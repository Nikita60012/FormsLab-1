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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            usersButton = new Button();
            equipManagmentButton = new Button();
            activesButton = new Button();
            billingButton = new Button();
            helpButton = new Button();
            crmButton = new Button();
            profButton = new Button();
            voprosButton = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            FIO = new DataGridViewTextBoxColumn();
            Abonent_number = new DataGridViewTextBoxColumn();
            Lic_schet = new DataGridViewTextBoxColumn();
            Uslugi = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            ActiveRadioButton = new RadioButton();
            noActiveRadioButton = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(5, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 112);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // usersButton
            // 
            usersButton.Location = new Point(6, 140);
            usersButton.Name = "usersButton";
            usersButton.Size = new Size(146, 52);
            usersButton.TabIndex = 1;
            usersButton.Text = "Абоненты";
            usersButton.UseVisualStyleBackColor = true;
            // 
            // equipManagmentButton
            // 
            equipManagmentButton.Location = new Point(5, 210);
            equipManagmentButton.Name = "equipManagmentButton";
            equipManagmentButton.Size = new Size(146, 52);
            equipManagmentButton.TabIndex = 2;
            equipManagmentButton.Text = "Управление оборудованием";
            equipManagmentButton.UseVisualStyleBackColor = true;
            // 
            // activesButton
            // 
            activesButton.Location = new Point(5, 282);
            activesButton.Name = "activesButton";
            activesButton.Size = new Size(146, 52);
            activesButton.TabIndex = 3;
            activesButton.Text = "Активы";
            activesButton.TextAlign = ContentAlignment.TopCenter;
            activesButton.UseVisualStyleBackColor = true;
            // 
            // billingButton
            // 
            billingButton.Location = new Point(5, 350);
            billingButton.Name = "billingButton";
            billingButton.Size = new Size(146, 52);
            billingButton.TabIndex = 4;
            billingButton.Text = "Биллинг";
            billingButton.UseVisualStyleBackColor = true;
            // 
            // helpButton
            // 
            helpButton.Location = new Point(6, 420);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(146, 52);
            helpButton.TabIndex = 5;
            helpButton.Text = "Поддержка пользователей";
            helpButton.UseVisualStyleBackColor = true;
            // 
            // crmButton
            // 
            crmButton.Location = new Point(6, 489);
            crmButton.Name = "crmButton";
            crmButton.Size = new Size(146, 52);
            crmButton.TabIndex = 6;
            crmButton.Text = "CRM";
            crmButton.UseVisualStyleBackColor = true;
            // 
            // profButton
            // 
            profButton.BackColor = SystemColors.ButtonShadow;
            profButton.FlatAppearance.BorderSize = 0;
            profButton.FlatStyle = FlatStyle.Flat;
            profButton.Location = new Point(44, 547);
            profButton.Name = "profButton";
            profButton.Size = new Size(57, 57);
            profButton.TabIndex = 7;
            profButton.Text = "проф.";
            profButton.UseVisualStyleBackColor = false;
            // 
            // voprosButton
            // 
            voprosButton.BackColor = SystemColors.ButtonShadow;
            voprosButton.FlatAppearance.BorderSize = 0;
            voprosButton.FlatStyle = FlatStyle.Flat;
            voprosButton.Location = new Point(44, 605);
            voprosButton.Name = "voprosButton";
            voprosButton.Size = new Size(57, 57);
            voprosButton.TabIndex = 8;
            voprosButton.Text = "?";
            voprosButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(164, 35);
            label1.Name = "label1";
            label1.Size = new Size(296, 45);
            label1.TabIndex = 9;
            label1.Text = "Абоненты ТНС";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(967, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 60);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(738, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(212, 28);
            comboBox1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FIO, Abonent_number, Lic_schet, Uslugi });
            dataGridView1.Location = new Point(164, 210);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(621, 385);
            dataGridView1.TabIndex = 14;
            // 
            // FIO
            // 
            FIO.HeaderText = "ФИО";
            FIO.MinimumWidth = 6;
            FIO.Name = "FIO";
            FIO.Width = 160;
            // 
            // Abonent_number
            // 
            Abonent_number.HeaderText = "Абонентский номер";
            Abonent_number.MinimumWidth = 6;
            Abonent_number.Name = "Abonent_number";
            Abonent_number.Width = 160;
            // 
            // Lic_schet
            // 
            Lic_schet.HeaderText = "Лицевой счёт";
            Lic_schet.MinimumWidth = 6;
            Lic_schet.Name = "Lic_schet";
            Lic_schet.Width = 160;
            // 
            // Uslugi
            // 
            Uslugi.HeaderText = "Услуги";
            Uslugi.MinimumWidth = 6;
            Uslugi.Name = "Uslugi";
            Uslugi.Width = 160;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(usersButton);
            groupBox1.Controls.Add(equipManagmentButton);
            groupBox1.Controls.Add(activesButton);
            groupBox1.Controls.Add(billingButton);
            groupBox1.Controls.Add(helpButton);
            groupBox1.Controls.Add(crmButton);
            groupBox1.Controls.Add(voprosButton);
            groupBox1.Controls.Add(profButton);
            groupBox1.Location = new Point(1, -5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(157, 660);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // ActiveRadioButton
            // 
            ActiveRadioButton.AutoSize = true;
            ActiveRadioButton.BackColor = SystemColors.Control;
            ActiveRadioButton.FlatAppearance.BorderSize = 0;
            ActiveRadioButton.FlatAppearance.CheckedBackColor = Color.Silver;
            ActiveRadioButton.Location = new Point(191, 619);
            ActiveRadioButton.Name = "ActiveRadioButton";
            ActiveRadioButton.Size = new Size(98, 24);
            ActiveRadioButton.TabIndex = 16;
            ActiveRadioButton.TabStop = true;
            ActiveRadioButton.Text = "Активные";
            ActiveRadioButton.UseVisualStyleBackColor = false;
            // 
            // noActiveRadioButton
            // 
            noActiveRadioButton.AutoSize = true;
            noActiveRadioButton.BackColor = SystemColors.Control;
            noActiveRadioButton.FlatAppearance.BorderSize = 0;
            noActiveRadioButton.Location = new Point(396, 619);
            noActiveRadioButton.Name = "noActiveRadioButton";
            noActiveRadioButton.Size = new Size(115, 24);
            noActiveRadioButton.TabIndex = 17;
            noActiveRadioButton.TabStop = true;
            noActiveRadioButton.Text = "Неактивные";
            noActiveRadioButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 655);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
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
    }
}