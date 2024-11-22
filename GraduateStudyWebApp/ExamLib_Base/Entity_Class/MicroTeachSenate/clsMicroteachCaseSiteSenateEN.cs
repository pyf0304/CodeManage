
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMicroteachCaseSiteSenateEN
 表名:MicroteachCaseSiteSenate(01120458)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:16:59
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
 /// 表MicroteachCaseSiteSenate的关键字(IdMicroteachCaseSiteSenate)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdMicroteachCaseSiteSenate_MicroteachCaseSiteSenate
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdMicroteachCaseSiteSenate">表关键字</param>
public K_IdMicroteachCaseSiteSenate_MicroteachCaseSiteSenate(long lngIdMicroteachCaseSiteSenate)
{
if (IsValid(lngIdMicroteachCaseSiteSenate)) Value = lngIdMicroteachCaseSiteSenate;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdMicroteachCaseSiteSenate)
{
if (lngIdMicroteachCaseSiteSenate == 0) return false;
if (lngIdMicroteachCaseSiteSenate == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdMicroteachCaseSiteSenate_MicroteachCaseSiteSenate]类型的对象</returns>
public static implicit operator K_IdMicroteachCaseSiteSenate_MicroteachCaseSiteSenate(long value)
{
return new K_IdMicroteachCaseSiteSenate_MicroteachCaseSiteSenate(value);
}
}
 /// <summary>
 /// 微格教学现场评议(MicroteachCaseSiteSenate)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsMicroteachCaseSiteSenateEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "MicroteachCaseSiteSenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdMicroteachCaseSiteSenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"IdMicroteachCaseSiteSenate", "FuncModuleId", "IdMicroteachCase", "IdMicroteachCaseSiteSenateType", "IdResource", "SiteSenateSenator", "SiteSenateTitle", "SiteSenateContent", "SiteSenateData", "SiteSenateTime", "SiteSenateReadCount", "Memo"};

protected long mlngIdMicroteachCaseSiteSenate;    //微格现场评议流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrIdMicroteachCase;    //微格教学案例流水号
protected string mstrIdMicroteachCaseSiteSenateType;    //微格现场评价类型流水号
protected string mstrIdResource;    //资源流水号
protected string mstrSiteSenateSenator;    //评议者
protected string mstrSiteSenateTitle;    //评议名称
protected string mstrSiteSenateContent;    //现场评议内容
protected string mstrSiteSenateData;    //现场评议日期
protected string mstrSiteSenateTime;    //现场评议时间
protected int? mintSiteSenateReadCount;    //现场评议阅读次数
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsMicroteachCaseSiteSenateEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMicroteachCaseSiteSenate");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdMicroteachCaseSiteSenate">关键字:微格现场评议流水号</param>
public clsMicroteachCaseSiteSenateEN(long lngIdMicroteachCaseSiteSenate)
 {
 if (lngIdMicroteachCaseSiteSenate  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdMicroteachCaseSiteSenate = lngIdMicroteachCaseSiteSenate;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMicroteachCaseSiteSenate");
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
if (strAttributeName  ==  conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate)
{
return mlngIdMicroteachCaseSiteSenate;
}
else if (strAttributeName  ==  conMicroteachCaseSiteSenate.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  conMicroteachCaseSiteSenate.IdMicroteachCase)
{
return mstrIdMicroteachCase;
}
else if (strAttributeName  ==  conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType)
{
return mstrIdMicroteachCaseSiteSenateType;
}
else if (strAttributeName  ==  conMicroteachCaseSiteSenate.IdResource)
{
return mstrIdResource;
}
else if (strAttributeName  ==  conMicroteachCaseSiteSenate.SiteSenateSenator)
{
return mstrSiteSenateSenator;
}
else if (strAttributeName  ==  conMicroteachCaseSiteSenate.SiteSenateTitle)
{
return mstrSiteSenateTitle;
}
else if (strAttributeName  ==  conMicroteachCaseSiteSenate.SiteSenateContent)
{
return mstrSiteSenateContent;
}
else if (strAttributeName  ==  conMicroteachCaseSiteSenate.SiteSenateData)
{
return mstrSiteSenateData;
}
else if (strAttributeName  ==  conMicroteachCaseSiteSenate.SiteSenateTime)
{
return mstrSiteSenateTime;
}
else if (strAttributeName  ==  conMicroteachCaseSiteSenate.SiteSenateReadCount)
{
return mintSiteSenateReadCount;
}
else if (strAttributeName  ==  conMicroteachCaseSiteSenate.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate)
{
mlngIdMicroteachCaseSiteSenate = TransNullToInt(value.ToString());
 AddUpdatedFld(conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate);
}
else if (strAttributeName  ==  conMicroteachCaseSiteSenate.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conMicroteachCaseSiteSenate.FuncModuleId);
}
else if (strAttributeName  ==  conMicroteachCaseSiteSenate.IdMicroteachCase)
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(conMicroteachCaseSiteSenate.IdMicroteachCase);
}
else if (strAttributeName  ==  conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType)
{
mstrIdMicroteachCaseSiteSenateType = value.ToString();
 AddUpdatedFld(conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType);
}
else if (strAttributeName  ==  conMicroteachCaseSiteSenate.IdResource)
{
mstrIdResource = value.ToString();
 AddUpdatedFld(conMicroteachCaseSiteSenate.IdResource);
}
else if (strAttributeName  ==  conMicroteachCaseSiteSenate.SiteSenateSenator)
{
mstrSiteSenateSenator = value.ToString();
 AddUpdatedFld(conMicroteachCaseSiteSenate.SiteSenateSenator);
}
else if (strAttributeName  ==  conMicroteachCaseSiteSenate.SiteSenateTitle)
{
mstrSiteSenateTitle = value.ToString();
 AddUpdatedFld(conMicroteachCaseSiteSenate.SiteSenateTitle);
}
else if (strAttributeName  ==  conMicroteachCaseSiteSenate.SiteSenateContent)
{
mstrSiteSenateContent = value.ToString();
 AddUpdatedFld(conMicroteachCaseSiteSenate.SiteSenateContent);
}
else if (strAttributeName  ==  conMicroteachCaseSiteSenate.SiteSenateData)
{
mstrSiteSenateData = value.ToString();
 AddUpdatedFld(conMicroteachCaseSiteSenate.SiteSenateData);
}
else if (strAttributeName  ==  conMicroteachCaseSiteSenate.SiteSenateTime)
{
mstrSiteSenateTime = value.ToString();
 AddUpdatedFld(conMicroteachCaseSiteSenate.SiteSenateTime);
}
else if (strAttributeName  ==  conMicroteachCaseSiteSenate.SiteSenateReadCount)
{
mintSiteSenateReadCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conMicroteachCaseSiteSenate.SiteSenateReadCount);
}
else if (strAttributeName  ==  conMicroteachCaseSiteSenate.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conMicroteachCaseSiteSenate.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate  ==  AttributeName[intIndex])
{
return mlngIdMicroteachCaseSiteSenate;
}
else if (conMicroteachCaseSiteSenate.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (conMicroteachCaseSiteSenate.IdMicroteachCase  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCase;
}
else if (conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType  ==  AttributeName[intIndex])
{
return mstrIdMicroteachCaseSiteSenateType;
}
else if (conMicroteachCaseSiteSenate.IdResource  ==  AttributeName[intIndex])
{
return mstrIdResource;
}
else if (conMicroteachCaseSiteSenate.SiteSenateSenator  ==  AttributeName[intIndex])
{
return mstrSiteSenateSenator;
}
else if (conMicroteachCaseSiteSenate.SiteSenateTitle  ==  AttributeName[intIndex])
{
return mstrSiteSenateTitle;
}
else if (conMicroteachCaseSiteSenate.SiteSenateContent  ==  AttributeName[intIndex])
{
return mstrSiteSenateContent;
}
else if (conMicroteachCaseSiteSenate.SiteSenateData  ==  AttributeName[intIndex])
{
return mstrSiteSenateData;
}
else if (conMicroteachCaseSiteSenate.SiteSenateTime  ==  AttributeName[intIndex])
{
return mstrSiteSenateTime;
}
else if (conMicroteachCaseSiteSenate.SiteSenateReadCount  ==  AttributeName[intIndex])
{
return mintSiteSenateReadCount;
}
else if (conMicroteachCaseSiteSenate.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate  ==  AttributeName[intIndex])
{
mlngIdMicroteachCaseSiteSenate = TransNullToInt(value.ToString());
 AddUpdatedFld(conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate);
}
else if (conMicroteachCaseSiteSenate.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conMicroteachCaseSiteSenate.FuncModuleId);
}
else if (conMicroteachCaseSiteSenate.IdMicroteachCase  ==  AttributeName[intIndex])
{
mstrIdMicroteachCase = value.ToString();
 AddUpdatedFld(conMicroteachCaseSiteSenate.IdMicroteachCase);
}
else if (conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType  ==  AttributeName[intIndex])
{
mstrIdMicroteachCaseSiteSenateType = value.ToString();
 AddUpdatedFld(conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType);
}
else if (conMicroteachCaseSiteSenate.IdResource  ==  AttributeName[intIndex])
{
mstrIdResource = value.ToString();
 AddUpdatedFld(conMicroteachCaseSiteSenate.IdResource);
}
else if (conMicroteachCaseSiteSenate.SiteSenateSenator  ==  AttributeName[intIndex])
{
mstrSiteSenateSenator = value.ToString();
 AddUpdatedFld(conMicroteachCaseSiteSenate.SiteSenateSenator);
}
else if (conMicroteachCaseSiteSenate.SiteSenateTitle  ==  AttributeName[intIndex])
{
mstrSiteSenateTitle = value.ToString();
 AddUpdatedFld(conMicroteachCaseSiteSenate.SiteSenateTitle);
}
else if (conMicroteachCaseSiteSenate.SiteSenateContent  ==  AttributeName[intIndex])
{
mstrSiteSenateContent = value.ToString();
 AddUpdatedFld(conMicroteachCaseSiteSenate.SiteSenateContent);
}
else if (conMicroteachCaseSiteSenate.SiteSenateData  ==  AttributeName[intIndex])
{
mstrSiteSenateData = value.ToString();
 AddUpdatedFld(conMicroteachCaseSiteSenate.SiteSenateData);
}
else if (conMicroteachCaseSiteSenate.SiteSenateTime  ==  AttributeName[intIndex])
{
mstrSiteSenateTime = value.ToString();
 AddUpdatedFld(conMicroteachCaseSiteSenate.SiteSenateTime);
}
else if (conMicroteachCaseSiteSenate.SiteSenateReadCount  ==  AttributeName[intIndex])
{
mintSiteSenateReadCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conMicroteachCaseSiteSenate.SiteSenateReadCount);
}
else if (conMicroteachCaseSiteSenate.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conMicroteachCaseSiteSenate.Memo);
}
}
}

/// <summary>
/// 微格现场评议流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdMicroteachCaseSiteSenate
{
get
{
return mlngIdMicroteachCaseSiteSenate;
}
set
{
 mlngIdMicroteachCaseSiteSenate = value;
//记录修改过的字段
 AddUpdatedFld(conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenate);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleId
{
get
{
return mstrFuncModuleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleId = value;
}
else
{
 mstrFuncModuleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroteachCaseSiteSenate.FuncModuleId);
}
}
/// <summary>
/// 微格教学案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdMicroteachCase
{
get
{
return mstrIdMicroteachCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdMicroteachCase = value;
}
else
{
 mstrIdMicroteachCase = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroteachCaseSiteSenate.IdMicroteachCase);
}
}
/// <summary>
/// 微格现场评价类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdMicroteachCaseSiteSenateType
{
get
{
return mstrIdMicroteachCaseSiteSenateType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdMicroteachCaseSiteSenateType = value;
}
else
{
 mstrIdMicroteachCaseSiteSenateType = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroteachCaseSiteSenate.IdMicroteachCaseSiteSenateType);
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
 AddUpdatedFld(conMicroteachCaseSiteSenate.IdResource);
}
}
/// <summary>
/// 评议者(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SiteSenateSenator
{
get
{
return mstrSiteSenateSenator;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSiteSenateSenator = value;
}
else
{
 mstrSiteSenateSenator = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroteachCaseSiteSenate.SiteSenateSenator);
}
}
/// <summary>
/// 评议名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SiteSenateTitle
{
get
{
return mstrSiteSenateTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSiteSenateTitle = value;
}
else
{
 mstrSiteSenateTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroteachCaseSiteSenate.SiteSenateTitle);
}
}
/// <summary>
/// 现场评议内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SiteSenateContent
{
get
{
return mstrSiteSenateContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSiteSenateContent = value;
}
else
{
 mstrSiteSenateContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroteachCaseSiteSenate.SiteSenateContent);
}
}
/// <summary>
/// 现场评议日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SiteSenateData
{
get
{
return mstrSiteSenateData;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSiteSenateData = value;
}
else
{
 mstrSiteSenateData = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroteachCaseSiteSenate.SiteSenateData);
}
}
/// <summary>
/// 现场评议时间(说明:;字段类型:char;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SiteSenateTime
{
get
{
return mstrSiteSenateTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSiteSenateTime = value;
}
else
{
 mstrSiteSenateTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroteachCaseSiteSenate.SiteSenateTime);
}
}
/// <summary>
/// 现场评议阅读次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? SiteSenateReadCount
{
get
{
return mintSiteSenateReadCount;
}
set
{
 mintSiteSenateReadCount = value;
//记录修改过的字段
 AddUpdatedFld(conMicroteachCaseSiteSenate.SiteSenateReadCount);
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
 AddUpdatedFld(conMicroteachCaseSiteSenate.Memo);
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
  return mlngIdMicroteachCaseSiteSenate.ToString();
 }
 }
}
 /// <summary>
 /// 微格教学现场评议(MicroteachCaseSiteSenate)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conMicroteachCaseSiteSenate
{
public const string _CurrTabName = "MicroteachCaseSiteSenate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdMicroteachCaseSiteSenate"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdMicroteachCaseSiteSenate", "FuncModuleId", "IdMicroteachCase", "IdMicroteachCaseSiteSenateType", "IdResource", "SiteSenateSenator", "SiteSenateTitle", "SiteSenateContent", "SiteSenateData", "SiteSenateTime", "SiteSenateReadCount", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdMicroteachCaseSiteSenate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroteachCaseSiteSenate = "IdMicroteachCaseSiteSenate";    //微格现场评议流水号

 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"IdMicroteachCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroteachCase = "IdMicroteachCase";    //微格教学案例流水号

 /// <summary>
 /// 常量:"IdMicroteachCaseSiteSenateType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroteachCaseSiteSenateType = "IdMicroteachCaseSiteSenateType";    //微格现场评价类型流水号

 /// <summary>
 /// 常量:"IdResource"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdResource = "IdResource";    //资源流水号

 /// <summary>
 /// 常量:"SiteSenateSenator"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SiteSenateSenator = "SiteSenateSenator";    //评议者

 /// <summary>
 /// 常量:"SiteSenateTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SiteSenateTitle = "SiteSenateTitle";    //评议名称

 /// <summary>
 /// 常量:"SiteSenateContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SiteSenateContent = "SiteSenateContent";    //现场评议内容

 /// <summary>
 /// 常量:"SiteSenateData"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SiteSenateData = "SiteSenateData";    //现场评议日期

 /// <summary>
 /// 常量:"SiteSenateTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SiteSenateTime = "SiteSenateTime";    //现场评议时间

 /// <summary>
 /// 常量:"SiteSenateReadCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SiteSenateReadCount = "SiteSenateReadCount";    //现场评议阅读次数

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}