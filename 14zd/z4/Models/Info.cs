namespace z4
{
    internal partial class Program
    {
        class Info
        {
            public string model = "S63";

            public delegate void Response(string model);
            public event Response Resp;

            public void OnResp(string a)
            {
                if (model != a)
                {
                    Resp(a);
                    model = a;
                }
            }
        }
    }
}
