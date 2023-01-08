using System.ComponentModel.DataAnnotations;

namespace Domain
{
    [System.ComponentModel.DataAnnotations.Schema.Table("PeopleActivity")]
    public class PeopleActivity
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime ActivityDate { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string City { get; set; }  
        public string Venue { get; set; }      
    }
}