using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteFourierTransform
{
    public class FrequencyDomainSignal
    {
        public FrequencyDomainSignal()
        {
            RealResult = new List<double>();
            ImaginaryResult = new List<double>();
        }
                
        public List<double> RealResult { get; set; }
        public List<double> ImaginaryResult { get; set; }    
    }
}
