
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPubClassCase_Resource_RelEN
 表名:vPubClassCase_Resource_Rel(01120407)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:39
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
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
 /// 表vPubClassCase_Resource_Rel的关键字(IdPubClassCaseResourceRel)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdPubClassCaseResourceRel_vPubClassCase_Resource_Rel
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngIdPubClassCaseResourceRel">表关键字</param>
public K_IdPubClassCaseResourceRel_vPubClassCase_Resource_Rel(long lngIdPubClassCaseResourceRel)
{
if (IsValid(lngIdPubClassCaseResourceRel)) Value = lngIdPubClassCaseResourceRel;
else
{
Value = 0;
}
}
private static bool IsValid(long lngIdPubClassCaseResourceRel)
{
if (lngIdPubClassCaseResourceRel == 0) return false;
if (lngIdPubClassCaseResourceRel == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdPubClassCaseResourceRel_vPubClassCase_Resource_Rel]类型的对象</returns>
public static implicit operator K_IdPubClassCaseResourceRel_vPubClassCase_Resource_Rel(long value)
{
return new K_IdPubClassCaseResourceRel_vPubClassCase_Resource_Rel(value);
}
}
 /// <summary>
 /// v案例与资源关系(vPubClassCase_Resource_Rel)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPubClassCase_Resource_RelEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPubClassCase_Resource_Rel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdPubClassCaseResourceRel"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 24;
public static string[] AttributeName = new string[] {"IdPubClassCaseResourceRel", "IdPubClassCase", "PubClassCaseID", "PubClassCaseName", "PubClassCaseExecutor", "DisciplineName", "PubCaseTypeName", "StudyLevelName", "Introduction", "IsDualVideo", "RecommendedDegreeId", "RecommendedDegreeName", "BrowseCount4Case", "IdResource", "ResourceID", "ResourceName", "IsExistFile", "FileNewName", "FileOldName", "IsMain", "IndexNO", "Memo", "IsVisible", "BrowseCount"};

protected long mlngIdPubClassCaseResourceRel;    //案例与资源关系表流水号
protected string mstrIdPubClassCase;    //案例流水号
protected string mstrPubClassCaseID;    //案例ID
protected string mstrPubClassCaseName;    //案例课题名称
protected string mstrPubClassCaseExecutor;    //案例执教者
protected string mstrDisciplineName;    //学科名称
protected string mstrPubCaseTypeName;    //公开课案例类型名称
protected string mstrStudyLevelName;    //学段名称
protected string mstrIntroduction;    //简要介绍
protected bool mbolIsDualVideo;    //是否双视频
protected string mstrRecommendedDegreeId;    //推荐度Id
protected string mstrRecommendedDegreeName;    //推荐度名称
protected int? mintBrowseCount4Case;    //课例浏览次数
protected string mstrIdResource;    //资源流水号
protected string mstrResourceID;    //资源ID
protected string mstrResourceName;    //资源名称
protected bool mbolIsExistFile;    //是否存在文件
protected string mstrFileNewName;    //新文件名
protected string mstrFileOldName;    //旧文件名
protected bool mbolIsMain;    //是否主资源
protected int? mintIndexNO;    //序号
protected string mstrMemo;    //备注
protected bool mbolIsVisible;    //是否显示
protected int? mintBrowseCount;    //浏览次数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvPubClassCase_Resource_RelEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPubClassCaseResourceRel");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngIdPubClassCaseResourceRel">关键字:案例与资源关系表流水号</param>
public clsvPubClassCase_Resource_RelEN(long lngIdPubClassCaseResourceRel)
 {
 if (lngIdPubClassCaseResourceRel  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngIdPubClassCaseResourceRel = lngIdPubClassCaseResourceRel;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdPubClassCaseResourceRel");
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
if (strAttributeName  ==  convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel)
{
return mlngIdPubClassCaseResourceRel;
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.IdPubClassCase)
{
return mstrIdPubClassCase;
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.PubClassCaseID)
{
return mstrPubClassCaseID;
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.PubClassCaseName)
{
return mstrPubClassCaseName;
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.PubClassCaseExecutor)
{
return mstrPubClassCaseExecutor;
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.DisciplineName)
{
return mstrDisciplineName;
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.PubCaseTypeName)
{
return mstrPubCaseTypeName;
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.StudyLevelName)
{
return mstrStudyLevelName;
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.Introduction)
{
return mstrIntroduction;
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.IsDualVideo)
{
return mbolIsDualVideo;
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.RecommendedDegreeId)
{
return mstrRecommendedDegreeId;
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.RecommendedDegreeName)
{
return mstrRecommendedDegreeName;
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.BrowseCount4Case)
{
return mintBrowseCount4Case;
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.IdResource)
{
return mstrIdResource;
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.ResourceID)
{
return mstrResourceID;
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.ResourceName)
{
return mstrResourceName;
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.IsExistFile)
{
return mbolIsExistFile;
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.FileNewName)
{
return mstrFileNewName;
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.FileOldName)
{
return mstrFileOldName;
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.IsMain)
{
return mbolIsMain;
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.IndexNO)
{
return mintIndexNO;
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.BrowseCount)
{
return mintBrowseCount;
}
return null;
}
set
{
if (strAttributeName  ==  convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel)
{
mlngIdPubClassCaseResourceRel = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel);
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.IdPubClassCase)
{
mstrIdPubClassCase = value.ToString();
 AddUpdatedFld(convPubClassCase_Resource_Rel.IdPubClassCase);
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.PubClassCaseID)
{
mstrPubClassCaseID = value.ToString();
 AddUpdatedFld(convPubClassCase_Resource_Rel.PubClassCaseID);
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.PubClassCaseName)
{
mstrPubClassCaseName = value.ToString();
 AddUpdatedFld(convPubClassCase_Resource_Rel.PubClassCaseName);
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.PubClassCaseExecutor)
{
mstrPubClassCaseExecutor = value.ToString();
 AddUpdatedFld(convPubClassCase_Resource_Rel.PubClassCaseExecutor);
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.DisciplineName)
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convPubClassCase_Resource_Rel.DisciplineName);
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.PubCaseTypeName)
{
mstrPubCaseTypeName = value.ToString();
 AddUpdatedFld(convPubClassCase_Resource_Rel.PubCaseTypeName);
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.StudyLevelName)
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convPubClassCase_Resource_Rel.StudyLevelName);
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.Introduction)
{
mstrIntroduction = value.ToString();
 AddUpdatedFld(convPubClassCase_Resource_Rel.Introduction);
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.IsDualVideo)
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubClassCase_Resource_Rel.IsDualVideo);
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.RecommendedDegreeId)
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convPubClassCase_Resource_Rel.RecommendedDegreeId);
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.RecommendedDegreeName)
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convPubClassCase_Resource_Rel.RecommendedDegreeName);
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.BrowseCount4Case)
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubClassCase_Resource_Rel.BrowseCount4Case);
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.IdResource)
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convPubClassCase_Resource_Rel.IdResource);
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.ResourceID)
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convPubClassCase_Resource_Rel.ResourceID);
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.ResourceName)
{
mstrResourceName = value.ToString();
 AddUpdatedFld(convPubClassCase_Resource_Rel.ResourceName);
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.IsExistFile)
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubClassCase_Resource_Rel.IsExistFile);
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.FileNewName)
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convPubClassCase_Resource_Rel.FileNewName);
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.FileOldName)
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convPubClassCase_Resource_Rel.FileOldName);
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.IsMain)
{
mbolIsMain = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubClassCase_Resource_Rel.IsMain);
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.IndexNO)
{
mintIndexNO = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubClassCase_Resource_Rel.IndexNO);
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPubClassCase_Resource_Rel.Memo);
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubClassCase_Resource_Rel.IsVisible);
}
else if (strAttributeName  ==  convPubClassCase_Resource_Rel.BrowseCount)
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubClassCase_Resource_Rel.BrowseCount);
}
}
}
public object this[int intIndex]
{
get
{
if (convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel  ==  AttributeName[intIndex])
{
return mlngIdPubClassCaseResourceRel;
}
else if (convPubClassCase_Resource_Rel.IdPubClassCase  ==  AttributeName[intIndex])
{
return mstrIdPubClassCase;
}
else if (convPubClassCase_Resource_Rel.PubClassCaseID  ==  AttributeName[intIndex])
{
return mstrPubClassCaseID;
}
else if (convPubClassCase_Resource_Rel.PubClassCaseName  ==  AttributeName[intIndex])
{
return mstrPubClassCaseName;
}
else if (convPubClassCase_Resource_Rel.PubClassCaseExecutor  ==  AttributeName[intIndex])
{
return mstrPubClassCaseExecutor;
}
else if (convPubClassCase_Resource_Rel.DisciplineName  ==  AttributeName[intIndex])
{
return mstrDisciplineName;
}
else if (convPubClassCase_Resource_Rel.PubCaseTypeName  ==  AttributeName[intIndex])
{
return mstrPubCaseTypeName;
}
else if (convPubClassCase_Resource_Rel.StudyLevelName  ==  AttributeName[intIndex])
{
return mstrStudyLevelName;
}
else if (convPubClassCase_Resource_Rel.Introduction  ==  AttributeName[intIndex])
{
return mstrIntroduction;
}
else if (convPubClassCase_Resource_Rel.IsDualVideo  ==  AttributeName[intIndex])
{
return mbolIsDualVideo;
}
else if (convPubClassCase_Resource_Rel.RecommendedDegreeId  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeId;
}
else if (convPubClassCase_Resource_Rel.RecommendedDegreeName  ==  AttributeName[intIndex])
{
return mstrRecommendedDegreeName;
}
else if (convPubClassCase_Resource_Rel.BrowseCount4Case  ==  AttributeName[intIndex])
{
return mintBrowseCount4Case;
}
else if (convPubClassCase_Resource_Rel.IdResource  ==  AttributeName[intIndex])
{
return mstrIdResource;
}
else if (convPubClassCase_Resource_Rel.ResourceID  ==  AttributeName[intIndex])
{
return mstrResourceID;
}
else if (convPubClassCase_Resource_Rel.ResourceName  ==  AttributeName[intIndex])
{
return mstrResourceName;
}
else if (convPubClassCase_Resource_Rel.IsExistFile  ==  AttributeName[intIndex])
{
return mbolIsExistFile;
}
else if (convPubClassCase_Resource_Rel.FileNewName  ==  AttributeName[intIndex])
{
return mstrFileNewName;
}
else if (convPubClassCase_Resource_Rel.FileOldName  ==  AttributeName[intIndex])
{
return mstrFileOldName;
}
else if (convPubClassCase_Resource_Rel.IsMain  ==  AttributeName[intIndex])
{
return mbolIsMain;
}
else if (convPubClassCase_Resource_Rel.IndexNO  ==  AttributeName[intIndex])
{
return mintIndexNO;
}
else if (convPubClassCase_Resource_Rel.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convPubClassCase_Resource_Rel.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convPubClassCase_Resource_Rel.BrowseCount  ==  AttributeName[intIndex])
{
return mintBrowseCount;
}
return null;
}
set
{
if (convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel  ==  AttributeName[intIndex])
{
mlngIdPubClassCaseResourceRel = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel);
}
else if (convPubClassCase_Resource_Rel.IdPubClassCase  ==  AttributeName[intIndex])
{
mstrIdPubClassCase = value.ToString();
 AddUpdatedFld(convPubClassCase_Resource_Rel.IdPubClassCase);
}
else if (convPubClassCase_Resource_Rel.PubClassCaseID  ==  AttributeName[intIndex])
{
mstrPubClassCaseID = value.ToString();
 AddUpdatedFld(convPubClassCase_Resource_Rel.PubClassCaseID);
}
else if (convPubClassCase_Resource_Rel.PubClassCaseName  ==  AttributeName[intIndex])
{
mstrPubClassCaseName = value.ToString();
 AddUpdatedFld(convPubClassCase_Resource_Rel.PubClassCaseName);
}
else if (convPubClassCase_Resource_Rel.PubClassCaseExecutor  ==  AttributeName[intIndex])
{
mstrPubClassCaseExecutor = value.ToString();
 AddUpdatedFld(convPubClassCase_Resource_Rel.PubClassCaseExecutor);
}
else if (convPubClassCase_Resource_Rel.DisciplineName  ==  AttributeName[intIndex])
{
mstrDisciplineName = value.ToString();
 AddUpdatedFld(convPubClassCase_Resource_Rel.DisciplineName);
}
else if (convPubClassCase_Resource_Rel.PubCaseTypeName  ==  AttributeName[intIndex])
{
mstrPubCaseTypeName = value.ToString();
 AddUpdatedFld(convPubClassCase_Resource_Rel.PubCaseTypeName);
}
else if (convPubClassCase_Resource_Rel.StudyLevelName  ==  AttributeName[intIndex])
{
mstrStudyLevelName = value.ToString();
 AddUpdatedFld(convPubClassCase_Resource_Rel.StudyLevelName);
}
else if (convPubClassCase_Resource_Rel.Introduction  ==  AttributeName[intIndex])
{
mstrIntroduction = value.ToString();
 AddUpdatedFld(convPubClassCase_Resource_Rel.Introduction);
}
else if (convPubClassCase_Resource_Rel.IsDualVideo  ==  AttributeName[intIndex])
{
mbolIsDualVideo = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubClassCase_Resource_Rel.IsDualVideo);
}
else if (convPubClassCase_Resource_Rel.RecommendedDegreeId  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeId = value.ToString();
 AddUpdatedFld(convPubClassCase_Resource_Rel.RecommendedDegreeId);
}
else if (convPubClassCase_Resource_Rel.RecommendedDegreeName  ==  AttributeName[intIndex])
{
mstrRecommendedDegreeName = value.ToString();
 AddUpdatedFld(convPubClassCase_Resource_Rel.RecommendedDegreeName);
}
else if (convPubClassCase_Resource_Rel.BrowseCount4Case  ==  AttributeName[intIndex])
{
mintBrowseCount4Case = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubClassCase_Resource_Rel.BrowseCount4Case);
}
else if (convPubClassCase_Resource_Rel.IdResource  ==  AttributeName[intIndex])
{
mstrIdResource = value.ToString();
 AddUpdatedFld(convPubClassCase_Resource_Rel.IdResource);
}
else if (convPubClassCase_Resource_Rel.ResourceID  ==  AttributeName[intIndex])
{
mstrResourceID = value.ToString();
 AddUpdatedFld(convPubClassCase_Resource_Rel.ResourceID);
}
else if (convPubClassCase_Resource_Rel.ResourceName  ==  AttributeName[intIndex])
{
mstrResourceName = value.ToString();
 AddUpdatedFld(convPubClassCase_Resource_Rel.ResourceName);
}
else if (convPubClassCase_Resource_Rel.IsExistFile  ==  AttributeName[intIndex])
{
mbolIsExistFile = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubClassCase_Resource_Rel.IsExistFile);
}
else if (convPubClassCase_Resource_Rel.FileNewName  ==  AttributeName[intIndex])
{
mstrFileNewName = value.ToString();
 AddUpdatedFld(convPubClassCase_Resource_Rel.FileNewName);
}
else if (convPubClassCase_Resource_Rel.FileOldName  ==  AttributeName[intIndex])
{
mstrFileOldName = value.ToString();
 AddUpdatedFld(convPubClassCase_Resource_Rel.FileOldName);
}
else if (convPubClassCase_Resource_Rel.IsMain  ==  AttributeName[intIndex])
{
mbolIsMain = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubClassCase_Resource_Rel.IsMain);
}
else if (convPubClassCase_Resource_Rel.IndexNO  ==  AttributeName[intIndex])
{
mintIndexNO = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubClassCase_Resource_Rel.IndexNO);
}
else if (convPubClassCase_Resource_Rel.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPubClassCase_Resource_Rel.Memo);
}
else if (convPubClassCase_Resource_Rel.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convPubClassCase_Resource_Rel.IsVisible);
}
else if (convPubClassCase_Resource_Rel.BrowseCount  ==  AttributeName[intIndex])
{
mintBrowseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPubClassCase_Resource_Rel.BrowseCount);
}
}
}

/// <summary>
/// 案例与资源关系表流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long IdPubClassCaseResourceRel
{
get
{
return mlngIdPubClassCaseResourceRel;
}
set
{
 mlngIdPubClassCaseResourceRel = value;
//记录修改过的字段
 AddUpdatedFld(convPubClassCase_Resource_Rel.IdPubClassCaseResourceRel);
}
}
/// <summary>
/// 案例流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdPubClassCase
{
get
{
return mstrIdPubClassCase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdPubClassCase = value;
}
else
{
 mstrIdPubClassCase = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase_Resource_Rel.IdPubClassCase);
}
}
/// <summary>
/// 案例ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseID
{
get
{
return mstrPubClassCaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseID = value;
}
else
{
 mstrPubClassCaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase_Resource_Rel.PubClassCaseID);
}
}
/// <summary>
/// 案例课题名称(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseName
{
get
{
return mstrPubClassCaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseName = value;
}
else
{
 mstrPubClassCaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase_Resource_Rel.PubClassCaseName);
}
}
/// <summary>
/// 案例执教者(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubClassCaseExecutor
{
get
{
return mstrPubClassCaseExecutor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubClassCaseExecutor = value;
}
else
{
 mstrPubClassCaseExecutor = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase_Resource_Rel.PubClassCaseExecutor);
}
}
/// <summary>
/// 学科名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DisciplineName
{
get
{
return mstrDisciplineName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDisciplineName = value;
}
else
{
 mstrDisciplineName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase_Resource_Rel.DisciplineName);
}
}
/// <summary>
/// 公开课案例类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubCaseTypeName
{
get
{
return mstrPubCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubCaseTypeName = value;
}
else
{
 mstrPubCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase_Resource_Rel.PubCaseTypeName);
}
}
/// <summary>
/// 学段名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StudyLevelName
{
get
{
return mstrStudyLevelName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStudyLevelName = value;
}
else
{
 mstrStudyLevelName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase_Resource_Rel.StudyLevelName);
}
}
/// <summary>
/// 简要介绍(说明:;字段类型:varchar;字段长度:4000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Introduction
{
get
{
return mstrIntroduction;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIntroduction = value;
}
else
{
 mstrIntroduction = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase_Resource_Rel.Introduction);
}
}
/// <summary>
/// 是否双视频(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDualVideo
{
get
{
return mbolIsDualVideo;
}
set
{
 mbolIsDualVideo = value;
//记录修改过的字段
 AddUpdatedFld(convPubClassCase_Resource_Rel.IsDualVideo);
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
 AddUpdatedFld(convPubClassCase_Resource_Rel.RecommendedDegreeId);
}
}
/// <summary>
/// 推荐度名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RecommendedDegreeName
{
get
{
return mstrRecommendedDegreeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRecommendedDegreeName = value;
}
else
{
 mstrRecommendedDegreeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase_Resource_Rel.RecommendedDegreeName);
}
}
/// <summary>
/// 课例浏览次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? BrowseCount4Case
{
get
{
return mintBrowseCount4Case;
}
set
{
 mintBrowseCount4Case = value;
//记录修改过的字段
 AddUpdatedFld(convPubClassCase_Resource_Rel.BrowseCount4Case);
}
}
/// <summary>
/// 资源流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdResource
{
get
{
return mstrIdResource;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdResource = value;
}
else
{
 mstrIdResource = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase_Resource_Rel.IdResource);
}
}
/// <summary>
/// 资源ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResourceID
{
get
{
return mstrResourceID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResourceID = value;
}
else
{
 mstrResourceID = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase_Resource_Rel.ResourceID);
}
}
/// <summary>
/// 资源名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResourceName
{
get
{
return mstrResourceName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResourceName = value;
}
else
{
 mstrResourceName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase_Resource_Rel.ResourceName);
}
}
/// <summary>
/// 是否存在文件(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsExistFile
{
get
{
return mbolIsExistFile;
}
set
{
 mbolIsExistFile = value;
//记录修改过的字段
 AddUpdatedFld(convPubClassCase_Resource_Rel.IsExistFile);
}
}
/// <summary>
/// 新文件名(说明:;字段类型:varchar;字段长度:530;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileNewName
{
get
{
return mstrFileNewName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileNewName = value;
}
else
{
 mstrFileNewName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase_Resource_Rel.FileNewName);
}
}
/// <summary>
/// 旧文件名(说明:;字段类型:varchar;字段长度:530;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileOldName
{
get
{
return mstrFileOldName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileOldName = value;
}
else
{
 mstrFileOldName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPubClassCase_Resource_Rel.FileOldName);
}
}
/// <summary>
/// 是否主资源(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsMain
{
get
{
return mbolIsMain;
}
set
{
 mbolIsMain = value;
//记录修改过的字段
 AddUpdatedFld(convPubClassCase_Resource_Rel.IsMain);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? IndexNO
{
get
{
return mintIndexNO;
}
set
{
 mintIndexNO = value;
//记录修改过的字段
 AddUpdatedFld(convPubClassCase_Resource_Rel.IndexNO);
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
 AddUpdatedFld(convPubClassCase_Resource_Rel.Memo);
}
}
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsVisible
{
get
{
return mbolIsVisible;
}
set
{
 mbolIsVisible = value;
//记录修改过的字段
 AddUpdatedFld(convPubClassCase_Resource_Rel.IsVisible);
}
}
/// <summary>
/// 浏览次数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? BrowseCount
{
get
{
return mintBrowseCount;
}
set
{
 mintBrowseCount = value;
//记录修改过的字段
 AddUpdatedFld(convPubClassCase_Resource_Rel.BrowseCount);
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
  return mlngIdPubClassCaseResourceRel.ToString();
 }
 }
}
 /// <summary>
 /// v案例与资源关系(vPubClassCase_Resource_Rel)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPubClassCase_Resource_Rel
{
public const string _CurrTabName = "vPubClassCase_Resource_Rel"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdPubClassCaseResourceRel"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdPubClassCaseResourceRel", "IdPubClassCase", "PubClassCaseID", "PubClassCaseName", "PubClassCaseExecutor", "DisciplineName", "PubCaseTypeName", "StudyLevelName", "Introduction", "IsDualVideo", "RecommendedDegreeId", "RecommendedDegreeName", "BrowseCount4Case", "IdResource", "ResourceID", "ResourceName", "IsExistFile", "FileNewName", "FileOldName", "IsMain", "IndexNO", "Memo", "IsVisible", "BrowseCount"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdPubClassCaseResourceRel"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubClassCaseResourceRel = "IdPubClassCaseResourceRel";    //案例与资源关系表流水号

 /// <summary>
 /// 常量:"IdPubClassCase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPubClassCase = "IdPubClassCase";    //案例流水号

 /// <summary>
 /// 常量:"PubClassCaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseID = "PubClassCaseID";    //案例ID

 /// <summary>
 /// 常量:"PubClassCaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseName = "PubClassCaseName";    //案例课题名称

 /// <summary>
 /// 常量:"PubClassCaseExecutor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubClassCaseExecutor = "PubClassCaseExecutor";    //案例执教者

 /// <summary>
 /// 常量:"DisciplineName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DisciplineName = "DisciplineName";    //学科名称

 /// <summary>
 /// 常量:"PubCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubCaseTypeName = "PubCaseTypeName";    //公开课案例类型名称

 /// <summary>
 /// 常量:"StudyLevelName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StudyLevelName = "StudyLevelName";    //学段名称

 /// <summary>
 /// 常量:"Introduction"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Introduction = "Introduction";    //简要介绍

 /// <summary>
 /// 常量:"IsDualVideo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDualVideo = "IsDualVideo";    //是否双视频

 /// <summary>
 /// 常量:"RecommendedDegreeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RecommendedDegreeId = "RecommendedDegreeId";    //推荐度Id

 /// <summary>
 /// 常量:"RecommendedDegreeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RecommendedDegreeName = "RecommendedDegreeName";    //推荐度名称

 /// <summary>
 /// 常量:"BrowseCount4Case"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount4Case = "BrowseCount4Case";    //课例浏览次数

 /// <summary>
 /// 常量:"IdResource"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdResource = "IdResource";    //资源流水号

 /// <summary>
 /// 常量:"ResourceID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceID = "ResourceID";    //资源ID

 /// <summary>
 /// 常量:"ResourceName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResourceName = "ResourceName";    //资源名称

 /// <summary>
 /// 常量:"IsExistFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsExistFile = "IsExistFile";    //是否存在文件

 /// <summary>
 /// 常量:"FileNewName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileNewName = "FileNewName";    //新文件名

 /// <summary>
 /// 常量:"FileOldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileOldName = "FileOldName";    //旧文件名

 /// <summary>
 /// 常量:"IsMain"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsMain = "IsMain";    //是否主资源

 /// <summary>
 /// 常量:"IndexNO"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IndexNO = "IndexNO";    //序号

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"BrowseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BrowseCount = "BrowseCount";    //浏览次数
}

}