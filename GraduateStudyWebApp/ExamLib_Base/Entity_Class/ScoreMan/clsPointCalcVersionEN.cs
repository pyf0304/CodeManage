
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPointCalcVersionEN
 表名:PointCalcVersion(01120577)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:20:57
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:成绩管理(ScoreMan)
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
 /// 表PointCalcVersion的关键字(PointCalcVersionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PointCalcVersionId_PointCalcVersion
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPointCalcVersionId">表关键字</param>
public K_PointCalcVersionId_PointCalcVersion(string strPointCalcVersionId)
{
if (IsValid(strPointCalcVersionId)) Value = strPointCalcVersionId;
else
{
Value = null;
}
}
private static bool IsValid(string strPointCalcVersionId)
{
if (string.IsNullOrEmpty(strPointCalcVersionId) == true) return false;
if (strPointCalcVersionId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PointCalcVersionId_PointCalcVersion]类型的对象</returns>
public static implicit operator K_PointCalcVersionId_PointCalcVersion(string value)
{
return new K_PointCalcVersionId_PointCalcVersion(value);
}
}
 /// <summary>
 /// 绩点计算版本(PointCalcVersion)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPointCalcVersionEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PointCalcVersion"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PointCalcVersionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"PointCalcVersionId", "PointCalcVersionName", "PointCalcVersionNameSim", "Memo"};

protected string mstrPointCalcVersionId;    //绩点计算版本Id
protected string mstrPointCalcVersionName;    //绩点计算版本名称
protected string mstrPointCalcVersionNameSim;    //绩点计算版本简称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsPointCalcVersionEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PointCalcVersionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strPointCalcVersionId">关键字:绩点计算版本Id</param>
public clsPointCalcVersionEN(string strPointCalcVersionId)
 {
strPointCalcVersionId = strPointCalcVersionId.Replace("'", "''");
if (strPointCalcVersionId.Length > 2)
{
throw new Exception("在表:PointCalcVersion中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPointCalcVersionId)  ==  true)
{
throw new Exception("在表:PointCalcVersion中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPointCalcVersionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPointCalcVersionId = strPointCalcVersionId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PointCalcVersionId");
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
if (strAttributeName  ==  conPointCalcVersion.PointCalcVersionId)
{
return mstrPointCalcVersionId;
}
else if (strAttributeName  ==  conPointCalcVersion.PointCalcVersionName)
{
return mstrPointCalcVersionName;
}
else if (strAttributeName  ==  conPointCalcVersion.PointCalcVersionNameSim)
{
return mstrPointCalcVersionNameSim;
}
else if (strAttributeName  ==  conPointCalcVersion.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPointCalcVersion.PointCalcVersionId)
{
mstrPointCalcVersionId = value.ToString();
 AddUpdatedFld(conPointCalcVersion.PointCalcVersionId);
}
else if (strAttributeName  ==  conPointCalcVersion.PointCalcVersionName)
{
mstrPointCalcVersionName = value.ToString();
 AddUpdatedFld(conPointCalcVersion.PointCalcVersionName);
}
else if (strAttributeName  ==  conPointCalcVersion.PointCalcVersionNameSim)
{
mstrPointCalcVersionNameSim = value.ToString();
 AddUpdatedFld(conPointCalcVersion.PointCalcVersionNameSim);
}
else if (strAttributeName  ==  conPointCalcVersion.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPointCalcVersion.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPointCalcVersion.PointCalcVersionId  ==  AttributeName[intIndex])
{
return mstrPointCalcVersionId;
}
else if (conPointCalcVersion.PointCalcVersionName  ==  AttributeName[intIndex])
{
return mstrPointCalcVersionName;
}
else if (conPointCalcVersion.PointCalcVersionNameSim  ==  AttributeName[intIndex])
{
return mstrPointCalcVersionNameSim;
}
else if (conPointCalcVersion.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPointCalcVersion.PointCalcVersionId  ==  AttributeName[intIndex])
{
mstrPointCalcVersionId = value.ToString();
 AddUpdatedFld(conPointCalcVersion.PointCalcVersionId);
}
else if (conPointCalcVersion.PointCalcVersionName  ==  AttributeName[intIndex])
{
mstrPointCalcVersionName = value.ToString();
 AddUpdatedFld(conPointCalcVersion.PointCalcVersionName);
}
else if (conPointCalcVersion.PointCalcVersionNameSim  ==  AttributeName[intIndex])
{
mstrPointCalcVersionNameSim = value.ToString();
 AddUpdatedFld(conPointCalcVersion.PointCalcVersionNameSim);
}
else if (conPointCalcVersion.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPointCalcVersion.Memo);
}
}
}

/// <summary>
/// 绩点计算版本Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PointCalcVersionId
{
get
{
return mstrPointCalcVersionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPointCalcVersionId = value;
}
else
{
 mstrPointCalcVersionId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPointCalcVersion.PointCalcVersionId);
}
}
/// <summary>
/// 绩点计算版本名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PointCalcVersionName
{
get
{
return mstrPointCalcVersionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPointCalcVersionName = value;
}
else
{
 mstrPointCalcVersionName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPointCalcVersion.PointCalcVersionName);
}
}
/// <summary>
/// 绩点计算版本简称(说明:;字段类型:varchar;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PointCalcVersionNameSim
{
get
{
return mstrPointCalcVersionNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPointCalcVersionNameSim = value;
}
else
{
 mstrPointCalcVersionNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(conPointCalcVersion.PointCalcVersionNameSim);
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
 AddUpdatedFld(conPointCalcVersion.Memo);
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
  return mstrPointCalcVersionId;
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
  return mstrPointCalcVersionName;
 }
 }
}
 /// <summary>
 /// 绩点计算版本(PointCalcVersion)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPointCalcVersion
{
public const string _CurrTabName = "PointCalcVersion"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PointCalcVersionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PointCalcVersionId", "PointCalcVersionName", "PointCalcVersionNameSim", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"PointCalcVersionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PointCalcVersionId = "PointCalcVersionId";    //绩点计算版本Id

 /// <summary>
 /// 常量:"PointCalcVersionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PointCalcVersionName = "PointCalcVersionName";    //绩点计算版本名称

 /// <summary>
 /// 常量:"PointCalcVersionNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PointCalcVersionNameSim = "PointCalcVersionNameSim";    //绩点计算版本简称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}