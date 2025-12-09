// GSB_2/Forms/FormDoctor.Designer.cs
namespace GSB_2.Forms
{
    partial class FormDoctor
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dataGridViewDoctorListPatient = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxViewDoctorSearchPatient = new System.Windows.Forms.TextBox();
            this.textBoxViewDoctorSearchMedicine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewDoctorListMedicine = new System.Windows.Forms.DataGridView();
            this.textBoxViewDoctorSearchPrescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewDoctorListPrescription = new System.Windows.Forms.DataGridView();
            this.buttonCreatePatient = new System.Windows.Forms.Button();
            this.buttonCreatePrescription = new System.Windows.Forms.Button();
            this.buttonViewDoctorDeconnexion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctorListPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctorListMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctorListPrescription)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDoctorListPatient
            // 
            this.dataGridViewDoctorListPatient.AllowUserToOrderColumns = true;
            this.dataGridViewDoctorListPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctorListPatient.Location = new System.Drawing.Point(29, 145);
            this.dataGridViewDoctorListPatient.Name = "dataGridViewDoctorListPatient";
            this.dataGridViewDoctorListPatient.RowHeadersWidth = 82;
            this.dataGridViewDoctorListPatient.Size = new System.Drawing.Size(517, 440);
            this.dataGridViewDoctorListPatient.TabIndex = 0;
            this.dataGridViewDoctorListPatient.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewDoctorListPatient_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenue sur votre espace docteur !";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Annuaire des patients";
            // 
            // textBoxViewDoctorSearchPatient
            // 
            this.textBoxViewDoctorSearchPatient.Location = new System.Drawing.Point(29, 113);
            this.textBoxViewDoctorSearchPatient.Name = "textBoxViewDoctorSearchPatient";
            this.textBoxViewDoctorSearchPatient.Size = new System.Drawing.Size(219, 27);
            this.textBoxViewDoctorSearchPatient.TabIndex = 3;
            this.textBoxViewDoctorSearchPatient.Text = "Rechercher un patient...";
            this.textBoxViewDoctorSearchPatient.ForeColor = System.Drawing.Color.Gray;
            // 
            // textBoxViewDoctorSearchMedicine
            // 
            this.textBoxViewDoctorSearchMedicine.Location = new System.Drawing.Point(560, 113);
            this.textBoxViewDoctorSearchMedicine.Name = "textBoxViewDoctorSearchMedicine";
            this.textBoxViewDoctorSearchMedicine.Size = new System.Drawing.Size(219, 27);
            this.textBoxViewDoctorSearchMedicine.TabIndex = 6;
            this.textBoxViewDoctorSearchMedicine.Text = "Rechercher un médicament...";
            this.textBoxViewDoctorSearchMedicine.ForeColor = System.Drawing.Color.Gray;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Annuaire des médicaments";
            // 
            // dataGridViewDoctorListMedicine
            // 
            this.dataGridViewDoctorListMedicine.AllowUserToOrderColumns = true;
            this.dataGridViewDoctorListMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctorListMedicine.Location = new System.Drawing.Point(560, 145);
            this.dataGridViewDoctorListMedicine.Name = "dataGridViewDoctorListMedicine";
            this.dataGridViewDoctorListMedicine.RowHeadersWidth = 82;
            this.dataGridViewDoctorListMedicine.Size = new System.Drawing.Size(517, 182);
            this.dataGridViewDoctorListMedicine.TabIndex = 4;
            this.dataGridViewDoctorListMedicine.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewDoctorListMedicine_CellDoubleClick);
            // 
            // textBoxViewDoctorSearchPrescription
            // 
            this.textBoxViewDoctorSearchPrescription.Location = new System.Drawing.Point(560, 367);
            this.textBoxViewDoctorSearchPrescription.Name = "textBoxViewDoctorSearchPrescription";
            this.textBoxViewDoctorSearchPrescription.Size = new System.Drawing.Size(219, 27);
            this.textBoxViewDoctorSearchPrescription.TabIndex = 9;
            this.textBoxViewDoctorSearchPrescription.Text = "Rechercher une ordonnance...";
            this.textBoxViewDoctorSearchPrescription.ForeColor = System.Drawing.Color.Gray;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Annuaire des ordonnances";
            // 
            // dataGridViewDoctorListPrescription
            // 
            this.dataGridViewDoctorListPrescription.AllowUserToOrderColumns = true;
            this.dataGridViewDoctorListPrescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctorListPrescription.Location = new System.Drawing.Point(560, 399);
            this.dataGridViewDoctorListPrescription.Name = "dataGridViewDoctorListPrescription";
            this.dataGridViewDoctorListPrescription.RowHeadersWidth = 82;
            this.dataGridViewDoctorListPrescription.Size = new System.Drawing.Size(517, 186);
            this.dataGridViewDoctorListPrescription.TabIndex = 7;
            this.dataGridViewDoctorListPrescription.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewDoctorListPrescription_CellDoubleClick);
            // 
            // buttonCreatePatient
            // 
            this.buttonCreatePatient.Location = new System.Drawing.Point(124, 604);
            this.buttonCreatePatient.Name = "buttonCreatePatient";
            this.buttonCreatePatient.Size = new System.Drawing.Size(297, 53);
            this.buttonCreatePatient.TabIndex = 10;
            this.buttonCreatePatient.Text = "Ajouter un patient";
            this.buttonCreatePatient.UseVisualStyleBackColor = true;
            this.buttonCreatePatient.Click += new System.EventHandler(this.buttonCreatePatient_Click);
            // 
            // buttonCreatePrescription
            // 
            this.buttonCreatePrescription.Location = new System.Drawing.Point(675, 604);
            this.buttonCreatePrescription.Name = "buttonCreatePrescription";
            this.buttonCreatePrescription.Size = new System.Drawing.Size(297, 53);
            this.buttonCreatePrescription.TabIndex = 11;
            this.buttonCreatePrescription.Text = "Créer une ordonnance";
            this.buttonCreatePrescription.UseVisualStyleBackColor = true;
            this.buttonCreatePrescription.Click += new System.EventHandler(this.buttonCreatePrescription_Click);
            // 
            // buttonViewDoctorDeconnexion
            // 
            this.buttonViewDoctorDeconnexion.ForeColor = System.Drawing.Color.Red;
            this.buttonViewDoctorDeconnexion.Location = new System.Drawing.Point(986, 12);
            this.buttonViewDoctorDeconnexion.Name = "buttonViewDoctorDeconnexion";
            this.buttonViewDoctorDeconnexion.Size = new System.Drawing.Size(104, 29);
            this.buttonViewDoctorDeconnexion.TabIndex = 12;
            this.buttonViewDoctorDeconnexion.Text = "Déconnexion";
            this.buttonViewDoctorDeconnexion.UseVisualStyleBackColor = true;
            this.buttonViewDoctorDeconnexion.Click += new System.EventHandler(this.buttonViewDoctorDeconnexion_Click);
            // 
            // FormDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 683);
            this.Controls.Add(this.buttonViewDoctorDeconnexion);
            this.Controls.Add(this.buttonCreatePrescription);
            this.Controls.Add(this.buttonCreatePatient);
            this.Controls.Add(this.textBoxViewDoctorSearchPrescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewDoctorListPrescription);
            this.Controls.Add(this.textBoxViewDoctorSearchMedicine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewDoctorListMedicine);
            this.Controls.Add(this.textBoxViewDoctorSearchPatient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDoctorListPatient);
            this.Name = "FormDoctor";
            this.Text = "Espace Docteur - GSB";
            this.Load += new System.EventHandler(this.FormDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctorListPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctorListMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctorListPrescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDoctorListPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxViewDoctorSearchPatient;
        private System.Windows.Forms.TextBox textBoxViewDoctorSearchMedicine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewDoctorListMedicine;
        private System.Windows.Forms.TextBox textBoxViewDoctorSearchPrescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewDoctorListPrescription;
        private System.Windows.Forms.Button buttonCreatePatient;
        private System.Windows.Forms.Button buttonCreatePrescription;
        private System.Windows.Forms.Button buttonViewDoctorDeconnexion;
    }
}