
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_TagsBLEx
 表名:gs_Tags(01120714)
 生成代码版本:2020.08.04.1
 生成日期:2020/08/05 18:35:41
 生成者:yy
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题
 模块英文名:GraduateEduTopic
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
public static class clsgs_TagsBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objgs_TagsENS">源对象</param>
 /// <returns>目标对象=>clsgs_TagsEN:objgs_TagsENT</returns>
 public static clsgs_TagsENEx CopyToEx(this clsgs_TagsEN objgs_TagsENS)
{
try
{
 clsgs_TagsENEx objgs_TagsENT = new clsgs_TagsENEx();
clsgs_TagsBL.gs_TagsDA.CopyTo(objgs_TagsENS, objgs_TagsENT);
 return objgs_TagsENT;
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
 /// <param name = "objgs_TagsENS">源对象</param>
 /// <returns>目标对象=>clsgs_TagsEN:objgs_TagsENT</returns>
 public static clsgs_TagsEN CopyTo(this clsgs_TagsENEx objgs_TagsENS)
{
try
{
 clsgs_TagsEN objgs_TagsENT = new clsgs_TagsEN();
clsgs_TagsBL.CopyTo(objgs_TagsENS, objgs_TagsENT);
 return objgs_TagsENT;
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
 /// gs_Tags(gs_Tags)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsgs_TagsBLEx : clsgs_TagsBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsgs_TagsDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsgs_TagsDAEx gs_TagsDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsgs_TagsDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objgs_TagsENS">源对象</param>
 /// <returns>目标对象=>clsgs_TagsEN:objgs_TagsENT</returns>
 public static clsgs_TagsENEx CopyToEx(clsgs_TagsEN objgs_TagsENS)
{
try
{
 clsgs_TagsENEx objgs_TagsENT = new clsgs_TagsENEx();
clsgs_TagsBL.gs_TagsDA.CopyTo(objgs_TagsENS, objgs_TagsENT);
 return objgs_TagsENT;
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
public static List<clsgs_TagsENEx> GetObjExLst(string strCondition)
{
List <clsgs_TagsEN> arrObjLst = clsgs_TagsBL.GetObjLst(strCondition);
List <clsgs_TagsENEx> arrObjExLst = new List<clsgs_TagsENEx>();
foreach (clsgs_TagsEN objInFor in arrObjLst)
{
clsgs_TagsENEx objgs_TagsENEx = new clsgs_TagsENEx();
clsgs_TagsBL.CopyTo(objInFor, objgs_TagsENEx);
arrObjExLst.Add(objgs_TagsENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strTagsId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsgs_TagsENEx GetObjExByTagsId(string strTagsId)
{
clsgs_TagsEN objgs_TagsEN = clsgs_TagsBL.GetObjByTagsId(strTagsId);
clsgs_TagsENEx objgs_TagsENEx = new clsgs_TagsENEx();
clsgs_TagsBL.CopyTo(objgs_TagsEN, objgs_TagsENEx);
return objgs_TagsENEx;
}
}
}