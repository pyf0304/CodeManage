using System;
using System.Collections;

namespace com.taishsoft.util
{
	/// <summary>
	/// IBindListView ��ժҪ˵����
	/// </summary>
	public  interface IGetValueFromDialog
	{
        /// <summary>
        /// ����ֵ
        /// </summary>
        /// <param name="strValue">���õ�ֵ</param>
		void SetValue(string strValue);
	}
    /// <summary>
    /// IBindListView ��ժҪ˵����
    /// </summary>
    public interface IGetValueFromDialog2
    {
        /// <summary>
        /// ����ֵ�����ýӿڵĿ����ж���ֶ�
        /// </summary>
        /// <param name="strFieldName">�ֶ�����</param>
        /// <param name="strFieldValue">�ֶ�ֵ</param>
        void SetValue(string strFieldName, string strFieldValue);
    }
    /// <summary>
    /// IBindListView ��ժҪ˵����
    /// </summary>
    public interface IGetArrayValueFromDialog
    {
        /// <summary>
        /// ����ֵ�����ýӿڵĿ����ж���ֶ�
        /// </summary>
        /// <param name="strFieldName">�ֶ�����</param>
        /// <param name="arrValue">����ֶ�ֵ</param>
        void SetValue(string strFieldName, ArrayList arrValue);
    }
}
