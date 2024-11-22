using ExamLib.DAL;
using ExamLib.Entity;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExamLib.BusinessLogic;

namespace ExamLib.BusinessLogicEx
{
 public   class clsContentTypeBLEx: clsContentTypeBL
    {
        /// <summary>
        /// 根据表名和字段名获取内容类型对象
        /// </summary>
        /// <param name="strTableName"></param>
        /// <param name="strFldName"></param>
        /// <returns></returns>
        public static clsContentTypeEN GetContentTypeObjByTableNameAndFldName(string strTableName, string strFldName)
        {
            string strCondition = string.Format("{0}='{1}' And {2}='{3}'",
                conContentType.TableName, strTableName,
                conContentType.FldName, strFldName);
            clsContentTypeEN objContentTypeEN = clsContentTypeBL.GetFirstObj_S(strCondition);
            return objContentTypeEN;
        }

        public static clsContentTypeEN GetContentTypeObjByTableNameAndFldName_Cache(string strTableName, string strFldName)
        {
            //string strWhereCond = string.Format("1 = 1 order by ContentTypeId");
            //if(arrContentTypeObjLst_Cache == null)
            //{
            //    arrContentTypeObjLst_Cache = new clsContentTypeDA().GetObjLst(strWhereCond);
            //}
            //foreach (clsContentTypeEN objContentTypeEN in arrContentTypeObjLst_Cache)
            //{
            //    if (objContentTypeEN.TableName == strTableName && objContentTypeEN.FldName == strFldName)
            //    {
          
            //        return objContentTypeEN;
            //    }
            //}
            return null;
        }
    }
}
