
/*-- -- -- -- -- -- -- -- -- -- --
类名:clszx_QuestionsBLEx
表名:zx_Questions(01120722)
生成代码版本:2020.08.04.1
生成日期:2020/08/20 16:02:32
生成者:yy
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:中学生课件管理
模块英文名:ZXCourseware
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
    public static class clszx_QuestionsBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objzx_QuestionsENS">源对象</param>
        /// <returns>目标对象=>clszx_QuestionsEN:objzx_QuestionsENT</returns>
        public static clszx_QuestionsENEx CopyToEx(this clszx_QuestionsEN objzx_QuestionsENS)
        {
            try
            {
                clszx_QuestionsENEx objzx_QuestionsENT = new clszx_QuestionsENEx();
                clszx_QuestionsBL.zx_QuestionsDA.CopyTo(objzx_QuestionsENS, objzx_QuestionsENT);
                return objzx_QuestionsENT;
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
        /// <param name = "objzx_QuestionsENS">源对象</param>
        /// <returns>目标对象=>clszx_QuestionsEN:objzx_QuestionsENT</returns>
        public static clszx_QuestionsEN CopyTo(this clszx_QuestionsENEx objzx_QuestionsENS)
        {
            try
            {
                clszx_QuestionsEN objzx_QuestionsENT = new clszx_QuestionsEN();
                clszx_QuestionsBL.CopyTo(objzx_QuestionsENS, objzx_QuestionsENT);
                return objzx_QuestionsENT;
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
    /// zx_Questions(zx_Questions)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clszx_QuestionsBLEx : clszx_QuestionsBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clszx_QuestionsDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clszx_QuestionsDAEx zx_QuestionsDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clszx_QuestionsDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objzx_QuestionsENS">源对象</param>
        /// <returns>目标对象=>clszx_QuestionsEN:objzx_QuestionsENT</returns>
        public static clszx_QuestionsENEx CopyToEx(clszx_QuestionsEN objzx_QuestionsENS)
        {
            try
            {
                clszx_QuestionsENEx objzx_QuestionsENT = new clszx_QuestionsENEx();
                clszx_QuestionsBL.zx_QuestionsDA.CopyTo(objzx_QuestionsENS, objzx_QuestionsENT);
                return objzx_QuestionsENT;
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
        public static List<clszx_QuestionsENEx> GetObjExLst(string strCondition)
        {
            List<clszx_QuestionsEN> arrObjLst = clszx_QuestionsBL.GetObjLst(strCondition);
            List<clszx_QuestionsENEx> arrObjExLst = new List<clszx_QuestionsENEx>();
            foreach (clszx_QuestionsEN objInFor in arrObjLst)
            {
                clszx_QuestionsENEx objzx_QuestionsENEx = new clszx_QuestionsENEx();
                clszx_QuestionsBL.CopyTo(objInFor, objzx_QuestionsENEx);
                arrObjExLst.Add(objzx_QuestionsENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strQuestionsId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clszx_QuestionsENEx GetObjExByQuestionsId(string strQuestionsId)
        {
            clszx_QuestionsEN objzx_QuestionsEN = clszx_QuestionsBL.GetObjByzxQuestionsId(strQuestionsId);
            clszx_QuestionsENEx objzx_QuestionsENEx = new clszx_QuestionsENEx();
            clszx_QuestionsBL.CopyTo(objzx_QuestionsEN, objzx_QuestionsENEx);
            return objzx_QuestionsENEx;
        }


        /// <summary>
        /// 获取课文
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static List<clszx_QuestionsEN> GetPageNumObjLst(string strWhereCond)
        {
            List<clszx_QuestionsEN> arrObjLst = new List<clszx_QuestionsEN>();
            System.Data.DataTable objDT = null;
            objDT = GetPageNumDataTable(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clszx_QuestionsEN objzx_QuestionsEN = new clszx_QuestionsEN();

                objzx_QuestionsEN.PdfPageNum = int.Parse(objRow[conzx_Questions.PdfPageNum].ToString().Trim()); //修改用户Id
                objzx_QuestionsEN.Memo = objRow["PdfNum"].ToString().Trim(); //统计


                arrObjLst.Add(objzx_QuestionsEN);
            }
            objDT = null;
            return arrObjLst;
        }

        public static DataTable GetPageNumDataTable(string strWhereCond)
        {
            DataTable objDT = null;
            try
            {
                objDT = clszx_QuestionsDAEx.GetPageNumDataTable(strWhereCond);
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                strWhereCond,
                objException.Message);
                throw new Exception(strMsg);
            }
        }

    }
}