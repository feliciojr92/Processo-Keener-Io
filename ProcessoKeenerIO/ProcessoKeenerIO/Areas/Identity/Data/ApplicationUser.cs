﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Castle.MicroKernel.SubSystems.Conversion;
using Microsoft.AspNetCore.Identity;

namespace ProcessoKeenerIO.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Nome { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Sobrenome { get; set; }
    }
}
