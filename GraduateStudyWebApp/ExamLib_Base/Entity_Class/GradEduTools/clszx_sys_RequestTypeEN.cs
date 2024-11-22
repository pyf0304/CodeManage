
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_sys_RequestTypeEN
 表名:zx_sys_RequestType(01120794)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:07:16
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
 框架-层名:实体层(CS)(EntityLayer)
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

namespace ExamLib.Entity
{
 /// <summary>
 /// 表zx_sys_RequestType的关键字(zxRequestTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxRequestTypeId_zx_sys_RequestType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxRequestTypeId">表关键字</param>
public K_zxRequestTypeId_zx_sys_RequestType(string strzxRequestTypeId)
{
if (IsValid(strzxRequestTypeId)) Value = strzxRequestTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxRequestTypeId)
{
if (string.IsNullOrEmpty(strzxRequestTypeId) == true) return false;
if (strzxRequestTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxRequestTypeId_zx_sys_RequestType]类型的对象</returns>
public static implicit operator K_zxRequestTypeId_zx_sys_RequestType(string value)
{
return new K_zxRequestTypeId_zx_sys_RequestType(value);
}
}
 /// <summary>
 /// 中学请求类型表(zx_sys_RequestType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_sys_RequestTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_sys_RequestType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxRequestTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"zxRequestTypeId", "RequestTypeName", "RequestTable", "RequestTableId", "Memo"};

protected string mstrzxRequestTypeId;    //RequestTypeId
protected string mstrRequestTypeName;    //RequestTypeName
protected string mstrRequestTable;    //RequestTable
protected string mstrRequestTableId;    //RequestTableId
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_sys_RequestTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxRequestTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxRequestTypeId">关键字:RequestTypeId</param>
public clszx_sys_RequestTypeEN(string strzxRequestTypeId)
 {
strzxRequestTypeId = strzxRequestTypeId.Replace("'", "''");
if (strzxRequestTypeId.Length > 2)
{
throw new Exception("在表:zx_sys_RequestType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxRequestTypeId)  ==  true)
{
throw new Exception("在表:zx_sys_RequestType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxRequestTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxRequestTypeId = strzxRequestTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxRequestTypeId");
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
if (strAttributeName  ==  conzx_sys_RequestType.zxRequestTypeId)
{
return mstrzxRequestTypeId;
}
else if (strAttributeName  ==  conzx_sys_RequestType.RequestTypeName)
{
return mstrRequestTypeName;
}
else if (strAttributeName  ==  conzx_sys_RequestType.RequestTable)
{
return mstrRequestTable;
}
else if (strAttributeName  ==  conzx_sys_RequestType.RequestTableId)
{
return mstrRequestTableId;
}
else if (strAttributeName  ==  conzx_sys_RequestType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_sys_RequestType.zxRequestTypeId)
{
mstrzxRequestTypeId = value.ToString();
 AddUpdatedFld(conzx_sys_RequestType.zxRequestTypeId);
}
else if (strAttributeName  ==  conzx_sys_RequestType.RequestTypeName)
{
mstrRequestTypeName = value.ToString();
 AddUpdatedFld(conzx_sys_RequestType.RequestTypeName);
}
else if (strAttributeName  ==  conzx_sys_RequestType.RequestTable)
{
mstrRequestTable = value.ToString();
 AddUpdatedFld(conzx_sys_RequestType.RequestTable);
}
else if (strAttributeName  ==  conzx_sys_RequestType.RequestTableId)
{
mstrRequestTableId = value.ToString();
 AddUpdatedFld(conzx_sys_RequestType.RequestTableId);
}
else if (strAttributeName  ==  conzx_sys_RequestType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_sys_RequestType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_sys_RequestType.zxRequestTypeId  ==  AttributeName[intIndex])
{
return mstrzxRequestTypeId;
}
else if (conzx_sys_RequestType.RequestTypeName  ==  AttributeName[intIndex])
{
return mstrRequestTypeName;
}
else if (conzx_sys_RequestType.RequestTable  ==  AttributeName[intIndex])
{
return mstrRequestTable;
}
else if (conzx_sys_RequestType.RequestTableId  ==  AttributeName[intIndex])
{
return mstrRequestTableId;
}
else if (conzx_sys_RequestType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_sys_RequestType.zxRequestTypeId  ==  AttributeName[intIndex])
{
mstrzxRequestTypeId = value.ToString();
 AddUpdatedFld(conzx_sys_RequestType.zxRequestTypeId);
}
else if (conzx_sys_RequestType.RequestTypeName  ==  AttributeName[intIndex])
{
mstrRequestTypeName = value.ToString();
 AddUpdatedFld(conzx_sys_RequestType.RequestTypeName);
}
else if (conzx_sys_RequestType.RequestTable  ==  AttributeName[intIndex])
{
mstrRequestTable = value.ToString();
 AddUpdatedFld(conzx_sys_RequestType.RequestTable);
}
else if (conzx_sys_RequestType.RequestTableId  ==  AttributeName[intIndex])
{
mstrRequestTableId = value.ToString();
 AddUpdatedFld(conzx_sys_RequestType.RequestTableId);
}
else if (conzx_sys_RequestType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_sys_RequestType.Memo);
}
}
}

/// <summary>
/// RequestTypeId(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxRequestTypeId
{
get
{
return mstrzxRequestTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxRequestTypeId = value;
}
else
{
 mstrzxRequestTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_sys_RequestType.zxRequestTypeId);
}
}
/// <summary>
/// RequestTypeName(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RequestTypeName
{
get
{
return mstrRequestTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRequestTypeName = value;
}
else
{
 mstrRequestTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_sys_RequestType.RequestTypeName);
}
}
/// <summary>
/// RequestTable(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RequestTable
{
get
{
return mstrRequestTable;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRequestTable = value;
}
else
{
 mstrRequestTable = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_sys_RequestType.RequestTable);
}
}
/// <summary>
/// RequestTableId(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RequestTableId
{
get
{
return mstrRequestTableId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRequestTableId = value;
}
else
{
 mstrRequestTableId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_sys_RequestType.RequestTableId);
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
 AddUpdatedFld(conzx_sys_RequestType.Memo);
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
  return mstrzxRequestTypeId;
 }
 }
}
 /// <summary>
 /// 中学请求类型表(zx_sys_RequestType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_sys_RequestType
{
public const string _CurrTabName = "zx_sys_RequestType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxRequestTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxRequestTypeId", "RequestTypeName", "RequestTable", "RequestTableId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxRequestTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxRequestTypeId = "zxRequestTypeId";    //RequestTypeId

 /// <summary>
 /// 常量:"RequestTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RequestTypeName = "RequestTypeName";    //RequestTypeName

 /// <summary>
 /// 常量:"RequestTable"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RequestTable = "RequestTable";    //RequestTable

 /// <summary>
 /// 常量:"RequestTableId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RequestTableId = "RequestTableId";    //RequestTableId

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}