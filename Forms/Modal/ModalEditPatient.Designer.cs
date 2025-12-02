namespace GSB_2.Forms.Modal
{
    partial class ModalEditPatient
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
            textBoxModalEditPatientFirstName = new TextBox();
            textBoxModalEditPatientName = new TextBox();
            comboBoxModalEditPatientAge = new ComboBox();
            comboBoxModalEditPatientGender = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonModalEditPatientDelete = new Button();
            buttonModalEditPatientSave = new Button();
            SuspendLayout();
            // 
            // textBoxModalEditPatientFirstName
            // 
            textBoxModalEditPatientFirstName.Location = new Point(12, 158);
            textBoxModalEditPatientFirstName.Name = "textBoxModalEditPatientFirstName";
            textBoxModalEditPatientFirstName.Size = new Size(125, 27);
            textBoxModalEditPatientFirstName.TabIndex = 20;
            // 
            // textBoxModalEditPatientName
            // 
            textBoxModalEditPatientName.Location = new Point(12, 83);
            textBoxModalEditPatientName.Name = "textBoxModalEditPatientName";
            textBoxModalEditPatientName.Size = new Size(125, 27);
            textBoxModalEditPatientName.TabIndex = 19;
            // 
            // comboBoxModalEditPatientAge
            // 
            comboBoxModalEditPatientAge.FormattingEnabled = true;
            comboBoxModalEditPatientAge.Location = new Point(12, 232);
            comboBoxModalEditPatientAge.Name = "comboBoxModalEditPatientAge";
            comboBoxModalEditPatientAge.Size = new Size(61, 28);
            comboBoxModalEditPatientAge.TabIndex = 18;
            // 
            // comboBoxModalEditPatientGender
            // 
            comboBoxModalEditPatientGender.FormattingEnabled = true;
            comboBoxModalEditPatientGender.Location = new Point(12, 309);
            comboBoxModalEditPatientGender.Name = "comboBoxModalEditPatientGender";
            comboBoxModalEditPatientGender.Size = new Size(161, 28);
            comboBoxModalEditPatientGender.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 286);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 15;
            label5.Text = "Genre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 209);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 14;
            label4.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 135);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 13;
            label3.Text = "Prénom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 12;
            label2.Text = "Nom";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(243, 28);
            label1.TabIndex = 11;
            label1.Text = "Modification d'un patient";
            // 
            // buttonModalEditPatientDelete
            // 
            buttonModalEditPatientDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonModalEditPatientDelete.ForeColor = Color.Red;
            buttonModalEditPatientDelete.Location = new Point(12, 371);
            buttonModalEditPatientDelete.Name = "buttonModalEditPatientDelete";
            buttonModalEditPatientDelete.Size = new Size(125, 37);
            buttonModalEditPatientDelete.TabIndex = 35;
            buttonModalEditPatientDelete.Text = "Supprimer";
            buttonModalEditPatientDelete.UseVisualStyleBackColor = true;
            buttonModalEditPatientDelete.Click += buttonModalEditPatientDelete_Click;
            // 
            // buttonModalEditPatientSave
            // 
            buttonModalEditPatientSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonModalEditPatientSave.Location = new Point(158, 371);
            buttonModalEditPatientSave.Name = "buttonModalEditPatientSave";
            buttonModalEditPatientSave.Size = new Size(122, 37);
            buttonModalEditPatientSave.TabIndex = 34;
            buttonModalEditPatientSave.Text = "Enregistrer";
            buttonModalEditPatientSave.UseVisualStyleBackColor = true;
            buttonModalEditPatientSave.Click += buttonModalEditPatientSave_Click;
            // 
            // ModalEditPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 420);
            Controls.Add(buttonModalEditPatientDelete);
            Controls.Add(buttonModalEditPatientSave);
            Controls.Add(textBoxModalEditPatientFirstName);
            Controls.Add(textBoxModalEditPatientName);
            Controls.Add(comboBoxModalEditPatientAge);
            Controls.Add(comboBoxModalEditPatientGender);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ModalEditPatient";
            Text = "ModalEditPatient";
            Load += ModalEditPatient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxModalEditPatientFirstName;
        private TextBox textBoxModalEditPatientName;
        private ComboBox comboBoxModalEditPatientAge;
        private ComboBox comboBoxModalEditPatientGender;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonModalEditPatientDelete;
        private Button buttonModalEditPatientSave;
    }
}