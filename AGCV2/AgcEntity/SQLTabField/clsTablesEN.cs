
///----------------------
///���ɴ���汾��2012.11.9.1
///�������ڣ�2012/11/20
///�����ߣ����Է�
///�������ƣ�AGC
///����ID��0005
///ģ����������SQL���ֶι���
///ģ��Ӣ������SQLTabField
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
    /// SQL��(Tables)
    /// </summary>
    [Serializable]
    public class clsTablesEN : clsEntityBase2
    {
        public const string CurrTabName_S = "Tables"; //��ǰ�������������صı���
        public const string CurrTabKeyFldName_S = "TabName"; //��ǰ���еĹؼ������ƣ��������صı��йؼ�����
        protected const int mintAttributeCount = 4;
        public static string[] AttributeName = new string[] { "TabName", "ColumnsNum", "DataBaseName", "PrjId" };
        //���������Ա���


        /// <summary> 
        /// ����(�ֶ�����:varchar,�ֶγ���:60,�Ƿ�ɿ�:False)
        /// </summary>
        protected string mstrTabName;

        /// <summary> 
        /// �ֶ���(�ֶ�����:int,�ֶγ���:4,�Ƿ�ɿ�:False)
        /// </summary>
        protected int mintColumnsNum;

        /// <summary> 
        /// ���ݿ���(�ֶ�����:varchar,�ֶγ���:50,�Ƿ�ɿ�:False)
        /// </summary>
        protected string mstrDataBaseName;

        /// <summary> 
        /// ����ID(�ֶ�����:char,�ֶγ���:4,�Ƿ�ɿ�:False)
        /// </summary>
        protected string mstrPrjId;

        public clsTablesEN()
        {
            SetInit();
            mbolIsCheckProperty = false;
            _CurrTabName = "Tables";
            lstKeyFldNames.Add("TabName");
        }

        public clsTablesEN(string strTabName)
        {
            if (string.IsNullOrEmpty(strTabName) == true)
            {
                throw new Exception("�ؼ��ֲ���Ϊ�ջ�null��");
            }

            mstrTabName = strTabName;
            SetInit();
            mbolIsCheckProperty = false;
            _CurrTabName = "Tables";
            lstKeyFldNames.Add("TabName");
        }

        public static int AttributeCount
        {
            get
            {
                return mintAttributeCount;
            }
        }
        public new object this[string strAttributeName]
        {
            get
            {
                if (strAttributeName == "TabName")
                {
                    return mstrTabName;
                }
                else if (strAttributeName == "ColumnsNum")
                {
                    return mintColumnsNum;
                }
                else if (strAttributeName == "DataBaseName")
                {
                    return mstrDataBaseName;
                }
                else if (strAttributeName == "PrjId")
                {
                    return mstrPrjId;
                }
                return null;
            }
            set
            {
                if (strAttributeName == "TabName")
                {
                    mstrTabName = value.ToString();
                }
                else if (strAttributeName == "ColumnsNum")
                {
                    mintColumnsNum = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "DataBaseName")
                {
                    mstrDataBaseName = value.ToString();
                }
                else if (strAttributeName == "PrjId")
                {
                    mstrPrjId = value.ToString();
                }
            }
        }
        public object this[int intIndex]
        {
            get
            {
                if ("TabName" == AttributeName[intIndex])
                {
                    return mstrTabName;
                }
                else if ("ColumnsNum" == AttributeName[intIndex])
                {
                    return mintColumnsNum;
                }
                else if ("DataBaseName" == AttributeName[intIndex])
                {
                    return mstrDataBaseName;
                }
                else if ("PrjId" == AttributeName[intIndex])
                {
                    return mstrPrjId;
                }
                return null;
            }
            set
            {
                if ("TabName" == AttributeName[intIndex])
                {
                    mstrTabName = value.ToString();
                }
                else if ("ColumnsNum" == AttributeName[intIndex])
                {
                    mintColumnsNum = TransNullToInt(value.ToString());
                }
                else if ("DataBaseName" == AttributeName[intIndex])
                {
                    mstrDataBaseName = value.ToString();
                }
                else if ("PrjId" == AttributeName[intIndex])
                {
                    mstrPrjId = value.ToString();
                }
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
        /// �ֶ���(˵��:;�ֶ�����:int;�ֶγ���:4;�Ƿ�ɿ�:False)
        /// </summary>
        public int ColumnsNum
        {
            get
            {
                return mintColumnsNum;
            }
            set
            {
                mintColumnsNum = value;
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("ColumnsNum");
            }
        }
        /// <summary>
        /// ���ݿ���(˵��:;�ֶ�����:varchar;�ֶγ���:50;�Ƿ�ɿ�:False)
        /// </summary>
        public string DataBaseName
        {
            get
            {
                return mstrDataBaseName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrDataBaseName = value;
                }
                else
                {
                    mstrDataBaseName = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("DataBaseName");
            }
        }
        /// <summary>
        /// ����ID(˵��:;�ֶ�����:char;�ֶγ���:4;�Ƿ�ɿ�:False)
        /// </summary>
        public string PrjId
        {
            get
            {
                return mstrPrjId;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPrjId = value;
                }
                else
                {
                    mstrPrjId = value;
                }
                //��¼�޸Ĺ����ֶ�
                AddUpdatedFld("PrjId");
            }
        }
    }
}