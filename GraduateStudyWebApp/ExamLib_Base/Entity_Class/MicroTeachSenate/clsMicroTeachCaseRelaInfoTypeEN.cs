
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMicroTeachCaseRelaInfoTypeEN
 表名:MicroTeachCaseRelaInfoType(01120317)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:19:30
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
 /// 表MicroTeachCaseRelaInfoType的关键字(IdMicroTeachCaseRelaInfoType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdMicroTeachCaseRelaInfoType_MicroTeachCaseRelaInfoType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdMicroTeachCaseRelaInfoType">表关键字</param>
public K_IdMicroTeachCaseRelaInfoType_MicroTeachCaseRelaInfoType(string strIdMicroTeachCaseRelaInfoType)
{
if (IsValid(strIdMicroTeachCaseRelaInfoType)) Value = strIdMicroTeachCaseRelaInfoType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdMicroTeachCaseRelaInfoType)
{
if (string.IsNullOrEmpty(strIdMicroTeachCaseRelaInfoType) == true) return false;
if (strIdMicroTeachCaseRelaInfoType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdMicroTeachCaseRelaInfoType_MicroTeachCaseRelaInfoType]类型的对象</returns>
public static implicit operator K_IdMicroTeachCaseRelaInfoType_MicroTeachCaseRelaInfoType(string value)
{
return new K_IdMicroTeachCaseRelaInfoType_MicroTeachCaseRelaInfoType(value);
}
}
 /// <summary>
 /// 微格案例相关信息类型(MicroTeachCaseRelaInfoType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsMicroTeachCaseRelaInfoTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "MicroTeachCaseRelaInfoType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdMicroTeachCaseRelaInfoType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"IdMicroTeachCaseRelaInfoType", "MicroTeachCaseRelaInfoTypeID", "MicroTeachCaseRelaInfoTypeName", "MicroTeachCaseRelaInfoTypeENName", "CoursewareCaseRelaInfoTypeName"};

protected string mstrIdMicroTeachCaseRelaInfoType;    //微格案例相关信息类型流水号
protected string mstrMicroTeachCaseRelaInfoTypeID;    //微格案例相关信息类型ID
protected string mstrMicroTeachCaseRelaInfoTypeName;    //微格案例相关信息类型名称
protected string mstrMicroTeachCaseRelaInfoTypeENName;    //案例相关信息类型英文名
protected string mstrCoursewareCaseRelaInfoTypeName;    //课件相关信息类型名称

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsMicroTeachCaseRelaInfoTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMicroTeachCaseRelaInfoType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdMicroTeachCaseRelaInfoType">关键字:微格案例相关信息类型流水号</param>
public clsMicroTeachCaseRelaInfoTypeEN(string strIdMicroTeachCaseRelaInfoType)
 {
strIdMicroTeachCaseRelaInfoType = strIdMicroTeachCaseRelaInfoType.Replace("'", "''");
if (strIdMicroTeachCaseRelaInfoType.Length > 4)
{
throw new Exception("在表:MicroTeachCaseRelaInfoType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdMicroTeachCaseRelaInfoType)  ==  true)
{
throw new Exception("在表:MicroTeachCaseRelaInfoType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdMicroTeachCaseRelaInfoType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdMicroTeachCaseRelaInfoType = strIdMicroTeachCaseRelaInfoType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdMicroTeachCaseRelaInfoType");
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
if (strAttributeName  ==  conMicroTeachCaseRelaInfoType.IdMicroTeachCaseRelaInfoType)
{
return mstrIdMicroTeachCaseRelaInfoType;
}
else if (strAttributeName  ==  conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeID)
{
return mstrMicroTeachCaseRelaInfoTypeID;
}
else if (strAttributeName  ==  conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeName)
{
return mstrMicroTeachCaseRelaInfoTypeName;
}
else if (strAttributeName  ==  conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName)
{
return mstrMicroTeachCaseRelaInfoTypeENName;
}
else if (strAttributeName  ==  conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName)
{
return mstrCoursewareCaseRelaInfoTypeName;
}
return null;
}
set
{
if (strAttributeName  ==  conMicroTeachCaseRelaInfoType.IdMicroTeachCaseRelaInfoType)
{
mstrIdMicroTeachCaseRelaInfoType = value.ToString();
 AddUpdatedFld(conMicroTeachCaseRelaInfoType.IdMicroTeachCaseRelaInfoType);
}
else if (strAttributeName  ==  conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeID)
{
mstrMicroTeachCaseRelaInfoTypeID = value.ToString();
 AddUpdatedFld(conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeID);
}
else if (strAttributeName  ==  conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeName)
{
mstrMicroTeachCaseRelaInfoTypeName = value.ToString();
 AddUpdatedFld(conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeName);
}
else if (strAttributeName  ==  conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName)
{
mstrMicroTeachCaseRelaInfoTypeENName = value.ToString();
 AddUpdatedFld(conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName);
}
else if (strAttributeName  ==  conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName)
{
mstrCoursewareCaseRelaInfoTypeName = value.ToString();
 AddUpdatedFld(conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName);
}
}
}
public object this[int intIndex]
{
get
{
if (conMicroTeachCaseRelaInfoType.IdMicroTeachCaseRelaInfoType  ==  AttributeName[intIndex])
{
return mstrIdMicroTeachCaseRelaInfoType;
}
else if (conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeID  ==  AttributeName[intIndex])
{
return mstrMicroTeachCaseRelaInfoTypeID;
}
else if (conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeName  ==  AttributeName[intIndex])
{
return mstrMicroTeachCaseRelaInfoTypeName;
}
else if (conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName  ==  AttributeName[intIndex])
{
return mstrMicroTeachCaseRelaInfoTypeENName;
}
else if (conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseRelaInfoTypeName;
}
return null;
}
set
{
if (conMicroTeachCaseRelaInfoType.IdMicroTeachCaseRelaInfoType  ==  AttributeName[intIndex])
{
mstrIdMicroTeachCaseRelaInfoType = value.ToString();
 AddUpdatedFld(conMicroTeachCaseRelaInfoType.IdMicroTeachCaseRelaInfoType);
}
else if (conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeID  ==  AttributeName[intIndex])
{
mstrMicroTeachCaseRelaInfoTypeID = value.ToString();
 AddUpdatedFld(conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeID);
}
else if (conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeName  ==  AttributeName[intIndex])
{
mstrMicroTeachCaseRelaInfoTypeName = value.ToString();
 AddUpdatedFld(conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeName);
}
else if (conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName  ==  AttributeName[intIndex])
{
mstrMicroTeachCaseRelaInfoTypeENName = value.ToString();
 AddUpdatedFld(conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName);
}
else if (conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName  ==  AttributeName[intIndex])
{
mstrCoursewareCaseRelaInfoTypeName = value.ToString();
 AddUpdatedFld(conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName);
}
}
}

/// <summary>
/// 微格案例相关信息类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdMicroTeachCaseRelaInfoType
{
get
{
return mstrIdMicroTeachCaseRelaInfoType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdMicroTeachCaseRelaInfoType = value;
}
else
{
 mstrIdMicroTeachCaseRelaInfoType = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroTeachCaseRelaInfoType.IdMicroTeachCaseRelaInfoType);
}
}
/// <summary>
/// 微格案例相关信息类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroTeachCaseRelaInfoTypeID
{
get
{
return mstrMicroTeachCaseRelaInfoTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroTeachCaseRelaInfoTypeID = value;
}
else
{
 mstrMicroTeachCaseRelaInfoTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeID);
}
}
/// <summary>
/// 微格案例相关信息类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroTeachCaseRelaInfoTypeName
{
get
{
return mstrMicroTeachCaseRelaInfoTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroTeachCaseRelaInfoTypeName = value;
}
else
{
 mstrMicroTeachCaseRelaInfoTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeName);
}
}
/// <summary>
/// 案例相关信息类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MicroTeachCaseRelaInfoTypeENName
{
get
{
return mstrMicroTeachCaseRelaInfoTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroTeachCaseRelaInfoTypeENName = value;
}
else
{
 mstrMicroTeachCaseRelaInfoTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroTeachCaseRelaInfoType.MicroTeachCaseRelaInfoTypeENName);
}
}
/// <summary>
/// 课件相关信息类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseRelaInfoTypeName
{
get
{
return mstrCoursewareCaseRelaInfoTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseRelaInfoTypeName = value;
}
else
{
 mstrCoursewareCaseRelaInfoTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conMicroTeachCaseRelaInfoType.CoursewareCaseRelaInfoTypeName);
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
  return mstrIdMicroTeachCaseRelaInfoType;
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
  return mstrMicroTeachCaseRelaInfoTypeName;
 }
 }
}
 /// <summary>
 /// 微格案例相关信息类型(MicroTeachCaseRelaInfoType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conMicroTeachCaseRelaInfoType
{
public const string _CurrTabName = "MicroTeachCaseRelaInfoType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdMicroTeachCaseRelaInfoType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdMicroTeachCaseRelaInfoType", "MicroTeachCaseRelaInfoTypeID", "MicroTeachCaseRelaInfoTypeName", "MicroTeachCaseRelaInfoTypeENName", "CoursewareCaseRelaInfoTypeName"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdMicroTeachCaseRelaInfoType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMicroTeachCaseRelaInfoType = "IdMicroTeachCaseRelaInfoType";    //微格案例相关信息类型流水号

 /// <summary>
 /// 常量:"MicroTeachCaseRelaInfoTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroTeachCaseRelaInfoTypeID = "MicroTeachCaseRelaInfoTypeID";    //微格案例相关信息类型ID

 /// <summary>
 /// 常量:"MicroTeachCaseRelaInfoTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroTeachCaseRelaInfoTypeName = "MicroTeachCaseRelaInfoTypeName";    //微格案例相关信息类型名称

 /// <summary>
 /// 常量:"MicroTeachCaseRelaInfoTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MicroTeachCaseRelaInfoTypeENName = "MicroTeachCaseRelaInfoTypeENName";    //案例相关信息类型英文名

 /// <summary>
 /// 常量:"CoursewareCaseRelaInfoTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseRelaInfoTypeName = "CoursewareCaseRelaInfoTypeName";    //课件相关信息类型名称
}

}