
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysVoteTypeEN
 表名:SysVoteType(01120638)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:14:04
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
 /// 表SysVoteType的关键字(VoteTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_VoteTypeId_SysVoteType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strVoteTypeId">表关键字</param>
public K_VoteTypeId_SysVoteType(string strVoteTypeId)
{
if (IsValid(strVoteTypeId)) Value = strVoteTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strVoteTypeId)
{
if (string.IsNullOrEmpty(strVoteTypeId) == true) return false;
if (strVoteTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_VoteTypeId_SysVoteType]类型的对象</returns>
public static implicit operator K_VoteTypeId_SysVoteType(string value)
{
return new K_VoteTypeId_SysVoteType(value);
}
}
 /// <summary>
 /// 系统点赞类型(SysVoteType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSysVoteTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SysVoteType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "VoteTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"VoteTypeId", "VoteTypeName", "VoteTable", "VoteTableId", "Memo"};

protected string mstrVoteTypeId;    //点赞类型Id
protected string mstrVoteTypeName;    //点赞类型名称
protected string mstrVoteTable;    //点赞表
protected string mstrVoteTableId;    //点赞表Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsSysVoteTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("VoteTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strVoteTypeId">关键字:点赞类型Id</param>
public clsSysVoteTypeEN(string strVoteTypeId)
 {
strVoteTypeId = strVoteTypeId.Replace("'", "''");
if (strVoteTypeId.Length > 2)
{
throw new Exception("在表:SysVoteType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strVoteTypeId)  ==  true)
{
throw new Exception("在表:SysVoteType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strVoteTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrVoteTypeId = strVoteTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("VoteTypeId");
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
if (strAttributeName  ==  conSysVoteType.VoteTypeId)
{
return mstrVoteTypeId;
}
else if (strAttributeName  ==  conSysVoteType.VoteTypeName)
{
return mstrVoteTypeName;
}
else if (strAttributeName  ==  conSysVoteType.VoteTable)
{
return mstrVoteTable;
}
else if (strAttributeName  ==  conSysVoteType.VoteTableId)
{
return mstrVoteTableId;
}
else if (strAttributeName  ==  conSysVoteType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conSysVoteType.VoteTypeId)
{
mstrVoteTypeId = value.ToString();
 AddUpdatedFld(conSysVoteType.VoteTypeId);
}
else if (strAttributeName  ==  conSysVoteType.VoteTypeName)
{
mstrVoteTypeName = value.ToString();
 AddUpdatedFld(conSysVoteType.VoteTypeName);
}
else if (strAttributeName  ==  conSysVoteType.VoteTable)
{
mstrVoteTable = value.ToString();
 AddUpdatedFld(conSysVoteType.VoteTable);
}
else if (strAttributeName  ==  conSysVoteType.VoteTableId)
{
mstrVoteTableId = value.ToString();
 AddUpdatedFld(conSysVoteType.VoteTableId);
}
else if (strAttributeName  ==  conSysVoteType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSysVoteType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conSysVoteType.VoteTypeId  ==  AttributeName[intIndex])
{
return mstrVoteTypeId;
}
else if (conSysVoteType.VoteTypeName  ==  AttributeName[intIndex])
{
return mstrVoteTypeName;
}
else if (conSysVoteType.VoteTable  ==  AttributeName[intIndex])
{
return mstrVoteTable;
}
else if (conSysVoteType.VoteTableId  ==  AttributeName[intIndex])
{
return mstrVoteTableId;
}
else if (conSysVoteType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conSysVoteType.VoteTypeId  ==  AttributeName[intIndex])
{
mstrVoteTypeId = value.ToString();
 AddUpdatedFld(conSysVoteType.VoteTypeId);
}
else if (conSysVoteType.VoteTypeName  ==  AttributeName[intIndex])
{
mstrVoteTypeName = value.ToString();
 AddUpdatedFld(conSysVoteType.VoteTypeName);
}
else if (conSysVoteType.VoteTable  ==  AttributeName[intIndex])
{
mstrVoteTable = value.ToString();
 AddUpdatedFld(conSysVoteType.VoteTable);
}
else if (conSysVoteType.VoteTableId  ==  AttributeName[intIndex])
{
mstrVoteTableId = value.ToString();
 AddUpdatedFld(conSysVoteType.VoteTableId);
}
else if (conSysVoteType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSysVoteType.Memo);
}
}
}

/// <summary>
/// 点赞类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VoteTypeId
{
get
{
return mstrVoteTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVoteTypeId = value;
}
else
{
 mstrVoteTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysVoteType.VoteTypeId);
}
}
/// <summary>
/// 点赞类型名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VoteTypeName
{
get
{
return mstrVoteTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVoteTypeName = value;
}
else
{
 mstrVoteTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysVoteType.VoteTypeName);
}
}
/// <summary>
/// 点赞表(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VoteTable
{
get
{
return mstrVoteTable;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVoteTable = value;
}
else
{
 mstrVoteTable = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysVoteType.VoteTable);
}
}
/// <summary>
/// 点赞表Id(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VoteTableId
{
get
{
return mstrVoteTableId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVoteTableId = value;
}
else
{
 mstrVoteTableId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysVoteType.VoteTableId);
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
 AddUpdatedFld(conSysVoteType.Memo);
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
  return mstrVoteTypeId;
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
  return mstrVoteTypeName;
 }
 }
}
 /// <summary>
 /// 系统点赞类型(SysVoteType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSysVoteType
{
public const string _CurrTabName = "SysVoteType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "VoteTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"VoteTypeId", "VoteTypeName", "VoteTable", "VoteTableId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"VoteTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VoteTypeId = "VoteTypeId";    //点赞类型Id

 /// <summary>
 /// 常量:"VoteTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VoteTypeName = "VoteTypeName";    //点赞类型名称

 /// <summary>
 /// 常量:"VoteTable"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VoteTable = "VoteTable";    //点赞表

 /// <summary>
 /// 常量:"VoteTableId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VoteTableId = "VoteTableId";    //点赞表Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}