using Furniture_Sales.BusinessLayer.Interfaces;
using Furniture_Sales.DataLayer.NHibernateConfiguration;
using Furniture_Sales.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Furniture_Sales.BusinessLayer.Services
{
    public class AdminServices : IAdminServices
    {
        private readonly IMapperSession _session;

        public AdminServices(IMapperSession session)
        {
            _session = session;
        }
        public int AddCompany(Company company)
        {
            Company ObjCompany = new Company();
            return ObjCompany.CompanyId;
        }

        public bool DeleteCompany(int CompanyId)
        {
            return true;
        }

        public Company GetCompany(int CompanyId)
        {
            Company ObjCompany = new Company();
            return ObjCompany;
        }

        public bool Login(string UserName, string Password)
        {
            return true;
        }

        public Admin Register(Admin admin)
        {
            Admin ObjAdmin = new Admin();
            return ObjAdmin;
        }

        public Company UpdateCompany(Company company)
        {
            Company ObjCompany = new Company();
            return ObjCompany;
        }
    }
}
