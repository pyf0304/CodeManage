
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_TagsEN
 表名:vzx_Tags(01120854)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:14:17
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
 /// 表vzx_Tags的关键字(zxTagsId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxTagsId_vzx_Tags
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxTagsId">表关键字</param>
public K_zxTagsId_vzx_Tags(string strzxTagsId)
{
if (IsValid(strzxTagsId)) Value = strzxTagsId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxTagsId)
{
if (string.IsNullOrEmpty(strzxTagsId) == true) return false;
if (strzxTagsId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxTagsId_vzx_Tags]类型的对象</returns>
public static implicit operator K_zxTagsId_vzx_Tags(string value)
{
return new K_zxTagsId_vzx_Tags(value);
}
}
 /// <summary>
 /// vzx_Tags(vzx_Tags)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvzx_TagsEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vzx_Tags"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxTagsId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 25;
public static string[] AttributeName = new string[] {"TextTitle", "TextContent", "Author", "Keyword", "zxTagsId", "TagsContent", "PdfContent", "PdfPageNum", "VoteCount", "OrderNum", "UpdUser", "UpdDate", "PdfLineNum", "PdfX", "PdfY", "Memo", "IdCurrEduCls", "TextId", "zxShareId", "PdfPageNumIn", "PdfPageTop", "PdfDivLet", "PdfDivTop", "PdfZoom", "zxTagsTypeId"};

protected string mstrTextTitle;    //TextTitle
protected string mstrTextContent;    //TextContent
protected string mstrAuthor;    //作者
protected string mstrKeyword;    //关键字
protected string mstrzxTagsId;    //标注Id
protected string mstrTagsContent;    //标注内容
protected string mstrPdfContent;    //Pdf内容
protected int? mintPdfPageNum;    //Pdf页码
protected int? mintVoteCount;    //点赞计数
protected int? mintOrderNum;    //序号
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected int? mintPdfLineNum;    //pdf行号
protected string mstrPdfX;    //PdfX
protected string mstrPdfY;    //PdfY
protected string mstrMemo;    //备注
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrTextId;    //课件Id
protected string mstrzxShareId;    //分享Id
protected string mstrPdfPageNumIn;    //PdfPageNumIn
protected int? mintPdfPageTop;    //pdf页面顶部位置
protected string mstrPdfDivLet;    //PdfDivLet
protected string mstrPdfDivTop;    //PdfDivTop
protected string mstrPdfZoom;    //PdfZoom
protected string mstrzxTagsTypeId;    //标注类型ID

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvzx_TagsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxTagsId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxTagsId">关键字:标注Id</param>
public clsvzx_TagsEN(string strzxTagsId)
 {
strzxTagsId = strzxTagsId.Replace("'", "''");
if (strzxTagsId.Length > 10)
{
throw new Exception("在表:vzx_Tags中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxTagsId)  ==  true)
{
throw new Exception("在表:vzx_Tags中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxTagsId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxTagsId = strzxTagsId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxTagsId");
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
if (strAttributeName  ==  convzx_Tags.TextTitle)
{
return mstrTextTitle;
}
else if (strAttributeName  ==  convzx_Tags.TextContent)
{
return mstrTextContent;
}
else if (strAttributeName  ==  convzx_Tags.Author)
{
return mstrAuthor;
}
else if (strAttributeName  ==  convzx_Tags.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  convzx_Tags.zxTagsId)
{
return mstrzxTagsId;
}
else if (strAttributeName  ==  convzx_Tags.TagsContent)
{
return mstrTagsContent;
}
else if (strAttributeName  ==  convzx_Tags.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  convzx_Tags.PdfPageNum)
{
return mintPdfPageNum;
}
else if (strAttributeName  ==  convzx_Tags.VoteCount)
{
return mintVoteCount;
}
else if (strAttributeName  ==  convzx_Tags.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convzx_Tags.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convzx_Tags.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convzx_Tags.PdfLineNum)
{
return mintPdfLineNum;
}
else if (strAttributeName  ==  convzx_Tags.PdfX)
{
return mstrPdfX;
}
else if (strAttributeName  ==  convzx_Tags.PdfY)
{
return mstrPdfY;
}
else if (strAttributeName  ==  convzx_Tags.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convzx_Tags.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convzx_Tags.TextId)
{
return mstrTextId;
}
else if (strAttributeName  ==  convzx_Tags.zxShareId)
{
return mstrzxShareId;
}
else if (strAttributeName  ==  convzx_Tags.PdfPageNumIn)
{
return mstrPdfPageNumIn;
}
else if (strAttributeName  ==  convzx_Tags.PdfPageTop)
{
return mintPdfPageTop;
}
else if (strAttributeName  ==  convzx_Tags.PdfDivLet)
{
return mstrPdfDivLet;
}
else if (strAttributeName  ==  convzx_Tags.PdfDivTop)
{
return mstrPdfDivTop;
}
else if (strAttributeName  ==  convzx_Tags.PdfZoom)
{
return mstrPdfZoom;
}
else if (strAttributeName  ==  convzx_Tags.zxTagsTypeId)
{
return mstrzxTagsTypeId;
}
return null;
}
set
{
if (strAttributeName  ==  convzx_Tags.TextTitle)
{
mstrTextTitle = value.ToString();
 AddUpdatedFld(convzx_Tags.TextTitle);
}
else if (strAttributeName  ==  convzx_Tags.TextContent)
{
mstrTextContent = value.ToString();
 AddUpdatedFld(convzx_Tags.TextContent);
}
else if (strAttributeName  ==  convzx_Tags.Author)
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convzx_Tags.Author);
}
else if (strAttributeName  ==  convzx_Tags.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convzx_Tags.Keyword);
}
else if (strAttributeName  ==  convzx_Tags.zxTagsId)
{
mstrzxTagsId = value.ToString();
 AddUpdatedFld(convzx_Tags.zxTagsId);
}
else if (strAttributeName  ==  convzx_Tags.TagsContent)
{
mstrTagsContent = value.ToString();
 AddUpdatedFld(convzx_Tags.TagsContent);
}
else if (strAttributeName  ==  convzx_Tags.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convzx_Tags.PdfContent);
}
else if (strAttributeName  ==  convzx_Tags.PdfPageNum)
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Tags.PdfPageNum);
}
else if (strAttributeName  ==  convzx_Tags.VoteCount)
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Tags.VoteCount);
}
else if (strAttributeName  ==  convzx_Tags.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Tags.OrderNum);
}
else if (strAttributeName  ==  convzx_Tags.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_Tags.UpdUser);
}
else if (strAttributeName  ==  convzx_Tags.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_Tags.UpdDate);
}
else if (strAttributeName  ==  convzx_Tags.PdfLineNum)
{
mintPdfLineNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Tags.PdfLineNum);
}
else if (strAttributeName  ==  convzx_Tags.PdfX)
{
mstrPdfX = value.ToString();
 AddUpdatedFld(convzx_Tags.PdfX);
}
else if (strAttributeName  ==  convzx_Tags.PdfY)
{
mstrPdfY = value.ToString();
 AddUpdatedFld(convzx_Tags.PdfY);
}
else if (strAttributeName  ==  convzx_Tags.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_Tags.Memo);
}
else if (strAttributeName  ==  convzx_Tags.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convzx_Tags.IdCurrEduCls);
}
else if (strAttributeName  ==  convzx_Tags.TextId)
{
mstrTextId = value.ToString();
 AddUpdatedFld(convzx_Tags.TextId);
}
else if (strAttributeName  ==  convzx_Tags.zxShareId)
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(convzx_Tags.zxShareId);
}
else if (strAttributeName  ==  convzx_Tags.PdfPageNumIn)
{
mstrPdfPageNumIn = value.ToString();
 AddUpdatedFld(convzx_Tags.PdfPageNumIn);
}
else if (strAttributeName  ==  convzx_Tags.PdfPageTop)
{
mintPdfPageTop = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Tags.PdfPageTop);
}
else if (strAttributeName  ==  convzx_Tags.PdfDivLet)
{
mstrPdfDivLet = value.ToString();
 AddUpdatedFld(convzx_Tags.PdfDivLet);
}
else if (strAttributeName  ==  convzx_Tags.PdfDivTop)
{
mstrPdfDivTop = value.ToString();
 AddUpdatedFld(convzx_Tags.PdfDivTop);
}
else if (strAttributeName  ==  convzx_Tags.PdfZoom)
{
mstrPdfZoom = value.ToString();
 AddUpdatedFld(convzx_Tags.PdfZoom);
}
else if (strAttributeName  ==  convzx_Tags.zxTagsTypeId)
{
mstrzxTagsTypeId = value.ToString();
 AddUpdatedFld(convzx_Tags.zxTagsTypeId);
}
}
}
public object this[int intIndex]
{
get
{
if (convzx_Tags.TextTitle  ==  AttributeName[intIndex])
{
return mstrTextTitle;
}
else if (convzx_Tags.TextContent  ==  AttributeName[intIndex])
{
return mstrTextContent;
}
else if (convzx_Tags.Author  ==  AttributeName[intIndex])
{
return mstrAuthor;
}
else if (convzx_Tags.Keyword  ==  AttributeName[intIndex])
{
return mstrKeyword;
}
else if (convzx_Tags.zxTagsId  ==  AttributeName[intIndex])
{
return mstrzxTagsId;
}
else if (convzx_Tags.TagsContent  ==  AttributeName[intIndex])
{
return mstrTagsContent;
}
else if (convzx_Tags.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (convzx_Tags.PdfPageNum  ==  AttributeName[intIndex])
{
return mintPdfPageNum;
}
else if (convzx_Tags.VoteCount  ==  AttributeName[intIndex])
{
return mintVoteCount;
}
else if (convzx_Tags.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convzx_Tags.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convzx_Tags.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convzx_Tags.PdfLineNum  ==  AttributeName[intIndex])
{
return mintPdfLineNum;
}
else if (convzx_Tags.PdfX  ==  AttributeName[intIndex])
{
return mstrPdfX;
}
else if (convzx_Tags.PdfY  ==  AttributeName[intIndex])
{
return mstrPdfY;
}
else if (convzx_Tags.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convzx_Tags.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convzx_Tags.TextId  ==  AttributeName[intIndex])
{
return mstrTextId;
}
else if (convzx_Tags.zxShareId  ==  AttributeName[intIndex])
{
return mstrzxShareId;
}
else if (convzx_Tags.PdfPageNumIn  ==  AttributeName[intIndex])
{
return mstrPdfPageNumIn;
}
else if (convzx_Tags.PdfPageTop  ==  AttributeName[intIndex])
{
return mintPdfPageTop;
}
else if (convzx_Tags.PdfDivLet  ==  AttributeName[intIndex])
{
return mstrPdfDivLet;
}
else if (convzx_Tags.PdfDivTop  ==  AttributeName[intIndex])
{
return mstrPdfDivTop;
}
else if (convzx_Tags.PdfZoom  ==  AttributeName[intIndex])
{
return mstrPdfZoom;
}
else if (convzx_Tags.zxTagsTypeId  ==  AttributeName[intIndex])
{
return mstrzxTagsTypeId;
}
return null;
}
set
{
if (convzx_Tags.TextTitle  ==  AttributeName[intIndex])
{
mstrTextTitle = value.ToString();
 AddUpdatedFld(convzx_Tags.TextTitle);
}
else if (convzx_Tags.TextContent  ==  AttributeName[intIndex])
{
mstrTextContent = value.ToString();
 AddUpdatedFld(convzx_Tags.TextContent);
}
else if (convzx_Tags.Author  ==  AttributeName[intIndex])
{
mstrAuthor = value.ToString();
 AddUpdatedFld(convzx_Tags.Author);
}
else if (convzx_Tags.Keyword  ==  AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convzx_Tags.Keyword);
}
else if (convzx_Tags.zxTagsId  ==  AttributeName[intIndex])
{
mstrzxTagsId = value.ToString();
 AddUpdatedFld(convzx_Tags.zxTagsId);
}
else if (convzx_Tags.TagsContent  ==  AttributeName[intIndex])
{
mstrTagsContent = value.ToString();
 AddUpdatedFld(convzx_Tags.TagsContent);
}
else if (convzx_Tags.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convzx_Tags.PdfContent);
}
else if (convzx_Tags.PdfPageNum  ==  AttributeName[intIndex])
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Tags.PdfPageNum);
}
else if (convzx_Tags.VoteCount  ==  AttributeName[intIndex])
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Tags.VoteCount);
}
else if (convzx_Tags.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Tags.OrderNum);
}
else if (convzx_Tags.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_Tags.UpdUser);
}
else if (convzx_Tags.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_Tags.UpdDate);
}
else if (convzx_Tags.PdfLineNum  ==  AttributeName[intIndex])
{
mintPdfLineNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Tags.PdfLineNum);
}
else if (convzx_Tags.PdfX  ==  AttributeName[intIndex])
{
mstrPdfX = value.ToString();
 AddUpdatedFld(convzx_Tags.PdfX);
}
else if (convzx_Tags.PdfY  ==  AttributeName[intIndex])
{
mstrPdfY = value.ToString();
 AddUpdatedFld(convzx_Tags.PdfY);
}
else if (convzx_Tags.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_Tags.Memo);
}
else if (convzx_Tags.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convzx_Tags.IdCurrEduCls);
}
else if (convzx_Tags.TextId  ==  AttributeName[intIndex])
{
mstrTextId = value.ToString();
 AddUpdatedFld(convzx_Tags.TextId);
}
else if (convzx_Tags.zxShareId  ==  AttributeName[intIndex])
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(convzx_Tags.zxShareId);
}
else if (convzx_Tags.PdfPageNumIn  ==  AttributeName[intIndex])
{
mstrPdfPageNumIn = value.ToString();
 AddUpdatedFld(convzx_Tags.PdfPageNumIn);
}
else if (convzx_Tags.PdfPageTop  ==  AttributeName[intIndex])
{
mintPdfPageTop = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_Tags.PdfPageTop);
}
else if (convzx_Tags.PdfDivLet  ==  AttributeName[intIndex])
{
mstrPdfDivLet = value.ToString();
 AddUpdatedFld(convzx_Tags.PdfDivLet);
}
else if (convzx_Tags.PdfDivTop  ==  AttributeName[intIndex])
{
mstrPdfDivTop = value.ToString();
 AddUpdatedFld(convzx_Tags.PdfDivTop);
}
else if (convzx_Tags.PdfZoom  ==  AttributeName[intIndex])
{
mstrPdfZoom = value.ToString();
 AddUpdatedFld(convzx_Tags.PdfZoom);
}
else if (convzx_Tags.zxTagsTypeId  ==  AttributeName[intIndex])
{
mstrzxTagsTypeId = value.ToString();
 AddUpdatedFld(convzx_Tags.zxTagsTypeId);
}
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
 AddUpdatedFld(convzx_Tags.TextTitle);
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
 AddUpdatedFld(convzx_Tags.TextContent);
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
 AddUpdatedFld(convzx_Tags.Author);
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
 AddUpdatedFld(convzx_Tags.Keyword);
}
}
/// <summary>
/// 标注Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxTagsId
{
get
{
return mstrzxTagsId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxTagsId = value;
}
else
{
 mstrzxTagsId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Tags.zxTagsId);
}
}
/// <summary>
/// 标注内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TagsContent
{
get
{
return mstrTagsContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTagsContent = value;
}
else
{
 mstrTagsContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Tags.TagsContent);
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
 AddUpdatedFld(convzx_Tags.PdfContent);
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
 AddUpdatedFld(convzx_Tags.PdfPageNum);
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
 AddUpdatedFld(convzx_Tags.VoteCount);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convzx_Tags.OrderNum);
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
 AddUpdatedFld(convzx_Tags.UpdUser);
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
 AddUpdatedFld(convzx_Tags.UpdDate);
}
}
/// <summary>
/// pdf行号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PdfLineNum
{
get
{
return mintPdfLineNum;
}
set
{
 mintPdfLineNum = value;
//记录修改过的字段
 AddUpdatedFld(convzx_Tags.PdfLineNum);
}
}
/// <summary>
/// PdfX(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PdfX
{
get
{
return mstrPdfX;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPdfX = value;
}
else
{
 mstrPdfX = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Tags.PdfX);
}
}
/// <summary>
/// PdfY(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PdfY
{
get
{
return mstrPdfY;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPdfY = value;
}
else
{
 mstrPdfY = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Tags.PdfY);
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
 AddUpdatedFld(convzx_Tags.Memo);
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
 AddUpdatedFld(convzx_Tags.IdCurrEduCls);
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
 AddUpdatedFld(convzx_Tags.TextId);
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
 AddUpdatedFld(convzx_Tags.zxShareId);
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
 AddUpdatedFld(convzx_Tags.PdfPageNumIn);
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
 AddUpdatedFld(convzx_Tags.PdfPageTop);
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
 AddUpdatedFld(convzx_Tags.PdfDivLet);
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
 AddUpdatedFld(convzx_Tags.PdfDivTop);
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
 AddUpdatedFld(convzx_Tags.PdfZoom);
}
}
/// <summary>
/// 标注类型ID(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxTagsTypeId
{
get
{
return mstrzxTagsTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxTagsTypeId = value;
}
else
{
 mstrzxTagsTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_Tags.zxTagsTypeId);
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
  return mstrzxTagsId;
 }
 }
}
 /// <summary>
 /// vzx_Tags(vzx_Tags)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convzx_Tags
{
public const string _CurrTabName = "vzx_Tags"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxTagsId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TextTitle", "TextContent", "Author", "Keyword", "zxTagsId", "TagsContent", "PdfContent", "PdfPageNum", "VoteCount", "OrderNum", "UpdUser", "UpdDate", "PdfLineNum", "PdfX", "PdfY", "Memo", "IdCurrEduCls", "TextId", "zxShareId", "PdfPageNumIn", "PdfPageTop", "PdfDivLet", "PdfDivTop", "PdfZoom", "zxTagsTypeId"};
//以下是属性变量


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
 /// 常量:"Keyword"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Keyword = "Keyword";    //关键字

 /// <summary>
 /// 常量:"zxTagsId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxTagsId = "zxTagsId";    //标注Id

 /// <summary>
 /// 常量:"TagsContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TagsContent = "TagsContent";    //标注内容

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
 /// 常量:"VoteCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VoteCount = "VoteCount";    //点赞计数

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

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
 /// 常量:"PdfLineNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfLineNum = "PdfLineNum";    //pdf行号

 /// <summary>
 /// 常量:"PdfX"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfX = "PdfX";    //PdfX

 /// <summary>
 /// 常量:"PdfY"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfY = "PdfY";    //PdfY

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
 /// 常量:"TextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextId = "TextId";    //课件Id

 /// <summary>
 /// 常量:"zxShareId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxShareId = "zxShareId";    //分享Id

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
 /// 常量:"PdfZoom"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfZoom = "PdfZoom";    //PdfZoom

 /// <summary>
 /// 常量:"zxTagsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxTagsTypeId = "zxTagsTypeId";    //标注类型ID
}

}