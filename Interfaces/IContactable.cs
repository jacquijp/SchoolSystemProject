using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystemProject.Interfaces
{
    internal interface IContactable
    {
        string Phone { get; set; }
        string Email { get; set; }

        void ShowContactInfo();
    }
}
