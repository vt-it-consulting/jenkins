using BethanysPieShopHRM.App.Components.Widgets;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace BethanysPieShopHRM.App.Pages
{
    public partial class Index
    {
        public List<Type> Widgets { get; set; } = new List<Type>() { typeof(EmployeeCountWidget), typeof(InboxWidget) };

        private Type? type;
        private string? message;


        protected override void OnInitialized()
        {
            base.OnInitialized();

          

        }
        private void dropdownChange(ChangeEventArgs e)
        {
            type = e.Value?.ToString()?.Length > 0 ? Type.GetType($"BethanysPieShopHRM.App.Components.Widgets.{e.Value}") : null;
        }

        private void ShowDTMessage(MouseEventArgs e) =>message = $"The current DT is: {DateTime.Now}.";



        private Dictionary<string, ComponentMetadata> components =
            new()   
            {
            {
                "Counter",
                new ComponentMetadata
                {
                    Parameters = new Dictionary<string, object>(){{"Title", "Counter Demo"}   }
                }
            } ,


      }; 
    }
}