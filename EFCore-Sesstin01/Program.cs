using EFCore_Sesstin01.Contexts;

namespace EFCore_Sesstin01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                context.Database.EnsureCreated();
            }
        }
    }
}
