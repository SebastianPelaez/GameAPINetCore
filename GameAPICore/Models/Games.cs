using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameAPICore.Models
{
    public class Games
    {
        [Key]
        public int Id { get; set; }

        public int Round { get; set; }

        [StringLength(50)]
        public string PlayerOneName  { get; set; }

        public int PlayerOneOption { get; set; }

        [StringLength(50)]
        public string PlayerTwoName { get; set; }

        public int PlayerTwoOption { get; set; }

        [StringLength(50)]
        public string Winner { get; set; }

    }
}
