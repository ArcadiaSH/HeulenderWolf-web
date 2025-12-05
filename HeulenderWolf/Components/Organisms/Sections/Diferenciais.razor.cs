using HeulenderWolf.Models;
using Microsoft.AspNetCore.Components;

namespace HeulenderWolf.Components.Organisms.Sections
{
    public partial class Diferenciais : ComponentBase
    {
        #region PARAMETROS
        [Parameter]
        public EventCallback OnClickEvent { get; set; }
        #endregion
        public List<CardModel> CardList { get; set; } = [];
        public CardModel CardModel { get; set; } = new();

        
       
    }
}
