using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolution.Model.Models
{
    public abstract class EmployeeDTO : Interfase.IEmployee
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

        public EmployeeDTO(EmployeeApiModel item)
        {
            GetEmployeeApiToModel(item);
        }

        public virtual decimal GetAnualSalary()
        {
            return AnualSalary;
        }


        protected void GetEmployeeApiToModel(EmployeeApiModel item)
        {
            if (item != null)
            {

                Id = item.id;
                Name = item.name;
                ContractTypeName = item.contractTypeName;
                HourlySalary = item.hourlySalary;
                MonthlySalary = item.monthlySalary;
                RoleDescription = item.roleDescription;
                RoleId = item.roleId;
                RoleName = item.roleName;
            }
        }
    }

}
