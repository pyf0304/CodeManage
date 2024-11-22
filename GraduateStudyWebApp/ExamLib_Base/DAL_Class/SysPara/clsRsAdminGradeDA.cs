
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRsAdminGradeDA
 表名:RsAdminGrade(01120111)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:05:05
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
 /// 职务(RsAdminGrade)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsRsAdminGradeDA : clsCommBase4DA
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
 return clsRsAdminGradeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsRsAdminGradeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsRsAdminGradeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsRsAdminGradeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsRsAdminGradeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdAdminGrade">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdAdminGrade)
{
strIdAdminGrade = strIdAdminGrade.Replace("'", "''");
if (strIdAdminGrade.Length > 4)
{
throw new Exception("(errid:Data000001)在表:RsAdminGrade中,检查关键字,长度不正确!(clsRsAdminGradeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdAdminGrade)  ==  true)
{
throw new Exception("(errid:Data000002)在表:RsAdminGrade中,关键字不能为空 或 null!(clsRsAdminGradeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdAdminGrade);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsRsAdminGradeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsRsAdminGradeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
strSQL = "Select * from RsAdminGrade where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_RsAdminGrade(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsRsAdminGradeDA: GetDataTable_RsAdminGrade)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
strSQL = "Select * from RsAdminGrade where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsRsAdminGradeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsRsAdminGradeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
strSQL = "Select * from RsAdminGrade where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsRsAdminGradeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsRsAdminGradeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from RsAdminGrade where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from RsAdminGrade where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsRsAdminGradeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from RsAdminGrade where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsRsAdminGradeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} RsAdminGrade.* from RsAdminGrade Left Join {1} on {2} where {3} and RsAdminGrade.IdAdminGrade not in (Select top {5} RsAdminGrade.IdAdminGrade from RsAdminGrade Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from RsAdminGrade where {1} and IdAdminGrade not in (Select top {2} IdAdminGrade from RsAdminGrade where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from RsAdminGrade where {1} and IdAdminGrade not in (Select top {3} IdAdminGrade from RsAdminGrade where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsRsAdminGradeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} RsAdminGrade.* from RsAdminGrade Left Join {1} on {2} where {3} and RsAdminGrade.IdAdminGrade not in (Select top {5} RsAdminGrade.IdAdminGrade from RsAdminGrade Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from RsAdminGrade where {1} and IdAdminGrade not in (Select top {2} IdAdminGrade from RsAdminGrade where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from RsAdminGrade where {1} and IdAdminGrade not in (Select top {3} IdAdminGrade from RsAdminGrade where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsRsAdminGradeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsRsAdminGradeDA:GetObjLst)", objException.Message));
}
List<clsRsAdminGradeEN> arrObjLst = new List<clsRsAdminGradeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
strSQL = "Select * from RsAdminGrade where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRsAdminGradeEN objRsAdminGradeEN = new clsRsAdminGradeEN();
try
{
objRsAdminGradeEN.IdAdminGrade = objRow[conRsAdminGrade.IdAdminGrade].ToString().Trim(); //行政职务流水号
objRsAdminGradeEN.AdminGradeId = objRow[conRsAdminGrade.AdminGradeId].ToString().Trim(); //行政职务代号
objRsAdminGradeEN.AdminGradeDesc = objRow[conRsAdminGrade.AdminGradeDesc].ToString().Trim(); //行政职务描述
objRsAdminGradeEN.ModifyDate = objRow[conRsAdminGrade.ModifyDate] == DBNull.Value ? null : objRow[conRsAdminGrade.ModifyDate].ToString().Trim(); //修改日期
objRsAdminGradeEN.ModifyUserId = objRow[conRsAdminGrade.ModifyUserId] == DBNull.Value ? null : objRow[conRsAdminGrade.ModifyUserId].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsRsAdminGradeDA: GetObjLst)", objException.Message));
}
objRsAdminGradeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objRsAdminGradeEN);
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
public List<clsRsAdminGradeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsRsAdminGradeDA:GetObjLstByTabName)", objException.Message));
}
List<clsRsAdminGradeEN> arrObjLst = new List<clsRsAdminGradeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRsAdminGradeEN objRsAdminGradeEN = new clsRsAdminGradeEN();
try
{
objRsAdminGradeEN.IdAdminGrade = objRow[conRsAdminGrade.IdAdminGrade].ToString().Trim(); //行政职务流水号
objRsAdminGradeEN.AdminGradeId = objRow[conRsAdminGrade.AdminGradeId].ToString().Trim(); //行政职务代号
objRsAdminGradeEN.AdminGradeDesc = objRow[conRsAdminGrade.AdminGradeDesc].ToString().Trim(); //行政职务描述
objRsAdminGradeEN.ModifyDate = objRow[conRsAdminGrade.ModifyDate] == DBNull.Value ? null : objRow[conRsAdminGrade.ModifyDate].ToString().Trim(); //修改日期
objRsAdminGradeEN.ModifyUserId = objRow[conRsAdminGrade.ModifyUserId] == DBNull.Value ? null : objRow[conRsAdminGrade.ModifyUserId].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsRsAdminGradeDA: GetObjLst)", objException.Message));
}
objRsAdminGradeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objRsAdminGradeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objRsAdminGradeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetRsAdminGrade(ref clsRsAdminGradeEN objRsAdminGradeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
strSQL = "Select * from RsAdminGrade where IdAdminGrade = " + "'"+ objRsAdminGradeEN.IdAdminGrade+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objRsAdminGradeEN.IdAdminGrade = objDT.Rows[0][conRsAdminGrade.IdAdminGrade].ToString().Trim(); //行政职务流水号(字段类型:char,字段长度:4,是否可空:False)
 objRsAdminGradeEN.AdminGradeId = objDT.Rows[0][conRsAdminGrade.AdminGradeId].ToString().Trim(); //行政职务代号(字段类型:char,字段长度:4,是否可空:False)
 objRsAdminGradeEN.AdminGradeDesc = objDT.Rows[0][conRsAdminGrade.AdminGradeDesc].ToString().Trim(); //行政职务描述(字段类型:varchar,字段长度:30,是否可空:False)
 objRsAdminGradeEN.ModifyDate = objDT.Rows[0][conRsAdminGrade.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objRsAdminGradeEN.ModifyUserId = objDT.Rows[0][conRsAdminGrade.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsRsAdminGradeDA: GetRsAdminGrade)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdAdminGrade">表关键字</param>
 /// <returns>表对象</returns>
public clsRsAdminGradeEN GetObjByIdAdminGrade(string strIdAdminGrade)
{
CheckPrimaryKey(strIdAdminGrade);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
strSQL = "Select * from RsAdminGrade where IdAdminGrade = " + "'"+ strIdAdminGrade+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsRsAdminGradeEN objRsAdminGradeEN = new clsRsAdminGradeEN();
try
{
 objRsAdminGradeEN.IdAdminGrade = objRow[conRsAdminGrade.IdAdminGrade].ToString().Trim(); //行政职务流水号(字段类型:char,字段长度:4,是否可空:False)
 objRsAdminGradeEN.AdminGradeId = objRow[conRsAdminGrade.AdminGradeId].ToString().Trim(); //行政职务代号(字段类型:char,字段长度:4,是否可空:False)
 objRsAdminGradeEN.AdminGradeDesc = objRow[conRsAdminGrade.AdminGradeDesc].ToString().Trim(); //行政职务描述(字段类型:varchar,字段长度:30,是否可空:False)
 objRsAdminGradeEN.ModifyDate = objRow[conRsAdminGrade.ModifyDate] == DBNull.Value ? null : objRow[conRsAdminGrade.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objRsAdminGradeEN.ModifyUserId = objRow[conRsAdminGrade.ModifyUserId] == DBNull.Value ? null : objRow[conRsAdminGrade.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsRsAdminGradeDA: GetObjByIdAdminGrade)", objException.Message));
}
return objRsAdminGradeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsRsAdminGradeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsRsAdminGradeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
strSQL = "Select * from RsAdminGrade where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsRsAdminGradeEN objRsAdminGradeEN = new clsRsAdminGradeEN()
{
IdAdminGrade = objRow[conRsAdminGrade.IdAdminGrade].ToString().Trim(), //行政职务流水号
AdminGradeId = objRow[conRsAdminGrade.AdminGradeId].ToString().Trim(), //行政职务代号
AdminGradeDesc = objRow[conRsAdminGrade.AdminGradeDesc].ToString().Trim(), //行政职务描述
ModifyDate = objRow[conRsAdminGrade.ModifyDate] == DBNull.Value ? null : objRow[conRsAdminGrade.ModifyDate].ToString().Trim(), //修改日期
ModifyUserId = objRow[conRsAdminGrade.ModifyUserId] == DBNull.Value ? null : objRow[conRsAdminGrade.ModifyUserId].ToString().Trim() //修改人
};
objRsAdminGradeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objRsAdminGradeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsRsAdminGradeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsRsAdminGradeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsRsAdminGradeEN objRsAdminGradeEN = new clsRsAdminGradeEN();
try
{
objRsAdminGradeEN.IdAdminGrade = objRow[conRsAdminGrade.IdAdminGrade].ToString().Trim(); //行政职务流水号
objRsAdminGradeEN.AdminGradeId = objRow[conRsAdminGrade.AdminGradeId].ToString().Trim(); //行政职务代号
objRsAdminGradeEN.AdminGradeDesc = objRow[conRsAdminGrade.AdminGradeDesc].ToString().Trim(); //行政职务描述
objRsAdminGradeEN.ModifyDate = objRow[conRsAdminGrade.ModifyDate] == DBNull.Value ? null : objRow[conRsAdminGrade.ModifyDate].ToString().Trim(); //修改日期
objRsAdminGradeEN.ModifyUserId = objRow[conRsAdminGrade.ModifyUserId] == DBNull.Value ? null : objRow[conRsAdminGrade.ModifyUserId].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsRsAdminGradeDA: GetObjByDataRowRsAdminGrade)", objException.Message));
}
objRsAdminGradeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objRsAdminGradeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsRsAdminGradeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsRsAdminGradeEN objRsAdminGradeEN = new clsRsAdminGradeEN();
try
{
objRsAdminGradeEN.IdAdminGrade = objRow[conRsAdminGrade.IdAdminGrade].ToString().Trim(); //行政职务流水号
objRsAdminGradeEN.AdminGradeId = objRow[conRsAdminGrade.AdminGradeId].ToString().Trim(); //行政职务代号
objRsAdminGradeEN.AdminGradeDesc = objRow[conRsAdminGrade.AdminGradeDesc].ToString().Trim(); //行政职务描述
objRsAdminGradeEN.ModifyDate = objRow[conRsAdminGrade.ModifyDate] == DBNull.Value ? null : objRow[conRsAdminGrade.ModifyDate].ToString().Trim(); //修改日期
objRsAdminGradeEN.ModifyUserId = objRow[conRsAdminGrade.ModifyUserId] == DBNull.Value ? null : objRow[conRsAdminGrade.ModifyUserId].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsRsAdminGradeDA: GetObjByDataRow)", objException.Message));
}
objRsAdminGradeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objRsAdminGradeEN;
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
objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsRsAdminGradeEN._CurrTabName, conRsAdminGrade.IdAdminGrade, 4, "");
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
objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsRsAdminGradeEN._CurrTabName, conRsAdminGrade.IdAdminGrade, 4, strPrefix);
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
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdAdminGrade from RsAdminGrade where " + strCondition;
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
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdAdminGrade from RsAdminGrade where " + strCondition;
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
 /// <param name = "strIdAdminGrade">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdAdminGrade)
{
CheckPrimaryKey(strIdAdminGrade);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("RsAdminGrade", "IdAdminGrade = " + "'"+ strIdAdminGrade+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsRsAdminGradeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("RsAdminGrade", strCondition))
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
objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("RsAdminGrade");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsRsAdminGradeEN objRsAdminGradeEN)
 {
 if (objRsAdminGradeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objRsAdminGradeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
strSQL = "Select * from RsAdminGrade where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "RsAdminGrade");
objRow = objDS.Tables["RsAdminGrade"].NewRow();
objRow[conRsAdminGrade.IdAdminGrade] = objRsAdminGradeEN.IdAdminGrade; //行政职务流水号
objRow[conRsAdminGrade.AdminGradeId] = objRsAdminGradeEN.AdminGradeId; //行政职务代号
objRow[conRsAdminGrade.AdminGradeDesc] = objRsAdminGradeEN.AdminGradeDesc; //行政职务描述
 if (objRsAdminGradeEN.ModifyDate !=  "")
 {
objRow[conRsAdminGrade.ModifyDate] = objRsAdminGradeEN.ModifyDate; //修改日期
 }
 if (objRsAdminGradeEN.ModifyUserId !=  "")
 {
objRow[conRsAdminGrade.ModifyUserId] = objRsAdminGradeEN.ModifyUserId; //修改人
 }
objDS.Tables[clsRsAdminGradeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsRsAdminGradeEN._CurrTabName);
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
 /// <param name = "objRsAdminGradeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsRsAdminGradeEN objRsAdminGradeEN)
{
 if (objRsAdminGradeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objRsAdminGradeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objRsAdminGradeEN.IdAdminGrade !=  null)
 {
 arrFieldListForInsert.Add(conRsAdminGrade.IdAdminGrade);
 var strIdAdminGrade = objRsAdminGradeEN.IdAdminGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAdminGrade + "'");
 }
 
 if (objRsAdminGradeEN.AdminGradeId !=  null)
 {
 arrFieldListForInsert.Add(conRsAdminGrade.AdminGradeId);
 var strAdminGradeId = objRsAdminGradeEN.AdminGradeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAdminGradeId + "'");
 }
 
 if (objRsAdminGradeEN.AdminGradeDesc !=  null)
 {
 arrFieldListForInsert.Add(conRsAdminGrade.AdminGradeDesc);
 var strAdminGradeDesc = objRsAdminGradeEN.AdminGradeDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAdminGradeDesc + "'");
 }
 
 if (objRsAdminGradeEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conRsAdminGrade.ModifyDate);
 var strModifyDate = objRsAdminGradeEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objRsAdminGradeEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conRsAdminGrade.ModifyUserId);
 var strModifyUserId = objRsAdminGradeEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into RsAdminGrade");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objRsAdminGradeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsRsAdminGradeEN objRsAdminGradeEN)
{
 if (objRsAdminGradeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objRsAdminGradeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objRsAdminGradeEN.IdAdminGrade !=  null)
 {
 arrFieldListForInsert.Add(conRsAdminGrade.IdAdminGrade);
 var strIdAdminGrade = objRsAdminGradeEN.IdAdminGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAdminGrade + "'");
 }
 
 if (objRsAdminGradeEN.AdminGradeId !=  null)
 {
 arrFieldListForInsert.Add(conRsAdminGrade.AdminGradeId);
 var strAdminGradeId = objRsAdminGradeEN.AdminGradeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAdminGradeId + "'");
 }
 
 if (objRsAdminGradeEN.AdminGradeDesc !=  null)
 {
 arrFieldListForInsert.Add(conRsAdminGrade.AdminGradeDesc);
 var strAdminGradeDesc = objRsAdminGradeEN.AdminGradeDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAdminGradeDesc + "'");
 }
 
 if (objRsAdminGradeEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conRsAdminGrade.ModifyDate);
 var strModifyDate = objRsAdminGradeEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objRsAdminGradeEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conRsAdminGrade.ModifyUserId);
 var strModifyUserId = objRsAdminGradeEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into RsAdminGrade");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objRsAdminGradeEN.IdAdminGrade;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objRsAdminGradeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsRsAdminGradeEN objRsAdminGradeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objRsAdminGradeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objRsAdminGradeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objRsAdminGradeEN.IdAdminGrade !=  null)
 {
 arrFieldListForInsert.Add(conRsAdminGrade.IdAdminGrade);
 var strIdAdminGrade = objRsAdminGradeEN.IdAdminGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAdminGrade + "'");
 }
 
 if (objRsAdminGradeEN.AdminGradeId !=  null)
 {
 arrFieldListForInsert.Add(conRsAdminGrade.AdminGradeId);
 var strAdminGradeId = objRsAdminGradeEN.AdminGradeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAdminGradeId + "'");
 }
 
 if (objRsAdminGradeEN.AdminGradeDesc !=  null)
 {
 arrFieldListForInsert.Add(conRsAdminGrade.AdminGradeDesc);
 var strAdminGradeDesc = objRsAdminGradeEN.AdminGradeDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAdminGradeDesc + "'");
 }
 
 if (objRsAdminGradeEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conRsAdminGrade.ModifyDate);
 var strModifyDate = objRsAdminGradeEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objRsAdminGradeEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conRsAdminGrade.ModifyUserId);
 var strModifyUserId = objRsAdminGradeEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into RsAdminGrade");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objRsAdminGradeEN.IdAdminGrade;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objRsAdminGradeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsRsAdminGradeEN objRsAdminGradeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objRsAdminGradeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objRsAdminGradeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objRsAdminGradeEN.IdAdminGrade !=  null)
 {
 arrFieldListForInsert.Add(conRsAdminGrade.IdAdminGrade);
 var strIdAdminGrade = objRsAdminGradeEN.IdAdminGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAdminGrade + "'");
 }
 
 if (objRsAdminGradeEN.AdminGradeId !=  null)
 {
 arrFieldListForInsert.Add(conRsAdminGrade.AdminGradeId);
 var strAdminGradeId = objRsAdminGradeEN.AdminGradeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAdminGradeId + "'");
 }
 
 if (objRsAdminGradeEN.AdminGradeDesc !=  null)
 {
 arrFieldListForInsert.Add(conRsAdminGrade.AdminGradeDesc);
 var strAdminGradeDesc = objRsAdminGradeEN.AdminGradeDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAdminGradeDesc + "'");
 }
 
 if (objRsAdminGradeEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conRsAdminGrade.ModifyDate);
 var strModifyDate = objRsAdminGradeEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objRsAdminGradeEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conRsAdminGrade.ModifyUserId);
 var strModifyUserId = objRsAdminGradeEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into RsAdminGrade");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewRsAdminGrades(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
strSQL = "Select * from RsAdminGrade where IdAdminGrade = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "RsAdminGrade");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdAdminGrade = oRow[conRsAdminGrade.IdAdminGrade].ToString().Trim();
if (IsExist(strIdAdminGrade))
{
 string strResult = "关键字变量值为:" + string.Format("IdAdminGrade = {0}", strIdAdminGrade) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsRsAdminGradeEN._CurrTabName ].NewRow();
objRow[conRsAdminGrade.IdAdminGrade] = oRow[conRsAdminGrade.IdAdminGrade].ToString().Trim(); //行政职务流水号
objRow[conRsAdminGrade.AdminGradeId] = oRow[conRsAdminGrade.AdminGradeId].ToString().Trim(); //行政职务代号
objRow[conRsAdminGrade.AdminGradeDesc] = oRow[conRsAdminGrade.AdminGradeDesc].ToString().Trim(); //行政职务描述
objRow[conRsAdminGrade.ModifyDate] = oRow[conRsAdminGrade.ModifyDate].ToString().Trim(); //修改日期
objRow[conRsAdminGrade.ModifyUserId] = oRow[conRsAdminGrade.ModifyUserId].ToString().Trim(); //修改人
 objDS.Tables[clsRsAdminGradeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsRsAdminGradeEN._CurrTabName);
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
 /// <param name = "objRsAdminGradeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsRsAdminGradeEN objRsAdminGradeEN)
{
 if (objRsAdminGradeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objRsAdminGradeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
strSQL = "Select * from RsAdminGrade where IdAdminGrade = " + "'"+ objRsAdminGradeEN.IdAdminGrade+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsRsAdminGradeEN._CurrTabName);
if (objDS.Tables[clsRsAdminGradeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdAdminGrade = " + "'"+ objRsAdminGradeEN.IdAdminGrade+"'");
return false;
}
objRow = objDS.Tables[clsRsAdminGradeEN._CurrTabName].Rows[0];
 if (objRsAdminGradeEN.IsUpdated(conRsAdminGrade.IdAdminGrade))
 {
objRow[conRsAdminGrade.IdAdminGrade] = objRsAdminGradeEN.IdAdminGrade; //行政职务流水号
 }
 if (objRsAdminGradeEN.IsUpdated(conRsAdminGrade.AdminGradeId))
 {
objRow[conRsAdminGrade.AdminGradeId] = objRsAdminGradeEN.AdminGradeId; //行政职务代号
 }
 if (objRsAdminGradeEN.IsUpdated(conRsAdminGrade.AdminGradeDesc))
 {
objRow[conRsAdminGrade.AdminGradeDesc] = objRsAdminGradeEN.AdminGradeDesc; //行政职务描述
 }
 if (objRsAdminGradeEN.IsUpdated(conRsAdminGrade.ModifyDate))
 {
objRow[conRsAdminGrade.ModifyDate] = objRsAdminGradeEN.ModifyDate; //修改日期
 }
 if (objRsAdminGradeEN.IsUpdated(conRsAdminGrade.ModifyUserId))
 {
objRow[conRsAdminGrade.ModifyUserId] = objRsAdminGradeEN.ModifyUserId; //修改人
 }
try
{
objDA.Update(objDS, clsRsAdminGradeEN._CurrTabName);
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
 /// <param name = "objRsAdminGradeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsRsAdminGradeEN objRsAdminGradeEN)
{
 if (objRsAdminGradeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objRsAdminGradeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update RsAdminGrade Set ");
 
 if (objRsAdminGradeEN.IsUpdated(conRsAdminGrade.AdminGradeId))
 {
 if (objRsAdminGradeEN.AdminGradeId !=  null)
 {
 var strAdminGradeId = objRsAdminGradeEN.AdminGradeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAdminGradeId, conRsAdminGrade.AdminGradeId); //行政职务代号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRsAdminGrade.AdminGradeId); //行政职务代号
 }
 }
 
 if (objRsAdminGradeEN.IsUpdated(conRsAdminGrade.AdminGradeDesc))
 {
 if (objRsAdminGradeEN.AdminGradeDesc !=  null)
 {
 var strAdminGradeDesc = objRsAdminGradeEN.AdminGradeDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAdminGradeDesc, conRsAdminGrade.AdminGradeDesc); //行政职务描述
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRsAdminGrade.AdminGradeDesc); //行政职务描述
 }
 }
 
 if (objRsAdminGradeEN.IsUpdated(conRsAdminGrade.ModifyDate))
 {
 if (objRsAdminGradeEN.ModifyDate !=  null)
 {
 var strModifyDate = objRsAdminGradeEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyDate, conRsAdminGrade.ModifyDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRsAdminGrade.ModifyDate); //修改日期
 }
 }
 
 if (objRsAdminGradeEN.IsUpdated(conRsAdminGrade.ModifyUserId))
 {
 if (objRsAdminGradeEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objRsAdminGradeEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyUserId, conRsAdminGrade.ModifyUserId); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRsAdminGrade.ModifyUserId); //修改人
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdAdminGrade = '{0}'", objRsAdminGradeEN.IdAdminGrade); 
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
 /// <param name = "objRsAdminGradeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsRsAdminGradeEN objRsAdminGradeEN, string strCondition)
{
 if (objRsAdminGradeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objRsAdminGradeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update RsAdminGrade Set ");
 
 if (objRsAdminGradeEN.IsUpdated(conRsAdminGrade.AdminGradeId))
 {
 if (objRsAdminGradeEN.AdminGradeId !=  null)
 {
 var strAdminGradeId = objRsAdminGradeEN.AdminGradeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AdminGradeId = '{0}',", strAdminGradeId); //行政职务代号
 }
 else
 {
 sbSQL.Append(" AdminGradeId = null,"); //行政职务代号
 }
 }
 
 if (objRsAdminGradeEN.IsUpdated(conRsAdminGrade.AdminGradeDesc))
 {
 if (objRsAdminGradeEN.AdminGradeDesc !=  null)
 {
 var strAdminGradeDesc = objRsAdminGradeEN.AdminGradeDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AdminGradeDesc = '{0}',", strAdminGradeDesc); //行政职务描述
 }
 else
 {
 sbSQL.Append(" AdminGradeDesc = null,"); //行政职务描述
 }
 }
 
 if (objRsAdminGradeEN.IsUpdated(conRsAdminGrade.ModifyDate))
 {
 if (objRsAdminGradeEN.ModifyDate !=  null)
 {
 var strModifyDate = objRsAdminGradeEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyDate = '{0}',", strModifyDate); //修改日期
 }
 else
 {
 sbSQL.Append(" ModifyDate = null,"); //修改日期
 }
 }
 
 if (objRsAdminGradeEN.IsUpdated(conRsAdminGrade.ModifyUserId))
 {
 if (objRsAdminGradeEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objRsAdminGradeEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyUserId = '{0}',", strModifyUserId); //修改人
 }
 else
 {
 sbSQL.Append(" ModifyUserId = null,"); //修改人
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
 /// <param name = "objRsAdminGradeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsRsAdminGradeEN objRsAdminGradeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objRsAdminGradeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objRsAdminGradeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update RsAdminGrade Set ");
 
 if (objRsAdminGradeEN.IsUpdated(conRsAdminGrade.AdminGradeId))
 {
 if (objRsAdminGradeEN.AdminGradeId !=  null)
 {
 var strAdminGradeId = objRsAdminGradeEN.AdminGradeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AdminGradeId = '{0}',", strAdminGradeId); //行政职务代号
 }
 else
 {
 sbSQL.Append(" AdminGradeId = null,"); //行政职务代号
 }
 }
 
 if (objRsAdminGradeEN.IsUpdated(conRsAdminGrade.AdminGradeDesc))
 {
 if (objRsAdminGradeEN.AdminGradeDesc !=  null)
 {
 var strAdminGradeDesc = objRsAdminGradeEN.AdminGradeDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AdminGradeDesc = '{0}',", strAdminGradeDesc); //行政职务描述
 }
 else
 {
 sbSQL.Append(" AdminGradeDesc = null,"); //行政职务描述
 }
 }
 
 if (objRsAdminGradeEN.IsUpdated(conRsAdminGrade.ModifyDate))
 {
 if (objRsAdminGradeEN.ModifyDate !=  null)
 {
 var strModifyDate = objRsAdminGradeEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyDate = '{0}',", strModifyDate); //修改日期
 }
 else
 {
 sbSQL.Append(" ModifyDate = null,"); //修改日期
 }
 }
 
 if (objRsAdminGradeEN.IsUpdated(conRsAdminGrade.ModifyUserId))
 {
 if (objRsAdminGradeEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objRsAdminGradeEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyUserId = '{0}',", strModifyUserId); //修改人
 }
 else
 {
 sbSQL.Append(" ModifyUserId = null,"); //修改人
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
 /// <param name = "objRsAdminGradeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsRsAdminGradeEN objRsAdminGradeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objRsAdminGradeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objRsAdminGradeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update RsAdminGrade Set ");
 
 if (objRsAdminGradeEN.IsUpdated(conRsAdminGrade.AdminGradeId))
 {
 if (objRsAdminGradeEN.AdminGradeId !=  null)
 {
 var strAdminGradeId = objRsAdminGradeEN.AdminGradeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAdminGradeId, conRsAdminGrade.AdminGradeId); //行政职务代号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRsAdminGrade.AdminGradeId); //行政职务代号
 }
 }
 
 if (objRsAdminGradeEN.IsUpdated(conRsAdminGrade.AdminGradeDesc))
 {
 if (objRsAdminGradeEN.AdminGradeDesc !=  null)
 {
 var strAdminGradeDesc = objRsAdminGradeEN.AdminGradeDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAdminGradeDesc, conRsAdminGrade.AdminGradeDesc); //行政职务描述
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRsAdminGrade.AdminGradeDesc); //行政职务描述
 }
 }
 
 if (objRsAdminGradeEN.IsUpdated(conRsAdminGrade.ModifyDate))
 {
 if (objRsAdminGradeEN.ModifyDate !=  null)
 {
 var strModifyDate = objRsAdminGradeEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyDate, conRsAdminGrade.ModifyDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRsAdminGrade.ModifyDate); //修改日期
 }
 }
 
 if (objRsAdminGradeEN.IsUpdated(conRsAdminGrade.ModifyUserId))
 {
 if (objRsAdminGradeEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objRsAdminGradeEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyUserId, conRsAdminGrade.ModifyUserId); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRsAdminGrade.ModifyUserId); //修改人
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdAdminGrade = '{0}'", objRsAdminGradeEN.IdAdminGrade); 
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
 /// <param name = "strIdAdminGrade">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdAdminGrade) 
{
CheckPrimaryKey(strIdAdminGrade);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdAdminGrade,
};
 objSQL.ExecSP("RsAdminGrade_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdAdminGrade">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdAdminGrade, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdAdminGrade);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
//删除RsAdminGrade本表中与当前对象有关的记录
strSQL = strSQL + "Delete from RsAdminGrade where IdAdminGrade = " + "'"+ strIdAdminGrade+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelRsAdminGrade(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
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
//删除RsAdminGrade本表中与当前对象有关的记录
strSQL = strSQL + "Delete from RsAdminGrade where IdAdminGrade in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdAdminGrade">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdAdminGrade) 
{
CheckPrimaryKey(strIdAdminGrade);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
//删除RsAdminGrade本表中与当前对象有关的记录
strSQL = strSQL + "Delete from RsAdminGrade where IdAdminGrade = " + "'"+ strIdAdminGrade+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelRsAdminGrade(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsRsAdminGradeDA: DelRsAdminGrade)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from RsAdminGrade where " + strCondition ;
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
public bool DelRsAdminGradeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsRsAdminGradeDA: DelRsAdminGradeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from RsAdminGrade where " + strCondition ;
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
 /// <param name = "objRsAdminGradeENS">源对象</param>
 /// <param name = "objRsAdminGradeENT">目标对象</param>
public void CopyTo(clsRsAdminGradeEN objRsAdminGradeENS, clsRsAdminGradeEN objRsAdminGradeENT)
{
objRsAdminGradeENT.IdAdminGrade = objRsAdminGradeENS.IdAdminGrade; //行政职务流水号
objRsAdminGradeENT.AdminGradeId = objRsAdminGradeENS.AdminGradeId; //行政职务代号
objRsAdminGradeENT.AdminGradeDesc = objRsAdminGradeENS.AdminGradeDesc; //行政职务描述
objRsAdminGradeENT.ModifyDate = objRsAdminGradeENS.ModifyDate; //修改日期
objRsAdminGradeENT.ModifyUserId = objRsAdminGradeENS.ModifyUserId; //修改人
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsRsAdminGradeEN objRsAdminGradeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objRsAdminGradeEN.AdminGradeId, conRsAdminGrade.AdminGradeId);
clsCheckSql.CheckFieldNotNull(objRsAdminGradeEN.AdminGradeDesc, conRsAdminGrade.AdminGradeDesc);
//检查字段长度
clsCheckSql.CheckFieldLen(objRsAdminGradeEN.IdAdminGrade, 4, conRsAdminGrade.IdAdminGrade);
clsCheckSql.CheckFieldLen(objRsAdminGradeEN.AdminGradeId, 4, conRsAdminGrade.AdminGradeId);
clsCheckSql.CheckFieldLen(objRsAdminGradeEN.AdminGradeDesc, 30, conRsAdminGrade.AdminGradeDesc);
clsCheckSql.CheckFieldLen(objRsAdminGradeEN.ModifyDate, 20, conRsAdminGrade.ModifyDate);
clsCheckSql.CheckFieldLen(objRsAdminGradeEN.ModifyUserId, 18, conRsAdminGrade.ModifyUserId);
//检查字段外键固定长度
 objRsAdminGradeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsRsAdminGradeEN objRsAdminGradeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objRsAdminGradeEN.AdminGradeId, 4, conRsAdminGrade.AdminGradeId);
clsCheckSql.CheckFieldLen(objRsAdminGradeEN.AdminGradeDesc, 30, conRsAdminGrade.AdminGradeDesc);
clsCheckSql.CheckFieldLen(objRsAdminGradeEN.ModifyDate, 20, conRsAdminGrade.ModifyDate);
clsCheckSql.CheckFieldLen(objRsAdminGradeEN.ModifyUserId, 18, conRsAdminGrade.ModifyUserId);
//检查外键字段长度
 objRsAdminGradeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsRsAdminGradeEN objRsAdminGradeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objRsAdminGradeEN.IdAdminGrade, 4, conRsAdminGrade.IdAdminGrade);
clsCheckSql.CheckFieldLen(objRsAdminGradeEN.AdminGradeId, 4, conRsAdminGrade.AdminGradeId);
clsCheckSql.CheckFieldLen(objRsAdminGradeEN.AdminGradeDesc, 30, conRsAdminGrade.AdminGradeDesc);
clsCheckSql.CheckFieldLen(objRsAdminGradeEN.ModifyDate, 20, conRsAdminGrade.ModifyDate);
clsCheckSql.CheckFieldLen(objRsAdminGradeEN.ModifyUserId, 18, conRsAdminGrade.ModifyUserId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objRsAdminGradeEN.IdAdminGrade, conRsAdminGrade.IdAdminGrade);
clsCheckSql.CheckSqlInjection4Field(objRsAdminGradeEN.AdminGradeId, conRsAdminGrade.AdminGradeId);
clsCheckSql.CheckSqlInjection4Field(objRsAdminGradeEN.AdminGradeDesc, conRsAdminGrade.AdminGradeDesc);
clsCheckSql.CheckSqlInjection4Field(objRsAdminGradeEN.ModifyDate, conRsAdminGrade.ModifyDate);
clsCheckSql.CheckSqlInjection4Field(objRsAdminGradeEN.ModifyUserId, conRsAdminGrade.ModifyUserId);
//检查外键字段长度
 objRsAdminGradeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdAdminGrade()
{
//获取某学院所有专业信息
string strSQL = "select IdAdminGrade, AdminGradeDesc from RsAdminGrade ";
 clsSpecSQLforSql mySql = clsRsAdminGradeDA.GetSpecSQLObj();
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
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
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
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
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
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsRsAdminGradeEN._CurrTabName);
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
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsRsAdminGradeEN._CurrTabName, strCondition);
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
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
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
 objSQL = clsRsAdminGradeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}