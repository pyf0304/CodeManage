
///----------------------
///���ɴ���汾��2012.11.9.1
///�������ڣ�2012/11/20
///�����ߣ����Է�
///�������ƣ�AGC
///����ID��0005
///ģ�������������̹���
///ģ��Ӣ������PrjManage
///ע�⣺1����Ҫ���ݵײ㣨PubDataBase.dll���İ汾��2012.10.20.1
///       2����Ҫ���������㣨TzPubFunction.dll���İ汾��2012.10.23.1
///========================
using System;
using System.Text;
using System.Collections;
using com.taishsoft.comm_db_obj;

namespace AGC.Entity
{
    /// <summary>
    /// ��������ṹ(EduAdminTabStru)
    /// </summary>
    [Serializable]
    public class clsEduAdminTabStruEN : clsEntityBase2
    {
        public const string CurrTabName_S = "EduAdminTabStru"; //��ǰ�������������صı���
        public const string CurrTabKeyFldName_S = "mId"; //��ǰ���еĹؼ������ƣ��������صı��йؼ�����
        protected const int mintAttributeCount = 11;
        public static string[] AttributeName = new string[] { "mId", "TabName", "TabCnName", "TabMemo", "FldName", "FLdCaption", "FldType", "FldLength", "DefaValue", "IsNull", "FldMemo" };
        //���������Ա���


        /// <summary> 
        /// mId(�ֶ�����:bigint,�ֶγ���:8,�Ƿ�ɿ�:False)
        /// </summary>
        protected long mlngmId;

        /// <summary> 
        /// ����(�ֶ�����:varchar,�ֶγ���:60,�Ƿ�ɿ�:False)
        /// </summary>
        protected string mstrTabName;

        /// <summary> 
        /// ��������(�ֶ�����:varchar,�ֶγ���:60,�Ƿ�ɿ�:True)
        /// </summary>
        protected string mstrTabCnName;

        /// <summary> 
        /// TabMemo(�ֶ�����:nvarchar,�ֶγ���:510,�Ƿ�ɿ�:True)
        /// </summary>
        protected string mstrTabMemo;

        /// <summary> 
        /// �ֶ���(�ֶ�����:varchar,�ֶγ���:50,�Ƿ�ɿ�:False)
        /// </summary>
        protected string mstrFldName;

        /// <summary> 
        /// FLdCaption(�ֶ�����:nvarchar,�ֶγ���:510,�Ƿ�ɿ�:True)
        /// </summary>
        protected string mstrFLdCaption;

        /// <summary> 
        /// �ֶ�����(�ֶ�����:varchar,�ֶγ���:2,�Ƿ�ɿ�:False)
        /// </summary>
        protected string mstrFldType;

        /// <summary> 
        /// �ֶγ���(�ֶ�����:int,�ֶγ���:4,�Ƿ�ɿ�:False)
        /// </summary>
        protected int mintFldLength;

        /// <summary> 
        /// DefaValue(�ֶ�����:nvarchar,�ֶγ���:510,�Ƿ�ɿ�:True)
        /// </summary>
        protected string mstrDefaValue;

        /// <summary> 
        /// �Ƿ�ɿ�(�ֶ�����:bit,�ֶγ���:1,�Ƿ�ɿ�:False)
        /// </summary>
        protected bool mbolIsNull;

        /// <summary> 
        /// FldMemo(�ֶ�����:nvarchar,�ֶγ���:510,�Ƿ�ɿ�:True)
        /// </summary>
        protected string mstrFldMemo;
        
        public clsEduAdminTabStruEN()
        {
            SetInit();
            mbolIsCheckProperty = false;
            _CurrTabName = "EduAdminTabStru";
            lstKeyFldNames.Add("mId");
        }

        public clsEduAdminTabStruEN(long lngmId)
        {
            if (lngmId == 0)
            {
                throw new Exception("�ؼ��ֲ���Ϊ0��");
            }

            mlngmId = lngmId;
            SetInit();
            mbolIsCheckProperty = false;
            _CurrTabName = "EduAdminTabStru";
            lstKeyFldNames.Add("mId");
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
                if (strAttributeName == "mId")
                {
                    return mlngmId;
                }
                else if (strAttributeName == "TabName")
                {
                    return mstrTabName;
                }
                else if (strAttributeName == "TabCnName")
                {
                    return mstrTabCnName;
                }
                else if (strAttributeName == "TabMemo")
                {
                    return mstrTabMemo;
                }
                else if (strAttributeName == "FldName")
                {
                    return mstrFldName;
                }
                else if (strAttributeName == "FLdCaption")
                {
                    return mstrFLdCaption;
                }
                else if (strAttributeName == "FldType")
                {
                    return mstrFldType;
                }
                else if (strAttributeName == "FldLength")
                {
                    return mintFldLength;
                }
                else if (strAttributeName == "DefaValue")
                {
                    return mstrDefaValue;
                }
                else if (strAttributeName == "IsNull")
                {
                    return mbolIsNull;
                }
                else if (strAttributeName == "FldMemo")
                {
                    return mstrFldMemo;
                }
                return null;
            }
            set
            {
                if (strAttributeName == "mId")
                {
                    mlngmId = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "TabName")
                {
                    mstrTabName = value.ToString();
                }
                else if (strAttributeName == "TabCnName")
                {
                    mstrTabCnName = value.ToString();
                }
                else if (strAttributeName == "TabMemo")
                {
                    mstrTabMemo = value.ToString();
                }
                else if (strAttributeName == "FldName")
                {
                    mstrFldName = value.ToString();
                }
                else if (strAttributeName == "FLdCaption")
                {
                    mstrFLdCaption = value.ToString();
                }
                else if (strAttributeName == "FldType")
                {
                    mstrFldType = value.ToString();
                }
                else if (strAttributeName == "FldLength")
                {
                    mintFldLength = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "DefaValue")
                {
                    mstrDefaValue = value.ToString();
                }
                else if (strAttributeName == "IsNull")
                {
                    mbolIsNull = TransNullToBool(value.ToString());
                }
                else if (strAttributeName == "FldMemo")
                {
                    mstrFldMemo = value.ToString();
                }
            }
        }
        public object this[int intIndex]
        {
            get
            {
                if ("mId" == AttributeName[intIndex])
                {
                    return mlngmId;
                }
                else if ("TabName" == AttributeName[intIndex])
                {
                    return mstrTabName;
                }
                else if ("TabCnName" == AttributeName[intIndex])
                {
                    return mstrTabCnName;
                }
                else if ("TabMemo" == AttributeName[intIndex])
                {
                    return mstrTabMemo;
                }
                else if ("FldName" == AttributeName[intIndex])
                {
                    return mstrFldName;
                }
                else if ("FLdCaption" == AttributeName[intIndex])
                {
                    return mstrFLdCaption;
                }
                else if ("FldType" == AttributeName[intIndex])
                {
                    return mstrFldType;
                }
                else if ("FldLength" == AttributeName[intIndex])
                {
                    return mintFldLength;
                }
                else if ("DefaValue" == AttributeName[intIndex])
                {
                    return mstrDefaValue;
                }
                else if ("IsNull" == AttributeName[intIndex])
                {
                    return mbolIsNull;
                }
                else if ("FldMemo" == AttributeName[intIndex])
                {
                    return mstrFldMemo;
                }
                return null;
            }
            set
            {
                if ("mId" == AttributeName[intIndex])
                {
                    mlngmId = TransNullToInt(value.ToString());
                }
                else if ("TabName" == AttributeName[intIndex])
                {
                    mstrTabName = value.ToString();
                }
                else if ("TabCnName" == AttributeName[intIndex])
                {
                    mstrTabCnName = value.ToString();
                }
                else if ("TabMemo" == AttributeName[intIndex])
                {
                    mstrTabMemo = value.ToString();
                }
                else if ("FldName" == AttributeName[intIndex])
                {
                    mstrFldName = value.ToString();
                }
                else if ("FLdCaption" == AttributeName[intIndex])
                {
                    mstrFLdCaption = value.ToString();
                }
                else if ("FldType" == AttributeName[intIndex])
                {
                    mstrFldType = value.ToString();
                }
                else if ("FldLength" == AttributeName[intIndex])
                {
                    mintFldLength = TransNullToInt(value.ToString());
                }
                else if ("DefaValue" == AttributeName[intIndex])
                {
                    mstrDefaValue = value.ToString();
                }
                else if ("IsNull" == AttributeName[intIndex])
                {
                    mbolIsNull = TransNullToBool(value.ToString());
                }
                else if ("FldMemo" == AttributeName[intIndex])
                {
                    mstrFldMemo = value.ToString();
                }
            }
        }

        /// <summary>
        /// mId(˵��:;�ֶ�����:bigint;�ֶγ���:8;�Ƿ�ɿ�:False)
        /// </summary>
        public long mId
        {
            get
            {
                return mlngmId;
            }
            set
            {
                mlngmId = value;
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("mId");
            }
        }
        /// <summary>
        /// ����(˵��:;�ֶ�����:varchar;�ֶγ���:60;�Ƿ�ɿ�:False)
        /// </summary>
        public string TabName
        {
            get
            {
                return mstrTabName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrTabName = value;
                }
                else
                {
                    mstrTabName = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("TabName");
            }
        }
        /// <summary>
        /// ��������(˵��:;�ֶ�����:varchar;�ֶγ���:60;�Ƿ�ɿ�:True)
        /// </summary>
        public string TabCnName
        {
            get
            {
                return mstrTabCnName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrTabCnName = value;
                }
                else
                {
                    mstrTabCnName = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("TabCnName");
            }
        }
        /// <summary>
        /// TabMemo(˵��:;�ֶ�����:nvarchar;�ֶγ���:510;�Ƿ�ɿ�:True)
        /// </summary>
        public string TabMemo
        {
            get
            {
                return mstrTabMemo;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrTabMemo = value;
                }
                else
                {
                    mstrTabMemo = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("TabMemo");
            }
        }
        /// <summary>
        /// �ֶ���(˵��:;�ֶ�����:varchar;�ֶγ���:50;�Ƿ�ɿ�:False)
        /// </summary>
        public string FldName
        {
            get
            {
                return mstrFldName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrFldName = value;
                }
                else
                {
                    mstrFldName = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("FldName");
            }
        }
        /// <summary>
        /// FLdCaption(˵��:;�ֶ�����:nvarchar;�ֶγ���:510;�Ƿ�ɿ�:True)
        /// </summary>
        public string FLdCaption
        {
            get
            {
                return mstrFLdCaption;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrFLdCaption = value;
                }
                else
                {
                    mstrFLdCaption = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("FLdCaption");
            }
        }
        /// <summary>
        /// �ֶ�����(˵��:;�ֶ�����:varchar;�ֶγ���:2;�Ƿ�ɿ�:False)
        /// </summary>
        public string FldType
        {
            get
            {
                return mstrFldType;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrFldType = value;
                }
                else
                {
                    mstrFldType = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("FldType");
            }
        }
        /// <summary>
        /// �ֶγ���(˵��:;�ֶ�����:int;�ֶγ���:4;�Ƿ�ɿ�:False)
        /// </summary>
        public int FldLength
        {
            get
            {
                return mintFldLength;
            }
            set
            {
                mintFldLength = value;
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("FldLength");
            }
        }
        /// <summary>
        /// DefaValue(˵��:;�ֶ�����:nvarchar;�ֶγ���:510;�Ƿ�ɿ�:True)
        /// </summary>
        public string DefaValue
        {
            get
            {
                return mstrDefaValue;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrDefaValue = value;
                }
                else
                {
                    mstrDefaValue = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("DefaValue");
            }
        }
        /// <summary>
        /// �Ƿ�ɿ�(˵��:;�ֶ�����:bit;�ֶγ���:1;�Ƿ�ɿ�:False)
        /// </summary>
        public bool IsNull
        {
            get
            {
                return mbolIsNull;
            }
            set
            {
                mbolIsNull = value;
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("IsNull");
            }
        }
        /// <summary>
        /// FldMemo(˵��:;�ֶ�����:nvarchar;�ֶγ���:510;�Ƿ�ɿ�:True)
        /// </summary>
        public string FldMemo
        {
            get
            {
                return mstrFldMemo;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrFldMemo = value;
                }
                else
                {
                    mstrFldMemo = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("FldMemo");
            }
        }

    }
}