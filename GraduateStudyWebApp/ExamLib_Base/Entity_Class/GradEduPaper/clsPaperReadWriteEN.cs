
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPaperReadWriteEN
 表名:PaperReadWrite(01120547)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:14:44
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
 /// 表PaperReadWrite的关键字(PaperRWId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperRWId_PaperReadWrite
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPaperRWId">表关键字</param>
public K_PaperRWId_PaperReadWrite(string strPaperRWId)
{
if (IsValid(strPaperRWId)) Value = strPaperRWId;
else
{
Value = null;
}
}
private static bool IsValid(string strPaperRWId)
{
if (string.IsNullOrEmpty(strPaperRWId) == true) return false;
if (strPaperRWId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PaperRWId_PaperReadWrite]类型的对象</returns>
public static implicit operator K_PaperRWId_PaperReadWrite(string value)
{
return new K_PaperRWId_PaperReadWrite(value);
}
}
 /// <summary>
 /// 论文读写表(PaperReadWrite)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPaperReadWriteEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PaperReadWrite"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperRWId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 16;
public static string[] AttributeName = new string[] {"PaperRWId", "ReaderId", "PaperId", "ResearchQuestion", "OperationTypeId", "UpdDate", "Memo", "IsSubmit", "IsPublic", "Submitter", "IdCurrEduCls", "SubVCount", "TeaCount", "CreateDate", "ShareId", "UpdUser"};

protected string mstrPaperRWId;    //课文阅读
protected string mstrReaderId;    //阅读者Id
protected string mstrPaperId;    //论文Id
protected string mstrResearchQuestion;    //研究问题
protected string mstrOperationTypeId;    //操作类型ID
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected bool mbolIsSubmit;    //是否提交
protected bool mbolIsPublic;    //是否公开
protected string mstrSubmitter;    //提交人
protected string mstrIdCurrEduCls;    //教学班流水号
protected int? mintSubVCount;    //论文子观点数
protected int? mintTeaCount;    //TeaCount
protected string mstrCreateDate;    //建立日期
protected string mstrShareId;    //分享Id
protected string mstrUpdUser;    //修改人

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsPaperReadWriteEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperRWId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strPaperRWId">关键字:课文阅读</param>
public clsPaperReadWriteEN(string strPaperRWId)
 {
strPaperRWId = strPaperRWId.Replace("'", "''");
if (strPaperRWId.Length > 8)
{
throw new Exception("在表:PaperReadWrite中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPaperRWId)  ==  true)
{
throw new Exception("在表:PaperReadWrite中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPaperRWId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPaperRWId = strPaperRWId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperRWId");
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
if (strAttributeName  ==  conPaperReadWrite.PaperRWId)
{
return mstrPaperRWId;
}
else if (strAttributeName  ==  conPaperReadWrite.ReaderId)
{
return mstrReaderId;
}
else if (strAttributeName  ==  conPaperReadWrite.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  conPaperReadWrite.ResearchQuestion)
{
return mstrResearchQuestion;
}
else if (strAttributeName  ==  conPaperReadWrite.OperationTypeId)
{
return mstrOperationTypeId;
}
else if (strAttributeName  ==  conPaperReadWrite.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conPaperReadWrite.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conPaperReadWrite.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  conPaperReadWrite.IsPublic)
{
return mbolIsPublic;
}
else if (strAttributeName  ==  conPaperReadWrite.Submitter)
{
return mstrSubmitter;
}
else if (strAttributeName  ==  conPaperReadWrite.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conPaperReadWrite.SubVCount)
{
return mintSubVCount;
}
else if (strAttributeName  ==  conPaperReadWrite.TeaCount)
{
return mintTeaCount;
}
else if (strAttributeName  ==  conPaperReadWrite.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  conPaperReadWrite.ShareId)
{
return mstrShareId;
}
else if (strAttributeName  ==  conPaperReadWrite.UpdUser)
{
return mstrUpdUser;
}
return null;
}
set
{
if (strAttributeName  ==  conPaperReadWrite.PaperRWId)
{
mstrPaperRWId = value.ToString();
 AddUpdatedFld(conPaperReadWrite.PaperRWId);
}
else if (strAttributeName  ==  conPaperReadWrite.ReaderId)
{
mstrReaderId = value.ToString();
 AddUpdatedFld(conPaperReadWrite.ReaderId);
}
else if (strAttributeName  ==  conPaperReadWrite.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(conPaperReadWrite.PaperId);
}
else if (strAttributeName  ==  conPaperReadWrite.ResearchQuestion)
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(conPaperReadWrite.ResearchQuestion);
}
else if (strAttributeName  ==  conPaperReadWrite.OperationTypeId)
{
mstrOperationTypeId = value.ToString();
 AddUpdatedFld(conPaperReadWrite.OperationTypeId);
}
else if (strAttributeName  ==  conPaperReadWrite.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPaperReadWrite.UpdDate);
}
else if (strAttributeName  ==  conPaperReadWrite.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPaperReadWrite.Memo);
}
else if (strAttributeName  ==  conPaperReadWrite.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conPaperReadWrite.IsSubmit);
}
else if (strAttributeName  ==  conPaperReadWrite.IsPublic)
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(conPaperReadWrite.IsPublic);
}
else if (strAttributeName  ==  conPaperReadWrite.Submitter)
{
mstrSubmitter = value.ToString();
 AddUpdatedFld(conPaperReadWrite.Submitter);
}
else if (strAttributeName  ==  conPaperReadWrite.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conPaperReadWrite.IdCurrEduCls);
}
else if (strAttributeName  ==  conPaperReadWrite.SubVCount)
{
mintSubVCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperReadWrite.SubVCount);
}
else if (strAttributeName  ==  conPaperReadWrite.TeaCount)
{
mintTeaCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperReadWrite.TeaCount);
}
else if (strAttributeName  ==  conPaperReadWrite.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conPaperReadWrite.CreateDate);
}
else if (strAttributeName  ==  conPaperReadWrite.ShareId)
{
mstrShareId = value.ToString();
 AddUpdatedFld(conPaperReadWrite.ShareId);
}
else if (strAttributeName  ==  conPaperReadWrite.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conPaperReadWrite.UpdUser);
}
}
}
public object this[int intIndex]
{
get
{
if (conPaperReadWrite.PaperRWId  ==  AttributeName[intIndex])
{
return mstrPaperRWId;
}
else if (conPaperReadWrite.ReaderId  ==  AttributeName[intIndex])
{
return mstrReaderId;
}
else if (conPaperReadWrite.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (conPaperReadWrite.ResearchQuestion  ==  AttributeName[intIndex])
{
return mstrResearchQuestion;
}
else if (conPaperReadWrite.OperationTypeId  ==  AttributeName[intIndex])
{
return mstrOperationTypeId;
}
else if (conPaperReadWrite.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conPaperReadWrite.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conPaperReadWrite.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (conPaperReadWrite.IsPublic  ==  AttributeName[intIndex])
{
return mbolIsPublic;
}
else if (conPaperReadWrite.Submitter  ==  AttributeName[intIndex])
{
return mstrSubmitter;
}
else if (conPaperReadWrite.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conPaperReadWrite.SubVCount  ==  AttributeName[intIndex])
{
return mintSubVCount;
}
else if (conPaperReadWrite.TeaCount  ==  AttributeName[intIndex])
{
return mintTeaCount;
}
else if (conPaperReadWrite.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (conPaperReadWrite.ShareId  ==  AttributeName[intIndex])
{
return mstrShareId;
}
else if (conPaperReadWrite.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
return null;
}
set
{
if (conPaperReadWrite.PaperRWId  ==  AttributeName[intIndex])
{
mstrPaperRWId = value.ToString();
 AddUpdatedFld(conPaperReadWrite.PaperRWId);
}
else if (conPaperReadWrite.ReaderId  ==  AttributeName[intIndex])
{
mstrReaderId = value.ToString();
 AddUpdatedFld(conPaperReadWrite.ReaderId);
}
else if (conPaperReadWrite.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(conPaperReadWrite.PaperId);
}
else if (conPaperReadWrite.ResearchQuestion  ==  AttributeName[intIndex])
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(conPaperReadWrite.ResearchQuestion);
}
else if (conPaperReadWrite.OperationTypeId  ==  AttributeName[intIndex])
{
mstrOperationTypeId = value.ToString();
 AddUpdatedFld(conPaperReadWrite.OperationTypeId);
}
else if (conPaperReadWrite.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPaperReadWrite.UpdDate);
}
else if (conPaperReadWrite.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPaperReadWrite.Memo);
}
else if (conPaperReadWrite.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conPaperReadWrite.IsSubmit);
}
else if (conPaperReadWrite.IsPublic  ==  AttributeName[intIndex])
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(conPaperReadWrite.IsPublic);
}
else if (conPaperReadWrite.Submitter  ==  AttributeName[intIndex])
{
mstrSubmitter = value.ToString();
 AddUpdatedFld(conPaperReadWrite.Submitter);
}
else if (conPaperReadWrite.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conPaperReadWrite.IdCurrEduCls);
}
else if (conPaperReadWrite.SubVCount  ==  AttributeName[intIndex])
{
mintSubVCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperReadWrite.SubVCount);
}
else if (conPaperReadWrite.TeaCount  ==  AttributeName[intIndex])
{
mintTeaCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperReadWrite.TeaCount);
}
else if (conPaperReadWrite.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conPaperReadWrite.CreateDate);
}
else if (conPaperReadWrite.ShareId  ==  AttributeName[intIndex])
{
mstrShareId = value.ToString();
 AddUpdatedFld(conPaperReadWrite.ShareId);
}
else if (conPaperReadWrite.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conPaperReadWrite.UpdUser);
}
}
}

/// <summary>
/// 课文阅读(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperRWId
{
get
{
return mstrPaperRWId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperRWId = value;
}
else
{
 mstrPaperRWId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaperReadWrite.PaperRWId);
}
}
/// <summary>
/// 阅读者Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReaderId
{
get
{
return mstrReaderId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReaderId = value;
}
else
{
 mstrReaderId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaperReadWrite.ReaderId);
}
}
/// <summary>
/// 论文Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperId
{
get
{
return mstrPaperId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperId = value;
}
else
{
 mstrPaperId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaperReadWrite.PaperId);
}
}
/// <summary>
/// 研究问题(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResearchQuestion
{
get
{
return mstrResearchQuestion;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResearchQuestion = value;
}
else
{
 mstrResearchQuestion = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaperReadWrite.ResearchQuestion);
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
 AddUpdatedFld(conPaperReadWrite.OperationTypeId);
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
 AddUpdatedFld(conPaperReadWrite.UpdDate);
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
 AddUpdatedFld(conPaperReadWrite.Memo);
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
 AddUpdatedFld(conPaperReadWrite.IsSubmit);
}
}
/// <summary>
/// 是否公开(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsPublic
{
get
{
return mbolIsPublic;
}
set
{
 mbolIsPublic = value;
//记录修改过的字段
 AddUpdatedFld(conPaperReadWrite.IsPublic);
}
}
/// <summary>
/// 提交人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Submitter
{
get
{
return mstrSubmitter;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSubmitter = value;
}
else
{
 mstrSubmitter = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaperReadWrite.Submitter);
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
 AddUpdatedFld(conPaperReadWrite.IdCurrEduCls);
}
}
/// <summary>
/// 论文子观点数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? SubVCount
{
get
{
return mintSubVCount;
}
set
{
 mintSubVCount = value;
//记录修改过的字段
 AddUpdatedFld(conPaperReadWrite.SubVCount);
}
}
/// <summary>
/// TeaCount(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? TeaCount
{
get
{
return mintTeaCount;
}
set
{
 mintTeaCount = value;
//记录修改过的字段
 AddUpdatedFld(conPaperReadWrite.TeaCount);
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
 AddUpdatedFld(conPaperReadWrite.CreateDate);
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
 AddUpdatedFld(conPaperReadWrite.ShareId);
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
 AddUpdatedFld(conPaperReadWrite.UpdUser);
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
  return mstrPaperRWId;
 }
 }
}
 /// <summary>
 /// 论文读写表(PaperReadWrite)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPaperReadWrite
{
public const string _CurrTabName = "PaperReadWrite"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperRWId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperRWId", "ReaderId", "PaperId", "ResearchQuestion", "OperationTypeId", "UpdDate", "Memo", "IsSubmit", "IsPublic", "Submitter", "IdCurrEduCls", "SubVCount", "TeaCount", "CreateDate", "ShareId", "UpdUser"};
//以下是属性变量


 /// <summary>
 /// 常量:"PaperRWId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperRWId = "PaperRWId";    //课文阅读

 /// <summary>
 /// 常量:"ReaderId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReaderId = "ReaderId";    //阅读者Id

 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

 /// <summary>
 /// 常量:"ResearchQuestion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResearchQuestion = "ResearchQuestion";    //研究问题

 /// <summary>
 /// 常量:"OperationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OperationTypeId = "OperationTypeId";    //操作类型ID

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
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"IsPublic"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsPublic = "IsPublic";    //是否公开

 /// <summary>
 /// 常量:"Submitter"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Submitter = "Submitter";    //提交人

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"SubVCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubVCount = "SubVCount";    //论文子观点数

 /// <summary>
 /// 常量:"TeaCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeaCount = "TeaCount";    //TeaCount

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