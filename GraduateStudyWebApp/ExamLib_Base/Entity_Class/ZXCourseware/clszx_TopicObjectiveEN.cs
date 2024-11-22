﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TopicObjectiveEN
 表名:zx_TopicObjective(01120708)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:56:20
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
 /// 表zx_TopicObjective的关键字(zxTopicObjectiveId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxTopicObjectiveId_zx_TopicObjective
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxTopicObjectiveId">表关键字</param>
public K_zxTopicObjectiveId_zx_TopicObjective(string strzxTopicObjectiveId)
{
if (IsValid(strzxTopicObjectiveId)) Value = strzxTopicObjectiveId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxTopicObjectiveId)
{
if (string.IsNullOrEmpty(strzxTopicObjectiveId) == true) return false;
if (strzxTopicObjectiveId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxTopicObjectiveId_zx_TopicObjective]类型的对象</returns>
public static implicit operator K_zxTopicObjectiveId_zx_TopicObjective(string value)
{
return new K_zxTopicObjectiveId_zx_TopicObjective(value);
}
}
 /// <summary>
 /// 中学客观事实数据(zx_TopicObjective)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_TopicObjectiveEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_TopicObjective"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxTopicObjectiveId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 28;
public static string[] AttributeName = new string[] {"zxTopicObjectiveId", "ObjectiveName", "ObjectiveContent", "ObjectiveType", "Conclusion", "TextId", "IsSubmit", "VoteCount", "AppraiseCount", "Score", "StuScore", "TeaScore", "IdCurrEduCls", "PdfContent", "PdfPageNum", "CitationCount", "VersionCount", "zxShareId", "CreateDate", "UpdDate", "UpdUser", "Memo", "PdfDivLet", "PdfDivTop", "PdfPageNumIn", "PdfPageTop", "PdfZoom", "GroupTextId"};

protected string mstrzxTopicObjectiveId;    //客观Id
protected string mstrObjectiveName;    //客观名称
protected string mstrObjectiveContent;    //客观内容
protected string mstrObjectiveType;    //客观类型
protected string mstrConclusion;    //结论
protected string mstrTextId;    //课件Id
protected bool mbolIsSubmit;    //是否提交
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
 public clszx_TopicObjectiveEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxTopicObjectiveId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxTopicObjectiveId">关键字:客观Id</param>
public clszx_TopicObjectiveEN(string strzxTopicObjectiveId)
 {
strzxTopicObjectiveId = strzxTopicObjectiveId.Replace("'", "''");
if (strzxTopicObjectiveId.Length > 8)
{
throw new Exception("在表:zx_TopicObjective中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxTopicObjectiveId)  ==  true)
{
throw new Exception("在表:zx_TopicObjective中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxTopicObjectiveId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxTopicObjectiveId = strzxTopicObjectiveId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxTopicObjectiveId");
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
if (strAttributeName  ==  conzx_TopicObjective.zxTopicObjectiveId)
{
return mstrzxTopicObjectiveId;
}
else if (strAttributeName  ==  conzx_TopicObjective.ObjectiveName)
{
return mstrObjectiveName;
}
else if (strAttributeName  ==  conzx_TopicObjective.ObjectiveContent)
{
return mstrObjectiveContent;
}
else if (strAttributeName  ==  conzx_TopicObjective.ObjectiveType)
{
return mstrObjectiveType;
}
else if (strAttributeName  ==  conzx_TopicObjective.Conclusion)
{
return mstrConclusion;
}
else if (strAttributeName  ==  conzx_TopicObjective.TextId)
{
return mstrTextId;
}
else if (strAttributeName  ==  conzx_TopicObjective.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  conzx_TopicObjective.VoteCount)
{
return mintVoteCount;
}
else if (strAttributeName  ==  conzx_TopicObjective.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  conzx_TopicObjective.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  conzx_TopicObjective.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  conzx_TopicObjective.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  conzx_TopicObjective.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conzx_TopicObjective.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  conzx_TopicObjective.PdfPageNum)
{
return mintPdfPageNum;
}
else if (strAttributeName  ==  conzx_TopicObjective.CitationCount)
{
return mintCitationCount;
}
else if (strAttributeName  ==  conzx_TopicObjective.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  conzx_TopicObjective.zxShareId)
{
return mstrzxShareId;
}
else if (strAttributeName  ==  conzx_TopicObjective.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  conzx_TopicObjective.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_TopicObjective.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_TopicObjective.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conzx_TopicObjective.PdfDivLet)
{
return mstrPdfDivLet;
}
else if (strAttributeName  ==  conzx_TopicObjective.PdfDivTop)
{
return mstrPdfDivTop;
}
else if (strAttributeName  ==  conzx_TopicObjective.PdfPageNumIn)
{
return mstrPdfPageNumIn;
}
else if (strAttributeName  ==  conzx_TopicObjective.PdfPageTop)
{
return mintPdfPageTop;
}
else if (strAttributeName  ==  conzx_TopicObjective.PdfZoom)
{
return mstrPdfZoom;
}
else if (strAttributeName  ==  conzx_TopicObjective.GroupTextId)
{
return mstrGroupTextId;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_TopicObjective.zxTopicObjectiveId)
{
mstrzxTopicObjectiveId = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.zxTopicObjectiveId);
}
else if (strAttributeName  ==  conzx_TopicObjective.ObjectiveName)
{
mstrObjectiveName = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.ObjectiveName);
}
else if (strAttributeName  ==  conzx_TopicObjective.ObjectiveContent)
{
mstrObjectiveContent = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.ObjectiveContent);
}
else if (strAttributeName  ==  conzx_TopicObjective.ObjectiveType)
{
mstrObjectiveType = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.ObjectiveType);
}
else if (strAttributeName  ==  conzx_TopicObjective.Conclusion)
{
mstrConclusion = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.Conclusion);
}
else if (strAttributeName  ==  conzx_TopicObjective.TextId)
{
mstrTextId = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.TextId);
}
else if (strAttributeName  ==  conzx_TopicObjective.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_TopicObjective.IsSubmit);
}
else if (strAttributeName  ==  conzx_TopicObjective.VoteCount)
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_TopicObjective.VoteCount);
}
else if (strAttributeName  ==  conzx_TopicObjective.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_TopicObjective.AppraiseCount);
}
else if (strAttributeName  ==  conzx_TopicObjective.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_TopicObjective.Score);
}
else if (strAttributeName  ==  conzx_TopicObjective.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_TopicObjective.StuScore);
}
else if (strAttributeName  ==  conzx_TopicObjective.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_TopicObjective.TeaScore);
}
else if (strAttributeName  ==  conzx_TopicObjective.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.IdCurrEduCls);
}
else if (strAttributeName  ==  conzx_TopicObjective.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.PdfContent);
}
else if (strAttributeName  ==  conzx_TopicObjective.PdfPageNum)
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_TopicObjective.PdfPageNum);
}
else if (strAttributeName  ==  conzx_TopicObjective.CitationCount)
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_TopicObjective.CitationCount);
}
else if (strAttributeName  ==  conzx_TopicObjective.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_TopicObjective.VersionCount);
}
else if (strAttributeName  ==  conzx_TopicObjective.zxShareId)
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.zxShareId);
}
else if (strAttributeName  ==  conzx_TopicObjective.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.CreateDate);
}
else if (strAttributeName  ==  conzx_TopicObjective.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.UpdDate);
}
else if (strAttributeName  ==  conzx_TopicObjective.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.UpdUser);
}
else if (strAttributeName  ==  conzx_TopicObjective.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.Memo);
}
else if (strAttributeName  ==  conzx_TopicObjective.PdfDivLet)
{
mstrPdfDivLet = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.PdfDivLet);
}
else if (strAttributeName  ==  conzx_TopicObjective.PdfDivTop)
{
mstrPdfDivTop = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.PdfDivTop);
}
else if (strAttributeName  ==  conzx_TopicObjective.PdfPageNumIn)
{
mstrPdfPageNumIn = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.PdfPageNumIn);
}
else if (strAttributeName  ==  conzx_TopicObjective.PdfPageTop)
{
mintPdfPageTop = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_TopicObjective.PdfPageTop);
}
else if (strAttributeName  ==  conzx_TopicObjective.PdfZoom)
{
mstrPdfZoom = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.PdfZoom);
}
else if (strAttributeName  ==  conzx_TopicObjective.GroupTextId)
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.GroupTextId);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_TopicObjective.zxTopicObjectiveId  ==  AttributeName[intIndex])
{
return mstrzxTopicObjectiveId;
}
else if (conzx_TopicObjective.ObjectiveName  ==  AttributeName[intIndex])
{
return mstrObjectiveName;
}
else if (conzx_TopicObjective.ObjectiveContent  ==  AttributeName[intIndex])
{
return mstrObjectiveContent;
}
else if (conzx_TopicObjective.ObjectiveType  ==  AttributeName[intIndex])
{
return mstrObjectiveType;
}
else if (conzx_TopicObjective.Conclusion  ==  AttributeName[intIndex])
{
return mstrConclusion;
}
else if (conzx_TopicObjective.TextId  ==  AttributeName[intIndex])
{
return mstrTextId;
}
else if (conzx_TopicObjective.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (conzx_TopicObjective.VoteCount  ==  AttributeName[intIndex])
{
return mintVoteCount;
}
else if (conzx_TopicObjective.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (conzx_TopicObjective.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (conzx_TopicObjective.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (conzx_TopicObjective.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (conzx_TopicObjective.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conzx_TopicObjective.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (conzx_TopicObjective.PdfPageNum  ==  AttributeName[intIndex])
{
return mintPdfPageNum;
}
else if (conzx_TopicObjective.CitationCount  ==  AttributeName[intIndex])
{
return mintCitationCount;
}
else if (conzx_TopicObjective.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (conzx_TopicObjective.zxShareId  ==  AttributeName[intIndex])
{
return mstrzxShareId;
}
else if (conzx_TopicObjective.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (conzx_TopicObjective.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_TopicObjective.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_TopicObjective.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conzx_TopicObjective.PdfDivLet  ==  AttributeName[intIndex])
{
return mstrPdfDivLet;
}
else if (conzx_TopicObjective.PdfDivTop  ==  AttributeName[intIndex])
{
return mstrPdfDivTop;
}
else if (conzx_TopicObjective.PdfPageNumIn  ==  AttributeName[intIndex])
{
return mstrPdfPageNumIn;
}
else if (conzx_TopicObjective.PdfPageTop  ==  AttributeName[intIndex])
{
return mintPdfPageTop;
}
else if (conzx_TopicObjective.PdfZoom  ==  AttributeName[intIndex])
{
return mstrPdfZoom;
}
else if (conzx_TopicObjective.GroupTextId  ==  AttributeName[intIndex])
{
return mstrGroupTextId;
}
return null;
}
set
{
if (conzx_TopicObjective.zxTopicObjectiveId  ==  AttributeName[intIndex])
{
mstrzxTopicObjectiveId = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.zxTopicObjectiveId);
}
else if (conzx_TopicObjective.ObjectiveName  ==  AttributeName[intIndex])
{
mstrObjectiveName = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.ObjectiveName);
}
else if (conzx_TopicObjective.ObjectiveContent  ==  AttributeName[intIndex])
{
mstrObjectiveContent = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.ObjectiveContent);
}
else if (conzx_TopicObjective.ObjectiveType  ==  AttributeName[intIndex])
{
mstrObjectiveType = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.ObjectiveType);
}
else if (conzx_TopicObjective.Conclusion  ==  AttributeName[intIndex])
{
mstrConclusion = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.Conclusion);
}
else if (conzx_TopicObjective.TextId  ==  AttributeName[intIndex])
{
mstrTextId = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.TextId);
}
else if (conzx_TopicObjective.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_TopicObjective.IsSubmit);
}
else if (conzx_TopicObjective.VoteCount  ==  AttributeName[intIndex])
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_TopicObjective.VoteCount);
}
else if (conzx_TopicObjective.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_TopicObjective.AppraiseCount);
}
else if (conzx_TopicObjective.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_TopicObjective.Score);
}
else if (conzx_TopicObjective.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_TopicObjective.StuScore);
}
else if (conzx_TopicObjective.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_TopicObjective.TeaScore);
}
else if (conzx_TopicObjective.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.IdCurrEduCls);
}
else if (conzx_TopicObjective.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.PdfContent);
}
else if (conzx_TopicObjective.PdfPageNum  ==  AttributeName[intIndex])
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_TopicObjective.PdfPageNum);
}
else if (conzx_TopicObjective.CitationCount  ==  AttributeName[intIndex])
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_TopicObjective.CitationCount);
}
else if (conzx_TopicObjective.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_TopicObjective.VersionCount);
}
else if (conzx_TopicObjective.zxShareId  ==  AttributeName[intIndex])
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.zxShareId);
}
else if (conzx_TopicObjective.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.CreateDate);
}
else if (conzx_TopicObjective.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.UpdDate);
}
else if (conzx_TopicObjective.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.UpdUser);
}
else if (conzx_TopicObjective.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.Memo);
}
else if (conzx_TopicObjective.PdfDivLet  ==  AttributeName[intIndex])
{
mstrPdfDivLet = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.PdfDivLet);
}
else if (conzx_TopicObjective.PdfDivTop  ==  AttributeName[intIndex])
{
mstrPdfDivTop = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.PdfDivTop);
}
else if (conzx_TopicObjective.PdfPageNumIn  ==  AttributeName[intIndex])
{
mstrPdfPageNumIn = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.PdfPageNumIn);
}
else if (conzx_TopicObjective.PdfPageTop  ==  AttributeName[intIndex])
{
mintPdfPageTop = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_TopicObjective.PdfPageTop);
}
else if (conzx_TopicObjective.PdfZoom  ==  AttributeName[intIndex])
{
mstrPdfZoom = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.PdfZoom);
}
else if (conzx_TopicObjective.GroupTextId  ==  AttributeName[intIndex])
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_TopicObjective.GroupTextId);
}
}
}

/// <summary>
/// 客观Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxTopicObjectiveId
{
get
{
return mstrzxTopicObjectiveId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxTopicObjectiveId = value;
}
else
{
 mstrzxTopicObjectiveId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_TopicObjective.zxTopicObjectiveId);
}
}
/// <summary>
/// 客观名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ObjectiveName
{
get
{
return mstrObjectiveName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrObjectiveName = value;
}
else
{
 mstrObjectiveName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_TopicObjective.ObjectiveName);
}
}
/// <summary>
/// 客观内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ObjectiveContent
{
get
{
return mstrObjectiveContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrObjectiveContent = value;
}
else
{
 mstrObjectiveContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_TopicObjective.ObjectiveContent);
}
}
/// <summary>
/// 客观类型(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ObjectiveType
{
get
{
return mstrObjectiveType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrObjectiveType = value;
}
else
{
 mstrObjectiveType = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_TopicObjective.ObjectiveType);
}
}
/// <summary>
/// 结论(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Conclusion
{
get
{
return mstrConclusion;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConclusion = value;
}
else
{
 mstrConclusion = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_TopicObjective.Conclusion);
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
 AddUpdatedFld(conzx_TopicObjective.TextId);
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
 AddUpdatedFld(conzx_TopicObjective.IsSubmit);
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
 AddUpdatedFld(conzx_TopicObjective.VoteCount);
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
 AddUpdatedFld(conzx_TopicObjective.AppraiseCount);
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
 AddUpdatedFld(conzx_TopicObjective.Score);
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
 AddUpdatedFld(conzx_TopicObjective.StuScore);
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
 AddUpdatedFld(conzx_TopicObjective.TeaScore);
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
 AddUpdatedFld(conzx_TopicObjective.IdCurrEduCls);
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
 AddUpdatedFld(conzx_TopicObjective.PdfContent);
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
 AddUpdatedFld(conzx_TopicObjective.PdfPageNum);
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
 AddUpdatedFld(conzx_TopicObjective.CitationCount);
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
 AddUpdatedFld(conzx_TopicObjective.VersionCount);
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
 AddUpdatedFld(conzx_TopicObjective.zxShareId);
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
 AddUpdatedFld(conzx_TopicObjective.CreateDate);
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
 AddUpdatedFld(conzx_TopicObjective.UpdDate);
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
 AddUpdatedFld(conzx_TopicObjective.UpdUser);
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
 AddUpdatedFld(conzx_TopicObjective.Memo);
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
 AddUpdatedFld(conzx_TopicObjective.PdfDivLet);
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
 AddUpdatedFld(conzx_TopicObjective.PdfDivTop);
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
 AddUpdatedFld(conzx_TopicObjective.PdfPageNumIn);
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
 AddUpdatedFld(conzx_TopicObjective.PdfPageTop);
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
 AddUpdatedFld(conzx_TopicObjective.PdfZoom);
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
 AddUpdatedFld(conzx_TopicObjective.GroupTextId);
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
  return mstrzxTopicObjectiveId;
 }
 }
}
 /// <summary>
 /// 中学客观事实数据(zx_TopicObjective)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_TopicObjective
{
public const string _CurrTabName = "zx_TopicObjective"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxTopicObjectiveId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxTopicObjectiveId", "ObjectiveName", "ObjectiveContent", "ObjectiveType", "Conclusion", "TextId", "IsSubmit", "VoteCount", "AppraiseCount", "Score", "StuScore", "TeaScore", "IdCurrEduCls", "PdfContent", "PdfPageNum", "CitationCount", "VersionCount", "zxShareId", "CreateDate", "UpdDate", "UpdUser", "Memo", "PdfDivLet", "PdfDivTop", "PdfPageNumIn", "PdfPageTop", "PdfZoom", "GroupTextId"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxTopicObjectiveId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxTopicObjectiveId = "zxTopicObjectiveId";    //客观Id

 /// <summary>
 /// 常量:"ObjectiveName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ObjectiveName = "ObjectiveName";    //客观名称

 /// <summary>
 /// 常量:"ObjectiveContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ObjectiveContent = "ObjectiveContent";    //客观内容

 /// <summary>
 /// 常量:"ObjectiveType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ObjectiveType = "ObjectiveType";    //客观类型

 /// <summary>
 /// 常量:"Conclusion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Conclusion = "Conclusion";    //结论

 /// <summary>
 /// 常量:"TextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextId = "TextId";    //课件Id

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

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