
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRsDegreeEN
 表名:RsDegree(01120106)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:17:42
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
 /// 表RsDegree的关键字(IdDegree)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdDegree_RsDegree
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdDegree">表关键字</param>
public K_IdDegree_RsDegree(string strIdDegree)
{
if (IsValid(strIdDegree)) Value = strIdDegree;
else
{
Value = null;
}
}
private static bool IsValid(string strIdDegree)
{
if (string.IsNullOrEmpty(strIdDegree) == true) return false;
if (strIdDegree.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdDegree_RsDegree]类型的对象</returns>
public static implicit operator K_IdDegree_RsDegree(string value)
{
return new K_IdDegree_RsDegree(value);
}
}
 /// <summary>
 /// 学位(RsDegree)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsRsDegreeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "RsDegree"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdDegree"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"IdDegree", "DegreeID", "DegreeName"};

protected string mstrIdDegree;    //学位流水号
protected string mstrDegreeID;    //学位代号
protected string mstrDegreeName;    //学位名称

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsRsDegreeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdDegree");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdDegree">关键字:学位流水号</param>
public clsRsDegreeEN(string strIdDegree)
 {
strIdDegree = strIdDegree.Replace("'", "''");
if (strIdDegree.Length > 4)
{
throw new Exception("在表:RsDegree中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdDegree)  ==  true)
{
throw new Exception("在表:RsDegree中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdDegree);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdDegree = strIdDegree;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdDegree");
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
if (strAttributeName  ==  conRsDegree.IdDegree)
{
return mstrIdDegree;
}
else if (strAttributeName  ==  conRsDegree.DegreeID)
{
return mstrDegreeID;
}
else if (strAttributeName  ==  conRsDegree.DegreeName)
{
return mstrDegreeName;
}
return null;
}
set
{
if (strAttributeName  ==  conRsDegree.IdDegree)
{
mstrIdDegree = value.ToString();
 AddUpdatedFld(conRsDegree.IdDegree);
}
else if (strAttributeName  ==  conRsDegree.DegreeID)
{
mstrDegreeID = value.ToString();
 AddUpdatedFld(conRsDegree.DegreeID);
}
else if (strAttributeName  ==  conRsDegree.DegreeName)
{
mstrDegreeName = value.ToString();
 AddUpdatedFld(conRsDegree.DegreeName);
}
}
}
public object this[int intIndex]
{
get
{
if (conRsDegree.IdDegree  ==  AttributeName[intIndex])
{
return mstrIdDegree;
}
else if (conRsDegree.DegreeID  ==  AttributeName[intIndex])
{
return mstrDegreeID;
}
else if (conRsDegree.DegreeName  ==  AttributeName[intIndex])
{
return mstrDegreeName;
}
return null;
}
set
{
if (conRsDegree.IdDegree  ==  AttributeName[intIndex])
{
mstrIdDegree = value.ToString();
 AddUpdatedFld(conRsDegree.IdDegree);
}
else if (conRsDegree.DegreeID  ==  AttributeName[intIndex])
{
mstrDegreeID = value.ToString();
 AddUpdatedFld(conRsDegree.DegreeID);
}
else if (conRsDegree.DegreeName  ==  AttributeName[intIndex])
{
mstrDegreeName = value.ToString();
 AddUpdatedFld(conRsDegree.DegreeName);
}
}
}

/// <summary>
/// 学位流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdDegree
{
get
{
return mstrIdDegree;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdDegree = value;
}
else
{
 mstrIdDegree = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsDegree.IdDegree);
}
}
/// <summary>
/// 学位代号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DegreeID
{
get
{
return mstrDegreeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDegreeID = value;
}
else
{
 mstrDegreeID = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsDegree.DegreeID);
}
}
/// <summary>
/// 学位名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DegreeName
{
get
{
return mstrDegreeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDegreeName = value;
}
else
{
 mstrDegreeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conRsDegree.DegreeName);
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
  return mstrIdDegree;
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
  return mstrDegreeName;
 }
 }
}
 /// <summary>
 /// 学位(RsDegree)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conRsDegree
{
public const string _CurrTabName = "RsDegree"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdDegree"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdDegree", "DegreeID", "DegreeName"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdDegree"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdDegree = "IdDegree";    //学位流水号

 /// <summary>
 /// 常量:"DegreeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DegreeID = "DegreeID";    //学位代号

 /// <summary>
 /// 常量:"DegreeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DegreeName = "DegreeName";    //学位名称
}

}