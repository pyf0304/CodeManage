
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TotalDataTypeEN
 表名:zx_TotalDataType(01120792)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:56:01
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
 /// 表zx_TotalDataType的关键字(zxTotalDataTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxTotalDataTypeId_zx_TotalDataType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxTotalDataTypeId">表关键字</param>
public K_zxTotalDataTypeId_zx_TotalDataType(string strzxTotalDataTypeId)
{
if (IsValid(strzxTotalDataTypeId)) Value = strzxTotalDataTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxTotalDataTypeId)
{
if (string.IsNullOrEmpty(strzxTotalDataTypeId) == true) return false;
if (strzxTotalDataTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxTotalDataTypeId_zx_TotalDataType]类型的对象</returns>
public static implicit operator K_zxTotalDataTypeId_zx_TotalDataType(string value)
{
return new K_zxTotalDataTypeId_zx_TotalDataType(value);
}
}
 /// <summary>
 /// 中学总数据类型表(zx_TotalDataType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_TotalDataTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_TotalDataType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxTotalDataTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"zxTotalDataTypeId", "TotalDataTypeName", "DataTable", "DataTableId", "Memo", "OnlyId"};

protected string mstrzxTotalDataTypeId;    //总数据类型Id
protected string mstrTotalDataTypeName;    //总数据类型名称
protected string mstrDataTable;    //数据表
protected string mstrDataTableId;    //数据表Id
protected string mstrMemo;    //备注
protected string mstrOnlyId;    //OnlyId

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_TotalDataTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxTotalDataTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxTotalDataTypeId">关键字:总数据类型Id</param>
public clszx_TotalDataTypeEN(string strzxTotalDataTypeId)
 {
strzxTotalDataTypeId = strzxTotalDataTypeId.Replace("'", "''");
if (strzxTotalDataTypeId.Length > 2)
{
throw new Exception("在表:zx_TotalDataType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxTotalDataTypeId)  ==  true)
{
throw new Exception("在表:zx_TotalDataType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxTotalDataTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxTotalDataTypeId = strzxTotalDataTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxTotalDataTypeId");
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
if (strAttributeName  ==  conzx_TotalDataType.zxTotalDataTypeId)
{
return mstrzxTotalDataTypeId;
}
else if (strAttributeName  ==  conzx_TotalDataType.TotalDataTypeName)
{
return mstrTotalDataTypeName;
}
else if (strAttributeName  ==  conzx_TotalDataType.DataTable)
{
return mstrDataTable;
}
else if (strAttributeName  ==  conzx_TotalDataType.DataTableId)
{
return mstrDataTableId;
}
else if (strAttributeName  ==  conzx_TotalDataType.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conzx_TotalDataType.OnlyId)
{
return mstrOnlyId;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_TotalDataType.zxTotalDataTypeId)
{
mstrzxTotalDataTypeId = value.ToString();
 AddUpdatedFld(conzx_TotalDataType.zxTotalDataTypeId);
}
else if (strAttributeName  ==  conzx_TotalDataType.TotalDataTypeName)
{
mstrTotalDataTypeName = value.ToString();
 AddUpdatedFld(conzx_TotalDataType.TotalDataTypeName);
}
else if (strAttributeName  ==  conzx_TotalDataType.DataTable)
{
mstrDataTable = value.ToString();
 AddUpdatedFld(conzx_TotalDataType.DataTable);
}
else if (strAttributeName  ==  conzx_TotalDataType.DataTableId)
{
mstrDataTableId = value.ToString();
 AddUpdatedFld(conzx_TotalDataType.DataTableId);
}
else if (strAttributeName  ==  conzx_TotalDataType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_TotalDataType.Memo);
}
else if (strAttributeName  ==  conzx_TotalDataType.OnlyId)
{
mstrOnlyId = value.ToString();
 AddUpdatedFld(conzx_TotalDataType.OnlyId);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_TotalDataType.zxTotalDataTypeId  ==  AttributeName[intIndex])
{
return mstrzxTotalDataTypeId;
}
else if (conzx_TotalDataType.TotalDataTypeName  ==  AttributeName[intIndex])
{
return mstrTotalDataTypeName;
}
else if (conzx_TotalDataType.DataTable  ==  AttributeName[intIndex])
{
return mstrDataTable;
}
else if (conzx_TotalDataType.DataTableId  ==  AttributeName[intIndex])
{
return mstrDataTableId;
}
else if (conzx_TotalDataType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conzx_TotalDataType.OnlyId  ==  AttributeName[intIndex])
{
return mstrOnlyId;
}
return null;
}
set
{
if (conzx_TotalDataType.zxTotalDataTypeId  ==  AttributeName[intIndex])
{
mstrzxTotalDataTypeId = value.ToString();
 AddUpdatedFld(conzx_TotalDataType.zxTotalDataTypeId);
}
else if (conzx_TotalDataType.TotalDataTypeName  ==  AttributeName[intIndex])
{
mstrTotalDataTypeName = value.ToString();
 AddUpdatedFld(conzx_TotalDataType.TotalDataTypeName);
}
else if (conzx_TotalDataType.DataTable  ==  AttributeName[intIndex])
{
mstrDataTable = value.ToString();
 AddUpdatedFld(conzx_TotalDataType.DataTable);
}
else if (conzx_TotalDataType.DataTableId  ==  AttributeName[intIndex])
{
mstrDataTableId = value.ToString();
 AddUpdatedFld(conzx_TotalDataType.DataTableId);
}
else if (conzx_TotalDataType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_TotalDataType.Memo);
}
else if (conzx_TotalDataType.OnlyId  ==  AttributeName[intIndex])
{
mstrOnlyId = value.ToString();
 AddUpdatedFld(conzx_TotalDataType.OnlyId);
}
}
}

/// <summary>
/// 总数据类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxTotalDataTypeId
{
get
{
return mstrzxTotalDataTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxTotalDataTypeId = value;
}
else
{
 mstrzxTotalDataTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_TotalDataType.zxTotalDataTypeId);
}
}
/// <summary>
/// 总数据类型名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TotalDataTypeName
{
get
{
return mstrTotalDataTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTotalDataTypeName = value;
}
else
{
 mstrTotalDataTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_TotalDataType.TotalDataTypeName);
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
 AddUpdatedFld(conzx_TotalDataType.DataTable);
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
 AddUpdatedFld(conzx_TotalDataType.DataTableId);
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
 AddUpdatedFld(conzx_TotalDataType.Memo);
}
}
/// <summary>
/// OnlyId(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OnlyId
{
get
{
return mstrOnlyId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOnlyId = value;
}
else
{
 mstrOnlyId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_TotalDataType.OnlyId);
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
  return mstrzxTotalDataTypeId;
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
  return mstrTotalDataTypeName;
 }
 }
}
 /// <summary>
 /// 中学总数据类型表(zx_TotalDataType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_TotalDataType
{
public const string _CurrTabName = "zx_TotalDataType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxTotalDataTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxTotalDataTypeId", "TotalDataTypeName", "DataTable", "DataTableId", "Memo", "OnlyId"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxTotalDataTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxTotalDataTypeId = "zxTotalDataTypeId";    //总数据类型Id

 /// <summary>
 /// 常量:"TotalDataTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TotalDataTypeName = "TotalDataTypeName";    //总数据类型名称

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

 /// <summary>
 /// 常量:"OnlyId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OnlyId = "OnlyId";    //OnlyId
}

}