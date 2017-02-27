namespace car
{
    public class Car
    {
        // Default constructor
        public Car ()
        {
            Brand = "Ford";
            Speed = 80.0f;
        }
        // Constructor with parameters
        public Car(string brand)
        {
            Brand = brand;
            Speed = 0;
        }

        // Properties
        public string Brand { get; } // autoproperty (palauttaa brand-arvon sellaisenaan)
        public float Speed { get; private set; }

        // Methods
        public override string ToString()
        {
            return Print();
        }
        public void Accelerate(float speedGain)
        {
            Speed += speedGain;
        }
        public void Brake()
        {
            Speed *= 0.9f;
        }

        private string Print()
        {
            return string.Format("Merkki: {0}\nNopeus: {1} km/h", Brand, Speed);
        }
    }
}
