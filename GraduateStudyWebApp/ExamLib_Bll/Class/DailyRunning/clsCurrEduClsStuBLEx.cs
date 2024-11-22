using com.taishsoft.commdb;
using ExamLib.Entity;
 
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.taishsoft.datetime;
using ExamLib.BusinessLogic;
using com.taishsoft.common;

namespace ExamLib.BusinessLogicEx
{
    public class clsCurrEduClsStuBLEx
    {

        //

        /// <summary>
        /// 添加学生到教学班
        /// </summary>
        /// <param name="strIdStu">教学班学生流水号（主键）</param>
        /// <param name="stridCurrEduCls">IdCurrEduCls（要求唯一的字段）</param>
        /// <param name="strOperator">strOperator（操作者）</param>
        /// <returns></returns>
        public static bool AddId_Stu4EduCls(string strIdStu, string strIdCurrEduCls, string strOperator
            )
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" IdCurrEduCls = '{0}'", strIdCurrEduCls);
            sbCondition.AppendFormat(" and  IdStu = '{0}'", strIdStu);
            if (clsCurrEduClsStuBL.IsExistRecord(sbCondition.ToString()) == true)
            {
                return false;
            }
            else
            {

                clsCurrEduClsStuEN objCurrEduClsStuEN = new clsCurrEduClsStuEN();
                objCurrEduClsStuEN.IdStu = strIdStu;
                objCurrEduClsStuEN.IdCurrEduCls = strIdCurrEduCls;
                if (string.IsNullOrEmpty(strOperator) == false)
                {
                    objCurrEduClsStuEN.IsOpByTeacher = true;
                    objCurrEduClsStuEN.ModifyUserId = strOperator;
                }
                else
                {
                    objCurrEduClsStuEN.IsOpByTeacher = false;
                    objCurrEduClsStuEN.ModifyUserId = "sysuser";
                }
                objCurrEduClsStuEN.ModifyDate = clsDateTime.getTodayDateTimeStr(0);

                clsCurrEduClsStuBL.AddNewRecordBySql2(objCurrEduClsStuEN);
                return true;
            }
        }

        /// <summary>
        /// 删除学生到教学班
        /// </summary>
        /// <param name="strIdStu">教学班学生流水号（主键）</param>
        /// <param name="stridCurrEduCls">IdCurrEduCls（要求唯一的字段）</param>
        /// <param name="strOperator">strOperator（操作者）</param>
        /// <returns></returns>
        public static bool RemoveId_Stu4EduCls(string strIdStu, string stridCurrEduCls,
            string strOperator)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" IdCurrEduCls = '{0}'", stridCurrEduCls);
            sbCondition.AppendFormat(" and  IdStu = '{0}'", strIdStu);
            clsCurrEduClsStuEN objCurrEduClsStuEN = clsCurrEduClsStuBL.GetFirstObj_S(sbCondition.ToString());
            if (objCurrEduClsStuEN == null) return false;
            if (objCurrEduClsStuEN.IsOpByTeacher == true && string.IsNullOrEmpty(strOperator) == false)
            {
                clsCurrEduClsStuBL.DelRecord(objCurrEduClsStuEN.IdEduClsStu);
            }
            else if (objCurrEduClsStuEN.IsOpByTeacher == true && string.IsNullOrEmpty(strOperator) == true)
            {
                return false;
            }
            else if (objCurrEduClsStuEN.IsOpByTeacher == false)
            {
                clsCurrEduClsStuBL.DelRecord(objCurrEduClsStuEN.IdEduClsStu);
            }

            return true;

        }
        /// <summary>
        /// 检查唯一性（Uniqueness）--IdCurrEduCls(IdCurrEduCls)
        /// </summary>
        /// <param name="lngid_EduClsStu">教学班学生流水号（主键）</param>
        /// <param name="stridCurrEduCls">IdCurrEduCls（要求唯一的字段）</param>
        /// <returns></returns>
        public static bool CheckIsHaveSameStuInSameEduCls(string strIdStu, string stridCurrEduCls,
                            string strSchoolYear, string strSchoolTerm)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" IdCurrEduCls = '{0}'", stridCurrEduCls);
            sbCondition.AppendFormat(" and  IdStu = '{0}'", strIdStu);
            sbCondition.AppendFormat(" and  SchoolYear = '{0}'", strSchoolYear);
            sbCondition.AppendFormat(" and  SchoolTerm = '{0}'", strSchoolTerm);
            if (clsCurrEduClsStuBL.IsExistRecord(sbCondition.ToString()) == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// 根据学生Id获取教学班流水号列表
        /// </summary>
        /// <param name="strStuId">学号</param>
        /// <returns>教学班流水号列表</returns>
        public static List<string> GetidCurrEduClsListByStuId(string strStuId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("{0} = '{1}' And {2}='1'",
                convCurrEduClsStu.StuId, strStuId,
                convCurrEduClsStu.IsEffective);
            return clsvCurrEduClsStuBL.GetFldValue(convCurrEduClsStu.IdCurrEduCls, sbCondition.ToString());
        }

        /// <summary>
        /// 根据教学班流水号获取学生Id列表
        /// </summary>
        /// <param name="strIdCurrEduCls">教学班流水号</param>
        /// <returns>学生Id列表</returns>
        public static List<string> GetStuIDLstByIdCurrEduCls(string strIdCurrEduCls)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("{0} = '{1}'",
                convCurrEduClsStu.IdCurrEduCls, strIdCurrEduCls);
            return clsvCurrEduClsStuBL.GetFldValue(convCurrEduClsStu.StuId, sbCondition.ToString());
        }

        /// <summary>
        /// 根据学生流水号获取教学班流水号列表
        /// </summary>
        /// <param name="strId_StudentInfo">学号</param>
        /// <returns>教学班流水号列表</returns>
        public static List<string> GetidCurrEduClsListById_StudentInfo(string strId_StudentInfo)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("{0} = '{1}'",
                conCurrEduClsStu.IdStu, strId_StudentInfo);
            return clsCurrEduClsStuBL.GetFldValue(conCurrEduClsStu.IdCurrEduCls, sbCondition.ToString());
        }



        /// <summary>
        /// 根据学生Id获取该生的课程Id列表
        /// </summary>
        /// <param name="strStuId">学号</param>
        /// <param name="strSchoolYear">学年</param>
        /// <param name="strSchoolTerm">学期</param>
        /// <returns>教学班流水号列表</returns>
        public static List<string> GetCourseIdLstByStuId(string strStuId)
        {

            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("{0} = '{1}' And {2}='1'",
                convCurrEduClsStu.StuId, strStuId,
                convCurrEduClsStu.IsEffective);

            List<string> arrCourseIdLst = clsvCurrEduClsStuBL.GetFldValue(convCurrEduClsStu.CourseId, sbCondition.ToString());
            for (int i = arrCourseIdLst.Count - 1; i >= 0; i--)
            {
                if (string.IsNullOrEmpty(arrCourseIdLst[i]) == true)
                {
                    arrCourseIdLst.RemoveAt(i);
                }
            }
            return arrCourseIdLst;
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_CopyObj_S)
        /// </summary>
        /// <param name = "objCurrEduClsStuENS">源对象</param>
        /// <param name = "objCurrEduClsStuENT">目标对象</param>
        //public static void CopyTo(clsvCurrEduClsStu_JTEN objCurrEduClsStuENS, clsCurrEduClsStuEN objCurrEduClsStuENT)
        //{
        //    try
        //    {
        //        objCurrEduClsStuENT.IdEduClsStu = objCurrEduClsStuENS.IdEduClsStu; //教学班学生流水号
        //        objCurrEduClsStuENT.IdCurrEduCls = objCurrEduClsStuENS.IdCurrEduCls; //当前教学班流水号
        //        objCurrEduClsStuENT.IdStu = objCurrEduClsStuENS.IdStu; //学生流水号
        //        //objCurrEduClsStuENT.EduClsStuStateID = objCurrEduClsStuENS.EduClsStuStateID; //教学班学生状态编号
        //        //objCurrEduClsStuENT.GetScoreTimes = objCurrEduClsStuENS.GetScoreTimes; //获得成绩次数
        //        objCurrEduClsStuENT.Score = objCurrEduClsStuENS.Score; //得分
        //        objCurrEduClsStuENT.TotalScores = objCurrEduClsStuENS.TotalScores; //总分值
        //        objCurrEduClsStuENT.Ranking = objCurrEduClsStuENS.Ranking; //名次
        //        objCurrEduClsStuENT.Percentile = objCurrEduClsStuENS.Percentile; //百分位
        //        objCurrEduClsStuENT.Ranking2 = objCurrEduClsStuENS.Ranking2; //Ranking2
        //        objCurrEduClsStuENT.Percentile2 = objCurrEduClsStuENS.Percentile2; //Percentile2
        //        objCurrEduClsStuENT.Ranking3 = objCurrEduClsStuENS.Ranking3; //Ranking3
        //        objCurrEduClsStuENT.Percentile3 = objCurrEduClsStuENS.Percentile3; //Percentile3
        //        //objCurrEduClsStuENT.Confirmed = objCurrEduClsStuENS.Confirmed; //是否确认
        //        objCurrEduClsStuENT.SchoolTerm = objCurrEduClsStuENS.SchoolTerm; //学期
        //        objCurrEduClsStuENT.SchoolYear = objCurrEduClsStuENS.SchoolYear; //学年
        //        //objCurrEduClsStuENT.ExportDate = objCurrEduClsStuENS.ExportDate; //导出日期
        //        //objCurrEduClsStuENT.SignInDate = objCurrEduClsStuENS.SignInDate; //签入时间
        //        //objCurrEduClsStuENT.SignInStateID = objCurrEduClsStuENS.SignInStateID; //签入状态表流水号
        //        //objCurrEduClsStuENT.SignInUser = objCurrEduClsStuENS.SignInUser; //签入人
        //        //objCurrEduClsStuENT.IsOpByTeacher = objCurrEduClsStuENS.IsOpByTeacher; //是否教师操作
        //        objCurrEduClsStuENT.ModifyDate = objCurrEduClsStuENS.ModifyDate; //修改日期
        //        objCurrEduClsStuENT.ModifyUserId = objCurrEduClsStuENS.ModifyUserId; //修改人
        //        //objCurrEduClsStuENT.Memo = objCurrEduClsStuENS.Memo; //备注
        //    }
        //    catch (Exception objException)
        //    {
        //     string   strMsg = string.Format("(errid:Busi000045)Copy表对象数据出错!({0}->{1})\r\n{2}",
        //        clsStackTrace.GetCurrClassFunctionByLevel(2),
        //        clsStackTrace.GetCurrClassFunction(),
        //        objException.Message);
        //        throw new Exception(strMsg);
        //    }
        //}

        public static List<clsCurrEduClsStuEN> GetObjLstByidCurrEduCls(string stridCurrEduCls)
        {
            string strWhereCond = string.Format("{0}='{1}'", conCurrEduClsStu.IdCurrEduCls, stridCurrEduCls);

            List<clsCurrEduClsStuEN> arrCurrEduClsStuObjList;
            ///	2、根据条件串获取该表满足条件的DataTable；
            arrCurrEduClsStuObjList = clsCurrEduClsStuBL.GetObjLst(strWhereCond);
            ///	4、设置记录数的状态，
            ///		在本界面中是把状态显示在控件txtRecCount中。
            return arrCurrEduClsStuObjList;
        }

    }
}
