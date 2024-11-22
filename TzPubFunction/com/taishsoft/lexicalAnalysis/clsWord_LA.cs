using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.taishsoft.lexicalAnalysis
{
    /// <summary>
    /// 词法分析-词表
    /// </summary>
 public   class clsWord_LA
    {
        private string mstrWord;
        private tzWordType mwtWordTypeId;
        private string mstrWordType;
        private string mstrTag;
        private string mstrTagName;
        private int mintLocation;
        private int mintIndex;
        private bool mbolInEffect = true;
        /// <summary>
        /// 词
        /// </summary>
        public string Word
        {
            get
            {
                return mstrWord;
            }

            set
            {
                mstrWord = value;
            }
        }
        /// <summary>
        /// 词类型
        /// </summary>
        public string WordType
        {
            get
            {
                return mstrWordType;
            }

            set
            {
                mstrWordType = value;
            }
        }
        /// <summary>
        /// 词类型位置
        /// </summary>
        public int Location
        {
            get
            {
                return mintLocation;
            }

            set
            {
                mintLocation = value;
            }
        }

        public tzWordType WordTypeId
        {
            get
            {
                return mwtWordTypeId;
            }

            set
            {
                mwtWordTypeId = value;
            }
        }
        /// <summary>
        /// 单词是否有效
        /// </summary>
        public bool InEffect
        {
            get
            {
                return mbolInEffect;
            }

            set
            {
                mbolInEffect = value;
            }
        }
        /// <summary>
        /// 当前词的序号
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
        /// 标签：例如“<  >, </  />, <? ”等
        /// </summary>
        public string Tag
        {
            get
            {
                return mstrTag;
            }

            set
            {
                mstrTag = value;
            }
        }
        /// <summary>
        /// 标签名，例如：<Layout 中的Layout
        /// </summary>
        public string TagName
        {
            get
            {
                return mstrTagName;
            }

            set
            {
                mstrTagName = value;
            }
        }
        #region aa bb

        #endregion
        public clsWord_LA(string strWord)
        {
            this.Word = strWord;
        }
    }
}
