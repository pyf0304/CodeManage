using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.taishsoft.util
{
    /// <summary>
    /// 表示范围的类
    /// </summary>
    public class clsRange
    {
        private string mstrID;
        private int mintIndex;
        private int mintStartPos;
        private int mintEndPos;

        /// <summary>
        /// 开始位置
        /// </summary>
        public int StartPos
        {
            get
            {
                return mintStartPos;
            }

            set
            {
                mintStartPos = value;
            }
        }
        //结束位置
        public int EndPos
        {
            get
            {
                return mintEndPos;
            }

            set
            {
                mintEndPos = value;
            }
        }

        /// <summary>
        /// 序号
        /// </summary>
        public int Index
        {
            get
            {
                return mintIndex;
            }

            set
            {
                mintIndex = value;
            }
        }

        /// <summary>
        /// ID
        /// </summary>
        public string ID
        {
            get
            {
                return mstrID;
            }

            set
            {
                mstrID = value;
            }
        }
    }
}
