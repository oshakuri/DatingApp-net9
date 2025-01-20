using System;

namespace API.Extentions;

public static class DateTimeExtentions
{
    public static int CalucluateAge(this DateOnly dob)
    {
        var today = DateOnly.FromDateTime(DateTime.Now);
        var age = today.Year - dob.Year;
        if(dob > today.AddYears(-age)) age--;
        return age;
    }
}
