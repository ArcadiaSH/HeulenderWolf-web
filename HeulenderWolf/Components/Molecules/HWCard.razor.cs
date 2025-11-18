using HeulenderWolf.Models;
using Microsoft.AspNetCore.Components;

namespace HeulenderWolf.Components.Molecules
{
    public partial class HWCard : ComponentBase
    {
        #region PARAMETRO
        [Parameter] public CardModel CardConfig { get; set; }
        #endregion

    }
}
