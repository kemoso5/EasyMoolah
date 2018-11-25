﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyMoolah.Model
{
    public class BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

        [Required]
        public DateTime ChangeDate { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
