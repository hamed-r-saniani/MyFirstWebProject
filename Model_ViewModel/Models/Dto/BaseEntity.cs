using System;

namespace Model_ViewModel.Models.Dto
{
    public abstract class BaseEntity<TKey>
    {
        public TKey Id { get; set; }
        public DateTime InsertTime { get; set; } = DateTime.Now;
        public DateTime? UpdateTime { get; set; }
        public bool Deleted { get; set; } = false;
        public DateTime? DeletedTime { get; set; }
    }
    public abstract class BaseEntity : BaseEntity<long>
    {
    }
}
