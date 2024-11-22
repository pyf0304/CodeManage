
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsgs_UserConfigBLEx
表名:gs_UserConfig(01120693)
生成代码版本:2020.06.27.2
生成日期:2020/07/06 20:26:37
生成者:
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:考试管理
模块英文名:ExamManage
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using ExamLib.Entity;
using System.Data;
using System.Data.SqlClient;
using ExamLib.DAL;
using ExamLib.BusinessLogic;


namespace ExamLib.BusinessLogicEx
{
    public static class clsgs_UserConfigBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objgs_UserConfigENS">源对象</param>
        /// <returns>目标对象=>clsgs_UserConfigEN:objgs_UserConfigENT</returns>
        public static clsgs_UserConfigENEx CopyToEx(this clsgs_UserConfigEN objgs_UserConfigENS)
        {
            try
            {
                clsgs_UserConfigENEx objgs_UserConfigENT = new clsgs_UserConfigENEx();
                clsgs_UserConfigBL.gs_UserConfigDA.CopyTo(objgs_UserConfigENS, objgs_UserConfigENT);
                return objgs_UserConfigENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objgs_UserConfigENS">源对象</param>
        /// <returns>目标对象=>clsgs_UserConfigEN:objgs_UserConfigENT</returns>
        public static clsgs_UserConfigEN CopyTo(this clsgs_UserConfigENEx objgs_UserConfigENS)
        {
            try
            {
                clsgs_UserConfigEN objgs_UserConfigENT = new clsgs_UserConfigEN();
                clsgs_UserConfigBL.CopyTo(objgs_UserConfigENS, objgs_UserConfigENT);
                return objgs_UserConfigENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    /// <summary>
    /// 用户配置(gs_UserConfig)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsgs_UserConfigBLEx : clsgs_UserConfigBL
    {
        #region 自带函数
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsgs_UserConfigDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsgs_UserConfigDAEx gs_UserConfigDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsgs_UserConfigDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objgs_UserConfigENS">源对象</param>
        /// <returns>目标对象=>clsgs_UserConfigEN:objgs_UserConfigENT</returns>
        public static clsgs_UserConfigENEx CopyToEx(clsgs_UserConfigEN objgs_UserConfigENS)
        {
            try
            {
                clsgs_UserConfigENEx objgs_UserConfigENT = new clsgs_UserConfigENEx();
                clsgs_UserConfigBL.gs_UserConfigDA.CopyTo(objgs_UserConfigENS, objgs_UserConfigENT);
                return objgs_UserConfigENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsgs_UserConfigENEx> GetObjExLst(string strCondition)
        {
            List<clsgs_UserConfigEN> arrObjLst = clsgs_UserConfigBL.GetObjLst(strCondition);
            List<clsgs_UserConfigENEx> arrObjExLst = new List<clsgs_UserConfigENEx>();
            foreach (clsgs_UserConfigEN objInFor in arrObjLst)
            {
                clsgs_UserConfigENEx objgs_UserConfigENEx = new clsgs_UserConfigENEx();
                clsgs_UserConfigBL.CopyTo(objInFor, objgs_UserConfigENEx);
                arrObjExLst.Add(objgs_UserConfigENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngConfigId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsgs_UserConfigENEx GetObjExByConfigId(long lngConfigId)
        {
            clsgs_UserConfigEN objgs_UserConfigEN = clsgs_UserConfigBL.GetObjByConfigId(lngConfigId);
            clsgs_UserConfigENEx objgs_UserConfigENEx = new clsgs_UserConfigENEx();
            clsgs_UserConfigBL.CopyTo(objgs_UserConfigEN, objgs_UserConfigENEx);
            return objgs_UserConfigENEx;
        }

        #endregion


        //根据传入的类型编号 和用户ID 返回分享ID
        public static string GetShareIdByConfigTypeId(string strConfigTypeId,string strUpdUser) {
            string strShareId = string.Empty;
            try
            {
                //通过类型和用户查询得到分享ID  如果存在则直接返回，如果不存在则添加后 再返回分享Id
                //根据类型和tablekey 查询是否存在此数据 存在修改 ，不存在添加；
                string strwhereCond = "ConfigTypeId='" + strConfigTypeId + "' And UpdUser='" + strUpdUser + "'";
                clsgs_UserConfigEN objgs_UserConfig = clsgs_UserConfigBL.GetFirstObj_S(strwhereCond);
                if (objgs_UserConfig == null)
                {
                    clsgs_UserConfigEN ObjNew = new clsgs_UserConfigEN();
                    ObjNew.ConfigTypeId = strConfigTypeId;
                    //只有strConfigTypeId=12时候，代表主题，shareId 默认为公开；
                    if (strConfigTypeId == "12")
                    {
                        ObjNew.ShareId = "03";//完全公开
                        strShareId = "03";
                    }
                    else
                    {
                        ObjNew.ShareId = "02";//教学班
                        strShareId = "02";
                    }
                    ObjNew.UpdUser = strUpdUser;
                    ObjNew.UpdDate = DateTime.Now.ToString("yyyy-MM-dd");

                    clsgs_UserConfigBL.AddNewRecordBySql2(ObjNew);
                }
                else
                {
                    //分享Id
                    strShareId = objgs_UserConfig.ShareId;
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取分享ID出错；, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
            return strShareId;
        }


        public static void AddgsConfig(string strConfigType,string strUpdUser) {
           
                clsgs_UserConfigEN ObjNew = new clsgs_UserConfigEN();
                ObjNew.ConfigTypeId = strConfigType;
                //只有strConfigTypeId=12时候，代表主题，shareId 默认为公开；
                if (strConfigType == "12")
                {
                    ObjNew.ShareId = "03";//完全公开
                  
                }
                else
                {
                    ObjNew.ShareId = "02";//教学班
                   
                }
                ObjNew.UpdUser = strUpdUser;
                ObjNew.UpdDate = DateTime.Now.ToString("yyyy-MM-dd");

                clsgs_UserConfigBL.AddNewRecordBySql2(ObjNew);
          
        }
        //获取对象列表时候，判断用户当前配置信息是否都存在，不存在则默认添加0710
        /// <summary>
        /// 根据条件获取对象列表
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
        /// </summary>
        /// <param name = "strWhereCond">给定条件</param>
        /// <returns>返回对象列表</returns>
        public static bool GetObjLstEx(string strUpdUser)
        {
            bool result = false;
            //首先根据传入的ID 查询类型配置表是否已经把所有配置数据都添加到表中，如果没有就自动添加；
            try { 
            string strwheregsconfig = "UpdUser='" + strUpdUser + "'";
            List<clsgs_UserConfigEN> arrgs_UserConfig = clsgs_UserConfigBL.GetObjLst(strwheregsconfig);
                WriteTextLog(arrgs_UserConfig.Count.ToString(), "获取配置", "configLog");
                string strwhere = "1=1";
            List<clsgs_ConfigTypeEN> arrgsConfigType = clsgs_ConfigTypeBL.GetObjLst(strwhere);
                WriteTextLog(arrgsConfigType.Count.ToString(), "获取配置类型", "configLog");
                #region 没有就添加
                foreach (clsgs_ConfigTypeEN objConfigType in arrgsConfigType) {
                switch (objConfigType.ConfigTypeId)
                {
                    case "01":
                       var arrSelOne = arrgs_UserConfig.Find(x => x.ConfigTypeId == "01");
                        if (arrSelOne == null)
                        {
                                WriteTextLog("", "论文", "configLog");
                                AddgsConfig(objConfigType.ConfigTypeId,strUpdUser);
                            result = true;
                        }
                       
                        break;
                    case "02":
                            var arrSeltwo = arrgs_UserConfig.Find(x => x.ConfigTypeId == "02");
                        if (arrSeltwo == null)
                        {
                                WriteTextLog("", "论文读写", "configLog");
                                AddgsConfig(objConfigType.ConfigTypeId, strUpdUser);
                            result = true;
                        }
                        break;
                    case "03":
                            var arrSelthree = arrgs_UserConfig.Find(x => x.ConfigTypeId == "03");
                        if (arrSelthree == null)
                        {
                                WriteTextLog("", "论文子观点", "configLog");
                                AddgsConfig(objConfigType.ConfigTypeId, strUpdUser);
                            result = true;
                        }
                        break;
                    case "04":
                            var arrSelfour = arrgs_UserConfig.Find(x => x.ConfigTypeId == "04");
                        if (arrSelfour == null)
                        {
                                WriteTextLog("", "个人观点", "configLog");
                                AddgsConfig(objConfigType.ConfigTypeId, strUpdUser);
                            result = true;
                        }
                        break;
                    case "05":
                            var arrSelf = arrgs_UserConfig.Find(x => x.ConfigTypeId == "05");
                        if (arrSelf == null)
                        {
                                WriteTextLog("", "专家观点", "configLog");
                                AddgsConfig(objConfigType.ConfigTypeId, strUpdUser);
                            result = true;
                        }
                        break;
                    case "06":
                            var arrSels = arrgs_UserConfig.Find(x => x.ConfigTypeId == "06");
                        if (arrSels == null)
                        {
                                WriteTextLog("", "主题概念", "configLog");
                                AddgsConfig(objConfigType.ConfigTypeId, strUpdUser);
                            result = true;
                        }
                        break;
                    case "07":
                            var arrSelse = arrgs_UserConfig.Find(x => x.ConfigTypeId == "07");
                        if (arrSelse == null)
                        {
                                WriteTextLog("", "客观事实", "configLog");
                                AddgsConfig(objConfigType.ConfigTypeId, strUpdUser);
                            result = true;
                        }
                        break;
                    case "08":
                            var arrSele = arrgs_UserConfig.Find(x => x.ConfigTypeId == "08");
                        if (arrSele == null)
                        {
                                WriteTextLog("", "客观数据", "configLog");
                                AddgsConfig(objConfigType.ConfigTypeId, strUpdUser);
                            result = true;
                        }
                        break;
                    case "09":
                            var arrSeln = arrgs_UserConfig.Find(x => x.ConfigTypeId == "09");
                        if (arrSeln == null)
                        {
                                WriteTextLog("", "技能", "configLog");
                                AddgsConfig(objConfigType.ConfigTypeId, strUpdUser);
                            result = true;
                        }
                        break;
                    case "10":
                            var arrSelt = arrgs_UserConfig.Find(x => x.ConfigTypeId == "10");
                        if (arrSelt == null)
                        {
                                WriteTextLog("", "社会关系", "configLog");
                                AddgsConfig(objConfigType.ConfigTypeId, strUpdUser);
                            result = true;
                        }
                        break;
                    case "11":
                            var arrSelel =arrgs_UserConfig.Find(x => x.ConfigTypeId == "11");
                        if (arrSelel == null)
                        {
                                WriteTextLog("", "答疑", "configLog");
                                AddgsConfig(objConfigType.ConfigTypeId, strUpdUser);
                            result = true;
                        }
                        break;
                    case "12":
                            var arrSeltv = arrgs_UserConfig.Find(x => x.ConfigTypeId == "12");
                        if (arrSeltv == null)
                        {
                                WriteTextLog("", "主题", "configLog");
                                AddgsConfig(objConfigType.ConfigTypeId, strUpdUser);
                            result = true;
                        }
                        break;
                    default:
                        string strMsg = string.Format("没有获得类型数据");
                        result = true;
                        break;

                }
            }

                #endregion

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("添加配置数据出错；, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }

            return result;
        }

        /// <summary>  
        /// 写入日志到文本文件  
        /// </summary>  
        /// <param name="action">动作</param>  
        /// <param name="strMessage">日志内容</param>  
        /// <param name="time">时间</param>  
        public static void WriteTextLog(string http, string strMessage, string Event)
        {
            string path = "D:\\IOT_log\\";
            //string path = AppDomain.CurrentDomain.BaseDirectory + @"IOT_log\";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            string fileFullPath = path + DateTime.Now.ToString("yyyy-MM-dd") + "." + Event + ".txt";
            StringBuilder str = new StringBuilder();
            str.Append("Time:    " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\r\n");
            str.Append("callbackURL:  " + http + "\r\n");
            str.Append("Message: " + strMessage + "\r\n");
            str.Append("-----------------------------------------------------------\r\n\r\n");
            StreamWriter sw;
            if (!File.Exists(fileFullPath))
            {
                sw = File.CreateText(fileFullPath);
            }
            else
            {
                sw = File.AppendText(fileFullPath);
            }
            sw.WriteLine(str.ToString());
            sw.Close();
        }

    }
}