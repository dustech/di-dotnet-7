


using ECommerce.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace ECommerce.Mvc;

public class ECommerceControllerActivator : IControllerActivator
{
  public object Create(ControllerContext context) =>
          this.Create(context.ActionDescriptor.ControllerTypeInfo.AsType());

  public void Release(ControllerContext context, object controller) =>
      (controller as IDisposable)?.Dispose();
  public Controller Create(Type type)
  {
    switch (type.Name)
    {
      case nameof(HomeController):
        return new HomeController();
        default: throw new InvalidOperationException($"Unknown controller {type}.");
    }
  }
}