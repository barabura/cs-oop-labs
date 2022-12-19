using System;
using System.Windows.Forms;
using oop_labs;

internal class CustomTextBox : TextBox
{
    public event EventHandler<ClipboardEventArguments> Pasted;

    protected override void WndProc(ref Message m)
    {
        if (m.Msg == 0x302 && Clipboard.ContainsText())
        {
            var evt = Pasted;

            if (evt != null)
            {
                evt(this, new ClipboardEventArguments(Clipboard.GetText()));
                return;
            }
        }
        base.WndProc(ref m);
    }
}