
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCaseCourseExamRelaTypeEN
 表名:CaseCourseExamRelaType(01120485)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:19:07
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
 /// 表CaseCourseExamRelaType的关键字(IdCaseCourseExamRelaType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdCaseCourseExamRelaType_CaseCourseExamRelaType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdCaseCourseExamRelaType">表关键字</param>
public K_IdCaseCourseExamRelaType_CaseCourseExamRelaType(string strIdCaseCourseExamRelaType)
{
if (IsValid(strIdCaseCourseExamRelaType)) Value = strIdCaseCourseExamRelaType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdCaseCourseExamRelaType)
{
if (string.IsNullOrEmpty(strIdCaseCourseExamRelaType) == true) return false;
if (strIdCaseCourseExamRelaType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdCaseCourseExamRelaType_CaseCourseExamRelaType]类型的对象</returns>
public static implicit operator K_IdCaseCourseExamRelaType_CaseCourseExamRelaType(string value)
{
return new K_IdCaseCourseExamRelaType_CaseCourseExamRelaType(value);
}
}
 /// <summary>
 /// 案例题库关系类型(CaseCourseExamRelaType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCaseCourseExamRelaTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "CaseCourseExamRelaType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdCaseCourseExamRelaType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"IdCaseCourseExamRelaType", "CaseCourseExamRelaTypeID", "CaseCourseExamRelaTypeName", "Memo"};

protected string mstrIdCaseCourseExamRelaType;    //案例题库关系类型流水号
protected string mstrCaseCourseExamRelaTypeID;    //案例知识点关系类型ID
protected string mstrCaseCourseExamRelaTypeName;    //案例题库关系类型名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsCaseCourseExamRelaTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCaseCourseExamRelaType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdCaseCourseExamRelaType">关键字:案例题库关系类型流水号</param>
public clsCaseCourseExamRelaTypeEN(string strIdCaseCourseExamRelaType)
 {
strIdCaseCourseExamRelaType = strIdCaseCourseExamRelaType.Replace("'", "''");
if (strIdCaseCourseExamRelaType.Length > 4)
{
throw new Exception("在表:CaseCourseExamRelaType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdCaseCourseExamRelaType)  ==  true)
{
throw new Exception("在表:CaseCourseExamRelaType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCaseCourseExamRelaType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdCaseCourseExamRelaType = strIdCaseCourseExamRelaType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdCaseCourseExamRelaType");
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
if (strAttributeName  ==  conCaseCourseExamRelaType.IdCaseCourseExamRelaType)
{
return mstrIdCaseCourseExamRelaType;
}
else if (strAttributeName  ==  conCaseCourseExamRelaType.CaseCourseExamRelaTypeID)
{
return mstrCaseCourseExamRelaTypeID;
}
else if (strAttributeName  ==  conCaseCourseExamRelaType.CaseCourseExamRelaTypeName)
{
return mstrCaseCourseExamRelaTypeName;
}
else if (strAttributeName  ==  conCaseCourseExamRelaType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conCaseCourseExamRelaType.IdCaseCourseExamRelaType)
{
mstrIdCaseCourseExamRelaType = value.ToString();
 AddUpdatedFld(conCaseCourseExamRelaType.IdCaseCourseExamRelaType);
}
else if (strAttributeName  ==  conCaseCourseExamRelaType.CaseCourseExamRelaTypeID)
{
mstrCaseCourseExamRelaTypeID = value.ToString();
 AddUpdatedFld(conCaseCourseExamRelaType.CaseCourseExamRelaTypeID);
}
else if (strAttributeName  ==  conCaseCourseExamRelaType.CaseCourseExamRelaTypeName)
{
mstrCaseCourseExamRelaTypeName = value.ToString();
 AddUpdatedFld(conCaseCourseExamRelaType.CaseCourseExamRelaTypeName);
}
else if (strAttributeName  ==  conCaseCourseExamRelaType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCaseCourseExamRelaType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conCaseCourseExamRelaType.IdCaseCourseExamRelaType  ==  AttributeName[intIndex])
{
return mstrIdCaseCourseExamRelaType;
}
else if (conCaseCourseExamRelaType.CaseCourseExamRelaTypeID  ==  AttributeName[intIndex])
{
return mstrCaseCourseExamRelaTypeID;
}
else if (conCaseCourseExamRelaType.CaseCourseExamRelaTypeName  ==  AttributeName[intIndex])
{
return mstrCaseCourseExamRelaTypeName;
}
else if (conCaseCourseExamRelaType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conCaseCourseExamRelaType.IdCaseCourseExamRelaType  ==  AttributeName[intIndex])
{
mstrIdCaseCourseExamRelaType = value.ToString();
 AddUpdatedFld(conCaseCourseExamRelaType.IdCaseCourseExamRelaType);
}
else if (conCaseCourseExamRelaType.CaseCourseExamRelaTypeID  ==  AttributeName[intIndex])
{
mstrCaseCourseExamRelaTypeID = value.ToString();
 AddUpdatedFld(conCaseCourseExamRelaType.CaseCourseExamRelaTypeID);
}
else if (conCaseCourseExamRelaType.CaseCourseExamRelaTypeName  ==  AttributeName[intIndex])
{
mstrCaseCourseExamRelaTypeName = value.ToString();
 AddUpdatedFld(conCaseCourseExamRelaType.CaseCourseExamRelaTypeName);
}
else if (conCaseCourseExamRelaType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conCaseCourseExamRelaType.Memo);
}
}
}

/// <summary>
/// 案例题库关系类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCaseCourseExamRelaType
{
get
{
return mstrIdCaseCourseExamRelaType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCaseCourseExamRelaType = value;
}
else
{
 mstrIdCaseCourseExamRelaType = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseCourseExamRelaType.IdCaseCourseExamRelaType);
}
}
/// <summary>
/// 案例知识点关系类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseCourseExamRelaTypeID
{
get
{
return mstrCaseCourseExamRelaTypeID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseCourseExamRelaTypeID = value;
}
else
{
 mstrCaseCourseExamRelaTypeID = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseCourseExamRelaType.CaseCourseExamRelaTypeID);
}
}
/// <summary>
/// 案例题库关系类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CaseCourseExamRelaTypeName
{
get
{
return mstrCaseCourseExamRelaTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCaseCourseExamRelaTypeName = value;
}
else
{
 mstrCaseCourseExamRelaTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conCaseCourseExamRelaType.CaseCourseExamRelaTypeName);
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
 AddUpdatedFld(conCaseCourseExamRelaType.Memo);
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
  return mstrIdCaseCourseExamRelaType;
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
  return mstrCaseCourseExamRelaTypeName;
 }
 }
}
 /// <summary>
 /// 案例题库关系类型(CaseCourseExamRelaType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conCaseCourseExamRelaType
{
public const string _CurrTabName = "CaseCourseExamRelaType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdCaseCourseExamRelaType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdCaseCourseExamRelaType", "CaseCourseExamRelaTypeID", "CaseCourseExamRelaTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdCaseCourseExamRelaType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCaseCourseExamRelaType = "IdCaseCourseExamRelaType";    //案例题库关系类型流水号

 /// <summary>
 /// 常量:"CaseCourseExamRelaTypeID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseCourseExamRelaTypeID = "CaseCourseExamRelaTypeID";    //案例知识点关系类型ID

 /// <summary>
 /// 常量:"CaseCourseExamRelaTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CaseCourseExamRelaTypeName = "CaseCourseExamRelaTypeName";    //案例题库关系类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}