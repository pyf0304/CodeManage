
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaire_SimEN
 表名:vQuestionnaire_Sim(01120949)
 * 版本:2024.11.10.1(服务器:WIN-SRV103-116)
 日期:2024/11/12 09:24:41
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护(QuestionaireEdit)
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
 /// 表vQuestionnaire_Sim的关键字(QuestionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_QuestionId_vQuestionnaire_Sim
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngQuestionId">表关键字</param>
public K_QuestionId_vQuestionnaire_Sim(long lngQuestionId)
{
if (IsValid(lngQuestionId)) Value = lngQuestionId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngQuestionId)
{
if (lngQuestionId == 0) return false;
if (lngQuestionId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_QuestionId_vQuestionnaire_Sim]类型的对象</returns>
public static implicit operator K_QuestionId_vQuestionnaire_Sim(long value)
{
return new K_QuestionId_vQuestionnaire_Sim(value);
}
}
 /// <summary>
 /// vQuestionnaire_Sim(vQuestionnaire_Sim)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQuestionnaire_SimEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQuestionnaire_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "QuestionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"QuestionId", "QuestionName", "QuestionIndex", "QuestionNo", "CourseId", "CourseChapterId", "ParentQuestionId", "QuestionTypeId", "QuestionTypeId4Course", "AnswerTypeId", "IsShow", "DifficultyLevelId"};

protected long mlngQuestionId;    //题目Id
protected string mstrQuestionName;    //题目名称
protected int? mintQuestionIndex;    //题目序号
protected string mstrQuestionNo;    //题目编号
protected string mstrCourseId;    //课程Id
protected string mstrCourseChapterId;    //课程章节ID
protected string mstrParentQuestionId;    //父题目Id
protected string mstrQuestionTypeId;    //题目类型Id
protected string mstrQuestionTypeId4Course;    //题目类型Id4课程
protected string mstrAnswerTypeId;    //答案类型ID
protected bool mbolIsShow;    //是否启用
protected string mstrDifficultyLevelId;    //难度等级Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQuestionnaire_SimEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QuestionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngQuestionId">关键字:题目Id</param>
public clsvQuestionnaire_SimEN(long lngQuestionId)
 {
 if (lngQuestionId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngQuestionId = lngQuestionId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QuestionId");
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
if (strAttributeName  ==  convQuestionnaire_Sim.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  convQuestionnaire_Sim.QuestionName)
{
return mstrQuestionName;
}
else if (strAttributeName  ==  convQuestionnaire_Sim.QuestionIndex)
{
return mintQuestionIndex;
}
else if (strAttributeName  ==  convQuestionnaire_Sim.QuestionNo)
{
return mstrQuestionNo;
}
else if (strAttributeName  ==  convQuestionnaire_Sim.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convQuestionnaire_Sim.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  convQuestionnaire_Sim.ParentQuestionId)
{
return mstrParentQuestionId;
}
else if (strAttributeName  ==  convQuestionnaire_Sim.QuestionTypeId)
{
return mstrQuestionTypeId;
}
else if (strAttributeName  ==  convQuestionnaire_Sim.QuestionTypeId4Course)
{
return mstrQuestionTypeId4Course;
}
else if (strAttributeName  ==  convQuestionnaire_Sim.AnswerTypeId)
{
return mstrAnswerTypeId;
}
else if (strAttributeName  ==  convQuestionnaire_Sim.IsShow)
{
return mbolIsShow;
}
else if (strAttributeName  ==  convQuestionnaire_Sim.DifficultyLevelId)
{
return mstrDifficultyLevelId;
}
return null;
}
set
{
if (strAttributeName  ==  convQuestionnaire_Sim.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire_Sim.QuestionId);
}
else if (strAttributeName  ==  convQuestionnaire_Sim.QuestionName)
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Sim.QuestionName);
}
else if (strAttributeName  ==  convQuestionnaire_Sim.QuestionIndex)
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire_Sim.QuestionIndex);
}
else if (strAttributeName  ==  convQuestionnaire_Sim.QuestionNo)
{
mstrQuestionNo = value.ToString();
 AddUpdatedFld(convQuestionnaire_Sim.QuestionNo);
}
else if (strAttributeName  ==  convQuestionnaire_Sim.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Sim.CourseId);
}
else if (strAttributeName  ==  convQuestionnaire_Sim.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Sim.CourseChapterId);
}
else if (strAttributeName  ==  convQuestionnaire_Sim.ParentQuestionId)
{
mstrParentQuestionId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Sim.ParentQuestionId);
}
else if (strAttributeName  ==  convQuestionnaire_Sim.QuestionTypeId)
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Sim.QuestionTypeId);
}
else if (strAttributeName  ==  convQuestionnaire_Sim.QuestionTypeId4Course)
{
mstrQuestionTypeId4Course = value.ToString();
 AddUpdatedFld(convQuestionnaire_Sim.QuestionTypeId4Course);
}
else if (strAttributeName  ==  convQuestionnaire_Sim.AnswerTypeId)
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Sim.AnswerTypeId);
}
else if (strAttributeName  ==  convQuestionnaire_Sim.IsShow)
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire_Sim.IsShow);
}
else if (strAttributeName  ==  convQuestionnaire_Sim.DifficultyLevelId)
{
mstrDifficultyLevelId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Sim.DifficultyLevelId);
}
}
}
public object this[int intIndex]
{
get
{
if (convQuestionnaire_Sim.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (convQuestionnaire_Sim.QuestionName  ==  AttributeName[intIndex])
{
return mstrQuestionName;
}
else if (convQuestionnaire_Sim.QuestionIndex  ==  AttributeName[intIndex])
{
return mintQuestionIndex;
}
else if (convQuestionnaire_Sim.QuestionNo  ==  AttributeName[intIndex])
{
return mstrQuestionNo;
}
else if (convQuestionnaire_Sim.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convQuestionnaire_Sim.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (convQuestionnaire_Sim.ParentQuestionId  ==  AttributeName[intIndex])
{
return mstrParentQuestionId;
}
else if (convQuestionnaire_Sim.QuestionTypeId  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId;
}
else if (convQuestionnaire_Sim.QuestionTypeId4Course  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId4Course;
}
else if (convQuestionnaire_Sim.AnswerTypeId  ==  AttributeName[intIndex])
{
return mstrAnswerTypeId;
}
else if (convQuestionnaire_Sim.IsShow  ==  AttributeName[intIndex])
{
return mbolIsShow;
}
else if (convQuestionnaire_Sim.DifficultyLevelId  ==  AttributeName[intIndex])
{
return mstrDifficultyLevelId;
}
return null;
}
set
{
if (convQuestionnaire_Sim.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire_Sim.QuestionId);
}
else if (convQuestionnaire_Sim.QuestionName  ==  AttributeName[intIndex])
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convQuestionnaire_Sim.QuestionName);
}
else if (convQuestionnaire_Sim.QuestionIndex  ==  AttributeName[intIndex])
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire_Sim.QuestionIndex);
}
else if (convQuestionnaire_Sim.QuestionNo  ==  AttributeName[intIndex])
{
mstrQuestionNo = value.ToString();
 AddUpdatedFld(convQuestionnaire_Sim.QuestionNo);
}
else if (convQuestionnaire_Sim.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Sim.CourseId);
}
else if (convQuestionnaire_Sim.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Sim.CourseChapterId);
}
else if (convQuestionnaire_Sim.ParentQuestionId  ==  AttributeName[intIndex])
{
mstrParentQuestionId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Sim.ParentQuestionId);
}
else if (convQuestionnaire_Sim.QuestionTypeId  ==  AttributeName[intIndex])
{
mstrQuestionTypeId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Sim.QuestionTypeId);
}
else if (convQuestionnaire_Sim.QuestionTypeId4Course  ==  AttributeName[intIndex])
{
mstrQuestionTypeId4Course = value.ToString();
 AddUpdatedFld(convQuestionnaire_Sim.QuestionTypeId4Course);
}
else if (convQuestionnaire_Sim.AnswerTypeId  ==  AttributeName[intIndex])
{
mstrAnswerTypeId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Sim.AnswerTypeId);
}
else if (convQuestionnaire_Sim.IsShow  ==  AttributeName[intIndex])
{
mbolIsShow = TransNullToBool(value.ToString());
 AddUpdatedFld(convQuestionnaire_Sim.IsShow);
}
else if (convQuestionnaire_Sim.DifficultyLevelId  ==  AttributeName[intIndex])
{
mstrDifficultyLevelId = value.ToString();
 AddUpdatedFld(convQuestionnaire_Sim.DifficultyLevelId);
}
}
}

/// <summary>
/// 题目Id(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long QuestionId
{
get
{
return mlngQuestionId;
}
set
{
 mlngQuestionId = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire_Sim.QuestionId);
}
}
/// <summary>
/// 题目名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionName
{
get
{
return mstrQuestionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionName = value;
}
else
{
 mstrQuestionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire_Sim.QuestionName);
}
}
/// <summary>
/// 题目序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? QuestionIndex
{
get
{
return mintQuestionIndex;
}
set
{
 mintQuestionIndex = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire_Sim.QuestionIndex);
}
}
/// <summary>
/// 题目编号(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionNo
{
get
{
return mstrQuestionNo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionNo = value;
}
else
{
 mstrQuestionNo = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire_Sim.QuestionNo);
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
 AddUpdatedFld(convQuestionnaire_Sim.CourseId);
}
}
/// <summary>
/// 课程章节ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseChapterId
{
get
{
return mstrCourseChapterId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseChapterId = value;
}
else
{
 mstrCourseChapterId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire_Sim.CourseChapterId);
}
}
/// <summary>
/// 父题目Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParentQuestionId
{
get
{
return mstrParentQuestionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParentQuestionId = value;
}
else
{
 mstrParentQuestionId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire_Sim.ParentQuestionId);
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
 AddUpdatedFld(convQuestionnaire_Sim.QuestionTypeId);
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
 AddUpdatedFld(convQuestionnaire_Sim.QuestionTypeId4Course);
}
}
/// <summary>
/// 答案类型ID(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AnswerTypeId
{
get
{
return mstrAnswerTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAnswerTypeId = value;
}
else
{
 mstrAnswerTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire_Sim.AnswerTypeId);
}
}
/// <summary>
/// 是否启用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsShow
{
get
{
return mbolIsShow;
}
set
{
 mbolIsShow = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire_Sim.IsShow);
}
}
/// <summary>
/// 难度等级Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DifficultyLevelId
{
get
{
return mstrDifficultyLevelId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDifficultyLevelId = value;
}
else
{
 mstrDifficultyLevelId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire_Sim.DifficultyLevelId);
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
  return mlngQuestionId.ToString();
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
  return mstrQuestionName;
 }
 }
}
 /// <summary>
 /// vQuestionnaire_Sim(vQuestionnaire_Sim)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQuestionnaire_Sim
{
public const string _CurrTabName = "vQuestionnaire_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "QuestionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"QuestionId", "QuestionName", "QuestionIndex", "QuestionNo", "CourseId", "CourseChapterId", "ParentQuestionId", "QuestionTypeId", "QuestionTypeId4Course", "AnswerTypeId", "IsShow", "DifficultyLevelId"};
//以下是属性变量


 /// <summary>
 /// 常量:"QuestionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionId = "QuestionId";    //题目Id

 /// <summary>
 /// 常量:"QuestionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionName = "QuestionName";    //题目名称

 /// <summary>
 /// 常量:"QuestionIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionIndex = "QuestionIndex";    //题目序号

 /// <summary>
 /// 常量:"QuestionNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionNo = "QuestionNo";    //题目编号

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"CourseChapterId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseChapterId = "CourseChapterId";    //课程章节ID

 /// <summary>
 /// 常量:"ParentQuestionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentQuestionId = "ParentQuestionId";    //父题目Id

 /// <summary>
 /// 常量:"QuestionTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeId = "QuestionTypeId";    //题目类型Id

 /// <summary>
 /// 常量:"QuestionTypeId4Course"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeId4Course = "QuestionTypeId4Course";    //题目类型Id4课程

 /// <summary>
 /// 常量:"AnswerTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerTypeId = "AnswerTypeId";    //答案类型ID

 /// <summary>
 /// 常量:"IsShow"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsShow = "IsShow";    //是否启用

 /// <summary>
 /// 常量:"DifficultyLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DifficultyLevelId = "DifficultyLevelId";    //难度等级Id
}

}