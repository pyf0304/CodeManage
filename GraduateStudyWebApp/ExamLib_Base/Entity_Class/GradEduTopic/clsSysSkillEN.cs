
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysSkillEN
 表名:SysSkill(01120646)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:05:52
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
 /// 表SysSkill的关键字(SkillId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_SkillId_SysSkill
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strSkillId">表关键字</param>
public K_SkillId_SysSkill(string strSkillId)
{
if (IsValid(strSkillId)) Value = strSkillId;
else
{
Value = null;
}
}
private static bool IsValid(string strSkillId)
{
if (string.IsNullOrEmpty(strSkillId) == true) return false;
if (strSkillId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_SkillId_SysSkill]类型的对象</returns>
public static implicit operator K_SkillId_SysSkill(string value)
{
return new K_SkillId_SysSkill(value);
}
}
 /// <summary>
 /// 技能表(SysSkill)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSysSkillEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SysSkill"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "SkillId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 22;
public static string[] AttributeName = new string[] {"SkillId", "SkillName", "OperationTypeId", "Process", "LevelId", "UpdUser", "UpdDate", "IsSubmit", "CitationId", "OkCount", "AppraiseCount", "Score", "StuScore", "TeaScore", "IdCurrEduCls", "PdfContent", "PdfPageNum", "CitationCount", "VersionCount", "Memo", "CreateDate", "ShareId"};

protected string mstrSkillId;    //技能Id
protected string mstrSkillName;    //技能名称
protected string mstrOperationTypeId;    //操作类型ID
protected string mstrProcess;    //实施过程
protected string mstrLevelId;    //级别Id
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected bool mbolIsSubmit;    //是否提交
protected string mstrCitationId;    //引用Id
protected int? mintOkCount;    //点赞统计
protected int? mintAppraiseCount;    //评论数
protected float? mfltScore;    //评分
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrPdfContent;    //Pdf内容
protected int? mintPdfPageNum;    //Pdf页码
protected int? mintCitationCount;    //引用统计
protected int? mintVersionCount;    //版本统计
protected string mstrMemo;    //备注
protected string mstrCreateDate;    //建立日期
protected string mstrShareId;    //分享Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsSysSkillEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SkillId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strSkillId">关键字:技能Id</param>
public clsSysSkillEN(string strSkillId)
 {
strSkillId = strSkillId.Replace("'", "''");
if (strSkillId.Length > 10)
{
throw new Exception("在表:SysSkill中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strSkillId)  ==  true)
{
throw new Exception("在表:SysSkill中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSkillId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrSkillId = strSkillId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SkillId");
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
if (strAttributeName  ==  conSysSkill.SkillId)
{
return mstrSkillId;
}
else if (strAttributeName  ==  conSysSkill.SkillName)
{
return mstrSkillName;
}
else if (strAttributeName  ==  conSysSkill.OperationTypeId)
{
return mstrOperationTypeId;
}
else if (strAttributeName  ==  conSysSkill.Process)
{
return mstrProcess;
}
else if (strAttributeName  ==  conSysSkill.LevelId)
{
return mstrLevelId;
}
else if (strAttributeName  ==  conSysSkill.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conSysSkill.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conSysSkill.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  conSysSkill.CitationId)
{
return mstrCitationId;
}
else if (strAttributeName  ==  conSysSkill.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  conSysSkill.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  conSysSkill.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  conSysSkill.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  conSysSkill.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  conSysSkill.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conSysSkill.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  conSysSkill.PdfPageNum)
{
return mintPdfPageNum;
}
else if (strAttributeName  ==  conSysSkill.CitationCount)
{
return mintCitationCount;
}
else if (strAttributeName  ==  conSysSkill.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  conSysSkill.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conSysSkill.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  conSysSkill.ShareId)
{
return mstrShareId;
}
return null;
}
set
{
if (strAttributeName  ==  conSysSkill.SkillId)
{
mstrSkillId = value.ToString();
 AddUpdatedFld(conSysSkill.SkillId);
}
else if (strAttributeName  ==  conSysSkill.SkillName)
{
mstrSkillName = value.ToString();
 AddUpdatedFld(conSysSkill.SkillName);
}
else if (strAttributeName  ==  conSysSkill.OperationTypeId)
{
mstrOperationTypeId = value.ToString();
 AddUpdatedFld(conSysSkill.OperationTypeId);
}
else if (strAttributeName  ==  conSysSkill.Process)
{
mstrProcess = value.ToString();
 AddUpdatedFld(conSysSkill.Process);
}
else if (strAttributeName  ==  conSysSkill.LevelId)
{
mstrLevelId = value.ToString();
 AddUpdatedFld(conSysSkill.LevelId);
}
else if (strAttributeName  ==  conSysSkill.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conSysSkill.UpdUser);
}
else if (strAttributeName  ==  conSysSkill.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSysSkill.UpdDate);
}
else if (strAttributeName  ==  conSysSkill.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conSysSkill.IsSubmit);
}
else if (strAttributeName  ==  conSysSkill.CitationId)
{
mstrCitationId = value.ToString();
 AddUpdatedFld(conSysSkill.CitationId);
}
else if (strAttributeName  ==  conSysSkill.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conSysSkill.OkCount);
}
else if (strAttributeName  ==  conSysSkill.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conSysSkill.AppraiseCount);
}
else if (strAttributeName  ==  conSysSkill.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conSysSkill.Score);
}
else if (strAttributeName  ==  conSysSkill.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conSysSkill.StuScore);
}
else if (strAttributeName  ==  conSysSkill.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conSysSkill.TeaScore);
}
else if (strAttributeName  ==  conSysSkill.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conSysSkill.IdCurrEduCls);
}
else if (strAttributeName  ==  conSysSkill.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(conSysSkill.PdfContent);
}
else if (strAttributeName  ==  conSysSkill.PdfPageNum)
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conSysSkill.PdfPageNum);
}
else if (strAttributeName  ==  conSysSkill.CitationCount)
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conSysSkill.CitationCount);
}
else if (strAttributeName  ==  conSysSkill.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conSysSkill.VersionCount);
}
else if (strAttributeName  ==  conSysSkill.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSysSkill.Memo);
}
else if (strAttributeName  ==  conSysSkill.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conSysSkill.CreateDate);
}
else if (strAttributeName  ==  conSysSkill.ShareId)
{
mstrShareId = value.ToString();
 AddUpdatedFld(conSysSkill.ShareId);
}
}
}
public object this[int intIndex]
{
get
{
if (conSysSkill.SkillId  ==  AttributeName[intIndex])
{
return mstrSkillId;
}
else if (conSysSkill.SkillName  ==  AttributeName[intIndex])
{
return mstrSkillName;
}
else if (conSysSkill.OperationTypeId  ==  AttributeName[intIndex])
{
return mstrOperationTypeId;
}
else if (conSysSkill.Process  ==  AttributeName[intIndex])
{
return mstrProcess;
}
else if (conSysSkill.LevelId  ==  AttributeName[intIndex])
{
return mstrLevelId;
}
else if (conSysSkill.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conSysSkill.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conSysSkill.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (conSysSkill.CitationId  ==  AttributeName[intIndex])
{
return mstrCitationId;
}
else if (conSysSkill.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (conSysSkill.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (conSysSkill.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (conSysSkill.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (conSysSkill.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (conSysSkill.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conSysSkill.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (conSysSkill.PdfPageNum  ==  AttributeName[intIndex])
{
return mintPdfPageNum;
}
else if (conSysSkill.CitationCount  ==  AttributeName[intIndex])
{
return mintCitationCount;
}
else if (conSysSkill.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (conSysSkill.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conSysSkill.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (conSysSkill.ShareId  ==  AttributeName[intIndex])
{
return mstrShareId;
}
return null;
}
set
{
if (conSysSkill.SkillId  ==  AttributeName[intIndex])
{
mstrSkillId = value.ToString();
 AddUpdatedFld(conSysSkill.SkillId);
}
else if (conSysSkill.SkillName  ==  AttributeName[intIndex])
{
mstrSkillName = value.ToString();
 AddUpdatedFld(conSysSkill.SkillName);
}
else if (conSysSkill.OperationTypeId  ==  AttributeName[intIndex])
{
mstrOperationTypeId = value.ToString();
 AddUpdatedFld(conSysSkill.OperationTypeId);
}
else if (conSysSkill.Process  ==  AttributeName[intIndex])
{
mstrProcess = value.ToString();
 AddUpdatedFld(conSysSkill.Process);
}
else if (conSysSkill.LevelId  ==  AttributeName[intIndex])
{
mstrLevelId = value.ToString();
 AddUpdatedFld(conSysSkill.LevelId);
}
else if (conSysSkill.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conSysSkill.UpdUser);
}
else if (conSysSkill.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSysSkill.UpdDate);
}
else if (conSysSkill.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conSysSkill.IsSubmit);
}
else if (conSysSkill.CitationId  ==  AttributeName[intIndex])
{
mstrCitationId = value.ToString();
 AddUpdatedFld(conSysSkill.CitationId);
}
else if (conSysSkill.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conSysSkill.OkCount);
}
else if (conSysSkill.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conSysSkill.AppraiseCount);
}
else if (conSysSkill.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conSysSkill.Score);
}
else if (conSysSkill.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conSysSkill.StuScore);
}
else if (conSysSkill.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conSysSkill.TeaScore);
}
else if (conSysSkill.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conSysSkill.IdCurrEduCls);
}
else if (conSysSkill.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(conSysSkill.PdfContent);
}
else if (conSysSkill.PdfPageNum  ==  AttributeName[intIndex])
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conSysSkill.PdfPageNum);
}
else if (conSysSkill.CitationCount  ==  AttributeName[intIndex])
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conSysSkill.CitationCount);
}
else if (conSysSkill.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conSysSkill.VersionCount);
}
else if (conSysSkill.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSysSkill.Memo);
}
else if (conSysSkill.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conSysSkill.CreateDate);
}
else if (conSysSkill.ShareId  ==  AttributeName[intIndex])
{
mstrShareId = value.ToString();
 AddUpdatedFld(conSysSkill.ShareId);
}
}
}

/// <summary>
/// 技能Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SkillId
{
get
{
return mstrSkillId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSkillId = value;
}
else
{
 mstrSkillId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysSkill.SkillId);
}
}
/// <summary>
/// 技能名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SkillName
{
get
{
return mstrSkillName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSkillName = value;
}
else
{
 mstrSkillName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysSkill.SkillName);
}
}
/// <summary>
/// 操作类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OperationTypeId
{
get
{
return mstrOperationTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOperationTypeId = value;
}
else
{
 mstrOperationTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysSkill.OperationTypeId);
}
}
/// <summary>
/// 实施过程(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Process
{
get
{
return mstrProcess;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProcess = value;
}
else
{
 mstrProcess = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysSkill.Process);
}
}
/// <summary>
/// 级别Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LevelId
{
get
{
return mstrLevelId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLevelId = value;
}
else
{
 mstrLevelId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysSkill.LevelId);
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
 AddUpdatedFld(conSysSkill.UpdUser);
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
 AddUpdatedFld(conSysSkill.UpdDate);
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
 AddUpdatedFld(conSysSkill.IsSubmit);
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
 AddUpdatedFld(conSysSkill.CitationId);
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
 AddUpdatedFld(conSysSkill.OkCount);
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
 AddUpdatedFld(conSysSkill.AppraiseCount);
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
 AddUpdatedFld(conSysSkill.Score);
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
 AddUpdatedFld(conSysSkill.StuScore);
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
 AddUpdatedFld(conSysSkill.TeaScore);
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
 AddUpdatedFld(conSysSkill.IdCurrEduCls);
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
 AddUpdatedFld(conSysSkill.PdfContent);
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
 AddUpdatedFld(conSysSkill.PdfPageNum);
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
 AddUpdatedFld(conSysSkill.CitationCount);
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
 AddUpdatedFld(conSysSkill.VersionCount);
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
 AddUpdatedFld(conSysSkill.Memo);
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
 AddUpdatedFld(conSysSkill.CreateDate);
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
 AddUpdatedFld(conSysSkill.ShareId);
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
  return mstrSkillId;
 }
 }
}
 /// <summary>
 /// 技能表(SysSkill)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSysSkill
{
public const string _CurrTabName = "SysSkill"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SkillId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"SkillId", "SkillName", "OperationTypeId", "Process", "LevelId", "UpdUser", "UpdDate", "IsSubmit", "CitationId", "OkCount", "AppraiseCount", "Score", "StuScore", "TeaScore", "IdCurrEduCls", "PdfContent", "PdfPageNum", "CitationCount", "VersionCount", "Memo", "CreateDate", "ShareId"};
//以下是属性变量


 /// <summary>
 /// 常量:"SkillId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SkillId = "SkillId";    //技能Id

 /// <summary>
 /// 常量:"SkillName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SkillName = "SkillName";    //技能名称

 /// <summary>
 /// 常量:"OperationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OperationTypeId = "OperationTypeId";    //操作类型ID

 /// <summary>
 /// 常量:"Process"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Process = "Process";    //实施过程

 /// <summary>
 /// 常量:"LevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LevelId = "LevelId";    //级别Id

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"CitationId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CitationId = "CitationId";    //引用Id

 /// <summary>
 /// 常量:"OkCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OkCount = "OkCount";    //点赞统计

 /// <summary>
 /// 常量:"AppraiseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseCount = "AppraiseCount";    //评论数

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

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
}

}