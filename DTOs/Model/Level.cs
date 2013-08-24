namespace DTOs.Model
{
    public class Level:EntityBase
    {
        public int Value { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string LvlGroup { get; set; }
    }
}