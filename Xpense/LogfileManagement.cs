using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xpense
{
    class LogfileManagement
    {
        public static string username = Environment.UserName;
        public static string logfilePath = @"C:\Users\"  +  username + @".CP22\Desktop\logfile.txt";
        public static void Write_Logfile(string logfileEvent, string error = "")
        {
            StreamWriter logfileAccess = new StreamWriter(logfilePath , true);
            logfileAccess.WriteLine('\n');
            logfileAccess.WriteLine(Convert.ToString(DateTime.Now));
            if (error != "")
            {
                logfileAccess.WriteLine('\n');
                logfileAccess.WriteLine("!");
                logfileAccess.Write(error);
                logfileAccess.Write("!");
                logfileAccess.WriteLine('\n');
            }
            logfileAccess.WriteLine(logfileEvent);
            logfileAccess.Write("--------------------------------------------------------------");
            logfileAccess.Close();
        }

        
        public static void Read_Logfile()
        {
            if (UserData.AdminAccess == true)
            {
                StreamReader logfileReader = new StreamReader(logfilePath);
                string  logfileContent = logfileReader.ReadToEnd();


                // if there is an error this will output it in red on the console 

                Console.WriteLine("Logfile lenght : " + logfileContent.Length);
                Console.WriteLine("");
                for (int i = 0; i <= logfileContent.Length; i++)
                {
                  
                    if (i < logfileContent.Length)
                    {
                        if (logfileContent[i] == '!')
                        {
                     
                            Console.ForegroundColor = ConsoleColor.Red;
                            i++;
                            while (logfileContent[i] != '!')
                            {

                                Console.Write(logfileContent[i]);

                                i++;
                            }
                            Console.ResetColor();
                        

                        }
                        else Console.Write(logfileContent[i]);

                    }
               
                      //  ConsoleOperations.WriteConsoleColorGreen("End of the string , logfile read ", true);
                   
                  
                }
            }
            
            else
            {
                ConsoleOperations.WriteConsoleErrors("   !!!  You do not have the permission to do this !");
            }
        }
    }
}
