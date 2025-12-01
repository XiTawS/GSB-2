namespace GSB_2.Forms.Modal
{
    partial class ModalCreateMedicine
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
            textBoxMedicineDosage = new TextBox();
            textBoxMedicineName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBoxMedicineDosageMesure = new ComboBox();
            textBoxMedicineDescription = new TextBox();
            label4 = new Label();
            textBoxMedicineMolecule = new TextBox();
            label5 = new Label();
            buttonCreateMedicine = new Button();
            SuspendLayout();
            // 
            // textBoxMedicineDosage
            // 
            textBoxMedicineDosage.Location = new Point(12, 157);
            textBoxMedicineDosage.Name = "textBoxMedicineDosage";
            textBoxMedicineDosage.Size = new Size(125, 27);
            textBoxMedicineDosage.TabIndex = 15;
            // 
            // textBoxMedicineName
            // 
            textBoxMedicineName.Location = new Point(12, 82);
            textBoxMedicineName.Name = "textBoxMedicineName";
            textBoxMedicineName.Size = new Size(192, 27);
            textBoxMedicineName.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 134);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 13;
            label3.Text = "Dosage";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 12;
            label2.Text = "Nom";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 9);
            label1.Name = "label1";
            label1.Size = new Size(254, 28);
            label1.TabIndex = 11;
            label1.Text = "Création d'un médicament";
            // 
            // comboBoxMedicineDosageMesure
            // 
            comboBoxMedicineDosageMesure.FormattingEnabled = true;
            comboBoxMedicineDosageMesure.Items.AddRange(new object[] { "mg", "gµ", "g", "ml", "UI", "mg/ml ", "µg/ml", "mg/g", "%" });
            comboBoxMedicineDosageMesure.Location = new Point(143, 157);
            comboBoxMedicineDosageMesure.Name = "comboBoxMedicineDosageMesure";
            comboBoxMedicineDosageMesure.Size = new Size(61, 28);
            comboBoxMedicineDosageMesure.TabIndex = 16;
            // 
            // textBoxMedicineDescription
            // 
            textBoxMedicineDescription.Location = new Point(12, 236);
            textBoxMedicineDescription.Name = "textBoxMedicineDescription";
            textBoxMedicineDescription.Size = new Size(354, 27);
            textBoxMedicineDescription.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 213);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 17;
            label4.Text = "Description";
            // 
            // textBoxMedicineMolecule
            // 
            textBoxMedicineMolecule.Location = new Point(12, 311);
            textBoxMedicineMolecule.Name = "textBoxMedicineMolecule";
            textBoxMedicineMolecule.Size = new Size(192, 27);
            textBoxMedicineMolecule.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 288);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 19;
            label5.Text = "Molécule";
            // 
            // buttonCreateMedicine
            // 
            buttonCreateMedicine.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCreateMedicine.Location = new Point(105, 381);
            buttonCreateMedicine.Name = "buttonCreateMedicine";
            buttonCreateMedicine.Size = new Size(186, 37);
            buttonCreateMedicine.TabIndex = 21;
            buttonCreateMedicine.Text = "Ajouter un médicament";
            buttonCreateMedicine.UseVisualStyleBackColor = true;
            buttonCreateMedicine.Click += buttonCreateMedicine_Click;
            // 
            // ModalCreateMedicine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 430);
            Controls.Add(buttonCreateMedicine);
            Controls.Add(textBoxMedicineMolecule);
            Controls.Add(label5);
            Controls.Add(textBoxMedicineDescription);
            Controls.Add(label4);
            Controls.Add(comboBoxMedicineDosageMesure);
            Controls.Add(textBoxMedicineDosage);
            Controls.Add(textBoxMedicineName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ModalCreateMedicine";
            Text = "ModalCreateMedicine";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxMedicineDosage;
        private TextBox textBoxMedicineName;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxMedicineDosageMesure;
        private TextBox textBoxMedicineDescription;
        private Label label4;
        private TextBox textBoxMedicineMolecule;
        private Label label5;
        private Button buttonCreateMedicine;
    }
}