using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171216HW
{
    [Flags]
    enum WeatherCondition : ushort
    {
        NoData = 0x0000,             //0000 0000 0000 0000
        Sunny = 0x0001,              // 0000 0000 0000 0001
        PartlyCloudy = 0x0002,       // 0000 0000 0000 0010
        Rain = 0x0004,               // 0000 0000 0000 0100
        Snow = 0x0008,               // 0000 0000 0000 1000
        Grad = 0x0010,               // 0000 0000 0001 0000
        StrongWind = 0x0020,         // 0000 0000 0010 0000
        WithoutWind = 0x0040,        // 0000 0000 0100 0000
        LightWind = 0x0080,          // 0000 0000 1000 0000
        MediumWind = 0x0100,         // 0000 0001 0000 0000
        Hot = 0x0200,                // 0000 0010 0000 0000
        Cold = 0x0400,               // 0000 0100 0000 0000
        Heat = 0x0800,               // 0000 1000 0000 0000
        BitCold = 0x1000,            // 0001 0000 0000 0000
        ExtremelyCold = 0x2000,      // 0010 0000 0000 0000
        ExtremelyHot = 0x4000,       // 0100 0000 0000 0000
        LastWeatherValue = 0x8000    // 1000 0000 0000 0000
    }
}
