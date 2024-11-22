
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsJxTeachPlanKnowledgeEN
 表名:JxTeachPlanKnowledge(01120971)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:02:13
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:教学执行计划管理(TeachingPlan)
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
 /// 表JxTeachPlanKnowledge的关键字(IdTeachPlanKnowledge)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdTeachPlanKnowledge_JxTeachPlanKnowledge
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdTeachPlanKnowledge">表关键字</param>
public K_IdTeachPlanKnowledge_JxTeachPlanKnowledge(string strIdTeachPlanKnowledge)
{
if (IsValid(strIdTeachPlanKnowledge)) Value = strIdTeachPlanKnowledge;
else
{
Value = null;
}
}
private static bool IsValid(string strIdTeachPlanKnowledge)
{
if (string.IsNullOrEmpty(strIdTeachPlanKnowledge) == true) return false;
if (strIdTeachPlanKnowledge.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdTeachPlanKnowledge_JxTeachPlanKnowledge]类型的对象</returns>
public static implicit operator K_IdTeachPlanKnowledge_JxTeachPlanKnowledge(string value)
{
return new K_IdTeachPlanKnowledge_JxTeachPlanKnowledge(value);
}
}
 /// <summary>
 /// 教学计划知识点(JxTeachPlanKnowledge)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsJxTeachPlanKnowledgeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "JxTeachPlanKnowledge"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdTeachPlanKnowledge"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"IdTeachPlanKnowledge", "IdTeachingPlan", "CourseKnowledgeId", "CourseId", "TeachingMethodId", "AssessmentMethodId", "UpdDate", "UpdUser", "Memo"};

protected string mstrIdTeachPlanKnowledge;    //教学计划知识点流水号
protected string mstrIdTeachingPlan;    //教案流水号
protected string mstrCourseKnowledgeId;    //知识点Id
protected string mstrCourseId;    //课程Id
protected string mstrTeachingMethodId;    //教学方式Id
protected string mstrAssessmentMethodId;    //考核方式Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsJxTeachPlanKnowledgeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdTeachPlanKnowledge");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdTeachPlanKnowledge">关键字:教学计划知识点流水号</param>
public clsJxTeachPlanKnowledgeEN(string strIdTeachPlanKnowledge)
 {
strIdTeachPlanKnowledge = strIdTeachPlanKnowledge.Replace("'", "''");
if (strIdTeachPlanKnowledge.Length > 8)
{
throw new Exception("在表:JxTeachPlanKnowledge中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdTeachPlanKnowledge)  ==  true)
{
throw new Exception("在表:JxTeachPlanKnowledge中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdTeachPlanKnowledge);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdTeachPlanKnowledge = strIdTeachPlanKnowledge;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdTeachPlanKnowledge");
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
if (strAttributeName  ==  conJxTeachPlanKnowledge.IdTeachPlanKnowledge)
{
return mstrIdTeachPlanKnowledge;
}
else if (strAttributeName  ==  conJxTeachPlanKnowledge.IdTeachingPlan)
{
return mstrIdTeachingPlan;
}
else if (strAttributeName  ==  conJxTeachPlanKnowledge.CourseKnowledgeId)
{
return mstrCourseKnowledgeId;
}
else if (strAttributeName  ==  conJxTeachPlanKnowledge.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  conJxTeachPlanKnowledge.TeachingMethodId)
{
return mstrTeachingMethodId;
}
else if (strAttributeName  ==  conJxTeachPlanKnowledge.AssessmentMethodId)
{
return mstrAssessmentMethodId;
}
else if (strAttributeName  ==  conJxTeachPlanKnowledge.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conJxTeachPlanKnowledge.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conJxTeachPlanKnowledge.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conJxTeachPlanKnowledge.IdTeachPlanKnowledge)
{
mstrIdTeachPlanKnowledge = value.ToString();
 AddUpdatedFld(conJxTeachPlanKnowledge.IdTeachPlanKnowledge);
}
else if (strAttributeName  ==  conJxTeachPlanKnowledge.IdTeachingPlan)
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(conJxTeachPlanKnowledge.IdTeachingPlan);
}
else if (strAttributeName  ==  conJxTeachPlanKnowledge.CourseKnowledgeId)
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(conJxTeachPlanKnowledge.CourseKnowledgeId);
}
else if (strAttributeName  ==  conJxTeachPlanKnowledge.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conJxTeachPlanKnowledge.CourseId);
}
else if (strAttributeName  ==  conJxTeachPlanKnowledge.TeachingMethodId)
{
mstrTeachingMethodId = value.ToString();
 AddUpdatedFld(conJxTeachPlanKnowledge.TeachingMethodId);
}
else if (strAttributeName  ==  conJxTeachPlanKnowledge.AssessmentMethodId)
{
mstrAssessmentMethodId = value.ToString();
 AddUpdatedFld(conJxTeachPlanKnowledge.AssessmentMethodId);
}
else if (strAttributeName  ==  conJxTeachPlanKnowledge.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conJxTeachPlanKnowledge.UpdDate);
}
else if (strAttributeName  ==  conJxTeachPlanKnowledge.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conJxTeachPlanKnowledge.UpdUser);
}
else if (strAttributeName  ==  conJxTeachPlanKnowledge.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conJxTeachPlanKnowledge.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conJxTeachPlanKnowledge.IdTeachPlanKnowledge  ==  AttributeName[intIndex])
{
return mstrIdTeachPlanKnowledge;
}
else if (conJxTeachPlanKnowledge.IdTeachingPlan  ==  AttributeName[intIndex])
{
return mstrIdTeachingPlan;
}
else if (conJxTeachPlanKnowledge.CourseKnowledgeId  ==  AttributeName[intIndex])
{
return mstrCourseKnowledgeId;
}
else if (conJxTeachPlanKnowledge.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (conJxTeachPlanKnowledge.TeachingMethodId  ==  AttributeName[intIndex])
{
return mstrTeachingMethodId;
}
else if (conJxTeachPlanKnowledge.AssessmentMethodId  ==  AttributeName[intIndex])
{
return mstrAssessmentMethodId;
}
else if (conJxTeachPlanKnowledge.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conJxTeachPlanKnowledge.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conJxTeachPlanKnowledge.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conJxTeachPlanKnowledge.IdTeachPlanKnowledge  ==  AttributeName[intIndex])
{
mstrIdTeachPlanKnowledge = value.ToString();
 AddUpdatedFld(conJxTeachPlanKnowledge.IdTeachPlanKnowledge);
}
else if (conJxTeachPlanKnowledge.IdTeachingPlan  ==  AttributeName[intIndex])
{
mstrIdTeachingPlan = value.ToString();
 AddUpdatedFld(conJxTeachPlanKnowledge.IdTeachingPlan);
}
else if (conJxTeachPlanKnowledge.CourseKnowledgeId  ==  AttributeName[intIndex])
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(conJxTeachPlanKnowledge.CourseKnowledgeId);
}
else if (conJxTeachPlanKnowledge.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(conJxTeachPlanKnowledge.CourseId);
}
else if (conJxTeachPlanKnowledge.TeachingMethodId  ==  AttributeName[intIndex])
{
mstrTeachingMethodId = value.ToString();
 AddUpdatedFld(conJxTeachPlanKnowledge.TeachingMethodId);
}
else if (conJxTeachPlanKnowledge.AssessmentMethodId  ==  AttributeName[intIndex])
{
mstrAssessmentMethodId = value.ToString();
 AddUpdatedFld(conJxTeachPlanKnowledge.AssessmentMethodId);
}
else if (conJxTeachPlanKnowledge.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conJxTeachPlanKnowledge.UpdDate);
}
else if (conJxTeachPlanKnowledge.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conJxTeachPlanKnowledge.UpdUser);
}
else if (conJxTeachPlanKnowledge.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conJxTeachPlanKnowledge.Memo);
}
}
}

/// <summary>
/// 教学计划知识点流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdTeachPlanKnowledge
{
get
{
return mstrIdTeachPlanKnowledge;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdTeachPlanKnowledge = value;
}
else
{
 mstrIdTeachPlanKnowledge = value;
}
//记录修改过的字段
 AddUpdatedFld(conJxTeachPlanKnowledge.IdTeachPlanKnowledge);
}
}
/// <summary>
/// 教案流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdTeachingPlan
{
get
{
return mstrIdTeachingPlan;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdTeachingPlan = value;
}
else
{
 mstrIdTeachingPlan = value;
}
//记录修改过的字段
 AddUpdatedFld(conJxTeachPlanKnowledge.IdTeachingPlan);
}
}
/// <summary>
/// 知识点Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseKnowledgeId
{
get
{
return mstrCourseKnowledgeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseKnowledgeId = value;
}
else
{
 mstrCourseKnowledgeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conJxTeachPlanKnowledge.CourseKnowledgeId);
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
 AddUpdatedFld(conJxTeachPlanKnowledge.CourseId);
}
}
/// <summary>
/// 教学方式Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachingMethodId
{
get
{
return mstrTeachingMethodId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachingMethodId = value;
}
else
{
 mstrTeachingMethodId = value;
}
//记录修改过的字段
 AddUpdatedFld(conJxTeachPlanKnowledge.TeachingMethodId);
}
}
/// <summary>
/// 考核方式Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AssessmentMethodId
{
get
{
return mstrAssessmentMethodId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAssessmentMethodId = value;
}
else
{
 mstrAssessmentMethodId = value;
}
//记录修改过的字段
 AddUpdatedFld(conJxTeachPlanKnowledge.AssessmentMethodId);
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
 AddUpdatedFld(conJxTeachPlanKnowledge.UpdDate);
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
 AddUpdatedFld(conJxTeachPlanKnowledge.UpdUser);
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
 AddUpdatedFld(conJxTeachPlanKnowledge.Memo);
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
  return mstrIdTeachPlanKnowledge;
 }
 }
}
 /// <summary>
 /// 教学计划知识点(JxTeachPlanKnowledge)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conJxTeachPlanKnowledge
{
public const string _CurrTabName = "JxTeachPlanKnowledge"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdTeachPlanKnowledge"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdTeachPlanKnowledge", "IdTeachingPlan", "CourseKnowledgeId", "CourseId", "TeachingMethodId", "AssessmentMethodId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdTeachPlanKnowledge"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachPlanKnowledge = "IdTeachPlanKnowledge";    //教学计划知识点流水号

 /// <summary>
 /// 常量:"IdTeachingPlan"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeachingPlan = "IdTeachingPlan";    //教案流水号

 /// <summary>
 /// 常量:"CourseKnowledgeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseKnowledgeId = "CourseKnowledgeId";    //知识点Id

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"TeachingMethodId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachingMethodId = "TeachingMethodId";    //教学方式Id

 /// <summary>
 /// 常量:"AssessmentMethodId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AssessmentMethodId = "AssessmentMethodId";    //考核方式Id

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