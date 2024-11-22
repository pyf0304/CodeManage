
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_TextCountDA
 表名:vzx_TextCount(01120839)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:38
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
 /// vzx_TextCount(vzx_TextCount)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvzx_TextCountDA : clsCommBase4DA
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
 return clsvzx_TextCountEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvzx_TextCountEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_TextCountEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvzx_TextCountEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvzx_TextCountEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strTextId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strTextId)
{
strTextId = strTextId.Replace("'", "''");
if (strTextId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vzx_TextCount中,检查关键字,长度不正确!(clsvzx_TextCountDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTextId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vzx_TextCount中,关键字不能为空 或 null!(clsvzx_TextCountDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTextId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvzx_TextCountDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvzx_TextCountDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TextCountDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TextCount where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vzx_TextCount(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvzx_TextCountDA: GetDataTable_vzx_TextCount)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TextCountDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TextCount where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvzx_TextCountDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TextCountDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvzx_TextCountDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TextCountDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TextCount where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvzx_TextCountDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TextCountDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvzx_TextCountDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TextCountDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_TextCount where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_TextCount where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvzx_TextCountDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TextCountDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vzx_TextCount where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvzx_TextCountDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TextCountDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_TextCount.* from vzx_TextCount Left Join {1} on {2} where {3} and vzx_TextCount.TextId not in (Select top {5} vzx_TextCount.TextId from vzx_TextCount Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_TextCount where {1} and TextId not in (Select top {2} TextId from vzx_TextCount where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_TextCount where {1} and TextId not in (Select top {3} TextId from vzx_TextCount where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvzx_TextCountDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TextCountDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_TextCount.* from vzx_TextCount Left Join {1} on {2} where {3} and vzx_TextCount.TextId not in (Select top {5} vzx_TextCount.TextId from vzx_TextCount Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_TextCount where {1} and TextId not in (Select top {2} TextId from vzx_TextCount where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_TextCount where {1} and TextId not in (Select top {3} TextId from vzx_TextCount where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvzx_TextCountEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvzx_TextCountDA:GetObjLst)", objException.Message));
}
List<clsvzx_TextCountEN> arrObjLst = new List<clsvzx_TextCountEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TextCountDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TextCount where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TextCountEN objvzx_TextCountEN = new clsvzx_TextCountEN();
try
{
objvzx_TextCountEN.TextId = objRow[convzx_TextCount.TextId].ToString().Trim(); //课件Id
objvzx_TextCountEN.PaperQCount = objRow[convzx_TextCount.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_TextCountEN.TagsCount = objRow[convzx_TextCount.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.TagsCount].ToString().Trim()); //论文标注数
objvzx_TextCountEN.SubVCount = objRow[convzx_TextCount.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.SubVCount].ToString().Trim()); //论文子观点数
objvzx_TextCountEN.TeaQCount = objRow[convzx_TextCount.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.TeaQCount].ToString().Trim()); //教师提问数
objvzx_TextCountEN.TeaScore = objRow[convzx_TextCount.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TextCount.TeaScore].ToString().Trim()); //教师评分
objvzx_TextCountEN.StuScore = objRow[convzx_TextCount.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TextCount.StuScore].ToString().Trim()); //学生平均分
objvzx_TextCountEN.Score = objRow[convzx_TextCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TextCount.Score].ToString().Trim()); //评分
objvzx_TextCountEN.AppraiseCount = objRow[convzx_TextCount.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.AppraiseCount].ToString().Trim()); //评论数
objvzx_TextCountEN.AttachmentCount = objRow[convzx_TextCount.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.AttachmentCount].ToString().Trim()); //附件计数
objvzx_TextCountEN.DownloadCount = objRow[convzx_TextCount.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.DownloadCount].ToString().Trim()); //下载数
objvzx_TextCountEN.CollectionCount = objRow[convzx_TextCount.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convzx_TextCount.CollectionCount].ToString().Trim()); //收藏数量
objvzx_TextCountEN.VoteCount = objRow[convzx_TextCount.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.VoteCount].ToString().Trim()); //点赞计数
objvzx_TextCountEN.VCount = objRow[convzx_TextCount.VCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.VCount].ToString().Trim()); //VCount
objvzx_TextCountEN.BrowseNumber = objRow[convzx_TextCount.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.BrowseNumber].ToString().Trim()); //浏览量
objvzx_TextCountEN.TextTitle = objRow[convzx_TextCount.TextTitle].ToString().Trim(); //TextTitle
objvzx_TextCountEN.TextContent = objRow[convzx_TextCount.TextContent] == DBNull.Value ? null : objRow[convzx_TextCount.TextContent].ToString().Trim(); //TextContent
objvzx_TextCountEN.UpdDate = objRow[convzx_TextCount.UpdDate] == DBNull.Value ? null : objRow[convzx_TextCount.UpdDate].ToString().Trim(); //修改日期
objvzx_TextCountEN.UpdUser = objRow[convzx_TextCount.UpdUser] == DBNull.Value ? null : objRow[convzx_TextCount.UpdUser].ToString().Trim(); //修改人
objvzx_TextCountEN.CreateDate = objRow[convzx_TextCount.CreateDate] == DBNull.Value ? null : objRow[convzx_TextCount.CreateDate].ToString().Trim(); //建立日期
objvzx_TextCountEN.IdCurrEduCls = objRow[convzx_TextCount.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TextCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_TextCountDA: GetObjLst)", objException.Message));
}
objvzx_TextCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_TextCountEN);
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
public List<clsvzx_TextCountEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvzx_TextCountDA:GetObjLstByTabName)", objException.Message));
}
List<clsvzx_TextCountEN> arrObjLst = new List<clsvzx_TextCountEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TextCountDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TextCountEN objvzx_TextCountEN = new clsvzx_TextCountEN();
try
{
objvzx_TextCountEN.TextId = objRow[convzx_TextCount.TextId].ToString().Trim(); //课件Id
objvzx_TextCountEN.PaperQCount = objRow[convzx_TextCount.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_TextCountEN.TagsCount = objRow[convzx_TextCount.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.TagsCount].ToString().Trim()); //论文标注数
objvzx_TextCountEN.SubVCount = objRow[convzx_TextCount.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.SubVCount].ToString().Trim()); //论文子观点数
objvzx_TextCountEN.TeaQCount = objRow[convzx_TextCount.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.TeaQCount].ToString().Trim()); //教师提问数
objvzx_TextCountEN.TeaScore = objRow[convzx_TextCount.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TextCount.TeaScore].ToString().Trim()); //教师评分
objvzx_TextCountEN.StuScore = objRow[convzx_TextCount.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TextCount.StuScore].ToString().Trim()); //学生平均分
objvzx_TextCountEN.Score = objRow[convzx_TextCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TextCount.Score].ToString().Trim()); //评分
objvzx_TextCountEN.AppraiseCount = objRow[convzx_TextCount.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.AppraiseCount].ToString().Trim()); //评论数
objvzx_TextCountEN.AttachmentCount = objRow[convzx_TextCount.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.AttachmentCount].ToString().Trim()); //附件计数
objvzx_TextCountEN.DownloadCount = objRow[convzx_TextCount.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.DownloadCount].ToString().Trim()); //下载数
objvzx_TextCountEN.CollectionCount = objRow[convzx_TextCount.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convzx_TextCount.CollectionCount].ToString().Trim()); //收藏数量
objvzx_TextCountEN.VoteCount = objRow[convzx_TextCount.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.VoteCount].ToString().Trim()); //点赞计数
objvzx_TextCountEN.VCount = objRow[convzx_TextCount.VCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.VCount].ToString().Trim()); //VCount
objvzx_TextCountEN.BrowseNumber = objRow[convzx_TextCount.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.BrowseNumber].ToString().Trim()); //浏览量
objvzx_TextCountEN.TextTitle = objRow[convzx_TextCount.TextTitle].ToString().Trim(); //TextTitle
objvzx_TextCountEN.TextContent = objRow[convzx_TextCount.TextContent] == DBNull.Value ? null : objRow[convzx_TextCount.TextContent].ToString().Trim(); //TextContent
objvzx_TextCountEN.UpdDate = objRow[convzx_TextCount.UpdDate] == DBNull.Value ? null : objRow[convzx_TextCount.UpdDate].ToString().Trim(); //修改日期
objvzx_TextCountEN.UpdUser = objRow[convzx_TextCount.UpdUser] == DBNull.Value ? null : objRow[convzx_TextCount.UpdUser].ToString().Trim(); //修改人
objvzx_TextCountEN.CreateDate = objRow[convzx_TextCount.CreateDate] == DBNull.Value ? null : objRow[convzx_TextCount.CreateDate].ToString().Trim(); //建立日期
objvzx_TextCountEN.IdCurrEduCls = objRow[convzx_TextCount.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TextCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_TextCountDA: GetObjLst)", objException.Message));
}
objvzx_TextCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_TextCountEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvzx_TextCountEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvzx_TextCount(ref clsvzx_TextCountEN objvzx_TextCountEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TextCountDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TextCount where TextId = " + "'"+ objvzx_TextCountEN.TextId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvzx_TextCountEN.TextId = objDT.Rows[0][convzx_TextCount.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_TextCountEN.PaperQCount = TransNullToInt(objDT.Rows[0][convzx_TextCount.PaperQCount].ToString().Trim()); //论文答疑数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TextCountEN.TagsCount = TransNullToInt(objDT.Rows[0][convzx_TextCount.TagsCount].ToString().Trim()); //论文标注数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TextCountEN.SubVCount = TransNullToInt(objDT.Rows[0][convzx_TextCount.SubVCount].ToString().Trim()); //论文子观点数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TextCountEN.TeaQCount = TransNullToInt(objDT.Rows[0][convzx_TextCount.TeaQCount].ToString().Trim()); //教师提问数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TextCountEN.TeaScore = TransNullToFloat(objDT.Rows[0][convzx_TextCount.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_TextCountEN.StuScore = TransNullToFloat(objDT.Rows[0][convzx_TextCount.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_TextCountEN.Score = TransNullToFloat(objDT.Rows[0][convzx_TextCount.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_TextCountEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convzx_TextCount.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TextCountEN.AttachmentCount = TransNullToInt(objDT.Rows[0][convzx_TextCount.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TextCountEN.DownloadCount = TransNullToInt(objDT.Rows[0][convzx_TextCount.DownloadCount].ToString().Trim()); //下载数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TextCountEN.CollectionCount = TransNullToInt(objDT.Rows[0][convzx_TextCount.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvzx_TextCountEN.VoteCount = TransNullToInt(objDT.Rows[0][convzx_TextCount.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TextCountEN.VCount = TransNullToInt(objDT.Rows[0][convzx_TextCount.VCount].ToString().Trim()); //VCount(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TextCountEN.BrowseNumber = TransNullToInt(objDT.Rows[0][convzx_TextCount.BrowseNumber].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TextCountEN.TextTitle = objDT.Rows[0][convzx_TextCount.TextTitle].ToString().Trim(); //TextTitle(字段类型:varchar,字段长度:500,是否可空:False)
 objvzx_TextCountEN.TextContent = objDT.Rows[0][convzx_TextCount.TextContent].ToString().Trim(); //TextContent(字段类型:text,字段长度:2147483647,是否可空:True)
 objvzx_TextCountEN.UpdDate = objDT.Rows[0][convzx_TextCount.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TextCountEN.UpdUser = objDT.Rows[0][convzx_TextCount.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TextCountEN.CreateDate = objDT.Rows[0][convzx_TextCount.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TextCountEN.IdCurrEduCls = objDT.Rows[0][convzx_TextCount.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvzx_TextCountDA: Getvzx_TextCount)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTextId">表关键字</param>
 /// <returns>表对象</returns>
public clsvzx_TextCountEN GetObjByTextId(string strTextId)
{
CheckPrimaryKey(strTextId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TextCountDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TextCount where TextId = " + "'"+ strTextId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvzx_TextCountEN objvzx_TextCountEN = new clsvzx_TextCountEN();
try
{
 objvzx_TextCountEN.TextId = objRow[convzx_TextCount.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_TextCountEN.PaperQCount = objRow[convzx_TextCount.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.PaperQCount].ToString().Trim()); //论文答疑数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TextCountEN.TagsCount = objRow[convzx_TextCount.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.TagsCount].ToString().Trim()); //论文标注数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TextCountEN.SubVCount = objRow[convzx_TextCount.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.SubVCount].ToString().Trim()); //论文子观点数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TextCountEN.TeaQCount = objRow[convzx_TextCount.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.TeaQCount].ToString().Trim()); //教师提问数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TextCountEN.TeaScore = objRow[convzx_TextCount.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_TextCountEN.StuScore = objRow[convzx_TextCount.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_TextCountEN.Score = objRow[convzx_TextCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TextCount.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_TextCountEN.AppraiseCount = objRow[convzx_TextCount.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TextCountEN.AttachmentCount = objRow[convzx_TextCount.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.AttachmentCount].ToString().Trim()); //附件计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TextCountEN.DownloadCount = objRow[convzx_TextCount.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.DownloadCount].ToString().Trim()); //下载数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TextCountEN.CollectionCount = objRow[convzx_TextCount.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvzx_TextCountEN.VoteCount = objRow[convzx_TextCount.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TextCountEN.VCount = objRow[convzx_TextCount.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.VCount].ToString().Trim()); //VCount(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TextCountEN.BrowseNumber = objRow[convzx_TextCount.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TextCount.BrowseNumber].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvzx_TextCountEN.TextTitle = objRow[convzx_TextCount.TextTitle].ToString().Trim(); //TextTitle(字段类型:varchar,字段长度:500,是否可空:False)
 objvzx_TextCountEN.TextContent = objRow[convzx_TextCount.TextContent] == DBNull.Value ? null : objRow[convzx_TextCount.TextContent].ToString().Trim(); //TextContent(字段类型:text,字段长度:2147483647,是否可空:True)
 objvzx_TextCountEN.UpdDate = objRow[convzx_TextCount.UpdDate] == DBNull.Value ? null : objRow[convzx_TextCount.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TextCountEN.UpdUser = objRow[convzx_TextCount.UpdUser] == DBNull.Value ? null : objRow[convzx_TextCount.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TextCountEN.CreateDate = objRow[convzx_TextCount.CreateDate] == DBNull.Value ? null : objRow[convzx_TextCount.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_TextCountEN.IdCurrEduCls = objRow[convzx_TextCount.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TextCount.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvzx_TextCountDA: GetObjByTextId)", objException.Message));
}
return objvzx_TextCountEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvzx_TextCountEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvzx_TextCountDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TextCountDA.GetSpecSQLObj();
strSQL = "Select * from vzx_TextCount where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvzx_TextCountEN objvzx_TextCountEN = new clsvzx_TextCountEN()
{
TextId = objRow[convzx_TextCount.TextId].ToString().Trim(), //课件Id
PaperQCount = objRow[convzx_TextCount.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.PaperQCount].ToString().Trim()), //论文答疑数
TagsCount = objRow[convzx_TextCount.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.TagsCount].ToString().Trim()), //论文标注数
SubVCount = objRow[convzx_TextCount.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.SubVCount].ToString().Trim()), //论文子观点数
TeaQCount = objRow[convzx_TextCount.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.TeaQCount].ToString().Trim()), //教师提问数
TeaScore = objRow[convzx_TextCount.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TextCount.TeaScore].ToString().Trim()), //教师评分
StuScore = objRow[convzx_TextCount.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TextCount.StuScore].ToString().Trim()), //学生平均分
Score = objRow[convzx_TextCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TextCount.Score].ToString().Trim()), //评分
AppraiseCount = objRow[convzx_TextCount.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.AppraiseCount].ToString().Trim()), //评论数
AttachmentCount = objRow[convzx_TextCount.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.AttachmentCount].ToString().Trim()), //附件计数
DownloadCount = objRow[convzx_TextCount.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.DownloadCount].ToString().Trim()), //下载数
CollectionCount = objRow[convzx_TextCount.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convzx_TextCount.CollectionCount].ToString().Trim()), //收藏数量
VoteCount = objRow[convzx_TextCount.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.VoteCount].ToString().Trim()), //点赞计数
VCount = objRow[convzx_TextCount.VCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.VCount].ToString().Trim()), //VCount
BrowseNumber = objRow[convzx_TextCount.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.BrowseNumber].ToString().Trim()), //浏览量
TextTitle = objRow[convzx_TextCount.TextTitle].ToString().Trim(), //TextTitle
TextContent = objRow[convzx_TextCount.TextContent] == DBNull.Value ? null : objRow[convzx_TextCount.TextContent].ToString().Trim(), //TextContent
UpdDate = objRow[convzx_TextCount.UpdDate] == DBNull.Value ? null : objRow[convzx_TextCount.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convzx_TextCount.UpdUser] == DBNull.Value ? null : objRow[convzx_TextCount.UpdUser].ToString().Trim(), //修改人
CreateDate = objRow[convzx_TextCount.CreateDate] == DBNull.Value ? null : objRow[convzx_TextCount.CreateDate].ToString().Trim(), //建立日期
IdCurrEduCls = objRow[convzx_TextCount.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TextCount.IdCurrEduCls].ToString().Trim() //教学班流水号
};
objvzx_TextCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_TextCountEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvzx_TextCountDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvzx_TextCountEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_TextCountEN objvzx_TextCountEN = new clsvzx_TextCountEN();
try
{
objvzx_TextCountEN.TextId = objRow[convzx_TextCount.TextId].ToString().Trim(); //课件Id
objvzx_TextCountEN.PaperQCount = objRow[convzx_TextCount.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_TextCountEN.TagsCount = objRow[convzx_TextCount.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.TagsCount].ToString().Trim()); //论文标注数
objvzx_TextCountEN.SubVCount = objRow[convzx_TextCount.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.SubVCount].ToString().Trim()); //论文子观点数
objvzx_TextCountEN.TeaQCount = objRow[convzx_TextCount.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.TeaQCount].ToString().Trim()); //教师提问数
objvzx_TextCountEN.TeaScore = objRow[convzx_TextCount.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TextCount.TeaScore].ToString().Trim()); //教师评分
objvzx_TextCountEN.StuScore = objRow[convzx_TextCount.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TextCount.StuScore].ToString().Trim()); //学生平均分
objvzx_TextCountEN.Score = objRow[convzx_TextCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TextCount.Score].ToString().Trim()); //评分
objvzx_TextCountEN.AppraiseCount = objRow[convzx_TextCount.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.AppraiseCount].ToString().Trim()); //评论数
objvzx_TextCountEN.AttachmentCount = objRow[convzx_TextCount.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.AttachmentCount].ToString().Trim()); //附件计数
objvzx_TextCountEN.DownloadCount = objRow[convzx_TextCount.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.DownloadCount].ToString().Trim()); //下载数
objvzx_TextCountEN.CollectionCount = objRow[convzx_TextCount.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convzx_TextCount.CollectionCount].ToString().Trim()); //收藏数量
objvzx_TextCountEN.VoteCount = objRow[convzx_TextCount.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.VoteCount].ToString().Trim()); //点赞计数
objvzx_TextCountEN.VCount = objRow[convzx_TextCount.VCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.VCount].ToString().Trim()); //VCount
objvzx_TextCountEN.BrowseNumber = objRow[convzx_TextCount.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.BrowseNumber].ToString().Trim()); //浏览量
objvzx_TextCountEN.TextTitle = objRow[convzx_TextCount.TextTitle].ToString().Trim(); //TextTitle
objvzx_TextCountEN.TextContent = objRow[convzx_TextCount.TextContent] == DBNull.Value ? null : objRow[convzx_TextCount.TextContent].ToString().Trim(); //TextContent
objvzx_TextCountEN.UpdDate = objRow[convzx_TextCount.UpdDate] == DBNull.Value ? null : objRow[convzx_TextCount.UpdDate].ToString().Trim(); //修改日期
objvzx_TextCountEN.UpdUser = objRow[convzx_TextCount.UpdUser] == DBNull.Value ? null : objRow[convzx_TextCount.UpdUser].ToString().Trim(); //修改人
objvzx_TextCountEN.CreateDate = objRow[convzx_TextCount.CreateDate] == DBNull.Value ? null : objRow[convzx_TextCount.CreateDate].ToString().Trim(); //建立日期
objvzx_TextCountEN.IdCurrEduCls = objRow[convzx_TextCount.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TextCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvzx_TextCountDA: GetObjByDataRowvzx_TextCount)", objException.Message));
}
objvzx_TextCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_TextCountEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvzx_TextCountEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_TextCountEN objvzx_TextCountEN = new clsvzx_TextCountEN();
try
{
objvzx_TextCountEN.TextId = objRow[convzx_TextCount.TextId].ToString().Trim(); //课件Id
objvzx_TextCountEN.PaperQCount = objRow[convzx_TextCount.PaperQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.PaperQCount].ToString().Trim()); //论文答疑数
objvzx_TextCountEN.TagsCount = objRow[convzx_TextCount.TagsCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.TagsCount].ToString().Trim()); //论文标注数
objvzx_TextCountEN.SubVCount = objRow[convzx_TextCount.SubVCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.SubVCount].ToString().Trim()); //论文子观点数
objvzx_TextCountEN.TeaQCount = objRow[convzx_TextCount.TeaQCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.TeaQCount].ToString().Trim()); //教师提问数
objvzx_TextCountEN.TeaScore = objRow[convzx_TextCount.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TextCount.TeaScore].ToString().Trim()); //教师评分
objvzx_TextCountEN.StuScore = objRow[convzx_TextCount.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TextCount.StuScore].ToString().Trim()); //学生平均分
objvzx_TextCountEN.Score = objRow[convzx_TextCount.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_TextCount.Score].ToString().Trim()); //评分
objvzx_TextCountEN.AppraiseCount = objRow[convzx_TextCount.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.AppraiseCount].ToString().Trim()); //评论数
objvzx_TextCountEN.AttachmentCount = objRow[convzx_TextCount.AttachmentCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.AttachmentCount].ToString().Trim()); //附件计数
objvzx_TextCountEN.DownloadCount = objRow[convzx_TextCount.DownloadCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.DownloadCount].ToString().Trim()); //下载数
objvzx_TextCountEN.CollectionCount = objRow[convzx_TextCount.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convzx_TextCount.CollectionCount].ToString().Trim()); //收藏数量
objvzx_TextCountEN.VoteCount = objRow[convzx_TextCount.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.VoteCount].ToString().Trim()); //点赞计数
objvzx_TextCountEN.VCount = objRow[convzx_TextCount.VCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.VCount].ToString().Trim()); //VCount
objvzx_TextCountEN.BrowseNumber = objRow[convzx_TextCount.BrowseNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_TextCount.BrowseNumber].ToString().Trim()); //浏览量
objvzx_TextCountEN.TextTitle = objRow[convzx_TextCount.TextTitle].ToString().Trim(); //TextTitle
objvzx_TextCountEN.TextContent = objRow[convzx_TextCount.TextContent] == DBNull.Value ? null : objRow[convzx_TextCount.TextContent].ToString().Trim(); //TextContent
objvzx_TextCountEN.UpdDate = objRow[convzx_TextCount.UpdDate] == DBNull.Value ? null : objRow[convzx_TextCount.UpdDate].ToString().Trim(); //修改日期
objvzx_TextCountEN.UpdUser = objRow[convzx_TextCount.UpdUser] == DBNull.Value ? null : objRow[convzx_TextCount.UpdUser].ToString().Trim(); //修改人
objvzx_TextCountEN.CreateDate = objRow[convzx_TextCount.CreateDate] == DBNull.Value ? null : objRow[convzx_TextCount.CreateDate].ToString().Trim(); //建立日期
objvzx_TextCountEN.IdCurrEduCls = objRow[convzx_TextCount.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TextCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvzx_TextCountDA: GetObjByDataRow)", objException.Message));
}
objvzx_TextCountEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_TextCountEN;
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
objSQL = clsvzx_TextCountDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_TextCountEN._CurrTabName, convzx_TextCount.TextId, 8, "");
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
objSQL = clsvzx_TextCountDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_TextCountEN._CurrTabName, convzx_TextCount.TextId, 8, strPrefix);
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
 objSQL = clsvzx_TextCountDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TextId from vzx_TextCount where " + strCondition;
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
 objSQL = clsvzx_TextCountDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TextId from vzx_TextCount where " + strCondition;
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
 /// <param name = "strTextId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strTextId)
{
CheckPrimaryKey(strTextId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TextCountDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_TextCount", "TextId = " + "'"+ strTextId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvzx_TextCountDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_TextCountDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_TextCount", strCondition))
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
objSQL = clsvzx_TextCountDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vzx_TextCount");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvzx_TextCountENS">源对象</param>
 /// <param name = "objvzx_TextCountENT">目标对象</param>
public void CopyTo(clsvzx_TextCountEN objvzx_TextCountENS, clsvzx_TextCountEN objvzx_TextCountENT)
{
objvzx_TextCountENT.TextId = objvzx_TextCountENS.TextId; //课件Id
objvzx_TextCountENT.PaperQCount = objvzx_TextCountENS.PaperQCount; //论文答疑数
objvzx_TextCountENT.TagsCount = objvzx_TextCountENS.TagsCount; //论文标注数
objvzx_TextCountENT.SubVCount = objvzx_TextCountENS.SubVCount; //论文子观点数
objvzx_TextCountENT.TeaQCount = objvzx_TextCountENS.TeaQCount; //教师提问数
objvzx_TextCountENT.TeaScore = objvzx_TextCountENS.TeaScore; //教师评分
objvzx_TextCountENT.StuScore = objvzx_TextCountENS.StuScore; //学生平均分
objvzx_TextCountENT.Score = objvzx_TextCountENS.Score; //评分
objvzx_TextCountENT.AppraiseCount = objvzx_TextCountENS.AppraiseCount; //评论数
objvzx_TextCountENT.AttachmentCount = objvzx_TextCountENS.AttachmentCount; //附件计数
objvzx_TextCountENT.DownloadCount = objvzx_TextCountENS.DownloadCount; //下载数
objvzx_TextCountENT.CollectionCount = objvzx_TextCountENS.CollectionCount; //收藏数量
objvzx_TextCountENT.VoteCount = objvzx_TextCountENS.VoteCount; //点赞计数
objvzx_TextCountENT.VCount = objvzx_TextCountENS.VCount; //VCount
objvzx_TextCountENT.BrowseNumber = objvzx_TextCountENS.BrowseNumber; //浏览量
objvzx_TextCountENT.TextTitle = objvzx_TextCountENS.TextTitle; //TextTitle
objvzx_TextCountENT.TextContent = objvzx_TextCountENS.TextContent; //TextContent
objvzx_TextCountENT.UpdDate = objvzx_TextCountENS.UpdDate; //修改日期
objvzx_TextCountENT.UpdUser = objvzx_TextCountENS.UpdUser; //修改人
objvzx_TextCountENT.CreateDate = objvzx_TextCountENS.CreateDate; //建立日期
objvzx_TextCountENT.IdCurrEduCls = objvzx_TextCountENS.IdCurrEduCls; //教学班流水号
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvzx_TextCountEN objvzx_TextCountEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvzx_TextCountEN.TextId, 8, convzx_TextCount.TextId);
clsCheckSql.CheckFieldLen(objvzx_TextCountEN.TextTitle, 500, convzx_TextCount.TextTitle);
clsCheckSql.CheckFieldLen(objvzx_TextCountEN.UpdDate, 20, convzx_TextCount.UpdDate);
clsCheckSql.CheckFieldLen(objvzx_TextCountEN.UpdUser, 20, convzx_TextCount.UpdUser);
clsCheckSql.CheckFieldLen(objvzx_TextCountEN.CreateDate, 20, convzx_TextCount.CreateDate);
clsCheckSql.CheckFieldLen(objvzx_TextCountEN.IdCurrEduCls, 8, convzx_TextCount.IdCurrEduCls);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvzx_TextCountEN.TextId, convzx_TextCount.TextId);
clsCheckSql.CheckSqlInjection4Field(objvzx_TextCountEN.TextTitle, convzx_TextCount.TextTitle);
clsCheckSql.CheckSqlInjection4Field(objvzx_TextCountEN.UpdDate, convzx_TextCount.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_TextCountEN.UpdUser, convzx_TextCount.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvzx_TextCountEN.CreateDate, convzx_TextCount.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_TextCountEN.IdCurrEduCls, convzx_TextCount.IdCurrEduCls);
//检查外键字段长度
 objvzx_TextCountEN._IsCheckProperty = true;
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
 objSQL = clsvzx_TextCountDA.GetSpecSQLObj();
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
 objSQL = clsvzx_TextCountDA.GetSpecSQLObj();
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
 objSQL = clsvzx_TextCountDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_TextCountEN._CurrTabName);
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
 objSQL = clsvzx_TextCountDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_TextCountEN._CurrTabName, strCondition);
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
 objSQL = clsvzx_TextCountDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}