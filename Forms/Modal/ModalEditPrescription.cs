using GSB_2.DAO;
using GSB_2.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GSB_2.Forms.Modal
{
    public partial class ModalEditPrescription : Form
    {
        private readonly int prescriptionId;

        public ModalEditPrescription(int idPrescription)
        {
            InitializeComponent();
            this.prescriptionId = idPrescription;
        }

        private void ModalEditPrescription_Load(object sender, EventArgs e)
        {

        }

        private void buttonModalEditPrescriptionSave_Click(object sender, EventArgs e)
        {
    
        }

        private void buttonModalEditPrescriptionDelete_Click(object sender, EventArgs e)
        {
            
        }
    }
}