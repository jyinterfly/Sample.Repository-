namespace Sample.Repositories
{
    public interface IDatabaseConfig
    {
        string ConnectionString { get; }
    }

    public class DatabaseConfig : IDatabaseConfig
    {
        public string ConnectionString
        {
        
            get { return "Data Source=xxxxx;Initial Catalog=xxxxxx;Persist Security Info=True;User ID=xxxxx;Password=xxxxxx"; }
        }
    }
}
