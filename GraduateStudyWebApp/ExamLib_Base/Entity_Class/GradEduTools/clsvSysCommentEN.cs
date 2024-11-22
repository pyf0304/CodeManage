
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSysCommentEN
 表名:vSysComment(01120624)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:03:32
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
 /// 表vSysComment的关键字(CommentId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CommentId_vSysComment
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCommentId">表关键字</param>
public K_CommentId_vSysComment(string strCommentId)
{
if (IsValid(strCommentId)) Value = strCommentId;
else
{
Value = null;
}
}
private static bool IsValid(string strCommentId)
{
if (string.IsNullOrEmpty(strCommentId) == true) return false;
if (strCommentId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CommentId_vSysComment]类型的对象</returns>
public static implicit operator K_CommentId_vSysComment(string value)
{
return new K_CommentId_vSysComment(value);
}
}
 /// <summary>
 /// v系统评论表(vSysComment)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvSysCommentEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vSysComment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CommentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 17;
public static string[] AttributeName = new string[] {"CommentId", "Comment", "Score", "CommentTypeId", "ScoreType", "ParentId", "TableKey", "UpdUser", "UpdDate", "Memo", "CommentTypeName", "CommentTable", "CommentTableId", "OkCount", "PubParentId", "IdCurrEduCls", "UserId"};

protected string mstrCommentId;    //评论Id
protected string mstrComment;    //评论
protected float? mfltScore;    //评分
protected string mstrCommentTypeId;    //评论类型Id
protected string mstrScoreType;    //评分类型
protected string mstrParentId;    //父Id
protected string mstrTableKey;    //表主键
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrCommentTypeName;    //评论类型名
protected string mstrCommentTable;    //评论表
protected string mstrCommentTableId;    //评论表Id
protected int? mintOkCount;    //点赞统计
protected string mstrPubParentId;    //公共父Id
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrUserId;    //用户ID

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvSysCommentEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CommentId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strCommentId">关键字:评论Id</param>
public clsvSysCommentEN(string strCommentId)
 {
strCommentId = strCommentId.Replace("'", "''");
if (strCommentId.Length > 10)
{
throw new Exception("在表:vSysComment中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCommentId)  ==  true)
{
throw new Exception("在表:vSysComment中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCommentId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCommentId = strCommentId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CommentId");
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
if (strAttributeName  ==  convSysComment.CommentId)
{
return mstrCommentId;
}
else if (strAttributeName  ==  convSysComment.Comment)
{
return mstrComment;
}
else if (strAttributeName  ==  convSysComment.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convSysComment.CommentTypeId)
{
return mstrCommentTypeId;
}
else if (strAttributeName  ==  convSysComment.ScoreType)
{
return mstrScoreType;
}
else if (strAttributeName  ==  convSysComment.ParentId)
{
return mstrParentId;
}
else if (strAttributeName  ==  convSysComment.TableKey)
{
return mstrTableKey;
}
else if (strAttributeName  ==  convSysComment.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convSysComment.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convSysComment.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convSysComment.CommentTypeName)
{
return mstrCommentTypeName;
}
else if (strAttributeName  ==  convSysComment.CommentTable)
{
return mstrCommentTable;
}
else if (strAttributeName  ==  convSysComment.CommentTableId)
{
return mstrCommentTableId;
}
else if (strAttributeName  ==  convSysComment.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  convSysComment.PubParentId)
{
return mstrPubParentId;
}
else if (strAttributeName  ==  convSysComment.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convSysComment.UserId)
{
return mstrUserId;
}
return null;
}
set
{
if (strAttributeName  ==  convSysComment.CommentId)
{
mstrCommentId = value.ToString();
 AddUpdatedFld(convSysComment.CommentId);
}
else if (strAttributeName  ==  convSysComment.Comment)
{
mstrComment = value.ToString();
 AddUpdatedFld(convSysComment.Comment);
}
else if (strAttributeName  ==  convSysComment.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSysComment.Score);
}
else if (strAttributeName  ==  convSysComment.CommentTypeId)
{
mstrCommentTypeId = value.ToString();
 AddUpdatedFld(convSysComment.CommentTypeId);
}
else if (strAttributeName  ==  convSysComment.ScoreType)
{
mstrScoreType = value.ToString();
 AddUpdatedFld(convSysComment.ScoreType);
}
else if (strAttributeName  ==  convSysComment.ParentId)
{
mstrParentId = value.ToString();
 AddUpdatedFld(convSysComment.ParentId);
}
else if (strAttributeName  ==  convSysComment.TableKey)
{
mstrTableKey = value.ToString();
 AddUpdatedFld(convSysComment.TableKey);
}
else if (strAttributeName  ==  convSysComment.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convSysComment.UpdUser);
}
else if (strAttributeName  ==  convSysComment.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSysComment.UpdDate);
}
else if (strAttributeName  ==  convSysComment.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSysComment.Memo);
}
else if (strAttributeName  ==  convSysComment.CommentTypeName)
{
mstrCommentTypeName = value.ToString();
 AddUpdatedFld(convSysComment.CommentTypeName);
}
else if (strAttributeName  ==  convSysComment.CommentTable)
{
mstrCommentTable = value.ToString();
 AddUpdatedFld(convSysComment.CommentTable);
}
else if (strAttributeName  ==  convSysComment.CommentTableId)
{
mstrCommentTableId = value.ToString();
 AddUpdatedFld(convSysComment.CommentTableId);
}
else if (strAttributeName  ==  convSysComment.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysComment.OkCount);
}
else if (strAttributeName  ==  convSysComment.PubParentId)
{
mstrPubParentId = value.ToString();
 AddUpdatedFld(convSysComment.PubParentId);
}
else if (strAttributeName  ==  convSysComment.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convSysComment.IdCurrEduCls);
}
else if (strAttributeName  ==  convSysComment.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convSysComment.UserId);
}
}
}
public object this[int intIndex]
{
get
{
if (convSysComment.CommentId  ==  AttributeName[intIndex])
{
return mstrCommentId;
}
else if (convSysComment.Comment  ==  AttributeName[intIndex])
{
return mstrComment;
}
else if (convSysComment.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convSysComment.CommentTypeId  ==  AttributeName[intIndex])
{
return mstrCommentTypeId;
}
else if (convSysComment.ScoreType  ==  AttributeName[intIndex])
{
return mstrScoreType;
}
else if (convSysComment.ParentId  ==  AttributeName[intIndex])
{
return mstrParentId;
}
else if (convSysComment.TableKey  ==  AttributeName[intIndex])
{
return mstrTableKey;
}
else if (convSysComment.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convSysComment.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convSysComment.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convSysComment.CommentTypeName  ==  AttributeName[intIndex])
{
return mstrCommentTypeName;
}
else if (convSysComment.CommentTable  ==  AttributeName[intIndex])
{
return mstrCommentTable;
}
else if (convSysComment.CommentTableId  ==  AttributeName[intIndex])
{
return mstrCommentTableId;
}
else if (convSysComment.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (convSysComment.PubParentId  ==  AttributeName[intIndex])
{
return mstrPubParentId;
}
else if (convSysComment.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convSysComment.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
return null;
}
set
{
if (convSysComment.CommentId  ==  AttributeName[intIndex])
{
mstrCommentId = value.ToString();
 AddUpdatedFld(convSysComment.CommentId);
}
else if (convSysComment.Comment  ==  AttributeName[intIndex])
{
mstrComment = value.ToString();
 AddUpdatedFld(convSysComment.Comment);
}
else if (convSysComment.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSysComment.Score);
}
else if (convSysComment.CommentTypeId  ==  AttributeName[intIndex])
{
mstrCommentTypeId = value.ToString();
 AddUpdatedFld(convSysComment.CommentTypeId);
}
else if (convSysComment.ScoreType  ==  AttributeName[intIndex])
{
mstrScoreType = value.ToString();
 AddUpdatedFld(convSysComment.ScoreType);
}
else if (convSysComment.ParentId  ==  AttributeName[intIndex])
{
mstrParentId = value.ToString();
 AddUpdatedFld(convSysComment.ParentId);
}
else if (convSysComment.TableKey  ==  AttributeName[intIndex])
{
mstrTableKey = value.ToString();
 AddUpdatedFld(convSysComment.TableKey);
}
else if (convSysComment.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convSysComment.UpdUser);
}
else if (convSysComment.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSysComment.UpdDate);
}
else if (convSysComment.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSysComment.Memo);
}
else if (convSysComment.CommentTypeName  ==  AttributeName[intIndex])
{
mstrCommentTypeName = value.ToString();
 AddUpdatedFld(convSysComment.CommentTypeName);
}
else if (convSysComment.CommentTable  ==  AttributeName[intIndex])
{
mstrCommentTable = value.ToString();
 AddUpdatedFld(convSysComment.CommentTable);
}
else if (convSysComment.CommentTableId  ==  AttributeName[intIndex])
{
mstrCommentTableId = value.ToString();
 AddUpdatedFld(convSysComment.CommentTableId);
}
else if (convSysComment.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysComment.OkCount);
}
else if (convSysComment.PubParentId  ==  AttributeName[intIndex])
{
mstrPubParentId = value.ToString();
 AddUpdatedFld(convSysComment.PubParentId);
}
else if (convSysComment.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convSysComment.IdCurrEduCls);
}
else if (convSysComment.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convSysComment.UserId);
}
}
}

/// <summary>
/// 评论Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CommentId
{
get
{
return mstrCommentId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCommentId = value;
}
else
{
 mstrCommentId = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysComment.CommentId);
}
}
/// <summary>
/// 评论(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Comment
{
get
{
return mstrComment;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrComment = value;
}
else
{
 mstrComment = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysComment.Comment);
}
}
/// <summary>
/// 评分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? Score
{
get
{
return mfltScore;
}
set
{
 mfltScore = value;
//记录修改过的字段
 AddUpdatedFld(convSysComment.Score);
}
}
/// <summary>
/// 评论类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CommentTypeId
{
get
{
return mstrCommentTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCommentTypeId = value;
}
else
{
 mstrCommentTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysComment.CommentTypeId);
}
}
/// <summary>
/// 评分类型(说明:;字段类型:char;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ScoreType
{
get
{
return mstrScoreType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrScoreType = value;
}
else
{
 mstrScoreType = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysComment.ScoreType);
}
}
/// <summary>
/// 父Id(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParentId
{
get
{
return mstrParentId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParentId = value;
}
else
{
 mstrParentId = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysComment.ParentId);
}
}
/// <summary>
/// 表主键(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TableKey
{
get
{
return mstrTableKey;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTableKey = value;
}
else
{
 mstrTableKey = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysComment.TableKey);
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
 AddUpdatedFld(convSysComment.UpdUser);
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
 AddUpdatedFld(convSysComment.UpdDate);
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
 AddUpdatedFld(convSysComment.Memo);
}
}
/// <summary>
/// 评论类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CommentTypeName
{
get
{
return mstrCommentTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCommentTypeName = value;
}
else
{
 mstrCommentTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysComment.CommentTypeName);
}
}
/// <summary>
/// 评论表(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CommentTable
{
get
{
return mstrCommentTable;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCommentTable = value;
}
else
{
 mstrCommentTable = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysComment.CommentTable);
}
}
/// <summary>
/// 评论表Id(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CommentTableId
{
get
{
return mstrCommentTableId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCommentTableId = value;
}
else
{
 mstrCommentTableId = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysComment.CommentTableId);
}
}
/// <summary>
/// 点赞统计(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OkCount
{
get
{
return mintOkCount;
}
set
{
 mintOkCount = value;
//记录修改过的字段
 AddUpdatedFld(convSysComment.OkCount);
}
}
/// <summary>
/// 公共父Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PubParentId
{
get
{
return mstrPubParentId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPubParentId = value;
}
else
{
 mstrPubParentId = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysComment.PubParentId);
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
 AddUpdatedFld(convSysComment.IdCurrEduCls);
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
 AddUpdatedFld(convSysComment.UserId);
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
  return mstrCommentId;
 }
 }
}
 /// <summary>
 /// v系统评论表(vSysComment)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convSysComment
{
public const string _CurrTabName = "vSysComment"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CommentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"CommentId", "Comment", "Score", "CommentTypeId", "ScoreType", "ParentId", "TableKey", "UpdUser", "UpdDate", "Memo", "CommentTypeName", "CommentTable", "CommentTableId", "OkCount", "PubParentId", "IdCurrEduCls", "UserId"};
//以下是属性变量


 /// <summary>
 /// 常量:"CommentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CommentId = "CommentId";    //评论Id

 /// <summary>
 /// 常量:"Comment"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Comment = "Comment";    //评论

 /// <summary>
 /// 常量:"Score"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Score = "Score";    //评分

 /// <summary>
 /// 常量:"CommentTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CommentTypeId = "CommentTypeId";    //评论类型Id

 /// <summary>
 /// 常量:"ScoreType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ScoreType = "ScoreType";    //评分类型

 /// <summary>
 /// 常量:"ParentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentId = "ParentId";    //父Id

 /// <summary>
 /// 常量:"TableKey"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TableKey = "TableKey";    //表主键

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"CommentTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CommentTypeName = "CommentTypeName";    //评论类型名

 /// <summary>
 /// 常量:"CommentTable"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CommentTable = "CommentTable";    //评论表

 /// <summary>
 /// 常量:"CommentTableId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CommentTableId = "CommentTableId";    //评论表Id

 /// <summary>
 /// 常量:"OkCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OkCount = "OkCount";    //点赞统计

 /// <summary>
 /// 常量:"PubParentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubParentId = "PubParentId";    //公共父Id

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID
}

}