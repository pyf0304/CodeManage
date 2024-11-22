
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPlatDefaRoleEN
 表名:PlatDefaRole(01120231)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:11:52
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
 /// 表PlatDefaRole的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_PlatDefaRole
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
public K_mId_PlatDefaRole(long lngmId)
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
 /// <returns>返回:[K_mId_PlatDefaRole]类型的对象</returns>
public static implicit operator K_mId_PlatDefaRole(long value)
{
return new K_mId_PlatDefaRole(value);
}
}
 /// <summary>
 /// 平台默认角色(PlatDefaRole)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPlatDefaRoleEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PlatDefaRole"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"mId", "IdSchool", "PersonType", "PrjId", "RoleId", "Memo"};

protected long mlngmId;    //mId
protected string mstrIdSchool;    //学校流水号
protected string mstrPersonType;    //人员类别
protected string mstrPrjId;    //PrjId
protected string mstrRoleId;    //角色Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsPlatDefaRoleEN()
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
public clsPlatDefaRoleEN(long lngmId)
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
if (strAttributeName  ==  conPlatDefaRole.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conPlatDefaRole.IdSchool)
{
return mstrIdSchool;
}
else if (strAttributeName  ==  conPlatDefaRole.PersonType)
{
return mstrPersonType;
}
else if (strAttributeName  ==  conPlatDefaRole.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conPlatDefaRole.RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  conPlatDefaRole.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPlatDefaRole.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPlatDefaRole.mId);
}
else if (strAttributeName  ==  conPlatDefaRole.IdSchool)
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(conPlatDefaRole.IdSchool);
}
else if (strAttributeName  ==  conPlatDefaRole.PersonType)
{
mstrPersonType = value.ToString();
 AddUpdatedFld(conPlatDefaRole.PersonType);
}
else if (strAttributeName  ==  conPlatDefaRole.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conPlatDefaRole.PrjId);
}
else if (strAttributeName  ==  conPlatDefaRole.RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(conPlatDefaRole.RoleId);
}
else if (strAttributeName  ==  conPlatDefaRole.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPlatDefaRole.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPlatDefaRole.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conPlatDefaRole.IdSchool  ==  AttributeName[intIndex])
{
return mstrIdSchool;
}
else if (conPlatDefaRole.PersonType  ==  AttributeName[intIndex])
{
return mstrPersonType;
}
else if (conPlatDefaRole.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conPlatDefaRole.RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (conPlatDefaRole.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPlatDefaRole.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conPlatDefaRole.mId);
}
else if (conPlatDefaRole.IdSchool  ==  AttributeName[intIndex])
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(conPlatDefaRole.IdSchool);
}
else if (conPlatDefaRole.PersonType  ==  AttributeName[intIndex])
{
mstrPersonType = value.ToString();
 AddUpdatedFld(conPlatDefaRole.PersonType);
}
else if (conPlatDefaRole.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conPlatDefaRole.PrjId);
}
else if (conPlatDefaRole.RoleId  ==  AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(conPlatDefaRole.RoleId);
}
else if (conPlatDefaRole.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPlatDefaRole.Memo);
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
 AddUpdatedFld(conPlatDefaRole.mId);
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
 AddUpdatedFld(conPlatDefaRole.IdSchool);
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
 AddUpdatedFld(conPlatDefaRole.PersonType);
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
 AddUpdatedFld(conPlatDefaRole.PrjId);
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
 AddUpdatedFld(conPlatDefaRole.RoleId);
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
 AddUpdatedFld(conPlatDefaRole.Memo);
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
 /// 平台默认角色(PlatDefaRole)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPlatDefaRole
{
public const string _CurrTabName = "PlatDefaRole"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "IdSchool", "PersonType", "PrjId", "RoleId", "Memo"};
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