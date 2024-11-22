
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSysVoteEN
 表名:vSysVote(01120633)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:47
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
 /// 表vSysVote的关键字(VoteId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_VoteId_vSysVote
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngVoteId">表关键字</param>
public K_VoteId_vSysVote(long lngVoteId)
{
if (IsValid(lngVoteId)) Value = lngVoteId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngVoteId)
{
if (lngVoteId == 0) return false;
if (lngVoteId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_VoteId_vSysVote]类型的对象</returns>
public static implicit operator K_VoteId_vSysVote(long value)
{
return new K_VoteId_vSysVote(value);
}
}
 /// <summary>
 /// v系统点赞视图(vSysVote)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvSysVoteEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vSysVote"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "VoteId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"VoteId", "TableKey", "PubParentId", "VoteTypeId", "VoteTypeName", "UpdUser", "VoteTable", "UpdDate", "VoteTableId", "Memo", "IdCurrEduCls", "LikedUserId"};

protected long mlngVoteId;    //点赞Id
protected string mstrTableKey;    //表主键
protected string mstrPubParentId;    //公共父Id
protected string mstrVoteTypeId;    //点赞类型Id
protected string mstrVoteTypeName;    //点赞类型名称
protected string mstrUpdUser;    //修改人
protected string mstrVoteTable;    //点赞表
protected string mstrUpdDate;    //修改日期
protected string mstrVoteTableId;    //点赞表Id
protected string mstrMemo;    //备注
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrLikedUserId;    //被点赞用户Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvSysVoteEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("VoteId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngVoteId">关键字:点赞Id</param>
public clsvSysVoteEN(long lngVoteId)
 {
 if (lngVoteId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngVoteId = lngVoteId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("VoteId");
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
if (strAttributeName  ==  convSysVote.VoteId)
{
return mlngVoteId;
}
else if (strAttributeName  ==  convSysVote.TableKey)
{
return mstrTableKey;
}
else if (strAttributeName  ==  convSysVote.PubParentId)
{
return mstrPubParentId;
}
else if (strAttributeName  ==  convSysVote.VoteTypeId)
{
return mstrVoteTypeId;
}
else if (strAttributeName  ==  convSysVote.VoteTypeName)
{
return mstrVoteTypeName;
}
else if (strAttributeName  ==  convSysVote.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convSysVote.VoteTable)
{
return mstrVoteTable;
}
else if (strAttributeName  ==  convSysVote.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convSysVote.VoteTableId)
{
return mstrVoteTableId;
}
else if (strAttributeName  ==  convSysVote.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convSysVote.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convSysVote.LikedUserId)
{
return mstrLikedUserId;
}
return null;
}
set
{
if (strAttributeName  ==  convSysVote.VoteId)
{
mlngVoteId = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysVote.VoteId);
}
else if (strAttributeName  ==  convSysVote.TableKey)
{
mstrTableKey = value.ToString();
 AddUpdatedFld(convSysVote.TableKey);
}
else if (strAttributeName  ==  convSysVote.PubParentId)
{
mstrPubParentId = value.ToString();
 AddUpdatedFld(convSysVote.PubParentId);
}
else if (strAttributeName  ==  convSysVote.VoteTypeId)
{
mstrVoteTypeId = value.ToString();
 AddUpdatedFld(convSysVote.VoteTypeId);
}
else if (strAttributeName  ==  convSysVote.VoteTypeName)
{
mstrVoteTypeName = value.ToString();
 AddUpdatedFld(convSysVote.VoteTypeName);
}
else if (strAttributeName  ==  convSysVote.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convSysVote.UpdUser);
}
else if (strAttributeName  ==  convSysVote.VoteTable)
{
mstrVoteTable = value.ToString();
 AddUpdatedFld(convSysVote.VoteTable);
}
else if (strAttributeName  ==  convSysVote.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSysVote.UpdDate);
}
else if (strAttributeName  ==  convSysVote.VoteTableId)
{
mstrVoteTableId = value.ToString();
 AddUpdatedFld(convSysVote.VoteTableId);
}
else if (strAttributeName  ==  convSysVote.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSysVote.Memo);
}
else if (strAttributeName  ==  convSysVote.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convSysVote.IdCurrEduCls);
}
else if (strAttributeName  ==  convSysVote.LikedUserId)
{
mstrLikedUserId = value.ToString();
 AddUpdatedFld(convSysVote.LikedUserId);
}
}
}
public object this[int intIndex]
{
get
{
if (convSysVote.VoteId  ==  AttributeName[intIndex])
{
return mlngVoteId;
}
else if (convSysVote.TableKey  ==  AttributeName[intIndex])
{
return mstrTableKey;
}
else if (convSysVote.PubParentId  ==  AttributeName[intIndex])
{
return mstrPubParentId;
}
else if (convSysVote.VoteTypeId  ==  AttributeName[intIndex])
{
return mstrVoteTypeId;
}
else if (convSysVote.VoteTypeName  ==  AttributeName[intIndex])
{
return mstrVoteTypeName;
}
else if (convSysVote.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convSysVote.VoteTable  ==  AttributeName[intIndex])
{
return mstrVoteTable;
}
else if (convSysVote.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convSysVote.VoteTableId  ==  AttributeName[intIndex])
{
return mstrVoteTableId;
}
else if (convSysVote.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convSysVote.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convSysVote.LikedUserId  ==  AttributeName[intIndex])
{
return mstrLikedUserId;
}
return null;
}
set
{
if (convSysVote.VoteId  ==  AttributeName[intIndex])
{
mlngVoteId = TransNullToInt(value.ToString());
 AddUpdatedFld(convSysVote.VoteId);
}
else if (convSysVote.TableKey  ==  AttributeName[intIndex])
{
mstrTableKey = value.ToString();
 AddUpdatedFld(convSysVote.TableKey);
}
else if (convSysVote.PubParentId  ==  AttributeName[intIndex])
{
mstrPubParentId = value.ToString();
 AddUpdatedFld(convSysVote.PubParentId);
}
else if (convSysVote.VoteTypeId  ==  AttributeName[intIndex])
{
mstrVoteTypeId = value.ToString();
 AddUpdatedFld(convSysVote.VoteTypeId);
}
else if (convSysVote.VoteTypeName  ==  AttributeName[intIndex])
{
mstrVoteTypeName = value.ToString();
 AddUpdatedFld(convSysVote.VoteTypeName);
}
else if (convSysVote.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convSysVote.UpdUser);
}
else if (convSysVote.VoteTable  ==  AttributeName[intIndex])
{
mstrVoteTable = value.ToString();
 AddUpdatedFld(convSysVote.VoteTable);
}
else if (convSysVote.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSysVote.UpdDate);
}
else if (convSysVote.VoteTableId  ==  AttributeName[intIndex])
{
mstrVoteTableId = value.ToString();
 AddUpdatedFld(convSysVote.VoteTableId);
}
else if (convSysVote.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSysVote.Memo);
}
else if (convSysVote.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convSysVote.IdCurrEduCls);
}
else if (convSysVote.LikedUserId  ==  AttributeName[intIndex])
{
mstrLikedUserId = value.ToString();
 AddUpdatedFld(convSysVote.LikedUserId);
}
}
}

/// <summary>
/// 点赞Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long VoteId
{
get
{
return mlngVoteId;
}
set
{
 mlngVoteId = value;
//记录修改过的字段
 AddUpdatedFld(convSysVote.VoteId);
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
 AddUpdatedFld(convSysVote.TableKey);
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
 AddUpdatedFld(convSysVote.PubParentId);
}
}
/// <summary>
/// 点赞类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VoteTypeId
{
get
{
return mstrVoteTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVoteTypeId = value;
}
else
{
 mstrVoteTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysVote.VoteTypeId);
}
}
/// <summary>
/// 点赞类型名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VoteTypeName
{
get
{
return mstrVoteTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVoteTypeName = value;
}
else
{
 mstrVoteTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysVote.VoteTypeName);
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
 AddUpdatedFld(convSysVote.UpdUser);
}
}
/// <summary>
/// 点赞表(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VoteTable
{
get
{
return mstrVoteTable;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVoteTable = value;
}
else
{
 mstrVoteTable = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysVote.VoteTable);
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
 AddUpdatedFld(convSysVote.UpdDate);
}
}
/// <summary>
/// 点赞表Id(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VoteTableId
{
get
{
return mstrVoteTableId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVoteTableId = value;
}
else
{
 mstrVoteTableId = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysVote.VoteTableId);
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
 AddUpdatedFld(convSysVote.Memo);
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
 AddUpdatedFld(convSysVote.IdCurrEduCls);
}
}
/// <summary>
/// 被点赞用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LikedUserId
{
get
{
return mstrLikedUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLikedUserId = value;
}
else
{
 mstrLikedUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysVote.LikedUserId);
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
  return mlngVoteId.ToString();
 }
 }
}
 /// <summary>
 /// v系统点赞视图(vSysVote)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convSysVote
{
public const string _CurrTabName = "vSysVote"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "VoteId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"VoteId", "TableKey", "PubParentId", "VoteTypeId", "VoteTypeName", "UpdUser", "VoteTable", "UpdDate", "VoteTableId", "Memo", "IdCurrEduCls", "LikedUserId"};
//以下是属性变量


 /// <summary>
 /// 常量:"VoteId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VoteId = "VoteId";    //点赞Id

 /// <summary>
 /// 常量:"TableKey"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TableKey = "TableKey";    //表主键

 /// <summary>
 /// 常量:"PubParentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PubParentId = "PubParentId";    //公共父Id

 /// <summary>
 /// 常量:"VoteTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VoteTypeId = "VoteTypeId";    //点赞类型Id

 /// <summary>
 /// 常量:"VoteTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VoteTypeName = "VoteTypeName";    //点赞类型名称

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"VoteTable"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VoteTable = "VoteTable";    //点赞表

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"VoteTableId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VoteTableId = "VoteTableId";    //点赞表Id

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
 /// 常量:"LikedUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LikedUserId = "LikedUserId";    //被点赞用户Id
}

}