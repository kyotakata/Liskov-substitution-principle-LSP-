using L060.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L060
{
    public partial class Form1 : Form
    {
        private IProduct _product;
        public Form1()
        {
            InitializeComponent();

            _product = ProductFactory.Create();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var csv = _product as ProductCsv;
            //if(csv != null)
            //{
            //    if (!csv.FileExists())
            //    {
            //        return;
            //    }
            //}
            if (_product.IsReady())
            {
                var entity = _product.GetData();
            }
        }
    }
}
