﻿using Dota.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dota.Data.Services
{
    public interface IHeroRepository
    {
        public Task<DotaHero[]> GetDotaHeroesAsync();
    }
}
