
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperReadWriteDA
 表名:vPaperReadWrite(01120550)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:04:45
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
 /// v论文读写表(vPaperReadWrite)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvPaperReadWriteDA : clsCommBase4DA
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
 return clsvPaperReadWriteEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvPaperReadWriteEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPaperReadWriteEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvPaperReadWriteEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvPaperReadWriteEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strPaperRWId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strPaperRWId)
{
strPaperRWId = strPaperRWId.Replace("'", "''");
if (strPaperRWId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vPaperReadWrite中,检查关键字,长度不正确!(clsvPaperReadWriteDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strPaperRWId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vPaperReadWrite中,关键字不能为空 或 null!(clsvPaperReadWriteDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPaperRWId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvPaperReadWriteDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPaperReadWriteDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperReadWriteDA.GetSpecSQLObj();
strSQL = "Select * from vPaperReadWrite where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vPaperReadWrite(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvPaperReadWriteDA: GetDataTable_vPaperReadWrite)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperReadWriteDA.GetSpecSQLObj();
strSQL = "Select * from vPaperReadWrite where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvPaperReadWriteDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperReadWriteDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvPaperReadWriteDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperReadWriteDA.GetSpecSQLObj();
strSQL = "Select * from vPaperReadWrite where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvPaperReadWriteDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperReadWriteDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvPaperReadWriteDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperReadWriteDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPaperReadWrite where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPaperReadWrite where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvPaperReadWriteDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperReadWriteDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vPaperReadWrite where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvPaperReadWriteDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperReadWriteDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPaperReadWrite.* from vPaperReadWrite Left Join {1} on {2} where {3} and vPaperReadWrite.PaperRWId not in (Select top {5} vPaperReadWrite.PaperRWId from vPaperReadWrite Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPaperReadWrite where {1} and PaperRWId not in (Select top {2} PaperRWId from vPaperReadWrite where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPaperReadWrite where {1} and PaperRWId not in (Select top {3} PaperRWId from vPaperReadWrite where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvPaperReadWriteDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperReadWriteDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPaperReadWrite.* from vPaperReadWrite Left Join {1} on {2} where {3} and vPaperReadWrite.PaperRWId not in (Select top {5} vPaperReadWrite.PaperRWId from vPaperReadWrite Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPaperReadWrite where {1} and PaperRWId not in (Select top {2} PaperRWId from vPaperReadWrite where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPaperReadWrite where {1} and PaperRWId not in (Select top {3} PaperRWId from vPaperReadWrite where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvPaperReadWriteEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvPaperReadWriteDA:GetObjLst)", objException.Message));
}
List<clsvPaperReadWriteEN> arrObjLst = new List<clsvPaperReadWriteEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperReadWriteDA.GetSpecSQLObj();
strSQL = "Select * from vPaperReadWrite where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperReadWriteEN objvPaperReadWriteEN = new clsvPaperReadWriteEN();
try
{
objvPaperReadWriteEN.PaperRWId = objRow[convPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读
objvPaperReadWriteEN.ReaderId = objRow[convPaperReadWrite.ReaderId] == DBNull.Value ? null : objRow[convPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id
objvPaperReadWriteEN.PaperId = objRow[convPaperReadWrite.PaperId] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperId].ToString().Trim(); //论文Id
objvPaperReadWriteEN.PaperTitle = objRow[convPaperReadWrite.PaperTitle] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperTitle].ToString().Trim(); //论文标题
objvPaperReadWriteEN.PaperContent = objRow[convPaperReadWrite.PaperContent] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperContent].ToString().Trim(); //主题内容
objvPaperReadWriteEN.Periodical = objRow[convPaperReadWrite.Periodical] == DBNull.Value ? null : objRow[convPaperReadWrite.Periodical].ToString().Trim(); //期刊
objvPaperReadWriteEN.Author = objRow[convPaperReadWrite.Author] == DBNull.Value ? null : objRow[convPaperReadWrite.Author].ToString().Trim(); //作者
objvPaperReadWriteEN.Keyword = objRow[convPaperReadWrite.Keyword] == DBNull.Value ? null : objRow[convPaperReadWrite.Keyword].ToString().Trim(); //关键字
objvPaperReadWriteEN.ResearchQuestion = objRow[convPaperReadWrite.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperReadWriteEN.OperationTypeId = objRow[convPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID
objvPaperReadWriteEN.OperationTypeName = objRow[convPaperReadWrite.OperationTypeName].ToString().Trim(); //操作类型名
objvPaperReadWriteEN.UpdDate = objRow[convPaperReadWrite.UpdDate] == DBNull.Value ? null : objRow[convPaperReadWrite.UpdDate].ToString().Trim(); //修改日期
objvPaperReadWriteEN.Memo = objRow[convPaperReadWrite.Memo] == DBNull.Value ? null : objRow[convPaperReadWrite.Memo].ToString().Trim(); //备注
objvPaperReadWriteEN.LiteratureLink = objRow[convPaperReadWrite.LiteratureLink] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureLink].ToString().Trim(); //文献链接
objvPaperReadWriteEN.LiteratureSources = objRow[convPaperReadWrite.LiteratureSources] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureSources].ToString().Trim(); //文献来源
objvPaperReadWriteEN.LiteratureTypeId = objRow[convPaperReadWrite.LiteratureTypeId] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperReadWriteEN.LiteratureTypeName = objRow[convPaperReadWrite.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperReadWriteEN.UploadfileUrl = objRow[convPaperReadWrite.UploadfileUrl] == DBNull.Value ? null : objRow[convPaperReadWrite.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperReadWriteEN.IsPublic = TransNullToBool(objRow[convPaperReadWrite.IsPublic].ToString().Trim()); //是否公开
objvPaperReadWriteEN.IsSubmit = TransNullToBool(objRow[convPaperReadWrite.IsSubmit].ToString().Trim()); //是否提交
objvPaperReadWriteEN.Submitter = objRow[convPaperReadWrite.Submitter] == DBNull.Value ? null : objRow[convPaperReadWrite.Submitter].ToString().Trim(); //提交人
objvPaperReadWriteEN.Pcount = objRow[convPaperReadWrite.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperReadWrite.Pcount].ToString().Trim()); //读写数
objvPaperReadWriteEN.TeaCount = objRow[convPaperReadWrite.TeaCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperReadWrite.TeaCount].ToString().Trim()); //TeaCount
objvPaperReadWriteEN.IdCurrEduCls = objRow[convPaperReadWrite.IdCurrEduCls] == DBNull.Value ? null : objRow[convPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperReadWriteEN.SubVCount = objRow[convPaperReadWrite.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperReadWrite.SubVCount].ToString().Trim()); //论文子观点数
objvPaperReadWriteEN.CreateDate = objRow[convPaperReadWrite.CreateDate] == DBNull.Value ? null : objRow[convPaperReadWrite.CreateDate].ToString().Trim(); //建立日期
objvPaperReadWriteEN.ShareId = objRow[convPaperReadWrite.ShareId] == DBNull.Value ? null : objRow[convPaperReadWrite.ShareId].ToString().Trim(); //分享Id
objvPaperReadWriteEN.UpdUser = objRow[convPaperReadWrite.UpdUser] == DBNull.Value ? null : objRow[convPaperReadWrite.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPaperReadWriteDA: GetObjLst)", objException.Message));
}
objvPaperReadWriteEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPaperReadWriteEN);
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
public List<clsvPaperReadWriteEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvPaperReadWriteDA:GetObjLstByTabName)", objException.Message));
}
List<clsvPaperReadWriteEN> arrObjLst = new List<clsvPaperReadWriteEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperReadWriteDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperReadWriteEN objvPaperReadWriteEN = new clsvPaperReadWriteEN();
try
{
objvPaperReadWriteEN.PaperRWId = objRow[convPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读
objvPaperReadWriteEN.ReaderId = objRow[convPaperReadWrite.ReaderId] == DBNull.Value ? null : objRow[convPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id
objvPaperReadWriteEN.PaperId = objRow[convPaperReadWrite.PaperId] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperId].ToString().Trim(); //论文Id
objvPaperReadWriteEN.PaperTitle = objRow[convPaperReadWrite.PaperTitle] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperTitle].ToString().Trim(); //论文标题
objvPaperReadWriteEN.PaperContent = objRow[convPaperReadWrite.PaperContent] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperContent].ToString().Trim(); //主题内容
objvPaperReadWriteEN.Periodical = objRow[convPaperReadWrite.Periodical] == DBNull.Value ? null : objRow[convPaperReadWrite.Periodical].ToString().Trim(); //期刊
objvPaperReadWriteEN.Author = objRow[convPaperReadWrite.Author] == DBNull.Value ? null : objRow[convPaperReadWrite.Author].ToString().Trim(); //作者
objvPaperReadWriteEN.Keyword = objRow[convPaperReadWrite.Keyword] == DBNull.Value ? null : objRow[convPaperReadWrite.Keyword].ToString().Trim(); //关键字
objvPaperReadWriteEN.ResearchQuestion = objRow[convPaperReadWrite.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperReadWriteEN.OperationTypeId = objRow[convPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID
objvPaperReadWriteEN.OperationTypeName = objRow[convPaperReadWrite.OperationTypeName].ToString().Trim(); //操作类型名
objvPaperReadWriteEN.UpdDate = objRow[convPaperReadWrite.UpdDate] == DBNull.Value ? null : objRow[convPaperReadWrite.UpdDate].ToString().Trim(); //修改日期
objvPaperReadWriteEN.Memo = objRow[convPaperReadWrite.Memo] == DBNull.Value ? null : objRow[convPaperReadWrite.Memo].ToString().Trim(); //备注
objvPaperReadWriteEN.LiteratureLink = objRow[convPaperReadWrite.LiteratureLink] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureLink].ToString().Trim(); //文献链接
objvPaperReadWriteEN.LiteratureSources = objRow[convPaperReadWrite.LiteratureSources] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureSources].ToString().Trim(); //文献来源
objvPaperReadWriteEN.LiteratureTypeId = objRow[convPaperReadWrite.LiteratureTypeId] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperReadWriteEN.LiteratureTypeName = objRow[convPaperReadWrite.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperReadWriteEN.UploadfileUrl = objRow[convPaperReadWrite.UploadfileUrl] == DBNull.Value ? null : objRow[convPaperReadWrite.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperReadWriteEN.IsPublic = TransNullToBool(objRow[convPaperReadWrite.IsPublic].ToString().Trim()); //是否公开
objvPaperReadWriteEN.IsSubmit = TransNullToBool(objRow[convPaperReadWrite.IsSubmit].ToString().Trim()); //是否提交
objvPaperReadWriteEN.Submitter = objRow[convPaperReadWrite.Submitter] == DBNull.Value ? null : objRow[convPaperReadWrite.Submitter].ToString().Trim(); //提交人
objvPaperReadWriteEN.Pcount = objRow[convPaperReadWrite.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperReadWrite.Pcount].ToString().Trim()); //读写数
objvPaperReadWriteEN.TeaCount = objRow[convPaperReadWrite.TeaCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperReadWrite.TeaCount].ToString().Trim()); //TeaCount
objvPaperReadWriteEN.IdCurrEduCls = objRow[convPaperReadWrite.IdCurrEduCls] == DBNull.Value ? null : objRow[convPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperReadWriteEN.SubVCount = objRow[convPaperReadWrite.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperReadWrite.SubVCount].ToString().Trim()); //论文子观点数
objvPaperReadWriteEN.CreateDate = objRow[convPaperReadWrite.CreateDate] == DBNull.Value ? null : objRow[convPaperReadWrite.CreateDate].ToString().Trim(); //建立日期
objvPaperReadWriteEN.ShareId = objRow[convPaperReadWrite.ShareId] == DBNull.Value ? null : objRow[convPaperReadWrite.ShareId].ToString().Trim(); //分享Id
objvPaperReadWriteEN.UpdUser = objRow[convPaperReadWrite.UpdUser] == DBNull.Value ? null : objRow[convPaperReadWrite.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPaperReadWriteDA: GetObjLst)", objException.Message));
}
objvPaperReadWriteEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPaperReadWriteEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvPaperReadWriteEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvPaperReadWrite(ref clsvPaperReadWriteEN objvPaperReadWriteEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperReadWriteDA.GetSpecSQLObj();
strSQL = "Select * from vPaperReadWrite where PaperRWId = " + "'"+ objvPaperReadWriteEN.PaperRWId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvPaperReadWriteEN.PaperRWId = objDT.Rows[0][convPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读(字段类型:char,字段长度:8,是否可空:True)
 objvPaperReadWriteEN.ReaderId = objDT.Rows[0][convPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperReadWriteEN.PaperId = objDT.Rows[0][convPaperReadWrite.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvPaperReadWriteEN.PaperTitle = objDT.Rows[0][convPaperReadWrite.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvPaperReadWriteEN.PaperContent = objDT.Rows[0][convPaperReadWrite.PaperContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvPaperReadWriteEN.Periodical = objDT.Rows[0][convPaperReadWrite.Periodical].ToString().Trim(); //期刊(字段类型:varchar,字段长度:100,是否可空:True)
 objvPaperReadWriteEN.Author = objDT.Rows[0][convPaperReadWrite.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvPaperReadWriteEN.Keyword = objDT.Rows[0][convPaperReadWrite.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperReadWriteEN.ResearchQuestion = objDT.Rows[0][convPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objvPaperReadWriteEN.OperationTypeId = objDT.Rows[0][convPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvPaperReadWriteEN.OperationTypeName = objDT.Rows[0][convPaperReadWrite.OperationTypeName].ToString().Trim(); //操作类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvPaperReadWriteEN.UpdDate = objDT.Rows[0][convPaperReadWrite.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperReadWriteEN.Memo = objDT.Rows[0][convPaperReadWrite.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperReadWriteEN.LiteratureLink = objDT.Rows[0][convPaperReadWrite.LiteratureLink].ToString().Trim(); //文献链接(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperReadWriteEN.LiteratureSources = objDT.Rows[0][convPaperReadWrite.LiteratureSources].ToString().Trim(); //文献来源(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperReadWriteEN.LiteratureTypeId = objDT.Rows[0][convPaperReadWrite.LiteratureTypeId].ToString().Trim(); //作文类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvPaperReadWriteEN.LiteratureTypeName = objDT.Rows[0][convPaperReadWrite.LiteratureTypeName].ToString().Trim(); //作文类型名(字段类型:varchar,字段长度:100,是否可空:True)
 objvPaperReadWriteEN.UploadfileUrl = objDT.Rows[0][convPaperReadWrite.UploadfileUrl].ToString().Trim(); //文件地址(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperReadWriteEN.IsPublic = TransNullToBool(objDT.Rows[0][convPaperReadWrite.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvPaperReadWriteEN.IsSubmit = TransNullToBool(objDT.Rows[0][convPaperReadWrite.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvPaperReadWriteEN.Submitter = objDT.Rows[0][convPaperReadWrite.Submitter].ToString().Trim(); //提交人(字段类型:varchar,字段长度:50,是否可空:True)
 objvPaperReadWriteEN.Pcount = TransNullToInt(objDT.Rows[0][convPaperReadWrite.Pcount].ToString().Trim()); //读写数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperReadWriteEN.TeaCount = TransNullToInt(objDT.Rows[0][convPaperReadWrite.TeaCount].ToString().Trim()); //TeaCount(字段类型:int,字段长度:4,是否可空:True)
 objvPaperReadWriteEN.IdCurrEduCls = objDT.Rows[0][convPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPaperReadWriteEN.SubVCount = TransNullToInt(objDT.Rows[0][convPaperReadWrite.SubVCount].ToString().Trim()); //论文子观点数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperReadWriteEN.CreateDate = objDT.Rows[0][convPaperReadWrite.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperReadWriteEN.ShareId = objDT.Rows[0][convPaperReadWrite.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvPaperReadWriteEN.UpdUser = objDT.Rows[0][convPaperReadWrite.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvPaperReadWriteDA: GetvPaperReadWrite)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPaperRWId">表关键字</param>
 /// <returns>表对象</returns>
public clsvPaperReadWriteEN GetObjByPaperRWId(string strPaperRWId)
{
CheckPrimaryKey(strPaperRWId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperReadWriteDA.GetSpecSQLObj();
strSQL = "Select * from vPaperReadWrite where PaperRWId = " + "'"+ strPaperRWId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvPaperReadWriteEN objvPaperReadWriteEN = new clsvPaperReadWriteEN();
try
{
 objvPaperReadWriteEN.PaperRWId = objRow[convPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读(字段类型:char,字段长度:8,是否可空:True)
 objvPaperReadWriteEN.ReaderId = objRow[convPaperReadWrite.ReaderId] == DBNull.Value ? null : objRow[convPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperReadWriteEN.PaperId = objRow[convPaperReadWrite.PaperId] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvPaperReadWriteEN.PaperTitle = objRow[convPaperReadWrite.PaperTitle] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvPaperReadWriteEN.PaperContent = objRow[convPaperReadWrite.PaperContent] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvPaperReadWriteEN.Periodical = objRow[convPaperReadWrite.Periodical] == DBNull.Value ? null : objRow[convPaperReadWrite.Periodical].ToString().Trim(); //期刊(字段类型:varchar,字段长度:100,是否可空:True)
 objvPaperReadWriteEN.Author = objRow[convPaperReadWrite.Author] == DBNull.Value ? null : objRow[convPaperReadWrite.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvPaperReadWriteEN.Keyword = objRow[convPaperReadWrite.Keyword] == DBNull.Value ? null : objRow[convPaperReadWrite.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperReadWriteEN.ResearchQuestion = objRow[convPaperReadWrite.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objvPaperReadWriteEN.OperationTypeId = objRow[convPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvPaperReadWriteEN.OperationTypeName = objRow[convPaperReadWrite.OperationTypeName].ToString().Trim(); //操作类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvPaperReadWriteEN.UpdDate = objRow[convPaperReadWrite.UpdDate] == DBNull.Value ? null : objRow[convPaperReadWrite.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperReadWriteEN.Memo = objRow[convPaperReadWrite.Memo] == DBNull.Value ? null : objRow[convPaperReadWrite.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperReadWriteEN.LiteratureLink = objRow[convPaperReadWrite.LiteratureLink] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureLink].ToString().Trim(); //文献链接(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperReadWriteEN.LiteratureSources = objRow[convPaperReadWrite.LiteratureSources] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureSources].ToString().Trim(); //文献来源(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperReadWriteEN.LiteratureTypeId = objRow[convPaperReadWrite.LiteratureTypeId] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureTypeId].ToString().Trim(); //作文类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvPaperReadWriteEN.LiteratureTypeName = objRow[convPaperReadWrite.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureTypeName].ToString().Trim(); //作文类型名(字段类型:varchar,字段长度:100,是否可空:True)
 objvPaperReadWriteEN.UploadfileUrl = objRow[convPaperReadWrite.UploadfileUrl] == DBNull.Value ? null : objRow[convPaperReadWrite.UploadfileUrl].ToString().Trim(); //文件地址(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPaperReadWriteEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaperReadWrite.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvPaperReadWriteEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperReadWrite.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvPaperReadWriteEN.Submitter = objRow[convPaperReadWrite.Submitter] == DBNull.Value ? null : objRow[convPaperReadWrite.Submitter].ToString().Trim(); //提交人(字段类型:varchar,字段长度:50,是否可空:True)
 objvPaperReadWriteEN.Pcount = objRow[convPaperReadWrite.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.Pcount].ToString().Trim()); //读写数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperReadWriteEN.TeaCount = objRow[convPaperReadWrite.TeaCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.TeaCount].ToString().Trim()); //TeaCount(字段类型:int,字段长度:4,是否可空:True)
 objvPaperReadWriteEN.IdCurrEduCls = objRow[convPaperReadWrite.IdCurrEduCls] == DBNull.Value ? null : objRow[convPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPaperReadWriteEN.SubVCount = objRow[convPaperReadWrite.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.SubVCount].ToString().Trim()); //论文子观点数(字段类型:int,字段长度:4,是否可空:True)
 objvPaperReadWriteEN.CreateDate = objRow[convPaperReadWrite.CreateDate] == DBNull.Value ? null : objRow[convPaperReadWrite.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPaperReadWriteEN.ShareId = objRow[convPaperReadWrite.ShareId] == DBNull.Value ? null : objRow[convPaperReadWrite.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvPaperReadWriteEN.UpdUser = objRow[convPaperReadWrite.UpdUser] == DBNull.Value ? null : objRow[convPaperReadWrite.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvPaperReadWriteDA: GetObjByPaperRWId)", objException.Message));
}
return objvPaperReadWriteEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvPaperReadWriteEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvPaperReadWriteDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperReadWriteDA.GetSpecSQLObj();
strSQL = "Select * from vPaperReadWrite where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvPaperReadWriteEN objvPaperReadWriteEN = new clsvPaperReadWriteEN()
{
PaperRWId = objRow[convPaperReadWrite.PaperRWId].ToString().Trim(), //课文阅读
ReaderId = objRow[convPaperReadWrite.ReaderId] == DBNull.Value ? null : objRow[convPaperReadWrite.ReaderId].ToString().Trim(), //阅读者Id
PaperId = objRow[convPaperReadWrite.PaperId] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperId].ToString().Trim(), //论文Id
PaperTitle = objRow[convPaperReadWrite.PaperTitle] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperTitle].ToString().Trim(), //论文标题
PaperContent = objRow[convPaperReadWrite.PaperContent] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperContent].ToString().Trim(), //主题内容
Periodical = objRow[convPaperReadWrite.Periodical] == DBNull.Value ? null : objRow[convPaperReadWrite.Periodical].ToString().Trim(), //期刊
Author = objRow[convPaperReadWrite.Author] == DBNull.Value ? null : objRow[convPaperReadWrite.Author].ToString().Trim(), //作者
Keyword = objRow[convPaperReadWrite.Keyword] == DBNull.Value ? null : objRow[convPaperReadWrite.Keyword].ToString().Trim(), //关键字
ResearchQuestion = objRow[convPaperReadWrite.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperReadWrite.ResearchQuestion].ToString().Trim(), //研究问题
OperationTypeId = objRow[convPaperReadWrite.OperationTypeId].ToString().Trim(), //操作类型ID
OperationTypeName = objRow[convPaperReadWrite.OperationTypeName].ToString().Trim(), //操作类型名
UpdDate = objRow[convPaperReadWrite.UpdDate] == DBNull.Value ? null : objRow[convPaperReadWrite.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convPaperReadWrite.Memo] == DBNull.Value ? null : objRow[convPaperReadWrite.Memo].ToString().Trim(), //备注
LiteratureLink = objRow[convPaperReadWrite.LiteratureLink] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureLink].ToString().Trim(), //文献链接
LiteratureSources = objRow[convPaperReadWrite.LiteratureSources] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureSources].ToString().Trim(), //文献来源
LiteratureTypeId = objRow[convPaperReadWrite.LiteratureTypeId] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureTypeId].ToString().Trim(), //作文类型Id
LiteratureTypeName = objRow[convPaperReadWrite.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureTypeName].ToString().Trim(), //作文类型名
UploadfileUrl = objRow[convPaperReadWrite.UploadfileUrl] == DBNull.Value ? null : objRow[convPaperReadWrite.UploadfileUrl].ToString().Trim(), //文件地址
IsPublic = TransNullToBool(objRow[convPaperReadWrite.IsPublic].ToString().Trim()), //是否公开
IsSubmit = TransNullToBool(objRow[convPaperReadWrite.IsSubmit].ToString().Trim()), //是否提交
Submitter = objRow[convPaperReadWrite.Submitter] == DBNull.Value ? null : objRow[convPaperReadWrite.Submitter].ToString().Trim(), //提交人
Pcount = objRow[convPaperReadWrite.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperReadWrite.Pcount].ToString().Trim()), //读写数
TeaCount = objRow[convPaperReadWrite.TeaCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperReadWrite.TeaCount].ToString().Trim()), //TeaCount
IdCurrEduCls = objRow[convPaperReadWrite.IdCurrEduCls] == DBNull.Value ? null : objRow[convPaperReadWrite.IdCurrEduCls].ToString().Trim(), //教学班流水号
SubVCount = objRow[convPaperReadWrite.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperReadWrite.SubVCount].ToString().Trim()), //论文子观点数
CreateDate = objRow[convPaperReadWrite.CreateDate] == DBNull.Value ? null : objRow[convPaperReadWrite.CreateDate].ToString().Trim(), //建立日期
ShareId = objRow[convPaperReadWrite.ShareId] == DBNull.Value ? null : objRow[convPaperReadWrite.ShareId].ToString().Trim(), //分享Id
UpdUser = objRow[convPaperReadWrite.UpdUser] == DBNull.Value ? null : objRow[convPaperReadWrite.UpdUser].ToString().Trim() //修改人
};
objvPaperReadWriteEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPaperReadWriteEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvPaperReadWriteDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvPaperReadWriteEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPaperReadWriteEN objvPaperReadWriteEN = new clsvPaperReadWriteEN();
try
{
objvPaperReadWriteEN.PaperRWId = objRow[convPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读
objvPaperReadWriteEN.ReaderId = objRow[convPaperReadWrite.ReaderId] == DBNull.Value ? null : objRow[convPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id
objvPaperReadWriteEN.PaperId = objRow[convPaperReadWrite.PaperId] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperId].ToString().Trim(); //论文Id
objvPaperReadWriteEN.PaperTitle = objRow[convPaperReadWrite.PaperTitle] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperTitle].ToString().Trim(); //论文标题
objvPaperReadWriteEN.PaperContent = objRow[convPaperReadWrite.PaperContent] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperContent].ToString().Trim(); //主题内容
objvPaperReadWriteEN.Periodical = objRow[convPaperReadWrite.Periodical] == DBNull.Value ? null : objRow[convPaperReadWrite.Periodical].ToString().Trim(); //期刊
objvPaperReadWriteEN.Author = objRow[convPaperReadWrite.Author] == DBNull.Value ? null : objRow[convPaperReadWrite.Author].ToString().Trim(); //作者
objvPaperReadWriteEN.Keyword = objRow[convPaperReadWrite.Keyword] == DBNull.Value ? null : objRow[convPaperReadWrite.Keyword].ToString().Trim(); //关键字
objvPaperReadWriteEN.ResearchQuestion = objRow[convPaperReadWrite.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperReadWriteEN.OperationTypeId = objRow[convPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID
objvPaperReadWriteEN.OperationTypeName = objRow[convPaperReadWrite.OperationTypeName].ToString().Trim(); //操作类型名
objvPaperReadWriteEN.UpdDate = objRow[convPaperReadWrite.UpdDate] == DBNull.Value ? null : objRow[convPaperReadWrite.UpdDate].ToString().Trim(); //修改日期
objvPaperReadWriteEN.Memo = objRow[convPaperReadWrite.Memo] == DBNull.Value ? null : objRow[convPaperReadWrite.Memo].ToString().Trim(); //备注
objvPaperReadWriteEN.LiteratureLink = objRow[convPaperReadWrite.LiteratureLink] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureLink].ToString().Trim(); //文献链接
objvPaperReadWriteEN.LiteratureSources = objRow[convPaperReadWrite.LiteratureSources] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureSources].ToString().Trim(); //文献来源
objvPaperReadWriteEN.LiteratureTypeId = objRow[convPaperReadWrite.LiteratureTypeId] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperReadWriteEN.LiteratureTypeName = objRow[convPaperReadWrite.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperReadWriteEN.UploadfileUrl = objRow[convPaperReadWrite.UploadfileUrl] == DBNull.Value ? null : objRow[convPaperReadWrite.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperReadWriteEN.IsPublic = TransNullToBool(objRow[convPaperReadWrite.IsPublic].ToString().Trim()); //是否公开
objvPaperReadWriteEN.IsSubmit = TransNullToBool(objRow[convPaperReadWrite.IsSubmit].ToString().Trim()); //是否提交
objvPaperReadWriteEN.Submitter = objRow[convPaperReadWrite.Submitter] == DBNull.Value ? null : objRow[convPaperReadWrite.Submitter].ToString().Trim(); //提交人
objvPaperReadWriteEN.Pcount = objRow[convPaperReadWrite.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperReadWrite.Pcount].ToString().Trim()); //读写数
objvPaperReadWriteEN.TeaCount = objRow[convPaperReadWrite.TeaCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperReadWrite.TeaCount].ToString().Trim()); //TeaCount
objvPaperReadWriteEN.IdCurrEduCls = objRow[convPaperReadWrite.IdCurrEduCls] == DBNull.Value ? null : objRow[convPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperReadWriteEN.SubVCount = objRow[convPaperReadWrite.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperReadWrite.SubVCount].ToString().Trim()); //论文子观点数
objvPaperReadWriteEN.CreateDate = objRow[convPaperReadWrite.CreateDate] == DBNull.Value ? null : objRow[convPaperReadWrite.CreateDate].ToString().Trim(); //建立日期
objvPaperReadWriteEN.ShareId = objRow[convPaperReadWrite.ShareId] == DBNull.Value ? null : objRow[convPaperReadWrite.ShareId].ToString().Trim(); //分享Id
objvPaperReadWriteEN.UpdUser = objRow[convPaperReadWrite.UpdUser] == DBNull.Value ? null : objRow[convPaperReadWrite.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvPaperReadWriteDA: GetObjByDataRowvPaperReadWrite)", objException.Message));
}
objvPaperReadWriteEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPaperReadWriteEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvPaperReadWriteEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPaperReadWriteEN objvPaperReadWriteEN = new clsvPaperReadWriteEN();
try
{
objvPaperReadWriteEN.PaperRWId = objRow[convPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读
objvPaperReadWriteEN.ReaderId = objRow[convPaperReadWrite.ReaderId] == DBNull.Value ? null : objRow[convPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id
objvPaperReadWriteEN.PaperId = objRow[convPaperReadWrite.PaperId] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperId].ToString().Trim(); //论文Id
objvPaperReadWriteEN.PaperTitle = objRow[convPaperReadWrite.PaperTitle] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperTitle].ToString().Trim(); //论文标题
objvPaperReadWriteEN.PaperContent = objRow[convPaperReadWrite.PaperContent] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperContent].ToString().Trim(); //主题内容
objvPaperReadWriteEN.Periodical = objRow[convPaperReadWrite.Periodical] == DBNull.Value ? null : objRow[convPaperReadWrite.Periodical].ToString().Trim(); //期刊
objvPaperReadWriteEN.Author = objRow[convPaperReadWrite.Author] == DBNull.Value ? null : objRow[convPaperReadWrite.Author].ToString().Trim(); //作者
objvPaperReadWriteEN.Keyword = objRow[convPaperReadWrite.Keyword] == DBNull.Value ? null : objRow[convPaperReadWrite.Keyword].ToString().Trim(); //关键字
objvPaperReadWriteEN.ResearchQuestion = objRow[convPaperReadWrite.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperReadWriteEN.OperationTypeId = objRow[convPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID
objvPaperReadWriteEN.OperationTypeName = objRow[convPaperReadWrite.OperationTypeName].ToString().Trim(); //操作类型名
objvPaperReadWriteEN.UpdDate = objRow[convPaperReadWrite.UpdDate] == DBNull.Value ? null : objRow[convPaperReadWrite.UpdDate].ToString().Trim(); //修改日期
objvPaperReadWriteEN.Memo = objRow[convPaperReadWrite.Memo] == DBNull.Value ? null : objRow[convPaperReadWrite.Memo].ToString().Trim(); //备注
objvPaperReadWriteEN.LiteratureLink = objRow[convPaperReadWrite.LiteratureLink] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureLink].ToString().Trim(); //文献链接
objvPaperReadWriteEN.LiteratureSources = objRow[convPaperReadWrite.LiteratureSources] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureSources].ToString().Trim(); //文献来源
objvPaperReadWriteEN.LiteratureTypeId = objRow[convPaperReadWrite.LiteratureTypeId] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperReadWriteEN.LiteratureTypeName = objRow[convPaperReadWrite.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperReadWriteEN.UploadfileUrl = objRow[convPaperReadWrite.UploadfileUrl] == DBNull.Value ? null : objRow[convPaperReadWrite.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperReadWriteEN.IsPublic = TransNullToBool(objRow[convPaperReadWrite.IsPublic].ToString().Trim()); //是否公开
objvPaperReadWriteEN.IsSubmit = TransNullToBool(objRow[convPaperReadWrite.IsSubmit].ToString().Trim()); //是否提交
objvPaperReadWriteEN.Submitter = objRow[convPaperReadWrite.Submitter] == DBNull.Value ? null : objRow[convPaperReadWrite.Submitter].ToString().Trim(); //提交人
objvPaperReadWriteEN.Pcount = objRow[convPaperReadWrite.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperReadWrite.Pcount].ToString().Trim()); //读写数
objvPaperReadWriteEN.TeaCount = objRow[convPaperReadWrite.TeaCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperReadWrite.TeaCount].ToString().Trim()); //TeaCount
objvPaperReadWriteEN.IdCurrEduCls = objRow[convPaperReadWrite.IdCurrEduCls] == DBNull.Value ? null : objRow[convPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperReadWriteEN.SubVCount = objRow[convPaperReadWrite.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPaperReadWrite.SubVCount].ToString().Trim()); //论文子观点数
objvPaperReadWriteEN.CreateDate = objRow[convPaperReadWrite.CreateDate] == DBNull.Value ? null : objRow[convPaperReadWrite.CreateDate].ToString().Trim(); //建立日期
objvPaperReadWriteEN.ShareId = objRow[convPaperReadWrite.ShareId] == DBNull.Value ? null : objRow[convPaperReadWrite.ShareId].ToString().Trim(); //分享Id
objvPaperReadWriteEN.UpdUser = objRow[convPaperReadWrite.UpdUser] == DBNull.Value ? null : objRow[convPaperReadWrite.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvPaperReadWriteDA: GetObjByDataRow)", objException.Message));
}
objvPaperReadWriteEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPaperReadWriteEN;
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
objSQL = clsvPaperReadWriteDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPaperReadWriteEN._CurrTabName, convPaperReadWrite.PaperRWId, 8, "");
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
objSQL = clsvPaperReadWriteDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPaperReadWriteEN._CurrTabName, convPaperReadWrite.PaperRWId, 8, strPrefix);
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
 objSQL = clsvPaperReadWriteDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PaperRWId from vPaperReadWrite where " + strCondition;
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
 objSQL = clsvPaperReadWriteDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PaperRWId from vPaperReadWrite where " + strCondition;
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
 /// <param name = "strPaperRWId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strPaperRWId)
{
CheckPrimaryKey(strPaperRWId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperReadWriteDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPaperReadWrite", "PaperRWId = " + "'"+ strPaperRWId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvPaperReadWriteDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPaperReadWriteDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPaperReadWrite", strCondition))
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
objSQL = clsvPaperReadWriteDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vPaperReadWrite");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvPaperReadWriteENS">源对象</param>
 /// <param name = "objvPaperReadWriteENT">目标对象</param>
public void CopyTo(clsvPaperReadWriteEN objvPaperReadWriteENS, clsvPaperReadWriteEN objvPaperReadWriteENT)
{
objvPaperReadWriteENT.PaperRWId = objvPaperReadWriteENS.PaperRWId; //课文阅读
objvPaperReadWriteENT.ReaderId = objvPaperReadWriteENS.ReaderId; //阅读者Id
objvPaperReadWriteENT.PaperId = objvPaperReadWriteENS.PaperId; //论文Id
objvPaperReadWriteENT.PaperTitle = objvPaperReadWriteENS.PaperTitle; //论文标题
objvPaperReadWriteENT.PaperContent = objvPaperReadWriteENS.PaperContent; //主题内容
objvPaperReadWriteENT.Periodical = objvPaperReadWriteENS.Periodical; //期刊
objvPaperReadWriteENT.Author = objvPaperReadWriteENS.Author; //作者
objvPaperReadWriteENT.Keyword = objvPaperReadWriteENS.Keyword; //关键字
objvPaperReadWriteENT.ResearchQuestion = objvPaperReadWriteENS.ResearchQuestion; //研究问题
objvPaperReadWriteENT.OperationTypeId = objvPaperReadWriteENS.OperationTypeId; //操作类型ID
objvPaperReadWriteENT.OperationTypeName = objvPaperReadWriteENS.OperationTypeName; //操作类型名
objvPaperReadWriteENT.UpdDate = objvPaperReadWriteENS.UpdDate; //修改日期
objvPaperReadWriteENT.Memo = objvPaperReadWriteENS.Memo; //备注
objvPaperReadWriteENT.LiteratureLink = objvPaperReadWriteENS.LiteratureLink; //文献链接
objvPaperReadWriteENT.LiteratureSources = objvPaperReadWriteENS.LiteratureSources; //文献来源
objvPaperReadWriteENT.LiteratureTypeId = objvPaperReadWriteENS.LiteratureTypeId; //作文类型Id
objvPaperReadWriteENT.LiteratureTypeName = objvPaperReadWriteENS.LiteratureTypeName; //作文类型名
objvPaperReadWriteENT.UploadfileUrl = objvPaperReadWriteENS.UploadfileUrl; //文件地址
objvPaperReadWriteENT.IsPublic = objvPaperReadWriteENS.IsPublic; //是否公开
objvPaperReadWriteENT.IsSubmit = objvPaperReadWriteENS.IsSubmit; //是否提交
objvPaperReadWriteENT.Submitter = objvPaperReadWriteENS.Submitter; //提交人
objvPaperReadWriteENT.Pcount = objvPaperReadWriteENS.Pcount; //读写数
objvPaperReadWriteENT.TeaCount = objvPaperReadWriteENS.TeaCount; //TeaCount
objvPaperReadWriteENT.IdCurrEduCls = objvPaperReadWriteENS.IdCurrEduCls; //教学班流水号
objvPaperReadWriteENT.SubVCount = objvPaperReadWriteENS.SubVCount; //论文子观点数
objvPaperReadWriteENT.CreateDate = objvPaperReadWriteENS.CreateDate; //建立日期
objvPaperReadWriteENT.ShareId = objvPaperReadWriteENS.ShareId; //分享Id
objvPaperReadWriteENT.UpdUser = objvPaperReadWriteENS.UpdUser; //修改人
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvPaperReadWriteEN objvPaperReadWriteEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvPaperReadWriteEN.PaperRWId, 8, convPaperReadWrite.PaperRWId);
clsCheckSql.CheckFieldLen(objvPaperReadWriteEN.ReaderId, 20, convPaperReadWrite.ReaderId);
clsCheckSql.CheckFieldLen(objvPaperReadWriteEN.PaperId, 8, convPaperReadWrite.PaperId);
clsCheckSql.CheckFieldLen(objvPaperReadWriteEN.PaperTitle, 500, convPaperReadWrite.PaperTitle);
clsCheckSql.CheckFieldLen(objvPaperReadWriteEN.Periodical, 100, convPaperReadWrite.Periodical);
clsCheckSql.CheckFieldLen(objvPaperReadWriteEN.Author, 200, convPaperReadWrite.Author);
clsCheckSql.CheckFieldLen(objvPaperReadWriteEN.Keyword, 1000, convPaperReadWrite.Keyword);
clsCheckSql.CheckFieldLen(objvPaperReadWriteEN.ResearchQuestion, 2000, convPaperReadWrite.ResearchQuestion);
clsCheckSql.CheckFieldLen(objvPaperReadWriteEN.OperationTypeId, 4, convPaperReadWrite.OperationTypeId);
clsCheckSql.CheckFieldLen(objvPaperReadWriteEN.OperationTypeName, 50, convPaperReadWrite.OperationTypeName);
clsCheckSql.CheckFieldLen(objvPaperReadWriteEN.UpdDate, 20, convPaperReadWrite.UpdDate);
clsCheckSql.CheckFieldLen(objvPaperReadWriteEN.Memo, 1000, convPaperReadWrite.Memo);
clsCheckSql.CheckFieldLen(objvPaperReadWriteEN.LiteratureLink, 1000, convPaperReadWrite.LiteratureLink);
clsCheckSql.CheckFieldLen(objvPaperReadWriteEN.LiteratureSources, 1000, convPaperReadWrite.LiteratureSources);
clsCheckSql.CheckFieldLen(objvPaperReadWriteEN.LiteratureTypeId, 2, convPaperReadWrite.LiteratureTypeId);
clsCheckSql.CheckFieldLen(objvPaperReadWriteEN.LiteratureTypeName, 100, convPaperReadWrite.LiteratureTypeName);
clsCheckSql.CheckFieldLen(objvPaperReadWriteEN.UploadfileUrl, 1000, convPaperReadWrite.UploadfileUrl);
clsCheckSql.CheckFieldLen(objvPaperReadWriteEN.Submitter, 50, convPaperReadWrite.Submitter);
clsCheckSql.CheckFieldLen(objvPaperReadWriteEN.IdCurrEduCls, 8, convPaperReadWrite.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvPaperReadWriteEN.CreateDate, 20, convPaperReadWrite.CreateDate);
clsCheckSql.CheckFieldLen(objvPaperReadWriteEN.ShareId, 2, convPaperReadWrite.ShareId);
clsCheckSql.CheckFieldLen(objvPaperReadWriteEN.UpdUser, 20, convPaperReadWrite.UpdUser);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvPaperReadWriteEN.PaperRWId, convPaperReadWrite.PaperRWId);
clsCheckSql.CheckSqlInjection4Field(objvPaperReadWriteEN.ReaderId, convPaperReadWrite.ReaderId);
clsCheckSql.CheckSqlInjection4Field(objvPaperReadWriteEN.PaperId, convPaperReadWrite.PaperId);
clsCheckSql.CheckSqlInjection4Field(objvPaperReadWriteEN.PaperTitle, convPaperReadWrite.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objvPaperReadWriteEN.Periodical, convPaperReadWrite.Periodical);
clsCheckSql.CheckSqlInjection4Field(objvPaperReadWriteEN.Author, convPaperReadWrite.Author);
clsCheckSql.CheckSqlInjection4Field(objvPaperReadWriteEN.Keyword, convPaperReadWrite.Keyword);
clsCheckSql.CheckSqlInjection4Field(objvPaperReadWriteEN.ResearchQuestion, convPaperReadWrite.ResearchQuestion);
clsCheckSql.CheckSqlInjection4Field(objvPaperReadWriteEN.OperationTypeId, convPaperReadWrite.OperationTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPaperReadWriteEN.OperationTypeName, convPaperReadWrite.OperationTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPaperReadWriteEN.UpdDate, convPaperReadWrite.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvPaperReadWriteEN.Memo, convPaperReadWrite.Memo);
clsCheckSql.CheckSqlInjection4Field(objvPaperReadWriteEN.LiteratureLink, convPaperReadWrite.LiteratureLink);
clsCheckSql.CheckSqlInjection4Field(objvPaperReadWriteEN.LiteratureSources, convPaperReadWrite.LiteratureSources);
clsCheckSql.CheckSqlInjection4Field(objvPaperReadWriteEN.LiteratureTypeId, convPaperReadWrite.LiteratureTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPaperReadWriteEN.LiteratureTypeName, convPaperReadWrite.LiteratureTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPaperReadWriteEN.UploadfileUrl, convPaperReadWrite.UploadfileUrl);
clsCheckSql.CheckSqlInjection4Field(objvPaperReadWriteEN.Submitter, convPaperReadWrite.Submitter);
clsCheckSql.CheckSqlInjection4Field(objvPaperReadWriteEN.IdCurrEduCls, convPaperReadWrite.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvPaperReadWriteEN.CreateDate, convPaperReadWrite.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvPaperReadWriteEN.ShareId, convPaperReadWrite.ShareId);
clsCheckSql.CheckSqlInjection4Field(objvPaperReadWriteEN.UpdUser, convPaperReadWrite.UpdUser);
//检查外键字段长度
 objvPaperReadWriteEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetPaperRWId()
{
//获取某学院所有专业信息
string strSQL = "select PaperRWId, OperationTypeName from vPaperReadWrite ";
 clsSpecSQLforSql mySql = clsvPaperReadWriteDA.GetSpecSQLObj();
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
 objSQL = clsvPaperReadWriteDA.GetSpecSQLObj();
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
 objSQL = clsvPaperReadWriteDA.GetSpecSQLObj();
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
 objSQL = clsvPaperReadWriteDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPaperReadWriteEN._CurrTabName);
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
 objSQL = clsvPaperReadWriteDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPaperReadWriteEN._CurrTabName, strCondition);
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
 objSQL = clsvPaperReadWriteDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}