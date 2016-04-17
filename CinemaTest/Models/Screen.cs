using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CinemaTest.Models
{
    public class Screen
    {
        [Key, Required, DataMember]
        public Guid Id { get; set; }

        [Required, DataMember]
        public string Name { get; set; }

        [Required, DataMember]
        public string Description { get; set; }

        //0 til mange shows
        [DataMember]
        public ICollection<Show> Shows { get; set; }
    }
}