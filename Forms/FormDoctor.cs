using GSB_2.DAO;
using GSB_2.Models;
using GSB_2.Forms.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB_2.Forms
{
    public partial class FormDoctor : Form
    {
        public FormDoctor()
        {
            InitializeComponent();

            //Medicine
            MedicineDAO medDAO = new MedicineDAO();
            List<Medicine> medList = medDAO.GetAll();

            this.dataGridViewDoctorListMedicine.DataSource = medList;

            //Patient
            PatientDAO patientDAO = new PatientDAO();
            List<Patient> patientList = patientDAO.GetAll();

            this.dataGridViewDoctorListPatient.DataSource = patientList;

            //Prescription
            PrescriptionDAO prescriptionDAO = new PrescriptionDAO();
            List<Prescription> prescriptionList = prescriptionDAO.GetAll();


            this.dataGridViewDoctorListPrescription.DataSource = prescriptionList;
        }
        private void FormDoctor_Load(object sender, EventArgs e)
        {
        }

        private void buttonCreatePatient_Click(object sender, EventArgs e)
        {
            ModalCreatePatient ModalCreatePatient = new ModalCreatePatient();
            ModalCreatePatient.ShowDialog();
        }

        private void buttonCreatePrescription_Click(object sender, EventArgs e)
        {
            ModalCreatePrescription ModalCreatePrescription = new ModalCreatePrescription();
            ModalCreatePrescription.ShowDialog();
        }
    }
}
