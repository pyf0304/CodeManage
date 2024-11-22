using com.taishsoft.common;
using System;
using System.Collections.Generic;

namespace com.taishsoft.util
{
	/// <summary>
	/// clsNodeObj ��ժҪ˵����
	/// </summary>
	public class clsNodeObj
	{
		private System.Collections.Hashtable htAttributes = new System.Collections.Hashtable();
        private List<clsNodeObj> arrSubNodeObjLst = null;
        /// <summary>
        /// ��Ĺ��캯��
        /// </summary>
        public clsNodeObj()
        {
            //
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.Value = "";
            this.Id = "";
            this.Name = "";
        }
        private string mstrId;
        private string mstrNodeType;
        /// <summary>
        /// Node�����Id
        /// </summary>
        public string Id
        {
            get
            {
                return mstrId;
            }

            set
            {
                mstrId = value;
            }
        }
        /// <summary>
        /// Node���������
        /// </summary>
        public string Name
        {
            get
            {
                return mstrName;
            }

            set
            {
                mstrName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Value
        {
            get
            {
                return mstrValue;
            }

            set
            {
                mstrValue = value;
            }
        }

        public List<clsNodeObj> SubNodeObjLst
        {
            get
            {
                return arrSubNodeObjLst;
            }

            set
            {
                arrSubNodeObjLst = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int IntTag
        {
            get
            {
                return mintIntTag;
            }

            set
            {
                mintIntTag = value;
            }
        }

        private string mstrName;
        private string mstrValue;
        private int mintIntTag;

      
        /// <summary>
        /// ���Ӷ����б�������µĶ���
        /// </summary>
        /// <param name="myNodeObj"></param>
        public void AddNodeObj(clsNodeObj myNodeObj)
        {
            if (arrSubNodeObjLst == null) arrSubNodeObjLst = new List<clsNodeObj>();
            if (string.IsNullOrEmpty(myNodeObj.Id) == false)
            {
                if (IsExistNodeObj(myNodeObj.Id) == true)
                {
                    string strMsg = string.Format("Id:[{0}], Name:[{1}]�Ѿ����Ӷ����б��Ѿ����ڣ�({2})", myNodeObj.Id, myNodeObj.Name, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
            }
            arrSubNodeObjLst.Add(myNodeObj);
        }
        /// <summary>
        /// ����Id�жϸö��������б����Ƿ���ڣ�
        /// </summary>
        /// <param name="strId">������Node����Id</param>
        /// <returns></returns>
        public bool IsExistNodeObj(string strId)
        {
            if (arrSubNodeObjLst == null) return false;
            foreach(clsNodeObj objInFor in arrSubNodeObjLst)
            {
                if (objInFor.Id == strId) return true;
            }
            return false;
        }
        /// <summary>
        /// �����Թ�ϣ�����������
        /// </summary>
        /// <param name="strKeyName"></param>
        /// <param name="strValue"></param>
		public void AddAttribute(string strKeyName, string strValue)
		{
			htAttributes.Add(strKeyName, strValue);
		}
        /// <summary>
        /// 
        /// </summary>
        public List<string> AttributeNames
        {
            get
            {
                List<string> arrAtt = new List<string>();
                foreach(string strKey in htAttributes.Keys)
                {
                    arrAtt.Add(strKey);
                }
                return arrAtt;
            }
        }

        /// <summary>
        /// �������
        /// </summary>
        public string NodeType
        {
            get
            {
                return mstrNodeType;
            }

            set
            {
                mstrNodeType = value;
            }
        }

        /// <summary>
        /// �������������Ϣ
        /// </summary>
        /// <param name="strAttributeName"></param>
        /// <returns></returns>
        public object this[string strAttributeName]
		{
			get
			{
				if (htAttributes.Contains(strAttributeName)==false)
				{
					return null;
				}
				return htAttributes[strAttributeName];
			}
			set
			{
                if (htAttributes.Contains(strAttributeName) == false)
                {
                    htAttributes.Add(strAttributeName, value.ToString());
                }
                else
                {
                    htAttributes.Remove(strAttributeName);
                    htAttributes.Add(strAttributeName, value.ToString());
                }
			}
		}
	}
}
