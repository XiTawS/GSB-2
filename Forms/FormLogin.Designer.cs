namespace GSB_2
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonLogin = new Button();
            textBoxLoginEmail = new TextBox();
            textBoxLoginPassword = new TextBox();
            labelEmail = new Label();
            labelPassword = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(194, 243);
            buttonLogin.Margin = new Padding(2);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(172, 42);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxLoginEmail
            // 
            textBoxLoginEmail.Location = new Point(114, 107);
            textBoxLoginEmail.Margin = new Padding(2);
            textBoxLoginEmail.Name = "textBoxLoginEmail";
            textBoxLoginEmail.Size = new Size(362, 27);
            textBoxLoginEmail.TabIndex = 1;
            // 
            // textBoxLoginPassword
            // 
            textBoxLoginPassword.Location = new Point(114, 179);
            textBoxLoginPassword.Margin = new Padding(2);
            textBoxLoginPassword.Name = "textBoxLoginPassword";
            textBoxLoginPassword.Size = new Size(362, 27);
            textBoxLoginPassword.TabIndex = 2;
            textBoxLoginPassword.UseSystemPasswordChar = true;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(114, 85);
            labelEmail.Margin = new Padding(2, 0, 2, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(52, 20);
            labelEmail.TabIndex = 3;
            labelEmail.Text = "E-mail";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(114, 157);
            labelPassword.Margin = new Padding(2, 0, 2, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(70, 20);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(239, 40);
            label1.Name = "label1";
            label1.Size = new Size(112, 28);
            label1.TabIndex = 5;
            label1.Text = "Connexion";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 338);
            Controls.Add(label1);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            Controls.Add(textBoxLoginPassword);
            Controls.Add(textBoxLoginEmail);
            Controls.Add(buttonLogin);
            Margin = new Padding(2);
            Name = "FormLogin";
            Text = "FormLogin";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private TextBox textBoxLoginEmail;
        private TextBox textBoxLoginPassword;
        private Label labelEmail;
        private Label labelPassword;
        private Label label1;
    }
}
