using System.Drawing.Drawing2D;

namespace Coldi
{
    public partial class PlaysForm : Form
    {
        public PlaysForm()
        {
            InitializeComponent();

        }

        SnakeForm snakeForm = new SnakeForm();
        TicTacToeForm TicTacToeForm = new TicTacToeForm();
        TagForm tagForm = new TagForm();
        FindCoupleForm findCoupleForm = new FindCoupleForm();

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

            if (TicTacToePanel.Visible == true || TagPanel.Visible == true || FindCouplePanel.Visible == true)
            {
                SnakePanel.Visible = false;
                MessageBox.Show("To launch the panel, you need to close the active ones by clicking on the game icon");
            }


        }






        private void TikTakToeBTN_Click(object sender, EventArgs e)
        {
            if (TicTacToePanel.Visible == true)
            {
                TicTacToePanel.Visible = false;
            }
            else
            {
                TicTacToePanel.Visible = true;
            }

            if (SnakePanel.Visible == true || TagPanel.Visible == true || FindCouplePanel.Visible == true)
            {
                TicTacToePanel.Visible = false;
                MessageBox.Show("To launch the panel, you need to close the active ones by clicking on the game icon");
            }
        }

        private void TagBTN_Click(object sender, EventArgs e)
        {
            if (TagPanel.Visible == true)
            {
                TagPanel.Visible = false;
            }
            else
            {
                TagPanel.Visible = true;
            }

            if (SnakePanel.Visible == true || TicTacToePanel.Visible == true || FindCouplePanel.Visible == true)
            {
                TagPanel.Visible = false;
                MessageBox.Show("To launch the panel, you need to close the active ones by clicking on the game icon");
            }
        }

        private void CoupleBTN_Click(object sender, EventArgs e)
        {
            if (FindCouplePanel.Visible == true)
            {
                FindCouplePanel.Visible = false;
            }
            else
            {
                FindCouplePanel.Visible = true;
            }

            if (SnakePanel.Visible == true || TicTacToePanel.Visible == true || TagPanel.Visible == true)
            {
                TagPanel.Visible = false;
                MessageBox.Show("To launch the panel, you need to close the active ones by clicking on the game icon");
            }
        }

        private void ViewCodeBTN_Click(object sender, EventArgs e)
        {

            if (MainCodePanel.Visible == false)
            {
                MainCodePanel.Visible = true;

                if (SnakePanel.Visible == true)
                {
                    SnakePanel.Visible = false;
                    SnakeViewCodePanel.Visible = true;
                }

                if (TicTacToePanel.Visible == true)
                {
                    TicTacToePanel.Visible = false;
                    TicTacToeViewCodePanel.Visible = true;
                }

                if (TagPanel.Visible == true)
                {
                    TagPanel.Visible = false;
                    TagViewCodePanel.Visible = true;
                }

                if (FindCouplePanel.Visible == true)
                {
                    FindCouplePanel.Visible = false;
                    FindCoupleViewCodePanel.Visible = true;
                }
            }
            else
            {
                MainCodePanel.Visible = false;
            }

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
            if (SnakePanel.Visible == true)
            {
               snakeForm.Show();
            }

            if (TicTacToePanel.Visible == true)
            {
                TicTacToeForm.Show(); 
            }

            if (TagPanel.Visible == true)
            {
                tagForm.Show();
            }

            if (FindCouplePanel.Visible == true)
            {
                findCoupleForm.Show();
            }
        }
    }
}
