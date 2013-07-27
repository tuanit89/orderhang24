namespace Models.StringHelper
{
    public class MetaHelper
    {
        public static string MetaRender(string desc, string meta)
        {
            return string.Format("<meta name=\"description\" content=\"{0}\" />" +
                                 "<meta name=\"keywords\" content=\"{1}\" />",desc,meta);
        }
    }
}
