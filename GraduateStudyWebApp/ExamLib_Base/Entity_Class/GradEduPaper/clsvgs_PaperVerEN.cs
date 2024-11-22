
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PaperVerEN
 表名:vgs_PaperVer(01120677)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:01:32
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
 /// 表vgs_PaperVer的关键字(PaperVId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperVId_vgs_PaperVer
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngPaperVId">表关键字</param>
public K_PaperVId_vgs_PaperVer(long lngPaperVId)
{
if (IsValid(lngPaperVId)) Value = lngPaperVId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngPaperVId)
{
if (lngPaperVId == 0) return false;
if (lngPaperVId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PaperVId_vgs_PaperVer]类型的对象</returns>
public static implicit operator K_PaperVId_vgs_PaperVer(long value)
{
return new K_PaperVId_vgs_PaperVer(value);
}
}
 /// <summary>
 /// 论文历史版本视图(vgs_PaperVer)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvgs_PaperVerEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vgs_PaperVer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 26;
public static string[] AttributeName = new string[] {"PaperVId", "PaperId", "PaperTitle", "PaperContent", "Periodical", "Author", "ResearchQuestion", "Keyword", "LiteratureSources", "LiteratureLink", "UploadfileUrl", "IsQuotethesis", "IsSubmit", "IsChecked", "QuoteId", "Checker", "LiteratureTypeId", "LiteratureTypeName", "UpdUser", "UpdDate", "IdCurrEduCls", "PaperTypeId", "PaperTypeName", "PaperStatusId", "PaperStatusName", "Memo"};

protected long mlngPaperVId;    //PaperVId
protected string mstrPaperId;    //论文Id
protected string mstrPaperTitle;    //论文标题
protected string mstrPaperContent;    //主题内容
protected string mstrPeriodical;    //期刊
protected string mstrAuthor;    //作者
protected string mstrResearchQuestion;    //研究问题
protected string mstrKeyword;    //关键字
protected string mstrLiteratureSources;    //文献来源
protected string mstrLiteratureLink;    //文献链接
protected string mstrUploadfileUrl;    //文件地址
protected bool mbolIsQuotethesis;    //是否引用论文
protected bool mbolIsSubmit;    //是否提交
protected bool mbolIsChecked;    //是否检查
protected string mstrQuoteId;    //引用Id
protected string mstrChecker;    //审核人
protected string mstrLiteratureTypeId;    //作文类型Id
protected string mstrLiteratureTypeName;    //作文类型名
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrPaperTypeId;    //论文类型Id
protected string mstrPaperTypeName;    //论文类型名
protected string mstrPaperStatusId;    //论文状态Id
protected string mstrPaperStatusName;    //论文状态名
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvgs_PaperVerEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperVId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngPaperVId">关键字:PaperVId</param>
public clsvgs_PaperVerEN(long lngPaperVId)
 {
 if (lngPaperVId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngPaperVId = lngPaperVId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperVId");
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
if (strAttributeName  ==  convgs_PaperVer.PaperVId)
{
return mlngPaperVId;
}
else if (strAttributeName  ==  convgs_PaperVer.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convgs_PaperVer.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convgs_PaperVer.PaperContent)
{
return mstrPaperContent;
}
else if (strAttributeName  ==  convgs_PaperVer.Periodical)
{
return mstrPeriodical;
}
else if (strAttributeName  ==  convgs_PaperVer.Author)
{
return mstrAuthor;
}
else if (strAttributeName  ==  convgs_PaperVer.ResearchQuestion)
{
return mstrResearchQuestion;
}
else if (strAttributeName  ==  convgs_PaperVer.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  convgs_PaperVer.LiteratureSources)
{
return mstrLiteratureSources;
}
else if (strAttributeName  ==  convgs_PaperVer.LiteratureLink)
{
return mstrLiteratureLink;
}
else if (strAttributeName  ==  convgs_PaperVer.UploadfileUrl)
{
return mstrUploadfileUrl;
}
else if (strAttributeName  ==  convgs_PaperVer.IsQuotethesis)
{
return mbolIsQuotethesis;
}
else if (strAttributeName  ==  convgs_PaperVer.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convgs_PaperVer.IsChecked)
{
return mbolIsChecked;
}
else if (strAttributeName  ==  convgs_PaperVer.QuoteId)
{
return mstrQuoteId;
}
else if (strAttributeName  ==  convgs_PaperVer.Checker)
{
return mstrChecker;
}
else if (strAttributeName  ==  convgs_PaperVer.LiteratureTypeId)
{
return mstrLiteratureTypeId;
}
else if (strAttributeName  ==  convgs_PaperVer.LiteratureTypeName)
{
return mstrLiteratureTypeName;
}
else if (strAttributeName  ==  convgs_PaperVer.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convgs_PaperVer.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convgs_PaperVer.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convgs_PaperVer.PaperTypeId)
{
return mstrPaperTypeId;
}
else if (strAttributeName  ==  convgs_PaperVer.PaperTypeName)
{
return mstrPaperTypeName;
}
else if (strAttributeName  ==  convgs_PaperVer.PaperStatusId)
{
return mstrPaperStatusId;
}
else if (strAttributeName  ==  convgs_PaperVer.PaperStatusName)
{
return mstrPaperStatusName;
}
else if (strAttributeName  ==  convgs_PaperVer.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convgs_PaperVer.PaperVId)
{
mlngPaperVId = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PaperVer.PaperVId);
}
else if (strAttributeName  ==  convgs_PaperVer.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convgs_PaperVer.PaperId);
}
else if (strAttributeName  ==  convgs_PaperVer.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convgs_PaperVer.PaperTitle);
}
else if (strAttributeName  ==  convgs_PaperVer.PaperContent)
{
mstrPaperContent = value.ToString();
 AddUpdatedFld(convgs_PaperVer.PaperContent);
}
else if (strAttributeName  ==  convgs_PaperVer.Periodical)
{
mstrPeriodical = value.ToString();
 AddUpdatedFld(convgs_PaperVer.Periodical);
}
else if (strAttributeName  ==  convgs_PaperVer.Author)
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convgs_PaperVer.Author);
}
else if (strAttributeName  ==  convgs_PaperVer.ResearchQuestion)
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(convgs_PaperVer.ResearchQuestion);
}
else if (strAttributeName  ==  convgs_PaperVer.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convgs_PaperVer.Keyword);
}
else if (strAttributeName  ==  convgs_PaperVer.LiteratureSources)
{
mstrLiteratureSources = value.ToString();
 AddUpdatedFld(convgs_PaperVer.LiteratureSources);
}
else if (strAttributeName  ==  convgs_PaperVer.LiteratureLink)
{
mstrLiteratureLink = value.ToString();
 AddUpdatedFld(convgs_PaperVer.LiteratureLink);
}
else if (strAttributeName  ==  convgs_PaperVer.UploadfileUrl)
{
mstrUploadfileUrl = value.ToString();
 AddUpdatedFld(convgs_PaperVer.UploadfileUrl);
}
else if (strAttributeName  ==  convgs_PaperVer.IsQuotethesis)
{
mbolIsQuotethesis = TransNullToBool(value.ToString());
 AddUpdatedFld(convgs_PaperVer.IsQuotethesis);
}
else if (strAttributeName  ==  convgs_PaperVer.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convgs_PaperVer.IsSubmit);
}
else if (strAttributeName  ==  convgs_PaperVer.IsChecked)
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(convgs_PaperVer.IsChecked);
}
else if (strAttributeName  ==  convgs_PaperVer.QuoteId)
{
mstrQuoteId = value.ToString();
 AddUpdatedFld(convgs_PaperVer.QuoteId);
}
else if (strAttributeName  ==  convgs_PaperVer.Checker)
{
mstrChecker = value.ToString();
 AddUpdatedFld(convgs_PaperVer.Checker);
}
else if (strAttributeName  ==  convgs_PaperVer.LiteratureTypeId)
{
mstrLiteratureTypeId = value.ToString();
 AddUpdatedFld(convgs_PaperVer.LiteratureTypeId);
}
else if (strAttributeName  ==  convgs_PaperVer.LiteratureTypeName)
{
mstrLiteratureTypeName = value.ToString();
 AddUpdatedFld(convgs_PaperVer.LiteratureTypeName);
}
else if (strAttributeName  ==  convgs_PaperVer.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convgs_PaperVer.UpdUser);
}
else if (strAttributeName  ==  convgs_PaperVer.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convgs_PaperVer.UpdDate);
}
else if (strAttributeName  ==  convgs_PaperVer.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convgs_PaperVer.IdCurrEduCls);
}
else if (strAttributeName  ==  convgs_PaperVer.PaperTypeId)
{
mstrPaperTypeId = value.ToString();
 AddUpdatedFld(convgs_PaperVer.PaperTypeId);
}
else if (strAttributeName  ==  convgs_PaperVer.PaperTypeName)
{
mstrPaperTypeName = value.ToString();
 AddUpdatedFld(convgs_PaperVer.PaperTypeName);
}
else if (strAttributeName  ==  convgs_PaperVer.PaperStatusId)
{
mstrPaperStatusId = value.ToString();
 AddUpdatedFld(convgs_PaperVer.PaperStatusId);
}
else if (strAttributeName  ==  convgs_PaperVer.PaperStatusName)
{
mstrPaperStatusName = value.ToString();
 AddUpdatedFld(convgs_PaperVer.PaperStatusName);
}
else if (strAttributeName  ==  convgs_PaperVer.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convgs_PaperVer.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convgs_PaperVer.PaperVId  ==  AttributeName[intIndex])
{
return mlngPaperVId;
}
else if (convgs_PaperVer.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convgs_PaperVer.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convgs_PaperVer.PaperContent  ==  AttributeName[intIndex])
{
return mstrPaperContent;
}
else if (convgs_PaperVer.Periodical  ==  AttributeName[intIndex])
{
return mstrPeriodical;
}
else if (convgs_PaperVer.Author  ==  AttributeName[intIndex])
{
return mstrAuthor;
}
else if (convgs_PaperVer.ResearchQuestion  ==  AttributeName[intIndex])
{
return mstrResearchQuestion;
}
else if (convgs_PaperVer.Keyword  ==  AttributeName[intIndex])
{
return mstrKeyword;
}
else if (convgs_PaperVer.LiteratureSources  ==  AttributeName[intIndex])
{
return mstrLiteratureSources;
}
else if (convgs_PaperVer.LiteratureLink  ==  AttributeName[intIndex])
{
return mstrLiteratureLink;
}
else if (convgs_PaperVer.UploadfileUrl  ==  AttributeName[intIndex])
{
return mstrUploadfileUrl;
}
else if (convgs_PaperVer.IsQuotethesis  ==  AttributeName[intIndex])
{
return mbolIsQuotethesis;
}
else if (convgs_PaperVer.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convgs_PaperVer.IsChecked  ==  AttributeName[intIndex])
{
return mbolIsChecked;
}
else if (convgs_PaperVer.QuoteId  ==  AttributeName[intIndex])
{
return mstrQuoteId;
}
else if (convgs_PaperVer.Checker  ==  AttributeName[intIndex])
{
return mstrChecker;
}
else if (convgs_PaperVer.LiteratureTypeId  ==  AttributeName[intIndex])
{
return mstrLiteratureTypeId;
}
else if (convgs_PaperVer.LiteratureTypeName  ==  AttributeName[intIndex])
{
return mstrLiteratureTypeName;
}
else if (convgs_PaperVer.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convgs_PaperVer.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convgs_PaperVer.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convgs_PaperVer.PaperTypeId  ==  AttributeName[intIndex])
{
return mstrPaperTypeId;
}
else if (convgs_PaperVer.PaperTypeName  ==  AttributeName[intIndex])
{
return mstrPaperTypeName;
}
else if (convgs_PaperVer.PaperStatusId  ==  AttributeName[intIndex])
{
return mstrPaperStatusId;
}
else if (convgs_PaperVer.PaperStatusName  ==  AttributeName[intIndex])
{
return mstrPaperStatusName;
}
else if (convgs_PaperVer.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convgs_PaperVer.PaperVId  ==  AttributeName[intIndex])
{
mlngPaperVId = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PaperVer.PaperVId);
}
else if (convgs_PaperVer.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convgs_PaperVer.PaperId);
}
else if (convgs_PaperVer.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convgs_PaperVer.PaperTitle);
}
else if (convgs_PaperVer.PaperContent  ==  AttributeName[intIndex])
{
mstrPaperContent = value.ToString();
 AddUpdatedFld(convgs_PaperVer.PaperContent);
}
else if (convgs_PaperVer.Periodical  ==  AttributeName[intIndex])
{
mstrPeriodical = value.ToString();
 AddUpdatedFld(convgs_PaperVer.Periodical);
}
else if (convgs_PaperVer.Author  ==  AttributeName[intIndex])
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convgs_PaperVer.Author);
}
else if (convgs_PaperVer.ResearchQuestion  ==  AttributeName[intIndex])
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(convgs_PaperVer.ResearchQuestion);
}
else if (convgs_PaperVer.Keyword  ==  AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convgs_PaperVer.Keyword);
}
else if (convgs_PaperVer.LiteratureSources  ==  AttributeName[intIndex])
{
mstrLiteratureSources = value.ToString();
 AddUpdatedFld(convgs_PaperVer.LiteratureSources);
}
else if (convgs_PaperVer.LiteratureLink  ==  AttributeName[intIndex])
{
mstrLiteratureLink = value.ToString();
 AddUpdatedFld(convgs_PaperVer.LiteratureLink);
}
else if (convgs_PaperVer.UploadfileUrl  ==  AttributeName[intIndex])
{
mstrUploadfileUrl = value.ToString();
 AddUpdatedFld(convgs_PaperVer.UploadfileUrl);
}
else if (convgs_PaperVer.IsQuotethesis  ==  AttributeName[intIndex])
{
mbolIsQuotethesis = TransNullToBool(value.ToString());
 AddUpdatedFld(convgs_PaperVer.IsQuotethesis);
}
else if (convgs_PaperVer.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convgs_PaperVer.IsSubmit);
}
else if (convgs_PaperVer.IsChecked  ==  AttributeName[intIndex])
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(convgs_PaperVer.IsChecked);
}
else if (convgs_PaperVer.QuoteId  ==  AttributeName[intIndex])
{
mstrQuoteId = value.ToString();
 AddUpdatedFld(convgs_PaperVer.QuoteId);
}
else if (convgs_PaperVer.Checker  ==  AttributeName[intIndex])
{
mstrChecker = value.ToString();
 AddUpdatedFld(convgs_PaperVer.Checker);
}
else if (convgs_PaperVer.LiteratureTypeId  ==  AttributeName[intIndex])
{
mstrLiteratureTypeId = value.ToString();
 AddUpdatedFld(convgs_PaperVer.LiteratureTypeId);
}
else if (convgs_PaperVer.LiteratureTypeName  ==  AttributeName[intIndex])
{
mstrLiteratureTypeName = value.ToString();
 AddUpdatedFld(convgs_PaperVer.LiteratureTypeName);
}
else if (convgs_PaperVer.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convgs_PaperVer.UpdUser);
}
else if (convgs_PaperVer.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convgs_PaperVer.UpdDate);
}
else if (convgs_PaperVer.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convgs_PaperVer.IdCurrEduCls);
}
else if (convgs_PaperVer.PaperTypeId  ==  AttributeName[intIndex])
{
mstrPaperTypeId = value.ToString();
 AddUpdatedFld(convgs_PaperVer.PaperTypeId);
}
else if (convgs_PaperVer.PaperTypeName  ==  AttributeName[intIndex])
{
mstrPaperTypeName = value.ToString();
 AddUpdatedFld(convgs_PaperVer.PaperTypeName);
}
else if (convgs_PaperVer.PaperStatusId  ==  AttributeName[intIndex])
{
mstrPaperStatusId = value.ToString();
 AddUpdatedFld(convgs_PaperVer.PaperStatusId);
}
else if (convgs_PaperVer.PaperStatusName  ==  AttributeName[intIndex])
{
mstrPaperStatusName = value.ToString();
 AddUpdatedFld(convgs_PaperVer.PaperStatusName);
}
else if (convgs_PaperVer.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convgs_PaperVer.Memo);
}
}
}

/// <summary>
/// PaperVId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long PaperVId
{
get
{
return mlngPaperVId;
}
set
{
 mlngPaperVId = value;
//记录修改过的字段
 AddUpdatedFld(convgs_PaperVer.PaperVId);
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
 AddUpdatedFld(convgs_PaperVer.PaperId);
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
 AddUpdatedFld(convgs_PaperVer.PaperTitle);
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
 AddUpdatedFld(convgs_PaperVer.PaperContent);
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
 AddUpdatedFld(convgs_PaperVer.Periodical);
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
 AddUpdatedFld(convgs_PaperVer.Author);
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
 AddUpdatedFld(convgs_PaperVer.ResearchQuestion);
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
 AddUpdatedFld(convgs_PaperVer.Keyword);
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
 AddUpdatedFld(convgs_PaperVer.LiteratureSources);
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
 AddUpdatedFld(convgs_PaperVer.LiteratureLink);
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
 AddUpdatedFld(convgs_PaperVer.UploadfileUrl);
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
 AddUpdatedFld(convgs_PaperVer.IsQuotethesis);
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
 AddUpdatedFld(convgs_PaperVer.IsSubmit);
}
}
/// <summary>
/// 是否检查(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsChecked
{
get
{
return mbolIsChecked;
}
set
{
 mbolIsChecked = value;
//记录修改过的字段
 AddUpdatedFld(convgs_PaperVer.IsChecked);
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
 AddUpdatedFld(convgs_PaperVer.QuoteId);
}
}
/// <summary>
/// 审核人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Checker
{
get
{
return mstrChecker;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrChecker = value;
}
else
{
 mstrChecker = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PaperVer.Checker);
}
}
/// <summary>
/// 作文类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LiteratureTypeId
{
get
{
return mstrLiteratureTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLiteratureTypeId = value;
}
else
{
 mstrLiteratureTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PaperVer.LiteratureTypeId);
}
}
/// <summary>
/// 作文类型名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LiteratureTypeName
{
get
{
return mstrLiteratureTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLiteratureTypeName = value;
}
else
{
 mstrLiteratureTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PaperVer.LiteratureTypeName);
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
 AddUpdatedFld(convgs_PaperVer.UpdUser);
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
 AddUpdatedFld(convgs_PaperVer.UpdDate);
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
 AddUpdatedFld(convgs_PaperVer.IdCurrEduCls);
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
 AddUpdatedFld(convgs_PaperVer.PaperTypeId);
}
}
/// <summary>
/// 论文类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperTypeName
{
get
{
return mstrPaperTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperTypeName = value;
}
else
{
 mstrPaperTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PaperVer.PaperTypeName);
}
}
/// <summary>
/// 论文状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperStatusId
{
get
{
return mstrPaperStatusId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperStatusId = value;
}
else
{
 mstrPaperStatusId = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PaperVer.PaperStatusId);
}
}
/// <summary>
/// 论文状态名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperStatusName
{
get
{
return mstrPaperStatusName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperStatusName = value;
}
else
{
 mstrPaperStatusName = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PaperVer.PaperStatusName);
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
 AddUpdatedFld(convgs_PaperVer.Memo);
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
  return mlngPaperVId.ToString();
 }
 }
}
 /// <summary>
 /// 论文历史版本视图(vgs_PaperVer)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convgs_PaperVer
{
public const string _CurrTabName = "vgs_PaperVer"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperVId", "PaperId", "PaperTitle", "PaperContent", "Periodical", "Author", "ResearchQuestion", "Keyword", "LiteratureSources", "LiteratureLink", "UploadfileUrl", "IsQuotethesis", "IsSubmit", "IsChecked", "QuoteId", "Checker", "LiteratureTypeId", "LiteratureTypeName", "UpdUser", "UpdDate", "IdCurrEduCls", "PaperTypeId", "PaperTypeName", "PaperStatusId", "PaperStatusName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"PaperVId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperVId = "PaperVId";    //PaperVId

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
 /// 常量:"Keyword"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Keyword = "Keyword";    //关键字

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
 /// 常量:"IsQuotethesis"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsQuotethesis = "IsQuotethesis";    //是否引用论文

 /// <summary>
 /// 常量:"IsSubmit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSubmit = "IsSubmit";    //是否提交

 /// <summary>
 /// 常量:"IsChecked"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsChecked = "IsChecked";    //是否检查

 /// <summary>
 /// 常量:"QuoteId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuoteId = "QuoteId";    //引用Id

 /// <summary>
 /// 常量:"Checker"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Checker = "Checker";    //审核人

 /// <summary>
 /// 常量:"LiteratureTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LiteratureTypeId = "LiteratureTypeId";    //作文类型Id

 /// <summary>
 /// 常量:"LiteratureTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LiteratureTypeName = "LiteratureTypeName";    //作文类型名

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"PaperTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTypeId = "PaperTypeId";    //论文类型Id

 /// <summary>
 /// 常量:"PaperTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTypeName = "PaperTypeName";    //论文类型名

 /// <summary>
 /// 常量:"PaperStatusId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperStatusId = "PaperStatusId";    //论文状态Id

 /// <summary>
 /// 常量:"PaperStatusName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperStatusName = "PaperStatusName";    //论文状态名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}