using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
using Newtonsoft.Json;



namespace test
{
    public class Account
    {
        public string Username { get; set; }
        public int? ID { get; set; }


        public class ClassDB
        {
            OleDbConnection conn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Damian\Desktop\CODING\GibJohn 2\GibJohn 2\GibJohn Database.accdb; Persist Security Info=True");


            public bool login(string uname, string pass)
            {
                if (uname != "" && pass != "")
                {
                    conn.Open();

                    OleDbDataReader reader = null;
                    OleDbCommand command = new OleDbCommand("SELECT * FROM [Table1] WHERE username ='" + uname + "' AND password = '" + pass + "'", conn);

                    reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        Account acc = new Account
                        {
                            Username = uname,
                            ID = (int)reader[0],
                        };
                        string json = JsonConvert.SerializeObject(acc, Formatting.Indented);
                        System.IO.File.WriteAllText(@"C:\Users\Damian\Desktop\CODING\GibJohn 2\GibJohn 2\local.json", json);

                        conn.Close();
                        return true;
                    }
                    else
                    {
                        conn.Close();
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            public void change(string data, string type)
            {
                if (data != "")
                {
                    Account acc = JsonConvert.DeserializeObject<Account>(File.ReadAllText(@"C:\Users\Damian\Desktop\CODING\GibJohn 2\GibJohn 2\local.json"));
                    conn.Open();
                    OleDbCommand command = new OleDbCommand("UPDATE Table1 SET [" + type + "] = '" + data + "' WHERE ID = " + acc.ID + "", conn);
                    command.ExecuteReader();
                    Console.WriteLine("Successful update");
                    conn.Close();
                    

                }
                else
                {
                }
            }
        }
    }
}

