using CustomBlazorDemoApp.Shared;
using Microsoft.AspNetCore.Components.Forms;

namespace CustomBlazorDemoApp.Client.Components;

    public partial class ProductCssClassProvider
    {
    private EditContext _editContext;
    private Product _product = new Product();
        public void Submit() =>
            Console.WriteLine($"{_product.Name}, {_product.Supplier}");

    protected override void OnInitialized()
    {
        _editContext = new EditContext(_product);
        _editContext.SetFieldCssClassProvider(new ValidationFieldClassProvider("validField", "invalidField"));
        _editContext.OnFieldChanged += HandleFieldChanged;
    }
    private void HandleFieldChanged(object sender, FieldChangedEventArgs e)
    {
        _editContext.Validate();
        StateHasChanged();
    }
}

