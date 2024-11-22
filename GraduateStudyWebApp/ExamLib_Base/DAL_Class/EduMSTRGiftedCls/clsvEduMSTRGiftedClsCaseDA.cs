
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvEduMSTRGiftedClsCaseDA
 表名:vEduMSTRGiftedClsCase(01120380)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:24:38
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
 /// v教育硕士优课案例(vEduMSTRGiftedClsCase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvEduMSTRGiftedClsCaseDA : clsCommBase4DA
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
 return clsvEduMSTRGiftedClsCaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvEduMSTRGiftedClsCaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvEduMSTRGiftedClsCaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvEduMSTRGiftedClsCaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvEduMSTRGiftedClsCaseEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vEduMSTRGiftedClsCase中,检查关键字,长度不正确!(clsvEduMSTRGiftedClsCaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdEduMSTRGiftedClsCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vEduMSTRGiftedClsCase中,关键字不能为空 或 null!(clsvEduMSTRGiftedClsCaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdEduMSTRGiftedClsCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvEduMSTRGiftedClsCaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vEduMSTRGiftedClsCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseDA: GetDataTable_vEduMSTRGiftedClsCase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vEduMSTRGiftedClsCase.* from vEduMSTRGiftedClsCase Left Join {1} on {2} where {3} and vEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase not in (Select top {5} vEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase from vEduMSTRGiftedClsCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCase where {1} and IdEduMSTRGiftedClsCase not in (Select top {2} IdEduMSTRGiftedClsCase from vEduMSTRGiftedClsCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCase where {1} and IdEduMSTRGiftedClsCase not in (Select top {3} IdEduMSTRGiftedClsCase from vEduMSTRGiftedClsCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vEduMSTRGiftedClsCase.* from vEduMSTRGiftedClsCase Left Join {1} on {2} where {3} and vEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase not in (Select top {5} vEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase from vEduMSTRGiftedClsCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCase where {1} and IdEduMSTRGiftedClsCase not in (Select top {2} IdEduMSTRGiftedClsCase from vEduMSTRGiftedClsCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCase where {1} and IdEduMSTRGiftedClsCase not in (Select top {3} IdEduMSTRGiftedClsCase from vEduMSTRGiftedClsCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvEduMSTRGiftedClsCaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseDA:GetObjLst)", objException.Message));
}
List<clsvEduMSTRGiftedClsCaseEN> arrObjLst = new List<clsvEduMSTRGiftedClsCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN = new clsvEduMSTRGiftedClsCaseEN();
try
{
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objvEduMSTRGiftedClsCaseEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvEduMSTRGiftedClsCaseEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase.StudyLevelName].ToString().Trim(); //学段名称
objvEduMSTRGiftedClsCaseEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeID = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID].ToString().Trim(); //教育硕士优课案例类型Id
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCaseEN.IdCaseType = objRow[convEduMSTRGiftedClsCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvEduMSTRGiftedClsCaseEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase.IdDiscipline].ToString().Trim(); //学科流水号
objvEduMSTRGiftedClsCaseEN.DisciplineID = objRow[convEduMSTRGiftedClsCase.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DisciplineID].ToString().Trim(); //学科ID
objvEduMSTRGiftedClsCaseEN.DisciplineName = objRow[convEduMSTRGiftedClsCase.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DisciplineName].ToString().Trim(); //学科名称
objvEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCaseEN.VersionNo = objRow[convEduMSTRGiftedClsCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase.VersionNo].ToString().Trim()); //版本号
objvEduMSTRGiftedClsCaseEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvEduMSTRGiftedClsCaseEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvEduMSTRGiftedClsCaseEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvEduMSTRGiftedClsCaseEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvEduMSTRGiftedClsCaseEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvEduMSTRGiftedClsCaseEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvEduMSTRGiftedClsCaseEN.IdSkillType = objRow[convEduMSTRGiftedClsCase.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvEduMSTRGiftedClsCaseEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvEduMSTRGiftedClsCaseEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvEduMSTRGiftedClsCaseEN.CaseLevelName = objRow[convEduMSTRGiftedClsCase.CaseLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvEduMSTRGiftedClsCaseEN.DocFile = objRow[convEduMSTRGiftedClsCase.DocFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DocFile].ToString().Trim(); //生成的Word文件名
objvEduMSTRGiftedClsCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convEduMSTRGiftedClsCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvEduMSTRGiftedClsCaseEN.WordCreateDate = objRow[convEduMSTRGiftedClsCase.WordCreateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvEduMSTRGiftedClsCaseEN.IsVisible = TransNullToBool(objRow[convEduMSTRGiftedClsCase.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objvEduMSTRGiftedClsCaseEN.OwnerId = objRow[convEduMSTRGiftedClsCase.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCaseEN.IdStudentInfo = objRow[convEduMSTRGiftedClsCase.IdStudentInfo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvEduMSTRGiftedClsCaseEN.StuName = objRow[convEduMSTRGiftedClsCase.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCaseEN.StuId = objRow[convEduMSTRGiftedClsCase.StuId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuId].ToString().Trim(); //学号
objvEduMSTRGiftedClsCaseEN.PoliticsName = objRow[convEduMSTRGiftedClsCase.PoliticsName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.PoliticsName].ToString().Trim(); //政治面貌
objvEduMSTRGiftedClsCaseEN.SexDesc = objRow[convEduMSTRGiftedClsCase.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SexDesc].ToString().Trim(); //性别名称
objvEduMSTRGiftedClsCaseEN.EthnicName = objRow[convEduMSTRGiftedClsCase.EthnicName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EthnicName].ToString().Trim(); //民族名称
objvEduMSTRGiftedClsCaseEN.UniZoneDesc = objRow[convEduMSTRGiftedClsCase.UniZoneDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UniZoneDesc].ToString().Trim(); //校区名称
objvEduMSTRGiftedClsCaseEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvEduMSTRGiftedClsCaseEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCaseEN.CollegeId = objRow[convEduMSTRGiftedClsCase.CollegeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CollegeId].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCaseEN.CollegeName = objRow[convEduMSTRGiftedClsCase.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCaseEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCaseEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdXzMajor].ToString().Trim(); //专业流水号
objvEduMSTRGiftedClsCaseEN.MajorName = objRow[convEduMSTRGiftedClsCase.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCaseEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase.IdGradeBase].ToString().Trim(); //年级流水号
objvEduMSTRGiftedClsCaseEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.GradeBaseName].ToString().Trim(); //年级名称
objvEduMSTRGiftedClsCaseEN.IdAdminCls = objRow[convEduMSTRGiftedClsCase.IdAdminCls] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvEduMSTRGiftedClsCaseEN.AdminClsId = objRow[convEduMSTRGiftedClsCase.AdminClsId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.AdminClsId].ToString().Trim(); //行政班代号
objvEduMSTRGiftedClsCaseEN.AdminClsName = objRow[convEduMSTRGiftedClsCase.AdminClsName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.AdminClsName].ToString().Trim(); //行政班名称
objvEduMSTRGiftedClsCaseEN.Birthday = objRow[convEduMSTRGiftedClsCase.Birthday] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Birthday].ToString().Trim(); //出生日期
objvEduMSTRGiftedClsCaseEN.NativePlace = objRow[convEduMSTRGiftedClsCase.NativePlace] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.NativePlace].ToString().Trim(); //籍贯
objvEduMSTRGiftedClsCaseEN.Duty = objRow[convEduMSTRGiftedClsCase.Duty] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Duty].ToString().Trim(); //职位
objvEduMSTRGiftedClsCaseEN.IdCardNo = objRow[convEduMSTRGiftedClsCase.IdCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdCardNo].ToString().Trim(); //身份证号
objvEduMSTRGiftedClsCaseEN.StuCardNo = objRow[convEduMSTRGiftedClsCase.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuCardNo].ToString().Trim(); //学生证号
objvEduMSTRGiftedClsCaseEN.LiveAddress = objRow[convEduMSTRGiftedClsCase.LiveAddress] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.LiveAddress].ToString().Trim(); //居住地址
objvEduMSTRGiftedClsCaseEN.HomePhone = objRow[convEduMSTRGiftedClsCase.HomePhone] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.HomePhone].ToString().Trim(); //住宅电话
objvEduMSTRGiftedClsCaseEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EnrollmentDate].ToString().Trim(); //入校日期
objvEduMSTRGiftedClsCaseEN.PostCode = objRow[convEduMSTRGiftedClsCase.PostCode] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.PostCode].ToString().Trim(); //邮编
objvEduMSTRGiftedClsCaseEN.IsDualVideo = TransNullToBool(objRow[convEduMSTRGiftedClsCase.IsDualVideo].ToString().Trim()); //是否双视频
objvEduMSTRGiftedClsCaseEN.UserKindId = objRow[convEduMSTRGiftedClsCase.UserKindId].ToString().Trim(); //用户类别Id
objvEduMSTRGiftedClsCaseEN.UserKindName = objRow[convEduMSTRGiftedClsCase.UserKindName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserKindName].ToString().Trim(); //用户类别名
objvEduMSTRGiftedClsCaseEN.UserTypeId = objRow[convEduMSTRGiftedClsCase.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCaseEN.UserTypeName = objRow[convEduMSTRGiftedClsCase.UserTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserTypeName].ToString().Trim(); //用户类型名称
objvEduMSTRGiftedClsCaseEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvEduMSTRGiftedClsCaseEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvEduMSTRGiftedClsCaseEN.ftpFileType = objRow[convEduMSTRGiftedClsCase.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCaseEN.VideoUrl = objRow[convEduMSTRGiftedClsCase.VideoUrl] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.VideoUrl].ToString().Trim(); //视频Url
objvEduMSTRGiftedClsCaseEN.VideoPath = objRow[convEduMSTRGiftedClsCase.VideoPath] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.VideoPath].ToString().Trim(); //视频目录
objvEduMSTRGiftedClsCaseEN.ResErrMsg = objRow[convEduMSTRGiftedClsCase.ResErrMsg] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvEduMSTRGiftedClsCaseEN.ResourceNum = objRow[convEduMSTRGiftedClsCase.ResourceNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase.ResourceNum].ToString().Trim()); //资源数
objvEduMSTRGiftedClsCaseEN.Memo = objRow[convEduMSTRGiftedClsCase.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Memo].ToString().Trim(); //备注
objvEduMSTRGiftedClsCaseEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvEduMSTRGiftedClsCaseEN.OwnerName = objRow[convEduMSTRGiftedClsCase.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCaseEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvEduMSTRGiftedClsCaseEN.IsHaveVideo = objRow[convEduMSTRGiftedClsCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvEduMSTRGiftedClsCaseDA: GetObjLst)", objException.Message));
}
objvEduMSTRGiftedClsCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvEduMSTRGiftedClsCaseEN);
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
public List<clsvEduMSTRGiftedClsCaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsvEduMSTRGiftedClsCaseEN> arrObjLst = new List<clsvEduMSTRGiftedClsCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN = new clsvEduMSTRGiftedClsCaseEN();
try
{
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objvEduMSTRGiftedClsCaseEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvEduMSTRGiftedClsCaseEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase.StudyLevelName].ToString().Trim(); //学段名称
objvEduMSTRGiftedClsCaseEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeID = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID].ToString().Trim(); //教育硕士优课案例类型Id
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCaseEN.IdCaseType = objRow[convEduMSTRGiftedClsCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvEduMSTRGiftedClsCaseEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase.IdDiscipline].ToString().Trim(); //学科流水号
objvEduMSTRGiftedClsCaseEN.DisciplineID = objRow[convEduMSTRGiftedClsCase.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DisciplineID].ToString().Trim(); //学科ID
objvEduMSTRGiftedClsCaseEN.DisciplineName = objRow[convEduMSTRGiftedClsCase.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DisciplineName].ToString().Trim(); //学科名称
objvEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCaseEN.VersionNo = objRow[convEduMSTRGiftedClsCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase.VersionNo].ToString().Trim()); //版本号
objvEduMSTRGiftedClsCaseEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvEduMSTRGiftedClsCaseEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvEduMSTRGiftedClsCaseEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvEduMSTRGiftedClsCaseEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvEduMSTRGiftedClsCaseEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvEduMSTRGiftedClsCaseEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvEduMSTRGiftedClsCaseEN.IdSkillType = objRow[convEduMSTRGiftedClsCase.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvEduMSTRGiftedClsCaseEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvEduMSTRGiftedClsCaseEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvEduMSTRGiftedClsCaseEN.CaseLevelName = objRow[convEduMSTRGiftedClsCase.CaseLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvEduMSTRGiftedClsCaseEN.DocFile = objRow[convEduMSTRGiftedClsCase.DocFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DocFile].ToString().Trim(); //生成的Word文件名
objvEduMSTRGiftedClsCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convEduMSTRGiftedClsCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvEduMSTRGiftedClsCaseEN.WordCreateDate = objRow[convEduMSTRGiftedClsCase.WordCreateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvEduMSTRGiftedClsCaseEN.IsVisible = TransNullToBool(objRow[convEduMSTRGiftedClsCase.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objvEduMSTRGiftedClsCaseEN.OwnerId = objRow[convEduMSTRGiftedClsCase.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCaseEN.IdStudentInfo = objRow[convEduMSTRGiftedClsCase.IdStudentInfo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvEduMSTRGiftedClsCaseEN.StuName = objRow[convEduMSTRGiftedClsCase.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCaseEN.StuId = objRow[convEduMSTRGiftedClsCase.StuId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuId].ToString().Trim(); //学号
objvEduMSTRGiftedClsCaseEN.PoliticsName = objRow[convEduMSTRGiftedClsCase.PoliticsName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.PoliticsName].ToString().Trim(); //政治面貌
objvEduMSTRGiftedClsCaseEN.SexDesc = objRow[convEduMSTRGiftedClsCase.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SexDesc].ToString().Trim(); //性别名称
objvEduMSTRGiftedClsCaseEN.EthnicName = objRow[convEduMSTRGiftedClsCase.EthnicName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EthnicName].ToString().Trim(); //民族名称
objvEduMSTRGiftedClsCaseEN.UniZoneDesc = objRow[convEduMSTRGiftedClsCase.UniZoneDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UniZoneDesc].ToString().Trim(); //校区名称
objvEduMSTRGiftedClsCaseEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvEduMSTRGiftedClsCaseEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCaseEN.CollegeId = objRow[convEduMSTRGiftedClsCase.CollegeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CollegeId].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCaseEN.CollegeName = objRow[convEduMSTRGiftedClsCase.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCaseEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCaseEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdXzMajor].ToString().Trim(); //专业流水号
objvEduMSTRGiftedClsCaseEN.MajorName = objRow[convEduMSTRGiftedClsCase.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCaseEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase.IdGradeBase].ToString().Trim(); //年级流水号
objvEduMSTRGiftedClsCaseEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.GradeBaseName].ToString().Trim(); //年级名称
objvEduMSTRGiftedClsCaseEN.IdAdminCls = objRow[convEduMSTRGiftedClsCase.IdAdminCls] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvEduMSTRGiftedClsCaseEN.AdminClsId = objRow[convEduMSTRGiftedClsCase.AdminClsId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.AdminClsId].ToString().Trim(); //行政班代号
objvEduMSTRGiftedClsCaseEN.AdminClsName = objRow[convEduMSTRGiftedClsCase.AdminClsName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.AdminClsName].ToString().Trim(); //行政班名称
objvEduMSTRGiftedClsCaseEN.Birthday = objRow[convEduMSTRGiftedClsCase.Birthday] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Birthday].ToString().Trim(); //出生日期
objvEduMSTRGiftedClsCaseEN.NativePlace = objRow[convEduMSTRGiftedClsCase.NativePlace] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.NativePlace].ToString().Trim(); //籍贯
objvEduMSTRGiftedClsCaseEN.Duty = objRow[convEduMSTRGiftedClsCase.Duty] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Duty].ToString().Trim(); //职位
objvEduMSTRGiftedClsCaseEN.IdCardNo = objRow[convEduMSTRGiftedClsCase.IdCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdCardNo].ToString().Trim(); //身份证号
objvEduMSTRGiftedClsCaseEN.StuCardNo = objRow[convEduMSTRGiftedClsCase.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuCardNo].ToString().Trim(); //学生证号
objvEduMSTRGiftedClsCaseEN.LiveAddress = objRow[convEduMSTRGiftedClsCase.LiveAddress] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.LiveAddress].ToString().Trim(); //居住地址
objvEduMSTRGiftedClsCaseEN.HomePhone = objRow[convEduMSTRGiftedClsCase.HomePhone] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.HomePhone].ToString().Trim(); //住宅电话
objvEduMSTRGiftedClsCaseEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EnrollmentDate].ToString().Trim(); //入校日期
objvEduMSTRGiftedClsCaseEN.PostCode = objRow[convEduMSTRGiftedClsCase.PostCode] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.PostCode].ToString().Trim(); //邮编
objvEduMSTRGiftedClsCaseEN.IsDualVideo = TransNullToBool(objRow[convEduMSTRGiftedClsCase.IsDualVideo].ToString().Trim()); //是否双视频
objvEduMSTRGiftedClsCaseEN.UserKindId = objRow[convEduMSTRGiftedClsCase.UserKindId].ToString().Trim(); //用户类别Id
objvEduMSTRGiftedClsCaseEN.UserKindName = objRow[convEduMSTRGiftedClsCase.UserKindName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserKindName].ToString().Trim(); //用户类别名
objvEduMSTRGiftedClsCaseEN.UserTypeId = objRow[convEduMSTRGiftedClsCase.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCaseEN.UserTypeName = objRow[convEduMSTRGiftedClsCase.UserTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserTypeName].ToString().Trim(); //用户类型名称
objvEduMSTRGiftedClsCaseEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvEduMSTRGiftedClsCaseEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvEduMSTRGiftedClsCaseEN.ftpFileType = objRow[convEduMSTRGiftedClsCase.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCaseEN.VideoUrl = objRow[convEduMSTRGiftedClsCase.VideoUrl] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.VideoUrl].ToString().Trim(); //视频Url
objvEduMSTRGiftedClsCaseEN.VideoPath = objRow[convEduMSTRGiftedClsCase.VideoPath] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.VideoPath].ToString().Trim(); //视频目录
objvEduMSTRGiftedClsCaseEN.ResErrMsg = objRow[convEduMSTRGiftedClsCase.ResErrMsg] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvEduMSTRGiftedClsCaseEN.ResourceNum = objRow[convEduMSTRGiftedClsCase.ResourceNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase.ResourceNum].ToString().Trim()); //资源数
objvEduMSTRGiftedClsCaseEN.Memo = objRow[convEduMSTRGiftedClsCase.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Memo].ToString().Trim(); //备注
objvEduMSTRGiftedClsCaseEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvEduMSTRGiftedClsCaseEN.OwnerName = objRow[convEduMSTRGiftedClsCase.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCaseEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvEduMSTRGiftedClsCaseEN.IsHaveVideo = objRow[convEduMSTRGiftedClsCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvEduMSTRGiftedClsCaseDA: GetObjLst)", objException.Message));
}
objvEduMSTRGiftedClsCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvEduMSTRGiftedClsCaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvEduMSTRGiftedClsCase(ref clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCase where IdEduMSTRGiftedClsCase = " + "'"+ objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase = objDT.Rows[0][convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID = objDT.Rows[0][convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName = objDT.Rows[0][convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme = objDT.Rows[0][convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate = objDT.Rows[0][convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime = objDT.Rows[0][convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间(字段类型:char,字段长度:6,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn = objDT.Rows[0][convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.IdStudyLevel = objDT.Rows[0][convEduMSTRGiftedClsCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.StudyLevelName = objDT.Rows[0][convEduMSTRGiftedClsCase.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.IdTeachingPlan = objDT.Rows[0][convEduMSTRGiftedClsCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn = objDT.Rows[0][convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType = objDT.Rows[0][convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeID = objDT.Rows[0][convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID].ToString().Trim(); //教育硕士优课案例类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeName = objDT.Rows[0][convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.IdCaseType = objDT.Rows[0][convEduMSTRGiftedClsCase.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.IdDiscipline = objDT.Rows[0][convEduMSTRGiftedClsCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.DisciplineID = objDT.Rows[0][convEduMSTRGiftedClsCase.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.DisciplineName = objDT.Rows[0][convEduMSTRGiftedClsCase.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion = objDT.Rows[0][convEduMSTRGiftedClsCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.senateGaugeVersionID = objDT.Rows[0][convEduMSTRGiftedClsCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.senateGaugeVersionName = objDT.Rows[0][convEduMSTRGiftedClsCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.VersionNo = TransNullToInt(objDT.Rows[0][convEduMSTRGiftedClsCase.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.IdTeachSkill = objDT.Rows[0][convEduMSTRGiftedClsCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.TeachSkillID = objDT.Rows[0][convEduMSTRGiftedClsCase.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.SkillTypeName = objDT.Rows[0][convEduMSTRGiftedClsCase.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.TeachSkillName = objDT.Rows[0][convEduMSTRGiftedClsCase.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.TeachSkillTheory = objDT.Rows[0][convEduMSTRGiftedClsCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.TeachSkillOperMethod = objDT.Rows[0][convEduMSTRGiftedClsCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.IdSkillType = objDT.Rows[0][convEduMSTRGiftedClsCase.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.SkillTypeID = objDT.Rows[0][convEduMSTRGiftedClsCase.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.CaseLevelId = objDT.Rows[0][convEduMSTRGiftedClsCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.CaseLevelName = objDT.Rows[0][convEduMSTRGiftedClsCase.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.DocFile = objDT.Rows[0][convEduMSTRGiftedClsCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][convEduMSTRGiftedClsCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.WordCreateDate = objDT.Rows[0][convEduMSTRGiftedClsCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.IsVisible = TransNullToBool(objDT.Rows[0][convEduMSTRGiftedClsCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText = objDT.Rows[0][convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本(字段类型:varchar,字段长度:8000,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.OwnerId = objDT.Rows[0][convEduMSTRGiftedClsCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.IdStudentInfo = objDT.Rows[0][convEduMSTRGiftedClsCase.IdStudentInfo].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.StuName = objDT.Rows[0][convEduMSTRGiftedClsCase.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.StuId = objDT.Rows[0][convEduMSTRGiftedClsCase.StuId].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.PoliticsName = objDT.Rows[0][convEduMSTRGiftedClsCase.PoliticsName].ToString().Trim(); //政治面貌(字段类型:varchar,字段长度:30,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.SexDesc = objDT.Rows[0][convEduMSTRGiftedClsCase.SexDesc].ToString().Trim(); //性别名称(字段类型:varchar,字段长度:10,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.EthnicName = objDT.Rows[0][convEduMSTRGiftedClsCase.EthnicName].ToString().Trim(); //民族名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.UniZoneDesc = objDT.Rows[0][convEduMSTRGiftedClsCase.UniZoneDesc].ToString().Trim(); //校区名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.StuTypeDesc = objDT.Rows[0][convEduMSTRGiftedClsCase.StuTypeDesc].ToString().Trim(); //学生类别名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.IdXzCollege = objDT.Rows[0][convEduMSTRGiftedClsCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.CollegeId = objDT.Rows[0][convEduMSTRGiftedClsCase.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.CollegeName = objDT.Rows[0][convEduMSTRGiftedClsCase.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.CollegeNameA = objDT.Rows[0][convEduMSTRGiftedClsCase.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.IdXzMajor = objDT.Rows[0][convEduMSTRGiftedClsCase.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.MajorName = objDT.Rows[0][convEduMSTRGiftedClsCase.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.IdGradeBase = objDT.Rows[0][convEduMSTRGiftedClsCase.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.GradeBaseName = objDT.Rows[0][convEduMSTRGiftedClsCase.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.IdAdminCls = objDT.Rows[0][convEduMSTRGiftedClsCase.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.AdminClsId = objDT.Rows[0][convEduMSTRGiftedClsCase.AdminClsId].ToString().Trim(); //行政班代号(字段类型:varchar,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.AdminClsName = objDT.Rows[0][convEduMSTRGiftedClsCase.AdminClsName].ToString().Trim(); //行政班名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.Birthday = objDT.Rows[0][convEduMSTRGiftedClsCase.Birthday].ToString().Trim(); //出生日期(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.NativePlace = objDT.Rows[0][convEduMSTRGiftedClsCase.NativePlace].ToString().Trim(); //籍贯(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.Duty = objDT.Rows[0][convEduMSTRGiftedClsCase.Duty].ToString().Trim(); //职位(字段类型:varchar,字段长度:30,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.IdCardNo = objDT.Rows[0][convEduMSTRGiftedClsCase.IdCardNo].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.StuCardNo = objDT.Rows[0][convEduMSTRGiftedClsCase.StuCardNo].ToString().Trim(); //学生证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.LiveAddress = objDT.Rows[0][convEduMSTRGiftedClsCase.LiveAddress].ToString().Trim(); //居住地址(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.HomePhone = objDT.Rows[0][convEduMSTRGiftedClsCase.HomePhone].ToString().Trim(); //住宅电话(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.EnrollmentDate = objDT.Rows[0][convEduMSTRGiftedClsCase.EnrollmentDate].ToString().Trim(); //入校日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.PostCode = objDT.Rows[0][convEduMSTRGiftedClsCase.PostCode].ToString().Trim(); //邮编(字段类型:char,字段长度:6,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convEduMSTRGiftedClsCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.UserKindId = objDT.Rows[0][convEduMSTRGiftedClsCase.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.UserKindName = objDT.Rows[0][convEduMSTRGiftedClsCase.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.UserTypeId = objDT.Rows[0][convEduMSTRGiftedClsCase.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.UserTypeName = objDT.Rows[0][convEduMSTRGiftedClsCase.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.RecommendedDegreeId = objDT.Rows[0][convEduMSTRGiftedClsCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.RecommendedDegreeName = objDT.Rows[0][convEduMSTRGiftedClsCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.ftpFileType = objDT.Rows[0][convEduMSTRGiftedClsCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.VideoUrl = objDT.Rows[0][convEduMSTRGiftedClsCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.VideoPath = objDT.Rows[0][convEduMSTRGiftedClsCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.ResErrMsg = objDT.Rows[0][convEduMSTRGiftedClsCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.ResourceNum = TransNullToInt(objDT.Rows[0][convEduMSTRGiftedClsCase.ResourceNum].ToString().Trim()); //资源数(字段类型:int,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.Memo = objDT.Rows[0][convEduMSTRGiftedClsCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convEduMSTRGiftedClsCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.OwnerName = objDT.Rows[0][convEduMSTRGiftedClsCase.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.OwnerNameWithId = objDT.Rows[0][convEduMSTRGiftedClsCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.IsHaveVideo = objDT.Rows[0][convEduMSTRGiftedClsCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo(字段类型:varchar,字段长度:6,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvEduMSTRGiftedClsCaseDA: GetvEduMSTRGiftedClsCase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdEduMSTRGiftedClsCase">表关键字</param>
 /// <returns>表对象</returns>
public clsvEduMSTRGiftedClsCaseEN GetObjByIdEduMSTRGiftedClsCase(string strIdEduMSTRGiftedClsCase)
{
CheckPrimaryKey(strIdEduMSTRGiftedClsCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCase where IdEduMSTRGiftedClsCase = " + "'"+ strIdEduMSTRGiftedClsCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN = new clsvEduMSTRGiftedClsCaseEN();
try
{
 objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间(字段类型:char,字段长度:6,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeID = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID].ToString().Trim(); //教育硕士优课案例类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.IdCaseType = objRow[convEduMSTRGiftedClsCase.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.DisciplineID = objRow[convEduMSTRGiftedClsCase.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.DisciplineName = objRow[convEduMSTRGiftedClsCase.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.VersionNo = objRow[convEduMSTRGiftedClsCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.IdSkillType = objRow[convEduMSTRGiftedClsCase.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.CaseLevelName = objRow[convEduMSTRGiftedClsCase.CaseLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.DocFile = objRow[convEduMSTRGiftedClsCase.DocFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.WordCreateDate = objRow[convEduMSTRGiftedClsCase.WordCreateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本(字段类型:varchar,字段长度:8000,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.OwnerId = objRow[convEduMSTRGiftedClsCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.IdStudentInfo = objRow[convEduMSTRGiftedClsCase.IdStudentInfo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdStudentInfo].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.StuName = objRow[convEduMSTRGiftedClsCase.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.StuId = objRow[convEduMSTRGiftedClsCase.StuId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuId].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.PoliticsName = objRow[convEduMSTRGiftedClsCase.PoliticsName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.PoliticsName].ToString().Trim(); //政治面貌(字段类型:varchar,字段长度:30,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.SexDesc = objRow[convEduMSTRGiftedClsCase.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SexDesc].ToString().Trim(); //性别名称(字段类型:varchar,字段长度:10,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.EthnicName = objRow[convEduMSTRGiftedClsCase.EthnicName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EthnicName].ToString().Trim(); //民族名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.UniZoneDesc = objRow[convEduMSTRGiftedClsCase.UniZoneDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UniZoneDesc].ToString().Trim(); //校区名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuTypeDesc].ToString().Trim(); //学生类别名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.CollegeId = objRow[convEduMSTRGiftedClsCase.CollegeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.CollegeName = objRow[convEduMSTRGiftedClsCase.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.MajorName = objRow[convEduMSTRGiftedClsCase.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.IdAdminCls = objRow[convEduMSTRGiftedClsCase.IdAdminCls] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.AdminClsId = objRow[convEduMSTRGiftedClsCase.AdminClsId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.AdminClsId].ToString().Trim(); //行政班代号(字段类型:varchar,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.AdminClsName = objRow[convEduMSTRGiftedClsCase.AdminClsName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.AdminClsName].ToString().Trim(); //行政班名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.Birthday = objRow[convEduMSTRGiftedClsCase.Birthday] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Birthday].ToString().Trim(); //出生日期(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.NativePlace = objRow[convEduMSTRGiftedClsCase.NativePlace] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.NativePlace].ToString().Trim(); //籍贯(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.Duty = objRow[convEduMSTRGiftedClsCase.Duty] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Duty].ToString().Trim(); //职位(字段类型:varchar,字段长度:30,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.IdCardNo = objRow[convEduMSTRGiftedClsCase.IdCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdCardNo].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.StuCardNo = objRow[convEduMSTRGiftedClsCase.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuCardNo].ToString().Trim(); //学生证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.LiveAddress = objRow[convEduMSTRGiftedClsCase.LiveAddress] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.LiveAddress].ToString().Trim(); //居住地址(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.HomePhone = objRow[convEduMSTRGiftedClsCase.HomePhone] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.HomePhone].ToString().Trim(); //住宅电话(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EnrollmentDate].ToString().Trim(); //入校日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.PostCode = objRow[convEduMSTRGiftedClsCase.PostCode] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.PostCode].ToString().Trim(); //邮编(字段类型:char,字段长度:6,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.UserKindId = objRow[convEduMSTRGiftedClsCase.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.UserKindName = objRow[convEduMSTRGiftedClsCase.UserKindName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.UserTypeId = objRow[convEduMSTRGiftedClsCase.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.UserTypeName = objRow[convEduMSTRGiftedClsCase.UserTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvEduMSTRGiftedClsCaseEN.ftpFileType = objRow[convEduMSTRGiftedClsCase.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.VideoUrl = objRow[convEduMSTRGiftedClsCase.VideoUrl] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.VideoPath = objRow[convEduMSTRGiftedClsCase.VideoPath] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.ResErrMsg = objRow[convEduMSTRGiftedClsCase.ResErrMsg] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.ResourceNum = objRow[convEduMSTRGiftedClsCase.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.ResourceNum].ToString().Trim()); //资源数(字段类型:int,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.Memo = objRow[convEduMSTRGiftedClsCase.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.OwnerName = objRow[convEduMSTRGiftedClsCase.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvEduMSTRGiftedClsCaseEN.IsHaveVideo = objRow[convEduMSTRGiftedClsCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo(字段类型:varchar,字段长度:6,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvEduMSTRGiftedClsCaseDA: GetObjByIdEduMSTRGiftedClsCase)", objException.Message));
}
return objvEduMSTRGiftedClsCaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvEduMSTRGiftedClsCaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN = new clsvEduMSTRGiftedClsCaseEN()
{
IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase].ToString().Trim(), //教育硕士优课案例流水号
EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID].ToString().Trim(), //教育硕士优课案例ID
EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName].ToString().Trim(), //教育硕士优课案例名称
EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme].ToString().Trim(), //教育硕士优课案例主题词
EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate].ToString().Trim(), //教育硕士优课案例日期
EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime].ToString().Trim(), //教育硕士优课案例时间
EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn].ToString().Trim(), //案例入库日期
IdStudyLevel = objRow[convEduMSTRGiftedClsCase.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convEduMSTRGiftedClsCase.StudyLevelName].ToString().Trim(), //学段名称
IdTeachingPlan = objRow[convEduMSTRGiftedClsCase.IdTeachingPlan].ToString().Trim(), //教案流水号
EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(), //案例入库时间
IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType].ToString().Trim(), //教育硕士优课案例类型流水号
EduMSTRGiftedClsCaseTypeID = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID].ToString().Trim(), //教育硕士优课案例类型Id
EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName].ToString().Trim(), //教育硕士优课案例类型名称
IdCaseType = objRow[convEduMSTRGiftedClsCase.IdCaseType].ToString().Trim(), //案例类型流水号
IdDiscipline = objRow[convEduMSTRGiftedClsCase.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convEduMSTRGiftedClsCase.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convEduMSTRGiftedClsCase.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DisciplineName].ToString().Trim(), //学科名称
IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCase.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = TransNullToFloat(objRow[convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
VersionNo = objRow[convEduMSTRGiftedClsCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase.VersionNo].ToString().Trim()), //版本号
IdTeachSkill = objRow[convEduMSTRGiftedClsCase.IdTeachSkill].ToString().Trim(), //教学技能流水号
TeachSkillID = objRow[convEduMSTRGiftedClsCase.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillID].ToString().Trim(), //教学技能ID
SkillTypeName = objRow[convEduMSTRGiftedClsCase.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SkillTypeName].ToString().Trim(), //技能类型名称
TeachSkillName = objRow[convEduMSTRGiftedClsCase.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillName].ToString().Trim(), //教学技能名称
TeachSkillTheory = objRow[convEduMSTRGiftedClsCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillTheory].ToString().Trim(), //教学技能理论阐述
TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillOperMethod].ToString().Trim(), //教学技能实践操作方法
IdSkillType = objRow[convEduMSTRGiftedClsCase.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdSkillType].ToString().Trim(), //技能类型流水号
SkillTypeID = objRow[convEduMSTRGiftedClsCase.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SkillTypeID].ToString().Trim(), //技能类型ID
CaseLevelId = objRow[convEduMSTRGiftedClsCase.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CaseLevelId].ToString().Trim(), //课例等级Id
CaseLevelName = objRow[convEduMSTRGiftedClsCase.CaseLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CaseLevelName].ToString().Trim(), //案例等级名称
DocFile = objRow[convEduMSTRGiftedClsCase.DocFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DocFile].ToString().Trim(), //生成的Word文件名
IsNeedGeneWord = TransNullToBool(objRow[convEduMSTRGiftedClsCase.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
WordCreateDate = objRow[convEduMSTRGiftedClsCase.WordCreateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.WordCreateDate].ToString().Trim(), //Word生成日期
IsVisible = TransNullToBool(objRow[convEduMSTRGiftedClsCase.IsVisible].ToString().Trim()), //是否显示
EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText].ToString().Trim(), //教育硕士优课案例文本
OwnerId = objRow[convEduMSTRGiftedClsCase.OwnerId].ToString().Trim(), //拥有者Id
IdStudentInfo = objRow[convEduMSTRGiftedClsCase.IdStudentInfo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdStudentInfo].ToString().Trim(), //学生流水号
StuName = objRow[convEduMSTRGiftedClsCase.StuName].ToString().Trim(), //姓名
StuId = objRow[convEduMSTRGiftedClsCase.StuId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuId].ToString().Trim(), //学号
PoliticsName = objRow[convEduMSTRGiftedClsCase.PoliticsName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.PoliticsName].ToString().Trim(), //政治面貌
SexDesc = objRow[convEduMSTRGiftedClsCase.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SexDesc].ToString().Trim(), //性别名称
EthnicName = objRow[convEduMSTRGiftedClsCase.EthnicName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EthnicName].ToString().Trim(), //民族名称
UniZoneDesc = objRow[convEduMSTRGiftedClsCase.UniZoneDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UniZoneDesc].ToString().Trim(), //校区名称
StuTypeDesc = objRow[convEduMSTRGiftedClsCase.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuTypeDesc].ToString().Trim(), //学生类别名称
IdXzCollege = objRow[convEduMSTRGiftedClsCase.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdXzCollege].ToString().Trim(), //学院流水号
CollegeId = objRow[convEduMSTRGiftedClsCase.CollegeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CollegeId].ToString().Trim(), //学院ID
CollegeName = objRow[convEduMSTRGiftedClsCase.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convEduMSTRGiftedClsCase.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CollegeNameA].ToString().Trim(), //学院名称简写
IdXzMajor = objRow[convEduMSTRGiftedClsCase.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdXzMajor].ToString().Trim(), //专业流水号
MajorName = objRow[convEduMSTRGiftedClsCase.MajorName].ToString().Trim(), //专业名称
IdGradeBase = objRow[convEduMSTRGiftedClsCase.IdGradeBase].ToString().Trim(), //年级流水号
GradeBaseName = objRow[convEduMSTRGiftedClsCase.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.GradeBaseName].ToString().Trim(), //年级名称
IdAdminCls = objRow[convEduMSTRGiftedClsCase.IdAdminCls] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdAdminCls].ToString().Trim(), //行政班流水号
AdminClsId = objRow[convEduMSTRGiftedClsCase.AdminClsId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.AdminClsId].ToString().Trim(), //行政班代号
AdminClsName = objRow[convEduMSTRGiftedClsCase.AdminClsName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.AdminClsName].ToString().Trim(), //行政班名称
Birthday = objRow[convEduMSTRGiftedClsCase.Birthday] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Birthday].ToString().Trim(), //出生日期
NativePlace = objRow[convEduMSTRGiftedClsCase.NativePlace] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.NativePlace].ToString().Trim(), //籍贯
Duty = objRow[convEduMSTRGiftedClsCase.Duty] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Duty].ToString().Trim(), //职位
IdCardNo = objRow[convEduMSTRGiftedClsCase.IdCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdCardNo].ToString().Trim(), //身份证号
StuCardNo = objRow[convEduMSTRGiftedClsCase.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuCardNo].ToString().Trim(), //学生证号
LiveAddress = objRow[convEduMSTRGiftedClsCase.LiveAddress] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.LiveAddress].ToString().Trim(), //居住地址
HomePhone = objRow[convEduMSTRGiftedClsCase.HomePhone] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.HomePhone].ToString().Trim(), //住宅电话
EnrollmentDate = objRow[convEduMSTRGiftedClsCase.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EnrollmentDate].ToString().Trim(), //入校日期
PostCode = objRow[convEduMSTRGiftedClsCase.PostCode] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.PostCode].ToString().Trim(), //邮编
IsDualVideo = TransNullToBool(objRow[convEduMSTRGiftedClsCase.IsDualVideo].ToString().Trim()), //是否双视频
UserKindId = objRow[convEduMSTRGiftedClsCase.UserKindId].ToString().Trim(), //用户类别Id
UserKindName = objRow[convEduMSTRGiftedClsCase.UserKindName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserKindName].ToString().Trim(), //用户类别名
UserTypeId = objRow[convEduMSTRGiftedClsCase.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserTypeId].ToString().Trim(), //用户类型Id
UserTypeName = objRow[convEduMSTRGiftedClsCase.UserTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserTypeName].ToString().Trim(), //用户类型名称
RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.RecommendedDegreeName].ToString().Trim(), //推荐度名称
ftpFileType = objRow[convEduMSTRGiftedClsCase.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.ftpFileType].ToString().Trim(), //ftp文件类型
VideoUrl = objRow[convEduMSTRGiftedClsCase.VideoUrl] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[convEduMSTRGiftedClsCase.VideoPath] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.VideoPath].ToString().Trim(), //视频目录
ResErrMsg = objRow[convEduMSTRGiftedClsCase.ResErrMsg] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.ResErrMsg].ToString().Trim(), //资源错误信息
ResourceNum = objRow[convEduMSTRGiftedClsCase.ResourceNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase.ResourceNum].ToString().Trim()), //资源数
Memo = objRow[convEduMSTRGiftedClsCase.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Memo].ToString().Trim(), //备注
BrowseCount4Case = objRow[convEduMSTRGiftedClsCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase.BrowseCount4Case].ToString().Trim()), //课例浏览次数
OwnerName = objRow[convEduMSTRGiftedClsCase.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.OwnerName].ToString().Trim(), //拥有者姓名
OwnerNameWithId = objRow[convEduMSTRGiftedClsCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
IsHaveVideo = objRow[convEduMSTRGiftedClsCase.IsHaveVideo].ToString().Trim() //IsHaveVideo
};
objvEduMSTRGiftedClsCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvEduMSTRGiftedClsCaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvEduMSTRGiftedClsCaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvEduMSTRGiftedClsCaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN = new clsvEduMSTRGiftedClsCaseEN();
try
{
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objvEduMSTRGiftedClsCaseEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvEduMSTRGiftedClsCaseEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase.StudyLevelName].ToString().Trim(); //学段名称
objvEduMSTRGiftedClsCaseEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeID = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID].ToString().Trim(); //教育硕士优课案例类型Id
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCaseEN.IdCaseType = objRow[convEduMSTRGiftedClsCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvEduMSTRGiftedClsCaseEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase.IdDiscipline].ToString().Trim(); //学科流水号
objvEduMSTRGiftedClsCaseEN.DisciplineID = objRow[convEduMSTRGiftedClsCase.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DisciplineID].ToString().Trim(); //学科ID
objvEduMSTRGiftedClsCaseEN.DisciplineName = objRow[convEduMSTRGiftedClsCase.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DisciplineName].ToString().Trim(); //学科名称
objvEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCaseEN.VersionNo = objRow[convEduMSTRGiftedClsCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase.VersionNo].ToString().Trim()); //版本号
objvEduMSTRGiftedClsCaseEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvEduMSTRGiftedClsCaseEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvEduMSTRGiftedClsCaseEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvEduMSTRGiftedClsCaseEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvEduMSTRGiftedClsCaseEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvEduMSTRGiftedClsCaseEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvEduMSTRGiftedClsCaseEN.IdSkillType = objRow[convEduMSTRGiftedClsCase.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvEduMSTRGiftedClsCaseEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvEduMSTRGiftedClsCaseEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvEduMSTRGiftedClsCaseEN.CaseLevelName = objRow[convEduMSTRGiftedClsCase.CaseLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvEduMSTRGiftedClsCaseEN.DocFile = objRow[convEduMSTRGiftedClsCase.DocFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DocFile].ToString().Trim(); //生成的Word文件名
objvEduMSTRGiftedClsCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convEduMSTRGiftedClsCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvEduMSTRGiftedClsCaseEN.WordCreateDate = objRow[convEduMSTRGiftedClsCase.WordCreateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvEduMSTRGiftedClsCaseEN.IsVisible = TransNullToBool(objRow[convEduMSTRGiftedClsCase.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objvEduMSTRGiftedClsCaseEN.OwnerId = objRow[convEduMSTRGiftedClsCase.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCaseEN.IdStudentInfo = objRow[convEduMSTRGiftedClsCase.IdStudentInfo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvEduMSTRGiftedClsCaseEN.StuName = objRow[convEduMSTRGiftedClsCase.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCaseEN.StuId = objRow[convEduMSTRGiftedClsCase.StuId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuId].ToString().Trim(); //学号
objvEduMSTRGiftedClsCaseEN.PoliticsName = objRow[convEduMSTRGiftedClsCase.PoliticsName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.PoliticsName].ToString().Trim(); //政治面貌
objvEduMSTRGiftedClsCaseEN.SexDesc = objRow[convEduMSTRGiftedClsCase.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SexDesc].ToString().Trim(); //性别名称
objvEduMSTRGiftedClsCaseEN.EthnicName = objRow[convEduMSTRGiftedClsCase.EthnicName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EthnicName].ToString().Trim(); //民族名称
objvEduMSTRGiftedClsCaseEN.UniZoneDesc = objRow[convEduMSTRGiftedClsCase.UniZoneDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UniZoneDesc].ToString().Trim(); //校区名称
objvEduMSTRGiftedClsCaseEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvEduMSTRGiftedClsCaseEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCaseEN.CollegeId = objRow[convEduMSTRGiftedClsCase.CollegeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CollegeId].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCaseEN.CollegeName = objRow[convEduMSTRGiftedClsCase.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCaseEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCaseEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdXzMajor].ToString().Trim(); //专业流水号
objvEduMSTRGiftedClsCaseEN.MajorName = objRow[convEduMSTRGiftedClsCase.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCaseEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase.IdGradeBase].ToString().Trim(); //年级流水号
objvEduMSTRGiftedClsCaseEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.GradeBaseName].ToString().Trim(); //年级名称
objvEduMSTRGiftedClsCaseEN.IdAdminCls = objRow[convEduMSTRGiftedClsCase.IdAdminCls] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvEduMSTRGiftedClsCaseEN.AdminClsId = objRow[convEduMSTRGiftedClsCase.AdminClsId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.AdminClsId].ToString().Trim(); //行政班代号
objvEduMSTRGiftedClsCaseEN.AdminClsName = objRow[convEduMSTRGiftedClsCase.AdminClsName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.AdminClsName].ToString().Trim(); //行政班名称
objvEduMSTRGiftedClsCaseEN.Birthday = objRow[convEduMSTRGiftedClsCase.Birthday] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Birthday].ToString().Trim(); //出生日期
objvEduMSTRGiftedClsCaseEN.NativePlace = objRow[convEduMSTRGiftedClsCase.NativePlace] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.NativePlace].ToString().Trim(); //籍贯
objvEduMSTRGiftedClsCaseEN.Duty = objRow[convEduMSTRGiftedClsCase.Duty] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Duty].ToString().Trim(); //职位
objvEduMSTRGiftedClsCaseEN.IdCardNo = objRow[convEduMSTRGiftedClsCase.IdCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdCardNo].ToString().Trim(); //身份证号
objvEduMSTRGiftedClsCaseEN.StuCardNo = objRow[convEduMSTRGiftedClsCase.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuCardNo].ToString().Trim(); //学生证号
objvEduMSTRGiftedClsCaseEN.LiveAddress = objRow[convEduMSTRGiftedClsCase.LiveAddress] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.LiveAddress].ToString().Trim(); //居住地址
objvEduMSTRGiftedClsCaseEN.HomePhone = objRow[convEduMSTRGiftedClsCase.HomePhone] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.HomePhone].ToString().Trim(); //住宅电话
objvEduMSTRGiftedClsCaseEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EnrollmentDate].ToString().Trim(); //入校日期
objvEduMSTRGiftedClsCaseEN.PostCode = objRow[convEduMSTRGiftedClsCase.PostCode] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.PostCode].ToString().Trim(); //邮编
objvEduMSTRGiftedClsCaseEN.IsDualVideo = TransNullToBool(objRow[convEduMSTRGiftedClsCase.IsDualVideo].ToString().Trim()); //是否双视频
objvEduMSTRGiftedClsCaseEN.UserKindId = objRow[convEduMSTRGiftedClsCase.UserKindId].ToString().Trim(); //用户类别Id
objvEduMSTRGiftedClsCaseEN.UserKindName = objRow[convEduMSTRGiftedClsCase.UserKindName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserKindName].ToString().Trim(); //用户类别名
objvEduMSTRGiftedClsCaseEN.UserTypeId = objRow[convEduMSTRGiftedClsCase.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCaseEN.UserTypeName = objRow[convEduMSTRGiftedClsCase.UserTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserTypeName].ToString().Trim(); //用户类型名称
objvEduMSTRGiftedClsCaseEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvEduMSTRGiftedClsCaseEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvEduMSTRGiftedClsCaseEN.ftpFileType = objRow[convEduMSTRGiftedClsCase.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCaseEN.VideoUrl = objRow[convEduMSTRGiftedClsCase.VideoUrl] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.VideoUrl].ToString().Trim(); //视频Url
objvEduMSTRGiftedClsCaseEN.VideoPath = objRow[convEduMSTRGiftedClsCase.VideoPath] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.VideoPath].ToString().Trim(); //视频目录
objvEduMSTRGiftedClsCaseEN.ResErrMsg = objRow[convEduMSTRGiftedClsCase.ResErrMsg] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvEduMSTRGiftedClsCaseEN.ResourceNum = objRow[convEduMSTRGiftedClsCase.ResourceNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase.ResourceNum].ToString().Trim()); //资源数
objvEduMSTRGiftedClsCaseEN.Memo = objRow[convEduMSTRGiftedClsCase.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Memo].ToString().Trim(); //备注
objvEduMSTRGiftedClsCaseEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvEduMSTRGiftedClsCaseEN.OwnerName = objRow[convEduMSTRGiftedClsCase.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCaseEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvEduMSTRGiftedClsCaseEN.IsHaveVideo = objRow[convEduMSTRGiftedClsCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvEduMSTRGiftedClsCaseDA: GetObjByDataRowvEduMSTRGiftedClsCase)", objException.Message));
}
objvEduMSTRGiftedClsCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvEduMSTRGiftedClsCaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvEduMSTRGiftedClsCaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN = new clsvEduMSTRGiftedClsCaseEN();
try
{
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objvEduMSTRGiftedClsCaseEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvEduMSTRGiftedClsCaseEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase.StudyLevelName].ToString().Trim(); //学段名称
objvEduMSTRGiftedClsCaseEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeID = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID].ToString().Trim(); //教育硕士优课案例类型Id
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCaseEN.IdCaseType = objRow[convEduMSTRGiftedClsCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvEduMSTRGiftedClsCaseEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase.IdDiscipline].ToString().Trim(); //学科流水号
objvEduMSTRGiftedClsCaseEN.DisciplineID = objRow[convEduMSTRGiftedClsCase.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DisciplineID].ToString().Trim(); //学科ID
objvEduMSTRGiftedClsCaseEN.DisciplineName = objRow[convEduMSTRGiftedClsCase.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DisciplineName].ToString().Trim(); //学科名称
objvEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convEduMSTRGiftedClsCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCaseEN.VersionNo = objRow[convEduMSTRGiftedClsCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase.VersionNo].ToString().Trim()); //版本号
objvEduMSTRGiftedClsCaseEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvEduMSTRGiftedClsCaseEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvEduMSTRGiftedClsCaseEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvEduMSTRGiftedClsCaseEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvEduMSTRGiftedClsCaseEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvEduMSTRGiftedClsCaseEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvEduMSTRGiftedClsCaseEN.IdSkillType = objRow[convEduMSTRGiftedClsCase.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvEduMSTRGiftedClsCaseEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvEduMSTRGiftedClsCaseEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvEduMSTRGiftedClsCaseEN.CaseLevelName = objRow[convEduMSTRGiftedClsCase.CaseLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvEduMSTRGiftedClsCaseEN.DocFile = objRow[convEduMSTRGiftedClsCase.DocFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.DocFile].ToString().Trim(); //生成的Word文件名
objvEduMSTRGiftedClsCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convEduMSTRGiftedClsCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvEduMSTRGiftedClsCaseEN.WordCreateDate = objRow[convEduMSTRGiftedClsCase.WordCreateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvEduMSTRGiftedClsCaseEN.IsVisible = TransNullToBool(objRow[convEduMSTRGiftedClsCase.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objvEduMSTRGiftedClsCaseEN.OwnerId = objRow[convEduMSTRGiftedClsCase.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCaseEN.IdStudentInfo = objRow[convEduMSTRGiftedClsCase.IdStudentInfo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvEduMSTRGiftedClsCaseEN.StuName = objRow[convEduMSTRGiftedClsCase.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCaseEN.StuId = objRow[convEduMSTRGiftedClsCase.StuId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuId].ToString().Trim(); //学号
objvEduMSTRGiftedClsCaseEN.PoliticsName = objRow[convEduMSTRGiftedClsCase.PoliticsName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.PoliticsName].ToString().Trim(); //政治面貌
objvEduMSTRGiftedClsCaseEN.SexDesc = objRow[convEduMSTRGiftedClsCase.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.SexDesc].ToString().Trim(); //性别名称
objvEduMSTRGiftedClsCaseEN.EthnicName = objRow[convEduMSTRGiftedClsCase.EthnicName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EthnicName].ToString().Trim(); //民族名称
objvEduMSTRGiftedClsCaseEN.UniZoneDesc = objRow[convEduMSTRGiftedClsCase.UniZoneDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UniZoneDesc].ToString().Trim(); //校区名称
objvEduMSTRGiftedClsCaseEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvEduMSTRGiftedClsCaseEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCaseEN.CollegeId = objRow[convEduMSTRGiftedClsCase.CollegeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CollegeId].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCaseEN.CollegeName = objRow[convEduMSTRGiftedClsCase.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCaseEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCaseEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdXzMajor].ToString().Trim(); //专业流水号
objvEduMSTRGiftedClsCaseEN.MajorName = objRow[convEduMSTRGiftedClsCase.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCaseEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase.IdGradeBase].ToString().Trim(); //年级流水号
objvEduMSTRGiftedClsCaseEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.GradeBaseName].ToString().Trim(); //年级名称
objvEduMSTRGiftedClsCaseEN.IdAdminCls = objRow[convEduMSTRGiftedClsCase.IdAdminCls] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvEduMSTRGiftedClsCaseEN.AdminClsId = objRow[convEduMSTRGiftedClsCase.AdminClsId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.AdminClsId].ToString().Trim(); //行政班代号
objvEduMSTRGiftedClsCaseEN.AdminClsName = objRow[convEduMSTRGiftedClsCase.AdminClsName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.AdminClsName].ToString().Trim(); //行政班名称
objvEduMSTRGiftedClsCaseEN.Birthday = objRow[convEduMSTRGiftedClsCase.Birthday] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Birthday].ToString().Trim(); //出生日期
objvEduMSTRGiftedClsCaseEN.NativePlace = objRow[convEduMSTRGiftedClsCase.NativePlace] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.NativePlace].ToString().Trim(); //籍贯
objvEduMSTRGiftedClsCaseEN.Duty = objRow[convEduMSTRGiftedClsCase.Duty] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Duty].ToString().Trim(); //职位
objvEduMSTRGiftedClsCaseEN.IdCardNo = objRow[convEduMSTRGiftedClsCase.IdCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.IdCardNo].ToString().Trim(); //身份证号
objvEduMSTRGiftedClsCaseEN.StuCardNo = objRow[convEduMSTRGiftedClsCase.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.StuCardNo].ToString().Trim(); //学生证号
objvEduMSTRGiftedClsCaseEN.LiveAddress = objRow[convEduMSTRGiftedClsCase.LiveAddress] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.LiveAddress].ToString().Trim(); //居住地址
objvEduMSTRGiftedClsCaseEN.HomePhone = objRow[convEduMSTRGiftedClsCase.HomePhone] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.HomePhone].ToString().Trim(); //住宅电话
objvEduMSTRGiftedClsCaseEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.EnrollmentDate].ToString().Trim(); //入校日期
objvEduMSTRGiftedClsCaseEN.PostCode = objRow[convEduMSTRGiftedClsCase.PostCode] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.PostCode].ToString().Trim(); //邮编
objvEduMSTRGiftedClsCaseEN.IsDualVideo = TransNullToBool(objRow[convEduMSTRGiftedClsCase.IsDualVideo].ToString().Trim()); //是否双视频
objvEduMSTRGiftedClsCaseEN.UserKindId = objRow[convEduMSTRGiftedClsCase.UserKindId].ToString().Trim(); //用户类别Id
objvEduMSTRGiftedClsCaseEN.UserKindName = objRow[convEduMSTRGiftedClsCase.UserKindName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserKindName].ToString().Trim(); //用户类别名
objvEduMSTRGiftedClsCaseEN.UserTypeId = objRow[convEduMSTRGiftedClsCase.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCaseEN.UserTypeName = objRow[convEduMSTRGiftedClsCase.UserTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.UserTypeName].ToString().Trim(); //用户类型名称
objvEduMSTRGiftedClsCaseEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvEduMSTRGiftedClsCaseEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvEduMSTRGiftedClsCaseEN.ftpFileType = objRow[convEduMSTRGiftedClsCase.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCaseEN.VideoUrl = objRow[convEduMSTRGiftedClsCase.VideoUrl] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.VideoUrl].ToString().Trim(); //视频Url
objvEduMSTRGiftedClsCaseEN.VideoPath = objRow[convEduMSTRGiftedClsCase.VideoPath] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.VideoPath].ToString().Trim(); //视频目录
objvEduMSTRGiftedClsCaseEN.ResErrMsg = objRow[convEduMSTRGiftedClsCase.ResErrMsg] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvEduMSTRGiftedClsCaseEN.ResourceNum = objRow[convEduMSTRGiftedClsCase.ResourceNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase.ResourceNum].ToString().Trim()); //资源数
objvEduMSTRGiftedClsCaseEN.Memo = objRow[convEduMSTRGiftedClsCase.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.Memo].ToString().Trim(); //备注
objvEduMSTRGiftedClsCaseEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvEduMSTRGiftedClsCaseEN.OwnerName = objRow[convEduMSTRGiftedClsCase.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCaseEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvEduMSTRGiftedClsCaseEN.IsHaveVideo = objRow[convEduMSTRGiftedClsCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvEduMSTRGiftedClsCaseDA: GetObjByDataRow)", objException.Message));
}
objvEduMSTRGiftedClsCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvEduMSTRGiftedClsCaseEN;
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
objSQL = clsvEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvEduMSTRGiftedClsCaseEN._CurrTabName, convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase, 8, "");
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
objSQL = clsvEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvEduMSTRGiftedClsCaseEN._CurrTabName, convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase, 8, strPrefix);
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
 objSQL = clsvEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdEduMSTRGiftedClsCase from vEduMSTRGiftedClsCase where " + strCondition;
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
 objSQL = clsvEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdEduMSTRGiftedClsCase from vEduMSTRGiftedClsCase where " + strCondition;
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
 objSQL = clsvEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vEduMSTRGiftedClsCase", "IdEduMSTRGiftedClsCase = " + "'"+ strIdEduMSTRGiftedClsCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vEduMSTRGiftedClsCase", strCondition))
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
objSQL = clsvEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vEduMSTRGiftedClsCase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseENS">源对象</param>
 /// <param name = "objvEduMSTRGiftedClsCaseENT">目标对象</param>
public void CopyTo(clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseENS, clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseENT)
{
objvEduMSTRGiftedClsCaseENT.IdEduMSTRGiftedClsCase = objvEduMSTRGiftedClsCaseENS.IdEduMSTRGiftedClsCase; //教育硕士优课案例流水号
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseID = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseID; //教育硕士优课案例ID
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseName = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseName; //教育硕士优课案例名称
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseTheme = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseTheme; //教育硕士优课案例主题词
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseDate = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseDate; //教育硕士优课案例日期
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseTime = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseTime; //教育硕士优课案例时间
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseDateIn = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseDateIn; //案例入库日期
objvEduMSTRGiftedClsCaseENT.IdStudyLevel = objvEduMSTRGiftedClsCaseENS.IdStudyLevel; //id_StudyLevel
objvEduMSTRGiftedClsCaseENT.StudyLevelName = objvEduMSTRGiftedClsCaseENS.StudyLevelName; //学段名称
objvEduMSTRGiftedClsCaseENT.IdTeachingPlan = objvEduMSTRGiftedClsCaseENS.IdTeachingPlan; //教案流水号
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseTimeIn = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseTimeIn; //案例入库时间
objvEduMSTRGiftedClsCaseENT.IdEduMSTRGiftedClsCaseType = objvEduMSTRGiftedClsCaseENS.IdEduMSTRGiftedClsCaseType; //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseTypeID = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseTypeID; //教育硕士优课案例类型Id
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseTypeName = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseTypeName; //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCaseENT.IdCaseType = objvEduMSTRGiftedClsCaseENS.IdCaseType; //案例类型流水号
objvEduMSTRGiftedClsCaseENT.IdDiscipline = objvEduMSTRGiftedClsCaseENS.IdDiscipline; //学科流水号
objvEduMSTRGiftedClsCaseENT.DisciplineID = objvEduMSTRGiftedClsCaseENS.DisciplineID; //学科ID
objvEduMSTRGiftedClsCaseENT.DisciplineName = objvEduMSTRGiftedClsCaseENS.DisciplineName; //学科名称
objvEduMSTRGiftedClsCaseENT.IdSenateGaugeVersion = objvEduMSTRGiftedClsCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvEduMSTRGiftedClsCaseENT.senateGaugeVersionID = objvEduMSTRGiftedClsCaseENS.senateGaugeVersionID; //评价量表版本ID
objvEduMSTRGiftedClsCaseENT.senateGaugeVersionName = objvEduMSTRGiftedClsCaseENS.senateGaugeVersionName; //评价量表版本名称
objvEduMSTRGiftedClsCaseENT.senateGaugeVersionTtlScore = objvEduMSTRGiftedClsCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvEduMSTRGiftedClsCaseENT.VersionNo = objvEduMSTRGiftedClsCaseENS.VersionNo; //版本号
objvEduMSTRGiftedClsCaseENT.IdTeachSkill = objvEduMSTRGiftedClsCaseENS.IdTeachSkill; //教学技能流水号
objvEduMSTRGiftedClsCaseENT.TeachSkillID = objvEduMSTRGiftedClsCaseENS.TeachSkillID; //教学技能ID
objvEduMSTRGiftedClsCaseENT.SkillTypeName = objvEduMSTRGiftedClsCaseENS.SkillTypeName; //技能类型名称
objvEduMSTRGiftedClsCaseENT.TeachSkillName = objvEduMSTRGiftedClsCaseENS.TeachSkillName; //教学技能名称
objvEduMSTRGiftedClsCaseENT.TeachSkillTheory = objvEduMSTRGiftedClsCaseENS.TeachSkillTheory; //教学技能理论阐述
objvEduMSTRGiftedClsCaseENT.TeachSkillOperMethod = objvEduMSTRGiftedClsCaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvEduMSTRGiftedClsCaseENT.IdSkillType = objvEduMSTRGiftedClsCaseENS.IdSkillType; //技能类型流水号
objvEduMSTRGiftedClsCaseENT.SkillTypeID = objvEduMSTRGiftedClsCaseENS.SkillTypeID; //技能类型ID
objvEduMSTRGiftedClsCaseENT.CaseLevelId = objvEduMSTRGiftedClsCaseENS.CaseLevelId; //课例等级Id
objvEduMSTRGiftedClsCaseENT.CaseLevelName = objvEduMSTRGiftedClsCaseENS.CaseLevelName; //案例等级名称
objvEduMSTRGiftedClsCaseENT.DocFile = objvEduMSTRGiftedClsCaseENS.DocFile; //生成的Word文件名
objvEduMSTRGiftedClsCaseENT.IsNeedGeneWord = objvEduMSTRGiftedClsCaseENS.IsNeedGeneWord; //是否需要生成Word
objvEduMSTRGiftedClsCaseENT.WordCreateDate = objvEduMSTRGiftedClsCaseENS.WordCreateDate; //Word生成日期
objvEduMSTRGiftedClsCaseENT.IsVisible = objvEduMSTRGiftedClsCaseENS.IsVisible; //是否显示
objvEduMSTRGiftedClsCaseENT.EduMSTRGiftedClsCaseText = objvEduMSTRGiftedClsCaseENS.EduMSTRGiftedClsCaseText; //教育硕士优课案例文本
objvEduMSTRGiftedClsCaseENT.OwnerId = objvEduMSTRGiftedClsCaseENS.OwnerId; //拥有者Id
objvEduMSTRGiftedClsCaseENT.IdStudentInfo = objvEduMSTRGiftedClsCaseENS.IdStudentInfo; //学生流水号
objvEduMSTRGiftedClsCaseENT.StuName = objvEduMSTRGiftedClsCaseENS.StuName; //姓名
objvEduMSTRGiftedClsCaseENT.StuId = objvEduMSTRGiftedClsCaseENS.StuId; //学号
objvEduMSTRGiftedClsCaseENT.PoliticsName = objvEduMSTRGiftedClsCaseENS.PoliticsName; //政治面貌
objvEduMSTRGiftedClsCaseENT.SexDesc = objvEduMSTRGiftedClsCaseENS.SexDesc; //性别名称
objvEduMSTRGiftedClsCaseENT.EthnicName = objvEduMSTRGiftedClsCaseENS.EthnicName; //民族名称
objvEduMSTRGiftedClsCaseENT.UniZoneDesc = objvEduMSTRGiftedClsCaseENS.UniZoneDesc; //校区名称
objvEduMSTRGiftedClsCaseENT.StuTypeDesc = objvEduMSTRGiftedClsCaseENS.StuTypeDesc; //学生类别名称
objvEduMSTRGiftedClsCaseENT.IdXzCollege = objvEduMSTRGiftedClsCaseENS.IdXzCollege; //学院流水号
objvEduMSTRGiftedClsCaseENT.CollegeId = objvEduMSTRGiftedClsCaseENS.CollegeId; //学院ID
objvEduMSTRGiftedClsCaseENT.CollegeName = objvEduMSTRGiftedClsCaseENS.CollegeName; //学院名称
objvEduMSTRGiftedClsCaseENT.CollegeNameA = objvEduMSTRGiftedClsCaseENS.CollegeNameA; //学院名称简写
objvEduMSTRGiftedClsCaseENT.IdXzMajor = objvEduMSTRGiftedClsCaseENS.IdXzMajor; //专业流水号
objvEduMSTRGiftedClsCaseENT.MajorName = objvEduMSTRGiftedClsCaseENS.MajorName; //专业名称
objvEduMSTRGiftedClsCaseENT.IdGradeBase = objvEduMSTRGiftedClsCaseENS.IdGradeBase; //年级流水号
objvEduMSTRGiftedClsCaseENT.GradeBaseName = objvEduMSTRGiftedClsCaseENS.GradeBaseName; //年级名称
objvEduMSTRGiftedClsCaseENT.IdAdminCls = objvEduMSTRGiftedClsCaseENS.IdAdminCls; //行政班流水号
objvEduMSTRGiftedClsCaseENT.AdminClsId = objvEduMSTRGiftedClsCaseENS.AdminClsId; //行政班代号
objvEduMSTRGiftedClsCaseENT.AdminClsName = objvEduMSTRGiftedClsCaseENS.AdminClsName; //行政班名称
objvEduMSTRGiftedClsCaseENT.Birthday = objvEduMSTRGiftedClsCaseENS.Birthday; //出生日期
objvEduMSTRGiftedClsCaseENT.NativePlace = objvEduMSTRGiftedClsCaseENS.NativePlace; //籍贯
objvEduMSTRGiftedClsCaseENT.Duty = objvEduMSTRGiftedClsCaseENS.Duty; //职位
objvEduMSTRGiftedClsCaseENT.IdCardNo = objvEduMSTRGiftedClsCaseENS.IdCardNo; //身份证号
objvEduMSTRGiftedClsCaseENT.StuCardNo = objvEduMSTRGiftedClsCaseENS.StuCardNo; //学生证号
objvEduMSTRGiftedClsCaseENT.LiveAddress = objvEduMSTRGiftedClsCaseENS.LiveAddress; //居住地址
objvEduMSTRGiftedClsCaseENT.HomePhone = objvEduMSTRGiftedClsCaseENS.HomePhone; //住宅电话
objvEduMSTRGiftedClsCaseENT.EnrollmentDate = objvEduMSTRGiftedClsCaseENS.EnrollmentDate; //入校日期
objvEduMSTRGiftedClsCaseENT.PostCode = objvEduMSTRGiftedClsCaseENS.PostCode; //邮编
objvEduMSTRGiftedClsCaseENT.IsDualVideo = objvEduMSTRGiftedClsCaseENS.IsDualVideo; //是否双视频
objvEduMSTRGiftedClsCaseENT.UserKindId = objvEduMSTRGiftedClsCaseENS.UserKindId; //用户类别Id
objvEduMSTRGiftedClsCaseENT.UserKindName = objvEduMSTRGiftedClsCaseENS.UserKindName; //用户类别名
objvEduMSTRGiftedClsCaseENT.UserTypeId = objvEduMSTRGiftedClsCaseENS.UserTypeId; //用户类型Id
objvEduMSTRGiftedClsCaseENT.UserTypeName = objvEduMSTRGiftedClsCaseENS.UserTypeName; //用户类型名称
objvEduMSTRGiftedClsCaseENT.RecommendedDegreeId = objvEduMSTRGiftedClsCaseENS.RecommendedDegreeId; //推荐度Id
objvEduMSTRGiftedClsCaseENT.RecommendedDegreeName = objvEduMSTRGiftedClsCaseENS.RecommendedDegreeName; //推荐度名称
objvEduMSTRGiftedClsCaseENT.ftpFileType = objvEduMSTRGiftedClsCaseENS.ftpFileType; //ftp文件类型
objvEduMSTRGiftedClsCaseENT.VideoUrl = objvEduMSTRGiftedClsCaseENS.VideoUrl; //视频Url
objvEduMSTRGiftedClsCaseENT.VideoPath = objvEduMSTRGiftedClsCaseENS.VideoPath; //视频目录
objvEduMSTRGiftedClsCaseENT.ResErrMsg = objvEduMSTRGiftedClsCaseENS.ResErrMsg; //资源错误信息
objvEduMSTRGiftedClsCaseENT.ResourceNum = objvEduMSTRGiftedClsCaseENS.ResourceNum; //资源数
objvEduMSTRGiftedClsCaseENT.Memo = objvEduMSTRGiftedClsCaseENS.Memo; //备注
objvEduMSTRGiftedClsCaseENT.BrowseCount4Case = objvEduMSTRGiftedClsCaseENS.BrowseCount4Case; //课例浏览次数
objvEduMSTRGiftedClsCaseENT.OwnerName = objvEduMSTRGiftedClsCaseENS.OwnerName; //拥有者姓名
objvEduMSTRGiftedClsCaseENT.OwnerNameWithId = objvEduMSTRGiftedClsCaseENS.OwnerNameWithId; //拥有者名称附Id
objvEduMSTRGiftedClsCaseENT.IsHaveVideo = objvEduMSTRGiftedClsCaseENS.IsHaveVideo; //IsHaveVideo
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvEduMSTRGiftedClsCaseEN objvEduMSTRGiftedClsCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase, 8, convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID, 8, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName, 100, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme, 200, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate, 8, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime, 6, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn, 8, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.IdStudyLevel, 4, convEduMSTRGiftedClsCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.StudyLevelName, 50, convEduMSTRGiftedClsCase.StudyLevelName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.IdTeachingPlan, 8, convEduMSTRGiftedClsCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn, 6, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType, 4, convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeID, 4, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeName, 50, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.IdCaseType, 4, convEduMSTRGiftedClsCase.IdCaseType);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.IdDiscipline, 4, convEduMSTRGiftedClsCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.DisciplineID, 4, convEduMSTRGiftedClsCase.DisciplineID);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.DisciplineName, 50, convEduMSTRGiftedClsCase.DisciplineName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion, 4, convEduMSTRGiftedClsCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.senateGaugeVersionID, 4, convEduMSTRGiftedClsCase.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.senateGaugeVersionName, 200, convEduMSTRGiftedClsCase.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.IdTeachSkill, 8, convEduMSTRGiftedClsCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.TeachSkillID, 8, convEduMSTRGiftedClsCase.TeachSkillID);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.SkillTypeName, 50, convEduMSTRGiftedClsCase.SkillTypeName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.TeachSkillName, 50, convEduMSTRGiftedClsCase.TeachSkillName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.TeachSkillTheory, 8000, convEduMSTRGiftedClsCase.TeachSkillTheory);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.TeachSkillOperMethod, 2000, convEduMSTRGiftedClsCase.TeachSkillOperMethod);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.IdSkillType, 4, convEduMSTRGiftedClsCase.IdSkillType);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.SkillTypeID, 4, convEduMSTRGiftedClsCase.SkillTypeID);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.CaseLevelId, 2, convEduMSTRGiftedClsCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.CaseLevelName, 30, convEduMSTRGiftedClsCase.CaseLevelName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.DocFile, 200, convEduMSTRGiftedClsCase.DocFile);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.WordCreateDate, 14, convEduMSTRGiftedClsCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText, 8000, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.OwnerId, 20, convEduMSTRGiftedClsCase.OwnerId);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.IdStudentInfo, 8, convEduMSTRGiftedClsCase.IdStudentInfo);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.StuName, 50, convEduMSTRGiftedClsCase.StuName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.StuId, 20, convEduMSTRGiftedClsCase.StuId);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.PoliticsName, 30, convEduMSTRGiftedClsCase.PoliticsName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.SexDesc, 10, convEduMSTRGiftedClsCase.SexDesc);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.EthnicName, 30, convEduMSTRGiftedClsCase.EthnicName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.UniZoneDesc, 20, convEduMSTRGiftedClsCase.UniZoneDesc);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.StuTypeDesc, 50, convEduMSTRGiftedClsCase.StuTypeDesc);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.IdXzCollege, 4, convEduMSTRGiftedClsCase.IdXzCollege);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.CollegeId, 4, convEduMSTRGiftedClsCase.CollegeId);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.CollegeName, 100, convEduMSTRGiftedClsCase.CollegeName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.CollegeNameA, 12, convEduMSTRGiftedClsCase.CollegeNameA);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.IdXzMajor, 8, convEduMSTRGiftedClsCase.IdXzMajor);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.MajorName, 100, convEduMSTRGiftedClsCase.MajorName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.IdGradeBase, 4, convEduMSTRGiftedClsCase.IdGradeBase);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.GradeBaseName, 50, convEduMSTRGiftedClsCase.GradeBaseName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.IdAdminCls, 8, convEduMSTRGiftedClsCase.IdAdminCls);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.AdminClsId, 8, convEduMSTRGiftedClsCase.AdminClsId);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.AdminClsName, 100, convEduMSTRGiftedClsCase.AdminClsName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.Birthday, 8, convEduMSTRGiftedClsCase.Birthday);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.NativePlace, 200, convEduMSTRGiftedClsCase.NativePlace);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.Duty, 30, convEduMSTRGiftedClsCase.Duty);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.IdCardNo, 20, convEduMSTRGiftedClsCase.IdCardNo);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.StuCardNo, 20, convEduMSTRGiftedClsCase.StuCardNo);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.LiveAddress, 200, convEduMSTRGiftedClsCase.LiveAddress);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.HomePhone, 20, convEduMSTRGiftedClsCase.HomePhone);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.EnrollmentDate, 8, convEduMSTRGiftedClsCase.EnrollmentDate);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.PostCode, 6, convEduMSTRGiftedClsCase.PostCode);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.UserKindId, 2, convEduMSTRGiftedClsCase.UserKindId);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.UserKindName, 30, convEduMSTRGiftedClsCase.UserKindName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.UserTypeId, 2, convEduMSTRGiftedClsCase.UserTypeId);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.UserTypeName, 20, convEduMSTRGiftedClsCase.UserTypeName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.RecommendedDegreeId, 2, convEduMSTRGiftedClsCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.RecommendedDegreeName, 30, convEduMSTRGiftedClsCase.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.ftpFileType, 30, convEduMSTRGiftedClsCase.ftpFileType);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.VideoUrl, 1000, convEduMSTRGiftedClsCase.VideoUrl);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.VideoPath, 1000, convEduMSTRGiftedClsCase.VideoPath);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.ResErrMsg, 30, convEduMSTRGiftedClsCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.Memo, 1000, convEduMSTRGiftedClsCase.Memo);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.OwnerName, 30, convEduMSTRGiftedClsCase.OwnerName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.OwnerNameWithId, 51, convEduMSTRGiftedClsCase.OwnerNameWithId);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseEN.IsHaveVideo, 6, convEduMSTRGiftedClsCase.IsHaveVideo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCase, convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCase);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseID, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseID);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseName, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTheme, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDate, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTime, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseDateIn, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.IdStudyLevel, convEduMSTRGiftedClsCase.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.StudyLevelName, convEduMSTRGiftedClsCase.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.IdTeachingPlan, convEduMSTRGiftedClsCase.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTimeIn, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.IdEduMSTRGiftedClsCaseType, convEduMSTRGiftedClsCase.IdEduMSTRGiftedClsCaseType);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeID, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeID);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseTypeName, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.IdCaseType, convEduMSTRGiftedClsCase.IdCaseType);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.IdDiscipline, convEduMSTRGiftedClsCase.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.DisciplineID, convEduMSTRGiftedClsCase.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.DisciplineName, convEduMSTRGiftedClsCase.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.IdSenateGaugeVersion, convEduMSTRGiftedClsCase.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.senateGaugeVersionID, convEduMSTRGiftedClsCase.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.senateGaugeVersionName, convEduMSTRGiftedClsCase.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.IdTeachSkill, convEduMSTRGiftedClsCase.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.TeachSkillID, convEduMSTRGiftedClsCase.TeachSkillID);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.SkillTypeName, convEduMSTRGiftedClsCase.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.TeachSkillName, convEduMSTRGiftedClsCase.TeachSkillName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.TeachSkillTheory, convEduMSTRGiftedClsCase.TeachSkillTheory);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.TeachSkillOperMethod, convEduMSTRGiftedClsCase.TeachSkillOperMethod);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.IdSkillType, convEduMSTRGiftedClsCase.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.SkillTypeID, convEduMSTRGiftedClsCase.SkillTypeID);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.CaseLevelId, convEduMSTRGiftedClsCase.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.CaseLevelName, convEduMSTRGiftedClsCase.CaseLevelName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.DocFile, convEduMSTRGiftedClsCase.DocFile);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.WordCreateDate, convEduMSTRGiftedClsCase.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.EduMSTRGiftedClsCaseText, convEduMSTRGiftedClsCase.EduMSTRGiftedClsCaseText);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.OwnerId, convEduMSTRGiftedClsCase.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.IdStudentInfo, convEduMSTRGiftedClsCase.IdStudentInfo);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.StuName, convEduMSTRGiftedClsCase.StuName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.StuId, convEduMSTRGiftedClsCase.StuId);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.PoliticsName, convEduMSTRGiftedClsCase.PoliticsName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.SexDesc, convEduMSTRGiftedClsCase.SexDesc);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.EthnicName, convEduMSTRGiftedClsCase.EthnicName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.UniZoneDesc, convEduMSTRGiftedClsCase.UniZoneDesc);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.StuTypeDesc, convEduMSTRGiftedClsCase.StuTypeDesc);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.IdXzCollege, convEduMSTRGiftedClsCase.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.CollegeId, convEduMSTRGiftedClsCase.CollegeId);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.CollegeName, convEduMSTRGiftedClsCase.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.CollegeNameA, convEduMSTRGiftedClsCase.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.IdXzMajor, convEduMSTRGiftedClsCase.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.MajorName, convEduMSTRGiftedClsCase.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.IdGradeBase, convEduMSTRGiftedClsCase.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.GradeBaseName, convEduMSTRGiftedClsCase.GradeBaseName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.IdAdminCls, convEduMSTRGiftedClsCase.IdAdminCls);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.AdminClsId, convEduMSTRGiftedClsCase.AdminClsId);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.AdminClsName, convEduMSTRGiftedClsCase.AdminClsName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.Birthday, convEduMSTRGiftedClsCase.Birthday);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.NativePlace, convEduMSTRGiftedClsCase.NativePlace);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.Duty, convEduMSTRGiftedClsCase.Duty);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.IdCardNo, convEduMSTRGiftedClsCase.IdCardNo);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.StuCardNo, convEduMSTRGiftedClsCase.StuCardNo);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.LiveAddress, convEduMSTRGiftedClsCase.LiveAddress);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.HomePhone, convEduMSTRGiftedClsCase.HomePhone);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.EnrollmentDate, convEduMSTRGiftedClsCase.EnrollmentDate);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.PostCode, convEduMSTRGiftedClsCase.PostCode);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.UserKindId, convEduMSTRGiftedClsCase.UserKindId);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.UserKindName, convEduMSTRGiftedClsCase.UserKindName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.UserTypeId, convEduMSTRGiftedClsCase.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.UserTypeName, convEduMSTRGiftedClsCase.UserTypeName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.RecommendedDegreeId, convEduMSTRGiftedClsCase.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.RecommendedDegreeName, convEduMSTRGiftedClsCase.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.ftpFileType, convEduMSTRGiftedClsCase.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.VideoUrl, convEduMSTRGiftedClsCase.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.VideoPath, convEduMSTRGiftedClsCase.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.ResErrMsg, convEduMSTRGiftedClsCase.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.Memo, convEduMSTRGiftedClsCase.Memo);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.OwnerName, convEduMSTRGiftedClsCase.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.OwnerNameWithId, convEduMSTRGiftedClsCase.OwnerNameWithId);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseEN.IsHaveVideo, convEduMSTRGiftedClsCase.IsHaveVideo);
//检查外键字段长度
 objvEduMSTRGiftedClsCaseEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdEduMSTRGiftedClsCase()
{
//获取某学院所有专业信息
string strSQL = "select IdEduMSTRGiftedClsCase, EduMSTRGiftedClsCaseName from vEduMSTRGiftedClsCase ";
 clsSpecSQLforSql mySql = clsvEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
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
 objSQL = clsvEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
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
 objSQL = clsvEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
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
 objSQL = clsvEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvEduMSTRGiftedClsCaseEN._CurrTabName);
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
 objSQL = clsvEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvEduMSTRGiftedClsCaseEN._CurrTabName, strCondition);
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
 objSQL = clsvEduMSTRGiftedClsCaseDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}