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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GSB_2.Forms.Modal
{
    public partial class ModalCreateMedicine : Form
    {
        public ModalCreateMedicine()
        {
            InitializeComponent();
        }

        private void ModalCreateMedicine_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreateMedicine_Click(object sender, EventArgs e)
        {
            // Récupération et nettoyage des champs
            string name = textBoxMedicineName.Text.Trim();
            string molecule = textBoxMedicineMolecule.Text.Trim();
            string dosageText = textBoxMedicineDosage.Text.Trim();
            string unite = comboBoxMedicineDosageMesure.SelectedItem?.ToString() ?? "mg";
            string description = textBoxMedicineDescription.Text.Trim();

            // Validation obligatoire
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Le nom du médicament est obligatoire.", "Attention",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxMedicineName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(molecule))
            {
                MessageBox.Show("La molécule est obligatoire.", "Attention",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxMedicineMolecule.Focus();
                return;
            }

            if (!int.TryParse(dosageText, out int dosage) || dosage <= 0)
            {
                MessageBox.Show("Veuillez saisir un dosage numérique valide.", "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxMedicineDosage.Focus();
                return;
            }

            string dosageComplet = $"{dosage} {unite}";

            try
            {
                // ID de l'user connecté
                int laboUserId = User.Connected.Id;

                MedicineDAO medicineDAO = new MedicineDAO();
                bool success = medicineDAO.CreateMedicine(laboUserId, name, molecule, dosageComplet, description);


                if (success)
                {
                    MessageBox.Show($"Médicament créé avec succès !\nID :", "Succès",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Échec de la création du médicament.", "Erreur",
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
            textBoxMedicineName.Clear();
            textBoxMedicineMolecule.Clear();
            textBoxMedicineDosage.Clear();
            textBoxMedicineDescription.Clear();
            comboBoxMedicineDosageMesure.SelectedIndex = 0;
            textBoxMedicineName.Focus();
        }
    }
}
