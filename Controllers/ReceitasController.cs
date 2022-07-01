using System.Collections.Generic;
using System.Linq;
using DesafioMVC.Data;
using DesafioMVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DesafioMVC.Controllers
{
    public class ReceitasController : Controller
    {
        private readonly ApplicationDbContext database;

        public ReceitasController(ApplicationDbContext database){
            this.database = database;
        }

        public IActionResult Listar(){
	        List<Receita> listaReceitas = database.Receitas.Where(x => x.Status == true).ToList();
	        return View (listaReceitas);
        }

        public IActionResult Visualizar(){
            return View();
        }

        [Authorize(Policy = "SomenteAdmin")]
        public IActionResult Adicionar(){
            return View();
        }

        [Authorize(Policy = "SomenteAdmin")]
        public IActionResult Salvar(Receita receita){
            if(ModelState.IsValid){
                receita.Status = true;
                database.Receitas.Add(receita);
                database.SaveChanges();
                return RedirectToAction("Listar","Receitas");
            } else {
                return View("../Receitas/Adicionar");
            }
        }    

        [Authorize(Policy = "SomenteAdmin")]
        public IActionResult Editar(int id){
            Receita receita = database.Receitas.First(x => x.Id == id);
            return View(receita);
        }

        [Authorize(Policy = "SomenteAdmin")]
        public IActionResult Atualizar(Receita receita){
            if(ModelState.IsValid){
                receita.Status = true;
                database.Receitas.Update(receita);
                database.SaveChanges();
                return RedirectToAction("Listar","Receitas");
            } else {
                return View("../Receitas/Editar");
            }
        }

        [Authorize(Policy = "SomenteAdmin")]
        public IActionResult Deletar(int id){
            if (id > 0){
                Receita receita = database.Receitas.First(x => x.Id == id);
                receita.Status = false;
                database.SaveChanges();
                return RedirectToAction("Listar","Receitas");
            } else {
                return View("../Receitas/Listar");
            }
        }
    }
}