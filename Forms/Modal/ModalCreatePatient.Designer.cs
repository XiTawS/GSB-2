namespace GSB_2.Forms.Modal
{
    partial class ModalCreatePatient
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonCreatePatient = new Button();
            comboBoxPatientGender = new ComboBox();
            comboBoxPatientAge = new ComboBox();
            textBoxPatientName = new TextBox();
            textBoxPatientFirstname = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 26);
            label1.Name = "label1";
            label1.Size = new Size(205, 28);
            label1.TabIndex = 0;
            label1.Text = "Création d'un patient";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 80);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 1;
            label2.Text = "Nom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 155);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Prénom";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 229);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 3;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 306);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 4;
            label5.Text = "Genre";
            // 
            // buttonCreatePatient
            // 
            buttonCreatePatient.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCreatePatient.Location = new Point(94, 401);
            buttonCreatePatient.Name = "buttonCreatePatient";
            buttonCreatePatient.Size = new Size(152, 37);
            buttonCreatePatient.TabIndex = 5;
            buttonCreatePatient.Text = "Ajouter un patient";
            buttonCreatePatient.UseVisualStyleBackColor = true;
            buttonCreatePatient.Click += buttonCreatePatient_Click;
            // 
            // comboBoxPatientGender
            // 
            comboBoxPatientGender.FormattingEnabled = true;
            comboBoxPatientGender.Items.AddRange(new object[] { "Masculin", "Féminin" });
            comboBoxPatientGender.Location = new Point(35, 329);
            comboBoxPatientGender.Name = "comboBoxPatientGender";
            comboBoxPatientGender.Size = new Size(161, 28);
            comboBoxPatientGender.TabIndex = 7;
            // 
            // comboBoxPatientAge
            // 
            comboBoxPatientAge.FormattingEnabled = true;
            comboBoxPatientAge.Location = new Point(35, 252);
            comboBoxPatientAge.Name = "comboBoxPatientAge";
            comboBoxPatientAge.Size = new Size(61, 28);
            comboBoxPatientAge.TabIndex = 8;
            // 
            // textBoxPatientName
            // 
            textBoxPatientName.Location = new Point(35, 103);
            textBoxPatientName.Name = "textBoxPatientName";
            textBoxPatientName.Size = new Size(125, 27);
            textBoxPatientName.TabIndex = 9;
            // 
            // textBoxPatientFirstname
            // 
            textBoxPatientFirstname.Location = new Point(35, 178);
            textBoxPatientFirstname.Name = "textBoxPatientFirstname";
            textBoxPatientFirstname.Size = new Size(125, 27);
            textBoxPatientFirstname.TabIndex = 10;
            // 
            // ModalCreatePatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 450);
            Controls.Add(textBoxPatientFirstname);
            Controls.Add(textBoxPatientName);
            Controls.Add(comboBoxPatientAge);
            Controls.Add(comboBoxPatientGender);
            Controls.Add(buttonCreatePatient);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ModalCreatePatient";
            Text = "ModalCreatePatient";
            Load += ModalCreatePatient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonCreatePatient;
        private ComboBox comboBoxPatientGender;
        private ComboBox comboBoxPatientAge;
        private TextBox textBoxPatientName;
        private TextBox textBoxPatientFirstname;
    }
}