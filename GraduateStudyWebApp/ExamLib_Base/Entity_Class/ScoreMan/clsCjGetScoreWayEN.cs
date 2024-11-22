
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCjGetScoreWayEN
 表名:CjGetScoreWay(01120575)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:20:53
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
 /// 表CjGetScoreWay的关键字(GetScoreWayId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_GetScoreWayId_CjGetScoreWay
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strGetScoreWayId">表关键字</param>
public K_GetScoreWayId_CjGetScoreWay(string strGetScoreWayId)
{
if (IsValid(strGetScoreWayId)) Value = strGetScoreWayId;
else
{
Value = null;
}
}
private static bool IsValid(string strGetScoreWayId)
{
if (string.IsNullOrEmpty(strGetScoreWayId) == true) return false;
if (strGetScoreWayId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_GetScoreWayId_CjGetScoreWay]类型的对象</returns>
public static implicit operator K_GetScoreWayId_CjGetScoreWay(string value)
{
return new K_GetScoreWayId_CjGetScoreWay(value);
}
}
 /// <summary>
 /// 成绩导入方式(CjGetScoreWay)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCjGetScoreWayEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CjGetScoreWay"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "GetScoreWayId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"GetScoreWayId", "GetScoreWayName", "Memo"};

protected string mstrGetScoreWayId;    //获得成绩方式Id
protected string mstrGetScoreWayName;    //获得成绩方式名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsCjGetScoreWayEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("GetScoreWayId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strGetScoreWayId">关键字:获得成绩方式Id</param>
public clsCjGetScoreWayEN(string strGetScoreWayId)
 {
strGetScoreWayId = strGetScoreWayId.Replace("'", "''");
if (strGetScoreWayId.Length > 2)
{
throw new Exception("在表:CjGetScoreWay中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strGetScoreWayId)  ==  true)
{
throw new Exception("在表:CjGetScoreWay中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strGetScoreWayId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrGetScoreWayId = strGetScoreWayId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("GetScoreWayId");
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
if (strAttributeName  ==  conCjGetScoreWay.GetScoreWayId)
{
return mstrGetScoreWayId;
}
else if (strAttributeName  ==  conCjGetScoreWay.GetScoreWayName)
{
return mstrGetScoreWayName;
}
else if (strAttributeName  ==  conCjGetScoreWay.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCjGetScoreWay.GetScoreWayId)
{
mstrGetScoreWayId = value.ToString();
 AddUpdatedFld(conCjGetScoreWay.GetScoreWayId);
}
else if (strAttributeName  ==  conCjGetScoreWay.GetScoreWayName)
{
mstrGetScoreWayName = value.ToString();
 AddUpdatedFld(conCjGetScoreWay.GetScoreWayName);
}
else if (strAttributeName  ==  conCjGetScoreWay.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCjGetScoreWay.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCjGetScoreWay.GetScoreWayId  ==  AttributeName[intIndex])
{
return mstrGetScoreWayId;
}
else if (conCjGetScoreWay.GetScoreWayName  ==  AttributeName[intIndex])
{
return mstrGetScoreWayName;
}
else if (conCjGetScoreWay.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCjGetScoreWay.GetScoreWayId  ==  AttributeName[intIndex])
{
mstrGetScoreWayId = value.ToString();
 AddUpdatedFld(conCjGetScoreWay.GetScoreWayId);
}
else if (conCjGetScoreWay.GetScoreWayName  ==  AttributeName[intIndex])
{
mstrGetScoreWayName = value.ToString();
 AddUpdatedFld(conCjGetScoreWay.GetScoreWayName);
}
else if (conCjGetScoreWay.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCjGetScoreWay.Memo);
}
}
}

/// <summary>
/// 获得成绩方式Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GetScoreWayId
{
get
{
return mstrGetScoreWayId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGetScoreWayId = value;
}
else
{
 mstrGetScoreWayId = value;
}
//记录修改过的字段
 AddUpdatedFld(conCjGetScoreWay.GetScoreWayId);
}
}
/// <summary>
/// 获得成绩方式名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GetScoreWayName
{
get
{
return mstrGetScoreWayName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGetScoreWayName = value;
}
else
{
 mstrGetScoreWayName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCjGetScoreWay.GetScoreWayName);
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
 AddUpdatedFld(conCjGetScoreWay.Memo);
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
  return mstrGetScoreWayId;
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
  return mstrGetScoreWayName;
 }
 }
}
 /// <summary>
 /// 成绩导入方式(CjGetScoreWay)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCjGetScoreWay
{
public const string _CurrTabName = "CjGetScoreWay"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "GetScoreWayId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"GetScoreWayId", "GetScoreWayName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"GetScoreWayId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GetScoreWayId = "GetScoreWayId";    //获得成绩方式Id

 /// <summary>
 /// 常量:"GetScoreWayName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GetScoreWayName = "GetScoreWayName";    //获得成绩方式名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}