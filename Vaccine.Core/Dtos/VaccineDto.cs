using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine.Core.Dtos
{
    public class VaccineDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public VaccineType VaccineType { get; set; }

        public List<VaccineSertificate> Sertificates { get; set; }

    }
}
