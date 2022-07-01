using System.Collections.Generic;
using System.Linq;
using DesafioMVC.Data;
using DesafioMVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DesafioMVC.Controllers
{
    public class IngredientesController : Controller
    {
        private readonly ApplicationDbContext database;

        public IngredientesController(ApplicationDbContext database){
            this.database = database;
        }

        public IActionResult Listar(){
	        List<Ingrediente> listaIngredientes = database.Ingredientes.Where(x => x.Status ==true).ToList();
	        return View (listaIngredientes);
        }

        [Authorize(Policy = "SomenteAdmin")]
        public IActionResult Adicionar(){
            return View();
        }

        [Authorize(Policy = "SomenteAdmin")]
        public IActionResult Salvar(Ingrediente ingrediente){
            if(ModelState.IsValid){
                ingrediente.Status = true;
                database.Ingredientes.Add(ingrediente);
                database.SaveChanges();
                return RedirectToAction("Listar","Ingredientes");
            } else {
                return View("../Ingredientes/Adicionar");
            }
        }    

        [Authorize(Policy = "SomenteAdmin")]
        public IActionResult Editar(int id){
            Ingrediente ingrediente = database.Ingredientes.First(x => x.Id == id);
            return View(ingrediente);
        }

        [Authorize(Policy = "SomenteAdmin")]
        public IActionResult Atualizar(Ingrediente ingrediente){
            if(ModelState.IsValid){
                ingrediente.Status = true;
                database.Ingredientes.Update(ingrediente);
                database.SaveChanges();
                return RedirectToAction("Listar","Ingredientes");
            } else {
                return View("../Ingredientes/Editar");
            }
        }

        [Authorize(Policy = "SomenteAdmin")]
        public IActionResult Deletar(int id){
            if (id > 0){
                Ingrediente ingrediente = database.Ingredientes.First(x => x.Id == id);
                ingrediente.Status = false;
                database.SaveChanges();
                return RedirectToAction("Listar", "Ingredientes");
            } else {
                return View("../Ingredientes/Listar");
            }
        }
    }
}