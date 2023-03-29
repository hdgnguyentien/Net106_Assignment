using _2.Data.ModelsClass;
using _3.Admin.IServices;
using Microsoft.AspNetCore.Components;

namespace _3.Admin.Pages
{
    public partial class Index
    {
        [Inject] private IAllServices allServices { get; set; }
        private List<SanPham> sanPhams;
        protected override async Task OnInitializedAsync()
        {
           sanPhams =  await allServices.GetAll<SanPham>("https://localhost:7095/api/SanPhams/Get-All");
        }
    }
}
