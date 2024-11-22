
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsShortMessageSendSateEN
 表名:ShortMessageSendSate(01120287)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:43:25
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:新闻公告(NewsAnn)
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
 /// 表ShortMessageSendSate的关键字(ShortMessageSendSateID)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ShortMessageSendSateID_ShortMessageSendSate
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strShortMessageSendSateID">表关键字</param>
public K_ShortMessageSendSateID_ShortMessageSendSate(string strShortMessageSendSateID)
{
if (IsValid(strShortMessageSendSateID)) Value = strShortMessageSendSateID;
else
{
Value = null;
}
}
private static bool IsValid(string strShortMessageSendSateID)
{
if (string.IsNullOrEmpty(strShortMessageSendSateID) == true) return false;
if (strShortMessageSendSateID.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ShortMessageSendSateID_ShortMessageSendSate]类型的对象</returns>
public static implicit operator K_ShortMessageSendSateID_ShortMessageSendSate(string value)
{
return new K_ShortMessageSendSateID_ShortMessageSendSate(value);
}
}
 /// <summary>
 /// 短信消息发送状态(ShortMessageSendSate)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsShortMessageSendSateEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ShortMessageSendSate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ShortMessageSendSateID"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"ShortMessageSendSateID", "ShortMessageSendSateName", "UpdUser", "Memo", "UpdDate"};

protected string mstrShortMessageSendSateID;    //消息发送状态Id
protected string mstrShortMessageSendSateName;    //短消息发送状态名称
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrUpdDate;    //修改日期

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsShortMessageSendSateEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ShortMessageSendSateID");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strShortMessageSendSateID">关键字:消息发送状态Id</param>
public clsShortMessageSendSateEN(string strShortMessageSendSateID)
 {
strShortMessageSendSateID = strShortMessageSendSateID.Replace("'", "''");
if (strShortMessageSendSateID.Length > 8)
{
throw new Exception("在表:ShortMessageSendSate中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strShortMessageSendSateID)  ==  true)
{
throw new Exception("在表:ShortMessageSendSate中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strShortMessageSendSateID);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrShortMessageSendSateID = strShortMessageSendSateID;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ShortMessageSendSateID");
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
if (strAttributeName  ==  conShortMessageSendSate.ShortMessageSendSateID)
{
return mstrShortMessageSendSateID;
}
else if (strAttributeName  ==  conShortMessageSendSate.ShortMessageSendSateName)
{
return mstrShortMessageSendSateName;
}
else if (strAttributeName  ==  conShortMessageSendSate.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conShortMessageSendSate.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conShortMessageSendSate.UpdDate)
{
return mstrUpdDate;
}
return null;
}
set
{
if (strAttributeName  ==  conShortMessageSendSate.ShortMessageSendSateID)
{
mstrShortMessageSendSateID = value.ToString();
 AddUpdatedFld(conShortMessageSendSate.ShortMessageSendSateID);
}
else if (strAttributeName  ==  conShortMessageSendSate.ShortMessageSendSateName)
{
mstrShortMessageSendSateName = value.ToString();
 AddUpdatedFld(conShortMessageSendSate.ShortMessageSendSateName);
}
else if (strAttributeName  ==  conShortMessageSendSate.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conShortMessageSendSate.UpdUser);
}
else if (strAttributeName  ==  conShortMessageSendSate.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conShortMessageSendSate.Memo);
}
else if (strAttributeName  ==  conShortMessageSendSate.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conShortMessageSendSate.UpdDate);
}
}
}
public object this[int intIndex]
{
get
{
if (conShortMessageSendSate.ShortMessageSendSateID  ==  AttributeName[intIndex])
{
return mstrShortMessageSendSateID;
}
else if (conShortMessageSendSate.ShortMessageSendSateName  ==  AttributeName[intIndex])
{
return mstrShortMessageSendSateName;
}
else if (conShortMessageSendSate.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conShortMessageSendSate.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conShortMessageSendSate.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
return null;
}
set
{
if (conShortMessageSendSate.ShortMessageSendSateID  ==  AttributeName[intIndex])
{
mstrShortMessageSendSateID = value.ToString();
 AddUpdatedFld(conShortMessageSendSate.ShortMessageSendSateID);
}
else if (conShortMessageSendSate.ShortMessageSendSateName  ==  AttributeName[intIndex])
{
mstrShortMessageSendSateName = value.ToString();
 AddUpdatedFld(conShortMessageSendSate.ShortMessageSendSateName);
}
else if (conShortMessageSendSate.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conShortMessageSendSate.UpdUser);
}
else if (conShortMessageSendSate.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conShortMessageSendSate.Memo);
}
else if (conShortMessageSendSate.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conShortMessageSendSate.UpdDate);
}
}
}

/// <summary>
/// 消息发送状态Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ShortMessageSendSateID
{
get
{
return mstrShortMessageSendSateID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrShortMessageSendSateID = value;
}
else
{
 mstrShortMessageSendSateID = value;
}
//记录修改过的字段
 AddUpdatedFld(conShortMessageSendSate.ShortMessageSendSateID);
}
}
/// <summary>
/// 短消息发送状态名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ShortMessageSendSateName
{
get
{
return mstrShortMessageSendSateName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrShortMessageSendSateName = value;
}
else
{
 mstrShortMessageSendSateName = value;
}
//记录修改过的字段
 AddUpdatedFld(conShortMessageSendSate.ShortMessageSendSateName);
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
 AddUpdatedFld(conShortMessageSendSate.UpdUser);
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
 AddUpdatedFld(conShortMessageSendSate.Memo);
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
 AddUpdatedFld(conShortMessageSendSate.UpdDate);
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
  return mstrShortMessageSendSateID;
 }
 }
}
 /// <summary>
 /// 短信消息发送状态(ShortMessageSendSate)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conShortMessageSendSate
{
public const string _CurrTabName = "ShortMessageSendSate"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ShortMessageSendSateID"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ShortMessageSendSateID", "ShortMessageSendSateName", "UpdUser", "Memo", "UpdDate"};
//以下是属性变量


 /// <summary>
 /// 常量:"ShortMessageSendSateID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ShortMessageSendSateID = "ShortMessageSendSateID";    //消息发送状态Id

 /// <summary>
 /// 常量:"ShortMessageSendSateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ShortMessageSendSateName = "ShortMessageSendSateName";    //短消息发送状态名称

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期
}

}