using System;

namespace com.taishsoft.util
{
	/// <summary>
	/// ���ҿ��԰�Ľӿڡ�
	/// </summary>
    public interface IFindPKaoEduCls
	{
        /// <summary>
        /// ���ҿ��԰�
        /// </summary>
        /// <param name="intNum">ʱ��Ƭ���</param>
        void FindPKaoEduCls(int intNum);
        /// <summary>
        /// ȡ����ʦ�ӿ��԰���ſ�
        /// </summary>
        /// <param name="intNum">ʱ��Ƭ���</param>
        void CancelPKao4EduCls(int intNum);

        /// <summary>
        /// ȡ��Ѳ��
        /// </summary>
        /// <param name="intNum">ʱ��Ƭ���</param>
        /// <param name="shtWeekSeq">������</param>
        void CancelXunkao(int intNum, short shtWeekSeq);
        /// <summary>
        /// ����Ѳ��
        /// </summary>
        /// <param name="intNum">ʱ��Ƭ���</param>
        void ArrangeXunkao(int intNum);

    }
}
