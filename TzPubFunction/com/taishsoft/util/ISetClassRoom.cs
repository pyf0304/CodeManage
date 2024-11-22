using System;

namespace com.taishsoft.util
{
	/// <summary>
	/// ISetClassRoom 的摘要说明。
	/// </summary>
	public interface ISetClassRoom
	{
        /// <summary>
        /// 设置教室
        /// </summary>
        /// <param name="id_ClassRoom">教室流水号</param>
        /// <param name="intNum">序号</param>
		void SetClassRoom(string id_ClassRoom,int intNum);
	}
}
