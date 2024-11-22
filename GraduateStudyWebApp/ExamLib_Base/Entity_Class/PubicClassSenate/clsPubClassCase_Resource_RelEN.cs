
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPubClassCase_Resource_RelEN
 表名:PubClassCase_Resource_Rel(01120408)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:17:40
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
 /// 表PubClassCase_Resource_Rel的关键字(IdPubClassCaseResourceRel)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdPubClassCaseResourceRel_PubClassCase_Resource_Rel
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdPubClassCaseResourceRel">表关键字</param>
public K_IdPubClassCaseResourceRel_PubClassCase_Resource_Rel(long lngIdPubClassCaseResourceRel)
{
if (IsValid(lngIdPubClassCaseResourceRel)) Value = lngIdPubClassCaseResourceRel;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdPubClassCaseResourceRel)
{
if (lngIdPubClassCaseResourceRel == 0) return false;
if (lngIdPubClassCaseResourceRel == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdPubClassCaseResourceRel_PubClassCase_Resource_Rel]类型的对象</returns>
public static implicit operator K_IdPubClassCaseResourceRel_PubClassCase_Resource_Rel(long value)
{
return new K_IdPubClassCaseResourceRel_PubClassCase_Resource_Rel(value);
}
}
 /// <summary>
 /// 案例与资源关系(PubClassCase_Resource_Rel)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPubClassCase_Resource_RelEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PubClassCase_Resource_Rel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdPubClassCaseResourceRel"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"IdPubClassCaseResourceRel", "IdPubClassCase", "IdResource", "IsMain", "IndexNO", "Memo", "IsVisible", "BrowseCount"};

protected long mlngIdPubClassCaseResourceRel;    //案例与资源关系表流水号
protected string mstrIdPubClassCase;    //案例流水号
protected string mstrIdResource;    //资源流水号
protected bool mbolIsMain;    //是否主资源
protected int? mintIndexNO;    //序号
protected string mstrMemo;    //备注
protected bool mbolIsVisible;    //是否显示
protected int? mintBrowseCount;    //浏览次数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsPubClassCase_Resource_RelEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPubClassCaseResourceRel");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdPubClassCaseResourceRel">关键字:案例与资源关系表流水号</param>
public clsPubClassCase_Resource_RelEN(long lngIdPubClassCaseResourceRel)
 {
 if (lngIdPubClassCaseResourceRel  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdPubClassCaseResourceRel = lngIdPubClassCaseResourceRel;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPubClassCaseResourceRel");
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
if (strAttributeName  ==  conPubClassCase_Resource_Rel.IdPubClassCaseResourceRel)
{
return mlngIdPubClassCaseResourceRel;
}
else if (strAttributeName  ==  conPubClassCase_Resource_Rel.IdPubClassCase)
{
return mstrIdPubClassCase;
}
else if (strAttributeName  ==  conPubClassCase_Resource_Rel.IdResource)
{
return mstrIdResource;
}
else if (strAttributeName  ==  conPubClassCase_Resource_Rel.IsMain)
{
return mbolIsMain;
}
else if (strAttributeName  ==  conPubClassCase_Resource_Rel.IndexNO)
{
return mintIndexNO;
}
else if (strAttributeName  ==  conPubClassCase_Resource_Rel.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conPubClassCase_Resource_Rel.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conPubClassCase_Resource_Rel.BrowseCount)
{
return mintBrowseCount;
}
return null;
}
set
{
if (strAttributeName  ==  conPubClassCase_Resource_Rel.IdPubClassCaseResourceRel)
{
mlngIdPubClassCaseResourceRel = TransNullToInt(value.ToString());
 AddUpdatedFld(conPubClassCase_Resource_Rel.IdPubClassCaseResourceRel);
}
else if (strAttributeName  ==  conPubClassCase_Resource_Rel.IdPubClassCase)
{
mstrIdPubClassCase = value.ToString();
 AddUpdatedFld(conPubClassCase_Resource_Rel.IdPubClassCase);
}
else if (strAttributeName  ==  conPubClassCase_Resource_Rel.IdResource)
{
mstrIdResource = value.ToString();
 AddUpdatedFld(conPubClassCase_Resource_Rel.IdResource);
}
else if (strAttributeName  ==  conPubClassCase_Resource_Rel.IsMain)
{
mbolIsMain = TransNullToBool(value.ToString());
 AddUpdatedFld(conPubClassCase_Resource_Rel.IsMain);
}
else if (strAttributeName  ==  conPubClassCase_Resource_Rel.IndexNO)
{
mintIndexNO = TransNullToInt(value.ToString());
 AddUpdatedFld(conPubClassCase_Resource_Rel.IndexNO);
}
else if (strAttributeName  ==  conPubClassCase_Resource_Rel.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPubClassCase_Resource_Rel.Memo);
}
else if (strAttributeName  ==  conPubClassCase_Resource_Rel.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conPubClassCase_Resource_Rel.IsVisible);
}
else if (strAttributeName  ==  conPubClassCase_Resource_Rel.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPubClassCase_Resource_Rel.BrowseCount);
}
}
}
public object this[int intIndex]
{
get
{
if (conPubClassCase_Resource_Rel.IdPubClassCaseResourceRel  ==  AttributeName[intIndex])
{
return mlngIdPubClassCaseResourceRel;
}
else if (conPubClassCase_Resource_Rel.IdPubClassCase  ==  AttributeName[intIndex])
{
return mstrIdPubClassCase;
}
else if (conPubClassCase_Resource_Rel.IdResource  ==  AttributeName[intIndex])
{
return mstrIdResource;
}
else if (conPubClassCase_Resource_Rel.IsMain  ==  AttributeName[intIndex])
{
return mbolIsMain;
}
else if (conPubClassCase_Resource_Rel.IndexNO  ==  AttributeName[intIndex])
{
return mintIndexNO;
}
else if (conPubClassCase_Resource_Rel.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conPubClassCase_Resource_Rel.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conPubClassCase_Resource_Rel.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
return null;
}
set
{
if (conPubClassCase_Resource_Rel.IdPubClassCaseResourceRel  ==  AttributeName[intIndex])
{
mlngIdPubClassCaseResourceRel = TransNullToInt(value.ToString());
 AddUpdatedFld(conPubClassCase_Resource_Rel.IdPubClassCaseResourceRel);
}
else if (conPubClassCase_Resource_Rel.IdPubClassCase  ==  AttributeName[intIndex])
{
mstrIdPubClassCase = value.ToString();
 AddUpdatedFld(conPubClassCase_Resource_Rel.IdPubClassCase);
}
else if (conPubClassCase_Resource_Rel.IdResource  ==  AttributeName[intIndex])
{
mstrIdResource = value.ToString();
 AddUpdatedFld(conPubClassCase_Resource_Rel.IdResource);
}
else if (conPubClassCase_Resource_Rel.IsMain  ==  AttributeName[intIndex])
{
mbolIsMain = TransNullToBool(value.ToString());
 AddUpdatedFld(conPubClassCase_Resource_Rel.IsMain);
}
else if (conPubClassCase_Resource_Rel.IndexNO  ==  AttributeName[intIndex])
{
mintIndexNO = TransNullToInt(value.ToString());
 AddUpdatedFld(conPubClassCase_Resource_Rel.IndexNO);
}
else if (conPubClassCase_Resource_Rel.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPubClassCase_Resource_Rel.Memo);
}
else if (conPubClassCase_Resource_Rel.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conPubClassCase_Resource_Rel.IsVisible);
}
else if (conPubClassCase_Resource_Rel.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conPubClassCase_Resource_Rel.BrowseCount);
}
}
}

/// <summary>
/// 案例与资源关系表流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdPubClassCaseResourceRel
{
get
{
return mlngIdPubClassCaseResourceRel;
}
set
{
 mlngIdPubClassCaseResourceRel = value;
//记录修改过的字段
 AddUpdatedFld(conPubClassCase_Resource_Rel.IdPubClassCaseResourceRel);
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
 AddUpdatedFld(conPubClassCase_Resource_Rel.IdPubClassCase);
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
 AddUpdatedFld(conPubClassCase_Resource_Rel.IdResource);
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
 AddUpdatedFld(conPubClassCase_Resource_Rel.IsMain);
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
 AddUpdatedFld(conPubClassCase_Resource_Rel.IndexNO);
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
 AddUpdatedFld(conPubClassCase_Resource_Rel.Memo);
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
 AddUpdatedFld(conPubClassCase_Resource_Rel.IsVisible);
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
 AddUpdatedFld(conPubClassCase_Resource_Rel.BrowseCount);
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
  return mlngIdPubClassCaseResourceRel.ToString();
 }
 }
}
 /// <summary>
 /// 案例与资源关系(PubClassCase_Resource_Rel)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPubClassCase_Resource_Rel
{
public const string _CurrTabName = "PubClassCase_Resource_Rel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdPubClassCaseResourceRel"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdPubClassCaseResourceRel", "IdPubClassCase", "IdResource", "IsMain", "IndexNO", "Memo", "IsVisible", "BrowseCount"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdPubClassCaseResourceRel"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubClassCaseResourceRel = "IdPubClassCaseResourceRel";    //案例与资源关系表流水号

 /// <summary>
 /// 常量:"IdPubClassCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubClassCase = "IdPubClassCase";    //案例流水号

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
 /// 常量:"IndexNO"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IndexNO = "IndexNO";    //序号

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

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