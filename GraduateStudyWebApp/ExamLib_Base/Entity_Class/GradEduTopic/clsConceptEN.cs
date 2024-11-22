
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsConceptEN
 表名:Concept(01120602)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:07:14
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 表Concept的关键字(ConceptId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ConceptId_Concept
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strConceptId">表关键字</param>
public K_ConceptId_Concept(string strConceptId)
{
if (IsValid(strConceptId)) Value = strConceptId;
else
{
Value = null;
}
}
private static bool IsValid(string strConceptId)
{
if (string.IsNullOrEmpty(strConceptId) == true) return false;
if (strConceptId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ConceptId_Concept]类型的对象</returns>
public static implicit operator K_ConceptId_Concept(string value)
{
return new K_ConceptId_Concept(value);
}
}
 /// <summary>
 /// 观点概念(Concept)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsConceptEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "Concept"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ConceptId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 20;
public static string[] AttributeName = new string[] {"ConceptId", "ConceptName", "ConceptContent", "IsSubmit", "UpdDate", "Memo", "CitationId", "AppraiseCount", "OkCount", "Score", "StuScore", "TeaScore", "IdCurrEduCls", "PdfContent", "PdfPageNum", "CitationCount", "VersionCount", "CreateDate", "ShareId", "UpdUser"};

protected string mstrConceptId;    //概念Id
protected string mstrConceptName;    //概念名称
protected string mstrConceptContent;    //概念内容
protected bool mbolIsSubmit;    //是否提交
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrCitationId;    //引用Id
protected int? mintAppraiseCount;    //评论数
protected int? mintOkCount;    //点赞统计
protected float? mfltScore;    //评分
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrPdfContent;    //Pdf内容
protected int? mintPdfPageNum;    //Pdf页码
protected int? mintCitationCount;    //引用统计
protected int? mintVersionCount;    //版本统计
protected string mstrCreateDate;    //建立日期
protected string mstrShareId;    //分享Id
protected string mstrUpdUser;    //修改人

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsConceptEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ConceptId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strConceptId">关键字:概念Id</param>
public clsConceptEN(string strConceptId)
 {
strConceptId = strConceptId.Replace("'", "''");
if (strConceptId.Length > 8)
{
throw new Exception("在表:Concept中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strConceptId)  ==  true)
{
throw new Exception("在表:Concept中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strConceptId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrConceptId = strConceptId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ConceptId");
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
if (strAttributeName  ==  conConcept.ConceptId)
{
return mstrConceptId;
}
else if (strAttributeName  ==  conConcept.ConceptName)
{
return mstrConceptName;
}
else if (strAttributeName  ==  conConcept.ConceptContent)
{
return mstrConceptContent;
}
else if (strAttributeName  ==  conConcept.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  conConcept.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conConcept.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conConcept.CitationId)
{
return mstrCitationId;
}
else if (strAttributeName  ==  conConcept.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  conConcept.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  conConcept.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  conConcept.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  conConcept.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  conConcept.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conConcept.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  conConcept.PdfPageNum)
{
return mintPdfPageNum;
}
else if (strAttributeName  ==  conConcept.CitationCount)
{
return mintCitationCount;
}
else if (strAttributeName  ==  conConcept.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  conConcept.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  conConcept.ShareId)
{
return mstrShareId;
}
else if (strAttributeName  ==  conConcept.UpdUser)
{
return mstrUpdUser;
}
return null;
}
set
{
if (strAttributeName  ==  conConcept.ConceptId)
{
mstrConceptId = value.ToString();
 AddUpdatedFld(conConcept.ConceptId);
}
else if (strAttributeName  ==  conConcept.ConceptName)
{
mstrConceptName = value.ToString();
 AddUpdatedFld(conConcept.ConceptName);
}
else if (strAttributeName  ==  conConcept.ConceptContent)
{
mstrConceptContent = value.ToString();
 AddUpdatedFld(conConcept.ConceptContent);
}
else if (strAttributeName  ==  conConcept.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conConcept.IsSubmit);
}
else if (strAttributeName  ==  conConcept.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conConcept.UpdDate);
}
else if (strAttributeName  ==  conConcept.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conConcept.Memo);
}
else if (strAttributeName  ==  conConcept.CitationId)
{
mstrCitationId = value.ToString();
 AddUpdatedFld(conConcept.CitationId);
}
else if (strAttributeName  ==  conConcept.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conConcept.AppraiseCount);
}
else if (strAttributeName  ==  conConcept.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conConcept.OkCount);
}
else if (strAttributeName  ==  conConcept.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conConcept.Score);
}
else if (strAttributeName  ==  conConcept.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conConcept.StuScore);
}
else if (strAttributeName  ==  conConcept.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conConcept.TeaScore);
}
else if (strAttributeName  ==  conConcept.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conConcept.IdCurrEduCls);
}
else if (strAttributeName  ==  conConcept.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(conConcept.PdfContent);
}
else if (strAttributeName  ==  conConcept.PdfPageNum)
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conConcept.PdfPageNum);
}
else if (strAttributeName  ==  conConcept.CitationCount)
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conConcept.CitationCount);
}
else if (strAttributeName  ==  conConcept.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conConcept.VersionCount);
}
else if (strAttributeName  ==  conConcept.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conConcept.CreateDate);
}
else if (strAttributeName  ==  conConcept.ShareId)
{
mstrShareId = value.ToString();
 AddUpdatedFld(conConcept.ShareId);
}
else if (strAttributeName  ==  conConcept.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conConcept.UpdUser);
}
}
}
public object this[int intIndex]
{
get
{
if (conConcept.ConceptId  ==  AttributeName[intIndex])
{
return mstrConceptId;
}
else if (conConcept.ConceptName  ==  AttributeName[intIndex])
{
return mstrConceptName;
}
else if (conConcept.ConceptContent  ==  AttributeName[intIndex])
{
return mstrConceptContent;
}
else if (conConcept.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (conConcept.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conConcept.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conConcept.CitationId  ==  AttributeName[intIndex])
{
return mstrCitationId;
}
else if (conConcept.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (conConcept.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (conConcept.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (conConcept.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (conConcept.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (conConcept.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conConcept.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (conConcept.PdfPageNum  ==  AttributeName[intIndex])
{
return mintPdfPageNum;
}
else if (conConcept.CitationCount  ==  AttributeName[intIndex])
{
return mintCitationCount;
}
else if (conConcept.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (conConcept.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (conConcept.ShareId  ==  AttributeName[intIndex])
{
return mstrShareId;
}
else if (conConcept.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
return null;
}
set
{
if (conConcept.ConceptId  ==  AttributeName[intIndex])
{
mstrConceptId = value.ToString();
 AddUpdatedFld(conConcept.ConceptId);
}
else if (conConcept.ConceptName  ==  AttributeName[intIndex])
{
mstrConceptName = value.ToString();
 AddUpdatedFld(conConcept.ConceptName);
}
else if (conConcept.ConceptContent  ==  AttributeName[intIndex])
{
mstrConceptContent = value.ToString();
 AddUpdatedFld(conConcept.ConceptContent);
}
else if (conConcept.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conConcept.IsSubmit);
}
else if (conConcept.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conConcept.UpdDate);
}
else if (conConcept.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conConcept.Memo);
}
else if (conConcept.CitationId  ==  AttributeName[intIndex])
{
mstrCitationId = value.ToString();
 AddUpdatedFld(conConcept.CitationId);
}
else if (conConcept.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conConcept.AppraiseCount);
}
else if (conConcept.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conConcept.OkCount);
}
else if (conConcept.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conConcept.Score);
}
else if (conConcept.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conConcept.StuScore);
}
else if (conConcept.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conConcept.TeaScore);
}
else if (conConcept.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conConcept.IdCurrEduCls);
}
else if (conConcept.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(conConcept.PdfContent);
}
else if (conConcept.PdfPageNum  ==  AttributeName[intIndex])
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conConcept.PdfPageNum);
}
else if (conConcept.CitationCount  ==  AttributeName[intIndex])
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conConcept.CitationCount);
}
else if (conConcept.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conConcept.VersionCount);
}
else if (conConcept.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conConcept.CreateDate);
}
else if (conConcept.ShareId  ==  AttributeName[intIndex])
{
mstrShareId = value.ToString();
 AddUpdatedFld(conConcept.ShareId);
}
else if (conConcept.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conConcept.UpdUser);
}
}
}

/// <summary>
/// 概念Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConceptId
{
get
{
return mstrConceptId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConceptId = value;
}
else
{
 mstrConceptId = value;
}
//记录修改过的字段
 AddUpdatedFld(conConcept.ConceptId);
}
}
/// <summary>
/// 概念名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConceptName
{
get
{
return mstrConceptName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConceptName = value;
}
else
{
 mstrConceptName = value;
}
//记录修改过的字段
 AddUpdatedFld(conConcept.ConceptName);
}
}
/// <summary>
/// 概念内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConceptContent
{
get
{
return mstrConceptContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConceptContent = value;
}
else
{
 mstrConceptContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conConcept.ConceptContent);
}
}
/// <summary>
/// 是否提交(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSubmit
{
get
{
return mbolIsSubmit;
}
set
{
 mbolIsSubmit = value;
//记录修改过的字段
 AddUpdatedFld(conConcept.IsSubmit);
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
 AddUpdatedFld(conConcept.UpdDate);
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
 AddUpdatedFld(conConcept.Memo);
}
}
/// <summary>
/// 引用Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CitationId
{
get
{
return mstrCitationId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCitationId = value;
}
else
{
 mstrCitationId = value;
}
//记录修改过的字段
 AddUpdatedFld(conConcept.CitationId);
}
}
/// <summary>
/// 评论数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AppraiseCount
{
get
{
return mintAppraiseCount;
}
set
{
 mintAppraiseCount = value;
//记录修改过的字段
 AddUpdatedFld(conConcept.AppraiseCount);
}
}
/// <summary>
/// 点赞统计(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OkCount
{
get
{
return mintOkCount;
}
set
{
 mintOkCount = value;
//记录修改过的字段
 AddUpdatedFld(conConcept.OkCount);
}
}
/// <summary>
/// 评分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? Score
{
get
{
return mfltScore;
}
set
{
 mfltScore = value;
//记录修改过的字段
 AddUpdatedFld(conConcept.Score);
}
}
/// <summary>
/// 学生平均分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? StuScore
{
get
{
return mfltStuScore;
}
set
{
 mfltStuScore = value;
//记录修改过的字段
 AddUpdatedFld(conConcept.StuScore);
}
}
/// <summary>
/// 教师评分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? TeaScore
{
get
{
return mfltTeaScore;
}
set
{
 mfltTeaScore = value;
//记录修改过的字段
 AddUpdatedFld(conConcept.TeaScore);
}
}
/// <summary>
/// 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCurrEduCls
{
get
{
return mstrIdCurrEduCls;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCurrEduCls = value;
}
else
{
 mstrIdCurrEduCls = value;
}
//记录修改过的字段
 AddUpdatedFld(conConcept.IdCurrEduCls);
}
}
/// <summary>
/// Pdf内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PdfContent
{
get
{
return mstrPdfContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPdfContent = value;
}
else
{
 mstrPdfContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conConcept.PdfContent);
}
}
/// <summary>
/// Pdf页码(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PdfPageNum
{
get
{
return mintPdfPageNum;
}
set
{
 mintPdfPageNum = value;
//记录修改过的字段
 AddUpdatedFld(conConcept.PdfPageNum);
}
}
/// <summary>
/// 引用统计(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? CitationCount
{
get
{
return mintCitationCount;
}
set
{
 mintCitationCount = value;
//记录修改过的字段
 AddUpdatedFld(conConcept.CitationCount);
}
}
/// <summary>
/// 版本统计(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? VersionCount
{
get
{
return mintVersionCount;
}
set
{
 mintVersionCount = value;
//记录修改过的字段
 AddUpdatedFld(conConcept.VersionCount);
}
}
/// <summary>
/// 建立日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateDate
{
get
{
return mstrCreateDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateDate = value;
}
else
{
 mstrCreateDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conConcept.CreateDate);
}
}
/// <summary>
/// 分享Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ShareId
{
get
{
return mstrShareId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrShareId = value;
}
else
{
 mstrShareId = value;
}
//记录修改过的字段
 AddUpdatedFld(conConcept.ShareId);
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
 AddUpdatedFld(conConcept.UpdUser);
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
  return mstrConceptId;
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
  return mstrConceptName;
 }
 }
}
 /// <summary>
 /// 观点概念(Concept)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conConcept
{
public const string _CurrTabName = "Concept"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ConceptId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ConceptId", "ConceptName", "ConceptContent", "IsSubmit", "UpdDate", "Memo", "CitationId", "AppraiseCount", "OkCount", "Score", "StuScore", "TeaScore", "IdCurrEduCls", "PdfContent", "PdfPageNum", "CitationCount", "VersionCount", "CreateDate", "ShareId", "UpdUser"};
//以下是属性变量


 /// <summary>
 /// 常量:"ConceptId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConceptId = "ConceptId";    //概念Id

 /// <summary>
 /// 常量:"ConceptName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConceptName = "ConceptName";    //概念名称

 /// <summary>
 /// 常量:"ConceptContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConceptContent = "ConceptContent";    //概念内容

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"CitationId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CitationId = "CitationId";    //引用Id

 /// <summary>
 /// 常量:"AppraiseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseCount = "AppraiseCount";    //评论数

 /// <summary>
 /// 常量:"OkCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OkCount = "OkCount";    //点赞统计

 /// <summary>
 /// 常量:"Score"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Score = "Score";    //评分

 /// <summary>
 /// 常量:"StuScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuScore = "StuScore";    //学生平均分

 /// <summary>
 /// 常量:"TeaScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeaScore = "TeaScore";    //教师评分

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"PdfContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfContent = "PdfContent";    //Pdf内容

 /// <summary>
 /// 常量:"PdfPageNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfPageNum = "PdfPageNum";    //Pdf页码

 /// <summary>
 /// 常量:"CitationCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CitationCount = "CitationCount";    //引用统计

 /// <summary>
 /// 常量:"VersionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionCount = "VersionCount";    //版本统计

 /// <summary>
 /// 常量:"CreateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateDate = "CreateDate";    //建立日期

 /// <summary>
 /// 常量:"ShareId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ShareId = "ShareId";    //分享Id

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人
}

}