using System;

namespace com.taishsoft.util
{
	/// <summary>
	/// IShceGroup ��ժҪ˵����
	/// </summary>
	
	
		public interface IShceGroup
		{
            /// <summary>
            /// ��ShceGroup
            /// </summary>
            /// <param name="intNum"></param>
			void GaoShceGroup(int intNum);
            /// <summary>
            /// ��ShceGroup
            /// </summary>
            /// <param name="intNum"></param>
			void ZhongShceGroup( int intNum);
            /// <summary>
            /// ��ShceGroup
            /// </summary>
            /// <param name="intNum"></param>
			void DiShceGroup(int intNum);
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
            /// <summary>
            /// ɾ��ShceGroup
            /// </summary>
            /// <param name="intNum"></param>
			void DelShceGroup(int intNum);
		}
	}

