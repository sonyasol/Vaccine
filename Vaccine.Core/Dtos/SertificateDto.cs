using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine.Core.Dtos
{
    public class SertificateDto
    {
        public int Id { get; set; }

        public DateOnly Date {  get; set; }

        public DoseNumber Dose { get; set; }

        public UserDto User { get; set; }

        public int UserId { get; set; }

        public List<VaccineSertificate> userSertificates { get; set; }

    }
}
