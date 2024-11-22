
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_KnowledgesLogic_UserEN
 表名:gs_KnowledgesLogic_User(01120889)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:44
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// 表gs_KnowledgesLogic_User的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_gs_KnowledgesLogic_User
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
public K_mId_gs_KnowledgesLogic_User(long lngmId)
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
 /// <returns>返回:[K_mId_gs_KnowledgesLogic_User]类型的对象</returns>
public static implicit operator K_mId_gs_KnowledgesLogic_User(long value)
{
return new K_mId_gs_KnowledgesLogic_User(value);
}
}
 /// <summary>
 /// 知识点逻辑点_个性化用户(gs_KnowledgesLogic_User)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsgs_KnowledgesLogic_UserEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "gs_KnowledgesLogic_User"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"mId", "UserId", "KnowledgeGraphId", "CourseKnowledgeId", "ClassName", "CourseId", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //mId
protected string mstrUserId;    //用户ID
protected string mstrKnowledgeGraphId;    //知识点图Id
protected string mstrCourseKnowledgeId;    //知识点Id
protected string mstrClassName;    //样式名称
protected string mstrCourseId;    //课程Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsgs_KnowledgesLogic_UserEN()
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
public clsgs_KnowledgesLogic_UserEN(long lngmId)
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
if (strAttributeName  ==  congs_KnowledgesLogic_User.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  congs_KnowledgesLogic_User.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  congs_KnowledgesLogic_User.KnowledgeGraphId)
{
return mstrKnowledgeGraphId;
}
else if (strAttributeName  ==  congs_KnowledgesLogic_User.CourseKnowledgeId)
{
return mstrCourseKnowledgeId;
}
else if (strAttributeName  ==  congs_KnowledgesLogic_User.ClassName)
{
return mstrClassName;
}
else if (strAttributeName  ==  congs_KnowledgesLogic_User.CourseId)
{
return mstrCourseId;
}
else if (strAttributeName  ==  congs_KnowledgesLogic_User.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  congs_KnowledgesLogic_User.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  congs_KnowledgesLogic_User.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  congs_KnowledgesLogic_User.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_KnowledgesLogic_User.mId);
}
else if (strAttributeName  ==  congs_KnowledgesLogic_User.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic_User.UserId);
}
else if (strAttributeName  ==  congs_KnowledgesLogic_User.KnowledgeGraphId)
{
mstrKnowledgeGraphId = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic_User.KnowledgeGraphId);
}
else if (strAttributeName  ==  congs_KnowledgesLogic_User.CourseKnowledgeId)
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic_User.CourseKnowledgeId);
}
else if (strAttributeName  ==  congs_KnowledgesLogic_User.ClassName)
{
mstrClassName = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic_User.ClassName);
}
else if (strAttributeName  ==  congs_KnowledgesLogic_User.CourseId)
{
mstrCourseId = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic_User.CourseId);
}
else if (strAttributeName  ==  congs_KnowledgesLogic_User.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic_User.UpdDate);
}
else if (strAttributeName  ==  congs_KnowledgesLogic_User.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic_User.UpdUser);
}
else if (strAttributeName  ==  congs_KnowledgesLogic_User.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic_User.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (congs_KnowledgesLogic_User.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (congs_KnowledgesLogic_User.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (congs_KnowledgesLogic_User.KnowledgeGraphId  ==  AttributeName[intIndex])
{
return mstrKnowledgeGraphId;
}
else if (congs_KnowledgesLogic_User.CourseKnowledgeId  ==  AttributeName[intIndex])
{
return mstrCourseKnowledgeId;
}
else if (congs_KnowledgesLogic_User.ClassName  ==  AttributeName[intIndex])
{
return mstrClassName;
}
else if (congs_KnowledgesLogic_User.CourseId  ==  AttributeName[intIndex])
{
return mstrCourseId;
}
else if (congs_KnowledgesLogic_User.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (congs_KnowledgesLogic_User.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (congs_KnowledgesLogic_User.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (congs_KnowledgesLogic_User.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(congs_KnowledgesLogic_User.mId);
}
else if (congs_KnowledgesLogic_User.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic_User.UserId);
}
else if (congs_KnowledgesLogic_User.KnowledgeGraphId  ==  AttributeName[intIndex])
{
mstrKnowledgeGraphId = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic_User.KnowledgeGraphId);
}
else if (congs_KnowledgesLogic_User.CourseKnowledgeId  ==  AttributeName[intIndex])
{
mstrCourseKnowledgeId = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic_User.CourseKnowledgeId);
}
else if (congs_KnowledgesLogic_User.ClassName  ==  AttributeName[intIndex])
{
mstrClassName = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic_User.ClassName);
}
else if (congs_KnowledgesLogic_User.CourseId  ==  AttributeName[intIndex])
{
mstrCourseId = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic_User.CourseId);
}
else if (congs_KnowledgesLogic_User.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic_User.UpdDate);
}
else if (congs_KnowledgesLogic_User.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic_User.UpdUser);
}
else if (congs_KnowledgesLogic_User.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(congs_KnowledgesLogic_User.Memo);
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
 AddUpdatedFld(congs_KnowledgesLogic_User.mId);
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
 AddUpdatedFld(congs_KnowledgesLogic_User.UserId);
}
}
/// <summary>
/// 知识点图Id(说明:;字段类型:char;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KnowledgeGraphId
{
get
{
return mstrKnowledgeGraphId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKnowledgeGraphId = value;
}
else
{
 mstrKnowledgeGraphId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_KnowledgesLogic_User.KnowledgeGraphId);
}
}
/// <summary>
/// 知识点Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseKnowledgeId
{
get
{
return mstrCourseKnowledgeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseKnowledgeId = value;
}
else
{
 mstrCourseKnowledgeId = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_KnowledgesLogic_User.CourseKnowledgeId);
}
}
/// <summary>
/// 样式名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClassName
{
get
{
return mstrClassName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClassName = value;
}
else
{
 mstrClassName = value;
}
//记录修改过的字段
 AddUpdatedFld(congs_KnowledgesLogic_User.ClassName);
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
 AddUpdatedFld(congs_KnowledgesLogic_User.CourseId);
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
 AddUpdatedFld(congs_KnowledgesLogic_User.UpdDate);
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
 AddUpdatedFld(congs_KnowledgesLogic_User.UpdUser);
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
 AddUpdatedFld(congs_KnowledgesLogic_User.Memo);
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
 /// 知识点逻辑点_个性化用户(gs_KnowledgesLogic_User)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class congs_KnowledgesLogic_User
{
public const string _CurrTabName = "gs_KnowledgesLogic_User"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserId", "KnowledgeGraphId", "CourseKnowledgeId", "ClassName", "CourseId", "UpdDate", "UpdUser", "Memo"};
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
 /// 常量:"KnowledgeGraphId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KnowledgeGraphId = "KnowledgeGraphId";    //知识点图Id

 /// <summary>
 /// 常量:"CourseKnowledgeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseKnowledgeId = "CourseKnowledgeId";    //知识点Id

 /// <summary>
 /// 常量:"ClassName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClassName = "ClassName";    //样式名称

 /// <summary>
 /// 常量:"CourseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseId = "CourseId";    //课程Id

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