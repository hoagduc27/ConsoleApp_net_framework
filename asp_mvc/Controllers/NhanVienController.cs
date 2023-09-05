using asp_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace asp_mvc.Controllers
{
    public class NhanVienController : Controller
    {
        public Context context;

        public NhanVienController(Context context)
        {
            this.context = context;
        }


        public IActionResult Index()
        {
            List<NhanVien> list = context.nhanViens.Include(nv => nv.chucVu).ToList();
            return View(list);
        }

        public IActionResult Delete(int id)
        {
            string m;
            try
            {
                context.nhanViens.Remove(context.nhanViens.Find(id));
                context.SaveChanges();
                return Json(new { status = true });
            }
            catch (Exception e)
            {
                m = e.Message;
                throw;
            }
            return Json(new { status = false, error = m });
        }


        public IActionResult Detail(int id)
        {
            ViewBag.listCv = context.chucVus.ToList();
            var nv = context.nhanViens.Find(id);
            return View(nv);
        }


        public IActionResult Update(NhanVien nhanVien)
        {
            context.nhanViens.Update(nhanVien);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Create(NhanVien nhanVien)
        {
            Console.WriteLine(nhanVien.chucVuId+"111");
            context.nhanViens.Add(nhanVien);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult CreateView()
        {
            ViewBag.listCv = context.chucVus.ToList();
            return View("Create");
        }
    }
}
