
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAllDataTypeEN
 表名:AllDataType(01160063)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 日期:2023/03/11 03:03:00
 生成者:pyf
 生成服务器IP:
 工程名称:简单工程样例(0116)
 CM工程:简单样例后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433SimplePrj
 PrjDataBaseId:0111
 模块中文名:基本信息(BaseInfo)
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

namespace SimplePrj.Entity
{
 /// <summary>
 /// 表AllDataType的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_AllDataType
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_AllDataType(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_AllDataType]类型的对象</returns>
public static implicit operator K_mId_AllDataType(long value)
{
return new K_mId_AllDataType(value);
}
}
 /// <summary>
 /// 各种数据类型(AllDataType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsAllDataTypeEN : clsEntityBase2
{
public const string _CurrTabName_S = "AllDataType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"mId", "mString", "mInt", "mLong", "mBool", "mDouble", "mFloat", "mDate", "OrderNum", "_IsDeleted", "_DeletedDate"};
//以下是属性变量

protected long mlngmId;    //mId
protected string mstrmString;    //字符串
protected int mintmInt;    //整型
protected long mlngmLong;    //长整型
protected bool mbolmBool;    //布尔型
protected double mdblmDouble;    //双精度
protected float mfltmFloat;    //浮点型
protected string mstrmDate;    //日期型
protected int mintOrderNum;    //排序
protected bool mbol_IsDeleted;    //是否删除
protected string mstr_DeletedDate;    //删除日期

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsAllDataTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "AllDataType";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsAllDataTypeEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "AllDataType";
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  conAllDataType.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conAllDataType.mString)
{
return mstrmString;
}
else if (strAttributeName  ==  conAllDataType.mInt)
{
return mintmInt;
}
else if (strAttributeName  ==  conAllDataType.mLong)
{
return mlngmLong;
}
else if (strAttributeName  ==  conAllDataType.mBool)
{
return mbolmBool;
}
else if (strAttributeName  ==  conAllDataType.mDouble)
{
return mdblmDouble;
}
else if (strAttributeName  ==  conAllDataType.mFloat)
{
return mfltmFloat;
}
else if (strAttributeName  ==  conAllDataType.mDate)
{
return mstrmDate;
}
else if (strAttributeName  ==  conAllDataType.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conAllDataType._IsDeleted)
{
return mbol_IsDeleted;
}
else if (strAttributeName  ==  conAllDataType._DeletedDate)
{
return mstr_DeletedDate;
}
return null;
}
set
{
if (strAttributeName  ==  conAllDataType.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conAllDataType.mId);
}
else if (strAttributeName  ==  conAllDataType.mString)
{
mstrmString = value.ToString();
 AddUpdatedFld(conAllDataType.mString);
}
else if (strAttributeName  ==  conAllDataType.mInt)
{
mintmInt = TransNullToInt(value.ToString());
 AddUpdatedFld(conAllDataType.mInt);
}
else if (strAttributeName  ==  conAllDataType.mLong)
{
mlngmLong = TransNullToInt(value.ToString());
 AddUpdatedFld(conAllDataType.mLong);
}
else if (strAttributeName  ==  conAllDataType.mBool)
{
mbolmBool = TransNullToBool(value.ToString());
 AddUpdatedFld(conAllDataType.mBool);
}
else if (strAttributeName  ==  conAllDataType.mDouble)
{
mdblmDouble = TransNullToDouble(value.ToString());
 AddUpdatedFld(conAllDataType.mDouble);
}
else if (strAttributeName  ==  conAllDataType.mFloat)
{
mfltmFloat = TransNullToFloat(value.ToString());
 AddUpdatedFld(conAllDataType.mFloat);
}
else if (strAttributeName  ==  conAllDataType.mDate)
{
mstrmDate = value.ToString();
 AddUpdatedFld(conAllDataType.mDate);
}
else if (strAttributeName  ==  conAllDataType.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conAllDataType.OrderNum);
}
else if (strAttributeName  ==  conAllDataType._IsDeleted)
{
mbol_IsDeleted = TransNullToBool(value.ToString());
 AddUpdatedFld(conAllDataType._IsDeleted);
}
else if (strAttributeName  ==  conAllDataType._DeletedDate)
{
mstr_DeletedDate = value.ToString();
 AddUpdatedFld(conAllDataType._DeletedDate);
}
}
}
public object this[int intIndex]
{
get
{
if (conAllDataType.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conAllDataType.mString  ==  AttributeName[intIndex])
{
return mstrmString;
}
else if (conAllDataType.mInt  ==  AttributeName[intIndex])
{
return mintmInt;
}
else if (conAllDataType.mLong  ==  AttributeName[intIndex])
{
return mlngmLong;
}
else if (conAllDataType.mBool  ==  AttributeName[intIndex])
{
return mbolmBool;
}
else if (conAllDataType.mDouble  ==  AttributeName[intIndex])
{
return mdblmDouble;
}
else if (conAllDataType.mFloat  ==  AttributeName[intIndex])
{
return mfltmFloat;
}
else if (conAllDataType.mDate  ==  AttributeName[intIndex])
{
return mstrmDate;
}
else if (conAllDataType.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conAllDataType._IsDeleted  ==  AttributeName[intIndex])
{
return mbol_IsDeleted;
}
else if (conAllDataType._DeletedDate  ==  AttributeName[intIndex])
{
return mstr_DeletedDate;
}
return null;
}
set
{
if (conAllDataType.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conAllDataType.mId);
}
else if (conAllDataType.mString  ==  AttributeName[intIndex])
{
mstrmString = value.ToString();
 AddUpdatedFld(conAllDataType.mString);
}
else if (conAllDataType.mInt  ==  AttributeName[intIndex])
{
mintmInt = TransNullToInt(value.ToString());
 AddUpdatedFld(conAllDataType.mInt);
}
else if (conAllDataType.mLong  ==  AttributeName[intIndex])
{
mlngmLong = TransNullToInt(value.ToString());
 AddUpdatedFld(conAllDataType.mLong);
}
else if (conAllDataType.mBool  ==  AttributeName[intIndex])
{
mbolmBool = TransNullToBool(value.ToString());
 AddUpdatedFld(conAllDataType.mBool);
}
else if (conAllDataType.mDouble  ==  AttributeName[intIndex])
{
mdblmDouble = TransNullToDouble(value.ToString());
 AddUpdatedFld(conAllDataType.mDouble);
}
else if (conAllDataType.mFloat  ==  AttributeName[intIndex])
{
mfltmFloat = TransNullToFloat(value.ToString());
 AddUpdatedFld(conAllDataType.mFloat);
}
else if (conAllDataType.mDate  ==  AttributeName[intIndex])
{
mstrmDate = value.ToString();
 AddUpdatedFld(conAllDataType.mDate);
}
else if (conAllDataType.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conAllDataType.OrderNum);
}
else if (conAllDataType._IsDeleted  ==  AttributeName[intIndex])
{
mbol_IsDeleted = TransNullToBool(value.ToString());
 AddUpdatedFld(conAllDataType._IsDeleted);
}
else if (conAllDataType._DeletedDate  ==  AttributeName[intIndex])
{
mstr_DeletedDate = value.ToString();
 AddUpdatedFld(conAllDataType._DeletedDate);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(conAllDataType.mId);
}
}
/// <summary>
/// 字符串(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string mString
{
get
{
return mstrmString;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrmString = value;
}
else
{
 mstrmString = value;
}
//记录修改过的字段
 AddUpdatedFld(conAllDataType.mString);
}
}
/// <summary>
/// 整型(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int mInt
{
get
{
return mintmInt;
}
set
{
 mintmInt = value;
//记录修改过的字段
 AddUpdatedFld(conAllDataType.mInt);
}
}
/// <summary>
/// 长整型(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mLong
{
get
{
return mlngmLong;
}
set
{
 mlngmLong = value;
//记录修改过的字段
 AddUpdatedFld(conAllDataType.mLong);
}
}
/// <summary>
/// 布尔型(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool mBool
{
get
{
return mbolmBool;
}
set
{
 mbolmBool = value;
//记录修改过的字段
 AddUpdatedFld(conAllDataType.mBool);
}
}
/// <summary>
/// 双精度(说明:;字段类型:decimal;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public double mDouble
{
get
{
return mdblmDouble;
}
set
{
 mdblmDouble = value;
//记录修改过的字段
 AddUpdatedFld(conAllDataType.mDouble);
}
}
/// <summary>
/// 浮点型(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float mFloat
{
get
{
return mfltmFloat;
}
set
{
 mfltmFloat = value;
//记录修改过的字段
 AddUpdatedFld(conAllDataType.mFloat);
}
}
/// <summary>
/// 日期型(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string mDate
{
get
{
return mstrmDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrmDate = value;
}
else
{
 mstrmDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conAllDataType.mDate);
}
}
/// <summary>
/// 排序(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conAllDataType.OrderNum);
}
}
/// <summary>
/// 是否删除(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool _IsDeleted
{
get
{
return mbol_IsDeleted;
}
set
{
 mbol_IsDeleted = value;
//记录修改过的字段
 AddUpdatedFld(conAllDataType._IsDeleted);
}
}
/// <summary>
/// 删除日期(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string _DeletedDate
{
get
{
return mstr_DeletedDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstr_DeletedDate = value;
}
else
{
 mstr_DeletedDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conAllDataType._DeletedDate);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// 各种数据类型(AllDataType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conAllDataType
{
public const string _CurrTabName_S = "AllDataType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "mString", "mInt", "mLong", "mBool", "mDouble", "mFloat", "mDate", "OrderNum", "_IsDeleted", "_DeletedDate"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"mString"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mString = "mString";    //字符串

 /// <summary>
 /// 常量:"mInt"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mInt = "mInt";    //整型

 /// <summary>
 /// 常量:"mLong"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mLong = "mLong";    //长整型

 /// <summary>
 /// 常量:"mBool"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mBool = "mBool";    //布尔型

 /// <summary>
 /// 常量:"mDouble"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mDouble = "mDouble";    //双精度

 /// <summary>
 /// 常量:"mFloat"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mFloat = "mFloat";    //浮点型

 /// <summary>
 /// 常量:"mDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mDate = "mDate";    //日期型

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //排序

 /// <summary>
 /// 常量:"_IsDeleted"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string _IsDeleted = "_IsDeleted";    //是否删除

 /// <summary>
 /// 常量:"_DeletedDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string _DeletedDate = "_DeletedDate";    //删除日期
}

}