using GSB_2.DAO;
using GSB_2.Models;
using GSB_2.Forms.Modal;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GSB_2.Forms
{
    public partial class FormLabo : Form
    {
        public FormLabo()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            RefreshAllGrids();
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            RefreshAllGrids();
        }

        private void RefreshAllGrids()
        {
            // ── MÉDICAMENTS ──
            MedicineDAO medDAO = new MedicineDAO();
            List<Medicine> medList = medDAO.GetAll();
            dataGridViewLaboListMedicine.DataSource = null;
            dataGridViewLaboListMedicine.DataSource = medList;

            // ── UTILISATEURS (Laboratoire) ──
            UserDAO userDAO = new UserDAO();
            List<User> userList = userDAO.GetAll();
            dataGridViewLaboListUser.DataSource = null;
            dataGridViewLaboListUser.DataSource = userList;

        }


        private void buttonCreateMedicine_Click(object sender, EventArgs e)
        {
            new ModalCreateMedicine().ShowDialog();
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            new ModalCreateUser().ShowDialog();
        }

        private void dataGridViewLaboListMedicine_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dataGridViewLaboListMedicine.CurrentRow == null) return;

            int idMedicine = Convert.ToInt32(dataGridViewLaboListMedicine.CurrentRow.Cells["IdMedicine"].Value);
            new ModalEditMedicine(idMedicine).ShowDialog();
        }

        private void dataGridViewLaboListUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dataGridViewLaboListUser.CurrentRow == null) return;

            int idUser = Convert.ToInt32(dataGridViewLaboListUser.CurrentRow.Cells["Id"].Value);
            new ModalEditUser(idUser).ShowDialog();
        }

        private void buttonViewLaboDeconnexion_Click(object sender, EventArgs e)
        {
            DialogResult resultat = MessageBox.Show(
                "Voulez-vous vraiment vous déconnecter ?",
                "Déconnexion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (resultat != DialogResult.Yes)
                return;
            User.Connected = null;

            foreach (Form form in Application.OpenForms)
            {
                if (form is not FormLogin)
                {
                    form.Close();
                }
            }

            FormLogin loginForm = new FormLogin();
            loginForm.Show();

            this.Close();
        }
    }
}