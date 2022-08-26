using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


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

    }
}
