using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L150
{
    public sealed class TextBoxEx : TextBox
    {
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            if (this.Text.Length < 5)
            {
                ForeColor = Color.Red;
                return;
            }

            ForeColor = Color.Black;
        }
    }
}
