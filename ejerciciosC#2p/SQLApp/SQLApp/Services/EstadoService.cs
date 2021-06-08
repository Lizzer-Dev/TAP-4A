using SQLApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace SQLApp.Services
{
    public class EstadoService
    {
        public const string tname = "ESTADOS";

        public static List<Estado> GetAll()
        {
            var result = new List<Estado>();
            using (System.Data.SQLite.SQLiteConnection ctx = DbContext.GetInstance())
            {
                var query = "SELECT * FROM " + tname;
                using (var command = new SQLiteCommand(query, ctx))
                {
                    try
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                result.Add(new Estado
                                {
                                    Id = Convert.ToInt32(reader["id"].ToString()),
                                    Name = reader["name"].ToString(),
                                    Surface = Convert.ToDouble(reader["surface"].ToString())
                                });

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        ex.ToString();
                    }
                }
            }
            return result;
        }

        public static Boolean Insert(Estado estado)
        {
            using ( var ctx = DbContext.GetInstance())
            {
                var query = string.Format("INSERT INTO {0} (id, name, surface) VALUES({1},'{2}', {3})", tname, estado.Id,estado.Name,estado.Surface);
                using (var command=new SQLiteCommand(query,ctx))
                {
                    int v = command.ExecuteNonQuery();
                    if (v > 0) return true;
                    else return false;
                }
            }
        }

        public static Boolean Update(Estado estado)
        {
            using ( var ctx = DbContext.GetInstance())
            {
                var query = string.Format("UPDATE {0} SET name='{1}', surface={2}", tname, estado.Name, estado.Surface);
                using (var command=new SQLiteCommand(query,ctx))
                {
                    int v = command.ExecuteNonQuery();
                    if (v > 0) return true;
                    else return false;
                }
            }
        }
    }
}
