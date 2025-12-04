using HeulenderWolf.Models;
using HeulenderWolf.Models.Sections;
using Microsoft.AspNetCore.Components;

namespace HeulenderWolf.Components.Organisms.Sections
{
    public partial class Sobre : ComponentBase
    {
        #region PARAMETRO
        [CascadingParameter]
        public ConfiguracaoGeralModel ConfiguracaoGeral { get; set; }
        #endregion
        #region PROPRIEDADES
        public SobreModel Model { get; set; } = new();
        #endregion
        public HWButtonModel ButtonModel { get; set; } = new();
        public HWFormModal<SobreModel> FormModal { get; set; } = new();
        #region METODOS
        protected override void OnInitialized()
        {
            Model = ConfiguracaoGeral.SobreNos;
        }
        public async Task ShowModal()
        {
            FormModal.Show(Model);
        }
        #endregion 
       

    }
}
