
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ConfigTypeEN
 表名:zx_ConfigType(01120781)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:55:21
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
 /// 表zx_ConfigType的关键字(zxConfigTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxConfigTypeId_zx_ConfigType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxConfigTypeId">表关键字</param>
public K_zxConfigTypeId_zx_ConfigType(string strzxConfigTypeId)
{
if (IsValid(strzxConfigTypeId)) Value = strzxConfigTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxConfigTypeId)
{
if (string.IsNullOrEmpty(strzxConfigTypeId) == true) return false;
if (strzxConfigTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxConfigTypeId_zx_ConfigType]类型的对象</returns>
public static implicit operator K_zxConfigTypeId_zx_ConfigType(string value)
{
return new K_zxConfigTypeId_zx_ConfigType(value);
}
}
 /// <summary>
 /// 配置类型_zx(zx_ConfigType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_ConfigTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_ConfigType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxConfigTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"zxConfigTypeId", "ConfigTypeName", "DataTable", "DataTableId", "Memo"};

protected string mstrzxConfigTypeId;    //配置类型Id
protected string mstrConfigTypeName;    //配置类型名称
protected string mstrDataTable;    //数据表
protected string mstrDataTableId;    //数据表Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_ConfigTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxConfigTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxConfigTypeId">关键字:配置类型Id</param>
public clszx_ConfigTypeEN(string strzxConfigTypeId)
 {
strzxConfigTypeId = strzxConfigTypeId.Replace("'", "''");
if (strzxConfigTypeId.Length > 2)
{
throw new Exception("在表:zx_ConfigType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxConfigTypeId)  ==  true)
{
throw new Exception("在表:zx_ConfigType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxConfigTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxConfigTypeId = strzxConfigTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxConfigTypeId");
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
if (strAttributeName  ==  conzx_ConfigType.zxConfigTypeId)
{
return mstrzxConfigTypeId;
}
else if (strAttributeName  ==  conzx_ConfigType.ConfigTypeName)
{
return mstrConfigTypeName;
}
else if (strAttributeName  ==  conzx_ConfigType.DataTable)
{
return mstrDataTable;
}
else if (strAttributeName  ==  conzx_ConfigType.DataTableId)
{
return mstrDataTableId;
}
else if (strAttributeName  ==  conzx_ConfigType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_ConfigType.zxConfigTypeId)
{
mstrzxConfigTypeId = value.ToString();
 AddUpdatedFld(conzx_ConfigType.zxConfigTypeId);
}
else if (strAttributeName  ==  conzx_ConfigType.ConfigTypeName)
{
mstrConfigTypeName = value.ToString();
 AddUpdatedFld(conzx_ConfigType.ConfigTypeName);
}
else if (strAttributeName  ==  conzx_ConfigType.DataTable)
{
mstrDataTable = value.ToString();
 AddUpdatedFld(conzx_ConfigType.DataTable);
}
else if (strAttributeName  ==  conzx_ConfigType.DataTableId)
{
mstrDataTableId = value.ToString();
 AddUpdatedFld(conzx_ConfigType.DataTableId);
}
else if (strAttributeName  ==  conzx_ConfigType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_ConfigType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_ConfigType.zxConfigTypeId  ==  AttributeName[intIndex])
{
return mstrzxConfigTypeId;
}
else if (conzx_ConfigType.ConfigTypeName  ==  AttributeName[intIndex])
{
return mstrConfigTypeName;
}
else if (conzx_ConfigType.DataTable  ==  AttributeName[intIndex])
{
return mstrDataTable;
}
else if (conzx_ConfigType.DataTableId  ==  AttributeName[intIndex])
{
return mstrDataTableId;
}
else if (conzx_ConfigType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_ConfigType.zxConfigTypeId  ==  AttributeName[intIndex])
{
mstrzxConfigTypeId = value.ToString();
 AddUpdatedFld(conzx_ConfigType.zxConfigTypeId);
}
else if (conzx_ConfigType.ConfigTypeName  ==  AttributeName[intIndex])
{
mstrConfigTypeName = value.ToString();
 AddUpdatedFld(conzx_ConfigType.ConfigTypeName);
}
else if (conzx_ConfigType.DataTable  ==  AttributeName[intIndex])
{
mstrDataTable = value.ToString();
 AddUpdatedFld(conzx_ConfigType.DataTable);
}
else if (conzx_ConfigType.DataTableId  ==  AttributeName[intIndex])
{
mstrDataTableId = value.ToString();
 AddUpdatedFld(conzx_ConfigType.DataTableId);
}
else if (conzx_ConfigType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_ConfigType.Memo);
}
}
}

/// <summary>
/// 配置类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxConfigTypeId
{
get
{
return mstrzxConfigTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxConfigTypeId = value;
}
else
{
 mstrzxConfigTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_ConfigType.zxConfigTypeId);
}
}
/// <summary>
/// 配置类型名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConfigTypeName
{
get
{
return mstrConfigTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConfigTypeName = value;
}
else
{
 mstrConfigTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_ConfigType.ConfigTypeName);
}
}
/// <summary>
/// 数据表(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataTable
{
get
{
return mstrDataTable;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataTable = value;
}
else
{
 mstrDataTable = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_ConfigType.DataTable);
}
}
/// <summary>
/// 数据表Id(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataTableId
{
get
{
return mstrDataTableId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataTableId = value;
}
else
{
 mstrDataTableId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_ConfigType.DataTableId);
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
 AddUpdatedFld(conzx_ConfigType.Memo);
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
  return mstrzxConfigTypeId;
 }
 }
}
 /// <summary>
 /// 配置类型_zx(zx_ConfigType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_ConfigType
{
public const string _CurrTabName = "zx_ConfigType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxConfigTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxConfigTypeId", "ConfigTypeName", "DataTable", "DataTableId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxConfigTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxConfigTypeId = "zxConfigTypeId";    //配置类型Id

 /// <summary>
 /// 常量:"ConfigTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConfigTypeName = "ConfigTypeName";    //配置类型名称

 /// <summary>
 /// 常量:"DataTable"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataTable = "DataTable";    //数据表

 /// <summary>
 /// 常量:"DataTableId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataTableId = "DataTableId";    //数据表Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}