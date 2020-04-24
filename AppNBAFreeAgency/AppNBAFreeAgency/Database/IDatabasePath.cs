using System;
using System.Collections.Generic;
using System.Text;

namespace AppNBAFreeAgency.Database
{
    interface IDatabasePath
    {
        string GetPath(string DatabaseName);
    }
}
