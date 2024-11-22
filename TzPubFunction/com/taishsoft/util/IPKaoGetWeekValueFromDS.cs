using System;

namespace com.taishsoft.util
{
	/// <summary>
	/// IBindListView ��ժҪ˵����
	/// </summary>
	public  interface IPKaoGetWeekValueFromDS
	{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="intRow">�����</param>
        /// <param name="intCol">ÿ�յĽڴ�</param>
        /// <param name="intTimesliceNumPerDay">ÿ���ſε�ʱ��Ƭ</param>
        /// <returns></returns>
        string GetDGValue(int intRow, int intCol, int intTimesliceNumPerDay);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="intRow">�����</param>
        /// <param name="intCol">ÿ�յĽڴ�</param>
        /// <param name="strid_PKaoEduClass">�ſ���ѧ����ˮ��</param>
        /// <param name="shtWeekSeq">������</param>
        /// <param name="intTimesliceNumPerDay">ÿ���ſε�ʱ��Ƭ</param>
        /// <param name="strSchoolYear">ѧ��</param>
        /// <param name="strSchoolTerm">ѧ��</param>
        /// <returns></returns>
        string GetDGValue_IsShowContextMenu(int intRow, int intCol, string strid_PKaoEduClass,
            short shtWeekSeq, int intTimesliceNumPerDay, string strSchoolYear, string strSchoolTerm);
      /// <summary>
      /// 
      /// </summary>
        /// <param name="intRow">�����</param>
        /// <param name="intCol">ÿ�յĽڴ�</param>
      /// <param name="strValue"></param>
        /// <param name="intTimesliceNumPerDay">ÿ���ſε�ʱ��Ƭ</param>
      /// <returns></returns>
        string GetDGValue_IsCanSelected(int intRow, int intCol, string strValue, int intTimesliceNumPerDay);

	}
}
