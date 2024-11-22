
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_qa_PaperEN
 表名:vzx_qa_Paper(01120849)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:13:55
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
 /// 表vzx_qa_Paper的关键字(ZxqaPaperId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ZxqaPaperId_vzx_qa_Paper
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strZxqaPaperId">表关键字</param>
public K_ZxqaPaperId_vzx_qa_Paper(string strZxqaPaperId)
{
if (IsValid(strZxqaPaperId)) Value = strZxqaPaperId;
else
{
Value = null;
}
}
private static bool IsValid(string strZxqaPaperId)
{
if (string.IsNullOrEmpty(strZxqaPaperId) == true) return false;
if (strZxqaPaperId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ZxqaPaperId_vzx_qa_Paper]类型的对象</returns>
public static implicit operator K_ZxqaPaperId_vzx_qa_Paper(string value)
{
return new K_ZxqaPaperId_vzx_qa_Paper(value);
}
}
 /// <summary>
 /// vzx_qa_Paper(vzx_qa_Paper)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvzx_qa_PaperEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vzx_qa_Paper"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ZxqaPaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 24;
public static string[] AttributeName = new string[] {"UserName", "IdXzMajor", "MajorName", "TextTitle", "TextContent", "Author", "ResearchQuestion", "LiteratureSources", "LiteratureLink", "UploadfileUrl", "AttachmentCount", "ZxqaPaperId", "QuestionsCount", "TextId", "IsDelete", "IsPublic", "IsSubmit", "UpdDate", "UpdUser", "Memo", "IdCurrEduCls", "AnswerCount", "zxShareId", "TagsCount"};

protected string mstrUserName;    //用户名
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorName;    //专业名称
protected string mstrTextTitle;    //TextTitle
protected string mstrTextContent;    //TextContent
protected string mstrAuthor;    //作者
protected string mstrResearchQuestion;    //研究问题
protected string mstrLiteratureSources;    //文献来源
protected string mstrLiteratureLink;    //文献链接
protected string mstrUploadfileUrl;    //文件地址
protected int? mintAttachmentCount;    //附件计数
protected string mstrZxqaPaperId;    //论文答疑Id
protected int? mintQuestionsCount;    //提问计数
protected string mstrTextId;    //课件Id
protected bool mbolIsDelete;    //是否删除
protected bool mbolIsPublic;    //是否公开
protected bool mbolIsSubmit;    //是否提交
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrIdCurrEduCls;    //教学班流水号
protected int? mintAnswerCount;    //回答计数
protected string mstrzxShareId;    //分享Id
protected int? mintTagsCount;    //论文标注数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvzx_qa_PaperEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ZxqaPaperId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strZxqaPaperId">关键字:论文答疑Id</param>
public clsvzx_qa_PaperEN(string strZxqaPaperId)
 {
strZxqaPaperId = strZxqaPaperId.Replace("'", "''");
if (strZxqaPaperId.Length > 8)
{
throw new Exception("在表:vzx_qa_Paper中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strZxqaPaperId)  ==  true)
{
throw new Exception("在表:vzx_qa_Paper中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strZxqaPaperId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrZxqaPaperId = strZxqaPaperId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ZxqaPaperId");
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
if (strAttributeName  ==  convzx_qa_Paper.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convzx_qa_Paper.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convzx_qa_Paper.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convzx_qa_Paper.TextTitle)
{
return mstrTextTitle;
}
else if (strAttributeName  ==  convzx_qa_Paper.TextContent)
{
return mstrTextContent;
}
else if (strAttributeName  ==  convzx_qa_Paper.Author)
{
return mstrAuthor;
}
else if (strAttributeName  ==  convzx_qa_Paper.ResearchQuestion)
{
return mstrResearchQuestion;
}
else if (strAttributeName  ==  convzx_qa_Paper.LiteratureSources)
{
return mstrLiteratureSources;
}
else if (strAttributeName  ==  convzx_qa_Paper.LiteratureLink)
{
return mstrLiteratureLink;
}
else if (strAttributeName  ==  convzx_qa_Paper.UploadfileUrl)
{
return mstrUploadfileUrl;
}
else if (strAttributeName  ==  convzx_qa_Paper.AttachmentCount)
{
return mintAttachmentCount;
}
else if (strAttributeName  ==  convzx_qa_Paper.ZxqaPaperId)
{
return mstrZxqaPaperId;
}
else if (strAttributeName  ==  convzx_qa_Paper.QuestionsCount)
{
return mintQuestionsCount;
}
else if (strAttributeName  ==  convzx_qa_Paper.TextId)
{
return mstrTextId;
}
else if (strAttributeName  ==  convzx_qa_Paper.IsDelete)
{
return mbolIsDelete;
}
else if (strAttributeName  ==  convzx_qa_Paper.IsPublic)
{
return mbolIsPublic;
}
else if (strAttributeName  ==  convzx_qa_Paper.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convzx_qa_Paper.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convzx_qa_Paper.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convzx_qa_Paper.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convzx_qa_Paper.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convzx_qa_Paper.AnswerCount)
{
return mintAnswerCount;
}
else if (strAttributeName  ==  convzx_qa_Paper.zxShareId)
{
return mstrzxShareId;
}
else if (strAttributeName  ==  convzx_qa_Paper.TagsCount)
{
return mintTagsCount;
}
return null;
}
set
{
if (strAttributeName  ==  convzx_qa_Paper.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.UserName);
}
else if (strAttributeName  ==  convzx_qa_Paper.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.IdXzMajor);
}
else if (strAttributeName  ==  convzx_qa_Paper.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.MajorName);
}
else if (strAttributeName  ==  convzx_qa_Paper.TextTitle)
{
mstrTextTitle = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.TextTitle);
}
else if (strAttributeName  ==  convzx_qa_Paper.TextContent)
{
mstrTextContent = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.TextContent);
}
else if (strAttributeName  ==  convzx_qa_Paper.Author)
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.Author);
}
else if (strAttributeName  ==  convzx_qa_Paper.ResearchQuestion)
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.ResearchQuestion);
}
else if (strAttributeName  ==  convzx_qa_Paper.LiteratureSources)
{
mstrLiteratureSources = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.LiteratureSources);
}
else if (strAttributeName  ==  convzx_qa_Paper.LiteratureLink)
{
mstrLiteratureLink = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.LiteratureLink);
}
else if (strAttributeName  ==  convzx_qa_Paper.UploadfileUrl)
{
mstrUploadfileUrl = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.UploadfileUrl);
}
else if (strAttributeName  ==  convzx_qa_Paper.AttachmentCount)
{
mintAttachmentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_qa_Paper.AttachmentCount);
}
else if (strAttributeName  ==  convzx_qa_Paper.ZxqaPaperId)
{
mstrZxqaPaperId = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.ZxqaPaperId);
}
else if (strAttributeName  ==  convzx_qa_Paper.QuestionsCount)
{
mintQuestionsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_qa_Paper.QuestionsCount);
}
else if (strAttributeName  ==  convzx_qa_Paper.TextId)
{
mstrTextId = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.TextId);
}
else if (strAttributeName  ==  convzx_qa_Paper.IsDelete)
{
mbolIsDelete = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_qa_Paper.IsDelete);
}
else if (strAttributeName  ==  convzx_qa_Paper.IsPublic)
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_qa_Paper.IsPublic);
}
else if (strAttributeName  ==  convzx_qa_Paper.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_qa_Paper.IsSubmit);
}
else if (strAttributeName  ==  convzx_qa_Paper.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.UpdDate);
}
else if (strAttributeName  ==  convzx_qa_Paper.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.UpdUser);
}
else if (strAttributeName  ==  convzx_qa_Paper.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.Memo);
}
else if (strAttributeName  ==  convzx_qa_Paper.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.IdCurrEduCls);
}
else if (strAttributeName  ==  convzx_qa_Paper.AnswerCount)
{
mintAnswerCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_qa_Paper.AnswerCount);
}
else if (strAttributeName  ==  convzx_qa_Paper.zxShareId)
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.zxShareId);
}
else if (strAttributeName  ==  convzx_qa_Paper.TagsCount)
{
mintTagsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_qa_Paper.TagsCount);
}
}
}
public object this[int intIndex]
{
get
{
if (convzx_qa_Paper.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convzx_qa_Paper.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convzx_qa_Paper.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convzx_qa_Paper.TextTitle  ==  AttributeName[intIndex])
{
return mstrTextTitle;
}
else if (convzx_qa_Paper.TextContent  ==  AttributeName[intIndex])
{
return mstrTextContent;
}
else if (convzx_qa_Paper.Author  ==  AttributeName[intIndex])
{
return mstrAuthor;
}
else if (convzx_qa_Paper.ResearchQuestion  ==  AttributeName[intIndex])
{
return mstrResearchQuestion;
}
else if (convzx_qa_Paper.LiteratureSources  ==  AttributeName[intIndex])
{
return mstrLiteratureSources;
}
else if (convzx_qa_Paper.LiteratureLink  ==  AttributeName[intIndex])
{
return mstrLiteratureLink;
}
else if (convzx_qa_Paper.UploadfileUrl  ==  AttributeName[intIndex])
{
return mstrUploadfileUrl;
}
else if (convzx_qa_Paper.AttachmentCount  ==  AttributeName[intIndex])
{
return mintAttachmentCount;
}
else if (convzx_qa_Paper.ZxqaPaperId  ==  AttributeName[intIndex])
{
return mstrZxqaPaperId;
}
else if (convzx_qa_Paper.QuestionsCount  ==  AttributeName[intIndex])
{
return mintQuestionsCount;
}
else if (convzx_qa_Paper.TextId  ==  AttributeName[intIndex])
{
return mstrTextId;
}
else if (convzx_qa_Paper.IsDelete  ==  AttributeName[intIndex])
{
return mbolIsDelete;
}
else if (convzx_qa_Paper.IsPublic  ==  AttributeName[intIndex])
{
return mbolIsPublic;
}
else if (convzx_qa_Paper.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convzx_qa_Paper.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convzx_qa_Paper.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convzx_qa_Paper.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convzx_qa_Paper.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convzx_qa_Paper.AnswerCount  ==  AttributeName[intIndex])
{
return mintAnswerCount;
}
else if (convzx_qa_Paper.zxShareId  ==  AttributeName[intIndex])
{
return mstrzxShareId;
}
else if (convzx_qa_Paper.TagsCount  ==  AttributeName[intIndex])
{
return mintTagsCount;
}
return null;
}
set
{
if (convzx_qa_Paper.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.UserName);
}
else if (convzx_qa_Paper.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.IdXzMajor);
}
else if (convzx_qa_Paper.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.MajorName);
}
else if (convzx_qa_Paper.TextTitle  ==  AttributeName[intIndex])
{
mstrTextTitle = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.TextTitle);
}
else if (convzx_qa_Paper.TextContent  ==  AttributeName[intIndex])
{
mstrTextContent = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.TextContent);
}
else if (convzx_qa_Paper.Author  ==  AttributeName[intIndex])
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.Author);
}
else if (convzx_qa_Paper.ResearchQuestion  ==  AttributeName[intIndex])
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.ResearchQuestion);
}
else if (convzx_qa_Paper.LiteratureSources  ==  AttributeName[intIndex])
{
mstrLiteratureSources = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.LiteratureSources);
}
else if (convzx_qa_Paper.LiteratureLink  ==  AttributeName[intIndex])
{
mstrLiteratureLink = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.LiteratureLink);
}
else if (convzx_qa_Paper.UploadfileUrl  ==  AttributeName[intIndex])
{
mstrUploadfileUrl = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.UploadfileUrl);
}
else if (convzx_qa_Paper.AttachmentCount  ==  AttributeName[intIndex])
{
mintAttachmentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_qa_Paper.AttachmentCount);
}
else if (convzx_qa_Paper.ZxqaPaperId  ==  AttributeName[intIndex])
{
mstrZxqaPaperId = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.ZxqaPaperId);
}
else if (convzx_qa_Paper.QuestionsCount  ==  AttributeName[intIndex])
{
mintQuestionsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_qa_Paper.QuestionsCount);
}
else if (convzx_qa_Paper.TextId  ==  AttributeName[intIndex])
{
mstrTextId = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.TextId);
}
else if (convzx_qa_Paper.IsDelete  ==  AttributeName[intIndex])
{
mbolIsDelete = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_qa_Paper.IsDelete);
}
else if (convzx_qa_Paper.IsPublic  ==  AttributeName[intIndex])
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_qa_Paper.IsPublic);
}
else if (convzx_qa_Paper.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_qa_Paper.IsSubmit);
}
else if (convzx_qa_Paper.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.UpdDate);
}
else if (convzx_qa_Paper.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.UpdUser);
}
else if (convzx_qa_Paper.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.Memo);
}
else if (convzx_qa_Paper.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.IdCurrEduCls);
}
else if (convzx_qa_Paper.AnswerCount  ==  AttributeName[intIndex])
{
mintAnswerCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_qa_Paper.AnswerCount);
}
else if (convzx_qa_Paper.zxShareId  ==  AttributeName[intIndex])
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(convzx_qa_Paper.zxShareId);
}
else if (convzx_qa_Paper.TagsCount  ==  AttributeName[intIndex])
{
mintTagsCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_qa_Paper.TagsCount);
}
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
 AddUpdatedFld(convzx_qa_Paper.UserName);
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
 AddUpdatedFld(convzx_qa_Paper.IdXzMajor);
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
 AddUpdatedFld(convzx_qa_Paper.MajorName);
}
}
/// <summary>
/// TextTitle(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextTitle
{
get
{
return mstrTextTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextTitle = value;
}
else
{
 mstrTextTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_qa_Paper.TextTitle);
}
}
/// <summary>
/// TextContent(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextContent
{
get
{
return mstrTextContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextContent = value;
}
else
{
 mstrTextContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_qa_Paper.TextContent);
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
 AddUpdatedFld(convzx_qa_Paper.Author);
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
 AddUpdatedFld(convzx_qa_Paper.ResearchQuestion);
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
 AddUpdatedFld(convzx_qa_Paper.LiteratureSources);
}
}
/// <summary>
/// 文献链接(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LiteratureLink
{
get
{
return mstrLiteratureLink;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLiteratureLink = value;
}
else
{
 mstrLiteratureLink = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_qa_Paper.LiteratureLink);
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
 AddUpdatedFld(convzx_qa_Paper.UploadfileUrl);
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
 AddUpdatedFld(convzx_qa_Paper.AttachmentCount);
}
}
/// <summary>
/// 论文答疑Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ZxqaPaperId
{
get
{
return mstrZxqaPaperId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrZxqaPaperId = value;
}
else
{
 mstrZxqaPaperId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_qa_Paper.ZxqaPaperId);
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
 AddUpdatedFld(convzx_qa_Paper.QuestionsCount);
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
 AddUpdatedFld(convzx_qa_Paper.TextId);
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
 AddUpdatedFld(convzx_qa_Paper.IsDelete);
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
 AddUpdatedFld(convzx_qa_Paper.IsPublic);
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
 AddUpdatedFld(convzx_qa_Paper.IsSubmit);
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
 AddUpdatedFld(convzx_qa_Paper.UpdDate);
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
 AddUpdatedFld(convzx_qa_Paper.UpdUser);
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
 AddUpdatedFld(convzx_qa_Paper.Memo);
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
 AddUpdatedFld(convzx_qa_Paper.IdCurrEduCls);
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
 AddUpdatedFld(convzx_qa_Paper.AnswerCount);
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
 AddUpdatedFld(convzx_qa_Paper.zxShareId);
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
 AddUpdatedFld(convzx_qa_Paper.TagsCount);
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
  return mstrZxqaPaperId;
 }
 }
}
 /// <summary>
 /// vzx_qa_Paper(vzx_qa_Paper)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convzx_qa_Paper
{
public const string _CurrTabName = "vzx_qa_Paper"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ZxqaPaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"UserName", "IdXzMajor", "MajorName", "TextTitle", "TextContent", "Author", "ResearchQuestion", "LiteratureSources", "LiteratureLink", "UploadfileUrl", "AttachmentCount", "ZxqaPaperId", "QuestionsCount", "TextId", "IsDelete", "IsPublic", "IsSubmit", "UpdDate", "UpdUser", "Memo", "IdCurrEduCls", "AnswerCount", "zxShareId", "TagsCount"};
//以下是属性变量


 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

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
 /// 常量:"TextTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextTitle = "TextTitle";    //TextTitle

 /// <summary>
 /// 常量:"TextContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextContent = "TextContent";    //TextContent

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
 /// 常量:"LiteratureLink"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LiteratureLink = "LiteratureLink";    //文献链接

 /// <summary>
 /// 常量:"UploadfileUrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UploadfileUrl = "UploadfileUrl";    //文件地址

 /// <summary>
 /// 常量:"AttachmentCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AttachmentCount = "AttachmentCount";    //附件计数

 /// <summary>
 /// 常量:"ZxqaPaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ZxqaPaperId = "ZxqaPaperId";    //论文答疑Id

 /// <summary>
 /// 常量:"QuestionsCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionsCount = "QuestionsCount";    //提问计数

 /// <summary>
 /// 常量:"TextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextId = "TextId";    //课件Id

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
 /// 常量:"zxShareId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxShareId = "zxShareId";    //分享Id

 /// <summary>
 /// 常量:"TagsCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TagsCount = "TagsCount";    //论文标注数
}

}