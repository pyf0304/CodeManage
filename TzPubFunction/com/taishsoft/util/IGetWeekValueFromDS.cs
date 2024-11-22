using System;

namespace com.taishsoft.util
{
	/// <summary>
	/// IBindListView 的摘要说明。
	/// </summary>
	public  interface IGetWeekValueFromDS
	{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="intRow"></param>
        /// <param name="intCol"></param>
        /// <returns></returns>
		string GetDGValue(int intRow, int intCol);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="intRow"></param>
        /// <param name="intCol"></param>
        /// <param name="strid_EduClassTask"></param>
        /// <returns></returns>
        string GetDGValue_IsShowContextMenu(int intRow, int intCol, string strid_EduClassTask);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="intRow"></param>
        /// <param name="intCol"></param>
        /// <param name="strValue"></param>
        /// <returns></returns>
        string GetDGValue_IsCanSelected(int intRow, int intCol, string strValue);

	}
}
