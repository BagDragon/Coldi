using Coldi.Control;
using Coldi.Model;

namespace Coldi
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }



        private void RegBTN_Click(object sender, EventArgs e)
        {
            AddUsers.AddUser(loginBox.Text, emailBox.Text, PasswordBox.Text, Repeat_PasswordBox.Text);
            this.Close();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            BackgroundForms.backgroundForm(this);
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            Authorization auth = new Authorization();
            auth.Show();
        }
    }
}
