﻿
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsPrjTab_CheckExWApi
表名:PrjTab_Check(00050564)
生成代码版本:2020.06.05.2
生成日期:2020/06/11 01:11:48
生成者:
生成服务器IP:192.168.1.10
工程名称:AGC
工程ID:0005
相关数据库:tzar.tpddns.cn,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:字段、表维护
模块英文名:Table_Field
框架-层名:WA_访问扩展层(WA_AccessEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web;
using System.Collections;
using com.taishsoft.common;
using System.ServiceModel;
using AGC.Entity;
using System.Collections.Generic;
using com.taishsoft.json;
using Newtonsoft.Json.Linq;
using com.taishsoft.datetime;

namespace AGC4WApi
{
    public static class clsPrjTab_CheckExWApi_Static
    {

        public static bool AddErrMsg(this clsPrjTab_CheckEN objPrjTabEN, string strErrMsg)
        {
            if (string.IsNullOrEmpty(strErrMsg) == true) return true;
            string strCurrDate = clsDateTime.getTodayStr(0);
            string strOldErrMsg = objPrjTabEN.ErrMsg;
            strOldErrMsg = strOldErrMsg.Replace(strCurrDate, "");
            strOldErrMsg = strOldErrMsg.Replace(":", "; ");
            string strNewErrMsg = "";
            if (string.IsNullOrEmpty(strOldErrMsg) == false)
            {
                strNewErrMsg = strCurrDate + ":" + strErrMsg + strOldErrMsg;
            }
            else
            {
                strNewErrMsg = strCurrDate + ":" + strErrMsg;
            }
            int intRecNum = 0;
            try
            {
                intRecNum = clsPrjTab_CheckWApi.SetFldValue("ErrMsg", strNewErrMsg, string.Format("TabId = '{0}'", objPrjTabEN.TabId));
            }
            catch (Exception objException)
            {
                //ErrorInformationWApi.AddInformation("clsPrjTabBLEx", "AddErrMsg", objException.Message + "::" + strErrMsg, "pyfdebug");

            }
            if (intRecNum > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objPrjTab_CheckENS">源对象</param>
        /// <returns>目标对象=>clsPrjTab_CheckEN:objPrjTab_CheckENT</returns>
        public static clsPrjTab_CheckENEx CopyToEx(this clsPrjTab_CheckEN objPrjTab_CheckENS)
        {
            try
            {
                clsPrjTab_CheckENEx objPrjTab_CheckENT = new clsPrjTab_CheckENEx();
                clsPrjTab_CheckWApi.CopyTo(objPrjTab_CheckENS, objPrjTab_CheckENT);
                return objPrjTab_CheckENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Watl000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
        /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_Static_EditRecordEx)
        /// </summary>
        /// <param name = "objPrjTab_CheckEN">需要添加的实体对象</param>
        /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
        public static bool EditRecordEx(this clsPrjTab_CheckEN objPrjTab_CheckEN)
        {
            try
            {
                objPrjTab_CheckEN.sf_UpdFldSetStr = objPrjTab_CheckEN.getsf_UpdFldSetStr();
                bool bolResult = clsPrjTab_CheckExWApi.EditRecordEx(objPrjTab_CheckEN);
                // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
                clsPrjTab_CheckWApi.ReFreshCache(objPrjTab_CheckEN.PrjId);
                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Watl000006)编辑记录出错,{1}!(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    /// <summary>
    /// 工程表_检查(PrjTab_Check)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsPrjTab_CheckExWApi
    {
        private static readonly string mstrApiControllerName = "PrjTab_CheckExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsPrjTab_CheckEN> arrPrjTab_CheckObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsPrjTab_CheckExWApi()
        {
        }

        /// <summary>
        /// 修改记录
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_EditRecordEx)
        /// </summary>
        /// <returns>是否成功?</returns>
        public static bool EditRecordEx(clsPrjTab_CheckEN objPrjTab_CheckEN)
        {
            if (string.IsNullOrEmpty(objPrjTab_CheckEN.sf_UpdFldSetStr) == true)
            {
                string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
                objPrjTab_CheckEN.TabId, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            string strAction = "EditRecordEx";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            try
            {
                string strJson = clsJSON.GetJsonFromObj<clsPrjTab_CheckEN>(objPrjTab_CheckEN);
                if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
                {
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["ErrorId"] == 0)
                    {
                        var bolReturnBool = (bool)jobjReturn["ReturnBool"];
                        return bolReturnBool;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return false;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
                     HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
               clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
                throw new Exception(strMsg);
            }
        }

    }
}