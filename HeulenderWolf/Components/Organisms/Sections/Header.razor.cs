using HeulenderWolf.Models;
using Microsoft.AspNetCore.Components;
using System.Reflection;

namespace HeulenderWolf.Components.Organisms.Sections
{
    public partial class Header : ComponentBase
    {
        private bool isMenuOpen = false;
        public ConfiguracaoGeralModel ConfiguracaoGeral { get; set; } = new();
        public HWFormModal<ConfiguracaoGeralModel> FormModal { get; set; } = new();

        private void ToggleMenu() => isMenuOpen = !isMenuOpen;

        private void CloseMenu() => isMenuOpen = false;

        public async Task ShowModal()
        {
            FormModal.Show(ConfiguracaoGeral);
        }
    }
}