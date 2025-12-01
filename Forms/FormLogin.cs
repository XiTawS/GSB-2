using GSB_2.DAO;
using GSB_2.Forms;
using GSB_2.Models;
using MySql.Data.MySqlClient;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace GSB_2
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            Database db = new Database();
            try
            {
                var connection = db.GetConnection();
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            string email = textBoxLoginEmail.Text.Trim();
            string password = textBoxLoginPassword.Text;

            SHA256 sha256 = SHA256.Create();
            byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(this.textBoxLoginPassword.Text));
            string hashedPassword = BitConverter.ToString(hashValue).Replace("-", "").ToLowerInvariant();
            // MessageBox.Show("Login: " + this.textBoxLoginEmail.Text + " Password : " + this.textBoxLoginPassword.Text + " Hash :" + hashedPassword);


            UserDAO userDao = new UserDAO();
            User? user = userDao.Login(email, hashedPassword);

            if (user != null && user.Role == true)
            {
                User.Connected = user;
                MessageBox.Show($"Bienvenue {user.Firstname} {user.Name} !", "Connexion réussie",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                FormLabo formAdmin = new FormLabo();
                formAdmin.ShowDialog();

            }
            else if (user != null && user.Role == false)
            {
                User.Connected = user;
                MessageBox.Show($"Bienvenue {user.Firstname} {user.Name} !", "Connexion réussie",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                FormDoctor formDoctor = new FormDoctor();
                formDoctor.ShowDialog();
            }
            else
            {
                MessageBox.Show("Email ou mot de passe incorrect.", "Échec de connexion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
