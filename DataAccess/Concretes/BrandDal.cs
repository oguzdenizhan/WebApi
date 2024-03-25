﻿using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class BrandDal : IBrandDal
    {
        List<Brand> _brands;

        public BrandDal()
        {
            _brands = new List<Brand>();
            _brands.Add(new Brand { Id = 1, Name = "BMW", CreatedTime = DateTime.Now });
            _brands.Add(new Brand { Id = 2, Name = "Mercedes", CreatedTime = DateTime.Now });
            _brands.Add(new Brand { Id = 3, Name = "Alfa Romeo", CreatedTime = DateTime.Now });

        }
        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }

        public List<Brand> GetAll()
        {
            return _brands;
        }
    }
}
