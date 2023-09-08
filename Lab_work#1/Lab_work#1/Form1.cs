using System.Drawing.Drawing2D;

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
            GraphicsPath grPathProf = new();
            grPathProf.AddEllipse(0, 0, profButton.Width, profButton.Height);
            Region profReg = new(grPathProf);
            profButton.Region = profReg;

            GraphicsPath grPathVop = new();
            grPathVop.AddEllipse(0, 0, voprosButton.Width, voprosButton.Height);
            Region vopReg = new(grPathVop);
            voprosButton.Region = vopReg;
        }
    }
}