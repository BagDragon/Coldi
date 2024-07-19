using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coldi
{
    public partial class PlaysForm : Form
    {
        public PlaysForm()
        {
            InitializeComponent();

        }

        private void PlaysForm_Load(object sender, EventArgs e)
        {
            LinearGradientBrush gradientBrush = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(20, 20, 20), Color.FromArgb(120, 0, 0), LinearGradientMode.Vertical);

            // Fill the form's background with the gradient brush
            this.Paint += (sender, e) =>
            {
                e.Graphics.FillRectangle(gradientBrush, this.ClientRectangle);
            };
        }

        private void SnakeBTN_Click(object sender, EventArgs e)
        {
            if (SnakePanel.Visible == true)
            {
                SnakePanel.Visible = false;
            }
            else
            {
                SnakePanel.Visible = true;
            }


        }

        private void SnakePlayPanel_Click(object sender, EventArgs e)
        {

        }

        private void SnakeViewCodeBTN_Click(object sender, EventArgs e)
        {

        }


        private void TikTakToeBTN_Click(object sender, EventArgs e)
        {

        }

        private void TagBTN_Click(object sender, EventArgs e)
        {

        }

        private void CoupleBTN_Click(object sender, EventArgs e)
        {

        }

        private void SnakePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
