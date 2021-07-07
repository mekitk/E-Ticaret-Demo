using E_Ticaret.Interfaces;
using E_TicaretApi.Repositories;
using ETicaretDB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using X.PagedList;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;

namespace E_Ticaret.Controllers
{
    public class Urunfiltreleme   : Controller 
    {

        ISepetRepository _sepetrepository;
        //sa _sepetrepository;
        UrunRepository urunRepository;
        UrunOzellikRepository urunozellikrepository;
        ResimRepository resimrepository;
        ETicaretContext db = new ETicaretContext();
        public Urunfiltreleme(ISepetRepository sepetrepository)
        {
            _sepetrepository = sepetrepository;
           urunRepository = new UrunRepository();
           urunozellikrepository = new UrunOzellikRepository();
            resimrepository = new ResimRepository();
        }

        public async Task<IActionResult> Index(int page=1)
        
        {
            HttpContext.Session.SetString("cartt", "cart");

            var result = urunRepository.GetUrunList().ToPagedList(page,6);

            //List <Urun> urunler = new List<Urun>();
            //urunler = urunRepository.GetirHepsi();
            //await Task.Delay(10);

            return View(result);

        }
     
        public async Task<IActionResult> Bilgisayar(int page = 1)

        {
            var hepsi = urunRepository.GetUrunList();
            var result = urunRepository.GetByKateBil().ToPagedList(page, 6);

            //List <Urun> urunler = new List<Urun>();
            //urunler = urunRepository.GetirHepsi();
            //await Task.Delay(10);

            return View(result);

        }
        public async Task<IActionResult> Telefon(int page = 1)
        {

            var result = urunRepository.GetByKateTel().ToPagedList(page, 1);
            return View(result);

        }
        public async Task<IActionResult> Kamera(int page = 1)
         {

            var result = urunRepository.GetByKateKamera().ToPagedList(page, 6);
             return View(result);

        }
        public async Task<IActionResult> TV(int page = 1)
         {

            var result = urunRepository.GetByKateTV().ToPagedList(page, 1);
            return View(result);

        }
        public async Task<IActionResult> Pc(int page = 1)

        {

            var result = urunRepository.GetByKatePc().ToPagedList(page, 1);

            //List <Urun> urunler = new List<Urun>();
            //urunler = urunRepository.GetirHepsi();
            //await Task.Delay(10);

            return View(result);

        }

        public async Task<IActionResult> OfisKirtasiye(int page = 1)

        {

            var result = urunRepository.GetByKateOfisKırtasiye().ToPagedList(page, 1);

            //List <Urun> urunler = new List<Urun>();
            //urunler = urunRepository.GetirHepsi();
            //await Task.Delay(10);

            return View(result);

        }

         

        public async Task<IActionResult> Spor(int page = 1)

        {

            var result = urunRepository.GetByKateSpor().ToPagedList(page, 1);

            //List <Urun> urunler = new List<Urun>();
            //urunler = urunRepository.GetirHepsi();
            //await Task.Delay(10);

            return View(result);

        }

        public async Task<IActionResult> Aksesuar(int page = 1)

        {
            
            var result = urunRepository.GetByKateAksesuar().ToPagedList(page, 1);

            //List <Urun> urunler = new List<Urun>();
            //urunler = urunRepository.GetirHepsi();
            //await Task.Delay(10);

            return View(result);

        }
        public async Task<IActionResult> KisiselBakim(int page = 1)

        {
            
            var result = urunRepository.GetByKateKisisel().ToPagedList(page, 1);

            //List <Urun> urunler = new List<Urun>();
            //urunler = urunRepository.GetirHepsi();
            //await Task.Delay(10);

            return View(result);

        }

        public async Task<IActionResult> EvMutfak(int page = 1)

        {

            var result = urunRepository.GetByKateEvMutfak().ToPagedList(page, 1);

            //List <Urun> urunler = new List<Urun>();
            //urunler = urunRepository.GetirHepsi();
            //await Task.Delay(10);

            return View(result);

        }


        public async Task<IActionResult> Hobi(int page = 1)

        {

            var result = urunRepository.GetByKateHobi().ToPagedList(page, 1);

            //List <Urun> urunler = new List<Urun>();
            //urunler = urunRepository.GetirHepsi();
            //await Task.Delay(10);

            return View(result);

        }

        public async Task<IActionResult> Oyun(int page = 1)

        {

            var result = urunRepository.GetByKateOyun().ToPagedList(page, 1);

            //List <Urun> urunler = new List<Urun>();
            //urunler = urunRepository.GetirHepsi();
            //await Task.Delay(10);

            return View(result);

        }

        public async Task<IActionResult> EvElektronigi(int page = 1)

        {
            ViewData["data"] = "EvElektroniği";
            var result = urunRepository.EvElektronigi().ToPagedList(page, 1);

            //List <Urun> urunler = new List<Urun>();
            //urunler = urunRepository.GetirHepsi();
            //await Task.Delay(10);

            return View(result);

        }
        [HttpPost]
        public async Task<IActionResult> Search(string search1, string search2,int page = 1)
        {
            var search = urunRepository.AnaSayfaArama(search1, search2).ToPagedList(page, 2);
            return View(search);
          //  return RedirectToAction("Index", "Urunfiltreleme", search);
        }

        public IActionResult EkleSepet(int id)
        {
            var urunn= urunRepository.GetirId(id);
            _sepetrepository.SepeteEkle(urunn);
            TempData["bildirim"] = "Ürün sepete eklendi";
            return RedirectToAction("Index");
        }

        public IActionResult AddToCart(int UrunId)
        {
            //ViewBag.product = urunRepository.GetirId(productId);
            //return RedirectToAction("Index");
            var result = urunRepository.GetById(UrunId);
           
            ViewBag.product = urunRepository.GetById(UrunId);
            return View(result);

        }
        public IActionResult filtre(int id)
        {
            var urunn = urunRepository.filtrelemecheck(id);
            return RedirectToAction("Index");
        }

    }
}
