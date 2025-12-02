namespace GSB_2.Forms
{
    partial class FormDoctor
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
            dataGridViewDoctorListPatient = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            dataGridViewDoctorListMedicine = new DataGridView();
            textBox3 = new TextBox();
            label4 = new Label();
            dataGridViewDoctorListPrescription = new DataGridView();
            buttonCreatePatient = new Button();
            buttonCreatePrescription = new Button();
            buttonViewDoctorDeconnexion = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctorListPatient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctorListMedicine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctorListPrescription).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDoctorListPatient
            // 
            dataGridViewDoctorListPatient.AllowUserToOrderColumns = true;
            dataGridViewDoctorListPatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDoctorListPatient.Location = new Point(29, 145);
            dataGridViewDoctorListPatient.Margin = new Padding(2);
            dataGridViewDoctorListPatient.Name = "dataGridViewDoctorListPatient";
            dataGridViewDoctorListPatient.RowHeadersWidth = 82;
            dataGridViewDoctorListPatient.Size = new Size(517, 440);
            dataGridViewDoctorListPatient.TabIndex = 0;
            dataGridViewDoctorListPatient.CellDoubleClick += dataGridViewDoctorListPatient_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 26);
            label1.Name = "label1";
            label1.Size = new Size(339, 28);
            label1.TabIndex = 1;
            label1.Text = "Bienvenue sur votre espace docteur !";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 90);
            label2.Name = "label2";
            label2.Size = new Size(152, 20);
            label2.TabIndex = 2;
            label2.Text = "Annuaire des patients";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 27);
            textBox1.TabIndex = 3;
            textBox1.Text = "Rechercher...";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(560, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(219, 27);
            textBox2.TabIndex = 6;
            textBox2.Text = "Rechercher...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(560, 90);
            label3.Name = "label3";
            label3.Size = new Size(188, 20);
            label3.TabIndex = 5;
            label3.Text = "Annuaire des médicaments";
            // 
            // dataGridViewDoctorListMedicine
            // 
            dataGridViewDoctorListMedicine.AllowUserToOrderColumns = true;
            dataGridViewDoctorListMedicine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDoctorListMedicine.Location = new Point(560, 145);
            dataGridViewDoctorListMedicine.Margin = new Padding(2);
            dataGridViewDoctorListMedicine.Name = "dataGridViewDoctorListMedicine";
            dataGridViewDoctorListMedicine.RowHeadersWidth = 82;
            dataGridViewDoctorListMedicine.Size = new Size(517, 182);
            dataGridViewDoctorListMedicine.TabIndex = 4;
            dataGridViewDoctorListMedicine.CellDoubleClick += dataGridViewDoctorListMedicine_CellDoubleClick;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(560, 367);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(219, 27);
            textBox3.TabIndex = 9;
            textBox3.Text = "Rechercher...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(560, 344);
            label4.Name = "label4";
            label4.Size = new Size(184, 20);
            label4.TabIndex = 8;
            label4.Text = "Annuaire des ordonnances";
            // 
            // dataGridViewDoctorListPrescription
            // 
            dataGridViewDoctorListPrescription.AllowUserToOrderColumns = true;
            dataGridViewDoctorListPrescription.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDoctorListPrescription.Location = new Point(560, 399);
            dataGridViewDoctorListPrescription.Margin = new Padding(2);
            dataGridViewDoctorListPrescription.Name = "dataGridViewDoctorListPrescription";
            dataGridViewDoctorListPrescription.RowHeadersWidth = 82;
            dataGridViewDoctorListPrescription.Size = new Size(517, 186);
            dataGridViewDoctorListPrescription.TabIndex = 7;
            dataGridViewDoctorListPrescription.CellDoubleClick += dataGridViewDoctorListPrescription_CellDoubleClick;
            // 
            // buttonCreatePatient
            // 
            buttonCreatePatient.Location = new Point(124, 604);
            buttonCreatePatient.Name = "buttonCreatePatient";
            buttonCreatePatient.Size = new Size(297, 53);
            buttonCreatePatient.TabIndex = 10;
            buttonCreatePatient.Text = "Ajouter un patient";
            buttonCreatePatient.UseVisualStyleBackColor = true;
            buttonCreatePatient.Click += buttonCreatePatient_Click;
            // 
            // buttonCreatePrescription
            // 
            buttonCreatePrescription.Location = new Point(675, 604);
            buttonCreatePrescription.Name = "buttonCreatePrescription";
            buttonCreatePrescription.Size = new Size(297, 53);
            buttonCreatePrescription.TabIndex = 11;
            buttonCreatePrescription.Text = "Créer une ordonnance";
            buttonCreatePrescription.UseVisualStyleBackColor = true;
            buttonCreatePrescription.Click += buttonCreatePrescription_Click;
            // 
            // buttonViewDoctorDeconnexion
            // 
            buttonViewDoctorDeconnexion.ForeColor = Color.Red;
            buttonViewDoctorDeconnexion.Location = new Point(986, 12);
            buttonViewDoctorDeconnexion.Name = "buttonViewDoctorDeconnexion";
            buttonViewDoctorDeconnexion.Size = new Size(104, 29);
            buttonViewDoctorDeconnexion.TabIndex = 12;
            buttonViewDoctorDeconnexion.Text = "Déconnexion";
            buttonViewDoctorDeconnexion.UseVisualStyleBackColor = true;
            buttonViewDoctorDeconnexion.Click += buttonViewDoctorDeconnexion_Click;
            // 
            // FormDoctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 683);
            Controls.Add(buttonViewDoctorDeconnexion);
            Controls.Add(buttonCreatePrescription);
            Controls.Add(buttonCreatePatient);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(dataGridViewDoctorListPrescription);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(dataGridViewDoctorListMedicine);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewDoctorListPatient);
            Margin = new Padding(2);
            Name = "FormDoctor";
            Text = "FormDoctor";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctorListPatient).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctorListMedicine).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctorListPrescription).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewDoctorListPatient;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private DataGridView dataGridViewDoctorListMedicine;
        private TextBox textBox3;
        private Label label4;
        private DataGridView dataGridViewDoctorListPrescription;
        private Button buttonCreatePatient;
        private Button buttonCreatePrescription;
        private Button buttonViewDoctorDeconnexion;
    }
}