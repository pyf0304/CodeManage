
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_PaperParagraphBLEx
 表名:gs_PaperParagraph(01120744)
 生成代码版本:2020.09.09.1
 生成日期:2020/09/23 19:04:47
 生成者:yy
 生成服务器IP:192.168.1.10
 工程名称:问卷调查
 工程ID:0112
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文
 模块英文名:GraduateEduPaper
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
public static class clsgs_PaperParagraphBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objgs_PaperParagraphENS">源对象</param>
 /// <returns>目标对象=>clsgs_PaperParagraphEN:objgs_PaperParagraphENT</returns>
 public static clsgs_PaperParagraphENEx CopyToEx(this clsgs_PaperParagraphEN objgs_PaperParagraphENS)
{
try
{
 clsgs_PaperParagraphENEx objgs_PaperParagraphENT = new clsgs_PaperParagraphENEx();
clsgs_PaperParagraphBL.gs_PaperParagraphDA.CopyTo(objgs_PaperParagraphENS, objgs_PaperParagraphENT);
 return objgs_PaperParagraphENT;
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
 /// <param name = "objgs_PaperParagraphENS">源对象</param>
 /// <returns>目标对象=>clsgs_PaperParagraphEN:objgs_PaperParagraphENT</returns>
 public static clsgs_PaperParagraphEN CopyTo(this clsgs_PaperParagraphENEx objgs_PaperParagraphENS)
{
try
{
 clsgs_PaperParagraphEN objgs_PaperParagraphENT = new clsgs_PaperParagraphEN();
clsgs_PaperParagraphBL.CopyTo(objgs_PaperParagraphENS, objgs_PaperParagraphENT);
 return objgs_PaperParagraphENT;
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
 /// 论文段落表(gs_PaperParagraph)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsgs_PaperParagraphBLEx : clsgs_PaperParagraphBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsgs_PaperParagraphDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsgs_PaperParagraphDAEx gs_PaperParagraphDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsgs_PaperParagraphDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objgs_PaperParagraphENS">源对象</param>
 /// <returns>目标对象=>clsgs_PaperParagraphEN:objgs_PaperParagraphENT</returns>
 public static clsgs_PaperParagraphENEx CopyToEx(clsgs_PaperParagraphEN objgs_PaperParagraphENS)
{
try
{
 clsgs_PaperParagraphENEx objgs_PaperParagraphENT = new clsgs_PaperParagraphENEx();
clsgs_PaperParagraphBL.gs_PaperParagraphDA.CopyTo(objgs_PaperParagraphENS, objgs_PaperParagraphENT);
 return objgs_PaperParagraphENT;
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
public static List<clsgs_PaperParagraphENEx> GetObjExLst(string strCondition)
{
List <clsgs_PaperParagraphEN> arrObjLst = clsgs_PaperParagraphBL.GetObjLst(strCondition);
List <clsgs_PaperParagraphENEx> arrObjExLst = new List<clsgs_PaperParagraphENEx>();
foreach (clsgs_PaperParagraphEN objInFor in arrObjLst)
{
clsgs_PaperParagraphENEx objgs_PaperParagraphENEx = new clsgs_PaperParagraphENEx();
clsgs_PaperParagraphBL.CopyTo(objInFor, objgs_PaperParagraphENEx);
arrObjExLst.Add(objgs_PaperParagraphENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strParagraphId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsgs_PaperParagraphENEx GetObjExByParagraphId(string strParagraphId)
{
clsgs_PaperParagraphEN objgs_PaperParagraphEN = clsgs_PaperParagraphBL.GetObjByParagraphId(strParagraphId);
clsgs_PaperParagraphENEx objgs_PaperParagraphENEx = new clsgs_PaperParagraphENEx();
clsgs_PaperParagraphBL.CopyTo(objgs_PaperParagraphEN, objgs_PaperParagraphENEx);
return objgs_PaperParagraphENEx;
}
}
}