
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewpointTypeEN
 表名:ViewpointType(01120544)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:10:39
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
 /// 表ViewpointType的关键字(ViewpointTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ViewpointTypeId_ViewpointType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strViewpointTypeId">表关键字</param>
public K_ViewpointTypeId_ViewpointType(string strViewpointTypeId)
{
if (IsValid(strViewpointTypeId)) Value = strViewpointTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strViewpointTypeId)
{
if (string.IsNullOrEmpty(strViewpointTypeId) == true) return false;
if (strViewpointTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ViewpointTypeId_ViewpointType]类型的对象</returns>
public static implicit operator K_ViewpointTypeId_ViewpointType(string value)
{
return new K_ViewpointTypeId_ViewpointType(value);
}
}
 /// <summary>
 /// 观点类型(ViewpointType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsViewpointTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ViewpointType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ViewpointTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"ViewpointTypeId", "ViewpointTypeName", "Memo"};

protected string mstrViewpointTypeId;    //观点类型Id
protected string mstrViewpointTypeName;    //观点类型名
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsViewpointTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewpointTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strViewpointTypeId">关键字:观点类型Id</param>
public clsViewpointTypeEN(string strViewpointTypeId)
 {
strViewpointTypeId = strViewpointTypeId.Replace("'", "''");
if (strViewpointTypeId.Length > 4)
{
throw new Exception("在表:ViewpointType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strViewpointTypeId)  ==  true)
{
throw new Exception("在表:ViewpointType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strViewpointTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrViewpointTypeId = strViewpointTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewpointTypeId");
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
if (strAttributeName  ==  conViewpointType.ViewpointTypeId)
{
return mstrViewpointTypeId;
}
else if (strAttributeName  ==  conViewpointType.ViewpointTypeName)
{
return mstrViewpointTypeName;
}
else if (strAttributeName  ==  conViewpointType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conViewpointType.ViewpointTypeId)
{
mstrViewpointTypeId = value.ToString();
 AddUpdatedFld(conViewpointType.ViewpointTypeId);
}
else if (strAttributeName  ==  conViewpointType.ViewpointTypeName)
{
mstrViewpointTypeName = value.ToString();
 AddUpdatedFld(conViewpointType.ViewpointTypeName);
}
else if (strAttributeName  ==  conViewpointType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conViewpointType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conViewpointType.ViewpointTypeId  ==  AttributeName[intIndex])
{
return mstrViewpointTypeId;
}
else if (conViewpointType.ViewpointTypeName  ==  AttributeName[intIndex])
{
return mstrViewpointTypeName;
}
else if (conViewpointType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conViewpointType.ViewpointTypeId  ==  AttributeName[intIndex])
{
mstrViewpointTypeId = value.ToString();
 AddUpdatedFld(conViewpointType.ViewpointTypeId);
}
else if (conViewpointType.ViewpointTypeName  ==  AttributeName[intIndex])
{
mstrViewpointTypeName = value.ToString();
 AddUpdatedFld(conViewpointType.ViewpointTypeName);
}
else if (conViewpointType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conViewpointType.Memo);
}
}
}

/// <summary>
/// 观点类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewpointTypeId
{
get
{
return mstrViewpointTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewpointTypeId = value;
}
else
{
 mstrViewpointTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewpointType.ViewpointTypeId);
}
}
/// <summary>
/// 观点类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewpointTypeName
{
get
{
return mstrViewpointTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewpointTypeName = value;
}
else
{
 mstrViewpointTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conViewpointType.ViewpointTypeName);
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
 AddUpdatedFld(conViewpointType.Memo);
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
  return mstrViewpointTypeId;
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
  return mstrViewpointTypeName;
 }
 }
}
 /// <summary>
 /// 观点类型(ViewpointType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conViewpointType
{
public const string _CurrTabName = "ViewpointType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ViewpointTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ViewpointTypeId", "ViewpointTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ViewpointTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointTypeId = "ViewpointTypeId";    //观点类型Id

 /// <summary>
 /// 常量:"ViewpointTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewpointTypeName = "ViewpointTypeName";    //观点类型名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}