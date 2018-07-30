using Metro.Logging.File.UI;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class AddLoggingFileUIExtensions
    {
        public static void AddLoggingFileUI(this IServiceCollection services)
        {
            services.ConfigureOptions(typeof(LoggingFileUIConfigureOptions));
        }
    }
}