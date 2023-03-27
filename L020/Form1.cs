using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using L020.Objects;

namespace L020
{
    public partial class Form1 : Form
    {
        private MemberKind _loginKind = MemberKind.Gold;
        private IMember _member;
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            this.Text = _loginKind.ToString();
            _member = MemberFactory.Create(_loginKind);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var price = Convert.ToInt32(PriceTextBox.Text);
            button1.Text = _member.GetPoint(price).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
