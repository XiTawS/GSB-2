using GSB_2.DAO;
using GSB_2.Models;
using GSB_2.Forms.Modal;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GSB_2.Forms
{
    public partial class FormDoctor : Form
    {
        public FormDoctor()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            RefreshAllGrids();
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            RefreshAllGrids();
        }

        private void RefreshAllGrids()
        {
            // ── MÉDICAMENTS ──
            MedicineDAO medDAO = new MedicineDAO();
            List<Medicine> medList = medDAO.GetAll();
            dataGridViewDoctorListMedicine.DataSource = null;
            dataGridViewDoctorListMedicine.DataSource = medList;

            // ── PATIENTS ── 
            PatientDAO patientDAO = new PatientDAO();
            List<Patient> patientList = patientDAO.GetAll();
            dataGridViewDoctorListPatient.DataSource = null;
            dataGridViewDoctorListPatient.DataSource = patientList;

            // ── ORDONNANCES ──
            PrescriptionDAO prescriptionDAO = new PrescriptionDAO();
            List<Prescription> prescriptionList = prescriptionDAO.GetAll();
            dataGridViewDoctorListPrescription.DataSource = null;
            dataGridViewDoctorListPrescription.DataSource = prescriptionList;
        }

        private void buttonCreatePatient_Click(object sender, EventArgs e)
        {
            new ModalCreatePatient().ShowDialog();
        }

        private void buttonCreatePrescription_Click(object sender, EventArgs e)
        {
            new ModalCreatePrescription().ShowDialog();
        }

        private void dataGridViewDoctorListPatient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dataGridViewDoctorListPatient.CurrentRow == null) return;

            int idPatient = Convert.ToInt32(dataGridViewDoctorListPatient.CurrentRow.Cells["IdPatient"].Value);
            new ModalEditPatient(idPatient).ShowDialog();
        }

        private void dataGridViewDoctorListPrescription_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dataGridViewDoctorListPrescription.CurrentRow == null) return;

            int idPrescription = Convert.ToInt32(dataGridViewDoctorListPrescription.CurrentRow.Cells["IdPrescription"].Value);
            new ModalEditPrescription(idPrescription).ShowDialog();
        }

        private void dataGridViewDoctorListMedicine_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dataGridViewDoctorListMedicine.CurrentRow == null) return;

            int IdMedicine = Convert.ToInt32(dataGridViewDoctorListMedicine.CurrentRow.Cells["IdMedicine"].Value);
            new ModalReadMedicine(IdMedicine).ShowDialog();
        }

        // ── DÉCONNEXION ── 
        private void buttonViewDoctorDeconnexion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment vous déconnecter ?", "Déconnexion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                User.Connected = null;

                FormLogin login = new FormLogin();
                login.Show();

                foreach (Form f in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (f != login)
                        f.Close();
                }
            }
        }
    }
}