﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Graduation_Project.Models
{
    public enum VisitRequestStatus
    {
        Pending,    
        Approved,   
        Rejected    
    }
    public class RequestVisit
    {
        public int Id { get; set; } 

        public DateTime RequestedDate { get; set; }  
        public DateTime? PreferredTime { get; set; }
        public VisitRequestStatus Status { get; set; }  

        [ForeignKey("Property")]
        public int PropertyId { get; set; }
        public Property? Property { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }  
        public User? User { get; set; }  
    }
}

