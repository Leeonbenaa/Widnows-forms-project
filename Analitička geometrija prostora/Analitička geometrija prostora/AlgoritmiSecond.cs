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
    public partial class AlgoritmiUdaljenost : Form
    {
        public AlgoritmiUdaljenost()
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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonTeorija_Click(object sender, EventArgs e)
        {

            double x;
            double y;
            double z;

            double A;
            double B;
            double C;
            double D;

            if (!double.TryParse(xCordinateDistance.Text, out x) || !double.TryParse(yCordinateDistance.Text, out y) || !double.TryParse(zCordinateDistance.Text, out z) || !double.TryParse(aCordinatePlane.Text, out A) || !double.TryParse(bCordinatePlane.Text, out B) || !double.TryParse(cCordinatePlane.Text, out C) || !double.TryParse(dCordinatePlane.Text, out D))
            {
                MessageBox.Show("Unos mora biti broj i ne smije biti prazan", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            double distance =Math.Abs(A*x+B*y+C*z+D)/(Math.Sqrt(Math.Pow(A,2)+Math.Pow(B,2)+Math.Pow(C,2)));
            distance = Math.Round(distance, 2);

            distancePointPlane.Text=distance.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            float A1;
            float B1;
            float C1;
            float D1;
            float A2;
            float B2;
            float C2;
            float D2;


            if ( !float.TryParse(aCordinatePlane1.Text,out A1) || !float.TryParse(bCordinatePlane2.Text, out B1) || !float.TryParse(cCordinatePlane1.Text, out C1) || !float.TryParse(dCordinatePlane1.Text, out D1) || !float.TryParse(aCordinatePlane2.Text, out A2) || !float.TryParse(bCordinatePlane2.Text, out B2) || !float.TryParse(cCordinatePlane2.Text, out C2) || !float.TryParse(dCordinatePlane2.Text, out D2))
            {
                MessageBox.Show("Unos mora biti broj i ne smije biti prazan","Upozorenje!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            
           
            
           
           
            bool paralel1, paralel2, paralel3;
           

             if (A1==0 && A2==0)
            {
                paralel1 = true;
                
            }else if (  A1 / A2 == 1)
            {
                paralel1 = true;
                
            }else
            {
                paralel1= false;
               
            }

            if (B1 == 0 && B2 == 0)
            {
                paralel2 = true;
              
            }
            else if (B1 / B2 == 1)
            {
                paralel2 = true;
                
            }else
            {
                paralel2 = false;
                
            }

            if (C1 == 0 && C2 == 0)
            {
                paralel3 = true;
               
            }
            else if (C1 / C2 == 1)
            {
                paralel3 = true;
                
            }
            else
            {
                paralel3 = false;
                
            }
            

            if (paralel1 && paralel2 && paralel3)
            { 
                double distanceOfPlanes = Math.Abs(D1 - D2) / (Math.Sqrt(Math.Pow(A1, 2) + Math.Pow(B1, 2) + Math.Pow(C1, 2)));
                distanceOfPlanes = Math.Round(distanceOfPlanes, 2);
                distancePlanes.Text = distanceOfPlanes.ToString(); }
            else
            {
                distancePlanes.Text = "0";
            }
            
            

    }
            

            
        

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x1;
            double y1;
            double z1;

            double x2;
            double y2;
            double z2;
            if (!double.TryParse(xT1.Text, out x1) || !double.TryParse(yT1.Text, out y1) || !double.TryParse(zT1.Text, out z1) || !double.TryParse(xT2.Text, out x2) || !double.TryParse(yT2.Text, out y2) || !double.TryParse(zT2.Text, out z2))
            {
                MessageBox.Show("Unos mora biti broj i ne smije biti prazan", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double distanceOfPoints =Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
            distanceOfPoints = Math.Round(distanceOfPoints, 2);
            distancePoints.Text = distanceOfPoints.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float tx1;
            float ty1;
            float tz1;
            float tx2;
            float ty2;
            float tz2;

            float tx3;
            float ty3;
            float tz3;


            if (!float.TryParse(t1X.Text, out tx1) || !float.TryParse(t1Y.Text, out ty1) || !float.TryParse(t1Z.Text, out tz1) || !float.TryParse(t2Y.Text, out ty2) || !float.TryParse(t2Z.Text, out tz2) || !float.TryParse(t2X.Text, out tx2) || !float.TryParse(t3X.Text, out tx3) || !float.TryParse(t3Y.Text, out ty3) || !float.TryParse(t3Z.Text, out tz3))
            {
                MessageBox.Show("Unos mora biti broj i ne smije biti prazan", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            float v1X = tx2 - tx1;
            float v1Y = ty2 - ty1;
            float v1Z = tz2 - tz1;

            float v2X = tx3 - tx1;
            float v2Y = ty3 - ty1;
            float v2Z = tz3 - tz1;
            //Vektor normale dobiven vektorskim produktom
            float i = v1Y * v2Z - v2Y * v1Z;
            float j = (v1X * v2Z - v2X * v1Z) * -1;
            float k = v1X * v2Y - v2X * v1Y;
            //D varijabla ravnine
            float d = (i * tx1 + j * ty1 + k * tz1) * -1;

            if (i == 0)
            {
                A.Text = "";
            }
            else
            {
                A.Text = i.ToString() + "x";
            }
            if (j > 0)
            {
                B.Text = "+" + j.ToString() + "y";
            } else if (j == 0)
            {
                B.Text = "";
            }else{
             B.Text = j.ToString() + "y";}

            if (k > 0)
            {
                C.Text = "+" + k.ToString() + "z";
            } else if (k == 0)
            {
                C.Text = "";
            }
            else
            {
                C.Text = k.ToString() + "z";
            }

            if (d > 0)
            {
                D.Text = "+" + d.ToString();
            }else if (d == 0)
            {
                D.Text = "";
            }
            else
            {
                D.Text = d.ToString();
            }


           
           

        }

        private void t1X1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }
    }
}
