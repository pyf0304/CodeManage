
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ViewpointEN
 表名:zx_Viewpoint(01120705)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:56:11
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
 /// 表zx_Viewpoint的关键字(zxViewpointId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxViewpointId_zx_Viewpoint
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxViewpointId">表关键字</param>
public K_zxViewpointId_zx_Viewpoint(string strzxViewpointId)
{
if (IsValid(strzxViewpointId)) Value = strzxViewpointId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxViewpointId)
{
if (string.IsNullOrEmpty(strzxViewpointId) == true) return false;
if (strzxViewpointId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxViewpointId_zx_Viewpoint]类型的对象</returns>
public static implicit operator K_zxViewpointId_zx_Viewpoint(string value)
{
return new K_zxViewpointId_zx_Viewpoint(value);
}
}
 /// <summary>
 /// 中学观点表(zx_Viewpoint)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_ViewpointEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_Viewpoint"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxViewpointId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 32;
public static string[] AttributeName = new string[] {"zxViewpointId", "ViewpointName", "ViewpointContent", "zxViewpointTypeId", "Reason", "Source", "VPProposePeople", "IsSubmit", "UserTypeId", "TextId", "VoteCount", "AppraiseCount", "Score", "StuScore", "TeaScore", "IdCurrEduCls", "PdfContent", "PdfPageNum", "CitationCount", "VersionCount", "zxShareId", "CreateDate", "UpdDate", "UpdUser", "Memo", "TeammenberId", "PdfDivLet", "PdfDivTop", "PdfPageNumIn", "PdfPageTop", "PdfZoom", "GroupTextId"};

protected string mstrzxViewpointId;    //观点Id
protected string mstrViewpointName;    //观点名称
protected string mstrViewpointContent;    //观点内容
protected string mstrzxViewpointTypeId;    //观点类型Id
protected string mstrReason;    //理由
protected string mstrSource;    //来源
protected string mstrVPProposePeople;    //观点提出人
protected bool mbolIsSubmit;    //是否提交
protected string mstrUserTypeId;    //用户类型Id
protected string mstrTextId;    //课件Id
protected int? mintVoteCount;    //点赞计数
protected int? mintAppraiseCount;    //评论数
protected float? mfltScore;    //评分
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrPdfContent;    //Pdf内容
protected int? mintPdfPageNum;    //Pdf页码
protected int? mintCitationCount;    //引用统计
protected int? mintVersionCount;    //版本统计
protected string mstrzxShareId;    //分享Id
protected string mstrCreateDate;    //建立日期
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrTeammenberId;    //主键
protected string mstrPdfDivLet;    //PdfDivLet
protected string mstrPdfDivTop;    //PdfDivTop
protected string mstrPdfPageNumIn;    //PdfPageNumIn
protected int? mintPdfPageTop;    //pdf页面顶部位置
protected string mstrPdfZoom;    //PdfZoom
protected string mstrGroupTextId;    //小组Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_ViewpointEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxViewpointId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxViewpointId">关键字:观点Id</param>
public clszx_ViewpointEN(string strzxViewpointId)
 {
strzxViewpointId = strzxViewpointId.Replace("'", "''");
if (strzxViewpointId.Length > 8)
{
throw new Exception("在表:zx_Viewpoint中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxViewpointId)  ==  true)
{
throw new Exception("在表:zx_Viewpoint中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxViewpointId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxViewpointId = strzxViewpointId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxViewpointId");
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
if (strAttributeName  ==  conzx_Viewpoint.zxViewpointId)
{
return mstrzxViewpointId;
}
else if (strAttributeName  ==  conzx_Viewpoint.ViewpointName)
{
return mstrViewpointName;
}
else if (strAttributeName  ==  conzx_Viewpoint.ViewpointContent)
{
return mstrViewpointContent;
}
else if (strAttributeName  ==  conzx_Viewpoint.zxViewpointTypeId)
{
return mstrzxViewpointTypeId;
}
else if (strAttributeName  ==  conzx_Viewpoint.Reason)
{
return mstrReason;
}
else if (strAttributeName  ==  conzx_Viewpoint.Source)
{
return mstrSource;
}
else if (strAttributeName  ==  conzx_Viewpoint.VPProposePeople)
{
return mstrVPProposePeople;
}
else if (strAttributeName  ==  conzx_Viewpoint.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  conzx_Viewpoint.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  conzx_Viewpoint.TextId)
{
return mstrTextId;
}
else if (strAttributeName  ==  conzx_Viewpoint.VoteCount)
{
return mintVoteCount;
}
else if (strAttributeName  ==  conzx_Viewpoint.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  conzx_Viewpoint.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  conzx_Viewpoint.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  conzx_Viewpoint.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  conzx_Viewpoint.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conzx_Viewpoint.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  conzx_Viewpoint.PdfPageNum)
{
return mintPdfPageNum;
}
else if (strAttributeName  ==  conzx_Viewpoint.CitationCount)
{
return mintCitationCount;
}
else if (strAttributeName  ==  conzx_Viewpoint.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  conzx_Viewpoint.zxShareId)
{
return mstrzxShareId;
}
else if (strAttributeName  ==  conzx_Viewpoint.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  conzx_Viewpoint.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_Viewpoint.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_Viewpoint.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conzx_Viewpoint.TeammenberId)
{
return mstrTeammenberId;
}
else if (strAttributeName  ==  conzx_Viewpoint.PdfDivLet)
{
return mstrPdfDivLet;
}
else if (strAttributeName  ==  conzx_Viewpoint.PdfDivTop)
{
return mstrPdfDivTop;
}
else if (strAttributeName  ==  conzx_Viewpoint.PdfPageNumIn)
{
return mstrPdfPageNumIn;
}
else if (strAttributeName  ==  conzx_Viewpoint.PdfPageTop)
{
return mintPdfPageTop;
}
else if (strAttributeName  ==  conzx_Viewpoint.PdfZoom)
{
return mstrPdfZoom;
}
else if (strAttributeName  ==  conzx_Viewpoint.GroupTextId)
{
return mstrGroupTextId;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_Viewpoint.zxViewpointId)
{
mstrzxViewpointId = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.zxViewpointId);
}
else if (strAttributeName  ==  conzx_Viewpoint.ViewpointName)
{
mstrViewpointName = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.ViewpointName);
}
else if (strAttributeName  ==  conzx_Viewpoint.ViewpointContent)
{
mstrViewpointContent = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.ViewpointContent);
}
else if (strAttributeName  ==  conzx_Viewpoint.zxViewpointTypeId)
{
mstrzxViewpointTypeId = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.zxViewpointTypeId);
}
else if (strAttributeName  ==  conzx_Viewpoint.Reason)
{
mstrReason = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.Reason);
}
else if (strAttributeName  ==  conzx_Viewpoint.Source)
{
mstrSource = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.Source);
}
else if (strAttributeName  ==  conzx_Viewpoint.VPProposePeople)
{
mstrVPProposePeople = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.VPProposePeople);
}
else if (strAttributeName  ==  conzx_Viewpoint.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_Viewpoint.IsSubmit);
}
else if (strAttributeName  ==  conzx_Viewpoint.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.UserTypeId);
}
else if (strAttributeName  ==  conzx_Viewpoint.TextId)
{
mstrTextId = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.TextId);
}
else if (strAttributeName  ==  conzx_Viewpoint.VoteCount)
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Viewpoint.VoteCount);
}
else if (strAttributeName  ==  conzx_Viewpoint.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Viewpoint.AppraiseCount);
}
else if (strAttributeName  ==  conzx_Viewpoint.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_Viewpoint.Score);
}
else if (strAttributeName  ==  conzx_Viewpoint.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_Viewpoint.StuScore);
}
else if (strAttributeName  ==  conzx_Viewpoint.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_Viewpoint.TeaScore);
}
else if (strAttributeName  ==  conzx_Viewpoint.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.IdCurrEduCls);
}
else if (strAttributeName  ==  conzx_Viewpoint.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.PdfContent);
}
else if (strAttributeName  ==  conzx_Viewpoint.PdfPageNum)
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Viewpoint.PdfPageNum);
}
else if (strAttributeName  ==  conzx_Viewpoint.CitationCount)
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Viewpoint.CitationCount);
}
else if (strAttributeName  ==  conzx_Viewpoint.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Viewpoint.VersionCount);
}
else if (strAttributeName  ==  conzx_Viewpoint.zxShareId)
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.zxShareId);
}
else if (strAttributeName  ==  conzx_Viewpoint.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.CreateDate);
}
else if (strAttributeName  ==  conzx_Viewpoint.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.UpdDate);
}
else if (strAttributeName  ==  conzx_Viewpoint.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.UpdUser);
}
else if (strAttributeName  ==  conzx_Viewpoint.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.Memo);
}
else if (strAttributeName  ==  conzx_Viewpoint.TeammenberId)
{
mstrTeammenberId = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.TeammenberId);
}
else if (strAttributeName  ==  conzx_Viewpoint.PdfDivLet)
{
mstrPdfDivLet = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.PdfDivLet);
}
else if (strAttributeName  ==  conzx_Viewpoint.PdfDivTop)
{
mstrPdfDivTop = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.PdfDivTop);
}
else if (strAttributeName  ==  conzx_Viewpoint.PdfPageNumIn)
{
mstrPdfPageNumIn = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.PdfPageNumIn);
}
else if (strAttributeName  ==  conzx_Viewpoint.PdfPageTop)
{
mintPdfPageTop = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Viewpoint.PdfPageTop);
}
else if (strAttributeName  ==  conzx_Viewpoint.PdfZoom)
{
mstrPdfZoom = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.PdfZoom);
}
else if (strAttributeName  ==  conzx_Viewpoint.GroupTextId)
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.GroupTextId);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_Viewpoint.zxViewpointId  ==  AttributeName[intIndex])
{
return mstrzxViewpointId;
}
else if (conzx_Viewpoint.ViewpointName  ==  AttributeName[intIndex])
{
return mstrViewpointName;
}
else if (conzx_Viewpoint.ViewpointContent  ==  AttributeName[intIndex])
{
return mstrViewpointContent;
}
else if (conzx_Viewpoint.zxViewpointTypeId  ==  AttributeName[intIndex])
{
return mstrzxViewpointTypeId;
}
else if (conzx_Viewpoint.Reason  ==  AttributeName[intIndex])
{
return mstrReason;
}
else if (conzx_Viewpoint.Source  ==  AttributeName[intIndex])
{
return mstrSource;
}
else if (conzx_Viewpoint.VPProposePeople  ==  AttributeName[intIndex])
{
return mstrVPProposePeople;
}
else if (conzx_Viewpoint.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (conzx_Viewpoint.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (conzx_Viewpoint.TextId  ==  AttributeName[intIndex])
{
return mstrTextId;
}
else if (conzx_Viewpoint.VoteCount  ==  AttributeName[intIndex])
{
return mintVoteCount;
}
else if (conzx_Viewpoint.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (conzx_Viewpoint.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (conzx_Viewpoint.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (conzx_Viewpoint.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (conzx_Viewpoint.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conzx_Viewpoint.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (conzx_Viewpoint.PdfPageNum  ==  AttributeName[intIndex])
{
return mintPdfPageNum;
}
else if (conzx_Viewpoint.CitationCount  ==  AttributeName[intIndex])
{
return mintCitationCount;
}
else if (conzx_Viewpoint.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (conzx_Viewpoint.zxShareId  ==  AttributeName[intIndex])
{
return mstrzxShareId;
}
else if (conzx_Viewpoint.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (conzx_Viewpoint.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_Viewpoint.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_Viewpoint.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conzx_Viewpoint.TeammenberId  ==  AttributeName[intIndex])
{
return mstrTeammenberId;
}
else if (conzx_Viewpoint.PdfDivLet  ==  AttributeName[intIndex])
{
return mstrPdfDivLet;
}
else if (conzx_Viewpoint.PdfDivTop  ==  AttributeName[intIndex])
{
return mstrPdfDivTop;
}
else if (conzx_Viewpoint.PdfPageNumIn  ==  AttributeName[intIndex])
{
return mstrPdfPageNumIn;
}
else if (conzx_Viewpoint.PdfPageTop  ==  AttributeName[intIndex])
{
return mintPdfPageTop;
}
else if (conzx_Viewpoint.PdfZoom  ==  AttributeName[intIndex])
{
return mstrPdfZoom;
}
else if (conzx_Viewpoint.GroupTextId  ==  AttributeName[intIndex])
{
return mstrGroupTextId;
}
return null;
}
set
{
if (conzx_Viewpoint.zxViewpointId  ==  AttributeName[intIndex])
{
mstrzxViewpointId = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.zxViewpointId);
}
else if (conzx_Viewpoint.ViewpointName  ==  AttributeName[intIndex])
{
mstrViewpointName = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.ViewpointName);
}
else if (conzx_Viewpoint.ViewpointContent  ==  AttributeName[intIndex])
{
mstrViewpointContent = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.ViewpointContent);
}
else if (conzx_Viewpoint.zxViewpointTypeId  ==  AttributeName[intIndex])
{
mstrzxViewpointTypeId = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.zxViewpointTypeId);
}
else if (conzx_Viewpoint.Reason  ==  AttributeName[intIndex])
{
mstrReason = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.Reason);
}
else if (conzx_Viewpoint.Source  ==  AttributeName[intIndex])
{
mstrSource = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.Source);
}
else if (conzx_Viewpoint.VPProposePeople  ==  AttributeName[intIndex])
{
mstrVPProposePeople = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.VPProposePeople);
}
else if (conzx_Viewpoint.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_Viewpoint.IsSubmit);
}
else if (conzx_Viewpoint.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.UserTypeId);
}
else if (conzx_Viewpoint.TextId  ==  AttributeName[intIndex])
{
mstrTextId = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.TextId);
}
else if (conzx_Viewpoint.VoteCount  ==  AttributeName[intIndex])
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Viewpoint.VoteCount);
}
else if (conzx_Viewpoint.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Viewpoint.AppraiseCount);
}
else if (conzx_Viewpoint.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_Viewpoint.Score);
}
else if (conzx_Viewpoint.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_Viewpoint.StuScore);
}
else if (conzx_Viewpoint.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_Viewpoint.TeaScore);
}
else if (conzx_Viewpoint.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.IdCurrEduCls);
}
else if (conzx_Viewpoint.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.PdfContent);
}
else if (conzx_Viewpoint.PdfPageNum  ==  AttributeName[intIndex])
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Viewpoint.PdfPageNum);
}
else if (conzx_Viewpoint.CitationCount  ==  AttributeName[intIndex])
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Viewpoint.CitationCount);
}
else if (conzx_Viewpoint.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Viewpoint.VersionCount);
}
else if (conzx_Viewpoint.zxShareId  ==  AttributeName[intIndex])
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.zxShareId);
}
else if (conzx_Viewpoint.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.CreateDate);
}
else if (conzx_Viewpoint.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.UpdDate);
}
else if (conzx_Viewpoint.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.UpdUser);
}
else if (conzx_Viewpoint.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.Memo);
}
else if (conzx_Viewpoint.TeammenberId  ==  AttributeName[intIndex])
{
mstrTeammenberId = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.TeammenberId);
}
else if (conzx_Viewpoint.PdfDivLet  ==  AttributeName[intIndex])
{
mstrPdfDivLet = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.PdfDivLet);
}
else if (conzx_Viewpoint.PdfDivTop  ==  AttributeName[intIndex])
{
mstrPdfDivTop = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.PdfDivTop);
}
else if (conzx_Viewpoint.PdfPageNumIn  ==  AttributeName[intIndex])
{
mstrPdfPageNumIn = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.PdfPageNumIn);
}
else if (conzx_Viewpoint.PdfPageTop  ==  AttributeName[intIndex])
{
mintPdfPageTop = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Viewpoint.PdfPageTop);
}
else if (conzx_Viewpoint.PdfZoom  ==  AttributeName[intIndex])
{
mstrPdfZoom = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.PdfZoom);
}
else if (conzx_Viewpoint.GroupTextId  ==  AttributeName[intIndex])
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_Viewpoint.GroupTextId);
}
}
}

/// <summary>
/// 观点Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxViewpointId
{
get
{
return mstrzxViewpointId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxViewpointId = value;
}
else
{
 mstrzxViewpointId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_Viewpoint.zxViewpointId);
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
 AddUpdatedFld(conzx_Viewpoint.ViewpointName);
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
 AddUpdatedFld(conzx_Viewpoint.ViewpointContent);
}
}
/// <summary>
/// 观点类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxViewpointTypeId
{
get
{
return mstrzxViewpointTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxViewpointTypeId = value;
}
else
{
 mstrzxViewpointTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_Viewpoint.zxViewpointTypeId);
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
 AddUpdatedFld(conzx_Viewpoint.Reason);
}
}
/// <summary>
/// 来源(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Source
{
get
{
return mstrSource;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSource = value;
}
else
{
 mstrSource = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_Viewpoint.Source);
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
 AddUpdatedFld(conzx_Viewpoint.VPProposePeople);
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
 AddUpdatedFld(conzx_Viewpoint.IsSubmit);
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
 AddUpdatedFld(conzx_Viewpoint.UserTypeId);
}
}
/// <summary>
/// 课件Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextId
{
get
{
return mstrTextId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextId = value;
}
else
{
 mstrTextId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_Viewpoint.TextId);
}
}
/// <summary>
/// 点赞计数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? VoteCount
{
get
{
return mintVoteCount;
}
set
{
 mintVoteCount = value;
//记录修改过的字段
 AddUpdatedFld(conzx_Viewpoint.VoteCount);
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
 AddUpdatedFld(conzx_Viewpoint.AppraiseCount);
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
 AddUpdatedFld(conzx_Viewpoint.Score);
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
 AddUpdatedFld(conzx_Viewpoint.StuScore);
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
 AddUpdatedFld(conzx_Viewpoint.TeaScore);
}
}
/// <summary>
/// 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCurrEduCls
{
get
{
return mstrIdCurrEduCls;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCurrEduCls = value;
}
else
{
 mstrIdCurrEduCls = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_Viewpoint.IdCurrEduCls);
}
}
/// <summary>
/// Pdf内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PdfContent
{
get
{
return mstrPdfContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPdfContent = value;
}
else
{
 mstrPdfContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_Viewpoint.PdfContent);
}
}
/// <summary>
/// Pdf页码(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PdfPageNum
{
get
{
return mintPdfPageNum;
}
set
{
 mintPdfPageNum = value;
//记录修改过的字段
 AddUpdatedFld(conzx_Viewpoint.PdfPageNum);
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
 AddUpdatedFld(conzx_Viewpoint.CitationCount);
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
 AddUpdatedFld(conzx_Viewpoint.VersionCount);
}
}
/// <summary>
/// 分享Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxShareId
{
get
{
return mstrzxShareId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxShareId = value;
}
else
{
 mstrzxShareId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_Viewpoint.zxShareId);
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
 AddUpdatedFld(conzx_Viewpoint.CreateDate);
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
 AddUpdatedFld(conzx_Viewpoint.UpdDate);
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
 AddUpdatedFld(conzx_Viewpoint.UpdUser);
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
 AddUpdatedFld(conzx_Viewpoint.Memo);
}
}
/// <summary>
/// 主键(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeammenberId
{
get
{
return mstrTeammenberId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeammenberId = value;
}
else
{
 mstrTeammenberId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_Viewpoint.TeammenberId);
}
}
/// <summary>
/// PdfDivLet(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PdfDivLet
{
get
{
return mstrPdfDivLet;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPdfDivLet = value;
}
else
{
 mstrPdfDivLet = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_Viewpoint.PdfDivLet);
}
}
/// <summary>
/// PdfDivTop(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PdfDivTop
{
get
{
return mstrPdfDivTop;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPdfDivTop = value;
}
else
{
 mstrPdfDivTop = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_Viewpoint.PdfDivTop);
}
}
/// <summary>
/// PdfPageNumIn(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PdfPageNumIn
{
get
{
return mstrPdfPageNumIn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPdfPageNumIn = value;
}
else
{
 mstrPdfPageNumIn = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_Viewpoint.PdfPageNumIn);
}
}
/// <summary>
/// pdf页面顶部位置(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PdfPageTop
{
get
{
return mintPdfPageTop;
}
set
{
 mintPdfPageTop = value;
//记录修改过的字段
 AddUpdatedFld(conzx_Viewpoint.PdfPageTop);
}
}
/// <summary>
/// PdfZoom(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PdfZoom
{
get
{
return mstrPdfZoom;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPdfZoom = value;
}
else
{
 mstrPdfZoom = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_Viewpoint.PdfZoom);
}
}
/// <summary>
/// 小组Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupTextId
{
get
{
return mstrGroupTextId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupTextId = value;
}
else
{
 mstrGroupTextId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_Viewpoint.GroupTextId);
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
  return mstrzxViewpointId;
 }
 }
}
 /// <summary>
 /// 中学观点表(zx_Viewpoint)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_Viewpoint
{
public const string _CurrTabName = "zx_Viewpoint"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxViewpointId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxViewpointId", "ViewpointName", "ViewpointContent", "zxViewpointTypeId", "Reason", "Source", "VPProposePeople", "IsSubmit", "UserTypeId", "TextId", "VoteCount", "AppraiseCount", "Score", "StuScore", "TeaScore", "IdCurrEduCls", "PdfContent", "PdfPageNum", "CitationCount", "VersionCount", "zxShareId", "CreateDate", "UpdDate", "UpdUser", "Memo", "TeammenberId", "PdfDivLet", "PdfDivTop", "PdfPageNumIn", "PdfPageTop", "PdfZoom", "GroupTextId"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxViewpointId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxViewpointId = "zxViewpointId";    //观点Id

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
 /// 常量:"zxViewpointTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxViewpointTypeId = "zxViewpointTypeId";    //观点类型Id

 /// <summary>
 /// 常量:"Reason"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Reason = "Reason";    //理由

 /// <summary>
 /// 常量:"Source"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Source = "Source";    //来源

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
 /// 常量:"TextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextId = "TextId";    //课件Id

 /// <summary>
 /// 常量:"VoteCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VoteCount = "VoteCount";    //点赞计数

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
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"PdfContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfContent = "PdfContent";    //Pdf内容

 /// <summary>
 /// 常量:"PdfPageNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfPageNum = "PdfPageNum";    //Pdf页码

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
 /// 常量:"zxShareId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxShareId = "zxShareId";    //分享Id

 /// <summary>
 /// 常量:"CreateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateDate = "CreateDate";    //建立日期

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
 /// 常量:"TeammenberId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeammenberId = "TeammenberId";    //主键

 /// <summary>
 /// 常量:"PdfDivLet"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfDivLet = "PdfDivLet";    //PdfDivLet

 /// <summary>
 /// 常量:"PdfDivTop"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfDivTop = "PdfDivTop";    //PdfDivTop

 /// <summary>
 /// 常量:"PdfPageNumIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfPageNumIn = "PdfPageNumIn";    //PdfPageNumIn

 /// <summary>
 /// 常量:"PdfPageTop"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfPageTop = "PdfPageTop";    //pdf页面顶部位置

 /// <summary>
 /// 常量:"PdfZoom"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfZoom = "PdfZoom";    //PdfZoom

 /// <summary>
 /// 常量:"GroupTextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupTextId = "GroupTextId";    //小组Id
}

}