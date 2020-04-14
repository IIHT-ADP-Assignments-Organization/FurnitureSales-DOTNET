using Furniture_Sales.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Furniture_Sales.BusinessLayer.Interfaces
{
    public interface IAdminServices
    {
        Admin Register(Admin admin);
        bool Login(string UserName, string Password);
        int AddCompany(Company company);
        Company UpdateCompany(Company company);
        Company GetCompany(int CompanyId);
        bool DeleteCompany(int CompanyId);

    }
}
