using Logging.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging.Core.Logging
{
    public interface ILoggger
    {
        void Logging(string level, string message);
    }
}
