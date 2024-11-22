
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvqa_AnswerBLEx
表名:vqa_Answer(01120635)
生成代码版本:2020.08.03.1
生成日期:2020/08/03 13:55:52
生成者:
生成服务器IP:192.168.1.10
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:互动管理
模块英文名:InteractManage
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
using System.Data;

namespace ExamLib.BusinessLogicEx
{
    public static class clsvqa_AnswerBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvqa_AnswerENS">源对象</param>
        /// <returns>目标对象=>clsvqa_AnswerEN:objvqa_AnswerENT</returns>
        public static clsvqa_AnswerENEx CopyToEx(this clsvqa_AnswerEN objvqa_AnswerENS)
        {
            try
            {
                clsvqa_AnswerENEx objvqa_AnswerENT = new clsvqa_AnswerENEx();
                clsvqa_AnswerBL.vqa_AnswerDA.CopyTo(objvqa_AnswerENS, objvqa_AnswerENT);
                return objvqa_AnswerENT;
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
        /// <param name = "objvqa_AnswerENS">源对象</param>
        /// <returns>目标对象=>clsvqa_AnswerEN:objvqa_AnswerENT</returns>
        public static clsvqa_AnswerEN CopyTo(this clsvqa_AnswerENEx objvqa_AnswerENS)
        {
            try
            {
                clsvqa_AnswerEN objvqa_AnswerENT = new clsvqa_AnswerEN();
                clsvqa_AnswerBL.CopyTo(objvqa_AnswerENS, objvqa_AnswerENT);
                return objvqa_AnswerENT;
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
    /// v答疑回答(vqa_Answer)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsvqa_AnswerBLEx : clsvqa_AnswerBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvqa_AnswerDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvqa_AnswerDAEx vqa_AnswerDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvqa_AnswerDAEx();
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
        public static List<clsvqa_AnswerENEx> GetObjExLst(string strCondition)
        {
            List<clsvqa_AnswerEN> arrObjLst = clsvqa_AnswerBL.GetObjLst(strCondition);
            List<clsvqa_AnswerENEx> arrObjExLst = new List<clsvqa_AnswerENEx>();
            foreach (clsvqa_AnswerEN objInFor in arrObjLst)
            {
                clsvqa_AnswerENEx objvqa_AnswerENEx = new clsvqa_AnswerENEx();
                clsvqa_AnswerBL.CopyTo(objInFor, objvqa_AnswerENEx);
                arrObjExLst.Add(objvqa_AnswerENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strAnswerId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvqa_AnswerENEx GetObjExByAnswerId(string strAnswerId)
        {
            clsvqa_AnswerEN objvqa_AnswerEN = clsvqa_AnswerBL.GetObjByAnswerId(strAnswerId);
            clsvqa_AnswerENEx objvqa_AnswerENEx = new clsvqa_AnswerENEx();
            clsvqa_AnswerBL.CopyTo(objvqa_AnswerEN, objvqa_AnswerENEx);
            return objvqa_AnswerENEx;
        }



        private static string strMsg = "";

        /// <summary>
        /// 获取回答的主题数量
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static List<clsvqa_AnswerEN> Getvqa_AnswerTopicIdNumObjLst(string strWhereCond)
        {
            List<clsvqa_AnswerEN> arrObjLst = new List<clsvqa_AnswerEN>();
            System.Data.DataTable objDT = null;
            objDT = Getvqa_AnswerTopicIdNumDataTable(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvqa_AnswerEN objvqa_Answer = new clsvqa_AnswerEN();

                objvqa_Answer.TopicId = objRow[convqa_Answer.TopicId].ToString().Trim(); //主题ID
                objvqa_Answer.Memo = objRow["ACount"].ToString().Trim(); //统计

                arrObjLst.Add(objvqa_Answer);
            }
            objDT = null;
            return arrObjLst;
        }

        public static DataTable Getvqa_AnswerTopicIdNumDataTable(string strWhereCond)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsvqa_AnswerDAEx.Getvqa_AnswerTopicIdNumDataTable(strWhereCond);
                return objDT;
            }
            catch (Exception objException)
            {
                strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                strWhereCond,
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 获取用户的回答问题数量
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static List<clsvqa_AnswerEN> Getvqa_AnswerUserNumObjLst(string strWhereCond)
        {
            List<clsvqa_AnswerEN> arrObjLst = new List<clsvqa_AnswerEN>();
            System.Data.DataTable objDT = null;
            objDT = Getvqa_AnswerUserNumDataTable(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvqa_AnswerEN objvqa_Answer = new clsvqa_AnswerEN();

                objvqa_Answer.UpdUser = objRow[convqa_Answer.UpdUser].ToString().Trim(); //用户Id
                objvqa_Answer.UserName = objRow[convqa_Answer.UserName].ToString().Trim(); //用户
                objvqa_Answer.Memo = objRow["UserCount"].ToString().Trim(); //统计

                arrObjLst.Add(objvqa_Answer);
            }
            objDT = null;
            return arrObjLst;
        }

        public static DataTable Getvqa_AnswerUserNumDataTable(string strWhereCond)
        {
            DataTable objDT = null;
            try
            {
                objDT = clsvqa_AnswerDAEx.Getvqa_AnswerUserNumDataTable(strWhereCond);
                return objDT;
            }
            catch (Exception objException)
            {
                strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                strWhereCond,
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        
    }
}