using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// This class is not capturing mouse events outside of the application window.
/// Need modifications, see https://stackoverflow.com/questions/2063974/how-do-i-capture-the-mouse-move-event
/// </summary>
class MouseMessageFilter : IMessageFilter
{
    public static event MouseEventHandler MouseMove = delegate { };
    const int WM_MOUSEMOVE = 0x0200;

    public bool PreFilterMessage(ref Message m)
    {
        if (m.Msg == WM_MOUSEMOVE)
        {
            Point mousePosition = Control.MousePosition;

            MouseMove(null, new MouseEventArgs(MouseButtons.None, 0, mousePosition.X, mousePosition.Y, 0));
        }

        return false;
    }
}