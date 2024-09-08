using Exo.WebApi.Models;
//using Microsoft.Build.Execution;
using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.FrameworkCore;
//using Microsoft.Extensions.Options;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;


namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
    {
        public ExoContext()
        {

        }
        public ExoContext(DbContextOptions<ExoContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;" + "Database=ExoApi;Trusted_Connection=True;");
            }
        }
        public DbSet<Projeto> Projetos { get; set; }
    }
}



/*
namespace Exo.Webapi.Contexts
{
    public ExoApiContext()
        {
        }
        public ExoApiContext(DbContextOptions<ExoApiContext> options) : base(options)
        {
        }
        // vamos utilizar esse método para configurar o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // cada provedor tem sua sintaxe para especificação
                optionsBuilder.UseSqlServer("Data Source = .\\SQLEXPRESS; initial catalog = ExoApi; Integrated Security = True; TrustServerCertificate=True");
            }
        }
        // dbset representa as entidades que serão utilizadas nas operações de leitura, criação, atualização e deleção
        public DbSet<Projeto> Projetos { get; set; }
*/