namespace FitnessTracker
{
    public class Running : Activity
    {
        private double _distance;

        public Running(DateTime date, int minutes, double distance) : base(date, minutes)
        {
            _distance = distance;
        }

        public override double GetDistance()
        {
            return _distance;
        }

        public override double GetSpeed()
        {
            return (_distance / Minutes) * 60;
        }

        public override double GetPace()
        {
            return Minutes / _distance;
        }
    }
}