
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_ExamPaperTypeDA
 表名:cc_ExamPaperType(01120074)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:40
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
 /// 试卷类型(cc_ExamPaperType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clscc_ExamPaperTypeDA : clsCommBase4DA
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
 return clscc_ExamPaperTypeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clscc_ExamPaperTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_ExamPaperTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clscc_ExamPaperTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clscc_ExamPaperTypeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strExamPaperTypeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strExamPaperTypeId)
{
strExamPaperTypeId = strExamPaperTypeId.Replace("'", "''");
if (strExamPaperTypeId.Length > 2)
{
throw new Exception("(errid:Data000001)在表:cc_ExamPaperType中,检查关键字,长度不正确!(clscc_ExamPaperTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strExamPaperTypeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:cc_ExamPaperType中,关键字不能为空 或 null!(clscc_ExamPaperTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strExamPaperTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clscc_ExamPaperTypeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clscc_ExamPaperTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExamPaperType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_cc_ExamPaperType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clscc_ExamPaperTypeDA: GetDataTable_cc_ExamPaperType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExamPaperType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clscc_ExamPaperTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clscc_ExamPaperTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExamPaperType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clscc_ExamPaperTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clscc_ExamPaperTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_ExamPaperType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_ExamPaperType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clscc_ExamPaperTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from cc_ExamPaperType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clscc_ExamPaperTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_ExamPaperType.* from cc_ExamPaperType Left Join {1} on {2} where {3} and cc_ExamPaperType.ExamPaperTypeId not in (Select top {5} cc_ExamPaperType.ExamPaperTypeId from cc_ExamPaperType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_ExamPaperType where {1} and ExamPaperTypeId not in (Select top {2} ExamPaperTypeId from cc_ExamPaperType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_ExamPaperType where {1} and ExamPaperTypeId not in (Select top {3} ExamPaperTypeId from cc_ExamPaperType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clscc_ExamPaperTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_ExamPaperType.* from cc_ExamPaperType Left Join {1} on {2} where {3} and cc_ExamPaperType.ExamPaperTypeId not in (Select top {5} cc_ExamPaperType.ExamPaperTypeId from cc_ExamPaperType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_ExamPaperType where {1} and ExamPaperTypeId not in (Select top {2} ExamPaperTypeId from cc_ExamPaperType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_ExamPaperType where {1} and ExamPaperTypeId not in (Select top {3} ExamPaperTypeId from cc_ExamPaperType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clscc_ExamPaperTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clscc_ExamPaperTypeDA:GetObjLst)", objException.Message));
}
List<clscc_ExamPaperTypeEN> arrObjLst = new List<clscc_ExamPaperTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExamPaperType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperTypeEN objcc_ExamPaperTypeEN = new clscc_ExamPaperTypeEN();
try
{
objcc_ExamPaperTypeEN.ExamPaperTypeId = objRow[concc_ExamPaperType.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objcc_ExamPaperTypeEN.ExamPaperTypeName = objRow[concc_ExamPaperType.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objcc_ExamPaperTypeEN.Memo = objRow[concc_ExamPaperType.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_ExamPaperTypeDA: GetObjLst)", objException.Message));
}
objcc_ExamPaperTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_ExamPaperTypeEN);
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
public List<clscc_ExamPaperTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clscc_ExamPaperTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clscc_ExamPaperTypeEN> arrObjLst = new List<clscc_ExamPaperTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperTypeEN objcc_ExamPaperTypeEN = new clscc_ExamPaperTypeEN();
try
{
objcc_ExamPaperTypeEN.ExamPaperTypeId = objRow[concc_ExamPaperType.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objcc_ExamPaperTypeEN.ExamPaperTypeName = objRow[concc_ExamPaperType.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objcc_ExamPaperTypeEN.Memo = objRow[concc_ExamPaperType.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_ExamPaperTypeDA: GetObjLst)", objException.Message));
}
objcc_ExamPaperTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_ExamPaperTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objcc_ExamPaperTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getcc_ExamPaperType(ref clscc_ExamPaperTypeEN objcc_ExamPaperTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExamPaperType where ExamPaperTypeId = " + "'"+ objcc_ExamPaperTypeEN.ExamPaperTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objcc_ExamPaperTypeEN.ExamPaperTypeId = objDT.Rows[0][concc_ExamPaperType.ExamPaperTypeId].ToString().Trim(); //试卷类型Id(字段类型:char,字段长度:2,是否可空:False)
 objcc_ExamPaperTypeEN.ExamPaperTypeName = objDT.Rows[0][concc_ExamPaperType.ExamPaperTypeName].ToString().Trim(); //试卷类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objcc_ExamPaperTypeEN.Memo = objDT.Rows[0][concc_ExamPaperType.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clscc_ExamPaperTypeDA: Getcc_ExamPaperType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strExamPaperTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clscc_ExamPaperTypeEN GetObjByExamPaperTypeId(string strExamPaperTypeId)
{
CheckPrimaryKey(strExamPaperTypeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExamPaperType where ExamPaperTypeId = " + "'"+ strExamPaperTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clscc_ExamPaperTypeEN objcc_ExamPaperTypeEN = new clscc_ExamPaperTypeEN();
try
{
 objcc_ExamPaperTypeEN.ExamPaperTypeId = objRow[concc_ExamPaperType.ExamPaperTypeId].ToString().Trim(); //试卷类型Id(字段类型:char,字段长度:2,是否可空:False)
 objcc_ExamPaperTypeEN.ExamPaperTypeName = objRow[concc_ExamPaperType.ExamPaperTypeName].ToString().Trim(); //试卷类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objcc_ExamPaperTypeEN.Memo = objRow[concc_ExamPaperType.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperType.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clscc_ExamPaperTypeDA: GetObjByExamPaperTypeId)", objException.Message));
}
return objcc_ExamPaperTypeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clscc_ExamPaperTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clscc_ExamPaperTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExamPaperType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clscc_ExamPaperTypeEN objcc_ExamPaperTypeEN = new clscc_ExamPaperTypeEN()
{
ExamPaperTypeId = objRow[concc_ExamPaperType.ExamPaperTypeId].ToString().Trim(), //试卷类型Id
ExamPaperTypeName = objRow[concc_ExamPaperType.ExamPaperTypeName].ToString().Trim(), //试卷类型名称
Memo = objRow[concc_ExamPaperType.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperType.Memo].ToString().Trim() //备注
};
objcc_ExamPaperTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_ExamPaperTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clscc_ExamPaperTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clscc_ExamPaperTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_ExamPaperTypeEN objcc_ExamPaperTypeEN = new clscc_ExamPaperTypeEN();
try
{
objcc_ExamPaperTypeEN.ExamPaperTypeId = objRow[concc_ExamPaperType.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objcc_ExamPaperTypeEN.ExamPaperTypeName = objRow[concc_ExamPaperType.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objcc_ExamPaperTypeEN.Memo = objRow[concc_ExamPaperType.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clscc_ExamPaperTypeDA: GetObjByDataRowcc_ExamPaperType)", objException.Message));
}
objcc_ExamPaperTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_ExamPaperTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clscc_ExamPaperTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_ExamPaperTypeEN objcc_ExamPaperTypeEN = new clscc_ExamPaperTypeEN();
try
{
objcc_ExamPaperTypeEN.ExamPaperTypeId = objRow[concc_ExamPaperType.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objcc_ExamPaperTypeEN.ExamPaperTypeName = objRow[concc_ExamPaperType.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objcc_ExamPaperTypeEN.Memo = objRow[concc_ExamPaperType.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clscc_ExamPaperTypeDA: GetObjByDataRow)", objException.Message));
}
objcc_ExamPaperTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_ExamPaperTypeEN;
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
objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_ExamPaperTypeEN._CurrTabName, concc_ExamPaperType.ExamPaperTypeId, 2, "");
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
objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_ExamPaperTypeEN._CurrTabName, concc_ExamPaperType.ExamPaperTypeId, 2, strPrefix);
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
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ExamPaperTypeId from cc_ExamPaperType where " + strCondition;
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
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ExamPaperTypeId from cc_ExamPaperType where " + strCondition;
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
 /// <param name = "strExamPaperTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strExamPaperTypeId)
{
CheckPrimaryKey(strExamPaperTypeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_ExamPaperType", "ExamPaperTypeId = " + "'"+ strExamPaperTypeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clscc_ExamPaperTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_ExamPaperType", strCondition))
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
objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("cc_ExamPaperType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clscc_ExamPaperTypeEN objcc_ExamPaperTypeEN)
 {
 if (objcc_ExamPaperTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_ExamPaperTypeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExamPaperType where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_ExamPaperType");
objRow = objDS.Tables["cc_ExamPaperType"].NewRow();
objRow[concc_ExamPaperType.ExamPaperTypeId] = objcc_ExamPaperTypeEN.ExamPaperTypeId; //试卷类型Id
objRow[concc_ExamPaperType.ExamPaperTypeName] = objcc_ExamPaperTypeEN.ExamPaperTypeName; //试卷类型名称
 if (objcc_ExamPaperTypeEN.Memo !=  "")
 {
objRow[concc_ExamPaperType.Memo] = objcc_ExamPaperTypeEN.Memo; //备注
 }
objDS.Tables[clscc_ExamPaperTypeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clscc_ExamPaperTypeEN._CurrTabName);
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
 /// <param name = "objcc_ExamPaperTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_ExamPaperTypeEN objcc_ExamPaperTypeEN)
{
 if (objcc_ExamPaperTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_ExamPaperTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_ExamPaperTypeEN.ExamPaperTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperType.ExamPaperTypeId);
 var strExamPaperTypeId = objcc_ExamPaperTypeEN.ExamPaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamPaperTypeId + "'");
 }
 
 if (objcc_ExamPaperTypeEN.ExamPaperTypeName !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperType.ExamPaperTypeName);
 var strExamPaperTypeName = objcc_ExamPaperTypeEN.ExamPaperTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamPaperTypeName + "'");
 }
 
 if (objcc_ExamPaperTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperType.Memo);
 var strMemo = objcc_ExamPaperTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_ExamPaperType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objcc_ExamPaperTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_ExamPaperTypeEN objcc_ExamPaperTypeEN)
{
 if (objcc_ExamPaperTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_ExamPaperTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_ExamPaperTypeEN.ExamPaperTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperType.ExamPaperTypeId);
 var strExamPaperTypeId = objcc_ExamPaperTypeEN.ExamPaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamPaperTypeId + "'");
 }
 
 if (objcc_ExamPaperTypeEN.ExamPaperTypeName !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperType.ExamPaperTypeName);
 var strExamPaperTypeName = objcc_ExamPaperTypeEN.ExamPaperTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamPaperTypeName + "'");
 }
 
 if (objcc_ExamPaperTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperType.Memo);
 var strMemo = objcc_ExamPaperTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_ExamPaperType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objcc_ExamPaperTypeEN.ExamPaperTypeId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objcc_ExamPaperTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_ExamPaperTypeEN objcc_ExamPaperTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objcc_ExamPaperTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_ExamPaperTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_ExamPaperTypeEN.ExamPaperTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperType.ExamPaperTypeId);
 var strExamPaperTypeId = objcc_ExamPaperTypeEN.ExamPaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamPaperTypeId + "'");
 }
 
 if (objcc_ExamPaperTypeEN.ExamPaperTypeName !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperType.ExamPaperTypeName);
 var strExamPaperTypeName = objcc_ExamPaperTypeEN.ExamPaperTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamPaperTypeName + "'");
 }
 
 if (objcc_ExamPaperTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperType.Memo);
 var strMemo = objcc_ExamPaperTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_ExamPaperType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objcc_ExamPaperTypeEN.ExamPaperTypeId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objcc_ExamPaperTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_ExamPaperTypeEN objcc_ExamPaperTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objcc_ExamPaperTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_ExamPaperTypeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_ExamPaperTypeEN.ExamPaperTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperType.ExamPaperTypeId);
 var strExamPaperTypeId = objcc_ExamPaperTypeEN.ExamPaperTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamPaperTypeId + "'");
 }
 
 if (objcc_ExamPaperTypeEN.ExamPaperTypeName !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperType.ExamPaperTypeName);
 var strExamPaperTypeName = objcc_ExamPaperTypeEN.ExamPaperTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamPaperTypeName + "'");
 }
 
 if (objcc_ExamPaperTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperType.Memo);
 var strMemo = objcc_ExamPaperTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_ExamPaperType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewcc_ExamPaperTypes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExamPaperType where ExamPaperTypeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_ExamPaperType");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strExamPaperTypeId = oRow[concc_ExamPaperType.ExamPaperTypeId].ToString().Trim();
if (IsExist(strExamPaperTypeId))
{
 string strResult = "关键字变量值为:" + string.Format("ExamPaperTypeId = {0}", strExamPaperTypeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clscc_ExamPaperTypeEN._CurrTabName ].NewRow();
objRow[concc_ExamPaperType.ExamPaperTypeId] = oRow[concc_ExamPaperType.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objRow[concc_ExamPaperType.ExamPaperTypeName] = oRow[concc_ExamPaperType.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objRow[concc_ExamPaperType.Memo] = oRow[concc_ExamPaperType.Memo].ToString().Trim(); //备注
 objDS.Tables[clscc_ExamPaperTypeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clscc_ExamPaperTypeEN._CurrTabName);
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
 /// <param name = "objcc_ExamPaperTypeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clscc_ExamPaperTypeEN objcc_ExamPaperTypeEN)
{
 if (objcc_ExamPaperTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_ExamPaperTypeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExamPaperType where ExamPaperTypeId = " + "'"+ objcc_ExamPaperTypeEN.ExamPaperTypeId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clscc_ExamPaperTypeEN._CurrTabName);
if (objDS.Tables[clscc_ExamPaperTypeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ExamPaperTypeId = " + "'"+ objcc_ExamPaperTypeEN.ExamPaperTypeId+"'");
return false;
}
objRow = objDS.Tables[clscc_ExamPaperTypeEN._CurrTabName].Rows[0];
 if (objcc_ExamPaperTypeEN.IsUpdated(concc_ExamPaperType.ExamPaperTypeId))
 {
objRow[concc_ExamPaperType.ExamPaperTypeId] = objcc_ExamPaperTypeEN.ExamPaperTypeId; //试卷类型Id
 }
 if (objcc_ExamPaperTypeEN.IsUpdated(concc_ExamPaperType.ExamPaperTypeName))
 {
objRow[concc_ExamPaperType.ExamPaperTypeName] = objcc_ExamPaperTypeEN.ExamPaperTypeName; //试卷类型名称
 }
 if (objcc_ExamPaperTypeEN.IsUpdated(concc_ExamPaperType.Memo))
 {
objRow[concc_ExamPaperType.Memo] = objcc_ExamPaperTypeEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clscc_ExamPaperTypeEN._CurrTabName);
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
 /// <param name = "objcc_ExamPaperTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_ExamPaperTypeEN objcc_ExamPaperTypeEN)
{
 if (objcc_ExamPaperTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_ExamPaperTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update cc_ExamPaperType Set ");
 
 if (objcc_ExamPaperTypeEN.IsUpdated(concc_ExamPaperType.ExamPaperTypeName))
 {
 if (objcc_ExamPaperTypeEN.ExamPaperTypeName !=  null)
 {
 var strExamPaperTypeName = objcc_ExamPaperTypeEN.ExamPaperTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExamPaperTypeName, concc_ExamPaperType.ExamPaperTypeName); //试卷类型名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperType.ExamPaperTypeName); //试卷类型名称
 }
 }
 
 if (objcc_ExamPaperTypeEN.IsUpdated(concc_ExamPaperType.Memo))
 {
 if (objcc_ExamPaperTypeEN.Memo !=  null)
 {
 var strMemo = objcc_ExamPaperTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_ExamPaperType.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperType.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ExamPaperTypeId = '{0}'", objcc_ExamPaperTypeEN.ExamPaperTypeId); 
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
 /// <param name = "objcc_ExamPaperTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clscc_ExamPaperTypeEN objcc_ExamPaperTypeEN, string strCondition)
{
 if (objcc_ExamPaperTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_ExamPaperTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_ExamPaperType Set ");
 
 if (objcc_ExamPaperTypeEN.IsUpdated(concc_ExamPaperType.ExamPaperTypeName))
 {
 if (objcc_ExamPaperTypeEN.ExamPaperTypeName !=  null)
 {
 var strExamPaperTypeName = objcc_ExamPaperTypeEN.ExamPaperTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamPaperTypeName = '{0}',", strExamPaperTypeName); //试卷类型名称
 }
 else
 {
 sbSQL.Append(" ExamPaperTypeName = null,"); //试卷类型名称
 }
 }
 
 if (objcc_ExamPaperTypeEN.IsUpdated(concc_ExamPaperType.Memo))
 {
 if (objcc_ExamPaperTypeEN.Memo !=  null)
 {
 var strMemo = objcc_ExamPaperTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_ExamPaperTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clscc_ExamPaperTypeEN objcc_ExamPaperTypeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objcc_ExamPaperTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_ExamPaperTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_ExamPaperType Set ");
 
 if (objcc_ExamPaperTypeEN.IsUpdated(concc_ExamPaperType.ExamPaperTypeName))
 {
 if (objcc_ExamPaperTypeEN.ExamPaperTypeName !=  null)
 {
 var strExamPaperTypeName = objcc_ExamPaperTypeEN.ExamPaperTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamPaperTypeName = '{0}',", strExamPaperTypeName); //试卷类型名称
 }
 else
 {
 sbSQL.Append(" ExamPaperTypeName = null,"); //试卷类型名称
 }
 }
 
 if (objcc_ExamPaperTypeEN.IsUpdated(concc_ExamPaperType.Memo))
 {
 if (objcc_ExamPaperTypeEN.Memo !=  null)
 {
 var strMemo = objcc_ExamPaperTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_ExamPaperTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_ExamPaperTypeEN objcc_ExamPaperTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objcc_ExamPaperTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_ExamPaperTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_ExamPaperType Set ");
 
 if (objcc_ExamPaperTypeEN.IsUpdated(concc_ExamPaperType.ExamPaperTypeName))
 {
 if (objcc_ExamPaperTypeEN.ExamPaperTypeName !=  null)
 {
 var strExamPaperTypeName = objcc_ExamPaperTypeEN.ExamPaperTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExamPaperTypeName, concc_ExamPaperType.ExamPaperTypeName); //试卷类型名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperType.ExamPaperTypeName); //试卷类型名称
 }
 }
 
 if (objcc_ExamPaperTypeEN.IsUpdated(concc_ExamPaperType.Memo))
 {
 if (objcc_ExamPaperTypeEN.Memo !=  null)
 {
 var strMemo = objcc_ExamPaperTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_ExamPaperType.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperType.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ExamPaperTypeId = '{0}'", objcc_ExamPaperTypeEN.ExamPaperTypeId); 
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
 /// <param name = "strExamPaperTypeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strExamPaperTypeId) 
{
CheckPrimaryKey(strExamPaperTypeId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strExamPaperTypeId,
};
 objSQL.ExecSP("cc_ExamPaperType_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strExamPaperTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strExamPaperTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strExamPaperTypeId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
//删除cc_ExamPaperType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_ExamPaperType where ExamPaperTypeId = " + "'"+ strExamPaperTypeId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delcc_ExamPaperType(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
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
//删除cc_ExamPaperType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_ExamPaperType where ExamPaperTypeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strExamPaperTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strExamPaperTypeId) 
{
CheckPrimaryKey(strExamPaperTypeId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
//删除cc_ExamPaperType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_ExamPaperType where ExamPaperTypeId = " + "'"+ strExamPaperTypeId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delcc_ExamPaperType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clscc_ExamPaperTypeDA: Delcc_ExamPaperType)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_ExamPaperType where " + strCondition ;
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
public bool Delcc_ExamPaperTypeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clscc_ExamPaperTypeDA: Delcc_ExamPaperTypeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_ExamPaperType where " + strCondition ;
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
 /// <param name = "objcc_ExamPaperTypeENS">源对象</param>
 /// <param name = "objcc_ExamPaperTypeENT">目标对象</param>
public void CopyTo(clscc_ExamPaperTypeEN objcc_ExamPaperTypeENS, clscc_ExamPaperTypeEN objcc_ExamPaperTypeENT)
{
objcc_ExamPaperTypeENT.ExamPaperTypeId = objcc_ExamPaperTypeENS.ExamPaperTypeId; //试卷类型Id
objcc_ExamPaperTypeENT.ExamPaperTypeName = objcc_ExamPaperTypeENS.ExamPaperTypeName; //试卷类型名称
objcc_ExamPaperTypeENT.Memo = objcc_ExamPaperTypeENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clscc_ExamPaperTypeEN objcc_ExamPaperTypeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objcc_ExamPaperTypeEN.ExamPaperTypeName, concc_ExamPaperType.ExamPaperTypeName);
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_ExamPaperTypeEN.ExamPaperTypeId, 2, concc_ExamPaperType.ExamPaperTypeId);
clsCheckSql.CheckFieldLen(objcc_ExamPaperTypeEN.ExamPaperTypeName, 30, concc_ExamPaperType.ExamPaperTypeName);
clsCheckSql.CheckFieldLen(objcc_ExamPaperTypeEN.Memo, 1000, concc_ExamPaperType.Memo);
//检查字段外键固定长度
 objcc_ExamPaperTypeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clscc_ExamPaperTypeEN objcc_ExamPaperTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_ExamPaperTypeEN.ExamPaperTypeName, 30, concc_ExamPaperType.ExamPaperTypeName);
clsCheckSql.CheckFieldLen(objcc_ExamPaperTypeEN.Memo, 1000, concc_ExamPaperType.Memo);
//检查外键字段长度
 objcc_ExamPaperTypeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clscc_ExamPaperTypeEN objcc_ExamPaperTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_ExamPaperTypeEN.ExamPaperTypeId, 2, concc_ExamPaperType.ExamPaperTypeId);
clsCheckSql.CheckFieldLen(objcc_ExamPaperTypeEN.ExamPaperTypeName, 30, concc_ExamPaperType.ExamPaperTypeName);
clsCheckSql.CheckFieldLen(objcc_ExamPaperTypeEN.Memo, 1000, concc_ExamPaperType.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperTypeEN.ExamPaperTypeId, concc_ExamPaperType.ExamPaperTypeId);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperTypeEN.ExamPaperTypeName, concc_ExamPaperType.ExamPaperTypeName);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperTypeEN.Memo, concc_ExamPaperType.Memo);
//检查外键字段长度
 objcc_ExamPaperTypeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetExamPaperTypeId()
{
//获取某学院所有专业信息
string strSQL = "select ExamPaperTypeId, ExamPaperTypeName from cc_ExamPaperType ";
 clsSpecSQLforSql mySql = clscc_ExamPaperTypeDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--cc_ExamPaperType(试卷类型),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_ExamPaperTypeEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clscc_ExamPaperTypeEN objcc_ExamPaperTypeEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ExamPaperTypeName = '{0}'", objcc_ExamPaperTypeEN.ExamPaperTypeName);
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
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
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
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
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
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_ExamPaperTypeEN._CurrTabName);
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
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_ExamPaperTypeEN._CurrTabName, strCondition);
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
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
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
 objSQL = clscc_ExamPaperTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}