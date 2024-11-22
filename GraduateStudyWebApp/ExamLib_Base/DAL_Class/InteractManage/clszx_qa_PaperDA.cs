
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_qa_PaperDA
 表名:zx_qa_Paper(01120810)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:02:42
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
 /// 中学论文答疑表(zx_qa_Paper)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clszx_qa_PaperDA : clsCommBase4DA
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
 return clszx_qa_PaperEN._CurrTabName;
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
if (string.IsNullOrEmpty(clszx_qa_PaperEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_qa_PaperEN._ConnectString);
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
 if (string.IsNullOrEmpty(clszx_qa_PaperEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clszx_qa_PaperEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strZxqaPaperId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strZxqaPaperId)
{
strZxqaPaperId = strZxqaPaperId.Replace("'", "''");
if (strZxqaPaperId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:zx_qa_Paper中,检查关键字,长度不正确!(clszx_qa_PaperDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strZxqaPaperId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:zx_qa_Paper中,关键字不能为空 或 null!(clszx_qa_PaperDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strZxqaPaperId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clszx_qa_PaperDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_qa_PaperDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from zx_qa_Paper where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_zx_qa_Paper(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clszx_qa_PaperDA: GetDataTable_zx_qa_Paper)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from zx_qa_Paper where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clszx_qa_PaperDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clszx_qa_PaperDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from zx_qa_Paper where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clszx_qa_PaperDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clszx_qa_PaperDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_qa_Paper where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_qa_Paper where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clszx_qa_PaperDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from zx_qa_Paper where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clszx_qa_PaperDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_qa_Paper.* from zx_qa_Paper Left Join {1} on {2} where {3} and zx_qa_Paper.ZxqaPaperId not in (Select top {5} zx_qa_Paper.ZxqaPaperId from zx_qa_Paper Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_qa_Paper where {1} and ZxqaPaperId not in (Select top {2} ZxqaPaperId from zx_qa_Paper where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_qa_Paper where {1} and ZxqaPaperId not in (Select top {3} ZxqaPaperId from zx_qa_Paper where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clszx_qa_PaperDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_qa_Paper.* from zx_qa_Paper Left Join {1} on {2} where {3} and zx_qa_Paper.ZxqaPaperId not in (Select top {5} zx_qa_Paper.ZxqaPaperId from zx_qa_Paper Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_qa_Paper where {1} and ZxqaPaperId not in (Select top {2} ZxqaPaperId from zx_qa_Paper where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_qa_Paper where {1} and ZxqaPaperId not in (Select top {3} ZxqaPaperId from zx_qa_Paper where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clszx_qa_PaperEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clszx_qa_PaperDA:GetObjLst)", objException.Message));
}
List<clszx_qa_PaperEN> arrObjLst = new List<clszx_qa_PaperEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from zx_qa_Paper where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_qa_PaperEN objzx_qa_PaperEN = new clszx_qa_PaperEN();
try
{
objzx_qa_PaperEN.ZxqaPaperId = objRow[conzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objzx_qa_PaperEN.TextId = objRow[conzx_qa_Paper.TextId] == DBNull.Value ? null : objRow[conzx_qa_Paper.TextId].ToString().Trim(); //课件Id
objzx_qa_PaperEN.QuestionsCount = objRow[conzx_qa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_qa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objzx_qa_PaperEN.IsDelete = TransNullToBool(objRow[conzx_qa_Paper.IsDelete].ToString().Trim()); //是否删除
objzx_qa_PaperEN.IsPublic = TransNullToBool(objRow[conzx_qa_Paper.IsPublic].ToString().Trim()); //是否公开
objzx_qa_PaperEN.IsSubmit = TransNullToBool(objRow[conzx_qa_Paper.IsSubmit].ToString().Trim()); //是否提交
objzx_qa_PaperEN.UpdUser = objRow[conzx_qa_Paper.UpdUser] == DBNull.Value ? null : objRow[conzx_qa_Paper.UpdUser].ToString().Trim(); //修改人
objzx_qa_PaperEN.UpdDate = objRow[conzx_qa_Paper.UpdDate] == DBNull.Value ? null : objRow[conzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期
objzx_qa_PaperEN.Memo = objRow[conzx_qa_Paper.Memo] == DBNull.Value ? null : objRow[conzx_qa_Paper.Memo].ToString().Trim(); //备注
objzx_qa_PaperEN.IdCurrEduCls = objRow[conzx_qa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_qa_PaperEN.AnswerCount = objRow[conzx_qa_Paper.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_qa_Paper.AnswerCount].ToString().Trim()); //回答计数
objzx_qa_PaperEN.zxShareId = objRow[conzx_qa_Paper.zxShareId] == DBNull.Value ? null : objRow[conzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id
objzx_qa_PaperEN.TagsCount = objRow[conzx_qa_Paper.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_qa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_qa_PaperDA: GetObjLst)", objException.Message));
}
objzx_qa_PaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_qa_PaperEN);
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
public List<clszx_qa_PaperEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clszx_qa_PaperDA:GetObjLstByTabName)", objException.Message));
}
List<clszx_qa_PaperEN> arrObjLst = new List<clszx_qa_PaperEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_qa_PaperEN objzx_qa_PaperEN = new clszx_qa_PaperEN();
try
{
objzx_qa_PaperEN.ZxqaPaperId = objRow[conzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objzx_qa_PaperEN.TextId = objRow[conzx_qa_Paper.TextId] == DBNull.Value ? null : objRow[conzx_qa_Paper.TextId].ToString().Trim(); //课件Id
objzx_qa_PaperEN.QuestionsCount = objRow[conzx_qa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_qa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objzx_qa_PaperEN.IsDelete = TransNullToBool(objRow[conzx_qa_Paper.IsDelete].ToString().Trim()); //是否删除
objzx_qa_PaperEN.IsPublic = TransNullToBool(objRow[conzx_qa_Paper.IsPublic].ToString().Trim()); //是否公开
objzx_qa_PaperEN.IsSubmit = TransNullToBool(objRow[conzx_qa_Paper.IsSubmit].ToString().Trim()); //是否提交
objzx_qa_PaperEN.UpdUser = objRow[conzx_qa_Paper.UpdUser] == DBNull.Value ? null : objRow[conzx_qa_Paper.UpdUser].ToString().Trim(); //修改人
objzx_qa_PaperEN.UpdDate = objRow[conzx_qa_Paper.UpdDate] == DBNull.Value ? null : objRow[conzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期
objzx_qa_PaperEN.Memo = objRow[conzx_qa_Paper.Memo] == DBNull.Value ? null : objRow[conzx_qa_Paper.Memo].ToString().Trim(); //备注
objzx_qa_PaperEN.IdCurrEduCls = objRow[conzx_qa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_qa_PaperEN.AnswerCount = objRow[conzx_qa_Paper.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_qa_Paper.AnswerCount].ToString().Trim()); //回答计数
objzx_qa_PaperEN.zxShareId = objRow[conzx_qa_Paper.zxShareId] == DBNull.Value ? null : objRow[conzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id
objzx_qa_PaperEN.TagsCount = objRow[conzx_qa_Paper.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_qa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_qa_PaperDA: GetObjLst)", objException.Message));
}
objzx_qa_PaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_qa_PaperEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objzx_qa_PaperEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getzx_qa_Paper(ref clszx_qa_PaperEN objzx_qa_PaperEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from zx_qa_Paper where ZxqaPaperId = " + "'"+ objzx_qa_PaperEN.ZxqaPaperId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objzx_qa_PaperEN.ZxqaPaperId = objDT.Rows[0][conzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_qa_PaperEN.TextId = objDT.Rows[0][conzx_qa_Paper.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_qa_PaperEN.QuestionsCount = TransNullToInt(objDT.Rows[0][conzx_qa_Paper.QuestionsCount].ToString().Trim()); //提问计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_qa_PaperEN.IsDelete = TransNullToBool(objDT.Rows[0][conzx_qa_Paper.IsDelete].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objzx_qa_PaperEN.IsPublic = TransNullToBool(objDT.Rows[0][conzx_qa_Paper.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objzx_qa_PaperEN.IsSubmit = TransNullToBool(objDT.Rows[0][conzx_qa_Paper.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_qa_PaperEN.UpdUser = objDT.Rows[0][conzx_qa_Paper.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_qa_PaperEN.UpdDate = objDT.Rows[0][conzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_qa_PaperEN.Memo = objDT.Rows[0][conzx_qa_Paper.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_qa_PaperEN.IdCurrEduCls = objDT.Rows[0][conzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_qa_PaperEN.AnswerCount = TransNullToInt(objDT.Rows[0][conzx_qa_Paper.AnswerCount].ToString().Trim()); //回答计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_qa_PaperEN.zxShareId = objDT.Rows[0][conzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_qa_PaperEN.TagsCount = TransNullToInt(objDT.Rows[0][conzx_qa_Paper.TagsCount].ToString().Trim()); //论文标注数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clszx_qa_PaperDA: Getzx_qa_Paper)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strZxqaPaperId">表关键字</param>
 /// <returns>表对象</returns>
public clszx_qa_PaperEN GetObjByZxqaPaperId(string strZxqaPaperId)
{
CheckPrimaryKey(strZxqaPaperId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from zx_qa_Paper where ZxqaPaperId = " + "'"+ strZxqaPaperId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clszx_qa_PaperEN objzx_qa_PaperEN = new clszx_qa_PaperEN();
try
{
 objzx_qa_PaperEN.ZxqaPaperId = objRow[conzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_qa_PaperEN.TextId = objRow[conzx_qa_Paper.TextId] == DBNull.Value ? null : objRow[conzx_qa_Paper.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_qa_PaperEN.QuestionsCount = objRow[conzx_qa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.QuestionsCount].ToString().Trim()); //提问计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_qa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsDelete].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objzx_qa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objzx_qa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_qa_Paper.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_qa_PaperEN.UpdUser = objRow[conzx_qa_Paper.UpdUser] == DBNull.Value ? null : objRow[conzx_qa_Paper.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_qa_PaperEN.UpdDate = objRow[conzx_qa_Paper.UpdDate] == DBNull.Value ? null : objRow[conzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_qa_PaperEN.Memo = objRow[conzx_qa_Paper.Memo] == DBNull.Value ? null : objRow[conzx_qa_Paper.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_qa_PaperEN.IdCurrEduCls = objRow[conzx_qa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_qa_PaperEN.AnswerCount = objRow[conzx_qa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.AnswerCount].ToString().Trim()); //回答计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_qa_PaperEN.zxShareId = objRow[conzx_qa_Paper.zxShareId] == DBNull.Value ? null : objRow[conzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_qa_PaperEN.TagsCount = objRow[conzx_qa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_qa_Paper.TagsCount].ToString().Trim()); //论文标注数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clszx_qa_PaperDA: GetObjByZxqaPaperId)", objException.Message));
}
return objzx_qa_PaperEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clszx_qa_PaperEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clszx_qa_PaperDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from zx_qa_Paper where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clszx_qa_PaperEN objzx_qa_PaperEN = new clszx_qa_PaperEN()
{
ZxqaPaperId = objRow[conzx_qa_Paper.ZxqaPaperId].ToString().Trim(), //论文答疑Id
TextId = objRow[conzx_qa_Paper.TextId] == DBNull.Value ? null : objRow[conzx_qa_Paper.TextId].ToString().Trim(), //课件Id
QuestionsCount = objRow[conzx_qa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_qa_Paper.QuestionsCount].ToString().Trim()), //提问计数
IsDelete = TransNullToBool(objRow[conzx_qa_Paper.IsDelete].ToString().Trim()), //是否删除
IsPublic = TransNullToBool(objRow[conzx_qa_Paper.IsPublic].ToString().Trim()), //是否公开
IsSubmit = TransNullToBool(objRow[conzx_qa_Paper.IsSubmit].ToString().Trim()), //是否提交
UpdUser = objRow[conzx_qa_Paper.UpdUser] == DBNull.Value ? null : objRow[conzx_qa_Paper.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[conzx_qa_Paper.UpdDate] == DBNull.Value ? null : objRow[conzx_qa_Paper.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conzx_qa_Paper.Memo] == DBNull.Value ? null : objRow[conzx_qa_Paper.Memo].ToString().Trim(), //备注
IdCurrEduCls = objRow[conzx_qa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_qa_Paper.IdCurrEduCls].ToString().Trim(), //教学班流水号
AnswerCount = objRow[conzx_qa_Paper.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_qa_Paper.AnswerCount].ToString().Trim()), //回答计数
zxShareId = objRow[conzx_qa_Paper.zxShareId] == DBNull.Value ? null : objRow[conzx_qa_Paper.zxShareId].ToString().Trim(), //分享Id
TagsCount = objRow[conzx_qa_Paper.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_qa_Paper.TagsCount].ToString().Trim()) //论文标注数
};
objzx_qa_PaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_qa_PaperEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clszx_qa_PaperDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clszx_qa_PaperEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_qa_PaperEN objzx_qa_PaperEN = new clszx_qa_PaperEN();
try
{
objzx_qa_PaperEN.ZxqaPaperId = objRow[conzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objzx_qa_PaperEN.TextId = objRow[conzx_qa_Paper.TextId] == DBNull.Value ? null : objRow[conzx_qa_Paper.TextId].ToString().Trim(); //课件Id
objzx_qa_PaperEN.QuestionsCount = objRow[conzx_qa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_qa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objzx_qa_PaperEN.IsDelete = TransNullToBool(objRow[conzx_qa_Paper.IsDelete].ToString().Trim()); //是否删除
objzx_qa_PaperEN.IsPublic = TransNullToBool(objRow[conzx_qa_Paper.IsPublic].ToString().Trim()); //是否公开
objzx_qa_PaperEN.IsSubmit = TransNullToBool(objRow[conzx_qa_Paper.IsSubmit].ToString().Trim()); //是否提交
objzx_qa_PaperEN.UpdUser = objRow[conzx_qa_Paper.UpdUser] == DBNull.Value ? null : objRow[conzx_qa_Paper.UpdUser].ToString().Trim(); //修改人
objzx_qa_PaperEN.UpdDate = objRow[conzx_qa_Paper.UpdDate] == DBNull.Value ? null : objRow[conzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期
objzx_qa_PaperEN.Memo = objRow[conzx_qa_Paper.Memo] == DBNull.Value ? null : objRow[conzx_qa_Paper.Memo].ToString().Trim(); //备注
objzx_qa_PaperEN.IdCurrEduCls = objRow[conzx_qa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_qa_PaperEN.AnswerCount = objRow[conzx_qa_Paper.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_qa_Paper.AnswerCount].ToString().Trim()); //回答计数
objzx_qa_PaperEN.zxShareId = objRow[conzx_qa_Paper.zxShareId] == DBNull.Value ? null : objRow[conzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id
objzx_qa_PaperEN.TagsCount = objRow[conzx_qa_Paper.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_qa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clszx_qa_PaperDA: GetObjByDataRowzx_qa_Paper)", objException.Message));
}
objzx_qa_PaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_qa_PaperEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clszx_qa_PaperEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_qa_PaperEN objzx_qa_PaperEN = new clszx_qa_PaperEN();
try
{
objzx_qa_PaperEN.ZxqaPaperId = objRow[conzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objzx_qa_PaperEN.TextId = objRow[conzx_qa_Paper.TextId] == DBNull.Value ? null : objRow[conzx_qa_Paper.TextId].ToString().Trim(); //课件Id
objzx_qa_PaperEN.QuestionsCount = objRow[conzx_qa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_qa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objzx_qa_PaperEN.IsDelete = TransNullToBool(objRow[conzx_qa_Paper.IsDelete].ToString().Trim()); //是否删除
objzx_qa_PaperEN.IsPublic = TransNullToBool(objRow[conzx_qa_Paper.IsPublic].ToString().Trim()); //是否公开
objzx_qa_PaperEN.IsSubmit = TransNullToBool(objRow[conzx_qa_Paper.IsSubmit].ToString().Trim()); //是否提交
objzx_qa_PaperEN.UpdUser = objRow[conzx_qa_Paper.UpdUser] == DBNull.Value ? null : objRow[conzx_qa_Paper.UpdUser].ToString().Trim(); //修改人
objzx_qa_PaperEN.UpdDate = objRow[conzx_qa_Paper.UpdDate] == DBNull.Value ? null : objRow[conzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期
objzx_qa_PaperEN.Memo = objRow[conzx_qa_Paper.Memo] == DBNull.Value ? null : objRow[conzx_qa_Paper.Memo].ToString().Trim(); //备注
objzx_qa_PaperEN.IdCurrEduCls = objRow[conzx_qa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_qa_PaperEN.AnswerCount = objRow[conzx_qa_Paper.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_qa_Paper.AnswerCount].ToString().Trim()); //回答计数
objzx_qa_PaperEN.zxShareId = objRow[conzx_qa_Paper.zxShareId] == DBNull.Value ? null : objRow[conzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id
objzx_qa_PaperEN.TagsCount = objRow[conzx_qa_Paper.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_qa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clszx_qa_PaperDA: GetObjByDataRow)", objException.Message));
}
objzx_qa_PaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_qa_PaperEN;
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
objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_qa_PaperEN._CurrTabName, conzx_qa_Paper.ZxqaPaperId, 8, "");
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
objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_qa_PaperEN._CurrTabName, conzx_qa_Paper.ZxqaPaperId, 8, strPrefix);
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
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ZxqaPaperId from zx_qa_Paper where " + strCondition;
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
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ZxqaPaperId from zx_qa_Paper where " + strCondition;
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
 /// <param name = "strZxqaPaperId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strZxqaPaperId)
{
CheckPrimaryKey(strZxqaPaperId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_qa_Paper", "ZxqaPaperId = " + "'"+ strZxqaPaperId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clszx_qa_PaperDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_qa_Paper", strCondition))
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
objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("zx_qa_Paper");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clszx_qa_PaperEN objzx_qa_PaperEN)
 {
 if (objzx_qa_PaperEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_qa_PaperEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from zx_qa_Paper where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_qa_Paper");
objRow = objDS.Tables["zx_qa_Paper"].NewRow();
objRow[conzx_qa_Paper.ZxqaPaperId] = objzx_qa_PaperEN.ZxqaPaperId; //论文答疑Id
 if (objzx_qa_PaperEN.TextId !=  "")
 {
objRow[conzx_qa_Paper.TextId] = objzx_qa_PaperEN.TextId; //课件Id
 }
objRow[conzx_qa_Paper.QuestionsCount] = objzx_qa_PaperEN.QuestionsCount; //提问计数
objRow[conzx_qa_Paper.IsDelete] = objzx_qa_PaperEN.IsDelete; //是否删除
objRow[conzx_qa_Paper.IsPublic] = objzx_qa_PaperEN.IsPublic; //是否公开
objRow[conzx_qa_Paper.IsSubmit] = objzx_qa_PaperEN.IsSubmit; //是否提交
 if (objzx_qa_PaperEN.UpdUser !=  "")
 {
objRow[conzx_qa_Paper.UpdUser] = objzx_qa_PaperEN.UpdUser; //修改人
 }
 if (objzx_qa_PaperEN.UpdDate !=  "")
 {
objRow[conzx_qa_Paper.UpdDate] = objzx_qa_PaperEN.UpdDate; //修改日期
 }
 if (objzx_qa_PaperEN.Memo !=  "")
 {
objRow[conzx_qa_Paper.Memo] = objzx_qa_PaperEN.Memo; //备注
 }
 if (objzx_qa_PaperEN.IdCurrEduCls !=  "")
 {
objRow[conzx_qa_Paper.IdCurrEduCls] = objzx_qa_PaperEN.IdCurrEduCls; //教学班流水号
 }
objRow[conzx_qa_Paper.AnswerCount] = objzx_qa_PaperEN.AnswerCount; //回答计数
 if (objzx_qa_PaperEN.zxShareId !=  "")
 {
objRow[conzx_qa_Paper.zxShareId] = objzx_qa_PaperEN.zxShareId; //分享Id
 }
objRow[conzx_qa_Paper.TagsCount] = objzx_qa_PaperEN.TagsCount; //论文标注数
objDS.Tables[clszx_qa_PaperEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clszx_qa_PaperEN._CurrTabName);
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
 /// <param name = "objzx_qa_PaperEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_qa_PaperEN objzx_qa_PaperEN)
{
 if (objzx_qa_PaperEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_qa_PaperEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_qa_PaperEN.ZxqaPaperId !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.ZxqaPaperId);
 var strZxqaPaperId = objzx_qa_PaperEN.ZxqaPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strZxqaPaperId + "'");
 }
 
 if (objzx_qa_PaperEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.TextId);
 var strTextId = objzx_qa_PaperEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_qa_PaperEN.QuestionsCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.QuestionsCount);
 arrValueListForInsert.Add(objzx_qa_PaperEN.QuestionsCount.ToString());
 }
 
 arrFieldListForInsert.Add(conzx_qa_Paper.IsDelete);
 arrValueListForInsert.Add("'" + (objzx_qa_PaperEN.IsDelete  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conzx_qa_Paper.IsPublic);
 arrValueListForInsert.Add("'" + (objzx_qa_PaperEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conzx_qa_Paper.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_qa_PaperEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_qa_PaperEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.UpdUser);
 var strUpdUser = objzx_qa_PaperEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_qa_PaperEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.UpdDate);
 var strUpdDate = objzx_qa_PaperEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_qa_PaperEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.Memo);
 var strMemo = objzx_qa_PaperEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_qa_PaperEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.IdCurrEduCls);
 var strIdCurrEduCls = objzx_qa_PaperEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_qa_PaperEN.AnswerCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.AnswerCount);
 arrValueListForInsert.Add(objzx_qa_PaperEN.AnswerCount.ToString());
 }
 
 if (objzx_qa_PaperEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.zxShareId);
 var strzxShareId = objzx_qa_PaperEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_qa_PaperEN.TagsCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.TagsCount);
 arrValueListForInsert.Add(objzx_qa_PaperEN.TagsCount.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_qa_Paper");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objzx_qa_PaperEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_qa_PaperEN objzx_qa_PaperEN)
{
 if (objzx_qa_PaperEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_qa_PaperEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_qa_PaperEN.ZxqaPaperId !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.ZxqaPaperId);
 var strZxqaPaperId = objzx_qa_PaperEN.ZxqaPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strZxqaPaperId + "'");
 }
 
 if (objzx_qa_PaperEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.TextId);
 var strTextId = objzx_qa_PaperEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_qa_PaperEN.QuestionsCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.QuestionsCount);
 arrValueListForInsert.Add(objzx_qa_PaperEN.QuestionsCount.ToString());
 }
 
 arrFieldListForInsert.Add(conzx_qa_Paper.IsDelete);
 arrValueListForInsert.Add("'" + (objzx_qa_PaperEN.IsDelete  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conzx_qa_Paper.IsPublic);
 arrValueListForInsert.Add("'" + (objzx_qa_PaperEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conzx_qa_Paper.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_qa_PaperEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_qa_PaperEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.UpdUser);
 var strUpdUser = objzx_qa_PaperEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_qa_PaperEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.UpdDate);
 var strUpdDate = objzx_qa_PaperEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_qa_PaperEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.Memo);
 var strMemo = objzx_qa_PaperEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_qa_PaperEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.IdCurrEduCls);
 var strIdCurrEduCls = objzx_qa_PaperEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_qa_PaperEN.AnswerCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.AnswerCount);
 arrValueListForInsert.Add(objzx_qa_PaperEN.AnswerCount.ToString());
 }
 
 if (objzx_qa_PaperEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.zxShareId);
 var strzxShareId = objzx_qa_PaperEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_qa_PaperEN.TagsCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.TagsCount);
 arrValueListForInsert.Add(objzx_qa_PaperEN.TagsCount.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_qa_Paper");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objzx_qa_PaperEN.ZxqaPaperId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objzx_qa_PaperEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_qa_PaperEN objzx_qa_PaperEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_qa_PaperEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_qa_PaperEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_qa_PaperEN.ZxqaPaperId !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.ZxqaPaperId);
 var strZxqaPaperId = objzx_qa_PaperEN.ZxqaPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strZxqaPaperId + "'");
 }
 
 if (objzx_qa_PaperEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.TextId);
 var strTextId = objzx_qa_PaperEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_qa_PaperEN.QuestionsCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.QuestionsCount);
 arrValueListForInsert.Add(objzx_qa_PaperEN.QuestionsCount.ToString());
 }
 
 arrFieldListForInsert.Add(conzx_qa_Paper.IsDelete);
 arrValueListForInsert.Add("'" + (objzx_qa_PaperEN.IsDelete  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conzx_qa_Paper.IsPublic);
 arrValueListForInsert.Add("'" + (objzx_qa_PaperEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conzx_qa_Paper.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_qa_PaperEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_qa_PaperEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.UpdUser);
 var strUpdUser = objzx_qa_PaperEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_qa_PaperEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.UpdDate);
 var strUpdDate = objzx_qa_PaperEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_qa_PaperEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.Memo);
 var strMemo = objzx_qa_PaperEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_qa_PaperEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.IdCurrEduCls);
 var strIdCurrEduCls = objzx_qa_PaperEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_qa_PaperEN.AnswerCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.AnswerCount);
 arrValueListForInsert.Add(objzx_qa_PaperEN.AnswerCount.ToString());
 }
 
 if (objzx_qa_PaperEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.zxShareId);
 var strzxShareId = objzx_qa_PaperEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_qa_PaperEN.TagsCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.TagsCount);
 arrValueListForInsert.Add(objzx_qa_PaperEN.TagsCount.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_qa_Paper");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objzx_qa_PaperEN.ZxqaPaperId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objzx_qa_PaperEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_qa_PaperEN objzx_qa_PaperEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_qa_PaperEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_qa_PaperEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_qa_PaperEN.ZxqaPaperId !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.ZxqaPaperId);
 var strZxqaPaperId = objzx_qa_PaperEN.ZxqaPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strZxqaPaperId + "'");
 }
 
 if (objzx_qa_PaperEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.TextId);
 var strTextId = objzx_qa_PaperEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_qa_PaperEN.QuestionsCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.QuestionsCount);
 arrValueListForInsert.Add(objzx_qa_PaperEN.QuestionsCount.ToString());
 }
 
 arrFieldListForInsert.Add(conzx_qa_Paper.IsDelete);
 arrValueListForInsert.Add("'" + (objzx_qa_PaperEN.IsDelete  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conzx_qa_Paper.IsPublic);
 arrValueListForInsert.Add("'" + (objzx_qa_PaperEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conzx_qa_Paper.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_qa_PaperEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_qa_PaperEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.UpdUser);
 var strUpdUser = objzx_qa_PaperEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_qa_PaperEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.UpdDate);
 var strUpdDate = objzx_qa_PaperEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_qa_PaperEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.Memo);
 var strMemo = objzx_qa_PaperEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_qa_PaperEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.IdCurrEduCls);
 var strIdCurrEduCls = objzx_qa_PaperEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_qa_PaperEN.AnswerCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.AnswerCount);
 arrValueListForInsert.Add(objzx_qa_PaperEN.AnswerCount.ToString());
 }
 
 if (objzx_qa_PaperEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.zxShareId);
 var strzxShareId = objzx_qa_PaperEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_qa_PaperEN.TagsCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_qa_Paper.TagsCount);
 arrValueListForInsert.Add(objzx_qa_PaperEN.TagsCount.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_qa_Paper");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewzx_qa_Papers(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from zx_qa_Paper where ZxqaPaperId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_qa_Paper");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strZxqaPaperId = oRow[conzx_qa_Paper.ZxqaPaperId].ToString().Trim();
if (IsExist(strZxqaPaperId))
{
 string strResult = "关键字变量值为:" + string.Format("ZxqaPaperId = {0}", strZxqaPaperId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clszx_qa_PaperEN._CurrTabName ].NewRow();
objRow[conzx_qa_Paper.ZxqaPaperId] = oRow[conzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objRow[conzx_qa_Paper.TextId] = oRow[conzx_qa_Paper.TextId].ToString().Trim(); //课件Id
objRow[conzx_qa_Paper.QuestionsCount] = oRow[conzx_qa_Paper.QuestionsCount].ToString().Trim(); //提问计数
objRow[conzx_qa_Paper.IsDelete] = oRow[conzx_qa_Paper.IsDelete].ToString().Trim(); //是否删除
objRow[conzx_qa_Paper.IsPublic] = oRow[conzx_qa_Paper.IsPublic].ToString().Trim(); //是否公开
objRow[conzx_qa_Paper.IsSubmit] = oRow[conzx_qa_Paper.IsSubmit].ToString().Trim(); //是否提交
objRow[conzx_qa_Paper.UpdUser] = oRow[conzx_qa_Paper.UpdUser].ToString().Trim(); //修改人
objRow[conzx_qa_Paper.UpdDate] = oRow[conzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期
objRow[conzx_qa_Paper.Memo] = oRow[conzx_qa_Paper.Memo].ToString().Trim(); //备注
objRow[conzx_qa_Paper.IdCurrEduCls] = oRow[conzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conzx_qa_Paper.AnswerCount] = oRow[conzx_qa_Paper.AnswerCount].ToString().Trim(); //回答计数
objRow[conzx_qa_Paper.zxShareId] = oRow[conzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id
objRow[conzx_qa_Paper.TagsCount] = oRow[conzx_qa_Paper.TagsCount].ToString().Trim(); //论文标注数
 objDS.Tables[clszx_qa_PaperEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clszx_qa_PaperEN._CurrTabName);
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
 /// <param name = "objzx_qa_PaperEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clszx_qa_PaperEN objzx_qa_PaperEN)
{
 if (objzx_qa_PaperEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_qa_PaperEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from zx_qa_Paper where ZxqaPaperId = " + "'"+ objzx_qa_PaperEN.ZxqaPaperId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clszx_qa_PaperEN._CurrTabName);
if (objDS.Tables[clszx_qa_PaperEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ZxqaPaperId = " + "'"+ objzx_qa_PaperEN.ZxqaPaperId+"'");
return false;
}
objRow = objDS.Tables[clszx_qa_PaperEN._CurrTabName].Rows[0];
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.ZxqaPaperId))
 {
objRow[conzx_qa_Paper.ZxqaPaperId] = objzx_qa_PaperEN.ZxqaPaperId; //论文答疑Id
 }
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.TextId))
 {
objRow[conzx_qa_Paper.TextId] = objzx_qa_PaperEN.TextId; //课件Id
 }
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.QuestionsCount))
 {
objRow[conzx_qa_Paper.QuestionsCount] = objzx_qa_PaperEN.QuestionsCount; //提问计数
 }
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.IsDelete))
 {
objRow[conzx_qa_Paper.IsDelete] = objzx_qa_PaperEN.IsDelete; //是否删除
 }
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.IsPublic))
 {
objRow[conzx_qa_Paper.IsPublic] = objzx_qa_PaperEN.IsPublic; //是否公开
 }
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.IsSubmit))
 {
objRow[conzx_qa_Paper.IsSubmit] = objzx_qa_PaperEN.IsSubmit; //是否提交
 }
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.UpdUser))
 {
objRow[conzx_qa_Paper.UpdUser] = objzx_qa_PaperEN.UpdUser; //修改人
 }
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.UpdDate))
 {
objRow[conzx_qa_Paper.UpdDate] = objzx_qa_PaperEN.UpdDate; //修改日期
 }
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.Memo))
 {
objRow[conzx_qa_Paper.Memo] = objzx_qa_PaperEN.Memo; //备注
 }
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.IdCurrEduCls))
 {
objRow[conzx_qa_Paper.IdCurrEduCls] = objzx_qa_PaperEN.IdCurrEduCls; //教学班流水号
 }
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.AnswerCount))
 {
objRow[conzx_qa_Paper.AnswerCount] = objzx_qa_PaperEN.AnswerCount; //回答计数
 }
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.zxShareId))
 {
objRow[conzx_qa_Paper.zxShareId] = objzx_qa_PaperEN.zxShareId; //分享Id
 }
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.TagsCount))
 {
objRow[conzx_qa_Paper.TagsCount] = objzx_qa_PaperEN.TagsCount; //论文标注数
 }
try
{
objDA.Update(objDS, clszx_qa_PaperEN._CurrTabName);
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
 /// <param name = "objzx_qa_PaperEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_qa_PaperEN objzx_qa_PaperEN)
{
 if (objzx_qa_PaperEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_qa_PaperEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update zx_qa_Paper Set ");
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.TextId))
 {
 if (objzx_qa_PaperEN.TextId !=  null)
 {
 var strTextId = objzx_qa_PaperEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_qa_Paper.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_qa_Paper.TextId); //课件Id
 }
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.QuestionsCount))
 {
 if (objzx_qa_PaperEN.QuestionsCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_qa_PaperEN.QuestionsCount, conzx_qa_Paper.QuestionsCount); //提问计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_qa_Paper.QuestionsCount); //提问计数
 }
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.IsDelete))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_qa_PaperEN.IsDelete == true?"1":"0", conzx_qa_Paper.IsDelete); //是否删除
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.IsPublic))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_qa_PaperEN.IsPublic == true?"1":"0", conzx_qa_Paper.IsPublic); //是否公开
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_qa_PaperEN.IsSubmit == true?"1":"0", conzx_qa_Paper.IsSubmit); //是否提交
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.UpdUser))
 {
 if (objzx_qa_PaperEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_qa_PaperEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_qa_Paper.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_qa_Paper.UpdUser); //修改人
 }
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.UpdDate))
 {
 if (objzx_qa_PaperEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_qa_PaperEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_qa_Paper.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_qa_Paper.UpdDate); //修改日期
 }
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.Memo))
 {
 if (objzx_qa_PaperEN.Memo !=  null)
 {
 var strMemo = objzx_qa_PaperEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_qa_Paper.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_qa_Paper.Memo); //备注
 }
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.IdCurrEduCls))
 {
 if (objzx_qa_PaperEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_qa_PaperEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_qa_Paper.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_qa_Paper.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.AnswerCount))
 {
 if (objzx_qa_PaperEN.AnswerCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_qa_PaperEN.AnswerCount, conzx_qa_Paper.AnswerCount); //回答计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_qa_Paper.AnswerCount); //回答计数
 }
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.zxShareId))
 {
 if (objzx_qa_PaperEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_qa_PaperEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxShareId, conzx_qa_Paper.zxShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_qa_Paper.zxShareId); //分享Id
 }
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.TagsCount))
 {
 if (objzx_qa_PaperEN.TagsCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_qa_PaperEN.TagsCount, conzx_qa_Paper.TagsCount); //论文标注数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_qa_Paper.TagsCount); //论文标注数
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ZxqaPaperId = '{0}'", objzx_qa_PaperEN.ZxqaPaperId); 
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
 /// <param name = "objzx_qa_PaperEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clszx_qa_PaperEN objzx_qa_PaperEN, string strCondition)
{
 if (objzx_qa_PaperEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_qa_PaperEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_qa_Paper Set ");
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.TextId))
 {
 if (objzx_qa_PaperEN.TextId !=  null)
 {
 var strTextId = objzx_qa_PaperEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.QuestionsCount))
 {
 if (objzx_qa_PaperEN.QuestionsCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_qa_PaperEN.QuestionsCount, conzx_qa_Paper.QuestionsCount); //提问计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_qa_Paper.QuestionsCount); //提问计数
 }
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.IsDelete))
 {
 sbSQL.AppendFormat(" IsDelete = '{0}',", objzx_qa_PaperEN.IsDelete == true?"1":"0"); //是否删除
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.IsPublic))
 {
 sbSQL.AppendFormat(" IsPublic = '{0}',", objzx_qa_PaperEN.IsPublic == true?"1":"0"); //是否公开
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_qa_PaperEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.UpdUser))
 {
 if (objzx_qa_PaperEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_qa_PaperEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.UpdDate))
 {
 if (objzx_qa_PaperEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_qa_PaperEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.Memo))
 {
 if (objzx_qa_PaperEN.Memo !=  null)
 {
 var strMemo = objzx_qa_PaperEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.IdCurrEduCls))
 {
 if (objzx_qa_PaperEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_qa_PaperEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.AnswerCount))
 {
 if (objzx_qa_PaperEN.AnswerCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_qa_PaperEN.AnswerCount, conzx_qa_Paper.AnswerCount); //回答计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_qa_Paper.AnswerCount); //回答计数
 }
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.zxShareId))
 {
 if (objzx_qa_PaperEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_qa_PaperEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxShareId = '{0}',", strzxShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" zxShareId = null,"); //分享Id
 }
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.TagsCount))
 {
 if (objzx_qa_PaperEN.TagsCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_qa_PaperEN.TagsCount, conzx_qa_Paper.TagsCount); //论文标注数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_qa_Paper.TagsCount); //论文标注数
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
 /// <param name = "objzx_qa_PaperEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clszx_qa_PaperEN objzx_qa_PaperEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_qa_PaperEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_qa_PaperEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_qa_Paper Set ");
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.TextId))
 {
 if (objzx_qa_PaperEN.TextId !=  null)
 {
 var strTextId = objzx_qa_PaperEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.QuestionsCount))
 {
 if (objzx_qa_PaperEN.QuestionsCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_qa_PaperEN.QuestionsCount, conzx_qa_Paper.QuestionsCount); //提问计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_qa_Paper.QuestionsCount); //提问计数
 }
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.IsDelete))
 {
 sbSQL.AppendFormat(" IsDelete = '{0}',", objzx_qa_PaperEN.IsDelete == true?"1":"0"); //是否删除
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.IsPublic))
 {
 sbSQL.AppendFormat(" IsPublic = '{0}',", objzx_qa_PaperEN.IsPublic == true?"1":"0"); //是否公开
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_qa_PaperEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.UpdUser))
 {
 if (objzx_qa_PaperEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_qa_PaperEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.UpdDate))
 {
 if (objzx_qa_PaperEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_qa_PaperEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.Memo))
 {
 if (objzx_qa_PaperEN.Memo !=  null)
 {
 var strMemo = objzx_qa_PaperEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.IdCurrEduCls))
 {
 if (objzx_qa_PaperEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_qa_PaperEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.AnswerCount))
 {
 if (objzx_qa_PaperEN.AnswerCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_qa_PaperEN.AnswerCount, conzx_qa_Paper.AnswerCount); //回答计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_qa_Paper.AnswerCount); //回答计数
 }
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.zxShareId))
 {
 if (objzx_qa_PaperEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_qa_PaperEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxShareId = '{0}',", strzxShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" zxShareId = null,"); //分享Id
 }
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.TagsCount))
 {
 if (objzx_qa_PaperEN.TagsCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_qa_PaperEN.TagsCount, conzx_qa_Paper.TagsCount); //论文标注数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_qa_Paper.TagsCount); //论文标注数
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
 /// <param name = "objzx_qa_PaperEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_qa_PaperEN objzx_qa_PaperEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_qa_PaperEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_qa_PaperEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_qa_Paper Set ");
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.TextId))
 {
 if (objzx_qa_PaperEN.TextId !=  null)
 {
 var strTextId = objzx_qa_PaperEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_qa_Paper.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_qa_Paper.TextId); //课件Id
 }
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.QuestionsCount))
 {
 if (objzx_qa_PaperEN.QuestionsCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_qa_PaperEN.QuestionsCount, conzx_qa_Paper.QuestionsCount); //提问计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_qa_Paper.QuestionsCount); //提问计数
 }
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.IsDelete))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_qa_PaperEN.IsDelete == true?"1":"0", conzx_qa_Paper.IsDelete); //是否删除
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.IsPublic))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_qa_PaperEN.IsPublic == true?"1":"0", conzx_qa_Paper.IsPublic); //是否公开
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_qa_PaperEN.IsSubmit == true?"1":"0", conzx_qa_Paper.IsSubmit); //是否提交
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.UpdUser))
 {
 if (objzx_qa_PaperEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_qa_PaperEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_qa_Paper.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_qa_Paper.UpdUser); //修改人
 }
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.UpdDate))
 {
 if (objzx_qa_PaperEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_qa_PaperEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_qa_Paper.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_qa_Paper.UpdDate); //修改日期
 }
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.Memo))
 {
 if (objzx_qa_PaperEN.Memo !=  null)
 {
 var strMemo = objzx_qa_PaperEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_qa_Paper.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_qa_Paper.Memo); //备注
 }
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.IdCurrEduCls))
 {
 if (objzx_qa_PaperEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_qa_PaperEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_qa_Paper.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_qa_Paper.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.AnswerCount))
 {
 if (objzx_qa_PaperEN.AnswerCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_qa_PaperEN.AnswerCount, conzx_qa_Paper.AnswerCount); //回答计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_qa_Paper.AnswerCount); //回答计数
 }
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.zxShareId))
 {
 if (objzx_qa_PaperEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_qa_PaperEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxShareId, conzx_qa_Paper.zxShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_qa_Paper.zxShareId); //分享Id
 }
 }
 
 if (objzx_qa_PaperEN.IsUpdated(conzx_qa_Paper.TagsCount))
 {
 if (objzx_qa_PaperEN.TagsCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_qa_PaperEN.TagsCount, conzx_qa_Paper.TagsCount); //论文标注数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_qa_Paper.TagsCount); //论文标注数
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ZxqaPaperId = '{0}'", objzx_qa_PaperEN.ZxqaPaperId); 
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
 /// <param name = "strZxqaPaperId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strZxqaPaperId) 
{
CheckPrimaryKey(strZxqaPaperId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strZxqaPaperId,
};
 objSQL.ExecSP("zx_qa_Paper_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strZxqaPaperId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strZxqaPaperId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strZxqaPaperId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
//删除zx_qa_Paper本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_qa_Paper where ZxqaPaperId = " + "'"+ strZxqaPaperId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delzx_qa_Paper(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
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
//删除zx_qa_Paper本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_qa_Paper where ZxqaPaperId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strZxqaPaperId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strZxqaPaperId) 
{
CheckPrimaryKey(strZxqaPaperId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
//删除zx_qa_Paper本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_qa_Paper where ZxqaPaperId = " + "'"+ strZxqaPaperId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delzx_qa_Paper(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clszx_qa_PaperDA: Delzx_qa_Paper)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_qa_Paper where " + strCondition ;
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
public bool Delzx_qa_PaperWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clszx_qa_PaperDA: Delzx_qa_PaperWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_qa_Paper where " + strCondition ;
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
 /// <param name = "objzx_qa_PaperENS">源对象</param>
 /// <param name = "objzx_qa_PaperENT">目标对象</param>
public void CopyTo(clszx_qa_PaperEN objzx_qa_PaperENS, clszx_qa_PaperEN objzx_qa_PaperENT)
{
objzx_qa_PaperENT.ZxqaPaperId = objzx_qa_PaperENS.ZxqaPaperId; //论文答疑Id
objzx_qa_PaperENT.TextId = objzx_qa_PaperENS.TextId; //课件Id
objzx_qa_PaperENT.QuestionsCount = objzx_qa_PaperENS.QuestionsCount; //提问计数
objzx_qa_PaperENT.IsDelete = objzx_qa_PaperENS.IsDelete; //是否删除
objzx_qa_PaperENT.IsPublic = objzx_qa_PaperENS.IsPublic; //是否公开
objzx_qa_PaperENT.IsSubmit = objzx_qa_PaperENS.IsSubmit; //是否提交
objzx_qa_PaperENT.UpdUser = objzx_qa_PaperENS.UpdUser; //修改人
objzx_qa_PaperENT.UpdDate = objzx_qa_PaperENS.UpdDate; //修改日期
objzx_qa_PaperENT.Memo = objzx_qa_PaperENS.Memo; //备注
objzx_qa_PaperENT.IdCurrEduCls = objzx_qa_PaperENS.IdCurrEduCls; //教学班流水号
objzx_qa_PaperENT.AnswerCount = objzx_qa_PaperENS.AnswerCount; //回答计数
objzx_qa_PaperENT.zxShareId = objzx_qa_PaperENS.zxShareId; //分享Id
objzx_qa_PaperENT.TagsCount = objzx_qa_PaperENS.TagsCount; //论文标注数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clszx_qa_PaperEN objzx_qa_PaperEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_qa_PaperEN.ZxqaPaperId, 8, conzx_qa_Paper.ZxqaPaperId);
clsCheckSql.CheckFieldLen(objzx_qa_PaperEN.TextId, 8, conzx_qa_Paper.TextId);
clsCheckSql.CheckFieldLen(objzx_qa_PaperEN.UpdUser, 20, conzx_qa_Paper.UpdUser);
clsCheckSql.CheckFieldLen(objzx_qa_PaperEN.UpdDate, 20, conzx_qa_Paper.UpdDate);
clsCheckSql.CheckFieldLen(objzx_qa_PaperEN.Memo, 1000, conzx_qa_Paper.Memo);
clsCheckSql.CheckFieldLen(objzx_qa_PaperEN.IdCurrEduCls, 8, conzx_qa_Paper.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_qa_PaperEN.zxShareId, 2, conzx_qa_Paper.zxShareId);
//检查字段外键固定长度
 objzx_qa_PaperEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clszx_qa_PaperEN objzx_qa_PaperEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_qa_PaperEN.TextId, 8, conzx_qa_Paper.TextId);
clsCheckSql.CheckFieldLen(objzx_qa_PaperEN.UpdUser, 20, conzx_qa_Paper.UpdUser);
clsCheckSql.CheckFieldLen(objzx_qa_PaperEN.UpdDate, 20, conzx_qa_Paper.UpdDate);
clsCheckSql.CheckFieldLen(objzx_qa_PaperEN.Memo, 1000, conzx_qa_Paper.Memo);
clsCheckSql.CheckFieldLen(objzx_qa_PaperEN.IdCurrEduCls, 8, conzx_qa_Paper.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_qa_PaperEN.zxShareId, 2, conzx_qa_Paper.zxShareId);
//检查外键字段长度
 objzx_qa_PaperEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clszx_qa_PaperEN objzx_qa_PaperEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_qa_PaperEN.ZxqaPaperId, 8, conzx_qa_Paper.ZxqaPaperId);
clsCheckSql.CheckFieldLen(objzx_qa_PaperEN.TextId, 8, conzx_qa_Paper.TextId);
clsCheckSql.CheckFieldLen(objzx_qa_PaperEN.UpdUser, 20, conzx_qa_Paper.UpdUser);
clsCheckSql.CheckFieldLen(objzx_qa_PaperEN.UpdDate, 20, conzx_qa_Paper.UpdDate);
clsCheckSql.CheckFieldLen(objzx_qa_PaperEN.Memo, 1000, conzx_qa_Paper.Memo);
clsCheckSql.CheckFieldLen(objzx_qa_PaperEN.IdCurrEduCls, 8, conzx_qa_Paper.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_qa_PaperEN.zxShareId, 2, conzx_qa_Paper.zxShareId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objzx_qa_PaperEN.ZxqaPaperId, conzx_qa_Paper.ZxqaPaperId);
clsCheckSql.CheckSqlInjection4Field(objzx_qa_PaperEN.TextId, conzx_qa_Paper.TextId);
clsCheckSql.CheckSqlInjection4Field(objzx_qa_PaperEN.UpdUser, conzx_qa_Paper.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objzx_qa_PaperEN.UpdDate, conzx_qa_Paper.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objzx_qa_PaperEN.Memo, conzx_qa_Paper.Memo);
clsCheckSql.CheckSqlInjection4Field(objzx_qa_PaperEN.IdCurrEduCls, conzx_qa_Paper.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objzx_qa_PaperEN.zxShareId, conzx_qa_Paper.zxShareId);
//检查外键字段长度
 objzx_qa_PaperEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--zx_qa_Paper(中学论文答疑表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_qa_PaperEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clszx_qa_PaperEN objzx_qa_PaperEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ZxqaPaperId = '{0}'", objzx_qa_PaperEN.ZxqaPaperId);
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
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
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
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
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
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_qa_PaperEN._CurrTabName);
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
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_qa_PaperEN._CurrTabName, strCondition);
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
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
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
 objSQL = clszx_qa_PaperDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}