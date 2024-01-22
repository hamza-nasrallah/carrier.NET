using Carrier.Data;
using Carrier.Models;
using Microsoft.AspNetCore.Mvc;

namespace Carrier.Controllers
{
    public class CarrierController : Controller
    {
        private ApplicationDbContext _context;
        public CarrierController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            return View(_context.CarrierTable.ToList());
        }




        //start edit
        
                public IActionResult Edit(int? id)
                {
                    if (id == null || _context.CarrierTable == null)
                    {
                        return NotFound();
                    }


                    var doos = _context.CarrierTable.FirstOrDefault(x => x.id == id);
                    if (doos == null)
                    {
                        return NotFound();
                    }



                    return View(doos);
                }
                [HttpPost]
                public IActionResult Edit(int id, CarrierCategory cc)
                {
                    if (ModelState.IsValid)
                    {
                        try
                        {
                            _context.Update(cc);
                            _context.SaveChanges();
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                    return RedirectToAction("Index");
                }



                //end edit


                //start delete

                public IActionResult Delete(int? id)
                {
                    if (id == null || _context.CarrierTable == null)
                    {
                        return NotFound();

                    }
                    var doos = _context.CarrierTable.FirstOrDefault(x => x.id == id);
                    if (doos == null)
                    {
                        return NotFound();
                    }
                    return View(doos);


                }

                //start post delete
                [HttpPost]
                [ActionName("Delete")]
                public IActionResult DeleteCo(int? id)
                {
                    if (id == null || _context.CarrierTable == null)
                    {
                        return NotFound();

                    }
                    var doos = _context.CarrierTable.FirstOrDefault(x => x.id == id);
                    if (doos == null)
                    {
                        return NotFound();
                    }
                    _context.CarrierTable.Remove(doos);
                    _context.SaveChanges();

                    return RedirectToAction("Index");
                }
                //end delete

                //start detalis
               
                //end detalis


                //start create
                public IActionResult create()
                {
                    return PartialView();
                }

                [HttpPost]
                public IActionResult create(CarrierCategory cc)
                {
                    if (ModelState.IsValid)
                    {

                        _context.CarrierTable.Add(cc);

                        _context.SaveChanges();
                        return RedirectToAction("Index");



                    }
                    return RedirectToAction("Index");
                }
                //end create
          
    }

}

