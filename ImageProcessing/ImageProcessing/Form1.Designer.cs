namespace ImageProcessing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ToCropImage = new Button();
            textBoxX = new TextBox();
            textBoxY = new TextBox();
            textBoxWidth = new TextBox();
            textBoxHeight = new TextBox();
            bightnessEnhancementButton = new Button();
            textBoxBrightness = new TextBox();
            hScrollBar1 = new HScrollBar();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            selectImageToolStripMenuItem = new ToolStripMenuItem();
            propertyToolStripMenuItem = new ToolStripMenuItem();
            convertGreyToolStripMenuItem = new ToolStripMenuItem();
            convertBinaryToolStripMenuItem = new ToolStripMenuItem();
            edgeDetectionToolStripMenuItem = new ToolStripMenuItem();
            gaussToolStripMenuItem = new ToolStripMenuItem();
            zoomToolStripMenuItem = new ToolStripMenuItem();
            ınToolStripMenuItem = new ToolStripMenuItem();
            outToolStripMenuItem = new ToolStripMenuItem();
            rotateToolStripMenuItem = new ToolStripMenuItem();
            clock90ToolStripMenuItem = new ToolStripMenuItem();
            antiClock90ToolStripMenuItem = new ToolStripMenuItem();
            addAndMultypToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(80, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 274);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(388, 46);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(184, 274);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // ToCropImage
            // 
            ToCropImage.Location = new Point(414, 461);
            ToCropImage.Name = "ToCropImage";
            ToCropImage.Size = new Size(161, 29);
            ToCropImage.TabIndex = 7;
            ToCropImage.Text = "ToCropImage";
            ToCropImage.UseVisualStyleBackColor = true;
            ToCropImage.Click += ToCropImage_Click;
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(378, 406);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(52, 27);
            textBoxX.TabIndex = 8;
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(454, 406);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(52, 27);
            textBoxY.TabIndex = 9;
            // 
            // textBoxWidth
            // 
            textBoxWidth.Location = new Point(523, 406);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(52, 27);
            textBoxWidth.TabIndex = 10;
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(590, 406);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(52, 27);
            textBoxHeight.TabIndex = 11;
            // 
            // bightnessEnhancementButton
            // 
            bightnessEnhancementButton.Location = new Point(323, 537);
            bightnessEnhancementButton.Name = "bightnessEnhancementButton";
            bightnessEnhancementButton.Size = new Size(260, 29);
            bightnessEnhancementButton.TabIndex = 14;
            bightnessEnhancementButton.Text = "bightnessEnhancementButton";
            bightnessEnhancementButton.UseVisualStyleBackColor = true;
            bightnessEnhancementButton.Click += bightnessEnhancementButton_Click;
            // 
            // textBoxBrightness
            // 
            textBoxBrightness.Location = new Point(589, 537);
            textBoxBrightness.Name = "textBoxBrightness";
            textBoxBrightness.Size = new Size(73, 27);
            textBoxBrightness.TabIndex = 15;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(48, 584);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(614, 26);
            hScrollBar1.TabIndex = 16;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, propertyToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1062, 28);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { selectImageToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // selectImageToolStripMenuItem
            // 
            selectImageToolStripMenuItem.Name = "selectImageToolStripMenuItem";
            selectImageToolStripMenuItem.Size = new Size(178, 26);
            selectImageToolStripMenuItem.Text = "Select Image";
            selectImageToolStripMenuItem.Click += selectImageToolStripMenuItem_Click;
            // 
            // propertyToolStripMenuItem
            // 
            propertyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { convertGreyToolStripMenuItem, convertBinaryToolStripMenuItem, edgeDetectionToolStripMenuItem, gaussToolStripMenuItem, zoomToolStripMenuItem, rotateToolStripMenuItem, addAndMultypToolStripMenuItem });
            propertyToolStripMenuItem.Name = "propertyToolStripMenuItem";
            propertyToolStripMenuItem.Size = new Size(79, 24);
            propertyToolStripMenuItem.Text = "Property";
            propertyToolStripMenuItem.Click += propertyToolStripMenuItem_Click;
            // 
            // convertGreyToolStripMenuItem
            // 
            convertGreyToolStripMenuItem.Name = "convertGreyToolStripMenuItem";
            convertGreyToolStripMenuItem.Size = new Size(210, 26);
            convertGreyToolStripMenuItem.Text = "Convert Grey";
            convertGreyToolStripMenuItem.Click += convertGreyToolStripMenuItem_Click;
            // 
            // convertBinaryToolStripMenuItem
            // 
            convertBinaryToolStripMenuItem.Name = "convertBinaryToolStripMenuItem";
            convertBinaryToolStripMenuItem.Size = new Size(210, 26);
            convertBinaryToolStripMenuItem.Text = "Convert Binary";
            convertBinaryToolStripMenuItem.Click += convertBinaryToolStripMenuItem_Click;
            // 
            // edgeDetectionToolStripMenuItem
            // 
            edgeDetectionToolStripMenuItem.Name = "edgeDetectionToolStripMenuItem";
            edgeDetectionToolStripMenuItem.Size = new Size(210, 26);
            edgeDetectionToolStripMenuItem.Text = "Edge Detection";
            edgeDetectionToolStripMenuItem.Click += edgeDetectionToolStripMenuItem_Click;
            // 
            // gaussToolStripMenuItem
            // 
            gaussToolStripMenuItem.Name = "gaussToolStripMenuItem";
            gaussToolStripMenuItem.Size = new Size(210, 26);
            gaussToolStripMenuItem.Text = "Gauss ";
            gaussToolStripMenuItem.Click += gaussToolStripMenuItem_Click;
            // 
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ınToolStripMenuItem, outToolStripMenuItem });
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.Size = new Size(210, 26);
            zoomToolStripMenuItem.Text = "Zoom";
            // 
            // ınToolStripMenuItem
            // 
            ınToolStripMenuItem.Name = "ınToolStripMenuItem";
            ınToolStripMenuItem.Size = new Size(116, 26);
            ınToolStripMenuItem.Text = "In";
            ınToolStripMenuItem.Click += ınToolStripMenuItem_Click;
            // 
            // outToolStripMenuItem
            // 
            outToolStripMenuItem.Name = "outToolStripMenuItem";
            outToolStripMenuItem.Size = new Size(116, 26);
            outToolStripMenuItem.Text = "Out";
            outToolStripMenuItem.Click += outToolStripMenuItem_Click;
            // 
            // rotateToolStripMenuItem
            // 
            rotateToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clock90ToolStripMenuItem, antiClock90ToolStripMenuItem });
            rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            rotateToolStripMenuItem.Size = new Size(210, 26);
            rotateToolStripMenuItem.Text = "Rotate";
            // 
            // clock90ToolStripMenuItem
            // 
            clock90ToolStripMenuItem.Name = "clock90ToolStripMenuItem";
            clock90ToolStripMenuItem.Size = new Size(175, 26);
            clock90ToolStripMenuItem.Text = "Clock 90";
            clock90ToolStripMenuItem.Click += clock90ToolStripMenuItem_Click;
            // 
            // antiClock90ToolStripMenuItem
            // 
            antiClock90ToolStripMenuItem.Name = "antiClock90ToolStripMenuItem";
            antiClock90ToolStripMenuItem.Size = new Size(175, 26);
            antiClock90ToolStripMenuItem.Text = "AntiClock 90";
            antiClock90ToolStripMenuItem.Click += antiClock90ToolStripMenuItem_Click;
            // 
            // addAndMultypToolStripMenuItem
            // 
            addAndMultypToolStripMenuItem.Name = "addAndMultypToolStripMenuItem";
            addAndMultypToolStripMenuItem.Size = new Size(210, 26);
            addAndMultypToolStripMenuItem.Text = "Sum And Multiply";
            addAndMultypToolStripMenuItem.Click += addAndMultypToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1062, 720);
            Controls.Add(hScrollBar1);
            Controls.Add(textBoxBrightness);
            Controls.Add(bightnessEnhancementButton);
            Controls.Add(textBoxHeight);
            Controls.Add(textBoxWidth);
            Controls.Add(textBoxY);
            Controls.Add(textBoxX);
            Controls.Add(ToCropImage);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Image Tool";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button ToCropImage;
        private TextBox textBoxX;
        private TextBox textBoxY;
        private TextBox textBoxWidth;
        private TextBox textBoxHeight;
        private Button bightnessEnhancementButton;
        private TextBox textBoxBrightness;
        private HScrollBar hScrollBar1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem selectImageToolStripMenuItem;
        private ToolStripMenuItem propertyToolStripMenuItem;
        private ToolStripMenuItem convertGreyToolStripMenuItem;
        private ToolStripMenuItem convertBinaryToolStripMenuItem;
        private ToolStripMenuItem edgeDetectionToolStripMenuItem;
        private ToolStripMenuItem gaussToolStripMenuItem;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private ToolStripMenuItem ınToolStripMenuItem;
        private ToolStripMenuItem outToolStripMenuItem;
        private ToolStripMenuItem rotateToolStripMenuItem;
        private ToolStripMenuItem clock90ToolStripMenuItem;
        private ToolStripMenuItem antiClock90ToolStripMenuItem;
        private ToolStripMenuItem addAndMultypToolStripMenuItem;
    }
}