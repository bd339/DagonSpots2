using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Collections;
using System.Xml;
using WeifenLuo.WinFormsUI.Docking;
namespace DagonSpots2
{
    public partial class Picview1 :DockContent
    {
        public Picview1()
        {
            InitializeComponent();
            BindDomainIUpDown();
            _imgs = this;
        }
        public static Picview1 _imgs;
        System.Drawing.Graphics g;
        System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.Blue, 2);
        Pen blackPen = new Pen(Color.Blue, 3);
        int miCounter = 0;
        bool polydrawnumber = false;
        private List<Point> points = new List<Point>();
        private Image Img;
        private Size OriginalImageSize;
        private Size ModifiedImageSize;
        System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(Color.Black);
        int xone;
        int yone;
        int xtwo;
        int ytwo;
        int xthree;
        int ythree;
        int xfour;
        int yfour;
        int xfive;
        int yfive;
        int xsix;
        int ysix;
        int xseven;
        int yseven;
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        #region picture control

        private void loadimgbtn_Click(object sender, EventArgs e)
        {

        }
        public void LoadImage()
        {
            //we set the picturebox size according to image, we can get image width and height with the help of Image.Width and Image.height properties.
            int imgWidth = NodeProperties._nodes.Img.Width;
            int imghieght = NodeProperties._nodes.Img.Height;
            PictureBox1.Width = imgWidth;
            PictureBox1.Height = imghieght;
            PictureBox1.Image = NodeProperties._nodes.Img;
            PictureBoxLocation();
            OriginalImageSize = new Size(imgWidth, imghieght);

            SetResizeInfo();
        }

        private void PictureBoxLocation()
        {
            int _x = 0;
            int _y = 0;
            if (splitContainer2.Panel1.Width > PictureBox1.Width)
            {
                _x = (splitContainer2.Panel1.Width - PictureBox1.Width) / 2;
            }
            if (splitContainer2.Panel1.Height > PictureBox1.Height)
            {
                _y = (splitContainer2.Panel1.Height - PictureBox1.Height) / 2;
            }
            PictureBox1.Location = new Point(_x, _y);
        }

        private void BindDomainIUpDown()
        {
            for (int i = 1; i <= 999; i++)
            {
                DomainUpDown1.Items.Add(i);
            }
            DomainUpDown1.Text = "100";
        }



        private void SetResizeInfo()
        {

           NodeProperties._nodes.lbloriginalSize.Text = OriginalImageSize.ToString();
           NodeProperties._nodes.lblModifiedSize.Text = ModifiedImageSize.ToString();

        }

        private void DomainUpDown1_SelectedItemChanged(System.Object sender, System.EventArgs e)
        {
            int percentage = 0;
            try
            {
                percentage = Convert.ToInt32(DomainUpDown1.Text);
                ModifiedImageSize = new Size((OriginalImageSize.Width * percentage) / 100, (OriginalImageSize.Height * percentage) / 100);
                SetResizeInfo();


            }
            catch
            {
                MessageBox.Show("Invalid Percentage");
                return;
            }


        }


        int cropX;
        int cropY;
        int cropWidth;

        int cropHeight;
        // int oCropX;
        //int oCropY;
        public Pen cropPen;

        public System.Drawing.Drawing2D.DashStyle cropDashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
        bool Makeselection = false;

        private void PictureBox1_MouseDown(System.Object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (MouseButtons == MouseButtons.Right)
            {
                polydraw();


            }
            if (Makeselection)
            {

                try
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        Cursor = Cursors.Cross;
                        cropX = e.X;
                        cropY = e.Y;

                        cropPen = new Pen(Color.Green, 5);
                        cropPen.DashStyle = DashStyle.DashDotDot;


                    }
                    PictureBox1.Refresh();

                }
                catch
                {

                    Console.WriteLine("{0} Exception caught.", e);


                }
            }
        }

        private void polydraw()
        {

            if (polydrawnumber == false)
            {
                return;
            }


            // Create pen.



            if (miCounter == 1)
            {
                Point point1 = new Point(xone, yone);
                Point[] curvePoints =
                    {
                        point1,
                    };
                MessageBox.Show("Nothing to draw!");
            }
            if (miCounter == 2)
            {

                Point point1 = new Point(xone, yone);
                Point point2 = new Point(xtwo, ytwo);

                Point[] curvePoints =
             {
                 point1,
                 point2,
             };

                g = PictureBox1.CreateGraphics();
                g.DrawPolygon(blackPen, curvePoints);
                miCounter = 0;
                drawpoly.Enabled = true;

                polydrawnumber = false;

            }
            if (miCounter == 3)
            {

                Point point1 = new Point(xone, yone);
                Point point2 = new Point(xtwo, ytwo);
                Point point3 = new Point(xthree, ythree);
                Point[] curvePoints =
             {
                 point1,
                 point2,
                 point3,
             };
                g = PictureBox1.CreateGraphics();
                g.DrawPolygon(blackPen, curvePoints);
                miCounter = 0;
                drawpoly.Enabled = true;

                polydrawnumber = false;

            }
            if (miCounter == 4)
            {

                Point point1 = new Point(xone, yone);
                Point point2 = new Point(xtwo, ytwo);
                Point point3 = new Point(xthree, ythree);
                Point point4 = new Point(xfour, yfour);
                Point[] curvePoints =
             {
                 point1,
                 point2,
                 point3,
                 point4,
 };

                // Draw polygon to screen.
                g = PictureBox1.CreateGraphics();
                g.DrawPolygon(blackPen, curvePoints);
                miCounter = 0;
                drawpoly.Enabled = true;

                polydrawnumber = false;

            }

            if (miCounter == 5)
            {

                Point point1 = new Point(xone, yone);
                Point point2 = new Point(xtwo, ytwo);
                Point point3 = new Point(xthree, ythree);
                Point point4 = new Point(xfour, yfour);
                Point point5 = new Point(xfive, yfive);
                Point[] curvePoints =
             {
                 point1,
                 point2,
                 point3,
                 point4,
                 point5,
             };
                // Draw polygon to screen.
                g = PictureBox1.CreateGraphics();
                g.DrawPolygon(blackPen, curvePoints);
                FillMode newFillMode = FillMode.Winding;

                // Fill polygon to screen.
                g.FillPolygon(myBrush, curvePoints, newFillMode);


                miCounter = 0;
                drawpoly.Enabled = true;

                polydrawnumber = false;

            }
            if (miCounter == 6)
            {

                Point point1 = new Point(xone, yone);
                Point point2 = new Point(xtwo, ytwo);
                Point point3 = new Point(xthree, ythree);
                Point point4 = new Point(xfour, yfour);
                Point point5 = new Point(xfive, yfive);
                Point point6 = new Point(xsix, ysix);

                Point[] curvePoints =
             {
                 point1,
                 point2,
                 point3,
                 point4,
                 point5,
              point6,

             };
                g = PictureBox1.CreateGraphics();
                g.DrawPolygon(blackPen, curvePoints);
                miCounter = 0;
                drawpoly.Enabled = true;

                polydrawnumber = false;

            }
            if (miCounter == 7)
            {

                Point point1 = new Point(xone, yone);
                Point point2 = new Point(xtwo, ytwo);
                Point point3 = new Point(xthree, ythree);
                Point point4 = new Point(xfour, yfour);
                Point point5 = new Point(xfive, yfive);
                Point point6 = new Point(xsix, ysix);
                Point point7 = new Point(xseven, yseven);
                Point[] curvePoints =
             {
                 point1,
                 point2,
                 point3,
                 point4,
                 point5,
              point6,
               point7,
             };

                // Draw polygon to screen.
                g = PictureBox1.CreateGraphics();
                g.DrawPolygon(blackPen, curvePoints);
                polydrawnumber = false;
                drawpoly.Enabled = true;
                if (miCounter >= 7)
                {
                    polydrawnumber = false;
                    drawpoly.Enabled = true;





                    // polydraw = False
                    // butPoly.Enabled = False
                    // g = PictureBox1.CreateGraphics
                    //'  g.DrawPolygon(pen1, p)

                }

            }
        }

        private void PictureBox1_MouseUp(System.Object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (Makeselection)
            {
                Cursor = Cursors.Default;
            }

        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Makeselection)
            {

                try
                {
                    if (PictureBox1.Image == null)
                        return;


                    if (e.Button == MouseButtons.Left)
                    {
                        PictureBox1.Refresh();
                        cropWidth = e.X - cropX;
                        cropHeight = e.Y - cropY;
                        Graphics g = PictureBox1.CreateGraphics();

                        g.DrawRectangle(cropPen, cropX, cropY, cropWidth, cropHeight);
                    }



                }
                catch
                {

                    return;
                }
            }
        }






        private void Regionbtn_Click(object sender, EventArgs e)
        {
            Makeselection = true;

        }



        private void Zoombtn_Click(object sender, EventArgs e)
        {
            Zoombtna();
        }
        private void Zoombtna()
        {
            if (DomainUpDown1.Text == "100")
            {
                return;
            }
            Bitmap bm_source = new Bitmap(PictureBox1.Image);
            // Make a bitmap for the result.
            Bitmap bm_dest = new Bitmap((int)ModifiedImageSize.Width, (int)ModifiedImageSize.Height);
            // Make a Graphics object for the result Bitmap.
            Graphics gr_dest = Graphics.FromImage(bm_dest);
            // Copy the source image into the destination bitmap.
            gr_dest.DrawImage(bm_source, 0, 0, bm_dest.Width + 1, bm_dest.Height + 1);
            // Display the result.
            PictureBox1.Image = bm_dest;
            PictureBox1.Width = bm_dest.Width;
            PictureBox1.Height = bm_dest.Height;
            PictureBoxLocation();
        }

        private void drawpoly_Click(object sender, EventArgs e)
        {

            polydrawnumber = true;
            drawpoly.Enabled = false;
            NodeProperties._nodes.CRPwidth.Text = "";
            miCounter = 0;
        }


        private void PictureBox1_MouseClick(System.Object sender, System.Windows.Forms.MouseEventArgs e)
        {

            //Dim p(5) As System.Drawing.Point
            // Dim miCounter As Integer = 0
            int percentage = 0;
            if (e.Button == MouseButtons.Left)
            {
                NodeProperties._nodes.Label25.Text = "X." + e.X + "\r\n" + "Y." + e.Y;
                Graphics g = PictureBox1.CreateGraphics();
                g.DrawEllipse(new Pen(Color.Blue, 5), e.X, e.Y, 2, 2);
                percentage = System.Convert.ToInt32(Convert.ToInt32(DomainUpDown1.Text));
                miCounter += 1;
                NodeProperties._nodes.Label26.Text = miCounter.ToString();
            }
            if (polydrawnumber == false)
            {
                return;
            }
            if (miCounter == 1)
            {
                xone = e.X;
                yone = e.Y;
                NodeProperties._nodes.x1.Text = xone.ToString();
                NodeProperties._nodes.y1.Text = yone.ToString();
                NodeProperties._nodes.CRPwidth.AppendText(100 / percentage * xone + ", " + 100 / percentage * yone);


            }
            if (miCounter == 2)
            {
                xtwo = e.X;
                ytwo = e.Y;
                NodeProperties._nodes.x2.Text = e.Y.ToString();
                NodeProperties._nodes.y2.Text = e.X.ToString();


                NodeProperties._nodes.CRPwidth.AppendText(", " + 100 / percentage * xtwo + ", " + 100 / percentage * ytwo);
            }
            if (miCounter == 3)
            {
                xthree = e.X;
                ythree = e.Y;
                NodeProperties._nodes.x3.Text = e.Y.ToString();
                NodeProperties._nodes.y3.Text = e.X.ToString();


                NodeProperties._nodes.CRPwidth.AppendText(", " + 100 / percentage * xthree + ", " + 100 / percentage * ythree);
            }
            if (miCounter == 4)
            {
                xfour = e.X;
                yfour = e.Y;
                NodeProperties._nodes.x4.Text = e.Y.ToString();
                NodeProperties._nodes.y4.Text = e.X.ToString();

                NodeProperties._nodes.CRPwidth.AppendText(", " + 100 / percentage * xfour + ", " + 100 / percentage * yfour);
            }
            if (miCounter == 5)
            {
                xfive = e.X;
                yfive = e.Y;
                NodeProperties._nodes.x5.Text = e.Y.ToString();
                NodeProperties._nodes.y5.Text = e.X.ToString();

                NodeProperties._nodes.CRPwidth.AppendText(", " + 100 / percentage * xfive + ", " + 100 / percentage * yfive);
            }
            if (miCounter == 6)
            {
                xsix = e.X;
                ysix = e.Y;
                NodeProperties._nodes.x6.Text = e.Y.ToString();
                NodeProperties._nodes.y6.Text = e.X.ToString();

                NodeProperties._nodes.CRPwidth.AppendText(", " + 100 / percentage * xsix + ", " + 100 / percentage * ysix);
            }
            if (miCounter == 7)
            {
                xseven = e.X;
                yseven = e.Y;
                NodeProperties._nodes.x7.Text = e.Y.ToString();
                NodeProperties._nodes.y7.Text = e.X.ToString();

                NodeProperties._nodes.CRPwidth.AppendText(", " + 100 / percentage * xseven + ", " + 100 / percentage * yseven);
            }


        }




        #endregion
     
    }
}
