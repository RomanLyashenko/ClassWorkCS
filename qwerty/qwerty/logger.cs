using System.Diagnostics;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace qwerty
{
    internal class logger
    {
        string path;
        bool isActive = false;
        public void logging(string warning)
        {

            if (!isActive)
            {
                Trace.Listeners.Add(new TextWriterTraceListener(path));
                Trace.AutoFlush = true;
                Trace.WriteLine(warning);
                isActive = true;
            }
            Trace.WriteLine(warning);
        }       
    } 
}