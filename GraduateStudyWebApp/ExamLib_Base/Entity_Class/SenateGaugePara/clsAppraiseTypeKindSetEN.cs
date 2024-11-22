
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAppraiseTypeKindSetEN
 表名:AppraiseTypeKindSet(01120460)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:20:23
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:评价相关参数(SenateGaugePara)
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
 /// 表AppraiseTypeKindSet的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_AppraiseTypeKindSet
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
public K_mId_AppraiseTypeKindSet(long lngmId)
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
 /// <returns>返回:[K_mId_AppraiseTypeKindSet]类型的对象</returns>
public static implicit operator K_mId_AppraiseTypeKindSet(long value)
{
return new K_mId_AppraiseTypeKindSet(value);
}
}
 /// <summary>
 /// 评议类型种类设置(AppraiseTypeKindSet)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsAppraiseTypeKindSetEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "AppraiseTypeKindSet"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"mId", "IdSchool", "FuncModuleId", "IdAppraiseType", "AppraiseKindId", "InEffect", "UpdDate", "UpdUserId", "Memo"};

protected long mlngmId;    //mId
protected string mstrIdSchool;    //学校流水号
protected string mstrFuncModuleId;    //功能模块Id
protected string mstrIdAppraiseType;    //评议类型流水号
protected string mstrAppraiseKindId;    //评议种类Id
protected bool mbolInEffect;    //是否有效
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsAppraiseTypeKindSetEN()
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
public clsAppraiseTypeKindSetEN(long lngmId)
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
if (strAttributeName  ==  conAppraiseTypeKindSet.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conAppraiseTypeKindSet.IdSchool)
{
return mstrIdSchool;
}
else if (strAttributeName  ==  conAppraiseTypeKindSet.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  conAppraiseTypeKindSet.IdAppraiseType)
{
return mstrIdAppraiseType;
}
else if (strAttributeName  ==  conAppraiseTypeKindSet.AppraiseKindId)
{
return mstrAppraiseKindId;
}
else if (strAttributeName  ==  conAppraiseTypeKindSet.InEffect)
{
return mbolInEffect;
}
else if (strAttributeName  ==  conAppraiseTypeKindSet.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conAppraiseTypeKindSet.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conAppraiseTypeKindSet.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conAppraiseTypeKindSet.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conAppraiseTypeKindSet.mId);
}
else if (strAttributeName  ==  conAppraiseTypeKindSet.IdSchool)
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(conAppraiseTypeKindSet.IdSchool);
}
else if (strAttributeName  ==  conAppraiseTypeKindSet.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conAppraiseTypeKindSet.FuncModuleId);
}
else if (strAttributeName  ==  conAppraiseTypeKindSet.IdAppraiseType)
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(conAppraiseTypeKindSet.IdAppraiseType);
}
else if (strAttributeName  ==  conAppraiseTypeKindSet.AppraiseKindId)
{
mstrAppraiseKindId = value.ToString();
 AddUpdatedFld(conAppraiseTypeKindSet.AppraiseKindId);
}
else if (strAttributeName  ==  conAppraiseTypeKindSet.InEffect)
{
mbolInEffect = TransNullToBool(value.ToString());
 AddUpdatedFld(conAppraiseTypeKindSet.InEffect);
}
else if (strAttributeName  ==  conAppraiseTypeKindSet.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conAppraiseTypeKindSet.UpdDate);
}
else if (strAttributeName  ==  conAppraiseTypeKindSet.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conAppraiseTypeKindSet.UpdUserId);
}
else if (strAttributeName  ==  conAppraiseTypeKindSet.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conAppraiseTypeKindSet.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conAppraiseTypeKindSet.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conAppraiseTypeKindSet.IdSchool  ==  AttributeName[intIndex])
{
return mstrIdSchool;
}
else if (conAppraiseTypeKindSet.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (conAppraiseTypeKindSet.IdAppraiseType  ==  AttributeName[intIndex])
{
return mstrIdAppraiseType;
}
else if (conAppraiseTypeKindSet.AppraiseKindId  ==  AttributeName[intIndex])
{
return mstrAppraiseKindId;
}
else if (conAppraiseTypeKindSet.InEffect  ==  AttributeName[intIndex])
{
return mbolInEffect;
}
else if (conAppraiseTypeKindSet.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conAppraiseTypeKindSet.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conAppraiseTypeKindSet.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conAppraiseTypeKindSet.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conAppraiseTypeKindSet.mId);
}
else if (conAppraiseTypeKindSet.IdSchool  ==  AttributeName[intIndex])
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(conAppraiseTypeKindSet.IdSchool);
}
else if (conAppraiseTypeKindSet.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conAppraiseTypeKindSet.FuncModuleId);
}
else if (conAppraiseTypeKindSet.IdAppraiseType  ==  AttributeName[intIndex])
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(conAppraiseTypeKindSet.IdAppraiseType);
}
else if (conAppraiseTypeKindSet.AppraiseKindId  ==  AttributeName[intIndex])
{
mstrAppraiseKindId = value.ToString();
 AddUpdatedFld(conAppraiseTypeKindSet.AppraiseKindId);
}
else if (conAppraiseTypeKindSet.InEffect  ==  AttributeName[intIndex])
{
mbolInEffect = TransNullToBool(value.ToString());
 AddUpdatedFld(conAppraiseTypeKindSet.InEffect);
}
else if (conAppraiseTypeKindSet.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conAppraiseTypeKindSet.UpdDate);
}
else if (conAppraiseTypeKindSet.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conAppraiseTypeKindSet.UpdUserId);
}
else if (conAppraiseTypeKindSet.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conAppraiseTypeKindSet.Memo);
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
 AddUpdatedFld(conAppraiseTypeKindSet.mId);
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
 AddUpdatedFld(conAppraiseTypeKindSet.IdSchool);
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
 AddUpdatedFld(conAppraiseTypeKindSet.FuncModuleId);
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
 AddUpdatedFld(conAppraiseTypeKindSet.IdAppraiseType);
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
 AddUpdatedFld(conAppraiseTypeKindSet.AppraiseKindId);
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
 AddUpdatedFld(conAppraiseTypeKindSet.InEffect);
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
 AddUpdatedFld(conAppraiseTypeKindSet.UpdDate);
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
 AddUpdatedFld(conAppraiseTypeKindSet.UpdUserId);
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
 AddUpdatedFld(conAppraiseTypeKindSet.Memo);
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
 /// 评议类型种类设置(AppraiseTypeKindSet)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conAppraiseTypeKindSet
{
public const string _CurrTabName = "AppraiseTypeKindSet"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "IdSchool", "FuncModuleId", "IdAppraiseType", "AppraiseKindId", "InEffect", "UpdDate", "UpdUserId", "Memo"};
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
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //功能模块Id

 /// <summary>
 /// 常量:"IdAppraiseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdAppraiseType = "IdAppraiseType";    //评议类型流水号

 /// <summary>
 /// 常量:"AppraiseKindId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseKindId = "AppraiseKindId";    //评议种类Id

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