
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_SysScoreTypeEN
 表名:zx_SysScoreType(01120825)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:54:58
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培参数(RT_Params)
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
 /// 表zx_SysScoreType的关键字(zxScoreTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxScoreTypeId_zx_SysScoreType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxScoreTypeId">表关键字</param>
public K_zxScoreTypeId_zx_SysScoreType(string strzxScoreTypeId)
{
if (IsValid(strzxScoreTypeId)) Value = strzxScoreTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxScoreTypeId)
{
if (string.IsNullOrEmpty(strzxScoreTypeId) == true) return false;
if (strzxScoreTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxScoreTypeId_zx_SysScoreType]类型的对象</returns>
public static implicit operator K_zxScoreTypeId_zx_SysScoreType(string value)
{
return new K_zxScoreTypeId_zx_SysScoreType(value);
}
}
 /// <summary>
 /// 中学评分类型表(zx_SysScoreType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_SysScoreTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_SysScoreType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxScoreTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"zxScoreTypeId", "ScoreTypeName", "OnlyId", "UpdUser", "UpdDate", "Memo"};

protected string mstrzxScoreTypeId;    //分数类型Id
protected string mstrScoreTypeName;    //分数类型名称
protected string mstrOnlyId;    //OnlyId
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_SysScoreTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxScoreTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxScoreTypeId">关键字:分数类型Id</param>
public clszx_SysScoreTypeEN(string strzxScoreTypeId)
 {
strzxScoreTypeId = strzxScoreTypeId.Replace("'", "''");
if (strzxScoreTypeId.Length > 4)
{
throw new Exception("在表:zx_SysScoreType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxScoreTypeId)  ==  true)
{
throw new Exception("在表:zx_SysScoreType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxScoreTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxScoreTypeId = strzxScoreTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxScoreTypeId");
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
if (strAttributeName  ==  conzx_SysScoreType.zxScoreTypeId)
{
return mstrzxScoreTypeId;
}
else if (strAttributeName  ==  conzx_SysScoreType.ScoreTypeName)
{
return mstrScoreTypeName;
}
else if (strAttributeName  ==  conzx_SysScoreType.OnlyId)
{
return mstrOnlyId;
}
else if (strAttributeName  ==  conzx_SysScoreType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_SysScoreType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_SysScoreType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_SysScoreType.zxScoreTypeId)
{
mstrzxScoreTypeId = value.ToString();
 AddUpdatedFld(conzx_SysScoreType.zxScoreTypeId);
}
else if (strAttributeName  ==  conzx_SysScoreType.ScoreTypeName)
{
mstrScoreTypeName = value.ToString();
 AddUpdatedFld(conzx_SysScoreType.ScoreTypeName);
}
else if (strAttributeName  ==  conzx_SysScoreType.OnlyId)
{
mstrOnlyId = value.ToString();
 AddUpdatedFld(conzx_SysScoreType.OnlyId);
}
else if (strAttributeName  ==  conzx_SysScoreType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_SysScoreType.UpdUser);
}
else if (strAttributeName  ==  conzx_SysScoreType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_SysScoreType.UpdDate);
}
else if (strAttributeName  ==  conzx_SysScoreType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_SysScoreType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_SysScoreType.zxScoreTypeId  ==  AttributeName[intIndex])
{
return mstrzxScoreTypeId;
}
else if (conzx_SysScoreType.ScoreTypeName  ==  AttributeName[intIndex])
{
return mstrScoreTypeName;
}
else if (conzx_SysScoreType.OnlyId  ==  AttributeName[intIndex])
{
return mstrOnlyId;
}
else if (conzx_SysScoreType.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_SysScoreType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_SysScoreType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_SysScoreType.zxScoreTypeId  ==  AttributeName[intIndex])
{
mstrzxScoreTypeId = value.ToString();
 AddUpdatedFld(conzx_SysScoreType.zxScoreTypeId);
}
else if (conzx_SysScoreType.ScoreTypeName  ==  AttributeName[intIndex])
{
mstrScoreTypeName = value.ToString();
 AddUpdatedFld(conzx_SysScoreType.ScoreTypeName);
}
else if (conzx_SysScoreType.OnlyId  ==  AttributeName[intIndex])
{
mstrOnlyId = value.ToString();
 AddUpdatedFld(conzx_SysScoreType.OnlyId);
}
else if (conzx_SysScoreType.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_SysScoreType.UpdUser);
}
else if (conzx_SysScoreType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_SysScoreType.UpdDate);
}
else if (conzx_SysScoreType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_SysScoreType.Memo);
}
}
}

/// <summary>
/// 分数类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxScoreTypeId
{
get
{
return mstrzxScoreTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxScoreTypeId = value;
}
else
{
 mstrzxScoreTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_SysScoreType.zxScoreTypeId);
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
 AddUpdatedFld(conzx_SysScoreType.ScoreTypeName);
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
 AddUpdatedFld(conzx_SysScoreType.OnlyId);
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
 AddUpdatedFld(conzx_SysScoreType.UpdUser);
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
 AddUpdatedFld(conzx_SysScoreType.UpdDate);
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
 AddUpdatedFld(conzx_SysScoreType.Memo);
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
  return mstrzxScoreTypeId;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrScoreTypeName;
 }
 }
}
 /// <summary>
 /// 中学评分类型表(zx_SysScoreType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_SysScoreType
{
public const string _CurrTabName = "zx_SysScoreType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxScoreTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxScoreTypeId", "ScoreTypeName", "OnlyId", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxScoreTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxScoreTypeId = "zxScoreTypeId";    //分数类型Id

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
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

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