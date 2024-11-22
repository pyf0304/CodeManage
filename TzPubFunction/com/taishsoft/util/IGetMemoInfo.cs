using System;

namespace com.taishsoft.util
{
	/// <summary>
	/// GetMemoInfo 的摘要说明。
	/// </summary>
	public interface IGetMemoInfo
	{
        /// <summary>
        /// 获取某行、列的备注信息
        /// </summary>
        /// <param name="intRow"></param>
        /// <param name="intCol"></param>
        /// <param name="Value"></param>
		void GetMemoInfo(int intRow,int intCol, string Value);
        /// <summary>
        /// 获取某行、列的备注信息
        /// </summary>
        /// <param name="intRow"></param>
        /// <param name="intCol"></param>
        /// <param name="Value"></param>
		void GetMemoInfos(int intRow,int intCol, string Value);
	}
}
