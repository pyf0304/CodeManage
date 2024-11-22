using System;
using System.Collections;
using System.Windows.Forms;


namespace com.taishsoft.util
{
	/// <summary>
	/// mySorter 的摘要说明。
	/// </summary>
	public class clsListViewSorter : IComparer
	{
		private Comparer comparer;
		private int sortColumn;
		private SortOrder sortOrder;

        /// <summary>
        /// ListView排序er
        /// </summary>
		public clsListViewSorter()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
			sortColumn=0;
			sortOrder=SortOrder.None;
			comparer=Comparer.Default;
		}
     
        /// <summary>
        /// 指定进行排序的列
        /// </summary>
        public int SortColumn
		{
			get {return sortColumn;}
			set {sortColumn=value;}
		}
       
        /// <summary>
        /// 指定按升序或降序进行排序
        /// </summary>
        public SortOrder SortOrder
		{
			get {return sortOrder;}
			set {sortOrder=value;}
		}
        /// <summary>
        /// 比较方法
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
		public int Compare(object x,object y)
		{
			int CompareResult;
			ListViewItem itemX=(ListViewItem)x;
			ListViewItem itemY=(ListViewItem)y;
			//在这里您可以提供自定义的排序
            CompareResult = comparer.Compare(itemX.SubItems[this.sortColumn].Text, itemY.SubItems[this.sortColumn].Text);
            
			if (this.SortOrder==SortOrder.Ascending)
				return CompareResult;
			else
				if (this.SortOrder==SortOrder.Descending)
				return (-CompareResult);
			else
				return 0;
		}



	}
}
