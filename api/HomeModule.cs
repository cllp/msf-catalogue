namespace MSF.Catalogue
{
    using Nancy;
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
                //var model = new Product() { Id = args.id, Name = args.name };

                //rep.Add(new Product() {Id = args.id, Name = args.name});
                
                rep.Add(model);
                //return model;//this.Response.AsRedirect("/"); //return model;
                return rep.FindAll();
            });


            /*Post["/add"] = x =>
            {
                rep.Add(new Product() {Id = args.id, Name = args.name});
                return args;
            };
            */
        }
    }
}
