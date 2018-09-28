using System;
using System.ComponentModel.DataAnnotations;

namespace RAdminApp.Models
{
    public class PackagesModel
    {
        public int Id { get; }
        public string Description { get; }
        public string Code { get; }
        public bool FixedSeatIndicator { get; }
        public bool FlexIndicator { get; }

    }
}