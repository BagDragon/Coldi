using System.Reflection.Metadata;
using Coldi.res.Model;

namespace Coldi
{
    public partial class AsagoForm : Form
    {
        public AsagoForm()
        {
            InitializeComponent();

        }



        private void AsagoForm_Load(object sender, EventArgs e)
        {
            
        }

        private void RegComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            CityComboBox.Items.Clear();
            CityComboBox.Visible = true;
           
            ChecksAsago.checkReg(RegComboBox, CityComboBox);
        }

        private void CityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChecksAsago.Score(RegComboBox, CityComboBox, ScoreKof);
            CityComboBox.Visible = false;
            CityComboBox.Items.Clear ();
        }
        

      


        private void resultBTN_Click(object sender, EventArgs e)
        {
           
            ChecksAsago.CheckAge_and_Experience(AgeTextBox, ExperienceTextBox, kofAge_and_Experience);
            ChecksAsago.CheckCountDriver(limitedRadioButton, unlimitedRadioButton, kofDrivers);
            ChecksAsago.Check_KMB(kofKMB, ExperienceTextBox, unlimitedRadioButton);
            ChecksAsago.Check_Power(PowerTextBox, kofPower);
            ChecksAsago.CheckTarif(TransportСategoryСomboBox, RateLabel);

            double kofRegionCity= double.Parse(ScoreKof.Text);
            double kofA_and_E= double.Parse(kofAge_and_Experience.Text);
            double kofDr = double.Parse(kofDrivers.Text);
            double kof_kmb= double.Parse(kofKMB.Text);
            double kof_power = double.Parse(kofPower.Text);
            int Rate_Label = int.Parse(RateLabel.Text);

            double result = Rate_Label * kofA_and_E * kofDr * kof_kmb * kofRegionCity * kof_kmb;
            double resRound = Math.Round(result, 2);
            resultLabel.Text = resRound.ToString();


        }

    }
}