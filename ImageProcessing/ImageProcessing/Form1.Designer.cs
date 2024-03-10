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
            ImageOpenerButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            textBoxRotationAngle = new TextBox();
            ToRotateButton = new Button();
            ToCropImage = new Button();
            textBoxX = new TextBox();
            textBoxY = new TextBox();
            textBoxWidth = new TextBox();
            textBoxHeight = new TextBox();
            ZoomInButton = new Button();
            ZoomOutButton = new Button();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ImageOpenerButton
            // 
            ImageOpenerButton.Location = new Point(80, 349);
            ImageOpenerButton.Name = "ImageOpenerButton";
            ImageOpenerButton.Size = new Size(161, 29);
            ImageOpenerButton.TabIndex = 0;
            ImageOpenerButton.Text = "ImageOpenerButton";
            ImageOpenerButton.UseVisualStyleBackColor = true;
            ImageOpenerButton.Click += ImageOpenerButton_Click;
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
            // 
            // textBoxRotationAngle
            // 
            textBoxRotationAngle.Location = new Point(567, 351);
            textBoxRotationAngle.Name = "textBoxRotationAngle";
            textBoxRotationAngle.Size = new Size(52, 27);
            textBoxRotationAngle.TabIndex = 5;
            // 
            // ToRotateButton
            // 
            ToRotateButton.Location = new Point(376, 349);
            ToRotateButton.Name = "ToRotateButton";
            ToRotateButton.Size = new Size(163, 29);
            ToRotateButton.TabIndex = 6;
            ToRotateButton.Text = "ToRotateButton";
            ToRotateButton.UseVisualStyleBackColor = true;
            ToRotateButton.Click += ToRotateButton_Click;
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
            // ZoomInButton
            // 
            ZoomInButton.Location = new Point(345, 546);
            ZoomInButton.Name = "ZoomInButton";
            ZoomInButton.Size = new Size(161, 29);
            ZoomInButton.TabIndex = 12;
            ZoomInButton.Text = "ZoomInButton";
            ZoomInButton.UseVisualStyleBackColor = true;
            ZoomInButton.Click += ZoomInButton_Click;
            // 
            // ZoomOutButton
            // 
            ZoomOutButton.Location = new Point(523, 546);
            ZoomOutButton.Name = "ZoomOutButton";
            ZoomOutButton.Size = new Size(161, 29);
            ZoomOutButton.TabIndex = 13;
            ZoomOutButton.Text = "ZoomOutButton";
            ZoomOutButton.UseVisualStyleBackColor = true;
            ZoomOutButton.Click += ZoomOutButton_Click;
            // 
            // bightnessEnhancementButton
            // 
            bightnessEnhancementButton.Location = new Point(345, 620);
            bightnessEnhancementButton.Name = "bightnessEnhancementButton";
            bightnessEnhancementButton.Size = new Size(260, 29);
            bightnessEnhancementButton.TabIndex = 14;
            bightnessEnhancementButton.Text = "bightnessEnhancementButton";
            bightnessEnhancementButton.UseVisualStyleBackColor = true;
            bightnessEnhancementButton.Click += bightnessEnhancementButton_Click;
            // 
            // textBoxBrightness
            // 
            textBoxBrightness.Location = new Point(611, 620);
            textBoxBrightness.Name = "textBoxBrightness";
            textBoxBrightness.Size = new Size(73, 27);
            textBoxBrightness.TabIndex = 15;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(70, 667);
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
            propertyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { convertGreyToolStripMenuItem, convertBinaryToolStripMenuItem, edgeDetectionToolStripMenuItem });
            propertyToolStripMenuItem.Name = "propertyToolStripMenuItem";
            propertyToolStripMenuItem.Size = new Size(79, 24);
            propertyToolStripMenuItem.Text = "Property";
            // 
            // convertGreyToolStripMenuItem
            // 
            convertGreyToolStripMenuItem.Name = "convertGreyToolStripMenuItem";
            convertGreyToolStripMenuItem.Size = new Size(195, 26);
            convertGreyToolStripMenuItem.Text = "Convert Grey";
            convertGreyToolStripMenuItem.Click += convertGreyToolStripMenuItem_Click;
            // 
            // convertBinaryToolStripMenuItem
            // 
            convertBinaryToolStripMenuItem.Name = "convertBinaryToolStripMenuItem";
            convertBinaryToolStripMenuItem.Size = new Size(195, 26);
            convertBinaryToolStripMenuItem.Text = "Convert Binary";
            convertBinaryToolStripMenuItem.Click += convertBinaryToolStripMenuItem_Click;
            // 
            // edgeDetectionToolStripMenuItem
            // 
            edgeDetectionToolStripMenuItem.Name = "edgeDetectionToolStripMenuItem";
            edgeDetectionToolStripMenuItem.Size = new Size(195, 26);
            edgeDetectionToolStripMenuItem.Text = "Edge Detection";
            edgeDetectionToolStripMenuItem.Click += edgeDetectionToolStripMenuItem_Click;
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
            Controls.Add(ZoomOutButton);
            Controls.Add(ZoomInButton);
            Controls.Add(textBoxHeight);
            Controls.Add(textBoxWidth);
            Controls.Add(textBoxY);
            Controls.Add(textBoxX);
            Controls.Add(ToCropImage);
            Controls.Add(ToRotateButton);
            Controls.Add(textBoxRotationAngle);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(ImageOpenerButton);
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

        private Button ImageOpenerButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textBoxRotationAngle;
        private Button ToRotateButton;
        private Button ToCropImage;
        private TextBox textBoxX;
        private TextBox textBoxY;
        private TextBox textBoxWidth;
        private TextBox textBoxHeight;
        private Button ZoomInButton;
        private Button ZoomOutButton;
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
    }
}