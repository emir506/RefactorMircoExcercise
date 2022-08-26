namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    public class Alarm
    {
        private readonly ISensor _sensor;

        public Alarm()
        {
            _sensor = new Sensor();
        }

        bool _alarmOn = false;

        public void Check()
        {
            double psiPressureValue = _sensor.PopNextPressurePsiValue();

            if (psiPressureValue < AlarmConfigData.LowPressureThreshold || AlarmConfigData.HighPressureThreshold < psiPressureValue)
            {
                _alarmOn = true;
            }

        }

        public bool AlarmOn
        {
            get { return _alarmOn; }
        }

    }
}
