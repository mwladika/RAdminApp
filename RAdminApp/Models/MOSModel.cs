using System;
using System.ComponentModel.DataAnnotations;

namespace RAdminApp.Models
{
    public class MOSModel
    {
        public int Id { get; }
        public string Description { get; }
        public bool Inactive { get; }
        public int HoldUntilDays { get; }
        public int HaboDays { get; }
        public bool HaboForeign { get; }
        public int PricingRuleSetId { get; }
    }
}