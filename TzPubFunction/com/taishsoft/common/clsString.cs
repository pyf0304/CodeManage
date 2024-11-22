using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Web;
using System.Diagnostics;
//using TzPubFunction.Properties;

namespace com.taishsoft.common
{
    /// <summary>
    /// 
    /// </summary>
    public class clsString
    {
        public clsString()
        {
        }
        /// <summary>
        /// ��װ�ַ�����
        /// </summary>
        /// <param name="mStr">ԭ�����ַ���</param>
        /// <param name="count">���ַ������ظ�����</param>
        /// <returns>��װ�õ��ַ���</returns>
        public string combineStr(string mStr, int count)
        {
            string strTemp = "";
            for (int i = 0; i < count; i++)
                strTemp += mStr;
            return strTemp;
        }

        /// <summary>
        /// ��װ�ַ�����
        /// </summary>
        /// <param name="mStr">ԭ�����ַ���</param>
        /// <param name="count">���ַ������ظ�����</param>
        /// <returns>��װ�õ��ַ���</returns>
        public static string combineStrS(string mStr, int count)
        {
            string strTemp = "";
            for (int i = 0; i < count; i++)
                strTemp += mStr;
            return strTemp;
        }
        /// <summary>
        /// ����:ʹ�������ַ�������ĸ��д
        /// </summary>
        /// <param name="mStr"></param>
        public void FstUcase(ref string mStr)
        {
            if (mStr.Length == 0) return;
            if (mStr.Length > 1)
            {
                mStr = mStr.Substring(0, 1).ToUpper() + mStr.Substring(1, mStr.Length - 1);
            }
            else
            {
                mStr = mStr.Substring(0, 1).ToUpper();
            }
        }
        /// <summary>
        /// �ѵ��ʵĵ�һ����ĸ��ɴ�д
        /// </summary>
        /// <param name="mStr"></param>
        public static void FstUcase_S(ref string mStr)
        {
            if (mStr.Length == 0) return;
            if (mStr.Length > 1)
            {
                mStr = mStr.Substring(0, 1).ToUpper() + mStr.Substring(1, mStr.Length - 1);
            }
            else
            {
                mStr = mStr.Substring(0, 1).ToUpper();
            }
        }
        /// <summary>
        /// �ѵ��ʵĵ�һ����ĸ��ɴ�д
        /// </summary>
        /// <param name="mStr"></param>
        /// <returns></returns>
        public string FirstUcase(string mStr)
        {
            if (mStr.Length == 0) return "";
            string strResult = "";
            if (mStr.Length > 1)
            {
                strResult = mStr.Substring(0, 1).ToUpper() + mStr.Substring(1, mStr.Length - 1);
            }
            else
            {
                strResult = mStr.Substring(0, 1).ToUpper();
            }
            return strResult;
        }
        /// <summary>
        /// �ѵ��ʵĵ�һ����ĸ��ɴ�д
        /// </summary>
        /// <param name="mStr"></param>
        /// <returns></returns>
        public static string FirstUcaseS(string mStr)
        {
            if (mStr.Length == 0) return "";
            string strResult = "";
            if (mStr.Length > 1)
            {
                strResult = mStr.Substring(0, 1).ToUpper() + mStr.Substring(1, mStr.Length - 1);
            }
            else
            {
                strResult = mStr.Substring(0, 1).ToUpper();
            }
            return strResult;
        }
        /// <summary>
        /// �ѵ��ʵĵ�һ����ĸ���Сд
        /// </summary>
        /// <param name="mStr"></param>
        /// <returns></returns>
        public string FstLcase(string mStr)
        {
            if (mStr.Length == 0) return "";
            string strResult = "";
            if (mStr.Length > 1)
            {
                strResult = mStr.Substring(0, 1).ToLower() + mStr.Substring(1, mStr.Length - 1);
            }
            else
            {
                strResult = mStr.Substring(0, 1).ToLower();
            }
            return strResult;
        }
        /// <summary>
        /// �ѵ��ʵĵ�һ����ĸ���Сд
        /// </summary>
        /// <param name="mStr"></param>
        /// <returns></returns>
        public static string FstLcaseS(string mStr)
        {
            if (mStr.Length == 0) return "";
            string strResult = "";
            if (mStr.Length > 1)
            {
                strResult = mStr.Substring(0, 1).ToLower() + mStr.Substring(1, mStr.Length - 1);
            }
            else
            {
                mStr = mStr.Substring(0, 1).ToLower();
            }
            return strResult;
        }
        /// <summary>
        /// �ѵ��ʵĵ�һ����ĸ���Сд
        /// </summary>
        /// <param name="mStr"></param>
        /// <returns></returns>
        public static string FirstLcaseS(string mStr)
        {
            if (mStr.Length == 0) return "";
            string strResult = "";
            if (mStr.Length > 1)
            {
                strResult = mStr.Substring(0, 1).ToLower() + mStr.Substring(1, mStr.Length - 1);
            }
            else
            {
                mStr = mStr.Substring(0, 1).ToLower();
            }
            return strResult;
        }

        /// <summary>
        /// �ѱ������ĵ�һ����ĸ����д���Сд����ǰ������ĸ��дȫ���Сд
        /// </summary>
        /// <param name="mStr"></param>
        /// <returns></returns>
        public static string Fst2LcaseS(string mStr)
        {
            if (mStr == null) return "";
            if (mStr.Length == 0) return "";
            string strResult = "";
            if (mStr.Length > 2)
            {
                string strFirstLetter = mStr.Substring(0, 1);
                string strSecondLetter = mStr.Substring(1, 1);
                if (clsString.IsUpper(strFirstLetter))
                {
                    if (clsString.IsUpper(strSecondLetter))
                    {
                        strResult = strFirstLetter.ToLower()
                            + strSecondLetter.ToLower()
                            + mStr.Substring(2, mStr.Length - 2);
                    }
                    else
                    {
                        strResult = mStr.Substring(0, 1).ToLower() + mStr.Substring(1, mStr.Length - 1);
                    }
                }
                else
                {
                    strResult = mStr;
                }
            }
            else if (mStr.Length > 1)
            {                
                strResult = mStr.Substring(0, 1).ToLower() + mStr.Substring(1, mStr.Length - 1);
            }
            else
            {
                mStr = mStr.Substring(0, 1).ToLower();
            }
            return strResult;
        }

        /// <summary>
        /// ��һ������ת����һ�������Ƶ��ַ���
        /// </summary>
        public string GetBinaryS(int mInt)
        {
            string s1;
            System.Collections.Stack S = new System.Collections.Stack();
            while (mInt > 0)
            {
                S.Push(mInt % 2);
                mInt = mInt / 2;
            }
            s1 = "";
            while (S.Count > 0)
            {
                s1 = s1 + S.Pop().ToString();
            }
            return s1;
        }


        /// <summary>
        /// �ļ�����
        /// </summary>
        /// <param name="fName"></param>
        /// <returns></returns>
        public bool FileBackup(string fName)
        {
            string fNameBak;
            string NewfName;
            if (File.Exists(fName))
            {
                fNameBak = fName + "bak";
                NewfName = fName + "1";
                if (File.Exists(fNameBak)) File.Delete(fNameBak);
                if (File.Exists(NewfName)) File.Delete(NewfName);
                File.Copy(fName, fNameBak);
                File.Copy(fName, NewfName);
            }
            else
            {
                return false;
            }
            return true;
        }

        public string ParentDir(string strPath)
        {
            string pDir;
            int i;
            strPath = strPath.Replace("/", "\\");
            i = strPath.LastIndexOf("\\");
            if (i == 0) return null;
            pDir = strPath.Substring(0, i+1);
            return pDir;
        }
        /// <summary>
        /// ��ȡĿ¼��
        /// </summary>
        /// <param name="strPath"></param>
        /// <returns></returns>
        public static string GetDirName_S(string strPath)
        {
            string pDir;
            int i;
            strPath = strPath.Replace("/", "\\");
            i = strPath.LastIndexOf("\\");

            if (i <= 0) return "";
            pDir = strPath.Substring(0, i+1);
            return pDir;
        }

        /// <summary>
        /// ��ȡΨһ�ļ���
        /// </summary>
        /// <param name="strFileFullName"></param>
        /// <returns>��ȡ��Ψһ�ļ���</returns>
        public static string GetUniqueFileName_S(string strFileFullName)
        {

            string strFileDirName = clsString.GetDirName_S(strFileFullName);
            string strFileName = clsString.GetSimpleFName_S(strFileFullName);
            string strPureFileName = clsString.GetPureFileName(strFileName);
            string strExeName = clsString.GetFileExtName(strFileName);
            string strFileFullName_New = string.Format("{0}{1}_01.{2}", 
                strFileDirName,
                strPureFileName,
                strExeName);
            int intIndex = 2;
            while(true)
            {
                if (File.Exists(strFileFullName_New) == false)
                {
                    return strFileFullName_New;
                }
                string strIndex = intIndex.ToString("00");
                strFileFullName_New = string.Format("{0}{1}_{3}.{2}",
                       strFileDirName,
                       strPureFileName,
                      strExeName,
                      strIndex);
                intIndex++;
            }
                     
            return "";
        }

        /// <summary>
        /// ��ȡΨһ�ַ���ֵ��������Ѵ��ڵ�ֵ�б��д��ڣ����ں����-01,-02,-03��
        /// </summary>
        /// <param name="strValue">��Ҫ����ֵ</param>
        /// <param name="arrExistValueList">�Ѵ��ڵ�ֵ�б�</param>
        /// <returns>��ȡ��Ψһ�ļ���</returns>
        public static string GetUniqueStrValue_S(string strValue, List<string> arrExistValueList)
        {
            if (arrExistValueList.Contains(strValue) == false)
            {
                return strValue;
            }        
            string strValue_New = string.Format("{0}_01",
                strValue);
            int intIndex = 2;
            while (true)
            {
                if (arrExistValueList.Contains(strValue_New) == false)
                {
                    return strValue_New;
                }
                string strIndex = intIndex.ToString("00");
                strValue_New = string.Format("{0}_{1}",
                       strValue,
                      strIndex);
                intIndex++;
            }
//            return "";
        }
        /// <summary>
        /// ��Ŀ¼
        /// </summary>
        /// <param name="strPath"></param>
        /// <returns></returns>
        public static string ParentDir_S(string strPath)
        {
            string pDir;
            int i;
            strPath = strPath.Replace("/", "\\");
            i = strPath.LastIndexOf("\\");
            if (i <= 0) return "";
            pDir = strPath.Substring(0, i+1);
            return pDir;
        }

        /// <summary>
        /// Ϊ�ļ��������չ��
        /// </summary>
        /// <param name="strFileName"></param>
        /// <param name="strExeName"></param>
        /// <returns></returns>
        public bool AddExeName(ref string strFileName, string strExeName)
        {
            int i;
            i = strFileName.LastIndexOf(strExeName);
            if (i == 0) strFileName += strExeName;
            return true;
        }
        /// <summary>
        /// �Ӵ���Ŀ¼���ļ����л�ȡ�򵥵��ļ���
        /// </summary>
        /// <param name="strFileName">����Ŀ¼���ļ���</param>
        /// <returns>����Ŀ¼�ļ򵥵��ļ���</returns>
        public string GetSimpleFName(string strFileName)
        {
            string sFName;
            int i;
            strFileName = strFileName.Replace("/", "\\");
            i = strFileName.LastIndexOf("\\");
            if (i == 0) return null;
            sFName = strFileName.Substring(i + 1);
            return sFName;
        }
        /// <summary>
        /// �Ӵ���Ŀ¼���ļ����л�ȡ�򵥵��ļ���
        /// </summary>
        /// <param name="strFileName">����Ŀ¼���ļ���</param>
        /// <returns>����Ŀ¼�ļ򵥵��ļ���</returns>
        public static string GetSimpleFName_S(string strFileName)
        {
            string sFName;
            int i;
            strFileName = strFileName.Replace("/", "\\");
            i = strFileName.LastIndexOf("\\");
            if (i == 0) return null;
            sFName = strFileName.Substring(i + 1);
            return sFName;
        }

        /// <summary>
        /// �Ӷ༶Ŀ¼�л�ȡ���һ��Ŀ¼��
        /// </summary>
        /// <param name="strFileName">����Ŀ¼���ļ���</param>
        /// <returns>����Ŀ¼�ļ򵥵��ļ���</returns>
        public static string GetSimplePath(string strFilePath)
        {
            string strSimplePath;
            int i, j;
            i = strFilePath.LastIndexOf("\\");
            j = strFilePath.LastIndexOf("/");
            int ii = i > j ? i : j;
            if (ii <= 0)
            {
                return strFilePath;
            }
            strSimplePath = strFilePath.Substring(ii + 1);
            return strSimplePath;
        }
        /// <summary>
        /// �����ļ�������ȡ���ļ�����չ��
        /// </summary>
        /// <param name="strFileName">�������ļ���</param>
        /// <returns></returns>
        public static string GetFileExtName(string strFileName)
        {
            string strFileExtName;
            int i;
            i = strFileName.LastIndexOf(".");
            if (i == 0) return null;
            strFileExtName = strFileName.Substring(i + 1);
            return strFileExtName;
        }
        /// <summary>
        /// �����ļ�������ȡ���ļ���ȥ����չ���Ĵ����ļ���
        /// </summary>
        /// <param name="strFileName">�������ļ���</param>
        /// <returns></returns>
        public static string GetPureFileName(string strFileName)
        {
            if (strFileName == "")
                return null;
            string strPureFileName;
            int i;
            i = strFileName.LastIndexOf(".");
            if (i == 0) return strFileName;
            strPureFileName = strFileName.Substring(0, i);
            return strPureFileName;
        }
        /// <summary>
        /// �жϸ����ַ����Ƿ�������������
        /// </summary>
        /// <param name="strValue">��Ҫ�жϵ��ַ���</param>
        /// <returns>True/False</returns>
        public static bool IsDate(string strValue)
        {
            string strDate = "";
            if (strValue == "") return true;
            if (strValue.Length < 8)
            {
                return false;
            }
            if (strValue.Length == 8)
            {
                strDate = strValue.Substring(0, 4) + "-" + strValue.Substring(4, 2) + "-" + strValue.Substring(6, 2);
            }
            strDate = strValue;
            try
            {
                DateTime dt = DateTime.Parse(strDate);
            }
            catch (Exception expt)
            {
                string ss = expt.Message;
                return false;
            }
            return true;
        }

        /// <summary>
        /// �жϸ����ַ����Ƿ��ǲ���������
        /// </summary>
        /// <param name="strValue">��Ҫ�жϵ��ַ���</param>
        /// <returns>True/False</returns>
        public static bool IsBoolean(string strValue)
        {
            if (strValue == "") return false;
            strValue = strValue.ToLower();
            if (strValue == "false" || strValue == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// �жϸ����ַ����Ƿ���Bit������
        /// </summary>
        /// <param name="strValue">��Ҫ�жϵ��ַ���</param>
        /// <returns>True/False</returns>
        public static bool IsBit(string strValue)
        {
            if (strValue == "") return false;
            if (strValue == "0" || strValue == "1" || strValue == "False" || strValue == "True")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// �ж��Ƿ�������
        /// </summary>
        /// <param name="strValue">��Ҫ�жϵ��ַ���</param>
        /// <returns>True/False</returns>
        public static bool IsDigit(string strValue)
        {
            if (string.IsNullOrEmpty(strValue) == true) return false;
            int intLen = strValue.Length;
            for (int i = 0; i < intLen; i++)
            {
                if (char.IsDigit(strValue, i) == false)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// �ж��Ƿ�����ĸ
        /// </summary>
        /// <param name="strValue">��Ҫ�жϵ��ַ���</param>
        /// <returns>True/False</returns>
        public static bool IsLetter(string strValue)
        {
            int intLen = strValue.Length;
            for (int i = 0; i < intLen; i++)
            {
                if (char.IsLetter(strValue, i) == false)
                {
                    return false;
                }
            }
            return true;
        }


        /// <summary>
        /// �ж��Ƿ��Ǵ�д��ĸ,
        /// </summary>
        /// <param name="strValue">��Ҫ�жϵ��ַ���</param>
        /// <returns>True/False</returns>
        public static bool IsUpper(string strValue)
        {
            int intLen = strValue.Length;
            for (int i = 0; i < intLen; i++)
            {
                if (char.IsUpper(strValue, i) == false)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// �ж��Ƿ���Сд��ĸ,
        /// </summary>
        /// <param name="strValue">��Ҫ�жϵ��ַ���</param>
        /// <returns>True/False</returns>
        public static bool IsLower(string strValue)
        {
            int intLen = strValue.Length;
            for (int i = 0; i < intLen; i++)
            {
                if (char.IsLower(strValue, i) == false)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// �ж��Ƿ��Ǹ�������ֵ
        /// </summary>
        /// <param name="strValue">��Ҫ�жϵ��ַ���</param>
        /// <returns>True/False</returns>
        public static bool IsFloat(string strValue)
        {
            if (string.IsNullOrEmpty(strValue) == true) return false;
            int intPointNum = 0;
            //���ڴ����������
            if (strValue.Substring(0, 1) == "-") strValue = strValue.Substring(1);
            if (strValue.Substring(0, 1) == "+") strValue = strValue.Substring(1);

            char[] arrChar = strValue.ToCharArray();
            int intLen = strValue.Length;
            for (int i = 0; i < intLen; i++)
            {
                if (char.IsDigit(strValue, i) == true || arrChar[i] == '.')
                {
                }
                else
                {
                    return false;
                }
                if (arrChar[i] == '.') intPointNum++;
            }
            //����ܹ��м���С���㣬����ж���1��С���㣬�Ͳ���ȷ
            if (intPointNum > 1) return false;
            return true;
        }
        /// <summary>
        /// �ж��Ƿ���������ֵ
        /// </summary>
        /// <param name="strValue">��Ҫ�жϵ��ַ���</param>
        /// <returns>True/False</returns>
        public static bool IsNumeric(string strValue)
        {

            int intLen = strValue.Length;
            if (intLen == 0) return false;
            //���ڴ����������
            if (strValue.Substring(0, 1) == "-") strValue = strValue.Substring(1);
            if (strValue.Substring(0, 1) == "+") strValue = strValue.Substring(1);
            intLen = strValue.Length;
            for (int i = 0; i < intLen; i++)
            {
                if (char.IsDigit(strValue, i) == false)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// ���ܣ���ȡ��ǰ���ڵ��ַ���
        /// ���ڸ�ʽ��
        ///    ���ڵ��ַ����ĸ�ʽ�����֣�
        ///		1��YYYYMMDD��	����20050120
        ///		2��YYYY-MM-DD	����2005-01-20
        ///		3��YYYY/MM/DD	����2005/01/20
        ///		4��YYYY��MM��DD��
        ///		5��YYYY��MM��DD�� ����X
        /// </summary>
        /// <param name="intFormat">���ڸ�ʽ������3�֣��������0,1��2
        ///							������ͬ����������ֵ�Ͳ�ͬ��
        ///							�μ���������ڸ�ʽ
        ///	</param>
        /// <returns>���ص�ǰ���ڵ��ַ���</returns>
        public string getTodayStr(int intFormat)
        {
            string strToday;
            string strYear, strMonth, strDay, strWeek;
            int intYear, intMonth, intDay;
            intYear = System.DateTime.Today.Year;
            intMonth = System.DateTime.Today.Month;
            intDay = System.DateTime.Today.Day;
            strYear = intYear.ToString().Trim();
            if (intMonth > 9) strMonth = intMonth.ToString().Trim();
            else strMonth = "0" + intMonth.ToString().Trim();
            if (intDay > 9) strDay = intDay.ToString().Trim();
            else strDay = "0" + intDay.ToString().Trim();
            strToday = strYear + strMonth + strDay;
            strWeek = TransWeekFromEngToChs(System.DateTime.Today.DayOfWeek.ToString());
            switch (intFormat)
            {
                case 0:
                    strToday = strYear + strMonth + strDay;
                    break;
                case 1:
                    strToday = strYear + "-" + strMonth + "-" + strDay;
                    break;
                case 2:
                    strToday = strYear + "/" + strMonth + "/" + strDay;
                    break;
                case 3:
                    strToday = strYear + "��" + strMonth + "��" + strDay + "��";
                    break;
                case 4:
                    strToday = strYear + "��" + strMonth + "��" + strDay + "�� " + strWeek;
                    break;

            }
            return strToday;
        }
        /// <summary>
        /// ���ܣ���ȡ��ǰ�µ��ַ���
        /// �µĸ�ʽ��
        ///    �µ��ַ����ĸ�ʽ�����֣�
        ///		1��YYYYMM��	����200501
        ///		2��YYYY-MM-DD	����2005-01
        ///		3��YYYY/MM/DD	����2005/01
        ///		4��YYYY��MM��DD��
        ///		5��YYYY��MM��DD�� ����X
        /// </summary>
        /// <param name="intFormat">�µĸ�ʽ������3�֣��������0,1��2��3,4
        ///							������ͬ����������ֵ�Ͳ�ͬ��
        ///							�μ�������µĸ�ʽ
        ///	</param>
        /// <returns>���ص�ǰ�µ��ַ���</returns>
        public string getCurrMonth(int intFormat)
        {
            string strCurrMonth;
            string strYear, strMonth;
            int intYear, intMonth;
            intYear = System.DateTime.Today.Year;
            intMonth = System.DateTime.Today.Month;
            strYear = intYear.ToString().Trim();
            if (intMonth > 9) strMonth = intMonth.ToString().Trim();
            else strMonth = "0" + intMonth.ToString().Trim();
            strCurrMonth = strYear + strMonth;
            switch (intFormat)
            {
                case 0:
                    strCurrMonth = strYear + strMonth;
                    break;
                case 1:
                    strCurrMonth = strYear + "-" + strMonth;
                    break;
                case 2:
                    strCurrMonth = strYear + "/" + strMonth;
                    break;

            }
            return strCurrMonth;
        }

        /// <summary>
        /// ���ܣ���ȡ��ǰ���ڵ��ַ���
        /// ���ڸ�ʽ��
        ///    ���ڵ��ַ����ĸ�ʽ�����֣�
        ///		1��YYYYMMDD��	����20050120
        ///		2��YYYY-MM-DD	����2005-01-20
        ///		3��YYYY/MM/DD	����2005/01/20
        /// </summary>
        /// <param name="intFormat">���ڸ�ʽ������3�֣��������0,1��2
        ///							������ͬ����������ֵ�Ͳ�ͬ��
        ///							�μ���������ڸ�ʽ
        ///	</param>
        /// <returns>���ص�ǰ���ڵ��ַ���</returns>
        public static string getTodayStr_S(int intFormat)
        {
            string strToday;
            string strYear, strMonth, strDay, strWeek;
            int intYear, intMonth, intDay;
            intYear = System.DateTime.Today.Year;
            intMonth = System.DateTime.Today.Month;
            intDay = System.DateTime.Today.Day;
            strYear = intYear.ToString().Trim();
            if (intMonth > 9) strMonth = intMonth.ToString().Trim();
            else strMonth = "0" + intMonth.ToString().Trim();
            if (intDay > 9) strDay = intDay.ToString().Trim();
            else strDay = "0" + intDay.ToString().Trim();
            strToday = strYear + strMonth + strDay;
            strWeek = TransWeekFromEngToChs(System.DateTime.Today.DayOfWeek.ToString());

            switch (intFormat)
            {
                case 0:
                    strToday = strYear + strMonth + strDay;
                    break;
                case 1:
                    strToday = strYear + "-" + strMonth + "-" + strDay;
                    break;
                case 2:
                    strToday = strYear + "/" + strMonth + "/" + strDay;
                    break;
                case 3:
                    strToday = strYear + "��" + strMonth + "��" + strDay + "��";
                    break;
                case 4:
                    strToday = strYear + "��" + strMonth + "��" + strDay + "�� " + strWeek;
                    break;

            }
            return strToday;
        }
        /// <summary>
        /// ���ܣ���ȡ��ǰ�µ��ַ���
        /// �µĸ�ʽ��
        ///    �µ��ַ����ĸ�ʽ�����֣�
        ///		1��YYYYMM��	����200501
        ///		2��YYYY-MM-DD	����2005-01
        ///		3��YYYY/MM/DD	����2005/01
        /// </summary>
        /// <param name="intFormat">�µĸ�ʽ������3�֣��������0,1��2
        ///							������ͬ����������ֵ�Ͳ�ͬ��
        ///							�μ�������µĸ�ʽ
        ///	</param>
        /// <returns>���ص�ǰ�µ��ַ���</returns>
        public static string getCurrMonth_S(int intFormat)
        {
            string strCurrMonth;
            string strYear, strMonth;
            int intYear, intMonth;
            intYear = System.DateTime.Today.Year;
            intMonth = System.DateTime.Today.Month;
            strYear = intYear.ToString().Trim();
            if (intMonth > 9) strMonth = intMonth.ToString().Trim();
            else strMonth = "0" + intMonth.ToString().Trim();
            strCurrMonth = strYear + strMonth;
            switch (intFormat)
            {
                case 0:
                    strCurrMonth = strYear + strMonth;
                    break;
                case 1:
                    strCurrMonth = strYear + "-" + strMonth;
                    break;
                case 2:
                    strCurrMonth = strYear + "/" + strMonth;
                    break;
            }
            return strCurrMonth;
        }
        private static string TransWeekFromEngToChs(string strEndWeek)
        {
            if (strEndWeek == "Friday") return "������";
            else if (strEndWeek == "Monday") return "����һ";
            else if (strEndWeek == "Saturday") return "������";
            else if (strEndWeek == "Sunday") return "������";
            else if (strEndWeek == "Thursday") return "������";
            else if (strEndWeek == "Tuesday") return "���ڶ�";
            else if (strEndWeek == "Wednesday") return "������";
            else return "�������ݷǷ�!";
        }
        public static string GetHostIpAddress()
        {
            System.Net.IPAddress[] addressList = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList;
            if (addressList.Length > 1)
            {
                return addressList[0].ToString();
            }
            else
            {
                return addressList[0].ToString();
            }
            //			{ 
            //			
            //			if ( addressList.Length>1)
            //			{ 
            //				nativeIP.Text = addressList[0].ToString();
            //				serverIP.Text = addressList[1].ToString();
            //			}
            //			else
            //			{
            //				nativeIP.Text = addressList[0].ToString();
            //				serverIP.Text = "Break the line...";
            //			}
        }
        /**/
        /// <summary>
        /// תȫ�ǵĺ���(SBC case)
        /// </summary>
        /// <param name="input">�����ַ���</param>
        /// <returns>ȫ���ַ���</returns>
        ///<remarks>
        ///ȫ�ǿո�Ϊ12288����ǿո�Ϊ32
        ///�����ַ����(33-126)��ȫ��(65281-65374)�Ķ�Ӧ��ϵ�ǣ������65248
        ///</remarks>        
        public string ToSBC(string input)
        {
            //���תȫ�ǣ�
            char[] c = input.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 32)
                {
                    c[i] = (char)12288;
                    continue;
                }
                if (c[i] < 127)
                    c[i] = (char)(c[i] + 65248);
            }
            return new string(c);
        }


        /**/
        /// <summary>
        /// ת��ǵĺ���(DBC case)
        /// </summary>
        /// <param name="input">�����ַ���</param>
        /// <returns>����ַ���</returns>
        ///<remarks>
        ///ȫ�ǿո�Ϊ12288����ǿո�Ϊ32
        ///�����ַ����(33-126)��ȫ��(65281-65374)�Ķ�Ӧ��ϵ�ǣ������65248
        ///</remarks>
        public string ToDBC(string input)
        {
            char[] c = input.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 12288)
                {
                    c[i] = (char)32;
                    continue;
                }
                if (c[i] > 65280 && c[i] < 65375)
                    c[i] = (char)(c[i] - 65248);
            }
            return new string(c);
        }
        /**/
        /// <summary>
        /// ת��ǵĺ���(DBC case)
        /// </summary>
        /// <param name="input">�����ַ���</param>
        /// <returns>����ַ���</returns>
        ///<remarks>
        ///ȫ�ǿո�Ϊ12288����ǿո�Ϊ32
        ///�����ַ����(33-126)��ȫ��(65281-65374)�Ķ�Ӧ��ϵ�ǣ������65248
        ///</remarks>
        public static string ToDBC_S(string input)
        {
            char[] c = input.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 12288)
                {
                    c[i] = (char)32;
                    continue;
                }
                if (c[i] > 65280 && c[i] < 65375)
                    c[i] = (char)(c[i] - 65248);
            }
            return new string(c);
        }
        /// <summary>
        /// ת��ǵĺ���(DBC case)
        /// </summary>
        /// <param name="input">�����ַ���</param>
        /// <returns>����ַ���</returns>
        ///<remarks>
        ///ȫ�ǿո�Ϊ12288����ǿո�Ϊ32
        ///�����ַ����(33-126)��ȫ��(65281-65374)�Ķ�Ӧ��ϵ�ǣ������65248
        ///</remarks>
        public static string ToDBC_S160(string input)
        {
            char[] c = input.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 160)
                {
                    c[i] = (char)32;
                    continue;
                }
                if (c[i] == 12288)
                {
                    c[i] = (char)32;
                    continue;
                }
                if (c[i] > 65280 && c[i] < 65375)
                    c[i] = (char)(c[i] - 65248);
            }
            return new string(c);
        }
        /// <summary>
        /// ��ȡ�ַ�����ʵ���ֽڳ��ȣ����к�����2���ֽڣ���ĸ��һ���ֽ�
        /// </summary>
        /// <param name="strTemp">�ṩ���ַ���</param>
        /// <returns>���ص��ֽڳ���</returns>
        public static int getStrLenS(string strTemp)
        {
            int len;
            byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
            len = sarr.Length;//will output as 3+3*2=9
            return len;
        }

      /// <summary>
      /// ���Ӵ������ݷָ���־�б�����
      /// </summary>
      /// <param name="strSourceStr">Դ��</param>
      /// <param name="lstSplitFlag">�ָ���־�б�</param>
      /// <returns>�����ַ����б��ָ��Ӵ����б�</returns>
        public static List<string> SplitStringBySplitFlagLst(string strSourceStr, List<string> lstSplitFlag)
        {
            //if (clsDebugBase_Pub.IsDebug == true)
            //{
            //    StackTrace trace = new StackTrace();
            //    int intCurrLevel = 0;
            //    foreach (StackFrame frame in trace.GetFrames())
            //    {
                    
            //        string strFileName = frame.GetFileName();
            //        string strMothodName = frame.GetMethod().Name;
            //        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
            //        clsDebugBase_Pub.WriteLog(strDeclaringType + ":" + strMothodName);
            //        if (intCurrLevel > clsDebugBase_Pub.TraceLevel) break;
            //    }
            //}
            strSourceStr += "  ";
            List<int> lstPos = new List<int>();
            lstPos.Add(0);
            foreach (string strSplitFlag in lstSplitFlag)
            {
                int intPos = -1;
                while (true)
                {
                    intPos = strSourceStr.IndexOf(strSplitFlag, intPos + 1, StringComparison.InvariantCultureIgnoreCase);
                    if (intPos >= 0)
                    {
                        if (lstPos.Contains(intPos) == false) lstPos.Add(intPos);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            lstPos.Add(strSourceStr.Length - 1);
            lstPos.Sort();
            List<string> lstItem = new List<string>();
            for (int i = 0; i < lstPos.Count - 1; i++)
            {
                int intPos_Start = lstPos[i];
                int intPos_End = lstPos[i + 1];
                string strItem = strSourceStr.Substring(intPos_Start, intPos_End - intPos_Start);
                if (string.IsNullOrEmpty(strItem) == false)
                {
                    lstItem.Add(strItem);
                }
            }
            return lstItem;
        }
  

        public static List<string> SplitCondition(string strConditionStr)
        {
            if (string.IsNullOrEmpty(strConditionStr) == true)
            {
                return null;
            }
            int[] iCondPos = new int[20];   //��¼"And","Or"��λ��
            int iIndex = 0;
            iCondPos[iIndex++] = 0;
            string strChar = "";
            int intLength = strConditionStr.Length;
            string strConditionStr_L = strConditionStr.ToLower();
            for (int iPos = 0; iPos < intLength; iPos++)
            {
                strChar = strConditionStr_L.Substring(iPos, 1);
                switch (strChar)
                {
                    case "(":
                        //����Ӧ��������
                        int intTempPos = FindRelaRightBrackets(strConditionStr_L, iPos + 1);
                        if (intTempPos == -1)
                        {
                            StringBuilder sbMsg = new StringBuilder();
                            sbMsg.AppendFormat("���ַ�����{0}��λ�ã�{1}��������û����Ե������š�", iPos);
                            throw new Exception(sbMsg.ToString());
                        }
                        iPos = intTempPos;
                        break;
                    case "a":
                        if (strConditionStr_L.Substring(iPos + 1, 2) == "nd")
                        {
                            iCondPos[iIndex++] = iPos;
                        }
                        break;
                    case "o":
                        if (strConditionStr_L.Substring(iPos + 1, 1) == "r")
                        {
                            iCondPos[iIndex++] = iPos;
                        }
                        break;
                    default:
                        break;
                }
            }
            List<string> arrCond = new List<string>();
            string strCond = "";
            for (int i = 0; i < iIndex - 1; i++)
            {
                strCond = strConditionStr.Substring(iCondPos[i], iCondPos[i + 1] - iCondPos[i]);
                arrCond.Add(strCond);
            }
            strCond = strConditionStr.Substring(iCondPos[iIndex - 1]);
            arrCond.Add(strCond);
            return arrCond;
        }
        /// <summary>
        /// ����Ӧ�������ţ�Brackets�����ţ�
        /// </summary>
        /// <param name="strValue">�ַ���ֵ</param>
        /// <param name="iStartPos">��ʼλ��</param>
        /// <returns></returns>
        public static int FindRelaRightBrackets(string strValue, int iStartPos)
        {
            string strChar = "";
            int intLength = strValue.Length;
            for (int iPos = iStartPos; iPos < intLength; iPos++)
            {
                strChar = strValue.Substring(iPos, 1);
                switch (strChar)
                {
                    case "(":
                        //����Ӧ��������
                        int intTempPos = FindRelaRightBrackets(strValue, iPos + 1);
                        if (intTempPos == -1) return -1;
                        if (intTempPos >= intLength) return -1;
                        iPos = intTempPos;
                        break;
                    case ")":
                        return iPos;
                    default:
                        break;

                }
            }
            return -1; //���磬δ�ҵ�
        }
        /// <summary>
        /// ȥ�����ˣ�Ends�������ţ�Brackets��
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns></returns>
        public static string RemoveEndsBrackets(string strValue)
        {
            string strNewValue = "";
            strValue = strValue.Trim();
            int intLength = strValue.Length;
            if (strValue.Substring(0, 1) == "(")
            {
                if (strValue.Substring(intLength - 1, 1) == ")")
                {
                    strNewValue = strValue.Substring(1, intLength - 2);
                    return strNewValue;
                }
                else
                {
                    return strValue;
                }
            }
            else
            {
                return strValue;
            }
        }
        public static string IntToStr(int intValue, int intStrLen)
        {
            string strFormat = combineStrS("0", intStrLen);
            string strTemp = string.Format(strFormat, intValue);
            return strTemp;
        }

        public static Encoding GetEncodingObjByCharEncodingId(string strCharEncodingId)
        {
            string strCharEncodingId_Lower = strCharEncodingId.ToLower();
            Encoding myEncoding = null;
//ANSI	ANSI�ַ���	ANSI�ַ������壺ASCII�ַ������Լ��ɴ����������ݵ��ַ������磺GB2312����ʽ������ΪMBCS(Multi-Byte Chactacter System�����ֽ��ַ�ϵͳ)��ͨ��Ҳ��ΪANSI�ַ�����	NULL
//ASCII	ASCII-������Ϣ������׼����	ASCII��American Standard Code for Information Interchange��������Ϣ������׼���룩�ǻ���������ĸ���һ�׵��Ա���ϵͳ��	NULL
//BIG5	BIG5-������������	BIG5�ֳƴ����������룬1984����̨����ŷ�����Ϣ��ҵ�߽������������˾�곞 (Acer)����ͨ (MiTAC)���Ѽѡ���Ҽ (Zero One)������ (FIC)�������ʳƴ����롣
//Big5��ʹ����˫�ֽڴ��淽����һ���ַ�ռ2���ֽڡ���һ���ֽڳ�Ϊ����λ�ֽڡ����ڶ����ֽڳ�Ϊ����λ�ֽڡ�����λ�ֽڵı��뷶Χ0xA1-0xF9����λ�ֽڵı��뷶Χ0x40-0x7E��0xA1-0xFE��	NULL
//GB18030	GB18030-��Ϣ�����ú��ֱ����ַ���������������	GB18030��ȫ����GB18030-2000����Ϣ�����ú��ֱ����ַ��������������䡷�����ҹ�������2000��3��17�շ������µĺ��ֱ�����ұ�׼��2001��8��31�պ����й��г��Ϸ��������������ϱ���׼��GB18030�ַ�����׼�ĳ�̨�����㷺�������֤�����Թ�����֪����Ϣ������ҵ�Ĺ�˾����Ϣ��ҵ����ԭ�������������ල������ʵʩ��	NULL
//GB2312	GB2312-���������ַ���		NULL
//GBK	GBK-GB2312����չ	GBK�ַ�����GB2312����չ(K)��������ȫ����GB2312��GBK1.0��¼��21886�����ţ�����Ϊ��������ͼ�η�����������������21003���ַ���GBK�ַ�����Ҫ��չ�˷��������ֵ�֧�ּ�GB2312�������ĺ��ֲ��׷��š����ű����ŵ��ַ���	NULL
//Unicode	Unicode-ͨ�ö��λ�����ַ���	Unicode�ַ��������ǣ�Universal Multiple-Octet Coded Character Set ��ͨ�ö��λ�����ַ����ļ�ƣ�����һ����Ϊ Unicode ѧ��ѧ��(Unicode Consortium)�Ļ����ƶ����ַ�����ϵͳ��֧���ֽ�������ֲ�ͬ���Ե������ı��Ľ�����������ʾ���ñ�����1990�꿪ʼ�з���1994����ʽ���������°汾��2005��3��31�յ�Unicode 4.1.0����Ϊÿ�������е�ÿ���ַ��趨��ͳһ����Ψһ�Ķ����Ʊ��룬����������ԡ���ƽ̨�����ı�ת���������Ҫ��	NULL
//UTF-16	UTF-16--��׼�� Unicode ��ΪUTF-16(UTF:UCS Transformation Format )	��׼�� Unicode ��ΪUTF-16(UTF:UCS Transformation Format )	NULL
//UTF-8	UTF-8--Unicode Translation Format������Unicodeת��ĳ�ָ�ʽ����˼	UTF�� Unicode Translation Format������Unicodeת��ĳ�ָ�ʽ����˼������UTF-8��Unicode������һ��ʹ�÷�ʽ��UTF-8���ֽ�Ϊ���뵥Ԫ��û���ֽ�������⡣��ʹ�ÿɱ䳤���ֽ������� Unicode�ַ���ASCII��ĸ����ʹ��1�ֽڴ��棬�������֡�ϣ����ĸ���������ĸ��ʹ��2�ֽ������棬�����õĺ��־�Ҫʹ��3�ֽڣ�����ƽ���ַ���ʹ��4�ֽڡ���UTF-8�������󳤶���4���ֽڣ�	True
            switch (strCharEncodingId_Lower)
            {
                case "ansi":
                    myEncoding = Encoding.Default;
                    break;
                case "ascii":
                    myEncoding = Encoding.ASCII;
                    break;
                case "utf-8":
                    myEncoding = Encoding.UTF8;
                    break;
                case "utf-8withoutbom":
                    myEncoding = new UTF8Encoding(false);
                    break;
                case "big5":
                    myEncoding = Encoding.BigEndianUnicode;
                    break;
                case "gb18030":
                    myEncoding = Encoding.Default;
                    break;
                case "gb2312":
                    myEncoding = Encoding.Default;
                    break;
                case "gbk":
                    myEncoding = Encoding.Default;
                    break;
                case "unicode":
                    myEncoding = Encoding.Unicode;
                    break;
                case "utf-16":
                    myEncoding = Encoding.UTF32;
                    break;
                default:
                    myEncoding = Encoding.Unicode;
                    break;
            }
            return myEncoding;
        }
        public static string Utf8ToAscII(string strSource)
        {

            //string   strSource   =   "This   string   contains   the   unicode   character   Pi(\u03a0)";   

            //   Create   two   different   encodings.   
            Encoding ascii = Encoding.ASCII;
            Encoding unicode = Encoding.UTF8;

            //   Convert   the   string   into   a   byte[].   
            byte[] SourceBytes = unicode.GetBytes(strSource);

            //   Perform   the   conversion   from   one   encoding   to   the   other.   
            byte[] TargetBytes = Encoding.Convert(unicode, ascii, SourceBytes);

            //   Convert   the   new   byte[]   into   a   char[]   and   then   into   a   string.   
            //   This   is   a   slightly   different   approach   to   converting   to   illustrate   
            //   the   use   of   GetCharCount/GetChars.   
            char[] TargetChars = new char[ascii.GetCharCount(TargetBytes, 0, TargetBytes.Length)];
            ascii.GetChars(TargetBytes, 0, TargetBytes.Length, TargetChars, 0);
            string TargetString = new string(TargetChars);
            return TargetString;


        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strSource"></param>
        /// <returns></returns>
        public static string Utf8ToUnicode(string strSource)
        {

            //string   strSource   =   "This   string   contains   the   unicode   character   Pi(\u03a0)";   

            //   Create   two   different   encodings.   
            Encoding ascii = Encoding.Unicode;
            Encoding unicode = Encoding.UTF8;

            //   Convert   the   string   into   a   byte[].   
            byte[] SourceBytes = unicode.GetBytes(strSource);

            //   Perform   the   conversion   from   one   encoding   to   the   other.   
            byte[] TargetBytes = Encoding.Convert(unicode, ascii, SourceBytes);

            //   Convert   the   new   byte[]   into   a   char[]   and   then   into   a   string.   
            //   This   is   a   slightly   different   approach   to   converting   to   illustrate   
            //   the   use   of   GetCharCount/GetChars.   
            char[] TargetChars = new char[ascii.GetCharCount(TargetBytes, 0, TargetBytes.Length)];
            ascii.GetChars(TargetBytes, 0, TargetBytes.Length, TargetChars, 0);
            string TargetString = new string(TargetChars);
            return TargetString;


        }

        public static string Utf8ToDefault(string strSource)
        {

            //string   strSource   =   "This   string   contains   the   unicode   character   Pi(\u03a0)";   

            //   Create   two   different   encodings.   
            Encoding ascii = Encoding.Default;
            Encoding unicode = Encoding.UTF8;

            //   Convert   the   string   into   a   byte[].   
            byte[] SourceBytes = unicode.GetBytes(strSource);

            //   Perform   the   conversion   from   one   encoding   to   the   other.   
            byte[] TargetBytes = Encoding.Convert(unicode, ascii, SourceBytes);

            //   Convert   the   new   byte[]   into   a   char[]   and   then   into   a   string.   
            //   This   is   a   slightly   different   approach   to   converting   to   illustrate   
            //   the   use   of   GetCharCount/GetChars.   
            char[] TargetChars = new char[ascii.GetCharCount(TargetBytes, 0, TargetBytes.Length)];
            ascii.GetChars(TargetBytes, 0, TargetBytes.Length, TargetChars, 0);
            string TargetString = new string(TargetChars);
            return TargetString;


        }

        public static string Utf8ToGB2312(byte[] strSource)
        {
            string gb2312Info = string.Empty;
            Encoding utf8 = Encoding.UTF8;
            Encoding gb2312 = Encoding.GetEncoding("gb2312");
            byte[] SourceBytes = strSource;// utf8.GetBytes(strSource);
            byte[] TargetBytes = Encoding.Convert(utf8, gb2312, SourceBytes);
            char[] TargetChars = new char[gb2312.GetCharCount(TargetBytes, 0, TargetBytes.Length)];
            gb2312.GetChars(TargetBytes, 0, TargetBytes.Length, TargetChars, 0);
            string gb2312info = new string(TargetChars);
            return gb2312info;




        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strSource"></param>
        /// <returns></returns>
        public static string Utf8ToGB2312(string strSource)
        {
            string gb2312Info = string.Empty;
            Encoding utf8 = Encoding.UTF8;
            Encoding gb2312 = Encoding.GetEncoding("gb2312");
            byte[] SourceBytes = utf8.GetBytes(strSource);
            byte[] TargetBytes = Encoding.Convert(utf8, gb2312, SourceBytes);
            char[] TargetChars = new char[gb2312.GetCharCount(TargetBytes, 0, TargetBytes.Length)];
            gb2312.GetChars(TargetBytes, 0, TargetBytes.Length, TargetChars, 0);
            string gb2312info = new string(TargetChars);
            return gb2312info;

        }
        /// <summary>
        /// ��gb2312���ַ���ת����UTF8���ַ���
        /// </summary>
        /// <param name="strSource">Դ�ַ���</param>
        /// <returns>ת���ɵ�Ŀ���ַ���</returns>
        public static string GB2312ToUtf8(string strSource)
        {
            string gb2312Info = string.Empty;
            Encoding utf8 = Encoding.UTF8;
            Encoding gb2312 = Encoding.GetEncoding("gb2312");
            byte[] SourceBytes = gb2312.GetBytes(strSource);
            byte[] TargetBytes = Encoding.Convert(gb2312, utf8, SourceBytes);
            char[] TargetChars = new char[utf8.GetCharCount(TargetBytes, 0, TargetBytes.Length)];
            utf8.GetChars(TargetBytes, 0, TargetBytes.Length, TargetChars, 0);
            string gb2312info = new string(TargetChars);
            return gb2312info;

        }
        /// <summary>
        /// ��gb2312���ַ���ת����UTF8���ֽ�����
        /// </summary>
        /// <param name="strSource">Դ�ַ���</param>
        /// <returns>Ŀ���ֽ�����</returns>
        public static byte[] GB2312ToUtf8Bytes(string strSource)
        {
            string gb2312Info = string.Empty;
            Encoding utf8 = Encoding.UTF8;
            Encoding gb2312 = Encoding.GetEncoding("gb2312");
            byte[] SourceBytes = gb2312.GetBytes(strSource);
            byte[] TargetBytes = Encoding.Convert(gb2312, utf8, SourceBytes);
            return TargetBytes;

        }

        public static string Utf8ToGBK(string strSource)
        {
            string gb2312Info = string.Empty;
            Encoding utf8 = Encoding.UTF8;
            Encoding gb2312 = Encoding.GetEncoding("gbk");
            byte[] SourceBytes = utf8.GetBytes(strSource);
            byte[] TargetBytes = Encoding.Convert(utf8, gb2312, SourceBytes);
            char[] TargetChars = new char[gb2312.GetCharCount(TargetBytes, 0, TargetBytes.Length)];
            gb2312.GetChars(TargetBytes, 0, TargetBytes.Length, TargetChars, 0);
            string gb2312info = new string(TargetChars);
            return gb2312info;



        }

        public static string UnicodeToGB2312(string strSource)
        {
            string gb2312Info = string.Empty;
            Encoding utf8 = Encoding.Unicode;
            Encoding gb2312 = Encoding.GetEncoding("gb2312");
            byte[] SourceBytes = utf8.GetBytes(strSource);
            byte[] TargetBytes = Encoding.Convert(utf8, gb2312, SourceBytes);
            char[] TargetChars = new char[gb2312.GetCharCount(TargetBytes, 0, TargetBytes.Length)];
            gb2312.GetChars(TargetBytes, 0, TargetBytes.Length, TargetChars, 0);
            string gb2312info = new string(TargetChars);
            return gb2312info;




        }

        public static string UnicodeToDefault(string strSource)
        {

            //string   strSource   =   "This   string   contains   the   unicode   character   Pi(\u03a0)";   

            //   Create   two   different   encodings.   
            Encoding ascii = Encoding.Default;
            Encoding unicode = Encoding.Unicode;

            //   Convert   the   string   into   a   byte[].   
            byte[] SourceBytes = unicode.GetBytes(strSource);

            //   Perform   the   conversion   from   one   encoding   to   the   other.   
            byte[] TargetBytes = Encoding.Convert(unicode, ascii, SourceBytes);

            //   Convert   the   new   byte[]   into   a   char[]   and   then   into   a   string.   
            //   This   is   a   slightly   different   approach   to   converting   to   illustrate   
            //   the   use   of   GetCharCount/GetChars.   
            char[] TargetChars = new char[ascii.GetCharCount(TargetBytes, 0, TargetBytes.Length)];
            ascii.GetChars(TargetBytes, 0, TargetBytes.Length, TargetChars, 0);
            string TargetString = new string(TargetChars);
            return TargetString;


        }

        public static string UnicodeToASCII(string strSource)
        {

            //string   strSource   =   "This   string   contains   the   unicode   character   Pi(\u03a0)";   

            //   Create   two   different   encodings.   
            Encoding ascii = Encoding.ASCII;
            Encoding unicode = Encoding.Unicode;

            //   Convert   the   string   into   a   byte[].   
            byte[] SourceBytes = unicode.GetBytes(strSource);

            //   Perform   the   conversion   from   one   encoding   to   the   other.   
            byte[] TargetBytes = Encoding.Convert(unicode, ascii, SourceBytes);

            //   Convert   the   new   byte[]   into   a   char[]   and   then   into   a   string.   
            //   This   is   a   slightly   different   approach   to   converting   to   illustrate   
            //   the   use   of   GetCharCount/GetChars.   
            char[] TargetChars = new char[ascii.GetCharCount(TargetBytes, 0, TargetBytes.Length)];
            ascii.GetChars(TargetBytes, 0, TargetBytes.Length, TargetChars, 0);
            string TargetString = new string(TargetChars);
            return TargetString;


        }

        public static string UnicodeToUTF8(string strSource)
        {

            //string   strSource   =   "This   string   contains   the   unicode   character   Pi(\u03a0)";   

            //   Create   two   different   encodings.   
            Encoding ascii = Encoding.UTF8;
            Encoding unicode = Encoding.Unicode;

            //   Convert   the   string   into   a   byte[].   
            byte[] SourceBytes = unicode.GetBytes(strSource);

            //   Perform   the   conversion   from   one   encoding   to   the   other.   
            byte[] TargetBytes = Encoding.Convert(unicode, ascii, SourceBytes);

            //   Convert   the   new   byte[]   into   a   char[]   and   then   into   a   string.   
            //   This   is   a   slightly   different   approach   to   converting   to   illustrate   
            //   the   use   of   GetCharCount/GetChars.   
            char[] TargetChars = new char[ascii.GetCharCount(TargetBytes, 0, TargetBytes.Length)];
            ascii.GetChars(TargetBytes, 0, TargetBytes.Length, TargetChars, 0);
            string TargetString = new string(TargetChars);
            return TargetString;


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strSource"></param>
        /// <returns></returns>
        public static string GB2312TOUtf8(string strSource)
        {
            string strResult = string.Empty;
            Encoding utf8 = Encoding.UTF8;
            Encoding gb2312 = Encoding.GetEncoding("gb2312");
            byte[] bytSources = gb2312.GetBytes(strSource);
            byte[] bytTargets = Encoding.Convert(gb2312, utf8, bytSources);
            char[] chrTargets = new char[gb2312.GetCharCount(bytTargets, 0, bytTargets.Length)];
            utf8.GetChars(bytTargets, 0, bytTargets.Length, chrTargets, 0);
            strResult = new string(chrTargets);
            return strResult;

        }
        /// <summary>
        /// �������֤��ȡ��������
        /// </summary>
        /// <param name="ID">���֤��</param>
        /// <returns>������ ��:19990101</returns>
        public static string GetBirthdayByIDNumber(string strIDNumber)
        {
            try
            {
                string Birthday = "";
                if (strIDNumber.Length == 15)
                {
                    string ss = strIDNumber.Substring(6, 6);
                    Birthday = "19" + ss;
                }
                else if (strIDNumber.Length == 18)
                {
                    string ss = strIDNumber.Substring(6, 8);
                    Birthday = ss;
                }
                else
                {
                    throw new Exception("������15λ����18λ�����֤��Ϣ��\r\n");
                }
                string year = Birthday.Substring(0, 4);
                string month = Birthday.Substring(4, 2);
                string date = Birthday.Substring(6, 2);
                if (int.Parse(year) < 1900)
                {
                    //��ݲ��ܴ���1900
                    throw new Exception("���֤��Ϣ����, ��ݲ��ܴ���1900��\r\n");
                }
                else if (int.Parse(year) > DateTime.Now.Year)
                {
                    //��ݲ���С���������
                    throw new Exception("���֤��Ϣ����, ��ݲ��ܳ���������ݣ�\r\n");
                }
                else if (int.Parse(month) < 1)
                {
                    //�·ݲ���С��1
                    throw new Exception("���֤��Ϣ����,�·ݲ���С��1��\r\n");
                }
                else if (int.Parse(month) > 12)
                {
                    //�·ݲ��ܴ���12
                    throw new Exception("���֤��Ϣ����,�·ݲ��ܴ���12��\r\n");
                }
                else if (int.Parse(date) < 1)
                {
                    //���ڲ���С��1
                    throw new Exception("���֤��Ϣ����,���ڲ���С��1��\r\n");
                }
                else if (int.Parse(date) > 31)
                {
                    //���ڲ��ܴ���31
                    throw new Exception("���֤��Ϣ����,���ڲ��ܴ���31��\r\n");
                }
                return Birthday;
            }
            catch (Exception objException)
            {
                throw new Exception("��ȡ�������ڳ���\r\n" + objException.Message);
            }
        }

        /// <summary>
        /// ɾ���ڵ���������ַ���ֵ
        /// </summary>
        /// <param name="strSourceStr">Դ�ַ���</param>
        /// <returns>ɾ���ַ���ֵ�������</returns>
        public static string RemoveStringValueInSingleQuotation(string strSourceStr)
        {
            int intPos4FirstQuotation = strSourceStr.IndexOf("'");
            int intPos4SecondQuotation = 0;
            StringBuilder sbTargetStr = new StringBuilder();
            while (true)
            {
                if (intPos4FirstQuotation < 0) break;
                sbTargetStr.Append(strSourceStr.Substring(intPos4SecondQuotation, intPos4FirstQuotation - intPos4SecondQuotation));
                intPos4SecondQuotation = strSourceStr.IndexOf("'", intPos4FirstQuotation + 1);
                if (intPos4SecondQuotation < 0) throw new Exception(string.Format("����������{0}�У������Ų�ƥ�䣬���飡", strSourceStr));
                intPos4SecondQuotation++;
                intPos4FirstQuotation = strSourceStr.IndexOf("'", intPos4SecondQuotation);
                if (intPos4FirstQuotation == -1)
                {
                    sbTargetStr.Append(strSourceStr.Substring(intPos4SecondQuotation));
                    break;
                }
            }
            return sbTargetStr.ToString();
        }

        /// <summary>
        /// ��ȡԴ�ַ�����Ԫ��ֵ�����磺"abcde[ss]111[/ss]", ��ȡԪ��"ss"��ֵ��Ϊ��"111"
        /// </summary>
        /// <param name="strSourceStr">Դ�ַ���</param>
        /// <param name="strElementName">Ԫ����</param>
        /// <returns>��ȡԪ��ֵ</returns>
        public static string GetElementValue(string strSourceStr, string strElementName)
        {
            string strElementValue;
            int intPos4First = strSourceStr.IndexOf(string.Format("[{0}]", strElementName));
            if (intPos4First >= 0)
            {
                int intPos4FirstEnd = intPos4First + strElementName.Length + 1;// strSourceStr.IndexOf(string.Format("]", strElementName), intPos4First + 1);
                //if (intPos4FirstEnd == -1)
                //{
                //    string strMsg = string.Format("��:{0}�У�û��Ԫ�أ�[{1}]", strSourceStr, strElementName);
                //    throw new Exception(strMsg);
                //}
                int intPos4Second = strSourceStr.IndexOf(string.Format("[/{0}]", strElementName), intPos4FirstEnd + 1);
                if (intPos4Second == -1)
                {
                    string strMsg = string.Format("��:{0}�У�ȱ�ٽ���Ԫ�ر�־��[/{1}]", strSourceStr, strElementName);
                    throw new Exception(strMsg);
                }
                strElementValue = strSourceStr.Substring(intPos4FirstEnd + 1, intPos4Second - intPos4FirstEnd - 1);
                return strElementValue;
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// ��Դ�ַ���ȥ��Ԫ��ֵ�����磺"abcde[ss]111[/ss]44", ȥ��Ԫ��"ss"��ֵ��Ϊ��"abcde44"
        /// </summary>
        /// <param name="strSourceStr">Դ�ַ���</param>
        /// <param name="strElementName">Ԫ����</param>
        /// <returns>��ȡԪ��ֵ</returns>
        public static string RemoveElementValue(string strSourceStr, string strElementName)
        {
            StringBuilder sbTargetStr = new StringBuilder();


            int intPos4First = strSourceStr.IndexOf(string.Format("[{0}]", strElementName));
            if (intPos4First < 0) return strSourceStr;
            int intPos4FirstEnd = 0;
            int intPos4Second = 0;
            int intPos4SecordEnd = 0;
            while (true)
            {
                if (intPos4First < 0)
                {
                    sbTargetStr.Append(strSourceStr.Substring(intPos4SecordEnd));
                    break;
                }
                intPos4FirstEnd = intPos4First + strElementName.Length + 1;// strSourceStr.IndexOf(string.Format("]", strElementName), intPos4First + 1);

                sbTargetStr.Append(strSourceStr.Substring(intPos4SecordEnd, intPos4First - intPos4SecordEnd));
                intPos4Second = strSourceStr.IndexOf(string.Format("[/{0}]", strElementName), intPos4FirstEnd + 1);

                if (intPos4Second < 0)
                {
                    string strMsg = string.Format("��:{0}�У�ȱ�ٽ���Ԫ�ر�־��[/{1}]", strSourceStr, strElementName);
                    throw new Exception(strMsg);
                }
                intPos4SecordEnd = intPos4Second + strElementName.Length + 3;
                //intPos4Second++;
                intPos4First = strSourceStr.IndexOf(string.Format("[{0}]", strElementName), intPos4SecordEnd);
            }
            return sbTargetStr.ToString();


        }


        /// <summary>
        /// �������nλ�ַ�
        /// </summary>
        /// <returns></returns>
        public static string MakeRandom()
        {
            string randomchars = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //			int pwdlen=5;
            string tmpstr = "";
            int iRandNum;
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                iRandNum = rnd.Next(randomchars.Length);
                tmpstr += randomchars[iRandNum];
            }
            return tmpstr;
        }
        /// <summary>
        /// �������nλ�ַ�
        /// </summary>
        /// <param name="intNumOfCharacters">�ַ���</param>
        /// <param name="intAdditionalSeed">��������</param>
        /// <returns>����nλ�ַ�</returns>
        public static string MakeRandom(int intNumOfCharacters, int intAdditionalSeed)
        {
            string randomchars = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //			int pwdlen=5;
            string tmpstr = "";
            int iRandNum;
            DateTime dbNow = DateTime.Now;
            int intSeed = (int)dbNow.Ticks;
            Random rnd = new Random(intSeed + intAdditionalSeed);
            for (int i = 0; i < intNumOfCharacters; i++)
            {
                iRandNum = rnd.Next(randomchars.Length);
                tmpstr += randomchars[iRandNum];
            }
            return tmpstr;
        }
        /// <summary>
        /// ����ֽڿ�ĳ���
        /// </summary>
        public static int GetStringLength(string str)
        {
            byte[] bytes = Encoding.Default.GetBytes(str);
            return bytes.Length;
        }
        /// <summary>
        /// ���Ρ���
        /// </summary>
        public static string ReplaceBothWord(object strOld)
        {
            return strOld.ToString().Replace("\"", "'");
        }
        /// <summary>
        /// ���ָ���ַ����ĳ����ַ���
        /// </summary>
        /// <param name="strOld">�ַ���</param>
        /// <param name="intStart">�ַ�����ʼ��ȡ��λ�ã�U</param>
        /// <param name="intCount">����ַ����ֽ���</param>
        /// <param name="bolSign">�Ƿ��ڷ��صĺ����"..."</param>
        /// <returns>����ָ�����ȵ��ַ���</returns>
        public static string GetPayStringLength(string strOld, int intStart, int intCount, bool bolSign)
        {
            if (intStart != 0)
            {
                strOld = strOld.Replace(strOld.Substring(0, intStart), "");
            }
            char[] chrSingle = strOld.ToCharArray();
            string strNew = "";
            int intNewCount = 0;
            int intTemp = 0;
            string strNewTemp = "";
            foreach (char chrTemp in chrSingle)
            {
                if (GetStringLength(chrTemp.ToString()) == 1)
                {
                    strNewTemp = strNew;
                    strNew += chrTemp;
                    intNewCount += 1;
                    intTemp = 1;
                }
                else if (GetStringLength(chrTemp.ToString()) == 2)
                {
                    strNewTemp = strNew;
                    strNew += chrTemp;
                    intNewCount += 2;
                    intTemp = 2;
                }
                if (intNewCount > intCount - 1)
                {
                    if (intTemp == 2)
                    {
                        return GetString(strNewTemp, bolSign);
                    }
                    return GetString(strNew, bolSign);
                }
            }
            return GetString(strNew, bolSign);
        }
        /// <summary>
        /// ��ȡ�ַ������ʡ�Ժ�
        /// </summary>
        /// <param name="strOld">ԭ�ַ���</param>
        /// <param name="bolSign"></param>
        /// <returns></returns>
        public static string GetString(string strOld, bool bolSign)
        {
            if (bolSign == true)
            {
                return strOld + "...";
            }
            return strOld;
        }
        /// <summary>
        /// ָ���ַ�����ָ�����ȵ��ַ���
        /// </summary>
        /// <param name="strOld">ԭ�ַ���</param>
        /// <param name="strNow">���ַ�����</param>
        /// <param name="intCount">����ַ����ֽ���</param>
        /// <param name="intLength">��ȡ�ַ����ĳ��� </param>
        /// <returns>����ָ�����ȵ��ַ���</returns>
        public static string GetPayStringLength(string strOld, string strNow, int intCount, out int intLength)
        {
            strOld = strOld.Substring(strNow.Length);
            char[] chrSingle = strOld.ToCharArray();
            string strNew = "";
            int intNewCount = 0;
            string strNewTemp = "";
            intLength = 0;
            foreach (char chrTemp in chrSingle)
            {
                if (GetStringLength(chrTemp.ToString()) == 1)
                {
                    strNewTemp = strNew;
                    strNew += chrTemp;
                    intNewCount += 1;
                }
                else if (GetStringLength(chrTemp.ToString()) == 2)
                {
                    strNewTemp = strNew;
                    strNew += chrTemp;
                    intNewCount += 2;
                }
                intLength += 1;
                if (intNewCount > intCount - 1)
                {
                    if (GetStringLength(strNew) - intCount >= 1)
                    {
                        intLength -= 1;
                        return strNewTemp;
                    }
                    return strNew;
                }
            }
            return strNew;
        }
        /// <summary>
        /// ���ַ�����ָ�����ȵ��ַ����мӡ�br��
        /// </summary>
        /// <param name="strBr">�ַ���</param>
        /// <param name="intSum" >�ַ��������</param>
        /// <returns>�ַ����мӡ�br��</returns>
        public static string getStrBr(string strBr, int intSum)
        {
            int intStrLength = 0;
            string strReulst = String.Empty;
            string strTemp = String.Empty;
            string strTemp1 = String.Empty;
            int intstrBLong = GetStringLength(strBr.ToString());

            for (int i = 0; i <= intstrBLong; i += intSum)
            {
                strTemp1 = GetPayStringLength(strBr, strTemp, intSum, out intStrLength);
                strTemp += strTemp1;
                strReulst += strTemp1 + "<BR>";
            }
            return strReulst.Substring(0, strReulst.Length - 4);
        }
        /// <summary>
        /// ���Ρ���
        /// </summary>
        public static string GetHostName(string strOld)
        {
            if (strOld.Length <= 2)
            {
                return strOld;
            }
            string strNew = strOld.ToString().Replace("/", "\\").Trim();
            string strTemp = strNew.Substring(2, strNew.Length - 2);
            return "\\\\" + strTemp.Substring(0, strTemp.IndexOf('\\'));
        }
        #region  ��ָ�����ȵ��ַ������б��루������ȳ���len�����Զ����ȡ��
        /// <summary>
        /// ��ָ�����ȵ��ַ������б��루������ȳ���len�����Զ����ȡ��
        /// </summary>
        /// <param name="strSrc">Դ�ַ���</param>
        /// <param name="len">����</param>
        /// <returns></returns>
        public static string GetHtmlFormString(string strSrc, int len)
        {
            string Result = String.Empty;
            //int intlen;
            Result = GetPayStringLength(strSrc, 0, len, false);
            Result = HttpUtility.HtmlEncode(Result);
            return Result.Trim();
        }
        #endregion
        /// <summary>
        /// �Ѽ��Ϻϲ�����
        /// </summary>
        /// <param name="aryBefore">ǰһ������</param>
        /// <param name="aryEnd">��һ������</param>
        /// <returns></returns>
        public static ArrayList CombineArrayList(ArrayList aryBefore, ArrayList aryEnd)
        {
            ArrayList aryResult = new ArrayList();
            try
            {
                if (aryBefore.Count > 0 && aryEnd.Count > 0)
                {
                    for (int i = 0; i < aryEnd.Count; i++)
                    {
                        aryBefore.Add(aryEnd[i].ToString());
                    }
                    aryResult = aryBefore;
                }
                else if (aryBefore.Count == 0)
                {
                    aryResult = aryEnd;
                }
                else if (aryEnd.Count == 0)
                {
                    aryResult = aryBefore;
                }
            }
            catch
            {
                aryResult = null;
            }
            return aryResult;
        }
        /// <summary>
        /// �Ѽ��Ϻϲ�����
        /// </summary>
        /// <param name="aryBefore">ǰһ������</param>
        /// <param name="aryEnd">��һ������</param>
        /// <returns></returns>
        public static List<string> CombineArrayList(List<string> aryBefore, List<string> aryEnd)
        {
            List<string> aryResult = new List<string>();
            try
            {
                if (aryBefore.Count > 0 && aryEnd.Count > 0)
                {
                    for (int i = 0; i < aryEnd.Count; i++)
                    {
                        aryBefore.Add(aryEnd[i].ToString());
                    }
                    aryResult = aryBefore;
                }
                else if (aryBefore.Count == 0)
                {
                    aryResult = aryEnd;
                }
                else if (aryEnd.Count == 0)
                {
                    aryResult = aryBefore;
                }
            }
            catch
            {
                aryResult = null;
            }
            return aryResult;
        }


        /// <summary>
        /// ת���ַ��ĸ�ʽ
        /// </summary>
        /// <param name="SourceDateTime"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static string ConvertDateTimeFormate(string SourceDateTime, int Type)
        {
            string result = SourceDateTime;

            if (Type == 0)
            {
                result = InsertSignOnfixationLengthOfstring(SourceDateTime, "-", 2);
            }
            else if (Type == 1)
            {
                SourceDateTime = SourceDateTime.Trim().Length < 6 ? SourceDateTime.Trim() + "00" : SourceDateTime;
                result = InsertSignOnfixationLengthOfstring(SourceDateTime, ":", 2);
            }
            return result;
        }
        /// <summary>
        /// Ҫת�����ַ���
        /// </summary>
        /// <param name="DataofDateTime">Դ�ַ���</param>
        /// <param name="sign">���� EG:��-��</param>
        /// <param name="length">�Ӵ��ĳ���</param>
        /// <returns></returns>
        private static string InsertSignOnfixationLengthOfstring(string DataofDateTime, string sign, int length)
        {
            string Temp = DataofDateTime;
            string result = String.Empty;
            if (DataofDateTime != "")
            {
                for (int i = length; i <= DataofDateTime.Length; i = i + 3)
                    Temp = Temp.Insert(i, sign);
            }
            return Temp;
        }
        /// <summary>
        /// HTML����
        /// </summary>
        /// <param name="txtstr">Դ��</param>
        /// <returns>���ɲ��ܽ���HTML���͵��ַ���</returns>
        public static string HtmlEncode(string txtstr)
        {
            if (!String.IsNullOrEmpty(txtstr.Trim()))
            {
                txtstr = txtstr.Replace(">", "&gt;");
                txtstr = txtstr.Replace("<", "&lt;");
                txtstr = txtstr.Replace(" ", "&nbsp;");
                txtstr = txtstr.Replace("\"", "&quot;");
                txtstr = txtstr.Replace("\r\n", "<br>");
            }
            return txtstr;
        }
        /// <summary>
        /// Html����Ľ���
        /// </summary>
        /// <param name="txtstr">Դ��</param>
        /// <returns>���ɿ��Խ��͵�HTML����</returns>
        public static string HtmlDecode(string txtstr)
        {
            if (!String.IsNullOrEmpty(txtstr.Trim()))
            {

                txtstr = txtstr.Replace("&gt;", ">");
                txtstr = txtstr.Replace("&lt;", "<");
                txtstr = txtstr.Replace("&nbsp;", " ");
                txtstr = txtstr.Replace("&quot;", "\"");
                txtstr = txtstr.Replace("<br>", "\r\n");
            }
            return txtstr;
        }
        /// <summary>
        /// ����������ַ�
        /// </summary>
        /// <param name="SourceData">Դ�ַ���</param>
        /// <returns></returns>
        public static string FilterSpecilizeString(string SourceData)
        {
            //string[] temp = null;
            string result = String.Empty; ;
            if (!String.IsNullOrEmpty(SourceData))
            {
                result = SourceData.Replace("-", "");
                result = result.Replace("@", "");
                result = result.Replace("~", "");
                result = result.Replace("!", "");
                result = result.Replace("#", "");
                result = result.Replace("$", "");
                result = result.Replace("%", "");
                result = result.Replace("^", "");
                result = result.Replace("&", "");
                result = result.Replace("*", "");
                result = result.Replace("\"", "");
                result = result.Replace("\'", "");
                result = result.Replace("\\", "");
                result = result.Replace("\\\\", "");
                result = result.Replace(";", "");
            }
            return result;
        }
        /// <summary>
        /// �Ѷ������ַ���ת������Ӧ�Ķ���������
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static  byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }

        /// <summary>
        /// �Ѷ���������ת�����ַ���
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string ByteArrayToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0').PadRight(3, ' '));
            return sb.ToString().ToUpper();
        }
        /// <summary>
        /// ��һ���ַ����ֳ�һ��������
        /// </summary>
        /// <param name="strSourceString"></param>
        /// <returns>�����б�</returns>
        public static List<string> SplitWord(string strSourceString)
        {
            List<string> lstWord = new List<string>();
            List<int> lstSplitPos = new List<int>();
            if (strSourceString.Length == 0) return lstWord;
            int intLen = strSourceString.Length;
            string strLastLetter = " ";
            lstSplitPos.Add(0);
            for (int i = 0; i < intLen; i++)
            {
                string strCurrLetter = strSourceString.Substring(i, 1);
                if (IsSplitChar(strLastLetter) == true && IsSplitChar(strCurrLetter) == false)
                {
                    lstSplitPos.Add(i);
                }
                else if (IsSplitChar(strLastLetter) == true && IsSplitChar(strCurrLetter) == true)
                {
                    if (strLastLetter == " " && strCurrLetter == " ")
                    {
                    }
                    else
                    {
                        lstSplitPos.Add(i);
                    }
                }
                else if (IsSplitChar(strCurrLetter) == true && strCurrLetter != " ")
                {
                     lstSplitPos.Add(i);
                }
                strLastLetter = strCurrLetter;
            }
            if (IsSplitChar(strLastLetter) == true)
            {
                lstSplitPos.Add(intLen - 1);
            }
            lstSplitPos.Add(intLen);

            int intCount4Pos = lstSplitPos.Count;
            int intLastPos = lstSplitPos[0];
            for(int i = 1; i<intCount4Pos; i++)
            {
                int intCurrPos = lstSplitPos[i];
                string strWord = strSourceString.Substring(intLastPos, intCurrPos - intLastPos);
                string strWord_Trim = strWord.Trim();
                if (strWord.Length>strWord_Trim.Length)
                {
                    strWord_Trim += " ";
                }
                if (strWord_Trim == " ")
                {
                    lstWord.Add(strWord_Trim);
                }
                else if (string.IsNullOrEmpty(strWord_Trim.Trim() ) == false)
                {
                    lstWord.Add(strWord_Trim);
                }
                intLastPos = intCurrPos;
            }
            return lstWord;
        }
        /// <summary>
        /// �ж��ַ��Ƿ��Ƿָ���
        /// </summary>
        /// <param name="strChar"></param>
        /// <returns>�Ƿ���true, ���򷵻�false</returns>
        public static bool IsSplitChar(string strChar)
        {
            switch (strChar)
            {
                case " ":
                    return true;
                case ",":
                case ".":
                case ";":
                case "?":
                case "!":
                case "|":
                case "+":
                case "-":
                case "=":
                case "/":
                case "(":
                case ")":
                case "<":
                case ">":

                    return true;
                default:
                    return false;

            }
        }
        /// <summary>
        /// ���ַ����б� ��ϳ�һ���ַ���
        /// </summary>
        /// <param name="lstWord">�ַ����б�</param>
        /// <returns>��ϳɵ�һ���ַ���</returns>
        public static string CombineListToString(List<string> lstWord)
        {
            StringBuilder sbCombineStr = new StringBuilder();
            foreach(string strWord in lstWord)
            {
                sbCombineStr.Append(strWord);
            }
            return sbCombineStr.ToString();
        }
        /// <summary>
        /// ���ı���ʽ��ת��ΪHTML�����ʽ
        /// </summary>
        /// <param name="txtstr">Դ��</param>
        /// <returns>���ɲ��ܽ���HTML���͵��ַ���</returns>
        public static string getHtmlEncodeFromTextCode(string txtstr)
        {
            if (!String.IsNullOrEmpty(txtstr.Trim()))
            {
                txtstr = txtstr.Replace(">", "&gt;");
                txtstr = txtstr.Replace("<", "&lt;");
                txtstr = txtstr.Replace(" ", "&nbsp;");
                txtstr = txtstr.Replace("\"", "&quot;");
                txtstr = txtstr.Replace("\r\n", "<br/>");
            }
            return txtstr;
        }
    }
}