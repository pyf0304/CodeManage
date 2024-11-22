
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_qa_PushEN
 表名:zx_qa_Push(01120811)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:02:44
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
 /// 表zx_qa_Push的关键字(PushId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PushId_zx_qa_Push
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngPushId">表关键字</param>
public K_PushId_zx_qa_Push(long lngPushId)
{
if (IsValid(lngPushId)) Value = lngPushId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngPushId)
{
if (lngPushId == 0) return false;
if (lngPushId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PushId_zx_qa_Push]类型的对象</returns>
public static implicit operator K_PushId_zx_qa_Push(long value)
{
return new K_PushId_zx_qa_Push(value);
}
}
 /// <summary>
 /// 中学答疑推送_Copy(zx_qa_Push)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_qa_PushEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_qa_Push"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PushId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"PushId", "zxQuestionsId", "ReceiveUser", "ReceiveDate", "IsReceive", "UpdDate", "Memo", "IdCurrEduCls", "IsReply", "IsRequestReply", "ReplyDate"};

protected long mlngPushId;    //推送d
protected string mstrzxQuestionsId;    //提问Id
protected string mstrReceiveUser;    //接收用户
protected string mstrReceiveDate;    //接收日期
protected bool mbolIsReceive;    //是否接收
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrIdCurrEduCls;    //教学班流水号
protected bool mbolIsReply;    //是否回复
protected bool mbolIsRequestReply;    //是否要求回复
protected string mstrReplyDate;    //回复日期

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_qa_PushEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PushId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngPushId">关键字:推送d</param>
public clszx_qa_PushEN(long lngPushId)
 {
 if (lngPushId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngPushId = lngPushId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PushId");
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
if (strAttributeName  ==  conzx_qa_Push.PushId)
{
return mlngPushId;
}
else if (strAttributeName  ==  conzx_qa_Push.zxQuestionsId)
{
return mstrzxQuestionsId;
}
else if (strAttributeName  ==  conzx_qa_Push.ReceiveUser)
{
return mstrReceiveUser;
}
else if (strAttributeName  ==  conzx_qa_Push.ReceiveDate)
{
return mstrReceiveDate;
}
else if (strAttributeName  ==  conzx_qa_Push.IsReceive)
{
return mbolIsReceive;
}
else if (strAttributeName  ==  conzx_qa_Push.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_qa_Push.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conzx_qa_Push.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conzx_qa_Push.IsReply)
{
return mbolIsReply;
}
else if (strAttributeName  ==  conzx_qa_Push.IsRequestReply)
{
return mbolIsRequestReply;
}
else if (strAttributeName  ==  conzx_qa_Push.ReplyDate)
{
return mstrReplyDate;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_qa_Push.PushId)
{
mlngPushId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_qa_Push.PushId);
}
else if (strAttributeName  ==  conzx_qa_Push.zxQuestionsId)
{
mstrzxQuestionsId = value.ToString();
 AddUpdatedFld(conzx_qa_Push.zxQuestionsId);
}
else if (strAttributeName  ==  conzx_qa_Push.ReceiveUser)
{
mstrReceiveUser = value.ToString();
 AddUpdatedFld(conzx_qa_Push.ReceiveUser);
}
else if (strAttributeName  ==  conzx_qa_Push.ReceiveDate)
{
mstrReceiveDate = value.ToString();
 AddUpdatedFld(conzx_qa_Push.ReceiveDate);
}
else if (strAttributeName  ==  conzx_qa_Push.IsReceive)
{
mbolIsReceive = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_qa_Push.IsReceive);
}
else if (strAttributeName  ==  conzx_qa_Push.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_qa_Push.UpdDate);
}
else if (strAttributeName  ==  conzx_qa_Push.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_qa_Push.Memo);
}
else if (strAttributeName  ==  conzx_qa_Push.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_qa_Push.IdCurrEduCls);
}
else if (strAttributeName  ==  conzx_qa_Push.IsReply)
{
mbolIsReply = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_qa_Push.IsReply);
}
else if (strAttributeName  ==  conzx_qa_Push.IsRequestReply)
{
mbolIsRequestReply = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_qa_Push.IsRequestReply);
}
else if (strAttributeName  ==  conzx_qa_Push.ReplyDate)
{
mstrReplyDate = value.ToString();
 AddUpdatedFld(conzx_qa_Push.ReplyDate);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_qa_Push.PushId  ==  AttributeName[intIndex])
{
return mlngPushId;
}
else if (conzx_qa_Push.zxQuestionsId  ==  AttributeName[intIndex])
{
return mstrzxQuestionsId;
}
else if (conzx_qa_Push.ReceiveUser  ==  AttributeName[intIndex])
{
return mstrReceiveUser;
}
else if (conzx_qa_Push.ReceiveDate  ==  AttributeName[intIndex])
{
return mstrReceiveDate;
}
else if (conzx_qa_Push.IsReceive  ==  AttributeName[intIndex])
{
return mbolIsReceive;
}
else if (conzx_qa_Push.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_qa_Push.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conzx_qa_Push.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conzx_qa_Push.IsReply  ==  AttributeName[intIndex])
{
return mbolIsReply;
}
else if (conzx_qa_Push.IsRequestReply  ==  AttributeName[intIndex])
{
return mbolIsRequestReply;
}
else if (conzx_qa_Push.ReplyDate  ==  AttributeName[intIndex])
{
return mstrReplyDate;
}
return null;
}
set
{
if (conzx_qa_Push.PushId  ==  AttributeName[intIndex])
{
mlngPushId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_qa_Push.PushId);
}
else if (conzx_qa_Push.zxQuestionsId  ==  AttributeName[intIndex])
{
mstrzxQuestionsId = value.ToString();
 AddUpdatedFld(conzx_qa_Push.zxQuestionsId);
}
else if (conzx_qa_Push.ReceiveUser  ==  AttributeName[intIndex])
{
mstrReceiveUser = value.ToString();
 AddUpdatedFld(conzx_qa_Push.ReceiveUser);
}
else if (conzx_qa_Push.ReceiveDate  ==  AttributeName[intIndex])
{
mstrReceiveDate = value.ToString();
 AddUpdatedFld(conzx_qa_Push.ReceiveDate);
}
else if (conzx_qa_Push.IsReceive  ==  AttributeName[intIndex])
{
mbolIsReceive = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_qa_Push.IsReceive);
}
else if (conzx_qa_Push.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_qa_Push.UpdDate);
}
else if (conzx_qa_Push.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_qa_Push.Memo);
}
else if (conzx_qa_Push.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_qa_Push.IdCurrEduCls);
}
else if (conzx_qa_Push.IsReply  ==  AttributeName[intIndex])
{
mbolIsReply = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_qa_Push.IsReply);
}
else if (conzx_qa_Push.IsRequestReply  ==  AttributeName[intIndex])
{
mbolIsRequestReply = TransNullToBool(value.ToString());
 AddUpdatedFld(conzx_qa_Push.IsRequestReply);
}
else if (conzx_qa_Push.ReplyDate  ==  AttributeName[intIndex])
{
mstrReplyDate = value.ToString();
 AddUpdatedFld(conzx_qa_Push.ReplyDate);
}
}
}

/// <summary>
/// 推送d(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long PushId
{
get
{
return mlngPushId;
}
set
{
 mlngPushId = value;
//记录修改过的字段
 AddUpdatedFld(conzx_qa_Push.PushId);
}
}
/// <summary>
/// 提问Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxQuestionsId
{
get
{
return mstrzxQuestionsId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxQuestionsId = value;
}
else
{
 mstrzxQuestionsId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_qa_Push.zxQuestionsId);
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
 AddUpdatedFld(conzx_qa_Push.ReceiveUser);
}
}
/// <summary>
/// 接收日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ReceiveDate
{
get
{
return mstrReceiveDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrReceiveDate = value;
}
else
{
 mstrReceiveDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_qa_Push.ReceiveDate);
}
}
/// <summary>
/// 是否接收(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsReceive
{
get
{
return mbolIsReceive;
}
set
{
 mbolIsReceive = value;
//记录修改过的字段
 AddUpdatedFld(conzx_qa_Push.IsReceive);
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
 AddUpdatedFld(conzx_qa_Push.UpdDate);
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
 AddUpdatedFld(conzx_qa_Push.Memo);
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
 AddUpdatedFld(conzx_qa_Push.IdCurrEduCls);
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
 AddUpdatedFld(conzx_qa_Push.IsReply);
}
}
/// <summary>
/// 是否要求回复(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsRequestReply
{
get
{
return mbolIsRequestReply;
}
set
{
 mbolIsRequestReply = value;
//记录修改过的字段
 AddUpdatedFld(conzx_qa_Push.IsRequestReply);
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
 AddUpdatedFld(conzx_qa_Push.ReplyDate);
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
  return mlngPushId.ToString();
 }
 }
}
 /// <summary>
 /// 中学答疑推送_Copy(zx_qa_Push)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_qa_Push
{
public const string _CurrTabName = "zx_qa_Push"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PushId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PushId", "zxQuestionsId", "ReceiveUser", "ReceiveDate", "IsReceive", "UpdDate", "Memo", "IdCurrEduCls", "IsReply", "IsRequestReply", "ReplyDate"};
//以下是属性变量


 /// <summary>
 /// 常量:"PushId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PushId = "PushId";    //推送d

 /// <summary>
 /// 常量:"zxQuestionsId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxQuestionsId = "zxQuestionsId";    //提问Id

 /// <summary>
 /// 常量:"ReceiveUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReceiveUser = "ReceiveUser";    //接收用户

 /// <summary>
 /// 常量:"ReceiveDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReceiveDate = "ReceiveDate";    //接收日期

 /// <summary>
 /// 常量:"IsReceive"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsReceive = "IsReceive";    //是否接收

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
 /// 常量:"IsReply"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsReply = "IsReply";    //是否回复

 /// <summary>
 /// 常量:"IsRequestReply"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsRequestReply = "IsRequestReply";    //是否要求回复

 /// <summary>
 /// 常量:"ReplyDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ReplyDate = "ReplyDate";    //回复日期
}

}