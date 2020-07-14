using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Syncfusion.Windows.Forms.Tools;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;

namespace TreeNavigatorSample
{
    /// <summary>
    /// Collection
    /// </summary>
    public class TreeMenuItemAdvCollection
    {
        public TreeMenuItemAdvCollection(TreeMenuItemAdv ChildMenuItem, TreeMenuItemAdv ParentMenuItem)
        {
            ChildTreeMenuItemAdv = ChildMenuItem;
            ParentTreeMenuItemAdv = ParentMenuItem;
            ChildTreeMenuItemAdv.ParentItem = ParentTreeMenuItemAdv;
        }

        /// <summary>
        /// Holds the Child TreeMenuItemAdv
        /// </summary>
        private TreeMenuItemAdv m_Child = null;
        /// <summary>
        /// Gets/Sets the Child TreeMenuItemAdv
        /// </summary>
        public TreeMenuItemAdv ChildTreeMenuItemAdv
        {
            get { return m_Child; }
            set { m_Child = value; }
        }

        /// <summary>
        /// Holds the Parent TreeMenuItemAdv
        /// </summary>
        private TreeMenuItemAdv m_Parent = null;
        /// <summary>
        /// Gets/Sets the Parent TreeMenuItemAdv
        /// </summary>
        public TreeMenuItemAdv ParentTreeMenuItemAdv
        {
            get { return m_Parent; }
            set { m_Parent = value; }
        }


    }

    /// <summary>
    /// Advanced TreeMenuItem class
    /// </summary>
    public class TreeMenuItemAdv : TreeMenuItem
    {
        #region Variables

        /// <summary>
        /// Holds whether it is being dragged
        /// </summary>
        private bool isDragging = false;

        /// <summary>
        /// Holds the Drag radius
        /// </summary>
        private int dragRadius = 40;

        /// <summary>
        /// Holds the Mouse down X position
        /// </summary>
        private int mousedownX = 0;

        /// <summary>
        /// Holds the Mouse down Y position
        /// </summary>
        private int mousedowny = 0;

        #endregion

        #region Constructor

        public TreeMenuItemAdv()
        {
            this.AllowDrag = true;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Hold whether it can be dragged
        /// </summary>
        private bool m_AllowDrag = false;
        /// <summary>
        /// Gets / Sets whether to allow drag
        /// </summary>
        public bool AllowDrag
        {
            get { return m_AllowDrag; }
            set { m_AllowDrag = value; }
        }

        /// <summary>
        /// Child Collection
        /// </summary>
        private List<TreeMenuItemAdvCollection> m_ChildCollection;
        /// <summary>
        /// Child Collection
        /// </summary>
        public List<TreeMenuItemAdvCollection> ChildCollection
        {
            get
            {
                if (m_ChildCollection == null)
                {
                    m_ChildCollection = new List<TreeMenuItemAdvCollection>();
                }
                return m_ChildCollection;
            }
        }


        private int m_Level = 0;
        /// <summary>
        /// Gets / Sets the Level
        /// </summary>
        public int Level
        {
            get { return m_Level; }
            set { m_Level = value; }
        }


        private TreeNavigator m_ParentControl;
        /// <summary>
        /// Gets / Sets the Parent Control
        /// </summary>
        public TreeNavigator ParentControl
        {
            get { return m_ParentControl; }
            set { m_ParentControl = value; }
        }


        private bool m_isParent = false;
        /// <summary>
        /// Gets whether this is Parent Item
        /// </summary>
        public bool IsParentItem
        {
            get
            {
                if (this.Items.Count > 0)
                    return true;
                else
                    return m_isParent;
            }
        }

        private bool m_Collapsed = false;
        /// <summary>
        /// Gets/Sets whether TreeMenuItemAdv is Collapsed/Expand
        /// </summary>
        public bool Collapsed
        {
            get { return m_Collapsed; }
            set
            {
                m_Collapsed = value;

                this.Invalidate();
            }
        }

        private Image m_Image = null;
        /// <summary>
        /// Gets/Sets the image to be displayed in left side
        /// </summary>
        public Image LeftImage
        {
            get { return m_Image; }
            set { m_Image = value; }
        }

        private Image m_CollapseImage = null;
        /// <summary>
        /// Gets/Sets the image to Collapse
        /// </summary>
        public Image CollapseImage
        {
            get { return m_CollapseImage; }
            set { m_CollapseImage = value; }
        }

        private Image m_ExpandImage = null;
        /// <summary>
        /// Gets/Sets the image to Expand
        /// </summary>
        public Image ExpandImage
        {
            get { return m_ExpandImage; }
            set { m_ExpandImage = value; }
        }

        private bool m_Collapser = false;
        /// <summary>
        /// Gets/Sets whether this is Collapser
        /// </summary>
        public bool Collapser
        {
            get { return m_Collapser; }
            set { m_Collapser = value; }
        }

        /// <summary>
        /// Parent TreeMenuExt item.
        /// </summary>
        private TreeMenuItemAdv m_Parent = null;
        /// <summary>
        /// Gets/Sets the Parent TreeMenuExt item.
        /// </summary>
        public TreeMenuItemAdv ParentItem
        {
            get { return m_Parent; }
            set { m_Parent = value; }
        }

        #endregion

        #region Overrides

        protected override void OnVisibleChanged(EventArgs e)
        {
            if (Visible)
            {
                foreach (TreeMenuItemAdvCollection item in this.ChildCollection)
                {
                    if (item.ParentTreeMenuItemAdv == this)
                    {
                        item.ChildTreeMenuItemAdv.Visible = true;
                    }
                }
            }
            else
            {
                foreach (TreeMenuItemAdvCollection item in this.ChildCollection)
                {
                    if (item.ParentTreeMenuItemAdv == this)
                    {
                        item.ChildTreeMenuItemAdv.Visible = false;
                    }
                }
            }
            base.OnVisibleChanged(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            this.Focus();
            base.OnMouseDown(e);
            mousedownX = e.X;
            mousedowny = e.Y;
            this.isDragging = false;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (!isDragging)
            {
                // This is a check to see if the mouse is moving while pressed.
                // Without this, the DragDrop is fired directly when the control is clicked, now you have to drag a few pixels first.
                if (e.Button == MouseButtons.Left && dragRadius > 0 && this.AllowDrag)
                {
                    int num1 = mousedownX - e.X;
                    int num2 = mousedowny - e.Y;
                    if (((num1 * num1) + (num2 * num2)) > dragRadius)
                    {
                        DoDragDrop(this, DragDropEffects.All);
                        isDragging = true;
                        return;
                    }
                }
                base.OnMouseMove(e);
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            isDragging = false;

            if (!this.Collapsed && this.ParentControl != null)
            {
                for (int i = 0; i < this.ChildCollection.Count; i++)
                {
                    TreeMenuItemAdv item = this.ChildCollection[i].ChildTreeMenuItemAdv as TreeMenuItemAdv;
                    if (item != null && item.ParentItem == this)
                    {
                        item.Visible = false;
                        if (this.ParentControl != null)
                            this.ParentControl.SerializeScrollPosition();
                        this.Collapsed = true;
                        item.Invalidate();
                    }
                }
            }

            else if (this.Collapsed && this.ParentControl != null)
            {
                for (int i = 0; i < this.ChildCollection.Count; i++)
                {
                    TreeMenuItemAdv item = this.ChildCollection[i].ChildTreeMenuItemAdv as TreeMenuItemAdv;
                    if (item != null && item.ParentItem == this)
                    {
                        item.Visible = true;
                        if (this.ParentControl != null)
                            this.ParentControl.SerializeScrollPosition();
                        this.Collapsed = false;
                        item.Invalidate();
                    }
                }
            }

            if (this.ParentControl != null)
            {
                this.ParentControl.UpdateVisibleItemBounds();
                this.ParentControl.ApplySavedScrollPosition();
            }

            base.OnMouseUp(e);
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            Pen linepen;
            linepen = new Pen(Color.FromArgb(54, 54, 54));
            Color selected = Color.White;

            linepen = new Pen(Color.FromArgb(54, 54, 54));
            linepen.Width = 2;
            if (Collapser)
            {
                if (Collapsed)
                {
                    if (this.CollapseImage != null)
                    {
                        e.Graphics.DrawImage(this.CollapseImage, new Rectangle(this.Width - 25, this.Height / 2 - 6, this.CollapseImage.Size.Width, this.CollapseImage.Size.Height));
                    }
                }
                else
                {
                    if (this.ExpandImage != null)
                    {
                        e.Graphics.DrawImage(this.ExpandImage, new Rectangle(this.Width - 25, this.Height / 2 - 6, this.ExpandImage.Size.Width, this.ExpandImage.Size.Height));
                    }
                }
                if (this.LeftImage != null)
                {
                    e.Graphics.DrawImage(this.LeftImage, new Rectangle(this.DisplayRectangle.X + ((Level * 16)), ((this.Height / 2) - (this.LeftImage.Height / 2)), this.LeftImage.Size.Width, this.LeftImage.Size.Height));
                    TextRenderer.DrawText(e.Graphics, this.Text, this.Font, new Rectangle(this.DisplayRectangle.X + ((Level + 1) * 20), this.DisplayRectangle.Y, this.DisplayRectangle.Width, this.DisplayRectangle.Height), Color.Black, TextFormatFlags.VerticalCenter | TextFormatFlags.LeftAndRightPadding);
                }
                else
                {
                    TextRenderer.DrawText(e.Graphics, this.Text, this.Font, new Rectangle(this.DisplayRectangle.X + (Level * 16), this.DisplayRectangle.Y, this.DisplayRectangle.Width, this.DisplayRectangle.Height), Color.Black, TextFormatFlags.VerticalCenter | TextFormatFlags.LeftAndRightPadding);
                }
            }
            else
            {
                if (this.LeftImage != null)
                {
                    e.Graphics.DrawImage(this.LeftImage, new Rectangle(this.DisplayRectangle.X + ((Level * 16)), ((this.Height / 2) - (this.LeftImage.Height / 2)), this.LeftImage.Size.Width, this.LeftImage.Size.Height));
                    TextRenderer.DrawText(e.Graphics, this.Text, this.Font, new Rectangle(this.DisplayRectangle.X + ((Level + 1) * 20), this.DisplayRectangle.Y, this.DisplayRectangle.Width, this.DisplayRectangle.Height), Color.Black, TextFormatFlags.VerticalCenter | TextFormatFlags.LeftAndRightPadding);
                }
                else
                {
                    TextRenderer.DrawText(e.Graphics, this.Text, this.Font, new Rectangle(this.DisplayRectangle.X + (Level * 16), this.DisplayRectangle.Y, this.DisplayRectangle.Width, this.DisplayRectangle.Height), Color.Black, TextFormatFlags.VerticalCenter | TextFormatFlags.LeftAndRightPadding);
                }
            }
        }

        #endregion
    }

}
