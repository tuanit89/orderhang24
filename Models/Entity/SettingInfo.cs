namespace Models.Entity
{
    public class SettingInfo
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public SettingInfo()
        {
            Key = Value = Description = string.Empty;
        }
    }
}
