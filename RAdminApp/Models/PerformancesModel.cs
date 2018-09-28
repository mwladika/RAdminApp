using System;
using System.ComponentModel.DataAnnotations;

namespace RAdminApp.Models
{
    public class PerformancesModel
    {
        public int Id { get; }
        public int FacilityId { get; }
        public string Description { get; }
        public DateTime PerformanceDateTime { get; }
    }
}