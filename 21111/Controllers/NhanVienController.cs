
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using models;


namespace controllers
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
            List<NhanVien> list = context.nhanViens.Include(nv=>nv.chucVu).ToList();
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
            var nv = context.nhanViens.Find(id);
            return View(nv);
        }

     
        public IActionResult Update(NhanVien nhanVien)
        {
            context.nhanViens.Update(nhanVien);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Create(NhanVien nhanVien)
        {
            Console.WriteLine(nhanVien);
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
