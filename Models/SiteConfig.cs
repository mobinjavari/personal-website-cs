namespace MyWebApp.Models;

public static class SiteConfig
{
    // Site Information
    public static class Site
    {
        public static string Name => "Mobin Javari";
        public static string ThemeColor => "#238636";
    }

    // Meta Tags
    public static class Meta
    {
        public static string DefaultAuthor => Site.Name;
        public static string DefaultDescription => "وب‌سایت شخصی مبین جواری - توسعه‌دهنده وب";
        public static string DefaultKeywords => "موبین جواری، برنامه نویس، توسعه دهنده وب، طراح سایت";
        public static string DefaultRobots => "index, follow";
        public static string DefaultOgType => "website";
        public static string TwitterCardType => "summary_large_image";
    }

    // Content
    public static class Content
    {   
        public static class Header
        {
            public static List<MenuItem> MenuItems => new()
            {
                new() { Url = "/", Icon = "home", Title = "خانه", Desc = "صفحه اصلی سایت", Brand = "fas" },
                new() { Url = "/tools", Icon = "tools", Title = "ابزارها", Desc = "ابزارهای کاربردی", Brand = "fas" }
            };
        }

        public static class Hero
        {
            public static string Title => "توسعه‌دهنده خلاق و حرفه‌ای";
            public static string JobTitle => "توسعه‌دهنده Full-Stack";
            public static string Description => "متخصص در طراحی و توسعه وب‌سایت‌های مدرن و اپلیکیشن‌های موبایل";
            public static string ProfileImage => "https://images.unsplash.com/photo-1568602471122-7832951cc4c5?q=80&w=800&auto=format&fit=crop";

            public static List<CallToAction> Actions => new()
            {
                new() { Title = Contact.Title, Target = Contact.Id, IsPrimary = true },
                new() { Title = Projects.Title, Target = Projects.Id, IsPrimary = false }
            };

            public static List<NavItem> Navigation => new()
            {
                new() { Title = Projects.Subtitle, Target = Projects.Id },
                new() { Title = Skills.Subtitle, Target = Skills.Id },
                new() { Title = Contact.Subtitle, Target = Contact.Id }
            };
        }

        public static class Projects
        {
            public static string Id => "projects";
            public static string Title => "پروژه‌های من";
            public static string Subtitle => "نمونه کارها";
            public static string Description => "مجموعه‌ای از پروژه‌های برجسته که نشان‌دهنده تجربه و مهارت‌های من است";

            public static List<Project> Items => new()
            {
                new() {
                    Title = "پروژه هوش مصنوعی",
                    Description = "سیستم پردازش تصویر با یادگیری عمیق",
                    Image = "https://images.unsplash.com/photo-1555949963-aa79dcee981c?q=80&w=800&auto=format&fit=crop",
                    Technologies = new() { "Python", "TensorFlow" }
                },
                new() {
                    Title = "اپلیکیشن مدیریت مالی",
                    Description = "پلتفرم مدیریت امور مالی شخصی",
                    Image = "https://images.unsplash.com/photo-1460925895917-afdab827c52f?q=80&w=800&auto=format&fit=crop",
                    Technologies = new() { "React", "Firebase" }
                },
                new() {
                    Title = "پلتفرم آموزشی",
                    Description = "سیستم مدیریت یادگیری آنلاین",
                    Image = "https://images.unsplash.com/photo-1522202176988-66273c2fd55f?q=80&w=800&auto=format&fit=crop",
                    Technologies = new() { ".NET", "Vue.js" }
                }
            };
        }

        public static class Skills
        {
            public static string Id => "skills";
            public static string Title => "مهارت‌های من";
            public static string Subtitle => "تخصص‌ها";
            public static string Description => "مجموعه توانمندی‌های فنی و تخصصی که در طول سال‌ها کسب کرده‌ام";

            public static List<Skill> Items => new()
            {
                new() { Title = "Frontend", Progress = 90, Icon = "code" },
                new() { Title = "Backend", Progress = 75, Icon = "database" },
                new() { Title = "UI/UX", Progress = 85, Icon = "palette" },
                new() { Title = "DevOps", Progress = 70, Icon = "server" }
            };
        }

        public static class Contact
        {
            public static string Id => "contact";
            public static string Title => "تماس با من";
            public static string Subtitle => "ارتباط با من";
            public static string Description => "آماده همکاری در پروژه‌های جدید و پاسخگویی به سؤالات شما هستم";
            public static string Location => "تهران، ایران";
            public static string Email => "mobinjavari@duck.com";
        }

        public static class Tools
        {
            public static string Id => "tools";
            public static string Title => "ابزارها";
            public static string Description => "مجموعه ابزارهای کاربردی برای تسهیل کارهای روزمره";

            public static List<Tool> Items => new()
            {
                new() {
                    Id = "grade-calculator",
                    Title = "محاسبه نمره",
                    Description = "محاسبه رتبه دانش‌آموز بر اساس نمره",
                    Icon = "calculator",
                    IconBrand = "fas",
                    LastUpdate = DateTimeOffset.FromUnixTimeSeconds(1741592305).DateTime,
                    Status = ToolStatus.Active
                },
            };
        }

        public static class Footer
        {
            public static string AboutMe => "توسعه‌دهنده خلاق با تجربه در ساخت راه‌حل‌های دیجیتال و علاقه‌مند به تکنولوژی‌های نوین";
            
            public static List<SocialLink> SocialLinks => new()
            {
                new() { Url = "https://x.com/mobinjavari", Icon = "twitter", Color = "blue" },
                new() { Url = "https://t.me/mobinjavari", Icon = "telegram", Color = "blue" },
                new() { Url = "https://github.com/mobinjavari", Icon = "github", Color = "slate" }
            };

            public static List<UsefulLink> UsefulLinks => new()
            {
                new() { Url = "https://google.com", Title = "گوگل" },
                new() { Url = "https://microsoft.com", Title = "مایکروسافت" }
            };
        }
    }
}

// Models
public record SocialLink
{
    public required string Url { get; init; }
    public required string Icon { get; init; }
    public required string Color { get; init; }
}

public record MenuItem
{
    public required string Url { get; init; }
    public required string Icon { get; init; }
    public required string Title { get; init; }
    public required string Desc { get; init; }
    public required string Brand { get; init; }
}

public record UsefulLink
{
    public required string Url { get; init; }
    public required string Title { get; init; }
}

public record CallToAction
{
    public required string Title { get; init; }
    public required string Target { get; init; }
    public required bool IsPrimary { get; init; }
}

public record NavItem
{
    public required string Title { get; init; }
    public required string Target { get; init; }
}

public record Project
{
    public required string Title { get; init; }
    public required string Description { get; init; }
    public required string Image { get; init; }
    public required List<string> Technologies { get; init; }
}

public record Skill
{
    public required string Title { get; init; }
    public required int Progress { get; init; }
    public required string Icon { get; init; }
}

public record Tool
{
    public required string Id { get; init; }
    public required string Title { get; init; }
    public required string Description { get; init; }
    public required string Icon { get; init; }
    public required string IconBrand { get; init; }
    public required DateTime LastUpdate { get; init; }
    public required ToolStatus Status { get; init; }
}

public enum ToolStatus
{
    Active,
    Maintenance,
    Development,
    Deprecated
} 