using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteFourierTransform
{
    public class Transform
    {
        public FrequencyDomainSignal PerformTransform(List<int> timeDomainSignal)
        {
            FrequencyDomainSignal result = new FrequencyDomainSignal();
            
            int dataPointCount = timeDomainSignal.Count;

            //foreach frequency
            for(int j=0; j < dataPointCount/2; j++)
            {
                double accumulatedReal = 0;
                double accumulatedImaginary= 0;

                foreach(int dataPoint in timeDomainSignal)
                {
                    double angle = CalculateCosSinAngle(j, j, dataPointCount);
                    accumulatedReal += Math.Cos(angle);
                    accumulatedImaginary += Math.Sin(angle);
                }

                result.RealResult.Add(accumulatedReal);
                result.ImaginaryResult.Add(accumulatedImaginary);
            }

            return result;
        }


        //todo: move this to a new class for better separation?
        public double CalculateCosSinAngle(int frequency, int dataPoint, int dataPointCount)
        {
            return -2 * Math.PI * frequency/*k(frequency)*/ * dataPoint/*n (data point number)*/ / dataPointCount /*N (total number of data points)*/;
        }
    }
}
