using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLibrary
{
    public interface IRequest
    {
        IModel<T> Get<T>(string url);
        List<IModel<T>> GetAll<T>(string url);
    }
}
