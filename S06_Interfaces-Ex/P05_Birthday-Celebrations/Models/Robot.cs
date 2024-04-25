﻿using BorderControl.Interfaces;

namespace BirthdayCelebrations.Models
{
    public class Robot : Iidentifiable
    {
        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }

        public string Model { get; set; }
        public string Id { get; set; }
    }
}
