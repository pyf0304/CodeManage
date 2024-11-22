
//类名:clsvUserBatchRelaEN
 ///----------------------
 ///生成代码版本:2016.10.01.1
 ///生成日期:2016/10/02
 ///生成者:潘以锋
 ///工程名称:问卷调查
 ///工程ID:0112
 ///模块中文名:用户管理
 ///模块英文名:UserManage
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
 /// vUserBatchRela(vUserBatchRela)
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsvUserBatchRelaEN : clsEntityBase2
{
public const string _CurrTabName_S = "vUserBatchRela"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"mId", "BatchId", "BatchName", "UserId", "UserName", "DepartmentName", "DepartmentId", "OperateModeId", "OperateModeName", "Memo"};
//以下是属性变量

protected long mlngmId;    //mId
protected string mstrBatchId;    //批次ID
protected string mstrBatchName;    //批次名称
protected string mstrUserId;    //用户ID
protected string mstrUserName;    //用户名
protected string mstrDepartmentName;    //部门名称
protected string mstrDepartmentId;    //部门Id
protected string mstrOperateModeId;    //操作方式Id
protected string mstrOperateModeName;    //操作方式名
protected string mstrMemo;    //备注


 /// <summary>
 /// 常量:"mId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_mId  =  "mId";    //mId

 /// <summary>
 /// 常量:"BatchId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_BatchId  =  "BatchId";    //批次ID

 /// <summary>
 /// 常量:"BatchName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_BatchName  =  "BatchName";    //批次名称

 /// <summary>
 /// 常量:"UserId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserId  =  "UserId";    //用户ID

 /// <summary>
 /// 常量:"UserName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserName  =  "UserName";    //用户名

 /// <summary>
 /// 常量:"DepartmentName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DepartmentName  =  "DepartmentName";    //部门名称

 /// <summary>
 /// 常量:"DepartmentId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DepartmentId  =  "DepartmentId";    //部门Id

 /// <summary>
 /// 常量:"OperateModeId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OperateModeId  =  "OperateModeId";    //操作方式Id

 /// <summary>
 /// 常量:"OperateModeName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OperateModeName  =  "OperateModeName";    //操作方式名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo  =  "Memo";    //备注

/// <summary>
/// 构造函数
 /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsvUserBatchRelaEN()
 {
 SetInit();
 mbolIsCheckProperty  =  false;
 _CurrTabName  =  "vUserBatchRela";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mlngmId">关键字:mId</param>
public clsvUserBatchRelaEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty  =  false;
 _CurrTabName  =  "vUserBatchRela";
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
else if (strAttributeName  ==  con_BatchId)
{
return mstrBatchId;
}
else if (strAttributeName  ==  con_BatchName)
{
return mstrBatchName;
}
else if (strAttributeName  ==  con_UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  con_UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  con_DepartmentName)
{
return mstrDepartmentName;
}
else if (strAttributeName  ==  con_DepartmentId)
{
return mstrDepartmentId;
}
else if (strAttributeName  ==  con_OperateModeId)
{
return mstrOperateModeId;
}
else if (strAttributeName  ==  con_OperateModeName)
{
return mstrOperateModeName;
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
else if (strAttributeName  ==  con_BatchId)
{
mstrBatchId  =  value.ToString();
 AddUpdatedFld(con_BatchId);
}
else if (strAttributeName  ==  con_BatchName)
{
mstrBatchName  =  value.ToString();
 AddUpdatedFld(con_BatchName);
}
else if (strAttributeName  ==  con_UserId)
{
mstrUserId  =  value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (strAttributeName  ==  con_UserName)
{
mstrUserName  =  value.ToString();
 AddUpdatedFld(con_UserName);
}
else if (strAttributeName  ==  con_DepartmentName)
{
mstrDepartmentName  =  value.ToString();
 AddUpdatedFld(con_DepartmentName);
}
else if (strAttributeName  ==  con_DepartmentId)
{
mstrDepartmentId  =  value.ToString();
 AddUpdatedFld(con_DepartmentId);
}
else if (strAttributeName  ==  con_OperateModeId)
{
mstrOperateModeId  =  value.ToString();
 AddUpdatedFld(con_OperateModeId);
}
else if (strAttributeName  ==  con_OperateModeName)
{
mstrOperateModeName  =  value.ToString();
 AddUpdatedFld(con_OperateModeName);
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
else if (con_BatchId  ==  AttributeName[intIndex])
{
return mstrBatchId;
}
else if (con_BatchName  ==  AttributeName[intIndex])
{
return mstrBatchName;
}
else if (con_UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (con_UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (con_DepartmentName  ==  AttributeName[intIndex])
{
return mstrDepartmentName;
}
else if (con_DepartmentId  ==  AttributeName[intIndex])
{
return mstrDepartmentId;
}
else if (con_OperateModeId  ==  AttributeName[intIndex])
{
return mstrOperateModeId;
}
else if (con_OperateModeName  ==  AttributeName[intIndex])
{
return mstrOperateModeName;
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
else if (con_BatchId  ==  AttributeName[intIndex])
{
mstrBatchId  =  value.ToString();
 AddUpdatedFld(con_BatchId);
}
else if (con_BatchName  ==  AttributeName[intIndex])
{
mstrBatchName  =  value.ToString();
 AddUpdatedFld(con_BatchName);
}
else if (con_UserId  ==  AttributeName[intIndex])
{
mstrUserId  =  value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (con_UserName  ==  AttributeName[intIndex])
{
mstrUserName  =  value.ToString();
 AddUpdatedFld(con_UserName);
}
else if (con_DepartmentName  ==  AttributeName[intIndex])
{
mstrDepartmentName  =  value.ToString();
 AddUpdatedFld(con_DepartmentName);
}
else if (con_DepartmentId  ==  AttributeName[intIndex])
{
mstrDepartmentId  =  value.ToString();
 AddUpdatedFld(con_DepartmentId);
}
else if (con_OperateModeId  ==  AttributeName[intIndex])
{
mstrOperateModeId  =  value.ToString();
 AddUpdatedFld(con_OperateModeId);
}
else if (con_OperateModeName  ==  AttributeName[intIndex])
{
mstrOperateModeName  =  value.ToString();
 AddUpdatedFld(con_OperateModeName);
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
/// 批次ID(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string BatchId
{
get
{
return mstrBatchId;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrBatchId  =  value;
}
else
{
 mstrBatchId  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_BatchId);
}
}
/// <summary>
/// 批次名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string BatchName
{
get
{
return mstrBatchName;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrBatchName  =  value;
}
else
{
 mstrBatchName  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_BatchName);
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
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string UserName
{
get
{
return mstrUserName;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrUserName  =  value;
}
else
{
 mstrUserName  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_UserName);
}
}
/// <summary>
/// 部门名称(说明:;字段类型:char;字段长度:20;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string DepartmentName
{
get
{
return mstrDepartmentName;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrDepartmentName  =  value;
}
else
{
 mstrDepartmentName  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_DepartmentName);
}
}
/// <summary>
/// 部门Id(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string DepartmentId
{
get
{
return mstrDepartmentId;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrDepartmentId  =  value;
}
else
{
 mstrDepartmentId  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_DepartmentId);
}
}
/// <summary>
/// 操作方式Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string OperateModeId
{
get
{
return mstrOperateModeId;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrOperateModeId  =  value;
}
else
{
 mstrOperateModeId  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_OperateModeId);
}
}
/// <summary>
/// 操作方式名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string OperateModeName
{
get
{
return mstrOperateModeName;
}
set
{
if (value  ==  "")
{
mintErrNo  =  1;
 mstrOperateModeName  =  value;
}
else
{
 mstrOperateModeName  =  value;
}
//记录修改过的字段
 AddUpdatedFld(con_OperateModeName);
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