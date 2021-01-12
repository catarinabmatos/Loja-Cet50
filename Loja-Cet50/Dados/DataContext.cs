using Loja_Cet50.Dados.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loja_Cet50.Dados
{
    public class DataContext : DbContext
    {

        public DbSet<Produto> Produtos { get; set; }


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
