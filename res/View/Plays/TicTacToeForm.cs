namespace Coldi
{
    public partial class TicTacToeForm : Form
    {     
        public TicTacToeForm()
        {
            InitializeComponent();

        }

        int player = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            ((Button)sender).Text = player++ % 2 == 0 ? "X" : "O";

            if (((Button)sender).Text == "X")
            {
                stroke.Text = "Stroke: O";
            }
            else 
            {
                stroke.Text = "Stroke: X";
            }

            checkWin();

        }




        private void checkWin()
        {
            Button[,] buttons = {
                { button1, button2, button3 },
                { button4, button5,button6},
                { button7, button8, button9} };

            if (buttons[0, 0].Text == buttons[0, 1].Text && buttons[0, 1].Text == buttons[0, 2].Text)
            {

                if (buttons[0, 0].Text != "")
                {
                    MessageBox.Show("Вы победили!");
                    return;
                }
            }
            if (buttons[1, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[1, 2].Text)
            {
                if (buttons[1, 0].Text != "")
                    MessageBox.Show("Вы победили!");
            }
            if (buttons[2, 0].Text == buttons[2, 1].Text && buttons[2, 1].Text == buttons[2, 2].Text)
            {
                if (buttons[2, 0].Text != "")
                    MessageBox.Show("Вы победили!");
            }
            if (buttons[0, 0].Text == buttons[1, 0].Text && buttons[1, 0].Text == buttons[2, 0].Text)
            {
                if (buttons[0, 0].Text != "")
                    MessageBox.Show("Вы победили!");
            }
            if (buttons[0, 1].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 1].Text)
            {
                if (buttons[0, 1].Text != "")
                    MessageBox.Show("Вы победили!");
            }
            if (buttons[0, 2].Text == buttons[1, 2].Text && buttons[1, 2].Text == buttons[2, 2].Text)
            {
                if (buttons[0, 2].Text != "")
                    MessageBox.Show("Вы победили!");
            }
            if (buttons[0, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 2].Text)
            {
                if (buttons[0, 0].Text != "")
                    MessageBox.Show("Вы победили!");
            }
            if (buttons[2, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[0, 2].Text)
            {
                if (buttons[2, 0].Text != "")
                    MessageBox.Show("Вы победили!");
            }
        }


        private void reset_Click(object sender, EventArgs e)
        {
            Button[,] buttons = {
                { button1, button2, button3 },
                { button4, button5,button6},
                { button7, button8, button9} };

            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    buttons[j, i].Text = "";
                }
            }
        }


    }
}
