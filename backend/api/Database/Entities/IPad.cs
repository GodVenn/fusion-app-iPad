﻿using System.ComponentModel.DataAnnotations;
using Api.Database.Models;

namespace Api.Database.Entities
{
#nullable disable
    public class IPad
    {
        public int Id { get; set; }

        [MaxLength(128)]
        public string YellowTag { get; set; }

        [MaxLength(128)]
        public string LastKnownRITM { get; set; }

        [Required]
        [MaxLength(128)]
        public string Owner { get; set; }

        [MaxLength(128)]
        public string Assignee { get; set; }

        [MaxLength(128)]
        public string Project { get; set; }

        [MaxLength(128)]
        public string DeliveryAddress { get; set; }

        [Required]
        [MaxLength(64)]
        public ExClassEnum ExClass { get; set; }

        [Required]
        [MaxLength(64)]
        public UserTypeEnum UserType { get; set; }

        [MaxLength(64)]
        public SimTypeEnum SimType { get; set; }

        [Required]
        [MaxLength(64)]
        public StatusEnum Status { get; set; }
    }
}
