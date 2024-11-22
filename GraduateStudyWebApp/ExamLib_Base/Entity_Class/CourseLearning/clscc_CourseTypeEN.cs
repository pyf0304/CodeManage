
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseTypeEN
 表名:cc_CourseType(01120057)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:01:34
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
 /// 表cc_CourseType的关键字(CourseTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CourseTypeId_cc_CourseType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCourseTypeId">表关键字</param>
public K_CourseTypeId_cc_CourseType(string strCourseTypeId)
{
if (IsValid(strCourseTypeId)) Value = strCourseTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strCourseTypeId)
{
if (string.IsNullOrEmpty(strCourseTypeId) == true) return false;
if (strCourseTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CourseTypeId_cc_CourseType]类型的对象</returns>
public static implicit operator K_CourseTypeId_cc_CourseType(string value)
{
return new K_CourseTypeId_cc_CourseType(value);
}
}
 /// <summary>
 /// 课程类型(cc_CourseType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_CourseTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_CourseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CourseTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"CourseTypeId", "CourseTypeName", "IdSchool", "IsUse", "UpdDate", "UpdUserId", "Memo"};

protected string mstrCourseTypeId;    //课程类型ID
protected string mstrCourseTypeName;    //课程类型名称
protected string mstrIdSchool;    //学校流水号
protected bool mbolIsUse;    //是否使用
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clscc_CourseTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CourseTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strCourseTypeId">关键字:课程类型ID</param>
public clscc_CourseTypeEN(string strCourseTypeId)
 {
strCourseTypeId = strCourseTypeId.Replace("'", "''");
if (strCourseTypeId.Length > 4)
{
throw new Exception("在表:cc_CourseType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCourseTypeId)  ==  true)
{
throw new Exception("在表:cc_CourseType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCourseTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCourseTypeId = strCourseTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CourseTypeId");
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
if (strAttributeName  ==  concc_CourseType.CourseTypeId)
{
return mstrCourseTypeId;
}
else if (strAttributeName  ==  concc_CourseType.CourseTypeName)
{
return mstrCourseTypeName;
}
else if (strAttributeName  ==  concc_CourseType.IdSchool)
{
return mstrIdSchool;
}
else if (strAttributeName  ==  concc_CourseType.IsUse)
{
return mbolIsUse;
}
else if (strAttributeName  ==  concc_CourseType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  concc_CourseType.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  concc_CourseType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concc_CourseType.CourseTypeId)
{
mstrCourseTypeId = value.ToString();
 AddUpdatedFld(concc_CourseType.CourseTypeId);
}
else if (strAttributeName  ==  concc_CourseType.CourseTypeName)
{
mstrCourseTypeName = value.ToString();
 AddUpdatedFld(concc_CourseType.CourseTypeName);
}
else if (strAttributeName  ==  concc_CourseType.IdSchool)
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(concc_CourseType.IdSchool);
}
else if (strAttributeName  ==  concc_CourseType.IsUse)
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseType.IsUse);
}
else if (strAttributeName  ==  concc_CourseType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_CourseType.UpdDate);
}
else if (strAttributeName  ==  concc_CourseType.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_CourseType.UpdUserId);
}
else if (strAttributeName  ==  concc_CourseType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_CourseType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_CourseType.CourseTypeId  ==  AttributeName[intIndex])
{
return mstrCourseTypeId;
}
else if (concc_CourseType.CourseTypeName  ==  AttributeName[intIndex])
{
return mstrCourseTypeName;
}
else if (concc_CourseType.IdSchool  ==  AttributeName[intIndex])
{
return mstrIdSchool;
}
else if (concc_CourseType.IsUse  ==  AttributeName[intIndex])
{
return mbolIsUse;
}
else if (concc_CourseType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (concc_CourseType.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (concc_CourseType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concc_CourseType.CourseTypeId  ==  AttributeName[intIndex])
{
mstrCourseTypeId = value.ToString();
 AddUpdatedFld(concc_CourseType.CourseTypeId);
}
else if (concc_CourseType.CourseTypeName  ==  AttributeName[intIndex])
{
mstrCourseTypeName = value.ToString();
 AddUpdatedFld(concc_CourseType.CourseTypeName);
}
else if (concc_CourseType.IdSchool  ==  AttributeName[intIndex])
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(concc_CourseType.IdSchool);
}
else if (concc_CourseType.IsUse  ==  AttributeName[intIndex])
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseType.IsUse);
}
else if (concc_CourseType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(concc_CourseType.UpdDate);
}
else if (concc_CourseType.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(concc_CourseType.UpdUserId);
}
else if (concc_CourseType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_CourseType.Memo);
}
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
 AddUpdatedFld(concc_CourseType.CourseTypeId);
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
 AddUpdatedFld(concc_CourseType.CourseTypeName);
}
}
/// <summary>
/// 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSchool
{
get
{
return mstrIdSchool;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSchool = value;
}
else
{
 mstrIdSchool = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseType.IdSchool);
}
}
/// <summary>
/// 是否使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsUse
{
get
{
return mbolIsUse;
}
set
{
 mbolIsUse = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseType.IsUse);
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
 AddUpdatedFld(concc_CourseType.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseType.UpdUserId);
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
 AddUpdatedFld(concc_CourseType.Memo);
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
  return mstrCourseTypeId;
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
 /// 课程类型(cc_CourseType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_CourseType
{
public const string _CurrTabName = "cc_CourseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CourseTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"CourseTypeId", "CourseTypeName", "IdSchool", "IsUse", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


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
 /// 常量:"IdSchool"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSchool = "IdSchool";    //学校流水号

 /// <summary>
 /// 常量:"IsUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUse = "IsUse";    //是否使用

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}