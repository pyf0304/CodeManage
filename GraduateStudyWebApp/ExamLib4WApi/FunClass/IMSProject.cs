using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLib4WApi
{
    public interface IMSProject
    {
        IEnumerable<string> GetCompileFileLst(string strPrjFileName);
    }
}
