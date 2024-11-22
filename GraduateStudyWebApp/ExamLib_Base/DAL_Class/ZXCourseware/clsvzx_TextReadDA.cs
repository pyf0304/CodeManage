
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_TextReadDA
 表名:vzx_TextRead(01120732)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:50:59
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
 /// vzx_TextRead(vzx_TextRead)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvzx_TextReadDA : clsCommBase4DA
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
 return clsvzx_TextReadEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvzx_TextReadEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_TextReadEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvzx_TextReadEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvzx_TextReadEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strTextRId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strTextRId)
{
strTextRId = strTextRId.Replace("'", "''");
if (strTextRId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:vzx_TextRead中,检查关键字,长度不正确!(clsvzx_TextReadDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTextRId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vzx_TextRead中,关键字不能为空 或 null!(clsvzx_TextReadDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTextRId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvzx_TextReadDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvzx_TextReadDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TextReadDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TextRead where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vzx_TextRead(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvzx_TextReadDA: GetDataTable_vzx_TextRead)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TextReadDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TextRead where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvzx_TextReadDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TextReadDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvzx_TextReadDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TextReadDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TextRead where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvzx_TextReadDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TextReadDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvzx_TextReadDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TextReadDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_TextRead where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_TextRead where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvzx_TextReadDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TextReadDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vzx_TextRead where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvzx_TextReadDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TextReadDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_TextRead.* from vzx_TextRead Left Join {1} on {2} where {3} and vzx_TextRead.TextRId not in (Select top {5} vzx_TextRead.TextRId from vzx_TextRead Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_TextRead where {1} and TextRId not in (Select top {2} TextRId from vzx_TextRead where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_TextRead where {1} and TextRId not in (Select top {3} TextRId from vzx_TextRead where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvzx_TextReadDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TextReadDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_TextRead.* from vzx_TextRead Left Join {1} on {2} where {3} and vzx_TextRead.TextRId not in (Select top {5} vzx_TextRead.TextRId from vzx_TextRead Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_TextRead where {1} and TextRId not in (Select top {2} TextRId from vzx_TextRead where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_TextRead where {1} and TextRId not in (Select top {3} TextRId from vzx_TextRead where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvzx_TextReadEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvzx_TextReadDA:GetObjLst)", objException.Message));
}
List<clsvzx_TextReadEN> arrObjLst = new List<clsvzx_TextReadEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TextReadDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TextRead where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TextReadEN objvzx_TextReadEN = new clsvzx_TextReadEN();
try
{
objvzx_TextReadEN.TextTitle = objRow[convzx_TextRead.TextTitle] == DBNull.Value ? null : objRow[convzx_TextRead.TextTitle].ToString().Trim(); //TextTitle
objvzx_TextReadEN.TextRId = objRow[convzx_TextRead.TextRId].ToString().Trim(); //TextRId
objvzx_TextReadEN.ReaderUserId = objRow[convzx_TextRead.ReaderUserId] == DBNull.Value ? null : objRow[convzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId
objvzx_TextReadEN.TextId = objRow[convzx_TextRead.TextId] == DBNull.Value ? null : objRow[convzx_TextRead.TextId].ToString().Trim(); //课件Id
objvzx_TextReadEN.ReadTypeId = objRow[convzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型
objvzx_TextReadEN.IsSubmit = TransNullToBool(objRow[convzx_TextRead.IsSubmit].ToString().Trim()); //是否提交
objvzx_TextReadEN.IsPublic = TransNullToBool(objRow[convzx_TextRead.IsPublic].ToString().Trim()); //是否公开
objvzx_TextReadEN.Submitter = objRow[convzx_TextRead.Submitter] == DBNull.Value ? null : objRow[convzx_TextRead.Submitter].ToString().Trim(); //提交人
objvzx_TextReadEN.IdCurrEduCls = objRow[convzx_TextRead.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TextReadEN.QuestionCount = objRow[convzx_TextRead.QuestionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextRead.QuestionCount].ToString().Trim()); //问题数
objvzx_TextReadEN.CreateDate = objRow[convzx_TextRead.CreateDate] == DBNull.Value ? null : objRow[convzx_TextRead.CreateDate].ToString().Trim(); //建立日期
objvzx_TextReadEN.UpdUser = objRow[convzx_TextRead.UpdUser] == DBNull.Value ? null : objRow[convzx_TextRead.UpdUser].ToString().Trim(); //修改人
objvzx_TextReadEN.UpdDate = objRow[convzx_TextRead.UpdDate].ToString().Trim(); //修改日期
objvzx_TextReadEN.Memo = objRow[convzx_TextRead.Memo] == DBNull.Value ? null : objRow[convzx_TextRead.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_TextReadDA: GetObjLst)", objException.Message));
}
objvzx_TextReadEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_TextReadEN);
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
public List<clsvzx_TextReadEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvzx_TextReadDA:GetObjLstByTabName)", objException.Message));
}
List<clsvzx_TextReadEN> arrObjLst = new List<clsvzx_TextReadEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TextReadDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TextReadEN objvzx_TextReadEN = new clsvzx_TextReadEN();
try
{
objvzx_TextReadEN.TextTitle = objRow[convzx_TextRead.TextTitle] == DBNull.Value ? null : objRow[convzx_TextRead.TextTitle].ToString().Trim(); //TextTitle
objvzx_TextReadEN.TextRId = objRow[convzx_TextRead.TextRId].ToString().Trim(); //TextRId
objvzx_TextReadEN.ReaderUserId = objRow[convzx_TextRead.ReaderUserId] == DBNull.Value ? null : objRow[convzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId
objvzx_TextReadEN.TextId = objRow[convzx_TextRead.TextId] == DBNull.Value ? null : objRow[convzx_TextRead.TextId].ToString().Trim(); //课件Id
objvzx_TextReadEN.ReadTypeId = objRow[convzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型
objvzx_TextReadEN.IsSubmit = TransNullToBool(objRow[convzx_TextRead.IsSubmit].ToString().Trim()); //是否提交
objvzx_TextReadEN.IsPublic = TransNullToBool(objRow[convzx_TextRead.IsPublic].ToString().Trim()); //是否公开
objvzx_TextReadEN.Submitter = objRow[convzx_TextRead.Submitter] == DBNull.Value ? null : objRow[convzx_TextRead.Submitter].ToString().Trim(); //提交人
objvzx_TextReadEN.IdCurrEduCls = objRow[convzx_TextRead.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TextReadEN.QuestionCount = objRow[convzx_TextRead.QuestionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextRead.QuestionCount].ToString().Trim()); //问题数
objvzx_TextReadEN.CreateDate = objRow[convzx_TextRead.CreateDate] == DBNull.Value ? null : objRow[convzx_TextRead.CreateDate].ToString().Trim(); //建立日期
objvzx_TextReadEN.UpdUser = objRow[convzx_TextRead.UpdUser] == DBNull.Value ? null : objRow[convzx_TextRead.UpdUser].ToString().Trim(); //修改人
objvzx_TextReadEN.UpdDate = objRow[convzx_TextRead.UpdDate].ToString().Trim(); //修改日期
objvzx_TextReadEN.Memo = objRow[convzx_TextRead.Memo] == DBNull.Value ? null : objRow[convzx_TextRead.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_TextReadDA: GetObjLst)", objException.Message));
}
objvzx_TextReadEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_TextReadEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvzx_TextReadEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvzx_TextRead(ref clsvzx_TextReadEN objvzx_TextReadEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TextReadDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TextRead where TextRId = " + "'"+ objvzx_TextReadEN.TextRId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvzx_TextReadEN.TextTitle = objDT.Rows[0][convzx_TextRead.TextTitle].ToString().Trim(); //TextTitle(字段类型:varchar,字段长度:500,是否可空:False)
 objvzx_TextReadEN.TextRId = objDT.Rows[0][convzx_TextRead.TextRId].ToString().Trim(); //TextRId(字段类型:char,字段长度:10,是否可空:False)
 objvzx_TextReadEN.ReaderUserId = objDT.Rows[0][convzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TextReadEN.TextId = objDT.Rows[0][convzx_TextRead.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_TextReadEN.ReadTypeId = objDT.Rows[0][convzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型(字段类型:char,字段长度:2,是否可空:False)
 objvzx_TextReadEN.IsSubmit = TransNullToBool(objDT.Rows[0][convzx_TextRead.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_TextReadEN.IsPublic = TransNullToBool(objDT.Rows[0][convzx_TextRead.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_TextReadEN.Submitter = objDT.Rows[0][convzx_TextRead.Submitter].ToString().Trim(); //提交人(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_TextReadEN.IdCurrEduCls = objDT.Rows[0][convzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_TextReadEN.QuestionCount = TransNullToInt(objDT.Rows[0][convzx_TextRead.QuestionCount].ToString().Trim()); //问题数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TextReadEN.CreateDate = objDT.Rows[0][convzx_TextRead.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TextReadEN.UpdUser = objDT.Rows[0][convzx_TextRead.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TextReadEN.UpdDate = objDT.Rows[0][convzx_TextRead.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TextReadEN.Memo = objDT.Rows[0][convzx_TextRead.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvzx_TextReadDA: Getvzx_TextRead)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTextRId">表关键字</param>
 /// <returns>表对象</returns>
public clsvzx_TextReadEN GetObjByTextRId(string strTextRId)
{
CheckPrimaryKey(strTextRId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TextReadDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TextRead where TextRId = " + "'"+ strTextRId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvzx_TextReadEN objvzx_TextReadEN = new clsvzx_TextReadEN();
try
{
 objvzx_TextReadEN.TextTitle = objRow[convzx_TextRead.TextTitle] == DBNull.Value ? null : objRow[convzx_TextRead.TextTitle].ToString().Trim(); //TextTitle(字段类型:varchar,字段长度:500,是否可空:False)
 objvzx_TextReadEN.TextRId = objRow[convzx_TextRead.TextRId].ToString().Trim(); //TextRId(字段类型:char,字段长度:10,是否可空:False)
 objvzx_TextReadEN.ReaderUserId = objRow[convzx_TextRead.ReaderUserId] == DBNull.Value ? null : objRow[convzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TextReadEN.TextId = objRow[convzx_TextRead.TextId] == DBNull.Value ? null : objRow[convzx_TextRead.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_TextReadEN.ReadTypeId = objRow[convzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型(字段类型:char,字段长度:2,是否可空:False)
 objvzx_TextReadEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TextRead.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_TextReadEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_TextRead.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_TextReadEN.Submitter = objRow[convzx_TextRead.Submitter] == DBNull.Value ? null : objRow[convzx_TextRead.Submitter].ToString().Trim(); //提交人(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_TextReadEN.IdCurrEduCls = objRow[convzx_TextRead.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_TextReadEN.QuestionCount = objRow[convzx_TextRead.QuestionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextRead.QuestionCount].ToString().Trim()); //问题数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TextReadEN.CreateDate = objRow[convzx_TextRead.CreateDate] == DBNull.Value ? null : objRow[convzx_TextRead.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TextReadEN.UpdUser = objRow[convzx_TextRead.UpdUser] == DBNull.Value ? null : objRow[convzx_TextRead.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TextReadEN.UpdDate = objRow[convzx_TextRead.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TextReadEN.Memo = objRow[convzx_TextRead.Memo] == DBNull.Value ? null : objRow[convzx_TextRead.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvzx_TextReadDA: GetObjByTextRId)", objException.Message));
}
return objvzx_TextReadEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvzx_TextReadEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvzx_TextReadDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TextReadDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TextRead where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvzx_TextReadEN objvzx_TextReadEN = new clsvzx_TextReadEN()
{
TextTitle = objRow[convzx_TextRead.TextTitle] == DBNull.Value ? null : objRow[convzx_TextRead.TextTitle].ToString().Trim(), //TextTitle
TextRId = objRow[convzx_TextRead.TextRId].ToString().Trim(), //TextRId
ReaderUserId = objRow[convzx_TextRead.ReaderUserId] == DBNull.Value ? null : objRow[convzx_TextRead.ReaderUserId].ToString().Trim(), //ReaderUserId
TextId = objRow[convzx_TextRead.TextId] == DBNull.Value ? null : objRow[convzx_TextRead.TextId].ToString().Trim(), //课件Id
ReadTypeId = objRow[convzx_TextRead.ReadTypeId].ToString().Trim(), //阅读类型
IsSubmit = TransNullToBool(objRow[convzx_TextRead.IsSubmit].ToString().Trim()), //是否提交
IsPublic = TransNullToBool(objRow[convzx_TextRead.IsPublic].ToString().Trim()), //是否公开
Submitter = objRow[convzx_TextRead.Submitter] == DBNull.Value ? null : objRow[convzx_TextRead.Submitter].ToString().Trim(), //提交人
IdCurrEduCls = objRow[convzx_TextRead.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TextRead.IdCurrEduCls].ToString().Trim(), //教学班流水号
QuestionCount = objRow[convzx_TextRead.QuestionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextRead.QuestionCount].ToString().Trim()), //问题数
CreateDate = objRow[convzx_TextRead.CreateDate] == DBNull.Value ? null : objRow[convzx_TextRead.CreateDate].ToString().Trim(), //建立日期
UpdUser = objRow[convzx_TextRead.UpdUser] == DBNull.Value ? null : objRow[convzx_TextRead.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[convzx_TextRead.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convzx_TextRead.Memo] == DBNull.Value ? null : objRow[convzx_TextRead.Memo].ToString().Trim() //备注
};
objvzx_TextReadEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_TextReadEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvzx_TextReadDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvzx_TextReadEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_TextReadEN objvzx_TextReadEN = new clsvzx_TextReadEN();
try
{
objvzx_TextReadEN.TextTitle = objRow[convzx_TextRead.TextTitle] == DBNull.Value ? null : objRow[convzx_TextRead.TextTitle].ToString().Trim(); //TextTitle
objvzx_TextReadEN.TextRId = objRow[convzx_TextRead.TextRId].ToString().Trim(); //TextRId
objvzx_TextReadEN.ReaderUserId = objRow[convzx_TextRead.ReaderUserId] == DBNull.Value ? null : objRow[convzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId
objvzx_TextReadEN.TextId = objRow[convzx_TextRead.TextId] == DBNull.Value ? null : objRow[convzx_TextRead.TextId].ToString().Trim(); //课件Id
objvzx_TextReadEN.ReadTypeId = objRow[convzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型
objvzx_TextReadEN.IsSubmit = TransNullToBool(objRow[convzx_TextRead.IsSubmit].ToString().Trim()); //是否提交
objvzx_TextReadEN.IsPublic = TransNullToBool(objRow[convzx_TextRead.IsPublic].ToString().Trim()); //是否公开
objvzx_TextReadEN.Submitter = objRow[convzx_TextRead.Submitter] == DBNull.Value ? null : objRow[convzx_TextRead.Submitter].ToString().Trim(); //提交人
objvzx_TextReadEN.IdCurrEduCls = objRow[convzx_TextRead.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TextReadEN.QuestionCount = objRow[convzx_TextRead.QuestionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextRead.QuestionCount].ToString().Trim()); //问题数
objvzx_TextReadEN.CreateDate = objRow[convzx_TextRead.CreateDate] == DBNull.Value ? null : objRow[convzx_TextRead.CreateDate].ToString().Trim(); //建立日期
objvzx_TextReadEN.UpdUser = objRow[convzx_TextRead.UpdUser] == DBNull.Value ? null : objRow[convzx_TextRead.UpdUser].ToString().Trim(); //修改人
objvzx_TextReadEN.UpdDate = objRow[convzx_TextRead.UpdDate].ToString().Trim(); //修改日期
objvzx_TextReadEN.Memo = objRow[convzx_TextRead.Memo] == DBNull.Value ? null : objRow[convzx_TextRead.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvzx_TextReadDA: GetObjByDataRowvzx_TextRead)", objException.Message));
}
objvzx_TextReadEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_TextReadEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvzx_TextReadEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_TextReadEN objvzx_TextReadEN = new clsvzx_TextReadEN();
try
{
objvzx_TextReadEN.TextTitle = objRow[convzx_TextRead.TextTitle] == DBNull.Value ? null : objRow[convzx_TextRead.TextTitle].ToString().Trim(); //TextTitle
objvzx_TextReadEN.TextRId = objRow[convzx_TextRead.TextRId].ToString().Trim(); //TextRId
objvzx_TextReadEN.ReaderUserId = objRow[convzx_TextRead.ReaderUserId] == DBNull.Value ? null : objRow[convzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId
objvzx_TextReadEN.TextId = objRow[convzx_TextRead.TextId] == DBNull.Value ? null : objRow[convzx_TextRead.TextId].ToString().Trim(); //课件Id
objvzx_TextReadEN.ReadTypeId = objRow[convzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型
objvzx_TextReadEN.IsSubmit = TransNullToBool(objRow[convzx_TextRead.IsSubmit].ToString().Trim()); //是否提交
objvzx_TextReadEN.IsPublic = TransNullToBool(objRow[convzx_TextRead.IsPublic].ToString().Trim()); //是否公开
objvzx_TextReadEN.Submitter = objRow[convzx_TextRead.Submitter] == DBNull.Value ? null : objRow[convzx_TextRead.Submitter].ToString().Trim(); //提交人
objvzx_TextReadEN.IdCurrEduCls = objRow[convzx_TextRead.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TextReadEN.QuestionCount = objRow[convzx_TextRead.QuestionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextRead.QuestionCount].ToString().Trim()); //问题数
objvzx_TextReadEN.CreateDate = objRow[convzx_TextRead.CreateDate] == DBNull.Value ? null : objRow[convzx_TextRead.CreateDate].ToString().Trim(); //建立日期
objvzx_TextReadEN.UpdUser = objRow[convzx_TextRead.UpdUser] == DBNull.Value ? null : objRow[convzx_TextRead.UpdUser].ToString().Trim(); //修改人
objvzx_TextReadEN.UpdDate = objRow[convzx_TextRead.UpdDate].ToString().Trim(); //修改日期
objvzx_TextReadEN.Memo = objRow[convzx_TextRead.Memo] == DBNull.Value ? null : objRow[convzx_TextRead.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvzx_TextReadDA: GetObjByDataRow)", objException.Message));
}
objvzx_TextReadEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_TextReadEN;
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
objSQL = clsvzx_TextReadDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_TextReadEN._CurrTabName, convzx_TextRead.TextRId, 10, "");
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
objSQL = clsvzx_TextReadDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_TextReadEN._CurrTabName, convzx_TextRead.TextRId, 10, strPrefix);
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
 objSQL = clsvzx_TextReadDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TextRId from vzx_TextRead where " + strCondition;
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
 objSQL = clsvzx_TextReadDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TextRId from vzx_TextRead where " + strCondition;
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
 /// <param name = "strTextRId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strTextRId)
{
CheckPrimaryKey(strTextRId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TextReadDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_TextRead", "TextRId = " + "'"+ strTextRId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvzx_TextReadDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TextReadDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_TextRead", strCondition))
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
objSQL = clsvzx_TextReadDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vzx_TextRead");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvzx_TextReadENS">源对象</param>
 /// <param name = "objvzx_TextReadENT">目标对象</param>
public void CopyTo(clsvzx_TextReadEN objvzx_TextReadENS, clsvzx_TextReadEN objvzx_TextReadENT)
{
objvzx_TextReadENT.TextTitle = objvzx_TextReadENS.TextTitle; //TextTitle
objvzx_TextReadENT.TextRId = objvzx_TextReadENS.TextRId; //TextRId
objvzx_TextReadENT.ReaderUserId = objvzx_TextReadENS.ReaderUserId; //ReaderUserId
objvzx_TextReadENT.TextId = objvzx_TextReadENS.TextId; //课件Id
objvzx_TextReadENT.ReadTypeId = objvzx_TextReadENS.ReadTypeId; //阅读类型
objvzx_TextReadENT.IsSubmit = objvzx_TextReadENS.IsSubmit; //是否提交
objvzx_TextReadENT.IsPublic = objvzx_TextReadENS.IsPublic; //是否公开
objvzx_TextReadENT.Submitter = objvzx_TextReadENS.Submitter; //提交人
objvzx_TextReadENT.IdCurrEduCls = objvzx_TextReadENS.IdCurrEduCls; //教学班流水号
objvzx_TextReadENT.QuestionCount = objvzx_TextReadENS.QuestionCount; //问题数
objvzx_TextReadENT.CreateDate = objvzx_TextReadENS.CreateDate; //建立日期
objvzx_TextReadENT.UpdUser = objvzx_TextReadENS.UpdUser; //修改人
objvzx_TextReadENT.UpdDate = objvzx_TextReadENS.UpdDate; //修改日期
objvzx_TextReadENT.Memo = objvzx_TextReadENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvzx_TextReadEN objvzx_TextReadEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvzx_TextReadEN.TextTitle, 500, convzx_TextRead.TextTitle);
clsCheckSql.CheckFieldLen(objvzx_TextReadEN.TextRId, 10, convzx_TextRead.TextRId);
clsCheckSql.CheckFieldLen(objvzx_TextReadEN.ReaderUserId, 20, convzx_TextRead.ReaderUserId);
clsCheckSql.CheckFieldLen(objvzx_TextReadEN.TextId, 8, convzx_TextRead.TextId);
clsCheckSql.CheckFieldLen(objvzx_TextReadEN.ReadTypeId, 2, convzx_TextRead.ReadTypeId);
clsCheckSql.CheckFieldLen(objvzx_TextReadEN.Submitter, 50, convzx_TextRead.Submitter);
clsCheckSql.CheckFieldLen(objvzx_TextReadEN.IdCurrEduCls, 8, convzx_TextRead.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvzx_TextReadEN.CreateDate, 20, convzx_TextRead.CreateDate);
clsCheckSql.CheckFieldLen(objvzx_TextReadEN.UpdUser, 20, convzx_TextRead.UpdUser);
clsCheckSql.CheckFieldLen(objvzx_TextReadEN.UpdDate, 20, convzx_TextRead.UpdDate);
clsCheckSql.CheckFieldLen(objvzx_TextReadEN.Memo, 1000, convzx_TextRead.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvzx_TextReadEN.TextTitle, convzx_TextRead.TextTitle);
clsCheckSql.CheckSqlInjection4Field(objvzx_TextReadEN.TextRId, convzx_TextRead.TextRId);
clsCheckSql.CheckSqlInjection4Field(objvzx_TextReadEN.ReaderUserId, convzx_TextRead.ReaderUserId);
clsCheckSql.CheckSqlInjection4Field(objvzx_TextReadEN.TextId, convzx_TextRead.TextId);
clsCheckSql.CheckSqlInjection4Field(objvzx_TextReadEN.ReadTypeId, convzx_TextRead.ReadTypeId);
clsCheckSql.CheckSqlInjection4Field(objvzx_TextReadEN.Submitter, convzx_TextRead.Submitter);
clsCheckSql.CheckSqlInjection4Field(objvzx_TextReadEN.IdCurrEduCls, convzx_TextRead.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvzx_TextReadEN.CreateDate, convzx_TextRead.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_TextReadEN.UpdUser, convzx_TextRead.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvzx_TextReadEN.UpdDate, convzx_TextRead.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_TextReadEN.Memo, convzx_TextRead.Memo);
//检查外键字段长度
 objvzx_TextReadEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetTextRId()
{
//获取某学院所有专业信息
string strSQL = "select TextRId, ReadTypeId from vzx_TextRead ";
 clsSpecSQLforSql mySql = clsvzx_TextReadDA.GetSpecSQLObj();
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
 objSQL = clsvzx_TextReadDA.GetSpecSQLObj();
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
 objSQL = clsvzx_TextReadDA.GetSpecSQLObj();
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
 objSQL = clsvzx_TextReadDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_TextReadEN._CurrTabName);
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
 objSQL = clsvzx_TextReadDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_TextReadEN._CurrTabName, strCondition);
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
 objSQL = clsvzx_TextReadDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}