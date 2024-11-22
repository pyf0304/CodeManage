
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_SkillVerEN
 表名:zx_SkillVer(01120738)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:07:59
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
 /// 表zx_SkillVer的关键字(SkillVId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_SkillVId_zx_SkillVer
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngSkillVId">表关键字</param>
public K_SkillVId_zx_SkillVer(long lngSkillVId)
{
if (IsValid(lngSkillVId)) Value = lngSkillVId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngSkillVId)
{
if (lngSkillVId == 0) return false;
if (lngSkillVId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_SkillVId_zx_SkillVer]类型的对象</returns>
public static implicit operator K_SkillVId_zx_SkillVer(long value)
{
return new K_SkillVId_zx_SkillVer(value);
}
}
 /// <summary>
 /// 技能历史版本(zx_SkillVer)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_SkillVerEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_SkillVer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "SkillVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 29;
public static string[] AttributeName = new string[] {"SkillVId", "zxSkillId", "SkillName", "zxOperationTypeId", "Process", "zxLevelId", "UpdUser", "CreateDate", "UpdDate", "IsSubmit", "TextId", "VoteCount", "AppraiseCount", "Score", "StuScore", "TeaScore", "IdCurrEduCls", "PdfContent", "PdfPageNum", "CitationCount", "VersionCount", "zxShareId", "Memo", "PdfDivLet", "PdfDivTop", "PdfPageNumIn", "PdfPageTop", "PdfZoom", "GroupTextId"};

protected long mlngSkillVId;    //SkillVId
protected string mstrzxSkillId;    //技能Id
protected string mstrSkillName;    //技能名称
protected string mstrzxOperationTypeId;    //操作类型ID
protected string mstrProcess;    //实施过程
protected string mstrzxLevelId;    //级别Id
protected string mstrUpdUser;    //修改人
protected string mstrCreateDate;    //建立日期
protected string mstrUpdDate;    //修改日期
protected bool mbolIsSubmit;    //是否提交
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
protected string mstrMemo;    //备注
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
 public clszx_SkillVerEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SkillVId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngSkillVId">关键字:SkillVId</param>
public clszx_SkillVerEN(long lngSkillVId)
 {
 if (lngSkillVId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngSkillVId = lngSkillVId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SkillVId");
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
if (strAttributeName  ==  conzx_SkillVer.SkillVId)
{
return mlngSkillVId;
}
else if (strAttributeName  ==  conzx_SkillVer.zxSkillId)
{
return mstrzxSkillId;
}
else if (strAttributeName  ==  conzx_SkillVer.SkillName)
{
return mstrSkillName;
}
else if (strAttributeName  ==  conzx_SkillVer.zxOperationTypeId)
{
return mstrzxOperationTypeId;
}
else if (strAttributeName  ==  conzx_SkillVer.Process)
{
return mstrProcess;
}
else if (strAttributeName  ==  conzx_SkillVer.zxLevelId)
{
return mstrzxLevelId;
}
else if (strAttributeName  ==  conzx_SkillVer.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_SkillVer.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  conzx_SkillVer.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_SkillVer.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  conzx_SkillVer.TextId)
{
return mstrTextId;
}
else if (strAttributeName  ==  conzx_SkillVer.VoteCount)
{
return mintVoteCount;
}
else if (strAttributeName  ==  conzx_SkillVer.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  conzx_SkillVer.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  conzx_SkillVer.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  conzx_SkillVer.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  conzx_SkillVer.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conzx_SkillVer.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  conzx_SkillVer.PdfPageNum)
{
return mintPdfPageNum;
}
else if (strAttributeName  ==  conzx_SkillVer.CitationCount)
{
return mintCitationCount;
}
else if (strAttributeName  ==  conzx_SkillVer.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  conzx_SkillVer.zxShareId)
{
return mstrzxShareId;
}
else if (strAttributeName  ==  conzx_SkillVer.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conzx_SkillVer.PdfDivLet)
{
return mstrPdfDivLet;
}
else if (strAttributeName  ==  conzx_SkillVer.PdfDivTop)
{
return mstrPdfDivTop;
}
else if (strAttributeName  ==  conzx_SkillVer.PdfPageNumIn)
{
return mstrPdfPageNumIn;
}
else if (strAttributeName  ==  conzx_SkillVer.PdfPageTop)
{
return mintPdfPageTop;
}
else if (strAttributeName  ==  conzx_SkillVer.PdfZoom)
{
return mstrPdfZoom;
}
else if (strAttributeName  ==  conzx_SkillVer.GroupTextId)
{
return mstrGroupTextId;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_SkillVer.SkillVId)
{
mlngSkillVId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SkillVer.SkillVId);
}
else if (strAttributeName  ==  conzx_SkillVer.zxSkillId)
{
mstrzxSkillId = value.ToString();
 AddUpdatedFld(conzx_SkillVer.zxSkillId);
}
else if (strAttributeName  ==  conzx_SkillVer.SkillName)
{
mstrSkillName = value.ToString();
 AddUpdatedFld(conzx_SkillVer.SkillName);
}
else if (strAttributeName  ==  conzx_SkillVer.zxOperationTypeId)
{
mstrzxOperationTypeId = value.ToString();
 AddUpdatedFld(conzx_SkillVer.zxOperationTypeId);
}
else if (strAttributeName  ==  conzx_SkillVer.Process)
{
mstrProcess = value.ToString();
 AddUpdatedFld(conzx_SkillVer.Process);
}
else if (strAttributeName  ==  conzx_SkillVer.zxLevelId)
{
mstrzxLevelId = value.ToString();
 AddUpdatedFld(conzx_SkillVer.zxLevelId);
}
else if (strAttributeName  ==  conzx_SkillVer.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_SkillVer.UpdUser);
}
else if (strAttributeName  ==  conzx_SkillVer.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conzx_SkillVer.CreateDate);
}
else if (strAttributeName  ==  conzx_SkillVer.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_SkillVer.UpdDate);
}
else if (strAttributeName  ==  conzx_SkillVer.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_SkillVer.IsSubmit);
}
else if (strAttributeName  ==  conzx_SkillVer.TextId)
{
mstrTextId = value.ToString();
 AddUpdatedFld(conzx_SkillVer.TextId);
}
else if (strAttributeName  ==  conzx_SkillVer.VoteCount)
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SkillVer.VoteCount);
}
else if (strAttributeName  ==  conzx_SkillVer.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SkillVer.AppraiseCount);
}
else if (strAttributeName  ==  conzx_SkillVer.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_SkillVer.Score);
}
else if (strAttributeName  ==  conzx_SkillVer.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_SkillVer.StuScore);
}
else if (strAttributeName  ==  conzx_SkillVer.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_SkillVer.TeaScore);
}
else if (strAttributeName  ==  conzx_SkillVer.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_SkillVer.IdCurrEduCls);
}
else if (strAttributeName  ==  conzx_SkillVer.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(conzx_SkillVer.PdfContent);
}
else if (strAttributeName  ==  conzx_SkillVer.PdfPageNum)
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SkillVer.PdfPageNum);
}
else if (strAttributeName  ==  conzx_SkillVer.CitationCount)
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SkillVer.CitationCount);
}
else if (strAttributeName  ==  conzx_SkillVer.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SkillVer.VersionCount);
}
else if (strAttributeName  ==  conzx_SkillVer.zxShareId)
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(conzx_SkillVer.zxShareId);
}
else if (strAttributeName  ==  conzx_SkillVer.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_SkillVer.Memo);
}
else if (strAttributeName  ==  conzx_SkillVer.PdfDivLet)
{
mstrPdfDivLet = value.ToString();
 AddUpdatedFld(conzx_SkillVer.PdfDivLet);
}
else if (strAttributeName  ==  conzx_SkillVer.PdfDivTop)
{
mstrPdfDivTop = value.ToString();
 AddUpdatedFld(conzx_SkillVer.PdfDivTop);
}
else if (strAttributeName  ==  conzx_SkillVer.PdfPageNumIn)
{
mstrPdfPageNumIn = value.ToString();
 AddUpdatedFld(conzx_SkillVer.PdfPageNumIn);
}
else if (strAttributeName  ==  conzx_SkillVer.PdfPageTop)
{
mintPdfPageTop = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SkillVer.PdfPageTop);
}
else if (strAttributeName  ==  conzx_SkillVer.PdfZoom)
{
mstrPdfZoom = value.ToString();
 AddUpdatedFld(conzx_SkillVer.PdfZoom);
}
else if (strAttributeName  ==  conzx_SkillVer.GroupTextId)
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_SkillVer.GroupTextId);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_SkillVer.SkillVId  ==  AttributeName[intIndex])
{
return mlngSkillVId;
}
else if (conzx_SkillVer.zxSkillId  ==  AttributeName[intIndex])
{
return mstrzxSkillId;
}
else if (conzx_SkillVer.SkillName  ==  AttributeName[intIndex])
{
return mstrSkillName;
}
else if (conzx_SkillVer.zxOperationTypeId  ==  AttributeName[intIndex])
{
return mstrzxOperationTypeId;
}
else if (conzx_SkillVer.Process  ==  AttributeName[intIndex])
{
return mstrProcess;
}
else if (conzx_SkillVer.zxLevelId  ==  AttributeName[intIndex])
{
return mstrzxLevelId;
}
else if (conzx_SkillVer.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_SkillVer.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (conzx_SkillVer.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_SkillVer.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (conzx_SkillVer.TextId  ==  AttributeName[intIndex])
{
return mstrTextId;
}
else if (conzx_SkillVer.VoteCount  ==  AttributeName[intIndex])
{
return mintVoteCount;
}
else if (conzx_SkillVer.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (conzx_SkillVer.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (conzx_SkillVer.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (conzx_SkillVer.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (conzx_SkillVer.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conzx_SkillVer.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (conzx_SkillVer.PdfPageNum  ==  AttributeName[intIndex])
{
return mintPdfPageNum;
}
else if (conzx_SkillVer.CitationCount  ==  AttributeName[intIndex])
{
return mintCitationCount;
}
else if (conzx_SkillVer.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (conzx_SkillVer.zxShareId  ==  AttributeName[intIndex])
{
return mstrzxShareId;
}
else if (conzx_SkillVer.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conzx_SkillVer.PdfDivLet  ==  AttributeName[intIndex])
{
return mstrPdfDivLet;
}
else if (conzx_SkillVer.PdfDivTop  ==  AttributeName[intIndex])
{
return mstrPdfDivTop;
}
else if (conzx_SkillVer.PdfPageNumIn  ==  AttributeName[intIndex])
{
return mstrPdfPageNumIn;
}
else if (conzx_SkillVer.PdfPageTop  ==  AttributeName[intIndex])
{
return mintPdfPageTop;
}
else if (conzx_SkillVer.PdfZoom  ==  AttributeName[intIndex])
{
return mstrPdfZoom;
}
else if (conzx_SkillVer.GroupTextId  ==  AttributeName[intIndex])
{
return mstrGroupTextId;
}
return null;
}
set
{
if (conzx_SkillVer.SkillVId  ==  AttributeName[intIndex])
{
mlngSkillVId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SkillVer.SkillVId);
}
else if (conzx_SkillVer.zxSkillId  ==  AttributeName[intIndex])
{
mstrzxSkillId = value.ToString();
 AddUpdatedFld(conzx_SkillVer.zxSkillId);
}
else if (conzx_SkillVer.SkillName  ==  AttributeName[intIndex])
{
mstrSkillName = value.ToString();
 AddUpdatedFld(conzx_SkillVer.SkillName);
}
else if (conzx_SkillVer.zxOperationTypeId  ==  AttributeName[intIndex])
{
mstrzxOperationTypeId = value.ToString();
 AddUpdatedFld(conzx_SkillVer.zxOperationTypeId);
}
else if (conzx_SkillVer.Process  ==  AttributeName[intIndex])
{
mstrProcess = value.ToString();
 AddUpdatedFld(conzx_SkillVer.Process);
}
else if (conzx_SkillVer.zxLevelId  ==  AttributeName[intIndex])
{
mstrzxLevelId = value.ToString();
 AddUpdatedFld(conzx_SkillVer.zxLevelId);
}
else if (conzx_SkillVer.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_SkillVer.UpdUser);
}
else if (conzx_SkillVer.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conzx_SkillVer.CreateDate);
}
else if (conzx_SkillVer.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_SkillVer.UpdDate);
}
else if (conzx_SkillVer.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_SkillVer.IsSubmit);
}
else if (conzx_SkillVer.TextId  ==  AttributeName[intIndex])
{
mstrTextId = value.ToString();
 AddUpdatedFld(conzx_SkillVer.TextId);
}
else if (conzx_SkillVer.VoteCount  ==  AttributeName[intIndex])
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SkillVer.VoteCount);
}
else if (conzx_SkillVer.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SkillVer.AppraiseCount);
}
else if (conzx_SkillVer.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_SkillVer.Score);
}
else if (conzx_SkillVer.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_SkillVer.StuScore);
}
else if (conzx_SkillVer.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_SkillVer.TeaScore);
}
else if (conzx_SkillVer.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_SkillVer.IdCurrEduCls);
}
else if (conzx_SkillVer.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(conzx_SkillVer.PdfContent);
}
else if (conzx_SkillVer.PdfPageNum  ==  AttributeName[intIndex])
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SkillVer.PdfPageNum);
}
else if (conzx_SkillVer.CitationCount  ==  AttributeName[intIndex])
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SkillVer.CitationCount);
}
else if (conzx_SkillVer.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SkillVer.VersionCount);
}
else if (conzx_SkillVer.zxShareId  ==  AttributeName[intIndex])
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(conzx_SkillVer.zxShareId);
}
else if (conzx_SkillVer.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_SkillVer.Memo);
}
else if (conzx_SkillVer.PdfDivLet  ==  AttributeName[intIndex])
{
mstrPdfDivLet = value.ToString();
 AddUpdatedFld(conzx_SkillVer.PdfDivLet);
}
else if (conzx_SkillVer.PdfDivTop  ==  AttributeName[intIndex])
{
mstrPdfDivTop = value.ToString();
 AddUpdatedFld(conzx_SkillVer.PdfDivTop);
}
else if (conzx_SkillVer.PdfPageNumIn  ==  AttributeName[intIndex])
{
mstrPdfPageNumIn = value.ToString();
 AddUpdatedFld(conzx_SkillVer.PdfPageNumIn);
}
else if (conzx_SkillVer.PdfPageTop  ==  AttributeName[intIndex])
{
mintPdfPageTop = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SkillVer.PdfPageTop);
}
else if (conzx_SkillVer.PdfZoom  ==  AttributeName[intIndex])
{
mstrPdfZoom = value.ToString();
 AddUpdatedFld(conzx_SkillVer.PdfZoom);
}
else if (conzx_SkillVer.GroupTextId  ==  AttributeName[intIndex])
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_SkillVer.GroupTextId);
}
}
}

/// <summary>
/// SkillVId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long SkillVId
{
get
{
return mlngSkillVId;
}
set
{
 mlngSkillVId = value;
//记录修改过的字段
 AddUpdatedFld(conzx_SkillVer.SkillVId);
}
}
/// <summary>
/// 技能Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxSkillId
{
get
{
return mstrzxSkillId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxSkillId = value;
}
else
{
 mstrzxSkillId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_SkillVer.zxSkillId);
}
}
/// <summary>
/// 技能名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SkillName
{
get
{
return mstrSkillName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSkillName = value;
}
else
{
 mstrSkillName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_SkillVer.SkillName);
}
}
/// <summary>
/// 操作类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxOperationTypeId
{
get
{
return mstrzxOperationTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxOperationTypeId = value;
}
else
{
 mstrzxOperationTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_SkillVer.zxOperationTypeId);
}
}
/// <summary>
/// 实施过程(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Process
{
get
{
return mstrProcess;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProcess = value;
}
else
{
 mstrProcess = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_SkillVer.Process);
}
}
/// <summary>
/// 级别Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxLevelId
{
get
{
return mstrzxLevelId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxLevelId = value;
}
else
{
 mstrzxLevelId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_SkillVer.zxLevelId);
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
 AddUpdatedFld(conzx_SkillVer.UpdUser);
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
 AddUpdatedFld(conzx_SkillVer.CreateDate);
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
 AddUpdatedFld(conzx_SkillVer.UpdDate);
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
 AddUpdatedFld(conzx_SkillVer.IsSubmit);
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
 AddUpdatedFld(conzx_SkillVer.TextId);
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
 AddUpdatedFld(conzx_SkillVer.VoteCount);
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
 AddUpdatedFld(conzx_SkillVer.AppraiseCount);
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
 AddUpdatedFld(conzx_SkillVer.Score);
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
 AddUpdatedFld(conzx_SkillVer.StuScore);
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
 AddUpdatedFld(conzx_SkillVer.TeaScore);
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
 AddUpdatedFld(conzx_SkillVer.IdCurrEduCls);
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
 AddUpdatedFld(conzx_SkillVer.PdfContent);
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
 AddUpdatedFld(conzx_SkillVer.PdfPageNum);
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
 AddUpdatedFld(conzx_SkillVer.CitationCount);
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
 AddUpdatedFld(conzx_SkillVer.VersionCount);
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
 AddUpdatedFld(conzx_SkillVer.zxShareId);
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
 AddUpdatedFld(conzx_SkillVer.Memo);
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
 AddUpdatedFld(conzx_SkillVer.PdfDivLet);
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
 AddUpdatedFld(conzx_SkillVer.PdfDivTop);
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
 AddUpdatedFld(conzx_SkillVer.PdfPageNumIn);
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
 AddUpdatedFld(conzx_SkillVer.PdfPageTop);
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
 AddUpdatedFld(conzx_SkillVer.PdfZoom);
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
 AddUpdatedFld(conzx_SkillVer.GroupTextId);
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
  return mlngSkillVId.ToString();
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
  return mstrzxLevelId;
 }
 }
}
 /// <summary>
 /// 技能历史版本(zx_SkillVer)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_SkillVer
{
public const string _CurrTabName = "zx_SkillVer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SkillVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"SkillVId", "zxSkillId", "SkillName", "zxOperationTypeId", "Process", "zxLevelId", "UpdUser", "CreateDate", "UpdDate", "IsSubmit", "TextId", "VoteCount", "AppraiseCount", "Score", "StuScore", "TeaScore", "IdCurrEduCls", "PdfContent", "PdfPageNum", "CitationCount", "VersionCount", "zxShareId", "Memo", "PdfDivLet", "PdfDivTop", "PdfPageNumIn", "PdfPageTop", "PdfZoom", "GroupTextId"};
//以下是属性变量


 /// <summary>
 /// 常量:"SkillVId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SkillVId = "SkillVId";    //SkillVId

 /// <summary>
 /// 常量:"zxSkillId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxSkillId = "zxSkillId";    //技能Id

 /// <summary>
 /// 常量:"SkillName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SkillName = "SkillName";    //技能名称

 /// <summary>
 /// 常量:"zxOperationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxOperationTypeId = "zxOperationTypeId";    //操作类型ID

 /// <summary>
 /// 常量:"Process"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Process = "Process";    //实施过程

 /// <summary>
 /// 常量:"zxLevelId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxLevelId = "zxLevelId";    //级别Id

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

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
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

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