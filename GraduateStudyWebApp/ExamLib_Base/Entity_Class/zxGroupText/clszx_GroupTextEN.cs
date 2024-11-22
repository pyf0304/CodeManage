
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_GroupTextEN
 表名:zx_GroupText(01120734)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:56:53
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学小组课文(zxGroupText)
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
 /// 表zx_GroupText的关键字(GroupTextId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_GroupTextId_zx_GroupText
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strGroupTextId">表关键字</param>
public K_GroupTextId_zx_GroupText(string strGroupTextId)
{
if (IsValid(strGroupTextId)) Value = strGroupTextId;
else
{
Value = null;
}
}
private static bool IsValid(string strGroupTextId)
{
if (string.IsNullOrEmpty(strGroupTextId) == true) return false;
if (strGroupTextId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_GroupTextId_zx_GroupText]类型的对象</returns>
public static implicit operator K_GroupTextId_zx_GroupText(string value)
{
return new K_GroupTextId_zx_GroupText(value);
}
}
 /// <summary>
 /// 中学小组表(zx_GroupText)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_GroupTextEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_GroupText"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "GroupTextId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"GroupTextId", "GroupTextName", "IdCurrEduCls", "zxShareId", "UpdDate", "UpdUser", "Memo"};

protected string mstrGroupTextId;    //小组Id
protected string mstrGroupTextName;    //小组名称
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrzxShareId;    //分享Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_GroupTextEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("GroupTextId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strGroupTextId">关键字:小组Id</param>
public clszx_GroupTextEN(string strGroupTextId)
 {
strGroupTextId = strGroupTextId.Replace("'", "''");
if (strGroupTextId.Length > 8)
{
throw new Exception("在表:zx_GroupText中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strGroupTextId)  ==  true)
{
throw new Exception("在表:zx_GroupText中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strGroupTextId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrGroupTextId = strGroupTextId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("GroupTextId");
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
if (strAttributeName  ==  conzx_GroupText.GroupTextId)
{
return mstrGroupTextId;
}
else if (strAttributeName  ==  conzx_GroupText.GroupTextName)
{
return mstrGroupTextName;
}
else if (strAttributeName  ==  conzx_GroupText.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conzx_GroupText.zxShareId)
{
return mstrzxShareId;
}
else if (strAttributeName  ==  conzx_GroupText.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_GroupText.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_GroupText.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_GroupText.GroupTextId)
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_GroupText.GroupTextId);
}
else if (strAttributeName  ==  conzx_GroupText.GroupTextName)
{
mstrGroupTextName = value.ToString();
 AddUpdatedFld(conzx_GroupText.GroupTextName);
}
else if (strAttributeName  ==  conzx_GroupText.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_GroupText.IdCurrEduCls);
}
else if (strAttributeName  ==  conzx_GroupText.zxShareId)
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(conzx_GroupText.zxShareId);
}
else if (strAttributeName  ==  conzx_GroupText.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_GroupText.UpdDate);
}
else if (strAttributeName  ==  conzx_GroupText.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_GroupText.UpdUser);
}
else if (strAttributeName  ==  conzx_GroupText.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_GroupText.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_GroupText.GroupTextId  ==  AttributeName[intIndex])
{
return mstrGroupTextId;
}
else if (conzx_GroupText.GroupTextName  ==  AttributeName[intIndex])
{
return mstrGroupTextName;
}
else if (conzx_GroupText.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conzx_GroupText.zxShareId  ==  AttributeName[intIndex])
{
return mstrzxShareId;
}
else if (conzx_GroupText.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_GroupText.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_GroupText.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conzx_GroupText.GroupTextId  ==  AttributeName[intIndex])
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_GroupText.GroupTextId);
}
else if (conzx_GroupText.GroupTextName  ==  AttributeName[intIndex])
{
mstrGroupTextName = value.ToString();
 AddUpdatedFld(conzx_GroupText.GroupTextName);
}
else if (conzx_GroupText.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_GroupText.IdCurrEduCls);
}
else if (conzx_GroupText.zxShareId  ==  AttributeName[intIndex])
{
mstrzxShareId = value.ToString();
 AddUpdatedFld(conzx_GroupText.zxShareId);
}
else if (conzx_GroupText.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_GroupText.UpdDate);
}
else if (conzx_GroupText.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_GroupText.UpdUser);
}
else if (conzx_GroupText.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_GroupText.Memo);
}
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
 AddUpdatedFld(conzx_GroupText.GroupTextId);
}
}
/// <summary>
/// 小组名称(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupTextName
{
get
{
return mstrGroupTextName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupTextName = value;
}
else
{
 mstrGroupTextName = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_GroupText.GroupTextName);
}
}
/// <summary>
/// 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCurrEduCls
{
get
{
return mstrIdCurrEduCls;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCurrEduCls = value;
}
else
{
 mstrIdCurrEduCls = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_GroupText.IdCurrEduCls);
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
 AddUpdatedFld(conzx_GroupText.zxShareId);
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
 AddUpdatedFld(conzx_GroupText.UpdDate);
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
 AddUpdatedFld(conzx_GroupText.UpdUser);
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
 AddUpdatedFld(conzx_GroupText.Memo);
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
  return mstrGroupTextId;
 }
 }
}
 /// <summary>
 /// 中学小组表(zx_GroupText)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_GroupText
{
public const string _CurrTabName = "zx_GroupText"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "GroupTextId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"GroupTextId", "GroupTextName", "IdCurrEduCls", "zxShareId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"GroupTextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupTextId = "GroupTextId";    //小组Id

 /// <summary>
 /// 常量:"GroupTextName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupTextName = "GroupTextName";    //小组名称

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"zxShareId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxShareId = "zxShareId";    //分享Id

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