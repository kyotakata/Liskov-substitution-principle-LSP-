using L090.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L090
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            X01 x01 = new X01(1, DateTime.Now, 111f, -1);
            X02 x02 = new X02(x01, 222f);
            //x02.
            //var aaa = x02.
        }
    }
}
