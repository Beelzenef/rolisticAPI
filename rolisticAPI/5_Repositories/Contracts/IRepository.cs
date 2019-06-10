using System.Collections.Generic;

namespace RolisticAPI._Repositories.Contracts
{
    public interface IRepository<T>
    {
        List<T> GetAll();

        T Find(int id);
    }
}
