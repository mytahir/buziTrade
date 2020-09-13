using System;
using System.Collections.Generic;
using System.Text;

namespace buziTrade
{
    public interface ISQLiteInterface
    {
       SQLiteConnection GetSQLiteConnection();
    }
}
