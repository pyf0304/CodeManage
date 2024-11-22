
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserDefaValueEN
 表名:UserDefaValue(01120203)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:08
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日志管理(LogManage)
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
 /// 表UserDefaValue的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_UserDefaValue
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
public K_mId_UserDefaValue(long lngmId)
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
 /// <returns>返回:[K_mId_UserDefaValue]类型的对象</returns>
public static implicit operator K_mId_UserDefaValue(long value)
{
return new K_mId_UserDefaValue(value);
}
}
 /// <summary>
 /// 用户缺省值(UserDefaValue)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsUserDefaValueEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "UserDefaValue"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"mId", "DefaValNameId", "UserId", "UserDefaValue", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrDefaValNameId;    //缺省值名称Id
protected string mstrUserId;    //用户ID
protected string mstrUserDefaValue;    //用户缺省值
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsUserDefaValueEN()
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
public clsUserDefaValueEN(long lngmId)
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
if (strAttributeName  ==  conUserDefaValue.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conUserDefaValue.DefaValNameId)
{
return mstrDefaValNameId;
}
else if (strAttributeName  ==  conUserDefaValue.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conUserDefaValue.UserDefaValue)
{
return mstrUserDefaValue;
}
else if (strAttributeName  ==  conUserDefaValue.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conUserDefaValue.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conUserDefaValue.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conUserDefaValue.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserDefaValue.mId);
}
else if (strAttributeName  ==  conUserDefaValue.DefaValNameId)
{
mstrDefaValNameId = value.ToString();
 AddUpdatedFld(conUserDefaValue.DefaValNameId);
}
else if (strAttributeName  ==  conUserDefaValue.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUserDefaValue.UserId);
}
else if (strAttributeName  ==  conUserDefaValue.UserDefaValue)
{
mstrUserDefaValue = value.ToString();
 AddUpdatedFld(conUserDefaValue.UserDefaValue);
}
else if (strAttributeName  ==  conUserDefaValue.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conUserDefaValue.UpdDate);
}
else if (strAttributeName  ==  conUserDefaValue.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conUserDefaValue.UpdUser);
}
else if (strAttributeName  ==  conUserDefaValue.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserDefaValue.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conUserDefaValue.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conUserDefaValue.DefaValNameId  ==  AttributeName[intIndex])
{
return mstrDefaValNameId;
}
else if (conUserDefaValue.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conUserDefaValue.UserDefaValue  ==  AttributeName[intIndex])
{
return mstrUserDefaValue;
}
else if (conUserDefaValue.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conUserDefaValue.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conUserDefaValue.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conUserDefaValue.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserDefaValue.mId);
}
else if (conUserDefaValue.DefaValNameId  ==  AttributeName[intIndex])
{
mstrDefaValNameId = value.ToString();
 AddUpdatedFld(conUserDefaValue.DefaValNameId);
}
else if (conUserDefaValue.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUserDefaValue.UserId);
}
else if (conUserDefaValue.UserDefaValue  ==  AttributeName[intIndex])
{
mstrUserDefaValue = value.ToString();
 AddUpdatedFld(conUserDefaValue.UserDefaValue);
}
else if (conUserDefaValue.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conUserDefaValue.UpdDate);
}
else if (conUserDefaValue.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conUserDefaValue.UpdUser);
}
else if (conUserDefaValue.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserDefaValue.Memo);
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
 AddUpdatedFld(conUserDefaValue.mId);
}
}
/// <summary>
/// 缺省值名称Id(说明:;字段类型:varchar;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DefaValNameId
{
get
{
return mstrDefaValNameId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDefaValNameId = value;
}
else
{
 mstrDefaValNameId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserDefaValue.DefaValNameId);
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
 AddUpdatedFld(conUserDefaValue.UserId);
}
}
/// <summary>
/// 用户缺省值(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserDefaValue
{
get
{
return mstrUserDefaValue;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserDefaValue = value;
}
else
{
 mstrUserDefaValue = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserDefaValue.UserDefaValue);
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
 AddUpdatedFld(conUserDefaValue.UpdDate);
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
 AddUpdatedFld(conUserDefaValue.UpdUser);
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
 AddUpdatedFld(conUserDefaValue.Memo);
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
 /// 用户缺省值(UserDefaValue)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conUserDefaValue
{
public const string _CurrTabName = "UserDefaValue"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "DefaValNameId", "UserId", "UserDefaValue", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"DefaValNameId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaValNameId = "DefaValNameId";    //缺省值名称Id

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"UserDefaValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserDefaValue = "UserDefaValue";    //用户缺省值

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

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
}

}