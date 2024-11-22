
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TextTypeEN
 表名:zx_TextType(01120711)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:59:46
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
 /// 表zx_TextType的关键字(TextTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TextTypeId_zx_TextType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTextTypeId">表关键字</param>
public K_TextTypeId_zx_TextType(string strTextTypeId)
{
if (IsValid(strTextTypeId)) Value = strTextTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strTextTypeId)
{
if (string.IsNullOrEmpty(strTextTypeId) == true) return false;
if (strTextTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TextTypeId_zx_TextType]类型的对象</returns>
public static implicit operator K_TextTypeId_zx_TextType(string value)
{
return new K_TextTypeId_zx_TextType(value);
}
}
 /// <summary>
 /// 中学课件类型(zx_TextType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_TextTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_TextType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TextTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"TextTypeId", "TextTypeName", "Memo"};

protected string mstrTextTypeId;    //TextTypeId
protected string mstrTextTypeName;    //TextTypeName
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_TextTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TextTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strTextTypeId">关键字:TextTypeId</param>
public clszx_TextTypeEN(string strTextTypeId)
 {
strTextTypeId = strTextTypeId.Replace("'", "''");
if (strTextTypeId.Length > 2)
{
throw new Exception("在表:zx_TextType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTextTypeId)  ==  true)
{
throw new Exception("在表:zx_TextType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTextTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTextTypeId = strTextTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TextTypeId");
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
if (strAttributeName  ==  conzx_TextType.TextTypeId)
{
return mstrTextTypeId;
}
else if (strAttributeName  ==  conzx_TextType.TextTypeName)
{
return mstrTextTypeName;
}
else if (strAttributeName  ==  conzx_TextType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_TextType.TextTypeId)
{
mstrTextTypeId = value.ToString();
 AddUpdatedFld(conzx_TextType.TextTypeId);
}
else if (strAttributeName  ==  conzx_TextType.TextTypeName)
{
mstrTextTypeName = value.ToString();
 AddUpdatedFld(conzx_TextType.TextTypeName);
}
else if (strAttributeName  ==  conzx_TextType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_TextType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_TextType.TextTypeId  ==  AttributeName[intIndex])
{
return mstrTextTypeId;
}
else if (conzx_TextType.TextTypeName  ==  AttributeName[intIndex])
{
return mstrTextTypeName;
}
else if (conzx_TextType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_TextType.TextTypeId  ==  AttributeName[intIndex])
{
mstrTextTypeId = value.ToString();
 AddUpdatedFld(conzx_TextType.TextTypeId);
}
else if (conzx_TextType.TextTypeName  ==  AttributeName[intIndex])
{
mstrTextTypeName = value.ToString();
 AddUpdatedFld(conzx_TextType.TextTypeName);
}
else if (conzx_TextType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_TextType.Memo);
}
}
}

/// <summary>
/// TextTypeId(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextTypeId
{
get
{
return mstrTextTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextTypeId = value;
}
else
{
 mstrTextTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_TextType.TextTypeId);
}
}
/// <summary>
/// TextTypeName(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TextTypeName
{
get
{
return mstrTextTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTextTypeName = value;
}
else
{
 mstrTextTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_TextType.TextTypeName);
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
 AddUpdatedFld(conzx_TextType.Memo);
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
  return mstrTextTypeId;
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
  return mstrTextTypeName;
 }
 }
}
 /// <summary>
 /// 中学课件类型(zx_TextType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_TextType
{
public const string _CurrTabName = "zx_TextType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TextTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TextTypeId", "TextTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"TextTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextTypeId = "TextTypeId";    //TextTypeId

 /// <summary>
 /// 常量:"TextTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TextTypeName = "TextTypeName";    //TextTypeName

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}