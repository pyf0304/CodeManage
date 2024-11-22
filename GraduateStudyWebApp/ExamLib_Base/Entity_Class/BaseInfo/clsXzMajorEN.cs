
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzMajorEN
 表名:XzMajor(01120065)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:59:41
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:基本信息维护(BaseInfo)
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
 /// 表XzMajor的关键字(IdXzMajor)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdXzMajor_XzMajor
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdXzMajor">表关键字</param>
public K_IdXzMajor_XzMajor(string strIdXzMajor)
{
if (IsValid(strIdXzMajor)) Value = strIdXzMajor;
else
{
Value = null;
}
}
private static bool IsValid(string strIdXzMajor)
{
if (string.IsNullOrEmpty(strIdXzMajor) == true) return false;
if (strIdXzMajor.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdXzMajor_XzMajor]类型的对象</returns>
public static implicit operator K_IdXzMajor_XzMajor(string value)
{
return new K_IdXzMajor_XzMajor(value);
}
}
 /// <summary>
 /// 专业(XzMajor)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsXzMajorEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "XzMajor"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdXzMajor"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 17;
public static string[] AttributeName = new string[] {"IdXzMajor", "MajorId", "MajorName", "MajorEnglishName", "MajorExplain", "MajorNationalID", "IdXzCollege", "IdMajorType", "IdDegreeType", "IsMainMajor", "MajorDirection", "IsVisible", "IsNormal", "ModifyDate", "ModifyUserId", "Memo", "IdXzMajorShoolType"};

protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorId;    //专业Id
protected string mstrMajorName;    //专业名称
protected string mstrMajorEnglishName;    //专业英文名称
protected string mstrMajorExplain;    //专业说明
protected string mstrMajorNationalID;    //专业国家代码
protected string mstrIdXzCollege;    //学院流水号
protected string mstrIdMajorType;    //专业类型(文理工)流水号
protected string mstrIdDegreeType;    //学位类型流水号
protected bool mbolIsMainMajor;    //是否重要专业
protected string mstrMajorDirection;    //专业方向
protected bool mbolIsVisible;    //是否显示
protected bool mbolIsNormal;    //IsNormal
protected string mstrModifyDate;    //修改日期
protected string mstrModifyUserId;    //修改人
protected string mstrMemo;    //备注
protected string mstrIdXzMajorShoolType;    //专业学校类型流水号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsXzMajorEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdXzMajor");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdXzMajor">关键字:专业流水号</param>
public clsXzMajorEN(string strIdXzMajor)
 {
strIdXzMajor = strIdXzMajor.Replace("'", "''");
if (strIdXzMajor.Length > 8)
{
throw new Exception("在表:XzMajor中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdXzMajor)  ==  true)
{
throw new Exception("在表:XzMajor中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdXzMajor);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdXzMajor = strIdXzMajor;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdXzMajor");
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
if (strAttributeName  ==  conXzMajor.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  conXzMajor.MajorId)
{
return mstrMajorId;
}
else if (strAttributeName  ==  conXzMajor.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  conXzMajor.MajorEnglishName)
{
return mstrMajorEnglishName;
}
else if (strAttributeName  ==  conXzMajor.MajorExplain)
{
return mstrMajorExplain;
}
else if (strAttributeName  ==  conXzMajor.MajorNationalID)
{
return mstrMajorNationalID;
}
else if (strAttributeName  ==  conXzMajor.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  conXzMajor.IdMajorType)
{
return mstrIdMajorType;
}
else if (strAttributeName  ==  conXzMajor.IdDegreeType)
{
return mstrIdDegreeType;
}
else if (strAttributeName  ==  conXzMajor.IsMainMajor)
{
return mbolIsMainMajor;
}
else if (strAttributeName  ==  conXzMajor.MajorDirection)
{
return mstrMajorDirection;
}
else if (strAttributeName  ==  conXzMajor.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conXzMajor.IsNormal)
{
return mbolIsNormal;
}
else if (strAttributeName  ==  conXzMajor.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  conXzMajor.ModifyUserId)
{
return mstrModifyUserId;
}
else if (strAttributeName  ==  conXzMajor.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conXzMajor.IdXzMajorShoolType)
{
return mstrIdXzMajorShoolType;
}
return null;
}
set
{
if (strAttributeName  ==  conXzMajor.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(conXzMajor.IdXzMajor);
}
else if (strAttributeName  ==  conXzMajor.MajorId)
{
mstrMajorId = value.ToString();
 AddUpdatedFld(conXzMajor.MajorId);
}
else if (strAttributeName  ==  conXzMajor.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(conXzMajor.MajorName);
}
else if (strAttributeName  ==  conXzMajor.MajorEnglishName)
{
mstrMajorEnglishName = value.ToString();
 AddUpdatedFld(conXzMajor.MajorEnglishName);
}
else if (strAttributeName  ==  conXzMajor.MajorExplain)
{
mstrMajorExplain = value.ToString();
 AddUpdatedFld(conXzMajor.MajorExplain);
}
else if (strAttributeName  ==  conXzMajor.MajorNationalID)
{
mstrMajorNationalID = value.ToString();
 AddUpdatedFld(conXzMajor.MajorNationalID);
}
else if (strAttributeName  ==  conXzMajor.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conXzMajor.IdXzCollege);
}
else if (strAttributeName  ==  conXzMajor.IdMajorType)
{
mstrIdMajorType = value.ToString();
 AddUpdatedFld(conXzMajor.IdMajorType);
}
else if (strAttributeName  ==  conXzMajor.IdDegreeType)
{
mstrIdDegreeType = value.ToString();
 AddUpdatedFld(conXzMajor.IdDegreeType);
}
else if (strAttributeName  ==  conXzMajor.IsMainMajor)
{
mbolIsMainMajor = TransNullToBool(value.ToString());
 AddUpdatedFld(conXzMajor.IsMainMajor);
}
else if (strAttributeName  ==  conXzMajor.MajorDirection)
{
mstrMajorDirection = value.ToString();
 AddUpdatedFld(conXzMajor.MajorDirection);
}
else if (strAttributeName  ==  conXzMajor.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conXzMajor.IsVisible);
}
else if (strAttributeName  ==  conXzMajor.IsNormal)
{
mbolIsNormal = TransNullToBool(value.ToString());
 AddUpdatedFld(conXzMajor.IsNormal);
}
else if (strAttributeName  ==  conXzMajor.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conXzMajor.ModifyDate);
}
else if (strAttributeName  ==  conXzMajor.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conXzMajor.ModifyUserId);
}
else if (strAttributeName  ==  conXzMajor.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conXzMajor.Memo);
}
else if (strAttributeName  ==  conXzMajor.IdXzMajorShoolType)
{
mstrIdXzMajorShoolType = value.ToString();
 AddUpdatedFld(conXzMajor.IdXzMajorShoolType);
}
}
}
public object this[int intIndex]
{
get
{
if (conXzMajor.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (conXzMajor.MajorId  ==  AttributeName[intIndex])
{
return mstrMajorId;
}
else if (conXzMajor.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (conXzMajor.MajorEnglishName  ==  AttributeName[intIndex])
{
return mstrMajorEnglishName;
}
else if (conXzMajor.MajorExplain  ==  AttributeName[intIndex])
{
return mstrMajorExplain;
}
else if (conXzMajor.MajorNationalID  ==  AttributeName[intIndex])
{
return mstrMajorNationalID;
}
else if (conXzMajor.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (conXzMajor.IdMajorType  ==  AttributeName[intIndex])
{
return mstrIdMajorType;
}
else if (conXzMajor.IdDegreeType  ==  AttributeName[intIndex])
{
return mstrIdDegreeType;
}
else if (conXzMajor.IsMainMajor  ==  AttributeName[intIndex])
{
return mbolIsMainMajor;
}
else if (conXzMajor.MajorDirection  ==  AttributeName[intIndex])
{
return mstrMajorDirection;
}
else if (conXzMajor.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conXzMajor.IsNormal  ==  AttributeName[intIndex])
{
return mbolIsNormal;
}
else if (conXzMajor.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (conXzMajor.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
else if (conXzMajor.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conXzMajor.IdXzMajorShoolType  ==  AttributeName[intIndex])
{
return mstrIdXzMajorShoolType;
}
return null;
}
set
{
if (conXzMajor.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(conXzMajor.IdXzMajor);
}
else if (conXzMajor.MajorId  ==  AttributeName[intIndex])
{
mstrMajorId = value.ToString();
 AddUpdatedFld(conXzMajor.MajorId);
}
else if (conXzMajor.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(conXzMajor.MajorName);
}
else if (conXzMajor.MajorEnglishName  ==  AttributeName[intIndex])
{
mstrMajorEnglishName = value.ToString();
 AddUpdatedFld(conXzMajor.MajorEnglishName);
}
else if (conXzMajor.MajorExplain  ==  AttributeName[intIndex])
{
mstrMajorExplain = value.ToString();
 AddUpdatedFld(conXzMajor.MajorExplain);
}
else if (conXzMajor.MajorNationalID  ==  AttributeName[intIndex])
{
mstrMajorNationalID = value.ToString();
 AddUpdatedFld(conXzMajor.MajorNationalID);
}
else if (conXzMajor.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conXzMajor.IdXzCollege);
}
else if (conXzMajor.IdMajorType  ==  AttributeName[intIndex])
{
mstrIdMajorType = value.ToString();
 AddUpdatedFld(conXzMajor.IdMajorType);
}
else if (conXzMajor.IdDegreeType  ==  AttributeName[intIndex])
{
mstrIdDegreeType = value.ToString();
 AddUpdatedFld(conXzMajor.IdDegreeType);
}
else if (conXzMajor.IsMainMajor  ==  AttributeName[intIndex])
{
mbolIsMainMajor = TransNullToBool(value.ToString());
 AddUpdatedFld(conXzMajor.IsMainMajor);
}
else if (conXzMajor.MajorDirection  ==  AttributeName[intIndex])
{
mstrMajorDirection = value.ToString();
 AddUpdatedFld(conXzMajor.MajorDirection);
}
else if (conXzMajor.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conXzMajor.IsVisible);
}
else if (conXzMajor.IsNormal  ==  AttributeName[intIndex])
{
mbolIsNormal = TransNullToBool(value.ToString());
 AddUpdatedFld(conXzMajor.IsNormal);
}
else if (conXzMajor.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conXzMajor.ModifyDate);
}
else if (conXzMajor.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conXzMajor.ModifyUserId);
}
else if (conXzMajor.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conXzMajor.Memo);
}
else if (conXzMajor.IdXzMajorShoolType  ==  AttributeName[intIndex])
{
mstrIdXzMajorShoolType = value.ToString();
 AddUpdatedFld(conXzMajor.IdXzMajorShoolType);
}
}
}

/// <summary>
/// 专业流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzMajor
{
get
{
return mstrIdXzMajor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzMajor = value;
}
else
{
 mstrIdXzMajor = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzMajor.IdXzMajor);
}
}
/// <summary>
/// 专业Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorId
{
get
{
return mstrMajorId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorId = value;
}
else
{
 mstrMajorId = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzMajor.MajorId);
}
}
/// <summary>
/// 专业名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorName
{
get
{
return mstrMajorName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorName = value;
}
else
{
 mstrMajorName = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzMajor.MajorName);
}
}
/// <summary>
/// 专业英文名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorEnglishName
{
get
{
return mstrMajorEnglishName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorEnglishName = value;
}
else
{
 mstrMajorEnglishName = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzMajor.MajorEnglishName);
}
}
/// <summary>
/// 专业说明(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorExplain
{
get
{
return mstrMajorExplain;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorExplain = value;
}
else
{
 mstrMajorExplain = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzMajor.MajorExplain);
}
}
/// <summary>
/// 专业国家代码(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorNationalID
{
get
{
return mstrMajorNationalID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorNationalID = value;
}
else
{
 mstrMajorNationalID = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzMajor.MajorNationalID);
}
}
/// <summary>
/// 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzCollege
{
get
{
return mstrIdXzCollege;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzCollege = value;
}
else
{
 mstrIdXzCollege = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzMajor.IdXzCollege);
}
}
/// <summary>
/// 专业类型(文理工)流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdMajorType
{
get
{
return mstrIdMajorType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdMajorType = value;
}
else
{
 mstrIdMajorType = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzMajor.IdMajorType);
}
}
/// <summary>
/// 学位类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdDegreeType
{
get
{
return mstrIdDegreeType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdDegreeType = value;
}
else
{
 mstrIdDegreeType = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzMajor.IdDegreeType);
}
}
/// <summary>
/// 是否重要专业(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsMainMajor
{
get
{
return mbolIsMainMajor;
}
set
{
 mbolIsMainMajor = value;
//记录修改过的字段
 AddUpdatedFld(conXzMajor.IsMainMajor);
}
}
/// <summary>
/// 专业方向(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorDirection
{
get
{
return mstrMajorDirection;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorDirection = value;
}
else
{
 mstrMajorDirection = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzMajor.MajorDirection);
}
}
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsVisible
{
get
{
return mbolIsVisible;
}
set
{
 mbolIsVisible = value;
//记录修改过的字段
 AddUpdatedFld(conXzMajor.IsVisible);
}
}
/// <summary>
/// IsNormal(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsNormal
{
get
{
return mbolIsNormal;
}
set
{
 mbolIsNormal = value;
//记录修改过的字段
 AddUpdatedFld(conXzMajor.IsNormal);
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
 AddUpdatedFld(conXzMajor.ModifyDate);
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
 AddUpdatedFld(conXzMajor.ModifyUserId);
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
 AddUpdatedFld(conXzMajor.Memo);
}
}
/// <summary>
/// 专业学校类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzMajorShoolType
{
get
{
return mstrIdXzMajorShoolType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzMajorShoolType = value;
}
else
{
 mstrIdXzMajorShoolType = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzMajor.IdXzMajorShoolType);
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
  return mstrIdXzMajor;
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
  return mstrMajorName;
 }
 }
}
 /// <summary>
 /// 专业(XzMajor)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conXzMajor
{
public const string _CurrTabName = "XzMajor"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdXzMajor"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdXzMajor", "MajorId", "MajorName", "MajorEnglishName", "MajorExplain", "MajorNationalID", "IdXzCollege", "IdMajorType", "IdDegreeType", "IsMainMajor", "MajorDirection", "IsVisible", "IsNormal", "ModifyDate", "ModifyUserId", "Memo", "IdXzMajorShoolType"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

 /// <summary>
 /// 常量:"MajorId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorId = "MajorId";    //专业Id

 /// <summary>
 /// 常量:"MajorName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorName = "MajorName";    //专业名称

 /// <summary>
 /// 常量:"MajorEnglishName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorEnglishName = "MajorEnglishName";    //专业英文名称

 /// <summary>
 /// 常量:"MajorExplain"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorExplain = "MajorExplain";    //专业说明

 /// <summary>
 /// 常量:"MajorNationalID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorNationalID = "MajorNationalID";    //专业国家代码

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"IdMajorType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdMajorType = "IdMajorType";    //专业类型(文理工)流水号

 /// <summary>
 /// 常量:"IdDegreeType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdDegreeType = "IdDegreeType";    //学位类型流水号

 /// <summary>
 /// 常量:"IsMainMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsMainMajor = "IsMainMajor";    //是否重要专业

 /// <summary>
 /// 常量:"MajorDirection"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorDirection = "MajorDirection";    //专业方向

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"IsNormal"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsNormal = "IsNormal";    //IsNormal

 /// <summary>
 /// 常量:"ModifyDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyDate = "ModifyDate";    //修改日期

 /// <summary>
 /// 常量:"ModifyUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyUserId = "ModifyUserId";    //修改人

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"IdXzMajorShoolType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajorShoolType = "IdXzMajorShoolType";    //专业学校类型流水号
}

}