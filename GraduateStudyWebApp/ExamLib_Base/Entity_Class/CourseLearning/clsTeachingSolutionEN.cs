
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeachingSolutionEN
 表名:TeachingSolution(01120137)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:10:03
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
 /// 表TeachingSolution的关键字(TeachingSolutionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TeachingSolutionId_TeachingSolution
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTeachingSolutionId">表关键字</param>
public K_TeachingSolutionId_TeachingSolution(string strTeachingSolutionId)
{
if (IsValid(strTeachingSolutionId)) Value = strTeachingSolutionId;
else
{
Value = null;
}
}
private static bool IsValid(string strTeachingSolutionId)
{
if (string.IsNullOrEmpty(strTeachingSolutionId) == true) return false;
if (strTeachingSolutionId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TeachingSolutionId_TeachingSolution]类型的对象</returns>
public static implicit operator K_TeachingSolutionId_TeachingSolution(string value)
{
return new K_TeachingSolutionId_TeachingSolution(value);
}
}
 /// <summary>
 /// 教学方案(TeachingSolution)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTeachingSolutionEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "TeachingSolution"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TeachingSolutionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"TeachingSolutionId", "TeachingSolutionName", "CourseId", "IdTeacher", "BriefIntroduction", "UpdDate", "UpdUser", "Memo"};

protected string mstrTeachingSolutionId;    //教学方案Id
protected string mstrTeachingSolutionName;    //教学方案名称
protected string mstrCourseId;    //课程Id
protected string mstrIdTeacher;    //教师流水号
protected string mstrBriefIntroduction;    //简介
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsTeachingSolutionEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TeachingSolutionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strTeachingSolutionId">关键字:教学方案Id</param>
public clsTeachingSolutionEN(string strTeachingSolutionId)
 {
strTeachingSolutionId = strTeachingSolutionId.Replace("'", "''");
if (strTeachingSolutionId.Length > 8)
{
throw new Exception("在表:TeachingSolution中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTeachingSolutionId)  ==  true)
{
throw new Exception("在表:TeachingSolution中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTeachingSolutionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTeachingSolutionId = strTeachingSolutionId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TeachingSolutionId");
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
if (strAttributeName  ==  conTeachingSolution.TeachingSolutionId)
{
return mstrTeachingSolutionId;
}
else if (strAttributeName  ==  conTeachingSolution.TeachingSolutionName)
{
return mstrTeachingSolutionName;
}
else if (strAttributeName  ==  conTeachingSolution.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conTeachingSolution.IdTeacher)
{
return mstrIdTeacher;
}
else if (strAttributeName  ==  conTeachingSolution.BriefIntroduction)
{
return mstrBriefIntroduction;
}
else if (strAttributeName  ==  conTeachingSolution.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conTeachingSolution.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conTeachingSolution.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conTeachingSolution.TeachingSolutionId)
{
mstrTeachingSolutionId = value.ToString();
 AddUpdatedFld(conTeachingSolution.TeachingSolutionId);
}
else if (strAttributeName  ==  conTeachingSolution.TeachingSolutionName)
{
mstrTeachingSolutionName = value.ToString();
 AddUpdatedFld(conTeachingSolution.TeachingSolutionName);
}
else if (strAttributeName  ==  conTeachingSolution.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conTeachingSolution.CourseId);
}
else if (strAttributeName  ==  conTeachingSolution.IdTeacher)
{
mstrIdTeacher = value.ToString();
 AddUpdatedFld(conTeachingSolution.IdTeacher);
}
else if (strAttributeName  ==  conTeachingSolution.BriefIntroduction)
{
mstrBriefIntroduction = value.ToString();
 AddUpdatedFld(conTeachingSolution.BriefIntroduction);
}
else if (strAttributeName  ==  conTeachingSolution.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conTeachingSolution.UpdDate);
}
else if (strAttributeName  ==  conTeachingSolution.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conTeachingSolution.UpdUser);
}
else if (strAttributeName  ==  conTeachingSolution.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTeachingSolution.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTeachingSolution.TeachingSolutionId  ==  AttributeName[intIndex])
{
return mstrTeachingSolutionId;
}
else if (conTeachingSolution.TeachingSolutionName  ==  AttributeName[intIndex])
{
return mstrTeachingSolutionName;
}
else if (conTeachingSolution.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conTeachingSolution.IdTeacher  ==  AttributeName[intIndex])
{
return mstrIdTeacher;
}
else if (conTeachingSolution.BriefIntroduction  ==  AttributeName[intIndex])
{
return mstrBriefIntroduction;
}
else if (conTeachingSolution.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conTeachingSolution.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conTeachingSolution.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conTeachingSolution.TeachingSolutionId  ==  AttributeName[intIndex])
{
mstrTeachingSolutionId = value.ToString();
 AddUpdatedFld(conTeachingSolution.TeachingSolutionId);
}
else if (conTeachingSolution.TeachingSolutionName  ==  AttributeName[intIndex])
{
mstrTeachingSolutionName = value.ToString();
 AddUpdatedFld(conTeachingSolution.TeachingSolutionName);
}
else if (conTeachingSolution.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conTeachingSolution.CourseId);
}
else if (conTeachingSolution.IdTeacher  ==  AttributeName[intIndex])
{
mstrIdTeacher = value.ToString();
 AddUpdatedFld(conTeachingSolution.IdTeacher);
}
else if (conTeachingSolution.BriefIntroduction  ==  AttributeName[intIndex])
{
mstrBriefIntroduction = value.ToString();
 AddUpdatedFld(conTeachingSolution.BriefIntroduction);
}
else if (conTeachingSolution.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conTeachingSolution.UpdDate);
}
else if (conTeachingSolution.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conTeachingSolution.UpdUser);
}
else if (conTeachingSolution.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTeachingSolution.Memo);
}
}
}

/// <summary>
/// 教学方案Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingSolutionId
{
get
{
return mstrTeachingSolutionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingSolutionId = value;
}
else
{
 mstrTeachingSolutionId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachingSolution.TeachingSolutionId);
}
}
/// <summary>
/// 教学方案名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingSolutionName
{
get
{
return mstrTeachingSolutionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingSolutionName = value;
}
else
{
 mstrTeachingSolutionName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachingSolution.TeachingSolutionName);
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
 AddUpdatedFld(conTeachingSolution.CourseId);
}
}
/// <summary>
/// 教师流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdTeacher
{
get
{
return mstrIdTeacher;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdTeacher = value;
}
else
{
 mstrIdTeacher = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachingSolution.IdTeacher);
}
}
/// <summary>
/// 简介(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string BriefIntroduction
{
get
{
return mstrBriefIntroduction;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBriefIntroduction = value;
}
else
{
 mstrBriefIntroduction = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeachingSolution.BriefIntroduction);
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
 AddUpdatedFld(conTeachingSolution.UpdDate);
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
 AddUpdatedFld(conTeachingSolution.UpdUser);
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
 AddUpdatedFld(conTeachingSolution.Memo);
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
  return mstrTeachingSolutionId;
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
  return mstrTeachingSolutionName;
 }
 }
}
 /// <summary>
 /// 教学方案(TeachingSolution)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTeachingSolution
{
public const string _CurrTabName = "TeachingSolution"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TeachingSolutionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TeachingSolutionId", "TeachingSolutionName", "CourseId", "IdTeacher", "BriefIntroduction", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"TeachingSolutionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingSolutionId = "TeachingSolutionId";    //教学方案Id

 /// <summary>
 /// 常量:"TeachingSolutionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingSolutionName = "TeachingSolutionName";    //教学方案名称

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"IdTeacher"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeacher = "IdTeacher";    //教师流水号

 /// <summary>
 /// 常量:"BriefIntroduction"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BriefIntroduction = "BriefIntroduction";    //简介

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