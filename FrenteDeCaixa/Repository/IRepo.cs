using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa.Repository
{
    internal interface IRepo<T>
    {
        int Insert(T value);
        int Update(T value);
        int Delete(int id);
        List<T> GetAll();
        T GetValue(int id);
        int GetUltCod();
    }
}
