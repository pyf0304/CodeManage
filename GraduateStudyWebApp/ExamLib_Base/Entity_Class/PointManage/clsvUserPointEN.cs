
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserPointEN
 表名:vUserPoint(01120306)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:23
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
 /// 表vUserPoint的关键字(PointId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PointId_vUserPoint
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
public K_PointId_vUserPoint(string strPointId)
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
 /// <returns>返回:[K_PointId_vUserPoint]类型的对象</returns>
public static implicit operator K_PointId_vUserPoint(string value)
{
return new K_PointId_vUserPoint(value);
}
}
 /// <summary>
 /// v用户点位(vUserPoint)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvUserPointEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vUserPoint"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PointId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 14;
public static string[] AttributeName = new string[] {"PointId", "UserId", "UserName", "UserStateId", "UserStateName", "IdXzCollege", "CollegeNameA", "IdentityID", "IdentityDesc", "Longitude", "Latitude", "Address", "UpdDate", "Memo"};

protected string mstrPointId;    //点位Id
protected string mstrUserId;    //用户ID
protected string mstrUserName;    //用户名
protected string mstrUserStateId;    //用户状态Id
protected string mstrUserStateName;    //用户状态名
protected string mstrIdXzCollege;    //学院流水号
protected string mstrCollegeNameA;    //学院名称简写
protected string mstrIdentityID;    //身份编号
protected string mstrIdentityDesc;    //身份描述
protected double? mdblLongitude;    //经度
protected double? mdblLatitude;    //纬度
protected string mstrAddress;    //地址
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvUserPointEN()
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
public clsvUserPointEN(string strPointId)
 {
strPointId = strPointId.Replace("'", "''");
if (strPointId.Length > 10)
{
throw new Exception("在表:vUserPoint中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPointId)  ==  true)
{
throw new Exception("在表:vUserPoint中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convUserPoint.PointId)
{
return mstrPointId;
}
else if (strAttributeName  ==  convUserPoint.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convUserPoint.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convUserPoint.UserStateId)
{
return mstrUserStateId;
}
else if (strAttributeName  ==  convUserPoint.UserStateName)
{
return mstrUserStateName;
}
else if (strAttributeName  ==  convUserPoint.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convUserPoint.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  convUserPoint.IdentityID)
{
return mstrIdentityID;
}
else if (strAttributeName  ==  convUserPoint.IdentityDesc)
{
return mstrIdentityDesc;
}
else if (strAttributeName  ==  convUserPoint.Longitude)
{
return mdblLongitude;
}
else if (strAttributeName  ==  convUserPoint.Latitude)
{
return mdblLatitude;
}
else if (strAttributeName  ==  convUserPoint.Address)
{
return mstrAddress;
}
else if (strAttributeName  ==  convUserPoint.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convUserPoint.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convUserPoint.PointId)
{
mstrPointId = value.ToString();
 AddUpdatedFld(convUserPoint.PointId);
}
else if (strAttributeName  ==  convUserPoint.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convUserPoint.UserId);
}
else if (strAttributeName  ==  convUserPoint.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convUserPoint.UserName);
}
else if (strAttributeName  ==  convUserPoint.UserStateId)
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(convUserPoint.UserStateId);
}
else if (strAttributeName  ==  convUserPoint.UserStateName)
{
mstrUserStateName = value.ToString();
 AddUpdatedFld(convUserPoint.UserStateName);
}
else if (strAttributeName  ==  convUserPoint.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convUserPoint.IdXzCollege);
}
else if (strAttributeName  ==  convUserPoint.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convUserPoint.CollegeNameA);
}
else if (strAttributeName  ==  convUserPoint.IdentityID)
{
mstrIdentityID = value.ToString();
 AddUpdatedFld(convUserPoint.IdentityID);
}
else if (strAttributeName  ==  convUserPoint.IdentityDesc)
{
mstrIdentityDesc = value.ToString();
 AddUpdatedFld(convUserPoint.IdentityDesc);
}
else if (strAttributeName  ==  convUserPoint.Longitude)
{
mdblLongitude = TransNullToDouble(value.ToString());
 AddUpdatedFld(convUserPoint.Longitude);
}
else if (strAttributeName  ==  convUserPoint.Latitude)
{
mdblLatitude = TransNullToDouble(value.ToString());
 AddUpdatedFld(convUserPoint.Latitude);
}
else if (strAttributeName  ==  convUserPoint.Address)
{
mstrAddress = value.ToString();
 AddUpdatedFld(convUserPoint.Address);
}
else if (strAttributeName  ==  convUserPoint.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convUserPoint.UpdDate);
}
else if (strAttributeName  ==  convUserPoint.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convUserPoint.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convUserPoint.PointId  ==  AttributeName[intIndex])
{
return mstrPointId;
}
else if (convUserPoint.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convUserPoint.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convUserPoint.UserStateId  ==  AttributeName[intIndex])
{
return mstrUserStateId;
}
else if (convUserPoint.UserStateName  ==  AttributeName[intIndex])
{
return mstrUserStateName;
}
else if (convUserPoint.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convUserPoint.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (convUserPoint.IdentityID  ==  AttributeName[intIndex])
{
return mstrIdentityID;
}
else if (convUserPoint.IdentityDesc  ==  AttributeName[intIndex])
{
return mstrIdentityDesc;
}
else if (convUserPoint.Longitude  ==  AttributeName[intIndex])
{
return mdblLongitude;
}
else if (convUserPoint.Latitude  ==  AttributeName[intIndex])
{
return mdblLatitude;
}
else if (convUserPoint.Address  ==  AttributeName[intIndex])
{
return mstrAddress;
}
else if (convUserPoint.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convUserPoint.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convUserPoint.PointId  ==  AttributeName[intIndex])
{
mstrPointId = value.ToString();
 AddUpdatedFld(convUserPoint.PointId);
}
else if (convUserPoint.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convUserPoint.UserId);
}
else if (convUserPoint.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convUserPoint.UserName);
}
else if (convUserPoint.UserStateId  ==  AttributeName[intIndex])
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(convUserPoint.UserStateId);
}
else if (convUserPoint.UserStateName  ==  AttributeName[intIndex])
{
mstrUserStateName = value.ToString();
 AddUpdatedFld(convUserPoint.UserStateName);
}
else if (convUserPoint.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convUserPoint.IdXzCollege);
}
else if (convUserPoint.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(convUserPoint.CollegeNameA);
}
else if (convUserPoint.IdentityID  ==  AttributeName[intIndex])
{
mstrIdentityID = value.ToString();
 AddUpdatedFld(convUserPoint.IdentityID);
}
else if (convUserPoint.IdentityDesc  ==  AttributeName[intIndex])
{
mstrIdentityDesc = value.ToString();
 AddUpdatedFld(convUserPoint.IdentityDesc);
}
else if (convUserPoint.Longitude  ==  AttributeName[intIndex])
{
mdblLongitude = TransNullToDouble(value.ToString());
 AddUpdatedFld(convUserPoint.Longitude);
}
else if (convUserPoint.Latitude  ==  AttributeName[intIndex])
{
mdblLatitude = TransNullToDouble(value.ToString());
 AddUpdatedFld(convUserPoint.Latitude);
}
else if (convUserPoint.Address  ==  AttributeName[intIndex])
{
mstrAddress = value.ToString();
 AddUpdatedFld(convUserPoint.Address);
}
else if (convUserPoint.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convUserPoint.UpdDate);
}
else if (convUserPoint.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convUserPoint.Memo);
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
 AddUpdatedFld(convUserPoint.PointId);
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
 AddUpdatedFld(convUserPoint.UserId);
}
}
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserName
{
get
{
return mstrUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserName = value;
}
else
{
 mstrUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserPoint.UserName);
}
}
/// <summary>
/// 用户状态Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserStateId
{
get
{
return mstrUserStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserStateId = value;
}
else
{
 mstrUserStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserPoint.UserStateId);
}
}
/// <summary>
/// 用户状态名(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserStateName
{
get
{
return mstrUserStateName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserStateName = value;
}
else
{
 mstrUserStateName = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserPoint.UserStateName);
}
}
/// <summary>
/// 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzCollege
{
get
{
return mstrIdXzCollege;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzCollege = value;
}
else
{
 mstrIdXzCollege = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserPoint.IdXzCollege);
}
}
/// <summary>
/// 学院名称简写(说明:;字段类型:varchar;字段长度:12;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeNameA
{
get
{
return mstrCollegeNameA;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeNameA = value;
}
else
{
 mstrCollegeNameA = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserPoint.CollegeNameA);
}
}
/// <summary>
/// 身份编号(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdentityID
{
get
{
return mstrIdentityID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdentityID = value;
}
else
{
 mstrIdentityID = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserPoint.IdentityID);
}
}
/// <summary>
/// 身份描述(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdentityDesc
{
get
{
return mstrIdentityDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdentityDesc = value;
}
else
{
 mstrIdentityDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(convUserPoint.IdentityDesc);
}
}
/// <summary>
/// 经度(说明:;字段类型:decimal;字段长度:12;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? Longitude
{
get
{
return mdblLongitude;
}
set
{
 mdblLongitude = value;
//记录修改过的字段
 AddUpdatedFld(convUserPoint.Longitude);
}
}
/// <summary>
/// 纬度(说明:;字段类型:decimal;字段长度:12;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double? Latitude
{
get
{
return mdblLatitude;
}
set
{
 mdblLatitude = value;
//记录修改过的字段
 AddUpdatedFld(convUserPoint.Latitude);
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
 AddUpdatedFld(convUserPoint.Address);
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
 AddUpdatedFld(convUserPoint.UpdDate);
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
 AddUpdatedFld(convUserPoint.Memo);
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
 /// v用户点位(vUserPoint)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convUserPoint
{
public const string _CurrTabName = "vUserPoint"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PointId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PointId", "UserId", "UserName", "UserStateId", "UserStateName", "IdXzCollege", "CollegeNameA", "IdentityID", "IdentityDesc", "Longitude", "Latitude", "Address", "UpdDate", "Memo"};
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
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"UserStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserStateId = "UserStateId";    //用户状态Id

 /// <summary>
 /// 常量:"UserStateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserStateName = "UserStateName";    //用户状态名

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"CollegeNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeNameA = "CollegeNameA";    //学院名称简写

 /// <summary>
 /// 常量:"IdentityID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdentityID = "IdentityID";    //身份编号

 /// <summary>
 /// 常量:"IdentityDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdentityDesc = "IdentityDesc";    //身份描述

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