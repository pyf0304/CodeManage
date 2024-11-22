
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTSysPara_JTEN
 表名:TSysPara_JT(01120754)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:54:02
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
 /// 表TSysPara_JT的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_TSysPara_JT
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
public K_mId_TSysPara_JT(long lngmId)
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
 /// <returns>返回:[K_mId_TSysPara_JT]类型的对象</returns>
public static implicit operator K_mId_TSysPara_JT(long value)
{
return new K_mId_TSysPara_JT(value);
}
}
 /// <summary>
 /// TSysPara_JT(TSysPara_JT)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTSysPara_JTEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "TSysPara_JT"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"mId", "SysParaName", "SysParaValue", "IdSchool", "SchoolId", "ModifyDate", "ModifyUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrSysParaName;    //SysParaName
protected string mstrSysParaValue;    //SysParaValue
protected string mstrIdSchool;    //学校流水号
protected string mstrSchoolId;    //学校编号
protected string mstrModifyDate;    //修改日期
protected string mstrModifyUser;    //ModifyUser
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsTSysPara_JTEN()
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
public clsTSysPara_JTEN(long lngmId)
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
if (strAttributeName  ==  conTSysPara_JT.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conTSysPara_JT.SysParaName)
{
return mstrSysParaName;
}
else if (strAttributeName  ==  conTSysPara_JT.SysParaValue)
{
return mstrSysParaValue;
}
else if (strAttributeName  ==  conTSysPara_JT.IdSchool)
{
return mstrIdSchool;
}
else if (strAttributeName  ==  conTSysPara_JT.SchoolId)
{
return mstrSchoolId;
}
else if (strAttributeName  ==  conTSysPara_JT.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  conTSysPara_JT.ModifyUser)
{
return mstrModifyUser;
}
else if (strAttributeName  ==  conTSysPara_JT.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conTSysPara_JT.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conTSysPara_JT.mId);
}
else if (strAttributeName  ==  conTSysPara_JT.SysParaName)
{
mstrSysParaName = value.ToString();
 AddUpdatedFld(conTSysPara_JT.SysParaName);
}
else if (strAttributeName  ==  conTSysPara_JT.SysParaValue)
{
mstrSysParaValue = value.ToString();
 AddUpdatedFld(conTSysPara_JT.SysParaValue);
}
else if (strAttributeName  ==  conTSysPara_JT.IdSchool)
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(conTSysPara_JT.IdSchool);
}
else if (strAttributeName  ==  conTSysPara_JT.SchoolId)
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(conTSysPara_JT.SchoolId);
}
else if (strAttributeName  ==  conTSysPara_JT.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conTSysPara_JT.ModifyDate);
}
else if (strAttributeName  ==  conTSysPara_JT.ModifyUser)
{
mstrModifyUser = value.ToString();
 AddUpdatedFld(conTSysPara_JT.ModifyUser);
}
else if (strAttributeName  ==  conTSysPara_JT.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTSysPara_JT.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTSysPara_JT.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conTSysPara_JT.SysParaName  ==  AttributeName[intIndex])
{
return mstrSysParaName;
}
else if (conTSysPara_JT.SysParaValue  ==  AttributeName[intIndex])
{
return mstrSysParaValue;
}
else if (conTSysPara_JT.IdSchool  ==  AttributeName[intIndex])
{
return mstrIdSchool;
}
else if (conTSysPara_JT.SchoolId  ==  AttributeName[intIndex])
{
return mstrSchoolId;
}
else if (conTSysPara_JT.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (conTSysPara_JT.ModifyUser  ==  AttributeName[intIndex])
{
return mstrModifyUser;
}
else if (conTSysPara_JT.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conTSysPara_JT.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conTSysPara_JT.mId);
}
else if (conTSysPara_JT.SysParaName  ==  AttributeName[intIndex])
{
mstrSysParaName = value.ToString();
 AddUpdatedFld(conTSysPara_JT.SysParaName);
}
else if (conTSysPara_JT.SysParaValue  ==  AttributeName[intIndex])
{
mstrSysParaValue = value.ToString();
 AddUpdatedFld(conTSysPara_JT.SysParaValue);
}
else if (conTSysPara_JT.IdSchool  ==  AttributeName[intIndex])
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(conTSysPara_JT.IdSchool);
}
else if (conTSysPara_JT.SchoolId  ==  AttributeName[intIndex])
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(conTSysPara_JT.SchoolId);
}
else if (conTSysPara_JT.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conTSysPara_JT.ModifyDate);
}
else if (conTSysPara_JT.ModifyUser  ==  AttributeName[intIndex])
{
mstrModifyUser = value.ToString();
 AddUpdatedFld(conTSysPara_JT.ModifyUser);
}
else if (conTSysPara_JT.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTSysPara_JT.Memo);
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
 AddUpdatedFld(conTSysPara_JT.mId);
}
}
/// <summary>
/// SysParaName(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SysParaName
{
get
{
return mstrSysParaName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSysParaName = value;
}
else
{
 mstrSysParaName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTSysPara_JT.SysParaName);
}
}
/// <summary>
/// SysParaValue(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SysParaValue
{
get
{
return mstrSysParaValue;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSysParaValue = value;
}
else
{
 mstrSysParaValue = value;
}
//记录修改过的字段
 AddUpdatedFld(conTSysPara_JT.SysParaValue);
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
 AddUpdatedFld(conTSysPara_JT.IdSchool);
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
 AddUpdatedFld(conTSysPara_JT.SchoolId);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyDate
{
get
{
return mstrModifyDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyDate = value;
}
else
{
 mstrModifyDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conTSysPara_JT.ModifyDate);
}
}
/// <summary>
/// ModifyUser(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyUser
{
get
{
return mstrModifyUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyUser = value;
}
else
{
 mstrModifyUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conTSysPara_JT.ModifyUser);
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
 AddUpdatedFld(conTSysPara_JT.Memo);
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
 /// TSysPara_JT(TSysPara_JT)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTSysPara_JT
{
public const string _CurrTabName = "TSysPara_JT"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "SysParaName", "SysParaValue", "IdSchool", "SchoolId", "ModifyDate", "ModifyUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"SysParaName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SysParaName = "SysParaName";    //SysParaName

 /// <summary>
 /// 常量:"SysParaValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SysParaValue = "SysParaValue";    //SysParaValue

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
 /// 常量:"ModifyDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyDate = "ModifyDate";    //修改日期

 /// <summary>
 /// 常量:"ModifyUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyUser = "ModifyUser";    //ModifyUser

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}