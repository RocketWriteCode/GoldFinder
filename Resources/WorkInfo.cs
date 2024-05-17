using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldFinder.Resources
{
    public class WorkInfo
    {
        public double lowQualityWork, mediumQualityWork, highQualityWork;

        public WorkInfo(double inLowQuality, double inMediumQuality, double inHighQuality)
        {
            lowQualityWork = inLowQuality;
            mediumQualityWork = inMediumQuality;
            highQualityWork = inHighQuality;
        }

        public WorkInfo(string inLowQuality, string inMediumQuality, string inHighQuality)
        {
            lowQualityWork = double.Parse(inLowQuality);
            mediumQualityWork = double.Parse(inMediumQuality);
            highQualityWork = double.Parse(inHighQuality);
        }

        public WorkInfo() { }
    }
}
