using System;

namespace Domain.Model
{
    public abstract class ModelBase
    {
        public Guid Id { get; set; }
        public DateTime DateAdd { get; set; }
        public bool Ative { get; set; }
        
    }
}