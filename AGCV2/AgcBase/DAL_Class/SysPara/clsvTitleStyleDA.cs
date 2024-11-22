﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTitleStyleDA
 表名:vTitleStyle(00050304)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 11:53:39
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
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
using AGC.Entity;

namespace AGC.DAL
{
 /// <summary>
 /// v标题模式(vTitleStyle)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvTitleStyleDA : clsCommBase4DA
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
 return clsvTitleStyleEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvTitleStyleEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTitleStyleEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvTitleStyleEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvTitleStyleEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strTitleStyleId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strTitleStyleId)
{
strTitleStyleId = strTitleStyleId.Replace("'", "''");
if (strTitleStyleId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vTitleStyle中,检查关键字,长度不正确!(clsvTitleStyleDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTitleStyleId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vTitleStyle中,关键字不能为空 或 null!(clsvTitleStyleDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTitleStyleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvTitleStyleDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvTitleStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTitleStyleDA.GetSpecSQLObj();
strSQL = "Select * from vTitleStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vTitleStyle(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvTitleStyleDA: GetDataTable_vTitleStyle)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTitleStyleDA.GetSpecSQLObj();
strSQL = "Select * from vTitleStyle where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvTitleStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTitleStyleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvTitleStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTitleStyleDA.GetSpecSQLObj();
strSQL = "Select * from vTitleStyle where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvTitleStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTitleStyleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvTitleStyleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTitleStyleDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTitleStyle where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTitleStyle where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvTitleStyleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTitleStyleDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vTitleStyle where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvTitleStyleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTitleStyleDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vTitleStyle.* from vTitleStyle Left Join {1} on {2} where {3} and vTitleStyle.TitleStyleId not in (Select top {5} vTitleStyle.TitleStyleId from vTitleStyle Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTitleStyle where {1} and TitleStyleId not in (Select top {2} TitleStyleId from vTitleStyle where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTitleStyle where {1} and TitleStyleId not in (Select top {3} TitleStyleId from vTitleStyle where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvTitleStyleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTitleStyleDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vTitleStyle.* from vTitleStyle Left Join {1} on {2} where {3} and vTitleStyle.TitleStyleId not in (Select top {5} vTitleStyle.TitleStyleId from vTitleStyle Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTitleStyle where {1} and TitleStyleId not in (Select top {2} TitleStyleId from vTitleStyle where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTitleStyle where {1} and TitleStyleId not in (Select top {3} TitleStyleId from vTitleStyle where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvTitleStyleEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvTitleStyleDA:GetObjLst)", objException.Message));
}
List<clsvTitleStyleEN> arrObjLst = new List<clsvTitleStyleEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTitleStyleDA.GetSpecSQLObj();
strSQL = "Select * from vTitleStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTitleStyleEN objvTitleStyleEN = new clsvTitleStyleEN();
try
{
objvTitleStyleEN.TitleStyleId = objRow[convTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id
objvTitleStyleEN.TitleTypeName = objRow[convTitleStyle.TitleTypeName].ToString().Trim(); //标题类型
objvTitleStyleEN.TitleStyleName = objRow[convTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名
objvTitleStyleEN.PrjId = objRow[convTitleStyle.PrjId].ToString().Trim(); //工程ID
objvTitleStyleEN.TabHeight = TransNullToInt(objRow[convTitleStyle.TabHeight].ToString().Trim()); //表格高度
objvTitleStyleEN.PrjName = objRow[convTitleStyle.PrjName].ToString().Trim(); //工程名称
objvTitleStyleEN.ImgFile = objRow[convTitleStyle.ImgFile] == DBNull.Value ? null : objRow[convTitleStyle.ImgFile].ToString().Trim(); //图像文件
objvTitleStyleEN.BackColor = objRow[convTitleStyle.BackColor].ToString().Trim(); //背景颜色
objvTitleStyleEN.TabWidth = TransNullToInt(objRow[convTitleStyle.TabWidth].ToString().Trim()); //表格宽度
objvTitleStyleEN.ForeColor = objRow[convTitleStyle.ForeColor].ToString().Trim(); //前景颜色
objvTitleStyleEN.FontSize = objRow[convTitleStyle.FontSize] == DBNull.Value ? null : objRow[convTitleStyle.FontSize].ToString().Trim(); //字号
objvTitleStyleEN.FontName = objRow[convTitleStyle.FontName] == DBNull.Value ? null : objRow[convTitleStyle.FontName].ToString().Trim(); //字体
objvTitleStyleEN.IsDefault = TransNullToBool(objRow[convTitleStyle.IsDefault].ToString().Trim()); //是否默认
objvTitleStyleEN.TitleTypeId = objRow[convTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTitleStyleDA: GetObjLst)", objException.Message));
}
objvTitleStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTitleStyleEN);
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
public List<clsvTitleStyleEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvTitleStyleDA:GetObjLstByTabName)", objException.Message));
}
List<clsvTitleStyleEN> arrObjLst = new List<clsvTitleStyleEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTitleStyleDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTitleStyleEN objvTitleStyleEN = new clsvTitleStyleEN();
try
{
objvTitleStyleEN.TitleStyleId = objRow[convTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id
objvTitleStyleEN.TitleTypeName = objRow[convTitleStyle.TitleTypeName].ToString().Trim(); //标题类型
objvTitleStyleEN.TitleStyleName = objRow[convTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名
objvTitleStyleEN.PrjId = objRow[convTitleStyle.PrjId].ToString().Trim(); //工程ID
objvTitleStyleEN.TabHeight = TransNullToInt(objRow[convTitleStyle.TabHeight].ToString().Trim()); //表格高度
objvTitleStyleEN.PrjName = objRow[convTitleStyle.PrjName].ToString().Trim(); //工程名称
objvTitleStyleEN.ImgFile = objRow[convTitleStyle.ImgFile] == DBNull.Value ? null : objRow[convTitleStyle.ImgFile].ToString().Trim(); //图像文件
objvTitleStyleEN.BackColor = objRow[convTitleStyle.BackColor].ToString().Trim(); //背景颜色
objvTitleStyleEN.TabWidth = TransNullToInt(objRow[convTitleStyle.TabWidth].ToString().Trim()); //表格宽度
objvTitleStyleEN.ForeColor = objRow[convTitleStyle.ForeColor].ToString().Trim(); //前景颜色
objvTitleStyleEN.FontSize = objRow[convTitleStyle.FontSize] == DBNull.Value ? null : objRow[convTitleStyle.FontSize].ToString().Trim(); //字号
objvTitleStyleEN.FontName = objRow[convTitleStyle.FontName] == DBNull.Value ? null : objRow[convTitleStyle.FontName].ToString().Trim(); //字体
objvTitleStyleEN.IsDefault = TransNullToBool(objRow[convTitleStyle.IsDefault].ToString().Trim()); //是否默认
objvTitleStyleEN.TitleTypeId = objRow[convTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTitleStyleDA: GetObjLst)", objException.Message));
}
objvTitleStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTitleStyleEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvTitleStyleEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvTitleStyle(ref clsvTitleStyleEN objvTitleStyleEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTitleStyleDA.GetSpecSQLObj();
strSQL = "Select * from vTitleStyle where TitleStyleId = " + "'"+ objvTitleStyleEN.TitleStyleId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvTitleStyleEN.TitleStyleId = objDT.Rows[0][convTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id(字段类型:varchar,字段长度:8,是否可空:False)
 objvTitleStyleEN.TitleTypeName = objDT.Rows[0][convTitleStyle.TitleTypeName].ToString().Trim(); //标题类型(字段类型:varchar,字段长度:20,是否可空:False)
 objvTitleStyleEN.TitleStyleName = objDT.Rows[0][convTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名(字段类型:varchar,字段长度:20,是否可空:False)
 objvTitleStyleEN.PrjId = objDT.Rows[0][convTitleStyle.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvTitleStyleEN.TabHeight = TransNullToInt(objDT.Rows[0][convTitleStyle.TabHeight].ToString().Trim()); //表格高度(字段类型:int,字段长度:4,是否可空:False)
 objvTitleStyleEN.PrjName = objDT.Rows[0][convTitleStyle.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTitleStyleEN.ImgFile = objDT.Rows[0][convTitleStyle.ImgFile].ToString().Trim(); //图像文件(字段类型:varchar,字段长度:200,是否可空:True)
 objvTitleStyleEN.BackColor = objDT.Rows[0][convTitleStyle.BackColor].ToString().Trim(); //背景颜色(字段类型:varchar,字段长度:30,是否可空:False)
 objvTitleStyleEN.TabWidth = TransNullToInt(objDT.Rows[0][convTitleStyle.TabWidth].ToString().Trim()); //表格宽度(字段类型:int,字段长度:4,是否可空:False)
 objvTitleStyleEN.ForeColor = objDT.Rows[0][convTitleStyle.ForeColor].ToString().Trim(); //前景颜色(字段类型:varchar,字段长度:30,是否可空:False)
 objvTitleStyleEN.FontSize = objDT.Rows[0][convTitleStyle.FontSize].ToString().Trim(); //字号(字段类型:varchar,字段长度:20,是否可空:True)
 objvTitleStyleEN.FontName = objDT.Rows[0][convTitleStyle.FontName].ToString().Trim(); //字体(字段类型:varchar,字段长度:20,是否可空:True)
 objvTitleStyleEN.IsDefault = TransNullToBool(objDT.Rows[0][convTitleStyle.IsDefault].ToString().Trim()); //是否默认(字段类型:bit,字段长度:1,是否可空:True)
 objvTitleStyleEN.TitleTypeId = objDT.Rows[0][convTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID(字段类型:varchar,字段长度:2,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvTitleStyleDA: GetvTitleStyle)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTitleStyleId">表关键字</param>
 /// <returns>表对象</returns>
public clsvTitleStyleEN GetObjByTitleStyleId(string strTitleStyleId)
{
CheckPrimaryKey(strTitleStyleId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTitleStyleDA.GetSpecSQLObj();
strSQL = "Select * from vTitleStyle where TitleStyleId = " + "'"+ strTitleStyleId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvTitleStyleEN objvTitleStyleEN = new clsvTitleStyleEN();
try
{
 objvTitleStyleEN.TitleStyleId = objRow[convTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id(字段类型:varchar,字段长度:8,是否可空:False)
 objvTitleStyleEN.TitleTypeName = objRow[convTitleStyle.TitleTypeName].ToString().Trim(); //标题类型(字段类型:varchar,字段长度:20,是否可空:False)
 objvTitleStyleEN.TitleStyleName = objRow[convTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名(字段类型:varchar,字段长度:20,是否可空:False)
 objvTitleStyleEN.PrjId = objRow[convTitleStyle.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvTitleStyleEN.TabHeight = Int32.Parse(objRow[convTitleStyle.TabHeight].ToString().Trim()); //表格高度(字段类型:int,字段长度:4,是否可空:False)
 objvTitleStyleEN.PrjName = objRow[convTitleStyle.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTitleStyleEN.ImgFile = objRow[convTitleStyle.ImgFile] == DBNull.Value ? null : objRow[convTitleStyle.ImgFile].ToString().Trim(); //图像文件(字段类型:varchar,字段长度:200,是否可空:True)
 objvTitleStyleEN.BackColor = objRow[convTitleStyle.BackColor].ToString().Trim(); //背景颜色(字段类型:varchar,字段长度:30,是否可空:False)
 objvTitleStyleEN.TabWidth = Int32.Parse(objRow[convTitleStyle.TabWidth].ToString().Trim()); //表格宽度(字段类型:int,字段长度:4,是否可空:False)
 objvTitleStyleEN.ForeColor = objRow[convTitleStyle.ForeColor].ToString().Trim(); //前景颜色(字段类型:varchar,字段长度:30,是否可空:False)
 objvTitleStyleEN.FontSize = objRow[convTitleStyle.FontSize] == DBNull.Value ? null : objRow[convTitleStyle.FontSize].ToString().Trim(); //字号(字段类型:varchar,字段长度:20,是否可空:True)
 objvTitleStyleEN.FontName = objRow[convTitleStyle.FontName] == DBNull.Value ? null : objRow[convTitleStyle.FontName].ToString().Trim(); //字体(字段类型:varchar,字段长度:20,是否可空:True)
 objvTitleStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convTitleStyle.IsDefault].ToString().Trim()); //是否默认(字段类型:bit,字段长度:1,是否可空:True)
 objvTitleStyleEN.TitleTypeId = objRow[convTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID(字段类型:varchar,字段长度:2,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvTitleStyleDA: GetObjByTitleStyleId)", objException.Message));
}
return objvTitleStyleEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvTitleStyleEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvTitleStyleDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTitleStyleDA.GetSpecSQLObj();
strSQL = "Select * from vTitleStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvTitleStyleEN objvTitleStyleEN = new clsvTitleStyleEN()
{
TitleStyleId = objRow[convTitleStyle.TitleStyleId].ToString().Trim(), //标题类型Id
TitleTypeName = objRow[convTitleStyle.TitleTypeName].ToString().Trim(), //标题类型
TitleStyleName = objRow[convTitleStyle.TitleStyleName].ToString().Trim(), //标题类型名
PrjId = objRow[convTitleStyle.PrjId].ToString().Trim(), //工程ID
TabHeight = TransNullToInt(objRow[convTitleStyle.TabHeight].ToString().Trim()), //表格高度
PrjName = objRow[convTitleStyle.PrjName].ToString().Trim(), //工程名称
ImgFile = objRow[convTitleStyle.ImgFile] == DBNull.Value ? null : objRow[convTitleStyle.ImgFile].ToString().Trim(), //图像文件
BackColor = objRow[convTitleStyle.BackColor].ToString().Trim(), //背景颜色
TabWidth = TransNullToInt(objRow[convTitleStyle.TabWidth].ToString().Trim()), //表格宽度
ForeColor = objRow[convTitleStyle.ForeColor].ToString().Trim(), //前景颜色
FontSize = objRow[convTitleStyle.FontSize] == DBNull.Value ? null : objRow[convTitleStyle.FontSize].ToString().Trim(), //字号
FontName = objRow[convTitleStyle.FontName] == DBNull.Value ? null : objRow[convTitleStyle.FontName].ToString().Trim(), //字体
IsDefault = TransNullToBool(objRow[convTitleStyle.IsDefault].ToString().Trim()), //是否默认
TitleTypeId = objRow[convTitleStyle.TitleTypeId].ToString().Trim() //标题类型ID
};
objvTitleStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTitleStyleEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvTitleStyleDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvTitleStyleEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTitleStyleEN objvTitleStyleEN = new clsvTitleStyleEN();
try
{
objvTitleStyleEN.TitleStyleId = objRow[convTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id
objvTitleStyleEN.TitleTypeName = objRow[convTitleStyle.TitleTypeName].ToString().Trim(); //标题类型
objvTitleStyleEN.TitleStyleName = objRow[convTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名
objvTitleStyleEN.PrjId = objRow[convTitleStyle.PrjId].ToString().Trim(); //工程ID
objvTitleStyleEN.TabHeight = TransNullToInt(objRow[convTitleStyle.TabHeight].ToString().Trim()); //表格高度
objvTitleStyleEN.PrjName = objRow[convTitleStyle.PrjName].ToString().Trim(); //工程名称
objvTitleStyleEN.ImgFile = objRow[convTitleStyle.ImgFile] == DBNull.Value ? null : objRow[convTitleStyle.ImgFile].ToString().Trim(); //图像文件
objvTitleStyleEN.BackColor = objRow[convTitleStyle.BackColor].ToString().Trim(); //背景颜色
objvTitleStyleEN.TabWidth = TransNullToInt(objRow[convTitleStyle.TabWidth].ToString().Trim()); //表格宽度
objvTitleStyleEN.ForeColor = objRow[convTitleStyle.ForeColor].ToString().Trim(); //前景颜色
objvTitleStyleEN.FontSize = objRow[convTitleStyle.FontSize] == DBNull.Value ? null : objRow[convTitleStyle.FontSize].ToString().Trim(); //字号
objvTitleStyleEN.FontName = objRow[convTitleStyle.FontName] == DBNull.Value ? null : objRow[convTitleStyle.FontName].ToString().Trim(); //字体
objvTitleStyleEN.IsDefault = TransNullToBool(objRow[convTitleStyle.IsDefault].ToString().Trim()); //是否默认
objvTitleStyleEN.TitleTypeId = objRow[convTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvTitleStyleDA: GetObjByDataRowvTitleStyle)", objException.Message));
}
objvTitleStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTitleStyleEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvTitleStyleEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTitleStyleEN objvTitleStyleEN = new clsvTitleStyleEN();
try
{
objvTitleStyleEN.TitleStyleId = objRow[convTitleStyle.TitleStyleId].ToString().Trim(); //标题类型Id
objvTitleStyleEN.TitleTypeName = objRow[convTitleStyle.TitleTypeName].ToString().Trim(); //标题类型
objvTitleStyleEN.TitleStyleName = objRow[convTitleStyle.TitleStyleName].ToString().Trim(); //标题类型名
objvTitleStyleEN.PrjId = objRow[convTitleStyle.PrjId].ToString().Trim(); //工程ID
objvTitleStyleEN.TabHeight = TransNullToInt(objRow[convTitleStyle.TabHeight].ToString().Trim()); //表格高度
objvTitleStyleEN.PrjName = objRow[convTitleStyle.PrjName].ToString().Trim(); //工程名称
objvTitleStyleEN.ImgFile = objRow[convTitleStyle.ImgFile] == DBNull.Value ? null : objRow[convTitleStyle.ImgFile].ToString().Trim(); //图像文件
objvTitleStyleEN.BackColor = objRow[convTitleStyle.BackColor].ToString().Trim(); //背景颜色
objvTitleStyleEN.TabWidth = TransNullToInt(objRow[convTitleStyle.TabWidth].ToString().Trim()); //表格宽度
objvTitleStyleEN.ForeColor = objRow[convTitleStyle.ForeColor].ToString().Trim(); //前景颜色
objvTitleStyleEN.FontSize = objRow[convTitleStyle.FontSize] == DBNull.Value ? null : objRow[convTitleStyle.FontSize].ToString().Trim(); //字号
objvTitleStyleEN.FontName = objRow[convTitleStyle.FontName] == DBNull.Value ? null : objRow[convTitleStyle.FontName].ToString().Trim(); //字体
objvTitleStyleEN.IsDefault = TransNullToBool(objRow[convTitleStyle.IsDefault].ToString().Trim()); //是否默认
objvTitleStyleEN.TitleTypeId = objRow[convTitleStyle.TitleTypeId].ToString().Trim(); //标题类型ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvTitleStyleDA: GetObjByDataRow)", objException.Message));
}
objvTitleStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTitleStyleEN;
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
objSQL = clsvTitleStyleDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTitleStyleEN._CurrTabName, convTitleStyle.TitleStyleId, 8, "");
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
objSQL = clsvTitleStyleDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTitleStyleEN._CurrTabName, convTitleStyle.TitleStyleId, 8, strPrefix);
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
 objSQL = clsvTitleStyleDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TitleStyleId from vTitleStyle where " + strCondition;
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
 objSQL = clsvTitleStyleDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TitleStyleId from vTitleStyle where " + strCondition;
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
 /// <param name = "strTitleStyleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strTitleStyleId)
{
CheckPrimaryKey(strTitleStyleId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTitleStyleDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTitleStyle", "TitleStyleId = " + "'"+ strTitleStyleId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvTitleStyleDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTitleStyleDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTitleStyle", strCondition))
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
objSQL = clsvTitleStyleDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vTitleStyle");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvTitleStyleENS">源对象</param>
 /// <param name = "objvTitleStyleENT">目标对象</param>
public void CopyTo(clsvTitleStyleEN objvTitleStyleENS, clsvTitleStyleEN objvTitleStyleENT)
{
objvTitleStyleENT.TitleStyleId = objvTitleStyleENS.TitleStyleId; //标题类型Id
objvTitleStyleENT.TitleTypeName = objvTitleStyleENS.TitleTypeName; //标题类型
objvTitleStyleENT.TitleStyleName = objvTitleStyleENS.TitleStyleName; //标题类型名
objvTitleStyleENT.PrjId = objvTitleStyleENS.PrjId; //工程ID
objvTitleStyleENT.TabHeight = objvTitleStyleENS.TabHeight; //表格高度
objvTitleStyleENT.PrjName = objvTitleStyleENS.PrjName; //工程名称
objvTitleStyleENT.ImgFile = objvTitleStyleENS.ImgFile; //图像文件
objvTitleStyleENT.BackColor = objvTitleStyleENS.BackColor; //背景颜色
objvTitleStyleENT.TabWidth = objvTitleStyleENS.TabWidth; //表格宽度
objvTitleStyleENT.ForeColor = objvTitleStyleENS.ForeColor; //前景颜色
objvTitleStyleENT.FontSize = objvTitleStyleENS.FontSize; //字号
objvTitleStyleENT.FontName = objvTitleStyleENS.FontName; //字体
objvTitleStyleENT.IsDefault = objvTitleStyleENS.IsDefault; //是否默认
objvTitleStyleENT.TitleTypeId = objvTitleStyleENS.TitleTypeId; //标题类型ID
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvTitleStyleEN objvTitleStyleEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvTitleStyleEN.TitleStyleId, 8, convTitleStyle.TitleStyleId);
clsCheckSql.CheckFieldLen(objvTitleStyleEN.TitleTypeName, 20, convTitleStyle.TitleTypeName);
clsCheckSql.CheckFieldLen(objvTitleStyleEN.TitleStyleName, 20, convTitleStyle.TitleStyleName);
clsCheckSql.CheckFieldLen(objvTitleStyleEN.PrjId, 4, convTitleStyle.PrjId);
clsCheckSql.CheckFieldLen(objvTitleStyleEN.PrjName, 30, convTitleStyle.PrjName);
clsCheckSql.CheckFieldLen(objvTitleStyleEN.ImgFile, 200, convTitleStyle.ImgFile);
clsCheckSql.CheckFieldLen(objvTitleStyleEN.BackColor, 30, convTitleStyle.BackColor);
clsCheckSql.CheckFieldLen(objvTitleStyleEN.ForeColor, 30, convTitleStyle.ForeColor);
clsCheckSql.CheckFieldLen(objvTitleStyleEN.FontSize, 20, convTitleStyle.FontSize);
clsCheckSql.CheckFieldLen(objvTitleStyleEN.FontName, 20, convTitleStyle.FontName);
clsCheckSql.CheckFieldLen(objvTitleStyleEN.TitleTypeId, 2, convTitleStyle.TitleTypeId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvTitleStyleEN.TitleStyleId, convTitleStyle.TitleStyleId);
clsCheckSql.CheckSqlInjection4Field(objvTitleStyleEN.TitleTypeName, convTitleStyle.TitleTypeName);
clsCheckSql.CheckSqlInjection4Field(objvTitleStyleEN.TitleStyleName, convTitleStyle.TitleStyleName);
clsCheckSql.CheckSqlInjection4Field(objvTitleStyleEN.PrjId, convTitleStyle.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvTitleStyleEN.PrjName, convTitleStyle.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvTitleStyleEN.ImgFile, convTitleStyle.ImgFile);
clsCheckSql.CheckSqlInjection4Field(objvTitleStyleEN.BackColor, convTitleStyle.BackColor);
clsCheckSql.CheckSqlInjection4Field(objvTitleStyleEN.ForeColor, convTitleStyle.ForeColor);
clsCheckSql.CheckSqlInjection4Field(objvTitleStyleEN.FontSize, convTitleStyle.FontSize);
clsCheckSql.CheckSqlInjection4Field(objvTitleStyleEN.FontName, convTitleStyle.FontName);
clsCheckSql.CheckSqlInjection4Field(objvTitleStyleEN.TitleTypeId, convTitleStyle.TitleTypeId);
//检查外键字段长度
 objvTitleStyleEN._IsCheckProperty = true;
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
 objSQL = clsvTitleStyleDA.GetSpecSQLObj();
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
 objSQL = clsvTitleStyleDA.GetSpecSQLObj();
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
 objSQL = clsvTitleStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTitleStyleEN._CurrTabName);
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
 objSQL = clsvTitleStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTitleStyleEN._CurrTabName, strCondition);
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
 objSQL = clsvTitleStyleDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}