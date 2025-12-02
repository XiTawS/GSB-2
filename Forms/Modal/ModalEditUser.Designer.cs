namespace GSB_2.Forms.Modal
{
    partial class ModalEditUser
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
            textBoxModalEditUserName = new TextBox();
            label6 = new Label();
            textBoxModalEditUserFirstName = new TextBox();
            label5 = new Label();
            textBoxModalEditUserPassword = new TextBox();
            label4 = new Label();
            comboBoxModalEditUserRole = new ComboBox();
            textBoxModalEditUserEmail = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonModalEditUserDelete = new Button();
            buttonModalEditUserSave = new Button();
            SuspendLayout();
            // 
            // textBoxModalEditUserName
            // 
            textBoxModalEditUserName.Location = new Point(217, 98);
            textBoxModalEditUserName.Name = "textBoxModalEditUserName";
            textBoxModalEditUserName.Size = new Size(161, 27);
            textBoxModalEditUserName.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(217, 75);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 35;
            label6.Text = "Nom de famille";
            // 
            // textBoxModalEditUserFirstName
            // 
            textBoxModalEditUserFirstName.Location = new Point(22, 98);
            textBoxModalEditUserFirstName.Name = "textBoxModalEditUserFirstName";
            textBoxModalEditUserFirstName.Size = new Size(161, 27);
            textBoxModalEditUserFirstName.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 75);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 33;
            label5.Text = "Prénom";
            // 
            // textBoxModalEditUserPassword
            // 
            textBoxModalEditUserPassword.Location = new Point(22, 238);
            textBoxModalEditUserPassword.Name = "textBoxModalEditUserPassword";
            textBoxModalEditUserPassword.Size = new Size(231, 27);
            textBoxModalEditUserPassword.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 215);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 31;
            label4.Text = "Mot de passe";
            // 
            // comboBoxModalEditUserRole
            // 
            comboBoxModalEditUserRole.FormattingEnabled = true;
            comboBoxModalEditUserRole.Location = new Point(22, 307);
            comboBoxModalEditUserRole.Name = "comboBoxModalEditUserRole";
            comboBoxModalEditUserRole.Size = new Size(161, 28);
            comboBoxModalEditUserRole.TabIndex = 30;
            // 
            // textBoxModalEditUserEmail
            // 
            textBoxModalEditUserEmail.Location = new Point(22, 169);
            textBoxModalEditUserEmail.Name = "textBoxModalEditUserEmail";
            textBoxModalEditUserEmail.Size = new Size(231, 27);
            textBoxModalEditUserEmail.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 284);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 28;
            label3.Text = "Rôle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 146);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 27;
            label2.Text = "E-mail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 24);
            label1.Name = "label1";
            label1.Size = new Size(269, 28);
            label1.TabIndex = 26;
            label1.Text = "Modification d'un utilisateur";
            // 
            // buttonModalEditUserDelete
            // 
            buttonModalEditUserDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonModalEditUserDelete.ForeColor = Color.Red;
            buttonModalEditUserDelete.Location = new Point(12, 360);
            buttonModalEditUserDelete.Name = "buttonModalEditUserDelete";
            buttonModalEditUserDelete.Size = new Size(186, 37);
            buttonModalEditUserDelete.TabIndex = 38;
            buttonModalEditUserDelete.Text = "Supprimer";
            buttonModalEditUserDelete.UseVisualStyleBackColor = true;
            buttonModalEditUserDelete.Click += buttonModalEditUserDelete_Click;
            // 
            // buttonModalEditUserSave
            // 
            buttonModalEditUserSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonModalEditUserSave.Location = new Point(216, 360);
            buttonModalEditUserSave.Name = "buttonModalEditUserSave";
            buttonModalEditUserSave.Size = new Size(186, 37);
            buttonModalEditUserSave.TabIndex = 37;
            buttonModalEditUserSave.Text = "Enregistrer";
            buttonModalEditUserSave.UseVisualStyleBackColor = true;
            buttonModalEditUserSave.Click += buttonModalEditUserSave_Click;
            // 
            // ModalEditUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 409);
            Controls.Add(buttonModalEditUserDelete);
            Controls.Add(buttonModalEditUserSave);
            Controls.Add(textBoxModalEditUserName);
            Controls.Add(label6);
            Controls.Add(textBoxModalEditUserFirstName);
            Controls.Add(label5);
            Controls.Add(textBoxModalEditUserPassword);
            Controls.Add(label4);
            Controls.Add(comboBoxModalEditUserRole);
            Controls.Add(textBoxModalEditUserEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ModalEditUser";
            Text = "ModalEditUser";
            Load += ModalEditUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxModalEditUserName;
        private Label label6;
        private TextBox textBoxModalEditUserFirstName;
        private Label label5;
        private TextBox textBoxModalEditUserPassword;
        private Label label4;
        private ComboBox comboBoxModalEditUserRole;
        private TextBox textBoxModalEditUserEmail;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonModalEditUserDelete;
        private Button buttonModalEditUserSave;
    }
}