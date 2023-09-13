using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Lab_work_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            rightGroupBox = new GroupBox();
            fourthRightButton = new Button();
            thirdRightButton = new Button();
            secondRightButton = new Button();
            firstRightButton = new Button();
            groupBox1.SuspendLayout();
            rightGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 112);
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
            usersButton.Click += usersButton_Click;
            // 
            // equipManagmentButton
            // 
            equipManagmentButton.Location = new Point(5, 210);
            equipManagmentButton.Name = "equipManagmentButton";
            equipManagmentButton.Size = new Size(146, 52);
            equipManagmentButton.TabIndex = 2;
            equipManagmentButton.Text = "Управление оборудованием";
            equipManagmentButton.UseVisualStyleBackColor = true;
            equipManagmentButton.Click += equipManagmentButton_Click;
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
            activesButton.Click += activesButton_Click;
            // 
            // billingButton
            // 
            billingButton.Location = new Point(5, 350);
            billingButton.Name = "billingButton";
            billingButton.Size = new Size(146, 52);
            billingButton.TabIndex = 4;
            billingButton.Text = "Биллинг";
            billingButton.UseVisualStyleBackColor = true;
            billingButton.Click += billingButton_Click;
            // 
            // helpButton
            // 
            helpButton.Location = new Point(6, 420);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(146, 52);
            helpButton.TabIndex = 5;
            helpButton.Text = "Поддержка пользователей";
            helpButton.UseVisualStyleBackColor = true;
            helpButton.Click += helpButton_Click;
            // 
            // crmButton
            // 
            crmButton.Location = new Point(6, 489);
            crmButton.Name = "crmButton";
            crmButton.Size = new Size(146, 52);
            crmButton.TabIndex = 6;
            crmButton.Text = "CRM";
            crmButton.UseVisualStyleBackColor = true;
            crmButton.Click += crmButton_Click;
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
            profButton.Click += profButton_Click;
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
            voprosButton.Click += voprosButton_Click;
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
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(901, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(128, 127);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(696, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(199, 28);
            comboBox1.TabIndex = 11;
            comboBox1.Text = "ФИО_пользователя";
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
            groupBox1.Size = new Size(157, 661);
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
            ActiveRadioButton.CheckedChanged += ActiveRadioButton_CheckedChanged;
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
            noActiveRadioButton.CheckedChanged += noActiveRadioButton_CheckedChanged;
            // 
            // rightGroupBox
            // 
            rightGroupBox.Controls.Add(fourthRightButton);
            rightGroupBox.Controls.Add(thirdRightButton);
            rightGroupBox.Controls.Add(secondRightButton);
            rightGroupBox.Controls.Add(firstRightButton);
            rightGroupBox.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rightGroupBox.Location = new Point(791, 135);
            rightGroupBox.Name = "rightGroupBox";
            rightGroupBox.Size = new Size(250, 477);
            rightGroupBox.TabIndex = 18;
            rightGroupBox.TabStop = false;
            rightGroupBox.Text = "        События";
            // 
            // fourthRightButton
            // 
            fourthRightButton.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            fourthRightButton.Location = new Point(6, 379);
            fourthRightButton.Name = "fourthRightButton";
            fourthRightButton.Size = new Size(238, 110);
            fourthRightButton.TabIndex = 3;
            fourthRightButton.Text = "Отчёт по Адмиралтейскому району";
            fourthRightButton.UseVisualStyleBackColor = true;
            fourthRightButton.Click += fourthRightButton_Click;
            // 
            // thirdRightButton
            // 
            thirdRightButton.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            thirdRightButton.Location = new Point(6, 280);
            thirdRightButton.Name = "thirdRightButton";
            thirdRightButton.Size = new Size(238, 95);
            thirdRightButton.TabIndex = 2;
            thirdRightButton.Text = "Собрание акционеров 12:00";
            thirdRightButton.UseVisualStyleBackColor = true;
            thirdRightButton.Click += thirdRightButton_Click;
            // 
            // secondRightButton
            // 
            secondRightButton.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            secondRightButton.Location = new Point(6, 179);
            secondRightButton.Name = "secondRightButton";
            secondRightButton.Size = new Size(238, 95);
            secondRightButton.TabIndex = 1;
            secondRightButton.Text = "Отчёт по инвентаризации";
            secondRightButton.UseVisualStyleBackColor = true;
            secondRightButton.Click += secondRightButton_Click;
            // 
            // firstRightButton
            // 
            firstRightButton.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            firstRightButton.Location = new Point(6, 78);
            firstRightButton.Name = "firstRightButton";
            firstRightButton.Size = new Size(238, 95);
            firstRightButton.TabIndex = 0;
            firstRightButton.Text = "Собрание менеджеров 10:00";
            firstRightButton.UseVisualStyleBackColor = true;
            firstRightButton.Click += firstRightButton_Click;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            rightGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

            Init();

            GraphicsPath grPathProf = new();
            grPathProf.AddEllipse(0, 0, profButton.Width, profButton.Height);
            Region profReg = new(grPathProf);
            profButton.Region = profReg;

            GraphicsPath grPathVop = new();
            grPathVop.AddEllipse(0, 0, voprosButton.Width, voprosButton.Height);
            Region vopReg = new(grPathVop);
            voprosButton.Region = vopReg;



            GraphicsPath grPathUser = new();
            grPathUser.AddEllipse(0, 0, pictureBox2.Width, pictureBox2.Height);
            Region picture2 = new(grPathUser);
            pictureBox2.Region = picture2;
        }
        public void Init()
        {
            
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(usersButton.Text);
        }

        private void equipManagmentButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(equipManagmentButton.Text);
        }

        private void activesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(activesButton.Text);
        }

        private void billingButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(billingButton.Text);
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(helpButton.Text);
        }

        private void crmButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(crmButton.Text);
        }

        private void profButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(profButton.Text);
        }

        private void voprosButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(voprosButton.Text);
        }

        private void firstRightButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(firstRightButton.Text);
        }

        private void secondRightButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(secondRightButton.Text);
        }

        private void thirdRightButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(thirdRightButton.Text);
        }

        private void fourthRightButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(fourthRightButton.Text);
        }

        private void ActiveRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(ActiveRadioButton.Text);
        }

        private void noActiveRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(noActiveRadioButton.Text);
        }
    }
}