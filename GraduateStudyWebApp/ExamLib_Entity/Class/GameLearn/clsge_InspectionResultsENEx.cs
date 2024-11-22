
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsge_InspectionResultsENEx
表名:ge_InspectionResults(01120897)
生成代码版本:2021.03.13.1
生成日期:2021/03/16 16:58:42
生成者:yy
生成服务器IP:103.116.76.183
工程名称:问卷调查
工程ID:0112
相关数据库:103.116.76.183,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:游戏化学习
模块英文名:GameLearn
框架-层名:实体扩展层(EntityLayerEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;

namespace ExamLib.Entity
{
    /// <summary>
    /// 编程检查结果表(ge_InspectionResults)
    /// (AutoGCLib.EntityLayerEx4CSharp:GeneCode)
    /// </summary>
    [Serializable]
    public class clsge_InspectionResultsENEx : clsge_InspectionResultsEN
    {
        protected new const int mintAttributeCount = 16;
        public new static string[] AttributeName = new string[] { "mId", "CriteriaId", "InspectionName", "IsRight", "ExamBatchNo", "UpdDate", "UpdUser", "Memo", "QuestionId", "UserId", "CourseId", "ControlHtml", "ControlId", "ControlClass", "ControlValue", "Result", "IdCurrEduCls" };
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.EntityLayerEx4CSharp:Gen_ENEx_ClassConstructor1)
        /// </summary>
        public clsge_InspectionResultsENEx()
        {
        }

        /// <summary>
        /// 常量:"UserId"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        public const string con_strCourseId = "CourseId";
        public const string con_strControlHtml = "ControlHtml";
        public const string con_strControlId = "ControlId";
        public const string con_strControlClass = "ControlClass";
        public const string con_strControlValue = "ControlValue";
        public const string con_strResult = "Result";
        public const string con_id_CurrEduCls = "IdCurrEduCls";
        


        //string UserId, string QuestionId, string ExamBatchNo, string CourseId, string ControlHtml,string Result
        //string UserId,string QuestionId,string ExamBatchNo, string CourseId,string ControlHtml, string ControlId,string ControlClass,string ControlValue








        protected string strCourseId;//课程ID

        protected string strControlHtml;//html代码code

        protected string strControlId;//控件ID

        protected string strControlClass;//控件样式

        protected string strControlValue;//控件值

        protected string strResult;//返回结果  1，正确、2、错误； 

        protected string strid_CurrEduCls;//教学班
        

        public override object this[string strAttributeName]
        {
            get
            {
                if (strAttributeName == conge_InspectionResults.mId)
                {
                    return mlngmId;
                }
                else if (strAttributeName == conge_InspectionResults.CriteriaId)
                {
                    return mstrCriteriaId;
                }
                else if (strAttributeName == conge_InspectionResults.InspectionName)
                {
                    return mstrInspectionName;
                }
                else if (strAttributeName == conge_InspectionResults.IsRight)
                {
                    return mbolIsRight;
                }
                else if (strAttributeName == conge_InspectionResults.ExamBatchNo)
                {
                    return mstrExamBatchNo;
                }
                else if (strAttributeName == conge_InspectionResults.UpdDate)
                {
                    return mstrUpdDate;
                }
                else if (strAttributeName == conge_InspectionResults.UpdUser)
                {
                    return mstrUpdUser;
                }
                else if (strAttributeName == conge_InspectionResults.Memo)
                {
                    return mstrMemo;
                }
                else if (strAttributeName == conge_InspectionResults.QuestionId)
                {
                    return mlngQuestionId;
                }
                else if (strAttributeName == conge_InspectionResults.UserId)
                {
                    return mstrUserId;
                }

                else if (strAttributeName == con_strCourseId)
                {
                    return strCourseId;
                }
                else if (strAttributeName == con_strControlHtml)
                {
                    return strControlHtml;
                }
                else if (strAttributeName == con_strControlId)
                {
                    return strControlId;
                }
                else if (strAttributeName == con_strControlClass)
                {
                    return strControlClass;
                }
                else if (strAttributeName == con_strControlValue)
                {
                    return strControlValue;
                }
                else if (strAttributeName == con_strResult)
                {
                    return strResult;
                }
                else if (strAttributeName == con_id_CurrEduCls)
                {
                    return strid_CurrEduCls;
                }
               

                return null;
            }
            set
            {
                if (strAttributeName == conge_InspectionResults.mId)
                {
                    mlngmId = TransNullToInt(value.ToString());
                    AddUpdatedFld(conge_InspectionResults.mId);
                }
                else if (strAttributeName == conge_InspectionResults.CriteriaId)
                {
                    mstrCriteriaId = value.ToString();
                    AddUpdatedFld(conge_InspectionResults.CriteriaId);
                }
                else if (strAttributeName == conge_InspectionResults.InspectionName)
                {
                    mstrInspectionName = value.ToString();
                    AddUpdatedFld(conge_InspectionResults.InspectionName);
                }
                else if (strAttributeName == conge_InspectionResults.IsRight)
                {
                    mbolIsRight = TransNullToBool(value.ToString());
                    AddUpdatedFld(conge_InspectionResults.IsRight);
                }
                else if (strAttributeName == conge_InspectionResults.ExamBatchNo)
                {
                    mstrExamBatchNo = value.ToString();
                    AddUpdatedFld(conge_InspectionResults.ExamBatchNo);
                }
                else if (strAttributeName == conge_InspectionResults.UpdDate)
                {
                    mstrUpdDate = value.ToString();
                    AddUpdatedFld(conge_InspectionResults.UpdDate);
                }
                else if (strAttributeName == conge_InspectionResults.UpdUser)
                {
                    mstrUpdUser = value.ToString();
                    AddUpdatedFld(conge_InspectionResults.UpdUser);
                }
                else if (strAttributeName == conge_InspectionResults.Memo)
                {
                    mstrMemo = value.ToString();
                    AddUpdatedFld(conge_InspectionResults.Memo);
                }
                else if (strAttributeName == conge_InspectionResults.QuestionId)
                {
                    mlngQuestionId = long.Parse(value.ToString());
                    AddUpdatedFld(conge_InspectionResults.QuestionId);
                }
                else if (strAttributeName == conge_InspectionResults.UserId)
                {
                    mstrUserId = value.ToString();
                    AddUpdatedFld(conge_InspectionResults.UserId);
                }

                else if (strAttributeName == con_strCourseId)
                {
                    strCourseId = value.ToString();
                    AddUpdatedFld(con_strCourseId);
                }
                else if (strAttributeName == con_strControlHtml)
                {
                    strControlHtml = value.ToString();
                    AddUpdatedFld(con_strControlHtml);
                }
                else if (strAttributeName == con_strControlId)
                {
                    strControlId = value.ToString();
                    AddUpdatedFld(con_strControlId);
                }
                else if (strAttributeName == con_strControlClass)
                {
                    strControlClass = value.ToString();
                    AddUpdatedFld(con_strControlClass);
                }
                else if (strAttributeName == con_strControlValue)
                {
                    strControlValue = value.ToString();
                    AddUpdatedFld(con_strControlValue);
                }
                else if (strAttributeName == con_strResult)
                {
                    strResult = value.ToString();
                    AddUpdatedFld(con_strResult);
                }
                else if (strAttributeName == con_id_CurrEduCls)
                {
                    strid_CurrEduCls = value.ToString();
                    AddUpdatedFld(con_id_CurrEduCls);
                    
                }

            }
        }
        public new object this[int intIndex]
        {
            get
            {
                if (conge_InspectionResults.mId == AttributeName[intIndex])
                {
                    return mlngmId;
                }
                else if (conge_InspectionResults.CriteriaId == AttributeName[intIndex])
                {
                    return mstrCriteriaId;
                }
                else if (conge_InspectionResults.InspectionName == AttributeName[intIndex])
                {
                    return mstrInspectionName;
                }
                else if (conge_InspectionResults.IsRight == AttributeName[intIndex])
                {
                    return mbolIsRight;
                }
                else if (conge_InspectionResults.ExamBatchNo == AttributeName[intIndex])
                {
                    return mstrExamBatchNo;
                }
                else if (conge_InspectionResults.UpdDate == AttributeName[intIndex])
                {
                    return mstrUpdDate;
                }
                else if (conge_InspectionResults.UpdUser == AttributeName[intIndex])
                {
                    return mstrUpdUser;
                }
                else if (conge_InspectionResults.Memo == AttributeName[intIndex])
                {
                    return mstrMemo;
                }
                else if (conge_InspectionResults.QuestionId == AttributeName[intIndex])
                {
                    return mlngQuestionId;
                }
                else if (conge_InspectionResults.UserId == AttributeName[intIndex])
                {
                    return mstrUserId;
                }
                else if (con_strCourseId == AttributeName[intIndex])
                {
                    return strCourseId;
                }
                else if (con_strControlHtml == AttributeName[intIndex])
                {
                    return strControlHtml;
                }
                else if (con_strControlId == AttributeName[intIndex])
                {
                    return strControlId;
                }
                else if (con_strControlClass == AttributeName[intIndex])
                {
                    return strControlClass;
                }
                else if (con_strControlValue == AttributeName[intIndex])
                {
                    return strControlValue;
                }
                else if (con_strResult == AttributeName[intIndex])
                {
                    return strResult;
                }
                else if (con_id_CurrEduCls == AttributeName[intIndex])
                {
                    return con_id_CurrEduCls;
                }
               




                return null;
            }
            set
            {
                if (conge_InspectionResults.mId == AttributeName[intIndex])
                {
                    mlngmId = TransNullToInt(value.ToString());
                    AddUpdatedFld(conge_InspectionResults.mId);
                }
                else if (conge_InspectionResults.CriteriaId == AttributeName[intIndex])
                {
                    mstrCriteriaId = value.ToString();
                    AddUpdatedFld(conge_InspectionResults.CriteriaId);
                }
                else if (conge_InspectionResults.InspectionName == AttributeName[intIndex])
                {
                    mstrInspectionName = value.ToString();
                    AddUpdatedFld(conge_InspectionResults.InspectionName);
                }
                else if (conge_InspectionResults.IsRight == AttributeName[intIndex])
                {
                    mbolIsRight = TransNullToBool(value.ToString());
                    AddUpdatedFld(conge_InspectionResults.IsRight);
                }
                else if (conge_InspectionResults.ExamBatchNo == AttributeName[intIndex])
                {
                    mstrExamBatchNo = value.ToString();
                    AddUpdatedFld(conge_InspectionResults.ExamBatchNo);
                }
                else if (conge_InspectionResults.UpdDate == AttributeName[intIndex])
                {
                    mstrUpdDate = value.ToString();
                    AddUpdatedFld(conge_InspectionResults.UpdDate);
                }
                else if (conge_InspectionResults.UpdUser == AttributeName[intIndex])
                {
                    mstrUpdUser = value.ToString();
                    AddUpdatedFld(conge_InspectionResults.UpdUser);
                }
                else if (conge_InspectionResults.Memo == AttributeName[intIndex])
                {
                    mstrMemo = value.ToString();
                    AddUpdatedFld(conge_InspectionResults.Memo);
                }
                else if (conge_InspectionResults.QuestionId == AttributeName[intIndex])
                {
                    mlngQuestionId = long.Parse(value.ToString());
                    AddUpdatedFld(conge_InspectionResults.QuestionId);
                }
                else if (conge_InspectionResults.UserId == AttributeName[intIndex])
                {
                    mstrUserId = value.ToString();
                    AddUpdatedFld(conge_InspectionResults.UserId);
                }

                else if (con_strCourseId == AttributeName[intIndex])
                {
                    strCourseId = value.ToString();
                    AddUpdatedFld(con_strCourseId);
                }
                else if (con_strControlHtml == AttributeName[intIndex])
                {
                    strControlHtml = value.ToString();
                    AddUpdatedFld(con_strControlHtml);
                }
                else if (con_strControlId == AttributeName[intIndex])
                {
                    strControlId = value.ToString();
                    AddUpdatedFld(con_strControlId);
                }
                else if (con_strControlClass == AttributeName[intIndex])
                {
                    strControlClass = value.ToString();
                    AddUpdatedFld(con_strControlClass);
                }
                else if (con_strControlValue == AttributeName[intIndex])
                {
                    strControlValue = value.ToString();
                    AddUpdatedFld(con_strControlValue);
                }
                else if (con_strResult == AttributeName[intIndex])
                {
                    strResult = value.ToString();
                    AddUpdatedFld(con_strResult);
                }

                else if (con_id_CurrEduCls == AttributeName[intIndex])
                {
                    strid_CurrEduCls = value.ToString();
                    AddUpdatedFld(con_id_CurrEduCls);

                }

            }
        }




        [DataMember]//非常重要
        public string CourseId
        {
            get
            {
                return strCourseId;
            }
            set
            {
                strCourseId = value;
                //记录修改过的字段
                AddUpdatedFld(con_strCourseId);
            }
        }
        [DataMember]//非常重要
        public string ControlHtml
        {
            get
            {
                return strControlHtml;
            }
            set
            {
                strControlHtml = value;
                //记录修改过的字段
                AddUpdatedFld(con_strControlHtml);
            }
        }

        [DataMember]//非常重要
        public string ControlId
        {
            get
            {
                return strControlId;
            }
            set
            {
                strControlId = value;
                //记录修改过的字段
                AddUpdatedFld(con_strControlId);
            }
        }

        [DataMember]//非常重要
        public string ControlClass
        {
            get
            {
                return strControlClass;
            }
            set
            {
                strControlClass = value;
                //记录修改过的字段
                AddUpdatedFld(con_strControlClass);
            }
        }

        [DataMember]//非常重要
        public string ControlValue
        {
            get
            {
                return strControlValue;
            }
            set
            {
                strControlValue = value;
                //记录修改过的字段
                AddUpdatedFld(con_strControlValue);
            }
        }
        [DataMember]//非常重要
        public string Result
        {
            get
            {
                return strResult;
            }
            set
            {
                strResult = value;
                //记录修改过的字段
                AddUpdatedFld(con_strResult);
            }
        }


        //[DataMember]//非常重要
        //public string IdCurrEduCls
        //{
        //    get
        //    {
        //        return strid_CurrEduCls;
        //    }
        //    set
        //    {
        //        strid_CurrEduCls = value;
        //        //记录修改过的字段
        //        AddUpdatedFld(con_id_CurrEduCls);
        //    }
        //}

        //public string StrCourseId { get => strCourseId; set => strCourseId = value; }
        //public string StrControlHtml { get => strControlHtml; set => strControlHtml = value; }
        //public string StrControlId { get => strControlId; set => strControlId = value; }
        //public string StrControlClass { get => strControlClass; set => strControlClass = value; }
        //public string StrControlValue { get => strControlValue; set => strControlValue = value; }

        //public string StrResult { get => strResult; set => strResult = value; }
    }
}