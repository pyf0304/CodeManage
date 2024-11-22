
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_GroupQuestionRelaEN
 表名:vzx_GroupQuestionRela(01120736)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:50:46
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学小组课文(zxGroupText)
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
 /// 表vzx_GroupQuestionRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vzx_GroupQuestionRela
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
public K_mId_vzx_GroupQuestionRela(long lngmId)
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
 /// <returns>返回:[K_mId_vzx_GroupQuestionRela]类型的对象</returns>
public static implicit operator K_mId_vzx_GroupQuestionRela(long value)
{
return new K_mId_vzx_GroupQuestionRela(value);
}
}
 /// <summary>
 /// 小组问题关系视图(vzx_GroupQuestionRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvzx_GroupQuestionRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vzx_GroupQuestionRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 23;
public static string[] AttributeName = new string[] {"GroupTextName", "mId", "GroupTextId", "zxQuestionsId", "UpdDate", "UpdUser", "Memo", "QuestionsContent", "PdfPageNum", "PdfContent", "IsPublic", "IsEnd", "IsDelete", "VoteCount", "AnswerCount", "OrderNum", "PdfPageTop", "PdfPageNumIn", "PdfDivTop", "PdfDivLet", "PdfZoom", "QuestionType", "TextId"};

protected string mstrGroupTextName;    //小组名称
protected long mlngmId;    //mId
protected string mstrGroupTextId;    //小组Id
protected string mstrzxQuestionsId;    //提问Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrQuestionsContent;    //提问内容
protected int? mintPdfPageNum;    //Pdf页码
protected string mstrPdfContent;    //Pdf内容
protected bool mbolIsPublic;    //是否公开
protected bool mbolIsEnd;    //是否结束
protected bool mbolIsDelete;    //是否删除
protected int? mintVoteCount;    //点赞计数
protected int? mintAnswerCount;    //回答计数
protected int? mintOrderNum;    //序号
protected int? mintPdfPageTop;    //pdf页面顶部位置
protected string mstrPdfPageNumIn;    //PdfPageNumIn
protected string mstrPdfDivTop;    //PdfDivTop
protected string mstrPdfDivLet;    //PdfDivLet
protected string mstrPdfZoom;    //PdfZoom
protected string mstrQuestionType;    //个人01小组02
protected string mstrTextId;    //课件Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvzx_GroupQuestionRelaEN()
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
public clsvzx_GroupQuestionRelaEN(long lngmId)
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
if (strAttributeName  ==  convzx_GroupQuestionRela.GroupTextName)
{
return mstrGroupTextName;
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.GroupTextId)
{
return mstrGroupTextId;
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.zxQuestionsId)
{
return mstrzxQuestionsId;
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.QuestionsContent)
{
return mstrQuestionsContent;
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.PdfPageNum)
{
return mintPdfPageNum;
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.PdfContent)
{
return mstrPdfContent;
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.IsPublic)
{
return mbolIsPublic;
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.IsEnd)
{
return mbolIsEnd;
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.IsDelete)
{
return mbolIsDelete;
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.VoteCount)
{
return mintVoteCount;
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.AnswerCount)
{
return mintAnswerCount;
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.PdfPageTop)
{
return mintPdfPageTop;
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.PdfPageNumIn)
{
return mstrPdfPageNumIn;
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.PdfDivTop)
{
return mstrPdfDivTop;
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.PdfDivLet)
{
return mstrPdfDivLet;
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.PdfZoom)
{
return mstrPdfZoom;
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.QuestionType)
{
return mstrQuestionType;
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.TextId)
{
return mstrTextId;
}
return null;
}
set
{
if (strAttributeName  ==  convzx_GroupQuestionRela.GroupTextName)
{
mstrGroupTextName = value.ToString();
 AddUpdatedFld(convzx_GroupQuestionRela.GroupTextName);
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_GroupQuestionRela.mId);
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.GroupTextId)
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(convzx_GroupQuestionRela.GroupTextId);
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.zxQuestionsId)
{
mstrzxQuestionsId = value.ToString();
 AddUpdatedFld(convzx_GroupQuestionRela.zxQuestionsId);
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_GroupQuestionRela.UpdDate);
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_GroupQuestionRela.UpdUser);
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_GroupQuestionRela.Memo);
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.QuestionsContent)
{
mstrQuestionsContent = value.ToString();
 AddUpdatedFld(convzx_GroupQuestionRela.QuestionsContent);
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.PdfPageNum)
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_GroupQuestionRela.PdfPageNum);
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.PdfContent)
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convzx_GroupQuestionRela.PdfContent);
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.IsPublic)
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_GroupQuestionRela.IsPublic);
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.IsEnd)
{
mbolIsEnd = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_GroupQuestionRela.IsEnd);
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.IsDelete)
{
mbolIsDelete = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_GroupQuestionRela.IsDelete);
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.VoteCount)
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_GroupQuestionRela.VoteCount);
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.AnswerCount)
{
mintAnswerCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_GroupQuestionRela.AnswerCount);
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_GroupQuestionRela.OrderNum);
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.PdfPageTop)
{
mintPdfPageTop = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_GroupQuestionRela.PdfPageTop);
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.PdfPageNumIn)
{
mstrPdfPageNumIn = value.ToString();
 AddUpdatedFld(convzx_GroupQuestionRela.PdfPageNumIn);
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.PdfDivTop)
{
mstrPdfDivTop = value.ToString();
 AddUpdatedFld(convzx_GroupQuestionRela.PdfDivTop);
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.PdfDivLet)
{
mstrPdfDivLet = value.ToString();
 AddUpdatedFld(convzx_GroupQuestionRela.PdfDivLet);
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.PdfZoom)
{
mstrPdfZoom = value.ToString();
 AddUpdatedFld(convzx_GroupQuestionRela.PdfZoom);
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.QuestionType)
{
mstrQuestionType = value.ToString();
 AddUpdatedFld(convzx_GroupQuestionRela.QuestionType);
}
else if (strAttributeName  ==  convzx_GroupQuestionRela.TextId)
{
mstrTextId = value.ToString();
 AddUpdatedFld(convzx_GroupQuestionRela.TextId);
}
}
}
public object this[int intIndex]
{
get
{
if (convzx_GroupQuestionRela.GroupTextName  ==  AttributeName[intIndex])
{
return mstrGroupTextName;
}
else if (convzx_GroupQuestionRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convzx_GroupQuestionRela.GroupTextId  ==  AttributeName[intIndex])
{
return mstrGroupTextId;
}
else if (convzx_GroupQuestionRela.zxQuestionsId  ==  AttributeName[intIndex])
{
return mstrzxQuestionsId;
}
else if (convzx_GroupQuestionRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convzx_GroupQuestionRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convzx_GroupQuestionRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convzx_GroupQuestionRela.QuestionsContent  ==  AttributeName[intIndex])
{
return mstrQuestionsContent;
}
else if (convzx_GroupQuestionRela.PdfPageNum  ==  AttributeName[intIndex])
{
return mintPdfPageNum;
}
else if (convzx_GroupQuestionRela.PdfContent  ==  AttributeName[intIndex])
{
return mstrPdfContent;
}
else if (convzx_GroupQuestionRela.IsPublic  ==  AttributeName[intIndex])
{
return mbolIsPublic;
}
else if (convzx_GroupQuestionRela.IsEnd  ==  AttributeName[intIndex])
{
return mbolIsEnd;
}
else if (convzx_GroupQuestionRela.IsDelete  ==  AttributeName[intIndex])
{
return mbolIsDelete;
}
else if (convzx_GroupQuestionRela.VoteCount  ==  AttributeName[intIndex])
{
return mintVoteCount;
}
else if (convzx_GroupQuestionRela.AnswerCount  ==  AttributeName[intIndex])
{
return mintAnswerCount;
}
else if (convzx_GroupQuestionRela.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convzx_GroupQuestionRela.PdfPageTop  ==  AttributeName[intIndex])
{
return mintPdfPageTop;
}
else if (convzx_GroupQuestionRela.PdfPageNumIn  ==  AttributeName[intIndex])
{
return mstrPdfPageNumIn;
}
else if (convzx_GroupQuestionRela.PdfDivTop  ==  AttributeName[intIndex])
{
return mstrPdfDivTop;
}
else if (convzx_GroupQuestionRela.PdfDivLet  ==  AttributeName[intIndex])
{
return mstrPdfDivLet;
}
else if (convzx_GroupQuestionRela.PdfZoom  ==  AttributeName[intIndex])
{
return mstrPdfZoom;
}
else if (convzx_GroupQuestionRela.QuestionType  ==  AttributeName[intIndex])
{
return mstrQuestionType;
}
else if (convzx_GroupQuestionRela.TextId  ==  AttributeName[intIndex])
{
return mstrTextId;
}
return null;
}
set
{
if (convzx_GroupQuestionRela.GroupTextName  ==  AttributeName[intIndex])
{
mstrGroupTextName = value.ToString();
 AddUpdatedFld(convzx_GroupQuestionRela.GroupTextName);
}
else if (convzx_GroupQuestionRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_GroupQuestionRela.mId);
}
else if (convzx_GroupQuestionRela.GroupTextId  ==  AttributeName[intIndex])
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(convzx_GroupQuestionRela.GroupTextId);
}
else if (convzx_GroupQuestionRela.zxQuestionsId  ==  AttributeName[intIndex])
{
mstrzxQuestionsId = value.ToString();
 AddUpdatedFld(convzx_GroupQuestionRela.zxQuestionsId);
}
else if (convzx_GroupQuestionRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_GroupQuestionRela.UpdDate);
}
else if (convzx_GroupQuestionRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_GroupQuestionRela.UpdUser);
}
else if (convzx_GroupQuestionRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_GroupQuestionRela.Memo);
}
else if (convzx_GroupQuestionRela.QuestionsContent  ==  AttributeName[intIndex])
{
mstrQuestionsContent = value.ToString();
 AddUpdatedFld(convzx_GroupQuestionRela.QuestionsContent);
}
else if (convzx_GroupQuestionRela.PdfPageNum  ==  AttributeName[intIndex])
{
mintPdfPageNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_GroupQuestionRela.PdfPageNum);
}
else if (convzx_GroupQuestionRela.PdfContent  ==  AttributeName[intIndex])
{
mstrPdfContent = value.ToString();
 AddUpdatedFld(convzx_GroupQuestionRela.PdfContent);
}
else if (convzx_GroupQuestionRela.IsPublic  ==  AttributeName[intIndex])
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_GroupQuestionRela.IsPublic);
}
else if (convzx_GroupQuestionRela.IsEnd  ==  AttributeName[intIndex])
{
mbolIsEnd = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_GroupQuestionRela.IsEnd);
}
else if (convzx_GroupQuestionRela.IsDelete  ==  AttributeName[intIndex])
{
mbolIsDelete = TransNullToBool(value.ToString());
 AddUpdatedFld(convzx_GroupQuestionRela.IsDelete);
}
else if (convzx_GroupQuestionRela.VoteCount  ==  AttributeName[intIndex])
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_GroupQuestionRela.VoteCount);
}
else if (convzx_GroupQuestionRela.AnswerCount  ==  AttributeName[intIndex])
{
mintAnswerCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_GroupQuestionRela.AnswerCount);
}
else if (convzx_GroupQuestionRela.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_GroupQuestionRela.OrderNum);
}
else if (convzx_GroupQuestionRela.PdfPageTop  ==  AttributeName[intIndex])
{
mintPdfPageTop = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_GroupQuestionRela.PdfPageTop);
}
else if (convzx_GroupQuestionRela.PdfPageNumIn  ==  AttributeName[intIndex])
{
mstrPdfPageNumIn = value.ToString();
 AddUpdatedFld(convzx_GroupQuestionRela.PdfPageNumIn);
}
else if (convzx_GroupQuestionRela.PdfDivTop  ==  AttributeName[intIndex])
{
mstrPdfDivTop = value.ToString();
 AddUpdatedFld(convzx_GroupQuestionRela.PdfDivTop);
}
else if (convzx_GroupQuestionRela.PdfDivLet  ==  AttributeName[intIndex])
{
mstrPdfDivLet = value.ToString();
 AddUpdatedFld(convzx_GroupQuestionRela.PdfDivLet);
}
else if (convzx_GroupQuestionRela.PdfZoom  ==  AttributeName[intIndex])
{
mstrPdfZoom = value.ToString();
 AddUpdatedFld(convzx_GroupQuestionRela.PdfZoom);
}
else if (convzx_GroupQuestionRela.QuestionType  ==  AttributeName[intIndex])
{
mstrQuestionType = value.ToString();
 AddUpdatedFld(convzx_GroupQuestionRela.QuestionType);
}
else if (convzx_GroupQuestionRela.TextId  ==  AttributeName[intIndex])
{
mstrTextId = value.ToString();
 AddUpdatedFld(convzx_GroupQuestionRela.TextId);
}
}
}

/// <summary>
/// 小组名称(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupTextName
{
get
{
return mstrGroupTextName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupTextName = value;
}
else
{
 mstrGroupTextName = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_GroupQuestionRela.GroupTextName);
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
 AddUpdatedFld(convzx_GroupQuestionRela.mId);
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
 AddUpdatedFld(convzx_GroupQuestionRela.GroupTextId);
}
}
/// <summary>
/// 提问Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxQuestionsId
{
get
{
return mstrzxQuestionsId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxQuestionsId = value;
}
else
{
 mstrzxQuestionsId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_GroupQuestionRela.zxQuestionsId);
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
 AddUpdatedFld(convzx_GroupQuestionRela.UpdDate);
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
 AddUpdatedFld(convzx_GroupQuestionRela.UpdUser);
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
 AddUpdatedFld(convzx_GroupQuestionRela.Memo);
}
}
/// <summary>
/// 提问内容(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionsContent
{
get
{
return mstrQuestionsContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionsContent = value;
}
else
{
 mstrQuestionsContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_GroupQuestionRela.QuestionsContent);
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
 AddUpdatedFld(convzx_GroupQuestionRela.PdfPageNum);
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
 AddUpdatedFld(convzx_GroupQuestionRela.PdfContent);
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
 AddUpdatedFld(convzx_GroupQuestionRela.IsPublic);
}
}
/// <summary>
/// 是否结束(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsEnd
{
get
{
return mbolIsEnd;
}
set
{
 mbolIsEnd = value;
//记录修改过的字段
 AddUpdatedFld(convzx_GroupQuestionRela.IsEnd);
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
 AddUpdatedFld(convzx_GroupQuestionRela.IsDelete);
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
 AddUpdatedFld(convzx_GroupQuestionRela.VoteCount);
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
 AddUpdatedFld(convzx_GroupQuestionRela.AnswerCount);
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
 AddUpdatedFld(convzx_GroupQuestionRela.OrderNum);
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
 AddUpdatedFld(convzx_GroupQuestionRela.PdfPageTop);
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
 AddUpdatedFld(convzx_GroupQuestionRela.PdfPageNumIn);
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
 AddUpdatedFld(convzx_GroupQuestionRela.PdfDivTop);
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
 AddUpdatedFld(convzx_GroupQuestionRela.PdfDivLet);
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
 AddUpdatedFld(convzx_GroupQuestionRela.PdfZoom);
}
}
/// <summary>
/// 个人01小组02(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QuestionType
{
get
{
return mstrQuestionType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQuestionType = value;
}
else
{
 mstrQuestionType = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_GroupQuestionRela.QuestionType);
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
 AddUpdatedFld(convzx_GroupQuestionRela.TextId);
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
 /// 小组问题关系视图(vzx_GroupQuestionRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convzx_GroupQuestionRela
{
public const string _CurrTabName = "vzx_GroupQuestionRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"GroupTextName", "mId", "GroupTextId", "zxQuestionsId", "UpdDate", "UpdUser", "Memo", "QuestionsContent", "PdfPageNum", "PdfContent", "IsPublic", "IsEnd", "IsDelete", "VoteCount", "AnswerCount", "OrderNum", "PdfPageTop", "PdfPageNumIn", "PdfDivTop", "PdfDivLet", "PdfZoom", "QuestionType", "TextId"};
//以下是属性变量


 /// <summary>
 /// 常量:"GroupTextName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupTextName = "GroupTextName";    //小组名称

 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"GroupTextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupTextId = "GroupTextId";    //小组Id

 /// <summary>
 /// 常量:"zxQuestionsId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxQuestionsId = "zxQuestionsId";    //提问Id

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
 /// 常量:"QuestionsContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionsContent = "QuestionsContent";    //提问内容

 /// <summary>
 /// 常量:"PdfPageNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfPageNum = "PdfPageNum";    //Pdf页码

 /// <summary>
 /// 常量:"PdfContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfContent = "PdfContent";    //Pdf内容

 /// <summary>
 /// 常量:"IsPublic"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsPublic = "IsPublic";    //是否公开

 /// <summary>
 /// 常量:"IsEnd"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsEnd = "IsEnd";    //是否结束

 /// <summary>
 /// 常量:"IsDelete"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDelete = "IsDelete";    //是否删除

 /// <summary>
 /// 常量:"VoteCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VoteCount = "VoteCount";    //点赞计数

 /// <summary>
 /// 常量:"AnswerCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AnswerCount = "AnswerCount";    //回答计数

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"PdfPageTop"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfPageTop = "PdfPageTop";    //pdf页面顶部位置

 /// <summary>
 /// 常量:"PdfPageNumIn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfPageNumIn = "PdfPageNumIn";    //PdfPageNumIn

 /// <summary>
 /// 常量:"PdfDivTop"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfDivTop = "PdfDivTop";    //PdfDivTop

 /// <summary>
 /// 常量:"PdfDivLet"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfDivLet = "PdfDivLet";    //PdfDivLet

 /// <summary>
 /// 常量:"PdfZoom"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PdfZoom = "PdfZoom";    //PdfZoom

 /// <summary>
 /// 常量:"QuestionType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QuestionType = "QuestionType";    //个人01小组02

 /// <summary>
 /// 常量:"TextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextId = "TextId";    //课件Id
}

}