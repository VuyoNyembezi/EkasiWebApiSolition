﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkasiServices.LoggingServices
{
    public interface ILogsManager
    {
        void Infor(string message);
        void Error(string message);
        void Debug(string message);
        void Warning(string message);
    }
}
