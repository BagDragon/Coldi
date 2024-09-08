using Coldi.Control;
using System.Drawing.Drawing2D;


namespace Coldi
{
    public partial class ProgramsForm : Form
    {
        public ProgramsForm(string usName)
        {
            InitializeComponent();

            UserName.Text = usName;
        }

        private void ProgramsForm_Load(object sender, EventArgs e)
        {
            BackgroundForms.backgroundForm(this);
        }

        CalculatorForm calculatorForm = new CalculatorForm();
        AsagoForm asagoForm = new AsagoForm();
        ToDoListForm toDoListForm = new ToDoListForm();

        bool checkPanel;

        private void ToDoListBTN_Click(object sender, EventArgs e)
        {
            ActionsWithPanel.OpenAndClose_Panel(ToDoListPanel, checkPanel);

            ActionsWithPanel.block_Panel(ASAGOpanel, CalculatorPanel, checkPanel);
        }

        private void CalculatorBTN_Click(object sender, EventArgs e)
        {
            ActionsWithPanel.OpenAndClose_Panel(CalculatorPanel, checkPanel);

            ActionsWithPanel.block_Panel(ASAGOpanel, ToDoListPanel, checkPanel);
        }

        private void OsagoBTN_Click(object sender, EventArgs e)
        {
            ActionsWithPanel.OpenAndClose_Panel(ASAGOpanel, checkPanel);

            ActionsWithPanel.block_Panel(ToDoListPanel, CalculatorPanel, checkPanel);
        }

        private void ViewCode_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;

            ActionsWithPanel.OpenAndClose_Panel(ASAGOpanel, ASAGOviewcodePanel);
            ActionsWithPanel.OpenAndClose_Panel(CalculatorPanel, CalcViewCodePanel);
            ActionsWithPanel.OpenAndClose_Panel(ToDoListPanel, ToDoList_ViewCodepanel);
        
        }

        private void LaunchProgram_Click(object sender, EventArgs e)
        {

            ActionsWithPanel.openForm_Panel(ASAGOpanel, asagoForm);
            ActionsWithPanel.openForm_Panel(ToDoListPanel, toDoListForm);
            ActionsWithPanel.openForm_Panel(CalculatorPanel, calculatorForm);                      
        }

        private void closePanel_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = false;
            ToDoList_ViewCodepanel.Visible = false;
            ASAGOviewcodePanel.Visible = false;
            CalcViewCodePanel.Visible = false;

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

        private void BackBTNprog_Click(object sender, EventArgs e)
        {
            ModeSelection modeSelection = new ModeSelection(UserName.Text);
            modeSelection.Show();
            this.Close();
        }
    }
}
