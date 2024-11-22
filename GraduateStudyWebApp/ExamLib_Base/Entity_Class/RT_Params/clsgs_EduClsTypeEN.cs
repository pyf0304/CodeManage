
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_EduClsTypeEN
 表名:gs_EduClsType(01120723)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:14:23
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
 /// 表gs_EduClsType的关键字(EduClsTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_EduClsTypeId_gs_EduClsType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strEduClsTypeId">表关键字</param>
public K_EduClsTypeId_gs_EduClsType(string strEduClsTypeId)
{
if (IsValid(strEduClsTypeId)) Value = strEduClsTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strEduClsTypeId)
{
if (string.IsNullOrEmpty(strEduClsTypeId) == true) return false;
if (strEduClsTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_EduClsTypeId_gs_EduClsType]类型的对象</returns>
public static implicit operator K_EduClsTypeId_gs_EduClsType(string value)
{
return new K_EduClsTypeId_gs_EduClsType(value);
}
}
 /// <summary>
 /// 教学班类型(gs_EduClsType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_EduClsTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_EduClsType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "EduClsTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"EduClsTypeId", "EduClsTypeName", "Memo"};

protected string mstrEduClsTypeId;    //教学班类型Id
protected string mstrEduClsTypeName;    //教学班类型名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_EduClsTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("EduClsTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strEduClsTypeId">关键字:教学班类型Id</param>
public clsgs_EduClsTypeEN(string strEduClsTypeId)
 {
strEduClsTypeId = strEduClsTypeId.Replace("'", "''");
if (strEduClsTypeId.Length > 4)
{
throw new Exception("在表:gs_EduClsType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strEduClsTypeId)  ==  true)
{
throw new Exception("在表:gs_EduClsType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strEduClsTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrEduClsTypeId = strEduClsTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("EduClsTypeId");
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
if (strAttributeName  ==  congs_EduClsType.EduClsTypeId)
{
return mstrEduClsTypeId;
}
else if (strAttributeName  ==  congs_EduClsType.EduClsTypeName)
{
return mstrEduClsTypeName;
}
else if (strAttributeName  ==  congs_EduClsType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  congs_EduClsType.EduClsTypeId)
{
mstrEduClsTypeId = value.ToString();
 AddUpdatedFld(congs_EduClsType.EduClsTypeId);
}
else if (strAttributeName  ==  congs_EduClsType.EduClsTypeName)
{
mstrEduClsTypeName = value.ToString();
 AddUpdatedFld(congs_EduClsType.EduClsTypeName);
}
else if (strAttributeName  ==  congs_EduClsType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_EduClsType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_EduClsType.EduClsTypeId  ==  AttributeName[intIndex])
{
return mstrEduClsTypeId;
}
else if (congs_EduClsType.EduClsTypeName  ==  AttributeName[intIndex])
{
return mstrEduClsTypeName;
}
else if (congs_EduClsType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (congs_EduClsType.EduClsTypeId  ==  AttributeName[intIndex])
{
mstrEduClsTypeId = value.ToString();
 AddUpdatedFld(congs_EduClsType.EduClsTypeId);
}
else if (congs_EduClsType.EduClsTypeName  ==  AttributeName[intIndex])
{
mstrEduClsTypeName = value.ToString();
 AddUpdatedFld(congs_EduClsType.EduClsTypeName);
}
else if (congs_EduClsType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_EduClsType.Memo);
}
}
}

/// <summary>
/// 教学班类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduClsTypeId
{
get
{
return mstrEduClsTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduClsTypeId = value;
}
else
{
 mstrEduClsTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_EduClsType.EduClsTypeId);
}
}
/// <summary>
/// 教学班类型名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EduClsTypeName
{
get
{
return mstrEduClsTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEduClsTypeName = value;
}
else
{
 mstrEduClsTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_EduClsType.EduClsTypeName);
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
 AddUpdatedFld(congs_EduClsType.Memo);
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
  return mstrEduClsTypeId;
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
  return mstrEduClsTypeName;
 }
 }
}
 /// <summary>
 /// 教学班类型(gs_EduClsType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_EduClsType
{
public const string _CurrTabName = "gs_EduClsType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "EduClsTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"EduClsTypeId", "EduClsTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"EduClsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduClsTypeId = "EduClsTypeId";    //教学班类型Id

 /// <summary>
 /// 常量:"EduClsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EduClsTypeName = "EduClsTypeName";    //教学班类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}