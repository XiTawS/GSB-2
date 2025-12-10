// GSB_2/Forms/FormDoctor.cs
using GSB_2.DAO;
using GSB_2.Models;
using GSB_2.Forms.Modal;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GSB_2.Forms
{
    public partial class FormDoctor : Form
    {
        // Listes complètes (en cache)
        private List<Medicine> allMedicines = new();
        private List<Patient> allPatients = new();
        private List<Prescription> allPrescriptions = new();

        public FormDoctor()
        {
            InitializeComponent();
        }

        private void FormDoctor_Load(object sender, EventArgs e)
        {
            ConfigurerPlaceholder(textBoxViewDoctorSearchMedicine, "Rechercher un médicament...");
            ConfigurerPlaceholder(textBoxViewDoctorSearchPatient, "Rechercher un patient...");
            ConfigurerPlaceholder(textBoxViewDoctorSearchPrescription, "Rechercher une ordonnance...");
            RefreshAllGrids();
        }

        // ── PLACEHOLDERS ─────────────────────

        private void ConfigurerPlaceholder(TextBox tb, string placeholder)
        {
            tb.Tag = placeholder;
            tb.Text = placeholder;
            tb.ForeColor = Color.Gray;

            // Quand on clique dedans
            tb.GotFocus += (s, e) =>
            {
                if (tb.Text == (string)tb.Tag)
                {
                    tb.Text = "";
                    tb.ForeColor = SystemColors.WindowText;
                }
            };

            // Quand on quitte le champ
            tb.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.Text = (string)tb.Tag;
                    tb.ForeColor = Color.Gray;
                }

                // ON FORCE LE RAFRAÎCHISSEMENT APRÈS LE PLACEHOLDER
                AppliquerFiltre(tb);
            };

            // Quand on tape
            tb.TextChanged += (s, e) =>
            {
                // On ne filtre QUE si ce n'est PAS le placeholder
                if (tb.Text != (string)tb.Tag)
                {
                    AppliquerFiltre(tb);
                }
            };
        }

        // Méthode unique qui gère TOUS les filtres
        private void AppliquerFiltre(TextBox tb)
        {
            string search = tb.Text.Trim().ToLower();

            // Si c'est le placeholder ou vide → on affiche TOUT
            bool isPlaceholder = tb.Text == (string)tb.Tag || string.IsNullOrWhiteSpace(tb.Text);

            if (tb == textBoxViewDoctorSearchMedicine)
            {
                var result = isPlaceholder
                    ? allMedicines
                    : allMedicines.Where(m =>
                        m.Name.ToLower().Contains(search) ||
                        m.Dosage.ToLower().Contains(search) ||
                        m.Molecule.ToLower().Contains(search)).ToList();

                dataGridViewDoctorListMedicine.DataSource = null;
                dataGridViewDoctorListMedicine.DataSource = result;
            }
            else if (tb == textBoxViewDoctorSearchPatient)
            {
                var result = isPlaceholder
                    ? allPatients
                    : allPatients.Where(p =>
                        p.Name.ToLower().Contains(search) ||
                        p.Firstname.ToLower().Contains(search) ||
                        $"{p.Name} {p.Firstname}".ToLower().Contains(search)).ToList();

                dataGridViewDoctorListPatient.DataSource = null;
                dataGridViewDoctorListPatient.DataSource = result;
            }
            else if (tb == textBoxViewDoctorSearchPrescription)
            {
                var result = isPlaceholder
                    ? allPrescriptions
                    : allPrescriptions.Where(p =>
                        p.IdPrescription.ToString().Contains(search) ||
                        p.Patient.ToLower().Contains(search) ||
                        p.Médecin.ToLower().Contains(search) ||
                        p.Médicaments.ToLower().Contains(search)).ToList();

                dataGridViewDoctorListPrescription.DataSource = null;
                dataGridViewDoctorListPrescription.DataSource = result;
            }
        }

        // ── RAFRAÎCHISSEMENT GLOBAL ───────────────────────────────────────────────
        private void RefreshAllGrids()
        {
            allMedicines = new MedicineDAO().GetAll();
            allPatients = new PatientDAO().GetAll();
            allPrescriptions = new PrescriptionDAO().GetAll();

            FiltrerMedicaments();
            FiltrerPatients();
            FiltrerOrdonnances();
        }

        // ── FILTRES ───────────────────────────────────────────────────────────────
        private void FiltrerMedicaments()
        {
            string search = textBoxViewDoctorSearchMedicine.Text.Trim().ToLower();
            var result = string.IsNullOrEmpty(search) || textBoxViewDoctorSearchMedicine.ForeColor == Color.Gray
                ? allMedicines
                : allMedicines.Where(m =>
                    m.Name.ToLower().Contains(search) ||
                    m.Dosage.ToLower().Contains(search) ||
                    m.Molecule.ToLower().Contains(search)).ToList();

            dataGridViewDoctorListMedicine.DataSource = null;
            dataGridViewDoctorListMedicine.DataSource = result;
        }

        private void FiltrerPatients()
        {
            string search = textBoxViewDoctorSearchPatient.Text.Trim().ToLower();
            var result = string.IsNullOrEmpty(search) || textBoxViewDoctorSearchPatient.ForeColor == Color.Gray
                ? allPatients
                : allPatients.Where(p =>
                    p.Name.ToLower().Contains(search) ||
                    p.Firstname.ToLower().Contains(search) ||
                    (p.Name + " " + p.Firstname).ToLower().Contains(search)).ToList();

            dataGridViewDoctorListPatient.DataSource = null;
            dataGridViewDoctorListPatient.DataSource = result;
        }

        private void FiltrerOrdonnances()
        {
            string search = textBoxViewDoctorSearchPrescription.Text.Trim().ToLower();
            var result = string.IsNullOrEmpty(search) || textBoxViewDoctorSearchPrescription.ForeColor == Color.Gray
                ? allPrescriptions
                : allPrescriptions.Where(p =>
                    p.IdPrescription.ToString().Contains(search) ||
                    p.Patient.ToLower().Contains(search) ||
                    p.Médecin.ToLower().Contains(search) ||
                    p.Validity.ToString("dd/MM/yyyy").Contains(search) ||
                    p.Médicaments.ToLower().Contains(search)).ToList();

            dataGridViewDoctorListPrescription.DataSource = null;
            dataGridViewDoctorListPrescription.DataSource = result;
        }

        // ── BOUTONS ───────────────────────────────────────────────────────────────
        private void buttonCreatePatient_Click(object sender, EventArgs e)
        {
            new ModalCreatePatient().ShowDialog();
            RefreshAllGrids();
        }

        private void buttonCreatePrescription_Click(object sender, EventArgs e)
        {
            new ModalCreatePrescription().ShowDialog();
            RefreshAllGrids();
        }

        // ── DOUBLE-CLIC ───────────────────────────────────────────────────────────
        private void DataGridViewDoctorListPatient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int idPatient = Convert.ToInt32(dataGridViewDoctorListPatient.Rows[e.RowIndex].Cells["IdPatient"].Value);
            new ModalDetailsPatient(idPatient).ShowDialog();
        }

        private void DataGridViewDoctorListPrescription_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int idPrescription = Convert.ToInt32(dataGridViewDoctorListPrescription.Rows[e.RowIndex].Cells["IdPrescription"].Value);
            using var modal = new ModalEditPrescription(idPrescription);
            if (modal.ShowDialog() == DialogResult.OK)
                RefreshAllGrids();
        }

        private void DataGridViewDoctorListMedicine_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int idMedicine = Convert.ToInt32(dataGridViewDoctorListMedicine.Rows[e.RowIndex].Cells["IdMedicine"].Value);
            new ModalReadMedicine(idMedicine).ShowDialog();
        }

        // ── DÉCONNEXION ───────────────────────────────────────────────────────────
        private void buttonViewDoctorDeconnexion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment vous déconnecter ?", "Déconnexion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                User.Connected = null;
                var login = new FormLogin();
                login.Show();
                this.Hide();

            }
        }

        // ── OPTIONNEL : Bouton Actualiser ────────────────────────────────────────
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshAllGrids();
        }
    }
}