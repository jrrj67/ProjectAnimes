namespace ProjectAnimes.Domain.Entities
{
    public abstract class BaseEntity : IBaseEntity
    {
        public Guid Id { get; private set; }

        private DateTime _createdDate;

        private DateTime _updatedDate;

        public DateTime CreatedDate
        {
            get => _createdDate;
            set
            {
                if (value < DateTime.UtcNow)
                {
                    throw new ArgumentOutOfRangeException(nameof(CreatedDate));
                }

                _createdDate = value;
            }
        }

        public DateTime UpdatedDate
        {
            get => _updatedDate;
            set
            {
                if (value < DateTime.UtcNow)
                {
                    throw new ArgumentOutOfRangeException(nameof(UpdatedDate));
                }

                _updatedDate = value;
            }
        }

        internal List<string> _errors = new();

        public IReadOnlyCollection<string> Errors { get => _errors; }

        public abstract bool ValidateAllFields();

        public abstract bool ValidateSingleField(string name);
    }
}