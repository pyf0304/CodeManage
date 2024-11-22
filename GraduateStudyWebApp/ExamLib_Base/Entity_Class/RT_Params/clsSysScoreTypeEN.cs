
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysScoreTypeEN
 表名:SysScoreType(01120631)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:14:08
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培参数(RT_Params)
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
 /// 表SysScoreType的关键字(ScoreTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ScoreTypeId_SysScoreType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strScoreTypeId">表关键字</param>
public K_ScoreTypeId_SysScoreType(string strScoreTypeId)
{
if (IsValid(strScoreTypeId)) Value = strScoreTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strScoreTypeId)
{
if (string.IsNullOrEmpty(strScoreTypeId) == true) return false;
if (strScoreTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ScoreTypeId_SysScoreType]类型的对象</returns>
public static implicit operator K_ScoreTypeId_SysScoreType(string value)
{
return new K_ScoreTypeId_SysScoreType(value);
}
}
 /// <summary>
 /// 评分类型表(SysScoreType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSysScoreTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SysScoreType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ScoreTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"ScoreTypeId", "ScoreTypeName", "OnlyId", "UpdUser", "UpdDate", "Memo"};

protected string mstrScoreTypeId;    //分数类型Id
protected string mstrScoreTypeName;    //分数类型名称
protected string mstrOnlyId;    //OnlyId
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsSysScoreTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ScoreTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strScoreTypeId">关键字:分数类型Id</param>
public clsSysScoreTypeEN(string strScoreTypeId)
 {
strScoreTypeId = strScoreTypeId.Replace("'", "''");
if (strScoreTypeId.Length > 4)
{
throw new Exception("在表:SysScoreType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strScoreTypeId)  ==  true)
{
throw new Exception("在表:SysScoreType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strScoreTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrScoreTypeId = strScoreTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ScoreTypeId");
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
if (strAttributeName  ==  conSysScoreType.ScoreTypeId)
{
return mstrScoreTypeId;
}
else if (strAttributeName  ==  conSysScoreType.ScoreTypeName)
{
return mstrScoreTypeName;
}
else if (strAttributeName  ==  conSysScoreType.OnlyId)
{
return mstrOnlyId;
}
else if (strAttributeName  ==  conSysScoreType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conSysScoreType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conSysScoreType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conSysScoreType.ScoreTypeId)
{
mstrScoreTypeId = value.ToString();
 AddUpdatedFld(conSysScoreType.ScoreTypeId);
}
else if (strAttributeName  ==  conSysScoreType.ScoreTypeName)
{
mstrScoreTypeName = value.ToString();
 AddUpdatedFld(conSysScoreType.ScoreTypeName);
}
else if (strAttributeName  ==  conSysScoreType.OnlyId)
{
mstrOnlyId = value.ToString();
 AddUpdatedFld(conSysScoreType.OnlyId);
}
else if (strAttributeName  ==  conSysScoreType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conSysScoreType.UpdUser);
}
else if (strAttributeName  ==  conSysScoreType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSysScoreType.UpdDate);
}
else if (strAttributeName  ==  conSysScoreType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSysScoreType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conSysScoreType.ScoreTypeId  ==  AttributeName[intIndex])
{
return mstrScoreTypeId;
}
else if (conSysScoreType.ScoreTypeName  ==  AttributeName[intIndex])
{
return mstrScoreTypeName;
}
else if (conSysScoreType.OnlyId  ==  AttributeName[intIndex])
{
return mstrOnlyId;
}
else if (conSysScoreType.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conSysScoreType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conSysScoreType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conSysScoreType.ScoreTypeId  ==  AttributeName[intIndex])
{
mstrScoreTypeId = value.ToString();
 AddUpdatedFld(conSysScoreType.ScoreTypeId);
}
else if (conSysScoreType.ScoreTypeName  ==  AttributeName[intIndex])
{
mstrScoreTypeName = value.ToString();
 AddUpdatedFld(conSysScoreType.ScoreTypeName);
}
else if (conSysScoreType.OnlyId  ==  AttributeName[intIndex])
{
mstrOnlyId = value.ToString();
 AddUpdatedFld(conSysScoreType.OnlyId);
}
else if (conSysScoreType.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conSysScoreType.UpdUser);
}
else if (conSysScoreType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSysScoreType.UpdDate);
}
else if (conSysScoreType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSysScoreType.Memo);
}
}
}

/// <summary>
/// 分数类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ScoreTypeId
{
get
{
return mstrScoreTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrScoreTypeId = value;
}
else
{
 mstrScoreTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysScoreType.ScoreTypeId);
}
}
/// <summary>
/// 分数类型名称(说明:;字段类型:varchar;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ScoreTypeName
{
get
{
return mstrScoreTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrScoreTypeName = value;
}
else
{
 mstrScoreTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysScoreType.ScoreTypeName);
}
}
/// <summary>
/// OnlyId(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OnlyId
{
get
{
return mstrOnlyId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOnlyId = value;
}
else
{
 mstrOnlyId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysScoreType.OnlyId);
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
 AddUpdatedFld(conSysScoreType.UpdUser);
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
 AddUpdatedFld(conSysScoreType.UpdDate);
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
 AddUpdatedFld(conSysScoreType.Memo);
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
  return mstrScoreTypeId;
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
  return mstrScoreTypeName;
 }
 }
}
 /// <summary>
 /// 评分类型表(SysScoreType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSysScoreType
{
public const string _CurrTabName = "SysScoreType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ScoreTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ScoreTypeId", "ScoreTypeName", "OnlyId", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ScoreTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ScoreTypeId = "ScoreTypeId";    //分数类型Id

 /// <summary>
 /// 常量:"ScoreTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ScoreTypeName = "ScoreTypeName";    //分数类型名称

 /// <summary>
 /// 常量:"OnlyId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OnlyId = "OnlyId";    //OnlyId

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}