
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ExplainTypeEN
 表名:zx_ExplainType(01120815)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:54:34
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
 /// 表zx_ExplainType的关键字(zxExplainTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxExplainTypeId_zx_ExplainType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxExplainTypeId">表关键字</param>
public K_zxExplainTypeId_zx_ExplainType(string strzxExplainTypeId)
{
if (IsValid(strzxExplainTypeId)) Value = strzxExplainTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxExplainTypeId)
{
if (string.IsNullOrEmpty(strzxExplainTypeId) == true) return false;
if (strzxExplainTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxExplainTypeId_zx_ExplainType]类型的对象</returns>
public static implicit operator K_zxExplainTypeId_zx_ExplainType(string value)
{
return new K_zxExplainTypeId_zx_ExplainType(value);
}
}
 /// <summary>
 /// 中学说明类型(zx_ExplainType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_ExplainTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_ExplainType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxExplainTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"zxExplainTypeId", "ExplainTypeName", "UpdDate", "UpdUserId", "Memo"};

protected string mstrzxExplainTypeId;    //说明类型Id
protected string mstrExplainTypeName;    //说明类型名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_ExplainTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxExplainTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxExplainTypeId">关键字:说明类型Id</param>
public clszx_ExplainTypeEN(string strzxExplainTypeId)
 {
strzxExplainTypeId = strzxExplainTypeId.Replace("'", "''");
if (strzxExplainTypeId.Length > 2)
{
throw new Exception("在表:zx_ExplainType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxExplainTypeId)  ==  true)
{
throw new Exception("在表:zx_ExplainType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxExplainTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxExplainTypeId = strzxExplainTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxExplainTypeId");
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
if (strAttributeName  ==  conzx_ExplainType.zxExplainTypeId)
{
return mstrzxExplainTypeId;
}
else if (strAttributeName  ==  conzx_ExplainType.ExplainTypeName)
{
return mstrExplainTypeName;
}
else if (strAttributeName  ==  conzx_ExplainType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_ExplainType.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conzx_ExplainType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_ExplainType.zxExplainTypeId)
{
mstrzxExplainTypeId = value.ToString();
 AddUpdatedFld(conzx_ExplainType.zxExplainTypeId);
}
else if (strAttributeName  ==  conzx_ExplainType.ExplainTypeName)
{
mstrExplainTypeName = value.ToString();
 AddUpdatedFld(conzx_ExplainType.ExplainTypeName);
}
else if (strAttributeName  ==  conzx_ExplainType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_ExplainType.UpdDate);
}
else if (strAttributeName  ==  conzx_ExplainType.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conzx_ExplainType.UpdUserId);
}
else if (strAttributeName  ==  conzx_ExplainType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_ExplainType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_ExplainType.zxExplainTypeId  ==  AttributeName[intIndex])
{
return mstrzxExplainTypeId;
}
else if (conzx_ExplainType.ExplainTypeName  ==  AttributeName[intIndex])
{
return mstrExplainTypeName;
}
else if (conzx_ExplainType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_ExplainType.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conzx_ExplainType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_ExplainType.zxExplainTypeId  ==  AttributeName[intIndex])
{
mstrzxExplainTypeId = value.ToString();
 AddUpdatedFld(conzx_ExplainType.zxExplainTypeId);
}
else if (conzx_ExplainType.ExplainTypeName  ==  AttributeName[intIndex])
{
mstrExplainTypeName = value.ToString();
 AddUpdatedFld(conzx_ExplainType.ExplainTypeName);
}
else if (conzx_ExplainType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_ExplainType.UpdDate);
}
else if (conzx_ExplainType.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conzx_ExplainType.UpdUserId);
}
else if (conzx_ExplainType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_ExplainType.Memo);
}
}
}

/// <summary>
/// 说明类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxExplainTypeId
{
get
{
return mstrzxExplainTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxExplainTypeId = value;
}
else
{
 mstrzxExplainTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_ExplainType.zxExplainTypeId);
}
}
/// <summary>
/// 说明类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExplainTypeName
{
get
{
return mstrExplainTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExplainTypeName = value;
}
else
{
 mstrExplainTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_ExplainType.ExplainTypeName);
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
 AddUpdatedFld(conzx_ExplainType.UpdDate);
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
 AddUpdatedFld(conzx_ExplainType.UpdUserId);
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
 AddUpdatedFld(conzx_ExplainType.Memo);
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
  return mstrzxExplainTypeId;
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
  return mstrExplainTypeName;
 }
 }
}
 /// <summary>
 /// 中学说明类型(zx_ExplainType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_ExplainType
{
public const string _CurrTabName = "zx_ExplainType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxExplainTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxExplainTypeId", "ExplainTypeName", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxExplainTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxExplainTypeId = "zxExplainTypeId";    //说明类型Id

 /// <summary>
 /// 常量:"ExplainTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExplainTypeName = "ExplainTypeName";    //说明类型名

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