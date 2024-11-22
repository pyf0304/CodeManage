
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ColorEN
 表名:zx_Color(01120758)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:00:07
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生参数(ZxParameter)
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
 /// 表zx_Color的关键字(zxColorId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxColorId_zx_Color
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxColorId">表关键字</param>
public K_zxColorId_zx_Color(string strzxColorId)
{
if (IsValid(strzxColorId)) Value = strzxColorId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxColorId)
{
if (string.IsNullOrEmpty(strzxColorId) == true) return false;
if (strzxColorId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxColorId_zx_Color]类型的对象</returns>
public static implicit operator K_zxColorId_zx_Color(string value)
{
return new K_zxColorId_zx_Color(value);
}
}
 /// <summary>
 /// 颜色表(zx_Color)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_ColorEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_Color"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxColorId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"zxColorId", "UserNo", "ColorCode"};

protected string mstrzxColorId;    //颜色Id
protected int? mintUserNo;    //用户号
protected string mstrColorCode;    //颜色码

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_ColorEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxColorId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxColorId">关键字:颜色Id</param>
public clszx_ColorEN(string strzxColorId)
 {
strzxColorId = strzxColorId.Replace("'", "''");
if (strzxColorId.Length > 2)
{
throw new Exception("在表:zx_Color中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxColorId)  ==  true)
{
throw new Exception("在表:zx_Color中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxColorId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxColorId = strzxColorId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxColorId");
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
if (strAttributeName  ==  conzx_Color.zxColorId)
{
return mstrzxColorId;
}
else if (strAttributeName  ==  conzx_Color.UserNo)
{
return mintUserNo;
}
else if (strAttributeName  ==  conzx_Color.ColorCode)
{
return mstrColorCode;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_Color.zxColorId)
{
mstrzxColorId = value.ToString();
 AddUpdatedFld(conzx_Color.zxColorId);
}
else if (strAttributeName  ==  conzx_Color.UserNo)
{
mintUserNo = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Color.UserNo);
}
else if (strAttributeName  ==  conzx_Color.ColorCode)
{
mstrColorCode = value.ToString();
 AddUpdatedFld(conzx_Color.ColorCode);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_Color.zxColorId  ==  AttributeName[intIndex])
{
return mstrzxColorId;
}
else if (conzx_Color.UserNo  ==  AttributeName[intIndex])
{
return mintUserNo;
}
else if (conzx_Color.ColorCode  ==  AttributeName[intIndex])
{
return mstrColorCode;
}
return null;
}
set
{
if (conzx_Color.zxColorId  ==  AttributeName[intIndex])
{
mstrzxColorId = value.ToString();
 AddUpdatedFld(conzx_Color.zxColorId);
}
else if (conzx_Color.UserNo  ==  AttributeName[intIndex])
{
mintUserNo = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_Color.UserNo);
}
else if (conzx_Color.ColorCode  ==  AttributeName[intIndex])
{
mstrColorCode = value.ToString();
 AddUpdatedFld(conzx_Color.ColorCode);
}
}
}

/// <summary>
/// 颜色Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxColorId
{
get
{
return mstrzxColorId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxColorId = value;
}
else
{
 mstrzxColorId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_Color.zxColorId);
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
 AddUpdatedFld(conzx_Color.UserNo);
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
 AddUpdatedFld(conzx_Color.ColorCode);
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
  return mstrzxColorId;
 }
 }
}
 /// <summary>
 /// 颜色表(zx_Color)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_Color
{
public const string _CurrTabName = "zx_Color"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxColorId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxColorId", "UserNo", "ColorCode"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxColorId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxColorId = "zxColorId";    //颜色Id

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