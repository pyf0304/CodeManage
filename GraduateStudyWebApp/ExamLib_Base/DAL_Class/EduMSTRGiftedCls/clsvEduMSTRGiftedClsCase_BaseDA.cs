
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvEduMSTRGiftedClsCase_BaseDA
 表名:vEduMSTRGiftedClsCase_Base(01120498)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:25:02
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
 /// v教育硕士优课案例_Base(vEduMSTRGiftedClsCase_Base)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvEduMSTRGiftedClsCase_BaseDA : clsCommBase4DA
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
 return clsvEduMSTRGiftedClsCase_BaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvEduMSTRGiftedClsCase_BaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvEduMSTRGiftedClsCase_BaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvEduMSTRGiftedClsCase_BaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvEduMSTRGiftedClsCase_BaseEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vEduMSTRGiftedClsCase_Base中,检查关键字,长度不正确!(clsvEduMSTRGiftedClsCase_BaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdEduMSTRGiftedClsCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vEduMSTRGiftedClsCase_Base中,关键字不能为空 或 null!(clsvEduMSTRGiftedClsCase_BaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdEduMSTRGiftedClsCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvEduMSTRGiftedClsCase_BaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCase_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCase_Base where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vEduMSTRGiftedClsCase_Base(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCase_BaseDA: GetDataTable_vEduMSTRGiftedClsCase_Base)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCase_Base where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCase_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCase_BaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCase_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCase_Base where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCase_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCase_BaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCase_BaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCase_BaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCase_Base where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCase_Base where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCase_BaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCase_BaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCase_Base where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCase_BaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCase_BaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vEduMSTRGiftedClsCase_Base.* from vEduMSTRGiftedClsCase_Base Left Join {1} on {2} where {3} and vEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase not in (Select top {5} vEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase from vEduMSTRGiftedClsCase_Base Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCase_Base where {1} and IdEduMSTRGiftedClsCase not in (Select top {2} IdEduMSTRGiftedClsCase from vEduMSTRGiftedClsCase_Base where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCase_Base where {1} and IdEduMSTRGiftedClsCase not in (Select top {3} IdEduMSTRGiftedClsCase from vEduMSTRGiftedClsCase_Base where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCase_BaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCase_BaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vEduMSTRGiftedClsCase_Base.* from vEduMSTRGiftedClsCase_Base Left Join {1} on {2} where {3} and vEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase not in (Select top {5} vEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase from vEduMSTRGiftedClsCase_Base Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCase_Base where {1} and IdEduMSTRGiftedClsCase not in (Select top {2} IdEduMSTRGiftedClsCase from vEduMSTRGiftedClsCase_Base where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCase_Base where {1} and IdEduMSTRGiftedClsCase not in (Select top {3} IdEduMSTRGiftedClsCase from vEduMSTRGiftedClsCase_Base where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvEduMSTRGiftedClsCase_BaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCase_BaseDA:GetObjLst)", objException.Message));
}
List<clsvEduMSTRGiftedClsCase_BaseEN> arrObjLst = new List<clsvEduMSTRGiftedClsCase_BaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCase_Base where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN = new clsvEduMSTRGiftedClsCase_BaseEN();
try
{
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objvEduMSTRGiftedClsCase_BaseEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvEduMSTRGiftedClsCase_BaseEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvEduMSTRGiftedClsCase_BaseEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCase_BaseEN.IdCaseType = objRow[convEduMSTRGiftedClsCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvEduMSTRGiftedClsCase_BaseEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvEduMSTRGiftedClsCase_BaseEN.DisciplineID = objRow[convEduMSTRGiftedClsCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvEduMSTRGiftedClsCase_BaseEN.DisciplineName = objRow[convEduMSTRGiftedClsCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvEduMSTRGiftedClsCase_BaseEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionTtlScore = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCase_BaseEN.VersionNo = objRow[convEduMSTRGiftedClsCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Base.VersionNo].ToString().Trim()); //版本号
objvEduMSTRGiftedClsCase_BaseEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvEduMSTRGiftedClsCase_BaseEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvEduMSTRGiftedClsCase_BaseEN.IdSkillType = objRow[convEduMSTRGiftedClsCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvEduMSTRGiftedClsCase_BaseEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvEduMSTRGiftedClsCase_BaseEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvEduMSTRGiftedClsCase_BaseEN.CaseLevelName = objRow[convEduMSTRGiftedClsCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvEduMSTRGiftedClsCase_BaseEN.DocFile = objRow[convEduMSTRGiftedClsCase_Base.DocFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvEduMSTRGiftedClsCase_BaseEN.IsNeedGeneWord = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvEduMSTRGiftedClsCase_BaseEN.WordCreateDate = objRow[convEduMSTRGiftedClsCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvEduMSTRGiftedClsCase_BaseEN.IsVisible = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Base.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objvEduMSTRGiftedClsCase_BaseEN.OwnerId = objRow[convEduMSTRGiftedClsCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCase_BaseEN.StuName = objRow[convEduMSTRGiftedClsCase_Base.StuName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCase_BaseEN.StuId = objRow[convEduMSTRGiftedClsCase_Base.StuId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuId].ToString().Trim(); //学号
objvEduMSTRGiftedClsCase_BaseEN.SexDesc = objRow[convEduMSTRGiftedClsCase_Base.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SexDesc].ToString().Trim(); //性别名称
objvEduMSTRGiftedClsCase_BaseEN.StuTypeID = objRow[convEduMSTRGiftedClsCase_Base.StuTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuTypeID].ToString().Trim(); //学生类别ID
objvEduMSTRGiftedClsCase_BaseEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称
objvEduMSTRGiftedClsCase_BaseEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCase_BaseEN.CollegeId = objRow[convEduMSTRGiftedClsCase_Base.CollegeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeId].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCase_BaseEN.CollegeName = objRow[convEduMSTRGiftedClsCase_Base.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCase_BaseEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCase_BaseEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvEduMSTRGiftedClsCase_BaseEN.MajorName = objRow[convEduMSTRGiftedClsCase_Base.MajorName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCase_BaseEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdGradeBase].ToString().Trim(); //年级流水号
objvEduMSTRGiftedClsCase_BaseEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.GradeBaseName].ToString().Trim(); //年级名称
objvEduMSTRGiftedClsCase_BaseEN.StuCardNo = objRow[convEduMSTRGiftedClsCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuCardNo].ToString().Trim(); //学生证号
objvEduMSTRGiftedClsCase_BaseEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EnrollmentDate].ToString().Trim(); //入校日期
objvEduMSTRGiftedClsCase_BaseEN.IsDualVideo = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvEduMSTRGiftedClsCase_BaseEN.UserTypeId = objRow[convEduMSTRGiftedClsCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvEduMSTRGiftedClsCase_BaseEN.ftpFileType = objRow[convEduMSTRGiftedClsCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCase_BaseEN.VideoUrl = objRow[convEduMSTRGiftedClsCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvEduMSTRGiftedClsCase_BaseEN.VideoPath = objRow[convEduMSTRGiftedClsCase_Base.VideoPath] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.VideoPath].ToString().Trim(); //视频目录
objvEduMSTRGiftedClsCase_BaseEN.ResErrMsg = objRow[convEduMSTRGiftedClsCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvEduMSTRGiftedClsCase_BaseEN.ResourceNum = objRow[convEduMSTRGiftedClsCase_Base.ResourceNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Base.ResourceNum].ToString().Trim()); //资源数
objvEduMSTRGiftedClsCase_BaseEN.Memo = objRow[convEduMSTRGiftedClsCase_Base.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.Memo].ToString().Trim(); //备注
objvEduMSTRGiftedClsCase_BaseEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvEduMSTRGiftedClsCase_BaseEN.OwnerName = objRow[convEduMSTRGiftedClsCase_Base.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCase_BaseEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvEduMSTRGiftedClsCase_BaseDA: GetObjLst)", objException.Message));
}
objvEduMSTRGiftedClsCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvEduMSTRGiftedClsCase_BaseEN);
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
public List<clsvEduMSTRGiftedClsCase_BaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCase_BaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsvEduMSTRGiftedClsCase_BaseEN> arrObjLst = new List<clsvEduMSTRGiftedClsCase_BaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCase_BaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN = new clsvEduMSTRGiftedClsCase_BaseEN();
try
{
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objvEduMSTRGiftedClsCase_BaseEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvEduMSTRGiftedClsCase_BaseEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvEduMSTRGiftedClsCase_BaseEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCase_BaseEN.IdCaseType = objRow[convEduMSTRGiftedClsCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvEduMSTRGiftedClsCase_BaseEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvEduMSTRGiftedClsCase_BaseEN.DisciplineID = objRow[convEduMSTRGiftedClsCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvEduMSTRGiftedClsCase_BaseEN.DisciplineName = objRow[convEduMSTRGiftedClsCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvEduMSTRGiftedClsCase_BaseEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionTtlScore = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCase_BaseEN.VersionNo = objRow[convEduMSTRGiftedClsCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Base.VersionNo].ToString().Trim()); //版本号
objvEduMSTRGiftedClsCase_BaseEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvEduMSTRGiftedClsCase_BaseEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvEduMSTRGiftedClsCase_BaseEN.IdSkillType = objRow[convEduMSTRGiftedClsCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvEduMSTRGiftedClsCase_BaseEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvEduMSTRGiftedClsCase_BaseEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvEduMSTRGiftedClsCase_BaseEN.CaseLevelName = objRow[convEduMSTRGiftedClsCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvEduMSTRGiftedClsCase_BaseEN.DocFile = objRow[convEduMSTRGiftedClsCase_Base.DocFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvEduMSTRGiftedClsCase_BaseEN.IsNeedGeneWord = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvEduMSTRGiftedClsCase_BaseEN.WordCreateDate = objRow[convEduMSTRGiftedClsCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvEduMSTRGiftedClsCase_BaseEN.IsVisible = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Base.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objvEduMSTRGiftedClsCase_BaseEN.OwnerId = objRow[convEduMSTRGiftedClsCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCase_BaseEN.StuName = objRow[convEduMSTRGiftedClsCase_Base.StuName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCase_BaseEN.StuId = objRow[convEduMSTRGiftedClsCase_Base.StuId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuId].ToString().Trim(); //学号
objvEduMSTRGiftedClsCase_BaseEN.SexDesc = objRow[convEduMSTRGiftedClsCase_Base.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SexDesc].ToString().Trim(); //性别名称
objvEduMSTRGiftedClsCase_BaseEN.StuTypeID = objRow[convEduMSTRGiftedClsCase_Base.StuTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuTypeID].ToString().Trim(); //学生类别ID
objvEduMSTRGiftedClsCase_BaseEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称
objvEduMSTRGiftedClsCase_BaseEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCase_BaseEN.CollegeId = objRow[convEduMSTRGiftedClsCase_Base.CollegeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeId].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCase_BaseEN.CollegeName = objRow[convEduMSTRGiftedClsCase_Base.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCase_BaseEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCase_BaseEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvEduMSTRGiftedClsCase_BaseEN.MajorName = objRow[convEduMSTRGiftedClsCase_Base.MajorName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCase_BaseEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdGradeBase].ToString().Trim(); //年级流水号
objvEduMSTRGiftedClsCase_BaseEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.GradeBaseName].ToString().Trim(); //年级名称
objvEduMSTRGiftedClsCase_BaseEN.StuCardNo = objRow[convEduMSTRGiftedClsCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuCardNo].ToString().Trim(); //学生证号
objvEduMSTRGiftedClsCase_BaseEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EnrollmentDate].ToString().Trim(); //入校日期
objvEduMSTRGiftedClsCase_BaseEN.IsDualVideo = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvEduMSTRGiftedClsCase_BaseEN.UserTypeId = objRow[convEduMSTRGiftedClsCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvEduMSTRGiftedClsCase_BaseEN.ftpFileType = objRow[convEduMSTRGiftedClsCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCase_BaseEN.VideoUrl = objRow[convEduMSTRGiftedClsCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvEduMSTRGiftedClsCase_BaseEN.VideoPath = objRow[convEduMSTRGiftedClsCase_Base.VideoPath] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.VideoPath].ToString().Trim(); //视频目录
objvEduMSTRGiftedClsCase_BaseEN.ResErrMsg = objRow[convEduMSTRGiftedClsCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvEduMSTRGiftedClsCase_BaseEN.ResourceNum = objRow[convEduMSTRGiftedClsCase_Base.ResourceNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Base.ResourceNum].ToString().Trim()); //资源数
objvEduMSTRGiftedClsCase_BaseEN.Memo = objRow[convEduMSTRGiftedClsCase_Base.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.Memo].ToString().Trim(); //备注
objvEduMSTRGiftedClsCase_BaseEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvEduMSTRGiftedClsCase_BaseEN.OwnerName = objRow[convEduMSTRGiftedClsCase_Base.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCase_BaseEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvEduMSTRGiftedClsCase_BaseDA: GetObjLst)", objException.Message));
}
objvEduMSTRGiftedClsCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvEduMSTRGiftedClsCase_BaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvEduMSTRGiftedClsCase_Base(ref clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCase_Base where IdEduMSTRGiftedClsCase = " + "'"+ objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseID = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseName = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTheme = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDate = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTime = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间(字段类型:char,字段长度:6,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDateIn = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.IdStudyLevel = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.StudyLevelName = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.IdTeachingPlan = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTimeIn = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCaseType = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTypeName = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.IdCaseType = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.IdDiscipline = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.DisciplineID = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.DisciplineName = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.IdSenateGaugeVersion = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionID = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionName = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.VersionNo = TransNullToInt(objDT.Rows[0][convEduMSTRGiftedClsCase_Base.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.IdTeachSkill = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.TeachSkillID = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.SkillTypeName = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.TeachSkillName = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.TeachSkillTheory = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.TeachSkillOperMethod = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.IdSkillType = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.SkillTypeID = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.CaseLevelId = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.CaseLevelName = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.DocFile = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][convEduMSTRGiftedClsCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.WordCreateDate = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.IsVisible = TransNullToBool(objDT.Rows[0][convEduMSTRGiftedClsCase_Base.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseText = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本(字段类型:varchar,字段长度:8000,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.OwnerId = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.StuName = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.StuId = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.StuId].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.SexDesc = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.SexDesc].ToString().Trim(); //性别名称(字段类型:varchar,字段长度:10,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.StuTypeID = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.StuTypeID].ToString().Trim(); //学生类别ID(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.StuTypeDesc = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.IdXzCollege = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.CollegeId = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.CollegeName = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.CollegeNameA = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.IdXzMajor = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.MajorName = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.IdGradeBase = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.GradeBaseName = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.StuCardNo = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.StuCardNo].ToString().Trim(); //学生证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.EnrollmentDate = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.EnrollmentDate].ToString().Trim(); //入校日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convEduMSTRGiftedClsCase_Base.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.UserTypeId = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeId = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeName = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.ftpFileType = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.VideoUrl = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.VideoPath = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.ResErrMsg = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.ResourceNum = TransNullToInt(objDT.Rows[0][convEduMSTRGiftedClsCase_Base.ResourceNum].ToString().Trim()); //资源数(字段类型:int,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.Memo = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convEduMSTRGiftedClsCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.OwnerName = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.OwnerNameWithId = objDT.Rows[0][convEduMSTRGiftedClsCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvEduMSTRGiftedClsCase_BaseDA: GetvEduMSTRGiftedClsCase_Base)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdEduMSTRGiftedClsCase">表关键字</param>
 /// <returns>表对象</returns>
public clsvEduMSTRGiftedClsCase_BaseEN GetObjByIdEduMSTRGiftedClsCase(string strIdEduMSTRGiftedClsCase)
{
CheckPrimaryKey(strIdEduMSTRGiftedClsCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCase_Base where IdEduMSTRGiftedClsCase = " + "'"+ strIdEduMSTRGiftedClsCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN = new clsvEduMSTRGiftedClsCase_BaseEN();
try
{
 objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间(字段类型:char,字段长度:6,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.IdCaseType = objRow[convEduMSTRGiftedClsCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase_Base.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.DisciplineID = objRow[convEduMSTRGiftedClsCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.DisciplineName = objRow[convEduMSTRGiftedClsCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionTtlScore = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.VersionNo = objRow[convEduMSTRGiftedClsCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.IdSkillType = objRow[convEduMSTRGiftedClsCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.CaseLevelName = objRow[convEduMSTRGiftedClsCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.DocFile = objRow[convEduMSTRGiftedClsCase_Base.DocFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.WordCreateDate = objRow[convEduMSTRGiftedClsCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本(字段类型:varchar,字段长度:8000,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.OwnerId = objRow[convEduMSTRGiftedClsCase_Base.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.StuName = objRow[convEduMSTRGiftedClsCase_Base.StuName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.StuId = objRow[convEduMSTRGiftedClsCase_Base.StuId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuId].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.SexDesc = objRow[convEduMSTRGiftedClsCase_Base.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SexDesc].ToString().Trim(); //性别名称(字段类型:varchar,字段长度:10,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.StuTypeID = objRow[convEduMSTRGiftedClsCase_Base.StuTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuTypeID].ToString().Trim(); //学生类别ID(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.CollegeId = objRow[convEduMSTRGiftedClsCase_Base.CollegeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.CollegeName = objRow[convEduMSTRGiftedClsCase_Base.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.MajorName = objRow[convEduMSTRGiftedClsCase_Base.MajorName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.StuCardNo = objRow[convEduMSTRGiftedClsCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuCardNo].ToString().Trim(); //学生证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EnrollmentDate].ToString().Trim(); //入校日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Base.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.UserTypeId = objRow[convEduMSTRGiftedClsCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvEduMSTRGiftedClsCase_BaseEN.ftpFileType = objRow[convEduMSTRGiftedClsCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.VideoUrl = objRow[convEduMSTRGiftedClsCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.VideoPath = objRow[convEduMSTRGiftedClsCase_Base.VideoPath] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.ResErrMsg = objRow[convEduMSTRGiftedClsCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.ResourceNum = objRow[convEduMSTRGiftedClsCase_Base.ResourceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.ResourceNum].ToString().Trim()); //资源数(字段类型:int,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.Memo = objRow[convEduMSTRGiftedClsCase_Base.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.OwnerName = objRow[convEduMSTRGiftedClsCase_Base.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvEduMSTRGiftedClsCase_BaseEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvEduMSTRGiftedClsCase_BaseDA: GetObjByIdEduMSTRGiftedClsCase)", objException.Message));
}
return objvEduMSTRGiftedClsCase_BaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvEduMSTRGiftedClsCase_BaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCase_BaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCase_Base where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN = new clsvEduMSTRGiftedClsCase_BaseEN()
{
IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase].ToString().Trim(), //教育硕士优课案例流水号
EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID].ToString().Trim(), //教育硕士优课案例ID
EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName].ToString().Trim(), //教育硕士优课案例名称
EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme].ToString().Trim(), //教育硕士优课案例主题词
EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate].ToString().Trim(), //教育硕士优课案例日期
EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime].ToString().Trim(), //教育硕士优课案例时间
EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn].ToString().Trim(), //案例入库日期
IdStudyLevel = objRow[convEduMSTRGiftedClsCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convEduMSTRGiftedClsCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StudyLevelName].ToString().Trim(), //学段名称
IdTeachingPlan = objRow[convEduMSTRGiftedClsCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdTeachingPlan].ToString().Trim(), //教案流水号
EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(), //案例入库时间
IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType].ToString().Trim(), //教育硕士优课案例类型流水号
EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName].ToString().Trim(), //教育硕士优课案例类型名称
IdCaseType = objRow[convEduMSTRGiftedClsCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdCaseType].ToString().Trim(), //案例类型流水号
IdDiscipline = objRow[convEduMSTRGiftedClsCase_Base.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convEduMSTRGiftedClsCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convEduMSTRGiftedClsCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DisciplineName].ToString().Trim(), //学科名称
IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
VersionNo = objRow[convEduMSTRGiftedClsCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Base.VersionNo].ToString().Trim()), //版本号
IdTeachSkill = objRow[convEduMSTRGiftedClsCase_Base.IdTeachSkill].ToString().Trim(), //教学技能流水号
TeachSkillID = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillID].ToString().Trim(), //教学技能ID
SkillTypeName = objRow[convEduMSTRGiftedClsCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SkillTypeName].ToString().Trim(), //技能类型名称
TeachSkillName = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillName].ToString().Trim(), //教学技能名称
TeachSkillTheory = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillTheory].ToString().Trim(), //教学技能理论阐述
TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod].ToString().Trim(), //教学技能实践操作方法
IdSkillType = objRow[convEduMSTRGiftedClsCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdSkillType].ToString().Trim(), //技能类型流水号
SkillTypeID = objRow[convEduMSTRGiftedClsCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SkillTypeID].ToString().Trim(), //技能类型ID
CaseLevelId = objRow[convEduMSTRGiftedClsCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CaseLevelId].ToString().Trim(), //课例等级Id
CaseLevelName = objRow[convEduMSTRGiftedClsCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CaseLevelName].ToString().Trim(), //案例等级名称
DocFile = objRow[convEduMSTRGiftedClsCase_Base.DocFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DocFile].ToString().Trim(), //生成的Word文件名
IsNeedGeneWord = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Base.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
WordCreateDate = objRow[convEduMSTRGiftedClsCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.WordCreateDate].ToString().Trim(), //Word生成日期
IsVisible = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Base.IsVisible].ToString().Trim()), //是否显示
EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText].ToString().Trim(), //教育硕士优课案例文本
OwnerId = objRow[convEduMSTRGiftedClsCase_Base.OwnerId].ToString().Trim(), //拥有者Id
StuName = objRow[convEduMSTRGiftedClsCase_Base.StuName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuName].ToString().Trim(), //姓名
StuId = objRow[convEduMSTRGiftedClsCase_Base.StuId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuId].ToString().Trim(), //学号
SexDesc = objRow[convEduMSTRGiftedClsCase_Base.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SexDesc].ToString().Trim(), //性别名称
StuTypeID = objRow[convEduMSTRGiftedClsCase_Base.StuTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuTypeID].ToString().Trim(), //学生类别ID
StuTypeDesc = objRow[convEduMSTRGiftedClsCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuTypeDesc].ToString().Trim(), //学生类别名称
IdXzCollege = objRow[convEduMSTRGiftedClsCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdXzCollege].ToString().Trim(), //学院流水号
CollegeId = objRow[convEduMSTRGiftedClsCase_Base.CollegeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeId].ToString().Trim(), //学院ID
CollegeName = objRow[convEduMSTRGiftedClsCase_Base.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convEduMSTRGiftedClsCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeNameA].ToString().Trim(), //学院名称简写
IdXzMajor = objRow[convEduMSTRGiftedClsCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdXzMajor].ToString().Trim(), //专业流水号
MajorName = objRow[convEduMSTRGiftedClsCase_Base.MajorName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.MajorName].ToString().Trim(), //专业名称
IdGradeBase = objRow[convEduMSTRGiftedClsCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdGradeBase].ToString().Trim(), //年级流水号
GradeBaseName = objRow[convEduMSTRGiftedClsCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.GradeBaseName].ToString().Trim(), //年级名称
StuCardNo = objRow[convEduMSTRGiftedClsCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuCardNo].ToString().Trim(), //学生证号
EnrollmentDate = objRow[convEduMSTRGiftedClsCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EnrollmentDate].ToString().Trim(), //入校日期
IsDualVideo = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Base.IsDualVideo].ToString().Trim()), //是否双视频
UserTypeId = objRow[convEduMSTRGiftedClsCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.UserTypeId].ToString().Trim(), //用户类型Id
RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName].ToString().Trim(), //推荐度名称
ftpFileType = objRow[convEduMSTRGiftedClsCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.ftpFileType].ToString().Trim(), //ftp文件类型
VideoUrl = objRow[convEduMSTRGiftedClsCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[convEduMSTRGiftedClsCase_Base.VideoPath] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.VideoPath].ToString().Trim(), //视频目录
ResErrMsg = objRow[convEduMSTRGiftedClsCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.ResErrMsg].ToString().Trim(), //资源错误信息
ResourceNum = objRow[convEduMSTRGiftedClsCase_Base.ResourceNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Base.ResourceNum].ToString().Trim()), //资源数
Memo = objRow[convEduMSTRGiftedClsCase_Base.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.Memo].ToString().Trim(), //备注
BrowseCount4Case = objRow[convEduMSTRGiftedClsCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Base.BrowseCount4Case].ToString().Trim()), //课例浏览次数
OwnerName = objRow[convEduMSTRGiftedClsCase_Base.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.OwnerName].ToString().Trim(), //拥有者姓名
OwnerNameWithId = objRow[convEduMSTRGiftedClsCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.OwnerNameWithId].ToString().Trim() //拥有者名称附Id
};
objvEduMSTRGiftedClsCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvEduMSTRGiftedClsCase_BaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvEduMSTRGiftedClsCase_BaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvEduMSTRGiftedClsCase_BaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN = new clsvEduMSTRGiftedClsCase_BaseEN();
try
{
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objvEduMSTRGiftedClsCase_BaseEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvEduMSTRGiftedClsCase_BaseEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvEduMSTRGiftedClsCase_BaseEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCase_BaseEN.IdCaseType = objRow[convEduMSTRGiftedClsCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvEduMSTRGiftedClsCase_BaseEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvEduMSTRGiftedClsCase_BaseEN.DisciplineID = objRow[convEduMSTRGiftedClsCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvEduMSTRGiftedClsCase_BaseEN.DisciplineName = objRow[convEduMSTRGiftedClsCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvEduMSTRGiftedClsCase_BaseEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionTtlScore = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCase_BaseEN.VersionNo = objRow[convEduMSTRGiftedClsCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Base.VersionNo].ToString().Trim()); //版本号
objvEduMSTRGiftedClsCase_BaseEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvEduMSTRGiftedClsCase_BaseEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvEduMSTRGiftedClsCase_BaseEN.IdSkillType = objRow[convEduMSTRGiftedClsCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvEduMSTRGiftedClsCase_BaseEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvEduMSTRGiftedClsCase_BaseEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvEduMSTRGiftedClsCase_BaseEN.CaseLevelName = objRow[convEduMSTRGiftedClsCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvEduMSTRGiftedClsCase_BaseEN.DocFile = objRow[convEduMSTRGiftedClsCase_Base.DocFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvEduMSTRGiftedClsCase_BaseEN.IsNeedGeneWord = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvEduMSTRGiftedClsCase_BaseEN.WordCreateDate = objRow[convEduMSTRGiftedClsCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvEduMSTRGiftedClsCase_BaseEN.IsVisible = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Base.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objvEduMSTRGiftedClsCase_BaseEN.OwnerId = objRow[convEduMSTRGiftedClsCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCase_BaseEN.StuName = objRow[convEduMSTRGiftedClsCase_Base.StuName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCase_BaseEN.StuId = objRow[convEduMSTRGiftedClsCase_Base.StuId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuId].ToString().Trim(); //学号
objvEduMSTRGiftedClsCase_BaseEN.SexDesc = objRow[convEduMSTRGiftedClsCase_Base.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SexDesc].ToString().Trim(); //性别名称
objvEduMSTRGiftedClsCase_BaseEN.StuTypeID = objRow[convEduMSTRGiftedClsCase_Base.StuTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuTypeID].ToString().Trim(); //学生类别ID
objvEduMSTRGiftedClsCase_BaseEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称
objvEduMSTRGiftedClsCase_BaseEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCase_BaseEN.CollegeId = objRow[convEduMSTRGiftedClsCase_Base.CollegeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeId].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCase_BaseEN.CollegeName = objRow[convEduMSTRGiftedClsCase_Base.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCase_BaseEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCase_BaseEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvEduMSTRGiftedClsCase_BaseEN.MajorName = objRow[convEduMSTRGiftedClsCase_Base.MajorName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCase_BaseEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdGradeBase].ToString().Trim(); //年级流水号
objvEduMSTRGiftedClsCase_BaseEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.GradeBaseName].ToString().Trim(); //年级名称
objvEduMSTRGiftedClsCase_BaseEN.StuCardNo = objRow[convEduMSTRGiftedClsCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuCardNo].ToString().Trim(); //学生证号
objvEduMSTRGiftedClsCase_BaseEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EnrollmentDate].ToString().Trim(); //入校日期
objvEduMSTRGiftedClsCase_BaseEN.IsDualVideo = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvEduMSTRGiftedClsCase_BaseEN.UserTypeId = objRow[convEduMSTRGiftedClsCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvEduMSTRGiftedClsCase_BaseEN.ftpFileType = objRow[convEduMSTRGiftedClsCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCase_BaseEN.VideoUrl = objRow[convEduMSTRGiftedClsCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvEduMSTRGiftedClsCase_BaseEN.VideoPath = objRow[convEduMSTRGiftedClsCase_Base.VideoPath] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.VideoPath].ToString().Trim(); //视频目录
objvEduMSTRGiftedClsCase_BaseEN.ResErrMsg = objRow[convEduMSTRGiftedClsCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvEduMSTRGiftedClsCase_BaseEN.ResourceNum = objRow[convEduMSTRGiftedClsCase_Base.ResourceNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Base.ResourceNum].ToString().Trim()); //资源数
objvEduMSTRGiftedClsCase_BaseEN.Memo = objRow[convEduMSTRGiftedClsCase_Base.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.Memo].ToString().Trim(); //备注
objvEduMSTRGiftedClsCase_BaseEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvEduMSTRGiftedClsCase_BaseEN.OwnerName = objRow[convEduMSTRGiftedClsCase_Base.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCase_BaseEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvEduMSTRGiftedClsCase_BaseDA: GetObjByDataRowvEduMSTRGiftedClsCase_Base)", objException.Message));
}
objvEduMSTRGiftedClsCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvEduMSTRGiftedClsCase_BaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvEduMSTRGiftedClsCase_BaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN = new clsvEduMSTRGiftedClsCase_BaseEN();
try
{
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objvEduMSTRGiftedClsCase_BaseEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvEduMSTRGiftedClsCase_BaseEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvEduMSTRGiftedClsCase_BaseEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCase_BaseEN.IdCaseType = objRow[convEduMSTRGiftedClsCase_Base.IdCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdCaseType].ToString().Trim(); //案例类型流水号
objvEduMSTRGiftedClsCase_BaseEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvEduMSTRGiftedClsCase_BaseEN.DisciplineID = objRow[convEduMSTRGiftedClsCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvEduMSTRGiftedClsCase_BaseEN.DisciplineName = objRow[convEduMSTRGiftedClsCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvEduMSTRGiftedClsCase_BaseEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionTtlScore = objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convEduMSTRGiftedClsCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCase_BaseEN.VersionNo = objRow[convEduMSTRGiftedClsCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Base.VersionNo].ToString().Trim()); //版本号
objvEduMSTRGiftedClsCase_BaseEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvEduMSTRGiftedClsCase_BaseEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvEduMSTRGiftedClsCase_BaseEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvEduMSTRGiftedClsCase_BaseEN.IdSkillType = objRow[convEduMSTRGiftedClsCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvEduMSTRGiftedClsCase_BaseEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvEduMSTRGiftedClsCase_BaseEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvEduMSTRGiftedClsCase_BaseEN.CaseLevelName = objRow[convEduMSTRGiftedClsCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvEduMSTRGiftedClsCase_BaseEN.DocFile = objRow[convEduMSTRGiftedClsCase_Base.DocFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvEduMSTRGiftedClsCase_BaseEN.IsNeedGeneWord = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvEduMSTRGiftedClsCase_BaseEN.WordCreateDate = objRow[convEduMSTRGiftedClsCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvEduMSTRGiftedClsCase_BaseEN.IsVisible = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Base.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objvEduMSTRGiftedClsCase_BaseEN.OwnerId = objRow[convEduMSTRGiftedClsCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCase_BaseEN.StuName = objRow[convEduMSTRGiftedClsCase_Base.StuName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCase_BaseEN.StuId = objRow[convEduMSTRGiftedClsCase_Base.StuId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuId].ToString().Trim(); //学号
objvEduMSTRGiftedClsCase_BaseEN.SexDesc = objRow[convEduMSTRGiftedClsCase_Base.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.SexDesc].ToString().Trim(); //性别名称
objvEduMSTRGiftedClsCase_BaseEN.StuTypeID = objRow[convEduMSTRGiftedClsCase_Base.StuTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuTypeID].ToString().Trim(); //学生类别ID
objvEduMSTRGiftedClsCase_BaseEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase_Base.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuTypeDesc].ToString().Trim(); //学生类别名称
objvEduMSTRGiftedClsCase_BaseEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase_Base.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCase_BaseEN.CollegeId = objRow[convEduMSTRGiftedClsCase_Base.CollegeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeId].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCase_BaseEN.CollegeName = objRow[convEduMSTRGiftedClsCase_Base.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCase_BaseEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCase_BaseEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase_Base.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvEduMSTRGiftedClsCase_BaseEN.MajorName = objRow[convEduMSTRGiftedClsCase_Base.MajorName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCase_BaseEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase_Base.IdGradeBase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.IdGradeBase].ToString().Trim(); //年级流水号
objvEduMSTRGiftedClsCase_BaseEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase_Base.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.GradeBaseName].ToString().Trim(); //年级名称
objvEduMSTRGiftedClsCase_BaseEN.StuCardNo = objRow[convEduMSTRGiftedClsCase_Base.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.StuCardNo].ToString().Trim(); //学生证号
objvEduMSTRGiftedClsCase_BaseEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase_Base.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.EnrollmentDate].ToString().Trim(); //入校日期
objvEduMSTRGiftedClsCase_BaseEN.IsDualVideo = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvEduMSTRGiftedClsCase_BaseEN.UserTypeId = objRow[convEduMSTRGiftedClsCase_Base.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvEduMSTRGiftedClsCase_BaseEN.ftpFileType = objRow[convEduMSTRGiftedClsCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCase_BaseEN.VideoUrl = objRow[convEduMSTRGiftedClsCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvEduMSTRGiftedClsCase_BaseEN.VideoPath = objRow[convEduMSTRGiftedClsCase_Base.VideoPath] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.VideoPath].ToString().Trim(); //视频目录
objvEduMSTRGiftedClsCase_BaseEN.ResErrMsg = objRow[convEduMSTRGiftedClsCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvEduMSTRGiftedClsCase_BaseEN.ResourceNum = objRow[convEduMSTRGiftedClsCase_Base.ResourceNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Base.ResourceNum].ToString().Trim()); //资源数
objvEduMSTRGiftedClsCase_BaseEN.Memo = objRow[convEduMSTRGiftedClsCase_Base.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.Memo].ToString().Trim(); //备注
objvEduMSTRGiftedClsCase_BaseEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvEduMSTRGiftedClsCase_BaseEN.OwnerName = objRow[convEduMSTRGiftedClsCase_Base.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCase_BaseEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvEduMSTRGiftedClsCase_BaseDA: GetObjByDataRow)", objException.Message));
}
objvEduMSTRGiftedClsCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvEduMSTRGiftedClsCase_BaseEN;
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
objSQL = clsvEduMSTRGiftedClsCase_BaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvEduMSTRGiftedClsCase_BaseEN._CurrTabName, convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase, 8, "");
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
objSQL = clsvEduMSTRGiftedClsCase_BaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvEduMSTRGiftedClsCase_BaseEN._CurrTabName, convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase, 8, strPrefix);
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
 objSQL = clsvEduMSTRGiftedClsCase_BaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdEduMSTRGiftedClsCase from vEduMSTRGiftedClsCase_Base where " + strCondition;
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
 objSQL = clsvEduMSTRGiftedClsCase_BaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdEduMSTRGiftedClsCase from vEduMSTRGiftedClsCase_Base where " + strCondition;
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
 objSQL = clsvEduMSTRGiftedClsCase_BaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vEduMSTRGiftedClsCase_Base", "IdEduMSTRGiftedClsCase = " + "'"+ strIdEduMSTRGiftedClsCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCase_BaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCase_BaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vEduMSTRGiftedClsCase_Base", strCondition))
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
objSQL = clsvEduMSTRGiftedClsCase_BaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vEduMSTRGiftedClsCase_Base");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseENS">源对象</param>
 /// <param name = "objvEduMSTRGiftedClsCase_BaseENT">目标对象</param>
public void CopyTo(clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseENS, clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseENT)
{
objvEduMSTRGiftedClsCase_BaseENT.IdEduMSTRGiftedClsCase = objvEduMSTRGiftedClsCase_BaseENS.IdEduMSTRGiftedClsCase; //教育硕士优课案例流水号
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseID = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseID; //教育硕士优课案例ID
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseName = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseName; //教育硕士优课案例名称
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseTheme = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseTheme; //教育硕士优课案例主题词
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseDate = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseDate; //教育硕士优课案例日期
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseTime = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseTime; //教育硕士优课案例时间
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseDateIn = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseDateIn; //案例入库日期
objvEduMSTRGiftedClsCase_BaseENT.IdStudyLevel = objvEduMSTRGiftedClsCase_BaseENS.IdStudyLevel; //id_StudyLevel
objvEduMSTRGiftedClsCase_BaseENT.StudyLevelName = objvEduMSTRGiftedClsCase_BaseENS.StudyLevelName; //学段名称
objvEduMSTRGiftedClsCase_BaseENT.IdTeachingPlan = objvEduMSTRGiftedClsCase_BaseENS.IdTeachingPlan; //教案流水号
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseTimeIn = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseTimeIn; //案例入库时间
objvEduMSTRGiftedClsCase_BaseENT.IdEduMSTRGiftedClsCaseType = objvEduMSTRGiftedClsCase_BaseENS.IdEduMSTRGiftedClsCaseType; //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseTypeName = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseTypeName; //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCase_BaseENT.IdCaseType = objvEduMSTRGiftedClsCase_BaseENS.IdCaseType; //案例类型流水号
objvEduMSTRGiftedClsCase_BaseENT.IdDiscipline = objvEduMSTRGiftedClsCase_BaseENS.IdDiscipline; //学科流水号
objvEduMSTRGiftedClsCase_BaseENT.DisciplineID = objvEduMSTRGiftedClsCase_BaseENS.DisciplineID; //学科ID
objvEduMSTRGiftedClsCase_BaseENT.DisciplineName = objvEduMSTRGiftedClsCase_BaseENS.DisciplineName; //学科名称
objvEduMSTRGiftedClsCase_BaseENT.IdSenateGaugeVersion = objvEduMSTRGiftedClsCase_BaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvEduMSTRGiftedClsCase_BaseENT.senateGaugeVersionID = objvEduMSTRGiftedClsCase_BaseENS.senateGaugeVersionID; //评价量表版本ID
objvEduMSTRGiftedClsCase_BaseENT.senateGaugeVersionName = objvEduMSTRGiftedClsCase_BaseENS.senateGaugeVersionName; //评价量表版本名称
objvEduMSTRGiftedClsCase_BaseENT.senateGaugeVersionTtlScore = objvEduMSTRGiftedClsCase_BaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvEduMSTRGiftedClsCase_BaseENT.VersionNo = objvEduMSTRGiftedClsCase_BaseENS.VersionNo; //版本号
objvEduMSTRGiftedClsCase_BaseENT.IdTeachSkill = objvEduMSTRGiftedClsCase_BaseENS.IdTeachSkill; //教学技能流水号
objvEduMSTRGiftedClsCase_BaseENT.TeachSkillID = objvEduMSTRGiftedClsCase_BaseENS.TeachSkillID; //教学技能ID
objvEduMSTRGiftedClsCase_BaseENT.SkillTypeName = objvEduMSTRGiftedClsCase_BaseENS.SkillTypeName; //技能类型名称
objvEduMSTRGiftedClsCase_BaseENT.TeachSkillName = objvEduMSTRGiftedClsCase_BaseENS.TeachSkillName; //教学技能名称
objvEduMSTRGiftedClsCase_BaseENT.TeachSkillTheory = objvEduMSTRGiftedClsCase_BaseENS.TeachSkillTheory; //教学技能理论阐述
objvEduMSTRGiftedClsCase_BaseENT.TeachSkillOperMethod = objvEduMSTRGiftedClsCase_BaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvEduMSTRGiftedClsCase_BaseENT.IdSkillType = objvEduMSTRGiftedClsCase_BaseENS.IdSkillType; //技能类型流水号
objvEduMSTRGiftedClsCase_BaseENT.SkillTypeID = objvEduMSTRGiftedClsCase_BaseENS.SkillTypeID; //技能类型ID
objvEduMSTRGiftedClsCase_BaseENT.CaseLevelId = objvEduMSTRGiftedClsCase_BaseENS.CaseLevelId; //课例等级Id
objvEduMSTRGiftedClsCase_BaseENT.CaseLevelName = objvEduMSTRGiftedClsCase_BaseENS.CaseLevelName; //案例等级名称
objvEduMSTRGiftedClsCase_BaseENT.DocFile = objvEduMSTRGiftedClsCase_BaseENS.DocFile; //生成的Word文件名
objvEduMSTRGiftedClsCase_BaseENT.IsNeedGeneWord = objvEduMSTRGiftedClsCase_BaseENS.IsNeedGeneWord; //是否需要生成Word
objvEduMSTRGiftedClsCase_BaseENT.WordCreateDate = objvEduMSTRGiftedClsCase_BaseENS.WordCreateDate; //Word生成日期
objvEduMSTRGiftedClsCase_BaseENT.IsVisible = objvEduMSTRGiftedClsCase_BaseENS.IsVisible; //是否显示
objvEduMSTRGiftedClsCase_BaseENT.EduMSTRGiftedClsCaseText = objvEduMSTRGiftedClsCase_BaseENS.EduMSTRGiftedClsCaseText; //教育硕士优课案例文本
objvEduMSTRGiftedClsCase_BaseENT.OwnerId = objvEduMSTRGiftedClsCase_BaseENS.OwnerId; //拥有者Id
objvEduMSTRGiftedClsCase_BaseENT.StuName = objvEduMSTRGiftedClsCase_BaseENS.StuName; //姓名
objvEduMSTRGiftedClsCase_BaseENT.StuId = objvEduMSTRGiftedClsCase_BaseENS.StuId; //学号
objvEduMSTRGiftedClsCase_BaseENT.SexDesc = objvEduMSTRGiftedClsCase_BaseENS.SexDesc; //性别名称
objvEduMSTRGiftedClsCase_BaseENT.StuTypeID = objvEduMSTRGiftedClsCase_BaseENS.StuTypeID; //学生类别ID
objvEduMSTRGiftedClsCase_BaseENT.StuTypeDesc = objvEduMSTRGiftedClsCase_BaseENS.StuTypeDesc; //学生类别名称
objvEduMSTRGiftedClsCase_BaseENT.IdXzCollege = objvEduMSTRGiftedClsCase_BaseENS.IdXzCollege; //学院流水号
objvEduMSTRGiftedClsCase_BaseENT.CollegeId = objvEduMSTRGiftedClsCase_BaseENS.CollegeId; //学院ID
objvEduMSTRGiftedClsCase_BaseENT.CollegeName = objvEduMSTRGiftedClsCase_BaseENS.CollegeName; //学院名称
objvEduMSTRGiftedClsCase_BaseENT.CollegeNameA = objvEduMSTRGiftedClsCase_BaseENS.CollegeNameA; //学院名称简写
objvEduMSTRGiftedClsCase_BaseENT.IdXzMajor = objvEduMSTRGiftedClsCase_BaseENS.IdXzMajor; //专业流水号
objvEduMSTRGiftedClsCase_BaseENT.MajorName = objvEduMSTRGiftedClsCase_BaseENS.MajorName; //专业名称
objvEduMSTRGiftedClsCase_BaseENT.IdGradeBase = objvEduMSTRGiftedClsCase_BaseENS.IdGradeBase; //年级流水号
objvEduMSTRGiftedClsCase_BaseENT.GradeBaseName = objvEduMSTRGiftedClsCase_BaseENS.GradeBaseName; //年级名称
objvEduMSTRGiftedClsCase_BaseENT.StuCardNo = objvEduMSTRGiftedClsCase_BaseENS.StuCardNo; //学生证号
objvEduMSTRGiftedClsCase_BaseENT.EnrollmentDate = objvEduMSTRGiftedClsCase_BaseENS.EnrollmentDate; //入校日期
objvEduMSTRGiftedClsCase_BaseENT.IsDualVideo = objvEduMSTRGiftedClsCase_BaseENS.IsDualVideo; //是否双视频
objvEduMSTRGiftedClsCase_BaseENT.UserTypeId = objvEduMSTRGiftedClsCase_BaseENS.UserTypeId; //用户类型Id
objvEduMSTRGiftedClsCase_BaseENT.RecommendedDegreeId = objvEduMSTRGiftedClsCase_BaseENS.RecommendedDegreeId; //推荐度Id
objvEduMSTRGiftedClsCase_BaseENT.RecommendedDegreeName = objvEduMSTRGiftedClsCase_BaseENS.RecommendedDegreeName; //推荐度名称
objvEduMSTRGiftedClsCase_BaseENT.ftpFileType = objvEduMSTRGiftedClsCase_BaseENS.ftpFileType; //ftp文件类型
objvEduMSTRGiftedClsCase_BaseENT.VideoUrl = objvEduMSTRGiftedClsCase_BaseENS.VideoUrl; //视频Url
objvEduMSTRGiftedClsCase_BaseENT.VideoPath = objvEduMSTRGiftedClsCase_BaseENS.VideoPath; //视频目录
objvEduMSTRGiftedClsCase_BaseENT.ResErrMsg = objvEduMSTRGiftedClsCase_BaseENS.ResErrMsg; //资源错误信息
objvEduMSTRGiftedClsCase_BaseENT.ResourceNum = objvEduMSTRGiftedClsCase_BaseENS.ResourceNum; //资源数
objvEduMSTRGiftedClsCase_BaseENT.Memo = objvEduMSTRGiftedClsCase_BaseENS.Memo; //备注
objvEduMSTRGiftedClsCase_BaseENT.BrowseCount4Case = objvEduMSTRGiftedClsCase_BaseENS.BrowseCount4Case; //课例浏览次数
objvEduMSTRGiftedClsCase_BaseENT.OwnerName = objvEduMSTRGiftedClsCase_BaseENS.OwnerName; //拥有者姓名
objvEduMSTRGiftedClsCase_BaseENT.OwnerNameWithId = objvEduMSTRGiftedClsCase_BaseENS.OwnerNameWithId; //拥有者名称附Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvEduMSTRGiftedClsCase_BaseEN objvEduMSTRGiftedClsCase_BaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase, 8, convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseID, 8, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseName, 100, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTheme, 200, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDate, 8, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTime, 6, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDateIn, 8, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.IdStudyLevel, 4, convEduMSTRGiftedClsCase_Base.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.StudyLevelName, 50, convEduMSTRGiftedClsCase_Base.StudyLevelName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.IdTeachingPlan, 8, convEduMSTRGiftedClsCase_Base.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTimeIn, 6, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCaseType, 4, convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTypeName, 50, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.IdCaseType, 4, convEduMSTRGiftedClsCase_Base.IdCaseType);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.IdDiscipline, 4, convEduMSTRGiftedClsCase_Base.IdDiscipline);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.DisciplineID, 4, convEduMSTRGiftedClsCase_Base.DisciplineID);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.DisciplineName, 50, convEduMSTRGiftedClsCase_Base.DisciplineName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.IdSenateGaugeVersion, 4, convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionID, 4, convEduMSTRGiftedClsCase_Base.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionName, 200, convEduMSTRGiftedClsCase_Base.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.IdTeachSkill, 8, convEduMSTRGiftedClsCase_Base.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.TeachSkillID, 8, convEduMSTRGiftedClsCase_Base.TeachSkillID);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.SkillTypeName, 50, convEduMSTRGiftedClsCase_Base.SkillTypeName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.TeachSkillName, 50, convEduMSTRGiftedClsCase_Base.TeachSkillName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.TeachSkillTheory, 8000, convEduMSTRGiftedClsCase_Base.TeachSkillTheory);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.TeachSkillOperMethod, 2000, convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.IdSkillType, 4, convEduMSTRGiftedClsCase_Base.IdSkillType);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.SkillTypeID, 4, convEduMSTRGiftedClsCase_Base.SkillTypeID);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.CaseLevelId, 2, convEduMSTRGiftedClsCase_Base.CaseLevelId);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.CaseLevelName, 30, convEduMSTRGiftedClsCase_Base.CaseLevelName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.DocFile, 200, convEduMSTRGiftedClsCase_Base.DocFile);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.WordCreateDate, 14, convEduMSTRGiftedClsCase_Base.WordCreateDate);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseText, 8000, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.OwnerId, 20, convEduMSTRGiftedClsCase_Base.OwnerId);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.StuName, 50, convEduMSTRGiftedClsCase_Base.StuName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.StuId, 20, convEduMSTRGiftedClsCase_Base.StuId);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.SexDesc, 10, convEduMSTRGiftedClsCase_Base.SexDesc);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.StuTypeID, 4, convEduMSTRGiftedClsCase_Base.StuTypeID);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.StuTypeDesc, 50, convEduMSTRGiftedClsCase_Base.StuTypeDesc);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.IdXzCollege, 4, convEduMSTRGiftedClsCase_Base.IdXzCollege);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.CollegeId, 4, convEduMSTRGiftedClsCase_Base.CollegeId);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.CollegeName, 100, convEduMSTRGiftedClsCase_Base.CollegeName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.CollegeNameA, 12, convEduMSTRGiftedClsCase_Base.CollegeNameA);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.IdXzMajor, 8, convEduMSTRGiftedClsCase_Base.IdXzMajor);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.MajorName, 100, convEduMSTRGiftedClsCase_Base.MajorName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.IdGradeBase, 4, convEduMSTRGiftedClsCase_Base.IdGradeBase);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.GradeBaseName, 50, convEduMSTRGiftedClsCase_Base.GradeBaseName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.StuCardNo, 20, convEduMSTRGiftedClsCase_Base.StuCardNo);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.EnrollmentDate, 8, convEduMSTRGiftedClsCase_Base.EnrollmentDate);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.UserTypeId, 2, convEduMSTRGiftedClsCase_Base.UserTypeId);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeId, 2, convEduMSTRGiftedClsCase_Base.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeName, 30, convEduMSTRGiftedClsCase_Base.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.ftpFileType, 30, convEduMSTRGiftedClsCase_Base.ftpFileType);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.VideoUrl, 1000, convEduMSTRGiftedClsCase_Base.VideoUrl);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.VideoPath, 1000, convEduMSTRGiftedClsCase_Base.VideoPath);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.ResErrMsg, 30, convEduMSTRGiftedClsCase_Base.ResErrMsg);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.Memo, 1000, convEduMSTRGiftedClsCase_Base.Memo);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.OwnerName, 30, convEduMSTRGiftedClsCase_Base.OwnerName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_BaseEN.OwnerNameWithId, 51, convEduMSTRGiftedClsCase_Base.OwnerNameWithId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCase, convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCase);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseID, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseID);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseName, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTheme, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDate, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTime, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseDateIn, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.IdStudyLevel, convEduMSTRGiftedClsCase_Base.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.StudyLevelName, convEduMSTRGiftedClsCase_Base.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.IdTeachingPlan, convEduMSTRGiftedClsCase_Base.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTimeIn, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.IdEduMSTRGiftedClsCaseType, convEduMSTRGiftedClsCase_Base.IdEduMSTRGiftedClsCaseType);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseTypeName, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.IdCaseType, convEduMSTRGiftedClsCase_Base.IdCaseType);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.IdDiscipline, convEduMSTRGiftedClsCase_Base.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.DisciplineID, convEduMSTRGiftedClsCase_Base.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.DisciplineName, convEduMSTRGiftedClsCase_Base.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.IdSenateGaugeVersion, convEduMSTRGiftedClsCase_Base.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionID, convEduMSTRGiftedClsCase_Base.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.senateGaugeVersionName, convEduMSTRGiftedClsCase_Base.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.IdTeachSkill, convEduMSTRGiftedClsCase_Base.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.TeachSkillID, convEduMSTRGiftedClsCase_Base.TeachSkillID);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.SkillTypeName, convEduMSTRGiftedClsCase_Base.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.TeachSkillName, convEduMSTRGiftedClsCase_Base.TeachSkillName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.TeachSkillTheory, convEduMSTRGiftedClsCase_Base.TeachSkillTheory);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.TeachSkillOperMethod, convEduMSTRGiftedClsCase_Base.TeachSkillOperMethod);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.IdSkillType, convEduMSTRGiftedClsCase_Base.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.SkillTypeID, convEduMSTRGiftedClsCase_Base.SkillTypeID);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.CaseLevelId, convEduMSTRGiftedClsCase_Base.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.CaseLevelName, convEduMSTRGiftedClsCase_Base.CaseLevelName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.DocFile, convEduMSTRGiftedClsCase_Base.DocFile);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.WordCreateDate, convEduMSTRGiftedClsCase_Base.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.EduMSTRGiftedClsCaseText, convEduMSTRGiftedClsCase_Base.EduMSTRGiftedClsCaseText);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.OwnerId, convEduMSTRGiftedClsCase_Base.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.StuName, convEduMSTRGiftedClsCase_Base.StuName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.StuId, convEduMSTRGiftedClsCase_Base.StuId);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.SexDesc, convEduMSTRGiftedClsCase_Base.SexDesc);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.StuTypeID, convEduMSTRGiftedClsCase_Base.StuTypeID);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.StuTypeDesc, convEduMSTRGiftedClsCase_Base.StuTypeDesc);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.IdXzCollege, convEduMSTRGiftedClsCase_Base.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.CollegeId, convEduMSTRGiftedClsCase_Base.CollegeId);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.CollegeName, convEduMSTRGiftedClsCase_Base.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.CollegeNameA, convEduMSTRGiftedClsCase_Base.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.IdXzMajor, convEduMSTRGiftedClsCase_Base.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.MajorName, convEduMSTRGiftedClsCase_Base.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.IdGradeBase, convEduMSTRGiftedClsCase_Base.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.GradeBaseName, convEduMSTRGiftedClsCase_Base.GradeBaseName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.StuCardNo, convEduMSTRGiftedClsCase_Base.StuCardNo);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.EnrollmentDate, convEduMSTRGiftedClsCase_Base.EnrollmentDate);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.UserTypeId, convEduMSTRGiftedClsCase_Base.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeId, convEduMSTRGiftedClsCase_Base.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.RecommendedDegreeName, convEduMSTRGiftedClsCase_Base.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.ftpFileType, convEduMSTRGiftedClsCase_Base.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.VideoUrl, convEduMSTRGiftedClsCase_Base.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.VideoPath, convEduMSTRGiftedClsCase_Base.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.ResErrMsg, convEduMSTRGiftedClsCase_Base.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.Memo, convEduMSTRGiftedClsCase_Base.Memo);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.OwnerName, convEduMSTRGiftedClsCase_Base.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_BaseEN.OwnerNameWithId, convEduMSTRGiftedClsCase_Base.OwnerNameWithId);
//检查外键字段长度
 objvEduMSTRGiftedClsCase_BaseEN._IsCheckProperty = true;
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
string strSQL = "select IdEduMSTRGiftedClsCase, EduMSTRGiftedClsCaseName from vEduMSTRGiftedClsCase_Base ";
 clsSpecSQLforSql mySql = clsvEduMSTRGiftedClsCase_BaseDA.GetSpecSQLObj();
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
 objSQL = clsvEduMSTRGiftedClsCase_BaseDA.GetSpecSQLObj();
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
 objSQL = clsvEduMSTRGiftedClsCase_BaseDA.GetSpecSQLObj();
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
 objSQL = clsvEduMSTRGiftedClsCase_BaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvEduMSTRGiftedClsCase_BaseEN._CurrTabName);
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
 objSQL = clsvEduMSTRGiftedClsCase_BaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvEduMSTRGiftedClsCase_BaseEN._CurrTabName, strCondition);
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
 objSQL = clsvEduMSTRGiftedClsCase_BaseDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}