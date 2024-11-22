
//----------------------
//生成代码版本：2015.08.06.1
//生成日期：2015/08/21
//生成者：潘以锋
//工程名称：教务管理系统2
//工程ID：0013
//模块中文名：系统基本参数
//模块英文名：BaseParameter
//注意：1、需要数据底层（PubDataBase.dll）的版本：2015.07.24.1
//       2、需要公共函数层（TzPubFunction.dll）的版本：2015.07.30.1
//========================
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;
using System.Data;
using System.Data.SqlClient;


namespace com.taishsoft.datetime
{
    /// <summary>
    /// 日期范围(DateRange)
    /// 数据源类型：SQL表
    /// </summary>
    public class clsDateRangeBL
    {
        /// <summary>
        /// 单项的XML结点标签
        /// </summary>
        public const string itemXmlNode = "DateRangeListItem";
        /// <summary>
        /// 列表的XML结点标签
        /// </summary>
        public const string listXmlNode = "DateRangeList";
        /// <summary>
        /// 集合的XML结点标签
        /// </summary>
        public const string itemsXmlNode = "Items";
        /// <summary>
        /// 静态的对象列表，用于缓存，针对记录较少，作为参数表可以使用
        /// </summary>
        public static List<clsDateRangeEN> arrDateRangeObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// </summary>
        private static int intFindFailCount = 0;

        /// <summary>
        /// 类的构造函数
        /// </summary>
        public clsDateRangeBL()
        {
        }

        #region 判断记录是否存在

        /// <summary>
        /// 功能：判断被检查的日期是否是有效日期，根据日期范围来检查
        /// </summary>
        /// <param name="objDateRangeEN">日期范围</param>
        /// <param name="strDate">被检查的日期(8位日期：20150901)</param>
        /// <returns>如果是有效日期就返回TRUE，否则返回FALSE</returns>
        public static bool IsEffectiveDate(clsDateRangeEN objDateRangeEN, string strDate)
        {
            //检测记录是否存在
//            bool bolIsEffective = false;
            if (strDate.Length != 8)
            {
                string strMsg = string.Format("被检查日期长度为:{0}, 应该为8，请检查！", strDate.Length);
                throw new Exception(strMsg);
            }
            if (objDateRangeEN.EndDate.CompareTo(strDate) < 0) return false;
            if (objDateRangeEN.BeginDate.CompareTo(strDate) > 0) return false;
            return true;
        }



        #endregion 判断记录是否存在


    }
}