using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vaccine.Core.Dtos;

namespace Vaccine.Core.OutputModel
{
    public class VaccineOutputModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public VaccineType VaccineType { get; set; }

    }
}
