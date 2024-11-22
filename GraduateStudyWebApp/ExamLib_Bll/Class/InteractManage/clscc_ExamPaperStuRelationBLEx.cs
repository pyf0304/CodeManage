
/*-- -- -- -- -- -- -- -- -- -- --
类名:clscc_ExamPaperStuRelationBLEx
表名:cc_ExamPaperStuRelation
生成代码版本:2017.06.27.1
生成日期:2017/06/28 14:51:31
生成者:
生成服务器IP:180.153.158.158
工程名称:问卷调查
工程ID:0112
模块中文名:互动管理
模块英文名:InteractManage
框架-层名:业务逻辑扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.06.19.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
== == == == == == == == == == == == 
*/
using com.taishsoft.datetime;
using ExamLib.BusinessLogic;
using ExamLib.DAL;
using ExamLib.Entity;
using System.Collections.Generic;

namespace ExamLib.BusinessLogicEx
{
    /// <summary>
    /// 考卷与学生关系表(cc_ExamPaperStuRelation)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public partial class clscc_ExamPaperStuRelationBLEx : clscc_ExamPaperStuRelationBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clscc_ExamPaperStuRelationDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clscc_ExamPaperStuRelationDAEx cc_ExamPaperStuRelationDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clscc_ExamPaperStuRelationDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 获取学生需要完成的作业关键字列表
        /// </summary>
        /// <param name="strid_StudentInfo"></param>
        /// <param name="stridCurrEduCls"></param>
        /// <returns></returns>
        public static List<string> GetAllPaper4Finish(
                    string strid_StudentInfo,
                    string stridCurrEduCls)
        {
            string strCondition = string.Format(" {0}='1' And {1}='{2}' And {3}='{4}'",
                  concc_ExamPaperStuRelation.IsPublish,
                    concc_ExamPaperStuRelation.IdCurrEduCls, stridCurrEduCls,
                concc_ExamPaperStuRelation.IdStudentInfo,
                strid_StudentInfo);
            List<string> arrKeyId = clscc_ExamPaperStuRelationBL.GetPrimaryKeyID_S(strCondition);
            return arrKeyId;
        }

        /// <summary>
        /// 布置作业
        /// </summary>
        /// <param name="objcc_ExamPaperEduClsRelaEN"></param>
        /// <param name="strIdStu"></param>
        /// <returns></returns>
        public static bool ArrangeHomeWork(clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN, string strIdStu)
        {
            string strCurrDate = clsDateTime.getTodayDateTimeStr(0);
            if (string.IsNullOrEmpty(strIdStu) == true) return false;
            string strCondition_WorkStuRelation = string.Format(" {0}='{1}' And {2}='{3}' And {4}='{5}'",
                                    concc_ExamPaperStuRelation.CourseExamPaperId, objcc_ExamPaperEduClsRelaEN.CourseExamPaperId,
                                    concc_ExamPaperStuRelation.IdStudentInfo, strIdStu,
                                    concc_ExamPaperStuRelation.IdCurrEduCls, objcc_ExamPaperEduClsRelaEN.IdCurrEduCls);
            if (clscc_ExamPaperStuRelationBL.IsExistRecord(strCondition_WorkStuRelation) == false)
            {
                clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = new clscc_ExamPaperStuRelationEN();
                objcc_ExamPaperStuRelationEN.CourseExamPaperId = objcc_ExamPaperEduClsRelaEN.CourseExamPaperId;
                objcc_ExamPaperStuRelationEN.Scores = objcc_ExamPaperEduClsRelaEN.Scores;
                objcc_ExamPaperStuRelationEN.IsPublish = true;
                objcc_ExamPaperStuRelationEN.IdCurrEduCls = objcc_ExamPaperEduClsRelaEN.IdCurrEduCls;
                objcc_ExamPaperStuRelationEN.IdStudentInfo = strIdStu;
                objcc_ExamPaperStuRelationEN.WorkTypeId = objcc_ExamPaperEduClsRelaEN.WorkTypeId;

                objcc_ExamPaperStuRelationEN.SpecifyCompletionDate = objcc_ExamPaperEduClsRelaEN.SpecifyCompletionDate;
                objcc_ExamPaperStuRelationEN.SchoolYear = clsSysParaEN.CurrYear;
                objcc_ExamPaperStuRelationEN.SchoolTerm = clsSysParaEN.CurrTerm;
                objcc_ExamPaperStuRelationEN.UpdDate = strCurrDate;
                objcc_ExamPaperStuRelationEN.UpdUserId = "lyl";
                clscc_ExamPaperStuRelationBL.AddNewRecordBySql2(objcc_ExamPaperStuRelationEN);
            }
            else
            {
                clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = clscc_ExamPaperStuRelationBL.GetFirstObj_S(strCondition_WorkStuRelation);
                objcc_ExamPaperStuRelationEN.SpecifyCompletionDate = objcc_ExamPaperEduClsRelaEN.SpecifyCompletionDate;
                objcc_ExamPaperStuRelationEN.Scores = objcc_ExamPaperEduClsRelaEN.Scores;
                objcc_ExamPaperStuRelationEN.WorkTypeId = objcc_ExamPaperEduClsRelaEN.WorkTypeId;
                objcc_ExamPaperStuRelationEN.IsPublish = true;
                objcc_ExamPaperStuRelationEN.SchoolYear = clsSysParaEN.CurrYear;
                objcc_ExamPaperStuRelationEN.SchoolTerm = clsSysParaEN.CurrTerm;
                objcc_ExamPaperStuRelationEN.UpdDate = strCurrDate;
                objcc_ExamPaperStuRelationEN.UpdUserId = "lyl";
                clscc_ExamPaperStuRelationBL.UpdateBySql2(objcc_ExamPaperStuRelationEN);
            }
            return true;
        }
        public static bool ArrangeHomeWork(string strIdCurrEduCls, string strIdStu, string strOpUserId)
        {
            string strCurrDate = clsDateTime.getTodayDateTimeStr(0);
            if (string.IsNullOrEmpty(strIdStu) == true) return false;

            string strCondition = string.Format("{0}='{1}'",
             concc_ExamPaperEduClsRela.IdCurrEduCls, strIdCurrEduCls);
            List<clscc_ExamPaperEduClsRelaEN> arrcc_ExamPaperEduClsRelaENObjLst = clscc_ExamPaperEduClsRelaBL.GetObjLst(strCondition);
            foreach (clscc_ExamPaperEduClsRelaEN objcc_ExamPaperEduClsRelaEN in arrcc_ExamPaperEduClsRelaENObjLst)
            {
                string strCondition_WorkStuRelation = string.Format(" {0}='{1}' And {2}='{3}' And {4}='{5}'",
                                        concc_ExamPaperStuRelation.CourseExamPaperId, objcc_ExamPaperEduClsRelaEN.CourseExamPaperId,
                                        concc_ExamPaperStuRelation.IdStudentInfo, strIdStu,
                                        concc_ExamPaperStuRelation.IdCurrEduCls, objcc_ExamPaperEduClsRelaEN.IdCurrEduCls);
                if (clscc_ExamPaperStuRelationBL.IsExistRecord(strCondition_WorkStuRelation) == false)
                {
                    clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = new clscc_ExamPaperStuRelationEN();
                    objcc_ExamPaperStuRelationEN.CourseExamPaperId = objcc_ExamPaperEduClsRelaEN.CourseExamPaperId;
                    objcc_ExamPaperStuRelationEN.Scores = objcc_ExamPaperEduClsRelaEN.Scores;
                    objcc_ExamPaperStuRelationEN.IsPublish = true;
                    objcc_ExamPaperStuRelationEN.IdCurrEduCls = objcc_ExamPaperEduClsRelaEN.IdCurrEduCls;
                    objcc_ExamPaperStuRelationEN.IdStudentInfo = strIdStu;
                    objcc_ExamPaperStuRelationEN.WorkTypeId = objcc_ExamPaperEduClsRelaEN.WorkTypeId;

                    objcc_ExamPaperStuRelationEN.SpecifyCompletionDate = objcc_ExamPaperEduClsRelaEN.SpecifyCompletionDate;
                    objcc_ExamPaperStuRelationEN.SchoolYear = clsSysParaEN.CurrYear;
                    objcc_ExamPaperStuRelationEN.SchoolTerm = clsSysParaEN.CurrTerm;
                    objcc_ExamPaperStuRelationEN.UpdDate = strCurrDate;
                    objcc_ExamPaperStuRelationEN.UpdUserId = strOpUserId;
                    clscc_ExamPaperStuRelationBL.AddNewRecordBySql2(objcc_ExamPaperStuRelationEN);
                }
                else
                {
                    clscc_ExamPaperStuRelationEN objcc_ExamPaperStuRelationEN = clscc_ExamPaperStuRelationBL.GetFirstObj_S(strCondition_WorkStuRelation);
                    objcc_ExamPaperStuRelationEN.SpecifyCompletionDate = objcc_ExamPaperEduClsRelaEN.SpecifyCompletionDate;
                    objcc_ExamPaperStuRelationEN.Scores = objcc_ExamPaperEduClsRelaEN.Scores;
                    objcc_ExamPaperStuRelationEN.WorkTypeId = objcc_ExamPaperEduClsRelaEN.WorkTypeId;
                    objcc_ExamPaperStuRelationEN.IsPublish = true;
                    objcc_ExamPaperStuRelationEN.SchoolYear = clsSysParaEN.CurrYear;
                    objcc_ExamPaperStuRelationEN.SchoolTerm = clsSysParaEN.CurrTerm;
                    objcc_ExamPaperStuRelationEN.UpdDate = strCurrDate;
                    objcc_ExamPaperStuRelationEN.UpdUserId = strOpUserId;
                    clscc_ExamPaperStuRelationBL.UpdateBySql2(objcc_ExamPaperStuRelationEN);
                }
            }
            return true;
        }

    }
}