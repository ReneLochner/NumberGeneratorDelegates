namespace NumberGenerator.Logic
{
    public interface IObservable
    {
        public NextNumberHandler NextNumber { get; set; }
        public delegate void NextNumberHandler(int number);
    }
}