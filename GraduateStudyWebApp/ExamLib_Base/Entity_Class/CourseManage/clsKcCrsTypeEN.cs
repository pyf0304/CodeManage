
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsKcCrsTypeEN
 表名:KcCrsType(01120136)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:06:31
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程管理(CourseManage)
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
 /// 表KcCrsType的关键字(IdCourseType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCourseType_KcCrsType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdCourseType">表关键字</param>
public K_IdCourseType_KcCrsType(string strIdCourseType)
{
if (IsValid(strIdCourseType)) Value = strIdCourseType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdCourseType)
{
if (string.IsNullOrEmpty(strIdCourseType) == true) return false;
if (strIdCourseType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdCourseType_KcCrsType]类型的对象</returns>
public static implicit operator K_IdCourseType_KcCrsType(string value)
{
return new K_IdCourseType_KcCrsType(value);
}
}
 /// <summary>
 /// 课程类型(KcCrsType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsKcCrsTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "KcCrsType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCourseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 14;
public static string[] AttributeName = new string[] {"IdCourseType", "CourseTypeId", "CourseTypeName", "IsMinor", "ReqOrElect", "PointEnabled", "IdCrsTypeAdminType", "IsCrtlScorePropor", "IsCrtlEduclsMember", "IsElectiveType", "IsOccupyResources", "IsDistinguishDegree", "ModifyUserId", "ModifyDate"};

protected string mstrIdCourseType;    //课程类型流水号
protected string mstrCourseTypeId;    //课程类型ID
protected string mstrCourseTypeName;    //课程类型名称
protected bool mbolIsMinor;    //是否副修
protected bool mbolReqOrElect;    //是否必修
protected bool mbolPointEnabled;    //是否计学分
protected string mstrIdCrsTypeAdminType;    //课程类型管理类型流水号
protected bool mbolIsCrtlScorePropor;    //是否控制成绩比例
protected bool mbolIsCrtlEduclsMember;    //是否控制教学班人数
protected bool mbolIsElectiveType;    //是否可选类型
protected bool mbolIsOccupyResources;    //是否占用资源
protected bool mbolIsDistinguishDegree;    //是否区分学位
protected string mstrModifyUserId;    //修改人
protected string mstrModifyDate;    //修改日期

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsKcCrsTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCourseType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdCourseType">关键字:课程类型流水号</param>
public clsKcCrsTypeEN(string strIdCourseType)
 {
strIdCourseType = strIdCourseType.Replace("'", "''");
if (strIdCourseType.Length > 4)
{
throw new Exception("在表:KcCrsType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdCourseType)  ==  true)
{
throw new Exception("在表:KcCrsType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCourseType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdCourseType = strIdCourseType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCourseType");
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
if (strAttributeName  ==  conKcCrsType.IdCourseType)
{
return mstrIdCourseType;
}
else if (strAttributeName  ==  conKcCrsType.CourseTypeId)
{
return mstrCourseTypeId;
}
else if (strAttributeName  ==  conKcCrsType.CourseTypeName)
{
return mstrCourseTypeName;
}
else if (strAttributeName  ==  conKcCrsType.IsMinor)
{
return mbolIsMinor;
}
else if (strAttributeName  ==  conKcCrsType.ReqOrElect)
{
return mbolReqOrElect;
}
else if (strAttributeName  ==  conKcCrsType.PointEnabled)
{
return mbolPointEnabled;
}
else if (strAttributeName  ==  conKcCrsType.IdCrsTypeAdminType)
{
return mstrIdCrsTypeAdminType;
}
else if (strAttributeName  ==  conKcCrsType.IsCrtlScorePropor)
{
return mbolIsCrtlScorePropor;
}
else if (strAttributeName  ==  conKcCrsType.IsCrtlEduclsMember)
{
return mbolIsCrtlEduclsMember;
}
else if (strAttributeName  ==  conKcCrsType.IsElectiveType)
{
return mbolIsElectiveType;
}
else if (strAttributeName  ==  conKcCrsType.IsOccupyResources)
{
return mbolIsOccupyResources;
}
else if (strAttributeName  ==  conKcCrsType.IsDistinguishDegree)
{
return mbolIsDistinguishDegree;
}
else if (strAttributeName  ==  conKcCrsType.ModifyUserId)
{
return mstrModifyUserId;
}
else if (strAttributeName  ==  conKcCrsType.ModifyDate)
{
return mstrModifyDate;
}
return null;
}
set
{
if (strAttributeName  ==  conKcCrsType.IdCourseType)
{
mstrIdCourseType = value.ToString();
 AddUpdatedFld(conKcCrsType.IdCourseType);
}
else if (strAttributeName  ==  conKcCrsType.CourseTypeId)
{
mstrCourseTypeId = value.ToString();
 AddUpdatedFld(conKcCrsType.CourseTypeId);
}
else if (strAttributeName  ==  conKcCrsType.CourseTypeName)
{
mstrCourseTypeName = value.ToString();
 AddUpdatedFld(conKcCrsType.CourseTypeName);
}
else if (strAttributeName  ==  conKcCrsType.IsMinor)
{
mbolIsMinor = TransNullToBool(value.ToString());
 AddUpdatedFld(conKcCrsType.IsMinor);
}
else if (strAttributeName  ==  conKcCrsType.ReqOrElect)
{
mbolReqOrElect = TransNullToBool(value.ToString());
 AddUpdatedFld(conKcCrsType.ReqOrElect);
}
else if (strAttributeName  ==  conKcCrsType.PointEnabled)
{
mbolPointEnabled = TransNullToBool(value.ToString());
 AddUpdatedFld(conKcCrsType.PointEnabled);
}
else if (strAttributeName  ==  conKcCrsType.IdCrsTypeAdminType)
{
mstrIdCrsTypeAdminType = value.ToString();
 AddUpdatedFld(conKcCrsType.IdCrsTypeAdminType);
}
else if (strAttributeName  ==  conKcCrsType.IsCrtlScorePropor)
{
mbolIsCrtlScorePropor = TransNullToBool(value.ToString());
 AddUpdatedFld(conKcCrsType.IsCrtlScorePropor);
}
else if (strAttributeName  ==  conKcCrsType.IsCrtlEduclsMember)
{
mbolIsCrtlEduclsMember = TransNullToBool(value.ToString());
 AddUpdatedFld(conKcCrsType.IsCrtlEduclsMember);
}
else if (strAttributeName  ==  conKcCrsType.IsElectiveType)
{
mbolIsElectiveType = TransNullToBool(value.ToString());
 AddUpdatedFld(conKcCrsType.IsElectiveType);
}
else if (strAttributeName  ==  conKcCrsType.IsOccupyResources)
{
mbolIsOccupyResources = TransNullToBool(value.ToString());
 AddUpdatedFld(conKcCrsType.IsOccupyResources);
}
else if (strAttributeName  ==  conKcCrsType.IsDistinguishDegree)
{
mbolIsDistinguishDegree = TransNullToBool(value.ToString());
 AddUpdatedFld(conKcCrsType.IsDistinguishDegree);
}
else if (strAttributeName  ==  conKcCrsType.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conKcCrsType.ModifyUserId);
}
else if (strAttributeName  ==  conKcCrsType.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conKcCrsType.ModifyDate);
}
}
}
public object this[int intIndex]
{
get
{
if (conKcCrsType.IdCourseType  ==  AttributeName[intIndex])
{
return mstrIdCourseType;
}
else if (conKcCrsType.CourseTypeId  ==  AttributeName[intIndex])
{
return mstrCourseTypeId;
}
else if (conKcCrsType.CourseTypeName  ==  AttributeName[intIndex])
{
return mstrCourseTypeName;
}
else if (conKcCrsType.IsMinor  ==  AttributeName[intIndex])
{
return mbolIsMinor;
}
else if (conKcCrsType.ReqOrElect  ==  AttributeName[intIndex])
{
return mbolReqOrElect;
}
else if (conKcCrsType.PointEnabled  ==  AttributeName[intIndex])
{
return mbolPointEnabled;
}
else if (conKcCrsType.IdCrsTypeAdminType  ==  AttributeName[intIndex])
{
return mstrIdCrsTypeAdminType;
}
else if (conKcCrsType.IsCrtlScorePropor  ==  AttributeName[intIndex])
{
return mbolIsCrtlScorePropor;
}
else if (conKcCrsType.IsCrtlEduclsMember  ==  AttributeName[intIndex])
{
return mbolIsCrtlEduclsMember;
}
else if (conKcCrsType.IsElectiveType  ==  AttributeName[intIndex])
{
return mbolIsElectiveType;
}
else if (conKcCrsType.IsOccupyResources  ==  AttributeName[intIndex])
{
return mbolIsOccupyResources;
}
else if (conKcCrsType.IsDistinguishDegree  ==  AttributeName[intIndex])
{
return mbolIsDistinguishDegree;
}
else if (conKcCrsType.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
else if (conKcCrsType.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
return null;
}
set
{
if (conKcCrsType.IdCourseType  ==  AttributeName[intIndex])
{
mstrIdCourseType = value.ToString();
 AddUpdatedFld(conKcCrsType.IdCourseType);
}
else if (conKcCrsType.CourseTypeId  ==  AttributeName[intIndex])
{
mstrCourseTypeId = value.ToString();
 AddUpdatedFld(conKcCrsType.CourseTypeId);
}
else if (conKcCrsType.CourseTypeName  ==  AttributeName[intIndex])
{
mstrCourseTypeName = value.ToString();
 AddUpdatedFld(conKcCrsType.CourseTypeName);
}
else if (conKcCrsType.IsMinor  ==  AttributeName[intIndex])
{
mbolIsMinor = TransNullToBool(value.ToString());
 AddUpdatedFld(conKcCrsType.IsMinor);
}
else if (conKcCrsType.ReqOrElect  ==  AttributeName[intIndex])
{
mbolReqOrElect = TransNullToBool(value.ToString());
 AddUpdatedFld(conKcCrsType.ReqOrElect);
}
else if (conKcCrsType.PointEnabled  ==  AttributeName[intIndex])
{
mbolPointEnabled = TransNullToBool(value.ToString());
 AddUpdatedFld(conKcCrsType.PointEnabled);
}
else if (conKcCrsType.IdCrsTypeAdminType  ==  AttributeName[intIndex])
{
mstrIdCrsTypeAdminType = value.ToString();
 AddUpdatedFld(conKcCrsType.IdCrsTypeAdminType);
}
else if (conKcCrsType.IsCrtlScorePropor  ==  AttributeName[intIndex])
{
mbolIsCrtlScorePropor = TransNullToBool(value.ToString());
 AddUpdatedFld(conKcCrsType.IsCrtlScorePropor);
}
else if (conKcCrsType.IsCrtlEduclsMember  ==  AttributeName[intIndex])
{
mbolIsCrtlEduclsMember = TransNullToBool(value.ToString());
 AddUpdatedFld(conKcCrsType.IsCrtlEduclsMember);
}
else if (conKcCrsType.IsElectiveType  ==  AttributeName[intIndex])
{
mbolIsElectiveType = TransNullToBool(value.ToString());
 AddUpdatedFld(conKcCrsType.IsElectiveType);
}
else if (conKcCrsType.IsOccupyResources  ==  AttributeName[intIndex])
{
mbolIsOccupyResources = TransNullToBool(value.ToString());
 AddUpdatedFld(conKcCrsType.IsOccupyResources);
}
else if (conKcCrsType.IsDistinguishDegree  ==  AttributeName[intIndex])
{
mbolIsDistinguishDegree = TransNullToBool(value.ToString());
 AddUpdatedFld(conKcCrsType.IsDistinguishDegree);
}
else if (conKcCrsType.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conKcCrsType.ModifyUserId);
}
else if (conKcCrsType.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conKcCrsType.ModifyDate);
}
}
}

/// <summary>
/// 课程类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCourseType
{
get
{
return mstrIdCourseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCourseType = value;
}
else
{
 mstrIdCourseType = value;
}
//记录修改过的字段
 AddUpdatedFld(conKcCrsType.IdCourseType);
}
}
/// <summary>
/// 课程类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseTypeId
{
get
{
return mstrCourseTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseTypeId = value;
}
else
{
 mstrCourseTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conKcCrsType.CourseTypeId);
}
}
/// <summary>
/// 课程类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseTypeName
{
get
{
return mstrCourseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseTypeName = value;
}
else
{
 mstrCourseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conKcCrsType.CourseTypeName);
}
}
/// <summary>
/// 是否副修(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsMinor
{
get
{
return mbolIsMinor;
}
set
{
 mbolIsMinor = value;
//记录修改过的字段
 AddUpdatedFld(conKcCrsType.IsMinor);
}
}
/// <summary>
/// 是否必修(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool ReqOrElect
{
get
{
return mbolReqOrElect;
}
set
{
 mbolReqOrElect = value;
//记录修改过的字段
 AddUpdatedFld(conKcCrsType.ReqOrElect);
}
}
/// <summary>
/// 是否计学分(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool PointEnabled
{
get
{
return mbolPointEnabled;
}
set
{
 mbolPointEnabled = value;
//记录修改过的字段
 AddUpdatedFld(conKcCrsType.PointEnabled);
}
}
/// <summary>
/// 课程类型管理类型流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCrsTypeAdminType
{
get
{
return mstrIdCrsTypeAdminType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCrsTypeAdminType = value;
}
else
{
 mstrIdCrsTypeAdminType = value;
}
//记录修改过的字段
 AddUpdatedFld(conKcCrsType.IdCrsTypeAdminType);
}
}
/// <summary>
/// 是否控制成绩比例(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCrtlScorePropor
{
get
{
return mbolIsCrtlScorePropor;
}
set
{
 mbolIsCrtlScorePropor = value;
//记录修改过的字段
 AddUpdatedFld(conKcCrsType.IsCrtlScorePropor);
}
}
/// <summary>
/// 是否控制教学班人数(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCrtlEduclsMember
{
get
{
return mbolIsCrtlEduclsMember;
}
set
{
 mbolIsCrtlEduclsMember = value;
//记录修改过的字段
 AddUpdatedFld(conKcCrsType.IsCrtlEduclsMember);
}
}
/// <summary>
/// 是否可选类型(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsElectiveType
{
get
{
return mbolIsElectiveType;
}
set
{
 mbolIsElectiveType = value;
//记录修改过的字段
 AddUpdatedFld(conKcCrsType.IsElectiveType);
}
}
/// <summary>
/// 是否占用资源(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsOccupyResources
{
get
{
return mbolIsOccupyResources;
}
set
{
 mbolIsOccupyResources = value;
//记录修改过的字段
 AddUpdatedFld(conKcCrsType.IsOccupyResources);
}
}
/// <summary>
/// 是否区分学位(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDistinguishDegree
{
get
{
return mbolIsDistinguishDegree;
}
set
{
 mbolIsDistinguishDegree = value;
//记录修改过的字段
 AddUpdatedFld(conKcCrsType.IsDistinguishDegree);
}
}
/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyUserId
{
get
{
return mstrModifyUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyUserId = value;
}
else
{
 mstrModifyUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conKcCrsType.ModifyUserId);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyDate
{
get
{
return mstrModifyDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyDate = value;
}
else
{
 mstrModifyDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conKcCrsType.ModifyDate);
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
  return mstrIdCourseType;
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
  return mstrCourseTypeName;
 }
 }
}
 /// <summary>
 /// 课程类型(KcCrsType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conKcCrsType
{
public const string _CurrTabName = "KcCrsType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCourseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCourseType", "CourseTypeId", "CourseTypeName", "IsMinor", "ReqOrElect", "PointEnabled", "IdCrsTypeAdminType", "IsCrtlScorePropor", "IsCrtlEduclsMember", "IsElectiveType", "IsOccupyResources", "IsDistinguishDegree", "ModifyUserId", "ModifyDate"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdCourseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCourseType = "IdCourseType";    //课程类型流水号

 /// <summary>
 /// 常量:"CourseTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseTypeId = "CourseTypeId";    //课程类型ID

 /// <summary>
 /// 常量:"CourseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseTypeName = "CourseTypeName";    //课程类型名称

 /// <summary>
 /// 常量:"IsMinor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsMinor = "IsMinor";    //是否副修

 /// <summary>
 /// 常量:"ReqOrElect"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReqOrElect = "ReqOrElect";    //是否必修

 /// <summary>
 /// 常量:"PointEnabled"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PointEnabled = "PointEnabled";    //是否计学分

 /// <summary>
 /// 常量:"IdCrsTypeAdminType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCrsTypeAdminType = "IdCrsTypeAdminType";    //课程类型管理类型流水号

 /// <summary>
 /// 常量:"IsCrtlScorePropor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCrtlScorePropor = "IsCrtlScorePropor";    //是否控制成绩比例

 /// <summary>
 /// 常量:"IsCrtlEduclsMember"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCrtlEduclsMember = "IsCrtlEduclsMember";    //是否控制教学班人数

 /// <summary>
 /// 常量:"IsElectiveType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsElectiveType = "IsElectiveType";    //是否可选类型

 /// <summary>
 /// 常量:"IsOccupyResources"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsOccupyResources = "IsOccupyResources";    //是否占用资源

 /// <summary>
 /// 常量:"IsDistinguishDegree"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDistinguishDegree = "IsDistinguishDegree";    //是否区分学位

 /// <summary>
 /// 常量:"ModifyUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyUserId = "ModifyUserId";    //修改人

 /// <summary>
 /// 常量:"ModifyDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyDate = "ModifyDate";    //修改日期
}

}