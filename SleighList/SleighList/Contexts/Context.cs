using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SleighList.Models;

namespace SleighList.Contexts
{
    public class Context: DbContext
    {
           public Context(){
        }

        public Context(DbContextOptions<Context> options) : base(options){
        }
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
                // colocar as informacoes do banco
                // As configuracoes existem?
                if(!optionsBuilder.IsConfigured){
                  
                optionsBuilder.UseSqlServer("Data Source=NOTE45-S28\\SQLEXPRESS2; Initial Catalog = Sleighlist; User Id=sa; Password=123; TrustServerCertificate = true");

                }
        }
    
        // As referencias das nossas tabelas no banco de dados:
        public DbSet<Item> Item {get; set;}


        public DbSet<Usuario> Usuario {get; set;}
    }
}