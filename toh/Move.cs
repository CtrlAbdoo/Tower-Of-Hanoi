namespace toh
{
    public class Move
    {
        public Pole FromPole { get; set; }
        public Pole ToPole { get; set; }

        public Move(Pole fromPole, Pole toPole)
        {
            this.FromPole = fromPole;
            this.ToPole = toPole;
        }
        public bool AffectCount()
        {
            if (ToPole.Equals(FromPole))
            {
                return false;
            }
            return IsValid();
        }            
        public bool IsValid()
        {
            if (ToPole.Equals(FromPole))
            {
                return true;
            }
            return ToPole.AllowDisk(FromPole.GetTopDisk());
        }
        public Move(int fromPoleNumber, int toPoleNumber)
        {
            this.FromPole = GameState.Poles[fromPoleNumber];
            this.ToPole = GameState.Poles[toPoleNumber];
        }
        override public string ToString()
        {
            if (FromPole == null || ToPole == null)
            {
                return "Missing poles";
            }
            return "Move the top disk from " + FromPole.ToString() + " to " + ToPole.ToString() + "\n";
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Move move = obj as Move;
            if ((System.Object)move == null)
            {
                return false;
            }
            return move.FromPole.Number == move.FromPole.Number &&
                move.ToPole.Number == move.ToPole.Number;
        }
    }
}