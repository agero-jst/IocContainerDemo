using System;
using System.Collections.Generic;

namespace IocContainer
{
    public class TrivialContainer
    {
        public delegate object Creator(TrivialContainer container);

        private readonly Dictionary<Type, Creator> typeToCreator;

        public TrivialContainer()
        {
            typeToCreator = new Dictionary<Type, Creator>();
        }
        public void Register<T>(Creator creator)
        {
            typeToCreator.Add(typeof(T), creator);
        }
        public T Resolve<T>()
        {
            return (T)typeToCreator[typeof(T)](this);
        }
    }
}
