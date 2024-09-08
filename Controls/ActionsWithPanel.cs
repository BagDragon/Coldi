using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coldi.Controls
{
    static class ActionsWithPanel
    {
        static public void OpenAndClose_Panel(Panel openPanel, bool open)
        {
            openPanel.Visible = !openPanel.Visible;
            open = !open;

        }
        static public void OpenAndClose_Panel(Panel panelMain, Panel panelView)
        {

            if (panelMain.Visible)
            {
                panelView.Visible = true;
                panelMain.Visible = !panelMain.Visible;
            }


        }


        static public void block_Panel(Panel panel1, Panel panel2, Panel panel3, bool BlockPanel)
        {

            BlockPanel = !BlockPanel;

            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;

        }

        static public void block_Panel(Panel panel1, Panel panel2, bool BlockPanel)
        {
            BlockPanel = !BlockPanel;

            panel1.Visible = false;
            panel2.Visible = false;
        }

        static public void openForm_Panel(Panel panel, Form form)
        {
            if (panel.Visible)
            {
                form.Show();
            }
        }
    }
}
