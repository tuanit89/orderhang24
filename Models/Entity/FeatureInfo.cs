namespace Models.Entity
{
    public class FeatureInfo
    {
        public int Id { get; set; }
        public string FeatureName { get; set; }
        public int CateProductId { get; set; }
        public bool IsShare { get; set;}

        public string CateProductName { get; set; }
    }
}
