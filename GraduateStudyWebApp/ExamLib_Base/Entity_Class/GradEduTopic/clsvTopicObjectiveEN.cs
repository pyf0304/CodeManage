
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTopicObjectiveEN
 表名:vTopicObjective(01120617)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:22:05
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 表vTopicObjective的关键字(TopicObjectiveId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TopicObjectiveId_vTopicObjective
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTopicObjectiveId">表关键字</param>
public K_TopicObjectiveId_vTopicObjective(string strTopicObjectiveId)
{
if (IsValid(strTopicObjectiveId)) Value = strTopicObjectiveId;
else
{
Value = null;
}
}
private static bool IsValid(string strTopicObjectiveId)
{
if (string.IsNullOrEmpty(strTopicObjectiveId) == true) return false;
if (strTopicObjectiveId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TopicObjectiveId_vTopicObjective]类型的对象</returns>
public static implicit operator K_TopicObjectiveId_vTopicObjective(string value)
{
return new K_TopicObjectiveId_vTopicObjective(value);
}
}
 /// <summary>
 /// 客观表视图(vTopicObjective)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvTopicObjectiveEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vTopicObjective"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TopicObjectiveId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 27;
public static string[] AttributeName = new string[] {"PaperTitle", "PaperContent", "Author", "Keyword", "TopicObjectiveId", "ObjectiveName", "ObjectiveContent", "ObjectiveType", "SourceId", "Conclusion", "IsSubmit", "UpdDate", "Memo", "ObjectiveTypeName", "CitationCount", "AppraiseCount", "Score", "StuScore", "TeaScore", "IdCurrEduCls", "PdfContent", "PdfPageNum", "OkCount", "VersionCount", "CreateDate", "ShareId", "UpdUser"};

protected string mstrPaperTitle;    //论文标题
protected string mstrPaperContent;    //主题内容
protected string mstrAuthor;    //作者
protected string mstrKeyword;    //关键字
protected string mstrTopicObjectiveId;    //客观Id
protected string mstrObjectiveName;    //客观名称
protected string mstrObjectiveContent;    //客观内容
protected string mstrObjectiveType;    //客观类型
protected string mstrSourceId;    //来源Id
protected string mstrConclusion;    //结论
protected bool mbolIsSubmit;    //是否提交
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrObjectiveTypeName;    //ObjectiveTypeName
protected int? mintCitationCount;    //引用统计
protected int? mintAppraiseCount;    //评论数
protected float? mfltScore;    //评分
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrPdfContent;    //Pdf内容
protected int? mintPdfPageNum;    //Pdf页码
protected int? mintOkCount;    //点赞统计
protected int? mintVersionCount;    //版本统计
protected string mstrCreateDate;    //建立日期
protected string mstrShareId;    //分享Id
protected string mstrUpdUser;    //修改人

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvTopicObjectiveEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TopicObjectiveId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strTopicObjectiveId">关键字:客观Id</param>
public clsvTopicObjectiveEN(string strTopicObjectiveId)
 {
strTopicObjectiveId = strTopicObjectiveId.Replace("'", "''");
if (strTopicObjectiveId.Length > 8)
{
throw new Exception("在表:vTopicObjective中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTopicObjectiveId)  ==  true)
{
throw new Exception("在表:vTopicObjective中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTopicObjectiveId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTopicObjectiveId = strTopicObjectiveId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TopicObjectiveId");
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
if (strAttributeName  ==  convTopicObjective.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convTopicObjective.PaperContent)
{
return mstrPaperContent;
}
else if (strAttributeName  ==  convTopicObjective.Author)
{
return mstrAuthor;
}
else if (strAttributeName  ==  convTopicObjective.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  convTopicObjective.TopicObjectiveId)
{
return mstrTopicObjectiveId;
}
else if (strAttributeName  ==  convTopicObjective.ObjectiveName)
{
return mstrObjectiveName;
}
else if (strAttributeName  ==  convTopicObjective.ObjectiveContent)
{
return mstrObjectiveContent;
}
else if (strAttributeName  ==  convTopicObjective.ObjectiveType)
{
return mstrObjectiveType;
}
else if (strAttributeName  ==  convTopicObjective.SourceId)
{
return mstrSourceId;
}
else if (strAttributeName  ==  convTopicObjective.Conclusion)
{
return mstrConclusion;
}
else if (strAttributeName  ==  convTopicObjective.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convTopicObjective.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convTopicObjective.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convTopicObjective.ObjectiveTypeName)
{
return mstrObjectiveTypeName;
}
else if (strAttributeName  ==  convTopicObjective.CitationCount)
{
return mintCitationCount;
}
else if (strAttributeName  ==  convTopicObjective.AppraiseCount)
{
return mintAppraiseCount;
}
else if (strAttributeName  ==  convTopicObjective.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convTopicObjective.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convTopicObjective.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convTopicObjective.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convTopicObjective.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  convTopicObjective.PdfPageNum)
{
return mintPdfPageNum;
}
else if (strAttributeName  ==  convTopicObjective.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  convTopicObjective.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  convTopicObjective.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convTopicObjective.ShareId)
{
return mstrShareId;
}
else if (strAttributeName  ==  convTopicObjective.UpdUser)
{
return mstrUpdUser;
}
return null;
}
set
{
if (strAttributeName  ==  convTopicObjective.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convTopicObjective.PaperTitle);
}
else if (strAttributeName  ==  convTopicObjective.PaperContent)
{
mstrPaperContent = value.ToString();
 AddUpdatedFld(convTopicObjective.PaperContent);
}
else if (strAttributeName  ==  convTopicObjective.Author)
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convTopicObjective.Author);
}
else if (strAttributeName  ==  convTopicObjective.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convTopicObjective.Keyword);
}
else if (strAttributeName  ==  convTopicObjective.TopicObjectiveId)
{
mstrTopicObjectiveId = value.ToString();
 AddUpdatedFld(convTopicObjective.TopicObjectiveId);
}
else if (strAttributeName  ==  convTopicObjective.ObjectiveName)
{
mstrObjectiveName = value.ToString();
 AddUpdatedFld(convTopicObjective.ObjectiveName);
}
else if (strAttributeName  ==  convTopicObjective.ObjectiveContent)
{
mstrObjectiveContent = value.ToString();
 AddUpdatedFld(convTopicObjective.ObjectiveContent);
}
else if (strAttributeName  ==  convTopicObjective.ObjectiveType)
{
mstrObjectiveType = value.ToString();
 AddUpdatedFld(convTopicObjective.ObjectiveType);
}
else if (strAttributeName  ==  convTopicObjective.SourceId)
{
mstrSourceId = value.ToString();
 AddUpdatedFld(convTopicObjective.SourceId);
}
else if (strAttributeName  ==  convTopicObjective.Conclusion)
{
mstrConclusion = value.ToString();
 AddUpdatedFld(convTopicObjective.Conclusion);
}
else if (strAttributeName  ==  convTopicObjective.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convTopicObjective.IsSubmit);
}
else if (strAttributeName  ==  convTopicObjective.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convTopicObjective.UpdDate);
}
else if (strAttributeName  ==  convTopicObjective.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convTopicObjective.Memo);
}
else if (strAttributeName  ==  convTopicObjective.ObjectiveTypeName)
{
mstrObjectiveTypeName = value.ToString();
 AddUpdatedFld(convTopicObjective.ObjectiveTypeName);
}
else if (strAttributeName  ==  convTopicObjective.CitationCount)
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convTopicObjective.CitationCount);
}
else if (strAttributeName  ==  convTopicObjective.AppraiseCount)
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convTopicObjective.AppraiseCount);
}
else if (strAttributeName  ==  convTopicObjective.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convTopicObjective.Score);
}
else if (strAttributeName  ==  convTopicObjective.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convTopicObjective.StuScore);
}
else if (strAttributeName  ==  convTopicObjective.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convTopicObjective.TeaScore);
}
else if (strAttributeName  ==  convTopicObjective.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convTopicObjective.IdCurrEduCls);
}
else if (strAttributeName  ==  convTopicObjective.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convTopicObjective.PdfContent);
}
else if (strAttributeName  ==  convTopicObjective.PdfPageNum)
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convTopicObjective.PdfPageNum);
}
else if (strAttributeName  ==  convTopicObjective.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convTopicObjective.OkCount);
}
else if (strAttributeName  ==  convTopicObjective.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convTopicObjective.VersionCount);
}
else if (strAttributeName  ==  convTopicObjective.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convTopicObjective.CreateDate);
}
else if (strAttributeName  ==  convTopicObjective.ShareId)
{
mstrShareId = value.ToString();
 AddUpdatedFld(convTopicObjective.ShareId);
}
else if (strAttributeName  ==  convTopicObjective.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convTopicObjective.UpdUser);
}
}
}
public object this[int intIndex]
{
get
{
if (convTopicObjective.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convTopicObjective.PaperContent  ==  AttributeName[intIndex])
{
return mstrPaperContent;
}
else if (convTopicObjective.Author  ==  AttributeName[intIndex])
{
return mstrAuthor;
}
else if (convTopicObjective.Keyword  ==  AttributeName[intIndex])
{
return mstrKeyword;
}
else if (convTopicObjective.TopicObjectiveId  ==  AttributeName[intIndex])
{
return mstrTopicObjectiveId;
}
else if (convTopicObjective.ObjectiveName  ==  AttributeName[intIndex])
{
return mstrObjectiveName;
}
else if (convTopicObjective.ObjectiveContent  ==  AttributeName[intIndex])
{
return mstrObjectiveContent;
}
else if (convTopicObjective.ObjectiveType  ==  AttributeName[intIndex])
{
return mstrObjectiveType;
}
else if (convTopicObjective.SourceId  ==  AttributeName[intIndex])
{
return mstrSourceId;
}
else if (convTopicObjective.Conclusion  ==  AttributeName[intIndex])
{
return mstrConclusion;
}
else if (convTopicObjective.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convTopicObjective.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convTopicObjective.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convTopicObjective.ObjectiveTypeName  ==  AttributeName[intIndex])
{
return mstrObjectiveTypeName;
}
else if (convTopicObjective.CitationCount  ==  AttributeName[intIndex])
{
return mintCitationCount;
}
else if (convTopicObjective.AppraiseCount  ==  AttributeName[intIndex])
{
return mintAppraiseCount;
}
else if (convTopicObjective.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convTopicObjective.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convTopicObjective.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convTopicObjective.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convTopicObjective.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (convTopicObjective.PdfPageNum  ==  AttributeName[intIndex])
{
return mintPdfPageNum;
}
else if (convTopicObjective.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (convTopicObjective.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (convTopicObjective.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convTopicObjective.ShareId  ==  AttributeName[intIndex])
{
return mstrShareId;
}
else if (convTopicObjective.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
return null;
}
set
{
if (convTopicObjective.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convTopicObjective.PaperTitle);
}
else if (convTopicObjective.PaperContent  ==  AttributeName[intIndex])
{
mstrPaperContent = value.ToString();
 AddUpdatedFld(convTopicObjective.PaperContent);
}
else if (convTopicObjective.Author  ==  AttributeName[intIndex])
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convTopicObjective.Author);
}
else if (convTopicObjective.Keyword  ==  AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convTopicObjective.Keyword);
}
else if (convTopicObjective.TopicObjectiveId  ==  AttributeName[intIndex])
{
mstrTopicObjectiveId = value.ToString();
 AddUpdatedFld(convTopicObjective.TopicObjectiveId);
}
else if (convTopicObjective.ObjectiveName  ==  AttributeName[intIndex])
{
mstrObjectiveName = value.ToString();
 AddUpdatedFld(convTopicObjective.ObjectiveName);
}
else if (convTopicObjective.ObjectiveContent  ==  AttributeName[intIndex])
{
mstrObjectiveContent = value.ToString();
 AddUpdatedFld(convTopicObjective.ObjectiveContent);
}
else if (convTopicObjective.ObjectiveType  ==  AttributeName[intIndex])
{
mstrObjectiveType = value.ToString();
 AddUpdatedFld(convTopicObjective.ObjectiveType);
}
else if (convTopicObjective.SourceId  ==  AttributeName[intIndex])
{
mstrSourceId = value.ToString();
 AddUpdatedFld(convTopicObjective.SourceId);
}
else if (convTopicObjective.Conclusion  ==  AttributeName[intIndex])
{
mstrConclusion = value.ToString();
 AddUpdatedFld(convTopicObjective.Conclusion);
}
else if (convTopicObjective.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convTopicObjective.IsSubmit);
}
else if (convTopicObjective.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convTopicObjective.UpdDate);
}
else if (convTopicObjective.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convTopicObjective.Memo);
}
else if (convTopicObjective.ObjectiveTypeName  ==  AttributeName[intIndex])
{
mstrObjectiveTypeName = value.ToString();
 AddUpdatedFld(convTopicObjective.ObjectiveTypeName);
}
else if (convTopicObjective.CitationCount  ==  AttributeName[intIndex])
{
mintCitationCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convTopicObjective.CitationCount);
}
else if (convTopicObjective.AppraiseCount  ==  AttributeName[intIndex])
{
mintAppraiseCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convTopicObjective.AppraiseCount);
}
else if (convTopicObjective.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convTopicObjective.Score);
}
else if (convTopicObjective.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convTopicObjective.StuScore);
}
else if (convTopicObjective.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convTopicObjective.TeaScore);
}
else if (convTopicObjective.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convTopicObjective.IdCurrEduCls);
}
else if (convTopicObjective.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convTopicObjective.PdfContent);
}
else if (convTopicObjective.PdfPageNum  ==  AttributeName[intIndex])
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convTopicObjective.PdfPageNum);
}
else if (convTopicObjective.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convTopicObjective.OkCount);
}
else if (convTopicObjective.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convTopicObjective.VersionCount);
}
else if (convTopicObjective.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convTopicObjective.CreateDate);
}
else if (convTopicObjective.ShareId  ==  AttributeName[intIndex])
{
mstrShareId = value.ToString();
 AddUpdatedFld(convTopicObjective.ShareId);
}
else if (convTopicObjective.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convTopicObjective.UpdUser);
}
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
 AddUpdatedFld(convTopicObjective.PaperTitle);
}
}
/// <summary>
/// 主题内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperContent
{
get
{
return mstrPaperContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperContent = value;
}
else
{
 mstrPaperContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convTopicObjective.PaperContent);
}
}
/// <summary>
/// 作者(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Author
{
get
{
return mstrAuthor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAuthor = value;
}
else
{
 mstrAuthor = value;
}
//记录修改过的字段
 AddUpdatedFld(convTopicObjective.Author);
}
}
/// <summary>
/// 关键字(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Keyword
{
get
{
return mstrKeyword;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyword = value;
}
else
{
 mstrKeyword = value;
}
//记录修改过的字段
 AddUpdatedFld(convTopicObjective.Keyword);
}
}
/// <summary>
/// 客观Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicObjectiveId
{
get
{
return mstrTopicObjectiveId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicObjectiveId = value;
}
else
{
 mstrTopicObjectiveId = value;
}
//记录修改过的字段
 AddUpdatedFld(convTopicObjective.TopicObjectiveId);
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
 AddUpdatedFld(convTopicObjective.ObjectiveName);
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
 AddUpdatedFld(convTopicObjective.ObjectiveContent);
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
 AddUpdatedFld(convTopicObjective.ObjectiveType);
}
}
/// <summary>
/// 来源Id(说明:;字段类型:char;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SourceId
{
get
{
return mstrSourceId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSourceId = value;
}
else
{
 mstrSourceId = value;
}
//记录修改过的字段
 AddUpdatedFld(convTopicObjective.SourceId);
}
}
/// <summary>
/// 结论(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
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
 AddUpdatedFld(convTopicObjective.Conclusion);
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
 AddUpdatedFld(convTopicObjective.IsSubmit);
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
 AddUpdatedFld(convTopicObjective.UpdDate);
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
 AddUpdatedFld(convTopicObjective.Memo);
}
}
/// <summary>
/// ObjectiveTypeName(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ObjectiveTypeName
{
get
{
return mstrObjectiveTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrObjectiveTypeName = value;
}
else
{
 mstrObjectiveTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convTopicObjective.ObjectiveTypeName);
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
 AddUpdatedFld(convTopicObjective.CitationCount);
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
 AddUpdatedFld(convTopicObjective.AppraiseCount);
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
 AddUpdatedFld(convTopicObjective.Score);
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
 AddUpdatedFld(convTopicObjective.StuScore);
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
 AddUpdatedFld(convTopicObjective.TeaScore);
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
 AddUpdatedFld(convTopicObjective.IdCurrEduCls);
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
 AddUpdatedFld(convTopicObjective.PdfContent);
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
 AddUpdatedFld(convTopicObjective.PdfPageNum);
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
 AddUpdatedFld(convTopicObjective.OkCount);
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
 AddUpdatedFld(convTopicObjective.VersionCount);
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
 AddUpdatedFld(convTopicObjective.CreateDate);
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
 AddUpdatedFld(convTopicObjective.ShareId);
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
 AddUpdatedFld(convTopicObjective.UpdUser);
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
  return mstrTopicObjectiveId;
 }
 }
}
 /// <summary>
 /// 客观表视图(vTopicObjective)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convTopicObjective
{
public const string _CurrTabName = "vTopicObjective"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TopicObjectiveId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperTitle", "PaperContent", "Author", "Keyword", "TopicObjectiveId", "ObjectiveName", "ObjectiveContent", "ObjectiveType", "SourceId", "Conclusion", "IsSubmit", "UpdDate", "Memo", "ObjectiveTypeName", "CitationCount", "AppraiseCount", "Score", "StuScore", "TeaScore", "IdCurrEduCls", "PdfContent", "PdfPageNum", "OkCount", "VersionCount", "CreateDate", "ShareId", "UpdUser"};
//以下是属性变量


 /// <summary>
 /// 常量:"PaperTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTitle = "PaperTitle";    //论文标题

 /// <summary>
 /// 常量:"PaperContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperContent = "PaperContent";    //主题内容

 /// <summary>
 /// 常量:"Author"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Author = "Author";    //作者

 /// <summary>
 /// 常量:"Keyword"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Keyword = "Keyword";    //关键字

 /// <summary>
 /// 常量:"TopicObjectiveId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicObjectiveId = "TopicObjectiveId";    //客观Id

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
 /// 常量:"SourceId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SourceId = "SourceId";    //来源Id

 /// <summary>
 /// 常量:"Conclusion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Conclusion = "Conclusion";    //结论

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"ObjectiveTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ObjectiveTypeName = "ObjectiveTypeName";    //ObjectiveTypeName

 /// <summary>
 /// 常量:"CitationCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CitationCount = "CitationCount";    //引用统计

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
 /// 常量:"OkCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OkCount = "OkCount";    //点赞统计

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
 /// 常量:"ShareId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ShareId = "ShareId";    //分享Id

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人
}

}