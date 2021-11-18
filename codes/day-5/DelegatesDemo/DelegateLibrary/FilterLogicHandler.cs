namespace DelegateLibrary
{
    //public delegate bool FilterLogicHandler(int num);
    public delegate bool FilterLogicHandler<in T>(T data);
    // delegate bool Predicate<in T>(T obj);
    //delegate TResult Func<in T, out TResult>(T arg);
}
