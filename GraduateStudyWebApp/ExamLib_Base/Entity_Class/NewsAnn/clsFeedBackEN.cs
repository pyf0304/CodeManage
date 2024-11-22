
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFeedBackEN
 表名:FeedBack(01120279)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:10:19
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:新闻公告(NewsAnn)
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
 /// 表FeedBack的关键字(FeedBackId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FeedBackId_FeedBack
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngFeedBackId">表关键字</param>
public K_FeedBackId_FeedBack(long lngFeedBackId)
{
if (IsValid(lngFeedBackId)) Value = lngFeedBackId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngFeedBackId)
{
if (lngFeedBackId == 0) return false;
if (lngFeedBackId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FeedBackId_FeedBack]类型的对象</returns>
public static implicit operator K_FeedBackId_FeedBack(long value)
{
return new K_FeedBackId_FeedBack(value);
}
}
 /// <summary>
 /// 反馈意见(FeedBack)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFeedBackEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FeedBack"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FeedBackId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"FeedBackId", "NickName", "FeedBackNumber", "FeedBackContent", "Email", "Telephone", "UpdDate", "Memo", "UpdUser"};

protected long mlngFeedBackId;    //FeedBackId
protected string mstrNickName;    //昵称
protected string mstrFeedBackNumber;    //FeedBackNumber
protected string mstrFeedBackContent;    //FeedBackContent
protected string mstrEmail;    //电子邮箱
protected string mstrTelephone;    //Telephone
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrUpdUser;    //修改人

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsFeedBackEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FeedBackId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngFeedBackId">关键字:FeedBackId</param>
public clsFeedBackEN(long lngFeedBackId)
 {
 if (lngFeedBackId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngFeedBackId = lngFeedBackId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FeedBackId");
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
if (strAttributeName  ==  conFeedBack.FeedBackId)
{
return mlngFeedBackId;
}
else if (strAttributeName  ==  conFeedBack.NickName)
{
return mstrNickName;
}
else if (strAttributeName  ==  conFeedBack.FeedBackNumber)
{
return mstrFeedBackNumber;
}
else if (strAttributeName  ==  conFeedBack.FeedBackContent)
{
return mstrFeedBackContent;
}
else if (strAttributeName  ==  conFeedBack.Email)
{
return mstrEmail;
}
else if (strAttributeName  ==  conFeedBack.Telephone)
{
return mstrTelephone;
}
else if (strAttributeName  ==  conFeedBack.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conFeedBack.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conFeedBack.UpdUser)
{
return mstrUpdUser;
}
return null;
}
set
{
if (strAttributeName  ==  conFeedBack.FeedBackId)
{
mlngFeedBackId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFeedBack.FeedBackId);
}
else if (strAttributeName  ==  conFeedBack.NickName)
{
mstrNickName = value.ToString();
 AddUpdatedFld(conFeedBack.NickName);
}
else if (strAttributeName  ==  conFeedBack.FeedBackNumber)
{
mstrFeedBackNumber = value.ToString();
 AddUpdatedFld(conFeedBack.FeedBackNumber);
}
else if (strAttributeName  ==  conFeedBack.FeedBackContent)
{
mstrFeedBackContent = value.ToString();
 AddUpdatedFld(conFeedBack.FeedBackContent);
}
else if (strAttributeName  ==  conFeedBack.Email)
{
mstrEmail = value.ToString();
 AddUpdatedFld(conFeedBack.Email);
}
else if (strAttributeName  ==  conFeedBack.Telephone)
{
mstrTelephone = value.ToString();
 AddUpdatedFld(conFeedBack.Telephone);
}
else if (strAttributeName  ==  conFeedBack.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFeedBack.UpdDate);
}
else if (strAttributeName  ==  conFeedBack.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFeedBack.Memo);
}
else if (strAttributeName  ==  conFeedBack.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFeedBack.UpdUser);
}
}
}
public object this[int intIndex]
{
get
{
if (conFeedBack.FeedBackId  ==  AttributeName[intIndex])
{
return mlngFeedBackId;
}
else if (conFeedBack.NickName  ==  AttributeName[intIndex])
{
return mstrNickName;
}
else if (conFeedBack.FeedBackNumber  ==  AttributeName[intIndex])
{
return mstrFeedBackNumber;
}
else if (conFeedBack.FeedBackContent  ==  AttributeName[intIndex])
{
return mstrFeedBackContent;
}
else if (conFeedBack.Email  ==  AttributeName[intIndex])
{
return mstrEmail;
}
else if (conFeedBack.Telephone  ==  AttributeName[intIndex])
{
return mstrTelephone;
}
else if (conFeedBack.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conFeedBack.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conFeedBack.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
return null;
}
set
{
if (conFeedBack.FeedBackId  ==  AttributeName[intIndex])
{
mlngFeedBackId = TransNullToInt(value.ToString());
 AddUpdatedFld(conFeedBack.FeedBackId);
}
else if (conFeedBack.NickName  ==  AttributeName[intIndex])
{
mstrNickName = value.ToString();
 AddUpdatedFld(conFeedBack.NickName);
}
else if (conFeedBack.FeedBackNumber  ==  AttributeName[intIndex])
{
mstrFeedBackNumber = value.ToString();
 AddUpdatedFld(conFeedBack.FeedBackNumber);
}
else if (conFeedBack.FeedBackContent  ==  AttributeName[intIndex])
{
mstrFeedBackContent = value.ToString();
 AddUpdatedFld(conFeedBack.FeedBackContent);
}
else if (conFeedBack.Email  ==  AttributeName[intIndex])
{
mstrEmail = value.ToString();
 AddUpdatedFld(conFeedBack.Email);
}
else if (conFeedBack.Telephone  ==  AttributeName[intIndex])
{
mstrTelephone = value.ToString();
 AddUpdatedFld(conFeedBack.Telephone);
}
else if (conFeedBack.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFeedBack.UpdDate);
}
else if (conFeedBack.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFeedBack.Memo);
}
else if (conFeedBack.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFeedBack.UpdUser);
}
}
}

/// <summary>
/// FeedBackId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long FeedBackId
{
get
{
return mlngFeedBackId;
}
set
{
 mlngFeedBackId = value;
//记录修改过的字段
 AddUpdatedFld(conFeedBack.FeedBackId);
}
}
/// <summary>
/// 昵称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string NickName
{
get
{
return mstrNickName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrNickName = value;
}
else
{
 mstrNickName = value;
}
//记录修改过的字段
 AddUpdatedFld(conFeedBack.NickName);
}
}
/// <summary>
/// FeedBackNumber(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeedBackNumber
{
get
{
return mstrFeedBackNumber;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeedBackNumber = value;
}
else
{
 mstrFeedBackNumber = value;
}
//记录修改过的字段
 AddUpdatedFld(conFeedBack.FeedBackNumber);
}
}
/// <summary>
/// FeedBackContent(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FeedBackContent
{
get
{
return mstrFeedBackContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFeedBackContent = value;
}
else
{
 mstrFeedBackContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conFeedBack.FeedBackContent);
}
}
/// <summary>
/// 电子邮箱(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Email
{
get
{
return mstrEmail;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEmail = value;
}
else
{
 mstrEmail = value;
}
//记录修改过的字段
 AddUpdatedFld(conFeedBack.Email);
}
}
/// <summary>
/// Telephone(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Telephone
{
get
{
return mstrTelephone;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTelephone = value;
}
else
{
 mstrTelephone = value;
}
//记录修改过的字段
 AddUpdatedFld(conFeedBack.Telephone);
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
 AddUpdatedFld(conFeedBack.UpdDate);
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
 AddUpdatedFld(conFeedBack.Memo);
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
 AddUpdatedFld(conFeedBack.UpdUser);
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
  return mlngFeedBackId.ToString();
 }
 }
}
 /// <summary>
 /// 反馈意见(FeedBack)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFeedBack
{
public const string _CurrTabName = "FeedBack"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FeedBackId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"FeedBackId", "NickName", "FeedBackNumber", "FeedBackContent", "Email", "Telephone", "UpdDate", "Memo", "UpdUser"};
//以下是属性变量


 /// <summary>
 /// 常量:"FeedBackId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeedBackId = "FeedBackId";    //FeedBackId

 /// <summary>
 /// 常量:"NickName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string NickName = "NickName";    //昵称

 /// <summary>
 /// 常量:"FeedBackNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeedBackNumber = "FeedBackNumber";    //FeedBackNumber

 /// <summary>
 /// 常量:"FeedBackContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FeedBackContent = "FeedBackContent";    //FeedBackContent

 /// <summary>
 /// 常量:"Email"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Email = "Email";    //电子邮箱

 /// <summary>
 /// 常量:"Telephone"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Telephone = "Telephone";    //Telephone

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
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人
}

}