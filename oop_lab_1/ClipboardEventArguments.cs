using System;

namespace oop_labs
{
    internal class ClipboardEventArguments : EventArgs
    {
        public string ClipboardText { get; set; }

        public ClipboardEventArguments(string clipboardText)
        {
            ClipboardText = clipboardText;
        }
    }
}