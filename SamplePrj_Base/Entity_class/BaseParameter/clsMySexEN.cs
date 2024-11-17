
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMySexEN
 表名:MySex(01160065)
 生成代码版本:2018.07.23.1
 生成日期:2018/07/30 11:07:41
 生成者:潘以锋
 生成服务器IP:202.121.63.42
 工程名称:简单工程样例
 工程ID:0116
 相关数据库:101.251.68.133,9433SimplePrj
 PrjDataBaseId:0111
 模块中文名:系统基本参数
 模块英文名:BaseParameter
 框架-层名:实体层(EntityLayer)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2018.05.31.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace SimplePrj.Entity
{
 /// <summary>
 /// 性别(MySex)
 /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsMySexEN : clsEntityBase2
{
public const string CurrTabName_S = "MySex"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "SexId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"SexId", "SexName", "Memo"};
//以下是属性变量

protected string mstrSexId;    //性别Id
protected string mstrSexName;    //性别名
protected string mstrMemo;    //备注


 /// <summary>
 /// 常量:"SexId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SexId = "SexId";    //性别Id

 /// <summary>
 /// 常量:"SexName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SexName = "SexName";    //性别名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsMySexEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "MySex";
 lstKeyFldNames.Add("SexId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mstrSexId">关键字:性别Id</param>
public clsMySexEN(string strSexId)
 {
strSexId = strSexId.Replace("'", "''");
if (strSexId.Length > 2)
{
throw new Exception("在表:MySex中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strSexId)  ==  true)
{
throw new Exception("在表:MySex中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSexId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

mstrSexId = strSexId;
 SetInit();
 mbolIsCheckProperty = false;
            _CurrTabName = "MySex";
 lstKeyFldNames.Add("SexId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  con_SexId)
{
return mstrSexId;
}
else if (strAttributeName  ==  con_SexName)
{
return mstrSexName;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_SexId)
{
mstrSexId = value.ToString();
 AddUpdatedFld(con_SexId);
}
else if (strAttributeName  ==  con_SexName)
{
mstrSexName = value.ToString();
 AddUpdatedFld(con_SexName);
}
else if (strAttributeName  ==  con_Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (con_SexId  ==  AttributeName[intIndex])
{
return mstrSexId;
}
else if (con_SexName  ==  AttributeName[intIndex])
{
return mstrSexName;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_SexId  ==  AttributeName[intIndex])
{
mstrSexId = value.ToString();
 AddUpdatedFld(con_SexId);
}
else if (con_SexName  ==  AttributeName[intIndex])
{
mstrSexName = value.ToString();
 AddUpdatedFld(con_SexName);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}

/// <summary>
/// 性别Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string SexId
{
get
{
return mstrSexId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSexId = value;
}
else
{
 mstrSexId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_SexId);
}
}
/// <summary>
/// 性别名(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string SexName
{
get
{
return mstrSexName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSexName = value;
}
else
{
 mstrSexName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_SexName);
}
}
/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
 AddUpdatedFld(con_Memo);
}
}

/// <summary>
/// 获取关键字Id(KeyId)
 /// (AutoGCLib.AutoGCPubFuncV6:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrSexId;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.AutoGCPubFuncV6:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrSexName;
 }
 }
}
}