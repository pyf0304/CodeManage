using System;

namespace com.taishsoft.util
{
	/// <summary>
	/// GetMemoInfo ��ժҪ˵����
	/// </summary>
	public interface IPk2GetMemoInfo
	{
        /// <summary>
        /// ��ȡ��ע��ֵ
        /// </summary>
        /// <param name="intRow">�����</param>
        /// <param name="intCol">ÿ�յĽڴ�</param>
        /// <param name="Value">��ȡ��ֵ</param>
        /// <param name="intTimesliceNumPerDay">ÿ���ſε�ʱ��Ƭ</param>
        /// <returns></returns>
		void GetMemoInfo(int intRow,int intCol, string Value, int intTimesliceNumPerDay);
        /// <summary>
        /// ��ȡ��ע��ֵ
        /// </summary>
        /// <param name="intRow">�����</param>
        /// <param name="intCol">ÿ�յĽڴ�</param>
        /// <param name="Value">��ȡ��ֵ</param>
        /// <param name="intTimesliceNumPerDay">ÿ���ſε�ʱ��Ƭ</param>
        /// <returns></returns>
        void GetMemoInfos(int intRow, int intCol, string Value, int intTimesliceNumPerDay);
	}
}
