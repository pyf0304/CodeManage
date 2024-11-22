
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsEduMSTRGiftedClsCaseDA
 表名:EduMSTRGiftedClsCase(01120379)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:08:58
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:教育硕士优课点评(EduMSTRGiftedCls)
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
 /// 教育硕士优课案例(EduMSTRGiftedClsCase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsEduMSTRGiftedClsCaseDA : clsCommBase4DA
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
 return clsEduMSTRGiftedClsCaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsEduMSTRGiftedClsCaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsEduMSTRGiftedClsCaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsEduMSTRGiftedClsCaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsEduMSTRGiftedClsCaseEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdEduMSTRGiftedClsCase">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdEduMSTRGiftedClsCase)
{
strIdEduMSTRGiftedClsCase = strIdEduMSTRGiftedClsCase.Replace("'", "''");
if (strIdEduMSTRGiftedClsCase.Length > 8)
{
throw new Exception("(errid:Data000001)在表:EduMSTRGiftedClsCase中,检查关键字,长度不正确!(clsEduMSTRGiftedClsCaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdEduMSTRGiftedClsCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:EduMSTRGiftedClsCase中,关键字不能为空 或 null!(clsEduMSTRGiftedClsCaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdEduMSTRGiftedClsCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsEduMSTRGiftedClsCaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsEduMSTRGiftedClsCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
strSQL = "Select * from EduMSTRGiftedClsCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_EduMSTRGiftedClsCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsEduMSTRGiftedClsCaseDA: GetDataTable_EduMSTRGiftedClsCase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
strSQL = "Select * from EduMSTRGiftedClsCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsEduMSTRGiftedClsCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsEduMSTRGiftedClsCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
strSQL = "Select * from EduMSTRGiftedClsCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsEduMSTRGiftedClsCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsEduMSTRGiftedClsCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from EduMSTRGiftedClsCase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from EduMSTRGiftedClsCase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsEduMSTRGiftedClsCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from EduMSTRGiftedClsCase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsEduMSTRGiftedClsCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} EduMSTRGiftedClsCase.* from EduMSTRGiftedClsCase Left Join {1} on {2} where {3} and EduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase not in (Select top {5} EduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase from EduMSTRGiftedClsCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from EduMSTRGiftedClsCase where {1} and IdEduMSTRGiftedClsCase not in (Select top {2} IdEduMSTRGiftedClsCase from EduMSTRGiftedClsCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from EduMSTRGiftedClsCase where {1} and IdEduMSTRGiftedClsCase not in (Select top {3} IdEduMSTRGiftedClsCase from EduMSTRGiftedClsCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsEduMSTRGiftedClsCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} EduMSTRGiftedClsCase.* from EduMSTRGiftedClsCase Left Join {1} on {2} where {3} and EduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase not in (Select top {5} EduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase from EduMSTRGiftedClsCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from EduMSTRGiftedClsCase where {1} and IdEduMSTRGiftedClsCase not in (Select top {2} IdEduMSTRGiftedClsCase from EduMSTRGiftedClsCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from EduMSTRGiftedClsCase where {1} and IdEduMSTRGiftedClsCase not in (Select top {3} IdEduMSTRGiftedClsCase from EduMSTRGiftedClsCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsEduMSTRGiftedClsCaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsEduMSTRGiftedClsCaseDA:GetObjLst)", objException.Message));
}
List<clsEduMSTRGiftedClsCaseEN> arrObjLst = new List<clsEduMSTRGiftedClsCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
strSQL = "Select * from EduMSTRGiftedClsCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN = new clsEduMSTRGiftedClsCaseEN();
try
{
objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase = objRow[conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objEduMSTRGiftedClsCaseEN.IdStudyLevel = objRow[conEduMSTRGiftedClsCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objEduMSTRGiftedClsCaseEN.IdTeachingPlan = objRow[conEduMSTRGiftedClsCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType = objRow[conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objEduMSTRGiftedClsCaseEN.IdCaseType = objRow[conEduMSTRGiftedClsCase.IdCaseType] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.IdCaseType].ToString().Trim(); //案例类型流水号
objEduMSTRGiftedClsCaseEN.IdDiscipline = objRow[conEduMSTRGiftedClsCase.IdDiscipline].ToString().Trim(); //学科流水号
objEduMSTRGiftedClsCaseEN.BrowseCount = objRow[conEduMSTRGiftedClsCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conEduMSTRGiftedClsCase.BrowseCount].ToString().Trim()); //浏览次数
objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion = objRow[conEduMSTRGiftedClsCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objEduMSTRGiftedClsCaseEN.IdTeachSkill = objRow[conEduMSTRGiftedClsCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objEduMSTRGiftedClsCaseEN.CaseLevelId = objRow[conEduMSTRGiftedClsCase.CaseLevelId] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.CaseLevelId].ToString().Trim(); //课例等级Id
objEduMSTRGiftedClsCaseEN.DocFile = objRow[conEduMSTRGiftedClsCase.DocFile] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.DocFile].ToString().Trim(); //生成的Word文件名
objEduMSTRGiftedClsCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conEduMSTRGiftedClsCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objEduMSTRGiftedClsCaseEN.WordCreateDate = objRow[conEduMSTRGiftedClsCase.WordCreateDate] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.WordCreateDate].ToString().Trim(); //Word生成日期
objEduMSTRGiftedClsCaseEN.IsVisible = TransNullToBool(objRow[conEduMSTRGiftedClsCase.IsVisible].ToString().Trim()); //是否显示
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objEduMSTRGiftedClsCaseEN.OwnerId = objRow[conEduMSTRGiftedClsCase.OwnerId].ToString().Trim(); //拥有者Id
objEduMSTRGiftedClsCaseEN.IsDualVideo = TransNullToBool(objRow[conEduMSTRGiftedClsCase.IsDualVideo].ToString().Trim()); //是否双视频
objEduMSTRGiftedClsCaseEN.UserKindId = objRow[conEduMSTRGiftedClsCase.UserKindId].ToString().Trim(); //用户类别Id
objEduMSTRGiftedClsCaseEN.UserTypeId = objRow[conEduMSTRGiftedClsCase.UserTypeId] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.UserTypeId].ToString().Trim(); //用户类型Id
objEduMSTRGiftedClsCaseEN.RecommendedDegreeId = objRow[conEduMSTRGiftedClsCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objEduMSTRGiftedClsCaseEN.ftpFileType = objRow[conEduMSTRGiftedClsCase.ftpFileType] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.ftpFileType].ToString().Trim(); //ftp文件类型
objEduMSTRGiftedClsCaseEN.VideoUrl = objRow[conEduMSTRGiftedClsCase.VideoUrl] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.VideoUrl].ToString().Trim(); //视频Url
objEduMSTRGiftedClsCaseEN.VideoPath = objRow[conEduMSTRGiftedClsCase.VideoPath] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.VideoPath].ToString().Trim(); //视频目录
objEduMSTRGiftedClsCaseEN.ResErrMsg = objRow[conEduMSTRGiftedClsCase.ResErrMsg] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.ResErrMsg].ToString().Trim(); //资源错误信息
objEduMSTRGiftedClsCaseEN.ResourceNum = objRow[conEduMSTRGiftedClsCase.ResourceNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conEduMSTRGiftedClsCase.ResourceNum].ToString().Trim()); //资源数
objEduMSTRGiftedClsCaseEN.UpdDate = objRow[conEduMSTRGiftedClsCase.UpdDate] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.UpdDate].ToString().Trim(); //修改日期
objEduMSTRGiftedClsCaseEN.UpdUserId = objRow[conEduMSTRGiftedClsCase.UpdUserId] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.UpdUserId].ToString().Trim(); //修改用户Id
objEduMSTRGiftedClsCaseEN.Memo = objRow[conEduMSTRGiftedClsCase.Memo] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsEduMSTRGiftedClsCaseDA: GetObjLst)", objException.Message));
}
objEduMSTRGiftedClsCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objEduMSTRGiftedClsCaseEN);
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
public List<clsEduMSTRGiftedClsCaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsEduMSTRGiftedClsCaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsEduMSTRGiftedClsCaseEN> arrObjLst = new List<clsEduMSTRGiftedClsCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN = new clsEduMSTRGiftedClsCaseEN();
try
{
objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase = objRow[conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objEduMSTRGiftedClsCaseEN.IdStudyLevel = objRow[conEduMSTRGiftedClsCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objEduMSTRGiftedClsCaseEN.IdTeachingPlan = objRow[conEduMSTRGiftedClsCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType = objRow[conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objEduMSTRGiftedClsCaseEN.IdCaseType = objRow[conEduMSTRGiftedClsCase.IdCaseType] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.IdCaseType].ToString().Trim(); //案例类型流水号
objEduMSTRGiftedClsCaseEN.IdDiscipline = objRow[conEduMSTRGiftedClsCase.IdDiscipline].ToString().Trim(); //学科流水号
objEduMSTRGiftedClsCaseEN.BrowseCount = objRow[conEduMSTRGiftedClsCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conEduMSTRGiftedClsCase.BrowseCount].ToString().Trim()); //浏览次数
objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion = objRow[conEduMSTRGiftedClsCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objEduMSTRGiftedClsCaseEN.IdTeachSkill = objRow[conEduMSTRGiftedClsCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objEduMSTRGiftedClsCaseEN.CaseLevelId = objRow[conEduMSTRGiftedClsCase.CaseLevelId] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.CaseLevelId].ToString().Trim(); //课例等级Id
objEduMSTRGiftedClsCaseEN.DocFile = objRow[conEduMSTRGiftedClsCase.DocFile] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.DocFile].ToString().Trim(); //生成的Word文件名
objEduMSTRGiftedClsCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conEduMSTRGiftedClsCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objEduMSTRGiftedClsCaseEN.WordCreateDate = objRow[conEduMSTRGiftedClsCase.WordCreateDate] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.WordCreateDate].ToString().Trim(); //Word生成日期
objEduMSTRGiftedClsCaseEN.IsVisible = TransNullToBool(objRow[conEduMSTRGiftedClsCase.IsVisible].ToString().Trim()); //是否显示
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objEduMSTRGiftedClsCaseEN.OwnerId = objRow[conEduMSTRGiftedClsCase.OwnerId].ToString().Trim(); //拥有者Id
objEduMSTRGiftedClsCaseEN.IsDualVideo = TransNullToBool(objRow[conEduMSTRGiftedClsCase.IsDualVideo].ToString().Trim()); //是否双视频
objEduMSTRGiftedClsCaseEN.UserKindId = objRow[conEduMSTRGiftedClsCase.UserKindId].ToString().Trim(); //用户类别Id
objEduMSTRGiftedClsCaseEN.UserTypeId = objRow[conEduMSTRGiftedClsCase.UserTypeId] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.UserTypeId].ToString().Trim(); //用户类型Id
objEduMSTRGiftedClsCaseEN.RecommendedDegreeId = objRow[conEduMSTRGiftedClsCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objEduMSTRGiftedClsCaseEN.ftpFileType = objRow[conEduMSTRGiftedClsCase.ftpFileType] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.ftpFileType].ToString().Trim(); //ftp文件类型
objEduMSTRGiftedClsCaseEN.VideoUrl = objRow[conEduMSTRGiftedClsCase.VideoUrl] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.VideoUrl].ToString().Trim(); //视频Url
objEduMSTRGiftedClsCaseEN.VideoPath = objRow[conEduMSTRGiftedClsCase.VideoPath] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.VideoPath].ToString().Trim(); //视频目录
objEduMSTRGiftedClsCaseEN.ResErrMsg = objRow[conEduMSTRGiftedClsCase.ResErrMsg] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.ResErrMsg].ToString().Trim(); //资源错误信息
objEduMSTRGiftedClsCaseEN.ResourceNum = objRow[conEduMSTRGiftedClsCase.ResourceNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conEduMSTRGiftedClsCase.ResourceNum].ToString().Trim()); //资源数
objEduMSTRGiftedClsCaseEN.UpdDate = objRow[conEduMSTRGiftedClsCase.UpdDate] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.UpdDate].ToString().Trim(); //修改日期
objEduMSTRGiftedClsCaseEN.UpdUserId = objRow[conEduMSTRGiftedClsCase.UpdUserId] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.UpdUserId].ToString().Trim(); //修改用户Id
objEduMSTRGiftedClsCaseEN.Memo = objRow[conEduMSTRGiftedClsCase.Memo] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsEduMSTRGiftedClsCaseDA: GetObjLst)", objException.Message));
}
objEduMSTRGiftedClsCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objEduMSTRGiftedClsCaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetEduMSTRGiftedClsCase(ref clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
strSQL = "Select * from EduMSTRGiftedClsCase where IdEduMSTRGiftedClsCase = " + "'"+ objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase = objDT.Rows[0][conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID = objDT.Rows[0][conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID(字段类型:char,字段长度:8,是否可空:False)
 objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName = objDT.Rows[0][conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme = objDT.Rows[0][conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate = objDT.Rows[0][conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期(字段类型:char,字段长度:8,是否可空:True)
 objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime = objDT.Rows[0][conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间(字段类型:char,字段长度:6,是否可空:True)
 objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn = objDT.Rows[0][conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objEduMSTRGiftedClsCaseEN.IdStudyLevel = objDT.Rows[0][conEduMSTRGiftedClsCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objEduMSTRGiftedClsCaseEN.IdTeachingPlan = objDT.Rows[0][conEduMSTRGiftedClsCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn = objDT.Rows[0][conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType = objDT.Rows[0][conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objEduMSTRGiftedClsCaseEN.IdCaseType = objDT.Rows[0][conEduMSTRGiftedClsCase.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objEduMSTRGiftedClsCaseEN.IdDiscipline = objDT.Rows[0][conEduMSTRGiftedClsCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objEduMSTRGiftedClsCaseEN.BrowseCount = TransNullToInt(objDT.Rows[0][conEduMSTRGiftedClsCase.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion = objDT.Rows[0][conEduMSTRGiftedClsCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objEduMSTRGiftedClsCaseEN.IdTeachSkill = objDT.Rows[0][conEduMSTRGiftedClsCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objEduMSTRGiftedClsCaseEN.CaseLevelId = objDT.Rows[0][conEduMSTRGiftedClsCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objEduMSTRGiftedClsCaseEN.DocFile = objDT.Rows[0][conEduMSTRGiftedClsCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objEduMSTRGiftedClsCaseEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][conEduMSTRGiftedClsCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objEduMSTRGiftedClsCaseEN.WordCreateDate = objDT.Rows[0][conEduMSTRGiftedClsCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objEduMSTRGiftedClsCaseEN.IsVisible = TransNullToBool(objDT.Rows[0][conEduMSTRGiftedClsCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText = objDT.Rows[0][conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本(字段类型:varchar,字段长度:8000,是否可空:True)
 objEduMSTRGiftedClsCaseEN.OwnerId = objDT.Rows[0][conEduMSTRGiftedClsCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objEduMSTRGiftedClsCaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][conEduMSTRGiftedClsCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objEduMSTRGiftedClsCaseEN.UserKindId = objDT.Rows[0][conEduMSTRGiftedClsCase.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objEduMSTRGiftedClsCaseEN.UserTypeId = objDT.Rows[0][conEduMSTRGiftedClsCase.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objEduMSTRGiftedClsCaseEN.RecommendedDegreeId = objDT.Rows[0][conEduMSTRGiftedClsCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objEduMSTRGiftedClsCaseEN.ftpFileType = objDT.Rows[0][conEduMSTRGiftedClsCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objEduMSTRGiftedClsCaseEN.VideoUrl = objDT.Rows[0][conEduMSTRGiftedClsCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objEduMSTRGiftedClsCaseEN.VideoPath = objDT.Rows[0][conEduMSTRGiftedClsCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objEduMSTRGiftedClsCaseEN.ResErrMsg = objDT.Rows[0][conEduMSTRGiftedClsCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objEduMSTRGiftedClsCaseEN.ResourceNum = TransNullToInt(objDT.Rows[0][conEduMSTRGiftedClsCase.ResourceNum].ToString().Trim()); //资源数(字段类型:int,字段长度:4,是否可空:True)
 objEduMSTRGiftedClsCaseEN.UpdDate = objDT.Rows[0][conEduMSTRGiftedClsCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objEduMSTRGiftedClsCaseEN.UpdUserId = objDT.Rows[0][conEduMSTRGiftedClsCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objEduMSTRGiftedClsCaseEN.Memo = objDT.Rows[0][conEduMSTRGiftedClsCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsEduMSTRGiftedClsCaseDA: GetEduMSTRGiftedClsCase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdEduMSTRGiftedClsCase">表关键字</param>
 /// <returns>表对象</returns>
public clsEduMSTRGiftedClsCaseEN GetObjByIdEduMSTRGiftedClsCase(string strIdEduMSTRGiftedClsCase)
{
CheckPrimaryKey(strIdEduMSTRGiftedClsCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
strSQL = "Select * from EduMSTRGiftedClsCase where IdEduMSTRGiftedClsCase = " + "'"+ strIdEduMSTRGiftedClsCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN = new clsEduMSTRGiftedClsCaseEN();
try
{
 objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase = objRow[conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID(字段类型:char,字段长度:8,是否可空:False)
 objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期(字段类型:char,字段长度:8,是否可空:True)
 objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间(字段类型:char,字段长度:6,是否可空:True)
 objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objEduMSTRGiftedClsCaseEN.IdStudyLevel = objRow[conEduMSTRGiftedClsCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objEduMSTRGiftedClsCaseEN.IdTeachingPlan = objRow[conEduMSTRGiftedClsCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType = objRow[conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objEduMSTRGiftedClsCaseEN.IdCaseType = objRow[conEduMSTRGiftedClsCase.IdCaseType] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objEduMSTRGiftedClsCaseEN.IdDiscipline = objRow[conEduMSTRGiftedClsCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objEduMSTRGiftedClsCaseEN.BrowseCount = objRow[conEduMSTRGiftedClsCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEduMSTRGiftedClsCase.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion = objRow[conEduMSTRGiftedClsCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objEduMSTRGiftedClsCaseEN.IdTeachSkill = objRow[conEduMSTRGiftedClsCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objEduMSTRGiftedClsCaseEN.CaseLevelId = objRow[conEduMSTRGiftedClsCase.CaseLevelId] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objEduMSTRGiftedClsCaseEN.DocFile = objRow[conEduMSTRGiftedClsCase.DocFile] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objEduMSTRGiftedClsCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conEduMSTRGiftedClsCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objEduMSTRGiftedClsCaseEN.WordCreateDate = objRow[conEduMSTRGiftedClsCase.WordCreateDate] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objEduMSTRGiftedClsCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conEduMSTRGiftedClsCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本(字段类型:varchar,字段长度:8000,是否可空:True)
 objEduMSTRGiftedClsCaseEN.OwnerId = objRow[conEduMSTRGiftedClsCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objEduMSTRGiftedClsCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conEduMSTRGiftedClsCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objEduMSTRGiftedClsCaseEN.UserKindId = objRow[conEduMSTRGiftedClsCase.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objEduMSTRGiftedClsCaseEN.UserTypeId = objRow[conEduMSTRGiftedClsCase.UserTypeId] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objEduMSTRGiftedClsCaseEN.RecommendedDegreeId = objRow[conEduMSTRGiftedClsCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objEduMSTRGiftedClsCaseEN.ftpFileType = objRow[conEduMSTRGiftedClsCase.ftpFileType] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objEduMSTRGiftedClsCaseEN.VideoUrl = objRow[conEduMSTRGiftedClsCase.VideoUrl] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objEduMSTRGiftedClsCaseEN.VideoPath = objRow[conEduMSTRGiftedClsCase.VideoPath] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objEduMSTRGiftedClsCaseEN.ResErrMsg = objRow[conEduMSTRGiftedClsCase.ResErrMsg] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objEduMSTRGiftedClsCaseEN.ResourceNum = objRow[conEduMSTRGiftedClsCase.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conEduMSTRGiftedClsCase.ResourceNum].ToString().Trim()); //资源数(字段类型:int,字段长度:4,是否可空:True)
 objEduMSTRGiftedClsCaseEN.UpdDate = objRow[conEduMSTRGiftedClsCase.UpdDate] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objEduMSTRGiftedClsCaseEN.UpdUserId = objRow[conEduMSTRGiftedClsCase.UpdUserId] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objEduMSTRGiftedClsCaseEN.Memo = objRow[conEduMSTRGiftedClsCase.Memo] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsEduMSTRGiftedClsCaseDA: GetObjByIdEduMSTRGiftedClsCase)", objException.Message));
}
return objEduMSTRGiftedClsCaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsEduMSTRGiftedClsCaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsEduMSTRGiftedClsCaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
strSQL = "Select * from EduMSTRGiftedClsCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN = new clsEduMSTRGiftedClsCaseEN()
{
IdEduMSTRGiftedClsCase = objRow[conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase].ToString().Trim(), //教育硕士优课案例流水号
EduMSTRGiftedClsCaseID = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID].ToString().Trim(), //教育硕士优课案例ID
EduMSTRGiftedClsCaseName = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName].ToString().Trim(), //教育硕士优课案例名称
EduMSTRGiftedClsCaseTheme = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme].ToString().Trim(), //教育硕士优课案例主题词
EduMSTRGiftedClsCaseDate = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate].ToString().Trim(), //教育硕士优课案例日期
EduMSTRGiftedClsCaseTime = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime].ToString().Trim(), //教育硕士优课案例时间
EduMSTRGiftedClsCaseDateIn = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn].ToString().Trim(), //案例入库日期
IdStudyLevel = objRow[conEduMSTRGiftedClsCase.IdStudyLevel].ToString().Trim(), //id_StudyLevel
IdTeachingPlan = objRow[conEduMSTRGiftedClsCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.IdTeachingPlan].ToString().Trim(), //教案流水号
EduMSTRGiftedClsCaseTimeIn = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(), //案例入库时间
IdEduMSTRGiftedClsCaseType = objRow[conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType].ToString().Trim(), //教育硕士优课案例类型流水号
IdCaseType = objRow[conEduMSTRGiftedClsCase.IdCaseType] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.IdCaseType].ToString().Trim(), //案例类型流水号
IdDiscipline = objRow[conEduMSTRGiftedClsCase.IdDiscipline].ToString().Trim(), //学科流水号
BrowseCount = objRow[conEduMSTRGiftedClsCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conEduMSTRGiftedClsCase.BrowseCount].ToString().Trim()), //浏览次数
IdSenateGaugeVersion = objRow[conEduMSTRGiftedClsCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
IdTeachSkill = objRow[conEduMSTRGiftedClsCase.IdTeachSkill].ToString().Trim(), //教学技能流水号
CaseLevelId = objRow[conEduMSTRGiftedClsCase.CaseLevelId] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.CaseLevelId].ToString().Trim(), //课例等级Id
DocFile = objRow[conEduMSTRGiftedClsCase.DocFile] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.DocFile].ToString().Trim(), //生成的Word文件名
IsNeedGeneWord = TransNullToBool(objRow[conEduMSTRGiftedClsCase.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
WordCreateDate = objRow[conEduMSTRGiftedClsCase.WordCreateDate] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.WordCreateDate].ToString().Trim(), //Word生成日期
IsVisible = TransNullToBool(objRow[conEduMSTRGiftedClsCase.IsVisible].ToString().Trim()), //是否显示
EduMSTRGiftedClsCaseText = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText].ToString().Trim(), //教育硕士优课案例文本
OwnerId = objRow[conEduMSTRGiftedClsCase.OwnerId].ToString().Trim(), //拥有者Id
IsDualVideo = TransNullToBool(objRow[conEduMSTRGiftedClsCase.IsDualVideo].ToString().Trim()), //是否双视频
UserKindId = objRow[conEduMSTRGiftedClsCase.UserKindId].ToString().Trim(), //用户类别Id
UserTypeId = objRow[conEduMSTRGiftedClsCase.UserTypeId] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.UserTypeId].ToString().Trim(), //用户类型Id
RecommendedDegreeId = objRow[conEduMSTRGiftedClsCase.RecommendedDegreeId].ToString().Trim(), //推荐度Id
ftpFileType = objRow[conEduMSTRGiftedClsCase.ftpFileType] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.ftpFileType].ToString().Trim(), //ftp文件类型
VideoUrl = objRow[conEduMSTRGiftedClsCase.VideoUrl] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[conEduMSTRGiftedClsCase.VideoPath] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.VideoPath].ToString().Trim(), //视频目录
ResErrMsg = objRow[conEduMSTRGiftedClsCase.ResErrMsg] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.ResErrMsg].ToString().Trim(), //资源错误信息
ResourceNum = objRow[conEduMSTRGiftedClsCase.ResourceNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conEduMSTRGiftedClsCase.ResourceNum].ToString().Trim()), //资源数
UpdDate = objRow[conEduMSTRGiftedClsCase.UpdDate] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conEduMSTRGiftedClsCase.UpdUserId] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conEduMSTRGiftedClsCase.Memo] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.Memo].ToString().Trim() //备注
};
objEduMSTRGiftedClsCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objEduMSTRGiftedClsCaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsEduMSTRGiftedClsCaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsEduMSTRGiftedClsCaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN = new clsEduMSTRGiftedClsCaseEN();
try
{
objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase = objRow[conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objEduMSTRGiftedClsCaseEN.IdStudyLevel = objRow[conEduMSTRGiftedClsCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objEduMSTRGiftedClsCaseEN.IdTeachingPlan = objRow[conEduMSTRGiftedClsCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType = objRow[conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objEduMSTRGiftedClsCaseEN.IdCaseType = objRow[conEduMSTRGiftedClsCase.IdCaseType] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.IdCaseType].ToString().Trim(); //案例类型流水号
objEduMSTRGiftedClsCaseEN.IdDiscipline = objRow[conEduMSTRGiftedClsCase.IdDiscipline].ToString().Trim(); //学科流水号
objEduMSTRGiftedClsCaseEN.BrowseCount = objRow[conEduMSTRGiftedClsCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conEduMSTRGiftedClsCase.BrowseCount].ToString().Trim()); //浏览次数
objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion = objRow[conEduMSTRGiftedClsCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objEduMSTRGiftedClsCaseEN.IdTeachSkill = objRow[conEduMSTRGiftedClsCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objEduMSTRGiftedClsCaseEN.CaseLevelId = objRow[conEduMSTRGiftedClsCase.CaseLevelId] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.CaseLevelId].ToString().Trim(); //课例等级Id
objEduMSTRGiftedClsCaseEN.DocFile = objRow[conEduMSTRGiftedClsCase.DocFile] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.DocFile].ToString().Trim(); //生成的Word文件名
objEduMSTRGiftedClsCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conEduMSTRGiftedClsCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objEduMSTRGiftedClsCaseEN.WordCreateDate = objRow[conEduMSTRGiftedClsCase.WordCreateDate] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.WordCreateDate].ToString().Trim(); //Word生成日期
objEduMSTRGiftedClsCaseEN.IsVisible = TransNullToBool(objRow[conEduMSTRGiftedClsCase.IsVisible].ToString().Trim()); //是否显示
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objEduMSTRGiftedClsCaseEN.OwnerId = objRow[conEduMSTRGiftedClsCase.OwnerId].ToString().Trim(); //拥有者Id
objEduMSTRGiftedClsCaseEN.IsDualVideo = TransNullToBool(objRow[conEduMSTRGiftedClsCase.IsDualVideo].ToString().Trim()); //是否双视频
objEduMSTRGiftedClsCaseEN.UserKindId = objRow[conEduMSTRGiftedClsCase.UserKindId].ToString().Trim(); //用户类别Id
objEduMSTRGiftedClsCaseEN.UserTypeId = objRow[conEduMSTRGiftedClsCase.UserTypeId] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.UserTypeId].ToString().Trim(); //用户类型Id
objEduMSTRGiftedClsCaseEN.RecommendedDegreeId = objRow[conEduMSTRGiftedClsCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objEduMSTRGiftedClsCaseEN.ftpFileType = objRow[conEduMSTRGiftedClsCase.ftpFileType] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.ftpFileType].ToString().Trim(); //ftp文件类型
objEduMSTRGiftedClsCaseEN.VideoUrl = objRow[conEduMSTRGiftedClsCase.VideoUrl] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.VideoUrl].ToString().Trim(); //视频Url
objEduMSTRGiftedClsCaseEN.VideoPath = objRow[conEduMSTRGiftedClsCase.VideoPath] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.VideoPath].ToString().Trim(); //视频目录
objEduMSTRGiftedClsCaseEN.ResErrMsg = objRow[conEduMSTRGiftedClsCase.ResErrMsg] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.ResErrMsg].ToString().Trim(); //资源错误信息
objEduMSTRGiftedClsCaseEN.ResourceNum = objRow[conEduMSTRGiftedClsCase.ResourceNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conEduMSTRGiftedClsCase.ResourceNum].ToString().Trim()); //资源数
objEduMSTRGiftedClsCaseEN.UpdDate = objRow[conEduMSTRGiftedClsCase.UpdDate] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.UpdDate].ToString().Trim(); //修改日期
objEduMSTRGiftedClsCaseEN.UpdUserId = objRow[conEduMSTRGiftedClsCase.UpdUserId] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.UpdUserId].ToString().Trim(); //修改用户Id
objEduMSTRGiftedClsCaseEN.Memo = objRow[conEduMSTRGiftedClsCase.Memo] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsEduMSTRGiftedClsCaseDA: GetObjByDataRowEduMSTRGiftedClsCase)", objException.Message));
}
objEduMSTRGiftedClsCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objEduMSTRGiftedClsCaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsEduMSTRGiftedClsCaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN = new clsEduMSTRGiftedClsCaseEN();
try
{
objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase = objRow[conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objEduMSTRGiftedClsCaseEN.IdStudyLevel = objRow[conEduMSTRGiftedClsCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objEduMSTRGiftedClsCaseEN.IdTeachingPlan = objRow[conEduMSTRGiftedClsCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType = objRow[conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objEduMSTRGiftedClsCaseEN.IdCaseType = objRow[conEduMSTRGiftedClsCase.IdCaseType] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.IdCaseType].ToString().Trim(); //案例类型流水号
objEduMSTRGiftedClsCaseEN.IdDiscipline = objRow[conEduMSTRGiftedClsCase.IdDiscipline].ToString().Trim(); //学科流水号
objEduMSTRGiftedClsCaseEN.BrowseCount = objRow[conEduMSTRGiftedClsCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conEduMSTRGiftedClsCase.BrowseCount].ToString().Trim()); //浏览次数
objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion = objRow[conEduMSTRGiftedClsCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objEduMSTRGiftedClsCaseEN.IdTeachSkill = objRow[conEduMSTRGiftedClsCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objEduMSTRGiftedClsCaseEN.CaseLevelId = objRow[conEduMSTRGiftedClsCase.CaseLevelId] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.CaseLevelId].ToString().Trim(); //课例等级Id
objEduMSTRGiftedClsCaseEN.DocFile = objRow[conEduMSTRGiftedClsCase.DocFile] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.DocFile].ToString().Trim(); //生成的Word文件名
objEduMSTRGiftedClsCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conEduMSTRGiftedClsCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objEduMSTRGiftedClsCaseEN.WordCreateDate = objRow[conEduMSTRGiftedClsCase.WordCreateDate] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.WordCreateDate].ToString().Trim(); //Word生成日期
objEduMSTRGiftedClsCaseEN.IsVisible = TransNullToBool(objRow[conEduMSTRGiftedClsCase.IsVisible].ToString().Trim()); //是否显示
objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText = objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objEduMSTRGiftedClsCaseEN.OwnerId = objRow[conEduMSTRGiftedClsCase.OwnerId].ToString().Trim(); //拥有者Id
objEduMSTRGiftedClsCaseEN.IsDualVideo = TransNullToBool(objRow[conEduMSTRGiftedClsCase.IsDualVideo].ToString().Trim()); //是否双视频
objEduMSTRGiftedClsCaseEN.UserKindId = objRow[conEduMSTRGiftedClsCase.UserKindId].ToString().Trim(); //用户类别Id
objEduMSTRGiftedClsCaseEN.UserTypeId = objRow[conEduMSTRGiftedClsCase.UserTypeId] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.UserTypeId].ToString().Trim(); //用户类型Id
objEduMSTRGiftedClsCaseEN.RecommendedDegreeId = objRow[conEduMSTRGiftedClsCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objEduMSTRGiftedClsCaseEN.ftpFileType = objRow[conEduMSTRGiftedClsCase.ftpFileType] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.ftpFileType].ToString().Trim(); //ftp文件类型
objEduMSTRGiftedClsCaseEN.VideoUrl = objRow[conEduMSTRGiftedClsCase.VideoUrl] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.VideoUrl].ToString().Trim(); //视频Url
objEduMSTRGiftedClsCaseEN.VideoPath = objRow[conEduMSTRGiftedClsCase.VideoPath] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.VideoPath].ToString().Trim(); //视频目录
objEduMSTRGiftedClsCaseEN.ResErrMsg = objRow[conEduMSTRGiftedClsCase.ResErrMsg] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.ResErrMsg].ToString().Trim(); //资源错误信息
objEduMSTRGiftedClsCaseEN.ResourceNum = objRow[conEduMSTRGiftedClsCase.ResourceNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conEduMSTRGiftedClsCase.ResourceNum].ToString().Trim()); //资源数
objEduMSTRGiftedClsCaseEN.UpdDate = objRow[conEduMSTRGiftedClsCase.UpdDate] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.UpdDate].ToString().Trim(); //修改日期
objEduMSTRGiftedClsCaseEN.UpdUserId = objRow[conEduMSTRGiftedClsCase.UpdUserId] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.UpdUserId].ToString().Trim(); //修改用户Id
objEduMSTRGiftedClsCaseEN.Memo = objRow[conEduMSTRGiftedClsCase.Memo] == DBNull.Value ? null : objRow[conEduMSTRGiftedClsCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsEduMSTRGiftedClsCaseDA: GetObjByDataRow)", objException.Message));
}
objEduMSTRGiftedClsCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objEduMSTRGiftedClsCaseEN;
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
objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsEduMSTRGiftedClsCaseEN._CurrTabName, conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase, 8, "");
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
objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsEduMSTRGiftedClsCaseEN._CurrTabName, conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase, 8, strPrefix);
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
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdEduMSTRGiftedClsCase from EduMSTRGiftedClsCase where " + strCondition;
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
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdEduMSTRGiftedClsCase from EduMSTRGiftedClsCase where " + strCondition;
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
 /// <param name = "strIdEduMSTRGiftedClsCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdEduMSTRGiftedClsCase)
{
CheckPrimaryKey(strIdEduMSTRGiftedClsCase);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("EduMSTRGiftedClsCase", "IdEduMSTRGiftedClsCase = " + "'"+ strIdEduMSTRGiftedClsCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsEduMSTRGiftedClsCaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("EduMSTRGiftedClsCase", strCondition))
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
objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("EduMSTRGiftedClsCase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN)
 {
 objEduMSTRGiftedClsCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objEduMSTRGiftedClsCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objEduMSTRGiftedClsCaseEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
strSQL = "Select * from EduMSTRGiftedClsCase where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "EduMSTRGiftedClsCase");
objRow = objDS.Tables["EduMSTRGiftedClsCase"].NewRow();
objRow[conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase] = objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase; //教育硕士优课案例流水号
objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID] = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID; //教育硕士优课案例ID
objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName] = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName; //教育硕士优课案例名称
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme !=  "")
 {
objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme] = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme; //教育硕士优课案例主题词
 }
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate !=  "")
 {
objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate] = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate; //教育硕士优课案例日期
 }
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime !=  "")
 {
objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime] = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime; //教育硕士优课案例时间
 }
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn !=  "")
 {
objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn] = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn; //案例入库日期
 }
objRow[conEduMSTRGiftedClsCase.IdStudyLevel] = objEduMSTRGiftedClsCaseEN.IdStudyLevel; //id_StudyLevel
 if (objEduMSTRGiftedClsCaseEN.IdTeachingPlan !=  "")
 {
objRow[conEduMSTRGiftedClsCase.IdTeachingPlan] = objEduMSTRGiftedClsCaseEN.IdTeachingPlan; //教案流水号
 }
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn !=  "")
 {
objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn] = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn; //案例入库时间
 }
 if (objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType !=  "")
 {
objRow[conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType] = objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType; //教育硕士优课案例类型流水号
 }
 if (objEduMSTRGiftedClsCaseEN.IdCaseType !=  "")
 {
objRow[conEduMSTRGiftedClsCase.IdCaseType] = objEduMSTRGiftedClsCaseEN.IdCaseType; //案例类型流水号
 }
objRow[conEduMSTRGiftedClsCase.IdDiscipline] = objEduMSTRGiftedClsCaseEN.IdDiscipline; //学科流水号
objRow[conEduMSTRGiftedClsCase.BrowseCount] = objEduMSTRGiftedClsCaseEN.BrowseCount; //浏览次数
 if (objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion !=  "")
 {
objRow[conEduMSTRGiftedClsCase.IdSenateGaugeVersion] = objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion; //评价量表版本流水号
 }
objRow[conEduMSTRGiftedClsCase.IdTeachSkill] = objEduMSTRGiftedClsCaseEN.IdTeachSkill; //教学技能流水号
 if (objEduMSTRGiftedClsCaseEN.CaseLevelId !=  "")
 {
objRow[conEduMSTRGiftedClsCase.CaseLevelId] = objEduMSTRGiftedClsCaseEN.CaseLevelId; //课例等级Id
 }
 if (objEduMSTRGiftedClsCaseEN.DocFile !=  "")
 {
objRow[conEduMSTRGiftedClsCase.DocFile] = objEduMSTRGiftedClsCaseEN.DocFile; //生成的Word文件名
 }
objRow[conEduMSTRGiftedClsCase.IsNeedGeneWord] = objEduMSTRGiftedClsCaseEN.IsNeedGeneWord; //是否需要生成Word
 if (objEduMSTRGiftedClsCaseEN.WordCreateDate !=  "")
 {
objRow[conEduMSTRGiftedClsCase.WordCreateDate] = objEduMSTRGiftedClsCaseEN.WordCreateDate; //Word生成日期
 }
objRow[conEduMSTRGiftedClsCase.IsVisible] = objEduMSTRGiftedClsCaseEN.IsVisible; //是否显示
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText !=  "")
 {
objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText] = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText; //教育硕士优课案例文本
 }
objRow[conEduMSTRGiftedClsCase.OwnerId] = objEduMSTRGiftedClsCaseEN.OwnerId; //拥有者Id
objRow[conEduMSTRGiftedClsCase.IsDualVideo] = objEduMSTRGiftedClsCaseEN.IsDualVideo; //是否双视频
objRow[conEduMSTRGiftedClsCase.UserKindId] = objEduMSTRGiftedClsCaseEN.UserKindId; //用户类别Id
 if (objEduMSTRGiftedClsCaseEN.UserTypeId !=  "")
 {
objRow[conEduMSTRGiftedClsCase.UserTypeId] = objEduMSTRGiftedClsCaseEN.UserTypeId; //用户类型Id
 }
objRow[conEduMSTRGiftedClsCase.RecommendedDegreeId] = objEduMSTRGiftedClsCaseEN.RecommendedDegreeId; //推荐度Id
 if (objEduMSTRGiftedClsCaseEN.ftpFileType !=  "")
 {
objRow[conEduMSTRGiftedClsCase.ftpFileType] = objEduMSTRGiftedClsCaseEN.ftpFileType; //ftp文件类型
 }
 if (objEduMSTRGiftedClsCaseEN.VideoUrl !=  "")
 {
objRow[conEduMSTRGiftedClsCase.VideoUrl] = objEduMSTRGiftedClsCaseEN.VideoUrl; //视频Url
 }
 if (objEduMSTRGiftedClsCaseEN.VideoPath !=  "")
 {
objRow[conEduMSTRGiftedClsCase.VideoPath] = objEduMSTRGiftedClsCaseEN.VideoPath; //视频目录
 }
 if (objEduMSTRGiftedClsCaseEN.ResErrMsg !=  "")
 {
objRow[conEduMSTRGiftedClsCase.ResErrMsg] = objEduMSTRGiftedClsCaseEN.ResErrMsg; //资源错误信息
 }
objRow[conEduMSTRGiftedClsCase.ResourceNum] = objEduMSTRGiftedClsCaseEN.ResourceNum; //资源数
 if (objEduMSTRGiftedClsCaseEN.UpdDate !=  "")
 {
objRow[conEduMSTRGiftedClsCase.UpdDate] = objEduMSTRGiftedClsCaseEN.UpdDate; //修改日期
 }
 if (objEduMSTRGiftedClsCaseEN.UpdUserId !=  "")
 {
objRow[conEduMSTRGiftedClsCase.UpdUserId] = objEduMSTRGiftedClsCaseEN.UpdUserId; //修改用户Id
 }
 if (objEduMSTRGiftedClsCaseEN.Memo !=  "")
 {
objRow[conEduMSTRGiftedClsCase.Memo] = objEduMSTRGiftedClsCaseEN.Memo; //备注
 }
objDS.Tables[clsEduMSTRGiftedClsCaseEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsEduMSTRGiftedClsCaseEN._CurrTabName);
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
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN)
{
 objEduMSTRGiftedClsCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objEduMSTRGiftedClsCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objEduMSTRGiftedClsCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase);
 var strIdEduMSTRGiftedClsCase = objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEduMSTRGiftedClsCase + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID);
 var strEduMSTRGiftedClsCaseID = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduMSTRGiftedClsCaseID + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName);
 var strEduMSTRGiftedClsCaseName = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduMSTRGiftedClsCaseName + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme);
 var strEduMSTRGiftedClsCaseTheme = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduMSTRGiftedClsCaseTheme + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate);
 var strEduMSTRGiftedClsCaseDate = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduMSTRGiftedClsCaseDate + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime);
 var strEduMSTRGiftedClsCaseTime = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduMSTRGiftedClsCaseTime + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn);
 var strEduMSTRGiftedClsCaseDateIn = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduMSTRGiftedClsCaseDateIn + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.IdStudyLevel  ==  "")
 {
 objEduMSTRGiftedClsCaseEN.IdStudyLevel = null;
 }
 if (objEduMSTRGiftedClsCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IdStudyLevel);
 var strIdStudyLevel = objEduMSTRGiftedClsCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IdTeachingPlan);
 var strIdTeachingPlan = objEduMSTRGiftedClsCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn);
 var strEduMSTRGiftedClsCaseTimeIn = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduMSTRGiftedClsCaseTimeIn + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType);
 var strIdEduMSTRGiftedClsCaseType = objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEduMSTRGiftedClsCaseType + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.IdCaseType  ==  "")
 {
 objEduMSTRGiftedClsCaseEN.IdCaseType = null;
 }
 if (objEduMSTRGiftedClsCaseEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IdCaseType);
 var strIdCaseType = objEduMSTRGiftedClsCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IdDiscipline);
 var strIdDiscipline = objEduMSTRGiftedClsCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.BrowseCount);
 arrValueListForInsert.Add(objEduMSTRGiftedClsCaseEN.BrowseCount.ToString());
 }
 
 if (objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion = null;
 }
 if (objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IdTeachSkill);
 var strIdTeachSkill = objEduMSTRGiftedClsCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.CaseLevelId);
 var strCaseLevelId = objEduMSTRGiftedClsCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.DocFile);
 var strDocFile = objEduMSTRGiftedClsCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objEduMSTRGiftedClsCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objEduMSTRGiftedClsCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.WordCreateDate);
 var strWordCreateDate = objEduMSTRGiftedClsCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IsVisible);
 arrValueListForInsert.Add("'" + (objEduMSTRGiftedClsCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText);
 var strEduMSTRGiftedClsCaseText = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduMSTRGiftedClsCaseText + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.OwnerId);
 var strOwnerId = objEduMSTRGiftedClsCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objEduMSTRGiftedClsCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objEduMSTRGiftedClsCaseEN.UserKindId !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.UserKindId);
 var strUserKindId = objEduMSTRGiftedClsCaseEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserKindId + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.UserTypeId);
 var strUserTypeId = objEduMSTRGiftedClsCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objEduMSTRGiftedClsCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.ftpFileType);
 var strftpFileType = objEduMSTRGiftedClsCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.VideoUrl);
 var strVideoUrl = objEduMSTRGiftedClsCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.VideoPath);
 var strVideoPath = objEduMSTRGiftedClsCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.ResErrMsg);
 var strResErrMsg = objEduMSTRGiftedClsCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.ResourceNum !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.ResourceNum);
 arrValueListForInsert.Add(objEduMSTRGiftedClsCaseEN.ResourceNum.ToString());
 }
 
 if (objEduMSTRGiftedClsCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.UpdDate);
 var strUpdDate = objEduMSTRGiftedClsCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.UpdUserId);
 var strUpdUserId = objEduMSTRGiftedClsCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.Memo);
 var strMemo = objEduMSTRGiftedClsCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into EduMSTRGiftedClsCase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN)
{
 objEduMSTRGiftedClsCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objEduMSTRGiftedClsCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objEduMSTRGiftedClsCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase);
 var strIdEduMSTRGiftedClsCase = objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEduMSTRGiftedClsCase + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID);
 var strEduMSTRGiftedClsCaseID = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduMSTRGiftedClsCaseID + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName);
 var strEduMSTRGiftedClsCaseName = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduMSTRGiftedClsCaseName + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme);
 var strEduMSTRGiftedClsCaseTheme = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduMSTRGiftedClsCaseTheme + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate);
 var strEduMSTRGiftedClsCaseDate = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduMSTRGiftedClsCaseDate + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime);
 var strEduMSTRGiftedClsCaseTime = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduMSTRGiftedClsCaseTime + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn);
 var strEduMSTRGiftedClsCaseDateIn = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduMSTRGiftedClsCaseDateIn + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.IdStudyLevel  ==  "")
 {
 objEduMSTRGiftedClsCaseEN.IdStudyLevel = null;
 }
 if (objEduMSTRGiftedClsCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IdStudyLevel);
 var strIdStudyLevel = objEduMSTRGiftedClsCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IdTeachingPlan);
 var strIdTeachingPlan = objEduMSTRGiftedClsCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn);
 var strEduMSTRGiftedClsCaseTimeIn = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduMSTRGiftedClsCaseTimeIn + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType);
 var strIdEduMSTRGiftedClsCaseType = objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEduMSTRGiftedClsCaseType + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.IdCaseType  ==  "")
 {
 objEduMSTRGiftedClsCaseEN.IdCaseType = null;
 }
 if (objEduMSTRGiftedClsCaseEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IdCaseType);
 var strIdCaseType = objEduMSTRGiftedClsCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IdDiscipline);
 var strIdDiscipline = objEduMSTRGiftedClsCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.BrowseCount);
 arrValueListForInsert.Add(objEduMSTRGiftedClsCaseEN.BrowseCount.ToString());
 }
 
 if (objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion = null;
 }
 if (objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IdTeachSkill);
 var strIdTeachSkill = objEduMSTRGiftedClsCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.CaseLevelId);
 var strCaseLevelId = objEduMSTRGiftedClsCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.DocFile);
 var strDocFile = objEduMSTRGiftedClsCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objEduMSTRGiftedClsCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objEduMSTRGiftedClsCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.WordCreateDate);
 var strWordCreateDate = objEduMSTRGiftedClsCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IsVisible);
 arrValueListForInsert.Add("'" + (objEduMSTRGiftedClsCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText);
 var strEduMSTRGiftedClsCaseText = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduMSTRGiftedClsCaseText + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.OwnerId);
 var strOwnerId = objEduMSTRGiftedClsCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objEduMSTRGiftedClsCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objEduMSTRGiftedClsCaseEN.UserKindId !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.UserKindId);
 var strUserKindId = objEduMSTRGiftedClsCaseEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserKindId + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.UserTypeId);
 var strUserTypeId = objEduMSTRGiftedClsCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objEduMSTRGiftedClsCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.ftpFileType);
 var strftpFileType = objEduMSTRGiftedClsCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.VideoUrl);
 var strVideoUrl = objEduMSTRGiftedClsCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.VideoPath);
 var strVideoPath = objEduMSTRGiftedClsCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.ResErrMsg);
 var strResErrMsg = objEduMSTRGiftedClsCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.ResourceNum !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.ResourceNum);
 arrValueListForInsert.Add(objEduMSTRGiftedClsCaseEN.ResourceNum.ToString());
 }
 
 if (objEduMSTRGiftedClsCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.UpdDate);
 var strUpdDate = objEduMSTRGiftedClsCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.UpdUserId);
 var strUpdUserId = objEduMSTRGiftedClsCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.Memo);
 var strMemo = objEduMSTRGiftedClsCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into EduMSTRGiftedClsCase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objEduMSTRGiftedClsCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objEduMSTRGiftedClsCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objEduMSTRGiftedClsCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase);
 var strIdEduMSTRGiftedClsCase = objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEduMSTRGiftedClsCase + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID);
 var strEduMSTRGiftedClsCaseID = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduMSTRGiftedClsCaseID + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName);
 var strEduMSTRGiftedClsCaseName = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduMSTRGiftedClsCaseName + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme);
 var strEduMSTRGiftedClsCaseTheme = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduMSTRGiftedClsCaseTheme + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate);
 var strEduMSTRGiftedClsCaseDate = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduMSTRGiftedClsCaseDate + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime);
 var strEduMSTRGiftedClsCaseTime = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduMSTRGiftedClsCaseTime + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn);
 var strEduMSTRGiftedClsCaseDateIn = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduMSTRGiftedClsCaseDateIn + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.IdStudyLevel  ==  "")
 {
 objEduMSTRGiftedClsCaseEN.IdStudyLevel = null;
 }
 if (objEduMSTRGiftedClsCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IdStudyLevel);
 var strIdStudyLevel = objEduMSTRGiftedClsCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IdTeachingPlan);
 var strIdTeachingPlan = objEduMSTRGiftedClsCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn);
 var strEduMSTRGiftedClsCaseTimeIn = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduMSTRGiftedClsCaseTimeIn + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType);
 var strIdEduMSTRGiftedClsCaseType = objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEduMSTRGiftedClsCaseType + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.IdCaseType  ==  "")
 {
 objEduMSTRGiftedClsCaseEN.IdCaseType = null;
 }
 if (objEduMSTRGiftedClsCaseEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IdCaseType);
 var strIdCaseType = objEduMSTRGiftedClsCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IdDiscipline);
 var strIdDiscipline = objEduMSTRGiftedClsCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.BrowseCount);
 arrValueListForInsert.Add(objEduMSTRGiftedClsCaseEN.BrowseCount.ToString());
 }
 
 if (objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion = null;
 }
 if (objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IdTeachSkill);
 var strIdTeachSkill = objEduMSTRGiftedClsCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.CaseLevelId);
 var strCaseLevelId = objEduMSTRGiftedClsCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.DocFile);
 var strDocFile = objEduMSTRGiftedClsCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objEduMSTRGiftedClsCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objEduMSTRGiftedClsCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.WordCreateDate);
 var strWordCreateDate = objEduMSTRGiftedClsCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IsVisible);
 arrValueListForInsert.Add("'" + (objEduMSTRGiftedClsCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText);
 var strEduMSTRGiftedClsCaseText = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduMSTRGiftedClsCaseText + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.OwnerId);
 var strOwnerId = objEduMSTRGiftedClsCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objEduMSTRGiftedClsCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objEduMSTRGiftedClsCaseEN.UserKindId !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.UserKindId);
 var strUserKindId = objEduMSTRGiftedClsCaseEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserKindId + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.UserTypeId);
 var strUserTypeId = objEduMSTRGiftedClsCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objEduMSTRGiftedClsCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.ftpFileType);
 var strftpFileType = objEduMSTRGiftedClsCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.VideoUrl);
 var strVideoUrl = objEduMSTRGiftedClsCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.VideoPath);
 var strVideoPath = objEduMSTRGiftedClsCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.ResErrMsg);
 var strResErrMsg = objEduMSTRGiftedClsCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.ResourceNum !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.ResourceNum);
 arrValueListForInsert.Add(objEduMSTRGiftedClsCaseEN.ResourceNum.ToString());
 }
 
 if (objEduMSTRGiftedClsCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.UpdDate);
 var strUpdDate = objEduMSTRGiftedClsCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.UpdUserId);
 var strUpdUserId = objEduMSTRGiftedClsCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.Memo);
 var strMemo = objEduMSTRGiftedClsCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into EduMSTRGiftedClsCase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objEduMSTRGiftedClsCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objEduMSTRGiftedClsCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objEduMSTRGiftedClsCaseEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase);
 var strIdEduMSTRGiftedClsCase = objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEduMSTRGiftedClsCase + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID);
 var strEduMSTRGiftedClsCaseID = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduMSTRGiftedClsCaseID + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName);
 var strEduMSTRGiftedClsCaseName = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduMSTRGiftedClsCaseName + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme);
 var strEduMSTRGiftedClsCaseTheme = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduMSTRGiftedClsCaseTheme + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate);
 var strEduMSTRGiftedClsCaseDate = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduMSTRGiftedClsCaseDate + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime);
 var strEduMSTRGiftedClsCaseTime = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduMSTRGiftedClsCaseTime + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn);
 var strEduMSTRGiftedClsCaseDateIn = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduMSTRGiftedClsCaseDateIn + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.IdStudyLevel  ==  "")
 {
 objEduMSTRGiftedClsCaseEN.IdStudyLevel = null;
 }
 if (objEduMSTRGiftedClsCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IdStudyLevel);
 var strIdStudyLevel = objEduMSTRGiftedClsCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IdTeachingPlan);
 var strIdTeachingPlan = objEduMSTRGiftedClsCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn);
 var strEduMSTRGiftedClsCaseTimeIn = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduMSTRGiftedClsCaseTimeIn + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType);
 var strIdEduMSTRGiftedClsCaseType = objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEduMSTRGiftedClsCaseType + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.IdCaseType  ==  "")
 {
 objEduMSTRGiftedClsCaseEN.IdCaseType = null;
 }
 if (objEduMSTRGiftedClsCaseEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IdCaseType);
 var strIdCaseType = objEduMSTRGiftedClsCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IdDiscipline);
 var strIdDiscipline = objEduMSTRGiftedClsCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.BrowseCount);
 arrValueListForInsert.Add(objEduMSTRGiftedClsCaseEN.BrowseCount.ToString());
 }
 
 if (objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion = null;
 }
 if (objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IdTeachSkill);
 var strIdTeachSkill = objEduMSTRGiftedClsCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.CaseLevelId);
 var strCaseLevelId = objEduMSTRGiftedClsCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.DocFile);
 var strDocFile = objEduMSTRGiftedClsCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objEduMSTRGiftedClsCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objEduMSTRGiftedClsCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.WordCreateDate);
 var strWordCreateDate = objEduMSTRGiftedClsCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IsVisible);
 arrValueListForInsert.Add("'" + (objEduMSTRGiftedClsCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText);
 var strEduMSTRGiftedClsCaseText = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduMSTRGiftedClsCaseText + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.OwnerId);
 var strOwnerId = objEduMSTRGiftedClsCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objEduMSTRGiftedClsCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objEduMSTRGiftedClsCaseEN.UserKindId !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.UserKindId);
 var strUserKindId = objEduMSTRGiftedClsCaseEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserKindId + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.UserTypeId);
 var strUserTypeId = objEduMSTRGiftedClsCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objEduMSTRGiftedClsCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.ftpFileType);
 var strftpFileType = objEduMSTRGiftedClsCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.VideoUrl);
 var strVideoUrl = objEduMSTRGiftedClsCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.VideoPath);
 var strVideoPath = objEduMSTRGiftedClsCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.ResErrMsg);
 var strResErrMsg = objEduMSTRGiftedClsCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.ResourceNum !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.ResourceNum);
 arrValueListForInsert.Add(objEduMSTRGiftedClsCaseEN.ResourceNum.ToString());
 }
 
 if (objEduMSTRGiftedClsCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.UpdDate);
 var strUpdDate = objEduMSTRGiftedClsCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.UpdUserId);
 var strUpdUserId = objEduMSTRGiftedClsCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objEduMSTRGiftedClsCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conEduMSTRGiftedClsCase.Memo);
 var strMemo = objEduMSTRGiftedClsCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into EduMSTRGiftedClsCase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewEduMSTRGiftedClsCases(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
strSQL = "Select * from EduMSTRGiftedClsCase where IdEduMSTRGiftedClsCase = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "EduMSTRGiftedClsCase");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdEduMSTRGiftedClsCase = oRow[conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase].ToString().Trim();
if (IsExist(strIdEduMSTRGiftedClsCase))
{
 string strResult = "关键字变量值为:" + string.Format("IdEduMSTRGiftedClsCase = {0}", strIdEduMSTRGiftedClsCase) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsEduMSTRGiftedClsCaseEN._CurrTabName ].NewRow();
objRow[conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase] = oRow[conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID] = oRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName] = oRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme] = oRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate] = oRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime] = oRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn] = oRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objRow[conEduMSTRGiftedClsCase.IdStudyLevel] = oRow[conEduMSTRGiftedClsCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objRow[conEduMSTRGiftedClsCase.IdTeachingPlan] = oRow[conEduMSTRGiftedClsCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn] = oRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objRow[conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType] = oRow[conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objRow[conEduMSTRGiftedClsCase.IdCaseType] = oRow[conEduMSTRGiftedClsCase.IdCaseType].ToString().Trim(); //案例类型流水号
objRow[conEduMSTRGiftedClsCase.IdDiscipline] = oRow[conEduMSTRGiftedClsCase.IdDiscipline].ToString().Trim(); //学科流水号
objRow[conEduMSTRGiftedClsCase.BrowseCount] = oRow[conEduMSTRGiftedClsCase.BrowseCount].ToString().Trim(); //浏览次数
objRow[conEduMSTRGiftedClsCase.IdSenateGaugeVersion] = oRow[conEduMSTRGiftedClsCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objRow[conEduMSTRGiftedClsCase.IdTeachSkill] = oRow[conEduMSTRGiftedClsCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objRow[conEduMSTRGiftedClsCase.CaseLevelId] = oRow[conEduMSTRGiftedClsCase.CaseLevelId].ToString().Trim(); //课例等级Id
objRow[conEduMSTRGiftedClsCase.DocFile] = oRow[conEduMSTRGiftedClsCase.DocFile].ToString().Trim(); //生成的Word文件名
objRow[conEduMSTRGiftedClsCase.IsNeedGeneWord] = oRow[conEduMSTRGiftedClsCase.IsNeedGeneWord].ToString().Trim(); //是否需要生成Word
objRow[conEduMSTRGiftedClsCase.WordCreateDate] = oRow[conEduMSTRGiftedClsCase.WordCreateDate].ToString().Trim(); //Word生成日期
objRow[conEduMSTRGiftedClsCase.IsVisible] = oRow[conEduMSTRGiftedClsCase.IsVisible].ToString().Trim(); //是否显示
objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText] = oRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objRow[conEduMSTRGiftedClsCase.OwnerId] = oRow[conEduMSTRGiftedClsCase.OwnerId].ToString().Trim(); //拥有者Id
objRow[conEduMSTRGiftedClsCase.IsDualVideo] = oRow[conEduMSTRGiftedClsCase.IsDualVideo].ToString().Trim(); //是否双视频
objRow[conEduMSTRGiftedClsCase.UserKindId] = oRow[conEduMSTRGiftedClsCase.UserKindId].ToString().Trim(); //用户类别Id
objRow[conEduMSTRGiftedClsCase.UserTypeId] = oRow[conEduMSTRGiftedClsCase.UserTypeId].ToString().Trim(); //用户类型Id
objRow[conEduMSTRGiftedClsCase.RecommendedDegreeId] = oRow[conEduMSTRGiftedClsCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objRow[conEduMSTRGiftedClsCase.ftpFileType] = oRow[conEduMSTRGiftedClsCase.ftpFileType].ToString().Trim(); //ftp文件类型
objRow[conEduMSTRGiftedClsCase.VideoUrl] = oRow[conEduMSTRGiftedClsCase.VideoUrl].ToString().Trim(); //视频Url
objRow[conEduMSTRGiftedClsCase.VideoPath] = oRow[conEduMSTRGiftedClsCase.VideoPath].ToString().Trim(); //视频目录
objRow[conEduMSTRGiftedClsCase.ResErrMsg] = oRow[conEduMSTRGiftedClsCase.ResErrMsg].ToString().Trim(); //资源错误信息
objRow[conEduMSTRGiftedClsCase.ResourceNum] = oRow[conEduMSTRGiftedClsCase.ResourceNum].ToString().Trim(); //资源数
objRow[conEduMSTRGiftedClsCase.UpdDate] = oRow[conEduMSTRGiftedClsCase.UpdDate].ToString().Trim(); //修改日期
objRow[conEduMSTRGiftedClsCase.UpdUserId] = oRow[conEduMSTRGiftedClsCase.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conEduMSTRGiftedClsCase.Memo] = oRow[conEduMSTRGiftedClsCase.Memo].ToString().Trim(); //备注
 objDS.Tables[clsEduMSTRGiftedClsCaseEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsEduMSTRGiftedClsCaseEN._CurrTabName);
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
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN)
{
 objEduMSTRGiftedClsCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objEduMSTRGiftedClsCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objEduMSTRGiftedClsCaseEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
strSQL = "Select * from EduMSTRGiftedClsCase where IdEduMSTRGiftedClsCase = " + "'"+ objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsEduMSTRGiftedClsCaseEN._CurrTabName);
if (objDS.Tables[clsEduMSTRGiftedClsCaseEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdEduMSTRGiftedClsCase = " + "'"+ objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase+"'");
return false;
}
objRow = objDS.Tables[clsEduMSTRGiftedClsCaseEN._CurrTabName].Rows[0];
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase))
 {
objRow[conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase] = objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase; //教育硕士优课案例流水号
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID))
 {
objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID] = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID; //教育硕士优课案例ID
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName))
 {
objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName] = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName; //教育硕士优课案例名称
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme))
 {
objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme] = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme; //教育硕士优课案例主题词
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate))
 {
objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate] = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate; //教育硕士优课案例日期
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime))
 {
objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime] = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime; //教育硕士优课案例时间
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn))
 {
objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn] = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn; //案例入库日期
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdStudyLevel))
 {
objRow[conEduMSTRGiftedClsCase.IdStudyLevel] = objEduMSTRGiftedClsCaseEN.IdStudyLevel; //id_StudyLevel
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdTeachingPlan))
 {
objRow[conEduMSTRGiftedClsCase.IdTeachingPlan] = objEduMSTRGiftedClsCaseEN.IdTeachingPlan; //教案流水号
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn))
 {
objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn] = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn; //案例入库时间
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType))
 {
objRow[conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType] = objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType; //教育硕士优课案例类型流水号
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdCaseType))
 {
objRow[conEduMSTRGiftedClsCase.IdCaseType] = objEduMSTRGiftedClsCaseEN.IdCaseType; //案例类型流水号
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdDiscipline))
 {
objRow[conEduMSTRGiftedClsCase.IdDiscipline] = objEduMSTRGiftedClsCaseEN.IdDiscipline; //学科流水号
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.BrowseCount))
 {
objRow[conEduMSTRGiftedClsCase.BrowseCount] = objEduMSTRGiftedClsCaseEN.BrowseCount; //浏览次数
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdSenateGaugeVersion))
 {
objRow[conEduMSTRGiftedClsCase.IdSenateGaugeVersion] = objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion; //评价量表版本流水号
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdTeachSkill))
 {
objRow[conEduMSTRGiftedClsCase.IdTeachSkill] = objEduMSTRGiftedClsCaseEN.IdTeachSkill; //教学技能流水号
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.CaseLevelId))
 {
objRow[conEduMSTRGiftedClsCase.CaseLevelId] = objEduMSTRGiftedClsCaseEN.CaseLevelId; //课例等级Id
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.DocFile))
 {
objRow[conEduMSTRGiftedClsCase.DocFile] = objEduMSTRGiftedClsCaseEN.DocFile; //生成的Word文件名
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IsNeedGeneWord))
 {
objRow[conEduMSTRGiftedClsCase.IsNeedGeneWord] = objEduMSTRGiftedClsCaseEN.IsNeedGeneWord; //是否需要生成Word
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.WordCreateDate))
 {
objRow[conEduMSTRGiftedClsCase.WordCreateDate] = objEduMSTRGiftedClsCaseEN.WordCreateDate; //Word生成日期
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IsVisible))
 {
objRow[conEduMSTRGiftedClsCase.IsVisible] = objEduMSTRGiftedClsCaseEN.IsVisible; //是否显示
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText))
 {
objRow[conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText] = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText; //教育硕士优课案例文本
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.OwnerId))
 {
objRow[conEduMSTRGiftedClsCase.OwnerId] = objEduMSTRGiftedClsCaseEN.OwnerId; //拥有者Id
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IsDualVideo))
 {
objRow[conEduMSTRGiftedClsCase.IsDualVideo] = objEduMSTRGiftedClsCaseEN.IsDualVideo; //是否双视频
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.UserKindId))
 {
objRow[conEduMSTRGiftedClsCase.UserKindId] = objEduMSTRGiftedClsCaseEN.UserKindId; //用户类别Id
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.UserTypeId))
 {
objRow[conEduMSTRGiftedClsCase.UserTypeId] = objEduMSTRGiftedClsCaseEN.UserTypeId; //用户类型Id
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.RecommendedDegreeId))
 {
objRow[conEduMSTRGiftedClsCase.RecommendedDegreeId] = objEduMSTRGiftedClsCaseEN.RecommendedDegreeId; //推荐度Id
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.ftpFileType))
 {
objRow[conEduMSTRGiftedClsCase.ftpFileType] = objEduMSTRGiftedClsCaseEN.ftpFileType; //ftp文件类型
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.VideoUrl))
 {
objRow[conEduMSTRGiftedClsCase.VideoUrl] = objEduMSTRGiftedClsCaseEN.VideoUrl; //视频Url
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.VideoPath))
 {
objRow[conEduMSTRGiftedClsCase.VideoPath] = objEduMSTRGiftedClsCaseEN.VideoPath; //视频目录
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.ResErrMsg))
 {
objRow[conEduMSTRGiftedClsCase.ResErrMsg] = objEduMSTRGiftedClsCaseEN.ResErrMsg; //资源错误信息
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.ResourceNum))
 {
objRow[conEduMSTRGiftedClsCase.ResourceNum] = objEduMSTRGiftedClsCaseEN.ResourceNum; //资源数
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.UpdDate))
 {
objRow[conEduMSTRGiftedClsCase.UpdDate] = objEduMSTRGiftedClsCaseEN.UpdDate; //修改日期
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.UpdUserId))
 {
objRow[conEduMSTRGiftedClsCase.UpdUserId] = objEduMSTRGiftedClsCaseEN.UpdUserId; //修改用户Id
 }
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.Memo))
 {
objRow[conEduMSTRGiftedClsCase.Memo] = objEduMSTRGiftedClsCaseEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsEduMSTRGiftedClsCaseEN._CurrTabName);
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
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN)
{
 objEduMSTRGiftedClsCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objEduMSTRGiftedClsCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objEduMSTRGiftedClsCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update EduMSTRGiftedClsCase Set ");
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID))
 {
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID !=  null)
 {
 var strEduMSTRGiftedClsCaseID = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEduMSTRGiftedClsCaseID, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID); //教育硕士优课案例ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID); //教育硕士优课案例ID
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName))
 {
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName !=  null)
 {
 var strEduMSTRGiftedClsCaseName = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEduMSTRGiftedClsCaseName, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName); //教育硕士优课案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName); //教育硕士优课案例名称
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme))
 {
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme !=  null)
 {
 var strEduMSTRGiftedClsCaseTheme = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEduMSTRGiftedClsCaseTheme, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme); //教育硕士优课案例主题词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme); //教育硕士优课案例主题词
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate))
 {
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate !=  null)
 {
 var strEduMSTRGiftedClsCaseDate = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEduMSTRGiftedClsCaseDate, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate); //教育硕士优课案例日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate); //教育硕士优课案例日期
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime))
 {
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime !=  null)
 {
 var strEduMSTRGiftedClsCaseTime = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEduMSTRGiftedClsCaseTime, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime); //教育硕士优课案例时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime); //教育硕士优课案例时间
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn))
 {
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn !=  null)
 {
 var strEduMSTRGiftedClsCaseDateIn = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEduMSTRGiftedClsCaseDateIn, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn); //案例入库日期
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdStudyLevel))
 {
 if (objEduMSTRGiftedClsCaseEN.IdStudyLevel  ==  "")
 {
 objEduMSTRGiftedClsCaseEN.IdStudyLevel = null;
 }
 if (objEduMSTRGiftedClsCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objEduMSTRGiftedClsCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudyLevel, conEduMSTRGiftedClsCase.IdStudyLevel); //id_StudyLevel
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.IdStudyLevel); //id_StudyLevel
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdTeachingPlan))
 {
 if (objEduMSTRGiftedClsCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objEduMSTRGiftedClsCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachingPlan, conEduMSTRGiftedClsCase.IdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.IdTeachingPlan); //教案流水号
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn))
 {
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn !=  null)
 {
 var strEduMSTRGiftedClsCaseTimeIn = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEduMSTRGiftedClsCaseTimeIn, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn); //案例入库时间
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType))
 {
 if (objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType !=  null)
 {
 var strIdEduMSTRGiftedClsCaseType = objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdEduMSTRGiftedClsCaseType, conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType); //教育硕士优课案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType); //教育硕士优课案例类型流水号
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdCaseType))
 {
 if (objEduMSTRGiftedClsCaseEN.IdCaseType  ==  "")
 {
 objEduMSTRGiftedClsCaseEN.IdCaseType = null;
 }
 if (objEduMSTRGiftedClsCaseEN.IdCaseType !=  null)
 {
 var strIdCaseType = objEduMSTRGiftedClsCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCaseType, conEduMSTRGiftedClsCase.IdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.IdCaseType); //案例类型流水号
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdDiscipline))
 {
 if (objEduMSTRGiftedClsCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objEduMSTRGiftedClsCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDiscipline, conEduMSTRGiftedClsCase.IdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.IdDiscipline); //学科流水号
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.BrowseCount))
 {
 if (objEduMSTRGiftedClsCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objEduMSTRGiftedClsCaseEN.BrowseCount, conEduMSTRGiftedClsCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.BrowseCount); //浏览次数
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdSenateGaugeVersion))
 {
 if (objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion = null;
 }
 if (objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSenateGaugeVersion, conEduMSTRGiftedClsCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdTeachSkill))
 {
 if (objEduMSTRGiftedClsCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objEduMSTRGiftedClsCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachSkill, conEduMSTRGiftedClsCase.IdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.IdTeachSkill); //教学技能流水号
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.CaseLevelId))
 {
 if (objEduMSTRGiftedClsCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objEduMSTRGiftedClsCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseLevelId, conEduMSTRGiftedClsCase.CaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.CaseLevelId); //课例等级Id
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.DocFile))
 {
 if (objEduMSTRGiftedClsCaseEN.DocFile !=  null)
 {
 var strDocFile = objEduMSTRGiftedClsCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDocFile, conEduMSTRGiftedClsCase.DocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.DocFile); //生成的Word文件名
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objEduMSTRGiftedClsCaseEN.IsNeedGeneWord == true?"1":"0", conEduMSTRGiftedClsCase.IsNeedGeneWord); //是否需要生成Word
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.WordCreateDate))
 {
 if (objEduMSTRGiftedClsCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objEduMSTRGiftedClsCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWordCreateDate, conEduMSTRGiftedClsCase.WordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.WordCreateDate); //Word生成日期
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objEduMSTRGiftedClsCaseEN.IsVisible == true?"1":"0", conEduMSTRGiftedClsCase.IsVisible); //是否显示
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText))
 {
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText !=  null)
 {
 var strEduMSTRGiftedClsCaseText = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEduMSTRGiftedClsCaseText, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText); //教育硕士优课案例文本
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText); //教育硕士优课案例文本
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.OwnerId))
 {
 if (objEduMSTRGiftedClsCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objEduMSTRGiftedClsCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conEduMSTRGiftedClsCase.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.OwnerId); //拥有者Id
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objEduMSTRGiftedClsCaseEN.IsDualVideo == true?"1":"0", conEduMSTRGiftedClsCase.IsDualVideo); //是否双视频
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.UserKindId))
 {
 if (objEduMSTRGiftedClsCaseEN.UserKindId !=  null)
 {
 var strUserKindId = objEduMSTRGiftedClsCaseEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserKindId, conEduMSTRGiftedClsCase.UserKindId); //用户类别Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.UserKindId); //用户类别Id
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.UserTypeId))
 {
 if (objEduMSTRGiftedClsCaseEN.UserTypeId !=  null)
 {
 var strUserTypeId = objEduMSTRGiftedClsCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserTypeId, conEduMSTRGiftedClsCase.UserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.UserTypeId); //用户类型Id
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.RecommendedDegreeId))
 {
 if (objEduMSTRGiftedClsCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objEduMSTRGiftedClsCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecommendedDegreeId, conEduMSTRGiftedClsCase.RecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.RecommendedDegreeId); //推荐度Id
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.ftpFileType))
 {
 if (objEduMSTRGiftedClsCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objEduMSTRGiftedClsCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strftpFileType, conEduMSTRGiftedClsCase.ftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.ftpFileType); //ftp文件类型
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.VideoUrl))
 {
 if (objEduMSTRGiftedClsCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objEduMSTRGiftedClsCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoUrl, conEduMSTRGiftedClsCase.VideoUrl); //视频Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.VideoUrl); //视频Url
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.VideoPath))
 {
 if (objEduMSTRGiftedClsCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objEduMSTRGiftedClsCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoPath, conEduMSTRGiftedClsCase.VideoPath); //视频目录
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.VideoPath); //视频目录
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.ResErrMsg))
 {
 if (objEduMSTRGiftedClsCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objEduMSTRGiftedClsCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResErrMsg, conEduMSTRGiftedClsCase.ResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.ResErrMsg); //资源错误信息
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.ResourceNum))
 {
 if (objEduMSTRGiftedClsCaseEN.ResourceNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objEduMSTRGiftedClsCaseEN.ResourceNum, conEduMSTRGiftedClsCase.ResourceNum); //资源数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.ResourceNum); //资源数
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.UpdDate))
 {
 if (objEduMSTRGiftedClsCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objEduMSTRGiftedClsCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conEduMSTRGiftedClsCase.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.UpdDate); //修改日期
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.UpdUserId))
 {
 if (objEduMSTRGiftedClsCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objEduMSTRGiftedClsCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conEduMSTRGiftedClsCase.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.UpdUserId); //修改用户Id
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.Memo))
 {
 if (objEduMSTRGiftedClsCaseEN.Memo !=  null)
 {
 var strMemo = objEduMSTRGiftedClsCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conEduMSTRGiftedClsCase.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdEduMSTRGiftedClsCase = '{0}'", objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase); 
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
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strCondition)
{
 objEduMSTRGiftedClsCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objEduMSTRGiftedClsCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objEduMSTRGiftedClsCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update EduMSTRGiftedClsCase Set ");
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID))
 {
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID !=  null)
 {
 var strEduMSTRGiftedClsCaseID = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EduMSTRGiftedClsCaseID = '{0}',", strEduMSTRGiftedClsCaseID); //教育硕士优课案例ID
 }
 else
 {
 sbSQL.Append(" EduMSTRGiftedClsCaseID = null,"); //教育硕士优课案例ID
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName))
 {
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName !=  null)
 {
 var strEduMSTRGiftedClsCaseName = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EduMSTRGiftedClsCaseName = '{0}',", strEduMSTRGiftedClsCaseName); //教育硕士优课案例名称
 }
 else
 {
 sbSQL.Append(" EduMSTRGiftedClsCaseName = null,"); //教育硕士优课案例名称
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme))
 {
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme !=  null)
 {
 var strEduMSTRGiftedClsCaseTheme = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EduMSTRGiftedClsCaseTheme = '{0}',", strEduMSTRGiftedClsCaseTheme); //教育硕士优课案例主题词
 }
 else
 {
 sbSQL.Append(" EduMSTRGiftedClsCaseTheme = null,"); //教育硕士优课案例主题词
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate))
 {
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate !=  null)
 {
 var strEduMSTRGiftedClsCaseDate = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EduMSTRGiftedClsCaseDate = '{0}',", strEduMSTRGiftedClsCaseDate); //教育硕士优课案例日期
 }
 else
 {
 sbSQL.Append(" EduMSTRGiftedClsCaseDate = null,"); //教育硕士优课案例日期
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime))
 {
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime !=  null)
 {
 var strEduMSTRGiftedClsCaseTime = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EduMSTRGiftedClsCaseTime = '{0}',", strEduMSTRGiftedClsCaseTime); //教育硕士优课案例时间
 }
 else
 {
 sbSQL.Append(" EduMSTRGiftedClsCaseTime = null,"); //教育硕士优课案例时间
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn))
 {
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn !=  null)
 {
 var strEduMSTRGiftedClsCaseDateIn = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EduMSTRGiftedClsCaseDateIn = '{0}',", strEduMSTRGiftedClsCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.Append(" EduMSTRGiftedClsCaseDateIn = null,"); //案例入库日期
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdStudyLevel))
 {
 if (objEduMSTRGiftedClsCaseEN.IdStudyLevel  ==  "")
 {
 objEduMSTRGiftedClsCaseEN.IdStudyLevel = null;
 }
 if (objEduMSTRGiftedClsCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objEduMSTRGiftedClsCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudyLevel = '{0}',", strIdStudyLevel); //id_StudyLevel
 }
 else
 {
 sbSQL.Append(" IdStudyLevel = null,"); //id_StudyLevel
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdTeachingPlan))
 {
 if (objEduMSTRGiftedClsCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objEduMSTRGiftedClsCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachingPlan = '{0}',", strIdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.Append(" IdTeachingPlan = null,"); //教案流水号
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn))
 {
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn !=  null)
 {
 var strEduMSTRGiftedClsCaseTimeIn = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EduMSTRGiftedClsCaseTimeIn = '{0}',", strEduMSTRGiftedClsCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.Append(" EduMSTRGiftedClsCaseTimeIn = null,"); //案例入库时间
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType))
 {
 if (objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType !=  null)
 {
 var strIdEduMSTRGiftedClsCaseType = objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdEduMSTRGiftedClsCaseType = '{0}',", strIdEduMSTRGiftedClsCaseType); //教育硕士优课案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdEduMSTRGiftedClsCaseType = null,"); //教育硕士优课案例类型流水号
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdCaseType))
 {
 if (objEduMSTRGiftedClsCaseEN.IdCaseType  ==  "")
 {
 objEduMSTRGiftedClsCaseEN.IdCaseType = null;
 }
 if (objEduMSTRGiftedClsCaseEN.IdCaseType !=  null)
 {
 var strIdCaseType = objEduMSTRGiftedClsCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCaseType = '{0}',", strIdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdCaseType = null,"); //案例类型流水号
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdDiscipline))
 {
 if (objEduMSTRGiftedClsCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objEduMSTRGiftedClsCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDiscipline = '{0}',", strIdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.Append(" IdDiscipline = null,"); //学科流水号
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.BrowseCount))
 {
 sbSQL.AppendFormat(" BrowseCount = {0},", objEduMSTRGiftedClsCaseEN.BrowseCount); //浏览次数
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdSenateGaugeVersion))
 {
 if (objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion = null;
 }
 if (objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSenateGaugeVersion = '{0}',", strIdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdSenateGaugeVersion = null,"); //评价量表版本流水号
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdTeachSkill))
 {
 if (objEduMSTRGiftedClsCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objEduMSTRGiftedClsCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachSkill = '{0}',", strIdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.Append(" IdTeachSkill = null,"); //教学技能流水号
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.CaseLevelId))
 {
 if (objEduMSTRGiftedClsCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objEduMSTRGiftedClsCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseLevelId = '{0}',", strCaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.Append(" CaseLevelId = null,"); //课例等级Id
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.DocFile))
 {
 if (objEduMSTRGiftedClsCaseEN.DocFile !=  null)
 {
 var strDocFile = objEduMSTRGiftedClsCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DocFile = '{0}',", strDocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.Append(" DocFile = null,"); //生成的Word文件名
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" IsNeedGeneWord = '{0}',", objEduMSTRGiftedClsCaseEN.IsNeedGeneWord == true?"1":"0"); //是否需要生成Word
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.WordCreateDate))
 {
 if (objEduMSTRGiftedClsCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objEduMSTRGiftedClsCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WordCreateDate = '{0}',", strWordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.Append(" WordCreateDate = null,"); //Word生成日期
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objEduMSTRGiftedClsCaseEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText))
 {
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText !=  null)
 {
 var strEduMSTRGiftedClsCaseText = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EduMSTRGiftedClsCaseText = '{0}',", strEduMSTRGiftedClsCaseText); //教育硕士优课案例文本
 }
 else
 {
 sbSQL.Append(" EduMSTRGiftedClsCaseText = null,"); //教育硕士优课案例文本
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.OwnerId))
 {
 if (objEduMSTRGiftedClsCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objEduMSTRGiftedClsCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" IsDualVideo = '{0}',", objEduMSTRGiftedClsCaseEN.IsDualVideo == true?"1":"0"); //是否双视频
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.UserKindId))
 {
 if (objEduMSTRGiftedClsCaseEN.UserKindId !=  null)
 {
 var strUserKindId = objEduMSTRGiftedClsCaseEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserKindId = '{0}',", strUserKindId); //用户类别Id
 }
 else
 {
 sbSQL.Append(" UserKindId = null,"); //用户类别Id
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.UserTypeId))
 {
 if (objEduMSTRGiftedClsCaseEN.UserTypeId !=  null)
 {
 var strUserTypeId = objEduMSTRGiftedClsCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserTypeId = '{0}',", strUserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.Append(" UserTypeId = null,"); //用户类型Id
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.RecommendedDegreeId))
 {
 if (objEduMSTRGiftedClsCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objEduMSTRGiftedClsCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecommendedDegreeId = '{0}',", strRecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.Append(" RecommendedDegreeId = null,"); //推荐度Id
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.ftpFileType))
 {
 if (objEduMSTRGiftedClsCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objEduMSTRGiftedClsCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ftpFileType = '{0}',", strftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.Append(" ftpFileType = null,"); //ftp文件类型
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.VideoUrl))
 {
 if (objEduMSTRGiftedClsCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objEduMSTRGiftedClsCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoUrl = '{0}',", strVideoUrl); //视频Url
 }
 else
 {
 sbSQL.Append(" VideoUrl = null,"); //视频Url
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.VideoPath))
 {
 if (objEduMSTRGiftedClsCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objEduMSTRGiftedClsCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoPath = '{0}',", strVideoPath); //视频目录
 }
 else
 {
 sbSQL.Append(" VideoPath = null,"); //视频目录
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.ResErrMsg))
 {
 if (objEduMSTRGiftedClsCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objEduMSTRGiftedClsCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResErrMsg = '{0}',", strResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.Append(" ResErrMsg = null,"); //资源错误信息
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.ResourceNum))
 {
 sbSQL.AppendFormat(" ResourceNum = {0},", objEduMSTRGiftedClsCaseEN.ResourceNum); //资源数
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.UpdDate))
 {
 if (objEduMSTRGiftedClsCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objEduMSTRGiftedClsCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.UpdUserId))
 {
 if (objEduMSTRGiftedClsCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objEduMSTRGiftedClsCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.Memo))
 {
 if (objEduMSTRGiftedClsCaseEN.Memo !=  null)
 {
 var strMemo = objEduMSTRGiftedClsCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objEduMSTRGiftedClsCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objEduMSTRGiftedClsCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objEduMSTRGiftedClsCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update EduMSTRGiftedClsCase Set ");
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID))
 {
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID !=  null)
 {
 var strEduMSTRGiftedClsCaseID = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EduMSTRGiftedClsCaseID = '{0}',", strEduMSTRGiftedClsCaseID); //教育硕士优课案例ID
 }
 else
 {
 sbSQL.Append(" EduMSTRGiftedClsCaseID = null,"); //教育硕士优课案例ID
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName))
 {
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName !=  null)
 {
 var strEduMSTRGiftedClsCaseName = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EduMSTRGiftedClsCaseName = '{0}',", strEduMSTRGiftedClsCaseName); //教育硕士优课案例名称
 }
 else
 {
 sbSQL.Append(" EduMSTRGiftedClsCaseName = null,"); //教育硕士优课案例名称
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme))
 {
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme !=  null)
 {
 var strEduMSTRGiftedClsCaseTheme = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EduMSTRGiftedClsCaseTheme = '{0}',", strEduMSTRGiftedClsCaseTheme); //教育硕士优课案例主题词
 }
 else
 {
 sbSQL.Append(" EduMSTRGiftedClsCaseTheme = null,"); //教育硕士优课案例主题词
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate))
 {
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate !=  null)
 {
 var strEduMSTRGiftedClsCaseDate = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EduMSTRGiftedClsCaseDate = '{0}',", strEduMSTRGiftedClsCaseDate); //教育硕士优课案例日期
 }
 else
 {
 sbSQL.Append(" EduMSTRGiftedClsCaseDate = null,"); //教育硕士优课案例日期
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime))
 {
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime !=  null)
 {
 var strEduMSTRGiftedClsCaseTime = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EduMSTRGiftedClsCaseTime = '{0}',", strEduMSTRGiftedClsCaseTime); //教育硕士优课案例时间
 }
 else
 {
 sbSQL.Append(" EduMSTRGiftedClsCaseTime = null,"); //教育硕士优课案例时间
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn))
 {
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn !=  null)
 {
 var strEduMSTRGiftedClsCaseDateIn = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EduMSTRGiftedClsCaseDateIn = '{0}',", strEduMSTRGiftedClsCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.Append(" EduMSTRGiftedClsCaseDateIn = null,"); //案例入库日期
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdStudyLevel))
 {
 if (objEduMSTRGiftedClsCaseEN.IdStudyLevel  ==  "")
 {
 objEduMSTRGiftedClsCaseEN.IdStudyLevel = null;
 }
 if (objEduMSTRGiftedClsCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objEduMSTRGiftedClsCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudyLevel = '{0}',", strIdStudyLevel); //id_StudyLevel
 }
 else
 {
 sbSQL.Append(" IdStudyLevel = null,"); //id_StudyLevel
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdTeachingPlan))
 {
 if (objEduMSTRGiftedClsCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objEduMSTRGiftedClsCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachingPlan = '{0}',", strIdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.Append(" IdTeachingPlan = null,"); //教案流水号
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn))
 {
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn !=  null)
 {
 var strEduMSTRGiftedClsCaseTimeIn = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EduMSTRGiftedClsCaseTimeIn = '{0}',", strEduMSTRGiftedClsCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.Append(" EduMSTRGiftedClsCaseTimeIn = null,"); //案例入库时间
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType))
 {
 if (objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType !=  null)
 {
 var strIdEduMSTRGiftedClsCaseType = objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdEduMSTRGiftedClsCaseType = '{0}',", strIdEduMSTRGiftedClsCaseType); //教育硕士优课案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdEduMSTRGiftedClsCaseType = null,"); //教育硕士优课案例类型流水号
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdCaseType))
 {
 if (objEduMSTRGiftedClsCaseEN.IdCaseType  ==  "")
 {
 objEduMSTRGiftedClsCaseEN.IdCaseType = null;
 }
 if (objEduMSTRGiftedClsCaseEN.IdCaseType !=  null)
 {
 var strIdCaseType = objEduMSTRGiftedClsCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCaseType = '{0}',", strIdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdCaseType = null,"); //案例类型流水号
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdDiscipline))
 {
 if (objEduMSTRGiftedClsCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objEduMSTRGiftedClsCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDiscipline = '{0}',", strIdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.Append(" IdDiscipline = null,"); //学科流水号
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.BrowseCount))
 {
 sbSQL.AppendFormat(" BrowseCount = {0},", objEduMSTRGiftedClsCaseEN.BrowseCount); //浏览次数
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdSenateGaugeVersion))
 {
 if (objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion = null;
 }
 if (objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSenateGaugeVersion = '{0}',", strIdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdSenateGaugeVersion = null,"); //评价量表版本流水号
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdTeachSkill))
 {
 if (objEduMSTRGiftedClsCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objEduMSTRGiftedClsCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachSkill = '{0}',", strIdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.Append(" IdTeachSkill = null,"); //教学技能流水号
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.CaseLevelId))
 {
 if (objEduMSTRGiftedClsCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objEduMSTRGiftedClsCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseLevelId = '{0}',", strCaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.Append(" CaseLevelId = null,"); //课例等级Id
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.DocFile))
 {
 if (objEduMSTRGiftedClsCaseEN.DocFile !=  null)
 {
 var strDocFile = objEduMSTRGiftedClsCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DocFile = '{0}',", strDocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.Append(" DocFile = null,"); //生成的Word文件名
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" IsNeedGeneWord = '{0}',", objEduMSTRGiftedClsCaseEN.IsNeedGeneWord == true?"1":"0"); //是否需要生成Word
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.WordCreateDate))
 {
 if (objEduMSTRGiftedClsCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objEduMSTRGiftedClsCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WordCreateDate = '{0}',", strWordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.Append(" WordCreateDate = null,"); //Word生成日期
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objEduMSTRGiftedClsCaseEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText))
 {
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText !=  null)
 {
 var strEduMSTRGiftedClsCaseText = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EduMSTRGiftedClsCaseText = '{0}',", strEduMSTRGiftedClsCaseText); //教育硕士优课案例文本
 }
 else
 {
 sbSQL.Append(" EduMSTRGiftedClsCaseText = null,"); //教育硕士优课案例文本
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.OwnerId))
 {
 if (objEduMSTRGiftedClsCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objEduMSTRGiftedClsCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" IsDualVideo = '{0}',", objEduMSTRGiftedClsCaseEN.IsDualVideo == true?"1":"0"); //是否双视频
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.UserKindId))
 {
 if (objEduMSTRGiftedClsCaseEN.UserKindId !=  null)
 {
 var strUserKindId = objEduMSTRGiftedClsCaseEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserKindId = '{0}',", strUserKindId); //用户类别Id
 }
 else
 {
 sbSQL.Append(" UserKindId = null,"); //用户类别Id
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.UserTypeId))
 {
 if (objEduMSTRGiftedClsCaseEN.UserTypeId !=  null)
 {
 var strUserTypeId = objEduMSTRGiftedClsCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserTypeId = '{0}',", strUserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.Append(" UserTypeId = null,"); //用户类型Id
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.RecommendedDegreeId))
 {
 if (objEduMSTRGiftedClsCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objEduMSTRGiftedClsCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecommendedDegreeId = '{0}',", strRecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.Append(" RecommendedDegreeId = null,"); //推荐度Id
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.ftpFileType))
 {
 if (objEduMSTRGiftedClsCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objEduMSTRGiftedClsCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ftpFileType = '{0}',", strftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.Append(" ftpFileType = null,"); //ftp文件类型
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.VideoUrl))
 {
 if (objEduMSTRGiftedClsCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objEduMSTRGiftedClsCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoUrl = '{0}',", strVideoUrl); //视频Url
 }
 else
 {
 sbSQL.Append(" VideoUrl = null,"); //视频Url
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.VideoPath))
 {
 if (objEduMSTRGiftedClsCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objEduMSTRGiftedClsCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoPath = '{0}',", strVideoPath); //视频目录
 }
 else
 {
 sbSQL.Append(" VideoPath = null,"); //视频目录
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.ResErrMsg))
 {
 if (objEduMSTRGiftedClsCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objEduMSTRGiftedClsCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResErrMsg = '{0}',", strResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.Append(" ResErrMsg = null,"); //资源错误信息
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.ResourceNum))
 {
 sbSQL.AppendFormat(" ResourceNum = {0},", objEduMSTRGiftedClsCaseEN.ResourceNum); //资源数
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.UpdDate))
 {
 if (objEduMSTRGiftedClsCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objEduMSTRGiftedClsCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.UpdUserId))
 {
 if (objEduMSTRGiftedClsCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objEduMSTRGiftedClsCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.Memo))
 {
 if (objEduMSTRGiftedClsCaseEN.Memo !=  null)
 {
 var strMemo = objEduMSTRGiftedClsCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objEduMSTRGiftedClsCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objEduMSTRGiftedClsCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objEduMSTRGiftedClsCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objEduMSTRGiftedClsCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update EduMSTRGiftedClsCase Set ");
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID))
 {
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID !=  null)
 {
 var strEduMSTRGiftedClsCaseID = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEduMSTRGiftedClsCaseID, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID); //教育硕士优课案例ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID); //教育硕士优课案例ID
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName))
 {
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName !=  null)
 {
 var strEduMSTRGiftedClsCaseName = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEduMSTRGiftedClsCaseName, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName); //教育硕士优课案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName); //教育硕士优课案例名称
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme))
 {
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme !=  null)
 {
 var strEduMSTRGiftedClsCaseTheme = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEduMSTRGiftedClsCaseTheme, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme); //教育硕士优课案例主题词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme); //教育硕士优课案例主题词
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate))
 {
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate !=  null)
 {
 var strEduMSTRGiftedClsCaseDate = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEduMSTRGiftedClsCaseDate, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate); //教育硕士优课案例日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate); //教育硕士优课案例日期
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime))
 {
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime !=  null)
 {
 var strEduMSTRGiftedClsCaseTime = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEduMSTRGiftedClsCaseTime, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime); //教育硕士优课案例时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime); //教育硕士优课案例时间
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn))
 {
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn !=  null)
 {
 var strEduMSTRGiftedClsCaseDateIn = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEduMSTRGiftedClsCaseDateIn, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn); //案例入库日期
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdStudyLevel))
 {
 if (objEduMSTRGiftedClsCaseEN.IdStudyLevel  ==  "")
 {
 objEduMSTRGiftedClsCaseEN.IdStudyLevel = null;
 }
 if (objEduMSTRGiftedClsCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objEduMSTRGiftedClsCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudyLevel, conEduMSTRGiftedClsCase.IdStudyLevel); //id_StudyLevel
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.IdStudyLevel); //id_StudyLevel
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdTeachingPlan))
 {
 if (objEduMSTRGiftedClsCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objEduMSTRGiftedClsCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachingPlan, conEduMSTRGiftedClsCase.IdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.IdTeachingPlan); //教案流水号
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn))
 {
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn !=  null)
 {
 var strEduMSTRGiftedClsCaseTimeIn = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEduMSTRGiftedClsCaseTimeIn, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn); //案例入库时间
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType))
 {
 if (objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType !=  null)
 {
 var strIdEduMSTRGiftedClsCaseType = objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdEduMSTRGiftedClsCaseType, conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType); //教育硕士优课案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType); //教育硕士优课案例类型流水号
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdCaseType))
 {
 if (objEduMSTRGiftedClsCaseEN.IdCaseType  ==  "")
 {
 objEduMSTRGiftedClsCaseEN.IdCaseType = null;
 }
 if (objEduMSTRGiftedClsCaseEN.IdCaseType !=  null)
 {
 var strIdCaseType = objEduMSTRGiftedClsCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCaseType, conEduMSTRGiftedClsCase.IdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.IdCaseType); //案例类型流水号
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdDiscipline))
 {
 if (objEduMSTRGiftedClsCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objEduMSTRGiftedClsCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDiscipline, conEduMSTRGiftedClsCase.IdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.IdDiscipline); //学科流水号
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.BrowseCount))
 {
 if (objEduMSTRGiftedClsCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objEduMSTRGiftedClsCaseEN.BrowseCount, conEduMSTRGiftedClsCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.BrowseCount); //浏览次数
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdSenateGaugeVersion))
 {
 if (objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion = null;
 }
 if (objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSenateGaugeVersion, conEduMSTRGiftedClsCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IdTeachSkill))
 {
 if (objEduMSTRGiftedClsCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objEduMSTRGiftedClsCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachSkill, conEduMSTRGiftedClsCase.IdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.IdTeachSkill); //教学技能流水号
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.CaseLevelId))
 {
 if (objEduMSTRGiftedClsCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objEduMSTRGiftedClsCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseLevelId, conEduMSTRGiftedClsCase.CaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.CaseLevelId); //课例等级Id
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.DocFile))
 {
 if (objEduMSTRGiftedClsCaseEN.DocFile !=  null)
 {
 var strDocFile = objEduMSTRGiftedClsCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDocFile, conEduMSTRGiftedClsCase.DocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.DocFile); //生成的Word文件名
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objEduMSTRGiftedClsCaseEN.IsNeedGeneWord == true?"1":"0", conEduMSTRGiftedClsCase.IsNeedGeneWord); //是否需要生成Word
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.WordCreateDate))
 {
 if (objEduMSTRGiftedClsCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objEduMSTRGiftedClsCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWordCreateDate, conEduMSTRGiftedClsCase.WordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.WordCreateDate); //Word生成日期
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objEduMSTRGiftedClsCaseEN.IsVisible == true?"1":"0", conEduMSTRGiftedClsCase.IsVisible); //是否显示
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText))
 {
 if (objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText !=  null)
 {
 var strEduMSTRGiftedClsCaseText = objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEduMSTRGiftedClsCaseText, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText); //教育硕士优课案例文本
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText); //教育硕士优课案例文本
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.OwnerId))
 {
 if (objEduMSTRGiftedClsCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objEduMSTRGiftedClsCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conEduMSTRGiftedClsCase.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.OwnerId); //拥有者Id
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objEduMSTRGiftedClsCaseEN.IsDualVideo == true?"1":"0", conEduMSTRGiftedClsCase.IsDualVideo); //是否双视频
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.UserKindId))
 {
 if (objEduMSTRGiftedClsCaseEN.UserKindId !=  null)
 {
 var strUserKindId = objEduMSTRGiftedClsCaseEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserKindId, conEduMSTRGiftedClsCase.UserKindId); //用户类别Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.UserKindId); //用户类别Id
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.UserTypeId))
 {
 if (objEduMSTRGiftedClsCaseEN.UserTypeId !=  null)
 {
 var strUserTypeId = objEduMSTRGiftedClsCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserTypeId, conEduMSTRGiftedClsCase.UserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.UserTypeId); //用户类型Id
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.RecommendedDegreeId))
 {
 if (objEduMSTRGiftedClsCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objEduMSTRGiftedClsCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecommendedDegreeId, conEduMSTRGiftedClsCase.RecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.RecommendedDegreeId); //推荐度Id
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.ftpFileType))
 {
 if (objEduMSTRGiftedClsCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objEduMSTRGiftedClsCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strftpFileType, conEduMSTRGiftedClsCase.ftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.ftpFileType); //ftp文件类型
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.VideoUrl))
 {
 if (objEduMSTRGiftedClsCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objEduMSTRGiftedClsCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoUrl, conEduMSTRGiftedClsCase.VideoUrl); //视频Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.VideoUrl); //视频Url
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.VideoPath))
 {
 if (objEduMSTRGiftedClsCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objEduMSTRGiftedClsCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoPath, conEduMSTRGiftedClsCase.VideoPath); //视频目录
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.VideoPath); //视频目录
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.ResErrMsg))
 {
 if (objEduMSTRGiftedClsCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objEduMSTRGiftedClsCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResErrMsg, conEduMSTRGiftedClsCase.ResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.ResErrMsg); //资源错误信息
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.ResourceNum))
 {
 if (objEduMSTRGiftedClsCaseEN.ResourceNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objEduMSTRGiftedClsCaseEN.ResourceNum, conEduMSTRGiftedClsCase.ResourceNum); //资源数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.ResourceNum); //资源数
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.UpdDate))
 {
 if (objEduMSTRGiftedClsCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objEduMSTRGiftedClsCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conEduMSTRGiftedClsCase.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.UpdDate); //修改日期
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.UpdUserId))
 {
 if (objEduMSTRGiftedClsCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objEduMSTRGiftedClsCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conEduMSTRGiftedClsCase.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.UpdUserId); //修改用户Id
 }
 }
 
 if (objEduMSTRGiftedClsCaseEN.IsUpdated(conEduMSTRGiftedClsCase.Memo))
 {
 if (objEduMSTRGiftedClsCaseEN.Memo !=  null)
 {
 var strMemo = objEduMSTRGiftedClsCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conEduMSTRGiftedClsCase.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEduMSTRGiftedClsCase.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdEduMSTRGiftedClsCase = '{0}'", objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase); 
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
 /// <param name = "strIdEduMSTRGiftedClsCase">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdEduMSTRGiftedClsCase) 
{
CheckPrimaryKey(strIdEduMSTRGiftedClsCase);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdEduMSTRGiftedClsCase,
};
 objSQL.ExecSP("EduMSTRGiftedClsCase_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdEduMSTRGiftedClsCase">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdEduMSTRGiftedClsCase, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdEduMSTRGiftedClsCase);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
//删除EduMSTRGiftedClsCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from EduMSTRGiftedClsCase where IdEduMSTRGiftedClsCase = " + "'"+ strIdEduMSTRGiftedClsCase+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelEduMSTRGiftedClsCase(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
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
//删除EduMSTRGiftedClsCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from EduMSTRGiftedClsCase where IdEduMSTRGiftedClsCase in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdEduMSTRGiftedClsCase">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdEduMSTRGiftedClsCase) 
{
CheckPrimaryKey(strIdEduMSTRGiftedClsCase);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
//删除EduMSTRGiftedClsCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from EduMSTRGiftedClsCase where IdEduMSTRGiftedClsCase = " + "'"+ strIdEduMSTRGiftedClsCase+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelEduMSTRGiftedClsCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsEduMSTRGiftedClsCaseDA: DelEduMSTRGiftedClsCase)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from EduMSTRGiftedClsCase where " + strCondition ;
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
public bool DelEduMSTRGiftedClsCaseWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsEduMSTRGiftedClsCaseDA: DelEduMSTRGiftedClsCaseWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from EduMSTRGiftedClsCase where " + strCondition ;
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
 /// <param name = "objEduMSTRGiftedClsCaseENS">源对象</param>
 /// <param name = "objEduMSTRGiftedClsCaseENT">目标对象</param>
public void CopyTo(clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseENS, clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseENT)
{
objEduMSTRGiftedClsCaseENT.IdEduMSTRGiftedClsCase = objEduMSTRGiftedClsCaseENS.IdEduMSTRGiftedClsCase; //教育硕士优课案例流水号
objEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseID = objEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseID; //教育硕士优课案例ID
objEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseName = objEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseName; //教育硕士优课案例名称
objEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseTheme = objEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseTheme; //教育硕士优课案例主题词
objEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseDate = objEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseDate; //教育硕士优课案例日期
objEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseTime = objEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseTime; //教育硕士优课案例时间
objEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseDateIn = objEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseDateIn; //案例入库日期
objEduMSTRGiftedClsCaseENT.IdStudyLevel = objEduMSTRGiftedClsCaseENS.IdStudyLevel; //id_StudyLevel
objEduMSTRGiftedClsCaseENT.IdTeachingPlan = objEduMSTRGiftedClsCaseENS.IdTeachingPlan; //教案流水号
objEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseTimeIn = objEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseTimeIn; //案例入库时间
objEduMSTRGiftedClsCaseENT.IdEduMSTRGiftedClsCaseType = objEduMSTRGiftedClsCaseENS.IdEduMSTRGiftedClsCaseType; //教育硕士优课案例类型流水号
objEduMSTRGiftedClsCaseENT.IdCaseType = objEduMSTRGiftedClsCaseENS.IdCaseType; //案例类型流水号
objEduMSTRGiftedClsCaseENT.IdDiscipline = objEduMSTRGiftedClsCaseENS.IdDiscipline; //学科流水号
objEduMSTRGiftedClsCaseENT.BrowseCount = objEduMSTRGiftedClsCaseENS.BrowseCount; //浏览次数
objEduMSTRGiftedClsCaseENT.IdSenateGaugeVersion = objEduMSTRGiftedClsCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objEduMSTRGiftedClsCaseENT.IdTeachSkill = objEduMSTRGiftedClsCaseENS.IdTeachSkill; //教学技能流水号
objEduMSTRGiftedClsCaseENT.CaseLevelId = objEduMSTRGiftedClsCaseENS.CaseLevelId; //课例等级Id
objEduMSTRGiftedClsCaseENT.DocFile = objEduMSTRGiftedClsCaseENS.DocFile; //生成的Word文件名
objEduMSTRGiftedClsCaseENT.IsNeedGeneWord = objEduMSTRGiftedClsCaseENS.IsNeedGeneWord; //是否需要生成Word
objEduMSTRGiftedClsCaseENT.WordCreateDate = objEduMSTRGiftedClsCaseENS.WordCreateDate; //Word生成日期
objEduMSTRGiftedClsCaseENT.IsVisible = objEduMSTRGiftedClsCaseENS.IsVisible; //是否显示
objEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseText = objEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseText; //教育硕士优课案例文本
objEduMSTRGiftedClsCaseENT.OwnerId = objEduMSTRGiftedClsCaseENS.OwnerId; //拥有者Id
objEduMSTRGiftedClsCaseENT.IsDualVideo = objEduMSTRGiftedClsCaseENS.IsDualVideo; //是否双视频
objEduMSTRGiftedClsCaseENT.UserKindId = objEduMSTRGiftedClsCaseENS.UserKindId; //用户类别Id
objEduMSTRGiftedClsCaseENT.UserTypeId = objEduMSTRGiftedClsCaseENS.UserTypeId; //用户类型Id
objEduMSTRGiftedClsCaseENT.RecommendedDegreeId = objEduMSTRGiftedClsCaseENS.RecommendedDegreeId; //推荐度Id
objEduMSTRGiftedClsCaseENT.ftpFileType = objEduMSTRGiftedClsCaseENS.ftpFileType; //ftp文件类型
objEduMSTRGiftedClsCaseENT.VideoUrl = objEduMSTRGiftedClsCaseENS.VideoUrl; //视频Url
objEduMSTRGiftedClsCaseENT.VideoPath = objEduMSTRGiftedClsCaseENS.VideoPath; //视频目录
objEduMSTRGiftedClsCaseENT.ResErrMsg = objEduMSTRGiftedClsCaseENS.ResErrMsg; //资源错误信息
objEduMSTRGiftedClsCaseENT.ResourceNum = objEduMSTRGiftedClsCaseENS.ResourceNum; //资源数
objEduMSTRGiftedClsCaseENT.UpdDate = objEduMSTRGiftedClsCaseENS.UpdDate; //修改日期
objEduMSTRGiftedClsCaseENT.UpdUserId = objEduMSTRGiftedClsCaseENS.UpdUserId; //修改用户Id
objEduMSTRGiftedClsCaseENT.Memo = objEduMSTRGiftedClsCaseENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID);
clsCheckSql.CheckFieldNotNull(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName);
clsCheckSql.CheckFieldNotNull(objEduMSTRGiftedClsCaseEN.IdStudyLevel, conEduMSTRGiftedClsCase.IdStudyLevel);
clsCheckSql.CheckFieldNotNull(objEduMSTRGiftedClsCaseEN.IdDiscipline, conEduMSTRGiftedClsCase.IdDiscipline);
clsCheckSql.CheckFieldNotNull(objEduMSTRGiftedClsCaseEN.IdTeachSkill, conEduMSTRGiftedClsCase.IdTeachSkill);
clsCheckSql.CheckFieldNotNull(objEduMSTRGiftedClsCaseEN.OwnerId, conEduMSTRGiftedClsCase.OwnerId);
clsCheckSql.CheckFieldNotNull(objEduMSTRGiftedClsCaseEN.UserKindId, conEduMSTRGiftedClsCase.UserKindId);
clsCheckSql.CheckFieldNotNull(objEduMSTRGiftedClsCaseEN.RecommendedDegreeId, conEduMSTRGiftedClsCase.RecommendedDegreeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase, 8, conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID, 8, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName, 100, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme, 200, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate, 8, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime, 6, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn, 8, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.IdStudyLevel, 4, conEduMSTRGiftedClsCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.IdTeachingPlan, 8, conEduMSTRGiftedClsCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn, 6, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType, 4, conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.IdCaseType, 4, conEduMSTRGiftedClsCase.IdCaseType);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.IdDiscipline, 4, conEduMSTRGiftedClsCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion, 4, conEduMSTRGiftedClsCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.IdTeachSkill, 8, conEduMSTRGiftedClsCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.CaseLevelId, 2, conEduMSTRGiftedClsCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.DocFile, 200, conEduMSTRGiftedClsCase.DocFile);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.WordCreateDate, 14, conEduMSTRGiftedClsCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText, 8000, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.OwnerId, 20, conEduMSTRGiftedClsCase.OwnerId);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.UserKindId, 2, conEduMSTRGiftedClsCase.UserKindId);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.UserTypeId, 2, conEduMSTRGiftedClsCase.UserTypeId);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.RecommendedDegreeId, 2, conEduMSTRGiftedClsCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.ftpFileType, 30, conEduMSTRGiftedClsCase.ftpFileType);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.VideoUrl, 1000, conEduMSTRGiftedClsCase.VideoUrl);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.VideoPath, 1000, conEduMSTRGiftedClsCase.VideoPath);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.ResErrMsg, 30, conEduMSTRGiftedClsCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.UpdDate, 20, conEduMSTRGiftedClsCase.UpdDate);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.UpdUserId, 20, conEduMSTRGiftedClsCase.UpdUserId);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.Memo, 1000, conEduMSTRGiftedClsCase.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objEduMSTRGiftedClsCaseEN.IdStudyLevel, 4, conEduMSTRGiftedClsCase.IdStudyLevel);
clsCheckSql.CheckFieldForeignKey(objEduMSTRGiftedClsCaseEN.IdCaseType, 4, conEduMSTRGiftedClsCase.IdCaseType);
clsCheckSql.CheckFieldForeignKey(objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion, 4, conEduMSTRGiftedClsCase.IdSenateGaugeVersion);
 objEduMSTRGiftedClsCaseEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID, 8, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName, 100, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme, 200, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate, 8, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime, 6, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn, 8, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.IdStudyLevel, 4, conEduMSTRGiftedClsCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.IdTeachingPlan, 8, conEduMSTRGiftedClsCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn, 6, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType, 4, conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.IdCaseType, 4, conEduMSTRGiftedClsCase.IdCaseType);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.IdDiscipline, 4, conEduMSTRGiftedClsCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion, 4, conEduMSTRGiftedClsCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.IdTeachSkill, 8, conEduMSTRGiftedClsCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.CaseLevelId, 2, conEduMSTRGiftedClsCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.DocFile, 200, conEduMSTRGiftedClsCase.DocFile);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.WordCreateDate, 14, conEduMSTRGiftedClsCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText, 8000, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.OwnerId, 20, conEduMSTRGiftedClsCase.OwnerId);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.UserKindId, 2, conEduMSTRGiftedClsCase.UserKindId);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.UserTypeId, 2, conEduMSTRGiftedClsCase.UserTypeId);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.RecommendedDegreeId, 2, conEduMSTRGiftedClsCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.ftpFileType, 30, conEduMSTRGiftedClsCase.ftpFileType);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.VideoUrl, 1000, conEduMSTRGiftedClsCase.VideoUrl);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.VideoPath, 1000, conEduMSTRGiftedClsCase.VideoPath);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.ResErrMsg, 30, conEduMSTRGiftedClsCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.UpdDate, 20, conEduMSTRGiftedClsCase.UpdDate);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.UpdUserId, 20, conEduMSTRGiftedClsCase.UpdUserId);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.Memo, 1000, conEduMSTRGiftedClsCase.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objEduMSTRGiftedClsCaseEN.IdStudyLevel, 4, conEduMSTRGiftedClsCase.IdStudyLevel);
clsCheckSql.CheckFieldForeignKey(objEduMSTRGiftedClsCaseEN.IdCaseType, 4, conEduMSTRGiftedClsCase.IdCaseType);
clsCheckSql.CheckFieldForeignKey(objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion, 4, conEduMSTRGiftedClsCase.IdSenateGaugeVersion);
 objEduMSTRGiftedClsCaseEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsEduMSTRGiftedClsCaseEN objEduMSTRGiftedClsCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase, 8, conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID, 8, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName, 100, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme, 200, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate, 8, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime, 6, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn, 8, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.IdStudyLevel, 4, conEduMSTRGiftedClsCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.IdTeachingPlan, 8, conEduMSTRGiftedClsCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn, 6, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType, 4, conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.IdCaseType, 4, conEduMSTRGiftedClsCase.IdCaseType);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.IdDiscipline, 4, conEduMSTRGiftedClsCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion, 4, conEduMSTRGiftedClsCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.IdTeachSkill, 8, conEduMSTRGiftedClsCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.CaseLevelId, 2, conEduMSTRGiftedClsCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.DocFile, 200, conEduMSTRGiftedClsCase.DocFile);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.WordCreateDate, 14, conEduMSTRGiftedClsCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText, 8000, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.OwnerId, 20, conEduMSTRGiftedClsCase.OwnerId);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.UserKindId, 2, conEduMSTRGiftedClsCase.UserKindId);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.UserTypeId, 2, conEduMSTRGiftedClsCase.UserTypeId);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.RecommendedDegreeId, 2, conEduMSTRGiftedClsCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.ftpFileType, 30, conEduMSTRGiftedClsCase.ftpFileType);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.VideoUrl, 1000, conEduMSTRGiftedClsCase.VideoUrl);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.VideoPath, 1000, conEduMSTRGiftedClsCase.VideoPath);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.ResErrMsg, 30, conEduMSTRGiftedClsCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.UpdDate, 20, conEduMSTRGiftedClsCase.UpdDate);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.UpdUserId, 20, conEduMSTRGiftedClsCase.UpdUserId);
clsCheckSql.CheckFieldLen(objEduMSTRGiftedClsCaseEN.Memo, 1000, conEduMSTRGiftedClsCase.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase, conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase);
clsCheckSql.CheckSqlInjection4Field(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID);
clsCheckSql.CheckSqlInjection4Field(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName);
clsCheckSql.CheckSqlInjection4Field(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate);
clsCheckSql.CheckSqlInjection4Field(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime);
clsCheckSql.CheckSqlInjection4Field(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objEduMSTRGiftedClsCaseEN.IdStudyLevel, conEduMSTRGiftedClsCase.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objEduMSTRGiftedClsCaseEN.IdTeachingPlan, conEduMSTRGiftedClsCase.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType, conEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType);
clsCheckSql.CheckSqlInjection4Field(objEduMSTRGiftedClsCaseEN.IdCaseType, conEduMSTRGiftedClsCase.IdCaseType);
clsCheckSql.CheckSqlInjection4Field(objEduMSTRGiftedClsCaseEN.IdDiscipline, conEduMSTRGiftedClsCase.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion, conEduMSTRGiftedClsCase.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objEduMSTRGiftedClsCaseEN.IdTeachSkill, conEduMSTRGiftedClsCase.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objEduMSTRGiftedClsCaseEN.CaseLevelId, conEduMSTRGiftedClsCase.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objEduMSTRGiftedClsCaseEN.DocFile, conEduMSTRGiftedClsCase.DocFile);
clsCheckSql.CheckSqlInjection4Field(objEduMSTRGiftedClsCaseEN.WordCreateDate, conEduMSTRGiftedClsCase.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText, conEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText);
clsCheckSql.CheckSqlInjection4Field(objEduMSTRGiftedClsCaseEN.OwnerId, conEduMSTRGiftedClsCase.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objEduMSTRGiftedClsCaseEN.UserKindId, conEduMSTRGiftedClsCase.UserKindId);
clsCheckSql.CheckSqlInjection4Field(objEduMSTRGiftedClsCaseEN.UserTypeId, conEduMSTRGiftedClsCase.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objEduMSTRGiftedClsCaseEN.RecommendedDegreeId, conEduMSTRGiftedClsCase.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objEduMSTRGiftedClsCaseEN.ftpFileType, conEduMSTRGiftedClsCase.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objEduMSTRGiftedClsCaseEN.VideoUrl, conEduMSTRGiftedClsCase.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objEduMSTRGiftedClsCaseEN.VideoPath, conEduMSTRGiftedClsCase.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objEduMSTRGiftedClsCaseEN.ResErrMsg, conEduMSTRGiftedClsCase.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objEduMSTRGiftedClsCaseEN.UpdDate, conEduMSTRGiftedClsCase.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objEduMSTRGiftedClsCaseEN.UpdUserId, conEduMSTRGiftedClsCase.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objEduMSTRGiftedClsCaseEN.Memo, conEduMSTRGiftedClsCase.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objEduMSTRGiftedClsCaseEN.IdStudyLevel, 4, conEduMSTRGiftedClsCase.IdStudyLevel);
clsCheckSql.CheckFieldForeignKey(objEduMSTRGiftedClsCaseEN.IdCaseType, 4, conEduMSTRGiftedClsCase.IdCaseType);
clsCheckSql.CheckFieldForeignKey(objEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion, 4, conEduMSTRGiftedClsCase.IdSenateGaugeVersion);
 objEduMSTRGiftedClsCaseEN._IsCheckProperty = true;
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
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
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
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
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
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsEduMSTRGiftedClsCaseEN._CurrTabName);
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
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsEduMSTRGiftedClsCaseEN._CurrTabName, strCondition);
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
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
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
 objSQL = clsEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}