namespace GSB_2.Forms.Modal
{
    partial class ModalCreateUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxUserEmail = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBoxUserRole = new ComboBox();
            textBoxUserPassword = new TextBox();
            label4 = new Label();
            textBoxUserFirstname = new TextBox();
            label5 = new Label();
            textBoxUserName = new TextBox();
            label6 = new Label();
            buttonCreateUser = new Button();
            SuspendLayout();
            // 
            // textBoxUserEmail
            // 
            textBoxUserEmail.Location = new Point(28, 164);
            textBoxUserEmail.Name = "textBoxUserEmail";
            textBoxUserEmail.Size = new Size(231, 27);
            textBoxUserEmail.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 279);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 13;
            label3.Text = "Rôle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 141);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 12;
            label2.Text = "E-mail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(109, 21);
            label1.Name = "label1";
            label1.Size = new Size(231, 28);
            label1.TabIndex = 11;
            label1.Text = "Création d'un utilisateur";
            // 
            // comboBoxUserRole
            // 
            comboBoxUserRole.FormattingEnabled = true;
            comboBoxUserRole.Items.AddRange(new object[] { "Médecin", "Laboratoire" });
            comboBoxUserRole.Location = new Point(28, 302);
            comboBoxUserRole.Name = "comboBoxUserRole";
            comboBoxUserRole.Size = new Size(161, 28);
            comboBoxUserRole.TabIndex = 19;
            // 
            // textBoxUserPassword
            // 
            textBoxUserPassword.Location = new Point(28, 233);
            textBoxUserPassword.Name = "textBoxUserPassword";
            textBoxUserPassword.Size = new Size(231, 27);
            textBoxUserPassword.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 210);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 20;
            label4.Text = "Mot de passe";
            // 
            // textBoxUserFirstname
            // 
            textBoxUserFirstname.Location = new Point(28, 93);
            textBoxUserFirstname.Name = "textBoxUserFirstname";
            textBoxUserFirstname.Size = new Size(161, 27);
            textBoxUserFirstname.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 70);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 22;
            label5.Text = "Prénom";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(223, 93);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(161, 27);
            textBoxUserName.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(223, 70);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 24;
            label6.Text = "Nom de famille";
            // 
            // buttonCreateUser
            // 
            buttonCreateUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCreateUser.Location = new Point(121, 364);
            buttonCreateUser.Name = "buttonCreateUser";
            buttonCreateUser.Size = new Size(203, 37);
            buttonCreateUser.TabIndex = 26;
            buttonCreateUser.Text = "Créer un utilisateur";
            buttonCreateUser.UseVisualStyleBackColor = true;
            buttonCreateUser.Click += buttonCreateUser_Click;
            // 
            // ModalCreateUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 413);
            Controls.Add(buttonCreateUser);
            Controls.Add(textBoxUserName);
            Controls.Add(label6);
            Controls.Add(textBoxUserFirstname);
            Controls.Add(label5);
            Controls.Add(textBoxUserPassword);
            Controls.Add(label4);
            Controls.Add(comboBoxUserRole);
            Controls.Add(textBoxUserEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ModalCreateUser";
            Text = "ModalCreateUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUserEmail;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxUserRole;
        private TextBox textBoxUserPassword;
        private Label label4;
        private TextBox textBoxUserFirstname;
        private Label label5;
        private TextBox textBoxUserName;
        private Label label6;
        private Button buttonCreateUser;
    }
}