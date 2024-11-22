using System;

namespace com.taishsoft.util
{
	/// <summary>
	/// 查找考试班的接口。
	/// </summary>
    public interface IFindPKaoEduCls
	{
        /// <summary>
        /// 查找考试班
        /// </summary>
        /// <param name="intNum">时间片序号</param>
        void FindPKaoEduCls(int intNum);
        /// <summary>
        /// 取消教师从考试班的排考
        /// </summary>
        /// <param name="intNum">时间片序号</param>
        void CancelPKao4EduCls(int intNum);

        /// <summary>
        /// 取消巡考
        /// </summary>
        /// <param name="intNum">时间片序号</param>
        /// <param name="shtWeekSeq">考试周</param>
        void CancelXunkao(int intNum, short shtWeekSeq);
        /// <summary>
        /// 安排巡考
        /// </summary>
        /// <param name="intNum">时间片序号</param>
        void ArrangeXunkao(int intNum);

    }
}
