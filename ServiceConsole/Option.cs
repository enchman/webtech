using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceConsole
{
    interface IOption
    {
        string Key { get; set; }
        object Value { get; set; }
        T GetValue<T>();
    }

    class Option: IOption
    {
        public string Key { get; set; }
        public object Value { get; set; }

        public T GetValue<T>()
        {
            try
            {
                return (T)Value;
            }
            catch (Exception)
            {

                return default(T);
            }
        }
    }
}
