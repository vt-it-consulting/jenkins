using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.App.Components;

    public partial class QuickViewPopup
    { 

        private bool _IsOpened = false;

        [Parameter]
        public Employee? Employee { get; set; }

        protected override void OnParametersSet()
        { 
            _IsOpened = Employee is not null;
        }

        public void Close()
        { 
            _IsOpened =  false;
        }
    }
 