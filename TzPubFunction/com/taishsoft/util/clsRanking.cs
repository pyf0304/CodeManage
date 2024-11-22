using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.taishsoft.util
{
    /// <summary>
    /// 用于排名的类
    /// </summary>
    public class clsRanking
    {
        /// <summary>
        /// 计算排名
        /// </summary>
        /// <param name="arrObjExLst">需要排名的数组</param>
        public static void CalcRanking(IRankObj[] arrObjExLst)
        {
            //clsCurrEduClsStuBL.GetObjLst(strCondition);
            List<IRankObj> arrRankObj = new List<IRankObj>();
            foreach (IRankObj objInFor in arrObjExLst)
            {
                arrRankObj.Add(objInFor);
            }

            arrRankObj.Sort((IRankObj x, IRankObj y) =>
            {
                if (x.Score - y.Score <= 0.001) return 0;
                else if (x.Score < y.Score) return 1;//左值小于右值，返回-1，为升序，如果返回1，就是降序  
                return -1;
            });

            int intNum = arrObjExLst.Length;
            double dblLastScore = 0.0;
            double dblLastPercentile = 0.0;
            int intLastRanking = 1;

            int intRanking = 1;
            foreach (IRankObj objInFor in arrObjExLst)
            {
                if (Math.Abs(objInFor.Score - dblLastScore) <= 0.001)
                {
                    objInFor.Ranking = intLastRanking;
                    objInFor.Percentile = dblLastPercentile;
                    //clsCurrEduClsStuBL.UpdateBySql2(objCurrEduClsStuEN);
                }
                else
                {
                    objInFor.Ranking = intRanking;
                    objInFor.Percentile = intRanking * 1.0 / intNum;
                    intLastRanking = intRanking;
                    dblLastScore = objInFor.Score;
                    dblLastPercentile = objInFor.Percentile;
                    //clsCurrEduClsStuBL.UpdateBySql2(objCurrEduClsStuEN);
                }
                intRanking++;
            }

        }
    }
}
