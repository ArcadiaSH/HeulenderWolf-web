using HeulenderWolf.Models;
using Microsoft.AspNetCore.Components;

namespace HeulenderWolf.Components.Organisms.Sections
{
    public partial class Depoimentos : ComponentBase
    {
        public HWFormModal<HWButtonModel> FormModal { get; set; } = new();
        public HWButtonModel ButtonModel { get; set; } = new();
        public async Task ShowModal()
        {
            FormModal.Show(ButtonModel);
        }
        public void teste()
        {

        }
    }
}
