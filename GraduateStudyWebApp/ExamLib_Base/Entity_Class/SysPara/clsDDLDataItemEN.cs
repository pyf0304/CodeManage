
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDDLDataItemEN
 表名:DDLDataItem(01120050)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:08:42
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
 /// 表DDLDataItem的关键字(DDLDataItemId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DDLDataItemId_DDLDataItem
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngDDLDataItemId">表关键字</param>
public K_DDLDataItemId_DDLDataItem(long lngDDLDataItemId)
{
if (IsValid(lngDDLDataItemId)) Value = lngDDLDataItemId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngDDLDataItemId)
{
if (lngDDLDataItemId == 0) return false;
if (lngDDLDataItemId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_DDLDataItemId_DDLDataItem]类型的对象</returns>
public static implicit operator K_DDLDataItemId_DDLDataItem(long value)
{
return new K_DDLDataItemId_DDLDataItem(value);
}
}
 /// <summary>
 /// 下拉框数据项(DDLDataItem)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDDLDataItemEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "DDLDataItem"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "DDLDataItemId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"DDLDataItemId", "DDLTabId", "DataItemNo", "DataItemText", "DataItemMemo", "UpdDate", "UpdUser", "OrderNum"};

protected long mlngDDLDataItemId;    //下拉框数据项Id
protected string mstrDDLTabId;    //下拉框表Id
protected string mstrDataItemNo;    //数据项编号
protected string mstrDataItemText;    //数据项文本
protected string mstrDataItemMemo;    //数据项备注
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected int? mintOrderNum;    //序号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsDDLDataItemEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DDLDataItemId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngDDLDataItemId">关键字:下拉框数据项Id</param>
public clsDDLDataItemEN(long lngDDLDataItemId)
 {
 if (lngDDLDataItemId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngDDLDataItemId = lngDDLDataItemId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DDLDataItemId");
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
if (strAttributeName  ==  conDDLDataItem.DDLDataItemId)
{
return mlngDDLDataItemId;
}
else if (strAttributeName  ==  conDDLDataItem.DDLTabId)
{
return mstrDDLTabId;
}
else if (strAttributeName  ==  conDDLDataItem.DataItemNo)
{
return mstrDataItemNo;
}
else if (strAttributeName  ==  conDDLDataItem.DataItemText)
{
return mstrDataItemText;
}
else if (strAttributeName  ==  conDDLDataItem.DataItemMemo)
{
return mstrDataItemMemo;
}
else if (strAttributeName  ==  conDDLDataItem.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conDDLDataItem.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conDDLDataItem.OrderNum)
{
return mintOrderNum;
}
return null;
}
set
{
if (strAttributeName  ==  conDDLDataItem.DDLDataItemId)
{
mlngDDLDataItemId = TransNullToInt(value.ToString());
 AddUpdatedFld(conDDLDataItem.DDLDataItemId);
}
else if (strAttributeName  ==  conDDLDataItem.DDLTabId)
{
mstrDDLTabId = value.ToString();
 AddUpdatedFld(conDDLDataItem.DDLTabId);
}
else if (strAttributeName  ==  conDDLDataItem.DataItemNo)
{
mstrDataItemNo = value.ToString();
 AddUpdatedFld(conDDLDataItem.DataItemNo);
}
else if (strAttributeName  ==  conDDLDataItem.DataItemText)
{
mstrDataItemText = value.ToString();
 AddUpdatedFld(conDDLDataItem.DataItemText);
}
else if (strAttributeName  ==  conDDLDataItem.DataItemMemo)
{
mstrDataItemMemo = value.ToString();
 AddUpdatedFld(conDDLDataItem.DataItemMemo);
}
else if (strAttributeName  ==  conDDLDataItem.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDDLDataItem.UpdDate);
}
else if (strAttributeName  ==  conDDLDataItem.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDDLDataItem.UpdUser);
}
else if (strAttributeName  ==  conDDLDataItem.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conDDLDataItem.OrderNum);
}
}
}
public object this[int intIndex]
{
get
{
if (conDDLDataItem.DDLDataItemId  ==  AttributeName[intIndex])
{
return mlngDDLDataItemId;
}
else if (conDDLDataItem.DDLTabId  ==  AttributeName[intIndex])
{
return mstrDDLTabId;
}
else if (conDDLDataItem.DataItemNo  ==  AttributeName[intIndex])
{
return mstrDataItemNo;
}
else if (conDDLDataItem.DataItemText  ==  AttributeName[intIndex])
{
return mstrDataItemText;
}
else if (conDDLDataItem.DataItemMemo  ==  AttributeName[intIndex])
{
return mstrDataItemMemo;
}
else if (conDDLDataItem.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conDDLDataItem.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conDDLDataItem.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
return null;
}
set
{
if (conDDLDataItem.DDLDataItemId  ==  AttributeName[intIndex])
{
mlngDDLDataItemId = TransNullToInt(value.ToString());
 AddUpdatedFld(conDDLDataItem.DDLDataItemId);
}
else if (conDDLDataItem.DDLTabId  ==  AttributeName[intIndex])
{
mstrDDLTabId = value.ToString();
 AddUpdatedFld(conDDLDataItem.DDLTabId);
}
else if (conDDLDataItem.DataItemNo  ==  AttributeName[intIndex])
{
mstrDataItemNo = value.ToString();
 AddUpdatedFld(conDDLDataItem.DataItemNo);
}
else if (conDDLDataItem.DataItemText  ==  AttributeName[intIndex])
{
mstrDataItemText = value.ToString();
 AddUpdatedFld(conDDLDataItem.DataItemText);
}
else if (conDDLDataItem.DataItemMemo  ==  AttributeName[intIndex])
{
mstrDataItemMemo = value.ToString();
 AddUpdatedFld(conDDLDataItem.DataItemMemo);
}
else if (conDDLDataItem.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conDDLDataItem.UpdDate);
}
else if (conDDLDataItem.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conDDLDataItem.UpdUser);
}
else if (conDDLDataItem.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conDDLDataItem.OrderNum);
}
}
}

/// <summary>
/// 下拉框数据项Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long DDLDataItemId
{
get
{
return mlngDDLDataItemId;
}
set
{
 mlngDDLDataItemId = value;
//记录修改过的字段
 AddUpdatedFld(conDDLDataItem.DDLDataItemId);
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
 AddUpdatedFld(conDDLDataItem.DDLTabId);
}
}
/// <summary>
/// 数据项编号(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataItemNo
{
get
{
return mstrDataItemNo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataItemNo = value;
}
else
{
 mstrDataItemNo = value;
}
//记录修改过的字段
 AddUpdatedFld(conDDLDataItem.DataItemNo);
}
}
/// <summary>
/// 数据项文本(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataItemText
{
get
{
return mstrDataItemText;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataItemText = value;
}
else
{
 mstrDataItemText = value;
}
//记录修改过的字段
 AddUpdatedFld(conDDLDataItem.DataItemText);
}
}
/// <summary>
/// 数据项备注(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataItemMemo
{
get
{
return mstrDataItemMemo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataItemMemo = value;
}
else
{
 mstrDataItemMemo = value;
}
//记录修改过的字段
 AddUpdatedFld(conDDLDataItem.DataItemMemo);
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
 AddUpdatedFld(conDDLDataItem.UpdDate);
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
 AddUpdatedFld(conDDLDataItem.UpdUser);
}
}
/// <summary>
/// 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conDDLDataItem.OrderNum);
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
  return mlngDDLDataItemId.ToString();
 }
 }
}
 /// <summary>
 /// 下拉框数据项(DDLDataItem)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conDDLDataItem
{
public const string _CurrTabName = "DDLDataItem"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DDLDataItemId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"DDLDataItemId", "DDLTabId", "DataItemNo", "DataItemText", "DataItemMemo", "UpdDate", "UpdUser", "OrderNum"};
//以下是属性变量


 /// <summary>
 /// 常量:"DDLDataItemId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DDLDataItemId = "DDLDataItemId";    //下拉框数据项Id

 /// <summary>
 /// 常量:"DDLTabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DDLTabId = "DDLTabId";    //下拉框表Id

 /// <summary>
 /// 常量:"DataItemNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataItemNo = "DataItemNo";    //数据项编号

 /// <summary>
 /// 常量:"DataItemText"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataItemText = "DataItemText";    //数据项文本

 /// <summary>
 /// 常量:"DataItemMemo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataItemMemo = "DataItemMemo";    //数据项备注

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
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号
}

}