using System;

namespace com.taishsoft.util
{
	/// <summary>
	/// GetMemoInfo 的摘要说明。
	/// </summary>
	public interface IPk2GetMemoInfo
	{
        /// <summary>
        /// 获取备注的值
        /// </summary>
        /// <param name="intRow">周序号</param>
        /// <param name="intCol">每日的节次</param>
        /// <param name="Value">获取的值</param>
        /// <param name="intTimesliceNumPerDay">每日排课的时间片</param>
        /// <returns></returns>
		void GetMemoInfo(int intRow,int intCol, string Value, int intTimesliceNumPerDay);
        /// <summary>
        /// 获取备注的值
        /// </summary>
        /// <param name="intRow">周序号</param>
        /// <param name="intCol">每日的节次</param>
        /// <param name="Value">获取的值</param>
        /// <param name="intTimesliceNumPerDay">每日排课的时间片</param>
        /// <returns></returns>
        void GetMemoInfos(int intRow, int intCol, string Value, int intTimesliceNumPerDay);
	}
}
