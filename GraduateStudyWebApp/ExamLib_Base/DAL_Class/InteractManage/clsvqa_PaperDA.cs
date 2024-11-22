
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvqa_PaperDA
 表名:vqa_Paper(01120637)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:02:25
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
 /// v论文答疑(vqa_Paper)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvqa_PaperDA : clsCommBase4DA
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
 return clsvqa_PaperEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvqa_PaperEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvqa_PaperEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvqa_PaperEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvqa_PaperEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strQaPaperId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strQaPaperId)
{
strQaPaperId = strQaPaperId.Replace("'", "''");
if (strQaPaperId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vqa_Paper中,检查关键字,长度不正确!(clsvqa_PaperDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strQaPaperId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vqa_Paper中,关键字不能为空 或 null!(clsvqa_PaperDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strQaPaperId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvqa_PaperDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvqa_PaperDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from vqa_Paper where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vqa_Paper(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvqa_PaperDA: GetDataTable_vqa_Paper)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from vqa_Paper where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvqa_PaperDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_PaperDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvqa_PaperDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from vqa_Paper where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvqa_PaperDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_PaperDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvqa_PaperDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_PaperDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vqa_Paper where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vqa_Paper where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvqa_PaperDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_PaperDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vqa_Paper where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvqa_PaperDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_PaperDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vqa_Paper.* from vqa_Paper Left Join {1} on {2} where {3} and vqa_Paper.QaPaperId not in (Select top {5} vqa_Paper.QaPaperId from vqa_Paper Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vqa_Paper where {1} and QaPaperId not in (Select top {2} QaPaperId from vqa_Paper where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vqa_Paper where {1} and QaPaperId not in (Select top {3} QaPaperId from vqa_Paper where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvqa_PaperDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_PaperDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vqa_Paper.* from vqa_Paper Left Join {1} on {2} where {3} and vqa_Paper.QaPaperId not in (Select top {5} vqa_Paper.QaPaperId from vqa_Paper Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vqa_Paper where {1} and QaPaperId not in (Select top {2} QaPaperId from vqa_Paper where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vqa_Paper where {1} and QaPaperId not in (Select top {3} QaPaperId from vqa_Paper where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvqa_PaperEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvqa_PaperDA:GetObjLst)", objException.Message));
}
List<clsvqa_PaperEN> arrObjLst = new List<clsvqa_PaperEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from vqa_Paper where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_PaperEN objvqa_PaperEN = new clsvqa_PaperEN();
try
{
objvqa_PaperEN.QaPaperId = objRow[convqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_PaperEN.PaperId = objRow[convqa_Paper.PaperId] == DBNull.Value ? null : objRow[convqa_Paper.PaperId].ToString().Trim(); //论文Id
objvqa_PaperEN.QuestionsCount = objRow[convqa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objvqa_PaperEN.IsDelete = TransNullToBool(objRow[convqa_Paper.IsDelete].ToString().Trim()); //是否删除
objvqa_PaperEN.IsPublic = TransNullToBool(objRow[convqa_Paper.IsPublic].ToString().Trim()); //是否公开
objvqa_PaperEN.IsSubmit = TransNullToBool(objRow[convqa_Paper.IsSubmit].ToString().Trim()); //是否提交
objvqa_PaperEN.UpdUser = objRow[convqa_Paper.UpdUser] == DBNull.Value ? null : objRow[convqa_Paper.UpdUser].ToString().Trim(); //修改人
objvqa_PaperEN.UserName = objRow[convqa_Paper.UserName] == DBNull.Value ? null : objRow[convqa_Paper.UserName].ToString().Trim(); //用户名
objvqa_PaperEN.UpdDate = objRow[convqa_Paper.UpdDate] == DBNull.Value ? null : objRow[convqa_Paper.UpdDate].ToString().Trim(); //修改日期
objvqa_PaperEN.Memo = objRow[convqa_Paper.Memo] == DBNull.Value ? null : objRow[convqa_Paper.Memo].ToString().Trim(); //备注
objvqa_PaperEN.PaperTitle = objRow[convqa_Paper.PaperTitle] == DBNull.Value ? null : objRow[convqa_Paper.PaperTitle].ToString().Trim(); //论文标题
objvqa_PaperEN.AttachmentCount = objRow[convqa_Paper.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Paper.AttachmentCount].ToString().Trim()); //附件计数
objvqa_PaperEN.PaperContent = objRow[convqa_Paper.PaperContent] == DBNull.Value ? null : objRow[convqa_Paper.PaperContent].ToString().Trim(); //主题内容
objvqa_PaperEN.Periodical = objRow[convqa_Paper.Periodical] == DBNull.Value ? null : objRow[convqa_Paper.Periodical].ToString().Trim(); //期刊
objvqa_PaperEN.Author = objRow[convqa_Paper.Author] == DBNull.Value ? null : objRow[convqa_Paper.Author].ToString().Trim(); //作者
objvqa_PaperEN.ResearchQuestion = objRow[convqa_Paper.ResearchQuestion] == DBNull.Value ? null : objRow[convqa_Paper.ResearchQuestion].ToString().Trim(); //研究问题
objvqa_PaperEN.LiteratureSources = objRow[convqa_Paper.LiteratureSources] == DBNull.Value ? null : objRow[convqa_Paper.LiteratureSources].ToString().Trim(); //文献来源
objvqa_PaperEN.UploadfileUrl = objRow[convqa_Paper.UploadfileUrl] == DBNull.Value ? null : objRow[convqa_Paper.UploadfileUrl].ToString().Trim(); //文件地址
objvqa_PaperEN.IdXzMajor = objRow[convqa_Paper.IdXzMajor] == DBNull.Value ? null : objRow[convqa_Paper.IdXzMajor].ToString().Trim(); //专业流水号
objvqa_PaperEN.MajorName = objRow[convqa_Paper.MajorName] == DBNull.Value ? null : objRow[convqa_Paper.MajorName].ToString().Trim(); //专业名称
objvqa_PaperEN.IdCurrEduCls = objRow[convqa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_PaperEN.AnswerCount = objRow[convqa_Paper.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Paper.AnswerCount].ToString().Trim()); //回答计数
objvqa_PaperEN.ShareId = objRow[convqa_Paper.ShareId] == DBNull.Value ? null : objRow[convqa_Paper.ShareId].ToString().Trim(); //分享Id
objvqa_PaperEN.TagsCount = objRow[convqa_Paper.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvqa_PaperDA: GetObjLst)", objException.Message));
}
objvqa_PaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvqa_PaperEN);
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
public List<clsvqa_PaperEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvqa_PaperDA:GetObjLstByTabName)", objException.Message));
}
List<clsvqa_PaperEN> arrObjLst = new List<clsvqa_PaperEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_PaperDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_PaperEN objvqa_PaperEN = new clsvqa_PaperEN();
try
{
objvqa_PaperEN.QaPaperId = objRow[convqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_PaperEN.PaperId = objRow[convqa_Paper.PaperId] == DBNull.Value ? null : objRow[convqa_Paper.PaperId].ToString().Trim(); //论文Id
objvqa_PaperEN.QuestionsCount = objRow[convqa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objvqa_PaperEN.IsDelete = TransNullToBool(objRow[convqa_Paper.IsDelete].ToString().Trim()); //是否删除
objvqa_PaperEN.IsPublic = TransNullToBool(objRow[convqa_Paper.IsPublic].ToString().Trim()); //是否公开
objvqa_PaperEN.IsSubmit = TransNullToBool(objRow[convqa_Paper.IsSubmit].ToString().Trim()); //是否提交
objvqa_PaperEN.UpdUser = objRow[convqa_Paper.UpdUser] == DBNull.Value ? null : objRow[convqa_Paper.UpdUser].ToString().Trim(); //修改人
objvqa_PaperEN.UserName = objRow[convqa_Paper.UserName] == DBNull.Value ? null : objRow[convqa_Paper.UserName].ToString().Trim(); //用户名
objvqa_PaperEN.UpdDate = objRow[convqa_Paper.UpdDate] == DBNull.Value ? null : objRow[convqa_Paper.UpdDate].ToString().Trim(); //修改日期
objvqa_PaperEN.Memo = objRow[convqa_Paper.Memo] == DBNull.Value ? null : objRow[convqa_Paper.Memo].ToString().Trim(); //备注
objvqa_PaperEN.PaperTitle = objRow[convqa_Paper.PaperTitle] == DBNull.Value ? null : objRow[convqa_Paper.PaperTitle].ToString().Trim(); //论文标题
objvqa_PaperEN.AttachmentCount = objRow[convqa_Paper.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Paper.AttachmentCount].ToString().Trim()); //附件计数
objvqa_PaperEN.PaperContent = objRow[convqa_Paper.PaperContent] == DBNull.Value ? null : objRow[convqa_Paper.PaperContent].ToString().Trim(); //主题内容
objvqa_PaperEN.Periodical = objRow[convqa_Paper.Periodical] == DBNull.Value ? null : objRow[convqa_Paper.Periodical].ToString().Trim(); //期刊
objvqa_PaperEN.Author = objRow[convqa_Paper.Author] == DBNull.Value ? null : objRow[convqa_Paper.Author].ToString().Trim(); //作者
objvqa_PaperEN.ResearchQuestion = objRow[convqa_Paper.ResearchQuestion] == DBNull.Value ? null : objRow[convqa_Paper.ResearchQuestion].ToString().Trim(); //研究问题
objvqa_PaperEN.LiteratureSources = objRow[convqa_Paper.LiteratureSources] == DBNull.Value ? null : objRow[convqa_Paper.LiteratureSources].ToString().Trim(); //文献来源
objvqa_PaperEN.UploadfileUrl = objRow[convqa_Paper.UploadfileUrl] == DBNull.Value ? null : objRow[convqa_Paper.UploadfileUrl].ToString().Trim(); //文件地址
objvqa_PaperEN.IdXzMajor = objRow[convqa_Paper.IdXzMajor] == DBNull.Value ? null : objRow[convqa_Paper.IdXzMajor].ToString().Trim(); //专业流水号
objvqa_PaperEN.MajorName = objRow[convqa_Paper.MajorName] == DBNull.Value ? null : objRow[convqa_Paper.MajorName].ToString().Trim(); //专业名称
objvqa_PaperEN.IdCurrEduCls = objRow[convqa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_PaperEN.AnswerCount = objRow[convqa_Paper.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Paper.AnswerCount].ToString().Trim()); //回答计数
objvqa_PaperEN.ShareId = objRow[convqa_Paper.ShareId] == DBNull.Value ? null : objRow[convqa_Paper.ShareId].ToString().Trim(); //分享Id
objvqa_PaperEN.TagsCount = objRow[convqa_Paper.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvqa_PaperDA: GetObjLst)", objException.Message));
}
objvqa_PaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvqa_PaperEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvqa_Paper(ref clsvqa_PaperEN objvqa_PaperEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from vqa_Paper where QaPaperId = " + "'"+ objvqa_PaperEN.QaPaperId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvqa_PaperEN.QaPaperId = objDT.Rows[0][convqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id(字段类型:char,字段长度:8,是否可空:False)
 objvqa_PaperEN.PaperId = objDT.Rows[0][convqa_Paper.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvqa_PaperEN.QuestionsCount = TransNullToInt(objDT.Rows[0][convqa_Paper.QuestionsCount].ToString().Trim()); //提问计数(字段类型:int,字段长度:4,是否可空:True)
 objvqa_PaperEN.IsDelete = TransNullToBool(objDT.Rows[0][convqa_Paper.IsDelete].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objvqa_PaperEN.IsPublic = TransNullToBool(objDT.Rows[0][convqa_Paper.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvqa_PaperEN.IsSubmit = TransNullToBool(objDT.Rows[0][convqa_Paper.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvqa_PaperEN.UpdUser = objDT.Rows[0][convqa_Paper.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvqa_PaperEN.UserName = objDT.Rows[0][convqa_Paper.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvqa_PaperEN.UpdDate = objDT.Rows[0][convqa_Paper.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvqa_PaperEN.Memo = objDT.Rows[0][convqa_Paper.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvqa_PaperEN.PaperTitle = objDT.Rows[0][convqa_Paper.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvqa_PaperEN.AttachmentCount = TransNullToInt(objDT.Rows[0][convqa_Paper.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objvqa_PaperEN.PaperContent = objDT.Rows[0][convqa_Paper.PaperContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvqa_PaperEN.Periodical = objDT.Rows[0][convqa_Paper.Periodical].ToString().Trim(); //期刊(字段类型:varchar,字段长度:100,是否可空:True)
 objvqa_PaperEN.Author = objDT.Rows[0][convqa_Paper.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvqa_PaperEN.ResearchQuestion = objDT.Rows[0][convqa_Paper.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objvqa_PaperEN.LiteratureSources = objDT.Rows[0][convqa_Paper.LiteratureSources].ToString().Trim(); //文献来源(字段类型:varchar,字段长度:1000,是否可空:True)
 objvqa_PaperEN.UploadfileUrl = objDT.Rows[0][convqa_Paper.UploadfileUrl].ToString().Trim(); //文件地址(字段类型:varchar,字段长度:1000,是否可空:True)
 objvqa_PaperEN.IdXzMajor = objDT.Rows[0][convqa_Paper.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvqa_PaperEN.MajorName = objDT.Rows[0][convqa_Paper.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvqa_PaperEN.IdCurrEduCls = objDT.Rows[0][convqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvqa_PaperEN.AnswerCount = TransNullToInt(objDT.Rows[0][convqa_Paper.AnswerCount].ToString().Trim()); //回答计数(字段类型:int,字段长度:4,是否可空:True)
 objvqa_PaperEN.ShareId = objDT.Rows[0][convqa_Paper.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvqa_PaperEN.TagsCount = TransNullToInt(objDT.Rows[0][convqa_Paper.TagsCount].ToString().Trim()); //论文标注数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvqa_PaperDA: Getvqa_Paper)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strQaPaperId">表关键字</param>
 /// <returns>表对象</returns>
public clsvqa_PaperEN GetObjByQaPaperId(string strQaPaperId)
{
CheckPrimaryKey(strQaPaperId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from vqa_Paper where QaPaperId = " + "'"+ strQaPaperId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvqa_PaperEN objvqa_PaperEN = new clsvqa_PaperEN();
try
{
 objvqa_PaperEN.QaPaperId = objRow[convqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id(字段类型:char,字段长度:8,是否可空:False)
 objvqa_PaperEN.PaperId = objRow[convqa_Paper.PaperId] == DBNull.Value ? null : objRow[convqa_Paper.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvqa_PaperEN.QuestionsCount = objRow[convqa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.QuestionsCount].ToString().Trim()); //提问计数(字段类型:int,字段长度:4,是否可空:True)
 objvqa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsDelete].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objvqa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvqa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvqa_PaperEN.UpdUser = objRow[convqa_Paper.UpdUser] == DBNull.Value ? null : objRow[convqa_Paper.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvqa_PaperEN.UserName = objRow[convqa_Paper.UserName] == DBNull.Value ? null : objRow[convqa_Paper.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvqa_PaperEN.UpdDate = objRow[convqa_Paper.UpdDate] == DBNull.Value ? null : objRow[convqa_Paper.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvqa_PaperEN.Memo = objRow[convqa_Paper.Memo] == DBNull.Value ? null : objRow[convqa_Paper.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvqa_PaperEN.PaperTitle = objRow[convqa_Paper.PaperTitle] == DBNull.Value ? null : objRow[convqa_Paper.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvqa_PaperEN.AttachmentCount = objRow[convqa_Paper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objvqa_PaperEN.PaperContent = objRow[convqa_Paper.PaperContent] == DBNull.Value ? null : objRow[convqa_Paper.PaperContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvqa_PaperEN.Periodical = objRow[convqa_Paper.Periodical] == DBNull.Value ? null : objRow[convqa_Paper.Periodical].ToString().Trim(); //期刊(字段类型:varchar,字段长度:100,是否可空:True)
 objvqa_PaperEN.Author = objRow[convqa_Paper.Author] == DBNull.Value ? null : objRow[convqa_Paper.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvqa_PaperEN.ResearchQuestion = objRow[convqa_Paper.ResearchQuestion] == DBNull.Value ? null : objRow[convqa_Paper.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objvqa_PaperEN.LiteratureSources = objRow[convqa_Paper.LiteratureSources] == DBNull.Value ? null : objRow[convqa_Paper.LiteratureSources].ToString().Trim(); //文献来源(字段类型:varchar,字段长度:1000,是否可空:True)
 objvqa_PaperEN.UploadfileUrl = objRow[convqa_Paper.UploadfileUrl] == DBNull.Value ? null : objRow[convqa_Paper.UploadfileUrl].ToString().Trim(); //文件地址(字段类型:varchar,字段长度:1000,是否可空:True)
 objvqa_PaperEN.IdXzMajor = objRow[convqa_Paper.IdXzMajor] == DBNull.Value ? null : objRow[convqa_Paper.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvqa_PaperEN.MajorName = objRow[convqa_Paper.MajorName] == DBNull.Value ? null : objRow[convqa_Paper.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvqa_PaperEN.IdCurrEduCls = objRow[convqa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvqa_PaperEN.AnswerCount = objRow[convqa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.AnswerCount].ToString().Trim()); //回答计数(字段类型:int,字段长度:4,是否可空:True)
 objvqa_PaperEN.ShareId = objRow[convqa_Paper.ShareId] == DBNull.Value ? null : objRow[convqa_Paper.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvqa_PaperEN.TagsCount = objRow[convqa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.TagsCount].ToString().Trim()); //论文标注数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvqa_PaperDA: GetObjByQaPaperId)", objException.Message));
}
return objvqa_PaperEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvqa_PaperEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvqa_PaperDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_PaperDA.GetSpecSQLObj();
strSQL = "Select * from vqa_Paper where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvqa_PaperEN objvqa_PaperEN = new clsvqa_PaperEN()
{
QaPaperId = objRow[convqa_Paper.QaPaperId].ToString().Trim(), //论文答疑Id
PaperId = objRow[convqa_Paper.PaperId] == DBNull.Value ? null : objRow[convqa_Paper.PaperId].ToString().Trim(), //论文Id
QuestionsCount = objRow[convqa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Paper.QuestionsCount].ToString().Trim()), //提问计数
IsDelete = TransNullToBool(objRow[convqa_Paper.IsDelete].ToString().Trim()), //是否删除
IsPublic = TransNullToBool(objRow[convqa_Paper.IsPublic].ToString().Trim()), //是否公开
IsSubmit = TransNullToBool(objRow[convqa_Paper.IsSubmit].ToString().Trim()), //是否提交
UpdUser = objRow[convqa_Paper.UpdUser] == DBNull.Value ? null : objRow[convqa_Paper.UpdUser].ToString().Trim(), //修改人
UserName = objRow[convqa_Paper.UserName] == DBNull.Value ? null : objRow[convqa_Paper.UserName].ToString().Trim(), //用户名
UpdDate = objRow[convqa_Paper.UpdDate] == DBNull.Value ? null : objRow[convqa_Paper.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convqa_Paper.Memo] == DBNull.Value ? null : objRow[convqa_Paper.Memo].ToString().Trim(), //备注
PaperTitle = objRow[convqa_Paper.PaperTitle] == DBNull.Value ? null : objRow[convqa_Paper.PaperTitle].ToString().Trim(), //论文标题
AttachmentCount = objRow[convqa_Paper.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Paper.AttachmentCount].ToString().Trim()), //附件计数
PaperContent = objRow[convqa_Paper.PaperContent] == DBNull.Value ? null : objRow[convqa_Paper.PaperContent].ToString().Trim(), //主题内容
Periodical = objRow[convqa_Paper.Periodical] == DBNull.Value ? null : objRow[convqa_Paper.Periodical].ToString().Trim(), //期刊
Author = objRow[convqa_Paper.Author] == DBNull.Value ? null : objRow[convqa_Paper.Author].ToString().Trim(), //作者
ResearchQuestion = objRow[convqa_Paper.ResearchQuestion] == DBNull.Value ? null : objRow[convqa_Paper.ResearchQuestion].ToString().Trim(), //研究问题
LiteratureSources = objRow[convqa_Paper.LiteratureSources] == DBNull.Value ? null : objRow[convqa_Paper.LiteratureSources].ToString().Trim(), //文献来源
UploadfileUrl = objRow[convqa_Paper.UploadfileUrl] == DBNull.Value ? null : objRow[convqa_Paper.UploadfileUrl].ToString().Trim(), //文件地址
IdXzMajor = objRow[convqa_Paper.IdXzMajor] == DBNull.Value ? null : objRow[convqa_Paper.IdXzMajor].ToString().Trim(), //专业流水号
MajorName = objRow[convqa_Paper.MajorName] == DBNull.Value ? null : objRow[convqa_Paper.MajorName].ToString().Trim(), //专业名称
IdCurrEduCls = objRow[convqa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Paper.IdCurrEduCls].ToString().Trim(), //教学班流水号
AnswerCount = objRow[convqa_Paper.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Paper.AnswerCount].ToString().Trim()), //回答计数
ShareId = objRow[convqa_Paper.ShareId] == DBNull.Value ? null : objRow[convqa_Paper.ShareId].ToString().Trim(), //分享Id
TagsCount = objRow[convqa_Paper.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Paper.TagsCount].ToString().Trim()) //论文标注数
};
objvqa_PaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvqa_PaperEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvqa_PaperDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvqa_PaperEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvqa_PaperEN objvqa_PaperEN = new clsvqa_PaperEN();
try
{
objvqa_PaperEN.QaPaperId = objRow[convqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_PaperEN.PaperId = objRow[convqa_Paper.PaperId] == DBNull.Value ? null : objRow[convqa_Paper.PaperId].ToString().Trim(); //论文Id
objvqa_PaperEN.QuestionsCount = objRow[convqa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objvqa_PaperEN.IsDelete = TransNullToBool(objRow[convqa_Paper.IsDelete].ToString().Trim()); //是否删除
objvqa_PaperEN.IsPublic = TransNullToBool(objRow[convqa_Paper.IsPublic].ToString().Trim()); //是否公开
objvqa_PaperEN.IsSubmit = TransNullToBool(objRow[convqa_Paper.IsSubmit].ToString().Trim()); //是否提交
objvqa_PaperEN.UpdUser = objRow[convqa_Paper.UpdUser] == DBNull.Value ? null : objRow[convqa_Paper.UpdUser].ToString().Trim(); //修改人
objvqa_PaperEN.UserName = objRow[convqa_Paper.UserName] == DBNull.Value ? null : objRow[convqa_Paper.UserName].ToString().Trim(); //用户名
objvqa_PaperEN.UpdDate = objRow[convqa_Paper.UpdDate] == DBNull.Value ? null : objRow[convqa_Paper.UpdDate].ToString().Trim(); //修改日期
objvqa_PaperEN.Memo = objRow[convqa_Paper.Memo] == DBNull.Value ? null : objRow[convqa_Paper.Memo].ToString().Trim(); //备注
objvqa_PaperEN.PaperTitle = objRow[convqa_Paper.PaperTitle] == DBNull.Value ? null : objRow[convqa_Paper.PaperTitle].ToString().Trim(); //论文标题
objvqa_PaperEN.AttachmentCount = objRow[convqa_Paper.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Paper.AttachmentCount].ToString().Trim()); //附件计数
objvqa_PaperEN.PaperContent = objRow[convqa_Paper.PaperContent] == DBNull.Value ? null : objRow[convqa_Paper.PaperContent].ToString().Trim(); //主题内容
objvqa_PaperEN.Periodical = objRow[convqa_Paper.Periodical] == DBNull.Value ? null : objRow[convqa_Paper.Periodical].ToString().Trim(); //期刊
objvqa_PaperEN.Author = objRow[convqa_Paper.Author] == DBNull.Value ? null : objRow[convqa_Paper.Author].ToString().Trim(); //作者
objvqa_PaperEN.ResearchQuestion = objRow[convqa_Paper.ResearchQuestion] == DBNull.Value ? null : objRow[convqa_Paper.ResearchQuestion].ToString().Trim(); //研究问题
objvqa_PaperEN.LiteratureSources = objRow[convqa_Paper.LiteratureSources] == DBNull.Value ? null : objRow[convqa_Paper.LiteratureSources].ToString().Trim(); //文献来源
objvqa_PaperEN.UploadfileUrl = objRow[convqa_Paper.UploadfileUrl] == DBNull.Value ? null : objRow[convqa_Paper.UploadfileUrl].ToString().Trim(); //文件地址
objvqa_PaperEN.IdXzMajor = objRow[convqa_Paper.IdXzMajor] == DBNull.Value ? null : objRow[convqa_Paper.IdXzMajor].ToString().Trim(); //专业流水号
objvqa_PaperEN.MajorName = objRow[convqa_Paper.MajorName] == DBNull.Value ? null : objRow[convqa_Paper.MajorName].ToString().Trim(); //专业名称
objvqa_PaperEN.IdCurrEduCls = objRow[convqa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_PaperEN.AnswerCount = objRow[convqa_Paper.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Paper.AnswerCount].ToString().Trim()); //回答计数
objvqa_PaperEN.ShareId = objRow[convqa_Paper.ShareId] == DBNull.Value ? null : objRow[convqa_Paper.ShareId].ToString().Trim(); //分享Id
objvqa_PaperEN.TagsCount = objRow[convqa_Paper.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvqa_PaperDA: GetObjByDataRowvqa_Paper)", objException.Message));
}
objvqa_PaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvqa_PaperEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvqa_PaperEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvqa_PaperEN objvqa_PaperEN = new clsvqa_PaperEN();
try
{
objvqa_PaperEN.QaPaperId = objRow[convqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_PaperEN.PaperId = objRow[convqa_Paper.PaperId] == DBNull.Value ? null : objRow[convqa_Paper.PaperId].ToString().Trim(); //论文Id
objvqa_PaperEN.QuestionsCount = objRow[convqa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objvqa_PaperEN.IsDelete = TransNullToBool(objRow[convqa_Paper.IsDelete].ToString().Trim()); //是否删除
objvqa_PaperEN.IsPublic = TransNullToBool(objRow[convqa_Paper.IsPublic].ToString().Trim()); //是否公开
objvqa_PaperEN.IsSubmit = TransNullToBool(objRow[convqa_Paper.IsSubmit].ToString().Trim()); //是否提交
objvqa_PaperEN.UpdUser = objRow[convqa_Paper.UpdUser] == DBNull.Value ? null : objRow[convqa_Paper.UpdUser].ToString().Trim(); //修改人
objvqa_PaperEN.UserName = objRow[convqa_Paper.UserName] == DBNull.Value ? null : objRow[convqa_Paper.UserName].ToString().Trim(); //用户名
objvqa_PaperEN.UpdDate = objRow[convqa_Paper.UpdDate] == DBNull.Value ? null : objRow[convqa_Paper.UpdDate].ToString().Trim(); //修改日期
objvqa_PaperEN.Memo = objRow[convqa_Paper.Memo] == DBNull.Value ? null : objRow[convqa_Paper.Memo].ToString().Trim(); //备注
objvqa_PaperEN.PaperTitle = objRow[convqa_Paper.PaperTitle] == DBNull.Value ? null : objRow[convqa_Paper.PaperTitle].ToString().Trim(); //论文标题
objvqa_PaperEN.AttachmentCount = objRow[convqa_Paper.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Paper.AttachmentCount].ToString().Trim()); //附件计数
objvqa_PaperEN.PaperContent = objRow[convqa_Paper.PaperContent] == DBNull.Value ? null : objRow[convqa_Paper.PaperContent].ToString().Trim(); //主题内容
objvqa_PaperEN.Periodical = objRow[convqa_Paper.Periodical] == DBNull.Value ? null : objRow[convqa_Paper.Periodical].ToString().Trim(); //期刊
objvqa_PaperEN.Author = objRow[convqa_Paper.Author] == DBNull.Value ? null : objRow[convqa_Paper.Author].ToString().Trim(); //作者
objvqa_PaperEN.ResearchQuestion = objRow[convqa_Paper.ResearchQuestion] == DBNull.Value ? null : objRow[convqa_Paper.ResearchQuestion].ToString().Trim(); //研究问题
objvqa_PaperEN.LiteratureSources = objRow[convqa_Paper.LiteratureSources] == DBNull.Value ? null : objRow[convqa_Paper.LiteratureSources].ToString().Trim(); //文献来源
objvqa_PaperEN.UploadfileUrl = objRow[convqa_Paper.UploadfileUrl] == DBNull.Value ? null : objRow[convqa_Paper.UploadfileUrl].ToString().Trim(); //文件地址
objvqa_PaperEN.IdXzMajor = objRow[convqa_Paper.IdXzMajor] == DBNull.Value ? null : objRow[convqa_Paper.IdXzMajor].ToString().Trim(); //专业流水号
objvqa_PaperEN.MajorName = objRow[convqa_Paper.MajorName] == DBNull.Value ? null : objRow[convqa_Paper.MajorName].ToString().Trim(); //专业名称
objvqa_PaperEN.IdCurrEduCls = objRow[convqa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_PaperEN.AnswerCount = objRow[convqa_Paper.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Paper.AnswerCount].ToString().Trim()); //回答计数
objvqa_PaperEN.ShareId = objRow[convqa_Paper.ShareId] == DBNull.Value ? null : objRow[convqa_Paper.ShareId].ToString().Trim(); //分享Id
objvqa_PaperEN.TagsCount = objRow[convqa_Paper.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convqa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvqa_PaperDA: GetObjByDataRow)", objException.Message));
}
objvqa_PaperEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvqa_PaperEN;
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
objSQL = clsvqa_PaperDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvqa_PaperEN._CurrTabName, convqa_Paper.QaPaperId, 8, "");
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
objSQL = clsvqa_PaperDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvqa_PaperEN._CurrTabName, convqa_Paper.QaPaperId, 8, strPrefix);
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
 objSQL = clsvqa_PaperDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select QaPaperId from vqa_Paper where " + strCondition;
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
 objSQL = clsvqa_PaperDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select QaPaperId from vqa_Paper where " + strCondition;
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
 /// <param name = "strQaPaperId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strQaPaperId)
{
CheckPrimaryKey(strQaPaperId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_PaperDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vqa_Paper", "QaPaperId = " + "'"+ strQaPaperId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvqa_PaperDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvqa_PaperDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vqa_Paper", strCondition))
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
objSQL = clsvqa_PaperDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vqa_Paper");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvqa_PaperENS">源对象</param>
 /// <param name = "objvqa_PaperENT">目标对象</param>
public void CopyTo(clsvqa_PaperEN objvqa_PaperENS, clsvqa_PaperEN objvqa_PaperENT)
{
objvqa_PaperENT.QaPaperId = objvqa_PaperENS.QaPaperId; //论文答疑Id
objvqa_PaperENT.PaperId = objvqa_PaperENS.PaperId; //论文Id
objvqa_PaperENT.QuestionsCount = objvqa_PaperENS.QuestionsCount; //提问计数
objvqa_PaperENT.IsDelete = objvqa_PaperENS.IsDelete; //是否删除
objvqa_PaperENT.IsPublic = objvqa_PaperENS.IsPublic; //是否公开
objvqa_PaperENT.IsSubmit = objvqa_PaperENS.IsSubmit; //是否提交
objvqa_PaperENT.UpdUser = objvqa_PaperENS.UpdUser; //修改人
objvqa_PaperENT.UserName = objvqa_PaperENS.UserName; //用户名
objvqa_PaperENT.UpdDate = objvqa_PaperENS.UpdDate; //修改日期
objvqa_PaperENT.Memo = objvqa_PaperENS.Memo; //备注
objvqa_PaperENT.PaperTitle = objvqa_PaperENS.PaperTitle; //论文标题
objvqa_PaperENT.AttachmentCount = objvqa_PaperENS.AttachmentCount; //附件计数
objvqa_PaperENT.PaperContent = objvqa_PaperENS.PaperContent; //主题内容
objvqa_PaperENT.Periodical = objvqa_PaperENS.Periodical; //期刊
objvqa_PaperENT.Author = objvqa_PaperENS.Author; //作者
objvqa_PaperENT.ResearchQuestion = objvqa_PaperENS.ResearchQuestion; //研究问题
objvqa_PaperENT.LiteratureSources = objvqa_PaperENS.LiteratureSources; //文献来源
objvqa_PaperENT.UploadfileUrl = objvqa_PaperENS.UploadfileUrl; //文件地址
objvqa_PaperENT.IdXzMajor = objvqa_PaperENS.IdXzMajor; //专业流水号
objvqa_PaperENT.MajorName = objvqa_PaperENS.MajorName; //专业名称
objvqa_PaperENT.IdCurrEduCls = objvqa_PaperENS.IdCurrEduCls; //教学班流水号
objvqa_PaperENT.AnswerCount = objvqa_PaperENS.AnswerCount; //回答计数
objvqa_PaperENT.ShareId = objvqa_PaperENS.ShareId; //分享Id
objvqa_PaperENT.TagsCount = objvqa_PaperENS.TagsCount; //论文标注数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvqa_PaperEN objvqa_PaperEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvqa_PaperEN.QaPaperId, 8, convqa_Paper.QaPaperId);
clsCheckSql.CheckFieldLen(objvqa_PaperEN.PaperId, 8, convqa_Paper.PaperId);
clsCheckSql.CheckFieldLen(objvqa_PaperEN.UpdUser, 20, convqa_Paper.UpdUser);
clsCheckSql.CheckFieldLen(objvqa_PaperEN.UserName, 30, convqa_Paper.UserName);
clsCheckSql.CheckFieldLen(objvqa_PaperEN.UpdDate, 20, convqa_Paper.UpdDate);
clsCheckSql.CheckFieldLen(objvqa_PaperEN.Memo, 1000, convqa_Paper.Memo);
clsCheckSql.CheckFieldLen(objvqa_PaperEN.PaperTitle, 500, convqa_Paper.PaperTitle);
clsCheckSql.CheckFieldLen(objvqa_PaperEN.Periodical, 100, convqa_Paper.Periodical);
clsCheckSql.CheckFieldLen(objvqa_PaperEN.Author, 200, convqa_Paper.Author);
clsCheckSql.CheckFieldLen(objvqa_PaperEN.ResearchQuestion, 2000, convqa_Paper.ResearchQuestion);
clsCheckSql.CheckFieldLen(objvqa_PaperEN.LiteratureSources, 1000, convqa_Paper.LiteratureSources);
clsCheckSql.CheckFieldLen(objvqa_PaperEN.UploadfileUrl, 1000, convqa_Paper.UploadfileUrl);
clsCheckSql.CheckFieldLen(objvqa_PaperEN.IdXzMajor, 8, convqa_Paper.IdXzMajor);
clsCheckSql.CheckFieldLen(objvqa_PaperEN.MajorName, 100, convqa_Paper.MajorName);
clsCheckSql.CheckFieldLen(objvqa_PaperEN.IdCurrEduCls, 8, convqa_Paper.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvqa_PaperEN.ShareId, 2, convqa_Paper.ShareId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvqa_PaperEN.QaPaperId, convqa_Paper.QaPaperId);
clsCheckSql.CheckSqlInjection4Field(objvqa_PaperEN.PaperId, convqa_Paper.PaperId);
clsCheckSql.CheckSqlInjection4Field(objvqa_PaperEN.UpdUser, convqa_Paper.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvqa_PaperEN.UserName, convqa_Paper.UserName);
clsCheckSql.CheckSqlInjection4Field(objvqa_PaperEN.UpdDate, convqa_Paper.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvqa_PaperEN.Memo, convqa_Paper.Memo);
clsCheckSql.CheckSqlInjection4Field(objvqa_PaperEN.PaperTitle, convqa_Paper.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objvqa_PaperEN.Periodical, convqa_Paper.Periodical);
clsCheckSql.CheckSqlInjection4Field(objvqa_PaperEN.Author, convqa_Paper.Author);
clsCheckSql.CheckSqlInjection4Field(objvqa_PaperEN.ResearchQuestion, convqa_Paper.ResearchQuestion);
clsCheckSql.CheckSqlInjection4Field(objvqa_PaperEN.LiteratureSources, convqa_Paper.LiteratureSources);
clsCheckSql.CheckSqlInjection4Field(objvqa_PaperEN.UploadfileUrl, convqa_Paper.UploadfileUrl);
clsCheckSql.CheckSqlInjection4Field(objvqa_PaperEN.IdXzMajor, convqa_Paper.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvqa_PaperEN.MajorName, convqa_Paper.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvqa_PaperEN.IdCurrEduCls, convqa_Paper.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvqa_PaperEN.ShareId, convqa_Paper.ShareId);
//检查外键字段长度
 objvqa_PaperEN._IsCheckProperty = true;
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
 objSQL = clsvqa_PaperDA.GetSpecSQLObj();
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
 objSQL = clsvqa_PaperDA.GetSpecSQLObj();
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
 objSQL = clsvqa_PaperDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvqa_PaperEN._CurrTabName);
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
 objSQL = clsvqa_PaperDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvqa_PaperEN._CurrTabName, strCondition);
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
 objSQL = clsvqa_PaperDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}