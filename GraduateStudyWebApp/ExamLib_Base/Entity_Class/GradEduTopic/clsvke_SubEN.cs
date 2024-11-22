
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvke_SubEN
 表名:vke_Sub(01120659)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:59:33
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 表vke_Sub的关键字(KeSubId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_KeSubId_vke_Sub
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strKeSubId">表关键字</param>
public K_KeSubId_vke_Sub(string strKeSubId)
{
if (IsValid(strKeSubId)) Value = strKeSubId;
else
{
Value = null;
}
}
private static bool IsValid(string strKeSubId)
{
if (string.IsNullOrEmpty(strKeSubId) == true) return false;
if (strKeSubId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_KeSubId_vke_Sub]类型的对象</returns>
public static implicit operator K_KeSubId_vke_Sub(string value)
{
return new K_KeSubId_vke_Sub(value);
}
}
 /// <summary>
 /// 知识经济子类视图(vke_Sub)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvke_SubEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vke_Sub"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "KeSubId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 14;
public static string[] AttributeName = new string[] {"KeSubId", "KeSuperId", "KeSuperNameCn", "KeSuperNameEn", "KeSubNameCn", "KeSubNameEn", "KeSuperDescribeCn", "KeSubDescribeCn", "KeSuperDescribeEn", "KeSubDescribeEn", "UpdDate", "UpdUser", "Memo", "Link"};

protected string mstrKeSubId;    //知识子类Id
protected string mstrKeSuperId;    //知识分类Id
protected string mstrKeSuperNameCn;    //知识分类名
protected string mstrKeSuperNameEn;    //知识分类英文名
protected string mstrKeSubNameCn;    //知识子类名
protected string mstrKeSubNameEn;    //知识子类英文名
protected string mstrKeSuperDescribeCn;    //知识分类描述
protected string mstrKeSubDescribeCn;    //知识子类描述
protected string mstrKeSuperDescribeEn;    //知识分类英文描述
protected string mstrKeSubDescribeEn;    //知识子类英文描述
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrLink;    //相应链接

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvke_SubEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("KeSubId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strKeSubId">关键字:知识子类Id</param>
public clsvke_SubEN(string strKeSubId)
 {
strKeSubId = strKeSubId.Replace("'", "''");
if (strKeSubId.Length > 4)
{
throw new Exception("在表:vke_Sub中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strKeSubId)  ==  true)
{
throw new Exception("在表:vke_Sub中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strKeSubId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrKeSubId = strKeSubId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("KeSubId");
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
if (strAttributeName  ==  convke_Sub.KeSubId)
{
return mstrKeSubId;
}
else if (strAttributeName  ==  convke_Sub.KeSuperId)
{
return mstrKeSuperId;
}
else if (strAttributeName  ==  convke_Sub.KeSuperNameCn)
{
return mstrKeSuperNameCn;
}
else if (strAttributeName  ==  convke_Sub.KeSuperNameEn)
{
return mstrKeSuperNameEn;
}
else if (strAttributeName  ==  convke_Sub.KeSubNameCn)
{
return mstrKeSubNameCn;
}
else if (strAttributeName  ==  convke_Sub.KeSubNameEn)
{
return mstrKeSubNameEn;
}
else if (strAttributeName  ==  convke_Sub.KeSuperDescribeCn)
{
return mstrKeSuperDescribeCn;
}
else if (strAttributeName  ==  convke_Sub.KeSubDescribeCn)
{
return mstrKeSubDescribeCn;
}
else if (strAttributeName  ==  convke_Sub.KeSuperDescribeEn)
{
return mstrKeSuperDescribeEn;
}
else if (strAttributeName  ==  convke_Sub.KeSubDescribeEn)
{
return mstrKeSubDescribeEn;
}
else if (strAttributeName  ==  convke_Sub.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convke_Sub.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convke_Sub.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convke_Sub.Link)
{
return mstrLink;
}
return null;
}
set
{
if (strAttributeName  ==  convke_Sub.KeSubId)
{
mstrKeSubId = value.ToString();
 AddUpdatedFld(convke_Sub.KeSubId);
}
else if (strAttributeName  ==  convke_Sub.KeSuperId)
{
mstrKeSuperId = value.ToString();
 AddUpdatedFld(convke_Sub.KeSuperId);
}
else if (strAttributeName  ==  convke_Sub.KeSuperNameCn)
{
mstrKeSuperNameCn = value.ToString();
 AddUpdatedFld(convke_Sub.KeSuperNameCn);
}
else if (strAttributeName  ==  convke_Sub.KeSuperNameEn)
{
mstrKeSuperNameEn = value.ToString();
 AddUpdatedFld(convke_Sub.KeSuperNameEn);
}
else if (strAttributeName  ==  convke_Sub.KeSubNameCn)
{
mstrKeSubNameCn = value.ToString();
 AddUpdatedFld(convke_Sub.KeSubNameCn);
}
else if (strAttributeName  ==  convke_Sub.KeSubNameEn)
{
mstrKeSubNameEn = value.ToString();
 AddUpdatedFld(convke_Sub.KeSubNameEn);
}
else if (strAttributeName  ==  convke_Sub.KeSuperDescribeCn)
{
mstrKeSuperDescribeCn = value.ToString();
 AddUpdatedFld(convke_Sub.KeSuperDescribeCn);
}
else if (strAttributeName  ==  convke_Sub.KeSubDescribeCn)
{
mstrKeSubDescribeCn = value.ToString();
 AddUpdatedFld(convke_Sub.KeSubDescribeCn);
}
else if (strAttributeName  ==  convke_Sub.KeSuperDescribeEn)
{
mstrKeSuperDescribeEn = value.ToString();
 AddUpdatedFld(convke_Sub.KeSuperDescribeEn);
}
else if (strAttributeName  ==  convke_Sub.KeSubDescribeEn)
{
mstrKeSubDescribeEn = value.ToString();
 AddUpdatedFld(convke_Sub.KeSubDescribeEn);
}
else if (strAttributeName  ==  convke_Sub.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convke_Sub.UpdDate);
}
else if (strAttributeName  ==  convke_Sub.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convke_Sub.UpdUser);
}
else if (strAttributeName  ==  convke_Sub.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convke_Sub.Memo);
}
else if (strAttributeName  ==  convke_Sub.Link)
{
mstrLink = value.ToString();
 AddUpdatedFld(convke_Sub.Link);
}
}
}
public object this[int intIndex]
{
get
{
if (convke_Sub.KeSubId  ==  AttributeName[intIndex])
{
return mstrKeSubId;
}
else if (convke_Sub.KeSuperId  ==  AttributeName[intIndex])
{
return mstrKeSuperId;
}
else if (convke_Sub.KeSuperNameCn  ==  AttributeName[intIndex])
{
return mstrKeSuperNameCn;
}
else if (convke_Sub.KeSuperNameEn  ==  AttributeName[intIndex])
{
return mstrKeSuperNameEn;
}
else if (convke_Sub.KeSubNameCn  ==  AttributeName[intIndex])
{
return mstrKeSubNameCn;
}
else if (convke_Sub.KeSubNameEn  ==  AttributeName[intIndex])
{
return mstrKeSubNameEn;
}
else if (convke_Sub.KeSuperDescribeCn  ==  AttributeName[intIndex])
{
return mstrKeSuperDescribeCn;
}
else if (convke_Sub.KeSubDescribeCn  ==  AttributeName[intIndex])
{
return mstrKeSubDescribeCn;
}
else if (convke_Sub.KeSuperDescribeEn  ==  AttributeName[intIndex])
{
return mstrKeSuperDescribeEn;
}
else if (convke_Sub.KeSubDescribeEn  ==  AttributeName[intIndex])
{
return mstrKeSubDescribeEn;
}
else if (convke_Sub.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convke_Sub.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convke_Sub.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convke_Sub.Link  ==  AttributeName[intIndex])
{
return mstrLink;
}
return null;
}
set
{
if (convke_Sub.KeSubId  ==  AttributeName[intIndex])
{
mstrKeSubId = value.ToString();
 AddUpdatedFld(convke_Sub.KeSubId);
}
else if (convke_Sub.KeSuperId  ==  AttributeName[intIndex])
{
mstrKeSuperId = value.ToString();
 AddUpdatedFld(convke_Sub.KeSuperId);
}
else if (convke_Sub.KeSuperNameCn  ==  AttributeName[intIndex])
{
mstrKeSuperNameCn = value.ToString();
 AddUpdatedFld(convke_Sub.KeSuperNameCn);
}
else if (convke_Sub.KeSuperNameEn  ==  AttributeName[intIndex])
{
mstrKeSuperNameEn = value.ToString();
 AddUpdatedFld(convke_Sub.KeSuperNameEn);
}
else if (convke_Sub.KeSubNameCn  ==  AttributeName[intIndex])
{
mstrKeSubNameCn = value.ToString();
 AddUpdatedFld(convke_Sub.KeSubNameCn);
}
else if (convke_Sub.KeSubNameEn  ==  AttributeName[intIndex])
{
mstrKeSubNameEn = value.ToString();
 AddUpdatedFld(convke_Sub.KeSubNameEn);
}
else if (convke_Sub.KeSuperDescribeCn  ==  AttributeName[intIndex])
{
mstrKeSuperDescribeCn = value.ToString();
 AddUpdatedFld(convke_Sub.KeSuperDescribeCn);
}
else if (convke_Sub.KeSubDescribeCn  ==  AttributeName[intIndex])
{
mstrKeSubDescribeCn = value.ToString();
 AddUpdatedFld(convke_Sub.KeSubDescribeCn);
}
else if (convke_Sub.KeSuperDescribeEn  ==  AttributeName[intIndex])
{
mstrKeSuperDescribeEn = value.ToString();
 AddUpdatedFld(convke_Sub.KeSuperDescribeEn);
}
else if (convke_Sub.KeSubDescribeEn  ==  AttributeName[intIndex])
{
mstrKeSubDescribeEn = value.ToString();
 AddUpdatedFld(convke_Sub.KeSubDescribeEn);
}
else if (convke_Sub.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convke_Sub.UpdDate);
}
else if (convke_Sub.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convke_Sub.UpdUser);
}
else if (convke_Sub.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convke_Sub.Memo);
}
else if (convke_Sub.Link  ==  AttributeName[intIndex])
{
mstrLink = value.ToString();
 AddUpdatedFld(convke_Sub.Link);
}
}
}

/// <summary>
/// 知识子类Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeSubId
{
get
{
return mstrKeSubId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeSubId = value;
}
else
{
 mstrKeSubId = value;
}
//记录修改过的字段
 AddUpdatedFld(convke_Sub.KeSubId);
}
}
/// <summary>
/// 知识分类Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeSuperId
{
get
{
return mstrKeSuperId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeSuperId = value;
}
else
{
 mstrKeSuperId = value;
}
//记录修改过的字段
 AddUpdatedFld(convke_Sub.KeSuperId);
}
}
/// <summary>
/// 知识分类名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeSuperNameCn
{
get
{
return mstrKeSuperNameCn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeSuperNameCn = value;
}
else
{
 mstrKeSuperNameCn = value;
}
//记录修改过的字段
 AddUpdatedFld(convke_Sub.KeSuperNameCn);
}
}
/// <summary>
/// 知识分类英文名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeSuperNameEn
{
get
{
return mstrKeSuperNameEn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeSuperNameEn = value;
}
else
{
 mstrKeSuperNameEn = value;
}
//记录修改过的字段
 AddUpdatedFld(convke_Sub.KeSuperNameEn);
}
}
/// <summary>
/// 知识子类名(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeSubNameCn
{
get
{
return mstrKeSubNameCn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeSubNameCn = value;
}
else
{
 mstrKeSubNameCn = value;
}
//记录修改过的字段
 AddUpdatedFld(convke_Sub.KeSubNameCn);
}
}
/// <summary>
/// 知识子类英文名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeSubNameEn
{
get
{
return mstrKeSubNameEn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeSubNameEn = value;
}
else
{
 mstrKeSubNameEn = value;
}
//记录修改过的字段
 AddUpdatedFld(convke_Sub.KeSubNameEn);
}
}
/// <summary>
/// 知识分类描述(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeSuperDescribeCn
{
get
{
return mstrKeSuperDescribeCn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeSuperDescribeCn = value;
}
else
{
 mstrKeSuperDescribeCn = value;
}
//记录修改过的字段
 AddUpdatedFld(convke_Sub.KeSuperDescribeCn);
}
}
/// <summary>
/// 知识子类描述(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeSubDescribeCn
{
get
{
return mstrKeSubDescribeCn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeSubDescribeCn = value;
}
else
{
 mstrKeSubDescribeCn = value;
}
//记录修改过的字段
 AddUpdatedFld(convke_Sub.KeSubDescribeCn);
}
}
/// <summary>
/// 知识分类英文描述(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeSuperDescribeEn
{
get
{
return mstrKeSuperDescribeEn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeSuperDescribeEn = value;
}
else
{
 mstrKeSuperDescribeEn = value;
}
//记录修改过的字段
 AddUpdatedFld(convke_Sub.KeSuperDescribeEn);
}
}
/// <summary>
/// 知识子类英文描述(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeSubDescribeEn
{
get
{
return mstrKeSubDescribeEn;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeSubDescribeEn = value;
}
else
{
 mstrKeSubDescribeEn = value;
}
//记录修改过的字段
 AddUpdatedFld(convke_Sub.KeSubDescribeEn);
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
 AddUpdatedFld(convke_Sub.UpdDate);
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
 AddUpdatedFld(convke_Sub.UpdUser);
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
 AddUpdatedFld(convke_Sub.Memo);
}
}
/// <summary>
/// 相应链接(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Link
{
get
{
return mstrLink;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLink = value;
}
else
{
 mstrLink = value;
}
//记录修改过的字段
 AddUpdatedFld(convke_Sub.Link);
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
  return mstrKeSubId;
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
  return mstrKeSuperNameCn;
 }
 }
}
 /// <summary>
 /// 知识经济子类视图(vke_Sub)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convke_Sub
{
public const string _CurrTabName = "vke_Sub"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "KeSubId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"KeSubId", "KeSuperId", "KeSuperNameCn", "KeSuperNameEn", "KeSubNameCn", "KeSubNameEn", "KeSuperDescribeCn", "KeSubDescribeCn", "KeSuperDescribeEn", "KeSubDescribeEn", "UpdDate", "UpdUser", "Memo", "Link"};
//以下是属性变量


 /// <summary>
 /// 常量:"KeSubId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeSubId = "KeSubId";    //知识子类Id

 /// <summary>
 /// 常量:"KeSuperId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeSuperId = "KeSuperId";    //知识分类Id

 /// <summary>
 /// 常量:"KeSuperNameCn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeSuperNameCn = "KeSuperNameCn";    //知识分类名

 /// <summary>
 /// 常量:"KeSuperNameEn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeSuperNameEn = "KeSuperNameEn";    //知识分类英文名

 /// <summary>
 /// 常量:"KeSubNameCn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeSubNameCn = "KeSubNameCn";    //知识子类名

 /// <summary>
 /// 常量:"KeSubNameEn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeSubNameEn = "KeSubNameEn";    //知识子类英文名

 /// <summary>
 /// 常量:"KeSuperDescribeCn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeSuperDescribeCn = "KeSuperDescribeCn";    //知识分类描述

 /// <summary>
 /// 常量:"KeSubDescribeCn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeSubDescribeCn = "KeSubDescribeCn";    //知识子类描述

 /// <summary>
 /// 常量:"KeSuperDescribeEn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeSuperDescribeEn = "KeSuperDescribeEn";    //知识分类英文描述

 /// <summary>
 /// 常量:"KeSubDescribeEn"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeSubDescribeEn = "KeSubDescribeEn";    //知识子类英文描述

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

 /// <summary>
 /// 常量:"Link"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Link = "Link";    //相应链接
}

}