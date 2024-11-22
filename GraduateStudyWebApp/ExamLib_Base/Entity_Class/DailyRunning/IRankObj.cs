using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamLib.Entity
{
    public interface IRankObj1
    {
        double Score
        {
            get;
            set;
        }
        double Percentile
        {
            get;
            set;
        }
        int Ranking
        {
            get;
            set;
        }
    }

    public class clsRankObj
    {
        public virtual  double Score
        {
            get;
            set;
        }
        public virtual double Percentile
        {
            get;
            set;
        }
        public virtual int Ranking
        {
            get;
            set;
        }
    }
}
