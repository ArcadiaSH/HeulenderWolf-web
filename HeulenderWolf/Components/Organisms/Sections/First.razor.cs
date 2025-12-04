using HeulenderWolf.Models;
using HeulenderWolf.Models.Sections;
using Microsoft.AspNetCore.Components;
using System.Reflection;

namespace HeulenderWolf.Components.Organisms.Sections
{
    public partial class First : ComponentBase
    {
        #region PARAMETROS
        [CascadingParameter]
        public ConfiguracaoGeralModel ConfiguracaoGeralModel { get; set; }
        #endregion
        #region PROPRIEDADES
        public HWButtonModel ButtonModel { get; set; } = new();
        public FirstModel Model { get; set; } = new();
        public HWFormModal<FirstModel> FormModal { get; set; } = new();
        #endregion
        #region METODOS
        public async Task ShowModal()
        {
            FormModal.Show(Model);
        }
        #endregion


    }
}
