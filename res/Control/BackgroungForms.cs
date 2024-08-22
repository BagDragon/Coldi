using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coldi.res.Control
{
    static class BackgroundForms
    {
        public static void backgroundForm(this Form form)
        {

            LinearGradientBrush gradientBrush = new LinearGradientBrush(form.ClientRectangle, Color.FromArgb(20, 20, 20), Color.FromArgb(120, 0, 0), LinearGradientMode.Vertical);

            // Fill the form's background with the gradient brush
            form.Paint += (sender, e) =>
            {
                e.Graphics.FillRectangle(gradientBrush, form.ClientRectangle);
            };
        }
    }
}
