//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Karamolegkos_PrivateSchool
{
    using System;
    using System.Collections.Generic;
    
    public partial class CourseAssignment
    {
        public int CourseId { get; set; }
        public int AssignmentId { get; set; }
        public System.DateTime SubmissionDate { get; set; }
    
        public virtual Assignment Assignment { get; set; }
        public virtual Cours Cours { get; set; }
    }
}