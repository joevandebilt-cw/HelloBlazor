using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BethanysPieShop.HRM.Shared.Domain
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Your First Name is too long")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(50, ErrorMessage = "Your Last Name is too long")]
        public string LastName { get; set; } = string.Empty;

        public DateTime? BirthDate { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public string? Street { get; set; }

        public string? Zip { get; set; }

        public string? City { get; set; }

        public int? CountryId { get; set; }

        public Country? Country { get; set; }

        public string? PhoneNumber { get; set; }

        public bool Smoker { get; set; } = false;

        public MaritalStatus? MaritalStatus { get; set; }

        public Gender? Gender { get; set; }

        public bool IsOnHoliday { get; set; } = false;

        [StringLength(1000, ErrorMessage = "Comment length can't exceed 1000 characters")]
        public string Comment { get; set; } = string.Empty;

        public DateTime? JoinedDate { get; set; }

        public DateTime? ExitDate { get; set; }

        public int? JobCategoryId { get; set; }

        public JobCategory? JobCategory { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

        public List<TimeRegistration> TimeRegistrations { get; set; }

        public byte[]? ImageContent { get; set; }
        public string? ImageName { get; set; }

        [NotMapped]
		public string ImageSrc
		{
			get
			{
                if (this?.ImageContent == null) return $"https://gillcleerenpluralsight.blob.core.windows.net/person/{this.EmployeeId}.jpg";
                return $"data:image/{Path.GetExtension(this.ImageName)!.Replace(".", "")};base64,{Convert.ToBase64String(this.ImageContent)}";
			}
		}

        [NotMapped]
        public string ImageAlt
        {
            get
            {
                return this.ImageName ?? $"A picture of {this.FirstName}";
            }
        }
    }
}
