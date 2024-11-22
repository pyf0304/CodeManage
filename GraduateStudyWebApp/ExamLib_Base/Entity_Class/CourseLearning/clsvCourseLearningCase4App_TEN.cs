
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningCase4App_TEN
 表名:vCourseLearningCase4App_T(01120272)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:48
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
 /// 表vCourseLearningCase4App_T的关键字(IdCourseLearningCase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCourseLearningCase_vCourseLearningCase4App_T
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdCourseLearningCase">表关键字</param>
public K_IdCourseLearningCase_vCourseLearningCase4App_T(string strIdCourseLearningCase)
{
if (IsValid(strIdCourseLearningCase)) Value = strIdCourseLearningCase;
else
{
Value = null;
}
}
private static bool IsValid(string strIdCourseLearningCase)
{
if (string.IsNullOrEmpty(strIdCourseLearningCase) == true) return false;
if (strIdCourseLearningCase.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdCourseLearningCase_vCourseLearningCase4App_T]类型的对象</returns>
public static implicit operator K_IdCourseLearningCase_vCourseLearningCase4App_T(string value)
{
return new K_IdCourseLearningCase_vCourseLearningCase4App_T(value);
}
}
 /// <summary>
 /// v课程学习案例4App_T(vCourseLearningCase4App_T)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCourseLearningCase4App_TEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCourseLearningCase4App_T"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCourseLearningCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"IdCourseLearningCase", "CourseLearningCaseID", "CourseLearningCaseName", "CourseId", "CourseChapterId", "ChapterId", "ChapterName", "ChapterNameSim", "OrderNum4Chapter", "RecommendedDegreeId", "ImageUrl"};

protected string mstrIdCourseLearningCase;    //课程学习案例流水号
protected string mstrCourseLearningCaseID;    //课程学习案例ID
protected string mstrCourseLearningCaseName;    //课程学习案例名称
protected string mstrCourseId;    //课程Id
protected string mstrCourseChapterId;    //课程章节ID
protected string mstrChapterId;    //章Id
protected string mstrChapterName;    //章名
protected string mstrChapterNameSim;    //章名简称
protected int? mintOrderNum4Chapter;    //OrderNum4Chapter
protected string mstrRecommendedDegreeId;    //推荐度Id
protected string mstrImageUrl;    //ImageUrl

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvCourseLearningCase4App_TEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCourseLearningCase");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdCourseLearningCase">关键字:课程学习案例流水号</param>
public clsvCourseLearningCase4App_TEN(string strIdCourseLearningCase)
 {
strIdCourseLearningCase = strIdCourseLearningCase.Replace("'", "''");
if (strIdCourseLearningCase.Length > 8)
{
throw new Exception("在表:vCourseLearningCase4App_T中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdCourseLearningCase)  ==  true)
{
throw new Exception("在表:vCourseLearningCase4App_T中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCourseLearningCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdCourseLearningCase = strIdCourseLearningCase;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCourseLearningCase");
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
if (strAttributeName  ==  convCourseLearningCase4App_T.IdCourseLearningCase)
{
return mstrIdCourseLearningCase;
}
else if (strAttributeName  ==  convCourseLearningCase4App_T.CourseLearningCaseID)
{
return mstrCourseLearningCaseID;
}
else if (strAttributeName  ==  convCourseLearningCase4App_T.CourseLearningCaseName)
{
return mstrCourseLearningCaseName;
}
else if (strAttributeName  ==  convCourseLearningCase4App_T.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convCourseLearningCase4App_T.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  convCourseLearningCase4App_T.ChapterId)
{
return mstrChapterId;
}
else if (strAttributeName  ==  convCourseLearningCase4App_T.ChapterName)
{
return mstrChapterName;
}
else if (strAttributeName  ==  convCourseLearningCase4App_T.ChapterNameSim)
{
return mstrChapterNameSim;
}
else if (strAttributeName  ==  convCourseLearningCase4App_T.OrderNum4Chapter)
{
return mintOrderNum4Chapter;
}
else if (strAttributeName  ==  convCourseLearningCase4App_T.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  convCourseLearningCase4App_T.ImageUrl)
{
return mstrImageUrl;
}
return null;
}
set
{
if (strAttributeName  ==  convCourseLearningCase4App_T.IdCourseLearningCase)
{
mstrIdCourseLearningCase = value.ToString();
 AddUpdatedFld(convCourseLearningCase4App_T.IdCourseLearningCase);
}
else if (strAttributeName  ==  convCourseLearningCase4App_T.CourseLearningCaseID)
{
mstrCourseLearningCaseID = value.ToString();
 AddUpdatedFld(convCourseLearningCase4App_T.CourseLearningCaseID);
}
else if (strAttributeName  ==  convCourseLearningCase4App_T.CourseLearningCaseName)
{
mstrCourseLearningCaseName = value.ToString();
 AddUpdatedFld(convCourseLearningCase4App_T.CourseLearningCaseName);
}
else if (strAttributeName  ==  convCourseLearningCase4App_T.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convCourseLearningCase4App_T.CourseId);
}
else if (strAttributeName  ==  convCourseLearningCase4App_T.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convCourseLearningCase4App_T.CourseChapterId);
}
else if (strAttributeName  ==  convCourseLearningCase4App_T.ChapterId)
{
mstrChapterId = value.ToString();
 AddUpdatedFld(convCourseLearningCase4App_T.ChapterId);
}
else if (strAttributeName  ==  convCourseLearningCase4App_T.ChapterName)
{
mstrChapterName = value.ToString();
 AddUpdatedFld(convCourseLearningCase4App_T.ChapterName);
}
else if (strAttributeName  ==  convCourseLearningCase4App_T.ChapterNameSim)
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convCourseLearningCase4App_T.ChapterNameSim);
}
else if (strAttributeName  ==  convCourseLearningCase4App_T.OrderNum4Chapter)
{
mintOrderNum4Chapter = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCase4App_T.OrderNum4Chapter);
}
else if (strAttributeName  ==  convCourseLearningCase4App_T.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convCourseLearningCase4App_T.RecommendedDegreeId);
}
else if (strAttributeName  ==  convCourseLearningCase4App_T.ImageUrl)
{
mstrImageUrl = value.ToString();
 AddUpdatedFld(convCourseLearningCase4App_T.ImageUrl);
}
}
}
public object this[int intIndex]
{
get
{
if (convCourseLearningCase4App_T.IdCourseLearningCase  ==  AttributeName[intIndex])
{
return mstrIdCourseLearningCase;
}
else if (convCourseLearningCase4App_T.CourseLearningCaseID  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseID;
}
else if (convCourseLearningCase4App_T.CourseLearningCaseName  ==  AttributeName[intIndex])
{
return mstrCourseLearningCaseName;
}
else if (convCourseLearningCase4App_T.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convCourseLearningCase4App_T.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (convCourseLearningCase4App_T.ChapterId  ==  AttributeName[intIndex])
{
return mstrChapterId;
}
else if (convCourseLearningCase4App_T.ChapterName  ==  AttributeName[intIndex])
{
return mstrChapterName;
}
else if (convCourseLearningCase4App_T.ChapterNameSim  ==  AttributeName[intIndex])
{
return mstrChapterNameSim;
}
else if (convCourseLearningCase4App_T.OrderNum4Chapter  ==  AttributeName[intIndex])
{
return mintOrderNum4Chapter;
}
else if (convCourseLearningCase4App_T.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (convCourseLearningCase4App_T.ImageUrl  ==  AttributeName[intIndex])
{
return mstrImageUrl;
}
return null;
}
set
{
if (convCourseLearningCase4App_T.IdCourseLearningCase  ==  AttributeName[intIndex])
{
mstrIdCourseLearningCase = value.ToString();
 AddUpdatedFld(convCourseLearningCase4App_T.IdCourseLearningCase);
}
else if (convCourseLearningCase4App_T.CourseLearningCaseID  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseID = value.ToString();
 AddUpdatedFld(convCourseLearningCase4App_T.CourseLearningCaseID);
}
else if (convCourseLearningCase4App_T.CourseLearningCaseName  ==  AttributeName[intIndex])
{
mstrCourseLearningCaseName = value.ToString();
 AddUpdatedFld(convCourseLearningCase4App_T.CourseLearningCaseName);
}
else if (convCourseLearningCase4App_T.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convCourseLearningCase4App_T.CourseId);
}
else if (convCourseLearningCase4App_T.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convCourseLearningCase4App_T.CourseChapterId);
}
else if (convCourseLearningCase4App_T.ChapterId  ==  AttributeName[intIndex])
{
mstrChapterId = value.ToString();
 AddUpdatedFld(convCourseLearningCase4App_T.ChapterId);
}
else if (convCourseLearningCase4App_T.ChapterName  ==  AttributeName[intIndex])
{
mstrChapterName = value.ToString();
 AddUpdatedFld(convCourseLearningCase4App_T.ChapterName);
}
else if (convCourseLearningCase4App_T.ChapterNameSim  ==  AttributeName[intIndex])
{
mstrChapterNameSim = value.ToString();
 AddUpdatedFld(convCourseLearningCase4App_T.ChapterNameSim);
}
else if (convCourseLearningCase4App_T.OrderNum4Chapter  ==  AttributeName[intIndex])
{
mintOrderNum4Chapter = TransNullToInt(value.ToString());
 AddUpdatedFld(convCourseLearningCase4App_T.OrderNum4Chapter);
}
else if (convCourseLearningCase4App_T.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convCourseLearningCase4App_T.RecommendedDegreeId);
}
else if (convCourseLearningCase4App_T.ImageUrl  ==  AttributeName[intIndex])
{
mstrImageUrl = value.ToString();
 AddUpdatedFld(convCourseLearningCase4App_T.ImageUrl);
}
}
}

/// <summary>
/// 课程学习案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCourseLearningCase
{
get
{
return mstrIdCourseLearningCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCourseLearningCase = value;
}
else
{
 mstrIdCourseLearningCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase4App_T.IdCourseLearningCase);
}
}
/// <summary>
/// 课程学习案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseLearningCaseID
{
get
{
return mstrCourseLearningCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseLearningCaseID = value;
}
else
{
 mstrCourseLearningCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase4App_T.CourseLearningCaseID);
}
}
/// <summary>
/// 课程学习案例名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseLearningCaseName
{
get
{
return mstrCourseLearningCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseLearningCaseName = value;
}
else
{
 mstrCourseLearningCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase4App_T.CourseLearningCaseName);
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
 AddUpdatedFld(convCourseLearningCase4App_T.CourseId);
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
 AddUpdatedFld(convCourseLearningCase4App_T.CourseChapterId);
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
 AddUpdatedFld(convCourseLearningCase4App_T.ChapterId);
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
 AddUpdatedFld(convCourseLearningCase4App_T.ChapterName);
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
 AddUpdatedFld(convCourseLearningCase4App_T.ChapterNameSim);
}
}
/// <summary>
/// OrderNum4Chapter(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum4Chapter
{
get
{
return mintOrderNum4Chapter;
}
set
{
 mintOrderNum4Chapter = value;
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase4App_T.OrderNum4Chapter);
}
}
/// <summary>
/// 推荐度Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RecommendedDegreeId
{
get
{
return mstrRecommendedDegreeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRecommendedDegreeId = value;
}
else
{
 mstrRecommendedDegreeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase4App_T.RecommendedDegreeId);
}
}
/// <summary>
/// ImageUrl(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ImageUrl
{
get
{
return mstrImageUrl;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrImageUrl = value;
}
else
{
 mstrImageUrl = value;
}
//记录修改过的字段
 AddUpdatedFld(convCourseLearningCase4App_T.ImageUrl);
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
  return mstrIdCourseLearningCase;
 }
 }
}
 /// <summary>
 /// v课程学习案例4App_T(vCourseLearningCase4App_T)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCourseLearningCase4App_T
{
public const string _CurrTabName = "vCourseLearningCase4App_T"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCourseLearningCase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCourseLearningCase", "CourseLearningCaseID", "CourseLearningCaseName", "CourseId", "CourseChapterId", "ChapterId", "ChapterName", "ChapterNameSim", "OrderNum4Chapter", "RecommendedDegreeId", "ImageUrl"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdCourseLearningCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCourseLearningCase = "IdCourseLearningCase";    //课程学习案例流水号

 /// <summary>
 /// 常量:"CourseLearningCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseLearningCaseID = "CourseLearningCaseID";    //课程学习案例ID

 /// <summary>
 /// 常量:"CourseLearningCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseLearningCaseName = "CourseLearningCaseName";    //课程学习案例名称

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
 /// 常量:"OrderNum4Chapter"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum4Chapter = "OrderNum4Chapter";    //OrderNum4Chapter

 /// <summary>
 /// 常量:"RecommendedDegreeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RecommendedDegreeId = "RecommendedDegreeId";    //推荐度Id

 /// <summary>
 /// 常量:"ImageUrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ImageUrl = "ImageUrl";    //ImageUrl
}

}