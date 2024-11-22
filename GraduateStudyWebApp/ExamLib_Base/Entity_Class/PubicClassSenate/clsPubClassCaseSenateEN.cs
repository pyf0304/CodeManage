
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPubClassCaseSenateEN
 表名:PubClassCaseSenate(01120411)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:17:49
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
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
 /// 表PubClassCaseSenate的关键字(IdPubClassCaseSenate)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdPubClassCaseSenate_PubClassCaseSenate
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdPubClassCaseSenate">表关键字</param>
public K_IdPubClassCaseSenate_PubClassCaseSenate(long lngIdPubClassCaseSenate)
{
if (IsValid(lngIdPubClassCaseSenate)) Value = lngIdPubClassCaseSenate;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdPubClassCaseSenate)
{
if (lngIdPubClassCaseSenate == 0) return false;
if (lngIdPubClassCaseSenate == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdPubClassCaseSenate_PubClassCaseSenate]类型的对象</returns>
public static implicit operator K_IdPubClassCaseSenate_PubClassCaseSenate(long value)
{
return new K_IdPubClassCaseSenate_PubClassCaseSenate(value);
}
}
 /// <summary>
 /// 公开课案例评议(PubClassCaseSenate)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPubClassCaseSenateEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PubClassCaseSenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdPubClassCaseSenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"IdPubClassCaseSenate", "IdPubClassCase", "IdPubClassCaseSenateClass", "PubClassCaseSenator", "PubClassCaseSenateTitle", "PubClassCaseSenateContent", "PubClassCaseSenateDate", "PubClassCaseSenateTime", "SenateReadCount", "IsVisual", "IsElite", "IdResource", "IdMediaType"};

protected long mlngIdPubClassCaseSenate;    //公开课案例评议流水号
protected string mstrIdPubClassCase;    //案例流水号
protected string mstrIdPubClassCaseSenateClass;    //公开课案例评议类别流水号
protected string mstrPubClassCaseSenator;    //公开课案例评议者
protected string mstrPubClassCaseSenateTitle;    //公开课案例评议标题
protected string mstrPubClassCaseSenateContent;    //公开课案例评议内容
protected string mstrPubClassCaseSenateDate;    //公开课案例评议日期
protected string mstrPubClassCaseSenateTime;    //公开课案例评议时间
protected int? mintSenateReadCount;    //评议阅读次数
protected bool mbolIsVisual;    //隐藏标志
protected bool mbolIsElite;    //精华标志
protected string mstrIdResource;    //资源流水号
protected string mstrIdMediaType;    //媒体格式流水号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsPubClassCaseSenateEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPubClassCaseSenate");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdPubClassCaseSenate">关键字:公开课案例评议流水号</param>
public clsPubClassCaseSenateEN(long lngIdPubClassCaseSenate)
 {
 if (lngIdPubClassCaseSenate  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdPubClassCaseSenate = lngIdPubClassCaseSenate;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPubClassCaseSenate");
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
if (strAttributeName  ==  conPubClassCaseSenate.IdPubClassCaseSenate)
{
return mlngIdPubClassCaseSenate;
}
else if (strAttributeName  ==  conPubClassCaseSenate.IdPubClassCase)
{
return mstrIdPubClassCase;
}
else if (strAttributeName  ==  conPubClassCaseSenate.IdPubClassCaseSenateClass)
{
return mstrIdPubClassCaseSenateClass;
}
else if (strAttributeName  ==  conPubClassCaseSenate.PubClassCaseSenator)
{
return mstrPubClassCaseSenator;
}
else if (strAttributeName  ==  conPubClassCaseSenate.PubClassCaseSenateTitle)
{
return mstrPubClassCaseSenateTitle;
}
else if (strAttributeName  ==  conPubClassCaseSenate.PubClassCaseSenateContent)
{
return mstrPubClassCaseSenateContent;
}
else if (strAttributeName  ==  conPubClassCaseSenate.PubClassCaseSenateDate)
{
return mstrPubClassCaseSenateDate;
}
else if (strAttributeName  ==  conPubClassCaseSenate.PubClassCaseSenateTime)
{
return mstrPubClassCaseSenateTime;
}
else if (strAttributeName  ==  conPubClassCaseSenate.SenateReadCount)
{
return mintSenateReadCount;
}
else if (strAttributeName  ==  conPubClassCaseSenate.IsVisual)
{
return mbolIsVisual;
}
else if (strAttributeName  ==  conPubClassCaseSenate.IsElite)
{
return mbolIsElite;
}
else if (strAttributeName  ==  conPubClassCaseSenate.IdResource)
{
return mstrIdResource;
}
else if (strAttributeName  ==  conPubClassCaseSenate.IdMediaType)
{
return mstrIdMediaType;
}
return null;
}
set
{
if (strAttributeName  ==  conPubClassCaseSenate.IdPubClassCaseSenate)
{
mlngIdPubClassCaseSenate = TransNullToInt(value.ToString());
 AddUpdatedFld(conPubClassCaseSenate.IdPubClassCaseSenate);
}
else if (strAttributeName  ==  conPubClassCaseSenate.IdPubClassCase)
{
mstrIdPubClassCase = value.ToString();
 AddUpdatedFld(conPubClassCaseSenate.IdPubClassCase);
}
else if (strAttributeName  ==  conPubClassCaseSenate.IdPubClassCaseSenateClass)
{
mstrIdPubClassCaseSenateClass = value.ToString();
 AddUpdatedFld(conPubClassCaseSenate.IdPubClassCaseSenateClass);
}
else if (strAttributeName  ==  conPubClassCaseSenate.PubClassCaseSenator)
{
mstrPubClassCaseSenator = value.ToString();
 AddUpdatedFld(conPubClassCaseSenate.PubClassCaseSenator);
}
else if (strAttributeName  ==  conPubClassCaseSenate.PubClassCaseSenateTitle)
{
mstrPubClassCaseSenateTitle = value.ToString();
 AddUpdatedFld(conPubClassCaseSenate.PubClassCaseSenateTitle);
}
else if (strAttributeName  ==  conPubClassCaseSenate.PubClassCaseSenateContent)
{
mstrPubClassCaseSenateContent = value.ToString();
 AddUpdatedFld(conPubClassCaseSenate.PubClassCaseSenateContent);
}
else if (strAttributeName  ==  conPubClassCaseSenate.PubClassCaseSenateDate)
{
mstrPubClassCaseSenateDate = value.ToString();
 AddUpdatedFld(conPubClassCaseSenate.PubClassCaseSenateDate);
}
else if (strAttributeName  ==  conPubClassCaseSenate.PubClassCaseSenateTime)
{
mstrPubClassCaseSenateTime = value.ToString();
 AddUpdatedFld(conPubClassCaseSenate.PubClassCaseSenateTime);
}
else if (strAttributeName  ==  conPubClassCaseSenate.SenateReadCount)
{
mintSenateReadCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPubClassCaseSenate.SenateReadCount);
}
else if (strAttributeName  ==  conPubClassCaseSenate.IsVisual)
{
mbolIsVisual = TransNullToBool(value.ToString());
 AddUpdatedFld(conPubClassCaseSenate.IsVisual);
}
else if (strAttributeName  ==  conPubClassCaseSenate.IsElite)
{
mbolIsElite = TransNullToBool(value.ToString());
 AddUpdatedFld(conPubClassCaseSenate.IsElite);
}
else if (strAttributeName  ==  conPubClassCaseSenate.IdResource)
{
mstrIdResource = value.ToString();
 AddUpdatedFld(conPubClassCaseSenate.IdResource);
}
else if (strAttributeName  ==  conPubClassCaseSenate.IdMediaType)
{
mstrIdMediaType = value.ToString();
 AddUpdatedFld(conPubClassCaseSenate.IdMediaType);
}
}
}
public object this[int intIndex]
{
get
{
if (conPubClassCaseSenate.IdPubClassCaseSenate  ==  AttributeName[intIndex])
{
return mlngIdPubClassCaseSenate;
}
else if (conPubClassCaseSenate.IdPubClassCase  ==  AttributeName[intIndex])
{
return mstrIdPubClassCase;
}
else if (conPubClassCaseSenate.IdPubClassCaseSenateClass  ==  AttributeName[intIndex])
{
return mstrIdPubClassCaseSenateClass;
}
else if (conPubClassCaseSenate.PubClassCaseSenator  ==  AttributeName[intIndex])
{
return mstrPubClassCaseSenator;
}
else if (conPubClassCaseSenate.PubClassCaseSenateTitle  ==  AttributeName[intIndex])
{
return mstrPubClassCaseSenateTitle;
}
else if (conPubClassCaseSenate.PubClassCaseSenateContent  ==  AttributeName[intIndex])
{
return mstrPubClassCaseSenateContent;
}
else if (conPubClassCaseSenate.PubClassCaseSenateDate  ==  AttributeName[intIndex])
{
return mstrPubClassCaseSenateDate;
}
else if (conPubClassCaseSenate.PubClassCaseSenateTime  ==  AttributeName[intIndex])
{
return mstrPubClassCaseSenateTime;
}
else if (conPubClassCaseSenate.SenateReadCount  ==  AttributeName[intIndex])
{
return mintSenateReadCount;
}
else if (conPubClassCaseSenate.IsVisual  ==  AttributeName[intIndex])
{
return mbolIsVisual;
}
else if (conPubClassCaseSenate.IsElite  ==  AttributeName[intIndex])
{
return mbolIsElite;
}
else if (conPubClassCaseSenate.IdResource  ==  AttributeName[intIndex])
{
return mstrIdResource;
}
else if (conPubClassCaseSenate.IdMediaType  ==  AttributeName[intIndex])
{
return mstrIdMediaType;
}
return null;
}
set
{
if (conPubClassCaseSenate.IdPubClassCaseSenate  ==  AttributeName[intIndex])
{
mlngIdPubClassCaseSenate = TransNullToInt(value.ToString());
 AddUpdatedFld(conPubClassCaseSenate.IdPubClassCaseSenate);
}
else if (conPubClassCaseSenate.IdPubClassCase  ==  AttributeName[intIndex])
{
mstrIdPubClassCase = value.ToString();
 AddUpdatedFld(conPubClassCaseSenate.IdPubClassCase);
}
else if (conPubClassCaseSenate.IdPubClassCaseSenateClass  ==  AttributeName[intIndex])
{
mstrIdPubClassCaseSenateClass = value.ToString();
 AddUpdatedFld(conPubClassCaseSenate.IdPubClassCaseSenateClass);
}
else if (conPubClassCaseSenate.PubClassCaseSenator  ==  AttributeName[intIndex])
{
mstrPubClassCaseSenator = value.ToString();
 AddUpdatedFld(conPubClassCaseSenate.PubClassCaseSenator);
}
else if (conPubClassCaseSenate.PubClassCaseSenateTitle  ==  AttributeName[intIndex])
{
mstrPubClassCaseSenateTitle = value.ToString();
 AddUpdatedFld(conPubClassCaseSenate.PubClassCaseSenateTitle);
}
else if (conPubClassCaseSenate.PubClassCaseSenateContent  ==  AttributeName[intIndex])
{
mstrPubClassCaseSenateContent = value.ToString();
 AddUpdatedFld(conPubClassCaseSenate.PubClassCaseSenateContent);
}
else if (conPubClassCaseSenate.PubClassCaseSenateDate  ==  AttributeName[intIndex])
{
mstrPubClassCaseSenateDate = value.ToString();
 AddUpdatedFld(conPubClassCaseSenate.PubClassCaseSenateDate);
}
else if (conPubClassCaseSenate.PubClassCaseSenateTime  ==  AttributeName[intIndex])
{
mstrPubClassCaseSenateTime = value.ToString();
 AddUpdatedFld(conPubClassCaseSenate.PubClassCaseSenateTime);
}
else if (conPubClassCaseSenate.SenateReadCount  ==  AttributeName[intIndex])
{
mintSenateReadCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPubClassCaseSenate.SenateReadCount);
}
else if (conPubClassCaseSenate.IsVisual  ==  AttributeName[intIndex])
{
mbolIsVisual = TransNullToBool(value.ToString());
 AddUpdatedFld(conPubClassCaseSenate.IsVisual);
}
else if (conPubClassCaseSenate.IsElite  ==  AttributeName[intIndex])
{
mbolIsElite = TransNullToBool(value.ToString());
 AddUpdatedFld(conPubClassCaseSenate.IsElite);
}
else if (conPubClassCaseSenate.IdResource  ==  AttributeName[intIndex])
{
mstrIdResource = value.ToString();
 AddUpdatedFld(conPubClassCaseSenate.IdResource);
}
else if (conPubClassCaseSenate.IdMediaType  ==  AttributeName[intIndex])
{
mstrIdMediaType = value.ToString();
 AddUpdatedFld(conPubClassCaseSenate.IdMediaType);
}
}
}

/// <summary>
/// 公开课案例评议流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdPubClassCaseSenate
{
get
{
return mlngIdPubClassCaseSenate;
}
set
{
 mlngIdPubClassCaseSenate = value;
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseSenate.IdPubClassCaseSenate);
}
}
/// <summary>
/// 案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdPubClassCase
{
get
{
return mstrIdPubClassCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdPubClassCase = value;
}
else
{
 mstrIdPubClassCase = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseSenate.IdPubClassCase);
}
}
/// <summary>
/// 公开课案例评议类别流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdPubClassCaseSenateClass
{
get
{
return mstrIdPubClassCaseSenateClass;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdPubClassCaseSenateClass = value;
}
else
{
 mstrIdPubClassCaseSenateClass = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseSenate.IdPubClassCaseSenateClass);
}
}
/// <summary>
/// 公开课案例评议者(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseSenator
{
get
{
return mstrPubClassCaseSenator;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseSenator = value;
}
else
{
 mstrPubClassCaseSenator = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseSenate.PubClassCaseSenator);
}
}
/// <summary>
/// 公开课案例评议标题(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseSenateTitle
{
get
{
return mstrPubClassCaseSenateTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseSenateTitle = value;
}
else
{
 mstrPubClassCaseSenateTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseSenate.PubClassCaseSenateTitle);
}
}
/// <summary>
/// 公开课案例评议内容(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseSenateContent
{
get
{
return mstrPubClassCaseSenateContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseSenateContent = value;
}
else
{
 mstrPubClassCaseSenateContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseSenate.PubClassCaseSenateContent);
}
}
/// <summary>
/// 公开课案例评议日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseSenateDate
{
get
{
return mstrPubClassCaseSenateDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseSenateDate = value;
}
else
{
 mstrPubClassCaseSenateDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseSenate.PubClassCaseSenateDate);
}
}
/// <summary>
/// 公开课案例评议时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseSenateTime
{
get
{
return mstrPubClassCaseSenateTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseSenateTime = value;
}
else
{
 mstrPubClassCaseSenateTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseSenate.PubClassCaseSenateTime);
}
}
/// <summary>
/// 评议阅读次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? SenateReadCount
{
get
{
return mintSenateReadCount;
}
set
{
 mintSenateReadCount = value;
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseSenate.SenateReadCount);
}
}
/// <summary>
/// 隐藏标志(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsVisual
{
get
{
return mbolIsVisual;
}
set
{
 mbolIsVisual = value;
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseSenate.IsVisual);
}
}
/// <summary>
/// 精华标志(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsElite
{
get
{
return mbolIsElite;
}
set
{
 mbolIsElite = value;
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseSenate.IsElite);
}
}
/// <summary>
/// 资源流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdResource
{
get
{
return mstrIdResource;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdResource = value;
}
else
{
 mstrIdResource = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseSenate.IdResource);
}
}
/// <summary>
/// 媒体格式流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdMediaType
{
get
{
return mstrIdMediaType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdMediaType = value;
}
else
{
 mstrIdMediaType = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubClassCaseSenate.IdMediaType);
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
  return mlngIdPubClassCaseSenate.ToString();
 }
 }
}
 /// <summary>
 /// 公开课案例评议(PubClassCaseSenate)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPubClassCaseSenate
{
public const string _CurrTabName = "PubClassCaseSenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdPubClassCaseSenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdPubClassCaseSenate", "IdPubClassCase", "IdPubClassCaseSenateClass", "PubClassCaseSenator", "PubClassCaseSenateTitle", "PubClassCaseSenateContent", "PubClassCaseSenateDate", "PubClassCaseSenateTime", "SenateReadCount", "IsVisual", "IsElite", "IdResource", "IdMediaType"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdPubClassCaseSenate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubClassCaseSenate = "IdPubClassCaseSenate";    //公开课案例评议流水号

 /// <summary>
 /// 常量:"IdPubClassCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubClassCase = "IdPubClassCase";    //案例流水号

 /// <summary>
 /// 常量:"IdPubClassCaseSenateClass"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubClassCaseSenateClass = "IdPubClassCaseSenateClass";    //公开课案例评议类别流水号

 /// <summary>
 /// 常量:"PubClassCaseSenator"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseSenator = "PubClassCaseSenator";    //公开课案例评议者

 /// <summary>
 /// 常量:"PubClassCaseSenateTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseSenateTitle = "PubClassCaseSenateTitle";    //公开课案例评议标题

 /// <summary>
 /// 常量:"PubClassCaseSenateContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseSenateContent = "PubClassCaseSenateContent";    //公开课案例评议内容

 /// <summary>
 /// 常量:"PubClassCaseSenateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseSenateDate = "PubClassCaseSenateDate";    //公开课案例评议日期

 /// <summary>
 /// 常量:"PubClassCaseSenateTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseSenateTime = "PubClassCaseSenateTime";    //公开课案例评议时间

 /// <summary>
 /// 常量:"SenateReadCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SenateReadCount = "SenateReadCount";    //评议阅读次数

 /// <summary>
 /// 常量:"IsVisual"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisual = "IsVisual";    //隐藏标志

 /// <summary>
 /// 常量:"IsElite"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsElite = "IsElite";    //精华标志

 /// <summary>
 /// 常量:"IdResource"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdResource = "IdResource";    //资源流水号

 /// <summary>
 /// 常量:"IdMediaType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMediaType = "IdMediaType";    //媒体格式流水号
}

}