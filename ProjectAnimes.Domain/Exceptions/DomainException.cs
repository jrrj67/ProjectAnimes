namespace ProjectAnimes.Domain.Exceptions
{
    internal class DomainException : Exception
    {
        public IReadOnlyCollection<string> Errors { get; } = default!;

        public DomainException()
        {
        }
        
        public DomainException(string message) : base(message)
        {
        }
        
        public DomainException(string message, List<string> errors) : base(message)
        {
            Errors = errors;
        }
        
        public DomainException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
