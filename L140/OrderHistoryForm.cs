using L140.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L140
{
    public partial class OrderHistoryForm : Form
    {
        public OrderHistoryForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            BindingList<Order> source = new BindingList<Order>();
            source.Add(new Order(1, DateTime.Now, 111, 200, DateTime.Now));
            source.Add(new Order(2, DateTime.Now, 222, 201, DateTime.Now));
            source.Add(new Order(3, DateTime.Now, 333, 202, DateTime.Now));
            source.Add(new Order(4, DateTime.Now, 444, 203, DateTime.Now));
            dataGridView1.DataSource = source;
        }
    }
}
