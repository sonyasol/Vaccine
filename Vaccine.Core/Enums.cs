using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine.Core
{
    public enum VaccineType
    {
        Грипп = 0,
        Гепатит_В = 1,
        Дифтерия = 2,
        Столбняк = 3,
        ВПЧ = 4
    }

    public enum UserRole
    {
        Doctor = 0,
        Patient = 1
    }

    public enum DoseNumber
    {
        V1 = 0,
        V2 = 1,
        V3 = 2,
        RV = 3
    }
}
