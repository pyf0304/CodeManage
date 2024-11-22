using System;

namespace com.taishsoft.util
{
	/// <summary>
	/// ISetValueToDS 的摘要说明。
	/// </summary>
	public interface IPk2SetValueToDS
	{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="intRow">周序号</param>
        /// <param name="intCol">每日的节次</param>
        /// <param name="strMenuName"></param>
        /// <param name="Value"></param>
        /// <param name="strReservedMemo">预留备注</param>
        /// <param name="strWeekStatusId">周状态Id</param>
        /// <param name="strCustomerWeek">用户自定义周</param>
        /// <param name="intTimesliceNumPerDay">每日排课的时间片</param>
        /// <param name="intPk2WeeksNumPerSchoolTerm">学期排课周数</param>
        /// <param name="intWeeksNumPerSchoolTerm">学期周数</param>
        /// <returns></returns>
        bool SetDSValue(int intRow, int intCol, string strMenuName, string Value, string strReservedMemo,
            string strWeekStatusId, string strCustomerWeek, 
            int intTimesliceNumPerDay,
            int intPk2WeeksNumPerSchoolTerm, int intWeeksNumPerSchoolTerm);

    }
}
