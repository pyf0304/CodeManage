
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaireTtlByTypeEN
 表名:vQuestionnaireTtlByType(01120214)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:07
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护(QuestionaireEdit)
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
 /// 表vQuestionnaireTtlByType的关键字(QuestionTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_QuestionTypeId_vQuestionnaireTtlByType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strQuestionTypeId">表关键字</param>
public K_QuestionTypeId_vQuestionnaireTtlByType(string strQuestionTypeId)
{
if (IsValid(strQuestionTypeId)) Value = strQuestionTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strQuestionTypeId)
{
if (string.IsNullOrEmpty(strQuestionTypeId) == true) return false;
if (strQuestionTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_QuestionTypeId_vQuestionnaireTtlByType]类型的对象</returns>
public static implicit operator K_QuestionTypeId_vQuestionnaireTtlByType(string value)
{
return new K_QuestionTypeId_vQuestionnaireTtlByType(value);
}
}
 /// <summary>
 /// vQuestionnaireTtlByType(vQuestionnaireTtlByType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQuestionnaireTtlByTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQuestionnaireTtlByType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "QuestionTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"QuestionTypeId", "QuestionTypeName", "CourseId", "QuestionNum", "OrderNum"};

protected string mstrQuestionTypeId;    //题目类型Id
protected string mstrQuestionTypeName;    //题目类型名
protected string mstrCourseId;    //课程Id
protected int? mintQuestionNum;    //题目数
protected int? mintOrderNum;    //序号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQuestionnaireTtlByTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QuestionTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strQuestionTypeId">关键字:题目类型Id</param>
public clsvQuestionnaireTtlByTypeEN(string strQuestionTypeId)
 {
strQuestionTypeId = strQuestionTypeId.Replace("'", "''");
if (strQuestionTypeId.Length > 2)
{
throw new Exception("在表:vQuestionnaireTtlByType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strQuestionTypeId)  ==  true)
{
throw new Exception("在表:vQuestionnaireTtlByType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strQuestionTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrQuestionTypeId = strQuestionTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QuestionTypeId");
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
if (strAttributeName  ==  convQuestionnaireTtlByType.QuestionTypeId)
{
return mstrQuestionTypeId;
}
else if (strAttributeName  ==  convQuestionnaireTtlByType.QuestionTypeName)
{
return mstrQuestionTypeName;
}
else if (strAttributeName  ==  convQuestionnaireTtlByType.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convQuestionnaireTtlByType.QuestionNum)
{
return mintQuestionNum;
}
else if (strAttributeName  ==  convQuestionnaireTtlByType.OrderNum)
{
return mintOrderNum;
}
return null;
}
set
{
if (strAttributeName  ==  convQuestionnaireTtlByType.QuestionTypeId)
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convQuestionnaireTtlByType.QuestionTypeId);
}
else if (strAttributeName  ==  convQuestionnaireTtlByType.QuestionTypeName)
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convQuestionnaireTtlByType.QuestionTypeName);
}
else if (strAttributeName  ==  convQuestionnaireTtlByType.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convQuestionnaireTtlByType.CourseId);
}
else if (strAttributeName  ==  convQuestionnaireTtlByType.QuestionNum)
{
mintQuestionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaireTtlByType.QuestionNum);
}
else if (strAttributeName  ==  convQuestionnaireTtlByType.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaireTtlByType.OrderNum);
}
}
}
public object this[int intIndex]
{
get
{
if (convQuestionnaireTtlByType.QuestionTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId;
}
else if (convQuestionnaireTtlByType.QuestionTypeName  ==  AttributeName[intIndex])
{
return mstrQuestionTypeName;
}
else if (convQuestionnaireTtlByType.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convQuestionnaireTtlByType.QuestionNum  ==  AttributeName[intIndex])
{
return mintQuestionNum;
}
else if (convQuestionnaireTtlByType.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
return null;
}
set
{
if (convQuestionnaireTtlByType.QuestionTypeId  ==  AttributeName[intIndex])
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convQuestionnaireTtlByType.QuestionTypeId);
}
else if (convQuestionnaireTtlByType.QuestionTypeName  ==  AttributeName[intIndex])
{
mstrQuestionTypeName = value.ToString();
 AddUpdatedFld(convQuestionnaireTtlByType.QuestionTypeName);
}
else if (convQuestionnaireTtlByType.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convQuestionnaireTtlByType.CourseId);
}
else if (convQuestionnaireTtlByType.QuestionNum  ==  AttributeName[intIndex])
{
mintQuestionNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaireTtlByType.QuestionNum);
}
else if (convQuestionnaireTtlByType.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaireTtlByType.OrderNum);
}
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
 AddUpdatedFld(convQuestionnaireTtlByType.QuestionTypeId);
}
}
/// <summary>
/// 题目类型名(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionTypeName
{
get
{
return mstrQuestionTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionTypeName = value;
}
else
{
 mstrQuestionTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaireTtlByType.QuestionTypeName);
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
 AddUpdatedFld(convQuestionnaireTtlByType.CourseId);
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
 AddUpdatedFld(convQuestionnaireTtlByType.QuestionNum);
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
 AddUpdatedFld(convQuestionnaireTtlByType.OrderNum);
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
  return mstrQuestionTypeId;
 }
 }
}
 /// <summary>
 /// vQuestionnaireTtlByType(vQuestionnaireTtlByType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQuestionnaireTtlByType
{
public const string _CurrTabName = "vQuestionnaireTtlByType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "QuestionTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"QuestionTypeId", "QuestionTypeName", "CourseId", "QuestionNum", "OrderNum"};
//以下是属性变量


 /// <summary>
 /// 常量:"QuestionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeId = "QuestionTypeId";    //题目类型Id

 /// <summary>
 /// 常量:"QuestionTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeName = "QuestionTypeName";    //题目类型名

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

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号
}

}