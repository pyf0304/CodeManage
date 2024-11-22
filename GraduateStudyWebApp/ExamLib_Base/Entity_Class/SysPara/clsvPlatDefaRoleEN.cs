
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPlatDefaRoleEN
 表名:vPlatDefaRole(01120232)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:49:31
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
 /// 表vPlatDefaRole的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vPlatDefaRole
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
public K_mId_vPlatDefaRole(long lngmId)
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
 /// <returns>返回:[K_mId_vPlatDefaRole]类型的对象</returns>
public static implicit operator K_mId_vPlatDefaRole(long value)
{
return new K_mId_vPlatDefaRole(value);
}
}
 /// <summary>
 /// v平台默认角色(vPlatDefaRole)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvPlatDefaRoleEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vPlatDefaRole"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"mId", "IdSchool", "SchoolId", "IsCurrentUse", "SchoolName", "PersonType", "PrjId", "RoleId", "Memo"};

protected long mlngmId;    //mId
protected string mstrIdSchool;    //学校流水号
protected string mstrSchoolId;    //学校编号
protected bool mbolIsCurrentUse;    //是否当前使用
protected string mstrSchoolName;    //学校名称
protected string mstrPersonType;    //人员类别
protected string mstrPrjId;    //PrjId
protected string mstrRoleId;    //角色Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvPlatDefaRoleEN()
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
public clsvPlatDefaRoleEN(long lngmId)
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
if (strAttributeName  ==  convPlatDefaRole.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convPlatDefaRole.IdSchool)
{
return mstrIdSchool;
}
else if (strAttributeName  ==  convPlatDefaRole.SchoolId)
{
return mstrSchoolId;
}
else if (strAttributeName  ==  convPlatDefaRole.IsCurrentUse)
{
return mbolIsCurrentUse;
}
else if (strAttributeName  ==  convPlatDefaRole.SchoolName)
{
return mstrSchoolName;
}
else if (strAttributeName  ==  convPlatDefaRole.PersonType)
{
return mstrPersonType;
}
else if (strAttributeName  ==  convPlatDefaRole.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convPlatDefaRole.RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  convPlatDefaRole.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convPlatDefaRole.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convPlatDefaRole.mId);
}
else if (strAttributeName  ==  convPlatDefaRole.IdSchool)
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(convPlatDefaRole.IdSchool);
}
else if (strAttributeName  ==  convPlatDefaRole.SchoolId)
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(convPlatDefaRole.SchoolId);
}
else if (strAttributeName  ==  convPlatDefaRole.IsCurrentUse)
{
mbolIsCurrentUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convPlatDefaRole.IsCurrentUse);
}
else if (strAttributeName  ==  convPlatDefaRole.SchoolName)
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(convPlatDefaRole.SchoolName);
}
else if (strAttributeName  ==  convPlatDefaRole.PersonType)
{
mstrPersonType = value.ToString();
 AddUpdatedFld(convPlatDefaRole.PersonType);
}
else if (strAttributeName  ==  convPlatDefaRole.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convPlatDefaRole.PrjId);
}
else if (strAttributeName  ==  convPlatDefaRole.RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(convPlatDefaRole.RoleId);
}
else if (strAttributeName  ==  convPlatDefaRole.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPlatDefaRole.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convPlatDefaRole.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convPlatDefaRole.IdSchool  ==  AttributeName[intIndex])
{
return mstrIdSchool;
}
else if (convPlatDefaRole.SchoolId  ==  AttributeName[intIndex])
{
return mstrSchoolId;
}
else if (convPlatDefaRole.IsCurrentUse  ==  AttributeName[intIndex])
{
return mbolIsCurrentUse;
}
else if (convPlatDefaRole.SchoolName  ==  AttributeName[intIndex])
{
return mstrSchoolName;
}
else if (convPlatDefaRole.PersonType  ==  AttributeName[intIndex])
{
return mstrPersonType;
}
else if (convPlatDefaRole.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convPlatDefaRole.RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (convPlatDefaRole.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convPlatDefaRole.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convPlatDefaRole.mId);
}
else if (convPlatDefaRole.IdSchool  ==  AttributeName[intIndex])
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(convPlatDefaRole.IdSchool);
}
else if (convPlatDefaRole.SchoolId  ==  AttributeName[intIndex])
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(convPlatDefaRole.SchoolId);
}
else if (convPlatDefaRole.IsCurrentUse  ==  AttributeName[intIndex])
{
mbolIsCurrentUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convPlatDefaRole.IsCurrentUse);
}
else if (convPlatDefaRole.SchoolName  ==  AttributeName[intIndex])
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(convPlatDefaRole.SchoolName);
}
else if (convPlatDefaRole.PersonType  ==  AttributeName[intIndex])
{
mstrPersonType = value.ToString();
 AddUpdatedFld(convPlatDefaRole.PersonType);
}
else if (convPlatDefaRole.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convPlatDefaRole.PrjId);
}
else if (convPlatDefaRole.RoleId  ==  AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(convPlatDefaRole.RoleId);
}
else if (convPlatDefaRole.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convPlatDefaRole.Memo);
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
 AddUpdatedFld(convPlatDefaRole.mId);
}
}
/// <summary>
/// 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSchool
{
get
{
return mstrIdSchool;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSchool = value;
}
else
{
 mstrIdSchool = value;
}
//记录修改过的字段
 AddUpdatedFld(convPlatDefaRole.IdSchool);
}
}
/// <summary>
/// 学校编号(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolId
{
get
{
return mstrSchoolId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolId = value;
}
else
{
 mstrSchoolId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPlatDefaRole.SchoolId);
}
}
/// <summary>
/// 是否当前使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCurrentUse
{
get
{
return mbolIsCurrentUse;
}
set
{
 mbolIsCurrentUse = value;
//记录修改过的字段
 AddUpdatedFld(convPlatDefaRole.IsCurrentUse);
}
}
/// <summary>
/// 学校名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolName
{
get
{
return mstrSchoolName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolName = value;
}
else
{
 mstrSchoolName = value;
}
//记录修改过的字段
 AddUpdatedFld(convPlatDefaRole.SchoolName);
}
}
/// <summary>
/// 人员类别(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PersonType
{
get
{
return mstrPersonType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPersonType = value;
}
else
{
 mstrPersonType = value;
}
//记录修改过的字段
 AddUpdatedFld(convPlatDefaRole.PersonType);
}
}
/// <summary>
/// PrjId(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjId
{
get
{
return mstrPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjId = value;
}
else
{
 mstrPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(convPlatDefaRole.PrjId);
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
 AddUpdatedFld(convPlatDefaRole.RoleId);
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
 AddUpdatedFld(convPlatDefaRole.Memo);
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
 /// v平台默认角色(vPlatDefaRole)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convPlatDefaRole
{
public const string _CurrTabName = "vPlatDefaRole"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "IdSchool", "SchoolId", "IsCurrentUse", "SchoolName", "PersonType", "PrjId", "RoleId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"IdSchool"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSchool = "IdSchool";    //学校流水号

 /// <summary>
 /// 常量:"SchoolId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolId = "SchoolId";    //学校编号

 /// <summary>
 /// 常量:"IsCurrentUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCurrentUse = "IsCurrentUse";    //是否当前使用

 /// <summary>
 /// 常量:"SchoolName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolName = "SchoolName";    //学校名称

 /// <summary>
 /// 常量:"PersonType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PersonType = "PersonType";    //人员类别

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //PrjId

 /// <summary>
 /// 常量:"RoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleId = "RoleId";    //角色Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}