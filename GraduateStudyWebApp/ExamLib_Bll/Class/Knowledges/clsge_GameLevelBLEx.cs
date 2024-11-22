
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_GameLevelBLEx
 表名:ge_GameLevel(01120904)
 生成代码版本:2021.03.27.2
 生成日期:2021/03/27 16:42:16
 生成者:yy
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关
 模块英文名:Knowledges
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
public static class clsge_GameLevelBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objge_GameLevelENS">源对象</param>
 /// <returns>目标对象=>clsge_GameLevelEN:objge_GameLevelENT</returns>
 public static clsge_GameLevelENEx CopyToEx(this clsge_GameLevelEN objge_GameLevelENS)
{
try
{
 clsge_GameLevelENEx objge_GameLevelENT = new clsge_GameLevelENEx();
clsge_GameLevelBL.ge_GameLevelDA.CopyTo(objge_GameLevelENS, objge_GameLevelENT);
 return objge_GameLevelENT;
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
 /// <param name = "objge_GameLevelENS">源对象</param>
 /// <returns>目标对象=>clsge_GameLevelEN:objge_GameLevelENT</returns>
 public static clsge_GameLevelEN CopyTo(this clsge_GameLevelENEx objge_GameLevelENS)
{
try
{
 clsge_GameLevelEN objge_GameLevelENT = new clsge_GameLevelEN();
clsge_GameLevelBL.CopyTo(objge_GameLevelENS, objge_GameLevelENT);
 return objge_GameLevelENT;
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
 /// 游戏关卡表(ge_GameLevel)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsge_GameLevelBLEx : clsge_GameLevelBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsge_GameLevelDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsge_GameLevelDAEx ge_GameLevelDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsge_GameLevelDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objge_GameLevelENS">源对象</param>
 /// <returns>目标对象=>clsge_GameLevelEN:objge_GameLevelENT</returns>
 public static clsge_GameLevelENEx CopyToEx(clsge_GameLevelEN objge_GameLevelENS)
{
try
{
 clsge_GameLevelENEx objge_GameLevelENT = new clsge_GameLevelENEx();
clsge_GameLevelBL.ge_GameLevelDA.CopyTo(objge_GameLevelENS, objge_GameLevelENT);
 return objge_GameLevelENT;
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
public static List<clsge_GameLevelENEx> GetObjExLst(string strCondition)
{
List <clsge_GameLevelEN> arrObjLst = clsge_GameLevelBL.GetObjLst(strCondition);
List <clsge_GameLevelENEx> arrObjExLst = new List<clsge_GameLevelENEx>();
foreach (clsge_GameLevelEN objInFor in arrObjLst)
{
clsge_GameLevelENEx objge_GameLevelENEx = new clsge_GameLevelENEx();
clsge_GameLevelBL.CopyTo(objInFor, objge_GameLevelENEx);
arrObjExLst.Add(objge_GameLevelENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strGameLevelId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsge_GameLevelENEx GetObjExByGameLevelId(string strGameLevelId)
{
clsge_GameLevelEN objge_GameLevelEN = clsge_GameLevelBL.GetObjByGameLevelId(strGameLevelId);
clsge_GameLevelENEx objge_GameLevelENEx = new clsge_GameLevelENEx();
clsge_GameLevelBL.CopyTo(objge_GameLevelEN, objge_GameLevelENEx);
return objge_GameLevelENEx;
}

        public static bool IsPassed(double fltCredits, string strGameLevelId, string strCourseId)
        {
            var objge_GameLevel_Sel = clsge_GameLevelBL.GetObjByGameLevelIdCache(strGameLevelId, strCourseId);

            //用户正确数 比对总数 得到百分比超过60，那么则关卡为通过；
            double dbNumber = fltCredits / (objge_GameLevel_Sel.QuestionNum * objge_GameLevel_Sel.QuestionScore ?? 0);
            if (dbNumber >= 0.60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}