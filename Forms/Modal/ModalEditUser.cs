using GSB_2.DAO;
using GSB_2.Models;
using System;
using System.Windows.Forms;

namespace GSB_2.Forms.Modal
{
    public partial class ModalEditUser : Form
    {
        private readonly int userId;

        public ModalEditUser(int idUser)
        {
            InitializeComponent();
            this.userId = idUser;
        }

        private void ModalEditUser_Load(object sender, EventArgs e)
        {
            ChargerRolesDansComboBox();
            ChargerUtilisateur();
        }

        private void ChargerRolesDansComboBox()
        {
            comboBoxModalEditUserRole.Items.Clear();
            comboBoxModalEditUserRole.Items.Add("Docteur");
            comboBoxModalEditUserRole.Items.Add("Laboratoire");
            comboBoxModalEditUserRole.SelectedIndex = 0;
        }

        private void ChargerUtilisateur()
        {
            UserDAO userDao = new UserDAO();
            User? user = userDao.GetById(userId);

            if (user == null)
            {
                MessageBox.Show("Utilisateur non trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            textBoxModalEditUserName.Text = user.Name;
            textBoxModalEditUserFirstName.Text = user.Firstname;
            textBoxModalEditUserEmail.Text = user.Email;
            textBoxModalEditUserPassword.Text = "";
            textBoxModalEditUserPassword.PlaceholderText = "Laisser vide pour ne pas modifier";

            // Role : true = Laboratoire, false = Docteur
            comboBoxModalEditUserRole.SelectedItem = user.Role ? "Laboratoire" : "Docteur";
        }
        private void buttonModalEditUserSave_Click(object sender, EventArgs e)
        {
            // Validation des champs obligatoires
            if (string.IsNullOrWhiteSpace(textBoxModalEditUserName.Text) ||
                string.IsNullOrWhiteSpace(textBoxModalEditUserFirstName.Text) ||
                string.IsNullOrWhiteSpace(textBoxModalEditUserEmail.Text))
            {
                MessageBox.Show("Nom, prénom et email sont obligatoires.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = textBoxModalEditUserName.Text.Trim();
            string firstname = textBoxModalEditUserFirstName.Text.Trim();
            string email = textBoxModalEditUserEmail.Text.Trim();
            string password = textBoxModalEditUserPassword.Text.Trim();
            bool role = comboBoxModalEditUserRole.SelectedItem?.ToString() == "Laboratoire";

            try
            {
                UserDAO userDao = new UserDAO();

                // On envoie le mot de passe en clair → le DAO le hash
                bool success = userDao.Update(userId, name, firstname, email, password, role);

                if (success)
                {
                    MessageBox.Show("Utilisateur modifié avec succès !", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Échec de la modification.", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Base de données",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonModalEditUserDelete_Click(object sender, EventArgs e)
        {
            // 1. Récupère les infos pour un message clair
            string nomComplet = $"{textBoxModalEditUserFirstName.Text.Trim()} {textBoxModalEditUserName.Text.Trim()}".Trim();
            string roleTexte = comboBoxModalEditUserRole.SelectedItem?.ToString() ?? "Inconnu";

            // 2. Demande confirmation
            DialogResult resultat = MessageBox.Show(
                $"Êtes-vous ABSOLUMENT sûr de vouloir supprimer cet utilisateur ?\n\n" +
                $"• Nom complet : {nomComplet}\n" +
                $"• Email : {textBoxModalEditUserEmail.Text.Trim()}\n" +
                $"• Rôle : {roleTexte}\n\n" +
                $"Attention : cette action est irréversible !\n" +
                $"Toutes les données liées seront perdues.",
                "Confirmer la suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2); 

            if (resultat != DialogResult.Yes)
                return;

            // 3. Tentative de suppression via le DAO
            UserDAO userDao = new UserDAO();
            bool supprime = userDao.Delete(userId);

            if (supprime)
            {
                MessageBox.Show(
                    $"L'utilisateur {nomComplet} a été supprimé avec succès.",
                    "Supprimé",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close(); 
            }
            else
            {
                MessageBox.Show(
                    "Impossible de supprimer cet utilisateur.\n\n" +
                    "Raison probable : il a déjà créé des médicaments, des patients ou des ordonnances.\n" +
                    "Vous ne pouvez pas supprimer un utilisateur qui a des données associées.",
                    "Suppression bloquée",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}