using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CinemaTest.Models
{
    public class Show
    {
        [Key, Required, DataMember]
        public Guid Id { get; set; }

        [Required, DataMember]
        public Guid MovieId { get; set; }

        [Required, DataMember]
        public Guid ScreenId { get; set; }

        [Required, DataMember]
        public DateTime DateTime { get; set; }

        [DataMember]
        public Screen Screen { get; set; }

        [DataMember]
        public Movie Movie { get; set; }
    }
}