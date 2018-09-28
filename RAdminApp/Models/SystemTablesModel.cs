using System;
using System.ComponentModel.DataAnnotations;

namespace RAdminApp.Models
{
    public class SystemTablesModel
    {
        public int Id { get; }
        public string Description { get; }
        public string HelpText { get; }
    }
}