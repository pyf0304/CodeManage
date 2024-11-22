
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGatherModeEN
 表名:GatherMode(01120014)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:18:27
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:查询统计(QueryStatistics)
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
 /// 表GatherMode的关键字(GatherModeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_GatherModeId_GatherMode
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strGatherModeId">表关键字</param>
public K_GatherModeId_GatherMode(string strGatherModeId)
{
if (IsValid(strGatherModeId)) Value = strGatherModeId;
else
{
Value = null;
}
}
private static bool IsValid(string strGatherModeId)
{
if (string.IsNullOrEmpty(strGatherModeId) == true) return false;
if (strGatherModeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_GatherModeId_GatherMode]类型的对象</returns>
public static implicit operator K_GatherModeId_GatherMode(string value)
{
return new K_GatherModeId_GatherMode(value);
}
}
 /// <summary>
 /// 汇总模式(GatherMode)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsGatherModeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "GatherMode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "GatherModeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"GatherModeId", "GatherModeName", "Memo"};

protected string mstrGatherModeId;    //汇总模式Id
protected string mstrGatherModeName;    //汇总模式名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsGatherModeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("GatherModeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strGatherModeId">关键字:汇总模式Id</param>
public clsGatherModeEN(string strGatherModeId)
 {
strGatherModeId = strGatherModeId.Replace("'", "''");
if (strGatherModeId.Length > 4)
{
throw new Exception("在表:GatherMode中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strGatherModeId)  ==  true)
{
throw new Exception("在表:GatherMode中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strGatherModeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrGatherModeId = strGatherModeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("GatherModeId");
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
if (strAttributeName  ==  conGatherMode.GatherModeId)
{
return mstrGatherModeId;
}
else if (strAttributeName  ==  conGatherMode.GatherModeName)
{
return mstrGatherModeName;
}
else if (strAttributeName  ==  conGatherMode.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conGatherMode.GatherModeId)
{
mstrGatherModeId = value.ToString();
 AddUpdatedFld(conGatherMode.GatherModeId);
}
else if (strAttributeName  ==  conGatherMode.GatherModeName)
{
mstrGatherModeName = value.ToString();
 AddUpdatedFld(conGatherMode.GatherModeName);
}
else if (strAttributeName  ==  conGatherMode.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conGatherMode.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conGatherMode.GatherModeId  ==  AttributeName[intIndex])
{
return mstrGatherModeId;
}
else if (conGatherMode.GatherModeName  ==  AttributeName[intIndex])
{
return mstrGatherModeName;
}
else if (conGatherMode.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conGatherMode.GatherModeId  ==  AttributeName[intIndex])
{
mstrGatherModeId = value.ToString();
 AddUpdatedFld(conGatherMode.GatherModeId);
}
else if (conGatherMode.GatherModeName  ==  AttributeName[intIndex])
{
mstrGatherModeName = value.ToString();
 AddUpdatedFld(conGatherMode.GatherModeName);
}
else if (conGatherMode.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conGatherMode.Memo);
}
}
}

/// <summary>
/// 汇总模式Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GatherModeId
{
get
{
return mstrGatherModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGatherModeId = value;
}
else
{
 mstrGatherModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conGatherMode.GatherModeId);
}
}
/// <summary>
/// 汇总模式名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GatherModeName
{
get
{
return mstrGatherModeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGatherModeName = value;
}
else
{
 mstrGatherModeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conGatherMode.GatherModeName);
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
 AddUpdatedFld(conGatherMode.Memo);
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
  return mstrGatherModeId;
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
  return mstrGatherModeName;
 }
 }
}
 /// <summary>
 /// 汇总模式(GatherMode)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conGatherMode
{
public const string _CurrTabName = "GatherMode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "GatherModeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"GatherModeId", "GatherModeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"GatherModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GatherModeId = "GatherModeId";    //汇总模式Id

 /// <summary>
 /// 常量:"GatherModeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GatherModeName = "GatherModeName";    //汇总模式名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}