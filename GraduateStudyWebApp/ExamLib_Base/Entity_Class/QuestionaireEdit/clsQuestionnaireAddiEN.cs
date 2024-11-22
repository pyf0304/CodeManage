
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQuestionnaireAddiEN
 表名:QuestionnaireAddi(01120886)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:59:52
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护(QuestionaireEdit)
 框架-层名:实体层(CS)(EntityLayer,0001)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 

using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ExamLib.Entity
{
 /// <summary>
 /// 表QuestionnaireAddi的关键字(QuestionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_QuestionId_QuestionnaireAddi
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngQuestionId">表关键字</param>
public K_QuestionId_QuestionnaireAddi(long lngQuestionId)
{
if (IsValid(lngQuestionId)) Value = lngQuestionId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngQuestionId)
{
if (lngQuestionId == 0) return false;
if (lngQuestionId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_QuestionId_QuestionnaireAddi]类型的对象</returns>
public static implicit operator K_QuestionId_QuestionnaireAddi(long value)
{
return new K_QuestionId_QuestionnaireAddi(value);
}
}
 /// <summary>
 /// 题目附加(QuestionnaireAddi)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQuestionnaireAddiEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QuestionnaireAddi"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "QuestionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 49;
public static string[] AttributeName = new string[] {"QuestionId", "QuestionIndex", "QuestionName", "QuestionContent", "QuestionMemo", "QuestionNo", "ParentQuestionId", "ExamAnswer", "CourseId", "LevelNo", "CourseChapterId", "QuestionTypeId", "QuestionTypeId4Course", "ExamGradeId", "AnswerTypeId", "GridTitle", "AnswerModeId", "IsHaveAdditionalMemo", "QuestionnaireSetId", "QuestionScore", "QuestionNameAdd", "DefaultValue", "TextDirectId", "FillInTextWidth", "MemoTextWidth", "CodeTab", "CodeTabCode", "CodeTabName", "CodeTabCondition", "RelaEvent", "FirstIndent", "DefaultSelectItem", "IfLinkage", "LinkageIndex", "IsAutoGridTitle", "FillInTextHeight", "IsMulti4FillInText", "CheckBoxLimitCount", "RoleId", "IsShow", "IsCast", "LikeCount", "AnswerAttLimitSize", "LimitedResourceType", "IsEffective", "IsCanInPaper", "UpdDate", "UpdUser", "Memo"};

protected long mlngQuestionId;    //题目Id
protected int? mintQuestionIndex;    //题目序号
protected string mstrQuestionName;    //题目名称
protected string mstrQuestionContent;    //题目内容
protected string mstrQuestionMemo;    //题目说明
protected string mstrQuestionNo;    //题目编号
protected string mstrParentQuestionId;    //父题目Id
protected string mstrExamAnswer;    //题目答案
protected string mstrCourseId;    //课程Id
protected int? mintLevelNo;    //学习关号2
protected string mstrCourseChapterId;    //课程章节ID
protected string mstrQuestionTypeId;    //题目类型Id
protected string mstrQuestionTypeId4Course;    //题目类型Id4课程
protected string mstrExamGradeId;    //题库等级ID
protected string mstrAnswerTypeId;    //答案类型ID
protected string mstrGridTitle;    //表格标题
protected string mstrAnswerModeId;    //答案模式Id
protected bool mbolIsHaveAdditionalMemo;    //是否有附加说明
protected string mstrQuestionnaireSetId;    //问卷集ID
protected float? mfltQuestionScore;    //题目得分
protected string mstrQuestionNameAdd;    //题目补充
protected string mstrDefaultValue;    //缺省值
protected string mstrTextDirectId;    //文本方向ID
protected int? mintFillInTextWidth;    //填空框宽度
protected int? mintMemoTextWidth;    //备注框宽度
protected string mstrCodeTab;    //代码表
protected string mstrCodeTabCode;    //CodeTab_Code
protected string mstrCodeTabName;    //CodeTab_Name
protected string mstrCodeTabCondition;    //代码表_条件
protected string mstrRelaEvent;    //相关事件
protected bool mbolFirstIndent;    //首行缩进
protected string mstrDefaultSelectItem;    //默认选项
protected bool mbolIfLinkage;    //是否联动
protected int? mintLinkageIndex;    //联动题序号
protected bool mbolIsAutoGridTitle;    //是否自动编表格标题
protected int? mintFillInTextHeight;    //填空框高度
protected bool mbolIsMulti4FillInText;    //是否填空框多行
protected int? mintCheckBoxLimitCount;    //复选框限制数
protected string mstrRoleId;    //角色Id
protected bool mbolIsShow;    //是否启用
protected bool mbolIsCast;    //是否播放
protected long? mlngLikeCount;    //资源喜欢数量
protected long? mlngAnswerAttLimitSize;    //回答附件限制大小
protected string mstrLimitedResourceType;    //限制资源类型
protected bool mbolIsEffective;    //是否有效
protected bool mbolIsCanInPaper;    //是否可在Paper
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQuestionnaireAddiEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QuestionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngQuestionId">关键字:题目Id</param>
public clsQuestionnaireAddiEN(long lngQuestionId)
 {
 if (lngQuestionId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngQuestionId = lngQuestionId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QuestionId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  conQuestionnaireAddi.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  conQuestionnaireAddi.QuestionIndex)
{
return mintQuestionIndex;
}
else if (strAttributeName  ==  conQuestionnaireAddi.QuestionName)
{
return mstrQuestionName;
}
else if (strAttributeName  ==  conQuestionnaireAddi.QuestionContent)
{
return mstrQuestionContent;
}
else if (strAttributeName  ==  conQuestionnaireAddi.QuestionMemo)
{
return mstrQuestionMemo;
}
else if (strAttributeName  ==  conQuestionnaireAddi.QuestionNo)
{
return mstrQuestionNo;
}
else if (strAttributeName  ==  conQuestionnaireAddi.ParentQuestionId)
{
return mstrParentQuestionId;
}
else if (strAttributeName  ==  conQuestionnaireAddi.ExamAnswer)
{
return mstrExamAnswer;
}
else if (strAttributeName  ==  conQuestionnaireAddi.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conQuestionnaireAddi.LevelNo)
{
return mintLevelNo;
}
else if (strAttributeName  ==  conQuestionnaireAddi.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  conQuestionnaireAddi.QuestionTypeId)
{
return mstrQuestionTypeId;
}
else if (strAttributeName  ==  conQuestionnaireAddi.QuestionTypeId4Course)
{
return mstrQuestionTypeId4Course;
}
else if (strAttributeName  ==  conQuestionnaireAddi.ExamGradeId)
{
return mstrExamGradeId;
}
else if (strAttributeName  ==  conQuestionnaireAddi.AnswerTypeId)
{
return mstrAnswerTypeId;
}
else if (strAttributeName  ==  conQuestionnaireAddi.GridTitle)
{
return mstrGridTitle;
}
else if (strAttributeName  ==  conQuestionnaireAddi.AnswerModeId)
{
return mstrAnswerModeId;
}
else if (strAttributeName  ==  conQuestionnaireAddi.IsHaveAdditionalMemo)
{
return mbolIsHaveAdditionalMemo;
}
else if (strAttributeName  ==  conQuestionnaireAddi.QuestionnaireSetId)
{
return mstrQuestionnaireSetId;
}
else if (strAttributeName  ==  conQuestionnaireAddi.QuestionScore)
{
return mfltQuestionScore;
}
else if (strAttributeName  ==  conQuestionnaireAddi.QuestionNameAdd)
{
return mstrQuestionNameAdd;
}
else if (strAttributeName  ==  conQuestionnaireAddi.DefaultValue)
{
return mstrDefaultValue;
}
else if (strAttributeName  ==  conQuestionnaireAddi.TextDirectId)
{
return mstrTextDirectId;
}
else if (strAttributeName  ==  conQuestionnaireAddi.FillInTextWidth)
{
return mintFillInTextWidth;
}
else if (strAttributeName  ==  conQuestionnaireAddi.MemoTextWidth)
{
return mintMemoTextWidth;
}
else if (strAttributeName  ==  conQuestionnaireAddi.CodeTab)
{
return mstrCodeTab;
}
else if (strAttributeName  ==  conQuestionnaireAddi.CodeTabCode)
{
return mstrCodeTabCode;
}
else if (strAttributeName  ==  conQuestionnaireAddi.CodeTabName)
{
return mstrCodeTabName;
}
else if (strAttributeName  ==  conQuestionnaireAddi.CodeTabCondition)
{
return mstrCodeTabCondition;
}
else if (strAttributeName  ==  conQuestionnaireAddi.RelaEvent)
{
return mstrRelaEvent;
}
else if (strAttributeName  ==  conQuestionnaireAddi.FirstIndent)
{
return mbolFirstIndent;
}
else if (strAttributeName  ==  conQuestionnaireAddi.DefaultSelectItem)
{
return mstrDefaultSelectItem;
}
else if (strAttributeName  ==  conQuestionnaireAddi.IfLinkage)
{
return mbolIfLinkage;
}
else if (strAttributeName  ==  conQuestionnaireAddi.LinkageIndex)
{
return mintLinkageIndex;
}
else if (strAttributeName  ==  conQuestionnaireAddi.IsAutoGridTitle)
{
return mbolIsAutoGridTitle;
}
else if (strAttributeName  ==  conQuestionnaireAddi.FillInTextHeight)
{
return mintFillInTextHeight;
}
else if (strAttributeName  ==  conQuestionnaireAddi.IsMulti4FillInText)
{
return mbolIsMulti4FillInText;
}
else if (strAttributeName  ==  conQuestionnaireAddi.CheckBoxLimitCount)
{
return mintCheckBoxLimitCount;
}
else if (strAttributeName  ==  conQuestionnaireAddi.RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  conQuestionnaireAddi.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  conQuestionnaireAddi.IsCast)
{
return mbolIsCast;
}
else if (strAttributeName  ==  conQuestionnaireAddi.LikeCount)
{
return mlngLikeCount;
}
else if (strAttributeName  ==  conQuestionnaireAddi.AnswerAttLimitSize)
{
return mlngAnswerAttLimitSize;
}
else if (strAttributeName  ==  conQuestionnaireAddi.LimitedResourceType)
{
return mstrLimitedResourceType;
}
else if (strAttributeName  ==  conQuestionnaireAddi.IsEffective)
{
return mbolIsEffective;
}
else if (strAttributeName  ==  conQuestionnaireAddi.IsCanInPaper)
{
return mbolIsCanInPaper;
}
else if (strAttributeName  ==  conQuestionnaireAddi.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQuestionnaireAddi.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conQuestionnaireAddi.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQuestionnaireAddi.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.QuestionId);
}
else if (strAttributeName  ==  conQuestionnaireAddi.QuestionIndex)
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.QuestionIndex);
}
else if (strAttributeName  ==  conQuestionnaireAddi.QuestionName)
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.QuestionName);
}
else if (strAttributeName  ==  conQuestionnaireAddi.QuestionContent)
{
mstrQuestionContent = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.QuestionContent);
}
else if (strAttributeName  ==  conQuestionnaireAddi.QuestionMemo)
{
mstrQuestionMemo = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.QuestionMemo);
}
else if (strAttributeName  ==  conQuestionnaireAddi.QuestionNo)
{
mstrQuestionNo = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.QuestionNo);
}
else if (strAttributeName  ==  conQuestionnaireAddi.ParentQuestionId)
{
mstrParentQuestionId = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.ParentQuestionId);
}
else if (strAttributeName  ==  conQuestionnaireAddi.ExamAnswer)
{
mstrExamAnswer = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.ExamAnswer);
}
else if (strAttributeName  ==  conQuestionnaireAddi.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.CourseId);
}
else if (strAttributeName  ==  conQuestionnaireAddi.LevelNo)
{
mintLevelNo = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.LevelNo);
}
else if (strAttributeName  ==  conQuestionnaireAddi.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.CourseChapterId);
}
else if (strAttributeName  ==  conQuestionnaireAddi.QuestionTypeId)
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.QuestionTypeId);
}
else if (strAttributeName  ==  conQuestionnaireAddi.QuestionTypeId4Course)
{
mstrQuestionTypeId4Course = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.QuestionTypeId4Course);
}
else if (strAttributeName  ==  conQuestionnaireAddi.ExamGradeId)
{
mstrExamGradeId = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.ExamGradeId);
}
else if (strAttributeName  ==  conQuestionnaireAddi.AnswerTypeId)
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.AnswerTypeId);
}
else if (strAttributeName  ==  conQuestionnaireAddi.GridTitle)
{
mstrGridTitle = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.GridTitle);
}
else if (strAttributeName  ==  conQuestionnaireAddi.AnswerModeId)
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.AnswerModeId);
}
else if (strAttributeName  ==  conQuestionnaireAddi.IsHaveAdditionalMemo)
{
mbolIsHaveAdditionalMemo = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.IsHaveAdditionalMemo);
}
else if (strAttributeName  ==  conQuestionnaireAddi.QuestionnaireSetId)
{
mstrQuestionnaireSetId = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.QuestionnaireSetId);
}
else if (strAttributeName  ==  conQuestionnaireAddi.QuestionScore)
{
mfltQuestionScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.QuestionScore);
}
else if (strAttributeName  ==  conQuestionnaireAddi.QuestionNameAdd)
{
mstrQuestionNameAdd = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.QuestionNameAdd);
}
else if (strAttributeName  ==  conQuestionnaireAddi.DefaultValue)
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.DefaultValue);
}
else if (strAttributeName  ==  conQuestionnaireAddi.TextDirectId)
{
mstrTextDirectId = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.TextDirectId);
}
else if (strAttributeName  ==  conQuestionnaireAddi.FillInTextWidth)
{
mintFillInTextWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.FillInTextWidth);
}
else if (strAttributeName  ==  conQuestionnaireAddi.MemoTextWidth)
{
mintMemoTextWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.MemoTextWidth);
}
else if (strAttributeName  ==  conQuestionnaireAddi.CodeTab)
{
mstrCodeTab = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.CodeTab);
}
else if (strAttributeName  ==  conQuestionnaireAddi.CodeTabCode)
{
mstrCodeTabCode = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.CodeTabCode);
}
else if (strAttributeName  ==  conQuestionnaireAddi.CodeTabName)
{
mstrCodeTabName = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.CodeTabName);
}
else if (strAttributeName  ==  conQuestionnaireAddi.CodeTabCondition)
{
mstrCodeTabCondition = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.CodeTabCondition);
}
else if (strAttributeName  ==  conQuestionnaireAddi.RelaEvent)
{
mstrRelaEvent = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.RelaEvent);
}
else if (strAttributeName  ==  conQuestionnaireAddi.FirstIndent)
{
mbolFirstIndent = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.FirstIndent);
}
else if (strAttributeName  ==  conQuestionnaireAddi.DefaultSelectItem)
{
mstrDefaultSelectItem = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.DefaultSelectItem);
}
else if (strAttributeName  ==  conQuestionnaireAddi.IfLinkage)
{
mbolIfLinkage = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.IfLinkage);
}
else if (strAttributeName  ==  conQuestionnaireAddi.LinkageIndex)
{
mintLinkageIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.LinkageIndex);
}
else if (strAttributeName  ==  conQuestionnaireAddi.IsAutoGridTitle)
{
mbolIsAutoGridTitle = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.IsAutoGridTitle);
}
else if (strAttributeName  ==  conQuestionnaireAddi.FillInTextHeight)
{
mintFillInTextHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.FillInTextHeight);
}
else if (strAttributeName  ==  conQuestionnaireAddi.IsMulti4FillInText)
{
mbolIsMulti4FillInText = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.IsMulti4FillInText);
}
else if (strAttributeName  ==  conQuestionnaireAddi.CheckBoxLimitCount)
{
mintCheckBoxLimitCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.CheckBoxLimitCount);
}
else if (strAttributeName  ==  conQuestionnaireAddi.RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.RoleId);
}
else if (strAttributeName  ==  conQuestionnaireAddi.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.IsShow);
}
else if (strAttributeName  ==  conQuestionnaireAddi.IsCast)
{
mbolIsCast = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.IsCast);
}
else if (strAttributeName  ==  conQuestionnaireAddi.LikeCount)
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.LikeCount);
}
else if (strAttributeName  ==  conQuestionnaireAddi.AnswerAttLimitSize)
{
mlngAnswerAttLimitSize = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.AnswerAttLimitSize);
}
else if (strAttributeName  ==  conQuestionnaireAddi.LimitedResourceType)
{
mstrLimitedResourceType = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.LimitedResourceType);
}
else if (strAttributeName  ==  conQuestionnaireAddi.IsEffective)
{
mbolIsEffective = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.IsEffective);
}
else if (strAttributeName  ==  conQuestionnaireAddi.IsCanInPaper)
{
mbolIsCanInPaper = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.IsCanInPaper);
}
else if (strAttributeName  ==  conQuestionnaireAddi.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.UpdDate);
}
else if (strAttributeName  ==  conQuestionnaireAddi.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.UpdUser);
}
else if (strAttributeName  ==  conQuestionnaireAddi.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQuestionnaireAddi.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (conQuestionnaireAddi.QuestionIndex  ==  AttributeName[intIndex])
{
return mintQuestionIndex;
}
else if (conQuestionnaireAddi.QuestionName  ==  AttributeName[intIndex])
{
return mstrQuestionName;
}
else if (conQuestionnaireAddi.QuestionContent  ==  AttributeName[intIndex])
{
return mstrQuestionContent;
}
else if (conQuestionnaireAddi.QuestionMemo  ==  AttributeName[intIndex])
{
return mstrQuestionMemo;
}
else if (conQuestionnaireAddi.QuestionNo  ==  AttributeName[intIndex])
{
return mstrQuestionNo;
}
else if (conQuestionnaireAddi.ParentQuestionId  ==  AttributeName[intIndex])
{
return mstrParentQuestionId;
}
else if (conQuestionnaireAddi.ExamAnswer  ==  AttributeName[intIndex])
{
return mstrExamAnswer;
}
else if (conQuestionnaireAddi.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conQuestionnaireAddi.LevelNo  ==  AttributeName[intIndex])
{
return mintLevelNo;
}
else if (conQuestionnaireAddi.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (conQuestionnaireAddi.QuestionTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId;
}
else if (conQuestionnaireAddi.QuestionTypeId4Course  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId4Course;
}
else if (conQuestionnaireAddi.ExamGradeId  ==  AttributeName[intIndex])
{
return mstrExamGradeId;
}
else if (conQuestionnaireAddi.AnswerTypeId  ==  AttributeName[intIndex])
{
return mstrAnswerTypeId;
}
else if (conQuestionnaireAddi.GridTitle  ==  AttributeName[intIndex])
{
return mstrGridTitle;
}
else if (conQuestionnaireAddi.AnswerModeId  ==  AttributeName[intIndex])
{
return mstrAnswerModeId;
}
else if (conQuestionnaireAddi.IsHaveAdditionalMemo  ==  AttributeName[intIndex])
{
return mbolIsHaveAdditionalMemo;
}
else if (conQuestionnaireAddi.QuestionnaireSetId  ==  AttributeName[intIndex])
{
return mstrQuestionnaireSetId;
}
else if (conQuestionnaireAddi.QuestionScore  ==  AttributeName[intIndex])
{
return mfltQuestionScore;
}
else if (conQuestionnaireAddi.QuestionNameAdd  ==  AttributeName[intIndex])
{
return mstrQuestionNameAdd;
}
else if (conQuestionnaireAddi.DefaultValue  ==  AttributeName[intIndex])
{
return mstrDefaultValue;
}
else if (conQuestionnaireAddi.TextDirectId  ==  AttributeName[intIndex])
{
return mstrTextDirectId;
}
else if (conQuestionnaireAddi.FillInTextWidth  ==  AttributeName[intIndex])
{
return mintFillInTextWidth;
}
else if (conQuestionnaireAddi.MemoTextWidth  ==  AttributeName[intIndex])
{
return mintMemoTextWidth;
}
else if (conQuestionnaireAddi.CodeTab  ==  AttributeName[intIndex])
{
return mstrCodeTab;
}
else if (conQuestionnaireAddi.CodeTabCode  ==  AttributeName[intIndex])
{
return mstrCodeTabCode;
}
else if (conQuestionnaireAddi.CodeTabName  ==  AttributeName[intIndex])
{
return mstrCodeTabName;
}
else if (conQuestionnaireAddi.CodeTabCondition  ==  AttributeName[intIndex])
{
return mstrCodeTabCondition;
}
else if (conQuestionnaireAddi.RelaEvent  ==  AttributeName[intIndex])
{
return mstrRelaEvent;
}
else if (conQuestionnaireAddi.FirstIndent  ==  AttributeName[intIndex])
{
return mbolFirstIndent;
}
else if (conQuestionnaireAddi.DefaultSelectItem  ==  AttributeName[intIndex])
{
return mstrDefaultSelectItem;
}
else if (conQuestionnaireAddi.IfLinkage  ==  AttributeName[intIndex])
{
return mbolIfLinkage;
}
else if (conQuestionnaireAddi.LinkageIndex  ==  AttributeName[intIndex])
{
return mintLinkageIndex;
}
else if (conQuestionnaireAddi.IsAutoGridTitle  ==  AttributeName[intIndex])
{
return mbolIsAutoGridTitle;
}
else if (conQuestionnaireAddi.FillInTextHeight  ==  AttributeName[intIndex])
{
return mintFillInTextHeight;
}
else if (conQuestionnaireAddi.IsMulti4FillInText  ==  AttributeName[intIndex])
{
return mbolIsMulti4FillInText;
}
else if (conQuestionnaireAddi.CheckBoxLimitCount  ==  AttributeName[intIndex])
{
return mintCheckBoxLimitCount;
}
else if (conQuestionnaireAddi.RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (conQuestionnaireAddi.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (conQuestionnaireAddi.IsCast  ==  AttributeName[intIndex])
{
return mbolIsCast;
}
else if (conQuestionnaireAddi.LikeCount  ==  AttributeName[intIndex])
{
return mlngLikeCount;
}
else if (conQuestionnaireAddi.AnswerAttLimitSize  ==  AttributeName[intIndex])
{
return mlngAnswerAttLimitSize;
}
else if (conQuestionnaireAddi.LimitedResourceType  ==  AttributeName[intIndex])
{
return mstrLimitedResourceType;
}
else if (conQuestionnaireAddi.IsEffective  ==  AttributeName[intIndex])
{
return mbolIsEffective;
}
else if (conQuestionnaireAddi.IsCanInPaper  ==  AttributeName[intIndex])
{
return mbolIsCanInPaper;
}
else if (conQuestionnaireAddi.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQuestionnaireAddi.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conQuestionnaireAddi.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQuestionnaireAddi.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.QuestionId);
}
else if (conQuestionnaireAddi.QuestionIndex  ==  AttributeName[intIndex])
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.QuestionIndex);
}
else if (conQuestionnaireAddi.QuestionName  ==  AttributeName[intIndex])
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.QuestionName);
}
else if (conQuestionnaireAddi.QuestionContent  ==  AttributeName[intIndex])
{
mstrQuestionContent = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.QuestionContent);
}
else if (conQuestionnaireAddi.QuestionMemo  ==  AttributeName[intIndex])
{
mstrQuestionMemo = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.QuestionMemo);
}
else if (conQuestionnaireAddi.QuestionNo  ==  AttributeName[intIndex])
{
mstrQuestionNo = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.QuestionNo);
}
else if (conQuestionnaireAddi.ParentQuestionId  ==  AttributeName[intIndex])
{
mstrParentQuestionId = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.ParentQuestionId);
}
else if (conQuestionnaireAddi.ExamAnswer  ==  AttributeName[intIndex])
{
mstrExamAnswer = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.ExamAnswer);
}
else if (conQuestionnaireAddi.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.CourseId);
}
else if (conQuestionnaireAddi.LevelNo  ==  AttributeName[intIndex])
{
mintLevelNo = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.LevelNo);
}
else if (conQuestionnaireAddi.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.CourseChapterId);
}
else if (conQuestionnaireAddi.QuestionTypeId  ==  AttributeName[intIndex])
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.QuestionTypeId);
}
else if (conQuestionnaireAddi.QuestionTypeId4Course  ==  AttributeName[intIndex])
{
mstrQuestionTypeId4Course = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.QuestionTypeId4Course);
}
else if (conQuestionnaireAddi.ExamGradeId  ==  AttributeName[intIndex])
{
mstrExamGradeId = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.ExamGradeId);
}
else if (conQuestionnaireAddi.AnswerTypeId  ==  AttributeName[intIndex])
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.AnswerTypeId);
}
else if (conQuestionnaireAddi.GridTitle  ==  AttributeName[intIndex])
{
mstrGridTitle = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.GridTitle);
}
else if (conQuestionnaireAddi.AnswerModeId  ==  AttributeName[intIndex])
{
mstrAnswerModeId = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.AnswerModeId);
}
else if (conQuestionnaireAddi.IsHaveAdditionalMemo  ==  AttributeName[intIndex])
{
mbolIsHaveAdditionalMemo = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.IsHaveAdditionalMemo);
}
else if (conQuestionnaireAddi.QuestionnaireSetId  ==  AttributeName[intIndex])
{
mstrQuestionnaireSetId = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.QuestionnaireSetId);
}
else if (conQuestionnaireAddi.QuestionScore  ==  AttributeName[intIndex])
{
mfltQuestionScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.QuestionScore);
}
else if (conQuestionnaireAddi.QuestionNameAdd  ==  AttributeName[intIndex])
{
mstrQuestionNameAdd = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.QuestionNameAdd);
}
else if (conQuestionnaireAddi.DefaultValue  ==  AttributeName[intIndex])
{
mstrDefaultValue = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.DefaultValue);
}
else if (conQuestionnaireAddi.TextDirectId  ==  AttributeName[intIndex])
{
mstrTextDirectId = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.TextDirectId);
}
else if (conQuestionnaireAddi.FillInTextWidth  ==  AttributeName[intIndex])
{
mintFillInTextWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.FillInTextWidth);
}
else if (conQuestionnaireAddi.MemoTextWidth  ==  AttributeName[intIndex])
{
mintMemoTextWidth = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.MemoTextWidth);
}
else if (conQuestionnaireAddi.CodeTab  ==  AttributeName[intIndex])
{
mstrCodeTab = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.CodeTab);
}
else if (conQuestionnaireAddi.CodeTabCode  ==  AttributeName[intIndex])
{
mstrCodeTabCode = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.CodeTabCode);
}
else if (conQuestionnaireAddi.CodeTabName  ==  AttributeName[intIndex])
{
mstrCodeTabName = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.CodeTabName);
}
else if (conQuestionnaireAddi.CodeTabCondition  ==  AttributeName[intIndex])
{
mstrCodeTabCondition = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.CodeTabCondition);
}
else if (conQuestionnaireAddi.RelaEvent  ==  AttributeName[intIndex])
{
mstrRelaEvent = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.RelaEvent);
}
else if (conQuestionnaireAddi.FirstIndent  ==  AttributeName[intIndex])
{
mbolFirstIndent = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.FirstIndent);
}
else if (conQuestionnaireAddi.DefaultSelectItem  ==  AttributeName[intIndex])
{
mstrDefaultSelectItem = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.DefaultSelectItem);
}
else if (conQuestionnaireAddi.IfLinkage  ==  AttributeName[intIndex])
{
mbolIfLinkage = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.IfLinkage);
}
else if (conQuestionnaireAddi.LinkageIndex  ==  AttributeName[intIndex])
{
mintLinkageIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.LinkageIndex);
}
else if (conQuestionnaireAddi.IsAutoGridTitle  ==  AttributeName[intIndex])
{
mbolIsAutoGridTitle = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.IsAutoGridTitle);
}
else if (conQuestionnaireAddi.FillInTextHeight  ==  AttributeName[intIndex])
{
mintFillInTextHeight = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.FillInTextHeight);
}
else if (conQuestionnaireAddi.IsMulti4FillInText  ==  AttributeName[intIndex])
{
mbolIsMulti4FillInText = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.IsMulti4FillInText);
}
else if (conQuestionnaireAddi.CheckBoxLimitCount  ==  AttributeName[intIndex])
{
mintCheckBoxLimitCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.CheckBoxLimitCount);
}
else if (conQuestionnaireAddi.RoleId  ==  AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.RoleId);
}
else if (conQuestionnaireAddi.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.IsShow);
}
else if (conQuestionnaireAddi.IsCast  ==  AttributeName[intIndex])
{
mbolIsCast = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.IsCast);
}
else if (conQuestionnaireAddi.LikeCount  ==  AttributeName[intIndex])
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.LikeCount);
}
else if (conQuestionnaireAddi.AnswerAttLimitSize  ==  AttributeName[intIndex])
{
mlngAnswerAttLimitSize = TransNullToInt(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.AnswerAttLimitSize);
}
else if (conQuestionnaireAddi.LimitedResourceType  ==  AttributeName[intIndex])
{
mstrLimitedResourceType = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.LimitedResourceType);
}
else if (conQuestionnaireAddi.IsEffective  ==  AttributeName[intIndex])
{
mbolIsEffective = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.IsEffective);
}
else if (conQuestionnaireAddi.IsCanInPaper  ==  AttributeName[intIndex])
{
mbolIsCanInPaper = TransNullToBool(value.ToString());
 AddUpdatedFld(conQuestionnaireAddi.IsCanInPaper);
}
else if (conQuestionnaireAddi.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.UpdDate);
}
else if (conQuestionnaireAddi.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.UpdUser);
}
else if (conQuestionnaireAddi.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQuestionnaireAddi.Memo);
}
}
}

/// <summary>
/// 题目Id(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long QuestionId
{
get
{
return mlngQuestionId;
}
set
{
 mlngQuestionId = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.QuestionId);
}
}
/// <summary>
/// 题目序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? QuestionIndex
{
get
{
return mintQuestionIndex;
}
set
{
 mintQuestionIndex = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.QuestionIndex);
}
}
/// <summary>
/// 题目名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionName
{
get
{
return mstrQuestionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionName = value;
}
else
{
 mstrQuestionName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.QuestionName);
}
}
/// <summary>
/// 题目内容(说明:;字段类型:varchar;字段长度:4000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionContent
{
get
{
return mstrQuestionContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionContent = value;
}
else
{
 mstrQuestionContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.QuestionContent);
}
}
/// <summary>
/// 题目说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionMemo
{
get
{
return mstrQuestionMemo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionMemo = value;
}
else
{
 mstrQuestionMemo = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.QuestionMemo);
}
}
/// <summary>
/// 题目编号(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionNo
{
get
{
return mstrQuestionNo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionNo = value;
}
else
{
 mstrQuestionNo = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.QuestionNo);
}
}
/// <summary>
/// 父题目Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParentQuestionId
{
get
{
return mstrParentQuestionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParentQuestionId = value;
}
else
{
 mstrParentQuestionId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.ParentQuestionId);
}
}
/// <summary>
/// 题目答案(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExamAnswer
{
get
{
return mstrExamAnswer;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExamAnswer = value;
}
else
{
 mstrExamAnswer = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.ExamAnswer);
}
}
/// <summary>
/// 课程Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseId
{
get
{
return mstrCourseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseId = value;
}
else
{
 mstrCourseId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.CourseId);
}
}
/// <summary>
/// 学习关号2(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? LevelNo
{
get
{
return mintLevelNo;
}
set
{
 mintLevelNo = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.LevelNo);
}
}
/// <summary>
/// 课程章节ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseChapterId
{
get
{
return mstrCourseChapterId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseChapterId = value;
}
else
{
 mstrCourseChapterId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.CourseChapterId);
}
}
/// <summary>
/// 题目类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionTypeId
{
get
{
return mstrQuestionTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionTypeId = value;
}
else
{
 mstrQuestionTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.QuestionTypeId);
}
}
/// <summary>
/// 题目类型Id4课程(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionTypeId4Course
{
get
{
return mstrQuestionTypeId4Course;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionTypeId4Course = value;
}
else
{
 mstrQuestionTypeId4Course = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.QuestionTypeId4Course);
}
}
/// <summary>
/// 题库等级ID(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExamGradeId
{
get
{
return mstrExamGradeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExamGradeId = value;
}
else
{
 mstrExamGradeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.ExamGradeId);
}
}
/// <summary>
/// 答案类型ID(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerTypeId
{
get
{
return mstrAnswerTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerTypeId = value;
}
else
{
 mstrAnswerTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.AnswerTypeId);
}
}
/// <summary>
/// 表格标题(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GridTitle
{
get
{
return mstrGridTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGridTitle = value;
}
else
{
 mstrGridTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.GridTitle);
}
}
/// <summary>
/// 答案模式Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerModeId
{
get
{
return mstrAnswerModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerModeId = value;
}
else
{
 mstrAnswerModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.AnswerModeId);
}
}
/// <summary>
/// 是否有附加说明(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsHaveAdditionalMemo
{
get
{
return mbolIsHaveAdditionalMemo;
}
set
{
 mbolIsHaveAdditionalMemo = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.IsHaveAdditionalMemo);
}
}
/// <summary>
/// 问卷集ID(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionnaireSetId
{
get
{
return mstrQuestionnaireSetId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionnaireSetId = value;
}
else
{
 mstrQuestionnaireSetId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.QuestionnaireSetId);
}
}
/// <summary>
/// 题目得分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? QuestionScore
{
get
{
return mfltQuestionScore;
}
set
{
 mfltQuestionScore = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.QuestionScore);
}
}
/// <summary>
/// 题目补充(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionNameAdd
{
get
{
return mstrQuestionNameAdd;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionNameAdd = value;
}
else
{
 mstrQuestionNameAdd = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.QuestionNameAdd);
}
}
/// <summary>
/// 缺省值(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DefaultValue
{
get
{
return mstrDefaultValue;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDefaultValue = value;
}
else
{
 mstrDefaultValue = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.DefaultValue);
}
}
/// <summary>
/// 文本方向ID(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextDirectId
{
get
{
return mstrTextDirectId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextDirectId = value;
}
else
{
 mstrTextDirectId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.TextDirectId);
}
}
/// <summary>
/// 填空框宽度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? FillInTextWidth
{
get
{
return mintFillInTextWidth;
}
set
{
 mintFillInTextWidth = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.FillInTextWidth);
}
}
/// <summary>
/// 备注框宽度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? MemoTextWidth
{
get
{
return mintMemoTextWidth;
}
set
{
 mintMemoTextWidth = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.MemoTextWidth);
}
}
/// <summary>
/// 代码表(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTab
{
get
{
return mstrCodeTab;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTab = value;
}
else
{
 mstrCodeTab = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.CodeTab);
}
}
/// <summary>
/// CodeTab_Code(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTabCode
{
get
{
return mstrCodeTabCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTabCode = value;
}
else
{
 mstrCodeTabCode = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.CodeTabCode);
}
}
/// <summary>
/// CodeTab_Name(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTabName
{
get
{
return mstrCodeTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTabName = value;
}
else
{
 mstrCodeTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.CodeTabName);
}
}
/// <summary>
/// 代码表_条件(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTabCondition
{
get
{
return mstrCodeTabCondition;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTabCondition = value;
}
else
{
 mstrCodeTabCondition = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.CodeTabCondition);
}
}
/// <summary>
/// 相关事件(说明:;字段类型:varchar;字段长度:4000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelaEvent
{
get
{
return mstrRelaEvent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelaEvent = value;
}
else
{
 mstrRelaEvent = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.RelaEvent);
}
}
/// <summary>
/// 首行缩进(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool FirstIndent
{
get
{
return mbolFirstIndent;
}
set
{
 mbolFirstIndent = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.FirstIndent);
}
}
/// <summary>
/// 默认选项(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DefaultSelectItem
{
get
{
return mstrDefaultSelectItem;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDefaultSelectItem = value;
}
else
{
 mstrDefaultSelectItem = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.DefaultSelectItem);
}
}
/// <summary>
/// 是否联动(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IfLinkage
{
get
{
return mbolIfLinkage;
}
set
{
 mbolIfLinkage = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.IfLinkage);
}
}
/// <summary>
/// 联动题序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? LinkageIndex
{
get
{
return mintLinkageIndex;
}
set
{
 mintLinkageIndex = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.LinkageIndex);
}
}
/// <summary>
/// 是否自动编表格标题(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsAutoGridTitle
{
get
{
return mbolIsAutoGridTitle;
}
set
{
 mbolIsAutoGridTitle = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.IsAutoGridTitle);
}
}
/// <summary>
/// 填空框高度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? FillInTextHeight
{
get
{
return mintFillInTextHeight;
}
set
{
 mintFillInTextHeight = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.FillInTextHeight);
}
}
/// <summary>
/// 是否填空框多行(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsMulti4FillInText
{
get
{
return mbolIsMulti4FillInText;
}
set
{
 mbolIsMulti4FillInText = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.IsMulti4FillInText);
}
}
/// <summary>
/// 复选框限制数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? CheckBoxLimitCount
{
get
{
return mintCheckBoxLimitCount;
}
set
{
 mintCheckBoxLimitCount = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.CheckBoxLimitCount);
}
}
/// <summary>
/// 角色Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RoleId
{
get
{
return mstrRoleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRoleId = value;
}
else
{
 mstrRoleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.RoleId);
}
}
/// <summary>
/// 是否启用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsShow
{
get
{
return mbolIsShow;
}
set
{
 mbolIsShow = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.IsShow);
}
}
/// <summary>
/// 是否播放(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCast
{
get
{
return mbolIsCast;
}
set
{
 mbolIsCast = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.IsCast);
}
}
/// <summary>
/// 资源喜欢数量(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? LikeCount
{
get
{
return mlngLikeCount;
}
set
{
 mlngLikeCount = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.LikeCount);
}
}
/// <summary>
/// 回答附件限制大小(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? AnswerAttLimitSize
{
get
{
return mlngAnswerAttLimitSize;
}
set
{
 mlngAnswerAttLimitSize = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.AnswerAttLimitSize);
}
}
/// <summary>
/// 限制资源类型(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LimitedResourceType
{
get
{
return mstrLimitedResourceType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLimitedResourceType = value;
}
else
{
 mstrLimitedResourceType = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.LimitedResourceType);
}
}
/// <summary>
/// 是否有效(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsEffective
{
get
{
return mbolIsEffective;
}
set
{
 mbolIsEffective = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.IsEffective);
}
}
/// <summary>
/// 是否可在Paper(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCanInPaper
{
get
{
return mbolIsCanInPaper;
}
set
{
 mbolIsCanInPaper = value;
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.IsCanInPaper);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdDate
{
get
{
return mstrUpdDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdDate = value;
}
else
{
 mstrUpdDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.UpdDate);
}
}
/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUser
{
get
{
return mstrUpdUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUser = value;
}
else
{
 mstrUpdUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.UpdUser);
}
}
/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Memo
{
get
{
return mstrMemo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMemo = value;
}
else
{
 mstrMemo = value;
}
//记录修改过的字段
 AddUpdatedFld(conQuestionnaireAddi.Memo);
}
}

/// <summary>
/// 获取关键字Id(keyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mlngQuestionId.ToString();
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrQuestionName;
 }
 }
}
 /// <summary>
 /// 题目附加(QuestionnaireAddi)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQuestionnaireAddi
{
public const string _CurrTabName = "QuestionnaireAddi"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "QuestionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"QuestionId", "QuestionIndex", "QuestionName", "QuestionContent", "QuestionMemo", "QuestionNo", "ParentQuestionId", "ExamAnswer", "CourseId", "LevelNo", "CourseChapterId", "QuestionTypeId", "QuestionTypeId4Course", "ExamGradeId", "AnswerTypeId", "GridTitle", "AnswerModeId", "IsHaveAdditionalMemo", "QuestionnaireSetId", "QuestionScore", "QuestionNameAdd", "DefaultValue", "TextDirectId", "FillInTextWidth", "MemoTextWidth", "CodeTab", "CodeTabCode", "CodeTabName", "CodeTabCondition", "RelaEvent", "FirstIndent", "DefaultSelectItem", "IfLinkage", "LinkageIndex", "IsAutoGridTitle", "FillInTextHeight", "IsMulti4FillInText", "CheckBoxLimitCount", "RoleId", "IsShow", "IsCast", "LikeCount", "AnswerAttLimitSize", "LimitedResourceType", "IsEffective", "IsCanInPaper", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"QuestionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionId = "QuestionId";    //题目Id

 /// <summary>
 /// 常量:"QuestionIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionIndex = "QuestionIndex";    //题目序号

 /// <summary>
 /// 常量:"QuestionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionName = "QuestionName";    //题目名称

 /// <summary>
 /// 常量:"QuestionContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionContent = "QuestionContent";    //题目内容

 /// <summary>
 /// 常量:"QuestionMemo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionMemo = "QuestionMemo";    //题目说明

 /// <summary>
 /// 常量:"QuestionNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionNo = "QuestionNo";    //题目编号

 /// <summary>
 /// 常量:"ParentQuestionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentQuestionId = "ParentQuestionId";    //父题目Id

 /// <summary>
 /// 常量:"ExamAnswer"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamAnswer = "ExamAnswer";    //题目答案

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"LevelNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LevelNo = "LevelNo";    //学习关号2

 /// <summary>
 /// 常量:"CourseChapterId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseChapterId = "CourseChapterId";    //课程章节ID

 /// <summary>
 /// 常量:"QuestionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeId = "QuestionTypeId";    //题目类型Id

 /// <summary>
 /// 常量:"QuestionTypeId4Course"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeId4Course = "QuestionTypeId4Course";    //题目类型Id4课程

 /// <summary>
 /// 常量:"ExamGradeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExamGradeId = "ExamGradeId";    //题库等级ID

 /// <summary>
 /// 常量:"AnswerTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerTypeId = "AnswerTypeId";    //答案类型ID

 /// <summary>
 /// 常量:"GridTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GridTitle = "GridTitle";    //表格标题

 /// <summary>
 /// 常量:"AnswerModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerModeId = "AnswerModeId";    //答案模式Id

 /// <summary>
 /// 常量:"IsHaveAdditionalMemo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsHaveAdditionalMemo = "IsHaveAdditionalMemo";    //是否有附加说明

 /// <summary>
 /// 常量:"QuestionnaireSetId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionnaireSetId = "QuestionnaireSetId";    //问卷集ID

 /// <summary>
 /// 常量:"QuestionScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionScore = "QuestionScore";    //题目得分

 /// <summary>
 /// 常量:"QuestionNameAdd"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionNameAdd = "QuestionNameAdd";    //题目补充

 /// <summary>
 /// 常量:"DefaultValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaultValue = "DefaultValue";    //缺省值

 /// <summary>
 /// 常量:"TextDirectId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextDirectId = "TextDirectId";    //文本方向ID

 /// <summary>
 /// 常量:"FillInTextWidth"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FillInTextWidth = "FillInTextWidth";    //填空框宽度

 /// <summary>
 /// 常量:"MemoTextWidth"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MemoTextWidth = "MemoTextWidth";    //备注框宽度

 /// <summary>
 /// 常量:"CodeTab"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTab = "CodeTab";    //代码表

 /// <summary>
 /// 常量:"CodeTabCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTabCode = "CodeTabCode";    //CodeTab_Code

 /// <summary>
 /// 常量:"CodeTabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTabName = "CodeTabName";    //CodeTab_Name

 /// <summary>
 /// 常量:"CodeTabCondition"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTabCondition = "CodeTabCondition";    //代码表_条件

 /// <summary>
 /// 常量:"RelaEvent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaEvent = "RelaEvent";    //相关事件

 /// <summary>
 /// 常量:"FirstIndent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FirstIndent = "FirstIndent";    //首行缩进

 /// <summary>
 /// 常量:"DefaultSelectItem"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaultSelectItem = "DefaultSelectItem";    //默认选项

 /// <summary>
 /// 常量:"IfLinkage"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IfLinkage = "IfLinkage";    //是否联动

 /// <summary>
 /// 常量:"LinkageIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LinkageIndex = "LinkageIndex";    //联动题序号

 /// <summary>
 /// 常量:"IsAutoGridTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsAutoGridTitle = "IsAutoGridTitle";    //是否自动编表格标题

 /// <summary>
 /// 常量:"FillInTextHeight"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FillInTextHeight = "FillInTextHeight";    //填空框高度

 /// <summary>
 /// 常量:"IsMulti4FillInText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsMulti4FillInText = "IsMulti4FillInText";    //是否填空框多行

 /// <summary>
 /// 常量:"CheckBoxLimitCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CheckBoxLimitCount = "CheckBoxLimitCount";    //复选框限制数

 /// <summary>
 /// 常量:"RoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleId = "RoleId";    //角色Id

 /// <summary>
 /// 常量:"IsShow"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsShow = "IsShow";    //是否启用

 /// <summary>
 /// 常量:"IsCast"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCast = "IsCast";    //是否播放

 /// <summary>
 /// 常量:"LikeCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LikeCount = "LikeCount";    //资源喜欢数量

 /// <summary>
 /// 常量:"AnswerAttLimitSize"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerAttLimitSize = "AnswerAttLimitSize";    //回答附件限制大小

 /// <summary>
 /// 常量:"LimitedResourceType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LimitedResourceType = "LimitedResourceType";    //限制资源类型

 /// <summary>
 /// 常量:"IsEffective"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsEffective = "IsEffective";    //是否有效

 /// <summary>
 /// 常量:"IsCanInPaper"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCanInPaper = "IsCanInPaper";    //是否可在Paper

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}