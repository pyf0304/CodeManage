
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_LiteratureTypeEN
 表名:zx_LiteratureType(01120763)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:57:01
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
 /// 表zx_LiteratureType的关键字(zxLiteratureTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxLiteratureTypeId_zx_LiteratureType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxLiteratureTypeId">表关键字</param>
public K_zxLiteratureTypeId_zx_LiteratureType(string strzxLiteratureTypeId)
{
if (IsValid(strzxLiteratureTypeId)) Value = strzxLiteratureTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxLiteratureTypeId)
{
if (string.IsNullOrEmpty(strzxLiteratureTypeId) == true) return false;
if (strzxLiteratureTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxLiteratureTypeId_zx_LiteratureType]类型的对象</returns>
public static implicit operator K_zxLiteratureTypeId_zx_LiteratureType(string value)
{
return new K_zxLiteratureTypeId_zx_LiteratureType(value);
}
}
 /// <summary>
 /// 作文类型(zx_LiteratureType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_LiteratureTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_LiteratureType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxLiteratureTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"zxLiteratureTypeId", "LiteratureTypeName", "UpdUserId", "UpdDate"};

protected string mstrzxLiteratureTypeId;    //作文类型Id
protected string mstrLiteratureTypeName;    //作文类型名
protected string mstrUpdUserId;    //修改用户Id
protected string mstrUpdDate;    //修改日期

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_LiteratureTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxLiteratureTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxLiteratureTypeId">关键字:作文类型Id</param>
public clszx_LiteratureTypeEN(string strzxLiteratureTypeId)
 {
strzxLiteratureTypeId = strzxLiteratureTypeId.Replace("'", "''");
if (strzxLiteratureTypeId.Length > 2)
{
throw new Exception("在表:zx_LiteratureType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxLiteratureTypeId)  ==  true)
{
throw new Exception("在表:zx_LiteratureType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxLiteratureTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxLiteratureTypeId = strzxLiteratureTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxLiteratureTypeId");
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
if (strAttributeName  ==  conzx_LiteratureType.zxLiteratureTypeId)
{
return mstrzxLiteratureTypeId;
}
else if (strAttributeName  ==  conzx_LiteratureType.LiteratureTypeName)
{
return mstrLiteratureTypeName;
}
else if (strAttributeName  ==  conzx_LiteratureType.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conzx_LiteratureType.UpdDate)
{
return mstrUpdDate;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_LiteratureType.zxLiteratureTypeId)
{
mstrzxLiteratureTypeId = value.ToString();
 AddUpdatedFld(conzx_LiteratureType.zxLiteratureTypeId);
}
else if (strAttributeName  ==  conzx_LiteratureType.LiteratureTypeName)
{
mstrLiteratureTypeName = value.ToString();
 AddUpdatedFld(conzx_LiteratureType.LiteratureTypeName);
}
else if (strAttributeName  ==  conzx_LiteratureType.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conzx_LiteratureType.UpdUserId);
}
else if (strAttributeName  ==  conzx_LiteratureType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_LiteratureType.UpdDate);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_LiteratureType.zxLiteratureTypeId  ==  AttributeName[intIndex])
{
return mstrzxLiteratureTypeId;
}
else if (conzx_LiteratureType.LiteratureTypeName  ==  AttributeName[intIndex])
{
return mstrLiteratureTypeName;
}
else if (conzx_LiteratureType.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conzx_LiteratureType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
return null;
}
set
{
if (conzx_LiteratureType.zxLiteratureTypeId  ==  AttributeName[intIndex])
{
mstrzxLiteratureTypeId = value.ToString();
 AddUpdatedFld(conzx_LiteratureType.zxLiteratureTypeId);
}
else if (conzx_LiteratureType.LiteratureTypeName  ==  AttributeName[intIndex])
{
mstrLiteratureTypeName = value.ToString();
 AddUpdatedFld(conzx_LiteratureType.LiteratureTypeName);
}
else if (conzx_LiteratureType.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conzx_LiteratureType.UpdUserId);
}
else if (conzx_LiteratureType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_LiteratureType.UpdDate);
}
}
}

/// <summary>
/// 作文类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxLiteratureTypeId
{
get
{
return mstrzxLiteratureTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxLiteratureTypeId = value;
}
else
{
 mstrzxLiteratureTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_LiteratureType.zxLiteratureTypeId);
}
}
/// <summary>
/// 作文类型名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LiteratureTypeName
{
get
{
return mstrLiteratureTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLiteratureTypeName = value;
}
else
{
 mstrLiteratureTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_LiteratureType.LiteratureTypeName);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_LiteratureType.UpdUserId);
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
 AddUpdatedFld(conzx_LiteratureType.UpdDate);
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
  return mstrzxLiteratureTypeId;
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
  return mstrLiteratureTypeName;
 }
 }
}
 /// <summary>
 /// 作文类型(zx_LiteratureType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_LiteratureType
{
public const string _CurrTabName = "zx_LiteratureType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxLiteratureTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxLiteratureTypeId", "LiteratureTypeName", "UpdUserId", "UpdDate"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxLiteratureTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxLiteratureTypeId = "zxLiteratureTypeId";    //作文类型Id

 /// <summary>
 /// 常量:"LiteratureTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LiteratureTypeName = "LiteratureTypeName";    //作文类型名

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期
}

}