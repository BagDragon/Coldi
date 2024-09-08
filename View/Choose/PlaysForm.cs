using Coldi.Control;
using System.Drawing.Drawing2D;

namespace Coldi
{
    public partial class PlaysForm : Form
    {
        
        public PlaysForm(string UsName)
        {
            InitializeComponent();
            UserName.Text = UsName;
        }

        bool checkPanel;


        SnakeForm snakeForm = new SnakeForm();
        TicTacToeForm TicTacToeForm = new TicTacToeForm();
        TagForm tagForm = new TagForm();
        FindCoupleForm findCoupleForm = new FindCoupleForm();

        private void PlaysForm_Load(object sender, EventArgs e)
        {
            BackgroundForms.backgroundForm(this);
        }

        private void SnakeBTN_Click(object sender, EventArgs e)
        {
            ActionsWithPanel.OpenAndClose_Panel(SnakePanel, checkPanel);

            ActionsWithPanel.block_Panel(TicTacToePanel, TagPanel, FindCouplePanel, checkPanel);
          
        }


        private void TikTakToeBTN_Click(object sender, EventArgs e)
        {
           ActionsWithPanel.OpenAndClose_Panel(TicTacToePanel, checkPanel);
            
           ActionsWithPanel.block_Panel(SnakePanel,TagPanel,FindCouplePanel, checkPanel);
                     
        }

        private void TagBTN_Click(object sender, EventArgs e)
        {
            ActionsWithPanel.OpenAndClose_Panel(TagPanel, checkPanel);

            ActionsWithPanel.block_Panel(SnakePanel,TicTacToePanel,FindCouplePanel,checkPanel);           
        }

        private void CoupleBTN_Click(object sender, EventArgs e)
        {
            ActionsWithPanel.OpenAndClose_Panel(FindCouplePanel, checkPanel);

            ActionsWithPanel.block_Panel(SnakePanel,TicTacToePanel,TagPanel, checkPanel);
        }

        private void ViewCodeBTN_Click(object sender, EventArgs e)
        {

            MainCodePanel.Visible = !MainCodePanel.Visible;

            ActionsWithPanel.OpenAndClose_Panel(SnakePanel, SnakeViewCodePanel);
            ActionsWithPanel.OpenAndClose_Panel(TicTacToePanel, TicTacToeViewCodePanel);
            ActionsWithPanel.OpenAndClose_Panel(TagPanel, TagViewCodePanel);
            ActionsWithPanel.OpenAndClose_Panel(FindCouplePanel, FindCoupleViewCodePanel);
          

        }

        private void ClosePanelBTN_Click(object sender, EventArgs e)
        {
            MainCodePanel.Visible = false;
            SnakeViewCodePanel.Visible = false;
            TicTacToeViewCodePanel.Visible = false;
            TagViewCodePanel.Visible = false;
        }

        private void PlayPanel_Click(object sender, EventArgs e)
        {
            ActionsWithPanel.openForm_Panel(SnakePanel, snakeForm);
            ActionsWithPanel.openForm_Panel(TicTacToePanel, TicTacToeForm);
            ActionsWithPanel.openForm_Panel(TagPanel, tagForm);
            ActionsWithPanel.openForm_Panel(FindCouplePanel,findCoupleForm);          
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            ModeSelection modeSelection = new ModeSelection(UserName.Text);
            modeSelection.Show();
            this.Close();
        }
    }
}
