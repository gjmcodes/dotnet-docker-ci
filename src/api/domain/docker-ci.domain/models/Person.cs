namespace docker_ci.domain.models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public bool IsOfAge => Age >= 18;
    }
}