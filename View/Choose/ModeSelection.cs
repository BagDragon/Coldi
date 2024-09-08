using Coldi.Control;
using System;
using System.Drawing.Drawing2D;


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
            BackgroundForms.backgroundForm(this);
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
