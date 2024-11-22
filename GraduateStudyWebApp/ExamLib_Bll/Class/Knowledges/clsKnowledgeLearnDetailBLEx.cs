
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsKnowledgeLearnDetailBLEx
表名:KnowledgeLearnDetail(01120153)
生成代码版本:2021.02.03.1
生成日期:2021/02/08 17:29:49
生成者:yy
生成服务器IP:103.116.76.183
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:知识点相关
模块英文名:Knowledges
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
using com.taishsoft.json;


namespace ExamLib.BusinessLogicEx
{
    public static class clsKnowledgeLearnDetailBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objKnowledgeLearnDetailENS">源对象</param>
        /// <returns>目标对象=>clsKnowledgeLearnDetailEN:objKnowledgeLearnDetailENT</returns>
        public static clsKnowledgeLearnDetailENEx CopyToEx(this clsKnowledgeLearnDetailEN objKnowledgeLearnDetailENS)
        {
            try
            {
                clsKnowledgeLearnDetailENEx objKnowledgeLearnDetailENT = new clsKnowledgeLearnDetailENEx();
                clsKnowledgeLearnDetailBL.KnowledgeLearnDetailDA.CopyTo(objKnowledgeLearnDetailENS, objKnowledgeLearnDetailENT);
                return objKnowledgeLearnDetailENT;
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
        /// <param name = "objKnowledgeLearnDetailENS">源对象</param>
        /// <returns>目标对象=>clsKnowledgeLearnDetailEN:objKnowledgeLearnDetailENT</returns>
        public static clsKnowledgeLearnDetailEN CopyTo(this clsKnowledgeLearnDetailENEx objKnowledgeLearnDetailENS)
        {
            try
            {
                clsKnowledgeLearnDetailEN objKnowledgeLearnDetailENT = new clsKnowledgeLearnDetailEN();
                clsKnowledgeLearnDetailBL.CopyTo(objKnowledgeLearnDetailENS, objKnowledgeLearnDetailENT);
                return objKnowledgeLearnDetailENT;
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
    /// 知识点学习情况(KnowledgeLearnDetail)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsKnowledgeLearnDetailBLEx : clsKnowledgeLearnDetailBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsKnowledgeLearnDetailDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsKnowledgeLearnDetailDAEx KnowledgeLearnDetailDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsKnowledgeLearnDetailDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objKnowledgeLearnDetailENS">源对象</param>
        /// <returns>目标对象=>clsKnowledgeLearnDetailEN:objKnowledgeLearnDetailENT</returns>
        public static clsKnowledgeLearnDetailENEx CopyToEx(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailENS)
        {
            try
            {
                clsKnowledgeLearnDetailENEx objKnowledgeLearnDetailENT = new clsKnowledgeLearnDetailENEx();
                clsKnowledgeLearnDetailBL.KnowledgeLearnDetailDA.CopyTo(objKnowledgeLearnDetailENS, objKnowledgeLearnDetailENT);
                return objKnowledgeLearnDetailENT;
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
        public static List<clsKnowledgeLearnDetailENEx> GetObjExLst(string strCondition)
        {
            List<clsKnowledgeLearnDetailEN> arrObjLst = clsKnowledgeLearnDetailBL.GetObjLst(strCondition);
            List<clsKnowledgeLearnDetailENEx> arrObjExLst = new List<clsKnowledgeLearnDetailENEx>();
            foreach (clsKnowledgeLearnDetailEN objInFor in arrObjLst)
            {
                clsKnowledgeLearnDetailENEx objKnowledgeLearnDetailENEx = new clsKnowledgeLearnDetailENEx();
                clsKnowledgeLearnDetailBL.CopyTo(objInFor, objKnowledgeLearnDetailENEx);
                arrObjExLst.Add(objKnowledgeLearnDetailENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsKnowledgeLearnDetailENEx GetObjExBymId(long lngmId)
        {
            clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN = clsKnowledgeLearnDetailBL.GetObjBymId(lngmId);
            clsKnowledgeLearnDetailENEx objKnowledgeLearnDetailENEx = new clsKnowledgeLearnDetailENEx();
            clsKnowledgeLearnDetailBL.CopyTo(objKnowledgeLearnDetailEN, objKnowledgeLearnDetailENEx);
            return objKnowledgeLearnDetailENEx;
        }

        public static bool AddLearnDetail(string strCourseKnowledgeId, clsUserAnswerResultEN objInFor)
        {
            clsKnowledgeLearnDetailEN obj = new clsKnowledgeLearnDetailEN();
            obj.CourseKnowledgeId = strCourseKnowledgeId;
            obj.IdCase = objInFor.QuestionId.ToString();
            obj.IdCaseType = enumCaseType.Questionnaire_0004;
            obj.UserId = objInFor.UserId;
            obj.LearnDate = objInFor.UpdDate;
            obj.LearnModeId = enumLearnMode.DoExercises_0001;
            obj.IsRight = objInFor.IsRight;
            obj.IsMaster = objInFor.IsRight;
            obj.MasterDegree = 1;
            obj.MarkerId = objInFor.MarkerId;
            obj.MarkTime = objInFor.MarkTime;
            obj.IsAnalysis = true;
            obj.CourseId = objInFor.CourseId;
            obj.UpdUser = objInFor.UpdUser;
            obj.UpdDate = objInFor.UpdDate;
            string strCondition = obj.GetUniCondStr();
            if (clsKnowledgeLearnDetailBL.IsExistRecord(strCondition) == true)
            {
                obj.UpdateWithCondition(strCondition);
            }
            else
            {
                obj.AddNewRecord();
            }
            return true;
        }

        public static List<clsKnowledgeLearnDetailEN> GetObjLstByUserCourseKnowLedgeId(string strUserId, string strCourseKnowledgeId)
        {
            string strWhere = $"{conUserAnswerResult.UserId}='{strUserId}' And {conKnowledgeLearnDetail.CourseKnowledgeId}='{strCourseKnowledgeId}' ";
            strWhere += $" order by {conKnowledgeLearnDetail.UpdDate} Asc";
            List<clsKnowledgeLearnDetailEN> arrKnowledgeLearnDetailList = clsKnowledgeLearnDetailBL.GetObjLst(strWhere);
            return arrKnowledgeLearnDetailList;
        }
    }
}