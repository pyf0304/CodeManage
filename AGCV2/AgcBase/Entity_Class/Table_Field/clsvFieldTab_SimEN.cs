
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFieldTab_SimEN
 表名:vFieldTab_Sim(00050590)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/16 09:47:18
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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

namespace AGC.Entity
{
 /// <summary>
 /// 表vFieldTab_Sim的关键字(FldId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FldId_vFieldTab_Sim
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFldId">表关键字</param>
public K_FldId_vFieldTab_Sim(string strFldId)
{
if (IsValid(strFldId)) Value = strFldId;
else
{
Value = null;
}
}
private static bool IsValid(string strFldId)
{
if (string.IsNullOrEmpty(strFldId) == true) return false;
if (strFldId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FldId_vFieldTab_Sim]类型的对象</returns>
public static implicit operator K_FldId_vFieldTab_Sim(string value)
{
return new K_FldId_vFieldTab_Sim(value);
}
}
 /// <summary>
 /// v字段表_Sim(vFieldTab_Sim)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvFieldTab_SimEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vFieldTab_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FldId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = "FldId in (select fldid from fieldtab where prjid ='{0}')"; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"FldId", "FldName", "Caption", "DataTypeId", "HomologousFldId", "PrjId", "FldPrecision", "FldLength"};

protected string mstrFldId;    //字段Id
protected string mstrFldName;    //字段名
protected string mstrCaption;    //标题
protected string mstrDataTypeId;    //数据类型Id
protected string mstrHomologousFldId;    //同源字段Id
protected string mstrPrjId;    //工程ID
protected int? mintFldPrecision;    //精确度
protected int mintFldLength;    //字段长度

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvFieldTab_SimEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FldId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strFldId">关键字:字段Id</param>
public clsvFieldTab_SimEN(string strFldId)
 {
strFldId = strFldId.Replace("'", "''");
if (strFldId.Length > 8)
{
throw new Exception("在表:vFieldTab_Sim中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFldId)  ==  true)
{
throw new Exception("在表:vFieldTab_Sim中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFldId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFldId = strFldId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FldId");
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
if (strAttributeName  ==  convFieldTab_Sim.FldId)
{
return mstrFldId;
}
else if (strAttributeName  ==  convFieldTab_Sim.FldName)
{
return mstrFldName;
}
else if (strAttributeName  ==  convFieldTab_Sim.Caption)
{
return mstrCaption;
}
else if (strAttributeName  ==  convFieldTab_Sim.DataTypeId)
{
return mstrDataTypeId;
}
else if (strAttributeName  ==  convFieldTab_Sim.HomologousFldId)
{
return mstrHomologousFldId;
}
else if (strAttributeName  ==  convFieldTab_Sim.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convFieldTab_Sim.FldPrecision)
{
return mintFldPrecision;
}
else if (strAttributeName  ==  convFieldTab_Sim.FldLength)
{
return mintFldLength;
}
return null;
}
set
{
if (strAttributeName  ==  convFieldTab_Sim.FldId)
{
mstrFldId = value.ToString();
 AddUpdatedFld(convFieldTab_Sim.FldId);
}
else if (strAttributeName  ==  convFieldTab_Sim.FldName)
{
mstrFldName = value.ToString();
 AddUpdatedFld(convFieldTab_Sim.FldName);
}
else if (strAttributeName  ==  convFieldTab_Sim.Caption)
{
mstrCaption = value.ToString();
 AddUpdatedFld(convFieldTab_Sim.Caption);
}
else if (strAttributeName  ==  convFieldTab_Sim.DataTypeId)
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(convFieldTab_Sim.DataTypeId);
}
else if (strAttributeName  ==  convFieldTab_Sim.HomologousFldId)
{
mstrHomologousFldId = value.ToString();
 AddUpdatedFld(convFieldTab_Sim.HomologousFldId);
}
else if (strAttributeName  ==  convFieldTab_Sim.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convFieldTab_Sim.PrjId);
}
else if (strAttributeName  ==  convFieldTab_Sim.FldPrecision)
{
mintFldPrecision = TransNullToInt(value.ToString());
 AddUpdatedFld(convFieldTab_Sim.FldPrecision);
}
else if (strAttributeName  ==  convFieldTab_Sim.FldLength)
{
mintFldLength = TransNullToInt(value.ToString());
 AddUpdatedFld(convFieldTab_Sim.FldLength);
}
}
}
public object this[int intIndex]
{
get
{
if (convFieldTab_Sim.FldId  ==  AttributeName[intIndex])
{
return mstrFldId;
}
else if (convFieldTab_Sim.FldName  ==  AttributeName[intIndex])
{
return mstrFldName;
}
else if (convFieldTab_Sim.Caption  ==  AttributeName[intIndex])
{
return mstrCaption;
}
else if (convFieldTab_Sim.DataTypeId  ==  AttributeName[intIndex])
{
return mstrDataTypeId;
}
else if (convFieldTab_Sim.HomologousFldId  ==  AttributeName[intIndex])
{
return mstrHomologousFldId;
}
else if (convFieldTab_Sim.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convFieldTab_Sim.FldPrecision  ==  AttributeName[intIndex])
{
return mintFldPrecision;
}
else if (convFieldTab_Sim.FldLength  ==  AttributeName[intIndex])
{
return mintFldLength;
}
return null;
}
set
{
if (convFieldTab_Sim.FldId  ==  AttributeName[intIndex])
{
mstrFldId = value.ToString();
 AddUpdatedFld(convFieldTab_Sim.FldId);
}
else if (convFieldTab_Sim.FldName  ==  AttributeName[intIndex])
{
mstrFldName = value.ToString();
 AddUpdatedFld(convFieldTab_Sim.FldName);
}
else if (convFieldTab_Sim.Caption  ==  AttributeName[intIndex])
{
mstrCaption = value.ToString();
 AddUpdatedFld(convFieldTab_Sim.Caption);
}
else if (convFieldTab_Sim.DataTypeId  ==  AttributeName[intIndex])
{
mstrDataTypeId = value.ToString();
 AddUpdatedFld(convFieldTab_Sim.DataTypeId);
}
else if (convFieldTab_Sim.HomologousFldId  ==  AttributeName[intIndex])
{
mstrHomologousFldId = value.ToString();
 AddUpdatedFld(convFieldTab_Sim.HomologousFldId);
}
else if (convFieldTab_Sim.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convFieldTab_Sim.PrjId);
}
else if (convFieldTab_Sim.FldPrecision  ==  AttributeName[intIndex])
{
mintFldPrecision = TransNullToInt(value.ToString());
 AddUpdatedFld(convFieldTab_Sim.FldPrecision);
}
else if (convFieldTab_Sim.FldLength  ==  AttributeName[intIndex])
{
mintFldLength = TransNullToInt(value.ToString());
 AddUpdatedFld(convFieldTab_Sim.FldLength);
}
}
}

/// <summary>
/// 字段Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldId
{
get
{
return mstrFldId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldId = value;
}
else
{
 mstrFldId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab_Sim.FldId);
}
}
/// <summary>
/// 字段名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FldName
{
get
{
return mstrFldName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFldName = value;
}
else
{
 mstrFldName = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab_Sim.FldName);
}
}
/// <summary>
/// 标题(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Caption
{
get
{
return mstrCaption;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaption = value;
}
else
{
 mstrCaption = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab_Sim.Caption);
}
}
/// <summary>
/// 数据类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataTypeId
{
get
{
return mstrDataTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataTypeId = value;
}
else
{
 mstrDataTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab_Sim.DataTypeId);
}
}
/// <summary>
/// 同源字段Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string HomologousFldId
{
get
{
return mstrHomologousFldId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrHomologousFldId = value;
}
else
{
 mstrHomologousFldId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab_Sim.HomologousFldId);
}
}
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjId
{
get
{
return mstrPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjId = value;
}
else
{
 mstrPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(convFieldTab_Sim.PrjId);
}
}
/// <summary>
/// 精确度(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? FldPrecision
{
get
{
return mintFldPrecision;
}
set
{
 mintFldPrecision = value;
//记录修改过的字段
 AddUpdatedFld(convFieldTab_Sim.FldPrecision);
}
}
/// <summary>
/// 字段长度(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int FldLength
{
get
{
return mintFldLength;
}
set
{
 mintFldLength = value;
//记录修改过的字段
 AddUpdatedFld(convFieldTab_Sim.FldLength);
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
  return mstrFldId;
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
  return mstrFldName;
 }
 }
}
 /// <summary>
 /// v字段表_Sim(vFieldTab_Sim)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convFieldTab_Sim
{
public const string _CurrTabName = "vFieldTab_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FldId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"FldId", "FldName", "Caption", "DataTypeId", "HomologousFldId", "PrjId", "FldPrecision", "FldLength"};
//以下是属性变量


 /// <summary>
 /// 常量:"FldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldId = "FldId";    //字段Id

 /// <summary>
 /// 常量:"FldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldName = "FldName";    //字段名

 /// <summary>
 /// 常量:"Caption"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Caption = "Caption";    //标题

 /// <summary>
 /// 常量:"DataTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataTypeId = "DataTypeId";    //数据类型Id

 /// <summary>
 /// 常量:"HomologousFldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string HomologousFldId = "HomologousFldId";    //同源字段Id

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程ID

 /// <summary>
 /// 常量:"FldPrecision"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldPrecision = "FldPrecision";    //精确度

 /// <summary>
 /// 常量:"FldLength"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FldLength = "FldLength";    //字段长度
}

}