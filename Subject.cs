namespace OOPExample2
{
    enum Level { Beginner, Rutineret, Avanceret, Expert};
    internal class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Level Niveau { get; set; }
    }
}
