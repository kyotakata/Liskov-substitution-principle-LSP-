using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using L050.Objects;

namespace L050
{
    public partial class Form1 : Form
    {
        private Member.MemberKind _loginKind = Member.MemberKind.Platinum;
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
            //button1.Text = _member.GetPoint(price).ToString();


            //button1.Text = _member.GetDoublePoint(price).ToString();

            var p =_member.GetPoint(price) + _member.GetDoublePoint(price);
            button1.Text = p.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
