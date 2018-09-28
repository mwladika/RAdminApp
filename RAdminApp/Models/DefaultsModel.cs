using System;
using System.ComponentModel.DataAnnotations;

namespace RAdminApp.Models
{
    public class DefaultsModel
    {
        public int Id { get; }
        public string Value { get; }
        public bool Inactive { get; }
        public string FieldName { get; }
        public string ParentTable { get; }
    }
}