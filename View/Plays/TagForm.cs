using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coldi
{
    public partial class TagForm : Form
    {
        Button[,] buttons;
        List<Image> images;

        public TagForm()
        {
            InitializeComponent();
            
        }

        private void TagForm_Load(object sender, EventArgs e)
        {
            FillTheAraayOfButtons();

            images = new List<Image>();

            for (int i = 1; i < 9; i++)
            {
                
                images.Add(Image.FromFile(@"C:\Users\пк\Desktop\Projects\Coldi\res\img\TAGimages\" + i + ".jpg"));
            }
            SetUpGame();
        }

        void SetUpGame()
        {
            Random rng = new Random();
            List<Image> imagesCopy = new List<Image>(images); // Создаем копию списка images

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (imagesCopy.Count > 0)
                    {
                        int randomImageIndex = rng.Next(0, imagesCopy.Count);
                        buttons[x, y].Image = imagesCopy[randomImageIndex];
                        imagesCopy.RemoveAt(randomImageIndex);
                    }
                }
            }
        }

        void FillTheAraayOfButtons()
        {
            buttons = new Button[3, 3];
            buttons[0, 0] = button1;
            buttons[1, 0] = button2;
            buttons[2, 0] = button3;
            buttons[0, 1] = button4;
            buttons[1, 1] = button5;
            buttons[2, 1] = button6;
            buttons[0, 2] = button7;
            buttons[1, 2] = button8;
            buttons[2, 2] = button9;
        }

        private void button_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            if (button.Image != null)
            {

                for (int x = 0; x < 3; x++)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        if (buttons[x, y] == button)
                        {
                            CheckNeighbours(x, y);
                        }
                    }
                }
            }


        }


        void CheckNeighbours(int xB, int yB)
        {
            for (int x = xB - 1; x <= xB + 1; x++)
            {
                for (int y = yB - 1; y <= yB + 1; y++)
                {
                    if (x >= 0 && x < 3 && y >= 0 && y < 3 && (xB == x || yB == y))
                    {
                        if (buttons[x, y].Image == null)
                        {
                            buttons[x, y].Image = buttons[xB, yB].Image;
                            buttons[xB, yB].Image = null;
                        }
                    }
                }
            }
        }
    }
}
