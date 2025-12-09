// GSB_2/Forms/Modal/ModalDetailsPatient.cs
using GSB_2.DAO;
using GSB_2.Forms.Modal;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace GSB_2.Forms.Modal
{
    public partial class ModalDetailsPatient : Form
    {
        private readonly int patientId;
        private readonly Database db = new Database();

        private class OrdonnanceItem
        {
            public int Id { get; set; }
            public string Text { get; set; }

            public override string ToString() => Text;
        }

        public ModalDetailsPatient(int idPatient)
        {
            InitializeComponent();
            this.patientId = idPatient;
        }

        private void ModalDetailsPatient_Load(object sender, EventArgs e)
        {
            if (patientId <= 0)
            {
                MessageBox.Show("ID patient invalide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ChargerInformationsPatient();
            ChargerOrdonnancesDuPatient();
            RendreToutLectureSeule();

            // Active le double-clic sur la ListBox
            listBoxModalDetailsPatientListPrescription.DoubleClick += ListBoxOrdonnances_DoubleClick;
        }

        private void ChargerInformationsPatient()
        {
            string sql = "SELECT name, firstname, age, gender FROM Patient WHERE id_patient = @id";
            try
            {
                using var conn = db.GetConnection();
                conn.Open();
                using var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", patientId);

                using var r = cmd.ExecuteReader();
                if (r.Read())
                {
                    textBoxModalDetailsPatientFirstName.Text = r.GetString("firstname");
                    textBoxModalDetailsPatientName.Text = r.GetString("name");

                    int age = r.IsDBNull(r.GetOrdinal("age")) ? 0 : r.GetInt32("age");
                    comboBoxModalDetailsPatientAge.Text = age > 0 ? age.ToString() : "";

                    string gender = r.IsDBNull(r.GetOrdinal("gender")) ? "" : r.GetString("gender");
                    comboBoxModalDetailsPatientGender.Text = gender switch
                    {
                        "M" => "Masculin",
                        "F" => "Féminin",
                        _ => "Non précisé"
                    };

                    string fullName = $"{r.GetString("firstname")} {r.GetString("name")}".Trim();
                    label1.Text = $"Détails de : {fullName}";
                }
                else
                {
                    MessageBox.Show("Patient non trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement patient :\n" + ex.Message);
                this.Close();
            }
        }

        private void ChargerOrdonnancesDuPatient()
        {
            listBoxModalDetailsPatientListPrescription.Items.Clear();

            string sql = @"
                SELECT id_prescription, validity 
                FROM Prescription 
                WHERE id_patient = @id 
                ORDER BY validity DESC";

            try
            {
                using var conn = db.GetConnection();
                conn.Open();
                using var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", patientId);

                using var r = cmd.ExecuteReader();
                bool hasOrdo = false;

                while (r.Read())
                {
                    hasOrdo = true;
                    int idPrescription = r.GetInt32("id_prescription");
                    DateTime validity = r.GetDateTime("validity");

                    var item = new OrdonnanceItem
                    {
                        Id = idPrescription,
                        Text = $"Ordonnance N°{idPrescription} — Valable jusqu'au {validity:dd/MM/yyyy}"
                    };

                    listBoxModalDetailsPatientListPrescription.Items.Add(item);
                }

                if (!hasOrdo)
                    listBoxModalDetailsPatientListPrescription.Items.Add("Aucune ordonnance");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement ordonnances :\n" + ex.Message);
            }
        }

        // DOUBLE-CLIC → OUVRE LA MODAL DE MODIFICATION
        private void ListBoxOrdonnances_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxModalDetailsPatientListPrescription.SelectedItem is OrdonnanceItem item)
            {
                using var modal = new ModalEditPrescription(item.Id);
                if (modal.ShowDialog() == DialogResult.OK)
                {
                    ChargerOrdonnancesDuPatient(); // rafraîchit après modif/suppression
                }
            }
            // Si c'est le texte "Aucune ordonnance", on ne fait rien
        }

        private void RendreToutLectureSeule()
        {
            textBoxModalDetailsPatientName.ReadOnly = true;
            textBoxModalDetailsPatientFirstName.ReadOnly = true;
            comboBoxModalDetailsPatientAge.Enabled = false;
            comboBoxModalDetailsPatientGender.Enabled = false;

            Color fond = Color.FromArgb(240, 240, 240);
            textBoxModalDetailsPatientName.BackColor = fond;
            textBoxModalDetailsPatientFirstName.BackColor = fond;
            comboBoxModalDetailsPatientAge.BackColor = fond;
            comboBoxModalDetailsPatientGender.BackColor = fond;
        }

        private void buttonModalDetailsPatientBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonModalDetailsPatientModify_Click(object sender, EventArgs e)
        {
            using var modal = new ModalEditPatient(patientId);
            if (modal.ShowDialog() == DialogResult.OK)
            {
                ChargerInformationsPatient();
                ChargerOrdonnancesDuPatient();
            }
        }
    }
}