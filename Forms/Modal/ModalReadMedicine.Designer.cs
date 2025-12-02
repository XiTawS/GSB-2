namespace GSB_2.Forms.Modal
{
    partial class ModalReadMedicine
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
            buttonModalReadMedicineBack = new Button();
            textBoxModalReadMedicineMolécule = new TextBox();
            label5 = new Label();
            textBoxModalReadMedicineDescription = new TextBox();
            label4 = new Label();
            comboBoxModalReadMedicineDosageMesure = new ComboBox();
            textBoxModalReadMedicineDosage = new TextBox();
            textBoxModalReadMedicineName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonModalReadMedicineBack
            // 
            buttonModalReadMedicineBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonModalReadMedicineBack.ForeColor = Color.Black;
            buttonModalReadMedicineBack.Location = new Point(11, 397);
            buttonModalReadMedicineBack.Name = "buttonModalReadMedicineBack";
            buttonModalReadMedicineBack.Size = new Size(134, 37);
            buttonModalReadMedicineBack.TabIndex = 45;
            buttonModalReadMedicineBack.Text = "<- Retour";
            buttonModalReadMedicineBack.UseVisualStyleBackColor = true;
            buttonModalReadMedicineBack.Click += buttonModalReadMedicineBack_Click;
            // 
            // textBoxModalReadMedicineMolécule
            // 
            textBoxModalReadMedicineMolécule.Location = new Point(12, 321);
            textBoxModalReadMedicineMolécule.Name = "textBoxModalReadMedicineMolécule";
            textBoxModalReadMedicineMolécule.Size = new Size(192, 27);
            textBoxModalReadMedicineMolécule.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 298);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 42;
            label5.Text = "Molécule";
            // 
            // textBoxModalReadMedicineDescription
            // 
            textBoxModalReadMedicineDescription.Location = new Point(12, 246);
            textBoxModalReadMedicineDescription.Name = "textBoxModalReadMedicineDescription";
            textBoxModalReadMedicineDescription.Size = new Size(354, 27);
            textBoxModalReadMedicineDescription.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 223);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 40;
            label4.Text = "Description";
            // 
            // comboBoxModalReadMedicineDosageMesure
            // 
            comboBoxModalReadMedicineDosageMesure.FormattingEnabled = true;
            comboBoxModalReadMedicineDosageMesure.Location = new Point(143, 167);
            comboBoxModalReadMedicineDosageMesure.Name = "comboBoxModalReadMedicineDosageMesure";
            comboBoxModalReadMedicineDosageMesure.Size = new Size(61, 28);
            comboBoxModalReadMedicineDosageMesure.TabIndex = 39;
            // 
            // textBoxModalReadMedicineDosage
            // 
            textBoxModalReadMedicineDosage.Location = new Point(12, 167);
            textBoxModalReadMedicineDosage.Name = "textBoxModalReadMedicineDosage";
            textBoxModalReadMedicineDosage.Size = new Size(125, 27);
            textBoxModalReadMedicineDosage.TabIndex = 38;
            // 
            // textBoxModalReadMedicineName
            // 
            textBoxModalReadMedicineName.Location = new Point(12, 92);
            textBoxModalReadMedicineName.Name = "textBoxModalReadMedicineName";
            textBoxModalReadMedicineName.Size = new Size(192, 27);
            textBoxModalReadMedicineName.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 144);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 36;
            label3.Text = "Dosage";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 35;
            label2.Text = "Nom";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 18);
            label1.Name = "label1";
            label1.Size = new Size(286, 28);
            label1.TabIndex = 34;
            label1.Text = "Information d'un médicament";
            // 
            // ModalReadMedicine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 450);
            Controls.Add(buttonModalReadMedicineBack);
            Controls.Add(textBoxModalReadMedicineMolécule);
            Controls.Add(label5);
            Controls.Add(textBoxModalReadMedicineDescription);
            Controls.Add(label4);
            Controls.Add(comboBoxModalReadMedicineDosageMesure);
            Controls.Add(textBoxModalReadMedicineDosage);
            Controls.Add(textBoxModalReadMedicineName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ModalReadMedicine";
            Text = "ModalReadMedicine";
            Load += ModalReadMedicine_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonModalReadMedicineBack;
        private TextBox textBoxModalReadMedicineMolécule;
        private Label label5;
        private TextBox textBoxModalReadMedicineDescription;
        private Label label4;
        private ComboBox comboBoxModalReadMedicineDosageMesure;
        private TextBox textBoxModalReadMedicineDosage;
        private TextBox textBoxModalReadMedicineName;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}