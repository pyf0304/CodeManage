
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_PaperTypeEN
 表名:gs_PaperType(01120675)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:08:12
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
 /// 表gs_PaperType的关键字(PaperTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperTypeId_gs_PaperType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPaperTypeId">表关键字</param>
public K_PaperTypeId_gs_PaperType(string strPaperTypeId)
{
if (IsValid(strPaperTypeId)) Value = strPaperTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strPaperTypeId)
{
if (string.IsNullOrEmpty(strPaperTypeId) == true) return false;
if (strPaperTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PaperTypeId_gs_PaperType]类型的对象</returns>
public static implicit operator K_PaperTypeId_gs_PaperType(string value)
{
return new K_PaperTypeId_gs_PaperType(value);
}
}
 /// <summary>
 /// 论文类型表(gs_PaperType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_PaperTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_PaperType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"PaperTypeId", "PaperTypeName", "Memo", "PaperTypeENName"};

protected string mstrPaperTypeId;    //论文类型Id
protected string mstrPaperTypeName;    //论文类型名
protected string mstrMemo;    //备注
protected string mstrPaperTypeENName;    //论文类型英文名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_PaperTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strPaperTypeId">关键字:论文类型Id</param>
public clsgs_PaperTypeEN(string strPaperTypeId)
 {
strPaperTypeId = strPaperTypeId.Replace("'", "''");
if (strPaperTypeId.Length > 2)
{
throw new Exception("在表:gs_PaperType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPaperTypeId)  ==  true)
{
throw new Exception("在表:gs_PaperType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPaperTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPaperTypeId = strPaperTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperTypeId");
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
if (strAttributeName  ==  congs_PaperType.PaperTypeId)
{
return mstrPaperTypeId;
}
else if (strAttributeName  ==  congs_PaperType.PaperTypeName)
{
return mstrPaperTypeName;
}
else if (strAttributeName  ==  congs_PaperType.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  congs_PaperType.PaperTypeENName)
{
return mstrPaperTypeENName;
}
return null;
}
set
{
if (strAttributeName  ==  congs_PaperType.PaperTypeId)
{
mstrPaperTypeId = value.ToString();
 AddUpdatedFld(congs_PaperType.PaperTypeId);
}
else if (strAttributeName  ==  congs_PaperType.PaperTypeName)
{
mstrPaperTypeName = value.ToString();
 AddUpdatedFld(congs_PaperType.PaperTypeName);
}
else if (strAttributeName  ==  congs_PaperType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_PaperType.Memo);
}
else if (strAttributeName  ==  congs_PaperType.PaperTypeENName)
{
mstrPaperTypeENName = value.ToString();
 AddUpdatedFld(congs_PaperType.PaperTypeENName);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_PaperType.PaperTypeId  ==  AttributeName[intIndex])
{
return mstrPaperTypeId;
}
else if (congs_PaperType.PaperTypeName  ==  AttributeName[intIndex])
{
return mstrPaperTypeName;
}
else if (congs_PaperType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (congs_PaperType.PaperTypeENName  ==  AttributeName[intIndex])
{
return mstrPaperTypeENName;
}
return null;
}
set
{
if (congs_PaperType.PaperTypeId  ==  AttributeName[intIndex])
{
mstrPaperTypeId = value.ToString();
 AddUpdatedFld(congs_PaperType.PaperTypeId);
}
else if (congs_PaperType.PaperTypeName  ==  AttributeName[intIndex])
{
mstrPaperTypeName = value.ToString();
 AddUpdatedFld(congs_PaperType.PaperTypeName);
}
else if (congs_PaperType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_PaperType.Memo);
}
else if (congs_PaperType.PaperTypeENName  ==  AttributeName[intIndex])
{
mstrPaperTypeENName = value.ToString();
 AddUpdatedFld(congs_PaperType.PaperTypeENName);
}
}
}

/// <summary>
/// 论文类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperTypeId
{
get
{
return mstrPaperTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperTypeId = value;
}
else
{
 mstrPaperTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_PaperType.PaperTypeId);
}
}
/// <summary>
/// 论文类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperTypeName
{
get
{
return mstrPaperTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperTypeName = value;
}
else
{
 mstrPaperTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_PaperType.PaperTypeName);
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
 AddUpdatedFld(congs_PaperType.Memo);
}
}
/// <summary>
/// 论文类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperTypeENName
{
get
{
return mstrPaperTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperTypeENName = value;
}
else
{
 mstrPaperTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_PaperType.PaperTypeENName);
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
  return mstrPaperTypeId;
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
  return mstrPaperTypeName;
 }
 }
}
 /// <summary>
 /// 论文类型表(gs_PaperType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_PaperType
{
public const string _CurrTabName = "gs_PaperType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperTypeId", "PaperTypeName", "Memo", "PaperTypeENName"};
//以下是属性变量


 /// <summary>
 /// 常量:"PaperTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTypeId = "PaperTypeId";    //论文类型Id

 /// <summary>
 /// 常量:"PaperTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTypeName = "PaperTypeName";    //论文类型名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"PaperTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperTypeENName = "PaperTypeENName";    //论文类型英文名
}

}