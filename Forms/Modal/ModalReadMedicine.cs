using GSB_2.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace GSB_2.Forms.Modal
{
    public partial class ModalReadMedicine : Form
    {
        private readonly int IdMedicine;
        private readonly Database db = new Database();

        public ModalReadMedicine(int IdMedicine)
        {
            InitializeComponent();
            this.IdMedicine = IdMedicine;
        }

        private void ModalReadMedicine_Load(object sender, EventArgs e)
        {
            ChargerMedicament();
            RemplirUniteDosage();
            RendreToutLectureSeule();
        }

        private void ChargerMedicament()
        {
            string sql = @"
                SELECT name, dosage, molecule, description 
                FROM Medicine 
                WHERE id_medicine = @id";

            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", IdMedicine);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBoxModalReadMedicineName.Text = reader.GetString("name");
                            textBoxModalReadMedicineMolécule.Text = reader.GetString("molecule");

                            string dosageComplet = reader.GetString("dosage");
                            // Ex: "500 mg" → on sépare le nombre et l'unité
                            SeparerDosageEtUnite(dosageComplet);

                            textBoxModalReadMedicineDescription.Text = reader.IsDBNull("description")
                                ? "Aucune description disponible."
                                : reader.GetString("description");
                        }
                        else
                        {
                            MessageBox.Show("Médicament non trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                    }
                }
            }
        }

        private void SeparerDosageEtUnite(string dosageComplet)
        {
            // Exemples acceptés : "500 mg", "100 UI/ml", "10 ml", "1 g", "250mg", "5ml"
            var match = System.Text.RegularExpressions.Regex.Match(dosageComplet.Trim(), @"^([\d.,\s]+)\s*([a-zA-Z%/]+)$");
            if (match.Success)
            {
                textBoxModalReadMedicineDosage.Text = match.Groups[1].Value.Trim();     // "500" ou "100" ou "10"
                comboBoxModalReadMedicineDosageMesure.Text = match.Groups[2].Value.Trim(); // "mg" ou "UI/ml" ou "ml"
            }
            else
            {
                // Si le format est bizarre, on met tout dans le TextBox
                textBoxModalReadMedicineDosage.Text = dosageComplet;
                comboBoxModalReadMedicineDosageMesure.Text = "";
            }
        }

        private void RemplirUniteDosage()
        {
            comboBoxModalReadMedicineDosageMesure.Items.Clear();
            string[] unites = { "mg", "g", "µg", "ml", "UI", "UI/ml", "%", "comprimés", "gélules", "suppositoires" };
            comboBoxModalReadMedicineDosageMesure.Items.AddRange(unites);
        }

        private void RendreToutLectureSeule()
        {
            textBoxModalReadMedicineName.ReadOnly = true;
            textBoxModalReadMedicineDosage.ReadOnly = true;
            textBoxModalReadMedicineMolécule.ReadOnly = true;
            textBoxModalReadMedicineDescription.ReadOnly = true;
            comboBoxModalReadMedicineDosageMesure.Enabled = false;

            // Fond gris clair pour bien montrer que c’est en lecture
            Color fondLecture = Color.FromArgb(240, 240, 240);
            textBoxModalReadMedicineName.BackColor = fondLecture;
            textBoxModalReadMedicineDosage.BackColor = fondLecture;
            textBoxModalReadMedicineMolécule.BackColor = fondLecture;
            textBoxModalReadMedicineDescription.BackColor = fondLecture;
            comboBoxModalReadMedicineDosageMesure.BackColor = fondLecture;
        }

        private void buttonModalReadMedicineBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}