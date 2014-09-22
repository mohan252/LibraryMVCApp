using System;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using Library.Business;
using Library.Data.Models;
using Microsoft.Practices.Unity;
using Unity.Mvc4;

namespace LibraryAppEmpty
{
  public static class Bootstrapper
  {
    public static IUnityContainer Initialise()
    {
      var container = BuildUnityContainer();

      DependencyResolver.SetResolver(new UnityDependencyResolver(container));

      return container;
    }

    private static IUnityContainer BuildUnityContainer()
    {
      var container = new UnityContainer();
      RegisterControllers(container);
      RegisterTypes(container);

      return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
        container.RegisterType<ILibraryService, LibraryService>();
        container.RegisterType<ILibraryDbContext, LibraryDbContext>();
    }

    private static void RegisterControllers(IUnityContainer container)
    {
        // Also register all the controller types as transient
        Type[] types = Assembly.GetExecutingAssembly().GetTypes();

        var controllerTypes = types.Where(t => typeof(IController).IsAssignableFrom(t));

        foreach (var t in controllerTypes)
        {
            if (!container.IsRegistered(t))
            {
                container.RegisterType(t);
            }
        }
    }
  }
}