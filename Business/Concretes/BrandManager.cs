using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class BrandManager : IBrandService
{
    private readonly IBrandDal _brandDal;

    public BrandManager(IBrandDal brandDal)
    {
        _brandDal = brandDal;
    }

    public CreatedBrandResponse Add(CreateBrandRequest createBrandRequest)
    {
        //business rules

        //mapping -->automapper
        Brand brand = new();
        brand.Name = createBrandRequest.Name;
        brand.CreatedTime = DateTime.Now;
        _brandDal.Add(brand);

        //mapping
        CreatedBrandResponse createBrandResponse = new CreatedBrandResponse();
        createBrandResponse.Id = 4;
        createBrandResponse.Name = brand.Name;
        createBrandResponse.CreatedDate = brand.CreatedTime;

        return createBrandResponse;

    }

    public List<GetAllBrandResponse> GetAll()
    {
        List<Brand> brands = _brandDal.GetAll();

        List<GetAllBrandResponse> getAllBrandResponses = new List<GetAllBrandResponse>();

        foreach(var brand in brands)
        {
            GetAllBrandResponse getAllBrandResponse = new GetAllBrandResponse();
            getAllBrandResponse.Name = brand.Name;
            getAllBrandResponse.Id= brand.Id;
            getAllBrandResponse.CreatedDate = brand.CreatedTime;

            getAllBrandResponses.Add(getAllBrandResponse);
        }

        return getAllBrandResponses;
    }
}
