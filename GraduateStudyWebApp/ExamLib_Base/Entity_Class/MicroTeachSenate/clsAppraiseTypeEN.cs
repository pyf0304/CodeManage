
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAppraiseTypeEN
 表名:AppraiseType(01120307)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:19:22
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
 /// 表AppraiseType的关键字(IdAppraiseType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdAppraiseType_AppraiseType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdAppraiseType">表关键字</param>
public K_IdAppraiseType_AppraiseType(string strIdAppraiseType)
{
if (IsValid(strIdAppraiseType)) Value = strIdAppraiseType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdAppraiseType)
{
if (string.IsNullOrEmpty(strIdAppraiseType) == true) return false;
if (strIdAppraiseType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdAppraiseType_AppraiseType]类型的对象</returns>
public static implicit operator K_IdAppraiseType_AppraiseType(string value)
{
return new K_IdAppraiseType_AppraiseType(value);
}
}
 /// <summary>
 /// 评价类型(AppraiseType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsAppraiseTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "AppraiseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdAppraiseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"IdAppraiseType", "AppraiseTypeID", "AppraiseTypeName", "AppraiseTypeName4CW", "UserTypeId", "Memo", "AppraiseTypeNameSim", "OrderNum"};

protected string mstrIdAppraiseType;    //评议类型流水号
protected string mstrAppraiseTypeID;    //评议类型ID
protected string mstrAppraiseTypeName;    //评议类型名称
protected string mstrAppraiseTypeName4CW;    //评议类型名称4课件
protected string mstrUserTypeId;    //用户类型Id
protected string mstrMemo;    //备注
protected string mstrAppraiseTypeNameSim;    //评议类型名称_Sim
protected int? mintOrderNum;    //序号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsAppraiseTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdAppraiseType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdAppraiseType">关键字:评议类型流水号</param>
public clsAppraiseTypeEN(string strIdAppraiseType)
 {
strIdAppraiseType = strIdAppraiseType.Replace("'", "''");
if (strIdAppraiseType.Length > 4)
{
throw new Exception("在表:AppraiseType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdAppraiseType)  ==  true)
{
throw new Exception("在表:AppraiseType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdAppraiseType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdAppraiseType = strIdAppraiseType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdAppraiseType");
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
if (strAttributeName  ==  conAppraiseType.IdAppraiseType)
{
return mstrIdAppraiseType;
}
else if (strAttributeName  ==  conAppraiseType.AppraiseTypeID)
{
return mstrAppraiseTypeID;
}
else if (strAttributeName  ==  conAppraiseType.AppraiseTypeName)
{
return mstrAppraiseTypeName;
}
else if (strAttributeName  ==  conAppraiseType.AppraiseTypeName4CW)
{
return mstrAppraiseTypeName4CW;
}
else if (strAttributeName  ==  conAppraiseType.UserTypeId)
{
return mstrUserTypeId;
}
else if (strAttributeName  ==  conAppraiseType.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conAppraiseType.AppraiseTypeNameSim)
{
return mstrAppraiseTypeNameSim;
}
else if (strAttributeName  ==  conAppraiseType.OrderNum)
{
return mintOrderNum;
}
return null;
}
set
{
if (strAttributeName  ==  conAppraiseType.IdAppraiseType)
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(conAppraiseType.IdAppraiseType);
}
else if (strAttributeName  ==  conAppraiseType.AppraiseTypeID)
{
mstrAppraiseTypeID = value.ToString();
 AddUpdatedFld(conAppraiseType.AppraiseTypeID);
}
else if (strAttributeName  ==  conAppraiseType.AppraiseTypeName)
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(conAppraiseType.AppraiseTypeName);
}
else if (strAttributeName  ==  conAppraiseType.AppraiseTypeName4CW)
{
mstrAppraiseTypeName4CW = value.ToString();
 AddUpdatedFld(conAppraiseType.AppraiseTypeName4CW);
}
else if (strAttributeName  ==  conAppraiseType.UserTypeId)
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(conAppraiseType.UserTypeId);
}
else if (strAttributeName  ==  conAppraiseType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conAppraiseType.Memo);
}
else if (strAttributeName  ==  conAppraiseType.AppraiseTypeNameSim)
{
mstrAppraiseTypeNameSim = value.ToString();
 AddUpdatedFld(conAppraiseType.AppraiseTypeNameSim);
}
else if (strAttributeName  ==  conAppraiseType.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conAppraiseType.OrderNum);
}
}
}
public object this[int intIndex]
{
get
{
if (conAppraiseType.IdAppraiseType  ==  AttributeName[intIndex])
{
return mstrIdAppraiseType;
}
else if (conAppraiseType.AppraiseTypeID  ==  AttributeName[intIndex])
{
return mstrAppraiseTypeID;
}
else if (conAppraiseType.AppraiseTypeName  ==  AttributeName[intIndex])
{
return mstrAppraiseTypeName;
}
else if (conAppraiseType.AppraiseTypeName4CW  ==  AttributeName[intIndex])
{
return mstrAppraiseTypeName4CW;
}
else if (conAppraiseType.UserTypeId  ==  AttributeName[intIndex])
{
return mstrUserTypeId;
}
else if (conAppraiseType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conAppraiseType.AppraiseTypeNameSim  ==  AttributeName[intIndex])
{
return mstrAppraiseTypeNameSim;
}
else if (conAppraiseType.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
return null;
}
set
{
if (conAppraiseType.IdAppraiseType  ==  AttributeName[intIndex])
{
mstrIdAppraiseType = value.ToString();
 AddUpdatedFld(conAppraiseType.IdAppraiseType);
}
else if (conAppraiseType.AppraiseTypeID  ==  AttributeName[intIndex])
{
mstrAppraiseTypeID = value.ToString();
 AddUpdatedFld(conAppraiseType.AppraiseTypeID);
}
else if (conAppraiseType.AppraiseTypeName  ==  AttributeName[intIndex])
{
mstrAppraiseTypeName = value.ToString();
 AddUpdatedFld(conAppraiseType.AppraiseTypeName);
}
else if (conAppraiseType.AppraiseTypeName4CW  ==  AttributeName[intIndex])
{
mstrAppraiseTypeName4CW = value.ToString();
 AddUpdatedFld(conAppraiseType.AppraiseTypeName4CW);
}
else if (conAppraiseType.UserTypeId  ==  AttributeName[intIndex])
{
mstrUserTypeId = value.ToString();
 AddUpdatedFld(conAppraiseType.UserTypeId);
}
else if (conAppraiseType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conAppraiseType.Memo);
}
else if (conAppraiseType.AppraiseTypeNameSim  ==  AttributeName[intIndex])
{
mstrAppraiseTypeNameSim = value.ToString();
 AddUpdatedFld(conAppraiseType.AppraiseTypeNameSim);
}
else if (conAppraiseType.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conAppraiseType.OrderNum);
}
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
 AddUpdatedFld(conAppraiseType.IdAppraiseType);
}
}
/// <summary>
/// 评议类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppraiseTypeID
{
get
{
return mstrAppraiseTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppraiseTypeID = value;
}
else
{
 mstrAppraiseTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(conAppraiseType.AppraiseTypeID);
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
 AddUpdatedFld(conAppraiseType.AppraiseTypeName);
}
}
/// <summary>
/// 评议类型名称4课件(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppraiseTypeName4CW
{
get
{
return mstrAppraiseTypeName4CW;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppraiseTypeName4CW = value;
}
else
{
 mstrAppraiseTypeName4CW = value;
}
//记录修改过的字段
 AddUpdatedFld(conAppraiseType.AppraiseTypeName4CW);
}
}
/// <summary>
/// 用户类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserTypeId
{
get
{
return mstrUserTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserTypeId = value;
}
else
{
 mstrUserTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conAppraiseType.UserTypeId);
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
 AddUpdatedFld(conAppraiseType.Memo);
}
}
/// <summary>
/// 评议类型名称_Sim(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AppraiseTypeNameSim
{
get
{
return mstrAppraiseTypeNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAppraiseTypeNameSim = value;
}
else
{
 mstrAppraiseTypeNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(conAppraiseType.AppraiseTypeNameSim);
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
 AddUpdatedFld(conAppraiseType.OrderNum);
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
  return mstrIdAppraiseType;
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
  return mstrAppraiseTypeName;
 }
 }
}
 /// <summary>
 /// 评价类型(AppraiseType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conAppraiseType
{
public const string _CurrTabName = "AppraiseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdAppraiseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdAppraiseType", "AppraiseTypeID", "AppraiseTypeName", "AppraiseTypeName4CW", "UserTypeId", "Memo", "AppraiseTypeNameSim", "OrderNum"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdAppraiseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdAppraiseType = "IdAppraiseType";    //评议类型流水号

 /// <summary>
 /// 常量:"AppraiseTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseTypeID = "AppraiseTypeID";    //评议类型ID

 /// <summary>
 /// 常量:"AppraiseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseTypeName = "AppraiseTypeName";    //评议类型名称

 /// <summary>
 /// 常量:"AppraiseTypeName4CW"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseTypeName4CW = "AppraiseTypeName4CW";    //评议类型名称4课件

 /// <summary>
 /// 常量:"UserTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserTypeId = "UserTypeId";    //用户类型Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"AppraiseTypeNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AppraiseTypeNameSim = "AppraiseTypeNameSim";    //评议类型名称_Sim

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号
}

}