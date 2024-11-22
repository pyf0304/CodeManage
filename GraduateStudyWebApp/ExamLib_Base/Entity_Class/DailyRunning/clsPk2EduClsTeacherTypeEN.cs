﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPk2EduClsTeacherTypeEN
 表名:Pk2EduClsTeacherType(01120133)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:07:03
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日常运行(DailyRunning)
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
 /// 表Pk2EduClsTeacherType的关键字(IdPk2EduClsTeacherType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdPk2EduClsTeacherType_Pk2EduClsTeacherType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdPk2EduClsTeacherType">表关键字</param>
public K_IdPk2EduClsTeacherType_Pk2EduClsTeacherType(string strIdPk2EduClsTeacherType)
{
if (IsValid(strIdPk2EduClsTeacherType)) Value = strIdPk2EduClsTeacherType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdPk2EduClsTeacherType)
{
if (string.IsNullOrEmpty(strIdPk2EduClsTeacherType) == true) return false;
if (strIdPk2EduClsTeacherType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdPk2EduClsTeacherType_Pk2EduClsTeacherType]类型的对象</returns>
public static implicit operator K_IdPk2EduClsTeacherType_Pk2EduClsTeacherType(string value)
{
return new K_IdPk2EduClsTeacherType_Pk2EduClsTeacherType(value);
}
}
 /// <summary>
 /// 教学班教师角色表2(Pk2EduClsTeacherType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPk2EduClsTeacherTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "Pk2EduClsTeacherType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdPk2EduClsTeacherType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"IdPk2EduClsTeacherType", "EduClsTeacherTypeId", "EduClsTeacherTypeDesc"};

protected string mstrIdPk2EduClsTeacherType;    //教学班老师角色(主讲,辅导)流水号
protected string mstrEduClsTeacherTypeId;    //教学班教学类型ID
protected string mstrEduClsTeacherTypeDesc;    //教学班教师类型名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsPk2EduClsTeacherTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPk2EduClsTeacherType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdPk2EduClsTeacherType">关键字:教学班老师角色(主讲,辅导)流水号</param>
public clsPk2EduClsTeacherTypeEN(string strIdPk2EduClsTeacherType)
 {
strIdPk2EduClsTeacherType = strIdPk2EduClsTeacherType.Replace("'", "''");
if (strIdPk2EduClsTeacherType.Length > 4)
{
throw new Exception("在表:Pk2EduClsTeacherType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdPk2EduClsTeacherType)  ==  true)
{
throw new Exception("在表:Pk2EduClsTeacherType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdPk2EduClsTeacherType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdPk2EduClsTeacherType = strIdPk2EduClsTeacherType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPk2EduClsTeacherType");
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
if (strAttributeName  ==  conPk2EduClsTeacherType.IdPk2EduClsTeacherType)
{
return mstrIdPk2EduClsTeacherType;
}
else if (strAttributeName  ==  conPk2EduClsTeacherType.EduClsTeacherTypeId)
{
return mstrEduClsTeacherTypeId;
}
else if (strAttributeName  ==  conPk2EduClsTeacherType.EduClsTeacherTypeDesc)
{
return mstrEduClsTeacherTypeDesc;
}
return null;
}
set
{
if (strAttributeName  ==  conPk2EduClsTeacherType.IdPk2EduClsTeacherType)
{
mstrIdPk2EduClsTeacherType = value.ToString();
 AddUpdatedFld(conPk2EduClsTeacherType.IdPk2EduClsTeacherType);
}
else if (strAttributeName  ==  conPk2EduClsTeacherType.EduClsTeacherTypeId)
{
mstrEduClsTeacherTypeId = value.ToString();
 AddUpdatedFld(conPk2EduClsTeacherType.EduClsTeacherTypeId);
}
else if (strAttributeName  ==  conPk2EduClsTeacherType.EduClsTeacherTypeDesc)
{
mstrEduClsTeacherTypeDesc = value.ToString();
 AddUpdatedFld(conPk2EduClsTeacherType.EduClsTeacherTypeDesc);
}
}
}
public object this[int intIndex]
{
get
{
if (conPk2EduClsTeacherType.IdPk2EduClsTeacherType  ==  AttributeName[intIndex])
{
return mstrIdPk2EduClsTeacherType;
}
else if (conPk2EduClsTeacherType.EduClsTeacherTypeId  ==  AttributeName[intIndex])
{
return mstrEduClsTeacherTypeId;
}
else if (conPk2EduClsTeacherType.EduClsTeacherTypeDesc  ==  AttributeName[intIndex])
{
return mstrEduClsTeacherTypeDesc;
}
return null;
}
set
{
if (conPk2EduClsTeacherType.IdPk2EduClsTeacherType  ==  AttributeName[intIndex])
{
mstrIdPk2EduClsTeacherType = value.ToString();
 AddUpdatedFld(conPk2EduClsTeacherType.IdPk2EduClsTeacherType);
}
else if (conPk2EduClsTeacherType.EduClsTeacherTypeId  ==  AttributeName[intIndex])
{
mstrEduClsTeacherTypeId = value.ToString();
 AddUpdatedFld(conPk2EduClsTeacherType.EduClsTeacherTypeId);
}
else if (conPk2EduClsTeacherType.EduClsTeacherTypeDesc  ==  AttributeName[intIndex])
{
mstrEduClsTeacherTypeDesc = value.ToString();
 AddUpdatedFld(conPk2EduClsTeacherType.EduClsTeacherTypeDesc);
}
}
}

/// <summary>
/// 教学班老师角色(主讲,辅导)流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdPk2EduClsTeacherType
{
get
{
return mstrIdPk2EduClsTeacherType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdPk2EduClsTeacherType = value;
}
else
{
 mstrIdPk2EduClsTeacherType = value;
}
//记录修改过的字段
 AddUpdatedFld(conPk2EduClsTeacherType.IdPk2EduClsTeacherType);
}
}
/// <summary>
/// 教学班教学类型ID(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduClsTeacherTypeId
{
get
{
return mstrEduClsTeacherTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduClsTeacherTypeId = value;
}
else
{
 mstrEduClsTeacherTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPk2EduClsTeacherType.EduClsTeacherTypeId);
}
}
/// <summary>
/// 教学班教师类型名(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduClsTeacherTypeDesc
{
get
{
return mstrEduClsTeacherTypeDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduClsTeacherTypeDesc = value;
}
else
{
 mstrEduClsTeacherTypeDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(conPk2EduClsTeacherType.EduClsTeacherTypeDesc);
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
  return mstrIdPk2EduClsTeacherType;
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
  return mstrEduClsTeacherTypeDesc;
 }
 }
}
 /// <summary>
 /// 教学班教师角色表2(Pk2EduClsTeacherType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPk2EduClsTeacherType
{
public const string _CurrTabName = "Pk2EduClsTeacherType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdPk2EduClsTeacherType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdPk2EduClsTeacherType", "EduClsTeacherTypeId", "EduClsTeacherTypeDesc"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdPk2EduClsTeacherType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPk2EduClsTeacherType = "IdPk2EduClsTeacherType";    //教学班老师角色(主讲,辅导)流水号

 /// <summary>
 /// 常量:"EduClsTeacherTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduClsTeacherTypeId = "EduClsTeacherTypeId";    //教学班教学类型ID

 /// <summary>
 /// 常量:"EduClsTeacherTypeDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduClsTeacherTypeDesc = "EduClsTeacherTypeDesc";    //教学班教师类型名
}

}