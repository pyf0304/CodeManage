
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsJournalSubjectDA
 表名:JournalSubject(01120930)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:14:41
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
 /// 期刊学科(JournalSubject)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsJournalSubjectDA : clsCommBase4DA
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
 return clsJournalSubjectEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsJournalSubjectEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsJournalSubjectEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsJournalSubjectEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsJournalSubjectEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strJournalSubjectId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strJournalSubjectId)
{
strJournalSubjectId = strJournalSubjectId.Replace("'", "''");
if (strJournalSubjectId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:JournalSubject中,检查关键字,长度不正确!(clsJournalSubjectDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strJournalSubjectId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:JournalSubject中,关键字不能为空 或 null!(clsJournalSubjectDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strJournalSubjectId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsJournalSubjectDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsJournalSubjectDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
strSQL = "Select * from JournalSubject where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_JournalSubject(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsJournalSubjectDA: GetDataTable_JournalSubject)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
strSQL = "Select * from JournalSubject where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsJournalSubjectDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsJournalSubjectDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
strSQL = "Select * from JournalSubject where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsJournalSubjectDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsJournalSubjectDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from JournalSubject where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from JournalSubject where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsJournalSubjectDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from JournalSubject where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsJournalSubjectDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} JournalSubject.* from JournalSubject Left Join {1} on {2} where {3} and JournalSubject.JournalSubjectId not in (Select top {5} JournalSubject.JournalSubjectId from JournalSubject Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from JournalSubject where {1} and JournalSubjectId not in (Select top {2} JournalSubjectId from JournalSubject where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from JournalSubject where {1} and JournalSubjectId not in (Select top {3} JournalSubjectId from JournalSubject where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsJournalSubjectDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} JournalSubject.* from JournalSubject Left Join {1} on {2} where {3} and JournalSubject.JournalSubjectId not in (Select top {5} JournalSubject.JournalSubjectId from JournalSubject Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from JournalSubject where {1} and JournalSubjectId not in (Select top {2} JournalSubjectId from JournalSubject where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from JournalSubject where {1} and JournalSubjectId not in (Select top {3} JournalSubjectId from JournalSubject where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsJournalSubjectEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsJournalSubjectDA:GetObjLst)", objException.Message));
}
List<clsJournalSubjectEN> arrObjLst = new List<clsJournalSubjectEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
strSQL = "Select * from JournalSubject where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsJournalSubjectEN objJournalSubjectEN = new clsJournalSubjectEN();
try
{
objJournalSubjectEN.JournalSubjectId = objRow[conJournalSubject.JournalSubjectId].ToString().Trim(); //期刊学科Id
objJournalSubjectEN.JournalSubjectCode = objRow[conJournalSubject.JournalSubjectCode].ToString().Trim(); //期刊学科代码
objJournalSubjectEN.JournalSubjectName = objRow[conJournalSubject.JournalSubjectName].ToString().Trim(); //期刊学科名称
objJournalSubjectEN.JournalSubjectCategoryId = objRow[conJournalSubject.JournalSubjectCategoryId].ToString().Trim(); //期刊学科门类Id
objJournalSubjectEN.UpdDate = objRow[conJournalSubject.UpdDate] == DBNull.Value ? null : objRow[conJournalSubject.UpdDate].ToString().Trim(); //修改日期
objJournalSubjectEN.UpdUser = objRow[conJournalSubject.UpdUser] == DBNull.Value ? null : objRow[conJournalSubject.UpdUser].ToString().Trim(); //修改人
objJournalSubjectEN.Memo = objRow[conJournalSubject.Memo] == DBNull.Value ? null : objRow[conJournalSubject.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsJournalSubjectDA: GetObjLst)", objException.Message));
}
objJournalSubjectEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objJournalSubjectEN);
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
public List<clsJournalSubjectEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsJournalSubjectDA:GetObjLstByTabName)", objException.Message));
}
List<clsJournalSubjectEN> arrObjLst = new List<clsJournalSubjectEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsJournalSubjectEN objJournalSubjectEN = new clsJournalSubjectEN();
try
{
objJournalSubjectEN.JournalSubjectId = objRow[conJournalSubject.JournalSubjectId].ToString().Trim(); //期刊学科Id
objJournalSubjectEN.JournalSubjectCode = objRow[conJournalSubject.JournalSubjectCode].ToString().Trim(); //期刊学科代码
objJournalSubjectEN.JournalSubjectName = objRow[conJournalSubject.JournalSubjectName].ToString().Trim(); //期刊学科名称
objJournalSubjectEN.JournalSubjectCategoryId = objRow[conJournalSubject.JournalSubjectCategoryId].ToString().Trim(); //期刊学科门类Id
objJournalSubjectEN.UpdDate = objRow[conJournalSubject.UpdDate] == DBNull.Value ? null : objRow[conJournalSubject.UpdDate].ToString().Trim(); //修改日期
objJournalSubjectEN.UpdUser = objRow[conJournalSubject.UpdUser] == DBNull.Value ? null : objRow[conJournalSubject.UpdUser].ToString().Trim(); //修改人
objJournalSubjectEN.Memo = objRow[conJournalSubject.Memo] == DBNull.Value ? null : objRow[conJournalSubject.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsJournalSubjectDA: GetObjLst)", objException.Message));
}
objJournalSubjectEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objJournalSubjectEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objJournalSubjectEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetJournalSubject(ref clsJournalSubjectEN objJournalSubjectEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
strSQL = "Select * from JournalSubject where JournalSubjectId = " + "'"+ objJournalSubjectEN.JournalSubjectId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objJournalSubjectEN.JournalSubjectId = objDT.Rows[0][conJournalSubject.JournalSubjectId].ToString().Trim(); //期刊学科Id(字段类型:char,字段长度:4,是否可空:True)
 objJournalSubjectEN.JournalSubjectCode = objDT.Rows[0][conJournalSubject.JournalSubjectCode].ToString().Trim(); //期刊学科代码(字段类型:varchar,字段长度:100,是否可空:True)
 objJournalSubjectEN.JournalSubjectName = objDT.Rows[0][conJournalSubject.JournalSubjectName].ToString().Trim(); //期刊学科名称(字段类型:varchar,字段长度:100,是否可空:True)
 objJournalSubjectEN.JournalSubjectCategoryId = objDT.Rows[0][conJournalSubject.JournalSubjectCategoryId].ToString().Trim(); //期刊学科门类Id(字段类型:char,字段长度:4,是否可空:True)
 objJournalSubjectEN.UpdDate = objDT.Rows[0][conJournalSubject.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objJournalSubjectEN.UpdUser = objDT.Rows[0][conJournalSubject.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objJournalSubjectEN.Memo = objDT.Rows[0][conJournalSubject.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsJournalSubjectDA: GetJournalSubject)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strJournalSubjectId">表关键字</param>
 /// <returns>表对象</returns>
public clsJournalSubjectEN GetObjByJournalSubjectId(string strJournalSubjectId)
{
CheckPrimaryKey(strJournalSubjectId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
strSQL = "Select * from JournalSubject where JournalSubjectId = " + "'"+ strJournalSubjectId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsJournalSubjectEN objJournalSubjectEN = new clsJournalSubjectEN();
try
{
 objJournalSubjectEN.JournalSubjectId = objRow[conJournalSubject.JournalSubjectId].ToString().Trim(); //期刊学科Id(字段类型:char,字段长度:4,是否可空:True)
 objJournalSubjectEN.JournalSubjectCode = objRow[conJournalSubject.JournalSubjectCode].ToString().Trim(); //期刊学科代码(字段类型:varchar,字段长度:100,是否可空:True)
 objJournalSubjectEN.JournalSubjectName = objRow[conJournalSubject.JournalSubjectName].ToString().Trim(); //期刊学科名称(字段类型:varchar,字段长度:100,是否可空:True)
 objJournalSubjectEN.JournalSubjectCategoryId = objRow[conJournalSubject.JournalSubjectCategoryId].ToString().Trim(); //期刊学科门类Id(字段类型:char,字段长度:4,是否可空:True)
 objJournalSubjectEN.UpdDate = objRow[conJournalSubject.UpdDate] == DBNull.Value ? null : objRow[conJournalSubject.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objJournalSubjectEN.UpdUser = objRow[conJournalSubject.UpdUser] == DBNull.Value ? null : objRow[conJournalSubject.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objJournalSubjectEN.Memo = objRow[conJournalSubject.Memo] == DBNull.Value ? null : objRow[conJournalSubject.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsJournalSubjectDA: GetObjByJournalSubjectId)", objException.Message));
}
return objJournalSubjectEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsJournalSubjectEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsJournalSubjectDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
strSQL = "Select * from JournalSubject where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsJournalSubjectEN objJournalSubjectEN = new clsJournalSubjectEN()
{
JournalSubjectId = objRow[conJournalSubject.JournalSubjectId].ToString().Trim(), //期刊学科Id
JournalSubjectCode = objRow[conJournalSubject.JournalSubjectCode].ToString().Trim(), //期刊学科代码
JournalSubjectName = objRow[conJournalSubject.JournalSubjectName].ToString().Trim(), //期刊学科名称
JournalSubjectCategoryId = objRow[conJournalSubject.JournalSubjectCategoryId].ToString().Trim(), //期刊学科门类Id
UpdDate = objRow[conJournalSubject.UpdDate] == DBNull.Value ? null : objRow[conJournalSubject.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conJournalSubject.UpdUser] == DBNull.Value ? null : objRow[conJournalSubject.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conJournalSubject.Memo] == DBNull.Value ? null : objRow[conJournalSubject.Memo].ToString().Trim() //备注
};
objJournalSubjectEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objJournalSubjectEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsJournalSubjectDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsJournalSubjectEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsJournalSubjectEN objJournalSubjectEN = new clsJournalSubjectEN();
try
{
objJournalSubjectEN.JournalSubjectId = objRow[conJournalSubject.JournalSubjectId].ToString().Trim(); //期刊学科Id
objJournalSubjectEN.JournalSubjectCode = objRow[conJournalSubject.JournalSubjectCode].ToString().Trim(); //期刊学科代码
objJournalSubjectEN.JournalSubjectName = objRow[conJournalSubject.JournalSubjectName].ToString().Trim(); //期刊学科名称
objJournalSubjectEN.JournalSubjectCategoryId = objRow[conJournalSubject.JournalSubjectCategoryId].ToString().Trim(); //期刊学科门类Id
objJournalSubjectEN.UpdDate = objRow[conJournalSubject.UpdDate] == DBNull.Value ? null : objRow[conJournalSubject.UpdDate].ToString().Trim(); //修改日期
objJournalSubjectEN.UpdUser = objRow[conJournalSubject.UpdUser] == DBNull.Value ? null : objRow[conJournalSubject.UpdUser].ToString().Trim(); //修改人
objJournalSubjectEN.Memo = objRow[conJournalSubject.Memo] == DBNull.Value ? null : objRow[conJournalSubject.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsJournalSubjectDA: GetObjByDataRowJournalSubject)", objException.Message));
}
objJournalSubjectEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objJournalSubjectEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsJournalSubjectEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsJournalSubjectEN objJournalSubjectEN = new clsJournalSubjectEN();
try
{
objJournalSubjectEN.JournalSubjectId = objRow[conJournalSubject.JournalSubjectId].ToString().Trim(); //期刊学科Id
objJournalSubjectEN.JournalSubjectCode = objRow[conJournalSubject.JournalSubjectCode].ToString().Trim(); //期刊学科代码
objJournalSubjectEN.JournalSubjectName = objRow[conJournalSubject.JournalSubjectName].ToString().Trim(); //期刊学科名称
objJournalSubjectEN.JournalSubjectCategoryId = objRow[conJournalSubject.JournalSubjectCategoryId].ToString().Trim(); //期刊学科门类Id
objJournalSubjectEN.UpdDate = objRow[conJournalSubject.UpdDate] == DBNull.Value ? null : objRow[conJournalSubject.UpdDate].ToString().Trim(); //修改日期
objJournalSubjectEN.UpdUser = objRow[conJournalSubject.UpdUser] == DBNull.Value ? null : objRow[conJournalSubject.UpdUser].ToString().Trim(); //修改人
objJournalSubjectEN.Memo = objRow[conJournalSubject.Memo] == DBNull.Value ? null : objRow[conJournalSubject.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsJournalSubjectDA: GetObjByDataRow)", objException.Message));
}
objJournalSubjectEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objJournalSubjectEN;
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
objSQL = clsJournalSubjectDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsJournalSubjectEN._CurrTabName, conJournalSubject.JournalSubjectId, 4, "");
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
objSQL = clsJournalSubjectDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsJournalSubjectEN._CurrTabName, conJournalSubject.JournalSubjectId, 4, strPrefix);
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
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select JournalSubjectId from JournalSubject where " + strCondition;
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
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select JournalSubjectId from JournalSubject where " + strCondition;
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
 /// <param name = "strJournalSubjectId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strJournalSubjectId)
{
CheckPrimaryKey(strJournalSubjectId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("JournalSubject", "JournalSubjectId = " + "'"+ strJournalSubjectId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsJournalSubjectDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("JournalSubject", strCondition))
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
objSQL = clsJournalSubjectDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("JournalSubject");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsJournalSubjectEN objJournalSubjectEN)
 {
 if (objJournalSubjectEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objJournalSubjectEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
strSQL = "Select * from JournalSubject where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "JournalSubject");
objRow = objDS.Tables["JournalSubject"].NewRow();
objRow[conJournalSubject.JournalSubjectId] = objJournalSubjectEN.JournalSubjectId; //期刊学科Id
objRow[conJournalSubject.JournalSubjectCode] = objJournalSubjectEN.JournalSubjectCode; //期刊学科代码
objRow[conJournalSubject.JournalSubjectName] = objJournalSubjectEN.JournalSubjectName; //期刊学科名称
objRow[conJournalSubject.JournalSubjectCategoryId] = objJournalSubjectEN.JournalSubjectCategoryId; //期刊学科门类Id
 if (objJournalSubjectEN.UpdDate !=  "")
 {
objRow[conJournalSubject.UpdDate] = objJournalSubjectEN.UpdDate; //修改日期
 }
 if (objJournalSubjectEN.UpdUser !=  "")
 {
objRow[conJournalSubject.UpdUser] = objJournalSubjectEN.UpdUser; //修改人
 }
 if (objJournalSubjectEN.Memo !=  "")
 {
objRow[conJournalSubject.Memo] = objJournalSubjectEN.Memo; //备注
 }
objDS.Tables[clsJournalSubjectEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsJournalSubjectEN._CurrTabName);
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
 /// <param name = "objJournalSubjectEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsJournalSubjectEN objJournalSubjectEN)
{
 if (objJournalSubjectEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objJournalSubjectEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objJournalSubjectEN.JournalSubjectId !=  null)
 {
 arrFieldListForInsert.Add(conJournalSubject.JournalSubjectId);
 var strJournalSubjectId = objJournalSubjectEN.JournalSubjectId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJournalSubjectId + "'");
 }
 
 if (objJournalSubjectEN.JournalSubjectCode !=  null)
 {
 arrFieldListForInsert.Add(conJournalSubject.JournalSubjectCode);
 var strJournalSubjectCode = objJournalSubjectEN.JournalSubjectCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJournalSubjectCode + "'");
 }
 
 if (objJournalSubjectEN.JournalSubjectName !=  null)
 {
 arrFieldListForInsert.Add(conJournalSubject.JournalSubjectName);
 var strJournalSubjectName = objJournalSubjectEN.JournalSubjectName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJournalSubjectName + "'");
 }
 
 if (objJournalSubjectEN.JournalSubjectCategoryId !=  null)
 {
 arrFieldListForInsert.Add(conJournalSubject.JournalSubjectCategoryId);
 var strJournalSubjectCategoryId = objJournalSubjectEN.JournalSubjectCategoryId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJournalSubjectCategoryId + "'");
 }
 
 if (objJournalSubjectEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conJournalSubject.UpdDate);
 var strUpdDate = objJournalSubjectEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objJournalSubjectEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conJournalSubject.UpdUser);
 var strUpdUser = objJournalSubjectEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objJournalSubjectEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conJournalSubject.Memo);
 var strMemo = objJournalSubjectEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into JournalSubject");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objJournalSubjectEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsJournalSubjectEN objJournalSubjectEN)
{
 if (objJournalSubjectEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objJournalSubjectEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objJournalSubjectEN.JournalSubjectId !=  null)
 {
 arrFieldListForInsert.Add(conJournalSubject.JournalSubjectId);
 var strJournalSubjectId = objJournalSubjectEN.JournalSubjectId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJournalSubjectId + "'");
 }
 
 if (objJournalSubjectEN.JournalSubjectCode !=  null)
 {
 arrFieldListForInsert.Add(conJournalSubject.JournalSubjectCode);
 var strJournalSubjectCode = objJournalSubjectEN.JournalSubjectCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJournalSubjectCode + "'");
 }
 
 if (objJournalSubjectEN.JournalSubjectName !=  null)
 {
 arrFieldListForInsert.Add(conJournalSubject.JournalSubjectName);
 var strJournalSubjectName = objJournalSubjectEN.JournalSubjectName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJournalSubjectName + "'");
 }
 
 if (objJournalSubjectEN.JournalSubjectCategoryId !=  null)
 {
 arrFieldListForInsert.Add(conJournalSubject.JournalSubjectCategoryId);
 var strJournalSubjectCategoryId = objJournalSubjectEN.JournalSubjectCategoryId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJournalSubjectCategoryId + "'");
 }
 
 if (objJournalSubjectEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conJournalSubject.UpdDate);
 var strUpdDate = objJournalSubjectEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objJournalSubjectEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conJournalSubject.UpdUser);
 var strUpdUser = objJournalSubjectEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objJournalSubjectEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conJournalSubject.Memo);
 var strMemo = objJournalSubjectEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into JournalSubject");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objJournalSubjectEN.JournalSubjectId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objJournalSubjectEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsJournalSubjectEN objJournalSubjectEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objJournalSubjectEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objJournalSubjectEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objJournalSubjectEN.JournalSubjectId !=  null)
 {
 arrFieldListForInsert.Add(conJournalSubject.JournalSubjectId);
 var strJournalSubjectId = objJournalSubjectEN.JournalSubjectId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJournalSubjectId + "'");
 }
 
 if (objJournalSubjectEN.JournalSubjectCode !=  null)
 {
 arrFieldListForInsert.Add(conJournalSubject.JournalSubjectCode);
 var strJournalSubjectCode = objJournalSubjectEN.JournalSubjectCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJournalSubjectCode + "'");
 }
 
 if (objJournalSubjectEN.JournalSubjectName !=  null)
 {
 arrFieldListForInsert.Add(conJournalSubject.JournalSubjectName);
 var strJournalSubjectName = objJournalSubjectEN.JournalSubjectName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJournalSubjectName + "'");
 }
 
 if (objJournalSubjectEN.JournalSubjectCategoryId !=  null)
 {
 arrFieldListForInsert.Add(conJournalSubject.JournalSubjectCategoryId);
 var strJournalSubjectCategoryId = objJournalSubjectEN.JournalSubjectCategoryId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJournalSubjectCategoryId + "'");
 }
 
 if (objJournalSubjectEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conJournalSubject.UpdDate);
 var strUpdDate = objJournalSubjectEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objJournalSubjectEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conJournalSubject.UpdUser);
 var strUpdUser = objJournalSubjectEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objJournalSubjectEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conJournalSubject.Memo);
 var strMemo = objJournalSubjectEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into JournalSubject");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objJournalSubjectEN.JournalSubjectId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objJournalSubjectEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsJournalSubjectEN objJournalSubjectEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objJournalSubjectEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objJournalSubjectEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objJournalSubjectEN.JournalSubjectId !=  null)
 {
 arrFieldListForInsert.Add(conJournalSubject.JournalSubjectId);
 var strJournalSubjectId = objJournalSubjectEN.JournalSubjectId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJournalSubjectId + "'");
 }
 
 if (objJournalSubjectEN.JournalSubjectCode !=  null)
 {
 arrFieldListForInsert.Add(conJournalSubject.JournalSubjectCode);
 var strJournalSubjectCode = objJournalSubjectEN.JournalSubjectCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJournalSubjectCode + "'");
 }
 
 if (objJournalSubjectEN.JournalSubjectName !=  null)
 {
 arrFieldListForInsert.Add(conJournalSubject.JournalSubjectName);
 var strJournalSubjectName = objJournalSubjectEN.JournalSubjectName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJournalSubjectName + "'");
 }
 
 if (objJournalSubjectEN.JournalSubjectCategoryId !=  null)
 {
 arrFieldListForInsert.Add(conJournalSubject.JournalSubjectCategoryId);
 var strJournalSubjectCategoryId = objJournalSubjectEN.JournalSubjectCategoryId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJournalSubjectCategoryId + "'");
 }
 
 if (objJournalSubjectEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conJournalSubject.UpdDate);
 var strUpdDate = objJournalSubjectEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objJournalSubjectEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conJournalSubject.UpdUser);
 var strUpdUser = objJournalSubjectEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objJournalSubjectEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conJournalSubject.Memo);
 var strMemo = objJournalSubjectEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into JournalSubject");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewJournalSubjects(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
strSQL = "Select * from JournalSubject where JournalSubjectId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "JournalSubject");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strJournalSubjectId = oRow[conJournalSubject.JournalSubjectId].ToString().Trim();
if (IsExist(strJournalSubjectId))
{
 string strResult = "关键字变量值为:" + string.Format("JournalSubjectId = {0}", strJournalSubjectId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsJournalSubjectEN._CurrTabName ].NewRow();
objRow[conJournalSubject.JournalSubjectId] = oRow[conJournalSubject.JournalSubjectId].ToString().Trim(); //期刊学科Id
objRow[conJournalSubject.JournalSubjectCode] = oRow[conJournalSubject.JournalSubjectCode].ToString().Trim(); //期刊学科代码
objRow[conJournalSubject.JournalSubjectName] = oRow[conJournalSubject.JournalSubjectName].ToString().Trim(); //期刊学科名称
objRow[conJournalSubject.JournalSubjectCategoryId] = oRow[conJournalSubject.JournalSubjectCategoryId].ToString().Trim(); //期刊学科门类Id
objRow[conJournalSubject.UpdDate] = oRow[conJournalSubject.UpdDate].ToString().Trim(); //修改日期
objRow[conJournalSubject.UpdUser] = oRow[conJournalSubject.UpdUser].ToString().Trim(); //修改人
objRow[conJournalSubject.Memo] = oRow[conJournalSubject.Memo].ToString().Trim(); //备注
 objDS.Tables[clsJournalSubjectEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsJournalSubjectEN._CurrTabName);
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
 /// <param name = "objJournalSubjectEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsJournalSubjectEN objJournalSubjectEN)
{
 if (objJournalSubjectEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objJournalSubjectEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
strSQL = "Select * from JournalSubject where JournalSubjectId = " + "'"+ objJournalSubjectEN.JournalSubjectId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsJournalSubjectEN._CurrTabName);
if (objDS.Tables[clsJournalSubjectEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:JournalSubjectId = " + "'"+ objJournalSubjectEN.JournalSubjectId+"'");
return false;
}
objRow = objDS.Tables[clsJournalSubjectEN._CurrTabName].Rows[0];
 if (objJournalSubjectEN.IsUpdated(conJournalSubject.JournalSubjectId))
 {
objRow[conJournalSubject.JournalSubjectId] = objJournalSubjectEN.JournalSubjectId; //期刊学科Id
 }
 if (objJournalSubjectEN.IsUpdated(conJournalSubject.JournalSubjectCode))
 {
objRow[conJournalSubject.JournalSubjectCode] = objJournalSubjectEN.JournalSubjectCode; //期刊学科代码
 }
 if (objJournalSubjectEN.IsUpdated(conJournalSubject.JournalSubjectName))
 {
objRow[conJournalSubject.JournalSubjectName] = objJournalSubjectEN.JournalSubjectName; //期刊学科名称
 }
 if (objJournalSubjectEN.IsUpdated(conJournalSubject.JournalSubjectCategoryId))
 {
objRow[conJournalSubject.JournalSubjectCategoryId] = objJournalSubjectEN.JournalSubjectCategoryId; //期刊学科门类Id
 }
 if (objJournalSubjectEN.IsUpdated(conJournalSubject.UpdDate))
 {
objRow[conJournalSubject.UpdDate] = objJournalSubjectEN.UpdDate; //修改日期
 }
 if (objJournalSubjectEN.IsUpdated(conJournalSubject.UpdUser))
 {
objRow[conJournalSubject.UpdUser] = objJournalSubjectEN.UpdUser; //修改人
 }
 if (objJournalSubjectEN.IsUpdated(conJournalSubject.Memo))
 {
objRow[conJournalSubject.Memo] = objJournalSubjectEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsJournalSubjectEN._CurrTabName);
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
 /// <param name = "objJournalSubjectEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsJournalSubjectEN objJournalSubjectEN)
{
 if (objJournalSubjectEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objJournalSubjectEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update JournalSubject Set ");
 
 if (objJournalSubjectEN.IsUpdated(conJournalSubject.JournalSubjectCode))
 {
 if (objJournalSubjectEN.JournalSubjectCode !=  null)
 {
 var strJournalSubjectCode = objJournalSubjectEN.JournalSubjectCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strJournalSubjectCode, conJournalSubject.JournalSubjectCode); //期刊学科代码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJournalSubject.JournalSubjectCode); //期刊学科代码
 }
 }
 
 if (objJournalSubjectEN.IsUpdated(conJournalSubject.JournalSubjectName))
 {
 if (objJournalSubjectEN.JournalSubjectName !=  null)
 {
 var strJournalSubjectName = objJournalSubjectEN.JournalSubjectName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strJournalSubjectName, conJournalSubject.JournalSubjectName); //期刊学科名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJournalSubject.JournalSubjectName); //期刊学科名称
 }
 }
 
 if (objJournalSubjectEN.IsUpdated(conJournalSubject.JournalSubjectCategoryId))
 {
 if (objJournalSubjectEN.JournalSubjectCategoryId !=  null)
 {
 var strJournalSubjectCategoryId = objJournalSubjectEN.JournalSubjectCategoryId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strJournalSubjectCategoryId, conJournalSubject.JournalSubjectCategoryId); //期刊学科门类Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJournalSubject.JournalSubjectCategoryId); //期刊学科门类Id
 }
 }
 
 if (objJournalSubjectEN.IsUpdated(conJournalSubject.UpdDate))
 {
 if (objJournalSubjectEN.UpdDate !=  null)
 {
 var strUpdDate = objJournalSubjectEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conJournalSubject.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJournalSubject.UpdDate); //修改日期
 }
 }
 
 if (objJournalSubjectEN.IsUpdated(conJournalSubject.UpdUser))
 {
 if (objJournalSubjectEN.UpdUser !=  null)
 {
 var strUpdUser = objJournalSubjectEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conJournalSubject.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJournalSubject.UpdUser); //修改人
 }
 }
 
 if (objJournalSubjectEN.IsUpdated(conJournalSubject.Memo))
 {
 if (objJournalSubjectEN.Memo !=  null)
 {
 var strMemo = objJournalSubjectEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conJournalSubject.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJournalSubject.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where JournalSubjectId = '{0}'", objJournalSubjectEN.JournalSubjectId); 
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
 /// <param name = "objJournalSubjectEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsJournalSubjectEN objJournalSubjectEN, string strCondition)
{
 if (objJournalSubjectEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objJournalSubjectEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update JournalSubject Set ");
 
 if (objJournalSubjectEN.IsUpdated(conJournalSubject.JournalSubjectCode))
 {
 if (objJournalSubjectEN.JournalSubjectCode !=  null)
 {
 var strJournalSubjectCode = objJournalSubjectEN.JournalSubjectCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" JournalSubjectCode = '{0}',", strJournalSubjectCode); //期刊学科代码
 }
 else
 {
 sbSQL.Append(" JournalSubjectCode = null,"); //期刊学科代码
 }
 }
 
 if (objJournalSubjectEN.IsUpdated(conJournalSubject.JournalSubjectName))
 {
 if (objJournalSubjectEN.JournalSubjectName !=  null)
 {
 var strJournalSubjectName = objJournalSubjectEN.JournalSubjectName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" JournalSubjectName = '{0}',", strJournalSubjectName); //期刊学科名称
 }
 else
 {
 sbSQL.Append(" JournalSubjectName = null,"); //期刊学科名称
 }
 }
 
 if (objJournalSubjectEN.IsUpdated(conJournalSubject.JournalSubjectCategoryId))
 {
 if (objJournalSubjectEN.JournalSubjectCategoryId !=  null)
 {
 var strJournalSubjectCategoryId = objJournalSubjectEN.JournalSubjectCategoryId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" JournalSubjectCategoryId = '{0}',", strJournalSubjectCategoryId); //期刊学科门类Id
 }
 else
 {
 sbSQL.Append(" JournalSubjectCategoryId = null,"); //期刊学科门类Id
 }
 }
 
 if (objJournalSubjectEN.IsUpdated(conJournalSubject.UpdDate))
 {
 if (objJournalSubjectEN.UpdDate !=  null)
 {
 var strUpdDate = objJournalSubjectEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objJournalSubjectEN.IsUpdated(conJournalSubject.UpdUser))
 {
 if (objJournalSubjectEN.UpdUser !=  null)
 {
 var strUpdUser = objJournalSubjectEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objJournalSubjectEN.IsUpdated(conJournalSubject.Memo))
 {
 if (objJournalSubjectEN.Memo !=  null)
 {
 var strMemo = objJournalSubjectEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objJournalSubjectEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsJournalSubjectEN objJournalSubjectEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objJournalSubjectEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objJournalSubjectEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update JournalSubject Set ");
 
 if (objJournalSubjectEN.IsUpdated(conJournalSubject.JournalSubjectCode))
 {
 if (objJournalSubjectEN.JournalSubjectCode !=  null)
 {
 var strJournalSubjectCode = objJournalSubjectEN.JournalSubjectCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" JournalSubjectCode = '{0}',", strJournalSubjectCode); //期刊学科代码
 }
 else
 {
 sbSQL.Append(" JournalSubjectCode = null,"); //期刊学科代码
 }
 }
 
 if (objJournalSubjectEN.IsUpdated(conJournalSubject.JournalSubjectName))
 {
 if (objJournalSubjectEN.JournalSubjectName !=  null)
 {
 var strJournalSubjectName = objJournalSubjectEN.JournalSubjectName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" JournalSubjectName = '{0}',", strJournalSubjectName); //期刊学科名称
 }
 else
 {
 sbSQL.Append(" JournalSubjectName = null,"); //期刊学科名称
 }
 }
 
 if (objJournalSubjectEN.IsUpdated(conJournalSubject.JournalSubjectCategoryId))
 {
 if (objJournalSubjectEN.JournalSubjectCategoryId !=  null)
 {
 var strJournalSubjectCategoryId = objJournalSubjectEN.JournalSubjectCategoryId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" JournalSubjectCategoryId = '{0}',", strJournalSubjectCategoryId); //期刊学科门类Id
 }
 else
 {
 sbSQL.Append(" JournalSubjectCategoryId = null,"); //期刊学科门类Id
 }
 }
 
 if (objJournalSubjectEN.IsUpdated(conJournalSubject.UpdDate))
 {
 if (objJournalSubjectEN.UpdDate !=  null)
 {
 var strUpdDate = objJournalSubjectEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objJournalSubjectEN.IsUpdated(conJournalSubject.UpdUser))
 {
 if (objJournalSubjectEN.UpdUser !=  null)
 {
 var strUpdUser = objJournalSubjectEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objJournalSubjectEN.IsUpdated(conJournalSubject.Memo))
 {
 if (objJournalSubjectEN.Memo !=  null)
 {
 var strMemo = objJournalSubjectEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objJournalSubjectEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsJournalSubjectEN objJournalSubjectEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objJournalSubjectEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objJournalSubjectEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update JournalSubject Set ");
 
 if (objJournalSubjectEN.IsUpdated(conJournalSubject.JournalSubjectCode))
 {
 if (objJournalSubjectEN.JournalSubjectCode !=  null)
 {
 var strJournalSubjectCode = objJournalSubjectEN.JournalSubjectCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strJournalSubjectCode, conJournalSubject.JournalSubjectCode); //期刊学科代码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJournalSubject.JournalSubjectCode); //期刊学科代码
 }
 }
 
 if (objJournalSubjectEN.IsUpdated(conJournalSubject.JournalSubjectName))
 {
 if (objJournalSubjectEN.JournalSubjectName !=  null)
 {
 var strJournalSubjectName = objJournalSubjectEN.JournalSubjectName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strJournalSubjectName, conJournalSubject.JournalSubjectName); //期刊学科名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJournalSubject.JournalSubjectName); //期刊学科名称
 }
 }
 
 if (objJournalSubjectEN.IsUpdated(conJournalSubject.JournalSubjectCategoryId))
 {
 if (objJournalSubjectEN.JournalSubjectCategoryId !=  null)
 {
 var strJournalSubjectCategoryId = objJournalSubjectEN.JournalSubjectCategoryId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strJournalSubjectCategoryId, conJournalSubject.JournalSubjectCategoryId); //期刊学科门类Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJournalSubject.JournalSubjectCategoryId); //期刊学科门类Id
 }
 }
 
 if (objJournalSubjectEN.IsUpdated(conJournalSubject.UpdDate))
 {
 if (objJournalSubjectEN.UpdDate !=  null)
 {
 var strUpdDate = objJournalSubjectEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conJournalSubject.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJournalSubject.UpdDate); //修改日期
 }
 }
 
 if (objJournalSubjectEN.IsUpdated(conJournalSubject.UpdUser))
 {
 if (objJournalSubjectEN.UpdUser !=  null)
 {
 var strUpdUser = objJournalSubjectEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conJournalSubject.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJournalSubject.UpdUser); //修改人
 }
 }
 
 if (objJournalSubjectEN.IsUpdated(conJournalSubject.Memo))
 {
 if (objJournalSubjectEN.Memo !=  null)
 {
 var strMemo = objJournalSubjectEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conJournalSubject.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conJournalSubject.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where JournalSubjectId = '{0}'", objJournalSubjectEN.JournalSubjectId); 
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
 /// <param name = "strJournalSubjectId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strJournalSubjectId) 
{
CheckPrimaryKey(strJournalSubjectId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strJournalSubjectId,
};
 objSQL.ExecSP("JournalSubject_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strJournalSubjectId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strJournalSubjectId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strJournalSubjectId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
//删除JournalSubject本表中与当前对象有关的记录
strSQL = strSQL + "Delete from JournalSubject where JournalSubjectId = " + "'"+ strJournalSubjectId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelJournalSubject(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
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
//删除JournalSubject本表中与当前对象有关的记录
strSQL = strSQL + "Delete from JournalSubject where JournalSubjectId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strJournalSubjectId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strJournalSubjectId) 
{
CheckPrimaryKey(strJournalSubjectId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
//删除JournalSubject本表中与当前对象有关的记录
strSQL = strSQL + "Delete from JournalSubject where JournalSubjectId = " + "'"+ strJournalSubjectId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelJournalSubject(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsJournalSubjectDA: DelJournalSubject)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from JournalSubject where " + strCondition ;
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
public bool DelJournalSubjectWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsJournalSubjectDA: DelJournalSubjectWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from JournalSubject where " + strCondition ;
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
 /// <param name = "objJournalSubjectENS">源对象</param>
 /// <param name = "objJournalSubjectENT">目标对象</param>
public void CopyTo(clsJournalSubjectEN objJournalSubjectENS, clsJournalSubjectEN objJournalSubjectENT)
{
objJournalSubjectENT.JournalSubjectId = objJournalSubjectENS.JournalSubjectId; //期刊学科Id
objJournalSubjectENT.JournalSubjectCode = objJournalSubjectENS.JournalSubjectCode; //期刊学科代码
objJournalSubjectENT.JournalSubjectName = objJournalSubjectENS.JournalSubjectName; //期刊学科名称
objJournalSubjectENT.JournalSubjectCategoryId = objJournalSubjectENS.JournalSubjectCategoryId; //期刊学科门类Id
objJournalSubjectENT.UpdDate = objJournalSubjectENS.UpdDate; //修改日期
objJournalSubjectENT.UpdUser = objJournalSubjectENS.UpdUser; //修改人
objJournalSubjectENT.Memo = objJournalSubjectENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsJournalSubjectEN objJournalSubjectEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objJournalSubjectEN.JournalSubjectCode, conJournalSubject.JournalSubjectCode);
clsCheckSql.CheckFieldNotNull(objJournalSubjectEN.JournalSubjectName, conJournalSubject.JournalSubjectName);
clsCheckSql.CheckFieldNotNull(objJournalSubjectEN.JournalSubjectCategoryId, conJournalSubject.JournalSubjectCategoryId);
//检查字段长度
clsCheckSql.CheckFieldLen(objJournalSubjectEN.JournalSubjectId, 4, conJournalSubject.JournalSubjectId);
clsCheckSql.CheckFieldLen(objJournalSubjectEN.JournalSubjectCode, 100, conJournalSubject.JournalSubjectCode);
clsCheckSql.CheckFieldLen(objJournalSubjectEN.JournalSubjectName, 100, conJournalSubject.JournalSubjectName);
clsCheckSql.CheckFieldLen(objJournalSubjectEN.JournalSubjectCategoryId, 4, conJournalSubject.JournalSubjectCategoryId);
clsCheckSql.CheckFieldLen(objJournalSubjectEN.UpdDate, 20, conJournalSubject.UpdDate);
clsCheckSql.CheckFieldLen(objJournalSubjectEN.UpdUser, 20, conJournalSubject.UpdUser);
clsCheckSql.CheckFieldLen(objJournalSubjectEN.Memo, 1000, conJournalSubject.Memo);
//检查字段外键固定长度
 objJournalSubjectEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsJournalSubjectEN objJournalSubjectEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objJournalSubjectEN.JournalSubjectCode, 100, conJournalSubject.JournalSubjectCode);
clsCheckSql.CheckFieldLen(objJournalSubjectEN.JournalSubjectName, 100, conJournalSubject.JournalSubjectName);
clsCheckSql.CheckFieldLen(objJournalSubjectEN.JournalSubjectCategoryId, 4, conJournalSubject.JournalSubjectCategoryId);
clsCheckSql.CheckFieldLen(objJournalSubjectEN.UpdDate, 20, conJournalSubject.UpdDate);
clsCheckSql.CheckFieldLen(objJournalSubjectEN.UpdUser, 20, conJournalSubject.UpdUser);
clsCheckSql.CheckFieldLen(objJournalSubjectEN.Memo, 1000, conJournalSubject.Memo);
//检查外键字段长度
 objJournalSubjectEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsJournalSubjectEN objJournalSubjectEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objJournalSubjectEN.JournalSubjectId, 4, conJournalSubject.JournalSubjectId);
clsCheckSql.CheckFieldLen(objJournalSubjectEN.JournalSubjectCode, 100, conJournalSubject.JournalSubjectCode);
clsCheckSql.CheckFieldLen(objJournalSubjectEN.JournalSubjectName, 100, conJournalSubject.JournalSubjectName);
clsCheckSql.CheckFieldLen(objJournalSubjectEN.JournalSubjectCategoryId, 4, conJournalSubject.JournalSubjectCategoryId);
clsCheckSql.CheckFieldLen(objJournalSubjectEN.UpdDate, 20, conJournalSubject.UpdDate);
clsCheckSql.CheckFieldLen(objJournalSubjectEN.UpdUser, 20, conJournalSubject.UpdUser);
clsCheckSql.CheckFieldLen(objJournalSubjectEN.Memo, 1000, conJournalSubject.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objJournalSubjectEN.JournalSubjectId, conJournalSubject.JournalSubjectId);
clsCheckSql.CheckSqlInjection4Field(objJournalSubjectEN.JournalSubjectCode, conJournalSubject.JournalSubjectCode);
clsCheckSql.CheckSqlInjection4Field(objJournalSubjectEN.JournalSubjectName, conJournalSubject.JournalSubjectName);
clsCheckSql.CheckSqlInjection4Field(objJournalSubjectEN.JournalSubjectCategoryId, conJournalSubject.JournalSubjectCategoryId);
clsCheckSql.CheckSqlInjection4Field(objJournalSubjectEN.UpdDate, conJournalSubject.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objJournalSubjectEN.UpdUser, conJournalSubject.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objJournalSubjectEN.Memo, conJournalSubject.Memo);
//检查外键字段长度
 objJournalSubjectEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetJournalSubjectId()
{
//获取某学院所有专业信息
string strSQL = "select JournalSubjectId, JournalSubjectName from JournalSubject ";
 clsSpecSQLforSql mySql = clsJournalSubjectDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--JournalSubject(期刊学科),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objJournalSubjectEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsJournalSubjectEN objJournalSubjectEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and JournalSubjectCategoryId = '{0}'", objJournalSubjectEN.JournalSubjectCategoryId);
 sbCondition.AppendFormat(" and JournalSubjectName = '{0}'", objJournalSubjectEN.JournalSubjectName);
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
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
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
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
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
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsJournalSubjectEN._CurrTabName);
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
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsJournalSubjectEN._CurrTabName, strCondition);
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
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
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
 objSQL = clsJournalSubjectDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}