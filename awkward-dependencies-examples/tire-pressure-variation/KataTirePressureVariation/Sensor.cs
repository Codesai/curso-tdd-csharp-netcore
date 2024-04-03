using System;

namespace KataTirePressureVariation
{
    public class Sensor 
    {
        private const double Offset = 16;

        public double PopNextPressurePsiValue()
        {
            var pressureTelemetryValue = SamplePressure();

            return Offset + pressureTelemetryValue;
        }

        private static double SamplePressure()
        {
            // placeholder implementation that simulate a real sensor in a real tire
            var basicRandomNumbersGenerator = new Random();
            var pressureTelemetryValue =
                6 * basicRandomNumbersGenerator.NextDouble() * basicRandomNumbersGenerator.NextDouble();
            return pressureTelemetryValue;
        }
    }
}