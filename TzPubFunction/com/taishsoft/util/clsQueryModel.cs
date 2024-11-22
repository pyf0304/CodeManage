using System;

namespace com.taishsoft.util
{
	/// <summary>
	/// clsNodeObj 的摘要说明。
	/// </summary>
	public class clsQueryModel
	{
		private System.Collections.Hashtable htAttributes = new System.Collections.Hashtable();
        /// <summary>
        /// 
        /// </summary>
        public clsQueryModel()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}
        /// <summary>
        /// 
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
				htAttributes.Add(strAttributeName, value.ToString());
			}
		}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strAttributeName"></param>
        /// <param name="objValue"></param>
        public void setProperty(string strAttributeName, object objValue)
        {
            if (htAttributes.Contains(strAttributeName) == true)
            {
                htAttributes.Remove(strAttributeName);
            }
            htAttributes.Add(strAttributeName, objValue);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strAttributeName"></param>
        /// <returns></returns>
        public object getProperty(string strAttributeName)
        {
            if (htAttributes.Contains(strAttributeName) == false)
            {
                return null;
            }
            return htAttributes[strAttributeName];
        }
	}
}
