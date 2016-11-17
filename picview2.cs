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
    public partial class picview2 : DockContent
    {
        public picview2()
        {
            InitializeComponent();
       _imgs2 = this;
        }
        public static picview2 _imgs2;
    }
}
