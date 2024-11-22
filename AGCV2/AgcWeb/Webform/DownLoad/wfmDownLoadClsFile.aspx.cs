using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace AGC.Webform
{
    /// <summary>
    /// wfmDownLoadClsFile ��ժҪ˵����
    /// </summary>
    public partial class wfmDownLoadClsFile : System.Web.UI.Page
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {
            // �ڴ˴������û������Գ�ʼ��ҳ��
            if (qsParentPage == "HomePage")
            {
                spanReturn.Visible = false;
            }
            else
            {
                spanReturn.Visible = true;
            }
        }


        /// <summary>
        /// ���ܣ������ļ����ӷ����������ļ����ͻ��������
        /// </summary>
        /// <param name="strDownLoadFileName">��Ҫ���ص��ļ��������ļ���Ϊ��Ŀ¼���ļ�ȫ��</param>
        /// <returns></returns>
        private bool DownLoadFile(string strDownLoadFileName)
        {
            //			string path = "D:\\�Ŀ�����������Լ��.doc";		//WORD�ļ�����ֱ������
            ///			string path = "D:\\1000010811.JPG";	//JPG�ļ���������ʾ���һ�����
            System.IO.FileInfo file = new System.IO.FileInfo(strDownLoadFileName);
            Response.Clear();
            //Response.AddHeader("Content-Disposition", "inline; filename=" + HttpUtility.UrlEncode(file.Name)); 
            Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(file.Name));
            Response.AddHeader("Content-Length", file.Length.ToString());
            Response.ContentType = "application/octet-stream";
            Response.WriteFile(file.FullName);
            Response.End();
            return true;
        }

        protected void lbDownSQL_Click(object sender, System.EventArgs e)
        {
            string strFileName = "clsSQL.rar";
            string strFolderName;
            string strDownLoadFileName;
            strFolderName = Server.MapPath("~/RelateFile/");
            strDownLoadFileName = strFolderName + strFileName;
            DownLoadFile(strDownLoadFileName);
        }

        protected void lbDownSpecSQL_Click(object sender, System.EventArgs e)
        {
            string strFileName = "clsSpecSQLforSql.rar";
            string strFolderName;
            string strDownLoadFileName;
            strFolderName = Server.MapPath("~/RelateFile/");
            strDownLoadFileName = strFolderName + strFileName;
            DownLoadFile(strDownLoadFileName);
        }

        protected void lbDownGeneTab_Click1(object sender, EventArgs e)
        {
            string strFileName = "clsGeneralTab.rar";
            string strFolderName;
            string strDownLoadFileName;
            strFolderName = Server.MapPath("~/RelateFile/");
            strDownLoadFileName = strFolderName + strFileName;
            DownLoadFile(strDownLoadFileName);
        }

        protected void lbDownPubDataBase_Click(object sender, EventArgs e)
        {
            string strFileName = "���ݵײ�.rar";
            string strFolderName;
            string strDownLoadFileName;
            strFolderName = Server.MapPath("~/RelateFile/");
            strDownLoadFileName = strFolderName + strFileName;
            DownLoadFile(strDownLoadFileName);
        }

        protected void lbDownCommFunc4Web_Click(object sender, EventArgs e)
        {
            string strFileName = "����Web�ĳ��ú���.rar";
            string strFolderName;
            string strDownLoadFileName;
            strFolderName = Server.MapPath("~/RelateFile/");
            strDownLoadFileName = strFolderName + strFileName;
            DownLoadFile(strDownLoadFileName);
        }

        protected void lbDownCommFunc4Win_Click(object sender, EventArgs e)
        {
            string strFileName = "����Win�ĳ��ú���.rar";
            string strFolderName;
            string strDownLoadFileName;
            strFolderName = Server.MapPath("~/RelateFile/");
            strDownLoadFileName = strFolderName + strFileName;
            DownLoadFile(strDownLoadFileName);
        }

        protected void lbDownExportExcel_Click(object sender, EventArgs e)
        {
            string strFileName = "����Excel�����Ĺ�����.rar";
            string strFolderName;
            string strDownLoadFileName;
            strFolderName = Server.MapPath("~/RelateFile/");
            strDownLoadFileName = strFolderName + strFileName;
            DownLoadFile(strDownLoadFileName);
        
        }

        protected void lbDownGeneralPlatform4WS_Click(object sender, EventArgs e)
        {
            string strFileName = "�û�����ͳһƽ̨������.rar";
            string strFolderName;
            string strDownLoadFileName;
            strFolderName = Server.MapPath("~/RelateFile/");
            strDownLoadFileName = strFolderName + strFileName;
            DownLoadFile(strDownLoadFileName);
        }

        protected void lbDownSimplePrj_Click(object sender, EventArgs e)
        {
            string strFileName = "SamplePrj2016.rar";
            string strFolderName;
            string strDownLoadFileName;
            strFolderName = Server.MapPath("~/RelateFile/");
            strDownLoadFileName = strFolderName + strFileName;
            DownLoadFile(strDownLoadFileName);
        }

        protected void lbDownWinClient_Click(object sender, EventArgs e)
        {
            string strFileName = "Agc_CsWinSetup.rar";
            string strFolderName;
            string strDownLoadFileName;
            strFolderName = Server.MapPath("~/RelateFile/");
            strDownLoadFileName = strFolderName + strFileName;
            DownLoadFile(strDownLoadFileName);
        }
        //��������洫����ObjId(����ID)
        private string qsParentPage
        {
            get
            {
                string strParentPage = Request.QueryString["ParentPage"] ?? "".ToString();
                if ((strParentPage != null) && (strParentPage != ""))
                {
                    return strParentPage;//Request.QueryString["id"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }

        protected void lbDownAndroidSample_Click(object sender, EventArgs e)
        {
            string strFileName = "ExamLib.rar";
            string strFolderName;
            string strDownLoadFileName;
            strFolderName = Server.MapPath("~/RelateFile/");
            strDownLoadFileName = strFolderName + strFileName;
            DownLoadFile(strDownLoadFileName);
        }
    }
}
