using System.Collections.Generic;

namespace UniManagementApp.entities.ViewModels
{
    class AdminScaleViewModel
    {
        public List<ApplyFor> ApplyFors { get; set; }
        public AdminScale AdminScales { get; set; }
    }

    class FacutlyScaleViewModel
    {
        public List<ApplyFor> ApplyFors { get; set; }
        public FacultyScale FacultyScales { get; set; }
    }
}
