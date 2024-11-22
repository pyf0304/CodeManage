
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzMajorShoolTypeEN
 表名:XzMajorShoolType(01120632)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:07:59
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:基本信息维护(BaseInfo)
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
 /// 表XzMajorShoolType的关键字(IdXzMajorShoolType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdXzMajorShoolType_XzMajorShoolType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdXzMajorShoolType">表关键字</param>
public K_IdXzMajorShoolType_XzMajorShoolType(string strIdXzMajorShoolType)
{
if (IsValid(strIdXzMajorShoolType)) Value = strIdXzMajorShoolType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdXzMajorShoolType)
{
if (string.IsNullOrEmpty(strIdXzMajorShoolType) == true) return false;
if (strIdXzMajorShoolType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdXzMajorShoolType_XzMajorShoolType]类型的对象</returns>
public static implicit operator K_IdXzMajorShoolType_XzMajorShoolType(string value)
{
return new K_IdXzMajorShoolType_XzMajorShoolType(value);
}
}
 /// <summary>
 /// 专业学校类型(XzMajorShoolType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsXzMajorShoolTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "XzMajorShoolType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdXzMajorShoolType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"IdXzMajorShoolType", "TypeName", "UpdUserId", "UpdDate", "Memo"};

protected string mstrIdXzMajorShoolType;    //专业学校类型流水号
protected string mstrTypeName;    //类型名称
protected string mstrUpdUserId;    //修改用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsXzMajorShoolTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdXzMajorShoolType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdXzMajorShoolType">关键字:专业学校类型流水号</param>
public clsXzMajorShoolTypeEN(string strIdXzMajorShoolType)
 {
strIdXzMajorShoolType = strIdXzMajorShoolType.Replace("'", "''");
if (strIdXzMajorShoolType.Length > 4)
{
throw new Exception("在表:XzMajorShoolType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdXzMajorShoolType)  ==  true)
{
throw new Exception("在表:XzMajorShoolType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdXzMajorShoolType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdXzMajorShoolType = strIdXzMajorShoolType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdXzMajorShoolType");
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
if (strAttributeName  ==  conXzMajorShoolType.IdXzMajorShoolType)
{
return mstrIdXzMajorShoolType;
}
else if (strAttributeName  ==  conXzMajorShoolType.TypeName)
{
return mstrTypeName;
}
else if (strAttributeName  ==  conXzMajorShoolType.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conXzMajorShoolType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conXzMajorShoolType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conXzMajorShoolType.IdXzMajorShoolType)
{
mstrIdXzMajorShoolType = value.ToString();
 AddUpdatedFld(conXzMajorShoolType.IdXzMajorShoolType);
}
else if (strAttributeName  ==  conXzMajorShoolType.TypeName)
{
mstrTypeName = value.ToString();
 AddUpdatedFld(conXzMajorShoolType.TypeName);
}
else if (strAttributeName  ==  conXzMajorShoolType.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conXzMajorShoolType.UpdUserId);
}
else if (strAttributeName  ==  conXzMajorShoolType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conXzMajorShoolType.UpdDate);
}
else if (strAttributeName  ==  conXzMajorShoolType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conXzMajorShoolType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conXzMajorShoolType.IdXzMajorShoolType  ==  AttributeName[intIndex])
{
return mstrIdXzMajorShoolType;
}
else if (conXzMajorShoolType.TypeName  ==  AttributeName[intIndex])
{
return mstrTypeName;
}
else if (conXzMajorShoolType.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conXzMajorShoolType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conXzMajorShoolType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conXzMajorShoolType.IdXzMajorShoolType  ==  AttributeName[intIndex])
{
mstrIdXzMajorShoolType = value.ToString();
 AddUpdatedFld(conXzMajorShoolType.IdXzMajorShoolType);
}
else if (conXzMajorShoolType.TypeName  ==  AttributeName[intIndex])
{
mstrTypeName = value.ToString();
 AddUpdatedFld(conXzMajorShoolType.TypeName);
}
else if (conXzMajorShoolType.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conXzMajorShoolType.UpdUserId);
}
else if (conXzMajorShoolType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conXzMajorShoolType.UpdDate);
}
else if (conXzMajorShoolType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conXzMajorShoolType.Memo);
}
}
}

/// <summary>
/// 专业学校类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzMajorShoolType
{
get
{
return mstrIdXzMajorShoolType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzMajorShoolType = value;
}
else
{
 mstrIdXzMajorShoolType = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzMajorShoolType.IdXzMajorShoolType);
}
}
/// <summary>
/// 类型名称(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TypeName
{
get
{
return mstrTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTypeName = value;
}
else
{
 mstrTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzMajorShoolType.TypeName);
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
 AddUpdatedFld(conXzMajorShoolType.UpdUserId);
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
 AddUpdatedFld(conXzMajorShoolType.UpdDate);
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
 AddUpdatedFld(conXzMajorShoolType.Memo);
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
  return mstrIdXzMajorShoolType;
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
  return mstrTypeName;
 }
 }
}
 /// <summary>
 /// 专业学校类型(XzMajorShoolType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conXzMajorShoolType
{
public const string _CurrTabName = "XzMajorShoolType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdXzMajorShoolType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdXzMajorShoolType", "TypeName", "UpdUserId", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdXzMajorShoolType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajorShoolType = "IdXzMajorShoolType";    //专业学校类型流水号

 /// <summary>
 /// 常量:"TypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TypeName = "TypeName";    //类型名称

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

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