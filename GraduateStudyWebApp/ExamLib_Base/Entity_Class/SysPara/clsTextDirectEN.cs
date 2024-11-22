
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTextDirectEN
 表名:TextDirect(01120031)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:11:40
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
 /// 表TextDirect的关键字(TextDirectId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TextDirectId_TextDirect
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTextDirectId">表关键字</param>
public K_TextDirectId_TextDirect(string strTextDirectId)
{
if (IsValid(strTextDirectId)) Value = strTextDirectId;
else
{
Value = null;
}
}
private static bool IsValid(string strTextDirectId)
{
if (string.IsNullOrEmpty(strTextDirectId) == true) return false;
if (strTextDirectId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TextDirectId_TextDirect]类型的对象</returns>
public static implicit operator K_TextDirectId_TextDirect(string value)
{
return new K_TextDirectId_TextDirect(value);
}
}
 /// <summary>
 /// 文本方向(TextDirect)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTextDirectEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "TextDirect"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TextDirectId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"TextDirectId", "TextDirectName", "Memo"};

protected string mstrTextDirectId;    //文本方向ID
protected string mstrTextDirectName;    //文本方向名
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsTextDirectEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TextDirectId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strTextDirectId">关键字:文本方向ID</param>
public clsTextDirectEN(string strTextDirectId)
 {
strTextDirectId = strTextDirectId.Replace("'", "''");
if (strTextDirectId.Length > 4)
{
throw new Exception("在表:TextDirect中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTextDirectId)  ==  true)
{
throw new Exception("在表:TextDirect中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTextDirectId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTextDirectId = strTextDirectId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TextDirectId");
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
if (strAttributeName  ==  conTextDirect.TextDirectId)
{
return mstrTextDirectId;
}
else if (strAttributeName  ==  conTextDirect.TextDirectName)
{
return mstrTextDirectName;
}
else if (strAttributeName  ==  conTextDirect.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conTextDirect.TextDirectId)
{
mstrTextDirectId = value.ToString();
 AddUpdatedFld(conTextDirect.TextDirectId);
}
else if (strAttributeName  ==  conTextDirect.TextDirectName)
{
mstrTextDirectName = value.ToString();
 AddUpdatedFld(conTextDirect.TextDirectName);
}
else if (strAttributeName  ==  conTextDirect.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTextDirect.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTextDirect.TextDirectId  ==  AttributeName[intIndex])
{
return mstrTextDirectId;
}
else if (conTextDirect.TextDirectName  ==  AttributeName[intIndex])
{
return mstrTextDirectName;
}
else if (conTextDirect.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conTextDirect.TextDirectId  ==  AttributeName[intIndex])
{
mstrTextDirectId = value.ToString();
 AddUpdatedFld(conTextDirect.TextDirectId);
}
else if (conTextDirect.TextDirectName  ==  AttributeName[intIndex])
{
mstrTextDirectName = value.ToString();
 AddUpdatedFld(conTextDirect.TextDirectName);
}
else if (conTextDirect.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTextDirect.Memo);
}
}
}

/// <summary>
/// 文本方向ID(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextDirectId
{
get
{
return mstrTextDirectId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextDirectId = value;
}
else
{
 mstrTextDirectId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTextDirect.TextDirectId);
}
}
/// <summary>
/// 文本方向名(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextDirectName
{
get
{
return mstrTextDirectName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextDirectName = value;
}
else
{
 mstrTextDirectName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTextDirect.TextDirectName);
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
 AddUpdatedFld(conTextDirect.Memo);
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
  return mstrTextDirectId;
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
  return mstrTextDirectName;
 }
 }
}
 /// <summary>
 /// 文本方向(TextDirect)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTextDirect
{
public const string _CurrTabName = "TextDirect"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TextDirectId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TextDirectId", "TextDirectName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"TextDirectId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextDirectId = "TextDirectId";    //文本方向ID

 /// <summary>
 /// 常量:"TextDirectName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextDirectName = "TextDirectName";    //文本方向名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}