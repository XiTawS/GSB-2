using GSB_2.DAO;
using GSB_2.Models;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GSB_2.Forms.Modal
{
    public partial class ModalEditMedicine : Form
    {
        private readonly int medicineId;

        public ModalEditMedicine(int idMedicine)
        {
            InitializeComponent();
            this.medicineId = idMedicine;
        }

        private void ModalEditMedicine_Load(object sender, EventArgs e)
        {
            ChargerUnites();
            ChargerMedicament();
        }

        private void ChargerUnites()
        {
            var unites = new[] { "mg", "ml", "g", "µg", "UI", "comprimés", "gouttes", "%" };
            comboBoxModalEditMedicineDosageMesure.Items.AddRange(unites);
            comboBoxModalEditMedicineDosageMesure.SelectedIndex = 0;
        }

        private void ChargerMedicament()
        {
            var dao = new MedicineDAO();
            var med = dao.GetById(medicineId);

            if (med == null)
            {
                MessageBox.Show("Médicament non trouvé.");
                this.Close();
                return;
            }

            textBoxModalEditMedicineName.Text = med.Name;
            textBoxModalEditMedicineMolecule.Text = med.Molecule;
            textBoxModalEditMedicineDescription.Text = med.Description ?? "";

            // Sépare "500 mg" → 500 et mg
            var match = Regex.Match(med.Dosage, @"^(\d+)\s*(.+)$");
            if (match.Success)
            {
                textBoxModalEditMedicineDosage.Text = match.Groups[1].Value;
                comboBoxModalEditMedicineDosageMesure.Text = match.Groups[2].Value.Trim();
            }
            else
            {
                textBoxModalEditMedicineDosage.Text = med.Dosage;
            }
        }

        private void buttonModalEditMedicineSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxModalEditMedicineName.Text))
            {
                MessageBox.Show("Le nom est obligatoire.");
                return;
            }

            string dosageTexte = textBoxModalEditMedicineDosage.Text.Trim();
            if (!int.TryParse(dosageTexte, out _))
            {
                MessageBox.Show("Le dosage doit être un nombre.");
                return;
            }

            string dosageComplet = $"{dosageTexte} {comboBoxModalEditMedicineDosageMesure.Text}";

            var med = new Medicine
            {
                IdMedicine = medicineId,
                Name = textBoxModalEditMedicineName.Text.Trim(),
                Dosage = dosageComplet,
                Molecule = textBoxModalEditMedicineMolecule.Text.Trim(),
                Description = textBoxModalEditMedicineDescription.Text.Trim()
            };

            if (new MedicineDAO().Update(med))
            {
                MessageBox.Show("Médicament modifié avec succès !");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Erreur lors de la sauvegarde.");
            }
        }

        private void buttonModalEditMedicineDelete_Click(object sender, EventArgs e)
        {
            // 1. On demande confirmation
            var resultat = MessageBox.Show(
                "Êtes-vous sûr de vouloir supprimer définitivement ce médicament ?\n\n" +
                $"Nom : {textBoxModalEditMedicineName.Text}\n" +
                $"Dosage : {textBoxModalEditMedicineDosage.Text} {comboBoxModalEditMedicineDosageMesure.Text}\n\n" +
                "Cette action est irréversible !",
                "Confirmer la suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (resultat != DialogResult.Yes)
                return;

            // 2. On supprime dans la base
            var dao = new MedicineDAO();
            bool supprime = dao.Delete(medicineId);

            // 3. On réagit selon le résultat
            if (supprime)
            {
                MessageBox.Show("Médicament supprimé avec succès !", "Supprimé",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Erreur lors de la suppression.\n" +
                                "Le médicament est peut-être déjà utilisé dans une ordonnance.",
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}