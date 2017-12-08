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
        private string bitString1;
        private string bitString2;

        //private Dictionary<String, Color> dicColors;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            /*
            double rate = ((double)12) / ((double)100) * 100;
            var first = rate / 10;
            var _first = Math.Round(rate / 10);
            var last = first - _first;
            if (last > 0)
            {
                _first = _first + 1;
            }
            MessageBox.Show(_first.ToString());
            */
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

                        // mảng 3 chiều R G B
                        byte[,,] arrBGRBytes = BitmapToBGRBytes(bm1);
                        //MessageBox.Show(arrBGRBytes1.Length.ToString());

                        // mảng số lượng mỗi màu thành phần
                        int[] arrColorComponentsNumber = GetColorComponentsNumber(bm1, arrBGRBytes);
                        /*
                        int count = 0;
                        for (int i = 0; i < arrColorComponents1.Length; i++)
                        {
                            count = count + arrColorComponents1[i];
                        }
                        MessageBox.Show(count.ToString());
                        */

                        // mảng tỉ lệ mỗi màu thành phần -> bin
                        int[] arrColorComponentsRate = GetColorComponentsRate(arrColorComponentsNumber);

                        var binNumbers1 = "";
                        for (int i = 0; i < arrColorComponentsRate.Length; i++)
                        {
                            binNumbers1 = binNumbers1 + arrColorComponentsRate[i];
                            if ((i + 1) % 9 == 0)
                            {
                                binNumbers1 += " ";
                            }
                        }

                        // dãy nhị phân của hình
                        string bitStringRecognization = "";
                        for (int i = 0; i < arrColorComponentsRate.Length; i++)
                        {
                            bitStringRecognization = bitStringRecognization + BinToBitString(arrColorComponentsRate[i]);
                            /*
                            if ((i + 1) % 9 == 0)
                            {
                                bitStringRecognization += "\n";
                            }
                            */
                        }

                        lblBinNumber1.Text = binNumbers1;
                        txt1.Text = bitStringRecognization;

                        bitString1 = bitStringRecognization;
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

        // BtnBrowse2
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
                        pictureBox2.Image = bm2;

                        // mảng 3 chiều R G B
                        byte[,,] arrBGRBytes = BitmapToBGRBytes(bm2);

                        // mảng số lượng mỗi màu thành phần
                        int[] arrColorComponentsNumber = GetColorComponentsNumber(bm2, arrBGRBytes);

                        // mảng tỉ lệ mỗi màu thành phần -> bin
                        int[] arrColorComponentsRate = GetColorComponentsRate(arrColorComponentsNumber);

                        var binNumbers2 = "";
                        for (int i = 0; i < arrColorComponentsRate.Length; i++)
                        {
                            binNumbers2 = binNumbers2 + arrColorComponentsRate[i];
                            if ((i + 1) % 9 == 0)
                            {
                                binNumbers2 += " ";
                            }
                        }

                        // dãy nhị phân của hình
                        string bitStringRecognization = "";
                        for (int i = 0; i < arrColorComponentsRate.Length; i++)
                        {
                            bitStringRecognization = bitStringRecognization + BinToBitString(arrColorComponentsRate[i]);
                            /*
                            if ((i + 1) % 9 == 0)
                            {
                                bitStringRecognization += "\n";
                            }
                            */
                        }

                        lblBinNumber2.Text = binNumbers2;
                        txt2.Text = bitStringRecognization;

                        bitString2 = bitStringRecognization;

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
        /*
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
        */
        // GetColorComponents
        private int[] GetColorComponentsNumber(Bitmap bitmap, byte[,,] arr)
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

        // thành phần màu -> rời rạc thành 10 bin nhị phân: 0100000000_1000000000_0000000100
        private int[] GetColorComponentsRate(int[] arrColorComponents)
        {
            // tổng số màu
            int totalColorPixel = 0;
            for (int i = 0; i < arrColorComponents.Length; i++)
            {
                totalColorPixel = totalColorPixel + arrColorComponents[i];
            }

            // init mảng tỉ lệ
            int[] arrRateColorComponents = new int[27];
            for (int i = 0; i < arrRateColorComponents.Length; i++)
            {
                arrRateColorComponents[i] = 0;

                if (i == arrRateColorComponents.Length - 1)
                {
                    arrRateColorComponents[i] = 10; // 10 bit
                }
            }

            // Duyệt các thành phần màu
            for (int i = 0; i < arrColorComponents.Length - 1; i++)
            {
                double rate = ((double)arrColorComponents[i]) / ((double)totalColorPixel) * 10;
                int colorRate = (int)Math.Round(rate);

                arrRateColorComponents[i] = colorRate;
            }

            // last color component
            for (int i = 0; i < arrRateColorComponents.Length - 1; i++)
            {
                arrRateColorComponents[26] = arrRateColorComponents[26] - arrRateColorComponents[i];
            }

            return arrRateColorComponents;
        }

        // 1 -> 10
        private string BinToBitString(int binValue)
        {
            if (binValue == 0)
            {
                return "0000000000";
                //return "#";
            }

            // init
            string[] str = new string[10];
            for (int i = 0; i < 10; i++)
            {
                str[i] = "0";
            }

            str[binValue - 1] = "1";

            string bitString = "";
            for (int i = 0; i < 10; i++)
            {
                bitString = bitString + str[i];
            }

            return bitString;
        }

        private void BtnCompare_Click(object sender, EventArgs e)
        {
            if (bitString1 == null)
            {
                MessageBox.Show("Input picture 1");
                return;
            }

            if (bitString2 == null)
            {
                MessageBox.Show("Input picture 2");
                return;
            }

            int countColor = 0;
            int result = 0;
            for (int i = 0; i < 27; i++)
            {
                var value1 = BitToBin(bitString1.Substring(countColor, 10));
                //MessageBox.Show(value1.ToString());
                //MessageBox.Show(bitString1.Substring(countColor, 10));
                var value2 = BitToBin(bitString2.Substring(countColor, 10));
                //MessageBox.Show(value2.ToString());
                //MessageBox.Show(bitString2.Substring(countColor, 10));
                var _result = Math.Abs(value1 - value2);
                countColor = countColor + 10;
                //MessageBox.Show(_result.ToString());
                result = result + _result;
            }

            MessageBox.Show(result.ToString());
            //var binValue = BitToBin("0000000001");
            //MessageBox.Show(binValue.ToString());
        }

        private int BitToBin(string bitString)
        {
            if (bitString.Contains('1'))
            {
                return bitString.IndexOf('1') + 1;
            }
            else
            {
                return 0;
            }

        }

        /*
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
        */
        /*
        private void BtnSetPictureBox1_Click(object sender, EventArgs e)
        {
            ShowColors(dicColors);
        }
        */
    }
}
