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
            textBox4 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            comboBox3 = new ComboBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.Location = new Point(217, 98);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(161, 27);
            textBox4.TabIndex = 36;
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
            // textBox3
            // 
            textBox3.Location = new Point(22, 98);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(161, 27);
            textBox3.TabIndex = 34;
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
            // textBox2
            // 
            textBox2.Location = new Point(22, 238);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(231, 27);
            textBox2.TabIndex = 32;
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
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(22, 307);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(161, 28);
            comboBox3.TabIndex = 30;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 27);
            textBox1.TabIndex = 29;
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
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(12, 360);
            button2.Name = "button2";
            button2.Size = new Size(186, 37);
            button2.TabIndex = 38;
            button2.Text = "Supprimer";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(216, 360);
            button1.Name = "button1";
            button1.Size = new Size(186, 37);
            button1.TabIndex = 37;
            button1.Text = "Enregistrer";
            button1.UseVisualStyleBackColor = true;
            // 
            // ModalEditUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 409);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(comboBox3);
            Controls.Add(textBox1);
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

        private TextBox textBox4;
        private Label label6;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox2;
        private Label label4;
        private ComboBox comboBox3;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
    }
}