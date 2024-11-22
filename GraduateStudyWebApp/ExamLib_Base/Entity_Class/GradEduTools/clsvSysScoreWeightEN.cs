
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSysScoreWeightEN
 表名:vSysScoreWeight(01120630)
 * 版本:2023.10.02.1(服务器:WIN-SRV103-116)
 日期:2023/10/08 16:38:24
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
 /// 表vSysScoreWeight的关键字(ScoreWeightId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ScoreWeightId_vSysScoreWeight
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
public K_ScoreWeightId_vSysScoreWeight(string strScoreWeightId)
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
 /// <returns>返回:[K_ScoreWeightId_vSysScoreWeight]类型的对象</returns>
public static implicit operator K_ScoreWeightId_vSysScoreWeight(string value)
{
return new K_ScoreWeightId_vSysScoreWeight(value);
}
}
 /// <summary>
 /// v系统分数权重表(vSysScoreWeight)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvSysScoreWeightEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vSysScoreWeight"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ScoreWeightId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"ScoreWeightId", "ScoreWeightValue", "IsPublic", "UpdDate", "UpdUser", "Memo", "ScoreTypeId", "ScoreTypeName", "OnlyId", "IdCurrEduCls", "CurrEduClsId", "EduClsName"};

protected string mstrScoreWeightId;    //分数权重Id
protected string mstrScoreWeightValue;    //分数权重值
protected bool mbolIsPublic;    //是否公开
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrScoreTypeId;    //分数类型Id
protected string mstrScoreTypeName;    //分数类型名称
protected string mstrOnlyId;    //OnlyId
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrCurrEduClsId;    //教学班Id
protected string mstrEduClsName;    //教学班名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvSysScoreWeightEN()
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
public clsvSysScoreWeightEN(string strScoreWeightId)
 {
strScoreWeightId = strScoreWeightId.Replace("'", "''");
if (strScoreWeightId.Length > 1)
{
throw new Exception("在表:vSysScoreWeight中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strScoreWeightId)  ==  true)
{
throw new Exception("在表:vSysScoreWeight中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convSysScoreWeight.ScoreWeightId)
{
return mstrScoreWeightId;
}
else if (strAttributeName  ==  convSysScoreWeight.ScoreWeightValue)
{
return mstrScoreWeightValue;
}
else if (strAttributeName  ==  convSysScoreWeight.IsPublic)
{
return mbolIsPublic;
}
else if (strAttributeName  ==  convSysScoreWeight.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convSysScoreWeight.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convSysScoreWeight.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convSysScoreWeight.ScoreTypeId)
{
return mstrScoreTypeId;
}
else if (strAttributeName  ==  convSysScoreWeight.ScoreTypeName)
{
return mstrScoreTypeName;
}
else if (strAttributeName  ==  convSysScoreWeight.OnlyId)
{
return mstrOnlyId;
}
else if (strAttributeName  ==  convSysScoreWeight.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  convSysScoreWeight.CurrEduClsId)
{
return mstrCurrEduClsId;
}
else if (strAttributeName  ==  convSysScoreWeight.EduClsName)
{
return mstrEduClsName;
}
return null;
}
set
{
if (strAttributeName  ==  convSysScoreWeight.ScoreWeightId)
{
mstrScoreWeightId = value.ToString();
 AddUpdatedFld(convSysScoreWeight.ScoreWeightId);
}
else if (strAttributeName  ==  convSysScoreWeight.ScoreWeightValue)
{
mstrScoreWeightValue = value.ToString();
 AddUpdatedFld(convSysScoreWeight.ScoreWeightValue);
}
else if (strAttributeName  ==  convSysScoreWeight.IsPublic)
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convSysScoreWeight.IsPublic);
}
else if (strAttributeName  ==  convSysScoreWeight.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSysScoreWeight.UpdDate);
}
else if (strAttributeName  ==  convSysScoreWeight.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convSysScoreWeight.UpdUser);
}
else if (strAttributeName  ==  convSysScoreWeight.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSysScoreWeight.Memo);
}
else if (strAttributeName  ==  convSysScoreWeight.ScoreTypeId)
{
mstrScoreTypeId = value.ToString();
 AddUpdatedFld(convSysScoreWeight.ScoreTypeId);
}
else if (strAttributeName  ==  convSysScoreWeight.ScoreTypeName)
{
mstrScoreTypeName = value.ToString();
 AddUpdatedFld(convSysScoreWeight.ScoreTypeName);
}
else if (strAttributeName  ==  convSysScoreWeight.OnlyId)
{
mstrOnlyId = value.ToString();
 AddUpdatedFld(convSysScoreWeight.OnlyId);
}
else if (strAttributeName  ==  convSysScoreWeight.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convSysScoreWeight.IdCurrEduCls);
}
else if (strAttributeName  ==  convSysScoreWeight.CurrEduClsId)
{
mstrCurrEduClsId = value.ToString();
 AddUpdatedFld(convSysScoreWeight.CurrEduClsId);
}
else if (strAttributeName  ==  convSysScoreWeight.EduClsName)
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(convSysScoreWeight.EduClsName);
}
}
}
public object this[int intIndex]
{
get
{
if (convSysScoreWeight.ScoreWeightId  ==  AttributeName[intIndex])
{
return mstrScoreWeightId;
}
else if (convSysScoreWeight.ScoreWeightValue  ==  AttributeName[intIndex])
{
return mstrScoreWeightValue;
}
else if (convSysScoreWeight.IsPublic  ==  AttributeName[intIndex])
{
return mbolIsPublic;
}
else if (convSysScoreWeight.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convSysScoreWeight.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convSysScoreWeight.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convSysScoreWeight.ScoreTypeId  ==  AttributeName[intIndex])
{
return mstrScoreTypeId;
}
else if (convSysScoreWeight.ScoreTypeName  ==  AttributeName[intIndex])
{
return mstrScoreTypeName;
}
else if (convSysScoreWeight.OnlyId  ==  AttributeName[intIndex])
{
return mstrOnlyId;
}
else if (convSysScoreWeight.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (convSysScoreWeight.CurrEduClsId  ==  AttributeName[intIndex])
{
return mstrCurrEduClsId;
}
else if (convSysScoreWeight.EduClsName  ==  AttributeName[intIndex])
{
return mstrEduClsName;
}
return null;
}
set
{
if (convSysScoreWeight.ScoreWeightId  ==  AttributeName[intIndex])
{
mstrScoreWeightId = value.ToString();
 AddUpdatedFld(convSysScoreWeight.ScoreWeightId);
}
else if (convSysScoreWeight.ScoreWeightValue  ==  AttributeName[intIndex])
{
mstrScoreWeightValue = value.ToString();
 AddUpdatedFld(convSysScoreWeight.ScoreWeightValue);
}
else if (convSysScoreWeight.IsPublic  ==  AttributeName[intIndex])
{
mbolIsPublic = TransNullToBool(value.ToString());
 AddUpdatedFld(convSysScoreWeight.IsPublic);
}
else if (convSysScoreWeight.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convSysScoreWeight.UpdDate);
}
else if (convSysScoreWeight.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convSysScoreWeight.UpdUser);
}
else if (convSysScoreWeight.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSysScoreWeight.Memo);
}
else if (convSysScoreWeight.ScoreTypeId  ==  AttributeName[intIndex])
{
mstrScoreTypeId = value.ToString();
 AddUpdatedFld(convSysScoreWeight.ScoreTypeId);
}
else if (convSysScoreWeight.ScoreTypeName  ==  AttributeName[intIndex])
{
mstrScoreTypeName = value.ToString();
 AddUpdatedFld(convSysScoreWeight.ScoreTypeName);
}
else if (convSysScoreWeight.OnlyId  ==  AttributeName[intIndex])
{
mstrOnlyId = value.ToString();
 AddUpdatedFld(convSysScoreWeight.OnlyId);
}
else if (convSysScoreWeight.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(convSysScoreWeight.IdCurrEduCls);
}
else if (convSysScoreWeight.CurrEduClsId  ==  AttributeName[intIndex])
{
mstrCurrEduClsId = value.ToString();
 AddUpdatedFld(convSysScoreWeight.CurrEduClsId);
}
else if (convSysScoreWeight.EduClsName  ==  AttributeName[intIndex])
{
mstrEduClsName = value.ToString();
 AddUpdatedFld(convSysScoreWeight.EduClsName);
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
 AddUpdatedFld(convSysScoreWeight.ScoreWeightId);
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
 AddUpdatedFld(convSysScoreWeight.ScoreWeightValue);
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
 AddUpdatedFld(convSysScoreWeight.IsPublic);
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
 AddUpdatedFld(convSysScoreWeight.UpdDate);
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
 AddUpdatedFld(convSysScoreWeight.UpdUser);
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
 AddUpdatedFld(convSysScoreWeight.Memo);
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
 AddUpdatedFld(convSysScoreWeight.ScoreTypeId);
}
}
/// <summary>
/// 分数类型名称(说明:;字段类型:varchar;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ScoreTypeName
{
get
{
return mstrScoreTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrScoreTypeName = value;
}
else
{
 mstrScoreTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysScoreWeight.ScoreTypeName);
}
}
/// <summary>
/// OnlyId(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OnlyId
{
get
{
return mstrOnlyId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOnlyId = value;
}
else
{
 mstrOnlyId = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysScoreWeight.OnlyId);
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
 AddUpdatedFld(convSysScoreWeight.IdCurrEduCls);
}
}
/// <summary>
/// 教学班Id(说明:;字段类型:varchar;字段长度:15;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CurrEduClsId
{
get
{
return mstrCurrEduClsId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCurrEduClsId = value;
}
else
{
 mstrCurrEduClsId = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysScoreWeight.CurrEduClsId);
}
}
/// <summary>
/// 教学班名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduClsName
{
get
{
return mstrEduClsName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduClsName = value;
}
else
{
 mstrEduClsName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSysScoreWeight.EduClsName);
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
 /// v系统分数权重表(vSysScoreWeight)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convSysScoreWeight
{
public const string _CurrTabName = "vSysScoreWeight"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ScoreWeightId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ScoreWeightId", "ScoreWeightValue", "IsPublic", "UpdDate", "UpdUser", "Memo", "ScoreTypeId", "ScoreTypeName", "OnlyId", "IdCurrEduCls", "CurrEduClsId", "EduClsName"};
//以下是属性变量


 /// <summary>
 /// 常量:"ScoreWeightId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ScoreWeightId = "ScoreWeightId";    //分数权重Id

 /// <summary>
 /// 常量:"ScoreWeightValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ScoreWeightValue = "ScoreWeightValue";    //分数权重值

 /// <summary>
 /// 常量:"IsPublic"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsPublic = "IsPublic";    //是否公开

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

 /// <summary>
 /// 常量:"ScoreTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ScoreTypeId = "ScoreTypeId";    //分数类型Id

 /// <summary>
 /// 常量:"ScoreTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ScoreTypeName = "ScoreTypeName";    //分数类型名称

 /// <summary>
 /// 常量:"OnlyId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OnlyId = "OnlyId";    //OnlyId

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"CurrEduClsId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CurrEduClsId = "CurrEduClsId";    //教学班Id

 /// <summary>
 /// 常量:"EduClsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduClsName = "EduClsName";    //教学班名
}

}