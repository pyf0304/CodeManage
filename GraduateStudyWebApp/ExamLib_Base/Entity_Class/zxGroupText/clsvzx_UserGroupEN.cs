
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_UserGroupEN
 表名:vzx_UserGroup(01120843)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:49:38
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
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
 /// 表vzx_UserGroup的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vzx_UserGroup
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
public K_mId_vzx_UserGroup(long lngmId)
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
 /// <returns>返回:[K_mId_vzx_UserGroup]类型的对象</returns>
public static implicit operator K_mId_vzx_UserGroup(long value)
{
return new K_mId_vzx_UserGroup(value);
}
}
 /// <summary>
 /// vzx_UserGroup(vzx_UserGroup)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvzx_UserGroupEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vzx_UserGroup"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 18;
public static string[] AttributeName = new string[] {"TopicUserRoleName", "mId", "UserId", "UpdDate", "UpdUser", "Memo", "zxTopicUserRoleId", "GroupTextId", "zxColorId", "OrderNum", "ColorCode", "UserNo", "CollegeName", "GroupTextName", "IdXzCollege", "IdXzMajor", "MajorName", "UserName"};

protected string mstrTopicUserRoleName;    //主题用户角色
protected long mlngmId;    //mId
protected string mstrUserId;    //用户ID
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注
protected string mstrzxTopicUserRoleId;    //主键Id
protected string mstrGroupTextId;    //小组Id
protected string mstrzxColorId;    //颜色Id
protected int? mintOrderNum;    //序号
protected string mstrColorCode;    //颜色码
protected int? mintUserNo;    //用户号
protected string mstrCollegeName;    //学院名称
protected string mstrGroupTextName;    //小组名称
protected string mstrIdXzCollege;    //学院流水号
protected string mstrIdXzMajor;    //专业流水号
protected string mstrMajorName;    //专业名称
protected string mstrUserName;    //用户名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvzx_UserGroupEN()
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
public clsvzx_UserGroupEN(long lngmId)
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
if (strAttributeName  ==  convzx_UserGroup.TopicUserRoleName)
{
return mstrTopicUserRoleName;
}
else if (strAttributeName  ==  convzx_UserGroup.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convzx_UserGroup.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convzx_UserGroup.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convzx_UserGroup.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  convzx_UserGroup.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convzx_UserGroup.zxTopicUserRoleId)
{
return mstrzxTopicUserRoleId;
}
else if (strAttributeName  ==  convzx_UserGroup.GroupTextId)
{
return mstrGroupTextId;
}
else if (strAttributeName  ==  convzx_UserGroup.zxColorId)
{
return mstrzxColorId;
}
else if (strAttributeName  ==  convzx_UserGroup.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convzx_UserGroup.ColorCode)
{
return mstrColorCode;
}
else if (strAttributeName  ==  convzx_UserGroup.UserNo)
{
return mintUserNo;
}
else if (strAttributeName  ==  convzx_UserGroup.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  convzx_UserGroup.GroupTextName)
{
return mstrGroupTextName;
}
else if (strAttributeName  ==  convzx_UserGroup.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  convzx_UserGroup.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  convzx_UserGroup.MajorName)
{
return mstrMajorName;
}
else if (strAttributeName  ==  convzx_UserGroup.UserName)
{
return mstrUserName;
}
return null;
}
set
{
if (strAttributeName  ==  convzx_UserGroup.TopicUserRoleName)
{
mstrTopicUserRoleName = value.ToString();
 AddUpdatedFld(convzx_UserGroup.TopicUserRoleName);
}
else if (strAttributeName  ==  convzx_UserGroup.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_UserGroup.mId);
}
else if (strAttributeName  ==  convzx_UserGroup.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convzx_UserGroup.UserId);
}
else if (strAttributeName  ==  convzx_UserGroup.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_UserGroup.UpdDate);
}
else if (strAttributeName  ==  convzx_UserGroup.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_UserGroup.UpdUser);
}
else if (strAttributeName  ==  convzx_UserGroup.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_UserGroup.Memo);
}
else if (strAttributeName  ==  convzx_UserGroup.zxTopicUserRoleId)
{
mstrzxTopicUserRoleId = value.ToString();
 AddUpdatedFld(convzx_UserGroup.zxTopicUserRoleId);
}
else if (strAttributeName  ==  convzx_UserGroup.GroupTextId)
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(convzx_UserGroup.GroupTextId);
}
else if (strAttributeName  ==  convzx_UserGroup.zxColorId)
{
mstrzxColorId = value.ToString();
 AddUpdatedFld(convzx_UserGroup.zxColorId);
}
else if (strAttributeName  ==  convzx_UserGroup.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_UserGroup.OrderNum);
}
else if (strAttributeName  ==  convzx_UserGroup.ColorCode)
{
mstrColorCode = value.ToString();
 AddUpdatedFld(convzx_UserGroup.ColorCode);
}
else if (strAttributeName  ==  convzx_UserGroup.UserNo)
{
mintUserNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_UserGroup.UserNo);
}
else if (strAttributeName  ==  convzx_UserGroup.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convzx_UserGroup.CollegeName);
}
else if (strAttributeName  ==  convzx_UserGroup.GroupTextName)
{
mstrGroupTextName = value.ToString();
 AddUpdatedFld(convzx_UserGroup.GroupTextName);
}
else if (strAttributeName  ==  convzx_UserGroup.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convzx_UserGroup.IdXzCollege);
}
else if (strAttributeName  ==  convzx_UserGroup.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convzx_UserGroup.IdXzMajor);
}
else if (strAttributeName  ==  convzx_UserGroup.MajorName)
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convzx_UserGroup.MajorName);
}
else if (strAttributeName  ==  convzx_UserGroup.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convzx_UserGroup.UserName);
}
}
}
public object this[int intIndex]
{
get
{
if (convzx_UserGroup.TopicUserRoleName  ==  AttributeName[intIndex])
{
return mstrTopicUserRoleName;
}
else if (convzx_UserGroup.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convzx_UserGroup.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convzx_UserGroup.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convzx_UserGroup.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (convzx_UserGroup.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convzx_UserGroup.zxTopicUserRoleId  ==  AttributeName[intIndex])
{
return mstrzxTopicUserRoleId;
}
else if (convzx_UserGroup.GroupTextId  ==  AttributeName[intIndex])
{
return mstrGroupTextId;
}
else if (convzx_UserGroup.zxColorId  ==  AttributeName[intIndex])
{
return mstrzxColorId;
}
else if (convzx_UserGroup.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convzx_UserGroup.ColorCode  ==  AttributeName[intIndex])
{
return mstrColorCode;
}
else if (convzx_UserGroup.UserNo  ==  AttributeName[intIndex])
{
return mintUserNo;
}
else if (convzx_UserGroup.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (convzx_UserGroup.GroupTextName  ==  AttributeName[intIndex])
{
return mstrGroupTextName;
}
else if (convzx_UserGroup.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (convzx_UserGroup.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (convzx_UserGroup.MajorName  ==  AttributeName[intIndex])
{
return mstrMajorName;
}
else if (convzx_UserGroup.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
return null;
}
set
{
if (convzx_UserGroup.TopicUserRoleName  ==  AttributeName[intIndex])
{
mstrTopicUserRoleName = value.ToString();
 AddUpdatedFld(convzx_UserGroup.TopicUserRoleName);
}
else if (convzx_UserGroup.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_UserGroup.mId);
}
else if (convzx_UserGroup.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convzx_UserGroup.UserId);
}
else if (convzx_UserGroup.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convzx_UserGroup.UpdDate);
}
else if (convzx_UserGroup.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(convzx_UserGroup.UpdUser);
}
else if (convzx_UserGroup.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convzx_UserGroup.Memo);
}
else if (convzx_UserGroup.zxTopicUserRoleId  ==  AttributeName[intIndex])
{
mstrzxTopicUserRoleId = value.ToString();
 AddUpdatedFld(convzx_UserGroup.zxTopicUserRoleId);
}
else if (convzx_UserGroup.GroupTextId  ==  AttributeName[intIndex])
{
mstrGroupTextId = value.ToString();
 AddUpdatedFld(convzx_UserGroup.GroupTextId);
}
else if (convzx_UserGroup.zxColorId  ==  AttributeName[intIndex])
{
mstrzxColorId = value.ToString();
 AddUpdatedFld(convzx_UserGroup.zxColorId);
}
else if (convzx_UserGroup.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_UserGroup.OrderNum);
}
else if (convzx_UserGroup.ColorCode  ==  AttributeName[intIndex])
{
mstrColorCode = value.ToString();
 AddUpdatedFld(convzx_UserGroup.ColorCode);
}
else if (convzx_UserGroup.UserNo  ==  AttributeName[intIndex])
{
mintUserNo = TransNullToInt(value.ToString());
 AddUpdatedFld(convzx_UserGroup.UserNo);
}
else if (convzx_UserGroup.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(convzx_UserGroup.CollegeName);
}
else if (convzx_UserGroup.GroupTextName  ==  AttributeName[intIndex])
{
mstrGroupTextName = value.ToString();
 AddUpdatedFld(convzx_UserGroup.GroupTextName);
}
else if (convzx_UserGroup.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(convzx_UserGroup.IdXzCollege);
}
else if (convzx_UserGroup.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(convzx_UserGroup.IdXzMajor);
}
else if (convzx_UserGroup.MajorName  ==  AttributeName[intIndex])
{
mstrMajorName = value.ToString();
 AddUpdatedFld(convzx_UserGroup.MajorName);
}
else if (convzx_UserGroup.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convzx_UserGroup.UserName);
}
}
}

/// <summary>
/// 主题用户角色(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TopicUserRoleName
{
get
{
return mstrTopicUserRoleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTopicUserRoleName = value;
}
else
{
 mstrTopicUserRoleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_UserGroup.TopicUserRoleName);
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
 AddUpdatedFld(convzx_UserGroup.mId);
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
 AddUpdatedFld(convzx_UserGroup.UserId);
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
 AddUpdatedFld(convzx_UserGroup.UpdDate);
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
 AddUpdatedFld(convzx_UserGroup.UpdUser);
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
 AddUpdatedFld(convzx_UserGroup.Memo);
}
}
/// <summary>
/// 主键Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxTopicUserRoleId
{
get
{
return mstrzxTopicUserRoleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxTopicUserRoleId = value;
}
else
{
 mstrzxTopicUserRoleId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_UserGroup.zxTopicUserRoleId);
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
 AddUpdatedFld(convzx_UserGroup.GroupTextId);
}
}
/// <summary>
/// 颜色Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string zxColorId
{
get
{
return mstrzxColorId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrzxColorId = value;
}
else
{
 mstrzxColorId = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_UserGroup.zxColorId);
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
 AddUpdatedFld(convzx_UserGroup.OrderNum);
}
}
/// <summary>
/// 颜色码(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ColorCode
{
get
{
return mstrColorCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrColorCode = value;
}
else
{
 mstrColorCode = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_UserGroup.ColorCode);
}
}
/// <summary>
/// 用户号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? UserNo
{
get
{
return mintUserNo;
}
set
{
 mintUserNo = value;
//记录修改过的字段
 AddUpdatedFld(convzx_UserGroup.UserNo);
}
}
/// <summary>
/// 学院名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeName
{
get
{
return mstrCollegeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeName = value;
}
else
{
 mstrCollegeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_UserGroup.CollegeName);
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
 AddUpdatedFld(convzx_UserGroup.GroupTextName);
}
}
/// <summary>
/// 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzCollege
{
get
{
return mstrIdXzCollege;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzCollege = value;
}
else
{
 mstrIdXzCollege = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_UserGroup.IdXzCollege);
}
}
/// <summary>
/// 专业流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzMajor
{
get
{
return mstrIdXzMajor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzMajor = value;
}
else
{
 mstrIdXzMajor = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_UserGroup.IdXzMajor);
}
}
/// <summary>
/// 专业名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MajorName
{
get
{
return mstrMajorName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMajorName = value;
}
else
{
 mstrMajorName = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_UserGroup.MajorName);
}
}
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserName
{
get
{
return mstrUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserName = value;
}
else
{
 mstrUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convzx_UserGroup.UserName);
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
 /// vzx_UserGroup(vzx_UserGroup)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convzx_UserGroup
{
public const string _CurrTabName = "vzx_UserGroup"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TopicUserRoleName", "mId", "UserId", "UpdDate", "UpdUser", "Memo", "zxTopicUserRoleId", "GroupTextId", "zxColorId", "OrderNum", "ColorCode", "UserNo", "CollegeName", "GroupTextName", "IdXzCollege", "IdXzMajor", "MajorName", "UserName"};
//以下是属性变量


 /// <summary>
 /// 常量:"TopicUserRoleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TopicUserRoleName = "TopicUserRoleName";    //主题用户角色

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
 /// 常量:"zxTopicUserRoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxTopicUserRoleId = "zxTopicUserRoleId";    //主键Id

 /// <summary>
 /// 常量:"GroupTextId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupTextId = "GroupTextId";    //小组Id

 /// <summary>
 /// 常量:"zxColorId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string zxColorId = "zxColorId";    //颜色Id

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //序号

 /// <summary>
 /// 常量:"ColorCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ColorCode = "ColorCode";    //颜色码

 /// <summary>
 /// 常量:"UserNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserNo = "UserNo";    //用户号

 /// <summary>
 /// 常量:"CollegeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeName = "CollegeName";    //学院名称

 /// <summary>
 /// 常量:"GroupTextName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupTextName = "GroupTextName";    //小组名称

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

 /// <summary>
 /// 常量:"MajorName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MajorName = "MajorName";    //专业名称

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名
}

}