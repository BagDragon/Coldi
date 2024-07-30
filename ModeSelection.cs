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
    public partial class ModeSelection : Form
    {
        Authorization authorization = new Authorization();
        public ModeSelection(string nameUs)
        {
            InitializeComponent();

            
            nameUser.Text = nameUs;
        }
        

        private void ModeSelection_Load(object sender, EventArgs e)
        {
            LinearGradientBrush gradientBrush = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(20, 20, 20), Color.FromArgb(120, 0, 0), LinearGradientMode.Vertical);

            // Fill the form's background with the gradient brush
            this.Paint += (sender, e) =>
            {
                e.Graphics.FillRectangle(gradientBrush, this.ClientRectangle);
            };
        }

        private void PlayBTN_Click(object sender, EventArgs e)
        {
           PlaysForm playForm = new PlaysForm(nameUser.Text);
            playForm.Show();
            this.Close();
        }

        private void ProgramsBTN_Click(object sender, EventArgs e)
        {
            ProgramsForm programsForm = new ProgramsForm(nameUser.Text);
            programsForm.Show();
            this.Close();
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Close();
            
        }
    }
}
