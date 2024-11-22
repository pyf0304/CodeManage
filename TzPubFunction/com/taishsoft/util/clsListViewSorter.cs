using System;
using System.Collections;
using System.Windows.Forms;


namespace com.taishsoft.util
{
	/// <summary>
	/// mySorter ��ժҪ˵����
	/// </summary>
	public class clsListViewSorter : IComparer
	{
		private Comparer comparer;
		private int sortColumn;
		private SortOrder sortOrder;

        /// <summary>
        /// ListView����er
        /// </summary>
		public clsListViewSorter()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
			sortColumn=0;
			sortOrder=SortOrder.None;
			comparer=Comparer.Default;
		}
     
        /// <summary>
        /// ָ�������������
        /// </summary>
        public int SortColumn
		{
			get {return sortColumn;}
			set {sortColumn=value;}
		}
       
        /// <summary>
        /// ָ������������������
        /// </summary>
        public SortOrder SortOrder
		{
			get {return sortOrder;}
			set {sortOrder=value;}
		}
        /// <summary>
        /// �ȽϷ���
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
		public int Compare(object x,object y)
		{
			int CompareResult;
			ListViewItem itemX=(ListViewItem)x;
			ListViewItem itemY=(ListViewItem)y;
			//�������������ṩ�Զ��������
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
