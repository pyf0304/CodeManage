using System;

namespace com.taishsoft.util
{
	/// <summary>
	/// IShceGroup 的摘要说明。
	/// </summary>
	
	
		public interface IShceGroup
		{
            /// <summary>
            /// 高ShceGroup
            /// </summary>
            /// <param name="intNum"></param>
			void GaoShceGroup(int intNum);
            /// <summary>
            /// 中ShceGroup
            /// </summary>
            /// <param name="intNum"></param>
			void ZhongShceGroup( int intNum);
            /// <summary>
            /// 低ShceGroup
            /// </summary>
            /// <param name="intNum"></param>
			void DiShceGroup(int intNum);
			//
			// TODO: 在此处添加构造函数逻辑
			//
            /// <summary>
            /// 删除ShceGroup
            /// </summary>
            /// <param name="intNum"></param>
			void DelShceGroup(int intNum);
		}
	}

