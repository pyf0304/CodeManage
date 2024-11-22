
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvViewpointScoreBLEx
表名:vViewpointScore(01120609)
生成代码版本:2020.09.24.1
生成日期:2020/09/28 14:51:20
生成者:pyf2
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研究生培养
模块英文名:GraduateEdu
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using com.taishsoft.common;
using ExamLib.BusinessLogic;
using ExamLib.DAL;
using ExamLib.Entity;
using System;
using System.Collections.Generic;

namespace ExamLib.BusinessLogicEx
{
    public static class clsvViewpointScoreBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvViewpointScoreENS">源对象</param>
        /// <returns>目标对象=>clsvViewpointScoreEN:objvViewpointScoreENT</returns>
        public static clsvViewpointScoreENEx CopyToEx(this clsvViewpointScoreEN objvViewpointScoreENS)
        {
            try
            {
                clsvViewpointScoreENEx objvViewpointScoreENT = new clsvViewpointScoreENEx();
                clsvViewpointScoreBL.vViewpointScoreDA.CopyTo(objvViewpointScoreENS, objvViewpointScoreENT);
                return objvViewpointScoreENT;
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
        /// <param name = "objvViewpointScoreENS">源对象</param>
        /// <returns>目标对象=>clsvViewpointScoreEN:objvViewpointScoreENT</returns>
        public static clsvViewpointScoreEN CopyTo(this clsvViewpointScoreENEx objvViewpointScoreENS)
        {
            try
            {
                clsvViewpointScoreEN objvViewpointScoreENT = new clsvViewpointScoreEN();
                clsvViewpointScoreBL.CopyTo(objvViewpointScoreENS, objvViewpointScoreENT);
                return objvViewpointScoreENT;
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
    /// vViewpointScore(vViewpointScore)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsvViewpointScoreBLEx : clsvViewpointScoreBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvViewpointScoreDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvViewpointScoreDAEx vViewpointScoreDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvViewpointScoreDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsvViewpointScoreENEx> GetObjExLst(string strCondition)
        {
            List<clsvViewpointScoreEN> arrObjLst = clsvViewpointScoreBL.GetObjLst(strCondition);
            List<clsvViewpointScoreENEx> arrObjExLst = new List<clsvViewpointScoreENEx>();
            foreach (clsvViewpointScoreEN objInFor in arrObjLst)
            {
                clsvViewpointScoreENEx objvViewpointScoreENEx = new clsvViewpointScoreENEx();
                clsvViewpointScoreBL.CopyTo(objInFor, objvViewpointScoreENEx);
                arrObjExLst.Add(objvViewpointScoreENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngViewpointScoreId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvViewpointScoreENEx GetObjExByViewpointScoreId(long lngViewpointScoreId)
        {
            clsvViewpointScoreEN objvViewpointScoreEN = clsvViewpointScoreBL.GetObjByViewpointScoreId(lngViewpointScoreId);
            clsvViewpointScoreENEx objvViewpointScoreENEx = new clsvViewpointScoreENEx();
            clsvViewpointScoreBL.CopyTo(objvViewpointScoreEN, objvViewpointScoreENEx);
            return objvViewpointScoreENEx;
        }
    }
}