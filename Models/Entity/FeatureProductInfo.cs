namespace Models.Entity
{
    public class FeatureProductInfo
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int FeatureId { get; set; }

        public int ProductCateId { get; set; }
    }
}
