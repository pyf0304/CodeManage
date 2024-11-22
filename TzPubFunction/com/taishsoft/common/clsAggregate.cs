using System;
using System.Collections;

namespace com.taishsoft.common
{
	/// <summary>
	/// clsAggregate 的摘要说明。
	/// 该类专门用处理一些集合方面的函数
	/// </summary>
	public partial class clsAggregate
	{
        /// <summary>
        /// 
        /// </summary>
		public clsAggregate()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}
		/// <summary>
		/// 求两个集合的差集
		/// </summary>
		/// <param name="arrAllSet">母集：是原集合中所有的元素</param>
		/// <param name="arrSubSet">是某一子集</param>
		/// <returns>母集减去子集得到的差</returns>
		public static ArrayList TwoAggrDiff(ArrayList arrAllSet, ArrayList arrSubSet)
		{
			ArrayList arrDiffSet = new ArrayList();	//需要删除的菜单项
			//找出修改后有，而原来没有，差集就为需要新增的菜单项
			foreach ( object obj in arrAllSet)
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
        public static void UniteTwoAggr(ref ArrayList arrSetA, ArrayList arrSetB)
        {
            //把所有B集合中的元素都添加到A集合中去，最后返回A集合
            foreach (object obj in arrSetB)
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
        public static ArrayList IntersectTwoAggr(ArrayList arrSetA, ArrayList arrSetB)
        {
            ArrayList arrNewSet = new ArrayList();
            //把所有B集合中的元素都添加到A集合中去，最后返回A集合
            foreach (object obj in arrSetB)
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
