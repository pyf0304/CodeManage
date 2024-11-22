using System;

namespace com.taishsoft.util
{
	/// <summary>
	/// IFindClm 的摘要说明。
	/// </summary>
	public interface IFindClm
	{
        /// <summary>
        /// 自动发现教室
        /// </summary>
        /// <param name="intNum"></param>
		void AutoFindClm(int intNum);
        /// <summary>
        /// 手动发现教室
        /// </summary>
        /// <param name="intNum"></param>
		void ManuFindClm(int intNum);
        /// <summary>
        /// 删除发现教室
        /// </summary>
        /// <param name="intNum"></param>
		void DelFindClm(int intNum);
	}
}
