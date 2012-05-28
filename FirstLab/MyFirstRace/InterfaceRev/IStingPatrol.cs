namespace InterfaceRev
{
    interface IStingPatrol
    {
        int AlertLevel { get; }
        int StingerLength { get; set; }
        bool LookForEnemies();
        int SharpensStinger(int length);
    }

    class Bee : IStingPatrol
    {
        public int AlertLevel
        {
            get { throw new System.NotImplementedException(); }
        }

        public int StingerLength
        {
            get { throw new System.NotImplementedException(); }
            set { throw new System.NotImplementedException(); }
        }

        public bool LookForEnemies()
        {
            throw new System.NotImplementedException();
        }

        public int SharpensStinger(int length)
        {
            throw new System.NotImplementedException();
        }
    }
}
