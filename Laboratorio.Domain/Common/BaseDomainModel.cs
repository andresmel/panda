﻿namespace Laboratorio.Domain.Common
{
    public abstract class BaseDomainModel
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
