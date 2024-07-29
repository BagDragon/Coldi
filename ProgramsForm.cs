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
    public partial class ProgramsForm : Form
    {
        public ProgramsForm()
        {
            InitializeComponent();
        }

        private void ProgramsForm_Load(object sender, EventArgs e)
        {
            LinearGradientBrush gradientBrush = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(20, 20, 20), Color.FromArgb(120, 0, 0), LinearGradientMode.Vertical);

            // Fill the form's background with the gradient brush
            this.Paint += (sender, e) =>
            {
                e.Graphics.FillRectangle(gradientBrush, this.ClientRectangle);
            };
        }

        CalculatorForm calculatorForm = new CalculatorForm();
        AsagoForm asagoForm = new AsagoForm();
        ToDoListForm toDoListForm = new ToDoListForm();


        private void ToDoListBTN_Click(object sender, EventArgs e)
        {
            if (ToDoListPanel.Visible == false)
            {
                ToDoListPanel.Visible = true;
            }
            else
            {
                ToDoListPanel.Visible = false;
            }

            if (CalculatorPanel.Visible == true || ASAGOpanel.Visible == true)
            {
                ToDoListPanel.Visible = false;
                MessageBox.Show("To launch the panel, you need to close the active ones by clicking on the game icon");
            }
        }

        private void CalculatorBTN_Click(object sender, EventArgs e)
        {
            if (CalculatorPanel.Visible == false)
            {
                CalculatorPanel.Visible = true;
            }
            else
            {
                CalculatorPanel.Visible = false;
            }

            if (ToDoListPanel.Visible == true || ASAGOpanel.Visible == true)
            {
                CalculatorPanel.Visible = false;
                MessageBox.Show("To launch the panel, you need to close the active ones by clicking on the game icon");
            }
        }

        private void OsagoBTN_Click(object sender, EventArgs e)
        {
            if (ASAGOpanel.Visible == false)
            {
                ASAGOpanel.Visible = true;
            }
            else
            {
                ASAGOpanel.Visible = false;
            }

            if (ToDoListPanel.Visible == true || CalculatorPanel.Visible == true)
            {
                ASAGOpanel.Visible = false;
                MessageBox.Show("To launch the panel, you need to close the active ones by clicking on the game icon");
            }
        }

        private void ViewCode_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            if (ASAGOpanel.Visible)
            {
                ASAGOviewcodePanel.Visible = true;
                CalcViewCodePanel.Visible = false;
                ToDoList_ViewCodepanel.Visible = false;

                ASAGOpanel.Visible = false;
            }
            if (ToDoListPanel.Visible)
            {
                ToDoList_ViewCodepanel.Visible = true;

                CalcViewCodePanel.Visible = false;
                ASAGOviewcodePanel.Visible = false;

                ToDoListPanel.Visible = false;
            }
            if (CalculatorPanel.Visible)
            {
                CalcViewCodePanel.Visible = true;

                ToDoList_ViewCodepanel.Visible = false;
                ASAGOviewcodePanel.Visible = false;

                CalculatorPanel.Visible = false;
            }
        }

        private void LaunchProgram_Click(object sender, EventArgs e)
        {
            if (ASAGOpanel.Visible)
            {
                asagoForm.Show();
            }
            if (ToDoListPanel.Visible)
            {
                toDoListForm.Show();
            }
            if (CalculatorPanel.Visible)
            {
                calculatorForm.Show();
            }
        }

        private void closeMainPanel_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = false;
        }

        private void formASAGOview_Click(object sender, EventArgs e)
        {
            AsagolistBox.Visible = true;
            classASAGOlistBox.Visible = false;
        }

        private void classCheckAsagoView_Click(object sender, EventArgs e)
        {
            classASAGOlistBox.Visible = true;
            AsagolistBox.Visible = false;
        }

        private void ToDoListViewCodeForm_Click(object sender, EventArgs e)
        {
            ConnectDBpanel.Visible = false;
            TableViewBD_ToDoList.Visible = false;
        }

        private void ConnectDBView_ToDoList_Click(object sender, EventArgs e)
        {
            ConnectDBpanel.Visible = true;
            TableViewBD_ToDoList.Visible = false;
        }

        private void CreateTableView_ToDoList_Click(object sender, EventArgs e)
        {
            TableViewBD_ToDoList.Visible = true;
            ConnectDBpanel.Visible = false;
        }

      
    }
}
