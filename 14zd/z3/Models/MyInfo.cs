namespace z3
{
    internal partial class Program
    {
        public class MyInfo
        {
            public string name = "Никита";

            public delegate void Response(string name);
            public event Response Resp;

            public void OnResp(string a)
            {
                if (name != a)
                {
                    Resp(a);
                    name = a;
                }
            }
        }
    }
}
