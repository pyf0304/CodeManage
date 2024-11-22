
//类名:clsProjectsEN
 ///----------------------
 ///生成代码版本:2016.10.07.1
 ///生成日期:2016/12/04
 ///生成者:潘以锋
 ///工程名称:问卷调查
 ///工程ID:0112
 ///模块中文名:系统参数
 ///模块英文名:SysPara
 ///注意:1、需要数据底层(PubDataBase.dll)的版本:2016.09.04.01
 ///       2、需要公共函数层(TzPubFunction.dll)的版本:2016.09.04.01
 /// ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == 
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace Questionnaire.Entity
{
 /// <summary>
 /// Projects(Projects)
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsProjectsEN : clsEntityBase2
{
public const string CurrTabName_S = "Projects"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "PrjId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"PrjId", "PrjName", "PrjDomain", "IsDefaultPrj", "PrjDataBaseId", "UpdTime", "UserId", "UpdDate", "Memo"};
//以下是属性变量

protected string mstrPrjId;    //PrjId
protected string mstrPrjName;    //PrjName
protected string mstrPrjDomain;    //PrjDomain
protected bool mbolIsDefaultPrj;    //IsDefaultPrj
protected string mstrPrjDataBaseId;    //PrjDataBaseId
protected string mstrUpdTime;    //UpdTime
protected string mstrUserId;    //用户ID
protected string mstrUpdDate;    //UpdDate
protected string mstrMemo;    //备注


 /// <summary>
 /// 常量:"PrjId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrjId  =  "PrjId";    //PrjId

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrjName  =  "PrjName";    //PrjName

 /// <summary>
 /// 常量:"PrjDomain"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrjDomain  =  "PrjDomain";    //PrjDomain

 /// <summary>
 /// 常量:"IsDefaultPrj"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsDefaultPrj  =  "IsDefaultPrj";    //IsDefaultPrj

 /// <summary>
 /// 常量:"PrjDataBaseId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrjDataBaseId  =  "PrjDataBaseId";    //PrjDataBaseId

 /// <summary>
 /// 常量:"UpdTime"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdTime  =  "UpdTime";    //UpdTime

 /// <summary>
 /// 常量:"UserId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserId  =  "UserId";    //用户ID

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdDate  =  "UpdDate";    //UpdDate

 /// <summary>
 /// 常量:"Memo"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo  =  "Memo";    //备注

/// <summary>
/// 构造函数
 /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsProjectsEN()
 {
 SetInit();
 mbolIsCheckProperty  =  false;
 CurrTabName  =  "Projects";
 lstKeyFldNames.Add("PrjId");
 }

/// <summary>
/// 构造函数
 /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mstrPrjId">关键字:PrjId</param>
public clsProjectsEN(string strPrjId)
 {
strPrjId  =  strPrjId.Replace("'", "''");
if (strPrjId.Length > 4)
{
throw new Exception("在表:Projects中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPrjId)  ==  true)
{
throw new Exception("在表:Projects中,关键字不能为空 或 null!");
}
try
{
clsCommonRegular.CheckStrSQL_Weak(strPrjId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

mstrPrjId = strPrjId;
 SetInit();
 mbolIsCheckProperty  =  false;
 CurrTabName  =  "Projects";
 lstKeyFldNames.Add("PrjId");
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
if (strAttributeName  ==  con_PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  con_PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  con_PrjDomain)
{
return mstrPrjDomain;
}
else if (strAttributeName  ==  con_IsDefaultPrj)
{
return mbolIsDefaultPrj;
}
else if (strAttributeName  ==  con_PrjDataBaseId)
{
return mstrPrjDataBaseId;
}
else if (strAttributeName  ==  con_UpdTime)
{
return mstrUpdTime;
}
else if (strAttributeName  ==  con_UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  con_UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_PrjId)
{
mstrPrjId  =  value.ToString();
 AddUpdatedFld(con_PrjId);
}
else if (strAttributeName  ==  con_PrjName)
{
mstrPrjName  =  value.ToString();
 AddUpdatedFld(con_PrjName);
}
else if (strAttributeName  ==  con_PrjDomain)
{
mstrPrjDomain  =  value.ToString();
 AddUpdatedFld(con_PrjDomain);
}
else if (strAttributeName  ==  con_IsDefaultPrj)
{
mbolIsDefaultPrj  =  TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsDefaultPrj);
}
else if (strAttributeName  ==  con_PrjDataBaseId)
{
mstrPrjDataBaseId  =  value.ToString();
 AddUpdatedFld(con_PrjDataBaseId);
}
else if (strAttributeName  ==  con_UpdTime)
{
mstrUpdTime  =  value.ToString();
 AddUpdatedFld(con_UpdTime);
}
else if (strAttributeName  ==  con_UserId)
{
mstrUserId  =  value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (strAttributeName  ==  con_UpdDate)
{
mstrUpdDate  =  value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (strAttributeName  ==  con_Memo)
{
mstrMemo  =  value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (con_PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (con_PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (con_PrjDomain  ==  AttributeName[intIndex])
{
return mstrPrjDomain;
}
else if (con_IsDefaultPrj  ==  AttributeName[intIndex])
{
return mbolIsDefaultPrj;
}
else if (con_PrjDataBaseId  ==  AttributeName[intIndex])
{
return mstrPrjDataBaseId;
}
else if (con_UpdTime  ==  AttributeName[intIndex])
{
return mstrUpdTime;
}
else if (con_UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_PrjId  ==  AttributeName[intIndex])
{
mstrPrjId  =  value.ToString();
 AddUpdatedFld(con_PrjId);
}
else if (con_PrjName  ==  AttributeName[intIndex])
{
mstrPrjName  =  value.ToString();
 AddUpdatedFld(con_PrjName);
}
else if (con_PrjDomain  ==  AttributeName[intIndex])
{
mstrPrjDomain  =  value.ToString();
 AddUpdatedFld(con_PrjDomain);
}
else if (con_IsDefaultPrj  ==  AttributeName[intIndex])
{
mbolIsDefaultPrj  =  TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsDefaultPrj);
}
else if (con_PrjDataBaseId  ==  AttributeName[intIndex])
{
mstrPrjDataBaseId  =  value.ToString();
 AddUpdatedFld(con_PrjDataBaseId);
}
else if (con_UpdTime  ==  AttributeName[intIndex])
{
mstrUpdTime  =  value.ToString();
 AddUpdatedFld(con_UpdTime);
}
else if (con_UserId  ==  AttributeName[intIndex])
{
mstrUserId  =  value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate  =  value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo  =  value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}

/// <summary>
/// PrjId(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
mintErrNo  =  1;
 mstrPrjId  =  value;
}
else
{
 mstrPrjId  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_PrjId);
}
}
/// <summary>
/// PrjName(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string PrjName
{
get
{
return mstrPrjName;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrPrjName  =  value;
}
else
{
 mstrPrjName  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_PrjName);
}
}
/// <summary>
/// PrjDomain(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string PrjDomain
{
get
{
return mstrPrjDomain;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrPrjDomain  =  value;
}
else
{
 mstrPrjDomain  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_PrjDomain);
}
}
/// <summary>
/// IsDefaultPrj(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public bool IsDefaultPrj
{
get
{
return mbolIsDefaultPrj;
}
set
{
 mbolIsDefaultPrj  =  value;
//记录修改过的字段
 AddUpdatedFld(con_IsDefaultPrj);
}
}
/// <summary>
/// PrjDataBaseId(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string PrjDataBaseId
{
get
{
return mstrPrjDataBaseId;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrPrjDataBaseId  =  value;
}
else
{
 mstrPrjDataBaseId  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_PrjDataBaseId);
}
}
/// <summary>
/// UpdTime(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string UpdTime
{
get
{
return mstrUpdTime;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrUpdTime  =  value;
}
else
{
 mstrUpdTime  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_UpdTime);
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrUserId  =  value;
}
else
{
 mstrUserId  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_UserId);
}
}
/// <summary>
/// UpdDate(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
mintErrNo  =  1;
 mstrUpdDate  =  value;
}
else
{
 mstrUpdDate  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_UpdDate);
}
}
/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
mintErrNo  =  1;
 mstrMemo  =  value;
}
else
{
 mstrMemo  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_Memo);
}
}
}
}