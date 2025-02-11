using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace WPfDashboard.Interfaces
{
    public interface IDateTime
    {
        DateTime? GetCurrentTime();
    }
}
