using System.Threading.Tasks;
using ekitap.webui.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ekitap.webui.Models;

namespace ekitap.webui.Controllers
{
    public class AccountController:Controller
    {
        //-identity-usermanager-signmanager:
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;

        //--yapıcı metod:
        public AccountController(UserManager<User> userManager,SignInManager<User> signInManager)
        {
            _userManager=userManager;
            _signInManager=signInManager;
        }


        
        //--login sayfası:
        public IActionResult Login(string ReturnUrl=null)
        {
            return View(new LoginModel()
            {
                ReturnUrl=ReturnUrl
            });
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {

            //--cleint validationu geçtikten soran,db de ilgili email varmı:
            var user=await _userManager.FindByEmailAsync(model.Email);

            if(user==null)
            {
                ModelState.AddModelError("","bu email ile daha önce hesap oluşturulmamış");
                return View(model);
            }

            //--eğer db de email varsa login işlemi yap,cookie oluştur:

            var result=await _signInManager.PasswordSignInAsync(user,model.Password,true,false);
            if (result.Succeeded)
            {
                return Redirect(model.ReturnUrl??"~/");
                
            }

            ModelState.AddModelError("","parola hatalı...");
            return View(model);


        }



        //--user kayıt işlemleri:
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            /*--eğer client validation geçerli ise,enetitleri user nesnesine;
                aktardık.
            */
            var user=new User()
            {
                FirstName=model.FirstName,
                LastName=model.LastName,
                UserName=model.UserName,
                Email=model.Email
            };

            //password hasleme:
            var result=await _userManager.CreateAsync(user,model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Login","Account");
            }

            //--eğer başarılı değilse,
            ModelState.AddModelError("","parola en az 6 karakter,rakam,küçük-büyük harf ve alafanümerik karakterlerden oluşmak zorundadır.");
            return View(model);


        }

        //--logout butonuna tıkladıktan sonra,cookie tarayıcıdan silienecek:
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("index","Home");

        }


    }
}