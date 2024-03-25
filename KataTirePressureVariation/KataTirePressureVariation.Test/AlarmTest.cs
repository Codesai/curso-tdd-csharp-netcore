using NUnit.Framework;

namespace KataTirePressureVariation.Test
{
    public class AlarmShould
    {
        [Test]
        public void Thinks_In_What_We_Need_To_Test()
        {
            var alarm = new Alarm();
            
            alarm.Check();
            
            Assert.That(false, Is.True);
        }
        
    
    }
}