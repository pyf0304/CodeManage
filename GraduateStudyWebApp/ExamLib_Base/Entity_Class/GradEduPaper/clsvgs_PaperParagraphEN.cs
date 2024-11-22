
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PaperParagraphEN
 表名:vgs_PaperParagraph(01120747)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:52:43
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
 /// 表vgs_PaperParagraph的关键字(ParagraphId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ParagraphId_vgs_PaperParagraph
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strParagraphId">表关键字</param>
public K_ParagraphId_vgs_PaperParagraph(string strParagraphId)
{
if (IsValid(strParagraphId)) Value = strParagraphId;
else
{
Value = null;
}
}
private static bool IsValid(string strParagraphId)
{
if (string.IsNullOrEmpty(strParagraphId) == true) return false;
if (strParagraphId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ParagraphId_vgs_PaperParagraph]类型的对象</returns>
public static implicit operator K_ParagraphId_vgs_PaperParagraph(string value)
{
return new K_ParagraphId_vgs_PaperParagraph(value);
}
}
 /// <summary>
 /// 论文段落视图(vgs_PaperParagraph)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvgs_PaperParagraphEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vgs_PaperParagraph"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ParagraphId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 17;
public static string[] AttributeName = new string[] {"ParagraphId", "ParagraphStateName", "ParagraphTypeName", "PaperId", "SectionId", "ParagraphStateId", "ParagraphTypeId", "ParagraphContent", "VoteCount", "CommentCount", "VersionCount", "CreateDate", "CreateUser", "UpdDate", "UpdUser", "Memo", "OrderNum"};

protected string mstrParagraphId;    //段落Id
protected string mstrParagraphStateName;    //段落状态
protected string mstrParagraphTypeName;    //段落类型
protected string mstrPaperId;    //论文Id
protected string mstrSectionId;    //节Id
protected string mstrParagraphStateId;    //段落状态Id
protected string mstrParagraphTypeId;    //段落类型Id
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
 public clsvgs_PaperParagraphEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ParagraphId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strParagraphId">关键字:段落Id</param>
public clsvgs_PaperParagraphEN(string strParagraphId)
 {
strParagraphId = strParagraphId.Replace("'", "''");
if (strParagraphId.Length > 10)
{
throw new Exception("在表:vgs_PaperParagraph中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strParagraphId)  ==  true)
{
throw new Exception("在表:vgs_PaperParagraph中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strParagraphId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrParagraphId = strParagraphId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ParagraphId");
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
if (strAttributeName  ==  convgs_PaperParagraph.ParagraphId)
{
return mstrParagraphId;
}
else if (strAttributeName  ==  convgs_PaperParagraph.ParagraphStateName)
{
return mstrParagraphStateName;
}
else if (strAttributeName  ==  convgs_PaperParagraph.ParagraphTypeName)
{
return mstrParagraphTypeName;
}
else if (strAttributeName  ==  convgs_PaperParagraph.PaperId)
{
return mstrPaperId;
}
else if (strAttributeName  ==  convgs_PaperParagraph.SectionId)
{
return mstrSectionId;
}
else if (strAttributeName  ==  convgs_PaperParagraph.ParagraphStateId)
{
return mstrParagraphStateId;
}
else if (strAttributeName  ==  convgs_PaperParagraph.ParagraphTypeId)
{
return mstrParagraphTypeId;
}
else if (strAttributeName  ==  convgs_PaperParagraph.ParagraphContent)
{
return mstrParagraphContent;
}
else if (strAttributeName  ==  convgs_PaperParagraph.VoteCount)
{
return mintVoteCount;
}
else if (strAttributeName  ==  convgs_PaperParagraph.CommentCount)
{
return mintCommentCount;
}
else if (strAttributeName  ==  convgs_PaperParagraph.VersionCount)
{
return mintVersionCount;
}
else if (strAttributeName  ==  convgs_PaperParagraph.CreateDate)
{
return mstrCreateDate;
}
else if (strAttributeName  ==  convgs_PaperParagraph.CreateUser)
{
return mstrCreateUser;
}
else if (strAttributeName  ==  convgs_PaperParagraph.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convgs_PaperParagraph.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convgs_PaperParagraph.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convgs_PaperParagraph.OrderNum)
{
return mintOrderNum;
}
return null;
}
set
{
if (strAttributeName  ==  convgs_PaperParagraph.ParagraphId)
{
mstrParagraphId = value.ToString();
 AddUpdatedFld(convgs_PaperParagraph.ParagraphId);
}
else if (strAttributeName  ==  convgs_PaperParagraph.ParagraphStateName)
{
mstrParagraphStateName = value.ToString();
 AddUpdatedFld(convgs_PaperParagraph.ParagraphStateName);
}
else if (strAttributeName  ==  convgs_PaperParagraph.ParagraphTypeName)
{
mstrParagraphTypeName = value.ToString();
 AddUpdatedFld(convgs_PaperParagraph.ParagraphTypeName);
}
else if (strAttributeName  ==  convgs_PaperParagraph.PaperId)
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convgs_PaperParagraph.PaperId);
}
else if (strAttributeName  ==  convgs_PaperParagraph.SectionId)
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convgs_PaperParagraph.SectionId);
}
else if (strAttributeName  ==  convgs_PaperParagraph.ParagraphStateId)
{
mstrParagraphStateId = value.ToString();
 AddUpdatedFld(convgs_PaperParagraph.ParagraphStateId);
}
else if (strAttributeName  ==  convgs_PaperParagraph.ParagraphTypeId)
{
mstrParagraphTypeId = value.ToString();
 AddUpdatedFld(convgs_PaperParagraph.ParagraphTypeId);
}
else if (strAttributeName  ==  convgs_PaperParagraph.ParagraphContent)
{
mstrParagraphContent = value.ToString();
 AddUpdatedFld(convgs_PaperParagraph.ParagraphContent);
}
else if (strAttributeName  ==  convgs_PaperParagraph.VoteCount)
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PaperParagraph.VoteCount);
}
else if (strAttributeName  ==  convgs_PaperParagraph.CommentCount)
{
mintCommentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PaperParagraph.CommentCount);
}
else if (strAttributeName  ==  convgs_PaperParagraph.VersionCount)
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PaperParagraph.VersionCount);
}
else if (strAttributeName  ==  convgs_PaperParagraph.CreateDate)
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convgs_PaperParagraph.CreateDate);
}
else if (strAttributeName  ==  convgs_PaperParagraph.CreateUser)
{
mstrCreateUser = value.ToString();
 AddUpdatedFld(convgs_PaperParagraph.CreateUser);
}
else if (strAttributeName  ==  convgs_PaperParagraph.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convgs_PaperParagraph.UpdDate);
}
else if (strAttributeName  ==  convgs_PaperParagraph.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convgs_PaperParagraph.UpdUser);
}
else if (strAttributeName  ==  convgs_PaperParagraph.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convgs_PaperParagraph.Memo);
}
else if (strAttributeName  ==  convgs_PaperParagraph.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PaperParagraph.OrderNum);
}
}
}
public object this[int intIndex]
{
get
{
if (convgs_PaperParagraph.ParagraphId  ==  AttributeName[intIndex])
{
return mstrParagraphId;
}
else if (convgs_PaperParagraph.ParagraphStateName  ==  AttributeName[intIndex])
{
return mstrParagraphStateName;
}
else if (convgs_PaperParagraph.ParagraphTypeName  ==  AttributeName[intIndex])
{
return mstrParagraphTypeName;
}
else if (convgs_PaperParagraph.PaperId  ==  AttributeName[intIndex])
{
return mstrPaperId;
}
else if (convgs_PaperParagraph.SectionId  ==  AttributeName[intIndex])
{
return mstrSectionId;
}
else if (convgs_PaperParagraph.ParagraphStateId  ==  AttributeName[intIndex])
{
return mstrParagraphStateId;
}
else if (convgs_PaperParagraph.ParagraphTypeId  ==  AttributeName[intIndex])
{
return mstrParagraphTypeId;
}
else if (convgs_PaperParagraph.ParagraphContent  ==  AttributeName[intIndex])
{
return mstrParagraphContent;
}
else if (convgs_PaperParagraph.VoteCount  ==  AttributeName[intIndex])
{
return mintVoteCount;
}
else if (convgs_PaperParagraph.CommentCount  ==  AttributeName[intIndex])
{
return mintCommentCount;
}
else if (convgs_PaperParagraph.VersionCount  ==  AttributeName[intIndex])
{
return mintVersionCount;
}
else if (convgs_PaperParagraph.CreateDate  ==  AttributeName[intIndex])
{
return mstrCreateDate;
}
else if (convgs_PaperParagraph.CreateUser  ==  AttributeName[intIndex])
{
return mstrCreateUser;
}
else if (convgs_PaperParagraph.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convgs_PaperParagraph.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convgs_PaperParagraph.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convgs_PaperParagraph.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
return null;
}
set
{
if (convgs_PaperParagraph.ParagraphId  ==  AttributeName[intIndex])
{
mstrParagraphId = value.ToString();
 AddUpdatedFld(convgs_PaperParagraph.ParagraphId);
}
else if (convgs_PaperParagraph.ParagraphStateName  ==  AttributeName[intIndex])
{
mstrParagraphStateName = value.ToString();
 AddUpdatedFld(convgs_PaperParagraph.ParagraphStateName);
}
else if (convgs_PaperParagraph.ParagraphTypeName  ==  AttributeName[intIndex])
{
mstrParagraphTypeName = value.ToString();
 AddUpdatedFld(convgs_PaperParagraph.ParagraphTypeName);
}
else if (convgs_PaperParagraph.PaperId  ==  AttributeName[intIndex])
{
mstrPaperId = value.ToString();
 AddUpdatedFld(convgs_PaperParagraph.PaperId);
}
else if (convgs_PaperParagraph.SectionId  ==  AttributeName[intIndex])
{
mstrSectionId = value.ToString();
 AddUpdatedFld(convgs_PaperParagraph.SectionId);
}
else if (convgs_PaperParagraph.ParagraphStateId  ==  AttributeName[intIndex])
{
mstrParagraphStateId = value.ToString();
 AddUpdatedFld(convgs_PaperParagraph.ParagraphStateId);
}
else if (convgs_PaperParagraph.ParagraphTypeId  ==  AttributeName[intIndex])
{
mstrParagraphTypeId = value.ToString();
 AddUpdatedFld(convgs_PaperParagraph.ParagraphTypeId);
}
else if (convgs_PaperParagraph.ParagraphContent  ==  AttributeName[intIndex])
{
mstrParagraphContent = value.ToString();
 AddUpdatedFld(convgs_PaperParagraph.ParagraphContent);
}
else if (convgs_PaperParagraph.VoteCount  ==  AttributeName[intIndex])
{
mintVoteCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PaperParagraph.VoteCount);
}
else if (convgs_PaperParagraph.CommentCount  ==  AttributeName[intIndex])
{
mintCommentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PaperParagraph.CommentCount);
}
else if (convgs_PaperParagraph.VersionCount  ==  AttributeName[intIndex])
{
mintVersionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PaperParagraph.VersionCount);
}
else if (convgs_PaperParagraph.CreateDate  ==  AttributeName[intIndex])
{
mstrCreateDate = value.ToString();
 AddUpdatedFld(convgs_PaperParagraph.CreateDate);
}
else if (convgs_PaperParagraph.CreateUser  ==  AttributeName[intIndex])
{
mstrCreateUser = value.ToString();
 AddUpdatedFld(convgs_PaperParagraph.CreateUser);
}
else if (convgs_PaperParagraph.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convgs_PaperParagraph.UpdDate);
}
else if (convgs_PaperParagraph.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convgs_PaperParagraph.UpdUser);
}
else if (convgs_PaperParagraph.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convgs_PaperParagraph.Memo);
}
else if (convgs_PaperParagraph.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convgs_PaperParagraph.OrderNum);
}
}
}

/// <summary>
/// 段落Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParagraphId
{
get
{
return mstrParagraphId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParagraphId = value;
}
else
{
 mstrParagraphId = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PaperParagraph.ParagraphId);
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
 AddUpdatedFld(convgs_PaperParagraph.ParagraphStateName);
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
 AddUpdatedFld(convgs_PaperParagraph.ParagraphTypeName);
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
 AddUpdatedFld(convgs_PaperParagraph.PaperId);
}
}
/// <summary>
/// 节Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SectionId
{
get
{
return mstrSectionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSectionId = value;
}
else
{
 mstrSectionId = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PaperParagraph.SectionId);
}
}
/// <summary>
/// 段落状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParagraphStateId
{
get
{
return mstrParagraphStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParagraphStateId = value;
}
else
{
 mstrParagraphStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PaperParagraph.ParagraphStateId);
}
}
/// <summary>
/// 段落类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParagraphTypeId
{
get
{
return mstrParagraphTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParagraphTypeId = value;
}
else
{
 mstrParagraphTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convgs_PaperParagraph.ParagraphTypeId);
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
 AddUpdatedFld(convgs_PaperParagraph.ParagraphContent);
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
 AddUpdatedFld(convgs_PaperParagraph.VoteCount);
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
 AddUpdatedFld(convgs_PaperParagraph.CommentCount);
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
 AddUpdatedFld(convgs_PaperParagraph.VersionCount);
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
 AddUpdatedFld(convgs_PaperParagraph.CreateDate);
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
 AddUpdatedFld(convgs_PaperParagraph.CreateUser);
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
 AddUpdatedFld(convgs_PaperParagraph.UpdDate);
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
 AddUpdatedFld(convgs_PaperParagraph.UpdUser);
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
 AddUpdatedFld(convgs_PaperParagraph.Memo);
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
 AddUpdatedFld(convgs_PaperParagraph.OrderNum);
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
  return mstrParagraphId;
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
  return mstrParagraphTypeName;
 }
 }
}
 /// <summary>
 /// 论文段落视图(vgs_PaperParagraph)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convgs_PaperParagraph
{
public const string _CurrTabName = "vgs_PaperParagraph"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ParagraphId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ParagraphId", "ParagraphStateName", "ParagraphTypeName", "PaperId", "SectionId", "ParagraphStateId", "ParagraphTypeId", "ParagraphContent", "VoteCount", "CommentCount", "VersionCount", "CreateDate", "CreateUser", "UpdDate", "UpdUser", "Memo", "OrderNum"};
//以下是属性变量


 /// <summary>
 /// 常量:"ParagraphId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParagraphId = "ParagraphId";    //段落Id

 /// <summary>
 /// 常量:"ParagraphStateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParagraphStateName = "ParagraphStateName";    //段落状态

 /// <summary>
 /// 常量:"ParagraphTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParagraphTypeName = "ParagraphTypeName";    //段落类型

 /// <summary>
 /// 常量:"PaperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperId = "PaperId";    //论文Id

 /// <summary>
 /// 常量:"SectionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SectionId = "SectionId";    //节Id

 /// <summary>
 /// 常量:"ParagraphStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParagraphStateId = "ParagraphStateId";    //段落状态Id

 /// <summary>
 /// 常量:"ParagraphTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParagraphTypeId = "ParagraphTypeId";    //段落类型Id

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