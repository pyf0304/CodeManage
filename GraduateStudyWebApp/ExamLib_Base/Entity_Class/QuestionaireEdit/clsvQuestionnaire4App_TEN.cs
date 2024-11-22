
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaire4App_TEN
 表名:vQuestionnaire4App_T(01120222)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:30:27
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
 /// 表vQuestionnaire4App_T的关键字(QuestionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_QuestionId_vQuestionnaire4App_T
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
public K_QuestionId_vQuestionnaire4App_T(long lngQuestionId)
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
 /// <returns>返回:[K_QuestionId_vQuestionnaire4App_T]类型的对象</returns>
public static implicit operator K_QuestionId_vQuestionnaire4App_T(long value)
{
return new K_QuestionId_vQuestionnaire4App_T(value);
}
}
 /// <summary>
 /// v题目表4App_T(vQuestionnaire4App_T)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQuestionnaire4App_TEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQuestionnaire4App_T"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "QuestionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"QuestionId", "QuestionIndex", "QuestionName", "QuestionNo", "CourseId", "CourseChapterId", "ChapterId", "ChapterName", "ChapterNameSim", "ChapterOrderNum", "QuestionTypeId4Course"};

protected long mlngQuestionId;    //题目Id
protected int? mintQuestionIndex;    //题目序号
protected string mstrQuestionName;    //题目名称
protected string mstrQuestionNo;    //题目编号
protected string mstrCourseId;    //课程Id
protected string mstrCourseChapterId;    //课程章节ID
protected string mstrChapterId;    //章Id
protected string mstrChapterName;    //章名
protected string mstrChapterNameSim;    //章名简称
protected int? mintChapterOrderNum;    //章排序号
protected string mstrQuestionTypeId4Course;    //题目类型Id4课程

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQuestionnaire4App_TEN()
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
public clsvQuestionnaire4App_TEN(long lngQuestionId)
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
if (strAttributeName  ==  convQuestionnaire4App_T.QuestionId)
{
return mlngQuestionId;
}
else if (strAttributeName  ==  convQuestionnaire4App_T.QuestionIndex)
{
return mintQuestionIndex;
}
else if (strAttributeName  ==  convQuestionnaire4App_T.QuestionName)
{
return mstrQuestionName;
}
else if (strAttributeName  ==  convQuestionnaire4App_T.QuestionNo)
{
return mstrQuestionNo;
}
else if (strAttributeName  ==  convQuestionnaire4App_T.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convQuestionnaire4App_T.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  convQuestionnaire4App_T.ChapterId)
{
return mstrChapterId;
}
else if (strAttributeName  ==  convQuestionnaire4App_T.ChapterName)
{
return mstrChapterName;
}
else if (strAttributeName  ==  convQuestionnaire4App_T.ChapterNameSim)
{
return mstrChapterNameSim;
}
else if (strAttributeName  ==  convQuestionnaire4App_T.ChapterOrderNum)
{
return mintChapterOrderNum;
}
else if (strAttributeName  ==  convQuestionnaire4App_T.QuestionTypeId4Course)
{
return mstrQuestionTypeId4Course;
}
return null;
}
set
{
if (strAttributeName  ==  convQuestionnaire4App_T.QuestionId)
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire4App_T.QuestionId);
}
else if (strAttributeName  ==  convQuestionnaire4App_T.QuestionIndex)
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire4App_T.QuestionIndex);
}
else if (strAttributeName  ==  convQuestionnaire4App_T.QuestionName)
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convQuestionnaire4App_T.QuestionName);
}
else if (strAttributeName  ==  convQuestionnaire4App_T.QuestionNo)
{
mstrQuestionNo = value.ToString();
 AddUpdatedFld(convQuestionnaire4App_T.QuestionNo);
}
else if (strAttributeName  ==  convQuestionnaire4App_T.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convQuestionnaire4App_T.CourseId);
}
else if (strAttributeName  ==  convQuestionnaire4App_T.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convQuestionnaire4App_T.CourseChapterId);
}
else if (strAttributeName  ==  convQuestionnaire4App_T.ChapterId)
{
mstrChapterId = value.ToString();
 AddUpdatedFld(convQuestionnaire4App_T.ChapterId);
}
else if (strAttributeName  ==  convQuestionnaire4App_T.ChapterName)
{
mstrChapterName = value.ToString();
 AddUpdatedFld(convQuestionnaire4App_T.ChapterName);
}
else if (strAttributeName  ==  convQuestionnaire4App_T.ChapterNameSim)
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convQuestionnaire4App_T.ChapterNameSim);
}
else if (strAttributeName  ==  convQuestionnaire4App_T.ChapterOrderNum)
{
mintChapterOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire4App_T.ChapterOrderNum);
}
else if (strAttributeName  ==  convQuestionnaire4App_T.QuestionTypeId4Course)
{
mstrQuestionTypeId4Course = value.ToString();
 AddUpdatedFld(convQuestionnaire4App_T.QuestionTypeId4Course);
}
}
}
public object this[int intIndex]
{
get
{
if (convQuestionnaire4App_T.QuestionId  ==  AttributeName[intIndex])
{
return mlngQuestionId;
}
else if (convQuestionnaire4App_T.QuestionIndex  ==  AttributeName[intIndex])
{
return mintQuestionIndex;
}
else if (convQuestionnaire4App_T.QuestionName  ==  AttributeName[intIndex])
{
return mstrQuestionName;
}
else if (convQuestionnaire4App_T.QuestionNo  ==  AttributeName[intIndex])
{
return mstrQuestionNo;
}
else if (convQuestionnaire4App_T.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convQuestionnaire4App_T.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (convQuestionnaire4App_T.ChapterId  ==  AttributeName[intIndex])
{
return mstrChapterId;
}
else if (convQuestionnaire4App_T.ChapterName  ==  AttributeName[intIndex])
{
return mstrChapterName;
}
else if (convQuestionnaire4App_T.ChapterNameSim  ==  AttributeName[intIndex])
{
return mstrChapterNameSim;
}
else if (convQuestionnaire4App_T.ChapterOrderNum  ==  AttributeName[intIndex])
{
return mintChapterOrderNum;
}
else if (convQuestionnaire4App_T.QuestionTypeId4Course  ==  AttributeName[intIndex])
{
return mstrQuestionTypeId4Course;
}
return null;
}
set
{
if (convQuestionnaire4App_T.QuestionId  ==  AttributeName[intIndex])
{
mlngQuestionId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire4App_T.QuestionId);
}
else if (convQuestionnaire4App_T.QuestionIndex  ==  AttributeName[intIndex])
{
mintQuestionIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire4App_T.QuestionIndex);
}
else if (convQuestionnaire4App_T.QuestionName  ==  AttributeName[intIndex])
{
mstrQuestionName = value.ToString();
 AddUpdatedFld(convQuestionnaire4App_T.QuestionName);
}
else if (convQuestionnaire4App_T.QuestionNo  ==  AttributeName[intIndex])
{
mstrQuestionNo = value.ToString();
 AddUpdatedFld(convQuestionnaire4App_T.QuestionNo);
}
else if (convQuestionnaire4App_T.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convQuestionnaire4App_T.CourseId);
}
else if (convQuestionnaire4App_T.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convQuestionnaire4App_T.CourseChapterId);
}
else if (convQuestionnaire4App_T.ChapterId  ==  AttributeName[intIndex])
{
mstrChapterId = value.ToString();
 AddUpdatedFld(convQuestionnaire4App_T.ChapterId);
}
else if (convQuestionnaire4App_T.ChapterName  ==  AttributeName[intIndex])
{
mstrChapterName = value.ToString();
 AddUpdatedFld(convQuestionnaire4App_T.ChapterName);
}
else if (convQuestionnaire4App_T.ChapterNameSim  ==  AttributeName[intIndex])
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convQuestionnaire4App_T.ChapterNameSim);
}
else if (convQuestionnaire4App_T.ChapterOrderNum  ==  AttributeName[intIndex])
{
mintChapterOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQuestionnaire4App_T.ChapterOrderNum);
}
else if (convQuestionnaire4App_T.QuestionTypeId4Course  ==  AttributeName[intIndex])
{
mstrQuestionTypeId4Course = value.ToString();
 AddUpdatedFld(convQuestionnaire4App_T.QuestionTypeId4Course);
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
 AddUpdatedFld(convQuestionnaire4App_T.QuestionId);
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
 AddUpdatedFld(convQuestionnaire4App_T.QuestionIndex);
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
 AddUpdatedFld(convQuestionnaire4App_T.QuestionName);
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
 AddUpdatedFld(convQuestionnaire4App_T.QuestionNo);
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
 AddUpdatedFld(convQuestionnaire4App_T.CourseId);
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
 AddUpdatedFld(convQuestionnaire4App_T.CourseChapterId);
}
}
/// <summary>
/// 章Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ChapterId
{
get
{
return mstrChapterId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrChapterId = value;
}
else
{
 mstrChapterId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire4App_T.ChapterId);
}
}
/// <summary>
/// 章名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ChapterName
{
get
{
return mstrChapterName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrChapterName = value;
}
else
{
 mstrChapterName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire4App_T.ChapterName);
}
}
/// <summary>
/// 章名简称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ChapterNameSim
{
get
{
return mstrChapterNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrChapterNameSim = value;
}
else
{
 mstrChapterNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire4App_T.ChapterNameSim);
}
}
/// <summary>
/// 章排序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ChapterOrderNum
{
get
{
return mintChapterOrderNum;
}
set
{
 mintChapterOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convQuestionnaire4App_T.ChapterOrderNum);
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
 AddUpdatedFld(convQuestionnaire4App_T.QuestionTypeId4Course);
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
 /// v题目表4App_T(vQuestionnaire4App_T)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQuestionnaire4App_T
{
public const string _CurrTabName = "vQuestionnaire4App_T"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "QuestionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"QuestionId", "QuestionIndex", "QuestionName", "QuestionNo", "CourseId", "CourseChapterId", "ChapterId", "ChapterName", "ChapterNameSim", "ChapterOrderNum", "QuestionTypeId4Course"};
//以下是属性变量


 /// <summary>
 /// 常量:"QuestionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionId = "QuestionId";    //题目Id

 /// <summary>
 /// 常量:"QuestionIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionIndex = "QuestionIndex";    //题目序号

 /// <summary>
 /// 常量:"QuestionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionName = "QuestionName";    //题目名称

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
 /// 常量:"ChapterId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterId = "ChapterId";    //章Id

 /// <summary>
 /// 常量:"ChapterName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterName = "ChapterName";    //章名

 /// <summary>
 /// 常量:"ChapterNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterNameSim = "ChapterNameSim";    //章名简称

 /// <summary>
 /// 常量:"ChapterOrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ChapterOrderNum = "ChapterOrderNum";    //章排序号

 /// <summary>
 /// 常量:"QuestionTypeId4Course"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionTypeId4Course = "QuestionTypeId4Course";    //题目类型Id4课程
}

}