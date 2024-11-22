
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMajorDirectionPaperRelaDA
 表名:vMajorDirectionPaperRela(01120555)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:06:27
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
 /// v专业方向论文关系(vMajorDirectionPaperRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvMajorDirectionPaperRelaDA : clsCommBase4DA
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
 return clsvMajorDirectionPaperRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvMajorDirectionPaperRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMajorDirectionPaperRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvMajorDirectionPaperRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvMajorDirectionPaperRelaEN._ConnectString);
 }
 return objSQL;
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvMajorDirectionPaperRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorDirectionPaperRelaDA.GetSpecSQLObj();
strSQL = "Select * from vMajorDirectionPaperRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vMajorDirectionPaperRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvMajorDirectionPaperRelaDA: GetDataTable_vMajorDirectionPaperRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorDirectionPaperRelaDA.GetSpecSQLObj();
strSQL = "Select * from vMajorDirectionPaperRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvMajorDirectionPaperRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorDirectionPaperRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvMajorDirectionPaperRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorDirectionPaperRelaDA.GetSpecSQLObj();
strSQL = "Select * from vMajorDirectionPaperRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvMajorDirectionPaperRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorDirectionPaperRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvMajorDirectionPaperRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorDirectionPaperRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMajorDirectionPaperRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMajorDirectionPaperRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvMajorDirectionPaperRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorDirectionPaperRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vMajorDirectionPaperRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvMajorDirectionPaperRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorDirectionPaperRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMajorDirectionPaperRela.* from vMajorDirectionPaperRela Left Join {1} on {2} where {3} and vMajorDirectionPaperRela.mId not in (Select top {5} vMajorDirectionPaperRela.mId from vMajorDirectionPaperRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMajorDirectionPaperRela where {1} and mId not in (Select top {2} mId from vMajorDirectionPaperRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMajorDirectionPaperRela where {1} and mId not in (Select top {3} mId from vMajorDirectionPaperRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvMajorDirectionPaperRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorDirectionPaperRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMajorDirectionPaperRela.* from vMajorDirectionPaperRela Left Join {1} on {2} where {3} and vMajorDirectionPaperRela.mId not in (Select top {5} vMajorDirectionPaperRela.mId from vMajorDirectionPaperRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMajorDirectionPaperRela where {1} and mId not in (Select top {2} mId from vMajorDirectionPaperRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMajorDirectionPaperRela where {1} and mId not in (Select top {3} mId from vMajorDirectionPaperRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvMajorDirectionPaperRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvMajorDirectionPaperRelaDA:GetObjLst)", objException.Message));
}
List<clsvMajorDirectionPaperRelaEN> arrObjLst = new List<clsvMajorDirectionPaperRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorDirectionPaperRelaDA.GetSpecSQLObj();
strSQL = "Select * from vMajorDirectionPaperRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN = new clsvMajorDirectionPaperRelaEN();
try
{
objvMajorDirectionPaperRelaEN.mId = TransNullToInt(objRow[convMajorDirectionPaperRela.mId].ToString().Trim()); //mId
objvMajorDirectionPaperRelaEN.MajorDirectionId = objRow[convMajorDirectionPaperRela.MajorDirectionId] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionId].ToString().Trim(); //研究方向Id
objvMajorDirectionPaperRelaEN.PaperId = objRow[convMajorDirectionPaperRela.PaperId] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperId].ToString().Trim(); //论文Id
objvMajorDirectionPaperRelaEN.UpdDate = objRow[convMajorDirectionPaperRela.UpdDate] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UpdDate].ToString().Trim(); //修改日期
objvMajorDirectionPaperRelaEN.UpdUser = objRow[convMajorDirectionPaperRela.UpdUser].ToString().Trim(); //修改人
objvMajorDirectionPaperRelaEN.Memo = objRow[convMajorDirectionPaperRela.Memo] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Memo].ToString().Trim(); //备注
objvMajorDirectionPaperRelaEN.IdXzMajor = objRow[convMajorDirectionPaperRela.IdXzMajor] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.IdXzMajor].ToString().Trim(); //专业流水号
objvMajorDirectionPaperRelaEN.MajorDirectionENName = objRow[convMajorDirectionPaperRela.MajorDirectionENName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objvMajorDirectionPaperRelaEN.MajorDirectionName = objRow[convMajorDirectionPaperRela.MajorDirectionName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionName].ToString().Trim(); //研究方向名
objvMajorDirectionPaperRelaEN.MajorDirectionExplain = objRow[convMajorDirectionPaperRela.MajorDirectionExplain] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objvMajorDirectionPaperRelaEN.IsVisible = TransNullToBool(objRow[convMajorDirectionPaperRela.IsVisible].ToString().Trim()); //是否显示
objvMajorDirectionPaperRelaEN.PaperTitle = objRow[convMajorDirectionPaperRela.PaperTitle] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperTitle].ToString().Trim(); //论文标题
objvMajorDirectionPaperRelaEN.PaperContent = objRow[convMajorDirectionPaperRela.PaperContent] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperContent].ToString().Trim(); //主题内容
objvMajorDirectionPaperRelaEN.Periodical = objRow[convMajorDirectionPaperRela.Periodical] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Periodical].ToString().Trim(); //期刊
objvMajorDirectionPaperRelaEN.Author = objRow[convMajorDirectionPaperRela.Author] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Author].ToString().Trim(); //作者
objvMajorDirectionPaperRelaEN.ResearchQuestion = objRow[convMajorDirectionPaperRela.ResearchQuestion] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.ResearchQuestion].ToString().Trim(); //研究问题
objvMajorDirectionPaperRelaEN.Keyword = objRow[convMajorDirectionPaperRela.Keyword] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Keyword].ToString().Trim(); //关键字
objvMajorDirectionPaperRelaEN.LiteratureSources = objRow[convMajorDirectionPaperRela.LiteratureSources] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.LiteratureSources].ToString().Trim(); //文献来源
objvMajorDirectionPaperRelaEN.LiteratureLink = objRow[convMajorDirectionPaperRela.LiteratureLink] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.LiteratureLink].ToString().Trim(); //文献链接
objvMajorDirectionPaperRelaEN.UploadfileUrl = objRow[convMajorDirectionPaperRela.UploadfileUrl] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UploadfileUrl].ToString().Trim(); //文件地址
objvMajorDirectionPaperRelaEN.IsQuotethesis = TransNullToBool(objRow[convMajorDirectionPaperRela.IsQuotethesis].ToString().Trim()); //是否引用论文
objvMajorDirectionPaperRelaEN.Checker = objRow[convMajorDirectionPaperRela.Checker] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Checker].ToString().Trim(); //审核人
objvMajorDirectionPaperRelaEN.IsChecked = TransNullToBool(objRow[convMajorDirectionPaperRela.IsChecked].ToString().Trim()); //是否检查
objvMajorDirectionPaperRelaEN.MajorID = objRow[convMajorDirectionPaperRela.MajorID] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorID].ToString().Trim(); //专业ID
objvMajorDirectionPaperRelaEN.MajorName = objRow[convMajorDirectionPaperRela.MajorName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorName].ToString().Trim(); //专业名称
objvMajorDirectionPaperRelaEN.UserName = objRow[convMajorDirectionPaperRela.UserName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UserName].ToString().Trim(); //用户名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMajorDirectionPaperRelaDA: GetObjLst)", objException.Message));
}
objvMajorDirectionPaperRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMajorDirectionPaperRelaEN);
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
public List<clsvMajorDirectionPaperRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvMajorDirectionPaperRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvMajorDirectionPaperRelaEN> arrObjLst = new List<clsvMajorDirectionPaperRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorDirectionPaperRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN = new clsvMajorDirectionPaperRelaEN();
try
{
objvMajorDirectionPaperRelaEN.mId = TransNullToInt(objRow[convMajorDirectionPaperRela.mId].ToString().Trim()); //mId
objvMajorDirectionPaperRelaEN.MajorDirectionId = objRow[convMajorDirectionPaperRela.MajorDirectionId] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionId].ToString().Trim(); //研究方向Id
objvMajorDirectionPaperRelaEN.PaperId = objRow[convMajorDirectionPaperRela.PaperId] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperId].ToString().Trim(); //论文Id
objvMajorDirectionPaperRelaEN.UpdDate = objRow[convMajorDirectionPaperRela.UpdDate] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UpdDate].ToString().Trim(); //修改日期
objvMajorDirectionPaperRelaEN.UpdUser = objRow[convMajorDirectionPaperRela.UpdUser].ToString().Trim(); //修改人
objvMajorDirectionPaperRelaEN.Memo = objRow[convMajorDirectionPaperRela.Memo] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Memo].ToString().Trim(); //备注
objvMajorDirectionPaperRelaEN.IdXzMajor = objRow[convMajorDirectionPaperRela.IdXzMajor] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.IdXzMajor].ToString().Trim(); //专业流水号
objvMajorDirectionPaperRelaEN.MajorDirectionENName = objRow[convMajorDirectionPaperRela.MajorDirectionENName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objvMajorDirectionPaperRelaEN.MajorDirectionName = objRow[convMajorDirectionPaperRela.MajorDirectionName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionName].ToString().Trim(); //研究方向名
objvMajorDirectionPaperRelaEN.MajorDirectionExplain = objRow[convMajorDirectionPaperRela.MajorDirectionExplain] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objvMajorDirectionPaperRelaEN.IsVisible = TransNullToBool(objRow[convMajorDirectionPaperRela.IsVisible].ToString().Trim()); //是否显示
objvMajorDirectionPaperRelaEN.PaperTitle = objRow[convMajorDirectionPaperRela.PaperTitle] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperTitle].ToString().Trim(); //论文标题
objvMajorDirectionPaperRelaEN.PaperContent = objRow[convMajorDirectionPaperRela.PaperContent] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperContent].ToString().Trim(); //主题内容
objvMajorDirectionPaperRelaEN.Periodical = objRow[convMajorDirectionPaperRela.Periodical] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Periodical].ToString().Trim(); //期刊
objvMajorDirectionPaperRelaEN.Author = objRow[convMajorDirectionPaperRela.Author] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Author].ToString().Trim(); //作者
objvMajorDirectionPaperRelaEN.ResearchQuestion = objRow[convMajorDirectionPaperRela.ResearchQuestion] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.ResearchQuestion].ToString().Trim(); //研究问题
objvMajorDirectionPaperRelaEN.Keyword = objRow[convMajorDirectionPaperRela.Keyword] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Keyword].ToString().Trim(); //关键字
objvMajorDirectionPaperRelaEN.LiteratureSources = objRow[convMajorDirectionPaperRela.LiteratureSources] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.LiteratureSources].ToString().Trim(); //文献来源
objvMajorDirectionPaperRelaEN.LiteratureLink = objRow[convMajorDirectionPaperRela.LiteratureLink] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.LiteratureLink].ToString().Trim(); //文献链接
objvMajorDirectionPaperRelaEN.UploadfileUrl = objRow[convMajorDirectionPaperRela.UploadfileUrl] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UploadfileUrl].ToString().Trim(); //文件地址
objvMajorDirectionPaperRelaEN.IsQuotethesis = TransNullToBool(objRow[convMajorDirectionPaperRela.IsQuotethesis].ToString().Trim()); //是否引用论文
objvMajorDirectionPaperRelaEN.Checker = objRow[convMajorDirectionPaperRela.Checker] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Checker].ToString().Trim(); //审核人
objvMajorDirectionPaperRelaEN.IsChecked = TransNullToBool(objRow[convMajorDirectionPaperRela.IsChecked].ToString().Trim()); //是否检查
objvMajorDirectionPaperRelaEN.MajorID = objRow[convMajorDirectionPaperRela.MajorID] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorID].ToString().Trim(); //专业ID
objvMajorDirectionPaperRelaEN.MajorName = objRow[convMajorDirectionPaperRela.MajorName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorName].ToString().Trim(); //专业名称
objvMajorDirectionPaperRelaEN.UserName = objRow[convMajorDirectionPaperRela.UserName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UserName].ToString().Trim(); //用户名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMajorDirectionPaperRelaDA: GetObjLst)", objException.Message));
}
objvMajorDirectionPaperRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMajorDirectionPaperRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvMajorDirectionPaperRela(ref clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorDirectionPaperRelaDA.GetSpecSQLObj();
strSQL = "Select * from vMajorDirectionPaperRela where mId = " + ""+ objvMajorDirectionPaperRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvMajorDirectionPaperRelaEN.mId = TransNullToInt(objDT.Rows[0][convMajorDirectionPaperRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvMajorDirectionPaperRelaEN.MajorDirectionId = objDT.Rows[0][convMajorDirectionPaperRela.MajorDirectionId].ToString().Trim(); //研究方向Id(字段类型:char,字段长度:8,是否可空:True)
 objvMajorDirectionPaperRelaEN.PaperId = objDT.Rows[0][convMajorDirectionPaperRela.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvMajorDirectionPaperRelaEN.UpdDate = objDT.Rows[0][convMajorDirectionPaperRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvMajorDirectionPaperRelaEN.UpdUser = objDT.Rows[0][convMajorDirectionPaperRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvMajorDirectionPaperRelaEN.Memo = objDT.Rows[0][convMajorDirectionPaperRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMajorDirectionPaperRelaEN.IdXzMajor = objDT.Rows[0][convMajorDirectionPaperRela.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMajorDirectionPaperRelaEN.MajorDirectionENName = objDT.Rows[0][convMajorDirectionPaperRela.MajorDirectionENName].ToString().Trim(); //研究方向英文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMajorDirectionPaperRelaEN.MajorDirectionName = objDT.Rows[0][convMajorDirectionPaperRela.MajorDirectionName].ToString().Trim(); //研究方向名(字段类型:varchar,字段长度:100,是否可空:False)
 objvMajorDirectionPaperRelaEN.MajorDirectionExplain = objDT.Rows[0][convMajorDirectionPaperRela.MajorDirectionExplain].ToString().Trim(); //专业方向说明(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMajorDirectionPaperRelaEN.IsVisible = TransNullToBool(objDT.Rows[0][convMajorDirectionPaperRela.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvMajorDirectionPaperRelaEN.PaperTitle = objDT.Rows[0][convMajorDirectionPaperRela.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvMajorDirectionPaperRelaEN.PaperContent = objDT.Rows[0][convMajorDirectionPaperRela.PaperContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvMajorDirectionPaperRelaEN.Periodical = objDT.Rows[0][convMajorDirectionPaperRela.Periodical].ToString().Trim(); //期刊(字段类型:varchar,字段长度:100,是否可空:True)
 objvMajorDirectionPaperRelaEN.Author = objDT.Rows[0][convMajorDirectionPaperRela.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvMajorDirectionPaperRelaEN.ResearchQuestion = objDT.Rows[0][convMajorDirectionPaperRela.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMajorDirectionPaperRelaEN.Keyword = objDT.Rows[0][convMajorDirectionPaperRela.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMajorDirectionPaperRelaEN.LiteratureSources = objDT.Rows[0][convMajorDirectionPaperRela.LiteratureSources].ToString().Trim(); //文献来源(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMajorDirectionPaperRelaEN.LiteratureLink = objDT.Rows[0][convMajorDirectionPaperRela.LiteratureLink].ToString().Trim(); //文献链接(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMajorDirectionPaperRelaEN.UploadfileUrl = objDT.Rows[0][convMajorDirectionPaperRela.UploadfileUrl].ToString().Trim(); //文件地址(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMajorDirectionPaperRelaEN.IsQuotethesis = TransNullToBool(objDT.Rows[0][convMajorDirectionPaperRela.IsQuotethesis].ToString().Trim()); //是否引用论文(字段类型:bit,字段长度:1,是否可空:True)
 objvMajorDirectionPaperRelaEN.Checker = objDT.Rows[0][convMajorDirectionPaperRela.Checker].ToString().Trim(); //审核人(字段类型:varchar,字段长度:20,是否可空:True)
 objvMajorDirectionPaperRelaEN.IsChecked = TransNullToBool(objDT.Rows[0][convMajorDirectionPaperRela.IsChecked].ToString().Trim()); //是否检查(字段类型:bit,字段长度:1,是否可空:True)
 objvMajorDirectionPaperRelaEN.MajorID = objDT.Rows[0][convMajorDirectionPaperRela.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvMajorDirectionPaperRelaEN.MajorName = objDT.Rows[0][convMajorDirectionPaperRela.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMajorDirectionPaperRelaEN.UserName = objDT.Rows[0][convMajorDirectionPaperRela.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvMajorDirectionPaperRelaDA: GetvMajorDirectionPaperRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvMajorDirectionPaperRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorDirectionPaperRelaDA.GetSpecSQLObj();
strSQL = "Select * from vMajorDirectionPaperRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN = new clsvMajorDirectionPaperRelaEN();
try
{
 objvMajorDirectionPaperRelaEN.mId = Int32.Parse(objRow[convMajorDirectionPaperRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvMajorDirectionPaperRelaEN.MajorDirectionId = objRow[convMajorDirectionPaperRela.MajorDirectionId] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionId].ToString().Trim(); //研究方向Id(字段类型:char,字段长度:8,是否可空:True)
 objvMajorDirectionPaperRelaEN.PaperId = objRow[convMajorDirectionPaperRela.PaperId] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvMajorDirectionPaperRelaEN.UpdDate = objRow[convMajorDirectionPaperRela.UpdDate] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvMajorDirectionPaperRelaEN.UpdUser = objRow[convMajorDirectionPaperRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvMajorDirectionPaperRelaEN.Memo = objRow[convMajorDirectionPaperRela.Memo] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMajorDirectionPaperRelaEN.IdXzMajor = objRow[convMajorDirectionPaperRela.IdXzMajor] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMajorDirectionPaperRelaEN.MajorDirectionENName = objRow[convMajorDirectionPaperRela.MajorDirectionENName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionENName].ToString().Trim(); //研究方向英文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMajorDirectionPaperRelaEN.MajorDirectionName = objRow[convMajorDirectionPaperRela.MajorDirectionName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionName].ToString().Trim(); //研究方向名(字段类型:varchar,字段长度:100,是否可空:False)
 objvMajorDirectionPaperRelaEN.MajorDirectionExplain = objRow[convMajorDirectionPaperRela.MajorDirectionExplain] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionExplain].ToString().Trim(); //专业方向说明(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMajorDirectionPaperRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvMajorDirectionPaperRelaEN.PaperTitle = objRow[convMajorDirectionPaperRela.PaperTitle] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvMajorDirectionPaperRelaEN.PaperContent = objRow[convMajorDirectionPaperRela.PaperContent] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvMajorDirectionPaperRelaEN.Periodical = objRow[convMajorDirectionPaperRela.Periodical] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Periodical].ToString().Trim(); //期刊(字段类型:varchar,字段长度:100,是否可空:True)
 objvMajorDirectionPaperRelaEN.Author = objRow[convMajorDirectionPaperRela.Author] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvMajorDirectionPaperRelaEN.ResearchQuestion = objRow[convMajorDirectionPaperRela.ResearchQuestion] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMajorDirectionPaperRelaEN.Keyword = objRow[convMajorDirectionPaperRela.Keyword] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMajorDirectionPaperRelaEN.LiteratureSources = objRow[convMajorDirectionPaperRela.LiteratureSources] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.LiteratureSources].ToString().Trim(); //文献来源(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMajorDirectionPaperRelaEN.LiteratureLink = objRow[convMajorDirectionPaperRela.LiteratureLink] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.LiteratureLink].ToString().Trim(); //文献链接(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMajorDirectionPaperRelaEN.UploadfileUrl = objRow[convMajorDirectionPaperRela.UploadfileUrl] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UploadfileUrl].ToString().Trim(); //文件地址(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMajorDirectionPaperRelaEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsQuotethesis].ToString().Trim()); //是否引用论文(字段类型:bit,字段长度:1,是否可空:True)
 objvMajorDirectionPaperRelaEN.Checker = objRow[convMajorDirectionPaperRela.Checker] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Checker].ToString().Trim(); //审核人(字段类型:varchar,字段长度:20,是否可空:True)
 objvMajorDirectionPaperRelaEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convMajorDirectionPaperRela.IsChecked].ToString().Trim()); //是否检查(字段类型:bit,字段长度:1,是否可空:True)
 objvMajorDirectionPaperRelaEN.MajorID = objRow[convMajorDirectionPaperRela.MajorID] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvMajorDirectionPaperRelaEN.MajorName = objRow[convMajorDirectionPaperRela.MajorName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMajorDirectionPaperRelaEN.UserName = objRow[convMajorDirectionPaperRela.UserName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvMajorDirectionPaperRelaDA: GetObjBymId)", objException.Message));
}
return objvMajorDirectionPaperRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvMajorDirectionPaperRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvMajorDirectionPaperRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorDirectionPaperRelaDA.GetSpecSQLObj();
strSQL = "Select * from vMajorDirectionPaperRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN = new clsvMajorDirectionPaperRelaEN()
{
mId = TransNullToInt(objRow[convMajorDirectionPaperRela.mId].ToString().Trim()), //mId
MajorDirectionId = objRow[convMajorDirectionPaperRela.MajorDirectionId] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionId].ToString().Trim(), //研究方向Id
PaperId = objRow[convMajorDirectionPaperRela.PaperId] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperId].ToString().Trim(), //论文Id
UpdDate = objRow[convMajorDirectionPaperRela.UpdDate] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convMajorDirectionPaperRela.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convMajorDirectionPaperRela.Memo] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Memo].ToString().Trim(), //备注
IdXzMajor = objRow[convMajorDirectionPaperRela.IdXzMajor] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.IdXzMajor].ToString().Trim(), //专业流水号
MajorDirectionENName = objRow[convMajorDirectionPaperRela.MajorDirectionENName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionENName].ToString().Trim(), //研究方向英文名
MajorDirectionName = objRow[convMajorDirectionPaperRela.MajorDirectionName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionName].ToString().Trim(), //研究方向名
MajorDirectionExplain = objRow[convMajorDirectionPaperRela.MajorDirectionExplain] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionExplain].ToString().Trim(), //专业方向说明
IsVisible = TransNullToBool(objRow[convMajorDirectionPaperRela.IsVisible].ToString().Trim()), //是否显示
PaperTitle = objRow[convMajorDirectionPaperRela.PaperTitle] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperTitle].ToString().Trim(), //论文标题
PaperContent = objRow[convMajorDirectionPaperRela.PaperContent] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperContent].ToString().Trim(), //主题内容
Periodical = objRow[convMajorDirectionPaperRela.Periodical] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Periodical].ToString().Trim(), //期刊
Author = objRow[convMajorDirectionPaperRela.Author] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Author].ToString().Trim(), //作者
ResearchQuestion = objRow[convMajorDirectionPaperRela.ResearchQuestion] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.ResearchQuestion].ToString().Trim(), //研究问题
Keyword = objRow[convMajorDirectionPaperRela.Keyword] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Keyword].ToString().Trim(), //关键字
LiteratureSources = objRow[convMajorDirectionPaperRela.LiteratureSources] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.LiteratureSources].ToString().Trim(), //文献来源
LiteratureLink = objRow[convMajorDirectionPaperRela.LiteratureLink] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.LiteratureLink].ToString().Trim(), //文献链接
UploadfileUrl = objRow[convMajorDirectionPaperRela.UploadfileUrl] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UploadfileUrl].ToString().Trim(), //文件地址
IsQuotethesis = TransNullToBool(objRow[convMajorDirectionPaperRela.IsQuotethesis].ToString().Trim()), //是否引用论文
Checker = objRow[convMajorDirectionPaperRela.Checker] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Checker].ToString().Trim(), //审核人
IsChecked = TransNullToBool(objRow[convMajorDirectionPaperRela.IsChecked].ToString().Trim()), //是否检查
MajorID = objRow[convMajorDirectionPaperRela.MajorID] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorID].ToString().Trim(), //专业ID
MajorName = objRow[convMajorDirectionPaperRela.MajorName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorName].ToString().Trim(), //专业名称
UserName = objRow[convMajorDirectionPaperRela.UserName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UserName].ToString().Trim() //用户名
};
objvMajorDirectionPaperRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMajorDirectionPaperRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvMajorDirectionPaperRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvMajorDirectionPaperRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN = new clsvMajorDirectionPaperRelaEN();
try
{
objvMajorDirectionPaperRelaEN.mId = TransNullToInt(objRow[convMajorDirectionPaperRela.mId].ToString().Trim()); //mId
objvMajorDirectionPaperRelaEN.MajorDirectionId = objRow[convMajorDirectionPaperRela.MajorDirectionId] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionId].ToString().Trim(); //研究方向Id
objvMajorDirectionPaperRelaEN.PaperId = objRow[convMajorDirectionPaperRela.PaperId] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperId].ToString().Trim(); //论文Id
objvMajorDirectionPaperRelaEN.UpdDate = objRow[convMajorDirectionPaperRela.UpdDate] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UpdDate].ToString().Trim(); //修改日期
objvMajorDirectionPaperRelaEN.UpdUser = objRow[convMajorDirectionPaperRela.UpdUser].ToString().Trim(); //修改人
objvMajorDirectionPaperRelaEN.Memo = objRow[convMajorDirectionPaperRela.Memo] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Memo].ToString().Trim(); //备注
objvMajorDirectionPaperRelaEN.IdXzMajor = objRow[convMajorDirectionPaperRela.IdXzMajor] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.IdXzMajor].ToString().Trim(); //专业流水号
objvMajorDirectionPaperRelaEN.MajorDirectionENName = objRow[convMajorDirectionPaperRela.MajorDirectionENName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objvMajorDirectionPaperRelaEN.MajorDirectionName = objRow[convMajorDirectionPaperRela.MajorDirectionName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionName].ToString().Trim(); //研究方向名
objvMajorDirectionPaperRelaEN.MajorDirectionExplain = objRow[convMajorDirectionPaperRela.MajorDirectionExplain] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objvMajorDirectionPaperRelaEN.IsVisible = TransNullToBool(objRow[convMajorDirectionPaperRela.IsVisible].ToString().Trim()); //是否显示
objvMajorDirectionPaperRelaEN.PaperTitle = objRow[convMajorDirectionPaperRela.PaperTitle] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperTitle].ToString().Trim(); //论文标题
objvMajorDirectionPaperRelaEN.PaperContent = objRow[convMajorDirectionPaperRela.PaperContent] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperContent].ToString().Trim(); //主题内容
objvMajorDirectionPaperRelaEN.Periodical = objRow[convMajorDirectionPaperRela.Periodical] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Periodical].ToString().Trim(); //期刊
objvMajorDirectionPaperRelaEN.Author = objRow[convMajorDirectionPaperRela.Author] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Author].ToString().Trim(); //作者
objvMajorDirectionPaperRelaEN.ResearchQuestion = objRow[convMajorDirectionPaperRela.ResearchQuestion] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.ResearchQuestion].ToString().Trim(); //研究问题
objvMajorDirectionPaperRelaEN.Keyword = objRow[convMajorDirectionPaperRela.Keyword] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Keyword].ToString().Trim(); //关键字
objvMajorDirectionPaperRelaEN.LiteratureSources = objRow[convMajorDirectionPaperRela.LiteratureSources] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.LiteratureSources].ToString().Trim(); //文献来源
objvMajorDirectionPaperRelaEN.LiteratureLink = objRow[convMajorDirectionPaperRela.LiteratureLink] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.LiteratureLink].ToString().Trim(); //文献链接
objvMajorDirectionPaperRelaEN.UploadfileUrl = objRow[convMajorDirectionPaperRela.UploadfileUrl] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UploadfileUrl].ToString().Trim(); //文件地址
objvMajorDirectionPaperRelaEN.IsQuotethesis = TransNullToBool(objRow[convMajorDirectionPaperRela.IsQuotethesis].ToString().Trim()); //是否引用论文
objvMajorDirectionPaperRelaEN.Checker = objRow[convMajorDirectionPaperRela.Checker] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Checker].ToString().Trim(); //审核人
objvMajorDirectionPaperRelaEN.IsChecked = TransNullToBool(objRow[convMajorDirectionPaperRela.IsChecked].ToString().Trim()); //是否检查
objvMajorDirectionPaperRelaEN.MajorID = objRow[convMajorDirectionPaperRela.MajorID] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorID].ToString().Trim(); //专业ID
objvMajorDirectionPaperRelaEN.MajorName = objRow[convMajorDirectionPaperRela.MajorName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorName].ToString().Trim(); //专业名称
objvMajorDirectionPaperRelaEN.UserName = objRow[convMajorDirectionPaperRela.UserName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UserName].ToString().Trim(); //用户名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvMajorDirectionPaperRelaDA: GetObjByDataRowvMajorDirectionPaperRela)", objException.Message));
}
objvMajorDirectionPaperRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMajorDirectionPaperRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvMajorDirectionPaperRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN = new clsvMajorDirectionPaperRelaEN();
try
{
objvMajorDirectionPaperRelaEN.mId = TransNullToInt(objRow[convMajorDirectionPaperRela.mId].ToString().Trim()); //mId
objvMajorDirectionPaperRelaEN.MajorDirectionId = objRow[convMajorDirectionPaperRela.MajorDirectionId] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionId].ToString().Trim(); //研究方向Id
objvMajorDirectionPaperRelaEN.PaperId = objRow[convMajorDirectionPaperRela.PaperId] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperId].ToString().Trim(); //论文Id
objvMajorDirectionPaperRelaEN.UpdDate = objRow[convMajorDirectionPaperRela.UpdDate] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UpdDate].ToString().Trim(); //修改日期
objvMajorDirectionPaperRelaEN.UpdUser = objRow[convMajorDirectionPaperRela.UpdUser].ToString().Trim(); //修改人
objvMajorDirectionPaperRelaEN.Memo = objRow[convMajorDirectionPaperRela.Memo] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Memo].ToString().Trim(); //备注
objvMajorDirectionPaperRelaEN.IdXzMajor = objRow[convMajorDirectionPaperRela.IdXzMajor] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.IdXzMajor].ToString().Trim(); //专业流水号
objvMajorDirectionPaperRelaEN.MajorDirectionENName = objRow[convMajorDirectionPaperRela.MajorDirectionENName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionENName].ToString().Trim(); //研究方向英文名
objvMajorDirectionPaperRelaEN.MajorDirectionName = objRow[convMajorDirectionPaperRela.MajorDirectionName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionName].ToString().Trim(); //研究方向名
objvMajorDirectionPaperRelaEN.MajorDirectionExplain = objRow[convMajorDirectionPaperRela.MajorDirectionExplain] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorDirectionExplain].ToString().Trim(); //专业方向说明
objvMajorDirectionPaperRelaEN.IsVisible = TransNullToBool(objRow[convMajorDirectionPaperRela.IsVisible].ToString().Trim()); //是否显示
objvMajorDirectionPaperRelaEN.PaperTitle = objRow[convMajorDirectionPaperRela.PaperTitle] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperTitle].ToString().Trim(); //论文标题
objvMajorDirectionPaperRelaEN.PaperContent = objRow[convMajorDirectionPaperRela.PaperContent] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.PaperContent].ToString().Trim(); //主题内容
objvMajorDirectionPaperRelaEN.Periodical = objRow[convMajorDirectionPaperRela.Periodical] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Periodical].ToString().Trim(); //期刊
objvMajorDirectionPaperRelaEN.Author = objRow[convMajorDirectionPaperRela.Author] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Author].ToString().Trim(); //作者
objvMajorDirectionPaperRelaEN.ResearchQuestion = objRow[convMajorDirectionPaperRela.ResearchQuestion] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.ResearchQuestion].ToString().Trim(); //研究问题
objvMajorDirectionPaperRelaEN.Keyword = objRow[convMajorDirectionPaperRela.Keyword] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Keyword].ToString().Trim(); //关键字
objvMajorDirectionPaperRelaEN.LiteratureSources = objRow[convMajorDirectionPaperRela.LiteratureSources] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.LiteratureSources].ToString().Trim(); //文献来源
objvMajorDirectionPaperRelaEN.LiteratureLink = objRow[convMajorDirectionPaperRela.LiteratureLink] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.LiteratureLink].ToString().Trim(); //文献链接
objvMajorDirectionPaperRelaEN.UploadfileUrl = objRow[convMajorDirectionPaperRela.UploadfileUrl] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UploadfileUrl].ToString().Trim(); //文件地址
objvMajorDirectionPaperRelaEN.IsQuotethesis = TransNullToBool(objRow[convMajorDirectionPaperRela.IsQuotethesis].ToString().Trim()); //是否引用论文
objvMajorDirectionPaperRelaEN.Checker = objRow[convMajorDirectionPaperRela.Checker] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.Checker].ToString().Trim(); //审核人
objvMajorDirectionPaperRelaEN.IsChecked = TransNullToBool(objRow[convMajorDirectionPaperRela.IsChecked].ToString().Trim()); //是否检查
objvMajorDirectionPaperRelaEN.MajorID = objRow[convMajorDirectionPaperRela.MajorID] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorID].ToString().Trim(); //专业ID
objvMajorDirectionPaperRelaEN.MajorName = objRow[convMajorDirectionPaperRela.MajorName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.MajorName].ToString().Trim(); //专业名称
objvMajorDirectionPaperRelaEN.UserName = objRow[convMajorDirectionPaperRela.UserName] == DBNull.Value ? null : objRow[convMajorDirectionPaperRela.UserName].ToString().Trim(); //用户名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvMajorDirectionPaperRelaDA: GetObjByDataRow)", objException.Message));
}
objvMajorDirectionPaperRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMajorDirectionPaperRelaEN;
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
objSQL = clsvMajorDirectionPaperRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMajorDirectionPaperRelaEN._CurrTabName, convMajorDirectionPaperRela.mId, 8, "");
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
objSQL = clsvMajorDirectionPaperRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMajorDirectionPaperRelaEN._CurrTabName, convMajorDirectionPaperRela.mId, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public long GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorDirectionPaperRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vMajorDirectionPaperRela where " + strCondition;
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
return 0;
}
strKeyValue = objDT.Rows[0][0].ToString();
return long.Parse(strKeyValue);
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
 objSQL = clsvMajorDirectionPaperRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vMajorDirectionPaperRela where " + strCondition;
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorDirectionPaperRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMajorDirectionPaperRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvMajorDirectionPaperRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorDirectionPaperRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMajorDirectionPaperRela", strCondition))
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
objSQL = clsvMajorDirectionPaperRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vMajorDirectionPaperRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvMajorDirectionPaperRelaENS">源对象</param>
 /// <param name = "objvMajorDirectionPaperRelaENT">目标对象</param>
public void CopyTo(clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaENS, clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaENT)
{
objvMajorDirectionPaperRelaENT.mId = objvMajorDirectionPaperRelaENS.mId; //mId
objvMajorDirectionPaperRelaENT.MajorDirectionId = objvMajorDirectionPaperRelaENS.MajorDirectionId; //研究方向Id
objvMajorDirectionPaperRelaENT.PaperId = objvMajorDirectionPaperRelaENS.PaperId; //论文Id
objvMajorDirectionPaperRelaENT.UpdDate = objvMajorDirectionPaperRelaENS.UpdDate; //修改日期
objvMajorDirectionPaperRelaENT.UpdUser = objvMajorDirectionPaperRelaENS.UpdUser; //修改人
objvMajorDirectionPaperRelaENT.Memo = objvMajorDirectionPaperRelaENS.Memo; //备注
objvMajorDirectionPaperRelaENT.IdXzMajor = objvMajorDirectionPaperRelaENS.IdXzMajor; //专业流水号
objvMajorDirectionPaperRelaENT.MajorDirectionENName = objvMajorDirectionPaperRelaENS.MajorDirectionENName; //研究方向英文名
objvMajorDirectionPaperRelaENT.MajorDirectionName = objvMajorDirectionPaperRelaENS.MajorDirectionName; //研究方向名
objvMajorDirectionPaperRelaENT.MajorDirectionExplain = objvMajorDirectionPaperRelaENS.MajorDirectionExplain; //专业方向说明
objvMajorDirectionPaperRelaENT.IsVisible = objvMajorDirectionPaperRelaENS.IsVisible; //是否显示
objvMajorDirectionPaperRelaENT.PaperTitle = objvMajorDirectionPaperRelaENS.PaperTitle; //论文标题
objvMajorDirectionPaperRelaENT.PaperContent = objvMajorDirectionPaperRelaENS.PaperContent; //主题内容
objvMajorDirectionPaperRelaENT.Periodical = objvMajorDirectionPaperRelaENS.Periodical; //期刊
objvMajorDirectionPaperRelaENT.Author = objvMajorDirectionPaperRelaENS.Author; //作者
objvMajorDirectionPaperRelaENT.ResearchQuestion = objvMajorDirectionPaperRelaENS.ResearchQuestion; //研究问题
objvMajorDirectionPaperRelaENT.Keyword = objvMajorDirectionPaperRelaENS.Keyword; //关键字
objvMajorDirectionPaperRelaENT.LiteratureSources = objvMajorDirectionPaperRelaENS.LiteratureSources; //文献来源
objvMajorDirectionPaperRelaENT.LiteratureLink = objvMajorDirectionPaperRelaENS.LiteratureLink; //文献链接
objvMajorDirectionPaperRelaENT.UploadfileUrl = objvMajorDirectionPaperRelaENS.UploadfileUrl; //文件地址
objvMajorDirectionPaperRelaENT.IsQuotethesis = objvMajorDirectionPaperRelaENS.IsQuotethesis; //是否引用论文
objvMajorDirectionPaperRelaENT.Checker = objvMajorDirectionPaperRelaENS.Checker; //审核人
objvMajorDirectionPaperRelaENT.IsChecked = objvMajorDirectionPaperRelaENS.IsChecked; //是否检查
objvMajorDirectionPaperRelaENT.MajorID = objvMajorDirectionPaperRelaENS.MajorID; //专业ID
objvMajorDirectionPaperRelaENT.MajorName = objvMajorDirectionPaperRelaENS.MajorName; //专业名称
objvMajorDirectionPaperRelaENT.UserName = objvMajorDirectionPaperRelaENS.UserName; //用户名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvMajorDirectionPaperRelaEN objvMajorDirectionPaperRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvMajorDirectionPaperRelaEN.MajorDirectionId, 8, convMajorDirectionPaperRela.MajorDirectionId);
clsCheckSql.CheckFieldLen(objvMajorDirectionPaperRelaEN.PaperId, 8, convMajorDirectionPaperRela.PaperId);
clsCheckSql.CheckFieldLen(objvMajorDirectionPaperRelaEN.UpdDate, 20, convMajorDirectionPaperRela.UpdDate);
clsCheckSql.CheckFieldLen(objvMajorDirectionPaperRelaEN.UpdUser, 20, convMajorDirectionPaperRela.UpdUser);
clsCheckSql.CheckFieldLen(objvMajorDirectionPaperRelaEN.Memo, 1000, convMajorDirectionPaperRela.Memo);
clsCheckSql.CheckFieldLen(objvMajorDirectionPaperRelaEN.IdXzMajor, 8, convMajorDirectionPaperRela.IdXzMajor);
clsCheckSql.CheckFieldLen(objvMajorDirectionPaperRelaEN.MajorDirectionENName, 200, convMajorDirectionPaperRela.MajorDirectionENName);
clsCheckSql.CheckFieldLen(objvMajorDirectionPaperRelaEN.MajorDirectionName, 100, convMajorDirectionPaperRela.MajorDirectionName);
clsCheckSql.CheckFieldLen(objvMajorDirectionPaperRelaEN.MajorDirectionExplain, 2000, convMajorDirectionPaperRela.MajorDirectionExplain);
clsCheckSql.CheckFieldLen(objvMajorDirectionPaperRelaEN.PaperTitle, 500, convMajorDirectionPaperRela.PaperTitle);
clsCheckSql.CheckFieldLen(objvMajorDirectionPaperRelaEN.Periodical, 100, convMajorDirectionPaperRela.Periodical);
clsCheckSql.CheckFieldLen(objvMajorDirectionPaperRelaEN.Author, 200, convMajorDirectionPaperRela.Author);
clsCheckSql.CheckFieldLen(objvMajorDirectionPaperRelaEN.ResearchQuestion, 2000, convMajorDirectionPaperRela.ResearchQuestion);
clsCheckSql.CheckFieldLen(objvMajorDirectionPaperRelaEN.Keyword, 1000, convMajorDirectionPaperRela.Keyword);
clsCheckSql.CheckFieldLen(objvMajorDirectionPaperRelaEN.LiteratureSources, 1000, convMajorDirectionPaperRela.LiteratureSources);
clsCheckSql.CheckFieldLen(objvMajorDirectionPaperRelaEN.LiteratureLink, 1000, convMajorDirectionPaperRela.LiteratureLink);
clsCheckSql.CheckFieldLen(objvMajorDirectionPaperRelaEN.UploadfileUrl, 1000, convMajorDirectionPaperRela.UploadfileUrl);
clsCheckSql.CheckFieldLen(objvMajorDirectionPaperRelaEN.Checker, 20, convMajorDirectionPaperRela.Checker);
clsCheckSql.CheckFieldLen(objvMajorDirectionPaperRelaEN.MajorID, 4, convMajorDirectionPaperRela.MajorID);
clsCheckSql.CheckFieldLen(objvMajorDirectionPaperRelaEN.MajorName, 100, convMajorDirectionPaperRela.MajorName);
clsCheckSql.CheckFieldLen(objvMajorDirectionPaperRelaEN.UserName, 30, convMajorDirectionPaperRela.UserName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvMajorDirectionPaperRelaEN.MajorDirectionId, convMajorDirectionPaperRela.MajorDirectionId);
clsCheckSql.CheckSqlInjection4Field(objvMajorDirectionPaperRelaEN.PaperId, convMajorDirectionPaperRela.PaperId);
clsCheckSql.CheckSqlInjection4Field(objvMajorDirectionPaperRelaEN.UpdDate, convMajorDirectionPaperRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvMajorDirectionPaperRelaEN.UpdUser, convMajorDirectionPaperRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvMajorDirectionPaperRelaEN.Memo, convMajorDirectionPaperRela.Memo);
clsCheckSql.CheckSqlInjection4Field(objvMajorDirectionPaperRelaEN.IdXzMajor, convMajorDirectionPaperRela.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvMajorDirectionPaperRelaEN.MajorDirectionENName, convMajorDirectionPaperRela.MajorDirectionENName);
clsCheckSql.CheckSqlInjection4Field(objvMajorDirectionPaperRelaEN.MajorDirectionName, convMajorDirectionPaperRela.MajorDirectionName);
clsCheckSql.CheckSqlInjection4Field(objvMajorDirectionPaperRelaEN.MajorDirectionExplain, convMajorDirectionPaperRela.MajorDirectionExplain);
clsCheckSql.CheckSqlInjection4Field(objvMajorDirectionPaperRelaEN.PaperTitle, convMajorDirectionPaperRela.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objvMajorDirectionPaperRelaEN.Periodical, convMajorDirectionPaperRela.Periodical);
clsCheckSql.CheckSqlInjection4Field(objvMajorDirectionPaperRelaEN.Author, convMajorDirectionPaperRela.Author);
clsCheckSql.CheckSqlInjection4Field(objvMajorDirectionPaperRelaEN.ResearchQuestion, convMajorDirectionPaperRela.ResearchQuestion);
clsCheckSql.CheckSqlInjection4Field(objvMajorDirectionPaperRelaEN.Keyword, convMajorDirectionPaperRela.Keyword);
clsCheckSql.CheckSqlInjection4Field(objvMajorDirectionPaperRelaEN.LiteratureSources, convMajorDirectionPaperRela.LiteratureSources);
clsCheckSql.CheckSqlInjection4Field(objvMajorDirectionPaperRelaEN.LiteratureLink, convMajorDirectionPaperRela.LiteratureLink);
clsCheckSql.CheckSqlInjection4Field(objvMajorDirectionPaperRelaEN.UploadfileUrl, convMajorDirectionPaperRela.UploadfileUrl);
clsCheckSql.CheckSqlInjection4Field(objvMajorDirectionPaperRelaEN.Checker, convMajorDirectionPaperRela.Checker);
clsCheckSql.CheckSqlInjection4Field(objvMajorDirectionPaperRelaEN.MajorID, convMajorDirectionPaperRela.MajorID);
clsCheckSql.CheckSqlInjection4Field(objvMajorDirectionPaperRelaEN.MajorName, convMajorDirectionPaperRela.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvMajorDirectionPaperRelaEN.UserName, convMajorDirectionPaperRela.UserName);
//检查外键字段长度
 objvMajorDirectionPaperRelaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

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
 objSQL = clsvMajorDirectionPaperRelaDA.GetSpecSQLObj();
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
 objSQL = clsvMajorDirectionPaperRelaDA.GetSpecSQLObj();
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
 objSQL = clsvMajorDirectionPaperRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMajorDirectionPaperRelaEN._CurrTabName);
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
 objSQL = clsvMajorDirectionPaperRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMajorDirectionPaperRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvMajorDirectionPaperRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}