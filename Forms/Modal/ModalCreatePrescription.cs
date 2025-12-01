using GSB_2.DAO;
using GSB_2.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GSB_2.Forms.Modal
{
    public partial class ModalCreatePrescription : Form
    {
        private readonly Database db = new Database();

        // Dictionnaires pour retrouver l'ID à partir du texte affiché
        private Dictionary<string, int> patientIdParNom = new Dictionary<string, int>();
        private Dictionary<string, int> medicineIdParTexte = new Dictionary<string, int>();

        public ModalCreatePrescription()
        {
            InitializeComponent();
        }

        private void ModalCreatePrescription_Load(object sender, EventArgs e)
        {
            // 1. Afficher seulement la première ligne
            AfficherLigne(1);
            CacherLigne(2);
            CacherLigne(3);
            CacherLigne(4);
            CacherLigne(5);

            // 2. Charger les données (proprement)
            ChargerPatients_Propre();
            ChargerMedicaments_Propre();

            // 3. Valeur par défaut pour les quantités
            comboBoxPrescriptionMédicineQuantity1.Text = "1";
            comboBoxPrescriptionMédicineQuantity2.Text = "1";
            comboBoxPrescriptionMédicineQuantity3.Text = "1";
            comboBoxPrescriptionMédicineQuantity4.Text = "1";
            comboBoxPrescriptionMédicineQuantity5.Text = "1";

            // 4. Boutons "+"
            buttonPrescriptionAddMedicine1.Click += BoutonPlus_Click;
            buttonPrescriptionAddMedicine2.Click += BoutonPlus_Click;
            buttonPrescriptionAddMedicine3.Click += BoutonPlus_Click;
            buttonPrescriptionAddMedicine4.Click += BoutonPlus_Click;
        }

        private void AfficherLigne(int numero)
        {
            switch (numero)
            {
                case 1: comboBoxPrescriptionListMédicineName1.Visible = true; comboBoxPrescriptionMédicineQuantity1.Visible = true; buttonPrescriptionAddMedicine1.Visible = true; break;
                case 2: comboBoxPrescriptionListMédicineName2.Visible = true; comboBoxPrescriptionMédicineQuantity2.Visible = true; buttonPrescriptionAddMedicine2.Visible = true; break;
                case 3: comboBoxPrescriptionListMédicineName3.Visible = true; comboBoxPrescriptionMédicineQuantity3.Visible = true; buttonPrescriptionAddMedicine3.Visible = true; break;
                case 4: comboBoxPrescriptionListMédicineName4.Visible = true; comboBoxPrescriptionMédicineQuantity4.Visible = true; buttonPrescriptionAddMedicine4.Visible = true; break;
                case 5: comboBoxPrescriptionListMédicineName5.Visible = true; comboBoxPrescriptionMédicineQuantity5.Visible = true; break;
            }
        }

        private void CacherLigne(int numero)
        {
            switch (numero)
            {
                case 2: comboBoxPrescriptionListMédicineName2.Visible = false; comboBoxPrescriptionMédicineQuantity2.Visible = false; buttonPrescriptionAddMedicine2.Visible = false; break;
                case 3: comboBoxPrescriptionListMédicineName3.Visible = false; comboBoxPrescriptionMédicineQuantity3.Visible = false; buttonPrescriptionAddMedicine3.Visible = false; break;
                case 4: comboBoxPrescriptionListMédicineName4.Visible = false; comboBoxPrescriptionMédicineQuantity4.Visible = false; buttonPrescriptionAddMedicine4.Visible = false; break;
                case 5: comboBoxPrescriptionListMédicineName5.Visible = false; comboBoxPrescriptionMédicineQuantity5.Visible = false; break;
            }
        }

        private void BoutonPlus_Click(object sender, EventArgs e)
        {
            if (sender == buttonPrescriptionAddMedicine1) AfficherLigne(2);
            else if (sender == buttonPrescriptionAddMedicine2) AfficherLigne(3);
            else if (sender == buttonPrescriptionAddMedicine3) AfficherLigne(4);
            else if (sender == buttonPrescriptionAddMedicine4)
            {
                AfficherLigne(5);
                buttonPrescriptionAddMedicine4.Visible = false;
            }
        }

        // PATIENTS : on affiche seulement "Nom Prénom"
        private void ChargerPatients_Propre()
        {
            patientIdParNom.Clear();
            comboBoxPrescriptionListPatient.Items.Clear();

            int docteurId = 1; // plus tard : Session.UserId

            string sql = "SELECT id_patient, name, firstname FROM Patient WHERE id_user = @id ORDER BY name, firstname";

            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", docteurId);
                    using (MySqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            int id = r.GetInt32("id_patient");
                            string nomComplet = r.GetString("name") + " " + r.GetString("firstname");

                            comboBoxPrescriptionListPatient.Items.Add(nomComplet);
                            patientIdParNom[nomComplet] = id; // on garde l'ID en mémoire
                        }
                    }
                }
            }
        }

        // MÉDICAMENTS : on affiche seulement "Nom (dosage mg) - Molécule"
        private void ChargerMedicaments_Propre()
        {
            medicineIdParTexte.Clear();

            var combos = new[]
            {
                comboBoxPrescriptionListMédicineName1,
                comboBoxPrescriptionListMédicineName2,
                comboBoxPrescriptionListMédicineName3,
                comboBoxPrescriptionListMédicineName4,
                comboBoxPrescriptionListMédicineName5
            };

            foreach (var cb in combos)
            {
                cb.Items.Clear();
                cb.Items.Add(""); // ligne vide
            }

            string sql = "SELECT id_medicine, name, dosage, molecule FROM Medicine ORDER BY name";

            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                using (MySqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        int id = r.GetInt32("id_medicine");
                        string texte = $"{r.GetString("name")} ({r.GetInt32("dosage")} mg) - {r.GetString("molecule")}";

                        foreach (var cb in combos)
                        {
                            cb.Items.Add(texte);
                        }
                        medicineIdParTexte[texte] = id;
                    }
                }
            }
        }

        private void buttonCreatePrescription_Click(object sender, EventArgs e)
        {
            // Patient
            if (comboBoxPrescriptionListPatient.SelectedItem == null || string.IsNullOrWhiteSpace(comboBoxPrescriptionListPatient.Text))
            {
                MessageBox.Show("Veuillez sélectionner un patient.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id_patient = patientIdParNom[comboBoxPrescriptionListPatient.Text];

            // Date
            DateTime validity = monthCalendarPrescriptionValidity.SelectionEnd.Date;
            if (validity < DateTime.Today)
            {
                MessageBox.Show("La date doit être aujourd'hui ou dans le futur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Médicaments
            var medicaments = new List<(int id_med, int qty)>();

            void AjouterLigne(ComboBox comboMed, TextBox txtQty)
            {
                if (comboMed.Visible && comboMed.SelectedIndex > 0)
                {
                    string texteMed = comboMed.Text;
                    if (int.TryParse(txtQty.Text.Trim(), out int q) && q > 0 && medicineIdParTexte.ContainsKey(texteMed))
                    {
                        int id_med = medicineIdParTexte[texteMed];
                        medicaments.Add((id_med, q));
                    }
                }
            }

            AjouterLigne(comboBoxPrescriptionListMédicineName1, comboBoxPrescriptionMédicineQuantity1);
            AjouterLigne(comboBoxPrescriptionListMédicineName2, comboBoxPrescriptionMédicineQuantity2);
            AjouterLigne(comboBoxPrescriptionListMédicineName3, comboBoxPrescriptionMédicineQuantity3);
            AjouterLigne(comboBoxPrescriptionListMédicineName4, comboBoxPrescriptionMédicineQuantity4);
            AjouterLigne(comboBoxPrescriptionListMédicineName5, comboBoxPrescriptionMédicineQuantity5);

            if (medicaments.Count == 0)
            {
                MessageBox.Show("Ajoutez au moins un médicament avec une quantité.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Création
            try
            {
                int docteurId = User.Connected.Id;

                bool ok = new PrescriptionDAO().CreatePrescription(
                    id_user: docteurId,
                    id_patient: id_patient,
                    validity: validity,
                    medicines: medicaments
                );

                if (ok)
                {
                    MessageBox.Show("Ordonnance créée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Échec de la création.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}