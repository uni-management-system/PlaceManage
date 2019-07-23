namespace UniManagementApp.entities
{
    public class FacultyScale
    {
        public int Id { get; set; }
        public Scale Scale { get; set; }
        public int ScaleId { get; set; }
        public string ScaleName { get; set; }
        public ApplyFor ApplyFor { get; set; }
        public int ApplyForId { get; set; }
    }
}
