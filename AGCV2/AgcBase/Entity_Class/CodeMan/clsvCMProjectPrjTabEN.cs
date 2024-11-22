
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMProjectPrjTabEN
 表名:vCMProjectPrjTab(00050531)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 11:52:59
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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

namespace AGC.Entity
{
 /// <summary>
 /// 表vCMProjectPrjTab的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vCMProjectPrjTab
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_vCMProjectPrjTab(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_vCMProjectPrjTab]类型的对象</returns>
public static implicit operator K_mId_vCMProjectPrjTab(long value)
{
return new K_mId_vCMProjectPrjTab(value);
}
}
 /// <summary>
 /// vCMProjectPrjTab(vCMProjectPrjTab)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvCMProjectPrjTabEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vCMProjectPrjTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 17;
public static string[] AttributeName = new string[] {"mId", "CmPrjId", "CmPrjName", "PrjId", "TabId", "TabName", "FuncModuleAgcId", "FuncModuleName", "OrderNum", "UpdDate", "UpdUser", "Memo", "SqlDsTypeId", "SqlDsTypeName", "TabRecNum", "TabTypeId", "TabStateId"};

protected long mlngmId;    //mId
protected string mstrCmPrjId;    //CM工程Id
protected string mstrCmPrjName;    //CM工程名
protected string mstrPrjId;    //工程ID
protected string mstrTabId;    //表ID
protected string mstrTabName;    //表名
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrFuncModuleName;    //功能模块名称
protected int mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改者
protected string mstrMemo;    //说明
protected string mstrSqlDsTypeId;    //数据源类型Id
protected string mstrSqlDsTypeName;    //Sql数据源名
protected int? mintTabRecNum;    //记录数
protected string mstrTabTypeId;    //表类型Id
protected string mstrTabStateId;    //表状态ID

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvCMProjectPrjTabEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clsvCMProjectPrjTabEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  convCMProjectPrjTab.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convCMProjectPrjTab.CmPrjId)
{
return mstrCmPrjId;
}
else if (strAttributeName  ==  convCMProjectPrjTab.CmPrjName)
{
return mstrCmPrjName;
}
else if (strAttributeName  ==  convCMProjectPrjTab.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  convCMProjectPrjTab.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convCMProjectPrjTab.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convCMProjectPrjTab.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  convCMProjectPrjTab.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convCMProjectPrjTab.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convCMProjectPrjTab.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convCMProjectPrjTab.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convCMProjectPrjTab.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convCMProjectPrjTab.SqlDsTypeId)
{
return mstrSqlDsTypeId;
}
else if (strAttributeName  ==  convCMProjectPrjTab.SqlDsTypeName)
{
return mstrSqlDsTypeName;
}
else if (strAttributeName  ==  convCMProjectPrjTab.TabRecNum)
{
return mintTabRecNum;
}
else if (strAttributeName  ==  convCMProjectPrjTab.TabTypeId)
{
return mstrTabTypeId;
}
else if (strAttributeName  ==  convCMProjectPrjTab.TabStateId)
{
return mstrTabStateId;
}
return null;
}
set
{
if (strAttributeName  ==  convCMProjectPrjTab.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMProjectPrjTab.mId);
}
else if (strAttributeName  ==  convCMProjectPrjTab.CmPrjId)
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(convCMProjectPrjTab.CmPrjId);
}
else if (strAttributeName  ==  convCMProjectPrjTab.CmPrjName)
{
mstrCmPrjName = value.ToString();
 AddUpdatedFld(convCMProjectPrjTab.CmPrjName);
}
else if (strAttributeName  ==  convCMProjectPrjTab.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convCMProjectPrjTab.PrjId);
}
else if (strAttributeName  ==  convCMProjectPrjTab.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convCMProjectPrjTab.TabId);
}
else if (strAttributeName  ==  convCMProjectPrjTab.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convCMProjectPrjTab.TabName);
}
else if (strAttributeName  ==  convCMProjectPrjTab.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convCMProjectPrjTab.FuncModuleAgcId);
}
else if (strAttributeName  ==  convCMProjectPrjTab.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCMProjectPrjTab.FuncModuleName);
}
else if (strAttributeName  ==  convCMProjectPrjTab.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMProjectPrjTab.OrderNum);
}
else if (strAttributeName  ==  convCMProjectPrjTab.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCMProjectPrjTab.UpdDate);
}
else if (strAttributeName  ==  convCMProjectPrjTab.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCMProjectPrjTab.UpdUser);
}
else if (strAttributeName  ==  convCMProjectPrjTab.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCMProjectPrjTab.Memo);
}
else if (strAttributeName  ==  convCMProjectPrjTab.SqlDsTypeId)
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(convCMProjectPrjTab.SqlDsTypeId);
}
else if (strAttributeName  ==  convCMProjectPrjTab.SqlDsTypeName)
{
mstrSqlDsTypeName = value.ToString();
 AddUpdatedFld(convCMProjectPrjTab.SqlDsTypeName);
}
else if (strAttributeName  ==  convCMProjectPrjTab.TabRecNum)
{
mintTabRecNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMProjectPrjTab.TabRecNum);
}
else if (strAttributeName  ==  convCMProjectPrjTab.TabTypeId)
{
mstrTabTypeId = value.ToString();
 AddUpdatedFld(convCMProjectPrjTab.TabTypeId);
}
else if (strAttributeName  ==  convCMProjectPrjTab.TabStateId)
{
mstrTabStateId = value.ToString();
 AddUpdatedFld(convCMProjectPrjTab.TabStateId);
}
}
}
public object this[int intIndex]
{
get
{
if (convCMProjectPrjTab.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convCMProjectPrjTab.CmPrjId  ==  AttributeName[intIndex])
{
return mstrCmPrjId;
}
else if (convCMProjectPrjTab.CmPrjName  ==  AttributeName[intIndex])
{
return mstrCmPrjName;
}
else if (convCMProjectPrjTab.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (convCMProjectPrjTab.TabId  ==  AttributeName[intIndex])
{
return mstrTabId;
}
else if (convCMProjectPrjTab.TabName  ==  AttributeName[intIndex])
{
return mstrTabName;
}
else if (convCMProjectPrjTab.FuncModuleAgcId  ==  AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (convCMProjectPrjTab.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convCMProjectPrjTab.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convCMProjectPrjTab.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convCMProjectPrjTab.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convCMProjectPrjTab.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convCMProjectPrjTab.SqlDsTypeId  ==  AttributeName[intIndex])
{
return mstrSqlDsTypeId;
}
else if (convCMProjectPrjTab.SqlDsTypeName  ==  AttributeName[intIndex])
{
return mstrSqlDsTypeName;
}
else if (convCMProjectPrjTab.TabRecNum  ==  AttributeName[intIndex])
{
return mintTabRecNum;
}
else if (convCMProjectPrjTab.TabTypeId  ==  AttributeName[intIndex])
{
return mstrTabTypeId;
}
else if (convCMProjectPrjTab.TabStateId  ==  AttributeName[intIndex])
{
return mstrTabStateId;
}
return null;
}
set
{
if (convCMProjectPrjTab.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMProjectPrjTab.mId);
}
else if (convCMProjectPrjTab.CmPrjId  ==  AttributeName[intIndex])
{
mstrCmPrjId = value.ToString();
 AddUpdatedFld(convCMProjectPrjTab.CmPrjId);
}
else if (convCMProjectPrjTab.CmPrjName  ==  AttributeName[intIndex])
{
mstrCmPrjName = value.ToString();
 AddUpdatedFld(convCMProjectPrjTab.CmPrjName);
}
else if (convCMProjectPrjTab.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(convCMProjectPrjTab.PrjId);
}
else if (convCMProjectPrjTab.TabId  ==  AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convCMProjectPrjTab.TabId);
}
else if (convCMProjectPrjTab.TabName  ==  AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convCMProjectPrjTab.TabName);
}
else if (convCMProjectPrjTab.FuncModuleAgcId  ==  AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convCMProjectPrjTab.FuncModuleAgcId);
}
else if (convCMProjectPrjTab.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convCMProjectPrjTab.FuncModuleName);
}
else if (convCMProjectPrjTab.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMProjectPrjTab.OrderNum);
}
else if (convCMProjectPrjTab.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convCMProjectPrjTab.UpdDate);
}
else if (convCMProjectPrjTab.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convCMProjectPrjTab.UpdUser);
}
else if (convCMProjectPrjTab.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convCMProjectPrjTab.Memo);
}
else if (convCMProjectPrjTab.SqlDsTypeId  ==  AttributeName[intIndex])
{
mstrSqlDsTypeId = value.ToString();
 AddUpdatedFld(convCMProjectPrjTab.SqlDsTypeId);
}
else if (convCMProjectPrjTab.SqlDsTypeName  ==  AttributeName[intIndex])
{
mstrSqlDsTypeName = value.ToString();
 AddUpdatedFld(convCMProjectPrjTab.SqlDsTypeName);
}
else if (convCMProjectPrjTab.TabRecNum  ==  AttributeName[intIndex])
{
mintTabRecNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convCMProjectPrjTab.TabRecNum);
}
else if (convCMProjectPrjTab.TabTypeId  ==  AttributeName[intIndex])
{
mstrTabTypeId = value.ToString();
 AddUpdatedFld(convCMProjectPrjTab.TabTypeId);
}
else if (convCMProjectPrjTab.TabStateId  ==  AttributeName[intIndex])
{
mstrTabStateId = value.ToString();
 AddUpdatedFld(convCMProjectPrjTab.TabStateId);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(convCMProjectPrjTab.mId);
}
}
/// <summary>
/// CM工程Id(说明:;字段类型:char;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmPrjId
{
get
{
return mstrCmPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmPrjId = value;
}
else
{
 mstrCmPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMProjectPrjTab.CmPrjId);
}
}
/// <summary>
/// CM工程名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CmPrjName
{
get
{
return mstrCmPrjName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCmPrjName = value;
}
else
{
 mstrCmPrjName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMProjectPrjTab.CmPrjName);
}
}
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjId
{
get
{
return mstrPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjId = value;
}
else
{
 mstrPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMProjectPrjTab.PrjId);
}
}
/// <summary>
/// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabId
{
get
{
return mstrTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabId = value;
}
else
{
 mstrTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMProjectPrjTab.TabId);
}
}
/// <summary>
/// 表名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabName
{
get
{
return mstrTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabName = value;
}
else
{
 mstrTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMProjectPrjTab.TabName);
}
}
/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleAgcId
{
get
{
return mstrFuncModuleAgcId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleAgcId = value;
}
else
{
 mstrFuncModuleAgcId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMProjectPrjTab.FuncModuleAgcId);
}
}
/// <summary>
/// 功能模块名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleName
{
get
{
return mstrFuncModuleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleName = value;
}
else
{
 mstrFuncModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMProjectPrjTab.FuncModuleName);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convCMProjectPrjTab.OrderNum);
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
 AddUpdatedFld(convCMProjectPrjTab.UpdDate);
}
}
/// <summary>
/// 修改者(说明:;字段类型:varchar;字段长度:20;是否可空:True)
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
 AddUpdatedFld(convCMProjectPrjTab.UpdUser);
}
}
/// <summary>
/// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
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
 AddUpdatedFld(convCMProjectPrjTab.Memo);
}
}
/// <summary>
/// 数据源类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlDsTypeId
{
get
{
return mstrSqlDsTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlDsTypeId = value;
}
else
{
 mstrSqlDsTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMProjectPrjTab.SqlDsTypeId);
}
}
/// <summary>
/// Sql数据源名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlDsTypeName
{
get
{
return mstrSqlDsTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlDsTypeName = value;
}
else
{
 mstrSqlDsTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMProjectPrjTab.SqlDsTypeName);
}
}
/// <summary>
/// 记录数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? TabRecNum
{
get
{
return mintTabRecNum;
}
set
{
 mintTabRecNum = value;
//记录修改过的字段
 AddUpdatedFld(convCMProjectPrjTab.TabRecNum);
}
}
/// <summary>
/// 表类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabTypeId
{
get
{
return mstrTabTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabTypeId = value;
}
else
{
 mstrTabTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMProjectPrjTab.TabTypeId);
}
}
/// <summary>
/// 表状态ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabStateId
{
get
{
return mstrTabStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabStateId = value;
}
else
{
 mstrTabStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(convCMProjectPrjTab.TabStateId);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// vCMProjectPrjTab(vCMProjectPrjTab)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convCMProjectPrjTab
{
public const string _CurrTabName = "vCMProjectPrjTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "CmPrjId", "CmPrjName", "PrjId", "TabId", "TabName", "FuncModuleAgcId", "FuncModuleName", "OrderNum", "UpdDate", "UpdUser", "Memo", "SqlDsTypeId", "SqlDsTypeName", "TabRecNum", "TabTypeId", "TabStateId"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"CmPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjId = "CmPrjId";    //CM工程Id

 /// <summary>
 /// 常量:"CmPrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CmPrjName = "CmPrjName";    //CM工程名

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程ID

 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"TabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabName = "TabName";    //表名

 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleAgcId = "FuncModuleAgcId";    //功能模块Id

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //功能模块名称

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改者

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //说明

 /// <summary>
 /// 常量:"SqlDsTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlDsTypeId = "SqlDsTypeId";    //数据源类型Id

 /// <summary>
 /// 常量:"SqlDsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlDsTypeName = "SqlDsTypeName";    //Sql数据源名

 /// <summary>
 /// 常量:"TabRecNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabRecNum = "TabRecNum";    //记录数

 /// <summary>
 /// 常量:"TabTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabTypeId = "TabTypeId";    //表类型Id

 /// <summary>
 /// 常量:"TabStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabStateId = "TabStateId";    //表状态ID
}

}