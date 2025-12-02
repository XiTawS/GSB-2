using GSB_2.DAO;
using GSB_2.Models;
using System;
using System.Windows.Forms;

namespace GSB_2.Forms.Modal
{
    public partial class ModalEditPatient : Form
    {
        private readonly int patientId;

        public ModalEditPatient(int idPatient)
        {
            InitializeComponent();
            this.patientId = idPatient;
        }

        private void ModalEditPatient_Load(object sender, EventArgs e)
        {
            // Remplir les ComboBox
            for (int i = 1; i <= 150; i++)
            {
                comboBoxModalEditPatientAge.Items.Add(i.ToString());
            }

            comboBoxModalEditPatientGender.Items.Add("Masculin");
            comboBoxModalEditPatientGender.Items.Add("Féminin");

            // Charger les données du patient
            ChargerPatient();
        }

        private void ChargerPatient()
        {
            PatientDAO dao = new PatientDAO();
            Patient patient = dao.GetById(patientId);

            if (patient == null)
            {
                MessageBox.Show("Patient non trouvé !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            textBoxModalEditPatientName.Text = patient.Name;
            textBoxModalEditPatientFirstName.Text = patient.Firstname;
            comboBoxModalEditPatientAge.Text = patient.Age.ToString();

            // Conversion M/F → Masculin/Féminin
            if (patient.Gender == "M")
                comboBoxModalEditPatientGender.Text = "Masculin";
            else if (patient.Gender == "F")
                comboBoxModalEditPatientGender.Text = "Féminin";
        }

        private void buttonModalEditPatientSave_Click(object sender, EventArgs e)
        {
            string name = textBoxModalEditPatientName.Text.Trim();
            string firstname = textBoxModalEditPatientFirstName.Text.Trim();
            string ageText = comboBoxModalEditPatientAge.Text.Trim();
            string genderText = comboBoxModalEditPatientGender.Text.Trim();

            // Validation identique à ton Create
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(firstname) ||
                string.IsNullOrWhiteSpace(ageText) ||
                string.IsNullOrWhiteSpace(genderText))
            {
                MessageBox.Show("Tous les champs sont obligatoires !", "Attention",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(ageText, out int age) || age < 1 || age > 150)
            {
                MessageBox.Show("Âge invalide (1 à 150 ans).", "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (genderText != "Masculin" && genderText != "Féminin")
            {
                MessageBox.Show("Genre doit être Masculin ou Féminin.", "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string genderDB = genderText == "Masculin" ? "M" : "F";

            try
            {
                var patientModifie = new Patient(
                    patientId,
                    User.Connected.Id,      // id_user du docteur connecté
                    name,
                    age,
                    firstname,
                    genderDB
                );

                PatientDAO dao = new PatientDAO();
                bool success = dao.Update(patientModifie);

                if (success)
                {
                    MessageBox.Show("Patient modifié avec succès !", "Succès",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Échec de la modification du patient.", "Erreur",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Base de données",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonModalEditPatientDelete_Click(object sender, EventArgs e)
        {
            string nomComplet = $"{textBoxModalEditPatientFirstName.Text.Trim()} {textBoxModalEditPatientName.Text.Trim()}";

            var resultat = MessageBox.Show(
                $"Voulez-vous vraiment supprimer le patient ?\n\n{nomComplet}\n\nCette action est irréversible !",
                "Confirmer la suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (resultat != DialogResult.Yes) return;

            try
            {
                bool supprime = new PatientDAO().Delete(patientId);
                if (supprime)
                {
                    MessageBox.Show("Patient supprimé avec succès !", "Succès",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Impossible de supprimer : le patient a des ordonnances associées.", "Erreur",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}