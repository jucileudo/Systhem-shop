using DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Systhem.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {

    }
}
