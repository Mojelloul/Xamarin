﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gatherman.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
