using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLFun.Models
{
    public class EFRecipesRepository : IRecipesRepository
    {
        private RecipesDbContext context { get; set; }
        public EFRecipesRepository (RecipesDbContext temp)
        {
            context = temp;
        }

        public IQueryable<Recipe> Recipes => context.Recipes;
    }
}
