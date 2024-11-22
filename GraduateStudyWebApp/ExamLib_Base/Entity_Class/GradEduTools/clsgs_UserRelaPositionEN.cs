﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_UserRelaPositionEN
 表名:gs_UserRelaPosition(01120844)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:16:06
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
 /// 表gs_UserRelaPosition的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_gs_UserRelaPosition
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
public K_mId_gs_UserRelaPosition(long lngmId)
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
 /// <returns>返回:[K_mId_gs_UserRelaPosition]类型的对象</returns>
public static implicit operator K_mId_gs_UserRelaPosition(long value)
{
return new K_mId_gs_UserRelaPosition(value);
}
}
 /// <summary>
 /// 用户关系坐标位置(gs_UserRelaPosition)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_UserRelaPositionEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_UserRelaPosition"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"mId", "UserId", "UpdUser", "UpdDate", "IdCurrEduCls", "OrderNum", "XPosition", "YPosition", "Memo"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户ID
protected string mstrUpdUser;    //修改人
protected string mstrUpdDate;    //修改日期
protected string mstrIdCurrEduCls;    //教学班流水号
protected int? mintOrderNum;    //序号
protected float? mfltXPosition;    //X_坐标
protected float? mfltYPosition;    //Y_坐标
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_UserRelaPositionEN()
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
public clsgs_UserRelaPositionEN(long lngmId)
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
if (strAttributeName  ==  congs_UserRelaPosition.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  congs_UserRelaPosition.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  congs_UserRelaPosition.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  congs_UserRelaPosition.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  congs_UserRelaPosition.IdCurrEduCls)
{
return mstrIdCurrEduCls;
}
else if (strAttributeName  ==  congs_UserRelaPosition.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  congs_UserRelaPosition.XPosition)
{
return mfltXPosition;
}
else if (strAttributeName  ==  congs_UserRelaPosition.YPosition)
{
return mfltYPosition;
}
else if (strAttributeName  ==  congs_UserRelaPosition.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  congs_UserRelaPosition.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_UserRelaPosition.mId);
}
else if (strAttributeName  ==  congs_UserRelaPosition.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(congs_UserRelaPosition.UserId);
}
else if (strAttributeName  ==  congs_UserRelaPosition.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_UserRelaPosition.UpdUser);
}
else if (strAttributeName  ==  congs_UserRelaPosition.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_UserRelaPosition.UpdDate);
}
else if (strAttributeName  ==  congs_UserRelaPosition.IdCurrEduCls)
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(congs_UserRelaPosition.IdCurrEduCls);
}
else if (strAttributeName  ==  congs_UserRelaPosition.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_UserRelaPosition.OrderNum);
}
else if (strAttributeName  ==  congs_UserRelaPosition.XPosition)
{
mfltXPosition = TransNullToFloat(value.ToString());
 AddUpdatedFld(congs_UserRelaPosition.XPosition);
}
else if (strAttributeName  ==  congs_UserRelaPosition.YPosition)
{
mfltYPosition = TransNullToFloat(value.ToString());
 AddUpdatedFld(congs_UserRelaPosition.YPosition);
}
else if (strAttributeName  ==  congs_UserRelaPosition.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_UserRelaPosition.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_UserRelaPosition.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (congs_UserRelaPosition.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (congs_UserRelaPosition.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (congs_UserRelaPosition.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (congs_UserRelaPosition.IdCurrEduCls  ==  AttributeName[intIndex])
{
return mstrIdCurrEduCls;
}
else if (congs_UserRelaPosition.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (congs_UserRelaPosition.XPosition  ==  AttributeName[intIndex])
{
return mfltXPosition;
}
else if (congs_UserRelaPosition.YPosition  ==  AttributeName[intIndex])
{
return mfltYPosition;
}
else if (congs_UserRelaPosition.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (congs_UserRelaPosition.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_UserRelaPosition.mId);
}
else if (congs_UserRelaPosition.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(congs_UserRelaPosition.UserId);
}
else if (congs_UserRelaPosition.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_UserRelaPosition.UpdUser);
}
else if (congs_UserRelaPosition.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_UserRelaPosition.UpdDate);
}
else if (congs_UserRelaPosition.IdCurrEduCls  ==  AttributeName[intIndex])
{
mstrIdCurrEduCls = value.ToString();
 AddUpdatedFld(congs_UserRelaPosition.IdCurrEduCls);
}
else if (congs_UserRelaPosition.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_UserRelaPosition.OrderNum);
}
else if (congs_UserRelaPosition.XPosition  ==  AttributeName[intIndex])
{
mfltXPosition = TransNullToFloat(value.ToString());
 AddUpdatedFld(congs_UserRelaPosition.XPosition);
}
else if (congs_UserRelaPosition.YPosition  ==  AttributeName[intIndex])
{
mfltYPosition = TransNullToFloat(value.ToString());
 AddUpdatedFld(congs_UserRelaPosition.YPosition);
}
else if (congs_UserRelaPosition.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_UserRelaPosition.Memo);
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
 AddUpdatedFld(congs_UserRelaPosition.mId);
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
 AddUpdatedFld(congs_UserRelaPosition.UserId);
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
 AddUpdatedFld(congs_UserRelaPosition.UpdUser);
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
 AddUpdatedFld(congs_UserRelaPosition.UpdDate);
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
 AddUpdatedFld(congs_UserRelaPosition.IdCurrEduCls);
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
 AddUpdatedFld(congs_UserRelaPosition.OrderNum);
}
}
/// <summary>
/// X_坐标(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? XPosition
{
get
{
return mfltXPosition;
}
set
{
 mfltXPosition = value;
//记录修改过的字段
 AddUpdatedFld(congs_UserRelaPosition.XPosition);
}
}
/// <summary>
/// Y_坐标(说明:;字段类型:float;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public float? YPosition
{
get
{
return mfltYPosition;
}
set
{
 mfltYPosition = value;
//记录修改过的字段
 AddUpdatedFld(congs_UserRelaPosition.YPosition);
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
 AddUpdatedFld(congs_UserRelaPosition.Memo);
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
 /// 用户关系坐标位置(gs_UserRelaPosition)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_UserRelaPosition
{
public const string _CurrTabName = "gs_UserRelaPosition"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserId", "UpdUser", "UpdDate", "IdCurrEduCls", "OrderNum", "XPosition", "YPosition", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //mId

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

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
 /// 常量:"IdCurrEduCls"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCurrEduCls = "IdCurrEduCls";    //教学班流水号

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"XPosition"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string XPosition = "XPosition";    //X_坐标

 /// <summary>
 /// 常量:"YPosition"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string YPosition = "YPosition";    //Y_坐标

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}