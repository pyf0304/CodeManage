
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserRoleRelation4SynchEN
 表名:QxUserRoleRelation4Synch(01120556)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:20:02
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:权限管理(UsersRight)
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
 /// 表QxUserRoleRelation4Synch的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_QxUserRoleRelation4Synch
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
public K_mId_QxUserRoleRelation4Synch(long lngmId)
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
 /// <returns>返回:[K_mId_QxUserRoleRelation4Synch]类型的对象</returns>
public static implicit operator K_mId_QxUserRoleRelation4Synch(long value)
{
return new K_mId_QxUserRoleRelation4Synch(value);
}
}
 /// <summary>
 /// QxUserRoleRelation4Synch(QxUserRoleRelation4Synch)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxUserRoleRelation4SynchEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxUserRoleRelation4Synch"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"mId", "IpAddress", "UserId", "RoleId", "QxPrjId", "UpdDate", "UpdUserId", "Memo"};

protected long mlngmId;    //mId
protected string mstrIpAddress;    //Ip地址
protected string mstrUserId;    //用户ID
protected string mstrRoleId;    //角色Id
protected string mstrQxPrjId;    //QxPrjId
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxUserRoleRelation4SynchEN()
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
public clsQxUserRoleRelation4SynchEN(long lngmId)
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
if (strAttributeName  ==  conQxUserRoleRelation4Synch.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conQxUserRoleRelation4Synch.IpAddress)
{
return mstrIpAddress;
}
else if (strAttributeName  ==  conQxUserRoleRelation4Synch.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conQxUserRoleRelation4Synch.RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  conQxUserRoleRelation4Synch.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  conQxUserRoleRelation4Synch.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQxUserRoleRelation4Synch.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conQxUserRoleRelation4Synch.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxUserRoleRelation4Synch.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUserRoleRelation4Synch.mId);
}
else if (strAttributeName  ==  conQxUserRoleRelation4Synch.IpAddress)
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(conQxUserRoleRelation4Synch.IpAddress);
}
else if (strAttributeName  ==  conQxUserRoleRelation4Synch.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conQxUserRoleRelation4Synch.UserId);
}
else if (strAttributeName  ==  conQxUserRoleRelation4Synch.RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(conQxUserRoleRelation4Synch.RoleId);
}
else if (strAttributeName  ==  conQxUserRoleRelation4Synch.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxUserRoleRelation4Synch.QxPrjId);
}
else if (strAttributeName  ==  conQxUserRoleRelation4Synch.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxUserRoleRelation4Synch.UpdDate);
}
else if (strAttributeName  ==  conQxUserRoleRelation4Synch.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conQxUserRoleRelation4Synch.UpdUserId);
}
else if (strAttributeName  ==  conQxUserRoleRelation4Synch.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxUserRoleRelation4Synch.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxUserRoleRelation4Synch.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conQxUserRoleRelation4Synch.IpAddress  ==  AttributeName[intIndex])
{
return mstrIpAddress;
}
else if (conQxUserRoleRelation4Synch.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conQxUserRoleRelation4Synch.RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (conQxUserRoleRelation4Synch.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (conQxUserRoleRelation4Synch.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQxUserRoleRelation4Synch.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conQxUserRoleRelation4Synch.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxUserRoleRelation4Synch.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUserRoleRelation4Synch.mId);
}
else if (conQxUserRoleRelation4Synch.IpAddress  ==  AttributeName[intIndex])
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(conQxUserRoleRelation4Synch.IpAddress);
}
else if (conQxUserRoleRelation4Synch.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conQxUserRoleRelation4Synch.UserId);
}
else if (conQxUserRoleRelation4Synch.RoleId  ==  AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(conQxUserRoleRelation4Synch.RoleId);
}
else if (conQxUserRoleRelation4Synch.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxUserRoleRelation4Synch.QxPrjId);
}
else if (conQxUserRoleRelation4Synch.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxUserRoleRelation4Synch.UpdDate);
}
else if (conQxUserRoleRelation4Synch.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conQxUserRoleRelation4Synch.UpdUserId);
}
else if (conQxUserRoleRelation4Synch.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxUserRoleRelation4Synch.Memo);
}
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
 AddUpdatedFld(conQxUserRoleRelation4Synch.mId);
}
}
/// <summary>
/// Ip地址(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IpAddress
{
get
{
return mstrIpAddress;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIpAddress = value;
}
else
{
 mstrIpAddress = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUserRoleRelation4Synch.IpAddress);
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
 AddUpdatedFld(conQxUserRoleRelation4Synch.UserId);
}
}
/// <summary>
/// 角色Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RoleId
{
get
{
return mstrRoleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRoleId = value;
}
else
{
 mstrRoleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUserRoleRelation4Synch.RoleId);
}
}
/// <summary>
/// QxPrjId(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QxPrjId
{
get
{
return mstrQxPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQxPrjId = value;
}
else
{
 mstrQxPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUserRoleRelation4Synch.QxPrjId);
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
 AddUpdatedFld(conQxUserRoleRelation4Synch.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUserRoleRelation4Synch.UpdUserId);
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
 AddUpdatedFld(conQxUserRoleRelation4Synch.Memo);
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
 /// QxUserRoleRelation4Synch(QxUserRoleRelation4Synch)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxUserRoleRelation4Synch
{
public const string _CurrTabName = "QxUserRoleRelation4Synch"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "IpAddress", "UserId", "RoleId", "QxPrjId", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"IpAddress"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IpAddress = "IpAddress";    //Ip地址

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"RoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleId = "RoleId";    //角色Id

 /// <summary>
 /// 常量:"QxPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxPrjId = "QxPrjId";    //QxPrjId

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}