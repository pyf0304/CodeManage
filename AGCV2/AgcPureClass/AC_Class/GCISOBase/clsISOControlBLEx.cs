﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.PureClass;
using AGC.BusinessLogic;

namespace AGC.PureClassEx
{
    public static class clsISOControlBLEx_Static 
    {
        public static void GeneCode(this ISOControlEx objISOControlENEx, StringBuilder strCodeForCs)
        {
            string strType = objISOControlENEx.GetType().Name;
            switch (strType)
            {
                case "ISOstoryBoardEx":
                    ISOstoryBoardEx objISOstoryBoardENEx = objISOControlENEx as ISOstoryBoardEx;
                    objISOstoryBoardENEx.GeneCode( strCodeForCs);
                    break;
                case "ISOviewControllerLayoutGuideEx":
                    ISOviewControllerLayoutGuideEx objISOviewControllerLayoutGuideENEx = objISOControlENEx as ISOviewControllerLayoutGuideEx;
                    objISOviewControllerLayoutGuideENEx.GeneCode( strCodeForCs);
                    break;
                case "ISOsceneEx":
                    ISOsceneEx objISOsceneENEx = objISOControlENEx as ISOsceneEx;
                    objISOsceneENEx.GeneCode( strCodeForCs);
                    break;
                case "ISOStackViewEx":
                    ISOStackViewEx objISOStackViewENEx = objISOControlENEx as ISOStackViewEx;
                    objISOStackViewENEx.GeneCode( strCodeForCs);
                    break;
                case "ISOtextFieldEx":
                    ISOtextFieldEx objISOtextFieldENEx = objISOControlENEx as ISOtextFieldEx;
                    objISOtextFieldENEx.GeneCode( strCodeForCs);
                    break;
                case "ISOviewControllerEx":
                    ISOviewControllerEx objISOviewControllerENEx = objISOControlENEx as ISOviewControllerEx;
                    objISOviewControllerENEx.GeneCode( strCodeForCs);
                    break;
                case "ISOviewEx":
                    ISOviewEx objISOviewENEx = objISOControlENEx as ISOviewEx;
                    objISOviewENEx.GeneCode( strCodeForCs);
                    break;
                case "ISOButtonEx":
                    ISOButtonEx objISOButtonENEx = objISOControlENEx as ISOButtonEx;
                    objISOButtonENEx.GeneCode(strCodeForCs);
                    break;
                case "ISOlabelEx":
                    ISOlabelEx objISOlabelENEx = objISOControlENEx as ISOlabelEx;
                    objISOlabelENEx.GeneCode( strCodeForCs);
                    break;
                case "ISOBarButtonItemEx":
                    ISOBarButtonItemEx objISOBarButtonItemENEx = objISOControlENEx as ISOBarButtonItemEx;
                    objISOBarButtonItemENEx.GeneCode(strCodeForCs);
                    break;
                case "ISONavigationItemEx":
                    ISONavigationItemEx objISONavigationItemENEx = objISOControlENEx as ISONavigationItemEx;
                    objISONavigationItemENEx.GeneCode( strCodeForCs);
                    break;
                case "ISOnavigationBarEx":
                    ISOnavigationBarEx objISOnavigationBarENEx = objISOControlENEx as ISOnavigationBarEx;
                    objISOnavigationBarENEx.GeneCode( strCodeForCs);
                    break;
                case "ISOOutletEx":
                    ISOOutletEx objISOOutletENEx = objISOControlENEx as ISOOutletEx;
                    objISOOutletENEx.GeneCode( strCodeForCs);
                    break;
                case "ISOActionEx":
                    ISOActionEx objISOActionENEx = objISOControlENEx as ISOActionEx;
                    objISOActionENEx.GeneCode( strCodeForCs);
                    break;
                case "ISOAutoresizingMaskEx":
                    ISOAutoresizingMaskEx objISOAutoresizingMaskENEx = objISOControlENEx as ISOAutoresizingMaskEx;
                    objISOAutoresizingMaskENEx.GeneCode( strCodeForCs);
                    break;

                //case "clsISOHeadENEx":
                //    clsISOHeadENEx objISOHeadENEx = objISOControlENEx as clsISOHeadENEx;
                //    clsISOHeadBLEx.GeneCode(objISOHeadENEx, strCodeForCs);
                //    break;
                //case "clsISOBodyENEx":
                //    clsISOBodyENEx objISOBodyENEx = objISOControlENEx as clsISOBodyENEx;
                //    clsISOBodyBLEx.GeneCode(objISOBodyENEx, strCodeForCs);
                //    break;
                //case "clsISOFormENEx":
                //    clsISOFormENEx objISOFormENEx = objISOControlENEx as clsISOFormENEx;
                //    clsISOFormBLEx.GeneCode(objISOFormENEx, strCodeForCs);
                //    break;
                //case "clsISOHtmlTableENEx":
                //    clsISOHtmlTableENEx objISOHtmlTableENEx = objISOControlENEx as clsISOHtmlTableENEx;
                //    clsISOHtmlTableBLEx.GeneCode(objISOHtmlTableENEx, strCodeForCs);
                //    break;
                //case "clsISORowENEx":
                //    clsISORowENEx objISORowENEx = objISOControlENEx as clsISORowENEx;
                //    clsISORowBLEx.GeneCode(objISORowENEx, strCodeForCs);
                //    break;
                //case "clsISOColENEx":
                //    clsISOColENEx objISOColENEx = objISOControlENEx as clsISOColENEx;
                //    clsISOColBLEx.GeneCode(objISOColENEx, strCodeForCs);
                //    break;
                //case "clsISODivENEx":
                //    clsISODivENEx objISODivENEx = objISOControlENEx as clsISODivENEx;
                //    clsISODivBLEx.GeneCode(objISODivENEx, strCodeForCs);
                //    break;
                //case "ISOlabelEx":
                //    ISOlabelEx objISOLabelENEx = objISOControlENEx as ISOlabelEx;
                //    clsISOLabelBLEx.GeneCode(objISOLabelENEx, strCodeForCs);
                //    break;

                //case "clsISOTextBoxENEx":
                //    clsISOTextBoxENEx objISOTextBoxENEx = objISOControlENEx as clsISOTextBoxENEx;
                //    clsISOTextBoxBLEx.GeneCode(objISOTextBoxENEx, strCodeForCs);
                //    break;



                //      case "clsISOLinkButtonENEx":
                //    clsISOLinkButtonENEx objISOLinkButtonENEx = objISOControlENEx as clsISOLinkButtonENEx;
                //    clsISOLinkButtonBLEx.GeneCode(objISOLinkButtonENEx, strCodeForCs);
                //    break;
                //case "clsISOCheckBoxENEx":
                //    clsISOCheckBoxENEx objISOCheckBoxENEx = objISOControlENEx as clsISOCheckBoxENEx;
                //    clsISOCheckBoxBLEx.GeneCode(objISOCheckBoxENEx, strCodeForCs);
                //    break;
                //case "clsISOGridViewENEx":
                //    clsISOGridViewENEx objISOGridViewENEx = objISOControlENEx as clsISOGridViewENEx;
                //    clsISOGridViewBLEx.GeneCode(objISOGridViewENEx, strCodeForCs);
                //    break;

                //case "clsISOTemplateFieldENEx":
                //    clsISOTemplateFieldENEx objISOTemplateFieldENEx = objISOControlENEx as clsISOTemplateFieldENEx;
                //    clsISOTemplateFieldBLEx.GeneCode(objISOTemplateFieldENEx, strCodeForCs);
                //    break;

                //case "clsISOHeaderStyleENEx":
                //    clsISOHeaderStyleENEx objISOHeaderStyleENEx = objISOControlENEx as clsISOHeaderStyleENEx;
                //    clsISOHeaderStyleBLEx.GeneCode(objISOHeaderStyleENEx, strCodeForCs);
                //    break;
                //case "clsISOHeaderTemplateENEx":
                //    clsISOHeaderTemplateENEx objISOHeaderTemplateENEx = objISOControlENEx as clsISOHeaderTemplateENEx;
                //    clsISOHeaderTemplateBLEx.GeneCode(objISOHeaderTemplateENEx, strCodeForCs);
                //    break;
                //case "clsISOItemTemplateENEx":
                //    clsISOItemTemplateENEx objISOItemTemplateENEx = objISOControlENEx as clsISOItemTemplateENEx;
                //    clsISOItemTemplateBLEx.GeneCode(objISOItemTemplateENEx, strCodeForCs);
                //    break;
                //     case "clsISOBoundFieldENEx":
                //    clsISOBoundFieldENEx objISOBoundFieldENEx = objISOControlENEx as clsISOBoundFieldENEx;
                //    clsISOBoundFieldBLEx.GeneCode(objISOBoundFieldENEx, strCodeForCs);
                //    break;
                //       case "clsISOWebUserControlENEx":
                //    clsISOWebUserControlENEx objISOWebUserControlENEx = objISOControlENEx as clsISOWebUserControlENEx;
                //    clsISOWebUserControlBLEx.GeneCode(objISOWebUserControlENEx, strCodeForCs);
                //    break;
                default:
                    throw new Exception(string.Format("类型:{0}不存在,请检查!", strType));
            }
        }
        public static int getSubObjNumForCtlTypeId(this ISOControlEx objISOControlENEx, string strCtlTypeId)
        {
            int intNum = 0;
            foreach (ISOControlEx objSubISOControlENEx in objISOControlENEx.arrSubIsoControlLst2)
            {
                if (objSubISOControlENEx.CtlTypeId == strCtlTypeId) intNum++;
               
            }
            return intNum;
        }
}
}