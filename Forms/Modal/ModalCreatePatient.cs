using GSB_2.DAO;
using GSB_2.Models;
using MySqlX.XDevAPI;
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
    public partial class ModalCreatePatient : Form
    {
        public ModalCreatePatient()
        {
            InitializeComponent();
        }

        private void ModalCreatePatient_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 150; i++)
            {
                comboBoxPatientAge.Items.Add(i.ToString());
            }
        }

        private void buttonCreatePatient_Click(object sender, EventArgs e)
        {
            string name = textBoxPatientName.Text.Trim();
            string firstname = textBoxPatientFirstname.Text.Trim();
            string ageText = comboBoxPatientAge.Text.Trim();
            string genderDB = comboBoxPatientGender.Text.Trim();

            // Validation
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(firstname) ||
                string.IsNullOrWhiteSpace(ageText) ||
                string.IsNullOrWhiteSpace(genderDB))
            {
                MessageBox.Show("Tous les champs sont obligatoires !", "Attention",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(ageText, out int age) || age < 0 || age > 150)
            {
                MessageBox.Show("Âge invalide (0 à 150 ans).", "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (genderDB != "Masculin" && genderDB != "Féminin")
            {
                MessageBox.Show("Genre doit être Masculin ou Féminin.", "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string gender = genderDB == "Masculin" ? "M" : "F";

            try
            {
                // ID du docteur connecté qui créé le patient
                int docteurConnecteId = User.Connected.Id;

                PatientDAO patientDAO = new PatientDAO();
                bool success = patientDAO.CreatePatient(docteurConnecteId, name, firstname, age, gender);

                if (success)
                {
                    MessageBox.Show("Patient créé avec succès !", "Succès",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearPatientFields();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Échec de la création du patient.", "Erreur",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Base de données",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearPatientFields()
        {
            textBoxPatientName.Clear();
            textBoxPatientFirstname.Clear();
            comboBoxPatientAge.Text = "";
            comboBoxPatientGender.SelectedIndex = -1;
        }
    }
}
