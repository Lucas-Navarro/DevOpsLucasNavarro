﻿namespace DevOpsLucasNavarro.Models
{
    public class Aluno
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Professor { get; set; }
        public DateTime? Idade { get; set; }
    }
}
