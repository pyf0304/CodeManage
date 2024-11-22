
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSysCountEN
 表名:vSysCount(01120626)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:44
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
 /// 表vSysCount的关键字(CountId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_CountId_vSysCount
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strCountId">表关键字</param>
public K_CountId_vSysCount(string strCountId)
{
if (IsValid(strCountId)) Value = strCountId;
else
{
Value = null;
}
}
private static bool IsValid(string strCountId)
{
if (string.IsNullOrEmpty(strCountId) == true) return false;
if (strCountId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_CountId_vSysCount]类型的对象</returns>
public static implicit operator K_CountId_vSysCount(string value)
{
return new K_CountId_vSysCount(value);
}
}
 /// <summary>
 /// 数据统计视图(vSysCount)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvSysCountEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vSysCount"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "CountId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 19;
public static string[] AttributeName = new string[] {"CountId", "CountTypeId", "CommentTypeName", "CommentTable", "OkCount", "CommentTableId", "CollectionCount", "DownloadCount", "AttachmentCount", "CommentCount", "Score", "StuScore", "TeaScore", "TableKey", "ParentId", "UpdUser", "UpdDate", "Memo", "PaperRWCount"};

protected string mstrCountId;    //CountId
protected string mstrCountTypeId;    //CountTypeId
protected string mstrCommentTypeName;    //评论类型名
protected string mstrCommentTable;    //评论表
protected int? mintOkCount;    //点赞统计
protected string mstrCommentTableId;    //评论表Id
protected long? mlngCollectionCount;    //收藏数量
protected int? mintDownloadCount;    //下载数
protected int? mintAttachmentCount;    //附件计数
protected int? mintCommentCount;    //评论数
protected float? mfltScore;    //评分
protected float? mfltStuScore;    //学生平均分
protected float? mfltTeaScore;    //教师评分
protected string mstrTableKey;    //表主键
protected string mstrParentId;    //父Id
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected int? mintPaperRWCount;    //PaperRWCount

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvSysCountEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CountId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strCountId">关键字:CountId</param>
public clsvSysCountEN(string strCountId)
 {
strCountId = strCountId.Replace("'", "''");
if (strCountId.Length > 10)
{
throw new Exception("在表:vSysCount中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strCountId)  ==  true)
{
throw new Exception("在表:vSysCount中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCountId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrCountId = strCountId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("CountId");
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
if (strAttributeName  ==  convSysCount.CountId)
{
return mstrCountId;
}
else if (strAttributeName  ==  convSysCount.CountTypeId)
{
return mstrCountTypeId;
}
else if (strAttributeName  ==  convSysCount.CommentTypeName)
{
return mstrCommentTypeName;
}
else if (strAttributeName  ==  convSysCount.CommentTable)
{
return mstrCommentTable;
}
else if (strAttributeName  ==  convSysCount.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  convSysCount.CommentTableId)
{
return mstrCommentTableId;
}
else if (strAttributeName  ==  convSysCount.CollectionCount)
{
return mlngCollectionCount;
}
else if (strAttributeName  ==  convSysCount.DownloadCount)
{
return mintDownloadCount;
}
else if (strAttributeName  ==  convSysCount.AttachmentCount)
{
return mintAttachmentCount;
}
else if (strAttributeName  ==  convSysCount.CommentCount)
{
return mintCommentCount;
}
else if (strAttributeName  ==  convSysCount.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  convSysCount.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  convSysCount.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  convSysCount.TableKey)
{
return mstrTableKey;
}
else if (strAttributeName  ==  convSysCount.ParentId)
{
return mstrParentId;
}
else if (strAttributeName  ==  convSysCount.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convSysCount.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convSysCount.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convSysCount.PaperRWCount)
{
return mintPaperRWCount;
}
return null;
}
set
{
if (strAttributeName  ==  convSysCount.CountId)
{
mstrCountId = value.ToString();
 AddUpdatedFld(convSysCount.CountId);
}
else if (strAttributeName  ==  convSysCount.CountTypeId)
{
mstrCountTypeId = value.ToString();
 AddUpdatedFld(convSysCount.CountTypeId);
}
else if (strAttributeName  ==  convSysCount.CommentTypeName)
{
mstrCommentTypeName = value.ToString();
 AddUpdatedFld(convSysCount.CommentTypeName);
}
else if (strAttributeName  ==  convSysCount.CommentTable)
{
mstrCommentTable = value.ToString();
 AddUpdatedFld(convSysCount.CommentTable);
}
else if (strAttributeName  ==  convSysCount.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysCount.OkCount);
}
else if (strAttributeName  ==  convSysCount.CommentTableId)
{
mstrCommentTableId = value.ToString();
 AddUpdatedFld(convSysCount.CommentTableId);
}
else if (strAttributeName  ==  convSysCount.CollectionCount)
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysCount.CollectionCount);
}
else if (strAttributeName  ==  convSysCount.DownloadCount)
{
mintDownloadCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysCount.DownloadCount);
}
else if (strAttributeName  ==  convSysCount.AttachmentCount)
{
mintAttachmentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysCount.AttachmentCount);
}
else if (strAttributeName  ==  convSysCount.CommentCount)
{
mintCommentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysCount.CommentCount);
}
else if (strAttributeName  ==  convSysCount.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSysCount.Score);
}
else if (strAttributeName  ==  convSysCount.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSysCount.StuScore);
}
else if (strAttributeName  ==  convSysCount.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSysCount.TeaScore);
}
else if (strAttributeName  ==  convSysCount.TableKey)
{
mstrTableKey = value.ToString();
 AddUpdatedFld(convSysCount.TableKey);
}
else if (strAttributeName  ==  convSysCount.ParentId)
{
mstrParentId = value.ToString();
 AddUpdatedFld(convSysCount.ParentId);
}
else if (strAttributeName  ==  convSysCount.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convSysCount.UpdUser);
}
else if (strAttributeName  ==  convSysCount.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSysCount.UpdDate);
}
else if (strAttributeName  ==  convSysCount.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSysCount.Memo);
}
else if (strAttributeName  ==  convSysCount.PaperRWCount)
{
mintPaperRWCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysCount.PaperRWCount);
}
}
}
public object this[int intIndex]
{
get
{
if (convSysCount.CountId  ==  AttributeName[intIndex])
{
return mstrCountId;
}
else if (convSysCount.CountTypeId  ==  AttributeName[intIndex])
{
return mstrCountTypeId;
}
else if (convSysCount.CommentTypeName  ==  AttributeName[intIndex])
{
return mstrCommentTypeName;
}
else if (convSysCount.CommentTable  ==  AttributeName[intIndex])
{
return mstrCommentTable;
}
else if (convSysCount.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (convSysCount.CommentTableId  ==  AttributeName[intIndex])
{
return mstrCommentTableId;
}
else if (convSysCount.CollectionCount  ==  AttributeName[intIndex])
{
return mlngCollectionCount;
}
else if (convSysCount.DownloadCount  ==  AttributeName[intIndex])
{
return mintDownloadCount;
}
else if (convSysCount.AttachmentCount  ==  AttributeName[intIndex])
{
return mintAttachmentCount;
}
else if (convSysCount.CommentCount  ==  AttributeName[intIndex])
{
return mintCommentCount;
}
else if (convSysCount.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (convSysCount.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (convSysCount.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (convSysCount.TableKey  ==  AttributeName[intIndex])
{
return mstrTableKey;
}
else if (convSysCount.ParentId  ==  AttributeName[intIndex])
{
return mstrParentId;
}
else if (convSysCount.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convSysCount.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convSysCount.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convSysCount.PaperRWCount  ==  AttributeName[intIndex])
{
return mintPaperRWCount;
}
return null;
}
set
{
if (convSysCount.CountId  ==  AttributeName[intIndex])
{
mstrCountId = value.ToString();
 AddUpdatedFld(convSysCount.CountId);
}
else if (convSysCount.CountTypeId  ==  AttributeName[intIndex])
{
mstrCountTypeId = value.ToString();
 AddUpdatedFld(convSysCount.CountTypeId);
}
else if (convSysCount.CommentTypeName  ==  AttributeName[intIndex])
{
mstrCommentTypeName = value.ToString();
 AddUpdatedFld(convSysCount.CommentTypeName);
}
else if (convSysCount.CommentTable  ==  AttributeName[intIndex])
{
mstrCommentTable = value.ToString();
 AddUpdatedFld(convSysCount.CommentTable);
}
else if (convSysCount.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysCount.OkCount);
}
else if (convSysCount.CommentTableId  ==  AttributeName[intIndex])
{
mstrCommentTableId = value.ToString();
 AddUpdatedFld(convSysCount.CommentTableId);
}
else if (convSysCount.CollectionCount  ==  AttributeName[intIndex])
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysCount.CollectionCount);
}
else if (convSysCount.DownloadCount  ==  AttributeName[intIndex])
{
mintDownloadCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysCount.DownloadCount);
}
else if (convSysCount.AttachmentCount  ==  AttributeName[intIndex])
{
mintAttachmentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysCount.AttachmentCount);
}
else if (convSysCount.CommentCount  ==  AttributeName[intIndex])
{
mintCommentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysCount.CommentCount);
}
else if (convSysCount.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSysCount.Score);
}
else if (convSysCount.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSysCount.StuScore);
}
else if (convSysCount.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(convSysCount.TeaScore);
}
else if (convSysCount.TableKey  ==  AttributeName[intIndex])
{
mstrTableKey = value.ToString();
 AddUpdatedFld(convSysCount.TableKey);
}
else if (convSysCount.ParentId  ==  AttributeName[intIndex])
{
mstrParentId = value.ToString();
 AddUpdatedFld(convSysCount.ParentId);
}
else if (convSysCount.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convSysCount.UpdUser);
}
else if (convSysCount.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSysCount.UpdDate);
}
else if (convSysCount.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSysCount.Memo);
}
else if (convSysCount.PaperRWCount  ==  AttributeName[intIndex])
{
mintPaperRWCount = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysCount.PaperRWCount);
}
}
}

/// <summary>
/// CountId(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CountId
{
get
{
return mstrCountId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCountId = value;
}
else
{
 mstrCountId = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysCount.CountId);
}
}
/// <summary>
/// CountTypeId(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CountTypeId
{
get
{
return mstrCountTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCountTypeId = value;
}
else
{
 mstrCountTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysCount.CountTypeId);
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
 AddUpdatedFld(convSysCount.CommentTypeName);
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
 AddUpdatedFld(convSysCount.CommentTable);
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
 AddUpdatedFld(convSysCount.OkCount);
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
 AddUpdatedFld(convSysCount.CommentTableId);
}
}
/// <summary>
/// 收藏数量(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long? CollectionCount
{
get
{
return mlngCollectionCount;
}
set
{
 mlngCollectionCount = value;
//记录修改过的字段
 AddUpdatedFld(convSysCount.CollectionCount);
}
}
/// <summary>
/// 下载数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? DownloadCount
{
get
{
return mintDownloadCount;
}
set
{
 mintDownloadCount = value;
//记录修改过的字段
 AddUpdatedFld(convSysCount.DownloadCount);
}
}
/// <summary>
/// 附件计数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AttachmentCount
{
get
{
return mintAttachmentCount;
}
set
{
 mintAttachmentCount = value;
//记录修改过的字段
 AddUpdatedFld(convSysCount.AttachmentCount);
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
 AddUpdatedFld(convSysCount.CommentCount);
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
 AddUpdatedFld(convSysCount.Score);
}
}
/// <summary>
/// 学生平均分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? StuScore
{
get
{
return mfltStuScore;
}
set
{
 mfltStuScore = value;
//记录修改过的字段
 AddUpdatedFld(convSysCount.StuScore);
}
}
/// <summary>
/// 教师评分(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? TeaScore
{
get
{
return mfltTeaScore;
}
set
{
 mfltTeaScore = value;
//记录修改过的字段
 AddUpdatedFld(convSysCount.TeaScore);
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
 AddUpdatedFld(convSysCount.TableKey);
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
 AddUpdatedFld(convSysCount.ParentId);
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
 AddUpdatedFld(convSysCount.UpdUser);
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
 AddUpdatedFld(convSysCount.UpdDate);
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
 AddUpdatedFld(convSysCount.Memo);
}
}
/// <summary>
/// PaperRWCount(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? PaperRWCount
{
get
{
return mintPaperRWCount;
}
set
{
 mintPaperRWCount = value;
//记录修改过的字段
 AddUpdatedFld(convSysCount.PaperRWCount);
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
  return mstrCountId;
 }
 }
}
 /// <summary>
 /// 数据统计视图(vSysCount)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convSysCount
{
public const string _CurrTabName = "vSysCount"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "CountId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"CountId", "CountTypeId", "CommentTypeName", "CommentTable", "OkCount", "CommentTableId", "CollectionCount", "DownloadCount", "AttachmentCount", "CommentCount", "Score", "StuScore", "TeaScore", "TableKey", "ParentId", "UpdUser", "UpdDate", "Memo", "PaperRWCount"};
//以下是属性变量


 /// <summary>
 /// 常量:"CountId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CountId = "CountId";    //CountId

 /// <summary>
 /// 常量:"CountTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CountTypeId = "CountTypeId";    //CountTypeId

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
 /// 常量:"OkCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OkCount = "OkCount";    //点赞统计

 /// <summary>
 /// 常量:"CommentTableId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CommentTableId = "CommentTableId";    //评论表Id

 /// <summary>
 /// 常量:"CollectionCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollectionCount = "CollectionCount";    //收藏数量

 /// <summary>
 /// 常量:"DownloadCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DownloadCount = "DownloadCount";    //下载数

 /// <summary>
 /// 常量:"AttachmentCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AttachmentCount = "AttachmentCount";    //附件计数

 /// <summary>
 /// 常量:"CommentCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CommentCount = "CommentCount";    //评论数

 /// <summary>
 /// 常量:"Score"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Score = "Score";    //评分

 /// <summary>
 /// 常量:"StuScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuScore = "StuScore";    //学生平均分

 /// <summary>
 /// 常量:"TeaScore"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeaScore = "TeaScore";    //教师评分

 /// <summary>
 /// 常量:"TableKey"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TableKey = "TableKey";    //表主键

 /// <summary>
 /// 常量:"ParentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParentId = "ParentId";    //父Id

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
 /// 常量:"PaperRWCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperRWCount = "PaperRWCount";    //PaperRWCount
}

}