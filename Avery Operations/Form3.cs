using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avery_Operations
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            float Box1, Box2, Box3, Box4, Box5, Box6;

            bool ifBox1 = float.TryParse(txtBox1.Text, out Box1);
            bool ifBox2 = float.TryParse(txtBox2.Text, out Box2);
            bool ifBox3 = float.TryParse(txtBox3.Text, out Box3);
            bool ifBox4 = float.TryParse(txtBox4.Text, out Box4);
            bool ifBox5 = float.TryParse(txtBox5.Text, out Box5);
            bool ifBox6 = float.TryParse(txtBox6.Text, out Box6);

            dataGridView1.Rows.Add(1, 2, 3, 4, 5, 6);
            dataGridView1.Rows.Add(1, 2, 3, 4, 5, 6);
            dataGridView1.Rows.Add(1, 2, 3, 4, 5, 6);
            dataGridView1.Rows.Add(1, 2, 3, 4, 5, 6);
            dataGridView1.Rows.Add(1, 2, 3, 4, 5, 6);
        }
    }
}
