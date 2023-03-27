using L110.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L110
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindingList<ProductViewModelDataSource> source = 
                new BindingList<ProductViewModelDataSource>();

            source.Add(new ProductViewModelDataSource(new ProductEntity(1, "AAA", 111)));
            source.Add(new ProductViewModelDataSource(new ProductEntity(2, "BBB", 222)));
            source.Add(new ProductViewModelDataSource(new ProductEntity(3, "CCC", 333)));

            dataGridView1.DataSource = source;
        }
    }
}
