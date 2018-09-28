using System;
using System.ComponentModel.DataAnnotations;

namespace RAdminApp.Models
{
    public class KeywordsModel
    {
        public int Id { get; }
        public string Description { get; }
        public string EditMask { get; }
        public string DetailTable { get; }
        public bool MultipleValue { get; }
        public string HelpText { get; }
    }
}