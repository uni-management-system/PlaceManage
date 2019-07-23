using System.Collections.Generic;

namespace UniManagementApp.entities.ViewModels
{
    public class PlaceViewModel
    {
        public Place Places { get; set; }
        public List<ApplyFor> ApplyFors { get; set; }
        public List<Scale> Scales { get; set; }
        public List<ScaleNo> ScaleNos { get; set; }
        public List<Designation> Designations { get; set; }
        public List<Department> Departments { get; set; }
        public List<Domicile> Domiciles { get; set; }
        public List<Status> Statuses { get; set; }

       
    }
}
