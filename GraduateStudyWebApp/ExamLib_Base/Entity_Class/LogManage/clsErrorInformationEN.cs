
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsErrorInformationEN
 表名:ErrorInformation(01120038)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:09:00
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日志管理(LogManage)
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
 /// 表ErrorInformation的关键字(ErrorID)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ErrorID_ErrorInformation
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngErrorID">表关键字</param>
public K_ErrorID_ErrorInformation(long lngErrorID)
{
if (IsValid(lngErrorID)) Value = lngErrorID;
else
{
Value = 0;
}
}
private static bool IsValid(long lngErrorID)
{
if (lngErrorID == 0) return false;
if (lngErrorID == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ErrorID_ErrorInformation]类型的对象</returns>
public static implicit operator K_ErrorID_ErrorInformation(long value)
{
return new K_ErrorID_ErrorInformation(value);
}
}
 /// <summary>
 /// 错误(ErrorInformation)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsErrorInformationEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "ErrorInformation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ErrorID"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"PageName", "UserId", "ErrorID", "FunctionName", "ErrorInformation", "CreateTime"};

protected string mstrPageName;    //页面名称
protected string mstrUserId;    //用户ID
protected long mlngErrorID;    //ErrorID
protected string mstrFunctionName;    //函数名
protected string mstrErrorInformation;    //ErrorInformation
protected DateTime mdteCreateTime;    //CreateTime

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsErrorInformationEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ErrorID");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngErrorID">关键字:ErrorID</param>
public clsErrorInformationEN(long lngErrorID)
 {
 if (lngErrorID  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngErrorID = lngErrorID;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ErrorID");
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
if (strAttributeName  ==  conErrorInformation.PageName)
{
return mstrPageName;
}
else if (strAttributeName  ==  conErrorInformation.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conErrorInformation.ErrorID)
{
return mlngErrorID;
}
else if (strAttributeName  ==  conErrorInformation.FunctionName)
{
return mstrFunctionName;
}
else if (strAttributeName  ==  conErrorInformation.ErrorInformation)
{
return mstrErrorInformation;
}
else if (strAttributeName  ==  conErrorInformation.CreateTime)
{
return mdteCreateTime;
}
return null;
}
set
{
if (strAttributeName  ==  conErrorInformation.PageName)
{
mstrPageName = value.ToString();
 AddUpdatedFld(conErrorInformation.PageName);
}
else if (strAttributeName  ==  conErrorInformation.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conErrorInformation.UserId);
}
else if (strAttributeName  ==  conErrorInformation.ErrorID)
{
mlngErrorID = TransNullToInt(value.ToString());
 AddUpdatedFld(conErrorInformation.ErrorID);
}
else if (strAttributeName  ==  conErrorInformation.FunctionName)
{
mstrFunctionName = value.ToString();
 AddUpdatedFld(conErrorInformation.FunctionName);
}
else if (strAttributeName  ==  conErrorInformation.ErrorInformation)
{
mstrErrorInformation = value.ToString();
 AddUpdatedFld(conErrorInformation.ErrorInformation);
}
else if (strAttributeName  ==  conErrorInformation.CreateTime)
{
mdteCreateTime = TransNullToDate(value.ToString());
 AddUpdatedFld(conErrorInformation.CreateTime);
}
}
}
public object this[int intIndex]
{
get
{
if (conErrorInformation.PageName  ==  AttributeName[intIndex])
{
return mstrPageName;
}
else if (conErrorInformation.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conErrorInformation.ErrorID  ==  AttributeName[intIndex])
{
return mlngErrorID;
}
else if (conErrorInformation.FunctionName  ==  AttributeName[intIndex])
{
return mstrFunctionName;
}
else if (conErrorInformation.ErrorInformation  ==  AttributeName[intIndex])
{
return mstrErrorInformation;
}
else if (conErrorInformation.CreateTime  ==  AttributeName[intIndex])
{
return mdteCreateTime;
}
return null;
}
set
{
if (conErrorInformation.PageName  ==  AttributeName[intIndex])
{
mstrPageName = value.ToString();
 AddUpdatedFld(conErrorInformation.PageName);
}
else if (conErrorInformation.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conErrorInformation.UserId);
}
else if (conErrorInformation.ErrorID  ==  AttributeName[intIndex])
{
mlngErrorID = TransNullToInt(value.ToString());
 AddUpdatedFld(conErrorInformation.ErrorID);
}
else if (conErrorInformation.FunctionName  ==  AttributeName[intIndex])
{
mstrFunctionName = value.ToString();
 AddUpdatedFld(conErrorInformation.FunctionName);
}
else if (conErrorInformation.ErrorInformation  ==  AttributeName[intIndex])
{
mstrErrorInformation = value.ToString();
 AddUpdatedFld(conErrorInformation.ErrorInformation);
}
else if (conErrorInformation.CreateTime  ==  AttributeName[intIndex])
{
mdteCreateTime = TransNullToDate(value.ToString());
 AddUpdatedFld(conErrorInformation.CreateTime);
}
}
}

/// <summary>
/// 页面名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PageName
{
get
{
return mstrPageName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPageName = value;
}
else
{
 mstrPageName = value;
}
//记录修改过的字段
 AddUpdatedFld(conErrorInformation.PageName);
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
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
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conErrorInformation.UserId);
}
}
/// <summary>
/// ErrorID(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long ErrorID
{
get
{
return mlngErrorID;
}
set
{
 mlngErrorID = value;
//记录修改过的字段
 AddUpdatedFld(conErrorInformation.ErrorID);
}
}
/// <summary>
/// 函数名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
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
mintErrNo = 1;
 mstrFunctionName = value;
}
else
{
 mstrFunctionName = value;
}
//记录修改过的字段
 AddUpdatedFld(conErrorInformation.FunctionName);
}
}
/// <summary>
/// ErrorInformation(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ErrorInformation
{
get
{
return mstrErrorInformation;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrErrorInformation = value;
}
else
{
 mstrErrorInformation = value;
}
//记录修改过的字段
 AddUpdatedFld(conErrorInformation.ErrorInformation);
}
}
/// <summary>
/// CreateTime(说明:;字段类型:datetime;字段长度:16;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public DateTime CreateTime
{
get
{
return mdteCreateTime;
}
set
{
 mdteCreateTime = value;
//记录修改过的字段
 AddUpdatedFld(conErrorInformation.CreateTime);
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
  return mlngErrorID.ToString();
 }
 }
}
 /// <summary>
 /// 错误(ErrorInformation)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conErrorInformation
{
public const string _CurrTabName = "ErrorInformation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ErrorID"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PageName", "UserId", "ErrorID", "FunctionName", "ErrorInformation", "CreateTime"};
//以下是属性变量


 /// <summary>
 /// 常量:"PageName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PageName = "PageName";    //页面名称

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"ErrorID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrorID = "ErrorID";    //ErrorID

 /// <summary>
 /// 常量:"FunctionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FunctionName = "FunctionName";    //函数名

 /// <summary>
 /// 常量:"ErrorInformation"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ErrorInformation = "ErrorInformation";    //ErrorInformation

 /// <summary>
 /// 常量:"CreateTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateTime = "CreateTime";    //CreateTime
}

}