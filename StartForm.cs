using Npgsql;
using System.Data;
using System.Drawing.Drawing2D;

namespace Coldi
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();

            StartBTN_Design();


            
        }



        public void StartBTN_Design()
        {
            StartBTN.BackColor = Color.FromArgb(189, 52, 52);

        }

        private void StartBTN_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();

            this.Hide();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            LinearGradientBrush gradientBrush = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(20, 20, 20), Color.FromArgb(120, 0, 0), LinearGradientMode.ForwardDiagonal);

            // Fill the form's background with the gradient brush
            this.Paint += (sender, e) =>
            {
                e.Graphics.FillRectangle(gradientBrush, this.ClientRectangle);
            };
        }
    }
}
