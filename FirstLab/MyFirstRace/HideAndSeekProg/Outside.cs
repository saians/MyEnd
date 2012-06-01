namespace LongExer
{
    class Outside : Location
    {
        private bool hot;

        public Outside(string name, bool hot)
            : base(name)
        {
            this.hot = hot;

        }

        protected bool Hot
        {
            get { return hot; }
        }

        public override string Description
        {
            get
            {
                string description = "Its very hot here";

                if (hot)
                {
                    return description;
                }

                return "Its hot in the backyard but not in the front yard or garden";
            }
        }
    }
}
