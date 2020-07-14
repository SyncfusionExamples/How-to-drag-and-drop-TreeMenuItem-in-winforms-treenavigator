using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace TreeNavigatorSample
{
    public partial class Form1 : MetroForm
    {
        #region Variables

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr WindowFromPoint(Point pnt);

        private TreeMenuItemAdv treeMenuItem1;
        private TreeMenuItemAdv treeMenuItem2;
        private TreeMenuItemAdv treeMenuItem3;
        private TreeMenuItemAdv treeMenuItem4;
        private TreeMenuItemAdv treeMenuItem5;
        private TreeMenuItemAdv treeMenuItem6;
        private TreeMenuItemAdv treeMenuItem7;
        private TreeMenuItemAdv treeMenuItem8;
        private TreeMenuItemAdv treeMenuItem9;
        private TreeMenuItemAdv treeMenuItem10;

        #endregion

        #region Constructor

        public Form1()
        {
            InitializeComponent();
            PopulateTree1();
            PopulateTree2();
            this.CenterToScreen();
            this.Text = "TreeNavigator";
            this.SourceTreeNavigator.ParentPanel.AllowDrop = true;
            this.DestinationTreeNavigator.ParentPanel.AllowDrop = true;
        }

        #endregion

        #region Functions

        /// <summary>
        /// To populate source TreeNavigator 1
        /// </summary>
        public void PopulateTree1()
        {
            this.treeMenuItem1 = new TreeMenuItemAdv();
            this.treeMenuItem1.ParentControl = this.SourceTreeNavigator;
            this.treeMenuItem2 = new TreeMenuItemAdv();
            this.treeMenuItem2.ParentControl = this.SourceTreeNavigator;
            this.treeMenuItem3 = new TreeMenuItemAdv();
            this.treeMenuItem3.ParentControl = this.SourceTreeNavigator;
            this.treeMenuItem4 = new TreeMenuItemAdv();
            this.treeMenuItem4.ParentControl = this.SourceTreeNavigator;
            this.treeMenuItem5 = new TreeMenuItemAdv();
            this.treeMenuItem5.ParentControl = this.SourceTreeNavigator;

            this.treeMenuItem6 = new TreeMenuItemAdv();
            this.treeMenuItem6.ParentControl = this.SourceTreeNavigator;
            this.treeMenuItem7 = new TreeMenuItemAdv();
            this.treeMenuItem7.ParentControl = this.SourceTreeNavigator;
            this.treeMenuItem8 = new TreeMenuItemAdv();
            this.treeMenuItem8.ParentControl = this.SourceTreeNavigator;
            this.treeMenuItem9 = new TreeMenuItemAdv();
            this.treeMenuItem9.ParentControl = this.SourceTreeNavigator;
            this.treeMenuItem10 = new TreeMenuItemAdv();
            this.treeMenuItem10.ParentControl = this.SourceTreeNavigator;

            this.SourceTreeNavigator.Items.Add(this.treeMenuItem1);
            this.SourceTreeNavigator.Items.Add(this.treeMenuItem2);
            this.SourceTreeNavigator.Items.Add(this.treeMenuItem3);
            this.SourceTreeNavigator.Items.Add(this.treeMenuItem4);
            this.SourceTreeNavigator.Items.Add(this.treeMenuItem5);
            this.SourceTreeNavigator.Items.Add(this.treeMenuItem6);
            this.SourceTreeNavigator.Items.Add(this.treeMenuItem7);
            this.SourceTreeNavigator.Items.Add(this.treeMenuItem8);
            this.SourceTreeNavigator.Items.Add(this.treeMenuItem9);
            this.SourceTreeNavigator.Items.Add(this.treeMenuItem10);

            this.SourceTreeNavigator.SuspendLayout();
            // 
            // treeNavigator1
            // 
            this.SourceTreeNavigator.BackColor = System.Drawing.Color.White;
            this.SourceTreeNavigator.ItemBackColor = System.Drawing.SystemColors.Control;
            this.SourceTreeNavigator.Name = "treeNavigator1";
            this.SourceTreeNavigator.Text = "treeNavigator1";
            // 
            // treeMenuItem1
            // 
            this.treeMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem1.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem1.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem1.Location = new System.Drawing.Point(2, 0);
            this.treeMenuItem1.Name = "treeMenuItem1";
            this.treeMenuItem1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem1.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem1.Size = new System.Drawing.Size(296, 50);
            this.treeMenuItem1.Text = "A";
            this.treeMenuItem1.CollapseImage = this.imageList1.Images[0];
            this.treeMenuItem1.ExpandImage = this.imageList1.Images[1];
            this.treeMenuItem1.LeftImage = this.imageList1.Images[4];
            this.treeMenuItem1.Collapser = true;
            this.treeMenuItem1.ChildCollection.Add(new TreeMenuItemAdvCollection(treeMenuItem2, treeMenuItem1));
            this.treeMenuItem1.ChildCollection.Add(new TreeMenuItemAdvCollection(treeMenuItem3, treeMenuItem1));
            this.treeMenuItem1.ChildCollection.Add(new TreeMenuItemAdvCollection(treeMenuItem4, treeMenuItem1));
            this.treeMenuItem1.ChildCollection.Add(new TreeMenuItemAdvCollection(treeMenuItem5, treeMenuItem1));
            this.treeMenuItem1.ChildCollection.Add(new TreeMenuItemAdvCollection(treeMenuItem6, treeMenuItem1));
            // 
            // treeMenuItem2
            // 
            this.treeMenuItem2.BackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem2.Level = 1;
            this.treeMenuItem2.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem2.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem2.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem2.Location = new System.Drawing.Point(2, 52);
            this.treeMenuItem2.Name = "treeMenuItem2";
            this.treeMenuItem2.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem2.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem2.Size = new System.Drawing.Size(296, 50);
            this.treeMenuItem2.LeftImage = this.imageList1.Images[4];
            this.treeMenuItem2.Text = "B";
            // 
            // treeMenuItem3
            // 
            this.treeMenuItem3.BackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem3.Level = 1;
            this.treeMenuItem3.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem3.Collapser = true;
            this.treeMenuItem3.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem3.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem3.Location = new System.Drawing.Point(2, 104);
            this.treeMenuItem3.Name = "treeMenuItem3";
            this.treeMenuItem3.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem3.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem3.Size = new System.Drawing.Size(296, 50);
            this.treeMenuItem3.TabIndex = 0;
            this.treeMenuItem3.CollapseImage = this.imageList1.Images[0];
            this.treeMenuItem3.ExpandImage = this.imageList1.Images[1];
            this.treeMenuItem3.Text = "C";
            this.treeMenuItem3.LeftImage = this.imageList1.Images[4];
            this.treeMenuItem3.ChildCollection.Add(new TreeMenuItemAdvCollection(treeMenuItem4, treeMenuItem3));
            this.treeMenuItem3.ChildCollection.Add(new TreeMenuItemAdvCollection(treeMenuItem5, treeMenuItem3));
            this.treeMenuItem3.ChildCollection.Add(new TreeMenuItemAdvCollection(treeMenuItem6, treeMenuItem3));
            // 
            // treeMenuItem4
            // 
            this.treeMenuItem4.BackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem4.Level = 2;
            this.treeMenuItem4.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem4.LeftImage = this.imageList1.Images[4];
            this.treeMenuItem4.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem4.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem4.Location = new System.Drawing.Point(2, 156);
            this.treeMenuItem4.Name = "treeMenuItem4";
            this.treeMenuItem4.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem4.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem4.Size = new System.Drawing.Size(296, 50);
            this.treeMenuItem4.TabIndex = 0;
            this.treeMenuItem4.Text = "D";
            // 
            // treeMenuItem5
            // 
            this.treeMenuItem5.BackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem5.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem5.LeftImage = this.imageList1.Images[4];
            this.treeMenuItem5.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem5.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem5.Location = new System.Drawing.Point(2, 156);
            this.treeMenuItem5.Level = 2;
            this.treeMenuItem5.Name = "treeMenuItem4";
            this.treeMenuItem5.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem5.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem5.Size = new System.Drawing.Size(296, 50);
            this.treeMenuItem5.TabIndex = 0;
            this.treeMenuItem5.Text = "E";
            this.treeMenuItem5.Collapser = true;
            this.treeMenuItem5.CollapseImage = this.imageList1.Images[0];
            this.treeMenuItem5.ExpandImage = this.imageList1.Images[1];
            this.treeMenuItem5.ChildCollection.Add(new TreeMenuItemAdvCollection(treeMenuItem6, treeMenuItem5));
            // 
            // treeMenuItem6
            // 
            this.treeMenuItem6.BackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem6.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem6.LeftImage = this.imageList1.Images[4];
            this.treeMenuItem6.Level = 3;
            this.treeMenuItem6.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem6.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem6.Location = new System.Drawing.Point(2, 0);
            this.treeMenuItem6.Name = "treeMenuItem1";
            this.treeMenuItem6.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem6.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem6.Size = new System.Drawing.Size(296, 50);
            this.treeMenuItem6.Text = "F";
            this.treeMenuItem6.CollapseImage = this.imageList1.Images[0];
            this.treeMenuItem6.ExpandImage = this.imageList1.Images[1];
            // 
            // treeMenuItem7
            // 
            this.treeMenuItem7.BackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem7.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem7.Level = 0;
            this.treeMenuItem7.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem7.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem7.Location = new System.Drawing.Point(2, 52);
            this.treeMenuItem7.LeftImage = this.imageList1.Images[4];
            this.treeMenuItem7.Name = "treeMenuItem2";
            this.treeMenuItem7.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem7.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem7.Size = new System.Drawing.Size(296, 50);
            this.treeMenuItem7.Text = "G";
            this.treeMenuItem7.CollapseImage = this.imageList1.Images[0];
            this.treeMenuItem7.ExpandImage = this.imageList1.Images[1];
            // 
            // treeMenuItem8
            // 
            this.treeMenuItem8.BackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem8.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem8.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem8.Level = 0;
            this.treeMenuItem8.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem8.Location = new System.Drawing.Point(2, 104);
            this.treeMenuItem8.Name = "treeMenuItem3";
            this.treeMenuItem8.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem8.LeftImage = this.imageList1.Images[4];
            this.treeMenuItem8.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem8.Size = new System.Drawing.Size(296, 50);
            this.treeMenuItem8.TabIndex = 0;
            this.treeMenuItem8.Text = "H";
            this.treeMenuItem8.CollapseImage = this.imageList1.Images[0];
            this.treeMenuItem8.ExpandImage = this.imageList1.Images[1];
            // 
            // treeMenuItem9
            // 
            this.treeMenuItem9.BackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem9.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem9.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem9.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem9.Location = new System.Drawing.Point(2, 156);
            this.treeMenuItem9.Name = "treeMenuItem4";
            this.treeMenuItem9.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem9.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem9.Level = 0;
            this.treeMenuItem9.Size = new System.Drawing.Size(296, 50);
            this.treeMenuItem9.LeftImage = this.imageList1.Images[4];
            this.treeMenuItem9.TabIndex = 0;
            this.treeMenuItem9.Text = "I";
            this.treeMenuItem9.CollapseImage = this.imageList1.Images[0];
            this.treeMenuItem9.ExpandImage = this.imageList1.Images[1];
            // 
            // treeMenuItem10
            // 
            this.treeMenuItem10.BackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem10.Level = 0;
            this.treeMenuItem10.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem10.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem10.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem10.Location = new System.Drawing.Point(2, 156);
            this.treeMenuItem10.Name = "treeMenuItem4";
            this.treeMenuItem10.LeftImage = this.imageList1.Images[4];
            this.treeMenuItem10.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem10.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem10.Size = new System.Drawing.Size(296, 50);
            this.treeMenuItem10.TabIndex = 0;
            this.treeMenuItem10.Text = "J";
            this.treeMenuItem10.CollapseImage = this.imageList1.Images[0];
            this.treeMenuItem10.ExpandImage = this.imageList1.Images[1];
            
            this.SourceTreeNavigator.ResumeLayout();

            this.SourceTreeNavigator.ParentPanel.DragEnter += ControlInside_DragEnter;
            this.SourceTreeNavigator.ParentPanel.DragDrop += ControlInside_DragDrop;
        }

        /// <summary>
        /// To populate destination TreeNavigator 
        /// </summary>
        public void PopulateTree2()
        {
            this.treeMenuItem1 = new TreeMenuItemAdv();
            this.treeMenuItem1.ParentControl = this.DestinationTreeNavigator;
            this.treeMenuItem2 = new TreeMenuItemAdv();
            this.treeMenuItem2.ParentControl = this.DestinationTreeNavigator;
            this.treeMenuItem3 = new TreeMenuItemAdv();
            this.treeMenuItem3.ParentControl = this.DestinationTreeNavigator;
            this.treeMenuItem4 = new TreeMenuItemAdv();
            this.treeMenuItem4.ParentControl = this.DestinationTreeNavigator;
            this.treeMenuItem5 = new TreeMenuItemAdv();
            this.treeMenuItem5.ParentControl = this.DestinationTreeNavigator;

            this.treeMenuItem6 = new TreeMenuItemAdv();
            this.treeMenuItem6.ParentControl = this.DestinationTreeNavigator;
            this.treeMenuItem7 = new TreeMenuItemAdv();
            this.treeMenuItem7.ParentControl = this.DestinationTreeNavigator;
            this.treeMenuItem8 = new TreeMenuItemAdv();
            this.treeMenuItem8.ParentControl = this.DestinationTreeNavigator;
            this.treeMenuItem9 = new TreeMenuItemAdv();
            this.treeMenuItem9.ParentControl = this.DestinationTreeNavigator;
            this.treeMenuItem10 = new TreeMenuItemAdv();
            this.treeMenuItem10.ParentControl = this.DestinationTreeNavigator;

            this.DestinationTreeNavigator.Items.Add(this.treeMenuItem1);
            this.DestinationTreeNavigator.Items.Add(this.treeMenuItem2);
            this.DestinationTreeNavigator.Items.Add(this.treeMenuItem3);
            this.DestinationTreeNavigator.Items.Add(this.treeMenuItem4);
            this.DestinationTreeNavigator.Items.Add(this.treeMenuItem5);
            this.DestinationTreeNavigator.Items.Add(this.treeMenuItem6);
            this.DestinationTreeNavigator.Items.Add(this.treeMenuItem7);
            this.DestinationTreeNavigator.Items.Add(this.treeMenuItem8);
            this.DestinationTreeNavigator.Items.Add(this.treeMenuItem9);
            this.DestinationTreeNavigator.Items.Add(this.treeMenuItem10);

            this.DestinationTreeNavigator.SuspendLayout();
            // 
            // treeNavigator1
            // 
            this.DestinationTreeNavigator.BackColor = System.Drawing.Color.White;
            this.DestinationTreeNavigator.ItemBackColor = System.Drawing.SystemColors.Control;
            this.DestinationTreeNavigator.Name = "treeNavigator1";
            this.DestinationTreeNavigator.Text = "treeNavigator1";
            // 
            // treeMenuItem1
            // 
            this.treeMenuItem1.AllowDrag = false;
            this.treeMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem1.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem1.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem1.Location = new System.Drawing.Point(2, 0);
            this.treeMenuItem1.Name = "treeMenuItem1";
            this.treeMenuItem1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem1.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem1.Size = new System.Drawing.Size(296, 50);
            this.treeMenuItem1.Text = "1";
            this.treeMenuItem1.CollapseImage = this.imageList1.Images[0];
            this.treeMenuItem1.ExpandImage = this.imageList1.Images[1];
            this.treeMenuItem1.LeftImage = this.imageList1.Images[4];
            this.treeMenuItem1.Collapser = true;
            this.treeMenuItem1.ChildCollection.Add(new TreeMenuItemAdvCollection(treeMenuItem2, treeMenuItem1));
            this.treeMenuItem1.ChildCollection.Add(new TreeMenuItemAdvCollection(treeMenuItem3, treeMenuItem1));
            this.treeMenuItem1.ChildCollection.Add(new TreeMenuItemAdvCollection(treeMenuItem4, treeMenuItem1));
            this.treeMenuItem1.ChildCollection.Add(new TreeMenuItemAdvCollection(treeMenuItem5, treeMenuItem1));
            this.treeMenuItem1.ChildCollection.Add(new TreeMenuItemAdvCollection(treeMenuItem6, treeMenuItem1));
            // 
            // treeMenuItem2
            // 
            this.treeMenuItem2.AllowDrag = false;
            this.treeMenuItem2.BackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem2.Level = 1;
            this.treeMenuItem2.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem2.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem2.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem2.Location = new System.Drawing.Point(2, 52);
            this.treeMenuItem2.Name = "treeMenuItem2";
            this.treeMenuItem2.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem2.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem2.Size = new System.Drawing.Size(296, 50);
            this.treeMenuItem2.LeftImage = this.imageList1.Images[4];
            this.treeMenuItem2.Text = "2";
            // 
            // treeMenuItem3
            // 
            this.treeMenuItem3.AllowDrag = false;
            this.treeMenuItem3.BackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem3.Level = 1;
            this.treeMenuItem3.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem3.Collapser = true;
            this.treeMenuItem3.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem3.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem3.Location = new System.Drawing.Point(2, 104);
            this.treeMenuItem3.Name = "treeMenuItem3";
            this.treeMenuItem3.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem3.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem3.Size = new System.Drawing.Size(296, 50);
            this.treeMenuItem3.TabIndex = 0;
            this.treeMenuItem3.CollapseImage = this.imageList1.Images[0];
            this.treeMenuItem3.ExpandImage = this.imageList1.Images[1];
            this.treeMenuItem3.Text = "3";
            this.treeMenuItem3.LeftImage = this.imageList1.Images[4];
            this.treeMenuItem3.ChildCollection.Add(new TreeMenuItemAdvCollection(treeMenuItem4, treeMenuItem3));
            this.treeMenuItem3.ChildCollection.Add(new TreeMenuItemAdvCollection(treeMenuItem5, treeMenuItem3));
            this.treeMenuItem3.ChildCollection.Add(new TreeMenuItemAdvCollection(treeMenuItem6, treeMenuItem3));
            // 
            // treeMenuItem4
            // 
            this.treeMenuItem4.AllowDrag = false;
            this.treeMenuItem4.BackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem4.Level = 2;
            this.treeMenuItem4.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem4.LeftImage = this.imageList1.Images[4];
            this.treeMenuItem4.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem4.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem4.Location = new System.Drawing.Point(2, 156);
            this.treeMenuItem4.Name = "treeMenuItem4";
            this.treeMenuItem4.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem4.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem4.Size = new System.Drawing.Size(296, 50);
            this.treeMenuItem4.TabIndex = 0;
            this.treeMenuItem4.Text = "4";
            // 
            // treeMenuItem5
            // 
            this.treeMenuItem5.AllowDrag = false;
            this.treeMenuItem5.BackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem5.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem5.LeftImage = this.imageList1.Images[4];
            this.treeMenuItem5.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem5.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem5.Location = new System.Drawing.Point(2, 156);
            this.treeMenuItem5.Level = 2;
            this.treeMenuItem5.Name = "treeMenuItem4";
            this.treeMenuItem5.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem5.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem5.Size = new System.Drawing.Size(296, 50);
            this.treeMenuItem5.TabIndex = 0;
            this.treeMenuItem5.Text = "5";
            this.treeMenuItem5.Collapser = true;
            this.treeMenuItem5.CollapseImage = this.imageList1.Images[0];
            this.treeMenuItem5.ExpandImage = this.imageList1.Images[1];
            this.treeMenuItem5.ChildCollection.Add(new TreeMenuItemAdvCollection(treeMenuItem6, treeMenuItem5));
            // 
            // treeMenuItem6
            // 
            this.treeMenuItem6.AllowDrag = false;
            this.treeMenuItem6.BackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem6.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem6.LeftImage = this.imageList1.Images[4];
            this.treeMenuItem6.Level = 3;
            this.treeMenuItem6.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem6.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem6.Location = new System.Drawing.Point(2, 0);
            this.treeMenuItem6.Name = "treeMenuItem1";
            this.treeMenuItem6.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem6.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem6.Size = new System.Drawing.Size(296, 50);
            this.treeMenuItem6.Text = "6";
            this.treeMenuItem6.CollapseImage = this.imageList1.Images[0];
            this.treeMenuItem6.ExpandImage = this.imageList1.Images[1];
            // 
            // treeMenuItem7
            // 
            this.treeMenuItem7.AllowDrag = false;
            this.treeMenuItem7.BackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem7.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem7.Level = 0;
            this.treeMenuItem7.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem7.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem7.Location = new System.Drawing.Point(2, 52);
            this.treeMenuItem7.LeftImage = this.imageList1.Images[4];
            this.treeMenuItem7.Name = "treeMenuItem2";
            this.treeMenuItem7.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem7.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem7.Size = new System.Drawing.Size(296, 50);
            this.treeMenuItem7.Text = "7";
            this.treeMenuItem7.CollapseImage = this.imageList1.Images[0];
            this.treeMenuItem7.ExpandImage = this.imageList1.Images[1];
            // 
            // treeMenuItem8
            // 
            this.treeMenuItem8.AllowDrag = false;
            this.treeMenuItem8.BackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem8.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem8.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem8.Level = 0;
            this.treeMenuItem8.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem8.Location = new System.Drawing.Point(2, 104);
            this.treeMenuItem8.Name = "treeMenuItem3";
            this.treeMenuItem8.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem8.LeftImage = this.imageList1.Images[4];
            this.treeMenuItem8.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem8.Size = new System.Drawing.Size(296, 50);
            this.treeMenuItem8.TabIndex = 0;
            this.treeMenuItem8.Text = "8";
            this.treeMenuItem8.CollapseImage = this.imageList1.Images[0];
            this.treeMenuItem8.ExpandImage = this.imageList1.Images[1];
            // 
            // treeMenuItem9
            // 
            this.treeMenuItem9.AllowDrag = false;
            this.treeMenuItem9.BackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem9.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem9.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem9.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem9.Location = new System.Drawing.Point(2, 156);
            this.treeMenuItem9.Name = "treeMenuItem4";
            this.treeMenuItem9.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem9.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem9.Level = 0;
            this.treeMenuItem9.Size = new System.Drawing.Size(296, 50);
            this.treeMenuItem9.LeftImage = this.imageList1.Images[4];
            this.treeMenuItem9.TabIndex = 0;
            this.treeMenuItem9.Text = "9";
            this.treeMenuItem9.CollapseImage = this.imageList1.Images[0];
            this.treeMenuItem9.ExpandImage = this.imageList1.Images[1];
            // 
            // treeMenuItem10
            // 
            this.treeMenuItem10.AllowDrag = false;
            this.treeMenuItem10.BackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem10.Level = 0;
            this.treeMenuItem10.ForeColor = System.Drawing.Color.Black;
            this.treeMenuItem10.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMenuItem10.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.treeMenuItem10.Location = new System.Drawing.Point(2, 156);
            this.treeMenuItem10.Name = "treeMenuItem4";
            this.treeMenuItem10.LeftImage = this.imageList1.Images[4];
            this.treeMenuItem10.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(193)))), ((int)(((byte)(220)))));
            this.treeMenuItem10.SelectedItemForeColor = System.Drawing.Color.Black;
            this.treeMenuItem10.Size = new System.Drawing.Size(296, 50);
            this.treeMenuItem10.TabIndex = 0;
            this.treeMenuItem10.Text = "10";
            this.treeMenuItem10.CollapseImage = this.imageList1.Images[0];
            this.treeMenuItem10.ExpandImage = this.imageList1.Images[1];
            this.DestinationTreeNavigator.ResumeLayout();
            this.DestinationTreeNavigator.ParentPanel.DragEnter += Outside_DragEnter;
            this.DestinationTreeNavigator.ParentPanel.DragDrop += Outside_DragDrop;
        }

        #endregion

        #region Events

        /// <summary>
        /// Occurs when Items Dropped
        /// </summary>
        private void Outside_DragDrop(object sender, DragEventArgs e)
        {
            IntPtr hWnd = WindowFromPoint(Control.MousePosition);

            if (hWnd != IntPtr.Zero)
            {
                TreeMenuItemAdv ctrlUnderMouse = (TreeMenuItemAdv)Control.FromHandle(hWnd);

                if (ctrlUnderMouse != null)
                {
                    TreeMenuItemAdv menuDrop = e.Data.GetData(e.Data.GetFormats()[0]) as TreeMenuItemAdv;

                    if (menuDrop != null)
                    {
                        this.SourceTreeNavigator.Items.Remove(menuDrop);

                        if (menuDrop.ParentItem != null)
                        {
                            for (int i = 0; i < menuDrop.ParentItem.ChildCollection.Count; i++)
                            {
                                if (menuDrop.ParentItem.ChildCollection[i].ChildTreeMenuItemAdv == menuDrop)
                                {
                                    menuDrop.ParentItem.ChildCollection.Remove(menuDrop.ParentItem.ChildCollection[i]);
                                    break;
                                }
                            }
                            for (int i = 0; i < menuDrop.ParentItem.ChildCollection.Count; i++)
                            {
                                for (int j = 0; j < menuDrop.ChildCollection.Count; j++)
                                {
                                    if (menuDrop.ParentItem.ChildCollection[i].ChildTreeMenuItemAdv == menuDrop.ChildCollection[j].ChildTreeMenuItemAdv)
                                    {
                                        menuDrop.ParentItem.ChildCollection.Remove(menuDrop.ParentItem.ChildCollection[i]);
                                        i = 0;
                                        break;
                                    }
                                }
                            }
                        }
                        
                        menuDrop.ParentItem = null;

                        this.SourceTreeNavigator.UpdateVisibleItemBounds();

                        menuDrop.ParentControl = this.DestinationTreeNavigator;

                        this.DestinationTreeNavigator.Items.Insert((this.DestinationTreeNavigator.Items.IndexOf(ctrlUnderMouse)), menuDrop);
                        
                        this.DestinationTreeNavigator.UpdateVisibleItemBounds();

                        foreach (TreeMenuItemAdvCollection item in menuDrop.ChildCollection)
                        {
                            this.SourceTreeNavigator.Items.Remove(item.ChildTreeMenuItemAdv);
                            item.ParentTreeMenuItemAdv = null;
                        }

                        this.SourceTreeNavigator.UpdateVisibleItemBounds();

                        int index = (this.DestinationTreeNavigator.Items.IndexOf(menuDrop) + 1);

                        for (int i = 0; i < menuDrop.ChildCollection.Count; i++)
                        {
                            if (i == 0)
                            {
                                this.DestinationTreeNavigator.Items.Insert(index, menuDrop.ChildCollection[i].ChildTreeMenuItemAdv);
                            }
                            else
                            {
                                index += 1;
                                this.DestinationTreeNavigator.Items.Insert(index, menuDrop.ChildCollection[i].ChildTreeMenuItemAdv);
                            }
                            menuDrop.ChildCollection[i].ChildTreeMenuItemAdv.ParentControl = this.DestinationTreeNavigator;
                        }

                        this.DestinationTreeNavigator.UpdateVisibleItemBounds();
                    }
                }
            }
        }

        /// <summary>
        /// Occurs when Items are dragged
        /// </summary>
        private void Outside_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        /// <summary>
        /// Occurs when dropped inside the control
        /// </summary>
        private void ControlInside_DragDrop(object sender, DragEventArgs e)
        {
            IntPtr hWnd = WindowFromPoint(Control.MousePosition);

            if (hWnd != IntPtr.Zero)
            {
                TreeMenuItemAdv ctrlUnderMouse = (TreeMenuItemAdv)Control.FromHandle(hWnd);

                if (ctrlUnderMouse != null) 
                {
                    TreeMenuItemAdv menuDrop = e.Data.GetData(e.Data.GetFormats()[0]) as TreeMenuItemAdv;

                    if (menuDrop != null)
                    {
                        this.SourceTreeNavigator.Items.Remove(menuDrop);

                        if (menuDrop.ParentItem != null)
                        {
                            for (int i = 0; i < menuDrop.ParentItem.ChildCollection.Count; i++)
                            {
                                if (menuDrop.ParentItem.ChildCollection[i].ChildTreeMenuItemAdv == menuDrop)
                                {
                                    menuDrop.ParentItem.ChildCollection.Remove(menuDrop.ParentItem.ChildCollection[i]);
                                    break;
                                }
                            }
                            for (int i = 0; i < menuDrop.ParentItem.ChildCollection.Count; i++)
                            {
                                for (int j = 0; j < menuDrop.ChildCollection.Count; j++)
                                {
                                    if (menuDrop.ParentItem.ChildCollection[i].ChildTreeMenuItemAdv == menuDrop.ChildCollection[j].ChildTreeMenuItemAdv)
                                    {
                                        menuDrop.ParentItem.ChildCollection.Remove(menuDrop.ParentItem.ChildCollection[i]);
                                        i = 0;
                                        break;
                                    }
                                }
                            }
                        }

                        menuDrop.ParentItem = null;

                        this.SourceTreeNavigator.UpdateVisibleItemBounds();

                        menuDrop.ParentControl = this.SourceTreeNavigator;

                        this.SourceTreeNavigator.Items.Insert((this.SourceTreeNavigator.Items.IndexOf(ctrlUnderMouse)), menuDrop);

                        this.SourceTreeNavigator.UpdateVisibleItemBounds();

                        foreach (TreeMenuItemAdvCollection item in menuDrop.ChildCollection)
                        {
                            this.SourceTreeNavigator.Items.Remove(item.ChildTreeMenuItemAdv);
                            item.ParentTreeMenuItemAdv = null;
                        }

                        this.SourceTreeNavigator.UpdateVisibleItemBounds();

                        int index = (this.SourceTreeNavigator.Items.IndexOf(menuDrop) + 1);

                        for (int i = 0; i < menuDrop.ChildCollection.Count; i++)
                        {
                            if (i == 0)
                            {
                                this.SourceTreeNavigator.Items.Insert(index, menuDrop.ChildCollection[i].ChildTreeMenuItemAdv);
                            }
                            else
                            {
                                index += 1;
                                this.SourceTreeNavigator.Items.Insert(index, menuDrop.ChildCollection[i].ChildTreeMenuItemAdv);
                            }
                            menuDrop.ChildCollection[i].ChildTreeMenuItemAdv.ParentControl = this.SourceTreeNavigator;
                        }

                        this.SourceTreeNavigator.UpdateVisibleItemBounds();
                    }
                }
            }
        }

        /// <summary>
        /// Occurs when Dragged inside the control
        /// </summary>
        private void ControlInside_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        #endregion
    }
}
