using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Text;

namespace SQLApp.Services
{
    public class DbContext
    {
        private const string DBname = "database.sqlite";
        private const string SQLScript = @"..\..\db\db.sql";
        private static bool IsDbRecentlyCreated = false;

        public static void Up()
        {
            if (!System.IO.File.Exists(Path.GetFullPath(DBname))){
                SQLiteConnection.CreateFile(DBname);
                IsDbRecentlyCreated = true;
            }
            using (var ctx = GetInstance())
            {
                if (IsDbRecentlyCreated)
                {
                    using (var reader = new StreamReader(Path.GetFullPath(SQLScript)))
                    {
                        var query = "";
                        var line = "";
                        while ((line=reader.ReadLine())!=null)
                        {
                            query += line;
                        }

                        using(var command=new SQLiteCommand(query, ctx))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        public static SQLiteConnection GetInstance()
        {
            var db = new SQLiteConnection(
                string.Format("Data Source={0};Version=3;",DBname 
                ));
            db.Open();
            return db;
        }
    }
}
