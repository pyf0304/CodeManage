
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_TagsEN
 表名:gs_Tags(01120714)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:07
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
 框架-层名:实体层(CS)(EntityLayer,0001)
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
using System.Collections.Generic;

namespace ExamLib.Entity
{
 /// <summary>
 /// 表gs_Tags的关键字(TagsId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TagsId_gs_Tags
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTagsId">表关键字</param>
public K_TagsId_gs_Tags(string strTagsId)
{
if (IsValid(strTagsId)) Value = strTagsId;
else
{
Value = null;
}
}
private static bool IsValid(string strTagsId)
{
if (string.IsNullOrEmpty(strTagsId) == true) return false;
if (strTagsId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TagsId_gs_Tags]类型的对象</returns>
public static implicit operator K_TagsId_gs_Tags(string value)
{
return new K_TagsId_gs_Tags(value);
}
}
 /// <summary>
 /// 标注(gs_Tags)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_TagsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_Tags"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TagsId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 23;
public static string[] AttributeName = new string[] {"TagsId", "TagsContent", "PdfContent", "PdfPageNum", "VoteCount", "UserId", "OrderNum", "UpdUser", "UpdDate", "PdfLineNum", "PdfX", "PdfY", "Memo", "IdCurrEduCls", "PaperId", "ShareId", "PdfPageNumIn", "PdfPageTop", "selectSpanRange", "PdfDivLet", "PdfDivTop", "PdfZoom", "TagsTypeId"};

protected string mstrTagsId;    //标注Id
protected string mstrTagsContent;    //标注内容
protected string mstrPdfContent;    //Pdf内容
protected int? mintPdfPageNum;    //Pdf页码
protected int? mintVoteCount;    //点赞计数
protected string mstrUserId;    //用户ID
protected int? mintOrderNum;    //序号
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected int? mintPdfLineNum;    //pdf行号
protected string mstrPdfX;    //PdfX
protected string mstrPdfY;    //PdfY
protected string mstrMemo;    //备注
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrPaperId;    //论文Id
protected string mstrShareId;    //分享Id
protected string mstrPdfPageNumIn;    //PdfPageNumIn
protected int? mintPdfPageTop;    //pdf页面顶部位置
protected string mstrselectSpanRange;    //选择Span范围
protected string mstrPdfDivLet;    //PdfDivLet
protected string mstrPdfDivTop;    //PdfDivTop
protected string mstrPdfZoom;    //PdfZoom
protected string mstrTagsTypeId;    //标注类型ID

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_TagsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TagsId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strTagsId">关键字:标注Id</param>
public clsgs_TagsEN(string strTagsId)
 {
strTagsId = strTagsId.Replace("'", "''");
if (strTagsId.Length > 10)
{
throw new Exception("在表:gs_Tags中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTagsId)  ==  true)
{
throw new Exception("在表:gs_Tags中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTagsId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTagsId = strTagsId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TagsId");
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
if (strAttributeName  ==  congs_Tags.TagsId)
{
return mstrTagsId;
}
else if (strAttributeName  ==  congs_Tags.TagsContent)
{
return mstrTagsContent;
}
else if (strAttributeName  ==  congs_Tags.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  congs_Tags.PdfPageNum)
{
return mintPdfPageNum;
}
else if (strAttributeName  ==  congs_Tags.VoteCount)
{
return mintVoteCount;
}
else if (strAttributeName  ==  congs_Tags.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  congs_Tags.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  congs_Tags.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  congs_Tags.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  congs_Tags.PdfLineNum)
{
return mintPdfLineNum;
}
else if (strAttributeName  ==  congs_Tags.PdfX)
{
return mstrPdfX;
}
else if (strAttributeName  ==  congs_Tags.PdfY)
{
return mstrPdfY;
}
else if (strAttributeName  ==  congs_Tags.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  congs_Tags.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  congs_Tags.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  congs_Tags.ShareId)
{
return mstrShareId;
}
else if (strAttributeName  ==  congs_Tags.PdfPageNumIn)
{
return mstrPdfPageNumIn;
}
else if (strAttributeName  ==  congs_Tags.PdfPageTop)
{
return mintPdfPageTop;
}
else if (strAttributeName  ==  congs_Tags.selectSpanRange)
{
return mstrselectSpanRange;
}
else if (strAttributeName  ==  congs_Tags.PdfDivLet)
{
return mstrPdfDivLet;
}
else if (strAttributeName  ==  congs_Tags.PdfDivTop)
{
return mstrPdfDivTop;
}
else if (strAttributeName  ==  congs_Tags.PdfZoom)
{
return mstrPdfZoom;
}
else if (strAttributeName  ==  congs_Tags.TagsTypeId)
{
return mstrTagsTypeId;
}
return null;
}
set
{
if (strAttributeName  ==  congs_Tags.TagsId)
{
mstrTagsId = value.ToString();
 AddUpdatedFld(congs_Tags.TagsId);
}
else if (strAttributeName  ==  congs_Tags.TagsContent)
{
mstrTagsContent = value.ToString();
 AddUpdatedFld(congs_Tags.TagsContent);
}
else if (strAttributeName  ==  congs_Tags.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(congs_Tags.PdfContent);
}
else if (strAttributeName  ==  congs_Tags.PdfPageNum)
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_Tags.PdfPageNum);
}
else if (strAttributeName  ==  congs_Tags.VoteCount)
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_Tags.VoteCount);
}
else if (strAttributeName  ==  congs_Tags.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(congs_Tags.UserId);
}
else if (strAttributeName  ==  congs_Tags.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_Tags.OrderNum);
}
else if (strAttributeName  ==  congs_Tags.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_Tags.UpdUser);
}
else if (strAttributeName  ==  congs_Tags.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_Tags.UpdDate);
}
else if (strAttributeName  ==  congs_Tags.PdfLineNum)
{
mintPdfLineNum = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_Tags.PdfLineNum);
}
else if (strAttributeName  ==  congs_Tags.PdfX)
{
mstrPdfX = value.ToString();
 AddUpdatedFld(congs_Tags.PdfX);
}
else if (strAttributeName  ==  congs_Tags.PdfY)
{
mstrPdfY = value.ToString();
 AddUpdatedFld(congs_Tags.PdfY);
}
else if (strAttributeName  ==  congs_Tags.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_Tags.Memo);
}
else if (strAttributeName  ==  congs_Tags.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(congs_Tags.IdCurrEduCls);
}
else if (strAttributeName  ==  congs_Tags.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(congs_Tags.PaperId);
}
else if (strAttributeName  ==  congs_Tags.ShareId)
{
mstrShareId = value.ToString();
 AddUpdatedFld(congs_Tags.ShareId);
}
else if (strAttributeName  ==  congs_Tags.PdfPageNumIn)
{
mstrPdfPageNumIn = value.ToString();
 AddUpdatedFld(congs_Tags.PdfPageNumIn);
}
else if (strAttributeName  ==  congs_Tags.PdfPageTop)
{
mintPdfPageTop = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_Tags.PdfPageTop);
}
else if (strAttributeName  ==  congs_Tags.selectSpanRange)
{
mstrselectSpanRange = value.ToString();
 AddUpdatedFld(congs_Tags.selectSpanRange);
}
else if (strAttributeName  ==  congs_Tags.PdfDivLet)
{
mstrPdfDivLet = value.ToString();
 AddUpdatedFld(congs_Tags.PdfDivLet);
}
else if (strAttributeName  ==  congs_Tags.PdfDivTop)
{
mstrPdfDivTop = value.ToString();
 AddUpdatedFld(congs_Tags.PdfDivTop);
}
else if (strAttributeName  ==  congs_Tags.PdfZoom)
{
mstrPdfZoom = value.ToString();
 AddUpdatedFld(congs_Tags.PdfZoom);
}
else if (strAttributeName  ==  congs_Tags.TagsTypeId)
{
mstrTagsTypeId = value.ToString();
 AddUpdatedFld(congs_Tags.TagsTypeId);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_Tags.TagsId  ==  AttributeName[intIndex])
{
return mstrTagsId;
}
else if (congs_Tags.TagsContent  ==  AttributeName[intIndex])
{
return mstrTagsContent;
}
else if (congs_Tags.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (congs_Tags.PdfPageNum  ==  AttributeName[intIndex])
{
return mintPdfPageNum;
}
else if (congs_Tags.VoteCount  ==  AttributeName[intIndex])
{
return mintVoteCount;
}
else if (congs_Tags.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (congs_Tags.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (congs_Tags.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (congs_Tags.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (congs_Tags.PdfLineNum  ==  AttributeName[intIndex])
{
return mintPdfLineNum;
}
else if (congs_Tags.PdfX  ==  AttributeName[intIndex])
{
return mstrPdfX;
}
else if (congs_Tags.PdfY  ==  AttributeName[intIndex])
{
return mstrPdfY;
}
else if (congs_Tags.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (congs_Tags.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (congs_Tags.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (congs_Tags.ShareId  ==  AttributeName[intIndex])
{
return mstrShareId;
}
else if (congs_Tags.PdfPageNumIn  ==  AttributeName[intIndex])
{
return mstrPdfPageNumIn;
}
else if (congs_Tags.PdfPageTop  ==  AttributeName[intIndex])
{
return mintPdfPageTop;
}
else if (congs_Tags.selectSpanRange  ==  AttributeName[intIndex])
{
return mstrselectSpanRange;
}
else if (congs_Tags.PdfDivLet  ==  AttributeName[intIndex])
{
return mstrPdfDivLet;
}
else if (congs_Tags.PdfDivTop  ==  AttributeName[intIndex])
{
return mstrPdfDivTop;
}
else if (congs_Tags.PdfZoom  ==  AttributeName[intIndex])
{
return mstrPdfZoom;
}
else if (congs_Tags.TagsTypeId  ==  AttributeName[intIndex])
{
return mstrTagsTypeId;
}
return null;
}
set
{
if (congs_Tags.TagsId  ==  AttributeName[intIndex])
{
mstrTagsId = value.ToString();
 AddUpdatedFld(congs_Tags.TagsId);
}
else if (congs_Tags.TagsContent  ==  AttributeName[intIndex])
{
mstrTagsContent = value.ToString();
 AddUpdatedFld(congs_Tags.TagsContent);
}
else if (congs_Tags.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(congs_Tags.PdfContent);
}
else if (congs_Tags.PdfPageNum  ==  AttributeName[intIndex])
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_Tags.PdfPageNum);
}
else if (congs_Tags.VoteCount  ==  AttributeName[intIndex])
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_Tags.VoteCount);
}
else if (congs_Tags.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(congs_Tags.UserId);
}
else if (congs_Tags.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_Tags.OrderNum);
}
else if (congs_Tags.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_Tags.UpdUser);
}
else if (congs_Tags.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_Tags.UpdDate);
}
else if (congs_Tags.PdfLineNum  ==  AttributeName[intIndex])
{
mintPdfLineNum = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_Tags.PdfLineNum);
}
else if (congs_Tags.PdfX  ==  AttributeName[intIndex])
{
mstrPdfX = value.ToString();
 AddUpdatedFld(congs_Tags.PdfX);
}
else if (congs_Tags.PdfY  ==  AttributeName[intIndex])
{
mstrPdfY = value.ToString();
 AddUpdatedFld(congs_Tags.PdfY);
}
else if (congs_Tags.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_Tags.Memo);
}
else if (congs_Tags.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(congs_Tags.IdCurrEduCls);
}
else if (congs_Tags.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(congs_Tags.PaperId);
}
else if (congs_Tags.ShareId  ==  AttributeName[intIndex])
{
mstrShareId = value.ToString();
 AddUpdatedFld(congs_Tags.ShareId);
}
else if (congs_Tags.PdfPageNumIn  ==  AttributeName[intIndex])
{
mstrPdfPageNumIn = value.ToString();
 AddUpdatedFld(congs_Tags.PdfPageNumIn);
}
else if (congs_Tags.PdfPageTop  ==  AttributeName[intIndex])
{
mintPdfPageTop = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_Tags.PdfPageTop);
}
else if (congs_Tags.selectSpanRange  ==  AttributeName[intIndex])
{
mstrselectSpanRange = value.ToString();
 AddUpdatedFld(congs_Tags.selectSpanRange);
}
else if (congs_Tags.PdfDivLet  ==  AttributeName[intIndex])
{
mstrPdfDivLet = value.ToString();
 AddUpdatedFld(congs_Tags.PdfDivLet);
}
else if (congs_Tags.PdfDivTop  ==  AttributeName[intIndex])
{
mstrPdfDivTop = value.ToString();
 AddUpdatedFld(congs_Tags.PdfDivTop);
}
else if (congs_Tags.PdfZoom  ==  AttributeName[intIndex])
{
mstrPdfZoom = value.ToString();
 AddUpdatedFld(congs_Tags.PdfZoom);
}
else if (congs_Tags.TagsTypeId  ==  AttributeName[intIndex])
{
mstrTagsTypeId = value.ToString();
 AddUpdatedFld(congs_Tags.TagsTypeId);
}
}
}

/// <summary>
/// 标注Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TagsId
{
get
{
return mstrTagsId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTagsId = value;
}
else
{
 mstrTagsId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_Tags.TagsId);
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
 AddUpdatedFld(congs_Tags.TagsContent);
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
 AddUpdatedFld(congs_Tags.PdfContent);
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
 AddUpdatedFld(congs_Tags.PdfPageNum);
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
 AddUpdatedFld(congs_Tags.VoteCount);
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_Tags.UserId);
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
 AddUpdatedFld(congs_Tags.OrderNum);
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
 AddUpdatedFld(congs_Tags.UpdUser);
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
 AddUpdatedFld(congs_Tags.UpdDate);
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
 AddUpdatedFld(congs_Tags.PdfLineNum);
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
 AddUpdatedFld(congs_Tags.PdfX);
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
 AddUpdatedFld(congs_Tags.PdfY);
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
 AddUpdatedFld(congs_Tags.Memo);
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
 AddUpdatedFld(congs_Tags.IdCurrEduCls);
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
 AddUpdatedFld(congs_Tags.PaperId);
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
 AddUpdatedFld(congs_Tags.ShareId);
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
 AddUpdatedFld(congs_Tags.PdfPageNumIn);
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
 AddUpdatedFld(congs_Tags.PdfPageTop);
}
}
/// <summary>
/// 选择Span范围(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string selectSpanRange
{
get
{
return mstrselectSpanRange;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrselectSpanRange = value;
}
else
{
 mstrselectSpanRange = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_Tags.selectSpanRange);
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
 AddUpdatedFld(congs_Tags.PdfDivLet);
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
 AddUpdatedFld(congs_Tags.PdfDivTop);
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
 AddUpdatedFld(congs_Tags.PdfZoom);
}
}
/// <summary>
/// 标注类型ID(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TagsTypeId
{
get
{
return mstrTagsTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTagsTypeId = value;
}
else
{
 mstrTagsTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_Tags.TagsTypeId);
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
  return mstrTagsId;
 }
 }
}
 /// <summary>
 /// 标注(gs_Tags)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_Tags
{
public const string _CurrTabName = "gs_Tags"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TagsId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TagsId", "TagsContent", "PdfContent", "PdfPageNum", "VoteCount", "UserId", "OrderNum", "UpdUser", "UpdDate", "PdfLineNum", "PdfX", "PdfY", "Memo", "IdCurrEduCls", "PaperId", "ShareId", "PdfPageNumIn", "PdfPageTop", "selectSpanRange", "PdfDivLet", "PdfDivTop", "PdfZoom", "TagsTypeId"};
//以下是属性变量


 /// <summary>
 /// 常量:"TagsId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TagsId = "TagsId";    //标注Id

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
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

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
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

 /// <summary>
 /// 常量:"ShareId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ShareId = "ShareId";    //分享Id

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
 /// 常量:"selectSpanRange"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string selectSpanRange = "selectSpanRange";    //选择Span范围

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
 /// 常量:"TagsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TagsTypeId = "TagsTypeId";    //标注类型ID
}

}