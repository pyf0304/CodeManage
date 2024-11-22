
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvAppraiseTypeKindSetEN
 表名:vAppraiseTypeKindSet(01120459)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:28
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:评价相关参数(SenateGaugePara)
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
 /// 表vAppraiseTypeKindSet的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vAppraiseTypeKindSet
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
public K_mId_vAppraiseTypeKindSet(long lngmId)
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
 /// <returns>返回:[K_mId_vAppraiseTypeKindSet]类型的对象</returns>
public static implicit operator K_mId_vAppraiseTypeKindSet(long value)
{
return new K_mId_vAppraiseTypeKindSet(value);
}
}
 /// <summary>
 /// v评议类型种类设置(vAppraiseTypeKindSet)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvAppraiseTypeKindSetEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vAppraiseTypeKindSet"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 15;
public static string[] AttributeName = new string[] {"mId", "IdSchool", "SchoolId", "SchoolName", "FuncModuleId", "FuncModuleName", "FuncModuleNameSim", "IdAppraiseType", "AppraiseTypeName", "AppraiseKindId", "AppraiseKindName", "InEffect", "UpdDate", "UpdUserId", "Memo"};

protected long mlngmId;    //mId
protected string mstrIdSchool;    //学校流水号
protected string mstrSchoolId;    //学校编号
protected string mstrSchoolName;    //学校名称
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected string mstrFuncModuleNameSim;    //功能模块简称
protected string mstrIdAppraiseType;    //评议类型流水号
protected string mstrAppraiseTypeName;    //评议类型名称
protected string mstrAppraiseKindId;    //评议种类Id
protected string mstrAppraiseKindName;    //评议种类名
protected bool mbolInEffect;    //是否有效
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvAppraiseTypeKindSetEN()
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
public clsvAppraiseTypeKindSetEN(long lngmId)
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
if (strAttributeName  ==  convAppraiseTypeKindSet.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convAppraiseTypeKindSet.IdSchool)
{
return mstrIdSchool;
}
else if (strAttributeName  ==  convAppraiseTypeKindSet.SchoolId)
{
return mstrSchoolId;
}
else if (strAttributeName  ==  convAppraiseTypeKindSet.SchoolName)
{
return mstrSchoolName;
}
else if (strAttributeName  ==  convAppraiseTypeKindSet.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convAppraiseTypeKindSet.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convAppraiseTypeKindSet.FuncModuleNameSim)
{
return mstrFuncModuleNameSim;
}
else if (strAttributeName  ==  convAppraiseTypeKindSet.IdAppraiseType)
{
return mstrIdAppraiseType;
}
else if (strAttributeName  ==  convAppraiseTypeKindSet.AppraiseTypeName)
{
return mstrAppraiseTypeName;
}
else if (strAttributeName  ==  convAppraiseTypeKindSet.AppraiseKindId)
{
return mstrAppraiseKindId;
}
else if (strAttributeName  ==  convAppraiseTypeKindSet.AppraiseKindName)
{
return mstrAppraiseKindName;
}
else if (strAttributeName  ==  convAppraiseTypeKindSet.InEffect)
{
return mbolInEffect;
}
else if (strAttributeName  ==  convAppraiseTypeKindSet.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convAppraiseTypeKindSet.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convAppraiseTypeKindSet.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convAppraiseTypeKindSet.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convAppraiseTypeKindSet.mId);
}
else if (strAttributeName  ==  convAppraiseTypeKindSet.IdSchool)
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(convAppraiseTypeKindSet.IdSchool);
}
else if (strAttributeName  ==  convAppraiseTypeKindSet.SchoolId)
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(convAppraiseTypeKindSet.SchoolId);
}
else if (strAttributeName  ==  convAppraiseTypeKindSet.SchoolName)
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(convAppraiseTypeKindSet.SchoolName);
}
else if (strAttributeName  ==  convAppraiseTypeKindSet.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convAppraiseTypeKindSet.FuncModuleId);
}
else if (strAttributeName  ==  convAppraiseTypeKindSet.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convAppraiseTypeKindSet.FuncModuleName);
}
else if (strAttributeName  ==  convAppraiseTypeKindSet.FuncModuleNameSim)
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convAppraiseTypeKindSet.FuncModuleNameSim);
}
else if (strAttributeName  ==  convAppraiseTypeKindSet.IdAppraiseType)
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convAppraiseTypeKindSet.IdAppraiseType);
}
else if (strAttributeName  ==  convAppraiseTypeKindSet.AppraiseTypeName)
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convAppraiseTypeKindSet.AppraiseTypeName);
}
else if (strAttributeName  ==  convAppraiseTypeKindSet.AppraiseKindId)
{
mstrAppraiseKindId = value.ToString();
 AddUpdatedFld(convAppraiseTypeKindSet.AppraiseKindId);
}
else if (strAttributeName  ==  convAppraiseTypeKindSet.AppraiseKindName)
{
mstrAppraiseKindName = value.ToString();
 AddUpdatedFld(convAppraiseTypeKindSet.AppraiseKindName);
}
else if (strAttributeName  ==  convAppraiseTypeKindSet.InEffect)
{
mbolInEffect = TransNullToBool(value.ToString());
 AddUpdatedFld(convAppraiseTypeKindSet.InEffect);
}
else if (strAttributeName  ==  convAppraiseTypeKindSet.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convAppraiseTypeKindSet.UpdDate);
}
else if (strAttributeName  ==  convAppraiseTypeKindSet.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convAppraiseTypeKindSet.UpdUserId);
}
else if (strAttributeName  ==  convAppraiseTypeKindSet.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convAppraiseTypeKindSet.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convAppraiseTypeKindSet.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convAppraiseTypeKindSet.IdSchool  ==  AttributeName[intIndex])
{
return mstrIdSchool;
}
else if (convAppraiseTypeKindSet.SchoolId  ==  AttributeName[intIndex])
{
return mstrSchoolId;
}
else if (convAppraiseTypeKindSet.SchoolName  ==  AttributeName[intIndex])
{
return mstrSchoolName;
}
else if (convAppraiseTypeKindSet.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convAppraiseTypeKindSet.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convAppraiseTypeKindSet.FuncModuleNameSim  ==  AttributeName[intIndex])
{
return mstrFuncModuleNameSim;
}
else if (convAppraiseTypeKindSet.IdAppraiseType  ==  AttributeName[intIndex])
{
return mstrIdAppraiseType;
}
else if (convAppraiseTypeKindSet.AppraiseTypeName  ==  AttributeName[intIndex])
{
return mstrAppraiseTypeName;
}
else if (convAppraiseTypeKindSet.AppraiseKindId  ==  AttributeName[intIndex])
{
return mstrAppraiseKindId;
}
else if (convAppraiseTypeKindSet.AppraiseKindName  ==  AttributeName[intIndex])
{
return mstrAppraiseKindName;
}
else if (convAppraiseTypeKindSet.InEffect  ==  AttributeName[intIndex])
{
return mbolInEffect;
}
else if (convAppraiseTypeKindSet.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convAppraiseTypeKindSet.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convAppraiseTypeKindSet.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convAppraiseTypeKindSet.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convAppraiseTypeKindSet.mId);
}
else if (convAppraiseTypeKindSet.IdSchool  ==  AttributeName[intIndex])
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(convAppraiseTypeKindSet.IdSchool);
}
else if (convAppraiseTypeKindSet.SchoolId  ==  AttributeName[intIndex])
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(convAppraiseTypeKindSet.SchoolId);
}
else if (convAppraiseTypeKindSet.SchoolName  ==  AttributeName[intIndex])
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(convAppraiseTypeKindSet.SchoolName);
}
else if (convAppraiseTypeKindSet.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convAppraiseTypeKindSet.FuncModuleId);
}
else if (convAppraiseTypeKindSet.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convAppraiseTypeKindSet.FuncModuleName);
}
else if (convAppraiseTypeKindSet.FuncModuleNameSim  ==  AttributeName[intIndex])
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convAppraiseTypeKindSet.FuncModuleNameSim);
}
else if (convAppraiseTypeKindSet.IdAppraiseType  ==  AttributeName[intIndex])
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(convAppraiseTypeKindSet.IdAppraiseType);
}
else if (convAppraiseTypeKindSet.AppraiseTypeName  ==  AttributeName[intIndex])
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(convAppraiseTypeKindSet.AppraiseTypeName);
}
else if (convAppraiseTypeKindSet.AppraiseKindId  ==  AttributeName[intIndex])
{
mstrAppraiseKindId = value.ToString();
 AddUpdatedFld(convAppraiseTypeKindSet.AppraiseKindId);
}
else if (convAppraiseTypeKindSet.AppraiseKindName  ==  AttributeName[intIndex])
{
mstrAppraiseKindName = value.ToString();
 AddUpdatedFld(convAppraiseTypeKindSet.AppraiseKindName);
}
else if (convAppraiseTypeKindSet.InEffect  ==  AttributeName[intIndex])
{
mbolInEffect = TransNullToBool(value.ToString());
 AddUpdatedFld(convAppraiseTypeKindSet.InEffect);
}
else if (convAppraiseTypeKindSet.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convAppraiseTypeKindSet.UpdDate);
}
else if (convAppraiseTypeKindSet.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convAppraiseTypeKindSet.UpdUserId);
}
else if (convAppraiseTypeKindSet.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convAppraiseTypeKindSet.Memo);
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
 AddUpdatedFld(convAppraiseTypeKindSet.mId);
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
 AddUpdatedFld(convAppraiseTypeKindSet.IdSchool);
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
 AddUpdatedFld(convAppraiseTypeKindSet.SchoolId);
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
 AddUpdatedFld(convAppraiseTypeKindSet.SchoolName);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleId
{
get
{
return mstrFuncModuleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleId = value;
}
else
{
 mstrFuncModuleId = value;
}
//记录修改过的字段
 AddUpdatedFld(convAppraiseTypeKindSet.FuncModuleId);
}
}
/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleName
{
get
{
return mstrFuncModuleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleName = value;
}
else
{
 mstrFuncModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convAppraiseTypeKindSet.FuncModuleName);
}
}
/// <summary>
/// 功能模块简称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleNameSim
{
get
{
return mstrFuncModuleNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleNameSim = value;
}
else
{
 mstrFuncModuleNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(convAppraiseTypeKindSet.FuncModuleNameSim);
}
}
/// <summary>
/// 评议类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdAppraiseType
{
get
{
return mstrIdAppraiseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdAppraiseType = value;
}
else
{
 mstrIdAppraiseType = value;
}
//记录修改过的字段
 AddUpdatedFld(convAppraiseTypeKindSet.IdAppraiseType);
}
}
/// <summary>
/// 评议类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppraiseTypeName
{
get
{
return mstrAppraiseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppraiseTypeName = value;
}
else
{
 mstrAppraiseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convAppraiseTypeKindSet.AppraiseTypeName);
}
}
/// <summary>
/// 评议种类Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppraiseKindId
{
get
{
return mstrAppraiseKindId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppraiseKindId = value;
}
else
{
 mstrAppraiseKindId = value;
}
//记录修改过的字段
 AddUpdatedFld(convAppraiseTypeKindSet.AppraiseKindId);
}
}
/// <summary>
/// 评议种类名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppraiseKindName
{
get
{
return mstrAppraiseKindName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppraiseKindName = value;
}
else
{
 mstrAppraiseKindName = value;
}
//记录修改过的字段
 AddUpdatedFld(convAppraiseTypeKindSet.AppraiseKindName);
}
}
/// <summary>
/// 是否有效(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool InEffect
{
get
{
return mbolInEffect;
}
set
{
 mbolInEffect = value;
//记录修改过的字段
 AddUpdatedFld(convAppraiseTypeKindSet.InEffect);
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
 AddUpdatedFld(convAppraiseTypeKindSet.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convAppraiseTypeKindSet.UpdUserId);
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
 AddUpdatedFld(convAppraiseTypeKindSet.Memo);
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
 /// v评议类型种类设置(vAppraiseTypeKindSet)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convAppraiseTypeKindSet
{
public const string _CurrTabName = "vAppraiseTypeKindSet"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "IdSchool", "SchoolId", "SchoolName", "FuncModuleId", "FuncModuleName", "FuncModuleNameSim", "IdAppraiseType", "AppraiseTypeName", "AppraiseKindId", "AppraiseKindName", "InEffect", "UpdDate", "UpdUserId", "Memo"};
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
 /// 常量:"SchoolName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolName = "SchoolName";    //学校名称

 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //功能模块名称

 /// <summary>
 /// 常量:"FuncModuleNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleNameSim = "FuncModuleNameSim";    //功能模块简称

 /// <summary>
 /// 常量:"IdAppraiseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdAppraiseType = "IdAppraiseType";    //评议类型流水号

 /// <summary>
 /// 常量:"AppraiseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseTypeName = "AppraiseTypeName";    //评议类型名称

 /// <summary>
 /// 常量:"AppraiseKindId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseKindId = "AppraiseKindId";    //评议种类Id

 /// <summary>
 /// 常量:"AppraiseKindName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseKindName = "AppraiseKindName";    //评议种类名

 /// <summary>
 /// 常量:"InEffect"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InEffect = "InEffect";    //是否有效

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}