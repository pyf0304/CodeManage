
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_WorkCorrectKeyWorkDA
 表名:cc_WorkCorrectKeyWork(01120190)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:08:19
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 /// 作业批改关键词(cc_WorkCorrectKeyWork)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clscc_WorkCorrectKeyWorkDA : clsCommBase4DA
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
 return clscc_WorkCorrectKeyWorkEN._CurrTabName;
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
if (string.IsNullOrEmpty(clscc_WorkCorrectKeyWorkEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_WorkCorrectKeyWorkEN._ConnectString);
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
 if (string.IsNullOrEmpty(clscc_WorkCorrectKeyWorkEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clscc_WorkCorrectKeyWorkEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clscc_WorkCorrectKeyWorkDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkCorrectKeyWork where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_cc_WorkCorrectKeyWork(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clscc_WorkCorrectKeyWorkDA: GetDataTable_cc_WorkCorrectKeyWork)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkCorrectKeyWork where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clscc_WorkCorrectKeyWorkDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clscc_WorkCorrectKeyWorkDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkCorrectKeyWork where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clscc_WorkCorrectKeyWorkDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clscc_WorkCorrectKeyWorkDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_WorkCorrectKeyWork where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_WorkCorrectKeyWork where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clscc_WorkCorrectKeyWorkDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from cc_WorkCorrectKeyWork where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clscc_WorkCorrectKeyWorkDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_WorkCorrectKeyWork.* from cc_WorkCorrectKeyWork Left Join {1} on {2} where {3} and cc_WorkCorrectKeyWork.IdWorkCorrectKeyWork not in (Select top {5} cc_WorkCorrectKeyWork.IdWorkCorrectKeyWork from cc_WorkCorrectKeyWork Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_WorkCorrectKeyWork where {1} and IdWorkCorrectKeyWork not in (Select top {2} IdWorkCorrectKeyWork from cc_WorkCorrectKeyWork where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_WorkCorrectKeyWork where {1} and IdWorkCorrectKeyWork not in (Select top {3} IdWorkCorrectKeyWork from cc_WorkCorrectKeyWork where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clscc_WorkCorrectKeyWorkDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_WorkCorrectKeyWork.* from cc_WorkCorrectKeyWork Left Join {1} on {2} where {3} and cc_WorkCorrectKeyWork.IdWorkCorrectKeyWork not in (Select top {5} cc_WorkCorrectKeyWork.IdWorkCorrectKeyWork from cc_WorkCorrectKeyWork Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_WorkCorrectKeyWork where {1} and IdWorkCorrectKeyWork not in (Select top {2} IdWorkCorrectKeyWork from cc_WorkCorrectKeyWork where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_WorkCorrectKeyWork where {1} and IdWorkCorrectKeyWork not in (Select top {3} IdWorkCorrectKeyWork from cc_WorkCorrectKeyWork where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clscc_WorkCorrectKeyWorkEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clscc_WorkCorrectKeyWorkDA:GetObjLst)", objException.Message));
}
List<clscc_WorkCorrectKeyWorkEN> arrObjLst = new List<clscc_WorkCorrectKeyWorkEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkCorrectKeyWork where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN = new clscc_WorkCorrectKeyWorkEN();
try
{
objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = TransNullToInt(objRow[concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()); //作业批改关键词流水号
objcc_WorkCorrectKeyWorkEN.QuestionID = objRow[concc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID
objcc_WorkCorrectKeyWorkEN.KeyWorkIndex = objRow[concc_WorkCorrectKeyWork.KeyWorkIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()); //关键字序号
objcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objRow[concc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词
objcc_WorkCorrectKeyWorkEN.IsUseFormatPara = TransNullToBool(objRow[concc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()); //是否使用格式化参数
objcc_WorkCorrectKeyWorkEN.FormatPara = objRow[concc_WorkCorrectKeyWork.FormatPara] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数
objcc_WorkCorrectKeyWorkEN.InOutTypeId = objRow[concc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id
objcc_WorkCorrectKeyWorkEN.Creator = objRow[concc_WorkCorrectKeyWork.Creator] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者
objcc_WorkCorrectKeyWorkEN.CreateDate = objRow[concc_WorkCorrectKeyWork.CreateDate] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期
objcc_WorkCorrectKeyWorkEN.IsEnable = TransNullToBool(objRow[concc_WorkCorrectKeyWork.IsEnable].ToString().Trim()); //是否启用
objcc_WorkCorrectKeyWorkEN.UpdDate = objRow[concc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期
objcc_WorkCorrectKeyWorkEN.UpdUser = objRow[concc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人
objcc_WorkCorrectKeyWorkEN.Memo = objRow[concc_WorkCorrectKeyWork.Memo] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_WorkCorrectKeyWorkDA: GetObjLst)", objException.Message));
}
objcc_WorkCorrectKeyWorkEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_WorkCorrectKeyWorkEN);
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
public List<clscc_WorkCorrectKeyWorkEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clscc_WorkCorrectKeyWorkDA:GetObjLstByTabName)", objException.Message));
}
List<clscc_WorkCorrectKeyWorkEN> arrObjLst = new List<clscc_WorkCorrectKeyWorkEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN = new clscc_WorkCorrectKeyWorkEN();
try
{
objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = TransNullToInt(objRow[concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()); //作业批改关键词流水号
objcc_WorkCorrectKeyWorkEN.QuestionID = objRow[concc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID
objcc_WorkCorrectKeyWorkEN.KeyWorkIndex = objRow[concc_WorkCorrectKeyWork.KeyWorkIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()); //关键字序号
objcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objRow[concc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词
objcc_WorkCorrectKeyWorkEN.IsUseFormatPara = TransNullToBool(objRow[concc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()); //是否使用格式化参数
objcc_WorkCorrectKeyWorkEN.FormatPara = objRow[concc_WorkCorrectKeyWork.FormatPara] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数
objcc_WorkCorrectKeyWorkEN.InOutTypeId = objRow[concc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id
objcc_WorkCorrectKeyWorkEN.Creator = objRow[concc_WorkCorrectKeyWork.Creator] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者
objcc_WorkCorrectKeyWorkEN.CreateDate = objRow[concc_WorkCorrectKeyWork.CreateDate] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期
objcc_WorkCorrectKeyWorkEN.IsEnable = TransNullToBool(objRow[concc_WorkCorrectKeyWork.IsEnable].ToString().Trim()); //是否启用
objcc_WorkCorrectKeyWorkEN.UpdDate = objRow[concc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期
objcc_WorkCorrectKeyWorkEN.UpdUser = objRow[concc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人
objcc_WorkCorrectKeyWorkEN.Memo = objRow[concc_WorkCorrectKeyWork.Memo] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_WorkCorrectKeyWorkDA: GetObjLst)", objException.Message));
}
objcc_WorkCorrectKeyWorkEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_WorkCorrectKeyWorkEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getcc_WorkCorrectKeyWork(ref clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkCorrectKeyWork where IdWorkCorrectKeyWork = " + ""+ objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = TransNullToInt(objDT.Rows[0][concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()); //作业批改关键词流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objcc_WorkCorrectKeyWorkEN.QuestionID = objDT.Rows[0][concc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID(字段类型:char,字段长度:8,是否可空:True)
 objcc_WorkCorrectKeyWorkEN.KeyWorkIndex = TransNullToInt(objDT.Rows[0][concc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()); //关键字序号(字段类型:int,字段长度:4,是否可空:True)
 objcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objDT.Rows[0][concc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词(字段类型:varchar,字段长度:200,是否可空:False)
 objcc_WorkCorrectKeyWorkEN.IsUseFormatPara = TransNullToBool(objDT.Rows[0][concc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()); //是否使用格式化参数(字段类型:bit,字段长度:1,是否可空:True)
 objcc_WorkCorrectKeyWorkEN.FormatPara = objDT.Rows[0][concc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数(字段类型:varchar,字段长度:100,是否可空:True)
 objcc_WorkCorrectKeyWorkEN.InOutTypeId = objDT.Rows[0][concc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id(字段类型:char,字段长度:2,是否可空:False)
 objcc_WorkCorrectKeyWorkEN.Creator = objDT.Rows[0][concc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者(字段类型:varchar,字段长度:18,是否可空:True)
 objcc_WorkCorrectKeyWorkEN.CreateDate = objDT.Rows[0][concc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_WorkCorrectKeyWorkEN.IsEnable = TransNullToBool(objDT.Rows[0][concc_WorkCorrectKeyWork.IsEnable].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:False)
 objcc_WorkCorrectKeyWorkEN.UpdDate = objDT.Rows[0][concc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_WorkCorrectKeyWorkEN.UpdUser = objDT.Rows[0][concc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_WorkCorrectKeyWorkEN.Memo = objDT.Rows[0][concc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clscc_WorkCorrectKeyWorkDA: Getcc_WorkCorrectKeyWork)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdWorkCorrectKeyWork">表关键字</param>
 /// <returns>表对象</returns>
public clscc_WorkCorrectKeyWorkEN GetObjByIdWorkCorrectKeyWork(long lngIdWorkCorrectKeyWork)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkCorrectKeyWork where IdWorkCorrectKeyWork = " + ""+ lngIdWorkCorrectKeyWork+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN = new clscc_WorkCorrectKeyWorkEN();
try
{
 objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = Int32.Parse(objRow[concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()); //作业批改关键词流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objcc_WorkCorrectKeyWorkEN.QuestionID = objRow[concc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID(字段类型:char,字段长度:8,是否可空:True)
 objcc_WorkCorrectKeyWorkEN.KeyWorkIndex = objRow[concc_WorkCorrectKeyWork.KeyWorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()); //关键字序号(字段类型:int,字段长度:4,是否可空:True)
 objcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objRow[concc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词(字段类型:varchar,字段长度:200,是否可空:False)
 objcc_WorkCorrectKeyWorkEN.IsUseFormatPara = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()); //是否使用格式化参数(字段类型:bit,字段长度:1,是否可空:True)
 objcc_WorkCorrectKeyWorkEN.FormatPara = objRow[concc_WorkCorrectKeyWork.FormatPara] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数(字段类型:varchar,字段长度:100,是否可空:True)
 objcc_WorkCorrectKeyWorkEN.InOutTypeId = objRow[concc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id(字段类型:char,字段长度:2,是否可空:False)
 objcc_WorkCorrectKeyWorkEN.Creator = objRow[concc_WorkCorrectKeyWork.Creator] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者(字段类型:varchar,字段长度:18,是否可空:True)
 objcc_WorkCorrectKeyWorkEN.CreateDate = objRow[concc_WorkCorrectKeyWork.CreateDate] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_WorkCorrectKeyWorkEN.IsEnable = clsEntityBase2.TransNullToBool_S(objRow[concc_WorkCorrectKeyWork.IsEnable].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:False)
 objcc_WorkCorrectKeyWorkEN.UpdDate = objRow[concc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_WorkCorrectKeyWorkEN.UpdUser = objRow[concc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_WorkCorrectKeyWorkEN.Memo = objRow[concc_WorkCorrectKeyWork.Memo] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clscc_WorkCorrectKeyWorkDA: GetObjByIdWorkCorrectKeyWork)", objException.Message));
}
return objcc_WorkCorrectKeyWorkEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clscc_WorkCorrectKeyWorkEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clscc_WorkCorrectKeyWorkDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkCorrectKeyWork where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN = new clscc_WorkCorrectKeyWorkEN()
{
IdWorkCorrectKeyWork = TransNullToInt(objRow[concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()), //作业批改关键词流水号
QuestionID = objRow[concc_WorkCorrectKeyWork.QuestionID].ToString().Trim(), //题目ID
KeyWorkIndex = objRow[concc_WorkCorrectKeyWork.KeyWorkIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()), //关键字序号
CorrectKeyWork = objRow[concc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(), //批改关键词
IsUseFormatPara = TransNullToBool(objRow[concc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()), //是否使用格式化参数
FormatPara = objRow[concc_WorkCorrectKeyWork.FormatPara] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.FormatPara].ToString().Trim(), //格式化参数
InOutTypeId = objRow[concc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(), //InOut类型Id
Creator = objRow[concc_WorkCorrectKeyWork.Creator] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.Creator].ToString().Trim(), //创建者
CreateDate = objRow[concc_WorkCorrectKeyWork.CreateDate] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.CreateDate].ToString().Trim(), //建立日期
IsEnable = TransNullToBool(objRow[concc_WorkCorrectKeyWork.IsEnable].ToString().Trim()), //是否启用
UpdDate = objRow[concc_WorkCorrectKeyWork.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[concc_WorkCorrectKeyWork.UpdUser].ToString().Trim(), //修改人
Memo = objRow[concc_WorkCorrectKeyWork.Memo] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.Memo].ToString().Trim() //备注
};
objcc_WorkCorrectKeyWorkEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_WorkCorrectKeyWorkEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clscc_WorkCorrectKeyWorkDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clscc_WorkCorrectKeyWorkEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN = new clscc_WorkCorrectKeyWorkEN();
try
{
objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = TransNullToInt(objRow[concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()); //作业批改关键词流水号
objcc_WorkCorrectKeyWorkEN.QuestionID = objRow[concc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID
objcc_WorkCorrectKeyWorkEN.KeyWorkIndex = objRow[concc_WorkCorrectKeyWork.KeyWorkIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()); //关键字序号
objcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objRow[concc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词
objcc_WorkCorrectKeyWorkEN.IsUseFormatPara = TransNullToBool(objRow[concc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()); //是否使用格式化参数
objcc_WorkCorrectKeyWorkEN.FormatPara = objRow[concc_WorkCorrectKeyWork.FormatPara] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数
objcc_WorkCorrectKeyWorkEN.InOutTypeId = objRow[concc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id
objcc_WorkCorrectKeyWorkEN.Creator = objRow[concc_WorkCorrectKeyWork.Creator] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者
objcc_WorkCorrectKeyWorkEN.CreateDate = objRow[concc_WorkCorrectKeyWork.CreateDate] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期
objcc_WorkCorrectKeyWorkEN.IsEnable = TransNullToBool(objRow[concc_WorkCorrectKeyWork.IsEnable].ToString().Trim()); //是否启用
objcc_WorkCorrectKeyWorkEN.UpdDate = objRow[concc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期
objcc_WorkCorrectKeyWorkEN.UpdUser = objRow[concc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人
objcc_WorkCorrectKeyWorkEN.Memo = objRow[concc_WorkCorrectKeyWork.Memo] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clscc_WorkCorrectKeyWorkDA: GetObjByDataRowcc_WorkCorrectKeyWork)", objException.Message));
}
objcc_WorkCorrectKeyWorkEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_WorkCorrectKeyWorkEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clscc_WorkCorrectKeyWorkEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN = new clscc_WorkCorrectKeyWorkEN();
try
{
objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork = TransNullToInt(objRow[concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim()); //作业批改关键词流水号
objcc_WorkCorrectKeyWorkEN.QuestionID = objRow[concc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID
objcc_WorkCorrectKeyWorkEN.KeyWorkIndex = objRow[concc_WorkCorrectKeyWork.KeyWorkIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim()); //关键字序号
objcc_WorkCorrectKeyWorkEN.CorrectKeyWork = objRow[concc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词
objcc_WorkCorrectKeyWorkEN.IsUseFormatPara = TransNullToBool(objRow[concc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim()); //是否使用格式化参数
objcc_WorkCorrectKeyWorkEN.FormatPara = objRow[concc_WorkCorrectKeyWork.FormatPara] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数
objcc_WorkCorrectKeyWorkEN.InOutTypeId = objRow[concc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id
objcc_WorkCorrectKeyWorkEN.Creator = objRow[concc_WorkCorrectKeyWork.Creator] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者
objcc_WorkCorrectKeyWorkEN.CreateDate = objRow[concc_WorkCorrectKeyWork.CreateDate] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期
objcc_WorkCorrectKeyWorkEN.IsEnable = TransNullToBool(objRow[concc_WorkCorrectKeyWork.IsEnable].ToString().Trim()); //是否启用
objcc_WorkCorrectKeyWorkEN.UpdDate = objRow[concc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期
objcc_WorkCorrectKeyWorkEN.UpdUser = objRow[concc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人
objcc_WorkCorrectKeyWorkEN.Memo = objRow[concc_WorkCorrectKeyWork.Memo] == DBNull.Value ? null : objRow[concc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clscc_WorkCorrectKeyWorkDA: GetObjByDataRow)", objException.Message));
}
objcc_WorkCorrectKeyWorkEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_WorkCorrectKeyWorkEN;
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
objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_WorkCorrectKeyWorkEN._CurrTabName, concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork, 8, "");
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
objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_WorkCorrectKeyWorkEN._CurrTabName, concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork, 8, strPrefix);
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
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdWorkCorrectKeyWork from cc_WorkCorrectKeyWork where " + strCondition;
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
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdWorkCorrectKeyWork from cc_WorkCorrectKeyWork where " + strCondition;
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
 /// <param name = "lngIdWorkCorrectKeyWork">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdWorkCorrectKeyWork)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_WorkCorrectKeyWork", "IdWorkCorrectKeyWork = " + ""+ lngIdWorkCorrectKeyWork+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clscc_WorkCorrectKeyWorkDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_WorkCorrectKeyWork", strCondition))
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
objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("cc_WorkCorrectKeyWork");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
 {
 objcc_WorkCorrectKeyWorkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkCorrectKeyWorkEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_WorkCorrectKeyWorkEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkCorrectKeyWork where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_WorkCorrectKeyWork");
objRow = objDS.Tables["cc_WorkCorrectKeyWork"].NewRow();
objRow[concc_WorkCorrectKeyWork.QuestionID] = objcc_WorkCorrectKeyWorkEN.QuestionID; //题目ID
objRow[concc_WorkCorrectKeyWork.KeyWorkIndex] = objcc_WorkCorrectKeyWorkEN.KeyWorkIndex; //关键字序号
objRow[concc_WorkCorrectKeyWork.CorrectKeyWork] = objcc_WorkCorrectKeyWorkEN.CorrectKeyWork; //批改关键词
objRow[concc_WorkCorrectKeyWork.IsUseFormatPara] = objcc_WorkCorrectKeyWorkEN.IsUseFormatPara; //是否使用格式化参数
 if (objcc_WorkCorrectKeyWorkEN.FormatPara !=  "")
 {
objRow[concc_WorkCorrectKeyWork.FormatPara] = objcc_WorkCorrectKeyWorkEN.FormatPara; //格式化参数
 }
objRow[concc_WorkCorrectKeyWork.InOutTypeId] = objcc_WorkCorrectKeyWorkEN.InOutTypeId; //InOut类型Id
 if (objcc_WorkCorrectKeyWorkEN.Creator !=  "")
 {
objRow[concc_WorkCorrectKeyWork.Creator] = objcc_WorkCorrectKeyWorkEN.Creator; //创建者
 }
 if (objcc_WorkCorrectKeyWorkEN.CreateDate !=  "")
 {
objRow[concc_WorkCorrectKeyWork.CreateDate] = objcc_WorkCorrectKeyWorkEN.CreateDate; //建立日期
 }
objRow[concc_WorkCorrectKeyWork.IsEnable] = objcc_WorkCorrectKeyWorkEN.IsEnable; //是否启用
objRow[concc_WorkCorrectKeyWork.UpdDate] = objcc_WorkCorrectKeyWorkEN.UpdDate; //修改日期
objRow[concc_WorkCorrectKeyWork.UpdUser] = objcc_WorkCorrectKeyWorkEN.UpdUser; //修改人
 if (objcc_WorkCorrectKeyWorkEN.Memo !=  "")
 {
objRow[concc_WorkCorrectKeyWork.Memo] = objcc_WorkCorrectKeyWorkEN.Memo; //备注
 }
objDS.Tables[clscc_WorkCorrectKeyWorkEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clscc_WorkCorrectKeyWorkEN._CurrTabName);
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
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
 objcc_WorkCorrectKeyWorkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkCorrectKeyWorkEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_WorkCorrectKeyWorkEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcc_WorkCorrectKeyWorkEN.QuestionID !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.QuestionID);
 var strQuestionID = objcc_WorkCorrectKeyWorkEN.QuestionID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionID + "'");
 }
 
 if (objcc_WorkCorrectKeyWorkEN.KeyWorkIndex !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.KeyWorkIndex);
 arrValueListForInsert.Add(objcc_WorkCorrectKeyWorkEN.KeyWorkIndex.ToString());
 }
 
 if (objcc_WorkCorrectKeyWorkEN.CorrectKeyWork !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.CorrectKeyWork);
 var strCorrectKeyWork = objcc_WorkCorrectKeyWorkEN.CorrectKeyWork.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCorrectKeyWork + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.IsUseFormatPara);
 arrValueListForInsert.Add("'" + (objcc_WorkCorrectKeyWorkEN.IsUseFormatPara  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkCorrectKeyWorkEN.FormatPara !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.FormatPara);
 var strFormatPara = objcc_WorkCorrectKeyWorkEN.FormatPara.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFormatPara + "'");
 }
 
 if (objcc_WorkCorrectKeyWorkEN.InOutTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.InOutTypeId);
 var strInOutTypeId = objcc_WorkCorrectKeyWorkEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInOutTypeId + "'");
 }
 
 if (objcc_WorkCorrectKeyWorkEN.Creator !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.Creator);
 var strCreator = objcc_WorkCorrectKeyWorkEN.Creator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreator + "'");
 }
 
 if (objcc_WorkCorrectKeyWorkEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.CreateDate);
 var strCreateDate = objcc_WorkCorrectKeyWorkEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.IsEnable);
 arrValueListForInsert.Add("'" + (objcc_WorkCorrectKeyWorkEN.IsEnable  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkCorrectKeyWorkEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.UpdDate);
 var strUpdDate = objcc_WorkCorrectKeyWorkEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_WorkCorrectKeyWorkEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.UpdUser);
 var strUpdUser = objcc_WorkCorrectKeyWorkEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objcc_WorkCorrectKeyWorkEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.Memo);
 var strMemo = objcc_WorkCorrectKeyWorkEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_WorkCorrectKeyWork");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
 objcc_WorkCorrectKeyWorkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkCorrectKeyWorkEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_WorkCorrectKeyWorkEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcc_WorkCorrectKeyWorkEN.QuestionID !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.QuestionID);
 var strQuestionID = objcc_WorkCorrectKeyWorkEN.QuestionID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionID + "'");
 }
 
 if (objcc_WorkCorrectKeyWorkEN.KeyWorkIndex !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.KeyWorkIndex);
 arrValueListForInsert.Add(objcc_WorkCorrectKeyWorkEN.KeyWorkIndex.ToString());
 }
 
 if (objcc_WorkCorrectKeyWorkEN.CorrectKeyWork !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.CorrectKeyWork);
 var strCorrectKeyWork = objcc_WorkCorrectKeyWorkEN.CorrectKeyWork.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCorrectKeyWork + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.IsUseFormatPara);
 arrValueListForInsert.Add("'" + (objcc_WorkCorrectKeyWorkEN.IsUseFormatPara  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkCorrectKeyWorkEN.FormatPara !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.FormatPara);
 var strFormatPara = objcc_WorkCorrectKeyWorkEN.FormatPara.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFormatPara + "'");
 }
 
 if (objcc_WorkCorrectKeyWorkEN.InOutTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.InOutTypeId);
 var strInOutTypeId = objcc_WorkCorrectKeyWorkEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInOutTypeId + "'");
 }
 
 if (objcc_WorkCorrectKeyWorkEN.Creator !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.Creator);
 var strCreator = objcc_WorkCorrectKeyWorkEN.Creator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreator + "'");
 }
 
 if (objcc_WorkCorrectKeyWorkEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.CreateDate);
 var strCreateDate = objcc_WorkCorrectKeyWorkEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.IsEnable);
 arrValueListForInsert.Add("'" + (objcc_WorkCorrectKeyWorkEN.IsEnable  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkCorrectKeyWorkEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.UpdDate);
 var strUpdDate = objcc_WorkCorrectKeyWorkEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_WorkCorrectKeyWorkEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.UpdUser);
 var strUpdUser = objcc_WorkCorrectKeyWorkEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objcc_WorkCorrectKeyWorkEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.Memo);
 var strMemo = objcc_WorkCorrectKeyWorkEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_WorkCorrectKeyWork");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcc_WorkCorrectKeyWorkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkCorrectKeyWorkEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_WorkCorrectKeyWorkEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcc_WorkCorrectKeyWorkEN.QuestionID !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.QuestionID);
 var strQuestionID = objcc_WorkCorrectKeyWorkEN.QuestionID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionID + "'");
 }
 
 if (objcc_WorkCorrectKeyWorkEN.KeyWorkIndex !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.KeyWorkIndex);
 arrValueListForInsert.Add(objcc_WorkCorrectKeyWorkEN.KeyWorkIndex.ToString());
 }
 
 if (objcc_WorkCorrectKeyWorkEN.CorrectKeyWork !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.CorrectKeyWork);
 var strCorrectKeyWork = objcc_WorkCorrectKeyWorkEN.CorrectKeyWork.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCorrectKeyWork + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.IsUseFormatPara);
 arrValueListForInsert.Add("'" + (objcc_WorkCorrectKeyWorkEN.IsUseFormatPara  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkCorrectKeyWorkEN.FormatPara !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.FormatPara);
 var strFormatPara = objcc_WorkCorrectKeyWorkEN.FormatPara.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFormatPara + "'");
 }
 
 if (objcc_WorkCorrectKeyWorkEN.InOutTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.InOutTypeId);
 var strInOutTypeId = objcc_WorkCorrectKeyWorkEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInOutTypeId + "'");
 }
 
 if (objcc_WorkCorrectKeyWorkEN.Creator !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.Creator);
 var strCreator = objcc_WorkCorrectKeyWorkEN.Creator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreator + "'");
 }
 
 if (objcc_WorkCorrectKeyWorkEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.CreateDate);
 var strCreateDate = objcc_WorkCorrectKeyWorkEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.IsEnable);
 arrValueListForInsert.Add("'" + (objcc_WorkCorrectKeyWorkEN.IsEnable  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkCorrectKeyWorkEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.UpdDate);
 var strUpdDate = objcc_WorkCorrectKeyWorkEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_WorkCorrectKeyWorkEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.UpdUser);
 var strUpdUser = objcc_WorkCorrectKeyWorkEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objcc_WorkCorrectKeyWorkEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.Memo);
 var strMemo = objcc_WorkCorrectKeyWorkEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_WorkCorrectKeyWork");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcc_WorkCorrectKeyWorkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkCorrectKeyWorkEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_WorkCorrectKeyWorkEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objcc_WorkCorrectKeyWorkEN.QuestionID !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.QuestionID);
 var strQuestionID = objcc_WorkCorrectKeyWorkEN.QuestionID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionID + "'");
 }
 
 if (objcc_WorkCorrectKeyWorkEN.KeyWorkIndex !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.KeyWorkIndex);
 arrValueListForInsert.Add(objcc_WorkCorrectKeyWorkEN.KeyWorkIndex.ToString());
 }
 
 if (objcc_WorkCorrectKeyWorkEN.CorrectKeyWork !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.CorrectKeyWork);
 var strCorrectKeyWork = objcc_WorkCorrectKeyWorkEN.CorrectKeyWork.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCorrectKeyWork + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.IsUseFormatPara);
 arrValueListForInsert.Add("'" + (objcc_WorkCorrectKeyWorkEN.IsUseFormatPara  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkCorrectKeyWorkEN.FormatPara !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.FormatPara);
 var strFormatPara = objcc_WorkCorrectKeyWorkEN.FormatPara.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFormatPara + "'");
 }
 
 if (objcc_WorkCorrectKeyWorkEN.InOutTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.InOutTypeId);
 var strInOutTypeId = objcc_WorkCorrectKeyWorkEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInOutTypeId + "'");
 }
 
 if (objcc_WorkCorrectKeyWorkEN.Creator !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.Creator);
 var strCreator = objcc_WorkCorrectKeyWorkEN.Creator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreator + "'");
 }
 
 if (objcc_WorkCorrectKeyWorkEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.CreateDate);
 var strCreateDate = objcc_WorkCorrectKeyWorkEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.IsEnable);
 arrValueListForInsert.Add("'" + (objcc_WorkCorrectKeyWorkEN.IsEnable  ==  false ? "0" : "1") + "'");
 
 if (objcc_WorkCorrectKeyWorkEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.UpdDate);
 var strUpdDate = objcc_WorkCorrectKeyWorkEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_WorkCorrectKeyWorkEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.UpdUser);
 var strUpdUser = objcc_WorkCorrectKeyWorkEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objcc_WorkCorrectKeyWorkEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_WorkCorrectKeyWork.Memo);
 var strMemo = objcc_WorkCorrectKeyWorkEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_WorkCorrectKeyWork");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewcc_WorkCorrectKeyWorks(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkCorrectKeyWork where IdWorkCorrectKeyWork = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_WorkCorrectKeyWork");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngIdWorkCorrectKeyWork = TransNullToInt(oRow[concc_WorkCorrectKeyWork.IdWorkCorrectKeyWork].ToString().Trim());
if (IsExist(lngIdWorkCorrectKeyWork))
{
 string strResult = "关键字变量值为:" + string.Format("IdWorkCorrectKeyWork = {0}", lngIdWorkCorrectKeyWork) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clscc_WorkCorrectKeyWorkEN._CurrTabName ].NewRow();
objRow[concc_WorkCorrectKeyWork.QuestionID] = oRow[concc_WorkCorrectKeyWork.QuestionID].ToString().Trim(); //题目ID
objRow[concc_WorkCorrectKeyWork.KeyWorkIndex] = oRow[concc_WorkCorrectKeyWork.KeyWorkIndex].ToString().Trim(); //关键字序号
objRow[concc_WorkCorrectKeyWork.CorrectKeyWork] = oRow[concc_WorkCorrectKeyWork.CorrectKeyWork].ToString().Trim(); //批改关键词
objRow[concc_WorkCorrectKeyWork.IsUseFormatPara] = oRow[concc_WorkCorrectKeyWork.IsUseFormatPara].ToString().Trim(); //是否使用格式化参数
objRow[concc_WorkCorrectKeyWork.FormatPara] = oRow[concc_WorkCorrectKeyWork.FormatPara].ToString().Trim(); //格式化参数
objRow[concc_WorkCorrectKeyWork.InOutTypeId] = oRow[concc_WorkCorrectKeyWork.InOutTypeId].ToString().Trim(); //InOut类型Id
objRow[concc_WorkCorrectKeyWork.Creator] = oRow[concc_WorkCorrectKeyWork.Creator].ToString().Trim(); //创建者
objRow[concc_WorkCorrectKeyWork.CreateDate] = oRow[concc_WorkCorrectKeyWork.CreateDate].ToString().Trim(); //建立日期
objRow[concc_WorkCorrectKeyWork.IsEnable] = oRow[concc_WorkCorrectKeyWork.IsEnable].ToString().Trim(); //是否启用
objRow[concc_WorkCorrectKeyWork.UpdDate] = oRow[concc_WorkCorrectKeyWork.UpdDate].ToString().Trim(); //修改日期
objRow[concc_WorkCorrectKeyWork.UpdUser] = oRow[concc_WorkCorrectKeyWork.UpdUser].ToString().Trim(); //修改人
objRow[concc_WorkCorrectKeyWork.Memo] = oRow[concc_WorkCorrectKeyWork.Memo].ToString().Trim(); //备注
 objDS.Tables[clscc_WorkCorrectKeyWorkEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clscc_WorkCorrectKeyWorkEN._CurrTabName);
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
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
 objcc_WorkCorrectKeyWorkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkCorrectKeyWorkEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_WorkCorrectKeyWorkEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
strSQL = "Select * from cc_WorkCorrectKeyWork where IdWorkCorrectKeyWork = " + ""+ objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clscc_WorkCorrectKeyWorkEN._CurrTabName);
if (objDS.Tables[clscc_WorkCorrectKeyWorkEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdWorkCorrectKeyWork = " + ""+ objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork+"");
return false;
}
objRow = objDS.Tables[clscc_WorkCorrectKeyWorkEN._CurrTabName].Rows[0];
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.QuestionID))
 {
objRow[concc_WorkCorrectKeyWork.QuestionID] = objcc_WorkCorrectKeyWorkEN.QuestionID; //题目ID
 }
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.KeyWorkIndex))
 {
objRow[concc_WorkCorrectKeyWork.KeyWorkIndex] = objcc_WorkCorrectKeyWorkEN.KeyWorkIndex; //关键字序号
 }
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.CorrectKeyWork))
 {
objRow[concc_WorkCorrectKeyWork.CorrectKeyWork] = objcc_WorkCorrectKeyWorkEN.CorrectKeyWork; //批改关键词
 }
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.IsUseFormatPara))
 {
objRow[concc_WorkCorrectKeyWork.IsUseFormatPara] = objcc_WorkCorrectKeyWorkEN.IsUseFormatPara; //是否使用格式化参数
 }
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.FormatPara))
 {
objRow[concc_WorkCorrectKeyWork.FormatPara] = objcc_WorkCorrectKeyWorkEN.FormatPara; //格式化参数
 }
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.InOutTypeId))
 {
objRow[concc_WorkCorrectKeyWork.InOutTypeId] = objcc_WorkCorrectKeyWorkEN.InOutTypeId; //InOut类型Id
 }
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.Creator))
 {
objRow[concc_WorkCorrectKeyWork.Creator] = objcc_WorkCorrectKeyWorkEN.Creator; //创建者
 }
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.CreateDate))
 {
objRow[concc_WorkCorrectKeyWork.CreateDate] = objcc_WorkCorrectKeyWorkEN.CreateDate; //建立日期
 }
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.IsEnable))
 {
objRow[concc_WorkCorrectKeyWork.IsEnable] = objcc_WorkCorrectKeyWorkEN.IsEnable; //是否启用
 }
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.UpdDate))
 {
objRow[concc_WorkCorrectKeyWork.UpdDate] = objcc_WorkCorrectKeyWorkEN.UpdDate; //修改日期
 }
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.UpdUser))
 {
objRow[concc_WorkCorrectKeyWork.UpdUser] = objcc_WorkCorrectKeyWorkEN.UpdUser; //修改人
 }
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.Memo))
 {
objRow[concc_WorkCorrectKeyWork.Memo] = objcc_WorkCorrectKeyWorkEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clscc_WorkCorrectKeyWorkEN._CurrTabName);
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
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
 objcc_WorkCorrectKeyWorkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkCorrectKeyWorkEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_WorkCorrectKeyWorkEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update cc_WorkCorrectKeyWork Set ");
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.QuestionID))
 {
 if (objcc_WorkCorrectKeyWorkEN.QuestionID !=  null)
 {
 var strQuestionID = objcc_WorkCorrectKeyWorkEN.QuestionID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionID, concc_WorkCorrectKeyWork.QuestionID); //题目ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkCorrectKeyWork.QuestionID); //题目ID
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.KeyWorkIndex))
 {
 if (objcc_WorkCorrectKeyWorkEN.KeyWorkIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_WorkCorrectKeyWorkEN.KeyWorkIndex, concc_WorkCorrectKeyWork.KeyWorkIndex); //关键字序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkCorrectKeyWork.KeyWorkIndex); //关键字序号
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.CorrectKeyWork))
 {
 if (objcc_WorkCorrectKeyWorkEN.CorrectKeyWork !=  null)
 {
 var strCorrectKeyWork = objcc_WorkCorrectKeyWorkEN.CorrectKeyWork.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCorrectKeyWork, concc_WorkCorrectKeyWork.CorrectKeyWork); //批改关键词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkCorrectKeyWork.CorrectKeyWork); //批改关键词
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.IsUseFormatPara))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkCorrectKeyWorkEN.IsUseFormatPara == true?"1":"0", concc_WorkCorrectKeyWork.IsUseFormatPara); //是否使用格式化参数
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.FormatPara))
 {
 if (objcc_WorkCorrectKeyWorkEN.FormatPara !=  null)
 {
 var strFormatPara = objcc_WorkCorrectKeyWorkEN.FormatPara.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFormatPara, concc_WorkCorrectKeyWork.FormatPara); //格式化参数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkCorrectKeyWork.FormatPara); //格式化参数
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.InOutTypeId))
 {
 if (objcc_WorkCorrectKeyWorkEN.InOutTypeId !=  null)
 {
 var strInOutTypeId = objcc_WorkCorrectKeyWorkEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInOutTypeId, concc_WorkCorrectKeyWork.InOutTypeId); //InOut类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkCorrectKeyWork.InOutTypeId); //InOut类型Id
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.Creator))
 {
 if (objcc_WorkCorrectKeyWorkEN.Creator !=  null)
 {
 var strCreator = objcc_WorkCorrectKeyWorkEN.Creator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreator, concc_WorkCorrectKeyWork.Creator); //创建者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkCorrectKeyWork.Creator); //创建者
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.CreateDate))
 {
 if (objcc_WorkCorrectKeyWorkEN.CreateDate !=  null)
 {
 var strCreateDate = objcc_WorkCorrectKeyWorkEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, concc_WorkCorrectKeyWork.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkCorrectKeyWork.CreateDate); //建立日期
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.IsEnable))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkCorrectKeyWorkEN.IsEnable == true?"1":"0", concc_WorkCorrectKeyWork.IsEnable); //是否启用
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.UpdDate))
 {
 if (objcc_WorkCorrectKeyWorkEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_WorkCorrectKeyWorkEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_WorkCorrectKeyWork.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkCorrectKeyWork.UpdDate); //修改日期
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.UpdUser))
 {
 if (objcc_WorkCorrectKeyWorkEN.UpdUser !=  null)
 {
 var strUpdUser = objcc_WorkCorrectKeyWorkEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, concc_WorkCorrectKeyWork.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkCorrectKeyWork.UpdUser); //修改人
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.Memo))
 {
 if (objcc_WorkCorrectKeyWorkEN.Memo !=  null)
 {
 var strMemo = objcc_WorkCorrectKeyWorkEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_WorkCorrectKeyWork.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkCorrectKeyWork.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdWorkCorrectKeyWork = {0}", objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork); 
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
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, string strCondition)
{
 objcc_WorkCorrectKeyWorkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkCorrectKeyWorkEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_WorkCorrectKeyWorkEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_WorkCorrectKeyWork Set ");
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.QuestionID))
 {
 if (objcc_WorkCorrectKeyWorkEN.QuestionID !=  null)
 {
 var strQuestionID = objcc_WorkCorrectKeyWorkEN.QuestionID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionID = '{0}',", strQuestionID); //题目ID
 }
 else
 {
 sbSQL.Append(" QuestionID = null,"); //题目ID
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.KeyWorkIndex))
 {
 sbSQL.AppendFormat(" KeyWorkIndex = {0},", objcc_WorkCorrectKeyWorkEN.KeyWorkIndex); //关键字序号
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.CorrectKeyWork))
 {
 if (objcc_WorkCorrectKeyWorkEN.CorrectKeyWork !=  null)
 {
 var strCorrectKeyWork = objcc_WorkCorrectKeyWorkEN.CorrectKeyWork.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CorrectKeyWork = '{0}',", strCorrectKeyWork); //批改关键词
 }
 else
 {
 sbSQL.Append(" CorrectKeyWork = null,"); //批改关键词
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.IsUseFormatPara))
 {
 sbSQL.AppendFormat(" IsUseFormatPara = '{0}',", objcc_WorkCorrectKeyWorkEN.IsUseFormatPara == true?"1":"0"); //是否使用格式化参数
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.FormatPara))
 {
 if (objcc_WorkCorrectKeyWorkEN.FormatPara !=  null)
 {
 var strFormatPara = objcc_WorkCorrectKeyWorkEN.FormatPara.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FormatPara = '{0}',", strFormatPara); //格式化参数
 }
 else
 {
 sbSQL.Append(" FormatPara = null,"); //格式化参数
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.InOutTypeId))
 {
 if (objcc_WorkCorrectKeyWorkEN.InOutTypeId !=  null)
 {
 var strInOutTypeId = objcc_WorkCorrectKeyWorkEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InOutTypeId = '{0}',", strInOutTypeId); //InOut类型Id
 }
 else
 {
 sbSQL.Append(" InOutTypeId = null,"); //InOut类型Id
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.Creator))
 {
 if (objcc_WorkCorrectKeyWorkEN.Creator !=  null)
 {
 var strCreator = objcc_WorkCorrectKeyWorkEN.Creator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Creator = '{0}',", strCreator); //创建者
 }
 else
 {
 sbSQL.Append(" Creator = null,"); //创建者
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.CreateDate))
 {
 if (objcc_WorkCorrectKeyWorkEN.CreateDate !=  null)
 {
 var strCreateDate = objcc_WorkCorrectKeyWorkEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.IsEnable))
 {
 sbSQL.AppendFormat(" IsEnable = '{0}',", objcc_WorkCorrectKeyWorkEN.IsEnable == true?"1":"0"); //是否启用
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.UpdDate))
 {
 if (objcc_WorkCorrectKeyWorkEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_WorkCorrectKeyWorkEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.UpdUser))
 {
 if (objcc_WorkCorrectKeyWorkEN.UpdUser !=  null)
 {
 var strUpdUser = objcc_WorkCorrectKeyWorkEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.Memo))
 {
 if (objcc_WorkCorrectKeyWorkEN.Memo !=  null)
 {
 var strMemo = objcc_WorkCorrectKeyWorkEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcc_WorkCorrectKeyWorkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkCorrectKeyWorkEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_WorkCorrectKeyWorkEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_WorkCorrectKeyWork Set ");
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.QuestionID))
 {
 if (objcc_WorkCorrectKeyWorkEN.QuestionID !=  null)
 {
 var strQuestionID = objcc_WorkCorrectKeyWorkEN.QuestionID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionID = '{0}',", strQuestionID); //题目ID
 }
 else
 {
 sbSQL.Append(" QuestionID = null,"); //题目ID
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.KeyWorkIndex))
 {
 sbSQL.AppendFormat(" KeyWorkIndex = {0},", objcc_WorkCorrectKeyWorkEN.KeyWorkIndex); //关键字序号
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.CorrectKeyWork))
 {
 if (objcc_WorkCorrectKeyWorkEN.CorrectKeyWork !=  null)
 {
 var strCorrectKeyWork = objcc_WorkCorrectKeyWorkEN.CorrectKeyWork.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CorrectKeyWork = '{0}',", strCorrectKeyWork); //批改关键词
 }
 else
 {
 sbSQL.Append(" CorrectKeyWork = null,"); //批改关键词
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.IsUseFormatPara))
 {
 sbSQL.AppendFormat(" IsUseFormatPara = '{0}',", objcc_WorkCorrectKeyWorkEN.IsUseFormatPara == true?"1":"0"); //是否使用格式化参数
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.FormatPara))
 {
 if (objcc_WorkCorrectKeyWorkEN.FormatPara !=  null)
 {
 var strFormatPara = objcc_WorkCorrectKeyWorkEN.FormatPara.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FormatPara = '{0}',", strFormatPara); //格式化参数
 }
 else
 {
 sbSQL.Append(" FormatPara = null,"); //格式化参数
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.InOutTypeId))
 {
 if (objcc_WorkCorrectKeyWorkEN.InOutTypeId !=  null)
 {
 var strInOutTypeId = objcc_WorkCorrectKeyWorkEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InOutTypeId = '{0}',", strInOutTypeId); //InOut类型Id
 }
 else
 {
 sbSQL.Append(" InOutTypeId = null,"); //InOut类型Id
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.Creator))
 {
 if (objcc_WorkCorrectKeyWorkEN.Creator !=  null)
 {
 var strCreator = objcc_WorkCorrectKeyWorkEN.Creator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Creator = '{0}',", strCreator); //创建者
 }
 else
 {
 sbSQL.Append(" Creator = null,"); //创建者
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.CreateDate))
 {
 if (objcc_WorkCorrectKeyWorkEN.CreateDate !=  null)
 {
 var strCreateDate = objcc_WorkCorrectKeyWorkEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.IsEnable))
 {
 sbSQL.AppendFormat(" IsEnable = '{0}',", objcc_WorkCorrectKeyWorkEN.IsEnable == true?"1":"0"); //是否启用
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.UpdDate))
 {
 if (objcc_WorkCorrectKeyWorkEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_WorkCorrectKeyWorkEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.UpdUser))
 {
 if (objcc_WorkCorrectKeyWorkEN.UpdUser !=  null)
 {
 var strUpdUser = objcc_WorkCorrectKeyWorkEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.Memo))
 {
 if (objcc_WorkCorrectKeyWorkEN.Memo !=  null)
 {
 var strMemo = objcc_WorkCorrectKeyWorkEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_WorkCorrectKeyWorkEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcc_WorkCorrectKeyWorkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_WorkCorrectKeyWorkEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_WorkCorrectKeyWorkEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_WorkCorrectKeyWork Set ");
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.QuestionID))
 {
 if (objcc_WorkCorrectKeyWorkEN.QuestionID !=  null)
 {
 var strQuestionID = objcc_WorkCorrectKeyWorkEN.QuestionID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionID, concc_WorkCorrectKeyWork.QuestionID); //题目ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkCorrectKeyWork.QuestionID); //题目ID
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.KeyWorkIndex))
 {
 if (objcc_WorkCorrectKeyWorkEN.KeyWorkIndex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_WorkCorrectKeyWorkEN.KeyWorkIndex, concc_WorkCorrectKeyWork.KeyWorkIndex); //关键字序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkCorrectKeyWork.KeyWorkIndex); //关键字序号
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.CorrectKeyWork))
 {
 if (objcc_WorkCorrectKeyWorkEN.CorrectKeyWork !=  null)
 {
 var strCorrectKeyWork = objcc_WorkCorrectKeyWorkEN.CorrectKeyWork.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCorrectKeyWork, concc_WorkCorrectKeyWork.CorrectKeyWork); //批改关键词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkCorrectKeyWork.CorrectKeyWork); //批改关键词
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.IsUseFormatPara))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkCorrectKeyWorkEN.IsUseFormatPara == true?"1":"0", concc_WorkCorrectKeyWork.IsUseFormatPara); //是否使用格式化参数
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.FormatPara))
 {
 if (objcc_WorkCorrectKeyWorkEN.FormatPara !=  null)
 {
 var strFormatPara = objcc_WorkCorrectKeyWorkEN.FormatPara.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFormatPara, concc_WorkCorrectKeyWork.FormatPara); //格式化参数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkCorrectKeyWork.FormatPara); //格式化参数
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.InOutTypeId))
 {
 if (objcc_WorkCorrectKeyWorkEN.InOutTypeId !=  null)
 {
 var strInOutTypeId = objcc_WorkCorrectKeyWorkEN.InOutTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInOutTypeId, concc_WorkCorrectKeyWork.InOutTypeId); //InOut类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkCorrectKeyWork.InOutTypeId); //InOut类型Id
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.Creator))
 {
 if (objcc_WorkCorrectKeyWorkEN.Creator !=  null)
 {
 var strCreator = objcc_WorkCorrectKeyWorkEN.Creator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreator, concc_WorkCorrectKeyWork.Creator); //创建者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkCorrectKeyWork.Creator); //创建者
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.CreateDate))
 {
 if (objcc_WorkCorrectKeyWorkEN.CreateDate !=  null)
 {
 var strCreateDate = objcc_WorkCorrectKeyWorkEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, concc_WorkCorrectKeyWork.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkCorrectKeyWork.CreateDate); //建立日期
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.IsEnable))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_WorkCorrectKeyWorkEN.IsEnable == true?"1":"0", concc_WorkCorrectKeyWork.IsEnable); //是否启用
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.UpdDate))
 {
 if (objcc_WorkCorrectKeyWorkEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_WorkCorrectKeyWorkEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_WorkCorrectKeyWork.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkCorrectKeyWork.UpdDate); //修改日期
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.UpdUser))
 {
 if (objcc_WorkCorrectKeyWorkEN.UpdUser !=  null)
 {
 var strUpdUser = objcc_WorkCorrectKeyWorkEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, concc_WorkCorrectKeyWork.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkCorrectKeyWork.UpdUser); //修改人
 }
 }
 
 if (objcc_WorkCorrectKeyWorkEN.IsUpdated(concc_WorkCorrectKeyWork.Memo))
 {
 if (objcc_WorkCorrectKeyWorkEN.Memo !=  null)
 {
 var strMemo = objcc_WorkCorrectKeyWorkEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_WorkCorrectKeyWork.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_WorkCorrectKeyWork.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdWorkCorrectKeyWork = {0}", objcc_WorkCorrectKeyWorkEN.IdWorkCorrectKeyWork); 
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
 /// <param name = "lngIdWorkCorrectKeyWork">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngIdWorkCorrectKeyWork) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngIdWorkCorrectKeyWork,
};
 objSQL.ExecSP("cc_WorkCorrectKeyWork_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngIdWorkCorrectKeyWork">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngIdWorkCorrectKeyWork, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
//删除cc_WorkCorrectKeyWork本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_WorkCorrectKeyWork where IdWorkCorrectKeyWork = " + ""+ lngIdWorkCorrectKeyWork+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delcc_WorkCorrectKeyWork(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
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
//删除cc_WorkCorrectKeyWork本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_WorkCorrectKeyWork where IdWorkCorrectKeyWork in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngIdWorkCorrectKeyWork">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngIdWorkCorrectKeyWork) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
//删除cc_WorkCorrectKeyWork本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_WorkCorrectKeyWork where IdWorkCorrectKeyWork = " + ""+ lngIdWorkCorrectKeyWork+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delcc_WorkCorrectKeyWork(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clscc_WorkCorrectKeyWorkDA: Delcc_WorkCorrectKeyWork)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_WorkCorrectKeyWork where " + strCondition ;
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
public bool Delcc_WorkCorrectKeyWorkWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clscc_WorkCorrectKeyWorkDA: Delcc_WorkCorrectKeyWorkWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_WorkCorrectKeyWork where " + strCondition ;
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
 /// <param name = "objcc_WorkCorrectKeyWorkENS">源对象</param>
 /// <param name = "objcc_WorkCorrectKeyWorkENT">目标对象</param>
public void CopyTo(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkENS, clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkENT)
{
objcc_WorkCorrectKeyWorkENT.IdWorkCorrectKeyWork = objcc_WorkCorrectKeyWorkENS.IdWorkCorrectKeyWork; //作业批改关键词流水号
objcc_WorkCorrectKeyWorkENT.QuestionID = objcc_WorkCorrectKeyWorkENS.QuestionID; //题目ID
objcc_WorkCorrectKeyWorkENT.KeyWorkIndex = objcc_WorkCorrectKeyWorkENS.KeyWorkIndex; //关键字序号
objcc_WorkCorrectKeyWorkENT.CorrectKeyWork = objcc_WorkCorrectKeyWorkENS.CorrectKeyWork; //批改关键词
objcc_WorkCorrectKeyWorkENT.IsUseFormatPara = objcc_WorkCorrectKeyWorkENS.IsUseFormatPara; //是否使用格式化参数
objcc_WorkCorrectKeyWorkENT.FormatPara = objcc_WorkCorrectKeyWorkENS.FormatPara; //格式化参数
objcc_WorkCorrectKeyWorkENT.InOutTypeId = objcc_WorkCorrectKeyWorkENS.InOutTypeId; //InOut类型Id
objcc_WorkCorrectKeyWorkENT.Creator = objcc_WorkCorrectKeyWorkENS.Creator; //创建者
objcc_WorkCorrectKeyWorkENT.CreateDate = objcc_WorkCorrectKeyWorkENS.CreateDate; //建立日期
objcc_WorkCorrectKeyWorkENT.IsEnable = objcc_WorkCorrectKeyWorkENS.IsEnable; //是否启用
objcc_WorkCorrectKeyWorkENT.UpdDate = objcc_WorkCorrectKeyWorkENS.UpdDate; //修改日期
objcc_WorkCorrectKeyWorkENT.UpdUser = objcc_WorkCorrectKeyWorkENS.UpdUser; //修改人
objcc_WorkCorrectKeyWorkENT.Memo = objcc_WorkCorrectKeyWorkENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objcc_WorkCorrectKeyWorkEN.QuestionID, concc_WorkCorrectKeyWork.QuestionID);
clsCheckSql.CheckFieldNotNull(objcc_WorkCorrectKeyWorkEN.CorrectKeyWork, concc_WorkCorrectKeyWork.CorrectKeyWork);
clsCheckSql.CheckFieldNotNull(objcc_WorkCorrectKeyWorkEN.InOutTypeId, concc_WorkCorrectKeyWork.InOutTypeId);
clsCheckSql.CheckFieldNotNull(objcc_WorkCorrectKeyWorkEN.IsEnable, concc_WorkCorrectKeyWork.IsEnable);
clsCheckSql.CheckFieldNotNull(objcc_WorkCorrectKeyWorkEN.UpdDate, concc_WorkCorrectKeyWork.UpdDate);
clsCheckSql.CheckFieldNotNull(objcc_WorkCorrectKeyWorkEN.UpdUser, concc_WorkCorrectKeyWork.UpdUser);
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_WorkCorrectKeyWorkEN.QuestionID, 8, concc_WorkCorrectKeyWork.QuestionID);
clsCheckSql.CheckFieldLen(objcc_WorkCorrectKeyWorkEN.CorrectKeyWork, 200, concc_WorkCorrectKeyWork.CorrectKeyWork);
clsCheckSql.CheckFieldLen(objcc_WorkCorrectKeyWorkEN.FormatPara, 100, concc_WorkCorrectKeyWork.FormatPara);
clsCheckSql.CheckFieldLen(objcc_WorkCorrectKeyWorkEN.InOutTypeId, 2, concc_WorkCorrectKeyWork.InOutTypeId);
clsCheckSql.CheckFieldLen(objcc_WorkCorrectKeyWorkEN.Creator, 18, concc_WorkCorrectKeyWork.Creator);
clsCheckSql.CheckFieldLen(objcc_WorkCorrectKeyWorkEN.CreateDate, 20, concc_WorkCorrectKeyWork.CreateDate);
clsCheckSql.CheckFieldLen(objcc_WorkCorrectKeyWorkEN.UpdDate, 20, concc_WorkCorrectKeyWork.UpdDate);
clsCheckSql.CheckFieldLen(objcc_WorkCorrectKeyWorkEN.UpdUser, 20, concc_WorkCorrectKeyWork.UpdUser);
clsCheckSql.CheckFieldLen(objcc_WorkCorrectKeyWorkEN.Memo, 1000, concc_WorkCorrectKeyWork.Memo);
//检查字段外键固定长度
 objcc_WorkCorrectKeyWorkEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_WorkCorrectKeyWorkEN.QuestionID, 8, concc_WorkCorrectKeyWork.QuestionID);
clsCheckSql.CheckFieldLen(objcc_WorkCorrectKeyWorkEN.CorrectKeyWork, 200, concc_WorkCorrectKeyWork.CorrectKeyWork);
clsCheckSql.CheckFieldLen(objcc_WorkCorrectKeyWorkEN.FormatPara, 100, concc_WorkCorrectKeyWork.FormatPara);
clsCheckSql.CheckFieldLen(objcc_WorkCorrectKeyWorkEN.InOutTypeId, 2, concc_WorkCorrectKeyWork.InOutTypeId);
clsCheckSql.CheckFieldLen(objcc_WorkCorrectKeyWorkEN.Creator, 18, concc_WorkCorrectKeyWork.Creator);
clsCheckSql.CheckFieldLen(objcc_WorkCorrectKeyWorkEN.CreateDate, 20, concc_WorkCorrectKeyWork.CreateDate);
clsCheckSql.CheckFieldLen(objcc_WorkCorrectKeyWorkEN.UpdDate, 20, concc_WorkCorrectKeyWork.UpdDate);
clsCheckSql.CheckFieldLen(objcc_WorkCorrectKeyWorkEN.UpdUser, 20, concc_WorkCorrectKeyWork.UpdUser);
clsCheckSql.CheckFieldLen(objcc_WorkCorrectKeyWorkEN.Memo, 1000, concc_WorkCorrectKeyWork.Memo);
//检查外键字段长度
 objcc_WorkCorrectKeyWorkEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_WorkCorrectKeyWorkEN.QuestionID, 8, concc_WorkCorrectKeyWork.QuestionID);
clsCheckSql.CheckFieldLen(objcc_WorkCorrectKeyWorkEN.CorrectKeyWork, 200, concc_WorkCorrectKeyWork.CorrectKeyWork);
clsCheckSql.CheckFieldLen(objcc_WorkCorrectKeyWorkEN.FormatPara, 100, concc_WorkCorrectKeyWork.FormatPara);
clsCheckSql.CheckFieldLen(objcc_WorkCorrectKeyWorkEN.InOutTypeId, 2, concc_WorkCorrectKeyWork.InOutTypeId);
clsCheckSql.CheckFieldLen(objcc_WorkCorrectKeyWorkEN.Creator, 18, concc_WorkCorrectKeyWork.Creator);
clsCheckSql.CheckFieldLen(objcc_WorkCorrectKeyWorkEN.CreateDate, 20, concc_WorkCorrectKeyWork.CreateDate);
clsCheckSql.CheckFieldLen(objcc_WorkCorrectKeyWorkEN.UpdDate, 20, concc_WorkCorrectKeyWork.UpdDate);
clsCheckSql.CheckFieldLen(objcc_WorkCorrectKeyWorkEN.UpdUser, 20, concc_WorkCorrectKeyWork.UpdUser);
clsCheckSql.CheckFieldLen(objcc_WorkCorrectKeyWorkEN.Memo, 1000, concc_WorkCorrectKeyWork.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objcc_WorkCorrectKeyWorkEN.QuestionID, concc_WorkCorrectKeyWork.QuestionID);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkCorrectKeyWorkEN.CorrectKeyWork, concc_WorkCorrectKeyWork.CorrectKeyWork);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkCorrectKeyWorkEN.FormatPara, concc_WorkCorrectKeyWork.FormatPara);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkCorrectKeyWorkEN.InOutTypeId, concc_WorkCorrectKeyWork.InOutTypeId);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkCorrectKeyWorkEN.Creator, concc_WorkCorrectKeyWork.Creator);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkCorrectKeyWorkEN.CreateDate, concc_WorkCorrectKeyWork.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkCorrectKeyWorkEN.UpdDate, concc_WorkCorrectKeyWork.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkCorrectKeyWorkEN.UpdUser, concc_WorkCorrectKeyWork.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objcc_WorkCorrectKeyWorkEN.Memo, concc_WorkCorrectKeyWork.Memo);
//检查外键字段长度
 objcc_WorkCorrectKeyWorkEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--cc_WorkCorrectKeyWork(作业批改关键词),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_WorkCorrectKeyWorkEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clscc_WorkCorrectKeyWorkEN objcc_WorkCorrectKeyWorkEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objcc_WorkCorrectKeyWorkEN.QuestionID);
 sbCondition.AppendFormat(" and CorrectKeyWork = '{0}'", objcc_WorkCorrectKeyWorkEN.CorrectKeyWork);
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
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
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
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
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
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_WorkCorrectKeyWorkEN._CurrTabName);
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
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_WorkCorrectKeyWorkEN._CurrTabName, strCondition);
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
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
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
 objSQL = clscc_WorkCorrectKeyWorkDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}