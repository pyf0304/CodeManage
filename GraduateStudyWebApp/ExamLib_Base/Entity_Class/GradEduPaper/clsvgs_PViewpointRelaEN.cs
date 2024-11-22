
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PViewpointRelaEN
 表名:vgs_PViewpointRela(01120669)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:59:22
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
 /// 表vgs_PViewpointRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vgs_PViewpointRela
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
public K_mId_vgs_PViewpointRela(long lngmId)
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
 /// <returns>返回:[K_mId_vgs_PViewpointRela]类型的对象</returns>
public static implicit operator K_mId_vgs_PViewpointRela(long value)
{
return new K_mId_vgs_PViewpointRela(value);
}
}
 /// <summary>
 /// 论文观点关系视图(vgs_PViewpointRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvgs_PViewpointRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vgs_PViewpointRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 31;
public static string[] AttributeName = new string[] {"mId", "PaperId", "PaperTitle", "PaperTypeId", "SectionId", "SectionName", "ViewpointId", "ViewpointName", "ViewpointContent", "ViewpointTypeId", "ViewpointTypeName", "Reason", "VPProposePeople", "IsSubmit", "UserTypeId", "UserTypeName", "AppraiseCount", "Score", "StuScore", "TeaScore", "OkCount", "CitationCount", "VersionCount", "ProposePeople", "UpdDate", "UpdUser", "Memo", "ViewsDate", "ViewsUserId", "CreateDate", "ShareId"};

protected long mlngmId;    //mId
protected string mstrPaperId;    //论文Id
protected string mstrPaperTitle;    //论文标题
protected string mstrPaperTypeId;    //论文类型Id
protected string mstrSectionId;    //节Id
protected string mstrSectionName;    //节名
protected string mstrViewpointId;    //观点Id
protected string mstrViewpointName;    //观点名称
protected string mstrViewpointContent;    //观点内容
protected string mstrViewpointTypeId;    //观点类型Id
protected string mstrViewpointTypeName;    //观点类型名
protected string mstrReason;    //理由
protected string mstrVPProposePeople;    //观点提出人
protected bool mbolIsSubmit;    //是否提交
protected string mstrUserTypeId;    //用户类型Id
protected string mstrUserTypeName;    //用户类型名称
protected int? mintAppraiseCount;    //评论数
protected float? mfltScore;    //评分
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected int? mintOkCount;    //点赞统计
protected int? mintCitationCount;    //引用统计
protected int? mintVersionCount;    //版本统计
protected string mstrProposePeople;    //提出人
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrViewsDate;    //ViewsDate
protected string mstrViewsUserId;    //ViewsUserId
protected string mstrCreateDate;    //建立日期
protected string mstrShareId;    //分享Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvgs_PViewpointRelaEN()
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
public clsvgs_PViewpointRelaEN(long lngmId)
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
if (strAttributeName  ==  convgs_PViewpointRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convgs_PViewpointRela.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convgs_PViewpointRela.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convgs_PViewpointRela.PaperTypeId)
{
return mstrPaperTypeId;
}
else if (strAttributeName  ==  convgs_PViewpointRela.SectionId)
{
return mstrSectionId;
}
else if (strAttributeName  ==  convgs_PViewpointRela.SectionName)
{
return mstrSectionName;
}
else if (strAttributeName  ==  convgs_PViewpointRela.ViewpointId)
{
return mstrViewpointId;
}
else if (strAttributeName  ==  convgs_PViewpointRela.ViewpointName)
{
return mstrViewpointName;
}
else if (strAttributeName  ==  convgs_PViewpointRela.ViewpointContent)
{
return mstrViewpointContent;
}
else if (strAttributeName  ==  convgs_PViewpointRela.ViewpointTypeId)
{
return mstrViewpointTypeId;
}
else if (strAttributeName  ==  convgs_PViewpointRela.ViewpointTypeName)
{
return mstrViewpointTypeName;
}
else if (strAttributeName  ==  convgs_PViewpointRela.Reason)
{
return mstrReason;
}
else if (strAttributeName  ==  convgs_PViewpointRela.VPProposePeople)
{
return mstrVPProposePeople;
}
else if (strAttributeName  ==  convgs_PViewpointRela.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convgs_PViewpointRela.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  convgs_PViewpointRela.UserTypeName)
{
return mstrUserTypeName;
}
else if (strAttributeName  ==  convgs_PViewpointRela.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convgs_PViewpointRela.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convgs_PViewpointRela.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convgs_PViewpointRela.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convgs_PViewpointRela.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  convgs_PViewpointRela.CitationCount)
{
return mintCitationCount;
}
else if (strAttributeName  ==  convgs_PViewpointRela.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  convgs_PViewpointRela.ProposePeople)
{
return mstrProposePeople;
}
else if (strAttributeName  ==  convgs_PViewpointRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convgs_PViewpointRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convgs_PViewpointRela.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convgs_PViewpointRela.ViewsDate)
{
return mstrViewsDate;
}
else if (strAttributeName  ==  convgs_PViewpointRela.ViewsUserId)
{
return mstrViewsUserId;
}
else if (strAttributeName  ==  convgs_PViewpointRela.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convgs_PViewpointRela.ShareId)
{
return mstrShareId;
}
return null;
}
set
{
if (strAttributeName  ==  convgs_PViewpointRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PViewpointRela.mId);
}
else if (strAttributeName  ==  convgs_PViewpointRela.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.PaperId);
}
else if (strAttributeName  ==  convgs_PViewpointRela.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.PaperTitle);
}
else if (strAttributeName  ==  convgs_PViewpointRela.PaperTypeId)
{
mstrPaperTypeId = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.PaperTypeId);
}
else if (strAttributeName  ==  convgs_PViewpointRela.SectionId)
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.SectionId);
}
else if (strAttributeName  ==  convgs_PViewpointRela.SectionName)
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.SectionName);
}
else if (strAttributeName  ==  convgs_PViewpointRela.ViewpointId)
{
mstrViewpointId = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.ViewpointId);
}
else if (strAttributeName  ==  convgs_PViewpointRela.ViewpointName)
{
mstrViewpointName = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.ViewpointName);
}
else if (strAttributeName  ==  convgs_PViewpointRela.ViewpointContent)
{
mstrViewpointContent = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.ViewpointContent);
}
else if (strAttributeName  ==  convgs_PViewpointRela.ViewpointTypeId)
{
mstrViewpointTypeId = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.ViewpointTypeId);
}
else if (strAttributeName  ==  convgs_PViewpointRela.ViewpointTypeName)
{
mstrViewpointTypeName = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.ViewpointTypeName);
}
else if (strAttributeName  ==  convgs_PViewpointRela.Reason)
{
mstrReason = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.Reason);
}
else if (strAttributeName  ==  convgs_PViewpointRela.VPProposePeople)
{
mstrVPProposePeople = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.VPProposePeople);
}
else if (strAttributeName  ==  convgs_PViewpointRela.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convgs_PViewpointRela.IsSubmit);
}
else if (strAttributeName  ==  convgs_PViewpointRela.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.UserTypeId);
}
else if (strAttributeName  ==  convgs_PViewpointRela.UserTypeName)
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.UserTypeName);
}
else if (strAttributeName  ==  convgs_PViewpointRela.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PViewpointRela.AppraiseCount);
}
else if (strAttributeName  ==  convgs_PViewpointRela.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PViewpointRela.Score);
}
else if (strAttributeName  ==  convgs_PViewpointRela.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PViewpointRela.StuScore);
}
else if (strAttributeName  ==  convgs_PViewpointRela.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PViewpointRela.TeaScore);
}
else if (strAttributeName  ==  convgs_PViewpointRela.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PViewpointRela.OkCount);
}
else if (strAttributeName  ==  convgs_PViewpointRela.CitationCount)
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PViewpointRela.CitationCount);
}
else if (strAttributeName  ==  convgs_PViewpointRela.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PViewpointRela.VersionCount);
}
else if (strAttributeName  ==  convgs_PViewpointRela.ProposePeople)
{
mstrProposePeople = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.ProposePeople);
}
else if (strAttributeName  ==  convgs_PViewpointRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.UpdDate);
}
else if (strAttributeName  ==  convgs_PViewpointRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.UpdUser);
}
else if (strAttributeName  ==  convgs_PViewpointRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.Memo);
}
else if (strAttributeName  ==  convgs_PViewpointRela.ViewsDate)
{
mstrViewsDate = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.ViewsDate);
}
else if (strAttributeName  ==  convgs_PViewpointRela.ViewsUserId)
{
mstrViewsUserId = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.ViewsUserId);
}
else if (strAttributeName  ==  convgs_PViewpointRela.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.CreateDate);
}
else if (strAttributeName  ==  convgs_PViewpointRela.ShareId)
{
mstrShareId = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.ShareId);
}
}
}
public object this[int intIndex]
{
get
{
if (convgs_PViewpointRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convgs_PViewpointRela.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convgs_PViewpointRela.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convgs_PViewpointRela.PaperTypeId  ==  AttributeName[intIndex])
{
return mstrPaperTypeId;
}
else if (convgs_PViewpointRela.SectionId  ==  AttributeName[intIndex])
{
return mstrSectionId;
}
else if (convgs_PViewpointRela.SectionName  ==  AttributeName[intIndex])
{
return mstrSectionName;
}
else if (convgs_PViewpointRela.ViewpointId  ==  AttributeName[intIndex])
{
return mstrViewpointId;
}
else if (convgs_PViewpointRela.ViewpointName  ==  AttributeName[intIndex])
{
return mstrViewpointName;
}
else if (convgs_PViewpointRela.ViewpointContent  ==  AttributeName[intIndex])
{
return mstrViewpointContent;
}
else if (convgs_PViewpointRela.ViewpointTypeId  ==  AttributeName[intIndex])
{
return mstrViewpointTypeId;
}
else if (convgs_PViewpointRela.ViewpointTypeName  ==  AttributeName[intIndex])
{
return mstrViewpointTypeName;
}
else if (convgs_PViewpointRela.Reason  ==  AttributeName[intIndex])
{
return mstrReason;
}
else if (convgs_PViewpointRela.VPProposePeople  ==  AttributeName[intIndex])
{
return mstrVPProposePeople;
}
else if (convgs_PViewpointRela.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convgs_PViewpointRela.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (convgs_PViewpointRela.UserTypeName  ==  AttributeName[intIndex])
{
return mstrUserTypeName;
}
else if (convgs_PViewpointRela.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convgs_PViewpointRela.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convgs_PViewpointRela.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convgs_PViewpointRela.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convgs_PViewpointRela.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (convgs_PViewpointRela.CitationCount  ==  AttributeName[intIndex])
{
return mintCitationCount;
}
else if (convgs_PViewpointRela.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (convgs_PViewpointRela.ProposePeople  ==  AttributeName[intIndex])
{
return mstrProposePeople;
}
else if (convgs_PViewpointRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convgs_PViewpointRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convgs_PViewpointRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convgs_PViewpointRela.ViewsDate  ==  AttributeName[intIndex])
{
return mstrViewsDate;
}
else if (convgs_PViewpointRela.ViewsUserId  ==  AttributeName[intIndex])
{
return mstrViewsUserId;
}
else if (convgs_PViewpointRela.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convgs_PViewpointRela.ShareId  ==  AttributeName[intIndex])
{
return mstrShareId;
}
return null;
}
set
{
if (convgs_PViewpointRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PViewpointRela.mId);
}
else if (convgs_PViewpointRela.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.PaperId);
}
else if (convgs_PViewpointRela.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.PaperTitle);
}
else if (convgs_PViewpointRela.PaperTypeId  ==  AttributeName[intIndex])
{
mstrPaperTypeId = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.PaperTypeId);
}
else if (convgs_PViewpointRela.SectionId  ==  AttributeName[intIndex])
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.SectionId);
}
else if (convgs_PViewpointRela.SectionName  ==  AttributeName[intIndex])
{
mstrSectionName = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.SectionName);
}
else if (convgs_PViewpointRela.ViewpointId  ==  AttributeName[intIndex])
{
mstrViewpointId = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.ViewpointId);
}
else if (convgs_PViewpointRela.ViewpointName  ==  AttributeName[intIndex])
{
mstrViewpointName = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.ViewpointName);
}
else if (convgs_PViewpointRela.ViewpointContent  ==  AttributeName[intIndex])
{
mstrViewpointContent = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.ViewpointContent);
}
else if (convgs_PViewpointRela.ViewpointTypeId  ==  AttributeName[intIndex])
{
mstrViewpointTypeId = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.ViewpointTypeId);
}
else if (convgs_PViewpointRela.ViewpointTypeName  ==  AttributeName[intIndex])
{
mstrViewpointTypeName = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.ViewpointTypeName);
}
else if (convgs_PViewpointRela.Reason  ==  AttributeName[intIndex])
{
mstrReason = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.Reason);
}
else if (convgs_PViewpointRela.VPProposePeople  ==  AttributeName[intIndex])
{
mstrVPProposePeople = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.VPProposePeople);
}
else if (convgs_PViewpointRela.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convgs_PViewpointRela.IsSubmit);
}
else if (convgs_PViewpointRela.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.UserTypeId);
}
else if (convgs_PViewpointRela.UserTypeName  ==  AttributeName[intIndex])
{
mstrUserTypeName = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.UserTypeName);
}
else if (convgs_PViewpointRela.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PViewpointRela.AppraiseCount);
}
else if (convgs_PViewpointRela.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PViewpointRela.Score);
}
else if (convgs_PViewpointRela.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PViewpointRela.StuScore);
}
else if (convgs_PViewpointRela.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convgs_PViewpointRela.TeaScore);
}
else if (convgs_PViewpointRela.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PViewpointRela.OkCount);
}
else if (convgs_PViewpointRela.CitationCount  ==  AttributeName[intIndex])
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PViewpointRela.CitationCount);
}
else if (convgs_PViewpointRela.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PViewpointRela.VersionCount);
}
else if (convgs_PViewpointRela.ProposePeople  ==  AttributeName[intIndex])
{
mstrProposePeople = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.ProposePeople);
}
else if (convgs_PViewpointRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.UpdDate);
}
else if (convgs_PViewpointRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.UpdUser);
}
else if (convgs_PViewpointRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.Memo);
}
else if (convgs_PViewpointRela.ViewsDate  ==  AttributeName[intIndex])
{
mstrViewsDate = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.ViewsDate);
}
else if (convgs_PViewpointRela.ViewsUserId  ==  AttributeName[intIndex])
{
mstrViewsUserId = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.ViewsUserId);
}
else if (convgs_PViewpointRela.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.CreateDate);
}
else if (convgs_PViewpointRela.ShareId  ==  AttributeName[intIndex])
{
mstrShareId = value.ToString();
 AddUpdatedFld(convgs_PViewpointRela.ShareId);
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
 AddUpdatedFld(convgs_PViewpointRela.mId);
}
}
/// <summary>
/// 论文Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperId
{
get
{
return mstrPaperId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperId = value;
}
else
{
 mstrPaperId = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PViewpointRela.PaperId);
}
}
/// <summary>
/// 论文标题(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperTitle
{
get
{
return mstrPaperTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperTitle = value;
}
else
{
 mstrPaperTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PViewpointRela.PaperTitle);
}
}
/// <summary>
/// 论文类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperTypeId
{
get
{
return mstrPaperTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperTypeId = value;
}
else
{
 mstrPaperTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PViewpointRela.PaperTypeId);
}
}
/// <summary>
/// 节Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionId
{
get
{
return mstrSectionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionId = value;
}
else
{
 mstrSectionId = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PViewpointRela.SectionId);
}
}
/// <summary>
/// 节名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionName
{
get
{
return mstrSectionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionName = value;
}
else
{
 mstrSectionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PViewpointRela.SectionName);
}
}
/// <summary>
/// 观点Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewpointId
{
get
{
return mstrViewpointId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewpointId = value;
}
else
{
 mstrViewpointId = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PViewpointRela.ViewpointId);
}
}
/// <summary>
/// 观点名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewpointName
{
get
{
return mstrViewpointName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewpointName = value;
}
else
{
 mstrViewpointName = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PViewpointRela.ViewpointName);
}
}
/// <summary>
/// 观点内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewpointContent
{
get
{
return mstrViewpointContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewpointContent = value;
}
else
{
 mstrViewpointContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PViewpointRela.ViewpointContent);
}
}
/// <summary>
/// 观点类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewpointTypeId
{
get
{
return mstrViewpointTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewpointTypeId = value;
}
else
{
 mstrViewpointTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PViewpointRela.ViewpointTypeId);
}
}
/// <summary>
/// 观点类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewpointTypeName
{
get
{
return mstrViewpointTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewpointTypeName = value;
}
else
{
 mstrViewpointTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PViewpointRela.ViewpointTypeName);
}
}
/// <summary>
/// 理由(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Reason
{
get
{
return mstrReason;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReason = value;
}
else
{
 mstrReason = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PViewpointRela.Reason);
}
}
/// <summary>
/// 观点提出人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VPProposePeople
{
get
{
return mstrVPProposePeople;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVPProposePeople = value;
}
else
{
 mstrVPProposePeople = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PViewpointRela.VPProposePeople);
}
}
/// <summary>
/// 是否提交(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSubmit
{
get
{
return mbolIsSubmit;
}
set
{
 mbolIsSubmit = value;
//记录修改过的字段
 AddUpdatedFld(convgs_PViewpointRela.IsSubmit);
}
}
/// <summary>
/// 用户类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserTypeId
{
get
{
return mstrUserTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserTypeId = value;
}
else
{
 mstrUserTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PViewpointRela.UserTypeId);
}
}
/// <summary>
/// 用户类型名称(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserTypeName
{
get
{
return mstrUserTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserTypeName = value;
}
else
{
 mstrUserTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PViewpointRela.UserTypeName);
}
}
/// <summary>
/// 评论数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AppraiseCount
{
get
{
return mintAppraiseCount;
}
set
{
 mintAppraiseCount = value;
//记录修改过的字段
 AddUpdatedFld(convgs_PViewpointRela.AppraiseCount);
}
}
/// <summary>
/// 评分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? Score
{
get
{
return mfltScore;
}
set
{
 mfltScore = value;
//记录修改过的字段
 AddUpdatedFld(convgs_PViewpointRela.Score);
}
}
/// <summary>
/// 学生平均分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? StuScore
{
get
{
return mfltStuScore;
}
set
{
 mfltStuScore = value;
//记录修改过的字段
 AddUpdatedFld(convgs_PViewpointRela.StuScore);
}
}
/// <summary>
/// 教师评分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? TeaScore
{
get
{
return mfltTeaScore;
}
set
{
 mfltTeaScore = value;
//记录修改过的字段
 AddUpdatedFld(convgs_PViewpointRela.TeaScore);
}
}
/// <summary>
/// 点赞统计(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OkCount
{
get
{
return mintOkCount;
}
set
{
 mintOkCount = value;
//记录修改过的字段
 AddUpdatedFld(convgs_PViewpointRela.OkCount);
}
}
/// <summary>
/// 引用统计(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? CitationCount
{
get
{
return mintCitationCount;
}
set
{
 mintCitationCount = value;
//记录修改过的字段
 AddUpdatedFld(convgs_PViewpointRela.CitationCount);
}
}
/// <summary>
/// 版本统计(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? VersionCount
{
get
{
return mintVersionCount;
}
set
{
 mintVersionCount = value;
//记录修改过的字段
 AddUpdatedFld(convgs_PViewpointRela.VersionCount);
}
}
/// <summary>
/// 提出人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProposePeople
{
get
{
return mstrProposePeople;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProposePeople = value;
}
else
{
 mstrProposePeople = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PViewpointRela.ProposePeople);
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
 AddUpdatedFld(convgs_PViewpointRela.UpdDate);
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
 AddUpdatedFld(convgs_PViewpointRela.UpdUser);
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
 AddUpdatedFld(convgs_PViewpointRela.Memo);
}
}
/// <summary>
/// ViewsDate(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewsDate
{
get
{
return mstrViewsDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewsDate = value;
}
else
{
 mstrViewsDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PViewpointRela.ViewsDate);
}
}
/// <summary>
/// ViewsUserId(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewsUserId
{
get
{
return mstrViewsUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewsUserId = value;
}
else
{
 mstrViewsUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PViewpointRela.ViewsUserId);
}
}
/// <summary>
/// 建立日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateDate
{
get
{
return mstrCreateDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateDate = value;
}
else
{
 mstrCreateDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PViewpointRela.CreateDate);
}
}
/// <summary>
/// 分享Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ShareId
{
get
{
return mstrShareId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrShareId = value;
}
else
{
 mstrShareId = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PViewpointRela.ShareId);
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
 /// 论文观点关系视图(vgs_PViewpointRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convgs_PViewpointRela
{
public const string _CurrTabName = "vgs_PViewpointRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "PaperId", "PaperTitle", "PaperTypeId", "SectionId", "SectionName", "ViewpointId", "ViewpointName", "ViewpointContent", "ViewpointTypeId", "ViewpointTypeName", "Reason", "VPProposePeople", "IsSubmit", "UserTypeId", "UserTypeName", "AppraiseCount", "Score", "StuScore", "TeaScore", "OkCount", "CitationCount", "VersionCount", "ProposePeople", "UpdDate", "UpdUser", "Memo", "ViewsDate", "ViewsUserId", "CreateDate", "ShareId"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

 /// <summary>
 /// 常量:"PaperTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTitle = "PaperTitle";    //论文标题

 /// <summary>
 /// 常量:"PaperTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTypeId = "PaperTypeId";    //论文类型Id

 /// <summary>
 /// 常量:"SectionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionId = "SectionId";    //节Id

 /// <summary>
 /// 常量:"SectionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionName = "SectionName";    //节名

 /// <summary>
 /// 常量:"ViewpointId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointId = "ViewpointId";    //观点Id

 /// <summary>
 /// 常量:"ViewpointName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointName = "ViewpointName";    //观点名称

 /// <summary>
 /// 常量:"ViewpointContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointContent = "ViewpointContent";    //观点内容

 /// <summary>
 /// 常量:"ViewpointTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointTypeId = "ViewpointTypeId";    //观点类型Id

 /// <summary>
 /// 常量:"ViewpointTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointTypeName = "ViewpointTypeName";    //观点类型名

 /// <summary>
 /// 常量:"Reason"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Reason = "Reason";    //理由

 /// <summary>
 /// 常量:"VPProposePeople"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VPProposePeople = "VPProposePeople";    //观点提出人

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"UserTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeId = "UserTypeId";    //用户类型Id

 /// <summary>
 /// 常量:"UserTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeName = "UserTypeName";    //用户类型名称

 /// <summary>
 /// 常量:"AppraiseCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseCount = "AppraiseCount";    //评论数

 /// <summary>
 /// 常量:"Score"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Score = "Score";    //评分

 /// <summary>
 /// 常量:"StuScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuScore = "StuScore";    //学生平均分

 /// <summary>
 /// 常量:"TeaScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeaScore = "TeaScore";    //教师评分

 /// <summary>
 /// 常量:"OkCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OkCount = "OkCount";    //点赞统计

 /// <summary>
 /// 常量:"CitationCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CitationCount = "CitationCount";    //引用统计

 /// <summary>
 /// 常量:"VersionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VersionCount = "VersionCount";    //版本统计

 /// <summary>
 /// 常量:"ProposePeople"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProposePeople = "ProposePeople";    //提出人

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

 /// <summary>
 /// 常量:"ViewsDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewsDate = "ViewsDate";    //ViewsDate

 /// <summary>
 /// 常量:"ViewsUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewsUserId = "ViewsUserId";    //ViewsUserId

 /// <summary>
 /// 常量:"CreateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateDate = "CreateDate";    //建立日期

 /// <summary>
 /// 常量:"ShareId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ShareId = "ShareId";    //分享Id
}

}