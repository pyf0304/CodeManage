
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseKnowledgesEN
 表名:vcc_CourseKnowledges(01120141)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:04:17
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
 /// 表vcc_CourseKnowledges的关键字(CourseKnowledgeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CourseKnowledgeId_vcc_CourseKnowledges
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCourseKnowledgeId">表关键字</param>
public K_CourseKnowledgeId_vcc_CourseKnowledges(string strCourseKnowledgeId)
{
if (IsValid(strCourseKnowledgeId)) Value = strCourseKnowledgeId;
else
{
Value = null;
}
}
private static bool IsValid(string strCourseKnowledgeId)
{
if (string.IsNullOrEmpty(strCourseKnowledgeId) == true) return false;
if (strCourseKnowledgeId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CourseKnowledgeId_vcc_CourseKnowledges]类型的对象</returns>
public static implicit operator K_CourseKnowledgeId_vcc_CourseKnowledges(string value)
{
return new K_CourseKnowledgeId_vcc_CourseKnowledges(value);
}
}
 /// <summary>
 /// v课程知识点(vcc_CourseKnowledges)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvcc_CourseKnowledgesEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vcc_CourseKnowledges"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CourseKnowledgeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 26;
public static string[] AttributeName = new string[] {"CourseKnowledgeId", "KnowledgeName", "KnowledgeTitle", "KnowledgeContent", "CourseId", "CourseCode", "CourseName", "CourseChapterId", "UserId", "ChapterId", "UploadDate", "SectionId", "IsShow", "ChapterName", "IsCast", "SectionName", "LikeCount", "ChapterNameSim", "UpdDate", "SectionNameSim", "Memo", "QuestionNum", "OrderNum", "UpdUser", "KnowledgeTypeId", "KnowledgeTypeName"};

protected string mstrCourseKnowledgeId;    //知识点Id
protected string mstrKnowledgeName;    //知识点名称
protected string mstrKnowledgeTitle;    //知识点标题
protected string mstrKnowledgeContent;    //知识点内容
protected string mstrCourseId;    //课程Id
protected string mstrCourseCode;    //课程代码
protected string mstrCourseName;    //课程名称
protected string mstrCourseChapterId;    //课程章节ID
protected string mstrUserId;    //用户ID
protected string mstrChapterId;    //章Id
protected string mstrUploadDate;    //上传时间
protected string mstrSectionId;    //节Id
protected bool mbolIsShow;    //是否启用
protected string mstrChapterName;    //章名
protected bool mbolIsCast;    //是否播放
protected string mstrSectionName;    //节名
protected long? mlngLikeCount;    //资源喜欢数量
protected string mstrChapterNameSim;    //章名简称
protected string mstrUpdDate;    //修改日期
protected string mstrSectionNameSim;    //节名简称
protected string mstrMemo;    //备注
protected int? mintQuestionNum;    //题目数
protected int? mintOrderNum;    //序号
protected string mstrUpdUser;    //修改人
protected string mstrKnowledgeTypeId;    //知识点类型Id
protected string mstrKnowledgeTypeName;    //知识点类型名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvcc_CourseKnowledgesEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CourseKnowledgeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strCourseKnowledgeId">关键字:知识点Id</param>
public clsvcc_CourseKnowledgesEN(string strCourseKnowledgeId)
 {
strCourseKnowledgeId = strCourseKnowledgeId.Replace("'", "''");
if (strCourseKnowledgeId.Length > 8)
{
throw new Exception("在表:vcc_CourseKnowledges中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCourseKnowledgeId)  ==  true)
{
throw new Exception("在表:vcc_CourseKnowledges中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCourseKnowledgeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCourseKnowledgeId = strCourseKnowledgeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CourseKnowledgeId");
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
if (strAttributeName  ==  convcc_CourseKnowledges.CourseKnowledgeId)
{
return mstrCourseKnowledgeId;
}
else if (strAttributeName  ==  convcc_CourseKnowledges.KnowledgeName)
{
return mstrKnowledgeName;
}
else if (strAttributeName  ==  convcc_CourseKnowledges.KnowledgeTitle)
{
return mstrKnowledgeTitle;
}
else if (strAttributeName  ==  convcc_CourseKnowledges.KnowledgeContent)
{
return mstrKnowledgeContent;
}
else if (strAttributeName  ==  convcc_CourseKnowledges.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convcc_CourseKnowledges.CourseCode)
{
return mstrCourseCode;
}
else if (strAttributeName  ==  convcc_CourseKnowledges.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convcc_CourseKnowledges.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  convcc_CourseKnowledges.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convcc_CourseKnowledges.ChapterId)
{
return mstrChapterId;
}
else if (strAttributeName  ==  convcc_CourseKnowledges.UploadDate)
{
return mstrUploadDate;
}
else if (strAttributeName  ==  convcc_CourseKnowledges.SectionId)
{
return mstrSectionId;
}
else if (strAttributeName  ==  convcc_CourseKnowledges.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  convcc_CourseKnowledges.ChapterName)
{
return mstrChapterName;
}
else if (strAttributeName  ==  convcc_CourseKnowledges.IsCast)
{
return mbolIsCast;
}
else if (strAttributeName  ==  convcc_CourseKnowledges.SectionName)
{
return mstrSectionName;
}
else if (strAttributeName  ==  convcc_CourseKnowledges.LikeCount)
{
return mlngLikeCount;
}
else if (strAttributeName  ==  convcc_CourseKnowledges.ChapterNameSim)
{
return mstrChapterNameSim;
}
else if (strAttributeName  ==  convcc_CourseKnowledges.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convcc_CourseKnowledges.SectionNameSim)
{
return mstrSectionNameSim;
}
else if (strAttributeName  ==  convcc_CourseKnowledges.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convcc_CourseKnowledges.QuestionNum)
{
return mintQuestionNum;
}
else if (strAttributeName  ==  convcc_CourseKnowledges.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convcc_CourseKnowledges.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convcc_CourseKnowledges.KnowledgeTypeId)
{
return mstrKnowledgeTypeId;
}
else if (strAttributeName  ==  convcc_CourseKnowledges.KnowledgeTypeName)
{
return mstrKnowledgeTypeName;
}
return null;
}
set
{
if (strAttributeName  ==  convcc_CourseKnowledges.CourseKnowledgeId)
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.CourseKnowledgeId);
}
else if (strAttributeName  ==  convcc_CourseKnowledges.KnowledgeName)
{
mstrKnowledgeName = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.KnowledgeName);
}
else if (strAttributeName  ==  convcc_CourseKnowledges.KnowledgeTitle)
{
mstrKnowledgeTitle = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.KnowledgeTitle);
}
else if (strAttributeName  ==  convcc_CourseKnowledges.KnowledgeContent)
{
mstrKnowledgeContent = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.KnowledgeContent);
}
else if (strAttributeName  ==  convcc_CourseKnowledges.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.CourseId);
}
else if (strAttributeName  ==  convcc_CourseKnowledges.CourseCode)
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.CourseCode);
}
else if (strAttributeName  ==  convcc_CourseKnowledges.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.CourseName);
}
else if (strAttributeName  ==  convcc_CourseKnowledges.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.CourseChapterId);
}
else if (strAttributeName  ==  convcc_CourseKnowledges.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.UserId);
}
else if (strAttributeName  ==  convcc_CourseKnowledges.ChapterId)
{
mstrChapterId = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.ChapterId);
}
else if (strAttributeName  ==  convcc_CourseKnowledges.UploadDate)
{
mstrUploadDate = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.UploadDate);
}
else if (strAttributeName  ==  convcc_CourseKnowledges.SectionId)
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.SectionId);
}
else if (strAttributeName  ==  convcc_CourseKnowledges.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseKnowledges.IsShow);
}
else if (strAttributeName  ==  convcc_CourseKnowledges.ChapterName)
{
mstrChapterName = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.ChapterName);
}
else if (strAttributeName  ==  convcc_CourseKnowledges.IsCast)
{
mbolIsCast = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseKnowledges.IsCast);
}
else if (strAttributeName  ==  convcc_CourseKnowledges.SectionName)
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.SectionName);
}
else if (strAttributeName  ==  convcc_CourseKnowledges.LikeCount)
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseKnowledges.LikeCount);
}
else if (strAttributeName  ==  convcc_CourseKnowledges.ChapterNameSim)
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.ChapterNameSim);
}
else if (strAttributeName  ==  convcc_CourseKnowledges.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.UpdDate);
}
else if (strAttributeName  ==  convcc_CourseKnowledges.SectionNameSim)
{
mstrSectionNameSim = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.SectionNameSim);
}
else if (strAttributeName  ==  convcc_CourseKnowledges.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.Memo);
}
else if (strAttributeName  ==  convcc_CourseKnowledges.QuestionNum)
{
mintQuestionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseKnowledges.QuestionNum);
}
else if (strAttributeName  ==  convcc_CourseKnowledges.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseKnowledges.OrderNum);
}
else if (strAttributeName  ==  convcc_CourseKnowledges.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.UpdUser);
}
else if (strAttributeName  ==  convcc_CourseKnowledges.KnowledgeTypeId)
{
mstrKnowledgeTypeId = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.KnowledgeTypeId);
}
else if (strAttributeName  ==  convcc_CourseKnowledges.KnowledgeTypeName)
{
mstrKnowledgeTypeName = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.KnowledgeTypeName);
}
}
}
public object this[int intIndex]
{
get
{
if (convcc_CourseKnowledges.CourseKnowledgeId  ==  AttributeName[intIndex])
{
return mstrCourseKnowledgeId;
}
else if (convcc_CourseKnowledges.KnowledgeName  ==  AttributeName[intIndex])
{
return mstrKnowledgeName;
}
else if (convcc_CourseKnowledges.KnowledgeTitle  ==  AttributeName[intIndex])
{
return mstrKnowledgeTitle;
}
else if (convcc_CourseKnowledges.KnowledgeContent  ==  AttributeName[intIndex])
{
return mstrKnowledgeContent;
}
else if (convcc_CourseKnowledges.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convcc_CourseKnowledges.CourseCode  ==  AttributeName[intIndex])
{
return mstrCourseCode;
}
else if (convcc_CourseKnowledges.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convcc_CourseKnowledges.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (convcc_CourseKnowledges.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convcc_CourseKnowledges.ChapterId  ==  AttributeName[intIndex])
{
return mstrChapterId;
}
else if (convcc_CourseKnowledges.UploadDate  ==  AttributeName[intIndex])
{
return mstrUploadDate;
}
else if (convcc_CourseKnowledges.SectionId  ==  AttributeName[intIndex])
{
return mstrSectionId;
}
else if (convcc_CourseKnowledges.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (convcc_CourseKnowledges.ChapterName  ==  AttributeName[intIndex])
{
return mstrChapterName;
}
else if (convcc_CourseKnowledges.IsCast  ==  AttributeName[intIndex])
{
return mbolIsCast;
}
else if (convcc_CourseKnowledges.SectionName  ==  AttributeName[intIndex])
{
return mstrSectionName;
}
else if (convcc_CourseKnowledges.LikeCount  ==  AttributeName[intIndex])
{
return mlngLikeCount;
}
else if (convcc_CourseKnowledges.ChapterNameSim  ==  AttributeName[intIndex])
{
return mstrChapterNameSim;
}
else if (convcc_CourseKnowledges.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convcc_CourseKnowledges.SectionNameSim  ==  AttributeName[intIndex])
{
return mstrSectionNameSim;
}
else if (convcc_CourseKnowledges.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convcc_CourseKnowledges.QuestionNum  ==  AttributeName[intIndex])
{
return mintQuestionNum;
}
else if (convcc_CourseKnowledges.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convcc_CourseKnowledges.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convcc_CourseKnowledges.KnowledgeTypeId  ==  AttributeName[intIndex])
{
return mstrKnowledgeTypeId;
}
else if (convcc_CourseKnowledges.KnowledgeTypeName  ==  AttributeName[intIndex])
{
return mstrKnowledgeTypeName;
}
return null;
}
set
{
if (convcc_CourseKnowledges.CourseKnowledgeId  ==  AttributeName[intIndex])
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.CourseKnowledgeId);
}
else if (convcc_CourseKnowledges.KnowledgeName  ==  AttributeName[intIndex])
{
mstrKnowledgeName = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.KnowledgeName);
}
else if (convcc_CourseKnowledges.KnowledgeTitle  ==  AttributeName[intIndex])
{
mstrKnowledgeTitle = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.KnowledgeTitle);
}
else if (convcc_CourseKnowledges.KnowledgeContent  ==  AttributeName[intIndex])
{
mstrKnowledgeContent = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.KnowledgeContent);
}
else if (convcc_CourseKnowledges.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.CourseId);
}
else if (convcc_CourseKnowledges.CourseCode  ==  AttributeName[intIndex])
{
mstrCourseCode = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.CourseCode);
}
else if (convcc_CourseKnowledges.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.CourseName);
}
else if (convcc_CourseKnowledges.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.CourseChapterId);
}
else if (convcc_CourseKnowledges.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.UserId);
}
else if (convcc_CourseKnowledges.ChapterId  ==  AttributeName[intIndex])
{
mstrChapterId = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.ChapterId);
}
else if (convcc_CourseKnowledges.UploadDate  ==  AttributeName[intIndex])
{
mstrUploadDate = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.UploadDate);
}
else if (convcc_CourseKnowledges.SectionId  ==  AttributeName[intIndex])
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.SectionId);
}
else if (convcc_CourseKnowledges.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseKnowledges.IsShow);
}
else if (convcc_CourseKnowledges.ChapterName  ==  AttributeName[intIndex])
{
mstrChapterName = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.ChapterName);
}
else if (convcc_CourseKnowledges.IsCast  ==  AttributeName[intIndex])
{
mbolIsCast = TransNullToBool(value.ToString());
 AddUpdatedFld(convcc_CourseKnowledges.IsCast);
}
else if (convcc_CourseKnowledges.SectionName  ==  AttributeName[intIndex])
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.SectionName);
}
else if (convcc_CourseKnowledges.LikeCount  ==  AttributeName[intIndex])
{
mlngLikeCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseKnowledges.LikeCount);
}
else if (convcc_CourseKnowledges.ChapterNameSim  ==  AttributeName[intIndex])
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.ChapterNameSim);
}
else if (convcc_CourseKnowledges.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.UpdDate);
}
else if (convcc_CourseKnowledges.SectionNameSim  ==  AttributeName[intIndex])
{
mstrSectionNameSim = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.SectionNameSim);
}
else if (convcc_CourseKnowledges.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.Memo);
}
else if (convcc_CourseKnowledges.QuestionNum  ==  AttributeName[intIndex])
{
mintQuestionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseKnowledges.QuestionNum);
}
else if (convcc_CourseKnowledges.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_CourseKnowledges.OrderNum);
}
else if (convcc_CourseKnowledges.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.UpdUser);
}
else if (convcc_CourseKnowledges.KnowledgeTypeId  ==  AttributeName[intIndex])
{
mstrKnowledgeTypeId = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.KnowledgeTypeId);
}
else if (convcc_CourseKnowledges.KnowledgeTypeName  ==  AttributeName[intIndex])
{
mstrKnowledgeTypeName = value.ToString();
 AddUpdatedFld(convcc_CourseKnowledges.KnowledgeTypeName);
}
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
 AddUpdatedFld(convcc_CourseKnowledges.CourseKnowledgeId);
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
 AddUpdatedFld(convcc_CourseKnowledges.KnowledgeName);
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
 AddUpdatedFld(convcc_CourseKnowledges.KnowledgeTitle);
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
 AddUpdatedFld(convcc_CourseKnowledges.KnowledgeContent);
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
 AddUpdatedFld(convcc_CourseKnowledges.CourseId);
}
}
/// <summary>
/// 课程代码(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseCode
{
get
{
return mstrCourseCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseCode = value;
}
else
{
 mstrCourseCode = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseKnowledges.CourseCode);
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
 AddUpdatedFld(convcc_CourseKnowledges.CourseName);
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
 AddUpdatedFld(convcc_CourseKnowledges.CourseChapterId);
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseKnowledges.UserId);
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
 AddUpdatedFld(convcc_CourseKnowledges.ChapterId);
}
}
/// <summary>
/// 上传时间(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UploadDate
{
get
{
return mstrUploadDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUploadDate = value;
}
else
{
 mstrUploadDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseKnowledges.UploadDate);
}
}
/// <summary>
/// 节Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionId
{
get
{
return mstrSectionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionId = value;
}
else
{
 mstrSectionId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseKnowledges.SectionId);
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
 AddUpdatedFld(convcc_CourseKnowledges.IsShow);
}
}
/// <summary>
/// 章名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ChapterName
{
get
{
return mstrChapterName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrChapterName = value;
}
else
{
 mstrChapterName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseKnowledges.ChapterName);
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
 AddUpdatedFld(convcc_CourseKnowledges.IsCast);
}
}
/// <summary>
/// 节名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionName
{
get
{
return mstrSectionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionName = value;
}
else
{
 mstrSectionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseKnowledges.SectionName);
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
 AddUpdatedFld(convcc_CourseKnowledges.LikeCount);
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
 AddUpdatedFld(convcc_CourseKnowledges.ChapterNameSim);
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
 AddUpdatedFld(convcc_CourseKnowledges.UpdDate);
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
 AddUpdatedFld(convcc_CourseKnowledges.SectionNameSim);
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
 AddUpdatedFld(convcc_CourseKnowledges.Memo);
}
}
/// <summary>
/// 题目数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? QuestionNum
{
get
{
return mintQuestionNum;
}
set
{
 mintQuestionNum = value;
//记录修改过的字段
 AddUpdatedFld(convcc_CourseKnowledges.QuestionNum);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convcc_CourseKnowledges.OrderNum);
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
 AddUpdatedFld(convcc_CourseKnowledges.UpdUser);
}
}
/// <summary>
/// 知识点类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KnowledgeTypeId
{
get
{
return mstrKnowledgeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKnowledgeTypeId = value;
}
else
{
 mstrKnowledgeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseKnowledges.KnowledgeTypeId);
}
}
/// <summary>
/// 知识点类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KnowledgeTypeName
{
get
{
return mstrKnowledgeTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKnowledgeTypeName = value;
}
else
{
 mstrKnowledgeTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_CourseKnowledges.KnowledgeTypeName);
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
  return mstrCourseKnowledgeId;
 }
 }
}
 /// <summary>
 /// v课程知识点(vcc_CourseKnowledges)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convcc_CourseKnowledges
{
public const string _CurrTabName = "vcc_CourseKnowledges"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CourseKnowledgeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"CourseKnowledgeId", "KnowledgeName", "KnowledgeTitle", "KnowledgeContent", "CourseId", "CourseCode", "CourseName", "CourseChapterId", "UserId", "ChapterId", "UploadDate", "SectionId", "IsShow", "ChapterName", "IsCast", "SectionName", "LikeCount", "ChapterNameSim", "UpdDate", "SectionNameSim", "Memo", "QuestionNum", "OrderNum", "UpdUser", "KnowledgeTypeId", "KnowledgeTypeName"};
//以下是属性变量


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
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"CourseCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseCode = "CourseCode";    //课程代码

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
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"ChapterId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterId = "ChapterId";    //章Id

 /// <summary>
 /// 常量:"UploadDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UploadDate = "UploadDate";    //上传时间

 /// <summary>
 /// 常量:"SectionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionId = "SectionId";    //节Id

 /// <summary>
 /// 常量:"IsShow"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsShow = "IsShow";    //是否启用

 /// <summary>
 /// 常量:"ChapterName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterName = "ChapterName";    //章名

 /// <summary>
 /// 常量:"IsCast"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCast = "IsCast";    //是否播放

 /// <summary>
 /// 常量:"SectionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionName = "SectionName";    //节名

 /// <summary>
 /// 常量:"LikeCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LikeCount = "LikeCount";    //资源喜欢数量

 /// <summary>
 /// 常量:"ChapterNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterNameSim = "ChapterNameSim";    //章名简称

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"SectionNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionNameSim = "SectionNameSim";    //节名简称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"QuestionNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionNum = "QuestionNum";    //题目数

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"KnowledgeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KnowledgeTypeId = "KnowledgeTypeId";    //知识点类型Id

 /// <summary>
 /// 常量:"KnowledgeTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KnowledgeTypeName = "KnowledgeTypeName";    //知识点类型名
}

}