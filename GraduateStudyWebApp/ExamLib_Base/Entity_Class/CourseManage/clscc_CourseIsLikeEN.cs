
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseIsLikeEN
 表名:cc_CourseIsLike(01120202)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:01:43
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程管理(CourseManage)
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
 /// 表cc_CourseIsLike的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_cc_CourseIsLike
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
public K_mId_cc_CourseIsLike(long lngmId)
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
 /// <returns>返回:[K_mId_cc_CourseIsLike]类型的对象</returns>
public static implicit operator K_mId_cc_CourseIsLike(long value)
{
return new K_mId_cc_CourseIsLike(value);
}
}
 /// <summary>
 /// 课程点赞日志(cc_CourseIsLike)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clscc_CourseIsLikeEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "cc_CourseIsLike"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"mId", "CourseId", "UserId", "IsLike", "RemarkRoleID", "CreateTime", "Memo"};

protected long mlngmId;    //mId
protected string mstrCourseId;    //课程Id
protected string mstrUserId;    //用户ID
protected bool mbolIsLike;    //IsLike
protected string mstrRemarkRoleID;    //RemarkRoleID
protected string mstrCreateTime;    //建立时间
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clscc_CourseIsLikeEN()
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
public clscc_CourseIsLikeEN(long lngmId)
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
if (strAttributeName  ==  concc_CourseIsLike.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  concc_CourseIsLike.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  concc_CourseIsLike.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  concc_CourseIsLike.IsLike)
{
return mbolIsLike;
}
else if (strAttributeName  ==  concc_CourseIsLike.RemarkRoleID)
{
return mstrRemarkRoleID;
}
else if (strAttributeName  ==  concc_CourseIsLike.CreateTime)
{
return mstrCreateTime;
}
else if (strAttributeName  ==  concc_CourseIsLike.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  concc_CourseIsLike.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseIsLike.mId);
}
else if (strAttributeName  ==  concc_CourseIsLike.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_CourseIsLike.CourseId);
}
else if (strAttributeName  ==  concc_CourseIsLike.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(concc_CourseIsLike.UserId);
}
else if (strAttributeName  ==  concc_CourseIsLike.IsLike)
{
mbolIsLike = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseIsLike.IsLike);
}
else if (strAttributeName  ==  concc_CourseIsLike.RemarkRoleID)
{
mstrRemarkRoleID = value.ToString();
 AddUpdatedFld(concc_CourseIsLike.RemarkRoleID);
}
else if (strAttributeName  ==  concc_CourseIsLike.CreateTime)
{
mstrCreateTime = value.ToString();
 AddUpdatedFld(concc_CourseIsLike.CreateTime);
}
else if (strAttributeName  ==  concc_CourseIsLike.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_CourseIsLike.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (concc_CourseIsLike.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (concc_CourseIsLike.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (concc_CourseIsLike.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (concc_CourseIsLike.IsLike  ==  AttributeName[intIndex])
{
return mbolIsLike;
}
else if (concc_CourseIsLike.RemarkRoleID  ==  AttributeName[intIndex])
{
return mstrRemarkRoleID;
}
else if (concc_CourseIsLike.CreateTime  ==  AttributeName[intIndex])
{
return mstrCreateTime;
}
else if (concc_CourseIsLike.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (concc_CourseIsLike.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(concc_CourseIsLike.mId);
}
else if (concc_CourseIsLike.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(concc_CourseIsLike.CourseId);
}
else if (concc_CourseIsLike.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(concc_CourseIsLike.UserId);
}
else if (concc_CourseIsLike.IsLike  ==  AttributeName[intIndex])
{
mbolIsLike = TransNullToBool(value.ToString());
 AddUpdatedFld(concc_CourseIsLike.IsLike);
}
else if (concc_CourseIsLike.RemarkRoleID  ==  AttributeName[intIndex])
{
mstrRemarkRoleID = value.ToString();
 AddUpdatedFld(concc_CourseIsLike.RemarkRoleID);
}
else if (concc_CourseIsLike.CreateTime  ==  AttributeName[intIndex])
{
mstrCreateTime = value.ToString();
 AddUpdatedFld(concc_CourseIsLike.CreateTime);
}
else if (concc_CourseIsLike.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(concc_CourseIsLike.Memo);
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
 AddUpdatedFld(concc_CourseIsLike.mId);
}
}
/// <summary>
/// 课程Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseId
{
get
{
return mstrCourseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseId = value;
}
else
{
 mstrCourseId = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseIsLike.CourseId);
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
 AddUpdatedFld(concc_CourseIsLike.UserId);
}
}
/// <summary>
/// IsLike(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsLike
{
get
{
return mbolIsLike;
}
set
{
 mbolIsLike = value;
//记录修改过的字段
 AddUpdatedFld(concc_CourseIsLike.IsLike);
}
}
/// <summary>
/// RemarkRoleID(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RemarkRoleID
{
get
{
return mstrRemarkRoleID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRemarkRoleID = value;
}
else
{
 mstrRemarkRoleID = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseIsLike.RemarkRoleID);
}
}
/// <summary>
/// 建立时间(说明:;字段类型:varchar;字段长度:16;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateTime
{
get
{
return mstrCreateTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateTime = value;
}
else
{
 mstrCreateTime = value;
}
//记录修改过的字段
 AddUpdatedFld(concc_CourseIsLike.CreateTime);
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
 AddUpdatedFld(concc_CourseIsLike.Memo);
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
 /// 课程点赞日志(cc_CourseIsLike)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class concc_CourseIsLike
{
public const string _CurrTabName = "cc_CourseIsLike"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "CourseId", "UserId", "IsLike", "RemarkRoleID", "CreateTime", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"IsLike"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsLike = "IsLike";    //IsLike

 /// <summary>
 /// 常量:"RemarkRoleID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RemarkRoleID = "RemarkRoleID";    //RemarkRoleID

 /// <summary>
 /// 常量:"CreateTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateTime = "CreateTime";    //建立时间

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}