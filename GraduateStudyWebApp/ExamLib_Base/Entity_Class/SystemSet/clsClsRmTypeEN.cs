
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsClsRmTypeEN
 表名:ClsRmType(01120576)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:06:27
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置(SystemSet)
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
 /// 表ClsRmType的关键字(IdClassRoomType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdClassRoomType_ClsRmType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdClassRoomType">表关键字</param>
public K_IdClassRoomType_ClsRmType(string strIdClassRoomType)
{
if (IsValid(strIdClassRoomType)) Value = strIdClassRoomType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdClassRoomType)
{
if (string.IsNullOrEmpty(strIdClassRoomType) == true) return false;
if (strIdClassRoomType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdClassRoomType_ClsRmType]类型的对象</returns>
public static implicit operator K_IdClassRoomType_ClsRmType(string value)
{
return new K_IdClassRoomType_ClsRmType(value);
}
}
 /// <summary>
 /// 教室类型(ClsRmType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsClsRmTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ClsRmType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdClassRoomType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"IdClassRoomType", "ClassRoomTypeID", "ClassRoomTypeDesc", "ClassRoomTypeDescA", "ModifyUserId", "ModifyDate", "Memo"};

protected string mstrIdClassRoomType;    //教室类型流水号
protected string mstrClassRoomTypeID;    //教室类型代号
protected string mstrClassRoomTypeDesc;    //教室类型描述
protected string mstrClassRoomTypeDescA;    //教室类型简称
protected string mstrModifyUserId;    //修改人
protected string mstrModifyDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsClsRmTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdClassRoomType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdClassRoomType">关键字:教室类型流水号</param>
public clsClsRmTypeEN(string strIdClassRoomType)
 {
strIdClassRoomType = strIdClassRoomType.Replace("'", "''");
if (strIdClassRoomType.Length > 4)
{
throw new Exception("在表:ClsRmType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdClassRoomType)  ==  true)
{
throw new Exception("在表:ClsRmType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdClassRoomType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdClassRoomType = strIdClassRoomType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdClassRoomType");
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
if (strAttributeName  ==  conClsRmType.IdClassRoomType)
{
return mstrIdClassRoomType;
}
else if (strAttributeName  ==  conClsRmType.ClassRoomTypeID)
{
return mstrClassRoomTypeID;
}
else if (strAttributeName  ==  conClsRmType.ClassRoomTypeDesc)
{
return mstrClassRoomTypeDesc;
}
else if (strAttributeName  ==  conClsRmType.ClassRoomTypeDescA)
{
return mstrClassRoomTypeDescA;
}
else if (strAttributeName  ==  conClsRmType.ModifyUserId)
{
return mstrModifyUserId;
}
else if (strAttributeName  ==  conClsRmType.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  conClsRmType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conClsRmType.IdClassRoomType)
{
mstrIdClassRoomType = value.ToString();
 AddUpdatedFld(conClsRmType.IdClassRoomType);
}
else if (strAttributeName  ==  conClsRmType.ClassRoomTypeID)
{
mstrClassRoomTypeID = value.ToString();
 AddUpdatedFld(conClsRmType.ClassRoomTypeID);
}
else if (strAttributeName  ==  conClsRmType.ClassRoomTypeDesc)
{
mstrClassRoomTypeDesc = value.ToString();
 AddUpdatedFld(conClsRmType.ClassRoomTypeDesc);
}
else if (strAttributeName  ==  conClsRmType.ClassRoomTypeDescA)
{
mstrClassRoomTypeDescA = value.ToString();
 AddUpdatedFld(conClsRmType.ClassRoomTypeDescA);
}
else if (strAttributeName  ==  conClsRmType.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conClsRmType.ModifyUserId);
}
else if (strAttributeName  ==  conClsRmType.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conClsRmType.ModifyDate);
}
else if (strAttributeName  ==  conClsRmType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conClsRmType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conClsRmType.IdClassRoomType  ==  AttributeName[intIndex])
{
return mstrIdClassRoomType;
}
else if (conClsRmType.ClassRoomTypeID  ==  AttributeName[intIndex])
{
return mstrClassRoomTypeID;
}
else if (conClsRmType.ClassRoomTypeDesc  ==  AttributeName[intIndex])
{
return mstrClassRoomTypeDesc;
}
else if (conClsRmType.ClassRoomTypeDescA  ==  AttributeName[intIndex])
{
return mstrClassRoomTypeDescA;
}
else if (conClsRmType.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
else if (conClsRmType.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (conClsRmType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conClsRmType.IdClassRoomType  ==  AttributeName[intIndex])
{
mstrIdClassRoomType = value.ToString();
 AddUpdatedFld(conClsRmType.IdClassRoomType);
}
else if (conClsRmType.ClassRoomTypeID  ==  AttributeName[intIndex])
{
mstrClassRoomTypeID = value.ToString();
 AddUpdatedFld(conClsRmType.ClassRoomTypeID);
}
else if (conClsRmType.ClassRoomTypeDesc  ==  AttributeName[intIndex])
{
mstrClassRoomTypeDesc = value.ToString();
 AddUpdatedFld(conClsRmType.ClassRoomTypeDesc);
}
else if (conClsRmType.ClassRoomTypeDescA  ==  AttributeName[intIndex])
{
mstrClassRoomTypeDescA = value.ToString();
 AddUpdatedFld(conClsRmType.ClassRoomTypeDescA);
}
else if (conClsRmType.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conClsRmType.ModifyUserId);
}
else if (conClsRmType.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conClsRmType.ModifyDate);
}
else if (conClsRmType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conClsRmType.Memo);
}
}
}

/// <summary>
/// 教室类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdClassRoomType
{
get
{
return mstrIdClassRoomType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdClassRoomType = value;
}
else
{
 mstrIdClassRoomType = value;
}
//记录修改过的字段
 AddUpdatedFld(conClsRmType.IdClassRoomType);
}
}
/// <summary>
/// 教室类型代号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClassRoomTypeID
{
get
{
return mstrClassRoomTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClassRoomTypeID = value;
}
else
{
 mstrClassRoomTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(conClsRmType.ClassRoomTypeID);
}
}
/// <summary>
/// 教室类型描述(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClassRoomTypeDesc
{
get
{
return mstrClassRoomTypeDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClassRoomTypeDesc = value;
}
else
{
 mstrClassRoomTypeDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(conClsRmType.ClassRoomTypeDesc);
}
}
/// <summary>
/// 教室类型简称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClassRoomTypeDescA
{
get
{
return mstrClassRoomTypeDescA;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClassRoomTypeDescA = value;
}
else
{
 mstrClassRoomTypeDescA = value;
}
//记录修改过的字段
 AddUpdatedFld(conClsRmType.ClassRoomTypeDescA);
}
}
/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyUserId
{
get
{
return mstrModifyUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyUserId = value;
}
else
{
 mstrModifyUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conClsRmType.ModifyUserId);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyDate
{
get
{
return mstrModifyDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyDate = value;
}
else
{
 mstrModifyDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conClsRmType.ModifyDate);
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
 AddUpdatedFld(conClsRmType.Memo);
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
  return mstrIdClassRoomType;
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
  return mstrClassRoomTypeDesc;
 }
 }
}
 /// <summary>
 /// 教室类型(ClsRmType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conClsRmType
{
public const string _CurrTabName = "ClsRmType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdClassRoomType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdClassRoomType", "ClassRoomTypeID", "ClassRoomTypeDesc", "ClassRoomTypeDescA", "ModifyUserId", "ModifyDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdClassRoomType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdClassRoomType = "IdClassRoomType";    //教室类型流水号

 /// <summary>
 /// 常量:"ClassRoomTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassRoomTypeID = "ClassRoomTypeID";    //教室类型代号

 /// <summary>
 /// 常量:"ClassRoomTypeDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassRoomTypeDesc = "ClassRoomTypeDesc";    //教室类型描述

 /// <summary>
 /// 常量:"ClassRoomTypeDescA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassRoomTypeDescA = "ClassRoomTypeDescA";    //教室类型简称

 /// <summary>
 /// 常量:"ModifyUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyUserId = "ModifyUserId";    //修改人

 /// <summary>
 /// 常量:"ModifyDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyDate = "ModifyDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}