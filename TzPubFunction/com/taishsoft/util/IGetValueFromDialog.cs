using System;
using System.Collections;

namespace com.taishsoft.util
{
	/// <summary>
	/// IBindListView 的摘要说明。
	/// </summary>
	public  interface IGetValueFromDialog
	{
        /// <summary>
        /// 设置值
        /// </summary>
        /// <param name="strValue">设置的值</param>
		void SetValue(string strValue);
	}
    /// <summary>
    /// IBindListView 的摘要说明。
    /// </summary>
    public interface IGetValueFromDialog2
    {
        /// <summary>
        /// 设置值，利用接口的可能有多个字段
        /// </summary>
        /// <param name="strFieldName">字段名称</param>
        /// <param name="strFieldValue">字段值</param>
        void SetValue(string strFieldName, string strFieldValue);
    }
    /// <summary>
    /// IBindListView 的摘要说明。
    /// </summary>
    public interface IGetArrayValueFromDialog
    {
        /// <summary>
        /// 设置值，利用接口的可能有多个字段
        /// </summary>
        /// <param name="strFieldName">字段名称</param>
        /// <param name="arrValue">多个字段值</param>
        void SetValue(string strFieldName, ArrayList arrValue);
    }
}
