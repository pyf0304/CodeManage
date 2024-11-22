using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.taishsoft.math
{
    /// <summary>
    /// 有关教育方面的数学计算
    /// </summary>
    public class clsMath_Edu
    {
        /// <summary>
        /// 求标准差（Standard Deviation）
        /// </summary>
        /// <param name="arrNums">数组</param>
        /// <param name="intCount">数据个数</param>
        /// <returns>方差</returns>
        public static double StandardDeviation(double[] arrNums, int intCount)
        {
            //double[] nums = new double[5];//定义一个长度为5的数组
            //for (int i = 0; i < 5; i++)
            //{
            //    nums[i] = Convert.ToDouble(Console.ReadLine());
            //}//从键盘读取5个正数，并放入数组
                       
            double sum = 0;
            for (int i = 0; i < intCount; i++)
            {
                sum += arrNums[i];
            }//求和
            double avg = sum / intCount;//求平均数
            double variance = 0;
            for (int i = 0; i < intCount; i++)
            {
                variance += Math.Pow(arrNums[i] - avg, 2);
            }//求方差
            variance = variance / intCount;
            double dblStandardDeviation = Math.Pow(variance, 0.5);//求标准差
            return dblStandardDeviation;
            //Console.WriteLine("这5个数的方差为：{0}", sd);//输出结果
            //Console.ReadLine();//屏幕暂停
        }
    }
}
