using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebBolaMagica.Models
{
    public class Message
    {
        [Key]
        [Required]
        public int MessageId { get; set; }
        [Required]
        public string BallMessage { get; set; }
    }
}