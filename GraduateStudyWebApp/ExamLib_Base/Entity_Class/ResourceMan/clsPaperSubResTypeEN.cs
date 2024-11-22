
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPaperSubResTypeEN
 表名:PaperSubResType(01120965)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:02:47
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:资源管理(ResourceMan)
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
 /// 表PaperSubResType的关键字(PaperSubResTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PaperSubResTypeId_PaperSubResType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPaperSubResTypeId">表关键字</param>
public K_PaperSubResTypeId_PaperSubResType(string strPaperSubResTypeId)
{
if (IsValid(strPaperSubResTypeId)) Value = strPaperSubResTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strPaperSubResTypeId)
{
if (string.IsNullOrEmpty(strPaperSubResTypeId) == true) return false;
if (strPaperSubResTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PaperSubResTypeId_PaperSubResType]类型的对象</returns>
public static implicit operator K_PaperSubResTypeId_PaperSubResType(string value)
{
return new K_PaperSubResTypeId_PaperSubResType(value);
}
}
 /// <summary>
 /// 论文子资源类型(PaperSubResType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsPaperSubResTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "PaperSubResType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PaperSubResTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"PaperSubResTypeId", "PaperSubResTypeName", "PaperSubResTypeENName", "FileExtentNameLst", "FileExtentNameLst2", "IsUse", "OrderNum", "UpdDate", "UpdUser", "Memo"};

protected string mstrPaperSubResTypeId;    //论文子资源类型Id
protected string mstrPaperSubResTypeName;    //论文子资源类型名
protected string mstrPaperSubResTypeENName;    //论文子资源类型英文名
protected string mstrFileExtentNameLst;    //文件扩展名列表
protected string mstrFileExtentNameLst2;    //文件扩展名列表2
protected bool mbolIsUse;    //是否使用
protected int? mintOrderNum;    //序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsPaperSubResTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperSubResTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strPaperSubResTypeId">关键字:论文子资源类型Id</param>
public clsPaperSubResTypeEN(string strPaperSubResTypeId)
 {
strPaperSubResTypeId = strPaperSubResTypeId.Replace("'", "''");
if (strPaperSubResTypeId.Length > 4)
{
throw new Exception("在表:PaperSubResType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPaperSubResTypeId)  ==  true)
{
throw new Exception("在表:PaperSubResType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPaperSubResTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPaperSubResTypeId = strPaperSubResTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PaperSubResTypeId");
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
if (strAttributeName  ==  conPaperSubResType.PaperSubResTypeId)
{
return mstrPaperSubResTypeId;
}
else if (strAttributeName  ==  conPaperSubResType.PaperSubResTypeName)
{
return mstrPaperSubResTypeName;
}
else if (strAttributeName  ==  conPaperSubResType.PaperSubResTypeENName)
{
return mstrPaperSubResTypeENName;
}
else if (strAttributeName  ==  conPaperSubResType.FileExtentNameLst)
{
return mstrFileExtentNameLst;
}
else if (strAttributeName  ==  conPaperSubResType.FileExtentNameLst2)
{
return mstrFileExtentNameLst2;
}
else if (strAttributeName  ==  conPaperSubResType.IsUse)
{
return mbolIsUse;
}
else if (strAttributeName  ==  conPaperSubResType.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conPaperSubResType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conPaperSubResType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conPaperSubResType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conPaperSubResType.PaperSubResTypeId)
{
mstrPaperSubResTypeId = value.ToString();
 AddUpdatedFld(conPaperSubResType.PaperSubResTypeId);
}
else if (strAttributeName  ==  conPaperSubResType.PaperSubResTypeName)
{
mstrPaperSubResTypeName = value.ToString();
 AddUpdatedFld(conPaperSubResType.PaperSubResTypeName);
}
else if (strAttributeName  ==  conPaperSubResType.PaperSubResTypeENName)
{
mstrPaperSubResTypeENName = value.ToString();
 AddUpdatedFld(conPaperSubResType.PaperSubResTypeENName);
}
else if (strAttributeName  ==  conPaperSubResType.FileExtentNameLst)
{
mstrFileExtentNameLst = value.ToString();
 AddUpdatedFld(conPaperSubResType.FileExtentNameLst);
}
else if (strAttributeName  ==  conPaperSubResType.FileExtentNameLst2)
{
mstrFileExtentNameLst2 = value.ToString();
 AddUpdatedFld(conPaperSubResType.FileExtentNameLst2);
}
else if (strAttributeName  ==  conPaperSubResType.IsUse)
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conPaperSubResType.IsUse);
}
else if (strAttributeName  ==  conPaperSubResType.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubResType.OrderNum);
}
else if (strAttributeName  ==  conPaperSubResType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPaperSubResType.UpdDate);
}
else if (strAttributeName  ==  conPaperSubResType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conPaperSubResType.UpdUser);
}
else if (strAttributeName  ==  conPaperSubResType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPaperSubResType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conPaperSubResType.PaperSubResTypeId  ==  AttributeName[intIndex])
{
return mstrPaperSubResTypeId;
}
else if (conPaperSubResType.PaperSubResTypeName  ==  AttributeName[intIndex])
{
return mstrPaperSubResTypeName;
}
else if (conPaperSubResType.PaperSubResTypeENName  ==  AttributeName[intIndex])
{
return mstrPaperSubResTypeENName;
}
else if (conPaperSubResType.FileExtentNameLst  ==  AttributeName[intIndex])
{
return mstrFileExtentNameLst;
}
else if (conPaperSubResType.FileExtentNameLst2  ==  AttributeName[intIndex])
{
return mstrFileExtentNameLst2;
}
else if (conPaperSubResType.IsUse  ==  AttributeName[intIndex])
{
return mbolIsUse;
}
else if (conPaperSubResType.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conPaperSubResType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conPaperSubResType.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conPaperSubResType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conPaperSubResType.PaperSubResTypeId  ==  AttributeName[intIndex])
{
mstrPaperSubResTypeId = value.ToString();
 AddUpdatedFld(conPaperSubResType.PaperSubResTypeId);
}
else if (conPaperSubResType.PaperSubResTypeName  ==  AttributeName[intIndex])
{
mstrPaperSubResTypeName = value.ToString();
 AddUpdatedFld(conPaperSubResType.PaperSubResTypeName);
}
else if (conPaperSubResType.PaperSubResTypeENName  ==  AttributeName[intIndex])
{
mstrPaperSubResTypeENName = value.ToString();
 AddUpdatedFld(conPaperSubResType.PaperSubResTypeENName);
}
else if (conPaperSubResType.FileExtentNameLst  ==  AttributeName[intIndex])
{
mstrFileExtentNameLst = value.ToString();
 AddUpdatedFld(conPaperSubResType.FileExtentNameLst);
}
else if (conPaperSubResType.FileExtentNameLst2  ==  AttributeName[intIndex])
{
mstrFileExtentNameLst2 = value.ToString();
 AddUpdatedFld(conPaperSubResType.FileExtentNameLst2);
}
else if (conPaperSubResType.IsUse  ==  AttributeName[intIndex])
{
mbolIsUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conPaperSubResType.IsUse);
}
else if (conPaperSubResType.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conPaperSubResType.OrderNum);
}
else if (conPaperSubResType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conPaperSubResType.UpdDate);
}
else if (conPaperSubResType.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conPaperSubResType.UpdUser);
}
else if (conPaperSubResType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conPaperSubResType.Memo);
}
}
}

/// <summary>
/// 论文子资源类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperSubResTypeId
{
get
{
return mstrPaperSubResTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperSubResTypeId = value;
}
else
{
 mstrPaperSubResTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaperSubResType.PaperSubResTypeId);
}
}
/// <summary>
/// 论文子资源类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperSubResTypeName
{
get
{
return mstrPaperSubResTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperSubResTypeName = value;
}
else
{
 mstrPaperSubResTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaperSubResType.PaperSubResTypeName);
}
}
/// <summary>
/// 论文子资源类型英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PaperSubResTypeENName
{
get
{
return mstrPaperSubResTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPaperSubResTypeENName = value;
}
else
{
 mstrPaperSubResTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaperSubResType.PaperSubResTypeENName);
}
}
/// <summary>
/// 文件扩展名列表(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileExtentNameLst
{
get
{
return mstrFileExtentNameLst;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileExtentNameLst = value;
}
else
{
 mstrFileExtentNameLst = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaperSubResType.FileExtentNameLst);
}
}
/// <summary>
/// 文件扩展名列表2(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FileExtentNameLst2
{
get
{
return mstrFileExtentNameLst2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFileExtentNameLst2 = value;
}
else
{
 mstrFileExtentNameLst2 = value;
}
//记录修改过的字段
 AddUpdatedFld(conPaperSubResType.FileExtentNameLst2);
}
}
/// <summary>
/// 是否使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsUse
{
get
{
return mbolIsUse;
}
set
{
 mbolIsUse = value;
//记录修改过的字段
 AddUpdatedFld(conPaperSubResType.IsUse);
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
 AddUpdatedFld(conPaperSubResType.OrderNum);
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
 AddUpdatedFld(conPaperSubResType.UpdDate);
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
 AddUpdatedFld(conPaperSubResType.UpdUser);
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
 AddUpdatedFld(conPaperSubResType.Memo);
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
  return mstrPaperSubResTypeId;
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
  return mstrPaperSubResTypeName;
 }
 }
}
 /// <summary>
 /// 论文子资源类型(PaperSubResType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conPaperSubResType
{
public const string _CurrTabName = "PaperSubResType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PaperSubResTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PaperSubResTypeId", "PaperSubResTypeName", "PaperSubResTypeENName", "FileExtentNameLst", "FileExtentNameLst2", "IsUse", "OrderNum", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"PaperSubResTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperSubResTypeId = "PaperSubResTypeId";    //论文子资源类型Id

 /// <summary>
 /// 常量:"PaperSubResTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperSubResTypeName = "PaperSubResTypeName";    //论文子资源类型名

 /// <summary>
 /// 常量:"PaperSubResTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PaperSubResTypeENName = "PaperSubResTypeENName";    //论文子资源类型英文名

 /// <summary>
 /// 常量:"FileExtentNameLst"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileExtentNameLst = "FileExtentNameLst";    //文件扩展名列表

 /// <summary>
 /// 常量:"FileExtentNameLst2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileExtentNameLst2 = "FileExtentNameLst2";    //文件扩展名列表2

 /// <summary>
 /// 常量:"IsUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsUse = "IsUse";    //是否使用

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
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}