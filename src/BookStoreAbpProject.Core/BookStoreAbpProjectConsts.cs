using BookStoreAbpProject.Debugging;

namespace BookStoreAbpProject
{
    public class BookStoreAbpProjectConsts
    {
        public const string LocalizationSourceName = "BookStoreAbpProject";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "2139b74a98c146c29d41dc052f5b90a1";
    }
}
