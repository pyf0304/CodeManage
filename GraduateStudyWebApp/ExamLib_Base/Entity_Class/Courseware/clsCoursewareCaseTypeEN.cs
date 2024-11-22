
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCoursewareCaseTypeEN
 表名:CoursewareCaseType(01120489)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:35
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课件(Courseware)
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
 /// 表CoursewareCaseType的关键字(IdCoursewareCaseType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCoursewareCaseType_CoursewareCaseType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdCoursewareCaseType">表关键字</param>
public K_IdCoursewareCaseType_CoursewareCaseType(string strIdCoursewareCaseType)
{
if (IsValid(strIdCoursewareCaseType)) Value = strIdCoursewareCaseType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdCoursewareCaseType)
{
if (string.IsNullOrEmpty(strIdCoursewareCaseType) == true) return false;
if (strIdCoursewareCaseType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdCoursewareCaseType_CoursewareCaseType]类型的对象</returns>
public static implicit operator K_IdCoursewareCaseType_CoursewareCaseType(string value)
{
return new K_IdCoursewareCaseType_CoursewareCaseType(value);
}
}
 /// <summary>
 /// 课件案例类型(CoursewareCaseType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCoursewareCaseTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CoursewareCaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCoursewareCaseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"IdCoursewareCaseType", "CoursewareCaseTypeID", "CoursewareCaseTypeName", "Memo"};

protected string mstrIdCoursewareCaseType;    //课件案例类型流水号
protected string mstrCoursewareCaseTypeID;    //课件案例类型ID
protected string mstrCoursewareCaseTypeName;    //课件案例类型名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsCoursewareCaseTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCoursewareCaseType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdCoursewareCaseType">关键字:课件案例类型流水号</param>
public clsCoursewareCaseTypeEN(string strIdCoursewareCaseType)
 {
strIdCoursewareCaseType = strIdCoursewareCaseType.Replace("'", "''");
if (strIdCoursewareCaseType.Length > 4)
{
throw new Exception("在表:CoursewareCaseType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdCoursewareCaseType)  ==  true)
{
throw new Exception("在表:CoursewareCaseType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCoursewareCaseType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdCoursewareCaseType = strIdCoursewareCaseType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCoursewareCaseType");
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
if (strAttributeName  ==  conCoursewareCaseType.IdCoursewareCaseType)
{
return mstrIdCoursewareCaseType;
}
else if (strAttributeName  ==  conCoursewareCaseType.CoursewareCaseTypeID)
{
return mstrCoursewareCaseTypeID;
}
else if (strAttributeName  ==  conCoursewareCaseType.CoursewareCaseTypeName)
{
return mstrCoursewareCaseTypeName;
}
else if (strAttributeName  ==  conCoursewareCaseType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCoursewareCaseType.IdCoursewareCaseType)
{
mstrIdCoursewareCaseType = value.ToString();
 AddUpdatedFld(conCoursewareCaseType.IdCoursewareCaseType);
}
else if (strAttributeName  ==  conCoursewareCaseType.CoursewareCaseTypeID)
{
mstrCoursewareCaseTypeID = value.ToString();
 AddUpdatedFld(conCoursewareCaseType.CoursewareCaseTypeID);
}
else if (strAttributeName  ==  conCoursewareCaseType.CoursewareCaseTypeName)
{
mstrCoursewareCaseTypeName = value.ToString();
 AddUpdatedFld(conCoursewareCaseType.CoursewareCaseTypeName);
}
else if (strAttributeName  ==  conCoursewareCaseType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCoursewareCaseType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCoursewareCaseType.IdCoursewareCaseType  ==  AttributeName[intIndex])
{
return mstrIdCoursewareCaseType;
}
else if (conCoursewareCaseType.CoursewareCaseTypeID  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseTypeID;
}
else if (conCoursewareCaseType.CoursewareCaseTypeName  ==  AttributeName[intIndex])
{
return mstrCoursewareCaseTypeName;
}
else if (conCoursewareCaseType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCoursewareCaseType.IdCoursewareCaseType  ==  AttributeName[intIndex])
{
mstrIdCoursewareCaseType = value.ToString();
 AddUpdatedFld(conCoursewareCaseType.IdCoursewareCaseType);
}
else if (conCoursewareCaseType.CoursewareCaseTypeID  ==  AttributeName[intIndex])
{
mstrCoursewareCaseTypeID = value.ToString();
 AddUpdatedFld(conCoursewareCaseType.CoursewareCaseTypeID);
}
else if (conCoursewareCaseType.CoursewareCaseTypeName  ==  AttributeName[intIndex])
{
mstrCoursewareCaseTypeName = value.ToString();
 AddUpdatedFld(conCoursewareCaseType.CoursewareCaseTypeName);
}
else if (conCoursewareCaseType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCoursewareCaseType.Memo);
}
}
}

/// <summary>
/// 课件案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCoursewareCaseType
{
get
{
return mstrIdCoursewareCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCoursewareCaseType = value;
}
else
{
 mstrIdCoursewareCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(conCoursewareCaseType.IdCoursewareCaseType);
}
}
/// <summary>
/// 课件案例类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseTypeID
{
get
{
return mstrCoursewareCaseTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseTypeID = value;
}
else
{
 mstrCoursewareCaseTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(conCoursewareCaseType.CoursewareCaseTypeID);
}
}
/// <summary>
/// 课件案例类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareCaseTypeName
{
get
{
return mstrCoursewareCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareCaseTypeName = value;
}
else
{
 mstrCoursewareCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCoursewareCaseType.CoursewareCaseTypeName);
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
 AddUpdatedFld(conCoursewareCaseType.Memo);
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
  return mstrIdCoursewareCaseType;
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
  return mstrCoursewareCaseTypeName;
 }
 }
}
 /// <summary>
 /// 课件案例类型(CoursewareCaseType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCoursewareCaseType
{
public const string _CurrTabName = "CoursewareCaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCoursewareCaseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCoursewareCaseType", "CoursewareCaseTypeID", "CoursewareCaseTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdCoursewareCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCoursewareCaseType = "IdCoursewareCaseType";    //课件案例类型流水号

 /// <summary>
 /// 常量:"CoursewareCaseTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseTypeID = "CoursewareCaseTypeID";    //课件案例类型ID

 /// <summary>
 /// 常量:"CoursewareCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareCaseTypeName = "CoursewareCaseTypeName";    //课件案例类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}