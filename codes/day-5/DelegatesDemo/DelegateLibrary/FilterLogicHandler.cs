namespace DelegateLibrary
{
    //public delegate bool FilterLogicHandler(int num);
    public delegate bool FilterLogicHandler<in T>(T data);
}
