
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCourseLearningCaseTypeEN
 表名:CourseLearningCaseType(01120275)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:19:03
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
 /// 表CourseLearningCaseType的关键字(IdCourseLearningCaseType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCourseLearningCaseType_CourseLearningCaseType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdCourseLearningCaseType">表关键字</param>
public K_IdCourseLearningCaseType_CourseLearningCaseType(string strIdCourseLearningCaseType)
{
if (IsValid(strIdCourseLearningCaseType)) Value = strIdCourseLearningCaseType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdCourseLearningCaseType)
{
if (string.IsNullOrEmpty(strIdCourseLearningCaseType) == true) return false;
if (strIdCourseLearningCaseType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdCourseLearningCaseType_CourseLearningCaseType]类型的对象</returns>
public static implicit operator K_IdCourseLearningCaseType_CourseLearningCaseType(string value)
{
return new K_IdCourseLearningCaseType_CourseLearningCaseType(value);
}
}
 /// <summary>
 /// 课程学习案例类型(CourseLearningCaseType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCourseLearningCaseTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CourseLearningCaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCourseLearningCaseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"IdCourseLearningCaseType", "CourseLearningCaseTypeId", "CourseLearningCaseTypeName", "Memo"};

protected string mstrIdCourseLearningCaseType;    //课程学习案例类型流水号
protected string mstrCourseLearningCaseTypeId;    //课程学习案例类型Id
protected string mstrCourseLearningCaseTypeName;    //课程学习案例类型名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsCourseLearningCaseTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCourseLearningCaseType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdCourseLearningCaseType">关键字:课程学习案例类型流水号</param>
public clsCourseLearningCaseTypeEN(string strIdCourseLearningCaseType)
 {
strIdCourseLearningCaseType = strIdCourseLearningCaseType.Replace("'", "''");
if (strIdCourseLearningCaseType.Length > 4)
{
throw new Exception("在表:CourseLearningCaseType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdCourseLearningCaseType)  ==  true)
{
throw new Exception("在表:CourseLearningCaseType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCourseLearningCaseType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdCourseLearningCaseType = strIdCourseLearningCaseType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCourseLearningCaseType");
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
if (strAttributeName  ==  conCourseLearningCaseType.IdCourseLearningCaseType)
{
return mstrIdCourseLearningCaseType;
}
else if (strAttributeName  ==  conCourseLearningCaseType.CourseLearningCaseTypeId)
{
return mstrCourseLearningCaseTypeId;
}
else if (strAttributeName  ==  conCourseLearningCaseType.CourseLearningCaseTypeName)
{
return mstrCourseLearningCaseTypeName;
}
else if (strAttributeName  ==  conCourseLearningCaseType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCourseLearningCaseType.IdCourseLearningCaseType)
{
mstrIdCourseLearningCaseType = value.ToString();
 AddUpdatedFld(conCourseLearningCaseType.IdCourseLearningCaseType);
}
else if (strAttributeName  ==  conCourseLearningCaseType.CourseLearningCaseTypeId)
{
mstrCourseLearningCaseTypeId = value.ToString();
 AddUpdatedFld(conCourseLearningCaseType.CourseLearningCaseTypeId);
}
else if (strAttributeName  ==  conCourseLearningCaseType.CourseLearningCaseTypeName)
{
mstrCourseLearningCaseTypeName = value.ToString();
 AddUpdatedFld(conCourseLearningCaseType.CourseLearningCaseTypeName);
}
else if (strAttributeName  ==  conCourseLearningCaseType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCourseLearningCaseType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCourseLearningCaseType.IdCourseLearningCaseType  ==  AttributeName[intIndex])
{
return mstrIdCourseLearningCaseType;
}
else if (conCourseLearningCaseType.CourseLearningCaseTypeId  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseTypeId;
}
else if (conCourseLearningCaseType.CourseLearningCaseTypeName  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseTypeName;
}
else if (conCourseLearningCaseType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCourseLearningCaseType.IdCourseLearningCaseType  ==  AttributeName[intIndex])
{
mstrIdCourseLearningCaseType = value.ToString();
 AddUpdatedFld(conCourseLearningCaseType.IdCourseLearningCaseType);
}
else if (conCourseLearningCaseType.CourseLearningCaseTypeId  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseTypeId = value.ToString();
 AddUpdatedFld(conCourseLearningCaseType.CourseLearningCaseTypeId);
}
else if (conCourseLearningCaseType.CourseLearningCaseTypeName  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseTypeName = value.ToString();
 AddUpdatedFld(conCourseLearningCaseType.CourseLearningCaseTypeName);
}
else if (conCourseLearningCaseType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCourseLearningCaseType.Memo);
}
}
}

/// <summary>
/// 课程学习案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCourseLearningCaseType
{
get
{
return mstrIdCourseLearningCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCourseLearningCaseType = value;
}
else
{
 mstrIdCourseLearningCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(conCourseLearningCaseType.IdCourseLearningCaseType);
}
}
/// <summary>
/// 课程学习案例类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseLearningCaseTypeId
{
get
{
return mstrCourseLearningCaseTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseLearningCaseTypeId = value;
}
else
{
 mstrCourseLearningCaseTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCourseLearningCaseType.CourseLearningCaseTypeId);
}
}
/// <summary>
/// 课程学习案例类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseLearningCaseTypeName
{
get
{
return mstrCourseLearningCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseLearningCaseTypeName = value;
}
else
{
 mstrCourseLearningCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCourseLearningCaseType.CourseLearningCaseTypeName);
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
 AddUpdatedFld(conCourseLearningCaseType.Memo);
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
  return mstrIdCourseLearningCaseType;
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
  return mstrCourseLearningCaseTypeName;
 }
 }
}
 /// <summary>
 /// 课程学习案例类型(CourseLearningCaseType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCourseLearningCaseType
{
public const string _CurrTabName = "CourseLearningCaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCourseLearningCaseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCourseLearningCaseType", "CourseLearningCaseTypeId", "CourseLearningCaseTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdCourseLearningCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCourseLearningCaseType = "IdCourseLearningCaseType";    //课程学习案例类型流水号

 /// <summary>
 /// 常量:"CourseLearningCaseTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseLearningCaseTypeId = "CourseLearningCaseTypeId";    //课程学习案例类型Id

 /// <summary>
 /// 常量:"CourseLearningCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseLearningCaseTypeName = "CourseLearningCaseTypeName";    //课程学习案例类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}