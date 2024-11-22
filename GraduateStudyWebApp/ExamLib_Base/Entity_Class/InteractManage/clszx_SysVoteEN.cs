
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_SysVoteEN
 表名:zx_SysVote(01120845)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:02:47
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
 /// 表zx_SysVote的关键字(zxVoteId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxVoteId_zx_SysVote
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngzxVoteId">表关键字</param>
public K_zxVoteId_zx_SysVote(long lngzxVoteId)
{
if (IsValid(lngzxVoteId)) Value = lngzxVoteId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngzxVoteId)
{
if (lngzxVoteId == 0) return false;
if (lngzxVoteId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxVoteId_zx_SysVote]类型的对象</returns>
public static implicit operator K_zxVoteId_zx_SysVote(long value)
{
return new K_zxVoteId_zx_SysVote(value);
}
}
 /// <summary>
 /// 中学系统点赞表(zx_SysVote)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_SysVoteEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_SysVote"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxVoteId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"zxVoteId", "TableKey", "PubParentId", "zxVoteTypeId", "UpdUser", "UpdDate", "Memo", "IdCurrEduCls", "UserId"};

protected long mlngzxVoteId;    //点赞Id
protected string mstrTableKey;    //表主键
protected string mstrPubParentId;    //公共父Id
protected string mstrzxVoteTypeId;    //点赞类型Id
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrUserId;    //用户ID

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_SysVoteEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxVoteId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngzxVoteId">关键字:点赞Id</param>
public clszx_SysVoteEN(long lngzxVoteId)
 {
 if (lngzxVoteId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngzxVoteId = lngzxVoteId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxVoteId");
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
if (strAttributeName  ==  conzx_SysVote.zxVoteId)
{
return mlngzxVoteId;
}
else if (strAttributeName  ==  conzx_SysVote.TableKey)
{
return mstrTableKey;
}
else if (strAttributeName  ==  conzx_SysVote.PubParentId)
{
return mstrPubParentId;
}
else if (strAttributeName  ==  conzx_SysVote.zxVoteTypeId)
{
return mstrzxVoteTypeId;
}
else if (strAttributeName  ==  conzx_SysVote.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_SysVote.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_SysVote.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conzx_SysVote.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conzx_SysVote.UserId)
{
return mstrUserId;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_SysVote.zxVoteId)
{
mlngzxVoteId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SysVote.zxVoteId);
}
else if (strAttributeName  ==  conzx_SysVote.TableKey)
{
mstrTableKey = value.ToString();
 AddUpdatedFld(conzx_SysVote.TableKey);
}
else if (strAttributeName  ==  conzx_SysVote.PubParentId)
{
mstrPubParentId = value.ToString();
 AddUpdatedFld(conzx_SysVote.PubParentId);
}
else if (strAttributeName  ==  conzx_SysVote.zxVoteTypeId)
{
mstrzxVoteTypeId = value.ToString();
 AddUpdatedFld(conzx_SysVote.zxVoteTypeId);
}
else if (strAttributeName  ==  conzx_SysVote.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_SysVote.UpdUser);
}
else if (strAttributeName  ==  conzx_SysVote.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_SysVote.UpdDate);
}
else if (strAttributeName  ==  conzx_SysVote.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_SysVote.Memo);
}
else if (strAttributeName  ==  conzx_SysVote.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_SysVote.IdCurrEduCls);
}
else if (strAttributeName  ==  conzx_SysVote.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conzx_SysVote.UserId);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_SysVote.zxVoteId  ==  AttributeName[intIndex])
{
return mlngzxVoteId;
}
else if (conzx_SysVote.TableKey  ==  AttributeName[intIndex])
{
return mstrTableKey;
}
else if (conzx_SysVote.PubParentId  ==  AttributeName[intIndex])
{
return mstrPubParentId;
}
else if (conzx_SysVote.zxVoteTypeId  ==  AttributeName[intIndex])
{
return mstrzxVoteTypeId;
}
else if (conzx_SysVote.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_SysVote.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_SysVote.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conzx_SysVote.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conzx_SysVote.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
return null;
}
set
{
if (conzx_SysVote.zxVoteId  ==  AttributeName[intIndex])
{
mlngzxVoteId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_SysVote.zxVoteId);
}
else if (conzx_SysVote.TableKey  ==  AttributeName[intIndex])
{
mstrTableKey = value.ToString();
 AddUpdatedFld(conzx_SysVote.TableKey);
}
else if (conzx_SysVote.PubParentId  ==  AttributeName[intIndex])
{
mstrPubParentId = value.ToString();
 AddUpdatedFld(conzx_SysVote.PubParentId);
}
else if (conzx_SysVote.zxVoteTypeId  ==  AttributeName[intIndex])
{
mstrzxVoteTypeId = value.ToString();
 AddUpdatedFld(conzx_SysVote.zxVoteTypeId);
}
else if (conzx_SysVote.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_SysVote.UpdUser);
}
else if (conzx_SysVote.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_SysVote.UpdDate);
}
else if (conzx_SysVote.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_SysVote.Memo);
}
else if (conzx_SysVote.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_SysVote.IdCurrEduCls);
}
else if (conzx_SysVote.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conzx_SysVote.UserId);
}
}
}

/// <summary>
/// 点赞Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long zxVoteId
{
get
{
return mlngzxVoteId;
}
set
{
 mlngzxVoteId = value;
//记录修改过的字段
 AddUpdatedFld(conzx_SysVote.zxVoteId);
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
 AddUpdatedFld(conzx_SysVote.TableKey);
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
 AddUpdatedFld(conzx_SysVote.PubParentId);
}
}
/// <summary>
/// 点赞类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxVoteTypeId
{
get
{
return mstrzxVoteTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxVoteTypeId = value;
}
else
{
 mstrzxVoteTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_SysVote.zxVoteTypeId);
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
 AddUpdatedFld(conzx_SysVote.UpdUser);
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
 AddUpdatedFld(conzx_SysVote.UpdDate);
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
 AddUpdatedFld(conzx_SysVote.Memo);
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
 AddUpdatedFld(conzx_SysVote.IdCurrEduCls);
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
 AddUpdatedFld(conzx_SysVote.UserId);
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
  return mlngzxVoteId.ToString();
 }
 }
}
 /// <summary>
 /// 中学系统点赞表(zx_SysVote)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_SysVote
{
public const string _CurrTabName = "zx_SysVote"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxVoteId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxVoteId", "TableKey", "PubParentId", "zxVoteTypeId", "UpdUser", "UpdDate", "Memo", "IdCurrEduCls", "UserId"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxVoteId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxVoteId = "zxVoteId";    //点赞Id

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
 /// 常量:"zxVoteTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxVoteTypeId = "zxVoteTypeId";    //点赞类型Id

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