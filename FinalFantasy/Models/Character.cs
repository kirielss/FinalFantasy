﻿namespace FinalFantasy.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GameId { get; set; }
        public virtual Game Game { get; set; }
        public string? Description { get; set; }
    }
}
