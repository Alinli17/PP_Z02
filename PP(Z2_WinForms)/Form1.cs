using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP_Z2_WinForms_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Verify_Click(object sender, EventArgs e)
        {
            float x = float.Parse(Coordinate_X.Text);
            float y = float.Parse(Coordinate_Y.Text);
            if (y >= -100 && y <= -x && y <= x)
            {
                if (y == -100 || y == -x || y == x)
                    rez_1.Text="На границе";
                else rez_1.Text="Да";
            }
            else rez_1.Text="Нет";
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            int Date = Convert.ToInt32(D.Text);
            int month = Convert.ToInt32(M.Text);
            int year = Convert.ToInt32(G.Text);

            int m = Convert.ToInt32(num.Text);

            int totalMonth = year * 12 + month - m;
            int Year = totalMonth / 12;
            int Month = totalMonth - (Year * 12);
            if (Month == 0)
            {
                Month = 12;
                Year--;
            }
            rez_D.Text = Date.ToString();
            rez_M.Text = Month.ToString();
            rez_G.Text = Year.ToString();
        }

        private void Display_Click(object sender, EventArgs e)
        {
            int A = int.Parse(per_A.Text);
            int B = int.Parse(per_B.Text);
            int X = int.Parse(per_X.Text);
            string str = "";
            string s = "";
            int i = A;

            while (i <= B)
            {
                if ((i - X) % 10 == 0)
                    str += i + " ";
                 rez_3Z.Text = str;
                 i++;
            }

            do
            {
                if ((i - X) % 10 == 0)
                    str += i + " ";
                rez_3Z_DW.Text = str;
                i++;
            }
            while (i <= B);

            for (i = A; i <= B; i++)
                if ((i - X) % 10 == 0)
                    s += i + " ";
            rez_3Z_F.Text = s;
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            int n = 5;
            string str1 = "";
            for (int i = 8; i >= 4; i--)
            {
                for (int j = n; j >= 1; j--)
                {
                    str1 += i + " ";
                    rez_Z4.Text = str1;
                }
                str1 += "\n";
                rez_Z4.Text = str1;
                n--;
            }
        }
    }
}
