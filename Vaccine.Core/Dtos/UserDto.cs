using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine.Core.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }

        public UserRole Role { get; set; }

        public string Login { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public SertificateDto Sertificate { get; set; }   // почему в sertificateDto не получилось написать public UserDto Unhandled exception. System.InvalidOperationException: The dependent side could not be determined for the one-to-one relationship between 'SertificateDto.User' and 'UserDto.Sertificate'. To identify the dependent side of the relationship, configure the foreign key property. If these navigations should not be part of the same relationship, configure them independently via separate method chains in 'OnModelCreating'. See https://go.microsoft.com/fwlink/?LinkId=724062 for more details.
    }
}
