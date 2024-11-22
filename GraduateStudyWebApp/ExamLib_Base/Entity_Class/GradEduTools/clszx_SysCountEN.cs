
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_SysCountEN
 表名:zx_SysCount(01120797)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:53:23
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
 /// 表zx_SysCount的关键字(zxCountId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxCountId_zx_SysCount
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxCountId">表关键字</param>
public K_zxCountId_zx_SysCount(string strzxCountId)
{
if (IsValid(strzxCountId)) Value = strzxCountId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxCountId)
{
if (string.IsNullOrEmpty(strzxCountId) == true) return false;
if (strzxCountId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxCountId_zx_SysCount]类型的对象</returns>
public static implicit operator K_zxCountId_zx_SysCount(string value)
{
return new K_zxCountId_zx_SysCount(value);
}
}
 /// <summary>
 /// 中学统计数据(zx_SysCount)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_SysCountEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_SysCount"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxCountId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 16;
public static string[] AttributeName = new string[] {"zxCountId", "CountTypeId", "PaperRWCount", "OkCount", "CollectionCount", "DownloadCount", "AttachmentCount", "CommentCount", "Score", "StuScore", "TeaScore", "TableKey", "ParentId", "UpdUser", "UpdDate", "Memo"};

protected string mstrzxCountId;    //CountId
protected string mstrCountTypeId;    //CountTypeId
protected int? mintPaperRWCount;    //PaperRWCount
protected int? mintOkCount;    //点赞统计
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

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_SysCountEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxCountId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxCountId">关键字:CountId</param>
public clszx_SysCountEN(string strzxCountId)
 {
strzxCountId = strzxCountId.Replace("'", "''");
if (strzxCountId.Length > 10)
{
throw new Exception("在表:zx_SysCount中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxCountId)  ==  true)
{
throw new Exception("在表:zx_SysCount中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxCountId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxCountId = strzxCountId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxCountId");
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
if (strAttributeName  ==  conzx_SysCount.zxCountId)
{
return mstrzxCountId;
}
else if (strAttributeName  ==  conzx_SysCount.CountTypeId)
{
return mstrCountTypeId;
}
else if (strAttributeName  ==  conzx_SysCount.PaperRWCount)
{
return mintPaperRWCount;
}
else if (strAttributeName  ==  conzx_SysCount.OkCount)
{
return mintOkCount;
}
else if (strAttributeName  ==  conzx_SysCount.CollectionCount)
{
return mlngCollectionCount;
}
else if (strAttributeName  ==  conzx_SysCount.DownloadCount)
{
return mintDownloadCount;
}
else if (strAttributeName  ==  conzx_SysCount.AttachmentCount)
{
return mintAttachmentCount;
}
else if (strAttributeName  ==  conzx_SysCount.CommentCount)
{
return mintCommentCount;
}
else if (strAttributeName  ==  conzx_SysCount.Score)
{
return mfltScore;
}
else if (strAttributeName  ==  conzx_SysCount.StuScore)
{
return mfltStuScore;
}
else if (strAttributeName  ==  conzx_SysCount.TeaScore)
{
return mfltTeaScore;
}
else if (strAttributeName  ==  conzx_SysCount.TableKey)
{
return mstrTableKey;
}
else if (strAttributeName  ==  conzx_SysCount.ParentId)
{
return mstrParentId;
}
else if (strAttributeName  ==  conzx_SysCount.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_SysCount.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_SysCount.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_SysCount.zxCountId)
{
mstrzxCountId = value.ToString();
 AddUpdatedFld(conzx_SysCount.zxCountId);
}
else if (strAttributeName  ==  conzx_SysCount.CountTypeId)
{
mstrCountTypeId = value.ToString();
 AddUpdatedFld(conzx_SysCount.CountTypeId);
}
else if (strAttributeName  ==  conzx_SysCount.PaperRWCount)
{
mintPaperRWCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SysCount.PaperRWCount);
}
else if (strAttributeName  ==  conzx_SysCount.OkCount)
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SysCount.OkCount);
}
else if (strAttributeName  ==  conzx_SysCount.CollectionCount)
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SysCount.CollectionCount);
}
else if (strAttributeName  ==  conzx_SysCount.DownloadCount)
{
mintDownloadCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SysCount.DownloadCount);
}
else if (strAttributeName  ==  conzx_SysCount.AttachmentCount)
{
mintAttachmentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SysCount.AttachmentCount);
}
else if (strAttributeName  ==  conzx_SysCount.CommentCount)
{
mintCommentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SysCount.CommentCount);
}
else if (strAttributeName  ==  conzx_SysCount.Score)
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_SysCount.Score);
}
else if (strAttributeName  ==  conzx_SysCount.StuScore)
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_SysCount.StuScore);
}
else if (strAttributeName  ==  conzx_SysCount.TeaScore)
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_SysCount.TeaScore);
}
else if (strAttributeName  ==  conzx_SysCount.TableKey)
{
mstrTableKey = value.ToString();
 AddUpdatedFld(conzx_SysCount.TableKey);
}
else if (strAttributeName  ==  conzx_SysCount.ParentId)
{
mstrParentId = value.ToString();
 AddUpdatedFld(conzx_SysCount.ParentId);
}
else if (strAttributeName  ==  conzx_SysCount.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_SysCount.UpdUser);
}
else if (strAttributeName  ==  conzx_SysCount.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_SysCount.UpdDate);
}
else if (strAttributeName  ==  conzx_SysCount.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_SysCount.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_SysCount.zxCountId  ==  AttributeName[intIndex])
{
return mstrzxCountId;
}
else if (conzx_SysCount.CountTypeId  ==  AttributeName[intIndex])
{
return mstrCountTypeId;
}
else if (conzx_SysCount.PaperRWCount  ==  AttributeName[intIndex])
{
return mintPaperRWCount;
}
else if (conzx_SysCount.OkCount  ==  AttributeName[intIndex])
{
return mintOkCount;
}
else if (conzx_SysCount.CollectionCount  ==  AttributeName[intIndex])
{
return mlngCollectionCount;
}
else if (conzx_SysCount.DownloadCount  ==  AttributeName[intIndex])
{
return mintDownloadCount;
}
else if (conzx_SysCount.AttachmentCount  ==  AttributeName[intIndex])
{
return mintAttachmentCount;
}
else if (conzx_SysCount.CommentCount  ==  AttributeName[intIndex])
{
return mintCommentCount;
}
else if (conzx_SysCount.Score  ==  AttributeName[intIndex])
{
return mfltScore;
}
else if (conzx_SysCount.StuScore  ==  AttributeName[intIndex])
{
return mfltStuScore;
}
else if (conzx_SysCount.TeaScore  ==  AttributeName[intIndex])
{
return mfltTeaScore;
}
else if (conzx_SysCount.TableKey  ==  AttributeName[intIndex])
{
return mstrTableKey;
}
else if (conzx_SysCount.ParentId  ==  AttributeName[intIndex])
{
return mstrParentId;
}
else if (conzx_SysCount.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_SysCount.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_SysCount.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_SysCount.zxCountId  ==  AttributeName[intIndex])
{
mstrzxCountId = value.ToString();
 AddUpdatedFld(conzx_SysCount.zxCountId);
}
else if (conzx_SysCount.CountTypeId  ==  AttributeName[intIndex])
{
mstrCountTypeId = value.ToString();
 AddUpdatedFld(conzx_SysCount.CountTypeId);
}
else if (conzx_SysCount.PaperRWCount  ==  AttributeName[intIndex])
{
mintPaperRWCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SysCount.PaperRWCount);
}
else if (conzx_SysCount.OkCount  ==  AttributeName[intIndex])
{
mintOkCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SysCount.OkCount);
}
else if (conzx_SysCount.CollectionCount  ==  AttributeName[intIndex])
{
mlngCollectionCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SysCount.CollectionCount);
}
else if (conzx_SysCount.DownloadCount  ==  AttributeName[intIndex])
{
mintDownloadCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SysCount.DownloadCount);
}
else if (conzx_SysCount.AttachmentCount  ==  AttributeName[intIndex])
{
mintAttachmentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SysCount.AttachmentCount);
}
else if (conzx_SysCount.CommentCount  ==  AttributeName[intIndex])
{
mintCommentCount = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SysCount.CommentCount);
}
else if (conzx_SysCount.Score  ==  AttributeName[intIndex])
{
mfltScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_SysCount.Score);
}
else if (conzx_SysCount.StuScore  ==  AttributeName[intIndex])
{
mfltStuScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_SysCount.StuScore);
}
else if (conzx_SysCount.TeaScore  ==  AttributeName[intIndex])
{
mfltTeaScore = TransNullToFloat(value.ToString());
 AddUpdatedFld(conzx_SysCount.TeaScore);
}
else if (conzx_SysCount.TableKey  ==  AttributeName[intIndex])
{
mstrTableKey = value.ToString();
 AddUpdatedFld(conzx_SysCount.TableKey);
}
else if (conzx_SysCount.ParentId  ==  AttributeName[intIndex])
{
mstrParentId = value.ToString();
 AddUpdatedFld(conzx_SysCount.ParentId);
}
else if (conzx_SysCount.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_SysCount.UpdUser);
}
else if (conzx_SysCount.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_SysCount.UpdDate);
}
else if (conzx_SysCount.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_SysCount.Memo);
}
}
}

/// <summary>
/// CountId(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxCountId
{
get
{
return mstrzxCountId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxCountId = value;
}
else
{
 mstrzxCountId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_SysCount.zxCountId);
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
 AddUpdatedFld(conzx_SysCount.CountTypeId);
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
 AddUpdatedFld(conzx_SysCount.PaperRWCount);
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
 AddUpdatedFld(conzx_SysCount.OkCount);
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
 AddUpdatedFld(conzx_SysCount.CollectionCount);
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
 AddUpdatedFld(conzx_SysCount.DownloadCount);
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
 AddUpdatedFld(conzx_SysCount.AttachmentCount);
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
 AddUpdatedFld(conzx_SysCount.CommentCount);
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
 AddUpdatedFld(conzx_SysCount.Score);
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
 AddUpdatedFld(conzx_SysCount.StuScore);
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
 AddUpdatedFld(conzx_SysCount.TeaScore);
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
 AddUpdatedFld(conzx_SysCount.TableKey);
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
 AddUpdatedFld(conzx_SysCount.ParentId);
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
 AddUpdatedFld(conzx_SysCount.UpdUser);
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
 AddUpdatedFld(conzx_SysCount.UpdDate);
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
 AddUpdatedFld(conzx_SysCount.Memo);
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
  return mstrzxCountId;
 }
 }
}
 /// <summary>
 /// 中学统计数据(zx_SysCount)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_SysCount
{
public const string _CurrTabName = "zx_SysCount"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxCountId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxCountId", "CountTypeId", "PaperRWCount", "OkCount", "CollectionCount", "DownloadCount", "AttachmentCount", "CommentCount", "Score", "StuScore", "TeaScore", "TableKey", "ParentId", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxCountId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxCountId = "zxCountId";    //CountId

 /// <summary>
 /// 常量:"CountTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CountTypeId = "CountTypeId";    //CountTypeId

 /// <summary>
 /// 常量:"PaperRWCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperRWCount = "PaperRWCount";    //PaperRWCount

 /// <summary>
 /// 常量:"OkCount"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OkCount = "OkCount";    //点赞统计

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
}

}