using System;

namespace NTier.Core.Entities
{
    public class CoreEntity : ICoreEntity
    {
        public Guid Id { get; set; } 




        public DateTime CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIP { get; set; }
        public Guid CreatedBy { get; set; } 
        public string CreatedADUsername { get; set; }

        public DateTime? ModifiedDate { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIP { get; set; }
        public Guid? ModifiedBy { get; set; }
        public string ModifiedADUsername { get; set; }

    }
}
