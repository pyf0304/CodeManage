
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_PaperStuBatchQuesRela_TotalDA
 表名:cc_PaperStuBatchQuesRela_Total(01120243)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:27
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 /// 学生试卷完成汇总(cc_PaperStuBatchQuesRela_Total)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clscc_PaperStuBatchQuesRela_TotalDA : clsCommBase4DA
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
 return clscc_PaperStuBatchQuesRela_TotalEN._CurrTabName;
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
if (string.IsNullOrEmpty(clscc_PaperStuBatchQuesRela_TotalEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_PaperStuBatchQuesRela_TotalEN._ConnectString);
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
 if (string.IsNullOrEmpty(clscc_PaperStuBatchQuesRela_TotalEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clscc_PaperStuBatchQuesRela_TotalEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clscc_PaperStuBatchQuesRela_TotalDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
strSQL = "Select * from cc_PaperStuBatchQuesRela_Total where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_cc_PaperStuBatchQuesRela_Total(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clscc_PaperStuBatchQuesRela_TotalDA: GetDataTable_cc_PaperStuBatchQuesRela_Total)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
strSQL = "Select * from cc_PaperStuBatchQuesRela_Total where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clscc_PaperStuBatchQuesRela_TotalDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clscc_PaperStuBatchQuesRela_TotalDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
strSQL = "Select * from cc_PaperStuBatchQuesRela_Total where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clscc_PaperStuBatchQuesRela_TotalDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clscc_PaperStuBatchQuesRela_TotalDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_PaperStuBatchQuesRela_Total where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_PaperStuBatchQuesRela_Total where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clscc_PaperStuBatchQuesRela_TotalDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from cc_PaperStuBatchQuesRela_Total where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clscc_PaperStuBatchQuesRela_TotalDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_PaperStuBatchQuesRela_Total.* from cc_PaperStuBatchQuesRela_Total Left Join {1} on {2} where {3} and cc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal not in (Select top {5} cc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal from cc_PaperStuBatchQuesRela_Total Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_PaperStuBatchQuesRela_Total where {1} and IdPaperStuBatchQuesRelaTotal not in (Select top {2} IdPaperStuBatchQuesRelaTotal from cc_PaperStuBatchQuesRela_Total where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_PaperStuBatchQuesRela_Total where {1} and IdPaperStuBatchQuesRelaTotal not in (Select top {3} IdPaperStuBatchQuesRelaTotal from cc_PaperStuBatchQuesRela_Total where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clscc_PaperStuBatchQuesRela_TotalDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_PaperStuBatchQuesRela_Total.* from cc_PaperStuBatchQuesRela_Total Left Join {1} on {2} where {3} and cc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal not in (Select top {5} cc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal from cc_PaperStuBatchQuesRela_Total Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_PaperStuBatchQuesRela_Total where {1} and IdPaperStuBatchQuesRelaTotal not in (Select top {2} IdPaperStuBatchQuesRelaTotal from cc_PaperStuBatchQuesRela_Total where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_PaperStuBatchQuesRela_Total where {1} and IdPaperStuBatchQuesRelaTotal not in (Select top {3} IdPaperStuBatchQuesRelaTotal from cc_PaperStuBatchQuesRela_Total where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clscc_PaperStuBatchQuesRela_TotalEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clscc_PaperStuBatchQuesRela_TotalDA:GetObjLst)", objException.Message));
}
List<clscc_PaperStuBatchQuesRela_TotalEN> arrObjLst = new List<clscc_PaperStuBatchQuesRela_TotalEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
strSQL = "Select * from cc_PaperStuBatchQuesRela_Total where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN = new clscc_PaperStuBatchQuesRela_TotalEN();
try
{
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal = TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal].ToString().Trim()); //学生试卷完成汇总流水号
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch = objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_PaperStuBatchQuesRela_TotalEN.QuesNum = TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNum].ToString().Trim()); //题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook].ToString().Trim()); //查看题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark].ToString().Trim()); //打分题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish].ToString().Trim()); //未完成题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue].ToString().Trim()); //逾期题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave].ToString().Trim()); //保存题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack].ToString().Trim()); //退回题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit].ToString().Trim()); //提交题目数
objcc_PaperStuBatchQuesRela_TotalEN.TotalScore = objRow[concc_PaperStuBatchQuesRela_Total.TotalScore] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_PaperStuBatchQuesRela_Total.TotalScore].ToString().Trim()); //总得分
objcc_PaperStuBatchQuesRela_TotalEN.TotalScores = objRow[concc_PaperStuBatchQuesRela_Total.TotalScores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_PaperStuBatchQuesRela_Total.TotalScores].ToString().Trim()); //总分值
objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear = objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear].ToString().Trim(); //学年
objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm = objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm].ToString().Trim(); //学期
objcc_PaperStuBatchQuesRela_TotalEN.UpdDate = objRow[concc_PaperStuBatchQuesRela_Total.UpdDate].ToString().Trim(); //修改日期
objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId = objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId].ToString().Trim(); //修改用户Id
objcc_PaperStuBatchQuesRela_TotalEN.Memo = objRow[concc_PaperStuBatchQuesRela_Total.Memo] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_PaperStuBatchQuesRela_TotalDA: GetObjLst)", objException.Message));
}
objcc_PaperStuBatchQuesRela_TotalEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_PaperStuBatchQuesRela_TotalEN);
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
public List<clscc_PaperStuBatchQuesRela_TotalEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clscc_PaperStuBatchQuesRela_TotalDA:GetObjLstByTabName)", objException.Message));
}
List<clscc_PaperStuBatchQuesRela_TotalEN> arrObjLst = new List<clscc_PaperStuBatchQuesRela_TotalEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN = new clscc_PaperStuBatchQuesRela_TotalEN();
try
{
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal = TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal].ToString().Trim()); //学生试卷完成汇总流水号
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch = objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_PaperStuBatchQuesRela_TotalEN.QuesNum = TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNum].ToString().Trim()); //题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook].ToString().Trim()); //查看题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark].ToString().Trim()); //打分题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish].ToString().Trim()); //未完成题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue].ToString().Trim()); //逾期题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave].ToString().Trim()); //保存题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack].ToString().Trim()); //退回题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit].ToString().Trim()); //提交题目数
objcc_PaperStuBatchQuesRela_TotalEN.TotalScore = objRow[concc_PaperStuBatchQuesRela_Total.TotalScore] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_PaperStuBatchQuesRela_Total.TotalScore].ToString().Trim()); //总得分
objcc_PaperStuBatchQuesRela_TotalEN.TotalScores = objRow[concc_PaperStuBatchQuesRela_Total.TotalScores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_PaperStuBatchQuesRela_Total.TotalScores].ToString().Trim()); //总分值
objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear = objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear].ToString().Trim(); //学年
objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm = objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm].ToString().Trim(); //学期
objcc_PaperStuBatchQuesRela_TotalEN.UpdDate = objRow[concc_PaperStuBatchQuesRela_Total.UpdDate].ToString().Trim(); //修改日期
objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId = objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId].ToString().Trim(); //修改用户Id
objcc_PaperStuBatchQuesRela_TotalEN.Memo = objRow[concc_PaperStuBatchQuesRela_Total.Memo] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_PaperStuBatchQuesRela_TotalDA: GetObjLst)", objException.Message));
}
objcc_PaperStuBatchQuesRela_TotalEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_PaperStuBatchQuesRela_TotalEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getcc_PaperStuBatchQuesRela_Total(ref clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
strSQL = "Select * from cc_PaperStuBatchQuesRela_Total where IdPaperStuBatchQuesRelaTotal = " + ""+ objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal = TransNullToInt(objDT.Rows[0][concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal].ToString().Trim()); //学生试卷完成汇总流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch = objDT.Rows[0][concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号(字段类型:char,字段长度:10,是否可空:False)
 objcc_PaperStuBatchQuesRela_TotalEN.QuesNum = TransNullToInt(objDT.Rows[0][concc_PaperStuBatchQuesRela_Total.QuesNum].ToString().Trim()); //题目数(字段类型:int,字段长度:4,是否可空:False)
 objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook = TransNullToInt(objDT.Rows[0][concc_PaperStuBatchQuesRela_Total.QuesNumLook].ToString().Trim()); //查看题目数(字段类型:int,字段长度:4,是否可空:True)
 objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark = TransNullToInt(objDT.Rows[0][concc_PaperStuBatchQuesRela_Total.QuesNumMark].ToString().Trim()); //打分题目数(字段类型:int,字段长度:4,是否可空:True)
 objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish = TransNullToInt(objDT.Rows[0][concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish].ToString().Trim()); //未完成题目数(字段类型:int,字段长度:4,是否可空:True)
 objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue = TransNullToInt(objDT.Rows[0][concc_PaperStuBatchQuesRela_Total.QuesNumOverdue].ToString().Trim()); //逾期题目数(字段类型:int,字段长度:4,是否可空:True)
 objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave = TransNullToInt(objDT.Rows[0][concc_PaperStuBatchQuesRela_Total.QuesNumSave].ToString().Trim()); //保存题目数(字段类型:int,字段长度:4,是否可空:True)
 objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack = TransNullToInt(objDT.Rows[0][concc_PaperStuBatchQuesRela_Total.QuesNumSendBack].ToString().Trim()); //退回题目数(字段类型:int,字段长度:4,是否可空:True)
 objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit = TransNullToInt(objDT.Rows[0][concc_PaperStuBatchQuesRela_Total.QuesNumSubmit].ToString().Trim()); //提交题目数(字段类型:int,字段长度:4,是否可空:True)
 objcc_PaperStuBatchQuesRela_TotalEN.TotalScore = TransNullToDouble(objDT.Rows[0][concc_PaperStuBatchQuesRela_Total.TotalScore].ToString().Trim()); //总得分(字段类型:decimal,字段长度:10,是否可空:False)
 objcc_PaperStuBatchQuesRela_TotalEN.TotalScores = TransNullToDouble(objDT.Rows[0][concc_PaperStuBatchQuesRela_Total.TotalScores].ToString().Trim()); //总分值(字段类型:decimal,字段长度:10,是否可空:True)
 objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear = objDT.Rows[0][concc_PaperStuBatchQuesRela_Total.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm = objDT.Rows[0][concc_PaperStuBatchQuesRela_Total.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objcc_PaperStuBatchQuesRela_TotalEN.UpdDate = objDT.Rows[0][concc_PaperStuBatchQuesRela_Total.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId = objDT.Rows[0][concc_PaperStuBatchQuesRela_Total.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_PaperStuBatchQuesRela_TotalEN.Memo = objDT.Rows[0][concc_PaperStuBatchQuesRela_Total.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clscc_PaperStuBatchQuesRela_TotalDA: Getcc_PaperStuBatchQuesRela_Total)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdPaperStuBatchQuesRelaTotal">表关键字</param>
 /// <returns>表对象</returns>
public clscc_PaperStuBatchQuesRela_TotalEN GetObjByIdPaperStuBatchQuesRelaTotal(long lngIdPaperStuBatchQuesRelaTotal)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
strSQL = "Select * from cc_PaperStuBatchQuesRela_Total where IdPaperStuBatchQuesRelaTotal = " + ""+ lngIdPaperStuBatchQuesRelaTotal+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN = new clscc_PaperStuBatchQuesRela_TotalEN();
try
{
 objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal = Int32.Parse(objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal].ToString().Trim()); //学生试卷完成汇总流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch = objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号(字段类型:char,字段长度:10,是否可空:False)
 objcc_PaperStuBatchQuesRela_TotalEN.QuesNum = Int32.Parse(objRow[concc_PaperStuBatchQuesRela_Total.QuesNum].ToString().Trim()); //题目数(字段类型:int,字段长度:4,是否可空:False)
 objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook].ToString().Trim()); //查看题目数(字段类型:int,字段长度:4,是否可空:True)
 objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark].ToString().Trim()); //打分题目数(字段类型:int,字段长度:4,是否可空:True)
 objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish].ToString().Trim()); //未完成题目数(字段类型:int,字段长度:4,是否可空:True)
 objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue].ToString().Trim()); //逾期题目数(字段类型:int,字段长度:4,是否可空:True)
 objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave].ToString().Trim()); //保存题目数(字段类型:int,字段长度:4,是否可空:True)
 objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack].ToString().Trim()); //退回题目数(字段类型:int,字段长度:4,是否可空:True)
 objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit].ToString().Trim()); //提交题目数(字段类型:int,字段长度:4,是否可空:True)
 objcc_PaperStuBatchQuesRela_TotalEN.TotalScore = objRow[concc_PaperStuBatchQuesRela_Total.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela_Total.TotalScore].ToString().Trim()); //总得分(字段类型:decimal,字段长度:10,是否可空:False)
 objcc_PaperStuBatchQuesRela_TotalEN.TotalScores = objRow[concc_PaperStuBatchQuesRela_Total.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela_Total.TotalScores].ToString().Trim()); //总分值(字段类型:decimal,字段长度:10,是否可空:True)
 objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear = objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm = objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objcc_PaperStuBatchQuesRela_TotalEN.UpdDate = objRow[concc_PaperStuBatchQuesRela_Total.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId = objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_PaperStuBatchQuesRela_TotalEN.Memo = objRow[concc_PaperStuBatchQuesRela_Total.Memo] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clscc_PaperStuBatchQuesRela_TotalDA: GetObjByIdPaperStuBatchQuesRelaTotal)", objException.Message));
}
return objcc_PaperStuBatchQuesRela_TotalEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clscc_PaperStuBatchQuesRela_TotalEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clscc_PaperStuBatchQuesRela_TotalDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
strSQL = "Select * from cc_PaperStuBatchQuesRela_Total where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN = new clscc_PaperStuBatchQuesRela_TotalEN()
{
IdPaperStuBatchQuesRelaTotal = TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal].ToString().Trim()), //学生试卷完成汇总流水号
IdPaperStuBatch = objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch].ToString().Trim(), //学生试卷批次流水号
QuesNum = TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNum].ToString().Trim()), //题目数
QuesNumLook = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook].ToString().Trim()), //查看题目数
QuesNumMark = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark].ToString().Trim()), //打分题目数
QuesNumNoFinish = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish].ToString().Trim()), //未完成题目数
QuesNumOverdue = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue].ToString().Trim()), //逾期题目数
QuesNumSave = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave].ToString().Trim()), //保存题目数
QuesNumSendBack = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack].ToString().Trim()), //退回题目数
QuesNumSubmit = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit].ToString().Trim()), //提交题目数
TotalScore = objRow[concc_PaperStuBatchQuesRela_Total.TotalScore] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_PaperStuBatchQuesRela_Total.TotalScore].ToString().Trim()), //总得分
TotalScores = objRow[concc_PaperStuBatchQuesRela_Total.TotalScores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_PaperStuBatchQuesRela_Total.TotalScores].ToString().Trim()), //总分值
SchoolYear = objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear].ToString().Trim(), //学年
SchoolTerm = objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm].ToString().Trim(), //学期
UpdDate = objRow[concc_PaperStuBatchQuesRela_Total.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[concc_PaperStuBatchQuesRela_Total.Memo] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.Memo].ToString().Trim() //备注
};
objcc_PaperStuBatchQuesRela_TotalEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_PaperStuBatchQuesRela_TotalEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clscc_PaperStuBatchQuesRela_TotalDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clscc_PaperStuBatchQuesRela_TotalEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN = new clscc_PaperStuBatchQuesRela_TotalEN();
try
{
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal = TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal].ToString().Trim()); //学生试卷完成汇总流水号
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch = objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_PaperStuBatchQuesRela_TotalEN.QuesNum = TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNum].ToString().Trim()); //题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook].ToString().Trim()); //查看题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark].ToString().Trim()); //打分题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish].ToString().Trim()); //未完成题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue].ToString().Trim()); //逾期题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave].ToString().Trim()); //保存题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack].ToString().Trim()); //退回题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit].ToString().Trim()); //提交题目数
objcc_PaperStuBatchQuesRela_TotalEN.TotalScore = objRow[concc_PaperStuBatchQuesRela_Total.TotalScore] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_PaperStuBatchQuesRela_Total.TotalScore].ToString().Trim()); //总得分
objcc_PaperStuBatchQuesRela_TotalEN.TotalScores = objRow[concc_PaperStuBatchQuesRela_Total.TotalScores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_PaperStuBatchQuesRela_Total.TotalScores].ToString().Trim()); //总分值
objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear = objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear].ToString().Trim(); //学年
objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm = objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm].ToString().Trim(); //学期
objcc_PaperStuBatchQuesRela_TotalEN.UpdDate = objRow[concc_PaperStuBatchQuesRela_Total.UpdDate].ToString().Trim(); //修改日期
objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId = objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId].ToString().Trim(); //修改用户Id
objcc_PaperStuBatchQuesRela_TotalEN.Memo = objRow[concc_PaperStuBatchQuesRela_Total.Memo] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clscc_PaperStuBatchQuesRela_TotalDA: GetObjByDataRowcc_PaperStuBatchQuesRela_Total)", objException.Message));
}
objcc_PaperStuBatchQuesRela_TotalEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_PaperStuBatchQuesRela_TotalEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clscc_PaperStuBatchQuesRela_TotalEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN = new clscc_PaperStuBatchQuesRela_TotalEN();
try
{
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal = TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal].ToString().Trim()); //学生试卷完成汇总流水号
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch = objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_PaperStuBatchQuesRela_TotalEN.QuesNum = TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNum].ToString().Trim()); //题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook].ToString().Trim()); //查看题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark].ToString().Trim()); //打分题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish].ToString().Trim()); //未完成题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue].ToString().Trim()); //逾期题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave].ToString().Trim()); //保存题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack].ToString().Trim()); //退回题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit].ToString().Trim()); //提交题目数
objcc_PaperStuBatchQuesRela_TotalEN.TotalScore = objRow[concc_PaperStuBatchQuesRela_Total.TotalScore] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_PaperStuBatchQuesRela_Total.TotalScore].ToString().Trim()); //总得分
objcc_PaperStuBatchQuesRela_TotalEN.TotalScores = objRow[concc_PaperStuBatchQuesRela_Total.TotalScores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_PaperStuBatchQuesRela_Total.TotalScores].ToString().Trim()); //总分值
objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear = objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear].ToString().Trim(); //学年
objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm = objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm].ToString().Trim(); //学期
objcc_PaperStuBatchQuesRela_TotalEN.UpdDate = objRow[concc_PaperStuBatchQuesRela_Total.UpdDate].ToString().Trim(); //修改日期
objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId = objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId].ToString().Trim(); //修改用户Id
objcc_PaperStuBatchQuesRela_TotalEN.Memo = objRow[concc_PaperStuBatchQuesRela_Total.Memo] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clscc_PaperStuBatchQuesRela_TotalDA: GetObjByDataRow)", objException.Message));
}
objcc_PaperStuBatchQuesRela_TotalEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_PaperStuBatchQuesRela_TotalEN;
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
objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_PaperStuBatchQuesRela_TotalEN._CurrTabName, concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal, 8, "");
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
objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_PaperStuBatchQuesRela_TotalEN._CurrTabName, concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal, 8, strPrefix);
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
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdPaperStuBatchQuesRelaTotal from cc_PaperStuBatchQuesRela_Total where " + strCondition;
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
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdPaperStuBatchQuesRelaTotal from cc_PaperStuBatchQuesRela_Total where " + strCondition;
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
 /// <param name = "lngIdPaperStuBatchQuesRelaTotal">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdPaperStuBatchQuesRelaTotal)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_PaperStuBatchQuesRela_Total", "IdPaperStuBatchQuesRelaTotal = " + ""+ lngIdPaperStuBatchQuesRelaTotal+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clscc_PaperStuBatchQuesRela_TotalDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_PaperStuBatchQuesRela_Total", strCondition))
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
objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("cc_PaperStuBatchQuesRela_Total");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN)
 {
 objcc_PaperStuBatchQuesRela_TotalEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_PaperStuBatchQuesRela_TotalEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_PaperStuBatchQuesRela_TotalEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
strSQL = "Select * from cc_PaperStuBatchQuesRela_Total where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_PaperStuBatchQuesRela_Total");
objRow = objDS.Tables["cc_PaperStuBatchQuesRela_Total"].NewRow();
 if (objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch !=  "")
 {
objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch] = objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch; //学生试卷批次流水号
 }
objRow[concc_PaperStuBatchQuesRela_Total.QuesNum] = objcc_PaperStuBatchQuesRela_TotalEN.QuesNum; //题目数
objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook] = objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook; //查看题目数
objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark] = objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark; //打分题目数
objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish] = objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish; //未完成题目数
objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue] = objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue; //逾期题目数
objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave] = objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave; //保存题目数
objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack] = objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack; //退回题目数
objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit] = objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit; //提交题目数
objRow[concc_PaperStuBatchQuesRela_Total.TotalScore] = objcc_PaperStuBatchQuesRela_TotalEN.TotalScore; //总得分
objRow[concc_PaperStuBatchQuesRela_Total.TotalScores] = objcc_PaperStuBatchQuesRela_TotalEN.TotalScores; //总分值
 if (objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear !=  "")
 {
objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear] = objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear; //学年
 }
 if (objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm !=  "")
 {
objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm] = objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm; //学期
 }
objRow[concc_PaperStuBatchQuesRela_Total.UpdDate] = objcc_PaperStuBatchQuesRela_TotalEN.UpdDate; //修改日期
 if (objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId !=  "")
 {
objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId] = objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId; //修改用户Id
 }
 if (objcc_PaperStuBatchQuesRela_TotalEN.Memo !=  "")
 {
objRow[concc_PaperStuBatchQuesRela_Total.Memo] = objcc_PaperStuBatchQuesRela_TotalEN.Memo; //备注
 }
objDS.Tables[clscc_PaperStuBatchQuesRela_TotalEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clscc_PaperStuBatchQuesRela_TotalEN._CurrTabName);
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
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN)
{
 objcc_PaperStuBatchQuesRela_TotalEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_PaperStuBatchQuesRela_TotalEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_PaperStuBatchQuesRela_TotalEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch);
 var strIdPaperStuBatch = objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPaperStuBatch + "'");
 }
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.QuesNum);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.QuesNum.ToString());
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.QuesNumLook);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.QuesNumMark);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.QuesNumOverdue);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.QuesNumSave);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.QuesNumSendBack);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.QuesNumSubmit);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.TotalScore !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.TotalScore);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.TotalScore.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.TotalScores !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.TotalScores);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.TotalScores.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.SchoolYear);
 var strSchoolYear = objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.SchoolTerm);
 var strSchoolTerm = objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.UpdDate);
 var strUpdDate = objcc_PaperStuBatchQuesRela_TotalEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.UpdUserId);
 var strUpdUserId = objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.Memo);
 var strMemo = objcc_PaperStuBatchQuesRela_TotalEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_PaperStuBatchQuesRela_Total");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN)
{
 objcc_PaperStuBatchQuesRela_TotalEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_PaperStuBatchQuesRela_TotalEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_PaperStuBatchQuesRela_TotalEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch);
 var strIdPaperStuBatch = objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPaperStuBatch + "'");
 }
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.QuesNum);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.QuesNum.ToString());
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.QuesNumLook);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.QuesNumMark);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.QuesNumOverdue);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.QuesNumSave);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.QuesNumSendBack);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.QuesNumSubmit);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.TotalScore !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.TotalScore);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.TotalScore.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.TotalScores !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.TotalScores);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.TotalScores.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.SchoolYear);
 var strSchoolYear = objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.SchoolTerm);
 var strSchoolTerm = objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.UpdDate);
 var strUpdDate = objcc_PaperStuBatchQuesRela_TotalEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.UpdUserId);
 var strUpdUserId = objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.Memo);
 var strMemo = objcc_PaperStuBatchQuesRela_TotalEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_PaperStuBatchQuesRela_Total");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcc_PaperStuBatchQuesRela_TotalEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_PaperStuBatchQuesRela_TotalEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_PaperStuBatchQuesRela_TotalEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch);
 var strIdPaperStuBatch = objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPaperStuBatch + "'");
 }
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.QuesNum);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.QuesNum.ToString());
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.QuesNumLook);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.QuesNumMark);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.QuesNumOverdue);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.QuesNumSave);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.QuesNumSendBack);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.QuesNumSubmit);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.TotalScore !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.TotalScore);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.TotalScore.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.TotalScores !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.TotalScores);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.TotalScores.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.SchoolYear);
 var strSchoolYear = objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.SchoolTerm);
 var strSchoolTerm = objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.UpdDate);
 var strUpdDate = objcc_PaperStuBatchQuesRela_TotalEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.UpdUserId);
 var strUpdUserId = objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.Memo);
 var strMemo = objcc_PaperStuBatchQuesRela_TotalEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_PaperStuBatchQuesRela_Total");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcc_PaperStuBatchQuesRela_TotalEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_PaperStuBatchQuesRela_TotalEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_PaperStuBatchQuesRela_TotalEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch);
 var strIdPaperStuBatch = objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPaperStuBatch + "'");
 }
 
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.QuesNum);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.QuesNum.ToString());
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.QuesNumLook);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.QuesNumMark);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.QuesNumOverdue);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.QuesNumSave);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.QuesNumSendBack);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.QuesNumSubmit);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.TotalScore !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.TotalScore);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.TotalScore.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.TotalScores !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.TotalScores);
 arrValueListForInsert.Add(objcc_PaperStuBatchQuesRela_TotalEN.TotalScores.ToString());
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.SchoolYear);
 var strSchoolYear = objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.SchoolTerm);
 var strSchoolTerm = objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.UpdDate);
 var strUpdDate = objcc_PaperStuBatchQuesRela_TotalEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.UpdUserId);
 var strUpdUserId = objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_PaperStuBatchQuesRela_Total.Memo);
 var strMemo = objcc_PaperStuBatchQuesRela_TotalEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_PaperStuBatchQuesRela_Total");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewcc_PaperStuBatchQuesRela_Totals(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
strSQL = "Select * from cc_PaperStuBatchQuesRela_Total where IdPaperStuBatchQuesRelaTotal = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_PaperStuBatchQuesRela_Total");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngIdPaperStuBatchQuesRelaTotal = TransNullToInt(oRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal].ToString().Trim());
if (IsExist(lngIdPaperStuBatchQuesRelaTotal))
{
 string strResult = "关键字变量值为:" + string.Format("IdPaperStuBatchQuesRelaTotal = {0}", lngIdPaperStuBatchQuesRelaTotal) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clscc_PaperStuBatchQuesRela_TotalEN._CurrTabName ].NewRow();
objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch] = oRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objRow[concc_PaperStuBatchQuesRela_Total.QuesNum] = oRow[concc_PaperStuBatchQuesRela_Total.QuesNum].ToString().Trim(); //题目数
objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook] = oRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook].ToString().Trim(); //查看题目数
objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark] = oRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark].ToString().Trim(); //打分题目数
objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish] = oRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish].ToString().Trim(); //未完成题目数
objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue] = oRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue].ToString().Trim(); //逾期题目数
objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave] = oRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave].ToString().Trim(); //保存题目数
objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack] = oRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack].ToString().Trim(); //退回题目数
objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit] = oRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit].ToString().Trim(); //提交题目数
objRow[concc_PaperStuBatchQuesRela_Total.TotalScore] = oRow[concc_PaperStuBatchQuesRela_Total.TotalScore].ToString().Trim(); //总得分
objRow[concc_PaperStuBatchQuesRela_Total.TotalScores] = oRow[concc_PaperStuBatchQuesRela_Total.TotalScores].ToString().Trim(); //总分值
objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear] = oRow[concc_PaperStuBatchQuesRela_Total.SchoolYear].ToString().Trim(); //学年
objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm] = oRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm].ToString().Trim(); //学期
objRow[concc_PaperStuBatchQuesRela_Total.UpdDate] = oRow[concc_PaperStuBatchQuesRela_Total.UpdDate].ToString().Trim(); //修改日期
objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId] = oRow[concc_PaperStuBatchQuesRela_Total.UpdUserId].ToString().Trim(); //修改用户Id
objRow[concc_PaperStuBatchQuesRela_Total.Memo] = oRow[concc_PaperStuBatchQuesRela_Total.Memo].ToString().Trim(); //备注
 objDS.Tables[clscc_PaperStuBatchQuesRela_TotalEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clscc_PaperStuBatchQuesRela_TotalEN._CurrTabName);
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
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN)
{
 objcc_PaperStuBatchQuesRela_TotalEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_PaperStuBatchQuesRela_TotalEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_PaperStuBatchQuesRela_TotalEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
strSQL = "Select * from cc_PaperStuBatchQuesRela_Total where IdPaperStuBatchQuesRelaTotal = " + ""+ objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clscc_PaperStuBatchQuesRela_TotalEN._CurrTabName);
if (objDS.Tables[clscc_PaperStuBatchQuesRela_TotalEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdPaperStuBatchQuesRelaTotal = " + ""+ objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal+"");
return false;
}
objRow = objDS.Tables[clscc_PaperStuBatchQuesRela_TotalEN._CurrTabName].Rows[0];
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch))
 {
objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch] = objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch; //学生试卷批次流水号
 }
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNum))
 {
objRow[concc_PaperStuBatchQuesRela_Total.QuesNum] = objcc_PaperStuBatchQuesRela_TotalEN.QuesNum; //题目数
 }
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumLook))
 {
objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook] = objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook; //查看题目数
 }
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumMark))
 {
objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark] = objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark; //打分题目数
 }
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish))
 {
objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish] = objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish; //未完成题目数
 }
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumOverdue))
 {
objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue] = objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue; //逾期题目数
 }
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumSave))
 {
objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave] = objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave; //保存题目数
 }
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumSendBack))
 {
objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack] = objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack; //退回题目数
 }
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumSubmit))
 {
objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit] = objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit; //提交题目数
 }
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.TotalScore))
 {
objRow[concc_PaperStuBatchQuesRela_Total.TotalScore] = objcc_PaperStuBatchQuesRela_TotalEN.TotalScore; //总得分
 }
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.TotalScores))
 {
objRow[concc_PaperStuBatchQuesRela_Total.TotalScores] = objcc_PaperStuBatchQuesRela_TotalEN.TotalScores; //总分值
 }
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.SchoolYear))
 {
objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear] = objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear; //学年
 }
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.SchoolTerm))
 {
objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm] = objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm; //学期
 }
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.UpdDate))
 {
objRow[concc_PaperStuBatchQuesRela_Total.UpdDate] = objcc_PaperStuBatchQuesRela_TotalEN.UpdDate; //修改日期
 }
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.UpdUserId))
 {
objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId] = objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId; //修改用户Id
 }
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.Memo))
 {
objRow[concc_PaperStuBatchQuesRela_Total.Memo] = objcc_PaperStuBatchQuesRela_TotalEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clscc_PaperStuBatchQuesRela_TotalEN._CurrTabName);
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
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN)
{
 objcc_PaperStuBatchQuesRela_TotalEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_PaperStuBatchQuesRela_TotalEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_PaperStuBatchQuesRela_TotalEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update cc_PaperStuBatchQuesRela_Total Set ");
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch !=  null)
 {
 var strIdPaperStuBatch = objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdPaperStuBatch, concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch); //学生试卷批次流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch); //学生试卷批次流水号
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.QuesNum, concc_PaperStuBatchQuesRela_Total.QuesNum); //题目数
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumLook))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook, concc_PaperStuBatchQuesRela_Total.QuesNumLook); //查看题目数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.QuesNumLook); //查看题目数
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumMark))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark, concc_PaperStuBatchQuesRela_Total.QuesNumMark); //打分题目数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.QuesNumMark); //打分题目数
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish, concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish); //未完成题目数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish); //未完成题目数
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumOverdue))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue, concc_PaperStuBatchQuesRela_Total.QuesNumOverdue); //逾期题目数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.QuesNumOverdue); //逾期题目数
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumSave))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave, concc_PaperStuBatchQuesRela_Total.QuesNumSave); //保存题目数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.QuesNumSave); //保存题目数
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumSendBack))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack, concc_PaperStuBatchQuesRela_Total.QuesNumSendBack); //退回题目数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.QuesNumSendBack); //退回题目数
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumSubmit))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit, concc_PaperStuBatchQuesRela_Total.QuesNumSubmit); //提交题目数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.QuesNumSubmit); //提交题目数
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.TotalScore))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.TotalScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.TotalScore, concc_PaperStuBatchQuesRela_Total.TotalScore); //总得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.TotalScore); //总得分
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.TotalScores))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.TotalScores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.TotalScores, concc_PaperStuBatchQuesRela_Total.TotalScores); //总分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.TotalScores); //总分值
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.SchoolYear))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear !=  null)
 {
 var strSchoolYear = objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolYear, concc_PaperStuBatchQuesRela_Total.SchoolYear); //学年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.SchoolYear); //学年
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.SchoolTerm))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTerm, concc_PaperStuBatchQuesRela_Total.SchoolTerm); //学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.SchoolTerm); //学期
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.UpdDate))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_PaperStuBatchQuesRela_TotalEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_PaperStuBatchQuesRela_Total.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.UpdDate); //修改日期
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.UpdUserId))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, concc_PaperStuBatchQuesRela_Total.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.UpdUserId); //修改用户Id
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.Memo))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.Memo !=  null)
 {
 var strMemo = objcc_PaperStuBatchQuesRela_TotalEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_PaperStuBatchQuesRela_Total.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdPaperStuBatchQuesRelaTotal = {0}", objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal); 
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
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN, string strCondition)
{
 objcc_PaperStuBatchQuesRela_TotalEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_PaperStuBatchQuesRela_TotalEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_PaperStuBatchQuesRela_TotalEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_PaperStuBatchQuesRela_Total Set ");
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch !=  null)
 {
 var strIdPaperStuBatch = objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdPaperStuBatch = '{0}',", strIdPaperStuBatch); //学生试卷批次流水号
 }
 else
 {
 sbSQL.Append(" IdPaperStuBatch = null,"); //学生试卷批次流水号
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNum))
 {
 sbSQL.AppendFormat(" QuesNum = {0},", objcc_PaperStuBatchQuesRela_TotalEN.QuesNum); //题目数
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumLook))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook, concc_PaperStuBatchQuesRela_Total.QuesNumLook); //查看题目数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.QuesNumLook); //查看题目数
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumMark))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark, concc_PaperStuBatchQuesRela_Total.QuesNumMark); //打分题目数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.QuesNumMark); //打分题目数
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish, concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish); //未完成题目数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish); //未完成题目数
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumOverdue))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue, concc_PaperStuBatchQuesRela_Total.QuesNumOverdue); //逾期题目数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.QuesNumOverdue); //逾期题目数
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumSave))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave, concc_PaperStuBatchQuesRela_Total.QuesNumSave); //保存题目数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.QuesNumSave); //保存题目数
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumSendBack))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack, concc_PaperStuBatchQuesRela_Total.QuesNumSendBack); //退回题目数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.QuesNumSendBack); //退回题目数
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumSubmit))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit, concc_PaperStuBatchQuesRela_Total.QuesNumSubmit); //提交题目数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.QuesNumSubmit); //提交题目数
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.TotalScore))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.TotalScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.TotalScore, concc_PaperStuBatchQuesRela_Total.TotalScore); //总得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.TotalScore); //总得分
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.TotalScores))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.TotalScores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.TotalScores, concc_PaperStuBatchQuesRela_Total.TotalScores); //总分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.TotalScores); //总分值
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.SchoolYear))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear !=  null)
 {
 var strSchoolYear = objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolYear = '{0}',", strSchoolYear); //学年
 }
 else
 {
 sbSQL.Append(" SchoolYear = null,"); //学年
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.SchoolTerm))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTerm = '{0}',", strSchoolTerm); //学期
 }
 else
 {
 sbSQL.Append(" SchoolTerm = null,"); //学期
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.UpdDate))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_PaperStuBatchQuesRela_TotalEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.UpdUserId))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.Memo))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.Memo !=  null)
 {
 var strMemo = objcc_PaperStuBatchQuesRela_TotalEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcc_PaperStuBatchQuesRela_TotalEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_PaperStuBatchQuesRela_TotalEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_PaperStuBatchQuesRela_TotalEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_PaperStuBatchQuesRela_Total Set ");
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch !=  null)
 {
 var strIdPaperStuBatch = objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdPaperStuBatch = '{0}',", strIdPaperStuBatch); //学生试卷批次流水号
 }
 else
 {
 sbSQL.Append(" IdPaperStuBatch = null,"); //学生试卷批次流水号
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNum))
 {
 sbSQL.AppendFormat(" QuesNum = {0},", objcc_PaperStuBatchQuesRela_TotalEN.QuesNum); //题目数
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumLook))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook, concc_PaperStuBatchQuesRela_Total.QuesNumLook); //查看题目数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.QuesNumLook); //查看题目数
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumMark))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark, concc_PaperStuBatchQuesRela_Total.QuesNumMark); //打分题目数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.QuesNumMark); //打分题目数
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish, concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish); //未完成题目数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish); //未完成题目数
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumOverdue))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue, concc_PaperStuBatchQuesRela_Total.QuesNumOverdue); //逾期题目数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.QuesNumOverdue); //逾期题目数
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumSave))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave, concc_PaperStuBatchQuesRela_Total.QuesNumSave); //保存题目数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.QuesNumSave); //保存题目数
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumSendBack))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack, concc_PaperStuBatchQuesRela_Total.QuesNumSendBack); //退回题目数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.QuesNumSendBack); //退回题目数
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumSubmit))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit, concc_PaperStuBatchQuesRela_Total.QuesNumSubmit); //提交题目数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.QuesNumSubmit); //提交题目数
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.TotalScore))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.TotalScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.TotalScore, concc_PaperStuBatchQuesRela_Total.TotalScore); //总得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.TotalScore); //总得分
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.TotalScores))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.TotalScores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.TotalScores, concc_PaperStuBatchQuesRela_Total.TotalScores); //总分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.TotalScores); //总分值
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.SchoolYear))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear !=  null)
 {
 var strSchoolYear = objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolYear = '{0}',", strSchoolYear); //学年
 }
 else
 {
 sbSQL.Append(" SchoolYear = null,"); //学年
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.SchoolTerm))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTerm = '{0}',", strSchoolTerm); //学期
 }
 else
 {
 sbSQL.Append(" SchoolTerm = null,"); //学期
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.UpdDate))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_PaperStuBatchQuesRela_TotalEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.UpdUserId))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.Memo))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.Memo !=  null)
 {
 var strMemo = objcc_PaperStuBatchQuesRela_TotalEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcc_PaperStuBatchQuesRela_TotalEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_PaperStuBatchQuesRela_TotalEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_PaperStuBatchQuesRela_TotalEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_PaperStuBatchQuesRela_Total Set ");
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch !=  null)
 {
 var strIdPaperStuBatch = objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdPaperStuBatch, concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch); //学生试卷批次流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch); //学生试卷批次流水号
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.QuesNum, concc_PaperStuBatchQuesRela_Total.QuesNum); //题目数
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumLook))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook, concc_PaperStuBatchQuesRela_Total.QuesNumLook); //查看题目数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.QuesNumLook); //查看题目数
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumMark))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark, concc_PaperStuBatchQuesRela_Total.QuesNumMark); //打分题目数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.QuesNumMark); //打分题目数
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish, concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish); //未完成题目数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish); //未完成题目数
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumOverdue))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue, concc_PaperStuBatchQuesRela_Total.QuesNumOverdue); //逾期题目数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.QuesNumOverdue); //逾期题目数
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumSave))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave, concc_PaperStuBatchQuesRela_Total.QuesNumSave); //保存题目数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.QuesNumSave); //保存题目数
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumSendBack))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack, concc_PaperStuBatchQuesRela_Total.QuesNumSendBack); //退回题目数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.QuesNumSendBack); //退回题目数
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumSubmit))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit, concc_PaperStuBatchQuesRela_Total.QuesNumSubmit); //提交题目数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.QuesNumSubmit); //提交题目数
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.TotalScore))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.TotalScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.TotalScore, concc_PaperStuBatchQuesRela_Total.TotalScore); //总得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.TotalScore); //总得分
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.TotalScores))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.TotalScores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PaperStuBatchQuesRela_TotalEN.TotalScores, concc_PaperStuBatchQuesRela_Total.TotalScores); //总分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.TotalScores); //总分值
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.SchoolYear))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear !=  null)
 {
 var strSchoolYear = objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolYear, concc_PaperStuBatchQuesRela_Total.SchoolYear); //学年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.SchoolYear); //学年
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.SchoolTerm))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTerm, concc_PaperStuBatchQuesRela_Total.SchoolTerm); //学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.SchoolTerm); //学期
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.UpdDate))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_PaperStuBatchQuesRela_TotalEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_PaperStuBatchQuesRela_Total.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.UpdDate); //修改日期
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.UpdUserId))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, concc_PaperStuBatchQuesRela_Total.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.UpdUserId); //修改用户Id
 }
 }
 
 if (objcc_PaperStuBatchQuesRela_TotalEN.IsUpdated(concc_PaperStuBatchQuesRela_Total.Memo))
 {
 if (objcc_PaperStuBatchQuesRela_TotalEN.Memo !=  null)
 {
 var strMemo = objcc_PaperStuBatchQuesRela_TotalEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_PaperStuBatchQuesRela_Total.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PaperStuBatchQuesRela_Total.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdPaperStuBatchQuesRelaTotal = {0}", objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal); 
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
 /// <param name = "lngIdPaperStuBatchQuesRelaTotal">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngIdPaperStuBatchQuesRelaTotal) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngIdPaperStuBatchQuesRelaTotal,
};
 objSQL.ExecSP("cc_PaperStuBatchQuesRela_Total_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngIdPaperStuBatchQuesRelaTotal">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngIdPaperStuBatchQuesRelaTotal, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
//删除cc_PaperStuBatchQuesRela_Total本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_PaperStuBatchQuesRela_Total where IdPaperStuBatchQuesRelaTotal = " + ""+ lngIdPaperStuBatchQuesRelaTotal+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delcc_PaperStuBatchQuesRela_Total(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
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
//删除cc_PaperStuBatchQuesRela_Total本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_PaperStuBatchQuesRela_Total where IdPaperStuBatchQuesRelaTotal in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngIdPaperStuBatchQuesRelaTotal">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngIdPaperStuBatchQuesRelaTotal) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
//删除cc_PaperStuBatchQuesRela_Total本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_PaperStuBatchQuesRela_Total where IdPaperStuBatchQuesRelaTotal = " + ""+ lngIdPaperStuBatchQuesRelaTotal+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delcc_PaperStuBatchQuesRela_Total(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clscc_PaperStuBatchQuesRela_TotalDA: Delcc_PaperStuBatchQuesRela_Total)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_PaperStuBatchQuesRela_Total where " + strCondition ;
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
public bool Delcc_PaperStuBatchQuesRela_TotalWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clscc_PaperStuBatchQuesRela_TotalDA: Delcc_PaperStuBatchQuesRela_TotalWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_PaperStuBatchQuesRela_Total where " + strCondition ;
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
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalENS">源对象</param>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalENT">目标对象</param>
public void CopyTo(clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalENS, clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalENT)
{
objcc_PaperStuBatchQuesRela_TotalENT.IdPaperStuBatchQuesRelaTotal = objcc_PaperStuBatchQuesRela_TotalENS.IdPaperStuBatchQuesRelaTotal; //学生试卷完成汇总流水号
objcc_PaperStuBatchQuesRela_TotalENT.IdPaperStuBatch = objcc_PaperStuBatchQuesRela_TotalENS.IdPaperStuBatch; //学生试卷批次流水号
objcc_PaperStuBatchQuesRela_TotalENT.QuesNum = objcc_PaperStuBatchQuesRela_TotalENS.QuesNum; //题目数
objcc_PaperStuBatchQuesRela_TotalENT.QuesNumLook = objcc_PaperStuBatchQuesRela_TotalENS.QuesNumLook; //查看题目数
objcc_PaperStuBatchQuesRela_TotalENT.QuesNumMark = objcc_PaperStuBatchQuesRela_TotalENS.QuesNumMark; //打分题目数
objcc_PaperStuBatchQuesRela_TotalENT.QuesNumNoFinish = objcc_PaperStuBatchQuesRela_TotalENS.QuesNumNoFinish; //未完成题目数
objcc_PaperStuBatchQuesRela_TotalENT.QuesNumOverdue = objcc_PaperStuBatchQuesRela_TotalENS.QuesNumOverdue; //逾期题目数
objcc_PaperStuBatchQuesRela_TotalENT.QuesNumSave = objcc_PaperStuBatchQuesRela_TotalENS.QuesNumSave; //保存题目数
objcc_PaperStuBatchQuesRela_TotalENT.QuesNumSendBack = objcc_PaperStuBatchQuesRela_TotalENS.QuesNumSendBack; //退回题目数
objcc_PaperStuBatchQuesRela_TotalENT.QuesNumSubmit = objcc_PaperStuBatchQuesRela_TotalENS.QuesNumSubmit; //提交题目数
objcc_PaperStuBatchQuesRela_TotalENT.TotalScore = objcc_PaperStuBatchQuesRela_TotalENS.TotalScore; //总得分
objcc_PaperStuBatchQuesRela_TotalENT.TotalScores = objcc_PaperStuBatchQuesRela_TotalENS.TotalScores; //总分值
objcc_PaperStuBatchQuesRela_TotalENT.SchoolYear = objcc_PaperStuBatchQuesRela_TotalENS.SchoolYear; //学年
objcc_PaperStuBatchQuesRela_TotalENT.SchoolTerm = objcc_PaperStuBatchQuesRela_TotalENS.SchoolTerm; //学期
objcc_PaperStuBatchQuesRela_TotalENT.UpdDate = objcc_PaperStuBatchQuesRela_TotalENS.UpdDate; //修改日期
objcc_PaperStuBatchQuesRela_TotalENT.UpdUserId = objcc_PaperStuBatchQuesRela_TotalENS.UpdUserId; //修改用户Id
objcc_PaperStuBatchQuesRela_TotalENT.Memo = objcc_PaperStuBatchQuesRela_TotalENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objcc_PaperStuBatchQuesRela_TotalEN.QuesNum, concc_PaperStuBatchQuesRela_Total.QuesNum);
clsCheckSql.CheckFieldNotNull(objcc_PaperStuBatchQuesRela_TotalEN.UpdDate, concc_PaperStuBatchQuesRela_Total.UpdDate);
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch, 10, concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear, 10, concc_PaperStuBatchQuesRela_Total.SchoolYear);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm, 1, concc_PaperStuBatchQuesRela_Total.SchoolTerm);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRela_TotalEN.UpdDate, 20, concc_PaperStuBatchQuesRela_Total.UpdDate);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId, 20, concc_PaperStuBatchQuesRela_Total.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRela_TotalEN.Memo, 1000, concc_PaperStuBatchQuesRela_Total.Memo);
//检查字段外键固定长度
 objcc_PaperStuBatchQuesRela_TotalEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch, 10, concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear, 10, concc_PaperStuBatchQuesRela_Total.SchoolYear);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm, 1, concc_PaperStuBatchQuesRela_Total.SchoolTerm);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRela_TotalEN.UpdDate, 20, concc_PaperStuBatchQuesRela_Total.UpdDate);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId, 20, concc_PaperStuBatchQuesRela_Total.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRela_TotalEN.Memo, 1000, concc_PaperStuBatchQuesRela_Total.Memo);
//检查外键字段长度
 objcc_PaperStuBatchQuesRela_TotalEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch, 10, concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear, 10, concc_PaperStuBatchQuesRela_Total.SchoolYear);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm, 1, concc_PaperStuBatchQuesRela_Total.SchoolTerm);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRela_TotalEN.UpdDate, 20, concc_PaperStuBatchQuesRela_Total.UpdDate);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId, 20, concc_PaperStuBatchQuesRela_Total.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_PaperStuBatchQuesRela_TotalEN.Memo, 1000, concc_PaperStuBatchQuesRela_Total.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch, concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch);
clsCheckSql.CheckSqlInjection4Field(objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear, concc_PaperStuBatchQuesRela_Total.SchoolYear);
clsCheckSql.CheckSqlInjection4Field(objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm, concc_PaperStuBatchQuesRela_Total.SchoolTerm);
clsCheckSql.CheckSqlInjection4Field(objcc_PaperStuBatchQuesRela_TotalEN.UpdDate, concc_PaperStuBatchQuesRela_Total.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId, concc_PaperStuBatchQuesRela_Total.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objcc_PaperStuBatchQuesRela_TotalEN.Memo, concc_PaperStuBatchQuesRela_Total.Memo);
//检查外键字段长度
 objcc_PaperStuBatchQuesRela_TotalEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--cc_PaperStuBatchQuesRela_Total(学生试卷完成汇总),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch == null)
{
 sbCondition.AppendFormat(" and IdPaperStuBatch is null");
}
else
{
 sbCondition.AppendFormat(" and IdPaperStuBatch = '{0}'", objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch);
}
 if (objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm == null)
{
 sbCondition.AppendFormat(" and SchoolTerm is null");
}
else
{
 sbCondition.AppendFormat(" and SchoolTerm = '{0}'", objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm);
}
 if (objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear == null)
{
 sbCondition.AppendFormat(" and SchoolYear is null");
}
else
{
 sbCondition.AppendFormat(" and SchoolYear = '{0}'", objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear);
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
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
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
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
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
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_PaperStuBatchQuesRela_TotalEN._CurrTabName);
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
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_PaperStuBatchQuesRela_TotalEN._CurrTabName, strCondition);
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
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
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
 objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}