namespace GSB_2.Forms
{
    partial class FormLabo
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
            buttonCreateMedicine = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            dataGridViewLaboListMedicine = new DataGridView();
            buttonCreateUser = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            dataGridViewLaboListUser = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLaboListMedicine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLaboListUser).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 28);
            label1.Name = "label1";
            label1.Size = new Size(314, 28);
            label1.TabIndex = 3;
            label1.Text = "Bienvenue sur votre espace Labo !";
            // 
            // buttonCreateMedicine
            // 
            buttonCreateMedicine.Location = new Point(119, 603);
            buttonCreateMedicine.Name = "buttonCreateMedicine";
            buttonCreateMedicine.Size = new Size(297, 53);
            buttonCreateMedicine.TabIndex = 14;
            buttonCreateMedicine.Text = "Ajouter un médicament";
            buttonCreateMedicine.UseVisualStyleBackColor = true;
            buttonCreateMedicine.Click += buttonCreateMedicine_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 27);
            textBox1.TabIndex = 13;
            textBox1.Text = "Rechercher...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 89);
            label2.Name = "label2";
            label2.Size = new Size(188, 20);
            label2.TabIndex = 12;
            label2.Text = "Annuaire des médicaments";
            // 
            // dataGridViewLaboListMedicine
            // 
            dataGridViewLaboListMedicine.AllowUserToOrderColumns = true;
            dataGridViewLaboListMedicine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLaboListMedicine.Location = new Point(24, 144);
            dataGridViewLaboListMedicine.Margin = new Padding(2);
            dataGridViewLaboListMedicine.Name = "dataGridViewLaboListMedicine";
            dataGridViewLaboListMedicine.RowHeadersWidth = 82;
            dataGridViewLaboListMedicine.Size = new Size(517, 440);
            dataGridViewLaboListMedicine.TabIndex = 11;
            // 
            // buttonCreateUser
            // 
            buttonCreateUser.Location = new Point(663, 603);
            buttonCreateUser.Name = "buttonCreateUser";
            buttonCreateUser.Size = new Size(297, 53);
            buttonCreateUser.TabIndex = 18;
            buttonCreateUser.Text = "Ajouter un utilisateur";
            buttonCreateUser.UseVisualStyleBackColor = true;
            buttonCreateUser.Click += buttonCreateUser_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(568, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(219, 27);
            textBox2.TabIndex = 17;
            textBox2.Text = "Rechercher...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(568, 89);
            label3.Name = "label3";
            label3.Size = new Size(170, 20);
            label3.TabIndex = 16;
            label3.Text = "Annuaire des utilisateurs";
            // 
            // dataGridViewLaboListUser
            // 
            dataGridViewLaboListUser.AllowUserToOrderColumns = true;
            dataGridViewLaboListUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLaboListUser.Location = new Point(568, 144);
            dataGridViewLaboListUser.Margin = new Padding(2);
            dataGridViewLaboListUser.Name = "dataGridViewLaboListUser";
            dataGridViewLaboListUser.RowHeadersWidth = 82;
            dataGridViewLaboListUser.Size = new Size(517, 440);
            dataGridViewLaboListUser.TabIndex = 15;
            // 
            // FormLabo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 679);
            Controls.Add(buttonCreateUser);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(dataGridViewLaboListUser);
            Controls.Add(buttonCreateMedicine);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(dataGridViewLaboListMedicine);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "FormLabo";
            Text = "FormAdmin";
            Load += FormAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLaboListMedicine).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLaboListUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonCreateMedicine;
        private TextBox textBox1;
        private Label label2;
        private DataGridView dataGridViewLaboListMedicine;
        private Button buttonCreateUser;
        private TextBox textBox2;
        private Label label3;
        private DataGridView dataGridViewLaboListUser;
    }
}