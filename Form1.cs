using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Disables buttons/trackbars accordingly
            newToolStripMenuItem.Enabled = false;

            btnReset.Enabled = false;

            btnRed.Enabled = false;
            btnGreen.Enabled = false;
            btnBlue.Enabled = false;

            btnInvert.Enabled = false;

            trkBrightness.Enabled = false;
            trkContrast.Enabled = false;

            btnBrightnen.Enabled = false;
            btnDarken.Enabled = false;
            btnSunset.Enabled = false;
            btnPolarize.Enabled = false;
            btnGrayscale.Enabled = false;
            btnBlur.Enabled = false;
            btnPixelate.Enabled = false;
            btnCornerSwitch.Enabled = false;
            btnSortH.Enabled = false;
            btnSortV.Enabled = false;
            btnScroll.Enabled = false;

            btnFlipHorizontal.Enabled = false;
            btnFlipVertical.Enabled = false;
            btnRotate180.Enabled = false;

            btnZoom.Enabled = false;
        }

        //Declares ImageArray
        Bitmap bitmapImage, bitmapOriginal;
        Color[,] ImageArray = new Color[320, 240];


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Stream myStream = null;
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                //openFileDialog1.InitialDirectory = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyPictures);
                openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;
                openFileDialog1.Title = "Image Browser";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        Image newImage = Image.FromStream(myStream);
                        bitmapImage = new Bitmap(newImage, 320, 240);
                        picImage.Image = bitmapImage;
                        myStream.Close();
                    }
                }
                else
                {
                    return;
                }

                //Declares bitmapOriginal for reset
                bitmapOriginal = new Bitmap(picImage.Image);
                SetArrayFromBitmap();

                //Enables/Disables buttons accordingly
                openToolStripMenuItem.Enabled = false;
                newToolStripMenuItem.Enabled = true;

                btnReset.Enabled = false;

                btnRed.Enabled = true;
                btnGreen.Enabled = true;
                btnBlue.Enabled = true;

                btnInvert.Enabled = true;

                btnBrightnen.Enabled = true;
                btnDarken.Enabled = true;
                btnSunset.Enabled = true;
                btnPolarize.Enabled = true;
                btnGrayscale.Enabled = true;
                btnBlur.Enabled = true;
                btnPixelate.Enabled = true;
                btnCornerSwitch.Enabled = true;
                btnSortH.Enabled = true;
                btnSortV.Enabled = true;
                btnScroll.Enabled = true;

                btnFlipHorizontal.Enabled = true;
                btnFlipVertical.Enabled = true;
                btnRotate180.Enabled = true;

                btnZoom.Enabled = true;

                //Resets trackbar values
                trkBrightness.Enabled = true;
                trkBrightness.Value = 0;

                trkContrast.Enabled = true;
                trkContrast.Value = 100;
            }
            catch
            {
                MessageBox.Show("Please select a valid image file.");
            }
        }

        //Sets bitmap from ImageArray
        private void SetBitmapFromArray()
        {
            for (int row = 0; row < 320; row++)
                for (int col = 0; col < 240; col++)
                {
                    bitmapImage.SetPixel(row, col, ImageArray[row, col]);
                }
        }

        //Sets ImageArray from bitmapImage
        private void SetArrayFromBitmap()
        {
            bitmapImage = new Bitmap(picImage.Image);
            for (int row = 0; row < 320; row++)
                for (int col = 0; col < 240; col++)
                {
                    ImageArray[row, col] = bitmapImage.GetPixel(row, col);
                }
        }

        //Sets ImageArray from bitmapOriginal used for reset
        private void ResetArrayFromOriginalBitmap()
        {
            for (int row = 0; row < 320; row++)
                for (int col = 0; col < 240; col++)
                {
                    ImageArray[row, col] = bitmapOriginal.GetPixel(row, col);
                }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Resets canvas and ImageArray
            picImage.Image = bitmapOriginal;
            ResetArrayFromOriginalBitmap();
            SetBitmapFromArray();

            //Disables buttons accordingly
            btnReset.Enabled = false;

            btnRed.Enabled = true;
            btnGreen.Enabled = true;
            btnBlue.Enabled = true;

            btnInvert.Enabled = true;
            btnBrightnen.Enabled = true;
            btnDarken.Enabled = true;
            btnSunset.Enabled = true;
            btnPolarize.Enabled = true;
            btnGrayscale.Enabled = true;
            btnBlur.Enabled = true;
            btnPixelate.Enabled = true;
            btnCornerSwitch.Enabled = true;
            btnSortH.Enabled = true;
            btnSortV.Enabled = true;
            btnScroll.Enabled = true;

            btnFlipHorizontal.Enabled = true;
            btnFlipVertical.Enabled = true;
            btnRotate180.Enabled = true;

            btnZoom.Enabled = true;

            //Resets trackbar values
            trkBrightness.Enabled = true;
            trkBrightness.Value = 0;

            trkContrast.Enabled = true;
            trkContrast.Value = 100;

            lblBrightnessValue.Text = (trkBrightness.Value * 0.01).ToString();
            lblContrastValue.Text = (trkContrast.Value * 0.01).ToString();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to start a new project? Your changes will not be saved.", "New Project", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Resets canvas
                picImage.Image = null;

                //Disables buttons accordingly
                openToolStripMenuItem.Enabled = true;
                newToolStripMenuItem.Enabled = false;

                btnReset.Enabled = false;

                btnRed.Enabled = false;
                btnBlue.Enabled = false;
                btnGreen.Enabled = false;

                trkContrast.Enabled = false;
                trkBrightness.Enabled = false;

                btnBrightnen.Enabled = false;
                btnDarken.Enabled = false;
                btnInvert.Enabled = false;
                btnSunset.Enabled = false;
                btnPolarize.Enabled = false;
                btnGrayscale.Enabled = false;
                btnBlur.Enabled = false;
                btnPixelate.Enabled = false;
                btnCornerSwitch.Enabled = false;
                btnSortH.Enabled = false;
                btnSortV.Enabled = false;
                btnScroll.Enabled = false;

                btnFlipHorizontal.Enabled = false;
                btnFlipVertical.Enabled = false;
                btnRotate180.Enabled = false;

                btnZoom.Enabled = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();           //Declares a new savefile dialog
            saveFileDialog.Title = "Save As New Image";                     //Sets the title of the dialog
            saveFileDialog.FileName = "Untitled";                           //Default file name if user chooses not to insert a new name
            saveFileDialog.Filter = "PNG|*.png|JPEG Image|*.jpg|GIF Image|*.gif|Bitmap Image|*.bmp|All files (*.*)|*.*";            //Limits selection of file types

            if (saveFileDialog.ShowDialog() == DialogResult.OK)             //If user clicks 'save'
            {
                int width = Convert.ToInt32(picImage.Width);
                int height = Convert.ToInt32(picImage.Height);
                Bitmap bmp = new Bitmap(width, height);
                picImage.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                bmp.Save(saveFileDialog.FileName, ImageFormat.Jpeg);

                MessageBox.Show("Image successfully saved to " + "'" + saveFileDialog.FileName + "'.");
            }
            else
            {
                return;
            }
        }

        //Shortcuts for ease of access
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                saveAsToolStripMenuItem.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.N))
            {
                newToolStripMenuItem.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.O))
            {
                openToolStripMenuItem.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.R))
            {
                btnReset.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            SetArrayFromBitmap();

            Byte Red;

            int iWidth = 320;
            int iHeight = 240;

            //Extracts Red channel from each pixel
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color pixel = ImageArray[i, j];

                    Red = pixel.R;

                    Color newColor = Color.FromArgb(255, Red, 0, 0);
                    ImageArray[i, j] = newColor;

                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;

            btnReset.Enabled = true;

            btnGreen.Enabled = false;
            btnBlue.Enabled = false;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            SetArrayFromBitmap();

            Byte Green;

            int iWidth = 320;
            int iHeight = 240;

            //Extracts Green channel from each pixel
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color pixel = ImageArray[i, j];

                    Green = pixel.G;

                    Color newColor = Color.FromArgb(255, 0, Green, 0);
                    ImageArray[i, j] = newColor;

                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;

            btnReset.Enabled = true;

            btnRed.Enabled = false;
            btnBlue.Enabled = false;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            SetArrayFromBitmap();

            Byte Blue;

            int iWidth = 320;
            int iHeight = 240;

            //Extracts Blue channel from each pixel
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color pixel = ImageArray[i, j];

                    Blue = pixel.B;

                    Color newColor = Color.FromArgb(255, 0, 0, Blue);
                    ImageArray[i, j] = newColor;

                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;

            btnReset.Enabled = true;

            btnRed.Enabled = false;
            btnGreen.Enabled = false;
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            SetArrayFromBitmap();

            Byte Red, Green, Blue;

            int iWidth = 320;
            int iHeight = 240;

            //Finds the inverted RGB values for each pixel
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color pixel = ImageArray[i, j];

                    Red = pixel.R;

                    Green = pixel.G;

                    Blue = pixel.B;

                    Color newColor = Color.FromArgb(255, 255 - Red, 255 - Green, 255 - Blue);
                    ImageArray[i, j] = newColor;

                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;

            btnReset.Enabled = true;
        }

        //Assigned both trackbars to this event
        private void trackbars_Scroll(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            //Calls method when either trackbar control is scrolled
            picImage.Image = AdjustBrightnessContrast(bitmapImage, trkContrast.Value, trkBrightness.Value);

            btnReset.Enabled = true;

            //Shows Brightness and Contrast values
            lblBrightnessValue.Text = (trkBrightness.Value * 0.01).ToString();
            lblContrastValue.Text = (trkContrast.Value * 0.01).ToString();
        }

        //Method that adjusts Brightness and Contrast values
        public Bitmap AdjustBrightnessContrast(Image image, int contrastValue, int brightnessValue)
        {
            //Converts  int values of the trackbars to floats in the respective ranges and assigns then to the Matrix array
            float brightness = (brightnessValue / 100.0f);
            float contrast = (contrastValue / 100.0f);

            //ColorMatrix is assigned to ImageAttribute class
            using (Bitmap bitmap = new Bitmap(image.Width, image.Height))
            using (Graphics g = Graphics.FromImage(bitmap))
            using (ImageAttributes attributes = new ImageAttributes())
            {
                //Contrast = 1; Brightness = 0
                float[][] matrix = { new float[] { contrast, 0, 0, 0, 0 }, new float[] { 0, contrast, 0, 0, 0 }, new float[] { 0, 0, contrast, 0, 0 }, new float[] { 0, 0, 0, 1, 0 }, new float[] { brightness, brightness, brightness, 1, 1 } };

                Color color = Color.Orange;
                ColorMatrix colorMatrix = new ColorMatrix(matrix);
                attributes.SetColorMatrix(colorMatrix);
                g.DrawImage(image, new Rectangle(0, 0, bitmap.Width, bitmap.Height), 0, 0, bitmap.Width, bitmap.Height, GraphicsUnit.Pixel, attributes);
                return (Bitmap)bitmap.Clone();
            }
        }

        private void btnSunset_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            SetArrayFromBitmap();

            int Red, Green, Blue;

            int iWidth = 320;
            int iHeight = 240;

            //Applies a sunset filter by increasing red and decreasing blue values 
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color pixel = ImageArray[i, j];

                    Red = pixel.R + 20;

                    Green = pixel.G;

                    Blue = pixel.B - 20;

                    if (Red > 255)
                    {
                        Red = 255;
                    }
                    if (Blue < 0)
                    {
                        Blue = 0;
                    }

                    Color newColor = Color.FromArgb(255, Red, Green, Blue);
                    ImageArray[i, j] = newColor;

                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;

            btnReset.Enabled = true;
        }

        private void btnPolarize_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            SetArrayFromBitmap();

            Byte Red, Green, Blue;
            int RAverage, GAverage, BAverage;

            RAverage = 0;
            GAverage = 0;
            BAverage = 0;

            int iWidth = 320;
            int iHeight = 240;

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color pixel = ImageArray[i, j];

                    Red = pixel.R;

                    Green = pixel.G;

                    Blue = pixel.B;

                    //Adds RGB values of all the pixels
                    RAverage = Convert.ToInt32(Red) + RAverage;
                    GAverage = Convert.ToInt32(Green) + GAverage;
                    BAverage = Convert.ToInt32(Blue) + BAverage;

                }
            }

            //Finds average of the RGB values of all the pixels
            RAverage = RAverage / 76800;
            GAverage = GAverage / 76800;
            BAverage = BAverage / 76800;

            //Polarizes image by setting each pixel's RGB values to its extremes based on the RGB averages
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color pixel = ImageArray[i, j];

                    Red = pixel.R;

                    Green = pixel.G;

                    Blue = pixel.B;

                    //If Red value exceed Red Average, sets Red value to 255, otherwise sets it to 0
                    if (Red >= RAverage)
                    {
                        Red = 255;
                    }
                    else
                    {
                        Red = 0;
                    }

                    //If Green value exceed Green Average, sets Green value to 255, otherwise sets it to 0
                    if (Green >= GAverage)
                    {
                        Green = 255;
                    }
                    else
                    {
                        Green = 0;
                    }

                    //If Blue value exceed Blue Average, sets Blue value to 255, otherwise sets it to 0
                    if (Blue >= BAverage)
                    {
                        Blue = 255;
                    }
                    else
                    {
                        Blue = 0;
                    }

                    Color newColor = Color.FromArgb(255, Red, Green, Blue);
                    ImageArray[i, j] = newColor;

                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;

            btnReset.Enabled = true;
        }

        //Method that converts image to grayscale
        public void Grayscale()
        {

            Byte Red, Green, Blue, Gray;

            int iWidth = 320;
            int iHeight = 240;

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color pixel = ImageArray[i, j];

                    Red = pixel.R;

                    Green = pixel.G;

                    Blue = pixel.B;

                    //Find average between RGB of each pixel
                    Gray = Convert.ToByte(Convert.ToInt32(Red + Blue + Green) / 3);

                    Color newColor = Color.FromArgb(255, Gray, Gray, Gray);
                    ImageArray[i, j] = newColor;
                }
            }

        }

        private void btnGrayscale_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            SetArrayFromBitmap();

            //Calls method to turn image into grayscale
            Grayscale();

            SetBitmapFromArray();
            picImage.Image = bitmapImage;

            btnReset.Enabled = true;
        }

        private void btnFlipHorizontal_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            SetArrayFromBitmap();

            int iWidth = 320;
            int iHeight = 240;

            //Horizontally flips image by switching half of the pixels with their respective counterpart pixel
            for (int i = 0; i < iWidth / 2; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color temp = ImageArray[i, j];

                    ImageArray[i, j] = ImageArray[319 - i, j];
                    ImageArray[319 - i, j] = temp;

                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;

            btnReset.Enabled = true;
        }

        private void btnFlipVertical_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            SetArrayFromBitmap();

            int iWidth = 320;
            int iHeight = 240;

            //Vertically flips image by switching half of the pixels with their respective counterpart pixel
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight / 2; j++)
                {
                    Color temp = ImageArray[i, j];

                    ImageArray[i, j] = ImageArray[i, 239 - j];
                    ImageArray[i, 239 - j] = temp;

                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;

            btnReset.Enabled = true;
        }

        //Rotates image by 180 degrees by flipping it horizontally then vertically
        private void btnRotate180_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            SetArrayFromBitmap();

            int iWidth = 320;
            int iHeight = 240;

            //Horizontally flips image by switching half of the pixels with their respective counterpart pixel
            for (int i = 0; i < iWidth / 2; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color temp = ImageArray[i, j];

                    ImageArray[i, j] = ImageArray[319 - i, j];
                    ImageArray[319 - i, j] = temp;

                }
            }

            //Vertically flips image by switching half of the pixels with their respective counterpart pixel
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight / 2; j++)
                {
                    Color temp = ImageArray[i, j];

                    ImageArray[i, j] = ImageArray[i, 239 - j];
                    ImageArray[i, 239 - j] = temp;

                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;

            btnReset.Enabled = true;
        }

        private void btnBrightnen_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            SetArrayFromBitmap();

            int Red, Green, Blue;

            int iWidth = 320;
            int iHeight = 240;

            //Brightens image by increasing the RGB values by 20 each
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color pixel = ImageArray[i, j];

                    Red = pixel.R + 20;

                    Green = pixel.G + 20;

                    Blue = pixel.B + 20;

                    //Limiting conditions if pixel RGB values exceeds a byte boundary
                    if (Red > 255)
                    {
                        Red = 255;
                    }
                    if (Green > 255)
                    {
                        Green = 255;
                    }
                    if (Blue > 255)
                    {
                        Blue = 255;
                    }

                    Color newColor = Color.FromArgb(255, Red, Green, Blue);
                    ImageArray[i, j] = newColor;

                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;

            btnReset.Enabled = true;
        }

        private void btnDarken_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            SetArrayFromBitmap();

            int Red, Green, Blue;

            int iWidth = 320;
            int iHeight = 240;

            //Darkens image by decreasing the RGB values by 20 each
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color pixel = ImageArray[i, j];

                    Red = pixel.R - 20;

                    Green = pixel.G - 20;

                    Blue = pixel.B - 20;

                    //Limiting conditions if pixel RGB values exceeds a byte boundary
                    if (Red < 0)
                    {
                        Red = 0;
                    }
                    if (Green < 0)
                    {
                        Green = 0;
                    }
                    if (Blue < 0)
                    {
                        Blue = 0;
                    }

                    Color newColor = Color.FromArgb(255, Red, Green, Blue);
                    ImageArray[i, j] = newColor;

                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;

            btnReset.Enabled = true;
        }

        private void btnPixelate_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            SetArrayFromBitmap();

            int iWidth = 320;
            int iHeight = 240;

            //Pixelates image by finding the RGB values for every 8x8 pixel block
            for (int i = 0; i < iWidth; i = i + 8)
            {
                for (int j = 0; j < iHeight; j = j + 8)
                {
                    Color pixel = ImageArray[i, j];

                    //Sets each 8x8 pixel block to the RGB values of its corner
                    for (int k = i; k < i + 8; k++)
                    {
                        for (int l = j; l < j + 8; l++)
                        {
                            ImageArray[k, l] = pixel;
                        }
                    }
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;

            btnReset.Enabled = true;
        }

        private void btnCornerSwitch_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            SetArrayFromBitmap();

            int iWidth = 320;
            int iHeight = 240;

            //Switches top left and bottom right corners by switching each pixel
            for (int i = 0; i < iWidth / 2; i++)
            {
                for (int j = 0; j < iHeight / 2; j++)
                {
                    //Stores top left corner pixels in a temp Color
                    Color temp = ImageArray[i, j];

                    //Replaces top left corner pixels with bottom right pixels
                    ImageArray[i, j] = ImageArray[i + (iWidth - (iWidth / 2)), j + (iHeight - (iHeight / 2))];

                    //Replaces bottom right corner pixels with top left corner pixels stored in the temp Color
                    ImageArray[i + (iWidth - (iWidth / 2)), j + (iHeight - (iHeight / 2))] = temp;
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;

            btnReset.Enabled = true;
        }

        private void btnSortH_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            SetArrayFromBitmap();

            int iWidth = 320;
            int iHeight = 240;

            //Converts image to grayscale
            Grayscale();

            //Repeats the process for every row of the image
            for (int i = 0; i < iHeight; i++)
            {
                //Sorts the pixel of each row based on its averaged RGB values
                for (int j = 1; j < iWidth; j++)
                {
                    Color pixel = ImageArray[j, i];
                    int k = j - 1;

                    while (k >= 0)
                    {
                        if (ImageArray[k, i].R > pixel.R)
                        {
                            ImageArray[k + 1, i] = ImageArray[k, i];
                        }
                        else
                        {
                            break;
                        }
                        k = k - 1;
                    }
                    ImageArray[k + 1, i] = pixel;
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;

            btnReset.Enabled = true;
        }

        private void btnScroll_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            SetArrayFromBitmap();

            int iWidth = 320;
            int iHeight = 240;

            //Declares temporary array for the image
            Color[,] TempArray = new Color[320, 240];

            //Sets temporary array with the pixel RGB values of the image
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    TempArray[i, j] = ImageArray[i, j];
                }
            }

            //Scrolls image up by 30 pixels
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    if (j + 30 <= 239)
                    {
                        ImageArray[i, j] = TempArray[i, j + 30];
                    }
                    else
                    {
                        ImageArray[i, j] = TempArray[i, j - 210];
                    }
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;

            btnReset.Enabled = true;

        }

        private void btnSortV_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            SetArrayFromBitmap();

            int iWidth = 320;
            int iHeight = 240;

            //Converts image to grayscale
            Grayscale();

            //Repeats the process for every coloumn of the image
            for (int i = 0; i < iWidth; i++)
            {
                //Sorts the pixel of each row based on its averaged RGB values
                for (int j = 1; j < iHeight; j++)
                {
                    Color pixel = ImageArray[i, j];
                    int k = j - 1;

                    while (k >= 0)
                    {
                        if (ImageArray[i, k].R > pixel.R)
                        {
                            ImageArray[i, k + 1] = ImageArray[i, k];
                        }
                        else
                        {
                            break;
                        }
                        k = k - 1;
                    }
                    ImageArray[i, k + 1] = pixel;
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;

            btnReset.Enabled = true;
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            int iWidth = 320;
            int iHeight = 240;

            SetArrayFromBitmap();

            //Declares temporary array
            Color[,] TempArray = new Color[320, 240];

            //Sets the temporary array values based on current ImageArray values
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    TempArray[i, j] = ImageArray[i, j];
                }
            }

            //Zooms image based on zoom centre
            for (int i = 0; i < iWidth; i = i + 2)
            {
                for (int j = 0; j < iHeight; j = j + 2)
                {
                    //Zoom centre at (80, 60)
                    ImageArray[i, j] = TempArray[i / 2 + 79, j / 2 + 59];
                    ImageArray[i + 1, j] = TempArray[i / 2 + 79, j / 2 + 59];
                    ImageArray[i, j + 1] = TempArray[i / 2 + 79, j / 2 + 59];
                    ImageArray[i + 1, j + 1] = TempArray[i / 2 + 79, j / 2 + 59];
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;

            btnReset.Enabled = true;
        }

        private void btnBlur_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            SetArrayFromBitmap();

            int AvgR, AvgG, AvgB;

            int iWidth = 320;
            int iHeight = 240;

            //Declares temporary array
            Color[,] TempArray = new Color[320, 240];

            //Sets the temporary array values based on current ImageArray values
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    TempArray[i, j] = ImageArray[i, j];
                }
            }

            //Blurs image by finding the average RGB values of a pixel and its neighbouring pixels, then setting their RGB values to the average
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    //Top left corner
                    if (i == 0 && j == 0)
                    {
                        AvgR = (TempArray[i, j].R + TempArray[i + 1, j].R + TempArray[i, j + 1].R + TempArray[i + 1, j + 1].R) / 4;
                        AvgG = (TempArray[i, j].G + TempArray[i + 1, j].G + TempArray[i, j + 1].G + TempArray[i + 1, j + 1].G) / 4;
                        AvgB = (TempArray[i, j].B + TempArray[i + 1, j].B + TempArray[i, j + 1].B + TempArray[i + 1, j + 1].B) / 4;

                        Color newColor = Color.FromArgb(255, AvgR, AvgG, AvgB);
                        ImageArray[i, j] = newColor;
                    }
                    //Bottom left corner
                    else if (i == 0 && j == 239)
                    {
                        AvgR = (TempArray[i, j].R + TempArray[i, j - 1].R + TempArray[i + 1, j - 1].R + TempArray[i + 1, j].R) / 4;
                        AvgG = (TempArray[i, j].G + TempArray[i, j - 1].G + TempArray[i + 1, j - 1].G + TempArray[i + 1, j].G) / 4;
                        AvgB = (TempArray[i, j].B + TempArray[i, j - 1].B + TempArray[i + 1, j - 1].B + TempArray[i + 1, j].B) / 4;

                        Color newColor = Color.FromArgb(255, AvgR, AvgG, AvgB);
                        ImageArray[i, j] = newColor;
                    }
                    //Bottom right corner
                    else if (i == 319 && j == 239)
                    {
                        AvgR = (TempArray[i, j].R + TempArray[i - 1, j].R + TempArray[i, j - 1].R + TempArray[i - 1, j - 1].R) / 4;
                        AvgG = (TempArray[i, j].G + TempArray[i - 1, j].G + TempArray[i, j - 1].G + TempArray[i - 1, j - 1].G) / 4;
                        AvgB = (TempArray[i, j].B + TempArray[i - 1, j].B + TempArray[i, j - 1].B + TempArray[i - 1, j - 1].B) / 4;

                        Color newColor = Color.FromArgb(255, AvgR, AvgG, AvgB);
                        ImageArray[i, j] = newColor;
                    }
                    //Top right corner
                    else if (i == 319 && j == 0)
                    {
                        AvgR = (TempArray[i, j].R + TempArray[i, j + 1].R + TempArray[i - 1, j + 1].R + TempArray[i - 1, j].R) / 4;
                        AvgG = (TempArray[i, j].G + TempArray[i, j + 1].G + TempArray[i - 1, j + 1].G + TempArray[i - 1, j].G) / 4;
                        AvgB = (TempArray[i, j].B + TempArray[i, j + 1].B + TempArray[i - 1, j + 1].B + TempArray[i - 1, j].B) / 4;

                        Color newColor = Color.FromArgb(255, AvgR, AvgG, AvgB);
                        ImageArray[i, j] = newColor;
                    }
                    //Top edge of image
                    else if (j == 0)
                    {
                        AvgR = (TempArray[i, j].R + TempArray[i - 1, j].R + TempArray[i + 1, j].R + TempArray[i - 1, j + 1].R + TempArray[i + 1, j + 1].R + TempArray[i, j + 1].R) / 6;
                        AvgG = (TempArray[i, j].G + TempArray[i - 1, j].G + TempArray[i + 1, j].G + TempArray[i - 1, j + 1].G + TempArray[i + 1, j + 1].G + TempArray[i, j + 1].G) / 6;
                        AvgB = (TempArray[i, j].B + TempArray[i - 1, j].B + TempArray[i + 1, j].B + TempArray[i - 1, j + 1].B + TempArray[i + 1, j + 1].B + TempArray[i, j + 1].B) / 6;

                        Color newColor = Color.FromArgb(255, AvgR, AvgG, AvgB);
                        ImageArray[i, j] = newColor;
                    }
                    //Right edge of image
                    else if (i == 319)
                    {
                        AvgR = (TempArray[i, j].R + TempArray[i, j - 1].R + TempArray[i - 1, j - 1].R + TempArray[i - 1, j].R + TempArray[i - 1, j + 1].R + TempArray[i, j + 1].R) / 6;
                        AvgG = (TempArray[i, j].G + TempArray[i, j - 1].G + TempArray[i - 1, j - 1].G + TempArray[i - 1, j].G + TempArray[i - 1, j + 1].G + TempArray[i, j + 1].G) / 6;
                        AvgB = (TempArray[i, j].B + TempArray[i, j - 1].B + TempArray[i - 1, j - 1].B + TempArray[i - 1, j].B + TempArray[i - 1, j + 1].B + TempArray[i, j + 1].B) / 6;

                        Color newColor = Color.FromArgb(255, AvgR, AvgG, AvgB);
                        ImageArray[i, j] = newColor;
                    }
                    //Left edge of image
                    else if (i == 0)
                    {
                        AvgR = (TempArray[i, j].R + TempArray[i, j - 1].R + TempArray[i + 1, j - 1].R + TempArray[i + 1, j].R + TempArray[i + 1, j + 1].R + TempArray[i, j + 1].R) / 6;
                        AvgG = (TempArray[i, j].G + TempArray[i, j - 1].G + TempArray[i + 1, j - 1].G + TempArray[i + 1, j].G + TempArray[i + 1, j + 1].G + TempArray[i, j + 1].G) / 6;
                        AvgB = (TempArray[i, j].B + TempArray[i, j - 1].B + TempArray[i + 1, j - 1].B + TempArray[i + 1, j].B + TempArray[i + 1, j + 1].B + TempArray[i, j + 1].B) / 6;

                        Color newColor = Color.FromArgb(255, AvgR, AvgG, AvgB);
                        ImageArray[i, j] = newColor;
                    }
                    //Bottom edge of image
                    else if (j == 239)
                    {
                        AvgR = (TempArray[i, j].R + TempArray[i - 1, j].R + TempArray[i - 1, j - 1].R + TempArray[i, j - 1].R + TempArray[i + 1, j - 1].R + TempArray[i + 1, j].R) / 6;
                        AvgG = (TempArray[i, j].G + TempArray[i - 1, j].G + TempArray[i - 1, j - 1].G + TempArray[i, j - 1].G + TempArray[i + 1, j - 1].G + TempArray[i + 1, j].G) / 6;
                        AvgB = (TempArray[i, j].B + TempArray[i - 1, j].B + TempArray[i - 1, j - 1].B + TempArray[i, j - 1].B + TempArray[i + 1, j - 1].B + TempArray[i + 1, j].B) / 6;

                        Color newColor = Color.FromArgb(255, AvgR, AvgG, AvgB);
                        ImageArray[i, j] = newColor;
                    }
                    //Every other pixel (i.e. pixels in the middle)
                    else
                    {
                        AvgR = (TempArray[i, j].R + TempArray[i - 1, j].R + TempArray[i - 1, j - 1].R + TempArray[i, j - 1].R + TempArray[i + 1, j - 1].R + TempArray[i + 1, j].R + TempArray[i + 1, j + 1].R + TempArray[i, j + 1].R + TempArray[i - 1, j + 1].R) / 9;
                        AvgG = (TempArray[i, j].G + TempArray[i - 1, j].G + TempArray[i - 1, j - 1].G + TempArray[i, j - 1].G + TempArray[i + 1, j - 1].G + TempArray[i + 1, j].G + TempArray[i + 1, j + 1].G + TempArray[i, j + 1].G + TempArray[i - 1, j + 1].G) / 9;
                        AvgB = (TempArray[i, j].B + TempArray[i - 1, j].B + TempArray[i - 1, j - 1].B + TempArray[i, j - 1].B + TempArray[i + 1, j - 1].B + TempArray[i + 1, j].B + TempArray[i + 1, j + 1].B + TempArray[i, j + 1].B + TempArray[i - 1, j + 1].B) / 9;

                        Color newColor = Color.FromArgb(255, AvgR, AvgG, AvgB);
                        ImageArray[i, j] = newColor;
                    }
                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;

            btnReset.Enabled = true;
        }

    }
}
