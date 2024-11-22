using System;
using System.Collections;
using System.Collections.Generic;

namespace com.taishsoft.common
{
	/// <summary>
	/// clsAggregate 的摘要说明。
	/// 该类专门用处理一些集合方面的函数
	/// </summary>
	public partial class clsAggregate
	{
		
		/// <summary>
		/// 求两个集合的差集
		/// </summary>
		/// <param name="arrAllSet">母集：是原集合中所有的元素</param>
		/// <param name="arrSubSet">是某一子集</param>
		/// <returns>母集减去子集得到的差</returns>
		public static List<string>  TwoAggrDiff(List<string>  arrAllSet, List<string>  arrSubSet)
		{
			List<string>  arrDiffSet = new List<string> ();	//需要删除的菜单项
			//找出修改后有，而原来没有，差集就为需要新增的菜单项
            foreach (string obj in arrAllSet)
			{
				if (arrSubSet.Contains(obj) == false)
				{
					arrDiffSet.Add(obj);
				}
			}
			return arrDiffSet;
		}
        /// <summary>
        /// 求两个集合的并集
        /// </summary>
        /// <param name="arrSetA">母集：是原集合中所有的元素</param>
        /// <param name="arrSetB">是某一子集</param>
        /// <returns>母集减去子集得到的差</returns>
        public static void UniteTwoAggr(ref List<string>  arrSetA, List<string>  arrSetB)
        {
            //把所有B集合中的元素都添加到A集合中去，最后返回A集合
            foreach (string  obj in arrSetB)
            {
                if (arrSetA.Contains(obj) == false)
                {
                    arrSetA.Add(obj);
                }
            }
            //			return arrSetA;
        }
        /// <summary>
        /// 求两个集合的交集
        /// </summary>
        /// <param name="arrSetA">子集A</param>
        /// <param name="arrSetB">子集B</param>
        /// <returns>两个子集的交集</returns>
        public static List<string>  IntersectTwoAggr(List<string>  arrSetA, List<string>  arrSetB)
        {
            List<string>  arrNewSet = new List<string> ();
            //把所有B集合中的元素都添加到A集合中去，最后返回A集合
            foreach (string obj in arrSetB)
            {
                if (arrSetA.Contains(obj) == true)
                {
                    arrNewSet.Add(obj);
                }
            }
            return arrNewSet;
        }
	}
}
