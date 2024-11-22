
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsVideoResCaseTypeEN
 表名:VideoResCaseType(01120525)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:06
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:视频资源库(VideoResLib)
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
 /// 表VideoResCaseType的关键字(IdVideoResCaseType)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdVideoResCaseType_VideoResCaseType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdVideoResCaseType">表关键字</param>
public K_IdVideoResCaseType_VideoResCaseType(string strIdVideoResCaseType)
{
if (IsValid(strIdVideoResCaseType)) Value = strIdVideoResCaseType;
else
{
Value = null;
}
}
private static bool IsValid(string strIdVideoResCaseType)
{
if (string.IsNullOrEmpty(strIdVideoResCaseType) == true) return false;
if (strIdVideoResCaseType.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdVideoResCaseType_VideoResCaseType]类型的对象</returns>
public static implicit operator K_IdVideoResCaseType_VideoResCaseType(string value)
{
return new K_IdVideoResCaseType_VideoResCaseType(value);
}
}
 /// <summary>
 /// 视频资源案例类型(VideoResCaseType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsVideoResCaseTypeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "VideoResCaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdVideoResCaseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"IdVideoResCaseType", "VideoResCaseTypeId", "VideoResCaseTypeName", "Memo"};

protected string mstrIdVideoResCaseType;    //视频资源类型流水号
protected string mstrVideoResCaseTypeId;    //视频资源案例类型Id
protected string mstrVideoResCaseTypeName;    //视频资源案例类型名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsVideoResCaseTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdVideoResCaseType");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdVideoResCaseType">关键字:视频资源类型流水号</param>
public clsVideoResCaseTypeEN(string strIdVideoResCaseType)
 {
strIdVideoResCaseType = strIdVideoResCaseType.Replace("'", "''");
if (strIdVideoResCaseType.Length > 4)
{
throw new Exception("在表:VideoResCaseType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdVideoResCaseType)  ==  true)
{
throw new Exception("在表:VideoResCaseType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdVideoResCaseType);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdVideoResCaseType = strIdVideoResCaseType;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdVideoResCaseType");
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
if (strAttributeName  ==  conVideoResCaseType.IdVideoResCaseType)
{
return mstrIdVideoResCaseType;
}
else if (strAttributeName  ==  conVideoResCaseType.VideoResCaseTypeId)
{
return mstrVideoResCaseTypeId;
}
else if (strAttributeName  ==  conVideoResCaseType.VideoResCaseTypeName)
{
return mstrVideoResCaseTypeName;
}
else if (strAttributeName  ==  conVideoResCaseType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conVideoResCaseType.IdVideoResCaseType)
{
mstrIdVideoResCaseType = value.ToString();
 AddUpdatedFld(conVideoResCaseType.IdVideoResCaseType);
}
else if (strAttributeName  ==  conVideoResCaseType.VideoResCaseTypeId)
{
mstrVideoResCaseTypeId = value.ToString();
 AddUpdatedFld(conVideoResCaseType.VideoResCaseTypeId);
}
else if (strAttributeName  ==  conVideoResCaseType.VideoResCaseTypeName)
{
mstrVideoResCaseTypeName = value.ToString();
 AddUpdatedFld(conVideoResCaseType.VideoResCaseTypeName);
}
else if (strAttributeName  ==  conVideoResCaseType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conVideoResCaseType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conVideoResCaseType.IdVideoResCaseType  ==  AttributeName[intIndex])
{
return mstrIdVideoResCaseType;
}
else if (conVideoResCaseType.VideoResCaseTypeId  ==  AttributeName[intIndex])
{
return mstrVideoResCaseTypeId;
}
else if (conVideoResCaseType.VideoResCaseTypeName  ==  AttributeName[intIndex])
{
return mstrVideoResCaseTypeName;
}
else if (conVideoResCaseType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conVideoResCaseType.IdVideoResCaseType  ==  AttributeName[intIndex])
{
mstrIdVideoResCaseType = value.ToString();
 AddUpdatedFld(conVideoResCaseType.IdVideoResCaseType);
}
else if (conVideoResCaseType.VideoResCaseTypeId  ==  AttributeName[intIndex])
{
mstrVideoResCaseTypeId = value.ToString();
 AddUpdatedFld(conVideoResCaseType.VideoResCaseTypeId);
}
else if (conVideoResCaseType.VideoResCaseTypeName  ==  AttributeName[intIndex])
{
mstrVideoResCaseTypeName = value.ToString();
 AddUpdatedFld(conVideoResCaseType.VideoResCaseTypeName);
}
else if (conVideoResCaseType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conVideoResCaseType.Memo);
}
}
}

/// <summary>
/// 视频资源类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdVideoResCaseType
{
get
{
return mstrIdVideoResCaseType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdVideoResCaseType = value;
}
else
{
 mstrIdVideoResCaseType = value;
}
//记录修改过的字段
 AddUpdatedFld(conVideoResCaseType.IdVideoResCaseType);
}
}
/// <summary>
/// 视频资源案例类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoResCaseTypeId
{
get
{
return mstrVideoResCaseTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoResCaseTypeId = value;
}
else
{
 mstrVideoResCaseTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conVideoResCaseType.VideoResCaseTypeId);
}
}
/// <summary>
/// 视频资源案例类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoResCaseTypeName
{
get
{
return mstrVideoResCaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoResCaseTypeName = value;
}
else
{
 mstrVideoResCaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conVideoResCaseType.VideoResCaseTypeName);
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
 AddUpdatedFld(conVideoResCaseType.Memo);
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
  return mstrIdVideoResCaseType;
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
  return mstrVideoResCaseTypeName;
 }
 }
}
 /// <summary>
 /// 视频资源案例类型(VideoResCaseType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conVideoResCaseType
{
public const string _CurrTabName = "VideoResCaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdVideoResCaseType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdVideoResCaseType", "VideoResCaseTypeId", "VideoResCaseTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdVideoResCaseType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdVideoResCaseType = "IdVideoResCaseType";    //视频资源类型流水号

 /// <summary>
 /// 常量:"VideoResCaseTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoResCaseTypeId = "VideoResCaseTypeId";    //视频资源案例类型Id

 /// <summary>
 /// 常量:"VideoResCaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoResCaseTypeName = "VideoResCaseTypeName";    //视频资源案例类型名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}