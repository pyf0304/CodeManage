
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvKnowledgeLearnDetailEN
 表名:vKnowledgeLearnDetail(01120157)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:49:26
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
 /// 表vKnowledgeLearnDetail的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vKnowledgeLearnDetail
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
public K_mId_vKnowledgeLearnDetail(long lngmId)
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
 /// <returns>返回:[K_mId_vKnowledgeLearnDetail]类型的对象</returns>
public static implicit operator K_mId_vKnowledgeLearnDetail(long value)
{
return new K_mId_vKnowledgeLearnDetail(value);
}
}
 /// <summary>
 /// v知识点学习情况(vKnowledgeLearnDetail)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvKnowledgeLearnDetailEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vKnowledgeLearnDetail"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 20;
public static string[] AttributeName = new string[] {"mId", "UserId", "UserName", "CourseKnowledgeId", "KnowledgeName", "CourseId", "CourseName", "CourseChapterId", "LearnDate", "LearnModeId", "LearnModeName", "IdCase", "IdCaseType", "IsMaster", "MasterDegree", "MarkerId", "MarkTime", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户ID
protected string mstrUserName;    //用户名
protected string mstrCourseKnowledgeId;    //知识点Id
protected string mstrKnowledgeName;    //知识点名称
protected string mstrCourseId;    //课程Id
protected string mstrCourseName;    //课程名称
protected string mstrCourseChapterId;    //课程章节ID
protected string mstrLearnDate;    //学习日期
protected string mstrLearnModeId;    //学习模式Id
protected string mstrLearnModeName;    //学习模式名
protected string mstrIdCase;    //案例流水号
protected string mstrIdCaseType;    //案例类型流水号
protected bool mbolIsMaster;    //是否掌握
protected int mintMasterDegree;    //掌握程度
protected string mstrMarkerId;    //打分者
protected string mstrMarkTime;    //批改时间
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvKnowledgeLearnDetailEN()
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
public clsvKnowledgeLearnDetailEN(long lngmId)
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
if (strAttributeName  ==  convKnowledgeLearnDetail.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.CourseKnowledgeId)
{
return mstrCourseKnowledgeId;
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.KnowledgeName)
{
return mstrKnowledgeName;
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.CourseName)
{
return mstrCourseName;
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.CourseChapterId)
{
return mstrCourseChapterId;
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.LearnDate)
{
return mstrLearnDate;
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.LearnModeId)
{
return mstrLearnModeId;
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.LearnModeName)
{
return mstrLearnModeName;
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.IdCase)
{
return mstrIdCase;
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.IdCaseType)
{
return mstrIdCaseType;
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.IsMaster)
{
return mbolIsMaster;
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.MasterDegree)
{
return mintMasterDegree;
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.MarkerId)
{
return mstrMarkerId;
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.MarkTime)
{
return mstrMarkTime;
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convKnowledgeLearnDetail.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convKnowledgeLearnDetail.mId);
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.UserId);
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.UserName);
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.CourseKnowledgeId)
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.CourseKnowledgeId);
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.KnowledgeName)
{
mstrKnowledgeName = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.KnowledgeName);
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.CourseId);
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.CourseName)
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.CourseName);
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.CourseChapterId)
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.CourseChapterId);
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.LearnDate)
{
mstrLearnDate = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.LearnDate);
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.LearnModeId)
{
mstrLearnModeId = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.LearnModeId);
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.LearnModeName)
{
mstrLearnModeName = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.LearnModeName);
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.IdCase)
{
mstrIdCase = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.IdCase);
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.IdCaseType)
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.IdCaseType);
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.IsMaster)
{
mbolIsMaster = TransNullToBool(value.ToString());
 AddUpdatedFld(convKnowledgeLearnDetail.IsMaster);
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.MasterDegree)
{
mintMasterDegree = TransNullToInt(value.ToString());
 AddUpdatedFld(convKnowledgeLearnDetail.MasterDegree);
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.MarkerId)
{
mstrMarkerId = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.MarkerId);
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.MarkTime)
{
mstrMarkTime = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.MarkTime);
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.UpdDate);
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.UpdUser);
}
else if (strAttributeName  ==  convKnowledgeLearnDetail.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convKnowledgeLearnDetail.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convKnowledgeLearnDetail.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convKnowledgeLearnDetail.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convKnowledgeLearnDetail.CourseKnowledgeId  ==  AttributeName[intIndex])
{
return mstrCourseKnowledgeId;
}
else if (convKnowledgeLearnDetail.KnowledgeName  ==  AttributeName[intIndex])
{
return mstrKnowledgeName;
}
else if (convKnowledgeLearnDetail.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (convKnowledgeLearnDetail.CourseName  ==  AttributeName[intIndex])
{
return mstrCourseName;
}
else if (convKnowledgeLearnDetail.CourseChapterId  ==  AttributeName[intIndex])
{
return mstrCourseChapterId;
}
else if (convKnowledgeLearnDetail.LearnDate  ==  AttributeName[intIndex])
{
return mstrLearnDate;
}
else if (convKnowledgeLearnDetail.LearnModeId  ==  AttributeName[intIndex])
{
return mstrLearnModeId;
}
else if (convKnowledgeLearnDetail.LearnModeName  ==  AttributeName[intIndex])
{
return mstrLearnModeName;
}
else if (convKnowledgeLearnDetail.IdCase  ==  AttributeName[intIndex])
{
return mstrIdCase;
}
else if (convKnowledgeLearnDetail.IdCaseType  ==  AttributeName[intIndex])
{
return mstrIdCaseType;
}
else if (convKnowledgeLearnDetail.IsMaster  ==  AttributeName[intIndex])
{
return mbolIsMaster;
}
else if (convKnowledgeLearnDetail.MasterDegree  ==  AttributeName[intIndex])
{
return mintMasterDegree;
}
else if (convKnowledgeLearnDetail.MarkerId  ==  AttributeName[intIndex])
{
return mstrMarkerId;
}
else if (convKnowledgeLearnDetail.MarkTime  ==  AttributeName[intIndex])
{
return mstrMarkTime;
}
else if (convKnowledgeLearnDetail.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convKnowledgeLearnDetail.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convKnowledgeLearnDetail.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convKnowledgeLearnDetail.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convKnowledgeLearnDetail.mId);
}
else if (convKnowledgeLearnDetail.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.UserId);
}
else if (convKnowledgeLearnDetail.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.UserName);
}
else if (convKnowledgeLearnDetail.CourseKnowledgeId  ==  AttributeName[intIndex])
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.CourseKnowledgeId);
}
else if (convKnowledgeLearnDetail.KnowledgeName  ==  AttributeName[intIndex])
{
mstrKnowledgeName = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.KnowledgeName);
}
else if (convKnowledgeLearnDetail.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.CourseId);
}
else if (convKnowledgeLearnDetail.CourseName  ==  AttributeName[intIndex])
{
mstrCourseName = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.CourseName);
}
else if (convKnowledgeLearnDetail.CourseChapterId  ==  AttributeName[intIndex])
{
mstrCourseChapterId = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.CourseChapterId);
}
else if (convKnowledgeLearnDetail.LearnDate  ==  AttributeName[intIndex])
{
mstrLearnDate = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.LearnDate);
}
else if (convKnowledgeLearnDetail.LearnModeId  ==  AttributeName[intIndex])
{
mstrLearnModeId = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.LearnModeId);
}
else if (convKnowledgeLearnDetail.LearnModeName  ==  AttributeName[intIndex])
{
mstrLearnModeName = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.LearnModeName);
}
else if (convKnowledgeLearnDetail.IdCase  ==  AttributeName[intIndex])
{
mstrIdCase = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.IdCase);
}
else if (convKnowledgeLearnDetail.IdCaseType  ==  AttributeName[intIndex])
{
mstrIdCaseType = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.IdCaseType);
}
else if (convKnowledgeLearnDetail.IsMaster  ==  AttributeName[intIndex])
{
mbolIsMaster = TransNullToBool(value.ToString());
 AddUpdatedFld(convKnowledgeLearnDetail.IsMaster);
}
else if (convKnowledgeLearnDetail.MasterDegree  ==  AttributeName[intIndex])
{
mintMasterDegree = TransNullToInt(value.ToString());
 AddUpdatedFld(convKnowledgeLearnDetail.MasterDegree);
}
else if (convKnowledgeLearnDetail.MarkerId  ==  AttributeName[intIndex])
{
mstrMarkerId = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.MarkerId);
}
else if (convKnowledgeLearnDetail.MarkTime  ==  AttributeName[intIndex])
{
mstrMarkTime = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.MarkTime);
}
else if (convKnowledgeLearnDetail.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.UpdDate);
}
else if (convKnowledgeLearnDetail.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.UpdUser);
}
else if (convKnowledgeLearnDetail.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convKnowledgeLearnDetail.Memo);
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
 AddUpdatedFld(convKnowledgeLearnDetail.mId);
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
 AddUpdatedFld(convKnowledgeLearnDetail.UserId);
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
 AddUpdatedFld(convKnowledgeLearnDetail.UserName);
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
 AddUpdatedFld(convKnowledgeLearnDetail.CourseKnowledgeId);
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
 AddUpdatedFld(convKnowledgeLearnDetail.KnowledgeName);
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
 AddUpdatedFld(convKnowledgeLearnDetail.CourseId);
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
 AddUpdatedFld(convKnowledgeLearnDetail.CourseName);
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
 AddUpdatedFld(convKnowledgeLearnDetail.CourseChapterId);
}
}
/// <summary>
/// 学习日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LearnDate
{
get
{
return mstrLearnDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLearnDate = value;
}
else
{
 mstrLearnDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convKnowledgeLearnDetail.LearnDate);
}
}
/// <summary>
/// 学习模式Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LearnModeId
{
get
{
return mstrLearnModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLearnModeId = value;
}
else
{
 mstrLearnModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convKnowledgeLearnDetail.LearnModeId);
}
}
/// <summary>
/// 学习模式名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LearnModeName
{
get
{
return mstrLearnModeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLearnModeName = value;
}
else
{
 mstrLearnModeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convKnowledgeLearnDetail.LearnModeName);
}
}
/// <summary>
/// 案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCase
{
get
{
return mstrIdCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCase = value;
}
else
{
 mstrIdCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convKnowledgeLearnDetail.IdCase);
}
}
/// <summary>
/// 案例类型流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCaseType
{
get
{
return mstrIdCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCaseType = value;
}
else
{
 mstrIdCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(convKnowledgeLearnDetail.IdCaseType);
}
}
/// <summary>
/// 是否掌握(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsMaster
{
get
{
return mbolIsMaster;
}
set
{
 mbolIsMaster = value;
//记录修改过的字段
 AddUpdatedFld(convKnowledgeLearnDetail.IsMaster);
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
 AddUpdatedFld(convKnowledgeLearnDetail.MasterDegree);
}
}
/// <summary>
/// 打分者(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MarkerId
{
get
{
return mstrMarkerId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMarkerId = value;
}
else
{
 mstrMarkerId = value;
}
//记录修改过的字段
 AddUpdatedFld(convKnowledgeLearnDetail.MarkerId);
}
}
/// <summary>
/// 批改时间(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MarkTime
{
get
{
return mstrMarkTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMarkTime = value;
}
else
{
 mstrMarkTime = value;
}
//记录修改过的字段
 AddUpdatedFld(convKnowledgeLearnDetail.MarkTime);
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
 AddUpdatedFld(convKnowledgeLearnDetail.UpdDate);
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
 AddUpdatedFld(convKnowledgeLearnDetail.UpdUser);
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
 AddUpdatedFld(convKnowledgeLearnDetail.Memo);
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
 /// v知识点学习情况(vKnowledgeLearnDetail)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convKnowledgeLearnDetail
{
public const string _CurrTabName = "vKnowledgeLearnDetail"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserId", "UserName", "CourseKnowledgeId", "KnowledgeName", "CourseId", "CourseName", "CourseChapterId", "LearnDate", "LearnModeId", "LearnModeName", "IdCase", "IdCaseType", "IsMaster", "MasterDegree", "MarkerId", "MarkTime", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"LearnDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LearnDate = "LearnDate";    //学习日期

 /// <summary>
 /// 常量:"LearnModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LearnModeId = "LearnModeId";    //学习模式Id

 /// <summary>
 /// 常量:"LearnModeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LearnModeName = "LearnModeName";    //学习模式名

 /// <summary>
 /// 常量:"IdCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCase = "IdCase";    //案例流水号

 /// <summary>
 /// 常量:"IdCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCaseType = "IdCaseType";    //案例类型流水号

 /// <summary>
 /// 常量:"IsMaster"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsMaster = "IsMaster";    //是否掌握

 /// <summary>
 /// 常量:"MasterDegree"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MasterDegree = "MasterDegree";    //掌握程度

 /// <summary>
 /// 常量:"MarkerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MarkerId = "MarkerId";    //打分者

 /// <summary>
 /// 常量:"MarkTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MarkTime = "MarkTime";    //批改时间

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