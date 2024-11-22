
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzAdminClsDA
 表名:vXzAdminCls(01120163)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:23:04
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:人员管理(PeopleManage)
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
 /// v行政班(vXzAdminCls)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvXzAdminClsDA : clsCommBase4DA
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
 return clsvXzAdminClsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvXzAdminClsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvXzAdminClsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvXzAdminClsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvXzAdminClsEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdAdminCls">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdAdminCls)
{
strIdAdminCls = strIdAdminCls.Replace("'", "''");
if (strIdAdminCls.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vXzAdminCls中,检查关键字,长度不正确!(clsvXzAdminClsDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdAdminCls)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vXzAdminCls中,关键字不能为空 或 null!(clsvXzAdminClsDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdAdminCls);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvXzAdminClsDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvXzAdminClsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzAdminClsDA.GetSpecSQLObj();
strSQL = "Select * from vXzAdminCls where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vXzAdminCls(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvXzAdminClsDA: GetDataTable_vXzAdminCls)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzAdminClsDA.GetSpecSQLObj();
strSQL = "Select * from vXzAdminCls where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvXzAdminClsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzAdminClsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvXzAdminClsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzAdminClsDA.GetSpecSQLObj();
strSQL = "Select * from vXzAdminCls where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvXzAdminClsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzAdminClsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvXzAdminClsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzAdminClsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vXzAdminCls where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vXzAdminCls where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvXzAdminClsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzAdminClsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vXzAdminCls where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvXzAdminClsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzAdminClsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vXzAdminCls.* from vXzAdminCls Left Join {1} on {2} where {3} and vXzAdminCls.IdAdminCls not in (Select top {5} vXzAdminCls.IdAdminCls from vXzAdminCls Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vXzAdminCls where {1} and IdAdminCls not in (Select top {2} IdAdminCls from vXzAdminCls where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vXzAdminCls where {1} and IdAdminCls not in (Select top {3} IdAdminCls from vXzAdminCls where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvXzAdminClsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzAdminClsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vXzAdminCls.* from vXzAdminCls Left Join {1} on {2} where {3} and vXzAdminCls.IdAdminCls not in (Select top {5} vXzAdminCls.IdAdminCls from vXzAdminCls Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vXzAdminCls where {1} and IdAdminCls not in (Select top {2} IdAdminCls from vXzAdminCls where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vXzAdminCls where {1} and IdAdminCls not in (Select top {3} IdAdminCls from vXzAdminCls where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvXzAdminClsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvXzAdminClsDA:GetObjLst)", objException.Message));
}
List<clsvXzAdminClsEN> arrObjLst = new List<clsvXzAdminClsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzAdminClsDA.GetSpecSQLObj();
strSQL = "Select * from vXzAdminCls where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzAdminClsEN objvXzAdminClsEN = new clsvXzAdminClsEN();
try
{
objvXzAdminClsEN.IdAdminCls = objRow[convXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号
objvXzAdminClsEN.IdXzMajor = objRow[convXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号
objvXzAdminClsEN.MajorID = objRow[convXzAdminCls.MajorID] == DBNull.Value ? null : objRow[convXzAdminCls.MajorID].ToString().Trim(); //专业ID
objvXzAdminClsEN.MajorName = objRow[convXzAdminCls.MajorName] == DBNull.Value ? null : objRow[convXzAdminCls.MajorName].ToString().Trim(); //专业名称
objvXzAdminClsEN.IdXzCollege = objRow[convXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号
objvXzAdminClsEN.CollegeId = objRow[convXzAdminCls.CollegeId] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeId].ToString().Trim(); //学院ID
objvXzAdminClsEN.CollegeName = objRow[convXzAdminCls.CollegeName] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeName].ToString().Trim(); //学院名称
objvXzAdminClsEN.CollegeNameA = objRow[convXzAdminCls.CollegeNameA] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzAdminClsEN.ModifyUserId = objRow[convXzAdminCls.ModifyUserId] == DBNull.Value ? null : objRow[convXzAdminCls.ModifyUserId].ToString().Trim(); //修改人
objvXzAdminClsEN.ModifyDate = objRow[convXzAdminCls.ModifyDate] == DBNull.Value ? null : objRow[convXzAdminCls.ModifyDate].ToString().Trim(); //修改日期
objvXzAdminClsEN.IdUniZone = objRow[convXzAdminCls.IdUniZone] == DBNull.Value ? null : objRow[convXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号
objvXzAdminClsEN.UniZoneDesc = objRow[convXzAdminCls.UniZoneDesc] == DBNull.Value ? null : objRow[convXzAdminCls.UniZoneDesc].ToString().Trim(); //校区名称
objvXzAdminClsEN.CurrentStuQty = objRow[convXzAdminCls.CurrentStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convXzAdminCls.CurrentStuQty].ToString().Trim()); //当前学生数
objvXzAdminClsEN.IdGradeBase = objRow[convXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号
objvXzAdminClsEN.GradeBaseId = objRow[convXzAdminCls.GradeBaseId] == DBNull.Value ? null : objRow[convXzAdminCls.GradeBaseId].ToString().Trim(); //年级代号
objvXzAdminClsEN.GradeBaseName = objRow[convXzAdminCls.GradeBaseName] == DBNull.Value ? null : objRow[convXzAdminCls.GradeBaseName].ToString().Trim(); //年级名称
objvXzAdminClsEN.StudyLevelName = objRow[convXzAdminCls.StudyLevelName] == DBNull.Value ? null : objRow[convXzAdminCls.StudyLevelName].ToString().Trim(); //学段名称
objvXzAdminClsEN.AdminClsName = objRow[convXzAdminCls.AdminClsName] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称
objvXzAdminClsEN.AdminClsId = objRow[convXzAdminCls.AdminClsId] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号
objvXzAdminClsEN.IdAdminClsType = objRow[convXzAdminCls.IdAdminClsType] == DBNull.Value ? null : objRow[convXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objvXzAdminClsEN.AdminClsTypeName = objRow[convXzAdminCls.AdminClsTypeName] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsTypeName].ToString().Trim(); //行政班级类型名称
objvXzAdminClsEN.AdminClsTypeId = objRow[convXzAdminCls.AdminClsTypeId] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsTypeId].ToString().Trim(); //行政班级类型ID
objvXzAdminClsEN.AdminClsIndex = objRow[convXzAdminCls.AdminClsIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convXzAdminCls.AdminClsIndex].ToString().Trim()); //AdminClsIndex
objvXzAdminClsEN.Memo = objRow[convXzAdminCls.Memo] == DBNull.Value ? null : objRow[convXzAdminCls.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvXzAdminClsDA: GetObjLst)", objException.Message));
}
objvXzAdminClsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvXzAdminClsEN);
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
public List<clsvXzAdminClsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvXzAdminClsDA:GetObjLstByTabName)", objException.Message));
}
List<clsvXzAdminClsEN> arrObjLst = new List<clsvXzAdminClsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzAdminClsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzAdminClsEN objvXzAdminClsEN = new clsvXzAdminClsEN();
try
{
objvXzAdminClsEN.IdAdminCls = objRow[convXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号
objvXzAdminClsEN.IdXzMajor = objRow[convXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号
objvXzAdminClsEN.MajorID = objRow[convXzAdminCls.MajorID] == DBNull.Value ? null : objRow[convXzAdminCls.MajorID].ToString().Trim(); //专业ID
objvXzAdminClsEN.MajorName = objRow[convXzAdminCls.MajorName] == DBNull.Value ? null : objRow[convXzAdminCls.MajorName].ToString().Trim(); //专业名称
objvXzAdminClsEN.IdXzCollege = objRow[convXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号
objvXzAdminClsEN.CollegeId = objRow[convXzAdminCls.CollegeId] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeId].ToString().Trim(); //学院ID
objvXzAdminClsEN.CollegeName = objRow[convXzAdminCls.CollegeName] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeName].ToString().Trim(); //学院名称
objvXzAdminClsEN.CollegeNameA = objRow[convXzAdminCls.CollegeNameA] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzAdminClsEN.ModifyUserId = objRow[convXzAdminCls.ModifyUserId] == DBNull.Value ? null : objRow[convXzAdminCls.ModifyUserId].ToString().Trim(); //修改人
objvXzAdminClsEN.ModifyDate = objRow[convXzAdminCls.ModifyDate] == DBNull.Value ? null : objRow[convXzAdminCls.ModifyDate].ToString().Trim(); //修改日期
objvXzAdminClsEN.IdUniZone = objRow[convXzAdminCls.IdUniZone] == DBNull.Value ? null : objRow[convXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号
objvXzAdminClsEN.UniZoneDesc = objRow[convXzAdminCls.UniZoneDesc] == DBNull.Value ? null : objRow[convXzAdminCls.UniZoneDesc].ToString().Trim(); //校区名称
objvXzAdminClsEN.CurrentStuQty = objRow[convXzAdminCls.CurrentStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convXzAdminCls.CurrentStuQty].ToString().Trim()); //当前学生数
objvXzAdminClsEN.IdGradeBase = objRow[convXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号
objvXzAdminClsEN.GradeBaseId = objRow[convXzAdminCls.GradeBaseId] == DBNull.Value ? null : objRow[convXzAdminCls.GradeBaseId].ToString().Trim(); //年级代号
objvXzAdminClsEN.GradeBaseName = objRow[convXzAdminCls.GradeBaseName] == DBNull.Value ? null : objRow[convXzAdminCls.GradeBaseName].ToString().Trim(); //年级名称
objvXzAdminClsEN.StudyLevelName = objRow[convXzAdminCls.StudyLevelName] == DBNull.Value ? null : objRow[convXzAdminCls.StudyLevelName].ToString().Trim(); //学段名称
objvXzAdminClsEN.AdminClsName = objRow[convXzAdminCls.AdminClsName] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称
objvXzAdminClsEN.AdminClsId = objRow[convXzAdminCls.AdminClsId] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号
objvXzAdminClsEN.IdAdminClsType = objRow[convXzAdminCls.IdAdminClsType] == DBNull.Value ? null : objRow[convXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objvXzAdminClsEN.AdminClsTypeName = objRow[convXzAdminCls.AdminClsTypeName] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsTypeName].ToString().Trim(); //行政班级类型名称
objvXzAdminClsEN.AdminClsTypeId = objRow[convXzAdminCls.AdminClsTypeId] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsTypeId].ToString().Trim(); //行政班级类型ID
objvXzAdminClsEN.AdminClsIndex = objRow[convXzAdminCls.AdminClsIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convXzAdminCls.AdminClsIndex].ToString().Trim()); //AdminClsIndex
objvXzAdminClsEN.Memo = objRow[convXzAdminCls.Memo] == DBNull.Value ? null : objRow[convXzAdminCls.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvXzAdminClsDA: GetObjLst)", objException.Message));
}
objvXzAdminClsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvXzAdminClsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvXzAdminClsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvXzAdminCls(ref clsvXzAdminClsEN objvXzAdminClsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzAdminClsDA.GetSpecSQLObj();
strSQL = "Select * from vXzAdminCls where IdAdminCls = " + "'"+ objvXzAdminClsEN.IdAdminCls+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvXzAdminClsEN.IdAdminCls = objDT.Rows[0][convXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objvXzAdminClsEN.IdXzMajor = objDT.Rows[0][convXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvXzAdminClsEN.MajorID = objDT.Rows[0][convXzAdminCls.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvXzAdminClsEN.MajorName = objDT.Rows[0][convXzAdminCls.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvXzAdminClsEN.IdXzCollege = objDT.Rows[0][convXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvXzAdminClsEN.CollegeId = objDT.Rows[0][convXzAdminCls.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvXzAdminClsEN.CollegeName = objDT.Rows[0][convXzAdminCls.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvXzAdminClsEN.CollegeNameA = objDT.Rows[0][convXzAdminCls.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvXzAdminClsEN.ModifyUserId = objDT.Rows[0][convXzAdminCls.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objvXzAdminClsEN.ModifyDate = objDT.Rows[0][convXzAdminCls.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvXzAdminClsEN.IdUniZone = objDT.Rows[0][convXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号(字段类型:char,字段长度:4,是否可空:False)
 objvXzAdminClsEN.UniZoneDesc = objDT.Rows[0][convXzAdminCls.UniZoneDesc].ToString().Trim(); //校区名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvXzAdminClsEN.CurrentStuQty = TransNullToInt(objDT.Rows[0][convXzAdminCls.CurrentStuQty].ToString().Trim()); //当前学生数(字段类型:int,字段长度:4,是否可空:False)
 objvXzAdminClsEN.IdGradeBase = objDT.Rows[0][convXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvXzAdminClsEN.GradeBaseId = objDT.Rows[0][convXzAdminCls.GradeBaseId].ToString().Trim(); //年级代号(字段类型:char,字段长度:4,是否可空:True)
 objvXzAdminClsEN.GradeBaseName = objDT.Rows[0][convXzAdminCls.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvXzAdminClsEN.StudyLevelName = objDT.Rows[0][convXzAdminCls.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvXzAdminClsEN.AdminClsName = objDT.Rows[0][convXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvXzAdminClsEN.AdminClsId = objDT.Rows[0][convXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号(字段类型:varchar,字段长度:8,是否可空:True)
 objvXzAdminClsEN.IdAdminClsType = objDT.Rows[0][convXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvXzAdminClsEN.AdminClsTypeName = objDT.Rows[0][convXzAdminCls.AdminClsTypeName].ToString().Trim(); //行政班级类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvXzAdminClsEN.AdminClsTypeId = objDT.Rows[0][convXzAdminCls.AdminClsTypeId].ToString().Trim(); //行政班级类型ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvXzAdminClsEN.AdminClsIndex = TransNullToInt(objDT.Rows[0][convXzAdminCls.AdminClsIndex].ToString().Trim()); //AdminClsIndex(字段类型:int,字段长度:4,是否可空:True)
 objvXzAdminClsEN.Memo = objDT.Rows[0][convXzAdminCls.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvXzAdminClsDA: GetvXzAdminCls)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdAdminCls">表关键字</param>
 /// <returns>表对象</returns>
public clsvXzAdminClsEN GetObjByIdAdminCls(string strIdAdminCls)
{
CheckPrimaryKey(strIdAdminCls);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzAdminClsDA.GetSpecSQLObj();
strSQL = "Select * from vXzAdminCls where IdAdminCls = " + "'"+ strIdAdminCls+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvXzAdminClsEN objvXzAdminClsEN = new clsvXzAdminClsEN();
try
{
 objvXzAdminClsEN.IdAdminCls = objRow[convXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objvXzAdminClsEN.IdXzMajor = objRow[convXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvXzAdminClsEN.MajorID = objRow[convXzAdminCls.MajorID] == DBNull.Value ? null : objRow[convXzAdminCls.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvXzAdminClsEN.MajorName = objRow[convXzAdminCls.MajorName] == DBNull.Value ? null : objRow[convXzAdminCls.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvXzAdminClsEN.IdXzCollege = objRow[convXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvXzAdminClsEN.CollegeId = objRow[convXzAdminCls.CollegeId] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvXzAdminClsEN.CollegeName = objRow[convXzAdminCls.CollegeName] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvXzAdminClsEN.CollegeNameA = objRow[convXzAdminCls.CollegeNameA] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvXzAdminClsEN.ModifyUserId = objRow[convXzAdminCls.ModifyUserId] == DBNull.Value ? null : objRow[convXzAdminCls.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objvXzAdminClsEN.ModifyDate = objRow[convXzAdminCls.ModifyDate] == DBNull.Value ? null : objRow[convXzAdminCls.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvXzAdminClsEN.IdUniZone = objRow[convXzAdminCls.IdUniZone] == DBNull.Value ? null : objRow[convXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号(字段类型:char,字段长度:4,是否可空:False)
 objvXzAdminClsEN.UniZoneDesc = objRow[convXzAdminCls.UniZoneDesc] == DBNull.Value ? null : objRow[convXzAdminCls.UniZoneDesc].ToString().Trim(); //校区名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvXzAdminClsEN.CurrentStuQty = objRow[convXzAdminCls.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzAdminCls.CurrentStuQty].ToString().Trim()); //当前学生数(字段类型:int,字段长度:4,是否可空:False)
 objvXzAdminClsEN.IdGradeBase = objRow[convXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvXzAdminClsEN.GradeBaseId = objRow[convXzAdminCls.GradeBaseId] == DBNull.Value ? null : objRow[convXzAdminCls.GradeBaseId].ToString().Trim(); //年级代号(字段类型:char,字段长度:4,是否可空:True)
 objvXzAdminClsEN.GradeBaseName = objRow[convXzAdminCls.GradeBaseName] == DBNull.Value ? null : objRow[convXzAdminCls.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvXzAdminClsEN.StudyLevelName = objRow[convXzAdminCls.StudyLevelName] == DBNull.Value ? null : objRow[convXzAdminCls.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvXzAdminClsEN.AdminClsName = objRow[convXzAdminCls.AdminClsName] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvXzAdminClsEN.AdminClsId = objRow[convXzAdminCls.AdminClsId] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号(字段类型:varchar,字段长度:8,是否可空:True)
 objvXzAdminClsEN.IdAdminClsType = objRow[convXzAdminCls.IdAdminClsType] == DBNull.Value ? null : objRow[convXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvXzAdminClsEN.AdminClsTypeName = objRow[convXzAdminCls.AdminClsTypeName] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsTypeName].ToString().Trim(); //行政班级类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvXzAdminClsEN.AdminClsTypeId = objRow[convXzAdminCls.AdminClsTypeId] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsTypeId].ToString().Trim(); //行政班级类型ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvXzAdminClsEN.AdminClsIndex = objRow[convXzAdminCls.AdminClsIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzAdminCls.AdminClsIndex].ToString().Trim()); //AdminClsIndex(字段类型:int,字段长度:4,是否可空:True)
 objvXzAdminClsEN.Memo = objRow[convXzAdminCls.Memo] == DBNull.Value ? null : objRow[convXzAdminCls.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvXzAdminClsDA: GetObjByIdAdminCls)", objException.Message));
}
return objvXzAdminClsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvXzAdminClsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvXzAdminClsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzAdminClsDA.GetSpecSQLObj();
strSQL = "Select * from vXzAdminCls where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvXzAdminClsEN objvXzAdminClsEN = new clsvXzAdminClsEN()
{
IdAdminCls = objRow[convXzAdminCls.IdAdminCls].ToString().Trim(), //行政班流水号
IdXzMajor = objRow[convXzAdminCls.IdXzMajor].ToString().Trim(), //专业流水号
MajorID = objRow[convXzAdminCls.MajorID] == DBNull.Value ? null : objRow[convXzAdminCls.MajorID].ToString().Trim(), //专业ID
MajorName = objRow[convXzAdminCls.MajorName] == DBNull.Value ? null : objRow[convXzAdminCls.MajorName].ToString().Trim(), //专业名称
IdXzCollege = objRow[convXzAdminCls.IdXzCollege].ToString().Trim(), //学院流水号
CollegeId = objRow[convXzAdminCls.CollegeId] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeId].ToString().Trim(), //学院ID
CollegeName = objRow[convXzAdminCls.CollegeName] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convXzAdminCls.CollegeNameA] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeNameA].ToString().Trim(), //学院名称简写
ModifyUserId = objRow[convXzAdminCls.ModifyUserId] == DBNull.Value ? null : objRow[convXzAdminCls.ModifyUserId].ToString().Trim(), //修改人
ModifyDate = objRow[convXzAdminCls.ModifyDate] == DBNull.Value ? null : objRow[convXzAdminCls.ModifyDate].ToString().Trim(), //修改日期
IdUniZone = objRow[convXzAdminCls.IdUniZone] == DBNull.Value ? null : objRow[convXzAdminCls.IdUniZone].ToString().Trim(), //校区流水号
UniZoneDesc = objRow[convXzAdminCls.UniZoneDesc] == DBNull.Value ? null : objRow[convXzAdminCls.UniZoneDesc].ToString().Trim(), //校区名称
CurrentStuQty = objRow[convXzAdminCls.CurrentStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convXzAdminCls.CurrentStuQty].ToString().Trim()), //当前学生数
IdGradeBase = objRow[convXzAdminCls.IdGradeBase].ToString().Trim(), //年级流水号
GradeBaseId = objRow[convXzAdminCls.GradeBaseId] == DBNull.Value ? null : objRow[convXzAdminCls.GradeBaseId].ToString().Trim(), //年级代号
GradeBaseName = objRow[convXzAdminCls.GradeBaseName] == DBNull.Value ? null : objRow[convXzAdminCls.GradeBaseName].ToString().Trim(), //年级名称
StudyLevelName = objRow[convXzAdminCls.StudyLevelName] == DBNull.Value ? null : objRow[convXzAdminCls.StudyLevelName].ToString().Trim(), //学段名称
AdminClsName = objRow[convXzAdminCls.AdminClsName] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsName].ToString().Trim(), //行政班名称
AdminClsId = objRow[convXzAdminCls.AdminClsId] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsId].ToString().Trim(), //行政班代号
IdAdminClsType = objRow[convXzAdminCls.IdAdminClsType] == DBNull.Value ? null : objRow[convXzAdminCls.IdAdminClsType].ToString().Trim(), //行政班级类型流水号
AdminClsTypeName = objRow[convXzAdminCls.AdminClsTypeName] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsTypeName].ToString().Trim(), //行政班级类型名称
AdminClsTypeId = objRow[convXzAdminCls.AdminClsTypeId] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsTypeId].ToString().Trim(), //行政班级类型ID
AdminClsIndex = objRow[convXzAdminCls.AdminClsIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convXzAdminCls.AdminClsIndex].ToString().Trim()), //AdminClsIndex
Memo = objRow[convXzAdminCls.Memo] == DBNull.Value ? null : objRow[convXzAdminCls.Memo].ToString().Trim() //备注
};
objvXzAdminClsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvXzAdminClsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvXzAdminClsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvXzAdminClsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvXzAdminClsEN objvXzAdminClsEN = new clsvXzAdminClsEN();
try
{
objvXzAdminClsEN.IdAdminCls = objRow[convXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号
objvXzAdminClsEN.IdXzMajor = objRow[convXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号
objvXzAdminClsEN.MajorID = objRow[convXzAdminCls.MajorID] == DBNull.Value ? null : objRow[convXzAdminCls.MajorID].ToString().Trim(); //专业ID
objvXzAdminClsEN.MajorName = objRow[convXzAdminCls.MajorName] == DBNull.Value ? null : objRow[convXzAdminCls.MajorName].ToString().Trim(); //专业名称
objvXzAdminClsEN.IdXzCollege = objRow[convXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号
objvXzAdminClsEN.CollegeId = objRow[convXzAdminCls.CollegeId] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeId].ToString().Trim(); //学院ID
objvXzAdminClsEN.CollegeName = objRow[convXzAdminCls.CollegeName] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeName].ToString().Trim(); //学院名称
objvXzAdminClsEN.CollegeNameA = objRow[convXzAdminCls.CollegeNameA] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzAdminClsEN.ModifyUserId = objRow[convXzAdminCls.ModifyUserId] == DBNull.Value ? null : objRow[convXzAdminCls.ModifyUserId].ToString().Trim(); //修改人
objvXzAdminClsEN.ModifyDate = objRow[convXzAdminCls.ModifyDate] == DBNull.Value ? null : objRow[convXzAdminCls.ModifyDate].ToString().Trim(); //修改日期
objvXzAdminClsEN.IdUniZone = objRow[convXzAdminCls.IdUniZone] == DBNull.Value ? null : objRow[convXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号
objvXzAdminClsEN.UniZoneDesc = objRow[convXzAdminCls.UniZoneDesc] == DBNull.Value ? null : objRow[convXzAdminCls.UniZoneDesc].ToString().Trim(); //校区名称
objvXzAdminClsEN.CurrentStuQty = objRow[convXzAdminCls.CurrentStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convXzAdminCls.CurrentStuQty].ToString().Trim()); //当前学生数
objvXzAdminClsEN.IdGradeBase = objRow[convXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号
objvXzAdminClsEN.GradeBaseId = objRow[convXzAdminCls.GradeBaseId] == DBNull.Value ? null : objRow[convXzAdminCls.GradeBaseId].ToString().Trim(); //年级代号
objvXzAdminClsEN.GradeBaseName = objRow[convXzAdminCls.GradeBaseName] == DBNull.Value ? null : objRow[convXzAdminCls.GradeBaseName].ToString().Trim(); //年级名称
objvXzAdminClsEN.StudyLevelName = objRow[convXzAdminCls.StudyLevelName] == DBNull.Value ? null : objRow[convXzAdminCls.StudyLevelName].ToString().Trim(); //学段名称
objvXzAdminClsEN.AdminClsName = objRow[convXzAdminCls.AdminClsName] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称
objvXzAdminClsEN.AdminClsId = objRow[convXzAdminCls.AdminClsId] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号
objvXzAdminClsEN.IdAdminClsType = objRow[convXzAdminCls.IdAdminClsType] == DBNull.Value ? null : objRow[convXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objvXzAdminClsEN.AdminClsTypeName = objRow[convXzAdminCls.AdminClsTypeName] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsTypeName].ToString().Trim(); //行政班级类型名称
objvXzAdminClsEN.AdminClsTypeId = objRow[convXzAdminCls.AdminClsTypeId] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsTypeId].ToString().Trim(); //行政班级类型ID
objvXzAdminClsEN.AdminClsIndex = objRow[convXzAdminCls.AdminClsIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convXzAdminCls.AdminClsIndex].ToString().Trim()); //AdminClsIndex
objvXzAdminClsEN.Memo = objRow[convXzAdminCls.Memo] == DBNull.Value ? null : objRow[convXzAdminCls.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvXzAdminClsDA: GetObjByDataRowvXzAdminCls)", objException.Message));
}
objvXzAdminClsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvXzAdminClsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvXzAdminClsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvXzAdminClsEN objvXzAdminClsEN = new clsvXzAdminClsEN();
try
{
objvXzAdminClsEN.IdAdminCls = objRow[convXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号
objvXzAdminClsEN.IdXzMajor = objRow[convXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号
objvXzAdminClsEN.MajorID = objRow[convXzAdminCls.MajorID] == DBNull.Value ? null : objRow[convXzAdminCls.MajorID].ToString().Trim(); //专业ID
objvXzAdminClsEN.MajorName = objRow[convXzAdminCls.MajorName] == DBNull.Value ? null : objRow[convXzAdminCls.MajorName].ToString().Trim(); //专业名称
objvXzAdminClsEN.IdXzCollege = objRow[convXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号
objvXzAdminClsEN.CollegeId = objRow[convXzAdminCls.CollegeId] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeId].ToString().Trim(); //学院ID
objvXzAdminClsEN.CollegeName = objRow[convXzAdminCls.CollegeName] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeName].ToString().Trim(); //学院名称
objvXzAdminClsEN.CollegeNameA = objRow[convXzAdminCls.CollegeNameA] == DBNull.Value ? null : objRow[convXzAdminCls.CollegeNameA].ToString().Trim(); //学院名称简写
objvXzAdminClsEN.ModifyUserId = objRow[convXzAdminCls.ModifyUserId] == DBNull.Value ? null : objRow[convXzAdminCls.ModifyUserId].ToString().Trim(); //修改人
objvXzAdminClsEN.ModifyDate = objRow[convXzAdminCls.ModifyDate] == DBNull.Value ? null : objRow[convXzAdminCls.ModifyDate].ToString().Trim(); //修改日期
objvXzAdminClsEN.IdUniZone = objRow[convXzAdminCls.IdUniZone] == DBNull.Value ? null : objRow[convXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号
objvXzAdminClsEN.UniZoneDesc = objRow[convXzAdminCls.UniZoneDesc] == DBNull.Value ? null : objRow[convXzAdminCls.UniZoneDesc].ToString().Trim(); //校区名称
objvXzAdminClsEN.CurrentStuQty = objRow[convXzAdminCls.CurrentStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convXzAdminCls.CurrentStuQty].ToString().Trim()); //当前学生数
objvXzAdminClsEN.IdGradeBase = objRow[convXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号
objvXzAdminClsEN.GradeBaseId = objRow[convXzAdminCls.GradeBaseId] == DBNull.Value ? null : objRow[convXzAdminCls.GradeBaseId].ToString().Trim(); //年级代号
objvXzAdminClsEN.GradeBaseName = objRow[convXzAdminCls.GradeBaseName] == DBNull.Value ? null : objRow[convXzAdminCls.GradeBaseName].ToString().Trim(); //年级名称
objvXzAdminClsEN.StudyLevelName = objRow[convXzAdminCls.StudyLevelName] == DBNull.Value ? null : objRow[convXzAdminCls.StudyLevelName].ToString().Trim(); //学段名称
objvXzAdminClsEN.AdminClsName = objRow[convXzAdminCls.AdminClsName] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称
objvXzAdminClsEN.AdminClsId = objRow[convXzAdminCls.AdminClsId] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号
objvXzAdminClsEN.IdAdminClsType = objRow[convXzAdminCls.IdAdminClsType] == DBNull.Value ? null : objRow[convXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objvXzAdminClsEN.AdminClsTypeName = objRow[convXzAdminCls.AdminClsTypeName] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsTypeName].ToString().Trim(); //行政班级类型名称
objvXzAdminClsEN.AdminClsTypeId = objRow[convXzAdminCls.AdminClsTypeId] == DBNull.Value ? null : objRow[convXzAdminCls.AdminClsTypeId].ToString().Trim(); //行政班级类型ID
objvXzAdminClsEN.AdminClsIndex = objRow[convXzAdminCls.AdminClsIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convXzAdminCls.AdminClsIndex].ToString().Trim()); //AdminClsIndex
objvXzAdminClsEN.Memo = objRow[convXzAdminCls.Memo] == DBNull.Value ? null : objRow[convXzAdminCls.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvXzAdminClsDA: GetObjByDataRow)", objException.Message));
}
objvXzAdminClsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvXzAdminClsEN;
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
objSQL = clsvXzAdminClsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvXzAdminClsEN._CurrTabName, convXzAdminCls.IdAdminCls, 8, "");
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
objSQL = clsvXzAdminClsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvXzAdminClsEN._CurrTabName, convXzAdminCls.IdAdminCls, 8, strPrefix);
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
 objSQL = clsvXzAdminClsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdAdminCls from vXzAdminCls where " + strCondition;
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
 objSQL = clsvXzAdminClsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdAdminCls from vXzAdminCls where " + strCondition;
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
 /// <param name = "strIdAdminCls">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdAdminCls)
{
CheckPrimaryKey(strIdAdminCls);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzAdminClsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vXzAdminCls", "IdAdminCls = " + "'"+ strIdAdminCls+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvXzAdminClsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzAdminClsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vXzAdminCls", strCondition))
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
objSQL = clsvXzAdminClsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vXzAdminCls");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvXzAdminClsENS">源对象</param>
 /// <param name = "objvXzAdminClsENT">目标对象</param>
public void CopyTo(clsvXzAdminClsEN objvXzAdminClsENS, clsvXzAdminClsEN objvXzAdminClsENT)
{
objvXzAdminClsENT.IdAdminCls = objvXzAdminClsENS.IdAdminCls; //行政班流水号
objvXzAdminClsENT.IdXzMajor = objvXzAdminClsENS.IdXzMajor; //专业流水号
objvXzAdminClsENT.MajorID = objvXzAdminClsENS.MajorID; //专业ID
objvXzAdminClsENT.MajorName = objvXzAdminClsENS.MajorName; //专业名称
objvXzAdminClsENT.IdXzCollege = objvXzAdminClsENS.IdXzCollege; //学院流水号
objvXzAdminClsENT.CollegeId = objvXzAdminClsENS.CollegeId; //学院ID
objvXzAdminClsENT.CollegeName = objvXzAdminClsENS.CollegeName; //学院名称
objvXzAdminClsENT.CollegeNameA = objvXzAdminClsENS.CollegeNameA; //学院名称简写
objvXzAdminClsENT.ModifyUserId = objvXzAdminClsENS.ModifyUserId; //修改人
objvXzAdminClsENT.ModifyDate = objvXzAdminClsENS.ModifyDate; //修改日期
objvXzAdminClsENT.IdUniZone = objvXzAdminClsENS.IdUniZone; //校区流水号
objvXzAdminClsENT.UniZoneDesc = objvXzAdminClsENS.UniZoneDesc; //校区名称
objvXzAdminClsENT.CurrentStuQty = objvXzAdminClsENS.CurrentStuQty; //当前学生数
objvXzAdminClsENT.IdGradeBase = objvXzAdminClsENS.IdGradeBase; //年级流水号
objvXzAdminClsENT.GradeBaseId = objvXzAdminClsENS.GradeBaseId; //年级代号
objvXzAdminClsENT.GradeBaseName = objvXzAdminClsENS.GradeBaseName; //年级名称
objvXzAdminClsENT.StudyLevelName = objvXzAdminClsENS.StudyLevelName; //学段名称
objvXzAdminClsENT.AdminClsName = objvXzAdminClsENS.AdminClsName; //行政班名称
objvXzAdminClsENT.AdminClsId = objvXzAdminClsENS.AdminClsId; //行政班代号
objvXzAdminClsENT.IdAdminClsType = objvXzAdminClsENS.IdAdminClsType; //行政班级类型流水号
objvXzAdminClsENT.AdminClsTypeName = objvXzAdminClsENS.AdminClsTypeName; //行政班级类型名称
objvXzAdminClsENT.AdminClsTypeId = objvXzAdminClsENS.AdminClsTypeId; //行政班级类型ID
objvXzAdminClsENT.AdminClsIndex = objvXzAdminClsENS.AdminClsIndex; //AdminClsIndex
objvXzAdminClsENT.Memo = objvXzAdminClsENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvXzAdminClsEN objvXzAdminClsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvXzAdminClsEN.IdAdminCls, 8, convXzAdminCls.IdAdminCls);
clsCheckSql.CheckFieldLen(objvXzAdminClsEN.IdXzMajor, 8, convXzAdminCls.IdXzMajor);
clsCheckSql.CheckFieldLen(objvXzAdminClsEN.MajorID, 4, convXzAdminCls.MajorID);
clsCheckSql.CheckFieldLen(objvXzAdminClsEN.MajorName, 100, convXzAdminCls.MajorName);
clsCheckSql.CheckFieldLen(objvXzAdminClsEN.IdXzCollege, 4, convXzAdminCls.IdXzCollege);
clsCheckSql.CheckFieldLen(objvXzAdminClsEN.CollegeId, 4, convXzAdminCls.CollegeId);
clsCheckSql.CheckFieldLen(objvXzAdminClsEN.CollegeName, 100, convXzAdminCls.CollegeName);
clsCheckSql.CheckFieldLen(objvXzAdminClsEN.CollegeNameA, 12, convXzAdminCls.CollegeNameA);
clsCheckSql.CheckFieldLen(objvXzAdminClsEN.ModifyUserId, 18, convXzAdminCls.ModifyUserId);
clsCheckSql.CheckFieldLen(objvXzAdminClsEN.ModifyDate, 20, convXzAdminCls.ModifyDate);
clsCheckSql.CheckFieldLen(objvXzAdminClsEN.IdUniZone, 4, convXzAdminCls.IdUniZone);
clsCheckSql.CheckFieldLen(objvXzAdminClsEN.UniZoneDesc, 20, convXzAdminCls.UniZoneDesc);
clsCheckSql.CheckFieldLen(objvXzAdminClsEN.IdGradeBase, 4, convXzAdminCls.IdGradeBase);
clsCheckSql.CheckFieldLen(objvXzAdminClsEN.GradeBaseId, 4, convXzAdminCls.GradeBaseId);
clsCheckSql.CheckFieldLen(objvXzAdminClsEN.GradeBaseName, 50, convXzAdminCls.GradeBaseName);
clsCheckSql.CheckFieldLen(objvXzAdminClsEN.StudyLevelName, 50, convXzAdminCls.StudyLevelName);
clsCheckSql.CheckFieldLen(objvXzAdminClsEN.AdminClsName, 100, convXzAdminCls.AdminClsName);
clsCheckSql.CheckFieldLen(objvXzAdminClsEN.AdminClsId, 8, convXzAdminCls.AdminClsId);
clsCheckSql.CheckFieldLen(objvXzAdminClsEN.IdAdminClsType, 4, convXzAdminCls.IdAdminClsType);
clsCheckSql.CheckFieldLen(objvXzAdminClsEN.AdminClsTypeName, 30, convXzAdminCls.AdminClsTypeName);
clsCheckSql.CheckFieldLen(objvXzAdminClsEN.AdminClsTypeId, 4, convXzAdminCls.AdminClsTypeId);
clsCheckSql.CheckFieldLen(objvXzAdminClsEN.Memo, 1000, convXzAdminCls.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvXzAdminClsEN.IdAdminCls, convXzAdminCls.IdAdminCls);
clsCheckSql.CheckSqlInjection4Field(objvXzAdminClsEN.IdXzMajor, convXzAdminCls.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvXzAdminClsEN.MajorID, convXzAdminCls.MajorID);
clsCheckSql.CheckSqlInjection4Field(objvXzAdminClsEN.MajorName, convXzAdminCls.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvXzAdminClsEN.IdXzCollege, convXzAdminCls.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvXzAdminClsEN.CollegeId, convXzAdminCls.CollegeId);
clsCheckSql.CheckSqlInjection4Field(objvXzAdminClsEN.CollegeName, convXzAdminCls.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvXzAdminClsEN.CollegeNameA, convXzAdminCls.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvXzAdminClsEN.ModifyUserId, convXzAdminCls.ModifyUserId);
clsCheckSql.CheckSqlInjection4Field(objvXzAdminClsEN.ModifyDate, convXzAdminCls.ModifyDate);
clsCheckSql.CheckSqlInjection4Field(objvXzAdminClsEN.IdUniZone, convXzAdminCls.IdUniZone);
clsCheckSql.CheckSqlInjection4Field(objvXzAdminClsEN.UniZoneDesc, convXzAdminCls.UniZoneDesc);
clsCheckSql.CheckSqlInjection4Field(objvXzAdminClsEN.IdGradeBase, convXzAdminCls.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objvXzAdminClsEN.GradeBaseId, convXzAdminCls.GradeBaseId);
clsCheckSql.CheckSqlInjection4Field(objvXzAdminClsEN.GradeBaseName, convXzAdminCls.GradeBaseName);
clsCheckSql.CheckSqlInjection4Field(objvXzAdminClsEN.StudyLevelName, convXzAdminCls.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvXzAdminClsEN.AdminClsName, convXzAdminCls.AdminClsName);
clsCheckSql.CheckSqlInjection4Field(objvXzAdminClsEN.AdminClsId, convXzAdminCls.AdminClsId);
clsCheckSql.CheckSqlInjection4Field(objvXzAdminClsEN.IdAdminClsType, convXzAdminCls.IdAdminClsType);
clsCheckSql.CheckSqlInjection4Field(objvXzAdminClsEN.AdminClsTypeName, convXzAdminCls.AdminClsTypeName);
clsCheckSql.CheckSqlInjection4Field(objvXzAdminClsEN.AdminClsTypeId, convXzAdminCls.AdminClsTypeId);
clsCheckSql.CheckSqlInjection4Field(objvXzAdminClsEN.Memo, convXzAdminCls.Memo);
//检查外键字段长度
 objvXzAdminClsEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdAdminCls()
{
//获取某学院所有专业信息
string strSQL = "select IdAdminCls, AdminClsName from vXzAdminCls ";
 clsSpecSQLforSql mySql = clsvXzAdminClsDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

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
 objSQL = clsvXzAdminClsDA.GetSpecSQLObj();
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
 objSQL = clsvXzAdminClsDA.GetSpecSQLObj();
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
 objSQL = clsvXzAdminClsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvXzAdminClsEN._CurrTabName);
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
 objSQL = clsvXzAdminClsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvXzAdminClsEN._CurrTabName, strCondition);
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
 objSQL = clsvXzAdminClsDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}