using System;

namespace com.taishsoft.util
{
	/// <summary>
	/// ISetClassRoom ��ժҪ˵����
	/// </summary>
	public interface ISetClassRoom
	{
        /// <summary>
        /// ���ý���
        /// </summary>
        /// <param name="id_ClassRoom">������ˮ��</param>
        /// <param name="intNum">���</param>
		void SetClassRoom(string id_ClassRoom,int intNum);
	}
}
