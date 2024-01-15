using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Changal.Infra
{
    public class SaveToFile : ILog
    {
        public void Log(string message)
        {
            using (StreamWriter sr=new StreamWriter("Log.txt"))
            {
               sr.WriteLine(message);
               sr.Close();
            }

        }
    }
}
