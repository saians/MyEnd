namespace BMS
{
    class Queen
    {
        private Worker[] workers;
        private int shiftNumber;

        public Queen(Worker[] workers)
        {
            this.workers = workers;
        }

        public bool AssignWork(string job, int numOfShifts)
        {
            for (int i = 0; i < workers.Length; i++)
                if (workers[i].DoThisJob(job, numOfShifts))
                    return true;
            return false;

        }

        public string WorkTheNextShift()
        {
            shiftNumber++;
            string report = "Report for shift #" + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].WorkOneShift())
                    report += "Worker #" + (i + 1) + "finished the job\r\n";
                if (string.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Worker #" + (i + 1) + "is not working\r\n";
                else
                    if (workers[i].ShiftsLeft > 0)
                        report += "Worker #" + (i + 1) +
               "is doing '" + workers[i].CurrentJob + "'for " + workers[i].ShiftsLeft + "more shifts \r \n";
                    else
                        report += "Worker #" + (i + 1) + "will be done with" + workers[i].CurrentJob + "after this shift\r\n";
            }
            return report;
        }

    }
}
