namespace MSF.Catalogue
{
    using Nancy;
    using System;
    using Nancy.ModelBinding;
    using MSF.Catalogue.Repository;
    using MSF.Catalogue.Models;
    

    public class HomeModule : NancyModule
    {
        private readonly ProductRepository rep;
        public HomeModule()
        {
            rep = new ProductRepository();

            Get("/", _ => "Hello aaaa");
            Get("/test/{name}", args => new Product() { Id = 123, Name = args.name });

            Get("/list/", _ => rep.FindAll());

            Post("/add", args =>
            {
                var model = this.Bind<Product>();                
                model.Created = DateTime.Now;                                
                int id = rep.Add(model);
                return rep.FindByID(id);
            });
        }
    }
}
