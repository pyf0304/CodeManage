
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMajorDirectionPaperRelaEN
 表名:vMajorDirectionPaperRela(01120555)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:06:26
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
 /// 表vMajorDirectionPaperRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vMajorDirectionPaperRela
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_vMajorDirectionPaperRela(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_vMajorDirectionPaperRela]类型的对象</returns>
public static implicit operator K_mId_vMajorDirectionPaperRela(long value)
{
return new K_mId_vMajorDirectionPaperRela(value);
}
}
 /// <summary>
 /// v专业方向论文关系(vMajorDirectionPaperRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvMajorDirectionPaperRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vMajorDirectionPaperRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 26;
public static string[] AttributeName = new string[] {"mId", "MajorDirectionId", "PaperId", "UpdDate", "UpdUser", "Memo", "IdXzMajor", "MajorDirectionENName", "MajorDirectionName", "MajorDirectionExplain", "IsVisible", "PaperTitle", "PaperContent", "Periodical", "Author", "ResearchQuestion", "Keyword", "LiteratureSources", "LiteratureLink", "UploadfileUrl", "IsQuotethesis", "Checker", "IsChecked", "MajorID", "MajorName", "UserName"};

protected long mlngmId;    //mId
protected string mstrMajorDirectionId;    //研究方向Id
protected string mstrPaperId;    //论文Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorDirectionENName;    //研究方向英文名
protected string mstrMajorDirectionName;    //研究方向名
protected string mstrMajorDirectionExplain;    //专业方向说明
protected bool mbolIsVisible;    //是否显示
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
protected string mstrChecker;    //审核人
protected bool mbolIsChecked;    //是否检查
protected string mstrMajorID;    //专业ID
protected string mstrMajorName;    //专业名称
protected string mstrUserName;    //用户名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvMajorDirectionPaperRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsvMajorDirectionPaperRelaEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  convMajorDirectionPaperRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.MajorDirectionId)
{
return mstrMajorDirectionId;
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.MajorDirectionENName)
{
return mstrMajorDirectionENName;
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.MajorDirectionName)
{
return mstrMajorDirectionName;
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.MajorDirectionExplain)
{
return mstrMajorDirectionExplain;
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.PaperTitle)
{
return mstrPaperTitle;
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.PaperContent)
{
return mstrPaperContent;
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.Periodical)
{
return mstrPeriodical;
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.Author)
{
return mstrAuthor;
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.ResearchQuestion)
{
return mstrResearchQuestion;
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.LiteratureSources)
{
return mstrLiteratureSources;
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.LiteratureLink)
{
return mstrLiteratureLink;
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.UploadfileUrl)
{
return mstrUploadfileUrl;
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.IsQuotethesis)
{
return mbolIsQuotethesis;
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.Checker)
{
return mstrChecker;
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.IsChecked)
{
return mbolIsChecked;
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.MajorID)
{
return mstrMajorID;
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.UserName)
{
return mstrUserName;
}
return null;
}
set
{
if (strAttributeName  ==  convMajorDirectionPaperRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convMajorDirectionPaperRela.mId);
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.MajorDirectionId)
{
mstrMajorDirectionId = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.MajorDirectionId);
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.PaperId);
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.UpdDate);
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.UpdUser);
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.Memo);
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.IdXzMajor);
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.MajorDirectionENName)
{
mstrMajorDirectionENName = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.MajorDirectionENName);
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.MajorDirectionName)
{
mstrMajorDirectionName = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.MajorDirectionName);
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.MajorDirectionExplain)
{
mstrMajorDirectionExplain = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.MajorDirectionExplain);
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convMajorDirectionPaperRela.IsVisible);
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.PaperTitle)
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.PaperTitle);
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.PaperContent)
{
mstrPaperContent = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.PaperContent);
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.Periodical)
{
mstrPeriodical = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.Periodical);
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.Author)
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.Author);
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.ResearchQuestion)
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.ResearchQuestion);
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.Keyword);
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.LiteratureSources)
{
mstrLiteratureSources = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.LiteratureSources);
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.LiteratureLink)
{
mstrLiteratureLink = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.LiteratureLink);
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.UploadfileUrl)
{
mstrUploadfileUrl = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.UploadfileUrl);
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.IsQuotethesis)
{
mbolIsQuotethesis = TransNullToBool(value.ToString());
 AddUpdatedFld(convMajorDirectionPaperRela.IsQuotethesis);
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.Checker)
{
mstrChecker = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.Checker);
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.IsChecked)
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(convMajorDirectionPaperRela.IsChecked);
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.MajorID)
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.MajorID);
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.MajorName);
}
else if (strAttributeName  ==  convMajorDirectionPaperRela.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.UserName);
}
}
}
public object this[int intIndex]
{
get
{
if (convMajorDirectionPaperRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convMajorDirectionPaperRela.MajorDirectionId  ==  AttributeName[intIndex])
{
return mstrMajorDirectionId;
}
else if (convMajorDirectionPaperRela.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convMajorDirectionPaperRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convMajorDirectionPaperRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convMajorDirectionPaperRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convMajorDirectionPaperRela.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convMajorDirectionPaperRela.MajorDirectionENName  ==  AttributeName[intIndex])
{
return mstrMajorDirectionENName;
}
else if (convMajorDirectionPaperRela.MajorDirectionName  ==  AttributeName[intIndex])
{
return mstrMajorDirectionName;
}
else if (convMajorDirectionPaperRela.MajorDirectionExplain  ==  AttributeName[intIndex])
{
return mstrMajorDirectionExplain;
}
else if (convMajorDirectionPaperRela.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convMajorDirectionPaperRela.PaperTitle  ==  AttributeName[intIndex])
{
return mstrPaperTitle;
}
else if (convMajorDirectionPaperRela.PaperContent  ==  AttributeName[intIndex])
{
return mstrPaperContent;
}
else if (convMajorDirectionPaperRela.Periodical  ==  AttributeName[intIndex])
{
return mstrPeriodical;
}
else if (convMajorDirectionPaperRela.Author  ==  AttributeName[intIndex])
{
return mstrAuthor;
}
else if (convMajorDirectionPaperRela.ResearchQuestion  ==  AttributeName[intIndex])
{
return mstrResearchQuestion;
}
else if (convMajorDirectionPaperRela.Keyword  ==  AttributeName[intIndex])
{
return mstrKeyword;
}
else if (convMajorDirectionPaperRela.LiteratureSources  ==  AttributeName[intIndex])
{
return mstrLiteratureSources;
}
else if (convMajorDirectionPaperRela.LiteratureLink  ==  AttributeName[intIndex])
{
return mstrLiteratureLink;
}
else if (convMajorDirectionPaperRela.UploadfileUrl  ==  AttributeName[intIndex])
{
return mstrUploadfileUrl;
}
else if (convMajorDirectionPaperRela.IsQuotethesis  ==  AttributeName[intIndex])
{
return mbolIsQuotethesis;
}
else if (convMajorDirectionPaperRela.Checker  ==  AttributeName[intIndex])
{
return mstrChecker;
}
else if (convMajorDirectionPaperRela.IsChecked  ==  AttributeName[intIndex])
{
return mbolIsChecked;
}
else if (convMajorDirectionPaperRela.MajorID  ==  AttributeName[intIndex])
{
return mstrMajorID;
}
else if (convMajorDirectionPaperRela.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convMajorDirectionPaperRela.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
return null;
}
set
{
if (convMajorDirectionPaperRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convMajorDirectionPaperRela.mId);
}
else if (convMajorDirectionPaperRela.MajorDirectionId  ==  AttributeName[intIndex])
{
mstrMajorDirectionId = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.MajorDirectionId);
}
else if (convMajorDirectionPaperRela.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.PaperId);
}
else if (convMajorDirectionPaperRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.UpdDate);
}
else if (convMajorDirectionPaperRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.UpdUser);
}
else if (convMajorDirectionPaperRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.Memo);
}
else if (convMajorDirectionPaperRela.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.IdXzMajor);
}
else if (convMajorDirectionPaperRela.MajorDirectionENName  ==  AttributeName[intIndex])
{
mstrMajorDirectionENName = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.MajorDirectionENName);
}
else if (convMajorDirectionPaperRela.MajorDirectionName  ==  AttributeName[intIndex])
{
mstrMajorDirectionName = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.MajorDirectionName);
}
else if (convMajorDirectionPaperRela.MajorDirectionExplain  ==  AttributeName[intIndex])
{
mstrMajorDirectionExplain = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.MajorDirectionExplain);
}
else if (convMajorDirectionPaperRela.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convMajorDirectionPaperRela.IsVisible);
}
else if (convMajorDirectionPaperRela.PaperTitle  ==  AttributeName[intIndex])
{
mstrPaperTitle = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.PaperTitle);
}
else if (convMajorDirectionPaperRela.PaperContent  ==  AttributeName[intIndex])
{
mstrPaperContent = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.PaperContent);
}
else if (convMajorDirectionPaperRela.Periodical  ==  AttributeName[intIndex])
{
mstrPeriodical = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.Periodical);
}
else if (convMajorDirectionPaperRela.Author  ==  AttributeName[intIndex])
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.Author);
}
else if (convMajorDirectionPaperRela.ResearchQuestion  ==  AttributeName[intIndex])
{
mstrResearchQuestion = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.ResearchQuestion);
}
else if (convMajorDirectionPaperRela.Keyword  ==  AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.Keyword);
}
else if (convMajorDirectionPaperRela.LiteratureSources  ==  AttributeName[intIndex])
{
mstrLiteratureSources = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.LiteratureSources);
}
else if (convMajorDirectionPaperRela.LiteratureLink  ==  AttributeName[intIndex])
{
mstrLiteratureLink = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.LiteratureLink);
}
else if (convMajorDirectionPaperRela.UploadfileUrl  ==  AttributeName[intIndex])
{
mstrUploadfileUrl = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.UploadfileUrl);
}
else if (convMajorDirectionPaperRela.IsQuotethesis  ==  AttributeName[intIndex])
{
mbolIsQuotethesis = TransNullToBool(value.ToString());
 AddUpdatedFld(convMajorDirectionPaperRela.IsQuotethesis);
}
else if (convMajorDirectionPaperRela.Checker  ==  AttributeName[intIndex])
{
mstrChecker = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.Checker);
}
else if (convMajorDirectionPaperRela.IsChecked  ==  AttributeName[intIndex])
{
mbolIsChecked = TransNullToBool(value.ToString());
 AddUpdatedFld(convMajorDirectionPaperRela.IsChecked);
}
else if (convMajorDirectionPaperRela.MajorID  ==  AttributeName[intIndex])
{
mstrMajorID = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.MajorID);
}
else if (convMajorDirectionPaperRela.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.MajorName);
}
else if (convMajorDirectionPaperRela.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convMajorDirectionPaperRela.UserName);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(convMajorDirectionPaperRela.mId);
}
}
/// <summary>
/// 研究方向Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorDirectionId
{
get
{
return mstrMajorDirectionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorDirectionId = value;
}
else
{
 mstrMajorDirectionId = value;
}
//记录修改过的字段
 AddUpdatedFld(convMajorDirectionPaperRela.MajorDirectionId);
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
 AddUpdatedFld(convMajorDirectionPaperRela.PaperId);
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
 AddUpdatedFld(convMajorDirectionPaperRela.UpdDate);
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
 AddUpdatedFld(convMajorDirectionPaperRela.UpdUser);
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
 AddUpdatedFld(convMajorDirectionPaperRela.Memo);
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
 AddUpdatedFld(convMajorDirectionPaperRela.IdXzMajor);
}
}
/// <summary>
/// 研究方向英文名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorDirectionENName
{
get
{
return mstrMajorDirectionENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorDirectionENName = value;
}
else
{
 mstrMajorDirectionENName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMajorDirectionPaperRela.MajorDirectionENName);
}
}
/// <summary>
/// 研究方向名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorDirectionName
{
get
{
return mstrMajorDirectionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorDirectionName = value;
}
else
{
 mstrMajorDirectionName = value;
}
//记录修改过的字段
 AddUpdatedFld(convMajorDirectionPaperRela.MajorDirectionName);
}
}
/// <summary>
/// 专业方向说明(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorDirectionExplain
{
get
{
return mstrMajorDirectionExplain;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorDirectionExplain = value;
}
else
{
 mstrMajorDirectionExplain = value;
}
//记录修改过的字段
 AddUpdatedFld(convMajorDirectionPaperRela.MajorDirectionExplain);
}
}
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsVisible
{
get
{
return mbolIsVisible;
}
set
{
 mbolIsVisible = value;
//记录修改过的字段
 AddUpdatedFld(convMajorDirectionPaperRela.IsVisible);
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
 AddUpdatedFld(convMajorDirectionPaperRela.PaperTitle);
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
 AddUpdatedFld(convMajorDirectionPaperRela.PaperContent);
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
 AddUpdatedFld(convMajorDirectionPaperRela.Periodical);
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
 AddUpdatedFld(convMajorDirectionPaperRela.Author);
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
 AddUpdatedFld(convMajorDirectionPaperRela.ResearchQuestion);
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
 AddUpdatedFld(convMajorDirectionPaperRela.Keyword);
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
 AddUpdatedFld(convMajorDirectionPaperRela.LiteratureSources);
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
 AddUpdatedFld(convMajorDirectionPaperRela.LiteratureLink);
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
 AddUpdatedFld(convMajorDirectionPaperRela.UploadfileUrl);
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
 AddUpdatedFld(convMajorDirectionPaperRela.IsQuotethesis);
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
 AddUpdatedFld(convMajorDirectionPaperRela.Checker);
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
 AddUpdatedFld(convMajorDirectionPaperRela.IsChecked);
}
}
/// <summary>
/// 专业ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorID
{
get
{
return mstrMajorID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorID = value;
}
else
{
 mstrMajorID = value;
}
//记录修改过的字段
 AddUpdatedFld(convMajorDirectionPaperRela.MajorID);
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
 AddUpdatedFld(convMajorDirectionPaperRela.MajorName);
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
 AddUpdatedFld(convMajorDirectionPaperRela.UserName);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// v专业方向论文关系(vMajorDirectionPaperRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convMajorDirectionPaperRela
{
public const string _CurrTabName = "vMajorDirectionPaperRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "MajorDirectionId", "PaperId", "UpdDate", "UpdUser", "Memo", "IdXzMajor", "MajorDirectionENName", "MajorDirectionName", "MajorDirectionExplain", "IsVisible", "PaperTitle", "PaperContent", "Periodical", "Author", "ResearchQuestion", "Keyword", "LiteratureSources", "LiteratureLink", "UploadfileUrl", "IsQuotethesis", "Checker", "IsChecked", "MajorID", "MajorName", "UserName"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"MajorDirectionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorDirectionId = "MajorDirectionId";    //研究方向Id

 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

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
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

 /// <summary>
 /// 常量:"MajorDirectionENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorDirectionENName = "MajorDirectionENName";    //研究方向英文名

 /// <summary>
 /// 常量:"MajorDirectionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorDirectionName = "MajorDirectionName";    //研究方向名

 /// <summary>
 /// 常量:"MajorDirectionExplain"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorDirectionExplain = "MajorDirectionExplain";    //专业方向说明

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

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
 /// 常量:"Checker"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Checker = "Checker";    //审核人

 /// <summary>
 /// 常量:"IsChecked"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsChecked = "IsChecked";    //是否检查

 /// <summary>
 /// 常量:"MajorID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorID = "MajorID";    //专业ID

 /// <summary>
 /// 常量:"MajorName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorName = "MajorName";    //专业名称

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名
}

}