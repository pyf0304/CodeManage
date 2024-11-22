
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzAdminClsTypeEN
 表名:XzAdminClsType(01120195)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:59:13
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:人员管理(PeopleManage)
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
 /// 表XzAdminClsType的关键字(IdAdminClsType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdAdminClsType_XzAdminClsType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdAdminClsType">表关键字</param>
public K_IdAdminClsType_XzAdminClsType(string strIdAdminClsType)
{
if (IsValid(strIdAdminClsType)) Value = strIdAdminClsType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdAdminClsType)
{
if (string.IsNullOrEmpty(strIdAdminClsType) == true) return false;
if (strIdAdminClsType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdAdminClsType_XzAdminClsType]类型的对象</returns>
public static implicit operator K_IdAdminClsType_XzAdminClsType(string value)
{
return new K_IdAdminClsType_XzAdminClsType(value);
}
}
 /// <summary>
 /// 行政班类型(XzAdminClsType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsXzAdminClsTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "XzAdminClsType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdAdminClsType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"IdAdminClsType", "AdminClsTypeId", "AdminClsTypeName", "Memo"};

protected string mstrIdAdminClsType;    //行政班级类型流水号
protected string mstrAdminClsTypeId;    //行政班级类型ID
protected string mstrAdminClsTypeName;    //行政班级类型名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsXzAdminClsTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdAdminClsType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdAdminClsType">关键字:行政班级类型流水号</param>
public clsXzAdminClsTypeEN(string strIdAdminClsType)
 {
strIdAdminClsType = strIdAdminClsType.Replace("'", "''");
if (strIdAdminClsType.Length > 4)
{
throw new Exception("在表:XzAdminClsType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdAdminClsType)  ==  true)
{
throw new Exception("在表:XzAdminClsType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdAdminClsType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdAdminClsType = strIdAdminClsType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdAdminClsType");
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
if (strAttributeName  ==  conXzAdminClsType.IdAdminClsType)
{
return mstrIdAdminClsType;
}
else if (strAttributeName  ==  conXzAdminClsType.AdminClsTypeId)
{
return mstrAdminClsTypeId;
}
else if (strAttributeName  ==  conXzAdminClsType.AdminClsTypeName)
{
return mstrAdminClsTypeName;
}
else if (strAttributeName  ==  conXzAdminClsType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conXzAdminClsType.IdAdminClsType)
{
mstrIdAdminClsType = value.ToString();
 AddUpdatedFld(conXzAdminClsType.IdAdminClsType);
}
else if (strAttributeName  ==  conXzAdminClsType.AdminClsTypeId)
{
mstrAdminClsTypeId = value.ToString();
 AddUpdatedFld(conXzAdminClsType.AdminClsTypeId);
}
else if (strAttributeName  ==  conXzAdminClsType.AdminClsTypeName)
{
mstrAdminClsTypeName = value.ToString();
 AddUpdatedFld(conXzAdminClsType.AdminClsTypeName);
}
else if (strAttributeName  ==  conXzAdminClsType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conXzAdminClsType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conXzAdminClsType.IdAdminClsType  ==  AttributeName[intIndex])
{
return mstrIdAdminClsType;
}
else if (conXzAdminClsType.AdminClsTypeId  ==  AttributeName[intIndex])
{
return mstrAdminClsTypeId;
}
else if (conXzAdminClsType.AdminClsTypeName  ==  AttributeName[intIndex])
{
return mstrAdminClsTypeName;
}
else if (conXzAdminClsType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conXzAdminClsType.IdAdminClsType  ==  AttributeName[intIndex])
{
mstrIdAdminClsType = value.ToString();
 AddUpdatedFld(conXzAdminClsType.IdAdminClsType);
}
else if (conXzAdminClsType.AdminClsTypeId  ==  AttributeName[intIndex])
{
mstrAdminClsTypeId = value.ToString();
 AddUpdatedFld(conXzAdminClsType.AdminClsTypeId);
}
else if (conXzAdminClsType.AdminClsTypeName  ==  AttributeName[intIndex])
{
mstrAdminClsTypeName = value.ToString();
 AddUpdatedFld(conXzAdminClsType.AdminClsTypeName);
}
else if (conXzAdminClsType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conXzAdminClsType.Memo);
}
}
}

/// <summary>
/// 行政班级类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdAdminClsType
{
get
{
return mstrIdAdminClsType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdAdminClsType = value;
}
else
{
 mstrIdAdminClsType = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzAdminClsType.IdAdminClsType);
}
}
/// <summary>
/// 行政班级类型ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AdminClsTypeId
{
get
{
return mstrAdminClsTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAdminClsTypeId = value;
}
else
{
 mstrAdminClsTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzAdminClsType.AdminClsTypeId);
}
}
/// <summary>
/// 行政班级类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AdminClsTypeName
{
get
{
return mstrAdminClsTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAdminClsTypeName = value;
}
else
{
 mstrAdminClsTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzAdminClsType.AdminClsTypeName);
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
 AddUpdatedFld(conXzAdminClsType.Memo);
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
  return mstrIdAdminClsType;
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
  return mstrAdminClsTypeName;
 }
 }
}
 /// <summary>
 /// 行政班类型(XzAdminClsType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conXzAdminClsType
{
public const string _CurrTabName = "XzAdminClsType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdAdminClsType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdAdminClsType", "AdminClsTypeId", "AdminClsTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdAdminClsType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdAdminClsType = "IdAdminClsType";    //行政班级类型流水号

 /// <summary>
 /// 常量:"AdminClsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AdminClsTypeId = "AdminClsTypeId";    //行政班级类型ID

 /// <summary>
 /// 常量:"AdminClsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AdminClsTypeName = "AdminClsTypeName";    //行政班级类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}