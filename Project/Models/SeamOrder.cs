﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class SeamOrder
    {
        public int Id { get; set; }
        public int SeamstressId { get; set; }
        public int ClothId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Secondname { get; set; }
        public string Email { get; set; }
        public DateTime MeetAt { get; set; }
        public DateTime OrderedAt { get; set; }
        public DateTime? CompleteAt { get; set; }

        public string Status { get; set; } = "Waiting...";

        public string ClothName { get; set; }
        public string Image { get; set; }
    }
}