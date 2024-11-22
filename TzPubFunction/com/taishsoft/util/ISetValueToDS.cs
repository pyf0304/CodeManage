using System;

namespace com.taishsoft.util
{
	/// <summary>
	/// ISetValueToDS 的摘要说明。
	/// </summary>
	public interface ISetValueToDS
	{
        /// <summary>
        /// 设置DS的值
        /// </summary>
        /// <param name="intRow">行</param>
        /// <param name="intCol">列</param>
        /// <param name="strMenuName">菜单</param>
        /// <param name="Value">值</param>
        /// <param name="Memo">备注</param>
        /// <returns></returns>
		bool SetDSValue(int intRow, int intCol,string strMenuName,string Value,string Memo);
	}
}
