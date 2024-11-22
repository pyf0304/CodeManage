///----------------------
///生成代码版本：2011.05.08.1
///生成日期：2011/05/28
///生成者：潘以锋
///注意：1、需要数据底层（PubDataBase.dll）的版本：2011.05.08.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2011.05.08.1
///========================
using System;
using System.Text;
using System.Collections;
using com.taishsoft.comm_db_obj;

namespace Questionnaire.Entity
{
    /// <summary>
    /// UserClass(UserClass)
    /// </summary>
    [Serializable]
    public class clsUserClassEN : clsEntityBase2
    {
        public const string CurrTabName_S = "UserClass"; //当前表名，与该类相关的表名
        public const string CurrTabKeyFldName_S = "UserClassId"; //当前表中的关键字名称，与该类相关的表中关键字名
        protected const int mintAttributeCount = 4;
        public static string[] AttributeName = new string[] { "UserClassId", "UserClassName", "ClassNo", "UserID" };
        //以下是属性变量


        /// <summary> 
        /// UserClassId
        /// </summary>
        protected long mlngUserClassId;

        /// <summary> 
        /// UserClassName
        /// </summary>
        protected string mstrUserClassName;

        /// <summary> 
        /// ClassNo
        /// </summary>
        protected int mintClassNo;

        /// <summary> 
        /// 用户ID
        /// </summary>
        protected string mstrUserID;

        //用户指定的连接串,如果用户不指定该连接串,就用PUBDATABASE中所指定的连接串
        private static string m_strConnectString;
        public static string ConnectString
        {
            get { return m_strConnectString; }
            set { m_strConnectString = value; }
        }

        public clsUserClassEN()
        {
            SetInit();
            CurrTabName = "UserClass";
            lstKeyFldNames.Add("UserClassId");
        }

        public clsUserClassEN(long lngUserClassId)
        {

            mlngUserClassId = lngUserClassId;
            SetInit();
            CurrTabName = "UserClass";
            lstKeyFldNames.Add("UserClassId");
        }

        public static int AttributeCount
        {
            get
            {
                return mintAttributeCount;
            }
        }
        public object this[string strAttributeName]
        {
            get
            {
                if (strAttributeName == "UserClassId")
                {
                    return mlngUserClassId;
                }
                else if (strAttributeName == "UserClassName")
                {
                    return mstrUserClassName;
                }
                else if (strAttributeName == "ClassNo")
                {
                    return mintClassNo;
                }
                else if (strAttributeName == "UserID")
                {
                    return mstrUserID;
                }
                return null;
            }
            set
            {
                if (strAttributeName == "UserClassId")
                {
                    mlngUserClassId = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "UserClassName")
                {
                    mstrUserClassName = value.ToString();
                }
                else if (strAttributeName == "ClassNo")
                {
                    mintClassNo = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "UserID")
                {
                    mstrUserID = value.ToString();
                }
            }
        }
        public object this[int intIndex]
        {
            get
            {
                if ("UserClassId" == AttributeName[intIndex])
                {
                    return mlngUserClassId;
                }
                else if ("UserClassName" == AttributeName[intIndex])
                {
                    return mstrUserClassName;
                }
                else if ("ClassNo" == AttributeName[intIndex])
                {
                    return mintClassNo;
                }
                else if ("UserID" == AttributeName[intIndex])
                {
                    return mstrUserID;
                }
                return null;
            }
            set
            {
                if ("UserClassId" == AttributeName[intIndex])
                {
                    mlngUserClassId = TransNullToInt(value.ToString());
                }
                else if ("UserClassName" == AttributeName[intIndex])
                {
                    mstrUserClassName = value.ToString();
                }
                else if ("ClassNo" == AttributeName[intIndex])
                {
                    mintClassNo = TransNullToInt(value.ToString());
                }
                else if ("UserID" == AttributeName[intIndex])
                {
                    mstrUserID = value.ToString();
                }
            }
        }

        /// <summary>
        /// UserClassId
        /// </summary>
        public long UserClassId
        {
            get
            {
                return mlngUserClassId;
            }
            set
            {
                mlngUserClassId = value;
                //记录修改过的字段
                AddUpdatedFld("UserClassId");
            }
        }
        /// <summary>
        /// UserClassName
        /// </summary>
        public string UserClassName
        {
            get
            {
                return mstrUserClassName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrUserClassName = value;
                }
                else
                {
                    mstrUserClassName = value;
                }
                //记录修改过的字段
                AddUpdatedFld("UserClassName");
            }
        }
        /// <summary>
        /// ClassNo
        /// </summary>
        public int ClassNo
        {
            get
            {
                return mintClassNo;
            }
            set
            {
                mintClassNo = value;
                //记录修改过的字段
                AddUpdatedFld("ClassNo");
            }
        }
        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserID
        {
            get
            {
                return mstrUserID;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrUserID = value;
                }
                else
                {
                    mstrUserID = value;
                }
                //记录修改过的字段
                AddUpdatedFld("UserID");
            }
        }
    }
}