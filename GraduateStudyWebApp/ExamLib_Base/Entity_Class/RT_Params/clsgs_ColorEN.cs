
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_ColorEN
 表名:gs_Color(01120751)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:14:29
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培参数(RT_Params)
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
 /// 表gs_Color的关键字(ColorId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ColorId_gs_Color
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strColorId">表关键字</param>
public K_ColorId_gs_Color(string strColorId)
{
if (IsValid(strColorId)) Value = strColorId;
else
{
Value = null;
}
}
private static bool IsValid(string strColorId)
{
if (string.IsNullOrEmpty(strColorId) == true) return false;
if (strColorId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ColorId_gs_Color]类型的对象</returns>
public static implicit operator K_ColorId_gs_Color(string value)
{
return new K_ColorId_gs_Color(value);
}
}
 /// <summary>
 /// 颜色表(gs_Color)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_ColorEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_Color"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ColorId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"ColorId", "UserNo", "ColorCode"};

protected string mstrColorId;    //颜色Id
protected int? mintUserNo;    //用户号
protected string mstrColorCode;    //颜色码

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_ColorEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ColorId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strColorId">关键字:颜色Id</param>
public clsgs_ColorEN(string strColorId)
 {
strColorId = strColorId.Replace("'", "''");
if (strColorId.Length > 2)
{
throw new Exception("在表:gs_Color中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strColorId)  ==  true)
{
throw new Exception("在表:gs_Color中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strColorId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrColorId = strColorId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ColorId");
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
if (strAttributeName  ==  congs_Color.ColorId)
{
return mstrColorId;
}
else if (strAttributeName  ==  congs_Color.UserNo)
{
return mintUserNo;
}
else if (strAttributeName  ==  congs_Color.ColorCode)
{
return mstrColorCode;
}
return null;
}
set
{
if (strAttributeName  ==  congs_Color.ColorId)
{
mstrColorId = value.ToString();
 AddUpdatedFld(congs_Color.ColorId);
}
else if (strAttributeName  ==  congs_Color.UserNo)
{
mintUserNo = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_Color.UserNo);
}
else if (strAttributeName  ==  congs_Color.ColorCode)
{
mstrColorCode = value.ToString();
 AddUpdatedFld(congs_Color.ColorCode);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_Color.ColorId  ==  AttributeName[intIndex])
{
return mstrColorId;
}
else if (congs_Color.UserNo  ==  AttributeName[intIndex])
{
return mintUserNo;
}
else if (congs_Color.ColorCode  ==  AttributeName[intIndex])
{
return mstrColorCode;
}
return null;
}
set
{
if (congs_Color.ColorId  ==  AttributeName[intIndex])
{
mstrColorId = value.ToString();
 AddUpdatedFld(congs_Color.ColorId);
}
else if (congs_Color.UserNo  ==  AttributeName[intIndex])
{
mintUserNo = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_Color.UserNo);
}
else if (congs_Color.ColorCode  ==  AttributeName[intIndex])
{
mstrColorCode = value.ToString();
 AddUpdatedFld(congs_Color.ColorCode);
}
}
}

/// <summary>
/// 颜色Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ColorId
{
get
{
return mstrColorId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrColorId = value;
}
else
{
 mstrColorId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_Color.ColorId);
}
}
/// <summary>
/// 用户号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? UserNo
{
get
{
return mintUserNo;
}
set
{
 mintUserNo = value;
//记录修改过的字段
 AddUpdatedFld(congs_Color.UserNo);
}
}
/// <summary>
/// 颜色码(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ColorCode
{
get
{
return mstrColorCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrColorCode = value;
}
else
{
 mstrColorCode = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_Color.ColorCode);
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
  return mstrColorId;
 }
 }
}
 /// <summary>
 /// 颜色表(gs_Color)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_Color
{
public const string _CurrTabName = "gs_Color"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ColorId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ColorId", "UserNo", "ColorCode"};
//以下是属性变量


 /// <summary>
 /// 常量:"ColorId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ColorId = "ColorId";    //颜色Id

 /// <summary>
 /// 常量:"UserNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserNo = "UserNo";    //用户号

 /// <summary>
 /// 常量:"ColorCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ColorCode = "ColorCode";    //颜色码
}

}