🎯 Get Information with If - C# Conditional Input System
یک برنامه کنسول پیشرفته C# برای دریافت اطلاعات کاربر با سیستم شرطی - تمرین کامل if/else و اعتبارسنجی

https://img.shields.io/badge/C%2523-239120?style=for-the-badge&logo=c-sharp&logoColor=white
https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white
https://img.shields.io/badge/Conditional-If%252FElse%2520Logic-blue?style=for-the-badge
https://img.shields.io/badge/GitHub-Open%2520Source-181717?style=for-the-badge&logo=github

https://img.shields.io/github/stars/programmerdrn/Get-information-with-if
https://img.shields.io/github/forks/programmerdrn/Get-information-with-if
https://img.shields.io/github/issues/programmerdrn/Get-information-with-if

✨ ویژگی‌ها
✅ سیستم شرطی پیشرفته: if/else, switch case, nested conditions

✅ اعتبارسنجی هوشمند: بررسی شرایط مختلف ورودی

✅ منوهای تعاملی: انتخاب‌های چندگانه کاربر

✅ مدیریت خطا: هندل کردن تمام حالت‌های غیرمنتظره

✅ کدهای آموزشی: الگوهای مختلف شرطی

🏗️ ساختار پروژه
text
Get-information-with-if/
├── Program.cs                 # فایل اصلی با منطق شرطی
├── Models/
│   ├── UserProfile.cs        # پروفایل کاربر
│   └── ValidationResult.cs   # نتیجه اعتبارسنجی
├── Services/
│   ├── ConditionalService.cs # سرویس‌های شرطی
│   ├── MenuService.cs        # مدیریت منوها
│   └── ValidationService.cs  # اعتبارسنجی پیشرفته
└── README.md
🚀 نحوه اجرا
پیش‌نیازها
.NET 6.0 یا بالاتر

اجرای پروژه
bash
# کلون کردن ریپوزیتوری
git clone https://github.com/programmerdrn/Get-information-with-if.git
cd Get-information-with-if

# اجرای پروژه
dotnet run
💡 مثال‌های شرطی در پروژه
۱. شرط ساده if/else
csharp
int age = GetAgeFromUser();

if (age >= 18)
{
    Console.WriteLine("✅ شما بزرگسال هستید");
    // دسترسی به features کامل
}
else
{
    Console.WriteLine("🔞 شما نوجوان هستید");
    // دسترسی محدود
}
۲. شرط else if زنجیره‌ای
csharp
int score = GetUserScore();

if (score >= 90)
{
    Console.WriteLine("🏆 Grade: A - عالی!");
}
else if (score >= 80)
{
    Console.WriteLine("✅ Grade: B - خوب");
}
else if (score >= 70)
{
    Console.WriteLine("⚠️ Grade: C - قابل قبول");
}
else
{
    Console.WriteLine("❌ Grade: F - مردود");
}
۳. شرط تو در تو (Nested)
csharp
bool isRegistered = CheckUserRegistration();
bool hasSubscription = CheckUserSubscription();

if (isRegistered)
{
    if (hasSubscription)
    {
        Console.WriteLine("🎉 به محتوای پریمیوم خوش آمدید!");
    }
    else
    {
        Console.WriteLine("💡 می‌توانید اشتراک تهیه کنید");
    }
}
else
{
    Console.WriteLine("📝 لطفا ابتدا ثبت نام کنید");
}
۴. Switch Case برای منوها
csharp
Console.WriteLine("🎯 لطفا گزینه مورد نظر را انتخاب کنید:");
Console.WriteLine("1. مشاهده پروفایل");
Console.WriteLine("2. ویرایش اطلاعات");
Console.WriteLine("3. تنظیمات");
Console.WriteLine("4. خروج");

string choice = Console.ReadLine();

switch (choice)
{
    case "1":
        ShowUserProfile();
        break;
    case "2":
        EditUserInfo();
        break;
    case "3":
        ShowSettings();
        break;
    case "4":
        ExitApplication();
        break;
    default:
        Console.WriteLine("❌ گزینه نامعتبر!");
        break;
}
🎯 سناریوهای کاربردی
سیستم ثبت نام شرطی
csharp
public void RegisterUser()
{
    string username = GetUsername();
    string email = GetEmail();
    int age = GetAge();
    
    if (string.IsNullOrEmpty(username))
    {
        Console.WriteLine("❌ نام کاربری نمی‌تواند خالی باشد");
        return;
    }
    
    if (!IsValidEmail(email))
    {
        Console.WriteLine("❌ فرمت ایمیل نامعتبر است");
        return;
    }
    
    if (age < 13)
    {
        Console.WriteLine("❌ سن شما برای ثبت نام کافی نیست");
        return;
    }
    
    // اگر همه شرط‌ها OK باشند
    Console.WriteLine("✅ ثبت نام با موفقیت انجام شد!");
    CreateUserAccount(username, email, age);
}
سیستم سطح‌بندی کاربر
csharp
public string DetermineUserLevel(int points)
{
    if (points >= 1000)
    {
        return "🌟 کاربر الماس";
    }
    else if (points >= 500)
    {
        return "⭐ کاربر طلا";
    }
    else if (points >= 100)
    {
        return "🔥 کاربر نقره";
    }
    else if (points >= 50)
    {
        return "👍 کاربر برنز";
    }
    else
    {
        return "👋 کاربر تازه وارد";
    }
}
🔧 قابلیت‌های پیشرفته
اعتبارسنجی ترکیبی
csharp
public bool ValidateUserInput(string username, string password, int age)
{
    // چندین شرط با AND/OR
    if (!string.IsNullOrEmpty(username) && 
        !string.IsNullOrEmpty(password) && 
        password.Length >= 8 && 
        age >= 18)
    {
        return true;
    }
    
    return false;
}
شرط‌های مختصر (Ternary)
csharp
string status = (age >= 18) ? "بزرگسال" : "نوجوان";
string accessLevel = (isPremium) ? "پریمیوم" : "معمولی";
🧪 تست منطق شرطی
csharp
// تست سناریوهای مختلف
TestConditionalLogic(17, "نوجوان");   // ✅
TestConditionalLogic(25, "بزرگسال");  // ✅
TestConditionalLogic(0, "نامعتبر");   // ✅
🎓 اهداف آموزشی
✅ درک عمیق if/else/else if

✅ کار با switch case

✅ شرط‌های تو در تو

✅ عملگرهای منطقی (&&, ||, !)

✅ الگوهای تصمیم‌گیری

🤝 مشارکت در توسعه
ریپو را Fork کنید

Branch جدید ایجاد کنید (git checkout -b feature/conditional-enhancement)

تغییرات را Commit کنید (git commit -m 'Add new conditional logic')

Branch را Push کنید (git push origin feature/conditional-enhancement)

Pull Request ایجاد کنید

📄 لایسنس
این پروژه تحت لایسنس MIT منتشر شده است.

👨‍💻 توسعه‌دهنده
[programmerdrn - GitHub Profile
](https://github.com/programmerdrn)
⭐ اگر این پروژه آموزشی برایتان مفید بود، حتما به آن Star بدهید!

💬 پشتیبانی
📧 ایجاد Issue در گیتهاب برای گزارش باگ یا پیشنهاد

🔄 پیشنهاد سناریوهای شرطی جدید
