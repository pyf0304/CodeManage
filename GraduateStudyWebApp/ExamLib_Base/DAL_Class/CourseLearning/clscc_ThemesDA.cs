
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_ThemesDA
 表名:cc_Themes(01120069)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:10:00
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
 /// 课程主题(cc_Themes)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clscc_ThemesDA : clsCommBase4DA
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
 return clscc_ThemesEN._CurrTabName;
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
if (string.IsNullOrEmpty(clscc_ThemesEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_ThemesEN._ConnectString);
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
 if (string.IsNullOrEmpty(clscc_ThemesEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clscc_ThemesEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strThemeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strThemeId)
{
strThemeId = strThemeId.Replace("'", "''");
if (strThemeId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:cc_Themes中,检查关键字,长度不正确!(clscc_ThemesDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strThemeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:cc_Themes中,关键字不能为空 或 null!(clscc_ThemesDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strThemeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clscc_ThemesDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clscc_ThemesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
strSQL = "Select * from cc_Themes where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_cc_Themes(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clscc_ThemesDA: GetDataTable_cc_Themes)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
strSQL = "Select * from cc_Themes where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clscc_ThemesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clscc_ThemesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
strSQL = "Select * from cc_Themes where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clscc_ThemesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clscc_ThemesDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_Themes where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_Themes where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clscc_ThemesDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from cc_Themes where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clscc_ThemesDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_Themes.* from cc_Themes Left Join {1} on {2} where {3} and cc_Themes.ThemeId not in (Select top {5} cc_Themes.ThemeId from cc_Themes Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_Themes where {1} and ThemeId not in (Select top {2} ThemeId from cc_Themes where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_Themes where {1} and ThemeId not in (Select top {3} ThemeId from cc_Themes where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clscc_ThemesDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_Themes.* from cc_Themes Left Join {1} on {2} where {3} and cc_Themes.ThemeId not in (Select top {5} cc_Themes.ThemeId from cc_Themes Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_Themes where {1} and ThemeId not in (Select top {2} ThemeId from cc_Themes where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_Themes where {1} and ThemeId not in (Select top {3} ThemeId from cc_Themes where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clscc_ThemesEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clscc_ThemesDA:GetObjLst)", objException.Message));
}
List<clscc_ThemesEN> arrObjLst = new List<clscc_ThemesEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
strSQL = "Select * from cc_Themes where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ThemesEN objcc_ThemesEN = new clscc_ThemesEN();
try
{
objcc_ThemesEN.ThemeId = objRow[concc_Themes.ThemeId].ToString().Trim(); //主题Id
objcc_ThemesEN.ThemeName = objRow[concc_Themes.ThemeName].ToString().Trim(); //主题名
objcc_ThemesEN.ThemeDesc = objRow[concc_Themes.ThemeDesc] == DBNull.Value ? null : objRow[concc_Themes.ThemeDesc].ToString().Trim(); //主题描述
objcc_ThemesEN.PageName = objRow[concc_Themes.PageName] == DBNull.Value ? null : objRow[concc_Themes.PageName].ToString().Trim(); //页面名称
objcc_ThemesEN.ExampleImgPath = objRow[concc_Themes.ExampleImgPath] == DBNull.Value ? null : objRow[concc_Themes.ExampleImgPath].ToString().Trim(); //示例图路径
objcc_ThemesEN.OrderNum = objRow[concc_Themes.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Themes.OrderNum].ToString().Trim()); //序号
objcc_ThemesEN.IsUse = TransNullToBool(objRow[concc_Themes.IsUse].ToString().Trim()); //是否使用
objcc_ThemesEN.UpdDate = objRow[concc_Themes.UpdDate].ToString().Trim(); //修改日期
objcc_ThemesEN.UpdUserId = objRow[concc_Themes.UpdUserId] == DBNull.Value ? null : objRow[concc_Themes.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ThemesEN.Memo = objRow[concc_Themes.Memo] == DBNull.Value ? null : objRow[concc_Themes.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_ThemesDA: GetObjLst)", objException.Message));
}
objcc_ThemesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_ThemesEN);
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
public List<clscc_ThemesEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clscc_ThemesDA:GetObjLstByTabName)", objException.Message));
}
List<clscc_ThemesEN> arrObjLst = new List<clscc_ThemesEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ThemesEN objcc_ThemesEN = new clscc_ThemesEN();
try
{
objcc_ThemesEN.ThemeId = objRow[concc_Themes.ThemeId].ToString().Trim(); //主题Id
objcc_ThemesEN.ThemeName = objRow[concc_Themes.ThemeName].ToString().Trim(); //主题名
objcc_ThemesEN.ThemeDesc = objRow[concc_Themes.ThemeDesc] == DBNull.Value ? null : objRow[concc_Themes.ThemeDesc].ToString().Trim(); //主题描述
objcc_ThemesEN.PageName = objRow[concc_Themes.PageName] == DBNull.Value ? null : objRow[concc_Themes.PageName].ToString().Trim(); //页面名称
objcc_ThemesEN.ExampleImgPath = objRow[concc_Themes.ExampleImgPath] == DBNull.Value ? null : objRow[concc_Themes.ExampleImgPath].ToString().Trim(); //示例图路径
objcc_ThemesEN.OrderNum = objRow[concc_Themes.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Themes.OrderNum].ToString().Trim()); //序号
objcc_ThemesEN.IsUse = TransNullToBool(objRow[concc_Themes.IsUse].ToString().Trim()); //是否使用
objcc_ThemesEN.UpdDate = objRow[concc_Themes.UpdDate].ToString().Trim(); //修改日期
objcc_ThemesEN.UpdUserId = objRow[concc_Themes.UpdUserId] == DBNull.Value ? null : objRow[concc_Themes.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ThemesEN.Memo = objRow[concc_Themes.Memo] == DBNull.Value ? null : objRow[concc_Themes.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_ThemesDA: GetObjLst)", objException.Message));
}
objcc_ThemesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_ThemesEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objcc_ThemesEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getcc_Themes(ref clscc_ThemesEN objcc_ThemesEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
strSQL = "Select * from cc_Themes where ThemeId = " + "'"+ objcc_ThemesEN.ThemeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objcc_ThemesEN.ThemeId = objDT.Rows[0][concc_Themes.ThemeId].ToString().Trim(); //主题Id(字段类型:char,字段长度:4,是否可空:False)
 objcc_ThemesEN.ThemeName = objDT.Rows[0][concc_Themes.ThemeName].ToString().Trim(); //主题名(字段类型:varchar,字段长度:200,是否可空:False)
 objcc_ThemesEN.ThemeDesc = objDT.Rows[0][concc_Themes.ThemeDesc].ToString().Trim(); //主题描述(字段类型:varchar,字段长度:500,是否可空:True)
 objcc_ThemesEN.PageName = objDT.Rows[0][concc_Themes.PageName].ToString().Trim(); //页面名称(字段类型:varchar,字段长度:100,是否可空:True)
 objcc_ThemesEN.ExampleImgPath = objDT.Rows[0][concc_Themes.ExampleImgPath].ToString().Trim(); //示例图路径(字段类型:varchar,字段长度:300,是否可空:True)
 objcc_ThemesEN.OrderNum = TransNullToInt(objDT.Rows[0][concc_Themes.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objcc_ThemesEN.IsUse = TransNullToBool(objDT.Rows[0][concc_Themes.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
 objcc_ThemesEN.UpdDate = objDT.Rows[0][concc_Themes.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_ThemesEN.UpdUserId = objDT.Rows[0][concc_Themes.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_ThemesEN.Memo = objDT.Rows[0][concc_Themes.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clscc_ThemesDA: Getcc_Themes)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strThemeId">表关键字</param>
 /// <returns>表对象</returns>
public clscc_ThemesEN GetObjByThemeId(string strThemeId)
{
CheckPrimaryKey(strThemeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
strSQL = "Select * from cc_Themes where ThemeId = " + "'"+ strThemeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clscc_ThemesEN objcc_ThemesEN = new clscc_ThemesEN();
try
{
 objcc_ThemesEN.ThemeId = objRow[concc_Themes.ThemeId].ToString().Trim(); //主题Id(字段类型:char,字段长度:4,是否可空:False)
 objcc_ThemesEN.ThemeName = objRow[concc_Themes.ThemeName].ToString().Trim(); //主题名(字段类型:varchar,字段长度:200,是否可空:False)
 objcc_ThemesEN.ThemeDesc = objRow[concc_Themes.ThemeDesc] == DBNull.Value ? null : objRow[concc_Themes.ThemeDesc].ToString().Trim(); //主题描述(字段类型:varchar,字段长度:500,是否可空:True)
 objcc_ThemesEN.PageName = objRow[concc_Themes.PageName] == DBNull.Value ? null : objRow[concc_Themes.PageName].ToString().Trim(); //页面名称(字段类型:varchar,字段长度:100,是否可空:True)
 objcc_ThemesEN.ExampleImgPath = objRow[concc_Themes.ExampleImgPath] == DBNull.Value ? null : objRow[concc_Themes.ExampleImgPath].ToString().Trim(); //示例图路径(字段类型:varchar,字段长度:300,是否可空:True)
 objcc_ThemesEN.OrderNum = objRow[concc_Themes.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Themes.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objcc_ThemesEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[concc_Themes.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
 objcc_ThemesEN.UpdDate = objRow[concc_Themes.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_ThemesEN.UpdUserId = objRow[concc_Themes.UpdUserId] == DBNull.Value ? null : objRow[concc_Themes.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_ThemesEN.Memo = objRow[concc_Themes.Memo] == DBNull.Value ? null : objRow[concc_Themes.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clscc_ThemesDA: GetObjByThemeId)", objException.Message));
}
return objcc_ThemesEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clscc_ThemesEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clscc_ThemesDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
strSQL = "Select * from cc_Themes where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clscc_ThemesEN objcc_ThemesEN = new clscc_ThemesEN()
{
ThemeId = objRow[concc_Themes.ThemeId].ToString().Trim(), //主题Id
ThemeName = objRow[concc_Themes.ThemeName].ToString().Trim(), //主题名
ThemeDesc = objRow[concc_Themes.ThemeDesc] == DBNull.Value ? null : objRow[concc_Themes.ThemeDesc].ToString().Trim(), //主题描述
PageName = objRow[concc_Themes.PageName] == DBNull.Value ? null : objRow[concc_Themes.PageName].ToString().Trim(), //页面名称
ExampleImgPath = objRow[concc_Themes.ExampleImgPath] == DBNull.Value ? null : objRow[concc_Themes.ExampleImgPath].ToString().Trim(), //示例图路径
OrderNum = objRow[concc_Themes.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Themes.OrderNum].ToString().Trim()), //序号
IsUse = TransNullToBool(objRow[concc_Themes.IsUse].ToString().Trim()), //是否使用
UpdDate = objRow[concc_Themes.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[concc_Themes.UpdUserId] == DBNull.Value ? null : objRow[concc_Themes.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[concc_Themes.Memo] == DBNull.Value ? null : objRow[concc_Themes.Memo].ToString().Trim() //备注
};
objcc_ThemesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_ThemesEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clscc_ThemesDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clscc_ThemesEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_ThemesEN objcc_ThemesEN = new clscc_ThemesEN();
try
{
objcc_ThemesEN.ThemeId = objRow[concc_Themes.ThemeId].ToString().Trim(); //主题Id
objcc_ThemesEN.ThemeName = objRow[concc_Themes.ThemeName].ToString().Trim(); //主题名
objcc_ThemesEN.ThemeDesc = objRow[concc_Themes.ThemeDesc] == DBNull.Value ? null : objRow[concc_Themes.ThemeDesc].ToString().Trim(); //主题描述
objcc_ThemesEN.PageName = objRow[concc_Themes.PageName] == DBNull.Value ? null : objRow[concc_Themes.PageName].ToString().Trim(); //页面名称
objcc_ThemesEN.ExampleImgPath = objRow[concc_Themes.ExampleImgPath] == DBNull.Value ? null : objRow[concc_Themes.ExampleImgPath].ToString().Trim(); //示例图路径
objcc_ThemesEN.OrderNum = objRow[concc_Themes.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Themes.OrderNum].ToString().Trim()); //序号
objcc_ThemesEN.IsUse = TransNullToBool(objRow[concc_Themes.IsUse].ToString().Trim()); //是否使用
objcc_ThemesEN.UpdDate = objRow[concc_Themes.UpdDate].ToString().Trim(); //修改日期
objcc_ThemesEN.UpdUserId = objRow[concc_Themes.UpdUserId] == DBNull.Value ? null : objRow[concc_Themes.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ThemesEN.Memo = objRow[concc_Themes.Memo] == DBNull.Value ? null : objRow[concc_Themes.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clscc_ThemesDA: GetObjByDataRowcc_Themes)", objException.Message));
}
objcc_ThemesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_ThemesEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clscc_ThemesEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_ThemesEN objcc_ThemesEN = new clscc_ThemesEN();
try
{
objcc_ThemesEN.ThemeId = objRow[concc_Themes.ThemeId].ToString().Trim(); //主题Id
objcc_ThemesEN.ThemeName = objRow[concc_Themes.ThemeName].ToString().Trim(); //主题名
objcc_ThemesEN.ThemeDesc = objRow[concc_Themes.ThemeDesc] == DBNull.Value ? null : objRow[concc_Themes.ThemeDesc].ToString().Trim(); //主题描述
objcc_ThemesEN.PageName = objRow[concc_Themes.PageName] == DBNull.Value ? null : objRow[concc_Themes.PageName].ToString().Trim(); //页面名称
objcc_ThemesEN.ExampleImgPath = objRow[concc_Themes.ExampleImgPath] == DBNull.Value ? null : objRow[concc_Themes.ExampleImgPath].ToString().Trim(); //示例图路径
objcc_ThemesEN.OrderNum = objRow[concc_Themes.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Themes.OrderNum].ToString().Trim()); //序号
objcc_ThemesEN.IsUse = TransNullToBool(objRow[concc_Themes.IsUse].ToString().Trim()); //是否使用
objcc_ThemesEN.UpdDate = objRow[concc_Themes.UpdDate].ToString().Trim(); //修改日期
objcc_ThemesEN.UpdUserId = objRow[concc_Themes.UpdUserId] == DBNull.Value ? null : objRow[concc_Themes.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ThemesEN.Memo = objRow[concc_Themes.Memo] == DBNull.Value ? null : objRow[concc_Themes.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clscc_ThemesDA: GetObjByDataRow)", objException.Message));
}
objcc_ThemesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_ThemesEN;
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
objSQL = clscc_ThemesDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_ThemesEN._CurrTabName, concc_Themes.ThemeId, 4, "");
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
objSQL = clscc_ThemesDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_ThemesEN._CurrTabName, concc_Themes.ThemeId, 4, strPrefix);
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
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ThemeId from cc_Themes where " + strCondition;
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
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ThemeId from cc_Themes where " + strCondition;
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
 /// <param name = "strThemeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strThemeId)
{
CheckPrimaryKey(strThemeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_Themes", "ThemeId = " + "'"+ strThemeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clscc_ThemesDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_Themes", strCondition))
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
objSQL = clscc_ThemesDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("cc_Themes");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clscc_ThemesEN objcc_ThemesEN)
 {
 objcc_ThemesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_ThemesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_ThemesEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
strSQL = "Select * from cc_Themes where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_Themes");
objRow = objDS.Tables["cc_Themes"].NewRow();
objRow[concc_Themes.ThemeId] = objcc_ThemesEN.ThemeId; //主题Id
objRow[concc_Themes.ThemeName] = objcc_ThemesEN.ThemeName; //主题名
 if (objcc_ThemesEN.ThemeDesc !=  "")
 {
objRow[concc_Themes.ThemeDesc] = objcc_ThemesEN.ThemeDesc; //主题描述
 }
 if (objcc_ThemesEN.PageName !=  "")
 {
objRow[concc_Themes.PageName] = objcc_ThemesEN.PageName; //页面名称
 }
 if (objcc_ThemesEN.ExampleImgPath !=  "")
 {
objRow[concc_Themes.ExampleImgPath] = objcc_ThemesEN.ExampleImgPath; //示例图路径
 }
objRow[concc_Themes.OrderNum] = objcc_ThemesEN.OrderNum; //序号
objRow[concc_Themes.IsUse] = objcc_ThemesEN.IsUse; //是否使用
objRow[concc_Themes.UpdDate] = objcc_ThemesEN.UpdDate; //修改日期
 if (objcc_ThemesEN.UpdUserId !=  "")
 {
objRow[concc_Themes.UpdUserId] = objcc_ThemesEN.UpdUserId; //修改用户Id
 }
 if (objcc_ThemesEN.Memo !=  "")
 {
objRow[concc_Themes.Memo] = objcc_ThemesEN.Memo; //备注
 }
objDS.Tables[clscc_ThemesEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clscc_ThemesEN._CurrTabName);
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
 /// <param name = "objcc_ThemesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_ThemesEN objcc_ThemesEN)
{
 objcc_ThemesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_ThemesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_ThemesEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_ThemesEN.ThemeId !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.ThemeId);
 var strThemeId = objcc_ThemesEN.ThemeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strThemeId + "'");
 }
 
 if (objcc_ThemesEN.ThemeName !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.ThemeName);
 var strThemeName = objcc_ThemesEN.ThemeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strThemeName + "'");
 }
 
 if (objcc_ThemesEN.ThemeDesc !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.ThemeDesc);
 var strThemeDesc = objcc_ThemesEN.ThemeDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strThemeDesc + "'");
 }
 
 if (objcc_ThemesEN.PageName !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.PageName);
 var strPageName = objcc_ThemesEN.PageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPageName + "'");
 }
 
 if (objcc_ThemesEN.ExampleImgPath !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.ExampleImgPath);
 var strExampleImgPath = objcc_ThemesEN.ExampleImgPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExampleImgPath + "'");
 }
 
 if (objcc_ThemesEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.OrderNum);
 arrValueListForInsert.Add(objcc_ThemesEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(concc_Themes.IsUse);
 arrValueListForInsert.Add("'" + (objcc_ThemesEN.IsUse  ==  false ? "0" : "1") + "'");
 
 if (objcc_ThemesEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.UpdDate);
 var strUpdDate = objcc_ThemesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_ThemesEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.UpdUserId);
 var strUpdUserId = objcc_ThemesEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_ThemesEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.Memo);
 var strMemo = objcc_ThemesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_Themes");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objcc_ThemesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_ThemesEN objcc_ThemesEN)
{
 objcc_ThemesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_ThemesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_ThemesEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_ThemesEN.ThemeId !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.ThemeId);
 var strThemeId = objcc_ThemesEN.ThemeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strThemeId + "'");
 }
 
 if (objcc_ThemesEN.ThemeName !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.ThemeName);
 var strThemeName = objcc_ThemesEN.ThemeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strThemeName + "'");
 }
 
 if (objcc_ThemesEN.ThemeDesc !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.ThemeDesc);
 var strThemeDesc = objcc_ThemesEN.ThemeDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strThemeDesc + "'");
 }
 
 if (objcc_ThemesEN.PageName !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.PageName);
 var strPageName = objcc_ThemesEN.PageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPageName + "'");
 }
 
 if (objcc_ThemesEN.ExampleImgPath !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.ExampleImgPath);
 var strExampleImgPath = objcc_ThemesEN.ExampleImgPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExampleImgPath + "'");
 }
 
 if (objcc_ThemesEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.OrderNum);
 arrValueListForInsert.Add(objcc_ThemesEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(concc_Themes.IsUse);
 arrValueListForInsert.Add("'" + (objcc_ThemesEN.IsUse  ==  false ? "0" : "1") + "'");
 
 if (objcc_ThemesEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.UpdDate);
 var strUpdDate = objcc_ThemesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_ThemesEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.UpdUserId);
 var strUpdUserId = objcc_ThemesEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_ThemesEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.Memo);
 var strMemo = objcc_ThemesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_Themes");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objcc_ThemesEN.ThemeId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objcc_ThemesEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_ThemesEN objcc_ThemesEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcc_ThemesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_ThemesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_ThemesEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_ThemesEN.ThemeId !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.ThemeId);
 var strThemeId = objcc_ThemesEN.ThemeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strThemeId + "'");
 }
 
 if (objcc_ThemesEN.ThemeName !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.ThemeName);
 var strThemeName = objcc_ThemesEN.ThemeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strThemeName + "'");
 }
 
 if (objcc_ThemesEN.ThemeDesc !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.ThemeDesc);
 var strThemeDesc = objcc_ThemesEN.ThemeDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strThemeDesc + "'");
 }
 
 if (objcc_ThemesEN.PageName !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.PageName);
 var strPageName = objcc_ThemesEN.PageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPageName + "'");
 }
 
 if (objcc_ThemesEN.ExampleImgPath !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.ExampleImgPath);
 var strExampleImgPath = objcc_ThemesEN.ExampleImgPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExampleImgPath + "'");
 }
 
 if (objcc_ThemesEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.OrderNum);
 arrValueListForInsert.Add(objcc_ThemesEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(concc_Themes.IsUse);
 arrValueListForInsert.Add("'" + (objcc_ThemesEN.IsUse  ==  false ? "0" : "1") + "'");
 
 if (objcc_ThemesEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.UpdDate);
 var strUpdDate = objcc_ThemesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_ThemesEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.UpdUserId);
 var strUpdUserId = objcc_ThemesEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_ThemesEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.Memo);
 var strMemo = objcc_ThemesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_Themes");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objcc_ThemesEN.ThemeId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objcc_ThemesEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_ThemesEN objcc_ThemesEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcc_ThemesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_ThemesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_ThemesEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_ThemesEN.ThemeId !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.ThemeId);
 var strThemeId = objcc_ThemesEN.ThemeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strThemeId + "'");
 }
 
 if (objcc_ThemesEN.ThemeName !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.ThemeName);
 var strThemeName = objcc_ThemesEN.ThemeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strThemeName + "'");
 }
 
 if (objcc_ThemesEN.ThemeDesc !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.ThemeDesc);
 var strThemeDesc = objcc_ThemesEN.ThemeDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strThemeDesc + "'");
 }
 
 if (objcc_ThemesEN.PageName !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.PageName);
 var strPageName = objcc_ThemesEN.PageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPageName + "'");
 }
 
 if (objcc_ThemesEN.ExampleImgPath !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.ExampleImgPath);
 var strExampleImgPath = objcc_ThemesEN.ExampleImgPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExampleImgPath + "'");
 }
 
 if (objcc_ThemesEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.OrderNum);
 arrValueListForInsert.Add(objcc_ThemesEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(concc_Themes.IsUse);
 arrValueListForInsert.Add("'" + (objcc_ThemesEN.IsUse  ==  false ? "0" : "1") + "'");
 
 if (objcc_ThemesEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.UpdDate);
 var strUpdDate = objcc_ThemesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_ThemesEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.UpdUserId);
 var strUpdUserId = objcc_ThemesEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_ThemesEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_Themes.Memo);
 var strMemo = objcc_ThemesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_Themes");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewcc_Themess(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
strSQL = "Select * from cc_Themes where ThemeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_Themes");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strThemeId = oRow[concc_Themes.ThemeId].ToString().Trim();
if (IsExist(strThemeId))
{
 string strResult = "关键字变量值为:" + string.Format("ThemeId = {0}", strThemeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clscc_ThemesEN._CurrTabName ].NewRow();
objRow[concc_Themes.ThemeId] = oRow[concc_Themes.ThemeId].ToString().Trim(); //主题Id
objRow[concc_Themes.ThemeName] = oRow[concc_Themes.ThemeName].ToString().Trim(); //主题名
objRow[concc_Themes.ThemeDesc] = oRow[concc_Themes.ThemeDesc].ToString().Trim(); //主题描述
objRow[concc_Themes.PageName] = oRow[concc_Themes.PageName].ToString().Trim(); //页面名称
objRow[concc_Themes.ExampleImgPath] = oRow[concc_Themes.ExampleImgPath].ToString().Trim(); //示例图路径
objRow[concc_Themes.OrderNum] = oRow[concc_Themes.OrderNum].ToString().Trim(); //序号
objRow[concc_Themes.IsUse] = oRow[concc_Themes.IsUse].ToString().Trim(); //是否使用
objRow[concc_Themes.UpdDate] = oRow[concc_Themes.UpdDate].ToString().Trim(); //修改日期
objRow[concc_Themes.UpdUserId] = oRow[concc_Themes.UpdUserId].ToString().Trim(); //修改用户Id
objRow[concc_Themes.Memo] = oRow[concc_Themes.Memo].ToString().Trim(); //备注
 objDS.Tables[clscc_ThemesEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clscc_ThemesEN._CurrTabName);
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
 /// <param name = "objcc_ThemesEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clscc_ThemesEN objcc_ThemesEN)
{
 objcc_ThemesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_ThemesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_ThemesEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
strSQL = "Select * from cc_Themes where ThemeId = " + "'"+ objcc_ThemesEN.ThemeId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clscc_ThemesEN._CurrTabName);
if (objDS.Tables[clscc_ThemesEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ThemeId = " + "'"+ objcc_ThemesEN.ThemeId+"'");
return false;
}
objRow = objDS.Tables[clscc_ThemesEN._CurrTabName].Rows[0];
 if (objcc_ThemesEN.IsUpdated(concc_Themes.ThemeId))
 {
objRow[concc_Themes.ThemeId] = objcc_ThemesEN.ThemeId; //主题Id
 }
 if (objcc_ThemesEN.IsUpdated(concc_Themes.ThemeName))
 {
objRow[concc_Themes.ThemeName] = objcc_ThemesEN.ThemeName; //主题名
 }
 if (objcc_ThemesEN.IsUpdated(concc_Themes.ThemeDesc))
 {
objRow[concc_Themes.ThemeDesc] = objcc_ThemesEN.ThemeDesc; //主题描述
 }
 if (objcc_ThemesEN.IsUpdated(concc_Themes.PageName))
 {
objRow[concc_Themes.PageName] = objcc_ThemesEN.PageName; //页面名称
 }
 if (objcc_ThemesEN.IsUpdated(concc_Themes.ExampleImgPath))
 {
objRow[concc_Themes.ExampleImgPath] = objcc_ThemesEN.ExampleImgPath; //示例图路径
 }
 if (objcc_ThemesEN.IsUpdated(concc_Themes.OrderNum))
 {
objRow[concc_Themes.OrderNum] = objcc_ThemesEN.OrderNum; //序号
 }
 if (objcc_ThemesEN.IsUpdated(concc_Themes.IsUse))
 {
objRow[concc_Themes.IsUse] = objcc_ThemesEN.IsUse; //是否使用
 }
 if (objcc_ThemesEN.IsUpdated(concc_Themes.UpdDate))
 {
objRow[concc_Themes.UpdDate] = objcc_ThemesEN.UpdDate; //修改日期
 }
 if (objcc_ThemesEN.IsUpdated(concc_Themes.UpdUserId))
 {
objRow[concc_Themes.UpdUserId] = objcc_ThemesEN.UpdUserId; //修改用户Id
 }
 if (objcc_ThemesEN.IsUpdated(concc_Themes.Memo))
 {
objRow[concc_Themes.Memo] = objcc_ThemesEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clscc_ThemesEN._CurrTabName);
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
 /// <param name = "objcc_ThemesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_ThemesEN objcc_ThemesEN)
{
 objcc_ThemesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_ThemesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_ThemesEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update cc_Themes Set ");
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.ThemeName))
 {
 if (objcc_ThemesEN.ThemeName !=  null)
 {
 var strThemeName = objcc_ThemesEN.ThemeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strThemeName, concc_Themes.ThemeName); //主题名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Themes.ThemeName); //主题名
 }
 }
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.ThemeDesc))
 {
 if (objcc_ThemesEN.ThemeDesc !=  null)
 {
 var strThemeDesc = objcc_ThemesEN.ThemeDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strThemeDesc, concc_Themes.ThemeDesc); //主题描述
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Themes.ThemeDesc); //主题描述
 }
 }
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.PageName))
 {
 if (objcc_ThemesEN.PageName !=  null)
 {
 var strPageName = objcc_ThemesEN.PageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPageName, concc_Themes.PageName); //页面名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Themes.PageName); //页面名称
 }
 }
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.ExampleImgPath))
 {
 if (objcc_ThemesEN.ExampleImgPath !=  null)
 {
 var strExampleImgPath = objcc_ThemesEN.ExampleImgPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExampleImgPath, concc_Themes.ExampleImgPath); //示例图路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Themes.ExampleImgPath); //示例图路径
 }
 }
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.OrderNum))
 {
 if (objcc_ThemesEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_ThemesEN.OrderNum, concc_Themes.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Themes.OrderNum); //序号
 }
 }
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.IsUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_ThemesEN.IsUse == true?"1":"0", concc_Themes.IsUse); //是否使用
 }
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.UpdDate))
 {
 if (objcc_ThemesEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_ThemesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_Themes.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Themes.UpdDate); //修改日期
 }
 }
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.UpdUserId))
 {
 if (objcc_ThemesEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_ThemesEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, concc_Themes.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Themes.UpdUserId); //修改用户Id
 }
 }
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.Memo))
 {
 if (objcc_ThemesEN.Memo !=  null)
 {
 var strMemo = objcc_ThemesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_Themes.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Themes.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ThemeId = '{0}'", objcc_ThemesEN.ThemeId); 
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
 /// <param name = "objcc_ThemesEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clscc_ThemesEN objcc_ThemesEN, string strCondition)
{
 objcc_ThemesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_ThemesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_ThemesEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_Themes Set ");
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.ThemeName))
 {
 if (objcc_ThemesEN.ThemeName !=  null)
 {
 var strThemeName = objcc_ThemesEN.ThemeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ThemeName = '{0}',", strThemeName); //主题名
 }
 else
 {
 sbSQL.Append(" ThemeName = null,"); //主题名
 }
 }
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.ThemeDesc))
 {
 if (objcc_ThemesEN.ThemeDesc !=  null)
 {
 var strThemeDesc = objcc_ThemesEN.ThemeDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ThemeDesc = '{0}',", strThemeDesc); //主题描述
 }
 else
 {
 sbSQL.Append(" ThemeDesc = null,"); //主题描述
 }
 }
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.PageName))
 {
 if (objcc_ThemesEN.PageName !=  null)
 {
 var strPageName = objcc_ThemesEN.PageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PageName = '{0}',", strPageName); //页面名称
 }
 else
 {
 sbSQL.Append(" PageName = null,"); //页面名称
 }
 }
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.ExampleImgPath))
 {
 if (objcc_ThemesEN.ExampleImgPath !=  null)
 {
 var strExampleImgPath = objcc_ThemesEN.ExampleImgPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExampleImgPath = '{0}',", strExampleImgPath); //示例图路径
 }
 else
 {
 sbSQL.Append(" ExampleImgPath = null,"); //示例图路径
 }
 }
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.OrderNum))
 {
 if (objcc_ThemesEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_ThemesEN.OrderNum, concc_Themes.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Themes.OrderNum); //序号
 }
 }
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.IsUse))
 {
 sbSQL.AppendFormat(" IsUse = '{0}',", objcc_ThemesEN.IsUse == true?"1":"0"); //是否使用
 }
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.UpdDate))
 {
 if (objcc_ThemesEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_ThemesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.UpdUserId))
 {
 if (objcc_ThemesEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_ThemesEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.Memo))
 {
 if (objcc_ThemesEN.Memo !=  null)
 {
 var strMemo = objcc_ThemesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_ThemesEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clscc_ThemesEN objcc_ThemesEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcc_ThemesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_ThemesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_ThemesEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_Themes Set ");
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.ThemeName))
 {
 if (objcc_ThemesEN.ThemeName !=  null)
 {
 var strThemeName = objcc_ThemesEN.ThemeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ThemeName = '{0}',", strThemeName); //主题名
 }
 else
 {
 sbSQL.Append(" ThemeName = null,"); //主题名
 }
 }
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.ThemeDesc))
 {
 if (objcc_ThemesEN.ThemeDesc !=  null)
 {
 var strThemeDesc = objcc_ThemesEN.ThemeDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ThemeDesc = '{0}',", strThemeDesc); //主题描述
 }
 else
 {
 sbSQL.Append(" ThemeDesc = null,"); //主题描述
 }
 }
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.PageName))
 {
 if (objcc_ThemesEN.PageName !=  null)
 {
 var strPageName = objcc_ThemesEN.PageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PageName = '{0}',", strPageName); //页面名称
 }
 else
 {
 sbSQL.Append(" PageName = null,"); //页面名称
 }
 }
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.ExampleImgPath))
 {
 if (objcc_ThemesEN.ExampleImgPath !=  null)
 {
 var strExampleImgPath = objcc_ThemesEN.ExampleImgPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExampleImgPath = '{0}',", strExampleImgPath); //示例图路径
 }
 else
 {
 sbSQL.Append(" ExampleImgPath = null,"); //示例图路径
 }
 }
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.OrderNum))
 {
 if (objcc_ThemesEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_ThemesEN.OrderNum, concc_Themes.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Themes.OrderNum); //序号
 }
 }
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.IsUse))
 {
 sbSQL.AppendFormat(" IsUse = '{0}',", objcc_ThemesEN.IsUse == true?"1":"0"); //是否使用
 }
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.UpdDate))
 {
 if (objcc_ThemesEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_ThemesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.UpdUserId))
 {
 if (objcc_ThemesEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_ThemesEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.Memo))
 {
 if (objcc_ThemesEN.Memo !=  null)
 {
 var strMemo = objcc_ThemesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_ThemesEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_ThemesEN objcc_ThemesEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcc_ThemesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_ThemesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_ThemesEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_Themes Set ");
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.ThemeName))
 {
 if (objcc_ThemesEN.ThemeName !=  null)
 {
 var strThemeName = objcc_ThemesEN.ThemeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strThemeName, concc_Themes.ThemeName); //主题名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Themes.ThemeName); //主题名
 }
 }
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.ThemeDesc))
 {
 if (objcc_ThemesEN.ThemeDesc !=  null)
 {
 var strThemeDesc = objcc_ThemesEN.ThemeDesc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strThemeDesc, concc_Themes.ThemeDesc); //主题描述
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Themes.ThemeDesc); //主题描述
 }
 }
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.PageName))
 {
 if (objcc_ThemesEN.PageName !=  null)
 {
 var strPageName = objcc_ThemesEN.PageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPageName, concc_Themes.PageName); //页面名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Themes.PageName); //页面名称
 }
 }
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.ExampleImgPath))
 {
 if (objcc_ThemesEN.ExampleImgPath !=  null)
 {
 var strExampleImgPath = objcc_ThemesEN.ExampleImgPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExampleImgPath, concc_Themes.ExampleImgPath); //示例图路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Themes.ExampleImgPath); //示例图路径
 }
 }
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.OrderNum))
 {
 if (objcc_ThemesEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_ThemesEN.OrderNum, concc_Themes.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Themes.OrderNum); //序号
 }
 }
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.IsUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_ThemesEN.IsUse == true?"1":"0", concc_Themes.IsUse); //是否使用
 }
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.UpdDate))
 {
 if (objcc_ThemesEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_ThemesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_Themes.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Themes.UpdDate); //修改日期
 }
 }
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.UpdUserId))
 {
 if (objcc_ThemesEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_ThemesEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, concc_Themes.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Themes.UpdUserId); //修改用户Id
 }
 }
 
 if (objcc_ThemesEN.IsUpdated(concc_Themes.Memo))
 {
 if (objcc_ThemesEN.Memo !=  null)
 {
 var strMemo = objcc_ThemesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_Themes.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Themes.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ThemeId = '{0}'", objcc_ThemesEN.ThemeId); 
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
 /// <param name = "strThemeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strThemeId) 
{
CheckPrimaryKey(strThemeId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strThemeId,
};
 objSQL.ExecSP("cc_Themes_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strThemeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strThemeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strThemeId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
//删除cc_Themes本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_Themes where ThemeId = " + "'"+ strThemeId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delcc_Themes(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
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
//删除cc_Themes本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_Themes where ThemeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strThemeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strThemeId) 
{
CheckPrimaryKey(strThemeId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
//删除cc_Themes本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_Themes where ThemeId = " + "'"+ strThemeId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delcc_Themes(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clscc_ThemesDA: Delcc_Themes)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_Themes where " + strCondition ;
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
public bool Delcc_ThemesWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clscc_ThemesDA: Delcc_ThemesWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_Themes where " + strCondition ;
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
 /// <param name = "objcc_ThemesENS">源对象</param>
 /// <param name = "objcc_ThemesENT">目标对象</param>
public void CopyTo(clscc_ThemesEN objcc_ThemesENS, clscc_ThemesEN objcc_ThemesENT)
{
objcc_ThemesENT.ThemeId = objcc_ThemesENS.ThemeId; //主题Id
objcc_ThemesENT.ThemeName = objcc_ThemesENS.ThemeName; //主题名
objcc_ThemesENT.ThemeDesc = objcc_ThemesENS.ThemeDesc; //主题描述
objcc_ThemesENT.PageName = objcc_ThemesENS.PageName; //页面名称
objcc_ThemesENT.ExampleImgPath = objcc_ThemesENS.ExampleImgPath; //示例图路径
objcc_ThemesENT.OrderNum = objcc_ThemesENS.OrderNum; //序号
objcc_ThemesENT.IsUse = objcc_ThemesENS.IsUse; //是否使用
objcc_ThemesENT.UpdDate = objcc_ThemesENS.UpdDate; //修改日期
objcc_ThemesENT.UpdUserId = objcc_ThemesENS.UpdUserId; //修改用户Id
objcc_ThemesENT.Memo = objcc_ThemesENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clscc_ThemesEN objcc_ThemesEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objcc_ThemesEN.ThemeName, concc_Themes.ThemeName);
clsCheckSql.CheckFieldNotNull(objcc_ThemesEN.UpdDate, concc_Themes.UpdDate);
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_ThemesEN.ThemeId, 4, concc_Themes.ThemeId);
clsCheckSql.CheckFieldLen(objcc_ThemesEN.ThemeName, 200, concc_Themes.ThemeName);
clsCheckSql.CheckFieldLen(objcc_ThemesEN.ThemeDesc, 500, concc_Themes.ThemeDesc);
clsCheckSql.CheckFieldLen(objcc_ThemesEN.PageName, 100, concc_Themes.PageName);
clsCheckSql.CheckFieldLen(objcc_ThemesEN.ExampleImgPath, 300, concc_Themes.ExampleImgPath);
clsCheckSql.CheckFieldLen(objcc_ThemesEN.UpdDate, 20, concc_Themes.UpdDate);
clsCheckSql.CheckFieldLen(objcc_ThemesEN.UpdUserId, 20, concc_Themes.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_ThemesEN.Memo, 1000, concc_Themes.Memo);
//检查字段外键固定长度
 objcc_ThemesEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clscc_ThemesEN objcc_ThemesEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_ThemesEN.ThemeName, 200, concc_Themes.ThemeName);
clsCheckSql.CheckFieldLen(objcc_ThemesEN.ThemeDesc, 500, concc_Themes.ThemeDesc);
clsCheckSql.CheckFieldLen(objcc_ThemesEN.PageName, 100, concc_Themes.PageName);
clsCheckSql.CheckFieldLen(objcc_ThemesEN.ExampleImgPath, 300, concc_Themes.ExampleImgPath);
clsCheckSql.CheckFieldLen(objcc_ThemesEN.UpdDate, 20, concc_Themes.UpdDate);
clsCheckSql.CheckFieldLen(objcc_ThemesEN.UpdUserId, 20, concc_Themes.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_ThemesEN.Memo, 1000, concc_Themes.Memo);
//检查外键字段长度
 objcc_ThemesEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clscc_ThemesEN objcc_ThemesEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_ThemesEN.ThemeId, 4, concc_Themes.ThemeId);
clsCheckSql.CheckFieldLen(objcc_ThemesEN.ThemeName, 200, concc_Themes.ThemeName);
clsCheckSql.CheckFieldLen(objcc_ThemesEN.ThemeDesc, 500, concc_Themes.ThemeDesc);
clsCheckSql.CheckFieldLen(objcc_ThemesEN.PageName, 100, concc_Themes.PageName);
clsCheckSql.CheckFieldLen(objcc_ThemesEN.ExampleImgPath, 300, concc_Themes.ExampleImgPath);
clsCheckSql.CheckFieldLen(objcc_ThemesEN.UpdDate, 20, concc_Themes.UpdDate);
clsCheckSql.CheckFieldLen(objcc_ThemesEN.UpdUserId, 20, concc_Themes.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_ThemesEN.Memo, 1000, concc_Themes.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objcc_ThemesEN.ThemeId, concc_Themes.ThemeId);
clsCheckSql.CheckSqlInjection4Field(objcc_ThemesEN.ThemeName, concc_Themes.ThemeName);
clsCheckSql.CheckSqlInjection4Field(objcc_ThemesEN.ThemeDesc, concc_Themes.ThemeDesc);
clsCheckSql.CheckSqlInjection4Field(objcc_ThemesEN.PageName, concc_Themes.PageName);
clsCheckSql.CheckSqlInjection4Field(objcc_ThemesEN.ExampleImgPath, concc_Themes.ExampleImgPath);
clsCheckSql.CheckSqlInjection4Field(objcc_ThemesEN.UpdDate, concc_Themes.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objcc_ThemesEN.UpdUserId, concc_Themes.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objcc_ThemesEN.Memo, concc_Themes.Memo);
//检查外键字段长度
 objcc_ThemesEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetThemeId()
{
//获取某学院所有专业信息
string strSQL = "select ThemeId, ThemeName from cc_Themes ";
 clsSpecSQLforSql mySql = clscc_ThemesDA.GetSpecSQLObj();
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
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
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
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
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
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_ThemesEN._CurrTabName);
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
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_ThemesEN._CurrTabName, strCondition);
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
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
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
 objSQL = clscc_ThemesDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}