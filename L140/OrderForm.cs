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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            BindingList<Order> source = new BindingList<Order>();
            source.Add(new Order(1, DateTime.Now, 111, 200,DateTime.MinValue));
            source.Add(new Order(2, DateTime.Now, 222, 201, DateTime.MinValue));
            source.Add(new Order(3, DateTime.Now, 333, 202, DateTime.MinValue));
            source.Add(new Order(4, DateTime.Now, 444, 203, DateTime.MinValue));
            dataGridView1.DataSource = source;

            dataGridView1.Columns[nameof(Order.DeleteDate)].Visible = false;
            dataGridView1.Columns[nameof(Order.DeleteMode)].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var f = new OrderHistoryForm())
            {
                f.ShowDialog();
            }
        }
    }
}
