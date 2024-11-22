
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSubViewpointTypeEN
 表名:SubViewpointType(01120533)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:14:32
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
 /// 表SubViewpointType的关键字(SubViewpointTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_SubViewpointTypeId_SubViewpointType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strSubViewpointTypeId">表关键字</param>
public K_SubViewpointTypeId_SubViewpointType(string strSubViewpointTypeId)
{
if (IsValid(strSubViewpointTypeId)) Value = strSubViewpointTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strSubViewpointTypeId)
{
if (string.IsNullOrEmpty(strSubViewpointTypeId) == true) return false;
if (strSubViewpointTypeId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_SubViewpointTypeId_SubViewpointType]类型的对象</returns>
public static implicit operator K_SubViewpointTypeId_SubViewpointType(string value)
{
return new K_SubViewpointTypeId_SubViewpointType(value);
}
}
 /// <summary>
 /// 子观点类型表(SubViewpointType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSubViewpointTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SubViewpointType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "SubViewpointTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"SubViewpointTypeId", "SubViewpointTypeName", "SubViewpointTypeENName", "DefaTitle", "OrderNum", "UpdDate", "UpdUserId", "Memo"};

protected string mstrSubViewpointTypeId;    //类型Id
protected string mstrSubViewpointTypeName;    //类型名称
protected string mstrSubViewpointTypeENName;    //类型英文名
protected string mstrDefaTitle;    //默认标题
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsSubViewpointTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SubViewpointTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strSubViewpointTypeId">关键字:类型Id</param>
public clsSubViewpointTypeEN(string strSubViewpointTypeId)
 {
strSubViewpointTypeId = strSubViewpointTypeId.Replace("'", "''");
if (strSubViewpointTypeId.Length > 8)
{
throw new Exception("在表:SubViewpointType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strSubViewpointTypeId)  ==  true)
{
throw new Exception("在表:SubViewpointType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSubViewpointTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrSubViewpointTypeId = strSubViewpointTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SubViewpointTypeId");
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
if (strAttributeName  ==  conSubViewpointType.SubViewpointTypeId)
{
return mstrSubViewpointTypeId;
}
else if (strAttributeName  ==  conSubViewpointType.SubViewpointTypeName)
{
return mstrSubViewpointTypeName;
}
else if (strAttributeName  ==  conSubViewpointType.SubViewpointTypeENName)
{
return mstrSubViewpointTypeENName;
}
else if (strAttributeName  ==  conSubViewpointType.DefaTitle)
{
return mstrDefaTitle;
}
else if (strAttributeName  ==  conSubViewpointType.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conSubViewpointType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conSubViewpointType.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conSubViewpointType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conSubViewpointType.SubViewpointTypeId)
{
mstrSubViewpointTypeId = value.ToString();
 AddUpdatedFld(conSubViewpointType.SubViewpointTypeId);
}
else if (strAttributeName  ==  conSubViewpointType.SubViewpointTypeName)
{
mstrSubViewpointTypeName = value.ToString();
 AddUpdatedFld(conSubViewpointType.SubViewpointTypeName);
}
else if (strAttributeName  ==  conSubViewpointType.SubViewpointTypeENName)
{
mstrSubViewpointTypeENName = value.ToString();
 AddUpdatedFld(conSubViewpointType.SubViewpointTypeENName);
}
else if (strAttributeName  ==  conSubViewpointType.DefaTitle)
{
mstrDefaTitle = value.ToString();
 AddUpdatedFld(conSubViewpointType.DefaTitle);
}
else if (strAttributeName  ==  conSubViewpointType.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conSubViewpointType.OrderNum);
}
else if (strAttributeName  ==  conSubViewpointType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSubViewpointType.UpdDate);
}
else if (strAttributeName  ==  conSubViewpointType.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conSubViewpointType.UpdUserId);
}
else if (strAttributeName  ==  conSubViewpointType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSubViewpointType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conSubViewpointType.SubViewpointTypeId  ==  AttributeName[intIndex])
{
return mstrSubViewpointTypeId;
}
else if (conSubViewpointType.SubViewpointTypeName  ==  AttributeName[intIndex])
{
return mstrSubViewpointTypeName;
}
else if (conSubViewpointType.SubViewpointTypeENName  ==  AttributeName[intIndex])
{
return mstrSubViewpointTypeENName;
}
else if (conSubViewpointType.DefaTitle  ==  AttributeName[intIndex])
{
return mstrDefaTitle;
}
else if (conSubViewpointType.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conSubViewpointType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conSubViewpointType.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conSubViewpointType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conSubViewpointType.SubViewpointTypeId  ==  AttributeName[intIndex])
{
mstrSubViewpointTypeId = value.ToString();
 AddUpdatedFld(conSubViewpointType.SubViewpointTypeId);
}
else if (conSubViewpointType.SubViewpointTypeName  ==  AttributeName[intIndex])
{
mstrSubViewpointTypeName = value.ToString();
 AddUpdatedFld(conSubViewpointType.SubViewpointTypeName);
}
else if (conSubViewpointType.SubViewpointTypeENName  ==  AttributeName[intIndex])
{
mstrSubViewpointTypeENName = value.ToString();
 AddUpdatedFld(conSubViewpointType.SubViewpointTypeENName);
}
else if (conSubViewpointType.DefaTitle  ==  AttributeName[intIndex])
{
mstrDefaTitle = value.ToString();
 AddUpdatedFld(conSubViewpointType.DefaTitle);
}
else if (conSubViewpointType.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conSubViewpointType.OrderNum);
}
else if (conSubViewpointType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conSubViewpointType.UpdDate);
}
else if (conSubViewpointType.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conSubViewpointType.UpdUserId);
}
else if (conSubViewpointType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSubViewpointType.Memo);
}
}
}

/// <summary>
/// 类型Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SubViewpointTypeId
{
get
{
return mstrSubViewpointTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSubViewpointTypeId = value;
}
else
{
 mstrSubViewpointTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSubViewpointType.SubViewpointTypeId);
}
}
/// <summary>
/// 类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SubViewpointTypeName
{
get
{
return mstrSubViewpointTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSubViewpointTypeName = value;
}
else
{
 mstrSubViewpointTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSubViewpointType.SubViewpointTypeName);
}
}
/// <summary>
/// 类型英文名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SubViewpointTypeENName
{
get
{
return mstrSubViewpointTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSubViewpointTypeENName = value;
}
else
{
 mstrSubViewpointTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSubViewpointType.SubViewpointTypeENName);
}
}
/// <summary>
/// 默认标题(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DefaTitle
{
get
{
return mstrDefaTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDefaTitle = value;
}
else
{
 mstrDefaTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(conSubViewpointType.DefaTitle);
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
 AddUpdatedFld(conSubViewpointType.OrderNum);
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
 AddUpdatedFld(conSubViewpointType.UpdDate);
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
 AddUpdatedFld(conSubViewpointType.UpdUserId);
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
 AddUpdatedFld(conSubViewpointType.Memo);
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
  return mstrSubViewpointTypeId;
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
  return mstrSubViewpointTypeName;
 }
 }
}
 /// <summary>
 /// 子观点类型表(SubViewpointType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSubViewpointType
{
public const string _CurrTabName = "SubViewpointType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SubViewpointTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"SubViewpointTypeId", "SubViewpointTypeName", "SubViewpointTypeENName", "DefaTitle", "OrderNum", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"SubViewpointTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubViewpointTypeId = "SubViewpointTypeId";    //类型Id

 /// <summary>
 /// 常量:"SubViewpointTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubViewpointTypeName = "SubViewpointTypeName";    //类型名称

 /// <summary>
 /// 常量:"SubViewpointTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubViewpointTypeENName = "SubViewpointTypeENName";    //类型英文名

 /// <summary>
 /// 常量:"DefaTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaTitle = "DefaTitle";    //默认标题

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