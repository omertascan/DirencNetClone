using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DirencNetClone.Model
{
   
    public  interface ISQLite
    {

        SQLiteConnection GetConnection();
    }
}
