using com.taishsoft.common;
using System;
using System.Collections.Generic;

namespace com.taishsoft.util
{
	/// <summary>
	/// clsNodeObj 的摘要说明。
	/// </summary>
	public class clsNodeObj
	{
		private System.Collections.Hashtable htAttributes = new System.Collections.Hashtable();
        private List<clsNodeObj> arrSubNodeObjLst = null;
        /// <summary>
        /// 类的构造函数
        /// </summary>
        public clsNodeObj()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
            this.Value = "";
            this.Id = "";
            this.Name = "";
        }
        private string mstrId;
        private string mstrNodeType;
        /// <summary>
        /// Node对象的Id
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
        /// Node对象的名称
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
        /// 在子对象列表中添加新的对象
        /// </summary>
        /// <param name="myNodeObj"></param>
        public void AddNodeObj(clsNodeObj myNodeObj)
        {
            if (arrSubNodeObjLst == null) arrSubNodeObjLst = new List<clsNodeObj>();
            if (string.IsNullOrEmpty(myNodeObj.Id) == false)
            {
                if (IsExistNodeObj(myNodeObj.Id) == true)
                {
                    string strMsg = string.Format("Id:[{0}], Name:[{1}]已经在子对象列表已经存在！({2})", myNodeObj.Id, myNodeObj.Name, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
            }
            arrSubNodeObjLst.Add(myNodeObj);
        }
        /// <summary>
        /// 根据Id判断该对象在子列表中是否存在？
        /// </summary>
        /// <param name="strId">所给的Node对象Id</param>
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
        /// 向属性哈希表中添加属性
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
        /// 结点类型
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
        /// 操作类的自身信息
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
