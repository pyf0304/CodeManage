
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPaperSubViewpointLikeLogDA
 表名:PaperSubViewpointLikeLog(01120560)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:05:35
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
 框架-层名:数据处理层(CS)(DALCode,0002)
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
 /// 子观点点赞表(PaperSubViewpointLikeLog)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsPaperSubViewpointLikeLogDA : clsCommBase4DA
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
 return clsPaperSubViewpointLikeLogEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsPaperSubViewpointLikeLogEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPaperSubViewpointLikeLogEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsPaperSubViewpointLikeLogEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsPaperSubViewpointLikeLogEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsPaperSubViewpointLikeLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
strSQL = "Select * from PaperSubViewpointLikeLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_PaperSubViewpointLikeLog(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsPaperSubViewpointLikeLogDA: GetDataTable_PaperSubViewpointLikeLog)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
strSQL = "Select * from PaperSubViewpointLikeLog where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsPaperSubViewpointLikeLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsPaperSubViewpointLikeLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
strSQL = "Select * from PaperSubViewpointLikeLog where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsPaperSubViewpointLikeLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsPaperSubViewpointLikeLogDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PaperSubViewpointLikeLog where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PaperSubViewpointLikeLog where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsPaperSubViewpointLikeLogDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from PaperSubViewpointLikeLog where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsPaperSubViewpointLikeLogDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} PaperSubViewpointLikeLog.* from PaperSubViewpointLikeLog Left Join {1} on {2} where {3} and PaperSubViewpointLikeLog.PaperSubViewpointLikeLogId not in (Select top {5} PaperSubViewpointLikeLog.PaperSubViewpointLikeLogId from PaperSubViewpointLikeLog Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PaperSubViewpointLikeLog where {1} and PaperSubViewpointLikeLogId not in (Select top {2} PaperSubViewpointLikeLogId from PaperSubViewpointLikeLog where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PaperSubViewpointLikeLog where {1} and PaperSubViewpointLikeLogId not in (Select top {3} PaperSubViewpointLikeLogId from PaperSubViewpointLikeLog where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsPaperSubViewpointLikeLogDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} PaperSubViewpointLikeLog.* from PaperSubViewpointLikeLog Left Join {1} on {2} where {3} and PaperSubViewpointLikeLog.PaperSubViewpointLikeLogId not in (Select top {5} PaperSubViewpointLikeLog.PaperSubViewpointLikeLogId from PaperSubViewpointLikeLog Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PaperSubViewpointLikeLog where {1} and PaperSubViewpointLikeLogId not in (Select top {2} PaperSubViewpointLikeLogId from PaperSubViewpointLikeLog where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PaperSubViewpointLikeLog where {1} and PaperSubViewpointLikeLogId not in (Select top {3} PaperSubViewpointLikeLogId from PaperSubViewpointLikeLog where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsPaperSubViewpointLikeLogEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsPaperSubViewpointLikeLogDA:GetObjLst)", objException.Message));
}
List<clsPaperSubViewpointLikeLogEN> arrObjLst = new List<clsPaperSubViewpointLikeLogEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
strSQL = "Select * from PaperSubViewpointLikeLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubViewpointLikeLogEN objPaperSubViewpointLikeLogEN = new clsPaperSubViewpointLikeLogEN();
try
{
objPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId = TransNullToInt(objRow[conPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId].ToString().Trim()); //点赞Id
objPaperSubViewpointLikeLogEN.SubViewpointId = TransNullToInt(objRow[conPaperSubViewpointLikeLog.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubViewpointLikeLogEN.UpdDate = objRow[conPaperSubViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[conPaperSubViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objPaperSubViewpointLikeLogEN.UpdUser = objRow[conPaperSubViewpointLikeLog.UpdUser] == DBNull.Value ? null : objRow[conPaperSubViewpointLikeLog.UpdUser].ToString().Trim(); //修改人
objPaperSubViewpointLikeLogEN.Memo = objRow[conPaperSubViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[conPaperSubViewpointLikeLog.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPaperSubViewpointLikeLogDA: GetObjLst)", objException.Message));
}
objPaperSubViewpointLikeLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPaperSubViewpointLikeLogEN);
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
public List<clsPaperSubViewpointLikeLogEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsPaperSubViewpointLikeLogDA:GetObjLstByTabName)", objException.Message));
}
List<clsPaperSubViewpointLikeLogEN> arrObjLst = new List<clsPaperSubViewpointLikeLogEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperSubViewpointLikeLogEN objPaperSubViewpointLikeLogEN = new clsPaperSubViewpointLikeLogEN();
try
{
objPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId = TransNullToInt(objRow[conPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId].ToString().Trim()); //点赞Id
objPaperSubViewpointLikeLogEN.SubViewpointId = TransNullToInt(objRow[conPaperSubViewpointLikeLog.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubViewpointLikeLogEN.UpdDate = objRow[conPaperSubViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[conPaperSubViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objPaperSubViewpointLikeLogEN.UpdUser = objRow[conPaperSubViewpointLikeLog.UpdUser] == DBNull.Value ? null : objRow[conPaperSubViewpointLikeLog.UpdUser].ToString().Trim(); //修改人
objPaperSubViewpointLikeLogEN.Memo = objRow[conPaperSubViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[conPaperSubViewpointLikeLog.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPaperSubViewpointLikeLogDA: GetObjLst)", objException.Message));
}
objPaperSubViewpointLikeLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPaperSubViewpointLikeLogEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objPaperSubViewpointLikeLogEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetPaperSubViewpointLikeLog(ref clsPaperSubViewpointLikeLogEN objPaperSubViewpointLikeLogEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
strSQL = "Select * from PaperSubViewpointLikeLog where PaperSubViewpointLikeLogId = " + ""+ objPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId = TransNullToInt(objDT.Rows[0][conPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId].ToString().Trim()); //点赞Id(字段类型:bigint,字段长度:8,是否可空:False)
 objPaperSubViewpointLikeLogEN.SubViewpointId = TransNullToInt(objDT.Rows[0][conPaperSubViewpointLikeLog.SubViewpointId].ToString().Trim()); //子观点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objPaperSubViewpointLikeLogEN.UpdDate = objDT.Rows[0][conPaperSubViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPaperSubViewpointLikeLogEN.UpdUser = objDT.Rows[0][conPaperSubViewpointLikeLog.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objPaperSubViewpointLikeLogEN.Memo = objDT.Rows[0][conPaperSubViewpointLikeLog.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsPaperSubViewpointLikeLogDA: GetPaperSubViewpointLikeLog)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngPaperSubViewpointLikeLogId">表关键字</param>
 /// <returns>表对象</returns>
public clsPaperSubViewpointLikeLogEN GetObjByPaperSubViewpointLikeLogId(long lngPaperSubViewpointLikeLogId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
strSQL = "Select * from PaperSubViewpointLikeLog where PaperSubViewpointLikeLogId = " + ""+ lngPaperSubViewpointLikeLogId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsPaperSubViewpointLikeLogEN objPaperSubViewpointLikeLogEN = new clsPaperSubViewpointLikeLogEN();
try
{
 objPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId = Int32.Parse(objRow[conPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId].ToString().Trim()); //点赞Id(字段类型:bigint,字段长度:8,是否可空:False)
 objPaperSubViewpointLikeLogEN.SubViewpointId = Int32.Parse(objRow[conPaperSubViewpointLikeLog.SubViewpointId].ToString().Trim()); //子观点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objPaperSubViewpointLikeLogEN.UpdDate = objRow[conPaperSubViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[conPaperSubViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPaperSubViewpointLikeLogEN.UpdUser = objRow[conPaperSubViewpointLikeLog.UpdUser] == DBNull.Value ? null : objRow[conPaperSubViewpointLikeLog.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objPaperSubViewpointLikeLogEN.Memo = objRow[conPaperSubViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[conPaperSubViewpointLikeLog.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsPaperSubViewpointLikeLogDA: GetObjByPaperSubViewpointLikeLogId)", objException.Message));
}
return objPaperSubViewpointLikeLogEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsPaperSubViewpointLikeLogEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsPaperSubViewpointLikeLogDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
strSQL = "Select * from PaperSubViewpointLikeLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsPaperSubViewpointLikeLogEN objPaperSubViewpointLikeLogEN = new clsPaperSubViewpointLikeLogEN()
{
PaperSubViewpointLikeLogId = TransNullToInt(objRow[conPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId].ToString().Trim()), //点赞Id
SubViewpointId = TransNullToInt(objRow[conPaperSubViewpointLikeLog.SubViewpointId].ToString().Trim()), //子观点Id
UpdDate = objRow[conPaperSubViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[conPaperSubViewpointLikeLog.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conPaperSubViewpointLikeLog.UpdUser] == DBNull.Value ? null : objRow[conPaperSubViewpointLikeLog.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conPaperSubViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[conPaperSubViewpointLikeLog.Memo].ToString().Trim() //备注
};
objPaperSubViewpointLikeLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPaperSubViewpointLikeLogEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsPaperSubViewpointLikeLogDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsPaperSubViewpointLikeLogEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPaperSubViewpointLikeLogEN objPaperSubViewpointLikeLogEN = new clsPaperSubViewpointLikeLogEN();
try
{
objPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId = TransNullToInt(objRow[conPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId].ToString().Trim()); //点赞Id
objPaperSubViewpointLikeLogEN.SubViewpointId = TransNullToInt(objRow[conPaperSubViewpointLikeLog.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubViewpointLikeLogEN.UpdDate = objRow[conPaperSubViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[conPaperSubViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objPaperSubViewpointLikeLogEN.UpdUser = objRow[conPaperSubViewpointLikeLog.UpdUser] == DBNull.Value ? null : objRow[conPaperSubViewpointLikeLog.UpdUser].ToString().Trim(); //修改人
objPaperSubViewpointLikeLogEN.Memo = objRow[conPaperSubViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[conPaperSubViewpointLikeLog.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsPaperSubViewpointLikeLogDA: GetObjByDataRowPaperSubViewpointLikeLog)", objException.Message));
}
objPaperSubViewpointLikeLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPaperSubViewpointLikeLogEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsPaperSubViewpointLikeLogEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPaperSubViewpointLikeLogEN objPaperSubViewpointLikeLogEN = new clsPaperSubViewpointLikeLogEN();
try
{
objPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId = TransNullToInt(objRow[conPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId].ToString().Trim()); //点赞Id
objPaperSubViewpointLikeLogEN.SubViewpointId = TransNullToInt(objRow[conPaperSubViewpointLikeLog.SubViewpointId].ToString().Trim()); //子观点Id
objPaperSubViewpointLikeLogEN.UpdDate = objRow[conPaperSubViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[conPaperSubViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objPaperSubViewpointLikeLogEN.UpdUser = objRow[conPaperSubViewpointLikeLog.UpdUser] == DBNull.Value ? null : objRow[conPaperSubViewpointLikeLog.UpdUser].ToString().Trim(); //修改人
objPaperSubViewpointLikeLogEN.Memo = objRow[conPaperSubViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[conPaperSubViewpointLikeLog.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsPaperSubViewpointLikeLogDA: GetObjByDataRow)", objException.Message));
}
objPaperSubViewpointLikeLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPaperSubViewpointLikeLogEN;
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
objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPaperSubViewpointLikeLogEN._CurrTabName, conPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId, 8, "");
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
objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPaperSubViewpointLikeLogEN._CurrTabName, conPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId, 8, strPrefix);
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
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PaperSubViewpointLikeLogId from PaperSubViewpointLikeLog where " + strCondition;
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
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PaperSubViewpointLikeLogId from PaperSubViewpointLikeLog where " + strCondition;
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
 /// <param name = "lngPaperSubViewpointLikeLogId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngPaperSubViewpointLikeLogId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PaperSubViewpointLikeLog", "PaperSubViewpointLikeLogId = " + ""+ lngPaperSubViewpointLikeLogId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsPaperSubViewpointLikeLogDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PaperSubViewpointLikeLog", strCondition))
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
objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("PaperSubViewpointLikeLog");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsPaperSubViewpointLikeLogEN objPaperSubViewpointLikeLogEN)
 {
 objPaperSubViewpointLikeLogEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPaperSubViewpointLikeLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPaperSubViewpointLikeLogEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
strSQL = "Select * from PaperSubViewpointLikeLog where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PaperSubViewpointLikeLog");
objRow = objDS.Tables["PaperSubViewpointLikeLog"].NewRow();
objRow[conPaperSubViewpointLikeLog.SubViewpointId] = objPaperSubViewpointLikeLogEN.SubViewpointId; //子观点Id
 if (objPaperSubViewpointLikeLogEN.UpdDate !=  "")
 {
objRow[conPaperSubViewpointLikeLog.UpdDate] = objPaperSubViewpointLikeLogEN.UpdDate; //修改日期
 }
 if (objPaperSubViewpointLikeLogEN.UpdUser !=  "")
 {
objRow[conPaperSubViewpointLikeLog.UpdUser] = objPaperSubViewpointLikeLogEN.UpdUser; //修改人
 }
 if (objPaperSubViewpointLikeLogEN.Memo !=  "")
 {
objRow[conPaperSubViewpointLikeLog.Memo] = objPaperSubViewpointLikeLogEN.Memo; //备注
 }
objDS.Tables[clsPaperSubViewpointLikeLogEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsPaperSubViewpointLikeLogEN._CurrTabName);
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
 /// <param name = "objPaperSubViewpointLikeLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPaperSubViewpointLikeLogEN objPaperSubViewpointLikeLogEN)
{
 objPaperSubViewpointLikeLogEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPaperSubViewpointLikeLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPaperSubViewpointLikeLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conPaperSubViewpointLikeLog.SubViewpointId);
 arrValueListForInsert.Add(objPaperSubViewpointLikeLogEN.SubViewpointId.ToString());
 
 if (objPaperSubViewpointLikeLogEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpointLikeLog.UpdDate);
 var strUpdDate = objPaperSubViewpointLikeLogEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPaperSubViewpointLikeLogEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpointLikeLog.UpdUser);
 var strUpdUser = objPaperSubViewpointLikeLogEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objPaperSubViewpointLikeLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpointLikeLog.Memo);
 var strMemo = objPaperSubViewpointLikeLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PaperSubViewpointLikeLog");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objPaperSubViewpointLikeLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPaperSubViewpointLikeLogEN objPaperSubViewpointLikeLogEN)
{
 objPaperSubViewpointLikeLogEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPaperSubViewpointLikeLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPaperSubViewpointLikeLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conPaperSubViewpointLikeLog.SubViewpointId);
 arrValueListForInsert.Add(objPaperSubViewpointLikeLogEN.SubViewpointId.ToString());
 
 if (objPaperSubViewpointLikeLogEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpointLikeLog.UpdDate);
 var strUpdDate = objPaperSubViewpointLikeLogEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPaperSubViewpointLikeLogEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpointLikeLog.UpdUser);
 var strUpdUser = objPaperSubViewpointLikeLogEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objPaperSubViewpointLikeLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpointLikeLog.Memo);
 var strMemo = objPaperSubViewpointLikeLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PaperSubViewpointLikeLog");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objPaperSubViewpointLikeLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPaperSubViewpointLikeLogEN objPaperSubViewpointLikeLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objPaperSubViewpointLikeLogEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPaperSubViewpointLikeLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPaperSubViewpointLikeLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conPaperSubViewpointLikeLog.SubViewpointId);
 arrValueListForInsert.Add(objPaperSubViewpointLikeLogEN.SubViewpointId.ToString());
 
 if (objPaperSubViewpointLikeLogEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpointLikeLog.UpdDate);
 var strUpdDate = objPaperSubViewpointLikeLogEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPaperSubViewpointLikeLogEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpointLikeLog.UpdUser);
 var strUpdUser = objPaperSubViewpointLikeLogEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objPaperSubViewpointLikeLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpointLikeLog.Memo);
 var strMemo = objPaperSubViewpointLikeLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PaperSubViewpointLikeLog");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objPaperSubViewpointLikeLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPaperSubViewpointLikeLogEN objPaperSubViewpointLikeLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objPaperSubViewpointLikeLogEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPaperSubViewpointLikeLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPaperSubViewpointLikeLogEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conPaperSubViewpointLikeLog.SubViewpointId);
 arrValueListForInsert.Add(objPaperSubViewpointLikeLogEN.SubViewpointId.ToString());
 
 if (objPaperSubViewpointLikeLogEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpointLikeLog.UpdDate);
 var strUpdDate = objPaperSubViewpointLikeLogEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPaperSubViewpointLikeLogEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpointLikeLog.UpdUser);
 var strUpdUser = objPaperSubViewpointLikeLogEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objPaperSubViewpointLikeLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPaperSubViewpointLikeLog.Memo);
 var strMemo = objPaperSubViewpointLikeLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PaperSubViewpointLikeLog");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewPaperSubViewpointLikeLogs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
strSQL = "Select * from PaperSubViewpointLikeLog where PaperSubViewpointLikeLogId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PaperSubViewpointLikeLog");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngPaperSubViewpointLikeLogId = TransNullToInt(oRow[conPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId].ToString().Trim());
if (IsExist(lngPaperSubViewpointLikeLogId))
{
 string strResult = "关键字变量值为:" + string.Format("PaperSubViewpointLikeLogId = {0}", lngPaperSubViewpointLikeLogId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsPaperSubViewpointLikeLogEN._CurrTabName ].NewRow();
objRow[conPaperSubViewpointLikeLog.SubViewpointId] = oRow[conPaperSubViewpointLikeLog.SubViewpointId].ToString().Trim(); //子观点Id
objRow[conPaperSubViewpointLikeLog.UpdDate] = oRow[conPaperSubViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objRow[conPaperSubViewpointLikeLog.UpdUser] = oRow[conPaperSubViewpointLikeLog.UpdUser].ToString().Trim(); //修改人
objRow[conPaperSubViewpointLikeLog.Memo] = oRow[conPaperSubViewpointLikeLog.Memo].ToString().Trim(); //备注
 objDS.Tables[clsPaperSubViewpointLikeLogEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsPaperSubViewpointLikeLogEN._CurrTabName);
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
 /// <param name = "objPaperSubViewpointLikeLogEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsPaperSubViewpointLikeLogEN objPaperSubViewpointLikeLogEN)
{
 objPaperSubViewpointLikeLogEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPaperSubViewpointLikeLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPaperSubViewpointLikeLogEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
strSQL = "Select * from PaperSubViewpointLikeLog where PaperSubViewpointLikeLogId = " + ""+ objPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsPaperSubViewpointLikeLogEN._CurrTabName);
if (objDS.Tables[clsPaperSubViewpointLikeLogEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:PaperSubViewpointLikeLogId = " + ""+ objPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId+"");
return false;
}
objRow = objDS.Tables[clsPaperSubViewpointLikeLogEN._CurrTabName].Rows[0];
 if (objPaperSubViewpointLikeLogEN.IsUpdated(conPaperSubViewpointLikeLog.SubViewpointId))
 {
objRow[conPaperSubViewpointLikeLog.SubViewpointId] = objPaperSubViewpointLikeLogEN.SubViewpointId; //子观点Id
 }
 if (objPaperSubViewpointLikeLogEN.IsUpdated(conPaperSubViewpointLikeLog.UpdDate))
 {
objRow[conPaperSubViewpointLikeLog.UpdDate] = objPaperSubViewpointLikeLogEN.UpdDate; //修改日期
 }
 if (objPaperSubViewpointLikeLogEN.IsUpdated(conPaperSubViewpointLikeLog.UpdUser))
 {
objRow[conPaperSubViewpointLikeLog.UpdUser] = objPaperSubViewpointLikeLogEN.UpdUser; //修改人
 }
 if (objPaperSubViewpointLikeLogEN.IsUpdated(conPaperSubViewpointLikeLog.Memo))
 {
objRow[conPaperSubViewpointLikeLog.Memo] = objPaperSubViewpointLikeLogEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsPaperSubViewpointLikeLogEN._CurrTabName);
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
 /// <param name = "objPaperSubViewpointLikeLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPaperSubViewpointLikeLogEN objPaperSubViewpointLikeLogEN)
{
 objPaperSubViewpointLikeLogEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPaperSubViewpointLikeLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPaperSubViewpointLikeLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update PaperSubViewpointLikeLog Set ");
 
 if (objPaperSubViewpointLikeLogEN.IsUpdated(conPaperSubViewpointLikeLog.SubViewpointId))
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointLikeLogEN.SubViewpointId, conPaperSubViewpointLikeLog.SubViewpointId); //子观点Id
 }
 
 if (objPaperSubViewpointLikeLogEN.IsUpdated(conPaperSubViewpointLikeLog.UpdDate))
 {
 if (objPaperSubViewpointLikeLogEN.UpdDate !=  null)
 {
 var strUpdDate = objPaperSubViewpointLikeLogEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conPaperSubViewpointLikeLog.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpointLikeLog.UpdDate); //修改日期
 }
 }
 
 if (objPaperSubViewpointLikeLogEN.IsUpdated(conPaperSubViewpointLikeLog.UpdUser))
 {
 if (objPaperSubViewpointLikeLogEN.UpdUser !=  null)
 {
 var strUpdUser = objPaperSubViewpointLikeLogEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conPaperSubViewpointLikeLog.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpointLikeLog.UpdUser); //修改人
 }
 }
 
 if (objPaperSubViewpointLikeLogEN.IsUpdated(conPaperSubViewpointLikeLog.Memo))
 {
 if (objPaperSubViewpointLikeLogEN.Memo !=  null)
 {
 var strMemo = objPaperSubViewpointLikeLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPaperSubViewpointLikeLog.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpointLikeLog.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PaperSubViewpointLikeLogId = {0}", objPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId); 
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
 /// <param name = "objPaperSubViewpointLikeLogEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsPaperSubViewpointLikeLogEN objPaperSubViewpointLikeLogEN, string strCondition)
{
 objPaperSubViewpointLikeLogEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPaperSubViewpointLikeLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPaperSubViewpointLikeLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PaperSubViewpointLikeLog Set ");
 
 if (objPaperSubViewpointLikeLogEN.IsUpdated(conPaperSubViewpointLikeLog.SubViewpointId))
 {
 sbSQL.AppendFormat(" SubViewpointId = {0},", objPaperSubViewpointLikeLogEN.SubViewpointId); //子观点Id
 }
 
 if (objPaperSubViewpointLikeLogEN.IsUpdated(conPaperSubViewpointLikeLog.UpdDate))
 {
 if (objPaperSubViewpointLikeLogEN.UpdDate !=  null)
 {
 var strUpdDate = objPaperSubViewpointLikeLogEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objPaperSubViewpointLikeLogEN.IsUpdated(conPaperSubViewpointLikeLog.UpdUser))
 {
 if (objPaperSubViewpointLikeLogEN.UpdUser !=  null)
 {
 var strUpdUser = objPaperSubViewpointLikeLogEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objPaperSubViewpointLikeLogEN.IsUpdated(conPaperSubViewpointLikeLog.Memo))
 {
 if (objPaperSubViewpointLikeLogEN.Memo !=  null)
 {
 var strMemo = objPaperSubViewpointLikeLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
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
 /// <param name = "objPaperSubViewpointLikeLogEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsPaperSubViewpointLikeLogEN objPaperSubViewpointLikeLogEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objPaperSubViewpointLikeLogEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPaperSubViewpointLikeLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPaperSubViewpointLikeLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PaperSubViewpointLikeLog Set ");
 
 if (objPaperSubViewpointLikeLogEN.IsUpdated(conPaperSubViewpointLikeLog.SubViewpointId))
 {
 sbSQL.AppendFormat(" SubViewpointId = {0},", objPaperSubViewpointLikeLogEN.SubViewpointId); //子观点Id
 }
 
 if (objPaperSubViewpointLikeLogEN.IsUpdated(conPaperSubViewpointLikeLog.UpdDate))
 {
 if (objPaperSubViewpointLikeLogEN.UpdDate !=  null)
 {
 var strUpdDate = objPaperSubViewpointLikeLogEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objPaperSubViewpointLikeLogEN.IsUpdated(conPaperSubViewpointLikeLog.UpdUser))
 {
 if (objPaperSubViewpointLikeLogEN.UpdUser !=  null)
 {
 var strUpdUser = objPaperSubViewpointLikeLogEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objPaperSubViewpointLikeLogEN.IsUpdated(conPaperSubViewpointLikeLog.Memo))
 {
 if (objPaperSubViewpointLikeLogEN.Memo !=  null)
 {
 var strMemo = objPaperSubViewpointLikeLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
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
 /// <param name = "objPaperSubViewpointLikeLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPaperSubViewpointLikeLogEN objPaperSubViewpointLikeLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objPaperSubViewpointLikeLogEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPaperSubViewpointLikeLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPaperSubViewpointLikeLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PaperSubViewpointLikeLog Set ");
 
 if (objPaperSubViewpointLikeLogEN.IsUpdated(conPaperSubViewpointLikeLog.SubViewpointId))
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperSubViewpointLikeLogEN.SubViewpointId, conPaperSubViewpointLikeLog.SubViewpointId); //子观点Id
 }
 
 if (objPaperSubViewpointLikeLogEN.IsUpdated(conPaperSubViewpointLikeLog.UpdDate))
 {
 if (objPaperSubViewpointLikeLogEN.UpdDate !=  null)
 {
 var strUpdDate = objPaperSubViewpointLikeLogEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conPaperSubViewpointLikeLog.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpointLikeLog.UpdDate); //修改日期
 }
 }
 
 if (objPaperSubViewpointLikeLogEN.IsUpdated(conPaperSubViewpointLikeLog.UpdUser))
 {
 if (objPaperSubViewpointLikeLogEN.UpdUser !=  null)
 {
 var strUpdUser = objPaperSubViewpointLikeLogEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conPaperSubViewpointLikeLog.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpointLikeLog.UpdUser); //修改人
 }
 }
 
 if (objPaperSubViewpointLikeLogEN.IsUpdated(conPaperSubViewpointLikeLog.Memo))
 {
 if (objPaperSubViewpointLikeLogEN.Memo !=  null)
 {
 var strMemo = objPaperSubViewpointLikeLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPaperSubViewpointLikeLog.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperSubViewpointLikeLog.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PaperSubViewpointLikeLogId = {0}", objPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId); 
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
 /// <param name = "lngPaperSubViewpointLikeLogId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngPaperSubViewpointLikeLogId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngPaperSubViewpointLikeLogId,
};
 objSQL.ExecSP("PaperSubViewpointLikeLog_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngPaperSubViewpointLikeLogId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngPaperSubViewpointLikeLogId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
//删除PaperSubViewpointLikeLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PaperSubViewpointLikeLog where PaperSubViewpointLikeLogId = " + ""+ lngPaperSubViewpointLikeLogId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelPaperSubViewpointLikeLog(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
else strKeyList +=  "," + "" + lstKey[i].ToString() + "";
}
strSQL = "";
//删除PaperSubViewpointLikeLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PaperSubViewpointLikeLog where PaperSubViewpointLikeLogId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngPaperSubViewpointLikeLogId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngPaperSubViewpointLikeLogId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
//删除PaperSubViewpointLikeLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PaperSubViewpointLikeLog where PaperSubViewpointLikeLogId = " + ""+ lngPaperSubViewpointLikeLogId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelPaperSubViewpointLikeLog(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsPaperSubViewpointLikeLogDA: DelPaperSubViewpointLikeLog)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PaperSubViewpointLikeLog where " + strCondition ;
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
public bool DelPaperSubViewpointLikeLogWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsPaperSubViewpointLikeLogDA: DelPaperSubViewpointLikeLogWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PaperSubViewpointLikeLog where " + strCondition ;
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
 /// <param name = "objPaperSubViewpointLikeLogENS">源对象</param>
 /// <param name = "objPaperSubViewpointLikeLogENT">目标对象</param>
public void CopyTo(clsPaperSubViewpointLikeLogEN objPaperSubViewpointLikeLogENS, clsPaperSubViewpointLikeLogEN objPaperSubViewpointLikeLogENT)
{
objPaperSubViewpointLikeLogENT.PaperSubViewpointLikeLogId = objPaperSubViewpointLikeLogENS.PaperSubViewpointLikeLogId; //点赞Id
objPaperSubViewpointLikeLogENT.SubViewpointId = objPaperSubViewpointLikeLogENS.SubViewpointId; //子观点Id
objPaperSubViewpointLikeLogENT.UpdDate = objPaperSubViewpointLikeLogENS.UpdDate; //修改日期
objPaperSubViewpointLikeLogENT.UpdUser = objPaperSubViewpointLikeLogENS.UpdUser; //修改人
objPaperSubViewpointLikeLogENT.Memo = objPaperSubViewpointLikeLogENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsPaperSubViewpointLikeLogEN objPaperSubViewpointLikeLogEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objPaperSubViewpointLikeLogEN.SubViewpointId, conPaperSubViewpointLikeLog.SubViewpointId);
//检查字段长度
clsCheckSql.CheckFieldLen(objPaperSubViewpointLikeLogEN.UpdDate, 20, conPaperSubViewpointLikeLog.UpdDate);
clsCheckSql.CheckFieldLen(objPaperSubViewpointLikeLogEN.UpdUser, 20, conPaperSubViewpointLikeLog.UpdUser);
clsCheckSql.CheckFieldLen(objPaperSubViewpointLikeLogEN.Memo, 1000, conPaperSubViewpointLikeLog.Memo);
//检查字段外键固定长度
 objPaperSubViewpointLikeLogEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsPaperSubViewpointLikeLogEN objPaperSubViewpointLikeLogEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPaperSubViewpointLikeLogEN.UpdDate, 20, conPaperSubViewpointLikeLog.UpdDate);
clsCheckSql.CheckFieldLen(objPaperSubViewpointLikeLogEN.UpdUser, 20, conPaperSubViewpointLikeLog.UpdUser);
clsCheckSql.CheckFieldLen(objPaperSubViewpointLikeLogEN.Memo, 1000, conPaperSubViewpointLikeLog.Memo);
//检查外键字段长度
 objPaperSubViewpointLikeLogEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsPaperSubViewpointLikeLogEN objPaperSubViewpointLikeLogEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPaperSubViewpointLikeLogEN.UpdDate, 20, conPaperSubViewpointLikeLog.UpdDate);
clsCheckSql.CheckFieldLen(objPaperSubViewpointLikeLogEN.UpdUser, 20, conPaperSubViewpointLikeLog.UpdUser);
clsCheckSql.CheckFieldLen(objPaperSubViewpointLikeLogEN.Memo, 1000, conPaperSubViewpointLikeLog.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objPaperSubViewpointLikeLogEN.UpdDate, conPaperSubViewpointLikeLog.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objPaperSubViewpointLikeLogEN.UpdUser, conPaperSubViewpointLikeLog.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objPaperSubViewpointLikeLogEN.Memo, conPaperSubViewpointLikeLog.Memo);
//检查外键字段长度
 objPaperSubViewpointLikeLogEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--PaperSubViewpointLikeLog(子观点点赞表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPaperSubViewpointLikeLogEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsPaperSubViewpointLikeLogEN objPaperSubViewpointLikeLogEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PaperSubViewpointLikeLogId = '{0}'", objPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId);
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
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
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
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
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
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPaperSubViewpointLikeLogEN._CurrTabName);
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
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPaperSubViewpointLikeLogEN._CurrTabName, strCondition);
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
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
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
 objSQL = clsPaperSubViewpointLikeLogDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}