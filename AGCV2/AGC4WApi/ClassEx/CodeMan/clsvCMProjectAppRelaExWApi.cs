
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvCMProjectAppRelaExWApi
表名:vCMProjectAppRela(00050634)
* 版本:2024.08.31.1(服务器:WIN-SRV103-116)
日期:2024/08/31 18:01:36
生成者:pyf
生成服务器IP:
工程名称:AGC(0005)
CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
相关数据库:103.116.76.183,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:代码管理(CodeMan)
框架-层名:WA_访问扩展层(CS)(WA_AccessEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
**/
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

namespace AGC4WApi
{

    public static class clsvCMProjectAppRelaExWApi_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvCMProjectAppRelaENS">源对象</param>
        /// <returns>目标对象=>clsvCMProjectAppRelaEN:objvCMProjectAppRelaENT</returns>
        public static clsvCMProjectAppRelaENEx CopyToEx(this clsvCMProjectAppRelaEN objvCMProjectAppRelaENS)
        {
            try
            {
                clsvCMProjectAppRelaENEx objvCMProjectAppRelaENT = new clsvCMProjectAppRelaENEx();
                clsvCMProjectAppRelaWApi.CopyTo(objvCMProjectAppRelaENS, objvCMProjectAppRelaENT);
                return objvCMProjectAppRelaENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Watl000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
               
    }
    /// <summary>
    /// vCMProjectAppRela(vCMProjectAppRela)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsvCMProjectAppRelaExWApi
    {
        private static readonly string mstrApiControllerName = "vCMProjectAppRelaExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsvCMProjectAppRelaEN> arrvCMProjectAppRelaObjLstCache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;
        public static clsvCMProjectAppRelaENEx CopyToEx(clsvCMProjectAppRelaEN objvCMProjectAppRelaENS)
        {
            try
            {
                clsvCMProjectAppRelaENEx objvCMProjectAppRelaENT = new clsvCMProjectAppRelaENEx();
                clsvCMProjectAppRelaWApi.CopyTo(objvCMProjectAppRelaENS, objvCMProjectAppRelaENT);
                return objvCMProjectAppRelaENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Watl000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
        public static clsvUserCodePrjMainPathEN CopyTovUserCodePrjMainPath(clsvCMProjectAppRelaEN objvCMProjectAppRelaENS)
        {
            try
            {
                clsvUserCodePrjMainPathEN objvUserCodePrjMainPath = new clsvUserCodePrjMainPathEN();
                objvUserCodePrjMainPath.AppOrderNum = objvCMProjectAppRelaENS.AppOrderNum;
                objvUserCodePrjMainPath.CmPrjId = objvCMProjectAppRelaENS.CmPrjId;
                objvUserCodePrjMainPath.CmPrjName = objvCMProjectAppRelaENS.CmPrjName;
                objvUserCodePrjMainPath.ApplicationTypeId = objvCMProjectAppRelaENS.ApplicationTypeId;
                objvUserCodePrjMainPath.ApplicationTypeName = objvCMProjectAppRelaENS.ApplicationTypeName;
                objvUserCodePrjMainPath.ApplicationTypeSimName = objvCMProjectAppRelaENS.ApplicationTypeSimName;
                objvUserCodePrjMainPath.PrjId = objvCMProjectAppRelaENS.PrjId;
                objvUserCodePrjMainPath.UpdDate = objvCMProjectAppRelaENS.UpdDate;
                objvUserCodePrjMainPath.UpdUserId = objvCMProjectAppRelaENS.UpdUser;
                objvUserCodePrjMainPath.CMProjectAppRelaId= objvCMProjectAppRelaENS.CMProjectAppRelaId;


                return objvUserCodePrjMainPath;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Watl000002)CopyTovUserCodePrjMainPath表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
        
    }
}