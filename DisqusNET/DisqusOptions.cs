namespace DisqusNET
{
    public class DisqusOptions
    {
        private static DisqusOptions _instance;

        private DisqusOptions() {}

        public static DisqusOptions GetInstance()
        {
            return _instance ?? (_instance = new DisqusOptions());
        }

        public string AccessToken { get; set; }
        public string ApiKey { get; set; }
    }
}