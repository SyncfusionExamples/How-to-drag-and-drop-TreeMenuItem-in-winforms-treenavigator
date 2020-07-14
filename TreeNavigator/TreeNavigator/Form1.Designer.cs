namespace TreeNavigatorSample
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Tools.TreeNavigator.HeaderCollection headerCollection1 = new Syncfusion.Windows.Forms.Tools.TreeNavigator.HeaderCollection();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Syncfusion.Windows.Forms.Tools.TreeNavigator.HeaderCollection headerCollection2 = new Syncfusion.Windows.Forms.Tools.TreeNavigator.HeaderCollection();
            this.SourceTreeNavigator = new Syncfusion.Windows.Forms.Tools.TreeNavigator();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.DestinationTreeNavigator = new Syncfusion.Windows.Forms.Tools.TreeNavigator();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SourceTreeNavigator
            // 
            this.SourceTreeNavigator.BackColor = System.Drawing.Color.White;
            headerCollection1.Font = new System.Drawing.Font("Arial", 8F);
            headerCollection1.HeaderText = "Customizable TreeNavigator";
            this.SourceTreeNavigator.Header = headerCollection1;
            this.SourceTreeNavigator.ItemBackColor = System.Drawing.SystemColors.Control;
            this.SourceTreeNavigator.Location = new System.Drawing.Point(61, 89);
            this.SourceTreeNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.SourceTreeNavigator.MinimumSize = new System.Drawing.Size(200, 185);
            this.SourceTreeNavigator.Name = "SourceTreeNavigator";
            this.SourceTreeNavigator.Size = new System.Drawing.Size(480, 629);
            this.SourceTreeNavigator.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "CollapseNotifier.png");
            this.imageList1.Images.SetKeyName(1, "ExpandNotifier.png");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            // 
            // DestinationTreeNavigator
            // 
            this.DestinationTreeNavigator.BackColor = System.Drawing.Color.White;
            headerCollection2.Font = new System.Drawing.Font("Arial", 8F);
            headerCollection2.HeaderText = "Customizable TreeNavigator";
            this.DestinationTreeNavigator.Header = headerCollection2;
            this.DestinationTreeNavigator.ItemBackColor = System.Drawing.SystemColors.Control;
            this.DestinationTreeNavigator.Location = new System.Drawing.Point(740, 89);
            this.DestinationTreeNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.DestinationTreeNavigator.MinimumSize = new System.Drawing.Size(200, 185);
            this.DestinationTreeNavigator.Name = "DestinationTreeNavigator";
            this.DestinationTreeNavigator.Size = new System.Drawing.Size(480, 629);
            this.DestinationTreeNavigator.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(737, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.CaptionButtonColor = System.Drawing.Color.Black;
            this.CaptionButtonHoverColor = System.Drawing.Color.White;
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1295, 822);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DestinationTreeNavigator);
            this.Controls.Add(this.SourceTreeNavigator);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TreeNavigator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TreeNavigator SourceTreeNavigator;
        private System.Windows.Forms.ImageList imageList1;
        private Syncfusion.Windows.Forms.Tools.TreeNavigator DestinationTreeNavigator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

