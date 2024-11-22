using System;
using System.Data.SqlClient;
using System.Reflection;
using System.IO;
using System.Collections;
using System.Text;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using System.Collections.Generic;

namespace GetExcelFromDataTable
{
    /// <summary>
    /// Class1 的摘要说明。
    /// </summary>
    public partial class clsGetExcelFromDataTable
    {
        private Excel.Application m_objExcel = null;
        private Excel.Workbooks m_objBooks = null;
        private Excel._Workbook m_objBook = null;
        private Excel.Sheets m_objSheets = null;
        private Excel._Worksheet m_objSheet = null;
        private Excel.Range m_objRange = null;
        private Excel.Font m_objFont = null;
        //private Excel.QueryTables m_objQryTables = null;
        //private Excel._QueryTable m_objQryTable = null;

        // Frequenty-used variable for optional arguments.
        private object m_objOpt = System.Reflection.Missing.Value;

        // Paths used by the sample code for accessing and storing data.
        private object m_strSampleFolder = "E:\\ASPNETJX\\";
        //private string m_strNorthwind = "C:\\Program Files\\Microsoft Office\\Office10\\Samples\\Northwind.mdb";

        public clsGetExcelFromDataTable()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        /// <summary>
        /// 把DataTable导成Excel文件．本函数有４个参数
        /// 参数1： 要导出的DataTable
        /// 参数2： 要到出的DataTable中列的名字（列名，不是中文名称）放在一个string 数组中. 申明数组样例：string[] ColumnNames = new string[5] {"XH","XM","XBMC","XYMC","ZYMC"};
        /// 参数3： 导出的Excel中第一行的中文名称数组．　申明数组样例：string[] Title = new string[5] {"学号","姓名","专业","学院","专业"};
        /// 参数4： 到出Excel后的存放路径和文件名（其中是路径＋文件名）　例如：@"D:\MyExcel.xls"
        /// 调用本函数样例：clsGetExcelFromDatatable.GetExcelFromDataTable(objDT,ColumnNames,Title,@"D:\haha.xls");
        /// </summary>
        /// <param name="objDT"></param>
        /// <param name="ColumnsNameInDataTable"></param>
        /// <param name="FirstRowChineseNames"></param>
        /// <param name="SavePathAndName"></param>
        /// <returns></returns>
        public static bool GetExcelFromDataTable(System.Data.DataTable objDT, string[] ColumnsNameInDataTable, string[] FirstRowChineseNames, string SavePathAndName)
        {
            try
            {
                ExcelOperate excelOperate = new ExcelOperate();
                int intRowNum = objDT.Rows.Count;
                if (intRowNum == 0)
                {
                    throw new Exception("需要导出的记录数为0，不需要导出！");
                }
                int intColumnNum = objDT.Columns.Count;
                //2 通过循环来写入Excel
                string sFile;		//, sTemplate;
                Excel.Application oExcel = new Excel.Application();
                Excel.Workbook oBook = oExcel.Application.Workbooks.Add(true);
                Excel.Worksheet oSheet = (Excel.Worksheet)oBook.Sheets[1];
                oExcel.Visible = false;
                //写第一行排头
                for (int j = 0; j < FirstRowChineseNames.Length; j++)
                {
                    oSheet.Cells[1, j + 1] = FirstRowChineseNames[j];
                }

                //从Excel的第二行开始写DataTable

                //(2) 通过循环把ss[i,j]数组里的内容写入Excel
                for (int i = 0; i < intRowNum; i++)
                    for (int j = 0; j < intColumnNum; j++)
                    {
                        //						tt = ss[i,j];
                        if (objDT.Columns[j].DataType == System.Type.GetType("System.String"))
                        {
                            oSheet.Cells[i + 2, j + 1] = "'" + objDT.Rows[i][ColumnsNameInDataTable[j]].ToString();
                        }
                        else
                        {
                            oSheet.Cells[i + 2, j + 1] = objDT.Rows[i][ColumnsNameInDataTable[j]].ToString();
                        }
                    }


                oSheet.Name = "First Sheet"; //命名该sheet
                sFile = SavePathAndName;

                if (File.Exists(sFile))     //把文件存盘，如果存在了就先删除．
                {
                    File.Delete(sFile);
                }
                oSheet.SaveAs(sFile, Missing.Value, Missing.Value, Missing.Value, Missing.Value
                    , Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
                excelOperate.Dispose(oSheet, oBook, oExcel);
                return true;
            }

            catch (Exception objException)
            {
                LogErrorS(objException, "clsGetExcelFromDataTable");
                throw new Exception(objException.Message, objException);
            }
        }
        /// <summary>
        /// 使用EXCEL对象来导出文件
        /// </summary>
        /// <param name="objDT"></param>
        /// <param name="ColumnsNameInDataTable"></param>
        /// <param name="FirstRowChineseNames"></param>
        /// <param name="SavePathAndName"></param>
        /// <returns></returns>
        public static bool GetExcelFromDataTable2(System.Data.DataTable objDT, string[] ColumnsNameInDataTable, string[] FirstRowChineseNames, string SavePathAndName)
        {
          
            ExcelOperate excelOperate = new ExcelOperate();
            Excel.Application m_objExcel = null;
            Excel.Workbooks m_objBooks = null;
            Excel._Workbook m_objBook = null;
            Excel.Sheets m_objSheets = null;
            Excel._Worksheet m_objSheet = null;
            Excel.Range m_objRange = null;
            Excel.Font m_objFont = null;
            //Excel.QueryTables m_objQryTables = null;
            //Excel._QueryTable m_objQryTable = null;
            // Frequenty-used variable for optional arguments.
            object m_objOpt = System.Reflection.Missing.Value;

            try
            {

                int intRowNum = objDT.Rows.Count;
                if (intRowNum == 0)
                {
                    throw new Exception("需要导出的记录数为0，不需要导出！");
                }
                int intColumnNum = objDT.Columns.Count;
                //2 通过循环来写入Excel
                //string sFile;		//, sTemplate;
                m_objExcel = new Excel.Application();
                m_objBooks = (Excel.Workbooks)m_objExcel.Workbooks;
                m_objBook = (Excel._Workbook)(m_objBooks.Add(m_objOpt));
                m_objSheets = (Excel.Sheets)m_objBook.Worksheets;
                m_objSheet = (Excel._Worksheet)(m_objSheets.get_Item(1));

                // Create an array for the headers and add it to cells A1:C1.
                //			object[] objHeaders = {"Order ID", "Amount", "Tax"};
                object[] objHeaders = new object[intColumnNum];
                for (int j = 0; j < FirstRowChineseNames.Length; j++)
                {
                    objHeaders[j] = FirstRowChineseNames[j];
                }

                //			m_objRange = m_objSheet.get_Range("A1");
                m_objRange = m_objSheet.get_Range("A1", m_objOpt);
                m_objRange = m_objRange.get_Resize(1, FirstRowChineseNames.Length);
                //			m_objRange.set_Value(m_objOpt,objHeaders);
                m_objRange.set_Value(m_objOpt, objHeaders);
                m_objFont = m_objRange.Font;
                m_objFont.Bold = true;

                // Create an array with 3 columns and 100 rows and add it to
                // the worksheet starting at cell A2.
                object[,] objData = new Object[intRowNum, FirstRowChineseNames.Length];
                int iColNum = 0;

                for (int i = 0; i < intRowNum; i++)
                {
                    iColNum = 0;
                    foreach (string strColName in ColumnsNameInDataTable)
                    {
                        //						tt = ss[i,j];
                        if (objDT.Columns[strColName].DataType == System.Type.GetType("System.String"))
                        {
                            objData[i, iColNum] = "'" + objDT.Rows[i][strColName].ToString();
                        }
                        else
                        {
                            objData[i, iColNum] = objDT.Rows[i][strColName].ToString();
                        }
                        iColNum++;
                    }
                }

                m_objRange = m_objSheet.get_Range("A2", m_objOpt);
                m_objRange = m_objRange.get_Resize(intRowNum, FirstRowChineseNames.Length);
                m_objRange.set_Value(m_objOpt, objData);

                // Save the workbook and quit Excel.
                if (File.Exists(SavePathAndName) == true)
                {
                    File.Delete(SavePathAndName);
                }
                m_objBook.SaveAs(SavePathAndName, m_objOpt, m_objOpt,
                    m_objOpt, m_objOpt, m_objOpt, Excel.XlSaveAsAccessMode.xlNoChange,
                    m_objOpt, m_objOpt, m_objOpt, m_objOpt, m_objOpt);
                //m_objBook.Close(false, m_objOpt, m_objOpt);
                excelOperate.Dispose(m_objSheet, m_objBook, m_objExcel);
                //m_obj1Excel.Quit();
                return true;

            }

            catch (Exception objException)
            {
                LogErrorS(objException, "clsGetExcelFromDataTable");
                throw new Exception(objException.Message, objException);
            }


        }

        /// <summary>
        /// 使用EXCEL对象来导出文件
        /// </summary>
        /// <param name="objDT"></param>
        /// <param name="ColumnsNameInDataTable"></param>
        /// <param name="FirstRowChineseNames"></param>
        /// <param name="SavePathAndName"></param>
        /// <returns></returns>
        public static bool GetExcelFromDataTable2_ArrayList(System.Data.DataTable objDT, ArrayList ColumnsNameInDataTable, ArrayList FirstRowChineseNames, string SavePathAndName)
        {
            ExcelOperate excelOperate = new ExcelOperate();
            Excel.Application m_objExcel = null;
            Excel.Workbooks m_objBooks = null;
            Excel._Workbook m_objBook = null;
            Excel.Sheets m_objSheets = null;
            Excel._Worksheet m_objSheet = null;
            Excel.Range m_objRange = null;
            Excel.Font m_objFont = null;
            //Excel.QueryTables m_objQryTables = null;
            //Excel._QueryTable m_objQryTable = null;
            // Frequenty-used variable for optional arguments.
            object m_objOpt = System.Reflection.Missing.Value;

            try
            {

                int intRowNum = objDT.Rows.Count;
                if (intRowNum == 0)
                {
                    throw new Exception("需要导出的记录数为0，不需要导出！");
                }
                int intColumnNum = objDT.Columns.Count;
                //2 通过循环来写入Excel
                //string sFile;		//, sTemplate;
                m_objExcel = new Excel.Application();
                m_objBooks = (Excel.Workbooks)m_objExcel.Workbooks;
                m_objBook = (Excel._Workbook)(m_objBooks.Add(m_objOpt));
                m_objSheets = (Excel.Sheets)m_objBook.Worksheets;
                m_objSheet = (Excel._Worksheet)(m_objSheets.get_Item(1));

                // Create an array for the headers and add it to cells A1:C1.
                //			object[] objHeaders = {"Order ID", "Amount", "Tax"};
                object[] objHeaders = new object[intColumnNum];
                int intMinColumnNum = Math.Min(intColumnNum, FirstRowChineseNames.Count);
                for (int j = 0; j < intMinColumnNum; j++)
                {
                    try
                    {
                        objHeaders[j] = FirstRowChineseNames[j];
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("第{0}个行中文名出错。{1}.", j, objException.Message);
                        throw new Exception(strMsg);
                    }
                }
                //for (int j = 0; j < FirstRowChineseNames1.Count; j++)
                //{
                //    objHeaders[j] = FirstRowChineseNames[j];
                //}

                //			m_objRange = m_objSheet.get_Range("A1");
                m_objRange = m_objSheet.get_Range("A1", m_objOpt);
                m_objRange = m_objRange.get_Resize(1, intMinColumnNum);
                //			m_objRange.set_Value(m_objOpt,objHeaders);
                m_objRange.set_Value(m_objOpt, objHeaders);
                m_objFont = m_objRange.Font;
                m_objFont.Bold = true;

                // Create an array with 3 columns and 100 rows and add it to
                // the worksheet starting at cell A2.
                object[,] objData = new Object[intRowNum, intMinColumnNum];
                int iColNum = 0;

                for (int i = 0; i < intRowNum; i++)
                {
                    iColNum = 0;
                    foreach (string strColName in ColumnsNameInDataTable)
                    {
                        //						tt = ss[i,j];
                        if (objDT.Columns[strColName].DataType == System.Type.GetType("System.String"))
                        {
                            objData[i, iColNum] = "'" + objDT.Rows[i][strColName].ToString();
                        }
                        else
                        {
                            objData[i, iColNum] = objDT.Rows[i][strColName].ToString();
                        }
                        iColNum++;
                    }
                }

                m_objRange = m_objSheet.get_Range("A2", m_objOpt);
                m_objRange = m_objRange.get_Resize(intRowNum, FirstRowChineseNames.Count);
                m_objRange.set_Value(m_objOpt, objData);

                // Save the workbook and quit Excel.
                if (File.Exists(SavePathAndName) == true)
                {
                    File.Delete(SavePathAndName);
                }
                m_objBook.SaveAs(SavePathAndName, m_objOpt, m_objOpt,
                    m_objOpt, m_objOpt, m_objOpt, Excel.XlSaveAsAccessMode.xlNoChange,
                    m_objOpt, m_objOpt, m_objOpt, m_objOpt, m_objOpt);
                //m_objBook.Close(false, m_objOpt, m_objOpt);
                excelOperate.Dispose(m_objSheet, m_objBook, m_objExcel);
                //m_obj1Excel.Quit();
                return true;

            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsGetExcelFromDataTable");
                throw new Exception(objException.Message, objException);
            }
        }


        /// <summary>
        /// 使用EXCEL对象来导出文件
        /// </summary>
        /// <param name="objDT"></param>
        /// <param name="ColumnsNameInDataTable"></param>
        /// <param name="FirstRowChineseNames"></param>
        /// <param name="SavePathAndName"></param>
        /// <returns></returns>
        public static bool GetExcelFromDataTable2_List(System.Data.DataTable objDT, List<string> ColumnsNameInDataTable, List<string> FirstRowChineseNames, string SavePathAndName)
        {
            ExcelOperate excelOperate = new ExcelOperate();
            Excel.Application m_objExcel = null;
            Excel.Workbooks m_objBooks = null;
            Excel._Workbook m_objBook = null;
            Excel.Sheets m_objSheets = null;
            Excel._Worksheet m_objSheet = null;
            Excel.Range m_objRange = null;
            Excel.Font m_objFont = null;
            //Excel.QueryTables m_objQryTables = null;
            //Excel._QueryTable m_objQryTable = null;
            // Frequenty-used variable for optional arguments.
            object m_objOpt = System.Reflection.Missing.Value;

            try
            {

                int intRowNum = objDT.Rows.Count;
                if (intRowNum == 0)
                {
                    throw new Exception("需要导出的记录数为0，不需要导出！");
                }
                int intColumnNum = objDT.Columns.Count;
                //2 通过循环来写入Excel
                //string sFile;		//, sTemplate;
                m_objExcel = new Excel.Application();
                m_objBooks = (Excel.Workbooks)m_objExcel.Workbooks;
                m_objBook = (Excel._Workbook)(m_objBooks.Add(m_objOpt));
                m_objSheets = (Excel.Sheets)m_objBook.Worksheets;
                m_objSheet = (Excel._Worksheet)(m_objSheets.get_Item(1));

                // Create an array for the headers and add it to cells A1:C1.
                //			object[] objHeaders = {"Order ID", "Amount", "Tax"};
                object[] objHeaders = new object[intColumnNum];
                int intMinColumnNum = Math.Min(intColumnNum, FirstRowChineseNames.Count);
                for (int j = 0; j < intMinColumnNum; j++)
                {
                    try
                    {
                        objHeaders[j] = FirstRowChineseNames[j];
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("第{0}个行中文名出错。{1}.", j, objException.Message);
                        throw new Exception(strMsg);
                    }
                }
              

                //			m_objRange = m_objSheet.get_Range("A1");
                m_objRange = m_objSheet.get_Range("A1", m_objOpt);
                m_objRange = m_objRange.get_Resize(1, intMinColumnNum);
                //			m_objRange.set_Value(m_objOpt,objHeaders);
                m_objRange.set_Value(m_objOpt, objHeaders);
                m_objFont = m_objRange.Font;
                m_objFont.Bold = true;

                // Create an array with 3 columns and 100 rows and add it to
                // the worksheet starting at cell A2.
                object[,] objData = new Object[intRowNum, intMinColumnNum];
                int iColNum = 0;

                for (int i = 0; i < intRowNum; i++)
                {
                    iColNum = 0;
                    foreach (string strColName in ColumnsNameInDataTable)
                    {
                        try
                        {
                            //						tt = ss[i,j];
                            if (objDT.Columns[strColName].DataType == System.Type.GetType("System.String"))
                            {
                                objData[i, iColNum] = "'" + objDT.Rows[i][strColName].ToString();
                            }
                            else
                            {
                                objData[i, iColNum] = objDT.Rows[i][strColName].ToString();
                            }
                            iColNum++;
                            if (iColNum >= intMinColumnNum - 1) continue;
                        }
                        catch (Exception objException)
                        {
                            string strMsg = string.Format("第{0}个列名出错。{1}.", strColName, objException.Message);
                            throw new Exception(strMsg);
                        }
                    }
                }

                m_objRange = m_objSheet.get_Range("A2", m_objOpt);
                m_objRange = m_objRange.get_Resize(intRowNum, intMinColumnNum);
                m_objRange.set_Value(m_objOpt, objData);

                // Save the workbook and quit Excel.
                if (File.Exists(SavePathAndName) == true)
                {
                    File.Delete(SavePathAndName);
                }
                m_objBook.SaveAs(SavePathAndName, m_objOpt, m_objOpt,
                    m_objOpt, m_objOpt, m_objOpt, Excel.XlSaveAsAccessMode.xlNoChange,
                    m_objOpt, m_objOpt, m_objOpt, m_objOpt, m_objOpt);
                //m_objBook.Close(false, m_objOpt, m_objOpt);
                excelOperate.Dispose(m_objSheet, m_objBook, m_objExcel);
                //m_obj1Excel.Quit();
                return true;

            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsGetExcelFromDataTable");
                throw new Exception(objException.Message, objException);
            }
        }


        /// <summary>
        /// 通过EXCEL对象来导出Excel,通过DataTable, 通过字段列表
        /// </summary>
        /// <param name="objDT">提供的DataTable</param>
        /// <param name="ColumnsNameInDataTable">导出的列名</param>
        /// <param name="FirstRowChineseNames">第一行的中文标题名称</param>
        /// <param name="SavePathAndName">保存的路径文件名</param>
        /// <returns></returns>
        public static bool GetExcelFromDataTableByArr(System.Data.DataTable objDT,
            ArrayList ColumnsNameInDataTable,
            ArrayList FirstRowChineseNames,
            string SavePathAndName)
        {
            if (CheckColumnsNameIsExist(objDT, ColumnsNameInDataTable) == false)
            {
                return false;
            }

            try
            {
                ExcelOperate excelOperate = new ExcelOperate();
                int intRowNum = objDT.Rows.Count;
                if (intRowNum == 0)
                {
                    throw new Exception("需要导出的记录数为0，不需要导出！");
                }
                int intColumnNum = objDT.Columns.Count;
                //2 通过循环来写入Excel
                string sFile;		//, sTemplate;
                Excel.Application oExcel = new Excel.Application();
                Excel.Workbook oBook = oExcel.Application.Workbooks.Add(true);
                Excel.Worksheet oSheet = (Excel.Worksheet)oBook.Sheets[1];
                oExcel.Visible = false;
                //写第一行排头
                int iColNum = 0;
                foreach (string strHeader in FirstRowChineseNames)
                {
                    oSheet.Cells[1, iColNum + 1] = strHeader;
                    iColNum++;
                }

                //从Excel的第二行开始写DataTable

                //(2) 通过循环把ss[i,j]数组里的内容写入Excel
                for (int i = 0; i < intRowNum; i++)
                {
                    iColNum = 0;
                    foreach (string strColName in ColumnsNameInDataTable)
                    {
                        //						tt = ss[i,j];
                        if (objDT.Columns[strColName].DataType == System.Type.GetType("System.String"))
                        {
                            oSheet.Cells[i + 2, iColNum + 1] = "'" + objDT.Rows[i][strColName].ToString();
                        }
                        else
                        {
                            oSheet.Cells[i + 2, iColNum + 1] = objDT.Rows[i][strColName].ToString();
                        }
                        iColNum++;
                    }
                }

                oSheet.Name = "First Sheet"; //命名该sheet
                sFile = SavePathAndName;

                if (File.Exists(sFile))     //把文件存盘，如果存在了就先删除．
                {
                    File.Delete(sFile);
                }
                oSheet.SaveAs(sFile, Missing.Value, Missing.Value, Missing.Value, Missing.Value
                    , Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
                //oBook.Close(Missing.Value, Missing.Value, Missing.Value);
                // o1Excel.Quit();
                excelOperate.Dispose(oSheet, oBook, oExcel);
                return true;
            }

            catch (Exception objException)
            {
                LogErrorS(objException, "clsGetExcelFromDataTable");
                throw new Exception(objException.Message, objException);
            }
        }

        /// <summary>
        /// 通过EXCEL对象来导出Excel,通过DataTable, 通过字段列表
        /// 潘以锋
        /// 修改日期：2008-12-31
        /// </summary>
        /// <param name="objDT">提供的DataTable</param>
        /// <param name="ColumnsNameInDataTable">导出的列名</param>
        /// <param name="FirstRowChineseNames">第一行的中文标题名称</param>
        /// <param name="SavePathAndName">保存的路径文件名</param>
        /// <param name="strTitle">标题</param>
        /// <param name="strSheetName">工作表名称</param>
        /// <returns></returns>
        public static bool GetExcelFromDataTableByArr(System.Data.DataTable objDT,
            ArrayList ColumnsNameInDataTable,
            ArrayList FirstRowChineseNames,
            string SavePathAndName,
            string strTitle,
            string strSheetName)
        {
            if (CheckColumnsNameIsExist(objDT, ColumnsNameInDataTable) == false)
            {
                return false;
            }

            try
            {
                ExcelOperate excelOperate = new ExcelOperate();
                int intRowNum = objDT.Rows.Count;
                if (intRowNum == 0)
                {
                    throw new Exception("需要导出的记录数为0，不需要导出！");
                }
                int intColumnNum = objDT.Columns.Count;
                //2 通过循环来写入Excel
                string sFile;		//, sTemplate;
                Excel.Application oExcel = new Excel.Application();
                Excel.Workbook oBook = oExcel.Application.Workbooks.Add(true);
                Excel.Worksheet oSheet = (Excel.Worksheet)oBook.Sheets[1];
                oExcel.Visible = false;
                //写标题
                oSheet.Cells[1, 1] = strTitle;

                //写第一行排头
                int iColNum = 0;
                foreach (string strHeader in FirstRowChineseNames)
                {
                    oSheet.Cells[2, iColNum + 1] = strHeader;
                    iColNum++;
                }

                //从Excel的第二行开始写DataTable

                //(2) 通过循环把ss[i,j]数组里的内容写入Excel
                for (int i = 0; i < intRowNum; i++)
                {
                    iColNum = 0;
                    foreach (string strColName in ColumnsNameInDataTable)
                    {
                        //						tt = ss[i,j];
                        if (objDT.Columns[strColName].DataType == System.Type.GetType("System.String"))
                        {
                            oSheet.Cells[i + 3, iColNum + 1] = "'" + objDT.Rows[i][strColName].ToString();
                        }
                        else
                        {
                            oSheet.Cells[i + 3, iColNum + 1] = objDT.Rows[i][strColName].ToString();
                        }
                        iColNum++;
                    }
                }

                if (string.IsNullOrEmpty(strSheetName) == true)
                {
                    oSheet.Name = "First Sheet"; //命名该sheet
                }
                else
                {
                    oSheet.Name = strSheetName;  //命名该sheet
                }
                sFile = SavePathAndName;

                if (File.Exists(sFile))     //把文件存盘，如果存在了就先删除．
                {
                    File.Delete(sFile);
                }
                oSheet.SaveAs(sFile, Missing.Value, Missing.Value, Missing.Value, Missing.Value
                    , Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
                //oBook.Close(Missing.Value, Missing.Value, Missing.Value);

                // oExcel.Dispose(oSheet, oBook, app);//关闭Excel进程 
                excelOperate.Dispose(oSheet, oBook, oExcel);
                //o1Excel.Quit();
                return true;
            }

            catch (Exception objException)
            {
                LogErrorS(objException, "clsGetExcelFromDataTable");
                throw new Exception(objException.Message, objException);
            }
        }

      

        /// <summary>
        /// 把DataTable导出到StringWriter数据流中，字段分隔用'\t'
        /// </summary>
        /// <param name="objDT">数据源DataTable</param>
        /// <param name="ColumnsNameInDataTable">从DataTable中选取的字段列表</param>
        /// <param name="FirstRowChineseNames">首行的标题列表</param>
        /// <param name="sw">StringWriter数据流</param>
        /// <returns>是否成功？</returns>
        public static bool GetExcelFromDataTableByArr2Bak201211101(System.Data.DataTable objDT,
            ArrayList ColumnsNameInDataTable,
            ArrayList FirstRowChineseNames,
            System.IO.StringWriter sw)
        {
            if (CheckColumnsNameIsExist(objDT, ColumnsNameInDataTable) == false)
            {
                return false;
            }

            try
            {
                int intRowNum = objDT.Rows.Count;
                if (intRowNum == 0)
                {
                    throw new Exception("需要导出的记录数为0，不需要导出！");
                }
                //				int intColumnNum = objDT.Columns.Count;
                //2 通过循环来写入Excel
                //				string sFile;		//, sTemplate;
                //				Excel.ApplicationClass oExcel = new Excel.ApplicationClass();	
                //				Excel.Workbook oBook = oExcel.Application.Workbooks.Add(true);
                //				Excel.Worksheet oSheet =(Excel.Worksheet) oBook.Sheets[1];
                //				oExcel.Visible = false;
                //写第一行排头
                //				int iColNum = 0;

                //				string data1 = "000000001";
                //				long data2 = 123456789123456789;
                ////				System.IO.StringWriter sw = new System.IO.StringWriter();
                //				sw.WriteLine("原数字1\t转换后数字1\t原数字2\t转换数字2");
                //				for(int i= 0;i<10000;i++)
                //				{
                //					sw.WriteLine(data1 +"\t" + "=\"" + data1 + "\"\t" + data2 +"\t" + "=\"" + data2.ToString() + "\"");
                //				}
                //				sw.Close();
                //				Response.Buffer= true;
                //				Response.Charset="";
                //				Response.AppendHeader("Content-Disposition","attachment;filename=aa.xls");
                //				Response.ContentType = "application/ms-excel";//设置输出文件类型为excel文件。 
                //				Response.ContentEncoding=System.Text.Encoding.GetEncoding("GB2312");//设置输出流为简体中文
                //				Response.Write(sw);
                //				Response.End();

                StringBuilder strLine = new StringBuilder();
                foreach (string strHeader in FirstRowChineseNames)
                {
                    strLine.Append(strHeader + "\t");
                    //					iColNum ++;
                }
                sw.WriteLine(strLine.ToString());

                //从Excel的第二行开始写DataTable

                //(2) 通过循环把ss[i,j]数组里的内容写入Excel

                for (int i = 0; i < intRowNum; i++)
                {
                    //					iColNum = 0;
                    strLine = new StringBuilder();
                    foreach (string strColName in ColumnsNameInDataTable)
                    {
                        string strTemp = objDT.Rows[i][strColName].ToString();
                        strTemp = strTemp.Replace("\r\n", "  ");
                        strTemp = strTemp.Replace("\n\r", "  ");
                        strTemp = strTemp.Replace("\t", " ");
                        strLine.Append("=\"" + strTemp + "\"\t");
                        //						iColNum ++;
                    }
                    sw.WriteLine(strLine.ToString());
                }
                sw.Close();

                //				oSheet.Name = "First Sheet"; //命名该sheet
                //				sFile = SavePathAndName;
                //            
                //				if (File.Exists(sFile))     //把文件存盘，如果存在了就先删除．
                //				{
                //					File.Delete(sFile);
                //				}
                //				oSheet.SaveAs(sFile, Missing.Value, Missing.Value, Missing.Value, Missing.Value
                //					,Missing.Value,Missing.Value,Missing.Value,Missing.Value,Missing.Value);
                //				oBook.Close(Missing.Value,Missing.Value,Missing.Value);
                //				oExcel.Quit();		
                return true;
            }

            catch (Exception objException)
            {
                LogErrorS(objException, "GetExcelFromDataTableByArr2");
                return false;
            }
        }

        /// <summary>
        /// 无须EXCEL对象， 把DataTable导出到StringWriter数据流中，字段分隔用'\t'
        /// </summary>
        /// <param name="objDT">数据源DataTable</param>
        /// <param name="ColumnsNameInDataTable">从DataTable中选取的字段列表</param>
        /// <param name="FirstRowChineseNames">首行的标题列表</param>
        /// <param name="SavePathAndName">保存的路径文件名</param>
        /// <returns>是否成功？</returns>
        public static bool GetExcelFromDataTableByArr_StringWriter(System.Data.DataTable objDT,
            ArrayList ColumnsNameInDataTable,
            ArrayList FirstRowChineseNames,
            string SavePathAndName)
        {
            //System.IO.StringWriter sw = new StringWriter();
            if (CheckColumnsNameIsExist(objDT, ColumnsNameInDataTable) == false)
            {
                return false;
            }
            if (File.Exists(SavePathAndName))
            {
                File.Delete(SavePathAndName);
            }
            FileStream fileWriter = new FileStream(SavePathAndName, FileMode.CreateNew, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileWriter, System.Text.Encoding.Unicode, 1024);
            StringBuilder fileBuilder = new StringBuilder();
            StringWriter stringWriter = new StringWriter(fileBuilder);

            //其他代码是往stringWriter里写入文本以及或替换文本   


            try
            {
                int intRowNum = objDT.Rows.Count;
                if (intRowNum == 0)
                {
                    throw new Exception("需要导出的记录数为0，不需要导出！");
                }
                StringBuilder strLine = new StringBuilder();
                foreach (string strHeader in FirstRowChineseNames)
                {
                    strLine.Append(strHeader + "\t");
                }
                stringWriter.WriteLine(strLine.ToString());

                //从Excel的第二行开始写DataTable

                //(2) 通过循环把ss[i,j]数组里的内容写入Excel

                for (int i = 0; i < intRowNum; i++)
                {
                    //					iColNum = 0;
                    strLine = new StringBuilder();
                    foreach (string strColName in ColumnsNameInDataTable)
                    {
                        string strTemp = objDT.Rows[i][strColName].ToString().Trim();
                        strTemp = strTemp.Replace("\r\n", "  ");
                        strTemp = strTemp.Replace("\n\r", "  ");
                        strTemp = strTemp.Replace("\r", " ");
                        strTemp = strTemp.Replace("\n", " ");
                        strTemp = strTemp.Replace("\t", " ");
                        strLine.Append("=\"" + strTemp + "\"\t");
                    }
                    stringWriter.WriteLine(strLine.ToString());
                }

                string fileContent = stringWriter.ToString();
                stringWriter.Close();
                stringWriter.Dispose();
                streamWriter.WriteLine(fileContent);
                streamWriter.Close();
                streamWriter.Dispose();
                fileWriter.Close();
                fileWriter.Dispose();

                return true;
            }

            catch (Exception objException)
            {
                LogErrorS(objException, "GetExcelFromDataTableByArr2");
                return false;
            }
        }

        /// <summary>
        /// 通过EXCEL对象，使用“自动化”将数据数组传输到工作表上的区域
        /// </summary>
        /// <param name="objDT">DataTable数据</param>
        /// <param name="ColumnsNameInDataTable">需要导出的字段列名</param>
        /// <param name="FirstRowChineseNames">导出EXCEL的标题行字段名</param>
        /// <param name="SavePathAndName">保存的路径及文件名</param>
        /// <returns>是否成功</returns>
        public bool GetExcelFromDataTableByArrAndArray(System.Data.DataTable objDT,
            ArrayList ColumnsNameInDataTable,
            ArrayList FirstRowChineseNames,
            string SavePathAndName
            )
        {
            if (CheckColumnsNameIsExist(objDT, ColumnsNameInDataTable) == false)
            {
                return false;
            }
            //行数
            int intRowNum = objDT.Rows.Count;
            if (intRowNum == 0)
            {
                throw new Exception("需要导出的记录数为0，不需要导出！");
            }
            //列数
            int intColumnNum = objDT.Columns.Count;
            //2 通过循环来写入Excel
            //string sFile;		//, sTemplate;
            m_objExcel = new Excel.Application();
            m_objBooks = (Excel.Workbooks)m_objExcel.Workbooks;
            m_objBook = (Excel._Workbook)(m_objBooks.Add(m_objOpt));
            m_objSheets = (Excel.Sheets)m_objBook.Worksheets;
            m_objSheet = (Excel._Worksheet)(m_objSheets.get_Item(1));

            // Create an array for the headers and add it to cells A1:C1.
            //			object[] objHeaders = {"Order ID", "Amount", "Tax"};
            object[] objHeaders = new object[intColumnNum];

            int intMinColumnNum = Math.Min(intColumnNum, FirstRowChineseNames.Count);
            for (int j = 0; j < intMinColumnNum; j++)
            {
                try
                {
                    objHeaders[j] = FirstRowChineseNames[j];
                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("第{0}个行中文名出错。{1}.", j, objException.Message);
                    throw new Exception(strMsg);
                }
            }
            //for (int i = 0; i < FirstRowChineseNames1.Count; i++)
            //{
            //    objHeaders[i] = FirstRowChineseNames[i];
            //}
            //			m_objRange = m_objSheet.get_Range("A1");
            m_objRange = m_objSheet.get_Range("A1", m_objOpt);
            m_objRange = m_objRange.get_Resize(1, intColumnNum);
            //			m_objRange.set_Value(m_objOpt,objHeaders);
            m_objRange.set_Value(m_objOpt, objHeaders);
            m_objFont = m_objRange.Font;
            m_objFont.Bold = true;

            // Create an array with 3 columns and 100 rows and add it to
            // the worksheet starting at cell A2.
            object[,] objData = new Object[intRowNum, intColumnNum];
            //			Random rdm = new Random((int)DateTime.Now.Ticks);
            //			double nOrderAmt, nTax;
            //			for(int r=0;r<100;r++)
            //			{
            //				objData[r,0] = "ORD" + r.ToString("0000");
            //				nOrderAmt = rdm.Next(1000);
            //				objData[r,1] = nOrderAmt.ToString("c");
            //				nTax = nOrderAmt*0.07;
            //				objData[r,2] = nTax.ToString("c");
            //			}
            int iColNum = 0;

            for (int i = 0; i < intRowNum; i++)
            {
                iColNum = 0;
                foreach (string strColName in ColumnsNameInDataTable)
                {
                    //						tt = ss[i,j];

                    if (objDT.Columns[strColName].DataType == System.Type.GetType("System.String"))
                    {
                        objData[i, iColNum] = "'" + objDT.Rows[i][strColName].ToString();
                    }
                    else
                    {
                        objData[i, iColNum] = objDT.Rows[i][strColName].ToString();
                    }
                    iColNum++;
                }
            }
            m_objRange = m_objSheet.get_Range("A2", m_objOpt);
            m_objRange = m_objRange.get_Resize(intRowNum, intColumnNum);
            m_objRange.set_Value(m_objOpt, objData);

            // Save the workbook and quit Excel.
            if (File.Exists(SavePathAndName) == true)
            {
                File.Delete(SavePathAndName);
            }
            m_objBook.SaveAs(SavePathAndName, m_objOpt, m_objOpt,
                m_objOpt, m_objOpt, m_objOpt, Excel.XlSaveAsAccessMode.xlNoChange,
                m_objOpt, m_objOpt, m_objOpt, m_objOpt, m_objOpt);
            m_objBook.Close(false, m_objOpt, m_objOpt);
            m_objExcel.Quit();
            return true;
        }

        /// <summary>
        /// 通过EXCEL对象，使用“自动化”将数据数组传输到工作表上的区域
        /// </summary>
        /// <param name="objDT">DataTable数据</param>
        /// <param name="ColumnsNameInDataTable">需要导出的字段列名</param>
        /// <param name="FirstRowChineseNames">导出EXCEL的标题行字段名</param>
        /// <param name="SavePathAndName">保存的路径及文件名</param>
        /// <param name="strTitle">标题行标题</param>
        /// <returns>是否成功</returns>
        public bool GetExcelFromDataTableByArrAndArray(System.Data.DataTable objDT,
            ArrayList ColumnsNameInDataTable,
            ArrayList FirstRowChineseNames,
            string SavePathAndName,
             string strTitle
            )
        {
            if (CheckColumnsNameIsExist(objDT, ColumnsNameInDataTable) == false)
            {
                return false;
            }
            //行数
            int intRowNum = objDT.Rows.Count;
            if (intRowNum == 0)
            {
                throw new Exception("需要导出的记录数为0，不需要导出！");
            }
            //列数
            int intColumnNum = objDT.Columns.Count;
            //2 通过循环来写入Excel
            //string sFile;		//, sTemplate;
            m_objExcel = new Excel.Application();
            m_objBooks = (Excel.Workbooks)m_objExcel.Workbooks;
            m_objBook = (Excel._Workbook)(m_objBooks.Add(m_objOpt));
            m_objSheets = (Excel.Sheets)m_objBook.Worksheets;
            m_objSheet = (Excel._Worksheet)(m_objSheets.get_Item(1));

            // Create an array for the headers and add it to cells A1:C1.
            //			object[] objHeaders = {"Order ID", "Amount", "Tax"};
            //写标题
            m_objSheet.Cells[1, 1] = strTitle;

            object[] objHeaders = new object[intColumnNum];
            int intMinColumnNum = Math.Min(intColumnNum, FirstRowChineseNames.Count);
            for (int j = 0; j < intMinColumnNum; j++)
            {
                try
                {
                    objHeaders[j] = FirstRowChineseNames[j];
                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("第{0}个行中文名出错。{1}.", j, objException.Message);
                    throw new Exception(strMsg);
                }
            }
            //for (int i = 0; i < FirstRowChineseNames1.Count; i++)
            //{
            //    objHeaders[i] = FirstRowChineseNames[i];
            //}
            //			m_objRange = m_objSheet.get_Range("A1");
            m_objRange = m_objSheet.get_Range("A2", m_objOpt);
            m_objRange = m_objRange.get_Resize(1, intColumnNum);
            //			m_objRange.set_Value(m_objOpt,objHeaders);
            m_objRange.set_Value(m_objOpt, objHeaders);
            m_objFont = m_objRange.Font;
            m_objFont.Bold = true;

            // Create an array with 3 columns and 100 rows and add it to
            // the worksheet starting at cell A2.
            object[,] objData = new Object[intRowNum, intColumnNum];
            //			Random rdm = new Random((int)DateTime.Now.Ticks);
            //			double nOrderAmt, nTax;
            //			for(int r=0;r<100;r++)
            //			{
            //				objData[r,0] = "ORD" + r.ToString("0000");
            //				nOrderAmt = rdm.Next(1000);
            //				objData[r,1] = nOrderAmt.ToString("c");
            //				nTax = nOrderAmt*0.07;
            //				objData[r,2] = nTax.ToString("c");
            //			}
            int iColNum = 0;

            for (int i = 0; i < intRowNum; i++)
            {
                iColNum = 0;
                foreach (string strColName in ColumnsNameInDataTable)
                {
                    //						tt = ss[i,j];

                    if (objDT.Columns[strColName].DataType == System.Type.GetType("System.String"))
                    {
                        objData[i, iColNum] = "'" + objDT.Rows[i][strColName].ToString();
                    }
                    else
                    {
                        objData[i, iColNum] = objDT.Rows[i][strColName].ToString();
                    }
                    iColNum++;
                }
            }
            m_objRange = m_objSheet.get_Range("A3", m_objOpt);
            m_objRange = m_objRange.get_Resize(intRowNum, intColumnNum);
            m_objRange.set_Value(m_objOpt, objData);

            // Save the workbook and quit Excel.
            if (File.Exists(SavePathAndName) == true)
            {
                File.Delete(SavePathAndName);
            }
            m_objBook.SaveAs(SavePathAndName, m_objOpt, m_objOpt,
                m_objOpt, m_objOpt, m_objOpt, Excel.XlSaveAsAccessMode.xlNoChange,
                m_objOpt, m_objOpt, m_objOpt, m_objOpt, m_objOpt);
            m_objBook.Close(false, m_objOpt, m_objOpt);
            m_objExcel.Quit();
            return true;

        }
        /// <summary>
        /// 把DataTable导成Excel文件．本函数有４个参数
        /// 参数1： 要导出的DataTable
        /// 参数2： 要到出的DataTable中列的名字（列名，不是中文名称）放在一个string 数组中. 申明数组样例：string[] ColumnNames = new string[5] {"XH","XM","XBMC","XYMC","ZYMC"};
        /// 参数3： 导出的Excel中第一行的中文名称数组．　申明数组样例：string[] Title = new string[5] {"学号","姓名","专业","学院","专业"};
        /// 参数4： 到出Excel后的存放路径和文件名（其中是路径＋文件名）　例如：@"D:\MyExcel.xls"
        /// 调用本函数样例：clsGetExcelFromDatatable.GetExcelFromDataTable(objDT,ColumnNames,Title,@"D:\haha.xls");
        /// </summary>
        /// <param name="objDT"></param>
        /// <param name="ColumnsNameInDataTable"></param>
        /// <param name="FirstRowChineseNames"></param>
        /// <param name="SavePathAndName"></param>
        /// <returns></returns>
        public static bool TestExcel(string SavePathAndName)
        {
            try
            {
                ExcelOperate excelOperate = new ExcelOperate();
                int intRowNum = 10;
                int intColumnNum = 10;
                //2 通过循环来写入Excel
                string sFile;		//, sTemplate;
                Excel.Application oExcel = new Excel.Application();
                Excel.Workbook oBook = oExcel.Application.Workbooks.Add(true);
                Excel.Worksheet oSheet = (Excel.Worksheet)oBook.Sheets[1];
                oExcel.Visible = false;
                //写第一行排头
                for (int j = 0; j < intColumnNum; j++)
                {
                    oSheet.Cells[1, j + 1] = "HH";
                }

                //从Excel的第二行开始写DataTable

                //(2) 通过循环把ss[i,j]数组里的内容写入Excel
                for (int i = 0; i < intRowNum; i++)
                    for (int j = 0; j < intColumnNum; j++)
                    {

                        oSheet.Cells[i + 2, j + 1] = "DATA";

                    }


                oSheet.Name = "First Sheet"; //命名该sheet
                sFile = SavePathAndName;

                if (File.Exists(sFile))     //把文件存盘，如果存在了就先删除．
                {
                    File.Delete(sFile);
                }
                oSheet.SaveAs(sFile, Missing.Value, Missing.Value, Missing.Value, Missing.Value
                    , Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
                excelOperate.Dispose(oSheet, oBook, oExcel);
                return true;
            }

            catch (Exception objException)
            {
                LogErrorS(objException, "clsGetExcelFromDataTable");
                throw new Exception(objException.Message, objException);
            }
        }

    }
}
