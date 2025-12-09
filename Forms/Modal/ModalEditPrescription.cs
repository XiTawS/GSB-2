// GSB_2/Forms/Modal/ModalEditPrescription.cs
using GSB_2.DAO;
using GSB_2.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GSB_2.Forms.Modal
{
    public partial class ModalEditPrescription : Form
    {
        private readonly int prescriptionId;
        private readonly PrescriptionDAO dao = new PrescriptionDAO();
        private readonly Database db = new Database();

        private readonly Dictionary<string, int> patients = new();
        private readonly Dictionary<string, int> medicines = new();

        public ModalEditPrescription(int idPrescription)
        {
            InitializeComponent();
            this.prescriptionId = idPrescription;
        }

        private void ModalEditPrescription_Load(object sender, EventArgs e)
        {
            this.Text = $"Modifier l'ordonnance N°{prescriptionId}";

            ChargerPatients();
            ChargerMedicaments();
            ChargerPrescriptionComplete();

            // Boutons "+"
            buttonModalEditPrescriptionAddMedicine1.Click += (_, __) => AfficherLigne(2);
            buttonModalEditPrescriptionAddMedicine2.Click += (_, __) => AfficherLigne(3);
            buttonModalEditPrescriptionAddMedicine3.Click += (_, __) => AfficherLigne(4);
            buttonModalEditPrescriptionAddMedicine4.Click += (_, __) =>
            {
                AfficherLigne(5);
                buttonModalEditPrescriptionAddMedicine4.Visible = false;
            };

            // ON AFFICHE TOUTES LES LIGNES DÈS LE DÉBUT
            AfficherToutesLesLignes();
        }

        private void ChargerPatients()
        {
            patients.Clear();
            comboBoxModalEditPrescriptionListPatient.Items.Clear();
            using var conn = db.GetConnection();
            conn.Open();
            using var cmd = new MySqlCommand("SELECT id_patient, name, firstname FROM Patient ORDER BY name", conn);
            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                string nom = $"{r.GetString("name")} {r.GetString("firstname")}".Trim();
                patients[nom] = r.GetInt32("id_patient");
                comboBoxModalEditPrescriptionListPatient.Items.Add(nom);
            }
        }

        private void ChargerMedicaments()
        {
            medicines.Clear();
            var combos = new[]
            {
                comboBoxModalEditPrescriptionListMédicineName1,
                comboBoxModalEditPrescriptionListMédicineName2,
                comboBoxModalEditPrescriptionListMédicineName3,
                comboBoxModalEditPrescriptionListMédicineName4,
                comboBoxModalEditPrescriptionListMédicineName5
            };

            foreach (var cb in combos)
            {
                cb.Items.Clear();
                cb.Items.Add(""); // ligne vide
            }

            using var conn = db.GetConnection();
            conn.Open();
            using var cmd = new MySqlCommand("SELECT id_medicine, name, dosage, molecule FROM Medicine ORDER BY name", conn);
            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                string txt = $"{r.GetString("name")} ({r.GetString("dosage")}) - {r.GetString("molecule")}";
                int id = r.GetInt32("id_medicine");
                foreach (var cb in combos) cb.Items.Add(txt);
                medicines[txt] = id;
            }
        }

        // VERSION QUI MARCHE À 100% : toutes les lignes visibles + remplissage propre
        private void ChargerPrescriptionComplete()
        {
            string sql = @"
                SELECT 
                    p.validity,
                    TRIM(CONCAT(pat.name, ' ', pat.firstname)) AS patient_nom,
                    m.name AS med_name,
                    m.dosage,
                    m.molecule,
                    COALESCE(a.quantity, 0) AS quantity
                FROM Prescription p
                JOIN Patient pat ON p.id_patient = pat.id_patient
                LEFT JOIN Appartient a ON p.id_prescription = a.id_prescription
                LEFT JOIN Medicine m ON a.id_medicine = m.id_medicine
                WHERE p.id_prescription = @id
                ORDER BY a.id_medicine";

            using var conn = db.GetConnection();
            conn.Open();
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", prescriptionId);
            using var r = cmd.ExecuteReader();

            var nameBoxes = new[]
            {
                comboBoxModalEditPrescriptionListMédicineName1,
                comboBoxModalEditPrescriptionListMédicineName2,
                comboBoxModalEditPrescriptionListMédicineName3,
                comboBoxModalEditPrescriptionListMédicineName4,
                comboBoxModalEditPrescriptionListMédicineName5
            };

            var qtyBoxes = new[]
            {
                comboBoxModalEditPrescriptionMédicineQuantity1,
                comboBoxModalEditPrescriptionMédicineQuantity2,
                comboBoxModalEditPrescriptionMédicineQuantity3,
                comboBoxModalEditPrescriptionMédicineQuantity4,
                comboBoxModalEditPrescriptionMédicineQuantity5
            };

            // Réinitialiser toutes les lignes
            for (int i = 0; i < 5; i++)
            {
                nameBoxes[i].Text = "";
                qtyBoxes[i].Text = "1";
            }

            bool first = true;
            int index = 0;

            while (r.Read())
            {
                // Première ligne = patient + date
                if (first)
                {
                    monthCalendarModalEditPrescriptionValidity.SelectionStart = r.GetDateTime("validity");
                    monthCalendarModalEditPrescriptionValidity.SelectionEnd = r.GetDateTime("validity");

                    string patient = r["patient_nom"]?.ToString()?.Trim() ?? "";
                    if (!string.IsNullOrEmpty(patient))
                    {
                        if (comboBoxModalEditPrescriptionListPatient.Items.Contains(patient))
                            comboBoxModalEditPrescriptionListPatient.SelectedItem = patient;
                        else
                            comboBoxModalEditPrescriptionListPatient.Text = patient;
                    }
                    first = false;
                }

                // Si un médicament existe → on le met dans la ligne correspondante
                string medName = r["med_name"]?.ToString() ?? "";
                if (!string.IsNullOrEmpty(medName) && index < 5)
                {
                    string texte = $"{medName} ({r["dosage"]}) - {r["molecule"]}";
                    int qty = Convert.ToInt32(r["quantity"]);

                    nameBoxes[index].Text = texte;
                    qtyBoxes[index].Text = qty.ToString();
                    index++;
                }
            }
        }

        private void AfficherToutesLesLignes()
        {
            comboBoxModalEditPrescriptionListMédicineName2.Visible = true;
            comboBoxModalEditPrescriptionMédicineQuantity2.Visible = true;
            buttonModalEditPrescriptionAddMedicine2.Visible = true;

            comboBoxModalEditPrescriptionListMédicineName3.Visible = true;
            comboBoxModalEditPrescriptionMédicineQuantity3.Visible = true;
            buttonModalEditPrescriptionAddMedicine3.Visible = true;

            comboBoxModalEditPrescriptionListMédicineName4.Visible = true;
            comboBoxModalEditPrescriptionMédicineQuantity4.Visible = true;
            buttonModalEditPrescriptionAddMedicine4.Visible = true;

            comboBoxModalEditPrescriptionListMédicineName5.Visible = true;
            comboBoxModalEditPrescriptionMédicineQuantity5.Visible = true;
        }

        private void AfficherLigne(int ligne)
        {
            // Plus besoin de cacher/afficher, tout est déjà visible
            // Le bouton + sert juste à indiquer qu’on peut en ajouter plus
            if (ligne == 5)
                buttonModalEditPrescriptionAddMedicine4.Visible = false;
        }

        private void buttonModalEditPrescriptionSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!patients.TryGetValue(comboBoxModalEditPrescriptionListPatient.Text.Trim(), out int idPatient))
                {
                    MessageBox.Show("Veuillez sélectionner un patient valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime validity = monthCalendarModalEditPrescriptionValidity.SelectionEnd.Date;

                var meds = new Dictionary<int, int>();

                var names = new[]
                {
                    comboBoxModalEditPrescriptionListMédicineName1.Text.Trim(),
                    comboBoxModalEditPrescriptionListMédicineName2.Text.Trim(),
                    comboBoxModalEditPrescriptionListMédicineName3.Text.Trim(),
                    comboBoxModalEditPrescriptionListMédicineName4.Text.Trim(),
                    comboBoxModalEditPrescriptionListMédicineName5.Text.Trim()
                };

                var qtys = new[]
                {
                    comboBoxModalEditPrescriptionMédicineQuantity1.Text,
                    comboBoxModalEditPrescriptionMédicineQuantity2.Text,
                    comboBoxModalEditPrescriptionMédicineQuantity3.Text,
                    comboBoxModalEditPrescriptionMédicineQuantity4.Text,
                    comboBoxModalEditPrescriptionMédicineQuantity5.Text
                };

                for (int i = 0; i < 5; i++)
                {
                    if (string.IsNullOrEmpty(names[i])) continue;
                    if (!medicines.TryGetValue(names[i], out int idMed)) continue;
                    if (!int.TryParse(qtys[i], out int q) || q <= 0) continue;

                    meds[idMed] = q;
                }

                if (dao.UpdatePrescription(prescriptionId, idPatient, validity, meds))
                {
                    MessageBox.Show("Ordonnance modifiée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Échec de la modification.", "Erreur");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void buttonModalEditPrescriptionDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Supprimer cette ordonnance ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dao.DeletePrescription(prescriptionId))
                {
                    MessageBox.Show("Ordonnance supprimée.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }
    }
}