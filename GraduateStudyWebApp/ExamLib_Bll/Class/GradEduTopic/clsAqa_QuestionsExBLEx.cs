
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsAqa_QuestionsExBLEx
表名:Aqa_QuestionsEx(01120952)
* 版本:2023.10.02.1(服务器:WIN-SRV103-116)
日期:2023/10/08 16:36:32
生成者:pyf
生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:研培主题(GradEduTopic)
框架-层名:业务逻辑扩展层(CS)(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
**/
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

using com.taishsoft.comm_db_obj;
using ExamLib.Entity;
using System.Data;
using System.Data.SqlClient;
using ExamLib.DAL;
using ExamLib.BusinessLogic;
using com.taishsoft.datetime;

namespace ExamLib.BusinessLogicEx
{
    /// <summary>
    /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
    /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
    /// </summary>
    public class RelatedActions_Aqa_QuestionsExEx : RelatedActions_Aqa_QuestionsEx
    {
        public override bool UpdRelaTabDate(string strStuID, string strQuestionsId, string strOpUser)
        {
            return true;
        }
    }
    public static class clsAqa_QuestionsExBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objAqa_QuestionsExENS">源对象</param>
        /// <returns>目标对象=>clsAqa_QuestionsExEN:objAqa_QuestionsExENT</returns>
        public static clsAqa_QuestionsExENEx CopyToEx(this clsAqa_QuestionsExEN objAqa_QuestionsExENS)
        {
            try
            {
                clsAqa_QuestionsExENEx objAqa_QuestionsExENT = new clsAqa_QuestionsExENEx();
                clsAqa_QuestionsExBL.Aqa_QuestionsExDA.CopyTo(objAqa_QuestionsExENS, objAqa_QuestionsExENT);
                return objAqa_QuestionsExENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:000)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objAqa_QuestionsExENS">源对象</param>
        /// <returns>目标对象=>clsAqa_QuestionsExEN:objAqa_QuestionsExENT</returns>
        public static clsAqa_QuestionsExEN CopyTo(this clsAqa_QuestionsExENEx objAqa_QuestionsExENS)
        {
            try
            {
                clsAqa_QuestionsExEN objAqa_QuestionsExENT = new clsAqa_QuestionsExEN();
                clsAqa_QuestionsExBL.CopyTo(objAqa_QuestionsExENS, objAqa_QuestionsExENT);
                return objAqa_QuestionsExENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000019)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    /// <summary>
    /// Aqa_QuestionsEx(Aqa_QuestionsEx)
    /// 数据源类型:表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsAqa_QuestionsExBLEx : clsAqa_QuestionsExBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsAqa_QuestionsExDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsAqa_QuestionsExDAEx Aqa_QuestionsExDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsAqa_QuestionsExDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objAqa_QuestionsExENS">源对象</param>
        /// <returns>目标对象=>clsAqa_QuestionsExEN:objAqa_QuestionsExENT</returns>
        public static clsAqa_QuestionsExENEx CopyToEx(clsAqa_QuestionsExEN objAqa_QuestionsExENS)
        {
            try
            {
                clsAqa_QuestionsExENEx objAqa_QuestionsExENT = new clsAqa_QuestionsExENEx();
                clsAqa_QuestionsExBL.Aqa_QuestionsExDA.CopyTo(objAqa_QuestionsExENS, objAqa_QuestionsExENT);
                return objAqa_QuestionsExENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000020)Copy表对象数据出错,{1}.({0})",
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
        public static List<clsAqa_QuestionsExENEx> GetObjExLst(string strCondition)
        {
            List<clsAqa_QuestionsExEN> arrObjLst = clsAqa_QuestionsExBL.GetObjLst(strCondition);
            List<clsAqa_QuestionsExENEx> arrObjExLst = new List<clsAqa_QuestionsExENEx>();
            foreach (clsAqa_QuestionsExEN objInFor in arrObjLst)
            {
                clsAqa_QuestionsExENEx objAqa_QuestionsExENEx = new clsAqa_QuestionsExENEx();
                clsAqa_QuestionsExBL.CopyTo(objInFor, objAqa_QuestionsExENEx);
                arrObjExLst.Add(objAqa_QuestionsExENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strStuID">表关键字</param>
        /// <param name = "strQuestionsId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsAqa_QuestionsExENEx GetObjExByKeyLst(string strStuID, string strQuestionsId)
        {
            clsAqa_QuestionsExEN objAqa_QuestionsExEN = clsAqa_QuestionsExBL.GetObjByKeyLst(strStuID, strQuestionsId);
            clsAqa_QuestionsExENEx objAqa_QuestionsExENEx = new clsAqa_QuestionsExENEx();
            clsAqa_QuestionsExBL.CopyTo(objAqa_QuestionsExEN, objAqa_QuestionsExENEx);
            return objAqa_QuestionsExENEx;
        }

        public static bool ImportStudentInfo()
        {
            bool flag = false;
            var strCurrDate = clsDateTime.getTodayDateTimeStr(0);
            var strOpUser = "pyf";
            var arrAqa_QuestionsEx = clsAqa_QuestionsExBL.GetObjLst("1=1");
            //var arrAqa_QuestionsEx_Group = arrAqa_QuestionsEx.GroupBy(x => new { x.StuId, x.StuName }).ToList();
            var arrAqa_QuestionsEx_Group = arrAqa_QuestionsEx
          .GroupBy(s => new { s.StuId, s.StuName }) // 根据StuId和StuName进行分组
          .Select(group => group.First()) // 对每个分组选择第一个元素，即去重
          .ToList();

            foreach (var objInfor in arrAqa_QuestionsEx_Group)
            {
                //Console.WriteLine(objInfor.Key + ":");

                clsStudentInfoEN objStudentInfo = new clsStudentInfoEN();

                objStudentInfo.StuName = objInfor.StuName;
                objStudentInfo.StuId = objInfor.StuId;

                //objStudentInfo.CourseChapterId = objge_GameLevel.cou.
                objStudentInfo.UpdDate = strCurrDate;
                objStudentInfo.UpdUser = strOpUser;
                string strCondition = objStudentInfo.GetUniCondStr();
                if (clsStudentInfoBL.IsExistRecord(strCondition) == false)
                {
                    objStudentInfo.AddNewRecordWithMaxId();
                }
                else
                {
                    objStudentInfo.UpdateWithCondition(strCondition);
                }
            }


            return flag;
        }

        public static bool ImportCurrEduClsStu()
        {
            bool flag = false;
            var strCurrDate = clsDateTime.getTodayDateTimeStr(0);
            var strOpUser = "pyf";
            var arrAqa_QuestionsEx = clsAqa_QuestionsExBL.GetObjLst("1=1");
            //var arrAqa_QuestionsEx_Group = arrAqa_QuestionsEx.GroupBy(x => new { x.StuId, x.StuName }).ToList();
            var arrAqa_QuestionsEx_Group = arrAqa_QuestionsEx
          .GroupBy(s => new { s.StuId, s.StuName }) // 根据StuId和StuName进行分组
          .Select(group => group.First()) // 对每个分组选择第一个元素，即去重
          .ToList();

            foreach (var objInfor in arrAqa_QuestionsEx_Group)
            {
                //Console.WriteLine(objInfor.Key + ":");

                clsCurrEduClsStuEN objCurrEduClsStu = new clsCurrEduClsStuEN();
                string strCondition_StuId = string.Format("{0}='{1}'", conStudentInfo.StuId, objInfor.StuId);
                string strIdStu = clsStudentInfoBL.GetFirstID_S(strCondition_StuId);
                objCurrEduClsStu.IdStu = strIdStu;
                objCurrEduClsStu.IdCurrEduCls = "00000060";

                //objCurrEduClsStu.CourseChapterId = objge_GameLevel.cou.
                objCurrEduClsStu.ModifyDate = strCurrDate;
                objCurrEduClsStu.ModifyUserId = strOpUser;
                string strCondition = objCurrEduClsStu.GetUniCondStr();
                if (clsCurrEduClsStuBL.IsExistRecord(strCondition) == false)
                {
                    objCurrEduClsStu.AddNewRecord();
                }
                else
                {
                    objCurrEduClsStu.UpdateWithCondition(strCondition);
                }
            }


            return flag;
        }

        public static bool ImportUsers()
        {
            bool flag = false;
            var strCurrDate = clsDateTime.getTodayDateTimeStr(0);
            var strOpUser = "pyf";
            var arrAqa_QuestionsEx = clsAqa_QuestionsExBL.GetObjLst("1=1");
            //var arrAqa_QuestionsEx_Group = arrAqa_QuestionsEx.GroupBy(x => new { x.StuId, x.StuName }).ToList();
            var arrAqa_QuestionsEx_Group = arrAqa_QuestionsEx
          .GroupBy(s => new { s.StuId, s.StuName }) // 根据StuId和StuName进行分组
          .Select(group => group.First()) // 对每个分组选择第一个元素，即去重
          .ToList();

            foreach (var objInfor in arrAqa_QuestionsEx_Group)
            {
                //Console.WriteLine(objInfor.Key + ":");

                clsUsersEN objUsers = new clsUsersEN();

                objUsers.UserName = objInfor.StuName;
                objUsers.UserId = objInfor.StuId;
                //objUsers.StuTeacherID = objInfor.StuId;
                objUsers.UserStateId = "01";
                objUsers.Password = "111111";
                objUsers.IdentityId = "04";
                objUsers.DepartmentId = "501";
                objUsers.IsGSuser = true;
                //objUsers.IdCollege = "0039";
                objUsers.UpdDate = strCurrDate;
                objUsers.UpdUser = strOpUser;
                //objUsers.EffitiveBeginDate = strCurrDate;
                //objUsers.EffitiveEndDate = "20301231";
                //string strCondition = objUsers.GetUniCondStr();
                if (clsUsersBL.IsExist(objInfor.StuId) == false)
                {
                    objUsers.AddNewRecord();
                }
            }


            return flag;
        }

        public static bool ImportQxUsers()
        {
            bool flag = false;
            var strCurrDate = clsDateTime.getTodayDateTimeStr(0);
            var strOpUser = "pyf";
            var arrAqa_QuestionsEx = clsAqa_QuestionsExBL.GetObjLst("1=1");
            //var arrAqa_QuestionsEx_Group = arrAqa_QuestionsEx.GroupBy(x => new { x.StuId, x.StuName }).ToList();
            var arrAqa_QuestionsEx_Group = arrAqa_QuestionsEx
          .GroupBy(s => new { s.StuId, s.StuName }) // 根据StuId和StuName进行分组
          .Select(group => group.First()) // 对每个分组选择第一个元素，即去重
          .ToList();

            foreach (var objInfor in arrAqa_QuestionsEx_Group)
            {
                //Console.WriteLine(objInfor.Key + ":");

                clsQxUsersEN objQxUsers = new clsQxUsersEN();

                objQxUsers.UserName = objInfor.StuName;
                objQxUsers.UserId = objInfor.StuId;
                objQxUsers.StuTeacherId = objInfor.StuId;
                objQxUsers.UserStateId = "01";
                objQxUsers.Password = "111111";

                objQxUsers.DepartmentId = "501";
                objQxUsers.IdXzCollege = "0039";
                objQxUsers.UpdDate = strCurrDate;
                objQxUsers.UpdUser = strOpUser;
                objQxUsers.EffitiveBeginDate = strCurrDate;
                objQxUsers.EffitiveEndDate = "20301231";
                //string strCondition = objQxUsers.GetUniCondStr();
                if (clsQxUsersBL.IsExist(objInfor.StuId) == false)
                {
                    objQxUsers.AddNewRecord();
                }
            }


            return flag;
        }

        public static bool ImportQxUserRoleRelation()
        {
            bool flag = false;
            var strCurrDate = clsDateTime.getTodayDateTimeStr(0);
            var strOpUser = "pyf";
            var arrAqa_QuestionsEx = clsAqa_QuestionsExBL.GetObjLst("1=1");
            //var arrAqa_QuestionsEx_Group = arrAqa_QuestionsEx.GroupBy(x => new { x.StuId, x.StuName }).ToList();
            var arrAqa_QuestionsEx_Group = arrAqa_QuestionsEx
          .GroupBy(s => new { s.StuId, s.StuName }) // 根据StuId和StuName进行分组
          .Select(group => group.First()) // 对每个分组选择第一个元素，即去重
          .ToList();

            foreach (var objInfor in arrAqa_QuestionsEx_Group)
            {
                //Console.WriteLine(objInfor.Key + ":");

                clsQxUserRoleRelationEN objQxUserRoleRelation = new clsQxUserRoleRelationEN();

                objQxUserRoleRelation.UserId = objInfor.StuId;
                objQxUserRoleRelation.RoleId = "00620003";
                objQxUserRoleRelation.QxPrjId = "0062";
                objQxUserRoleRelation.UpdDate = strCurrDate;
                objQxUserRoleRelation.UpdUser = strOpUser;
                //string strCondition = objQxUserRoleRelation.GetUniCondStr();
                string strCondition = objQxUserRoleRelation.GetUniCondStr();
                if (clsQxUserRoleRelationBL.IsExistRecord(strCondition) == false)
                {
                    objQxUserRoleRelation.AddNewRecord();
                }
                else
                {
                    objQxUserRoleRelation.UpdateWithCondition(strCondition);
                }
            }


            return flag;
        }

        public static bool ImportQxPrjUserRelation()
        {
            bool flag = false;
            var strCurrDate = clsDateTime.getTodayDateTimeStr(0);
            var strOpUser = "pyf";
            var arrAqa_QuestionsEx = clsAqa_QuestionsExBL.GetObjLst("1=1");
            //var arrAqa_QuestionsEx_Group = arrAqa_QuestionsEx.GroupBy(x => new { x.StuId, x.StuName }).ToList();
            var arrAqa_QuestionsEx_Group = arrAqa_QuestionsEx
          .GroupBy(s => new { s.StuId, s.StuName }) // 根据StuId和StuName进行分组
          .Select(group => group.First()) // 对每个分组选择第一个元素，即去重
          .ToList();

            foreach (var objInfor in arrAqa_QuestionsEx_Group)
            {
                //Console.WriteLine(objInfor.Key + ":");
                clsQxPrjUserRelationEN objQxPrjUserRelation = new clsQxPrjUserRelationEN();

                objQxPrjUserRelation.UserId = objInfor.StuId;                
                objQxPrjUserRelation.QxPrjId = "0062";
                objQxPrjUserRelation.UpdDate = strCurrDate;
                objQxPrjUserRelation.UpdUserId = strOpUser;
                //string strCondition = objQxPrjUserRelation.GetUniCondStr();
                string strCondition = objQxPrjUserRelation.GetUniCondStr();
                if (clsQxPrjUserRelationBL.IsExistRecord(strCondition) == false)
                {
                    objQxPrjUserRelation.AddNewRecord();
                }
                else
                {
                    objQxPrjUserRelation.UpdateWithCondition(strCondition);
                }
            }


            return flag;
        }


        public static bool Importqa_Answer()
        {
            bool flag = false;
            var strCurrDate = clsDateTime.getTodayDateTimeStr(0);
            //var strOpUser = "pyf";
            var arrAqa_QuestionsEx = clsAqa_QuestionsExBL.GetObjLst("1=1");
            //var arrAqa_QuestionsEx_Group = arrAqa_QuestionsEx.GroupBy(x => new { x.StuId, x.StuName }).ToList();

            foreach (var objInfor in arrAqa_QuestionsEx)
            {
                //Console.WriteLine(objInfor.Key + ":");

                clsqa_AnswerEN objqa_Answer = new clsqa_AnswerEN();

                objqa_Answer.QuestionsId = objInfor.QuestionsId;
                objqa_Answer.AnswerContent = objInfor.StuAnswer;
                objqa_Answer.TopicId = "00000000";
                objqa_Answer.ParentId = "root";
                objqa_Answer.AnswerTypeId = "01";
                objqa_Answer.IdCurrEduCls = "00000060";
                objqa_Answer.CreateDate = strCurrDate;
                objqa_Answer.IsSubmit = true;

                objqa_Answer.UpdUser = objInfor.StuId;
                
                //objqa_Answer.CourseChapterId = objge_GameLevel.cou.
                objqa_Answer.UpdDate = strCurrDate;
                
                string strCondition = objqa_Answer.GetUniCondStr();
                if (clsqa_AnswerBL.IsExistRecord(strCondition) == false)
                {
                    objqa_Answer.AddNewRecordWithMaxId();
                }
                else
                {
                    objqa_Answer.UpdateWithCondition(strCondition);
                }
            }


            return flag;
        }

    }
}