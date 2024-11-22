
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDDLTabEN
 表名:DDLTab(01120049)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:17:34
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
 /// 表DDLTab的关键字(DDLTabId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DDLTabId_DDLTab
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strDDLTabId">表关键字</param>
public K_DDLTabId_DDLTab(string strDDLTabId)
{
if (IsValid(strDDLTabId)) Value = strDDLTabId;
else
{
Value = null;
}
}
private static bool IsValid(string strDDLTabId)
{
if (string.IsNullOrEmpty(strDDLTabId) == true) return false;
if (strDDLTabId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_DDLTabId_DDLTab]类型的对象</returns>
public static implicit operator K_DDLTabId_DDLTab(string value)
{
return new K_DDLTabId_DDLTab(value);
}
}
 /// <summary>
 /// 下拉框(DDLTab)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDDLTabEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "DDLTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "DDLTabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"DDLTabId", "DDLTabName", "DDLTabFldNoName", "DDLTabFldTextName", "UpdDate", "UpdUser", "Memo"};

protected string mstrDDLTabId;    //下拉框表Id
protected string mstrDDLTabName;    //下拉框表名
protected string mstrDDLTabFldNoName;    //下拉框表的编号字段名
protected string mstrDDLTabFldTextName;    //下拉框表的文本字段名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsDDLTabEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DDLTabId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strDDLTabId">关键字:下拉框表Id</param>
public clsDDLTabEN(string strDDLTabId)
 {
strDDLTabId = strDDLTabId.Replace("'", "''");
if (strDDLTabId.Length > 4)
{
throw new Exception("在表:DDLTab中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strDDLTabId)  ==  true)
{
throw new Exception("在表:DDLTab中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDDLTabId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrDDLTabId = strDDLTabId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DDLTabId");
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
if (strAttributeName  ==  conDDLTab.DDLTabId)
{
return mstrDDLTabId;
}
else if (strAttributeName  ==  conDDLTab.DDLTabName)
{
return mstrDDLTabName;
}
else if (strAttributeName  ==  conDDLTab.DDLTabFldNoName)
{
return mstrDDLTabFldNoName;
}
else if (strAttributeName  ==  conDDLTab.DDLTabFldTextName)
{
return mstrDDLTabFldTextName;
}
else if (strAttributeName  ==  conDDLTab.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conDDLTab.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conDDLTab.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conDDLTab.DDLTabId)
{
mstrDDLTabId = value.ToString();
 AddUpdatedFld(conDDLTab.DDLTabId);
}
else if (strAttributeName  ==  conDDLTab.DDLTabName)
{
mstrDDLTabName = value.ToString();
 AddUpdatedFld(conDDLTab.DDLTabName);
}
else if (strAttributeName  ==  conDDLTab.DDLTabFldNoName)
{
mstrDDLTabFldNoName = value.ToString();
 AddUpdatedFld(conDDLTab.DDLTabFldNoName);
}
else if (strAttributeName  ==  conDDLTab.DDLTabFldTextName)
{
mstrDDLTabFldTextName = value.ToString();
 AddUpdatedFld(conDDLTab.DDLTabFldTextName);
}
else if (strAttributeName  ==  conDDLTab.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDDLTab.UpdDate);
}
else if (strAttributeName  ==  conDDLTab.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDDLTab.UpdUser);
}
else if (strAttributeName  ==  conDDLTab.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDDLTab.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conDDLTab.DDLTabId  ==  AttributeName[intIndex])
{
return mstrDDLTabId;
}
else if (conDDLTab.DDLTabName  ==  AttributeName[intIndex])
{
return mstrDDLTabName;
}
else if (conDDLTab.DDLTabFldNoName  ==  AttributeName[intIndex])
{
return mstrDDLTabFldNoName;
}
else if (conDDLTab.DDLTabFldTextName  ==  AttributeName[intIndex])
{
return mstrDDLTabFldTextName;
}
else if (conDDLTab.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conDDLTab.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conDDLTab.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conDDLTab.DDLTabId  ==  AttributeName[intIndex])
{
mstrDDLTabId = value.ToString();
 AddUpdatedFld(conDDLTab.DDLTabId);
}
else if (conDDLTab.DDLTabName  ==  AttributeName[intIndex])
{
mstrDDLTabName = value.ToString();
 AddUpdatedFld(conDDLTab.DDLTabName);
}
else if (conDDLTab.DDLTabFldNoName  ==  AttributeName[intIndex])
{
mstrDDLTabFldNoName = value.ToString();
 AddUpdatedFld(conDDLTab.DDLTabFldNoName);
}
else if (conDDLTab.DDLTabFldTextName  ==  AttributeName[intIndex])
{
mstrDDLTabFldTextName = value.ToString();
 AddUpdatedFld(conDDLTab.DDLTabFldTextName);
}
else if (conDDLTab.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDDLTab.UpdDate);
}
else if (conDDLTab.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDDLTab.UpdUser);
}
else if (conDDLTab.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conDDLTab.Memo);
}
}
}

/// <summary>
/// 下拉框表Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DDLTabId
{
get
{
return mstrDDLTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDDLTabId = value;
}
else
{
 mstrDDLTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(conDDLTab.DDLTabId);
}
}
/// <summary>
/// 下拉框表名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DDLTabName
{
get
{
return mstrDDLTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDDLTabName = value;
}
else
{
 mstrDDLTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(conDDLTab.DDLTabName);
}
}
/// <summary>
/// 下拉框表的编号字段名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DDLTabFldNoName
{
get
{
return mstrDDLTabFldNoName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDDLTabFldNoName = value;
}
else
{
 mstrDDLTabFldNoName = value;
}
//记录修改过的字段
 AddUpdatedFld(conDDLTab.DDLTabFldNoName);
}
}
/// <summary>
/// 下拉框表的文本字段名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DDLTabFldTextName
{
get
{
return mstrDDLTabFldTextName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDDLTabFldTextName = value;
}
else
{
 mstrDDLTabFldTextName = value;
}
//记录修改过的字段
 AddUpdatedFld(conDDLTab.DDLTabFldTextName);
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
 AddUpdatedFld(conDDLTab.UpdDate);
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
 AddUpdatedFld(conDDLTab.UpdUser);
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
 AddUpdatedFld(conDDLTab.Memo);
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
  return mstrDDLTabId;
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
  return mstrDDLTabName;
 }
 }
}
 /// <summary>
 /// 下拉框(DDLTab)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDDLTab
{
public const string _CurrTabName = "DDLTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DDLTabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"DDLTabId", "DDLTabName", "DDLTabFldNoName", "DDLTabFldTextName", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"DDLTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DDLTabId = "DDLTabId";    //下拉框表Id

 /// <summary>
 /// 常量:"DDLTabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DDLTabName = "DDLTabName";    //下拉框表名

 /// <summary>
 /// 常量:"DDLTabFldNoName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DDLTabFldNoName = "DDLTabFldNoName";    //下拉框表的编号字段名

 /// <summary>
 /// 常量:"DDLTabFldTextName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DDLTabFldTextName = "DDLTabFldTextName";    //下拉框表的文本字段名

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