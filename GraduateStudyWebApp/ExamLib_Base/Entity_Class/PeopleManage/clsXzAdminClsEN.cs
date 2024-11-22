
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzAdminClsEN
 表名:XzAdminCls(01120194)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:59:09
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:人员管理(PeopleManage)
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
 /// 表XzAdminCls的关键字(IdAdminCls)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdAdminCls_XzAdminCls
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdAdminCls">表关键字</param>
public K_IdAdminCls_XzAdminCls(string strIdAdminCls)
{
if (IsValid(strIdAdminCls)) Value = strIdAdminCls;
else
{
Value = null;
}
}
private static bool IsValid(string strIdAdminCls)
{
if (string.IsNullOrEmpty(strIdAdminCls) == true) return false;
if (strIdAdminCls.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdAdminCls_XzAdminCls]类型的对象</returns>
public static implicit operator K_IdAdminCls_XzAdminCls(string value)
{
return new K_IdAdminCls_XzAdminCls(value);
}
}
 /// <summary>
 /// 行政班(XzAdminCls)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsXzAdminClsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "XzAdminCls"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdAdminCls"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"IdAdminCls", "AdminClsName", "IdXzMajor", "IdXzCollege", "IdUniZone", "CurrentStuQty", "IdGradeBase", "AdminClsId", "IdAdminClsType", "AdminClsIndex", "Memo", "ModifyUserId", "ModifyDate"};

protected string mstrIdAdminCls;    //行政班流水号
protected string mstrAdminClsName;    //行政班名称
protected string mstrIdXzMajor;    //专业流水号
protected string mstrIdXzCollege;    //学院流水号
protected string mstrIdUniZone;    //校区流水号
protected int? mintCurrentStuQty;    //当前学生数
protected string mstrIdGradeBase;    //年级流水号
protected string mstrAdminClsId;    //行政班代号
protected string mstrIdAdminClsType;    //行政班级类型流水号
protected int? mintAdminClsIndex;    //AdminClsIndex
protected string mstrMemo;    //备注
protected string mstrModifyUserId;    //修改人
protected string mstrModifyDate;    //修改日期

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsXzAdminClsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdAdminCls");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdAdminCls">关键字:行政班流水号</param>
public clsXzAdminClsEN(string strIdAdminCls)
 {
strIdAdminCls = strIdAdminCls.Replace("'", "''");
if (strIdAdminCls.Length > 8)
{
throw new Exception("在表:XzAdminCls中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdAdminCls)  ==  true)
{
throw new Exception("在表:XzAdminCls中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdAdminCls);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdAdminCls = strIdAdminCls;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdAdminCls");
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
if (strAttributeName  ==  conXzAdminCls.IdAdminCls)
{
return mstrIdAdminCls;
}
else if (strAttributeName  ==  conXzAdminCls.AdminClsName)
{
return mstrAdminClsName;
}
else if (strAttributeName  ==  conXzAdminCls.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  conXzAdminCls.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  conXzAdminCls.IdUniZone)
{
return mstrIdUniZone;
}
else if (strAttributeName  ==  conXzAdminCls.CurrentStuQty)
{
return mintCurrentStuQty;
}
else if (strAttributeName  ==  conXzAdminCls.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  conXzAdminCls.AdminClsId)
{
return mstrAdminClsId;
}
else if (strAttributeName  ==  conXzAdminCls.IdAdminClsType)
{
return mstrIdAdminClsType;
}
else if (strAttributeName  ==  conXzAdminCls.AdminClsIndex)
{
return mintAdminClsIndex;
}
else if (strAttributeName  ==  conXzAdminCls.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conXzAdminCls.ModifyUserId)
{
return mstrModifyUserId;
}
else if (strAttributeName  ==  conXzAdminCls.ModifyDate)
{
return mstrModifyDate;
}
return null;
}
set
{
if (strAttributeName  ==  conXzAdminCls.IdAdminCls)
{
mstrIdAdminCls = value.ToString();
 AddUpdatedFld(conXzAdminCls.IdAdminCls);
}
else if (strAttributeName  ==  conXzAdminCls.AdminClsName)
{
mstrAdminClsName = value.ToString();
 AddUpdatedFld(conXzAdminCls.AdminClsName);
}
else if (strAttributeName  ==  conXzAdminCls.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(conXzAdminCls.IdXzMajor);
}
else if (strAttributeName  ==  conXzAdminCls.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conXzAdminCls.IdXzCollege);
}
else if (strAttributeName  ==  conXzAdminCls.IdUniZone)
{
mstrIdUniZone = value.ToString();
 AddUpdatedFld(conXzAdminCls.IdUniZone);
}
else if (strAttributeName  ==  conXzAdminCls.CurrentStuQty)
{
mintCurrentStuQty = TransNullToInt(value.ToString());
 AddUpdatedFld(conXzAdminCls.CurrentStuQty);
}
else if (strAttributeName  ==  conXzAdminCls.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(conXzAdminCls.IdGradeBase);
}
else if (strAttributeName  ==  conXzAdminCls.AdminClsId)
{
mstrAdminClsId = value.ToString();
 AddUpdatedFld(conXzAdminCls.AdminClsId);
}
else if (strAttributeName  ==  conXzAdminCls.IdAdminClsType)
{
mstrIdAdminClsType = value.ToString();
 AddUpdatedFld(conXzAdminCls.IdAdminClsType);
}
else if (strAttributeName  ==  conXzAdminCls.AdminClsIndex)
{
mintAdminClsIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(conXzAdminCls.AdminClsIndex);
}
else if (strAttributeName  ==  conXzAdminCls.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conXzAdminCls.Memo);
}
else if (strAttributeName  ==  conXzAdminCls.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conXzAdminCls.ModifyUserId);
}
else if (strAttributeName  ==  conXzAdminCls.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conXzAdminCls.ModifyDate);
}
}
}
public object this[int intIndex]
{
get
{
if (conXzAdminCls.IdAdminCls  ==  AttributeName[intIndex])
{
return mstrIdAdminCls;
}
else if (conXzAdminCls.AdminClsName  ==  AttributeName[intIndex])
{
return mstrAdminClsName;
}
else if (conXzAdminCls.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (conXzAdminCls.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (conXzAdminCls.IdUniZone  ==  AttributeName[intIndex])
{
return mstrIdUniZone;
}
else if (conXzAdminCls.CurrentStuQty  ==  AttributeName[intIndex])
{
return mintCurrentStuQty;
}
else if (conXzAdminCls.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (conXzAdminCls.AdminClsId  ==  AttributeName[intIndex])
{
return mstrAdminClsId;
}
else if (conXzAdminCls.IdAdminClsType  ==  AttributeName[intIndex])
{
return mstrIdAdminClsType;
}
else if (conXzAdminCls.AdminClsIndex  ==  AttributeName[intIndex])
{
return mintAdminClsIndex;
}
else if (conXzAdminCls.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conXzAdminCls.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
else if (conXzAdminCls.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
return null;
}
set
{
if (conXzAdminCls.IdAdminCls  ==  AttributeName[intIndex])
{
mstrIdAdminCls = value.ToString();
 AddUpdatedFld(conXzAdminCls.IdAdminCls);
}
else if (conXzAdminCls.AdminClsName  ==  AttributeName[intIndex])
{
mstrAdminClsName = value.ToString();
 AddUpdatedFld(conXzAdminCls.AdminClsName);
}
else if (conXzAdminCls.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(conXzAdminCls.IdXzMajor);
}
else if (conXzAdminCls.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conXzAdminCls.IdXzCollege);
}
else if (conXzAdminCls.IdUniZone  ==  AttributeName[intIndex])
{
mstrIdUniZone = value.ToString();
 AddUpdatedFld(conXzAdminCls.IdUniZone);
}
else if (conXzAdminCls.CurrentStuQty  ==  AttributeName[intIndex])
{
mintCurrentStuQty = TransNullToInt(value.ToString());
 AddUpdatedFld(conXzAdminCls.CurrentStuQty);
}
else if (conXzAdminCls.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(conXzAdminCls.IdGradeBase);
}
else if (conXzAdminCls.AdminClsId  ==  AttributeName[intIndex])
{
mstrAdminClsId = value.ToString();
 AddUpdatedFld(conXzAdminCls.AdminClsId);
}
else if (conXzAdminCls.IdAdminClsType  ==  AttributeName[intIndex])
{
mstrIdAdminClsType = value.ToString();
 AddUpdatedFld(conXzAdminCls.IdAdminClsType);
}
else if (conXzAdminCls.AdminClsIndex  ==  AttributeName[intIndex])
{
mintAdminClsIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(conXzAdminCls.AdminClsIndex);
}
else if (conXzAdminCls.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conXzAdminCls.Memo);
}
else if (conXzAdminCls.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conXzAdminCls.ModifyUserId);
}
else if (conXzAdminCls.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conXzAdminCls.ModifyDate);
}
}
}

/// <summary>
/// 行政班流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdAdminCls
{
get
{
return mstrIdAdminCls;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdAdminCls = value;
}
else
{
 mstrIdAdminCls = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzAdminCls.IdAdminCls);
}
}
/// <summary>
/// 行政班名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AdminClsName
{
get
{
return mstrAdminClsName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAdminClsName = value;
}
else
{
 mstrAdminClsName = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzAdminCls.AdminClsName);
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
 AddUpdatedFld(conXzAdminCls.IdXzMajor);
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
 AddUpdatedFld(conXzAdminCls.IdXzCollege);
}
}
/// <summary>
/// 校区流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdUniZone
{
get
{
return mstrIdUniZone;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdUniZone = value;
}
else
{
 mstrIdUniZone = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzAdminCls.IdUniZone);
}
}
/// <summary>
/// 当前学生数(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? CurrentStuQty
{
get
{
return mintCurrentStuQty;
}
set
{
 mintCurrentStuQty = value;
//记录修改过的字段
 AddUpdatedFld(conXzAdminCls.CurrentStuQty);
}
}
/// <summary>
/// 年级流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdGradeBase
{
get
{
return mstrIdGradeBase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdGradeBase = value;
}
else
{
 mstrIdGradeBase = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzAdminCls.IdGradeBase);
}
}
/// <summary>
/// 行政班代号(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AdminClsId
{
get
{
return mstrAdminClsId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAdminClsId = value;
}
else
{
 mstrAdminClsId = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzAdminCls.AdminClsId);
}
}
/// <summary>
/// 行政班级类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdAdminClsType
{
get
{
return mstrIdAdminClsType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdAdminClsType = value;
}
else
{
 mstrIdAdminClsType = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzAdminCls.IdAdminClsType);
}
}
/// <summary>
/// AdminClsIndex(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? AdminClsIndex
{
get
{
return mintAdminClsIndex;
}
set
{
 mintAdminClsIndex = value;
//记录修改过的字段
 AddUpdatedFld(conXzAdminCls.AdminClsIndex);
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
 AddUpdatedFld(conXzAdminCls.Memo);
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
 AddUpdatedFld(conXzAdminCls.ModifyUserId);
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
 AddUpdatedFld(conXzAdminCls.ModifyDate);
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
  return mstrIdAdminCls;
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
  return mstrAdminClsName;
 }
 }
}
 /// <summary>
 /// 行政班(XzAdminCls)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conXzAdminCls
{
public const string _CurrTabName = "XzAdminCls"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdAdminCls"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdAdminCls", "AdminClsName", "IdXzMajor", "IdXzCollege", "IdUniZone", "CurrentStuQty", "IdGradeBase", "AdminClsId", "IdAdminClsType", "AdminClsIndex", "Memo", "ModifyUserId", "ModifyDate"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdAdminCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdAdminCls = "IdAdminCls";    //行政班流水号

 /// <summary>
 /// 常量:"AdminClsName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AdminClsName = "AdminClsName";    //行政班名称

 /// <summary>
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"IdUniZone"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdUniZone = "IdUniZone";    //校区流水号

 /// <summary>
 /// 常量:"CurrentStuQty"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CurrentStuQty = "CurrentStuQty";    //当前学生数

 /// <summary>
 /// 常量:"IdGradeBase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdGradeBase = "IdGradeBase";    //年级流水号

 /// <summary>
 /// 常量:"AdminClsId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AdminClsId = "AdminClsId";    //行政班代号

 /// <summary>
 /// 常量:"IdAdminClsType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdAdminClsType = "IdAdminClsType";    //行政班级类型流水号

 /// <summary>
 /// 常量:"AdminClsIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AdminClsIndex = "AdminClsIndex";    //AdminClsIndex

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

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
}

}