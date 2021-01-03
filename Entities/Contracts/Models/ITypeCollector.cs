using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Entities.Contracts.Models
{
    public interface ITypeCollector
    {
        Type[] GetAllInheritingTypes<T>()
            where T : class;
    }
}
