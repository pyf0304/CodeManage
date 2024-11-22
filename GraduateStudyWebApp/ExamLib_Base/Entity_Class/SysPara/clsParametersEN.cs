
//类名:clsParametersEN
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

namespace ExamLib.Entity
{
 /// <summary>
 /// Parameters(Parameters)
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsParametersEN : clsEntityBase2
{
public const string _CurrTabName_S = "Parameters"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"mId", "FunctionName", "intValue", "strValue", "Memo"};
//以下是属性变量

protected long mlngmId;    //mId
protected string mstrFunctionName;    //功能名
protected long mlngintValue;    //intValue
protected string mstrstrValue;    //strValue
protected string mstrMemo;    //备注


 /// <summary>
 /// 常量:"mId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_mId  =  "mId";    //mId

 /// <summary>
 /// 常量:"FunctionName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FunctionName  =  "FunctionName";    //功能名

 /// <summary>
 /// 常量:"intValue"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_intValue  =  "intValue";    //intValue

 /// <summary>
 /// 常量:"strValue"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_strValue  =  "strValue";    //strValue

 /// <summary>
 /// 常量:"Memo"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo  =  "Memo";    //备注

/// <summary>
/// 构造函数
 /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsParametersEN()
 {
 SetInit();
 mbolIsCheckProperty  =  false;
 _CurrTabName  =  "Parameters";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mlngmId">关键字:mId</param>
public clsParametersEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty  =  false;
 _CurrTabName  =  "Parameters";
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  con_mId)
{
return mlngmId;
}
else if (strAttributeName  ==  con_FunctionName)
{
return mstrFunctionName;
}
else if (strAttributeName  ==  con_intValue)
{
return mlngintValue;
}
else if (strAttributeName  ==  con_strValue)
{
return mstrstrValue;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_mId)
{
mlngmId  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_mId);
}
else if (strAttributeName  ==  con_FunctionName)
{
mstrFunctionName  =  value.ToString();
 AddUpdatedFld(con_FunctionName);
}
else if (strAttributeName  ==  con_intValue)
{
mlngintValue  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_intValue);
}
else if (strAttributeName  ==  con_strValue)
{
mstrstrValue  =  value.ToString();
 AddUpdatedFld(con_strValue);
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
if (con_mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (con_FunctionName  ==  AttributeName[intIndex])
{
return mstrFunctionName;
}
else if (con_intValue  ==  AttributeName[intIndex])
{
return mlngintValue;
}
else if (con_strValue  ==  AttributeName[intIndex])
{
return mstrstrValue;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_mId  ==  AttributeName[intIndex])
{
mlngmId  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_mId);
}
else if (con_FunctionName  ==  AttributeName[intIndex])
{
mstrFunctionName  =  value.ToString();
 AddUpdatedFld(con_FunctionName);
}
else if (con_intValue  ==  AttributeName[intIndex])
{
mlngintValue  =  TransNullToInt(value.ToString());
 AddUpdatedFld(con_intValue);
}
else if (con_strValue  ==  AttributeName[intIndex])
{
mstrstrValue  =  value.ToString();
 AddUpdatedFld(con_strValue);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo  =  value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId  =  value;
//记录修改过的字段
 AddUpdatedFld(con_mId);
}
}
/// <summary>
/// 功能名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string FunctionName
{
get
{
return mstrFunctionName;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrFunctionName  =  value;
}
else
{
 mstrFunctionName  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_FunctionName);
}
}
/// <summary>
/// intValue(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public long intValue
{
get
{
return mlngintValue;
}
set
{
 mlngintValue  =  value;
//记录修改过的字段
 AddUpdatedFld(con_intValue);
}
}
/// <summary>
/// strValue(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string strValue
{
get
{
return mstrstrValue;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrstrValue  =  value;
}
else
{
 mstrstrValue  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_strValue);
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