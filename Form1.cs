using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1KG
{
    struct RGB
    {
        public int R;
        public int G;
        public int B;
    }
    struct LAB
    {
        public double L;
        public double A;
        public double B;
    }
    struct XYZ
    {
        public double X;
        public double Y;
        public double Z;
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void rgbButton_Click(object sender, EventArgs e)
        {
            RGB n;
            n.R = Convert.ToInt32(rField.Text);
            n.G = Convert.ToInt32(gField.Text);
            n.B = Convert.ToInt32(b_Field.Text);
            showColorsRGB(n);
        }

        double f1(double x)
        {
            if ( x >= 0.04045)
            {
                return Math.Pow((x + 0.055) / 1.055, 2.40);
            }
            else
            {
                return x / 12.92;
            }
        }

        private XYZ toXYZ(RGB l)
        {
            int R = l.R;
            int G = l.G;
            int B = l.B;

            double Rn = f1(R / 255.0) * 100;
            double Gn = f1(G / 255.0) * 100;
            double Bn = f1(B / 255.0) * 100;

            XYZ p;
            p.X = 0.412453 * Rn + 0.357580 * Gn + 0.180423 * Bn;
            p.Y = 0.212671 * Rn + 0.715160 * Gn + 0.072169 * Bn;
            p.Z = 0.019334 * Rn + 0.119193 * Gn + 0.950227 * Bn;

            return p;
        }

        double f2(double x)
        {
            if (x >= 0.0031308)
            {
                return 1.055 * Math.Pow(x, 1 / 2.4) - 0.055;
            }
            else
            {
                return 12.92 * x;
            }
        }
        private RGB fromXYZ(XYZ l)
        {
            double Rn = 3.2406 * l.X / 100.0 - 1.5372 * l.Y / 100.0 - 0.4986 * l.Z / 100.0;
            double Gn = -0.9689 * l.X / 100.0 + 1.8758 * l.Y / 100.0 + 0.0415 * l.Z / 100.0;
            double Bn = 0.0557 * l.X / 100.0 - 0.2040 * l.Y / 100.0 + 1.0570 * l.Z / 100.0;

            RGB r;
            r.R = (int)(Math.Abs((f2(Rn) * 255)));
            if (r.R > 255)
            {
                r.R = 0;
            }

            r.G = (int)(Math.Abs((f2(Gn) * 255)))%255;
            r.B = (int)(Math.Abs((f2(Bn) * 255)))%255;

            return r;
        }

        private void showColorsRGB(RGB r)
        {
            rgbPicture.BackColor = Color.FromArgb(r.R, r.G, r.B);
            rgbPicture.ForeColor = Color.FromArgb(r.R, r.G, r.B);

            label1.Text = "RGB: " + r.R + " " + r.G + " " + r.B;

            XYZ x = toXYZ(r);
            xFieldXYZ.Text = x.X.ToString();
            yFieldXYZ.Text = x.Y.ToString();
            zFieldXYZ.Text = x.Z.ToString();

            LAB lab = toLab(x);
            lField.Text = lab.L.ToString();
            aField.Text = lab.A.ToString();
            bField.Text = lab.B.ToString();

        }
        private void showColorsXYZ(RGB r)
        {
            xyzPicture.BackColor = Color.FromArgb(r.R, r.G, r.B);
            xyzPicture.ForeColor = Color.FromArgb(r.R, r.G, r.B);

            label2.Text = "XYZ: " + r.R + " " + r.G + " " + r.B;

            rField.Text = r.R.ToString();
            gField.Text = r.G.ToString();
            b_Field.Text = r.B.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XYZ p;
            p.X = Convert.ToDouble(xFieldXYZ.Text);
            p.Y = Convert.ToDouble(yFieldXYZ.Text);
            p.Z = Convert.ToDouble(zFieldXYZ.Text);

            RGB rgb = fromXYZ(p);

            showColorsXYZ(rgb);

            LAB l = toLab(p);
            lField.Text = l.L.ToString();
            aField.Text = l.A.ToString();
            bField.Text = l.B.ToString();

        }

        // Lab
        private double f3(double x)
        {
            if (x >= 0.008856)
            {
                return Math.Pow(x, 1.0 / 3);
            }
            else
            {
                return 7.787 * x + 16 / 116.0;
            }
        }

        private LAB toLab(XYZ p)
        {
            LAB l;
            l.L = 116.0 * f3(p.Y / 100.0) - 16;
            l.A = 500 * (f3(p.X / 95.047) - f3(p.Y / 100.0));
            l.B = 200 * (f3(p.Y / 100.0) - f3(p.Z / 108.883));

            return l;
        }

        private double f4(double x)
        {
            if (x * x * x >= 0.008856)
            {
                return x * x * x * 1.0;
            }
            else
            {
                return (x - (16.0 / 166.0)) / 7.787 * 1.0;
            }
        }

        private XYZ fromLab(LAB l)
        {
            XYZ x;
            x.Y = f4((l.L + 16.0) / 116.0) * 95.047;
            x.X = f4(l.A / 500.0 + (l.L + 16.0) / 116.0) * 100;
            x.Z = f4((l.L + 16.0) / 116.0 - l.B / 200.0) * 108.883;
            return x;
        }

        private void ShowLAB_Click(object sender, EventArgs e)
        {
            LAB l;
            l.L = Convert.ToDouble(lField.Text);
            l.A = Convert.ToDouble(aField.Text);
            l.B = Convert.ToDouble(bField.Text);

            XYZ x = fromLab(l);
            xFieldXYZ.Text = x.X.ToString();
            yFieldXYZ.Text = x.Y.ToString();
            zFieldXYZ.Text = x.Z.ToString();

            RGB r = fromXYZ(x);

            label3.Text = "LAB: " + r.R + " " + r.G + " " + r.B;
            labPicture.BackColor = Color.FromArgb(r.R, r.G, r.B);
            labPicture.ForeColor = Color.FromArgb(r.R, r.G, r.B);

            rField.Text = r.R.ToString();
            gField.Text = r.G.ToString();
            b_Field.Text = r.B.ToString();
        }
    }
}
