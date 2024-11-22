
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvThesisEN
 表名:vThesis(01120537)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:19:32
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研究生培养(GraduateEdu)
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
 /// 表vThesis的关键字(ThesisId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ThesisId_vThesis
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strThesisId">表关键字</param>
public K_ThesisId_vThesis(string strThesisId)
{
if (IsValid(strThesisId)) Value = strThesisId;
else
{
Value = null;
}
}
private static bool IsValid(string strThesisId)
{
if (string.IsNullOrEmpty(strThesisId) == true) return false;
if (strThesisId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ThesisId_vThesis]类型的对象</returns>
public static implicit operator K_ThesisId_vThesis(string value)
{
return new K_ThesisId_vThesis(value);
}
}
 /// <summary>
 /// vThesis(vThesis)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvThesisEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vThesis"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ThesisId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 22;
public static string[] AttributeName = new string[] {"ThesisId", "ThesisTitle", "ThesisName", "ThesisContent", "Periodical", "Author", "ResearchQuestion", "UpdDate", "UpdUserId", "Memo", "OperationTypeId", "OperationTypeName", "Keyword", "LiteratureLink", "LiteratureSources", "ResearcherInformation", "UploadfileUrl", "IsQuotethesis", "QuoteId", "QuoteThesisContent", "QuoteThesisName", "QuoteThesisTitle"};

protected string mstrThesisId;    //论文Id
protected string mstrThesisTitle;    //论文标题
protected string mstrThesisName;    //主题名称
protected string mstrThesisContent;    //主题内容
protected string mstrPeriodical;    //期刊
protected string mstrAuthor;    //作者
protected string mstrResearchQuestion;    //研究问题
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注
protected string mstrOperationTypeId;    //操作类型ID
protected string mstrOperationTypeName;    //操作类型名
protected string mstrKeyword;    //关键字
protected string mstrLiteratureLink;    //文献链接
protected string mstrLiteratureSources;    //文献来源
protected string mstrResearcherInformation;    //研究者
protected string mstrUploadfileUrl;    //文件地址
protected bool mbolIsQuotethesis;    //是否引用论文
protected string mstrQuoteId;    //引用Id
protected string mstrQuoteThesisContent;    //QuoteThesisContent
protected string mstrQuoteThesisName;    //QuoteThesisName
protected string mstrQuoteThesisTitle;    //QuoteThesisTitle

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvThesisEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ThesisId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strThesisId">关键字:论文Id</param>
public clsvThesisEN(string strThesisId)
 {
strThesisId = strThesisId.Replace("'", "''");
if (strThesisId.Length > 8)
{
throw new Exception("在表:vThesis中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strThesisId)  ==  true)
{
throw new Exception("在表:vThesis中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strThesisId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrThesisId = strThesisId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ThesisId");
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
if (strAttributeName  ==  convThesis.ThesisId)
{
return mstrThesisId;
}
else if (strAttributeName  ==  convThesis.ThesisTitle)
{
return mstrThesisTitle;
}
else if (strAttributeName  ==  convThesis.ThesisName)
{
return mstrThesisName;
}
else if (strAttributeName  ==  convThesis.ThesisContent)
{
return mstrThesisContent;
}
else if (strAttributeName  ==  convThesis.Periodical)
{
return mstrPeriodical;
}
else if (strAttributeName  ==  convThesis.Author)
{
return mstrAuthor;
}
else if (strAttributeName  ==  convThesis.ResearchQuestion)
{
return mstrResearchQuestion;
}
else if (strAttributeName  ==  convThesis.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convThesis.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convThesis.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convThesis.OperationTypeId)
{
return mstrOperationTypeId;
}
else if (strAttributeName  ==  convThesis.OperationTypeName)
{
return mstrOperationTypeName;
}
else if (strAttributeName  ==  convThesis.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  convThesis.LiteratureLink)
{
return mstrLiteratureLink;
}
else if (strAttributeName  ==  convThesis.LiteratureSources)
{
return mstrLiteratureSources;
}
else if (strAttributeName  ==  convThesis.ResearcherInformation)
{
return mstrResearcherInformation;
}
else if (strAttributeName  ==  convThesis.UploadfileUrl)
{
return mstrUploadfileUrl;
}
else if (strAttributeName  ==  convThesis.IsQuotethesis)
{
return mbolIsQuotethesis;
}
else if (strAttributeName  ==  convThesis.QuoteId)
{
return mstrQuoteId;
}
else if (strAttributeName  ==  convThesis.QuoteThesisContent)
{
return mstrQuoteThesisContent;
}
else if (strAttributeName  ==  convThesis.QuoteThesisName)
{
return mstrQuoteThesisName;
}
else if (strAttributeName  ==  convThesis.QuoteThesisTitle)
{
return mstrQuoteThesisTitle;
}
return null;
}
set
{
if (strAttributeName  ==  convThesis.ThesisId)
{
mstrThesisId = value.ToString();
 AddUpdatedFld(convThesis.ThesisId);
}
else if (strAttributeName  ==  convThesis.ThesisTitle)
{
mstrThesisTitle = value.ToString();
 AddUpdatedFld(convThesis.ThesisTitle);
}
else if (strAttributeName  ==  convThesis.ThesisName)
{
mstrThesisName = value.ToString();
 AddUpdatedFld(convThesis.ThesisName);
}
else if (strAttributeName  ==  convThesis.ThesisContent)
{
mstrThesisContent = value.ToString();
 AddUpdatedFld(convThesis.ThesisContent);
}
else if (strAttributeName  ==  convThesis.Periodical)
{
mstrPeriodical = value.ToString();
 AddUpdatedFld(convThesis.Periodical);
}
else if (strAttributeName  ==  convThesis.Author)
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convThesis.Author);
}
else if (strAttributeName  ==  convThesis.ResearchQuestion)
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(convThesis.ResearchQuestion);
}
else if (strAttributeName  ==  convThesis.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convThesis.UpdDate);
}
else if (strAttributeName  ==  convThesis.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convThesis.UpdUserId);
}
else if (strAttributeName  ==  convThesis.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convThesis.Memo);
}
else if (strAttributeName  ==  convThesis.OperationTypeId)
{
mstrOperationTypeId = value.ToString();
 AddUpdatedFld(convThesis.OperationTypeId);
}
else if (strAttributeName  ==  convThesis.OperationTypeName)
{
mstrOperationTypeName = value.ToString();
 AddUpdatedFld(convThesis.OperationTypeName);
}
else if (strAttributeName  ==  convThesis.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convThesis.Keyword);
}
else if (strAttributeName  ==  convThesis.LiteratureLink)
{
mstrLiteratureLink = value.ToString();
 AddUpdatedFld(convThesis.LiteratureLink);
}
else if (strAttributeName  ==  convThesis.LiteratureSources)
{
mstrLiteratureSources = value.ToString();
 AddUpdatedFld(convThesis.LiteratureSources);
}
else if (strAttributeName  ==  convThesis.ResearcherInformation)
{
mstrResearcherInformation = value.ToString();
 AddUpdatedFld(convThesis.ResearcherInformation);
}
else if (strAttributeName  ==  convThesis.UploadfileUrl)
{
mstrUploadfileUrl = value.ToString();
 AddUpdatedFld(convThesis.UploadfileUrl);
}
else if (strAttributeName  ==  convThesis.IsQuotethesis)
{
mbolIsQuotethesis = TransNullToBool(value.ToString());
 AddUpdatedFld(convThesis.IsQuotethesis);
}
else if (strAttributeName  ==  convThesis.QuoteId)
{
mstrQuoteId = value.ToString();
 AddUpdatedFld(convThesis.QuoteId);
}
else if (strAttributeName  ==  convThesis.QuoteThesisContent)
{
mstrQuoteThesisContent = value.ToString();
 AddUpdatedFld(convThesis.QuoteThesisContent);
}
else if (strAttributeName  ==  convThesis.QuoteThesisName)
{
mstrQuoteThesisName = value.ToString();
 AddUpdatedFld(convThesis.QuoteThesisName);
}
else if (strAttributeName  ==  convThesis.QuoteThesisTitle)
{
mstrQuoteThesisTitle = value.ToString();
 AddUpdatedFld(convThesis.QuoteThesisTitle);
}
}
}
public object this[int intIndex]
{
get
{
if (convThesis.ThesisId  ==  AttributeName[intIndex])
{
return mstrThesisId;
}
else if (convThesis.ThesisTitle  ==  AttributeName[intIndex])
{
return mstrThesisTitle;
}
else if (convThesis.ThesisName  ==  AttributeName[intIndex])
{
return mstrThesisName;
}
else if (convThesis.ThesisContent  ==  AttributeName[intIndex])
{
return mstrThesisContent;
}
else if (convThesis.Periodical  ==  AttributeName[intIndex])
{
return mstrPeriodical;
}
else if (convThesis.Author  ==  AttributeName[intIndex])
{
return mstrAuthor;
}
else if (convThesis.ResearchQuestion  ==  AttributeName[intIndex])
{
return mstrResearchQuestion;
}
else if (convThesis.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convThesis.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convThesis.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convThesis.OperationTypeId  ==  AttributeName[intIndex])
{
return mstrOperationTypeId;
}
else if (convThesis.OperationTypeName  ==  AttributeName[intIndex])
{
return mstrOperationTypeName;
}
else if (convThesis.Keyword  ==  AttributeName[intIndex])
{
return mstrKeyword;
}
else if (convThesis.LiteratureLink  ==  AttributeName[intIndex])
{
return mstrLiteratureLink;
}
else if (convThesis.LiteratureSources  ==  AttributeName[intIndex])
{
return mstrLiteratureSources;
}
else if (convThesis.ResearcherInformation  ==  AttributeName[intIndex])
{
return mstrResearcherInformation;
}
else if (convThesis.UploadfileUrl  ==  AttributeName[intIndex])
{
return mstrUploadfileUrl;
}
else if (convThesis.IsQuotethesis  ==  AttributeName[intIndex])
{
return mbolIsQuotethesis;
}
else if (convThesis.QuoteId  ==  AttributeName[intIndex])
{
return mstrQuoteId;
}
else if (convThesis.QuoteThesisContent  ==  AttributeName[intIndex])
{
return mstrQuoteThesisContent;
}
else if (convThesis.QuoteThesisName  ==  AttributeName[intIndex])
{
return mstrQuoteThesisName;
}
else if (convThesis.QuoteThesisTitle  ==  AttributeName[intIndex])
{
return mstrQuoteThesisTitle;
}
return null;
}
set
{
if (convThesis.ThesisId  ==  AttributeName[intIndex])
{
mstrThesisId = value.ToString();
 AddUpdatedFld(convThesis.ThesisId);
}
else if (convThesis.ThesisTitle  ==  AttributeName[intIndex])
{
mstrThesisTitle = value.ToString();
 AddUpdatedFld(convThesis.ThesisTitle);
}
else if (convThesis.ThesisName  ==  AttributeName[intIndex])
{
mstrThesisName = value.ToString();
 AddUpdatedFld(convThesis.ThesisName);
}
else if (convThesis.ThesisContent  ==  AttributeName[intIndex])
{
mstrThesisContent = value.ToString();
 AddUpdatedFld(convThesis.ThesisContent);
}
else if (convThesis.Periodical  ==  AttributeName[intIndex])
{
mstrPeriodical = value.ToString();
 AddUpdatedFld(convThesis.Periodical);
}
else if (convThesis.Author  ==  AttributeName[intIndex])
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convThesis.Author);
}
else if (convThesis.ResearchQuestion  ==  AttributeName[intIndex])
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(convThesis.ResearchQuestion);
}
else if (convThesis.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convThesis.UpdDate);
}
else if (convThesis.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convThesis.UpdUserId);
}
else if (convThesis.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convThesis.Memo);
}
else if (convThesis.OperationTypeId  ==  AttributeName[intIndex])
{
mstrOperationTypeId = value.ToString();
 AddUpdatedFld(convThesis.OperationTypeId);
}
else if (convThesis.OperationTypeName  ==  AttributeName[intIndex])
{
mstrOperationTypeName = value.ToString();
 AddUpdatedFld(convThesis.OperationTypeName);
}
else if (convThesis.Keyword  ==  AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convThesis.Keyword);
}
else if (convThesis.LiteratureLink  ==  AttributeName[intIndex])
{
mstrLiteratureLink = value.ToString();
 AddUpdatedFld(convThesis.LiteratureLink);
}
else if (convThesis.LiteratureSources  ==  AttributeName[intIndex])
{
mstrLiteratureSources = value.ToString();
 AddUpdatedFld(convThesis.LiteratureSources);
}
else if (convThesis.ResearcherInformation  ==  AttributeName[intIndex])
{
mstrResearcherInformation = value.ToString();
 AddUpdatedFld(convThesis.ResearcherInformation);
}
else if (convThesis.UploadfileUrl  ==  AttributeName[intIndex])
{
mstrUploadfileUrl = value.ToString();
 AddUpdatedFld(convThesis.UploadfileUrl);
}
else if (convThesis.IsQuotethesis  ==  AttributeName[intIndex])
{
mbolIsQuotethesis = TransNullToBool(value.ToString());
 AddUpdatedFld(convThesis.IsQuotethesis);
}
else if (convThesis.QuoteId  ==  AttributeName[intIndex])
{
mstrQuoteId = value.ToString();
 AddUpdatedFld(convThesis.QuoteId);
}
else if (convThesis.QuoteThesisContent  ==  AttributeName[intIndex])
{
mstrQuoteThesisContent = value.ToString();
 AddUpdatedFld(convThesis.QuoteThesisContent);
}
else if (convThesis.QuoteThesisName  ==  AttributeName[intIndex])
{
mstrQuoteThesisName = value.ToString();
 AddUpdatedFld(convThesis.QuoteThesisName);
}
else if (convThesis.QuoteThesisTitle  ==  AttributeName[intIndex])
{
mstrQuoteThesisTitle = value.ToString();
 AddUpdatedFld(convThesis.QuoteThesisTitle);
}
}
}

/// <summary>
/// 论文Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ThesisId
{
get
{
return mstrThesisId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrThesisId = value;
}
else
{
 mstrThesisId = value;
}
//记录修改过的字段
 AddUpdatedFld(convThesis.ThesisId);
}
}
/// <summary>
/// 论文标题(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ThesisTitle
{
get
{
return mstrThesisTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrThesisTitle = value;
}
else
{
 mstrThesisTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convThesis.ThesisTitle);
}
}
/// <summary>
/// 主题名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ThesisName
{
get
{
return mstrThesisName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrThesisName = value;
}
else
{
 mstrThesisName = value;
}
//记录修改过的字段
 AddUpdatedFld(convThesis.ThesisName);
}
}
/// <summary>
/// 主题内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ThesisContent
{
get
{
return mstrThesisContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrThesisContent = value;
}
else
{
 mstrThesisContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convThesis.ThesisContent);
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
 AddUpdatedFld(convThesis.Periodical);
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
 AddUpdatedFld(convThesis.Author);
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
 AddUpdatedFld(convThesis.ResearchQuestion);
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
 AddUpdatedFld(convThesis.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convThesis.UpdUserId);
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
 AddUpdatedFld(convThesis.Memo);
}
}
/// <summary>
/// 操作类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OperationTypeId
{
get
{
return mstrOperationTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOperationTypeId = value;
}
else
{
 mstrOperationTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convThesis.OperationTypeId);
}
}
/// <summary>
/// 操作类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OperationTypeName
{
get
{
return mstrOperationTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOperationTypeName = value;
}
else
{
 mstrOperationTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convThesis.OperationTypeName);
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
 AddUpdatedFld(convThesis.Keyword);
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
 AddUpdatedFld(convThesis.LiteratureLink);
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
 AddUpdatedFld(convThesis.LiteratureSources);
}
}
/// <summary>
/// 研究者(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ResearcherInformation
{
get
{
return mstrResearcherInformation;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrResearcherInformation = value;
}
else
{
 mstrResearcherInformation = value;
}
//记录修改过的字段
 AddUpdatedFld(convThesis.ResearcherInformation);
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
 AddUpdatedFld(convThesis.UploadfileUrl);
}
}
/// <summary>
/// 是否引用论文(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsQuotethesis
{
get
{
return mbolIsQuotethesis;
}
set
{
 mbolIsQuotethesis = value;
//记录修改过的字段
 AddUpdatedFld(convThesis.IsQuotethesis);
}
}
/// <summary>
/// 引用Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuoteId
{
get
{
return mstrQuoteId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuoteId = value;
}
else
{
 mstrQuoteId = value;
}
//记录修改过的字段
 AddUpdatedFld(convThesis.QuoteId);
}
}
/// <summary>
/// QuoteThesisContent(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuoteThesisContent
{
get
{
return mstrQuoteThesisContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuoteThesisContent = value;
}
else
{
 mstrQuoteThesisContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convThesis.QuoteThesisContent);
}
}
/// <summary>
/// QuoteThesisName(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuoteThesisName
{
get
{
return mstrQuoteThesisName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuoteThesisName = value;
}
else
{
 mstrQuoteThesisName = value;
}
//记录修改过的字段
 AddUpdatedFld(convThesis.QuoteThesisName);
}
}
/// <summary>
/// QuoteThesisTitle(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuoteThesisTitle
{
get
{
return mstrQuoteThesisTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuoteThesisTitle = value;
}
else
{
 mstrQuoteThesisTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convThesis.QuoteThesisTitle);
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
  return mstrThesisId;
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
  return mstrOperationTypeName;
 }
 }
}
 /// <summary>
 /// vThesis(vThesis)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convThesis
{
public const string _CurrTabName = "vThesis"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ThesisId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ThesisId", "ThesisTitle", "ThesisName", "ThesisContent", "Periodical", "Author", "ResearchQuestion", "UpdDate", "UpdUserId", "Memo", "OperationTypeId", "OperationTypeName", "Keyword", "LiteratureLink", "LiteratureSources", "ResearcherInformation", "UploadfileUrl", "IsQuotethesis", "QuoteId", "QuoteThesisContent", "QuoteThesisName", "QuoteThesisTitle"};
//以下是属性变量


 /// <summary>
 /// 常量:"ThesisId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ThesisId = "ThesisId";    //论文Id

 /// <summary>
 /// 常量:"ThesisTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ThesisTitle = "ThesisTitle";    //论文标题

 /// <summary>
 /// 常量:"ThesisName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ThesisName = "ThesisName";    //主题名称

 /// <summary>
 /// 常量:"ThesisContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ThesisContent = "ThesisContent";    //主题内容

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
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"OperationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OperationTypeId = "OperationTypeId";    //操作类型ID

 /// <summary>
 /// 常量:"OperationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OperationTypeName = "OperationTypeName";    //操作类型名

 /// <summary>
 /// 常量:"Keyword"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Keyword = "Keyword";    //关键字

 /// <summary>
 /// 常量:"LiteratureLink"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LiteratureLink = "LiteratureLink";    //文献链接

 /// <summary>
 /// 常量:"LiteratureSources"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LiteratureSources = "LiteratureSources";    //文献来源

 /// <summary>
 /// 常量:"ResearcherInformation"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResearcherInformation = "ResearcherInformation";    //研究者

 /// <summary>
 /// 常量:"UploadfileUrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UploadfileUrl = "UploadfileUrl";    //文件地址

 /// <summary>
 /// 常量:"IsQuotethesis"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsQuotethesis = "IsQuotethesis";    //是否引用论文

 /// <summary>
 /// 常量:"QuoteId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuoteId = "QuoteId";    //引用Id

 /// <summary>
 /// 常量:"QuoteThesisContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuoteThesisContent = "QuoteThesisContent";    //QuoteThesisContent

 /// <summary>
 /// 常量:"QuoteThesisName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuoteThesisName = "QuoteThesisName";    //QuoteThesisName

 /// <summary>
 /// 常量:"QuoteThesisTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuoteThesisTitle = "QuoteThesisTitle";    //QuoteThesisTitle
}

}