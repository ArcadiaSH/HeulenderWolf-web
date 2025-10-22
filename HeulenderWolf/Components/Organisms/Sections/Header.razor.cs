using Microsoft.AspNetCore.Components;

namespace HeulenderWolf.Components.Organisms.Sections
{
    public partial class Header : ComponentBase
    {
        private bool isMenuOpen = false;

        private void ToggleMenu() => isMenuOpen = !isMenuOpen;

        private void CloseMenu() => isMenuOpen = false;
    }
}