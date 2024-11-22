
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ViewsClassificationEN
 表名:zx_ViewsClassification(01120806)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:55:42
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
 /// 表zx_ViewsClassification的关键字(zxClassificationId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_zxClassificationId_zx_ViewsClassification
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strzxClassificationId">表关键字</param>
public K_zxClassificationId_zx_ViewsClassification(string strzxClassificationId)
{
if (IsValid(strzxClassificationId)) Value = strzxClassificationId;
else
{
Value = null;
}
}
private static bool IsValid(string strzxClassificationId)
{
if (string.IsNullOrEmpty(strzxClassificationId) == true) return false;
if (strzxClassificationId.Length != 10) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_zxClassificationId_zx_ViewsClassification]类型的对象</returns>
public static implicit operator K_zxClassificationId_zx_ViewsClassification(string value)
{
return new K_zxClassificationId_zx_ViewsClassification(value);
}
}
 /// <summary>
 /// 中学各观点分类表(zx_ViewsClassification)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_ViewsClassificationEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_ViewsClassification"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "zxClassificationId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"zxClassificationId", "ClassificationName", "GroupTextId", "UpdDate", "UpdUser", "Memo", "OrderNum"};

protected string mstrzxClassificationId;    //分类Id
protected string mstrClassificationName;    //分类名称
protected string mstrGroupTextId;    //小组Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected int? mintOrderNum;    //序号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_ViewsClassificationEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxClassificationId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strzxClassificationId">关键字:分类Id</param>
public clszx_ViewsClassificationEN(string strzxClassificationId)
 {
strzxClassificationId = strzxClassificationId.Replace("'", "''");
if (strzxClassificationId.Length > 10)
{
throw new Exception("在表:zx_ViewsClassification中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strzxClassificationId)  ==  true)
{
throw new Exception("在表:zx_ViewsClassification中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxClassificationId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrzxClassificationId = strzxClassificationId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("zxClassificationId");
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
if (strAttributeName  ==  conzx_ViewsClassification.zxClassificationId)
{
return mstrzxClassificationId;
}
else if (strAttributeName  ==  conzx_ViewsClassification.ClassificationName)
{
return mstrClassificationName;
}
else if (strAttributeName  ==  conzx_ViewsClassification.GroupTextId)
{
return mstrGroupTextId;
}
else if (strAttributeName  ==  conzx_ViewsClassification.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_ViewsClassification.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_ViewsClassification.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conzx_ViewsClassification.OrderNum)
{
return mintOrderNum;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_ViewsClassification.zxClassificationId)
{
mstrzxClassificationId = value.ToString();
 AddUpdatedFld(conzx_ViewsClassification.zxClassificationId);
}
else if (strAttributeName  ==  conzx_ViewsClassification.ClassificationName)
{
mstrClassificationName = value.ToString();
 AddUpdatedFld(conzx_ViewsClassification.ClassificationName);
}
else if (strAttributeName  ==  conzx_ViewsClassification.GroupTextId)
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_ViewsClassification.GroupTextId);
}
else if (strAttributeName  ==  conzx_ViewsClassification.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_ViewsClassification.UpdDate);
}
else if (strAttributeName  ==  conzx_ViewsClassification.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_ViewsClassification.UpdUser);
}
else if (strAttributeName  ==  conzx_ViewsClassification.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_ViewsClassification.Memo);
}
else if (strAttributeName  ==  conzx_ViewsClassification.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_ViewsClassification.OrderNum);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_ViewsClassification.zxClassificationId  ==  AttributeName[intIndex])
{
return mstrzxClassificationId;
}
else if (conzx_ViewsClassification.ClassificationName  ==  AttributeName[intIndex])
{
return mstrClassificationName;
}
else if (conzx_ViewsClassification.GroupTextId  ==  AttributeName[intIndex])
{
return mstrGroupTextId;
}
else if (conzx_ViewsClassification.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_ViewsClassification.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_ViewsClassification.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conzx_ViewsClassification.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
return null;
}
set
{
if (conzx_ViewsClassification.zxClassificationId  ==  AttributeName[intIndex])
{
mstrzxClassificationId = value.ToString();
 AddUpdatedFld(conzx_ViewsClassification.zxClassificationId);
}
else if (conzx_ViewsClassification.ClassificationName  ==  AttributeName[intIndex])
{
mstrClassificationName = value.ToString();
 AddUpdatedFld(conzx_ViewsClassification.ClassificationName);
}
else if (conzx_ViewsClassification.GroupTextId  ==  AttributeName[intIndex])
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_ViewsClassification.GroupTextId);
}
else if (conzx_ViewsClassification.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_ViewsClassification.UpdDate);
}
else if (conzx_ViewsClassification.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_ViewsClassification.UpdUser);
}
else if (conzx_ViewsClassification.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_ViewsClassification.Memo);
}
else if (conzx_ViewsClassification.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_ViewsClassification.OrderNum);
}
}
}

/// <summary>
/// 分类Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxClassificationId
{
get
{
return mstrzxClassificationId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxClassificationId = value;
}
else
{
 mstrzxClassificationId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_ViewsClassification.zxClassificationId);
}
}
/// <summary>
/// 分类名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClassificationName
{
get
{
return mstrClassificationName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClassificationName = value;
}
else
{
 mstrClassificationName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_ViewsClassification.ClassificationName);
}
}
/// <summary>
/// 小组Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupTextId
{
get
{
return mstrGroupTextId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupTextId = value;
}
else
{
 mstrGroupTextId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_ViewsClassification.GroupTextId);
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
 AddUpdatedFld(conzx_ViewsClassification.UpdDate);
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
 AddUpdatedFld(conzx_ViewsClassification.UpdUser);
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
 AddUpdatedFld(conzx_ViewsClassification.Memo);
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
 AddUpdatedFld(conzx_ViewsClassification.OrderNum);
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
  return mstrzxClassificationId;
 }
 }
}
 /// <summary>
 /// 中学各观点分类表(zx_ViewsClassification)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_ViewsClassification
{
public const string _CurrTabName = "zx_ViewsClassification"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "zxClassificationId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"zxClassificationId", "ClassificationName", "GroupTextId", "UpdDate", "UpdUser", "Memo", "OrderNum"};
//以下是属性变量


 /// <summary>
 /// 常量:"zxClassificationId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxClassificationId = "zxClassificationId";    //分类Id

 /// <summary>
 /// 常量:"ClassificationName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassificationName = "ClassificationName";    //分类名称

 /// <summary>
 /// 常量:"GroupTextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupTextId = "GroupTextId";    //小组Id

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
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号
}

}