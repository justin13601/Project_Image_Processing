namespace ImageProcessing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRed = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbColours = new System.Windows.Forms.GroupBox();
            this.btnInvert = new System.Windows.Forms.Button();
            this.gbEffectsFilters = new System.Windows.Forms.GroupBox();
            this.btnCornerSwitch = new System.Windows.Forms.Button();
            this.btnPixelate = new System.Windows.Forms.Button();
            this.btnBlur = new System.Windows.Forms.Button();
            this.btnScroll = new System.Windows.Forms.Button();
            this.btnGrayscale = new System.Windows.Forms.Button();
            this.btnPolarize = new System.Windows.Forms.Button();
            this.btnSunset = new System.Windows.Forms.Button();
            this.btnZoom = new System.Windows.Forms.Button();
            this.btnDarken = new System.Windows.Forms.Button();
            this.btnBrightnen = new System.Windows.Forms.Button();
            this.trkContrast = new System.Windows.Forms.TrackBar();
            this.gbBrightness = new System.Windows.Forms.GroupBox();
            this.lblBrightnessValue = new System.Windows.Forms.Label();
            this.lblLowBrightness = new System.Windows.Forms.Label();
            this.lblHighBrightness = new System.Windows.Forms.Label();
            this.trkBrightness = new System.Windows.Forms.TrackBar();
            this.gbContrast = new System.Windows.Forms.GroupBox();
            this.lblContrastValue = new System.Windows.Forms.Label();
            this.lblLowContrast = new System.Windows.Forms.Label();
            this.lblHighContrast = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbFlipRotate = new System.Windows.Forms.GroupBox();
            this.btnFlipHorizontal = new System.Windows.Forms.Button();
            this.btnFlipVertical = new System.Windows.Forms.Button();
            this.btnRotate180 = new System.Windows.Forms.Button();
            this.gbChangeBrightness = new System.Windows.Forms.GroupBox();
            this.btnSortH = new System.Windows.Forms.Button();
            this.gbMisc = new System.Windows.Forms.GroupBox();
            this.btnSortV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.gbColours.SuspendLayout();
            this.gbEffectsFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkContrast)).BeginInit();
            this.gbBrightness.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBrightness)).BeginInit();
            this.gbContrast.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbFlipRotate.SuspendLayout();
            this.gbChangeBrightness.SuspendLayout();
            this.gbMisc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(27, 26);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(78, 23);
            this.btnRed.TabIndex = 2;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(12, 36);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(320, 240);
            this.picImage.TabIndex = 3;
            this.picImage.TabStop = false;
            // 
            // btnGreen
            // 
            this.btnGreen.Location = new System.Drawing.Point(27, 55);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(78, 23);
            this.btnGreen.TabIndex = 3;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Location = new System.Drawing.Point(27, 84);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(78, 23);
            this.btnBlue.TabIndex = 4;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(40, 301);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(261, 36);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset (Ctrl + R)";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gbColours
            // 
            this.gbColours.Controls.Add(this.btnRed);
            this.gbColours.Controls.Add(this.btnGreen);
            this.gbColours.Controls.Add(this.btnBlue);
            this.gbColours.Location = new System.Drawing.Point(358, 35);
            this.gbColours.Name = "gbColours";
            this.gbColours.Size = new System.Drawing.Size(131, 121);
            this.gbColours.TabIndex = 9;
            this.gbColours.TabStop = false;
            this.gbColours.Text = "Extract Colours";
            // 
            // btnInvert
            // 
            this.btnInvert.Location = new System.Drawing.Point(39, 30);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(118, 26);
            this.btnInvert.TabIndex = 10;
            this.btnInvert.Text = "Invert Colours";
            this.btnInvert.UseVisualStyleBackColor = true;
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
            // 
            // gbEffectsFilters
            // 
            this.gbEffectsFilters.Controls.Add(this.btnCornerSwitch);
            this.gbEffectsFilters.Controls.Add(this.btnPixelate);
            this.gbEffectsFilters.Controls.Add(this.btnBlur);
            this.gbEffectsFilters.Controls.Add(this.btnScroll);
            this.gbEffectsFilters.Controls.Add(this.btnGrayscale);
            this.gbEffectsFilters.Controls.Add(this.btnPolarize);
            this.gbEffectsFilters.Controls.Add(this.btnSunset);
            this.gbEffectsFilters.Controls.Add(this.btnInvert);
            this.gbEffectsFilters.Location = new System.Drawing.Point(358, 162);
            this.gbEffectsFilters.Name = "gbEffectsFilters";
            this.gbEffectsFilters.Size = new System.Drawing.Size(663, 113);
            this.gbEffectsFilters.TabIndex = 11;
            this.gbEffectsFilters.TabStop = false;
            this.gbEffectsFilters.Text = "Effects and Filters";
            // 
            // btnCornerSwitch
            // 
            this.btnCornerSwitch.Location = new System.Drawing.Point(504, 30);
            this.btnCornerSwitch.Name = "btnCornerSwitch";
            this.btnCornerSwitch.Size = new System.Drawing.Size(121, 26);
            this.btnCornerSwitch.TabIndex = 16;
            this.btnCornerSwitch.Text = "Corner Switch";
            this.btnCornerSwitch.UseVisualStyleBackColor = true;
            this.btnCornerSwitch.Click += new System.EventHandler(this.btnCornerSwitch_Click);
            // 
            // btnPixelate
            // 
            this.btnPixelate.Location = new System.Drawing.Point(348, 30);
            this.btnPixelate.Name = "btnPixelate";
            this.btnPixelate.Size = new System.Drawing.Size(118, 26);
            this.btnPixelate.TabIndex = 14;
            this.btnPixelate.Text = "Pixelate";
            this.btnPixelate.UseVisualStyleBackColor = true;
            this.btnPixelate.Click += new System.EventHandler(this.btnPixelate_Click);
            // 
            // btnBlur
            // 
            this.btnBlur.Location = new System.Drawing.Point(348, 70);
            this.btnBlur.Name = "btnBlur";
            this.btnBlur.Size = new System.Drawing.Size(118, 26);
            this.btnBlur.TabIndex = 15;
            this.btnBlur.Text = "Blur";
            this.btnBlur.UseVisualStyleBackColor = true;
            this.btnBlur.Click += new System.EventHandler(this.btnBlur_Click);
            // 
            // btnScroll
            // 
            this.btnScroll.Location = new System.Drawing.Point(504, 70);
            this.btnScroll.Name = "btnScroll";
            this.btnScroll.Size = new System.Drawing.Size(121, 26);
            this.btnScroll.TabIndex = 19;
            this.btnScroll.Text = "Scroll Image";
            this.btnScroll.UseVisualStyleBackColor = true;
            this.btnScroll.Click += new System.EventHandler(this.btnScroll_Click);
            // 
            // btnGrayscale
            // 
            this.btnGrayscale.Location = new System.Drawing.Point(39, 70);
            this.btnGrayscale.Name = "btnGrayscale";
            this.btnGrayscale.Size = new System.Drawing.Size(118, 26);
            this.btnGrayscale.TabIndex = 13;
            this.btnGrayscale.Text = "Grayscale Filter";
            this.btnGrayscale.UseVisualStyleBackColor = true;
            this.btnGrayscale.Click += new System.EventHandler(this.btnGrayscale_Click);
            // 
            // btnPolarize
            // 
            this.btnPolarize.Location = new System.Drawing.Point(193, 30);
            this.btnPolarize.Name = "btnPolarize";
            this.btnPolarize.Size = new System.Drawing.Size(118, 26);
            this.btnPolarize.TabIndex = 12;
            this.btnPolarize.Text = "Polarize";
            this.btnPolarize.UseVisualStyleBackColor = true;
            this.btnPolarize.Click += new System.EventHandler(this.btnPolarize_Click);
            // 
            // btnSunset
            // 
            this.btnSunset.Location = new System.Drawing.Point(193, 70);
            this.btnSunset.Name = "btnSunset";
            this.btnSunset.Size = new System.Drawing.Size(118, 26);
            this.btnSunset.TabIndex = 11;
            this.btnSunset.Text = "Sunset Effect";
            this.btnSunset.UseVisualStyleBackColor = true;
            this.btnSunset.Click += new System.EventHandler(this.btnSunset_Click);
            // 
            // btnZoom
            // 
            this.btnZoom.Location = new System.Drawing.Point(25, 83);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(118, 24);
            this.btnZoom.TabIndex = 20;
            this.btnZoom.Text = "Zoom";
            this.btnZoom.UseVisualStyleBackColor = true;
            this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // btnDarken
            // 
            this.btnDarken.Location = new System.Drawing.Point(22, 75);
            this.btnDarken.Name = "btnDarken";
            this.btnDarken.Size = new System.Drawing.Size(90, 26);
            this.btnDarken.TabIndex = 17;
            this.btnDarken.Text = "Darken";
            this.btnDarken.UseVisualStyleBackColor = true;
            this.btnDarken.Click += new System.EventHandler(this.btnDarken_Click);
            // 
            // btnBrightnen
            // 
            this.btnBrightnen.Location = new System.Drawing.Point(22, 35);
            this.btnBrightnen.Name = "btnBrightnen";
            this.btnBrightnen.Size = new System.Drawing.Size(90, 26);
            this.btnBrightnen.TabIndex = 16;
            this.btnBrightnen.Text = "Lighten";
            this.btnBrightnen.UseVisualStyleBackColor = true;
            this.btnBrightnen.Click += new System.EventHandler(this.btnBrightnen_Click);
            // 
            // trkContrast
            // 
            this.trkContrast.LargeChange = 10;
            this.trkContrast.Location = new System.Drawing.Point(51, 26);
            this.trkContrast.Maximum = 200;
            this.trkContrast.Minimum = -100;
            this.trkContrast.Name = "trkContrast";
            this.trkContrast.Size = new System.Drawing.Size(222, 45);
            this.trkContrast.TabIndex = 1;
            this.trkContrast.TickFrequency = 20;
            this.trkContrast.Value = 100;
            this.trkContrast.Scroll += new System.EventHandler(this.trackbars_Scroll);
            // 
            // gbBrightness
            // 
            this.gbBrightness.Controls.Add(this.lblBrightnessValue);
            this.gbBrightness.Controls.Add(this.lblLowBrightness);
            this.gbBrightness.Controls.Add(this.lblHighBrightness);
            this.gbBrightness.Controls.Add(this.trkBrightness);
            this.gbBrightness.Location = new System.Drawing.Point(358, 281);
            this.gbBrightness.Name = "gbBrightness";
            this.gbBrightness.Size = new System.Drawing.Size(330, 74);
            this.gbBrightness.TabIndex = 12;
            this.gbBrightness.TabStop = false;
            this.gbBrightness.Text = "Adjust Brightness";
            // 
            // lblBrightnessValue
            // 
            this.lblBrightnessValue.AutoSize = true;
            this.lblBrightnessValue.BackColor = System.Drawing.Color.Transparent;
            this.lblBrightnessValue.Location = new System.Drawing.Point(158, 56);
            this.lblBrightnessValue.Name = "lblBrightnessValue";
            this.lblBrightnessValue.Size = new System.Drawing.Size(13, 13);
            this.lblBrightnessValue.TabIndex = 5;
            this.lblBrightnessValue.Text = "0";
            // 
            // lblLowBrightness
            // 
            this.lblLowBrightness.AutoSize = true;
            this.lblLowBrightness.Location = new System.Drawing.Point(18, 30);
            this.lblLowBrightness.Name = "lblLowBrightness";
            this.lblLowBrightness.Size = new System.Drawing.Size(31, 13);
            this.lblLowBrightness.TabIndex = 4;
            this.lblLowBrightness.Text = "-1.00";
            // 
            // lblHighBrightness
            // 
            this.lblHighBrightness.AutoSize = true;
            this.lblHighBrightness.Location = new System.Drawing.Point(282, 30);
            this.lblHighBrightness.Name = "lblHighBrightness";
            this.lblHighBrightness.Size = new System.Drawing.Size(34, 13);
            this.lblHighBrightness.TabIndex = 3;
            this.lblHighBrightness.Text = "+1.00";
            // 
            // trkBrightness
            // 
            this.trkBrightness.LargeChange = 10;
            this.trkBrightness.Location = new System.Drawing.Point(54, 26);
            this.trkBrightness.Maximum = 100;
            this.trkBrightness.Minimum = -100;
            this.trkBrightness.Name = "trkBrightness";
            this.trkBrightness.Size = new System.Drawing.Size(222, 45);
            this.trkBrightness.TabIndex = 0;
            this.trkBrightness.TickFrequency = 10;
            this.trkBrightness.Scroll += new System.EventHandler(this.trackbars_Scroll);
            // 
            // gbContrast
            // 
            this.gbContrast.Controls.Add(this.lblContrastValue);
            this.gbContrast.Controls.Add(this.lblLowContrast);
            this.gbContrast.Controls.Add(this.lblHighContrast);
            this.gbContrast.Controls.Add(this.trkContrast);
            this.gbContrast.Location = new System.Drawing.Point(694, 281);
            this.gbContrast.Name = "gbContrast";
            this.gbContrast.Size = new System.Drawing.Size(327, 74);
            this.gbContrast.TabIndex = 13;
            this.gbContrast.TabStop = false;
            this.gbContrast.Text = "Adjust Contrast";
            // 
            // lblContrastValue
            // 
            this.lblContrastValue.AutoSize = true;
            this.lblContrastValue.BackColor = System.Drawing.Color.Transparent;
            this.lblContrastValue.Location = new System.Drawing.Point(155, 56);
            this.lblContrastValue.Name = "lblContrastValue";
            this.lblContrastValue.Size = new System.Drawing.Size(13, 13);
            this.lblContrastValue.TabIndex = 6;
            this.lblContrastValue.Text = "1";
            // 
            // lblLowContrast
            // 
            this.lblLowContrast.AutoSize = true;
            this.lblLowContrast.Location = new System.Drawing.Point(16, 29);
            this.lblLowContrast.Name = "lblLowContrast";
            this.lblLowContrast.Size = new System.Drawing.Size(31, 13);
            this.lblLowContrast.TabIndex = 2;
            this.lblLowContrast.Text = "-1.00";
            // 
            // lblHighContrast
            // 
            this.lblHighContrast.AutoSize = true;
            this.lblHighContrast.Location = new System.Drawing.Point(276, 29);
            this.lblHighContrast.Name = "lblHighContrast";
            this.lblHighContrast.Size = new System.Drawing.Size(34, 13);
            this.lblHighContrast.TabIndex = 1;
            this.lblHighContrast.Text = "+2.00";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.newToolStripMenuItem.Text = "New           (Ctrl + N)";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.openToolStripMenuItem.Text = "Open         (Ctrl + O)";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...   (Ctrl + S)";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // gbFlipRotate
            // 
            this.gbFlipRotate.Controls.Add(this.btnFlipHorizontal);
            this.gbFlipRotate.Controls.Add(this.btnFlipVertical);
            this.gbFlipRotate.Controls.Add(this.btnRotate180);
            this.gbFlipRotate.Location = new System.Drawing.Point(662, 35);
            this.gbFlipRotate.Name = "gbFlipRotate";
            this.gbFlipRotate.Size = new System.Drawing.Size(172, 121);
            this.gbFlipRotate.TabIndex = 10;
            this.gbFlipRotate.TabStop = false;
            this.gbFlipRotate.Text = "Flip/Rotate";
            // 
            // btnFlipHorizontal
            // 
            this.btnFlipHorizontal.Location = new System.Drawing.Point(27, 26);
            this.btnFlipHorizontal.Name = "btnFlipHorizontal";
            this.btnFlipHorizontal.Size = new System.Drawing.Size(119, 23);
            this.btnFlipHorizontal.TabIndex = 2;
            this.btnFlipHorizontal.Text = "Flip Horizontally";
            this.btnFlipHorizontal.UseVisualStyleBackColor = true;
            this.btnFlipHorizontal.Click += new System.EventHandler(this.btnFlipHorizontal_Click);
            // 
            // btnFlipVertical
            // 
            this.btnFlipVertical.Location = new System.Drawing.Point(27, 55);
            this.btnFlipVertical.Name = "btnFlipVertical";
            this.btnFlipVertical.Size = new System.Drawing.Size(119, 23);
            this.btnFlipVertical.TabIndex = 3;
            this.btnFlipVertical.Text = "Flip Vertically";
            this.btnFlipVertical.UseVisualStyleBackColor = true;
            this.btnFlipVertical.Click += new System.EventHandler(this.btnFlipVertical_Click);
            // 
            // btnRotate180
            // 
            this.btnRotate180.Location = new System.Drawing.Point(27, 84);
            this.btnRotate180.Name = "btnRotate180";
            this.btnRotate180.Size = new System.Drawing.Size(119, 23);
            this.btnRotate180.TabIndex = 4;
            this.btnRotate180.Text = "Rotate 180°";
            this.btnRotate180.UseVisualStyleBackColor = true;
            this.btnRotate180.Click += new System.EventHandler(this.btnRotate180_Click);
            // 
            // gbChangeBrightness
            // 
            this.gbChangeBrightness.Controls.Add(this.btnDarken);
            this.gbChangeBrightness.Controls.Add(this.btnBrightnen);
            this.gbChangeBrightness.Location = new System.Drawing.Point(508, 35);
            this.gbChangeBrightness.Name = "gbChangeBrightness";
            this.gbChangeBrightness.Size = new System.Drawing.Size(135, 121);
            this.gbChangeBrightness.TabIndex = 15;
            this.gbChangeBrightness.TabStop = false;
            this.gbChangeBrightness.Text = "Change Brightness";
            // 
            // btnSortH
            // 
            this.btnSortH.Location = new System.Drawing.Point(25, 25);
            this.btnSortH.Name = "btnSortH";
            this.btnSortH.Size = new System.Drawing.Size(118, 23);
            this.btnSortH.TabIndex = 18;
            this.btnSortH.Text = "Sort Horizontally";
            this.btnSortH.UseVisualStyleBackColor = true;
            this.btnSortH.Click += new System.EventHandler(this.btnSortH_Click);
            // 
            // gbMisc
            // 
            this.gbMisc.Controls.Add(this.btnZoom);
            this.gbMisc.Controls.Add(this.btnSortV);
            this.gbMisc.Controls.Add(this.btnSortH);
            this.gbMisc.Location = new System.Drawing.Point(853, 35);
            this.gbMisc.Name = "gbMisc";
            this.gbMisc.Size = new System.Drawing.Size(168, 121);
            this.gbMisc.TabIndex = 11;
            this.gbMisc.TabStop = false;
            this.gbMisc.Text = "Misc.";
            // 
            // btnSortV
            // 
            this.btnSortV.Location = new System.Drawing.Point(25, 54);
            this.btnSortV.Name = "btnSortV";
            this.btnSortV.Size = new System.Drawing.Size(118, 23);
            this.btnSortV.TabIndex = 19;
            this.btnSortV.Text = "Sort Vertically";
            this.btnSortV.UseVisualStyleBackColor = true;
            this.btnSortV.Click += new System.EventHandler(this.btnSortV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 367);
            this.Controls.Add(this.gbMisc);
            this.Controls.Add(this.gbChangeBrightness);
            this.Controls.Add(this.gbFlipRotate);
            this.Controls.Add(this.gbContrast);
            this.Controls.Add(this.gbBrightness);
            this.Controls.Add(this.gbEffectsFilters);
            this.Controls.Add(this.gbColours);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.gbColours.ResumeLayout(false);
            this.gbEffectsFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trkContrast)).EndInit();
            this.gbBrightness.ResumeLayout(false);
            this.gbBrightness.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBrightness)).EndInit();
            this.gbContrast.ResumeLayout(false);
            this.gbContrast.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbFlipRotate.ResumeLayout(false);
            this.gbChangeBrightness.ResumeLayout(false);
            this.gbMisc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbColours;
        private System.Windows.Forms.Button btnInvert;
        private System.Windows.Forms.GroupBox gbEffectsFilters;
        private System.Windows.Forms.GroupBox gbBrightness;
        private System.Windows.Forms.TrackBar trkBrightness;
        private System.Windows.Forms.TrackBar trkContrast;
        private System.Windows.Forms.GroupBox gbContrast;
        private System.Windows.Forms.Label lblLowContrast;
        private System.Windows.Forms.Label lblHighContrast;
        private System.Windows.Forms.Label lblLowBrightness;
        private System.Windows.Forms.Label lblHighBrightness;
        private System.Windows.Forms.Label lblBrightnessValue;
        private System.Windows.Forms.Label lblContrastValue;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Button btnSunset;
        private System.Windows.Forms.Button btnPolarize;
        private System.Windows.Forms.Button btnGrayscale;
        private System.Windows.Forms.GroupBox gbFlipRotate;
        private System.Windows.Forms.Button btnFlipHorizontal;
        private System.Windows.Forms.Button btnFlipVertical;
        private System.Windows.Forms.Button btnRotate180;
        private System.Windows.Forms.Button btnBlur;
        private System.Windows.Forms.Button btnPixelate;
        private System.Windows.Forms.Button btnDarken;
        private System.Windows.Forms.Button btnBrightnen;
        private System.Windows.Forms.GroupBox gbChangeBrightness;
        private System.Windows.Forms.Button btnCornerSwitch;
        private System.Windows.Forms.Button btnSortH;
        private System.Windows.Forms.Button btnScroll;
        private System.Windows.Forms.GroupBox gbMisc;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Button btnSortV;
        private System.Windows.Forms.Button btnZoom;
    }
}

