using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLibrary
{
    public interface IModel
    {}

    public interface IModel<T>
    {
        void ToData(T item);
        T ToModel();
    }
}
