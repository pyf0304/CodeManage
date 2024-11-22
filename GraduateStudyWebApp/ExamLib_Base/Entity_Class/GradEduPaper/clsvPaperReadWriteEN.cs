
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperReadWriteEN
 表名:vPaperReadWrite(01120550)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:04:44
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
 /// 表vPaperReadWrite的关键字(PaperRWId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperRWId_vPaperReadWrite
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPaperRWId">表关键字</param>
public K_PaperRWId_vPaperReadWrite(string strPaperRWId)
{
if (IsValid(strPaperRWId)) Value = strPaperRWId;
else
{
Value = null;
}
}
private static bool IsValid(string strPaperRWId)
{
if (string.IsNullOrEmpty(strPaperRWId) == true) return false;
if (strPaperRWId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PaperRWId_vPaperReadWrite]类型的对象</returns>
public static implicit operator K_PaperRWId_vPaperReadWrite(string value)
{
return new K_PaperRWId_vPaperReadWrite(value);
}
}
 /// <summary>
 /// v论文读写表(vPaperReadWrite)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPaperReadWriteEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPaperReadWrite"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperRWId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 28;
public static string[] AttributeName = new string[] {"PaperRWId", "ReaderId", "PaperId", "PaperTitle", "PaperContent", "Periodical", "Author", "Keyword", "ResearchQuestion", "OperationTypeId", "OperationTypeName", "UpdDate", "Memo", "LiteratureLink", "LiteratureSources", "LiteratureTypeId", "LiteratureTypeName", "UploadfileUrl", "IsPublic", "IsSubmit", "Submitter", "Pcount", "TeaCount", "IdCurrEduCls", "SubVCount", "CreateDate", "ShareId", "UpdUser"};

protected string mstrPaperRWId;    //课文阅读
protected string mstrReaderId;    //阅读者Id
protected string mstrPaperId;    //论文Id
protected string mstrPaperTitle;    //论文标题
protected string mstrPaperContent;    //主题内容
protected string mstrPeriodical;    //期刊
protected string mstrAuthor;    //作者
protected string mstrKeyword;    //关键字
protected string mstrResearchQuestion;    //研究问题
protected string mstrOperationTypeId;    //操作类型ID
protected string mstrOperationTypeName;    //操作类型名
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrLiteratureLink;    //文献链接
protected string mstrLiteratureSources;    //文献来源
protected string mstrLiteratureTypeId;    //作文类型Id
protected string mstrLiteratureTypeName;    //作文类型名
protected string mstrUploadfileUrl;    //文件地址
protected bool mbolIsPublic;    //是否公开
protected bool mbolIsSubmit;    //是否提交
protected string mstrSubmitter;    //提交人
protected int? mintPcount;    //读写数
protected int? mintTeaCount;    //TeaCount
protected string mstrIdCurrEduCls;    //教学班流水号
protected int? mintSubVCount;    //论文子观点数
protected string mstrCreateDate;    //建立日期
protected string mstrShareId;    //分享Id
protected string mstrUpdUser;    //修改人

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvPaperReadWriteEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperRWId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strPaperRWId">关键字:课文阅读</param>
public clsvPaperReadWriteEN(string strPaperRWId)
 {
strPaperRWId = strPaperRWId.Replace("'", "''");
if (strPaperRWId.Length > 8)
{
throw new Exception("在表:vPaperReadWrite中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPaperRWId)  ==  true)
{
throw new Exception("在表:vPaperReadWrite中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPaperRWId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPaperRWId = strPaperRWId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperRWId");
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
if (strAttributeName  ==  convPaperReadWrite.PaperRWId)
{
return mstrPaperRWId;
}
else if (strAttributeName  ==  convPaperReadWrite.ReaderId)
{
return mstrReaderId;
}
else if (strAttributeName  ==  convPaperReadWrite.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convPaperReadWrite.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convPaperReadWrite.PaperContent)
{
return mstrPaperContent;
}
else if (strAttributeName  ==  convPaperReadWrite.Periodical)
{
return mstrPeriodical;
}
else if (strAttributeName  ==  convPaperReadWrite.Author)
{
return mstrAuthor;
}
else if (strAttributeName  ==  convPaperReadWrite.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  convPaperReadWrite.ResearchQuestion)
{
return mstrResearchQuestion;
}
else if (strAttributeName  ==  convPaperReadWrite.OperationTypeId)
{
return mstrOperationTypeId;
}
else if (strAttributeName  ==  convPaperReadWrite.OperationTypeName)
{
return mstrOperationTypeName;
}
else if (strAttributeName  ==  convPaperReadWrite.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convPaperReadWrite.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convPaperReadWrite.LiteratureLink)
{
return mstrLiteratureLink;
}
else if (strAttributeName  ==  convPaperReadWrite.LiteratureSources)
{
return mstrLiteratureSources;
}
else if (strAttributeName  ==  convPaperReadWrite.LiteratureTypeId)
{
return mstrLiteratureTypeId;
}
else if (strAttributeName  ==  convPaperReadWrite.LiteratureTypeName)
{
return mstrLiteratureTypeName;
}
else if (strAttributeName  ==  convPaperReadWrite.UploadfileUrl)
{
return mstrUploadfileUrl;
}
else if (strAttributeName  ==  convPaperReadWrite.IsPublic)
{
return mbolIsPublic;
}
else if (strAttributeName  ==  convPaperReadWrite.IsSubmit)
{
return mbolIsSubmit;
}
else if (strAttributeName  ==  convPaperReadWrite.Submitter)
{
return mstrSubmitter;
}
else if (strAttributeName  ==  convPaperReadWrite.Pcount)
{
return mintPcount;
}
else if (strAttributeName  ==  convPaperReadWrite.TeaCount)
{
return mintTeaCount;
}
else if (strAttributeName  ==  convPaperReadWrite.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convPaperReadWrite.SubVCount)
{
return mintSubVCount;
}
else if (strAttributeName  ==  convPaperReadWrite.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convPaperReadWrite.ShareId)
{
return mstrShareId;
}
else if (strAttributeName  ==  convPaperReadWrite.UpdUser)
{
return mstrUpdUser;
}
return null;
}
set
{
if (strAttributeName  ==  convPaperReadWrite.PaperRWId)
{
mstrPaperRWId = value.ToString();
 AddUpdatedFld(convPaperReadWrite.PaperRWId);
}
else if (strAttributeName  ==  convPaperReadWrite.ReaderId)
{
mstrReaderId = value.ToString();
 AddUpdatedFld(convPaperReadWrite.ReaderId);
}
else if (strAttributeName  ==  convPaperReadWrite.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convPaperReadWrite.PaperId);
}
else if (strAttributeName  ==  convPaperReadWrite.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convPaperReadWrite.PaperTitle);
}
else if (strAttributeName  ==  convPaperReadWrite.PaperContent)
{
mstrPaperContent = value.ToString();
 AddUpdatedFld(convPaperReadWrite.PaperContent);
}
else if (strAttributeName  ==  convPaperReadWrite.Periodical)
{
mstrPeriodical = value.ToString();
 AddUpdatedFld(convPaperReadWrite.Periodical);
}
else if (strAttributeName  ==  convPaperReadWrite.Author)
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convPaperReadWrite.Author);
}
else if (strAttributeName  ==  convPaperReadWrite.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convPaperReadWrite.Keyword);
}
else if (strAttributeName  ==  convPaperReadWrite.ResearchQuestion)
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(convPaperReadWrite.ResearchQuestion);
}
else if (strAttributeName  ==  convPaperReadWrite.OperationTypeId)
{
mstrOperationTypeId = value.ToString();
 AddUpdatedFld(convPaperReadWrite.OperationTypeId);
}
else if (strAttributeName  ==  convPaperReadWrite.OperationTypeName)
{
mstrOperationTypeName = value.ToString();
 AddUpdatedFld(convPaperReadWrite.OperationTypeName);
}
else if (strAttributeName  ==  convPaperReadWrite.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPaperReadWrite.UpdDate);
}
else if (strAttributeName  ==  convPaperReadWrite.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPaperReadWrite.Memo);
}
else if (strAttributeName  ==  convPaperReadWrite.LiteratureLink)
{
mstrLiteratureLink = value.ToString();
 AddUpdatedFld(convPaperReadWrite.LiteratureLink);
}
else if (strAttributeName  ==  convPaperReadWrite.LiteratureSources)
{
mstrLiteratureSources = value.ToString();
 AddUpdatedFld(convPaperReadWrite.LiteratureSources);
}
else if (strAttributeName  ==  convPaperReadWrite.LiteratureTypeId)
{
mstrLiteratureTypeId = value.ToString();
 AddUpdatedFld(convPaperReadWrite.LiteratureTypeId);
}
else if (strAttributeName  ==  convPaperReadWrite.LiteratureTypeName)
{
mstrLiteratureTypeName = value.ToString();
 AddUpdatedFld(convPaperReadWrite.LiteratureTypeName);
}
else if (strAttributeName  ==  convPaperReadWrite.UploadfileUrl)
{
mstrUploadfileUrl = value.ToString();
 AddUpdatedFld(convPaperReadWrite.UploadfileUrl);
}
else if (strAttributeName  ==  convPaperReadWrite.IsPublic)
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convPaperReadWrite.IsPublic);
}
else if (strAttributeName  ==  convPaperReadWrite.IsSubmit)
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convPaperReadWrite.IsSubmit);
}
else if (strAttributeName  ==  convPaperReadWrite.Submitter)
{
mstrSubmitter = value.ToString();
 AddUpdatedFld(convPaperReadWrite.Submitter);
}
else if (strAttributeName  ==  convPaperReadWrite.Pcount)
{
mintPcount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperReadWrite.Pcount);
}
else if (strAttributeName  ==  convPaperReadWrite.TeaCount)
{
mintTeaCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperReadWrite.TeaCount);
}
else if (strAttributeName  ==  convPaperReadWrite.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convPaperReadWrite.IdCurrEduCls);
}
else if (strAttributeName  ==  convPaperReadWrite.SubVCount)
{
mintSubVCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperReadWrite.SubVCount);
}
else if (strAttributeName  ==  convPaperReadWrite.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convPaperReadWrite.CreateDate);
}
else if (strAttributeName  ==  convPaperReadWrite.ShareId)
{
mstrShareId = value.ToString();
 AddUpdatedFld(convPaperReadWrite.ShareId);
}
else if (strAttributeName  ==  convPaperReadWrite.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convPaperReadWrite.UpdUser);
}
}
}
public object this[int intIndex]
{
get
{
if (convPaperReadWrite.PaperRWId  ==  AttributeName[intIndex])
{
return mstrPaperRWId;
}
else if (convPaperReadWrite.ReaderId  ==  AttributeName[intIndex])
{
return mstrReaderId;
}
else if (convPaperReadWrite.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convPaperReadWrite.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convPaperReadWrite.PaperContent  ==  AttributeName[intIndex])
{
return mstrPaperContent;
}
else if (convPaperReadWrite.Periodical  ==  AttributeName[intIndex])
{
return mstrPeriodical;
}
else if (convPaperReadWrite.Author  ==  AttributeName[intIndex])
{
return mstrAuthor;
}
else if (convPaperReadWrite.Keyword  ==  AttributeName[intIndex])
{
return mstrKeyword;
}
else if (convPaperReadWrite.ResearchQuestion  ==  AttributeName[intIndex])
{
return mstrResearchQuestion;
}
else if (convPaperReadWrite.OperationTypeId  ==  AttributeName[intIndex])
{
return mstrOperationTypeId;
}
else if (convPaperReadWrite.OperationTypeName  ==  AttributeName[intIndex])
{
return mstrOperationTypeName;
}
else if (convPaperReadWrite.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convPaperReadWrite.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convPaperReadWrite.LiteratureLink  ==  AttributeName[intIndex])
{
return mstrLiteratureLink;
}
else if (convPaperReadWrite.LiteratureSources  ==  AttributeName[intIndex])
{
return mstrLiteratureSources;
}
else if (convPaperReadWrite.LiteratureTypeId  ==  AttributeName[intIndex])
{
return mstrLiteratureTypeId;
}
else if (convPaperReadWrite.LiteratureTypeName  ==  AttributeName[intIndex])
{
return mstrLiteratureTypeName;
}
else if (convPaperReadWrite.UploadfileUrl  ==  AttributeName[intIndex])
{
return mstrUploadfileUrl;
}
else if (convPaperReadWrite.IsPublic  ==  AttributeName[intIndex])
{
return mbolIsPublic;
}
else if (convPaperReadWrite.IsSubmit  ==  AttributeName[intIndex])
{
return mbolIsSubmit;
}
else if (convPaperReadWrite.Submitter  ==  AttributeName[intIndex])
{
return mstrSubmitter;
}
else if (convPaperReadWrite.Pcount  ==  AttributeName[intIndex])
{
return mintPcount;
}
else if (convPaperReadWrite.TeaCount  ==  AttributeName[intIndex])
{
return mintTeaCount;
}
else if (convPaperReadWrite.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convPaperReadWrite.SubVCount  ==  AttributeName[intIndex])
{
return mintSubVCount;
}
else if (convPaperReadWrite.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convPaperReadWrite.ShareId  ==  AttributeName[intIndex])
{
return mstrShareId;
}
else if (convPaperReadWrite.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
return null;
}
set
{
if (convPaperReadWrite.PaperRWId  ==  AttributeName[intIndex])
{
mstrPaperRWId = value.ToString();
 AddUpdatedFld(convPaperReadWrite.PaperRWId);
}
else if (convPaperReadWrite.ReaderId  ==  AttributeName[intIndex])
{
mstrReaderId = value.ToString();
 AddUpdatedFld(convPaperReadWrite.ReaderId);
}
else if (convPaperReadWrite.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convPaperReadWrite.PaperId);
}
else if (convPaperReadWrite.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convPaperReadWrite.PaperTitle);
}
else if (convPaperReadWrite.PaperContent  ==  AttributeName[intIndex])
{
mstrPaperContent = value.ToString();
 AddUpdatedFld(convPaperReadWrite.PaperContent);
}
else if (convPaperReadWrite.Periodical  ==  AttributeName[intIndex])
{
mstrPeriodical = value.ToString();
 AddUpdatedFld(convPaperReadWrite.Periodical);
}
else if (convPaperReadWrite.Author  ==  AttributeName[intIndex])
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convPaperReadWrite.Author);
}
else if (convPaperReadWrite.Keyword  ==  AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convPaperReadWrite.Keyword);
}
else if (convPaperReadWrite.ResearchQuestion  ==  AttributeName[intIndex])
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(convPaperReadWrite.ResearchQuestion);
}
else if (convPaperReadWrite.OperationTypeId  ==  AttributeName[intIndex])
{
mstrOperationTypeId = value.ToString();
 AddUpdatedFld(convPaperReadWrite.OperationTypeId);
}
else if (convPaperReadWrite.OperationTypeName  ==  AttributeName[intIndex])
{
mstrOperationTypeName = value.ToString();
 AddUpdatedFld(convPaperReadWrite.OperationTypeName);
}
else if (convPaperReadWrite.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convPaperReadWrite.UpdDate);
}
else if (convPaperReadWrite.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPaperReadWrite.Memo);
}
else if (convPaperReadWrite.LiteratureLink  ==  AttributeName[intIndex])
{
mstrLiteratureLink = value.ToString();
 AddUpdatedFld(convPaperReadWrite.LiteratureLink);
}
else if (convPaperReadWrite.LiteratureSources  ==  AttributeName[intIndex])
{
mstrLiteratureSources = value.ToString();
 AddUpdatedFld(convPaperReadWrite.LiteratureSources);
}
else if (convPaperReadWrite.LiteratureTypeId  ==  AttributeName[intIndex])
{
mstrLiteratureTypeId = value.ToString();
 AddUpdatedFld(convPaperReadWrite.LiteratureTypeId);
}
else if (convPaperReadWrite.LiteratureTypeName  ==  AttributeName[intIndex])
{
mstrLiteratureTypeName = value.ToString();
 AddUpdatedFld(convPaperReadWrite.LiteratureTypeName);
}
else if (convPaperReadWrite.UploadfileUrl  ==  AttributeName[intIndex])
{
mstrUploadfileUrl = value.ToString();
 AddUpdatedFld(convPaperReadWrite.UploadfileUrl);
}
else if (convPaperReadWrite.IsPublic  ==  AttributeName[intIndex])
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convPaperReadWrite.IsPublic);
}
else if (convPaperReadWrite.IsSubmit  ==  AttributeName[intIndex])
{
mbolIsSubmit = TransNullToBool(value.ToString());
 AddUpdatedFld(convPaperReadWrite.IsSubmit);
}
else if (convPaperReadWrite.Submitter  ==  AttributeName[intIndex])
{
mstrSubmitter = value.ToString();
 AddUpdatedFld(convPaperReadWrite.Submitter);
}
else if (convPaperReadWrite.Pcount  ==  AttributeName[intIndex])
{
mintPcount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperReadWrite.Pcount);
}
else if (convPaperReadWrite.TeaCount  ==  AttributeName[intIndex])
{
mintTeaCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperReadWrite.TeaCount);
}
else if (convPaperReadWrite.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convPaperReadWrite.IdCurrEduCls);
}
else if (convPaperReadWrite.SubVCount  ==  AttributeName[intIndex])
{
mintSubVCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convPaperReadWrite.SubVCount);
}
else if (convPaperReadWrite.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convPaperReadWrite.CreateDate);
}
else if (convPaperReadWrite.ShareId  ==  AttributeName[intIndex])
{
mstrShareId = value.ToString();
 AddUpdatedFld(convPaperReadWrite.ShareId);
}
else if (convPaperReadWrite.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convPaperReadWrite.UpdUser);
}
}
}

/// <summary>
/// 课文阅读(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperRWId
{
get
{
return mstrPaperRWId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperRWId = value;
}
else
{
 mstrPaperRWId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaperReadWrite.PaperRWId);
}
}
/// <summary>
/// 阅读者Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReaderId
{
get
{
return mstrReaderId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReaderId = value;
}
else
{
 mstrReaderId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaperReadWrite.ReaderId);
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
 AddUpdatedFld(convPaperReadWrite.PaperId);
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
 AddUpdatedFld(convPaperReadWrite.PaperTitle);
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
 AddUpdatedFld(convPaperReadWrite.PaperContent);
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
 AddUpdatedFld(convPaperReadWrite.Periodical);
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
 AddUpdatedFld(convPaperReadWrite.Author);
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
 AddUpdatedFld(convPaperReadWrite.Keyword);
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
 AddUpdatedFld(convPaperReadWrite.ResearchQuestion);
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
 AddUpdatedFld(convPaperReadWrite.OperationTypeId);
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
 AddUpdatedFld(convPaperReadWrite.OperationTypeName);
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
 AddUpdatedFld(convPaperReadWrite.UpdDate);
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
 AddUpdatedFld(convPaperReadWrite.Memo);
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
 AddUpdatedFld(convPaperReadWrite.LiteratureLink);
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
 AddUpdatedFld(convPaperReadWrite.LiteratureSources);
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
 AddUpdatedFld(convPaperReadWrite.LiteratureTypeId);
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
 AddUpdatedFld(convPaperReadWrite.LiteratureTypeName);
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
 AddUpdatedFld(convPaperReadWrite.UploadfileUrl);
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
 AddUpdatedFld(convPaperReadWrite.IsPublic);
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
 AddUpdatedFld(convPaperReadWrite.IsSubmit);
}
}
/// <summary>
/// 提交人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Submitter
{
get
{
return mstrSubmitter;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSubmitter = value;
}
else
{
 mstrSubmitter = value;
}
//记录修改过的字段
 AddUpdatedFld(convPaperReadWrite.Submitter);
}
}
/// <summary>
/// 读写数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? Pcount
{
get
{
return mintPcount;
}
set
{
 mintPcount = value;
//记录修改过的字段
 AddUpdatedFld(convPaperReadWrite.Pcount);
}
}
/// <summary>
/// TeaCount(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? TeaCount
{
get
{
return mintTeaCount;
}
set
{
 mintTeaCount = value;
//记录修改过的字段
 AddUpdatedFld(convPaperReadWrite.TeaCount);
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
 AddUpdatedFld(convPaperReadWrite.IdCurrEduCls);
}
}
/// <summary>
/// 论文子观点数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? SubVCount
{
get
{
return mintSubVCount;
}
set
{
 mintSubVCount = value;
//记录修改过的字段
 AddUpdatedFld(convPaperReadWrite.SubVCount);
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
 AddUpdatedFld(convPaperReadWrite.CreateDate);
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
 AddUpdatedFld(convPaperReadWrite.ShareId);
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
 AddUpdatedFld(convPaperReadWrite.UpdUser);
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
  return mstrPaperRWId;
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
 /// v论文读写表(vPaperReadWrite)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPaperReadWrite
{
public const string _CurrTabName = "vPaperReadWrite"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperRWId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperRWId", "ReaderId", "PaperId", "PaperTitle", "PaperContent", "Periodical", "Author", "Keyword", "ResearchQuestion", "OperationTypeId", "OperationTypeName", "UpdDate", "Memo", "LiteratureLink", "LiteratureSources", "LiteratureTypeId", "LiteratureTypeName", "UploadfileUrl", "IsPublic", "IsSubmit", "Submitter", "Pcount", "TeaCount", "IdCurrEduCls", "SubVCount", "CreateDate", "ShareId", "UpdUser"};
//以下是属性变量


 /// <summary>
 /// 常量:"PaperRWId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperRWId = "PaperRWId";    //课文阅读

 /// <summary>
 /// 常量:"ReaderId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReaderId = "ReaderId";    //阅读者Id

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
 /// 常量:"Keyword"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Keyword = "Keyword";    //关键字

 /// <summary>
 /// 常量:"ResearchQuestion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ResearchQuestion = "ResearchQuestion";    //研究问题

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
 /// 常量:"UploadfileUrl"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UploadfileUrl = "UploadfileUrl";    //文件地址

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
 /// 常量:"Submitter"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Submitter = "Submitter";    //提交人

 /// <summary>
 /// 常量:"Pcount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Pcount = "Pcount";    //读写数

 /// <summary>
 /// 常量:"TeaCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeaCount = "TeaCount";    //TeaCount

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"SubVCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubVCount = "SubVCount";    //论文子观点数

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