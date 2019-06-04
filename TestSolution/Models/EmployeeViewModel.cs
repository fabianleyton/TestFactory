using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestSolution.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContractTypeName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public decimal HourlySalary { get; set; }
        public decimal MonthlySalary { get; set; }
        public decimal AnualSalary { get; set; }

        //public void GetEmployeeViewModelFromModel(Model.Interfase.IEmployee item)
        //{
        //    if (item != null)
        //    {

        //        Id = item.Id;
        //        Name = item.Name;
        //        ContractTypeName = item.ContractTypeName;
        //        HourlySalary = item.HourlySalary;
        //        MonthlySalary = item.MonthlySalary;
        //        RoleDescription = item.RoleDescription;
        //        RoleId = item.RoleId;
        //        RoleName = item.RoleName;
        //        AnualSalary = item.AnualSalary;
        //    }
        //}
        
    }
}