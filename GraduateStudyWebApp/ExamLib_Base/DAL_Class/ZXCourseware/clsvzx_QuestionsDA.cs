
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_QuestionsDA
 表名:vzx_Questions(01120851)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:14:00
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
 /// vzx_Questions(vzx_Questions)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvzx_QuestionsDA : clsCommBase4DA
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
 return clsvzx_QuestionsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvzx_QuestionsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_QuestionsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvzx_QuestionsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvzx_QuestionsEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strzxQuestionsId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strzxQuestionsId)
{
strzxQuestionsId = strzxQuestionsId.Replace("'", "''");
if (strzxQuestionsId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vzx_Questions中,检查关键字,长度不正确!(clsvzx_QuestionsDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strzxQuestionsId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vzx_Questions中,关键字不能为空 或 null!(clsvzx_QuestionsDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxQuestionsId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvzx_QuestionsDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvzx_QuestionsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Questions where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vzx_Questions(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvzx_QuestionsDA: GetDataTable_vzx_Questions)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Questions where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvzx_QuestionsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_QuestionsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvzx_QuestionsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Questions where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvzx_QuestionsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_QuestionsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvzx_QuestionsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_QuestionsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_Questions where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_Questions where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvzx_QuestionsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_QuestionsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vzx_Questions where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvzx_QuestionsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_QuestionsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_Questions.* from vzx_Questions Left Join {1} on {2} where {3} and vzx_Questions.zxQuestionsId not in (Select top {5} vzx_Questions.zxQuestionsId from vzx_Questions Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_Questions where {1} and zxQuestionsId not in (Select top {2} zxQuestionsId from vzx_Questions where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_Questions where {1} and zxQuestionsId not in (Select top {3} zxQuestionsId from vzx_Questions where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvzx_QuestionsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_QuestionsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_Questions.* from vzx_Questions Left Join {1} on {2} where {3} and vzx_Questions.zxQuestionsId not in (Select top {5} vzx_Questions.zxQuestionsId from vzx_Questions Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_Questions where {1} and zxQuestionsId not in (Select top {2} zxQuestionsId from vzx_Questions where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_Questions where {1} and zxQuestionsId not in (Select top {3} zxQuestionsId from vzx_Questions where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvzx_QuestionsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvzx_QuestionsDA:GetObjLst)", objException.Message));
}
List<clsvzx_QuestionsEN> arrObjLst = new List<clsvzx_QuestionsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Questions where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_QuestionsEN objvzx_QuestionsEN = new clsvzx_QuestionsEN();
try
{
objvzx_QuestionsEN.zxQuestionsId = objRow[convzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_QuestionsEN.UserName = objRow[convzx_Questions.UserName] == DBNull.Value ? null : objRow[convzx_Questions.UserName].ToString().Trim(); //用户名
objvzx_QuestionsEN.QuestionsTypeName = objRow[convzx_Questions.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_Questions.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_QuestionsEN.TextTitle = objRow[convzx_Questions.TextTitle] == DBNull.Value ? null : objRow[convzx_Questions.TextTitle].ToString().Trim(); //TextTitle
objvzx_QuestionsEN.IdCurrEduCls = objRow[convzx_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_QuestionsEN.IsSubmit = TransNullToBool(objRow[convzx_Questions.IsSubmit].ToString().Trim()); //是否提交
objvzx_QuestionsEN.TextId = objRow[convzx_Questions.TextId] == DBNull.Value ? null : objRow[convzx_Questions.TextId].ToString().Trim(); //课件Id
objvzx_QuestionsEN.QuestionsContent = objRow[convzx_Questions.QuestionsContent] == DBNull.Value ? null : objRow[convzx_Questions.QuestionsContent].ToString().Trim(); //提问内容
objvzx_QuestionsEN.PdfPageNum = objRow[convzx_Questions.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_QuestionsEN.PdfContent = objRow[convzx_Questions.PdfContent] == DBNull.Value ? null : objRow[convzx_Questions.PdfContent].ToString().Trim(); //Pdf内容
objvzx_QuestionsEN.IsDelete = TransNullToBool(objRow[convzx_Questions.IsDelete].ToString().Trim()); //是否删除
objvzx_QuestionsEN.IsPublic = TransNullToBool(objRow[convzx_Questions.IsPublic].ToString().Trim()); //是否公开
objvzx_QuestionsEN.IsEnd = TransNullToBool(objRow[convzx_Questions.IsEnd].ToString().Trim()); //是否结束
objvzx_QuestionsEN.VoteCount = objRow[convzx_Questions.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.VoteCount].ToString().Trim()); //点赞计数
objvzx_QuestionsEN.AnswerCount = objRow[convzx_Questions.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.AnswerCount].ToString().Trim()); //回答计数
objvzx_QuestionsEN.OrderNum = objRow[convzx_Questions.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.OrderNum].ToString().Trim()); //序号
objvzx_QuestionsEN.PdfPageTop = objRow[convzx_Questions.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_QuestionsEN.PdfPageNumIn = objRow[convzx_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_QuestionsEN.PdfDivTop = objRow[convzx_Questions.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_QuestionsEN.PdfDivLet = objRow[convzx_Questions.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_QuestionsEN.PdfZoom = objRow[convzx_Questions.PdfZoom] == DBNull.Value ? null : objRow[convzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_QuestionsEN.UpdUser = objRow[convzx_Questions.UpdUser] == DBNull.Value ? null : objRow[convzx_Questions.UpdUser].ToString().Trim(); //修改人
objvzx_QuestionsEN.UpdDate = objRow[convzx_Questions.UpdDate] == DBNull.Value ? null : objRow[convzx_Questions.UpdDate].ToString().Trim(); //修改日期
objvzx_QuestionsEN.Memo = objRow[convzx_Questions.Memo] == DBNull.Value ? null : objRow[convzx_Questions.Memo].ToString().Trim(); //备注
objvzx_QuestionsEN.DiscussCount = objRow[convzx_Questions.DiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objvzx_QuestionsEN.GroupDiscussCount = objRow[convzx_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objvzx_QuestionsEN.ZxqaPaperId = objRow[convzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objvzx_QuestionsEN.zxQuestionsTypeId = objRow[convzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_QuestionsEN.RecommendAnswerCount = objRow[convzx_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
objvzx_QuestionsEN.UserId = objRow[convzx_Questions.UserId] == DBNull.Value ? null : objRow[convzx_Questions.UserId].ToString().Trim(); //用户ID
objvzx_QuestionsEN.IdXzMajor = objRow[convzx_Questions.IdXzMajor] == DBNull.Value ? null : objRow[convzx_Questions.IdXzMajor].ToString().Trim(); //专业流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_QuestionsDA: GetObjLst)", objException.Message));
}
objvzx_QuestionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_QuestionsEN);
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
public List<clsvzx_QuestionsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvzx_QuestionsDA:GetObjLstByTabName)", objException.Message));
}
List<clsvzx_QuestionsEN> arrObjLst = new List<clsvzx_QuestionsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_QuestionsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_QuestionsEN objvzx_QuestionsEN = new clsvzx_QuestionsEN();
try
{
objvzx_QuestionsEN.zxQuestionsId = objRow[convzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_QuestionsEN.UserName = objRow[convzx_Questions.UserName] == DBNull.Value ? null : objRow[convzx_Questions.UserName].ToString().Trim(); //用户名
objvzx_QuestionsEN.QuestionsTypeName = objRow[convzx_Questions.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_Questions.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_QuestionsEN.TextTitle = objRow[convzx_Questions.TextTitle] == DBNull.Value ? null : objRow[convzx_Questions.TextTitle].ToString().Trim(); //TextTitle
objvzx_QuestionsEN.IdCurrEduCls = objRow[convzx_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_QuestionsEN.IsSubmit = TransNullToBool(objRow[convzx_Questions.IsSubmit].ToString().Trim()); //是否提交
objvzx_QuestionsEN.TextId = objRow[convzx_Questions.TextId] == DBNull.Value ? null : objRow[convzx_Questions.TextId].ToString().Trim(); //课件Id
objvzx_QuestionsEN.QuestionsContent = objRow[convzx_Questions.QuestionsContent] == DBNull.Value ? null : objRow[convzx_Questions.QuestionsContent].ToString().Trim(); //提问内容
objvzx_QuestionsEN.PdfPageNum = objRow[convzx_Questions.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_QuestionsEN.PdfContent = objRow[convzx_Questions.PdfContent] == DBNull.Value ? null : objRow[convzx_Questions.PdfContent].ToString().Trim(); //Pdf内容
objvzx_QuestionsEN.IsDelete = TransNullToBool(objRow[convzx_Questions.IsDelete].ToString().Trim()); //是否删除
objvzx_QuestionsEN.IsPublic = TransNullToBool(objRow[convzx_Questions.IsPublic].ToString().Trim()); //是否公开
objvzx_QuestionsEN.IsEnd = TransNullToBool(objRow[convzx_Questions.IsEnd].ToString().Trim()); //是否结束
objvzx_QuestionsEN.VoteCount = objRow[convzx_Questions.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.VoteCount].ToString().Trim()); //点赞计数
objvzx_QuestionsEN.AnswerCount = objRow[convzx_Questions.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.AnswerCount].ToString().Trim()); //回答计数
objvzx_QuestionsEN.OrderNum = objRow[convzx_Questions.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.OrderNum].ToString().Trim()); //序号
objvzx_QuestionsEN.PdfPageTop = objRow[convzx_Questions.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_QuestionsEN.PdfPageNumIn = objRow[convzx_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_QuestionsEN.PdfDivTop = objRow[convzx_Questions.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_QuestionsEN.PdfDivLet = objRow[convzx_Questions.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_QuestionsEN.PdfZoom = objRow[convzx_Questions.PdfZoom] == DBNull.Value ? null : objRow[convzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_QuestionsEN.UpdUser = objRow[convzx_Questions.UpdUser] == DBNull.Value ? null : objRow[convzx_Questions.UpdUser].ToString().Trim(); //修改人
objvzx_QuestionsEN.UpdDate = objRow[convzx_Questions.UpdDate] == DBNull.Value ? null : objRow[convzx_Questions.UpdDate].ToString().Trim(); //修改日期
objvzx_QuestionsEN.Memo = objRow[convzx_Questions.Memo] == DBNull.Value ? null : objRow[convzx_Questions.Memo].ToString().Trim(); //备注
objvzx_QuestionsEN.DiscussCount = objRow[convzx_Questions.DiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objvzx_QuestionsEN.GroupDiscussCount = objRow[convzx_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objvzx_QuestionsEN.ZxqaPaperId = objRow[convzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objvzx_QuestionsEN.zxQuestionsTypeId = objRow[convzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_QuestionsEN.RecommendAnswerCount = objRow[convzx_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
objvzx_QuestionsEN.UserId = objRow[convzx_Questions.UserId] == DBNull.Value ? null : objRow[convzx_Questions.UserId].ToString().Trim(); //用户ID
objvzx_QuestionsEN.IdXzMajor = objRow[convzx_Questions.IdXzMajor] == DBNull.Value ? null : objRow[convzx_Questions.IdXzMajor].ToString().Trim(); //专业流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_QuestionsDA: GetObjLst)", objException.Message));
}
objvzx_QuestionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_QuestionsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvzx_QuestionsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvzx_Questions(ref clsvzx_QuestionsEN objvzx_QuestionsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Questions where zxQuestionsId = " + "'"+ objvzx_QuestionsEN.zxQuestionsId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvzx_QuestionsEN.zxQuestionsId = objDT.Rows[0][convzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_QuestionsEN.UserName = objDT.Rows[0][convzx_Questions.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvzx_QuestionsEN.QuestionsTypeName = objDT.Rows[0][convzx_Questions.QuestionsTypeName].ToString().Trim(); //问题类型名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_QuestionsEN.TextTitle = objDT.Rows[0][convzx_Questions.TextTitle].ToString().Trim(); //TextTitle(字段类型:varchar,字段长度:500,是否可空:False)
 objvzx_QuestionsEN.IdCurrEduCls = objDT.Rows[0][convzx_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_QuestionsEN.IsSubmit = TransNullToBool(objDT.Rows[0][convzx_Questions.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_QuestionsEN.TextId = objDT.Rows[0][convzx_Questions.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_QuestionsEN.QuestionsContent = objDT.Rows[0][convzx_Questions.QuestionsContent].ToString().Trim(); //提问内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_QuestionsEN.PdfPageNum = TransNullToInt(objDT.Rows[0][convzx_Questions.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvzx_QuestionsEN.PdfContent = objDT.Rows[0][convzx_Questions.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_QuestionsEN.IsDelete = TransNullToBool(objDT.Rows[0][convzx_Questions.IsDelete].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_QuestionsEN.IsPublic = TransNullToBool(objDT.Rows[0][convzx_Questions.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_QuestionsEN.IsEnd = TransNullToBool(objDT.Rows[0][convzx_Questions.IsEnd].ToString().Trim()); //是否结束(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_QuestionsEN.VoteCount = TransNullToInt(objDT.Rows[0][convzx_Questions.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_QuestionsEN.AnswerCount = TransNullToInt(objDT.Rows[0][convzx_Questions.AnswerCount].ToString().Trim()); //回答计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_QuestionsEN.OrderNum = TransNullToInt(objDT.Rows[0][convzx_Questions.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvzx_QuestionsEN.PdfPageTop = TransNullToInt(objDT.Rows[0][convzx_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objvzx_QuestionsEN.PdfPageNumIn = objDT.Rows[0][convzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_QuestionsEN.PdfDivTop = objDT.Rows[0][convzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_QuestionsEN.PdfDivLet = objDT.Rows[0][convzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_QuestionsEN.PdfZoom = objDT.Rows[0][convzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_QuestionsEN.UpdUser = objDT.Rows[0][convzx_Questions.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_QuestionsEN.UpdDate = objDT.Rows[0][convzx_Questions.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_QuestionsEN.Memo = objDT.Rows[0][convzx_Questions.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_QuestionsEN.DiscussCount = TransNullToInt(objDT.Rows[0][convzx_Questions.DiscussCount].ToString().Trim()); //DiscussCount(字段类型:int,字段长度:4,是否可空:True)
 objvzx_QuestionsEN.GroupDiscussCount = TransNullToInt(objDT.Rows[0][convzx_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount(字段类型:int,字段长度:4,是否可空:True)
 objvzx_QuestionsEN.ZxqaPaperId = objDT.Rows[0][convzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_QuestionsEN.zxQuestionsTypeId = objDT.Rows[0][convzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_QuestionsEN.RecommendAnswerCount = TransNullToInt(objDT.Rows[0][convzx_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount(字段类型:int,字段长度:4,是否可空:True)
 objvzx_QuestionsEN.UserId = objDT.Rows[0][convzx_Questions.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvzx_QuestionsEN.IdXzMajor = objDT.Rows[0][convzx_Questions.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvzx_QuestionsDA: Getvzx_Questions)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strzxQuestionsId">表关键字</param>
 /// <returns>表对象</returns>
public clsvzx_QuestionsEN GetObjByzxQuestionsId(string strzxQuestionsId)
{
CheckPrimaryKey(strzxQuestionsId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Questions where zxQuestionsId = " + "'"+ strzxQuestionsId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvzx_QuestionsEN objvzx_QuestionsEN = new clsvzx_QuestionsEN();
try
{
 objvzx_QuestionsEN.zxQuestionsId = objRow[convzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_QuestionsEN.UserName = objRow[convzx_Questions.UserName] == DBNull.Value ? null : objRow[convzx_Questions.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvzx_QuestionsEN.QuestionsTypeName = objRow[convzx_Questions.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_Questions.QuestionsTypeName].ToString().Trim(); //问题类型名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_QuestionsEN.TextTitle = objRow[convzx_Questions.TextTitle] == DBNull.Value ? null : objRow[convzx_Questions.TextTitle].ToString().Trim(); //TextTitle(字段类型:varchar,字段长度:500,是否可空:False)
 objvzx_QuestionsEN.IdCurrEduCls = objRow[convzx_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_QuestionsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_QuestionsEN.TextId = objRow[convzx_Questions.TextId] == DBNull.Value ? null : objRow[convzx_Questions.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_QuestionsEN.QuestionsContent = objRow[convzx_Questions.QuestionsContent] == DBNull.Value ? null : objRow[convzx_Questions.QuestionsContent].ToString().Trim(); //提问内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_QuestionsEN.PdfPageNum = objRow[convzx_Questions.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvzx_QuestionsEN.PdfContent = objRow[convzx_Questions.PdfContent] == DBNull.Value ? null : objRow[convzx_Questions.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_QuestionsEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsDelete].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_QuestionsEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_QuestionsEN.IsEnd = clsEntityBase2.TransNullToBool_S(objRow[convzx_Questions.IsEnd].ToString().Trim()); //是否结束(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_QuestionsEN.VoteCount = objRow[convzx_Questions.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_QuestionsEN.AnswerCount = objRow[convzx_Questions.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.AnswerCount].ToString().Trim()); //回答计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_QuestionsEN.OrderNum = objRow[convzx_Questions.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvzx_QuestionsEN.PdfPageTop = objRow[convzx_Questions.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objvzx_QuestionsEN.PdfPageNumIn = objRow[convzx_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_QuestionsEN.PdfDivTop = objRow[convzx_Questions.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_QuestionsEN.PdfDivLet = objRow[convzx_Questions.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_QuestionsEN.PdfZoom = objRow[convzx_Questions.PdfZoom] == DBNull.Value ? null : objRow[convzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_QuestionsEN.UpdUser = objRow[convzx_Questions.UpdUser] == DBNull.Value ? null : objRow[convzx_Questions.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_QuestionsEN.UpdDate = objRow[convzx_Questions.UpdDate] == DBNull.Value ? null : objRow[convzx_Questions.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_QuestionsEN.Memo = objRow[convzx_Questions.Memo] == DBNull.Value ? null : objRow[convzx_Questions.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_QuestionsEN.DiscussCount = objRow[convzx_Questions.DiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.DiscussCount].ToString().Trim()); //DiscussCount(字段类型:int,字段长度:4,是否可空:True)
 objvzx_QuestionsEN.GroupDiscussCount = objRow[convzx_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount(字段类型:int,字段长度:4,是否可空:True)
 objvzx_QuestionsEN.ZxqaPaperId = objRow[convzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_QuestionsEN.zxQuestionsTypeId = objRow[convzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_QuestionsEN.RecommendAnswerCount = objRow[convzx_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount(字段类型:int,字段长度:4,是否可空:True)
 objvzx_QuestionsEN.UserId = objRow[convzx_Questions.UserId] == DBNull.Value ? null : objRow[convzx_Questions.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvzx_QuestionsEN.IdXzMajor = objRow[convzx_Questions.IdXzMajor] == DBNull.Value ? null : objRow[convzx_Questions.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvzx_QuestionsDA: GetObjByzxQuestionsId)", objException.Message));
}
return objvzx_QuestionsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvzx_QuestionsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvzx_QuestionsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_QuestionsDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Questions where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvzx_QuestionsEN objvzx_QuestionsEN = new clsvzx_QuestionsEN()
{
zxQuestionsId = objRow[convzx_Questions.zxQuestionsId].ToString().Trim(), //提问Id
UserName = objRow[convzx_Questions.UserName] == DBNull.Value ? null : objRow[convzx_Questions.UserName].ToString().Trim(), //用户名
QuestionsTypeName = objRow[convzx_Questions.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_Questions.QuestionsTypeName].ToString().Trim(), //问题类型名称
TextTitle = objRow[convzx_Questions.TextTitle] == DBNull.Value ? null : objRow[convzx_Questions.TextTitle].ToString().Trim(), //TextTitle
IdCurrEduCls = objRow[convzx_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Questions.IdCurrEduCls].ToString().Trim(), //教学班流水号
IsSubmit = TransNullToBool(objRow[convzx_Questions.IsSubmit].ToString().Trim()), //是否提交
TextId = objRow[convzx_Questions.TextId] == DBNull.Value ? null : objRow[convzx_Questions.TextId].ToString().Trim(), //课件Id
QuestionsContent = objRow[convzx_Questions.QuestionsContent] == DBNull.Value ? null : objRow[convzx_Questions.QuestionsContent].ToString().Trim(), //提问内容
PdfPageNum = objRow[convzx_Questions.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.PdfPageNum].ToString().Trim()), //Pdf页码
PdfContent = objRow[convzx_Questions.PdfContent] == DBNull.Value ? null : objRow[convzx_Questions.PdfContent].ToString().Trim(), //Pdf内容
IsDelete = TransNullToBool(objRow[convzx_Questions.IsDelete].ToString().Trim()), //是否删除
IsPublic = TransNullToBool(objRow[convzx_Questions.IsPublic].ToString().Trim()), //是否公开
IsEnd = TransNullToBool(objRow[convzx_Questions.IsEnd].ToString().Trim()), //是否结束
VoteCount = objRow[convzx_Questions.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.VoteCount].ToString().Trim()), //点赞计数
AnswerCount = objRow[convzx_Questions.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.AnswerCount].ToString().Trim()), //回答计数
OrderNum = objRow[convzx_Questions.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.OrderNum].ToString().Trim()), //序号
PdfPageTop = objRow[convzx_Questions.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.PdfPageTop].ToString().Trim()), //pdf页面顶部位置
PdfPageNumIn = objRow[convzx_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Questions.PdfPageNumIn].ToString().Trim(), //PdfPageNumIn
PdfDivTop = objRow[convzx_Questions.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Questions.PdfDivTop].ToString().Trim(), //PdfDivTop
PdfDivLet = objRow[convzx_Questions.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Questions.PdfDivLet].ToString().Trim(), //PdfDivLet
PdfZoom = objRow[convzx_Questions.PdfZoom] == DBNull.Value ? null : objRow[convzx_Questions.PdfZoom].ToString().Trim(), //PdfZoom
UpdUser = objRow[convzx_Questions.UpdUser] == DBNull.Value ? null : objRow[convzx_Questions.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[convzx_Questions.UpdDate] == DBNull.Value ? null : objRow[convzx_Questions.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convzx_Questions.Memo] == DBNull.Value ? null : objRow[convzx_Questions.Memo].ToString().Trim(), //备注
DiscussCount = objRow[convzx_Questions.DiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.DiscussCount].ToString().Trim()), //DiscussCount
GroupDiscussCount = objRow[convzx_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.GroupDiscussCount].ToString().Trim()), //GroupDiscussCount
ZxqaPaperId = objRow[convzx_Questions.ZxqaPaperId].ToString().Trim(), //论文答疑Id
zxQuestionsTypeId = objRow[convzx_Questions.zxQuestionsTypeId].ToString().Trim(), //问题类型Id
RecommendAnswerCount = objRow[convzx_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.RecommendAnswerCount].ToString().Trim()), //RecommendAnswerCount
UserId = objRow[convzx_Questions.UserId] == DBNull.Value ? null : objRow[convzx_Questions.UserId].ToString().Trim(), //用户ID
IdXzMajor = objRow[convzx_Questions.IdXzMajor] == DBNull.Value ? null : objRow[convzx_Questions.IdXzMajor].ToString().Trim() //专业流水号
};
objvzx_QuestionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_QuestionsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvzx_QuestionsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvzx_QuestionsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_QuestionsEN objvzx_QuestionsEN = new clsvzx_QuestionsEN();
try
{
objvzx_QuestionsEN.zxQuestionsId = objRow[convzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_QuestionsEN.UserName = objRow[convzx_Questions.UserName] == DBNull.Value ? null : objRow[convzx_Questions.UserName].ToString().Trim(); //用户名
objvzx_QuestionsEN.QuestionsTypeName = objRow[convzx_Questions.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_Questions.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_QuestionsEN.TextTitle = objRow[convzx_Questions.TextTitle] == DBNull.Value ? null : objRow[convzx_Questions.TextTitle].ToString().Trim(); //TextTitle
objvzx_QuestionsEN.IdCurrEduCls = objRow[convzx_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_QuestionsEN.IsSubmit = TransNullToBool(objRow[convzx_Questions.IsSubmit].ToString().Trim()); //是否提交
objvzx_QuestionsEN.TextId = objRow[convzx_Questions.TextId] == DBNull.Value ? null : objRow[convzx_Questions.TextId].ToString().Trim(); //课件Id
objvzx_QuestionsEN.QuestionsContent = objRow[convzx_Questions.QuestionsContent] == DBNull.Value ? null : objRow[convzx_Questions.QuestionsContent].ToString().Trim(); //提问内容
objvzx_QuestionsEN.PdfPageNum = objRow[convzx_Questions.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_QuestionsEN.PdfContent = objRow[convzx_Questions.PdfContent] == DBNull.Value ? null : objRow[convzx_Questions.PdfContent].ToString().Trim(); //Pdf内容
objvzx_QuestionsEN.IsDelete = TransNullToBool(objRow[convzx_Questions.IsDelete].ToString().Trim()); //是否删除
objvzx_QuestionsEN.IsPublic = TransNullToBool(objRow[convzx_Questions.IsPublic].ToString().Trim()); //是否公开
objvzx_QuestionsEN.IsEnd = TransNullToBool(objRow[convzx_Questions.IsEnd].ToString().Trim()); //是否结束
objvzx_QuestionsEN.VoteCount = objRow[convzx_Questions.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.VoteCount].ToString().Trim()); //点赞计数
objvzx_QuestionsEN.AnswerCount = objRow[convzx_Questions.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.AnswerCount].ToString().Trim()); //回答计数
objvzx_QuestionsEN.OrderNum = objRow[convzx_Questions.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.OrderNum].ToString().Trim()); //序号
objvzx_QuestionsEN.PdfPageTop = objRow[convzx_Questions.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_QuestionsEN.PdfPageNumIn = objRow[convzx_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_QuestionsEN.PdfDivTop = objRow[convzx_Questions.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_QuestionsEN.PdfDivLet = objRow[convzx_Questions.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_QuestionsEN.PdfZoom = objRow[convzx_Questions.PdfZoom] == DBNull.Value ? null : objRow[convzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_QuestionsEN.UpdUser = objRow[convzx_Questions.UpdUser] == DBNull.Value ? null : objRow[convzx_Questions.UpdUser].ToString().Trim(); //修改人
objvzx_QuestionsEN.UpdDate = objRow[convzx_Questions.UpdDate] == DBNull.Value ? null : objRow[convzx_Questions.UpdDate].ToString().Trim(); //修改日期
objvzx_QuestionsEN.Memo = objRow[convzx_Questions.Memo] == DBNull.Value ? null : objRow[convzx_Questions.Memo].ToString().Trim(); //备注
objvzx_QuestionsEN.DiscussCount = objRow[convzx_Questions.DiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objvzx_QuestionsEN.GroupDiscussCount = objRow[convzx_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objvzx_QuestionsEN.ZxqaPaperId = objRow[convzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objvzx_QuestionsEN.zxQuestionsTypeId = objRow[convzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_QuestionsEN.RecommendAnswerCount = objRow[convzx_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
objvzx_QuestionsEN.UserId = objRow[convzx_Questions.UserId] == DBNull.Value ? null : objRow[convzx_Questions.UserId].ToString().Trim(); //用户ID
objvzx_QuestionsEN.IdXzMajor = objRow[convzx_Questions.IdXzMajor] == DBNull.Value ? null : objRow[convzx_Questions.IdXzMajor].ToString().Trim(); //专业流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvzx_QuestionsDA: GetObjByDataRowvzx_Questions)", objException.Message));
}
objvzx_QuestionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_QuestionsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvzx_QuestionsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_QuestionsEN objvzx_QuestionsEN = new clsvzx_QuestionsEN();
try
{
objvzx_QuestionsEN.zxQuestionsId = objRow[convzx_Questions.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_QuestionsEN.UserName = objRow[convzx_Questions.UserName] == DBNull.Value ? null : objRow[convzx_Questions.UserName].ToString().Trim(); //用户名
objvzx_QuestionsEN.QuestionsTypeName = objRow[convzx_Questions.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_Questions.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_QuestionsEN.TextTitle = objRow[convzx_Questions.TextTitle] == DBNull.Value ? null : objRow[convzx_Questions.TextTitle].ToString().Trim(); //TextTitle
objvzx_QuestionsEN.IdCurrEduCls = objRow[convzx_Questions.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Questions.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_QuestionsEN.IsSubmit = TransNullToBool(objRow[convzx_Questions.IsSubmit].ToString().Trim()); //是否提交
objvzx_QuestionsEN.TextId = objRow[convzx_Questions.TextId] == DBNull.Value ? null : objRow[convzx_Questions.TextId].ToString().Trim(); //课件Id
objvzx_QuestionsEN.QuestionsContent = objRow[convzx_Questions.QuestionsContent] == DBNull.Value ? null : objRow[convzx_Questions.QuestionsContent].ToString().Trim(); //提问内容
objvzx_QuestionsEN.PdfPageNum = objRow[convzx_Questions.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_QuestionsEN.PdfContent = objRow[convzx_Questions.PdfContent] == DBNull.Value ? null : objRow[convzx_Questions.PdfContent].ToString().Trim(); //Pdf内容
objvzx_QuestionsEN.IsDelete = TransNullToBool(objRow[convzx_Questions.IsDelete].ToString().Trim()); //是否删除
objvzx_QuestionsEN.IsPublic = TransNullToBool(objRow[convzx_Questions.IsPublic].ToString().Trim()); //是否公开
objvzx_QuestionsEN.IsEnd = TransNullToBool(objRow[convzx_Questions.IsEnd].ToString().Trim()); //是否结束
objvzx_QuestionsEN.VoteCount = objRow[convzx_Questions.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.VoteCount].ToString().Trim()); //点赞计数
objvzx_QuestionsEN.AnswerCount = objRow[convzx_Questions.AnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.AnswerCount].ToString().Trim()); //回答计数
objvzx_QuestionsEN.OrderNum = objRow[convzx_Questions.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.OrderNum].ToString().Trim()); //序号
objvzx_QuestionsEN.PdfPageTop = objRow[convzx_Questions.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_QuestionsEN.PdfPageNumIn = objRow[convzx_Questions.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Questions.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_QuestionsEN.PdfDivTop = objRow[convzx_Questions.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Questions.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_QuestionsEN.PdfDivLet = objRow[convzx_Questions.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Questions.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_QuestionsEN.PdfZoom = objRow[convzx_Questions.PdfZoom] == DBNull.Value ? null : objRow[convzx_Questions.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_QuestionsEN.UpdUser = objRow[convzx_Questions.UpdUser] == DBNull.Value ? null : objRow[convzx_Questions.UpdUser].ToString().Trim(); //修改人
objvzx_QuestionsEN.UpdDate = objRow[convzx_Questions.UpdDate] == DBNull.Value ? null : objRow[convzx_Questions.UpdDate].ToString().Trim(); //修改日期
objvzx_QuestionsEN.Memo = objRow[convzx_Questions.Memo] == DBNull.Value ? null : objRow[convzx_Questions.Memo].ToString().Trim(); //备注
objvzx_QuestionsEN.DiscussCount = objRow[convzx_Questions.DiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.DiscussCount].ToString().Trim()); //DiscussCount
objvzx_QuestionsEN.GroupDiscussCount = objRow[convzx_Questions.GroupDiscussCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.GroupDiscussCount].ToString().Trim()); //GroupDiscussCount
objvzx_QuestionsEN.ZxqaPaperId = objRow[convzx_Questions.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objvzx_QuestionsEN.zxQuestionsTypeId = objRow[convzx_Questions.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_QuestionsEN.RecommendAnswerCount = objRow[convzx_Questions.RecommendAnswerCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Questions.RecommendAnswerCount].ToString().Trim()); //RecommendAnswerCount
objvzx_QuestionsEN.UserId = objRow[convzx_Questions.UserId] == DBNull.Value ? null : objRow[convzx_Questions.UserId].ToString().Trim(); //用户ID
objvzx_QuestionsEN.IdXzMajor = objRow[convzx_Questions.IdXzMajor] == DBNull.Value ? null : objRow[convzx_Questions.IdXzMajor].ToString().Trim(); //专业流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvzx_QuestionsDA: GetObjByDataRow)", objException.Message));
}
objvzx_QuestionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_QuestionsEN;
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
objSQL = clsvzx_QuestionsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_QuestionsEN._CurrTabName, convzx_Questions.zxQuestionsId, 8, "");
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
objSQL = clsvzx_QuestionsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_QuestionsEN._CurrTabName, convzx_Questions.zxQuestionsId, 8, strPrefix);
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
 objSQL = clsvzx_QuestionsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select zxQuestionsId from vzx_Questions where " + strCondition;
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
 objSQL = clsvzx_QuestionsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select zxQuestionsId from vzx_Questions where " + strCondition;
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
 /// <param name = "strzxQuestionsId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strzxQuestionsId)
{
CheckPrimaryKey(strzxQuestionsId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_QuestionsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_Questions", "zxQuestionsId = " + "'"+ strzxQuestionsId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvzx_QuestionsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_QuestionsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_Questions", strCondition))
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
objSQL = clsvzx_QuestionsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vzx_Questions");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvzx_QuestionsENS">源对象</param>
 /// <param name = "objvzx_QuestionsENT">目标对象</param>
public void CopyTo(clsvzx_QuestionsEN objvzx_QuestionsENS, clsvzx_QuestionsEN objvzx_QuestionsENT)
{
objvzx_QuestionsENT.zxQuestionsId = objvzx_QuestionsENS.zxQuestionsId; //提问Id
objvzx_QuestionsENT.UserName = objvzx_QuestionsENS.UserName; //用户名
objvzx_QuestionsENT.QuestionsTypeName = objvzx_QuestionsENS.QuestionsTypeName; //问题类型名称
objvzx_QuestionsENT.TextTitle = objvzx_QuestionsENS.TextTitle; //TextTitle
objvzx_QuestionsENT.IdCurrEduCls = objvzx_QuestionsENS.IdCurrEduCls; //教学班流水号
objvzx_QuestionsENT.IsSubmit = objvzx_QuestionsENS.IsSubmit; //是否提交
objvzx_QuestionsENT.TextId = objvzx_QuestionsENS.TextId; //课件Id
objvzx_QuestionsENT.QuestionsContent = objvzx_QuestionsENS.QuestionsContent; //提问内容
objvzx_QuestionsENT.PdfPageNum = objvzx_QuestionsENS.PdfPageNum; //Pdf页码
objvzx_QuestionsENT.PdfContent = objvzx_QuestionsENS.PdfContent; //Pdf内容
objvzx_QuestionsENT.IsDelete = objvzx_QuestionsENS.IsDelete; //是否删除
objvzx_QuestionsENT.IsPublic = objvzx_QuestionsENS.IsPublic; //是否公开
objvzx_QuestionsENT.IsEnd = objvzx_QuestionsENS.IsEnd; //是否结束
objvzx_QuestionsENT.VoteCount = objvzx_QuestionsENS.VoteCount; //点赞计数
objvzx_QuestionsENT.AnswerCount = objvzx_QuestionsENS.AnswerCount; //回答计数
objvzx_QuestionsENT.OrderNum = objvzx_QuestionsENS.OrderNum; //序号
objvzx_QuestionsENT.PdfPageTop = objvzx_QuestionsENS.PdfPageTop; //pdf页面顶部位置
objvzx_QuestionsENT.PdfPageNumIn = objvzx_QuestionsENS.PdfPageNumIn; //PdfPageNumIn
objvzx_QuestionsENT.PdfDivTop = objvzx_QuestionsENS.PdfDivTop; //PdfDivTop
objvzx_QuestionsENT.PdfDivLet = objvzx_QuestionsENS.PdfDivLet; //PdfDivLet
objvzx_QuestionsENT.PdfZoom = objvzx_QuestionsENS.PdfZoom; //PdfZoom
objvzx_QuestionsENT.UpdUser = objvzx_QuestionsENS.UpdUser; //修改人
objvzx_QuestionsENT.UpdDate = objvzx_QuestionsENS.UpdDate; //修改日期
objvzx_QuestionsENT.Memo = objvzx_QuestionsENS.Memo; //备注
objvzx_QuestionsENT.DiscussCount = objvzx_QuestionsENS.DiscussCount; //DiscussCount
objvzx_QuestionsENT.GroupDiscussCount = objvzx_QuestionsENS.GroupDiscussCount; //GroupDiscussCount
objvzx_QuestionsENT.ZxqaPaperId = objvzx_QuestionsENS.ZxqaPaperId; //论文答疑Id
objvzx_QuestionsENT.zxQuestionsTypeId = objvzx_QuestionsENS.zxQuestionsTypeId; //问题类型Id
objvzx_QuestionsENT.RecommendAnswerCount = objvzx_QuestionsENS.RecommendAnswerCount; //RecommendAnswerCount
objvzx_QuestionsENT.UserId = objvzx_QuestionsENS.UserId; //用户ID
objvzx_QuestionsENT.IdXzMajor = objvzx_QuestionsENS.IdXzMajor; //专业流水号
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvzx_QuestionsEN objvzx_QuestionsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvzx_QuestionsEN.zxQuestionsId, 8, convzx_Questions.zxQuestionsId);
clsCheckSql.CheckFieldLen(objvzx_QuestionsEN.UserName, 30, convzx_Questions.UserName);
clsCheckSql.CheckFieldLen(objvzx_QuestionsEN.QuestionsTypeName, 50, convzx_Questions.QuestionsTypeName);
clsCheckSql.CheckFieldLen(objvzx_QuestionsEN.TextTitle, 500, convzx_Questions.TextTitle);
clsCheckSql.CheckFieldLen(objvzx_QuestionsEN.IdCurrEduCls, 8, convzx_Questions.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvzx_QuestionsEN.TextId, 8, convzx_Questions.TextId);
clsCheckSql.CheckFieldLen(objvzx_QuestionsEN.QuestionsContent, 1000, convzx_Questions.QuestionsContent);
clsCheckSql.CheckFieldLen(objvzx_QuestionsEN.PdfContent, 2000, convzx_Questions.PdfContent);
clsCheckSql.CheckFieldLen(objvzx_QuestionsEN.PdfPageNumIn, 50, convzx_Questions.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objvzx_QuestionsEN.PdfDivTop, 50, convzx_Questions.PdfDivTop);
clsCheckSql.CheckFieldLen(objvzx_QuestionsEN.PdfDivLet, 50, convzx_Questions.PdfDivLet);
clsCheckSql.CheckFieldLen(objvzx_QuestionsEN.PdfZoom, 50, convzx_Questions.PdfZoom);
clsCheckSql.CheckFieldLen(objvzx_QuestionsEN.UpdUser, 20, convzx_Questions.UpdUser);
clsCheckSql.CheckFieldLen(objvzx_QuestionsEN.UpdDate, 20, convzx_Questions.UpdDate);
clsCheckSql.CheckFieldLen(objvzx_QuestionsEN.Memo, 1000, convzx_Questions.Memo);
clsCheckSql.CheckFieldLen(objvzx_QuestionsEN.ZxqaPaperId, 8, convzx_Questions.ZxqaPaperId);
clsCheckSql.CheckFieldLen(objvzx_QuestionsEN.zxQuestionsTypeId, 2, convzx_Questions.zxQuestionsTypeId);
clsCheckSql.CheckFieldLen(objvzx_QuestionsEN.UserId, 18, convzx_Questions.UserId);
clsCheckSql.CheckFieldLen(objvzx_QuestionsEN.IdXzMajor, 8, convzx_Questions.IdXzMajor);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvzx_QuestionsEN.zxQuestionsId, convzx_Questions.zxQuestionsId);
clsCheckSql.CheckSqlInjection4Field(objvzx_QuestionsEN.UserName, convzx_Questions.UserName);
clsCheckSql.CheckSqlInjection4Field(objvzx_QuestionsEN.QuestionsTypeName, convzx_Questions.QuestionsTypeName);
clsCheckSql.CheckSqlInjection4Field(objvzx_QuestionsEN.TextTitle, convzx_Questions.TextTitle);
clsCheckSql.CheckSqlInjection4Field(objvzx_QuestionsEN.IdCurrEduCls, convzx_Questions.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvzx_QuestionsEN.TextId, convzx_Questions.TextId);
clsCheckSql.CheckSqlInjection4Field(objvzx_QuestionsEN.QuestionsContent, convzx_Questions.QuestionsContent);
clsCheckSql.CheckSqlInjection4Field(objvzx_QuestionsEN.PdfContent, convzx_Questions.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objvzx_QuestionsEN.PdfPageNumIn, convzx_Questions.PdfPageNumIn);
clsCheckSql.CheckSqlInjection4Field(objvzx_QuestionsEN.PdfDivTop, convzx_Questions.PdfDivTop);
clsCheckSql.CheckSqlInjection4Field(objvzx_QuestionsEN.PdfDivLet, convzx_Questions.PdfDivLet);
clsCheckSql.CheckSqlInjection4Field(objvzx_QuestionsEN.PdfZoom, convzx_Questions.PdfZoom);
clsCheckSql.CheckSqlInjection4Field(objvzx_QuestionsEN.UpdUser, convzx_Questions.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvzx_QuestionsEN.UpdDate, convzx_Questions.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_QuestionsEN.Memo, convzx_Questions.Memo);
clsCheckSql.CheckSqlInjection4Field(objvzx_QuestionsEN.ZxqaPaperId, convzx_Questions.ZxqaPaperId);
clsCheckSql.CheckSqlInjection4Field(objvzx_QuestionsEN.zxQuestionsTypeId, convzx_Questions.zxQuestionsTypeId);
clsCheckSql.CheckSqlInjection4Field(objvzx_QuestionsEN.UserId, convzx_Questions.UserId);
clsCheckSql.CheckSqlInjection4Field(objvzx_QuestionsEN.IdXzMajor, convzx_Questions.IdXzMajor);
//检查外键字段长度
 objvzx_QuestionsEN._IsCheckProperty = true;
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
 objSQL = clsvzx_QuestionsDA.GetSpecSQLObj();
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
 objSQL = clsvzx_QuestionsDA.GetSpecSQLObj();
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
 objSQL = clsvzx_QuestionsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_QuestionsEN._CurrTabName);
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
 objSQL = clsvzx_QuestionsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_QuestionsEN._CurrTabName, strCondition);
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
 objSQL = clsvzx_QuestionsDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}