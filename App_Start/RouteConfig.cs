using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI;

namespace WebBanHangOnline
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
             name: "Chitietdonhang",
             url: "Lich-Su-Don-Hang/p-{id}",
             defaults: new { controller = "Review", action = "detail", alias = UrlParameter.Optional },
             namespaces: new[] { "WebBanHangOnline.Controllers" }
             );

            routes.MapRoute(
            name: "Chitiettintuc",
            url: "{alias}-n{id}",
            defaults: new { controller = "News", action = "Detail", alias = UrlParameter.Optional },
            namespaces: new[] { "WebBanHangOnline.Controllers" }
        );
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
            name: "Tintuc",
            url: "Tin-tuc",
            defaults: new { controller = "News", action = "Index", alias = UrlParameter.Optional },
            namespaces: new[] { "WebBanHangOnline.Controllers" }
        );
            routes.MapRoute(
             name: "CheckOut",
             url: "thanh-toan-pro-vip",
             defaults: new { controller = "ShoppingCart", action = "CheckOutprovip", alias = UrlParameter.Optional },
             namespaces: new[] { "WebBanHangOnline.Controllers" }
         );
            routes.MapRoute(
            name: "ShoppingCart",
            url: "gio-hang",
            defaults: new { controller = "ShoppingCart", action = "Index", alias = UrlParameter.Optional },
            namespaces: new[] { "WebBanHangOnline.Controllers" }
              );
            routes.MapRoute(
              name: "Thanhtoan",
              url: "Account/Thanh-toan",
              defaults: new { controller = "CheckOut", action = "ShoppingCart", alias = UrlParameter.Optional },
              namespaces: new[] { "WebBanHangOnline.Controllers" }
              );
            routes.MapRoute(
              name: "Lichsudonhang",
              url: "Lich-Su-Don-Hang",
              defaults: new { controller = "Review", action = "Index", alias = UrlParameter.Optional },
              namespaces: new[] { "WebBanHangOnline.Controllers" }
              );
            routes.MapRoute(
              name: "Policy",
              url: "chinh-sach-bao-mat",
              defaults: new { controller = "Policy", action = "Index", alias = UrlParameter.Optional },
               namespaces: new[] { "WebBanHangOnline.Controllers" }
              );

            routes.MapRoute(
              name: "Terms",
              url: "dieu-khoan",
              defaults: new { controller = "Terms", action = "Index", alias = UrlParameter.Optional },
               namespaces: new[] { "WebBanHangOnline.Controllers" }
              );
            routes.MapRoute(
      name: "vnpay_return",
      url: "vnpay_return",
      defaults: new { controller = "ShoppingCart", action = "VnpayReturn", alias = UrlParameter.Optional },
      namespaces: new[] { "WebBanHangOnline.Controllers" }
  );
            routes.MapRoute(
              name: "Contact",
              url: "gioi-thieu",
              defaults: new { controller = "Contact", action = "Index", alias = UrlParameter.Optional },
               namespaces: new[] { "WebBanHangOnline.Controllers" }
              );
            routes.MapRoute(
             name: "CategoryProductList",
             url: "danh-muc-san-pham/{alias}-{id}",
             defaults: new { controller = "Product", action = "CatagoryProduct", id = UrlParameter.Optional },
               namespaces: new[] { "WebBanHangOnline.Controllers" }
             );
            routes.MapRoute(
              name: "CategoryProduct",
              url: "danh-muc-san-pham",
              defaults: new { controller = "Product", action = "Index", alias = UrlParameter.Optional },
              namespaces: new[] { "WebBanHangOnline.Controllers" }
              );

            routes.MapRoute(
               name: "ProductDetails",
               url: "chi-tiet/{alias}-p{id}",
               defaults: new { controller = "Product", action = "Details", id = UrlParameter.Optional },
               namespaces: new[] { "WebBanHangOnline.Controllers" }
           );

            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
               namespaces: new[] { "WebBanHangOnline.Controllers" }
        );
        }
    }
}
