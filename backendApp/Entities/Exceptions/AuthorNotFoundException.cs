namespace Entities.Exceptions
{
    public partial class NotFoundException
    {
        public class AuthorNotFoundException : NotFoundException
        {
            public AuthorNotFoundException(int id) : base($"Category with {id} id could not found.")
            {
            }
        }
    }
}
