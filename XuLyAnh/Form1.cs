using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XuLyAnh
{
    public partial class Form1 : Form
    {
        // Variables
        private Bitmap bm1;
        private Bitmap bm2;

        private Dictionary<String, Color> dicColors;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // BtnBrowse1
        private void BtnBrowse1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG",
                FilterIndex = 1,
                Multiselect = false
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (ofd.FileName != null)
                    {
                        bm1 = new Bitmap(ofd.FileName);
                        pictureBox1.Image = bm1;

                        byte[,,] arrBGRBytes1 = BitmapToBGRBytes(bm1);
                        //MessageBox.Show(arrBGRBytes1.Length.ToString());

                        int[] arrColorComponents1 = GetColorComponents(bm1, arrBGRBytes1);
                        /*
                        int count = 0;
                        for (int i = 0; i < arrColorComponents1.Length; i++)
                        {
                            count = count + arrColorComponents1[i];
                        }
                        MessageBox.Show(count.ToString());
                        */

                        //var dic = BitmapToColors(bm1, arrBGRBytes1);
                        //dicColors = dic;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not open file! \n" + ex.Message);
                }
            }
        }

        private void BtnBrowse2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG",
                FilterIndex = 1,
                Multiselect = false
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (ofd.FileName != null)
                    {
                        bm2 = new Bitmap(ofd.FileName);
                        //mHandler.MyBitmap1 = (Bitmap)Bitmap.FromFile(ofd.FileName);
                        pictureBox2.Image = bm2;
                        byte[,,] arrBGRBytes2 = BitmapToBGRBytes(bm2);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not open file! \n" + ex.Message);
                }
            }
        }

        // BitmapToBGRBytes
        private byte[,,] BitmapToBGRBytes(Bitmap bitmap)
        {
            BitmapData bitmapData =
                bitmap.LockBits(new Rectangle(new Point(), bitmap.Size), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            byte[] bitmapBytes;
            var stride = bitmapData.Stride;
            try
            {
                int byteCount = bitmapData.Stride * bitmap.Height;
                bitmapBytes = new byte[byteCount];
                Marshal.Copy(bitmapData.Scan0, bitmapBytes, 0, byteCount);
            }
            finally
            {
                bitmap.UnlockBits(bitmapData);
            }
            byte[,,] result = new byte[3, bitmap.Width, bitmap.Height];
            for (int k = 0; k < 3; k++)
            {
                for (int i = 0; i < bitmap.Width; i++)
                {
                    for (int j = 0; j < bitmap.Height; j++)
                    {
                        result[k, i, j] = bitmapBytes[j * stride + i * 3 + k];
                    }
                }
            }
            return result;
        }

        // BitmapToColors
        private Dictionary<String, Color> BitmapToColors(Bitmap bitmap, byte[,,] arr)
        {
            var dic = new Dictionary<String, Color>();

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    var r = int.Parse(arr[2, i, j].ToString());
                    var g = int.Parse(arr[1, i, j].ToString());
                    var b = int.Parse(arr[0, i, j].ToString());

                    var color = Color.FromArgb(r, g, b);
                    var point = i.ToString() + "," + j.ToString();

                    dic.Add(point, color);
                }

            }
            return dic;

        }

        // GetColorComponents
        private int[] GetColorComponents(Bitmap bitmap, byte[,,] arr)
        {
            // init
            int[] arrColorComponents = new int[27];
            for (int i = 0; i < arrColorComponents.Length; i++)
            {
                arrColorComponents[i] = 0;
            }

            // get
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    int R = int.Parse(arr[2, i, j].ToString());
                    int G = int.Parse(arr[1, i, j].ToString());
                    int B = int.Parse(arr[0, i, j].ToString());
                    MyColor myColor = new MyColor(R, G, B);
                    int colorClass = myColor.GetColorClass();
                    arrColorComponents[colorClass]++;
                }

            }
            return arrColorComponents;

        }

        private void ShowColors(Dictionary<String, Color> dic)
        {
            try
            {
                var image1 = bm1;

                int x, y;

                // Loop through the images pixels to reset color.
                for (x = 0; x < image1.Width; x++)
                {
                    for (y = 0; y < image1.Height; y++)
                    {
                        Color pixelColor = image1.GetPixel(x, y);
                        //Color newColor = Color.FromArgb(pixelColor.R, 0, 0);
                        var point = x.ToString() + "," + y.ToString();
                        //Color value = Color.Red;

                        var color = dic[point];
                        image1.SetPixel(x, y, color);

                    }
                }

                // Set the PictureBox to display the image.
                pictureBox2.Image = image1;

                // Display the pixel format in Label1.
                Lbl1.Text = "Pixel format: " + image1.PixelFormat.ToString();

            }
            catch (ArgumentException)
            {
                MessageBox.Show("There was an error." +
                "Check the path to the image file.");
            }
        }

        private void bitmapFromArray(byte[,,] arr)
        {
        }

        private void BtnSetPictureBox1_Click(object sender, EventArgs e)
        {
            ShowColors(dicColors);
        }
    }
}
