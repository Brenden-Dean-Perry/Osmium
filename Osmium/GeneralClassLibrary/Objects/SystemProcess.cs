using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BusinessLogicLibrary.Objects
{
    public class SystemProcess
    {
        private string _ProcessName { get; set; }
        public SystemProcess(string ProcessName)
        {
            _ProcessName = ProcessName.ToLower();
        }

        public void SetProcessName(string ProcessName)
        {
            _ProcessName = ProcessName.ToLower();
        }

        public bool ProcessIsRunning()
        {
            if(ActiveProcessInstanceCount() > 0)
            {
                return true;
            }
            return false;
        }

        public int ActiveProcessInstanceCount()
        {
            return GetProcesses().Count();
        }

        public IEnumerable<Process> GetProcesses()
        {
            return Process.GetProcesses().Where(x => x.ProcessName.ToLower() == _ProcessName).ToList();
        }

        public int TerminateRunningProcesses()
        {
            int ProcessCount = 0;
            foreach(Process process in GetProcesses())
            {
                try
                {
                    process.Kill();
                    ProcessCount++;
                }
                catch{}
            }
            return ProcessCount;
        }
    }
}
