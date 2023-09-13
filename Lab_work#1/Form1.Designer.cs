namespace Lab_work_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            
            
            
           
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 655);
            Controls.Add(rightGroupBox);
            Controls.Add(noActiveRadioButton);
            Controls.Add(ActiveRadioButton);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            
            
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button usersButton;
        private Button equipManagmentButton;
        private Button activesButton;
        private Button billingButton;
        private Button helpButton;
        private Button crmButton;
        private Button profButton;
        private Button voprosButton;
        private Label label1;
        private PictureBox pictureBox2;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn FIO;
        private DataGridViewTextBoxColumn Abonent_number;
        private DataGridViewTextBoxColumn Lic_schet;
        private DataGridViewTextBoxColumn Uslugi;
        private RadioButton ActiveRadioButton;
        private RadioButton noActiveRadioButton;
        private GroupBox rightGroupBox;
        private Button fourthRightButton;
        private Button thirdRightButton;
        private Button secondRightButton;
        private Button firstRightButton;
    }
}