using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace purchase_list_csharp.Mappers
{

    public abstract class AbstractMapper<A, B>
    {

        public abstract B FromAToB(A obj);
        public abstract A FromBToA(B obj);

        public List<B> FromAToB(List<A> list)
        {
            return list.Select(a => this.FromAToB(a)).ToList();
        }
        public List<A> FromBToA(List<B> list)
        {
            return list.Select(b => this.FromBToA(b)).ToList();
        }

    }
}
