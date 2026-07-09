namespace Shared.DTOs
{
    public class PersonBaseDTO
    {
        public required string Name { get; set; }
        public DateOnly BirthDate { get; set; }
        public string? Photo { get; set; }

        public int Age
        {
            get
            {
                var today = DateOnly.FromDateTime(DateTime.Today);
                var age = today.Year - BirthDate.Year;

                if (BirthDate > today.AddYears(-age))
                {
                    age--;
                }

                return age;
            }
        }
    }
}
