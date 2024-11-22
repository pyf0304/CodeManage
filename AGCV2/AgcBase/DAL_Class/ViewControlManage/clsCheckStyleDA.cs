﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCheckStyleDA
 表名:CheckStyle(00050056)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 12:05:13
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面控件管理(ViewControlManage)
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
using AGC.Entity;

namespace AGC.DAL
{
 /// <summary>
 /// 复选框样式(CheckStyle)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCheckStyleDA : clsCommBase4DA
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
 return clsCheckStyleEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCheckStyleEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCheckStyleEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCheckStyleEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCheckStyleEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCheckStyleId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCheckStyleId)
{
strCheckStyleId = strCheckStyleId.Replace("'", "''");
if (strCheckStyleId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:CheckStyle中,检查关键字,长度不正确!(clsCheckStyleDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCheckStyleId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:CheckStyle中,关键字不能为空 或 null!(clsCheckStyleDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCheckStyleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsCheckStyleDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCheckStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
strSQL = "Select * from CheckStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CheckStyle(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCheckStyleDA: GetDataTable_CheckStyle)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
strSQL = "Select * from CheckStyle where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCheckStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCheckStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
strSQL = "Select * from CheckStyle where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCheckStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCheckStyleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CheckStyle where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CheckStyle where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCheckStyleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CheckStyle where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCheckStyleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CheckStyle.* from CheckStyle Left Join {1} on {2} where {3} and CheckStyle.CheckStyleId not in (Select top {5} CheckStyle.CheckStyleId from CheckStyle Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CheckStyle where {1} and CheckStyleId not in (Select top {2} CheckStyleId from CheckStyle where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CheckStyle where {1} and CheckStyleId not in (Select top {3} CheckStyleId from CheckStyle where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCheckStyleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CheckStyle.* from CheckStyle Left Join {1} on {2} where {3} and CheckStyle.CheckStyleId not in (Select top {5} CheckStyle.CheckStyleId from CheckStyle Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CheckStyle where {1} and CheckStyleId not in (Select top {2} CheckStyleId from CheckStyle where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CheckStyle where {1} and CheckStyleId not in (Select top {3} CheckStyleId from CheckStyle where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCheckStyleEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCheckStyleDA:GetObjLst)", objException.Message));
}
List<clsCheckStyleEN> arrObjLst = new List<clsCheckStyleEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
strSQL = "Select * from CheckStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCheckStyleEN objCheckStyleEN = new clsCheckStyleEN();
try
{
objCheckStyleEN.CheckStyleId = objRow[conCheckStyle.CheckStyleId].ToString().Trim(); //CheckStyleId
objCheckStyleEN.CheckStyleName = objRow[conCheckStyle.CheckStyleName].ToString().Trim(); //CheckStyleName
objCheckStyleEN.Style = objRow[conCheckStyle.Style] == DBNull.Value ? null : objRow[conCheckStyle.Style].ToString().Trim(); //类型
objCheckStyleEN.Runat = objRow[conCheckStyle.Runat] == DBNull.Value ? null : objRow[conCheckStyle.Runat].ToString().Trim(); //运行在
objCheckStyleEN.FontSize = objRow[conCheckStyle.FontSize] == DBNull.Value ? null : objRow[conCheckStyle.FontSize].ToString().Trim(); //字号
objCheckStyleEN.FontName = objRow[conCheckStyle.FontName] == DBNull.Value ? null : objRow[conCheckStyle.FontName].ToString().Trim(); //字体
objCheckStyleEN.Width = objRow[conCheckStyle.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCheckStyle.Width].ToString().Trim()); //宽
objCheckStyleEN.Height = objRow[conCheckStyle.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCheckStyle.Height].ToString().Trim()); //高度
objCheckStyleEN.StyleZindex = objRow[conCheckStyle.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCheckStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objCheckStyleEN.StyleLeft = objRow[conCheckStyle.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCheckStyle.StyleLeft].ToString().Trim()); //Style_Left
objCheckStyleEN.StylePosition = objRow[conCheckStyle.StylePosition] == DBNull.Value ? null : objRow[conCheckStyle.StylePosition].ToString().Trim(); //Style_Position
objCheckStyleEN.StyleTop = objRow[conCheckStyle.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCheckStyle.StyleTop].ToString().Trim()); //Style_Top
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCheckStyleDA: GetObjLst)", objException.Message));
}
objCheckStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCheckStyleEN);
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
public List<clsCheckStyleEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCheckStyleDA:GetObjLstByTabName)", objException.Message));
}
List<clsCheckStyleEN> arrObjLst = new List<clsCheckStyleEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCheckStyleEN objCheckStyleEN = new clsCheckStyleEN();
try
{
objCheckStyleEN.CheckStyleId = objRow[conCheckStyle.CheckStyleId].ToString().Trim(); //CheckStyleId
objCheckStyleEN.CheckStyleName = objRow[conCheckStyle.CheckStyleName].ToString().Trim(); //CheckStyleName
objCheckStyleEN.Style = objRow[conCheckStyle.Style] == DBNull.Value ? null : objRow[conCheckStyle.Style].ToString().Trim(); //类型
objCheckStyleEN.Runat = objRow[conCheckStyle.Runat] == DBNull.Value ? null : objRow[conCheckStyle.Runat].ToString().Trim(); //运行在
objCheckStyleEN.FontSize = objRow[conCheckStyle.FontSize] == DBNull.Value ? null : objRow[conCheckStyle.FontSize].ToString().Trim(); //字号
objCheckStyleEN.FontName = objRow[conCheckStyle.FontName] == DBNull.Value ? null : objRow[conCheckStyle.FontName].ToString().Trim(); //字体
objCheckStyleEN.Width = objRow[conCheckStyle.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCheckStyle.Width].ToString().Trim()); //宽
objCheckStyleEN.Height = objRow[conCheckStyle.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCheckStyle.Height].ToString().Trim()); //高度
objCheckStyleEN.StyleZindex = objRow[conCheckStyle.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCheckStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objCheckStyleEN.StyleLeft = objRow[conCheckStyle.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCheckStyle.StyleLeft].ToString().Trim()); //Style_Left
objCheckStyleEN.StylePosition = objRow[conCheckStyle.StylePosition] == DBNull.Value ? null : objRow[conCheckStyle.StylePosition].ToString().Trim(); //Style_Position
objCheckStyleEN.StyleTop = objRow[conCheckStyle.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCheckStyle.StyleTop].ToString().Trim()); //Style_Top
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCheckStyleDA: GetObjLst)", objException.Message));
}
objCheckStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCheckStyleEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCheckStyleEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCheckStyle(ref clsCheckStyleEN objCheckStyleEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
strSQL = "Select * from CheckStyle where CheckStyleId = " + "'"+ objCheckStyleEN.CheckStyleId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCheckStyleEN.CheckStyleId = objDT.Rows[0][conCheckStyle.CheckStyleId].ToString().Trim(); //CheckStyleId(字段类型:varchar,字段长度:4,是否可空:False)
 objCheckStyleEN.CheckStyleName = objDT.Rows[0][conCheckStyle.CheckStyleName].ToString().Trim(); //CheckStyleName(字段类型:varchar,字段长度:30,是否可空:False)
 objCheckStyleEN.Style = objDT.Rows[0][conCheckStyle.Style].ToString().Trim(); //类型(字段类型:varchar,字段长度:800,是否可空:True)
 objCheckStyleEN.Runat = objDT.Rows[0][conCheckStyle.Runat].ToString().Trim(); //运行在(字段类型:varchar,字段长度:30,是否可空:True)
 objCheckStyleEN.FontSize = objDT.Rows[0][conCheckStyle.FontSize].ToString().Trim(); //字号(字段类型:varchar,字段长度:20,是否可空:True)
 objCheckStyleEN.FontName = objDT.Rows[0][conCheckStyle.FontName].ToString().Trim(); //字体(字段类型:varchar,字段长度:20,是否可空:True)
 objCheckStyleEN.Width = TransNullToInt(objDT.Rows[0][conCheckStyle.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objCheckStyleEN.Height = TransNullToInt(objDT.Rows[0][conCheckStyle.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objCheckStyleEN.StyleZindex = TransNullToInt(objDT.Rows[0][conCheckStyle.StyleZindex].ToString().Trim()); //Style_Zindex(字段类型:int,字段长度:4,是否可空:True)
 objCheckStyleEN.StyleLeft = TransNullToInt(objDT.Rows[0][conCheckStyle.StyleLeft].ToString().Trim()); //Style_Left(字段类型:int,字段长度:4,是否可空:True)
 objCheckStyleEN.StylePosition = objDT.Rows[0][conCheckStyle.StylePosition].ToString().Trim(); //Style_Position(字段类型:varchar,字段长度:20,是否可空:True)
 objCheckStyleEN.StyleTop = TransNullToInt(objDT.Rows[0][conCheckStyle.StyleTop].ToString().Trim()); //Style_Top(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCheckStyleDA: GetCheckStyle)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCheckStyleId">表关键字</param>
 /// <returns>表对象</returns>
public clsCheckStyleEN GetObjByCheckStyleId(string strCheckStyleId)
{
CheckPrimaryKey(strCheckStyleId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
strSQL = "Select * from CheckStyle where CheckStyleId = " + "'"+ strCheckStyleId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCheckStyleEN objCheckStyleEN = new clsCheckStyleEN();
try
{
 objCheckStyleEN.CheckStyleId = objRow[conCheckStyle.CheckStyleId].ToString().Trim(); //CheckStyleId(字段类型:varchar,字段长度:4,是否可空:False)
 objCheckStyleEN.CheckStyleName = objRow[conCheckStyle.CheckStyleName].ToString().Trim(); //CheckStyleName(字段类型:varchar,字段长度:30,是否可空:False)
 objCheckStyleEN.Style = objRow[conCheckStyle.Style] == DBNull.Value ? null : objRow[conCheckStyle.Style].ToString().Trim(); //类型(字段类型:varchar,字段长度:800,是否可空:True)
 objCheckStyleEN.Runat = objRow[conCheckStyle.Runat] == DBNull.Value ? null : objRow[conCheckStyle.Runat].ToString().Trim(); //运行在(字段类型:varchar,字段长度:30,是否可空:True)
 objCheckStyleEN.FontSize = objRow[conCheckStyle.FontSize] == DBNull.Value ? null : objRow[conCheckStyle.FontSize].ToString().Trim(); //字号(字段类型:varchar,字段长度:20,是否可空:True)
 objCheckStyleEN.FontName = objRow[conCheckStyle.FontName] == DBNull.Value ? null : objRow[conCheckStyle.FontName].ToString().Trim(); //字体(字段类型:varchar,字段长度:20,是否可空:True)
 objCheckStyleEN.Width = objRow[conCheckStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objCheckStyleEN.Height = objRow[conCheckStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objCheckStyleEN.StyleZindex = objRow[conCheckStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleZindex].ToString().Trim()); //Style_Zindex(字段类型:int,字段长度:4,是否可空:True)
 objCheckStyleEN.StyleLeft = objRow[conCheckStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleLeft].ToString().Trim()); //Style_Left(字段类型:int,字段长度:4,是否可空:True)
 objCheckStyleEN.StylePosition = objRow[conCheckStyle.StylePosition] == DBNull.Value ? null : objRow[conCheckStyle.StylePosition].ToString().Trim(); //Style_Position(字段类型:varchar,字段长度:20,是否可空:True)
 objCheckStyleEN.StyleTop = objRow[conCheckStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCheckStyle.StyleTop].ToString().Trim()); //Style_Top(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCheckStyleDA: GetObjByCheckStyleId)", objException.Message));
}
return objCheckStyleEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCheckStyleEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCheckStyleDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
strSQL = "Select * from CheckStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCheckStyleEN objCheckStyleEN = new clsCheckStyleEN()
{
CheckStyleId = objRow[conCheckStyle.CheckStyleId].ToString().Trim(), //CheckStyleId
CheckStyleName = objRow[conCheckStyle.CheckStyleName].ToString().Trim(), //CheckStyleName
Style = objRow[conCheckStyle.Style] == DBNull.Value ? null : objRow[conCheckStyle.Style].ToString().Trim(), //类型
Runat = objRow[conCheckStyle.Runat] == DBNull.Value ? null : objRow[conCheckStyle.Runat].ToString().Trim(), //运行在
FontSize = objRow[conCheckStyle.FontSize] == DBNull.Value ? null : objRow[conCheckStyle.FontSize].ToString().Trim(), //字号
FontName = objRow[conCheckStyle.FontName] == DBNull.Value ? null : objRow[conCheckStyle.FontName].ToString().Trim(), //字体
Width = objRow[conCheckStyle.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCheckStyle.Width].ToString().Trim()), //宽
Height = objRow[conCheckStyle.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCheckStyle.Height].ToString().Trim()), //高度
StyleZindex = objRow[conCheckStyle.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCheckStyle.StyleZindex].ToString().Trim()), //Style_Zindex
StyleLeft = objRow[conCheckStyle.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCheckStyle.StyleLeft].ToString().Trim()), //Style_Left
StylePosition = objRow[conCheckStyle.StylePosition] == DBNull.Value ? null : objRow[conCheckStyle.StylePosition].ToString().Trim(), //Style_Position
StyleTop = objRow[conCheckStyle.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCheckStyle.StyleTop].ToString().Trim()) //Style_Top
};
objCheckStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCheckStyleEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCheckStyleDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCheckStyleEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCheckStyleEN objCheckStyleEN = new clsCheckStyleEN();
try
{
objCheckStyleEN.CheckStyleId = objRow[conCheckStyle.CheckStyleId].ToString().Trim(); //CheckStyleId
objCheckStyleEN.CheckStyleName = objRow[conCheckStyle.CheckStyleName].ToString().Trim(); //CheckStyleName
objCheckStyleEN.Style = objRow[conCheckStyle.Style] == DBNull.Value ? null : objRow[conCheckStyle.Style].ToString().Trim(); //类型
objCheckStyleEN.Runat = objRow[conCheckStyle.Runat] == DBNull.Value ? null : objRow[conCheckStyle.Runat].ToString().Trim(); //运行在
objCheckStyleEN.FontSize = objRow[conCheckStyle.FontSize] == DBNull.Value ? null : objRow[conCheckStyle.FontSize].ToString().Trim(); //字号
objCheckStyleEN.FontName = objRow[conCheckStyle.FontName] == DBNull.Value ? null : objRow[conCheckStyle.FontName].ToString().Trim(); //字体
objCheckStyleEN.Width = objRow[conCheckStyle.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCheckStyle.Width].ToString().Trim()); //宽
objCheckStyleEN.Height = objRow[conCheckStyle.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCheckStyle.Height].ToString().Trim()); //高度
objCheckStyleEN.StyleZindex = objRow[conCheckStyle.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCheckStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objCheckStyleEN.StyleLeft = objRow[conCheckStyle.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCheckStyle.StyleLeft].ToString().Trim()); //Style_Left
objCheckStyleEN.StylePosition = objRow[conCheckStyle.StylePosition] == DBNull.Value ? null : objRow[conCheckStyle.StylePosition].ToString().Trim(); //Style_Position
objCheckStyleEN.StyleTop = objRow[conCheckStyle.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCheckStyle.StyleTop].ToString().Trim()); //Style_Top
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCheckStyleDA: GetObjByDataRowCheckStyle)", objException.Message));
}
objCheckStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCheckStyleEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCheckStyleEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCheckStyleEN objCheckStyleEN = new clsCheckStyleEN();
try
{
objCheckStyleEN.CheckStyleId = objRow[conCheckStyle.CheckStyleId].ToString().Trim(); //CheckStyleId
objCheckStyleEN.CheckStyleName = objRow[conCheckStyle.CheckStyleName].ToString().Trim(); //CheckStyleName
objCheckStyleEN.Style = objRow[conCheckStyle.Style] == DBNull.Value ? null : objRow[conCheckStyle.Style].ToString().Trim(); //类型
objCheckStyleEN.Runat = objRow[conCheckStyle.Runat] == DBNull.Value ? null : objRow[conCheckStyle.Runat].ToString().Trim(); //运行在
objCheckStyleEN.FontSize = objRow[conCheckStyle.FontSize] == DBNull.Value ? null : objRow[conCheckStyle.FontSize].ToString().Trim(); //字号
objCheckStyleEN.FontName = objRow[conCheckStyle.FontName] == DBNull.Value ? null : objRow[conCheckStyle.FontName].ToString().Trim(); //字体
objCheckStyleEN.Width = objRow[conCheckStyle.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCheckStyle.Width].ToString().Trim()); //宽
objCheckStyleEN.Height = objRow[conCheckStyle.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCheckStyle.Height].ToString().Trim()); //高度
objCheckStyleEN.StyleZindex = objRow[conCheckStyle.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCheckStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objCheckStyleEN.StyleLeft = objRow[conCheckStyle.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCheckStyle.StyleLeft].ToString().Trim()); //Style_Left
objCheckStyleEN.StylePosition = objRow[conCheckStyle.StylePosition] == DBNull.Value ? null : objRow[conCheckStyle.StylePosition].ToString().Trim(); //Style_Position
objCheckStyleEN.StyleTop = objRow[conCheckStyle.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCheckStyle.StyleTop].ToString().Trim()); //Style_Top
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCheckStyleDA: GetObjByDataRow)", objException.Message));
}
objCheckStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCheckStyleEN;
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
objSQL = clsCheckStyleDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCheckStyleEN._CurrTabName, conCheckStyle.CheckStyleId, 4, "");
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
objSQL = clsCheckStyleDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCheckStyleEN._CurrTabName, conCheckStyle.CheckStyleId, 4, strPrefix);
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
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CheckStyleId from CheckStyle where " + strCondition;
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
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CheckStyleId from CheckStyle where " + strCondition;
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
 /// <param name = "strCheckStyleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCheckStyleId)
{
CheckPrimaryKey(strCheckStyleId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CheckStyle", "CheckStyleId = " + "'"+ strCheckStyleId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCheckStyleDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CheckStyle", strCondition))
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
objSQL = clsCheckStyleDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CheckStyle");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCheckStyleEN objCheckStyleEN)
 {
 if (objCheckStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCheckStyleEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
strSQL = "Select * from CheckStyle where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CheckStyle");
objRow = objDS.Tables["CheckStyle"].NewRow();
objRow[conCheckStyle.CheckStyleId] = objCheckStyleEN.CheckStyleId; //CheckStyleId
objRow[conCheckStyle.CheckStyleName] = objCheckStyleEN.CheckStyleName; //CheckStyleName
 if (objCheckStyleEN.Style !=  "")
 {
objRow[conCheckStyle.Style] = objCheckStyleEN.Style; //类型
 }
 if (objCheckStyleEN.Runat !=  "")
 {
objRow[conCheckStyle.Runat] = objCheckStyleEN.Runat; //运行在
 }
 if (objCheckStyleEN.FontSize !=  "")
 {
objRow[conCheckStyle.FontSize] = objCheckStyleEN.FontSize; //字号
 }
 if (objCheckStyleEN.FontName !=  "")
 {
objRow[conCheckStyle.FontName] = objCheckStyleEN.FontName; //字体
 }
objRow[conCheckStyle.Width] = objCheckStyleEN.Width; //宽
objRow[conCheckStyle.Height] = objCheckStyleEN.Height; //高度
objRow[conCheckStyle.StyleZindex] = objCheckStyleEN.StyleZindex; //Style_Zindex
objRow[conCheckStyle.StyleLeft] = objCheckStyleEN.StyleLeft; //Style_Left
 if (objCheckStyleEN.StylePosition !=  "")
 {
objRow[conCheckStyle.StylePosition] = objCheckStyleEN.StylePosition; //Style_Position
 }
objRow[conCheckStyle.StyleTop] = objCheckStyleEN.StyleTop; //Style_Top
objDS.Tables[clsCheckStyleEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCheckStyleEN._CurrTabName);
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
 /// <param name = "objCheckStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCheckStyleEN objCheckStyleEN)
{
 if (objCheckStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCheckStyleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCheckStyleEN.CheckStyleId !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.CheckStyleId);
 var strCheckStyleId = objCheckStyleEN.CheckStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckStyleId + "'");
 }
 
 if (objCheckStyleEN.CheckStyleName !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.CheckStyleName);
 var strCheckStyleName = objCheckStyleEN.CheckStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckStyleName + "'");
 }
 
 if (objCheckStyleEN.Style !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.Style);
 var strStyle = objCheckStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyle + "'");
 }
 
 if (objCheckStyleEN.Runat !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.Runat);
 var strRunat = objCheckStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRunat + "'");
 }
 
 if (objCheckStyleEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.FontSize);
 var strFontSize = objCheckStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontSize + "'");
 }
 
 if (objCheckStyleEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.FontName);
 var strFontName = objCheckStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontName + "'");
 }
 
 if (objCheckStyleEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.Width);
 arrValueListForInsert.Add(objCheckStyleEN.Width.ToString());
 }
 
 if (objCheckStyleEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.Height);
 arrValueListForInsert.Add(objCheckStyleEN.Height.ToString());
 }
 
 if (objCheckStyleEN.StyleZindex !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.StyleZindex);
 arrValueListForInsert.Add(objCheckStyleEN.StyleZindex.ToString());
 }
 
 if (objCheckStyleEN.StyleLeft !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.StyleLeft);
 arrValueListForInsert.Add(objCheckStyleEN.StyleLeft.ToString());
 }
 
 if (objCheckStyleEN.StylePosition !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.StylePosition);
 var strStylePosition = objCheckStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStylePosition + "'");
 }
 
 if (objCheckStyleEN.StyleTop !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.StyleTop);
 arrValueListForInsert.Add(objCheckStyleEN.StyleTop.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CheckStyle");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCheckStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCheckStyleEN objCheckStyleEN)
{
 if (objCheckStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCheckStyleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCheckStyleEN.CheckStyleId !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.CheckStyleId);
 var strCheckStyleId = objCheckStyleEN.CheckStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckStyleId + "'");
 }
 
 if (objCheckStyleEN.CheckStyleName !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.CheckStyleName);
 var strCheckStyleName = objCheckStyleEN.CheckStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckStyleName + "'");
 }
 
 if (objCheckStyleEN.Style !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.Style);
 var strStyle = objCheckStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyle + "'");
 }
 
 if (objCheckStyleEN.Runat !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.Runat);
 var strRunat = objCheckStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRunat + "'");
 }
 
 if (objCheckStyleEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.FontSize);
 var strFontSize = objCheckStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontSize + "'");
 }
 
 if (objCheckStyleEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.FontName);
 var strFontName = objCheckStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontName + "'");
 }
 
 if (objCheckStyleEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.Width);
 arrValueListForInsert.Add(objCheckStyleEN.Width.ToString());
 }
 
 if (objCheckStyleEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.Height);
 arrValueListForInsert.Add(objCheckStyleEN.Height.ToString());
 }
 
 if (objCheckStyleEN.StyleZindex !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.StyleZindex);
 arrValueListForInsert.Add(objCheckStyleEN.StyleZindex.ToString());
 }
 
 if (objCheckStyleEN.StyleLeft !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.StyleLeft);
 arrValueListForInsert.Add(objCheckStyleEN.StyleLeft.ToString());
 }
 
 if (objCheckStyleEN.StylePosition !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.StylePosition);
 var strStylePosition = objCheckStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStylePosition + "'");
 }
 
 if (objCheckStyleEN.StyleTop !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.StyleTop);
 arrValueListForInsert.Add(objCheckStyleEN.StyleTop.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CheckStyle");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objCheckStyleEN.CheckStyleId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCheckStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCheckStyleEN objCheckStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCheckStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCheckStyleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCheckStyleEN.CheckStyleId !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.CheckStyleId);
 var strCheckStyleId = objCheckStyleEN.CheckStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckStyleId + "'");
 }
 
 if (objCheckStyleEN.CheckStyleName !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.CheckStyleName);
 var strCheckStyleName = objCheckStyleEN.CheckStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckStyleName + "'");
 }
 
 if (objCheckStyleEN.Style !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.Style);
 var strStyle = objCheckStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyle + "'");
 }
 
 if (objCheckStyleEN.Runat !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.Runat);
 var strRunat = objCheckStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRunat + "'");
 }
 
 if (objCheckStyleEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.FontSize);
 var strFontSize = objCheckStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontSize + "'");
 }
 
 if (objCheckStyleEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.FontName);
 var strFontName = objCheckStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontName + "'");
 }
 
 if (objCheckStyleEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.Width);
 arrValueListForInsert.Add(objCheckStyleEN.Width.ToString());
 }
 
 if (objCheckStyleEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.Height);
 arrValueListForInsert.Add(objCheckStyleEN.Height.ToString());
 }
 
 if (objCheckStyleEN.StyleZindex !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.StyleZindex);
 arrValueListForInsert.Add(objCheckStyleEN.StyleZindex.ToString());
 }
 
 if (objCheckStyleEN.StyleLeft !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.StyleLeft);
 arrValueListForInsert.Add(objCheckStyleEN.StyleLeft.ToString());
 }
 
 if (objCheckStyleEN.StylePosition !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.StylePosition);
 var strStylePosition = objCheckStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStylePosition + "'");
 }
 
 if (objCheckStyleEN.StyleTop !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.StyleTop);
 arrValueListForInsert.Add(objCheckStyleEN.StyleTop.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CheckStyle");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objCheckStyleEN.CheckStyleId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCheckStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCheckStyleEN objCheckStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objCheckStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCheckStyleEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCheckStyleEN.CheckStyleId !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.CheckStyleId);
 var strCheckStyleId = objCheckStyleEN.CheckStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckStyleId + "'");
 }
 
 if (objCheckStyleEN.CheckStyleName !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.CheckStyleName);
 var strCheckStyleName = objCheckStyleEN.CheckStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckStyleName + "'");
 }
 
 if (objCheckStyleEN.Style !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.Style);
 var strStyle = objCheckStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyle + "'");
 }
 
 if (objCheckStyleEN.Runat !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.Runat);
 var strRunat = objCheckStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRunat + "'");
 }
 
 if (objCheckStyleEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.FontSize);
 var strFontSize = objCheckStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontSize + "'");
 }
 
 if (objCheckStyleEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.FontName);
 var strFontName = objCheckStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontName + "'");
 }
 
 if (objCheckStyleEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.Width);
 arrValueListForInsert.Add(objCheckStyleEN.Width.ToString());
 }
 
 if (objCheckStyleEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.Height);
 arrValueListForInsert.Add(objCheckStyleEN.Height.ToString());
 }
 
 if (objCheckStyleEN.StyleZindex !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.StyleZindex);
 arrValueListForInsert.Add(objCheckStyleEN.StyleZindex.ToString());
 }
 
 if (objCheckStyleEN.StyleLeft !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.StyleLeft);
 arrValueListForInsert.Add(objCheckStyleEN.StyleLeft.ToString());
 }
 
 if (objCheckStyleEN.StylePosition !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.StylePosition);
 var strStylePosition = objCheckStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStylePosition + "'");
 }
 
 if (objCheckStyleEN.StyleTop !=  null)
 {
 arrFieldListForInsert.Add(conCheckStyle.StyleTop);
 arrValueListForInsert.Add(objCheckStyleEN.StyleTop.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CheckStyle");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCheckStyles(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
strSQL = "Select * from CheckStyle where CheckStyleId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CheckStyle");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strCheckStyleId = oRow[conCheckStyle.CheckStyleId].ToString().Trim();
if (IsExist(strCheckStyleId))
{
 string strResult = "关键字变量值为:" + string.Format("CheckStyleId = {0}", strCheckStyleId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCheckStyleEN._CurrTabName ].NewRow();
objRow[conCheckStyle.CheckStyleId] = oRow[conCheckStyle.CheckStyleId].ToString().Trim(); //CheckStyleId
objRow[conCheckStyle.CheckStyleName] = oRow[conCheckStyle.CheckStyleName].ToString().Trim(); //CheckStyleName
objRow[conCheckStyle.Style] = oRow[conCheckStyle.Style].ToString().Trim(); //类型
objRow[conCheckStyle.Runat] = oRow[conCheckStyle.Runat].ToString().Trim(); //运行在
objRow[conCheckStyle.FontSize] = oRow[conCheckStyle.FontSize].ToString().Trim(); //字号
objRow[conCheckStyle.FontName] = oRow[conCheckStyle.FontName].ToString().Trim(); //字体
objRow[conCheckStyle.Width] = oRow[conCheckStyle.Width].ToString().Trim(); //宽
objRow[conCheckStyle.Height] = oRow[conCheckStyle.Height].ToString().Trim(); //高度
objRow[conCheckStyle.StyleZindex] = oRow[conCheckStyle.StyleZindex].ToString().Trim(); //Style_Zindex
objRow[conCheckStyle.StyleLeft] = oRow[conCheckStyle.StyleLeft].ToString().Trim(); //Style_Left
objRow[conCheckStyle.StylePosition] = oRow[conCheckStyle.StylePosition].ToString().Trim(); //Style_Position
objRow[conCheckStyle.StyleTop] = oRow[conCheckStyle.StyleTop].ToString().Trim(); //Style_Top
 objDS.Tables[clsCheckStyleEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCheckStyleEN._CurrTabName);
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
 /// <param name = "objCheckStyleEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCheckStyleEN objCheckStyleEN)
{
 if (objCheckStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCheckStyleEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
strSQL = "Select * from CheckStyle where CheckStyleId = " + "'"+ objCheckStyleEN.CheckStyleId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCheckStyleEN._CurrTabName);
if (objDS.Tables[clsCheckStyleEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:CheckStyleId = " + "'"+ objCheckStyleEN.CheckStyleId+"'");
return false;
}
objRow = objDS.Tables[clsCheckStyleEN._CurrTabName].Rows[0];
 if (objCheckStyleEN.IsUpdated(conCheckStyle.CheckStyleId))
 {
objRow[conCheckStyle.CheckStyleId] = objCheckStyleEN.CheckStyleId; //CheckStyleId
 }
 if (objCheckStyleEN.IsUpdated(conCheckStyle.CheckStyleName))
 {
objRow[conCheckStyle.CheckStyleName] = objCheckStyleEN.CheckStyleName; //CheckStyleName
 }
 if (objCheckStyleEN.IsUpdated(conCheckStyle.Style))
 {
objRow[conCheckStyle.Style] = objCheckStyleEN.Style; //类型
 }
 if (objCheckStyleEN.IsUpdated(conCheckStyle.Runat))
 {
objRow[conCheckStyle.Runat] = objCheckStyleEN.Runat; //运行在
 }
 if (objCheckStyleEN.IsUpdated(conCheckStyle.FontSize))
 {
objRow[conCheckStyle.FontSize] = objCheckStyleEN.FontSize; //字号
 }
 if (objCheckStyleEN.IsUpdated(conCheckStyle.FontName))
 {
objRow[conCheckStyle.FontName] = objCheckStyleEN.FontName; //字体
 }
 if (objCheckStyleEN.IsUpdated(conCheckStyle.Width))
 {
objRow[conCheckStyle.Width] = objCheckStyleEN.Width; //宽
 }
 if (objCheckStyleEN.IsUpdated(conCheckStyle.Height))
 {
objRow[conCheckStyle.Height] = objCheckStyleEN.Height; //高度
 }
 if (objCheckStyleEN.IsUpdated(conCheckStyle.StyleZindex))
 {
objRow[conCheckStyle.StyleZindex] = objCheckStyleEN.StyleZindex; //Style_Zindex
 }
 if (objCheckStyleEN.IsUpdated(conCheckStyle.StyleLeft))
 {
objRow[conCheckStyle.StyleLeft] = objCheckStyleEN.StyleLeft; //Style_Left
 }
 if (objCheckStyleEN.IsUpdated(conCheckStyle.StylePosition))
 {
objRow[conCheckStyle.StylePosition] = objCheckStyleEN.StylePosition; //Style_Position
 }
 if (objCheckStyleEN.IsUpdated(conCheckStyle.StyleTop))
 {
objRow[conCheckStyle.StyleTop] = objCheckStyleEN.StyleTop; //Style_Top
 }
try
{
objDA.Update(objDS, clsCheckStyleEN._CurrTabName);
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
 /// <param name = "objCheckStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCheckStyleEN objCheckStyleEN)
{
 if (objCheckStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCheckStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CheckStyle Set ");
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.CheckStyleName))
 {
 if (objCheckStyleEN.CheckStyleName !=  null)
 {
 var strCheckStyleName = objCheckStyleEN.CheckStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCheckStyleName, conCheckStyle.CheckStyleName); //CheckStyleName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCheckStyle.CheckStyleName); //CheckStyleName
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.Style))
 {
 if (objCheckStyleEN.Style !=  null)
 {
 var strStyle = objCheckStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStyle, conCheckStyle.Style); //类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCheckStyle.Style); //类型
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.Runat))
 {
 if (objCheckStyleEN.Runat !=  null)
 {
 var strRunat = objCheckStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRunat, conCheckStyle.Runat); //运行在
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCheckStyle.Runat); //运行在
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.FontSize))
 {
 if (objCheckStyleEN.FontSize !=  null)
 {
 var strFontSize = objCheckStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFontSize, conCheckStyle.FontSize); //字号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCheckStyle.FontSize); //字号
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.FontName))
 {
 if (objCheckStyleEN.FontName !=  null)
 {
 var strFontName = objCheckStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFontName, conCheckStyle.FontName); //字体
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCheckStyle.FontName); //字体
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.Width))
 {
 if (objCheckStyleEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCheckStyleEN.Width, conCheckStyle.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCheckStyle.Width); //宽
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.Height))
 {
 if (objCheckStyleEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCheckStyleEN.Height, conCheckStyle.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCheckStyle.Height); //高度
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.StyleZindex))
 {
 if (objCheckStyleEN.StyleZindex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCheckStyleEN.StyleZindex, conCheckStyle.StyleZindex); //Style_Zindex
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCheckStyle.StyleZindex); //Style_Zindex
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.StyleLeft))
 {
 if (objCheckStyleEN.StyleLeft !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCheckStyleEN.StyleLeft, conCheckStyle.StyleLeft); //Style_Left
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCheckStyle.StyleLeft); //Style_Left
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.StylePosition))
 {
 if (objCheckStyleEN.StylePosition !=  null)
 {
 var strStylePosition = objCheckStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStylePosition, conCheckStyle.StylePosition); //Style_Position
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCheckStyle.StylePosition); //Style_Position
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.StyleTop))
 {
 if (objCheckStyleEN.StyleTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCheckStyleEN.StyleTop, conCheckStyle.StyleTop); //Style_Top
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCheckStyle.StyleTop); //Style_Top
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CheckStyleId = '{0}'", objCheckStyleEN.CheckStyleId); 
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
 /// <param name = "objCheckStyleEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCheckStyleEN objCheckStyleEN, string strCondition)
{
 if (objCheckStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCheckStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CheckStyle Set ");
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.CheckStyleName))
 {
 if (objCheckStyleEN.CheckStyleName !=  null)
 {
 var strCheckStyleName = objCheckStyleEN.CheckStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CheckStyleName = '{0}',", strCheckStyleName); //CheckStyleName
 }
 else
 {
 sbSQL.Append(" CheckStyleName = null,"); //CheckStyleName
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.Style))
 {
 if (objCheckStyleEN.Style !=  null)
 {
 var strStyle = objCheckStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Style = '{0}',", strStyle); //类型
 }
 else
 {
 sbSQL.Append(" Style = null,"); //类型
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.Runat))
 {
 if (objCheckStyleEN.Runat !=  null)
 {
 var strRunat = objCheckStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Runat = '{0}',", strRunat); //运行在
 }
 else
 {
 sbSQL.Append(" Runat = null,"); //运行在
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.FontSize))
 {
 if (objCheckStyleEN.FontSize !=  null)
 {
 var strFontSize = objCheckStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontSize = '{0}',", strFontSize); //字号
 }
 else
 {
 sbSQL.Append(" FontSize = null,"); //字号
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.FontName))
 {
 if (objCheckStyleEN.FontName !=  null)
 {
 var strFontName = objCheckStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontName = '{0}',", strFontName); //字体
 }
 else
 {
 sbSQL.Append(" FontName = null,"); //字体
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.Width))
 {
 if (objCheckStyleEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCheckStyleEN.Width, conCheckStyle.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCheckStyle.Width); //宽
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.Height))
 {
 if (objCheckStyleEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCheckStyleEN.Height, conCheckStyle.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCheckStyle.Height); //高度
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.StyleZindex))
 {
 if (objCheckStyleEN.StyleZindex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCheckStyleEN.StyleZindex, conCheckStyle.StyleZindex); //Style_Zindex
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCheckStyle.StyleZindex); //Style_Zindex
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.StyleLeft))
 {
 if (objCheckStyleEN.StyleLeft !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCheckStyleEN.StyleLeft, conCheckStyle.StyleLeft); //Style_Left
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCheckStyle.StyleLeft); //Style_Left
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.StylePosition))
 {
 if (objCheckStyleEN.StylePosition !=  null)
 {
 var strStylePosition = objCheckStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StylePosition = '{0}',", strStylePosition); //Style_Position
 }
 else
 {
 sbSQL.Append(" StylePosition = null,"); //Style_Position
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.StyleTop))
 {
 if (objCheckStyleEN.StyleTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCheckStyleEN.StyleTop, conCheckStyle.StyleTop); //Style_Top
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCheckStyle.StyleTop); //Style_Top
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
 /// <param name = "objCheckStyleEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCheckStyleEN objCheckStyleEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCheckStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCheckStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CheckStyle Set ");
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.CheckStyleName))
 {
 if (objCheckStyleEN.CheckStyleName !=  null)
 {
 var strCheckStyleName = objCheckStyleEN.CheckStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CheckStyleName = '{0}',", strCheckStyleName); //CheckStyleName
 }
 else
 {
 sbSQL.Append(" CheckStyleName = null,"); //CheckStyleName
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.Style))
 {
 if (objCheckStyleEN.Style !=  null)
 {
 var strStyle = objCheckStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Style = '{0}',", strStyle); //类型
 }
 else
 {
 sbSQL.Append(" Style = null,"); //类型
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.Runat))
 {
 if (objCheckStyleEN.Runat !=  null)
 {
 var strRunat = objCheckStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Runat = '{0}',", strRunat); //运行在
 }
 else
 {
 sbSQL.Append(" Runat = null,"); //运行在
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.FontSize))
 {
 if (objCheckStyleEN.FontSize !=  null)
 {
 var strFontSize = objCheckStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontSize = '{0}',", strFontSize); //字号
 }
 else
 {
 sbSQL.Append(" FontSize = null,"); //字号
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.FontName))
 {
 if (objCheckStyleEN.FontName !=  null)
 {
 var strFontName = objCheckStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontName = '{0}',", strFontName); //字体
 }
 else
 {
 sbSQL.Append(" FontName = null,"); //字体
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.Width))
 {
 if (objCheckStyleEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCheckStyleEN.Width, conCheckStyle.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCheckStyle.Width); //宽
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.Height))
 {
 if (objCheckStyleEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCheckStyleEN.Height, conCheckStyle.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCheckStyle.Height); //高度
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.StyleZindex))
 {
 if (objCheckStyleEN.StyleZindex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCheckStyleEN.StyleZindex, conCheckStyle.StyleZindex); //Style_Zindex
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCheckStyle.StyleZindex); //Style_Zindex
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.StyleLeft))
 {
 if (objCheckStyleEN.StyleLeft !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCheckStyleEN.StyleLeft, conCheckStyle.StyleLeft); //Style_Left
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCheckStyle.StyleLeft); //Style_Left
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.StylePosition))
 {
 if (objCheckStyleEN.StylePosition !=  null)
 {
 var strStylePosition = objCheckStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StylePosition = '{0}',", strStylePosition); //Style_Position
 }
 else
 {
 sbSQL.Append(" StylePosition = null,"); //Style_Position
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.StyleTop))
 {
 if (objCheckStyleEN.StyleTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCheckStyleEN.StyleTop, conCheckStyle.StyleTop); //Style_Top
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCheckStyle.StyleTop); //Style_Top
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
 /// <param name = "objCheckStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCheckStyleEN objCheckStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objCheckStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCheckStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CheckStyle Set ");
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.CheckStyleName))
 {
 if (objCheckStyleEN.CheckStyleName !=  null)
 {
 var strCheckStyleName = objCheckStyleEN.CheckStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCheckStyleName, conCheckStyle.CheckStyleName); //CheckStyleName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCheckStyle.CheckStyleName); //CheckStyleName
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.Style))
 {
 if (objCheckStyleEN.Style !=  null)
 {
 var strStyle = objCheckStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStyle, conCheckStyle.Style); //类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCheckStyle.Style); //类型
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.Runat))
 {
 if (objCheckStyleEN.Runat !=  null)
 {
 var strRunat = objCheckStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRunat, conCheckStyle.Runat); //运行在
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCheckStyle.Runat); //运行在
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.FontSize))
 {
 if (objCheckStyleEN.FontSize !=  null)
 {
 var strFontSize = objCheckStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFontSize, conCheckStyle.FontSize); //字号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCheckStyle.FontSize); //字号
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.FontName))
 {
 if (objCheckStyleEN.FontName !=  null)
 {
 var strFontName = objCheckStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFontName, conCheckStyle.FontName); //字体
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCheckStyle.FontName); //字体
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.Width))
 {
 if (objCheckStyleEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCheckStyleEN.Width, conCheckStyle.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCheckStyle.Width); //宽
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.Height))
 {
 if (objCheckStyleEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCheckStyleEN.Height, conCheckStyle.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCheckStyle.Height); //高度
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.StyleZindex))
 {
 if (objCheckStyleEN.StyleZindex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCheckStyleEN.StyleZindex, conCheckStyle.StyleZindex); //Style_Zindex
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCheckStyle.StyleZindex); //Style_Zindex
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.StyleLeft))
 {
 if (objCheckStyleEN.StyleLeft !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCheckStyleEN.StyleLeft, conCheckStyle.StyleLeft); //Style_Left
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCheckStyle.StyleLeft); //Style_Left
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.StylePosition))
 {
 if (objCheckStyleEN.StylePosition !=  null)
 {
 var strStylePosition = objCheckStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStylePosition, conCheckStyle.StylePosition); //Style_Position
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCheckStyle.StylePosition); //Style_Position
 }
 }
 
 if (objCheckStyleEN.IsUpdated(conCheckStyle.StyleTop))
 {
 if (objCheckStyleEN.StyleTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCheckStyleEN.StyleTop, conCheckStyle.StyleTop); //Style_Top
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCheckStyle.StyleTop); //Style_Top
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CheckStyleId = '{0}'", objCheckStyleEN.CheckStyleId); 
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
 /// <param name = "strCheckStyleId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strCheckStyleId) 
{
CheckPrimaryKey(strCheckStyleId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strCheckStyleId,
};
 objSQL.ExecSP("CheckStyle_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strCheckStyleId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strCheckStyleId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strCheckStyleId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
//删除CheckStyle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CheckStyle where CheckStyleId = " + "'"+ strCheckStyleId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCheckStyle(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
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
//删除CheckStyle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CheckStyle where CheckStyleId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strCheckStyleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strCheckStyleId) 
{
CheckPrimaryKey(strCheckStyleId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
//删除CheckStyle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CheckStyle where CheckStyleId = " + "'"+ strCheckStyleId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCheckStyle(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCheckStyleDA: DelCheckStyle)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CheckStyle where " + strCondition ;
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
public bool DelCheckStyleWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCheckStyleDA: DelCheckStyleWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CheckStyle where " + strCondition ;
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
 /// <param name = "objCheckStyleENS">源对象</param>
 /// <param name = "objCheckStyleENT">目标对象</param>
public void CopyTo(clsCheckStyleEN objCheckStyleENS, clsCheckStyleEN objCheckStyleENT)
{
objCheckStyleENT.CheckStyleId = objCheckStyleENS.CheckStyleId; //CheckStyleId
objCheckStyleENT.CheckStyleName = objCheckStyleENS.CheckStyleName; //CheckStyleName
objCheckStyleENT.Style = objCheckStyleENS.Style; //类型
objCheckStyleENT.Runat = objCheckStyleENS.Runat; //运行在
objCheckStyleENT.FontSize = objCheckStyleENS.FontSize; //字号
objCheckStyleENT.FontName = objCheckStyleENS.FontName; //字体
objCheckStyleENT.Width = objCheckStyleENS.Width; //宽
objCheckStyleENT.Height = objCheckStyleENS.Height; //高度
objCheckStyleENT.StyleZindex = objCheckStyleENS.StyleZindex; //Style_Zindex
objCheckStyleENT.StyleLeft = objCheckStyleENS.StyleLeft; //Style_Left
objCheckStyleENT.StylePosition = objCheckStyleENS.StylePosition; //Style_Position
objCheckStyleENT.StyleTop = objCheckStyleENS.StyleTop; //Style_Top
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCheckStyleEN objCheckStyleEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCheckStyleEN.CheckStyleName, conCheckStyle.CheckStyleName);
//检查字段长度
clsCheckSql.CheckFieldLen(objCheckStyleEN.CheckStyleId, 4, conCheckStyle.CheckStyleId);
clsCheckSql.CheckFieldLen(objCheckStyleEN.CheckStyleName, 30, conCheckStyle.CheckStyleName);
clsCheckSql.CheckFieldLen(objCheckStyleEN.Style, 800, conCheckStyle.Style);
clsCheckSql.CheckFieldLen(objCheckStyleEN.Runat, 30, conCheckStyle.Runat);
clsCheckSql.CheckFieldLen(objCheckStyleEN.FontSize, 20, conCheckStyle.FontSize);
clsCheckSql.CheckFieldLen(objCheckStyleEN.FontName, 20, conCheckStyle.FontName);
clsCheckSql.CheckFieldLen(objCheckStyleEN.StylePosition, 20, conCheckStyle.StylePosition);
//检查字段外键固定长度
 objCheckStyleEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCheckStyleEN objCheckStyleEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCheckStyleEN.CheckStyleName, 30, conCheckStyle.CheckStyleName);
clsCheckSql.CheckFieldLen(objCheckStyleEN.Style, 800, conCheckStyle.Style);
clsCheckSql.CheckFieldLen(objCheckStyleEN.Runat, 30, conCheckStyle.Runat);
clsCheckSql.CheckFieldLen(objCheckStyleEN.FontSize, 20, conCheckStyle.FontSize);
clsCheckSql.CheckFieldLen(objCheckStyleEN.FontName, 20, conCheckStyle.FontName);
clsCheckSql.CheckFieldLen(objCheckStyleEN.StylePosition, 20, conCheckStyle.StylePosition);
//检查外键字段长度
 objCheckStyleEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCheckStyleEN objCheckStyleEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCheckStyleEN.CheckStyleId, 4, conCheckStyle.CheckStyleId);
clsCheckSql.CheckFieldLen(objCheckStyleEN.CheckStyleName, 30, conCheckStyle.CheckStyleName);
clsCheckSql.CheckFieldLen(objCheckStyleEN.Style, 800, conCheckStyle.Style);
clsCheckSql.CheckFieldLen(objCheckStyleEN.Runat, 30, conCheckStyle.Runat);
clsCheckSql.CheckFieldLen(objCheckStyleEN.FontSize, 20, conCheckStyle.FontSize);
clsCheckSql.CheckFieldLen(objCheckStyleEN.FontName, 20, conCheckStyle.FontName);
clsCheckSql.CheckFieldLen(objCheckStyleEN.StylePosition, 20, conCheckStyle.StylePosition);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCheckStyleEN.CheckStyleId, conCheckStyle.CheckStyleId);
clsCheckSql.CheckSqlInjection4Field(objCheckStyleEN.CheckStyleName, conCheckStyle.CheckStyleName);
clsCheckSql.CheckSqlInjection4Field(objCheckStyleEN.Style, conCheckStyle.Style);
clsCheckSql.CheckSqlInjection4Field(objCheckStyleEN.Runat, conCheckStyle.Runat);
clsCheckSql.CheckSqlInjection4Field(objCheckStyleEN.FontSize, conCheckStyle.FontSize);
clsCheckSql.CheckSqlInjection4Field(objCheckStyleEN.FontName, conCheckStyle.FontName);
clsCheckSql.CheckSqlInjection4Field(objCheckStyleEN.StylePosition, conCheckStyle.StylePosition);
//检查外键字段长度
 objCheckStyleEN._IsCheckProperty = true;
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
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
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
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
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
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCheckStyleEN._CurrTabName);
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
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCheckStyleEN._CurrTabName, strCondition);
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
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
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
 objSQL = clsCheckStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}