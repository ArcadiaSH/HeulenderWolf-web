using HeulenderWolf.Models;
using Microsoft.AspNetCore.Components;

namespace HeulenderWolf.Components.Molecules
{
    public partial class HWAccordionItem : ComponentBase
    {
        #region PARAMETROS

        [Parameter]
        public FAQItem Item { get; set; } = new();

        [Parameter]
        public string AccordionId { get; set; } = "faqAccordion";

        [Parameter]
        public string CorFundo { get; set; } = "#8ce1c9";

        [Parameter]
        public string CorTexto { get; set; } = "#fbbf24";

        [Parameter]
        public EventCallback<FAQItem> OnToggle { get; set; }

        #endregion

        #region PROPRIEDADES

        protected string HeaderId => $"faq{Item.Id}";
        protected string CollapseId => $"collapse{Item.Id}";
        protected string CollapseClass => Item.IsExpanded ? "" : "collapsed";
        protected string ShowClass => Item.IsExpanded ? "show" : "";
        
        // Adiciona transparência de 34% (57 em hexadecimal) diretamente na cor
        protected string CorFundoComTransparencia => $"{CorFundo}57";

        #endregion

        #region METODOS

        protected async Task ToggleAccordion()
        {
            Item.IsExpanded = !Item.IsExpanded;
            await OnToggle.InvokeAsync(Item);
        }

        #endregion
    }
}
