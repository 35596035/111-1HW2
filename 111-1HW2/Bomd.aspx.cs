using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Runtime.dll;

namespace _111_1HW2
{
    public partial class Bomd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] ia_Mlndex = new int[10] { 0, 7, 13, 28, 44, 62, 74, 75, 87, 90 };
            char[,] ia_Map = new char[10, 10];
            for (int i_Row = 0; i_Row < 10; i_Row++)
            {
                for (int i_Col = 0; i_Col < 10; i_Col++)
                {
                    ia_Map[i_Row, i_Col] = 'O';
                }
            }
            #region 塞炸彈位置和判斷炸彈周圍數字顯示
            for (int i_Ct = 0; i_Ct < 10; i_Ct++)
            {
                int i_Row = ia_Mlndex[i_Ct] / 10;
                int i_Col = ia_Mlndex[i_Ct] % 10;
                ia_Map[i_Row, i_Col] = '*';
                if (ia_Map[i_Row, i_Col] == '*')
                {
                    continue;
                }
                //左上
                if ((i_Row - 1) >= 0 && (i_Col - 1) >= 0)
                {
                    int i_Num = Convert.ToInt32(ia_Map[i_Row, i_Col]);
                    i_Num++;
                    ia_Map[i_Row, i_Col] = Convert.ToChar(i_Num);
                }
                //上
                if ((i_Row - 1) >= 0 && (i_Col - 0) >= 0)
                {
                    int i_Num = Convert.ToInt32(ia_Map[i_Row, i_Col]);
                    i_Num++;
                    ia_Map[i_Row, i_Col] = Convert.ToChar(i_Num);
                }
                //右上
                if ((i_Row - 1) >= 0 && (i_Col + 1) >= 0)
                {
                    int i_Num = Convert.ToInt32(ia_Map[i_Row, i_Col]);
                    i_Num++;
                    ia_Map[i_Row, i_Col] = Convert.ToChar(i_Num);
                }
                //左
                if ((i_Row - 0) >= 0 && (i_Col - 1) >= 0)
                {
                    int i_Num = Convert.ToInt32(ia_Map[i_Row, i_Col]);
                    i_Num++;
                    ia_Map[i_Row, i_Col] = Convert.ToChar(i_Num);
                }
                //右
                if ((i_Row - 0) >= 0 && (i_Col + 1) >= 0)
                {
                    int i_Num = Convert.ToInt32(ia_Map[i_Row, i_Col]);
                    i_Num++;
                    ia_Map[i_Row, i_Col] = Convert.ToChar(i_Num);
                }
                //左下
                if ((i_Row + 1) >= 0 && (i_Col - 1) >= 0)
                {
                    int i_Num = Convert.ToInt32(ia_Map[i_Row, i_Col]);
                    i_Num++;
                    ia_Map[i_Row, i_Col] = Convert.ToChar(i_Num);
                }
                //下
                if ((i_Row + 1) >= 0 && (i_Col - 0) >= 0)
                {
                    int i_Num = Convert.ToInt32(ia_Map[i_Row, i_Col]);
                    i_Num++;
                    ia_Map[i_Row, i_Col] = Convert.ToChar(i_Num);
                }
                //右下
                if ((i_Row + 1) >= 0 && (i_Col + 1) >= 0)
                {
                    int i_Num = Convert.ToInt32(ia_Map[i_Row, i_Col]);
                    i_Num++;
                    ia_Map[i_Row, i_Col] = Convert.ToChar(i_Num);
                }
            }
            #endregion

            for (int i_Row = 0; i_Row < 10; i_Row++)
            {
                for (int i_Col = 0; i_Col < 10; i_Col++)
                {
                    Response.Write(ia_Map[i_Row, i_Col]);
                }
                Response.Write("<br />");
            }
        }
    }
}