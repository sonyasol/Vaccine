using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine.Core.InputModel
{
    public class VaccineInputModel
    {
        [Required(ErrorMessage = "Название обязательно")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Минимум 3 символа")]
        public string Title { get; set; }

        public VaccineType VaccineType { get; set; }
    }
}
