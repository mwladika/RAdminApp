using System;
using System.ComponentModel.DataAnnotations;

namespace RAdminApp.Models
{
    public class ConstituenciesModel
    {
        public int Id { get; }
        public string ShortDescription { get; }
        public string Description { get; }
        public int Rank { get; }
        public bool Inactive { get; }

    }
}