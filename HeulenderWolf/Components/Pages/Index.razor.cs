using HeulenderWolf.Components.Organisms;
using HeulenderWolf.Models;
using System.Reflection;

namespace HeulenderWolf.Components.Pages
{
    public partial class Index
    {
        public ConfiguracaoGeralModel ConfiguracaoGeral { get; set; } = new();
        public VisitanteModel Visitante { get; set; } = new();
        public HWFormModal<VisitanteModel> FormModal = new();
        public async Task ShowModal()
        {
            FormModal.Show(Visitante);
        }
    }
}
