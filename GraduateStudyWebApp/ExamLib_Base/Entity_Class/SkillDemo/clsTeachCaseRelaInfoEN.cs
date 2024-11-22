
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeachCaseRelaInfoEN
 表名:TeachCaseRelaInfo(01120513)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:43:42
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:技能示范(SkillDemo)
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
 /// 表TeachCaseRelaInfo的关键字(IdTeachCaseRelaInfo)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdTeachCaseRelaInfo_TeachCaseRelaInfo
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdTeachCaseRelaInfo">表关键字</param>
public K_IdTeachCaseRelaInfo_TeachCaseRelaInfo(long lngIdTeachCaseRelaInfo)
{
if (IsValid(lngIdTeachCaseRelaInfo)) Value = lngIdTeachCaseRelaInfo;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdTeachCaseRelaInfo)
{
if (lngIdTeachCaseRelaInfo == 0) return false;
if (lngIdTeachCaseRelaInfo == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdTeachCaseRelaInfo_TeachCaseRelaInfo]类型的对象</returns>
public static implicit operator K_IdTeachCaseRelaInfo_TeachCaseRelaInfo(long value)
{
return new K_IdTeachCaseRelaInfo_TeachCaseRelaInfo(value);
}
}
 /// <summary>
 /// 案例相关信息(TeachCaseRelaInfo)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTeachCaseRelaInfoEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "TeachCaseRelaInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdTeachCaseRelaInfo"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"IdTeachCaseRelaInfo", "IdTeachCase", "IdResource", "IdTeachCaseRelaInfoType", "IsVisible", "BrowseCount", "Memo"};

protected long mlngIdTeachCaseRelaInfo;    //案例相关信息流水号
protected string mstrIdTeachCase;    //案例流水号
protected string mstrIdResource;    //资源流水号
protected string mstrIdTeachCaseRelaInfoType;    //案例相关信息类型流水号
protected bool mbolIsVisible;    //是否显示
protected int? mintBrowseCount;    //浏览次数
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsTeachCaseRelaInfoEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdTeachCaseRelaInfo");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdTeachCaseRelaInfo">关键字:案例相关信息流水号</param>
public clsTeachCaseRelaInfoEN(long lngIdTeachCaseRelaInfo)
 {
 if (lngIdTeachCaseRelaInfo  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdTeachCaseRelaInfo = lngIdTeachCaseRelaInfo;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdTeachCaseRelaInfo");
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
if (strAttributeName  ==  conTeachCaseRelaInfo.IdTeachCaseRelaInfo)
{
return mlngIdTeachCaseRelaInfo;
}
else if (strAttributeName  ==  conTeachCaseRelaInfo.IdTeachCase)
{
return mstrIdTeachCase;
}
else if (strAttributeName  ==  conTeachCaseRelaInfo.IdResource)
{
return mstrIdResource;
}
else if (strAttributeName  ==  conTeachCaseRelaInfo.IdTeachCaseRelaInfoType)
{
return mstrIdTeachCaseRelaInfoType;
}
else if (strAttributeName  ==  conTeachCaseRelaInfo.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conTeachCaseRelaInfo.BrowseCount)
{
return mintBrowseCount;
}
else if (strAttributeName  ==  conTeachCaseRelaInfo.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conTeachCaseRelaInfo.IdTeachCaseRelaInfo)
{
mlngIdTeachCaseRelaInfo = TransNullToInt(value.ToString());
 AddUpdatedFld(conTeachCaseRelaInfo.IdTeachCaseRelaInfo);
}
else if (strAttributeName  ==  conTeachCaseRelaInfo.IdTeachCase)
{
mstrIdTeachCase = value.ToString();
 AddUpdatedFld(conTeachCaseRelaInfo.IdTeachCase);
}
else if (strAttributeName  ==  conTeachCaseRelaInfo.IdResource)
{
mstrIdResource = value.ToString();
 AddUpdatedFld(conTeachCaseRelaInfo.IdResource);
}
else if (strAttributeName  ==  conTeachCaseRelaInfo.IdTeachCaseRelaInfoType)
{
mstrIdTeachCaseRelaInfoType = value.ToString();
 AddUpdatedFld(conTeachCaseRelaInfo.IdTeachCaseRelaInfoType);
}
else if (strAttributeName  ==  conTeachCaseRelaInfo.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conTeachCaseRelaInfo.IsVisible);
}
else if (strAttributeName  ==  conTeachCaseRelaInfo.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conTeachCaseRelaInfo.BrowseCount);
}
else if (strAttributeName  ==  conTeachCaseRelaInfo.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTeachCaseRelaInfo.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTeachCaseRelaInfo.IdTeachCaseRelaInfo  ==  AttributeName[intIndex])
{
return mlngIdTeachCaseRelaInfo;
}
else if (conTeachCaseRelaInfo.IdTeachCase  ==  AttributeName[intIndex])
{
return mstrIdTeachCase;
}
else if (conTeachCaseRelaInfo.IdResource  ==  AttributeName[intIndex])
{
return mstrIdResource;
}
else if (conTeachCaseRelaInfo.IdTeachCaseRelaInfoType  ==  AttributeName[intIndex])
{
return mstrIdTeachCaseRelaInfoType;
}
else if (conTeachCaseRelaInfo.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conTeachCaseRelaInfo.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
else if (conTeachCaseRelaInfo.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conTeachCaseRelaInfo.IdTeachCaseRelaInfo  ==  AttributeName[intIndex])
{
mlngIdTeachCaseRelaInfo = TransNullToInt(value.ToString());
 AddUpdatedFld(conTeachCaseRelaInfo.IdTeachCaseRelaInfo);
}
else if (conTeachCaseRelaInfo.IdTeachCase  ==  AttributeName[intIndex])
{
mstrIdTeachCase = value.ToString();
 AddUpdatedFld(conTeachCaseRelaInfo.IdTeachCase);
}
else if (conTeachCaseRelaInfo.IdResource  ==  AttributeName[intIndex])
{
mstrIdResource = value.ToString();
 AddUpdatedFld(conTeachCaseRelaInfo.IdResource);
}
else if (conTeachCaseRelaInfo.IdTeachCaseRelaInfoType  ==  AttributeName[intIndex])
{
mstrIdTeachCaseRelaInfoType = value.ToString();
 AddUpdatedFld(conTeachCaseRelaInfo.IdTeachCaseRelaInfoType);
}
else if (conTeachCaseRelaInfo.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conTeachCaseRelaInfo.IsVisible);
}
else if (conTeachCaseRelaInfo.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conTeachCaseRelaInfo.BrowseCount);
}
else if (conTeachCaseRelaInfo.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTeachCaseRelaInfo.Memo);
}
}
}

/// <summary>
/// 案例相关信息流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdTeachCaseRelaInfo
{
get
{
return mlngIdTeachCaseRelaInfo;
}
set
{
 mlngIdTeachCaseRelaInfo = value;
//记录修改过的字段
 AddUpdatedFld(conTeachCaseRelaInfo.IdTeachCaseRelaInfo);
}
}
/// <summary>
/// 案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdTeachCase
{
get
{
return mstrIdTeachCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdTeachCase = value;
}
else
{
 mstrIdTeachCase = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachCaseRelaInfo.IdTeachCase);
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
 AddUpdatedFld(conTeachCaseRelaInfo.IdResource);
}
}
/// <summary>
/// 案例相关信息类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdTeachCaseRelaInfoType
{
get
{
return mstrIdTeachCaseRelaInfoType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdTeachCaseRelaInfoType = value;
}
else
{
 mstrIdTeachCaseRelaInfoType = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachCaseRelaInfo.IdTeachCaseRelaInfoType);
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
 AddUpdatedFld(conTeachCaseRelaInfo.IsVisible);
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
 AddUpdatedFld(conTeachCaseRelaInfo.BrowseCount);
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
 AddUpdatedFld(conTeachCaseRelaInfo.Memo);
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
  return mlngIdTeachCaseRelaInfo.ToString();
 }
 }
}
 /// <summary>
 /// 案例相关信息(TeachCaseRelaInfo)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTeachCaseRelaInfo
{
public const string _CurrTabName = "TeachCaseRelaInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdTeachCaseRelaInfo"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdTeachCaseRelaInfo", "IdTeachCase", "IdResource", "IdTeachCaseRelaInfoType", "IsVisible", "BrowseCount", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdTeachCaseRelaInfo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachCaseRelaInfo = "IdTeachCaseRelaInfo";    //案例相关信息流水号

 /// <summary>
 /// 常量:"IdTeachCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachCase = "IdTeachCase";    //案例流水号

 /// <summary>
 /// 常量:"IdResource"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdResource = "IdResource";    //资源流水号

 /// <summary>
 /// 常量:"IdTeachCaseRelaInfoType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachCaseRelaInfoType = "IdTeachCaseRelaInfoType";    //案例相关信息类型流水号

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"BrowseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount = "BrowseCount";    //浏览次数

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}