using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analitička_geometrija_prostora
{
    public partial class AlgoritmiFirst : Form
    {
        public AlgoritmiFirst()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OsnovneOperacije form = new OsnovneOperacije();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            double n1i;
            double n1j;
            double n1k;


            double n2i;
            double n2j;
            double n2k;

            if (!double.TryParse(aCordinatePlane1.Text, out n1i) || !double.TryParse(bCordinatePlane1.Text, out n1j) || !double.TryParse(cCordinatePlane1.Text, out n1k)  || !double.TryParse(aCordinatePlane2.Text, out n2i) || !double.TryParse(bCordinatePlane2.Text, out n2j) || !double.TryParse(cCordinatePlane2.Text, out n2k))
            {
                MessageBox.Show("Unos mora biti broj i ne smije biti prazan", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //formula za kut 
            double cosine = ((n1i * n2i)+ (n1j * n2j) + (n1k * n2k)) /( Math.Sqrt(Math.Pow(n1i, 2) + Math.Pow(n1j, 2) + Math.Pow(n1k, 2)) * Math.Sqrt(Math.Pow(n2i, 2) + Math.Pow(n2j, 2) + Math.Pow(n2k, 2)));
            cosine= Math.Acos(cosine);
            //pretvorba u stupnjeve
            cosine = cosine * 180 / Math.PI;
            cosine = Math.Round(cosine, 4);
            cosineValue.Text=cosine.ToString()+ "°";



        }

        private void button2_Click(object sender, EventArgs e)
        {
            double A;
            double B;
            double C;
            double D;


            double x;
            double y;
            double z;


            if (!double.TryParse(planeA.Text, out A) || !double.TryParse(planeB.Text, out B) || !double.TryParse(planeC.Text, out C) || !double.TryParse(planeD.Text, out D) || !double.TryParse(lineX.Text, out x) || !double.TryParse(lineY.Text, out y) || !double.TryParse(lineZ.Text, out z))
            {
                MessageBox.Show("Unos mora biti broj i ne smije biti prazan", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //formula za kut 

            double cosine = ((A * x) + (B * y) + (C * z)) / (Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2) + Math.Pow(C, 2)) * Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2)));
            cosine = Math.Acos(cosine);
            //pretvorba u stupnjeve

            cosine = cosine * 180 / Math.PI;
            //kut između pravca i ravnine je 90-kut između normale i pravca smjera

            cosine = Math.Abs(90 - cosine);
            cosine = Math.Round(cosine, 4);
            cosineValue2.Text = cosine.ToString() + "°";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double A;
            double B;
            double C;
            double D;


            double x;
            double y;
            double z;


            if (!double.TryParse(planeValueA.Text, out A) || !double.TryParse(planeValueB.Text, out B) || !double.TryParse(planeValueC.Text, out C) || !double.TryParse(planeValueD.Text, out D) || !double.TryParse(pointX.Text, out x) || !double.TryParse(pointY.Text, out y) || !double.TryParse(pointZ.Text, out z))
            {
                MessageBox.Show("Unos mora biti broj i ne smije biti prazan", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double sum = A * x + B * y + C * z + D;

            if(sum == 0)

            {
                valuePripada.Text = "Točka pripada danoj ravnini";
            }
            else
            {
                valuePripada.Text = "Točka ne pripada danoj ravnini";
            }

            

            if (D == 0)
            {
                valueKoordinatneOsi.Text = "Ravnina prolazi kroz ishodište";
            }
            else
            {
                valueKoordinatneOsi.Text = "Ravnina ne prolazi kroz ishodište";
            }
            
        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            double x1;
            double y1;
            double z1;

            double x2;
            double y2;
            double z2;

            if (!double.TryParse(point1x.Text, out x1) || !double.TryParse(point1y.Text, out y1) || !double.TryParse(point1z.Text, out z1) || !double.TryParse(point2x.Text, out x2) || !double.TryParse(point2y.Text, out y2) || !double.TryParse(point2z.Text, out z2))
            {
                MessageBox.Show("Unos mora biti broj i ne smije biti prazan", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            double x12 = x2 - x1;
            double y12 = y2 - y1;
            double z12 = z2 - z1;
           
            double s1 = x12;
            double s2 = y12;
            double s3 = z12;
            string s1text;
            string s2text;
            string s3text;
            
           
            
            if (s1 > 0)
            {
                 s1text = "+" + s1.ToString()+"t";
            }
            else if(s1==0)
            {
                s1text = "";
            }else
            {
                s1text =s1.ToString() + "t";
            }

            if (s2 > 0)
            {
                s2text = "+" + s2.ToString() + "t";
            }
            else if (s2 == 0)
            {
                s2text = "";
            }else
            {
                s2text = s2.ToString() + "t";
            }
            if (s3 > 0)
            {
                s3text = "+" + s3.ToString() + "t";
            }
            else if (s3 == 0)
            {
                s3text = "";
            }else
            {
                s3text = s3.ToString() + "t";
            }
            string x,y,z;
            
            if (x1 == 0)
            {
                x = "";
            }else
            {
                x= x1.ToString();
            }
            if (y1 == 0)
            {
                y = "";
            }else
            {
                y = y1.ToString();
            }



            if (z1 == 0)
            {
                z = "";
            }else
            {
                z = z1.ToString();
            }
            xvalue.Text = "x=" + x + s1text;
            yvalue.Text = "y=" + y + s2text;
            zvalue.Text = "z=" + z + s3text;

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void aCordinatePlane1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
