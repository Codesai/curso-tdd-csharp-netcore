using System;

namespace KataTirePressureVariation
{
    public interface ISensor
    {
        double PopNextPressurePsiValue();
    }

    public class Sensor : ISensor
    {
        public const double OFFSET = 16;

        public double PopNextPressurePsiValue()
        {
            var pressureTelemetryValue = SamplePressure();

            return OFFSET + pressureTelemetryValue;
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