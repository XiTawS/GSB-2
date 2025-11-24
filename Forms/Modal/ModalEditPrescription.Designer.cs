namespace GSB_2.Forms.Modal
{
    partial class ModalEditPrescription
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
            label4 = new Label();
            monthCalendar1 = new MonthCalendar();
            listBox1 = new ListBox();
            comboBox3 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 326);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 32;
            label4.Text = "Validité jusqu'au :";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(33, 355);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 31;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(34, 185);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(261, 124);
            listBox1.TabIndex = 30;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(34, 110);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(261, 28);
            comboBox3.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 162);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 27;
            label3.Text = "Médicament(s) :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 87);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 26;
            label2.Text = "Patient";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 30);
            label1.Name = "label1";
            label1.Size = new Size(299, 28);
            label1.TabIndex = 25;
            label1.Text = "Modification d'une ordonnance";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(11, 606);
            button2.Name = "button2";
            button2.Size = new Size(150, 37);
            button2.TabIndex = 35;
            button2.Text = "Supprimer";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(167, 606);
            button1.Name = "button1";
            button1.Size = new Size(150, 37);
            button1.TabIndex = 34;
            button1.Text = "Enregistrer";
            button1.UseVisualStyleBackColor = true;
            // 
            // ModalEditPrescription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 655);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(monthCalendar1);
            Controls.Add(listBox1);
            Controls.Add(comboBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ModalEditPrescription";
            Text = "ModalEditPrescription";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private MonthCalendar monthCalendar1;
        private ListBox listBox1;
        private ComboBox comboBox3;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
    }
}