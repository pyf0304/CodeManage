
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionType4CourseEN
 表名:vQuestionType4Course(01120340)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:10
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
 框架-层名:实体层(CS)(EntityLayer)
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

namespace ExamLib.Entity
{
 /// <summary>
 /// 表vQuestionType4Course的关键字(QuestionTypeId4Course)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_QuestionTypeId4Course_vQuestionType4Course
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strQuestionTypeId4Course">表关键字</param>
public K_QuestionTypeId4Course_vQuestionType4Course(string strQuestionTypeId4Course)
{
if (IsValid(strQuestionTypeId4Course)) Value = strQuestionTypeId4Course;
else
{
Value = null;
}
}
private static bool IsValid(string strQuestionTypeId4Course)
{
if (string.IsNullOrEmpty(strQuestionTypeId4Course) == true) return false;
if (strQuestionTypeId4Course.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_QuestionTypeId4Course_vQuestionType4Course]类型的对象</returns>
public static implicit operator K_QuestionTypeId4Course_vQuestionType4Course(string value)
{
return new K_QuestionTypeId4Course_vQuestionType4Course(value);
}
}
 /// <summary>
 /// v题目类型4课程(vQuestionType4Course)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQuestionType4CourseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQuestionType4Course"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "QuestionTypeId4Course"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"QuestionTypeId4Course", "QuestionTypeName4Course", "CourseId", "CourseName", "OrderNum", "IsUse", "UpdDate", "UpdUser", "Memo"};

protected string mstrQuestionTypeId4Course;    //题目类型Id4课程
protected string mstrQuestionTypeName4Course;    //题目类型名4课程
protected string mstrCourseId;    //课程Id
protected string mstrCourseName;    //课程名称
protected int? mintOrderNum;    //序号
protected bool mbolIsUse;    //是否使用
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQuestionType4CourseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QuestionTypeId4Course");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strQuestionTypeId4Course">关键字:题目类型Id4课程</param>
public clsvQuestionType4CourseEN(string strQuestionTypeId4Course)
 {
strQuestionTypeId4Course = strQuestionTypeId4Course.Replace("'", "''");
if (strQuestionTypeId4Course.Length > 8)
{
throw new Exception("在表:vQuestionType4Course中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strQuestionTypeId4Course)  ==  true)
{
throw new Exception("在表:vQuestionType4Course中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strQuestionTypeId4Course);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrQuestionTypeId4Course = strQuestionTypeId4Course;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QuestionTypeId4Course");
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
if (strAttributeName  ==  convQuestionType4Course.QuestionTypeId4Course)
{
return mstrQuestionTypeId4Course;
}
else if (strAttributeName  ==  convQuestionType4Course.QuestionTypeName4Course)
{
return mstrQuestionTypeName4Course;
}
else if (strAttributeName  ==  convQuestionType4Course.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convQuestionType4Course.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convQuestionType4Course.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convQuestionType4Course.IsUse)
{
return mbolIsUse;
}
else if (strAttributeName  ==  convQuestionType4Course.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convQuestionType4Course.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convQuestionType4Course.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convQuestionType4Course.QuestionTypeId4Course)
{
mstrQuestionTypeId4Course = value.ToString();
 AddUpdatedFld(convQuestionType4Course.QuestionTypeId4Course);
}
else if (strAttributeName  ==  convQuestionType4Course.QuestionTypeName4Course)
{
mstrQuestionTypeName4Course = value.ToString();
 AddUpdatedFld(convQuestionType4Course.QuestionTypeName4Course);
}
else if (strAttributeName  ==  convQuestionType4Course.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convQuestionType4Course.CourseId);
}
else if (strAttributeName  ==  convQuestionType4Course.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convQuestionType4Course.CourseName);
}
else if (strAttributeName  ==  convQuestionType4Course.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionType4Course.OrderNum);
}
else if (strAttributeName  ==  convQuestionType4Course.IsUse)
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionType4Course.IsUse);
}
else if (strAttributeName  ==  convQuestionType4Course.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQuestionType4Course.UpdDate);
}
else if (strAttributeName  ==  convQuestionType4Course.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convQuestionType4Course.UpdUser);
}
else if (strAttributeName  ==  convQuestionType4Course.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQuestionType4Course.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convQuestionType4Course.QuestionTypeId4Course  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId4Course;
}
else if (convQuestionType4Course.QuestionTypeName4Course  ==  AttributeName[intIndex])
{
return mstrQuestionTypeName4Course;
}
else if (convQuestionType4Course.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convQuestionType4Course.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convQuestionType4Course.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convQuestionType4Course.IsUse  ==  AttributeName[intIndex])
{
return mbolIsUse;
}
else if (convQuestionType4Course.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convQuestionType4Course.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convQuestionType4Course.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convQuestionType4Course.QuestionTypeId4Course  ==  AttributeName[intIndex])
{
mstrQuestionTypeId4Course = value.ToString();
 AddUpdatedFld(convQuestionType4Course.QuestionTypeId4Course);
}
else if (convQuestionType4Course.QuestionTypeName4Course  ==  AttributeName[intIndex])
{
mstrQuestionTypeName4Course = value.ToString();
 AddUpdatedFld(convQuestionType4Course.QuestionTypeName4Course);
}
else if (convQuestionType4Course.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convQuestionType4Course.CourseId);
}
else if (convQuestionType4Course.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convQuestionType4Course.CourseName);
}
else if (convQuestionType4Course.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionType4Course.OrderNum);
}
else if (convQuestionType4Course.IsUse  ==  AttributeName[intIndex])
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionType4Course.IsUse);
}
else if (convQuestionType4Course.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQuestionType4Course.UpdDate);
}
else if (convQuestionType4Course.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convQuestionType4Course.UpdUser);
}
else if (convQuestionType4Course.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQuestionType4Course.Memo);
}
}
}

/// <summary>
/// 题目类型Id4课程(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionTypeId4Course
{
get
{
return mstrQuestionTypeId4Course;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionTypeId4Course = value;
}
else
{
 mstrQuestionTypeId4Course = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionType4Course.QuestionTypeId4Course);
}
}
/// <summary>
/// 题目类型名4课程(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionTypeName4Course
{
get
{
return mstrQuestionTypeName4Course;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionTypeName4Course = value;
}
else
{
 mstrQuestionTypeName4Course = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionType4Course.QuestionTypeName4Course);
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
 AddUpdatedFld(convQuestionType4Course.CourseId);
}
}
/// <summary>
/// 课程名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseName
{
get
{
return mstrCourseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseName = value;
}
else
{
 mstrCourseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionType4Course.CourseName);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionType4Course.OrderNum);
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
 AddUpdatedFld(convQuestionType4Course.IsUse);
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
 AddUpdatedFld(convQuestionType4Course.UpdDate);
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
 AddUpdatedFld(convQuestionType4Course.UpdUser);
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
 AddUpdatedFld(convQuestionType4Course.Memo);
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
  return mstrQuestionTypeId4Course;
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
  return mstrQuestionTypeName4Course;
 }
 }
}
 /// <summary>
 /// v题目类型4课程(vQuestionType4Course)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQuestionType4Course
{
public const string _CurrTabName = "vQuestionType4Course"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "QuestionTypeId4Course"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"QuestionTypeId4Course", "QuestionTypeName4Course", "CourseId", "CourseName", "OrderNum", "IsUse", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"QuestionTypeId4Course"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeId4Course = "QuestionTypeId4Course";    //题目类型Id4课程

 /// <summary>
 /// 常量:"QuestionTypeName4Course"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeName4Course = "QuestionTypeName4Course";    //题目类型名4课程

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"CourseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseName = "CourseName";    //课程名称

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

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