
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsge_GameLevelChapterRelaBLEx
表名:ge_GameLevelChapterRela(01120913)
生成代码版本:2021.04.13.1
生成日期:2021/04/20 15:44:15
生成者:yy
生成服务器IP:103.116.76.183
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:游戏化学习
模块英文名:GameLearn
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
using com.taishsoft.datetime;

namespace ExamLib.BusinessLogicEx
{
    public static class clsge_GameLevelChapterRelaBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objge_GameLevelChapterRelaENS">源对象</param>
        /// <returns>目标对象=>clsge_GameLevelChapterRelaEN:objge_GameLevelChapterRelaENT</returns>
        public static clsge_GameLevelChapterRelaENEx CopyToEx(this clsge_GameLevelChapterRelaEN objge_GameLevelChapterRelaENS)
        {
            try
            {
                clsge_GameLevelChapterRelaENEx objge_GameLevelChapterRelaENT = new clsge_GameLevelChapterRelaENEx();
                clsge_GameLevelChapterRelaBL.ge_GameLevelChapterRelaDA.CopyTo(objge_GameLevelChapterRelaENS, objge_GameLevelChapterRelaENT);
                return objge_GameLevelChapterRelaENT;
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
        /// <param name = "objge_GameLevelChapterRelaENS">源对象</param>
        /// <returns>目标对象=>clsge_GameLevelChapterRelaEN:objge_GameLevelChapterRelaENT</returns>
        public static clsge_GameLevelChapterRelaEN CopyTo(this clsge_GameLevelChapterRelaENEx objge_GameLevelChapterRelaENS)
        {
            try
            {
                clsge_GameLevelChapterRelaEN objge_GameLevelChapterRelaENT = new clsge_GameLevelChapterRelaEN();
                clsge_GameLevelChapterRelaBL.CopyTo(objge_GameLevelChapterRelaENS, objge_GameLevelChapterRelaENT);
                return objge_GameLevelChapterRelaENT;
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
    /// 游戏关卡章节关系表(ge_GameLevelChapterRela)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsge_GameLevelChapterRelaBLEx : clsge_GameLevelChapterRelaBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsge_GameLevelChapterRelaDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsge_GameLevelChapterRelaDAEx ge_GameLevelChapterRelaDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsge_GameLevelChapterRelaDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objge_GameLevelChapterRelaENS">源对象</param>
        /// <returns>目标对象=>clsge_GameLevelChapterRelaEN:objge_GameLevelChapterRelaENT</returns>
        public static clsge_GameLevelChapterRelaENEx CopyToEx(clsge_GameLevelChapterRelaEN objge_GameLevelChapterRelaENS)
        {
            try
            {
                clsge_GameLevelChapterRelaENEx objge_GameLevelChapterRelaENT = new clsge_GameLevelChapterRelaENEx();
                clsge_GameLevelChapterRelaBL.ge_GameLevelChapterRelaDA.CopyTo(objge_GameLevelChapterRelaENS, objge_GameLevelChapterRelaENT);
                return objge_GameLevelChapterRelaENT;
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
        public static List<clsge_GameLevelChapterRelaENEx> GetObjExLst(string strCondition)
        {
            List<clsge_GameLevelChapterRelaEN> arrObjLst = clsge_GameLevelChapterRelaBL.GetObjLst(strCondition);
            List<clsge_GameLevelChapterRelaENEx> arrObjExLst = new List<clsge_GameLevelChapterRelaENEx>();
            foreach (clsge_GameLevelChapterRelaEN objInFor in arrObjLst)
            {
                clsge_GameLevelChapterRelaENEx objge_GameLevelChapterRelaENEx = new clsge_GameLevelChapterRelaENEx();
                clsge_GameLevelChapterRelaBL.CopyTo(objInFor, objge_GameLevelChapterRelaENEx);
                arrObjExLst.Add(objge_GameLevelChapterRelaENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsge_GameLevelChapterRelaENEx GetObjExBymId(long lngmId)
        {
            clsge_GameLevelChapterRelaEN objge_GameLevelChapterRelaEN = clsge_GameLevelChapterRelaBL.GetObjBymId(lngmId);
            clsge_GameLevelChapterRelaENEx objge_GameLevelChapterRelaENEx = new clsge_GameLevelChapterRelaENEx();
            clsge_GameLevelChapterRelaBL.CopyTo(objge_GameLevelChapterRelaEN, objge_GameLevelChapterRelaENEx);
            return objge_GameLevelChapterRelaENEx;
        }

        public static bool AddNewRecordEx(clsge_GameLevelChapterRelaEN objge_GameLevelChapterRelaEN)
        {
            if (objge_GameLevelChapterRelaEN.CheckUniqueness() == false)
            {
                var strMsg = string.Format("记录已经存在!mId = [{0}]的数据已经存在!(in clsge_GameLevelChapterRelaBL.AddNewRecordBySql2)", objge_GameLevelChapterRelaEN.mId);
                throw new Exception(strMsg);
            }
            try
            {
                bool bolResult = clsge_GameLevelChapterRelaBL.AddNewRecordBySql2(objge_GameLevelChapterRelaEN);
                if (bolResult == true)
                {
                    string strCondition = string.Format("{0}='{1}'", conge_GameLevelChapterRela.GameLevelId,
                        objge_GameLevelChapterRelaEN.GameLevelId);
                    var arrge_GameLevelChapterRela = clsge_GameLevelChapterRelaBL.GetObjLst(strCondition);
                    var intQuestionNum_Ttl = arrge_GameLevelChapterRela.Sum(x => x.QuestionNum);
                    var objge_GameLevel = clsge_GameLevelBL.GetObjByGameLevelIdCache(objge_GameLevelChapterRelaEN.GameLevelId, objge_GameLevelChapterRelaEN.CourseId);
                    if (objge_GameLevel != null)
                    {
                        if (objge_GameLevel.QuestionNum != intQuestionNum_Ttl)
                        {
                            objge_GameLevel.SetQuestionNum(intQuestionNum_Ttl)
                                .SetUpdDate(clsDateTime.getTodayDateTimeStr(0))
                                .Update();
                        }
                        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
                        clsge_GameLevelBL.ReFreshCache(objge_GameLevelChapterRelaEN.CourseId);
                        if (clsge_GameLevelBL.relatedActions != null)
                        {
                            clsge_GameLevelBL.relatedActions.UpdRelaTabDate(objge_GameLevel.GameLevelId, "SetUpdDate");
                        }
                    }
                }
                return bolResult;
            }
            catch (Exception objException)
            {
                var strMsg = string.Format("(errid:Busi000030)添加记录出错, {1}.(from {0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static int DelRecordEx(string strGameLevelId, string strCourseChapterId)
        {
            string strCourseId = "";
            var strWhereCond = string.Format(" {0}='{1}' and {2} = '{3}'",
                conge_GameLevelChapterRela.GameLevelId, strGameLevelId,
              conge_GameLevelChapterRela.CourseChapterId, strCourseChapterId);
            var intCount = clsge_GameLevelChapterRelaBL.Delge_GameLevelChapterRelasByCond(strWhereCond);
            if (intCount == 0)
            {
                throw new Exception("删除失败");
            }

            string strCondition = string.Format("{0}='{1}'", conge_GameLevelChapterRela.GameLevelId,
                strGameLevelId);
            var arrge_GameLevelChapterRela = clsge_GameLevelChapterRelaBL.GetObjLst(strCondition);
            var intQuestionNum_Ttl = arrge_GameLevelChapterRela.Sum(x => x.QuestionNum);
            if (arrge_GameLevelChapterRela.Count > 0)
            {
                strCourseId = arrge_GameLevelChapterRela[0].CourseId;
                var objge_GameLevel = clsge_GameLevelBL.GetObjByGameLevelIdCache(strGameLevelId, strCourseId);
                if (objge_GameLevel != null)
                {
                    if (objge_GameLevel.QuestionNum != intQuestionNum_Ttl)
                    {
                        objge_GameLevel.SetQuestionNum(intQuestionNum_Ttl)
                            .SetUpdDate(clsDateTime.getTodayDateTimeStr(0))
                            .Update();
                    }
                    // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
                    clsge_GameLevelBL.ReFreshCache(strCourseId);
                    if (clsge_GameLevelBL.relatedActions != null)
                    {
                        clsge_GameLevelBL.relatedActions.UpdRelaTabDate(objge_GameLevel.GameLevelId, "SetUpdDate");
                    }
                }
                clsge_GameLevelChapterRelaBL.ReFreshCache(strCourseId);
            }      
            return intCount;
        }
    }
}