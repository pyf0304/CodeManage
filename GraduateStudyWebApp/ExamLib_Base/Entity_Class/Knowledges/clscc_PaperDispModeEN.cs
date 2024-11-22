
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_PaperDispModeEN
 表名:cc_PaperDispMode(01120073)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:23
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// 表cc_PaperDispMode的关键字(PaperDispModeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperDispModeId_cc_PaperDispMode
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPaperDispModeId">表关键字</param>
public K_PaperDispModeId_cc_PaperDispMode(string strPaperDispModeId)
{
if (IsValid(strPaperDispModeId)) Value = strPaperDispModeId;
else
{
Value = null;
}
}
private static bool IsValid(string strPaperDispModeId)
{
if (string.IsNullOrEmpty(strPaperDispModeId) == true) return false;
if (strPaperDispModeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PaperDispModeId_cc_PaperDispMode]类型的对象</returns>
public static implicit operator K_PaperDispModeId_cc_PaperDispMode(string value)
{
return new K_PaperDispModeId_cc_PaperDispMode(value);
}
}
 /// <summary>
 /// 试卷显示模式(cc_PaperDispMode)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_PaperDispModeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_PaperDispMode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperDispModeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"PaperDispModeId", "PaperDispModeName", "Memo"};

protected string mstrPaperDispModeId;    //试卷显示模式Id
protected string mstrPaperDispModeName;    //试卷显示模式名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clscc_PaperDispModeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperDispModeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strPaperDispModeId">关键字:试卷显示模式Id</param>
public clscc_PaperDispModeEN(string strPaperDispModeId)
 {
strPaperDispModeId = strPaperDispModeId.Replace("'", "''");
if (strPaperDispModeId.Length > 4)
{
throw new Exception("在表:cc_PaperDispMode中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPaperDispModeId)  ==  true)
{
throw new Exception("在表:cc_PaperDispMode中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPaperDispModeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPaperDispModeId = strPaperDispModeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperDispModeId");
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
if (strAttributeName  ==  concc_PaperDispMode.PaperDispModeId)
{
return mstrPaperDispModeId;
}
else if (strAttributeName  ==  concc_PaperDispMode.PaperDispModeName)
{
return mstrPaperDispModeName;
}
else if (strAttributeName  ==  concc_PaperDispMode.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concc_PaperDispMode.PaperDispModeId)
{
mstrPaperDispModeId = value.ToString();
 AddUpdatedFld(concc_PaperDispMode.PaperDispModeId);
}
else if (strAttributeName  ==  concc_PaperDispMode.PaperDispModeName)
{
mstrPaperDispModeName = value.ToString();
 AddUpdatedFld(concc_PaperDispMode.PaperDispModeName);
}
else if (strAttributeName  ==  concc_PaperDispMode.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_PaperDispMode.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_PaperDispMode.PaperDispModeId  ==  AttributeName[intIndex])
{
return mstrPaperDispModeId;
}
else if (concc_PaperDispMode.PaperDispModeName  ==  AttributeName[intIndex])
{
return mstrPaperDispModeName;
}
else if (concc_PaperDispMode.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concc_PaperDispMode.PaperDispModeId  ==  AttributeName[intIndex])
{
mstrPaperDispModeId = value.ToString();
 AddUpdatedFld(concc_PaperDispMode.PaperDispModeId);
}
else if (concc_PaperDispMode.PaperDispModeName  ==  AttributeName[intIndex])
{
mstrPaperDispModeName = value.ToString();
 AddUpdatedFld(concc_PaperDispMode.PaperDispModeName);
}
else if (concc_PaperDispMode.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_PaperDispMode.Memo);
}
}
}

/// <summary>
/// 试卷显示模式Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperDispModeId
{
get
{
return mstrPaperDispModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperDispModeId = value;
}
else
{
 mstrPaperDispModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_PaperDispMode.PaperDispModeId);
}
}
/// <summary>
/// 试卷显示模式名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperDispModeName
{
get
{
return mstrPaperDispModeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperDispModeName = value;
}
else
{
 mstrPaperDispModeName = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_PaperDispMode.PaperDispModeName);
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
 AddUpdatedFld(concc_PaperDispMode.Memo);
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
  return mstrPaperDispModeId;
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
  return mstrPaperDispModeName;
 }
 }
}
 /// <summary>
 /// 试卷显示模式(cc_PaperDispMode)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_PaperDispMode
{
public const string _CurrTabName = "cc_PaperDispMode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperDispModeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperDispModeId", "PaperDispModeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"PaperDispModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperDispModeId = "PaperDispModeId";    //试卷显示模式Id

 /// <summary>
 /// 常量:"PaperDispModeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperDispModeName = "PaperDispModeName";    //试卷显示模式名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}