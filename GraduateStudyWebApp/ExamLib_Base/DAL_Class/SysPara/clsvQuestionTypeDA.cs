
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionTypeDA
 表名:vQuestionType(01120114)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:07:47
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
 /// v题目类型(vQuestionType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvQuestionTypeDA : clsCommBase4DA
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
 return clsvQuestionTypeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvQuestionTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQuestionTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvQuestionTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvQuestionTypeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strQuestionTypeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strQuestionTypeId)
{
strQuestionTypeId = strQuestionTypeId.Replace("'", "''");
if (strQuestionTypeId.Length > 2)
{
throw new Exception("(errid:Data000001)在表:vQuestionType中,检查关键字,长度不正确!(clsvQuestionTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strQuestionTypeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vQuestionType中,关键字不能为空 或 null!(clsvQuestionTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strQuestionTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvQuestionTypeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvQuestionTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionTypeDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vQuestionType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvQuestionTypeDA: GetDataTable_vQuestionType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionTypeDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvQuestionTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvQuestionTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionTypeDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvQuestionTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvQuestionTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQuestionType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQuestionType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvQuestionTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQuestionType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvQuestionTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQuestionType.* from vQuestionType Left Join {1} on {2} where {3} and vQuestionType.QuestionTypeId not in (Select top {5} vQuestionType.QuestionTypeId from vQuestionType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQuestionType where {1} and QuestionTypeId not in (Select top {2} QuestionTypeId from vQuestionType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQuestionType where {1} and QuestionTypeId not in (Select top {3} QuestionTypeId from vQuestionType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvQuestionTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQuestionType.* from vQuestionType Left Join {1} on {2} where {3} and vQuestionType.QuestionTypeId not in (Select top {5} vQuestionType.QuestionTypeId from vQuestionType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQuestionType where {1} and QuestionTypeId not in (Select top {2} QuestionTypeId from vQuestionType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQuestionType where {1} and QuestionTypeId not in (Select top {3} QuestionTypeId from vQuestionType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvQuestionTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvQuestionTypeDA:GetObjLst)", objException.Message));
}
List<clsvQuestionTypeEN> arrObjLst = new List<clsvQuestionTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionTypeDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionTypeEN objvQuestionTypeEN = new clsvQuestionTypeEN();
try
{
objvQuestionTypeEN.QuestionTypeId = objRow[convQuestionType.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionTypeEN.QuestionTypeName = objRow[convQuestionType.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionType.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionTypeEN.DefaAnswerModeId = objRow[convQuestionType.DefaAnswerModeId] == DBNull.Value ? null : objRow[convQuestionType.DefaAnswerModeId].ToString().Trim(); //默认答案模式Id
objvQuestionTypeEN.AnswerModeName = objRow[convQuestionType.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionType.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionTypeEN.DefaAnswerTypeId = objRow[convQuestionType.DefaAnswerTypeId] == DBNull.Value ? null : objRow[convQuestionType.DefaAnswerTypeId].ToString().Trim(); //默认答案类型Id
objvQuestionTypeEN.AnswerTypeName = objRow[convQuestionType.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionType.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionTypeEN.OrderNum = objRow[convQuestionType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionType.OrderNum].ToString().Trim()); //序号
objvQuestionTypeEN.IsUse = TransNullToBool(objRow[convQuestionType.IsUse].ToString().Trim()); //是否使用
objvQuestionTypeEN.UpdDate = objRow[convQuestionType.UpdDate].ToString().Trim(); //修改日期
objvQuestionTypeEN.UpdUser = objRow[convQuestionType.UpdUser].ToString().Trim(); //修改人
objvQuestionTypeEN.Memo = objRow[convQuestionType.Memo] == DBNull.Value ? null : objRow[convQuestionType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQuestionTypeDA: GetObjLst)", objException.Message));
}
objvQuestionTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQuestionTypeEN);
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
public List<clsvQuestionTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvQuestionTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clsvQuestionTypeEN> arrObjLst = new List<clsvQuestionTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionTypeEN objvQuestionTypeEN = new clsvQuestionTypeEN();
try
{
objvQuestionTypeEN.QuestionTypeId = objRow[convQuestionType.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionTypeEN.QuestionTypeName = objRow[convQuestionType.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionType.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionTypeEN.DefaAnswerModeId = objRow[convQuestionType.DefaAnswerModeId] == DBNull.Value ? null : objRow[convQuestionType.DefaAnswerModeId].ToString().Trim(); //默认答案模式Id
objvQuestionTypeEN.AnswerModeName = objRow[convQuestionType.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionType.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionTypeEN.DefaAnswerTypeId = objRow[convQuestionType.DefaAnswerTypeId] == DBNull.Value ? null : objRow[convQuestionType.DefaAnswerTypeId].ToString().Trim(); //默认答案类型Id
objvQuestionTypeEN.AnswerTypeName = objRow[convQuestionType.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionType.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionTypeEN.OrderNum = objRow[convQuestionType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionType.OrderNum].ToString().Trim()); //序号
objvQuestionTypeEN.IsUse = TransNullToBool(objRow[convQuestionType.IsUse].ToString().Trim()); //是否使用
objvQuestionTypeEN.UpdDate = objRow[convQuestionType.UpdDate].ToString().Trim(); //修改日期
objvQuestionTypeEN.UpdUser = objRow[convQuestionType.UpdUser].ToString().Trim(); //修改人
objvQuestionTypeEN.Memo = objRow[convQuestionType.Memo] == DBNull.Value ? null : objRow[convQuestionType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQuestionTypeDA: GetObjLst)", objException.Message));
}
objvQuestionTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQuestionTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvQuestionTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQuestionType(ref clsvQuestionTypeEN objvQuestionTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionTypeDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionType where QuestionTypeId = " + "'"+ objvQuestionTypeEN.QuestionTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvQuestionTypeEN.QuestionTypeId = objDT.Rows[0][convQuestionType.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvQuestionTypeEN.QuestionTypeName = objDT.Rows[0][convQuestionType.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionTypeEN.DefaAnswerModeId = objDT.Rows[0][convQuestionType.DefaAnswerModeId].ToString().Trim(); //默认答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objvQuestionTypeEN.AnswerModeName = objDT.Rows[0][convQuestionType.AnswerModeName].ToString().Trim(); //答案模式名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvQuestionTypeEN.DefaAnswerTypeId = objDT.Rows[0][convQuestionType.DefaAnswerTypeId].ToString().Trim(); //默认答案类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvQuestionTypeEN.AnswerTypeName = objDT.Rows[0][convQuestionType.AnswerTypeName].ToString().Trim(); //答案类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvQuestionTypeEN.OrderNum = TransNullToInt(objDT.Rows[0][convQuestionType.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionTypeEN.IsUse = TransNullToBool(objDT.Rows[0][convQuestionType.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionTypeEN.UpdDate = objDT.Rows[0][convQuestionType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionTypeEN.UpdUser = objDT.Rows[0][convQuestionType.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionTypeEN.Memo = objDT.Rows[0][convQuestionType.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvQuestionTypeDA: GetvQuestionType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strQuestionTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clsvQuestionTypeEN GetObjByQuestionTypeId(string strQuestionTypeId)
{
CheckPrimaryKey(strQuestionTypeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionTypeDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionType where QuestionTypeId = " + "'"+ strQuestionTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvQuestionTypeEN objvQuestionTypeEN = new clsvQuestionTypeEN();
try
{
 objvQuestionTypeEN.QuestionTypeId = objRow[convQuestionType.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvQuestionTypeEN.QuestionTypeName = objRow[convQuestionType.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionType.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionTypeEN.DefaAnswerModeId = objRow[convQuestionType.DefaAnswerModeId] == DBNull.Value ? null : objRow[convQuestionType.DefaAnswerModeId].ToString().Trim(); //默认答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objvQuestionTypeEN.AnswerModeName = objRow[convQuestionType.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionType.AnswerModeName].ToString().Trim(); //答案模式名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvQuestionTypeEN.DefaAnswerTypeId = objRow[convQuestionType.DefaAnswerTypeId] == DBNull.Value ? null : objRow[convQuestionType.DefaAnswerTypeId].ToString().Trim(); //默认答案类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvQuestionTypeEN.AnswerTypeName = objRow[convQuestionType.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionType.AnswerTypeName].ToString().Trim(); //答案类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvQuestionTypeEN.OrderNum = objRow[convQuestionType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionType.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convQuestionType.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionTypeEN.UpdDate = objRow[convQuestionType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionTypeEN.UpdUser = objRow[convQuestionType.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionTypeEN.Memo = objRow[convQuestionType.Memo] == DBNull.Value ? null : objRow[convQuestionType.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvQuestionTypeDA: GetObjByQuestionTypeId)", objException.Message));
}
return objvQuestionTypeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQuestionTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvQuestionTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionTypeDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvQuestionTypeEN objvQuestionTypeEN = new clsvQuestionTypeEN()
{
QuestionTypeId = objRow[convQuestionType.QuestionTypeId].ToString().Trim(), //题目类型Id
QuestionTypeName = objRow[convQuestionType.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionType.QuestionTypeName].ToString().Trim(), //题目类型名
DefaAnswerModeId = objRow[convQuestionType.DefaAnswerModeId] == DBNull.Value ? null : objRow[convQuestionType.DefaAnswerModeId].ToString().Trim(), //默认答案模式Id
AnswerModeName = objRow[convQuestionType.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionType.AnswerModeName].ToString().Trim(), //答案模式名称
DefaAnswerTypeId = objRow[convQuestionType.DefaAnswerTypeId] == DBNull.Value ? null : objRow[convQuestionType.DefaAnswerTypeId].ToString().Trim(), //默认答案类型Id
AnswerTypeName = objRow[convQuestionType.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionType.AnswerTypeName].ToString().Trim(), //答案类型名
OrderNum = objRow[convQuestionType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionType.OrderNum].ToString().Trim()), //序号
IsUse = TransNullToBool(objRow[convQuestionType.IsUse].ToString().Trim()), //是否使用
UpdDate = objRow[convQuestionType.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convQuestionType.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convQuestionType.Memo] == DBNull.Value ? null : objRow[convQuestionType.Memo].ToString().Trim() //备注
};
objvQuestionTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQuestionTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvQuestionTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvQuestionTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQuestionTypeEN objvQuestionTypeEN = new clsvQuestionTypeEN();
try
{
objvQuestionTypeEN.QuestionTypeId = objRow[convQuestionType.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionTypeEN.QuestionTypeName = objRow[convQuestionType.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionType.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionTypeEN.DefaAnswerModeId = objRow[convQuestionType.DefaAnswerModeId] == DBNull.Value ? null : objRow[convQuestionType.DefaAnswerModeId].ToString().Trim(); //默认答案模式Id
objvQuestionTypeEN.AnswerModeName = objRow[convQuestionType.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionType.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionTypeEN.DefaAnswerTypeId = objRow[convQuestionType.DefaAnswerTypeId] == DBNull.Value ? null : objRow[convQuestionType.DefaAnswerTypeId].ToString().Trim(); //默认答案类型Id
objvQuestionTypeEN.AnswerTypeName = objRow[convQuestionType.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionType.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionTypeEN.OrderNum = objRow[convQuestionType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionType.OrderNum].ToString().Trim()); //序号
objvQuestionTypeEN.IsUse = TransNullToBool(objRow[convQuestionType.IsUse].ToString().Trim()); //是否使用
objvQuestionTypeEN.UpdDate = objRow[convQuestionType.UpdDate].ToString().Trim(); //修改日期
objvQuestionTypeEN.UpdUser = objRow[convQuestionType.UpdUser].ToString().Trim(); //修改人
objvQuestionTypeEN.Memo = objRow[convQuestionType.Memo] == DBNull.Value ? null : objRow[convQuestionType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvQuestionTypeDA: GetObjByDataRowvQuestionType)", objException.Message));
}
objvQuestionTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQuestionTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvQuestionTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQuestionTypeEN objvQuestionTypeEN = new clsvQuestionTypeEN();
try
{
objvQuestionTypeEN.QuestionTypeId = objRow[convQuestionType.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionTypeEN.QuestionTypeName = objRow[convQuestionType.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionType.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionTypeEN.DefaAnswerModeId = objRow[convQuestionType.DefaAnswerModeId] == DBNull.Value ? null : objRow[convQuestionType.DefaAnswerModeId].ToString().Trim(); //默认答案模式Id
objvQuestionTypeEN.AnswerModeName = objRow[convQuestionType.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionType.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionTypeEN.DefaAnswerTypeId = objRow[convQuestionType.DefaAnswerTypeId] == DBNull.Value ? null : objRow[convQuestionType.DefaAnswerTypeId].ToString().Trim(); //默认答案类型Id
objvQuestionTypeEN.AnswerTypeName = objRow[convQuestionType.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionType.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionTypeEN.OrderNum = objRow[convQuestionType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionType.OrderNum].ToString().Trim()); //序号
objvQuestionTypeEN.IsUse = TransNullToBool(objRow[convQuestionType.IsUse].ToString().Trim()); //是否使用
objvQuestionTypeEN.UpdDate = objRow[convQuestionType.UpdDate].ToString().Trim(); //修改日期
objvQuestionTypeEN.UpdUser = objRow[convQuestionType.UpdUser].ToString().Trim(); //修改人
objvQuestionTypeEN.Memo = objRow[convQuestionType.Memo] == DBNull.Value ? null : objRow[convQuestionType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvQuestionTypeDA: GetObjByDataRow)", objException.Message));
}
objvQuestionTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQuestionTypeEN;
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
objSQL = clsvQuestionTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQuestionTypeEN._CurrTabName, convQuestionType.QuestionTypeId, 2, "");
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
objSQL = clsvQuestionTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQuestionTypeEN._CurrTabName, convQuestionType.QuestionTypeId, 2, strPrefix);
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
 objSQL = clsvQuestionTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select QuestionTypeId from vQuestionType where " + strCondition;
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
 objSQL = clsvQuestionTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select QuestionTypeId from vQuestionType where " + strCondition;
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
 /// <param name = "strQuestionTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strQuestionTypeId)
{
CheckPrimaryKey(strQuestionTypeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQuestionType", "QuestionTypeId = " + "'"+ strQuestionTypeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvQuestionTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQuestionType", strCondition))
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
objSQL = clsvQuestionTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vQuestionType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvQuestionTypeENS">源对象</param>
 /// <param name = "objvQuestionTypeENT">目标对象</param>
public void CopyTo(clsvQuestionTypeEN objvQuestionTypeENS, clsvQuestionTypeEN objvQuestionTypeENT)
{
objvQuestionTypeENT.QuestionTypeId = objvQuestionTypeENS.QuestionTypeId; //题目类型Id
objvQuestionTypeENT.QuestionTypeName = objvQuestionTypeENS.QuestionTypeName; //题目类型名
objvQuestionTypeENT.DefaAnswerModeId = objvQuestionTypeENS.DefaAnswerModeId; //默认答案模式Id
objvQuestionTypeENT.AnswerModeName = objvQuestionTypeENS.AnswerModeName; //答案模式名称
objvQuestionTypeENT.DefaAnswerTypeId = objvQuestionTypeENS.DefaAnswerTypeId; //默认答案类型Id
objvQuestionTypeENT.AnswerTypeName = objvQuestionTypeENS.AnswerTypeName; //答案类型名
objvQuestionTypeENT.OrderNum = objvQuestionTypeENS.OrderNum; //序号
objvQuestionTypeENT.IsUse = objvQuestionTypeENS.IsUse; //是否使用
objvQuestionTypeENT.UpdDate = objvQuestionTypeENS.UpdDate; //修改日期
objvQuestionTypeENT.UpdUser = objvQuestionTypeENS.UpdUser; //修改人
objvQuestionTypeENT.Memo = objvQuestionTypeENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvQuestionTypeEN objvQuestionTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvQuestionTypeEN.QuestionTypeId, 2, convQuestionType.QuestionTypeId);
clsCheckSql.CheckFieldLen(objvQuestionTypeEN.QuestionTypeName, 20, convQuestionType.QuestionTypeName);
clsCheckSql.CheckFieldLen(objvQuestionTypeEN.DefaAnswerModeId, 4, convQuestionType.DefaAnswerModeId);
clsCheckSql.CheckFieldLen(objvQuestionTypeEN.AnswerModeName, 30, convQuestionType.AnswerModeName);
clsCheckSql.CheckFieldLen(objvQuestionTypeEN.DefaAnswerTypeId, 2, convQuestionType.DefaAnswerTypeId);
clsCheckSql.CheckFieldLen(objvQuestionTypeEN.AnswerTypeName, 50, convQuestionType.AnswerTypeName);
clsCheckSql.CheckFieldLen(objvQuestionTypeEN.UpdDate, 20, convQuestionType.UpdDate);
clsCheckSql.CheckFieldLen(objvQuestionTypeEN.UpdUser, 20, convQuestionType.UpdUser);
clsCheckSql.CheckFieldLen(objvQuestionTypeEN.Memo, 1000, convQuestionType.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvQuestionTypeEN.QuestionTypeId, convQuestionType.QuestionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionTypeEN.QuestionTypeName, convQuestionType.QuestionTypeName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionTypeEN.DefaAnswerModeId, convQuestionType.DefaAnswerModeId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionTypeEN.AnswerModeName, convQuestionType.AnswerModeName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionTypeEN.DefaAnswerTypeId, convQuestionType.DefaAnswerTypeId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionTypeEN.AnswerTypeName, convQuestionType.AnswerTypeName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionTypeEN.UpdDate, convQuestionType.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvQuestionTypeEN.UpdUser, convQuestionType.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvQuestionTypeEN.Memo, convQuestionType.Memo);
//检查外键字段长度
 objvQuestionTypeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetQuestionTypeId()
{
//获取某学院所有专业信息
string strSQL = "select QuestionTypeId, QuestionTypeName from vQuestionType ";
 clsSpecSQLforSql mySql = clsvQuestionTypeDA.GetSpecSQLObj();
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
 objSQL = clsvQuestionTypeDA.GetSpecSQLObj();
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
 objSQL = clsvQuestionTypeDA.GetSpecSQLObj();
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
 objSQL = clsvQuestionTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQuestionTypeEN._CurrTabName);
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
 objSQL = clsvQuestionTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQuestionTypeEN._CurrTabName, strCondition);
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
 objSQL = clsvQuestionTypeDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}