using System;

namespace com.taishsoft.util
{
	/// <summary>
	/// ISetValueToDS ��ժҪ˵����
	/// </summary>
	public interface ISetValueToDS
	{
        /// <summary>
        /// ����DS��ֵ
        /// </summary>
        /// <param name="intRow">��</param>
        /// <param name="intCol">��</param>
        /// <param name="strMenuName">�˵�</param>
        /// <param name="Value">ֵ</param>
        /// <param name="Memo">��ע</param>
        /// <returns></returns>
		bool SetDSValue(int intRow, int intCol,string strMenuName,string Value,string Memo);
	}
}
