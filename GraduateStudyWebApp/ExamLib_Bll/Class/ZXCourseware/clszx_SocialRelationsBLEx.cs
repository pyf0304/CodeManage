
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_SocialRelationsBLEx
 表名:zx_SocialRelations(01120707)
 生成代码版本:2020.07.31.1
 生成日期:2020/08/03 09:32:21
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
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
public static class clszx_SocialRelationsBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objzx_SocialRelationsENS">源对象</param>
 /// <returns>目标对象=>clszx_SocialRelationsEN:objzx_SocialRelationsENT</returns>
 public static clszx_SocialRelationsENEx CopyToEx(this clszx_SocialRelationsEN objzx_SocialRelationsENS)
{
try
{
 clszx_SocialRelationsENEx objzx_SocialRelationsENT = new clszx_SocialRelationsENEx();
clszx_SocialRelationsBL.zx_SocialRelationsDA.CopyTo(objzx_SocialRelationsENS, objzx_SocialRelationsENT);
 return objzx_SocialRelationsENT;
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
 /// <param name = "objzx_SocialRelationsENS">源对象</param>
 /// <returns>目标对象=>clszx_SocialRelationsEN:objzx_SocialRelationsENT</returns>
 public static clszx_SocialRelationsEN CopyTo(this clszx_SocialRelationsENEx objzx_SocialRelationsENS)
{
try
{
 clszx_SocialRelationsEN objzx_SocialRelationsENT = new clszx_SocialRelationsEN();
clszx_SocialRelationsBL.CopyTo(objzx_SocialRelationsENS, objzx_SocialRelationsENT);
 return objzx_SocialRelationsENT;
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
 /// 中学社会关系(zx_SocialRelations)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clszx_SocialRelationsBLEx : clszx_SocialRelationsBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clszx_SocialRelationsDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clszx_SocialRelationsDAEx zx_SocialRelationsDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clszx_SocialRelationsDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objzx_SocialRelationsENS">源对象</param>
 /// <returns>目标对象=>clszx_SocialRelationsEN:objzx_SocialRelationsENT</returns>
 public static clszx_SocialRelationsENEx CopyToEx(clszx_SocialRelationsEN objzx_SocialRelationsENS)
{
try
{
 clszx_SocialRelationsENEx objzx_SocialRelationsENT = new clszx_SocialRelationsENEx();
clszx_SocialRelationsBL.zx_SocialRelationsDA.CopyTo(objzx_SocialRelationsENS, objzx_SocialRelationsENT);
 return objzx_SocialRelationsENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取扩展对象列表
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回扩展对象列表</returns>
public static List<clszx_SocialRelationsENEx> GetObjExLst(string strCondition)
{
List <clszx_SocialRelationsEN> arrObjLst = clszx_SocialRelationsBL.GetObjLst(strCondition);
List <clszx_SocialRelationsENEx> arrObjExLst = new List<clszx_SocialRelationsENEx>();
foreach (clszx_SocialRelationsEN objInFor in arrObjLst)
{
clszx_SocialRelationsENEx objzx_SocialRelationsENEx = new clszx_SocialRelationsENEx();
clszx_SocialRelationsBL.CopyTo(objInFor, objzx_SocialRelationsENEx);
arrObjExLst.Add(objzx_SocialRelationsENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strSocialId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clszx_SocialRelationsENEx GetObjExBySocialId(string strSocialId)
{
clszx_SocialRelationsEN objzx_SocialRelationsEN = clszx_SocialRelationsBL.GetObjByzxSocialId(strSocialId);
clszx_SocialRelationsENEx objzx_SocialRelationsENEx = new clszx_SocialRelationsENEx();
clszx_SocialRelationsBL.CopyTo(objzx_SocialRelationsEN, objzx_SocialRelationsENEx);
return objzx_SocialRelationsENEx;
}
}
}