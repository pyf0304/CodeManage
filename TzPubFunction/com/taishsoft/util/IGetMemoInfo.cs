using System;

namespace com.taishsoft.util
{
	/// <summary>
	/// GetMemoInfo ��ժҪ˵����
	/// </summary>
	public interface IGetMemoInfo
	{
        /// <summary>
        /// ��ȡĳ�С��еı�ע��Ϣ
        /// </summary>
        /// <param name="intRow"></param>
        /// <param name="intCol"></param>
        /// <param name="Value"></param>
		void GetMemoInfo(int intRow,int intCol, string Value);
        /// <summary>
        /// ��ȡĳ�С��еı�ע��Ϣ
        /// </summary>
        /// <param name="intRow"></param>
        /// <param name="intCol"></param>
        /// <param name="Value"></param>
		void GetMemoInfos(int intRow,int intCol, string Value);
	}
}
