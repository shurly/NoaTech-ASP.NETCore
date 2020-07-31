using Noahtech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoahTech.Models
{
    public class InicializaBD
    {
        public static void Initialize(Context context)
        {
            context.Database.EnsureCreated();


           


        }
    }
}
