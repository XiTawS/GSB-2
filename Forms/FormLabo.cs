// GSB_2/Forms/FormLabo.cs
using GSB_2.DAO;
using GSB_2.Models;
using GSB_2.Forms.Modal;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GSB_2.Forms
{
    public partial class FormLabo : Form
    {
        private List<Medicine> allMedicines = new();
        private List<User> allUsers = new();

        public FormLabo()
        {
            InitializeComponent();
        }

        private void FormLabo_Load(object sender, EventArgs e)
        {
            ConfigurerPlaceholders();
            RefreshAllGrids();
        }

        // PLACEHOLDERS (ne gênent jamais la recherche)
        private void ConfigurerPlaceholders()
        {
            ConfigurerPlaceholder(textBoxViewLaboSearchMedicine, "Rechercher un médicament...");
            ConfigurerPlaceholder(textBoxViewLaboSearchUser, "Rechercher un utilisateur...");
        }

        private void ConfigurerPlaceholder(TextBox tb, string placeholder)
        {
            tb.Tag = placeholder;
            tb.Text = placeholder;
            tb.ForeColor = Color.Gray;

            tb.GotFocus += (s, e) =>
            {
                if (tb.Text == (string)tb.Tag)
                {
                    tb.Text = "";
                    tb.ForeColor = SystemColors.WindowText;
                }
            };

            tb.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.Text = (string)tb.Tag;
                    tb.ForeColor = Color.Gray;
                }
                AppliquerFiltre(tb);
            };

            tb.TextChanged += (s, e) =>
            {
                if (tb.Text != (string)tb.Tag)
                {
                    AppliquerFiltre(tb);
                }
            };
        }

        // RAFRAÎCHISSEMENT GLOBAL
        private void RefreshAllGrids()
        {
            allMedicines = new MedicineDAO().GetAll();
            allUsers = new UserDAO().GetAll();

            AppliquerFiltre(textBoxViewLaboSearchMedicine);
            AppliquerFiltre(textBoxViewLaboSearchUser);
        }

        // FILTRE 100 % SÉCURISÉ (gère les valeurs null)
        private void AppliquerFiltre(TextBox tb)
        {
            string search = (tb.Text ?? "").Trim().ToLower();
            bool isPlaceholder = string.Equals(tb.Text, (string)tb.Tag, StringComparison.OrdinalIgnoreCase) ||
                                 string.IsNullOrWhiteSpace(tb.Text);

            if (tb == textBoxViewLaboSearchMedicine)
            {
                var result = isPlaceholder
                    ? allMedicines
                    : allMedicines.Where(m =>
                        (m.Name ?? "").ToLower().Contains(search) ||
                        (m.Dosage ?? "").ToLower().Contains(search) ||
                        (m.Molecule ?? "").ToLower().Contains(search)).ToList();

                dataGridViewLaboListMedicine.DataSource = null;
                dataGridViewLaboListMedicine.DataSource = result;
            }
            else if (tb == textBoxViewLaboSearchUser)
            {
                var result = isPlaceholder
                    ? allUsers
                    : allUsers.Where(u =>
                        (u.Name ?? "").ToLower().Contains(search) ||
                        (u.Firstname ?? "").ToLower().Contains(search) ||
                        (u.Email ?? "").ToLower().Contains(search) ||
                        $"{u.Firstname ?? ""} {u.Name ?? ""}".ToLower().Contains(search)).ToList();

                dataGridViewLaboListUser.DataSource = null;
                dataGridViewLaboListUser.DataSource = result;
            }
        }

        // RECHERCHE MÉDICAMENTS
        private void textBoxViewLaboSearchMedicine_TextChanged(object sender, EventArgs e)
        {
            AppliquerFiltre(textBoxViewLaboSearchMedicine);
        }

        // RECHERCHE UTILISATEURS
        private void textBoxViewLaboSearchUser_TextChanged(object sender, EventArgs e)
        {
            AppliquerFiltre(textBoxViewLaboSearchUser);
        }

        // DOUBLE-CLIC SÉCURISÉ (plus jamais de NullReferenceException)
        private void dataGridViewLaboListMedicine_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OuvrirEditionSiPossible(dataGridViewLaboListMedicine, "IdMedicine", id => new ModalEditMedicine(id));
        }

        private void dataGridViewLaboListUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OuvrirEditionSiPossible(dataGridViewLaboListUser, "Id", id => new ModalEditUser(id));
        }

        // Méthode générique = zéro bug
        private void OuvrirEditionSiPossible(DataGridView grid, string columnName, Func<int, Form> createModal)
        {
            if (grid.CurrentRow == null || grid.CurrentRow.Index < 0) return;

            var cell = grid.CurrentRow.Cells[columnName];
            if (cell?.Value == null) return;

            if (int.TryParse(cell.Value.ToString(), out int id))
            {
                using var modal = createModal(id);
                if (modal.ShowDialog() == DialogResult.OK)
                    RefreshAllGrids();
            }
        }

        // BOUTONS
        private void buttonCreateMedicine_Click(object sender, EventArgs e)
        {
            new ModalCreateMedicine().ShowDialog();
            RefreshAllGrids();
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            new ModalCreateUser().ShowDialog();
            RefreshAllGrids();
        }

        // DÉCONNEXION
        private void buttonViewLaboDeconnexion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment vous déconnecter ?", "Déconnexion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                User.Connected = null;
                var login = new FormLogin();
                login.Show();
                this.Hide();

                foreach (Form f in Application.OpenForms.Cast<Form>().ToList())
                    if (f != login) f.Close();
            }
        }
    }
}