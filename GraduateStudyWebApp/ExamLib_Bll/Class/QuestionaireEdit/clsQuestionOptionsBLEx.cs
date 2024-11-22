﻿
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQuestionOptionsBLEx
表名:QuestionOptions(01120188)
生成代码版本:2021.02.03.1
生成日期:2021/02/08 17:32:52
生成者:yy
生成服务器IP:103.116.76.183
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:问卷维护
模块英文名:QuestionaireEdit
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
    public static class clsQuestionOptionsBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objQuestionOptionsENS">源对象</param>
        /// <returns>目标对象=>clsQuestionOptionsEN:objQuestionOptionsENT</returns>
        public static clsQuestionOptionsENEx CopyToEx(this clsQuestionOptionsEN objQuestionOptionsENS)
        {
            try
            {
                clsQuestionOptionsENEx objQuestionOptionsENT = new clsQuestionOptionsENEx();
                clsQuestionOptionsBL.QuestionOptionsDA.CopyTo(objQuestionOptionsENS, objQuestionOptionsENT);
                return objQuestionOptionsENT;
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
        /// <param name = "objQuestionOptionsENS">源对象</param>
        /// <returns>目标对象=>clsQuestionOptionsEN:objQuestionOptionsENT</returns>
        public static clsQuestionOptionsEN CopyTo(this clsQuestionOptionsENEx objQuestionOptionsENS)
        {
            try
            {
                clsQuestionOptionsEN objQuestionOptionsENT = new clsQuestionOptionsEN();
                clsQuestionOptionsBL.CopyTo(objQuestionOptionsENS, objQuestionOptionsENT);
                return objQuestionOptionsENT;
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
    /// 题目选项(QuestionOptions)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsQuestionOptionsBLEx : clsQuestionOptionsBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQuestionOptionsDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQuestionOptionsDAEx QuestionOptionsDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQuestionOptionsDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objQuestionOptionsENS">源对象</param>
        /// <returns>目标对象=>clsQuestionOptionsEN:objQuestionOptionsENT</returns>
        public static clsQuestionOptionsENEx CopyToEx(clsQuestionOptionsEN objQuestionOptionsENS)
        {
            try
            {
                clsQuestionOptionsENEx objQuestionOptionsENT = new clsQuestionOptionsENEx();
                clsQuestionOptionsBL.QuestionOptionsDA.CopyTo(objQuestionOptionsENS, objQuestionOptionsENT);
                return objQuestionOptionsENT;
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
        public static List<clsQuestionOptionsENEx> GetObjExLst(string strCondition)
        {
            List<clsQuestionOptionsEN> arrObjLst = clsQuestionOptionsBL.GetObjLst(strCondition);
            List<clsQuestionOptionsENEx> arrObjExLst = new List<clsQuestionOptionsENEx>();
            foreach (clsQuestionOptionsEN objInFor in arrObjLst)
            {
                clsQuestionOptionsENEx objQuestionOptionsENEx = new clsQuestionOptionsENEx();
                clsQuestionOptionsBL.CopyTo(objInFor, objQuestionOptionsENEx);
                arrObjExLst.Add(objQuestionOptionsENEx);
            }
            return arrObjExLst;
        }

        public static string GetCorrectOptionIdByQuestionId(long strQuestionId, string strCourseId)
        {
            string strCondition = $"{conQuestionOptions.QuestionId} = '{strQuestionId}' and {conQuestionOptions.IsCorrect} = '1'";
            List<clsQuestionOptionsEN> arrObjLst = clsQuestionOptionsBL.GetObjLst(strCondition);
            if (arrObjLst.Count == 0) return "";
            var objQuestion = clsQuestionnaireBL.GetObjByQuestionIdCache(strQuestionId, strCourseId);
            switch (objQuestion.QuestionTypeId)
            {
                case enumQuestionType.SingleChoice_02:
                    return arrObjLst[0].QuestionOptionId;

                case enumQuestionType.MultipleChoice_03:
                    List<string> arrAnswer = arrObjLst.Select(x => x.QuestionOptionId).ToList();
                    string strAnswer = string.Join("|", arrAnswer);
                    return strAnswer;
                default:
                    throw new Exception("题型不正确！");
            }

            //return "";
        }
        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strQuestionOptionId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsQuestionOptionsENEx GetObjExByQuestionOptionId(string strQuestionOptionId)
        {
            clsQuestionOptionsEN objQuestionOptionsEN = clsQuestionOptionsBL.GetObjByQuestionOptionId(strQuestionOptionId);
            clsQuestionOptionsENEx objQuestionOptionsENEx = new clsQuestionOptionsENEx();
            clsQuestionOptionsBL.CopyTo(objQuestionOptionsEN, objQuestionOptionsENEx);
            return objQuestionOptionsENEx;
        }
    }
}