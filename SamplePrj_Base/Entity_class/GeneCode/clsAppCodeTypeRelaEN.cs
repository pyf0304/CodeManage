
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAppCodeTypeRelaEN
 表名:AppCodeTypeRela(01160069)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 日期:2023/03/11 03:03:08
 生成者:pyf
 生成服务器IP:
 工程名称:简单工程样例(0116)
 CM工程:简单样例后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433SimplePrj
 PrjDataBaseId:0111
 模块中文名:生成代码(GeneCode)
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

namespace SimplePrj.Entity
{
 /// <summary>
 /// 表AppCodeTypeRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_AppCodeTypeRela
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_AppCodeTypeRela(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_AppCodeTypeRela]类型的对象</returns>
public static implicit operator K_mId_AppCodeTypeRela(long value)
{
return new K_mId_AppCodeTypeRela(value);
}
}
 /// <summary>
 /// 应用程序代码类型关系(AppCodeTypeRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsAppCodeTypeRelaEN : clsEntityBase2
{
public const string _CurrTabName_S = "AppCodeTypeRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 18;
public static string[] AttributeName = new string[] {"mId", "ApplicationTypeId", "CodeTypeId", "ViewTypeCode", "TabMainTypeId", "IsVisible", "IsInGroupGeneCode", "OrderNum", "UpdDate", "UpdUser", "Memo", "ApplicationTypeName", "CodeTypeSimName", "CodeTypeName", "DependsOn", "GroupName", "ProgLangTypeSimName", "ProgLangTypeName"};
//以下是属性变量

protected long mlngmId;    //mId
protected int mintApplicationTypeId;    //应用程序类型ID
protected string mstrCodeTypeId;    //代码类型Id
protected int mintViewTypeCode;    //界面类型码
protected string mstrTabMainTypeId;    //表主类型Id
protected bool mbolIsVisible;    //是否显示
protected bool mbolIsInGroupGeneCode;    //是否参与组生成代码
protected int mintOrderNum;    //排序
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改用户
protected string mstrMemo;    //备注
protected string mstrApplicationTypeName;    //应用程序类型名称
protected string mstrCodeTypeSimName;    //简称
protected string mstrCodeTypeName;    //代码类型名
protected string mstrDependsOn;    //依赖于
protected string mstrGroupName;    //组名
protected string mstrProgLangTypeSimName;    //编程语言类型简称
protected string mstrProgLangTypeName;    //编程语言类型名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsAppCodeTypeRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "AppCodeTypeRela";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsAppCodeTypeRelaEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "AppCodeTypeRela";
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  conAppCodeTypeRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conAppCodeTypeRela.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  conAppCodeTypeRela.CodeTypeId)
{
return mstrCodeTypeId;
}
else if (strAttributeName  ==  conAppCodeTypeRela.ViewTypeCode)
{
return mintViewTypeCode;
}
else if (strAttributeName  ==  conAppCodeTypeRela.TabMainTypeId)
{
return mstrTabMainTypeId;
}
else if (strAttributeName  ==  conAppCodeTypeRela.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conAppCodeTypeRela.IsInGroupGeneCode)
{
return mbolIsInGroupGeneCode;
}
else if (strAttributeName  ==  conAppCodeTypeRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conAppCodeTypeRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conAppCodeTypeRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conAppCodeTypeRela.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conAppCodeTypeRela.ApplicationTypeName)
{
return mstrApplicationTypeName;
}
else if (strAttributeName  ==  conAppCodeTypeRela.CodeTypeSimName)
{
return mstrCodeTypeSimName;
}
else if (strAttributeName  ==  conAppCodeTypeRela.CodeTypeName)
{
return mstrCodeTypeName;
}
else if (strAttributeName  ==  conAppCodeTypeRela.DependsOn)
{
return mstrDependsOn;
}
else if (strAttributeName  ==  conAppCodeTypeRela.GroupName)
{
return mstrGroupName;
}
else if (strAttributeName  ==  conAppCodeTypeRela.ProgLangTypeSimName)
{
return mstrProgLangTypeSimName;
}
else if (strAttributeName  ==  conAppCodeTypeRela.ProgLangTypeName)
{
return mstrProgLangTypeName;
}
return null;
}
set
{
if (strAttributeName  ==  conAppCodeTypeRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conAppCodeTypeRela.mId);
}
else if (strAttributeName  ==  conAppCodeTypeRela.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conAppCodeTypeRela.ApplicationTypeId);
}
else if (strAttributeName  ==  conAppCodeTypeRela.CodeTypeId)
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.CodeTypeId);
}
else if (strAttributeName  ==  conAppCodeTypeRela.ViewTypeCode)
{
mintViewTypeCode = TransNullToInt(value.ToString());
 AddUpdatedFld(conAppCodeTypeRela.ViewTypeCode);
}
else if (strAttributeName  ==  conAppCodeTypeRela.TabMainTypeId)
{
mstrTabMainTypeId = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.TabMainTypeId);
}
else if (strAttributeName  ==  conAppCodeTypeRela.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conAppCodeTypeRela.IsVisible);
}
else if (strAttributeName  ==  conAppCodeTypeRela.IsInGroupGeneCode)
{
mbolIsInGroupGeneCode = TransNullToBool(value.ToString());
 AddUpdatedFld(conAppCodeTypeRela.IsInGroupGeneCode);
}
else if (strAttributeName  ==  conAppCodeTypeRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conAppCodeTypeRela.OrderNum);
}
else if (strAttributeName  ==  conAppCodeTypeRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.UpdDate);
}
else if (strAttributeName  ==  conAppCodeTypeRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.UpdUser);
}
else if (strAttributeName  ==  conAppCodeTypeRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.Memo);
}
else if (strAttributeName  ==  conAppCodeTypeRela.ApplicationTypeName)
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.ApplicationTypeName);
}
else if (strAttributeName  ==  conAppCodeTypeRela.CodeTypeSimName)
{
mstrCodeTypeSimName = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.CodeTypeSimName);
}
else if (strAttributeName  ==  conAppCodeTypeRela.CodeTypeName)
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.CodeTypeName);
}
else if (strAttributeName  ==  conAppCodeTypeRela.DependsOn)
{
mstrDependsOn = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.DependsOn);
}
else if (strAttributeName  ==  conAppCodeTypeRela.GroupName)
{
mstrGroupName = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.GroupName);
}
else if (strAttributeName  ==  conAppCodeTypeRela.ProgLangTypeSimName)
{
mstrProgLangTypeSimName = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.ProgLangTypeSimName);
}
else if (strAttributeName  ==  conAppCodeTypeRela.ProgLangTypeName)
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.ProgLangTypeName);
}
}
}
public object this[int intIndex]
{
get
{
if (conAppCodeTypeRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conAppCodeTypeRela.ApplicationTypeId  ==  AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (conAppCodeTypeRela.CodeTypeId  ==  AttributeName[intIndex])
{
return mstrCodeTypeId;
}
else if (conAppCodeTypeRela.ViewTypeCode  ==  AttributeName[intIndex])
{
return mintViewTypeCode;
}
else if (conAppCodeTypeRela.TabMainTypeId  ==  AttributeName[intIndex])
{
return mstrTabMainTypeId;
}
else if (conAppCodeTypeRela.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conAppCodeTypeRela.IsInGroupGeneCode  ==  AttributeName[intIndex])
{
return mbolIsInGroupGeneCode;
}
else if (conAppCodeTypeRela.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conAppCodeTypeRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conAppCodeTypeRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conAppCodeTypeRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conAppCodeTypeRela.ApplicationTypeName  ==  AttributeName[intIndex])
{
return mstrApplicationTypeName;
}
else if (conAppCodeTypeRela.CodeTypeSimName  ==  AttributeName[intIndex])
{
return mstrCodeTypeSimName;
}
else if (conAppCodeTypeRela.CodeTypeName  ==  AttributeName[intIndex])
{
return mstrCodeTypeName;
}
else if (conAppCodeTypeRela.DependsOn  ==  AttributeName[intIndex])
{
return mstrDependsOn;
}
else if (conAppCodeTypeRela.GroupName  ==  AttributeName[intIndex])
{
return mstrGroupName;
}
else if (conAppCodeTypeRela.ProgLangTypeSimName  ==  AttributeName[intIndex])
{
return mstrProgLangTypeSimName;
}
else if (conAppCodeTypeRela.ProgLangTypeName  ==  AttributeName[intIndex])
{
return mstrProgLangTypeName;
}
return null;
}
set
{
if (conAppCodeTypeRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conAppCodeTypeRela.mId);
}
else if (conAppCodeTypeRela.ApplicationTypeId  ==  AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conAppCodeTypeRela.ApplicationTypeId);
}
else if (conAppCodeTypeRela.CodeTypeId  ==  AttributeName[intIndex])
{
mstrCodeTypeId = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.CodeTypeId);
}
else if (conAppCodeTypeRela.ViewTypeCode  ==  AttributeName[intIndex])
{
mintViewTypeCode = TransNullToInt(value.ToString());
 AddUpdatedFld(conAppCodeTypeRela.ViewTypeCode);
}
else if (conAppCodeTypeRela.TabMainTypeId  ==  AttributeName[intIndex])
{
mstrTabMainTypeId = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.TabMainTypeId);
}
else if (conAppCodeTypeRela.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conAppCodeTypeRela.IsVisible);
}
else if (conAppCodeTypeRela.IsInGroupGeneCode  ==  AttributeName[intIndex])
{
mbolIsInGroupGeneCode = TransNullToBool(value.ToString());
 AddUpdatedFld(conAppCodeTypeRela.IsInGroupGeneCode);
}
else if (conAppCodeTypeRela.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conAppCodeTypeRela.OrderNum);
}
else if (conAppCodeTypeRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.UpdDate);
}
else if (conAppCodeTypeRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.UpdUser);
}
else if (conAppCodeTypeRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.Memo);
}
else if (conAppCodeTypeRela.ApplicationTypeName  ==  AttributeName[intIndex])
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.ApplicationTypeName);
}
else if (conAppCodeTypeRela.CodeTypeSimName  ==  AttributeName[intIndex])
{
mstrCodeTypeSimName = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.CodeTypeSimName);
}
else if (conAppCodeTypeRela.CodeTypeName  ==  AttributeName[intIndex])
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.CodeTypeName);
}
else if (conAppCodeTypeRela.DependsOn  ==  AttributeName[intIndex])
{
mstrDependsOn = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.DependsOn);
}
else if (conAppCodeTypeRela.GroupName  ==  AttributeName[intIndex])
{
mstrGroupName = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.GroupName);
}
else if (conAppCodeTypeRela.ProgLangTypeSimName  ==  AttributeName[intIndex])
{
mstrProgLangTypeSimName = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.ProgLangTypeSimName);
}
else if (conAppCodeTypeRela.ProgLangTypeName  ==  AttributeName[intIndex])
{
mstrProgLangTypeName = value.ToString();
 AddUpdatedFld(conAppCodeTypeRela.ProgLangTypeName);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(conAppCodeTypeRela.mId);
}
}
/// <summary>
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ApplicationTypeId
{
get
{
return mintApplicationTypeId;
}
set
{
 mintApplicationTypeId = value;
//记录修改过的字段
 AddUpdatedFld(conAppCodeTypeRela.ApplicationTypeId);
}
}
/// <summary>
/// 代码类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTypeId
{
get
{
return mstrCodeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTypeId = value;
}
else
{
 mstrCodeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conAppCodeTypeRela.CodeTypeId);
}
}
/// <summary>
/// 界面类型码(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ViewTypeCode
{
get
{
return mintViewTypeCode;
}
set
{
 mintViewTypeCode = value;
//记录修改过的字段
 AddUpdatedFld(conAppCodeTypeRela.ViewTypeCode);
}
}
/// <summary>
/// 表主类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabMainTypeId
{
get
{
return mstrTabMainTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabMainTypeId = value;
}
else
{
 mstrTabMainTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conAppCodeTypeRela.TabMainTypeId);
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
 AddUpdatedFld(conAppCodeTypeRela.IsVisible);
}
}
/// <summary>
/// 是否参与组生成代码(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsInGroupGeneCode
{
get
{
return mbolIsInGroupGeneCode;
}
set
{
 mbolIsInGroupGeneCode = value;
//记录修改过的字段
 AddUpdatedFld(conAppCodeTypeRela.IsInGroupGeneCode);
}
}
/// <summary>
/// 排序(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conAppCodeTypeRela.OrderNum);
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
 AddUpdatedFld(conAppCodeTypeRela.UpdDate);
}
}
/// <summary>
/// 修改用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
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
 AddUpdatedFld(conAppCodeTypeRela.UpdUser);
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
 AddUpdatedFld(conAppCodeTypeRela.Memo);
}
}
/// <summary>
/// 应用程序类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ApplicationTypeName
{
get
{
return mstrApplicationTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrApplicationTypeName = value;
}
else
{
 mstrApplicationTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conAppCodeTypeRela.ApplicationTypeName);
}
}
/// <summary>
/// 简称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTypeSimName
{
get
{
return mstrCodeTypeSimName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTypeSimName = value;
}
else
{
 mstrCodeTypeSimName = value;
}
//记录修改过的字段
 AddUpdatedFld(conAppCodeTypeRela.CodeTypeSimName);
}
}
/// <summary>
/// 代码类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTypeName
{
get
{
return mstrCodeTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTypeName = value;
}
else
{
 mstrCodeTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conAppCodeTypeRela.CodeTypeName);
}
}
/// <summary>
/// 依赖于(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DependsOn
{
get
{
return mstrDependsOn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDependsOn = value;
}
else
{
 mstrDependsOn = value;
}
//记录修改过的字段
 AddUpdatedFld(conAppCodeTypeRela.DependsOn);
}
}
/// <summary>
/// 组名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupName
{
get
{
return mstrGroupName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupName = value;
}
else
{
 mstrGroupName = value;
}
//记录修改过的字段
 AddUpdatedFld(conAppCodeTypeRela.GroupName);
}
}
/// <summary>
/// 编程语言类型简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeSimName
{
get
{
return mstrProgLangTypeSimName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeSimName = value;
}
else
{
 mstrProgLangTypeSimName = value;
}
//记录修改过的字段
 AddUpdatedFld(conAppCodeTypeRela.ProgLangTypeSimName);
}
}
/// <summary>
/// 编程语言类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeName
{
get
{
return mstrProgLangTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeName = value;
}
else
{
 mstrProgLangTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conAppCodeTypeRela.ProgLangTypeName);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// 应用程序代码类型关系(AppCodeTypeRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conAppCodeTypeRela
{
public const string _CurrTabName_S = "AppCodeTypeRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "ApplicationTypeId", "CodeTypeId", "ViewTypeCode", "TabMainTypeId", "IsVisible", "IsInGroupGeneCode", "OrderNum", "UpdDate", "UpdUser", "Memo", "ApplicationTypeName", "CodeTypeSimName", "CodeTypeName", "DependsOn", "GroupName", "ProgLangTypeSimName", "ProgLangTypeName"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

 /// <summary>
 /// 常量:"CodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeId = "CodeTypeId";    //代码类型Id

 /// <summary>
 /// 常量:"ViewTypeCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewTypeCode = "ViewTypeCode";    //界面类型码

 /// <summary>
 /// 常量:"TabMainTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabMainTypeId = "TabMainTypeId";    //表主类型Id

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"IsInGroupGeneCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsInGroupGeneCode = "IsInGroupGeneCode";    //是否参与组生成代码

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //排序

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改用户

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"ApplicationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeName = "ApplicationTypeName";    //应用程序类型名称

 /// <summary>
 /// 常量:"CodeTypeSimName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeSimName = "CodeTypeSimName";    //简称

 /// <summary>
 /// 常量:"CodeTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeName = "CodeTypeName";    //代码类型名

 /// <summary>
 /// 常量:"DependsOn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DependsOn = "DependsOn";    //依赖于

 /// <summary>
 /// 常量:"GroupName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupName = "GroupName";    //组名

 /// <summary>
 /// 常量:"ProgLangTypeSimName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeSimName = "ProgLangTypeSimName";    //编程语言类型简称

 /// <summary>
 /// 常量:"ProgLangTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeName = "ProgLangTypeName";    //编程语言类型名
}

}