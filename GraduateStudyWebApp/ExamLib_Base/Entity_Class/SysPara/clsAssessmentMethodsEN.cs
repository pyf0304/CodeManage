
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAssessmentMethodsEN
 表名:AssessmentMethods(01120967)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:02:16
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
 /// 表AssessmentMethods的关键字(AssessmentMethodId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_AssessmentMethodId_AssessmentMethods
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strAssessmentMethodId">表关键字</param>
public K_AssessmentMethodId_AssessmentMethods(string strAssessmentMethodId)
{
if (IsValid(strAssessmentMethodId)) Value = strAssessmentMethodId;
else
{
Value = null;
}
}
private static bool IsValid(string strAssessmentMethodId)
{
if (string.IsNullOrEmpty(strAssessmentMethodId) == true) return false;
if (strAssessmentMethodId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_AssessmentMethodId_AssessmentMethods]类型的对象</returns>
public static implicit operator K_AssessmentMethodId_AssessmentMethods(string value)
{
return new K_AssessmentMethodId_AssessmentMethods(value);
}
}
 /// <summary>
 /// 考核方式(AssessmentMethods)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsAssessmentMethodsEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "AssessmentMethods"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "AssessmentMethodId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"AssessmentMethodId", "AssessmentMethodName", "AssessmentMethodEnName", "UpdDate", "UpdUser", "Memo"};

protected string mstrAssessmentMethodId;    //考核方式Id
protected string mstrAssessmentMethodName;    //考核方式名
protected string mstrAssessmentMethodEnName;    //考核方式英文名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsAssessmentMethodsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("AssessmentMethodId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strAssessmentMethodId">关键字:考核方式Id</param>
public clsAssessmentMethodsEN(string strAssessmentMethodId)
 {
strAssessmentMethodId = strAssessmentMethodId.Replace("'", "''");
if (strAssessmentMethodId.Length > 2)
{
throw new Exception("在表:AssessmentMethods中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strAssessmentMethodId)  ==  true)
{
throw new Exception("在表:AssessmentMethods中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strAssessmentMethodId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrAssessmentMethodId = strAssessmentMethodId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("AssessmentMethodId");
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
if (strAttributeName  ==  conAssessmentMethods.AssessmentMethodId)
{
return mstrAssessmentMethodId;
}
else if (strAttributeName  ==  conAssessmentMethods.AssessmentMethodName)
{
return mstrAssessmentMethodName;
}
else if (strAttributeName  ==  conAssessmentMethods.AssessmentMethodEnName)
{
return mstrAssessmentMethodEnName;
}
else if (strAttributeName  ==  conAssessmentMethods.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conAssessmentMethods.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conAssessmentMethods.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conAssessmentMethods.AssessmentMethodId)
{
mstrAssessmentMethodId = value.ToString();
 AddUpdatedFld(conAssessmentMethods.AssessmentMethodId);
}
else if (strAttributeName  ==  conAssessmentMethods.AssessmentMethodName)
{
mstrAssessmentMethodName = value.ToString();
 AddUpdatedFld(conAssessmentMethods.AssessmentMethodName);
}
else if (strAttributeName  ==  conAssessmentMethods.AssessmentMethodEnName)
{
mstrAssessmentMethodEnName = value.ToString();
 AddUpdatedFld(conAssessmentMethods.AssessmentMethodEnName);
}
else if (strAttributeName  ==  conAssessmentMethods.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conAssessmentMethods.UpdDate);
}
else if (strAttributeName  ==  conAssessmentMethods.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conAssessmentMethods.UpdUser);
}
else if (strAttributeName  ==  conAssessmentMethods.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conAssessmentMethods.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conAssessmentMethods.AssessmentMethodId  ==  AttributeName[intIndex])
{
return mstrAssessmentMethodId;
}
else if (conAssessmentMethods.AssessmentMethodName  ==  AttributeName[intIndex])
{
return mstrAssessmentMethodName;
}
else if (conAssessmentMethods.AssessmentMethodEnName  ==  AttributeName[intIndex])
{
return mstrAssessmentMethodEnName;
}
else if (conAssessmentMethods.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conAssessmentMethods.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conAssessmentMethods.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conAssessmentMethods.AssessmentMethodId  ==  AttributeName[intIndex])
{
mstrAssessmentMethodId = value.ToString();
 AddUpdatedFld(conAssessmentMethods.AssessmentMethodId);
}
else if (conAssessmentMethods.AssessmentMethodName  ==  AttributeName[intIndex])
{
mstrAssessmentMethodName = value.ToString();
 AddUpdatedFld(conAssessmentMethods.AssessmentMethodName);
}
else if (conAssessmentMethods.AssessmentMethodEnName  ==  AttributeName[intIndex])
{
mstrAssessmentMethodEnName = value.ToString();
 AddUpdatedFld(conAssessmentMethods.AssessmentMethodEnName);
}
else if (conAssessmentMethods.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conAssessmentMethods.UpdDate);
}
else if (conAssessmentMethods.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conAssessmentMethods.UpdUser);
}
else if (conAssessmentMethods.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conAssessmentMethods.Memo);
}
}
}

/// <summary>
/// 考核方式Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AssessmentMethodId
{
get
{
return mstrAssessmentMethodId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAssessmentMethodId = value;
}
else
{
 mstrAssessmentMethodId = value;
}
//记录修改过的字段
 AddUpdatedFld(conAssessmentMethods.AssessmentMethodId);
}
}
/// <summary>
/// 考核方式名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AssessmentMethodName
{
get
{
return mstrAssessmentMethodName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAssessmentMethodName = value;
}
else
{
 mstrAssessmentMethodName = value;
}
//记录修改过的字段
 AddUpdatedFld(conAssessmentMethods.AssessmentMethodName);
}
}
/// <summary>
/// 考核方式英文名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string AssessmentMethodEnName
{
get
{
return mstrAssessmentMethodEnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAssessmentMethodEnName = value;
}
else
{
 mstrAssessmentMethodEnName = value;
}
//记录修改过的字段
 AddUpdatedFld(conAssessmentMethods.AssessmentMethodEnName);
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
 AddUpdatedFld(conAssessmentMethods.UpdDate);
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
 AddUpdatedFld(conAssessmentMethods.UpdUser);
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
 AddUpdatedFld(conAssessmentMethods.Memo);
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
  return mstrAssessmentMethodId;
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
  return mstrAssessmentMethodName;
 }
 }
}
 /// <summary>
 /// 考核方式(AssessmentMethods)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conAssessmentMethods
{
public const string _CurrTabName = "AssessmentMethods"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "AssessmentMethodId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"AssessmentMethodId", "AssessmentMethodName", "AssessmentMethodEnName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"AssessmentMethodId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AssessmentMethodId = "AssessmentMethodId";    //考核方式Id

 /// <summary>
 /// 常量:"AssessmentMethodName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AssessmentMethodName = "AssessmentMethodName";    //考核方式名

 /// <summary>
 /// 常量:"AssessmentMethodEnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AssessmentMethodEnName = "AssessmentMethodEnName";    //考核方式英文名

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