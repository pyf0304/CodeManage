
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_GradeIdEN
 表名:zx_GradeId(01120712)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:56:24
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
 /// 表zx_GradeId的关键字(GradeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_GradeId_zx_GradeId
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strGradeId">表关键字</param>
public K_GradeId_zx_GradeId(string strGradeId)
{
if (IsValid(strGradeId)) Value = strGradeId;
else
{
Value = null;
}
}
private static bool IsValid(string strGradeId)
{
if (string.IsNullOrEmpty(strGradeId) == true) return false;
if (strGradeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_GradeId_zx_GradeId]类型的对象</returns>
public static implicit operator K_GradeId_zx_GradeId(string value)
{
return new K_GradeId_zx_GradeId(value);
}
}
 /// <summary>
 /// 中学年级表(zx_GradeId)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_GradeIdEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_GradeId"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "GradeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"GradeId", "GradeName", "Memo"};

protected string mstrGradeId;    //年级代号
protected string mstrGradeName;    //年级名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_GradeIdEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("GradeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strGradeId">关键字:年级代号</param>
public clszx_GradeIdEN(string strGradeId)
 {
strGradeId = strGradeId.Replace("'", "''");
if (strGradeId.Length > 4)
{
throw new Exception("在表:zx_GradeId中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strGradeId)  ==  true)
{
throw new Exception("在表:zx_GradeId中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strGradeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrGradeId = strGradeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("GradeId");
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
if (strAttributeName  ==  conzx_GradeId.GradeId)
{
return mstrGradeId;
}
else if (strAttributeName  ==  conzx_GradeId.GradeName)
{
return mstrGradeName;
}
else if (strAttributeName  ==  conzx_GradeId.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_GradeId.GradeId)
{
mstrGradeId = value.ToString();
 AddUpdatedFld(conzx_GradeId.GradeId);
}
else if (strAttributeName  ==  conzx_GradeId.GradeName)
{
mstrGradeName = value.ToString();
 AddUpdatedFld(conzx_GradeId.GradeName);
}
else if (strAttributeName  ==  conzx_GradeId.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_GradeId.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_GradeId.GradeId  ==  AttributeName[intIndex])
{
return mstrGradeId;
}
else if (conzx_GradeId.GradeName  ==  AttributeName[intIndex])
{
return mstrGradeName;
}
else if (conzx_GradeId.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_GradeId.GradeId  ==  AttributeName[intIndex])
{
mstrGradeId = value.ToString();
 AddUpdatedFld(conzx_GradeId.GradeId);
}
else if (conzx_GradeId.GradeName  ==  AttributeName[intIndex])
{
mstrGradeName = value.ToString();
 AddUpdatedFld(conzx_GradeId.GradeName);
}
else if (conzx_GradeId.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_GradeId.Memo);
}
}
}

/// <summary>
/// 年级代号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GradeId
{
get
{
return mstrGradeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGradeId = value;
}
else
{
 mstrGradeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_GradeId.GradeId);
}
}
/// <summary>
/// 年级名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GradeName
{
get
{
return mstrGradeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGradeName = value;
}
else
{
 mstrGradeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_GradeId.GradeName);
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
 AddUpdatedFld(conzx_GradeId.Memo);
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
  return mstrGradeId;
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
  return mstrGradeName;
 }
 }
}
 /// <summary>
 /// 中学年级表(zx_GradeId)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_GradeId
{
public const string _CurrTabName = "zx_GradeId"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "GradeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"GradeId", "GradeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"GradeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GradeId = "GradeId";    //年级代号

 /// <summary>
 /// 常量:"GradeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GradeName = "GradeName";    //年级名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}