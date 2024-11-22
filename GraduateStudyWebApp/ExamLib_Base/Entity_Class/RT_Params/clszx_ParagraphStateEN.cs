
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ParagraphStateEN
 表名:zx_ParagraphState(01120820)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:03:56
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
 /// 表zx_ParagraphState的关键字(zxParagraphStateId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxParagraphStateId_zx_ParagraphState
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxParagraphStateId">表关键字</param>
public K_zxParagraphStateId_zx_ParagraphState(string strzxParagraphStateId)
{
if (IsValid(strzxParagraphStateId)) Value = strzxParagraphStateId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxParagraphStateId)
{
if (string.IsNullOrEmpty(strzxParagraphStateId) == true) return false;
if (strzxParagraphStateId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxParagraphStateId_zx_ParagraphState]类型的对象</returns>
public static implicit operator K_zxParagraphStateId_zx_ParagraphState(string value)
{
return new K_zxParagraphStateId_zx_ParagraphState(value);
}
}
 /// <summary>
 /// 中学段落状态(zx_ParagraphState)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_ParagraphStateEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_ParagraphState"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxParagraphStateId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"zxParagraphStateId", "ParagraphStateName", "Memo"};

protected string mstrzxParagraphStateId;    //段落状态Id
protected string mstrParagraphStateName;    //段落状态
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_ParagraphStateEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxParagraphStateId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxParagraphStateId">关键字:段落状态Id</param>
public clszx_ParagraphStateEN(string strzxParagraphStateId)
 {
strzxParagraphStateId = strzxParagraphStateId.Replace("'", "''");
if (strzxParagraphStateId.Length > 2)
{
throw new Exception("在表:zx_ParagraphState中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxParagraphStateId)  ==  true)
{
throw new Exception("在表:zx_ParagraphState中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxParagraphStateId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxParagraphStateId = strzxParagraphStateId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxParagraphStateId");
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
if (strAttributeName  ==  conzx_ParagraphState.zxParagraphStateId)
{
return mstrzxParagraphStateId;
}
else if (strAttributeName  ==  conzx_ParagraphState.ParagraphStateName)
{
return mstrParagraphStateName;
}
else if (strAttributeName  ==  conzx_ParagraphState.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_ParagraphState.zxParagraphStateId)
{
mstrzxParagraphStateId = value.ToString();
 AddUpdatedFld(conzx_ParagraphState.zxParagraphStateId);
}
else if (strAttributeName  ==  conzx_ParagraphState.ParagraphStateName)
{
mstrParagraphStateName = value.ToString();
 AddUpdatedFld(conzx_ParagraphState.ParagraphStateName);
}
else if (strAttributeName  ==  conzx_ParagraphState.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_ParagraphState.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_ParagraphState.zxParagraphStateId  ==  AttributeName[intIndex])
{
return mstrzxParagraphStateId;
}
else if (conzx_ParagraphState.ParagraphStateName  ==  AttributeName[intIndex])
{
return mstrParagraphStateName;
}
else if (conzx_ParagraphState.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_ParagraphState.zxParagraphStateId  ==  AttributeName[intIndex])
{
mstrzxParagraphStateId = value.ToString();
 AddUpdatedFld(conzx_ParagraphState.zxParagraphStateId);
}
else if (conzx_ParagraphState.ParagraphStateName  ==  AttributeName[intIndex])
{
mstrParagraphStateName = value.ToString();
 AddUpdatedFld(conzx_ParagraphState.ParagraphStateName);
}
else if (conzx_ParagraphState.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_ParagraphState.Memo);
}
}
}

/// <summary>
/// 段落状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxParagraphStateId
{
get
{
return mstrzxParagraphStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxParagraphStateId = value;
}
else
{
 mstrzxParagraphStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_ParagraphState.zxParagraphStateId);
}
}
/// <summary>
/// 段落状态(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParagraphStateName
{
get
{
return mstrParagraphStateName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParagraphStateName = value;
}
else
{
 mstrParagraphStateName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_ParagraphState.ParagraphStateName);
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
 AddUpdatedFld(conzx_ParagraphState.Memo);
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
  return mstrzxParagraphStateId;
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
  return mstrParagraphStateName;
 }
 }
}
 /// <summary>
 /// 中学段落状态(zx_ParagraphState)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_ParagraphState
{
public const string _CurrTabName = "zx_ParagraphState"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxParagraphStateId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxParagraphStateId", "ParagraphStateName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxParagraphStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxParagraphStateId = "zxParagraphStateId";    //段落状态Id

 /// <summary>
 /// 常量:"ParagraphStateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParagraphStateName = "ParagraphStateName";    //段落状态

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}