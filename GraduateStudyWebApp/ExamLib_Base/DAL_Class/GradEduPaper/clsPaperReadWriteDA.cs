
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPaperReadWriteDA
 表名:PaperReadWrite(01120547)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:14:44
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
 /// 论文读写表(PaperReadWrite)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsPaperReadWriteDA : clsCommBase4DA
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
 return clsPaperReadWriteEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsPaperReadWriteEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPaperReadWriteEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsPaperReadWriteEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsPaperReadWriteEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:PaperReadWrite中,检查关键字,长度不正确!(clsPaperReadWriteDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strPaperRWId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:PaperReadWrite中,关键字不能为空 或 null!(clsPaperReadWriteDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPaperRWId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsPaperReadWriteDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsPaperReadWriteDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
strSQL = "Select * from PaperReadWrite where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_PaperReadWrite(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsPaperReadWriteDA: GetDataTable_PaperReadWrite)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
strSQL = "Select * from PaperReadWrite where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsPaperReadWriteDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsPaperReadWriteDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
strSQL = "Select * from PaperReadWrite where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsPaperReadWriteDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsPaperReadWriteDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PaperReadWrite where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PaperReadWrite where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsPaperReadWriteDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from PaperReadWrite where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsPaperReadWriteDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} PaperReadWrite.* from PaperReadWrite Left Join {1} on {2} where {3} and PaperReadWrite.PaperRWId not in (Select top {5} PaperReadWrite.PaperRWId from PaperReadWrite Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PaperReadWrite where {1} and PaperRWId not in (Select top {2} PaperRWId from PaperReadWrite where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PaperReadWrite where {1} and PaperRWId not in (Select top {3} PaperRWId from PaperReadWrite where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsPaperReadWriteDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} PaperReadWrite.* from PaperReadWrite Left Join {1} on {2} where {3} and PaperReadWrite.PaperRWId not in (Select top {5} PaperReadWrite.PaperRWId from PaperReadWrite Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PaperReadWrite where {1} and PaperRWId not in (Select top {2} PaperRWId from PaperReadWrite where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PaperReadWrite where {1} and PaperRWId not in (Select top {3} PaperRWId from PaperReadWrite where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsPaperReadWriteEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsPaperReadWriteDA:GetObjLst)", objException.Message));
}
List<clsPaperReadWriteEN> arrObjLst = new List<clsPaperReadWriteEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
strSQL = "Select * from PaperReadWrite where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperReadWriteEN objPaperReadWriteEN = new clsPaperReadWriteEN();
try
{
objPaperReadWriteEN.PaperRWId = objRow[conPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读
objPaperReadWriteEN.ReaderId = objRow[conPaperReadWrite.ReaderId] == DBNull.Value ? null : objRow[conPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id
objPaperReadWriteEN.PaperId = objRow[conPaperReadWrite.PaperId] == DBNull.Value ? null : objRow[conPaperReadWrite.PaperId].ToString().Trim(); //论文Id
objPaperReadWriteEN.ResearchQuestion = objRow[conPaperReadWrite.ResearchQuestion] == DBNull.Value ? null : objRow[conPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题
objPaperReadWriteEN.OperationTypeId = objRow[conPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID
objPaperReadWriteEN.UpdDate = objRow[conPaperReadWrite.UpdDate].ToString().Trim(); //修改日期
objPaperReadWriteEN.Memo = objRow[conPaperReadWrite.Memo] == DBNull.Value ? null : objRow[conPaperReadWrite.Memo].ToString().Trim(); //备注
objPaperReadWriteEN.IsSubmit = TransNullToBool(objRow[conPaperReadWrite.IsSubmit].ToString().Trim()); //是否提交
objPaperReadWriteEN.IsPublic = TransNullToBool(objRow[conPaperReadWrite.IsPublic].ToString().Trim()); //是否公开
objPaperReadWriteEN.Submitter = objRow[conPaperReadWrite.Submitter] == DBNull.Value ? null : objRow[conPaperReadWrite.Submitter].ToString().Trim(); //提交人
objPaperReadWriteEN.IdCurrEduCls = objRow[conPaperReadWrite.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperReadWriteEN.SubVCount = objRow[conPaperReadWrite.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperReadWrite.SubVCount].ToString().Trim()); //论文子观点数
objPaperReadWriteEN.TeaCount = objRow[conPaperReadWrite.TeaCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperReadWrite.TeaCount].ToString().Trim()); //TeaCount
objPaperReadWriteEN.CreateDate = objRow[conPaperReadWrite.CreateDate] == DBNull.Value ? null : objRow[conPaperReadWrite.CreateDate].ToString().Trim(); //建立日期
objPaperReadWriteEN.ShareId = objRow[conPaperReadWrite.ShareId] == DBNull.Value ? null : objRow[conPaperReadWrite.ShareId].ToString().Trim(); //分享Id
objPaperReadWriteEN.UpdUser = objRow[conPaperReadWrite.UpdUser] == DBNull.Value ? null : objRow[conPaperReadWrite.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPaperReadWriteDA: GetObjLst)", objException.Message));
}
objPaperReadWriteEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPaperReadWriteEN);
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
public List<clsPaperReadWriteEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsPaperReadWriteDA:GetObjLstByTabName)", objException.Message));
}
List<clsPaperReadWriteEN> arrObjLst = new List<clsPaperReadWriteEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPaperReadWriteEN objPaperReadWriteEN = new clsPaperReadWriteEN();
try
{
objPaperReadWriteEN.PaperRWId = objRow[conPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读
objPaperReadWriteEN.ReaderId = objRow[conPaperReadWrite.ReaderId] == DBNull.Value ? null : objRow[conPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id
objPaperReadWriteEN.PaperId = objRow[conPaperReadWrite.PaperId] == DBNull.Value ? null : objRow[conPaperReadWrite.PaperId].ToString().Trim(); //论文Id
objPaperReadWriteEN.ResearchQuestion = objRow[conPaperReadWrite.ResearchQuestion] == DBNull.Value ? null : objRow[conPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题
objPaperReadWriteEN.OperationTypeId = objRow[conPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID
objPaperReadWriteEN.UpdDate = objRow[conPaperReadWrite.UpdDate].ToString().Trim(); //修改日期
objPaperReadWriteEN.Memo = objRow[conPaperReadWrite.Memo] == DBNull.Value ? null : objRow[conPaperReadWrite.Memo].ToString().Trim(); //备注
objPaperReadWriteEN.IsSubmit = TransNullToBool(objRow[conPaperReadWrite.IsSubmit].ToString().Trim()); //是否提交
objPaperReadWriteEN.IsPublic = TransNullToBool(objRow[conPaperReadWrite.IsPublic].ToString().Trim()); //是否公开
objPaperReadWriteEN.Submitter = objRow[conPaperReadWrite.Submitter] == DBNull.Value ? null : objRow[conPaperReadWrite.Submitter].ToString().Trim(); //提交人
objPaperReadWriteEN.IdCurrEduCls = objRow[conPaperReadWrite.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperReadWriteEN.SubVCount = objRow[conPaperReadWrite.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperReadWrite.SubVCount].ToString().Trim()); //论文子观点数
objPaperReadWriteEN.TeaCount = objRow[conPaperReadWrite.TeaCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperReadWrite.TeaCount].ToString().Trim()); //TeaCount
objPaperReadWriteEN.CreateDate = objRow[conPaperReadWrite.CreateDate] == DBNull.Value ? null : objRow[conPaperReadWrite.CreateDate].ToString().Trim(); //建立日期
objPaperReadWriteEN.ShareId = objRow[conPaperReadWrite.ShareId] == DBNull.Value ? null : objRow[conPaperReadWrite.ShareId].ToString().Trim(); //分享Id
objPaperReadWriteEN.UpdUser = objRow[conPaperReadWrite.UpdUser] == DBNull.Value ? null : objRow[conPaperReadWrite.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPaperReadWriteDA: GetObjLst)", objException.Message));
}
objPaperReadWriteEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPaperReadWriteEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objPaperReadWriteEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetPaperReadWrite(ref clsPaperReadWriteEN objPaperReadWriteEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
strSQL = "Select * from PaperReadWrite where PaperRWId = " + "'"+ objPaperReadWriteEN.PaperRWId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objPaperReadWriteEN.PaperRWId = objDT.Rows[0][conPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读(字段类型:char,字段长度:8,是否可空:True)
 objPaperReadWriteEN.ReaderId = objDT.Rows[0][conPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id(字段类型:varchar,字段长度:20,是否可空:True)
 objPaperReadWriteEN.PaperId = objDT.Rows[0][conPaperReadWrite.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objPaperReadWriteEN.ResearchQuestion = objDT.Rows[0][conPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objPaperReadWriteEN.OperationTypeId = objDT.Rows[0][conPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID(字段类型:char,字段长度:4,是否可空:False)
 objPaperReadWriteEN.UpdDate = objDT.Rows[0][conPaperReadWrite.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPaperReadWriteEN.Memo = objDT.Rows[0][conPaperReadWrite.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objPaperReadWriteEN.IsSubmit = TransNullToBool(objDT.Rows[0][conPaperReadWrite.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objPaperReadWriteEN.IsPublic = TransNullToBool(objDT.Rows[0][conPaperReadWrite.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objPaperReadWriteEN.Submitter = objDT.Rows[0][conPaperReadWrite.Submitter].ToString().Trim(); //提交人(字段类型:varchar,字段长度:50,是否可空:True)
 objPaperReadWriteEN.IdCurrEduCls = objDT.Rows[0][conPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objPaperReadWriteEN.SubVCount = TransNullToInt(objDT.Rows[0][conPaperReadWrite.SubVCount].ToString().Trim()); //论文子观点数(字段类型:int,字段长度:4,是否可空:True)
 objPaperReadWriteEN.TeaCount = TransNullToInt(objDT.Rows[0][conPaperReadWrite.TeaCount].ToString().Trim()); //TeaCount(字段类型:int,字段长度:4,是否可空:True)
 objPaperReadWriteEN.CreateDate = objDT.Rows[0][conPaperReadWrite.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPaperReadWriteEN.ShareId = objDT.Rows[0][conPaperReadWrite.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objPaperReadWriteEN.UpdUser = objDT.Rows[0][conPaperReadWrite.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsPaperReadWriteDA: GetPaperReadWrite)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPaperRWId">表关键字</param>
 /// <returns>表对象</returns>
public clsPaperReadWriteEN GetObjByPaperRWId(string strPaperRWId)
{
CheckPrimaryKey(strPaperRWId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
strSQL = "Select * from PaperReadWrite where PaperRWId = " + "'"+ strPaperRWId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsPaperReadWriteEN objPaperReadWriteEN = new clsPaperReadWriteEN();
try
{
 objPaperReadWriteEN.PaperRWId = objRow[conPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读(字段类型:char,字段长度:8,是否可空:True)
 objPaperReadWriteEN.ReaderId = objRow[conPaperReadWrite.ReaderId] == DBNull.Value ? null : objRow[conPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id(字段类型:varchar,字段长度:20,是否可空:True)
 objPaperReadWriteEN.PaperId = objRow[conPaperReadWrite.PaperId] == DBNull.Value ? null : objRow[conPaperReadWrite.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objPaperReadWriteEN.ResearchQuestion = objRow[conPaperReadWrite.ResearchQuestion] == DBNull.Value ? null : objRow[conPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objPaperReadWriteEN.OperationTypeId = objRow[conPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID(字段类型:char,字段长度:4,是否可空:False)
 objPaperReadWriteEN.UpdDate = objRow[conPaperReadWrite.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPaperReadWriteEN.Memo = objRow[conPaperReadWrite.Memo] == DBNull.Value ? null : objRow[conPaperReadWrite.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objPaperReadWriteEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conPaperReadWrite.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objPaperReadWriteEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conPaperReadWrite.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objPaperReadWriteEN.Submitter = objRow[conPaperReadWrite.Submitter] == DBNull.Value ? null : objRow[conPaperReadWrite.Submitter].ToString().Trim(); //提交人(字段类型:varchar,字段长度:50,是否可空:True)
 objPaperReadWriteEN.IdCurrEduCls = objRow[conPaperReadWrite.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objPaperReadWriteEN.SubVCount = objRow[conPaperReadWrite.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperReadWrite.SubVCount].ToString().Trim()); //论文子观点数(字段类型:int,字段长度:4,是否可空:True)
 objPaperReadWriteEN.TeaCount = objRow[conPaperReadWrite.TeaCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPaperReadWrite.TeaCount].ToString().Trim()); //TeaCount(字段类型:int,字段长度:4,是否可空:True)
 objPaperReadWriteEN.CreateDate = objRow[conPaperReadWrite.CreateDate] == DBNull.Value ? null : objRow[conPaperReadWrite.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPaperReadWriteEN.ShareId = objRow[conPaperReadWrite.ShareId] == DBNull.Value ? null : objRow[conPaperReadWrite.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objPaperReadWriteEN.UpdUser = objRow[conPaperReadWrite.UpdUser] == DBNull.Value ? null : objRow[conPaperReadWrite.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsPaperReadWriteDA: GetObjByPaperRWId)", objException.Message));
}
return objPaperReadWriteEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsPaperReadWriteEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsPaperReadWriteDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
strSQL = "Select * from PaperReadWrite where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsPaperReadWriteEN objPaperReadWriteEN = new clsPaperReadWriteEN()
{
PaperRWId = objRow[conPaperReadWrite.PaperRWId].ToString().Trim(), //课文阅读
ReaderId = objRow[conPaperReadWrite.ReaderId] == DBNull.Value ? null : objRow[conPaperReadWrite.ReaderId].ToString().Trim(), //阅读者Id
PaperId = objRow[conPaperReadWrite.PaperId] == DBNull.Value ? null : objRow[conPaperReadWrite.PaperId].ToString().Trim(), //论文Id
ResearchQuestion = objRow[conPaperReadWrite.ResearchQuestion] == DBNull.Value ? null : objRow[conPaperReadWrite.ResearchQuestion].ToString().Trim(), //研究问题
OperationTypeId = objRow[conPaperReadWrite.OperationTypeId].ToString().Trim(), //操作类型ID
UpdDate = objRow[conPaperReadWrite.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conPaperReadWrite.Memo] == DBNull.Value ? null : objRow[conPaperReadWrite.Memo].ToString().Trim(), //备注
IsSubmit = TransNullToBool(objRow[conPaperReadWrite.IsSubmit].ToString().Trim()), //是否提交
IsPublic = TransNullToBool(objRow[conPaperReadWrite.IsPublic].ToString().Trim()), //是否公开
Submitter = objRow[conPaperReadWrite.Submitter] == DBNull.Value ? null : objRow[conPaperReadWrite.Submitter].ToString().Trim(), //提交人
IdCurrEduCls = objRow[conPaperReadWrite.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperReadWrite.IdCurrEduCls].ToString().Trim(), //教学班流水号
SubVCount = objRow[conPaperReadWrite.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperReadWrite.SubVCount].ToString().Trim()), //论文子观点数
TeaCount = objRow[conPaperReadWrite.TeaCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperReadWrite.TeaCount].ToString().Trim()), //TeaCount
CreateDate = objRow[conPaperReadWrite.CreateDate] == DBNull.Value ? null : objRow[conPaperReadWrite.CreateDate].ToString().Trim(), //建立日期
ShareId = objRow[conPaperReadWrite.ShareId] == DBNull.Value ? null : objRow[conPaperReadWrite.ShareId].ToString().Trim(), //分享Id
UpdUser = objRow[conPaperReadWrite.UpdUser] == DBNull.Value ? null : objRow[conPaperReadWrite.UpdUser].ToString().Trim() //修改人
};
objPaperReadWriteEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPaperReadWriteEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsPaperReadWriteDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsPaperReadWriteEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPaperReadWriteEN objPaperReadWriteEN = new clsPaperReadWriteEN();
try
{
objPaperReadWriteEN.PaperRWId = objRow[conPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读
objPaperReadWriteEN.ReaderId = objRow[conPaperReadWrite.ReaderId] == DBNull.Value ? null : objRow[conPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id
objPaperReadWriteEN.PaperId = objRow[conPaperReadWrite.PaperId] == DBNull.Value ? null : objRow[conPaperReadWrite.PaperId].ToString().Trim(); //论文Id
objPaperReadWriteEN.ResearchQuestion = objRow[conPaperReadWrite.ResearchQuestion] == DBNull.Value ? null : objRow[conPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题
objPaperReadWriteEN.OperationTypeId = objRow[conPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID
objPaperReadWriteEN.UpdDate = objRow[conPaperReadWrite.UpdDate].ToString().Trim(); //修改日期
objPaperReadWriteEN.Memo = objRow[conPaperReadWrite.Memo] == DBNull.Value ? null : objRow[conPaperReadWrite.Memo].ToString().Trim(); //备注
objPaperReadWriteEN.IsSubmit = TransNullToBool(objRow[conPaperReadWrite.IsSubmit].ToString().Trim()); //是否提交
objPaperReadWriteEN.IsPublic = TransNullToBool(objRow[conPaperReadWrite.IsPublic].ToString().Trim()); //是否公开
objPaperReadWriteEN.Submitter = objRow[conPaperReadWrite.Submitter] == DBNull.Value ? null : objRow[conPaperReadWrite.Submitter].ToString().Trim(); //提交人
objPaperReadWriteEN.IdCurrEduCls = objRow[conPaperReadWrite.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperReadWriteEN.SubVCount = objRow[conPaperReadWrite.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperReadWrite.SubVCount].ToString().Trim()); //论文子观点数
objPaperReadWriteEN.TeaCount = objRow[conPaperReadWrite.TeaCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperReadWrite.TeaCount].ToString().Trim()); //TeaCount
objPaperReadWriteEN.CreateDate = objRow[conPaperReadWrite.CreateDate] == DBNull.Value ? null : objRow[conPaperReadWrite.CreateDate].ToString().Trim(); //建立日期
objPaperReadWriteEN.ShareId = objRow[conPaperReadWrite.ShareId] == DBNull.Value ? null : objRow[conPaperReadWrite.ShareId].ToString().Trim(); //分享Id
objPaperReadWriteEN.UpdUser = objRow[conPaperReadWrite.UpdUser] == DBNull.Value ? null : objRow[conPaperReadWrite.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsPaperReadWriteDA: GetObjByDataRowPaperReadWrite)", objException.Message));
}
objPaperReadWriteEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPaperReadWriteEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsPaperReadWriteEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPaperReadWriteEN objPaperReadWriteEN = new clsPaperReadWriteEN();
try
{
objPaperReadWriteEN.PaperRWId = objRow[conPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读
objPaperReadWriteEN.ReaderId = objRow[conPaperReadWrite.ReaderId] == DBNull.Value ? null : objRow[conPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id
objPaperReadWriteEN.PaperId = objRow[conPaperReadWrite.PaperId] == DBNull.Value ? null : objRow[conPaperReadWrite.PaperId].ToString().Trim(); //论文Id
objPaperReadWriteEN.ResearchQuestion = objRow[conPaperReadWrite.ResearchQuestion] == DBNull.Value ? null : objRow[conPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题
objPaperReadWriteEN.OperationTypeId = objRow[conPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID
objPaperReadWriteEN.UpdDate = objRow[conPaperReadWrite.UpdDate].ToString().Trim(); //修改日期
objPaperReadWriteEN.Memo = objRow[conPaperReadWrite.Memo] == DBNull.Value ? null : objRow[conPaperReadWrite.Memo].ToString().Trim(); //备注
objPaperReadWriteEN.IsSubmit = TransNullToBool(objRow[conPaperReadWrite.IsSubmit].ToString().Trim()); //是否提交
objPaperReadWriteEN.IsPublic = TransNullToBool(objRow[conPaperReadWrite.IsPublic].ToString().Trim()); //是否公开
objPaperReadWriteEN.Submitter = objRow[conPaperReadWrite.Submitter] == DBNull.Value ? null : objRow[conPaperReadWrite.Submitter].ToString().Trim(); //提交人
objPaperReadWriteEN.IdCurrEduCls = objRow[conPaperReadWrite.IdCurrEduCls] == DBNull.Value ? null : objRow[conPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号
objPaperReadWriteEN.SubVCount = objRow[conPaperReadWrite.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperReadWrite.SubVCount].ToString().Trim()); //论文子观点数
objPaperReadWriteEN.TeaCount = objRow[conPaperReadWrite.TeaCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPaperReadWrite.TeaCount].ToString().Trim()); //TeaCount
objPaperReadWriteEN.CreateDate = objRow[conPaperReadWrite.CreateDate] == DBNull.Value ? null : objRow[conPaperReadWrite.CreateDate].ToString().Trim(); //建立日期
objPaperReadWriteEN.ShareId = objRow[conPaperReadWrite.ShareId] == DBNull.Value ? null : objRow[conPaperReadWrite.ShareId].ToString().Trim(); //分享Id
objPaperReadWriteEN.UpdUser = objRow[conPaperReadWrite.UpdUser] == DBNull.Value ? null : objRow[conPaperReadWrite.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsPaperReadWriteDA: GetObjByDataRow)", objException.Message));
}
objPaperReadWriteEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPaperReadWriteEN;
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
objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPaperReadWriteEN._CurrTabName, conPaperReadWrite.PaperRWId, 8, "");
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
objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPaperReadWriteEN._CurrTabName, conPaperReadWrite.PaperRWId, 8, strPrefix);
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
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PaperRWId from PaperReadWrite where " + strCondition;
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
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PaperRWId from PaperReadWrite where " + strCondition;
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
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PaperReadWrite", "PaperRWId = " + "'"+ strPaperRWId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsPaperReadWriteDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PaperReadWrite", strCondition))
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
objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("PaperReadWrite");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsPaperReadWriteEN objPaperReadWriteEN)
 {
 if (objPaperReadWriteEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPaperReadWriteEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
strSQL = "Select * from PaperReadWrite where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PaperReadWrite");
objRow = objDS.Tables["PaperReadWrite"].NewRow();
objRow[conPaperReadWrite.PaperRWId] = objPaperReadWriteEN.PaperRWId; //课文阅读
 if (objPaperReadWriteEN.ReaderId !=  "")
 {
objRow[conPaperReadWrite.ReaderId] = objPaperReadWriteEN.ReaderId; //阅读者Id
 }
 if (objPaperReadWriteEN.PaperId !=  "")
 {
objRow[conPaperReadWrite.PaperId] = objPaperReadWriteEN.PaperId; //论文Id
 }
 if (objPaperReadWriteEN.ResearchQuestion !=  "")
 {
objRow[conPaperReadWrite.ResearchQuestion] = objPaperReadWriteEN.ResearchQuestion; //研究问题
 }
objRow[conPaperReadWrite.OperationTypeId] = objPaperReadWriteEN.OperationTypeId; //操作类型ID
objRow[conPaperReadWrite.UpdDate] = objPaperReadWriteEN.UpdDate; //修改日期
 if (objPaperReadWriteEN.Memo !=  "")
 {
objRow[conPaperReadWrite.Memo] = objPaperReadWriteEN.Memo; //备注
 }
objRow[conPaperReadWrite.IsSubmit] = objPaperReadWriteEN.IsSubmit; //是否提交
objRow[conPaperReadWrite.IsPublic] = objPaperReadWriteEN.IsPublic; //是否公开
 if (objPaperReadWriteEN.Submitter !=  "")
 {
objRow[conPaperReadWrite.Submitter] = objPaperReadWriteEN.Submitter; //提交人
 }
 if (objPaperReadWriteEN.IdCurrEduCls !=  "")
 {
objRow[conPaperReadWrite.IdCurrEduCls] = objPaperReadWriteEN.IdCurrEduCls; //教学班流水号
 }
objRow[conPaperReadWrite.SubVCount] = objPaperReadWriteEN.SubVCount; //论文子观点数
objRow[conPaperReadWrite.TeaCount] = objPaperReadWriteEN.TeaCount; //TeaCount
 if (objPaperReadWriteEN.CreateDate !=  "")
 {
objRow[conPaperReadWrite.CreateDate] = objPaperReadWriteEN.CreateDate; //建立日期
 }
 if (objPaperReadWriteEN.ShareId !=  "")
 {
objRow[conPaperReadWrite.ShareId] = objPaperReadWriteEN.ShareId; //分享Id
 }
 if (objPaperReadWriteEN.UpdUser !=  "")
 {
objRow[conPaperReadWrite.UpdUser] = objPaperReadWriteEN.UpdUser; //修改人
 }
objDS.Tables[clsPaperReadWriteEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsPaperReadWriteEN._CurrTabName);
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
 /// <param name = "objPaperReadWriteEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPaperReadWriteEN objPaperReadWriteEN)
{
 if (objPaperReadWriteEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPaperReadWriteEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPaperReadWriteEN.PaperRWId !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.PaperRWId);
 var strPaperRWId = objPaperReadWriteEN.PaperRWId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperRWId + "'");
 }
 
 if (objPaperReadWriteEN.ReaderId !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.ReaderId);
 var strReaderId = objPaperReadWriteEN.ReaderId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReaderId + "'");
 }
 
 if (objPaperReadWriteEN.PaperId  ==  "")
 {
 objPaperReadWriteEN.PaperId = null;
 }
 if (objPaperReadWriteEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.PaperId);
 var strPaperId = objPaperReadWriteEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objPaperReadWriteEN.ResearchQuestion !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.ResearchQuestion);
 var strResearchQuestion = objPaperReadWriteEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchQuestion + "'");
 }
 
 if (objPaperReadWriteEN.OperationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.OperationTypeId);
 var strOperationTypeId = objPaperReadWriteEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperationTypeId + "'");
 }
 
 if (objPaperReadWriteEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.UpdDate);
 var strUpdDate = objPaperReadWriteEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPaperReadWriteEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.Memo);
 var strMemo = objPaperReadWriteEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conPaperReadWrite.IsSubmit);
 arrValueListForInsert.Add("'" + (objPaperReadWriteEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPaperReadWrite.IsPublic);
 arrValueListForInsert.Add("'" + (objPaperReadWriteEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 if (objPaperReadWriteEN.Submitter !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.Submitter);
 var strSubmitter = objPaperReadWriteEN.Submitter.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubmitter + "'");
 }
 
 if (objPaperReadWriteEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.IdCurrEduCls);
 var strIdCurrEduCls = objPaperReadWriteEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objPaperReadWriteEN.SubVCount !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.SubVCount);
 arrValueListForInsert.Add(objPaperReadWriteEN.SubVCount.ToString());
 }
 
 if (objPaperReadWriteEN.TeaCount !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.TeaCount);
 arrValueListForInsert.Add(objPaperReadWriteEN.TeaCount.ToString());
 }
 
 if (objPaperReadWriteEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.CreateDate);
 var strCreateDate = objPaperReadWriteEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objPaperReadWriteEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.ShareId);
 var strShareId = objPaperReadWriteEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objPaperReadWriteEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.UpdUser);
 var strUpdUser = objPaperReadWriteEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PaperReadWrite");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objPaperReadWriteEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPaperReadWriteEN objPaperReadWriteEN)
{
 if (objPaperReadWriteEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPaperReadWriteEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPaperReadWriteEN.PaperRWId !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.PaperRWId);
 var strPaperRWId = objPaperReadWriteEN.PaperRWId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperRWId + "'");
 }
 
 if (objPaperReadWriteEN.ReaderId !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.ReaderId);
 var strReaderId = objPaperReadWriteEN.ReaderId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReaderId + "'");
 }
 
 if (objPaperReadWriteEN.PaperId  ==  "")
 {
 objPaperReadWriteEN.PaperId = null;
 }
 if (objPaperReadWriteEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.PaperId);
 var strPaperId = objPaperReadWriteEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objPaperReadWriteEN.ResearchQuestion !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.ResearchQuestion);
 var strResearchQuestion = objPaperReadWriteEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchQuestion + "'");
 }
 
 if (objPaperReadWriteEN.OperationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.OperationTypeId);
 var strOperationTypeId = objPaperReadWriteEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperationTypeId + "'");
 }
 
 if (objPaperReadWriteEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.UpdDate);
 var strUpdDate = objPaperReadWriteEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPaperReadWriteEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.Memo);
 var strMemo = objPaperReadWriteEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conPaperReadWrite.IsSubmit);
 arrValueListForInsert.Add("'" + (objPaperReadWriteEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPaperReadWrite.IsPublic);
 arrValueListForInsert.Add("'" + (objPaperReadWriteEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 if (objPaperReadWriteEN.Submitter !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.Submitter);
 var strSubmitter = objPaperReadWriteEN.Submitter.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubmitter + "'");
 }
 
 if (objPaperReadWriteEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.IdCurrEduCls);
 var strIdCurrEduCls = objPaperReadWriteEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objPaperReadWriteEN.SubVCount !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.SubVCount);
 arrValueListForInsert.Add(objPaperReadWriteEN.SubVCount.ToString());
 }
 
 if (objPaperReadWriteEN.TeaCount !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.TeaCount);
 arrValueListForInsert.Add(objPaperReadWriteEN.TeaCount.ToString());
 }
 
 if (objPaperReadWriteEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.CreateDate);
 var strCreateDate = objPaperReadWriteEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objPaperReadWriteEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.ShareId);
 var strShareId = objPaperReadWriteEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objPaperReadWriteEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.UpdUser);
 var strUpdUser = objPaperReadWriteEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PaperReadWrite");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objPaperReadWriteEN.PaperRWId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objPaperReadWriteEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPaperReadWriteEN objPaperReadWriteEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPaperReadWriteEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPaperReadWriteEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPaperReadWriteEN.PaperRWId !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.PaperRWId);
 var strPaperRWId = objPaperReadWriteEN.PaperRWId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperRWId + "'");
 }
 
 if (objPaperReadWriteEN.ReaderId !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.ReaderId);
 var strReaderId = objPaperReadWriteEN.ReaderId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReaderId + "'");
 }
 
 if (objPaperReadWriteEN.PaperId  ==  "")
 {
 objPaperReadWriteEN.PaperId = null;
 }
 if (objPaperReadWriteEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.PaperId);
 var strPaperId = objPaperReadWriteEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objPaperReadWriteEN.ResearchQuestion !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.ResearchQuestion);
 var strResearchQuestion = objPaperReadWriteEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchQuestion + "'");
 }
 
 if (objPaperReadWriteEN.OperationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.OperationTypeId);
 var strOperationTypeId = objPaperReadWriteEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperationTypeId + "'");
 }
 
 if (objPaperReadWriteEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.UpdDate);
 var strUpdDate = objPaperReadWriteEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPaperReadWriteEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.Memo);
 var strMemo = objPaperReadWriteEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conPaperReadWrite.IsSubmit);
 arrValueListForInsert.Add("'" + (objPaperReadWriteEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPaperReadWrite.IsPublic);
 arrValueListForInsert.Add("'" + (objPaperReadWriteEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 if (objPaperReadWriteEN.Submitter !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.Submitter);
 var strSubmitter = objPaperReadWriteEN.Submitter.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubmitter + "'");
 }
 
 if (objPaperReadWriteEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.IdCurrEduCls);
 var strIdCurrEduCls = objPaperReadWriteEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objPaperReadWriteEN.SubVCount !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.SubVCount);
 arrValueListForInsert.Add(objPaperReadWriteEN.SubVCount.ToString());
 }
 
 if (objPaperReadWriteEN.TeaCount !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.TeaCount);
 arrValueListForInsert.Add(objPaperReadWriteEN.TeaCount.ToString());
 }
 
 if (objPaperReadWriteEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.CreateDate);
 var strCreateDate = objPaperReadWriteEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objPaperReadWriteEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.ShareId);
 var strShareId = objPaperReadWriteEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objPaperReadWriteEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.UpdUser);
 var strUpdUser = objPaperReadWriteEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PaperReadWrite");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objPaperReadWriteEN.PaperRWId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objPaperReadWriteEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPaperReadWriteEN objPaperReadWriteEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objPaperReadWriteEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPaperReadWriteEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPaperReadWriteEN.PaperRWId !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.PaperRWId);
 var strPaperRWId = objPaperReadWriteEN.PaperRWId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperRWId + "'");
 }
 
 if (objPaperReadWriteEN.ReaderId !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.ReaderId);
 var strReaderId = objPaperReadWriteEN.ReaderId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReaderId + "'");
 }
 
 if (objPaperReadWriteEN.PaperId  ==  "")
 {
 objPaperReadWriteEN.PaperId = null;
 }
 if (objPaperReadWriteEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.PaperId);
 var strPaperId = objPaperReadWriteEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objPaperReadWriteEN.ResearchQuestion !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.ResearchQuestion);
 var strResearchQuestion = objPaperReadWriteEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResearchQuestion + "'");
 }
 
 if (objPaperReadWriteEN.OperationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.OperationTypeId);
 var strOperationTypeId = objPaperReadWriteEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperationTypeId + "'");
 }
 
 if (objPaperReadWriteEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.UpdDate);
 var strUpdDate = objPaperReadWriteEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPaperReadWriteEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.Memo);
 var strMemo = objPaperReadWriteEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conPaperReadWrite.IsSubmit);
 arrValueListForInsert.Add("'" + (objPaperReadWriteEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPaperReadWrite.IsPublic);
 arrValueListForInsert.Add("'" + (objPaperReadWriteEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 if (objPaperReadWriteEN.Submitter !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.Submitter);
 var strSubmitter = objPaperReadWriteEN.Submitter.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubmitter + "'");
 }
 
 if (objPaperReadWriteEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.IdCurrEduCls);
 var strIdCurrEduCls = objPaperReadWriteEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objPaperReadWriteEN.SubVCount !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.SubVCount);
 arrValueListForInsert.Add(objPaperReadWriteEN.SubVCount.ToString());
 }
 
 if (objPaperReadWriteEN.TeaCount !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.TeaCount);
 arrValueListForInsert.Add(objPaperReadWriteEN.TeaCount.ToString());
 }
 
 if (objPaperReadWriteEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.CreateDate);
 var strCreateDate = objPaperReadWriteEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objPaperReadWriteEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.ShareId);
 var strShareId = objPaperReadWriteEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objPaperReadWriteEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conPaperReadWrite.UpdUser);
 var strUpdUser = objPaperReadWriteEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PaperReadWrite");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewPaperReadWrites(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
strSQL = "Select * from PaperReadWrite where PaperRWId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PaperReadWrite");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strPaperRWId = oRow[conPaperReadWrite.PaperRWId].ToString().Trim();
if (IsExist(strPaperRWId))
{
 string strResult = "关键字变量值为:" + string.Format("PaperRWId = {0}", strPaperRWId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsPaperReadWriteEN._CurrTabName ].NewRow();
objRow[conPaperReadWrite.PaperRWId] = oRow[conPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读
objRow[conPaperReadWrite.ReaderId] = oRow[conPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id
objRow[conPaperReadWrite.PaperId] = oRow[conPaperReadWrite.PaperId].ToString().Trim(); //论文Id
objRow[conPaperReadWrite.ResearchQuestion] = oRow[conPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题
objRow[conPaperReadWrite.OperationTypeId] = oRow[conPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID
objRow[conPaperReadWrite.UpdDate] = oRow[conPaperReadWrite.UpdDate].ToString().Trim(); //修改日期
objRow[conPaperReadWrite.Memo] = oRow[conPaperReadWrite.Memo].ToString().Trim(); //备注
objRow[conPaperReadWrite.IsSubmit] = oRow[conPaperReadWrite.IsSubmit].ToString().Trim(); //是否提交
objRow[conPaperReadWrite.IsPublic] = oRow[conPaperReadWrite.IsPublic].ToString().Trim(); //是否公开
objRow[conPaperReadWrite.Submitter] = oRow[conPaperReadWrite.Submitter].ToString().Trim(); //提交人
objRow[conPaperReadWrite.IdCurrEduCls] = oRow[conPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conPaperReadWrite.SubVCount] = oRow[conPaperReadWrite.SubVCount].ToString().Trim(); //论文子观点数
objRow[conPaperReadWrite.TeaCount] = oRow[conPaperReadWrite.TeaCount].ToString().Trim(); //TeaCount
objRow[conPaperReadWrite.CreateDate] = oRow[conPaperReadWrite.CreateDate].ToString().Trim(); //建立日期
objRow[conPaperReadWrite.ShareId] = oRow[conPaperReadWrite.ShareId].ToString().Trim(); //分享Id
objRow[conPaperReadWrite.UpdUser] = oRow[conPaperReadWrite.UpdUser].ToString().Trim(); //修改人
 objDS.Tables[clsPaperReadWriteEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsPaperReadWriteEN._CurrTabName);
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
 /// <param name = "objPaperReadWriteEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsPaperReadWriteEN objPaperReadWriteEN)
{
 if (objPaperReadWriteEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPaperReadWriteEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
strSQL = "Select * from PaperReadWrite where PaperRWId = " + "'"+ objPaperReadWriteEN.PaperRWId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsPaperReadWriteEN._CurrTabName);
if (objDS.Tables[clsPaperReadWriteEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:PaperRWId = " + "'"+ objPaperReadWriteEN.PaperRWId+"'");
return false;
}
objRow = objDS.Tables[clsPaperReadWriteEN._CurrTabName].Rows[0];
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.PaperRWId))
 {
objRow[conPaperReadWrite.PaperRWId] = objPaperReadWriteEN.PaperRWId; //课文阅读
 }
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.ReaderId))
 {
objRow[conPaperReadWrite.ReaderId] = objPaperReadWriteEN.ReaderId; //阅读者Id
 }
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.PaperId))
 {
objRow[conPaperReadWrite.PaperId] = objPaperReadWriteEN.PaperId; //论文Id
 }
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.ResearchQuestion))
 {
objRow[conPaperReadWrite.ResearchQuestion] = objPaperReadWriteEN.ResearchQuestion; //研究问题
 }
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.OperationTypeId))
 {
objRow[conPaperReadWrite.OperationTypeId] = objPaperReadWriteEN.OperationTypeId; //操作类型ID
 }
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.UpdDate))
 {
objRow[conPaperReadWrite.UpdDate] = objPaperReadWriteEN.UpdDate; //修改日期
 }
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.Memo))
 {
objRow[conPaperReadWrite.Memo] = objPaperReadWriteEN.Memo; //备注
 }
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.IsSubmit))
 {
objRow[conPaperReadWrite.IsSubmit] = objPaperReadWriteEN.IsSubmit; //是否提交
 }
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.IsPublic))
 {
objRow[conPaperReadWrite.IsPublic] = objPaperReadWriteEN.IsPublic; //是否公开
 }
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.Submitter))
 {
objRow[conPaperReadWrite.Submitter] = objPaperReadWriteEN.Submitter; //提交人
 }
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.IdCurrEduCls))
 {
objRow[conPaperReadWrite.IdCurrEduCls] = objPaperReadWriteEN.IdCurrEduCls; //教学班流水号
 }
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.SubVCount))
 {
objRow[conPaperReadWrite.SubVCount] = objPaperReadWriteEN.SubVCount; //论文子观点数
 }
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.TeaCount))
 {
objRow[conPaperReadWrite.TeaCount] = objPaperReadWriteEN.TeaCount; //TeaCount
 }
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.CreateDate))
 {
objRow[conPaperReadWrite.CreateDate] = objPaperReadWriteEN.CreateDate; //建立日期
 }
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.ShareId))
 {
objRow[conPaperReadWrite.ShareId] = objPaperReadWriteEN.ShareId; //分享Id
 }
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.UpdUser))
 {
objRow[conPaperReadWrite.UpdUser] = objPaperReadWriteEN.UpdUser; //修改人
 }
try
{
objDA.Update(objDS, clsPaperReadWriteEN._CurrTabName);
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
 /// <param name = "objPaperReadWriteEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPaperReadWriteEN objPaperReadWriteEN)
{
 if (objPaperReadWriteEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPaperReadWriteEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update PaperReadWrite Set ");
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.ReaderId))
 {
 if (objPaperReadWriteEN.ReaderId !=  null)
 {
 var strReaderId = objPaperReadWriteEN.ReaderId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReaderId, conPaperReadWrite.ReaderId); //阅读者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperReadWrite.ReaderId); //阅读者Id
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.PaperId))
 {
 if (objPaperReadWriteEN.PaperId  ==  "")
 {
 objPaperReadWriteEN.PaperId = null;
 }
 if (objPaperReadWriteEN.PaperId !=  null)
 {
 var strPaperId = objPaperReadWriteEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperId, conPaperReadWrite.PaperId); //论文Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperReadWrite.PaperId); //论文Id
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.ResearchQuestion))
 {
 if (objPaperReadWriteEN.ResearchQuestion !=  null)
 {
 var strResearchQuestion = objPaperReadWriteEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResearchQuestion, conPaperReadWrite.ResearchQuestion); //研究问题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperReadWrite.ResearchQuestion); //研究问题
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.OperationTypeId))
 {
 if (objPaperReadWriteEN.OperationTypeId !=  null)
 {
 var strOperationTypeId = objPaperReadWriteEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOperationTypeId, conPaperReadWrite.OperationTypeId); //操作类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperReadWrite.OperationTypeId); //操作类型ID
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.UpdDate))
 {
 if (objPaperReadWriteEN.UpdDate !=  null)
 {
 var strUpdDate = objPaperReadWriteEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conPaperReadWrite.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperReadWrite.UpdDate); //修改日期
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.Memo))
 {
 if (objPaperReadWriteEN.Memo !=  null)
 {
 var strMemo = objPaperReadWriteEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPaperReadWrite.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperReadWrite.Memo); //备注
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPaperReadWriteEN.IsSubmit == true?"1":"0", conPaperReadWrite.IsSubmit); //是否提交
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.IsPublic))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPaperReadWriteEN.IsPublic == true?"1":"0", conPaperReadWrite.IsPublic); //是否公开
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.Submitter))
 {
 if (objPaperReadWriteEN.Submitter !=  null)
 {
 var strSubmitter = objPaperReadWriteEN.Submitter.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSubmitter, conPaperReadWrite.Submitter); //提交人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperReadWrite.Submitter); //提交人
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.IdCurrEduCls))
 {
 if (objPaperReadWriteEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objPaperReadWriteEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conPaperReadWrite.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperReadWrite.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.SubVCount))
 {
 if (objPaperReadWriteEN.SubVCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperReadWriteEN.SubVCount, conPaperReadWrite.SubVCount); //论文子观点数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperReadWrite.SubVCount); //论文子观点数
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.TeaCount))
 {
 if (objPaperReadWriteEN.TeaCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperReadWriteEN.TeaCount, conPaperReadWrite.TeaCount); //TeaCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperReadWrite.TeaCount); //TeaCount
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.CreateDate))
 {
 if (objPaperReadWriteEN.CreateDate !=  null)
 {
 var strCreateDate = objPaperReadWriteEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conPaperReadWrite.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperReadWrite.CreateDate); //建立日期
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.ShareId))
 {
 if (objPaperReadWriteEN.ShareId !=  null)
 {
 var strShareId = objPaperReadWriteEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strShareId, conPaperReadWrite.ShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperReadWrite.ShareId); //分享Id
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.UpdUser))
 {
 if (objPaperReadWriteEN.UpdUser !=  null)
 {
 var strUpdUser = objPaperReadWriteEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conPaperReadWrite.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperReadWrite.UpdUser); //修改人
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PaperRWId = '{0}'", objPaperReadWriteEN.PaperRWId); 
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
 /// <param name = "objPaperReadWriteEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsPaperReadWriteEN objPaperReadWriteEN, string strCondition)
{
 if (objPaperReadWriteEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPaperReadWriteEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PaperReadWrite Set ");
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.ReaderId))
 {
 if (objPaperReadWriteEN.ReaderId !=  null)
 {
 var strReaderId = objPaperReadWriteEN.ReaderId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReaderId = '{0}',", strReaderId); //阅读者Id
 }
 else
 {
 sbSQL.Append(" ReaderId = null,"); //阅读者Id
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.PaperId))
 {
 if (objPaperReadWriteEN.PaperId  ==  "")
 {
 objPaperReadWriteEN.PaperId = null;
 }
 if (objPaperReadWriteEN.PaperId !=  null)
 {
 var strPaperId = objPaperReadWriteEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperId = '{0}',", strPaperId); //论文Id
 }
 else
 {
 sbSQL.Append(" PaperId = null,"); //论文Id
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.ResearchQuestion))
 {
 if (objPaperReadWriteEN.ResearchQuestion !=  null)
 {
 var strResearchQuestion = objPaperReadWriteEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResearchQuestion = '{0}',", strResearchQuestion); //研究问题
 }
 else
 {
 sbSQL.Append(" ResearchQuestion = null,"); //研究问题
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.OperationTypeId))
 {
 if (objPaperReadWriteEN.OperationTypeId !=  null)
 {
 var strOperationTypeId = objPaperReadWriteEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OperationTypeId = '{0}',", strOperationTypeId); //操作类型ID
 }
 else
 {
 sbSQL.Append(" OperationTypeId = null,"); //操作类型ID
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.UpdDate))
 {
 if (objPaperReadWriteEN.UpdDate !=  null)
 {
 var strUpdDate = objPaperReadWriteEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.Memo))
 {
 if (objPaperReadWriteEN.Memo !=  null)
 {
 var strMemo = objPaperReadWriteEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objPaperReadWriteEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.IsPublic))
 {
 sbSQL.AppendFormat(" IsPublic = '{0}',", objPaperReadWriteEN.IsPublic == true?"1":"0"); //是否公开
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.Submitter))
 {
 if (objPaperReadWriteEN.Submitter !=  null)
 {
 var strSubmitter = objPaperReadWriteEN.Submitter.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Submitter = '{0}',", strSubmitter); //提交人
 }
 else
 {
 sbSQL.Append(" Submitter = null,"); //提交人
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.IdCurrEduCls))
 {
 if (objPaperReadWriteEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objPaperReadWriteEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.SubVCount))
 {
 if (objPaperReadWriteEN.SubVCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperReadWriteEN.SubVCount, conPaperReadWrite.SubVCount); //论文子观点数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperReadWrite.SubVCount); //论文子观点数
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.TeaCount))
 {
 if (objPaperReadWriteEN.TeaCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperReadWriteEN.TeaCount, conPaperReadWrite.TeaCount); //TeaCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperReadWrite.TeaCount); //TeaCount
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.CreateDate))
 {
 if (objPaperReadWriteEN.CreateDate !=  null)
 {
 var strCreateDate = objPaperReadWriteEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.ShareId))
 {
 if (objPaperReadWriteEN.ShareId !=  null)
 {
 var strShareId = objPaperReadWriteEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ShareId = '{0}',", strShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" ShareId = null,"); //分享Id
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.UpdUser))
 {
 if (objPaperReadWriteEN.UpdUser !=  null)
 {
 var strUpdUser = objPaperReadWriteEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
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
 /// <param name = "objPaperReadWriteEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsPaperReadWriteEN objPaperReadWriteEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPaperReadWriteEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPaperReadWriteEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PaperReadWrite Set ");
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.ReaderId))
 {
 if (objPaperReadWriteEN.ReaderId !=  null)
 {
 var strReaderId = objPaperReadWriteEN.ReaderId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReaderId = '{0}',", strReaderId); //阅读者Id
 }
 else
 {
 sbSQL.Append(" ReaderId = null,"); //阅读者Id
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.PaperId))
 {
 if (objPaperReadWriteEN.PaperId  ==  "")
 {
 objPaperReadWriteEN.PaperId = null;
 }
 if (objPaperReadWriteEN.PaperId !=  null)
 {
 var strPaperId = objPaperReadWriteEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperId = '{0}',", strPaperId); //论文Id
 }
 else
 {
 sbSQL.Append(" PaperId = null,"); //论文Id
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.ResearchQuestion))
 {
 if (objPaperReadWriteEN.ResearchQuestion !=  null)
 {
 var strResearchQuestion = objPaperReadWriteEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResearchQuestion = '{0}',", strResearchQuestion); //研究问题
 }
 else
 {
 sbSQL.Append(" ResearchQuestion = null,"); //研究问题
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.OperationTypeId))
 {
 if (objPaperReadWriteEN.OperationTypeId !=  null)
 {
 var strOperationTypeId = objPaperReadWriteEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OperationTypeId = '{0}',", strOperationTypeId); //操作类型ID
 }
 else
 {
 sbSQL.Append(" OperationTypeId = null,"); //操作类型ID
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.UpdDate))
 {
 if (objPaperReadWriteEN.UpdDate !=  null)
 {
 var strUpdDate = objPaperReadWriteEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.Memo))
 {
 if (objPaperReadWriteEN.Memo !=  null)
 {
 var strMemo = objPaperReadWriteEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objPaperReadWriteEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.IsPublic))
 {
 sbSQL.AppendFormat(" IsPublic = '{0}',", objPaperReadWriteEN.IsPublic == true?"1":"0"); //是否公开
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.Submitter))
 {
 if (objPaperReadWriteEN.Submitter !=  null)
 {
 var strSubmitter = objPaperReadWriteEN.Submitter.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Submitter = '{0}',", strSubmitter); //提交人
 }
 else
 {
 sbSQL.Append(" Submitter = null,"); //提交人
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.IdCurrEduCls))
 {
 if (objPaperReadWriteEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objPaperReadWriteEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.SubVCount))
 {
 if (objPaperReadWriteEN.SubVCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperReadWriteEN.SubVCount, conPaperReadWrite.SubVCount); //论文子观点数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperReadWrite.SubVCount); //论文子观点数
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.TeaCount))
 {
 if (objPaperReadWriteEN.TeaCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperReadWriteEN.TeaCount, conPaperReadWrite.TeaCount); //TeaCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperReadWrite.TeaCount); //TeaCount
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.CreateDate))
 {
 if (objPaperReadWriteEN.CreateDate !=  null)
 {
 var strCreateDate = objPaperReadWriteEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.ShareId))
 {
 if (objPaperReadWriteEN.ShareId !=  null)
 {
 var strShareId = objPaperReadWriteEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ShareId = '{0}',", strShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" ShareId = null,"); //分享Id
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.UpdUser))
 {
 if (objPaperReadWriteEN.UpdUser !=  null)
 {
 var strUpdUser = objPaperReadWriteEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
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
 /// <param name = "objPaperReadWriteEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPaperReadWriteEN objPaperReadWriteEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objPaperReadWriteEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPaperReadWriteEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PaperReadWrite Set ");
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.ReaderId))
 {
 if (objPaperReadWriteEN.ReaderId !=  null)
 {
 var strReaderId = objPaperReadWriteEN.ReaderId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReaderId, conPaperReadWrite.ReaderId); //阅读者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperReadWrite.ReaderId); //阅读者Id
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.PaperId))
 {
 if (objPaperReadWriteEN.PaperId  ==  "")
 {
 objPaperReadWriteEN.PaperId = null;
 }
 if (objPaperReadWriteEN.PaperId !=  null)
 {
 var strPaperId = objPaperReadWriteEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperId, conPaperReadWrite.PaperId); //论文Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperReadWrite.PaperId); //论文Id
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.ResearchQuestion))
 {
 if (objPaperReadWriteEN.ResearchQuestion !=  null)
 {
 var strResearchQuestion = objPaperReadWriteEN.ResearchQuestion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResearchQuestion, conPaperReadWrite.ResearchQuestion); //研究问题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperReadWrite.ResearchQuestion); //研究问题
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.OperationTypeId))
 {
 if (objPaperReadWriteEN.OperationTypeId !=  null)
 {
 var strOperationTypeId = objPaperReadWriteEN.OperationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOperationTypeId, conPaperReadWrite.OperationTypeId); //操作类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperReadWrite.OperationTypeId); //操作类型ID
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.UpdDate))
 {
 if (objPaperReadWriteEN.UpdDate !=  null)
 {
 var strUpdDate = objPaperReadWriteEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conPaperReadWrite.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperReadWrite.UpdDate); //修改日期
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.Memo))
 {
 if (objPaperReadWriteEN.Memo !=  null)
 {
 var strMemo = objPaperReadWriteEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPaperReadWrite.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperReadWrite.Memo); //备注
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPaperReadWriteEN.IsSubmit == true?"1":"0", conPaperReadWrite.IsSubmit); //是否提交
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.IsPublic))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPaperReadWriteEN.IsPublic == true?"1":"0", conPaperReadWrite.IsPublic); //是否公开
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.Submitter))
 {
 if (objPaperReadWriteEN.Submitter !=  null)
 {
 var strSubmitter = objPaperReadWriteEN.Submitter.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSubmitter, conPaperReadWrite.Submitter); //提交人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperReadWrite.Submitter); //提交人
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.IdCurrEduCls))
 {
 if (objPaperReadWriteEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objPaperReadWriteEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conPaperReadWrite.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperReadWrite.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.SubVCount))
 {
 if (objPaperReadWriteEN.SubVCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperReadWriteEN.SubVCount, conPaperReadWrite.SubVCount); //论文子观点数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperReadWrite.SubVCount); //论文子观点数
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.TeaCount))
 {
 if (objPaperReadWriteEN.TeaCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPaperReadWriteEN.TeaCount, conPaperReadWrite.TeaCount); //TeaCount
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperReadWrite.TeaCount); //TeaCount
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.CreateDate))
 {
 if (objPaperReadWriteEN.CreateDate !=  null)
 {
 var strCreateDate = objPaperReadWriteEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conPaperReadWrite.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperReadWrite.CreateDate); //建立日期
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.ShareId))
 {
 if (objPaperReadWriteEN.ShareId !=  null)
 {
 var strShareId = objPaperReadWriteEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strShareId, conPaperReadWrite.ShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperReadWrite.ShareId); //分享Id
 }
 }
 
 if (objPaperReadWriteEN.IsUpdated(conPaperReadWrite.UpdUser))
 {
 if (objPaperReadWriteEN.UpdUser !=  null)
 {
 var strUpdUser = objPaperReadWriteEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conPaperReadWrite.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPaperReadWrite.UpdUser); //修改人
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PaperRWId = '{0}'", objPaperReadWriteEN.PaperRWId); 
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
 /// <param name = "strPaperRWId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strPaperRWId) 
{
CheckPrimaryKey(strPaperRWId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strPaperRWId,
};
 objSQL.ExecSP("PaperReadWrite_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strPaperRWId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strPaperRWId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strPaperRWId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
//删除PaperReadWrite本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PaperReadWrite where PaperRWId = " + "'"+ strPaperRWId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelPaperReadWrite(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
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
//删除PaperReadWrite本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PaperReadWrite where PaperRWId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strPaperRWId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strPaperRWId) 
{
CheckPrimaryKey(strPaperRWId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
//删除PaperReadWrite本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PaperReadWrite where PaperRWId = " + "'"+ strPaperRWId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelPaperReadWrite(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsPaperReadWriteDA: DelPaperReadWrite)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PaperReadWrite where " + strCondition ;
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
public bool DelPaperReadWriteWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsPaperReadWriteDA: DelPaperReadWriteWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PaperReadWrite where " + strCondition ;
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
 /// <param name = "objPaperReadWriteENS">源对象</param>
 /// <param name = "objPaperReadWriteENT">目标对象</param>
public void CopyTo(clsPaperReadWriteEN objPaperReadWriteENS, clsPaperReadWriteEN objPaperReadWriteENT)
{
objPaperReadWriteENT.PaperRWId = objPaperReadWriteENS.PaperRWId; //课文阅读
objPaperReadWriteENT.ReaderId = objPaperReadWriteENS.ReaderId; //阅读者Id
objPaperReadWriteENT.PaperId = objPaperReadWriteENS.PaperId; //论文Id
objPaperReadWriteENT.ResearchQuestion = objPaperReadWriteENS.ResearchQuestion; //研究问题
objPaperReadWriteENT.OperationTypeId = objPaperReadWriteENS.OperationTypeId; //操作类型ID
objPaperReadWriteENT.UpdDate = objPaperReadWriteENS.UpdDate; //修改日期
objPaperReadWriteENT.Memo = objPaperReadWriteENS.Memo; //备注
objPaperReadWriteENT.IsSubmit = objPaperReadWriteENS.IsSubmit; //是否提交
objPaperReadWriteENT.IsPublic = objPaperReadWriteENS.IsPublic; //是否公开
objPaperReadWriteENT.Submitter = objPaperReadWriteENS.Submitter; //提交人
objPaperReadWriteENT.IdCurrEduCls = objPaperReadWriteENS.IdCurrEduCls; //教学班流水号
objPaperReadWriteENT.SubVCount = objPaperReadWriteENS.SubVCount; //论文子观点数
objPaperReadWriteENT.TeaCount = objPaperReadWriteENS.TeaCount; //TeaCount
objPaperReadWriteENT.CreateDate = objPaperReadWriteENS.CreateDate; //建立日期
objPaperReadWriteENT.ShareId = objPaperReadWriteENS.ShareId; //分享Id
objPaperReadWriteENT.UpdUser = objPaperReadWriteENS.UpdUser; //修改人
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsPaperReadWriteEN objPaperReadWriteEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objPaperReadWriteEN.OperationTypeId, conPaperReadWrite.OperationTypeId);
clsCheckSql.CheckFieldNotNull(objPaperReadWriteEN.UpdDate, conPaperReadWrite.UpdDate);
//检查字段长度
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.PaperRWId, 8, conPaperReadWrite.PaperRWId);
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.ReaderId, 20, conPaperReadWrite.ReaderId);
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.PaperId, 8, conPaperReadWrite.PaperId);
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.ResearchQuestion, 2000, conPaperReadWrite.ResearchQuestion);
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.OperationTypeId, 4, conPaperReadWrite.OperationTypeId);
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.UpdDate, 20, conPaperReadWrite.UpdDate);
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.Memo, 1000, conPaperReadWrite.Memo);
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.Submitter, 50, conPaperReadWrite.Submitter);
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.IdCurrEduCls, 8, conPaperReadWrite.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.CreateDate, 20, conPaperReadWrite.CreateDate);
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.ShareId, 2, conPaperReadWrite.ShareId);
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.UpdUser, 20, conPaperReadWrite.UpdUser);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objPaperReadWriteEN.PaperId, 8, conPaperReadWrite.PaperId);
 objPaperReadWriteEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsPaperReadWriteEN objPaperReadWriteEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.ReaderId, 20, conPaperReadWrite.ReaderId);
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.PaperId, 8, conPaperReadWrite.PaperId);
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.ResearchQuestion, 2000, conPaperReadWrite.ResearchQuestion);
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.OperationTypeId, 4, conPaperReadWrite.OperationTypeId);
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.UpdDate, 20, conPaperReadWrite.UpdDate);
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.Memo, 1000, conPaperReadWrite.Memo);
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.Submitter, 50, conPaperReadWrite.Submitter);
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.IdCurrEduCls, 8, conPaperReadWrite.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.CreateDate, 20, conPaperReadWrite.CreateDate);
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.ShareId, 2, conPaperReadWrite.ShareId);
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.UpdUser, 20, conPaperReadWrite.UpdUser);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objPaperReadWriteEN.PaperId, 8, conPaperReadWrite.PaperId);
 objPaperReadWriteEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsPaperReadWriteEN objPaperReadWriteEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.PaperRWId, 8, conPaperReadWrite.PaperRWId);
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.ReaderId, 20, conPaperReadWrite.ReaderId);
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.PaperId, 8, conPaperReadWrite.PaperId);
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.ResearchQuestion, 2000, conPaperReadWrite.ResearchQuestion);
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.OperationTypeId, 4, conPaperReadWrite.OperationTypeId);
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.UpdDate, 20, conPaperReadWrite.UpdDate);
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.Memo, 1000, conPaperReadWrite.Memo);
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.Submitter, 50, conPaperReadWrite.Submitter);
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.IdCurrEduCls, 8, conPaperReadWrite.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.CreateDate, 20, conPaperReadWrite.CreateDate);
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.ShareId, 2, conPaperReadWrite.ShareId);
clsCheckSql.CheckFieldLen(objPaperReadWriteEN.UpdUser, 20, conPaperReadWrite.UpdUser);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objPaperReadWriteEN.PaperRWId, conPaperReadWrite.PaperRWId);
clsCheckSql.CheckSqlInjection4Field(objPaperReadWriteEN.ReaderId, conPaperReadWrite.ReaderId);
clsCheckSql.CheckSqlInjection4Field(objPaperReadWriteEN.PaperId, conPaperReadWrite.PaperId);
clsCheckSql.CheckSqlInjection4Field(objPaperReadWriteEN.ResearchQuestion, conPaperReadWrite.ResearchQuestion);
clsCheckSql.CheckSqlInjection4Field(objPaperReadWriteEN.OperationTypeId, conPaperReadWrite.OperationTypeId);
clsCheckSql.CheckSqlInjection4Field(objPaperReadWriteEN.UpdDate, conPaperReadWrite.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objPaperReadWriteEN.Memo, conPaperReadWrite.Memo);
clsCheckSql.CheckSqlInjection4Field(objPaperReadWriteEN.Submitter, conPaperReadWrite.Submitter);
clsCheckSql.CheckSqlInjection4Field(objPaperReadWriteEN.IdCurrEduCls, conPaperReadWrite.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objPaperReadWriteEN.CreateDate, conPaperReadWrite.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objPaperReadWriteEN.ShareId, conPaperReadWrite.ShareId);
clsCheckSql.CheckSqlInjection4Field(objPaperReadWriteEN.UpdUser, conPaperReadWrite.UpdUser);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objPaperReadWriteEN.PaperId, 8, conPaperReadWrite.PaperId);
 objPaperReadWriteEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--PaperReadWrite(论文读写表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPaperReadWriteEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsPaperReadWriteEN objPaperReadWriteEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objPaperReadWriteEN.ReaderId == null)
{
 sbCondition.AppendFormat(" and ReaderId is null");
}
else
{
 sbCondition.AppendFormat(" and ReaderId = '{0}'", objPaperReadWriteEN.ReaderId);
}
 if (objPaperReadWriteEN.PaperId == null)
{
 sbCondition.AppendFormat(" and PaperId is null");
}
else
{
 sbCondition.AppendFormat(" and PaperId = '{0}'", objPaperReadWriteEN.PaperId);
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
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
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
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
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
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPaperReadWriteEN._CurrTabName);
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
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPaperReadWriteEN._CurrTabName, strCondition);
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
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
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
 objSQL = clsPaperReadWriteDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}