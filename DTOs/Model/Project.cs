namespace DTOs.Model
{
    using System.Collections.Generic;

    public class Project:EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Task> Tasks { get; set; }
        public Level Level { get; set; }
    }
}