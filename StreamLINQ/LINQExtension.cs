using System;
using System.Linq;
using System.Collections.Generic;

namespace StreamLINQ
{
    public static class LINQExtension
    {
        public static IEnumerable<TResult> Dispatch<TSource, TResult>(IEnumerable<TSource> source, Dictionary<Type, Func<TSource, TResult>> dispatcher)
        {
            foreach (var element in source)
            {
                if (dispatcher.ContainsKey(element.GetType()))
                    yield return dispatcher[element.GetType()](element);
                else
                    // 원래 원소를 리턴한다거나 그런거는 따로 설정하는걸로
                    throw new KeyNotFoundException();
            }
        }
    }
}
