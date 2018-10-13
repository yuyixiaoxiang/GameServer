﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class DBConn
{
    private static string m_DBGameServer;

    public static string DBGameServer
    {
        get
        {
            if (string.IsNullOrEmpty(m_DBGameServer))
            {
                m_DBGameServer = "Data Source=.;Initial Catalog=DBGameServer;User ID=suzhen2;Password=123456"; ; 
            }
            return m_DBGameServer;
        }
    }
}