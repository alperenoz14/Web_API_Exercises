using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class Player
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required,MaxLength(50)]
        public string Name { get; set; }
        [Required,MaxLength(50)]
        public string LastName { get; set; }
        [Required,MaxLength(50)]
        public string Position { get; set; }
    }
}
