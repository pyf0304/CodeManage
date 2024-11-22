using System;
using System.Collections.Generic;
using System.Text;
using com.taishsoft.commdb;
using PubDataBase;

namespace com.taishsoft.resourse
{
    /// <summary>
    /// ��Դ�ļ���
    /// </summary>
    public class clsResource
    {
        
        /// <summary>
        /// ����
        /// </summary>
        /// <param name="strKey">�ؼ���</param>
        /// <returns>�ؼ���ֵ</returns>
        public string Property(string strKey)
        {
            //if (strKey == "s001")
            //{
            //    return s001;
            //}
            //else if (strKey == "s002")
            //{
            //    return s002;
            //}
            //return "";
            System.Resources.ResourceManager rm = null;
            if (clsSqlEx.Language == "EN")
            {
                rm = new System.Resources.ResourceManager("PubDataBase.ResourceEN", this.GetType().Assembly);
            }
            else
            {
                rm = new System.Resources.ResourceManager("PubDataBase.ResourceCH", this.GetType().Assembly);
            }
            //            string strP01 = rm.GetObject("p01") as string;
            string strValue = rm.GetString(strKey);
            return strValue;
        }
        /// <summary>
        /// ����
        /// </summary>
        /// <param name="strKey">�ؼ���</param>
        /// <returns>�ؼ���ֵ</returns>
        public string Property(string strKey, string strResFileName)
        {
            //if (strKey == "s001")
            //{
            //    return s001;
            //}
            //else if (strKey == "s002")
            //{
            //    return s002;
            //}
            //return "";
            System.Resources.ResourceManager rm = null;
            rm = new System.Resources.ResourceManager(strResFileName, this.GetType().Assembly);

            //if (clsSqlEx.Language == "EN")
            //{
            //    rm = new System.Resources.ResourceManager("PubDataBase.ResourceEN", this.GetType().Assembly);
            //}
            //else
            //{
            //    rm = new System.Resources.ResourceManager("PubDataBase.ResourceCH", this.GetType().Assembly);
            //}
            //            string strP01 = rm.GetObject("p01") as string;
            string strValue = rm.GetString(strKey);
            return strValue;
        }
    }
}
