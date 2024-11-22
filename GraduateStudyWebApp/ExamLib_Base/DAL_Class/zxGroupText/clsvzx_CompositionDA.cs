
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_CompositionDA
 表名:vzx_Composition(01120765)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:31
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学小组课文(zxGroupText)
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
 /// vzx_Composition(vzx_Composition)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvzx_CompositionDA : clsCommBase4DA
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
 return clsvzx_CompositionEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvzx_CompositionEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_CompositionEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvzx_CompositionEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvzx_CompositionEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strzxPaperId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strzxPaperId)
{
strzxPaperId = strzxPaperId.Replace("'", "''");
if (strzxPaperId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vzx_Composition中,检查关键字,长度不正确!(clsvzx_CompositionDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strzxPaperId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vzx_Composition中,关键字不能为空 或 null!(clsvzx_CompositionDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxPaperId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvzx_CompositionDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvzx_CompositionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_CompositionDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Composition where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vzx_Composition(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvzx_CompositionDA: GetDataTable_vzx_Composition)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_CompositionDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Composition where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvzx_CompositionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_CompositionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvzx_CompositionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_CompositionDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Composition where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvzx_CompositionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_CompositionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvzx_CompositionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_CompositionDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_Composition where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_Composition where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvzx_CompositionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_CompositionDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vzx_Composition where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvzx_CompositionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_CompositionDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_Composition.* from vzx_Composition Left Join {1} on {2} where {3} and vzx_Composition.zxPaperId not in (Select top {5} vzx_Composition.zxPaperId from vzx_Composition Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_Composition where {1} and zxPaperId not in (Select top {2} zxPaperId from vzx_Composition where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_Composition where {1} and zxPaperId not in (Select top {3} zxPaperId from vzx_Composition where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvzx_CompositionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_CompositionDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_Composition.* from vzx_Composition Left Join {1} on {2} where {3} and vzx_Composition.zxPaperId not in (Select top {5} vzx_Composition.zxPaperId from vzx_Composition Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_Composition where {1} and zxPaperId not in (Select top {2} zxPaperId from vzx_Composition where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_Composition where {1} and zxPaperId not in (Select top {3} zxPaperId from vzx_Composition where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvzx_CompositionEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvzx_CompositionDA:GetObjLst)", objException.Message));
}
List<clsvzx_CompositionEN> arrObjLst = new List<clsvzx_CompositionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_CompositionDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Composition where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_CompositionEN objvzx_CompositionEN = new clsvzx_CompositionEN();
try
{
objvzx_CompositionEN.zxPaperId = objRow[convzx_Composition.zxPaperId].ToString().Trim(); //论文Id
objvzx_CompositionEN.LiteratureTypeName = objRow[convzx_Composition.LiteratureTypeName] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureTypeName].ToString().Trim(); //作文类型名
objvzx_CompositionEN.CurrEduClsId = objRow[convzx_Composition.CurrEduClsId] == DBNull.Value ? null : objRow[convzx_Composition.CurrEduClsId].ToString().Trim(); //教学班Id
objvzx_CompositionEN.EduClsName = objRow[convzx_Composition.EduClsName] == DBNull.Value ? null : objRow[convzx_Composition.EduClsName].ToString().Trim(); //教学班名
objvzx_CompositionEN.GroupTextId = objRow[convzx_Composition.GroupTextId].ToString().Trim(); //小组Id
objvzx_CompositionEN.TeaQCount = objRow[convzx_Composition.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.TeaQCount].ToString().Trim()); //教师提问数
objvzx_CompositionEN.TagsCount = objRow[convzx_Composition.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.TagsCount].ToString().Trim()); //论文标注数
objvzx_CompositionEN.SubVCount = objRow[convzx_Composition.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.SubVCount].ToString().Trim()); //论文子观点数
objvzx_CompositionEN.PaperQCount = objRow[convzx_Composition.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_CompositionEN.zxShareId = objRow[convzx_Composition.zxShareId] == DBNull.Value ? null : objRow[convzx_Composition.zxShareId].ToString().Trim(); //分享Id
objvzx_CompositionEN.CreateDate = objRow[convzx_Composition.CreateDate] == DBNull.Value ? null : objRow[convzx_Composition.CreateDate].ToString().Trim(); //建立日期
objvzx_CompositionEN.ExpectedConclusion = objRow[convzx_Composition.ExpectedConclusion] == DBNull.Value ? null : objRow[convzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论
objvzx_CompositionEN.DimensionDataProcess = objRow[convzx_Composition.DimensionDataProcess] == DBNull.Value ? null : objRow[convzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objvzx_CompositionEN.InnovationPoints = objRow[convzx_Composition.InnovationPoints] == DBNull.Value ? null : objRow[convzx_Composition.InnovationPoints].ToString().Trim(); //创新点
objvzx_CompositionEN.ResearchStatus = objRow[convzx_Composition.ResearchStatus] == DBNull.Value ? null : objRow[convzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状
objvzx_CompositionEN.IsPublic = TransNullToBool(objRow[convzx_Composition.IsPublic].ToString().Trim()); //是否公开
objvzx_CompositionEN.UpdUser = objRow[convzx_Composition.UpdUser] == DBNull.Value ? null : objRow[convzx_Composition.UpdUser].ToString().Trim(); //修改人
objvzx_CompositionEN.ResearchDesign = objRow[convzx_Composition.ResearchDesign] == DBNull.Value ? null : objRow[convzx_Composition.ResearchDesign].ToString().Trim(); //研究设计
objvzx_CompositionEN.VersionCount = objRow[convzx_Composition.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.VersionCount].ToString().Trim()); //版本统计
objvzx_CompositionEN.AskQuestion = objRow[convzx_Composition.AskQuestion] == DBNull.Value ? null : objRow[convzx_Composition.AskQuestion].ToString().Trim(); //问题提出
objvzx_CompositionEN.zxPaperStatusId = objRow[convzx_Composition.zxPaperStatusId] == DBNull.Value ? null : objRow[convzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id
objvzx_CompositionEN.PaperTypeId = objRow[convzx_Composition.PaperTypeId] == DBNull.Value ? null : objRow[convzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id
objvzx_CompositionEN.IdCurrEduCls = objRow[convzx_Composition.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_CompositionEN.TeaScore = objRow[convzx_Composition.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Composition.TeaScore].ToString().Trim()); //教师评分
objvzx_CompositionEN.StuScore = objRow[convzx_Composition.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Composition.StuScore].ToString().Trim()); //学生平均分
objvzx_CompositionEN.Score = objRow[convzx_Composition.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Composition.Score].ToString().Trim()); //评分
objvzx_CompositionEN.Pcount = objRow[convzx_Composition.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.Pcount].ToString().Trim()); //读写数
objvzx_CompositionEN.OkCount = objRow[convzx_Composition.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.OkCount].ToString().Trim()); //点赞统计
objvzx_CompositionEN.DownloadCount = objRow[convzx_Composition.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.DownloadCount].ToString().Trim()); //下载数
objvzx_CompositionEN.CollectionCount = objRow[convzx_Composition.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convzx_Composition.CollectionCount].ToString().Trim()); //收藏数量
objvzx_CompositionEN.AttachmentCount = objRow[convzx_Composition.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.AttachmentCount].ToString().Trim()); //附件计数
objvzx_CompositionEN.AppraiseCount = objRow[convzx_Composition.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.AppraiseCount].ToString().Trim()); //评论数
objvzx_CompositionEN.IsSubmit = TransNullToBool(objRow[convzx_Composition.IsSubmit].ToString().Trim()); //是否提交
objvzx_CompositionEN.BrowseNumber = objRow[convzx_Composition.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.BrowseNumber].ToString().Trim()); //浏览量
objvzx_CompositionEN.zxLiteratureTypeId = objRow[convzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id
objvzx_CompositionEN.Checker = objRow[convzx_Composition.Checker] == DBNull.Value ? null : objRow[convzx_Composition.Checker].ToString().Trim(); //审核人
objvzx_CompositionEN.PaperTitle = objRow[convzx_Composition.PaperTitle].ToString().Trim(); //论文标题
objvzx_CompositionEN.PaperName = objRow[convzx_Composition.PaperName] == DBNull.Value ? null : objRow[convzx_Composition.PaperName].ToString().Trim(); //主题名称
objvzx_CompositionEN.PaperContent = objRow[convzx_Composition.PaperContent] == DBNull.Value ? null : objRow[convzx_Composition.PaperContent].ToString().Trim(); //主题内容
objvzx_CompositionEN.Periodical = objRow[convzx_Composition.Periodical] == DBNull.Value ? null : objRow[convzx_Composition.Periodical].ToString().Trim(); //期刊
objvzx_CompositionEN.Author = objRow[convzx_Composition.Author] == DBNull.Value ? null : objRow[convzx_Composition.Author].ToString().Trim(); //作者
objvzx_CompositionEN.ResearchQuestion = objRow[convzx_Composition.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_CompositionEN.UpdDate = objRow[convzx_Composition.UpdDate] == DBNull.Value ? null : objRow[convzx_Composition.UpdDate].ToString().Trim(); //修改日期
objvzx_CompositionEN.Memo = objRow[convzx_Composition.Memo] == DBNull.Value ? null : objRow[convzx_Composition.Memo].ToString().Trim(); //备注
objvzx_CompositionEN.Keyword = objRow[convzx_Composition.Keyword] == DBNull.Value ? null : objRow[convzx_Composition.Keyword].ToString().Trim(); //关键字
objvzx_CompositionEN.LiteratureSources = objRow[convzx_Composition.LiteratureSources] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureSources].ToString().Trim(); //文献来源
objvzx_CompositionEN.LiteratureLink = objRow[convzx_Composition.LiteratureLink] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureLink].ToString().Trim(); //文献链接
objvzx_CompositionEN.UploadfileUrl = objRow[convzx_Composition.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_CompositionEN.IsQuotethesis = TransNullToBool(objRow[convzx_Composition.IsQuotethesis].ToString().Trim()); //是否引用论文
objvzx_CompositionEN.QuoteId = objRow[convzx_Composition.QuoteId] == DBNull.Value ? null : objRow[convzx_Composition.QuoteId].ToString().Trim(); //引用Id
objvzx_CompositionEN.IsChecked = TransNullToBool(objRow[convzx_Composition.IsChecked].ToString().Trim()); //是否检查
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_CompositionDA: GetObjLst)", objException.Message));
}
objvzx_CompositionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_CompositionEN);
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
public List<clsvzx_CompositionEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvzx_CompositionDA:GetObjLstByTabName)", objException.Message));
}
List<clsvzx_CompositionEN> arrObjLst = new List<clsvzx_CompositionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_CompositionDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_CompositionEN objvzx_CompositionEN = new clsvzx_CompositionEN();
try
{
objvzx_CompositionEN.zxPaperId = objRow[convzx_Composition.zxPaperId].ToString().Trim(); //论文Id
objvzx_CompositionEN.LiteratureTypeName = objRow[convzx_Composition.LiteratureTypeName] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureTypeName].ToString().Trim(); //作文类型名
objvzx_CompositionEN.CurrEduClsId = objRow[convzx_Composition.CurrEduClsId] == DBNull.Value ? null : objRow[convzx_Composition.CurrEduClsId].ToString().Trim(); //教学班Id
objvzx_CompositionEN.EduClsName = objRow[convzx_Composition.EduClsName] == DBNull.Value ? null : objRow[convzx_Composition.EduClsName].ToString().Trim(); //教学班名
objvzx_CompositionEN.GroupTextId = objRow[convzx_Composition.GroupTextId].ToString().Trim(); //小组Id
objvzx_CompositionEN.TeaQCount = objRow[convzx_Composition.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.TeaQCount].ToString().Trim()); //教师提问数
objvzx_CompositionEN.TagsCount = objRow[convzx_Composition.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.TagsCount].ToString().Trim()); //论文标注数
objvzx_CompositionEN.SubVCount = objRow[convzx_Composition.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.SubVCount].ToString().Trim()); //论文子观点数
objvzx_CompositionEN.PaperQCount = objRow[convzx_Composition.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_CompositionEN.zxShareId = objRow[convzx_Composition.zxShareId] == DBNull.Value ? null : objRow[convzx_Composition.zxShareId].ToString().Trim(); //分享Id
objvzx_CompositionEN.CreateDate = objRow[convzx_Composition.CreateDate] == DBNull.Value ? null : objRow[convzx_Composition.CreateDate].ToString().Trim(); //建立日期
objvzx_CompositionEN.ExpectedConclusion = objRow[convzx_Composition.ExpectedConclusion] == DBNull.Value ? null : objRow[convzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论
objvzx_CompositionEN.DimensionDataProcess = objRow[convzx_Composition.DimensionDataProcess] == DBNull.Value ? null : objRow[convzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objvzx_CompositionEN.InnovationPoints = objRow[convzx_Composition.InnovationPoints] == DBNull.Value ? null : objRow[convzx_Composition.InnovationPoints].ToString().Trim(); //创新点
objvzx_CompositionEN.ResearchStatus = objRow[convzx_Composition.ResearchStatus] == DBNull.Value ? null : objRow[convzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状
objvzx_CompositionEN.IsPublic = TransNullToBool(objRow[convzx_Composition.IsPublic].ToString().Trim()); //是否公开
objvzx_CompositionEN.UpdUser = objRow[convzx_Composition.UpdUser] == DBNull.Value ? null : objRow[convzx_Composition.UpdUser].ToString().Trim(); //修改人
objvzx_CompositionEN.ResearchDesign = objRow[convzx_Composition.ResearchDesign] == DBNull.Value ? null : objRow[convzx_Composition.ResearchDesign].ToString().Trim(); //研究设计
objvzx_CompositionEN.VersionCount = objRow[convzx_Composition.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.VersionCount].ToString().Trim()); //版本统计
objvzx_CompositionEN.AskQuestion = objRow[convzx_Composition.AskQuestion] == DBNull.Value ? null : objRow[convzx_Composition.AskQuestion].ToString().Trim(); //问题提出
objvzx_CompositionEN.zxPaperStatusId = objRow[convzx_Composition.zxPaperStatusId] == DBNull.Value ? null : objRow[convzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id
objvzx_CompositionEN.PaperTypeId = objRow[convzx_Composition.PaperTypeId] == DBNull.Value ? null : objRow[convzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id
objvzx_CompositionEN.IdCurrEduCls = objRow[convzx_Composition.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_CompositionEN.TeaScore = objRow[convzx_Composition.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Composition.TeaScore].ToString().Trim()); //教师评分
objvzx_CompositionEN.StuScore = objRow[convzx_Composition.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Composition.StuScore].ToString().Trim()); //学生平均分
objvzx_CompositionEN.Score = objRow[convzx_Composition.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Composition.Score].ToString().Trim()); //评分
objvzx_CompositionEN.Pcount = objRow[convzx_Composition.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.Pcount].ToString().Trim()); //读写数
objvzx_CompositionEN.OkCount = objRow[convzx_Composition.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.OkCount].ToString().Trim()); //点赞统计
objvzx_CompositionEN.DownloadCount = objRow[convzx_Composition.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.DownloadCount].ToString().Trim()); //下载数
objvzx_CompositionEN.CollectionCount = objRow[convzx_Composition.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convzx_Composition.CollectionCount].ToString().Trim()); //收藏数量
objvzx_CompositionEN.AttachmentCount = objRow[convzx_Composition.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.AttachmentCount].ToString().Trim()); //附件计数
objvzx_CompositionEN.AppraiseCount = objRow[convzx_Composition.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.AppraiseCount].ToString().Trim()); //评论数
objvzx_CompositionEN.IsSubmit = TransNullToBool(objRow[convzx_Composition.IsSubmit].ToString().Trim()); //是否提交
objvzx_CompositionEN.BrowseNumber = objRow[convzx_Composition.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.BrowseNumber].ToString().Trim()); //浏览量
objvzx_CompositionEN.zxLiteratureTypeId = objRow[convzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id
objvzx_CompositionEN.Checker = objRow[convzx_Composition.Checker] == DBNull.Value ? null : objRow[convzx_Composition.Checker].ToString().Trim(); //审核人
objvzx_CompositionEN.PaperTitle = objRow[convzx_Composition.PaperTitle].ToString().Trim(); //论文标题
objvzx_CompositionEN.PaperName = objRow[convzx_Composition.PaperName] == DBNull.Value ? null : objRow[convzx_Composition.PaperName].ToString().Trim(); //主题名称
objvzx_CompositionEN.PaperContent = objRow[convzx_Composition.PaperContent] == DBNull.Value ? null : objRow[convzx_Composition.PaperContent].ToString().Trim(); //主题内容
objvzx_CompositionEN.Periodical = objRow[convzx_Composition.Periodical] == DBNull.Value ? null : objRow[convzx_Composition.Periodical].ToString().Trim(); //期刊
objvzx_CompositionEN.Author = objRow[convzx_Composition.Author] == DBNull.Value ? null : objRow[convzx_Composition.Author].ToString().Trim(); //作者
objvzx_CompositionEN.ResearchQuestion = objRow[convzx_Composition.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_CompositionEN.UpdDate = objRow[convzx_Composition.UpdDate] == DBNull.Value ? null : objRow[convzx_Composition.UpdDate].ToString().Trim(); //修改日期
objvzx_CompositionEN.Memo = objRow[convzx_Composition.Memo] == DBNull.Value ? null : objRow[convzx_Composition.Memo].ToString().Trim(); //备注
objvzx_CompositionEN.Keyword = objRow[convzx_Composition.Keyword] == DBNull.Value ? null : objRow[convzx_Composition.Keyword].ToString().Trim(); //关键字
objvzx_CompositionEN.LiteratureSources = objRow[convzx_Composition.LiteratureSources] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureSources].ToString().Trim(); //文献来源
objvzx_CompositionEN.LiteratureLink = objRow[convzx_Composition.LiteratureLink] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureLink].ToString().Trim(); //文献链接
objvzx_CompositionEN.UploadfileUrl = objRow[convzx_Composition.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_CompositionEN.IsQuotethesis = TransNullToBool(objRow[convzx_Composition.IsQuotethesis].ToString().Trim()); //是否引用论文
objvzx_CompositionEN.QuoteId = objRow[convzx_Composition.QuoteId] == DBNull.Value ? null : objRow[convzx_Composition.QuoteId].ToString().Trim(); //引用Id
objvzx_CompositionEN.IsChecked = TransNullToBool(objRow[convzx_Composition.IsChecked].ToString().Trim()); //是否检查
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_CompositionDA: GetObjLst)", objException.Message));
}
objvzx_CompositionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_CompositionEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvzx_CompositionEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvzx_Composition(ref clsvzx_CompositionEN objvzx_CompositionEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_CompositionDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Composition where zxPaperId = " + "'"+ objvzx_CompositionEN.zxPaperId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvzx_CompositionEN.zxPaperId = objDT.Rows[0][convzx_Composition.zxPaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvzx_CompositionEN.LiteratureTypeName = objDT.Rows[0][convzx_Composition.LiteratureTypeName].ToString().Trim(); //作文类型名(字段类型:varchar,字段长度:100,是否可空:True)
 objvzx_CompositionEN.CurrEduClsId = objDT.Rows[0][convzx_Composition.CurrEduClsId].ToString().Trim(); //教学班Id(字段类型:varchar,字段长度:15,是否可空:True)
 objvzx_CompositionEN.EduClsName = objDT.Rows[0][convzx_Composition.EduClsName].ToString().Trim(); //教学班名(字段类型:varchar,字段长度:100,是否可空:False)
 objvzx_CompositionEN.GroupTextId = objDT.Rows[0][convzx_Composition.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_CompositionEN.TeaQCount = TransNullToInt(objDT.Rows[0][convzx_Composition.TeaQCount].ToString().Trim()); //教师提问数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_CompositionEN.TagsCount = TransNullToInt(objDT.Rows[0][convzx_Composition.TagsCount].ToString().Trim()); //论文标注数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_CompositionEN.SubVCount = TransNullToInt(objDT.Rows[0][convzx_Composition.SubVCount].ToString().Trim()); //论文子观点数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_CompositionEN.PaperQCount = TransNullToInt(objDT.Rows[0][convzx_Composition.PaperQCount].ToString().Trim()); //论文答疑数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_CompositionEN.zxShareId = objDT.Rows[0][convzx_Composition.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_CompositionEN.CreateDate = objDT.Rows[0][convzx_Composition.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_CompositionEN.ExpectedConclusion = objDT.Rows[0][convzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论(字段类型:varchar,字段长度:5000,是否可空:True)
 objvzx_CompositionEN.DimensionDataProcess = objDT.Rows[0][convzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度(字段类型:varchar,字段长度:5000,是否可空:True)
 objvzx_CompositionEN.InnovationPoints = objDT.Rows[0][convzx_Composition.InnovationPoints].ToString().Trim(); //创新点(字段类型:varchar,字段长度:5000,是否可空:True)
 objvzx_CompositionEN.ResearchStatus = objDT.Rows[0][convzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状(字段类型:varchar,字段长度:5000,是否可空:True)
 objvzx_CompositionEN.IsPublic = TransNullToBool(objDT.Rows[0][convzx_Composition.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_CompositionEN.UpdUser = objDT.Rows[0][convzx_Composition.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_CompositionEN.ResearchDesign = objDT.Rows[0][convzx_Composition.ResearchDesign].ToString().Trim(); //研究设计(字段类型:varchar,字段长度:5000,是否可空:True)
 objvzx_CompositionEN.VersionCount = TransNullToInt(objDT.Rows[0][convzx_Composition.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvzx_CompositionEN.AskQuestion = objDT.Rows[0][convzx_Composition.AskQuestion].ToString().Trim(); //问题提出(字段类型:varchar,字段长度:5000,是否可空:True)
 objvzx_CompositionEN.zxPaperStatusId = objDT.Rows[0][convzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_CompositionEN.PaperTypeId = objDT.Rows[0][convzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvzx_CompositionEN.IdCurrEduCls = objDT.Rows[0][convzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_CompositionEN.TeaScore = TransNullToFloat(objDT.Rows[0][convzx_Composition.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_CompositionEN.StuScore = TransNullToFloat(objDT.Rows[0][convzx_Composition.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_CompositionEN.Score = TransNullToFloat(objDT.Rows[0][convzx_Composition.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_CompositionEN.Pcount = TransNullToInt(objDT.Rows[0][convzx_Composition.Pcount].ToString().Trim()); //读写数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_CompositionEN.OkCount = TransNullToInt(objDT.Rows[0][convzx_Composition.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvzx_CompositionEN.DownloadCount = TransNullToInt(objDT.Rows[0][convzx_Composition.DownloadCount].ToString().Trim()); //下载数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_CompositionEN.CollectionCount = TransNullToInt(objDT.Rows[0][convzx_Composition.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvzx_CompositionEN.AttachmentCount = TransNullToInt(objDT.Rows[0][convzx_Composition.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_CompositionEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convzx_Composition.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_CompositionEN.IsSubmit = TransNullToBool(objDT.Rows[0][convzx_Composition.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_CompositionEN.BrowseNumber = TransNullToInt(objDT.Rows[0][convzx_Composition.BrowseNumber].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvzx_CompositionEN.zxLiteratureTypeId = objDT.Rows[0][convzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_CompositionEN.Checker = objDT.Rows[0][convzx_Composition.Checker].ToString().Trim(); //审核人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_CompositionEN.PaperTitle = objDT.Rows[0][convzx_Composition.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvzx_CompositionEN.PaperName = objDT.Rows[0][convzx_Composition.PaperName].ToString().Trim(); //主题名称(字段类型:varchar,字段长度:500,是否可空:False)
 objvzx_CompositionEN.PaperContent = objDT.Rows[0][convzx_Composition.PaperContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvzx_CompositionEN.Periodical = objDT.Rows[0][convzx_Composition.Periodical].ToString().Trim(); //期刊(字段类型:varchar,字段长度:100,是否可空:True)
 objvzx_CompositionEN.Author = objDT.Rows[0][convzx_Composition.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvzx_CompositionEN.ResearchQuestion = objDT.Rows[0][convzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_CompositionEN.UpdDate = objDT.Rows[0][convzx_Composition.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_CompositionEN.Memo = objDT.Rows[0][convzx_Composition.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_CompositionEN.Keyword = objDT.Rows[0][convzx_Composition.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_CompositionEN.LiteratureSources = objDT.Rows[0][convzx_Composition.LiteratureSources].ToString().Trim(); //文献来源(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_CompositionEN.LiteratureLink = objDT.Rows[0][convzx_Composition.LiteratureLink].ToString().Trim(); //文献链接(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_CompositionEN.UploadfileUrl = objDT.Rows[0][convzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_CompositionEN.IsQuotethesis = TransNullToBool(objDT.Rows[0][convzx_Composition.IsQuotethesis].ToString().Trim()); //是否引用论文(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_CompositionEN.QuoteId = objDT.Rows[0][convzx_Composition.QuoteId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objvzx_CompositionEN.IsChecked = TransNullToBool(objDT.Rows[0][convzx_Composition.IsChecked].ToString().Trim()); //是否检查(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvzx_CompositionDA: Getvzx_Composition)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strzxPaperId">表关键字</param>
 /// <returns>表对象</returns>
public clsvzx_CompositionEN GetObjByzxPaperId(string strzxPaperId)
{
CheckPrimaryKey(strzxPaperId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_CompositionDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Composition where zxPaperId = " + "'"+ strzxPaperId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvzx_CompositionEN objvzx_CompositionEN = new clsvzx_CompositionEN();
try
{
 objvzx_CompositionEN.zxPaperId = objRow[convzx_Composition.zxPaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvzx_CompositionEN.LiteratureTypeName = objRow[convzx_Composition.LiteratureTypeName] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureTypeName].ToString().Trim(); //作文类型名(字段类型:varchar,字段长度:100,是否可空:True)
 objvzx_CompositionEN.CurrEduClsId = objRow[convzx_Composition.CurrEduClsId] == DBNull.Value ? null : objRow[convzx_Composition.CurrEduClsId].ToString().Trim(); //教学班Id(字段类型:varchar,字段长度:15,是否可空:True)
 objvzx_CompositionEN.EduClsName = objRow[convzx_Composition.EduClsName] == DBNull.Value ? null : objRow[convzx_Composition.EduClsName].ToString().Trim(); //教学班名(字段类型:varchar,字段长度:100,是否可空:False)
 objvzx_CompositionEN.GroupTextId = objRow[convzx_Composition.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_CompositionEN.TeaQCount = objRow[convzx_Composition.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.TeaQCount].ToString().Trim()); //教师提问数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_CompositionEN.TagsCount = objRow[convzx_Composition.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.TagsCount].ToString().Trim()); //论文标注数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_CompositionEN.SubVCount = objRow[convzx_Composition.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.SubVCount].ToString().Trim()); //论文子观点数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_CompositionEN.PaperQCount = objRow[convzx_Composition.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.PaperQCount].ToString().Trim()); //论文答疑数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_CompositionEN.zxShareId = objRow[convzx_Composition.zxShareId] == DBNull.Value ? null : objRow[convzx_Composition.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_CompositionEN.CreateDate = objRow[convzx_Composition.CreateDate] == DBNull.Value ? null : objRow[convzx_Composition.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_CompositionEN.ExpectedConclusion = objRow[convzx_Composition.ExpectedConclusion] == DBNull.Value ? null : objRow[convzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论(字段类型:varchar,字段长度:5000,是否可空:True)
 objvzx_CompositionEN.DimensionDataProcess = objRow[convzx_Composition.DimensionDataProcess] == DBNull.Value ? null : objRow[convzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度(字段类型:varchar,字段长度:5000,是否可空:True)
 objvzx_CompositionEN.InnovationPoints = objRow[convzx_Composition.InnovationPoints] == DBNull.Value ? null : objRow[convzx_Composition.InnovationPoints].ToString().Trim(); //创新点(字段类型:varchar,字段长度:5000,是否可空:True)
 objvzx_CompositionEN.ResearchStatus = objRow[convzx_Composition.ResearchStatus] == DBNull.Value ? null : objRow[convzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状(字段类型:varchar,字段长度:5000,是否可空:True)
 objvzx_CompositionEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_CompositionEN.UpdUser = objRow[convzx_Composition.UpdUser] == DBNull.Value ? null : objRow[convzx_Composition.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_CompositionEN.ResearchDesign = objRow[convzx_Composition.ResearchDesign] == DBNull.Value ? null : objRow[convzx_Composition.ResearchDesign].ToString().Trim(); //研究设计(字段类型:varchar,字段长度:5000,是否可空:True)
 objvzx_CompositionEN.VersionCount = objRow[convzx_Composition.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvzx_CompositionEN.AskQuestion = objRow[convzx_Composition.AskQuestion] == DBNull.Value ? null : objRow[convzx_Composition.AskQuestion].ToString().Trim(); //问题提出(字段类型:varchar,字段长度:5000,是否可空:True)
 objvzx_CompositionEN.zxPaperStatusId = objRow[convzx_Composition.zxPaperStatusId] == DBNull.Value ? null : objRow[convzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_CompositionEN.PaperTypeId = objRow[convzx_Composition.PaperTypeId] == DBNull.Value ? null : objRow[convzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvzx_CompositionEN.IdCurrEduCls = objRow[convzx_Composition.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_CompositionEN.TeaScore = objRow[convzx_Composition.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_CompositionEN.StuScore = objRow[convzx_Composition.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_CompositionEN.Score = objRow[convzx_Composition.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Composition.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_CompositionEN.Pcount = objRow[convzx_Composition.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.Pcount].ToString().Trim()); //读写数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_CompositionEN.OkCount = objRow[convzx_Composition.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvzx_CompositionEN.DownloadCount = objRow[convzx_Composition.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.DownloadCount].ToString().Trim()); //下载数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_CompositionEN.CollectionCount = objRow[convzx_Composition.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvzx_CompositionEN.AttachmentCount = objRow[convzx_Composition.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_CompositionEN.AppraiseCount = objRow[convzx_Composition.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_CompositionEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_CompositionEN.BrowseNumber = objRow[convzx_Composition.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Composition.BrowseNumber].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvzx_CompositionEN.zxLiteratureTypeId = objRow[convzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_CompositionEN.Checker = objRow[convzx_Composition.Checker] == DBNull.Value ? null : objRow[convzx_Composition.Checker].ToString().Trim(); //审核人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_CompositionEN.PaperTitle = objRow[convzx_Composition.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvzx_CompositionEN.PaperName = objRow[convzx_Composition.PaperName] == DBNull.Value ? null : objRow[convzx_Composition.PaperName].ToString().Trim(); //主题名称(字段类型:varchar,字段长度:500,是否可空:False)
 objvzx_CompositionEN.PaperContent = objRow[convzx_Composition.PaperContent] == DBNull.Value ? null : objRow[convzx_Composition.PaperContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvzx_CompositionEN.Periodical = objRow[convzx_Composition.Periodical] == DBNull.Value ? null : objRow[convzx_Composition.Periodical].ToString().Trim(); //期刊(字段类型:varchar,字段长度:100,是否可空:True)
 objvzx_CompositionEN.Author = objRow[convzx_Composition.Author] == DBNull.Value ? null : objRow[convzx_Composition.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvzx_CompositionEN.ResearchQuestion = objRow[convzx_Composition.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_CompositionEN.UpdDate = objRow[convzx_Composition.UpdDate] == DBNull.Value ? null : objRow[convzx_Composition.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_CompositionEN.Memo = objRow[convzx_Composition.Memo] == DBNull.Value ? null : objRow[convzx_Composition.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_CompositionEN.Keyword = objRow[convzx_Composition.Keyword] == DBNull.Value ? null : objRow[convzx_Composition.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_CompositionEN.LiteratureSources = objRow[convzx_Composition.LiteratureSources] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureSources].ToString().Trim(); //文献来源(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_CompositionEN.LiteratureLink = objRow[convzx_Composition.LiteratureLink] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureLink].ToString().Trim(); //文献链接(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_CompositionEN.UploadfileUrl = objRow[convzx_Composition.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_CompositionEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsQuotethesis].ToString().Trim()); //是否引用论文(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_CompositionEN.QuoteId = objRow[convzx_Composition.QuoteId] == DBNull.Value ? null : objRow[convzx_Composition.QuoteId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objvzx_CompositionEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convzx_Composition.IsChecked].ToString().Trim()); //是否检查(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvzx_CompositionDA: GetObjByzxPaperId)", objException.Message));
}
return objvzx_CompositionEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvzx_CompositionEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvzx_CompositionDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_CompositionDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Composition where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvzx_CompositionEN objvzx_CompositionEN = new clsvzx_CompositionEN()
{
zxPaperId = objRow[convzx_Composition.zxPaperId].ToString().Trim(), //论文Id
LiteratureTypeName = objRow[convzx_Composition.LiteratureTypeName] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureTypeName].ToString().Trim(), //作文类型名
CurrEduClsId = objRow[convzx_Composition.CurrEduClsId] == DBNull.Value ? null : objRow[convzx_Composition.CurrEduClsId].ToString().Trim(), //教学班Id
EduClsName = objRow[convzx_Composition.EduClsName] == DBNull.Value ? null : objRow[convzx_Composition.EduClsName].ToString().Trim(), //教学班名
GroupTextId = objRow[convzx_Composition.GroupTextId].ToString().Trim(), //小组Id
TeaQCount = objRow[convzx_Composition.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.TeaQCount].ToString().Trim()), //教师提问数
TagsCount = objRow[convzx_Composition.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.TagsCount].ToString().Trim()), //论文标注数
SubVCount = objRow[convzx_Composition.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.SubVCount].ToString().Trim()), //论文子观点数
PaperQCount = objRow[convzx_Composition.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.PaperQCount].ToString().Trim()), //论文答疑数
zxShareId = objRow[convzx_Composition.zxShareId] == DBNull.Value ? null : objRow[convzx_Composition.zxShareId].ToString().Trim(), //分享Id
CreateDate = objRow[convzx_Composition.CreateDate] == DBNull.Value ? null : objRow[convzx_Composition.CreateDate].ToString().Trim(), //建立日期
ExpectedConclusion = objRow[convzx_Composition.ExpectedConclusion] == DBNull.Value ? null : objRow[convzx_Composition.ExpectedConclusion].ToString().Trim(), //预期结论
DimensionDataProcess = objRow[convzx_Composition.DimensionDataProcess] == DBNull.Value ? null : objRow[convzx_Composition.DimensionDataProcess].ToString().Trim(), //数据处理的维度
InnovationPoints = objRow[convzx_Composition.InnovationPoints] == DBNull.Value ? null : objRow[convzx_Composition.InnovationPoints].ToString().Trim(), //创新点
ResearchStatus = objRow[convzx_Composition.ResearchStatus] == DBNull.Value ? null : objRow[convzx_Composition.ResearchStatus].ToString().Trim(), //目前研究的现状
IsPublic = TransNullToBool(objRow[convzx_Composition.IsPublic].ToString().Trim()), //是否公开
UpdUser = objRow[convzx_Composition.UpdUser] == DBNull.Value ? null : objRow[convzx_Composition.UpdUser].ToString().Trim(), //修改人
ResearchDesign = objRow[convzx_Composition.ResearchDesign] == DBNull.Value ? null : objRow[convzx_Composition.ResearchDesign].ToString().Trim(), //研究设计
VersionCount = objRow[convzx_Composition.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.VersionCount].ToString().Trim()), //版本统计
AskQuestion = objRow[convzx_Composition.AskQuestion] == DBNull.Value ? null : objRow[convzx_Composition.AskQuestion].ToString().Trim(), //问题提出
zxPaperStatusId = objRow[convzx_Composition.zxPaperStatusId] == DBNull.Value ? null : objRow[convzx_Composition.zxPaperStatusId].ToString().Trim(), //论文状态Id
PaperTypeId = objRow[convzx_Composition.PaperTypeId] == DBNull.Value ? null : objRow[convzx_Composition.PaperTypeId].ToString().Trim(), //论文类型Id
IdCurrEduCls = objRow[convzx_Composition.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Composition.IdCurrEduCls].ToString().Trim(), //教学班流水号
TeaScore = objRow[convzx_Composition.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Composition.TeaScore].ToString().Trim()), //教师评分
StuScore = objRow[convzx_Composition.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Composition.StuScore].ToString().Trim()), //学生平均分
Score = objRow[convzx_Composition.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Composition.Score].ToString().Trim()), //评分
Pcount = objRow[convzx_Composition.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.Pcount].ToString().Trim()), //读写数
OkCount = objRow[convzx_Composition.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.OkCount].ToString().Trim()), //点赞统计
DownloadCount = objRow[convzx_Composition.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.DownloadCount].ToString().Trim()), //下载数
CollectionCount = objRow[convzx_Composition.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convzx_Composition.CollectionCount].ToString().Trim()), //收藏数量
AttachmentCount = objRow[convzx_Composition.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.AttachmentCount].ToString().Trim()), //附件计数
AppraiseCount = objRow[convzx_Composition.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.AppraiseCount].ToString().Trim()), //评论数
IsSubmit = TransNullToBool(objRow[convzx_Composition.IsSubmit].ToString().Trim()), //是否提交
BrowseNumber = objRow[convzx_Composition.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.BrowseNumber].ToString().Trim()), //浏览量
zxLiteratureTypeId = objRow[convzx_Composition.zxLiteratureTypeId].ToString().Trim(), //作文类型Id
Checker = objRow[convzx_Composition.Checker] == DBNull.Value ? null : objRow[convzx_Composition.Checker].ToString().Trim(), //审核人
PaperTitle = objRow[convzx_Composition.PaperTitle].ToString().Trim(), //论文标题
PaperName = objRow[convzx_Composition.PaperName] == DBNull.Value ? null : objRow[convzx_Composition.PaperName].ToString().Trim(), //主题名称
PaperContent = objRow[convzx_Composition.PaperContent] == DBNull.Value ? null : objRow[convzx_Composition.PaperContent].ToString().Trim(), //主题内容
Periodical = objRow[convzx_Composition.Periodical] == DBNull.Value ? null : objRow[convzx_Composition.Periodical].ToString().Trim(), //期刊
Author = objRow[convzx_Composition.Author] == DBNull.Value ? null : objRow[convzx_Composition.Author].ToString().Trim(), //作者
ResearchQuestion = objRow[convzx_Composition.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Composition.ResearchQuestion].ToString().Trim(), //研究问题
UpdDate = objRow[convzx_Composition.UpdDate] == DBNull.Value ? null : objRow[convzx_Composition.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convzx_Composition.Memo] == DBNull.Value ? null : objRow[convzx_Composition.Memo].ToString().Trim(), //备注
Keyword = objRow[convzx_Composition.Keyword] == DBNull.Value ? null : objRow[convzx_Composition.Keyword].ToString().Trim(), //关键字
LiteratureSources = objRow[convzx_Composition.LiteratureSources] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureSources].ToString().Trim(), //文献来源
LiteratureLink = objRow[convzx_Composition.LiteratureLink] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureLink].ToString().Trim(), //文献链接
UploadfileUrl = objRow[convzx_Composition.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_Composition.UploadfileUrl].ToString().Trim(), //文件地址
IsQuotethesis = TransNullToBool(objRow[convzx_Composition.IsQuotethesis].ToString().Trim()), //是否引用论文
QuoteId = objRow[convzx_Composition.QuoteId] == DBNull.Value ? null : objRow[convzx_Composition.QuoteId].ToString().Trim(), //引用Id
IsChecked = TransNullToBool(objRow[convzx_Composition.IsChecked].ToString().Trim()) //是否检查
};
objvzx_CompositionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_CompositionEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvzx_CompositionDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvzx_CompositionEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_CompositionEN objvzx_CompositionEN = new clsvzx_CompositionEN();
try
{
objvzx_CompositionEN.zxPaperId = objRow[convzx_Composition.zxPaperId].ToString().Trim(); //论文Id
objvzx_CompositionEN.LiteratureTypeName = objRow[convzx_Composition.LiteratureTypeName] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureTypeName].ToString().Trim(); //作文类型名
objvzx_CompositionEN.CurrEduClsId = objRow[convzx_Composition.CurrEduClsId] == DBNull.Value ? null : objRow[convzx_Composition.CurrEduClsId].ToString().Trim(); //教学班Id
objvzx_CompositionEN.EduClsName = objRow[convzx_Composition.EduClsName] == DBNull.Value ? null : objRow[convzx_Composition.EduClsName].ToString().Trim(); //教学班名
objvzx_CompositionEN.GroupTextId = objRow[convzx_Composition.GroupTextId].ToString().Trim(); //小组Id
objvzx_CompositionEN.TeaQCount = objRow[convzx_Composition.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.TeaQCount].ToString().Trim()); //教师提问数
objvzx_CompositionEN.TagsCount = objRow[convzx_Composition.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.TagsCount].ToString().Trim()); //论文标注数
objvzx_CompositionEN.SubVCount = objRow[convzx_Composition.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.SubVCount].ToString().Trim()); //论文子观点数
objvzx_CompositionEN.PaperQCount = objRow[convzx_Composition.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_CompositionEN.zxShareId = objRow[convzx_Composition.zxShareId] == DBNull.Value ? null : objRow[convzx_Composition.zxShareId].ToString().Trim(); //分享Id
objvzx_CompositionEN.CreateDate = objRow[convzx_Composition.CreateDate] == DBNull.Value ? null : objRow[convzx_Composition.CreateDate].ToString().Trim(); //建立日期
objvzx_CompositionEN.ExpectedConclusion = objRow[convzx_Composition.ExpectedConclusion] == DBNull.Value ? null : objRow[convzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论
objvzx_CompositionEN.DimensionDataProcess = objRow[convzx_Composition.DimensionDataProcess] == DBNull.Value ? null : objRow[convzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objvzx_CompositionEN.InnovationPoints = objRow[convzx_Composition.InnovationPoints] == DBNull.Value ? null : objRow[convzx_Composition.InnovationPoints].ToString().Trim(); //创新点
objvzx_CompositionEN.ResearchStatus = objRow[convzx_Composition.ResearchStatus] == DBNull.Value ? null : objRow[convzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状
objvzx_CompositionEN.IsPublic = TransNullToBool(objRow[convzx_Composition.IsPublic].ToString().Trim()); //是否公开
objvzx_CompositionEN.UpdUser = objRow[convzx_Composition.UpdUser] == DBNull.Value ? null : objRow[convzx_Composition.UpdUser].ToString().Trim(); //修改人
objvzx_CompositionEN.ResearchDesign = objRow[convzx_Composition.ResearchDesign] == DBNull.Value ? null : objRow[convzx_Composition.ResearchDesign].ToString().Trim(); //研究设计
objvzx_CompositionEN.VersionCount = objRow[convzx_Composition.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.VersionCount].ToString().Trim()); //版本统计
objvzx_CompositionEN.AskQuestion = objRow[convzx_Composition.AskQuestion] == DBNull.Value ? null : objRow[convzx_Composition.AskQuestion].ToString().Trim(); //问题提出
objvzx_CompositionEN.zxPaperStatusId = objRow[convzx_Composition.zxPaperStatusId] == DBNull.Value ? null : objRow[convzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id
objvzx_CompositionEN.PaperTypeId = objRow[convzx_Composition.PaperTypeId] == DBNull.Value ? null : objRow[convzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id
objvzx_CompositionEN.IdCurrEduCls = objRow[convzx_Composition.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_CompositionEN.TeaScore = objRow[convzx_Composition.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Composition.TeaScore].ToString().Trim()); //教师评分
objvzx_CompositionEN.StuScore = objRow[convzx_Composition.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Composition.StuScore].ToString().Trim()); //学生平均分
objvzx_CompositionEN.Score = objRow[convzx_Composition.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Composition.Score].ToString().Trim()); //评分
objvzx_CompositionEN.Pcount = objRow[convzx_Composition.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.Pcount].ToString().Trim()); //读写数
objvzx_CompositionEN.OkCount = objRow[convzx_Composition.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.OkCount].ToString().Trim()); //点赞统计
objvzx_CompositionEN.DownloadCount = objRow[convzx_Composition.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.DownloadCount].ToString().Trim()); //下载数
objvzx_CompositionEN.CollectionCount = objRow[convzx_Composition.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convzx_Composition.CollectionCount].ToString().Trim()); //收藏数量
objvzx_CompositionEN.AttachmentCount = objRow[convzx_Composition.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.AttachmentCount].ToString().Trim()); //附件计数
objvzx_CompositionEN.AppraiseCount = objRow[convzx_Composition.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.AppraiseCount].ToString().Trim()); //评论数
objvzx_CompositionEN.IsSubmit = TransNullToBool(objRow[convzx_Composition.IsSubmit].ToString().Trim()); //是否提交
objvzx_CompositionEN.BrowseNumber = objRow[convzx_Composition.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.BrowseNumber].ToString().Trim()); //浏览量
objvzx_CompositionEN.zxLiteratureTypeId = objRow[convzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id
objvzx_CompositionEN.Checker = objRow[convzx_Composition.Checker] == DBNull.Value ? null : objRow[convzx_Composition.Checker].ToString().Trim(); //审核人
objvzx_CompositionEN.PaperTitle = objRow[convzx_Composition.PaperTitle].ToString().Trim(); //论文标题
objvzx_CompositionEN.PaperName = objRow[convzx_Composition.PaperName] == DBNull.Value ? null : objRow[convzx_Composition.PaperName].ToString().Trim(); //主题名称
objvzx_CompositionEN.PaperContent = objRow[convzx_Composition.PaperContent] == DBNull.Value ? null : objRow[convzx_Composition.PaperContent].ToString().Trim(); //主题内容
objvzx_CompositionEN.Periodical = objRow[convzx_Composition.Periodical] == DBNull.Value ? null : objRow[convzx_Composition.Periodical].ToString().Trim(); //期刊
objvzx_CompositionEN.Author = objRow[convzx_Composition.Author] == DBNull.Value ? null : objRow[convzx_Composition.Author].ToString().Trim(); //作者
objvzx_CompositionEN.ResearchQuestion = objRow[convzx_Composition.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_CompositionEN.UpdDate = objRow[convzx_Composition.UpdDate] == DBNull.Value ? null : objRow[convzx_Composition.UpdDate].ToString().Trim(); //修改日期
objvzx_CompositionEN.Memo = objRow[convzx_Composition.Memo] == DBNull.Value ? null : objRow[convzx_Composition.Memo].ToString().Trim(); //备注
objvzx_CompositionEN.Keyword = objRow[convzx_Composition.Keyword] == DBNull.Value ? null : objRow[convzx_Composition.Keyword].ToString().Trim(); //关键字
objvzx_CompositionEN.LiteratureSources = objRow[convzx_Composition.LiteratureSources] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureSources].ToString().Trim(); //文献来源
objvzx_CompositionEN.LiteratureLink = objRow[convzx_Composition.LiteratureLink] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureLink].ToString().Trim(); //文献链接
objvzx_CompositionEN.UploadfileUrl = objRow[convzx_Composition.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_CompositionEN.IsQuotethesis = TransNullToBool(objRow[convzx_Composition.IsQuotethesis].ToString().Trim()); //是否引用论文
objvzx_CompositionEN.QuoteId = objRow[convzx_Composition.QuoteId] == DBNull.Value ? null : objRow[convzx_Composition.QuoteId].ToString().Trim(); //引用Id
objvzx_CompositionEN.IsChecked = TransNullToBool(objRow[convzx_Composition.IsChecked].ToString().Trim()); //是否检查
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvzx_CompositionDA: GetObjByDataRowvzx_Composition)", objException.Message));
}
objvzx_CompositionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_CompositionEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvzx_CompositionEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_CompositionEN objvzx_CompositionEN = new clsvzx_CompositionEN();
try
{
objvzx_CompositionEN.zxPaperId = objRow[convzx_Composition.zxPaperId].ToString().Trim(); //论文Id
objvzx_CompositionEN.LiteratureTypeName = objRow[convzx_Composition.LiteratureTypeName] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureTypeName].ToString().Trim(); //作文类型名
objvzx_CompositionEN.CurrEduClsId = objRow[convzx_Composition.CurrEduClsId] == DBNull.Value ? null : objRow[convzx_Composition.CurrEduClsId].ToString().Trim(); //教学班Id
objvzx_CompositionEN.EduClsName = objRow[convzx_Composition.EduClsName] == DBNull.Value ? null : objRow[convzx_Composition.EduClsName].ToString().Trim(); //教学班名
objvzx_CompositionEN.GroupTextId = objRow[convzx_Composition.GroupTextId].ToString().Trim(); //小组Id
objvzx_CompositionEN.TeaQCount = objRow[convzx_Composition.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.TeaQCount].ToString().Trim()); //教师提问数
objvzx_CompositionEN.TagsCount = objRow[convzx_Composition.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.TagsCount].ToString().Trim()); //论文标注数
objvzx_CompositionEN.SubVCount = objRow[convzx_Composition.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.SubVCount].ToString().Trim()); //论文子观点数
objvzx_CompositionEN.PaperQCount = objRow[convzx_Composition.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_CompositionEN.zxShareId = objRow[convzx_Composition.zxShareId] == DBNull.Value ? null : objRow[convzx_Composition.zxShareId].ToString().Trim(); //分享Id
objvzx_CompositionEN.CreateDate = objRow[convzx_Composition.CreateDate] == DBNull.Value ? null : objRow[convzx_Composition.CreateDate].ToString().Trim(); //建立日期
objvzx_CompositionEN.ExpectedConclusion = objRow[convzx_Composition.ExpectedConclusion] == DBNull.Value ? null : objRow[convzx_Composition.ExpectedConclusion].ToString().Trim(); //预期结论
objvzx_CompositionEN.DimensionDataProcess = objRow[convzx_Composition.DimensionDataProcess] == DBNull.Value ? null : objRow[convzx_Composition.DimensionDataProcess].ToString().Trim(); //数据处理的维度
objvzx_CompositionEN.InnovationPoints = objRow[convzx_Composition.InnovationPoints] == DBNull.Value ? null : objRow[convzx_Composition.InnovationPoints].ToString().Trim(); //创新点
objvzx_CompositionEN.ResearchStatus = objRow[convzx_Composition.ResearchStatus] == DBNull.Value ? null : objRow[convzx_Composition.ResearchStatus].ToString().Trim(); //目前研究的现状
objvzx_CompositionEN.IsPublic = TransNullToBool(objRow[convzx_Composition.IsPublic].ToString().Trim()); //是否公开
objvzx_CompositionEN.UpdUser = objRow[convzx_Composition.UpdUser] == DBNull.Value ? null : objRow[convzx_Composition.UpdUser].ToString().Trim(); //修改人
objvzx_CompositionEN.ResearchDesign = objRow[convzx_Composition.ResearchDesign] == DBNull.Value ? null : objRow[convzx_Composition.ResearchDesign].ToString().Trim(); //研究设计
objvzx_CompositionEN.VersionCount = objRow[convzx_Composition.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.VersionCount].ToString().Trim()); //版本统计
objvzx_CompositionEN.AskQuestion = objRow[convzx_Composition.AskQuestion] == DBNull.Value ? null : objRow[convzx_Composition.AskQuestion].ToString().Trim(); //问题提出
objvzx_CompositionEN.zxPaperStatusId = objRow[convzx_Composition.zxPaperStatusId] == DBNull.Value ? null : objRow[convzx_Composition.zxPaperStatusId].ToString().Trim(); //论文状态Id
objvzx_CompositionEN.PaperTypeId = objRow[convzx_Composition.PaperTypeId] == DBNull.Value ? null : objRow[convzx_Composition.PaperTypeId].ToString().Trim(); //论文类型Id
objvzx_CompositionEN.IdCurrEduCls = objRow[convzx_Composition.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Composition.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_CompositionEN.TeaScore = objRow[convzx_Composition.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Composition.TeaScore].ToString().Trim()); //教师评分
objvzx_CompositionEN.StuScore = objRow[convzx_Composition.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Composition.StuScore].ToString().Trim()); //学生平均分
objvzx_CompositionEN.Score = objRow[convzx_Composition.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Composition.Score].ToString().Trim()); //评分
objvzx_CompositionEN.Pcount = objRow[convzx_Composition.Pcount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.Pcount].ToString().Trim()); //读写数
objvzx_CompositionEN.OkCount = objRow[convzx_Composition.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.OkCount].ToString().Trim()); //点赞统计
objvzx_CompositionEN.DownloadCount = objRow[convzx_Composition.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.DownloadCount].ToString().Trim()); //下载数
objvzx_CompositionEN.CollectionCount = objRow[convzx_Composition.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convzx_Composition.CollectionCount].ToString().Trim()); //收藏数量
objvzx_CompositionEN.AttachmentCount = objRow[convzx_Composition.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.AttachmentCount].ToString().Trim()); //附件计数
objvzx_CompositionEN.AppraiseCount = objRow[convzx_Composition.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.AppraiseCount].ToString().Trim()); //评论数
objvzx_CompositionEN.IsSubmit = TransNullToBool(objRow[convzx_Composition.IsSubmit].ToString().Trim()); //是否提交
objvzx_CompositionEN.BrowseNumber = objRow[convzx_Composition.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Composition.BrowseNumber].ToString().Trim()); //浏览量
objvzx_CompositionEN.zxLiteratureTypeId = objRow[convzx_Composition.zxLiteratureTypeId].ToString().Trim(); //作文类型Id
objvzx_CompositionEN.Checker = objRow[convzx_Composition.Checker] == DBNull.Value ? null : objRow[convzx_Composition.Checker].ToString().Trim(); //审核人
objvzx_CompositionEN.PaperTitle = objRow[convzx_Composition.PaperTitle].ToString().Trim(); //论文标题
objvzx_CompositionEN.PaperName = objRow[convzx_Composition.PaperName] == DBNull.Value ? null : objRow[convzx_Composition.PaperName].ToString().Trim(); //主题名称
objvzx_CompositionEN.PaperContent = objRow[convzx_Composition.PaperContent] == DBNull.Value ? null : objRow[convzx_Composition.PaperContent].ToString().Trim(); //主题内容
objvzx_CompositionEN.Periodical = objRow[convzx_Composition.Periodical] == DBNull.Value ? null : objRow[convzx_Composition.Periodical].ToString().Trim(); //期刊
objvzx_CompositionEN.Author = objRow[convzx_Composition.Author] == DBNull.Value ? null : objRow[convzx_Composition.Author].ToString().Trim(); //作者
objvzx_CompositionEN.ResearchQuestion = objRow[convzx_Composition.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Composition.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_CompositionEN.UpdDate = objRow[convzx_Composition.UpdDate] == DBNull.Value ? null : objRow[convzx_Composition.UpdDate].ToString().Trim(); //修改日期
objvzx_CompositionEN.Memo = objRow[convzx_Composition.Memo] == DBNull.Value ? null : objRow[convzx_Composition.Memo].ToString().Trim(); //备注
objvzx_CompositionEN.Keyword = objRow[convzx_Composition.Keyword] == DBNull.Value ? null : objRow[convzx_Composition.Keyword].ToString().Trim(); //关键字
objvzx_CompositionEN.LiteratureSources = objRow[convzx_Composition.LiteratureSources] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureSources].ToString().Trim(); //文献来源
objvzx_CompositionEN.LiteratureLink = objRow[convzx_Composition.LiteratureLink] == DBNull.Value ? null : objRow[convzx_Composition.LiteratureLink].ToString().Trim(); //文献链接
objvzx_CompositionEN.UploadfileUrl = objRow[convzx_Composition.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_Composition.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_CompositionEN.IsQuotethesis = TransNullToBool(objRow[convzx_Composition.IsQuotethesis].ToString().Trim()); //是否引用论文
objvzx_CompositionEN.QuoteId = objRow[convzx_Composition.QuoteId] == DBNull.Value ? null : objRow[convzx_Composition.QuoteId].ToString().Trim(); //引用Id
objvzx_CompositionEN.IsChecked = TransNullToBool(objRow[convzx_Composition.IsChecked].ToString().Trim()); //是否检查
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvzx_CompositionDA: GetObjByDataRow)", objException.Message));
}
objvzx_CompositionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_CompositionEN;
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
objSQL = clsvzx_CompositionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_CompositionEN._CurrTabName, convzx_Composition.zxPaperId, 8, "");
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
objSQL = clsvzx_CompositionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_CompositionEN._CurrTabName, convzx_Composition.zxPaperId, 8, strPrefix);
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
 objSQL = clsvzx_CompositionDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select zxPaperId from vzx_Composition where " + strCondition;
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
 objSQL = clsvzx_CompositionDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select zxPaperId from vzx_Composition where " + strCondition;
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
 /// <param name = "strzxPaperId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strzxPaperId)
{
CheckPrimaryKey(strzxPaperId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_CompositionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_Composition", "zxPaperId = " + "'"+ strzxPaperId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvzx_CompositionDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_CompositionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_Composition", strCondition))
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
objSQL = clsvzx_CompositionDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vzx_Composition");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvzx_CompositionENS">源对象</param>
 /// <param name = "objvzx_CompositionENT">目标对象</param>
public void CopyTo(clsvzx_CompositionEN objvzx_CompositionENS, clsvzx_CompositionEN objvzx_CompositionENT)
{
objvzx_CompositionENT.zxPaperId = objvzx_CompositionENS.zxPaperId; //论文Id
objvzx_CompositionENT.LiteratureTypeName = objvzx_CompositionENS.LiteratureTypeName; //作文类型名
objvzx_CompositionENT.CurrEduClsId = objvzx_CompositionENS.CurrEduClsId; //教学班Id
objvzx_CompositionENT.EduClsName = objvzx_CompositionENS.EduClsName; //教学班名
objvzx_CompositionENT.GroupTextId = objvzx_CompositionENS.GroupTextId; //小组Id
objvzx_CompositionENT.TeaQCount = objvzx_CompositionENS.TeaQCount; //教师提问数
objvzx_CompositionENT.TagsCount = objvzx_CompositionENS.TagsCount; //论文标注数
objvzx_CompositionENT.SubVCount = objvzx_CompositionENS.SubVCount; //论文子观点数
objvzx_CompositionENT.PaperQCount = objvzx_CompositionENS.PaperQCount; //论文答疑数
objvzx_CompositionENT.zxShareId = objvzx_CompositionENS.zxShareId; //分享Id
objvzx_CompositionENT.CreateDate = objvzx_CompositionENS.CreateDate; //建立日期
objvzx_CompositionENT.ExpectedConclusion = objvzx_CompositionENS.ExpectedConclusion; //预期结论
objvzx_CompositionENT.DimensionDataProcess = objvzx_CompositionENS.DimensionDataProcess; //数据处理的维度
objvzx_CompositionENT.InnovationPoints = objvzx_CompositionENS.InnovationPoints; //创新点
objvzx_CompositionENT.ResearchStatus = objvzx_CompositionENS.ResearchStatus; //目前研究的现状
objvzx_CompositionENT.IsPublic = objvzx_CompositionENS.IsPublic; //是否公开
objvzx_CompositionENT.UpdUser = objvzx_CompositionENS.UpdUser; //修改人
objvzx_CompositionENT.ResearchDesign = objvzx_CompositionENS.ResearchDesign; //研究设计
objvzx_CompositionENT.VersionCount = objvzx_CompositionENS.VersionCount; //版本统计
objvzx_CompositionENT.AskQuestion = objvzx_CompositionENS.AskQuestion; //问题提出
objvzx_CompositionENT.zxPaperStatusId = objvzx_CompositionENS.zxPaperStatusId; //论文状态Id
objvzx_CompositionENT.PaperTypeId = objvzx_CompositionENS.PaperTypeId; //论文类型Id
objvzx_CompositionENT.IdCurrEduCls = objvzx_CompositionENS.IdCurrEduCls; //教学班流水号
objvzx_CompositionENT.TeaScore = objvzx_CompositionENS.TeaScore; //教师评分
objvzx_CompositionENT.StuScore = objvzx_CompositionENS.StuScore; //学生平均分
objvzx_CompositionENT.Score = objvzx_CompositionENS.Score; //评分
objvzx_CompositionENT.Pcount = objvzx_CompositionENS.Pcount; //读写数
objvzx_CompositionENT.OkCount = objvzx_CompositionENS.OkCount; //点赞统计
objvzx_CompositionENT.DownloadCount = objvzx_CompositionENS.DownloadCount; //下载数
objvzx_CompositionENT.CollectionCount = objvzx_CompositionENS.CollectionCount; //收藏数量
objvzx_CompositionENT.AttachmentCount = objvzx_CompositionENS.AttachmentCount; //附件计数
objvzx_CompositionENT.AppraiseCount = objvzx_CompositionENS.AppraiseCount; //评论数
objvzx_CompositionENT.IsSubmit = objvzx_CompositionENS.IsSubmit; //是否提交
objvzx_CompositionENT.BrowseNumber = objvzx_CompositionENS.BrowseNumber; //浏览量
objvzx_CompositionENT.zxLiteratureTypeId = objvzx_CompositionENS.zxLiteratureTypeId; //作文类型Id
objvzx_CompositionENT.Checker = objvzx_CompositionENS.Checker; //审核人
objvzx_CompositionENT.PaperTitle = objvzx_CompositionENS.PaperTitle; //论文标题
objvzx_CompositionENT.PaperName = objvzx_CompositionENS.PaperName; //主题名称
objvzx_CompositionENT.PaperContent = objvzx_CompositionENS.PaperContent; //主题内容
objvzx_CompositionENT.Periodical = objvzx_CompositionENS.Periodical; //期刊
objvzx_CompositionENT.Author = objvzx_CompositionENS.Author; //作者
objvzx_CompositionENT.ResearchQuestion = objvzx_CompositionENS.ResearchQuestion; //研究问题
objvzx_CompositionENT.UpdDate = objvzx_CompositionENS.UpdDate; //修改日期
objvzx_CompositionENT.Memo = objvzx_CompositionENS.Memo; //备注
objvzx_CompositionENT.Keyword = objvzx_CompositionENS.Keyword; //关键字
objvzx_CompositionENT.LiteratureSources = objvzx_CompositionENS.LiteratureSources; //文献来源
objvzx_CompositionENT.LiteratureLink = objvzx_CompositionENS.LiteratureLink; //文献链接
objvzx_CompositionENT.UploadfileUrl = objvzx_CompositionENS.UploadfileUrl; //文件地址
objvzx_CompositionENT.IsQuotethesis = objvzx_CompositionENS.IsQuotethesis; //是否引用论文
objvzx_CompositionENT.QuoteId = objvzx_CompositionENS.QuoteId; //引用Id
objvzx_CompositionENT.IsChecked = objvzx_CompositionENS.IsChecked; //是否检查
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvzx_CompositionEN objvzx_CompositionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvzx_CompositionEN.zxPaperId, 8, convzx_Composition.zxPaperId);
clsCheckSql.CheckFieldLen(objvzx_CompositionEN.LiteratureTypeName, 100, convzx_Composition.LiteratureTypeName);
clsCheckSql.CheckFieldLen(objvzx_CompositionEN.CurrEduClsId, 15, convzx_Composition.CurrEduClsId);
clsCheckSql.CheckFieldLen(objvzx_CompositionEN.EduClsName, 100, convzx_Composition.EduClsName);
clsCheckSql.CheckFieldLen(objvzx_CompositionEN.GroupTextId, 8, convzx_Composition.GroupTextId);
clsCheckSql.CheckFieldLen(objvzx_CompositionEN.zxShareId, 2, convzx_Composition.zxShareId);
clsCheckSql.CheckFieldLen(objvzx_CompositionEN.CreateDate, 20, convzx_Composition.CreateDate);
clsCheckSql.CheckFieldLen(objvzx_CompositionEN.ExpectedConclusion, 5000, convzx_Composition.ExpectedConclusion);
clsCheckSql.CheckFieldLen(objvzx_CompositionEN.DimensionDataProcess, 5000, convzx_Composition.DimensionDataProcess);
clsCheckSql.CheckFieldLen(objvzx_CompositionEN.InnovationPoints, 5000, convzx_Composition.InnovationPoints);
clsCheckSql.CheckFieldLen(objvzx_CompositionEN.ResearchStatus, 5000, convzx_Composition.ResearchStatus);
clsCheckSql.CheckFieldLen(objvzx_CompositionEN.UpdUser, 20, convzx_Composition.UpdUser);
clsCheckSql.CheckFieldLen(objvzx_CompositionEN.ResearchDesign, 5000, convzx_Composition.ResearchDesign);
clsCheckSql.CheckFieldLen(objvzx_CompositionEN.AskQuestion, 5000, convzx_Composition.AskQuestion);
clsCheckSql.CheckFieldLen(objvzx_CompositionEN.zxPaperStatusId, 2, convzx_Composition.zxPaperStatusId);
clsCheckSql.CheckFieldLen(objvzx_CompositionEN.PaperTypeId, 2, convzx_Composition.PaperTypeId);
clsCheckSql.CheckFieldLen(objvzx_CompositionEN.IdCurrEduCls, 8, convzx_Composition.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvzx_CompositionEN.zxLiteratureTypeId, 2, convzx_Composition.zxLiteratureTypeId);
clsCheckSql.CheckFieldLen(objvzx_CompositionEN.Checker, 20, convzx_Composition.Checker);
clsCheckSql.CheckFieldLen(objvzx_CompositionEN.PaperTitle, 500, convzx_Composition.PaperTitle);
clsCheckSql.CheckFieldLen(objvzx_CompositionEN.PaperName, 500, convzx_Composition.PaperName);
clsCheckSql.CheckFieldLen(objvzx_CompositionEN.Periodical, 100, convzx_Composition.Periodical);
clsCheckSql.CheckFieldLen(objvzx_CompositionEN.Author, 200, convzx_Composition.Author);
clsCheckSql.CheckFieldLen(objvzx_CompositionEN.ResearchQuestion, 2000, convzx_Composition.ResearchQuestion);
clsCheckSql.CheckFieldLen(objvzx_CompositionEN.UpdDate, 20, convzx_Composition.UpdDate);
clsCheckSql.CheckFieldLen(objvzx_CompositionEN.Memo, 1000, convzx_Composition.Memo);
clsCheckSql.CheckFieldLen(objvzx_CompositionEN.Keyword, 1000, convzx_Composition.Keyword);
clsCheckSql.CheckFieldLen(objvzx_CompositionEN.LiteratureSources, 1000, convzx_Composition.LiteratureSources);
clsCheckSql.CheckFieldLen(objvzx_CompositionEN.LiteratureLink, 1000, convzx_Composition.LiteratureLink);
clsCheckSql.CheckFieldLen(objvzx_CompositionEN.UploadfileUrl, 1000, convzx_Composition.UploadfileUrl);
clsCheckSql.CheckFieldLen(objvzx_CompositionEN.QuoteId, 8, convzx_Composition.QuoteId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvzx_CompositionEN.zxPaperId, convzx_Composition.zxPaperId);
clsCheckSql.CheckSqlInjection4Field(objvzx_CompositionEN.LiteratureTypeName, convzx_Composition.LiteratureTypeName);
clsCheckSql.CheckSqlInjection4Field(objvzx_CompositionEN.CurrEduClsId, convzx_Composition.CurrEduClsId);
clsCheckSql.CheckSqlInjection4Field(objvzx_CompositionEN.EduClsName, convzx_Composition.EduClsName);
clsCheckSql.CheckSqlInjection4Field(objvzx_CompositionEN.GroupTextId, convzx_Composition.GroupTextId);
clsCheckSql.CheckSqlInjection4Field(objvzx_CompositionEN.zxShareId, convzx_Composition.zxShareId);
clsCheckSql.CheckSqlInjection4Field(objvzx_CompositionEN.CreateDate, convzx_Composition.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_CompositionEN.ExpectedConclusion, convzx_Composition.ExpectedConclusion);
clsCheckSql.CheckSqlInjection4Field(objvzx_CompositionEN.DimensionDataProcess, convzx_Composition.DimensionDataProcess);
clsCheckSql.CheckSqlInjection4Field(objvzx_CompositionEN.InnovationPoints, convzx_Composition.InnovationPoints);
clsCheckSql.CheckSqlInjection4Field(objvzx_CompositionEN.ResearchStatus, convzx_Composition.ResearchStatus);
clsCheckSql.CheckSqlInjection4Field(objvzx_CompositionEN.UpdUser, convzx_Composition.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvzx_CompositionEN.ResearchDesign, convzx_Composition.ResearchDesign);
clsCheckSql.CheckSqlInjection4Field(objvzx_CompositionEN.AskQuestion, convzx_Composition.AskQuestion);
clsCheckSql.CheckSqlInjection4Field(objvzx_CompositionEN.zxPaperStatusId, convzx_Composition.zxPaperStatusId);
clsCheckSql.CheckSqlInjection4Field(objvzx_CompositionEN.PaperTypeId, convzx_Composition.PaperTypeId);
clsCheckSql.CheckSqlInjection4Field(objvzx_CompositionEN.IdCurrEduCls, convzx_Composition.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvzx_CompositionEN.zxLiteratureTypeId, convzx_Composition.zxLiteratureTypeId);
clsCheckSql.CheckSqlInjection4Field(objvzx_CompositionEN.Checker, convzx_Composition.Checker);
clsCheckSql.CheckSqlInjection4Field(objvzx_CompositionEN.PaperTitle, convzx_Composition.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objvzx_CompositionEN.PaperName, convzx_Composition.PaperName);
clsCheckSql.CheckSqlInjection4Field(objvzx_CompositionEN.Periodical, convzx_Composition.Periodical);
clsCheckSql.CheckSqlInjection4Field(objvzx_CompositionEN.Author, convzx_Composition.Author);
clsCheckSql.CheckSqlInjection4Field(objvzx_CompositionEN.ResearchQuestion, convzx_Composition.ResearchQuestion);
clsCheckSql.CheckSqlInjection4Field(objvzx_CompositionEN.UpdDate, convzx_Composition.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_CompositionEN.Memo, convzx_Composition.Memo);
clsCheckSql.CheckSqlInjection4Field(objvzx_CompositionEN.Keyword, convzx_Composition.Keyword);
clsCheckSql.CheckSqlInjection4Field(objvzx_CompositionEN.LiteratureSources, convzx_Composition.LiteratureSources);
clsCheckSql.CheckSqlInjection4Field(objvzx_CompositionEN.LiteratureLink, convzx_Composition.LiteratureLink);
clsCheckSql.CheckSqlInjection4Field(objvzx_CompositionEN.UploadfileUrl, convzx_Composition.UploadfileUrl);
clsCheckSql.CheckSqlInjection4Field(objvzx_CompositionEN.QuoteId, convzx_Composition.QuoteId);
//检查外键字段长度
 objvzx_CompositionEN._IsCheckProperty = true;
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
 objSQL = clsvzx_CompositionDA.GetSpecSQLObj();
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
 objSQL = clsvzx_CompositionDA.GetSpecSQLObj();
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
 objSQL = clsvzx_CompositionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_CompositionEN._CurrTabName);
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
 objSQL = clsvzx_CompositionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_CompositionEN._CurrTabName, strCondition);
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
 objSQL = clsvzx_CompositionDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}