using BethanysPieShop.HRM.Contracts.Services;
using BethanysPieShop.HRM.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace BethanysPieShop.HRM.Components.Pages
{
	public partial class EmployeeEdit
	{
		[Inject]
		public required IEmployeeDataService employeeDataService { get; set; }
		[Inject]
		public required ICountryDataService countryDataService { get; set; }
		[Inject]
		public required IJobCategoryDataService jobCategoryDataService { get; set; }
		[Inject]
		public required NavigationManager NavigationManager { get; set; }

		[Parameter]
		public int EmployeeId { get; set; }

		[SupplyParameterFromForm]
		public Employee Employee { get; set; } = new();


		protected string Message { get; set; } = string.Empty;
		protected string StatusClass { get; set; } = string.Empty;
		protected bool Saved { get; set; } = false;

		public List<Country> Countries { get; set; } = [];
		public List<JobCategory> JobCategories { get; set; } = [];


		protected override async void OnInitialized()
		{
			Saved = false;
			Employee = await employeeDataService.GetEmployeeDetails(EmployeeId);
			Countries = (await countryDataService.GetAllCountries()).ToList();
			JobCategories = (await jobCategoryDataService.GetAllJobCategories()).ToList();
		}

		protected async Task OnValidSubmit()
		{
			if (selectedFile != null)
			{
				var file = selectedFile;
				Stream stream = file.OpenReadStream();
				MemoryStream ms = new();
				await stream.CopyToAsync(ms);
				stream.Close();

				Employee.ImageName = file.Name;
				Employee.ImageContent = ms.ToArray();
			}

			await employeeDataService.UpdateEmployee(Employee);
			Message = $"{Employee.FirstName} {Employee.LastName} has been saved to the HRM";
			StatusClass = "alert-success";
			Saved = true;
		}

		protected void OnInvalidSubmit()
		{
			StatusClass = "alert-danger";
			Message = $"There are some validation errors";
		}		

		protected async Task DeleteEmployee()
		{
			await employeeDataService.DeleteEmployee(EmployeeId);
			Message = $"{Employee.FirstName} {Employee.LastName} has been deleted from the HRM";
			StatusClass = "alert-danger";
			Saved = true;
		}

		protected void NavigateToOverview()
		{
			NavigationManager.NavigateTo("/employeeoverview");
		}

		private IBrowserFile selectedFile;
		protected void OnInputFileChane(InputFileChangeEventArgs e)
		{
			selectedFile = e.File;
			StateHasChanged();
		}
	}
}
