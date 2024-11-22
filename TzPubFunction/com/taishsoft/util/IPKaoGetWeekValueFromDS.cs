using System;

namespace com.taishsoft.util
{
	/// <summary>
	/// IBindListView 的摘要说明。
	/// </summary>
	public  interface IPKaoGetWeekValueFromDS
	{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="intRow">周序号</param>
        /// <param name="intCol">每日的节次</param>
        /// <param name="intTimesliceNumPerDay">每日排课的时间片</param>
        /// <returns></returns>
        string GetDGValue(int intRow, int intCol, int intTimesliceNumPerDay);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="intRow">周序号</param>
        /// <param name="intCol">每日的节次</param>
        /// <param name="strid_PKaoEduClass">排考教学班流水号</param>
        /// <param name="shtWeekSeq">考试周</param>
        /// <param name="intTimesliceNumPerDay">每日排课的时间片</param>
        /// <param name="strSchoolYear">学年</param>
        /// <param name="strSchoolTerm">学期</param>
        /// <returns></returns>
        string GetDGValue_IsShowContextMenu(int intRow, int intCol, string strid_PKaoEduClass,
            short shtWeekSeq, int intTimesliceNumPerDay, string strSchoolYear, string strSchoolTerm);
      /// <summary>
      /// 
      /// </summary>
        /// <param name="intRow">周序号</param>
        /// <param name="intCol">每日的节次</param>
      /// <param name="strValue"></param>
        /// <param name="intTimesliceNumPerDay">每日排课的时间片</param>
      /// <returns></returns>
        string GetDGValue_IsCanSelected(int intRow, int intCol, string strValue, int intTimesliceNumPerDay);

	}
}
