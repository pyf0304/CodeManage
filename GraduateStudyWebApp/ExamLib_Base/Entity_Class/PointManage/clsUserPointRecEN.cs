
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserPointRecEN
 表名:UserPointRec(01120304)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:18
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:位置管理(PointManage)
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
 /// 表UserPointRec的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_UserPointRec
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
public K_mId_UserPointRec(long lngmId)
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
 /// <returns>返回:[K_mId_UserPointRec]类型的对象</returns>
public static implicit operator K_mId_UserPointRec(long value)
{
return new K_mId_UserPointRec(value);
}
}
 /// <summary>
 /// 用户点位记录(UserPointRec)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsUserPointRecEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "UserPointRec"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"mId", "PointId", "UserId", "PointTypeId", "Longitude", "Latitude", "Address", "PhoneModels", "PhoneOS", "IMEI", "UpdDate", "Memo"};

protected long mlngmId;    //mId
protected string mstrPointId;    //点位Id
protected string mstrUserId;    //用户ID
protected string mstrPointTypeId;    //点位类型Id
protected double mdblLongitude;    //经度
protected double mdblLatitude;    //纬度
protected string mstrAddress;    //地址
protected string mstrPhoneModels;    //手机型号
protected string mstrPhoneOS;    //手机系统
protected string mstrIMEI;    //IMEI
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsUserPointRecEN()
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
public clsUserPointRecEN(long lngmId)
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
if (strAttributeName  ==  conUserPointRec.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conUserPointRec.PointId)
{
return mstrPointId;
}
else if (strAttributeName  ==  conUserPointRec.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conUserPointRec.PointTypeId)
{
return mstrPointTypeId;
}
else if (strAttributeName  ==  conUserPointRec.Longitude)
{
return mdblLongitude;
}
else if (strAttributeName  ==  conUserPointRec.Latitude)
{
return mdblLatitude;
}
else if (strAttributeName  ==  conUserPointRec.Address)
{
return mstrAddress;
}
else if (strAttributeName  ==  conUserPointRec.PhoneModels)
{
return mstrPhoneModels;
}
else if (strAttributeName  ==  conUserPointRec.PhoneOS)
{
return mstrPhoneOS;
}
else if (strAttributeName  ==  conUserPointRec.IMEI)
{
return mstrIMEI;
}
else if (strAttributeName  ==  conUserPointRec.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conUserPointRec.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conUserPointRec.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserPointRec.mId);
}
else if (strAttributeName  ==  conUserPointRec.PointId)
{
mstrPointId = value.ToString();
 AddUpdatedFld(conUserPointRec.PointId);
}
else if (strAttributeName  ==  conUserPointRec.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUserPointRec.UserId);
}
else if (strAttributeName  ==  conUserPointRec.PointTypeId)
{
mstrPointTypeId = value.ToString();
 AddUpdatedFld(conUserPointRec.PointTypeId);
}
else if (strAttributeName  ==  conUserPointRec.Longitude)
{
mdblLongitude = TransNullToDouble(value.ToString());
 AddUpdatedFld(conUserPointRec.Longitude);
}
else if (strAttributeName  ==  conUserPointRec.Latitude)
{
mdblLatitude = TransNullToDouble(value.ToString());
 AddUpdatedFld(conUserPointRec.Latitude);
}
else if (strAttributeName  ==  conUserPointRec.Address)
{
mstrAddress = value.ToString();
 AddUpdatedFld(conUserPointRec.Address);
}
else if (strAttributeName  ==  conUserPointRec.PhoneModels)
{
mstrPhoneModels = value.ToString();
 AddUpdatedFld(conUserPointRec.PhoneModels);
}
else if (strAttributeName  ==  conUserPointRec.PhoneOS)
{
mstrPhoneOS = value.ToString();
 AddUpdatedFld(conUserPointRec.PhoneOS);
}
else if (strAttributeName  ==  conUserPointRec.IMEI)
{
mstrIMEI = value.ToString();
 AddUpdatedFld(conUserPointRec.IMEI);
}
else if (strAttributeName  ==  conUserPointRec.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conUserPointRec.UpdDate);
}
else if (strAttributeName  ==  conUserPointRec.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserPointRec.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conUserPointRec.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conUserPointRec.PointId  ==  AttributeName[intIndex])
{
return mstrPointId;
}
else if (conUserPointRec.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conUserPointRec.PointTypeId  ==  AttributeName[intIndex])
{
return mstrPointTypeId;
}
else if (conUserPointRec.Longitude  ==  AttributeName[intIndex])
{
return mdblLongitude;
}
else if (conUserPointRec.Latitude  ==  AttributeName[intIndex])
{
return mdblLatitude;
}
else if (conUserPointRec.Address  ==  AttributeName[intIndex])
{
return mstrAddress;
}
else if (conUserPointRec.PhoneModels  ==  AttributeName[intIndex])
{
return mstrPhoneModels;
}
else if (conUserPointRec.PhoneOS  ==  AttributeName[intIndex])
{
return mstrPhoneOS;
}
else if (conUserPointRec.IMEI  ==  AttributeName[intIndex])
{
return mstrIMEI;
}
else if (conUserPointRec.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conUserPointRec.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conUserPointRec.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conUserPointRec.mId);
}
else if (conUserPointRec.PointId  ==  AttributeName[intIndex])
{
mstrPointId = value.ToString();
 AddUpdatedFld(conUserPointRec.PointId);
}
else if (conUserPointRec.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUserPointRec.UserId);
}
else if (conUserPointRec.PointTypeId  ==  AttributeName[intIndex])
{
mstrPointTypeId = value.ToString();
 AddUpdatedFld(conUserPointRec.PointTypeId);
}
else if (conUserPointRec.Longitude  ==  AttributeName[intIndex])
{
mdblLongitude = TransNullToDouble(value.ToString());
 AddUpdatedFld(conUserPointRec.Longitude);
}
else if (conUserPointRec.Latitude  ==  AttributeName[intIndex])
{
mdblLatitude = TransNullToDouble(value.ToString());
 AddUpdatedFld(conUserPointRec.Latitude);
}
else if (conUserPointRec.Address  ==  AttributeName[intIndex])
{
mstrAddress = value.ToString();
 AddUpdatedFld(conUserPointRec.Address);
}
else if (conUserPointRec.PhoneModels  ==  AttributeName[intIndex])
{
mstrPhoneModels = value.ToString();
 AddUpdatedFld(conUserPointRec.PhoneModels);
}
else if (conUserPointRec.PhoneOS  ==  AttributeName[intIndex])
{
mstrPhoneOS = value.ToString();
 AddUpdatedFld(conUserPointRec.PhoneOS);
}
else if (conUserPointRec.IMEI  ==  AttributeName[intIndex])
{
mstrIMEI = value.ToString();
 AddUpdatedFld(conUserPointRec.IMEI);
}
else if (conUserPointRec.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conUserPointRec.UpdDate);
}
else if (conUserPointRec.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserPointRec.Memo);
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
 AddUpdatedFld(conUserPointRec.mId);
}
}
/// <summary>
/// 点位Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PointId
{
get
{
return mstrPointId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPointId = value;
}
else
{
 mstrPointId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserPointRec.PointId);
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
 AddUpdatedFld(conUserPointRec.UserId);
}
}
/// <summary>
/// 点位类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PointTypeId
{
get
{
return mstrPointTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPointTypeId = value;
}
else
{
 mstrPointTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserPointRec.PointTypeId);
}
}
/// <summary>
/// 经度(说明:;字段类型:decimal;字段长度:12;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double Longitude
{
get
{
return mdblLongitude;
}
set
{
 mdblLongitude = value;
//记录修改过的字段
 AddUpdatedFld(conUserPointRec.Longitude);
}
}
/// <summary>
/// 纬度(说明:;字段类型:decimal;字段长度:12;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double Latitude
{
get
{
return mdblLatitude;
}
set
{
 mdblLatitude = value;
//记录修改过的字段
 AddUpdatedFld(conUserPointRec.Latitude);
}
}
/// <summary>
/// 地址(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Address
{
get
{
return mstrAddress;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAddress = value;
}
else
{
 mstrAddress = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserPointRec.Address);
}
}
/// <summary>
/// 手机型号(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PhoneModels
{
get
{
return mstrPhoneModels;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPhoneModels = value;
}
else
{
 mstrPhoneModels = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserPointRec.PhoneModels);
}
}
/// <summary>
/// 手机系统(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PhoneOS
{
get
{
return mstrPhoneOS;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPhoneOS = value;
}
else
{
 mstrPhoneOS = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserPointRec.PhoneOS);
}
}
/// <summary>
/// IMEI(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IMEI
{
get
{
return mstrIMEI;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIMEI = value;
}
else
{
 mstrIMEI = value;
}
//记录修改过的字段
 AddUpdatedFld(conUserPointRec.IMEI);
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
 AddUpdatedFld(conUserPointRec.UpdDate);
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
 AddUpdatedFld(conUserPointRec.Memo);
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
 /// 用户点位记录(UserPointRec)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conUserPointRec
{
public const string _CurrTabName = "UserPointRec"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "PointId", "UserId", "PointTypeId", "Longitude", "Latitude", "Address", "PhoneModels", "PhoneOS", "IMEI", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"PointId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PointId = "PointId";    //点位Id

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"PointTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PointTypeId = "PointTypeId";    //点位类型Id

 /// <summary>
 /// 常量:"Longitude"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Longitude = "Longitude";    //经度

 /// <summary>
 /// 常量:"Latitude"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Latitude = "Latitude";    //纬度

 /// <summary>
 /// 常量:"Address"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Address = "Address";    //地址

 /// <summary>
 /// 常量:"PhoneModels"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PhoneModels = "PhoneModels";    //手机型号

 /// <summary>
 /// 常量:"PhoneOS"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PhoneOS = "PhoneOS";    //手机系统

 /// <summary>
 /// 常量:"IMEI"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IMEI = "IMEI";    //IMEI

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