using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;


namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    [TestFixture]
    internal class NUnitTest
    {
        [TestCase]
        public void CheckIfAlarmDefaultValue_IsFalse()
        {
            bool defaultAlarmStatus = false;
            Alarm alarm = new Alarm();
            Assert.AreEqual(defaultAlarmStatus, alarm.AlarmOn);
        }


        [TestCase(0, true)]
        [TestCase(16.999, true)]
        [TestCase(17, false)]
        [TestCase(19, false)]
        [TestCase(21, false)]
        [TestCase(21.001, true)]
        [TestCase(10000, true)]
        public void CheckMethod_PopNextPressurePsiValue_From_ISensor(double input, bool expected)
        {
            Mock<ISensor> mockSensor = new Mock<ISensor>();
            mockSensor.Setup(x => x.PopNextPressurePsiValue()).Returns(input);


            Alarm alarm = new Alarm(mockSensor.Object);
            alarm.Check();
            Assert.AreEqual(expected, alarm.AlarmOn);


        }
    }
}
