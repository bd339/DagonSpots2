namespace DagonSpots2
{
    partial class Picview1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.colbtn = new System.Windows.Forms.Button();
            this.Zoombtn = new System.Windows.Forms.Button();
            this.drawpoly = new System.Windows.Forms.Button();
            this.DomainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer2.Panel1.Controls.Add(this.PictureBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer2.Panel2MinSize = 70;
            this.splitContainer2.Size = new System.Drawing.Size(875, 404);
            this.splitContainer2.SplitterDistance = 300;
            this.splitContainer2.TabIndex = 8;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(3, 3);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(158, 116);
            this.PictureBox1.TabIndex = 8;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseClick);
            this.PictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.PictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.PictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.colbtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Zoombtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.drawpoly, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DomainUpDown1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button7, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(875, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // colbtn
            // 
            this.colbtn.Location = new System.Drawing.Point(153, 29);
            this.colbtn.Name = "colbtn";
            this.colbtn.Size = new System.Drawing.Size(69, 20);
            this.colbtn.TabIndex = 241;
            this.colbtn.Text = "colour";
            this.colbtn.UseVisualStyleBackColor = true;
            // 
            // Zoombtn
            // 
            this.Zoombtn.Location = new System.Drawing.Point(3, 3);
            this.Zoombtn.Name = "Zoombtn";
            this.Zoombtn.Size = new System.Drawing.Size(69, 20);
            this.Zoombtn.TabIndex = 240;
            this.Zoombtn.Text = "Zoom";
            this.Zoombtn.UseVisualStyleBackColor = true;
            this.Zoombtn.Click += new System.EventHandler(this.Zoombtn_Click);
            // 
            // drawpoly
            // 
            this.drawpoly.Location = new System.Drawing.Point(3, 29);
            this.drawpoly.Name = "drawpoly";
            this.drawpoly.Size = new System.Drawing.Size(69, 20);
            this.drawpoly.TabIndex = 238;
            this.drawpoly.Text = "draw poly";
            this.drawpoly.UseVisualStyleBackColor = true;
            this.drawpoly.Click += new System.EventHandler(this.drawpoly_Click);
            // 
            // DomainUpDown1
            // 
            this.DomainUpDown1.Location = new System.Drawing.Point(78, 3);
            this.DomainUpDown1.Name = "DomainUpDown1";
            this.DomainUpDown1.Size = new System.Drawing.Size(69, 20);
            this.DomainUpDown1.TabIndex = 235;
            this.DomainUpDown1.SelectedItemChanged += new System.EventHandler(this.DomainUpDown1_SelectedItemChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(78, 29);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(69, 20);
            this.button7.TabIndex = 236;
            this.button7.Text = "Clear Poly";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Picview1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 404);
            this.Controls.Add(this.splitContainer2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Picview1";
            this.Text = "Spot Draw";
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button colbtn;
        private System.Windows.Forms.Button Zoombtn;
        internal System.Windows.Forms.Button drawpoly;
        internal System.Windows.Forms.DomainUpDown DomainUpDown1;
        private System.Windows.Forms.Button button7;
    }
}