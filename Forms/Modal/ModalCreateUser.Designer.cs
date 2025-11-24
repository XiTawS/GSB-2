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
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox3 = new ComboBox();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 164);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 27);
            textBox1.TabIndex = 18;
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
            label1.Click += label1_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(28, 302);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(161, 28);
            comboBox3.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(28, 233);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(231, 27);
            textBox2.TabIndex = 21;
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
            // textBox3
            // 
            textBox3.Location = new Point(28, 93);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(161, 27);
            textBox3.TabIndex = 23;
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
            // textBox4
            // 
            textBox4.Location = new Point(223, 93);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(161, 27);
            textBox4.TabIndex = 25;
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
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(121, 364);
            button1.Name = "button1";
            button1.Size = new Size(203, 37);
            button1.TabIndex = 26;
            button1.Text = "Créer un utilisateur";
            button1.UseVisualStyleBackColor = true;
            // 
            // ModalCreateUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 413);
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
            Name = "ModalCreateUser";
            Text = "ModalCreateUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private Button button1;
    }
}