
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsLiveRoomEN
 表名:LiveRoom(01120263)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:16:24
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
 /// 表LiveRoom的关键字(LiveRoomID)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_LiveRoomID_LiveRoom
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngLiveRoomID">表关键字</param>
public K_LiveRoomID_LiveRoom(long lngLiveRoomID)
{
if (IsValid(lngLiveRoomID)) Value = lngLiveRoomID;
else
{
Value = 0;
}
}
private static bool IsValid(long lngLiveRoomID)
{
if (lngLiveRoomID == 0) return false;
if (lngLiveRoomID == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_LiveRoomID_LiveRoom]类型的对象</returns>
public static implicit operator K_LiveRoomID_LiveRoom(long value)
{
return new K_LiveRoomID_LiveRoom(value);
}
}
 /// <summary>
 /// 直播教室(LiveRoom)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsLiveRoomEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "LiveRoom"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "LiveRoomID"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"LiveRoomID", "RoomName", "LiveCode", "School", "Link", "PublishSite", "VideoName", "CourseContent", "Instructors", "IsOpen", "Memo", "LiveRoomSite"};

protected long mlngLiveRoomID;    //房间ID
protected string mstrRoomName;    //房间名称
protected string mstrLiveCode;    //直播代码
protected string mstrSchool;    //School
protected string mstrLink;    //相应链接
protected string mstrPublishSite;    //发布点
protected string mstrVideoName;    //视频名称
protected string mstrCourseContent;    //授课内容
protected string mstrInstructors;    //授课教师
protected bool mbolIsOpen;    //是否公开
protected string mstrMemo;    //备注
protected string mstrLiveRoomSite;    //LiveRoomSite

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsLiveRoomEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("LiveRoomID");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngLiveRoomID">关键字:房间ID</param>
public clsLiveRoomEN(long lngLiveRoomID)
 {
 if (lngLiveRoomID  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngLiveRoomID = lngLiveRoomID;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("LiveRoomID");
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
if (strAttributeName  ==  conLiveRoom.LiveRoomID)
{
return mlngLiveRoomID;
}
else if (strAttributeName  ==  conLiveRoom.RoomName)
{
return mstrRoomName;
}
else if (strAttributeName  ==  conLiveRoom.LiveCode)
{
return mstrLiveCode;
}
else if (strAttributeName  ==  conLiveRoom.School)
{
return mstrSchool;
}
else if (strAttributeName  ==  conLiveRoom.Link)
{
return mstrLink;
}
else if (strAttributeName  ==  conLiveRoom.PublishSite)
{
return mstrPublishSite;
}
else if (strAttributeName  ==  conLiveRoom.VideoName)
{
return mstrVideoName;
}
else if (strAttributeName  ==  conLiveRoom.CourseContent)
{
return mstrCourseContent;
}
else if (strAttributeName  ==  conLiveRoom.Instructors)
{
return mstrInstructors;
}
else if (strAttributeName  ==  conLiveRoom.IsOpen)
{
return mbolIsOpen;
}
else if (strAttributeName  ==  conLiveRoom.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conLiveRoom.LiveRoomSite)
{
return mstrLiveRoomSite;
}
return null;
}
set
{
if (strAttributeName  ==  conLiveRoom.LiveRoomID)
{
mlngLiveRoomID = TransNullToInt(value.ToString());
 AddUpdatedFld(conLiveRoom.LiveRoomID);
}
else if (strAttributeName  ==  conLiveRoom.RoomName)
{
mstrRoomName = value.ToString();
 AddUpdatedFld(conLiveRoom.RoomName);
}
else if (strAttributeName  ==  conLiveRoom.LiveCode)
{
mstrLiveCode = value.ToString();
 AddUpdatedFld(conLiveRoom.LiveCode);
}
else if (strAttributeName  ==  conLiveRoom.School)
{
mstrSchool = value.ToString();
 AddUpdatedFld(conLiveRoom.School);
}
else if (strAttributeName  ==  conLiveRoom.Link)
{
mstrLink = value.ToString();
 AddUpdatedFld(conLiveRoom.Link);
}
else if (strAttributeName  ==  conLiveRoom.PublishSite)
{
mstrPublishSite = value.ToString();
 AddUpdatedFld(conLiveRoom.PublishSite);
}
else if (strAttributeName  ==  conLiveRoom.VideoName)
{
mstrVideoName = value.ToString();
 AddUpdatedFld(conLiveRoom.VideoName);
}
else if (strAttributeName  ==  conLiveRoom.CourseContent)
{
mstrCourseContent = value.ToString();
 AddUpdatedFld(conLiveRoom.CourseContent);
}
else if (strAttributeName  ==  conLiveRoom.Instructors)
{
mstrInstructors = value.ToString();
 AddUpdatedFld(conLiveRoom.Instructors);
}
else if (strAttributeName  ==  conLiveRoom.IsOpen)
{
mbolIsOpen = TransNullToBool(value.ToString());
 AddUpdatedFld(conLiveRoom.IsOpen);
}
else if (strAttributeName  ==  conLiveRoom.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conLiveRoom.Memo);
}
else if (strAttributeName  ==  conLiveRoom.LiveRoomSite)
{
mstrLiveRoomSite = value.ToString();
 AddUpdatedFld(conLiveRoom.LiveRoomSite);
}
}
}
public object this[int intIndex]
{
get
{
if (conLiveRoom.LiveRoomID  ==  AttributeName[intIndex])
{
return mlngLiveRoomID;
}
else if (conLiveRoom.RoomName  ==  AttributeName[intIndex])
{
return mstrRoomName;
}
else if (conLiveRoom.LiveCode  ==  AttributeName[intIndex])
{
return mstrLiveCode;
}
else if (conLiveRoom.School  ==  AttributeName[intIndex])
{
return mstrSchool;
}
else if (conLiveRoom.Link  ==  AttributeName[intIndex])
{
return mstrLink;
}
else if (conLiveRoom.PublishSite  ==  AttributeName[intIndex])
{
return mstrPublishSite;
}
else if (conLiveRoom.VideoName  ==  AttributeName[intIndex])
{
return mstrVideoName;
}
else if (conLiveRoom.CourseContent  ==  AttributeName[intIndex])
{
return mstrCourseContent;
}
else if (conLiveRoom.Instructors  ==  AttributeName[intIndex])
{
return mstrInstructors;
}
else if (conLiveRoom.IsOpen  ==  AttributeName[intIndex])
{
return mbolIsOpen;
}
else if (conLiveRoom.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conLiveRoom.LiveRoomSite  ==  AttributeName[intIndex])
{
return mstrLiveRoomSite;
}
return null;
}
set
{
if (conLiveRoom.LiveRoomID  ==  AttributeName[intIndex])
{
mlngLiveRoomID = TransNullToInt(value.ToString());
 AddUpdatedFld(conLiveRoom.LiveRoomID);
}
else if (conLiveRoom.RoomName  ==  AttributeName[intIndex])
{
mstrRoomName = value.ToString();
 AddUpdatedFld(conLiveRoom.RoomName);
}
else if (conLiveRoom.LiveCode  ==  AttributeName[intIndex])
{
mstrLiveCode = value.ToString();
 AddUpdatedFld(conLiveRoom.LiveCode);
}
else if (conLiveRoom.School  ==  AttributeName[intIndex])
{
mstrSchool = value.ToString();
 AddUpdatedFld(conLiveRoom.School);
}
else if (conLiveRoom.Link  ==  AttributeName[intIndex])
{
mstrLink = value.ToString();
 AddUpdatedFld(conLiveRoom.Link);
}
else if (conLiveRoom.PublishSite  ==  AttributeName[intIndex])
{
mstrPublishSite = value.ToString();
 AddUpdatedFld(conLiveRoom.PublishSite);
}
else if (conLiveRoom.VideoName  ==  AttributeName[intIndex])
{
mstrVideoName = value.ToString();
 AddUpdatedFld(conLiveRoom.VideoName);
}
else if (conLiveRoom.CourseContent  ==  AttributeName[intIndex])
{
mstrCourseContent = value.ToString();
 AddUpdatedFld(conLiveRoom.CourseContent);
}
else if (conLiveRoom.Instructors  ==  AttributeName[intIndex])
{
mstrInstructors = value.ToString();
 AddUpdatedFld(conLiveRoom.Instructors);
}
else if (conLiveRoom.IsOpen  ==  AttributeName[intIndex])
{
mbolIsOpen = TransNullToBool(value.ToString());
 AddUpdatedFld(conLiveRoom.IsOpen);
}
else if (conLiveRoom.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conLiveRoom.Memo);
}
else if (conLiveRoom.LiveRoomSite  ==  AttributeName[intIndex])
{
mstrLiveRoomSite = value.ToString();
 AddUpdatedFld(conLiveRoom.LiveRoomSite);
}
}
}

/// <summary>
/// 房间ID(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long LiveRoomID
{
get
{
return mlngLiveRoomID;
}
set
{
 mlngLiveRoomID = value;
//记录修改过的字段
 AddUpdatedFld(conLiveRoom.LiveRoomID);
}
}
/// <summary>
/// 房间名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RoomName
{
get
{
return mstrRoomName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRoomName = value;
}
else
{
 mstrRoomName = value;
}
//记录修改过的字段
 AddUpdatedFld(conLiveRoom.RoomName);
}
}
/// <summary>
/// 直播代码(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LiveCode
{
get
{
return mstrLiveCode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLiveCode = value;
}
else
{
 mstrLiveCode = value;
}
//记录修改过的字段
 AddUpdatedFld(conLiveRoom.LiveCode);
}
}
/// <summary>
/// School(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string School
{
get
{
return mstrSchool;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchool = value;
}
else
{
 mstrSchool = value;
}
//记录修改过的字段
 AddUpdatedFld(conLiveRoom.School);
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
 AddUpdatedFld(conLiveRoom.Link);
}
}
/// <summary>
/// 发布点(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PublishSite
{
get
{
return mstrPublishSite;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPublishSite = value;
}
else
{
 mstrPublishSite = value;
}
//记录修改过的字段
 AddUpdatedFld(conLiveRoom.PublishSite);
}
}
/// <summary>
/// 视频名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string VideoName
{
get
{
return mstrVideoName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrVideoName = value;
}
else
{
 mstrVideoName = value;
}
//记录修改过的字段
 AddUpdatedFld(conLiveRoom.VideoName);
}
}
/// <summary>
/// 授课内容(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CourseContent
{
get
{
return mstrCourseContent;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCourseContent = value;
}
else
{
 mstrCourseContent = value;
}
//记录修改过的字段
 AddUpdatedFld(conLiveRoom.CourseContent);
}
}
/// <summary>
/// 授课教师(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Instructors
{
get
{
return mstrInstructors;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrInstructors = value;
}
else
{
 mstrInstructors = value;
}
//记录修改过的字段
 AddUpdatedFld(conLiveRoom.Instructors);
}
}
/// <summary>
/// 是否公开(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsOpen
{
get
{
return mbolIsOpen;
}
set
{
 mbolIsOpen = value;
//记录修改过的字段
 AddUpdatedFld(conLiveRoom.IsOpen);
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
 AddUpdatedFld(conLiveRoom.Memo);
}
}
/// <summary>
/// LiveRoomSite(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LiveRoomSite
{
get
{
return mstrLiveRoomSite;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLiveRoomSite = value;
}
else
{
 mstrLiveRoomSite = value;
}
//记录修改过的字段
 AddUpdatedFld(conLiveRoom.LiveRoomSite);
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
  return mlngLiveRoomID.ToString();
 }
 }
}
 /// <summary>
 /// 直播教室(LiveRoom)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conLiveRoom
{
public const string _CurrTabName = "LiveRoom"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "LiveRoomID"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"LiveRoomID", "RoomName", "LiveCode", "School", "Link", "PublishSite", "VideoName", "CourseContent", "Instructors", "IsOpen", "Memo", "LiveRoomSite"};
//以下是属性变量


 /// <summary>
 /// 常量:"LiveRoomID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LiveRoomID = "LiveRoomID";    //房间ID

 /// <summary>
 /// 常量:"RoomName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoomName = "RoomName";    //房间名称

 /// <summary>
 /// 常量:"LiveCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LiveCode = "LiveCode";    //直播代码

 /// <summary>
 /// 常量:"School"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string School = "School";    //School

 /// <summary>
 /// 常量:"Link"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Link = "Link";    //相应链接

 /// <summary>
 /// 常量:"PublishSite"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PublishSite = "PublishSite";    //发布点

 /// <summary>
 /// 常量:"VideoName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string VideoName = "VideoName";    //视频名称

 /// <summary>
 /// 常量:"CourseContent"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CourseContent = "CourseContent";    //授课内容

 /// <summary>
 /// 常量:"Instructors"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Instructors = "Instructors";    //授课教师

 /// <summary>
 /// 常量:"IsOpen"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsOpen = "IsOpen";    //是否公开

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"LiveRoomSite"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LiveRoomSite = "LiveRoomSite";    //LiveRoomSite
}

}