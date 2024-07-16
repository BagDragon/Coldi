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
    }
}
