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
    public partial class NodeProperties : DockContent
    {
        public NodeProperties()
        {
            InitializeComponent();
            _nodes = this;
        }
        public static NodeProperties _nodes;
        public Image Img;
        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        string extension;
        private void loadBtn_Click(object sender, EventArgs e)
        {
            Spotlist.Items.Clear();
            OpenFileDialog Dlg = new OpenFileDialog();
            Dlg.Filter = "";
            Dlg.Title = "Select image";
            if (Dlg.ShowDialog(this) == DialogResult.OK)
            {
                extension = Path.GetExtension(Dlg.FileName);
                String pathfolder = Path.GetDirectoryName(Dlg.FileName);
                dagonpath.Text = pathfolder;
                if (extension == ".tga")
                {
                    Img = Paloma.TargaImage.LoadTargaImage(Dlg.FileName);
                }
                else
                {
                    Img = Image.FromFile(Dlg.FileName);
                    //Image.FromFile(String) method creates an image from the specifed file, here dlg.Filename contains the name of the file from which to create the image
                   Picview1._imgs.LoadImage();
                    pictureBox2.Image = Img;

                    {
                        DirectoryInfo dinfo3 = new DirectoryInfo(dagonpath.Text);
                        FileInfo[] Files3 = dinfo3.GetFiles("*00*" + extension);
                        foreach (FileInfo file in Files3)
                        {
                            object resultx = Path.GetFileNameWithoutExtension(file.Name);
                            Spotlist.Items.Add(resultx);

                        }
                    }
                }
            }
        }

        private void Spotlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            Img = Image.FromFile(dagonpath.Text + "\\" + Spotlist.Text + extension);
            //Image.FromFile(String) method creates an image from the specifed file, here dlg.Filename contains the name of the file from which to create the image
            Picview1._imgs.LoadImage();
            //Zoombtna();
            pictureBox2.Image = Img;

            nodeface.Text = Spotlist.Text;

            string s1 = "001";
            string s2 = "002";
            string s3 = "003";
            string s4 = "004";
            string s5 = "005";
            string s6 = "006";
            string s = null;

            string s1a = "0001";
            string s2a = "0002";
            string s3a = "0003";
            string s4a = "0004";
            string s5a = "0005";
            string s6a = "0006";
            s = Spotlist.Text;

            //TextBox4.Text = work
            if (nodeface.Text.Contains(s1))
            {
                spotdirection.Text = "NORTH";
                nodespotetxt.Text = (s.Substring(0, s.Length - 3));

            }
            if (nodeface.Text.Contains(s2))
            {
                spotdirection.Text = "EAST";
                nodespotetxt.Text = (s.Substring(0, s.Length - 3));
            }

            if (nodeface.Text.Contains(s3))
            {
                spotdirection.Text = "SOUTH";
                nodespotetxt.Text = (s.Substring(0, s.Length - 3));

            }
            if (nodeface.Text.Contains(s4))
            {
                spotdirection.Text = "WEST";
                nodespotetxt.Text = (s.Substring(0, s.Length - 3));

            }
            if (nodeface.Text.Contains(s5))
            {
                spotdirection.Text = "UP";
                nodespotetxt.Text = (s.Substring(0, s.Length - 3));
            }

            if (nodeface.Text.Contains(s6))
            {
                spotdirection.Text = "DOWN";
                nodespotetxt.Text = (s.Substring(0, s.Length - 3));

            }

            if (nodeface.Text.Contains(s1a))
            {
                spotdirection.Text = "NORTH";
                nodespotetxt.Text = (s.Substring(0, s.Length - 4));
            }
            if (nodeface.Text.Contains(s2a))
            {
                spotdirection.Text = "EAST";
                nodespotetxt.Text = (s.Substring(0, s.Length - 4));
            }
            if (nodeface.Text.Contains(s3a))
            {
                spotdirection.Text = "SOUTH";
                nodespotetxt.Text = (s.Substring(0, s.Length - 4));
            }
            if (nodeface.Text.Contains(s4a))
            {
                spotdirection.Text = "WEST";
                nodespotetxt.Text = (s.Substring(0, s.Length - 4));
            }
            if (nodeface.Text.Contains(s5a))
            {
                spotdirection.Text = "UP";
                nodespotetxt.Text = (s.Substring(0, s.Length - 4));
            }
            if (nodeface.Text.Contains(s6a))
            {
                spotdirection.Text = "DOWN";
                nodespotetxt.Text = (s.Substring(0, s.Length - 4));
            }
               
        }
    }
}
