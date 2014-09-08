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
            
            //foreach frequency
            for (int k = 0; k <= timeDomainSignal.Count / 2; k++)
            {
                double accumulatedReal = 0;
                double accumulatedImaginary= 0;

                for (int i = 0; i < timeDomainSignal.Count; i++)
                {
                    double angle = CalculateCosSinAngle(k, i, timeDomainSignal.Count);
                    accumulatedReal += timeDomainSignal[i] * Math.Cos(angle);                                        
                    accumulatedImaginary += timeDomainSignal[i] * Math.Sin(angle);                
                }

                result.RealResult.Add(accumulatedReal);
                
                //must negate imaginary
                result.ImaginaryResult.Add(-accumulatedImaginary);
            }

            return result;
        }


        //todo: move this to a new class for better separation?
        //todo:  could extract @ PI * k / N out for re-use, then just multiply it by i every time
        public double CalculateCosSinAngle(int frequency, int dataPointPosition, int totalDataPointCount)
        {            
            //2 PI*ki/N
            //
            return 2 * Math.PI * frequency/*k(frequency)*/ * dataPointPosition/*n (data point number)*/ / totalDataPointCount /*N (total number of data points)*/;
        }
    }
}
