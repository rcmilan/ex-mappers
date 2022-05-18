using Mapster;

namespace ex_mapster
{
    public class GenericAdapter<TSource, TDestination>
    {
        public TDestination Map(TSource source)
        {
            return source!.Adapt<TDestination>();
        }
    }
}