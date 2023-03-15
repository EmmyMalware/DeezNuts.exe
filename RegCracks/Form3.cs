using System;
using System.Windows.Forms;

namespace RegCracks
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label3.Text = "seede: " + Form4.seed;
        }
    }
}
