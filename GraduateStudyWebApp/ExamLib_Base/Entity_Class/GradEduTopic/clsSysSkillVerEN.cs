
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysSkillVerEN
 表名:SysSkillVer(01120647)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:15:22
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
 /// 表SysSkillVer的关键字(SkillVId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_SkillVId_SysSkillVer
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngSkillVId">表关键字</param>
public K_SkillVId_SysSkillVer(long lngSkillVId)
{
if (IsValid(lngSkillVId)) Value = lngSkillVId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngSkillVId)
{
if (lngSkillVId == 0) return false;
if (lngSkillVId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_SkillVId_SysSkillVer]类型的对象</returns>
public static implicit operator K_SkillVId_SysSkillVer(long value)
{
return new K_SkillVId_SysSkillVer(value);
}
}
 /// <summary>
 /// 系统技能版本(SysSkillVer)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSysSkillVerEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SysSkillVer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "SkillVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"SkillVId", "SkillId", "SkillName", "OperationTypeId", "Process", "LevelId", "UpdUser", "UpdDate", "CitationId", "IdCurrEduCls", "PdfContent", "PdfPageNum", "Memo"};

protected long mlngSkillVId;    //SkillVId
protected string mstrSkillId;    //技能Id
protected string mstrSkillName;    //技能名称
protected string mstrOperationTypeId;    //操作类型ID
protected string mstrProcess;    //实施过程
protected string mstrLevelId;    //级别Id
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrCitationId;    //引用Id
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrPdfContent;    //Pdf内容
protected int? mintPdfPageNum;    //Pdf页码
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsSysSkillVerEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SkillVId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngSkillVId">关键字:SkillVId</param>
public clsSysSkillVerEN(long lngSkillVId)
 {
 if (lngSkillVId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngSkillVId = lngSkillVId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SkillVId");
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
if (strAttributeName  ==  conSysSkillVer.SkillVId)
{
return mlngSkillVId;
}
else if (strAttributeName  ==  conSysSkillVer.SkillId)
{
return mstrSkillId;
}
else if (strAttributeName  ==  conSysSkillVer.SkillName)
{
return mstrSkillName;
}
else if (strAttributeName  ==  conSysSkillVer.OperationTypeId)
{
return mstrOperationTypeId;
}
else if (strAttributeName  ==  conSysSkillVer.Process)
{
return mstrProcess;
}
else if (strAttributeName  ==  conSysSkillVer.LevelId)
{
return mstrLevelId;
}
else if (strAttributeName  ==  conSysSkillVer.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conSysSkillVer.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conSysSkillVer.CitationId)
{
return mstrCitationId;
}
else if (strAttributeName  ==  conSysSkillVer.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conSysSkillVer.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  conSysSkillVer.PdfPageNum)
{
return mintPdfPageNum;
}
else if (strAttributeName  ==  conSysSkillVer.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conSysSkillVer.SkillVId)
{
mlngSkillVId = TransNullToInt(value.ToString());
 AddUpdatedFld(conSysSkillVer.SkillVId);
}
else if (strAttributeName  ==  conSysSkillVer.SkillId)
{
mstrSkillId = value.ToString();
 AddUpdatedFld(conSysSkillVer.SkillId);
}
else if (strAttributeName  ==  conSysSkillVer.SkillName)
{
mstrSkillName = value.ToString();
 AddUpdatedFld(conSysSkillVer.SkillName);
}
else if (strAttributeName  ==  conSysSkillVer.OperationTypeId)
{
mstrOperationTypeId = value.ToString();
 AddUpdatedFld(conSysSkillVer.OperationTypeId);
}
else if (strAttributeName  ==  conSysSkillVer.Process)
{
mstrProcess = value.ToString();
 AddUpdatedFld(conSysSkillVer.Process);
}
else if (strAttributeName  ==  conSysSkillVer.LevelId)
{
mstrLevelId = value.ToString();
 AddUpdatedFld(conSysSkillVer.LevelId);
}
else if (strAttributeName  ==  conSysSkillVer.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conSysSkillVer.UpdUser);
}
else if (strAttributeName  ==  conSysSkillVer.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSysSkillVer.UpdDate);
}
else if (strAttributeName  ==  conSysSkillVer.CitationId)
{
mstrCitationId = value.ToString();
 AddUpdatedFld(conSysSkillVer.CitationId);
}
else if (strAttributeName  ==  conSysSkillVer.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conSysSkillVer.IdCurrEduCls);
}
else if (strAttributeName  ==  conSysSkillVer.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(conSysSkillVer.PdfContent);
}
else if (strAttributeName  ==  conSysSkillVer.PdfPageNum)
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conSysSkillVer.PdfPageNum);
}
else if (strAttributeName  ==  conSysSkillVer.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSysSkillVer.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conSysSkillVer.SkillVId  ==  AttributeName[intIndex])
{
return mlngSkillVId;
}
else if (conSysSkillVer.SkillId  ==  AttributeName[intIndex])
{
return mstrSkillId;
}
else if (conSysSkillVer.SkillName  ==  AttributeName[intIndex])
{
return mstrSkillName;
}
else if (conSysSkillVer.OperationTypeId  ==  AttributeName[intIndex])
{
return mstrOperationTypeId;
}
else if (conSysSkillVer.Process  ==  AttributeName[intIndex])
{
return mstrProcess;
}
else if (conSysSkillVer.LevelId  ==  AttributeName[intIndex])
{
return mstrLevelId;
}
else if (conSysSkillVer.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conSysSkillVer.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conSysSkillVer.CitationId  ==  AttributeName[intIndex])
{
return mstrCitationId;
}
else if (conSysSkillVer.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conSysSkillVer.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (conSysSkillVer.PdfPageNum  ==  AttributeName[intIndex])
{
return mintPdfPageNum;
}
else if (conSysSkillVer.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conSysSkillVer.SkillVId  ==  AttributeName[intIndex])
{
mlngSkillVId = TransNullToInt(value.ToString());
 AddUpdatedFld(conSysSkillVer.SkillVId);
}
else if (conSysSkillVer.SkillId  ==  AttributeName[intIndex])
{
mstrSkillId = value.ToString();
 AddUpdatedFld(conSysSkillVer.SkillId);
}
else if (conSysSkillVer.SkillName  ==  AttributeName[intIndex])
{
mstrSkillName = value.ToString();
 AddUpdatedFld(conSysSkillVer.SkillName);
}
else if (conSysSkillVer.OperationTypeId  ==  AttributeName[intIndex])
{
mstrOperationTypeId = value.ToString();
 AddUpdatedFld(conSysSkillVer.OperationTypeId);
}
else if (conSysSkillVer.Process  ==  AttributeName[intIndex])
{
mstrProcess = value.ToString();
 AddUpdatedFld(conSysSkillVer.Process);
}
else if (conSysSkillVer.LevelId  ==  AttributeName[intIndex])
{
mstrLevelId = value.ToString();
 AddUpdatedFld(conSysSkillVer.LevelId);
}
else if (conSysSkillVer.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conSysSkillVer.UpdUser);
}
else if (conSysSkillVer.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSysSkillVer.UpdDate);
}
else if (conSysSkillVer.CitationId  ==  AttributeName[intIndex])
{
mstrCitationId = value.ToString();
 AddUpdatedFld(conSysSkillVer.CitationId);
}
else if (conSysSkillVer.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conSysSkillVer.IdCurrEduCls);
}
else if (conSysSkillVer.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(conSysSkillVer.PdfContent);
}
else if (conSysSkillVer.PdfPageNum  ==  AttributeName[intIndex])
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conSysSkillVer.PdfPageNum);
}
else if (conSysSkillVer.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSysSkillVer.Memo);
}
}
}

/// <summary>
/// SkillVId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long SkillVId
{
get
{
return mlngSkillVId;
}
set
{
 mlngSkillVId = value;
//记录修改过的字段
 AddUpdatedFld(conSysSkillVer.SkillVId);
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
 AddUpdatedFld(conSysSkillVer.SkillId);
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
 AddUpdatedFld(conSysSkillVer.SkillName);
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
 AddUpdatedFld(conSysSkillVer.OperationTypeId);
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
 AddUpdatedFld(conSysSkillVer.Process);
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
 AddUpdatedFld(conSysSkillVer.LevelId);
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
 AddUpdatedFld(conSysSkillVer.UpdUser);
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
 AddUpdatedFld(conSysSkillVer.UpdDate);
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
 AddUpdatedFld(conSysSkillVer.CitationId);
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
 AddUpdatedFld(conSysSkillVer.IdCurrEduCls);
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
 AddUpdatedFld(conSysSkillVer.PdfContent);
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
 AddUpdatedFld(conSysSkillVer.PdfPageNum);
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
 AddUpdatedFld(conSysSkillVer.Memo);
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
  return mlngSkillVId.ToString();
 }
 }
}
 /// <summary>
 /// 系统技能版本(SysSkillVer)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSysSkillVer
{
public const string _CurrTabName = "SysSkillVer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SkillVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"SkillVId", "SkillId", "SkillName", "OperationTypeId", "Process", "LevelId", "UpdUser", "UpdDate", "CitationId", "IdCurrEduCls", "PdfContent", "PdfPageNum", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"SkillVId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SkillVId = "SkillVId";    //SkillVId

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
 /// 常量:"CitationId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CitationId = "CitationId";    //引用Id

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}