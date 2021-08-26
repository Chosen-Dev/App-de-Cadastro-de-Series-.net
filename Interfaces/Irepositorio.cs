using System.Collections.Generic;

namespace Dio.Series
{
    public class Irepositorio<T>
    {
    }
}

namespace Dio.Series.Interfaces
{
    public interface Irepositorio
    {
         List<T> Lista();

         T RetornaPortId (int id);

         void Insere(T entidade);

         void Exclui(int id);

         void Atualiza(int id, T entidade);

         int Proximoid(); 

    }
}