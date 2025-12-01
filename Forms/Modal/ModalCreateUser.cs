using GSB_2.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB_2.Forms.Modal
{
    public partial class ModalCreateUser : Form
    {
        public ModalCreateUser()
        {
            InitializeComponent();
            Database db = new Database();
            try
            {
                var connection = db.GetConnection();
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            // Récupération et nettoyage
            string name = textBoxUserName.Text.Trim();
            string firstname = textBoxUserFirstname.Text.Trim();
            string email = textBoxUserEmail.Text.Trim();
            string password = textBoxUserPassword.Text;

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(firstname) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) ||
                comboBoxUserRole.SelectedItem == null)
            {
                MessageBox.Show("Tous les champs sont obligatoires !", "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // false = Docteur, true = Laboratoire
            bool role = comboBoxUserRole.SelectedItem.ToString() == "Laboratoire";

            try
            {
                UserDAO userDao = new UserDAO();
                bool success = userDao.CreateUser(name, firstname, email, password, role);

                if (success)
                {
                    MessageBox.Show("Utilisateur créé avec succès !", "Succès",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Échec de la création.", "Erreur",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Base de données",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            textBoxUserName.Clear();
            textBoxUserFirstname.Clear();
            textBoxUserEmail.Clear();
            textBoxUserPassword.Clear();
            comboBoxUserRole.SelectedIndex = -1;
        }
    }
}
