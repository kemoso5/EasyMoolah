namespace EasyMoolah.Model
{
    public class ApplicationSettings
    {
        public string LocalProccessLocation { get; set; }
        public string Timezone { get; set; }
        public string ProductManagerApiUrl { get; set; }
        public string ClientManagerApiUrl { get; set; }
        public string PolicyManagerApiUrl { get; set; }
        public string SecurityApiUrl { get; set; }
        public string MasterDataApiUrl { get; set; }
        public string RuleEngineApiUrl { get; set; }
        public string ConnectionString { get; set; }
    }
}