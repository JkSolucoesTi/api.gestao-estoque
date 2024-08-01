namespace Api.GestaoEstoque.Configuration
{
    public static class ConfigDataBase
    {
        public static string ConnectionString(IConfiguration configuration)
        {
            var param = configuration.GetConnectionString("DefaultConnection");
            if (param != null) return param;
            else return "";
        }
        
    }
}
