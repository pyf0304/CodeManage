using System;

namespace com.taishsoft.util
{
	/// <summary>
	/// IFindClm ��ժҪ˵����
	/// </summary>
	public interface IFindClm
	{
        /// <summary>
        /// �Զ����ֽ���
        /// </summary>
        /// <param name="intNum"></param>
		void AutoFindClm(int intNum);
        /// <summary>
        /// �ֶ����ֽ���
        /// </summary>
        /// <param name="intNum"></param>
		void ManuFindClm(int intNum);
        /// <summary>
        /// ɾ�����ֽ���
        /// </summary>
        /// <param name="intNum"></param>
		void DelFindClm(int intNum);
	}
}
