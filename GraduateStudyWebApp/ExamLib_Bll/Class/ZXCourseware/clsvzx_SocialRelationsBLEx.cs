
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_SocialRelationsBLEx
 表名:vzx_SocialRelations(01120852)
 生成代码版本:2021.06.06.1
 生成日期:2021/06/15 00:00:56
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理
 模块英文名:ZXCourseware
 框架-层名:业务逻辑扩展层(BusinessLogicEx)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;
using ExamLib.BusinessLogic;


namespace ExamLib.BusinessLogicEx
{
public static class clsvzx_SocialRelationsBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsENS">源对象</param>
 /// <returns>目标对象=>clsvzx_SocialRelationsEN:objvzx_SocialRelationsENT</returns>
 public static clsvzx_SocialRelationsENEx CopyToEx(this clsvzx_SocialRelationsEN objvzx_SocialRelationsENS)
{
try
{
 clsvzx_SocialRelationsENEx objvzx_SocialRelationsENT = new clsvzx_SocialRelationsENEx();
clsvzx_SocialRelationsBL.vzx_SocialRelationsDA.CopyTo(objvzx_SocialRelationsENS, objvzx_SocialRelationsENT);
 return objvzx_SocialRelationsENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
 /// </summary>
 /// <param name = "objvzx_SocialRelationsENS">源对象</param>
 /// <returns>目标对象=>clsvzx_SocialRelationsEN:objvzx_SocialRelationsENT</returns>
 public static clsvzx_SocialRelationsEN CopyTo(this clsvzx_SocialRelationsENEx objvzx_SocialRelationsENS)
{
try
{
 clsvzx_SocialRelationsEN objvzx_SocialRelationsENT = new clsvzx_SocialRelationsEN();
clsvzx_SocialRelationsBL.CopyTo(objvzx_SocialRelationsENS, objvzx_SocialRelationsENT);
 return objvzx_SocialRelationsENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// vzx_SocialRelations(vzx_SocialRelations)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvzx_SocialRelationsBLEx : clsvzx_SocialRelationsBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvzx_SocialRelationsDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvzx_SocialRelationsDAEx vzx_SocialRelationsDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvzx_SocialRelationsDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 根据条件获取扩展对象列表
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回扩展对象列表</returns>
public static List<clsvzx_SocialRelationsENEx> GetObjExLst(string strCondition)
{
List <clsvzx_SocialRelationsEN> arrObjLst = clsvzx_SocialRelationsBL.GetObjLst(strCondition);
List <clsvzx_SocialRelationsENEx> arrObjExLst = new List<clsvzx_SocialRelationsENEx>();
foreach (clsvzx_SocialRelationsEN objInFor in arrObjLst)
{
clsvzx_SocialRelationsENEx objvzx_SocialRelationsENEx = new clsvzx_SocialRelationsENEx();
clsvzx_SocialRelationsBL.CopyTo(objInFor, objvzx_SocialRelationsENEx);
arrObjExLst.Add(objvzx_SocialRelationsENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strzxSocialId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvzx_SocialRelationsENEx GetObjExByzxSocialId(string strzxSocialId)
{
clsvzx_SocialRelationsEN objvzx_SocialRelationsEN = clsvzx_SocialRelationsBL.GetObjByzxSocialId(strzxSocialId);
clsvzx_SocialRelationsENEx objvzx_SocialRelationsENEx = new clsvzx_SocialRelationsENEx();
clsvzx_SocialRelationsBL.CopyTo(objvzx_SocialRelationsEN, objvzx_SocialRelationsENEx);
return objvzx_SocialRelationsENEx;
}
}
}