
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_KnowledgeTypeEN
 表名:gs_KnowledgeType(01120954)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:05:59
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培参数(RT_Params)
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
 /// 表gs_KnowledgeType的关键字(gsKnowledgeTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_gsKnowledgeTypeId_gs_KnowledgeType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strgsKnowledgeTypeId">表关键字</param>
public K_gsKnowledgeTypeId_gs_KnowledgeType(string strgsKnowledgeTypeId)
{
if (IsValid(strgsKnowledgeTypeId)) Value = strgsKnowledgeTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strgsKnowledgeTypeId)
{
if (string.IsNullOrEmpty(strgsKnowledgeTypeId) == true) return false;
if (strgsKnowledgeTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_gsKnowledgeTypeId_gs_KnowledgeType]类型的对象</returns>
public static implicit operator K_gsKnowledgeTypeId_gs_KnowledgeType(string value)
{
return new K_gsKnowledgeTypeId_gs_KnowledgeType(value);
}
}
 /// <summary>
 /// 知识类型(gs_KnowledgeType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_KnowledgeTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_KnowledgeType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "gsKnowledgeTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"gsKnowledgeTypeId", "gsKnowledgeTypeName", "KnowledgeTypeENName", "OrderNum", "UpdDate", "UpdUser", "Memo"};

protected string mstrgsKnowledgeTypeId;    //知识类型Id
protected string mstrgsKnowledgeTypeName;    //知识类型名
protected string mstrKnowledgeTypeENName;    //知识类型英文名
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_KnowledgeTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("gsKnowledgeTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strgsKnowledgeTypeId">关键字:知识类型Id</param>
public clsgs_KnowledgeTypeEN(string strgsKnowledgeTypeId)
 {
strgsKnowledgeTypeId = strgsKnowledgeTypeId.Replace("'", "''");
if (strgsKnowledgeTypeId.Length > 2)
{
throw new Exception("在表:gs_KnowledgeType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strgsKnowledgeTypeId)  ==  true)
{
throw new Exception("在表:gs_KnowledgeType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strgsKnowledgeTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrgsKnowledgeTypeId = strgsKnowledgeTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("gsKnowledgeTypeId");
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
if (strAttributeName  ==  congs_KnowledgeType.gsKnowledgeTypeId)
{
return mstrgsKnowledgeTypeId;
}
else if (strAttributeName  ==  congs_KnowledgeType.gsKnowledgeTypeName)
{
return mstrgsKnowledgeTypeName;
}
else if (strAttributeName  ==  congs_KnowledgeType.KnowledgeTypeENName)
{
return mstrKnowledgeTypeENName;
}
else if (strAttributeName  ==  congs_KnowledgeType.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  congs_KnowledgeType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  congs_KnowledgeType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  congs_KnowledgeType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  congs_KnowledgeType.gsKnowledgeTypeId)
{
mstrgsKnowledgeTypeId = value.ToString();
 AddUpdatedFld(congs_KnowledgeType.gsKnowledgeTypeId);
}
else if (strAttributeName  ==  congs_KnowledgeType.gsKnowledgeTypeName)
{
mstrgsKnowledgeTypeName = value.ToString();
 AddUpdatedFld(congs_KnowledgeType.gsKnowledgeTypeName);
}
else if (strAttributeName  ==  congs_KnowledgeType.KnowledgeTypeENName)
{
mstrKnowledgeTypeENName = value.ToString();
 AddUpdatedFld(congs_KnowledgeType.KnowledgeTypeENName);
}
else if (strAttributeName  ==  congs_KnowledgeType.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_KnowledgeType.OrderNum);
}
else if (strAttributeName  ==  congs_KnowledgeType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_KnowledgeType.UpdDate);
}
else if (strAttributeName  ==  congs_KnowledgeType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_KnowledgeType.UpdUser);
}
else if (strAttributeName  ==  congs_KnowledgeType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_KnowledgeType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_KnowledgeType.gsKnowledgeTypeId  ==  AttributeName[intIndex])
{
return mstrgsKnowledgeTypeId;
}
else if (congs_KnowledgeType.gsKnowledgeTypeName  ==  AttributeName[intIndex])
{
return mstrgsKnowledgeTypeName;
}
else if (congs_KnowledgeType.KnowledgeTypeENName  ==  AttributeName[intIndex])
{
return mstrKnowledgeTypeENName;
}
else if (congs_KnowledgeType.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (congs_KnowledgeType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (congs_KnowledgeType.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (congs_KnowledgeType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (congs_KnowledgeType.gsKnowledgeTypeId  ==  AttributeName[intIndex])
{
mstrgsKnowledgeTypeId = value.ToString();
 AddUpdatedFld(congs_KnowledgeType.gsKnowledgeTypeId);
}
else if (congs_KnowledgeType.gsKnowledgeTypeName  ==  AttributeName[intIndex])
{
mstrgsKnowledgeTypeName = value.ToString();
 AddUpdatedFld(congs_KnowledgeType.gsKnowledgeTypeName);
}
else if (congs_KnowledgeType.KnowledgeTypeENName  ==  AttributeName[intIndex])
{
mstrKnowledgeTypeENName = value.ToString();
 AddUpdatedFld(congs_KnowledgeType.KnowledgeTypeENName);
}
else if (congs_KnowledgeType.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_KnowledgeType.OrderNum);
}
else if (congs_KnowledgeType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_KnowledgeType.UpdDate);
}
else if (congs_KnowledgeType.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_KnowledgeType.UpdUser);
}
else if (congs_KnowledgeType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_KnowledgeType.Memo);
}
}
}

/// <summary>
/// 知识类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string gsKnowledgeTypeId
{
get
{
return mstrgsKnowledgeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrgsKnowledgeTypeId = value;
}
else
{
 mstrgsKnowledgeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_KnowledgeType.gsKnowledgeTypeId);
}
}
/// <summary>
/// 知识类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string gsKnowledgeTypeName
{
get
{
return mstrgsKnowledgeTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrgsKnowledgeTypeName = value;
}
else
{
 mstrgsKnowledgeTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_KnowledgeType.gsKnowledgeTypeName);
}
}
/// <summary>
/// 知识类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KnowledgeTypeENName
{
get
{
return mstrKnowledgeTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKnowledgeTypeENName = value;
}
else
{
 mstrKnowledgeTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_KnowledgeType.KnowledgeTypeENName);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(congs_KnowledgeType.OrderNum);
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
 AddUpdatedFld(congs_KnowledgeType.UpdDate);
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
 AddUpdatedFld(congs_KnowledgeType.UpdUser);
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
 AddUpdatedFld(congs_KnowledgeType.Memo);
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
  return mstrgsKnowledgeTypeId;
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
  return mstrgsKnowledgeTypeName;
 }
 }
}
 /// <summary>
 /// 知识类型(gs_KnowledgeType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_KnowledgeType
{
public const string _CurrTabName = "gs_KnowledgeType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "gsKnowledgeTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"gsKnowledgeTypeId", "gsKnowledgeTypeName", "KnowledgeTypeENName", "OrderNum", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"gsKnowledgeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string gsKnowledgeTypeId = "gsKnowledgeTypeId";    //知识类型Id

 /// <summary>
 /// 常量:"gsKnowledgeTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string gsKnowledgeTypeName = "gsKnowledgeTypeName";    //知识类型名

 /// <summary>
 /// 常量:"KnowledgeTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KnowledgeTypeENName = "KnowledgeTypeENName";    //知识类型英文名

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

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
}

}