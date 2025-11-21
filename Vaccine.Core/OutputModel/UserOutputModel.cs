using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vaccine.Core.Dtos;

namespace Vaccine.Core.OutputModel
{
    public class UserOutputModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public SertificateDto Sertificate { get; set; }

        public UserRole Role { get; set; }
    }
}
