namespace Models.Entity
{
    public class PropertyProductInfo
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int FeatureProductId { get; set; }
        public int FeatureValueId { get; set; }

        public string FeatureName { get; set; }
        public string FeatureValue { get; set; }
    }
}
