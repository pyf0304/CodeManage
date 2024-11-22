
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPubTeachCaseRelaInfoEN
 表名:PubTeachCaseRelaInfo(01120409)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:17:59
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
 /// 表PubTeachCaseRelaInfo的关键字(IdPubTeachCaseRelaInfo)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdPubTeachCaseRelaInfo_PubTeachCaseRelaInfo
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdPubTeachCaseRelaInfo">表关键字</param>
public K_IdPubTeachCaseRelaInfo_PubTeachCaseRelaInfo(long lngIdPubTeachCaseRelaInfo)
{
if (IsValid(lngIdPubTeachCaseRelaInfo)) Value = lngIdPubTeachCaseRelaInfo;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdPubTeachCaseRelaInfo)
{
if (lngIdPubTeachCaseRelaInfo == 0) return false;
if (lngIdPubTeachCaseRelaInfo == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdPubTeachCaseRelaInfo_PubTeachCaseRelaInfo]类型的对象</returns>
public static implicit operator K_IdPubTeachCaseRelaInfo_PubTeachCaseRelaInfo(long value)
{
return new K_IdPubTeachCaseRelaInfo_PubTeachCaseRelaInfo(value);
}
}
 /// <summary>
 /// 公开课案例相关信息(PubTeachCaseRelaInfo)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPubTeachCaseRelaInfoEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PubTeachCaseRelaInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdPubTeachCaseRelaInfo"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"IdPubTeachCaseRelaInfo", "IdPubClassCase", "IdPubTeachCaseRelaInfoType", "IdResource", "IsVisible", "Memo", "BrowseCount"};

protected long mlngIdPubTeachCaseRelaInfo;    //公开课案例相关信息流水号
protected string mstrIdPubClassCase;    //案例流水号
protected string mstrIdPubTeachCaseRelaInfoType;    //公开课案例相关信息类型流水号
protected string mstrIdResource;    //资源流水号
protected bool mbolIsVisible;    //是否显示
protected string mstrMemo;    //备注
protected int? mintBrowseCount;    //浏览次数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsPubTeachCaseRelaInfoEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPubTeachCaseRelaInfo");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdPubTeachCaseRelaInfo">关键字:公开课案例相关信息流水号</param>
public clsPubTeachCaseRelaInfoEN(long lngIdPubTeachCaseRelaInfo)
 {
 if (lngIdPubTeachCaseRelaInfo  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdPubTeachCaseRelaInfo = lngIdPubTeachCaseRelaInfo;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPubTeachCaseRelaInfo");
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
if (strAttributeName  ==  conPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo)
{
return mlngIdPubTeachCaseRelaInfo;
}
else if (strAttributeName  ==  conPubTeachCaseRelaInfo.IdPubClassCase)
{
return mstrIdPubClassCase;
}
else if (strAttributeName  ==  conPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType)
{
return mstrIdPubTeachCaseRelaInfoType;
}
else if (strAttributeName  ==  conPubTeachCaseRelaInfo.IdResource)
{
return mstrIdResource;
}
else if (strAttributeName  ==  conPubTeachCaseRelaInfo.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conPubTeachCaseRelaInfo.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conPubTeachCaseRelaInfo.BrowseCount)
{
return mintBrowseCount;
}
return null;
}
set
{
if (strAttributeName  ==  conPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo)
{
mlngIdPubTeachCaseRelaInfo = TransNullToInt(value.ToString());
 AddUpdatedFld(conPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo);
}
else if (strAttributeName  ==  conPubTeachCaseRelaInfo.IdPubClassCase)
{
mstrIdPubClassCase = value.ToString();
 AddUpdatedFld(conPubTeachCaseRelaInfo.IdPubClassCase);
}
else if (strAttributeName  ==  conPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType)
{
mstrIdPubTeachCaseRelaInfoType = value.ToString();
 AddUpdatedFld(conPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType);
}
else if (strAttributeName  ==  conPubTeachCaseRelaInfo.IdResource)
{
mstrIdResource = value.ToString();
 AddUpdatedFld(conPubTeachCaseRelaInfo.IdResource);
}
else if (strAttributeName  ==  conPubTeachCaseRelaInfo.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conPubTeachCaseRelaInfo.IsVisible);
}
else if (strAttributeName  ==  conPubTeachCaseRelaInfo.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPubTeachCaseRelaInfo.Memo);
}
else if (strAttributeName  ==  conPubTeachCaseRelaInfo.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPubTeachCaseRelaInfo.BrowseCount);
}
}
}
public object this[int intIndex]
{
get
{
if (conPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo  ==  AttributeName[intIndex])
{
return mlngIdPubTeachCaseRelaInfo;
}
else if (conPubTeachCaseRelaInfo.IdPubClassCase  ==  AttributeName[intIndex])
{
return mstrIdPubClassCase;
}
else if (conPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType  ==  AttributeName[intIndex])
{
return mstrIdPubTeachCaseRelaInfoType;
}
else if (conPubTeachCaseRelaInfo.IdResource  ==  AttributeName[intIndex])
{
return mstrIdResource;
}
else if (conPubTeachCaseRelaInfo.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conPubTeachCaseRelaInfo.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conPubTeachCaseRelaInfo.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
return null;
}
set
{
if (conPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo  ==  AttributeName[intIndex])
{
mlngIdPubTeachCaseRelaInfo = TransNullToInt(value.ToString());
 AddUpdatedFld(conPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo);
}
else if (conPubTeachCaseRelaInfo.IdPubClassCase  ==  AttributeName[intIndex])
{
mstrIdPubClassCase = value.ToString();
 AddUpdatedFld(conPubTeachCaseRelaInfo.IdPubClassCase);
}
else if (conPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType  ==  AttributeName[intIndex])
{
mstrIdPubTeachCaseRelaInfoType = value.ToString();
 AddUpdatedFld(conPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType);
}
else if (conPubTeachCaseRelaInfo.IdResource  ==  AttributeName[intIndex])
{
mstrIdResource = value.ToString();
 AddUpdatedFld(conPubTeachCaseRelaInfo.IdResource);
}
else if (conPubTeachCaseRelaInfo.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conPubTeachCaseRelaInfo.IsVisible);
}
else if (conPubTeachCaseRelaInfo.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPubTeachCaseRelaInfo.Memo);
}
else if (conPubTeachCaseRelaInfo.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPubTeachCaseRelaInfo.BrowseCount);
}
}
}

/// <summary>
/// 公开课案例相关信息流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdPubTeachCaseRelaInfo
{
get
{
return mlngIdPubTeachCaseRelaInfo;
}
set
{
 mlngIdPubTeachCaseRelaInfo = value;
//记录修改过的字段
 AddUpdatedFld(conPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfo);
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
 AddUpdatedFld(conPubTeachCaseRelaInfo.IdPubClassCase);
}
}
/// <summary>
/// 公开课案例相关信息类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdPubTeachCaseRelaInfoType
{
get
{
return mstrIdPubTeachCaseRelaInfoType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdPubTeachCaseRelaInfoType = value;
}
else
{
 mstrIdPubTeachCaseRelaInfoType = value;
}
//记录修改过的字段
 AddUpdatedFld(conPubTeachCaseRelaInfo.IdPubTeachCaseRelaInfoType);
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
 AddUpdatedFld(conPubTeachCaseRelaInfo.IdResource);
}
}
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsVisible
{
get
{
return mbolIsVisible;
}
set
{
 mbolIsVisible = value;
//记录修改过的字段
 AddUpdatedFld(conPubTeachCaseRelaInfo.IsVisible);
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
 AddUpdatedFld(conPubTeachCaseRelaInfo.Memo);
}
}
/// <summary>
/// 浏览次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? BrowseCount
{
get
{
return mintBrowseCount;
}
set
{
 mintBrowseCount = value;
//记录修改过的字段
 AddUpdatedFld(conPubTeachCaseRelaInfo.BrowseCount);
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
  return mlngIdPubTeachCaseRelaInfo.ToString();
 }
 }
}
 /// <summary>
 /// 公开课案例相关信息(PubTeachCaseRelaInfo)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPubTeachCaseRelaInfo
{
public const string _CurrTabName = "PubTeachCaseRelaInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdPubTeachCaseRelaInfo"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdPubTeachCaseRelaInfo", "IdPubClassCase", "IdPubTeachCaseRelaInfoType", "IdResource", "IsVisible", "Memo", "BrowseCount"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdPubTeachCaseRelaInfo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubTeachCaseRelaInfo = "IdPubTeachCaseRelaInfo";    //公开课案例相关信息流水号

 /// <summary>
 /// 常量:"IdPubClassCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubClassCase = "IdPubClassCase";    //案例流水号

 /// <summary>
 /// 常量:"IdPubTeachCaseRelaInfoType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubTeachCaseRelaInfoType = "IdPubTeachCaseRelaInfoType";    //公开课案例相关信息类型流水号

 /// <summary>
 /// 常量:"IdResource"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdResource = "IdResource";    //资源流水号

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"BrowseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount = "BrowseCount";    //浏览次数
}

}