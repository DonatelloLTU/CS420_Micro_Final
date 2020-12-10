using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Bartender bar = new Bartender();
            bar.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 hostess = new Form1();
            hostess.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Waiter w = new Waiter();
            w.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Kitchen k = new Kitchen();
            k.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            BussBoy b = new BussBoy();
            b.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
