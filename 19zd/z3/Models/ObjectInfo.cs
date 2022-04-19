namespace z3
{
    internal partial class Program
    {
        class ObjectInfo
        {
            public static void Info<type>(type obj) where type : Game
            {
                obj.GetInfo();
            }
        }
    }
}
