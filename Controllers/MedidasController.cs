using System.Collections.Generic;
using System.Linq;
using DesafioMVC.Data;
using DesafioMVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DesafioMVC.Controllers
{
    public class MedidasController : Controller
    {
        private readonly ApplicationDbContext database;

        public MedidasController(ApplicationDbContext database){
            this.database = database;
        }

        public IActionResult Listar(){
	        List<Medida> listaMedidas = database.Medidas.Where(x => x.Status == true).ToList();
	        return View (listaMedidas);
        }

        [Authorize(Policy = "SomenteAdmin")]
        public IActionResult Adicionar(){
            return View();
        }

        [Authorize(Policy = "SomenteAdmin")]
        public IActionResult Salvar(Medida medida){
            if(ModelState.IsValid){
                medida.Status = true;
                database.Medidas.Add(medida);
                database.SaveChanges();
                return RedirectToAction("Listar","Medidas");
            } else {
                return View("../Medidas/Adicionar");
            }
        }    

        [Authorize(Policy = "SomenteAdmin")]
        public IActionResult Editar(int id){
            Medida medida = database.Medidas.First(x => x.Id == id);
            return View(medida);
        }

        [Authorize(Policy = "SomenteAdmin")]
        public IActionResult Atualizar(Medida medida){
            if(ModelState.IsValid){
                medida.Status = true;
                database.Medidas.Update(medida);
                database.SaveChanges();
                return RedirectToAction("Listar","Medidas");
            } else {
                return View("../Medidas/Editar");
            }
        }

        [Authorize(Policy = "SomenteAdmin")]
        public IActionResult Deletar(int id){
            if (id > 0){
                Medida medida = database.Medidas.First(x => x.Id == id);
                medida.Status = false;
                database.SaveChanges();
                return RedirectToAction("Listar", "Medidas");
            } else {
                return View("../Medidas/Listar");
            }
        }
    }
}
