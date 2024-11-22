
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ViewpointDA
 表名:zx_Viewpoint(01120705)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:56:12
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
 框架-层名:数据处理层(CS)(DALCode)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commdb;
using ExamLib.Entity;

namespace ExamLib.DAL
{
 /// <summary>
 /// 中学观点表(zx_Viewpoint)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clszx_ViewpointDA : clsCommBase4DA
{
 /// <summary>
 /// 错误信息
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
protected const string EXCEPTION_MSG = "出错:"; //there was an error in the method. please see the Application Log for details.";
 /// <summary>
 /// 模块名称
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
protected string mstrModuleName;
//以下是属性变量

 /// <summary>
 /// 当前表名
 /// </summary>
 public override string _CurrTabName
 {
 get
 {
 return clszx_ViewpointEN._CurrTabName;
 }
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.DALCode4CSharp:Gen_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName  ==  true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clszx_ViewpointEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_ViewpointEN._ConnectString);
}
return objSQL;
}


 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetSpecSQLObj_Obj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public override clsSpecSQLforSql GetSpecSQLObj_Obj() 
{
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName  ==  true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
 if (string.IsNullOrEmpty(clszx_ViewpointEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clszx_ViewpointEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strzxViewpointId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strzxViewpointId)
{
strzxViewpointId = strzxViewpointId.Replace("'", "''");
if (strzxViewpointId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:zx_Viewpoint中,检查关键字,长度不正确!(clszx_ViewpointDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strzxViewpointId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:zx_Viewpoint中,关键字不能为空 或 null!(clszx_ViewpointDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxViewpointId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clszx_ViewpointDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_ViewpointDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
strSQL = "Select * from zx_Viewpoint where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_zx_Viewpoint(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clszx_ViewpointDA: GetDataTable_zx_Viewpoint)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
strSQL = "Select * from zx_Viewpoint where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(给定表名)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByTabName_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strTabName">表名</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable(string strCondition, string strTabName)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clszx_ViewpointDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clszx_ViewpointDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
strSQL = "Select * from zx_Viewpoint where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByTabName_S_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, string strTabName, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clszx_ViewpointDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Top(stuTopPara objTopPara)
{
 return GetDataTable_Top(objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, string strOrderBy)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clszx_ViewpointDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_Viewpoint where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_Viewpoint where {1} order by {2}", intTopSize, strCondition, strOrderBy);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S_Exclude)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clszx_ViewpointDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from zx_Viewpoint where {1}", intTopSize, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByPager_S)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clszx_ViewpointDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var IsAscOrDesc = "Asc";
if (strOrderBy.IndexOf(" Asc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Asc", "");
IsAscOrDesc = "Asc";
}
else if (strOrderBy.IndexOf(" Desc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Desc", "");
IsAscOrDesc = "Desc";
}
var arrPart = strOrderBy.Split('|');
if (arrPart.Length != 3)
{
throw new Exception(string.Format("在带有特殊排序分页查询中,strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} zx_Viewpoint.* from zx_Viewpoint Left Join {1} on {2} where {3} and zx_Viewpoint.zxViewpointId not in (Select top {5} zx_Viewpoint.zxViewpointId from zx_Viewpoint Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_Viewpoint where {1} and zxViewpointId not in (Select top {2} zxViewpointId from zx_Viewpoint where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_Viewpoint where {1} and zxViewpointId not in (Select top {3} zxViewpointId from zx_Viewpoint where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByPager_S_Exclude)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clszx_ViewpointDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var IsAscOrDesc = "Asc";
if (strOrderBy.IndexOf(" Asc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Asc", "");
IsAscOrDesc = "Asc";
}
else if (strOrderBy.IndexOf(" Desc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Desc", "");
IsAscOrDesc = "Desc";
}
var arrPart = strOrderBy.Split('|');
if (arrPart.Length != 3)
{
throw new Exception(string.Format("在带有特殊排序分页查询中,strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} zx_Viewpoint.* from zx_Viewpoint Left Join {1} on {2} where {3} and zx_Viewpoint.zxViewpointId not in (Select top {5} zx_Viewpoint.zxViewpointId from zx_Viewpoint Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_Viewpoint where {1} and zxViewpointId not in (Select top {2} zxViewpointId from zx_Viewpoint where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_Viewpoint where {1} and zxViewpointId not in (Select top {3} zxViewpointId from zx_Viewpoint where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 #endregion 获取数据表的DataTable

 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clszx_ViewpointEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clszx_ViewpointDA:GetObjLst)", objException.Message));
}
List<clszx_ViewpointEN> arrObjLst = new List<clszx_ViewpointEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
strSQL = "Select * from zx_Viewpoint where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointEN objzx_ViewpointEN = new clszx_ViewpointEN();
try
{
objzx_ViewpointEN.zxViewpointId = objRow[conzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointEN.ViewpointName = objRow[conzx_Viewpoint.ViewpointName] == DBNull.Value ? null : objRow[conzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称
objzx_ViewpointEN.ViewpointContent = objRow[conzx_Viewpoint.ViewpointContent] == DBNull.Value ? null : objRow[conzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容
objzx_ViewpointEN.zxViewpointTypeId = objRow[conzx_Viewpoint.zxViewpointTypeId] == DBNull.Value ? null : objRow[conzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objzx_ViewpointEN.Reason = objRow[conzx_Viewpoint.Reason] == DBNull.Value ? null : objRow[conzx_Viewpoint.Reason].ToString().Trim(); //理由
objzx_ViewpointEN.Source = objRow[conzx_Viewpoint.Source] == DBNull.Value ? null : objRow[conzx_Viewpoint.Source].ToString().Trim(); //来源
objzx_ViewpointEN.VPProposePeople = objRow[conzx_Viewpoint.VPProposePeople] == DBNull.Value ? null : objRow[conzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objzx_ViewpointEN.IsSubmit = TransNullToBool(objRow[conzx_Viewpoint.IsSubmit].ToString().Trim()); //是否提交
objzx_ViewpointEN.UserTypeId = objRow[conzx_Viewpoint.UserTypeId] == DBNull.Value ? null : objRow[conzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objzx_ViewpointEN.TextId = objRow[conzx_Viewpoint.TextId] == DBNull.Value ? null : objRow[conzx_Viewpoint.TextId].ToString().Trim(); //课件Id
objzx_ViewpointEN.VoteCount = objRow[conzx_Viewpoint.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Viewpoint.VoteCount].ToString().Trim()); //点赞计数
objzx_ViewpointEN.AppraiseCount = objRow[conzx_Viewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Viewpoint.AppraiseCount].ToString().Trim()); //评论数
objzx_ViewpointEN.Score = objRow[conzx_Viewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Viewpoint.Score].ToString().Trim()); //评分
objzx_ViewpointEN.StuScore = objRow[conzx_Viewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Viewpoint.StuScore].ToString().Trim()); //学生平均分
objzx_ViewpointEN.TeaScore = objRow[conzx_Viewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Viewpoint.TeaScore].ToString().Trim()); //教师评分
objzx_ViewpointEN.IdCurrEduCls = objRow[conzx_Viewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ViewpointEN.PdfContent = objRow[conzx_Viewpoint.PdfContent] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容
objzx_ViewpointEN.PdfPageNum = objRow[conzx_Viewpoint.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Viewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ViewpointEN.CitationCount = objRow[conzx_Viewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Viewpoint.CitationCount].ToString().Trim()); //引用统计
objzx_ViewpointEN.VersionCount = objRow[conzx_Viewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Viewpoint.VersionCount].ToString().Trim()); //版本统计
objzx_ViewpointEN.zxShareId = objRow[conzx_Viewpoint.zxShareId] == DBNull.Value ? null : objRow[conzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id
objzx_ViewpointEN.CreateDate = objRow[conzx_Viewpoint.CreateDate] == DBNull.Value ? null : objRow[conzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期
objzx_ViewpointEN.UpdDate = objRow[conzx_Viewpoint.UpdDate] == DBNull.Value ? null : objRow[conzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointEN.UpdUser = objRow[conzx_Viewpoint.UpdUser] == DBNull.Value ? null : objRow[conzx_Viewpoint.UpdUser].ToString().Trim(); //修改人
objzx_ViewpointEN.Memo = objRow[conzx_Viewpoint.Memo] == DBNull.Value ? null : objRow[conzx_Viewpoint.Memo].ToString().Trim(); //备注
objzx_ViewpointEN.TeammenberId = objRow[conzx_Viewpoint.TeammenberId] == DBNull.Value ? null : objRow[conzx_Viewpoint.TeammenberId].ToString().Trim(); //主键
objzx_ViewpointEN.PdfDivLet = objRow[conzx_Viewpoint.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ViewpointEN.PdfDivTop = objRow[conzx_Viewpoint.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ViewpointEN.PdfPageNumIn = objRow[conzx_Viewpoint.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ViewpointEN.PdfPageTop = objRow[conzx_Viewpoint.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Viewpoint.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ViewpointEN.PdfZoom = objRow[conzx_Viewpoint.PdfZoom] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ViewpointEN.GroupTextId = objRow[conzx_Viewpoint.GroupTextId] == DBNull.Value ? null : objRow[conzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_ViewpointDA: GetObjLst)", objException.Message));
}
objzx_ViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_ViewpointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstByTabName)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <param name = "strTabName">表名</param>
 /// <returns>返回对象列表</returns>
public List<clszx_ViewpointEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clszx_ViewpointDA:GetObjLstByTabName)", objException.Message));
}
List<clszx_ViewpointEN> arrObjLst = new List<clszx_ViewpointEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ViewpointEN objzx_ViewpointEN = new clszx_ViewpointEN();
try
{
objzx_ViewpointEN.zxViewpointId = objRow[conzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointEN.ViewpointName = objRow[conzx_Viewpoint.ViewpointName] == DBNull.Value ? null : objRow[conzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称
objzx_ViewpointEN.ViewpointContent = objRow[conzx_Viewpoint.ViewpointContent] == DBNull.Value ? null : objRow[conzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容
objzx_ViewpointEN.zxViewpointTypeId = objRow[conzx_Viewpoint.zxViewpointTypeId] == DBNull.Value ? null : objRow[conzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objzx_ViewpointEN.Reason = objRow[conzx_Viewpoint.Reason] == DBNull.Value ? null : objRow[conzx_Viewpoint.Reason].ToString().Trim(); //理由
objzx_ViewpointEN.Source = objRow[conzx_Viewpoint.Source] == DBNull.Value ? null : objRow[conzx_Viewpoint.Source].ToString().Trim(); //来源
objzx_ViewpointEN.VPProposePeople = objRow[conzx_Viewpoint.VPProposePeople] == DBNull.Value ? null : objRow[conzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objzx_ViewpointEN.IsSubmit = TransNullToBool(objRow[conzx_Viewpoint.IsSubmit].ToString().Trim()); //是否提交
objzx_ViewpointEN.UserTypeId = objRow[conzx_Viewpoint.UserTypeId] == DBNull.Value ? null : objRow[conzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objzx_ViewpointEN.TextId = objRow[conzx_Viewpoint.TextId] == DBNull.Value ? null : objRow[conzx_Viewpoint.TextId].ToString().Trim(); //课件Id
objzx_ViewpointEN.VoteCount = objRow[conzx_Viewpoint.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Viewpoint.VoteCount].ToString().Trim()); //点赞计数
objzx_ViewpointEN.AppraiseCount = objRow[conzx_Viewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Viewpoint.AppraiseCount].ToString().Trim()); //评论数
objzx_ViewpointEN.Score = objRow[conzx_Viewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Viewpoint.Score].ToString().Trim()); //评分
objzx_ViewpointEN.StuScore = objRow[conzx_Viewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Viewpoint.StuScore].ToString().Trim()); //学生平均分
objzx_ViewpointEN.TeaScore = objRow[conzx_Viewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Viewpoint.TeaScore].ToString().Trim()); //教师评分
objzx_ViewpointEN.IdCurrEduCls = objRow[conzx_Viewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ViewpointEN.PdfContent = objRow[conzx_Viewpoint.PdfContent] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容
objzx_ViewpointEN.PdfPageNum = objRow[conzx_Viewpoint.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Viewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ViewpointEN.CitationCount = objRow[conzx_Viewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Viewpoint.CitationCount].ToString().Trim()); //引用统计
objzx_ViewpointEN.VersionCount = objRow[conzx_Viewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Viewpoint.VersionCount].ToString().Trim()); //版本统计
objzx_ViewpointEN.zxShareId = objRow[conzx_Viewpoint.zxShareId] == DBNull.Value ? null : objRow[conzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id
objzx_ViewpointEN.CreateDate = objRow[conzx_Viewpoint.CreateDate] == DBNull.Value ? null : objRow[conzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期
objzx_ViewpointEN.UpdDate = objRow[conzx_Viewpoint.UpdDate] == DBNull.Value ? null : objRow[conzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointEN.UpdUser = objRow[conzx_Viewpoint.UpdUser] == DBNull.Value ? null : objRow[conzx_Viewpoint.UpdUser].ToString().Trim(); //修改人
objzx_ViewpointEN.Memo = objRow[conzx_Viewpoint.Memo] == DBNull.Value ? null : objRow[conzx_Viewpoint.Memo].ToString().Trim(); //备注
objzx_ViewpointEN.TeammenberId = objRow[conzx_Viewpoint.TeammenberId] == DBNull.Value ? null : objRow[conzx_Viewpoint.TeammenberId].ToString().Trim(); //主键
objzx_ViewpointEN.PdfDivLet = objRow[conzx_Viewpoint.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ViewpointEN.PdfDivTop = objRow[conzx_Viewpoint.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ViewpointEN.PdfPageNumIn = objRow[conzx_Viewpoint.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ViewpointEN.PdfPageTop = objRow[conzx_Viewpoint.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Viewpoint.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ViewpointEN.PdfZoom = objRow[conzx_Viewpoint.PdfZoom] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ViewpointEN.GroupTextId = objRow[conzx_Viewpoint.GroupTextId] == DBNull.Value ? null : objRow[conzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_ViewpointDA: GetObjLst)", objException.Message));
}
objzx_ViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_ViewpointEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getzx_Viewpoint(ref clszx_ViewpointEN objzx_ViewpointEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
strSQL = "Select * from zx_Viewpoint where zxViewpointId = " + "'"+ objzx_ViewpointEN.zxViewpointId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objzx_ViewpointEN.zxViewpointId = objDT.Rows[0][conzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id(字段类型:char,字段长度:8,是否可空:True)
 objzx_ViewpointEN.ViewpointName = objDT.Rows[0][conzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_ViewpointEN.ViewpointContent = objDT.Rows[0][conzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_ViewpointEN.zxViewpointTypeId = objDT.Rows[0][conzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id(字段类型:char,字段长度:4,是否可空:True)
 objzx_ViewpointEN.Reason = objDT.Rows[0][conzx_Viewpoint.Reason].ToString().Trim(); //理由(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_ViewpointEN.Source = objDT.Rows[0][conzx_Viewpoint.Source].ToString().Trim(); //来源(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_ViewpointEN.VPProposePeople = objDT.Rows[0][conzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ViewpointEN.IsSubmit = TransNullToBool(objDT.Rows[0][conzx_Viewpoint.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_ViewpointEN.UserTypeId = objDT.Rows[0][conzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objzx_ViewpointEN.TextId = objDT.Rows[0][conzx_Viewpoint.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_ViewpointEN.VoteCount = TransNullToInt(objDT.Rows[0][conzx_Viewpoint.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_ViewpointEN.AppraiseCount = TransNullToInt(objDT.Rows[0][conzx_Viewpoint.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objzx_ViewpointEN.Score = TransNullToFloat(objDT.Rows[0][conzx_Viewpoint.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_ViewpointEN.StuScore = TransNullToFloat(objDT.Rows[0][conzx_Viewpoint.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objzx_ViewpointEN.TeaScore = TransNullToFloat(objDT.Rows[0][conzx_Viewpoint.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_ViewpointEN.IdCurrEduCls = objDT.Rows[0][conzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_ViewpointEN.PdfContent = objDT.Rows[0][conzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objzx_ViewpointEN.PdfPageNum = TransNullToInt(objDT.Rows[0][conzx_Viewpoint.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objzx_ViewpointEN.CitationCount = TransNullToInt(objDT.Rows[0][conzx_Viewpoint.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_ViewpointEN.VersionCount = TransNullToInt(objDT.Rows[0][conzx_Viewpoint.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_ViewpointEN.zxShareId = objDT.Rows[0][conzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_ViewpointEN.CreateDate = objDT.Rows[0][conzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ViewpointEN.UpdDate = objDT.Rows[0][conzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ViewpointEN.UpdUser = objDT.Rows[0][conzx_Viewpoint.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ViewpointEN.Memo = objDT.Rows[0][conzx_Viewpoint.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_ViewpointEN.TeammenberId = objDT.Rows[0][conzx_Viewpoint.TeammenberId].ToString().Trim(); //主键(字段类型:char,字段长度:8,是否可空:False)
 objzx_ViewpointEN.PdfDivLet = objDT.Rows[0][conzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ViewpointEN.PdfDivTop = objDT.Rows[0][conzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ViewpointEN.PdfPageNumIn = objDT.Rows[0][conzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ViewpointEN.PdfPageTop = TransNullToInt(objDT.Rows[0][conzx_Viewpoint.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objzx_ViewpointEN.PdfZoom = objDT.Rows[0][conzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ViewpointEN.GroupTextId = objDT.Rows[0][conzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clszx_ViewpointDA: Getzx_Viewpoint)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strzxViewpointId">表关键字</param>
 /// <returns>表对象</returns>
public clszx_ViewpointEN GetObjByzxViewpointId(string strzxViewpointId)
{
CheckPrimaryKey(strzxViewpointId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
strSQL = "Select * from zx_Viewpoint where zxViewpointId = " + "'"+ strzxViewpointId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clszx_ViewpointEN objzx_ViewpointEN = new clszx_ViewpointEN();
try
{
 objzx_ViewpointEN.zxViewpointId = objRow[conzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id(字段类型:char,字段长度:8,是否可空:True)
 objzx_ViewpointEN.ViewpointName = objRow[conzx_Viewpoint.ViewpointName] == DBNull.Value ? null : objRow[conzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_ViewpointEN.ViewpointContent = objRow[conzx_Viewpoint.ViewpointContent] == DBNull.Value ? null : objRow[conzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_ViewpointEN.zxViewpointTypeId = objRow[conzx_Viewpoint.zxViewpointTypeId] == DBNull.Value ? null : objRow[conzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id(字段类型:char,字段长度:4,是否可空:True)
 objzx_ViewpointEN.Reason = objRow[conzx_Viewpoint.Reason] == DBNull.Value ? null : objRow[conzx_Viewpoint.Reason].ToString().Trim(); //理由(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_ViewpointEN.Source = objRow[conzx_Viewpoint.Source] == DBNull.Value ? null : objRow[conzx_Viewpoint.Source].ToString().Trim(); //来源(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_ViewpointEN.VPProposePeople = objRow[conzx_Viewpoint.VPProposePeople] == DBNull.Value ? null : objRow[conzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Viewpoint.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_ViewpointEN.UserTypeId = objRow[conzx_Viewpoint.UserTypeId] == DBNull.Value ? null : objRow[conzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objzx_ViewpointEN.TextId = objRow[conzx_Viewpoint.TextId] == DBNull.Value ? null : objRow[conzx_Viewpoint.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_ViewpointEN.VoteCount = objRow[conzx_Viewpoint.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_ViewpointEN.AppraiseCount = objRow[conzx_Viewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objzx_ViewpointEN.Score = objRow[conzx_Viewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_ViewpointEN.StuScore = objRow[conzx_Viewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objzx_ViewpointEN.TeaScore = objRow[conzx_Viewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Viewpoint.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_ViewpointEN.IdCurrEduCls = objRow[conzx_Viewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_ViewpointEN.PdfContent = objRow[conzx_Viewpoint.PdfContent] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objzx_ViewpointEN.PdfPageNum = objRow[conzx_Viewpoint.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objzx_ViewpointEN.CitationCount = objRow[conzx_Viewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_ViewpointEN.VersionCount = objRow[conzx_Viewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_ViewpointEN.zxShareId = objRow[conzx_Viewpoint.zxShareId] == DBNull.Value ? null : objRow[conzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_ViewpointEN.CreateDate = objRow[conzx_Viewpoint.CreateDate] == DBNull.Value ? null : objRow[conzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ViewpointEN.UpdDate = objRow[conzx_Viewpoint.UpdDate] == DBNull.Value ? null : objRow[conzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ViewpointEN.UpdUser = objRow[conzx_Viewpoint.UpdUser] == DBNull.Value ? null : objRow[conzx_Viewpoint.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ViewpointEN.Memo = objRow[conzx_Viewpoint.Memo] == DBNull.Value ? null : objRow[conzx_Viewpoint.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_ViewpointEN.TeammenberId = objRow[conzx_Viewpoint.TeammenberId] == DBNull.Value ? null : objRow[conzx_Viewpoint.TeammenberId].ToString().Trim(); //主键(字段类型:char,字段长度:8,是否可空:False)
 objzx_ViewpointEN.PdfDivLet = objRow[conzx_Viewpoint.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ViewpointEN.PdfDivTop = objRow[conzx_Viewpoint.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ViewpointEN.PdfPageNumIn = objRow[conzx_Viewpoint.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ViewpointEN.PdfPageTop = objRow[conzx_Viewpoint.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Viewpoint.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objzx_ViewpointEN.PdfZoom = objRow[conzx_Viewpoint.PdfZoom] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ViewpointEN.GroupTextId = objRow[conzx_Viewpoint.GroupTextId] == DBNull.Value ? null : objRow[conzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clszx_ViewpointDA: GetObjByzxViewpointId)", objException.Message));
}
return objzx_ViewpointEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clszx_ViewpointEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clszx_ViewpointDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
strSQL = "Select * from zx_Viewpoint where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clszx_ViewpointEN objzx_ViewpointEN = new clszx_ViewpointEN()
{
zxViewpointId = objRow[conzx_Viewpoint.zxViewpointId].ToString().Trim(), //观点Id
ViewpointName = objRow[conzx_Viewpoint.ViewpointName] == DBNull.Value ? null : objRow[conzx_Viewpoint.ViewpointName].ToString().Trim(), //观点名称
ViewpointContent = objRow[conzx_Viewpoint.ViewpointContent] == DBNull.Value ? null : objRow[conzx_Viewpoint.ViewpointContent].ToString().Trim(), //观点内容
zxViewpointTypeId = objRow[conzx_Viewpoint.zxViewpointTypeId] == DBNull.Value ? null : objRow[conzx_Viewpoint.zxViewpointTypeId].ToString().Trim(), //观点类型Id
Reason = objRow[conzx_Viewpoint.Reason] == DBNull.Value ? null : objRow[conzx_Viewpoint.Reason].ToString().Trim(), //理由
Source = objRow[conzx_Viewpoint.Source] == DBNull.Value ? null : objRow[conzx_Viewpoint.Source].ToString().Trim(), //来源
VPProposePeople = objRow[conzx_Viewpoint.VPProposePeople] == DBNull.Value ? null : objRow[conzx_Viewpoint.VPProposePeople].ToString().Trim(), //观点提出人
IsSubmit = TransNullToBool(objRow[conzx_Viewpoint.IsSubmit].ToString().Trim()), //是否提交
UserTypeId = objRow[conzx_Viewpoint.UserTypeId] == DBNull.Value ? null : objRow[conzx_Viewpoint.UserTypeId].ToString().Trim(), //用户类型Id
TextId = objRow[conzx_Viewpoint.TextId] == DBNull.Value ? null : objRow[conzx_Viewpoint.TextId].ToString().Trim(), //课件Id
VoteCount = objRow[conzx_Viewpoint.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Viewpoint.VoteCount].ToString().Trim()), //点赞计数
AppraiseCount = objRow[conzx_Viewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Viewpoint.AppraiseCount].ToString().Trim()), //评论数
Score = objRow[conzx_Viewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Viewpoint.Score].ToString().Trim()), //评分
StuScore = objRow[conzx_Viewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Viewpoint.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[conzx_Viewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Viewpoint.TeaScore].ToString().Trim()), //教师评分
IdCurrEduCls = objRow[conzx_Viewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Viewpoint.IdCurrEduCls].ToString().Trim(), //教学班流水号
PdfContent = objRow[conzx_Viewpoint.PdfContent] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[conzx_Viewpoint.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Viewpoint.PdfPageNum].ToString().Trim()), //Pdf页码
CitationCount = objRow[conzx_Viewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Viewpoint.CitationCount].ToString().Trim()), //引用统计
VersionCount = objRow[conzx_Viewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Viewpoint.VersionCount].ToString().Trim()), //版本统计
zxShareId = objRow[conzx_Viewpoint.zxShareId] == DBNull.Value ? null : objRow[conzx_Viewpoint.zxShareId].ToString().Trim(), //分享Id
CreateDate = objRow[conzx_Viewpoint.CreateDate] == DBNull.Value ? null : objRow[conzx_Viewpoint.CreateDate].ToString().Trim(), //建立日期
UpdDate = objRow[conzx_Viewpoint.UpdDate] == DBNull.Value ? null : objRow[conzx_Viewpoint.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conzx_Viewpoint.UpdUser] == DBNull.Value ? null : objRow[conzx_Viewpoint.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conzx_Viewpoint.Memo] == DBNull.Value ? null : objRow[conzx_Viewpoint.Memo].ToString().Trim(), //备注
TeammenberId = objRow[conzx_Viewpoint.TeammenberId] == DBNull.Value ? null : objRow[conzx_Viewpoint.TeammenberId].ToString().Trim(), //主键
PdfDivLet = objRow[conzx_Viewpoint.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfDivLet].ToString().Trim(), //PdfDivLet
PdfDivTop = objRow[conzx_Viewpoint.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfDivTop].ToString().Trim(), //PdfDivTop
PdfPageNumIn = objRow[conzx_Viewpoint.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfPageNumIn].ToString().Trim(), //PdfPageNumIn
PdfPageTop = objRow[conzx_Viewpoint.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Viewpoint.PdfPageTop].ToString().Trim()), //pdf页面顶部位置
PdfZoom = objRow[conzx_Viewpoint.PdfZoom] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfZoom].ToString().Trim(), //PdfZoom
GroupTextId = objRow[conzx_Viewpoint.GroupTextId] == DBNull.Value ? null : objRow[conzx_Viewpoint.GroupTextId].ToString().Trim() //小组Id
};
objzx_ViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_ViewpointEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clszx_ViewpointDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clszx_ViewpointEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_ViewpointEN objzx_ViewpointEN = new clszx_ViewpointEN();
try
{
objzx_ViewpointEN.zxViewpointId = objRow[conzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointEN.ViewpointName = objRow[conzx_Viewpoint.ViewpointName] == DBNull.Value ? null : objRow[conzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称
objzx_ViewpointEN.ViewpointContent = objRow[conzx_Viewpoint.ViewpointContent] == DBNull.Value ? null : objRow[conzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容
objzx_ViewpointEN.zxViewpointTypeId = objRow[conzx_Viewpoint.zxViewpointTypeId] == DBNull.Value ? null : objRow[conzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objzx_ViewpointEN.Reason = objRow[conzx_Viewpoint.Reason] == DBNull.Value ? null : objRow[conzx_Viewpoint.Reason].ToString().Trim(); //理由
objzx_ViewpointEN.Source = objRow[conzx_Viewpoint.Source] == DBNull.Value ? null : objRow[conzx_Viewpoint.Source].ToString().Trim(); //来源
objzx_ViewpointEN.VPProposePeople = objRow[conzx_Viewpoint.VPProposePeople] == DBNull.Value ? null : objRow[conzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objzx_ViewpointEN.IsSubmit = TransNullToBool(objRow[conzx_Viewpoint.IsSubmit].ToString().Trim()); //是否提交
objzx_ViewpointEN.UserTypeId = objRow[conzx_Viewpoint.UserTypeId] == DBNull.Value ? null : objRow[conzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objzx_ViewpointEN.TextId = objRow[conzx_Viewpoint.TextId] == DBNull.Value ? null : objRow[conzx_Viewpoint.TextId].ToString().Trim(); //课件Id
objzx_ViewpointEN.VoteCount = objRow[conzx_Viewpoint.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Viewpoint.VoteCount].ToString().Trim()); //点赞计数
objzx_ViewpointEN.AppraiseCount = objRow[conzx_Viewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Viewpoint.AppraiseCount].ToString().Trim()); //评论数
objzx_ViewpointEN.Score = objRow[conzx_Viewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Viewpoint.Score].ToString().Trim()); //评分
objzx_ViewpointEN.StuScore = objRow[conzx_Viewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Viewpoint.StuScore].ToString().Trim()); //学生平均分
objzx_ViewpointEN.TeaScore = objRow[conzx_Viewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Viewpoint.TeaScore].ToString().Trim()); //教师评分
objzx_ViewpointEN.IdCurrEduCls = objRow[conzx_Viewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ViewpointEN.PdfContent = objRow[conzx_Viewpoint.PdfContent] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容
objzx_ViewpointEN.PdfPageNum = objRow[conzx_Viewpoint.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Viewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ViewpointEN.CitationCount = objRow[conzx_Viewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Viewpoint.CitationCount].ToString().Trim()); //引用统计
objzx_ViewpointEN.VersionCount = objRow[conzx_Viewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Viewpoint.VersionCount].ToString().Trim()); //版本统计
objzx_ViewpointEN.zxShareId = objRow[conzx_Viewpoint.zxShareId] == DBNull.Value ? null : objRow[conzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id
objzx_ViewpointEN.CreateDate = objRow[conzx_Viewpoint.CreateDate] == DBNull.Value ? null : objRow[conzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期
objzx_ViewpointEN.UpdDate = objRow[conzx_Viewpoint.UpdDate] == DBNull.Value ? null : objRow[conzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointEN.UpdUser = objRow[conzx_Viewpoint.UpdUser] == DBNull.Value ? null : objRow[conzx_Viewpoint.UpdUser].ToString().Trim(); //修改人
objzx_ViewpointEN.Memo = objRow[conzx_Viewpoint.Memo] == DBNull.Value ? null : objRow[conzx_Viewpoint.Memo].ToString().Trim(); //备注
objzx_ViewpointEN.TeammenberId = objRow[conzx_Viewpoint.TeammenberId] == DBNull.Value ? null : objRow[conzx_Viewpoint.TeammenberId].ToString().Trim(); //主键
objzx_ViewpointEN.PdfDivLet = objRow[conzx_Viewpoint.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ViewpointEN.PdfDivTop = objRow[conzx_Viewpoint.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ViewpointEN.PdfPageNumIn = objRow[conzx_Viewpoint.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ViewpointEN.PdfPageTop = objRow[conzx_Viewpoint.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Viewpoint.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ViewpointEN.PdfZoom = objRow[conzx_Viewpoint.PdfZoom] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ViewpointEN.GroupTextId = objRow[conzx_Viewpoint.GroupTextId] == DBNull.Value ? null : objRow[conzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clszx_ViewpointDA: GetObjByDataRowzx_Viewpoint)", objException.Message));
}
objzx_ViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_ViewpointEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clszx_ViewpointEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_ViewpointEN objzx_ViewpointEN = new clszx_ViewpointEN();
try
{
objzx_ViewpointEN.zxViewpointId = objRow[conzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id
objzx_ViewpointEN.ViewpointName = objRow[conzx_Viewpoint.ViewpointName] == DBNull.Value ? null : objRow[conzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称
objzx_ViewpointEN.ViewpointContent = objRow[conzx_Viewpoint.ViewpointContent] == DBNull.Value ? null : objRow[conzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容
objzx_ViewpointEN.zxViewpointTypeId = objRow[conzx_Viewpoint.zxViewpointTypeId] == DBNull.Value ? null : objRow[conzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objzx_ViewpointEN.Reason = objRow[conzx_Viewpoint.Reason] == DBNull.Value ? null : objRow[conzx_Viewpoint.Reason].ToString().Trim(); //理由
objzx_ViewpointEN.Source = objRow[conzx_Viewpoint.Source] == DBNull.Value ? null : objRow[conzx_Viewpoint.Source].ToString().Trim(); //来源
objzx_ViewpointEN.VPProposePeople = objRow[conzx_Viewpoint.VPProposePeople] == DBNull.Value ? null : objRow[conzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objzx_ViewpointEN.IsSubmit = TransNullToBool(objRow[conzx_Viewpoint.IsSubmit].ToString().Trim()); //是否提交
objzx_ViewpointEN.UserTypeId = objRow[conzx_Viewpoint.UserTypeId] == DBNull.Value ? null : objRow[conzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objzx_ViewpointEN.TextId = objRow[conzx_Viewpoint.TextId] == DBNull.Value ? null : objRow[conzx_Viewpoint.TextId].ToString().Trim(); //课件Id
objzx_ViewpointEN.VoteCount = objRow[conzx_Viewpoint.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Viewpoint.VoteCount].ToString().Trim()); //点赞计数
objzx_ViewpointEN.AppraiseCount = objRow[conzx_Viewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Viewpoint.AppraiseCount].ToString().Trim()); //评论数
objzx_ViewpointEN.Score = objRow[conzx_Viewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Viewpoint.Score].ToString().Trim()); //评分
objzx_ViewpointEN.StuScore = objRow[conzx_Viewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Viewpoint.StuScore].ToString().Trim()); //学生平均分
objzx_ViewpointEN.TeaScore = objRow[conzx_Viewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Viewpoint.TeaScore].ToString().Trim()); //教师评分
objzx_ViewpointEN.IdCurrEduCls = objRow[conzx_Viewpoint.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ViewpointEN.PdfContent = objRow[conzx_Viewpoint.PdfContent] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容
objzx_ViewpointEN.PdfPageNum = objRow[conzx_Viewpoint.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Viewpoint.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ViewpointEN.CitationCount = objRow[conzx_Viewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Viewpoint.CitationCount].ToString().Trim()); //引用统计
objzx_ViewpointEN.VersionCount = objRow[conzx_Viewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Viewpoint.VersionCount].ToString().Trim()); //版本统计
objzx_ViewpointEN.zxShareId = objRow[conzx_Viewpoint.zxShareId] == DBNull.Value ? null : objRow[conzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id
objzx_ViewpointEN.CreateDate = objRow[conzx_Viewpoint.CreateDate] == DBNull.Value ? null : objRow[conzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期
objzx_ViewpointEN.UpdDate = objRow[conzx_Viewpoint.UpdDate] == DBNull.Value ? null : objRow[conzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期
objzx_ViewpointEN.UpdUser = objRow[conzx_Viewpoint.UpdUser] == DBNull.Value ? null : objRow[conzx_Viewpoint.UpdUser].ToString().Trim(); //修改人
objzx_ViewpointEN.Memo = objRow[conzx_Viewpoint.Memo] == DBNull.Value ? null : objRow[conzx_Viewpoint.Memo].ToString().Trim(); //备注
objzx_ViewpointEN.TeammenberId = objRow[conzx_Viewpoint.TeammenberId] == DBNull.Value ? null : objRow[conzx_Viewpoint.TeammenberId].ToString().Trim(); //主键
objzx_ViewpointEN.PdfDivLet = objRow[conzx_Viewpoint.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ViewpointEN.PdfDivTop = objRow[conzx_Viewpoint.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ViewpointEN.PdfPageNumIn = objRow[conzx_Viewpoint.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ViewpointEN.PdfPageTop = objRow[conzx_Viewpoint.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Viewpoint.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ViewpointEN.PdfZoom = objRow[conzx_Viewpoint.PdfZoom] == DBNull.Value ? null : objRow[conzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ViewpointEN.GroupTextId = objRow[conzx_Viewpoint.GroupTextId] == DBNull.Value ? null : objRow[conzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clszx_ViewpointDA: GetObjByDataRow)", objException.Message));
}
objzx_ViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_ViewpointEN;
}

 #endregion 获取一个实体对象

 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase:GenGetMaxStrID)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public static string GetMaxStrId()
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_ViewpointDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_ViewpointEN._CurrTabName, conzx_Viewpoint.zxViewpointId, 8, "");
return strMaxValue;
}

 /// <summary>
 /// 根据前缀获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase:GenGetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public string GetMaxStrIdByPrefix(string strPrefix)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_ViewpointDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_ViewpointEN._CurrTabName, conzx_Viewpoint.zxViewpointId, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public string GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select zxViewpointId from zx_Viewpoint where " + strCondition;
try
{
objDT = objSQL.GetDataTable(strSQL);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}

if (objDT.Rows.Count  ==  0)
{
return "";
}
strKeyValue = objDT.Rows[0][0].ToString();
return strKeyValue;
}

 #endregion 获取一个关键字值

 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的所有记录的关键字值列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetPrimaryKeyID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的关键字值列表</returns>
public List<string> GetID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
List<string> arrList = new List<string>();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select zxViewpointId from zx_Viewpoint where " + strCondition;
try
{
objDT = objSQL.GetDataTable(strSQL);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}

if (objDT.Rows.Count  ==  0)
{
return null;
}
for (iRow = 0; iRow<=  objDT.Rows.Count - 1;iRow++)
{
strKeyValue = "";
for (iCol = 0; iCol<=  objDT.Columns.Count - 1;iCol++)
{
if (iCol  ==  0)
{
strKeyValue +=  objDT.Rows[iRow][iCol].ToString();
}
else
{
strKeyValue +=  "//" + objDT.Rows[iRow][iCol].ToString();
}
}
arrList.Add(strKeyValue);
}
return arrList;
}

 #endregion 获取多个关键字值列表

 #region 判断记录是否存在

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.clsGeneCodeBase:GenIsExist_S)
 /// </summary>
 /// <param name = "strzxViewpointId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strzxViewpointId)
{
CheckPrimaryKey(strzxViewpointId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_Viewpoint", "zxViewpointId = " + "'"+ strzxViewpointId+"'"))
{
return true;
}
else
{
return false;
}
}

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.clsGeneCodeBase:GenIsExistCondRec_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public bool IsExistCondRec(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clszx_ViewpointDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_Viewpoint", strCondition))
{
return true;
}
else
{
return false;
}
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.clsGeneCodeBase:GenIsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable()
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_ViewpointDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("zx_Viewpoint");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clszx_ViewpointEN objzx_ViewpointEN)
 {
 if (objzx_ViewpointEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ViewpointEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
strSQL = "Select * from zx_Viewpoint where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_Viewpoint");
objRow = objDS.Tables["zx_Viewpoint"].NewRow();
objRow[conzx_Viewpoint.zxViewpointId] = objzx_ViewpointEN.zxViewpointId; //观点Id
 if (objzx_ViewpointEN.ViewpointName !=  "")
 {
objRow[conzx_Viewpoint.ViewpointName] = objzx_ViewpointEN.ViewpointName; //观点名称
 }
 if (objzx_ViewpointEN.ViewpointContent !=  "")
 {
objRow[conzx_Viewpoint.ViewpointContent] = objzx_ViewpointEN.ViewpointContent; //观点内容
 }
 if (objzx_ViewpointEN.zxViewpointTypeId !=  "")
 {
objRow[conzx_Viewpoint.zxViewpointTypeId] = objzx_ViewpointEN.zxViewpointTypeId; //观点类型Id
 }
 if (objzx_ViewpointEN.Reason !=  "")
 {
objRow[conzx_Viewpoint.Reason] = objzx_ViewpointEN.Reason; //理由
 }
 if (objzx_ViewpointEN.Source !=  "")
 {
objRow[conzx_Viewpoint.Source] = objzx_ViewpointEN.Source; //来源
 }
 if (objzx_ViewpointEN.VPProposePeople !=  "")
 {
objRow[conzx_Viewpoint.VPProposePeople] = objzx_ViewpointEN.VPProposePeople; //观点提出人
 }
objRow[conzx_Viewpoint.IsSubmit] = objzx_ViewpointEN.IsSubmit; //是否提交
 if (objzx_ViewpointEN.UserTypeId !=  "")
 {
objRow[conzx_Viewpoint.UserTypeId] = objzx_ViewpointEN.UserTypeId; //用户类型Id
 }
 if (objzx_ViewpointEN.TextId !=  "")
 {
objRow[conzx_Viewpoint.TextId] = objzx_ViewpointEN.TextId; //课件Id
 }
objRow[conzx_Viewpoint.VoteCount] = objzx_ViewpointEN.VoteCount; //点赞计数
objRow[conzx_Viewpoint.AppraiseCount] = objzx_ViewpointEN.AppraiseCount; //评论数
objRow[conzx_Viewpoint.Score] = objzx_ViewpointEN.Score; //评分
objRow[conzx_Viewpoint.StuScore] = objzx_ViewpointEN.StuScore; //学生平均分
objRow[conzx_Viewpoint.TeaScore] = objzx_ViewpointEN.TeaScore; //教师评分
 if (objzx_ViewpointEN.IdCurrEduCls !=  "")
 {
objRow[conzx_Viewpoint.IdCurrEduCls] = objzx_ViewpointEN.IdCurrEduCls; //教学班流水号
 }
 if (objzx_ViewpointEN.PdfContent !=  "")
 {
objRow[conzx_Viewpoint.PdfContent] = objzx_ViewpointEN.PdfContent; //Pdf内容
 }
objRow[conzx_Viewpoint.PdfPageNum] = objzx_ViewpointEN.PdfPageNum; //Pdf页码
objRow[conzx_Viewpoint.CitationCount] = objzx_ViewpointEN.CitationCount; //引用统计
objRow[conzx_Viewpoint.VersionCount] = objzx_ViewpointEN.VersionCount; //版本统计
 if (objzx_ViewpointEN.zxShareId !=  "")
 {
objRow[conzx_Viewpoint.zxShareId] = objzx_ViewpointEN.zxShareId; //分享Id
 }
 if (objzx_ViewpointEN.CreateDate !=  "")
 {
objRow[conzx_Viewpoint.CreateDate] = objzx_ViewpointEN.CreateDate; //建立日期
 }
 if (objzx_ViewpointEN.UpdDate !=  "")
 {
objRow[conzx_Viewpoint.UpdDate] = objzx_ViewpointEN.UpdDate; //修改日期
 }
 if (objzx_ViewpointEN.UpdUser !=  "")
 {
objRow[conzx_Viewpoint.UpdUser] = objzx_ViewpointEN.UpdUser; //修改人
 }
 if (objzx_ViewpointEN.Memo !=  "")
 {
objRow[conzx_Viewpoint.Memo] = objzx_ViewpointEN.Memo; //备注
 }
 if (objzx_ViewpointEN.TeammenberId !=  "")
 {
objRow[conzx_Viewpoint.TeammenberId] = objzx_ViewpointEN.TeammenberId; //主键
 }
 if (objzx_ViewpointEN.PdfDivLet !=  "")
 {
objRow[conzx_Viewpoint.PdfDivLet] = objzx_ViewpointEN.PdfDivLet; //PdfDivLet
 }
 if (objzx_ViewpointEN.PdfDivTop !=  "")
 {
objRow[conzx_Viewpoint.PdfDivTop] = objzx_ViewpointEN.PdfDivTop; //PdfDivTop
 }
 if (objzx_ViewpointEN.PdfPageNumIn !=  "")
 {
objRow[conzx_Viewpoint.PdfPageNumIn] = objzx_ViewpointEN.PdfPageNumIn; //PdfPageNumIn
 }
objRow[conzx_Viewpoint.PdfPageTop] = objzx_ViewpointEN.PdfPageTop; //pdf页面顶部位置
 if (objzx_ViewpointEN.PdfZoom !=  "")
 {
objRow[conzx_Viewpoint.PdfZoom] = objzx_ViewpointEN.PdfZoom; //PdfZoom
 }
 if (objzx_ViewpointEN.GroupTextId !=  "")
 {
objRow[conzx_Viewpoint.GroupTextId] = objzx_ViewpointEN.GroupTextId; //小组Id
 }
objDS.Tables[clszx_ViewpointEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clszx_ViewpointEN._CurrTabName);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
return true;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_ViewpointEN objzx_ViewpointEN)
{
 if (objzx_ViewpointEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ViewpointEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_ViewpointEN.zxViewpointId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.zxViewpointId);
 var strzxViewpointId = objzx_ViewpointEN.zxViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxViewpointId + "'");
 }
 
 if (objzx_ViewpointEN.ViewpointName !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.ViewpointName);
 var strViewpointName = objzx_ViewpointEN.ViewpointName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointName + "'");
 }
 
 if (objzx_ViewpointEN.ViewpointContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.ViewpointContent);
 var strViewpointContent = objzx_ViewpointEN.ViewpointContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointContent + "'");
 }
 
 if (objzx_ViewpointEN.zxViewpointTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.zxViewpointTypeId);
 var strzxViewpointTypeId = objzx_ViewpointEN.zxViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxViewpointTypeId + "'");
 }
 
 if (objzx_ViewpointEN.Reason !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.Reason);
 var strReason = objzx_ViewpointEN.Reason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReason + "'");
 }
 
 if (objzx_ViewpointEN.Source !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.Source);
 var strSource = objzx_ViewpointEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSource + "'");
 }
 
 if (objzx_ViewpointEN.VPProposePeople !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.VPProposePeople);
 var strVPProposePeople = objzx_ViewpointEN.VPProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVPProposePeople + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Viewpoint.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_ViewpointEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_ViewpointEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.UserTypeId);
 var strUserTypeId = objzx_ViewpointEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objzx_ViewpointEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.TextId);
 var strTextId = objzx_ViewpointEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_ViewpointEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.VoteCount);
 arrValueListForInsert.Add(objzx_ViewpointEN.VoteCount.ToString());
 }
 
 if (objzx_ViewpointEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.AppraiseCount);
 arrValueListForInsert.Add(objzx_ViewpointEN.AppraiseCount.ToString());
 }
 
 if (objzx_ViewpointEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.Score);
 arrValueListForInsert.Add(objzx_ViewpointEN.Score.ToString());
 }
 
 if (objzx_ViewpointEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.StuScore);
 arrValueListForInsert.Add(objzx_ViewpointEN.StuScore.ToString());
 }
 
 if (objzx_ViewpointEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.TeaScore);
 arrValueListForInsert.Add(objzx_ViewpointEN.TeaScore.ToString());
 }
 
 if (objzx_ViewpointEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.IdCurrEduCls);
 var strIdCurrEduCls = objzx_ViewpointEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_ViewpointEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.PdfContent);
 var strPdfContent = objzx_ViewpointEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_ViewpointEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.PdfPageNum);
 arrValueListForInsert.Add(objzx_ViewpointEN.PdfPageNum.ToString());
 }
 
 if (objzx_ViewpointEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.CitationCount);
 arrValueListForInsert.Add(objzx_ViewpointEN.CitationCount.ToString());
 }
 
 if (objzx_ViewpointEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.VersionCount);
 arrValueListForInsert.Add(objzx_ViewpointEN.VersionCount.ToString());
 }
 
 if (objzx_ViewpointEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.zxShareId);
 var strzxShareId = objzx_ViewpointEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_ViewpointEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.CreateDate);
 var strCreateDate = objzx_ViewpointEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_ViewpointEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.UpdDate);
 var strUpdDate = objzx_ViewpointEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_ViewpointEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.UpdUser);
 var strUpdUser = objzx_ViewpointEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_ViewpointEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.Memo);
 var strMemo = objzx_ViewpointEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_ViewpointEN.TeammenberId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.TeammenberId);
 var strTeammenberId = objzx_ViewpointEN.TeammenberId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeammenberId + "'");
 }
 
 if (objzx_ViewpointEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.PdfDivLet);
 var strPdfDivLet = objzx_ViewpointEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_ViewpointEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.PdfDivTop);
 var strPdfDivTop = objzx_ViewpointEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_ViewpointEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.PdfPageNumIn);
 var strPdfPageNumIn = objzx_ViewpointEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_ViewpointEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.PdfPageTop);
 arrValueListForInsert.Add(objzx_ViewpointEN.PdfPageTop.ToString());
 }
 
 if (objzx_ViewpointEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.PdfZoom);
 var strPdfZoom = objzx_ViewpointEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_ViewpointEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.GroupTextId);
 var strGroupTextId = objzx_ViewpointEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_Viewpoint");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_ViewpointEN objzx_ViewpointEN)
{
 if (objzx_ViewpointEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ViewpointEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_ViewpointEN.zxViewpointId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.zxViewpointId);
 var strzxViewpointId = objzx_ViewpointEN.zxViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxViewpointId + "'");
 }
 
 if (objzx_ViewpointEN.ViewpointName !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.ViewpointName);
 var strViewpointName = objzx_ViewpointEN.ViewpointName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointName + "'");
 }
 
 if (objzx_ViewpointEN.ViewpointContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.ViewpointContent);
 var strViewpointContent = objzx_ViewpointEN.ViewpointContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointContent + "'");
 }
 
 if (objzx_ViewpointEN.zxViewpointTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.zxViewpointTypeId);
 var strzxViewpointTypeId = objzx_ViewpointEN.zxViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxViewpointTypeId + "'");
 }
 
 if (objzx_ViewpointEN.Reason !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.Reason);
 var strReason = objzx_ViewpointEN.Reason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReason + "'");
 }
 
 if (objzx_ViewpointEN.Source !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.Source);
 var strSource = objzx_ViewpointEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSource + "'");
 }
 
 if (objzx_ViewpointEN.VPProposePeople !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.VPProposePeople);
 var strVPProposePeople = objzx_ViewpointEN.VPProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVPProposePeople + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Viewpoint.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_ViewpointEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_ViewpointEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.UserTypeId);
 var strUserTypeId = objzx_ViewpointEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objzx_ViewpointEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.TextId);
 var strTextId = objzx_ViewpointEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_ViewpointEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.VoteCount);
 arrValueListForInsert.Add(objzx_ViewpointEN.VoteCount.ToString());
 }
 
 if (objzx_ViewpointEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.AppraiseCount);
 arrValueListForInsert.Add(objzx_ViewpointEN.AppraiseCount.ToString());
 }
 
 if (objzx_ViewpointEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.Score);
 arrValueListForInsert.Add(objzx_ViewpointEN.Score.ToString());
 }
 
 if (objzx_ViewpointEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.StuScore);
 arrValueListForInsert.Add(objzx_ViewpointEN.StuScore.ToString());
 }
 
 if (objzx_ViewpointEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.TeaScore);
 arrValueListForInsert.Add(objzx_ViewpointEN.TeaScore.ToString());
 }
 
 if (objzx_ViewpointEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.IdCurrEduCls);
 var strIdCurrEduCls = objzx_ViewpointEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_ViewpointEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.PdfContent);
 var strPdfContent = objzx_ViewpointEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_ViewpointEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.PdfPageNum);
 arrValueListForInsert.Add(objzx_ViewpointEN.PdfPageNum.ToString());
 }
 
 if (objzx_ViewpointEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.CitationCount);
 arrValueListForInsert.Add(objzx_ViewpointEN.CitationCount.ToString());
 }
 
 if (objzx_ViewpointEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.VersionCount);
 arrValueListForInsert.Add(objzx_ViewpointEN.VersionCount.ToString());
 }
 
 if (objzx_ViewpointEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.zxShareId);
 var strzxShareId = objzx_ViewpointEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_ViewpointEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.CreateDate);
 var strCreateDate = objzx_ViewpointEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_ViewpointEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.UpdDate);
 var strUpdDate = objzx_ViewpointEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_ViewpointEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.UpdUser);
 var strUpdUser = objzx_ViewpointEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_ViewpointEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.Memo);
 var strMemo = objzx_ViewpointEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_ViewpointEN.TeammenberId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.TeammenberId);
 var strTeammenberId = objzx_ViewpointEN.TeammenberId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeammenberId + "'");
 }
 
 if (objzx_ViewpointEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.PdfDivLet);
 var strPdfDivLet = objzx_ViewpointEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_ViewpointEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.PdfDivTop);
 var strPdfDivTop = objzx_ViewpointEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_ViewpointEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.PdfPageNumIn);
 var strPdfPageNumIn = objzx_ViewpointEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_ViewpointEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.PdfPageTop);
 arrValueListForInsert.Add(objzx_ViewpointEN.PdfPageTop.ToString());
 }
 
 if (objzx_ViewpointEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.PdfZoom);
 var strPdfZoom = objzx_ViewpointEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_ViewpointEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.GroupTextId);
 var strGroupTextId = objzx_ViewpointEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_Viewpoint");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objzx_ViewpointEN.zxViewpointId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_ViewpointEN objzx_ViewpointEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_ViewpointEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ViewpointEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_ViewpointEN.zxViewpointId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.zxViewpointId);
 var strzxViewpointId = objzx_ViewpointEN.zxViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxViewpointId + "'");
 }
 
 if (objzx_ViewpointEN.ViewpointName !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.ViewpointName);
 var strViewpointName = objzx_ViewpointEN.ViewpointName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointName + "'");
 }
 
 if (objzx_ViewpointEN.ViewpointContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.ViewpointContent);
 var strViewpointContent = objzx_ViewpointEN.ViewpointContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointContent + "'");
 }
 
 if (objzx_ViewpointEN.zxViewpointTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.zxViewpointTypeId);
 var strzxViewpointTypeId = objzx_ViewpointEN.zxViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxViewpointTypeId + "'");
 }
 
 if (objzx_ViewpointEN.Reason !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.Reason);
 var strReason = objzx_ViewpointEN.Reason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReason + "'");
 }
 
 if (objzx_ViewpointEN.Source !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.Source);
 var strSource = objzx_ViewpointEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSource + "'");
 }
 
 if (objzx_ViewpointEN.VPProposePeople !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.VPProposePeople);
 var strVPProposePeople = objzx_ViewpointEN.VPProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVPProposePeople + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Viewpoint.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_ViewpointEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_ViewpointEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.UserTypeId);
 var strUserTypeId = objzx_ViewpointEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objzx_ViewpointEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.TextId);
 var strTextId = objzx_ViewpointEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_ViewpointEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.VoteCount);
 arrValueListForInsert.Add(objzx_ViewpointEN.VoteCount.ToString());
 }
 
 if (objzx_ViewpointEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.AppraiseCount);
 arrValueListForInsert.Add(objzx_ViewpointEN.AppraiseCount.ToString());
 }
 
 if (objzx_ViewpointEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.Score);
 arrValueListForInsert.Add(objzx_ViewpointEN.Score.ToString());
 }
 
 if (objzx_ViewpointEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.StuScore);
 arrValueListForInsert.Add(objzx_ViewpointEN.StuScore.ToString());
 }
 
 if (objzx_ViewpointEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.TeaScore);
 arrValueListForInsert.Add(objzx_ViewpointEN.TeaScore.ToString());
 }
 
 if (objzx_ViewpointEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.IdCurrEduCls);
 var strIdCurrEduCls = objzx_ViewpointEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_ViewpointEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.PdfContent);
 var strPdfContent = objzx_ViewpointEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_ViewpointEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.PdfPageNum);
 arrValueListForInsert.Add(objzx_ViewpointEN.PdfPageNum.ToString());
 }
 
 if (objzx_ViewpointEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.CitationCount);
 arrValueListForInsert.Add(objzx_ViewpointEN.CitationCount.ToString());
 }
 
 if (objzx_ViewpointEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.VersionCount);
 arrValueListForInsert.Add(objzx_ViewpointEN.VersionCount.ToString());
 }
 
 if (objzx_ViewpointEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.zxShareId);
 var strzxShareId = objzx_ViewpointEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_ViewpointEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.CreateDate);
 var strCreateDate = objzx_ViewpointEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_ViewpointEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.UpdDate);
 var strUpdDate = objzx_ViewpointEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_ViewpointEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.UpdUser);
 var strUpdUser = objzx_ViewpointEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_ViewpointEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.Memo);
 var strMemo = objzx_ViewpointEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_ViewpointEN.TeammenberId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.TeammenberId);
 var strTeammenberId = objzx_ViewpointEN.TeammenberId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeammenberId + "'");
 }
 
 if (objzx_ViewpointEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.PdfDivLet);
 var strPdfDivLet = objzx_ViewpointEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_ViewpointEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.PdfDivTop);
 var strPdfDivTop = objzx_ViewpointEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_ViewpointEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.PdfPageNumIn);
 var strPdfPageNumIn = objzx_ViewpointEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_ViewpointEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.PdfPageTop);
 arrValueListForInsert.Add(objzx_ViewpointEN.PdfPageTop.ToString());
 }
 
 if (objzx_ViewpointEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.PdfZoom);
 var strPdfZoom = objzx_ViewpointEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_ViewpointEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.GroupTextId);
 var strGroupTextId = objzx_ViewpointEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_Viewpoint");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objzx_ViewpointEN.zxViewpointId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_ViewpointEN objzx_ViewpointEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_ViewpointEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ViewpointEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_ViewpointEN.zxViewpointId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.zxViewpointId);
 var strzxViewpointId = objzx_ViewpointEN.zxViewpointId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxViewpointId + "'");
 }
 
 if (objzx_ViewpointEN.ViewpointName !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.ViewpointName);
 var strViewpointName = objzx_ViewpointEN.ViewpointName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointName + "'");
 }
 
 if (objzx_ViewpointEN.ViewpointContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.ViewpointContent);
 var strViewpointContent = objzx_ViewpointEN.ViewpointContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewpointContent + "'");
 }
 
 if (objzx_ViewpointEN.zxViewpointTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.zxViewpointTypeId);
 var strzxViewpointTypeId = objzx_ViewpointEN.zxViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxViewpointTypeId + "'");
 }
 
 if (objzx_ViewpointEN.Reason !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.Reason);
 var strReason = objzx_ViewpointEN.Reason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReason + "'");
 }
 
 if (objzx_ViewpointEN.Source !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.Source);
 var strSource = objzx_ViewpointEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSource + "'");
 }
 
 if (objzx_ViewpointEN.VPProposePeople !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.VPProposePeople);
 var strVPProposePeople = objzx_ViewpointEN.VPProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVPProposePeople + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Viewpoint.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_ViewpointEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_ViewpointEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.UserTypeId);
 var strUserTypeId = objzx_ViewpointEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objzx_ViewpointEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.TextId);
 var strTextId = objzx_ViewpointEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_ViewpointEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.VoteCount);
 arrValueListForInsert.Add(objzx_ViewpointEN.VoteCount.ToString());
 }
 
 if (objzx_ViewpointEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.AppraiseCount);
 arrValueListForInsert.Add(objzx_ViewpointEN.AppraiseCount.ToString());
 }
 
 if (objzx_ViewpointEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.Score);
 arrValueListForInsert.Add(objzx_ViewpointEN.Score.ToString());
 }
 
 if (objzx_ViewpointEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.StuScore);
 arrValueListForInsert.Add(objzx_ViewpointEN.StuScore.ToString());
 }
 
 if (objzx_ViewpointEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.TeaScore);
 arrValueListForInsert.Add(objzx_ViewpointEN.TeaScore.ToString());
 }
 
 if (objzx_ViewpointEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.IdCurrEduCls);
 var strIdCurrEduCls = objzx_ViewpointEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_ViewpointEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.PdfContent);
 var strPdfContent = objzx_ViewpointEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_ViewpointEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.PdfPageNum);
 arrValueListForInsert.Add(objzx_ViewpointEN.PdfPageNum.ToString());
 }
 
 if (objzx_ViewpointEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.CitationCount);
 arrValueListForInsert.Add(objzx_ViewpointEN.CitationCount.ToString());
 }
 
 if (objzx_ViewpointEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.VersionCount);
 arrValueListForInsert.Add(objzx_ViewpointEN.VersionCount.ToString());
 }
 
 if (objzx_ViewpointEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.zxShareId);
 var strzxShareId = objzx_ViewpointEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_ViewpointEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.CreateDate);
 var strCreateDate = objzx_ViewpointEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_ViewpointEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.UpdDate);
 var strUpdDate = objzx_ViewpointEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_ViewpointEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.UpdUser);
 var strUpdUser = objzx_ViewpointEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_ViewpointEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.Memo);
 var strMemo = objzx_ViewpointEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_ViewpointEN.TeammenberId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.TeammenberId);
 var strTeammenberId = objzx_ViewpointEN.TeammenberId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeammenberId + "'");
 }
 
 if (objzx_ViewpointEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.PdfDivLet);
 var strPdfDivLet = objzx_ViewpointEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_ViewpointEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.PdfDivTop);
 var strPdfDivTop = objzx_ViewpointEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_ViewpointEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.PdfPageNumIn);
 var strPdfPageNumIn = objzx_ViewpointEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_ViewpointEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.PdfPageTop);
 arrValueListForInsert.Add(objzx_ViewpointEN.PdfPageTop.ToString());
 }
 
 if (objzx_ViewpointEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.PdfZoom);
 var strPdfZoom = objzx_ViewpointEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_ViewpointEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Viewpoint.GroupTextId);
 var strGroupTextId = objzx_ViewpointEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_Viewpoint");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewzx_Viewpoints(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
strSQL = "Select * from zx_Viewpoint where zxViewpointId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_Viewpoint");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strzxViewpointId = oRow[conzx_Viewpoint.zxViewpointId].ToString().Trim();
if (IsExist(strzxViewpointId))
{
 string strResult = "关键字变量值为:" + string.Format("zxViewpointId = {0}", strzxViewpointId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clszx_ViewpointEN._CurrTabName ].NewRow();
objRow[conzx_Viewpoint.zxViewpointId] = oRow[conzx_Viewpoint.zxViewpointId].ToString().Trim(); //观点Id
objRow[conzx_Viewpoint.ViewpointName] = oRow[conzx_Viewpoint.ViewpointName].ToString().Trim(); //观点名称
objRow[conzx_Viewpoint.ViewpointContent] = oRow[conzx_Viewpoint.ViewpointContent].ToString().Trim(); //观点内容
objRow[conzx_Viewpoint.zxViewpointTypeId] = oRow[conzx_Viewpoint.zxViewpointTypeId].ToString().Trim(); //观点类型Id
objRow[conzx_Viewpoint.Reason] = oRow[conzx_Viewpoint.Reason].ToString().Trim(); //理由
objRow[conzx_Viewpoint.Source] = oRow[conzx_Viewpoint.Source].ToString().Trim(); //来源
objRow[conzx_Viewpoint.VPProposePeople] = oRow[conzx_Viewpoint.VPProposePeople].ToString().Trim(); //观点提出人
objRow[conzx_Viewpoint.IsSubmit] = oRow[conzx_Viewpoint.IsSubmit].ToString().Trim(); //是否提交
objRow[conzx_Viewpoint.UserTypeId] = oRow[conzx_Viewpoint.UserTypeId].ToString().Trim(); //用户类型Id
objRow[conzx_Viewpoint.TextId] = oRow[conzx_Viewpoint.TextId].ToString().Trim(); //课件Id
objRow[conzx_Viewpoint.VoteCount] = oRow[conzx_Viewpoint.VoteCount].ToString().Trim(); //点赞计数
objRow[conzx_Viewpoint.AppraiseCount] = oRow[conzx_Viewpoint.AppraiseCount].ToString().Trim(); //评论数
objRow[conzx_Viewpoint.Score] = oRow[conzx_Viewpoint.Score].ToString().Trim(); //评分
objRow[conzx_Viewpoint.StuScore] = oRow[conzx_Viewpoint.StuScore].ToString().Trim(); //学生平均分
objRow[conzx_Viewpoint.TeaScore] = oRow[conzx_Viewpoint.TeaScore].ToString().Trim(); //教师评分
objRow[conzx_Viewpoint.IdCurrEduCls] = oRow[conzx_Viewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conzx_Viewpoint.PdfContent] = oRow[conzx_Viewpoint.PdfContent].ToString().Trim(); //Pdf内容
objRow[conzx_Viewpoint.PdfPageNum] = oRow[conzx_Viewpoint.PdfPageNum].ToString().Trim(); //Pdf页码
objRow[conzx_Viewpoint.CitationCount] = oRow[conzx_Viewpoint.CitationCount].ToString().Trim(); //引用统计
objRow[conzx_Viewpoint.VersionCount] = oRow[conzx_Viewpoint.VersionCount].ToString().Trim(); //版本统计
objRow[conzx_Viewpoint.zxShareId] = oRow[conzx_Viewpoint.zxShareId].ToString().Trim(); //分享Id
objRow[conzx_Viewpoint.CreateDate] = oRow[conzx_Viewpoint.CreateDate].ToString().Trim(); //建立日期
objRow[conzx_Viewpoint.UpdDate] = oRow[conzx_Viewpoint.UpdDate].ToString().Trim(); //修改日期
objRow[conzx_Viewpoint.UpdUser] = oRow[conzx_Viewpoint.UpdUser].ToString().Trim(); //修改人
objRow[conzx_Viewpoint.Memo] = oRow[conzx_Viewpoint.Memo].ToString().Trim(); //备注
objRow[conzx_Viewpoint.TeammenberId] = oRow[conzx_Viewpoint.TeammenberId].ToString().Trim(); //主键
objRow[conzx_Viewpoint.PdfDivLet] = oRow[conzx_Viewpoint.PdfDivLet].ToString().Trim(); //PdfDivLet
objRow[conzx_Viewpoint.PdfDivTop] = oRow[conzx_Viewpoint.PdfDivTop].ToString().Trim(); //PdfDivTop
objRow[conzx_Viewpoint.PdfPageNumIn] = oRow[conzx_Viewpoint.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objRow[conzx_Viewpoint.PdfPageTop] = oRow[conzx_Viewpoint.PdfPageTop].ToString().Trim(); //pdf页面顶部位置
objRow[conzx_Viewpoint.PdfZoom] = oRow[conzx_Viewpoint.PdfZoom].ToString().Trim(); //PdfZoom
objRow[conzx_Viewpoint.GroupTextId] = oRow[conzx_Viewpoint.GroupTextId].ToString().Trim(); //小组Id
 objDS.Tables[clszx_ViewpointEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clszx_ViewpointEN._CurrTabName);
}
catch(Exception objException) 
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
objSQL.SQLConnect.Close();
}
return true;
}

 #endregion 添加记录

 #region 修改记录

 /// <summary>
 /// 功能:通过ADO修改记录
 /// (AutoGCLib.DALCode4CSharp:GenUpdate)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clszx_ViewpointEN objzx_ViewpointEN)
{
 if (objzx_ViewpointEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ViewpointEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
strSQL = "Select * from zx_Viewpoint where zxViewpointId = " + "'"+ objzx_ViewpointEN.zxViewpointId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clszx_ViewpointEN._CurrTabName);
if (objDS.Tables[clszx_ViewpointEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:zxViewpointId = " + "'"+ objzx_ViewpointEN.zxViewpointId+"'");
return false;
}
objRow = objDS.Tables[clszx_ViewpointEN._CurrTabName].Rows[0];
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.zxViewpointId))
 {
objRow[conzx_Viewpoint.zxViewpointId] = objzx_ViewpointEN.zxViewpointId; //观点Id
 }
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.ViewpointName))
 {
objRow[conzx_Viewpoint.ViewpointName] = objzx_ViewpointEN.ViewpointName; //观点名称
 }
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.ViewpointContent))
 {
objRow[conzx_Viewpoint.ViewpointContent] = objzx_ViewpointEN.ViewpointContent; //观点内容
 }
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.zxViewpointTypeId))
 {
objRow[conzx_Viewpoint.zxViewpointTypeId] = objzx_ViewpointEN.zxViewpointTypeId; //观点类型Id
 }
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.Reason))
 {
objRow[conzx_Viewpoint.Reason] = objzx_ViewpointEN.Reason; //理由
 }
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.Source))
 {
objRow[conzx_Viewpoint.Source] = objzx_ViewpointEN.Source; //来源
 }
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.VPProposePeople))
 {
objRow[conzx_Viewpoint.VPProposePeople] = objzx_ViewpointEN.VPProposePeople; //观点提出人
 }
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.IsSubmit))
 {
objRow[conzx_Viewpoint.IsSubmit] = objzx_ViewpointEN.IsSubmit; //是否提交
 }
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.UserTypeId))
 {
objRow[conzx_Viewpoint.UserTypeId] = objzx_ViewpointEN.UserTypeId; //用户类型Id
 }
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.TextId))
 {
objRow[conzx_Viewpoint.TextId] = objzx_ViewpointEN.TextId; //课件Id
 }
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.VoteCount))
 {
objRow[conzx_Viewpoint.VoteCount] = objzx_ViewpointEN.VoteCount; //点赞计数
 }
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.AppraiseCount))
 {
objRow[conzx_Viewpoint.AppraiseCount] = objzx_ViewpointEN.AppraiseCount; //评论数
 }
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.Score))
 {
objRow[conzx_Viewpoint.Score] = objzx_ViewpointEN.Score; //评分
 }
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.StuScore))
 {
objRow[conzx_Viewpoint.StuScore] = objzx_ViewpointEN.StuScore; //学生平均分
 }
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.TeaScore))
 {
objRow[conzx_Viewpoint.TeaScore] = objzx_ViewpointEN.TeaScore; //教师评分
 }
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.IdCurrEduCls))
 {
objRow[conzx_Viewpoint.IdCurrEduCls] = objzx_ViewpointEN.IdCurrEduCls; //教学班流水号
 }
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfContent))
 {
objRow[conzx_Viewpoint.PdfContent] = objzx_ViewpointEN.PdfContent; //Pdf内容
 }
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfPageNum))
 {
objRow[conzx_Viewpoint.PdfPageNum] = objzx_ViewpointEN.PdfPageNum; //Pdf页码
 }
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.CitationCount))
 {
objRow[conzx_Viewpoint.CitationCount] = objzx_ViewpointEN.CitationCount; //引用统计
 }
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.VersionCount))
 {
objRow[conzx_Viewpoint.VersionCount] = objzx_ViewpointEN.VersionCount; //版本统计
 }
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.zxShareId))
 {
objRow[conzx_Viewpoint.zxShareId] = objzx_ViewpointEN.zxShareId; //分享Id
 }
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.CreateDate))
 {
objRow[conzx_Viewpoint.CreateDate] = objzx_ViewpointEN.CreateDate; //建立日期
 }
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.UpdDate))
 {
objRow[conzx_Viewpoint.UpdDate] = objzx_ViewpointEN.UpdDate; //修改日期
 }
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.UpdUser))
 {
objRow[conzx_Viewpoint.UpdUser] = objzx_ViewpointEN.UpdUser; //修改人
 }
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.Memo))
 {
objRow[conzx_Viewpoint.Memo] = objzx_ViewpointEN.Memo; //备注
 }
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.TeammenberId))
 {
objRow[conzx_Viewpoint.TeammenberId] = objzx_ViewpointEN.TeammenberId; //主键
 }
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfDivLet))
 {
objRow[conzx_Viewpoint.PdfDivLet] = objzx_ViewpointEN.PdfDivLet; //PdfDivLet
 }
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfDivTop))
 {
objRow[conzx_Viewpoint.PdfDivTop] = objzx_ViewpointEN.PdfDivTop; //PdfDivTop
 }
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfPageNumIn))
 {
objRow[conzx_Viewpoint.PdfPageNumIn] = objzx_ViewpointEN.PdfPageNumIn; //PdfPageNumIn
 }
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfPageTop))
 {
objRow[conzx_Viewpoint.PdfPageTop] = objzx_ViewpointEN.PdfPageTop; //pdf页面顶部位置
 }
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfZoom))
 {
objRow[conzx_Viewpoint.PdfZoom] = objzx_ViewpointEN.PdfZoom; //PdfZoom
 }
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.GroupTextId))
 {
objRow[conzx_Viewpoint.GroupTextId] = objzx_ViewpointEN.GroupTextId; //小组Id
 }
try
{
objDA.Update(objDS, clszx_ViewpointEN._CurrTabName);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
return true;
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_ViewpointEN objzx_ViewpointEN)
{
 if (objzx_ViewpointEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ViewpointEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update zx_Viewpoint Set ");
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.ViewpointName))
 {
 if (objzx_ViewpointEN.ViewpointName !=  null)
 {
 var strViewpointName = objzx_ViewpointEN.ViewpointName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewpointName, conzx_Viewpoint.ViewpointName); //观点名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.ViewpointName); //观点名称
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.ViewpointContent))
 {
 if (objzx_ViewpointEN.ViewpointContent !=  null)
 {
 var strViewpointContent = objzx_ViewpointEN.ViewpointContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewpointContent, conzx_Viewpoint.ViewpointContent); //观点内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.ViewpointContent); //观点内容
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.zxViewpointTypeId))
 {
 if (objzx_ViewpointEN.zxViewpointTypeId !=  null)
 {
 var strzxViewpointTypeId = objzx_ViewpointEN.zxViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxViewpointTypeId, conzx_Viewpoint.zxViewpointTypeId); //观点类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.zxViewpointTypeId); //观点类型Id
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.Reason))
 {
 if (objzx_ViewpointEN.Reason !=  null)
 {
 var strReason = objzx_ViewpointEN.Reason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReason, conzx_Viewpoint.Reason); //理由
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.Reason); //理由
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.Source))
 {
 if (objzx_ViewpointEN.Source !=  null)
 {
 var strSource = objzx_ViewpointEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSource, conzx_Viewpoint.Source); //来源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.Source); //来源
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.VPProposePeople))
 {
 if (objzx_ViewpointEN.VPProposePeople !=  null)
 {
 var strVPProposePeople = objzx_ViewpointEN.VPProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVPProposePeople, conzx_Viewpoint.VPProposePeople); //观点提出人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.VPProposePeople); //观点提出人
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_ViewpointEN.IsSubmit == true?"1":"0", conzx_Viewpoint.IsSubmit); //是否提交
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.UserTypeId))
 {
 if (objzx_ViewpointEN.UserTypeId !=  null)
 {
 var strUserTypeId = objzx_ViewpointEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserTypeId, conzx_Viewpoint.UserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.UserTypeId); //用户类型Id
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.TextId))
 {
 if (objzx_ViewpointEN.TextId !=  null)
 {
 var strTextId = objzx_ViewpointEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_Viewpoint.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.TextId); //课件Id
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.VoteCount))
 {
 if (objzx_ViewpointEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.VoteCount, conzx_Viewpoint.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.VoteCount); //点赞计数
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.AppraiseCount))
 {
 if (objzx_ViewpointEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.AppraiseCount, conzx_Viewpoint.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.AppraiseCount); //评论数
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.Score))
 {
 if (objzx_ViewpointEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.Score, conzx_Viewpoint.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.Score); //评分
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.StuScore))
 {
 if (objzx_ViewpointEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.StuScore, conzx_Viewpoint.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.StuScore); //学生平均分
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.TeaScore))
 {
 if (objzx_ViewpointEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.TeaScore, conzx_Viewpoint.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.TeaScore); //教师评分
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.IdCurrEduCls))
 {
 if (objzx_ViewpointEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_ViewpointEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_Viewpoint.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfContent))
 {
 if (objzx_ViewpointEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_ViewpointEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conzx_Viewpoint.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.PdfContent); //Pdf内容
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfPageNum))
 {
 if (objzx_ViewpointEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.PdfPageNum, conzx_Viewpoint.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.CitationCount))
 {
 if (objzx_ViewpointEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.CitationCount, conzx_Viewpoint.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.CitationCount); //引用统计
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.VersionCount))
 {
 if (objzx_ViewpointEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.VersionCount, conzx_Viewpoint.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.VersionCount); //版本统计
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.zxShareId))
 {
 if (objzx_ViewpointEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_ViewpointEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxShareId, conzx_Viewpoint.zxShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.zxShareId); //分享Id
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.CreateDate))
 {
 if (objzx_ViewpointEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_ViewpointEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conzx_Viewpoint.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.CreateDate); //建立日期
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.UpdDate))
 {
 if (objzx_ViewpointEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_ViewpointEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_Viewpoint.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.UpdDate); //修改日期
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.UpdUser))
 {
 if (objzx_ViewpointEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_ViewpointEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_Viewpoint.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.UpdUser); //修改人
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.Memo))
 {
 if (objzx_ViewpointEN.Memo !=  null)
 {
 var strMemo = objzx_ViewpointEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_Viewpoint.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.Memo); //备注
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.TeammenberId))
 {
 if (objzx_ViewpointEN.TeammenberId !=  null)
 {
 var strTeammenberId = objzx_ViewpointEN.TeammenberId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeammenberId, conzx_Viewpoint.TeammenberId); //主键
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.TeammenberId); //主键
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfDivLet))
 {
 if (objzx_ViewpointEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_ViewpointEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivLet, conzx_Viewpoint.PdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.PdfDivLet); //PdfDivLet
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfDivTop))
 {
 if (objzx_ViewpointEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_ViewpointEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivTop, conzx_Viewpoint.PdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.PdfDivTop); //PdfDivTop
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfPageNumIn))
 {
 if (objzx_ViewpointEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_ViewpointEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfPageNumIn, conzx_Viewpoint.PdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.PdfPageNumIn); //PdfPageNumIn
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfPageTop))
 {
 if (objzx_ViewpointEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.PdfPageTop, conzx_Viewpoint.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfZoom))
 {
 if (objzx_ViewpointEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_ViewpointEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfZoom, conzx_Viewpoint.PdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.PdfZoom); //PdfZoom
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.GroupTextId))
 {
 if (objzx_ViewpointEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_ViewpointEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_Viewpoint.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.GroupTextId); //小组Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where zxViewpointId = '{0}'", objzx_ViewpointEN.zxViewpointId); 
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString());
}
catch (Exception objException)
{
string strMsg = string.Format("发生错误:[{0}].SQL:[{1}].({2})",
     objException.Message, sbSQL.ToString(), clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clszx_ViewpointEN objzx_ViewpointEN, string strCondition)
{
 if (objzx_ViewpointEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ViewpointEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_Viewpoint Set ");
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.ViewpointName))
 {
 if (objzx_ViewpointEN.ViewpointName !=  null)
 {
 var strViewpointName = objzx_ViewpointEN.ViewpointName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewpointName = '{0}',", strViewpointName); //观点名称
 }
 else
 {
 sbSQL.Append(" ViewpointName = null,"); //观点名称
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.ViewpointContent))
 {
 if (objzx_ViewpointEN.ViewpointContent !=  null)
 {
 var strViewpointContent = objzx_ViewpointEN.ViewpointContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewpointContent = '{0}',", strViewpointContent); //观点内容
 }
 else
 {
 sbSQL.Append(" ViewpointContent = null,"); //观点内容
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.zxViewpointTypeId))
 {
 if (objzx_ViewpointEN.zxViewpointTypeId !=  null)
 {
 var strzxViewpointTypeId = objzx_ViewpointEN.zxViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxViewpointTypeId = '{0}',", strzxViewpointTypeId); //观点类型Id
 }
 else
 {
 sbSQL.Append(" zxViewpointTypeId = null,"); //观点类型Id
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.Reason))
 {
 if (objzx_ViewpointEN.Reason !=  null)
 {
 var strReason = objzx_ViewpointEN.Reason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Reason = '{0}',", strReason); //理由
 }
 else
 {
 sbSQL.Append(" Reason = null,"); //理由
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.Source))
 {
 if (objzx_ViewpointEN.Source !=  null)
 {
 var strSource = objzx_ViewpointEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Source = '{0}',", strSource); //来源
 }
 else
 {
 sbSQL.Append(" Source = null,"); //来源
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.VPProposePeople))
 {
 if (objzx_ViewpointEN.VPProposePeople !=  null)
 {
 var strVPProposePeople = objzx_ViewpointEN.VPProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VPProposePeople = '{0}',", strVPProposePeople); //观点提出人
 }
 else
 {
 sbSQL.Append(" VPProposePeople = null,"); //观点提出人
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_ViewpointEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.UserTypeId))
 {
 if (objzx_ViewpointEN.UserTypeId !=  null)
 {
 var strUserTypeId = objzx_ViewpointEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserTypeId = '{0}',", strUserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.Append(" UserTypeId = null,"); //用户类型Id
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.TextId))
 {
 if (objzx_ViewpointEN.TextId !=  null)
 {
 var strTextId = objzx_ViewpointEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.VoteCount))
 {
 if (objzx_ViewpointEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.VoteCount, conzx_Viewpoint.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.VoteCount); //点赞计数
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.AppraiseCount))
 {
 if (objzx_ViewpointEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.AppraiseCount, conzx_Viewpoint.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.AppraiseCount); //评论数
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.Score))
 {
 if (objzx_ViewpointEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.Score, conzx_Viewpoint.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.Score); //评分
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.StuScore))
 {
 if (objzx_ViewpointEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.StuScore, conzx_Viewpoint.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.StuScore); //学生平均分
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.TeaScore))
 {
 if (objzx_ViewpointEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.TeaScore, conzx_Viewpoint.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.TeaScore); //教师评分
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.IdCurrEduCls))
 {
 if (objzx_ViewpointEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_ViewpointEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfContent))
 {
 if (objzx_ViewpointEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_ViewpointEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfPageNum))
 {
 if (objzx_ViewpointEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.PdfPageNum, conzx_Viewpoint.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.CitationCount))
 {
 if (objzx_ViewpointEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.CitationCount, conzx_Viewpoint.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.CitationCount); //引用统计
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.VersionCount))
 {
 if (objzx_ViewpointEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.VersionCount, conzx_Viewpoint.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.VersionCount); //版本统计
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.zxShareId))
 {
 if (objzx_ViewpointEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_ViewpointEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxShareId = '{0}',", strzxShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" zxShareId = null,"); //分享Id
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.CreateDate))
 {
 if (objzx_ViewpointEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_ViewpointEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.UpdDate))
 {
 if (objzx_ViewpointEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_ViewpointEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.UpdUser))
 {
 if (objzx_ViewpointEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_ViewpointEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.Memo))
 {
 if (objzx_ViewpointEN.Memo !=  null)
 {
 var strMemo = objzx_ViewpointEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.TeammenberId))
 {
 if (objzx_ViewpointEN.TeammenberId !=  null)
 {
 var strTeammenberId = objzx_ViewpointEN.TeammenberId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeammenberId = '{0}',", strTeammenberId); //主键
 }
 else
 {
 sbSQL.Append(" TeammenberId = null,"); //主键
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfDivLet))
 {
 if (objzx_ViewpointEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_ViewpointEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivLet = '{0}',", strPdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.Append(" PdfDivLet = null,"); //PdfDivLet
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfDivTop))
 {
 if (objzx_ViewpointEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_ViewpointEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivTop = '{0}',", strPdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.Append(" PdfDivTop = null,"); //PdfDivTop
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfPageNumIn))
 {
 if (objzx_ViewpointEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_ViewpointEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfPageNumIn = '{0}',", strPdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.Append(" PdfPageNumIn = null,"); //PdfPageNumIn
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfPageTop))
 {
 if (objzx_ViewpointEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.PdfPageTop, conzx_Viewpoint.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfZoom))
 {
 if (objzx_ViewpointEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_ViewpointEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfZoom = '{0}',", strPdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.Append(" PdfZoom = null,"); //PdfZoom
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.GroupTextId))
 {
 if (objzx_ViewpointEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_ViewpointEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupTextId = '{0}',", strGroupTextId); //小组Id
 }
 else
 {
 sbSQL.Append(" GroupTextId = null,"); //小组Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where {0}", strCondition); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString());
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式,根据条件修改记录.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithConditionTransaction)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clszx_ViewpointEN objzx_ViewpointEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_ViewpointEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ViewpointEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_Viewpoint Set ");
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.ViewpointName))
 {
 if (objzx_ViewpointEN.ViewpointName !=  null)
 {
 var strViewpointName = objzx_ViewpointEN.ViewpointName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewpointName = '{0}',", strViewpointName); //观点名称
 }
 else
 {
 sbSQL.Append(" ViewpointName = null,"); //观点名称
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.ViewpointContent))
 {
 if (objzx_ViewpointEN.ViewpointContent !=  null)
 {
 var strViewpointContent = objzx_ViewpointEN.ViewpointContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewpointContent = '{0}',", strViewpointContent); //观点内容
 }
 else
 {
 sbSQL.Append(" ViewpointContent = null,"); //观点内容
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.zxViewpointTypeId))
 {
 if (objzx_ViewpointEN.zxViewpointTypeId !=  null)
 {
 var strzxViewpointTypeId = objzx_ViewpointEN.zxViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxViewpointTypeId = '{0}',", strzxViewpointTypeId); //观点类型Id
 }
 else
 {
 sbSQL.Append(" zxViewpointTypeId = null,"); //观点类型Id
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.Reason))
 {
 if (objzx_ViewpointEN.Reason !=  null)
 {
 var strReason = objzx_ViewpointEN.Reason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Reason = '{0}',", strReason); //理由
 }
 else
 {
 sbSQL.Append(" Reason = null,"); //理由
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.Source))
 {
 if (objzx_ViewpointEN.Source !=  null)
 {
 var strSource = objzx_ViewpointEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Source = '{0}',", strSource); //来源
 }
 else
 {
 sbSQL.Append(" Source = null,"); //来源
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.VPProposePeople))
 {
 if (objzx_ViewpointEN.VPProposePeople !=  null)
 {
 var strVPProposePeople = objzx_ViewpointEN.VPProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VPProposePeople = '{0}',", strVPProposePeople); //观点提出人
 }
 else
 {
 sbSQL.Append(" VPProposePeople = null,"); //观点提出人
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_ViewpointEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.UserTypeId))
 {
 if (objzx_ViewpointEN.UserTypeId !=  null)
 {
 var strUserTypeId = objzx_ViewpointEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserTypeId = '{0}',", strUserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.Append(" UserTypeId = null,"); //用户类型Id
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.TextId))
 {
 if (objzx_ViewpointEN.TextId !=  null)
 {
 var strTextId = objzx_ViewpointEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.VoteCount))
 {
 if (objzx_ViewpointEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.VoteCount, conzx_Viewpoint.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.VoteCount); //点赞计数
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.AppraiseCount))
 {
 if (objzx_ViewpointEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.AppraiseCount, conzx_Viewpoint.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.AppraiseCount); //评论数
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.Score))
 {
 if (objzx_ViewpointEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.Score, conzx_Viewpoint.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.Score); //评分
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.StuScore))
 {
 if (objzx_ViewpointEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.StuScore, conzx_Viewpoint.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.StuScore); //学生平均分
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.TeaScore))
 {
 if (objzx_ViewpointEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.TeaScore, conzx_Viewpoint.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.TeaScore); //教师评分
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.IdCurrEduCls))
 {
 if (objzx_ViewpointEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_ViewpointEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfContent))
 {
 if (objzx_ViewpointEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_ViewpointEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfPageNum))
 {
 if (objzx_ViewpointEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.PdfPageNum, conzx_Viewpoint.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.CitationCount))
 {
 if (objzx_ViewpointEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.CitationCount, conzx_Viewpoint.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.CitationCount); //引用统计
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.VersionCount))
 {
 if (objzx_ViewpointEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.VersionCount, conzx_Viewpoint.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.VersionCount); //版本统计
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.zxShareId))
 {
 if (objzx_ViewpointEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_ViewpointEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxShareId = '{0}',", strzxShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" zxShareId = null,"); //分享Id
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.CreateDate))
 {
 if (objzx_ViewpointEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_ViewpointEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.UpdDate))
 {
 if (objzx_ViewpointEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_ViewpointEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.UpdUser))
 {
 if (objzx_ViewpointEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_ViewpointEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.Memo))
 {
 if (objzx_ViewpointEN.Memo !=  null)
 {
 var strMemo = objzx_ViewpointEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.TeammenberId))
 {
 if (objzx_ViewpointEN.TeammenberId !=  null)
 {
 var strTeammenberId = objzx_ViewpointEN.TeammenberId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeammenberId = '{0}',", strTeammenberId); //主键
 }
 else
 {
 sbSQL.Append(" TeammenberId = null,"); //主键
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfDivLet))
 {
 if (objzx_ViewpointEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_ViewpointEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivLet = '{0}',", strPdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.Append(" PdfDivLet = null,"); //PdfDivLet
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfDivTop))
 {
 if (objzx_ViewpointEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_ViewpointEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivTop = '{0}',", strPdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.Append(" PdfDivTop = null,"); //PdfDivTop
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfPageNumIn))
 {
 if (objzx_ViewpointEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_ViewpointEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfPageNumIn = '{0}',", strPdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.Append(" PdfPageNumIn = null,"); //PdfPageNumIn
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfPageTop))
 {
 if (objzx_ViewpointEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.PdfPageTop, conzx_Viewpoint.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfZoom))
 {
 if (objzx_ViewpointEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_ViewpointEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfZoom = '{0}',", strPdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.Append(" PdfZoom = null,"); //PdfZoom
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.GroupTextId))
 {
 if (objzx_ViewpointEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_ViewpointEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupTextId = '{0}',", strGroupTextId); //小组Id
 }
 else
 {
 sbSQL.Append(" GroupTextId = null,"); //小组Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where {0}", strCondition); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；
 /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;
 /// /// 3、支持事务处理.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithTransaction2)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_ViewpointEN objzx_ViewpointEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_ViewpointEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ViewpointEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_Viewpoint Set ");
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.ViewpointName))
 {
 if (objzx_ViewpointEN.ViewpointName !=  null)
 {
 var strViewpointName = objzx_ViewpointEN.ViewpointName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewpointName, conzx_Viewpoint.ViewpointName); //观点名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.ViewpointName); //观点名称
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.ViewpointContent))
 {
 if (objzx_ViewpointEN.ViewpointContent !=  null)
 {
 var strViewpointContent = objzx_ViewpointEN.ViewpointContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewpointContent, conzx_Viewpoint.ViewpointContent); //观点内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.ViewpointContent); //观点内容
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.zxViewpointTypeId))
 {
 if (objzx_ViewpointEN.zxViewpointTypeId !=  null)
 {
 var strzxViewpointTypeId = objzx_ViewpointEN.zxViewpointTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxViewpointTypeId, conzx_Viewpoint.zxViewpointTypeId); //观点类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.zxViewpointTypeId); //观点类型Id
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.Reason))
 {
 if (objzx_ViewpointEN.Reason !=  null)
 {
 var strReason = objzx_ViewpointEN.Reason.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReason, conzx_Viewpoint.Reason); //理由
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.Reason); //理由
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.Source))
 {
 if (objzx_ViewpointEN.Source !=  null)
 {
 var strSource = objzx_ViewpointEN.Source.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSource, conzx_Viewpoint.Source); //来源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.Source); //来源
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.VPProposePeople))
 {
 if (objzx_ViewpointEN.VPProposePeople !=  null)
 {
 var strVPProposePeople = objzx_ViewpointEN.VPProposePeople.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVPProposePeople, conzx_Viewpoint.VPProposePeople); //观点提出人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.VPProposePeople); //观点提出人
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_ViewpointEN.IsSubmit == true?"1":"0", conzx_Viewpoint.IsSubmit); //是否提交
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.UserTypeId))
 {
 if (objzx_ViewpointEN.UserTypeId !=  null)
 {
 var strUserTypeId = objzx_ViewpointEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserTypeId, conzx_Viewpoint.UserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.UserTypeId); //用户类型Id
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.TextId))
 {
 if (objzx_ViewpointEN.TextId !=  null)
 {
 var strTextId = objzx_ViewpointEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_Viewpoint.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.TextId); //课件Id
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.VoteCount))
 {
 if (objzx_ViewpointEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.VoteCount, conzx_Viewpoint.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.VoteCount); //点赞计数
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.AppraiseCount))
 {
 if (objzx_ViewpointEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.AppraiseCount, conzx_Viewpoint.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.AppraiseCount); //评论数
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.Score))
 {
 if (objzx_ViewpointEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.Score, conzx_Viewpoint.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.Score); //评分
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.StuScore))
 {
 if (objzx_ViewpointEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.StuScore, conzx_Viewpoint.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.StuScore); //学生平均分
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.TeaScore))
 {
 if (objzx_ViewpointEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.TeaScore, conzx_Viewpoint.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.TeaScore); //教师评分
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.IdCurrEduCls))
 {
 if (objzx_ViewpointEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_ViewpointEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_Viewpoint.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfContent))
 {
 if (objzx_ViewpointEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_ViewpointEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conzx_Viewpoint.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.PdfContent); //Pdf内容
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfPageNum))
 {
 if (objzx_ViewpointEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.PdfPageNum, conzx_Viewpoint.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.CitationCount))
 {
 if (objzx_ViewpointEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.CitationCount, conzx_Viewpoint.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.CitationCount); //引用统计
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.VersionCount))
 {
 if (objzx_ViewpointEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.VersionCount, conzx_Viewpoint.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.VersionCount); //版本统计
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.zxShareId))
 {
 if (objzx_ViewpointEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_ViewpointEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxShareId, conzx_Viewpoint.zxShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.zxShareId); //分享Id
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.CreateDate))
 {
 if (objzx_ViewpointEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_ViewpointEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conzx_Viewpoint.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.CreateDate); //建立日期
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.UpdDate))
 {
 if (objzx_ViewpointEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_ViewpointEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_Viewpoint.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.UpdDate); //修改日期
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.UpdUser))
 {
 if (objzx_ViewpointEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_ViewpointEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_Viewpoint.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.UpdUser); //修改人
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.Memo))
 {
 if (objzx_ViewpointEN.Memo !=  null)
 {
 var strMemo = objzx_ViewpointEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_Viewpoint.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.Memo); //备注
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.TeammenberId))
 {
 if (objzx_ViewpointEN.TeammenberId !=  null)
 {
 var strTeammenberId = objzx_ViewpointEN.TeammenberId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeammenberId, conzx_Viewpoint.TeammenberId); //主键
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.TeammenberId); //主键
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfDivLet))
 {
 if (objzx_ViewpointEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_ViewpointEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivLet, conzx_Viewpoint.PdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.PdfDivLet); //PdfDivLet
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfDivTop))
 {
 if (objzx_ViewpointEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_ViewpointEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivTop, conzx_Viewpoint.PdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.PdfDivTop); //PdfDivTop
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfPageNumIn))
 {
 if (objzx_ViewpointEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_ViewpointEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfPageNumIn, conzx_Viewpoint.PdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.PdfPageNumIn); //PdfPageNumIn
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfPageTop))
 {
 if (objzx_ViewpointEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ViewpointEN.PdfPageTop, conzx_Viewpoint.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.PdfZoom))
 {
 if (objzx_ViewpointEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_ViewpointEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfZoom, conzx_Viewpoint.PdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.PdfZoom); //PdfZoom
 }
 }
 
 if (objzx_ViewpointEN.IsUpdated(conzx_Viewpoint.GroupTextId))
 {
 if (objzx_ViewpointEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_ViewpointEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_Viewpoint.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Viewpoint.GroupTextId); //小组Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where zxViewpointId = '{0}'", objzx_ViewpointEN.zxViewpointId); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 #endregion 修改记录

 #region 删除记录

 /// <summary>
 /// 功能:删除关键字所指定的记录,通过存储过程(SP)来删除。
 /// (AutoGCLib.DALCode4CSharp:GenDelRecordBySP)
 /// </summary>
 /// <param name = "strzxViewpointId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strzxViewpointId) 
{
CheckPrimaryKey(strzxViewpointId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strzxViewpointId,
};
 objSQL.ExecSP("zx_Viewpoint_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strzxViewpointId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strzxViewpointId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strzxViewpointId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
//删除zx_Viewpoint本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_Viewpoint where zxViewpointId = " + "'"+ strzxViewpointId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delzx_Viewpoint(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
else strKeyList +=  "," + "'" + lstKey[i].ToString() + "'";
}
strSQL = "";
//删除zx_Viewpoint本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_Viewpoint where zxViewpointId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strzxViewpointId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strzxViewpointId) 
{
CheckPrimaryKey(strzxViewpointId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
//删除zx_Viewpoint本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_Viewpoint where zxViewpointId = " + "'"+ strzxViewpointId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delzx_Viewpoint(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clszx_ViewpointDA: Delzx_Viewpoint)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_Viewpoint where " + strCondition ;
}
int intRecoCount = objSQL.ExecSql2(strSQL);
return intRecoCount;
}



 /// <summary>
 /// 功能:删除满足条件的多条记录,同时处理事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRecWithTransaction)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回是否删除成功。</returns>
public bool Delzx_ViewpointWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clszx_ViewpointDA: Delzx_ViewpointWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_Viewpoint where " + strCondition ;
}
 bool bolResult = objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
return bolResult;
}


 #endregion 删除记录

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objzx_ViewpointENS">源对象</param>
 /// <param name = "objzx_ViewpointENT">目标对象</param>
public void CopyTo(clszx_ViewpointEN objzx_ViewpointENS, clszx_ViewpointEN objzx_ViewpointENT)
{
objzx_ViewpointENT.zxViewpointId = objzx_ViewpointENS.zxViewpointId; //观点Id
objzx_ViewpointENT.ViewpointName = objzx_ViewpointENS.ViewpointName; //观点名称
objzx_ViewpointENT.ViewpointContent = objzx_ViewpointENS.ViewpointContent; //观点内容
objzx_ViewpointENT.zxViewpointTypeId = objzx_ViewpointENS.zxViewpointTypeId; //观点类型Id
objzx_ViewpointENT.Reason = objzx_ViewpointENS.Reason; //理由
objzx_ViewpointENT.Source = objzx_ViewpointENS.Source; //来源
objzx_ViewpointENT.VPProposePeople = objzx_ViewpointENS.VPProposePeople; //观点提出人
objzx_ViewpointENT.IsSubmit = objzx_ViewpointENS.IsSubmit; //是否提交
objzx_ViewpointENT.UserTypeId = objzx_ViewpointENS.UserTypeId; //用户类型Id
objzx_ViewpointENT.TextId = objzx_ViewpointENS.TextId; //课件Id
objzx_ViewpointENT.VoteCount = objzx_ViewpointENS.VoteCount; //点赞计数
objzx_ViewpointENT.AppraiseCount = objzx_ViewpointENS.AppraiseCount; //评论数
objzx_ViewpointENT.Score = objzx_ViewpointENS.Score; //评分
objzx_ViewpointENT.StuScore = objzx_ViewpointENS.StuScore; //学生平均分
objzx_ViewpointENT.TeaScore = objzx_ViewpointENS.TeaScore; //教师评分
objzx_ViewpointENT.IdCurrEduCls = objzx_ViewpointENS.IdCurrEduCls; //教学班流水号
objzx_ViewpointENT.PdfContent = objzx_ViewpointENS.PdfContent; //Pdf内容
objzx_ViewpointENT.PdfPageNum = objzx_ViewpointENS.PdfPageNum; //Pdf页码
objzx_ViewpointENT.CitationCount = objzx_ViewpointENS.CitationCount; //引用统计
objzx_ViewpointENT.VersionCount = objzx_ViewpointENS.VersionCount; //版本统计
objzx_ViewpointENT.zxShareId = objzx_ViewpointENS.zxShareId; //分享Id
objzx_ViewpointENT.CreateDate = objzx_ViewpointENS.CreateDate; //建立日期
objzx_ViewpointENT.UpdDate = objzx_ViewpointENS.UpdDate; //修改日期
objzx_ViewpointENT.UpdUser = objzx_ViewpointENS.UpdUser; //修改人
objzx_ViewpointENT.Memo = objzx_ViewpointENS.Memo; //备注
objzx_ViewpointENT.TeammenberId = objzx_ViewpointENS.TeammenberId; //主键
objzx_ViewpointENT.PdfDivLet = objzx_ViewpointENS.PdfDivLet; //PdfDivLet
objzx_ViewpointENT.PdfDivTop = objzx_ViewpointENS.PdfDivTop; //PdfDivTop
objzx_ViewpointENT.PdfPageNumIn = objzx_ViewpointENS.PdfPageNumIn; //PdfPageNumIn
objzx_ViewpointENT.PdfPageTop = objzx_ViewpointENS.PdfPageTop; //pdf页面顶部位置
objzx_ViewpointENT.PdfZoom = objzx_ViewpointENS.PdfZoom; //PdfZoom
objzx_ViewpointENT.GroupTextId = objzx_ViewpointENS.GroupTextId; //小组Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clszx_ViewpointEN objzx_ViewpointEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.zxViewpointId, 8, conzx_Viewpoint.zxViewpointId);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.ViewpointName, 500, conzx_Viewpoint.ViewpointName);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.zxViewpointTypeId, 4, conzx_Viewpoint.zxViewpointTypeId);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.Source, 500, conzx_Viewpoint.Source);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.VPProposePeople, 50, conzx_Viewpoint.VPProposePeople);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.UserTypeId, 2, conzx_Viewpoint.UserTypeId);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.TextId, 8, conzx_Viewpoint.TextId);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.IdCurrEduCls, 8, conzx_Viewpoint.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.PdfContent, 2000, conzx_Viewpoint.PdfContent);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.zxShareId, 2, conzx_Viewpoint.zxShareId);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.CreateDate, 20, conzx_Viewpoint.CreateDate);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.UpdDate, 20, conzx_Viewpoint.UpdDate);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.UpdUser, 20, conzx_Viewpoint.UpdUser);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.Memo, 1000, conzx_Viewpoint.Memo);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.TeammenberId, 8, conzx_Viewpoint.TeammenberId);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.PdfDivLet, 50, conzx_Viewpoint.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.PdfDivTop, 50, conzx_Viewpoint.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.PdfPageNumIn, 50, conzx_Viewpoint.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.PdfZoom, 50, conzx_Viewpoint.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.GroupTextId, 8, conzx_Viewpoint.GroupTextId);
//检查字段外键固定长度
 objzx_ViewpointEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clszx_ViewpointEN objzx_ViewpointEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.ViewpointName, 500, conzx_Viewpoint.ViewpointName);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.zxViewpointTypeId, 4, conzx_Viewpoint.zxViewpointTypeId);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.Source, 500, conzx_Viewpoint.Source);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.VPProposePeople, 50, conzx_Viewpoint.VPProposePeople);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.UserTypeId, 2, conzx_Viewpoint.UserTypeId);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.TextId, 8, conzx_Viewpoint.TextId);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.IdCurrEduCls, 8, conzx_Viewpoint.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.PdfContent, 2000, conzx_Viewpoint.PdfContent);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.zxShareId, 2, conzx_Viewpoint.zxShareId);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.CreateDate, 20, conzx_Viewpoint.CreateDate);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.UpdDate, 20, conzx_Viewpoint.UpdDate);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.UpdUser, 20, conzx_Viewpoint.UpdUser);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.Memo, 1000, conzx_Viewpoint.Memo);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.TeammenberId, 8, conzx_Viewpoint.TeammenberId);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.PdfDivLet, 50, conzx_Viewpoint.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.PdfDivTop, 50, conzx_Viewpoint.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.PdfPageNumIn, 50, conzx_Viewpoint.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.PdfZoom, 50, conzx_Viewpoint.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.GroupTextId, 8, conzx_Viewpoint.GroupTextId);
//检查外键字段长度
 objzx_ViewpointEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clszx_ViewpointEN objzx_ViewpointEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.zxViewpointId, 8, conzx_Viewpoint.zxViewpointId);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.ViewpointName, 500, conzx_Viewpoint.ViewpointName);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.zxViewpointTypeId, 4, conzx_Viewpoint.zxViewpointTypeId);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.Source, 500, conzx_Viewpoint.Source);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.VPProposePeople, 50, conzx_Viewpoint.VPProposePeople);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.UserTypeId, 2, conzx_Viewpoint.UserTypeId);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.TextId, 8, conzx_Viewpoint.TextId);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.IdCurrEduCls, 8, conzx_Viewpoint.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.PdfContent, 2000, conzx_Viewpoint.PdfContent);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.zxShareId, 2, conzx_Viewpoint.zxShareId);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.CreateDate, 20, conzx_Viewpoint.CreateDate);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.UpdDate, 20, conzx_Viewpoint.UpdDate);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.UpdUser, 20, conzx_Viewpoint.UpdUser);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.Memo, 1000, conzx_Viewpoint.Memo);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.TeammenberId, 8, conzx_Viewpoint.TeammenberId);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.PdfDivLet, 50, conzx_Viewpoint.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.PdfDivTop, 50, conzx_Viewpoint.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.PdfPageNumIn, 50, conzx_Viewpoint.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.PdfZoom, 50, conzx_Viewpoint.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_ViewpointEN.GroupTextId, 8, conzx_Viewpoint.GroupTextId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointEN.zxViewpointId, conzx_Viewpoint.zxViewpointId);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointEN.ViewpointName, conzx_Viewpoint.ViewpointName);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointEN.zxViewpointTypeId, conzx_Viewpoint.zxViewpointTypeId);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointEN.Source, conzx_Viewpoint.Source);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointEN.VPProposePeople, conzx_Viewpoint.VPProposePeople);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointEN.UserTypeId, conzx_Viewpoint.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointEN.TextId, conzx_Viewpoint.TextId);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointEN.IdCurrEduCls, conzx_Viewpoint.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointEN.PdfContent, conzx_Viewpoint.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointEN.zxShareId, conzx_Viewpoint.zxShareId);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointEN.CreateDate, conzx_Viewpoint.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointEN.UpdDate, conzx_Viewpoint.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointEN.UpdUser, conzx_Viewpoint.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointEN.Memo, conzx_Viewpoint.Memo);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointEN.TeammenberId, conzx_Viewpoint.TeammenberId);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointEN.PdfDivLet, conzx_Viewpoint.PdfDivLet);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointEN.PdfDivTop, conzx_Viewpoint.PdfDivTop);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointEN.PdfPageNumIn, conzx_Viewpoint.PdfPageNumIn);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointEN.PdfZoom, conzx_Viewpoint.PdfZoom);
clsCheckSql.CheckSqlInjection4Field(objzx_ViewpointEN.GroupTextId, conzx_Viewpoint.GroupTextId);
//检查外键字段长度
 objzx_ViewpointEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--zx_Viewpoint(中学观点表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_ViewpointEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clszx_ViewpointEN objzx_ViewpointEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxViewpointId = '{0}'", objzx_ViewpointEN.zxViewpointId);
 if (objzx_ViewpointEN.TextId == null)
{
 sbCondition.AppendFormat(" and TextId is null");
}
else
{
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_ViewpointEN.TextId);
}
return sbCondition.ToString();
}

 #endregion 检查唯一性

 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数, 该表与当前类不相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strCondition">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strCondition)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(strTabName, strCondition);
return intRecCount;
}



 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
 public static int GetRecCount()
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_ViewpointEN._CurrTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCountByCond)
 /// </summary>
 /// <param name = "strCondition">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
 public static int GetRecCountByCond(string strCondition)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_ViewpointEN._CurrTabName, strCondition);
return intRecCount;
}

 /// <summary>
 /// 功能:获取给定表中的符合条件的某字段的值,以列表返回
 /// (AutoGCLib.DALCode4CSharp:GenGetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>获取的字段值列表</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strCondition) 
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.DALCode4CSharp:GenfunSetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "varValue">值</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue<T>(string strTabName, string strFldName, T varValue, string strCondition) 
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ViewpointDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}