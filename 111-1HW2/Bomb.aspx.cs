using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1HW2
{
    public partial class Bomb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //第二種寫法for
            //填入0
            int[] ia_Mlndex = new int[10] { 0, 7, 13, 28, 44, 62, 74, 75, 87, 90 };
            char[,] ia_Map = new char[10, 10];
            for (int i_Row = 0; i_Row < 10; i_Row++)
            {
                for (int i_Col = 0; i_Col < 10; i_Col++)
                {
                    ia_Map[i_Row, i_Col] = '0';
                }
            }
            //填入*
            for (int i_Ct = 0; i_Ct < ia_Mlndex.Length; i_Ct++)
            {
                int i_Row = ia_Mlndex[i_Ct] / 10; //0
                int i_Col = ia_Mlndex[i_Ct] % 10; //0
                ia_Map[i_Row, i_Col] = '*';
                //Response.Write(ia_Map[i_Row, i_Col]);
            }
            //訪問*周邊
            for (int i_Ct = 0; i_Ct < ia_Mlndex.Length; i_Ct++)
            {
                int i_Row = ia_Mlndex[i_Ct] / 10; //0
                int i_Col = ia_Mlndex[i_Ct] % 10; //0
                //左上
                if ((i_Row - 1) >= 0 && (i_Col - 1) >= 0)
                {
                    if (ia_Map[i_Row - 1, i_Col - 1] != '*')
                    {
                        int i_Num = Convert.ToInt32(ia_Map[i_Row - 1, i_Col - 1]);
                        i_Num++;
                        ia_Map[i_Row - 1, i_Col - 1] = Convert.ToChar(i_Num);
                    }
                }
                //上
                if ((i_Row - 1) >= 0)
                {
                    if (ia_Map[i_Row - 1, i_Col] != '*')
                    {
                        int i_Num = Convert.ToInt32(ia_Map[i_Row - 1, i_Col]);
                        i_Num++;
                        ia_Map[i_Row - 1, i_Col] = Convert.ToChar(i_Num);
                    }
                }
                //右上
                if ((i_Row - 1) >= 0 && (i_Col + 1) < 10)
                {
                    if (ia_Map[i_Row - 1, i_Col + 1] != '*')
                    {
                        int i_Num = Convert.ToInt32(ia_Map[i_Row - 1, i_Col + 1]);
                        i_Num++;
                        ia_Map[i_Row - 1, i_Col + 1] = Convert.ToChar(i_Num);
                    }
                }
                //左
                if ((i_Col - 1) >= 0)
                {
                    if (ia_Map[i_Row, i_Col - 1] != '*')
                    {
                        int i_Num = Convert.ToInt32(ia_Map[i_Row, i_Col - 1]);
                        i_Num++;
                        ia_Map[i_Row, i_Col - 1] = Convert.ToChar(i_Num);
                    }
                }

                //右
                if ((i_Col + 1) < 10)
                {
                    if (ia_Map[i_Row, i_Col + 1] != '*')
                    {
                        int i_Num = Convert.ToInt32(ia_Map[i_Row, i_Col + 1]);
                        i_Num++;
                        ia_Map[i_Row, i_Col + 1] = Convert.ToChar(i_Num);
                    }
                }

                //左下
                if ((i_Row + 1) < 10 && (i_Col - 1) >= 0)
                {
                    if (ia_Map[i_Row + 1, i_Col - 1] != '*')
                    {
                        int i_Num = Convert.ToInt32(ia_Map[i_Row + 1, i_Col - 1]);
                        i_Num++;
                        ia_Map[i_Row + 1, i_Col - 1] = Convert.ToChar(i_Num);
                    }
                }
                //下
                if ((i_Row + 1) < 10)
                {
                    if (ia_Map[i_Row + 1, i_Col] != '*')
                    {
                        int i_Num = Convert.ToInt32(ia_Map[i_Row + 1, i_Col]);
                        i_Num++;
                        ia_Map[i_Row + 1, i_Col] = Convert.ToChar(i_Num);
                    }
                }
                //右下
                if ((i_Row + 1) < 10 && (i_Col + 1) < 10)
                {
                    if (ia_Map[i_Row + 1, i_Col + 1] != '*')
                    {
                        int i_Num = Convert.ToInt32(ia_Map[i_Row + 1, i_Col + 1]);
                        i_Num++;
                        ia_Map[i_Row + 1, i_Col + 1] = Convert.ToChar(i_Num);
                    }
                }
            }
            //最後訪問全部的陣列
            for (int i_Row = 0; i_Row < 10; i_Row++)
            {
                for (int i_Col = 0; i_Col < 10; i_Col++)
                {
                    Response.Write(ia_Map[i_Row, i_Col]);
                }
                Response.Write("<br />");
            }
            //Response.Write(ia_Map[7, 4]);
            //Response.Write(ia_Map[7, 5]);
        }
    }
}