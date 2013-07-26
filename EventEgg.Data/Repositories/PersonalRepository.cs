using EventEgg.Data.Interfaces;
using EventEgg.Domain;
using EventEgg.Domain.Personal;

namespace EventEgg.Data.Repositories
{
    public class PersonalRepository : RepositoryBase<PersonalDetail>, IPersonalRepository
    {
    }
}
