
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ViewpointTypeEN
 表名:zx_ViewpointType(01120828)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:55:12
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
 /// 表zx_ViewpointType的关键字(zxViewpointTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxViewpointTypeId_zx_ViewpointType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxViewpointTypeId">表关键字</param>
public K_zxViewpointTypeId_zx_ViewpointType(string strzxViewpointTypeId)
{
if (IsValid(strzxViewpointTypeId)) Value = strzxViewpointTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxViewpointTypeId)
{
if (string.IsNullOrEmpty(strzxViewpointTypeId) == true) return false;
if (strzxViewpointTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxViewpointTypeId_zx_ViewpointType]类型的对象</returns>
public static implicit operator K_zxViewpointTypeId_zx_ViewpointType(string value)
{
return new K_zxViewpointTypeId_zx_ViewpointType(value);
}
}
 /// <summary>
 /// 中学观点类型(zx_ViewpointType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_ViewpointTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_ViewpointType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxViewpointTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"zxViewpointTypeId", "ViewpointTypeName", "Memo"};

protected string mstrzxViewpointTypeId;    //观点类型Id
protected string mstrViewpointTypeName;    //观点类型名
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_ViewpointTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxViewpointTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxViewpointTypeId">关键字:观点类型Id</param>
public clszx_ViewpointTypeEN(string strzxViewpointTypeId)
 {
strzxViewpointTypeId = strzxViewpointTypeId.Replace("'", "''");
if (strzxViewpointTypeId.Length > 4)
{
throw new Exception("在表:zx_ViewpointType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxViewpointTypeId)  ==  true)
{
throw new Exception("在表:zx_ViewpointType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxViewpointTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxViewpointTypeId = strzxViewpointTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxViewpointTypeId");
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
if (strAttributeName  ==  conzx_ViewpointType.zxViewpointTypeId)
{
return mstrzxViewpointTypeId;
}
else if (strAttributeName  ==  conzx_ViewpointType.ViewpointTypeName)
{
return mstrViewpointTypeName;
}
else if (strAttributeName  ==  conzx_ViewpointType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_ViewpointType.zxViewpointTypeId)
{
mstrzxViewpointTypeId = value.ToString();
 AddUpdatedFld(conzx_ViewpointType.zxViewpointTypeId);
}
else if (strAttributeName  ==  conzx_ViewpointType.ViewpointTypeName)
{
mstrViewpointTypeName = value.ToString();
 AddUpdatedFld(conzx_ViewpointType.ViewpointTypeName);
}
else if (strAttributeName  ==  conzx_ViewpointType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_ViewpointType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_ViewpointType.zxViewpointTypeId  ==  AttributeName[intIndex])
{
return mstrzxViewpointTypeId;
}
else if (conzx_ViewpointType.ViewpointTypeName  ==  AttributeName[intIndex])
{
return mstrViewpointTypeName;
}
else if (conzx_ViewpointType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_ViewpointType.zxViewpointTypeId  ==  AttributeName[intIndex])
{
mstrzxViewpointTypeId = value.ToString();
 AddUpdatedFld(conzx_ViewpointType.zxViewpointTypeId);
}
else if (conzx_ViewpointType.ViewpointTypeName  ==  AttributeName[intIndex])
{
mstrViewpointTypeName = value.ToString();
 AddUpdatedFld(conzx_ViewpointType.ViewpointTypeName);
}
else if (conzx_ViewpointType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_ViewpointType.Memo);
}
}
}

/// <summary>
/// 观点类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxViewpointTypeId
{
get
{
return mstrzxViewpointTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxViewpointTypeId = value;
}
else
{
 mstrzxViewpointTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_ViewpointType.zxViewpointTypeId);
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
 AddUpdatedFld(conzx_ViewpointType.ViewpointTypeName);
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
 AddUpdatedFld(conzx_ViewpointType.Memo);
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
  return mstrzxViewpointTypeId;
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
 /// 中学观点类型(zx_ViewpointType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_ViewpointType
{
public const string _CurrTabName = "zx_ViewpointType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxViewpointTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxViewpointTypeId", "ViewpointTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxViewpointTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxViewpointTypeId = "zxViewpointTypeId";    //观点类型Id

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