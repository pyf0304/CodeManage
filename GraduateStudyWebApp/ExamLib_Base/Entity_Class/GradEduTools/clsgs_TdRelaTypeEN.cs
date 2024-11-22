
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_TdRelaTypeEN
 表名:gs_TdRelaType(01120703)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:16:19
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
 /// 表gs_TdRelaType的关键字(TdRelaTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TdRelaTypeId_gs_TdRelaType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTdRelaTypeId">表关键字</param>
public K_TdRelaTypeId_gs_TdRelaType(string strTdRelaTypeId)
{
if (IsValid(strTdRelaTypeId)) Value = strTdRelaTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strTdRelaTypeId)
{
if (string.IsNullOrEmpty(strTdRelaTypeId) == true) return false;
if (strTdRelaTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TdRelaTypeId_gs_TdRelaType]类型的对象</returns>
public static implicit operator K_TdRelaTypeId_gs_TdRelaType(string value)
{
return new K_TdRelaTypeId_gs_TdRelaType(value);
}
}
 /// <summary>
 /// 总数据关系类型表(gs_TdRelaType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_TdRelaTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_TdRelaType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TdRelaTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"TdRelaTypeId", "TdRelaTypeName", "Memo"};

protected string mstrTdRelaTypeId;    //总数据关系类型Id
protected string mstrTdRelaTypeName;    //总数据类型名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_TdRelaTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TdRelaTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strTdRelaTypeId">关键字:总数据关系类型Id</param>
public clsgs_TdRelaTypeEN(string strTdRelaTypeId)
 {
strTdRelaTypeId = strTdRelaTypeId.Replace("'", "''");
if (strTdRelaTypeId.Length > 2)
{
throw new Exception("在表:gs_TdRelaType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTdRelaTypeId)  ==  true)
{
throw new Exception("在表:gs_TdRelaType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTdRelaTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTdRelaTypeId = strTdRelaTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TdRelaTypeId");
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
if (strAttributeName  ==  congs_TdRelaType.TdRelaTypeId)
{
return mstrTdRelaTypeId;
}
else if (strAttributeName  ==  congs_TdRelaType.TdRelaTypeName)
{
return mstrTdRelaTypeName;
}
else if (strAttributeName  ==  congs_TdRelaType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  congs_TdRelaType.TdRelaTypeId)
{
mstrTdRelaTypeId = value.ToString();
 AddUpdatedFld(congs_TdRelaType.TdRelaTypeId);
}
else if (strAttributeName  ==  congs_TdRelaType.TdRelaTypeName)
{
mstrTdRelaTypeName = value.ToString();
 AddUpdatedFld(congs_TdRelaType.TdRelaTypeName);
}
else if (strAttributeName  ==  congs_TdRelaType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_TdRelaType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_TdRelaType.TdRelaTypeId  ==  AttributeName[intIndex])
{
return mstrTdRelaTypeId;
}
else if (congs_TdRelaType.TdRelaTypeName  ==  AttributeName[intIndex])
{
return mstrTdRelaTypeName;
}
else if (congs_TdRelaType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (congs_TdRelaType.TdRelaTypeId  ==  AttributeName[intIndex])
{
mstrTdRelaTypeId = value.ToString();
 AddUpdatedFld(congs_TdRelaType.TdRelaTypeId);
}
else if (congs_TdRelaType.TdRelaTypeName  ==  AttributeName[intIndex])
{
mstrTdRelaTypeName = value.ToString();
 AddUpdatedFld(congs_TdRelaType.TdRelaTypeName);
}
else if (congs_TdRelaType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_TdRelaType.Memo);
}
}
}

/// <summary>
/// 总数据关系类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TdRelaTypeId
{
get
{
return mstrTdRelaTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTdRelaTypeId = value;
}
else
{
 mstrTdRelaTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_TdRelaType.TdRelaTypeId);
}
}
/// <summary>
/// 总数据类型名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TdRelaTypeName
{
get
{
return mstrTdRelaTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTdRelaTypeName = value;
}
else
{
 mstrTdRelaTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_TdRelaType.TdRelaTypeName);
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
 AddUpdatedFld(congs_TdRelaType.Memo);
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
  return mstrTdRelaTypeId;
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
  return mstrTdRelaTypeName;
 }
 }
}
 /// <summary>
 /// 总数据关系类型表(gs_TdRelaType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_TdRelaType
{
public const string _CurrTabName = "gs_TdRelaType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TdRelaTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TdRelaTypeId", "TdRelaTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"TdRelaTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TdRelaTypeId = "TdRelaTypeId";    //总数据关系类型Id

 /// <summary>
 /// 常量:"TdRelaTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TdRelaTypeName = "TdRelaTypeName";    //总数据类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}