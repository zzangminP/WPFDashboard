using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPfDashboard.Interfaces
{
    public interface IDatabase<T>
    {
        List<T> Get();

        T? GetDetail(int? id);

        void Create(T entity);

        void Delete(T entity);

        void Update(T entity);

    }
}
