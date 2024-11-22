
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsVideoLibTypeEN
 表名:VideoLibType(01120296)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:20:05
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:视频库(VideoLib)
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
 /// 表VideoLibType的关键字(IdVideoLibType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdVideoLibType_VideoLibType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdVideoLibType">表关键字</param>
public K_IdVideoLibType_VideoLibType(string strIdVideoLibType)
{
if (IsValid(strIdVideoLibType)) Value = strIdVideoLibType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdVideoLibType)
{
if (string.IsNullOrEmpty(strIdVideoLibType) == true) return false;
if (strIdVideoLibType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdVideoLibType_VideoLibType]类型的对象</returns>
public static implicit operator K_IdVideoLibType_VideoLibType(string value)
{
return new K_IdVideoLibType_VideoLibType(value);
}
}
 /// <summary>
 /// 视频库类型(VideoLibType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsVideoLibTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "VideoLibType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdVideoLibType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"IdVideoLibType", "VideoLibTypeId", "VideoLibTypeName", "Memo"};

protected string mstrIdVideoLibType;    //视频库类型流水号
protected string mstrVideoLibTypeId;    //视频库类型Id
protected string mstrVideoLibTypeName;    //视频库类型名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsVideoLibTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdVideoLibType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdVideoLibType">关键字:视频库类型流水号</param>
public clsVideoLibTypeEN(string strIdVideoLibType)
 {
strIdVideoLibType = strIdVideoLibType.Replace("'", "''");
if (strIdVideoLibType.Length > 4)
{
throw new Exception("在表:VideoLibType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdVideoLibType)  ==  true)
{
throw new Exception("在表:VideoLibType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdVideoLibType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdVideoLibType = strIdVideoLibType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdVideoLibType");
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
if (strAttributeName  ==  conVideoLibType.IdVideoLibType)
{
return mstrIdVideoLibType;
}
else if (strAttributeName  ==  conVideoLibType.VideoLibTypeId)
{
return mstrVideoLibTypeId;
}
else if (strAttributeName  ==  conVideoLibType.VideoLibTypeName)
{
return mstrVideoLibTypeName;
}
else if (strAttributeName  ==  conVideoLibType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conVideoLibType.IdVideoLibType)
{
mstrIdVideoLibType = value.ToString();
 AddUpdatedFld(conVideoLibType.IdVideoLibType);
}
else if (strAttributeName  ==  conVideoLibType.VideoLibTypeId)
{
mstrVideoLibTypeId = value.ToString();
 AddUpdatedFld(conVideoLibType.VideoLibTypeId);
}
else if (strAttributeName  ==  conVideoLibType.VideoLibTypeName)
{
mstrVideoLibTypeName = value.ToString();
 AddUpdatedFld(conVideoLibType.VideoLibTypeName);
}
else if (strAttributeName  ==  conVideoLibType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conVideoLibType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conVideoLibType.IdVideoLibType  ==  AttributeName[intIndex])
{
return mstrIdVideoLibType;
}
else if (conVideoLibType.VideoLibTypeId  ==  AttributeName[intIndex])
{
return mstrVideoLibTypeId;
}
else if (conVideoLibType.VideoLibTypeName  ==  AttributeName[intIndex])
{
return mstrVideoLibTypeName;
}
else if (conVideoLibType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conVideoLibType.IdVideoLibType  ==  AttributeName[intIndex])
{
mstrIdVideoLibType = value.ToString();
 AddUpdatedFld(conVideoLibType.IdVideoLibType);
}
else if (conVideoLibType.VideoLibTypeId  ==  AttributeName[intIndex])
{
mstrVideoLibTypeId = value.ToString();
 AddUpdatedFld(conVideoLibType.VideoLibTypeId);
}
else if (conVideoLibType.VideoLibTypeName  ==  AttributeName[intIndex])
{
mstrVideoLibTypeName = value.ToString();
 AddUpdatedFld(conVideoLibType.VideoLibTypeName);
}
else if (conVideoLibType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conVideoLibType.Memo);
}
}
}

/// <summary>
/// 视频库类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdVideoLibType
{
get
{
return mstrIdVideoLibType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdVideoLibType = value;
}
else
{
 mstrIdVideoLibType = value;
}
//记录修改过的字段
 AddUpdatedFld(conVideoLibType.IdVideoLibType);
}
}
/// <summary>
/// 视频库类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoLibTypeId
{
get
{
return mstrVideoLibTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoLibTypeId = value;
}
else
{
 mstrVideoLibTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conVideoLibType.VideoLibTypeId);
}
}
/// <summary>
/// 视频库类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoLibTypeName
{
get
{
return mstrVideoLibTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoLibTypeName = value;
}
else
{
 mstrVideoLibTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conVideoLibType.VideoLibTypeName);
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
 AddUpdatedFld(conVideoLibType.Memo);
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
  return mstrIdVideoLibType;
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
  return mstrVideoLibTypeName;
 }
 }
}
 /// <summary>
 /// 视频库类型(VideoLibType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conVideoLibType
{
public const string _CurrTabName = "VideoLibType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdVideoLibType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdVideoLibType", "VideoLibTypeId", "VideoLibTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdVideoLibType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdVideoLibType = "IdVideoLibType";    //视频库类型流水号

 /// <summary>
 /// 常量:"VideoLibTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoLibTypeId = "VideoLibTypeId";    //视频库类型Id

 /// <summary>
 /// 常量:"VideoLibTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoLibTypeName = "VideoLibTypeName";    //视频库类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}