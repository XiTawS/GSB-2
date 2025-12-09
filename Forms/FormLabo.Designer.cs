// GSB_2/Forms/FormLabo.Designer.cs
namespace GSB_2.Forms
{
    partial class FormLabo
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreateMedicine = new System.Windows.Forms.Button();
            this.textBoxViewLaboSearchMedicine = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewLaboListMedicine = new System.Windows.Forms.DataGridView();
            this.buttonCreateUser = new System.Windows.Forms.Button();
            this.textBoxViewLaboSearchUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewLaboListUser = new System.Windows.Forms.DataGridView();
            this.buttonViewLaboDeconnexion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLaboListMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLaboListUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bienvenue sur votre espace Laboratoire !";
            // 
            // buttonCreateMedicine
            // 
            this.buttonCreateMedicine.Location = new System.Drawing.Point(119, 603);
            this.buttonCreateMedicine.Name = "buttonCreateMedicine";
            this.buttonCreateMedicine.Size = new System.Drawing.Size(297, 53);
            this.buttonCreateMedicine.TabIndex = 14;
            this.buttonCreateMedicine.Text = "Ajouter un médicament";
            this.buttonCreateMedicine.UseVisualStyleBackColor = true;
            this.buttonCreateMedicine.Click += new System.EventHandler(this.buttonCreateMedicine_Click);
            // 
            // textBoxViewLaboSearchMedicine
            // 
            this.textBoxViewLaboSearchMedicine.Location = new System.Drawing.Point(24, 112);
            this.textBoxViewLaboSearchMedicine.Name = "textBoxViewLaboSearchMedicine";
            this.textBoxViewLaboSearchMedicine.Size = new System.Drawing.Size(219, 27);
            this.textBoxViewLaboSearchMedicine.TabIndex = 13;
            this.textBoxViewLaboSearchMedicine.Text = "Rechercher un médicament...";
            this.textBoxViewLaboSearchMedicine.ForeColor = System.Drawing.Color.Gray;
            this.textBoxViewLaboSearchMedicine.TextChanged += new System.EventHandler(this.textBoxViewLaboSearchMedicine_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Annuaire des médicaments";
            // 
            // dataGridViewLaboListMedicine
            // 
            this.dataGridViewLaboListMedicine.AllowUserToOrderColumns = true;
            this.dataGridViewLaboListMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLaboListMedicine.Location = new System.Drawing.Point(24, 144);
            this.dataGridViewLaboListMedicine.Name = "dataGridViewLaboListMedicine";
            this.dataGridViewLaboListMedicine.RowHeadersWidth = 82;
            this.dataGridViewLaboListMedicine.Size = new System.Drawing.Size(517, 440);
            this.dataGridViewLaboListMedicine.TabIndex = 11;
            this.dataGridViewLaboListMedicine.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLaboListMedicine_CellDoubleClick);
            // 
            // buttonCreateUser
            // 
            this.buttonCreateUser.Location = new System.Drawing.Point(663, 603);
            this.buttonCreateUser.Name = "buttonCreateUser";
            this.buttonCreateUser.Size = new System.Drawing.Size(297, 53);
            this.buttonCreateUser.TabIndex = 18;
            this.buttonCreateUser.Text = "Ajouter un utilisateur";
            this.buttonCreateUser.UseVisualStyleBackColor = true;
            this.buttonCreateUser.Click += new System.EventHandler(this.buttonCreateUser_Click);
            // 
            // textBoxViewLaboSearchUser
            // 
            this.textBoxViewLaboSearchUser.Location = new System.Drawing.Point(568, 112);
            this.textBoxViewLaboSearchUser.Name = "textBoxViewLaboSearchUser";
            this.textBoxViewLaboSearchUser.Size = new System.Drawing.Size(219, 27);
            this.textBoxViewLaboSearchUser.TabIndex = 17;
            this.textBoxViewLaboSearchUser.Text = "Rechercher un utilisateur...";
            this.textBoxViewLaboSearchUser.ForeColor = System.Drawing.Color.Gray;
            this.textBoxViewLaboSearchUser.TextChanged += new System.EventHandler(this.textBoxViewLaboSearchUser_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Annuaire des utilisateurs";
            // 
            // dataGridViewLaboListUser
            // 
            this.dataGridViewLaboListUser.AllowUserToOrderColumns = true;
            this.dataGridViewLaboListUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLaboListUser.Location = new System.Drawing.Point(568, 144);
            this.dataGridViewLaboListUser.Name = "dataGridViewLaboListUser";
            this.dataGridViewLaboListUser.RowHeadersWidth = 82;
            this.dataGridViewLaboListUser.Size = new System.Drawing.Size(517, 440);
            this.dataGridViewLaboListUser.TabIndex = 15;
            this.dataGridViewLaboListUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLaboListUser_CellDoubleClick);
            // 
            // buttonViewLaboDeconnexion
            // 
            this.buttonViewLaboDeconnexion.ForeColor = System.Drawing.Color.Red;
            this.buttonViewLaboDeconnexion.Location = new System.Drawing.Point(994, 12);
            this.buttonViewLaboDeconnexion.Name = "buttonViewLaboDeconnexion";
            this.buttonViewLaboDeconnexion.Size = new System.Drawing.Size(104, 29);
            this.buttonViewLaboDeconnexion.TabIndex = 19;
            this.buttonViewLaboDeconnexion.Text = "Déconnexion";
            this.buttonViewLaboDeconnexion.UseVisualStyleBackColor = true;
            this.buttonViewLaboDeconnexion.Click += new System.EventHandler(this.buttonViewLaboDeconnexion_Click);
            // 
            // FormLabo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 679);
            this.Controls.Add(this.buttonViewLaboDeconnexion);
            this.Controls.Add(this.buttonCreateUser);
            this.Controls.Add(this.textBoxViewLaboSearchUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewLaboListUser);
            this.Controls.Add(this.buttonCreateMedicine);
            this.Controls.Add(this.textBoxViewLaboSearchMedicine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewLaboListMedicine);
            this.Controls.Add(this.label1);
            this.Name = "FormLabo";
            this.Text = "Espace Laboratoire - GSB";
            this.Load += new System.EventHandler(this.FormLabo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLaboListMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLaboListUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCreateMedicine;
        private System.Windows.Forms.TextBox textBoxViewLaboSearchMedicine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewLaboListMedicine;
        private System.Windows.Forms.Button buttonCreateUser;
        private System.Windows.Forms.TextBox textBoxViewLaboSearchUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewLaboListUser;
        private System.Windows.Forms.Button buttonViewLaboDeconnexion;
    }
}