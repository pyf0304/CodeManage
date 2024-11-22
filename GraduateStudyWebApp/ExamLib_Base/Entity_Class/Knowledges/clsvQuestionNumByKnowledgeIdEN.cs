
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionNumByKnowledgeIdEN
 表名:vQuestionNumByKnowledgeId(01120937)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:06:38
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// 表vQuestionNumByKnowledgeId的关键字(CourseKnowledgeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CourseKnowledgeId_vQuestionNumByKnowledgeId
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCourseKnowledgeId">表关键字</param>
public K_CourseKnowledgeId_vQuestionNumByKnowledgeId(string strCourseKnowledgeId)
{
if (IsValid(strCourseKnowledgeId)) Value = strCourseKnowledgeId;
else
{
Value = null;
}
}
private static bool IsValid(string strCourseKnowledgeId)
{
if (string.IsNullOrEmpty(strCourseKnowledgeId) == true) return false;
if (strCourseKnowledgeId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CourseKnowledgeId_vQuestionNumByKnowledgeId]类型的对象</returns>
public static implicit operator K_CourseKnowledgeId_vQuestionNumByKnowledgeId(string value)
{
return new K_CourseKnowledgeId_vQuestionNumByKnowledgeId(value);
}
}
 /// <summary>
 /// vQuestionNumByKnowledgeId(vQuestionNumByKnowledgeId)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQuestionNumByKnowledgeIdEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQuestionNumByKnowledgeId"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CourseKnowledgeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"CourseKnowledgeId", "CourseId", "QuestionNum"};

protected string mstrCourseKnowledgeId;    //知识点Id
protected string mstrCourseId;    //课程Id
protected int? mintQuestionNum;    //题目数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQuestionNumByKnowledgeIdEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CourseKnowledgeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strCourseKnowledgeId">关键字:知识点Id</param>
public clsvQuestionNumByKnowledgeIdEN(string strCourseKnowledgeId)
 {
strCourseKnowledgeId = strCourseKnowledgeId.Replace("'", "''");
if (strCourseKnowledgeId.Length > 8)
{
throw new Exception("在表:vQuestionNumByKnowledgeId中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCourseKnowledgeId)  ==  true)
{
throw new Exception("在表:vQuestionNumByKnowledgeId中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCourseKnowledgeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCourseKnowledgeId = strCourseKnowledgeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CourseKnowledgeId");
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
if (strAttributeName  ==  convQuestionNumByKnowledgeId.CourseKnowledgeId)
{
return mstrCourseKnowledgeId;
}
else if (strAttributeName  ==  convQuestionNumByKnowledgeId.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convQuestionNumByKnowledgeId.QuestionNum)
{
return mintQuestionNum;
}
return null;
}
set
{
if (strAttributeName  ==  convQuestionNumByKnowledgeId.CourseKnowledgeId)
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(convQuestionNumByKnowledgeId.CourseKnowledgeId);
}
else if (strAttributeName  ==  convQuestionNumByKnowledgeId.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convQuestionNumByKnowledgeId.CourseId);
}
else if (strAttributeName  ==  convQuestionNumByKnowledgeId.QuestionNum)
{
mintQuestionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionNumByKnowledgeId.QuestionNum);
}
}
}
public object this[int intIndex]
{
get
{
if (convQuestionNumByKnowledgeId.CourseKnowledgeId  ==  AttributeName[intIndex])
{
return mstrCourseKnowledgeId;
}
else if (convQuestionNumByKnowledgeId.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convQuestionNumByKnowledgeId.QuestionNum  ==  AttributeName[intIndex])
{
return mintQuestionNum;
}
return null;
}
set
{
if (convQuestionNumByKnowledgeId.CourseKnowledgeId  ==  AttributeName[intIndex])
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(convQuestionNumByKnowledgeId.CourseKnowledgeId);
}
else if (convQuestionNumByKnowledgeId.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convQuestionNumByKnowledgeId.CourseId);
}
else if (convQuestionNumByKnowledgeId.QuestionNum  ==  AttributeName[intIndex])
{
mintQuestionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionNumByKnowledgeId.QuestionNum);
}
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
 AddUpdatedFld(convQuestionNumByKnowledgeId.CourseKnowledgeId);
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
 AddUpdatedFld(convQuestionNumByKnowledgeId.CourseId);
}
}
/// <summary>
/// 题目数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? QuestionNum
{
get
{
return mintQuestionNum;
}
set
{
 mintQuestionNum = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionNumByKnowledgeId.QuestionNum);
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
  return mstrCourseKnowledgeId;
 }
 }
}
 /// <summary>
 /// vQuestionNumByKnowledgeId(vQuestionNumByKnowledgeId)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQuestionNumByKnowledgeId
{
public const string _CurrTabName = "vQuestionNumByKnowledgeId"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CourseKnowledgeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"CourseKnowledgeId", "CourseId", "QuestionNum"};
//以下是属性变量


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
 /// 常量:"QuestionNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionNum = "QuestionNum";    //题目数
}

}