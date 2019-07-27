using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubcribedToNewsletter { get; set; }
        // make association with a MenbershipType class
        // a navaigation property - navigate from one type to another e.g. Customer type to Membership type
        public MembershipType MembershipType { get; set; }
        // foreign key - EF will recognize this convention automatically 
        public byte MembershipTypeId { get; set; }
    }
}
