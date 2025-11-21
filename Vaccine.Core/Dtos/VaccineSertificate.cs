using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine.Core.Dtos
{
    public class VaccineSertificate
    {
        public int Id { get; set; }

        public SertificateDto Sertificate { get; set; }

        public VaccineDto Vaccine { get; set; }
    }
}
