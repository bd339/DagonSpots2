﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;//dock panel
namespace DagonSpots2
{
    public partial class Form1 : Form
    {
        // add class links e
       private NodeProperties m_roomsettings = new NodeProperties();
       private Picview1 m_picview = new Picview1();
       private picview2 m_picview2 = new picview2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dock panels
            m_picview.Show(dockPanel, DockState.Document);
            m_picview2.Show(dockPanel, DockState.Document);
            m_roomsettings.Show(dockPanel, DockState.DockLeft);
            
        }
    }
}
