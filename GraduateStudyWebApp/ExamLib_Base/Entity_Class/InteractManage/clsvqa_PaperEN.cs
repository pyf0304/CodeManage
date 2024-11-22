
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvqa_PaperEN
 表名:vqa_Paper(01120637)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:02:25
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 /// 表vqa_Paper的关键字(QaPaperId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_QaPaperId_vqa_Paper
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strQaPaperId">表关键字</param>
public K_QaPaperId_vqa_Paper(string strQaPaperId)
{
if (IsValid(strQaPaperId)) Value = strQaPaperId;
else
{
Value = null;
}
}
private static bool IsValid(string strQaPaperId)
{
if (string.IsNullOrEmpty(strQaPaperId) == true) return false;
if (strQaPaperId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_QaPaperId_vqa_Paper]类型的对象</returns>
public static implicit operator K_QaPaperId_vqa_Paper(string value)
{
return new K_QaPaperId_vqa_Paper(value);
}
}
 /// <summary>
 /// v论文答疑(vqa_Paper)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvqa_PaperEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vqa_Paper"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "QaPaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 24;
public static string[] AttributeName = new string[] {"QaPaperId", "PaperId", "QuestionsCount", "IsDelete", "IsPublic", "IsSubmit", "UpdUser", "UserName", "UpdDate", "Memo", "PaperTitle", "AttachmentCount", "PaperContent", "Periodical", "Author", "ResearchQuestion", "LiteratureSources", "UploadfileUrl", "IdXzMajor", "MajorName", "IdCurrEduCls", "AnswerCount", "ShareId", "TagsCount"};

protected string mstrQaPaperId;    //论文答疑Id
protected string mstrPaperId;    //论文Id
protected int? mintQuestionsCount;    //提问计数
protected bool mbolIsDelete;    //是否删除
protected bool mbolIsPublic;    //是否公开
protected bool mbolIsSubmit;    //是否提交
protected string mstrUpdUser;    //修改人
protected string mstrUserName;    //用户名
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrPaperTitle;    //论文标题
protected int? mintAttachmentCount;    //附件计数
protected string mstrPaperContent;    //主题内容
protected string mstrPeriodical;    //期刊
protected string mstrAuthor;    //作者
protected string mstrResearchQuestion;    //研究问题
protected string mstrLiteratureSources;    //文献来源
protected string mstrUploadfileUrl;    //文件地址
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorName;    //专业名称
protected string mstrIdCurrEduCls;    //教学班流水号
protected int? mintAnswerCount;    //回答计数
protected string mstrShareId;    //分享Id
protected int? mintTagsCount;    //论文标注数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvqa_PaperEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QaPaperId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strQaPaperId">关键字:论文答疑Id</param>
public clsvqa_PaperEN(string strQaPaperId)
 {
strQaPaperId = strQaPaperId.Replace("'", "''");
if (strQaPaperId.Length > 8)
{
throw new Exception("在表:vqa_Paper中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strQaPaperId)  ==  true)
{
throw new Exception("在表:vqa_Paper中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strQaPaperId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrQaPaperId = strQaPaperId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QaPaperId");
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
if (strAttributeName  ==  convqa_Paper.QaPaperId)
{
return mstrQaPaperId;
}
else if (strAttributeName  ==  convqa_Paper.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convqa_Paper.QuestionsCount)
{
return mintQuestionsCount;
}
else if (strAttributeName  ==  convqa_Paper.IsDelete)
{
return mbolIsDelete;
}
else if (strAttributeName  ==  convqa_Paper.IsPublic)
{
return mbolIsPublic;
}
else if (strAttributeName  ==  convqa_Paper.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convqa_Paper.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convqa_Paper.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convqa_Paper.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convqa_Paper.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convqa_Paper.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convqa_Paper.AttachmentCount)
{
return mintAttachmentCount;
}
else if (strAttributeName  ==  convqa_Paper.PaperContent)
{
return mstrPaperContent;
}
else if (strAttributeName  ==  convqa_Paper.Periodical)
{
return mstrPeriodical;
}
else if (strAttributeName  ==  convqa_Paper.Author)
{
return mstrAuthor;
}
else if (strAttributeName  ==  convqa_Paper.ResearchQuestion)
{
return mstrResearchQuestion;
}
else if (strAttributeName  ==  convqa_Paper.LiteratureSources)
{
return mstrLiteratureSources;
}
else if (strAttributeName  ==  convqa_Paper.UploadfileUrl)
{
return mstrUploadfileUrl;
}
else if (strAttributeName  ==  convqa_Paper.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convqa_Paper.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convqa_Paper.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convqa_Paper.AnswerCount)
{
return mintAnswerCount;
}
else if (strAttributeName  ==  convqa_Paper.ShareId)
{
return mstrShareId;
}
else if (strAttributeName  ==  convqa_Paper.TagsCount)
{
return mintTagsCount;
}
return null;
}
set
{
if (strAttributeName  ==  convqa_Paper.QaPaperId)
{
mstrQaPaperId = value.ToString();
 AddUpdatedFld(convqa_Paper.QaPaperId);
}
else if (strAttributeName  ==  convqa_Paper.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convqa_Paper.PaperId);
}
else if (strAttributeName  ==  convqa_Paper.QuestionsCount)
{
mintQuestionsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Paper.QuestionsCount);
}
else if (strAttributeName  ==  convqa_Paper.IsDelete)
{
mbolIsDelete = TransNullToBool(value.ToString());
 AddUpdatedFld(convqa_Paper.IsDelete);
}
else if (strAttributeName  ==  convqa_Paper.IsPublic)
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convqa_Paper.IsPublic);
}
else if (strAttributeName  ==  convqa_Paper.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convqa_Paper.IsSubmit);
}
else if (strAttributeName  ==  convqa_Paper.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convqa_Paper.UpdUser);
}
else if (strAttributeName  ==  convqa_Paper.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convqa_Paper.UserName);
}
else if (strAttributeName  ==  convqa_Paper.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convqa_Paper.UpdDate);
}
else if (strAttributeName  ==  convqa_Paper.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convqa_Paper.Memo);
}
else if (strAttributeName  ==  convqa_Paper.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convqa_Paper.PaperTitle);
}
else if (strAttributeName  ==  convqa_Paper.AttachmentCount)
{
mintAttachmentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Paper.AttachmentCount);
}
else if (strAttributeName  ==  convqa_Paper.PaperContent)
{
mstrPaperContent = value.ToString();
 AddUpdatedFld(convqa_Paper.PaperContent);
}
else if (strAttributeName  ==  convqa_Paper.Periodical)
{
mstrPeriodical = value.ToString();
 AddUpdatedFld(convqa_Paper.Periodical);
}
else if (strAttributeName  ==  convqa_Paper.Author)
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convqa_Paper.Author);
}
else if (strAttributeName  ==  convqa_Paper.ResearchQuestion)
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(convqa_Paper.ResearchQuestion);
}
else if (strAttributeName  ==  convqa_Paper.LiteratureSources)
{
mstrLiteratureSources = value.ToString();
 AddUpdatedFld(convqa_Paper.LiteratureSources);
}
else if (strAttributeName  ==  convqa_Paper.UploadfileUrl)
{
mstrUploadfileUrl = value.ToString();
 AddUpdatedFld(convqa_Paper.UploadfileUrl);
}
else if (strAttributeName  ==  convqa_Paper.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convqa_Paper.IdXzMajor);
}
else if (strAttributeName  ==  convqa_Paper.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convqa_Paper.MajorName);
}
else if (strAttributeName  ==  convqa_Paper.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convqa_Paper.IdCurrEduCls);
}
else if (strAttributeName  ==  convqa_Paper.AnswerCount)
{
mintAnswerCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Paper.AnswerCount);
}
else if (strAttributeName  ==  convqa_Paper.ShareId)
{
mstrShareId = value.ToString();
 AddUpdatedFld(convqa_Paper.ShareId);
}
else if (strAttributeName  ==  convqa_Paper.TagsCount)
{
mintTagsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Paper.TagsCount);
}
}
}
public object this[int intIndex]
{
get
{
if (convqa_Paper.QaPaperId  ==  AttributeName[intIndex])
{
return mstrQaPaperId;
}
else if (convqa_Paper.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convqa_Paper.QuestionsCount  ==  AttributeName[intIndex])
{
return mintQuestionsCount;
}
else if (convqa_Paper.IsDelete  ==  AttributeName[intIndex])
{
return mbolIsDelete;
}
else if (convqa_Paper.IsPublic  ==  AttributeName[intIndex])
{
return mbolIsPublic;
}
else if (convqa_Paper.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convqa_Paper.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convqa_Paper.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convqa_Paper.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convqa_Paper.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convqa_Paper.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convqa_Paper.AttachmentCount  ==  AttributeName[intIndex])
{
return mintAttachmentCount;
}
else if (convqa_Paper.PaperContent  ==  AttributeName[intIndex])
{
return mstrPaperContent;
}
else if (convqa_Paper.Periodical  ==  AttributeName[intIndex])
{
return mstrPeriodical;
}
else if (convqa_Paper.Author  ==  AttributeName[intIndex])
{
return mstrAuthor;
}
else if (convqa_Paper.ResearchQuestion  ==  AttributeName[intIndex])
{
return mstrResearchQuestion;
}
else if (convqa_Paper.LiteratureSources  ==  AttributeName[intIndex])
{
return mstrLiteratureSources;
}
else if (convqa_Paper.UploadfileUrl  ==  AttributeName[intIndex])
{
return mstrUploadfileUrl;
}
else if (convqa_Paper.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convqa_Paper.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convqa_Paper.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convqa_Paper.AnswerCount  ==  AttributeName[intIndex])
{
return mintAnswerCount;
}
else if (convqa_Paper.ShareId  ==  AttributeName[intIndex])
{
return mstrShareId;
}
else if (convqa_Paper.TagsCount  ==  AttributeName[intIndex])
{
return mintTagsCount;
}
return null;
}
set
{
if (convqa_Paper.QaPaperId  ==  AttributeName[intIndex])
{
mstrQaPaperId = value.ToString();
 AddUpdatedFld(convqa_Paper.QaPaperId);
}
else if (convqa_Paper.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convqa_Paper.PaperId);
}
else if (convqa_Paper.QuestionsCount  ==  AttributeName[intIndex])
{
mintQuestionsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Paper.QuestionsCount);
}
else if (convqa_Paper.IsDelete  ==  AttributeName[intIndex])
{
mbolIsDelete = TransNullToBool(value.ToString());
 AddUpdatedFld(convqa_Paper.IsDelete);
}
else if (convqa_Paper.IsPublic  ==  AttributeName[intIndex])
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convqa_Paper.IsPublic);
}
else if (convqa_Paper.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convqa_Paper.IsSubmit);
}
else if (convqa_Paper.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convqa_Paper.UpdUser);
}
else if (convqa_Paper.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convqa_Paper.UserName);
}
else if (convqa_Paper.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convqa_Paper.UpdDate);
}
else if (convqa_Paper.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convqa_Paper.Memo);
}
else if (convqa_Paper.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convqa_Paper.PaperTitle);
}
else if (convqa_Paper.AttachmentCount  ==  AttributeName[intIndex])
{
mintAttachmentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Paper.AttachmentCount);
}
else if (convqa_Paper.PaperContent  ==  AttributeName[intIndex])
{
mstrPaperContent = value.ToString();
 AddUpdatedFld(convqa_Paper.PaperContent);
}
else if (convqa_Paper.Periodical  ==  AttributeName[intIndex])
{
mstrPeriodical = value.ToString();
 AddUpdatedFld(convqa_Paper.Periodical);
}
else if (convqa_Paper.Author  ==  AttributeName[intIndex])
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convqa_Paper.Author);
}
else if (convqa_Paper.ResearchQuestion  ==  AttributeName[intIndex])
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(convqa_Paper.ResearchQuestion);
}
else if (convqa_Paper.LiteratureSources  ==  AttributeName[intIndex])
{
mstrLiteratureSources = value.ToString();
 AddUpdatedFld(convqa_Paper.LiteratureSources);
}
else if (convqa_Paper.UploadfileUrl  ==  AttributeName[intIndex])
{
mstrUploadfileUrl = value.ToString();
 AddUpdatedFld(convqa_Paper.UploadfileUrl);
}
else if (convqa_Paper.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convqa_Paper.IdXzMajor);
}
else if (convqa_Paper.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convqa_Paper.MajorName);
}
else if (convqa_Paper.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convqa_Paper.IdCurrEduCls);
}
else if (convqa_Paper.AnswerCount  ==  AttributeName[intIndex])
{
mintAnswerCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Paper.AnswerCount);
}
else if (convqa_Paper.ShareId  ==  AttributeName[intIndex])
{
mstrShareId = value.ToString();
 AddUpdatedFld(convqa_Paper.ShareId);
}
else if (convqa_Paper.TagsCount  ==  AttributeName[intIndex])
{
mintTagsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convqa_Paper.TagsCount);
}
}
}

/// <summary>
/// 论文答疑Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QaPaperId
{
get
{
return mstrQaPaperId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQaPaperId = value;
}
else
{
 mstrQaPaperId = value;
}
//记录修改过的字段
 AddUpdatedFld(convqa_Paper.QaPaperId);
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
 AddUpdatedFld(convqa_Paper.PaperId);
}
}
/// <summary>
/// 提问计数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? QuestionsCount
{
get
{
return mintQuestionsCount;
}
set
{
 mintQuestionsCount = value;
//记录修改过的字段
 AddUpdatedFld(convqa_Paper.QuestionsCount);
}
}
/// <summary>
/// 是否删除(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDelete
{
get
{
return mbolIsDelete;
}
set
{
 mbolIsDelete = value;
//记录修改过的字段
 AddUpdatedFld(convqa_Paper.IsDelete);
}
}
/// <summary>
/// 是否公开(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsPublic
{
get
{
return mbolIsPublic;
}
set
{
 mbolIsPublic = value;
//记录修改过的字段
 AddUpdatedFld(convqa_Paper.IsPublic);
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
 AddUpdatedFld(convqa_Paper.IsSubmit);
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
 AddUpdatedFld(convqa_Paper.UpdUser);
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
 AddUpdatedFld(convqa_Paper.UserName);
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
 AddUpdatedFld(convqa_Paper.UpdDate);
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
 AddUpdatedFld(convqa_Paper.Memo);
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
 AddUpdatedFld(convqa_Paper.PaperTitle);
}
}
/// <summary>
/// 附件计数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AttachmentCount
{
get
{
return mintAttachmentCount;
}
set
{
 mintAttachmentCount = value;
//记录修改过的字段
 AddUpdatedFld(convqa_Paper.AttachmentCount);
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
 AddUpdatedFld(convqa_Paper.PaperContent);
}
}
/// <summary>
/// 期刊(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Periodical
{
get
{
return mstrPeriodical;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPeriodical = value;
}
else
{
 mstrPeriodical = value;
}
//记录修改过的字段
 AddUpdatedFld(convqa_Paper.Periodical);
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
 AddUpdatedFld(convqa_Paper.Author);
}
}
/// <summary>
/// 研究问题(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResearchQuestion
{
get
{
return mstrResearchQuestion;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResearchQuestion = value;
}
else
{
 mstrResearchQuestion = value;
}
//记录修改过的字段
 AddUpdatedFld(convqa_Paper.ResearchQuestion);
}
}
/// <summary>
/// 文献来源(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LiteratureSources
{
get
{
return mstrLiteratureSources;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLiteratureSources = value;
}
else
{
 mstrLiteratureSources = value;
}
//记录修改过的字段
 AddUpdatedFld(convqa_Paper.LiteratureSources);
}
}
/// <summary>
/// 文件地址(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UploadfileUrl
{
get
{
return mstrUploadfileUrl;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUploadfileUrl = value;
}
else
{
 mstrUploadfileUrl = value;
}
//记录修改过的字段
 AddUpdatedFld(convqa_Paper.UploadfileUrl);
}
}
/// <summary>
/// 专业流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzMajor
{
get
{
return mstrIdXzMajor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzMajor = value;
}
else
{
 mstrIdXzMajor = value;
}
//记录修改过的字段
 AddUpdatedFld(convqa_Paper.IdXzMajor);
}
}
/// <summary>
/// 专业名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorName
{
get
{
return mstrMajorName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorName = value;
}
else
{
 mstrMajorName = value;
}
//记录修改过的字段
 AddUpdatedFld(convqa_Paper.MajorName);
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
 AddUpdatedFld(convqa_Paper.IdCurrEduCls);
}
}
/// <summary>
/// 回答计数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AnswerCount
{
get
{
return mintAnswerCount;
}
set
{
 mintAnswerCount = value;
//记录修改过的字段
 AddUpdatedFld(convqa_Paper.AnswerCount);
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
 AddUpdatedFld(convqa_Paper.ShareId);
}
}
/// <summary>
/// 论文标注数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? TagsCount
{
get
{
return mintTagsCount;
}
set
{
 mintTagsCount = value;
//记录修改过的字段
 AddUpdatedFld(convqa_Paper.TagsCount);
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
  return mstrQaPaperId;
 }
 }
}
 /// <summary>
 /// v论文答疑(vqa_Paper)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convqa_Paper
{
public const string _CurrTabName = "vqa_Paper"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "QaPaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"QaPaperId", "PaperId", "QuestionsCount", "IsDelete", "IsPublic", "IsSubmit", "UpdUser", "UserName", "UpdDate", "Memo", "PaperTitle", "AttachmentCount", "PaperContent", "Periodical", "Author", "ResearchQuestion", "LiteratureSources", "UploadfileUrl", "IdXzMajor", "MajorName", "IdCurrEduCls", "AnswerCount", "ShareId", "TagsCount"};
//以下是属性变量


 /// <summary>
 /// 常量:"QaPaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QaPaperId = "QaPaperId";    //论文答疑Id

 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

 /// <summary>
 /// 常量:"QuestionsCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionsCount = "QuestionsCount";    //提问计数

 /// <summary>
 /// 常量:"IsDelete"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDelete = "IsDelete";    //是否删除

 /// <summary>
 /// 常量:"IsPublic"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsPublic = "IsPublic";    //是否公开

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

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
 /// 常量:"PaperTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTitle = "PaperTitle";    //论文标题

 /// <summary>
 /// 常量:"AttachmentCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AttachmentCount = "AttachmentCount";    //附件计数

 /// <summary>
 /// 常量:"PaperContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperContent = "PaperContent";    //主题内容

 /// <summary>
 /// 常量:"Periodical"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Periodical = "Periodical";    //期刊

 /// <summary>
 /// 常量:"Author"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Author = "Author";    //作者

 /// <summary>
 /// 常量:"ResearchQuestion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResearchQuestion = "ResearchQuestion";    //研究问题

 /// <summary>
 /// 常量:"LiteratureSources"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LiteratureSources = "LiteratureSources";    //文献来源

 /// <summary>
 /// 常量:"UploadfileUrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UploadfileUrl = "UploadfileUrl";    //文件地址

 /// <summary>
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

 /// <summary>
 /// 常量:"MajorName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorName = "MajorName";    //专业名称

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"AnswerCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerCount = "AnswerCount";    //回答计数

 /// <summary>
 /// 常量:"ShareId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ShareId = "ShareId";    //分享Id

 /// <summary>
 /// 常量:"TagsCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TagsCount = "TagsCount";    //论文标注数
}

}