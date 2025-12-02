namespace GSB_2.Forms.Modal
{
    partial class ModalEditMedicine
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
            buttonModalEditMedicineSave = new Button();
            textBoxModalEditMedicineMolecule = new TextBox();
            label5 = new Label();
            textBoxModalEditMedicineDescription = new TextBox();
            label4 = new Label();
            comboBoxModalEditMedicineDosageMesure = new ComboBox();
            textBoxModalEditMedicineDosage = new TextBox();
            textBoxModalEditMedicineName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonModalEditMedicineDelete = new Button();
            SuspendLayout();
            // 
            // buttonModalEditMedicineSave
            // 
            buttonModalEditMedicineSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonModalEditMedicineSave.Location = new Point(203, 397);
            buttonModalEditMedicineSave.Name = "buttonModalEditMedicineSave";
            buttonModalEditMedicineSave.Size = new Size(186, 37);
            buttonModalEditMedicineSave.TabIndex = 32;
            buttonModalEditMedicineSave.Text = "Enregistrer";
            buttonModalEditMedicineSave.UseVisualStyleBackColor = true;
            buttonModalEditMedicineSave.Click += buttonModalEditMedicineSave_Click;
            // 
            // textBoxModalEditMedicineMolecule
            // 
            textBoxModalEditMedicineMolecule.Location = new Point(12, 321);
            textBoxModalEditMedicineMolecule.Name = "textBoxModalEditMedicineMolecule";
            textBoxModalEditMedicineMolecule.Size = new Size(192, 27);
            textBoxModalEditMedicineMolecule.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 298);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 30;
            label5.Text = "Molécule";
            // 
            // textBoxModalEditMedicineDescription
            // 
            textBoxModalEditMedicineDescription.Location = new Point(12, 246);
            textBoxModalEditMedicineDescription.Name = "textBoxModalEditMedicineDescription";
            textBoxModalEditMedicineDescription.Size = new Size(354, 27);
            textBoxModalEditMedicineDescription.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 223);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 28;
            label4.Text = "Description";
            // 
            // comboBoxModalEditMedicineDosageMesure
            // 
            comboBoxModalEditMedicineDosageMesure.FormattingEnabled = true;
            comboBoxModalEditMedicineDosageMesure.Location = new Point(143, 167);
            comboBoxModalEditMedicineDosageMesure.Name = "comboBoxModalEditMedicineDosageMesure";
            comboBoxModalEditMedicineDosageMesure.Size = new Size(61, 28);
            comboBoxModalEditMedicineDosageMesure.TabIndex = 27;
            // 
            // textBoxModalEditMedicineDosage
            // 
            textBoxModalEditMedicineDosage.Location = new Point(12, 167);
            textBoxModalEditMedicineDosage.Name = "textBoxModalEditMedicineDosage";
            textBoxModalEditMedicineDosage.Size = new Size(125, 27);
            textBoxModalEditMedicineDosage.TabIndex = 26;
            // 
            // textBoxModalEditMedicineName
            // 
            textBoxModalEditMedicineName.Location = new Point(12, 92);
            textBoxModalEditMedicineName.Name = "textBoxModalEditMedicineName";
            textBoxModalEditMedicineName.Size = new Size(192, 27);
            textBoxModalEditMedicineName.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 144);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 24;
            label3.Text = "Dosage";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 23;
            label2.Text = "Nom";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 21);
            label1.Name = "label1";
            label1.Size = new Size(292, 28);
            label1.TabIndex = 22;
            label1.Text = "Modification d'un médicament";
            // 
            // buttonModalEditMedicineDelete
            // 
            buttonModalEditMedicineDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonModalEditMedicineDelete.ForeColor = Color.Red;
            buttonModalEditMedicineDelete.Location = new Point(11, 397);
            buttonModalEditMedicineDelete.Name = "buttonModalEditMedicineDelete";
            buttonModalEditMedicineDelete.Size = new Size(186, 37);
            buttonModalEditMedicineDelete.TabIndex = 33;
            buttonModalEditMedicineDelete.Text = "Supprimer";
            buttonModalEditMedicineDelete.UseVisualStyleBackColor = true;
            buttonModalEditMedicineDelete.Click += buttonModalEditMedicineDelete_Click;
            // 
            // ModalEditMedicine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 446);
            Controls.Add(buttonModalEditMedicineDelete);
            Controls.Add(buttonModalEditMedicineSave);
            Controls.Add(textBoxModalEditMedicineMolecule);
            Controls.Add(label5);
            Controls.Add(textBoxModalEditMedicineDescription);
            Controls.Add(label4);
            Controls.Add(comboBoxModalEditMedicineDosageMesure);
            Controls.Add(textBoxModalEditMedicineDosage);
            Controls.Add(textBoxModalEditMedicineName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ModalEditMedicine";
            Text = "ModalEditMedicine";
            Load += ModalEditMedicine_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonModalEditMedicineSave;
        private TextBox textBoxModalEditMedicineMolecule;
        private Label label5;
        private TextBox textBoxModalEditMedicineDescription;
        private Label label4;
        private ComboBox comboBoxModalEditMedicineDosageMesure;
        private TextBox textBoxModalEditMedicineDosage;
        private TextBox textBoxModalEditMedicineName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonModalEditMedicineDelete;
    }
}