namespace GSB_2.Forms.Modal
{
    partial class ModalDetailsPatient
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
            textBoxModalDetailsPatientName = new TextBox();
            textBoxModalDetailsPatientFirstName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            buttonModalDetailsPatientBack = new Button();
            buttonModalDetailsPatientModify = new Button();
            comboBoxModalDetailsPatientAge = new ComboBox();
            comboBoxModalDetailsPatientGender = new ComboBox();
            listBoxModalDetailsPatientListPrescription = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 9);
            label1.Name = "label1";
            label1.Size = new Size(119, 28);
            label1.TabIndex = 12;
            label1.Text = "Détails de : ";
            // 
            // textBoxModalDetailsPatientName
            // 
            textBoxModalDetailsPatientName.Location = new Point(376, 12);
            textBoxModalDetailsPatientName.Name = "textBoxModalDetailsPatientName";
            textBoxModalDetailsPatientName.Size = new Size(161, 27);
            textBoxModalDetailsPatientName.TabIndex = 29;
            // 
            // textBoxModalDetailsPatientFirstName
            // 
            textBoxModalDetailsPatientFirstName.Location = new Point(200, 12);
            textBoxModalDetailsPatientFirstName.Name = "textBoxModalDetailsPatientFirstName";
            textBoxModalDetailsPatientFirstName.Size = new Size(161, 27);
            textBoxModalDetailsPatientFirstName.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(155, 55);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 35;
            label5.Text = "Genre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 55);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 34;
            label4.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 132);
            label6.Name = "label6";
            label6.Size = new Size(164, 20);
            label6.TabIndex = 39;
            label6.Text = "Listes des ordonnaces : ";
            // 
            // buttonModalDetailsPatientBack
            // 
            buttonModalDetailsPatientBack.Location = new Point(12, 518);
            buttonModalDetailsPatientBack.Name = "buttonModalDetailsPatientBack";
            buttonModalDetailsPatientBack.Size = new Size(94, 29);
            buttonModalDetailsPatientBack.TabIndex = 40;
            buttonModalDetailsPatientBack.Text = "<- Retour";
            buttonModalDetailsPatientBack.UseVisualStyleBackColor = true;
            buttonModalDetailsPatientBack.Click += buttonModalDetailsPatientBack_Click;
            // 
            // buttonModalDetailsPatientModify
            // 
            buttonModalDetailsPatientModify.Location = new Point(116, 518);
            buttonModalDetailsPatientModify.Name = "buttonModalDetailsPatientModify";
            buttonModalDetailsPatientModify.Size = new Size(94, 29);
            buttonModalDetailsPatientModify.TabIndex = 41;
            buttonModalDetailsPatientModify.Text = "Modifier";
            buttonModalDetailsPatientModify.UseVisualStyleBackColor = true;
            buttonModalDetailsPatientModify.Click += buttonModalDetailsPatientModify_Click;
            // 
            // comboBoxModalDetailsPatientAge
            // 
            comboBoxModalDetailsPatientAge.FormattingEnabled = true;
            comboBoxModalDetailsPatientAge.Location = new Point(16, 78);
            comboBoxModalDetailsPatientAge.Name = "comboBoxModalDetailsPatientAge";
            comboBoxModalDetailsPatientAge.Size = new Size(80, 28);
            comboBoxModalDetailsPatientAge.TabIndex = 42;
            // 
            // comboBoxModalDetailsPatientGender
            // 
            comboBoxModalDetailsPatientGender.FormattingEnabled = true;
            comboBoxModalDetailsPatientGender.Location = new Point(155, 78);
            comboBoxModalDetailsPatientGender.Name = "comboBoxModalDetailsPatientGender";
            comboBoxModalDetailsPatientGender.Size = new Size(153, 28);
            comboBoxModalDetailsPatientGender.TabIndex = 43;
            // 
            // listBoxModalDetailsPatientListPrescription
            // 
            listBoxModalDetailsPatientListPrescription.FormattingEnabled = true;
            listBoxModalDetailsPatientListPrescription.Location = new Point(12, 155);
            listBoxModalDetailsPatientListPrescription.Name = "listBoxModalDetailsPatientListPrescription";
            listBoxModalDetailsPatientListPrescription.Size = new Size(776, 344);
            listBoxModalDetailsPatientListPrescription.TabIndex = 44;
            // 
            // ModalDetailsPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 559);
            Controls.Add(listBoxModalDetailsPatientListPrescription);
            Controls.Add(comboBoxModalDetailsPatientGender);
            Controls.Add(comboBoxModalDetailsPatientAge);
            Controls.Add(buttonModalDetailsPatientModify);
            Controls.Add(buttonModalDetailsPatientBack);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxModalDetailsPatientName);
            Controls.Add(textBoxModalDetailsPatientFirstName);
            Controls.Add(label1);
            Name = "ModalDetailsPatient";
            Text = "ModalDetailsPatient";
            Load += ModalDetailsPatient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxModalDetailsPatientName;
        private TextBox textBoxModalDetailsPatientFirstName;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label5;
        private Label label4;
        private ListBox listBox1;
        private Label label6;
        private Button buttonModalDetailsPatientBack;
        private Button buttonModalDetailsPatientModify;
        private ComboBox comboBoxModalDetailsPatientAge;
        private ComboBox comboBoxModalDetailsPatientGender;
        private ListBox listBoxModalDetailsPatientListPrescription;
    }
}