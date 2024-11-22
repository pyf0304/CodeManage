
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeachCase_Resource_RelEN
 表名:TeachCase_Resource_Rel(01120511)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:43:40
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
 /// 表TeachCase_Resource_Rel的关键字(IdTeachCaseResourceRel)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdTeachCaseResourceRel_TeachCase_Resource_Rel
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdTeachCaseResourceRel">表关键字</param>
public K_IdTeachCaseResourceRel_TeachCase_Resource_Rel(long lngIdTeachCaseResourceRel)
{
if (IsValid(lngIdTeachCaseResourceRel)) Value = lngIdTeachCaseResourceRel;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdTeachCaseResourceRel)
{
if (lngIdTeachCaseResourceRel == 0) return false;
if (lngIdTeachCaseResourceRel == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdTeachCaseResourceRel_TeachCase_Resource_Rel]类型的对象</returns>
public static implicit operator K_IdTeachCaseResourceRel_TeachCase_Resource_Rel(long value)
{
return new K_IdTeachCaseResourceRel_TeachCase_Resource_Rel(value);
}
}
 /// <summary>
 /// 案例与资源表系(TeachCase_Resource_Rel)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTeachCase_Resource_RelEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "TeachCase_Resource_Rel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdTeachCaseResourceRel"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"IdTeachCaseResourceRel", "IdTeachCase", "IdResource", "IsMain", "Memo", "IndexNO", "IsVisible", "BrowseCount"};

protected long mlngIdTeachCaseResourceRel;    //案例与资源表系表流水号
protected string mstrIdTeachCase;    //案例流水号
protected string mstrIdResource;    //资源流水号
protected bool mbolIsMain;    //是否主资源
protected string mstrMemo;    //备注
protected int? mintIndexNO;    //序号
protected bool mbolIsVisible;    //是否显示
protected int? mintBrowseCount;    //浏览次数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsTeachCase_Resource_RelEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdTeachCaseResourceRel");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdTeachCaseResourceRel">关键字:案例与资源表系表流水号</param>
public clsTeachCase_Resource_RelEN(long lngIdTeachCaseResourceRel)
 {
 if (lngIdTeachCaseResourceRel  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdTeachCaseResourceRel = lngIdTeachCaseResourceRel;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdTeachCaseResourceRel");
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
if (strAttributeName  ==  conTeachCase_Resource_Rel.IdTeachCaseResourceRel)
{
return mlngIdTeachCaseResourceRel;
}
else if (strAttributeName  ==  conTeachCase_Resource_Rel.IdTeachCase)
{
return mstrIdTeachCase;
}
else if (strAttributeName  ==  conTeachCase_Resource_Rel.IdResource)
{
return mstrIdResource;
}
else if (strAttributeName  ==  conTeachCase_Resource_Rel.IsMain)
{
return mbolIsMain;
}
else if (strAttributeName  ==  conTeachCase_Resource_Rel.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conTeachCase_Resource_Rel.IndexNO)
{
return mintIndexNO;
}
else if (strAttributeName  ==  conTeachCase_Resource_Rel.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conTeachCase_Resource_Rel.BrowseCount)
{
return mintBrowseCount;
}
return null;
}
set
{
if (strAttributeName  ==  conTeachCase_Resource_Rel.IdTeachCaseResourceRel)
{
mlngIdTeachCaseResourceRel = TransNullToInt(value.ToString());
 AddUpdatedFld(conTeachCase_Resource_Rel.IdTeachCaseResourceRel);
}
else if (strAttributeName  ==  conTeachCase_Resource_Rel.IdTeachCase)
{
mstrIdTeachCase = value.ToString();
 AddUpdatedFld(conTeachCase_Resource_Rel.IdTeachCase);
}
else if (strAttributeName  ==  conTeachCase_Resource_Rel.IdResource)
{
mstrIdResource = value.ToString();
 AddUpdatedFld(conTeachCase_Resource_Rel.IdResource);
}
else if (strAttributeName  ==  conTeachCase_Resource_Rel.IsMain)
{
mbolIsMain = TransNullToBool(value.ToString());
 AddUpdatedFld(conTeachCase_Resource_Rel.IsMain);
}
else if (strAttributeName  ==  conTeachCase_Resource_Rel.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTeachCase_Resource_Rel.Memo);
}
else if (strAttributeName  ==  conTeachCase_Resource_Rel.IndexNO)
{
mintIndexNO = TransNullToInt(value.ToString());
 AddUpdatedFld(conTeachCase_Resource_Rel.IndexNO);
}
else if (strAttributeName  ==  conTeachCase_Resource_Rel.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conTeachCase_Resource_Rel.IsVisible);
}
else if (strAttributeName  ==  conTeachCase_Resource_Rel.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conTeachCase_Resource_Rel.BrowseCount);
}
}
}
public object this[int intIndex]
{
get
{
if (conTeachCase_Resource_Rel.IdTeachCaseResourceRel  ==  AttributeName[intIndex])
{
return mlngIdTeachCaseResourceRel;
}
else if (conTeachCase_Resource_Rel.IdTeachCase  ==  AttributeName[intIndex])
{
return mstrIdTeachCase;
}
else if (conTeachCase_Resource_Rel.IdResource  ==  AttributeName[intIndex])
{
return mstrIdResource;
}
else if (conTeachCase_Resource_Rel.IsMain  ==  AttributeName[intIndex])
{
return mbolIsMain;
}
else if (conTeachCase_Resource_Rel.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conTeachCase_Resource_Rel.IndexNO  ==  AttributeName[intIndex])
{
return mintIndexNO;
}
else if (conTeachCase_Resource_Rel.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conTeachCase_Resource_Rel.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
return null;
}
set
{
if (conTeachCase_Resource_Rel.IdTeachCaseResourceRel  ==  AttributeName[intIndex])
{
mlngIdTeachCaseResourceRel = TransNullToInt(value.ToString());
 AddUpdatedFld(conTeachCase_Resource_Rel.IdTeachCaseResourceRel);
}
else if (conTeachCase_Resource_Rel.IdTeachCase  ==  AttributeName[intIndex])
{
mstrIdTeachCase = value.ToString();
 AddUpdatedFld(conTeachCase_Resource_Rel.IdTeachCase);
}
else if (conTeachCase_Resource_Rel.IdResource  ==  AttributeName[intIndex])
{
mstrIdResource = value.ToString();
 AddUpdatedFld(conTeachCase_Resource_Rel.IdResource);
}
else if (conTeachCase_Resource_Rel.IsMain  ==  AttributeName[intIndex])
{
mbolIsMain = TransNullToBool(value.ToString());
 AddUpdatedFld(conTeachCase_Resource_Rel.IsMain);
}
else if (conTeachCase_Resource_Rel.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTeachCase_Resource_Rel.Memo);
}
else if (conTeachCase_Resource_Rel.IndexNO  ==  AttributeName[intIndex])
{
mintIndexNO = TransNullToInt(value.ToString());
 AddUpdatedFld(conTeachCase_Resource_Rel.IndexNO);
}
else if (conTeachCase_Resource_Rel.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conTeachCase_Resource_Rel.IsVisible);
}
else if (conTeachCase_Resource_Rel.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conTeachCase_Resource_Rel.BrowseCount);
}
}
}

/// <summary>
/// 案例与资源表系表流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdTeachCaseResourceRel
{
get
{
return mlngIdTeachCaseResourceRel;
}
set
{
 mlngIdTeachCaseResourceRel = value;
//记录修改过的字段
 AddUpdatedFld(conTeachCase_Resource_Rel.IdTeachCaseResourceRel);
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
 AddUpdatedFld(conTeachCase_Resource_Rel.IdTeachCase);
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
 AddUpdatedFld(conTeachCase_Resource_Rel.IdResource);
}
}
/// <summary>
/// 是否主资源(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsMain
{
get
{
return mbolIsMain;
}
set
{
 mbolIsMain = value;
//记录修改过的字段
 AddUpdatedFld(conTeachCase_Resource_Rel.IsMain);
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
 AddUpdatedFld(conTeachCase_Resource_Rel.Memo);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? IndexNO
{
get
{
return mintIndexNO;
}
set
{
 mintIndexNO = value;
//记录修改过的字段
 AddUpdatedFld(conTeachCase_Resource_Rel.IndexNO);
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
 AddUpdatedFld(conTeachCase_Resource_Rel.IsVisible);
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
 AddUpdatedFld(conTeachCase_Resource_Rel.BrowseCount);
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
  return mlngIdTeachCaseResourceRel.ToString();
 }
 }
}
 /// <summary>
 /// 案例与资源表系(TeachCase_Resource_Rel)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTeachCase_Resource_Rel
{
public const string _CurrTabName = "TeachCase_Resource_Rel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdTeachCaseResourceRel"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdTeachCaseResourceRel", "IdTeachCase", "IdResource", "IsMain", "Memo", "IndexNO", "IsVisible", "BrowseCount"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdTeachCaseResourceRel"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachCaseResourceRel = "IdTeachCaseResourceRel";    //案例与资源表系表流水号

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
 /// 常量:"IsMain"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsMain = "IsMain";    //是否主资源

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"IndexNO"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IndexNO = "IndexNO";    //序号

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
}

}