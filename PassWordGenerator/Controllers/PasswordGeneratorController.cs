using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PassWordGenerator.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PassWordGenerator.Controllers
{
    public class PasswordGeneratorController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            PassWordGeneratorViewModel pass = new PassWordGeneratorViewModel();
            return View(pass);
        }
        public IActionResult PassWord(int PassWordLenght, bool UpperCase, bool SpecialCaractor)
        {
            PassWordGeneratorViewModel model = new PassWordGeneratorViewModel();
            Random random = new Random();

            string useUpperCase = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string useSpecialCaractors = "!@#$%^&*()_+œ∑´®†¥¨ˆøπåß∂ƒ©˙∆˚¬Ω≈ç√∫˜µ≤≥÷æ";
            string defaultpassword = "qwertyuiopasdfghjklzxcvbnm1234567890";
            string usingPassWord = "";
            string result = "";

            if (UpperCase && SpecialCaractor)
            {
                usingPassWord = defaultpassword + useUpperCase + useSpecialCaractors;
            }
            else if (UpperCase)
            {
                usingPassWord = defaultpassword + useUpperCase;
            }
            else if (SpecialCaractor)
            {
                usingPassWord = defaultpassword + useSpecialCaractors;
            }
            else
            {
                usingPassWord = defaultpassword;
            }
             
            for (int i =0; i < PassWordLenght; i++)
            {
                int letterValue = random.Next(0, usingPassWord.Length);
                char letter = usingPassWord[letterValue];
                result += letter;

            }
            model.PassResult = result;
            return View("Index",model);
        }
        
    }
}

