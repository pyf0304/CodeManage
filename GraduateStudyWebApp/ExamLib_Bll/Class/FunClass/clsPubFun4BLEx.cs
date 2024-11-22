using ExamLib.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLib.BusinessLogicEx
{
    public class clsPubFun4BLEx
    {
        public static void SetCommFun4BL()
        {
            //---------A-----------//

            clsQuestionTypeBL.objCommFun4BL = new clsCommFun4BL4QuestionType();
            clsUserStateBL.objCommFun4BL = new clsCommFun4BL4UserState();
            clsQxUserIdentityBL.objCommFun4BL = new clsCommFun4BL4QxUserIdentity();
            clsSysDefaValNameBL.objCommFun4BL = new clsCommFun4BL4SysDefaValName();
            clsCacheModeBL.objCommFun4BL = new clsCommFun4BL4CacheMode();
            clsPageDispModeBL.objCommFun4BL = new clsCommFun4BL4PageDispMode();
        }

    }
}
