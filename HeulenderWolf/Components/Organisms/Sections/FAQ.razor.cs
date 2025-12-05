using HeulenderWolf.Models;
using Microsoft.AspNetCore.Components;

namespace HeulenderWolf.Components.Organisms.Sections
{
    public partial class FAQ : ComponentBase
    {
        #region PARAMETROS

        [Parameter]
        public EventCallback OnClickEvent { get; set; }

        #endregion

        #region PROPRIEDADES

        protected List<FAQItem> FAQItems { get; set; } = new();

        protected FAQConfiguracao Configuracao { get; set; } = new();

        protected HWFormModal<FAQItem> FormModalItem { get; set; } = new();

        protected HWFormModal<FAQConfiguracao> FormModalConfig { get; set; } = new();

        protected FAQItem CurrentFAQItem { get; set; } = new();

        protected bool IsEditMode { get; set; } = false;

        #endregion

        #region METODOS

        protected override void OnInitialized()
        {
            InitializeDefaultFAQs();
            base.OnInitialized();
        }

        private void InitializeDefaultFAQs()
        {
            FAQItems = new List<FAQItem>
            {
                new FAQItem
                {
                    Pergunta = "Vocês oferecem garantia de saúde para os Shih-Tzus vendidos?",
                    Resposta = "Sim, oferecemos uma garantia de saúde abrangente para nossos Shih-Tzus. Além de suporte veterinário em nossa clínica própria.",
                    Ordem = 1
                },
                new FAQItem
                {
                    Pergunta = "Os Shih-Tzus são fáceis de treinar?",
                    Resposta = "Os Shih-Tzus são inteligentes e geralmente respondem bem ao treinamento positivo e consistente. Além disso, nossos filhotes já são treinados para fazer as necessidades no tapete higiênico ou jornal.",
                    Ordem = 2
                },
                new FAQItem
                {
                    Pergunta = "Os Shih-Tzus são bons para famílias com crianças?",
                    Resposta = "Sim, os Shih-Tzus são conhecidos por serem amigáveis, amorosos e se darem bem com crianças e outros animais de estimação.",
                    Ordem = 3
                },
                new FAQItem
                {
                    Pergunta = "Os filhotes são vacinados e vermifugados?",
                    Resposta = "Sim, todos os nossos filhotes são vacinados e vermifugados antes da entrega, além de nossa garantia e suporte veterinário.",
                    Ordem = 4
                },
                new FAQItem
                {
                    Pergunta = "Como posso realizar a compra de um filhote?",
                    Resposta = "Você pode clicar em \"Comprar Agora\" para ser direcionado ao nosso contato no WhatsApp, onde poderá obter mais informações e realizar sua compra.",
                    Ordem = 5
                },
                new FAQItem
                {
                    Pergunta = "Como adquirir microchip e pedigree?",
                    Resposta = "Microchip e pedigree estão disponíveis mediante consulta de condição. Entre em contato para mais informações.",
                    Ordem = 6
                }
            };
        }

        protected void ShowModal()
        {
            FormModalConfig.Show(Configuracao);
        }

        protected void AdicionarNovo()
        {
            IsEditMode = false;
            CurrentFAQItem = new FAQItem
            {
                Ordem = FAQItems.Count + 1
            };
            FormModalItem.Show(CurrentFAQItem);
        }

        protected void EditarFAQ(FAQItem item)
        {
            IsEditMode = true;
            CurrentFAQItem = item;
            FormModalItem.Show(CurrentFAQItem);
        }

        protected void OnSalvarConfiguracao()
        {
            FormModalConfig.Close();
            StateHasChanged();
        }

        protected void OnSalvarFAQ()
        {
            if (FormModalItem.EditContext.Validate())
            {
                if (!IsEditMode)
                {
                    FAQItems.Add(CurrentFAQItem);
                }

                FAQItems = FAQItems.OrderBy(f => f.Ordem).ToList();
                FormModalItem.Close();
                StateHasChanged();
            }
        }

        protected void ExcluirFAQ(FAQItem item)
        {
            FAQItems.Remove(item);
            ReordenarItens();
            StateHasChanged();
        }

        protected void MoverParaCima(FAQItem item)
        {
            var index = FAQItems.IndexOf(item);
            if (index > 0)
            {
                FAQItems[index] = FAQItems[index - 1];
                FAQItems[index - 1] = item;
                ReordenarItens();
                StateHasChanged();
            }
        }

        protected void MoverParaBaixo(FAQItem item)
        {
            var index = FAQItems.IndexOf(item);
            if (index < FAQItems.Count - 1)
            {
                FAQItems[index] = FAQItems[index + 1];
                FAQItems[index + 1] = item;
                ReordenarItens();
                StateHasChanged();
            }
        }

        private void ReordenarItens()
        {
            for (int i = 0; i < FAQItems.Count; i++)
            {
                FAQItems[i].Ordem = i + 1;
            }
        }

        protected void OnToggleItem(FAQItem item)
        {
            foreach (var faqItem in FAQItems.Where(f => f.Id != item.Id))
            {
                faqItem.IsExpanded = false;
            }

            StateHasChanged();
        }

        #endregion
    }
}
