using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern.Method2
{
    public class InternalEmployeeBuilder : EmployeeBuilderM2
    {
        public override void SetEmailAddress(string emailAddress)
        {
            // berkayzaim@mail.com
            var arr = emailAddress.Split('@');
            // endswith @test.com.tr

            Employee.EmailAddress = arr[0] + "@test.com.tr";
        }

        public override void SetFullName(string fullName)
        {
            var arr = fullName.Split(new[] { ' ', '_', '.' });

            Employee.FirstName = arr[0];
            Employee.LastName = arr[1];
        }

        public override void SetUserName(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
