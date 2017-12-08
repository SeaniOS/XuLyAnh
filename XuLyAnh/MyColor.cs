using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuLyAnh
{
    //ảnh: lượng tử hóa thành n màu
    class MyColor
    {
        private int R;
        private int G;
        private int B;

        public MyColor(int R, int G, int B)
        {
            this.R = R;
            this.G = G;
            this.B = B;
        }

        public int GetColorClass()
        {
            // R <- 0
            if (InSpace(R) == 0)
            {
                if (InSpace(G) == 0 && InSpace(B) == 0)
                {
                    return 0;
                }
                if (InSpace(G) == 0 && InSpace(B) == 1)
                {
                    return 1;
                }
                if (InSpace(G) == 0 && InSpace(B) == 2)
                {
                    return 2;
                }
                if (InSpace(G) == 1 && InSpace(B) == 0)
                {
                    return 3;
                }
                if (InSpace(G) == 1 && InSpace(B) == 1)
                {
                    return 4;
                }
                if (InSpace(G) == 1 && InSpace(B) == 2)
                {
                    return 5;
                }
                if (InSpace(G) == 2 && InSpace(B) == 0)
                {
                    return 6;
                }
                if (InSpace(G) == 2 && InSpace(B) == 1)
                {
                    return 7;
                }
                if (InSpace(G) == 2 && InSpace(B) == 2)
                {
                    return 8;
                }
            }

            // R <- 1
            if (InSpace(R) == 1)
            {
                if (InSpace(G) == 0 && InSpace(B) == 0)
                {
                    return 9;
                }
                if (InSpace(G) == 0 && InSpace(B) == 1)
                {
                    return 10;
                }
                if (InSpace(G) == 0 && InSpace(B) == 2)
                {
                    return 11;
                }
                if (InSpace(G) == 1 && InSpace(B) == 0)
                {
                    return 12;
                }
                if (InSpace(G) == 1 && InSpace(B) == 1)
                {
                    return 13;
                }
                if (InSpace(G) == 1 && InSpace(B) == 2)
                {
                    return 14;
                }
                if (InSpace(G) == 2 && InSpace(B) == 0)
                {
                    return 15;
                }
                if (InSpace(G) == 2 && InSpace(B) == 1)
                {
                    return 16;
                }
                if (InSpace(G) == 2 && InSpace(B) == 2)
                {
                    return 17;
                }
            }

            // R <- 2
            if (InSpace(R) == 2)
            {
                if (InSpace(G) == 0 && InSpace(B) == 0)
                {
                    return 18;
                }
                if (InSpace(G) == 0 && InSpace(B) == 1)
                {
                    return 19;
                }
                if (InSpace(G) == 0 && InSpace(B) == 2)
                {
                    return 20;
                }
                if (InSpace(G) == 1 && InSpace(B) == 0)
                {
                    return 21;
                }
                if (InSpace(G) == 1 && InSpace(B) == 1)
                {
                    return 22;
                }
                if (InSpace(G) == 1 && InSpace(B) == 2)
                {
                    return 23;
                }
                if (InSpace(G) == 2 && InSpace(B) == 0)
                {
                    return 24;
                }
                if (InSpace(G) == 2 && InSpace(B) == 1)
                {
                    return 25;
                }
                if (InSpace(G) == 2 && InSpace(B) == 2)
                {
                    return 26;
                }
            }
            return -1;
        }

        // 0 -> 255: 0 -> 85, 86 -> 170, 171 -> 255
        private int InSpace(int value)
        {
            if (0 <= value && value <= 85)
            {
                return 0;
            }
            else if (86 <= value && value <= 170)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
