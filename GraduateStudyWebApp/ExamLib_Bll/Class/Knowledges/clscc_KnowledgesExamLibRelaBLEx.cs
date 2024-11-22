
/*-- -- -- -- -- -- -- -- -- -- --
类名:clscc_KnowledgesExamLibRelaBLEx
表名:cc_KnowledgesExamLibRela(01120140)
生成代码版本:2021.02.03.1
生成日期:2021/02/08 17:26:24
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


namespace ExamLib.BusinessLogicEx
{
    public static class clscc_KnowledgesExamLibRelaBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objcc_KnowledgesExamLibRelaENS">源对象</param>
        /// <returns>目标对象=>clscc_KnowledgesExamLibRelaEN:objcc_KnowledgesExamLibRelaENT</returns>
        public static clscc_KnowledgesExamLibRelaENEx CopyToEx(this clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaENS)
        {
            try
            {
                clscc_KnowledgesExamLibRelaENEx objcc_KnowledgesExamLibRelaENT = new clscc_KnowledgesExamLibRelaENEx();
                clscc_KnowledgesExamLibRelaBL.cc_KnowledgesExamLibRelaDA.CopyTo(objcc_KnowledgesExamLibRelaENS, objcc_KnowledgesExamLibRelaENT);
                return objcc_KnowledgesExamLibRelaENT;
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
        /// <param name = "objcc_KnowledgesExamLibRelaENS">源对象</param>
        /// <returns>目标对象=>clscc_KnowledgesExamLibRelaEN:objcc_KnowledgesExamLibRelaENT</returns>
        public static clscc_KnowledgesExamLibRelaEN CopyTo(this clscc_KnowledgesExamLibRelaENEx objcc_KnowledgesExamLibRelaENS)
        {
            try
            {
                clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaENT = new clscc_KnowledgesExamLibRelaEN();
                clscc_KnowledgesExamLibRelaBL.CopyTo(objcc_KnowledgesExamLibRelaENS, objcc_KnowledgesExamLibRelaENT);
                return objcc_KnowledgesExamLibRelaENT;
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
    /// 知识点习题关系(cc_KnowledgesExamLibRela)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clscc_KnowledgesExamLibRelaBLEx : clscc_KnowledgesExamLibRelaBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clscc_KnowledgesExamLibRelaDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clscc_KnowledgesExamLibRelaDAEx cc_KnowledgesExamLibRelaDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clscc_KnowledgesExamLibRelaDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objcc_KnowledgesExamLibRelaENS">源对象</param>
        /// <returns>目标对象=>clscc_KnowledgesExamLibRelaEN:objcc_KnowledgesExamLibRelaENT</returns>
        public static clscc_KnowledgesExamLibRelaENEx CopyToEx(clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaENS)
        {
            try
            {
                clscc_KnowledgesExamLibRelaENEx objcc_KnowledgesExamLibRelaENT = new clscc_KnowledgesExamLibRelaENEx();
                clscc_KnowledgesExamLibRelaBL.cc_KnowledgesExamLibRelaDA.CopyTo(objcc_KnowledgesExamLibRelaENS, objcc_KnowledgesExamLibRelaENT);
                return objcc_KnowledgesExamLibRelaENT;
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
        public static List<clscc_KnowledgesExamLibRelaENEx> GetObjExLst(string strCondition)
        {
            List<clscc_KnowledgesExamLibRelaEN> arrObjLst = clscc_KnowledgesExamLibRelaBL.GetObjLst(strCondition);
            List<clscc_KnowledgesExamLibRelaENEx> arrObjExLst = new List<clscc_KnowledgesExamLibRelaENEx>();
            foreach (clscc_KnowledgesExamLibRelaEN objInFor in arrObjLst)
            {
                clscc_KnowledgesExamLibRelaENEx objcc_KnowledgesExamLibRelaENEx = new clscc_KnowledgesExamLibRelaENEx();
                clscc_KnowledgesExamLibRelaBL.CopyTo(objInFor, objcc_KnowledgesExamLibRelaENEx);
                arrObjExLst.Add(objcc_KnowledgesExamLibRelaENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clscc_KnowledgesExamLibRelaENEx GetObjExBymId(long lngmId)
        {
            clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN = clscc_KnowledgesExamLibRelaBL.GetObjBymId(lngmId);
            clscc_KnowledgesExamLibRelaENEx objcc_KnowledgesExamLibRelaENEx = new clscc_KnowledgesExamLibRelaENEx();
            clscc_KnowledgesExamLibRelaBL.CopyTo(objcc_KnowledgesExamLibRelaEN, objcc_KnowledgesExamLibRelaENEx);
            return objcc_KnowledgesExamLibRelaENEx;
        }
        //SELECT distinct(CourseKnowledgeId) FROM cc_KnowledgesExamLibRela where CourseId='00000005'
        //--查询cc_KnowledgesExamLibRela知识点习题关系表 去除重复知识点数据；
        /// <summary>
        /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
        /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)根据课程号获取最大闯关号；
        /// </summary>
        /// <param name = "strCondition">条件串</param>
        /// <returns>返回数据表DataTable</returns>
        public static List<string> GetCourseKnowledgeIdLstByCourseId(string CourseId)
        {
            try
            {
                //根据闯关号，来获取题目中对应的随机10条数据；
              List<string> arrCourseKnowledgeId = clscc_KnowledgesExamLibRelaBL.GetFldValue(concc_KnowledgesExamLibRela.CourseKnowledgeId,  $" CourseId='{ CourseId}'");
                return arrCourseKnowledgeId;
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsge_StuBatchQuesRelaDA: GetDataTable)", objException.Message));
            }


        }


        public static List<string> GetCourseKnowledgeIdLstByCourseId(string CourseId, long strQuestionId)
        {
            try
            {
                //根据闯关号，来获取题目中对应的随机10条数据；
                List<string> arrCourseKnowledgeId = clscc_KnowledgesExamLibRelaBL.GetFldValue(concc_KnowledgesExamLibRela.CourseKnowledgeId,
                    $" CourseId='{CourseId}' and {concc_KnowledgesExamLibRela.QuestionId}='{strQuestionId}'");
                return arrCourseKnowledgeId;
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsge_StuBatchQuesRelaDA: GetDataTable)", objException.Message));
            }


        }

    }
}