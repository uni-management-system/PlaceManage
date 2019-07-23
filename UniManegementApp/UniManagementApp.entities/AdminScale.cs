namespace UniManagementApp.entities
{
    public class AdminScale
    {
        public int Id { get; set; }
        public int Scale { get; set; }
        public string ScaleName { get; set; }
        public ApplyFor ApplyFor { get; set; }
        public int AppluForId { get; set; }
    }
}
