
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ViewpointVerEN
 表名:zx_ViewpointVer(01120742)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:08:16
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学历史版本(zxHistoricalVersion)
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
 /// 表zx_ViewpointVer的关键字(ViewpointVId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ViewpointVId_zx_ViewpointVer
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngViewpointVId">表关键字</param>
public K_ViewpointVId_zx_ViewpointVer(long lngViewpointVId)
{
if (IsValid(lngViewpointVId)) Value = lngViewpointVId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngViewpointVId)
{
if (lngViewpointVId == 0) return false;
if (lngViewpointVId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ViewpointVId_zx_ViewpointVer]类型的对象</returns>
public static implicit operator K_ViewpointVId_zx_ViewpointVer(long value)
{
return new K_ViewpointVId_zx_ViewpointVer(value);
}
}
 /// <summary>
 /// 观点历史版本(zx_ViewpointVer)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_ViewpointVerEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_ViewpointVer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ViewpointVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 33;
public static string[] AttributeName = new string[] {"ViewpointVId", "zxViewpointId", "ViewpointName", "ViewpointContent", "zxViewpointTypeId", "Reason", "Source", "VPProposePeople", "IsSubmit", "UserTypeId", "TextId", "VoteCount", "AppraiseCount", "Score", "StuScore", "TeaScore", "UpdDate", "UpdUser", "IdCurrEduCls", "PdfContent", "PdfPageNum", "CitationCount", "VersionCount", "CreateDate", "zxShareId", "Memo", "TeammenberId", "PdfDivLet", "PdfDivTop", "PdfPageNumIn", "PdfPageTop", "PdfZoom", "GroupTextId"};

protected long mlngViewpointVId;    //ViewpointVId
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
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrPdfContent;    //Pdf内容
protected int? mintPdfPageNum;    //Pdf页码
protected int? mintCitationCount;    //引用统计
protected int? mintVersionCount;    //版本统计
protected string mstrCreateDate;    //建立日期
protected string mstrzxShareId;    //分享Id
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
 public clszx_ViewpointVerEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewpointVId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngViewpointVId">关键字:ViewpointVId</param>
public clszx_ViewpointVerEN(long lngViewpointVId)
 {
 if (lngViewpointVId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngViewpointVId = lngViewpointVId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewpointVId");
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
if (strAttributeName  ==  conzx_ViewpointVer.ViewpointVId)
{
return mlngViewpointVId;
}
else if (strAttributeName  ==  conzx_ViewpointVer.zxViewpointId)
{
return mstrzxViewpointId;
}
else if (strAttributeName  ==  conzx_ViewpointVer.ViewpointName)
{
return mstrViewpointName;
}
else if (strAttributeName  ==  conzx_ViewpointVer.ViewpointContent)
{
return mstrViewpointContent;
}
else if (strAttributeName  ==  conzx_ViewpointVer.zxViewpointTypeId)
{
return mstrzxViewpointTypeId;
}
else if (strAttributeName  ==  conzx_ViewpointVer.Reason)
{
return mstrReason;
}
else if (strAttributeName  ==  conzx_ViewpointVer.Source)
{
return mstrSource;
}
else if (strAttributeName  ==  conzx_ViewpointVer.VPProposePeople)
{
return mstrVPProposePeople;
}
else if (strAttributeName  ==  conzx_ViewpointVer.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  conzx_ViewpointVer.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  conzx_ViewpointVer.TextId)
{
return mstrTextId;
}
else if (strAttributeName  ==  conzx_ViewpointVer.VoteCount)
{
return mintVoteCount;
}
else if (strAttributeName  ==  conzx_ViewpointVer.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  conzx_ViewpointVer.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  conzx_ViewpointVer.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  conzx_ViewpointVer.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  conzx_ViewpointVer.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_ViewpointVer.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_ViewpointVer.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conzx_ViewpointVer.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  conzx_ViewpointVer.PdfPageNum)
{
return mintPdfPageNum;
}
else if (strAttributeName  ==  conzx_ViewpointVer.CitationCount)
{
return mintCitationCount;
}
else if (strAttributeName  ==  conzx_ViewpointVer.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  conzx_ViewpointVer.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  conzx_ViewpointVer.zxShareId)
{
return mstrzxShareId;
}
else if (strAttributeName  ==  conzx_ViewpointVer.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conzx_ViewpointVer.TeammenberId)
{
return mstrTeammenberId;
}
else if (strAttributeName  ==  conzx_ViewpointVer.PdfDivLet)
{
return mstrPdfDivLet;
}
else if (strAttributeName  ==  conzx_ViewpointVer.PdfDivTop)
{
return mstrPdfDivTop;
}
else if (strAttributeName  ==  conzx_ViewpointVer.PdfPageNumIn)
{
return mstrPdfPageNumIn;
}
else if (strAttributeName  ==  conzx_ViewpointVer.PdfPageTop)
{
return mintPdfPageTop;
}
else if (strAttributeName  ==  conzx_ViewpointVer.PdfZoom)
{
return mstrPdfZoom;
}
else if (strAttributeName  ==  conzx_ViewpointVer.GroupTextId)
{
return mstrGroupTextId;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_ViewpointVer.ViewpointVId)
{
mlngViewpointVId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_ViewpointVer.ViewpointVId);
}
else if (strAttributeName  ==  conzx_ViewpointVer.zxViewpointId)
{
mstrzxViewpointId = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.zxViewpointId);
}
else if (strAttributeName  ==  conzx_ViewpointVer.ViewpointName)
{
mstrViewpointName = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.ViewpointName);
}
else if (strAttributeName  ==  conzx_ViewpointVer.ViewpointContent)
{
mstrViewpointContent = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.ViewpointContent);
}
else if (strAttributeName  ==  conzx_ViewpointVer.zxViewpointTypeId)
{
mstrzxViewpointTypeId = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.zxViewpointTypeId);
}
else if (strAttributeName  ==  conzx_ViewpointVer.Reason)
{
mstrReason = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.Reason);
}
else if (strAttributeName  ==  conzx_ViewpointVer.Source)
{
mstrSource = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.Source);
}
else if (strAttributeName  ==  conzx_ViewpointVer.VPProposePeople)
{
mstrVPProposePeople = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.VPProposePeople);
}
else if (strAttributeName  ==  conzx_ViewpointVer.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_ViewpointVer.IsSubmit);
}
else if (strAttributeName  ==  conzx_ViewpointVer.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.UserTypeId);
}
else if (strAttributeName  ==  conzx_ViewpointVer.TextId)
{
mstrTextId = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.TextId);
}
else if (strAttributeName  ==  conzx_ViewpointVer.VoteCount)
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_ViewpointVer.VoteCount);
}
else if (strAttributeName  ==  conzx_ViewpointVer.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_ViewpointVer.AppraiseCount);
}
else if (strAttributeName  ==  conzx_ViewpointVer.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_ViewpointVer.Score);
}
else if (strAttributeName  ==  conzx_ViewpointVer.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_ViewpointVer.StuScore);
}
else if (strAttributeName  ==  conzx_ViewpointVer.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_ViewpointVer.TeaScore);
}
else if (strAttributeName  ==  conzx_ViewpointVer.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.UpdDate);
}
else if (strAttributeName  ==  conzx_ViewpointVer.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.UpdUser);
}
else if (strAttributeName  ==  conzx_ViewpointVer.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.IdCurrEduCls);
}
else if (strAttributeName  ==  conzx_ViewpointVer.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.PdfContent);
}
else if (strAttributeName  ==  conzx_ViewpointVer.PdfPageNum)
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_ViewpointVer.PdfPageNum);
}
else if (strAttributeName  ==  conzx_ViewpointVer.CitationCount)
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_ViewpointVer.CitationCount);
}
else if (strAttributeName  ==  conzx_ViewpointVer.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_ViewpointVer.VersionCount);
}
else if (strAttributeName  ==  conzx_ViewpointVer.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.CreateDate);
}
else if (strAttributeName  ==  conzx_ViewpointVer.zxShareId)
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.zxShareId);
}
else if (strAttributeName  ==  conzx_ViewpointVer.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.Memo);
}
else if (strAttributeName  ==  conzx_ViewpointVer.TeammenberId)
{
mstrTeammenberId = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.TeammenberId);
}
else if (strAttributeName  ==  conzx_ViewpointVer.PdfDivLet)
{
mstrPdfDivLet = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.PdfDivLet);
}
else if (strAttributeName  ==  conzx_ViewpointVer.PdfDivTop)
{
mstrPdfDivTop = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.PdfDivTop);
}
else if (strAttributeName  ==  conzx_ViewpointVer.PdfPageNumIn)
{
mstrPdfPageNumIn = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.PdfPageNumIn);
}
else if (strAttributeName  ==  conzx_ViewpointVer.PdfPageTop)
{
mintPdfPageTop = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_ViewpointVer.PdfPageTop);
}
else if (strAttributeName  ==  conzx_ViewpointVer.PdfZoom)
{
mstrPdfZoom = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.PdfZoom);
}
else if (strAttributeName  ==  conzx_ViewpointVer.GroupTextId)
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.GroupTextId);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_ViewpointVer.ViewpointVId  ==  AttributeName[intIndex])
{
return mlngViewpointVId;
}
else if (conzx_ViewpointVer.zxViewpointId  ==  AttributeName[intIndex])
{
return mstrzxViewpointId;
}
else if (conzx_ViewpointVer.ViewpointName  ==  AttributeName[intIndex])
{
return mstrViewpointName;
}
else if (conzx_ViewpointVer.ViewpointContent  ==  AttributeName[intIndex])
{
return mstrViewpointContent;
}
else if (conzx_ViewpointVer.zxViewpointTypeId  ==  AttributeName[intIndex])
{
return mstrzxViewpointTypeId;
}
else if (conzx_ViewpointVer.Reason  ==  AttributeName[intIndex])
{
return mstrReason;
}
else if (conzx_ViewpointVer.Source  ==  AttributeName[intIndex])
{
return mstrSource;
}
else if (conzx_ViewpointVer.VPProposePeople  ==  AttributeName[intIndex])
{
return mstrVPProposePeople;
}
else if (conzx_ViewpointVer.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (conzx_ViewpointVer.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (conzx_ViewpointVer.TextId  ==  AttributeName[intIndex])
{
return mstrTextId;
}
else if (conzx_ViewpointVer.VoteCount  ==  AttributeName[intIndex])
{
return mintVoteCount;
}
else if (conzx_ViewpointVer.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (conzx_ViewpointVer.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (conzx_ViewpointVer.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (conzx_ViewpointVer.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (conzx_ViewpointVer.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_ViewpointVer.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_ViewpointVer.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conzx_ViewpointVer.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (conzx_ViewpointVer.PdfPageNum  ==  AttributeName[intIndex])
{
return mintPdfPageNum;
}
else if (conzx_ViewpointVer.CitationCount  ==  AttributeName[intIndex])
{
return mintCitationCount;
}
else if (conzx_ViewpointVer.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (conzx_ViewpointVer.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (conzx_ViewpointVer.zxShareId  ==  AttributeName[intIndex])
{
return mstrzxShareId;
}
else if (conzx_ViewpointVer.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conzx_ViewpointVer.TeammenberId  ==  AttributeName[intIndex])
{
return mstrTeammenberId;
}
else if (conzx_ViewpointVer.PdfDivLet  ==  AttributeName[intIndex])
{
return mstrPdfDivLet;
}
else if (conzx_ViewpointVer.PdfDivTop  ==  AttributeName[intIndex])
{
return mstrPdfDivTop;
}
else if (conzx_ViewpointVer.PdfPageNumIn  ==  AttributeName[intIndex])
{
return mstrPdfPageNumIn;
}
else if (conzx_ViewpointVer.PdfPageTop  ==  AttributeName[intIndex])
{
return mintPdfPageTop;
}
else if (conzx_ViewpointVer.PdfZoom  ==  AttributeName[intIndex])
{
return mstrPdfZoom;
}
else if (conzx_ViewpointVer.GroupTextId  ==  AttributeName[intIndex])
{
return mstrGroupTextId;
}
return null;
}
set
{
if (conzx_ViewpointVer.ViewpointVId  ==  AttributeName[intIndex])
{
mlngViewpointVId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_ViewpointVer.ViewpointVId);
}
else if (conzx_ViewpointVer.zxViewpointId  ==  AttributeName[intIndex])
{
mstrzxViewpointId = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.zxViewpointId);
}
else if (conzx_ViewpointVer.ViewpointName  ==  AttributeName[intIndex])
{
mstrViewpointName = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.ViewpointName);
}
else if (conzx_ViewpointVer.ViewpointContent  ==  AttributeName[intIndex])
{
mstrViewpointContent = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.ViewpointContent);
}
else if (conzx_ViewpointVer.zxViewpointTypeId  ==  AttributeName[intIndex])
{
mstrzxViewpointTypeId = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.zxViewpointTypeId);
}
else if (conzx_ViewpointVer.Reason  ==  AttributeName[intIndex])
{
mstrReason = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.Reason);
}
else if (conzx_ViewpointVer.Source  ==  AttributeName[intIndex])
{
mstrSource = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.Source);
}
else if (conzx_ViewpointVer.VPProposePeople  ==  AttributeName[intIndex])
{
mstrVPProposePeople = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.VPProposePeople);
}
else if (conzx_ViewpointVer.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_ViewpointVer.IsSubmit);
}
else if (conzx_ViewpointVer.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.UserTypeId);
}
else if (conzx_ViewpointVer.TextId  ==  AttributeName[intIndex])
{
mstrTextId = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.TextId);
}
else if (conzx_ViewpointVer.VoteCount  ==  AttributeName[intIndex])
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_ViewpointVer.VoteCount);
}
else if (conzx_ViewpointVer.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_ViewpointVer.AppraiseCount);
}
else if (conzx_ViewpointVer.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_ViewpointVer.Score);
}
else if (conzx_ViewpointVer.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_ViewpointVer.StuScore);
}
else if (conzx_ViewpointVer.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_ViewpointVer.TeaScore);
}
else if (conzx_ViewpointVer.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.UpdDate);
}
else if (conzx_ViewpointVer.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.UpdUser);
}
else if (conzx_ViewpointVer.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.IdCurrEduCls);
}
else if (conzx_ViewpointVer.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.PdfContent);
}
else if (conzx_ViewpointVer.PdfPageNum  ==  AttributeName[intIndex])
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_ViewpointVer.PdfPageNum);
}
else if (conzx_ViewpointVer.CitationCount  ==  AttributeName[intIndex])
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_ViewpointVer.CitationCount);
}
else if (conzx_ViewpointVer.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_ViewpointVer.VersionCount);
}
else if (conzx_ViewpointVer.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.CreateDate);
}
else if (conzx_ViewpointVer.zxShareId  ==  AttributeName[intIndex])
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.zxShareId);
}
else if (conzx_ViewpointVer.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.Memo);
}
else if (conzx_ViewpointVer.TeammenberId  ==  AttributeName[intIndex])
{
mstrTeammenberId = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.TeammenberId);
}
else if (conzx_ViewpointVer.PdfDivLet  ==  AttributeName[intIndex])
{
mstrPdfDivLet = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.PdfDivLet);
}
else if (conzx_ViewpointVer.PdfDivTop  ==  AttributeName[intIndex])
{
mstrPdfDivTop = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.PdfDivTop);
}
else if (conzx_ViewpointVer.PdfPageNumIn  ==  AttributeName[intIndex])
{
mstrPdfPageNumIn = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.PdfPageNumIn);
}
else if (conzx_ViewpointVer.PdfPageTop  ==  AttributeName[intIndex])
{
mintPdfPageTop = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_ViewpointVer.PdfPageTop);
}
else if (conzx_ViewpointVer.PdfZoom  ==  AttributeName[intIndex])
{
mstrPdfZoom = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.PdfZoom);
}
else if (conzx_ViewpointVer.GroupTextId  ==  AttributeName[intIndex])
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_ViewpointVer.GroupTextId);
}
}
}

/// <summary>
/// ViewpointVId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long ViewpointVId
{
get
{
return mlngViewpointVId;
}
set
{
 mlngViewpointVId = value;
//记录修改过的字段
 AddUpdatedFld(conzx_ViewpointVer.ViewpointVId);
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
 AddUpdatedFld(conzx_ViewpointVer.zxViewpointId);
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
 AddUpdatedFld(conzx_ViewpointVer.ViewpointName);
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
 AddUpdatedFld(conzx_ViewpointVer.ViewpointContent);
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
 AddUpdatedFld(conzx_ViewpointVer.zxViewpointTypeId);
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
 AddUpdatedFld(conzx_ViewpointVer.Reason);
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
 AddUpdatedFld(conzx_ViewpointVer.Source);
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
 AddUpdatedFld(conzx_ViewpointVer.VPProposePeople);
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
 AddUpdatedFld(conzx_ViewpointVer.IsSubmit);
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
 AddUpdatedFld(conzx_ViewpointVer.UserTypeId);
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
 AddUpdatedFld(conzx_ViewpointVer.TextId);
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
 AddUpdatedFld(conzx_ViewpointVer.VoteCount);
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
 AddUpdatedFld(conzx_ViewpointVer.AppraiseCount);
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
 AddUpdatedFld(conzx_ViewpointVer.Score);
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
 AddUpdatedFld(conzx_ViewpointVer.StuScore);
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
 AddUpdatedFld(conzx_ViewpointVer.TeaScore);
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
 AddUpdatedFld(conzx_ViewpointVer.UpdDate);
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
 AddUpdatedFld(conzx_ViewpointVer.UpdUser);
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
 AddUpdatedFld(conzx_ViewpointVer.IdCurrEduCls);
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
 AddUpdatedFld(conzx_ViewpointVer.PdfContent);
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
 AddUpdatedFld(conzx_ViewpointVer.PdfPageNum);
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
 AddUpdatedFld(conzx_ViewpointVer.CitationCount);
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
 AddUpdatedFld(conzx_ViewpointVer.VersionCount);
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
 AddUpdatedFld(conzx_ViewpointVer.CreateDate);
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
 AddUpdatedFld(conzx_ViewpointVer.zxShareId);
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
 AddUpdatedFld(conzx_ViewpointVer.Memo);
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
 AddUpdatedFld(conzx_ViewpointVer.TeammenberId);
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
 AddUpdatedFld(conzx_ViewpointVer.PdfDivLet);
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
 AddUpdatedFld(conzx_ViewpointVer.PdfDivTop);
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
 AddUpdatedFld(conzx_ViewpointVer.PdfPageNumIn);
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
 AddUpdatedFld(conzx_ViewpointVer.PdfPageTop);
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
 AddUpdatedFld(conzx_ViewpointVer.PdfZoom);
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
 AddUpdatedFld(conzx_ViewpointVer.GroupTextId);
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
  return mlngViewpointVId.ToString();
 }
 }
}
 /// <summary>
 /// 观点历史版本(zx_ViewpointVer)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_ViewpointVer
{
public const string _CurrTabName = "zx_ViewpointVer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ViewpointVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ViewpointVId", "zxViewpointId", "ViewpointName", "ViewpointContent", "zxViewpointTypeId", "Reason", "Source", "VPProposePeople", "IsSubmit", "UserTypeId", "TextId", "VoteCount", "AppraiseCount", "Score", "StuScore", "TeaScore", "UpdDate", "UpdUser", "IdCurrEduCls", "PdfContent", "PdfPageNum", "CitationCount", "VersionCount", "CreateDate", "zxShareId", "Memo", "TeammenberId", "PdfDivLet", "PdfDivTop", "PdfPageNumIn", "PdfPageTop", "PdfZoom", "GroupTextId"};
//以下是属性变量


 /// <summary>
 /// 常量:"ViewpointVId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointVId = "ViewpointVId";    //ViewpointVId

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
 /// 常量:"CreateDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateDate = "CreateDate";    //建立日期

 /// <summary>
 /// 常量:"zxShareId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxShareId = "zxShareId";    //分享Id

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