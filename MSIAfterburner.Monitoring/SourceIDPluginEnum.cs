using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSIAfterburner.Monitoring
{
    public enum SourceIDPluginEnum : uint
    {
        GPU = 0x000000F0,
        CPU = 0x000000F1,
        Motherboard = 0x000000F2,
        RAM = 0x000000F3,
        HDD = 0x000000F4,
        NET = 0x000000F5,
        PSU = 0x000000F6,
        UPS = 0x000000F7,
        Misc = 0x000000FF
    }
}
