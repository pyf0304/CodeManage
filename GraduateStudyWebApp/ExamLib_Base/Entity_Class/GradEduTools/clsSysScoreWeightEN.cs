
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysScoreWeightEN
 表名:SysScoreWeight(01120629)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:08:46
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
 /// 表SysScoreWeight的关键字(ScoreWeightId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ScoreWeightId_SysScoreWeight
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strScoreWeightId">表关键字</param>
public K_ScoreWeightId_SysScoreWeight(string strScoreWeightId)
{
if (IsValid(strScoreWeightId)) Value = strScoreWeightId;
else
{
Value = null;
}
}
private static bool IsValid(string strScoreWeightId)
{
if (string.IsNullOrEmpty(strScoreWeightId) == true) return false;
if (strScoreWeightId.Length != 1) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ScoreWeightId_SysScoreWeight]类型的对象</returns>
public static implicit operator K_ScoreWeightId_SysScoreWeight(string value)
{
return new K_ScoreWeightId_SysScoreWeight(value);
}
}
 /// <summary>
 /// 系统分数权重表(SysScoreWeight)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSysScoreWeightEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SysScoreWeight"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ScoreWeightId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"ScoreWeightId", "Memo", "IsPublic", "ScoreTypeId", "ScoreWeightValue", "UpdDate", "UpdUser", "IdCurrEduCls"};

protected string mstrScoreWeightId;    //分数权重Id
protected string mstrMemo;    //备注
protected bool mbolIsPublic;    //是否公开
protected string mstrScoreTypeId;    //分数类型Id
protected string mstrScoreWeightValue;    //分数权重值
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrIdCurrEduCls;    //教学班流水号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsSysScoreWeightEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ScoreWeightId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strScoreWeightId">关键字:分数权重Id</param>
public clsSysScoreWeightEN(string strScoreWeightId)
 {
strScoreWeightId = strScoreWeightId.Replace("'", "''");
if (strScoreWeightId.Length > 1)
{
throw new Exception("在表:SysScoreWeight中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strScoreWeightId)  ==  true)
{
throw new Exception("在表:SysScoreWeight中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strScoreWeightId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrScoreWeightId = strScoreWeightId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ScoreWeightId");
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
if (strAttributeName  ==  conSysScoreWeight.ScoreWeightId)
{
return mstrScoreWeightId;
}
else if (strAttributeName  ==  conSysScoreWeight.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conSysScoreWeight.IsPublic)
{
return mbolIsPublic;
}
else if (strAttributeName  ==  conSysScoreWeight.ScoreTypeId)
{
return mstrScoreTypeId;
}
else if (strAttributeName  ==  conSysScoreWeight.ScoreWeightValue)
{
return mstrScoreWeightValue;
}
else if (strAttributeName  ==  conSysScoreWeight.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conSysScoreWeight.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conSysScoreWeight.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (strAttributeName  ==  conSysScoreWeight.ScoreWeightId)
{
mstrScoreWeightId = value.ToString();
 AddUpdatedFld(conSysScoreWeight.ScoreWeightId);
}
else if (strAttributeName  ==  conSysScoreWeight.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSysScoreWeight.Memo);
}
else if (strAttributeName  ==  conSysScoreWeight.IsPublic)
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(conSysScoreWeight.IsPublic);
}
else if (strAttributeName  ==  conSysScoreWeight.ScoreTypeId)
{
mstrScoreTypeId = value.ToString();
 AddUpdatedFld(conSysScoreWeight.ScoreTypeId);
}
else if (strAttributeName  ==  conSysScoreWeight.ScoreWeightValue)
{
mstrScoreWeightValue = value.ToString();
 AddUpdatedFld(conSysScoreWeight.ScoreWeightValue);
}
else if (strAttributeName  ==  conSysScoreWeight.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSysScoreWeight.UpdDate);
}
else if (strAttributeName  ==  conSysScoreWeight.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conSysScoreWeight.UpdUser);
}
else if (strAttributeName  ==  conSysScoreWeight.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conSysScoreWeight.IdCurrEduCls);
}
}
}
public object this[int intIndex]
{
get
{
if (conSysScoreWeight.ScoreWeightId  ==  AttributeName[intIndex])
{
return mstrScoreWeightId;
}
else if (conSysScoreWeight.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conSysScoreWeight.IsPublic  ==  AttributeName[intIndex])
{
return mbolIsPublic;
}
else if (conSysScoreWeight.ScoreTypeId  ==  AttributeName[intIndex])
{
return mstrScoreTypeId;
}
else if (conSysScoreWeight.ScoreWeightValue  ==  AttributeName[intIndex])
{
return mstrScoreWeightValue;
}
else if (conSysScoreWeight.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conSysScoreWeight.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conSysScoreWeight.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
return null;
}
set
{
if (conSysScoreWeight.ScoreWeightId  ==  AttributeName[intIndex])
{
mstrScoreWeightId = value.ToString();
 AddUpdatedFld(conSysScoreWeight.ScoreWeightId);
}
else if (conSysScoreWeight.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSysScoreWeight.Memo);
}
else if (conSysScoreWeight.IsPublic  ==  AttributeName[intIndex])
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(conSysScoreWeight.IsPublic);
}
else if (conSysScoreWeight.ScoreTypeId  ==  AttributeName[intIndex])
{
mstrScoreTypeId = value.ToString();
 AddUpdatedFld(conSysScoreWeight.ScoreTypeId);
}
else if (conSysScoreWeight.ScoreWeightValue  ==  AttributeName[intIndex])
{
mstrScoreWeightValue = value.ToString();
 AddUpdatedFld(conSysScoreWeight.ScoreWeightValue);
}
else if (conSysScoreWeight.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSysScoreWeight.UpdDate);
}
else if (conSysScoreWeight.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conSysScoreWeight.UpdUser);
}
else if (conSysScoreWeight.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conSysScoreWeight.IdCurrEduCls);
}
}
}

/// <summary>
/// 分数权重Id(说明:;字段类型:char;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ScoreWeightId
{
get
{
return mstrScoreWeightId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrScoreWeightId = value;
}
else
{
 mstrScoreWeightId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysScoreWeight.ScoreWeightId);
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
 AddUpdatedFld(conSysScoreWeight.Memo);
}
}
/// <summary>
/// 是否公开(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsPublic
{
get
{
return mbolIsPublic;
}
set
{
 mbolIsPublic = value;
//记录修改过的字段
 AddUpdatedFld(conSysScoreWeight.IsPublic);
}
}
/// <summary>
/// 分数类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ScoreTypeId
{
get
{
return mstrScoreTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrScoreTypeId = value;
}
else
{
 mstrScoreTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysScoreWeight.ScoreTypeId);
}
}
/// <summary>
/// 分数权重值(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ScoreWeightValue
{
get
{
return mstrScoreWeightValue;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrScoreWeightValue = value;
}
else
{
 mstrScoreWeightValue = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysScoreWeight.ScoreWeightValue);
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
 AddUpdatedFld(conSysScoreWeight.UpdDate);
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
 AddUpdatedFld(conSysScoreWeight.UpdUser);
}
}
/// <summary>
/// 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCurrEduCls
{
get
{
return mstrIdCurrEduCls;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCurrEduCls = value;
}
else
{
 mstrIdCurrEduCls = value;
}
//记录修改过的字段
 AddUpdatedFld(conSysScoreWeight.IdCurrEduCls);
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
  return mstrScoreWeightId;
 }
 }
}
 /// <summary>
 /// 系统分数权重表(SysScoreWeight)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSysScoreWeight
{
public const string _CurrTabName = "SysScoreWeight"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ScoreWeightId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ScoreWeightId", "Memo", "IsPublic", "ScoreTypeId", "ScoreWeightValue", "UpdDate", "UpdUser", "IdCurrEduCls"};
//以下是属性变量


 /// <summary>
 /// 常量:"ScoreWeightId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ScoreWeightId = "ScoreWeightId";    //分数权重Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"IsPublic"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsPublic = "IsPublic";    //是否公开

 /// <summary>
 /// 常量:"ScoreTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ScoreTypeId = "ScoreTypeId";    //分数类型Id

 /// <summary>
 /// 常量:"ScoreWeightValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ScoreWeightValue = "ScoreWeightValue";    //分数权重值

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
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号
}

}