namespace Homework_Task1
{
    class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        public Car(string model, Driver driver, int speed)
        {
            Model = model;
            Speed = speed;
            this.Driver = driver;
        }
        public Car() { }

        public void AssignDriver(Driver driver)
        {
            Driver = driver;
        }
        public int CalculateSpeed()
        {
            int result = Driver.Skill * Speed;
            return result;
        }
    }
}
