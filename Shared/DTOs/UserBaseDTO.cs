namespace Shared.DTOs
{
    public class UserBaseDTO
    {
        public required string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Photo { get; set; }

        public int Age
        {
            get
            {
                var today = DateTime.Today;
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
