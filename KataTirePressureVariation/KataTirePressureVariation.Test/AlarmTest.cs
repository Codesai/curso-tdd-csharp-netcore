using System;
using System.Collections.Generic;
using NSubstitute;
using NSubstitute.Exceptions;
using Xunit;

namespace KataTirePressureVariation.Test
{
    public class AlarmShould
    {
        [Fact]
        public void thinks_in_what_we_need_to_test()
        {
            var alarm = new Alarm();
            
            alarm.Check();
            
            Assert.True(false);
        }
        
    
    }
}