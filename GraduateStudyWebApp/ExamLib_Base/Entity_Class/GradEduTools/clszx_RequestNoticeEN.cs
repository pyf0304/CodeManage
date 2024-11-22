
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_RequestNoticeEN
 表名:zx_RequestNotice(01120786)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:55:50
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
 /// 表zx_RequestNotice的关键字(RequestId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RequestId_zx_RequestNotice
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
public K_RequestId_zx_RequestNotice(long lngRequestId)
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
 /// <returns>返回:[K_RequestId_zx_RequestNotice]类型的对象</returns>
public static implicit operator K_RequestId_zx_RequestNotice(long value)
{
return new K_RequestId_zx_RequestNotice(value);
}
}
 /// <summary>
 /// 中学请求通知表(zx_RequestNotice)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_RequestNoticeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_RequestNotice"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "RequestId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"RequestId", "RequesTypeId", "TableKey", "ReceiveUser", "IsReply", "ReplyDate", "RequestUser", "RequestDate", "RequestStata", "Memo", "PushTypeId", "IdCurrEduCls"};

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
protected string mstrPushTypeId;    //推送类型Id
protected string mstrIdCurrEduCls;    //教学班流水号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_RequestNoticeEN()
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
public clszx_RequestNoticeEN(long lngRequestId)
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
if (strAttributeName  ==  conzx_RequestNotice.RequestId)
{
return mlngRequestId;
}
else if (strAttributeName  ==  conzx_RequestNotice.RequesTypeId)
{
return mstrRequesTypeId;
}
else if (strAttributeName  ==  conzx_RequestNotice.TableKey)
{
return mstrTableKey;
}
else if (strAttributeName  ==  conzx_RequestNotice.ReceiveUser)
{
return mstrReceiveUser;
}
else if (strAttributeName  ==  conzx_RequestNotice.IsReply)
{
return mbolIsReply;
}
else if (strAttributeName  ==  conzx_RequestNotice.ReplyDate)
{
return mstrReplyDate;
}
else if (strAttributeName  ==  conzx_RequestNotice.RequestUser)
{
return mstrRequestUser;
}
else if (strAttributeName  ==  conzx_RequestNotice.RequestDate)
{
return mstrRequestDate;
}
else if (strAttributeName  ==  conzx_RequestNotice.RequestStata)
{
return mstrRequestStata;
}
else if (strAttributeName  ==  conzx_RequestNotice.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conzx_RequestNotice.PushTypeId)
{
return mstrPushTypeId;
}
else if (strAttributeName  ==  conzx_RequestNotice.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_RequestNotice.RequestId)
{
mlngRequestId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_RequestNotice.RequestId);
}
else if (strAttributeName  ==  conzx_RequestNotice.RequesTypeId)
{
mstrRequesTypeId = value.ToString();
 AddUpdatedFld(conzx_RequestNotice.RequesTypeId);
}
else if (strAttributeName  ==  conzx_RequestNotice.TableKey)
{
mstrTableKey = value.ToString();
 AddUpdatedFld(conzx_RequestNotice.TableKey);
}
else if (strAttributeName  ==  conzx_RequestNotice.ReceiveUser)
{
mstrReceiveUser = value.ToString();
 AddUpdatedFld(conzx_RequestNotice.ReceiveUser);
}
else if (strAttributeName  ==  conzx_RequestNotice.IsReply)
{
mbolIsReply = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_RequestNotice.IsReply);
}
else if (strAttributeName  ==  conzx_RequestNotice.ReplyDate)
{
mstrReplyDate = value.ToString();
 AddUpdatedFld(conzx_RequestNotice.ReplyDate);
}
else if (strAttributeName  ==  conzx_RequestNotice.RequestUser)
{
mstrRequestUser = value.ToString();
 AddUpdatedFld(conzx_RequestNotice.RequestUser);
}
else if (strAttributeName  ==  conzx_RequestNotice.RequestDate)
{
mstrRequestDate = value.ToString();
 AddUpdatedFld(conzx_RequestNotice.RequestDate);
}
else if (strAttributeName  ==  conzx_RequestNotice.RequestStata)
{
mstrRequestStata = value.ToString();
 AddUpdatedFld(conzx_RequestNotice.RequestStata);
}
else if (strAttributeName  ==  conzx_RequestNotice.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_RequestNotice.Memo);
}
else if (strAttributeName  ==  conzx_RequestNotice.PushTypeId)
{
mstrPushTypeId = value.ToString();
 AddUpdatedFld(conzx_RequestNotice.PushTypeId);
}
else if (strAttributeName  ==  conzx_RequestNotice.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_RequestNotice.IdCurrEduCls);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_RequestNotice.RequestId  ==  AttributeName[intIndex])
{
return mlngRequestId;
}
else if (conzx_RequestNotice.RequesTypeId  ==  AttributeName[intIndex])
{
return mstrRequesTypeId;
}
else if (conzx_RequestNotice.TableKey  ==  AttributeName[intIndex])
{
return mstrTableKey;
}
else if (conzx_RequestNotice.ReceiveUser  ==  AttributeName[intIndex])
{
return mstrReceiveUser;
}
else if (conzx_RequestNotice.IsReply  ==  AttributeName[intIndex])
{
return mbolIsReply;
}
else if (conzx_RequestNotice.ReplyDate  ==  AttributeName[intIndex])
{
return mstrReplyDate;
}
else if (conzx_RequestNotice.RequestUser  ==  AttributeName[intIndex])
{
return mstrRequestUser;
}
else if (conzx_RequestNotice.RequestDate  ==  AttributeName[intIndex])
{
return mstrRequestDate;
}
else if (conzx_RequestNotice.RequestStata  ==  AttributeName[intIndex])
{
return mstrRequestStata;
}
else if (conzx_RequestNotice.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conzx_RequestNotice.PushTypeId  ==  AttributeName[intIndex])
{
return mstrPushTypeId;
}
else if (conzx_RequestNotice.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (conzx_RequestNotice.RequestId  ==  AttributeName[intIndex])
{
mlngRequestId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_RequestNotice.RequestId);
}
else if (conzx_RequestNotice.RequesTypeId  ==  AttributeName[intIndex])
{
mstrRequesTypeId = value.ToString();
 AddUpdatedFld(conzx_RequestNotice.RequesTypeId);
}
else if (conzx_RequestNotice.TableKey  ==  AttributeName[intIndex])
{
mstrTableKey = value.ToString();
 AddUpdatedFld(conzx_RequestNotice.TableKey);
}
else if (conzx_RequestNotice.ReceiveUser  ==  AttributeName[intIndex])
{
mstrReceiveUser = value.ToString();
 AddUpdatedFld(conzx_RequestNotice.ReceiveUser);
}
else if (conzx_RequestNotice.IsReply  ==  AttributeName[intIndex])
{
mbolIsReply = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_RequestNotice.IsReply);
}
else if (conzx_RequestNotice.ReplyDate  ==  AttributeName[intIndex])
{
mstrReplyDate = value.ToString();
 AddUpdatedFld(conzx_RequestNotice.ReplyDate);
}
else if (conzx_RequestNotice.RequestUser  ==  AttributeName[intIndex])
{
mstrRequestUser = value.ToString();
 AddUpdatedFld(conzx_RequestNotice.RequestUser);
}
else if (conzx_RequestNotice.RequestDate  ==  AttributeName[intIndex])
{
mstrRequestDate = value.ToString();
 AddUpdatedFld(conzx_RequestNotice.RequestDate);
}
else if (conzx_RequestNotice.RequestStata  ==  AttributeName[intIndex])
{
mstrRequestStata = value.ToString();
 AddUpdatedFld(conzx_RequestNotice.RequestStata);
}
else if (conzx_RequestNotice.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_RequestNotice.Memo);
}
else if (conzx_RequestNotice.PushTypeId  ==  AttributeName[intIndex])
{
mstrPushTypeId = value.ToString();
 AddUpdatedFld(conzx_RequestNotice.PushTypeId);
}
else if (conzx_RequestNotice.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_RequestNotice.IdCurrEduCls);
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
 AddUpdatedFld(conzx_RequestNotice.RequestId);
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
 AddUpdatedFld(conzx_RequestNotice.RequesTypeId);
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
 AddUpdatedFld(conzx_RequestNotice.TableKey);
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
 AddUpdatedFld(conzx_RequestNotice.ReceiveUser);
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
 AddUpdatedFld(conzx_RequestNotice.IsReply);
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
 AddUpdatedFld(conzx_RequestNotice.ReplyDate);
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
 AddUpdatedFld(conzx_RequestNotice.RequestUser);
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
 AddUpdatedFld(conzx_RequestNotice.RequestDate);
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
 AddUpdatedFld(conzx_RequestNotice.RequestStata);
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
 AddUpdatedFld(conzx_RequestNotice.Memo);
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
 AddUpdatedFld(conzx_RequestNotice.PushTypeId);
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
 AddUpdatedFld(conzx_RequestNotice.IdCurrEduCls);
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
 /// 中学请求通知表(zx_RequestNotice)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_RequestNotice
{
public const string _CurrTabName = "zx_RequestNotice"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RequestId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"RequestId", "RequesTypeId", "TableKey", "ReceiveUser", "IsReply", "ReplyDate", "RequestUser", "RequestDate", "RequestStata", "Memo", "PushTypeId", "IdCurrEduCls"};
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
 /// 常量:"PushTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PushTypeId = "PushTypeId";    //推送类型Id

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号
}

}