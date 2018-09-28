using System;
using System.ComponentModel.DataAnnotations;

namespace RAdminApp.Models
{
    public class ZonesModel
    {
        public int Id { get; }
        public string Description { get; }
        public string ShortDescription { get; }
        public int Rank { get; }
        public int ZoneMapId { get; }
        public string Abbreviation { get; }
        public int ZoneLegend { get; }
    }
}