
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clssys_RequestPushEN
 表名:sys_RequestPush(01120726)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:16:22
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
 /// 表sys_RequestPush的关键字(RequestId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RequestId_sys_RequestPush
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngRequestId">表关键字</param>
public K_RequestId_sys_RequestPush(long lngRequestId)
{
if (IsValid(lngRequestId)) Value = lngRequestId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngRequestId)
{
if (lngRequestId == 0) return false;
if (lngRequestId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_RequestId_sys_RequestPush]类型的对象</returns>
public static implicit operator K_RequestId_sys_RequestPush(long value)
{
return new K_RequestId_sys_RequestPush(value);
}
}
 /// <summary>
 /// 请求推送表(sys_RequestPush)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clssys_RequestPushEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "sys_RequestPush"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "RequestId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"RequestId", "RequesTypeId", "TableKey", "ReceiveUser", "IsReply", "ReplyDate", "RequestUser", "RequestDate", "RequestStata", "Memo", "IdCurrEduCls", "PushTypeId"};

protected long mlngRequestId;    //RequestId
protected string mstrRequesTypeId;    //请求类型Id
protected string mstrTableKey;    //表主键
protected string mstrReceiveUser;    //接收用户
protected bool mbolIsReply;    //是否回复
protected string mstrReplyDate;    //回复日期
protected string mstrRequestUser;    //RequestUser
protected string mstrRequestDate;    //RequestDate
protected string mstrRequestStata;    //RequestStata
protected string mstrMemo;    //备注
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrPushTypeId;    //推送类型Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clssys_RequestPushEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RequestId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngRequestId">关键字:RequestId</param>
public clssys_RequestPushEN(long lngRequestId)
 {
 if (lngRequestId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngRequestId = lngRequestId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RequestId");
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
if (strAttributeName  ==  consys_RequestPush.RequestId)
{
return mlngRequestId;
}
else if (strAttributeName  ==  consys_RequestPush.RequesTypeId)
{
return mstrRequesTypeId;
}
else if (strAttributeName  ==  consys_RequestPush.TableKey)
{
return mstrTableKey;
}
else if (strAttributeName  ==  consys_RequestPush.ReceiveUser)
{
return mstrReceiveUser;
}
else if (strAttributeName  ==  consys_RequestPush.IsReply)
{
return mbolIsReply;
}
else if (strAttributeName  ==  consys_RequestPush.ReplyDate)
{
return mstrReplyDate;
}
else if (strAttributeName  ==  consys_RequestPush.RequestUser)
{
return mstrRequestUser;
}
else if (strAttributeName  ==  consys_RequestPush.RequestDate)
{
return mstrRequestDate;
}
else if (strAttributeName  ==  consys_RequestPush.RequestStata)
{
return mstrRequestStata;
}
else if (strAttributeName  ==  consys_RequestPush.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  consys_RequestPush.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  consys_RequestPush.PushTypeId)
{
return mstrPushTypeId;
}
return null;
}
set
{
if (strAttributeName  ==  consys_RequestPush.RequestId)
{
mlngRequestId = TransNullToInt(value.ToString());
 AddUpdatedFld(consys_RequestPush.RequestId);
}
else if (strAttributeName  ==  consys_RequestPush.RequesTypeId)
{
mstrRequesTypeId = value.ToString();
 AddUpdatedFld(consys_RequestPush.RequesTypeId);
}
else if (strAttributeName  ==  consys_RequestPush.TableKey)
{
mstrTableKey = value.ToString();
 AddUpdatedFld(consys_RequestPush.TableKey);
}
else if (strAttributeName  ==  consys_RequestPush.ReceiveUser)
{
mstrReceiveUser = value.ToString();
 AddUpdatedFld(consys_RequestPush.ReceiveUser);
}
else if (strAttributeName  ==  consys_RequestPush.IsReply)
{
mbolIsReply = TransNullToBool(value.ToString());
 AddUpdatedFld(consys_RequestPush.IsReply);
}
else if (strAttributeName  ==  consys_RequestPush.ReplyDate)
{
mstrReplyDate = value.ToString();
 AddUpdatedFld(consys_RequestPush.ReplyDate);
}
else if (strAttributeName  ==  consys_RequestPush.RequestUser)
{
mstrRequestUser = value.ToString();
 AddUpdatedFld(consys_RequestPush.RequestUser);
}
else if (strAttributeName  ==  consys_RequestPush.RequestDate)
{
mstrRequestDate = value.ToString();
 AddUpdatedFld(consys_RequestPush.RequestDate);
}
else if (strAttributeName  ==  consys_RequestPush.RequestStata)
{
mstrRequestStata = value.ToString();
 AddUpdatedFld(consys_RequestPush.RequestStata);
}
else if (strAttributeName  ==  consys_RequestPush.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(consys_RequestPush.Memo);
}
else if (strAttributeName  ==  consys_RequestPush.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(consys_RequestPush.IdCurrEduCls);
}
else if (strAttributeName  ==  consys_RequestPush.PushTypeId)
{
mstrPushTypeId = value.ToString();
 AddUpdatedFld(consys_RequestPush.PushTypeId);
}
}
}
public object this[int intIndex]
{
get
{
if (consys_RequestPush.RequestId  ==  AttributeName[intIndex])
{
return mlngRequestId;
}
else if (consys_RequestPush.RequesTypeId  ==  AttributeName[intIndex])
{
return mstrRequesTypeId;
}
else if (consys_RequestPush.TableKey  ==  AttributeName[intIndex])
{
return mstrTableKey;
}
else if (consys_RequestPush.ReceiveUser  ==  AttributeName[intIndex])
{
return mstrReceiveUser;
}
else if (consys_RequestPush.IsReply  ==  AttributeName[intIndex])
{
return mbolIsReply;
}
else if (consys_RequestPush.ReplyDate  ==  AttributeName[intIndex])
{
return mstrReplyDate;
}
else if (consys_RequestPush.RequestUser  ==  AttributeName[intIndex])
{
return mstrRequestUser;
}
else if (consys_RequestPush.RequestDate  ==  AttributeName[intIndex])
{
return mstrRequestDate;
}
else if (consys_RequestPush.RequestStata  ==  AttributeName[intIndex])
{
return mstrRequestStata;
}
else if (consys_RequestPush.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (consys_RequestPush.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (consys_RequestPush.PushTypeId  ==  AttributeName[intIndex])
{
return mstrPushTypeId;
}
return null;
}
set
{
if (consys_RequestPush.RequestId  ==  AttributeName[intIndex])
{
mlngRequestId = TransNullToInt(value.ToString());
 AddUpdatedFld(consys_RequestPush.RequestId);
}
else if (consys_RequestPush.RequesTypeId  ==  AttributeName[intIndex])
{
mstrRequesTypeId = value.ToString();
 AddUpdatedFld(consys_RequestPush.RequesTypeId);
}
else if (consys_RequestPush.TableKey  ==  AttributeName[intIndex])
{
mstrTableKey = value.ToString();
 AddUpdatedFld(consys_RequestPush.TableKey);
}
else if (consys_RequestPush.ReceiveUser  ==  AttributeName[intIndex])
{
mstrReceiveUser = value.ToString();
 AddUpdatedFld(consys_RequestPush.ReceiveUser);
}
else if (consys_RequestPush.IsReply  ==  AttributeName[intIndex])
{
mbolIsReply = TransNullToBool(value.ToString());
 AddUpdatedFld(consys_RequestPush.IsReply);
}
else if (consys_RequestPush.ReplyDate  ==  AttributeName[intIndex])
{
mstrReplyDate = value.ToString();
 AddUpdatedFld(consys_RequestPush.ReplyDate);
}
else if (consys_RequestPush.RequestUser  ==  AttributeName[intIndex])
{
mstrRequestUser = value.ToString();
 AddUpdatedFld(consys_RequestPush.RequestUser);
}
else if (consys_RequestPush.RequestDate  ==  AttributeName[intIndex])
{
mstrRequestDate = value.ToString();
 AddUpdatedFld(consys_RequestPush.RequestDate);
}
else if (consys_RequestPush.RequestStata  ==  AttributeName[intIndex])
{
mstrRequestStata = value.ToString();
 AddUpdatedFld(consys_RequestPush.RequestStata);
}
else if (consys_RequestPush.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(consys_RequestPush.Memo);
}
else if (consys_RequestPush.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(consys_RequestPush.IdCurrEduCls);
}
else if (consys_RequestPush.PushTypeId  ==  AttributeName[intIndex])
{
mstrPushTypeId = value.ToString();
 AddUpdatedFld(consys_RequestPush.PushTypeId);
}
}
}

/// <summary>
/// RequestId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long RequestId
{
get
{
return mlngRequestId;
}
set
{
 mlngRequestId = value;
//记录修改过的字段
 AddUpdatedFld(consys_RequestPush.RequestId);
}
}
/// <summary>
/// 请求类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RequesTypeId
{
get
{
return mstrRequesTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRequesTypeId = value;
}
else
{
 mstrRequesTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(consys_RequestPush.RequesTypeId);
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
 AddUpdatedFld(consys_RequestPush.TableKey);
}
}
/// <summary>
/// 接收用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReceiveUser
{
get
{
return mstrReceiveUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReceiveUser = value;
}
else
{
 mstrReceiveUser = value;
}
//记录修改过的字段
 AddUpdatedFld(consys_RequestPush.ReceiveUser);
}
}
/// <summary>
/// 是否回复(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsReply
{
get
{
return mbolIsReply;
}
set
{
 mbolIsReply = value;
//记录修改过的字段
 AddUpdatedFld(consys_RequestPush.IsReply);
}
}
/// <summary>
/// 回复日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReplyDate
{
get
{
return mstrReplyDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReplyDate = value;
}
else
{
 mstrReplyDate = value;
}
//记录修改过的字段
 AddUpdatedFld(consys_RequestPush.ReplyDate);
}
}
/// <summary>
/// RequestUser(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RequestUser
{
get
{
return mstrRequestUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRequestUser = value;
}
else
{
 mstrRequestUser = value;
}
//记录修改过的字段
 AddUpdatedFld(consys_RequestPush.RequestUser);
}
}
/// <summary>
/// RequestDate(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RequestDate
{
get
{
return mstrRequestDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRequestDate = value;
}
else
{
 mstrRequestDate = value;
}
//记录修改过的字段
 AddUpdatedFld(consys_RequestPush.RequestDate);
}
}
/// <summary>
/// RequestStata(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RequestStata
{
get
{
return mstrRequestStata;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRequestStata = value;
}
else
{
 mstrRequestStata = value;
}
//记录修改过的字段
 AddUpdatedFld(consys_RequestPush.RequestStata);
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
 AddUpdatedFld(consys_RequestPush.Memo);
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
 AddUpdatedFld(consys_RequestPush.IdCurrEduCls);
}
}
/// <summary>
/// 推送类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PushTypeId
{
get
{
return mstrPushTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPushTypeId = value;
}
else
{
 mstrPushTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(consys_RequestPush.PushTypeId);
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
  return mlngRequestId.ToString();
 }
 }
}
 /// <summary>
 /// 请求推送表(sys_RequestPush)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class consys_RequestPush
{
public const string _CurrTabName = "sys_RequestPush"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RequestId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"RequestId", "RequesTypeId", "TableKey", "ReceiveUser", "IsReply", "ReplyDate", "RequestUser", "RequestDate", "RequestStata", "Memo", "IdCurrEduCls", "PushTypeId"};
//以下是属性变量


 /// <summary>
 /// 常量:"RequestId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RequestId = "RequestId";    //RequestId

 /// <summary>
 /// 常量:"RequesTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RequesTypeId = "RequesTypeId";    //请求类型Id

 /// <summary>
 /// 常量:"TableKey"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TableKey = "TableKey";    //表主键

 /// <summary>
 /// 常量:"ReceiveUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReceiveUser = "ReceiveUser";    //接收用户

 /// <summary>
 /// 常量:"IsReply"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsReply = "IsReply";    //是否回复

 /// <summary>
 /// 常量:"ReplyDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReplyDate = "ReplyDate";    //回复日期

 /// <summary>
 /// 常量:"RequestUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RequestUser = "RequestUser";    //RequestUser

 /// <summary>
 /// 常量:"RequestDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RequestDate = "RequestDate";    //RequestDate

 /// <summary>
 /// 常量:"RequestStata"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RequestStata = "RequestStata";    //RequestStata

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
 /// 常量:"PushTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PushTypeId = "PushTypeId";    //推送类型Id
}

}