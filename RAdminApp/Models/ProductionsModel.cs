using System;
using System.ComponentModel.DataAnnotations;

namespace RAdminApp.Models
{
    public class ProductionsModel
    {
        public int Id { get; }
        public string Description { get; }
        public string ShortName { get; }
        public string Text1 { get; }
        public string Text2 { get; }
    }
}