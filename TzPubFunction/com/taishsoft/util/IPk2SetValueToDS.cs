using System;

namespace com.taishsoft.util
{
	/// <summary>
	/// ISetValueToDS ��ժҪ˵����
	/// </summary>
	public interface IPk2SetValueToDS
	{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="intRow">�����</param>
        /// <param name="intCol">ÿ�յĽڴ�</param>
        /// <param name="strMenuName"></param>
        /// <param name="Value"></param>
        /// <param name="strReservedMemo">Ԥ����ע</param>
        /// <param name="strWeekStatusId">��״̬Id</param>
        /// <param name="strCustomerWeek">�û��Զ�����</param>
        /// <param name="intTimesliceNumPerDay">ÿ���ſε�ʱ��Ƭ</param>
        /// <param name="intPk2WeeksNumPerSchoolTerm">ѧ���ſ�����</param>
        /// <param name="intWeeksNumPerSchoolTerm">ѧ������</param>
        /// <returns></returns>
        bool SetDSValue(int intRow, int intCol, string strMenuName, string Value, string strReservedMemo,
            string strWeekStatusId, string strCustomerWeek, 
            int intTimesliceNumPerDay,
            int intPk2WeeksNumPerSchoolTerm, int intWeeksNumPerSchoolTerm);

    }
}
