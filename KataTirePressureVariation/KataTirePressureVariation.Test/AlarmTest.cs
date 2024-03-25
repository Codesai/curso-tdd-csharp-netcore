using NUnit.Framework;

namespace KataTirePressureVariation.Test
{
    public class AlarmShould
    {
        [Test]
        public void thinks_in_what_we_need_to_test()
        {
            var alarm = new Alarm();
            
            alarm.Check();
            
            Assert.That(false, Is.True);
        }
        
    
    }
}