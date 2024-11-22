
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ParagraphTypeEN
 表名:zx_ParagraphType(01120821)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:58:19
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
 /// 表zx_ParagraphType的关键字(zxParagraphTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxParagraphTypeId_zx_ParagraphType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxParagraphTypeId">表关键字</param>
public K_zxParagraphTypeId_zx_ParagraphType(string strzxParagraphTypeId)
{
if (IsValid(strzxParagraphTypeId)) Value = strzxParagraphTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxParagraphTypeId)
{
if (string.IsNullOrEmpty(strzxParagraphTypeId) == true) return false;
if (strzxParagraphTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxParagraphTypeId_zx_ParagraphType]类型的对象</returns>
public static implicit operator K_zxParagraphTypeId_zx_ParagraphType(string value)
{
return new K_zxParagraphTypeId_zx_ParagraphType(value);
}
}
 /// <summary>
 /// 中学段落类型(zx_ParagraphType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_ParagraphTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_ParagraphType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxParagraphTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"zxParagraphTypeId", "ParagraphTypeName", "Memo"};

protected string mstrzxParagraphTypeId;    //段落类型Id
protected string mstrParagraphTypeName;    //段落类型
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_ParagraphTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxParagraphTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxParagraphTypeId">关键字:段落类型Id</param>
public clszx_ParagraphTypeEN(string strzxParagraphTypeId)
 {
strzxParagraphTypeId = strzxParagraphTypeId.Replace("'", "''");
if (strzxParagraphTypeId.Length > 2)
{
throw new Exception("在表:zx_ParagraphType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxParagraphTypeId)  ==  true)
{
throw new Exception("在表:zx_ParagraphType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxParagraphTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxParagraphTypeId = strzxParagraphTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxParagraphTypeId");
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
if (strAttributeName  ==  conzx_ParagraphType.zxParagraphTypeId)
{
return mstrzxParagraphTypeId;
}
else if (strAttributeName  ==  conzx_ParagraphType.ParagraphTypeName)
{
return mstrParagraphTypeName;
}
else if (strAttributeName  ==  conzx_ParagraphType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_ParagraphType.zxParagraphTypeId)
{
mstrzxParagraphTypeId = value.ToString();
 AddUpdatedFld(conzx_ParagraphType.zxParagraphTypeId);
}
else if (strAttributeName  ==  conzx_ParagraphType.ParagraphTypeName)
{
mstrParagraphTypeName = value.ToString();
 AddUpdatedFld(conzx_ParagraphType.ParagraphTypeName);
}
else if (strAttributeName  ==  conzx_ParagraphType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_ParagraphType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_ParagraphType.zxParagraphTypeId  ==  AttributeName[intIndex])
{
return mstrzxParagraphTypeId;
}
else if (conzx_ParagraphType.ParagraphTypeName  ==  AttributeName[intIndex])
{
return mstrParagraphTypeName;
}
else if (conzx_ParagraphType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_ParagraphType.zxParagraphTypeId  ==  AttributeName[intIndex])
{
mstrzxParagraphTypeId = value.ToString();
 AddUpdatedFld(conzx_ParagraphType.zxParagraphTypeId);
}
else if (conzx_ParagraphType.ParagraphTypeName  ==  AttributeName[intIndex])
{
mstrParagraphTypeName = value.ToString();
 AddUpdatedFld(conzx_ParagraphType.ParagraphTypeName);
}
else if (conzx_ParagraphType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_ParagraphType.Memo);
}
}
}

/// <summary>
/// 段落类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxParagraphTypeId
{
get
{
return mstrzxParagraphTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxParagraphTypeId = value;
}
else
{
 mstrzxParagraphTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_ParagraphType.zxParagraphTypeId);
}
}
/// <summary>
/// 段落类型(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ParagraphTypeName
{
get
{
return mstrParagraphTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrParagraphTypeName = value;
}
else
{
 mstrParagraphTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_ParagraphType.ParagraphTypeName);
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
 AddUpdatedFld(conzx_ParagraphType.Memo);
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
  return mstrzxParagraphTypeId;
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
  return mstrParagraphTypeName;
 }
 }
}
 /// <summary>
 /// 中学段落类型(zx_ParagraphType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_ParagraphType
{
public const string _CurrTabName = "zx_ParagraphType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxParagraphTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxParagraphTypeId", "ParagraphTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxParagraphTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxParagraphTypeId = "zxParagraphTypeId";    //段落类型Id

 /// <summary>
 /// 常量:"ParagraphTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ParagraphTypeName = "ParagraphTypeName";    //段落类型

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}