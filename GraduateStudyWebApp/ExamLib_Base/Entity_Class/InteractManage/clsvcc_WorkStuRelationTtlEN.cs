
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkStuRelationTtlEN
 表名:vcc_WorkStuRelationTtl(01120356)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:52:42
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 /// 表vcc_WorkStuRelationTtl的关键字(IdStudentInfo)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdStudentInfo_vcc_WorkStuRelationTtl
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdStudentInfo">表关键字</param>
public K_IdStudentInfo_vcc_WorkStuRelationTtl(string strIdStudentInfo)
{
if (IsValid(strIdStudentInfo)) Value = strIdStudentInfo;
else
{
Value = null;
}
}
private static bool IsValid(string strIdStudentInfo)
{
if (string.IsNullOrEmpty(strIdStudentInfo) == true) return false;
if (strIdStudentInfo.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdStudentInfo_vcc_WorkStuRelationTtl]类型的对象</returns>
public static implicit operator K_IdStudentInfo_vcc_WorkStuRelationTtl(string value)
{
return new K_IdStudentInfo_vcc_WorkStuRelationTtl(value);
}
}
 /// <summary>
 /// vcc_WorkStuRelationTtl(vcc_WorkStuRelationTtl)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvcc_WorkStuRelationTtlEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vcc_WorkStuRelationTtl"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdStudentInfo"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"IdStudentInfo", "IdCurrEduCls", "QuestionTypeId4Course", "QuestionTypeId", "QuestionCount"};

protected string mstrIdStudentInfo;    //学生流水号
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrQuestionTypeId4Course;    //题目类型Id4课程
protected string mstrQuestionTypeId;    //题目类型Id
protected int? mintQuestionCount;    //问题数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvcc_WorkStuRelationTtlEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdStudentInfo");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdStudentInfo">关键字:学生流水号</param>
public clsvcc_WorkStuRelationTtlEN(string strIdStudentInfo)
 {
strIdStudentInfo = strIdStudentInfo.Replace("'", "''");
if (strIdStudentInfo.Length > 8)
{
throw new Exception("在表:vcc_WorkStuRelationTtl中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdStudentInfo)  ==  true)
{
throw new Exception("在表:vcc_WorkStuRelationTtl中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdStudentInfo);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdStudentInfo = strIdStudentInfo;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdStudentInfo");
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
if (strAttributeName  ==  convcc_WorkStuRelationTtl.IdStudentInfo)
{
return mstrIdStudentInfo;
}
else if (strAttributeName  ==  convcc_WorkStuRelationTtl.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convcc_WorkStuRelationTtl.QuestionTypeId4Course)
{
return mstrQuestionTypeId4Course;
}
else if (strAttributeName  ==  convcc_WorkStuRelationTtl.QuestionTypeId)
{
return mstrQuestionTypeId;
}
else if (strAttributeName  ==  convcc_WorkStuRelationTtl.QuestionCount)
{
return mintQuestionCount;
}
return null;
}
set
{
if (strAttributeName  ==  convcc_WorkStuRelationTtl.IdStudentInfo)
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelationTtl.IdStudentInfo);
}
else if (strAttributeName  ==  convcc_WorkStuRelationTtl.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelationTtl.IdCurrEduCls);
}
else if (strAttributeName  ==  convcc_WorkStuRelationTtl.QuestionTypeId4Course)
{
mstrQuestionTypeId4Course = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelationTtl.QuestionTypeId4Course);
}
else if (strAttributeName  ==  convcc_WorkStuRelationTtl.QuestionTypeId)
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelationTtl.QuestionTypeId);
}
else if (strAttributeName  ==  convcc_WorkStuRelationTtl.QuestionCount)
{
mintQuestionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelationTtl.QuestionCount);
}
}
}
public object this[int intIndex]
{
get
{
if (convcc_WorkStuRelationTtl.IdStudentInfo  ==  AttributeName[intIndex])
{
return mstrIdStudentInfo;
}
else if (convcc_WorkStuRelationTtl.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convcc_WorkStuRelationTtl.QuestionTypeId4Course  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId4Course;
}
else if (convcc_WorkStuRelationTtl.QuestionTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId;
}
else if (convcc_WorkStuRelationTtl.QuestionCount  ==  AttributeName[intIndex])
{
return mintQuestionCount;
}
return null;
}
set
{
if (convcc_WorkStuRelationTtl.IdStudentInfo  ==  AttributeName[intIndex])
{
mstrIdStudentInfo = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelationTtl.IdStudentInfo);
}
else if (convcc_WorkStuRelationTtl.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelationTtl.IdCurrEduCls);
}
else if (convcc_WorkStuRelationTtl.QuestionTypeId4Course  ==  AttributeName[intIndex])
{
mstrQuestionTypeId4Course = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelationTtl.QuestionTypeId4Course);
}
else if (convcc_WorkStuRelationTtl.QuestionTypeId  ==  AttributeName[intIndex])
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convcc_WorkStuRelationTtl.QuestionTypeId);
}
else if (convcc_WorkStuRelationTtl.QuestionCount  ==  AttributeName[intIndex])
{
mintQuestionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convcc_WorkStuRelationTtl.QuestionCount);
}
}
}

/// <summary>
/// 学生流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdStudentInfo
{
get
{
return mstrIdStudentInfo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdStudentInfo = value;
}
else
{
 mstrIdStudentInfo = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelationTtl.IdStudentInfo);
}
}
/// <summary>
/// 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCurrEduCls
{
get
{
return mstrIdCurrEduCls;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCurrEduCls = value;
}
else
{
 mstrIdCurrEduCls = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelationTtl.IdCurrEduCls);
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
 AddUpdatedFld(convcc_WorkStuRelationTtl.QuestionTypeId4Course);
}
}
/// <summary>
/// 题目类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionTypeId
{
get
{
return mstrQuestionTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionTypeId = value;
}
else
{
 mstrQuestionTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelationTtl.QuestionTypeId);
}
}
/// <summary>
/// 问题数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? QuestionCount
{
get
{
return mintQuestionCount;
}
set
{
 mintQuestionCount = value;
//记录修改过的字段
 AddUpdatedFld(convcc_WorkStuRelationTtl.QuestionCount);
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
  return mstrIdStudentInfo;
 }
 }
}
 /// <summary>
 /// vcc_WorkStuRelationTtl(vcc_WorkStuRelationTtl)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convcc_WorkStuRelationTtl
{
public const string _CurrTabName = "vcc_WorkStuRelationTtl"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdStudentInfo"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdStudentInfo", "IdCurrEduCls", "QuestionTypeId4Course", "QuestionTypeId", "QuestionCount"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdStudentInfo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStudentInfo = "IdStudentInfo";    //学生流水号

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"QuestionTypeId4Course"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeId4Course = "QuestionTypeId4Course";    //题目类型Id4课程

 /// <summary>
 /// 常量:"QuestionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeId = "QuestionTypeId";    //题目类型Id

 /// <summary>
 /// 常量:"QuestionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionCount = "QuestionCount";    //问题数
}

}