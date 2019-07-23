using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UniManagementApp.entities
{
    public class Place
    {
        public int Id { get; set; }

        public ApplyFor ApplyFor { get; set; }

        [Required]
        [DisplayName("Apply For")]
        public int ApplyForId { get; set; }

        public ScaleNo ScaleNo { get; set; }

        [Required]
        [DisplayName("Scale")]
        public int ScaleNoId { get; set; }


        public Designation Designation { get; set; }
        [Required]
        [DisplayName("Designation")]
        public string DesignationId { get; set; }

        [Required]
        public string Allotment { get; set; }

        [Required]
        public string Reason { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]  
        [MaxLength(13, ErrorMessage = "Invalide CNIC"),
         MinLength(13, ErrorMessage = "Invalide CNIC")]
        public string CNIC { get; set; }

        [Required]
        //A,B,C.....
        public string HouseCategory { get; set; }


        //[Required]
        //[DisplayName("Job Status")]
        //public int DesignationId { get; set; }

        public Department Department { get; set; }

        [Required]
        [DisplayName("Department")]
        public int DepartmentId { get; set; }

        [Required]
        [DisplayName("Marital Status")]
        public string MaritalStatus { get; set; }
        
        [DisplayName("No of Dependent")]
        public string NoOfDependent { get; set; }

        public Domicile Domicile { get; set; }

        [Required]
        [DisplayName("Domicile")]
        public int DomicileId { get; set; }

        [Required]
        public string Address { get; set; }
        
        [DisplayName("Phone No")]
        public string PhoneNo { get; set; }

        [Required]
        [DisplayName("Mobile No")]
        [MaxLength(11, ErrorMessage = "Invalide Mobile number"), 
         MinLength(11,ErrorMessage = "Invalide Mobile number")]
        public string MobileNo { get; set; }

        [Required]
        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Required]
        public string Age { get; set; }

        public Status Status { get; set; }

        [Required]
        [DisplayName("Job Status")]
        public int StatusId { get; set; }        
        
        [DisplayName("Do you or your spouse have any house within Bahawalpur City")]
        public string HaveHome { get; set; }
        
        [DisplayName("Do you or your spouse have availed house purchase/repair loan from IUB or any other Institute.")]
        public string Loan { get; set; }

        [Required]
        [DisplayName("Appointment Date")]
        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; }

        [Required]
        [DisplayName("Current Scale Appointment Date")]
        [DataType(DataType.Date)]
        public DateTime CurrentScaleAppointmentDate { get; set; }

        [Required]
        [DisplayName("Current Scale Length")]
        public string CurrentScaleLength { get; set; }
        
        [DisplayName("Immediate Lower Scale Appointment Date")]
        [DataType(DataType.Date)]
        public DateTime ImmediateLowerScaleAppointmentDate { get; set; }
        
        [DisplayName("Immediate Lower Scale Length")]
        public string ImmediateLowerScaleLength { get; set; }
        
        [DisplayName("Next Lower Scale Appointment Date")]
        [DataType(DataType.Date)]
        public DateTime NextLowerScaleAppointmentDate { get; set; }
        
        [DisplayName("Next Lower Scale Length")]
        public string NextLowerScaleLength { get; set; }
        
        [DisplayName("Next Lower Scale Appointment Date")]
        [DataType(DataType.Date)]
        public DateTime NextLowerScaleAppointmentDate1 { get; set; }
        
        [DisplayName("Next Lower Scale Length")]
        public string NextLowerScaleLength1 { get; set; }
        
        [DisplayName("Next Lower Scale Appointment Date")]
        [DataType(DataType.Date)]
        public DateTime NextLowerScaleAppointmentDate2 { get; set; }
        
        [DisplayName("Next Lower Scale Length")]
        public string NextLowerScaleLength2 { get; set; }
        
        [DisplayName("Next Lower Scale Appointment Date")]
        [DataType(DataType.Date)]
        public DateTime NextLowerScaleAppointmentDate3 { get; set; }
        
        [DisplayName("Next Lower Scale Length")]
        public string NextLowerScaleLength3 { get; set; }


        [DataType(DataType.Date)]
        public DateTime ApplyDate { get; set; }
    }
}
