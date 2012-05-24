using System.Windows.Forms;

namespace BMS
{
    class Worker
    {
        //public readonly string CurrentJob;
        public readonly int shiftsLeft;
        private string[] jobICanDo;
        private int shiftsToWork;
        private int shiftsWorked;
        private string currentJob = "";

        public Worker(string[] workers)
        {
            this.jobICanDo = jobICanDo;
        }

        public int ShiftsLeft
        {
            get { return shiftsToWork - shiftsWorked; }
        }

        public string CurrentJob
        {
            get { return currentJob; }
        }

        public bool DoThisJob(string job, int numberOfShifts)
        {
            if (!string.IsNullOrEmpty(currentJob))
                return false;

            for (int i = 0; i < jobICanDo.Length; i++)

                if (jobICanDo[i] == job)
                {
                    currentJob = job;
                    this.shiftsToWork = numberOfShifts;
                    shiftsWorked = 0;
                    return true;
                }
            return false;
        }

        public bool WorkOneShift()
        {
            if (string.IsNullOrEmpty(currentJob))
                return false;
            shiftsWorked++;
            if (shiftsWorked > shiftsToWork)
            {
                shiftsWorked = 0;
                shiftsToWork = 0;
                currentJob = "";
                return true;
            }
            else
            {
                return false;
            }
        }




    }
}
