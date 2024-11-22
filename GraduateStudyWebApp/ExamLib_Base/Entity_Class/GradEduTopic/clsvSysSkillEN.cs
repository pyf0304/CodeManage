
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSysSkillEN
 表名:vSysSkill(01120653)
 * 版本:2023.10.02.1(服务器:WIN-SRV103-116)
 日期:2023/10/08 16:37:22
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 表vSysSkill的关键字(SkillId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_SkillId_vSysSkill
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
public K_SkillId_vSysSkill(string strSkillId)
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
 /// <returns>返回:[K_SkillId_vSysSkill]类型的对象</returns>
public static implicit operator K_SkillId_vSysSkill(string value)
{
return new K_SkillId_vSysSkill(value);
}
}
 /// <summary>
 /// 技能表视图(vSysSkill)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvSysSkillEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vSysSkill"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "SkillId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 24;
public static string[] AttributeName = new string[] {"SkillId", "SkillName", "Process", "OperationTypeId", "LevelId", "LevelName", "UpdUser", "UpdDate", "IsSubmit", "CitationId", "OkCount", "AppraiseCount", "Score", "StuScore", "TeaScore", "IdCurrEduCls", "PdfContent", "PdfPageNum", "CitationCount", "VersionCount", "Memo", "OperationTypeName", "CreateDate", "ShareId"};

protected string mstrSkillId;    //技能Id
protected string mstrSkillName;    //技能名称
protected string mstrProcess;    //实施过程
protected string mstrOperationTypeId;    //操作类型ID
protected string mstrLevelId;    //级别Id
protected string mstrLevelName;    //级别名称
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
protected string mstrOperationTypeName;    //操作类型名
protected string mstrCreateDate;    //建立日期
protected string mstrShareId;    //分享Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvSysSkillEN()
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
public clsvSysSkillEN(string strSkillId)
 {
strSkillId = strSkillId.Replace("'", "''");
if (strSkillId.Length > 10)
{
throw new Exception("在表:vSysSkill中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strSkillId)  ==  true)
{
throw new Exception("在表:vSysSkill中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convSysSkill.SkillId)
{
return mstrSkillId;
}
else if (strAttributeName  ==  convSysSkill.SkillName)
{
return mstrSkillName;
}
else if (strAttributeName  ==  convSysSkill.Process)
{
return mstrProcess;
}
else if (strAttributeName  ==  convSysSkill.OperationTypeId)
{
return mstrOperationTypeId;
}
else if (strAttributeName  ==  convSysSkill.LevelId)
{
return mstrLevelId;
}
else if (strAttributeName  ==  convSysSkill.LevelName)
{
return mstrLevelName;
}
else if (strAttributeName  ==  convSysSkill.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convSysSkill.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convSysSkill.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convSysSkill.CitationId)
{
return mstrCitationId;
}
else if (strAttributeName  ==  convSysSkill.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  convSysSkill.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convSysSkill.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convSysSkill.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convSysSkill.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convSysSkill.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convSysSkill.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  convSysSkill.PdfPageNum)
{
return mintPdfPageNum;
}
else if (strAttributeName  ==  convSysSkill.CitationCount)
{
return mintCitationCount;
}
else if (strAttributeName  ==  convSysSkill.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  convSysSkill.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convSysSkill.OperationTypeName)
{
return mstrOperationTypeName;
}
else if (strAttributeName  ==  convSysSkill.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convSysSkill.ShareId)
{
return mstrShareId;
}
return null;
}
set
{
if (strAttributeName  ==  convSysSkill.SkillId)
{
mstrSkillId = value.ToString();
 AddUpdatedFld(convSysSkill.SkillId);
}
else if (strAttributeName  ==  convSysSkill.SkillName)
{
mstrSkillName = value.ToString();
 AddUpdatedFld(convSysSkill.SkillName);
}
else if (strAttributeName  ==  convSysSkill.Process)
{
mstrProcess = value.ToString();
 AddUpdatedFld(convSysSkill.Process);
}
else if (strAttributeName  ==  convSysSkill.OperationTypeId)
{
mstrOperationTypeId = value.ToString();
 AddUpdatedFld(convSysSkill.OperationTypeId);
}
else if (strAttributeName  ==  convSysSkill.LevelId)
{
mstrLevelId = value.ToString();
 AddUpdatedFld(convSysSkill.LevelId);
}
else if (strAttributeName  ==  convSysSkill.LevelName)
{
mstrLevelName = value.ToString();
 AddUpdatedFld(convSysSkill.LevelName);
}
else if (strAttributeName  ==  convSysSkill.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convSysSkill.UpdUser);
}
else if (strAttributeName  ==  convSysSkill.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSysSkill.UpdDate);
}
else if (strAttributeName  ==  convSysSkill.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convSysSkill.IsSubmit);
}
else if (strAttributeName  ==  convSysSkill.CitationId)
{
mstrCitationId = value.ToString();
 AddUpdatedFld(convSysSkill.CitationId);
}
else if (strAttributeName  ==  convSysSkill.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysSkill.OkCount);
}
else if (strAttributeName  ==  convSysSkill.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysSkill.AppraiseCount);
}
else if (strAttributeName  ==  convSysSkill.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSysSkill.Score);
}
else if (strAttributeName  ==  convSysSkill.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSysSkill.StuScore);
}
else if (strAttributeName  ==  convSysSkill.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSysSkill.TeaScore);
}
else if (strAttributeName  ==  convSysSkill.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convSysSkill.IdCurrEduCls);
}
else if (strAttributeName  ==  convSysSkill.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convSysSkill.PdfContent);
}
else if (strAttributeName  ==  convSysSkill.PdfPageNum)
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysSkill.PdfPageNum);
}
else if (strAttributeName  ==  convSysSkill.CitationCount)
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysSkill.CitationCount);
}
else if (strAttributeName  ==  convSysSkill.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysSkill.VersionCount);
}
else if (strAttributeName  ==  convSysSkill.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSysSkill.Memo);
}
else if (strAttributeName  ==  convSysSkill.OperationTypeName)
{
mstrOperationTypeName = value.ToString();
 AddUpdatedFld(convSysSkill.OperationTypeName);
}
else if (strAttributeName  ==  convSysSkill.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convSysSkill.CreateDate);
}
else if (strAttributeName  ==  convSysSkill.ShareId)
{
mstrShareId = value.ToString();
 AddUpdatedFld(convSysSkill.ShareId);
}
}
}
public object this[int intIndex]
{
get
{
if (convSysSkill.SkillId  ==  AttributeName[intIndex])
{
return mstrSkillId;
}
else if (convSysSkill.SkillName  ==  AttributeName[intIndex])
{
return mstrSkillName;
}
else if (convSysSkill.Process  ==  AttributeName[intIndex])
{
return mstrProcess;
}
else if (convSysSkill.OperationTypeId  ==  AttributeName[intIndex])
{
return mstrOperationTypeId;
}
else if (convSysSkill.LevelId  ==  AttributeName[intIndex])
{
return mstrLevelId;
}
else if (convSysSkill.LevelName  ==  AttributeName[intIndex])
{
return mstrLevelName;
}
else if (convSysSkill.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convSysSkill.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convSysSkill.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convSysSkill.CitationId  ==  AttributeName[intIndex])
{
return mstrCitationId;
}
else if (convSysSkill.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (convSysSkill.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convSysSkill.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convSysSkill.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convSysSkill.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convSysSkill.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convSysSkill.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (convSysSkill.PdfPageNum  ==  AttributeName[intIndex])
{
return mintPdfPageNum;
}
else if (convSysSkill.CitationCount  ==  AttributeName[intIndex])
{
return mintCitationCount;
}
else if (convSysSkill.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (convSysSkill.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convSysSkill.OperationTypeName  ==  AttributeName[intIndex])
{
return mstrOperationTypeName;
}
else if (convSysSkill.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convSysSkill.ShareId  ==  AttributeName[intIndex])
{
return mstrShareId;
}
return null;
}
set
{
if (convSysSkill.SkillId  ==  AttributeName[intIndex])
{
mstrSkillId = value.ToString();
 AddUpdatedFld(convSysSkill.SkillId);
}
else if (convSysSkill.SkillName  ==  AttributeName[intIndex])
{
mstrSkillName = value.ToString();
 AddUpdatedFld(convSysSkill.SkillName);
}
else if (convSysSkill.Process  ==  AttributeName[intIndex])
{
mstrProcess = value.ToString();
 AddUpdatedFld(convSysSkill.Process);
}
else if (convSysSkill.OperationTypeId  ==  AttributeName[intIndex])
{
mstrOperationTypeId = value.ToString();
 AddUpdatedFld(convSysSkill.OperationTypeId);
}
else if (convSysSkill.LevelId  ==  AttributeName[intIndex])
{
mstrLevelId = value.ToString();
 AddUpdatedFld(convSysSkill.LevelId);
}
else if (convSysSkill.LevelName  ==  AttributeName[intIndex])
{
mstrLevelName = value.ToString();
 AddUpdatedFld(convSysSkill.LevelName);
}
else if (convSysSkill.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convSysSkill.UpdUser);
}
else if (convSysSkill.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSysSkill.UpdDate);
}
else if (convSysSkill.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convSysSkill.IsSubmit);
}
else if (convSysSkill.CitationId  ==  AttributeName[intIndex])
{
mstrCitationId = value.ToString();
 AddUpdatedFld(convSysSkill.CitationId);
}
else if (convSysSkill.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysSkill.OkCount);
}
else if (convSysSkill.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysSkill.AppraiseCount);
}
else if (convSysSkill.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSysSkill.Score);
}
else if (convSysSkill.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSysSkill.StuScore);
}
else if (convSysSkill.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSysSkill.TeaScore);
}
else if (convSysSkill.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convSysSkill.IdCurrEduCls);
}
else if (convSysSkill.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convSysSkill.PdfContent);
}
else if (convSysSkill.PdfPageNum  ==  AttributeName[intIndex])
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysSkill.PdfPageNum);
}
else if (convSysSkill.CitationCount  ==  AttributeName[intIndex])
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysSkill.CitationCount);
}
else if (convSysSkill.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysSkill.VersionCount);
}
else if (convSysSkill.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSysSkill.Memo);
}
else if (convSysSkill.OperationTypeName  ==  AttributeName[intIndex])
{
mstrOperationTypeName = value.ToString();
 AddUpdatedFld(convSysSkill.OperationTypeName);
}
else if (convSysSkill.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convSysSkill.CreateDate);
}
else if (convSysSkill.ShareId  ==  AttributeName[intIndex])
{
mstrShareId = value.ToString();
 AddUpdatedFld(convSysSkill.ShareId);
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
 AddUpdatedFld(convSysSkill.SkillId);
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
 AddUpdatedFld(convSysSkill.SkillName);
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
 AddUpdatedFld(convSysSkill.Process);
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
 AddUpdatedFld(convSysSkill.OperationTypeId);
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
 AddUpdatedFld(convSysSkill.LevelId);
}
}
/// <summary>
/// 级别名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LevelName
{
get
{
return mstrLevelName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLevelName = value;
}
else
{
 mstrLevelName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysSkill.LevelName);
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
 AddUpdatedFld(convSysSkill.UpdUser);
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
 AddUpdatedFld(convSysSkill.UpdDate);
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
 AddUpdatedFld(convSysSkill.IsSubmit);
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
 AddUpdatedFld(convSysSkill.CitationId);
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
 AddUpdatedFld(convSysSkill.OkCount);
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
 AddUpdatedFld(convSysSkill.AppraiseCount);
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
 AddUpdatedFld(convSysSkill.Score);
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
 AddUpdatedFld(convSysSkill.StuScore);
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
 AddUpdatedFld(convSysSkill.TeaScore);
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
 AddUpdatedFld(convSysSkill.IdCurrEduCls);
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
 AddUpdatedFld(convSysSkill.PdfContent);
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
 AddUpdatedFld(convSysSkill.PdfPageNum);
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
 AddUpdatedFld(convSysSkill.CitationCount);
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
 AddUpdatedFld(convSysSkill.VersionCount);
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
 AddUpdatedFld(convSysSkill.Memo);
}
}
/// <summary>
/// 操作类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OperationTypeName
{
get
{
return mstrOperationTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOperationTypeName = value;
}
else
{
 mstrOperationTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysSkill.OperationTypeName);
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
 AddUpdatedFld(convSysSkill.CreateDate);
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
 AddUpdatedFld(convSysSkill.ShareId);
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

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrOperationTypeName;
 }
 }
}
 /// <summary>
 /// 技能表视图(vSysSkill)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convSysSkill
{
public const string _CurrTabName = "vSysSkill"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SkillId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"SkillId", "SkillName", "Process", "OperationTypeId", "LevelId", "LevelName", "UpdUser", "UpdDate", "IsSubmit", "CitationId", "OkCount", "AppraiseCount", "Score", "StuScore", "TeaScore", "IdCurrEduCls", "PdfContent", "PdfPageNum", "CitationCount", "VersionCount", "Memo", "OperationTypeName", "CreateDate", "ShareId"};
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
 /// 常量:"Process"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Process = "Process";    //实施过程

 /// <summary>
 /// 常量:"OperationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OperationTypeId = "OperationTypeId";    //操作类型ID

 /// <summary>
 /// 常量:"LevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LevelId = "LevelId";    //级别Id

 /// <summary>
 /// 常量:"LevelName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LevelName = "LevelName";    //级别名称

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
 /// 常量:"OperationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OperationTypeName = "OperationTypeName";    //操作类型名

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