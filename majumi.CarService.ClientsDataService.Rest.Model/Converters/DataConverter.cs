﻿using majumi.CarService.ClientsDataService.Model;
using majumi.CarService.ClientsDataService.Rest.Model.Model;

namespace majumi.CarService.ClientsDataService.Rest.Model.Converters;

public static class DataConverter
{
    public static MechanicData ConvertToMechanicData(this Mechanic mechanic)
    {
        return new MechanicData
        {
            MechanicID = mechanic.MechanicID,
            Name = mechanic.Name,
            Surname = mechanic.Surname,
            BirthDate = mechanic.BirthDate,
            HireDate = mechanic.HireDate,
            Specialty = mechanic.Specialty,
            VacationDays = mechanic.VacationDays,
            Address = mechanic.Address,
            Phone = mechanic.Phone,
            Email = mechanic.Email
        };
    }
}