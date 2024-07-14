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

            LinearGradientBrush gradientBrush = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(111, 0, 0), Color.FromArgb(0,0,0), LinearGradientMode.ForwardDiagonal);

            // Fill the form's background with the gradient brush
            this.Paint += (sender, e) =>
            {
                e.Graphics.FillRectangle(gradientBrush, this.ClientRectangle);
            };

        }

      

        public void StartBTN_Design()
        {
            StartBTN.BackColor = Color.FromArgb(189, 52, 52);

        }

       
    }
}
