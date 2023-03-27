using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using L040.Objects;

namespace L040
{
    public partial class Form1 : Form
    {
        private Member.MemberKind _loginKind = Member.MemberKind.Gold;
        private Member _member;
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            _member = Member.Create(_loginKind);
            this.Text = _loginKind.ToString() + _member.GetId();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var price = Convert.ToInt32(PriceTextBox.Text);
            button1.Text = _member.GetPoint(price).ToString();

            var gold = _member as Gold;
            if (gold != null)
            {
                button1.Text = gold.GetDoublePoint(price).ToString();
            }

            var p = _member as Platinum;
            if (p != null)
            {
                button1.Text = p.GetDoublePoint(price).ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
