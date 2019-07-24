using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FurnitureStore.Models;
using System.Web.UI;
using System.IO;
using Microsoft.AspNet.Identity;

namespace FurnitureStore.Controllers
{
    public class HomeController : Controller
    {
        private ProductContext db = new ProductContext();

        private string GetCount(List<ShopingCart> ShopingCarts)
        {
            short sum = 0;
            foreach (ShopingCart s in ShopingCarts)
            {
                sum += s.count;
            }
            string count = sum.ToString();
            return count;
        }
        private bool ClientControl(Client newClient)
        {
            bool clientControl = false;
            foreach (Client c in db.Clients)
            {
                if (newClient.UserName == c.UserName)
                {
                    clientControl = true;
                }
            }
            return clientControl;
        }
        [HttpGet]
        public ActionResult Index()
        {
            var allPromo = db.Promoes.ToList<Promo>();
            ViewBag.Promoes = allPromo;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult LivingRoom()
        {
            var allSubCategories = db.SubCategories.ToList<SubCategory>();
            var allLivingRoom = new List<SubCategory>();
            foreach (SubCategory s in allSubCategories)
            {
                if (s.CategoryID == 1)
                {
                    allLivingRoom.Add(s);
                }
            }
            ViewBag.LivingRoom = allLivingRoom;
            return View();
        }

        public ActionResult DiningRoom()
        {
            var allSubCategories = db.SubCategories.ToList<SubCategory>();
            var allDiningRoom = new List<SubCategory>();
            foreach (SubCategory s in allSubCategories)
            {
                if (s.CategoryID == 2)
                {
                    allDiningRoom.Add(s);
                }
            }
            ViewBag.DiningRoom = allDiningRoom;
            return View();
        }

        public ActionResult BadRoom()
        {
            var allSubCategories = db.SubCategories.ToList<SubCategory>();
            var allBadRoom = new List<SubCategory>();
            foreach (SubCategory s in allSubCategories)
            {
                if (s.CategoryID == 3)
                {
                    allBadRoom.Add(s);
                }
            }
            ViewBag.BadRoom = allBadRoom;
            return View();
        }

        public ActionResult GardenFurniture()
        {
            var allSubCategories = db.SubCategories.ToList<SubCategory>();
            var allGardenFurniture = new List<SubCategory>();
            foreach (SubCategory s in allSubCategories)
            {
                if (s.CategoryID == 4)
                {
                    allGardenFurniture.Add(s);
                }
            }
            ViewBag.GardenFurniture = allGardenFurniture;
            return View();
        }

        public ActionResult InteriorItems()
        {
            var allSubCategories = db.SubCategories.ToList<SubCategory>();
            var allInteriorItems = new List<SubCategory>();
            foreach (SubCategory s in allSubCategories)
            {
                if (s.CategoryID == 5)
                {
                    allInteriorItems.Add(s);
                }
            }
            ViewBag.InteriorItems = allInteriorItems;
            return View();
        }

        public ActionResult Sofas()
        {
            var allProducts = db.Products.ToList<Product>();
            var allSofas = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 2)
                {
                    allSofas.Add(p);
                }
            }
            ViewBag.Sofas = allSofas;
            return View();
        }

        public ActionResult Sofa_beds()
        {
            var allProducts = db.Products.ToList<Product>();
            var allSofa_beds = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 4)
                {
                    allSofa_beds.Add(p);
                }
            }
            ViewBag.Sofa_beds = allSofa_beds;
            return View();
        }

        public ActionResult Armchairs()
        {
            var allProducts = db.Products.ToList<Product>();
            var allArmchairs = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 5)
                {
                    allArmchairs.Add(p);
                }
            }
            ViewBag.Armchairs = allArmchairs;
            return View();
        }

        public ActionResult Coffee_tables()
        {
            var allProducts = db.Products.ToList<Product>();
            var allCoffee_tables = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 6)
                {
                    allCoffee_tables.Add(p);
                }
            }
            ViewBag.Coffee_tables = allCoffee_tables;
            return View();
        }

        public ActionResult TV_stands()
        {
            var allProducts = db.Products.ToList<Product>();
            var allTV_stands = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 7)
                {
                    allTV_stands.Add(p);
                }
            }
            ViewBag.TV_stands = allTV_stands;
            return View();
        }


        public ActionResult Commodes()
        {
            var allProducts = db.Products.ToList<Product>();
            var allCommodes = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 8)
                {
                    allCommodes.Add(p);
                }
            }
            ViewBag.Commodes = allCommodes;
            return View();
        }

        public ActionResult Sections_and_shelves()
        {
            var allProducts = db.Products.ToList<Product>();
            var allSections_and_shelves = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 9)
                {
                    allSections_and_shelves.Add(p);
                }
            }
            ViewBag.Sections_and_shelves = allSections_and_shelves;
            return View();
        }

        public ActionResult Stuff()
        {
            var allProducts = db.Products.ToList<Product>();
            var allStuff = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 10)
                {
                    allStuff.Add(p);
                }
            }
            ViewBag.Stuff = allStuff;
            return View();
        }

        public ActionResult Dining_tables()
        {
            var allProducts = db.Products.ToList<Product>();
            var allDiningTables = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 11)
                {
                    allDiningTables.Add(p);
                }
            }
            ViewBag.DiningTables = allDiningTables;
            return View();
        }

        public ActionResult Dining_chairs()
        {
            var allProducts = db.Products.ToList<Product>();
            var allDiningChairs = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 12)
                {
                    allDiningChairs.Add(p);
                }
            }
            ViewBag.DiningChairs = allDiningChairs;
            return View();
        }

        public ActionResult Dining_room_sections_and_shelves()
        {
            var allProducts = db.Products.ToList<Product>();
            var allDiningRoomSectionsAndShelves = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 13)
                {
                    allDiningRoomSectionsAndShelves.Add(p);
                }
            }
            ViewBag.DiningRoomSectionsAndShelves = allDiningRoomSectionsAndShelves;
            return View();
        }

        public ActionResult Dining_room_commodes()
        {
            var allProducts = db.Products.ToList<Product>();
            var allDiningRoomCommodes = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 14)
                {
                    allDiningRoomCommodes.Add(p);
                }
            }
            ViewBag.DiningRoomCommodes = allDiningRoomCommodes;
            return View();
        }

        public ActionResult Dining_room_stuff()
        {
            var allProducts = db.Products.ToList<Product>();
            var allDiningRoomStuff = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 15)
                {
                    allDiningRoomStuff.Add(p);
                }
            }
            ViewBag.DiningRoomStuff = allDiningRoomStuff;
            return View();
        }

        public ActionResult Bads()
        {
            var allProducts = db.Products.ToList<Product>();
            var allBads = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 16)
                {
                    allBads.Add(p);
                }
            }
            ViewBag.Bads = allBads;
            return View();
        }

        public ActionResult Couches()
        {
            var allProducts = db.Products.ToList<Product>();
            var allCouches = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 17)
                {
                    allCouches.Add(p);
                }
            }
            ViewBag.Couches = allCouches;
            return View();
        }

        public ActionResult Mattresses()
        {
            var allProducts = db.Products.ToList<Product>();
            var allMattresses = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 18)
                {
                    allMattresses.Add(p);
                }
            }
            ViewBag.Mattresses = allMattresses;
            return View();
        }

        public ActionResult Mattress_covers()
        {
            var allProducts = db.Products.ToList<Product>();
            var allMattressCovers = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 19)
                {
                    allMattressCovers.Add(p);
                }
            }
            ViewBag.MattressCovers = allMattressCovers;
            return View();
        }

        public ActionResult Chests()
        {
            var allProducts = db.Products.ToList<Product>();
            var allChests = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 20)
                {
                    allChests.Add(p);
                }
            }
            ViewBag.Chests = allChests;
            return View();
        }

        public ActionResult Badroom_commodes()
        {
            var allProducts = db.Products.ToList<Product>();
            var allBadroomCommodes = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 21)
                {
                    allBadroomCommodes.Add(p);
                }
            }
            ViewBag.BadroomCommodes = allBadroomCommodes;
            return View();
        }

        public ActionResult Wardrobes()
        {
            var allProducts = db.Products.ToList<Product>();
            var allWardrobes = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 22)
                {
                    allWardrobes.Add(p);
                }
            }
            ViewBag.Wardrobes = allWardrobes;
            return View();
        }

        public ActionResult Blankets_and_pillows()
        {
            var allProducts = db.Products.ToList<Product>();
            var allBlanketsAndPillows = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 23)
                {
                    allBlanketsAndPillows.Add(p);
                }
            }
            ViewBag.BlanketsAndPillows = allBlanketsAndPillows;
            return View();
        }

        public ActionResult Summer_tables()
        {
            var allProducts = db.Products.ToList<Product>();
            var allSummerTables = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 24)
                {
                    allSummerTables.Add(p);
                }
            }
            ViewBag.SummerTables = allSummerTables;
            return View();
        }

        public ActionResult Summer_chairs()
        {
            var allProducts = db.Products.ToList<Product>();
            var allSummerChairs = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 25)
                {
                    allSummerChairs.Add(p);
                }
            }
            ViewBag.SummerChairs = allSummerChairs;
            return View();
        }

        public ActionResult Summer_sofas()
        {
            var allProducts = db.Products.ToList<Product>();
            var allSummerSofas = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 26)
                {
                    allSummerSofas.Add(p);
                }
            }
            ViewBag.SummerSofas = allSummerSofas;
            return View();
        }

        public ActionResult Pillows_for_chairs()
        {
            var allProducts = db.Products.ToList<Product>();
            var allPillowsForChairs = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 27)
                {
                    allPillowsForChairs.Add(p);
                }
            }
            ViewBag.PillowsForChairs = allPillowsForChairs;
            return View();
        }

        public ActionResult Caponies()
        {
            var allProducts = db.Products.ToList<Product>();
            var allCaponies = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 28)
                {
                    allCaponies.Add(p);
                }
            }
            ViewBag.Caponies = allCaponies;
            return View();
        }

        public ActionResult Interrior_stuff()
        {
            var allProducts = db.Products.ToList<Product>();
            var allInterriorStuff = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 29)
                {
                    allInterriorStuff.Add(p);
                }
            }
            ViewBag.InterriorStuff = allInterriorStuff;
            return View();
        }

        public ActionResult Carpets()
        {
            var allProducts = db.Products.ToList<Product>();
            var allCarpets = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 30)
                {
                    allCarpets.Add(p);
                }
            }
            ViewBag.Carpets = allCarpets;
            return View();
        }

        public ActionResult Buskets()
        {
            var allProducts = db.Products.ToList<Product>();
            var allBuskets = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 31)
                {
                    allBuskets.Add(p);
                }
            }
            ViewBag.Buskets = allBuskets;
            return View();
        }

        public ActionResult Pedestals()
        {
            var allProducts = db.Products.ToList<Product>();
            var allPedestals = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 32)
                {
                    allPedestals.Add(p);
                }
            }
            ViewBag.Pedestals = allPedestals;
            return View();
        }

        public ActionResult Pictures()
        {
            var allProducts = db.Products.ToList<Product>();
            var allPictures = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 33)
                {
                    allPictures.Add(p);
                }
            }
            ViewBag.Pictures = allPictures;
            return View();
        }

        public ActionResult Plaids_and_bedspreads()
        {
            var allProducts = db.Products.ToList<Product>();
            var allPlaidsAndBedspreads = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 34)
                {
                    allPlaidsAndBedspreads.Add(p);
                }
            }
            ViewBag.PlaidsAndBedspreads = allPlaidsAndBedspreads;
            return View();
        }

        public ActionResult Decorative_pillows()
        {
            var allProducts = db.Products.ToList<Product>();
            var allDecorativePillows = new List<Product>();
            foreach (Product p in allProducts)
            {
                if (p.SubCategoryID == 35)
                {
                    allDecorativePillows.Add(p);
                }
            }
            ViewBag.DecorativePillows = allDecorativePillows;
            return View();
        }

        public ActionResult ProductSearch(string name)
        {
            var allProducts = db.Products.Where(p => p.ProductName.Contains(name)).ToList();
            if (allProducts.Count == 0)
            {
                return Content("We tried very hard, but could not find it!");
            }
            ViewBag.SearchingResults = allProducts;
            return View();
        }
        [Authorize]
        [HttpGet]
        public ActionResult ClientDetails()
        {
            Client client = new Client();
            foreach (Client c in db.Clients)
            {
                if (c.UserName == User.Identity.GetUserName())
                {
                    client = c;
                }
            }
            //ViewBag.ClientDetails = client;
            return View(client);
        }

        [Authorize]
        [HttpGet]
        public ActionResult CreateProfile()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult CreateProfile(Client newClient)
        {
            newClient.UserName = User.Identity.GetUserName();
            if (ClientControl(newClient) == true)
            {
                return Content("You allready have a profile");
            }
            else
            {
                db.Clients.Add(newClient);
                db.SaveChanges();
                return RedirectToAction("ClientDetails");
            }
        }

        public ActionResult EditProfile(int id)
        {
            Client client = db.Clients.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditProfile(Client client)
        {
            client.UserName = User.Identity.GetUserName();
            if (ModelState.IsValid)
            {
                db.Entry(client).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ClientDetails");
            }
            return View(client);
        }

        public ActionResult AddShopingCart(short? id)
        {
            Product product = db.Products.Find(id);
            short count = 1;
            if (Session["busket"] == null)
            {
                Busket busketTm = new Busket();
                ShopingCart shopingCart = new ShopingCart();
                shopingCart.product = product;
                shopingCart.count = count;
                shopingCart.sum = product.ProductPrice * count;
                busketTm.ShopingCarts.Add(shopingCart);
                Session["busket"] = busketTm;
            }
            else
            {
                int tempCount = 0;
                Busket busketTemp = (Busket)Session["busket"];
                foreach (ShopingCart s in busketTemp.ShopingCarts)
                {
                    if (s.product.ProductID == product.ProductID)
                    {
                        s.count += 1;
                        tempCount += 1;
                        s.sum = s.product.ProductPrice * s.count;
                        break;
                    }
                }
                if (tempCount == 0)
                {
                    ShopingCart shopingCart = new ShopingCart();
                    shopingCart.product = product;
                    shopingCart.count = count;
                    shopingCart.sum = product.ProductPrice * count;
                    busketTemp.ShopingCarts.Add(shopingCart);
                }
                Session["busket"] = busketTemp;
            }
            Busket busketTmp = (Busket)Session["busket"];
            string countPr = GetCount(busketTmp.ShopingCarts);
            Session["count"] = countPr;
            SubCategory subCategory = db.SubCategories.Find(product.SubCategoryID);
            string scName = subCategory.SubCategoryName;
            return RedirectToAction(scName, controllerName:"Home");
        }

        public ActionResult ShopingCartsView()
        {
            if(Session["busket"] != null)
            { 
            Busket busketTmp = new Busket();
            busketTmp = (Busket)Session["busket"];
            var allCarts = busketTmp.ShopingCarts.ToList();
            ViewBag.ShopingCarts = allCarts;
            return View();
            }
            else
            {
                return Content("You didn't choose anything!");
            }
        }

        public ActionResult RemoveFromShopingCart(short? id)
        {
            Busket busketTemp = (Busket)Session["busket"];
            Product product = db.Products.Find(id);
            foreach (ShopingCart s in busketTemp.ShopingCarts)
            {
                if (s.product.ProductID == product.ProductID && s.count > 1)
                {
                    s.count -= 1;
                    s.sum = s.product.ProductPrice * s.count;
                }
                else if (s.product.ProductID == product.ProductID && s.count == 1)
                {
                    busketTemp.ShopingCarts.Remove(s);
                    break;
                }
            }
            Session["busket"] = busketTemp;
            Busket busketTmp = (Busket)Session["busket"];
            string countPr = GetCount(busketTmp.ShopingCarts);
            Session["count"] = countPr;
            SubCategory subCategory = db.SubCategories.Find(product.SubCategoryID);
            string scName = subCategory.SubCategoryName;
            return RedirectToAction("ShopingCartsView", controllerName: "Home");
        }

        [Authorize]
        [HttpGet]
        public ActionResult CreateOrder()
        {
            Client client = new Client();
            foreach (Client c in db.Clients)
            {
                if (c.UserName == User.Identity.GetUserName())
                {
                    client = c;
                }
            }
            return View(client);
        }

        [Authorize]
        [HttpPost]
        public ActionResult CreateOrder(Delivery newDelivery)
        {
            newDelivery.DeliveryDate = DateTime.Now.AddDays(2);
            newDelivery.DeliveryPrice = 30;
            db.Deliveries.Add(newDelivery);
            db.SaveChanges();

            Order order = new Order();
            Client client = new Client();
            foreach(Client c in db.Clients)
            {
                if(c.UserName == User.Identity.GetUserName())
                {
                    client = c;
                }
            }
            order.DeliveryID = newDelivery.DeliveryID;
            order.ClientID = client.ClientID;
            order.OrderDate = DateTime.Now;
            order.OrderSum = 0;
            Busket busketTmp = (Busket)Session["busket"];
            foreach(ShopingCart s in busketTmp.ShopingCarts)
            {
                order.OrderSum += s.sum;
            }
            db.Orders.Add(order);
            db.SaveChanges();

            foreach (ShopingCart s in busketTmp.ShopingCarts)
            {
                OrderProduct orderProduct = new OrderProduct();
                orderProduct.OrderID = order.OrderID;
                orderProduct.ProductID = s.product.ProductID;
                orderProduct.ProductCount = s.count;
                db.OrderProducts.Add(orderProduct);
                db.SaveChanges();
            }
            Session["busket"] = null;
            Session["count"] = 0;
            return RedirectToAction("GetOrders", controllerName: "Home");
        }

        [Authorize]
        public ActionResult GetOrders()
        {
            Client client = new Client();
            foreach(Client c in db.Clients)
            {
                if(c.UserName == User.Identity.GetUserName())
                {
                    client = c;
                }
            }

            var allOrders = db.Orders.ToList();
            var allClientOrders = new List<Order>();
            foreach(Order o in db.Orders)
            {
                if(o.ClientID == client.ClientID)
                {
                    allClientOrders.Add(o);
                }
            }
            ViewBag.ClientOrders = allClientOrders;
            return View();
        }
   
        public ActionResult Information()
        {
            return View();
        }
    }
}