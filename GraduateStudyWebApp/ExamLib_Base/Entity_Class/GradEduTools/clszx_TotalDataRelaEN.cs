
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TotalDataRelaEN
 表名:zx_TotalDataRela(01120790)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:55:56
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
 /// 表zx_TotalDataRela的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_zx_TotalDataRela
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_zx_TotalDataRela(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_zx_TotalDataRela]类型的对象</returns>
public static implicit operator K_mId_zx_TotalDataRela(long value)
{
return new K_mId_zx_TotalDataRela(value);
}
}
 /// <summary>
 /// 中学各观点总数据关系表(zx_TotalDataRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_TotalDataRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_TotalDataRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"mId", "IdCurrEduCls", "UpdDate", "UpdUser", "Memo", "TdRelaTypeId", "TotalDataId1", "TotalDataId2"};

protected long mlngmId;    //mId
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrTdRelaTypeId;    //总数据关系类型Id
protected string mstrTotalDataId1;    //TotalDataId1
protected string mstrTotalDataId2;    //TotalDataId2

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_TotalDataRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:mId</param>
public clszx_TotalDataRelaEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  conzx_TotalDataRela.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conzx_TotalDataRela.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conzx_TotalDataRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_TotalDataRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_TotalDataRela.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conzx_TotalDataRela.TdRelaTypeId)
{
return mstrTdRelaTypeId;
}
else if (strAttributeName  ==  conzx_TotalDataRela.TotalDataId1)
{
return mstrTotalDataId1;
}
else if (strAttributeName  ==  conzx_TotalDataRela.TotalDataId2)
{
return mstrTotalDataId2;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_TotalDataRela.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_TotalDataRela.mId);
}
else if (strAttributeName  ==  conzx_TotalDataRela.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_TotalDataRela.IdCurrEduCls);
}
else if (strAttributeName  ==  conzx_TotalDataRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_TotalDataRela.UpdDate);
}
else if (strAttributeName  ==  conzx_TotalDataRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_TotalDataRela.UpdUser);
}
else if (strAttributeName  ==  conzx_TotalDataRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_TotalDataRela.Memo);
}
else if (strAttributeName  ==  conzx_TotalDataRela.TdRelaTypeId)
{
mstrTdRelaTypeId = value.ToString();
 AddUpdatedFld(conzx_TotalDataRela.TdRelaTypeId);
}
else if (strAttributeName  ==  conzx_TotalDataRela.TotalDataId1)
{
mstrTotalDataId1 = value.ToString();
 AddUpdatedFld(conzx_TotalDataRela.TotalDataId1);
}
else if (strAttributeName  ==  conzx_TotalDataRela.TotalDataId2)
{
mstrTotalDataId2 = value.ToString();
 AddUpdatedFld(conzx_TotalDataRela.TotalDataId2);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_TotalDataRela.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conzx_TotalDataRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conzx_TotalDataRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_TotalDataRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_TotalDataRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conzx_TotalDataRela.TdRelaTypeId  ==  AttributeName[intIndex])
{
return mstrTdRelaTypeId;
}
else if (conzx_TotalDataRela.TotalDataId1  ==  AttributeName[intIndex])
{
return mstrTotalDataId1;
}
else if (conzx_TotalDataRela.TotalDataId2  ==  AttributeName[intIndex])
{
return mstrTotalDataId2;
}
return null;
}
set
{
if (conzx_TotalDataRela.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_TotalDataRela.mId);
}
else if (conzx_TotalDataRela.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_TotalDataRela.IdCurrEduCls);
}
else if (conzx_TotalDataRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_TotalDataRela.UpdDate);
}
else if (conzx_TotalDataRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_TotalDataRela.UpdUser);
}
else if (conzx_TotalDataRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_TotalDataRela.Memo);
}
else if (conzx_TotalDataRela.TdRelaTypeId  ==  AttributeName[intIndex])
{
mstrTdRelaTypeId = value.ToString();
 AddUpdatedFld(conzx_TotalDataRela.TdRelaTypeId);
}
else if (conzx_TotalDataRela.TotalDataId1  ==  AttributeName[intIndex])
{
mstrTotalDataId1 = value.ToString();
 AddUpdatedFld(conzx_TotalDataRela.TotalDataId1);
}
else if (conzx_TotalDataRela.TotalDataId2  ==  AttributeName[intIndex])
{
mstrTotalDataId2 = value.ToString();
 AddUpdatedFld(conzx_TotalDataRela.TotalDataId2);
}
}
}

/// <summary>
/// mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(conzx_TotalDataRela.mId);
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
 AddUpdatedFld(conzx_TotalDataRela.IdCurrEduCls);
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
 AddUpdatedFld(conzx_TotalDataRela.UpdDate);
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
 AddUpdatedFld(conzx_TotalDataRela.UpdUser);
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
 AddUpdatedFld(conzx_TotalDataRela.Memo);
}
}
/// <summary>
/// 总数据关系类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TdRelaTypeId
{
get
{
return mstrTdRelaTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTdRelaTypeId = value;
}
else
{
 mstrTdRelaTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_TotalDataRela.TdRelaTypeId);
}
}
/// <summary>
/// TotalDataId1(说明:;字段类型:char;字段长度:12;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TotalDataId1
{
get
{
return mstrTotalDataId1;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTotalDataId1 = value;
}
else
{
 mstrTotalDataId1 = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_TotalDataRela.TotalDataId1);
}
}
/// <summary>
/// TotalDataId2(说明:;字段类型:char;字段长度:12;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TotalDataId2
{
get
{
return mstrTotalDataId2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTotalDataId2 = value;
}
else
{
 mstrTotalDataId2 = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_TotalDataRela.TotalDataId2);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// 中学各观点总数据关系表(zx_TotalDataRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_TotalDataRela
{
public const string _CurrTabName = "zx_TotalDataRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "IdCurrEduCls", "UpdDate", "UpdUser", "Memo", "TdRelaTypeId", "TotalDataId1", "TotalDataId2"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

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
 /// 常量:"TdRelaTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TdRelaTypeId = "TdRelaTypeId";    //总数据关系类型Id

 /// <summary>
 /// 常量:"TotalDataId1"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TotalDataId1 = "TotalDataId1";    //TotalDataId1

 /// <summary>
 /// 常量:"TotalDataId2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TotalDataId2 = "TotalDataId2";    //TotalDataId2
}

}