using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiscreteFourierTransform;

namespace DiscreteFourierTransform.Test
{
    [TestClass]
    public class TransformInverseTransformTest
    {
        [Ignore]
        [TestMethod]     
        public void PerformTransformInverseTransformTest()
        {
            //todo: create randomized signal instead of hard-coded one.
            List<int> inputTimeDomain = new List<int>(){
                4,
                0,
                0,
                0
            };

            Transform transform = new Transform();
            InverseTransform inverseTransform = new InverseTransform();

            List<int> outputTimeDomain = inverseTransform.PerformInverseTransform(transform.PerformTransform(inputTimeDomain));

            Assert.AreEqual(inputTimeDomain, outputTimeDomain);        
        }

        [Ignore]
        [TestMethod]
        public void PerformTransformTest()
        {
            List<int> inputTimeDomain = new List<int>(){
                4,
                0,
                0,
                0
            };

            Transform transform = new Transform();
            FrequencyDomainSignal frequencyDomainSignal = transform.PerformTransform(inputTimeDomain);

            Assert.AreEqual(1, frequencyDomainSignal.RealResult[0]);
            Assert.AreEqual(1, frequencyDomainSignal.RealResult[1]);
            Assert.AreEqual(1, frequencyDomainSignal.RealResult[2]);
            Assert.AreEqual(1, frequencyDomainSignal.RealResult[3]);
        }

        [TestMethod]
        public void PerformTransformTestSimple()
        {
            List<int> inputTimeDomain = new List<int>(){
                1,
                -1
            };

            Transform transform = new Transform();
            FrequencyDomainSignal frequencyDomainSignal = transform.PerformTransform(inputTimeDomain);

            //not sure what is expected yet
            Assert.AreEqual(1, frequencyDomainSignal.RealResult[0]);
            Assert.AreEqual(1, frequencyDomainSignal.RealResult[1]);
        }
    }
}
