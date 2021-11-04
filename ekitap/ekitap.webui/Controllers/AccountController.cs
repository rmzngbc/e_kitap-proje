using System.Threading.Tasks;
using ekitap.webui.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ekitap.webui.Models;
using ekitap.webui.EmailServices;
using Newtonsoft.Json;
using ekitap.business.Abstract;

namespace ekitap.webui.Controllers
{   
    //form güvenliği:
    [AutoValidateAntiforgeryToken]
    public class AccountController:Controller
    {
        //-identity-usermanager-signmanager:
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;

        private IEmailSender _emailSender;

        private ISepetService _sepetService;





        //--yapıcı metod:
        public AccountController(UserManager<User> userManager,SignInManager<User> signInManager,IEmailSender emailSender,ISepetService sepetService)
        {
            _userManager=userManager;
            _signInManager=signInManager;
            _emailSender=emailSender;
            _sepetService=sepetService;
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

                //--yeni kayıt olan her bir user için sepetId oluştur:
                //email:ragebA@gmail.com,,rG2190+_
                _sepetService.InitializeSepet(user.Id);
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

        //--şifremi unuttum:
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string Email)
        {
            if(string.IsNullOrEmpty(Email))
            {
                return View();
            }

            var user = await _userManager.FindByEmailAsync(Email);

            if(user==null)
            {
                return View();
            }

            var code = await _userManager.GeneratePasswordResetTokenAsync(user);

            var url = Url.Action("ResetPassword","Account",new {
                userId = user.Id,
                token = code
            });

            //--email gönderme:
            await _emailSender.SendEmailAsync(Email,"Reset Password",$"Parolanızı yenilemek için linke <a href='https://localhost:5000{url}'>tıklayınız.</a>");

            CreateMessage("mail gönderme başarılı","warning");
            return RedirectToAction("Login","Account");



        }

        //--parola resetleme,maile gelecek:
        public IActionResult ResetPassword(string userId,string token)
        {
            if (userId==null || token==null)
            {
                return RedirectToAction("Index","Home");
                
            }

            var model=new ResetPasswordModel{Token=token};
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel model)
        {

            //-maile göre db den kayıt arama
            var user = await _userManager.FindByEmailAsync(model.Email);
            if(user==null)
            {   
                return RedirectToAction("Login","Account");
            }


            //eğer kayıt varsa,resetle
            var result = await _userManager.ResetPasswordAsync(user,model.Token,model.Password);

            if(result.Succeeded)
            {   CreateMessage("şifrenin başarı ile değiştirildi","warning");
                return RedirectToAction("Login","Account");
            }

            return View(model);
        }



        /*
        yetkisi olmayan user,ilgili linke  tıkladığında erişim sağlayamaz;
        accesdenied action metoduna yönlendirilir(Startup--cookies de ayarlandı)
        */
        public IActionResult AccessDenied()
        {
            return View();
        }


        //--bilgi mesajı method:

        private void CreateMessage(string message,string alerttype)
        {   
            var msg=new AlertMessage()
            {
                Message=message,
                AlertType=alerttype
            };

            TempData["message"]=JsonConvert.SerializeObject(msg);


        }


    }
}