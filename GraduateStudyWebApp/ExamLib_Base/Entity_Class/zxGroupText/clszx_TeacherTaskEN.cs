
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TeacherTaskEN
 表名:zx_TeacherTask(01120730)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:59:55
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
 /// 表zx_TeacherTask的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_zx_TeacherTask
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
public K_mId_zx_TeacherTask(long lngmId)
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
 /// <returns>返回:[K_mId_zx_TeacherTask]类型的对象</returns>
public static implicit operator K_mId_zx_TeacherTask(long value)
{
return new K_mId_zx_TeacherTask(value);
}
}
 /// <summary>
 /// 中学任务布置(zx_TeacherTask)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clszx_TeacherTaskEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "zx_TeacherTask"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"mId", "IdCurrEduCls", "MissionStatement", "MissionRequirement", "UpdDate", "UpdUser", "Memo", "GroupTextId"};

protected long mlngmId;    //mId
protected string mstrIdCurrEduCls;    //教学班流水号
protected string mstrMissionStatement;    //任务说明
protected string mstrMissionRequirement;    //任务要求
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrGroupTextId;    //小组Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clszx_TeacherTaskEN()
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
public clszx_TeacherTaskEN(long lngmId)
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
if (strAttributeName  ==  conzx_TeacherTask.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conzx_TeacherTask.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  conzx_TeacherTask.MissionStatement)
{
return mstrMissionStatement;
}
else if (strAttributeName  ==  conzx_TeacherTask.MissionRequirement)
{
return mstrMissionRequirement;
}
else if (strAttributeName  ==  conzx_TeacherTask.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conzx_TeacherTask.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conzx_TeacherTask.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conzx_TeacherTask.GroupTextId)
{
return mstrGroupTextId;
}
return null;
}
set
{
if (strAttributeName  ==  conzx_TeacherTask.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_TeacherTask.mId);
}
else if (strAttributeName  ==  conzx_TeacherTask.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_TeacherTask.IdCurrEduCls);
}
else if (strAttributeName  ==  conzx_TeacherTask.MissionStatement)
{
mstrMissionStatement = value.ToString();
 AddUpdatedFld(conzx_TeacherTask.MissionStatement);
}
else if (strAttributeName  ==  conzx_TeacherTask.MissionRequirement)
{
mstrMissionRequirement = value.ToString();
 AddUpdatedFld(conzx_TeacherTask.MissionRequirement);
}
else if (strAttributeName  ==  conzx_TeacherTask.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_TeacherTask.UpdDate);
}
else if (strAttributeName  ==  conzx_TeacherTask.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_TeacherTask.UpdUser);
}
else if (strAttributeName  ==  conzx_TeacherTask.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_TeacherTask.Memo);
}
else if (strAttributeName  ==  conzx_TeacherTask.GroupTextId)
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_TeacherTask.GroupTextId);
}
}
}
public object this[int intIndex]
{
get
{
if (conzx_TeacherTask.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conzx_TeacherTask.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (conzx_TeacherTask.MissionStatement  ==  AttributeName[intIndex])
{
return mstrMissionStatement;
}
else if (conzx_TeacherTask.MissionRequirement  ==  AttributeName[intIndex])
{
return mstrMissionRequirement;
}
else if (conzx_TeacherTask.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conzx_TeacherTask.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conzx_TeacherTask.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conzx_TeacherTask.GroupTextId  ==  AttributeName[intIndex])
{
return mstrGroupTextId;
}
return null;
}
set
{
if (conzx_TeacherTask.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conzx_TeacherTask.mId);
}
else if (conzx_TeacherTask.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(conzx_TeacherTask.IdCurrEduCls);
}
else if (conzx_TeacherTask.MissionStatement  ==  AttributeName[intIndex])
{
mstrMissionStatement = value.ToString();
 AddUpdatedFld(conzx_TeacherTask.MissionStatement);
}
else if (conzx_TeacherTask.MissionRequirement  ==  AttributeName[intIndex])
{
mstrMissionRequirement = value.ToString();
 AddUpdatedFld(conzx_TeacherTask.MissionRequirement);
}
else if (conzx_TeacherTask.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conzx_TeacherTask.UpdDate);
}
else if (conzx_TeacherTask.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conzx_TeacherTask.UpdUser);
}
else if (conzx_TeacherTask.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conzx_TeacherTask.Memo);
}
else if (conzx_TeacherTask.GroupTextId  ==  AttributeName[intIndex])
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(conzx_TeacherTask.GroupTextId);
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
 AddUpdatedFld(conzx_TeacherTask.mId);
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
 AddUpdatedFld(conzx_TeacherTask.IdCurrEduCls);
}
}
/// <summary>
/// 任务说明(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MissionStatement
{
get
{
return mstrMissionStatement;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMissionStatement = value;
}
else
{
 mstrMissionStatement = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_TeacherTask.MissionStatement);
}
}
/// <summary>
/// 任务要求(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MissionRequirement
{
get
{
return mstrMissionRequirement;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMissionRequirement = value;
}
else
{
 mstrMissionRequirement = value;
}
//记录修改过的字段
 AddUpdatedFld(conzx_TeacherTask.MissionRequirement);
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
 AddUpdatedFld(conzx_TeacherTask.UpdDate);
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
 AddUpdatedFld(conzx_TeacherTask.UpdUser);
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
 AddUpdatedFld(conzx_TeacherTask.Memo);
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
 AddUpdatedFld(conzx_TeacherTask.GroupTextId);
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
 /// 中学任务布置(zx_TeacherTask)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conzx_TeacherTask
{
public const string _CurrTabName = "zx_TeacherTask"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "IdCurrEduCls", "MissionStatement", "MissionRequirement", "UpdDate", "UpdUser", "Memo", "GroupTextId"};
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
 /// 常量:"MissionStatement"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MissionStatement = "MissionStatement";    //任务说明

 /// <summary>
 /// 常量:"MissionRequirement"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MissionRequirement = "MissionRequirement";    //任务要求

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
 /// 常量:"GroupTextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupTextId = "GroupTextId";    //小组Id
}

}