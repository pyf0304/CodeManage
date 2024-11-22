
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCoursewareResCaseTypeEN
 表名:CoursewareResCaseType(01120495)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:40
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课件资源库(CoursewareResLib)
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
 /// 表CoursewareResCaseType的关键字(IdCoursewareResCaseType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCoursewareResCaseType_CoursewareResCaseType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdCoursewareResCaseType">表关键字</param>
public K_IdCoursewareResCaseType_CoursewareResCaseType(string strIdCoursewareResCaseType)
{
if (IsValid(strIdCoursewareResCaseType)) Value = strIdCoursewareResCaseType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdCoursewareResCaseType)
{
if (string.IsNullOrEmpty(strIdCoursewareResCaseType) == true) return false;
if (strIdCoursewareResCaseType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdCoursewareResCaseType_CoursewareResCaseType]类型的对象</returns>
public static implicit operator K_IdCoursewareResCaseType_CoursewareResCaseType(string value)
{
return new K_IdCoursewareResCaseType_CoursewareResCaseType(value);
}
}
 /// <summary>
 /// 课件资源案例类型(CoursewareResCaseType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCoursewareResCaseTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CoursewareResCaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCoursewareResCaseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"IdCoursewareResCaseType", "CoursewareResCaseTypeId", "CoursewareResCaseTypeName", "Memo"};

protected string mstrIdCoursewareResCaseType;    //课件资源类型流水号
protected string mstrCoursewareResCaseTypeId;    //课件资源案例类型Id
protected string mstrCoursewareResCaseTypeName;    //课件资源案例类型名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsCoursewareResCaseTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCoursewareResCaseType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdCoursewareResCaseType">关键字:课件资源类型流水号</param>
public clsCoursewareResCaseTypeEN(string strIdCoursewareResCaseType)
 {
strIdCoursewareResCaseType = strIdCoursewareResCaseType.Replace("'", "''");
if (strIdCoursewareResCaseType.Length > 4)
{
throw new Exception("在表:CoursewareResCaseType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdCoursewareResCaseType)  ==  true)
{
throw new Exception("在表:CoursewareResCaseType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCoursewareResCaseType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdCoursewareResCaseType = strIdCoursewareResCaseType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCoursewareResCaseType");
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
if (strAttributeName  ==  conCoursewareResCaseType.IdCoursewareResCaseType)
{
return mstrIdCoursewareResCaseType;
}
else if (strAttributeName  ==  conCoursewareResCaseType.CoursewareResCaseTypeId)
{
return mstrCoursewareResCaseTypeId;
}
else if (strAttributeName  ==  conCoursewareResCaseType.CoursewareResCaseTypeName)
{
return mstrCoursewareResCaseTypeName;
}
else if (strAttributeName  ==  conCoursewareResCaseType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCoursewareResCaseType.IdCoursewareResCaseType)
{
mstrIdCoursewareResCaseType = value.ToString();
 AddUpdatedFld(conCoursewareResCaseType.IdCoursewareResCaseType);
}
else if (strAttributeName  ==  conCoursewareResCaseType.CoursewareResCaseTypeId)
{
mstrCoursewareResCaseTypeId = value.ToString();
 AddUpdatedFld(conCoursewareResCaseType.CoursewareResCaseTypeId);
}
else if (strAttributeName  ==  conCoursewareResCaseType.CoursewareResCaseTypeName)
{
mstrCoursewareResCaseTypeName = value.ToString();
 AddUpdatedFld(conCoursewareResCaseType.CoursewareResCaseTypeName);
}
else if (strAttributeName  ==  conCoursewareResCaseType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCoursewareResCaseType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCoursewareResCaseType.IdCoursewareResCaseType  ==  AttributeName[intIndex])
{
return mstrIdCoursewareResCaseType;
}
else if (conCoursewareResCaseType.CoursewareResCaseTypeId  ==  AttributeName[intIndex])
{
return mstrCoursewareResCaseTypeId;
}
else if (conCoursewareResCaseType.CoursewareResCaseTypeName  ==  AttributeName[intIndex])
{
return mstrCoursewareResCaseTypeName;
}
else if (conCoursewareResCaseType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCoursewareResCaseType.IdCoursewareResCaseType  ==  AttributeName[intIndex])
{
mstrIdCoursewareResCaseType = value.ToString();
 AddUpdatedFld(conCoursewareResCaseType.IdCoursewareResCaseType);
}
else if (conCoursewareResCaseType.CoursewareResCaseTypeId  ==  AttributeName[intIndex])
{
mstrCoursewareResCaseTypeId = value.ToString();
 AddUpdatedFld(conCoursewareResCaseType.CoursewareResCaseTypeId);
}
else if (conCoursewareResCaseType.CoursewareResCaseTypeName  ==  AttributeName[intIndex])
{
mstrCoursewareResCaseTypeName = value.ToString();
 AddUpdatedFld(conCoursewareResCaseType.CoursewareResCaseTypeName);
}
else if (conCoursewareResCaseType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCoursewareResCaseType.Memo);
}
}
}

/// <summary>
/// 课件资源类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCoursewareResCaseType
{
get
{
return mstrIdCoursewareResCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCoursewareResCaseType = value;
}
else
{
 mstrIdCoursewareResCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(conCoursewareResCaseType.IdCoursewareResCaseType);
}
}
/// <summary>
/// 课件资源案例类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareResCaseTypeId
{
get
{
return mstrCoursewareResCaseTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareResCaseTypeId = value;
}
else
{
 mstrCoursewareResCaseTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCoursewareResCaseType.CoursewareResCaseTypeId);
}
}
/// <summary>
/// 课件资源案例类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CoursewareResCaseTypeName
{
get
{
return mstrCoursewareResCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCoursewareResCaseTypeName = value;
}
else
{
 mstrCoursewareResCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCoursewareResCaseType.CoursewareResCaseTypeName);
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
 AddUpdatedFld(conCoursewareResCaseType.Memo);
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
  return mstrIdCoursewareResCaseType;
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
  return mstrCoursewareResCaseTypeName;
 }
 }
}
 /// <summary>
 /// 课件资源案例类型(CoursewareResCaseType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCoursewareResCaseType
{
public const string _CurrTabName = "CoursewareResCaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCoursewareResCaseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCoursewareResCaseType", "CoursewareResCaseTypeId", "CoursewareResCaseTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdCoursewareResCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCoursewareResCaseType = "IdCoursewareResCaseType";    //课件资源类型流水号

 /// <summary>
 /// 常量:"CoursewareResCaseTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareResCaseTypeId = "CoursewareResCaseTypeId";    //课件资源案例类型Id

 /// <summary>
 /// 常量:"CoursewareResCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CoursewareResCaseTypeName = "CoursewareResCaseTypeName";    //课件资源案例类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}