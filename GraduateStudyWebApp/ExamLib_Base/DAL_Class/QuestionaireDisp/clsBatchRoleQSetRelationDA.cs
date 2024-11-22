
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsBatchRoleQSetRelationDA
 表名:BatchRoleQSetRelation(01120005)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:18:17
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷呈现(QuestionaireDisp)
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
 /// 批次角色问卷集关系(BatchRoleQSetRelation)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsBatchRoleQSetRelationDA : clsCommBase4DA
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
 return clsBatchRoleQSetRelationEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsBatchRoleQSetRelationEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsBatchRoleQSetRelationEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsBatchRoleQSetRelationEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsBatchRoleQSetRelationEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsBatchRoleQSetRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
strSQL = "Select * from BatchRoleQSetRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_BatchRoleQSetRelation(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsBatchRoleQSetRelationDA: GetDataTable_BatchRoleQSetRelation)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
strSQL = "Select * from BatchRoleQSetRelation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsBatchRoleQSetRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsBatchRoleQSetRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
strSQL = "Select * from BatchRoleQSetRelation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsBatchRoleQSetRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsBatchRoleQSetRelationDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from BatchRoleQSetRelation where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from BatchRoleQSetRelation where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsBatchRoleQSetRelationDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from BatchRoleQSetRelation where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsBatchRoleQSetRelationDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} BatchRoleQSetRelation.* from BatchRoleQSetRelation Left Join {1} on {2} where {3} and BatchRoleQSetRelation.mId not in (Select top {5} BatchRoleQSetRelation.mId from BatchRoleQSetRelation Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from BatchRoleQSetRelation where {1} and mId not in (Select top {2} mId from BatchRoleQSetRelation where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from BatchRoleQSetRelation where {1} and mId not in (Select top {3} mId from BatchRoleQSetRelation where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsBatchRoleQSetRelationDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} BatchRoleQSetRelation.* from BatchRoleQSetRelation Left Join {1} on {2} where {3} and BatchRoleQSetRelation.mId not in (Select top {5} BatchRoleQSetRelation.mId from BatchRoleQSetRelation Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from BatchRoleQSetRelation where {1} and mId not in (Select top {2} mId from BatchRoleQSetRelation where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from BatchRoleQSetRelation where {1} and mId not in (Select top {3} mId from BatchRoleQSetRelation where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsBatchRoleQSetRelationEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsBatchRoleQSetRelationDA:GetObjLst)", objException.Message));
}
List<clsBatchRoleQSetRelationEN> arrObjLst = new List<clsBatchRoleQSetRelationEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
strSQL = "Select * from BatchRoleQSetRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsBatchRoleQSetRelationEN objBatchRoleQSetRelationEN = new clsBatchRoleQSetRelationEN();
try
{
objBatchRoleQSetRelationEN.mId = TransNullToInt(objRow[conBatchRoleQSetRelation.mId].ToString().Trim()); //mId
objBatchRoleQSetRelationEN.BatchId = objRow[conBatchRoleQSetRelation.BatchId].ToString().Trim(); //批次ID
objBatchRoleQSetRelationEN.RoleId = objRow[conBatchRoleQSetRelation.RoleId].ToString().Trim(); //角色Id
objBatchRoleQSetRelationEN.QuestionnaireSetId = objRow[conBatchRoleQSetRelation.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objBatchRoleQSetRelationEN.Memo = objRow[conBatchRoleQSetRelation.Memo] == DBNull.Value ? null : objRow[conBatchRoleQSetRelation.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsBatchRoleQSetRelationDA: GetObjLst)", objException.Message));
}
objBatchRoleQSetRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objBatchRoleQSetRelationEN);
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
public List<clsBatchRoleQSetRelationEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsBatchRoleQSetRelationDA:GetObjLstByTabName)", objException.Message));
}
List<clsBatchRoleQSetRelationEN> arrObjLst = new List<clsBatchRoleQSetRelationEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsBatchRoleQSetRelationEN objBatchRoleQSetRelationEN = new clsBatchRoleQSetRelationEN();
try
{
objBatchRoleQSetRelationEN.mId = TransNullToInt(objRow[conBatchRoleQSetRelation.mId].ToString().Trim()); //mId
objBatchRoleQSetRelationEN.BatchId = objRow[conBatchRoleQSetRelation.BatchId].ToString().Trim(); //批次ID
objBatchRoleQSetRelationEN.RoleId = objRow[conBatchRoleQSetRelation.RoleId].ToString().Trim(); //角色Id
objBatchRoleQSetRelationEN.QuestionnaireSetId = objRow[conBatchRoleQSetRelation.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objBatchRoleQSetRelationEN.Memo = objRow[conBatchRoleQSetRelation.Memo] == DBNull.Value ? null : objRow[conBatchRoleQSetRelation.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsBatchRoleQSetRelationDA: GetObjLst)", objException.Message));
}
objBatchRoleQSetRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objBatchRoleQSetRelationEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objBatchRoleQSetRelationEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetBatchRoleQSetRelation(ref clsBatchRoleQSetRelationEN objBatchRoleQSetRelationEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
strSQL = "Select * from BatchRoleQSetRelation where mId = " + ""+ objBatchRoleQSetRelationEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objBatchRoleQSetRelationEN.mId = TransNullToInt(objDT.Rows[0][conBatchRoleQSetRelation.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objBatchRoleQSetRelationEN.BatchId = objDT.Rows[0][conBatchRoleQSetRelation.BatchId].ToString().Trim(); //批次ID(字段类型:char,字段长度:4,是否可空:True)
 objBatchRoleQSetRelationEN.RoleId = objDT.Rows[0][conBatchRoleQSetRelation.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objBatchRoleQSetRelationEN.QuestionnaireSetId = objDT.Rows[0][conBatchRoleQSetRelation.QuestionnaireSetId].ToString().Trim(); //问卷集ID(字段类型:char,字段长度:4,是否可空:True)
 objBatchRoleQSetRelationEN.Memo = objDT.Rows[0][conBatchRoleQSetRelation.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsBatchRoleQSetRelationDA: GetBatchRoleQSetRelation)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsBatchRoleQSetRelationEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
strSQL = "Select * from BatchRoleQSetRelation where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsBatchRoleQSetRelationEN objBatchRoleQSetRelationEN = new clsBatchRoleQSetRelationEN();
try
{
 objBatchRoleQSetRelationEN.mId = Int32.Parse(objRow[conBatchRoleQSetRelation.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objBatchRoleQSetRelationEN.BatchId = objRow[conBatchRoleQSetRelation.BatchId].ToString().Trim(); //批次ID(字段类型:char,字段长度:4,是否可空:True)
 objBatchRoleQSetRelationEN.RoleId = objRow[conBatchRoleQSetRelation.RoleId].ToString().Trim(); //角色Id(字段类型:char,字段长度:8,是否可空:True)
 objBatchRoleQSetRelationEN.QuestionnaireSetId = objRow[conBatchRoleQSetRelation.QuestionnaireSetId].ToString().Trim(); //问卷集ID(字段类型:char,字段长度:4,是否可空:True)
 objBatchRoleQSetRelationEN.Memo = objRow[conBatchRoleQSetRelation.Memo] == DBNull.Value ? null : objRow[conBatchRoleQSetRelation.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsBatchRoleQSetRelationDA: GetObjBymId)", objException.Message));
}
return objBatchRoleQSetRelationEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsBatchRoleQSetRelationEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsBatchRoleQSetRelationDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
strSQL = "Select * from BatchRoleQSetRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsBatchRoleQSetRelationEN objBatchRoleQSetRelationEN = new clsBatchRoleQSetRelationEN()
{
mId = TransNullToInt(objRow[conBatchRoleQSetRelation.mId].ToString().Trim()), //mId
BatchId = objRow[conBatchRoleQSetRelation.BatchId].ToString().Trim(), //批次ID
RoleId = objRow[conBatchRoleQSetRelation.RoleId].ToString().Trim(), //角色Id
QuestionnaireSetId = objRow[conBatchRoleQSetRelation.QuestionnaireSetId].ToString().Trim(), //问卷集ID
Memo = objRow[conBatchRoleQSetRelation.Memo] == DBNull.Value ? null : objRow[conBatchRoleQSetRelation.Memo].ToString().Trim() //备注
};
objBatchRoleQSetRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objBatchRoleQSetRelationEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsBatchRoleQSetRelationDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsBatchRoleQSetRelationEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsBatchRoleQSetRelationEN objBatchRoleQSetRelationEN = new clsBatchRoleQSetRelationEN();
try
{
objBatchRoleQSetRelationEN.mId = TransNullToInt(objRow[conBatchRoleQSetRelation.mId].ToString().Trim()); //mId
objBatchRoleQSetRelationEN.BatchId = objRow[conBatchRoleQSetRelation.BatchId].ToString().Trim(); //批次ID
objBatchRoleQSetRelationEN.RoleId = objRow[conBatchRoleQSetRelation.RoleId].ToString().Trim(); //角色Id
objBatchRoleQSetRelationEN.QuestionnaireSetId = objRow[conBatchRoleQSetRelation.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objBatchRoleQSetRelationEN.Memo = objRow[conBatchRoleQSetRelation.Memo] == DBNull.Value ? null : objRow[conBatchRoleQSetRelation.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsBatchRoleQSetRelationDA: GetObjByDataRowBatchRoleQSetRelation)", objException.Message));
}
objBatchRoleQSetRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objBatchRoleQSetRelationEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsBatchRoleQSetRelationEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsBatchRoleQSetRelationEN objBatchRoleQSetRelationEN = new clsBatchRoleQSetRelationEN();
try
{
objBatchRoleQSetRelationEN.mId = TransNullToInt(objRow[conBatchRoleQSetRelation.mId].ToString().Trim()); //mId
objBatchRoleQSetRelationEN.BatchId = objRow[conBatchRoleQSetRelation.BatchId].ToString().Trim(); //批次ID
objBatchRoleQSetRelationEN.RoleId = objRow[conBatchRoleQSetRelation.RoleId].ToString().Trim(); //角色Id
objBatchRoleQSetRelationEN.QuestionnaireSetId = objRow[conBatchRoleQSetRelation.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objBatchRoleQSetRelationEN.Memo = objRow[conBatchRoleQSetRelation.Memo] == DBNull.Value ? null : objRow[conBatchRoleQSetRelation.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsBatchRoleQSetRelationDA: GetObjByDataRow)", objException.Message));
}
objBatchRoleQSetRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objBatchRoleQSetRelationEN;
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
objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsBatchRoleQSetRelationEN._CurrTabName, conBatchRoleQSetRelation.mId, 8, "");
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
objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsBatchRoleQSetRelationEN._CurrTabName, conBatchRoleQSetRelation.mId, 8, strPrefix);
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
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from BatchRoleQSetRelation where " + strCondition;
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
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from BatchRoleQSetRelation where " + strCondition;
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("BatchRoleQSetRelation", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsBatchRoleQSetRelationDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("BatchRoleQSetRelation", strCondition))
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
objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("BatchRoleQSetRelation");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsBatchRoleQSetRelationEN objBatchRoleQSetRelationEN)
 {
 if (objBatchRoleQSetRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objBatchRoleQSetRelationEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
strSQL = "Select * from BatchRoleQSetRelation where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "BatchRoleQSetRelation");
objRow = objDS.Tables["BatchRoleQSetRelation"].NewRow();
objRow[conBatchRoleQSetRelation.BatchId] = objBatchRoleQSetRelationEN.BatchId; //批次ID
objRow[conBatchRoleQSetRelation.RoleId] = objBatchRoleQSetRelationEN.RoleId; //角色Id
objRow[conBatchRoleQSetRelation.QuestionnaireSetId] = objBatchRoleQSetRelationEN.QuestionnaireSetId; //问卷集ID
 if (objBatchRoleQSetRelationEN.Memo !=  "")
 {
objRow[conBatchRoleQSetRelation.Memo] = objBatchRoleQSetRelationEN.Memo; //备注
 }
objDS.Tables[clsBatchRoleQSetRelationEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsBatchRoleQSetRelationEN._CurrTabName);
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
 /// <param name = "objBatchRoleQSetRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsBatchRoleQSetRelationEN objBatchRoleQSetRelationEN)
{
 if (objBatchRoleQSetRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objBatchRoleQSetRelationEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objBatchRoleQSetRelationEN.BatchId !=  null)
 {
 arrFieldListForInsert.Add(conBatchRoleQSetRelation.BatchId);
 var strBatchId = objBatchRoleQSetRelationEN.BatchId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBatchId + "'");
 }
 
 if (objBatchRoleQSetRelationEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conBatchRoleQSetRelation.RoleId);
 var strRoleId = objBatchRoleQSetRelationEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 if (objBatchRoleQSetRelationEN.QuestionnaireSetId !=  null)
 {
 arrFieldListForInsert.Add(conBatchRoleQSetRelation.QuestionnaireSetId);
 var strQuestionnaireSetId = objBatchRoleQSetRelationEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionnaireSetId + "'");
 }
 
 if (objBatchRoleQSetRelationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conBatchRoleQSetRelation.Memo);
 var strMemo = objBatchRoleQSetRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into BatchRoleQSetRelation");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objBatchRoleQSetRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsBatchRoleQSetRelationEN objBatchRoleQSetRelationEN)
{
 if (objBatchRoleQSetRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objBatchRoleQSetRelationEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objBatchRoleQSetRelationEN.BatchId !=  null)
 {
 arrFieldListForInsert.Add(conBatchRoleQSetRelation.BatchId);
 var strBatchId = objBatchRoleQSetRelationEN.BatchId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBatchId + "'");
 }
 
 if (objBatchRoleQSetRelationEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conBatchRoleQSetRelation.RoleId);
 var strRoleId = objBatchRoleQSetRelationEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 if (objBatchRoleQSetRelationEN.QuestionnaireSetId !=  null)
 {
 arrFieldListForInsert.Add(conBatchRoleQSetRelation.QuestionnaireSetId);
 var strQuestionnaireSetId = objBatchRoleQSetRelationEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionnaireSetId + "'");
 }
 
 if (objBatchRoleQSetRelationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conBatchRoleQSetRelation.Memo);
 var strMemo = objBatchRoleQSetRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into BatchRoleQSetRelation");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objBatchRoleQSetRelationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsBatchRoleQSetRelationEN objBatchRoleQSetRelationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objBatchRoleQSetRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objBatchRoleQSetRelationEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objBatchRoleQSetRelationEN.BatchId !=  null)
 {
 arrFieldListForInsert.Add(conBatchRoleQSetRelation.BatchId);
 var strBatchId = objBatchRoleQSetRelationEN.BatchId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBatchId + "'");
 }
 
 if (objBatchRoleQSetRelationEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conBatchRoleQSetRelation.RoleId);
 var strRoleId = objBatchRoleQSetRelationEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 if (objBatchRoleQSetRelationEN.QuestionnaireSetId !=  null)
 {
 arrFieldListForInsert.Add(conBatchRoleQSetRelation.QuestionnaireSetId);
 var strQuestionnaireSetId = objBatchRoleQSetRelationEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionnaireSetId + "'");
 }
 
 if (objBatchRoleQSetRelationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conBatchRoleQSetRelation.Memo);
 var strMemo = objBatchRoleQSetRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into BatchRoleQSetRelation");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objBatchRoleQSetRelationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsBatchRoleQSetRelationEN objBatchRoleQSetRelationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objBatchRoleQSetRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objBatchRoleQSetRelationEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objBatchRoleQSetRelationEN.BatchId !=  null)
 {
 arrFieldListForInsert.Add(conBatchRoleQSetRelation.BatchId);
 var strBatchId = objBatchRoleQSetRelationEN.BatchId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBatchId + "'");
 }
 
 if (objBatchRoleQSetRelationEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conBatchRoleQSetRelation.RoleId);
 var strRoleId = objBatchRoleQSetRelationEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 if (objBatchRoleQSetRelationEN.QuestionnaireSetId !=  null)
 {
 arrFieldListForInsert.Add(conBatchRoleQSetRelation.QuestionnaireSetId);
 var strQuestionnaireSetId = objBatchRoleQSetRelationEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionnaireSetId + "'");
 }
 
 if (objBatchRoleQSetRelationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conBatchRoleQSetRelation.Memo);
 var strMemo = objBatchRoleQSetRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into BatchRoleQSetRelation");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewBatchRoleQSetRelations(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
strSQL = "Select * from BatchRoleQSetRelation where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "BatchRoleQSetRelation");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsBatchRoleQSetRelationEN._CurrTabName ].NewRow();
objRow[conBatchRoleQSetRelation.BatchId] = oRow[conBatchRoleQSetRelation.BatchId].ToString().Trim(); //批次ID
objRow[conBatchRoleQSetRelation.RoleId] = oRow[conBatchRoleQSetRelation.RoleId].ToString().Trim(); //角色Id
objRow[conBatchRoleQSetRelation.QuestionnaireSetId] = oRow[conBatchRoleQSetRelation.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objRow[conBatchRoleQSetRelation.Memo] = oRow[conBatchRoleQSetRelation.Memo].ToString().Trim(); //备注
 objDS.Tables[clsBatchRoleQSetRelationEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsBatchRoleQSetRelationEN._CurrTabName);
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
 /// <param name = "objBatchRoleQSetRelationEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsBatchRoleQSetRelationEN objBatchRoleQSetRelationEN)
{
 if (objBatchRoleQSetRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objBatchRoleQSetRelationEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
strSQL = "Select * from BatchRoleQSetRelation where mId = " + ""+ objBatchRoleQSetRelationEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsBatchRoleQSetRelationEN._CurrTabName);
if (objDS.Tables[clsBatchRoleQSetRelationEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objBatchRoleQSetRelationEN.mId+"");
return false;
}
objRow = objDS.Tables[clsBatchRoleQSetRelationEN._CurrTabName].Rows[0];
 if (objBatchRoleQSetRelationEN.IsUpdated(conBatchRoleQSetRelation.BatchId))
 {
objRow[conBatchRoleQSetRelation.BatchId] = objBatchRoleQSetRelationEN.BatchId; //批次ID
 }
 if (objBatchRoleQSetRelationEN.IsUpdated(conBatchRoleQSetRelation.RoleId))
 {
objRow[conBatchRoleQSetRelation.RoleId] = objBatchRoleQSetRelationEN.RoleId; //角色Id
 }
 if (objBatchRoleQSetRelationEN.IsUpdated(conBatchRoleQSetRelation.QuestionnaireSetId))
 {
objRow[conBatchRoleQSetRelation.QuestionnaireSetId] = objBatchRoleQSetRelationEN.QuestionnaireSetId; //问卷集ID
 }
 if (objBatchRoleQSetRelationEN.IsUpdated(conBatchRoleQSetRelation.Memo))
 {
objRow[conBatchRoleQSetRelation.Memo] = objBatchRoleQSetRelationEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsBatchRoleQSetRelationEN._CurrTabName);
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
 /// <param name = "objBatchRoleQSetRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsBatchRoleQSetRelationEN objBatchRoleQSetRelationEN)
{
 if (objBatchRoleQSetRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objBatchRoleQSetRelationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update BatchRoleQSetRelation Set ");
 
 if (objBatchRoleQSetRelationEN.IsUpdated(conBatchRoleQSetRelation.BatchId))
 {
 if (objBatchRoleQSetRelationEN.BatchId !=  null)
 {
 var strBatchId = objBatchRoleQSetRelationEN.BatchId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strBatchId, conBatchRoleQSetRelation.BatchId); //批次ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBatchRoleQSetRelation.BatchId); //批次ID
 }
 }
 
 if (objBatchRoleQSetRelationEN.IsUpdated(conBatchRoleQSetRelation.RoleId))
 {
 if (objBatchRoleQSetRelationEN.RoleId !=  null)
 {
 var strRoleId = objBatchRoleQSetRelationEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRoleId, conBatchRoleQSetRelation.RoleId); //角色Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBatchRoleQSetRelation.RoleId); //角色Id
 }
 }
 
 if (objBatchRoleQSetRelationEN.IsUpdated(conBatchRoleQSetRelation.QuestionnaireSetId))
 {
 if (objBatchRoleQSetRelationEN.QuestionnaireSetId !=  null)
 {
 var strQuestionnaireSetId = objBatchRoleQSetRelationEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionnaireSetId, conBatchRoleQSetRelation.QuestionnaireSetId); //问卷集ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBatchRoleQSetRelation.QuestionnaireSetId); //问卷集ID
 }
 }
 
 if (objBatchRoleQSetRelationEN.IsUpdated(conBatchRoleQSetRelation.Memo))
 {
 if (objBatchRoleQSetRelationEN.Memo !=  null)
 {
 var strMemo = objBatchRoleQSetRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conBatchRoleQSetRelation.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBatchRoleQSetRelation.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objBatchRoleQSetRelationEN.mId); 
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
 /// <param name = "objBatchRoleQSetRelationEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsBatchRoleQSetRelationEN objBatchRoleQSetRelationEN, string strCondition)
{
 if (objBatchRoleQSetRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objBatchRoleQSetRelationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update BatchRoleQSetRelation Set ");
 
 if (objBatchRoleQSetRelationEN.IsUpdated(conBatchRoleQSetRelation.BatchId))
 {
 if (objBatchRoleQSetRelationEN.BatchId !=  null)
 {
 var strBatchId = objBatchRoleQSetRelationEN.BatchId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" BatchId = '{0}',", strBatchId); //批次ID
 }
 else
 {
 sbSQL.Append(" BatchId = null,"); //批次ID
 }
 }
 
 if (objBatchRoleQSetRelationEN.IsUpdated(conBatchRoleQSetRelation.RoleId))
 {
 if (objBatchRoleQSetRelationEN.RoleId !=  null)
 {
 var strRoleId = objBatchRoleQSetRelationEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RoleId = '{0}',", strRoleId); //角色Id
 }
 else
 {
 sbSQL.Append(" RoleId = null,"); //角色Id
 }
 }
 
 if (objBatchRoleQSetRelationEN.IsUpdated(conBatchRoleQSetRelation.QuestionnaireSetId))
 {
 if (objBatchRoleQSetRelationEN.QuestionnaireSetId !=  null)
 {
 var strQuestionnaireSetId = objBatchRoleQSetRelationEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionnaireSetId = '{0}',", strQuestionnaireSetId); //问卷集ID
 }
 else
 {
 sbSQL.Append(" QuestionnaireSetId = null,"); //问卷集ID
 }
 }
 
 if (objBatchRoleQSetRelationEN.IsUpdated(conBatchRoleQSetRelation.Memo))
 {
 if (objBatchRoleQSetRelationEN.Memo !=  null)
 {
 var strMemo = objBatchRoleQSetRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objBatchRoleQSetRelationEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsBatchRoleQSetRelationEN objBatchRoleQSetRelationEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objBatchRoleQSetRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objBatchRoleQSetRelationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update BatchRoleQSetRelation Set ");
 
 if (objBatchRoleQSetRelationEN.IsUpdated(conBatchRoleQSetRelation.BatchId))
 {
 if (objBatchRoleQSetRelationEN.BatchId !=  null)
 {
 var strBatchId = objBatchRoleQSetRelationEN.BatchId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" BatchId = '{0}',", strBatchId); //批次ID
 }
 else
 {
 sbSQL.Append(" BatchId = null,"); //批次ID
 }
 }
 
 if (objBatchRoleQSetRelationEN.IsUpdated(conBatchRoleQSetRelation.RoleId))
 {
 if (objBatchRoleQSetRelationEN.RoleId !=  null)
 {
 var strRoleId = objBatchRoleQSetRelationEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RoleId = '{0}',", strRoleId); //角色Id
 }
 else
 {
 sbSQL.Append(" RoleId = null,"); //角色Id
 }
 }
 
 if (objBatchRoleQSetRelationEN.IsUpdated(conBatchRoleQSetRelation.QuestionnaireSetId))
 {
 if (objBatchRoleQSetRelationEN.QuestionnaireSetId !=  null)
 {
 var strQuestionnaireSetId = objBatchRoleQSetRelationEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionnaireSetId = '{0}',", strQuestionnaireSetId); //问卷集ID
 }
 else
 {
 sbSQL.Append(" QuestionnaireSetId = null,"); //问卷集ID
 }
 }
 
 if (objBatchRoleQSetRelationEN.IsUpdated(conBatchRoleQSetRelation.Memo))
 {
 if (objBatchRoleQSetRelationEN.Memo !=  null)
 {
 var strMemo = objBatchRoleQSetRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objBatchRoleQSetRelationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsBatchRoleQSetRelationEN objBatchRoleQSetRelationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objBatchRoleQSetRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objBatchRoleQSetRelationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update BatchRoleQSetRelation Set ");
 
 if (objBatchRoleQSetRelationEN.IsUpdated(conBatchRoleQSetRelation.BatchId))
 {
 if (objBatchRoleQSetRelationEN.BatchId !=  null)
 {
 var strBatchId = objBatchRoleQSetRelationEN.BatchId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strBatchId, conBatchRoleQSetRelation.BatchId); //批次ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBatchRoleQSetRelation.BatchId); //批次ID
 }
 }
 
 if (objBatchRoleQSetRelationEN.IsUpdated(conBatchRoleQSetRelation.RoleId))
 {
 if (objBatchRoleQSetRelationEN.RoleId !=  null)
 {
 var strRoleId = objBatchRoleQSetRelationEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRoleId, conBatchRoleQSetRelation.RoleId); //角色Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBatchRoleQSetRelation.RoleId); //角色Id
 }
 }
 
 if (objBatchRoleQSetRelationEN.IsUpdated(conBatchRoleQSetRelation.QuestionnaireSetId))
 {
 if (objBatchRoleQSetRelationEN.QuestionnaireSetId !=  null)
 {
 var strQuestionnaireSetId = objBatchRoleQSetRelationEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionnaireSetId, conBatchRoleQSetRelation.QuestionnaireSetId); //问卷集ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBatchRoleQSetRelation.QuestionnaireSetId); //问卷集ID
 }
 }
 
 if (objBatchRoleQSetRelationEN.IsUpdated(conBatchRoleQSetRelation.Memo))
 {
 if (objBatchRoleQSetRelationEN.Memo !=  null)
 {
 var strMemo = objBatchRoleQSetRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conBatchRoleQSetRelation.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conBatchRoleQSetRelation.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objBatchRoleQSetRelationEN.mId); 
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngmId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("BatchRoleQSetRelation_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
//删除BatchRoleQSetRelation本表中与当前对象有关的记录
strSQL = strSQL + "Delete from BatchRoleQSetRelation where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelBatchRoleQSetRelation(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
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
//删除BatchRoleQSetRelation本表中与当前对象有关的记录
strSQL = strSQL + "Delete from BatchRoleQSetRelation where mId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngmId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
//删除BatchRoleQSetRelation本表中与当前对象有关的记录
strSQL = strSQL + "Delete from BatchRoleQSetRelation where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelBatchRoleQSetRelation(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsBatchRoleQSetRelationDA: DelBatchRoleQSetRelation)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from BatchRoleQSetRelation where " + strCondition ;
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
public bool DelBatchRoleQSetRelationWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsBatchRoleQSetRelationDA: DelBatchRoleQSetRelationWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from BatchRoleQSetRelation where " + strCondition ;
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
 /// <param name = "objBatchRoleQSetRelationENS">源对象</param>
 /// <param name = "objBatchRoleQSetRelationENT">目标对象</param>
public void CopyTo(clsBatchRoleQSetRelationEN objBatchRoleQSetRelationENS, clsBatchRoleQSetRelationEN objBatchRoleQSetRelationENT)
{
objBatchRoleQSetRelationENT.mId = objBatchRoleQSetRelationENS.mId; //mId
objBatchRoleQSetRelationENT.BatchId = objBatchRoleQSetRelationENS.BatchId; //批次ID
objBatchRoleQSetRelationENT.RoleId = objBatchRoleQSetRelationENS.RoleId; //角色Id
objBatchRoleQSetRelationENT.QuestionnaireSetId = objBatchRoleQSetRelationENS.QuestionnaireSetId; //问卷集ID
objBatchRoleQSetRelationENT.Memo = objBatchRoleQSetRelationENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsBatchRoleQSetRelationEN objBatchRoleQSetRelationEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objBatchRoleQSetRelationEN.BatchId, conBatchRoleQSetRelation.BatchId);
clsCheckSql.CheckFieldNotNull(objBatchRoleQSetRelationEN.RoleId, conBatchRoleQSetRelation.RoleId);
clsCheckSql.CheckFieldNotNull(objBatchRoleQSetRelationEN.QuestionnaireSetId, conBatchRoleQSetRelation.QuestionnaireSetId);
//检查字段长度
clsCheckSql.CheckFieldLen(objBatchRoleQSetRelationEN.BatchId, 4, conBatchRoleQSetRelation.BatchId);
clsCheckSql.CheckFieldLen(objBatchRoleQSetRelationEN.RoleId, 8, conBatchRoleQSetRelation.RoleId);
clsCheckSql.CheckFieldLen(objBatchRoleQSetRelationEN.QuestionnaireSetId, 4, conBatchRoleQSetRelation.QuestionnaireSetId);
clsCheckSql.CheckFieldLen(objBatchRoleQSetRelationEN.Memo, 1000, conBatchRoleQSetRelation.Memo);
//检查字段外键固定长度
 objBatchRoleQSetRelationEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsBatchRoleQSetRelationEN objBatchRoleQSetRelationEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objBatchRoleQSetRelationEN.BatchId, 4, conBatchRoleQSetRelation.BatchId);
clsCheckSql.CheckFieldLen(objBatchRoleQSetRelationEN.RoleId, 8, conBatchRoleQSetRelation.RoleId);
clsCheckSql.CheckFieldLen(objBatchRoleQSetRelationEN.QuestionnaireSetId, 4, conBatchRoleQSetRelation.QuestionnaireSetId);
clsCheckSql.CheckFieldLen(objBatchRoleQSetRelationEN.Memo, 1000, conBatchRoleQSetRelation.Memo);
//检查外键字段长度
 objBatchRoleQSetRelationEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsBatchRoleQSetRelationEN objBatchRoleQSetRelationEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objBatchRoleQSetRelationEN.BatchId, 4, conBatchRoleQSetRelation.BatchId);
clsCheckSql.CheckFieldLen(objBatchRoleQSetRelationEN.RoleId, 8, conBatchRoleQSetRelation.RoleId);
clsCheckSql.CheckFieldLen(objBatchRoleQSetRelationEN.QuestionnaireSetId, 4, conBatchRoleQSetRelation.QuestionnaireSetId);
clsCheckSql.CheckFieldLen(objBatchRoleQSetRelationEN.Memo, 1000, conBatchRoleQSetRelation.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objBatchRoleQSetRelationEN.BatchId, conBatchRoleQSetRelation.BatchId);
clsCheckSql.CheckSqlInjection4Field(objBatchRoleQSetRelationEN.RoleId, conBatchRoleQSetRelation.RoleId);
clsCheckSql.CheckSqlInjection4Field(objBatchRoleQSetRelationEN.QuestionnaireSetId, conBatchRoleQSetRelation.QuestionnaireSetId);
clsCheckSql.CheckSqlInjection4Field(objBatchRoleQSetRelationEN.Memo, conBatchRoleQSetRelation.Memo);
//检查外键字段长度
 objBatchRoleQSetRelationEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--BatchRoleQSetRelation(批次角色问卷集关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objBatchRoleQSetRelationEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsBatchRoleQSetRelationEN objBatchRoleQSetRelationEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and BatchId = '{0}'", objBatchRoleQSetRelationEN.BatchId);
 sbCondition.AppendFormat(" and QuestionnaireSetId = '{0}'", objBatchRoleQSetRelationEN.QuestionnaireSetId);
 sbCondition.AppendFormat(" and RoleId = '{0}'", objBatchRoleQSetRelationEN.RoleId);
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
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
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
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
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
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsBatchRoleQSetRelationEN._CurrTabName);
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
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsBatchRoleQSetRelationEN._CurrTabName, strCondition);
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
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
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
 objSQL = clsBatchRoleQSetRelationDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}