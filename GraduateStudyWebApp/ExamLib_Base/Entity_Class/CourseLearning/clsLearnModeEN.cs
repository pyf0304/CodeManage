
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsLearnModeEN
 表名:LearnMode(01120154)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:56
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
 /// 表LearnMode的关键字(LearnModeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_LearnModeId_LearnMode
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strLearnModeId">表关键字</param>
public K_LearnModeId_LearnMode(string strLearnModeId)
{
if (IsValid(strLearnModeId)) Value = strLearnModeId;
else
{
Value = null;
}
}
private static bool IsValid(string strLearnModeId)
{
if (string.IsNullOrEmpty(strLearnModeId) == true) return false;
if (strLearnModeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_LearnModeId_LearnMode]类型的对象</returns>
public static implicit operator K_LearnModeId_LearnMode(string value)
{
return new K_LearnModeId_LearnMode(value);
}
}
 /// <summary>
 /// 学习模式(LearnMode)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsLearnModeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "LearnMode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "LearnModeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"LearnModeId", "LearnModeName", "LearnModeENName", "Memo"};

protected string mstrLearnModeId;    //学习模式Id
protected string mstrLearnModeName;    //学习模式名
protected string mstrLearnModeENName;    //学习模式英文名
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsLearnModeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("LearnModeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strLearnModeId">关键字:学习模式Id</param>
public clsLearnModeEN(string strLearnModeId)
 {
strLearnModeId = strLearnModeId.Replace("'", "''");
if (strLearnModeId.Length > 4)
{
throw new Exception("在表:LearnMode中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strLearnModeId)  ==  true)
{
throw new Exception("在表:LearnMode中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strLearnModeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrLearnModeId = strLearnModeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("LearnModeId");
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
if (strAttributeName  ==  conLearnMode.LearnModeId)
{
return mstrLearnModeId;
}
else if (strAttributeName  ==  conLearnMode.LearnModeName)
{
return mstrLearnModeName;
}
else if (strAttributeName  ==  conLearnMode.LearnModeENName)
{
return mstrLearnModeENName;
}
else if (strAttributeName  ==  conLearnMode.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conLearnMode.LearnModeId)
{
mstrLearnModeId = value.ToString();
 AddUpdatedFld(conLearnMode.LearnModeId);
}
else if (strAttributeName  ==  conLearnMode.LearnModeName)
{
mstrLearnModeName = value.ToString();
 AddUpdatedFld(conLearnMode.LearnModeName);
}
else if (strAttributeName  ==  conLearnMode.LearnModeENName)
{
mstrLearnModeENName = value.ToString();
 AddUpdatedFld(conLearnMode.LearnModeENName);
}
else if (strAttributeName  ==  conLearnMode.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conLearnMode.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conLearnMode.LearnModeId  ==  AttributeName[intIndex])
{
return mstrLearnModeId;
}
else if (conLearnMode.LearnModeName  ==  AttributeName[intIndex])
{
return mstrLearnModeName;
}
else if (conLearnMode.LearnModeENName  ==  AttributeName[intIndex])
{
return mstrLearnModeENName;
}
else if (conLearnMode.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conLearnMode.LearnModeId  ==  AttributeName[intIndex])
{
mstrLearnModeId = value.ToString();
 AddUpdatedFld(conLearnMode.LearnModeId);
}
else if (conLearnMode.LearnModeName  ==  AttributeName[intIndex])
{
mstrLearnModeName = value.ToString();
 AddUpdatedFld(conLearnMode.LearnModeName);
}
else if (conLearnMode.LearnModeENName  ==  AttributeName[intIndex])
{
mstrLearnModeENName = value.ToString();
 AddUpdatedFld(conLearnMode.LearnModeENName);
}
else if (conLearnMode.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conLearnMode.Memo);
}
}
}

/// <summary>
/// 学习模式Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LearnModeId
{
get
{
return mstrLearnModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLearnModeId = value;
}
else
{
 mstrLearnModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conLearnMode.LearnModeId);
}
}
/// <summary>
/// 学习模式名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LearnModeName
{
get
{
return mstrLearnModeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLearnModeName = value;
}
else
{
 mstrLearnModeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conLearnMode.LearnModeName);
}
}
/// <summary>
/// 学习模式英文名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LearnModeENName
{
get
{
return mstrLearnModeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLearnModeENName = value;
}
else
{
 mstrLearnModeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conLearnMode.LearnModeENName);
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
 AddUpdatedFld(conLearnMode.Memo);
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
  return mstrLearnModeId;
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
  return mstrLearnModeName;
 }
 }
}
 /// <summary>
 /// 学习模式(LearnMode)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conLearnMode
{
public const string _CurrTabName = "LearnMode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "LearnModeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"LearnModeId", "LearnModeName", "LearnModeENName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"LearnModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LearnModeId = "LearnModeId";    //学习模式Id

 /// <summary>
 /// 常量:"LearnModeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LearnModeName = "LearnModeName";    //学习模式名

 /// <summary>
 /// 常量:"LearnModeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LearnModeENName = "LearnModeENName";    //学习模式英文名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}