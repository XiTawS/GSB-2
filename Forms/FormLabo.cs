using GSB_2.DAO;
using GSB_2.Models;
using GSB_2.Forms.Modal ;
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
    public partial class FormLabo : Form
    {
        public FormLabo()
        {
            InitializeComponent();
            MedicineDAO medDAO = new MedicineDAO();
            List<Medicine> medList = medDAO.GetAll();

            this.dataGridViewLaboListMedicine.DataSource = medList;

            //Medicine
            UserDAO userDAO = new UserDAO();
            List<User> userList = userDAO.GetAll();

            this.dataGridViewLaboListUser.DataSource = userList;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewDoctorListMedicine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonCreateMedicine_Click(object sender, EventArgs e)
        {
            ModalCreateMedicine ModalCreateMedicine = new ModalCreateMedicine();
            ModalCreateMedicine.ShowDialog();
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            ModalCreateUser ModalCreateUser = new ModalCreateUser();
            ModalCreateUser.ShowDialog();
        }
    }
}
