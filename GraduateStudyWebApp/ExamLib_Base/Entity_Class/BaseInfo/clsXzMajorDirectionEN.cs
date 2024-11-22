
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzMajorDirectionEN
 表名:XzMajorDirection(01120552)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:06:08
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
 /// 表XzMajorDirection的关键字(MajorDirectionId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_MajorDirectionId_XzMajorDirection
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strMajorDirectionId">表关键字</param>
public K_MajorDirectionId_XzMajorDirection(string strMajorDirectionId)
{
if (IsValid(strMajorDirectionId)) Value = strMajorDirectionId;
else
{
Value = null;
}
}
private static bool IsValid(string strMajorDirectionId)
{
if (string.IsNullOrEmpty(strMajorDirectionId) == true) return false;
if (strMajorDirectionId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_MajorDirectionId_XzMajorDirection]类型的对象</returns>
public static implicit operator K_MajorDirectionId_XzMajorDirection(string value)
{
return new K_MajorDirectionId_XzMajorDirection(value);
}
}
 /// <summary>
 /// 专业方向(XzMajorDirection)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsXzMajorDirectionEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "XzMajorDirection"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "MajorDirectionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"MajorDirectionId", "IdXzMajor", "MajorDirectionName", "MajorDirectionENName", "MajorDirectionExplain", "IsVisible", "UpdDate", "UpdUser", "Memo"};

protected string mstrMajorDirectionId;    //研究方向Id
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorDirectionName;    //研究方向名
protected string mstrMajorDirectionENName;    //研究方向英文名
protected string mstrMajorDirectionExplain;    //专业方向说明
protected bool mbolIsVisible;    //是否显示
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsXzMajorDirectionEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MajorDirectionId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strMajorDirectionId">关键字:研究方向Id</param>
public clsXzMajorDirectionEN(string strMajorDirectionId)
 {
strMajorDirectionId = strMajorDirectionId.Replace("'", "''");
if (strMajorDirectionId.Length > 8)
{
throw new Exception("在表:XzMajorDirection中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strMajorDirectionId)  ==  true)
{
throw new Exception("在表:XzMajorDirection中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strMajorDirectionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrMajorDirectionId = strMajorDirectionId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MajorDirectionId");
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
if (strAttributeName  ==  conXzMajorDirection.MajorDirectionId)
{
return mstrMajorDirectionId;
}
else if (strAttributeName  ==  conXzMajorDirection.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  conXzMajorDirection.MajorDirectionName)
{
return mstrMajorDirectionName;
}
else if (strAttributeName  ==  conXzMajorDirection.MajorDirectionENName)
{
return mstrMajorDirectionENName;
}
else if (strAttributeName  ==  conXzMajorDirection.MajorDirectionExplain)
{
return mstrMajorDirectionExplain;
}
else if (strAttributeName  ==  conXzMajorDirection.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conXzMajorDirection.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conXzMajorDirection.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conXzMajorDirection.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conXzMajorDirection.MajorDirectionId)
{
mstrMajorDirectionId = value.ToString();
 AddUpdatedFld(conXzMajorDirection.MajorDirectionId);
}
else if (strAttributeName  ==  conXzMajorDirection.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(conXzMajorDirection.IdXzMajor);
}
else if (strAttributeName  ==  conXzMajorDirection.MajorDirectionName)
{
mstrMajorDirectionName = value.ToString();
 AddUpdatedFld(conXzMajorDirection.MajorDirectionName);
}
else if (strAttributeName  ==  conXzMajorDirection.MajorDirectionENName)
{
mstrMajorDirectionENName = value.ToString();
 AddUpdatedFld(conXzMajorDirection.MajorDirectionENName);
}
else if (strAttributeName  ==  conXzMajorDirection.MajorDirectionExplain)
{
mstrMajorDirectionExplain = value.ToString();
 AddUpdatedFld(conXzMajorDirection.MajorDirectionExplain);
}
else if (strAttributeName  ==  conXzMajorDirection.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conXzMajorDirection.IsVisible);
}
else if (strAttributeName  ==  conXzMajorDirection.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conXzMajorDirection.UpdDate);
}
else if (strAttributeName  ==  conXzMajorDirection.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conXzMajorDirection.UpdUser);
}
else if (strAttributeName  ==  conXzMajorDirection.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conXzMajorDirection.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conXzMajorDirection.MajorDirectionId  ==  AttributeName[intIndex])
{
return mstrMajorDirectionId;
}
else if (conXzMajorDirection.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (conXzMajorDirection.MajorDirectionName  ==  AttributeName[intIndex])
{
return mstrMajorDirectionName;
}
else if (conXzMajorDirection.MajorDirectionENName  ==  AttributeName[intIndex])
{
return mstrMajorDirectionENName;
}
else if (conXzMajorDirection.MajorDirectionExplain  ==  AttributeName[intIndex])
{
return mstrMajorDirectionExplain;
}
else if (conXzMajorDirection.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conXzMajorDirection.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conXzMajorDirection.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conXzMajorDirection.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conXzMajorDirection.MajorDirectionId  ==  AttributeName[intIndex])
{
mstrMajorDirectionId = value.ToString();
 AddUpdatedFld(conXzMajorDirection.MajorDirectionId);
}
else if (conXzMajorDirection.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(conXzMajorDirection.IdXzMajor);
}
else if (conXzMajorDirection.MajorDirectionName  ==  AttributeName[intIndex])
{
mstrMajorDirectionName = value.ToString();
 AddUpdatedFld(conXzMajorDirection.MajorDirectionName);
}
else if (conXzMajorDirection.MajorDirectionENName  ==  AttributeName[intIndex])
{
mstrMajorDirectionENName = value.ToString();
 AddUpdatedFld(conXzMajorDirection.MajorDirectionENName);
}
else if (conXzMajorDirection.MajorDirectionExplain  ==  AttributeName[intIndex])
{
mstrMajorDirectionExplain = value.ToString();
 AddUpdatedFld(conXzMajorDirection.MajorDirectionExplain);
}
else if (conXzMajorDirection.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conXzMajorDirection.IsVisible);
}
else if (conXzMajorDirection.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conXzMajorDirection.UpdDate);
}
else if (conXzMajorDirection.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conXzMajorDirection.UpdUser);
}
else if (conXzMajorDirection.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conXzMajorDirection.Memo);
}
}
}

/// <summary>
/// 研究方向Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorDirectionId
{
get
{
return mstrMajorDirectionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorDirectionId = value;
}
else
{
 mstrMajorDirectionId = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzMajorDirection.MajorDirectionId);
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
 AddUpdatedFld(conXzMajorDirection.IdXzMajor);
}
}
/// <summary>
/// 研究方向名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorDirectionName
{
get
{
return mstrMajorDirectionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorDirectionName = value;
}
else
{
 mstrMajorDirectionName = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzMajorDirection.MajorDirectionName);
}
}
/// <summary>
/// 研究方向英文名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorDirectionENName
{
get
{
return mstrMajorDirectionENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorDirectionENName = value;
}
else
{
 mstrMajorDirectionENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzMajorDirection.MajorDirectionENName);
}
}
/// <summary>
/// 专业方向说明(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorDirectionExplain
{
get
{
return mstrMajorDirectionExplain;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorDirectionExplain = value;
}
else
{
 mstrMajorDirectionExplain = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzMajorDirection.MajorDirectionExplain);
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
 AddUpdatedFld(conXzMajorDirection.IsVisible);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdDate
{
get
{
return mstrUpdDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdDate = value;
}
else
{
 mstrUpdDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzMajorDirection.UpdDate);
}
}
/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUser
{
get
{
return mstrUpdUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUser = value;
}
else
{
 mstrUpdUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzMajorDirection.UpdUser);
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
 AddUpdatedFld(conXzMajorDirection.Memo);
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
  return mstrMajorDirectionId;
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
  return mstrMajorDirectionName;
 }
 }
}
 /// <summary>
 /// 专业方向(XzMajorDirection)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conXzMajorDirection
{
public const string _CurrTabName = "XzMajorDirection"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "MajorDirectionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"MajorDirectionId", "IdXzMajor", "MajorDirectionName", "MajorDirectionENName", "MajorDirectionExplain", "IsVisible", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"MajorDirectionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorDirectionId = "MajorDirectionId";    //研究方向Id

 /// <summary>
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

 /// <summary>
 /// 常量:"MajorDirectionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorDirectionName = "MajorDirectionName";    //研究方向名

 /// <summary>
 /// 常量:"MajorDirectionENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorDirectionENName = "MajorDirectionENName";    //研究方向英文名

 /// <summary>
 /// 常量:"MajorDirectionExplain"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorDirectionExplain = "MajorDirectionExplain";    //专业方向说明

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}