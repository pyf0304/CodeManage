
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_PaperParagraphEN
 表名:vzx_PaperParagraph(01120766)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:50:51
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
 /// 表vzx_PaperParagraph的关键字(zxParagraphId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxParagraphId_vzx_PaperParagraph
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxParagraphId">表关键字</param>
public K_zxParagraphId_vzx_PaperParagraph(string strzxParagraphId)
{
if (IsValid(strzxParagraphId)) Value = strzxParagraphId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxParagraphId)
{
if (string.IsNullOrEmpty(strzxParagraphId) == true) return false;
if (strzxParagraphId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxParagraphId_vzx_PaperParagraph]类型的对象</returns>
public static implicit operator K_zxParagraphId_vzx_PaperParagraph(string value)
{
return new K_zxParagraphId_vzx_PaperParagraph(value);
}
}
 /// <summary>
 /// vzx_PaperParagraph(vzx_PaperParagraph)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvzx_PaperParagraphEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vzx_PaperParagraph"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxParagraphId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 17;
public static string[] AttributeName = new string[] {"ParagraphTypeName", "ParagraphStateName", "zxParagraphId", "TextId", "zxSectionId", "zxParagraphStateId", "zxParagraphTypeId", "ParagraphContent", "VoteCount", "CommentCount", "VersionCount", "CreateDate", "CreateUser", "UpdDate", "UpdUser", "Memo", "OrderNum"};

protected string mstrParagraphTypeName;    //段落类型
protected string mstrParagraphStateName;    //段落状态
protected string mstrzxParagraphId;    //段落Id
protected string mstrTextId;    //课件Id
protected string mstrzxSectionId;    //节Id
protected string mstrzxParagraphStateId;    //段落状态Id
protected string mstrzxParagraphTypeId;    //段落类型Id
protected string mstrParagraphContent;    //段落内容
protected int? mintVoteCount;    //点赞计数
protected int? mintCommentCount;    //评论数
protected int? mintVersionCount;    //版本统计
protected string mstrCreateDate;    //建立日期
protected string mstrCreateUser;    //建立用户
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected int? mintOrderNum;    //序号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvzx_PaperParagraphEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxParagraphId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxParagraphId">关键字:段落Id</param>
public clsvzx_PaperParagraphEN(string strzxParagraphId)
 {
strzxParagraphId = strzxParagraphId.Replace("'", "''");
if (strzxParagraphId.Length > 10)
{
throw new Exception("在表:vzx_PaperParagraph中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxParagraphId)  ==  true)
{
throw new Exception("在表:vzx_PaperParagraph中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxParagraphId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxParagraphId = strzxParagraphId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxParagraphId");
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
if (strAttributeName  ==  convzx_PaperParagraph.ParagraphTypeName)
{
return mstrParagraphTypeName;
}
else if (strAttributeName  ==  convzx_PaperParagraph.ParagraphStateName)
{
return mstrParagraphStateName;
}
else if (strAttributeName  ==  convzx_PaperParagraph.zxParagraphId)
{
return mstrzxParagraphId;
}
else if (strAttributeName  ==  convzx_PaperParagraph.TextId)
{
return mstrTextId;
}
else if (strAttributeName  ==  convzx_PaperParagraph.zxSectionId)
{
return mstrzxSectionId;
}
else if (strAttributeName  ==  convzx_PaperParagraph.zxParagraphStateId)
{
return mstrzxParagraphStateId;
}
else if (strAttributeName  ==  convzx_PaperParagraph.zxParagraphTypeId)
{
return mstrzxParagraphTypeId;
}
else if (strAttributeName  ==  convzx_PaperParagraph.ParagraphContent)
{
return mstrParagraphContent;
}
else if (strAttributeName  ==  convzx_PaperParagraph.VoteCount)
{
return mintVoteCount;
}
else if (strAttributeName  ==  convzx_PaperParagraph.CommentCount)
{
return mintCommentCount;
}
else if (strAttributeName  ==  convzx_PaperParagraph.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  convzx_PaperParagraph.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convzx_PaperParagraph.CreateUser)
{
return mstrCreateUser;
}
else if (strAttributeName  ==  convzx_PaperParagraph.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convzx_PaperParagraph.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convzx_PaperParagraph.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convzx_PaperParagraph.OrderNum)
{
return mintOrderNum;
}
return null;
}
set
{
if (strAttributeName  ==  convzx_PaperParagraph.ParagraphTypeName)
{
mstrParagraphTypeName = value.ToString();
 AddUpdatedFld(convzx_PaperParagraph.ParagraphTypeName);
}
else if (strAttributeName  ==  convzx_PaperParagraph.ParagraphStateName)
{
mstrParagraphStateName = value.ToString();
 AddUpdatedFld(convzx_PaperParagraph.ParagraphStateName);
}
else if (strAttributeName  ==  convzx_PaperParagraph.zxParagraphId)
{
mstrzxParagraphId = value.ToString();
 AddUpdatedFld(convzx_PaperParagraph.zxParagraphId);
}
else if (strAttributeName  ==  convzx_PaperParagraph.TextId)
{
mstrTextId = value.ToString();
 AddUpdatedFld(convzx_PaperParagraph.TextId);
}
else if (strAttributeName  ==  convzx_PaperParagraph.zxSectionId)
{
mstrzxSectionId = value.ToString();
 AddUpdatedFld(convzx_PaperParagraph.zxSectionId);
}
else if (strAttributeName  ==  convzx_PaperParagraph.zxParagraphStateId)
{
mstrzxParagraphStateId = value.ToString();
 AddUpdatedFld(convzx_PaperParagraph.zxParagraphStateId);
}
else if (strAttributeName  ==  convzx_PaperParagraph.zxParagraphTypeId)
{
mstrzxParagraphTypeId = value.ToString();
 AddUpdatedFld(convzx_PaperParagraph.zxParagraphTypeId);
}
else if (strAttributeName  ==  convzx_PaperParagraph.ParagraphContent)
{
mstrParagraphContent = value.ToString();
 AddUpdatedFld(convzx_PaperParagraph.ParagraphContent);
}
else if (strAttributeName  ==  convzx_PaperParagraph.VoteCount)
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperParagraph.VoteCount);
}
else if (strAttributeName  ==  convzx_PaperParagraph.CommentCount)
{
mintCommentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperParagraph.CommentCount);
}
else if (strAttributeName  ==  convzx_PaperParagraph.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperParagraph.VersionCount);
}
else if (strAttributeName  ==  convzx_PaperParagraph.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convzx_PaperParagraph.CreateDate);
}
else if (strAttributeName  ==  convzx_PaperParagraph.CreateUser)
{
mstrCreateUser = value.ToString();
 AddUpdatedFld(convzx_PaperParagraph.CreateUser);
}
else if (strAttributeName  ==  convzx_PaperParagraph.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_PaperParagraph.UpdDate);
}
else if (strAttributeName  ==  convzx_PaperParagraph.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_PaperParagraph.UpdUser);
}
else if (strAttributeName  ==  convzx_PaperParagraph.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_PaperParagraph.Memo);
}
else if (strAttributeName  ==  convzx_PaperParagraph.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperParagraph.OrderNum);
}
}
}
public object this[int intIndex]
{
get
{
if (convzx_PaperParagraph.ParagraphTypeName  ==  AttributeName[intIndex])
{
return mstrParagraphTypeName;
}
else if (convzx_PaperParagraph.ParagraphStateName  ==  AttributeName[intIndex])
{
return mstrParagraphStateName;
}
else if (convzx_PaperParagraph.zxParagraphId  ==  AttributeName[intIndex])
{
return mstrzxParagraphId;
}
else if (convzx_PaperParagraph.TextId  ==  AttributeName[intIndex])
{
return mstrTextId;
}
else if (convzx_PaperParagraph.zxSectionId  ==  AttributeName[intIndex])
{
return mstrzxSectionId;
}
else if (convzx_PaperParagraph.zxParagraphStateId  ==  AttributeName[intIndex])
{
return mstrzxParagraphStateId;
}
else if (convzx_PaperParagraph.zxParagraphTypeId  ==  AttributeName[intIndex])
{
return mstrzxParagraphTypeId;
}
else if (convzx_PaperParagraph.ParagraphContent  ==  AttributeName[intIndex])
{
return mstrParagraphContent;
}
else if (convzx_PaperParagraph.VoteCount  ==  AttributeName[intIndex])
{
return mintVoteCount;
}
else if (convzx_PaperParagraph.CommentCount  ==  AttributeName[intIndex])
{
return mintCommentCount;
}
else if (convzx_PaperParagraph.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (convzx_PaperParagraph.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convzx_PaperParagraph.CreateUser  ==  AttributeName[intIndex])
{
return mstrCreateUser;
}
else if (convzx_PaperParagraph.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convzx_PaperParagraph.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convzx_PaperParagraph.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convzx_PaperParagraph.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
return null;
}
set
{
if (convzx_PaperParagraph.ParagraphTypeName  ==  AttributeName[intIndex])
{
mstrParagraphTypeName = value.ToString();
 AddUpdatedFld(convzx_PaperParagraph.ParagraphTypeName);
}
else if (convzx_PaperParagraph.ParagraphStateName  ==  AttributeName[intIndex])
{
mstrParagraphStateName = value.ToString();
 AddUpdatedFld(convzx_PaperParagraph.ParagraphStateName);
}
else if (convzx_PaperParagraph.zxParagraphId  ==  AttributeName[intIndex])
{
mstrzxParagraphId = value.ToString();
 AddUpdatedFld(convzx_PaperParagraph.zxParagraphId);
}
else if (convzx_PaperParagraph.TextId  ==  AttributeName[intIndex])
{
mstrTextId = value.ToString();
 AddUpdatedFld(convzx_PaperParagraph.TextId);
}
else if (convzx_PaperParagraph.zxSectionId  ==  AttributeName[intIndex])
{
mstrzxSectionId = value.ToString();
 AddUpdatedFld(convzx_PaperParagraph.zxSectionId);
}
else if (convzx_PaperParagraph.zxParagraphStateId  ==  AttributeName[intIndex])
{
mstrzxParagraphStateId = value.ToString();
 AddUpdatedFld(convzx_PaperParagraph.zxParagraphStateId);
}
else if (convzx_PaperParagraph.zxParagraphTypeId  ==  AttributeName[intIndex])
{
mstrzxParagraphTypeId = value.ToString();
 AddUpdatedFld(convzx_PaperParagraph.zxParagraphTypeId);
}
else if (convzx_PaperParagraph.ParagraphContent  ==  AttributeName[intIndex])
{
mstrParagraphContent = value.ToString();
 AddUpdatedFld(convzx_PaperParagraph.ParagraphContent);
}
else if (convzx_PaperParagraph.VoteCount  ==  AttributeName[intIndex])
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperParagraph.VoteCount);
}
else if (convzx_PaperParagraph.CommentCount  ==  AttributeName[intIndex])
{
mintCommentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperParagraph.CommentCount);
}
else if (convzx_PaperParagraph.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperParagraph.VersionCount);
}
else if (convzx_PaperParagraph.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convzx_PaperParagraph.CreateDate);
}
else if (convzx_PaperParagraph.CreateUser  ==  AttributeName[intIndex])
{
mstrCreateUser = value.ToString();
 AddUpdatedFld(convzx_PaperParagraph.CreateUser);
}
else if (convzx_PaperParagraph.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_PaperParagraph.UpdDate);
}
else if (convzx_PaperParagraph.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_PaperParagraph.UpdUser);
}
else if (convzx_PaperParagraph.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_PaperParagraph.Memo);
}
else if (convzx_PaperParagraph.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_PaperParagraph.OrderNum);
}
}
}

/// <summary>
/// 段落类型(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParagraphTypeName
{
get
{
return mstrParagraphTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParagraphTypeName = value;
}
else
{
 mstrParagraphTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_PaperParagraph.ParagraphTypeName);
}
}
/// <summary>
/// 段落状态(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParagraphStateName
{
get
{
return mstrParagraphStateName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParagraphStateName = value;
}
else
{
 mstrParagraphStateName = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_PaperParagraph.ParagraphStateName);
}
}
/// <summary>
/// 段落Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxParagraphId
{
get
{
return mstrzxParagraphId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxParagraphId = value;
}
else
{
 mstrzxParagraphId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_PaperParagraph.zxParagraphId);
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
 AddUpdatedFld(convzx_PaperParagraph.TextId);
}
}
/// <summary>
/// 节Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxSectionId
{
get
{
return mstrzxSectionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxSectionId = value;
}
else
{
 mstrzxSectionId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_PaperParagraph.zxSectionId);
}
}
/// <summary>
/// 段落状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxParagraphStateId
{
get
{
return mstrzxParagraphStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxParagraphStateId = value;
}
else
{
 mstrzxParagraphStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_PaperParagraph.zxParagraphStateId);
}
}
/// <summary>
/// 段落类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxParagraphTypeId
{
get
{
return mstrzxParagraphTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxParagraphTypeId = value;
}
else
{
 mstrzxParagraphTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_PaperParagraph.zxParagraphTypeId);
}
}
/// <summary>
/// 段落内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParagraphContent
{
get
{
return mstrParagraphContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParagraphContent = value;
}
else
{
 mstrParagraphContent = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_PaperParagraph.ParagraphContent);
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
 AddUpdatedFld(convzx_PaperParagraph.VoteCount);
}
}
/// <summary>
/// 评论数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? CommentCount
{
get
{
return mintCommentCount;
}
set
{
 mintCommentCount = value;
//记录修改过的字段
 AddUpdatedFld(convzx_PaperParagraph.CommentCount);
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
 AddUpdatedFld(convzx_PaperParagraph.VersionCount);
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
 AddUpdatedFld(convzx_PaperParagraph.CreateDate);
}
}
/// <summary>
/// 建立用户(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateUser
{
get
{
return mstrCreateUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateUser = value;
}
else
{
 mstrCreateUser = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_PaperParagraph.CreateUser);
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
 AddUpdatedFld(convzx_PaperParagraph.UpdDate);
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
 AddUpdatedFld(convzx_PaperParagraph.UpdUser);
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
 AddUpdatedFld(convzx_PaperParagraph.Memo);
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
 AddUpdatedFld(convzx_PaperParagraph.OrderNum);
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
  return mstrzxParagraphId;
 }
 }
}
 /// <summary>
 /// vzx_PaperParagraph(vzx_PaperParagraph)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convzx_PaperParagraph
{
public const string _CurrTabName = "vzx_PaperParagraph"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxParagraphId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ParagraphTypeName", "ParagraphStateName", "zxParagraphId", "TextId", "zxSectionId", "zxParagraphStateId", "zxParagraphTypeId", "ParagraphContent", "VoteCount", "CommentCount", "VersionCount", "CreateDate", "CreateUser", "UpdDate", "UpdUser", "Memo", "OrderNum"};
//以下是属性变量


 /// <summary>
 /// 常量:"ParagraphTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParagraphTypeName = "ParagraphTypeName";    //段落类型

 /// <summary>
 /// 常量:"ParagraphStateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParagraphStateName = "ParagraphStateName";    //段落状态

 /// <summary>
 /// 常量:"zxParagraphId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxParagraphId = "zxParagraphId";    //段落Id

 /// <summary>
 /// 常量:"TextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextId = "TextId";    //课件Id

 /// <summary>
 /// 常量:"zxSectionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxSectionId = "zxSectionId";    //节Id

 /// <summary>
 /// 常量:"zxParagraphStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxParagraphStateId = "zxParagraphStateId";    //段落状态Id

 /// <summary>
 /// 常量:"zxParagraphTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxParagraphTypeId = "zxParagraphTypeId";    //段落类型Id

 /// <summary>
 /// 常量:"ParagraphContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParagraphContent = "ParagraphContent";    //段落内容

 /// <summary>
 /// 常量:"VoteCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VoteCount = "VoteCount";    //点赞计数

 /// <summary>
 /// 常量:"CommentCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CommentCount = "CommentCount";    //评论数

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
 /// 常量:"CreateUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateUser = "CreateUser";    //建立用户

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
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号
}

}