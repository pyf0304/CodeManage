
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_KnowledgesExamLibRelaEN
 表名:vcc_KnowledgesExamLibRela(01120142)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:05
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
 框架-层名:实体层(CS)(EntityLayer)
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

namespace ExamLib.Entity
{
 /// <summary>
 /// 表vcc_KnowledgesExamLibRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vcc_KnowledgesExamLibRela
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_vcc_KnowledgesExamLibRela(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_vcc_KnowledgesExamLibRela]类型的对象</returns>
public static implicit operator K_mId_vcc_KnowledgesExamLibRela(long value)
{
return new K_mId_vcc_KnowledgesExamLibRela(value);
}
}
 /// <summary>
 /// v知识点习题关系(vcc_KnowledgesExamLibRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvcc_KnowledgesExamLibRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vcc_KnowledgesExamLibRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 22;
public static string[] AttributeName = new string[] {"mId", "QuestionID", "QuestionIndex", "QuestionName", "QuestionContent", "ChapterNameSim", "SectionNameSim", "CourseId", "PositiveCorrelation", "CourseKnowledgeId", "KnowledgeName", "KnowledgeTitle", "KnowledgeContent", "CourseName", "CourseChapterId", "ChapterId", "NegativeCorrelation", "UpdDate", "UpdUserId", "Memo", "ChapterNameSim4Question", "SectionNameSim4Question"};

protected long mlngmId;    //mId
protected string mstrQuestionID;    //题目ID
protected int? mintQuestionIndex;    //题目序号
protected string mstrQuestionName;    //题目名称
protected string mstrQuestionContent;    //题目内容
protected string mstrChapterNameSim;    //章名简称
protected string mstrSectionNameSim;    //节名简称
protected string mstrCourseId;    //课程Id
protected double? mdblPositiveCorrelation;    //正相关度
protected string mstrCourseKnowledgeId;    //知识点Id
protected string mstrKnowledgeName;    //知识点名称
protected string mstrKnowledgeTitle;    //知识点标题
protected string mstrKnowledgeContent;    //知识点内容
protected string mstrCourseName;    //课程名称
protected string mstrCourseChapterId;    //课程章节ID
protected string mstrChapterId;    //章Id
protected double? mdblNegativeCorrelation;    //负相关度
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注
protected string mstrChapterNameSim4Question;    //ChapterNameSim4Question
protected string mstrSectionNameSim4Question;    //SectionNameSim4Question

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvcc_KnowledgesExamLibRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsvcc_KnowledgesExamLibRelaEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  convcc_KnowledgesExamLibRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.QuestionID)
{
return mstrQuestionID;
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.QuestionIndex)
{
return mintQuestionIndex;
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.QuestionName)
{
return mstrQuestionName;
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.QuestionContent)
{
return mstrQuestionContent;
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.ChapterNameSim)
{
return mstrChapterNameSim;
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.SectionNameSim)
{
return mstrSectionNameSim;
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.PositiveCorrelation)
{
return mdblPositiveCorrelation;
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.CourseKnowledgeId)
{
return mstrCourseKnowledgeId;
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.KnowledgeName)
{
return mstrKnowledgeName;
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.KnowledgeTitle)
{
return mstrKnowledgeTitle;
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.KnowledgeContent)
{
return mstrKnowledgeContent;
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.ChapterId)
{
return mstrChapterId;
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.NegativeCorrelation)
{
return mdblNegativeCorrelation;
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.ChapterNameSim4Question)
{
return mstrChapterNameSim4Question;
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.SectionNameSim4Question)
{
return mstrSectionNameSim4Question;
}
return null;
}
set
{
if (strAttributeName  ==  convcc_KnowledgesExamLibRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_KnowledgesExamLibRela.mId);
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.QuestionID)
{
mstrQuestionID = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.QuestionID);
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.QuestionIndex)
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_KnowledgesExamLibRela.QuestionIndex);
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.QuestionName)
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.QuestionName);
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.QuestionContent)
{
mstrQuestionContent = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.QuestionContent);
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.ChapterNameSim)
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.ChapterNameSim);
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.SectionNameSim)
{
mstrSectionNameSim = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.SectionNameSim);
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.CourseId);
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.PositiveCorrelation)
{
mdblPositiveCorrelation = TransNullToDouble(value.ToString());
 AddUpdatedFld(convcc_KnowledgesExamLibRela.PositiveCorrelation);
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.CourseKnowledgeId)
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.CourseKnowledgeId);
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.KnowledgeName)
{
mstrKnowledgeName = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.KnowledgeName);
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.KnowledgeTitle)
{
mstrKnowledgeTitle = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.KnowledgeTitle);
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.KnowledgeContent)
{
mstrKnowledgeContent = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.KnowledgeContent);
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.CourseName);
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.CourseChapterId);
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.ChapterId)
{
mstrChapterId = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.ChapterId);
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.NegativeCorrelation)
{
mdblNegativeCorrelation = TransNullToDouble(value.ToString());
 AddUpdatedFld(convcc_KnowledgesExamLibRela.NegativeCorrelation);
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.UpdDate);
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.UpdUserId);
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.Memo);
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.ChapterNameSim4Question)
{
mstrChapterNameSim4Question = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.ChapterNameSim4Question);
}
else if (strAttributeName  ==  convcc_KnowledgesExamLibRela.SectionNameSim4Question)
{
mstrSectionNameSim4Question = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.SectionNameSim4Question);
}
}
}
public object this[int intIndex]
{
get
{
if (convcc_KnowledgesExamLibRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convcc_KnowledgesExamLibRela.QuestionID  ==  AttributeName[intIndex])
{
return mstrQuestionID;
}
else if (convcc_KnowledgesExamLibRela.QuestionIndex  ==  AttributeName[intIndex])
{
return mintQuestionIndex;
}
else if (convcc_KnowledgesExamLibRela.QuestionName  ==  AttributeName[intIndex])
{
return mstrQuestionName;
}
else if (convcc_KnowledgesExamLibRela.QuestionContent  ==  AttributeName[intIndex])
{
return mstrQuestionContent;
}
else if (convcc_KnowledgesExamLibRela.ChapterNameSim  ==  AttributeName[intIndex])
{
return mstrChapterNameSim;
}
else if (convcc_KnowledgesExamLibRela.SectionNameSim  ==  AttributeName[intIndex])
{
return mstrSectionNameSim;
}
else if (convcc_KnowledgesExamLibRela.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convcc_KnowledgesExamLibRela.PositiveCorrelation  ==  AttributeName[intIndex])
{
return mdblPositiveCorrelation;
}
else if (convcc_KnowledgesExamLibRela.CourseKnowledgeId  ==  AttributeName[intIndex])
{
return mstrCourseKnowledgeId;
}
else if (convcc_KnowledgesExamLibRela.KnowledgeName  ==  AttributeName[intIndex])
{
return mstrKnowledgeName;
}
else if (convcc_KnowledgesExamLibRela.KnowledgeTitle  ==  AttributeName[intIndex])
{
return mstrKnowledgeTitle;
}
else if (convcc_KnowledgesExamLibRela.KnowledgeContent  ==  AttributeName[intIndex])
{
return mstrKnowledgeContent;
}
else if (convcc_KnowledgesExamLibRela.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convcc_KnowledgesExamLibRela.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (convcc_KnowledgesExamLibRela.ChapterId  ==  AttributeName[intIndex])
{
return mstrChapterId;
}
else if (convcc_KnowledgesExamLibRela.NegativeCorrelation  ==  AttributeName[intIndex])
{
return mdblNegativeCorrelation;
}
else if (convcc_KnowledgesExamLibRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convcc_KnowledgesExamLibRela.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convcc_KnowledgesExamLibRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convcc_KnowledgesExamLibRela.ChapterNameSim4Question  ==  AttributeName[intIndex])
{
return mstrChapterNameSim4Question;
}
else if (convcc_KnowledgesExamLibRela.SectionNameSim4Question  ==  AttributeName[intIndex])
{
return mstrSectionNameSim4Question;
}
return null;
}
set
{
if (convcc_KnowledgesExamLibRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_KnowledgesExamLibRela.mId);
}
else if (convcc_KnowledgesExamLibRela.QuestionID  ==  AttributeName[intIndex])
{
mstrQuestionID = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.QuestionID);
}
else if (convcc_KnowledgesExamLibRela.QuestionIndex  ==  AttributeName[intIndex])
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_KnowledgesExamLibRela.QuestionIndex);
}
else if (convcc_KnowledgesExamLibRela.QuestionName  ==  AttributeName[intIndex])
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.QuestionName);
}
else if (convcc_KnowledgesExamLibRela.QuestionContent  ==  AttributeName[intIndex])
{
mstrQuestionContent = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.QuestionContent);
}
else if (convcc_KnowledgesExamLibRela.ChapterNameSim  ==  AttributeName[intIndex])
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.ChapterNameSim);
}
else if (convcc_KnowledgesExamLibRela.SectionNameSim  ==  AttributeName[intIndex])
{
mstrSectionNameSim = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.SectionNameSim);
}
else if (convcc_KnowledgesExamLibRela.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.CourseId);
}
else if (convcc_KnowledgesExamLibRela.PositiveCorrelation  ==  AttributeName[intIndex])
{
mdblPositiveCorrelation = TransNullToDouble(value.ToString());
 AddUpdatedFld(convcc_KnowledgesExamLibRela.PositiveCorrelation);
}
else if (convcc_KnowledgesExamLibRela.CourseKnowledgeId  ==  AttributeName[intIndex])
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.CourseKnowledgeId);
}
else if (convcc_KnowledgesExamLibRela.KnowledgeName  ==  AttributeName[intIndex])
{
mstrKnowledgeName = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.KnowledgeName);
}
else if (convcc_KnowledgesExamLibRela.KnowledgeTitle  ==  AttributeName[intIndex])
{
mstrKnowledgeTitle = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.KnowledgeTitle);
}
else if (convcc_KnowledgesExamLibRela.KnowledgeContent  ==  AttributeName[intIndex])
{
mstrKnowledgeContent = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.KnowledgeContent);
}
else if (convcc_KnowledgesExamLibRela.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.CourseName);
}
else if (convcc_KnowledgesExamLibRela.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.CourseChapterId);
}
else if (convcc_KnowledgesExamLibRela.ChapterId  ==  AttributeName[intIndex])
{
mstrChapterId = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.ChapterId);
}
else if (convcc_KnowledgesExamLibRela.NegativeCorrelation  ==  AttributeName[intIndex])
{
mdblNegativeCorrelation = TransNullToDouble(value.ToString());
 AddUpdatedFld(convcc_KnowledgesExamLibRela.NegativeCorrelation);
}
else if (convcc_KnowledgesExamLibRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.UpdDate);
}
else if (convcc_KnowledgesExamLibRela.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.UpdUserId);
}
else if (convcc_KnowledgesExamLibRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.Memo);
}
else if (convcc_KnowledgesExamLibRela.ChapterNameSim4Question  ==  AttributeName[intIndex])
{
mstrChapterNameSim4Question = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.ChapterNameSim4Question);
}
else if (convcc_KnowledgesExamLibRela.SectionNameSim4Question  ==  AttributeName[intIndex])
{
mstrSectionNameSim4Question = value.ToString();
 AddUpdatedFld(convcc_KnowledgesExamLibRela.SectionNameSim4Question);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(convcc_KnowledgesExamLibRela.mId);
}
}
/// <summary>
/// 题目ID(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionID
{
get
{
return mstrQuestionID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionID = value;
}
else
{
 mstrQuestionID = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_KnowledgesExamLibRela.QuestionID);
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
 AddUpdatedFld(convcc_KnowledgesExamLibRela.QuestionIndex);
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
 AddUpdatedFld(convcc_KnowledgesExamLibRela.QuestionName);
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
 AddUpdatedFld(convcc_KnowledgesExamLibRela.QuestionContent);
}
}
/// <summary>
/// 章名简称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ChapterNameSim
{
get
{
return mstrChapterNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrChapterNameSim = value;
}
else
{
 mstrChapterNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_KnowledgesExamLibRela.ChapterNameSim);
}
}
/// <summary>
/// 节名简称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionNameSim
{
get
{
return mstrSectionNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionNameSim = value;
}
else
{
 mstrSectionNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_KnowledgesExamLibRela.SectionNameSim);
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
 AddUpdatedFld(convcc_KnowledgesExamLibRela.CourseId);
}
}
/// <summary>
/// 正相关度(说明:;字段类型:decimal;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? PositiveCorrelation
{
get
{
return mdblPositiveCorrelation;
}
set
{
 mdblPositiveCorrelation = value;
//记录修改过的字段
 AddUpdatedFld(convcc_KnowledgesExamLibRela.PositiveCorrelation);
}
}
/// <summary>
/// 知识点Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseKnowledgeId
{
get
{
return mstrCourseKnowledgeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseKnowledgeId = value;
}
else
{
 mstrCourseKnowledgeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_KnowledgesExamLibRela.CourseKnowledgeId);
}
}
/// <summary>
/// 知识点名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KnowledgeName
{
get
{
return mstrKnowledgeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKnowledgeName = value;
}
else
{
 mstrKnowledgeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_KnowledgesExamLibRela.KnowledgeName);
}
}
/// <summary>
/// 知识点标题(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KnowledgeTitle
{
get
{
return mstrKnowledgeTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKnowledgeTitle = value;
}
else
{
 mstrKnowledgeTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_KnowledgesExamLibRela.KnowledgeTitle);
}
}
/// <summary>
/// 知识点内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KnowledgeContent
{
get
{
return mstrKnowledgeContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKnowledgeContent = value;
}
else
{
 mstrKnowledgeContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_KnowledgesExamLibRela.KnowledgeContent);
}
}
/// <summary>
/// 课程名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseName
{
get
{
return mstrCourseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseName = value;
}
else
{
 mstrCourseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_KnowledgesExamLibRela.CourseName);
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
 AddUpdatedFld(convcc_KnowledgesExamLibRela.CourseChapterId);
}
}
/// <summary>
/// 章Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ChapterId
{
get
{
return mstrChapterId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrChapterId = value;
}
else
{
 mstrChapterId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_KnowledgesExamLibRela.ChapterId);
}
}
/// <summary>
/// 负相关度(说明:;字段类型:decimal;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? NegativeCorrelation
{
get
{
return mdblNegativeCorrelation;
}
set
{
 mdblNegativeCorrelation = value;
//记录修改过的字段
 AddUpdatedFld(convcc_KnowledgesExamLibRela.NegativeCorrelation);
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
 AddUpdatedFld(convcc_KnowledgesExamLibRela.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_KnowledgesExamLibRela.UpdUserId);
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
 AddUpdatedFld(convcc_KnowledgesExamLibRela.Memo);
}
}
/// <summary>
/// ChapterName_Sim4Question(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ChapterNameSim4Question
{
get
{
return mstrChapterNameSim4Question;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrChapterNameSim4Question = value;
}
else
{
 mstrChapterNameSim4Question = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_KnowledgesExamLibRela.ChapterNameSim4Question);
}
}
/// <summary>
/// SectionNameSim4Question(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionNameSim4Question
{
get
{
return mstrSectionNameSim4Question;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionNameSim4Question = value;
}
else
{
 mstrSectionNameSim4Question = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_KnowledgesExamLibRela.SectionNameSim4Question);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// v知识点习题关系(vcc_KnowledgesExamLibRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convcc_KnowledgesExamLibRela
{
public const string _CurrTabName = "vcc_KnowledgesExamLibRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "QuestionID", "QuestionIndex", "QuestionName", "QuestionContent", "ChapterNameSim", "SectionNameSim", "CourseId", "PositiveCorrelation", "CourseKnowledgeId", "KnowledgeName", "KnowledgeTitle", "KnowledgeContent", "CourseName", "CourseChapterId", "ChapterId", "NegativeCorrelation", "UpdDate", "UpdUserId", "Memo", "ChapterNameSim4Question", "SectionNameSim4Question"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"QuestionID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionID = "QuestionID";    //题目ID

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
 /// 常量:"ChapterNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterNameSim = "ChapterNameSim";    //章名简称

 /// <summary>
 /// 常量:"SectionNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionNameSim = "SectionNameSim";    //节名简称

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"PositiveCorrelation"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PositiveCorrelation = "PositiveCorrelation";    //正相关度

 /// <summary>
 /// 常量:"CourseKnowledgeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseKnowledgeId = "CourseKnowledgeId";    //知识点Id

 /// <summary>
 /// 常量:"KnowledgeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KnowledgeName = "KnowledgeName";    //知识点名称

 /// <summary>
 /// 常量:"KnowledgeTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KnowledgeTitle = "KnowledgeTitle";    //知识点标题

 /// <summary>
 /// 常量:"KnowledgeContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KnowledgeContent = "KnowledgeContent";    //知识点内容

 /// <summary>
 /// 常量:"CourseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseName = "CourseName";    //课程名称

 /// <summary>
 /// 常量:"CourseChapterId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseChapterId = "CourseChapterId";    //课程章节ID

 /// <summary>
 /// 常量:"ChapterId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterId = "ChapterId";    //章Id

 /// <summary>
 /// 常量:"NegativeCorrelation"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NegativeCorrelation = "NegativeCorrelation";    //负相关度

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"ChapterNameSim4Question"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterNameSim4Question = "ChapterNameSim4Question";    //ChapterName_Sim4Question

 /// <summary>
 /// 常量:"SectionNameSim4Question"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionNameSim4Question = "SectionNameSim4Question";    //SectionNameSim4Question
}

}