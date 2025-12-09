// GSB_2/Forms/Modal/ModalCreatePrescription.cs
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
        private readonly PrescriptionDAO dao = new PrescriptionDAO();

        private readonly Dictionary<string, int> patients = new();
        private readonly Dictionary<string, int> medicines = new();

        public ModalCreatePrescription()
        {
            InitializeComponent();
        }

        private void ModalCreatePrescription_Load(object sender, EventArgs e)
        {
            monthCalendarPrescriptionValidity.SelectionStart = DateTime.Today;
            monthCalendarPrescriptionValidity.SelectionEnd = DateTime.Today;

            ChargerPatients();
            ChargerMedicaments();

            // Quantités par défaut
            comboBoxPrescriptionMédicineQuantity1.Text = "1";
            comboBoxPrescriptionMédicineQuantity2.Text = "1";
            comboBoxPrescriptionMédicineQuantity3.Text = "1";
            comboBoxPrescriptionMédicineQuantity4.Text = "1";
            comboBoxPrescriptionMédicineQuantity5.Text = "1";

            // Boutons +
            buttonPrescriptionAddMedicine1.Click += (_, __) => AfficherLigne(2);
            buttonPrescriptionAddMedicine2.Click += (_, __) => AfficherLigne(3);
            buttonPrescriptionAddMedicine3.Click += (_, __) => AfficherLigne(4);
            buttonPrescriptionAddMedicine4.Click += (_, __) =>
            {
                AfficherLigne(5);
                buttonPrescriptionAddMedicine4.Visible = false;
            };

            // On cache toutes les lignes sauf la première
            CacherLignes(2, 3, 4, 5);
        }

        private void ChargerPatients()
        {
            patients.Clear();
            comboBoxPrescriptionListPatient.Items.Clear();

            string sql = "SELECT id_patient, name, firstname FROM Patient ORDER BY name, firstname";
            // Décommente la ligne ci-dessous si tu veux filtrer par médecin connecté
            // string sql = "SELECT id_patient, name, firstname FROM Patient WHERE id_user = @id_user ORDER BY name, firstname";

            try
            {
                using var conn = db.GetConnection();
                conn.Open();
                using var cmd = new MySqlCommand(sql, conn);
                // cmd.Parameters.AddWithValue("@id_user", User.Connected.Id); // si tu filtres

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string nom = $"{reader.GetString("name")} {reader.GetString("firstname")}";
                    int id = reader.GetInt32("id_patient");
                    comboBoxPrescriptionListPatient.Items.Add(nom);
                    patients[nom] = id;
                }

                if (comboBoxPrescriptionListPatient.Items.Count > 0)
                    comboBoxPrescriptionListPatient.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement patients :\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChargerMedicaments()
        {
            medicines.Clear();
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
                cb.Items.Add(""); // ligne vide pour pouvoir effacer
            }

            try
            {
                using var conn = db.GetConnection();
                conn.Open();
                using var cmd = new MySqlCommand("SELECT id_medicine, name, dosage, molecule FROM Medicine ORDER BY name", conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string texte = $"{reader.GetString("name")} ({reader.GetString("dosage")}) - {reader.GetString("molecule")}";
                    int id = reader.GetInt32("id_medicine");
                    foreach (var cb in combos)
                        cb.Items.Add(texte);
                    medicines[texte] = id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement médicaments :\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AfficherLigne(int numero)
        {
            switch (numero)
            {
                case 2:
                    comboBoxPrescriptionListMédicineName2.Visible = true;
                    comboBoxPrescriptionMédicineQuantity2.Visible = true;
                    buttonPrescriptionAddMedicine2.Visible = true;
                    break;
                case 3:
                    comboBoxPrescriptionListMédicineName3.Visible = true;
                    comboBoxPrescriptionMédicineQuantity3.Visible = true;
                    buttonPrescriptionAddMedicine3.Visible = true;
                    break;
                case 4:
                    comboBoxPrescriptionListMédicineName4.Visible = true;
                    comboBoxPrescriptionMédicineQuantity4.Visible = true;
                    buttonPrescriptionAddMedicine4.Visible = true;
                    break;
                case 5:
                    comboBoxPrescriptionListMédicineName5.Visible = true;
                    comboBoxPrescriptionMédicineQuantity5.Visible = true;
                    break;
            }
        }

        private void CacherLignes(params int[] numeros)
        {
            foreach (int n in numeros)
            {
                switch (n)
                {
                    case 2:
                        comboBoxPrescriptionListMédicineName2.Visible = false;
                        comboBoxPrescriptionMédicineQuantity2.Visible = false;
                        buttonPrescriptionAddMedicine2.Visible = false;
                        comboBoxPrescriptionListMédicineName2.Text = "";
                        comboBoxPrescriptionMédicineQuantity2.Text = "1";
                        break;
                    case 3:
                        comboBoxPrescriptionListMédicineName3.Visible = false;
                        comboBoxPrescriptionMédicineQuantity3.Visible = false;
                        buttonPrescriptionAddMedicine3.Visible = false;
                        comboBoxPrescriptionListMédicineName3.Text = "";
                        comboBoxPrescriptionMédicineQuantity3.Text = "1";
                        break;
                    case 4:
                        comboBoxPrescriptionListMédicineName4.Visible = false;
                        comboBoxPrescriptionMédicineQuantity4.Visible = false;
                        buttonPrescriptionAddMedicine4.Visible = false;
                        comboBoxPrescriptionListMédicineName4.Text = "";
                        comboBoxPrescriptionMédicineQuantity4.Text = "1";
                        break;
                    case 5:
                        comboBoxPrescriptionListMédicineName5.Visible = false;
                        comboBoxPrescriptionMédicineQuantity5.Visible = false;
                        comboBoxPrescriptionListMédicineName5.Text = "";
                        comboBoxPrescriptionMédicineQuantity5.Text = "1";
                        break;
                }
            }
        }

        private void buttonCreatePrescription_Click(object sender, EventArgs e)
        {
            try
            {
                // Patient
                if (string.IsNullOrWhiteSpace(comboBoxPrescriptionListPatient.Text) ||
                    !patients.TryGetValue(comboBoxPrescriptionListPatient.Text.Trim(), out int idPatient))
                {
                    MessageBox.Show("Veuillez sélectionner un patient valide dans la liste.", "Patient requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Date
                DateTime validity = monthCalendarPrescriptionValidity.SelectionEnd.Date;
                if (validity < DateTime.Today)
                {
                    MessageBox.Show("La date de validité doit être aujourd'hui ou dans le futur.", "Date invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Médicaments
                var meds = new Dictionary<int, int>();

                void AjouterSiValide(ComboBox cbName, TextBox tbQty)
                {
                    if (!cbName.Visible) return;
                    string texte = cbName.Text.Trim();
                    if (string.IsNullOrEmpty(texte)) return;

                    if (!medicines.TryGetValue(texte, out int idMed))
                    {
                        MessageBox.Show($"Médicament non reconnu : {texte}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!int.TryParse(tbQty.Text, out int qty) || qty <= 0)
                    {
                        MessageBox.Show($"Quantité invalide pour {texte}. Entrez un nombre positif.", "Quantité", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbQty.Focus();
                        throw new InvalidOperationException("Quantité invalide");
                    }

                    meds[idMed] = meds.GetValueOrDefault(idMed) + qty;
                }

                AjouterSiValide(comboBoxPrescriptionListMédicineName1, comboBoxPrescriptionMédicineQuantity1);
                AjouterSiValide(comboBoxPrescriptionListMédicineName2, comboBoxPrescriptionMédicineQuantity2);
                AjouterSiValide(comboBoxPrescriptionListMédicineName3, comboBoxPrescriptionMédicineQuantity3);
                AjouterSiValide(comboBoxPrescriptionListMédicineName4, comboBoxPrescriptionMédicineQuantity4);
                AjouterSiValide(comboBoxPrescriptionListMédicineName5, comboBoxPrescriptionMédicineQuantity5);

                if (meds.Count == 0)
                {
                    MessageBox.Show("Veuillez ajouter au moins un médicament avec une quantité valide.", "Médicaments manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Création
                var prescription = new Prescription(User.Connected.Id, idPatient, validity);

                if (dao.Create(prescription, meds))
                {
                    MessageBox.Show("Ordonnance créée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Échec de la création de l'ordonnance.\n\nVérifiez votre connexion à la base de données.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException mysqlEx)
            {
                MessageBox.Show($"Erreur base de données :\n{mysqlEx.Message}\n\nCode : {mysqlEx.Number}", "Erreur MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur inattendue :\n{ex.Message}\n\nDétails techniques :\n{ex.StackTrace}", "Erreur critique", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}