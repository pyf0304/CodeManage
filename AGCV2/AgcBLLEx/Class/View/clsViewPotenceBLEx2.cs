using System;


namespace AGC.BusinessLogicEx
{
	/// <summary>
	/// clsViewPotenceEx ��ժҪ˵����
	/// </summary>
	public class clsViewPotenceBLEx 
	{
		

		public System.Data.DataTable GetViewPotence1(string strViewId)
		{
			//��������:
			//1�����ؼ����Ƿ�Ϊ�գ�
			//2��IF (���ùؼ��ֵļ�¼��ViewPotence���Ƿ����)��
			///   {
			///        ��ViewPotence�л�ȡ�ùؼ��ֵļ�¼��Ϣ
			///   }
			///   ELSE IF (���ùؼ��ֵļ�¼��ViewInfo���Ƿ����)
			///   {
			///			��ViewInfo�л�ȡ�ùؼ��ֵļ�¼��Ϣ
			///   }
			///   ELSE
			///   {
			///         ����NULL
			///   }

			//1�����ؼ����Ƿ�Ϊ�գ�
//			if (strViewId  ==  "") return null;		//����ؼ���Ϊ�վͷ����˳�
//			//2��IF (���ùؼ��ֵļ�¼��ViewPotence���Ƿ����)��
//			///   {
//
//			///        ��ViewPotence�л�ȡ�ùؼ��ֵļ�¼��Ϣ
//			///   }
//			if (clsViewPotence.IsExist(strViewId)  ==  true)		//���ùؼ��ֵļ�¼�Ƿ����
//			{
//				ViewId = strViewId;
//				return  base.GetViewPotence();
//			}
//			else if (clsViewInfoBL.IsExist(strViewId)  ==  true)
//			{
//				///   ELSE IF (���ùؼ��ֵļ�¼��ViewInfo���Ƿ����)
//				///   {
//				///			��ViewInfo�л�ȡ�ùؼ��ֵļ�¼��Ϣ
//				///   }
//				return	clsViewInfoBL.GetViewInfo(string.Format("ViewId = '{0}'", strViewId));
//				
//			}
//			///   ELSE
//			///   {
//			///         ����NULL
//			///   }
//
//			
//			if (clsViewInfoBL.IsExist(strViewId)  ==  false)		//���ùؼ��ֵļ�¼�Ƿ����
//			{
//				string ss = "�ؼ���Ϊ:" + strViewId + "�Ĳ�����!";
//				Response.Write("<script>alert('" + ss + "')</script>");
//				return ;
//			}
//			//3�����ṩ�Ĺؼ��ֳ�ʼ��һ�������
//			clsViewInfoEN objViewInfo = new clsViewInfoEN(strViewId);
//			//4����ȡ�������������ԣ�
//			objViewInfo.GetViewInfo();
//			Session.Add("objViewInfo", objViewInfo);
//			//5���Ѹö��������������ʾ�ڽ�����,��������ʾ�ڱ�ؼ���
//			GetDataFromViewInfoClass(objViewInfo);
return null;
		}
	}
}
