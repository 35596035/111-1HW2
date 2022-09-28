using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1HW2
{
    public partial class Bomb2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if寫法
            int[] ia_Mlndex = new int[10] { 0, 7, 13, 28, 44, 62, 74, 75, 87, 90 };
            char[,] ia_Map = new char[10, 10];
            for (int i_Row = 0; i_Row< 10; i_Row++)
            {
                for (int i_Col = 0; i_Col< 10; i_Col++)
                {
                    ia_Map[i_Row, i_Col] = '0';
                }
            }

            for (int i_Ct = 0; i_Ct < 10; i_Ct++)
            {
                int i_Row = ia_Mlndex[i_Ct] / 10; //0
                int i_Col = ia_Mlndex[i_Ct] % 10; //0
                ia_Map[i_Row, i_Col] = '*';
            }
            for (int i_Row = 0; i_Row < 10; i_Row++)
            {
                int BombCt = 0;
                for (int i_Col = 0; i_Col < 10; i_Col++)
                {
                    if (ia_Map[i_Row, i_Col] == '*')
                    {
                        continue;
                    }
                    Response.Write(i_Row);
                    Response.Write(i_Col);
                    Response.Write("<br>");
                    //左上
                    if ((i_Row - 1) >= 0 && (i_Col - 1) >= 0)
                    {
                        //左上
                        if (ia_Map[i_Row - 1, i_Col - 1] == '*')
                        {
                            BombCt++;
                            break;
                        }
                        /*
                        //上
                        if (ia_Map[i_Row - 1, i_Col - 0] == '*')
                        {
                            BombCt++;
                        }
                        //右上
                        if (ia_Map[i_Row - 1, i_Col + 1] == '*')
                        {
                            BombCt++;
                        }
                        //左
                        if (ia_Map[i_Row - 0, i_Col - 1] == '*')
                        {
                            BombCt++;
                        }
                        //右
                        if (ia_Map[i_Row - 0, i_Col + 1] == '*')
                        {
                            BombCt++;
                        }
                        //左下
                        if (ia_Map[i_Row + 1, i_Col - 1] == '*')
                        {
                            BombCt++;
                        }
                        //下
                        if (ia_Map[i_Row + 1, i_Col - 0] == '*')
                        {
                            BombCt++;
                        }
                        //右下
                        if (ia_Map[i_Row + 1, i_Col + 1] == '*')
                        {
                            BombCt++;
                        }*/
                    }
                    //上
                    if ((i_Row - 1) >= 0)
                    {
                        if (ia_Map[i_Row - 1, i_Col] == '*')
                        {
                            BombCt++;
                        }
                    }
                    //右上
                    if ((i_Row - 1) >= 0 && (i_Col + 1) < 10)
                    {
                        if (ia_Map[i_Row - 1, i_Col + 1] == '*')
                        {
                            BombCt++;
                        }
                    }
                    //左
                    if ((i_Col - 1) > 0)
                    {
                        if (ia_Map[i_Row, i_Col - 1] == '*')
                        {
                            BombCt++;
                        }
                    }

                    //右
                    if ((i_Col + 1) < 10) //Row:0-0=0 Col:0+1=1
                    {
                        if (ia_Map[i_Row, i_Col + 1] == '*')
                        {
                            BombCt++;
                        }
                    }

                    //左下
                    if ((i_Row + 1) < 10 && (i_Col - 1) >= 0)
                    {
                        if (ia_Map[i_Row + 1, i_Col - 1] == '*')
                        {
                            BombCt++;
                        }
                    }
                    //下
                    if ((i_Row + 1) < 10)
                    {
                        if (ia_Map[i_Row + 1, i_Col] == '*')
                        {
                            BombCt++;
                        }
                    }
                    //右下
                    if ((i_Row + 1) < 10 && (i_Col + 1) <= 9)
                    {
                        if (ia_Map[i_Row + 1, i_Col + 1] == '*')
                        {
                            BombCt++;
                        }
                    }
                    Response.Write(Convert.ToInt32(BombCt) + "<br />");
                    ia_Map[i_Row, i_Col] = Convert.ToChar(BombCt);
                }
                //#endregion
            }

            //methonds 2


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