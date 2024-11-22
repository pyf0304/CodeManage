
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_OriginalPaperLogTypeEN
 表名:zx_OriginalPaperLogType(01120817)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:54:38
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培参数(RT_Params)
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
 /// 表zx_OriginalPaperLogType的关键字(zxLogTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxLogTypeId_zx_OriginalPaperLogType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxLogTypeId">表关键字</param>
public K_zxLogTypeId_zx_OriginalPaperLogType(string strzxLogTypeId)
{
if (IsValid(strzxLogTypeId)) Value = strzxLogTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxLogTypeId)
{
if (string.IsNullOrEmpty(strzxLogTypeId) == true) return false;
if (strzxLogTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxLogTypeId_zx_OriginalPaperLogType]类型的对象</returns>
public static implicit operator K_zxLogTypeId_zx_OriginalPaperLogType(string value)
{
return new K_zxLogTypeId_zx_OriginalPaperLogType(value);
}
}
 /// <summary>
 /// 中学论文日志类型(zx_OriginalPaperLogType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_OriginalPaperLogTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_OriginalPaperLogType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxLogTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"zxLogTypeId", "LogTypeName", "UpdUser", "UpdDate", "Memo"};

protected string mstrzxLogTypeId;    //日志类型Id
protected string mstrLogTypeName;    //日志类型名
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_OriginalPaperLogTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxLogTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxLogTypeId">关键字:日志类型Id</param>
public clszx_OriginalPaperLogTypeEN(string strzxLogTypeId)
 {
strzxLogTypeId = strzxLogTypeId.Replace("'", "''");
if (strzxLogTypeId.Length > 2)
{
throw new Exception("在表:zx_OriginalPaperLogType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxLogTypeId)  ==  true)
{
throw new Exception("在表:zx_OriginalPaperLogType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxLogTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxLogTypeId = strzxLogTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxLogTypeId");
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
if (strAttributeName  ==  conzx_OriginalPaperLogType.zxLogTypeId)
{
return mstrzxLogTypeId;
}
else if (strAttributeName  ==  conzx_OriginalPaperLogType.LogTypeName)
{
return mstrLogTypeName;
}
else if (strAttributeName  ==  conzx_OriginalPaperLogType.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_OriginalPaperLogType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_OriginalPaperLogType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_OriginalPaperLogType.zxLogTypeId)
{
mstrzxLogTypeId = value.ToString();
 AddUpdatedFld(conzx_OriginalPaperLogType.zxLogTypeId);
}
else if (strAttributeName  ==  conzx_OriginalPaperLogType.LogTypeName)
{
mstrLogTypeName = value.ToString();
 AddUpdatedFld(conzx_OriginalPaperLogType.LogTypeName);
}
else if (strAttributeName  ==  conzx_OriginalPaperLogType.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_OriginalPaperLogType.UpdUser);
}
else if (strAttributeName  ==  conzx_OriginalPaperLogType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_OriginalPaperLogType.UpdDate);
}
else if (strAttributeName  ==  conzx_OriginalPaperLogType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_OriginalPaperLogType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_OriginalPaperLogType.zxLogTypeId  ==  AttributeName[intIndex])
{
return mstrzxLogTypeId;
}
else if (conzx_OriginalPaperLogType.LogTypeName  ==  AttributeName[intIndex])
{
return mstrLogTypeName;
}
else if (conzx_OriginalPaperLogType.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_OriginalPaperLogType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_OriginalPaperLogType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_OriginalPaperLogType.zxLogTypeId  ==  AttributeName[intIndex])
{
mstrzxLogTypeId = value.ToString();
 AddUpdatedFld(conzx_OriginalPaperLogType.zxLogTypeId);
}
else if (conzx_OriginalPaperLogType.LogTypeName  ==  AttributeName[intIndex])
{
mstrLogTypeName = value.ToString();
 AddUpdatedFld(conzx_OriginalPaperLogType.LogTypeName);
}
else if (conzx_OriginalPaperLogType.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_OriginalPaperLogType.UpdUser);
}
else if (conzx_OriginalPaperLogType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_OriginalPaperLogType.UpdDate);
}
else if (conzx_OriginalPaperLogType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_OriginalPaperLogType.Memo);
}
}
}

/// <summary>
/// 日志类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxLogTypeId
{
get
{
return mstrzxLogTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxLogTypeId = value;
}
else
{
 mstrzxLogTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_OriginalPaperLogType.zxLogTypeId);
}
}
/// <summary>
/// 日志类型名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LogTypeName
{
get
{
return mstrLogTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLogTypeName = value;
}
else
{
 mstrLogTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_OriginalPaperLogType.LogTypeName);
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
 AddUpdatedFld(conzx_OriginalPaperLogType.UpdUser);
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
 AddUpdatedFld(conzx_OriginalPaperLogType.UpdDate);
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
 AddUpdatedFld(conzx_OriginalPaperLogType.Memo);
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
  return mstrzxLogTypeId;
 }
 }
}
 /// <summary>
 /// 中学论文日志类型(zx_OriginalPaperLogType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_OriginalPaperLogType
{
public const string _CurrTabName = "zx_OriginalPaperLogType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxLogTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxLogTypeId", "LogTypeName", "UpdUser", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxLogTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxLogTypeId = "zxLogTypeId";    //日志类型Id

 /// <summary>
 /// 常量:"LogTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LogTypeName = "LogTypeName";    //日志类型名

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改人

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}