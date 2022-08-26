namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    public class Alarm
    {

        private readonly ISensor _sensor;

        // Constructor injection with optional parameter
        // use parameter for testing and passing Mock objects
        // don't use parameter for production
        public Alarm(ISensor sensor = null)
        {
            _sensor = sensor ?? new Sensor();
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
