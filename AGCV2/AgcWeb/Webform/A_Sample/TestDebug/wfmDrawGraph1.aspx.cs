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
	/// wfmDrawGraph1 ��ժҪ˵����
	/// </summary>
	public partial class wfmDrawGraph1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
			Bitmap bm = new Bitmap ( 600 , 250 ) ;
			//����һ������Ϊ600�����Ϊ250��Bitmapʵ��
			Graphics g ;
			g = Graphics.FromImage ( bm ) ;
			//�ɴ�Bitmapʵ������Graphicʵ��
			g . Clear ( Color . Snow ) ;
			//			Brush brush = new Brush();
			Pen mThinPen = new Pen(Color.Red, 1.0f);
			g.DrawLine(mThinPen,new Point(10,10), new Point(200,200));
			//��Snowɫ��Ϊ����ɫ���˻滭ͼ��
			g . DrawString ( " ������˾��������2002����������һ����" , new Font ( "����" , 16 ) , Brushes . Black , new Point ( 5 , 5 ) ) ;
			//�ڻ滭ͼ���ָ��λ�ã���ָ�������塢ָ������ɫ����ָ�����ַ�������Ϊͼ�����
			//���´�������ʵ��ͼ01�е����ϲ�
			Point myRec = new Point ( 535 , 30 ) ;
			Point myDec = new Point ( 560 , 26 ) ;
			//��������ͼ01��Ϊ������ƶ�λ
			g . DrawString ( "��λ������" , new Font ( "����" , 9 ) , Brushes . Black , new Point ( 525 , 12 ) ) ;
			//���´����ǻ���ͼ01�еı߿򣬲��γ�Jpeg�ļ������������ʾ����
			Pen p = new Pen ( Color.Black , 2 ) ;
			g . DrawRectangle ( p , 1 , 1 , 598 , 248 ) ;
            //HouseManLib.clsMyObj objTT1 = new HouseManLib.clsMyObj();
            //objTT1.Draw(g);
			bm.Save(Response.OutputStream , System.Drawing.Imaging.ImageFormat.Jpeg ) ;
		}

	}
}
