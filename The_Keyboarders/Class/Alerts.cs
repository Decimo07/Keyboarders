using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Keyboarders.Class
{
    internal class Alerts
    {
        public void AlertBoxs(Color backColor, Color color, string title, string text, Image icon)
        {
            Alertbox.frm_Alertbox frm = new Alertbox.frm_Alertbox();
            frm.BackColor = backColor;
            frm.ColorAlertBox = color;
            frm.TitleAlertBox = title;
            frm.TextAlertBox = text;
            frm.IconeAlertBox = icon;
            frm.ShowDialog();

        }

    }
}
