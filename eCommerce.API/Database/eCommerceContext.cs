﻿using Microsoft.EntityFrameworkCore;

namespace eCommerce.API.Database;

public class eCommerceContext : DbContext
{
    public eCommerceContext(DbContextOptions<eCommerceContext> options) : base(options) 
    {

    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Contato> Contatos { get; set; }
    public DbSet<EnderecoEntrega> EnderecosEntrega { get; set; }
    public DbSet<Departamento> Departamentos { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseSqlServer("Server=DESKTOP-36FIOJP\\SQLEXPRESS; Database=eCommerce;user id=sa; password=123456;MultipleActiveResultSets=true");
    //}
}
