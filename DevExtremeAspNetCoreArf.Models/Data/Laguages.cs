using DevExtremeAspNetCoreArf.Models;

namespace DevExtremeAspNetCoreArf.Models.Data
{
    public partial class DataSource
    {
        //private static readonly string iconPath = "~/lib/icon/languages/";
        private static readonly string iconDirPath = "../../lib/icon/languages/";
        public static readonly List<Language> Languages = new()
        {
            new Language {Id = 0, Name = "English" , ShortName = "En", ImageSrc = iconDirPath + "English32.ico", IconSrc = iconDirPath + "English16.ico"},
            new Language {Id = 1, Name = "Deutsch" , ShortName = "De", ImageSrc = iconDirPath + "Germany32.ico", IconSrc =  iconDirPath + "Germany16.ico"},
            new Language {Id = 2, Name = "Русский" , ShortName = "Ру", ImageSrc = iconDirPath + "Russia32.ico", IconSrc = iconDirPath + "Russia16.ico"},
            new Language {Id = 3, Name = "中国人" , ShortName = "Ch", ImageSrc = iconDirPath + "China32.ico", IconSrc = iconDirPath + "China16.ico"},
            new Language {Id = 4, Name = "Italiano" , ShortName = "It", ImageSrc = iconDirPath + "Italy32.ico", IconSrc = iconDirPath + "Italy16.ico"},
            new Language {Id = 5, Name = "日本語" , ShortName = "Ja", ImageSrc = iconDirPath + "Japan32.ico", IconSrc = iconDirPath + "Japan16.ico"}
        };
    }
}