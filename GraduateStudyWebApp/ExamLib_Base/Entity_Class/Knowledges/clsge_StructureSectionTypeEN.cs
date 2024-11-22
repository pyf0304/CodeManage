﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_StructureSectionTypeEN
 表名:ge_StructureSectionType(01120901)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:19:14
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// 表ge_StructureSectionType的关键字(SectionTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_SectionTypeId_ge_StructureSectionType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strSectionTypeId">表关键字</param>
public K_SectionTypeId_ge_StructureSectionType(string strSectionTypeId)
{
if (IsValid(strSectionTypeId)) Value = strSectionTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strSectionTypeId)
{
if (string.IsNullOrEmpty(strSectionTypeId) == true) return false;
if (strSectionTypeId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_SectionTypeId_ge_StructureSectionType]类型的对象</returns>
public static implicit operator K_SectionTypeId_ge_StructureSectionType(string value)
{
return new K_SectionTypeId_ge_StructureSectionType(value);
}
}
 /// <summary>
 /// 结构章节类型(ge_StructureSectionType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsge_StructureSectionTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ge_StructureSectionType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "SectionTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"SectionTypeId", "SectionTypeName", "SectionTypeEnName", "CourseId", "UpdDate", "UpdUser", "Memo"};

protected string mstrSectionTypeId;    //节点类型Id
protected string mstrSectionTypeName;    //节点类型名称
protected string mstrSectionTypeEnName;    //节点类型英文名称
protected string mstrCourseId;    //课程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsge_StructureSectionTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SectionTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strSectionTypeId">关键字:节点类型Id</param>
public clsge_StructureSectionTypeEN(string strSectionTypeId)
 {
strSectionTypeId = strSectionTypeId.Replace("'", "''");
if (strSectionTypeId.Length > 8)
{
throw new Exception("在表:ge_StructureSectionType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strSectionTypeId)  ==  true)
{
throw new Exception("在表:ge_StructureSectionType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSectionTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrSectionTypeId = strSectionTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SectionTypeId");
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
if (strAttributeName  ==  conge_StructureSectionType.SectionTypeId)
{
return mstrSectionTypeId;
}
else if (strAttributeName  ==  conge_StructureSectionType.SectionTypeName)
{
return mstrSectionTypeName;
}
else if (strAttributeName  ==  conge_StructureSectionType.SectionTypeEnName)
{
return mstrSectionTypeEnName;
}
else if (strAttributeName  ==  conge_StructureSectionType.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conge_StructureSectionType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conge_StructureSectionType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conge_StructureSectionType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conge_StructureSectionType.SectionTypeId)
{
mstrSectionTypeId = value.ToString();
 AddUpdatedFld(conge_StructureSectionType.SectionTypeId);
}
else if (strAttributeName  ==  conge_StructureSectionType.SectionTypeName)
{
mstrSectionTypeName = value.ToString();
 AddUpdatedFld(conge_StructureSectionType.SectionTypeName);
}
else if (strAttributeName  ==  conge_StructureSectionType.SectionTypeEnName)
{
mstrSectionTypeEnName = value.ToString();
 AddUpdatedFld(conge_StructureSectionType.SectionTypeEnName);
}
else if (strAttributeName  ==  conge_StructureSectionType.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conge_StructureSectionType.CourseId);
}
else if (strAttributeName  ==  conge_StructureSectionType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_StructureSectionType.UpdDate);
}
else if (strAttributeName  ==  conge_StructureSectionType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_StructureSectionType.UpdUser);
}
else if (strAttributeName  ==  conge_StructureSectionType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_StructureSectionType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conge_StructureSectionType.SectionTypeId  ==  AttributeName[intIndex])
{
return mstrSectionTypeId;
}
else if (conge_StructureSectionType.SectionTypeName  ==  AttributeName[intIndex])
{
return mstrSectionTypeName;
}
else if (conge_StructureSectionType.SectionTypeEnName  ==  AttributeName[intIndex])
{
return mstrSectionTypeEnName;
}
else if (conge_StructureSectionType.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conge_StructureSectionType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conge_StructureSectionType.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conge_StructureSectionType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conge_StructureSectionType.SectionTypeId  ==  AttributeName[intIndex])
{
mstrSectionTypeId = value.ToString();
 AddUpdatedFld(conge_StructureSectionType.SectionTypeId);
}
else if (conge_StructureSectionType.SectionTypeName  ==  AttributeName[intIndex])
{
mstrSectionTypeName = value.ToString();
 AddUpdatedFld(conge_StructureSectionType.SectionTypeName);
}
else if (conge_StructureSectionType.SectionTypeEnName  ==  AttributeName[intIndex])
{
mstrSectionTypeEnName = value.ToString();
 AddUpdatedFld(conge_StructureSectionType.SectionTypeEnName);
}
else if (conge_StructureSectionType.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conge_StructureSectionType.CourseId);
}
else if (conge_StructureSectionType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conge_StructureSectionType.UpdDate);
}
else if (conge_StructureSectionType.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conge_StructureSectionType.UpdUser);
}
else if (conge_StructureSectionType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conge_StructureSectionType.Memo);
}
}
}

/// <summary>
/// 节点类型Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionTypeId
{
get
{
return mstrSectionTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionTypeId = value;
}
else
{
 mstrSectionTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_StructureSectionType.SectionTypeId);
}
}
/// <summary>
/// 节点类型名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionTypeName
{
get
{
return mstrSectionTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionTypeName = value;
}
else
{
 mstrSectionTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_StructureSectionType.SectionTypeName);
}
}
/// <summary>
/// 节点类型英文名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionTypeEnName
{
get
{
return mstrSectionTypeEnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionTypeEnName = value;
}
else
{
 mstrSectionTypeEnName = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_StructureSectionType.SectionTypeEnName);
}
}
/// <summary>
/// 课程Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseId
{
get
{
return mstrCourseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseId = value;
}
else
{
 mstrCourseId = value;
}
//记录修改过的字段
 AddUpdatedFld(conge_StructureSectionType.CourseId);
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
 AddUpdatedFld(conge_StructureSectionType.UpdDate);
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
 AddUpdatedFld(conge_StructureSectionType.UpdUser);
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
 AddUpdatedFld(conge_StructureSectionType.Memo);
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
  return mstrSectionTypeId;
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
  return mstrSectionTypeName;
 }
 }
}
 /// <summary>
 /// 结构章节类型(ge_StructureSectionType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conge_StructureSectionType
{
public const string _CurrTabName = "ge_StructureSectionType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SectionTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"SectionTypeId", "SectionTypeName", "SectionTypeEnName", "CourseId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"SectionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionTypeId = "SectionTypeId";    //节点类型Id

 /// <summary>
 /// 常量:"SectionTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionTypeName = "SectionTypeName";    //节点类型名称

 /// <summary>
 /// 常量:"SectionTypeEnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionTypeEnName = "SectionTypeEnName";    //节点类型英文名称

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

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