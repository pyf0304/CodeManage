using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.taishsoft.util
{
    /// <summary>
    /// 用于排名的对象
    /// </summary>
    public interface IRankObj
    {
        /// <summary>
        /// 成绩
        /// </summary>
        double Score
        {
            get;
            set;
        }

        /// <summary>
        /// 百分比
        /// </summary>
        double Percentile
        {
            get;
            set;
        }
        /// <summary>
        /// 排名
        /// </summary>
        int Ranking
        {
            get;
            set;
        }
    }
}
