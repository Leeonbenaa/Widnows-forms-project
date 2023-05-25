using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analitička_geometrija_prostora
{
    public partial class OsnovneOperacije : Form
    {
        public OsnovneOperacije()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Visible = false;
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonTeorija_Click(object sender, EventArgs e)
        {
            AlgoritmiUdaljenost form = new AlgoritmiUdaljenost();
            form.Show();
            Visible= false; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlgoritmiUdaljenost form = new AlgoritmiUdaljenost();
            form.Show();
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AlgoritmiUdaljenost form = new AlgoritmiUdaljenost();
            form.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            AlgoritmiUdaljenost form = new AlgoritmiUdaljenost();
            form.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AlgoritmiFirst form = new AlgoritmiFirst();
            form.Show();
            Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AlgoritmiFirst form = new AlgoritmiFirst();
            form.Show();
            Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AlgoritmiFirst form = new AlgoritmiFirst();
            form.Show();
            Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AlgoritmiFirst form = new AlgoritmiFirst();
            form.Show();
            Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AlgoritmiFirst form = new AlgoritmiFirst();
            form.Show();
            Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AlgoritmiFirst form = new AlgoritmiFirst();
            form.Show();
            Visible = false;
        }

       
        

       
    }
}
