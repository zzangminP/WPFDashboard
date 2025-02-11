using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPfDashboard.Interfaces;

namespace WPfDashboard.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime? GetCurrentTime()
        {
            return DateTime.Now;
        }
    }
}
