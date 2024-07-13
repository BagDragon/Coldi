using Npgsql;
using System.Data;

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

       
    }
}
