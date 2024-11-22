
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabFeatureEN
 表名:TabFeature(00050463)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 11:47:22
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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

namespace AGC.Entity
{
 /// <summary>
 /// 表TabFeature的关键字(TabFeatureId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TabFeatureId_TabFeature
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTabFeatureId">表关键字</param>
public K_TabFeatureId_TabFeature(string strTabFeatureId)
{
if (IsValid(strTabFeatureId)) Value = strTabFeatureId;
else
{
Value = null;
}
}
private static bool IsValid(string strTabFeatureId)
{
if (string.IsNullOrEmpty(strTabFeatureId) == true) return false;
if (strTabFeatureId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TabFeatureId_TabFeature]类型的对象</returns>
public static implicit operator K_TabFeatureId_TabFeature(string value)
{
return new K_TabFeatureId_TabFeature(value);
}
}
 /// <summary>
 /// 表功能(TabFeature)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTabFeatureEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "TabFeature"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TabFeatureId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 21;
public static string[] AttributeName = new string[] {"TabFeatureId", "TabFeatureName", "TabId", "FeatureId", "FuncNameCs", "FuncNameJs", "IsExtendedClass", "IsForCSharp", "IsForTypeScript", "IsForDiv", "IsNeedGC", "UseTimes", "OrderNum", "IsNullable", "InUse", "CheckDate", "ErrMsg", "PrjId", "UpdUser", "UpdDate", "Memo"};

protected string mstrTabFeatureId;    //表功能Id
protected string mstrTabFeatureName;    //表功能名
protected string mstrTabId;    //表ID
protected string mstrFeatureId;    //功能Id
protected string mstrFuncNameCs;    //Cs函数名
protected string mstrFuncNameJs;    //Js函数名
protected bool mbolIsExtendedClass;    //是否在扩展类
protected bool mbolIsForCSharp;    //是否ForCSharp
protected bool mbolIsForTypeScript;    //是否ForTypeScript
protected bool mbolIsForDiv;    //是否针对Div内控件
protected bool mbolIsNeedGC;    //是否需要生成代码
protected int? mintUseTimes;    //使用次数
protected int? mintOrderNum;    //序号
protected bool mbolIsNullable;    //是否可空
protected bool mbolInUse;    //是否在用
protected string mstrCheckDate;    //检查日期
protected string mstrErrMsg;    //错误信息
protected string mstrPrjId;    //工程ID
protected string mstrUpdUser;    //修改者
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //说明

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsTabFeatureEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TabFeatureId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strTabFeatureId">关键字:表功能Id</param>
public clsTabFeatureEN(string strTabFeatureId)
 {
strTabFeatureId = strTabFeatureId.Replace("'", "''");
if (strTabFeatureId.Length > 8)
{
throw new Exception("在表:TabFeature中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTabFeatureId)  ==  true)
{
throw new Exception("在表:TabFeature中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTabFeatureId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTabFeatureId = strTabFeatureId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TabFeatureId");
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
if (strAttributeName  ==  conTabFeature.TabFeatureId)
{
return mstrTabFeatureId;
}
else if (strAttributeName  ==  conTabFeature.TabFeatureName)
{
return mstrTabFeatureName;
}
else if (strAttributeName  ==  conTabFeature.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  conTabFeature.FeatureId)
{
return mstrFeatureId;
}
else if (strAttributeName  ==  conTabFeature.FuncNameCs)
{
return mstrFuncNameCs;
}
else if (strAttributeName  ==  conTabFeature.FuncNameJs)
{
return mstrFuncNameJs;
}
else if (strAttributeName  ==  conTabFeature.IsExtendedClass)
{
return mbolIsExtendedClass;
}
else if (strAttributeName  ==  conTabFeature.IsForCSharp)
{
return mbolIsForCSharp;
}
else if (strAttributeName  ==  conTabFeature.IsForTypeScript)
{
return mbolIsForTypeScript;
}
else if (strAttributeName  ==  conTabFeature.IsForDiv)
{
return mbolIsForDiv;
}
else if (strAttributeName  ==  conTabFeature.IsNeedGC)
{
return mbolIsNeedGC;
}
else if (strAttributeName  ==  conTabFeature.UseTimes)
{
return mintUseTimes;
}
else if (strAttributeName  ==  conTabFeature.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conTabFeature.IsNullable)
{
return mbolIsNullable;
}
else if (strAttributeName  ==  conTabFeature.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conTabFeature.CheckDate)
{
return mstrCheckDate;
}
else if (strAttributeName  ==  conTabFeature.ErrMsg)
{
return mstrErrMsg;
}
else if (strAttributeName  ==  conTabFeature.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conTabFeature.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conTabFeature.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conTabFeature.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conTabFeature.TabFeatureId)
{
mstrTabFeatureId = value.ToString();
 AddUpdatedFld(conTabFeature.TabFeatureId);
}
else if (strAttributeName  ==  conTabFeature.TabFeatureName)
{
mstrTabFeatureName = value.ToString();
 AddUpdatedFld(conTabFeature.TabFeatureName);
}
else if (strAttributeName  ==  conTabFeature.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(conTabFeature.TabId);
}
else if (strAttributeName  ==  conTabFeature.FeatureId)
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(conTabFeature.FeatureId);
}
else if (strAttributeName  ==  conTabFeature.FuncNameCs)
{
mstrFuncNameCs = value.ToString();
 AddUpdatedFld(conTabFeature.FuncNameCs);
}
else if (strAttributeName  ==  conTabFeature.FuncNameJs)
{
mstrFuncNameJs = value.ToString();
 AddUpdatedFld(conTabFeature.FuncNameJs);
}
else if (strAttributeName  ==  conTabFeature.IsExtendedClass)
{
mbolIsExtendedClass = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFeature.IsExtendedClass);
}
else if (strAttributeName  ==  conTabFeature.IsForCSharp)
{
mbolIsForCSharp = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFeature.IsForCSharp);
}
else if (strAttributeName  ==  conTabFeature.IsForTypeScript)
{
mbolIsForTypeScript = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFeature.IsForTypeScript);
}
else if (strAttributeName  ==  conTabFeature.IsForDiv)
{
mbolIsForDiv = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFeature.IsForDiv);
}
else if (strAttributeName  ==  conTabFeature.IsNeedGC)
{
mbolIsNeedGC = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFeature.IsNeedGC);
}
else if (strAttributeName  ==  conTabFeature.UseTimes)
{
mintUseTimes = TransNullToInt(value.ToString());
 AddUpdatedFld(conTabFeature.UseTimes);
}
else if (strAttributeName  ==  conTabFeature.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conTabFeature.OrderNum);
}
else if (strAttributeName  ==  conTabFeature.IsNullable)
{
mbolIsNullable = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFeature.IsNullable);
}
else if (strAttributeName  ==  conTabFeature.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFeature.InUse);
}
else if (strAttributeName  ==  conTabFeature.CheckDate)
{
mstrCheckDate = value.ToString();
 AddUpdatedFld(conTabFeature.CheckDate);
}
else if (strAttributeName  ==  conTabFeature.ErrMsg)
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conTabFeature.ErrMsg);
}
else if (strAttributeName  ==  conTabFeature.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conTabFeature.PrjId);
}
else if (strAttributeName  ==  conTabFeature.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conTabFeature.UpdUser);
}
else if (strAttributeName  ==  conTabFeature.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conTabFeature.UpdDate);
}
else if (strAttributeName  ==  conTabFeature.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTabFeature.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTabFeature.TabFeatureId  ==  AttributeName[intIndex])
{
return mstrTabFeatureId;
}
else if (conTabFeature.TabFeatureName  ==  AttributeName[intIndex])
{
return mstrTabFeatureName;
}
else if (conTabFeature.TabId  ==  AttributeName[intIndex])
{
return mstrTabId;
}
else if (conTabFeature.FeatureId  ==  AttributeName[intIndex])
{
return mstrFeatureId;
}
else if (conTabFeature.FuncNameCs  ==  AttributeName[intIndex])
{
return mstrFuncNameCs;
}
else if (conTabFeature.FuncNameJs  ==  AttributeName[intIndex])
{
return mstrFuncNameJs;
}
else if (conTabFeature.IsExtendedClass  ==  AttributeName[intIndex])
{
return mbolIsExtendedClass;
}
else if (conTabFeature.IsForCSharp  ==  AttributeName[intIndex])
{
return mbolIsForCSharp;
}
else if (conTabFeature.IsForTypeScript  ==  AttributeName[intIndex])
{
return mbolIsForTypeScript;
}
else if (conTabFeature.IsForDiv  ==  AttributeName[intIndex])
{
return mbolIsForDiv;
}
else if (conTabFeature.IsNeedGC  ==  AttributeName[intIndex])
{
return mbolIsNeedGC;
}
else if (conTabFeature.UseTimes  ==  AttributeName[intIndex])
{
return mintUseTimes;
}
else if (conTabFeature.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conTabFeature.IsNullable  ==  AttributeName[intIndex])
{
return mbolIsNullable;
}
else if (conTabFeature.InUse  ==  AttributeName[intIndex])
{
return mbolInUse;
}
else if (conTabFeature.CheckDate  ==  AttributeName[intIndex])
{
return mstrCheckDate;
}
else if (conTabFeature.ErrMsg  ==  AttributeName[intIndex])
{
return mstrErrMsg;
}
else if (conTabFeature.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conTabFeature.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conTabFeature.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conTabFeature.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conTabFeature.TabFeatureId  ==  AttributeName[intIndex])
{
mstrTabFeatureId = value.ToString();
 AddUpdatedFld(conTabFeature.TabFeatureId);
}
else if (conTabFeature.TabFeatureName  ==  AttributeName[intIndex])
{
mstrTabFeatureName = value.ToString();
 AddUpdatedFld(conTabFeature.TabFeatureName);
}
else if (conTabFeature.TabId  ==  AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(conTabFeature.TabId);
}
else if (conTabFeature.FeatureId  ==  AttributeName[intIndex])
{
mstrFeatureId = value.ToString();
 AddUpdatedFld(conTabFeature.FeatureId);
}
else if (conTabFeature.FuncNameCs  ==  AttributeName[intIndex])
{
mstrFuncNameCs = value.ToString();
 AddUpdatedFld(conTabFeature.FuncNameCs);
}
else if (conTabFeature.FuncNameJs  ==  AttributeName[intIndex])
{
mstrFuncNameJs = value.ToString();
 AddUpdatedFld(conTabFeature.FuncNameJs);
}
else if (conTabFeature.IsExtendedClass  ==  AttributeName[intIndex])
{
mbolIsExtendedClass = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFeature.IsExtendedClass);
}
else if (conTabFeature.IsForCSharp  ==  AttributeName[intIndex])
{
mbolIsForCSharp = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFeature.IsForCSharp);
}
else if (conTabFeature.IsForTypeScript  ==  AttributeName[intIndex])
{
mbolIsForTypeScript = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFeature.IsForTypeScript);
}
else if (conTabFeature.IsForDiv  ==  AttributeName[intIndex])
{
mbolIsForDiv = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFeature.IsForDiv);
}
else if (conTabFeature.IsNeedGC  ==  AttributeName[intIndex])
{
mbolIsNeedGC = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFeature.IsNeedGC);
}
else if (conTabFeature.UseTimes  ==  AttributeName[intIndex])
{
mintUseTimes = TransNullToInt(value.ToString());
 AddUpdatedFld(conTabFeature.UseTimes);
}
else if (conTabFeature.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conTabFeature.OrderNum);
}
else if (conTabFeature.IsNullable  ==  AttributeName[intIndex])
{
mbolIsNullable = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFeature.IsNullable);
}
else if (conTabFeature.InUse  ==  AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conTabFeature.InUse);
}
else if (conTabFeature.CheckDate  ==  AttributeName[intIndex])
{
mstrCheckDate = value.ToString();
 AddUpdatedFld(conTabFeature.CheckDate);
}
else if (conTabFeature.ErrMsg  ==  AttributeName[intIndex])
{
mstrErrMsg = value.ToString();
 AddUpdatedFld(conTabFeature.ErrMsg);
}
else if (conTabFeature.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conTabFeature.PrjId);
}
else if (conTabFeature.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conTabFeature.UpdUser);
}
else if (conTabFeature.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conTabFeature.UpdDate);
}
else if (conTabFeature.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTabFeature.Memo);
}
}
}

/// <summary>
/// 表功能Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabFeatureId
{
get
{
return mstrTabFeatureId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabFeatureId = value;
}
else
{
 mstrTabFeatureId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabFeature.TabFeatureId);
}
}
/// <summary>
/// 表功能名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabFeatureName
{
get
{
return mstrTabFeatureName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabFeatureName = value;
}
else
{
 mstrTabFeatureName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabFeature.TabFeatureName);
}
}
/// <summary>
/// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabId
{
get
{
return mstrTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabId = value;
}
else
{
 mstrTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabFeature.TabId);
}
}
/// <summary>
/// 功能Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeatureId
{
get
{
return mstrFeatureId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeatureId = value;
}
else
{
 mstrFeatureId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabFeature.FeatureId);
}
}
/// <summary>
/// Cs函数名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncNameCs
{
get
{
return mstrFuncNameCs;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncNameCs = value;
}
else
{
 mstrFuncNameCs = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabFeature.FuncNameCs);
}
}
/// <summary>
/// Js函数名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncNameJs
{
get
{
return mstrFuncNameJs;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncNameJs = value;
}
else
{
 mstrFuncNameJs = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabFeature.FuncNameJs);
}
}
/// <summary>
/// 是否在扩展类(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsExtendedClass
{
get
{
return mbolIsExtendedClass;
}
set
{
 mbolIsExtendedClass = value;
//记录修改过的字段
 AddUpdatedFld(conTabFeature.IsExtendedClass);
}
}
/// <summary>
/// 是否ForCSharp(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsForCSharp
{
get
{
return mbolIsForCSharp;
}
set
{
 mbolIsForCSharp = value;
//记录修改过的字段
 AddUpdatedFld(conTabFeature.IsForCSharp);
}
}
/// <summary>
/// 是否ForTypeScript(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsForTypeScript
{
get
{
return mbolIsForTypeScript;
}
set
{
 mbolIsForTypeScript = value;
//记录修改过的字段
 AddUpdatedFld(conTabFeature.IsForTypeScript);
}
}
/// <summary>
/// 是否针对Div内控件(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsForDiv
{
get
{
return mbolIsForDiv;
}
set
{
 mbolIsForDiv = value;
//记录修改过的字段
 AddUpdatedFld(conTabFeature.IsForDiv);
}
}
/// <summary>
/// 是否需要生成代码(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNeedGC
{
get
{
return mbolIsNeedGC;
}
set
{
 mbolIsNeedGC = value;
//记录修改过的字段
 AddUpdatedFld(conTabFeature.IsNeedGC);
}
}
/// <summary>
/// 使用次数(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? UseTimes
{
get
{
return mintUseTimes;
}
set
{
 mintUseTimes = value;
//记录修改过的字段
 AddUpdatedFld(conTabFeature.UseTimes);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conTabFeature.OrderNum);
}
}
/// <summary>
/// 是否可空(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNullable
{
get
{
return mbolIsNullable;
}
set
{
 mbolIsNullable = value;
//记录修改过的字段
 AddUpdatedFld(conTabFeature.IsNullable);
}
}
/// <summary>
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool InUse
{
get
{
return mbolInUse;
}
set
{
 mbolInUse = value;
//记录修改过的字段
 AddUpdatedFld(conTabFeature.InUse);
}
}
/// <summary>
/// 检查日期(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CheckDate
{
get
{
return mstrCheckDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCheckDate = value;
}
else
{
 mstrCheckDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabFeature.CheckDate);
}
}
/// <summary>
/// 错误信息(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ErrMsg
{
get
{
return mstrErrMsg;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrErrMsg = value;
}
else
{
 mstrErrMsg = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabFeature.ErrMsg);
}
}
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjId
{
get
{
return mstrPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjId = value;
}
else
{
 mstrPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTabFeature.PrjId);
}
}
/// <summary>
/// 修改者(说明:;字段类型:varchar;字段长度:20;是否可空:True)
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
 AddUpdatedFld(conTabFeature.UpdUser);
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
 AddUpdatedFld(conTabFeature.UpdDate);
}
}
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
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
 AddUpdatedFld(conTabFeature.Memo);
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
  return mstrTabFeatureId;
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
  return mstrTabFeatureName;
 }
 }
}
 /// <summary>
 /// 表功能(TabFeature)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTabFeature
{
public const string _CurrTabName = "TabFeature"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TabFeatureId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TabFeatureId", "TabFeatureName", "TabId", "FeatureId", "FuncNameCs", "FuncNameJs", "IsExtendedClass", "IsForCSharp", "IsForTypeScript", "IsForDiv", "IsNeedGC", "UseTimes", "OrderNum", "IsNullable", "InUse", "CheckDate", "ErrMsg", "PrjId", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"TabFeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabFeatureId = "TabFeatureId";    //表功能Id

 /// <summary>
 /// 常量:"TabFeatureName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabFeatureName = "TabFeatureName";    //表功能名

 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"FeatureId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeatureId = "FeatureId";    //功能Id

 /// <summary>
 /// 常量:"FuncNameCs"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncNameCs = "FuncNameCs";    //Cs函数名

 /// <summary>
 /// 常量:"FuncNameJs"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncNameJs = "FuncNameJs";    //Js函数名

 /// <summary>
 /// 常量:"IsExtendedClass"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsExtendedClass = "IsExtendedClass";    //是否在扩展类

 /// <summary>
 /// 常量:"IsForCSharp"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsForCSharp = "IsForCSharp";    //是否ForCSharp

 /// <summary>
 /// 常量:"IsForTypeScript"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsForTypeScript = "IsForTypeScript";    //是否ForTypeScript

 /// <summary>
 /// 常量:"IsForDiv"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsForDiv = "IsForDiv";    //是否针对Div内控件

 /// <summary>
 /// 常量:"IsNeedGC"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNeedGC = "IsNeedGC";    //是否需要生成代码

 /// <summary>
 /// 常量:"UseTimes"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UseTimes = "UseTimes";    //使用次数

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"IsNullable"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNullable = "IsNullable";    //是否可空

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"CheckDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CheckDate = "CheckDate";    //检查日期

 /// <summary>
 /// 常量:"ErrMsg"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrMsg = "ErrMsg";    //错误信息

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程ID

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改者

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明
}

}