using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AppProject.Models
{
    public class Trainee
    {
        public int ID { get; set; }
      //  [StringLength(3)]
        [Display(Name="Your Serial (as in DSHE training nomination)")]
        public int DsheSL { get; set;}

        [Display(Name="Trainee Category")]
       public TraineeType TraineeType { get; set;}
       


       
        //course info
        [Display(Name="Name of Training Course")]
        [EnumDataType(typeof(Course))]
        public Course Course_Name { get; set; }
        
        [Display(Name="Batch No." )]
        public int BatchNo { get; set; }

        [DisplayFormat(ApplyFormatInEditMode=true,DataFormatString="{0:yyy/MM/dd}")]
        [Display(Name="Course Duration")]
       // [DataType(DataType.Date)]
        public DateTime OpeningDate { get; set;}

        // [DataType(DataType.Date)]
        // [DisplayFormat(ApplyFormatInEditMode=true,DataFormatString="{0:dd/MM/yyyy}")]
         [DisplayFormat(ApplyFormatInEditMode=true,DataFormatString="{0:yyyy/MM/dd}")]
        
        public DateTime ClosingDate { get; set;}
        
        [Display(Name = "Last Training Course Attended at NAEM (if any)")]
       // [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode=true,DataFormatString="{0:yyyy/MM/dd}")]
        public string LastNaemCourseAttendeded { get; set;}
       
        //personal info

        [StringLength(100)]
        [Required]
       // [RegularExpression(@"^[ A-Za-z./()-]*$")]
        [Display(Name="Name (as per SSC/equivalent certificate) ")]
        public string Name { get; set;}

        [StringLength(100)]
      //  [RegularExpression(@"^[a-zA-Z ]+$")]
        [Display(Name="Father's Name")]
        public string FatherName { get; set;}

        [StringLength(100)]
        //[RegularExpression(@"^[a-zA-Z ]+$")]
        [Display(Name="Mother's Name ")]
        public string MotherName { get; set;}

        [Required]
        [EnumDataType(typeof(Sex))]
        public Sex Gender { get; set;}
	
 	      //[DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode=true,DataFormatString="{0:yyyy/MM/dd}")]
        [Display(Name="Date of Birth")]
        [Required]
        public DateTime DateOfBirth { get; set;}

        [Display(Name="Blood Group")]
        [Required]
        [EnumDataType(typeof(BloodGroup))]
        public BloodGroup BloodGroup { get; set;}


        [Display(Name="Marital Status")]
        [Required]
        [EnumDataType(typeof(MaritalStatus))]
        public MaritalStatus MaritalStatus { get; set;}
       
        [Required]
        [Display(Name="Age (on first day of training)")]
       
        public string Age { get; set;}
       
        [StringLength(11, ErrorMessage="Mobile number must have 11 digits")]
        [Required]
        [RegularExpression(@"^[0-9]{11}$",ErrorMessage="Plz, enter a 11 digit valid mobile number.")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name="Mobile No.")]
        public string CellNo { get; set;}

        [DataType(DataType.EmailAddress)]
        
        [Required]
        public string Email { get; set;}

        [RegularExpression(@"^[0-9]+$",ErrorMessage="Plz, enter  a digit only valid NID number.")]
        [Required]
        [Display(Name="National ID No.")]
        public string NID { get; set;}
        
        [Display(Name="Permanent Address")]
        [Required]
        [DataType(DataType.MultilineText)]
        public string PermanentAddress { get; set;}


        //Job & Educationsl info

        [StringLength(100)]
        //[RegularExpression(@"^[a-zA-Z ]+$",ErrorMessage="Plz, enter a valid designation with letters.")]
        [Required]
        public string Designation { get; set;}

        [Display(Name="Index/ID No.")]
        [RegularExpression(@"^[0-9]+$",ErrorMessage="Plz, enter a digit only valid number.")]
        [StringLength(20)]
        [Required]
        public string IndexNo { get; set;}
        
        [Display(Name="Name of Cadre (if applicable)")]
        [EnumDataType(typeof(Cadre))]
        
        public Cadre? NameOfCadre { get; set;}

        [Display(Name="BCS Batch No. (if applicable)")]
      //  [RegularExpression(@"^[0-9]{2}$", ErrorMessage="Plz, enter a valid No. with digits.")]
        public int? BCSBatchNo  { get; set;}

        [Display(Name="Present Workplace (with address)")]
        [Required]
        [DataType(DataType.MultilineText)]
        public string WorkplaceAddress { get; set;}

        [RegularExpression(@"^[0-9]+$",ErrorMessage="Plz, enter a valid No. with digits.")]
        [Display(Name="EIIN No. (if applicable)")]
        public int? EiinNo { get; set;}


        [Display(Name="Academic Qualification")]
        [Required]
        [DataType(DataType.MultilineText)]
        public string AcademicQualification { get; set; }
       
        [Required]
        //[RegularExpression(@"^[a-zA-Z ]+$",ErrorMessage="Plz, enter a valid subject name with letters.")]
        [StringLength(100)]
        public string Subject { get; set;}


        //Emmergency Contact Info
        
        [Required]
       // [RegularExpression(@"^[a-zA-Z ]+$",ErrorMessage="Plz, enter a name with letters.")]
        [Display(Name="Person to be Contacted in Emmergency(spouse/family member)")]
        public string EmmergencyContactName { get; set;}


        
       /*  [StringLength(11, ErrorMessage="Mobile number must have 11 digits")]
        [Required]
        [RegularExpression(@"^[0-9]{11}$")]
  
        [DataType(DataType.PhoneNumber)]
        [Display(Name="Emmergency Contact (Mobile No.)")]
        
        public string EmmergencyContactCellNo { get; set;} */

        [StringLength(11, ErrorMessage="Mobile number must have 11 digits")]
        [Required]
        [RegularExpression(@"^[0-9]{11}$",ErrorMessage="Plz, enter a 11 digit valid mobile number.")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name="Emmergency Contact (Mobile No.)")]
        public string EmmergencyContactCellNo { get; set;}
        
       //Image to Upload
        [Display(Name="Profile Photo")]
        public string ProfileImagePath { get; set;}

        [Display(Name="Signature")]      
        public string SignatureImgPath { get; set;}
       
       //Registration Date & Time

        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode=true,DataFormatString="{0:yyyy/MM/dd hh:mm:ss tt}")]
        [Display(Name="Date and Time of Registration")]
        public DateTime RegDate { get; set;}
        [Display(Name="UID")]
        public string Guid {get; set;}
        [Display(Name="Add ID")]
        public int? TraineeSerial { get; set;}
        [Display(Name="Home District")]
        
        [Required]
        [StringLength(100)]
        public string HomeDistrict { get; set;}

        

    }


    public enum BloodGroup
    {
       [Display(Name="A+")]
       APositive,
       [Display(Name="A-")]
       ANegative,
       [Display(Name="B+")]
       BPositive,
       [Display(Name="B-")]
       BNegative,
       [Display(Name="AB+")]
       ABPositive,
       [Display(Name="AB-")]
       ABNegative,
       [Display(Name="O+")]
       OPositive,
       [Display(Name="O-")]
       ONegative
    }

    public enum  Course
    {
       [Display(Name="Advanced Course on Education and Management(ACEM)")]
       ACEM,
       [Display(Name="Foundation Training Course for BCS (General Education)")]
       FTC,
       [Display(Name="Educational Administration and Management Training Course (EAM-P)")]
       EAMP,
       [Display(Name="Educational Administration and Management Training Course (EAM-H)")]
       EAMH,
       [Display(Name="English Language Teaching Training Course(ELT)")]
       ELT,
       [Display(Name="Satellite Training Course on Teachers' Professional Development (STC)")]
       STC
    }
    public enum Cadre
    {
        //BcSGEdu,BcsEdu,BcsAdm
        [Display(Name="BCS (General Education)")]
        BCSGenEdu,
        [Display(Name="Not Applicable")]
        NotApplicable
    }
    public enum MaritalStatus
    {
        Married,Unmarried,Other
    }
    public enum Sex
    {
        Male,Female,Other
    }
    public enum TraineeType
    {
        Male,
        Female,
        [Display(Name="Female with a child")]
        FemaleWithChild,
        [Display(Name="Male (waiting)")]
        MaleWaiting,
        [Display(Name="Female (waiting)")]
        FemaleWaiting,
       
        [Display(Name="Female with a child (waiting)")]
        FemaleWithChildWaiting
    }
  
}
