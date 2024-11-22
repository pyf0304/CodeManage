
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserPointEN
 表名:UserPoint(01120303)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:20:25
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:位置管理(PointManage)
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
 /// 表UserPoint的关键字(PointId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PointId_UserPoint
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPointId">表关键字</param>
public K_PointId_UserPoint(string strPointId)
{
if (IsValid(strPointId)) Value = strPointId;
else
{
Value = null;
}
}
private static bool IsValid(string strPointId)
{
if (string.IsNullOrEmpty(strPointId) == true) return false;
if (strPointId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PointId_UserPoint]类型的对象</returns>
public static implicit operator K_PointId_UserPoint(string value)
{
return new K_PointId_UserPoint(value);
}
}
 /// <summary>
 /// 用户点位(UserPoint)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsUserPointEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "UserPoint"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PointId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"PointId", "UserId", "Longitude", "Latitude", "Address", "UpdDate", "Memo"};

protected string mstrPointId;    //点位Id
protected string mstrUserId;    //用户ID
protected double mdblLongitude;    //经度
protected double mdblLatitude;    //纬度
protected string mstrAddress;    //地址
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsUserPointEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PointId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strPointId">关键字:点位Id</param>
public clsUserPointEN(string strPointId)
 {
strPointId = strPointId.Replace("'", "''");
if (strPointId.Length > 10)
{
throw new Exception("在表:UserPoint中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPointId)  ==  true)
{
throw new Exception("在表:UserPoint中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPointId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPointId = strPointId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PointId");
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
if (strAttributeName  ==  conUserPoint.PointId)
{
return mstrPointId;
}
else if (strAttributeName  ==  conUserPoint.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conUserPoint.Longitude)
{
return mdblLongitude;
}
else if (strAttributeName  ==  conUserPoint.Latitude)
{
return mdblLatitude;
}
else if (strAttributeName  ==  conUserPoint.Address)
{
return mstrAddress;
}
else if (strAttributeName  ==  conUserPoint.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conUserPoint.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conUserPoint.PointId)
{
mstrPointId = value.ToString();
 AddUpdatedFld(conUserPoint.PointId);
}
else if (strAttributeName  ==  conUserPoint.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUserPoint.UserId);
}
else if (strAttributeName  ==  conUserPoint.Longitude)
{
mdblLongitude = TransNullToDouble(value.ToString());
 AddUpdatedFld(conUserPoint.Longitude);
}
else if (strAttributeName  ==  conUserPoint.Latitude)
{
mdblLatitude = TransNullToDouble(value.ToString());
 AddUpdatedFld(conUserPoint.Latitude);
}
else if (strAttributeName  ==  conUserPoint.Address)
{
mstrAddress = value.ToString();
 AddUpdatedFld(conUserPoint.Address);
}
else if (strAttributeName  ==  conUserPoint.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conUserPoint.UpdDate);
}
else if (strAttributeName  ==  conUserPoint.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserPoint.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conUserPoint.PointId  ==  AttributeName[intIndex])
{
return mstrPointId;
}
else if (conUserPoint.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conUserPoint.Longitude  ==  AttributeName[intIndex])
{
return mdblLongitude;
}
else if (conUserPoint.Latitude  ==  AttributeName[intIndex])
{
return mdblLatitude;
}
else if (conUserPoint.Address  ==  AttributeName[intIndex])
{
return mstrAddress;
}
else if (conUserPoint.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conUserPoint.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conUserPoint.PointId  ==  AttributeName[intIndex])
{
mstrPointId = value.ToString();
 AddUpdatedFld(conUserPoint.PointId);
}
else if (conUserPoint.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conUserPoint.UserId);
}
else if (conUserPoint.Longitude  ==  AttributeName[intIndex])
{
mdblLongitude = TransNullToDouble(value.ToString());
 AddUpdatedFld(conUserPoint.Longitude);
}
else if (conUserPoint.Latitude  ==  AttributeName[intIndex])
{
mdblLatitude = TransNullToDouble(value.ToString());
 AddUpdatedFld(conUserPoint.Latitude);
}
else if (conUserPoint.Address  ==  AttributeName[intIndex])
{
mstrAddress = value.ToString();
 AddUpdatedFld(conUserPoint.Address);
}
else if (conUserPoint.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conUserPoint.UpdDate);
}
else if (conUserPoint.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conUserPoint.Memo);
}
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
 AddUpdatedFld(conUserPoint.PointId);
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
 AddUpdatedFld(conUserPoint.UserId);
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
 AddUpdatedFld(conUserPoint.Longitude);
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
 AddUpdatedFld(conUserPoint.Latitude);
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
 AddUpdatedFld(conUserPoint.Address);
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
 AddUpdatedFld(conUserPoint.UpdDate);
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
 AddUpdatedFld(conUserPoint.Memo);
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
  return mstrPointId;
 }
 }
}
 /// <summary>
 /// 用户点位(UserPoint)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conUserPoint
{
public const string _CurrTabName = "UserPoint"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PointId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PointId", "UserId", "Longitude", "Latitude", "Address", "UpdDate", "Memo"};
//以下是属性变量


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