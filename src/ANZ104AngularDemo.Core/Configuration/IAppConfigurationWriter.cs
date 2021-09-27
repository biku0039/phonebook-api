namespace ANZ104AngularDemo.Configuration
{
    public interface IAppConfigurationWriter
    {
        void Write(string key, string value);
    }
}
