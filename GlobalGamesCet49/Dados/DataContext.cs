﻿using GlobalGamesCet49.Dados.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalGamesCet49.Dados
{
    

    public class DataContext : DbContext
    { 
        
        
        public DbSet<Inscricoes> Inscricoes { get; set; }


        public DbSet<Contacto> Contactos { get; set; }


         public DataContext(DbContextOptions<DataContext>options) : base(options)
        {

        }




       
    }
}
