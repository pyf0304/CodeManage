
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_DifficultyLevelEN
 表名:ge_DifficultyLevel(01120905)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:07:48
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置(SystemSet)
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
 /// 表ge_DifficultyLevel的关键字(DifficultyLevelId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DifficultyLevelId_ge_DifficultyLevel
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strDifficultyLevelId">表关键字</param>
public K_DifficultyLevelId_ge_DifficultyLevel(string strDifficultyLevelId)
{
if (IsValid(strDifficultyLevelId)) Value = strDifficultyLevelId;
else
{
Value = null;
}
}
private static bool IsValid(string strDifficultyLevelId)
{
if (string.IsNullOrEmpty(strDifficultyLevelId) == true) return false;
if (strDifficultyLevelId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_DifficultyLevelId_ge_DifficultyLevel]类型的对象</returns>
public static implicit operator K_DifficultyLevelId_ge_DifficultyLevel(string value)
{
return new K_DifficultyLevelId_ge_DifficultyLevel(value);
}
}
 /// <summary>
 /// 难度等级表(ge_DifficultyLevel)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsge_DifficultyLevelEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ge_DifficultyLevel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "DifficultyLevelId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"DifficultyLevelId", "DifficultyLevelName", "DifficultyLevelENName", "UpdDate", "UpdUser", "Memo"};

protected string mstrDifficultyLevelId;    //难度等级Id
protected string mstrDifficultyLevelName;    //难度等级名称
protected string mstrDifficultyLevelENName;    //难度等级英文名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsge_DifficultyLevelEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DifficultyLevelId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strDifficultyLevelId">关键字:难度等级Id</param>
public clsge_DifficultyLevelEN(string strDifficultyLevelId)
 {
strDifficultyLevelId = strDifficultyLevelId.Replace("'", "''");
if (strDifficultyLevelId.Length > 2)
{
throw new Exception("在表:ge_DifficultyLevel中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strDifficultyLevelId)  ==  true)
{
throw new Exception("在表:ge_DifficultyLevel中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDifficultyLevelId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrDifficultyLevelId = strDifficultyLevelId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DifficultyLevelId");
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
if (strAttributeName  ==  conge_DifficultyLevel.DifficultyLevelId)
{
return mstrDifficultyLevelId;
}
else if (strAttributeName  ==  conge_DifficultyLevel.DifficultyLevelName)
{
return mstrDifficultyLevelName;
}
else if (strAttributeName  ==  conge_DifficultyLevel.DifficultyLevelENName)
{
return mstrDifficultyLevelENName;
}
else if (strAttributeName  ==  conge_DifficultyLevel.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conge_DifficultyLevel.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conge_DifficultyLevel.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conge_DifficultyLevel.DifficultyLevelId)
{
mstrDifficultyLevelId = value.ToString();
 AddUpdatedFld(conge_DifficultyLevel.DifficultyLevelId);
}
else if (strAttributeName  ==  conge_DifficultyLevel.DifficultyLevelName)
{
mstrDifficultyLevelName = value.ToString();
 AddUpdatedFld(conge_DifficultyLevel.DifficultyLevelName);
}
else if (strAttributeName  ==  conge_DifficultyLevel.DifficultyLevelENName)
{
mstrDifficultyLevelENName = value.ToString();
 AddUpdatedFld(conge_DifficultyLevel.DifficultyLevelENName);
}
else if (strAttributeName  ==  conge_DifficultyLevel.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_DifficultyLevel.UpdDate);
}
else if (strAttributeName  ==  conge_DifficultyLevel.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_DifficultyLevel.UpdUser);
}
else if (strAttributeName  ==  conge_DifficultyLevel.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_DifficultyLevel.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conge_DifficultyLevel.DifficultyLevelId  ==  AttributeName[intIndex])
{
return mstrDifficultyLevelId;
}
else if (conge_DifficultyLevel.DifficultyLevelName  ==  AttributeName[intIndex])
{
return mstrDifficultyLevelName;
}
else if (conge_DifficultyLevel.DifficultyLevelENName  ==  AttributeName[intIndex])
{
return mstrDifficultyLevelENName;
}
else if (conge_DifficultyLevel.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conge_DifficultyLevel.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conge_DifficultyLevel.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conge_DifficultyLevel.DifficultyLevelId  ==  AttributeName[intIndex])
{
mstrDifficultyLevelId = value.ToString();
 AddUpdatedFld(conge_DifficultyLevel.DifficultyLevelId);
}
else if (conge_DifficultyLevel.DifficultyLevelName  ==  AttributeName[intIndex])
{
mstrDifficultyLevelName = value.ToString();
 AddUpdatedFld(conge_DifficultyLevel.DifficultyLevelName);
}
else if (conge_DifficultyLevel.DifficultyLevelENName  ==  AttributeName[intIndex])
{
mstrDifficultyLevelENName = value.ToString();
 AddUpdatedFld(conge_DifficultyLevel.DifficultyLevelENName);
}
else if (conge_DifficultyLevel.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_DifficultyLevel.UpdDate);
}
else if (conge_DifficultyLevel.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_DifficultyLevel.UpdUser);
}
else if (conge_DifficultyLevel.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_DifficultyLevel.Memo);
}
}
}

/// <summary>
/// 难度等级Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DifficultyLevelId
{
get
{
return mstrDifficultyLevelId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDifficultyLevelId = value;
}
else
{
 mstrDifficultyLevelId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_DifficultyLevel.DifficultyLevelId);
}
}
/// <summary>
/// 难度等级名称(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DifficultyLevelName
{
get
{
return mstrDifficultyLevelName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDifficultyLevelName = value;
}
else
{
 mstrDifficultyLevelName = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_DifficultyLevel.DifficultyLevelName);
}
}
/// <summary>
/// 难度等级英文名(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DifficultyLevelENName
{
get
{
return mstrDifficultyLevelENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDifficultyLevelENName = value;
}
else
{
 mstrDifficultyLevelENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_DifficultyLevel.DifficultyLevelENName);
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
 AddUpdatedFld(conge_DifficultyLevel.UpdDate);
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
 AddUpdatedFld(conge_DifficultyLevel.UpdUser);
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
 AddUpdatedFld(conge_DifficultyLevel.Memo);
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
  return mstrDifficultyLevelId;
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
  return mstrDifficultyLevelName;
 }
 }
}
 /// <summary>
 /// 难度等级表(ge_DifficultyLevel)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conge_DifficultyLevel
{
public const string _CurrTabName = "ge_DifficultyLevel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DifficultyLevelId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"DifficultyLevelId", "DifficultyLevelName", "DifficultyLevelENName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"DifficultyLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DifficultyLevelId = "DifficultyLevelId";    //难度等级Id

 /// <summary>
 /// 常量:"DifficultyLevelName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DifficultyLevelName = "DifficultyLevelName";    //难度等级名称

 /// <summary>
 /// 常量:"DifficultyLevelENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DifficultyLevelENName = "DifficultyLevelENName";    //难度等级英文名

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}