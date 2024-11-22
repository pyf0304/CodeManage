
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_UserConfigEN
 表名:vzx_UserConfig(01120842)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:14:28
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:考试管理(ExamMan)
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
 /// 表vzx_UserConfig的关键字(ConfigId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ConfigId_vzx_UserConfig
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngConfigId">表关键字</param>
public K_ConfigId_vzx_UserConfig(long lngConfigId)
{
if (IsValid(lngConfigId)) Value = lngConfigId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngConfigId)
{
if (lngConfigId == 0) return false;
if (lngConfigId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ConfigId_vzx_UserConfig]类型的对象</returns>
public static implicit operator K_ConfigId_vzx_UserConfig(long value)
{
return new K_ConfigId_vzx_UserConfig(value);
}
}
 /// <summary>
 /// vzx_UserConfig(vzx_UserConfig)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvzx_UserConfigEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vzx_UserConfig"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ConfigId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"Memo", "UpdDate", "UpdUser", "zxShareId", "zxConfigTypeId", "ConfigId", "ShareName", "ConfigTypeName", "DataTable", "DataTableId"};

protected string mstrMemo;    //备注
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrzxShareId;    //分享Id
protected string mstrzxConfigTypeId;    //配置类型Id
protected long mlngConfigId;    //配置Id
protected string mstrShareName;    //分享名称
protected string mstrConfigTypeName;    //配置类型名称
protected string mstrDataTable;    //数据表
protected string mstrDataTableId;    //数据表Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvzx_UserConfigEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ConfigId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngConfigId">关键字:配置Id</param>
public clsvzx_UserConfigEN(long lngConfigId)
 {
 if (lngConfigId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngConfigId = lngConfigId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ConfigId");
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
if (strAttributeName  ==  convzx_UserConfig.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convzx_UserConfig.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convzx_UserConfig.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convzx_UserConfig.zxShareId)
{
return mstrzxShareId;
}
else if (strAttributeName  ==  convzx_UserConfig.zxConfigTypeId)
{
return mstrzxConfigTypeId;
}
else if (strAttributeName  ==  convzx_UserConfig.ConfigId)
{
return mlngConfigId;
}
else if (strAttributeName  ==  convzx_UserConfig.ShareName)
{
return mstrShareName;
}
else if (strAttributeName  ==  convzx_UserConfig.ConfigTypeName)
{
return mstrConfigTypeName;
}
else if (strAttributeName  ==  convzx_UserConfig.DataTable)
{
return mstrDataTable;
}
else if (strAttributeName  ==  convzx_UserConfig.DataTableId)
{
return mstrDataTableId;
}
return null;
}
set
{
if (strAttributeName  ==  convzx_UserConfig.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_UserConfig.Memo);
}
else if (strAttributeName  ==  convzx_UserConfig.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_UserConfig.UpdDate);
}
else if (strAttributeName  ==  convzx_UserConfig.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_UserConfig.UpdUser);
}
else if (strAttributeName  ==  convzx_UserConfig.zxShareId)
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(convzx_UserConfig.zxShareId);
}
else if (strAttributeName  ==  convzx_UserConfig.zxConfigTypeId)
{
mstrzxConfigTypeId = value.ToString();
 AddUpdatedFld(convzx_UserConfig.zxConfigTypeId);
}
else if (strAttributeName  ==  convzx_UserConfig.ConfigId)
{
mlngConfigId = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_UserConfig.ConfigId);
}
else if (strAttributeName  ==  convzx_UserConfig.ShareName)
{
mstrShareName = value.ToString();
 AddUpdatedFld(convzx_UserConfig.ShareName);
}
else if (strAttributeName  ==  convzx_UserConfig.ConfigTypeName)
{
mstrConfigTypeName = value.ToString();
 AddUpdatedFld(convzx_UserConfig.ConfigTypeName);
}
else if (strAttributeName  ==  convzx_UserConfig.DataTable)
{
mstrDataTable = value.ToString();
 AddUpdatedFld(convzx_UserConfig.DataTable);
}
else if (strAttributeName  ==  convzx_UserConfig.DataTableId)
{
mstrDataTableId = value.ToString();
 AddUpdatedFld(convzx_UserConfig.DataTableId);
}
}
}
public object this[int intIndex]
{
get
{
if (convzx_UserConfig.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convzx_UserConfig.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convzx_UserConfig.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convzx_UserConfig.zxShareId  ==  AttributeName[intIndex])
{
return mstrzxShareId;
}
else if (convzx_UserConfig.zxConfigTypeId  ==  AttributeName[intIndex])
{
return mstrzxConfigTypeId;
}
else if (convzx_UserConfig.ConfigId  ==  AttributeName[intIndex])
{
return mlngConfigId;
}
else if (convzx_UserConfig.ShareName  ==  AttributeName[intIndex])
{
return mstrShareName;
}
else if (convzx_UserConfig.ConfigTypeName  ==  AttributeName[intIndex])
{
return mstrConfigTypeName;
}
else if (convzx_UserConfig.DataTable  ==  AttributeName[intIndex])
{
return mstrDataTable;
}
else if (convzx_UserConfig.DataTableId  ==  AttributeName[intIndex])
{
return mstrDataTableId;
}
return null;
}
set
{
if (convzx_UserConfig.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_UserConfig.Memo);
}
else if (convzx_UserConfig.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_UserConfig.UpdDate);
}
else if (convzx_UserConfig.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_UserConfig.UpdUser);
}
else if (convzx_UserConfig.zxShareId  ==  AttributeName[intIndex])
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(convzx_UserConfig.zxShareId);
}
else if (convzx_UserConfig.zxConfigTypeId  ==  AttributeName[intIndex])
{
mstrzxConfigTypeId = value.ToString();
 AddUpdatedFld(convzx_UserConfig.zxConfigTypeId);
}
else if (convzx_UserConfig.ConfigId  ==  AttributeName[intIndex])
{
mlngConfigId = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_UserConfig.ConfigId);
}
else if (convzx_UserConfig.ShareName  ==  AttributeName[intIndex])
{
mstrShareName = value.ToString();
 AddUpdatedFld(convzx_UserConfig.ShareName);
}
else if (convzx_UserConfig.ConfigTypeName  ==  AttributeName[intIndex])
{
mstrConfigTypeName = value.ToString();
 AddUpdatedFld(convzx_UserConfig.ConfigTypeName);
}
else if (convzx_UserConfig.DataTable  ==  AttributeName[intIndex])
{
mstrDataTable = value.ToString();
 AddUpdatedFld(convzx_UserConfig.DataTable);
}
else if (convzx_UserConfig.DataTableId  ==  AttributeName[intIndex])
{
mstrDataTableId = value.ToString();
 AddUpdatedFld(convzx_UserConfig.DataTableId);
}
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
 AddUpdatedFld(convzx_UserConfig.Memo);
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
 AddUpdatedFld(convzx_UserConfig.UpdDate);
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
 AddUpdatedFld(convzx_UserConfig.UpdUser);
}
}
/// <summary>
/// 分享Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxShareId
{
get
{
return mstrzxShareId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxShareId = value;
}
else
{
 mstrzxShareId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_UserConfig.zxShareId);
}
}
/// <summary>
/// 配置类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxConfigTypeId
{
get
{
return mstrzxConfigTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxConfigTypeId = value;
}
else
{
 mstrzxConfigTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_UserConfig.zxConfigTypeId);
}
}
/// <summary>
/// 配置Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long ConfigId
{
get
{
return mlngConfigId;
}
set
{
 mlngConfigId = value;
//记录修改过的字段
 AddUpdatedFld(convzx_UserConfig.ConfigId);
}
}
/// <summary>
/// 分享名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ShareName
{
get
{
return mstrShareName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrShareName = value;
}
else
{
 mstrShareName = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_UserConfig.ShareName);
}
}
/// <summary>
/// 配置类型名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ConfigTypeName
{
get
{
return mstrConfigTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrConfigTypeName = value;
}
else
{
 mstrConfigTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_UserConfig.ConfigTypeName);
}
}
/// <summary>
/// 数据表(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataTable
{
get
{
return mstrDataTable;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataTable = value;
}
else
{
 mstrDataTable = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_UserConfig.DataTable);
}
}
/// <summary>
/// 数据表Id(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataTableId
{
get
{
return mstrDataTableId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataTableId = value;
}
else
{
 mstrDataTableId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_UserConfig.DataTableId);
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
  return mlngConfigId.ToString();
 }
 }
}
 /// <summary>
 /// vzx_UserConfig(vzx_UserConfig)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convzx_UserConfig
{
public const string _CurrTabName = "vzx_UserConfig"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ConfigId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"Memo", "UpdDate", "UpdUser", "zxShareId", "zxConfigTypeId", "ConfigId", "ShareName", "ConfigTypeName", "DataTable", "DataTableId"};
//以下是属性变量


 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

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
 /// 常量:"zxShareId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxShareId = "zxShareId";    //分享Id

 /// <summary>
 /// 常量:"zxConfigTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxConfigTypeId = "zxConfigTypeId";    //配置类型Id

 /// <summary>
 /// 常量:"ConfigId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConfigId = "ConfigId";    //配置Id

 /// <summary>
 /// 常量:"ShareName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ShareName = "ShareName";    //分享名称

 /// <summary>
 /// 常量:"ConfigTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ConfigTypeName = "ConfigTypeName";    //配置类型名称

 /// <summary>
 /// 常量:"DataTable"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataTable = "DataTable";    //数据表

 /// <summary>
 /// 常量:"DataTableId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataTableId = "DataTableId";    //数据表Id
}

}