using System;
using System.ComponentModel.DataAnnotations;

namespace RAdminApp.Models
{
    public class PriceTypesModel
    {
        public int Id { get; }
        public string Description { get; }
        public string ShortDescription { get; }
        public bool Inactive { get; }
    }
}