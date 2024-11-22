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
    /// Class1 ��ժҪ˵����
    /// </summary>
    public partial class clsGetExcelFromDataTable
    {

        /// <summary>
        /// ͨ��EXCEL����������Excel,ͨ��DataTable, ͨ���ֶ��б�
        /// </summary>
        /// <param name="objDT">�ṩ��DataTable</param>
        /// <param name="ColumnsNameInDataTable">����������</param>
        /// <param name="FirstRowChineseNames">��һ�е����ı�������</param>
        /// <param name="SavePathAndName">�����·���ļ���</param>
        /// <returns></returns>
        public static bool GetExcelFromDataTableByArr(System.Data.DataTable objDT,
            List<string> ColumnsNameInDataTable,
            List<string> FirstRowChineseNames,
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
                    throw new Exception("��Ҫ�����ļ�¼��Ϊ0������Ҫ������");
                }
                int intColumnNum = objDT.Columns.Count;
                //2 ͨ��ѭ����д��Excel
                string sFile;		//, sTemplate;
                Excel.Application oExcel = new Excel.Application();
                Excel.Workbook oBook = oExcel.Application.Workbooks.Add(true);
                Excel.Worksheet oSheet = (Excel.Worksheet)oBook.Sheets[1];
                oExcel.Visible = false;
                //д��һ����ͷ
                int iColNum = 0;
                foreach (string strHeader in FirstRowChineseNames)
                {
                    oSheet.Cells[1, iColNum + 1] = strHeader;
                    iColNum++;
                }

                //��Excel�ĵڶ��п�ʼдDataTable

                //(2) ͨ��ѭ����ss[i,j]�����������д��Excel
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

                oSheet.Name = "First Sheet"; //������sheet
                sFile = SavePathAndName;

                if (File.Exists(sFile))     //���ļ����̣���������˾���ɾ����
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
        /// ͨ��EXCEL����������Excel,ͨ��DataTable, ͨ���ֶ��б�
        /// ���Է�
        /// �޸����ڣ�2008-12-31
        /// </summary>
        /// <param name="objDT">�ṩ��DataTable</param>
        /// <param name="ColumnsNameInDataTable">����������</param>
        /// <param name="FirstRowChineseNames">��һ�е����ı�������</param>
        /// <param name="SavePathAndName">�����·���ļ���</param>
        /// <param name="strTitle">����</param>
        /// <param name="strSheetName">����������</param>
        /// <returns></returns>
        public static bool GetExcelFromDataTableByArr(System.Data.DataTable objDT,
            List<string> ColumnsNameInDataTable,
            List<string> FirstRowChineseNames,
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
                    throw new Exception("��Ҫ�����ļ�¼��Ϊ0������Ҫ������");
                }
                int intColumnNum = objDT.Columns.Count;
                //2 ͨ��ѭ����д��Excel
                string sFile;		//, sTemplate;
                Excel.Application oExcel = new Excel.Application();
                Excel.Workbook oBook = oExcel.Application.Workbooks.Add(true);
                Excel.Worksheet oSheet = (Excel.Worksheet)oBook.Sheets[1];
                oExcel.Visible = false;
                //д����
                oSheet.Cells[1, 1] = strTitle;

                //д��һ����ͷ
                int iColNum = 0;
                foreach (string strHeader in FirstRowChineseNames)
                {
                    oSheet.Cells[2, iColNum + 1] = strHeader;
                    iColNum++;
                }

                //��Excel�ĵڶ��п�ʼдDataTable

                //(2) ͨ��ѭ����ss[i,j]�����������д��Excel
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
                    oSheet.Name = "First Sheet"; //������sheet
                }
                else
                {
                    oSheet.Name = strSheetName;  //������sheet
                }
                sFile = SavePathAndName;

                if (File.Exists(sFile))     //���ļ����̣���������˾���ɾ����
                {
                    File.Delete(sFile);
                }
                oSheet.SaveAs(sFile, Missing.Value, Missing.Value, Missing.Value, Missing.Value
                    , Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
                //oBook.Close(Missing.Value, Missing.Value, Missing.Value);

                // oExcel.Dispose(oSheet, oBook, app);//�ر�Excel���� 
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
        /// ��DataTable������StringWriter�������У��ֶηָ���'\t'
        /// </summary>
        /// <param name="objDT">����ԴDataTable</param>
        /// <param name="ColumnsNameInDataTable">��DataTable��ѡȡ���ֶ��б�</param>
        /// <param name="FirstRowChineseNames">���еı����б�</param>
        /// <param name="sw">StringWriter������</param>
        /// <returns>�Ƿ�ɹ���</returns>
        public static bool GetExcelFromDataTableByArr2(System.Data.DataTable objDT,
            List<string> ColumnsNameInDataTable,
            List<string> FirstRowChineseNames,
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
                    throw new Exception("��Ҫ�����ļ�¼��Ϊ0������Ҫ������");
                }
                //				int intColumnNum = objDT.Columns.Count;
                //2 ͨ��ѭ����д��Excel
                //				string sFile;		//, sTemplate;
                //				Excel.ApplicationClass oExcel = new Excel.ApplicationClass();	
                //				Excel.Workbook oBook = oExcel.Application.Workbooks.Add(true);
                //				Excel.Worksheet oSheet =(Excel.Worksheet) oBook.Sheets[1];
                //				oExcel.Visible = false;
                //д��һ����ͷ
                //				int iColNum = 0;

                //				string data1 = "000000001";
                //				long data2 = 123456789123456789;
                ////				System.IO.StringWriter sw = new System.IO.StringWriter();
                //				sw.WriteLine("ԭ����1\tת��������1\tԭ����2\tת������2");
                //				for(int i= 0;i<10000;i++)
                //				{
                //					sw.WriteLine(data1 +"\t" + "=\"" + data1 + "\"\t" + data2 +"\t" + "=\"" + data2.ToString() + "\"");
                //				}
                //				sw.Close();
                //				Response.Buffer= true;
                //				Response.Charset="";
                //				Response.AppendHeader("Content-Disposition","attachment;filename=aa.xls");
                //				Response.ContentType = "application/ms-excel";//��������ļ�����Ϊexcel�ļ��� 
                //				Response.ContentEncoding=System.Text.Encoding.GetEncoding("GB2312");//���������Ϊ��������
                //				Response.Write(sw);
                //				Response.End();

                StringBuilder strLine = new StringBuilder();
                foreach (string strHeader in FirstRowChineseNames)
                {
                    strLine.Append(strHeader + "\t");
                    //					iColNum ++;
                }
                sw.WriteLine(strLine.ToString());

                //��Excel�ĵڶ��п�ʼдDataTable

                //(2) ͨ��ѭ����ss[i,j]�����������д��Excel

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

                //				oSheet.Name = "First Sheet"; //������sheet
                //				sFile = SavePathAndName;
                //            
                //				if (File.Exists(sFile))     //���ļ����̣���������˾���ɾ����
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
        /// ����EXCEL���� ��DataTable������StringWriter�������У��ֶηָ���'\t'
        /// </summary>
        /// <param name="objDT">����ԴDataTable</param>
        /// <param name="ColumnsNameInDataTable">��DataTable��ѡȡ���ֶ��б�</param>
        /// <param name="FirstRowChineseNames">���еı����б�</param>
        /// <param name="SavePathAndName">�����·���ļ���</param>
        /// <returns>�Ƿ�ɹ���</returns>
        public static bool GetExcelFromDataTableByArr_StringWriter(System.Data.DataTable objDT,
            List<string> ColumnsNameInDataTable,
            List<string> FirstRowChineseNames,
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

            //������������stringWriter��д���ı��Լ����滻�ı�   


            try
            {
                int intRowNum = objDT.Rows.Count;
                if (intRowNum == 0)
                {
                    throw new Exception("��Ҫ�����ļ�¼��Ϊ0������Ҫ������");
                }
                StringBuilder strLine = new StringBuilder();
                foreach (string strHeader in FirstRowChineseNames)
                {
                    strLine.Append(strHeader + "\t");
                }
                stringWriter.WriteLine(strLine.ToString());

                //��Excel�ĵڶ��п�ʼдDataTable

                //(2) ͨ��ѭ����ss[i,j]�����������д��Excel

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
        /// ͨ��EXCEL����ʹ�á��Զ��������������鴫�䵽�������ϵ�����
        /// </summary>
        /// <param name="objDT">DataTable����</param>
        /// <param name="ColumnsNameInDataTable">��Ҫ�������ֶ�����</param>
        /// <param name="FirstRowChineseNames">����EXCEL�ı������ֶ���</param>
        /// <param name="SavePathAndName">�����·�����ļ���</param>
        /// <returns>�Ƿ�ɹ�</returns>
        public bool GetExcelFromDataTableByArrAndArray(System.Data.DataTable objDT,
            List<string> ColumnsNameInDataTable,
            List<string> FirstRowChineseNames,
            string SavePathAndName
            )
        {
            if (CheckColumnsNameIsExist(objDT, ColumnsNameInDataTable) == false)
            {
                return false;
            }
            //����
            int intRowNum = objDT.Rows.Count;
            if (intRowNum == 0)
            {
                throw new Exception("��Ҫ�����ļ�¼��Ϊ0������Ҫ������");
            }
            //����
            int intColumnNum = objDT.Columns.Count;
            //2 ͨ��ѭ����д��Excel
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
                    string strMsg = string.Format("��{0}����������������{1}.", j, objException.Message);
                    throw new Exception(strMsg);
                }
            }
            //for (int i = 0; i < FirstRowChineseNames.Count; i++)
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
        /// ͨ��EXCEL����ʹ�á��Զ��������������鴫�䵽�������ϵ�����
        /// </summary>
        /// <param name="objDT">DataTable����</param>
        /// <param name="ColumnsNameInDataTable">��Ҫ�������ֶ�����</param>
        /// <param name="FirstRowChineseNames">����EXCEL�ı������ֶ���</param>
        /// <param name="SavePathAndName">�����·�����ļ���</param>
        /// <param name="strTitle">�����б���</param>
        /// <returns>�Ƿ�ɹ�</returns>
        public bool GetExcelFromDataTableByArrAndArray(System.Data.DataTable objDT,
            List<string> ColumnsNameInDataTable,
            List<string> FirstRowChineseNames,
            string SavePathAndName,
             string strTitle
            )
        {
            if (CheckColumnsNameIsExist(objDT, ColumnsNameInDataTable) == false)
            {
                return false;
            }
            //����
            int intRowNum = objDT.Rows.Count;
            if (intRowNum == 0)
            {
                throw new Exception("��Ҫ�����ļ�¼��Ϊ0������Ҫ������");
            }
            //����
            int intColumnNum = objDT.Columns.Count;
            //2 ͨ��ѭ����д��Excel
            //string sFile;		//, sTemplate;
            m_objExcel = new Excel.Application();
            m_objBooks = (Excel.Workbooks)m_objExcel.Workbooks;
            m_objBook = (Excel._Workbook)(m_objBooks.Add(m_objOpt));
            m_objSheets = (Excel.Sheets)m_objBook.Worksheets;
            m_objSheet = (Excel._Worksheet)(m_objSheets.get_Item(1));

            // Create an array for the headers and add it to cells A1:C1.
            //			object[] objHeaders = {"Order ID", "Amount", "Tax"};
            //д����
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
                    string strMsg = string.Format("��{0}����������������{1}.", j, objException.Message);
                    throw new Exception(strMsg);
                }
            }
            //for (int i = 0; i < FirstRowChineseNames.Count; i++)
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

    }
}