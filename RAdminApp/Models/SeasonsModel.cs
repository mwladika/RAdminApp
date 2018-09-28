using System;
using System.ComponentModel.DataAnnotations;

namespace RAdminApp.Models
{
    public class SeasonsModel
    {
        public int Id { get; }
        public string Description { get; }
        public bool Inactive { get; }
        public int FYear { get; }
    }
}