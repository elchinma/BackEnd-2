using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.ViewsModels;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public List<Menu> Menu;
        public List<Category> Categories;
        public HomeController()
        {
            Menu = new List<Menu>()
            {
                new Menu()
                {
                    Id = 1,
                    Name = "",
                    Photo = "",
                    Desc = ""
                },
                 new Menu()
                {
                    Id = 2,
                    Name = "",
                    Photo = "",
                    Desc = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
                  new Menu()
                {
                    Id = 3,
                    Name = "",
                    Photo = "",
                    Desc = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
                   new Menu()
                {
                    Id = 4,
                    Name = "",
                    Photo = "",
                    Desc = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
                    new Menu()
                {
                    Id = 5,
                    Name = "",
                    Photo = "",
                    Desc = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
                     new Menu()
                {
                    Id = 6,
                    Name = "",
                    Photo = "",
                    Desc = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
            };
            Category cat1 = new Category()
            {
                Id = 1,
                Name = "Menu"
            };

            Categories = new List<Category>()
            {
                cat1,

            };
        }
        public IActionResult Index()
        {

            HomeVM model = new HomeVM
            {
                Categories = Categories,
                Menu = Menu,
            };
            return View(model);
        }
    }
};

  
               
