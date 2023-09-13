using DesignPatterns.BuilderPattern.Method1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern.Method2
{
    public interface IEmployeeBuilderM2
    {
        EmployeeM2 BuildEmployee();
        void SetEmailAddress(string emailAddress);
        void SetFullName(string fullName);
        void SetUserName(string userName);
    }

    public abstract class EmployeeBuilderM2 : IEmployeeBuilderM2
    {
        protected EmployeeM2 Employee { get; set; }


        public EmployeeBuilderM2()
        {
            Employee = new EmployeeM2();
        }

        public abstract void SetFullName(string fullName);
        public abstract void SetEmailAddress(string emailAddress);
        public abstract void SetUserName(string userName);
        public EmployeeM2 BuildEmployee() => Employee;
    }
}
