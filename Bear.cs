namespace Animals
{ 
    public class Bear: Animal
    {
        private string Name { get; set; }
        public Bear(string name, int age) : base(age, TypeOfFood.Herb)
        {
            this.Name = name;
        }

        public override string About()
        {
            string comment;
            if (Age >= 13)
            {
            comment = "Умер :(";
            }
            else if (Age <= 10)
            {
                comment = "Приемлемо";
            }
            else
            {
                comment = "Средний возраст продолжительности жизни =/";
            }

            return $"Name: {Name} \n Age: {Age} {comment} \n Type: Травоядное";
        }

        public override void Eat()
        {
            Console.WriteLine("Люблю есть мёд");
        }

        public override void Move()
        {
            Console.WriteLine("Карабкаюсь");
        }
    }
}
