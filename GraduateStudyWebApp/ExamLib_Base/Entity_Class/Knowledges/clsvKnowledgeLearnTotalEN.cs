
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvKnowledgeLearnTotalEN
 表名:vKnowledgeLearnTotal(01120156)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:49:29
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
 /// 表vKnowledgeLearnTotal的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vKnowledgeLearnTotal
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_vKnowledgeLearnTotal(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_vKnowledgeLearnTotal]类型的对象</returns>
public static implicit operator K_mId_vKnowledgeLearnTotal(long value)
{
return new K_mId_vKnowledgeLearnTotal(value);
}
}
 /// <summary>
 /// v知识点学习汇总表(vKnowledgeLearnTotal)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvKnowledgeLearnTotalEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vKnowledgeLearnTotal"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 17;
public static string[] AttributeName = new string[] {"mId", "UserId", "UserName", "CourseKnowledgeId", "KnowledgeName", "CourseId", "CourseName", "CourseChapterId", "MasterDegree", "LearnCount", "SuccessCount", "FailCount", "LastLearnDate", "RecommendedNextReviewDate", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户ID
protected string mstrUserName;    //用户名
protected string mstrCourseKnowledgeId;    //知识点Id
protected string mstrKnowledgeName;    //知识点名称
protected string mstrCourseId;    //课程Id
protected string mstrCourseName;    //课程名称
protected string mstrCourseChapterId;    //课程章节ID
protected int mintMasterDegree;    //掌握程度
protected int? mintLearnCount;    //学习次数
protected int? mintSuccessCount;    //成功次数
protected int? mintFailCount;    //失败次数
protected string mstrLastLearnDate;    //最后学习日期
protected string mstrRecommendedNextReviewDate;    //推荐下次复习日期
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvKnowledgeLearnTotalEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsvKnowledgeLearnTotalEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  convKnowledgeLearnTotal.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convKnowledgeLearnTotal.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convKnowledgeLearnTotal.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convKnowledgeLearnTotal.CourseKnowledgeId)
{
return mstrCourseKnowledgeId;
}
else if (strAttributeName  ==  convKnowledgeLearnTotal.KnowledgeName)
{
return mstrKnowledgeName;
}
else if (strAttributeName  ==  convKnowledgeLearnTotal.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convKnowledgeLearnTotal.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convKnowledgeLearnTotal.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  convKnowledgeLearnTotal.MasterDegree)
{
return mintMasterDegree;
}
else if (strAttributeName  ==  convKnowledgeLearnTotal.LearnCount)
{
return mintLearnCount;
}
else if (strAttributeName  ==  convKnowledgeLearnTotal.SuccessCount)
{
return mintSuccessCount;
}
else if (strAttributeName  ==  convKnowledgeLearnTotal.FailCount)
{
return mintFailCount;
}
else if (strAttributeName  ==  convKnowledgeLearnTotal.LastLearnDate)
{
return mstrLastLearnDate;
}
else if (strAttributeName  ==  convKnowledgeLearnTotal.RecommendedNextReviewDate)
{
return mstrRecommendedNextReviewDate;
}
else if (strAttributeName  ==  convKnowledgeLearnTotal.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convKnowledgeLearnTotal.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convKnowledgeLearnTotal.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convKnowledgeLearnTotal.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convKnowledgeLearnTotal.mId);
}
else if (strAttributeName  ==  convKnowledgeLearnTotal.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convKnowledgeLearnTotal.UserId);
}
else if (strAttributeName  ==  convKnowledgeLearnTotal.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convKnowledgeLearnTotal.UserName);
}
else if (strAttributeName  ==  convKnowledgeLearnTotal.CourseKnowledgeId)
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(convKnowledgeLearnTotal.CourseKnowledgeId);
}
else if (strAttributeName  ==  convKnowledgeLearnTotal.KnowledgeName)
{
mstrKnowledgeName = value.ToString();
 AddUpdatedFld(convKnowledgeLearnTotal.KnowledgeName);
}
else if (strAttributeName  ==  convKnowledgeLearnTotal.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convKnowledgeLearnTotal.CourseId);
}
else if (strAttributeName  ==  convKnowledgeLearnTotal.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convKnowledgeLearnTotal.CourseName);
}
else if (strAttributeName  ==  convKnowledgeLearnTotal.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convKnowledgeLearnTotal.CourseChapterId);
}
else if (strAttributeName  ==  convKnowledgeLearnTotal.MasterDegree)
{
mintMasterDegree = TransNullToInt(value.ToString());
 AddUpdatedFld(convKnowledgeLearnTotal.MasterDegree);
}
else if (strAttributeName  ==  convKnowledgeLearnTotal.LearnCount)
{
mintLearnCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convKnowledgeLearnTotal.LearnCount);
}
else if (strAttributeName  ==  convKnowledgeLearnTotal.SuccessCount)
{
mintSuccessCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convKnowledgeLearnTotal.SuccessCount);
}
else if (strAttributeName  ==  convKnowledgeLearnTotal.FailCount)
{
mintFailCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convKnowledgeLearnTotal.FailCount);
}
else if (strAttributeName  ==  convKnowledgeLearnTotal.LastLearnDate)
{
mstrLastLearnDate = value.ToString();
 AddUpdatedFld(convKnowledgeLearnTotal.LastLearnDate);
}
else if (strAttributeName  ==  convKnowledgeLearnTotal.RecommendedNextReviewDate)
{
mstrRecommendedNextReviewDate = value.ToString();
 AddUpdatedFld(convKnowledgeLearnTotal.RecommendedNextReviewDate);
}
else if (strAttributeName  ==  convKnowledgeLearnTotal.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convKnowledgeLearnTotal.UpdDate);
}
else if (strAttributeName  ==  convKnowledgeLearnTotal.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convKnowledgeLearnTotal.UpdUser);
}
else if (strAttributeName  ==  convKnowledgeLearnTotal.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convKnowledgeLearnTotal.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convKnowledgeLearnTotal.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convKnowledgeLearnTotal.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convKnowledgeLearnTotal.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convKnowledgeLearnTotal.CourseKnowledgeId  ==  AttributeName[intIndex])
{
return mstrCourseKnowledgeId;
}
else if (convKnowledgeLearnTotal.KnowledgeName  ==  AttributeName[intIndex])
{
return mstrKnowledgeName;
}
else if (convKnowledgeLearnTotal.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convKnowledgeLearnTotal.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convKnowledgeLearnTotal.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (convKnowledgeLearnTotal.MasterDegree  ==  AttributeName[intIndex])
{
return mintMasterDegree;
}
else if (convKnowledgeLearnTotal.LearnCount  ==  AttributeName[intIndex])
{
return mintLearnCount;
}
else if (convKnowledgeLearnTotal.SuccessCount  ==  AttributeName[intIndex])
{
return mintSuccessCount;
}
else if (convKnowledgeLearnTotal.FailCount  ==  AttributeName[intIndex])
{
return mintFailCount;
}
else if (convKnowledgeLearnTotal.LastLearnDate  ==  AttributeName[intIndex])
{
return mstrLastLearnDate;
}
else if (convKnowledgeLearnTotal.RecommendedNextReviewDate  ==  AttributeName[intIndex])
{
return mstrRecommendedNextReviewDate;
}
else if (convKnowledgeLearnTotal.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convKnowledgeLearnTotal.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convKnowledgeLearnTotal.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convKnowledgeLearnTotal.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convKnowledgeLearnTotal.mId);
}
else if (convKnowledgeLearnTotal.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convKnowledgeLearnTotal.UserId);
}
else if (convKnowledgeLearnTotal.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convKnowledgeLearnTotal.UserName);
}
else if (convKnowledgeLearnTotal.CourseKnowledgeId  ==  AttributeName[intIndex])
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(convKnowledgeLearnTotal.CourseKnowledgeId);
}
else if (convKnowledgeLearnTotal.KnowledgeName  ==  AttributeName[intIndex])
{
mstrKnowledgeName = value.ToString();
 AddUpdatedFld(convKnowledgeLearnTotal.KnowledgeName);
}
else if (convKnowledgeLearnTotal.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convKnowledgeLearnTotal.CourseId);
}
else if (convKnowledgeLearnTotal.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convKnowledgeLearnTotal.CourseName);
}
else if (convKnowledgeLearnTotal.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convKnowledgeLearnTotal.CourseChapterId);
}
else if (convKnowledgeLearnTotal.MasterDegree  ==  AttributeName[intIndex])
{
mintMasterDegree = TransNullToInt(value.ToString());
 AddUpdatedFld(convKnowledgeLearnTotal.MasterDegree);
}
else if (convKnowledgeLearnTotal.LearnCount  ==  AttributeName[intIndex])
{
mintLearnCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convKnowledgeLearnTotal.LearnCount);
}
else if (convKnowledgeLearnTotal.SuccessCount  ==  AttributeName[intIndex])
{
mintSuccessCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convKnowledgeLearnTotal.SuccessCount);
}
else if (convKnowledgeLearnTotal.FailCount  ==  AttributeName[intIndex])
{
mintFailCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convKnowledgeLearnTotal.FailCount);
}
else if (convKnowledgeLearnTotal.LastLearnDate  ==  AttributeName[intIndex])
{
mstrLastLearnDate = value.ToString();
 AddUpdatedFld(convKnowledgeLearnTotal.LastLearnDate);
}
else if (convKnowledgeLearnTotal.RecommendedNextReviewDate  ==  AttributeName[intIndex])
{
mstrRecommendedNextReviewDate = value.ToString();
 AddUpdatedFld(convKnowledgeLearnTotal.RecommendedNextReviewDate);
}
else if (convKnowledgeLearnTotal.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convKnowledgeLearnTotal.UpdDate);
}
else if (convKnowledgeLearnTotal.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convKnowledgeLearnTotal.UpdUser);
}
else if (convKnowledgeLearnTotal.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convKnowledgeLearnTotal.Memo);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(convKnowledgeLearnTotal.mId);
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convKnowledgeLearnTotal.UserId);
}
}
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserName
{
get
{
return mstrUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserName = value;
}
else
{
 mstrUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convKnowledgeLearnTotal.UserName);
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
 AddUpdatedFld(convKnowledgeLearnTotal.CourseKnowledgeId);
}
}
/// <summary>
/// 知识点名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KnowledgeName
{
get
{
return mstrKnowledgeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKnowledgeName = value;
}
else
{
 mstrKnowledgeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convKnowledgeLearnTotal.KnowledgeName);
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
 AddUpdatedFld(convKnowledgeLearnTotal.CourseId);
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
 AddUpdatedFld(convKnowledgeLearnTotal.CourseName);
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
 AddUpdatedFld(convKnowledgeLearnTotal.CourseChapterId);
}
}
/// <summary>
/// 掌握程度(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int MasterDegree
{
get
{
return mintMasterDegree;
}
set
{
 mintMasterDegree = value;
//记录修改过的字段
 AddUpdatedFld(convKnowledgeLearnTotal.MasterDegree);
}
}
/// <summary>
/// 学习次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? LearnCount
{
get
{
return mintLearnCount;
}
set
{
 mintLearnCount = value;
//记录修改过的字段
 AddUpdatedFld(convKnowledgeLearnTotal.LearnCount);
}
}
/// <summary>
/// 成功次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? SuccessCount
{
get
{
return mintSuccessCount;
}
set
{
 mintSuccessCount = value;
//记录修改过的字段
 AddUpdatedFld(convKnowledgeLearnTotal.SuccessCount);
}
}
/// <summary>
/// 失败次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? FailCount
{
get
{
return mintFailCount;
}
set
{
 mintFailCount = value;
//记录修改过的字段
 AddUpdatedFld(convKnowledgeLearnTotal.FailCount);
}
}
/// <summary>
/// 最后学习日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LastLearnDate
{
get
{
return mstrLastLearnDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLastLearnDate = value;
}
else
{
 mstrLastLearnDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convKnowledgeLearnTotal.LastLearnDate);
}
}
/// <summary>
/// 推荐下次复习日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RecommendedNextReviewDate
{
get
{
return mstrRecommendedNextReviewDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRecommendedNextReviewDate = value;
}
else
{
 mstrRecommendedNextReviewDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convKnowledgeLearnTotal.RecommendedNextReviewDate);
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
 AddUpdatedFld(convKnowledgeLearnTotal.UpdDate);
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
 AddUpdatedFld(convKnowledgeLearnTotal.UpdUser);
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
 AddUpdatedFld(convKnowledgeLearnTotal.Memo);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// v知识点学习汇总表(vKnowledgeLearnTotal)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convKnowledgeLearnTotal
{
public const string _CurrTabName = "vKnowledgeLearnTotal"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserId", "UserName", "CourseKnowledgeId", "KnowledgeName", "CourseId", "CourseName", "CourseChapterId", "MasterDegree", "LearnCount", "SuccessCount", "FailCount", "LastLearnDate", "RecommendedNextReviewDate", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"CourseKnowledgeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseKnowledgeId = "CourseKnowledgeId";    //知识点Id

 /// <summary>
 /// 常量:"KnowledgeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KnowledgeName = "KnowledgeName";    //知识点名称

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
 /// 常量:"CourseChapterId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseChapterId = "CourseChapterId";    //课程章节ID

 /// <summary>
 /// 常量:"MasterDegree"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MasterDegree = "MasterDegree";    //掌握程度

 /// <summary>
 /// 常量:"LearnCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LearnCount = "LearnCount";    //学习次数

 /// <summary>
 /// 常量:"SuccessCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SuccessCount = "SuccessCount";    //成功次数

 /// <summary>
 /// 常量:"FailCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FailCount = "FailCount";    //失败次数

 /// <summary>
 /// 常量:"LastLearnDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LastLearnDate = "LastLearnDate";    //最后学习日期

 /// <summary>
 /// 常量:"RecommendedNextReviewDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RecommendedNextReviewDate = "RecommendedNextReviewDate";    //推荐下次复习日期

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