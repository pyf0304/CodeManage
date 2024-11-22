
//----------------------
//生成代码版本：2015.08.06.1
//生成日期：2015/08/19
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


namespace com.taishsoft.common
{
    /// <summary>
    /// 周时间段(WeekTimeslice)
    /// 数据源类型：SQL表
    /// </summary>
    public class clsWeekTimesliceBL
    {
        /// <summary>
        /// 单项的XML结点标签
        /// </summary>
        public const string itemXmlNode = "WeekTimesliceListItem";
        /// <summary>
        /// 列表的XML结点标签
        /// </summary>
        public const string listXmlNode = "WeekTimesliceList";
        /// <summary>
        /// 集合的XML结点标签
        /// </summary>
        public const string itemsXmlNode = "Items";
        /// <summary>
        /// 静态的对象列表，用于缓存，针对记录较少，作为参数表可以使用
        /// </summary>
        public static List<clsWeekTimesliceEN> arrWeekTimesliceObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// </summary>
        private static int intFindFailCount = 0;

        /// <summary>
        /// 类的构造函数
        /// </summary>
        public clsWeekTimesliceBL()
        {
        }

     
 





        #region 判断记录是否存在

        /// <summary>
        /// 功能：判断被检查的周时间片对象是否与提供的周单片对象列表冲突
        /// </summary>
        /// <param name="arrWeekTimesliceObjLst">周时间片对象列表</param>
        /// <param name="objWeekTimesliceEN_T">被检查的周时间片对象</param>
        /// <returns>如果存在就返回TRUE，否则返回FALSE</returns>
        public static bool IsConflict(List<clsWeekTimesliceEN> arrWeekTimesliceObjLst, clsWeekTimesliceEN objWeekTimesliceEN_T)
        {
            //检测记录是否存在
            bool bolIsConflict = false;
            foreach (clsWeekTimesliceEN objWeekTimesliceEN in arrWeekTimesliceObjLst)
            {
                if (objWeekTimesliceEN.WeekDayID != objWeekTimesliceEN_T.WeekDayID) continue;
                if (objWeekTimesliceEN_T.EndTime.CompareTo( objWeekTimesliceEN.StartTime) <0) continue;
                if (objWeekTimesliceEN_T.StartTime.CompareTo( objWeekTimesliceEN.EndTime) >0) continue;
                return true;
            }
            return bolIsConflict;
        }



        #endregion 判断记录是否存在




      



        #region 有关XML操作

      
        /// <summary>
        /// 序列化一个对象列表到Xml文件
        /// 作者：潘以锋
        /// 日期：2015/08/19
        /// </summary>
        /// <param name="lstWeekTimesliceObjList">需要序列化的对象列表</param>
        /// <param name="strXmlFile">生成的XML文件</param>
        public static void SerializeObjListToXMLFile(List<clsWeekTimesliceEN> lstWeekTimesliceObjList, string strXmlFile)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = (" ");
            using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
            {
                SerializeObjListToXML(lstWeekTimesliceObjList, writer);
            }
        }

        /// <summary>
        /// 序列化一个对象列表到XmlWriter
        /// 作者：潘以锋
        /// 日期：2015/08/19
        /// </summary>
        /// <param name="lstWeekTimesliceObjList">[clsWeekTimesliceEN]对象列表</param>
        /// <param name="writer">提供的一个XmlWriter对象</param>
        /// <returns>返回是否成功?</returns>
        public static bool SerializeObjListToXML(List<clsWeekTimesliceEN> lstWeekTimesliceObjList, XmlWriter writer)
        {
            writer.WriteStartElement(clsWeekTimesliceBL.listXmlNode);
            writer.WriteStartElement(clsWeekTimesliceBL.itemsXmlNode);
            foreach (clsWeekTimesliceEN objWeekTimesliceEN in lstWeekTimesliceObjList)
            {
                clsWeekTimesliceBL.SerializeXML(writer, objWeekTimesliceEN);
            }
            writer.WriteEndElement();
            writer.WriteEndElement();
            return true;
        }

        /// <summary>
        /// 把一个对象序列化到XML中
        /// 作者：潘以锋
        /// 日期：2015/08/19
        /// </summary>
        /// <param name="writer">目标：序列化到的XmlWriter</param>
        /// <param name="objWeekTimesliceEN">数据源：需要序列化的对象</param>
        public static void SerializeXML(XmlWriter writer, clsWeekTimesliceEN objWeekTimesliceEN)
        {
            writer.WriteStartElement(clsWeekTimesliceBL.itemXmlNode);

            writer.WriteElementString(clsWeekTimesliceEN.con_mId, objWeekTimesliceEN.mId.ToString(CultureInfo.InvariantCulture));

            writer.WriteElementString(clsWeekTimesliceEN.con_WeekDayID, objWeekTimesliceEN.WeekDayID.ToString(CultureInfo.InvariantCulture));

            writer.WriteElementString(clsWeekTimesliceEN.con_StartTime, objWeekTimesliceEN.StartTime.ToString(CultureInfo.InvariantCulture));

            writer.WriteElementString(clsWeekTimesliceEN.con_EndTime, objWeekTimesliceEN.EndTime.ToString(CultureInfo.InvariantCulture));

            writer.WriteElementString(clsWeekTimesliceEN.con_Memo, objWeekTimesliceEN.Memo.ToString(CultureInfo.InvariantCulture));
            writer.WriteEndElement();
        }

        /// <summary>
        /// 从XML串中获取一个对象列表
        /// 作者：潘以锋
        /// 日期：2015/08/19
        /// </summary>
        /// <param name="strWeekTimeslicelistXml">提供的一个XML串</param>
        /// <returns>返回一个[clsWeekTimesliceEN]对象列表</returns>
        public static List<clsWeekTimesliceEN> GetWeekTimesliceObjListFromXmlStr(string strWeekTimeslicelistXml)
        {
            List<clsWeekTimesliceEN> lstWeekTimesliceObj = new List<clsWeekTimesliceEN>();
            clsWeekTimesliceEN objWeekTimesliceEN;
            UTF8Encoding enc = new UTF8Encoding();
            using (MemoryStream ms = new MemoryStream(enc.GetBytes(strWeekTimeslicelistXml)))
            {
                XmlReaderSettings xmlrs = new XmlReaderSettings();
                xmlrs.IgnoreComments = true;
                xmlrs.IgnoreWhitespace = true;
                XmlReader reader = XmlReader.Create(ms, xmlrs);
                while (reader.ReadToFollowing(clsWeekTimesliceBL.itemXmlNode))
                {
                    objWeekTimesliceEN = GetWeekTimesliceFromXml(reader);
                    lstWeekTimesliceObj.Add(objWeekTimesliceEN);
                }
            }
            return lstWeekTimesliceObj;
        }

        /// <summary>
        /// 从XML文件中获取一个对象列表
        /// 作者：潘以锋
        /// 日期：2015/08/19
        /// </summary>
        /// <param name="strXmlFileName">提供的一个XML文件</param>
        /// <returns>返回一个[clsWeekTimesliceEN]对象列表</returns>
        public static List<clsWeekTimesliceEN> GetWeekTimesliceObjListFromXmlFile(string strXmlFileName)
        {
            List<clsWeekTimesliceEN> lstWeekTimesliceObj = new List<clsWeekTimesliceEN>();
            clsWeekTimesliceEN objWeekTimesliceEN;
            XmlReader reader = XmlReader.Create(strXmlFileName);
            while (reader.ReadToFollowing(clsWeekTimesliceBL.itemXmlNode))
            {
                objWeekTimesliceEN = GetWeekTimesliceFromXml(reader);
                lstWeekTimesliceObj.Add(objWeekTimesliceEN);
            }
            return lstWeekTimesliceObj;
        }

        /// <summary>
        /// 读XmlReader到一个对象
        /// 作者：潘以锋
        /// 日期：2015/08/19
        /// </summary>
        /// <param name="reader">提供的数据源：XmlReader</param>
        /// <returns>返回的一个对象</returns>
        public static clsWeekTimesliceEN GetWeekTimesliceFromXml(System.Xml.XmlReader reader)
        {
            clsWeekTimesliceEN objWeekTimesliceEN = new clsWeekTimesliceEN();
            reader.Read();
            while (!(reader.Name == clsWeekTimesliceBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
            {
                if (reader.IsStartElement(clsWeekTimesliceEN.con_mId))
                {
                    objWeekTimesliceEN.mId = reader.ReadElementContentAsLong();
                }
                if (reader.IsStartElement(clsWeekTimesliceEN.con_WeekDayID))
                {
                    objWeekTimesliceEN.WeekDayID = reader.ReadElementContentAsString();
                }
                if (reader.IsStartElement(clsWeekTimesliceEN.con_StartTime))
                {
                    objWeekTimesliceEN.StartTime = reader.ReadElementContentAsString();
                }
                if (reader.IsStartElement(clsWeekTimesliceEN.con_EndTime))
                {
                    objWeekTimesliceEN.EndTime = reader.ReadElementContentAsString();
                }
                if (reader.IsStartElement(clsWeekTimesliceEN.con_Memo))
                {
                    objWeekTimesliceEN.Memo = reader.ReadElementContentAsString();
                }
            }
            return objWeekTimesliceEN;
        }

        /// <summary>
        /// 读Xml字符串到一个对象
        /// 作者：潘以锋
        /// 日期：2010/10/04
        /// </summary>
        /// <param name="strWeekTimesliceObjXmlStr">提供的数据源：表示一个对象的XML串</param>
        /// <returns>返回的一个对象</returns>
        public static clsWeekTimesliceEN GetWeekTimesliceFromXmlStr(string strWeekTimesliceObjXmlStr)
        {
            clsWeekTimesliceEN objWeekTimesliceEN = new clsWeekTimesliceEN();
            UTF8Encoding enc = new UTF8Encoding();
            using (MemoryStream ms = new MemoryStream(enc.GetBytes(strWeekTimesliceObjXmlStr)))
            {
                XmlReaderSettings xmlrs = new XmlReaderSettings();
                xmlrs.IgnoreComments = true;
                xmlrs.IgnoreWhitespace = true;
                XmlReader reader = XmlReader.Create(ms, xmlrs);
                while (reader.ReadToFollowing(clsWeekTimesliceBL.itemXmlNode))
                {
                    objWeekTimesliceEN = GetWeekTimesliceFromXml(reader);
                    return objWeekTimesliceEN;
                }
            }
            return objWeekTimesliceEN;
        }

       
        #endregion 有关XML操作


      }
}