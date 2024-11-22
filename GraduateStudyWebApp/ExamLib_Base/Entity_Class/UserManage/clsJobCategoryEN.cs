
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsJobCategoryEN
 表名:JobCategory(01120229)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:18:53
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理(UserManage)
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
 /// 表JobCategory的关键字(JobCategoryId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_JobCategoryId_JobCategory
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strJobCategoryId">表关键字</param>
public K_JobCategoryId_JobCategory(string strJobCategoryId)
{
if (IsValid(strJobCategoryId)) Value = strJobCategoryId;
else
{
Value = null;
}
}
private static bool IsValid(string strJobCategoryId)
{
if (string.IsNullOrEmpty(strJobCategoryId) == true) return false;
if (strJobCategoryId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_JobCategoryId_JobCategory]类型的对象</returns>
public static implicit operator K_JobCategoryId_JobCategory(string value)
{
return new K_JobCategoryId_JobCategory(value);
}
}
 /// <summary>
 /// 岗位类别(JobCategory)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsJobCategoryEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "JobCategory"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "JobCategoryId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"JobCategoryId", "JobCategoryName", "Memo"};

protected string mstrJobCategoryId;    //岗位类别Id
protected string mstrJobCategoryName;    //岗位类别名
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsJobCategoryEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("JobCategoryId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strJobCategoryId">关键字:岗位类别Id</param>
public clsJobCategoryEN(string strJobCategoryId)
 {
strJobCategoryId = strJobCategoryId.Replace("'", "''");
if (strJobCategoryId.Length > 2)
{
throw new Exception("在表:JobCategory中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strJobCategoryId)  ==  true)
{
throw new Exception("在表:JobCategory中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strJobCategoryId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrJobCategoryId = strJobCategoryId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("JobCategoryId");
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
if (strAttributeName  ==  conJobCategory.JobCategoryId)
{
return mstrJobCategoryId;
}
else if (strAttributeName  ==  conJobCategory.JobCategoryName)
{
return mstrJobCategoryName;
}
else if (strAttributeName  ==  conJobCategory.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conJobCategory.JobCategoryId)
{
mstrJobCategoryId = value.ToString();
 AddUpdatedFld(conJobCategory.JobCategoryId);
}
else if (strAttributeName  ==  conJobCategory.JobCategoryName)
{
mstrJobCategoryName = value.ToString();
 AddUpdatedFld(conJobCategory.JobCategoryName);
}
else if (strAttributeName  ==  conJobCategory.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conJobCategory.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conJobCategory.JobCategoryId  ==  AttributeName[intIndex])
{
return mstrJobCategoryId;
}
else if (conJobCategory.JobCategoryName  ==  AttributeName[intIndex])
{
return mstrJobCategoryName;
}
else if (conJobCategory.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conJobCategory.JobCategoryId  ==  AttributeName[intIndex])
{
mstrJobCategoryId = value.ToString();
 AddUpdatedFld(conJobCategory.JobCategoryId);
}
else if (conJobCategory.JobCategoryName  ==  AttributeName[intIndex])
{
mstrJobCategoryName = value.ToString();
 AddUpdatedFld(conJobCategory.JobCategoryName);
}
else if (conJobCategory.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conJobCategory.Memo);
}
}
}

/// <summary>
/// 岗位类别Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string JobCategoryId
{
get
{
return mstrJobCategoryId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrJobCategoryId = value;
}
else
{
 mstrJobCategoryId = value;
}
//记录修改过的字段
 AddUpdatedFld(conJobCategory.JobCategoryId);
}
}
/// <summary>
/// 岗位类别名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string JobCategoryName
{
get
{
return mstrJobCategoryName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrJobCategoryName = value;
}
else
{
 mstrJobCategoryName = value;
}
//记录修改过的字段
 AddUpdatedFld(conJobCategory.JobCategoryName);
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
 AddUpdatedFld(conJobCategory.Memo);
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
  return mstrJobCategoryId;
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
  return mstrJobCategoryName;
 }
 }
}
 /// <summary>
 /// 岗位类别(JobCategory)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conJobCategory
{
public const string _CurrTabName = "JobCategory"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "JobCategoryId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"JobCategoryId", "JobCategoryName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"JobCategoryId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string JobCategoryId = "JobCategoryId";    //岗位类别Id

 /// <summary>
 /// 常量:"JobCategoryName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string JobCategoryName = "JobCategoryName";    //岗位类别名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}