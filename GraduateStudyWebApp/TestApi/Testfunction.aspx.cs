
using ExamLib.BusinessLogic;
using ExamLib.BusinessLogicEx;
using ExamLib.BusinessLogicExs;
using ExamLib.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestApi
{
    public partial class Testfunction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            string UpdUserId = "pyf";
            bool i = clsSysCommentBLEx.GetTotalRevalidation(UpdUserId);
            if (i == true)
            {
                Response.Write("<script>alert('核算完毕')</script>");
            }
            else
            {
                Response.Write("<script>alert('核算失败')</script>");
            }
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            bool i = clsSysCommentBLEx.PersonalScoreStatistics("0310276", "1221","02","root","00000048");
            if (i == true)
            {
                Response.Write("<script>alert('核算完毕')</script>");
            }
            else
            {
                Response.Write("<script>alert('核算失败')</script>");
            }
        }


       
protected void btn3_Click(object sender, EventArgs e)
        {
            List<clsUsersEN> userList = clsUsersBL.GetObjLst("UserId='0310276'");

            if (userList.Count > 0)
            {
                Response.Write("<script>alert('成功')</script>");
            }
            else
            {
                Response.Write("<script>alert('获取失败')</script>");
            }
        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            bool i = clsgs_TotalDataStatisticsBLEx.GetTotalStatisticsByTable("00000048", "00701");
            if (i == true)
            {
                Response.Write("<script>alert('同步完毕')</script>");
              
            }
            else
            {
                Response.Write("<script>alert('同步失败')</script>");
            }
        }
            //根据开始日期 结束日期 返回周
            protected void btn5_Click(object sender, EventArgs e)
        {
            //string txtBeginDate = "2020-06-01 10:06:10";
            //string txtCurrDate = "2020-06-23 10:06:10";

            string txtBeginDate = "2020-06-01";
            string txtCurrDate = "2020-06-23";
            lblMsg.Text = clsgs_TotalDataStatisticsBLEx.GetWeekByDate(txtBeginDate,txtCurrDate).ToString();

            lblMsg.Text += clsgs_TotalDataStatisticsBLEx.GetMonthDate("2020-06-23 10:06:10");
        }




        #region 根据传入的日期，需要增加的天数返回一个字符串
        /// <summary>
        /// 根据传入的日期，需要增加的天数返回一个字符串
        /// </summary>
        /// <param name="data"></param>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReTime(string data, int str)
        {
            DateTime dt = DateTime.Parse(data);
            int year = dt.Year;
            int month = dt.Month;
            int day = dt.Day;
            int n = DateTime.DaysInMonth(year, month);
            int k = day + str;
            if (k > n)
            {
                day = str - (n - day);
                month = month + 1;
                if (month > 12)
                {
                    month = 1;
                    year = year + 1;
                }
            }
            else
            {
                day = day + str;
            }
            string c = year + "-" + month + "-" + day;
            return c;
        }
        #endregion

        protected void Button1_Click(object sender, EventArgs e)
        {
            lblMsg.Text = ReTime("2020-03-02",28);
        }
    }
}